using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using FluffyUnderware.Curvy.Generator;
using FluffyUnderware.Curvy.ThirdParty.LibTessDotNet;
using FluffyUnderware.DevTools;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Utility;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F4F6C", Offset = "0x6F4F6C")]
internal sealed class <>f__AnonymousType0<<A>j__TPar, <B>j__TPar, <C>j__TPar, <D>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6F790C", Offset = "0x6F790C")]
	private readonly <A>j__TPar <A>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6F7920", Offset = "0x6F7920")]
	private readonly <B>j__TPar <B>i__Field;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6F7934", Offset = "0x6F7934")]
	private readonly <C>j__TPar <C>i__Field;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6F7948", Offset = "0x6F7948")]
	private readonly <D>j__TPar <D>i__Field;

	[Token(Token = "0x17000001")]
	public <A>j__TPar A
	{
		[Token(Token = "0x6000001")]
		get
		{
			return (<A>j__TPar)null;
		}
	}

	[Token(Token = "0x17000002")]
	public <B>j__TPar B
	{
		[Token(Token = "0x6000002")]
		get
		{
			return (<B>j__TPar)null;
		}
	}

	[Token(Token = "0x17000003")]
	public <C>j__TPar C
	{
		[Token(Token = "0x6000003")]
		get
		{
			return (<C>j__TPar)null;
		}
	}

	[Token(Token = "0x17000004")]
	public <D>j__TPar D
	{
		[Token(Token = "0x6000004")]
		get
		{
			return (<D>j__TPar)null;
		}
	}

	[Token(Token = "0x6000005")]
	[DebuggerHidden]
	public <>f__AnonymousType0(<A>j__TPar A, <B>j__TPar B, <C>j__TPar C, <D>j__TPar D)
	{
	}

	[Token(Token = "0x6000006")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F4F7C", Offset = "0x6F4F7C")]
internal sealed class <>f__AnonymousType1<<A>j__TPar, <B>j__TPar, <C>j__TPar, <D>j__TPar, <E>j__TPar>
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6F795C", Offset = "0x6F795C")]
	private readonly <A>j__TPar <A>i__Field;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6F7970", Offset = "0x6F7970")]
	private readonly <B>j__TPar <B>i__Field;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6F7984", Offset = "0x6F7984")]
	private readonly <C>j__TPar <C>i__Field;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6F7998", Offset = "0x6F7998")]
	private readonly <D>j__TPar <D>i__Field;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6F79AC", Offset = "0x6F79AC")]
	private readonly <E>j__TPar <E>i__Field;

	[Token(Token = "0x17000005")]
	public <A>j__TPar A
	{
		[Token(Token = "0x6000009")]
		get
		{
			return (<A>j__TPar)null;
		}
	}

	[Token(Token = "0x17000006")]
	public <B>j__TPar B
	{
		[Token(Token = "0x600000A")]
		get
		{
			return (<B>j__TPar)null;
		}
	}

	[Token(Token = "0x17000007")]
	public <C>j__TPar C
	{
		[Token(Token = "0x600000B")]
		get
		{
			return (<C>j__TPar)null;
		}
	}

	[Token(Token = "0x17000008")]
	public <D>j__TPar D
	{
		[Token(Token = "0x600000C")]
		get
		{
			return (<D>j__TPar)null;
		}
	}

	[Token(Token = "0x17000009")]
	public <E>j__TPar E
	{
		[Token(Token = "0x600000D")]
		get
		{
			return (<E>j__TPar)null;
		}
	}

	[Token(Token = "0x600000E")]
	[DebuggerHidden]
	public <>f__AnonymousType1(<A>j__TPar A, <B>j__TPar B, <C>j__TPar C, <D>j__TPar D, <E>j__TPar E)
	{
	}

	[Token(Token = "0x600000F")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000011")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000004")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x12C5AE4", Offset = "0x12C5AE4", VA = "0x12C5AE4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x12C5C1C", Offset = "0x12C5C1C", VA = "0x12C5C1C")]
	public EventSystemChecker()
	{
	}
}
[Token(Token = "0x2000005")]
public class ForcedReset : MonoBehaviour
{
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1D8E2BC", Offset = "0x1D8E2BC", VA = "0x1D8E2BC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1D8E3A8", Offset = "0x1D8E3A8", VA = "0x1D8E3A8")]
	public ForcedReset()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000006")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x200013A")]
		public enum Mode
		{
			[Token(Token = "0x40004E5")]
			Trigger,
			[Token(Token = "0x40004E6")]
			Replace,
			[Token(Token = "0x40004E7")]
			Activate,
			[Token(Token = "0x40004E8")]
			Enable,
			[Token(Token = "0x40004E9")]
			Animate,
			[Token(Token = "0x40004EA")]
			Deactivate
		}

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Mode action;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityEngine.Object target;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public GameObject source;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int triggerCount;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool repeatTrigger;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xD11CE8", Offset = "0xD11CE8", VA = "0xD11CE8")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xD121B0", Offset = "0xD121B0", VA = "0xD121B0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xD121B4", Offset = "0xD121B4", VA = "0xD121B4")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200013B")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Shader original;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Shader replacement;

			[Token(Token = "0x6000A99")]
			[Address(RVA = "0xD13014", Offset = "0xD13014", VA = "0xD13014")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013C")]
		public class ReplacementList
		{
			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0xD1301C", Offset = "0xD1301C", VA = "0xD1301C")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xD121CC", Offset = "0xD121CC", VA = "0xD121CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xD1300C", Offset = "0xD1300C", VA = "0xD1300C")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200013D")]
		public class Vector3andSpace
		{
			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 value;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Space space;

			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0xD1326C", Offset = "0xD1326C", VA = "0xD1326C")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool ignoreTimescale;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_LastRealTime;

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xD13094", Offset = "0xD13094", VA = "0xD13094")]
		private void Start()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xD130B0", Offset = "0xD130B0", VA = "0xD130B0")]
		private void Update()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xD13264", Offset = "0xD13264", VA = "0xD13264")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class CameraRefocus
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Camera Camera;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Parent;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_Refocus;

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xD1327C", Offset = "0xD1327C", VA = "0xD1327C")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xD132D4", Offset = "0xD132D4", VA = "0xD132D4")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xD132DC", Offset = "0xD132DC", VA = "0xD132DC")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xD132E4", Offset = "0xD132E4", VA = "0xD132E4")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xD13474", Offset = "0xD13474", VA = "0xD13474")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000A")]
	public class CurveControlledBob
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float HorizontalBobRange;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float VerticalBobRange;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_CyclePositionX;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_CyclePositionY;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_BobBaseInterval;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_Time;

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xD134EC", Offset = "0xD134EC", VA = "0xD134EC")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xD135E4", Offset = "0xD135E4", VA = "0xD135E4")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xD1371C", Offset = "0xD1371C", VA = "0xD1371C")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x200013E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F779C", Offset = "0x6F779C")]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float distance;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float <oldDrag>5__2;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x1700025E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A9F")]
				[Address(RVA = "0xD14448", Offset = "0xD14448", VA = "0xD14448", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700025F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AA1")]
				[Address(RVA = "0xD144C8", Offset = "0xD144C8", VA = "0xD144C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0xD14064", Offset = "0xD14064", VA = "0xD14064")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0xD1408C", Offset = "0xD1408C", VA = "0xD1408C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0xD14090", Offset = "0xD14090", VA = "0xD14090", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0xD14450", Offset = "0xD14450", VA = "0xD14450", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000022")]
		private const float k_Spring = 50f;

		[Token(Token = "0x4000023")]
		private const float k_Damper = 5f;

		[Token(Token = "0x4000024")]
		private const float k_Drag = 10f;

		[Token(Token = "0x4000025")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x4000026")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x4000027")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xD13A10", Offset = "0xD13A10", VA = "0xD13A10")]
		private void Update()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xD13FA8", Offset = "0xD13FA8", VA = "0xD13FA8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x702958", Offset = "0x702958")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xD13EF0", Offset = "0xD13EF0", VA = "0xD13EF0")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xD14084", Offset = "0xD14084", VA = "0xD14084")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Light sunLight;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minHeight;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float minShadowDistance;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minShadowBias;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxHeight;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxShadowDistance;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float maxShadowBias;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float adaptTime;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_SmoothHeight;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_ChangeSpeed;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float m_OriginalStrength;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xD144D0", Offset = "0xD144D0", VA = "0xD144D0")]
		private void Start()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xD14500", Offset = "0xD14500", VA = "0xD14500")]
		private void Update()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xD14828", Offset = "0xD14828", VA = "0xD14828")]
		public DynamicShadowSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public class FOVKick
	{
		[Token(Token = "0x200013F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F77AC", Offset = "0x6F77AC")]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FOVKick <>4__this;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <t>5__2;

			[Token(Token = "0x17000260")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AA5")]
				[Address(RVA = "0xD14FA0", Offset = "0xD14FA0", VA = "0xD14FA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000261")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AA7")]
				[Address(RVA = "0xD15020", Offset = "0xD15020", VA = "0xD15020", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0xD14A54", Offset = "0xD14A54", VA = "0xD14A54")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0xD14DD8", Offset = "0xD14DD8", VA = "0xD14DD8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0xD14DDC", Offset = "0xD14DDC", VA = "0xD14DDC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0xD14FA8", Offset = "0xD14FA8", VA = "0xD14FA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F77BC", Offset = "0x6F77BC")]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FOVKick <>4__this;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <t>5__2;

			[Token(Token = "0x17000262")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AAB")]
				[Address(RVA = "0xD14D50", Offset = "0xD14D50", VA = "0xD14D50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000263")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AAD")]
				[Address(RVA = "0xD14DD0", Offset = "0xD14DD0", VA = "0xD14DD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0xD14B00", Offset = "0xD14B00", VA = "0xD14B00")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0xD14B40", Offset = "0xD14B40", VA = "0xD14B40", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0xD14B44", Offset = "0xD14B44", VA = "0xD14B44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0xD14D58", Offset = "0xD14D58", VA = "0xD14D58", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Camera Camera;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float FOVIncrease;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float TimeToIncrease;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float TimeToDecrease;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xD14870", Offset = "0xD14870", VA = "0xD14870")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xD148B4", Offset = "0xD148B4", VA = "0xD148B4")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xD149C0", Offset = "0xD149C0", VA = "0xD149C0")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xD149C8", Offset = "0xD149C8", VA = "0xD149C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7029C8", Offset = "0x7029C8")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xD14A74", Offset = "0xD14A74", VA = "0xD14A74")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x702A38", Offset = "0x702A38")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xD14B20", Offset = "0xD14B20", VA = "0xD14B20")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F4F8C", Offset = "0x6F4F8C")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x400003A")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int m_FpsAccumulator;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int m_CurrentFps;

		[Token(Token = "0x400003E")]
		private const string display = "{0} FPS";

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Text m_Text;

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xD15028", Offset = "0xD15028", VA = "0xD15028")]
		private void Start()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xD15144", Offset = "0xD15144", VA = "0xD15144")]
		private void Update()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xD15290", Offset = "0xD15290", VA = "0xD15290")]
		public FPSCounter()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform target;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 offset;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xD15298", Offset = "0xD15298", VA = "0xD15298")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xD15390", Offset = "0xD15390", VA = "0xD15390")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	public class LerpControlledBob
	{
		[Token(Token = "0x2000141")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F77CC", Offset = "0x6F77CC")]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <t>5__2;

			[Token(Token = "0x17000264")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AB1")]
				[Address(RVA = "0xD15728", Offset = "0xD15728", VA = "0xD15728", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000265")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AB3")]
				[Address(RVA = "0xD157A8", Offset = "0xD157A8", VA = "0xD157A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0xD15484", Offset = "0xD15484", VA = "0xD15484")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0xD154AC", Offset = "0xD154AC", VA = "0xD154AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0xD154B0", Offset = "0xD154B0", VA = "0xD154B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0xD15730", Offset = "0xD15730", VA = "0xD15730", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float BobDuration;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float BobAmount;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float m_Offset;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xD153F0", Offset = "0xD153F0", VA = "0xD153F0")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xD153F8", Offset = "0xD153F8", VA = "0xD153F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x702AA8", Offset = "0x702AA8")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xD154A4", Offset = "0xD154A4", VA = "0xD154A4")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x2000142")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F77DC", Offset = "0x6F77DC")]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float delay;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x17000266")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AB7")]
				[Address(RVA = "0xD15D2C", Offset = "0xD15D2C", VA = "0xD15D2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000267")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AB9")]
				[Address(RVA = "0xD15DAC", Offset = "0xD15DAC", VA = "0xD15DAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0xD159E0", Offset = "0xD159E0", VA = "0xD159E0")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0xD15A08", Offset = "0xD15A08", VA = "0xD15A08", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0xD15A0C", Offset = "0xD15A0C", VA = "0xD15A0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0xD15D34", Offset = "0xD15D34", VA = "0xD15D34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Vector3 originalPosition;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Quaternion originalRotation;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Transform> originalStructure;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xD157B0", Offset = "0xD157B0", VA = "0xD157B0")]
		private void Start()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xD15900", Offset = "0xD15900", VA = "0xD15900")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xD15924", Offset = "0xD15924", VA = "0xD15924")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x702B18", Offset = "0x702B18")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xD15A00", Offset = "0xD15A00", VA = "0xD15A00")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x2000143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F77EC", Offset = "0x6F77EC")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float <stopTime>5__3;

			[Token(Token = "0x17000268")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000ABD")]
				[Address(RVA = "0xD16284", Offset = "0xD16284", VA = "0xD16284", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000269")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000ABF")]
				[Address(RVA = "0xD16304", Offset = "0xD16304", VA = "0xD16304", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0xD15E40", Offset = "0xD15E40", VA = "0xD15E40")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0xD15E88", Offset = "0xD15E88", VA = "0xD15E88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0xD15E8C", Offset = "0xD15E8C", VA = "0xD15E8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0xD1628C", Offset = "0xD1628C", VA = "0xD1628C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float minDuration;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float maxDuration;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float m_MaxLifetime;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_EarlyStop;

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xD15DB4", Offset = "0xD15DB4", VA = "0xD15DB4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x702B88", Offset = "0x702B88")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xD15E60", Offset = "0xD15E60", VA = "0xD15E60")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xD15E6C", Offset = "0xD15E6C", VA = "0xD15E6C")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x2000144")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x400050D")]
			Standalone,
			[Token(Token = "0x400050E")]
			Mobile
		}

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xD1630C", Offset = "0xD1630C", VA = "0xD1630C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xD16310", Offset = "0xD16310", VA = "0xD16310")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xD16324", Offset = "0xD16324", VA = "0xD16324")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xD167A0", Offset = "0xD167A0", VA = "0xD167A0")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0xD16840", Offset = "0xD16840", VA = "0xD16840")]
		public SimpleActivatorMenu()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector2 rotationRange;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float rotationSpeed;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float dampingTime;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool relative;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xD16848", Offset = "0xD16848", VA = "0xD16848")]
		private void Start()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xD1689C", Offset = "0xD1689C", VA = "0xD1689C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xD16DFC", Offset = "0xD16DFC", VA = "0xD16DFC")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float height;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xD16EE8", Offset = "0xD16EE8", VA = "0xD16EE8")]
		private void Start()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xD16EEC", Offset = "0xD16EEC", VA = "0xD16EEC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xD17354", Offset = "0xD17354", VA = "0xD17354")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000145")]
		public enum Action
		{
			[Token(Token = "0x4000510")]
			Activate,
			[Token(Token = "0x4000511")]
			Deactivate,
			[Token(Token = "0x4000512")]
			Destroy,
			[Token(Token = "0x4000513")]
			ReloadLevel,
			[Token(Token = "0x4000514")]
			Call
		}

		[Serializable]
		[Token(Token = "0x2000146")]
		public class Entry
		{
			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public GameObject target;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Action action;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float delay;

			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0xD17C04", Offset = "0xD17C04", VA = "0xD17C04")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000147")]
		public class Entries
		{
			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Entry[] entries;

			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0xD17744", Offset = "0xD17744", VA = "0xD17744")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F77FC", Offset = "0x6F77FC")]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry entry;

			[Token(Token = "0x1700026A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AC5")]
				[Address(RVA = "0xD17848", Offset = "0xD17848", VA = "0xD17848", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700026B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AC7")]
				[Address(RVA = "0xD178C8", Offset = "0xD178C8", VA = "0xD178C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0xD17664", Offset = "0xD17664", VA = "0xD17664")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0xD1774C", Offset = "0xD1774C", VA = "0xD1774C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0xD17750", Offset = "0xD17750", VA = "0xD17750", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0xD17850", Offset = "0xD17850", VA = "0xD17850", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000149")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F780C", Offset = "0x6F780C")]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry entry;

			[Token(Token = "0x1700026C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000ACB")]
				[Address(RVA = "0xD179CC", Offset = "0xD179CC", VA = "0xD179CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700026D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000ACD")]
				[Address(RVA = "0xD17A4C", Offset = "0xD17A4C", VA = "0xD17A4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0xD17684", Offset = "0xD17684", VA = "0xD17684")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0xD178D0", Offset = "0xD178D0", VA = "0xD178D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0xD178D4", Offset = "0xD178D4", VA = "0xD178D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0xD179D4", Offset = "0xD179D4", VA = "0xD179D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200014A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F781C", Offset = "0x6F781C")]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry entry;

			[Token(Token = "0x1700026E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AD1")]
				[Address(RVA = "0xD17B7C", Offset = "0xD17B7C", VA = "0xD17B7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700026F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AD3")]
				[Address(RVA = "0xD17BFC", Offset = "0xD17BFC", VA = "0xD17BFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0xD176A4", Offset = "0xD176A4", VA = "0xD176A4")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0xD17A54", Offset = "0xD17A54", VA = "0xD17A54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0xD17A58", Offset = "0xD17A58", VA = "0xD17A58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0xD17B84", Offset = "0xD17B84", VA = "0xD17B84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Entries entries;

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xD17374", Offset = "0xD17374", VA = "0xD17374")]
		private void Awake()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xD174C0", Offset = "0xD174C0", VA = "0xD174C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x702BF8", Offset = "0x702BF8")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xD1754C", Offset = "0xD1754C", VA = "0xD1754C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x702C68", Offset = "0x702C68")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xD175D8", Offset = "0xD175D8", VA = "0xD175D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x702CD8", Offset = "0x702CD8")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xD176C4", Offset = "0xD176C4", VA = "0xD176C4")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xD17C0C", Offset = "0xD17C0C", VA = "0xD17C0C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xD17C70", Offset = "0xD17C70", VA = "0xD17C70")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xD17D30", Offset = "0xD17D30", VA = "0xD17D30")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014B")]
		public class WaypointList
		{
			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public WaypointCircuit circuit;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform[] items;

			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0xD190FC", Offset = "0xD190FC", VA = "0xD190FC")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x200014C")]
		public struct RoutePoint
		{
			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0xD18878", Offset = "0xD18878", VA = "0xD18878")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public WaypointList waypointList;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int numPoints;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3[] points;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float[] distances;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7AA0", Offset = "0x6F7AA0")]
		private float <Length>k__BackingField;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int p0n;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int p1n;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int p2n;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int p3n;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float i;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 P0;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 P1;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P2;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P3;

		[Token(Token = "0x1700000A")]
		public float Length
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0xD17D40", Offset = "0xD17D40", VA = "0xD17D40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702D48", Offset = "0x702D48")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xD17D48", Offset = "0xD17D48", VA = "0xD17D48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702D58", Offset = "0x702D58")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xD17D50", Offset = "0xD17D50", VA = "0xD17D50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xD17D70", Offset = "0xD17D70", VA = "0xD17D70")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xD182A0", Offset = "0xD182A0", VA = "0xD182A0")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xD183B8", Offset = "0xD183B8", VA = "0xD183B8")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xD18890", Offset = "0xD18890", VA = "0xD18890")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xD17DD8", Offset = "0xD17DD8", VA = "0xD17DD8")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xD18C68", Offset = "0xD18C68", VA = "0xD18C68")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xD19064", Offset = "0xD19064", VA = "0xD19064")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xD18C70", Offset = "0xD18C70", VA = "0xD18C70")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xD1906C", Offset = "0xD1906C", VA = "0xD1906C")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x200014D")]
		public enum ProgressStyle
		{
			[Token(Token = "0x4000527")]
			SmoothAlongRoute,
			[Token(Token = "0x4000528")]
			PointToPoint
		}

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7B20", Offset = "0x6F7B20")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7B30", Offset = "0x6F7B30")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7B40", Offset = "0x6F7B40")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform target;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float progressDistance;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int progressNum;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float speed;

		[Token(Token = "0x1700000C")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0xD19174", Offset = "0xD19174", VA = "0xD19174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702D68", Offset = "0x702D68")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000062")]
			[Address(RVA = "0xD1918C", Offset = "0xD1918C", VA = "0xD1918C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702D78", Offset = "0x702D78")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0xD191A8", Offset = "0xD191A8", VA = "0xD191A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702D88", Offset = "0x702D88")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000064")]
			[Address(RVA = "0xD191C0", Offset = "0xD191C0", VA = "0xD191C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702D98", Offset = "0x702D98")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0xD191DC", Offset = "0xD191DC", VA = "0xD191DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702DA8", Offset = "0x702DA8")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000066")]
			[Address(RVA = "0xD191F4", Offset = "0xD191F4", VA = "0xD191F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702DB8", Offset = "0x702DB8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xD19210", Offset = "0xD19210", VA = "0xD19210")]
		private void Start()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xD1931C", Offset = "0xD1931C", VA = "0xD1931C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xD19480", Offset = "0xD19480", VA = "0xD19480")]
		private void Update()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xD19C2C", Offset = "0xD19C2C", VA = "0xD19C2C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xD19E50", Offset = "0xD19E50", VA = "0xD19E50")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200001B")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string axisName;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float axisValue;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float responseSpeed;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float returnToCentreSpeed;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xD0D530", Offset = "0xD0D530", VA = "0xD0D530")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xD0D864", Offset = "0xD0D864", VA = "0xD0D864")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xD0DA34", Offset = "0xD0DA34", VA = "0xD0DA34")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xD0DAD4", Offset = "0xD0DAD4", VA = "0xD0DAD4", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xD0DBE0", Offset = "0xD0DBE0", VA = "0xD0DBE0", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xD0DC9C", Offset = "0xD0DC9C", VA = "0xD0DC9C")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string Name;

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xD0DD20", Offset = "0xD0DD20", VA = "0xD0DD20")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xD0DD24", Offset = "0xD0DD24", VA = "0xD0DD24")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xD0DE40", Offset = "0xD0DE40", VA = "0xD0DE40")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xD0DF5C", Offset = "0xD0DF5C", VA = "0xD0DF5C")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xD0E078", Offset = "0xD0E078", VA = "0xD0E078")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xD0E194", Offset = "0xD0E194", VA = "0xD0E194")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xD0E2B0", Offset = "0xD0E2B0", VA = "0xD0E2B0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xD0E2B4", Offset = "0xD0E2B4", VA = "0xD0E2B4")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200014E")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x400052A")]
			Hardware,
			[Token(Token = "0x400052B")]
			Touch
		}

		[Token(Token = "0x200014F")]
		public class VirtualAxis
		{
			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702854", Offset = "0x702854")]
			private string <name>k__BackingField;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private float m_Value;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702864", Offset = "0x702864")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x17000270")]
			public string name
			{
				[Token(Token = "0x6000AD6")]
				[Address(RVA = "0xD0F3A4", Offset = "0xD0F3A4", VA = "0xD0F3A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703FA8", Offset = "0x703FA8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000AD7")]
				[Address(RVA = "0xD0F3AC", Offset = "0xD0F3AC", VA = "0xD0F3AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703FB8", Offset = "0x703FB8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000271")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000AD8")]
				[Address(RVA = "0xD0F3B4", Offset = "0xD0F3B4", VA = "0xD0F3B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703FC8", Offset = "0x703FC8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000AD9")]
				[Address(RVA = "0xD0F3BC", Offset = "0xD0F3BC", VA = "0xD0F3BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703FD8", Offset = "0x703FD8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000272")]
			public float GetValue
			{
				[Token(Token = "0x6000ADE")]
				[Address(RVA = "0xD0F400", Offset = "0xD0F400", VA = "0xD0F400")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000273")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000ADF")]
				[Address(RVA = "0xD0F408", Offset = "0xD0F408", VA = "0xD0F408")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0xD0D708", Offset = "0xD0D708", VA = "0xD0D708")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0xD0F3C4", Offset = "0xD0F3C4", VA = "0xD0F3C4")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0xD0DA58", Offset = "0xD0DA58", VA = "0xD0DA58")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0xD0F3F8", Offset = "0xD0F3F8", VA = "0xD0F3F8")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000150")]
		public class VirtualButton
		{
			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702874", Offset = "0x702874")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702884", Offset = "0x702884")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int m_LastPressedFrame;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool m_Pressed;

			[Token(Token = "0x17000274")]
			public string name
			{
				[Token(Token = "0x6000AE0")]
				[Address(RVA = "0xD0F410", Offset = "0xD0F410", VA = "0xD0F410")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703FE8", Offset = "0x703FE8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000AE1")]
				[Address(RVA = "0xD0F418", Offset = "0xD0F418", VA = "0xD0F418")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703FF8", Offset = "0x703FF8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000275")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000AE2")]
				[Address(RVA = "0xD0F420", Offset = "0xD0F420", VA = "0xD0F420")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x704008", Offset = "0x704008")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000AE3")]
				[Address(RVA = "0xD0F428", Offset = "0xD0F428", VA = "0xD0F428")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x704018", Offset = "0x704018")]
				private set
				{
				}
			}

			[Token(Token = "0x17000276")]
			public bool GetButton
			{
				[Token(Token = "0x6000AE9")]
				[Address(RVA = "0xD0F588", Offset = "0xD0F588", VA = "0xD0F588")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000277")]
			public bool GetButtonDown
			{
				[Token(Token = "0x6000AEA")]
				[Address(RVA = "0xD0F590", Offset = "0xD0F590", VA = "0xD0F590")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000278")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000AEB")]
				[Address(RVA = "0xD0F5B8", Offset = "0xD0F5B8", VA = "0xD0F5B8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0xD0F430", Offset = "0xD0F430", VA = "0xD0F430")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0xD0F474", Offset = "0xD0F474", VA = "0xD0F474")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0xD0F4B8", Offset = "0xD0F4B8", VA = "0xD0F4B8")]
			public void Pressed()
			{
			}

			[Token(Token = "0x6000AE7")]
			[Address(RVA = "0xD0F4E8", Offset = "0xD0F4E8", VA = "0xD0F4E8")]
			public void Released()
			{
			}

			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0xD0F50C", Offset = "0xD0F50C", VA = "0xD0F50C")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x1700000F")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xD0EFC0", Offset = "0xD0EFC0", VA = "0xD0EFC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xD0E2BC", Offset = "0xD0E2BC", VA = "0xD0E2BC")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xD0E384", Offset = "0xD0E384", VA = "0xD0E384")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xD0D674", Offset = "0xD0D674", VA = "0xD0D674")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xD0E4C8", Offset = "0xD0E4C8", VA = "0xD0E4C8")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xD0D73C", Offset = "0xD0D73C", VA = "0xD0D73C")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xD0E738", Offset = "0xD0E738", VA = "0xD0E738")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xD0E934", Offset = "0xD0E934", VA = "0xD0E934")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xD0EAC8", Offset = "0xD0EAC8", VA = "0xD0EAC8")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xD0D7D0", Offset = "0xD0D7D0", VA = "0xD0D7D0")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xD0D4AC", Offset = "0xD0D4AC", VA = "0xD0D4AC")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xD0ED5C", Offset = "0xD0ED5C", VA = "0xD0ED5C")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xD0ECB4", Offset = "0xD0ECB4", VA = "0xD0ECB4")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xD0EDD8", Offset = "0xD0EDD8", VA = "0xD0EDD8")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xD0D0A4", Offset = "0xD0D0A4", VA = "0xD0D0A4")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xD0EE78", Offset = "0xD0EE78", VA = "0xD0EE78")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xD0DDA0", Offset = "0xD0DDA0", VA = "0xD0DDA0")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xD0DEBC", Offset = "0xD0DEBC", VA = "0xD0DEBC")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xD0DFD8", Offset = "0xD0DFD8", VA = "0xD0DFD8")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xD0E210", Offset = "0xD0E210", VA = "0xD0E210")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xD0E0F4", Offset = "0xD0E0F4", VA = "0xD0E0F4")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xD0EF18", Offset = "0xD0EF18", VA = "0xD0EF18")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xD0F060", Offset = "0xD0F060", VA = "0xD0F060")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xD0F174", Offset = "0xD0F174", VA = "0xD0F174")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xD0F28C", Offset = "0xD0F28C", VA = "0xD0F28C")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string axis;

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xD0F5E0", Offset = "0xD0F5E0", VA = "0xD0F5E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xD0F5E4", Offset = "0xD0F5E4", VA = "0xD0F5E4")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xD0F680", Offset = "0xD0F680", VA = "0xD0F680")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000151")]
		public enum AxisOption
		{
			[Token(Token = "0x4000535")]
			Both,
			[Token(Token = "0x4000536")]
			OnlyHorizontal,
			[Token(Token = "0x4000537")]
			OnlyVertical
		}

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int MovementRange;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AxisOption axesToUse;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public string horizontalAxisName;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string verticalAxisName;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_UseX;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool m_UseY;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xD0F688", Offset = "0xD0F688", VA = "0xD0F688")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xD0F848", Offset = "0xD0F848", VA = "0xD0F848")]
		private void Start()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xD0F894", Offset = "0xD0F894", VA = "0xD0F894")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xD0F68C", Offset = "0xD0F68C", VA = "0xD0F68C")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xD0F9D8", Offset = "0xD0F9D8", VA = "0xD0F9D8", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xD0FC10", Offset = "0xD0FC10", VA = "0xD0FC10", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xD0FC74", Offset = "0xD0FC74", VA = "0xD0FC74", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xD0FC78", Offset = "0xD0FC78", VA = "0xD0FC78")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xD0FCD4", Offset = "0xD0FCD4", VA = "0xD0FCD4")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0xD0FD64", Offset = "0xD0FD64", VA = "0xD0FD64")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xD0FD74", Offset = "0xD0FD74", VA = "0xD0FD74")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xD0FD6C", Offset = "0xD0FD6C", VA = "0xD0FD6C")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xD0FE98", Offset = "0xD0FE98", VA = "0xD0FE98")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xD101C8", Offset = "0xD101C8", VA = "0xD101C8")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000152")]
		public enum AxisOptions
		{
			[Token(Token = "0x4000539")]
			ForwardAxis,
			[Token(Token = "0x400053A")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x2000153")]
		public class AxisMapping
		{
			[Token(Token = "0x2000186")]
			public enum MappingType
			{
				[Token(Token = "0x4000613")]
				NamedAxis,
				[Token(Token = "0x4000614")]
				MousePositionX,
				[Token(Token = "0x4000615")]
				MousePositionY,
				[Token(Token = "0x4000616")]
				MousePositionZ
			}

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public MappingType type;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public string axisName;

			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0xD11418", Offset = "0xD11418", VA = "0xD11418")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AxisMapping mapping;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float fullTiltAngle;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float centreAngleOffset;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xD10FF4", Offset = "0xD10FF4", VA = "0xD10FF4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xD110E8", Offset = "0xD110E8", VA = "0xD110E8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xD113E0", Offset = "0xD113E0", VA = "0xD113E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xD11404", Offset = "0xD11404", VA = "0xD11404")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F500C", Offset = "0x6F500C")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000154")]
		public enum AxisOption
		{
			[Token(Token = "0x400053E")]
			Both,
			[Token(Token = "0x400053F")]
			OnlyHorizontal,
			[Token(Token = "0x4000540")]
			OnlyVertical
		}

		[Token(Token = "0x2000155")]
		public enum ControlStyle
		{
			[Token(Token = "0x4000542")]
			Absolute,
			[Token(Token = "0x4000543")]
			Relative,
			[Token(Token = "0x4000544")]
			Swipe
		}

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AxisOption axesToUse;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ControlStyle controlStyle;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public string horizontalAxisName;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string verticalAxisName;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Xsensitivity;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Ysensitivity;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool m_UseX;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		private bool m_UseY;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Dragging;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_Id;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 m_Center;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Image m_Image;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xD11420", Offset = "0xD11420", VA = "0xD11420")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xD115E0", Offset = "0xD115E0", VA = "0xD115E0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xD11424", Offset = "0xD11424", VA = "0xD11424")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xD1169C", Offset = "0xD1169C", VA = "0xD1169C")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xD11724", Offset = "0xD11724", VA = "0xD11724", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xD117F0", Offset = "0xD117F0", VA = "0xD117F0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xD11A78", Offset = "0xD11A78", VA = "0xD11A78", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xD11B18", Offset = "0xD11B18", VA = "0xD11B18")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xD11C2C", Offset = "0xD11C2C", VA = "0xD11C2C")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7B50", Offset = "0x6F7B50")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x17000010")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0xD11CC8", Offset = "0xD11CC8", VA = "0xD11CC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702DC8", Offset = "0x702DC8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0xD11CDC", Offset = "0xD11CDC", VA = "0xD11CDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702DD8", Offset = "0x702DD8")]
			private set
			{
			}
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xD0E454", Offset = "0xD0E454", VA = "0xD0E454")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xD0E55C", Offset = "0xD0E55C", VA = "0xD0E55C")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xD0E5D0", Offset = "0xD0E5D0", VA = "0xD0E5D0")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xD0E7CC", Offset = "0xD0E7CC", VA = "0xD0E7CC")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xD0EA20", Offset = "0xD0EA20", VA = "0xD0EA20")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xD0EB5C", Offset = "0xD0EB5C", VA = "0xD0EB5C")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xD0EC04", Offset = "0xD0EC04", VA = "0xD0EC04")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xD0F128", Offset = "0xD0F128", VA = "0xD0F128")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xD0F23C", Offset = "0xD0F23C", VA = "0xD0F23C")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xD0F354", Offset = "0xD0F354", VA = "0xD0F354")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x60000BD")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x60000BE")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x60000BF")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x60000C0")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x60000C1")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x60000C2")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x60000C3")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x60000C4")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x60000C5")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x60000C6")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x60000C7")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xD10B4C", Offset = "0xD10B4C", VA = "0xD10B4C")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000024")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xD101D0", Offset = "0xD101D0", VA = "0xD101D0")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xD10290", Offset = "0xD10290", VA = "0xD10290")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xD10340", Offset = "0xD10340", VA = "0xD10340", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xD10400", Offset = "0xD10400", VA = "0xD10400", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xD104DC", Offset = "0xD104DC", VA = "0xD104DC", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xD105AC", Offset = "0xD105AC", VA = "0xD105AC", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xD10670", Offset = "0xD10670", VA = "0xD10670", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xD10738", Offset = "0xD10738", VA = "0xD10738", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xD107FC", Offset = "0xD107FC", VA = "0xD107FC", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xD108CC", Offset = "0xD108CC", VA = "0xD108CC", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xD109A4", Offset = "0xD109A4", VA = "0xD109A4", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xD10A7C", Offset = "0xD10A7C", VA = "0xD10A7C", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xD10B38", Offset = "0xD10B38", VA = "0xD10B38", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xD0E37C", Offset = "0xD0E37C", VA = "0xD0E37C")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xD10C5C", Offset = "0xD10C5C", VA = "0xD10C5C", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xD10C74", Offset = "0xD10C74", VA = "0xD10C74", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xD10C80", Offset = "0xD10C80", VA = "0xD10C80", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xD10C8C", Offset = "0xD10C8C", VA = "0xD10C8C", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xD10C98", Offset = "0xD10C98", VA = "0xD10C98", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xD10D24", Offset = "0xD10D24", VA = "0xD10D24", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xD10DB0", Offset = "0xD10DB0", VA = "0xD10DB0", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xD10E3C", Offset = "0xD10E3C", VA = "0xD10E3C", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xD10EC8", Offset = "0xD10EC8", VA = "0xD10EC8", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xD10F54", Offset = "0xD10F54", VA = "0xD10F54", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xD10FE0", Offset = "0xD10FE0", VA = "0xD10FE0", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xD0E380", Offset = "0xD0E380", VA = "0xD0E380")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F507C", Offset = "0x6F507C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F507C", Offset = "0x6F507C")]
	public class AICharacterControl : MonoBehaviour
	{
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7B60", Offset = "0x6F7B60")]
		private NavMeshAgent <agent>k__BackingField;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7B70", Offset = "0x6F7B70")]
		private ThirdPersonCharacter <character>k__BackingField;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform target;

		[Token(Token = "0x17000011")]
		public NavMeshAgent agent
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x1D91910", Offset = "0x1D91910", VA = "0x1D91910")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702DE8", Offset = "0x702DE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x1D91918", Offset = "0x1D91918", VA = "0x1D91918")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702DF8", Offset = "0x702DF8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public ThirdPersonCharacter character
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x1D91920", Offset = "0x1D91920", VA = "0x1D91920")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702E08", Offset = "0x702E08")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x1D91928", Offset = "0x1D91928", VA = "0x1D91928")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702E18", Offset = "0x702E18")]
			private set
			{
			}
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1D91930", Offset = "0x1D91930", VA = "0x1D91930")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1D91A08", Offset = "0x1D91A08", VA = "0x1D91A08")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1D91DE0", Offset = "0x1D91DE0", VA = "0x1D91DE0")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1D91DE8", Offset = "0x1D91DE8", VA = "0x1D91DE8")]
		public AICharacterControl()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F5118", Offset = "0x6F5118")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F5118", Offset = "0x6F5118")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F5118", Offset = "0x6F5118")]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private float m_MovingTurnSpeed;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float m_StationaryTurnSpeed;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6F7BB0", Offset = "0x6F7BB0")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_RunCycleLegOffset;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MoveSpeedMultiplier;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_AnimSpeedMultiplier;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_GroundCheckDistance;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator m_Animator;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_IsGrounded;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_OrigGroundCheckDistance;

		[Token(Token = "0x40000C0")]
		private const float k_Half = 0.5f;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_TurnAmount;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_ForwardAmount;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_GroundNormal;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_CapsuleHeight;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 m_CapsuleCenter;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool m_Crouching;

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1D91DF0", Offset = "0x1D91DF0", VA = "0x1D91DF0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1D91BE0", Offset = "0x1D91BE0", VA = "0x1D91BE0")]
		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1D92518", Offset = "0x1D92518", VA = "0x1D92518")]
		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1D92898", Offset = "0x1D92898", VA = "0x1D92898")]
		private void PreventStandingInLowHeadroom()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1D92AA8", Offset = "0x1D92AA8", VA = "0x1D92AA8")]
		private void UpdateAnimator(Vector3 move)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1D923C8", Offset = "0x1D923C8", VA = "0x1D923C8")]
		private void HandleAirborneMovement()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1D92214", Offset = "0x1D92214", VA = "0x1D92214")]
		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1D9211C", Offset = "0x1D9211C", VA = "0x1D9211C")]
		private void ApplyExtraTurnRotation()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1D92DFC", Offset = "0x1D92DFC", VA = "0x1D92DFC")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1D91F28", Offset = "0x1D91F28", VA = "0x1D91F28")]
		private void CheckGroundStatus()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1D92F58", Offset = "0x1D92F58", VA = "0x1D92F58")]
		public ThirdPersonCharacter()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F51E0", Offset = "0x6F51E0")]
	public class ThirdPersonUserControl : MonoBehaviour
	{
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private ThirdPersonCharacter m_Character;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform m_Cam;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Vector3 m_CamForward;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 m_Move;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool m_Jump;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xD0CED8", Offset = "0xD0CED8", VA = "0xD0CED8")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xD0D010", Offset = "0xD0D010", VA = "0xD0D010")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xD0D144", Offset = "0xD0D144", VA = "0xD0D144")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xD0D528", Offset = "0xD0D528", VA = "0xD0D528")]
		public ThirdPersonUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F5250", Offset = "0x6F5250")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F5250", Offset = "0x6F5250")]
	public class FirstPersonController : MonoBehaviour
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6F7C5C", Offset = "0x6F7C5C")]
		private float m_RunstepLenghten;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MouseLook m_MouseLook;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FOVKick m_FovKick;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioClip m_JumpSound;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private AudioClip m_LandSound;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Camera m_Camera;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool m_Jump;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float m_YRotation;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector2 m_Input;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float m_StepCycle;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float m_NextStep;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_Jumping;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1D8E3B0", Offset = "0x1D8E3B0", VA = "0x1D8E3B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1D8E5E0", Offset = "0x1D8E5E0", VA = "0x1D8E5E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1D8E7AC", Offset = "0x1D8E7AC", VA = "0x1D8E7AC")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1D8E80C", Offset = "0x1D8E80C", VA = "0x1D8E80C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1D8EEB4", Offset = "0x1D8EEB4", VA = "0x1D8EEB4")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1D8EF04", Offset = "0x1D8EF04", VA = "0x1D8EF04")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1D8F308", Offset = "0x1D8F308", VA = "0x1D8F308")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1D8F038", Offset = "0x1D8F038", VA = "0x1D8F038")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1D8ECC4", Offset = "0x1D8ECC4", VA = "0x1D8ECC4")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1D8E750", Offset = "0x1D8E750", VA = "0x1D8E750")]
		private void RotateView()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1D8F8E0", Offset = "0x1D8F8E0", VA = "0x1D8F8E0")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1D8FA9C", Offset = "0x1D8FA9C", VA = "0x1D8FA9C")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class HeadBob : MonoBehaviour
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Camera Camera;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CurveControlledBob motionBob;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public LerpControlledBob jumpAndLandingBob;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float StrideInterval;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6F7D64", Offset = "0x6F7D64")]
		public float RunningStrideLengthen;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1D8FBCC", Offset = "0x1D8FBCC", VA = "0x1D8FBCC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1D8FC60", Offset = "0x1D8FC60", VA = "0x1D8FC60")]
		private void Update()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1D8FFB4", Offset = "0x1D8FFB4", VA = "0x1D8FFB4")]
		public HeadBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public class MouseLook
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float XSensitivity;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float YSensitivity;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool clampVerticalRotation;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float MinimumX;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float MaximumX;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool smooth;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float smoothTime;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool lockCursor;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1D8E564", Offset = "0x1D8E564", VA = "0x1D8E564")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1D8F500", Offset = "0x1D8F500", VA = "0x1D8F500")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1D9016C", Offset = "0x1D9016C", VA = "0x1D9016C")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1D8F2F8", Offset = "0x1D8F2F8", VA = "0x1D8F2F8")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1D9019C", Offset = "0x1D9019C", VA = "0x1D9019C")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1D90064", Offset = "0x1D90064", VA = "0x1D90064")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1D90220", Offset = "0x1D90220", VA = "0x1D90220")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F52EC", Offset = "0x6F52EC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F52EC", Offset = "0x6F52EC")]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000156")]
		public class MovementSettings
		{
			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float ForwardSpeed;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float BackwardSpeed;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float StrafeSpeed;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float RunMultiplier;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public KeyCode RunKey;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float JumpForce;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AnimationCurve SlopeCurveModifier;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[HideInInspector]
			public float CurrentTargetSpeed;

			[Token(Token = "0x6000AED")]
			[Address(RVA = "0x1D91468", Offset = "0x1D91468", VA = "0x1D91468")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0x1D916A0", Offset = "0x1D916A0", VA = "0x1D916A0")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000157")]
		public class AdvancedSettings
		{
			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float groundCheckDistance;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float slowDownRate;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool airControl;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7028A4", Offset = "0x7028A4")]
			public float shellOffset;

			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0x1D918E8", Offset = "0x1D918E8", VA = "0x1D918E8")]
			public AdvancedSettings()
			{
			}
		}

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Camera cam;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MovementSettings movementSettings;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public MouseLook mouseLook;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvancedSettings advancedSettings;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_YRotation;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 m_GroundContactNormal;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_Jump;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool m_Jumping;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool m_IsGrounded;

		[Token(Token = "0x17000013")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x1D8FF7C", Offset = "0x1D8FF7C", VA = "0x1D8FF7C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000014")]
		public bool Grounded
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x1D90268", Offset = "0x1D90268", VA = "0x1D90268")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public bool Jumping
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x1D90270", Offset = "0x1D90270", VA = "0x1D90270")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000016")]
		public bool Running
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x1D8FFAC", Offset = "0x1D8FFAC", VA = "0x1D8FFAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1D90278", Offset = "0x1D90278", VA = "0x1D90278")]
		private void Start()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1D9035C", Offset = "0x1D9035C", VA = "0x1D9035C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1D90684", Offset = "0x1D90684", VA = "0x1D90684")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1D91044", Offset = "0x1D91044", VA = "0x1D91044")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1D91128", Offset = "0x1D91128", VA = "0x1D91128")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1D90F60", Offset = "0x1D90F60", VA = "0x1D90F60")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1D90404", Offset = "0x1D90404", VA = "0x1D90404")]
		private void RotateView()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1D90CF4", Offset = "0x1D90CF4", VA = "0x1D90CF4")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1D9155C", Offset = "0x1D9155C", VA = "0x1D9155C")]
		public RigidbodyFirstPersonController()
		{
		}
	}
}
namespace FluffyUnderware.DevTools
{
	[Token(Token = "0x200002D")]
	public interface IDTGroupParsingAttribute
	{
		[Token(Token = "0x17000017")]
		string Path
		{
			[Token(Token = "0x600011D")]
			get;
		}
	}
	[Token(Token = "0x200002E")]
	public interface IDTFieldParsingAttribute
	{
	}
	[Token(Token = "0x200002F")]
	public interface IDTGroupRenderAttribute
	{
	}
	[Token(Token = "0x2000030")]
	public interface IDTFieldRenderAttribute
	{
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6F5388", Offset = "0x6F5388")]
	public class DTVersionAttribute : Attribute
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly string Version;

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1D83BE8", Offset = "0x1D83BE8", VA = "0x1D83BE8")]
		public DTVersionAttribute(string version)
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6F53B4", Offset = "0x6F53B4")]
	public class DTAttribute : Attribute, IComparable
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7D7C", Offset = "0x6F7D7C")]
		private int <TypeSort>k__BackingField;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int Sort;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool ShowBelowProperty;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Space;

		[Token(Token = "0x17000018")]
		public int TypeSort
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x1D7CFE4", Offset = "0x1D7CFE4", VA = "0x1D7CFE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702E28", Offset = "0x702E28")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x1D7CFEC", Offset = "0x1D7CFEC", VA = "0x1D7CFEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702E38", Offset = "0x702E38")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1D7CFF4", Offset = "0x1D7CFF4", VA = "0x1D7CFF4", Slot = "8")]
		public virtual int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1D79EE0", Offset = "0x1D79EE0", VA = "0x1D79EE0")]
		public DTAttribute(int sortOrder, bool showBelow = false)
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class GroupAttribute : DTAttribute, IDTGroupParsingAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7D8C", Offset = "0x6F7D8C")]
		private bool <PathIsAbsolute>k__BackingField;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool Expanded;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool Invisible;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public string Label;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Tooltip;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public string HelpURL;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string mPath;

		[Token(Token = "0x17000019")]
		public string Path
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x1D89A54", Offset = "0x1D89A54", VA = "0x1D89A54", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x1D89A5C", Offset = "0x1D89A5C", VA = "0x1D89A5C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public bool PathIsAbsolute
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x1D89B6C", Offset = "0x1D89B6C", VA = "0x1D89B6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702E48", Offset = "0x702E48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x1D89B74", Offset = "0x1D89B74", VA = "0x1D89B74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702E58", Offset = "0x702E58")]
			private set
			{
			}
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1D7A2E8", Offset = "0x1D7A2E8", VA = "0x1D7A2E8")]
		public GroupAttribute(string pathAndName)
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class ActionAttribute : DTAttribute
	{
		[Token(Token = "0x2000158")]
		public enum ActionEnum
		{
			[Token(Token = "0x4000553")]
			Show,
			[Token(Token = "0x4000554")]
			Hide,
			[Token(Token = "0x4000555")]
			Enable,
			[Token(Token = "0x4000556")]
			Disable,
			[Token(Token = "0x4000557")]
			ShowInfo,
			[Token(Token = "0x4000558")]
			ShowWarning,
			[Token(Token = "0x4000559")]
			ShowError,
			[Token(Token = "0x400055A")]
			Callback
		}

		[Token(Token = "0x2000159")]
		public enum ActionPositionEnum
		{
			[Token(Token = "0x400055C")]
			Above,
			[Token(Token = "0x400055D")]
			Below
		}

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ActionEnum Action;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ActionPositionEnum Position;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public object ActionData;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private MethodInfo mCallback;

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1D79E80", Offset = "0x1D79E80", VA = "0x1D79E80")]
		protected ActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1D79F14", Offset = "0x1D79F14", VA = "0x1D79F14")]
		public void Callback(object classInstance)
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class ConditionalAttribute : ActionAttribute
	{
		[Token(Token = "0x200015A")]
		public enum OperatorEnum
		{
			[Token(Token = "0x400055F")]
			AND,
			[Token(Token = "0x4000560")]
			OR
		}

		[Token(Token = "0x200015B")]
		public class Condition
		{
			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string FieldName;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public FieldInfo FieldInfo;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PropertyInfo PropertyInfo;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public object CompareTo;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool CompareFalse;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public OperatorEnum Operator;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MethodInfo MethodInfo;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public string MethodName;

			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x1D7C1BC", Offset = "0x1D7C1BC", VA = "0x1D7C1BC")]
			public Condition()
			{
			}
		}

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Condition[] Conditions;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1D7C010", Offset = "0x1D7C010", VA = "0x1D7C010")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1D7C1C4", Offset = "0x1D7C1C4", VA = "0x1D7C1C4")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1D7C48C", Offset = "0x1D7C48C", VA = "0x1D7C48C")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1D7C848", Offset = "0x1D7C848", VA = "0x1D7C848")]
		protected ConditionalAttribute(string methodToQuery)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1D7C9D4", Offset = "0x1D7C9D4", VA = "0x1D7C9D4", Slot = "9")]
		public virtual bool ConditionMet(object classInstance)
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1D7CAD0", Offset = "0x1D7CAD0", VA = "0x1D7CAD0")]
		private bool evaluate(Condition cond, object classInstance)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000036")]
	public class SortOrderAttribute : DTAttribute, IDTFieldParsingAttribute
	{
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1D8CDF8", Offset = "0x1D8CDF8", VA = "0x1D8CDF8")]
		public SortOrderAttribute(int sort = 100)
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class AsGroupAttribute : GroupAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1D7A294", Offset = "0x1D7A294", VA = "0x1D7A294")]
		public AsGroupAttribute([Optional] string pathAndName)
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class TabAttribute : GroupAttribute
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public readonly string TabName;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string TabBarName;

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1D8CE30", Offset = "0x1D8CE30", VA = "0x1D8CE30")]
		public TabAttribute(string pathAndName)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1D8CEF4", Offset = "0x1D8CEF4", VA = "0x1D8CEF4")]
		private static bool split(string pathAndName, out string path, out string tabBar, out string tabname)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000039")]
	public class SectionAttribute : GroupAttribute
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool Fixed;

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1D8A38C", Offset = "0x1D8A38C", VA = "0x1D8A38C")]
		public SectionAttribute(string name, bool expanded = true, bool fix = false, int sort = 100)
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class NoSectionAttribute : SectionAttribute
	{
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1D8A2EC", Offset = "0x1D8A2EC", VA = "0x1D8A2EC")]
		public NoSectionAttribute()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class Hide : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1D89C20", Offset = "0x1D89C20", VA = "0x1D89C20")]
		public Hide()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class Inline : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1D89C54", Offset = "0x1D89C54", VA = "0x1D89C54")]
		public Inline()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class ArrayExAttribute : DTAttribute, IDTFieldParsingAttribute
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Draggable;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool ShowHeader;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool ShowAdd;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool ShowDelete;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool DropTarget;

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1D7A24C", Offset = "0x1D7A24C", VA = "0x1D7A24C")]
		public ArrayExAttribute()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class FieldActionAttribute : ActionAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1D89170", Offset = "0x1D89170", VA = "0x1D89170")]
		public FieldActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class GroupActionAttribute : ActionAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1D899F4", Offset = "0x1D899F4", VA = "0x1D899F4")]
		public GroupActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class FieldConditionAttribute : ConditionalAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1D891D0", Offset = "0x1D891D0", VA = "0x1D891D0")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false, ActionEnum action = ActionEnum.Show, [Optional] object actionData, ActionPositionEnum position = ActionPositionEnum.Below)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1D8920C", Offset = "0x1D8920C", VA = "0x1D8920C")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1D89244", Offset = "0x1D89244", VA = "0x1D89244")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1D89294", Offset = "0x1D89294", VA = "0x1D89294")]
		public FieldConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class GroupConditionAttribute : ConditionalAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1D89B7C", Offset = "0x1D89B7C", VA = "0x1D89B7C")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1D89B94", Offset = "0x1D89B94", VA = "0x1D89B94")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1D89BCC", Offset = "0x1D89BCC", VA = "0x1D89BCC")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1D89C1C", Offset = "0x1D89C1C", VA = "0x1D89C1C")]
		public GroupConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class Couple<T1, T2>
	{
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7D9C", Offset = "0x6F7D9C")]
		private T1 <First>k__BackingField;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7DAC", Offset = "0x6F7DAC")]
		private T2 <Second>k__BackingField;

		[Token(Token = "0x1700001B")]
		public T1 First
		{
			[Token(Token = "0x6000143")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702E68", Offset = "0x702E68")]
			get
			{
				return (T1)null;
			}
			[Token(Token = "0x6000144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702E78", Offset = "0x702E78")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public T2 Second
		{
			[Token(Token = "0x6000145")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702E88", Offset = "0x702E88")]
			get
			{
				return (T2)null;
			}
			[Token(Token = "0x6000146")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702E98", Offset = "0x702E98")]
			set
			{
			}
		}

		[Token(Token = "0x6000147")]
		public Couple(T1 first, T2 second)
		{
		}
	}
	[Token(Token = "0x2000043")]
	public static class DTTween
	{
		[Token(Token = "0x200015C")]
		public enum EasingMethod
		{
			[Token(Token = "0x400056A")]
			Linear,
			[Token(Token = "0x400056B")]
			ExponentialIn,
			[Token(Token = "0x400056C")]
			ExponentialOut,
			[Token(Token = "0x400056D")]
			ExponentialInOut,
			[Token(Token = "0x400056E")]
			ExponentialOutIn,
			[Token(Token = "0x400056F")]
			CircularIn,
			[Token(Token = "0x4000570")]
			CircularOut,
			[Token(Token = "0x4000571")]
			CircularInOut,
			[Token(Token = "0x4000572")]
			CircularOutIn,
			[Token(Token = "0x4000573")]
			QuadraticIn,
			[Token(Token = "0x4000574")]
			QuadraticOut,
			[Token(Token = "0x4000575")]
			QuadraticInOut,
			[Token(Token = "0x4000576")]
			QuadraticOutIn,
			[Token(Token = "0x4000577")]
			SinusIn,
			[Token(Token = "0x4000578")]
			SinusOut,
			[Token(Token = "0x4000579")]
			SinusInOut,
			[Token(Token = "0x400057A")]
			SinusOutIn,
			[Token(Token = "0x400057B")]
			CubicIn,
			[Token(Token = "0x400057C")]
			CubicOut,
			[Token(Token = "0x400057D")]
			CubicInOut,
			[Token(Token = "0x400057E")]
			CubicOutIn,
			[Token(Token = "0x400057F")]
			QuarticIn,
			[Token(Token = "0x4000580")]
			QuarticOut,
			[Token(Token = "0x4000581")]
			QuarticInOut,
			[Token(Token = "0x4000582")]
			QuarticOutIn,
			[Token(Token = "0x4000583")]
			QuinticIn,
			[Token(Token = "0x4000584")]
			QuinticOut,
			[Token(Token = "0x4000585")]
			QuinticInOut,
			[Token(Token = "0x4000586")]
			QuinticOutIn
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1D80414", Offset = "0x1D80414", VA = "0x1D80414")]
		public static float Ease(EasingMethod method, float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1D81FD4", Offset = "0x1D81FD4", VA = "0x1D81FD4")]
		public static float Ease(EasingMethod method, float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1D81F34", Offset = "0x1D81F34", VA = "0x1D81F34")]
		public static float Linear(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1D833D8", Offset = "0x1D833D8", VA = "0x1D833D8")]
		public static float Linear(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1D80758", Offset = "0x1D80758", VA = "0x1D80758")]
		public static float ExpoOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1D82568", Offset = "0x1D82568", VA = "0x1D82568")]
		public static float ExpoOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1D80670", Offset = "0x1D80670", VA = "0x1D80670")]
		public static float ExpoIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1D824A4", Offset = "0x1D824A4", VA = "0x1D824A4")]
		public static float ExpoIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1D80844", Offset = "0x1D80844", VA = "0x1D80844")]
		public static float ExpoInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1D8262C", Offset = "0x1D8262C", VA = "0x1D8262C")]
		public static float ExpoInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1D809AC", Offset = "0x1D809AC", VA = "0x1D809AC")]
		public static float ExpoOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1D8277C", Offset = "0x1D8277C", VA = "0x1D8277C")]
		public static float ExpoOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1D80B60", Offset = "0x1D80B60", VA = "0x1D80B60")]
		public static float CircOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1D828AC", Offset = "0x1D828AC", VA = "0x1D828AC")]
		public static float CircOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1D80A94", Offset = "0x1D80A94", VA = "0x1D80A94")]
		public static float CircIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1D827E8", Offset = "0x1D827E8", VA = "0x1D827E8")]
		public static float CircIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1D80C2C", Offset = "0x1D80C2C", VA = "0x1D80C2C")]
		public static float CircInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1D82970", Offset = "0x1D82970", VA = "0x1D82970")]
		public static float CircInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1D80D6C", Offset = "0x1D80D6C", VA = "0x1D80D6C")]
		public static float CircOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1D82A94", Offset = "0x1D82A94", VA = "0x1D82A94")]
		public static float CircOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1D80EF8", Offset = "0x1D80EF8", VA = "0x1D80EF8")]
		public static float QuadOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1D82B24", Offset = "0x1D82B24", VA = "0x1D82B24")]
		public static float QuadOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1D80E54", Offset = "0x1D80E54", VA = "0x1D80E54")]
		public static float QuadIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1D82B00", Offset = "0x1D82B00", VA = "0x1D82B00")]
		public static float QuadIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1D80FA4", Offset = "0x1D80FA4", VA = "0x1D80FA4")]
		public static float QuadInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1D82B50", Offset = "0x1D82B50", VA = "0x1D82B50")]
		public static float QuadInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1D810E4", Offset = "0x1D810E4", VA = "0x1D810E4")]
		public static float QuadOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1D82C74", Offset = "0x1D82C74", VA = "0x1D82C74")]
		public static float QuadOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1D81288", Offset = "0x1D81288", VA = "0x1D81288")]
		public static float SineOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1D82D98", Offset = "0x1D82D98", VA = "0x1D82D98")]
		public static float SineOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1D811CC", Offset = "0x1D811CC", VA = "0x1D811CC")]
		public static float SineIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1D82CDC", Offset = "0x1D82CDC", VA = "0x1D82CDC")]
		public static float SineIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1D81340", Offset = "0x1D81340", VA = "0x1D81340")]
		public static float SineInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1D82E50", Offset = "0x1D82E50", VA = "0x1D82E50")]
		public static float SineInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1D81494", Offset = "0x1D81494", VA = "0x1D81494")]
		public static float SineOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1D82F84", Offset = "0x1D82F84", VA = "0x1D82F84")]
		public static float SineOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1D81624", Offset = "0x1D81624", VA = "0x1D81624")]
		public static float CubicOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1D83018", Offset = "0x1D83018", VA = "0x1D83018")]
		public static float CubicOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1D8157C", Offset = "0x1D8157C", VA = "0x1D8157C")]
		public static float CubicIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1D82FF0", Offset = "0x1D82FF0", VA = "0x1D82FF0")]
		public static float CubicIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1D816D8", Offset = "0x1D816D8", VA = "0x1D816D8")]
		public static float CubicInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1D8304C", Offset = "0x1D8304C", VA = "0x1D8304C")]
		public static float CubicInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1D817C4", Offset = "0x1D817C4", VA = "0x1D817C4")]
		public static float CubicOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1D830B4", Offset = "0x1D830B4", VA = "0x1D830B4")]
		public static float CubicOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1D81958", Offset = "0x1D81958", VA = "0x1D81958")]
		public static float QuartOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1D83154", Offset = "0x1D83154", VA = "0x1D83154")]
		public static float QuartOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1D818AC", Offset = "0x1D818AC", VA = "0x1D818AC")]
		public static float QuartIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1D83128", Offset = "0x1D83128", VA = "0x1D83128")]
		public static float QuartIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1D81A0C", Offset = "0x1D81A0C", VA = "0x1D81A0C")]
		public static float QuartInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1D83188", Offset = "0x1D83188", VA = "0x1D83188")]
		public static float QuartInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1D81AFC", Offset = "0x1D81AFC", VA = "0x1D81AFC")]
		public static float QuartOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1D831F8", Offset = "0x1D831F8", VA = "0x1D831F8")]
		public static float QuartOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1D81C94", Offset = "0x1D81C94", VA = "0x1D81C94")]
		public static float QuintOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1D832A0", Offset = "0x1D832A0", VA = "0x1D832A0")]
		public static float QuintOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1D81BE4", Offset = "0x1D81BE4", VA = "0x1D81BE4")]
		public static float QuintIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1D83270", Offset = "0x1D83270", VA = "0x1D83270")]
		public static float QuintIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1D81D50", Offset = "0x1D81D50", VA = "0x1D81D50")]
		public static float QuintInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1D832DC", Offset = "0x1D832DC", VA = "0x1D832DC")]
		public static float QuintInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1D81E4C", Offset = "0x1D81E4C", VA = "0x1D81E4C")]
		public static float QuintOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1D83354", Offset = "0x1D83354", VA = "0x1D83354")]
		public static float QuintOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000044")]
	public class DTObjectDump
	{
		[Token(Token = "0x4000125")]
		private const int INDENTSPACES = 5;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string mIndent;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private StringBuilder mSB;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private object mObject;

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1D7EF10", Offset = "0x1D7EF10", VA = "0x1D7EF10")]
		public DTObjectDump(object o, int indent = 0)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1D80140", Offset = "0x1D80140", VA = "0x1D80140", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1D7F2A8", Offset = "0x1D7F2A8", VA = "0x1D7F2A8")]
		private void AppendHeader(string name)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1D7F350", Offset = "0x1D7F350", VA = "0x1D7F350")]
		private void AppendMember(MemberInfo info)
		{
		}
	}
	[Token(Token = "0x2000045")]
	public static class DTUtility
	{
		[Token(Token = "0x1700001D")]
		public static bool IsEditorStateChange
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x1D83404", Offset = "0x1D83404", VA = "0x1D83404")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1D833FC", Offset = "0x1D833FC", VA = "0x1D833FC")]
		public static Material GetDefaultMaterial()
		{
			return null;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1D8340C", Offset = "0x1D8340C", VA = "0x1D8340C")]
		public static float GetHandleSize(Vector3 position)
		{
			return default(float);
		}

		[Token(Token = "0x600018B")]
		public static void SetPlayerPrefs<T>(string key, T value)
		{
		}

		[Token(Token = "0x600018C")]
		public static T GetPlayerPrefs<T>(string key, T defaultValue)
		{
			return (T)null;
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1D83820", Offset = "0x1D83820", VA = "0x1D83820")]
		public static float RandomSign()
		{
			return default(float);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1D83850", Offset = "0x1D83850", VA = "0x1D83850")]
		public static string GetHelpUrl(object forClass)
		{
			return null;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1D838C8", Offset = "0x1D838C8", VA = "0x1D838C8")]
		public static string GetHelpUrl(Type classType)
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1D83A54", Offset = "0x1D83A54", VA = "0x1D83A54")]
		public static Vector3 GetCenterPosition(Vector3 fallback, params Vector3[] vectors)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000191")]
		public static T CreateGameObject<T>(Transform parent, string name) where T : MonoBehaviour
		{
			return null;
		}
	}
	[Token(Token = "0x2000046")]
	public static class DTTime
	{
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float _EditorDeltaTime;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float _EditorLastTime;

		[Token(Token = "0x1700001E")]
		public static double TimeSinceStartup
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x1D7A788", Offset = "0x1D7A788", VA = "0x1D7A788")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700001F")]
		public static float deltaTime
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x1D802BC", Offset = "0x1D802BC", VA = "0x1D802BC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1D80330", Offset = "0x1D80330", VA = "0x1D80330")]
		public static void InitializeEditorTime()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1D8039C", Offset = "0x1D8039C", VA = "0x1D8039C")]
		public static void UpdateEditorTime()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class TimeMeasure : Ring<long>
	{
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Stopwatch mWatch;

		[Token(Token = "0x17000020")]
		public double LastTicks
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x1D8DB14", Offset = "0x1D8DB14", VA = "0x1D8DB14")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000021")]
		public double LastMS
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x1D8DB90", Offset = "0x1D8DB90", VA = "0x1D8DB90")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000022")]
		public double AverageMS
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x1D8DBB8", Offset = "0x1D8DBB8", VA = "0x1D8DBB8")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000023")]
		public double MinimumMS
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x1D8DCB8", Offset = "0x1D8DCB8", VA = "0x1D8DCB8")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000024")]
		public double MaximumMS
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x1D8DE00", Offset = "0x1D8DE00", VA = "0x1D8DE00")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000025")]
		public double AverageTicks
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x1D8DF48", Offset = "0x1D8DF48", VA = "0x1D8DF48")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000026")]
		public double MinimumTicks
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x1D8E038", Offset = "0x1D8E038", VA = "0x1D8E038")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000027")]
		public double MaximumTicks
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x1D8E170", Offset = "0x1D8E170", VA = "0x1D8E170")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1D8D96C", Offset = "0x1D8D96C", VA = "0x1D8D96C")]
		public TimeMeasure(int size)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1D8DA00", Offset = "0x1D8DA00", VA = "0x1D8DA00")]
		public void Start()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1D8DA28", Offset = "0x1D8DA28", VA = "0x1D8DA28")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1D8DAEC", Offset = "0x1D8DAEC", VA = "0x1D8DAEC")]
		public void Pause()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public static class DTMath
	{
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1D7D79C", Offset = "0x1D7D79C", VA = "0x1D7D79C")]
		public static Vector3 ParallelTransportFrame(Vector3 up, Vector3 tan0, Vector3 tan1)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1D7DA54", Offset = "0x1D7DA54", VA = "0x1D7DA54")]
		public static Vector3 LeftTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1D7DB0C", Offset = "0x1D7DB0C", VA = "0x1D7DB0C")]
		public static Vector3 RightTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1D7DBC4", Offset = "0x1D7DBC4", VA = "0x1D7DBC4")]
		public static float Repeat(float t, float length)
		{
			return default(float);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1D7DC64", Offset = "0x1D7DC64", VA = "0x1D7DC64")]
		public static double FixNaN(double v)
		{
			return default(double);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1D7DD04", Offset = "0x1D7DD04", VA = "0x1D7DD04")]
		public static float FixNaN(float v)
		{
			return default(float);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1D7DD34", Offset = "0x1D7DD34", VA = "0x1D7DD34")]
		public static Vector2 FixNaN(Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1D7DD7C", Offset = "0x1D7DD7C", VA = "0x1D7DD7C")]
		public static Vector3 FixNaN(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1D776C4", Offset = "0x1D776C4", VA = "0x1D776C4")]
		public static float MapValue(float min, float max, float value, float vMin = -1f, float vMax = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1D7DDE4", Offset = "0x1D7DDE4", VA = "0x1D7DDE4")]
		public static float SnapPrecision(float value, int decimals)
		{
			return default(float);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1D7DE8C", Offset = "0x1D7DE8C", VA = "0x1D7DE8C")]
		public static Vector2 SnapPrecision(Vector2 value, int decimals)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1D7DEF4", Offset = "0x1D7DEF4", VA = "0x1D7DEF4")]
		public static Vector3 SnapPrecision(Vector3 value, int decimals)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1D7DF80", Offset = "0x1D7DF80", VA = "0x1D7DF80")]
		public static float LinePointDistanceSqr(Vector3 l1, Vector3 l2, Vector3 p, out float frag)
		{
			return default(float);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1D7E268", Offset = "0x1D7E268", VA = "0x1D7E268")]
		public static bool RayLineSegmentIntersection(Vector2 r0, Vector2 dir, Vector2 l1, Vector2 l2, out Vector2 hit, out float frag)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1D7E418", Offset = "0x1D7E418", VA = "0x1D7E418")]
		public static bool ShortestIntersectionLine(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 resultSegmentA, out Vector3 resultSegmentB)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1D7E8C8", Offset = "0x1D7E8C8", VA = "0x1D7E8C8")]
		public static bool LineLineIntersection(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 hitPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1D7EAC4", Offset = "0x1D7EAC4", VA = "0x1D7EAC4")]
		public static bool LineLineIntersect(Vector2 line1A, Vector2 line1B, Vector2 line2A, Vector2 line2B, out Vector2 hitPoint, bool segmentOnly = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1D7EC60", Offset = "0x1D7EC60", VA = "0x1D7EC60")]
		public static bool PointInsideTriangle(Vector3 A, Vector3 B, Vector3 C, Vector3 p, out float ac, out float ab, bool edgesAllowed)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000049")]
	public class UnityEventEx<T0> : UnityEvent<T0>
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object mCallerList;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private MethodInfo mCallsCount;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mCount;

		[Token(Token = "0x60001B4")]
		public void AddListenerOnce(UnityAction<T0> call)
		{
		}

		[Token(Token = "0x60001B5")]
		public bool HasListeners()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		public void CheckForListeners()
		{
		}

		[Token(Token = "0x60001B7")]
		public UnityEventEx()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public static class DTLog
	{
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1D7D0E8", Offset = "0x1D7D0E8", VA = "0x1D7D0E8")]
		public static void Log(object message)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1D7D164", Offset = "0x1D7D164", VA = "0x1D7D164")]
		public static void Log(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1D7D1E8", Offset = "0x1D7D1E8", VA = "0x1D7D1E8")]
		public static void LogError(object message)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1D7D264", Offset = "0x1D7D264", VA = "0x1D7D264")]
		public static void LogError(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1D7D2E8", Offset = "0x1D7D2E8", VA = "0x1D7D2E8")]
		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1D7D36C", Offset = "0x1D7D36C", VA = "0x1D7D36C")]
		public static void LogErrorFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1D7D3F8", Offset = "0x1D7D3F8", VA = "0x1D7D3F8")]
		public static void LogException(Exception exception)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1D7D474", Offset = "0x1D7D474", VA = "0x1D7D474")]
		public static void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1D7D4F8", Offset = "0x1D7D4F8", VA = "0x1D7D4F8")]
		public static void LogFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1D7D57C", Offset = "0x1D7D57C", VA = "0x1D7D57C")]
		public static void LogFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1D7A5E4", Offset = "0x1D7A5E4", VA = "0x1D7A5E4")]
		public static void LogWarning(object message)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1D7D608", Offset = "0x1D7D608", VA = "0x1D7D608")]
		public static void LogWarning(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1D7D68C", Offset = "0x1D7D68C", VA = "0x1D7D68C")]
		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1D7D710", Offset = "0x1D7D710", VA = "0x1D7D710")]
		public static void LogWarningFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public struct FloatRegion : IEquatable<FloatRegion>
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float From;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float To;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SimpleValue;

		[Token(Token = "0x17000028")]
		public static FloatRegion ZeroOne
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x1D892BC", Offset = "0x1D892BC", VA = "0x1D892BC")]
			get
			{
				return default(FloatRegion);
			}
		}

		[Token(Token = "0x17000029")]
		public bool Positive
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x1D8947C", Offset = "0x1D8947C", VA = "0x1D8947C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		public float Low
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x1D8940C", Offset = "0x1D8940C", VA = "0x1D8940C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x1D89428", Offset = "0x1D89428", VA = "0x1D89428")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public float High
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x1D89444", Offset = "0x1D89444", VA = "0x1D89444")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x1D89460", Offset = "0x1D89460", VA = "0x1D89460")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public float Random
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x1D89498", Offset = "0x1D89498", VA = "0x1D89498")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public float Next
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x1D894AC", Offset = "0x1D894AC", VA = "0x1D894AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002E")]
		public float Length
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x1D894D4", Offset = "0x1D894D4", VA = "0x1D894D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002F")]
		public float LengthPositive
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x1D894E8", Offset = "0x1D894E8", VA = "0x1D894E8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1D89298", Offset = "0x1D89298", VA = "0x1D89298")]
		public FloatRegion(float value)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1D892AC", Offset = "0x1D892AC", VA = "0x1D892AC")]
		public FloatRegion(float A, float B)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1D892D4", Offset = "0x1D892D4", VA = "0x1D892D4")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1D892F0", Offset = "0x1D892F0", VA = "0x1D892F0")]
		public void Clamp(float low, float high)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1D8950C", Offset = "0x1D8950C", VA = "0x1D8950C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1D895B0", Offset = "0x1D895B0", VA = "0x1D895B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1D895DC", Offset = "0x1D895DC", VA = "0x1D895DC", Slot = "4")]
		public bool Equals(FloatRegion other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1D89618", Offset = "0x1D89618", VA = "0x1D89618", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1D896CC", Offset = "0x1D896CC", VA = "0x1D896CC")]
		public static FloatRegion operator +(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1D89704", Offset = "0x1D89704", VA = "0x1D89704")]
		public static FloatRegion operator -(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1D8973C", Offset = "0x1D8973C", VA = "0x1D8973C")]
		public static FloatRegion operator -(FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1D89754", Offset = "0x1D89754", VA = "0x1D89754")]
		public static FloatRegion operator *(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1D89788", Offset = "0x1D89788", VA = "0x1D89788")]
		public static FloatRegion operator *(float v, FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1D897BC", Offset = "0x1D897BC", VA = "0x1D897BC")]
		public static FloatRegion operator /(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1D897F0", Offset = "0x1D897F0", VA = "0x1D897F0")]
		public static bool operator ==(FloatRegion lhs, FloatRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1D898F0", Offset = "0x1D898F0", VA = "0x1D898F0")]
		public static bool operator !=(FloatRegion lhs, FloatRegion rhs)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public struct IntRegion : IEquatable<IntRegion>
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int From;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int To;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SimpleValue;

		[Token(Token = "0x17000030")]
		public static IntRegion ZeroOne
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x1D89CB4", Offset = "0x1D89CB4", VA = "0x1D89CB4")]
			get
			{
				return default(IntRegion);
			}
		}

		[Token(Token = "0x17000031")]
		public bool Positive
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x1D89E34", Offset = "0x1D89E34", VA = "0x1D89E34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000032")]
		public int Low
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x1D89DD0", Offset = "0x1D89DD0", VA = "0x1D89DD0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x1D89DE8", Offset = "0x1D89DE8", VA = "0x1D89DE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public int High
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x1D89E04", Offset = "0x1D89E04", VA = "0x1D89E04")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x1D89E18", Offset = "0x1D89E18", VA = "0x1D89E18")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public int Random
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x1D89E48", Offset = "0x1D89E48", VA = "0x1D89E48")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000035")]
		public int Length
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x1D89E5C", Offset = "0x1D89E5C", VA = "0x1D89E5C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000036")]
		public int LengthPositive
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x1D89E6C", Offset = "0x1D89E6C", VA = "0x1D89E6C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1D89C90", Offset = "0x1D89C90", VA = "0x1D89C90")]
		public IntRegion(int value)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1D89CA4", Offset = "0x1D89CA4", VA = "0x1D89CA4")]
		public IntRegion(int A, int B)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1D89CCC", Offset = "0x1D89CCC", VA = "0x1D89CCC")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1D89CE0", Offset = "0x1D89CE0", VA = "0x1D89CE0")]
		public void Clamp(int low, int high)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1D89E7C", Offset = "0x1D89E7C", VA = "0x1D89E7C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1D89F20", Offset = "0x1D89F20", VA = "0x1D89F20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1D89F4C", Offset = "0x1D89F4C", VA = "0x1D89F4C", Slot = "4")]
		public bool Equals(IntRegion other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1D89F88", Offset = "0x1D89F88", VA = "0x1D89F88", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1D8A02C", Offset = "0x1D8A02C", VA = "0x1D8A02C")]
		public static IntRegion operator +(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1D8A054", Offset = "0x1D8A054", VA = "0x1D8A054")]
		public static IntRegion operator -(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1D8A07C", Offset = "0x1D8A07C", VA = "0x1D8A07C")]
		public static IntRegion operator -(IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1D8A094", Offset = "0x1D8A094", VA = "0x1D8A094")]
		public static IntRegion operator *(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1D8A0B4", Offset = "0x1D8A0B4", VA = "0x1D8A0B4")]
		public static IntRegion operator *(int v, IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1D8A0D4", Offset = "0x1D8A0D4", VA = "0x1D8A0D4")]
		public static IntRegion operator /(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1D8A118", Offset = "0x1D8A118", VA = "0x1D8A118")]
		public static bool operator ==(IntRegion lhs, IntRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1D8A158", Offset = "0x1D8A158", VA = "0x1D8A158")]
		public static bool operator !=(IntRegion lhs, IntRegion rhs)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200004D")]
	public class WeightedRandom<T>
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mData;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mCurrentPosition;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T mCurrentItem;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7DBC", Offset = "0x6F7DBC")]
		private int <Seed>k__BackingField;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7DCC", Offset = "0x6F7DCC")]
		private bool <RandomizeSeed>k__BackingField;

		[Token(Token = "0x17000037")]
		public int Seed
		{
			[Token(Token = "0x60001F9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702EA8", Offset = "0x702EA8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001FA")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702EB8", Offset = "0x702EB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool RandomizeSeed
		{
			[Token(Token = "0x60001FB")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702EC8", Offset = "0x702EC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702ED8", Offset = "0x702ED8")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		private int Capacity
		{
			[Token(Token = "0x60001FD")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003A")]
		public int Size
		{
			[Token(Token = "0x60001FE")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001FF")]
		public WeightedRandom(int initCapacity = 0)
		{
		}

		[Token(Token = "0x6000200")]
		public void Add(T item, int amount)
		{
		}

		[Token(Token = "0x6000201")]
		public T Next()
		{
			return (T)null;
		}

		[Token(Token = "0x6000202")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000203")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6F53E0", Offset = "0x6F53E0")]
	public class Ring<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mList;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7DDC", Offset = "0x6F7DDC")]
		private int <Size>k__BackingField;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mIndex;

		[Token(Token = "0x1700003B")]
		public int Size
		{
			[Token(Token = "0x6000204")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702EE8", Offset = "0x702EE8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000205")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702EF8", Offset = "0x702EF8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public T Item
		{
			[Token(Token = "0x600020C")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x600020D")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public int Count
		{
			[Token(Token = "0x6000211")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003E")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000212")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000206")]
		public Ring(int size)
		{
		}

		[Token(Token = "0x6000207")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x6000208")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000209")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x600020A")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x600020B")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x600020E")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000210")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000213")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x200004F")]
	public class Pool<T> : IPool
	{
		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mObjects;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7DEC", Offset = "0x6F7DEC")]
		private string <Identifier>k__BackingField;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7DFC", Offset = "0x6F7DFC")]
		private PoolSettings <Settings>k__BackingField;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double mLastTime;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double mDeltaTime;

		[Token(Token = "0x1700003F")]
		public string Identifier
		{
			[Token(Token = "0x6000215")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702F08", Offset = "0x702F08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000216")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702F18", Offset = "0x702F18")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public PoolSettings Settings
		{
			[Token(Token = "0x6000217")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702F28", Offset = "0x702F28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000218")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702F38", Offset = "0x702F38")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public Type Type
		{
			[Token(Token = "0x6000219")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public int Count
		{
			[Token(Token = "0x600021E")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600021A")]
		public Pool([Optional] PoolSettings settings)
		{
		}

		[Token(Token = "0x600021B")]
		public void Update()
		{
		}

		[Token(Token = "0x600021C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600021D")]
		public void Clear()
		{
		}

		[Token(Token = "0x600021F")]
		public virtual T Pop([Optional] Transform parent)
		{
			return (T)null;
		}

		[Token(Token = "0x6000220")]
		public virtual void Push(T item)
		{
		}

		[Token(Token = "0x6000221")]
		protected virtual void sendBeforePush(T item)
		{
		}

		[Token(Token = "0x6000222")]
		protected virtual void sendAfterPop(T item)
		{
		}

		[Token(Token = "0x6000223")]
		protected virtual void setParent(T item, Transform parent)
		{
		}

		[Token(Token = "0x6000224")]
		protected virtual T create()
		{
			return (T)null;
		}

		[Token(Token = "0x6000225")]
		protected virtual void destroy(T item)
		{
		}

		[Token(Token = "0x6000226")]
		private void log(string msg)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class PoolSettings
	{
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private bool m_Prewarm;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		[SerializeField]
		private bool m_AutoCreate;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		[SerializeField]
		private bool m_AutoEnableDisable;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[Positive]
		[SerializeField]
		private int m_MinItems;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Positive]
		[SerializeField]
		private int m_Threshold;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Positive]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Debug;

		[Token(Token = "0x17000043")]
		public bool Prewarm
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x1D8BA54", Offset = "0x1D8BA54", VA = "0x1D8BA54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x1D8B860", Offset = "0x1D8B860", VA = "0x1D8B860")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public bool AutoCreate
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x1D8BA5C", Offset = "0x1D8BA5C", VA = "0x1D8BA5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x1D8B87C", Offset = "0x1D8B87C", VA = "0x1D8B87C")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public bool AutoEnableDisable
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x1D8BA64", Offset = "0x1D8BA64", VA = "0x1D8BA64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x1D8BA6C", Offset = "0x1D8BA6C", VA = "0x1D8BA6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public int MinItems
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x1D8BA88", Offset = "0x1D8BA88", VA = "0x1D8BA88")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x1D8B898", Offset = "0x1D8B898", VA = "0x1D8B898")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public int Threshold
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x1D8BA90", Offset = "0x1D8BA90", VA = "0x1D8BA90")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x1D8B928", Offset = "0x1D8B928", VA = "0x1D8B928")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public float Speed
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x1D8BA98", Offset = "0x1D8BA98", VA = "0x1D8BA98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x1D8B9BC", Offset = "0x1D8B9BC", VA = "0x1D8B9BC")]
			set
			{
			}
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1D8B848", Offset = "0x1D8B848", VA = "0x1D8B848")]
		public PoolSettings()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1D8B0D8", Offset = "0x1D8B0D8", VA = "0x1D8B0D8")]
		public PoolSettings(PoolSettings src)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1D7A37C", Offset = "0x1D7A37C", VA = "0x1D7A37C")]
		public void OnValidate()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public interface IPool
	{
		[Token(Token = "0x17000049")]
		string Identifier
		{
			[Token(Token = "0x6000236")]
			get;
			[Token(Token = "0x6000237")]
			set;
		}

		[Token(Token = "0x1700004A")]
		PoolSettings Settings
		{
			[Token(Token = "0x6000238")]
			get;
		}

		[Token(Token = "0x1700004B")]
		int Count
		{
			[Token(Token = "0x600023C")]
			get;
		}

		[Token(Token = "0x6000239")]
		void Clear();

		[Token(Token = "0x600023A")]
		void Reset();

		[Token(Token = "0x600023B")]
		void Update();
	}
	[Token(Token = "0x2000052")]
	public interface IPoolable
	{
		[Token(Token = "0x600023D")]
		void OnBeforePush();

		[Token(Token = "0x600023E")]
		void OnAfterPop();
	}
	[Token(Token = "0x2000053")]
	public enum DTMessageType
	{
		[Token(Token = "0x400014A")]
		None,
		[Token(Token = "0x400014B")]
		Info,
		[Token(Token = "0x400014C")]
		Warning,
		[Token(Token = "0x400014D")]
		Error
	}
	[Token(Token = "0x2000054")]
	public enum AttributeOptionsFlags
	{
		[Token(Token = "0x400014F")]
		None = 0,
		[Token(Token = "0x4000150")]
		Compact = 1,
		[Token(Token = "0x4000151")]
		Clipboard = 128,
		[Token(Token = "0x4000152")]
		Zero = 256,
		[Token(Token = "0x4000153")]
		One = 512,
		[Token(Token = "0x4000154")]
		Negate = 1024,
		[Token(Token = "0x4000155")]
		Full = 1920,
		[Token(Token = "0x4000156")]
		FullCompact = 1921
	}
	[Token(Token = "0x2000055")]
	public class DTPropertyAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Label;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string Tooltip;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Color;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AttributeOptionsFlags Options;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Precision;

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1D7A200", Offset = "0x1D7A200", VA = "0x1D7A200")]
		public DTPropertyAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class LabelAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1D8A19C", Offset = "0x1D8A19C", VA = "0x1D8A19C")]
		public LabelAttribute()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1D8A1FC", Offset = "0x1D8A1FC", VA = "0x1D8A1FC")]
		public LabelAttribute(string label, string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class ToggleButtonAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1D8E29C", Offset = "0x1D8E29C", VA = "0x1D8E29C")]
		public ToggleButtonAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class LayerAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1D8A200", Offset = "0x1D8A200", VA = "0x1D8A200")]
		public LayerAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class TagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1D8D0DC", Offset = "0x1D8D0DC", VA = "0x1D8D0DC")]
		public TagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class VectorExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1D8E2A0", Offset = "0x1D8E2A0", VA = "0x1D8E2A0")]
		public VectorExAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class AnimationCurveExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1D7A1E4", Offset = "0x1D7A1E4", VA = "0x1D7A1E4")]
		public AnimationCurveExAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class MinAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MinValue;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string MinFieldOrPropertyName;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1D8A258", Offset = "0x1D8A258", VA = "0x1D8A258")]
		public MinAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1D8A27C", Offset = "0x1D8A27C", VA = "0x1D8A27C")]
		public MinAttribute(string fieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class PositiveAttribute : MinAttribute
	{
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1D8BAA0", Offset = "0x1D8BAA0", VA = "0x1D8BAA0")]
		public PositiveAttribute()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class MaxAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MaxValue;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string MaxFieldOrPropertyName;

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1D8A204", Offset = "0x1D8A204", VA = "0x1D8A204")]
		public MaxAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1D8A228", Offset = "0x1D8A228", VA = "0x1D8A228")]
		public MaxAttribute(string fieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class RangeExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MinValue;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string MinFieldOrPropertyName;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float MaxValue;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string MaxFieldOrPropertyName;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool Slider;

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1D8CCE8", Offset = "0x1D8CCE8", VA = "0x1D8CCE8")]
		public RangeExAttribute(float minValue, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1D8CD20", Offset = "0x1D8CD20", VA = "0x1D8CD20")]
		public RangeExAttribute(string minFieldOrProperty, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1D8CD64", Offset = "0x1D8CD64", VA = "0x1D8CD64")]
		public RangeExAttribute(float minValue, string maxFieldOrProperty, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1D8CDA8", Offset = "0x1D8CDA8", VA = "0x1D8CDA8")]
		public RangeExAttribute(string minFieldOrProperty, string maxFieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class MinMaxAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly string MaxValueField;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Min;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public string MinBoundFieldOrPropertyName;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Max;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public string MaxBoundFieldOrPropertyName;

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1D8A2AC", Offset = "0x1D8A2AC", VA = "0x1D8A2AC")]
		public MinMaxAttribute(string maxValueField, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class EnumFlagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1D844FC", Offset = "0x1D844FC", VA = "0x1D844FC")]
		public EnumFlagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class ObjectSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1D8A3F8", Offset = "0x1D8A3F8", VA = "0x1D8A3F8")]
		public ObjectSelectorAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class PathSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x200015D")]
		public enum DialogMode
		{
			[Token(Token = "0x4000588")]
			OpenFile,
			[Token(Token = "0x4000589")]
			OpenFolder,
			[Token(Token = "0x400058A")]
			CreateFile
		}

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly DialogMode Mode;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Title;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public string Directory;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Extension;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public string DefaultName;

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1D8A3FC", Offset = "0x1D8A3FC", VA = "0x1D8A3FC")]
		public PathSelectorAttribute(DialogMode mode = DialogMode.OpenFile)
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class EnumSelectionGridAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1D84500", Offset = "0x1D84500", VA = "0x1D84500")]
		public EnumSelectionGridAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class DTRegionAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool RegionIsOptional;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string RegionOptionsPropertyName;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool UseSlider;

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1D80254", Offset = "0x1D80254", VA = "0x1D80254")]
		public DTRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class FloatRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1D899F0", Offset = "0x1D899F0", VA = "0x1D899F0")]
		public FloatRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class IntRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1D8A198", Offset = "0x1D8A198", VA = "0x1D8A198")]
		public IntRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public struct RegionOptions<T>
	{
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string LabelFrom;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string LabelTo;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string OptionalTooltip;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DTValueClamping ClampFrom;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DTValueClamping ClampTo;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T FromMin;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T FromMax;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T ToMin;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T ToMax;

		[Token(Token = "0x1700004C")]
		public static RegionOptions<T> Default
		{
			[Token(Token = "0x6000258")]
			get
			{
				return default(RegionOptions<T>);
			}
		}

		[Token(Token = "0x6000259")]
		public static RegionOptions<T> MinMax(T min, T max)
		{
			return default(RegionOptions<T>);
		}
	}
	[Token(Token = "0x2000069")]
	public enum DTValueClamping
	{
		[Token(Token = "0x400017C")]
		None,
		[Token(Token = "0x400017D")]
		Min,
		[Token(Token = "0x400017E")]
		Max,
		[Token(Token = "0x400017F")]
		Range
	}
	[Token(Token = "0x200006A")]
	public class ThreadPoolWorker<T> : IDisposable
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SimplePool<QueuedCallback> queuedCallbackPool;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SimplePool<LoopState<T>> loopStatePool;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _remainingWorkItems;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ManualResetEvent _done;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private WaitCallback handleWorkItemCallBack;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private WaitCallback handleLoopCallBack;

		[Token(Token = "0x600025A")]
		public ThreadPoolWorker()
		{
		}

		[Token(Token = "0x600025B")]
		public void ParralelFor(Action<T> action, List<T> list)
		{
		}

		[Token(Token = "0x600025C")]
		private bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x600025D")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x600025E")]
		private void DoneWorkItem()
		{
		}

		[Token(Token = "0x600025F")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000260")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702F48", Offset = "0x702F48")]
		private void <.ctor>b__6_0(object o)
		{
		}

		[Token(Token = "0x6000261")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702F58", Offset = "0x702F58")]
		private void <.ctor>b__6_1(object state)
		{
		}
	}
	[Token(Token = "0x200006B")]
	internal class SimplePool<T> where T : new()
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<T> freeItemsBackfield;

		[Token(Token = "0x6000262")]
		public SimplePool(int preCreatedElementsCount)
		{
		}

		[Token(Token = "0x6000263")]
		public T GetItem()
		{
			return (T)null;
		}

		[Token(Token = "0x6000264")]
		public void ReleaseItem(T item)
		{
		}
	}
	[Token(Token = "0x200006C")]
	internal class QueuedCallback
	{
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public WaitCallback Callback;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public object State;

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1D8CCE0", Offset = "0x1D8CCE0", VA = "0x1D8CCE0")]
		public QueuedCallback()
		{
		}
	}
	[Token(Token = "0x200006D")]
	internal class LoopState<T>
	{
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short StartIndex;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short EndIndex;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<T> Items;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> Action;

		[Token(Token = "0x6000266")]
		public LoopState()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class ThreadPoolWorker : IDisposable
	{
		[Serializable]
		[Token(Token = "0x200015E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F782C", Offset = "0x6F782C")]
		private sealed class <>c__4<T>
		{
			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__4<T> <>9;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static WaitCallback <>9__4_0;

			[Token(Token = "0x6000AF2")]
			public <>c__4()
			{
			}

			[Token(Token = "0x6000AF3")]
			internal void <ParralelFor>b__4_0(object state)
			{
			}
		}

		[Token(Token = "0x200015F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F783C", Offset = "0x6F783C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Action act;

			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x1D8D4AC", Offset = "0x1D8D4AC", VA = "0x1D8D4AC")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0x1D8D944", Offset = "0x1D8D944", VA = "0x1D8D944")]
			internal void <QueueWorkItem>b__0(object x)
			{
			}
		}

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int _remainingWorkItems;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private ManualResetEvent _done;

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1D8D0E0", Offset = "0x1D8D0E0", VA = "0x1D8D0E0")]
		public void QueueWorkItem(WaitCallback callback)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1D8D1A8", Offset = "0x1D8D1A8", VA = "0x1D8D1A8")]
		public void QueueWorkItem(Action act)
		{
		}

		[Token(Token = "0x6000269")]
		public void ParralelFor<T>(Action<T> action, List<T> list)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1D8D2E4", Offset = "0x1D8D2E4", VA = "0x1D8D2E4")]
		private void QueueWorkItem(QueuedCallback callback)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1D8D0E8", Offset = "0x1D8D0E8", VA = "0x1D8D0E8")]
		public void QueueWorkItem(WaitCallback callback, object state)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1D8D1B0", Offset = "0x1D8D1B0", VA = "0x1D8D1B0")]
		public void QueueWorkItem(Action act, object state)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1D8D4B4", Offset = "0x1D8D4B4", VA = "0x1D8D4B4")]
		public bool WaitAll()
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1D8D5D0", Offset = "0x1D8D5D0", VA = "0x1D8D5D0")]
		public bool WaitAll(TimeSpan timeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1D8D4C0", Offset = "0x1D8D4C0", VA = "0x1D8D4C0")]
		public bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1D8D6C0", Offset = "0x1D8D6C0", VA = "0x1D8D6C0")]
		private void HandleWorkItem(object state)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1D8D610", Offset = "0x1D8D610", VA = "0x1D8D610")]
		private void DoneWorkItem()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1D8D3F4", Offset = "0x1D8D3F4", VA = "0x1D8D3F4")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1D8D7D8", Offset = "0x1D8D7D8", VA = "0x1D8D7D8", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1D8D8B8", Offset = "0x1D8D8B8", VA = "0x1D8D8B8")]
		public ThreadPoolWorker()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class ComponentPool : MonoBehaviour, IPool, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F784C", Offset = "0x6F784C")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string typeName;

			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0x1D7BE00", Offset = "0x1D7BE00", VA = "0x1D7BE00")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x1D7BFD0", Offset = "0x1D7BFD0", VA = "0x1D7BFD0")]
			internal bool <OnAfterDeserialize>b__0(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		[HideInInspector]
		private string m_Identifier;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Inline]
		[SerializeField]
		private PoolSettings m_Settings;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private PoolManager mManager;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<UnityEngine.Component> mObjects;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private double mLastTime;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private double mDeltaTime;

		[Token(Token = "0x1700004D")]
		public PoolSettings Settings
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x1D7A334", Offset = "0x1D7A334", VA = "0x1D7A334", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x1D7A33C", Offset = "0x1D7A33C", VA = "0x1D7A33C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public PoolManager Manager
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x1D7A3AC", Offset = "0x1D7A3AC", VA = "0x1D7A3AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public string Identifier
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x1D7A468", Offset = "0x1D7A468", VA = "0x1D7A468", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x1D7A470", Offset = "0x1D7A470", VA = "0x1D7A470", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public Type Type
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x1D7A4FC", Offset = "0x1D7A4FC", VA = "0x1D7A4FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public int Count
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x1D7A660", Offset = "0x1D7A660", VA = "0x1D7A660", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1D7A6B8", Offset = "0x1D7A6B8", VA = "0x1D7A6B8")]
		public void Initialize(Type type, PoolSettings settings)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1D7A920", Offset = "0x1D7A920", VA = "0x1D7A920")]
		private void Start()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1D7A958", Offset = "0x1D7A958", VA = "0x1D7A958")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1D7AA18", Offset = "0x1D7AA18", VA = "0x1D7AA18")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1D7AA1C", Offset = "0x1D7AA1C", VA = "0x1D7AA1C", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1D7A7A8", Offset = "0x1D7A7A8", VA = "0x1D7A7A8", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1D7B030", Offset = "0x1D7B030", VA = "0x1D7B030")]
		public void OnSceneLoaded(Scene scn, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1D7B14C", Offset = "0x1D7B14C", VA = "0x1D7B14C", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1D7B230", Offset = "0x1D7B230", VA = "0x1D7B230")]
		public void Push(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1D7B614", Offset = "0x1D7B614", VA = "0x1D7B614")]
		public UnityEngine.Component Pop([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		public T Pop<T>(Transform parent) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1D7AEE0", Offset = "0x1D7AEE0", VA = "0x1D7AEE0")]
		private UnityEngine.Component create()
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x1D7AE10", Offset = "0x1D7AE10", VA = "0x1D7AE10")]
		private void destroy(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1D7BAA0", Offset = "0x1D7BAA0", VA = "0x1D7BAA0")]
		private void setParent(UnityEngine.Component item, Transform parent)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1D7B88C", Offset = "0x1D7B88C", VA = "0x1D7B88C")]
		private void sendAfterPop(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1D7B400", Offset = "0x1D7B400", VA = "0x1D7B400")]
		private void sendBeforePush(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1D7AD30", Offset = "0x1D7AD30", VA = "0x1D7AD30")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1D7BB68", Offset = "0x1D7BB68", VA = "0x1D7BB68", Slot = "11")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1D7BB6C", Offset = "0x1D7BB6C", VA = "0x1D7BB6C", Slot = "12")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1D7BF40", Offset = "0x1D7BF40", VA = "0x1D7BF40")]
		public ComponentPool()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class DTSingleton<T> : MonoBehaviour, IDTSingleton where T : MonoBehaviour, IDTSingleton
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool applicationIsQuitting;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool isDuplicateInstance;

		[Token(Token = "0x17000052")]
		public static bool HasInstance
		{
			[Token(Token = "0x6000290")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		public static T Instance
		{
			[Token(Token = "0x6000291")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000292")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x6000293")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000294")]
		public virtual void MergeDoubleLoaded(IDTSingleton newInstance)
		{
		}

		[Token(Token = "0x6000295")]
		private void DestroySelf()
		{
		}

		[Token(Token = "0x6000296")]
		public DTSingleton()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public interface IDTSingleton
	{
		[Token(Token = "0x6000298")]
		void MergeDoubleLoaded(IDTSingleton newInstance);
	}
	[Token(Token = "0x2000072")]
	public class DTVersionedMonoBehaviour : MonoBehaviour
	{
		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		[HideInInspector]
		private string m_Version;

		[Token(Token = "0x17000054")]
		public string Version
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x1D83C14", Offset = "0x1D83C14", VA = "0x1D83C14")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x1D83C1C", Offset = "0x1D83C1C", VA = "0x1D83C1C")]
			protected set
			{
			}
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1D83C24", Offset = "0x1D83C24", VA = "0x1D83C24")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x702F68", Offset = "0x702F68")]
		protected void CheckForVersionUpgrade()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1D83C28", Offset = "0x1D83C28", VA = "0x1D83C28", Slot = "4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x702F9C", Offset = "0x702F9C")]
		protected virtual bool UpgradeVersion(string oldVersion, string newVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1D84028", Offset = "0x1D84028", VA = "0x1D84028")]
		public void Destroy()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1D840F4", Offset = "0x1D840F4", VA = "0x1D840F4")]
		public DTVersionedMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[ExecuteInEditMode]
	public class DuplicateEditorMesh : MonoBehaviour
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private MeshFilter mFilter;

		[Token(Token = "0x17000055")]
		public MeshFilter Filter
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x1D840FC", Offset = "0x1D840FC", VA = "0x1D840FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1D841B8", Offset = "0x1D841B8", VA = "0x1D841B8", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1D844F4", Offset = "0x1D844F4", VA = "0x1D844F4")]
		public DuplicateEditorMesh()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class InspectorNote : MonoBehaviour
	{
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x6F7F5C", Offset = "0x6F7F5C")]
		[SerializeField]
		private string m_Note;

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1D89C88", Offset = "0x1D89C88", VA = "0x1D89C88")]
		public InspectorNote()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class PoolManager : MonoBehaviour
	{
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6F7F94", Offset = "0x6F7F94")]
		[SerializeField]
		private bool m_AutoCreatePools;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "AsGroupAttribute", RVA = "0x6F7FF8", Offset = "0x6F7FF8")]
		[SerializeField]
		private PoolSettings m_DefaultSettings;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8038", Offset = "0x6F8038")]
		private bool <IsInitialized>k__BackingField;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, IPool> Pools;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Dictionary<Type, IPool> TypePools;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IPool[] mPools;

		[Token(Token = "0x17000056")]
		public bool AutoCreatePools
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x1D8A47C", Offset = "0x1D8A47C", VA = "0x1D8A47C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x1D8A484", Offset = "0x1D8A484", VA = "0x1D8A484")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public PoolSettings DefaultSettings
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x1D8A4A0", Offset = "0x1D8A4A0", VA = "0x1D8A4A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x1D8A4A8", Offset = "0x1D8A4A8", VA = "0x1D8A4A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public bool IsInitialized
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x1D8A4E8", Offset = "0x1D8A4E8", VA = "0x1D8A4E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702FD0", Offset = "0x702FD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x1D8A4F0", Offset = "0x1D8A4F0", VA = "0x1D8A4F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702FE0", Offset = "0x702FE0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public int Count
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x1D8A4F8", Offset = "0x1D8A4F8", VA = "0x1D8A4F8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1D8A594", Offset = "0x1D8A594", VA = "0x1D8A594")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1D8A5A0", Offset = "0x1D8A5A0", VA = "0x1D8A5A0")]
		private void Update()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1D8A7B4", Offset = "0x1D8A7B4", VA = "0x1D8A7B4")]
		private void Initialize()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1D8AD2C", Offset = "0x1D8AD2C", VA = "0x1D8AD2C")]
		public string GetUniqueIdentifier(string ident)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		public Pool<T> GetTypePool<T>()
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		public ComponentPool GetComponentPool<T>() where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1D8ADF4", Offset = "0x1D8ADF4", VA = "0x1D8ADF4")]
		public PrefabPool GetPrefabPool(string identifier, params GameObject[] prefabs)
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		public Pool<T> CreateTypePool<T>([Optional] PoolSettings settings)
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		public ComponentPool CreateComponentPool<T>([Optional] PoolSettings settings) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1D8AF18", Offset = "0x1D8AF18", VA = "0x1D8AF18")]
		public PrefabPool CreatePrefabPool(string name, [Optional] PoolSettings settings, params GameObject[] prefabs)
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1D8B2BC", Offset = "0x1D8B2BC", VA = "0x1D8B2BC")]
		public List<IPool> FindPools(string identifierStartsWith)
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1D8B470", Offset = "0x1D8B470", VA = "0x1D8B470")]
		public void DeletePools(string startsWith)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1D8B524", Offset = "0x1D8B524", VA = "0x1D8B524")]
		public void DeletePool(IPool pool)
		{
		}

		[Token(Token = "0x60002B7")]
		public void DeletePool<T>()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1D8B704", Offset = "0x1D8B704", VA = "0x1D8B704")]
		public PoolManager()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F5454", Offset = "0x6F5454")]
	public class PrefabPool : MonoBehaviour, IPool
	{
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6F8048", Offset = "0x6F8048")]
		[SerializeField]
		private string m_Identifier;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<GameObject> m_Prefabs;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Inline]
		[SerializeField]
		private PoolSettings m_Settings;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PoolManager mManager;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private List<GameObject> mObjects;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private double mLastTime;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private double mDeltaTime;

		[Token(Token = "0x1700005A")]
		public string Identifier
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x1D8BB08", Offset = "0x1D8BB08", VA = "0x1D8BB08", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x1D8BB10", Offset = "0x1D8BB10", VA = "0x1D8BB10", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public List<GameObject> Prefabs
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x1D8BC44", Offset = "0x1D8BC44", VA = "0x1D8BC44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x1D8BC4C", Offset = "0x1D8BC4C", VA = "0x1D8BC4C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public PoolSettings Settings
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x1D8BC60", Offset = "0x1D8BC60", VA = "0x1D8BC60", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x1D8BC68", Offset = "0x1D8BC68", VA = "0x1D8BC68")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public PoolManager Manager
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x1D8BB88", Offset = "0x1D8BB88", VA = "0x1D8BB88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public int Count
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1D8C170", Offset = "0x1D8C170", VA = "0x1D8C170", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1D8BCA8", Offset = "0x1D8BCA8", VA = "0x1D8BCA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1D8BCAC", Offset = "0x1D8BCAC", VA = "0x1D8BCAC")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1D8B188", Offset = "0x1D8B188", VA = "0x1D8B188")]
		public void Initialize(string ident, PoolSettings settings, params GameObject[] prefabs)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1D8BE5C", Offset = "0x1D8BE5C", VA = "0x1D8BE5C", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1D8BCE4", Offset = "0x1D8BCE4", VA = "0x1D8BCE4", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1D8C584", Offset = "0x1D8C584", VA = "0x1D8C584", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1D8C668", Offset = "0x1D8C668", VA = "0x1D8C668")]
		public GameObject Pop([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1D8C934", Offset = "0x1D8C934", VA = "0x1D8C934", Slot = "11")]
		public virtual void Push(GameObject item)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1D8C324", Offset = "0x1D8C324", VA = "0x1D8C324")]
		private GameObject create()
		{
			return null;
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1D8C2A8", Offset = "0x1D8C2A8", VA = "0x1D8C2A8")]
		private void destroy(GameObject go)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1D8C1C8", Offset = "0x1D8C1C8", VA = "0x1D8C1C8")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1D8CB84", Offset = "0x1D8CB84", VA = "0x1D8CB84")]
		private void setParent(Transform item, Transform parent)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1D8C8C4", Offset = "0x1D8C8C4", VA = "0x1D8C8C4")]
		private void sendAfterPop(GameObject item)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1D8CB14", Offset = "0x1D8CB14", VA = "0x1D8CB14")]
		private void sendBeforePush(GameObject item)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1D8CC30", Offset = "0x1D8CC30", VA = "0x1D8CC30")]
		public PrefabPool()
		{
		}
	}
}
namespace FluffyUnderware.DevTools.Extensions
{
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6F54C4", Offset = "0x6F54C4")]
	public static class TransformExt
	{
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1D878E0", Offset = "0x1D878E0", VA = "0x1D878E0")]
		public static void CopyFrom(this Transform t, Transform other)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1D879C0", Offset = "0x1D879C0", VA = "0x1D879C0")]
		public static void SetChildrenHideFlags(this Transform t, HideFlags flags)
		{
		}
	}
	[Token(Token = "0x2000078")]
	public static class ObjectExt
	{
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1D86A24", Offset = "0x1D86A24", VA = "0x1D86A24")]
		public static void Destroy(this UnityEngine.Object c)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1D86AA0", Offset = "0x1D86AA0", VA = "0x1D86AA0")]
		public static string ToDumpString(this object o)
		{
			return null;
		}
	}
	[Token(Token = "0x2000079")]
	public static class Vector2Ext
	{
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1D88A3C", Offset = "0x1D88A3C", VA = "0x1D88A3C")]
		public static Vector2 Snap(this Vector2 v, float snapX, float snapY = -1f)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1D88AC8", Offset = "0x1D88AC8", VA = "0x1D88AC8")]
		public static float AngleSigned(this Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1D88BD4", Offset = "0x1D88BD4", VA = "0x1D88BD4")]
		public static Vector2 LeftNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1D88C00", Offset = "0x1D88C00", VA = "0x1D88C00")]
		public static Vector2 RightNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1D88C2C", Offset = "0x1D88C2C", VA = "0x1D88C2C")]
		public static Vector2 Rotate(this Vector2 v, float degree)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1D88D10", Offset = "0x1D88D10", VA = "0x1D88D10")]
		public static Vector2 ToVector3(this Vector2 v)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x200007A")]
	public static class Vector3Ext
	{
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1D88DCC", Offset = "0x1D88DCC", VA = "0x1D88DCC")]
		public static float AngleSigned(this Vector3 a, Vector3 b, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1D88F0C", Offset = "0x1D88F0C", VA = "0x1D88F0C")]
		public static Vector3 RotateAround(this Vector3 point, Vector3 origin, Quaternion rotation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1D8904C", Offset = "0x1D8904C", VA = "0x1D8904C")]
		public static Vector2 ToVector2(this Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1D8906C", Offset = "0x1D8906C", VA = "0x1D8906C")]
		public static bool Approximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1D89148", Offset = "0x1D89148", VA = "0x1D89148")]
		public static bool NotApproximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200007B")]
	public static class QuaternionExt
	{
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1D86B28", Offset = "0x1D86B28", VA = "0x1D86B28")]
		public static bool SameOrientation(this Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1D86C60", Offset = "0x1D86C60", VA = "0x1D86C60")]
		public static bool DifferentOrientation(this Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200007C")]
	public static class CameraExt
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Plane[] camPlanes;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static Vector3 camPos;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Vector3 camForward;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static float fov;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float screenW;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static float screenH;

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1D84504", Offset = "0x1D84504", VA = "0x1D84504")]
		public static bool BoundsInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1D84970", Offset = "0x1D84970", VA = "0x1D84970")]
		public static bool BoundsPartiallyInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200007D")]
	public static class GameObjectExt
	{
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1D85D10", Offset = "0x1D85D10", VA = "0x1D85D10")]
		public static GameObject DuplicateGameObject(this GameObject source, Transform newParent, bool keepPrefabReference = false)
		{
			return null;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1D854A4", Offset = "0x1D854A4", VA = "0x1D854A4")]
		public static void StripComponents(this GameObject go, params Type[] toKeep)
		{
		}
	}
	[Token(Token = "0x200007E")]
	public static class ComponentExt
	{
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1D85384", Offset = "0x1D85384", VA = "0x1D85384")]
		public static void StripComponents(this UnityEngine.Component c, params Type[] toKeep)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1D8571C", Offset = "0x1D8571C", VA = "0x1D8571C")]
		public static GameObject AddChildGameObject(this UnityEngine.Component c, string name)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		public static T AddChildGameObject<T>(this UnityEngine.Component c, string name) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		public static T DuplicateGameObject<T>(this UnityEngine.Component source, Transform newParent, bool keepPrefabConnection = false) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1D857E0", Offset = "0x1D857E0", VA = "0x1D857E0")]
		public static UnityEngine.Component DuplicateGameObject(this UnityEngine.Component source, Transform newParent, bool keepPrefabConnection = false)
		{
			return null;
		}
	}
	[Token(Token = "0x200007F")]
	public static class ColorExt
	{
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1D85110", Offset = "0x1D85110", VA = "0x1D85110")]
		public static string ToHtml(this Color c)
		{
			return null;
		}
	}
	[Token(Token = "0x2000080")]
	public static class EnumExt
	{
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1D85A90", Offset = "0x1D85A90", VA = "0x1D85A90")]
		public static bool HasFlag(this Enum variable, params Enum[] flags)
		{
			return default(bool);
		}

		[Token(Token = "0x60002ED")]
		public static bool HasFlag<T>(this T value, T flag) where T : struct
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		public static T Set<T>(this Enum value, T append)
		{
			return (T)null;
		}

		[Token(Token = "0x60002EF")]
		public static T Set<T>(this Enum value, T append, bool OnOff)
		{
			return (T)null;
		}

		[Token(Token = "0x60002F0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7031E0", Offset = "0x7031E0")]
		public static T Toggle<T>(this Enum value, T toggleValue)
		{
			return (T)null;
		}

		[Token(Token = "0x60002F1")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x703228", Offset = "0x703228")]
		public static T SetAll<T>(this Enum value)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000081")]
	public static class RectExt
	{
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1D86D98", Offset = "0x1D86D98", VA = "0x1D86D98")]
		public static Rect Set(this Rect rect, Vector2 pos, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1D86E04", Offset = "0x1D86E04", VA = "0x1D86E04")]
		public static Rect SetBetween(this Rect rect, Vector2 pos, Vector2 pos2)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1D86E94", Offset = "0x1D86E94", VA = "0x1D86E94")]
		public static Rect SetPosition(this Rect rect, Vector2 pos)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1D86F08", Offset = "0x1D86F08", VA = "0x1D86F08")]
		public static Rect SetPosition(this Rect rect, float x, float y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1D86F7C", Offset = "0x1D86F7C", VA = "0x1D86F7C")]
		public static Vector2 GetSize(this Rect rect)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1D86FE0", Offset = "0x1D86FE0", VA = "0x1D86FE0")]
		public static Rect SetSize(this Rect rect, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1D87054", Offset = "0x1D87054", VA = "0x1D87054")]
		public static Rect ScaleBy(this Rect rect, int pixel)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1D8707C", Offset = "0x1D8707C", VA = "0x1D8707C")]
		public static Rect ScaleBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1D8717C", Offset = "0x1D8717C", VA = "0x1D8717C")]
		public static Rect ShiftBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1D87224", Offset = "0x1D87224", VA = "0x1D87224")]
		public static Rect Include(this Rect rect, Rect other)
		{
			return default(Rect);
		}
	}
	[Token(Token = "0x2000082")]
	public static class StringExt
	{
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1D873E0", Offset = "0x1D873E0", VA = "0x1D873E0")]
		public static Color ColorFromHtml(this string hexString)
		{
			return default(Color);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1D877F0", Offset = "0x1D877F0", VA = "0x1D877F0")]
		public static string TrimStart(this string s, string trim, StringComparison compare = StringComparison.CurrentCultureIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1D87864", Offset = "0x1D87864", VA = "0x1D87864")]
		public static string TrimEnd(this string s, string trim, StringComparison compare = StringComparison.CurrentCultureIgnoreCase)
		{
			return null;
		}
	}
	[Token(Token = "0x2000083")]
	public static class IEnumerableExt
	{
		[Token(Token = "0x60002FF")]
		public static void ForEach<T>(this IEnumerable<T> ie, Action<T> action)
		{
		}
	}
	[Token(Token = "0x2000084")]
	public static class ArrayExt
	{
		[Token(Token = "0x6000300")]
		public static T[] SubArray<T>(this T[] data, int index, int length)
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		public static T[] RemoveAt<T>(this T[] source, int index)
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		public static T[] InsertAt<T>(this T[] source, int index)
		{
			return null;
		}

		[Token(Token = "0x6000303")]
		public static T[] Swap<T>(this T[] source, int index, int with)
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		public static T[] Add<T>(this T[] source, T item)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		public static T[] AddRange<T>(this T[] source, T[] items)
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		public static T[] RemoveDuplicates<T>(this T[] source)
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		public static int IndexOf<T>(this T[] source, T item)
		{
			return default(int);
		}

		[Token(Token = "0x6000308")]
		public static T[] Remove<T>(this T[] source, T item)
		{
			return null;
		}
	}
	[Token(Token = "0x2000085")]
	public static class MeshFilterExt
	{
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1D85E40", Offset = "0x1D85E40", VA = "0x1D85E40")]
		public static Mesh PrepareNewShared(this MeshFilter m, string name = "Mesh")
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1D86060", Offset = "0x1D86060", VA = "0x1D86060")]
		public static void CalculateTangents(this MeshFilter m)
		{
		}
	}
	[Token(Token = "0x2000086")]
	public static class TypeExt
	{
		[Serializable]
		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F785C", Offset = "0x6F785C")]
		private sealed class <>c
		{
			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<Assembly, IEnumerable<Type>> <>9__1_0;

			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x1D88A04", Offset = "0x1D88A04", VA = "0x1D88A04")]
			public <>c()
			{
			}

			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x1D88A0C", Offset = "0x1D88A0C", VA = "0x1D88A0C")]
			internal IEnumerable<Type> <GetLoadedTypes>b__1_0(Assembly a)
			{
				return null;
			}
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1D87ABC", Offset = "0x1D87ABC", VA = "0x1D87ABC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x703400", Offset = "0x703400")]
		public static Type[] GetAllTypes(this Type typeFromAssembly)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1D7BE08", Offset = "0x1D7BE08", VA = "0x1D7BE08")]
		public static Type[] GetLoadedTypes()
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1D87B10", Offset = "0x1D87B10", VA = "0x1D87B10")]
		public static IEnumerable<Assembly> GetLoadedAssemblies()
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		public static Dictionary<U, Type> GetAllTypesWithAttribute<U>(this Type type)
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		public static List<FieldInfo> GetFieldsWithAttribute<T>(this Type type, bool includeInherited = false, bool includePrivate = false) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		public static T GetCustomAttribute<T>(this Type type) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1D7A188", Offset = "0x1D7A188", VA = "0x1D7A188")]
		public static MethodInfo MethodByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1D7CF24", Offset = "0x1D7CF24", VA = "0x1D7CF24")]
		public static FieldInfo FieldByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1D7CF88", Offset = "0x1D7CF88", VA = "0x1D7CF88")]
		public static PropertyInfo PropertyByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1D7F0F4", Offset = "0x1D7F0F4", VA = "0x1D7F0F4")]
		public static FieldInfo[] GetAllFields(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1D7FF8C", Offset = "0x1D7FF8C", VA = "0x1D7FF8C")]
		public static PropertyInfo[] GetAllProperties(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1D880AC", Offset = "0x1D880AC", VA = "0x1D880AC")]
		public static bool IsFrameworkType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1D881E4", Offset = "0x1D881E4", VA = "0x1D881E4")]
		public static bool IsArrayOrList(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1D80170", Offset = "0x1D80170", VA = "0x1D80170")]
		public static Type GetEnumerableType(this Type t)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1D882F4", Offset = "0x1D882F4", VA = "0x1D882F4")]
		private static Type FindIEnumerable(Type seqType)
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1D87B40", Offset = "0x1D87B40", VA = "0x1D87B40")]
		private static MethodInfo GetMethodIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1D87D14", Offset = "0x1D87D14", VA = "0x1D87D14")]
		private static FieldInfo GetFieldIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1D87ED8", Offset = "0x1D87ED8", VA = "0x1D87ED8")]
		private static PropertyInfo GetPropertyIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1D88884", Offset = "0x1D88884", VA = "0x1D88884")]
		public static bool Matches(this Type type, params Type[] types)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000087")]
	public static class FieldInfoExt
	{
		[Token(Token = "0x600031E")]
		public static T GetCustomAttribute<T>(this FieldInfo field) where T : Attribute
		{
			return null;
		}
	}
}
namespace FluffyUnderware.Curvy
{
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F560C", Offset = "0x6F560C")]
	public class MetaCGOptions : CurvyMetadataBase
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Positive]
		[SerializeField]
		private int m_MaterialID;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool m_HardEdge;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Positive]
		[SerializeField]
		private float m_MaxStepDistance;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6F81B0", Offset = "0x6F81B0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6F81B0", Offset = "0x6F81B0")]
		[SerializeField]
		private bool m_UVEdge;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6F82C0", Offset = "0x6F82C0")]
		[SerializeField]
		private bool m_ExplicitU;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6F838C", Offset = "0x6F838C")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x6F838C", Offset = "0x6F838C")]
		[Positive]
		[SerializeField]
		private float m_FirstU;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6F8484", Offset = "0x6F8484")]
		[Positive]
		[SerializeField]
		private float m_SecondU;

		[Token(Token = "0x1700005F")]
		public int MaterialID
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x1BE7E98", Offset = "0x1BE7E98", VA = "0x1BE7E98")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x1BE7EA0", Offset = "0x1BE7EA0", VA = "0x1BE7EA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public bool HardEdge
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x1BE7F44", Offset = "0x1BE7F44", VA = "0x1BE7F44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x1BE7F4C", Offset = "0x1BE7F4C", VA = "0x1BE7F4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public bool UVEdge
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x1BE7F70", Offset = "0x1BE7F70", VA = "0x1BE7F70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x1BE7F78", Offset = "0x1BE7F78", VA = "0x1BE7F78")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public bool ExplicitU
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x1BE7F9C", Offset = "0x1BE7F9C", VA = "0x1BE7F9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x1BE7FA4", Offset = "0x1BE7FA4", VA = "0x1BE7FA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public float FirstU
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x1BE7FC8", Offset = "0x1BE7FC8", VA = "0x1BE7FC8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x1BE7FD0", Offset = "0x1BE7FD0", VA = "0x1BE7FD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public float SecondU
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x1BE7FF0", Offset = "0x1BE7FF0", VA = "0x1BE7FF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x1BE7FF8", Offset = "0x1BE7FF8", VA = "0x1BE7FF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public float MaxStepDistance
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x1BE8018", Offset = "0x1BE8018", VA = "0x1BE8018")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1BE8020", Offset = "0x1BE8020", VA = "0x1BE8020")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public bool HasDifferentMaterial
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x1BE69B4", Offset = "0x1BE69B4", VA = "0x1BE69B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		private bool showUVEdge
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x1BE80CC", Offset = "0x1BE80CC", VA = "0x1BE80CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		private bool showExplicitU
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x1BE826C", Offset = "0x1BE826C", VA = "0x1BE826C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		private bool showFirstU
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x1BE8314", Offset = "0x1BE8314", VA = "0x1BE8314")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		private bool showSecondU
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x1BE83C8", Offset = "0x1BE83C8", VA = "0x1BE83C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1BE83DC", Offset = "0x1BE83DC", VA = "0x1BE83DC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1BE68FC", Offset = "0x1BE68FC", VA = "0x1BE68FC")]
		public float GetDefinedFirstU(float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1BE6944", Offset = "0x1BE6944", VA = "0x1BE6944")]
		public float GetDefinedSecondU(float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1BE84AC", Offset = "0x1BE84AC", VA = "0x1BE84AC")]
		public MetaCGOptions()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6F5640", Offset = "0x6F5640")]
	public interface ICurvyMetadata
	{
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6F5674", Offset = "0x6F5674")]
	public interface ICurvyInterpolatableMetadata : ICurvyMetadata
	{
		[Token(Token = "0x1700006B")]
		object Value
		{
			[Token(Token = "0x6000336")]
			get;
		}

		[Token(Token = "0x6000337")]
		object InterpolateObject(ICurvyMetadata b, float f);
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6F56A8", Offset = "0x6F56A8")]
	public interface ICurvyInterpolatableMetadata<U> : ICurvyInterpolatableMetadata, ICurvyMetadata
	{
		[Token(Token = "0x6000338")]
		U Interpolate(ICurvyMetadata b, float f);
	}
	[Token(Token = "0x200008C")]
	public enum OrientationModeEnum
	{
		[Token(Token = "0x40001B7")]
		None,
		[Token(Token = "0x40001B8")]
		Orientation,
		[Token(Token = "0x40001B9")]
		Tangent
	}
	[Token(Token = "0x200008D")]
	public enum OrientationAxisEnum
	{
		[Token(Token = "0x40001BB")]
		Up,
		[Token(Token = "0x40001BC")]
		Down,
		[Token(Token = "0x40001BD")]
		Forward,
		[Token(Token = "0x40001BE")]
		Backward,
		[Token(Token = "0x40001BF")]
		Left,
		[Token(Token = "0x40001C0")]
		Right
	}
	[Token(Token = "0x200008E")]
	public enum ConnectionHeadingEnum
	{
		[Token(Token = "0x40001C2")]
		Minus = -1,
		[Token(Token = "0x40001C3")]
		Sharp,
		[Token(Token = "0x40001C4")]
		Plus,
		[Token(Token = "0x40001C5")]
		Auto
	}
	[Token(Token = "0x200008F")]
	public static class ConnectionHeadingEnumMethods
	{
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x12C76B0", Offset = "0x12C76B0", VA = "0x12C76B0")]
		public static ConnectionHeadingEnum ResolveAuto(this ConnectionHeadingEnum heading, CurvySplineSegment followUp)
		{
			return default(ConnectionHeadingEnum);
		}
	}
	[Token(Token = "0x2000090")]
	public enum CurvyUpdateMethod
	{
		[Token(Token = "0x40001C7")]
		Update,
		[Token(Token = "0x40001C8")]
		LateUpdate,
		[Token(Token = "0x40001C9")]
		FixedUpdate
	}
	[Token(Token = "0x2000091")]
	public enum CurvyRepeatingOrderEnum
	{
		[Token(Token = "0x40001CB")]
		Random,
		[Token(Token = "0x40001CC")]
		Row
	}
	[Token(Token = "0x2000092")]
	public enum CurvyPlane
	{
		[Token(Token = "0x40001CE")]
		XY,
		[Token(Token = "0x40001CF")]
		XZ,
		[Token(Token = "0x40001D0")]
		YZ
	}
	[Token(Token = "0x2000093")]
	public enum CurvyPositionMode
	{
		[Token(Token = "0x40001D2")]
		Relative,
		[Token(Token = "0x40001D3")]
		WorldUnits
	}
	[Token(Token = "0x2000094")]
	[Flags]
	public enum CurvyBezierModeEnum
	{
		[Token(Token = "0x40001D5")]
		None = 0,
		[Token(Token = "0x40001D6")]
		Direction = 1,
		[Token(Token = "0x40001D7")]
		Length = 2,
		[Token(Token = "0x40001D8")]
		Connections = 4,
		[Token(Token = "0x40001D9")]
		Combine = 8
	}
	[Token(Token = "0x2000095")]
	public enum CurvyAdvBezierModeEnum
	{
		[Token(Token = "0x40001DB")]
		None = 0,
		[Token(Token = "0x40001DC")]
		Direction = 1,
		[Token(Token = "0x40001DD")]
		Length = 2,
		[Token(Token = "0x40001DE")]
		Combine = 8
	}
	[Token(Token = "0x2000096")]
	public enum CurvyInterpolation
	{
		[Token(Token = "0x40001E0")]
		Linear,
		[Token(Token = "0x40001E1")]
		CatmullRom,
		[Token(Token = "0x40001E2")]
		TCB,
		[Token(Token = "0x40001E3")]
		Bezier
	}
	[Token(Token = "0x2000097")]
	public enum CurvyClamping
	{
		[Token(Token = "0x40001E5")]
		Clamp,
		[Token(Token = "0x40001E6")]
		Loop,
		[Token(Token = "0x40001E7")]
		PingPong
	}
	[Token(Token = "0x2000098")]
	public enum CurvyOrientation
	{
		[Token(Token = "0x40001E9")]
		None,
		[Token(Token = "0x40001EA")]
		Dynamic,
		[Token(Token = "0x40001EB")]
		Static
	}
	[Token(Token = "0x2000099")]
	public enum CurvyOrientationSwirl
	{
		[Token(Token = "0x40001ED")]
		None,
		[Token(Token = "0x40001EE")]
		Segment,
		[Token(Token = "0x40001EF")]
		AnchorGroup,
		[Token(Token = "0x40001F0")]
		AnchorGroupAbs
	}
	[Token(Token = "0x200009A")]
	public enum CurvySplineGizmos
	{
		[Token(Token = "0x40001F2")]
		None = 0,
		[Token(Token = "0x40001F3")]
		Curve = 2,
		[Token(Token = "0x40001F4")]
		Approximation = 4,
		[Token(Token = "0x40001F5")]
		Tangents = 8,
		[Token(Token = "0x40001F6")]
		Orientation = 16,
		[Token(Token = "0x40001F7")]
		Labels = 32,
		[Token(Token = "0x40001F8")]
		Metadata = 64,
		[Token(Token = "0x40001F9")]
		Bounds = 128,
		[Token(Token = "0x40001FA")]
		All = 65535
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6F56FC", Offset = "0x6F56FC")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F56FC", Offset = "0x6F56FC")]
	public class CurvyConnection : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x2000162")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F786C", Offset = "0x6F786C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Predicate<CurvySplineSegment> <>9__24_0;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<CurvySplineSegment> <>9__25_0;

			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0x12D4994", Offset = "0x12D4994", VA = "0x12D4994")]
			public <>c()
			{
			}

			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0x12D499C", Offset = "0x12D499C", VA = "0x12D499C")]
			internal bool <OnBeforeSerialize>b__24_0(CurvySplineSegment cp)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0x12D49A8", Offset = "0x12D49A8", VA = "0x12D49A8")]
			internal bool <OnAfterDeserialize>b__25_0(CurvySplineSegment cp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		[Hide]
		private List<CurvySplineSegment> m_ControlPoints;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ReadOnlyCollection<CurvySplineSegment> readOnlyControlPoints;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Couple<Vector3, Quaternion> processedConnectionCoordinates;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<CurvySplineSegment, Couple<Vector3, Quaternion>> processedControlPointsCoordinates;

		[Token(Token = "0x1700006C")]
		public ReadOnlyCollection<CurvySplineSegment> ControlPointsList
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x12CEF88", Offset = "0x12CEF88", VA = "0x12CEF88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public int Count
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x12D2C00", Offset = "0x12D2C00", VA = "0x12D2C00")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006E")]
		public CurvySplineSegment Item
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x12D2C58", Offset = "0x12D2C58", VA = "0x12D2C58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x12D2CD0", Offset = "0x12D2CD0", VA = "0x12D2CD0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x12D2F60", Offset = "0x12D2F60", VA = "0x12D2F60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x12D2F64", Offset = "0x12D2F64", VA = "0x12D2F64")]
		private void Update()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x12D35EC", Offset = "0x12D35EC", VA = "0x12D35EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x12D3614", Offset = "0x12D3614", VA = "0x12D3614")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x12D363C", Offset = "0x12D363C", VA = "0x12D363C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x12D37B8", Offset = "0x12D37B8", VA = "0x12D37B8")]
		public static CurvyConnection Create(params CurvySplineSegment[] controlPoints)
		{
			return null;
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x12D39D8", Offset = "0x12D39D8", VA = "0x12D39D8")]
		public void AddControlPoints(params CurvySplineSegment[] controlPoints)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x12D3C08", Offset = "0x12D3C08", VA = "0x12D3C08")]
		public void AutoSetFollowUp()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x12D3F54", Offset = "0x12D3F54", VA = "0x12D3F54")]
		public void RemoveControlPoint(CurvySplineSegment controlPoint, bool destroySelfIfEmpty = true)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x12D4044", Offset = "0x12D4044", VA = "0x12D4044")]
		public void Delete()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x12D40E0", Offset = "0x12D40E0", VA = "0x12D40E0")]
		public List<CurvySplineSegment> OtherControlPoints(CurvySplineSegment source)
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x12D418C", Offset = "0x12D418C", VA = "0x12D418C")]
		public void SetSynchronisationPositionAndRotation(Vector3 referencePosition, Quaternion referenceRotation)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x12D2F8C", Offset = "0x12D2F8C", VA = "0x12D2F8C")]
		private void DoUpdate()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x12D45F0", Offset = "0x12D45F0", VA = "0x12D45F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x12D4720", Offset = "0x12D4720", VA = "0x12D4720", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x12D4850", Offset = "0x12D4850", VA = "0x12D4850")]
		public CurvyConnection()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class CurvyEventArgs : EventArgs
	{
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly MonoBehaviour Sender;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public readonly object Data;

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x12CA500", Offset = "0x12CA500", VA = "0x12CA500")]
		public CurvyEventArgs(MonoBehaviour sender, object data)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009D")]
	public class CurvySplineEvent : UnityEventEx<CurvySplineEventArgs>
	{
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1D5CBBC", Offset = "0x1D5CBBC", VA = "0x1D5CBBC")]
		public CurvySplineEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009E")]
	public class CurvyControlPointEvent : UnityEventEx<CurvyControlPointEventArgs>
	{
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x12D49B4", Offset = "0x12D49B4", VA = "0x12D49B4")]
		public CurvyControlPointEvent()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class CurvyControlPointEventArgs : CurvySplineEventArgs
	{
		[Token(Token = "0x2000163")]
		public enum ModeEnum
		{
			[Token(Token = "0x4000595")]
			None,
			[Token(Token = "0x4000596")]
			AddBefore,
			[Token(Token = "0x4000597")]
			AddAfter,
			[Token(Token = "0x4000598")]
			Delete
		}

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public readonly ModeEnum Mode;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly CurvySplineSegment ControlPoint;

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x12D4A10", Offset = "0x12D4A10", VA = "0x12D4A10")]
		public CurvyControlPointEventArgs(MonoBehaviour sender, CurvySpline spline, CurvySplineSegment cp, ModeEnum mode = ModeEnum.None, [Optional] object data)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class CurvySplineEventArgs : CurvyEventArgs
	{
		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly CurvySpline Spline;

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1D5CC18", Offset = "0x1D5CC18", VA = "0x1D5CC18")]
		public CurvySplineEventArgs(MonoBehaviour sender, CurvySpline spline, [Optional] object data)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A1")]
	public class CurvyCGEvent : UnityEventEx<CurvyCGEventArgs>
	{
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x12D2A34", Offset = "0x12D2A34", VA = "0x12D2A34")]
		public CurvyCGEvent()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class CurvyCGEventArgs : EventArgs
	{
		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly MonoBehaviour Sender;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public readonly CurvyGenerator Generator;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly CGModule Module;

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x12D2A90", Offset = "0x12D2A90", VA = "0x12D2A90")]
		public CurvyCGEventArgs(CGModule module)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x12D2B4C", Offset = "0x12D2B4C", VA = "0x12D2B4C")]
		public CurvyCGEventArgs(CurvyGenerator generator, CGModule module)
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public static class CurvyGizmoHelper
	{
		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Matrix4x4 Matrix;

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x12D4A58", Offset = "0x12D4A58", VA = "0x12D4A58")]
		public static void SegmentCurveGizmo(CurvySplineSegment seg, Color col, float stepSize = 0.05f)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x12D4DD0", Offset = "0x12D4DD0", VA = "0x12D4DD0")]
		public static void SegmentApproximationGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x12D5228", Offset = "0x12D5228", VA = "0x12D5228")]
		public static void SegmentOrientationAnchorGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x12D56A0", Offset = "0x12D56A0", VA = "0x12D56A0")]
		public static void SegmentOrientationGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x12D5BA4", Offset = "0x12D5BA4", VA = "0x12D5BA4")]
		public static void SegmentTangentGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x12D5FB4", Offset = "0x12D5FB4", VA = "0x12D5FB4")]
		public static void ControlPointGizmo(CurvySplineSegment cp, bool selected, Color col)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x12D6470", Offset = "0x12D6470", VA = "0x12D6470")]
		public static void BoundsGizmo(CurvySplineSegment cp, Color col)
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F576C", Offset = "0x6F576C")]
	public class CurvyGlobalManager : DTSingleton<CurvyGlobalManager>
	{
		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool HideManager;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float SceneViewResolution;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Color DefaultGizmoColor;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Color DefaultGizmoSelectionColor;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static CurvyInterpolation DefaultInterpolation;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static float GizmoControlPointSize;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static float GizmoOrientationLength;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static Color GizmoOrientationColor;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static int SplineLayer;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static CurvySplineGizmos Gizmos;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PoolManager mPoolManager;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private ComponentPool mControlPointPool;

		[Token(Token = "0x1700006F")]
		public static bool ShowCurveGizmo
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x12D67B4", Offset = "0x12D67B4", VA = "0x12D67B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x12D6830", Offset = "0x12D6830", VA = "0x12D6830")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public static bool ShowApproximationGizmo
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x12D68EC", Offset = "0x12D68EC", VA = "0x12D68EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x12D6968", Offset = "0x12D6968", VA = "0x12D6968")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public static bool ShowTangentsGizmo
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x12D6A24", Offset = "0x12D6A24", VA = "0x12D6A24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x12D6AA0", Offset = "0x12D6AA0", VA = "0x12D6AA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public static bool ShowOrientationGizmo
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x12D6B5C", Offset = "0x12D6B5C", VA = "0x12D6B5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x12D6BD8", Offset = "0x12D6BD8", VA = "0x12D6BD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public static bool ShowLabelsGizmo
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x12D6C94", Offset = "0x12D6C94", VA = "0x12D6C94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x12D6D10", Offset = "0x12D6D10", VA = "0x12D6D10")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public static bool ShowMetadataGizmo
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x12D6DCC", Offset = "0x12D6DCC", VA = "0x12D6DCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x12D6E48", Offset = "0x12D6E48", VA = "0x12D6E48")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public static bool ShowBoundsGizmo
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x12D6F04", Offset = "0x12D6F04", VA = "0x12D6F04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x12D6F80", Offset = "0x12D6F80", VA = "0x12D6F80")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public PoolManager PoolManager
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x12D703C", Offset = "0x12D703C", VA = "0x12D703C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public ComponentPool ControlPointPool
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x12D70F8", Offset = "0x12D70F8", VA = "0x12D70F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public CurvyConnection[] Connections
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x12D7100", Offset = "0x12D7100", VA = "0x12D7100")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x12D715C", Offset = "0x12D715C", VA = "0x12D715C")]
		public CurvyConnection[] GetContainingConnections(params CurvySpline[] splines)
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x12D7A6C", Offset = "0x12D7A6C", VA = "0x12D7A6C", Slot = "5")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x12D7C8C", Offset = "0x12D7C8C", VA = "0x12D7C8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x12D7D3C", Offset = "0x12D7D3C", VA = "0x12D7D3C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x703558", Offset = "0x703558")]
		private static void LoadRuntimeSettings()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x12D806C", Offset = "0x12D806C", VA = "0x12D806C")]
		public static void SaveRuntimeSettings()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x12D82B8", Offset = "0x12D82B8", VA = "0x12D82B8", Slot = "7")]
		public override void MergeDoubleLoaded(IDTSingleton newInstance)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x12D8430", Offset = "0x12D8430", VA = "0x12D8430")]
		public CurvyGlobalManager()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6F57EC", Offset = "0x6F57EC")]
	public abstract class CurvyInterpolatableMetadataBase : CurvyMetadataBase, ICurvyInterpolatableMetadata, ICurvyMetadata
	{
		[Token(Token = "0x17000079")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x704348", Offset = "0x704348")]
		public abstract object Value
		{
			[Token(Token = "0x6000377")]
			get;
		}

		[Token(Token = "0x6000378")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x703568", Offset = "0x703568")]
		public abstract object InterpolateObject(ICurvyMetadata b, float f);

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x12D8624", Offset = "0x12D8624", VA = "0x12D8624")]
		protected CurvyInterpolatableMetadataBase()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	[ExecuteInEditMode]
	public abstract class CurvyInterpolatableMetadataBase<T> : CurvyInterpolatableMetadataBase, ICurvyInterpolatableMetadata<T>, ICurvyInterpolatableMetadata, ICurvyMetadata
	{
		[Token(Token = "0x1700007A")]
		public abstract T MetaDataValue
		{
			[Token(Token = "0x600037A")]
			get;
		}

		[Token(Token = "0x1700007B")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x70437C", Offset = "0x70437C")]
		public override object Value
		{
			[Token(Token = "0x600037C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037B")]
		public abstract T Interpolate(CurvyInterpolatableMetadataBase<T> nextMetadata, float interpolationTime);

		[Token(Token = "0x600037D")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x70359C", Offset = "0x70359C")]
		public override object InterpolateObject(ICurvyMetadata b, float f)
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7035D0", Offset = "0x7035D0")]
		public T Interpolate(ICurvyMetadata b, float f)
		{
			return (T)null;
		}

		[Token(Token = "0x600037F")]
		protected CurvyInterpolatableMetadataBase()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	[ExecuteInEditMode]
	public class CurvyMetadataBase : MonoBehaviour, ICurvyMetadata
	{
		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private CurvySplineSegment mCP;

		[Token(Token = "0x1700007C")]
		public CurvySplineSegment ControlPoint
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x12D8634", Offset = "0x12D8634", VA = "0x12D8634")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x12D863C", Offset = "0x12D863C", VA = "0x12D863C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x12D86E0", Offset = "0x12D86E0", VA = "0x12D86E0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x12D876C", Offset = "0x12D876C", VA = "0x12D876C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000384")]
		public T GetPreviousData<T>(bool autoCreate = true, bool segmentsOnly = true, bool useFollowUp = false) where T : MonoBehaviour, ICurvyMetadata
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		public T GetNextData<T>(bool autoCreate = true, bool segmentsOnly = true, bool useFollowUp = false) where T : MonoBehaviour, ICurvyMetadata
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x12D879C", Offset = "0x12D879C", VA = "0x12D879C")]
		protected void NotifyModification()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x12D862C", Offset = "0x12D862C", VA = "0x12D862C")]
		public CurvyMetadataBase()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6F5854", Offset = "0x6F5854")]
	public class CGResourceManagerAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly string ResourceName;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool ReadOnly;

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x12C5CB8", Offset = "0x12C5CB8", VA = "0x12C5CB8")]
		public CGResourceManagerAttribute(string resourceName)
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6F5880", Offset = "0x6F5880")]
	public sealed class CGResourceCollectionManagerAttribute : CGResourceManagerAttribute
	{
		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool ShowCount;

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x12C5C9C", Offset = "0x12C5C9C", VA = "0x12C5C9C")]
		public CGResourceCollectionManagerAttribute(string resourceName)
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6F58AC", Offset = "0x6F58AC")]
	public sealed class CGDataReferenceSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly Type DataType;

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x12C5C24", Offset = "0x12C5C24", VA = "0x12C5C24")]
		public CGDataReferenceSelectorAttribute(Type dataType)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F58D8", Offset = "0x6F58D8")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F58D8", Offset = "0x6F58D8")]
	public class CurvyShape : DTVersionedMonoBehaviour
	{
		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6F8580", Offset = "0x6F8580")]
		private CurvyPlane m_Plane;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		[HideInInspector]
		private bool m_Persistent;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<CurvyShapeInfo, Type> mShapeDefs;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvySpline mSpline;

		[NonSerialized]
		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool Dirty;

		[Token(Token = "0x1700007E")]
		public CurvyPlane Plane
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x12D8854", Offset = "0x12D8854", VA = "0x12D8854")]
			get
			{
				return default(CurvyPlane);
			}
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x12D885C", Offset = "0x12D885C", VA = "0x12D885C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public bool Persistent
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x12D8874", Offset = "0x12D8874", VA = "0x12D8874")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x12D887C", Offset = "0x12D887C", VA = "0x12D887C")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public CurvySpline Spline
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x12D88B0", Offset = "0x12D88B0", VA = "0x12D88B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public static Dictionary<CurvyShapeInfo, Type> ShapeDefinitions
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x12DA520", Offset = "0x12DA520", VA = "0x12DA520")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x12D8968", Offset = "0x12D8968", VA = "0x12D8968")]
		private void Update()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x12D8AE0", Offset = "0x12D8AE0", VA = "0x12D8AE0", Slot = "5")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x12D8AFC", Offset = "0x12D8AFC", VA = "0x12D8AFC")]
		public void Delete()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x12D89AC", Offset = "0x12D89AC", VA = "0x12D89AC")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x12D8CD0", Offset = "0x12D8CD0", VA = "0x12D8CD0")]
		public CurvyShape Replace(string menuName)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x12D9064", Offset = "0x12D9064", VA = "0x12D9064")]
		protected void PrepareSpline(CurvyInterpolation interpolation, CurvyOrientation orientation = CurvyOrientation.Dynamic, int cachedensity = 50, bool closed = true)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x12D9378", Offset = "0x12D9378", VA = "0x12D9378")]
		protected void SetPosition(int no, Vector3 position)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x12D944C", Offset = "0x12D944C", VA = "0x12D944C")]
		protected void SetRotation(int no, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x12D9528", Offset = "0x12D9528", VA = "0x12D9528")]
		protected void SetBezierHandles(int no, float distanceFrag)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x12D9544", Offset = "0x12D9544", VA = "0x12D9544")]
		protected void SetBezierHandles(int no, float inDistanceFrag, float outDistanceFrag)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x12D98E0", Offset = "0x12D98E0", VA = "0x12D98E0")]
		protected void SetBezierHandles(int no, Vector3 i, Vector3 o, Space space = Space.World)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x12D9848", Offset = "0x12D9848", VA = "0x12D9848")]
		public static void SetBezierHandles(float distanceFrag, bool setIn, bool setOut, params CurvySplineSegment[] controlPoints)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x12D9AC4", Offset = "0x12D9AC4", VA = "0x12D9AC4")]
		protected void SetCGHardEdges(params int[] controlPoints)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x12D9CD0", Offset = "0x12D9CD0", VA = "0x12D9CD0", Slot = "6")]
		protected virtual void ApplyShape()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x12D9CD4", Offset = "0x12D9CD4", VA = "0x12D9CD4")]
		protected void PrepareControlPoints(int count)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x12DA684", Offset = "0x12DA684", VA = "0x12DA684")]
		public static List<string> GetShapesMenuNames(bool only2D = false)
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x12DA888", Offset = "0x12DA888", VA = "0x12DA888")]
		public static List<string> GetShapesMenuNames(Type currentShapeType, out int currentIndex, bool only2D = false)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x12DAB84", Offset = "0x12DAB84", VA = "0x12DAB84")]
		public static string GetShapeName(Type shapeType)
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x12D8E60", Offset = "0x12D8E60", VA = "0x12D8E60")]
		public static Type GetShapeType(string menuName)
		{
			return null;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x12D8B78", Offset = "0x12D8B78", VA = "0x12D8B78")]
		private void applyPlane()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x12DAD44", Offset = "0x12DAD44", VA = "0x12DAD44")]
		private void applyRotation(Quaternion q)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x12DB258", Offset = "0x12DB258", VA = "0x12DB258")]
		public CurvyShape()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6F5980", Offset = "0x6F5980")]
	public sealed class CurvyShapeInfo : Attribute
	{
		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly string Name;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public readonly bool Is2D;

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x12DB37C", Offset = "0x12DB37C", VA = "0x12DB37C")]
		public CurvyShapeInfo(string name, bool is2D = true)
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class CurvyShape2D : CurvyShape
	{
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x12DB2F8", Offset = "0x12DB2F8", VA = "0x12DB2F8")]
		public CurvyShape2D()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6F59AC", Offset = "0x6F59AC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F59AC", Offset = "0x6F59AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6F59AC", Offset = "0x6F59AC")]
	[ExecuteInEditMode]
	public class CurvySpline : DTVersionedMonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F787C", Offset = "0x6F787C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Action<CurvySplineSegment> <>9__296_0;

			[Token(Token = "0x6000B00")]
			[Address(RVA = "0x1D5C944", Offset = "0x1D5C944", VA = "0x1D5C944")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B01")]
			[Address(RVA = "0x1D5C94C", Offset = "0x1D5C94C", VA = "0x1D5C94C")]
			internal void <ProcessDirtyControlPoints>b__296_0(CurvySplineSegment controlPoint)
			{
			}
		}

		[Token(Token = "0x4000220")]
		public const string VERSION = "6.0.1";

		[Token(Token = "0x4000221")]
		public const string APIVERSION = "600";

		[Token(Token = "0x4000222")]
		public const string WEBROOT = "https://curvyeditor.com/";

		[Token(Token = "0x4000223")]
		public const string DOCLINK = "https://curvyeditor.com/doclink/";

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[HideInInspector]
		private List<CurvySplineSegment> ControlPoints;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public bool ShowGizmos;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8650", Offset = "0x6F8650")]
		private Action<CurvySpline> <OnGlobalCoordinatesChanged>k__BackingField;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6F8660", Offset = "0x6F8660")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8660", Offset = "0x6F8660")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F8660", Offset = "0x6F8660")]
		private CurvyInterpolation m_Interpolation;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8734", Offset = "0x6F8734")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x6F8734", Offset = "0x6F8734")]
		[SerializeField]
		private bool m_RestrictTo2D;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F87A8", Offset = "0x6F87A8")]
		private bool m_Closed;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6F87F0", Offset = "0x6F87F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F87F0", Offset = "0x6F87F0")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F87F0", Offset = "0x6F87F0")]
		private bool m_AutoEndTangents;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8890", Offset = "0x6F8890")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F8890", Offset = "0x6F8890")]
		private CurvyOrientation m_Orientation;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6F8900", Offset = "0x6F8900")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x6F8900", Offset = "0x6F8900")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6F8900", Offset = "0x6F8900")]
		[SerializeField]
		private float m_AutoHandleDistance;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6F8A4C", Offset = "0x6F8A4C")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x6F8A4C", Offset = "0x6F8A4C")]
		[AttributeAttribute(Name = "GroupActionAttribute", RVA = "0x6F8A4C", Offset = "0x6F8A4C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F8A4C", Offset = "0x6F8A4C")]
		private float m_Tension;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F8BB0", Offset = "0x6F8BB0")]
		private float m_Continuity;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F8BF8", Offset = "0x6F8BF8")]
		private float m_Bias;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6F8C40", Offset = "0x6F8C40")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x6F8C40", Offset = "0x6F8C40")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6F8C40", Offset = "0x6F8C40")]
		[SerializeField]
		private Color m_GizmoColor;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6F8D30", Offset = "0x6F8D30")]
		[SerializeField]
		private Color m_GizmoSelectionColor;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6F8D90", Offset = "0x6F8D90")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F8D90", Offset = "0x6F8D90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8D90", Offset = "0x6F8D90")]
		private int m_CacheDensity;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8E50", Offset = "0x6F8E50")]
		private float m_MaxPointsPerUnit;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8E98", Offset = "0x6F8E98")]
		private bool m_UsePooling;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8EE0", Offset = "0x6F8EE0")]
		private bool m_UseThreading;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8F28", Offset = "0x6F8F28")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F8F28", Offset = "0x6F8F28")]
		private bool m_CheckTransform;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private CurvyUpdateMethod m_UpdateIn;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6F8FA8", Offset = "0x6F8FA8")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x6F8FA8", Offset = "0x6F8FA8")]
		[SerializeField]
		private CurvySplineEvent m_OnRefresh;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6F9034", Offset = "0x6F9034")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x6F9034", Offset = "0x6F9034")]
		[SerializeField]
		private CurvySplineEvent m_OnAfterControlPointChanges;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6F9098", Offset = "0x6F9098")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x6F9098", Offset = "0x6F9098")]
		[SerializeField]
		private CurvyControlPointEvent m_OnBeforeControlPointAdd;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6F90FC", Offset = "0x6F90FC")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x6F90FC", Offset = "0x6F90FC")]
		[SerializeField]
		private CurvyControlPointEvent m_OnAfterControlPointAdd;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6F9160", Offset = "0x6F9160")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x6F9160", Offset = "0x6F9160")]
		[SerializeField]
		private CurvyControlPointEvent m_OnBeforeControlPointDelete;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool mIsInitialized;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		private bool isStarted;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
		private bool sendOnRefreshEventNextUpdate;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly object controlPointsRelationshipCacheLock;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private List<CurvySplineSegment> mSegments;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ReadOnlyCollection<CurvySplineSegment> readOnlyControlPoints;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float length;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int mCacheSize;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Bounds? mBounds;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool mDirtyCurve;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool mDirtyOrientation;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private HashSet<CurvySplineSegment> dirtyControlPointsMinimalSet;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<CurvySplineSegment> dirtyCpsExtendedList;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool allControlPointsAreDirty;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ThreadPoolWorker<CurvySplineSegment> mThreadWorker;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private readonly CurvySplineEventArgs defaultSplineEventArgs;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly CurvyControlPointEventArgs defaultAddAfterEventArgs;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private readonly CurvyControlPointEventArgs defaultDeleteEventArgs;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private CurvySplineSegment _lastDistToSeg;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private readonly Action<CurvySplineSegment> refreshCurveAction;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastProcessedPosition;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion lastProcessedRotation;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Vector3 lastProcessedScale;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool globalCoordinatesChangedThisFrame;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		private bool isCpsRelationshipCacheValid;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private CurvySplineSegment firstSegment;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private CurvySplineSegment lastSegment;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private CurvySplineSegment firstVisibleControlPoint;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private CurvySplineSegment lastVisibleControlPoint;

		[Token(Token = "0x17000082")]
		public CurvyInterpolation Interpolation
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x12DB7DC", Offset = "0x12DB7DC", VA = "0x12DB7DC")]
			get
			{
				return default(CurvyInterpolation);
			}
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x12D91F4", Offset = "0x12D91F4", VA = "0x12D91F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public bool RestrictTo2D
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x12DBC18", Offset = "0x12DBC18", VA = "0x12DBC18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x12D9350", Offset = "0x12D9350", VA = "0x12D9350")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public float AutoHandleDistance
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x12DBC20", Offset = "0x12DBC20", VA = "0x12DBC20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x12DBC28", Offset = "0x12DBC28", VA = "0x12DBC28")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public bool Closed
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x12DBCD4", Offset = "0x12DBCD4", VA = "0x12DBCD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x12D9300", Offset = "0x12D9300", VA = "0x12D9300")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public bool AutoEndTangents
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x12DBCDC", Offset = "0x12DBCDC", VA = "0x12DBCDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x12DBBA4", Offset = "0x12DBBA4", VA = "0x12DBBA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public CurvyOrientation Orientation
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x12DBD0C", Offset = "0x12DBD0C", VA = "0x12DBD0C")]
			get
			{
				return default(CurvyOrientation);
			}
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x12D9238", Offset = "0x12D9238", VA = "0x12D9238")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public CurvyUpdateMethod UpdateIn
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x12DBD14", Offset = "0x12DBD14", VA = "0x12DBD14")]
			get
			{
				return default(CurvyUpdateMethod);
			}
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x12DBD1C", Offset = "0x12DBD1C", VA = "0x12DBD1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public Color GizmoColor
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x12DBD2C", Offset = "0x12DBD2C", VA = "0x12DBD2C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x12DBD3C", Offset = "0x12DBD3C", VA = "0x12DBD3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public Color GizmoSelectionColor
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x12DBD9C", Offset = "0x12DBD9C", VA = "0x12DBD9C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x12DBDAC", Offset = "0x12DBDAC", VA = "0x12DBDAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public int CacheDensity
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x12DBE0C", Offset = "0x12DBE0C", VA = "0x12DBE0C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x12D9254", Offset = "0x12D9254", VA = "0x12D9254")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public float MaxPointsPerUnit
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x12DBE14", Offset = "0x12DBE14", VA = "0x12DBE14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x12DBE1C", Offset = "0x12DBE1C", VA = "0x12DBE1C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool UsePooling
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x12DBED8", Offset = "0x12DBED8", VA = "0x12DBED8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x12DBEE0", Offset = "0x12DBEE0", VA = "0x12DBEE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public bool UseThreading
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x12DBEFC", Offset = "0x12DBEFC", VA = "0x12DBEFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x12DBF04", Offset = "0x12DBF04", VA = "0x12DBF04")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public bool CheckTransform
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x12DBF20", Offset = "0x12DBF20", VA = "0x12DBF20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x12DBF28", Offset = "0x12DBF28", VA = "0x12DBF28")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public float Tension
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x12DBF50", Offset = "0x12DBF50", VA = "0x12DBF50")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x12DBF58", Offset = "0x12DBF58", VA = "0x12DBF58")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public float Continuity
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x12DBF7C", Offset = "0x12DBF7C", VA = "0x12DBF7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x12DBF84", Offset = "0x12DBF84", VA = "0x12DBF84")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public float Bias
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x12DBFA8", Offset = "0x12DBFA8", VA = "0x12DBFA8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x12DBFB0", Offset = "0x12DBFB0", VA = "0x12DBFB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public bool IsInitialized
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x12DBFD4", Offset = "0x12DBFD4", VA = "0x12DBFD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000094")]
		public Bounds Bounds
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x12DBFDC", Offset = "0x12DBFDC", VA = "0x12DBFDC")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000095")]
		public int Count
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x12CC8A8", Offset = "0x12CC8A8", VA = "0x12CC8A8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000096")]
		public int ControlPointCount
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x12D97F0", Offset = "0x12D97F0", VA = "0x12D97F0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000097")]
		public int CacheSize
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x12DC2E0", Offset = "0x12DC2E0", VA = "0x12DC2E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000098")]
		public float Length
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x12CB2D0", Offset = "0x12CB2D0", VA = "0x12CB2D0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000099")]
		public bool Dirty
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x12CD8FC", Offset = "0x12CD8FC", VA = "0x12CD8FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009A")]
		public CurvySplineSegment Item
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x12CF348", Offset = "0x12CF348", VA = "0x12CF348")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public ReadOnlyCollection<CurvySplineSegment> ControlPointsList
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x12D79DC", Offset = "0x12D79DC", VA = "0x12D79DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		[CanBeNull]
		public CurvySplineSegment FirstVisibleControlPoint
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x12C77E8", Offset = "0x12C77E8", VA = "0x12C77E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		[CanBeNull]
		public CurvySplineSegment LastVisibleControlPoint
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x12C7814", Offset = "0x12C7814", VA = "0x12C7814")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public CurvySplineSegment FirstSegment
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x12DCA84", Offset = "0x12DCA84", VA = "0x12DCA84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public CurvySplineSegment LastSegment
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x12DCAB0", Offset = "0x12DCAB0", VA = "0x12DCAB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public CurvySpline NextSpline
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x12DCADC", Offset = "0x12DCADC", VA = "0x12DCADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		public CurvySpline PreviousSpline
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x12DCBE0", Offset = "0x12DCBE0", VA = "0x12DCBE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		public bool GlobalCoordinatesChangedThisFrame
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x12DCCE4", Offset = "0x12DCCE4", VA = "0x12DCCE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A3")]
		public Action<CurvySpline> OnGlobalCoordinatesChanged
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x12DCCEC", Offset = "0x12DCCEC", VA = "0x12DCCEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703604", Offset = "0x703604")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x12DCCF4", Offset = "0x12DCCF4", VA = "0x12DCCF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703614", Offset = "0x703614")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public CurvySplineEvent OnRefresh
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x12DCCFC", Offset = "0x12DCCFC", VA = "0x12DCCFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x12DCD04", Offset = "0x12DCD04", VA = "0x12DCD04")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public CurvySplineEvent OnAfterControlPointChanges
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x12DCD18", Offset = "0x12DCD18", VA = "0x12DCD18")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x12DCD20", Offset = "0x12DCD20", VA = "0x12DCD20")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public CurvyControlPointEvent OnBeforeControlPointAdd
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x12DCD34", Offset = "0x12DCD34", VA = "0x12DCD34")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x12DCD3C", Offset = "0x12DCD3C", VA = "0x12DCD3C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public CurvyControlPointEvent OnAfterControlPointAdd
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x12DCD50", Offset = "0x12DCD50", VA = "0x12DCD50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x12DCD58", Offset = "0x12DCD58", VA = "0x12DCD58")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public CurvyControlPointEvent OnBeforeControlPointDelete
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x12DCD6C", Offset = "0x12DCD6C", VA = "0x12DCD6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x12DCD74", Offset = "0x12DCD74", VA = "0x12DCD74")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		private List<CurvySplineSegment> controlPoints
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x12E7250", Offset = "0x12E7250", VA = "0x12E7250")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		private List<CurvySplineSegment> Segments
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x12DC2B4", Offset = "0x12DC2B4", VA = "0x12DC2B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x12DB3B0", Offset = "0x12DB3B0", VA = "0x12DB3B0")]
		public CurvySpline()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x12DCD88", Offset = "0x12DCD88", VA = "0x12DCD88")]
		public static CurvySpline Create()
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x12DCFB8", Offset = "0x12DCFB8", VA = "0x12DCFB8")]
		public static CurvySpline Create(CurvySpline takeOptionsFrom)
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x12DD168", Offset = "0x12DD168", VA = "0x12DD168")]
		public static int CalculateCacheSize(int density, float splineLength, float maxPointsPerUnit)
		{
			return default(int);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x12DD214", Offset = "0x12DD214", VA = "0x12DD214")]
		public static float CalculateSamplingPointsPerUnit(int density, float maxPointsPerUnit)
		{
			return default(float);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x12DD324", Offset = "0x12DD324", VA = "0x12DD324")]
		public static Vector3 Bezier(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x12DD474", Offset = "0x12DD474", VA = "0x12DD474")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x703624", Offset = "0x703624")]
		public static float BezierTangent(float T0, float P0, float P1, float T1, float t)
		{
			return default(float);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x12DD4D4", Offset = "0x12DD4D4", VA = "0x12DD4D4")]
		public static Vector3 BezierTangent(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x12DD81C", Offset = "0x12DD81C", VA = "0x12DD81C")]
		public static Vector3 CatmullRom(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x12DD980", Offset = "0x12DD980", VA = "0x12DD980")]
		public static Vector3 TCB(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f, float FT0, float FC0, float FB0, float FT1, float FC1, float FB1)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x12CBCEC", Offset = "0x12CBCEC", VA = "0x12CBCEC")]
		public Vector3 Interpolate(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x12DDBCC", Offset = "0x12DDBCC", VA = "0x12DDBCC")]
		public Vector3 Interpolate(float tf, CurvyInterpolation interpolation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x12CBD08", Offset = "0x12CBD08", VA = "0x12CBD08")]
		public Vector3 InterpolateFast(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F5")]
		public T GetMetadata<T>(float tf) where T : UnityEngine.Component, ICurvyMetadata
		{
			return null;
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x12DDD10", Offset = "0x12DDD10", VA = "0x12DDD10")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x703658", Offset = "0x703658")]
		public UnityEngine.Component GetMetadata(Type type, float tf)
		{
			return null;
		}

		[Token(Token = "0x60003F7")]
		public U GetInterpolatedMetadata<T, U>(float tf) where T : CurvyInterpolatableMetadataBase<U>
		{
			return (U)null;
		}

		[Token(Token = "0x60003F8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x70368C", Offset = "0x70368C")]
		public U InterpolateMetadata<T, U>(float tf) where T : UnityEngine.Component, ICurvyInterpolatableMetadata<U>
		{
			return (U)null;
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x12DDDEC", Offset = "0x12DDDEC", VA = "0x12DDDEC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7036C0", Offset = "0x7036C0")]
		public object InterpolateMetadata(Type type, float tf)
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x12DDED4", Offset = "0x12DDED4", VA = "0x12DDED4")]
		public Vector3 InterpolateScale(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x12CC240", Offset = "0x12CC240", VA = "0x12CC240")]
		public Vector3 GetOrientationUpFast(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x12DDFF0", Offset = "0x12DDFF0", VA = "0x12DDFF0")]
		public Quaternion GetOrientationFast(float tf, bool inverse = false)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x12CC42C", Offset = "0x12CC42C", VA = "0x12CC42C")]
		public Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x12DE118", Offset = "0x12DE118", VA = "0x12DE118")]
		public Vector3 GetTangent(float tf, Vector3 localPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x12CC548", Offset = "0x12CC548", VA = "0x12CC548")]
		public Vector3 GetTangentFast(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x12CC0EC", Offset = "0x12CC0EC", VA = "0x12CC0EC")]
		public void InterpolateAndGetTangent(float tf, out Vector3 localPosition, out Vector3 localTangent)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x12CBF98", Offset = "0x12CBF98", VA = "0x12CBF98")]
		public void InterpolateAndGetTangentFast(float tf, out Vector3 localPosition, out Vector3 localTangent)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x12DE24C", Offset = "0x12DE24C", VA = "0x12DE24C")]
		public Vector3 GetTangentByDistance(float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x12DE280", Offset = "0x12DE280", VA = "0x12DE280")]
		public Vector3 GetTangentByDistanceFast(float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x12DE2B4", Offset = "0x12DE2B4", VA = "0x12DE2B4")]
		public Vector3 InterpolateByDistance(float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x12DE2F4", Offset = "0x12DE2F4", VA = "0x12DE2F4")]
		public Vector3 InterpolateByDistanceFast(float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x12DE328", Offset = "0x12DE328", VA = "0x12DE328")]
		public float ExtrapolateDistanceToTF(float tf, float distance, float stepSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x12DE54C", Offset = "0x12DE54C", VA = "0x12DE54C")]
		public float ExtrapolateDistanceToTFFast(float tf, float distance, float stepSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x12CB934", Offset = "0x12CB934", VA = "0x12CB934")]
		public float TFToDistance(float tf, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x12CE108", Offset = "0x12CE108", VA = "0x12CE108")]
		public CurvySplineSegment TFToSegment(float tf, out float localF, CurvyClamping clamping)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x12DE768", Offset = "0x12DE768", VA = "0x12DE768")]
		public CurvySplineSegment TFToSegment(float tf, CurvyClamping clamping)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x12DE790", Offset = "0x12DE790", VA = "0x12DE790")]
		public CurvySplineSegment TFToSegment(float tf)
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x12DDCF4", Offset = "0x12DDCF4", VA = "0x12DDCF4")]
		public CurvySplineSegment TFToSegment(float tf, out float localF)
		{
			return null;
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x12CF494", Offset = "0x12CF494", VA = "0x12CF494")]
		public float SegmentToTF(CurvySplineSegment segment)
		{
			return default(float);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x12CE614", Offset = "0x12CE614", VA = "0x12CE614")]
		public float SegmentToTF(CurvySplineSegment segment, float localF)
		{
			return default(float);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x12CBAC8", Offset = "0x12CBAC8", VA = "0x12CBAC8")]
		public float DistanceToTF(float distance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x12DE830", Offset = "0x12DE830", VA = "0x12DE830")]
		public CurvySplineSegment DistanceToSegment(float distance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x12CE2CC", Offset = "0x12CE2CC", VA = "0x12CE2CC")]
		public CurvySplineSegment DistanceToSegment(float distance, out float localDistance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x12DE918", Offset = "0x12DE918", VA = "0x12DE918")]
		public Vector3 Move(ref float tf, ref int direction, float fDistance, CurvyClamping clamping)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x12DE978", Offset = "0x12DE978", VA = "0x12DE978")]
		public Vector3 MoveFast(ref float tf, ref int direction, float fDistance, CurvyClamping clamping)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x12DE9CC", Offset = "0x12DE9CC", VA = "0x12DE9CC")]
		public Vector3 MoveBy(ref float tf, ref int direction, float distance, CurvyClamping clamping, float stepSize = 0.002f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x12DEA20", Offset = "0x12DEA20", VA = "0x12DEA20")]
		public Vector3 MoveByFast(ref float tf, ref int direction, float distance, CurvyClamping clamping, float stepSize = 0.002f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x12DEA94", Offset = "0x12DEA94", VA = "0x12DEA94")]
		public Vector3 MoveByLengthFast(ref float tf, ref int direction, float distance, CurvyClamping clamping)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x12DEB28", Offset = "0x12DEB28", VA = "0x12DEB28")]
		public Vector3 MoveByAngle(ref float tf, ref int direction, float angle, CurvyClamping clamping, float stepSize = 0.002f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x12DEE48", Offset = "0x12DEE48", VA = "0x12DEE48")]
		public Vector3 MoveByAngleFast(ref float tf, ref int direction, float angle, CurvyClamping clamping, float stepSize)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x12DF158", Offset = "0x12DF158", VA = "0x12DF158")]
		public float ClampDistance(float distance, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x12DF184", Offset = "0x12DF184", VA = "0x12DF184")]
		public float ClampDistance(float distance, CurvyClamping clamping, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x12CD7FC", Offset = "0x12CD7FC", VA = "0x12CD7FC")]
		public float ClampDistance(float distance, ref int dir, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x12DF1CC", Offset = "0x12DF1CC", VA = "0x12DF1CC")]
		public float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x12DF21C", Offset = "0x12DF21C", VA = "0x12DF21C")]
		public CurvySplineSegment Add()
		{
			return null;
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x12DF228", Offset = "0x12DF228", VA = "0x12DF228")]
		public CurvySplineSegment[] Add(params Vector3[] controlPointsLocalPositions)
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x12DF690", Offset = "0x12DF690", VA = "0x12DF690")]
		public CurvySplineSegment InsertBefore(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x12DF9CC", Offset = "0x12DF9CC", VA = "0x12DF9CC")]
		public CurvySplineSegment InsertBefore(CurvySplineSegment controlPoint, Vector3 globalPosition, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x12D9FB0", Offset = "0x12D9FB0", VA = "0x12D9FB0")]
		public CurvySplineSegment InsertAfter(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x12DF4B4", Offset = "0x12DF4B4", VA = "0x12DF4B4")]
		public CurvySplineSegment InsertAfter(CurvySplineSegment controlPoint, Vector3 globalPosition, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x12E00B0", Offset = "0x12E00B0", VA = "0x12E00B0")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x12DA290", Offset = "0x12DA290", VA = "0x12DA290")]
		public void Delete(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x12C7440", Offset = "0x12C7440", VA = "0x12C7440")]
		public Vector3[] GetApproximation(Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x12E0760", Offset = "0x12E0760", VA = "0x12E0760")]
		public Vector3[] GetApproximationT()
		{
			return null;
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x12E08AC", Offset = "0x12E08AC", VA = "0x12E08AC")]
		public Vector3[] GetApproximationUpVectors()
		{
			return null;
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x12E09F8", Offset = "0x12E09F8", VA = "0x12E09F8")]
		public float GetNearestPointTF(Vector3 localPosition)
		{
			return default(float);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x12E0A94", Offset = "0x12E0A94", VA = "0x12E0A94")]
		public float GetNearestPointTF(Vector3 localPosition, out Vector3 nearest)
		{
			return default(float);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x12E0ADC", Offset = "0x12E0ADC", VA = "0x12E0ADC")]
		public float GetNearestPointTF(Vector3 localPosition, int startSegmentIndex = 0, int stopSegmentIndex = -1)
		{
			return default(float);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x12E0A48", Offset = "0x12E0A48", VA = "0x12E0A48")]
		public float GetNearestPointTF(Vector3 localPosition, out Vector3 nearest, int startSegmentIndex = 0, int stopSegmentIndex = -1)
		{
			return default(float);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x12E0B30", Offset = "0x12E0B30", VA = "0x12E0B30")]
		public float GetNearestPointTF(Vector3 localPosition, out Vector3 nearestPoint, [CanBeNull] out CurvySplineSegment nearestSegment, out float nearestSegmentF, int startSegmentIndex = 0, int stopSegmentIndex = -1)
		{
			return default(float);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x12CD970", Offset = "0x12CD970", VA = "0x12CD970")]
		public void Refresh()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x12D8CC4", Offset = "0x12D8CC4", VA = "0x12D8CC4")]
		public void SetDirtyAll()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x12DB8C8", Offset = "0x12DB8C8", VA = "0x12DB8C8")]
		public void SetDirtyAll(SplineDirtyingType dirtyingType, bool dirtyConnectedControlPoints)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x12E20D4", Offset = "0x12E20D4", VA = "0x12E20D4")]
		public void SetDirty(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x12D45A0", Offset = "0x12D45A0", VA = "0x12D45A0")]
		public void SetDirtyPartial(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x12E26C0", Offset = "0x12E26C0", VA = "0x12E26C0")]
		public Vector3 ToWorldPosition(Vector3 localPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x12E2720", Offset = "0x12E2720", VA = "0x12E2720")]
		public void SyncSplineFromHierarchy()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x12E2A2C", Offset = "0x12E2A2C", VA = "0x12E2A2C")]
		public Vector3[] GetApproximationPoints(float fromTF, float toTF, bool includeEndPoint = true)
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x12E2F68", Offset = "0x12E2F68", VA = "0x12E2F68")]
		public bool IsPlanar(out int ignoreAxis)
		{
			return default(bool);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x12E2FD4", Offset = "0x12E2FD4", VA = "0x12E2FD4")]
		public bool IsPlanar(out bool xplanar, out bool yplanar, out bool zplanar)
		{
			return default(bool);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x12E335C", Offset = "0x12E335C", VA = "0x12E335C")]
		public bool IsPlanar(CurvyPlane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x12E35CC", Offset = "0x12E35CC", VA = "0x12E35CC")]
		public void MakePlanar(CurvyPlane plane)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x12E3C4C", Offset = "0x12E3C4C", VA = "0x12E3C4C")]
		public void Subdivide([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x12E45A4", Offset = "0x12E45A4", VA = "0x12E45A4")]
		public void Simplify([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x12E492C", Offset = "0x12E492C", VA = "0x12E492C")]
		public void Equalize([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x12E4DB8", Offset = "0x12E4DB8", VA = "0x12E4DB8")]
		public void Normalize()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x12E50D4", Offset = "0x12E50D4", VA = "0x12E50D4")]
		public void MakePlanar(int axis)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x12E52F0", Offset = "0x12E52F0", VA = "0x12E52F0")]
		public Vector3 SetPivot(float xRel = 0f, float yRel = 0f, float zRel = 0f, bool preview = false)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x12E5764", Offset = "0x12E5764", VA = "0x12E5764")]
		public void Flip()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x12E5C00", Offset = "0x12E5C00", VA = "0x12E5C00")]
		public void MoveControlPoints(int startIndex, int count, CurvySplineSegment destCP)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x12E606C", Offset = "0x12E606C", VA = "0x12E606C")]
		public void JoinWith(CurvySplineSegment destCP)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x12E6170", Offset = "0x12E6170", VA = "0x12E6170")]
		public CurvySpline Split(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x12E6448", Offset = "0x12E6448", VA = "0x12E6448")]
		public void SetFirstControlPoint(CurvySplineSegment controlPoint)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x12E65F8", Offset = "0x12E65F8", VA = "0x12E65F8")]
		public bool IsControlPointAnOrientationAnchor(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x12D3F18", Offset = "0x12D3F18", VA = "0x12D3F18")]
		public bool CanControlPointHaveFollowUp(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x12DE7F4", Offset = "0x12DE7F4", VA = "0x12DE7F4")]
		public short GetControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x12DE7B8", Offset = "0x12DE7B8", VA = "0x12DE7B8")]
		public short GetSegmentIndex(CurvySplineSegment segment)
		{
			return default(short);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x12CE7A8", Offset = "0x12CE7A8", VA = "0x12CE7A8")]
		[CanBeNull]
		public CurvySplineSegment GetNextControlPoint(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x12E6728", Offset = "0x12E6728", VA = "0x12E6728")]
		[CanBeNull]
		public short GetNextControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x12E6764", Offset = "0x12E6764", VA = "0x12E6764")]
		[CanBeNull]
		public CurvySplineSegment GetNextControlPointUsingFollowUp(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x12CEA64", Offset = "0x12CEA64", VA = "0x12CEA64")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousControlPoint(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x12E6974", Offset = "0x12E6974", VA = "0x12E6974")]
		[CanBeNull]
		public short GetPreviousControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x12E69B0", Offset = "0x12E69B0", VA = "0x12E69B0")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousControlPointUsingFollowUp(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x12DE858", Offset = "0x12DE858", VA = "0x12DE858")]
		[CanBeNull]
		public CurvySplineSegment GetNextSegment(CurvySplineSegment segment)
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x12E6ABC", Offset = "0x12E6ABC", VA = "0x12E6ABC")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousSegment(CurvySplineSegment segment)
		{
			return null;
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x12DF98C", Offset = "0x12DF98C", VA = "0x12DF98C")]
		public bool IsControlPointASegment(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x12CEB20", Offset = "0x12CEB20", VA = "0x12CEB20")]
		public bool IsControlPointVisible(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x12E6B7C", Offset = "0x12E6B7C", VA = "0x12E6B7C")]
		public short GetControlPointOrientationAnchorIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x12E6BB8", Offset = "0x12E6BB8", VA = "0x12E6BB8")]
		public void SetFromString(string fieldAndValue)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x12E7258", Offset = "0x12E7258", VA = "0x12E7258")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x12E72EC", Offset = "0x12E72EC", VA = "0x12E72EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x12DCF78", Offset = "0x12DCF78", VA = "0x12DCF78")]
		public void Start()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x12E734C", Offset = "0x12E734C", VA = "0x12E734C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x12E7358", Offset = "0x12E7358", VA = "0x12E7358")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x12E7500", Offset = "0x12E7500", VA = "0x12E7500", Slot = "5")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x12E76F8", Offset = "0x12E76F8", VA = "0x12E76F8")]
		private void Update()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x12E7B4C", Offset = "0x12E7B4C", VA = "0x12E7B4C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x12E7B84", Offset = "0x12E7B84", VA = "0x12E7B84")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x12E7318", Offset = "0x12E7318", VA = "0x12E7318")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x12E7730", Offset = "0x12E7730", VA = "0x12E7730")]
		private void doUpdate()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x12DBCE4", Offset = "0x12DBCE4", VA = "0x12DBCE4")]
		private bool canHaveManualEndCP()
		{
			return default(bool);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x12E2124", Offset = "0x12E2124", VA = "0x12E2124")]
		private void SetDirty(CurvySplineSegment controlPoint, SplineDirtyingType dirtyingType, CurvySplineSegment previousControlPoint, CurvySplineSegment nextControlPoint, bool ignoreConnectionOfInputControlPoint)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x12E2040", Offset = "0x12E2040", VA = "0x12E2040")]
		private void SetDirtyingFlags(SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x12E5B7C", Offset = "0x12E5B7C", VA = "0x12E5B7C")]
		private void ReverseControlPoints()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x12E7C84", Offset = "0x12E7C84", VA = "0x12E7C84")]
		private static short GetNextControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount)
		{
			return default(short);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x12E7C9C", Offset = "0x12E7C9C", VA = "0x12E7C9C")]
		private static short GetPreviousControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount)
		{
			return default(short);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x12E7CB8", Offset = "0x12E7CB8", VA = "0x12E7CB8")]
		private static bool IsControlPointASegment(int controlPointIndex, int controlPointCount, bool isClosed, bool notAutoEndTangentsAndIsCatmullRomOrTCB)
		{
			return default(bool);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x12E6870", Offset = "0x12E6870", VA = "0x12E6870")]
		[NotNull]
		private static CurvySplineSegment GetFollowUpNextControlPoint(CurvySplineSegment followUp, ConnectionHeadingEnum headToDirection)
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x12E284C", Offset = "0x12E284C", VA = "0x12E284C")]
		private void AddControlPoint(CurvySplineSegment item)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x12E5EB4", Offset = "0x12E5EB4", VA = "0x12E5EB4")]
		private void InsertControlPoint(int index, CurvySplineSegment item)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x12E0510", Offset = "0x12E0510", VA = "0x12E0510")]
		private void RemoveControlPoint(CurvySplineSegment item)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x12E0378", Offset = "0x12E0378", VA = "0x12E0378")]
		private void ClearControlPoints()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x12DB7E4", Offset = "0x12DB7E4", VA = "0x12DB7E4")]
		internal void InvalidateControlPointsRelationshipCacheINTERNAL()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x12DC3B8", Offset = "0x12DC3B8", VA = "0x12DC3B8")]
		private void RebuildControlPointsRelationshipCache(bool fixNonCoherentControlPoints)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x12E0E80", Offset = "0x12E0E80", VA = "0x12E0E80")]
		private void ProcessDirtyControlPoints()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x12E8020", Offset = "0x12E8020", VA = "0x12E8020")]
		private void PrepareTTransforms()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x12E7CF8", Offset = "0x12E7CF8", VA = "0x12E7CF8")]
		private void FillDirtyCpsExtendedList()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x12D8848", Offset = "0x12D8848", VA = "0x12D8848")]
		internal void NotifyMetaDataModification()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x12E8250", Offset = "0x12E8250", VA = "0x12E8250")]
		private void SyncHierarchyFromSpline(bool renameControlPoints = true)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x12E7BBC", Offset = "0x12E7BBC", VA = "0x12E7BBC")]
		private void UpdatedLastProcessedGlobalCoordinates()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x12DFAF4", Offset = "0x12DFAF4", VA = "0x12DFAF4")]
		private CurvySplineSegment InsertAt(CurvySplineSegment controlPoint, Vector3 globalPosition, int insertionIndex, CurvyControlPointEventArgs.ModeEnum insertionMode, bool skipRefreshingAndEvents)
		{
			return null;
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x12E1FD0", Offset = "0x12E1FD0", VA = "0x12E1FD0")]
		private CurvySplineEventArgs OnRefreshEvent(CurvySplineEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x12DF444", Offset = "0x12DF444", VA = "0x12DF444")]
		private CurvyControlPointEventArgs OnBeforeControlPointAddEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x12DF5B0", Offset = "0x12DF5B0", VA = "0x12DF5B0")]
		private CurvyControlPointEventArgs OnAfterControlPointAddEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x12E0308", Offset = "0x12E0308", VA = "0x12E0308")]
		private CurvyControlPointEventArgs OnBeforeControlPointDeleteEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x12DF620", Offset = "0x12DF620", VA = "0x12DF620")]
		private CurvySplineEventArgs OnAfterControlPointChangesEvent(CurvySplineEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x12E8254", Offset = "0x12E8254", VA = "0x12E8254")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703784", Offset = "0x703784")]
		private void <.ctor>b__4_0(CurvySplineSegment controlPoint)
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public enum SplineDirtyingType
	{
		[Token(Token = "0x400025B")]
		OrientationOnly,
		[Token(Token = "0x400025C")]
		Everything
	}
	[Token(Token = "0x20000B0")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F5A48", Offset = "0x6F5A48")]
	public class CurvySplineSegment : MonoBehaviour, IPoolable
	{
		[Token(Token = "0x2000165")]
		internal readonly struct ControlPointExtrinsicProperties : IEquatable<ControlPointExtrinsicProperties>
		{
			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly bool isVisible;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			private readonly short segmentIndex;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private readonly short controlPointIndex;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			private readonly short nextControlPointIndex;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly short previousControlPointIndex;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			private readonly bool previousControlPointIsSegment;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
			private readonly bool nextControlPointIsSegment;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private readonly bool canHaveFollowUp;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			private readonly short orientationAnchorIndex;

			[Token(Token = "0x17000279")]
			internal bool IsVisible
			{
				[Token(Token = "0x6000B02")]
				[Address(RVA = "0x1D66D04", Offset = "0x1D66D04", VA = "0x1D66D04")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700027A")]
			internal short SegmentIndex
			{
				[Token(Token = "0x6000B03")]
				[Address(RVA = "0x1D66D0C", Offset = "0x1D66D0C", VA = "0x1D66D0C")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x1700027B")]
			internal short ControlPointIndex
			{
				[Token(Token = "0x6000B04")]
				[Address(RVA = "0x1D66D14", Offset = "0x1D66D14", VA = "0x1D66D14")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x1700027C")]
			internal short NextControlPointIndex
			{
				[Token(Token = "0x6000B05")]
				[Address(RVA = "0x1D66D1C", Offset = "0x1D66D1C", VA = "0x1D66D1C")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x1700027D")]
			internal short PreviousControlPointIndex
			{
				[Token(Token = "0x6000B06")]
				[Address(RVA = "0x1D66D24", Offset = "0x1D66D24", VA = "0x1D66D24")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x1700027E")]
			internal bool PreviousControlPointIsSegment
			{
				[Token(Token = "0x6000B07")]
				[Address(RVA = "0x1D66D2C", Offset = "0x1D66D2C", VA = "0x1D66D2C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700027F")]
			internal bool NextControlPointIsSegment
			{
				[Token(Token = "0x6000B08")]
				[Address(RVA = "0x1D66D34", Offset = "0x1D66D34", VA = "0x1D66D34")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000280")]
			internal bool CanHaveFollowUp
			{
				[Token(Token = "0x6000B09")]
				[Address(RVA = "0x1D66D3C", Offset = "0x1D66D3C", VA = "0x1D66D3C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000281")]
			internal bool IsSegment
			{
				[Token(Token = "0x6000B0A")]
				[Address(RVA = "0x1D66D44", Offset = "0x1D66D44", VA = "0x1D66D44")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000282")]
			internal short OrientationAnchorIndex
			{
				[Token(Token = "0x6000B0B")]
				[Address(RVA = "0x1D66D58", Offset = "0x1D66D58", VA = "0x1D66D58")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0x1D66D60", Offset = "0x1D66D60", VA = "0x1D66D60")]
			internal ControlPointExtrinsicProperties(bool isVisible, short segmentIndex, short controlPointIndex, short previousControlPointIndex, short nextControlPointIndex, bool previousControlPointIsSegment, bool nextControlPointIsSegment, bool canHaveFollowUp, short orientationAnchorIndex)
			{
			}

			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x1D66DA4", Offset = "0x1D66DA4", VA = "0x1D66DA4", Slot = "4")]
			public bool Equals(ControlPointExtrinsicProperties other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0x1D66E8C", Offset = "0x1D66E8C", VA = "0x1D66E8C", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0x1D66F30", Offset = "0x1D66F30", VA = "0x1D66F30", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000B10")]
			[Address(RVA = "0x1D6704C", Offset = "0x1D6704C", VA = "0x1D6704C")]
			public static bool operator ==(ControlPointExtrinsicProperties left, ControlPointExtrinsicProperties right)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B11")]
			[Address(RVA = "0x1D67098", Offset = "0x1D67098", VA = "0x1D67098")]
			public static bool operator !=(ControlPointExtrinsicProperties left, ControlPointExtrinsicProperties right)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color GizmoTangentColor;

		[NonSerialized]
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3[] Approximation;

		[NonSerialized]
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] ApproximationDistances;

		[NonSerialized]
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3[] ApproximationUp;

		[NonSerialized]
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] ApproximationT;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F91C4", Offset = "0x6F91C4")]
		private float <Length>k__BackingField;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F91D4", Offset = "0x6F91D4")]
		private float <Distance>k__BackingField;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6F91E4", Offset = "0x6F91E4")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x6F91E4", Offset = "0x6F91E4")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6F91E4", Offset = "0x6F91E4")]
		[SerializeField]
		private bool m_AutoBakeOrientation;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6F92A0", Offset = "0x6F92A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F92A0", Offset = "0x6F92A0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6F92A0", Offset = "0x6F92A0")]
		[SerializeField]
		private bool m_OrientationAnchor;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6F93B0", Offset = "0x6F93B0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6F93B0", Offset = "0x6F93B0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6F93B0", Offset = "0x6F93B0")]
		[SerializeField]
		private CurvyOrientationSwirl m_Swirl;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6F94D8", Offset = "0x6F94D8")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6F94D8", Offset = "0x6F94D8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6F94D8", Offset = "0x6F94D8")]
		[SerializeField]
		private float m_SwirlTurns;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6F9638", Offset = "0x6F9638")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x6F9638", Offset = "0x6F9638")]
		[SerializeField]
		private bool m_AutoHandles;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6F9748", Offset = "0x6F9748")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6F9748", Offset = "0x6F9748")]
		[SerializeField]
		private float m_AutoHandleDistance;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6F9850", Offset = "0x6F9850")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F9850", Offset = "0x6F9850")]
		private Vector3 m_HandleIn;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6F9904", Offset = "0x6F9904")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F9904", Offset = "0x6F9904")]
		private Vector3 m_HandleOut;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6F99B8", Offset = "0x6F99B8")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x6F99B8", Offset = "0x6F99B8")]
		[AttributeAttribute(Name = "GroupActionAttribute", RVA = "0x6F99B8", Offset = "0x6F99B8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6F99B8", Offset = "0x6F99B8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F99B8", Offset = "0x6F99B8")]
		private bool m_OverrideGlobalTension;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6F9B60", Offset = "0x6F9B60")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F9B60", Offset = "0x6F9B60")]
		private bool m_OverrideGlobalContinuity;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6F9BE8", Offset = "0x6F9BE8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F9BE8", Offset = "0x6F9BE8")]
		private bool m_OverrideGlobalBias;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F9C70", Offset = "0x6F9C70")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F9C70", Offset = "0x6F9C70")]
		private bool m_SynchronizeTCB;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6F9CE0", Offset = "0x6F9CE0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6F9CE0", Offset = "0x6F9CE0")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F9CE0", Offset = "0x6F9CE0")]
		private float m_StartTension;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6F9E04", Offset = "0x6F9E04")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6F9E04", Offset = "0x6F9E04")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F9E04", Offset = "0x6F9E04")]
		private float m_EndTension;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6F9F58", Offset = "0x6F9F58")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6F9F58", Offset = "0x6F9F58")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6F9F58", Offset = "0x6F9F58")]
		private float m_StartContinuity;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FA07C", Offset = "0x6FA07C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FA07C", Offset = "0x6FA07C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6FA07C", Offset = "0x6FA07C")]
		private float m_EndContinuity;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FA1D0", Offset = "0x6FA1D0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FA1D0", Offset = "0x6FA1D0")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6FA1D0", Offset = "0x6FA1D0")]
		private float m_StartBias;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FA2F4", Offset = "0x6FA2F4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FA2F4", Offset = "0x6FA2F4")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6FA2F4", Offset = "0x6FA2F4")]
		private float m_EndBias;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[HideInInspector]
		private CurvySplineSegment m_FollowUp;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[HideInInspector]
		private ConnectionHeadingEnum m_FollowUpHeading;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[HideInInspector]
		private bool m_ConnectionSyncPosition;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		[SerializeField]
		[HideInInspector]
		private bool m_ConnectionSyncRotation;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[HideInInspector]
		private CurvyConnection m_Connection;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int cacheSize;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 threadSafeLocalPosition;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion threadSafeLocalRotation;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private CurvySpline mSpline;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float mStepSize;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Bounds? mBounds;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int mCacheLastDistanceToLocalFIndex;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private readonly HashSet<UnityEngine.Component> mMetaData;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 lastProcessedLocalPosition;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion lastProcessedLocalRotation;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private ControlPointExtrinsicProperties extrinsicPropertiesINTERNAL;

		[Token(Token = "0x170000AB")]
		public bool AutoBakeOrientation
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x1D5CC48", Offset = "0x1D5CC48", VA = "0x1D5CC48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x1D5CC50", Offset = "0x1D5CC50", VA = "0x1D5CC50")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public bool SerializedOrientationAnchor
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x1D5CC6C", Offset = "0x1D5CC6C", VA = "0x1D5CC6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x1D5CC74", Offset = "0x1D5CC74", VA = "0x1D5CC74")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public CurvyOrientationSwirl Swirl
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x1D5CCE0", Offset = "0x1D5CCE0", VA = "0x1D5CCE0")]
			get
			{
				return default(CurvyOrientationSwirl);
			}
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x1D5CCE8", Offset = "0x1D5CCE8", VA = "0x1D5CCE8")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public float SwirlTurns
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x1D5CD2C", Offset = "0x1D5CD2C", VA = "0x1D5CD2C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x1D5CD34", Offset = "0x1D5CD34", VA = "0x1D5CD34")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public Vector3 HandleIn
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x1D5CD84", Offset = "0x1D5CD84", VA = "0x1D5CD84")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x1D5CD98", Offset = "0x1D5CD98", VA = "0x1D5CD98")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public Vector3 HandleOut
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x1D5CE88", Offset = "0x1D5CE88", VA = "0x1D5CE88")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x1D5CE9C", Offset = "0x1D5CE9C", VA = "0x1D5CE9C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public Vector3 HandleInPosition
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x1D5CF8C", Offset = "0x1D5CF8C", VA = "0x1D5CF8C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x1D5D0F8", Offset = "0x1D5D0F8", VA = "0x1D5D0F8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public Vector3 HandleOutPosition
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x1D5D228", Offset = "0x1D5D228", VA = "0x1D5D228")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x1D5D394", Offset = "0x1D5D394", VA = "0x1D5D394")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public bool AutoHandles
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x1D5D4C4", Offset = "0x1D5D4C4", VA = "0x1D5D4C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x1D5D4CC", Offset = "0x1D5D4CC", VA = "0x1D5D4CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public float AutoHandleDistance
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x1D5D688", Offset = "0x1D5D688", VA = "0x1D5D688")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x1D5D690", Offset = "0x1D5D690", VA = "0x1D5D690")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public bool SynchronizeTCB
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x1D5D770", Offset = "0x1D5D770", VA = "0x1D5D770")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x1D5D778", Offset = "0x1D5D778", VA = "0x1D5D778")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public bool OverrideGlobalTension
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x1D5D7C8", Offset = "0x1D5D7C8", VA = "0x1D5D7C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x1D5D7D0", Offset = "0x1D5D7D0", VA = "0x1D5D7D0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public bool OverrideGlobalContinuity
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x1D5D820", Offset = "0x1D5D820", VA = "0x1D5D820")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x1D5D828", Offset = "0x1D5D828", VA = "0x1D5D828")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public bool OverrideGlobalBias
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x1D5D878", Offset = "0x1D5D878", VA = "0x1D5D878")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x1D5D880", Offset = "0x1D5D880", VA = "0x1D5D880")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public float StartTension
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x1D5D8D0", Offset = "0x1D5D8D0", VA = "0x1D5D8D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x1D5D8D8", Offset = "0x1D5D8D8", VA = "0x1D5D8D8")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public float StartContinuity
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x1D5D928", Offset = "0x1D5D928", VA = "0x1D5D928")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x1D5D930", Offset = "0x1D5D930", VA = "0x1D5D930")]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public float StartBias
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x1D5D980", Offset = "0x1D5D980", VA = "0x1D5D980")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x1D5D988", Offset = "0x1D5D988", VA = "0x1D5D988")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public float EndTension
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x1D5D9D8", Offset = "0x1D5D9D8", VA = "0x1D5D9D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x1D5D9E0", Offset = "0x1D5D9E0", VA = "0x1D5D9E0")]
			set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public float EndContinuity
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x1D5DA30", Offset = "0x1D5DA30", VA = "0x1D5DA30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x1D5DA38", Offset = "0x1D5DA38", VA = "0x1D5DA38")]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public float EndBias
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x1D5DA88", Offset = "0x1D5DA88", VA = "0x1D5DA88")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x1D5DA90", Offset = "0x1D5DA90", VA = "0x1D5DA90")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public CurvySplineSegment FollowUp
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x1D5DAE0", Offset = "0x1D5DAE0", VA = "0x1D5DAE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x1D5DAE8", Offset = "0x1D5DAE8", VA = "0x1D5DAE8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public ConnectionHeadingEnum FollowUpHeading
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x1D5DBF0", Offset = "0x1D5DBF0", VA = "0x1D5DBF0")]
			get
			{
				return default(ConnectionHeadingEnum);
			}
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x1D5DBF8", Offset = "0x1D5DBF8", VA = "0x1D5DBF8")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public bool ConnectionSyncPosition
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x1D5DCC0", Offset = "0x1D5DCC0", VA = "0x1D5DCC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x1D5DCC8", Offset = "0x1D5DCC8", VA = "0x1D5DCC8")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public bool ConnectionSyncRotation
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x1D5DCE4", Offset = "0x1D5DCE4", VA = "0x1D5DCE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x1D5DCEC", Offset = "0x1D5DCEC", VA = "0x1D5DCEC")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public CurvyConnection Connection
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x1D5DD08", Offset = "0x1D5DD08", VA = "0x1D5DD08")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x1D5DD10", Offset = "0x1D5DD10", VA = "0x1D5DD10")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public int CacheSize
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x1D5DF1C", Offset = "0x1D5DF1C", VA = "0x1D5DF1C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x1D5DF24", Offset = "0x1D5DF24", VA = "0x1D5DF24")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public Bounds Bounds
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x1D5DF2C", Offset = "0x1D5DF2C", VA = "0x1D5DF2C")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x170000C6")]
		public float Length
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x1D5E2BC", Offset = "0x1D5E2BC", VA = "0x1D5E2BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703794", Offset = "0x703794")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x1D5E2C4", Offset = "0x1D5E2C4", VA = "0x1D5E2C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7037A4", Offset = "0x7037A4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public float Distance
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x1D5E2CC", Offset = "0x1D5E2CC", VA = "0x1D5E2CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7037B4", Offset = "0x7037B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x1D5E2D4", Offset = "0x1D5E2D4", VA = "0x1D5E2D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7037C4", Offset = "0x7037C4")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public float TF
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x1D5E2DC", Offset = "0x1D5E2DC", VA = "0x1D5E2DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C9")]
		public bool IsFirstControlPoint
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x1D5E31C", Offset = "0x1D5E31C", VA = "0x1D5E31C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CA")]
		public bool IsLastControlPoint
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x1D5E354", Offset = "0x1D5E354", VA = "0x1D5E354")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CB")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7043D0", Offset = "0x7043D0")]
		public List<UnityEngine.Component> MetaData
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x1D5E3B4", Offset = "0x1D5E3B4", VA = "0x1D5E3B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		public HashSet<UnityEngine.Component> MetaDataSet
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x1D5E410", Offset = "0x1D5E410", VA = "0x1D5E410")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		public CurvySpline Spline
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x1D5E418", Offset = "0x1D5E418", VA = "0x1D5E418")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CE")]
		public bool HasUnprocessedLocalPosition
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x1D5E420", Offset = "0x1D5E420", VA = "0x1D5E420")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		public bool HasUnprocessedLocalOrientation
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x1D5E4EC", Offset = "0x1D5E4EC", VA = "0x1D5E4EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D0")]
		public bool OrientatinInfluencesSpline
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x1D5E554", Offset = "0x1D5E554", VA = "0x1D5E554")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D1")]
		private CurvyInterpolation interpolation
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x1D6349C", Offset = "0x1D6349C", VA = "0x1D6349C")]
			get
			{
				return default(CurvyInterpolation);
			}
		}

		[Token(Token = "0x170000D2")]
		private bool isDynamicOrientation
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x1D63540", Offset = "0x1D63540", VA = "0x1D63540")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D3")]
		private bool IsOrientationAnchorEditable
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x1D635F0", Offset = "0x1D635F0", VA = "0x1D635F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D4")]
		private bool canHaveSwirl
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x1D63720", Offset = "0x1D63720", VA = "0x1D63720")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1D5E62C", Offset = "0x1D5E62C", VA = "0x1D5E62C")]
		public void SetBezierHandleIn(Vector3 position, Space space = Space.Self, CurvyBezierModeEnum mode = CurvyBezierModeEnum.None)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1D5ECCC", Offset = "0x1D5ECCC", VA = "0x1D5ECCC")]
		public void SetBezierHandleOut(Vector3 position, Space space = Space.Self, CurvyBezierModeEnum mode = CurvyBezierModeEnum.None)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1D5F378", Offset = "0x1D5F378", VA = "0x1D5F378")]
		public void SetBezierHandles(float distanceFrag = -1f, bool setIn = true, bool setOut = true, bool noDirtying = false)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1D5F6E8", Offset = "0x1D5F6E8", VA = "0x1D5F6E8")]
		public void SetBezierHandles(float distanceFrag, Vector3 p, Vector3 n, bool setIn = true, bool setOut = true, bool noDirtying = false)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1D5F998", Offset = "0x1D5F998", VA = "0x1D5F998")]
		public void SetFollowUp(CurvySplineSegment target, ConnectionHeadingEnum heading = ConnectionHeadingEnum.Auto)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1D5FA84", Offset = "0x1D5FA84", VA = "0x1D5FA84")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1D5FB38", Offset = "0x1D5FB38", VA = "0x1D5FB38")]
		public void ResetConnectionRelatedData()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1D5FB88", Offset = "0x1D5FB88", VA = "0x1D5FB88")]
		public Vector3 Interpolate(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1D5FBCC", Offset = "0x1D5FBCC", VA = "0x1D5FBCC")]
		public Vector3 Interpolate(float localF, CurvyInterpolation interpolation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1D602BC", Offset = "0x1D602BC", VA = "0x1D602BC")]
		public Vector3 InterpolateFast(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1D6055C", Offset = "0x1D6055C", VA = "0x1D6055C")]
		public void ReloadMetaData()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1D608CC", Offset = "0x1D608CC", VA = "0x1D608CC")]
		public void RegisterMetaData(CurvyMetadataBase metaData)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1D60948", Offset = "0x1D60948", VA = "0x1D60948")]
		public void UnregisterMetaData(CurvyMetadataBase metaData)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1D609BC", Offset = "0x1D609BC", VA = "0x1D609BC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7037D4", Offset = "0x7037D4")]
		public UnityEngine.Component GetMetaData(Type type, bool autoCreate = false)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		public T GetMetadata<T>(bool autoCreate = false) where T : UnityEngine.Component, ICurvyMetadata
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		public U GetInterpolatedMetadata<T, U>(float f) where T : CurvyInterpolatableMetadataBase<U>
		{
			return (U)null;
		}

		[Token(Token = "0x60004CE")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x703808", Offset = "0x703808")]
		public U InterpolateMetadata<T, U>(float f) where T : UnityEngine.Component, ICurvyInterpolatableMetadata<U>
		{
			return (U)null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1D60D10", Offset = "0x1D60D10", VA = "0x1D60D10")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x70383C", Offset = "0x70383C")]
		public object InterpolateMetadata(Type type, float f)
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1D60EA8", Offset = "0x1D60EA8", VA = "0x1D60EA8")]
		public void DeleteMetadata()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1D60F64", Offset = "0x1D60F64", VA = "0x1D60F64")]
		public Vector3 InterpolateScale(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1D61100", Offset = "0x1D61100", VA = "0x1D61100")]
		public Vector3 GetTangent(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1D611C0", Offset = "0x1D611C0", VA = "0x1D611C0")]
		public Vector3 GetTangent(float localF, Vector3 position)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1D61458", Offset = "0x1D61458", VA = "0x1D61458")]
		public Vector3 GetTangentFast(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1D615F4", Offset = "0x1D615F4", VA = "0x1D615F4")]
		public void InterpolateAndGetTangent(float localF, out Vector3 localPosition, out Vector3 localTangent)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1D616EC", Offset = "0x1D616EC", VA = "0x1D616EC")]
		public void InterpolateAndGetTangentFast(float localF, out Vector3 localPosition, out Vector3 localTangent)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1D61964", Offset = "0x1D61964", VA = "0x1D61964")]
		public Quaternion GetOrientationFast(float localF)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1D61980", Offset = "0x1D61980", VA = "0x1D61980")]
		public Quaternion GetOrientationFast(float localF, bool inverse)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1D61B60", Offset = "0x1D61B60", VA = "0x1D61B60")]
		public Vector3 GetOrientationUpFast(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1D61CFC", Offset = "0x1D61CFC", VA = "0x1D61CFC")]
		public float GetNearestPointF(Vector3 p)
		{
			return default(float);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1D62088", Offset = "0x1D62088", VA = "0x1D62088")]
		public float DistanceToLocalF(float localDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1D62354", Offset = "0x1D62354", VA = "0x1D62354")]
		public float LocalFToDistance(float localF)
		{
			return default(float);
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1D5E2E4", Offset = "0x1D5E2E4", VA = "0x1D5E2E4")]
		public float LocalFToTF(float localF)
		{
			return default(float);
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1D6251C", Offset = "0x1D6251C", VA = "0x1D6251C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1D62604", Offset = "0x1D62604", VA = "0x1D62604")]
		public void BakeOrientationToTransform()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1D60458", Offset = "0x1D60458", VA = "0x1D60458")]
		public int getApproximationIndexINTERNAL(float localF, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1D6295C", Offset = "0x1D6295C", VA = "0x1D6295C")]
		public void LinkToSpline(CurvySpline spline)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1D62964", Offset = "0x1D62964", VA = "0x1D62964")]
		public void UnlinkFromSpline()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1D62974", Offset = "0x1D62974", VA = "0x1D62974")]
		public void SetLocalPosition(Vector3 newPosition)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1D62C08", Offset = "0x1D62C08", VA = "0x1D62C08")]
		public void SetPosition(Vector3 value)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1D626AC", Offset = "0x1D626AC", VA = "0x1D626AC")]
		public void SetLocalRotation(Quaternion value)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1D62E9C", Offset = "0x1D62E9C", VA = "0x1D62E9C")]
		public void SetRotation(Quaternion value)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1D6314C", Offset = "0x1D6314C", VA = "0x1D6314C", Slot = "4")]
		public void OnBeforePush()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1D63254", Offset = "0x1D63254", VA = "0x1D63254", Slot = "5")]
		public void OnAfterPop()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1D633D0", Offset = "0x1D633D0", VA = "0x1D633D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1D633D4", Offset = "0x1D633D4", VA = "0x1D633D4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1D633D8", Offset = "0x1D633D8", VA = "0x1D633D8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1D633DC", Offset = "0x1D633DC", VA = "0x1D633DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1D63448", Offset = "0x1D63448", VA = "0x1D63448")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1D63470", Offset = "0x1D63470", VA = "0x1D63470")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1D63498", Offset = "0x1D63498", VA = "0x1D63498")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1D63258", Offset = "0x1D63258", VA = "0x1D63258")]
		public void Reset()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1D6384C", Offset = "0x1D6384C", VA = "0x1D6384C")]
		internal void SetExtrinsicPropertiesINTERNAL(ControlPointExtrinsicProperties value)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1D6385C", Offset = "0x1D6385C", VA = "0x1D6385C")]
		internal unsafe ref ControlPointExtrinsicProperties GetExtrinsicPropertiesINTERNAL()
		{
			return ref *(ControlPointExtrinsicProperties*)null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1D606A0", Offset = "0x1D606A0", VA = "0x1D606A0")]
		private void CheckAgainstMetaDataDuplication()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1D63404", Offset = "0x1D63404", VA = "0x1D63404")]
		private void DoUpdate()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1D5DDDC", Offset = "0x1D5DDDC", VA = "0x1D5DDDC")]
		private bool SetConnection(CurvyConnection newConnection)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1D5D50C", Offset = "0x1D5D50C", VA = "0x1D5D50C")]
		private bool SetAutoHandles(bool newValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1D62070", Offset = "0x1D62070", VA = "0x1D62070")]
		private float getApproximationLocalF(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1D63864", Offset = "0x1D63864", VA = "0x1D63864")]
		internal void refreshCurveINTERNAL(CurvyInterpolation splineInterpolation, bool isControlPointASegment, CurvySpline spline)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1D64220", Offset = "0x1D64220", VA = "0x1D64220")]
		private float InterpolateBezierSegment(CurvySpline spline, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1D64FC8", Offset = "0x1D64FC8", VA = "0x1D64FC8")]
		private float InterpolateTCBSegment(CurvySpline spline, CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1D648E8", Offset = "0x1D648E8", VA = "0x1D648E8")]
		private float InterpolateCatmullSegment(CurvySpline spline, CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1D657E8", Offset = "0x1D657E8", VA = "0x1D657E8")]
		private float InterpolateLinearSegment(CurvySpline spline, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1D65CCC", Offset = "0x1D65CCC", VA = "0x1D65CCC")]
		internal void refreshOrientationNoneINTERNAL()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1D5C970", Offset = "0x1D5C970", VA = "0x1D5C970")]
		internal void refreshOrientationStaticINTERNAL()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1D66038", Offset = "0x1D66038", VA = "0x1D66038")]
		internal void refreshOrientationDynamicINTERNAL(Vector3 initialUp)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1D66338", Offset = "0x1D66338", VA = "0x1D66338")]
		internal void ClearBoundsINTERNAL()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1D65D10", Offset = "0x1D65D10", VA = "0x1D65D10")]
		internal Vector3 getOrthoUp0INTERNAL()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1D65E60", Offset = "0x1D65E60", VA = "0x1D65E60")]
		private Vector3 getOrthoUp1INTERNAL()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1D66350", Offset = "0x1D66350", VA = "0x1D66350")]
		internal void UnsetFollowUpWithoutDirtyingINTERNAL()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1D6637C", Offset = "0x1D6637C", VA = "0x1D6637C")]
		private bool SnapToFitSplineLength(float newSplineLength, float stepSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1D66A48", Offset = "0x1D66A48", VA = "0x1D66A48")]
		internal void PrepareThreadSafeTransfromINTERNAL()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1D66AC8", Offset = "0x1D66AC8", VA = "0x1D66AC8")]
		public CurvySplineSegment()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public static class CurvySplineSegmentDefaultValues
	{
		[Token(Token = "0x4000286")]
		public const CurvyOrientationSwirl Swirl = CurvyOrientationSwirl.None;

		[Token(Token = "0x4000287")]
		public const bool AutoHandles = true;

		[Token(Token = "0x4000288")]
		public const float AutoHandleDistance = 0.39f;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector3 HandleIn;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly Vector3 HandleOut;
	}
	[Token(Token = "0x20000B2")]
	public static class CurvySplineDefaultValues
	{
		[Token(Token = "0x400028B")]
		public const bool AutoEndTangents = true;

		[Token(Token = "0x400028C")]
		public const CurvyOrientation Orientation = CurvyOrientation.Dynamic;

		[Token(Token = "0x400028D")]
		public const float AutoHandleDistance = 0.39f;

		[Token(Token = "0x400028E")]
		public const int CacheDensity = 50;

		[Token(Token = "0x400028F")]
		public const float MaxPointsPerUnit = 8f;

		[Token(Token = "0x4000290")]
		public const bool UsePooling = true;

		[Token(Token = "0x4000291")]
		public const CurvyUpdateMethod UpdateIn = CurvyUpdateMethod.Update;

		[Token(Token = "0x4000292")]
		public const bool CheckTransform = true;
	}
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F5A90", Offset = "0x6F5A90")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6F5A90", Offset = "0x6F5A90")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F5A90", Offset = "0x6F5A90")]
	public class CurvyUISpline : CurvySpline
	{
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1D671B8", Offset = "0x1D671B8", VA = "0x1D671B8")]
		public static CurvyUISpline CreateUISpline(string gameObjectName = "Curvy UI Spline")
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1D67368", Offset = "0x1D67368", VA = "0x1D67368", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1D6732C", Offset = "0x1D6732C", VA = "0x1D6732C")]
		private void SetupUISpline()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1D67388", Offset = "0x1D67388", VA = "0x1D67388")]
		public CurvyUISpline()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.ThirdParty.LibTessDotNet
{
	[Token(Token = "0x20000B4")]
	internal class Dict<TValue> where TValue : class
	{
		[Token(Token = "0x2000166")]
		public class Node
		{
			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _prev;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _next;

			[Token(Token = "0x17000283")]
			public TValue Key
			{
				[Token(Token = "0x6000B12")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000284")]
			public Node Prev
			{
				[Token(Token = "0x6000B13")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000285")]
			public Node Next
			{
				[Token(Token = "0x6000B14")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B15")]
			public Node()
			{
			}
		}

		[Token(Token = "0x2000167")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Node _head;

		[Token(Token = "0x6000511")]
		public Dict(LessOrEqual leq)
		{
		}

		[Token(Token = "0x6000512")]
		public Node Insert(TValue key)
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		public Node InsertBefore(Node node, TValue key)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		public Node Find(TValue key)
		{
			return null;
		}

		[Token(Token = "0x6000515")]
		public Node Min()
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		public void Remove(Node node)
		{
		}
	}
	[Token(Token = "0x20000B5")]
	internal static class Geom
	{
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1BEB4A8", Offset = "0x1BEB4A8", VA = "0x1BEB4A8")]
		public static bool IsWindingInside(WindingRule rule, int n)
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1BEB5AC", Offset = "0x1BEB5AC", VA = "0x1BEB5AC")]
		public static bool VertCCW(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(bool);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1BEB664", Offset = "0x1BEB664", VA = "0x1BEB664")]
		public static bool VertEq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1BEB6CC", Offset = "0x1BEB6CC", VA = "0x1BEB6CC")]
		public static bool VertLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1BEB748", Offset = "0x1BEB748", VA = "0x1BEB748")]
		public static float EdgeEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1BEB804", Offset = "0x1BEB804", VA = "0x1BEB804")]
		public static float EdgeSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1BEB89C", Offset = "0x1BEB89C", VA = "0x1BEB89C")]
		public static bool TransLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1BEB918", Offset = "0x1BEB918", VA = "0x1BEB918")]
		public static float TransEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1BEB9D4", Offset = "0x1BEB9D4", VA = "0x1BEB9D4")]
		public static float TransSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1BEBA6C", Offset = "0x1BEBA6C", VA = "0x1BEBA6C")]
		public static bool EdgeGoesLeft(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1BEBAC4", Offset = "0x1BEBAC4", VA = "0x1BEBAC4")]
		public static bool EdgeGoesRight(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1BEBB10", Offset = "0x1BEBB10", VA = "0x1BEBB10")]
		public static float VertL1dist(MeshUtils.Vertex u, MeshUtils.Vertex v)
		{
			return default(float);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1BEBBCC", Offset = "0x1BEBBCC", VA = "0x1BEBBCC")]
		public static void AddWinding(MeshUtils.Edge eDst, MeshUtils.Edge eSrc)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1BEBC38", Offset = "0x1BEBC38", VA = "0x1BEBC38")]
		public static float Interpolate(float a, float x, float b, float y)
		{
			return default(float);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1BEBCB0", Offset = "0x1BEBCB0", VA = "0x1BEBCB0")]
		private static void Swap(ref MeshUtils.Vertex a, ref MeshUtils.Vertex b)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1BEBCE0", Offset = "0x1BEBCE0", VA = "0x1BEBCE0")]
		public static void EdgeIntersect(MeshUtils.Vertex o1, MeshUtils.Vertex d1, MeshUtils.Vertex o2, MeshUtils.Vertex d2, MeshUtils.Vertex v)
		{
		}
	}
	[Token(Token = "0x20000B6")]
	internal class LTMesh : MeshUtils.Pooled<LTMesh>
	{
		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal MeshUtils.Vertex _vHead;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal MeshUtils.Face _fHead;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal MeshUtils.Edge _eHead;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal MeshUtils.Edge _eHeadSym;

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1BEC1B8", Offset = "0x1BEC1B8", VA = "0x1BEC1B8")]
		public LTMesh()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1BEC70C", Offset = "0x1BEC70C", VA = "0x1BEC70C", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1BEC75C", Offset = "0x1BEC75C", VA = "0x1BEC75C", Slot = "5")]
		public override void OnFree()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1BEC8E4", Offset = "0x1BEC8E4", VA = "0x1BEC8E4")]
		public MeshUtils.Edge MakeEdge()
		{
			return null;
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1BECD54", Offset = "0x1BECD54", VA = "0x1BECD54")]
		public void Splice(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1BED120", Offset = "0x1BED120", VA = "0x1BED120")]
		public void Delete(MeshUtils.Edge eDel)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1BED500", Offset = "0x1BED500", VA = "0x1BED500")]
		public MeshUtils.Edge AddEdgeVertex(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1BED5C0", Offset = "0x1BED5C0", VA = "0x1BED5C0")]
		public MeshUtils.Edge SplitEdge(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1BED7C0", Offset = "0x1BED7C0", VA = "0x1BED7C0")]
		public MeshUtils.Edge Connect(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
			return null;
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1BED8EC", Offset = "0x1BED8EC", VA = "0x1BED8EC")]
		public void ZapFace(MeshUtils.Face fZap)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1BEDB58", Offset = "0x1BEDB58", VA = "0x1BEDB58")]
		public void MergeConvexFaces(int maxVertsPerFace)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1BEDE44", Offset = "0x1BEDE44", VA = "0x1BEDE44")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x703870", Offset = "0x703870")]
		public void Check()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6F5B54", Offset = "0x6F5B54")]
	public struct Vec3
	{
		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vec3 Zero;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float X;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Y;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float Z;

		[Token(Token = "0x170000D5")]
		public float Item
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x1D76EF4", Offset = "0x1D76EF4", VA = "0x1D76EF4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x1D76FA0", Offset = "0x1D76FA0", VA = "0x1D76FA0")]
			set
			{
			}
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1D77054", Offset = "0x1D77054", VA = "0x1D77054")]
		public static void Sub(ref Vec3 lhs, ref Vec3 rhs, out Vec3 result)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1D77088", Offset = "0x1D77088", VA = "0x1D77088")]
		public static void Neg(ref Vec3 v)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1D770B0", Offset = "0x1D770B0", VA = "0x1D770B0")]
		public static void Dot(ref Vec3 u, ref Vec3 v, out float dot)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1D770DC", Offset = "0x1D770DC", VA = "0x1D770DC")]
		public static void Normalize(ref Vec3 v)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1D771B4", Offset = "0x1D771B4", VA = "0x1D771B4")]
		public static int LongAxis(ref Vec3 v)
		{
			return default(int);
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1D772F4", Offset = "0x1D772F4", VA = "0x1D772F4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000B8")]
	internal static class MeshUtils
	{
		[Token(Token = "0x2000168")]
		public abstract class Pooled<T> where T : Pooled<T>, new()
		{
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Stack<T> _stack;

			[Token(Token = "0x6000B1A")]
			public abstract void Reset();

			[Token(Token = "0x6000B1B")]
			public virtual void OnFree()
			{
			}

			[Token(Token = "0x6000B1C")]
			public static T Create()
			{
				return null;
			}

			[Token(Token = "0x6000B1D")]
			public void Free()
			{
			}

			[Token(Token = "0x6000B1E")]
			protected Pooled()
			{
			}
		}

		[Token(Token = "0x2000169")]
		public class Vertex : Pooled<Vertex>
		{
			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Vertex _prev;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Vertex _next;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Edge _anEdge;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal Vec3 _coords;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal float _s;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal float _t;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal PQHandle _pqHandle;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal int _n;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal object _data;

			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x1BEE43C", Offset = "0x1BEE43C", VA = "0x1BEE43C", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x1BEE518", Offset = "0x1BEE518", VA = "0x1BEE518")]
			public Vertex()
			{
			}
		}

		[Token(Token = "0x200016A")]
		public class Face : Pooled<Face>
		{
			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Face _prev;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Face _next;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Edge _anEdge;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal Face _trail;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int _n;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal bool _marked;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
			internal bool _inside;

			[Token(Token = "0x17000286")]
			internal int VertsCount
			{
				[Token(Token = "0x6000B21")]
				[Address(RVA = "0x1BEDDE4", Offset = "0x1BEDDE4", VA = "0x1BEDDE4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000B22")]
			[Address(RVA = "0x1BEE388", Offset = "0x1BEE388", VA = "0x1BEE388", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x1BEE3E0", Offset = "0x1BEE3E0", VA = "0x1BEE3E0")]
			public Face()
			{
			}
		}

		[Token(Token = "0x200016B")]
		public struct EdgePair
		{
			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Edge _e;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal Edge _eSym;

			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x1BEC618", Offset = "0x1BEC618", VA = "0x1BEC618")]
			public static EdgePair Create()
			{
				return default(EdgePair);
			}

			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x1BEE2FC", Offset = "0x1BEE2FC", VA = "0x1BEE2FC")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x200016C")]
		public class Edge : Pooled<Edge>
		{
			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal EdgePair _pair;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Edge _next;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal Edge _Sym;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Edge _Onext;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal Edge _Lnext;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Vertex _Org;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal Face _Lface;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Tess.ActiveRegion _activeRegion;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal int _winding;

			[Token(Token = "0x17000287")]
			internal Face _Rface
			{
				[Token(Token = "0x6000B26")]
				[Address(RVA = "0x1BED3B0", Offset = "0x1BED3B0", VA = "0x1BED3B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B27")]
				[Address(RVA = "0x1BED790", Offset = "0x1BED790", VA = "0x1BED790")]
				set
				{
				}
			}

			[Token(Token = "0x17000288")]
			internal Vertex _Dst
			{
				[Token(Token = "0x6000B28")]
				[Address(RVA = "0x1BEBAA4", Offset = "0x1BEBAA4", VA = "0x1BEBAA4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B29")]
				[Address(RVA = "0x1BED760", Offset = "0x1BED760", VA = "0x1BED760")]
				set
				{
				}
			}

			[Token(Token = "0x17000289")]
			internal Edge _Oprev
			{
				[Token(Token = "0x6000B2A")]
				[Address(RVA = "0x1BED3D0", Offset = "0x1BED3D0", VA = "0x1BED3D0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B2B")]
				[Address(RVA = "0x1BEE078", Offset = "0x1BEE078", VA = "0x1BEE078")]
				set
				{
				}
			}

			[Token(Token = "0x1700028A")]
			internal Edge _Lprev
			{
				[Token(Token = "0x6000B2C")]
				[Address(RVA = "0x1BEDE24", Offset = "0x1BEDE24", VA = "0x1BEDE24")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B2D")]
				[Address(RVA = "0x1BEE0A8", Offset = "0x1BEE0A8", VA = "0x1BEE0A8")]
				set
				{
				}
			}

			[Token(Token = "0x1700028B")]
			internal Edge _Dprev
			{
				[Token(Token = "0x6000B2E")]
				[Address(RVA = "0x1BEE0D8", Offset = "0x1BEE0D8", VA = "0x1BEE0D8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B2F")]
				[Address(RVA = "0x1BEE0F8", Offset = "0x1BEE0F8", VA = "0x1BEE0F8")]
				set
				{
				}
			}

			[Token(Token = "0x1700028C")]
			internal Edge _Rprev
			{
				[Token(Token = "0x6000B30")]
				[Address(RVA = "0x1BEE128", Offset = "0x1BEE128", VA = "0x1BEE128")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B31")]
				[Address(RVA = "0x1BEE148", Offset = "0x1BEE148", VA = "0x1BEE148")]
				set
				{
				}
			}

			[Token(Token = "0x1700028D")]
			internal Edge _Dnext
			{
				[Token(Token = "0x6000B32")]
				[Address(RVA = "0x1BEE178", Offset = "0x1BEE178", VA = "0x1BEE178")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B33")]
				[Address(RVA = "0x1BEE1A8", Offset = "0x1BEE1A8", VA = "0x1BEE1A8")]
				set
				{
				}
			}

			[Token(Token = "0x1700028E")]
			internal Edge _Rnext
			{
				[Token(Token = "0x6000B34")]
				[Address(RVA = "0x1BEE1E8", Offset = "0x1BEE1E8", VA = "0x1BEE1E8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B35")]
				[Address(RVA = "0x1BEE218", Offset = "0x1BEE218", VA = "0x1BEE218")]
				set
				{
				}
			}

			[Token(Token = "0x6000B36")]
			[Address(RVA = "0x1BEDF60", Offset = "0x1BEDF60", VA = "0x1BEDF60")]
			internal static void EnsureFirst(ref Edge e)
			{
			}

			[Token(Token = "0x6000B37")]
			[Address(RVA = "0x1BEE258", Offset = "0x1BEE258", VA = "0x1BEE258", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000B38")]
			[Address(RVA = "0x1BEE32C", Offset = "0x1BEE32C", VA = "0x1BEE32C")]
			public Edge()
			{
			}
		}

		[Token(Token = "0x400029D")]
		public const int Undef = -1;

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1BEC930", Offset = "0x1BEC930", VA = "0x1BEC930")]
		public static Edge MakeEdge(Edge eNext)
		{
			return null;
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1BED064", Offset = "0x1BED064", VA = "0x1BED064")]
		public static void Splice(Edge a, Edge b)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1BECAE8", Offset = "0x1BECAE8", VA = "0x1BECAE8")]
		public static void MakeVertex(Edge eOrig, Vertex vNext)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1BECC0C", Offset = "0x1BECC0C", VA = "0x1BECC0C")]
		public static void MakeFace(Edge eOrig, Face fNext)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1BED3F0", Offset = "0x1BED3F0", VA = "0x1BED3F0")]
		public static void KillEdge(Edge eDel)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1BECE3C", Offset = "0x1BECE3C", VA = "0x1BECE3C")]
		public static void KillVertex(Vertex vDel, Vertex newOrg)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1BECF50", Offset = "0x1BECF50", VA = "0x1BECF50")]
		public static void KillFace(Face fDel, Face newLFace)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1BEDFAC", Offset = "0x1BEDFAC", VA = "0x1BEDFAC")]
		public static float FaceArea(Face f)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000B9")]
	internal struct PQHandle
	{
		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int Invalid;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal int _handle;
	}
	[Token(Token = "0x20000BA")]
	internal class PriorityHeap<TValue> where TValue : class
	{
		[Token(Token = "0x200016D")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x200016E")]
		protected class HandleElem
		{
			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int _node;

			[Token(Token = "0x6000B3D")]
			public HandleElem()
			{
			}
		}

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _nodes;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HandleElem[] _handles;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _freeList;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x170000D6")]
		public bool Empty
		{
			[Token(Token = "0x6000545")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000546")]
		public PriorityHeap(int initialSize, LessOrEqual leq)
		{
		}

		[Token(Token = "0x6000547")]
		private void FloatDown(int curr)
		{
		}

		[Token(Token = "0x6000548")]
		private void FloatUp(int curr)
		{
		}

		[Token(Token = "0x6000549")]
		public void Init()
		{
		}

		[Token(Token = "0x600054A")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x600054B")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x600054D")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x20000BB")]
	internal class PriorityQueue<TValue> where TValue : class
	{
		[Token(Token = "0x200016F")]
		private class StackItem
		{
			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int p;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int r;

			[Token(Token = "0x6000B3E")]
			public StackItem()
			{
			}
		}

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue>.LessOrEqual _leq;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue> _heap;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TValue[] _keys;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _order;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x170000D7")]
		public bool Empty
		{
			[Token(Token = "0x600054E")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600054F")]
		public PriorityQueue(int initialSize, PriorityHeap<TValue>.LessOrEqual leq)
		{
		}

		[Token(Token = "0x6000550")]
		private static void Swap(ref int a, ref int b)
		{
		}

		[Token(Token = "0x6000551")]
		public void Init()
		{
		}

		[Token(Token = "0x6000552")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x6000553")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x6000554")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class Tess
	{
		[Token(Token = "0x2000170")]
		internal class ActiveRegion
		{
			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal MeshUtils.Edge _eUp;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Dict<ActiveRegion>.Node _nodeUp;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int _windingNumber;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool _inside;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			internal bool _sentinel;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
			internal bool _dirty;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
			internal bool _fixUpperEdge;

			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0x1D76950", Offset = "0x1D76950", VA = "0x1D76950")]
			public ActiveRegion()
			{
			}
		}

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private LTMesh _mesh;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Vec3 _normal;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vec3 _sUnit;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vec3 _tUnit;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _bminX;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _bminY;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _bmaxX;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _bmaxY;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WindingRule _windingRule;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Dict<ActiveRegion> _dict;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PriorityQueue<MeshUtils.Vertex> _pq;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private MeshUtils.Vertex _event;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CombineCallback _combineCallback;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private ContourVertex[] _vertices;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _vertexCount;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int[] _elements;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _elementCount;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float SUnitX;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float SUnitY;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float SentinelCoord;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool NoEmptyPolygons;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		public bool UsePooling;

		[Token(Token = "0x170000D8")]
		public Vec3 Normal
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x1BF1858", Offset = "0x1BF1858", VA = "0x1BF1858")]
			get
			{
				return default(Vec3);
			}
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x1BF186C", Offset = "0x1BF186C", VA = "0x1BF186C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public ContourVertex[] Vertices
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x1BF1878", Offset = "0x1BF1878", VA = "0x1BF1878")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DA")]
		public int VertexCount
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x1BF1880", Offset = "0x1BF1880", VA = "0x1BF1880")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DB")]
		public int[] Elements
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x1BF1888", Offset = "0x1BF1888", VA = "0x1BF1888")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		public int ElementCount
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x1BF1890", Offset = "0x1BF1890", VA = "0x1BF1890")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1BEE5D0", Offset = "0x1BEE5D0", VA = "0x1BEE5D0")]
		private ActiveRegion RegionBelow(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1BEE610", Offset = "0x1BEE610", VA = "0x1BEE610")]
		private ActiveRegion RegionAbove(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1BEE650", Offset = "0x1BEE650", VA = "0x1BEE650")]
		private bool EdgeLeq(ActiveRegion reg1, ActiveRegion reg2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1BEE7F0", Offset = "0x1BEE7F0", VA = "0x1BEE7F0")]
		private void DeleteRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1BEE89C", Offset = "0x1BEE89C", VA = "0x1BEE89C")]
		private void FixUpperEdge(ActiveRegion reg, MeshUtils.Edge newEdge)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1BEE910", Offset = "0x1BEE910", VA = "0x1BEE910")]
		private ActiveRegion TopLeftRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1BEEA00", Offset = "0x1BEEA00", VA = "0x1BEEA00")]
		private ActiveRegion TopRightRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1BEEA88", Offset = "0x1BEEA88", VA = "0x1BEEA88")]
		private ActiveRegion AddRegionBelow(ActiveRegion regAbove, MeshUtils.Edge eNewUp)
		{
			return null;
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1BEEB8C", Offset = "0x1BEEB8C", VA = "0x1BEEB8C")]
		private void ComputeWinding(ActiveRegion reg)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1BEEBEC", Offset = "0x1BEEBEC", VA = "0x1BEEBEC")]
		private void FinishRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1BEEC60", Offset = "0x1BEEC60", VA = "0x1BEEC60")]
		private MeshUtils.Edge FinishLeftRegions(ActiveRegion regFirst, ActiveRegion regLast)
		{
			return null;
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1BEEDE8", Offset = "0x1BEEDE8", VA = "0x1BEEDE8")]
		private void AddRightEdges(ActiveRegion regUp, MeshUtils.Edge eFirst, MeshUtils.Edge eLast, MeshUtils.Edge eTopLeft, bool cleanUp)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1BEF5E4", Offset = "0x1BEF5E4", VA = "0x1BEF5E4")]
		private void SpliceMergeVertices(MeshUtils.Edge e1, MeshUtils.Edge e2)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1BEF614", Offset = "0x1BEF614", VA = "0x1BEF614")]
		private void VertexWeights(MeshUtils.Vertex isect, MeshUtils.Vertex org, MeshUtils.Vertex dst, out float w0, out float w1)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1BEF720", Offset = "0x1BEF720", VA = "0x1BEF720")]
		private void GetIntersectData(MeshUtils.Vertex isect, MeshUtils.Vertex orgUp, MeshUtils.Vertex dstUp, MeshUtils.Vertex orgLo, MeshUtils.Vertex dstLo)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1BEF048", Offset = "0x1BEF048", VA = "0x1BEF048")]
		private bool CheckForRightSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1BEFAD8", Offset = "0x1BEFAD8", VA = "0x1BEFAD8")]
		private bool CheckForLeftSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1BEFD08", Offset = "0x1BEFD08", VA = "0x1BEFD08")]
		private bool CheckForIntersect(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1BEF2C0", Offset = "0x1BEF2C0", VA = "0x1BEF2C0")]
		private void WalkDirtyRegions(ActiveRegion regUp)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1BF0608", Offset = "0x1BF0608", VA = "0x1BF0608")]
		private void ConnectRightVertex(ActiveRegion regUp, MeshUtils.Edge eBottomLeft)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1BF08F0", Offset = "0x1BF08F0", VA = "0x1BF08F0")]
		private void ConnectLeftDegenerate(ActiveRegion regUp, MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1BF0B80", Offset = "0x1BF0B80", VA = "0x1BF0B80")]
		private void ConnectLeftVertex(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1BF0A64", Offset = "0x1BF0A64", VA = "0x1BF0A64")]
		private void SweepEvent(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1BF0E3C", Offset = "0x1BF0E3C", VA = "0x1BF0E3C")]
		private void AddSentinel(float smin, float smax, float t)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1BF1038", Offset = "0x1BF1038", VA = "0x1BF1038")]
		private void InitEdgeDict()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1BF1134", Offset = "0x1BF1134", VA = "0x1BF1134")]
		private void DoneEdgeDict()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1BF11E0", Offset = "0x1BF11E0", VA = "0x1BF11E0")]
		private void RemoveDegenerateEdges()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1BF13CC", Offset = "0x1BF13CC", VA = "0x1BF13CC")]
		private void InitPriorityQ()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1BF1614", Offset = "0x1BF1614", VA = "0x1BF1614")]
		private void DonePriorityQ()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1BF1624", Offset = "0x1BF1624", VA = "0x1BF1624")]
		private void RemoveDegenerateFaces()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1BF16F0", Offset = "0x1BF16F0", VA = "0x1BF16F0")]
		protected void ComputeInterior()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1BF1898", Offset = "0x1BF1898", VA = "0x1BF1898")]
		public Tess()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1BF1990", Offset = "0x1BF1990", VA = "0x1BF1990")]
		private void ComputeNormal(ref Vec3 norm)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1BF2518", Offset = "0x1BF2518", VA = "0x1BF2518")]
		private void CheckOrientation()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1BF26AC", Offset = "0x1BF26AC", VA = "0x1BF26AC")]
		private void ProjectPolygon()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1BF2A40", Offset = "0x1BF2A40", VA = "0x1BF2A40")]
		private void TessellateMonoRegion(MeshUtils.Face face)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1BF2D70", Offset = "0x1BF2D70", VA = "0x1BF2D70")]
		private void TessellateInterior()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1BF2E00", Offset = "0x1BF2E00", VA = "0x1BF2E00")]
		private void DiscardExterior()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1BF2E9C", Offset = "0x1BF2E9C", VA = "0x1BF2E9C")]
		private void SetWindingNumber(int value, bool keepOnlyBoundary)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1BF2FC4", Offset = "0x1BF2FC4", VA = "0x1BF2FC4")]
		private int GetNeighbourFace(MeshUtils.Edge edge)
		{
			return default(int);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1BF3054", Offset = "0x1BF3054", VA = "0x1BF3054")]
		private void OutputPolymesh(ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1BF36AC", Offset = "0x1BF36AC", VA = "0x1BF36AC")]
		private void OutputContours()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1BF3A2C", Offset = "0x1BF3A2C", VA = "0x1BF3A2C")]
		private float SignedArea(ContourVertex[] vertices)
		{
			return default(float);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1BF3AE0", Offset = "0x1BF3AE0", VA = "0x1BF3AE0")]
		public void AddContour(ContourVertex[] vertices)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1BF3AE8", Offset = "0x1BF3AE8", VA = "0x1BF3AE8")]
		public void AddContour(ContourVertex[] vertices, ContourOrientation forceOrientation)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1BF3D3C", Offset = "0x1BF3D3C", VA = "0x1BF3D3C")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1BF3D5C", Offset = "0x1BF3D5C", VA = "0x1BF3D5C")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize, CombineCallback combineCallback)
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public enum WindingRule
	{
		[Token(Token = "0x40002C5")]
		EvenOdd,
		[Token(Token = "0x40002C6")]
		NonZero,
		[Token(Token = "0x40002C7")]
		Positive,
		[Token(Token = "0x40002C8")]
		Negative,
		[Token(Token = "0x40002C9")]
		AbsGeqTwo
	}
	[Token(Token = "0x20000BE")]
	public enum ElementType
	{
		[Token(Token = "0x40002CB")]
		Polygons,
		[Token(Token = "0x40002CC")]
		ConnectedPolygons,
		[Token(Token = "0x40002CD")]
		BoundaryContours
	}
	[Token(Token = "0x20000BF")]
	public enum ContourOrientation
	{
		[Token(Token = "0x40002CF")]
		Original,
		[Token(Token = "0x40002D0")]
		Clockwise,
		[Token(Token = "0x40002D1")]
		CounterClockwise
	}
	[Token(Token = "0x20000C0")]
	public struct ContourVertex
	{
		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vec3 Position;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public object Data;

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1BEB414", Offset = "0x1BEB414", VA = "0x1BEB414", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000C1")]
	public delegate object CombineCallback(Vec3 position, object[] data, float[] weights);
	[Token(Token = "0x20000C2")]
	public static class LibTessVector3Extension
	{
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1BEDF4C", Offset = "0x1BEDF4C", VA = "0x1BEDF4C")]
		public static Vec3 Vec3(this Vector3 v)
		{
			return default(Vec3);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1BEDF54", Offset = "0x1BEDF54", VA = "0x1BEDF54")]
		public static ContourVertex ContourVertex(this Vector3 v)
		{
			return default(ContourVertex);
		}
	}
	[Token(Token = "0x20000C3")]
	public static class LibTessV3Extension
	{
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1BEDF20", Offset = "0x1BEDF20", VA = "0x1BEDF20")]
		public static Vector3 Vector3(this Vec3 v)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000C4")]
	public static class UnityLibTessUtility
	{
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1D76958", Offset = "0x1D76958", VA = "0x1D76958")]
		public static ContourVertex[] ToContourVertex(Vector3[] v, bool zeroZ = false)
		{
			return null;
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1D76ADC", Offset = "0x1D76ADC", VA = "0x1D76ADC")]
		public static Vector3[] FromContourVertex(ContourVertex[] v)
		{
			return null;
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1D76B6C", Offset = "0x1D76B6C", VA = "0x1D76B6C")]
		public static void SetFromContourVertex(ref Vector3[] v3Array, ref ContourVertex[] cvArray)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1D76D30", Offset = "0x1D76D30", VA = "0x1D76D30")]
		public static void SetToContourVertex(ref ContourVertex[] cvArray, ref Vector3[] v3Array)
		{
		}
	}
}
namespace FluffyUnderware.Curvy.ImportExport
{
	[Token(Token = "0x20000C5")]
	public enum CurvySerializationSpace
	{
		[Token(Token = "0x40002D5")]
		Global,
		[Token(Token = "0x40002D6")]
		Local
	}
	[Serializable]
	[Token(Token = "0x20000C6")]
	public class SerializedCurvySpline
	{
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Name;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 Position;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Rotation;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public CurvyInterpolation Interpolation;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool RestrictTo2D;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool Closed;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool AutoEndTangents;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public CurvyOrientation Orientation;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float AutoHandleDistance;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int CacheDensity;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float MaxPointsPerUnit;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool UsePooling;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public bool UseThreading;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		public bool CheckTransform;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CurvyUpdateMethod UpdateIn;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public SerializedCurvySplineSegment[] ControlPoints;

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1BE6E60", Offset = "0x1BE6E60", VA = "0x1BE6E60")]
		public SerializedCurvySpline()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1BE6F48", Offset = "0x1BE6F48", VA = "0x1BE6F48")]
		public SerializedCurvySpline([NotNull] CurvySpline spline, CurvySerializationSpace space)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1BE7520", Offset = "0x1BE7520", VA = "0x1BE7520")]
		public void WriteIntoSpline([NotNull] CurvySpline deserializedSpline, CurvySerializationSpace space)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C7")]
	public class SerializedCurvySplineSegment
	{
		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 Position;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 Rotation;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool AutoBakeOrientation;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool OrientationAnchor;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public CurvyOrientationSwirl Swirl;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float SwirlTurns;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool AutoHandles;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float AutoHandleDistance;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 HandleOut;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 HandleIn;

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1BE7DC8", Offset = "0x1BE7DC8", VA = "0x1BE7DC8")]
		public SerializedCurvySplineSegment()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1BE733C", Offset = "0x1BE733C", VA = "0x1BE733C")]
		public SerializedCurvySplineSegment([NotNull] CurvySplineSegment segment, CurvySerializationSpace space)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1BE7A28", Offset = "0x1BE7A28", VA = "0x1BE7A28")]
		public void WriteIntoControlPoint([NotNull] CurvySplineSegment controlPoint, CurvySerializationSpace space)
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Controllers
{
	[Token(Token = "0x20000C8")]
	public abstract class ConnectedControlPointsSelector : MonoBehaviour
	{
		[Token(Token = "0x600059D")]
		public abstract CurvySplineSegment SelectConnectedControlPoint(SplineController caller, CurvyConnection connection, CurvySplineSegment currentControlPoint);

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x12C7840", Offset = "0x12C7840", VA = "0x12C7840")]
		protected ConnectedControlPointsSelector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C9")]
	public class ControllerEvent : UnityEventEx<CurvyController>
	{
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x12C7848", Offset = "0x12C7848", VA = "0x12C7848")]
		public ControllerEvent()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class CurvyControllerEventArgs : CurvyEventArgs
	{
		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly CurvyController Controller;

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x12CA4D4", Offset = "0x12CA4D4", VA = "0x12CA4D4")]
		public CurvyControllerEventArgs(MonoBehaviour sender, CurvyController controller)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CB")]
	public class CurvySplineMoveEvent : UnityEventEx<CurvySplineMoveEventArgs>
	{
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x12CA5A4", Offset = "0x12CA5A4", VA = "0x12CA5A4")]
		public CurvySplineMoveEvent()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class CurvySplineMoveEventArgs : CancelEventArgs
	{
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA538", Offset = "0x6FA538")]
		private SplineController <Sender>k__BackingField;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA548", Offset = "0x6FA548")]
		private CurvySpline <Spline>k__BackingField;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA558", Offset = "0x6FA558")]
		private CurvySplineSegment <ControlPoint>k__BackingField;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA568", Offset = "0x6FA568")]
		private bool <WorldUnits>k__BackingField;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA578", Offset = "0x6FA578")]
		private MovementDirection <MovementDirection>k__BackingField;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA588", Offset = "0x6FA588")]
		private float <Delta>k__BackingField;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA598", Offset = "0x6FA598")]
		private float <Position>k__BackingField;

		[Token(Token = "0x170000DD")]
		public SplineController Sender
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x12CA600", Offset = "0x12CA600", VA = "0x12CA600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7038D4", Offset = "0x7038D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x12CA608", Offset = "0x12CA608", VA = "0x12CA608")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7038E4", Offset = "0x7038E4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public CurvySpline Spline
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x12CA610", Offset = "0x12CA610", VA = "0x12CA610")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7038F4", Offset = "0x7038F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x12CA618", Offset = "0x12CA618", VA = "0x12CA618")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703904", Offset = "0x703904")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public CurvySplineSegment ControlPoint
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x12CA620", Offset = "0x12CA620", VA = "0x12CA620")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703914", Offset = "0x703914")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x12CA628", Offset = "0x12CA628", VA = "0x12CA628")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703924", Offset = "0x703924")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public bool WorldUnits
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x12CA630", Offset = "0x12CA630", VA = "0x12CA630")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703934", Offset = "0x703934")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x12CA638", Offset = "0x12CA638", VA = "0x12CA638")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703944", Offset = "0x703944")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public MovementDirection MovementDirection
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x12CA640", Offset = "0x12CA640", VA = "0x12CA640")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703954", Offset = "0x703954")]
			get
			{
				return default(MovementDirection);
			}
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x12CA648", Offset = "0x12CA648", VA = "0x12CA648")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703964", Offset = "0x703964")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public float Delta
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x12CA650", Offset = "0x12CA650", VA = "0x12CA650")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703974", Offset = "0x703974")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x12CA658", Offset = "0x12CA658", VA = "0x12CA658")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703984", Offset = "0x703984")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public float Position
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x12CA660", Offset = "0x12CA660", VA = "0x12CA660")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703994", Offset = "0x703994")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x12CA668", Offset = "0x12CA668", VA = "0x12CA668")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7039A4", Offset = "0x7039A4")]
			private set
			{
			}
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x12CA670", Offset = "0x12CA670", VA = "0x12CA670")]
		public CurvySplineMoveEventArgs(SplineController sender, CurvySpline spline, CurvySplineSegment controlPoint, float position, bool usingWorldUnits, float delta, MovementDirection direction)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x12CA6D0", Offset = "0x12CA6D0", VA = "0x12CA6D0")]
		internal void Set_INTERNAL(SplineController sender, CurvySpline spline, CurvySplineSegment controlPoint, float position, float delta, MovementDirection direction, bool usingWorldUnits)
		{
		}
	}
	[Token(Token = "0x20000CD")]
	[ExecuteInEditMode]
	public abstract class CurvyController : DTVersionedMonoBehaviour, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000171")]
		public enum MoveModeEnum
		{
			[Token(Token = "0x40005CF")]
			Relative,
			[Token(Token = "0x40005D0")]
			AbsolutePrecise
		}

		[Token(Token = "0x2000172")]
		public enum CurvyControllerState
		{
			[Token(Token = "0x40005D2")]
			Stopped,
			[Token(Token = "0x40005D3")]
			Playing,
			[Token(Token = "0x40005D4")]
			Paused
		}

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6FA5A8", Offset = "0x6FA5A8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FA5A8", Offset = "0x6FA5A8")]
		public CurvyUpdateMethod UpdateIn;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6FA650", Offset = "0x6FA650")]
		[SerializeField]
		private CurvyPositionMode m_PositionMode;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6FA6D8", Offset = "0x6FA6D8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6FA6D8", Offset = "0x6FA6D8")]
		protected float m_Position;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6FA780", Offset = "0x6FA780")]
		[SerializeField]
		private MoveModeEnum m_MoveMode;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Positive]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private MovementDirection m_Direction;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CurvyClamping m_Clamping;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6FA85C", Offset = "0x6FA85C")]
		private bool m_PlayAutomatically;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6FA8A4", Offset = "0x6FA8A4")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FA8A4", Offset = "0x6FA8A4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FA8A4", Offset = "0x6FA8A4")]
		[SerializeField]
		private OrientationModeEnum m_OrientationMode;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FAA00", Offset = "0x6FAA00")]
		[SerializeField]
		private bool m_LockRotation;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FAA60", Offset = "0x6FAA60")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FAA60", Offset = "0x6FAA60")]
		[SerializeField]
		private OrientationAxisEnum m_OrientationAxis;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6FAB98", Offset = "0x6FAB98")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FAB98", Offset = "0x6FAB98")]
		[SerializeField]
		private bool m_IgnoreDirection;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x6FACB8", Offset = "0x6FACB8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FACB8", Offset = "0x6FACB8")]
		[SerializeField]
		private float m_DampingDirection;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x6FADC0", Offset = "0x6FADC0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FADC0", Offset = "0x6FADC0")]
		[SerializeField]
		private float m_DampingUp;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6FAEC8", Offset = "0x6FAEC8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FAEC8", Offset = "0x6FAEC8")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6FAEC8", Offset = "0x6FAEC8")]
		[SerializeField]
		private float m_OffsetAngle;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FB068", Offset = "0x6FB068")]
		[SerializeField]
		private float m_OffsetRadius;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FB164", Offset = "0x6FB164")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FB164", Offset = "0x6FB164")]
		[SerializeField]
		private bool m_OffsetCompensation;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6FB29C", Offset = "0x6FB29C")]
		[SerializeField]
		private ControllerEvent onInitialized;

		[Token(Token = "0x400030B")]
		protected const string ControllerNotReadyMessage = "The controller is not yet ready";

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FB308", Offset = "0x6FB308")]
		private bool <isInitialized>k__BackingField;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private CurvyControllerState state;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 directionDampingVelocity;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 upDampingVelocity;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float prePlayPosition;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Quaternion lockedRotation;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private MovementDirection prePlayDirection;

		[Token(Token = "0x170000E4")]
		public ControllerEvent OnInitialized
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x12C78A4", Offset = "0x12C78A4", VA = "0x12C78A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		public CurvyPositionMode PositionMode
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x12C78AC", Offset = "0x12C78AC", VA = "0x12C78AC")]
			get
			{
				return default(CurvyPositionMode);
			}
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x12C78B4", Offset = "0x12C78B4", VA = "0x12C78B4")]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public MoveModeEnum MoveMode
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x12C78BC", Offset = "0x12C78BC", VA = "0x12C78BC")]
			get
			{
				return default(MoveModeEnum);
			}
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x12C78C4", Offset = "0x12C78C4", VA = "0x12C78C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public bool PlayAutomatically
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x12C78D4", Offset = "0x12C78D4", VA = "0x12C78D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x12C78DC", Offset = "0x12C78DC", VA = "0x12C78DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public CurvyClamping Clamping
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x12C78F8", Offset = "0x12C78F8", VA = "0x12C78F8")]
			get
			{
				return default(CurvyClamping);
			}
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x12C7900", Offset = "0x12C7900", VA = "0x12C7900")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public OrientationModeEnum OrientationMode
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x12C7910", Offset = "0x12C7910", VA = "0x12C7910")]
			get
			{
				return default(OrientationModeEnum);
			}
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x12C7918", Offset = "0x12C7918", VA = "0x12C7918")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public bool LockRotation
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x12C7928", Offset = "0x12C7928", VA = "0x12C7928")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x12C7930", Offset = "0x12C7930", VA = "0x12C7930")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public OrientationAxisEnum OrientationAxis
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x12C79B8", Offset = "0x12C79B8", VA = "0x12C79B8")]
			get
			{
				return default(OrientationAxisEnum);
			}
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x12C79C0", Offset = "0x12C79C0", VA = "0x12C79C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public float DirectionDampingTime
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x12C79D0", Offset = "0x12C79D0", VA = "0x12C79D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x12C79D8", Offset = "0x12C79D8", VA = "0x12C79D8")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public float UpDampingTime
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x12C7A70", Offset = "0x12C7A70", VA = "0x12C7A70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x12C7A78", Offset = "0x12C7A78", VA = "0x12C7A78")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public bool IgnoreDirection
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x12C7B10", Offset = "0x12C7B10", VA = "0x12C7B10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x12C7B18", Offset = "0x12C7B18", VA = "0x12C7B18")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public float OffsetAngle
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x12C7B34", Offset = "0x12C7B34", VA = "0x12C7B34")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x12C7B3C", Offset = "0x12C7B3C", VA = "0x12C7B3C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public float OffsetRadius
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x12C7B54", Offset = "0x12C7B54", VA = "0x12C7B54")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x12C7B5C", Offset = "0x12C7B5C", VA = "0x12C7B5C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public bool OffsetCompensation
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x12C7B74", Offset = "0x12C7B74", VA = "0x12C7B74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x12C7B7C", Offset = "0x12C7B7C", VA = "0x12C7B7C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public float Speed
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x12C7B84", Offset = "0x12C7B84", VA = "0x12C7B84")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x12C7B8C", Offset = "0x12C7B8C", VA = "0x12C7B8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public float RelativePosition
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x12C7BA8", Offset = "0x12C7BA8", VA = "0x12C7BA8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x12C7DC4", Offset = "0x12C7DC4", VA = "0x12C7DC4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public float AbsolutePosition
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x12C7EDC", Offset = "0x12C7EDC", VA = "0x12C7EDC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x12C8034", Offset = "0x12C8034", VA = "0x12C8034")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public float Position
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x12C8124", Offset = "0x12C8124", VA = "0x12C8124")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x12C81CC", Offset = "0x12C81CC", VA = "0x12C81CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public MovementDirection MovementDirection
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x12C8280", Offset = "0x12C8280", VA = "0x12C8280")]
			get
			{
				return default(MovementDirection);
			}
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x12C8288", Offset = "0x12C8288", VA = "0x12C8288")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public CurvyControllerState PlayState
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x12C8290", Offset = "0x12C8290", VA = "0x12C8290")]
			get
			{
				return default(CurvyControllerState);
			}
		}

		[Token(Token = "0x170000F8")]
		public abstract bool IsReady
		{
			[Token(Token = "0x60005D8")]
			get;
		}

		[Token(Token = "0x170000F9")]
		protected bool isInitialized
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x12C8298", Offset = "0x12C8298", VA = "0x12C8298")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7039B4", Offset = "0x7039B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x12C82A0", Offset = "0x12C82A0", VA = "0x12C82A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7039C4", Offset = "0x7039C4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public virtual Transform Transform
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x12C8600", Offset = "0x12C8600", VA = "0x12C8600", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FB")]
		protected virtual bool ShowOrientationSection
		{
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x12C9A94", Offset = "0x12C9A94", VA = "0x12C9A94", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FC")]
		protected virtual bool ShowOffsetSection
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x12C9A9C", Offset = "0x12C9A9C", VA = "0x12C9A9C", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FD")]
		public abstract float Length
		{
			[Token(Token = "0x60005F0")]
			get;
		}

		[Token(Token = "0x170000FE")]
		private float TimeSinceLastUpdate
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x12C843C", Offset = "0x12C843C", VA = "0x12C843C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000FF")]
		private float maxPosition
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x12CA31C", Offset = "0x12CA31C", VA = "0x12CA31C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x12C82A8", Offset = "0x12C82A8", VA = "0x12C82A8", Slot = "8")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x12C8310", Offset = "0x12C8310", VA = "0x12C8310", Slot = "9")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x12C83F0", Offset = "0x12C83F0", VA = "0x12C83F0", Slot = "10")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x12C840C", Offset = "0x12C840C", VA = "0x12C840C", Slot = "11")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x12C84F4", Offset = "0x12C84F4", VA = "0x12C84F4", Slot = "12")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x12C853C", Offset = "0x12C853C", VA = "0x12C853C", Slot = "13")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x12C856C", Offset = "0x12C856C", VA = "0x12C856C", Slot = "14")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x12C8608", Offset = "0x12C8608", VA = "0x12C8608", Slot = "16")]
		protected virtual void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x12C8ED4", Offset = "0x12C8ED4", VA = "0x12C8ED4", Slot = "17")]
		protected virtual void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x12C95BC", Offset = "0x12C95BC", VA = "0x12C95BC")]
		private void GetOrientationNoneUpAndForward(out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x12C98F4", Offset = "0x12C98F4", VA = "0x12C98F4", Slot = "18")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x12C9A30", Offset = "0x12C9A30", VA = "0x12C9A30", Slot = "19")]
		protected virtual void Deinitialize()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x12C9A5C", Offset = "0x12C9A5C", VA = "0x12C9A5C", Slot = "20")]
		protected virtual void BindEvents()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x12C9A60", Offset = "0x12C9A60", VA = "0x12C9A60", Slot = "21")]
		protected virtual void UnbindEvents()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x12C9A64", Offset = "0x12C9A64", VA = "0x12C9A64", Slot = "22")]
		protected virtual void SavePrePlayState()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x12C9A78", Offset = "0x12C9A78", VA = "0x12C9A78", Slot = "23")]
		protected virtual void RestorePrePlayState()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x12C9A8C", Offset = "0x12C9A8C", VA = "0x12C9A8C", Slot = "24")]
		protected virtual void UserAfterInit()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x12C9A90", Offset = "0x12C9A90", VA = "0x12C9A90", Slot = "25")]
		protected virtual void UserAfterUpdate()
		{
		}

		[Token(Token = "0x60005F1")]
		protected abstract void Advance(float speed, float deltaTime);

		[Token(Token = "0x60005F2")]
		protected abstract void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime);

		[Token(Token = "0x60005F3")]
		protected abstract float AbsoluteToRelative(float worldUnitDistance);

		[Token(Token = "0x60005F4")]
		protected abstract float RelativeToAbsolute(float relativeDistance);

		[Token(Token = "0x60005F5")]
		protected abstract Vector3 GetInterpolatedSourcePosition(float tf);

		[Token(Token = "0x60005F6")]
		protected abstract void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up);

		[Token(Token = "0x60005F7")]
		protected abstract Vector3 GetOrientation(float tf);

		[Token(Token = "0x60005F8")]
		protected abstract Vector3 GetTangent(float tf);

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x12C83B8", Offset = "0x12C83B8", VA = "0x12C83B8")]
		public void Play()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x12C9AA4", Offset = "0x12C9AA4", VA = "0x12C9AA4")]
		public void Stop()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x12C9ADC", Offset = "0x12C9ADC", VA = "0x12C9ADC")]
		public void Pause()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x12C9AF0", Offset = "0x12C9AF0", VA = "0x12C9AF0")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x12C8444", Offset = "0x12C8444", VA = "0x12C8444")]
		public void ApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x12C9AF8", Offset = "0x12C9AF8", VA = "0x12C9AF8")]
		public void TeleportTo(float newPosition)
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x12C9BB8", Offset = "0x12C9BB8", VA = "0x12C9BB8")]
		public void TeleportBy(float distance, MovementDirection direction)
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x12C9C84", Offset = "0x12C9C84", VA = "0x12C9C84")]
		public void SetFromString(string fieldAndValue)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x12C9798", Offset = "0x12C9798", VA = "0x12C9798")]
		private static Vector3 ApplyOffset(Vector3 pos, Vector3 tan, Vector3 up, float angle, float radius)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x12C7D00", Offset = "0x12C7D00", VA = "0x12C7D00")]
		protected static float GetClampedPosition(float position, CurvyPositionMode positionMode, CurvyClamping clampingMode, float length)
		{
			return default(float);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x12C8B88", Offset = "0x12C8B88", VA = "0x12C8B88")]
		private float ComputeOffsetCompensatedSpeed(float deltaTime)
		{
			return default(float);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x12CA3F8", Offset = "0x12CA3F8", VA = "0x12CA3F8", Slot = "37")]
		public virtual void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x12CA4AC", Offset = "0x12CA4AC", VA = "0x12CA4AC", Slot = "5")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x12CA4B0", Offset = "0x12CA4B0", VA = "0x12CA4B0")]
		protected CurvyController()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public enum MovementDirection
	{
		[Token(Token = "0x4000314")]
		Forward,
		[Token(Token = "0x4000315")]
		Backward
	}
	[Token(Token = "0x20000CF")]
	public static class MovementDirectionMethods
	{
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x12CA738", Offset = "0x12CA738", VA = "0x12CA738")]
		public static MovementDirection FromInt(int value)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x12CA740", Offset = "0x12CA740", VA = "0x12CA740")]
		public static MovementDirection GetOpposite(this MovementDirection value)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x12CA7D8", Offset = "0x12CA7D8", VA = "0x12CA7D8")]
		public static int ToInt(this MovementDirection direction)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6F5BC8", Offset = "0x6F5BC8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F5BC8", Offset = "0x6F5BC8")]
	public class PathController : CurvyController
	{
		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6FB318", Offset = "0x6FB318")]
		[SerializeField]
		[AttributeAttribute(Name = "CGDataReferenceSelectorAttribute", RVA = "0x6FB318", Offset = "0x6FB318")]
		private CGDataReference m_Path;

		[Token(Token = "0x17000100")]
		public CGDataReference Path
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x12CA870", Offset = "0x12CA870", VA = "0x12CA870")]
			get
			{
				return null;
			}
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x12CA878", Offset = "0x12CA878", VA = "0x12CA878")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public CGPath PathData
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x12CA880", Offset = "0x12CA880", VA = "0x12CA880")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000102")]
		public override float Length
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x12CA91C", Offset = "0x12CA91C", VA = "0x12CA91C", Slot = "28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000103")]
		public override bool IsReady
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x12CA964", Offset = "0x12CA964", VA = "0x12CA964", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x12CA9B4", Offset = "0x12CA9B4", VA = "0x12CA9B4", Slot = "32")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x12CAA04", Offset = "0x12CAA04", VA = "0x12CAA04", Slot = "31")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x12CAA54", Offset = "0x12CAA54", VA = "0x12CAA54", Slot = "33")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x12CAB0C", Offset = "0x12CAB0C", VA = "0x12CAB0C", Slot = "34")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x12CAC64", Offset = "0x12CAC64", VA = "0x12CAC64", Slot = "36")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x12CAD1C", Offset = "0x12CAD1C", VA = "0x12CAD1C", Slot = "35")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x12CADD4", Offset = "0x12CADD4", VA = "0x12CADD4", Slot = "29")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x12CAE40", Offset = "0x12CAE40", VA = "0x12CAE40", Slot = "30")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x12CAF94", Offset = "0x12CAF94", VA = "0x12CAF94")]
		public PathController()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public enum SplineControllerConnectionBehavior
	{
		[Token(Token = "0x4000318")]
		CurrentSpline,
		[Token(Token = "0x4000319")]
		FollowUpSpline,
		[Token(Token = "0x400031A")]
		RandomSpline,
		[Token(Token = "0x400031B")]
		FollowUpOtherwiseRandom,
		[Token(Token = "0x400031C")]
		Custom
	}
	[Token(Token = "0x20000D2")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6F5C2C", Offset = "0x6F5C2C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F5C2C", Offset = "0x6F5C2C")]
	public class SplineController : CurvyController
	{
		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6FB3FC", Offset = "0x6FB3FC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FB3FC", Offset = "0x6FB3FC")]
		[SerializeField]
		protected CurvySpline m_Spline;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6FB4B4", Offset = "0x6FB4B4")]
		private bool m_UseCache;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6FB4FC", Offset = "0x6FB4FC")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FB4FC", Offset = "0x6FB4FC")]
		private SplineControllerConnectionBehavior connectionBehavior;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FB5C8", Offset = "0x6FB5C8")]
		private bool allowDirectionChange;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FB628", Offset = "0x6FB628")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FB628", Offset = "0x6FB628")]
		private bool rejectCurrentSpline;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FB728", Offset = "0x6FB728")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FB728", Offset = "0x6FB728")]
		private bool rejectTooDivergentSplines;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FB828", Offset = "0x6FB828")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6FB828", Offset = "0x6FB828")]
		private float maxAllowedDivergenceAngle;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FB8A4", Offset = "0x6FB8A4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FB8A4", Offset = "0x6FB8A4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FB8A4", Offset = "0x6FB8A4")]
		private ConnectedControlPointsSelector connectionCustomSelector;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6FB9F4", Offset = "0x6FB9F4")]
		[SerializeField]
		private CurvySplineMoveEvent m_OnControlPointReached;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private CurvySplineMoveEvent m_OnEndReached;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private CurvySplineMoveEvent m_OnSwitch;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FBA98", Offset = "0x6FBA98")]
		private bool <IsSwitching>k__BackingField;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private CurvySpline prePlaySpline;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float switchStartTime;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float switchDuration;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private CurvySpline switchTarget;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float tfOnSwitchTarget;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private MovementDirection directionOnSwitchTarget;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly CurvySplineMoveEventArgs preAllocatedEventArgs;

		[Token(Token = "0x17000104")]
		public virtual CurvySpline Spline
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x12CB12C", Offset = "0x12CB12C", VA = "0x12CB12C", Slot = "38")]
			get
			{
				return null;
			}
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x12CB134", Offset = "0x12CB134", VA = "0x12CB134", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public bool UseCache
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x12CB13C", Offset = "0x12CB13C", VA = "0x12CB13C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x12CB144", Offset = "0x12CB144", VA = "0x12CB144")]
			set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public SplineControllerConnectionBehavior ConnectionBehavior
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x12CB160", Offset = "0x12CB160", VA = "0x12CB160")]
			get
			{
				return default(SplineControllerConnectionBehavior);
			}
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x12CB168", Offset = "0x12CB168", VA = "0x12CB168")]
			set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public ConnectedControlPointsSelector ConnectionCustomSelector
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x12CB170", Offset = "0x12CB170", VA = "0x12CB170")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x12CB178", Offset = "0x12CB178", VA = "0x12CB178")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public bool AllowDirectionChange
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x12CB180", Offset = "0x12CB180", VA = "0x12CB180")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x12CB188", Offset = "0x12CB188", VA = "0x12CB188")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public bool RejectCurrentSpline
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x12CB190", Offset = "0x12CB190", VA = "0x12CB190")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x12CB198", Offset = "0x12CB198", VA = "0x12CB198")]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public bool RejectTooDivergentSplines
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x12CB1A0", Offset = "0x12CB1A0", VA = "0x12CB1A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x12CB1A8", Offset = "0x12CB1A8", VA = "0x12CB1A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public float MaxAllowedDivergenceAngle
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x12CB1B0", Offset = "0x12CB1B0", VA = "0x12CB1B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x12CB1B8", Offset = "0x12CB1B8", VA = "0x12CB1B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public CurvySplineMoveEvent OnControlPointReached
		{
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x12CB1C0", Offset = "0x12CB1C0", VA = "0x12CB1C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x12CB1C8", Offset = "0x12CB1C8", VA = "0x12CB1C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public CurvySplineMoveEvent OnEndReached
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x12CB1D0", Offset = "0x12CB1D0", VA = "0x12CB1D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x12CB1D8", Offset = "0x12CB1D8", VA = "0x12CB1D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public CurvySplineMoveEvent OnSwitch
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x12CB1E0", Offset = "0x12CB1E0", VA = "0x12CB1E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x12CB1E8", Offset = "0x12CB1E8", VA = "0x12CB1E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		public bool IsSwitching
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x12CB1F0", Offset = "0x12CB1F0", VA = "0x12CB1F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7039F4", Offset = "0x7039F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x12CB1F8", Offset = "0x12CB1F8", VA = "0x12CB1F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703A04", Offset = "0x703A04")]
			private set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public override float Length
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x12CB200", Offset = "0x12CB200", VA = "0x12CB200", Slot = "28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000111")]
		private float SwitchProgress
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x12CB410", Offset = "0x12CB410", VA = "0x12CB410")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000112")]
		public override bool IsReady
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x12CB794", Offset = "0x12CB794", VA = "0x12CB794", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000113")]
		private bool ShowRandomConnectionOptions
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x12CF49C", Offset = "0x12CF49C", VA = "0x12CF49C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x12CB030", Offset = "0x12CB030", VA = "0x12CB030")]
		public SplineController()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x12CB4CC", Offset = "0x12CB4CC", VA = "0x12CB4CC", Slot = "40")]
		public virtual void SwitchTo(CurvySpline destinationSpline, float destinationTf, float duration)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x12CB58C", Offset = "0x12CB58C", VA = "0x12CB58C")]
		public void FinishCurrentSwitch()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x12CB5D8", Offset = "0x12CB5D8", VA = "0x12CB5D8")]
		public void CancelCurrentSwitch()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x12CB5EC", Offset = "0x12CB5EC", VA = "0x12CB5EC")]
		public static float GetAngleBetweenConnectedSplines(CurvySplineSegment before, MovementDirection movementMode, CurvySplineSegment after, bool allowMovementModeChange)
		{
			return default(float);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x12CB86C", Offset = "0x12CB86C", VA = "0x12CB86C", Slot = "22")]
		protected override void SavePrePlayState()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x12CB8B0", Offset = "0x12CB8B0", VA = "0x12CB8B0", Slot = "23")]
		protected override void RestorePrePlayState()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x12CB8E8", Offset = "0x12CB8E8", VA = "0x12CB8E8", Slot = "32")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x12CBA7C", Offset = "0x12CBA7C", VA = "0x12CBA7C", Slot = "31")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x12CBC0C", Offset = "0x12CBC0C", VA = "0x12CBC0C", Slot = "33")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x12CBE24", Offset = "0x12CBE24", VA = "0x12CBE24", Slot = "34")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x12CC35C", Offset = "0x12CC35C", VA = "0x12CC35C", Slot = "36")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x12CC664", Offset = "0x12CC664", VA = "0x12CC664", Slot = "35")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x12CC718", Offset = "0x12CC718", VA = "0x12CC718", Slot = "29")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x12CD7A0", Offset = "0x12CD7A0", VA = "0x12CD7A0", Slot = "30")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x12CD5E4", Offset = "0x12CD5E4", VA = "0x12CD5E4")]
		private void SimulateAdvanceOnSpline(ref float tf, ref MovementDirection curyDirection, CurvySpline spline, float distance)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x12CD83C", Offset = "0x12CD83C", VA = "0x12CD83C", Slot = "16")]
		protected override void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x12CD990", Offset = "0x12CD990", VA = "0x12CD990", Slot = "17")]
		protected override void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x12CDD78", Offset = "0x12CDD78", VA = "0x12CDD78")]
		private static float MovementCompatibleGetPosition(SplineController controller, CurvyPositionMode positionMode, out CurvySplineSegment controlPoint, out bool isOnControlPoint)
		{
			return default(float);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x12CE864", Offset = "0x12CE864", VA = "0x12CE864")]
		private static void MovementCompatibleSetPosition(SplineController controller, CurvyPositionMode positionMode, float position)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x12CC918", Offset = "0x12CC918", VA = "0x12CC918")]
		private void EventAwareMove(float distance)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x12CEA28", Offset = "0x12CEA28", VA = "0x12CEA28")]
		private CurvySplineSegment GetCurrentControlPoint(out bool isOnControlPoint, out float position, CurvyPositionMode positionMode)
		{
			return null;
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x12CEC98", Offset = "0x12CEC98", VA = "0x12CEC98")]
		private void HandleReachingNewControlPoint(CurvySplineSegment newControlPoint, CurvyPositionMode positionMode, float currentDelta, ref bool cancelMovement)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x12CF11C", Offset = "0x12CF11C", VA = "0x12CF11C")]
		private CurvySplineSegment HandleRandomConnectionBehavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection, ReadOnlyCollection<CurvySplineSegment> connectedControlPoints)
		{
			return null;
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x12CB738", Offset = "0x12CB738", VA = "0x12CB738")]
		private static MovementDirection GetPostConnectionDirection(CurvySplineSegment connectedControlPoint, MovementDirection currentDirection, bool directionChangeAllowed)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x12CF018", Offset = "0x12CF018", VA = "0x12CF018")]
		private CurvySplineSegment HandleFolloUpConnectionBahavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection)
		{
			return null;
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x12CF3D8", Offset = "0x12CF3D8", VA = "0x12CF3D8")]
		private static MovementDirection HeadingToDirection(ConnectionHeadingEnum heading, CurvySplineSegment controlPoint, MovementDirection currentDirection)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x12CEB5C", Offset = "0x12CEB5C", VA = "0x12CEB5C")]
		private static float GetControlPointPosition(CurvySplineSegment controlPoint, CurvyPositionMode positionMode, MovementDirection movementDirection)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000D3")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F5C90", Offset = "0x6F5C90")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6F5C90", Offset = "0x6F5C90")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F5C90", Offset = "0x6F5C90")]
	public class UITextSplineController : SplineController, IMeshModifier
	{
		[Token(Token = "0x2000173")]
		protected interface IGlyph
		{
			[Token(Token = "0x1700028F")]
			Vector3 Center
			{
				[Token(Token = "0x6000B40")]
				get;
			}

			[Token(Token = "0x6000B41")]
			void Transpose(Vector3 v);

			[Token(Token = "0x6000B42")]
			void Rotate(Quaternion rotation);
		}

		[Token(Token = "0x2000174")]
		protected class GlyphQuad : IGlyph
		{
			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public UIVertex[] V;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Rect Rect;

			[Token(Token = "0x17000290")]
			public Vector3 Center
			{
				[Token(Token = "0x6000B43")]
				[Address(RVA = "0x12D1528", Offset = "0x12D1528", VA = "0x12D1528", Slot = "4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x12D15C4", Offset = "0x12D15C4", VA = "0x12D15C4")]
			public void Load(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x12D0800", Offset = "0x12D0800", VA = "0x12D0800")]
			public void LoadTris(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x6000B46")]
			[Address(RVA = "0x12D1818", Offset = "0x12D1818", VA = "0x12D1818")]
			public void calcRect()
			{
			}

			[Token(Token = "0x6000B47")]
			[Address(RVA = "0x12D1984", Offset = "0x12D1984", VA = "0x12D1984")]
			public void Save(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x6000B48")]
			[Address(RVA = "0x12D0A54", Offset = "0x12D0A54", VA = "0x12D0A54")]
			public void Save(VertexHelper vh)
			{
			}

			[Token(Token = "0x6000B49")]
			[Address(RVA = "0x12D1BE4", Offset = "0x12D1BE4", VA = "0x12D1BE4", Slot = "5")]
			public void Transpose(Vector3 v)
			{
			}

			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0x12D1CF4", Offset = "0x12D1CF4", VA = "0x12D1CF4", Slot = "6")]
			public void Rotate(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000B4B")]
			[Address(RVA = "0x12D0788", Offset = "0x12D0788", VA = "0x12D0788")]
			public GlyphQuad()
			{
			}
		}

		[Token(Token = "0x2000175")]
		protected class GlyphPlain : IGlyph
		{
			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3[] V;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Rect Rect;

			[Token(Token = "0x17000291")]
			public Vector3 Center
			{
				[Token(Token = "0x6000B4C")]
				[Address(RVA = "0x12D1124", Offset = "0x12D1124", VA = "0x12D1124", Slot = "4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000B4D")]
			[Address(RVA = "0x12CF968", Offset = "0x12CF968", VA = "0x12CF968")]
			public void Load(ref Vector3[] verts, int index)
			{
			}

			[Token(Token = "0x6000B4E")]
			[Address(RVA = "0x12D11C0", Offset = "0x12D11C0", VA = "0x12D11C0")]
			public void calcRect()
			{
			}

			[Token(Token = "0x6000B4F")]
			[Address(RVA = "0x12D03A4", Offset = "0x12D03A4", VA = "0x12D03A4")]
			public void Save(ref Vector3[] verts, int index)
			{
			}

			[Token(Token = "0x6000B50")]
			[Address(RVA = "0x12D132C", Offset = "0x12D132C", VA = "0x12D132C", Slot = "5")]
			public void Transpose(Vector3 v)
			{
			}

			[Token(Token = "0x6000B51")]
			[Address(RVA = "0x12D143C", Offset = "0x12D143C", VA = "0x12D143C", Slot = "6")]
			public void Rotate(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000B52")]
			[Address(RVA = "0x12CF8F0", Offset = "0x12CF8F0", VA = "0x12CF8F0")]
			public GlyphPlain()
			{
			}
		}

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6FBAA8", Offset = "0x6FBAA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6FBAA8", Offset = "0x6FBAA8")]
		[SerializeField]
		private bool staticOrientation;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Graphic m_Graphic;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private RectTransform mRect;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Text mText;

		[Token(Token = "0x17000114")]
		public bool StaticOrientation
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x12CF4B4", Offset = "0x12CF4B4", VA = "0x12CF4B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x12CF4BC", Offset = "0x12CF4BC", VA = "0x12CF4BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000115")]
		protected override bool ShowOrientationSection
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x12CF4C4", Offset = "0x12CF4C4", VA = "0x12CF4C4", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000116")]
		protected override bool ShowOffsetSection
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x12CF4CC", Offset = "0x12CF4CC", VA = "0x12CF4CC", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000117")]
		protected Text Text
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x12CF4D4", Offset = "0x12CF4D4", VA = "0x12CF4D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000118")]
		protected RectTransform Rect
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x12CF590", Offset = "0x12CF590", VA = "0x12CF590")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000119")]
		protected Graphic graphic
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x12CF64C", Offset = "0x12CF64C", VA = "0x12CF64C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011A")]
		public override CurvySpline Spline
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x12D0C2C", Offset = "0x12D0C2C", VA = "0x12D0C2C", Slot = "38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x12D0C34", Offset = "0x12D0C34", VA = "0x12D0C34", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x12CF708", Offset = "0x12CF708", VA = "0x12CF708", Slot = "16")]
		protected override void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x12CF748", Offset = "0x12CF748", VA = "0x12CF748", Slot = "41")]
		public void ModifyMesh(Mesh verts)
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x12D0594", Offset = "0x12D0594", VA = "0x12D0594", Slot = "42")]
		public void ModifyMesh(VertexHelper vertexHelper)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x12CFB44", Offset = "0x12CFB44", VA = "0x12CFB44")]
		private void UpdateGlyph(IGlyph glyph)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x12D0A84", Offset = "0x12D0A84", VA = "0x12D0A84", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x12D0B4C", Offset = "0x12D0B4C", VA = "0x12D0B4C", Slot = "10")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x12D0F70", Offset = "0x12D0F70", VA = "0x12D0F70", Slot = "20")]
		protected override void BindEvents()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x12D0F74", Offset = "0x12D0F74", VA = "0x12D0F74", Slot = "21")]
		protected override void UnbindEvents()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x12D0E34", Offset = "0x12D0E34", VA = "0x12D0E34")]
		private void BindSplineRelatedEvents()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x12D0D00", Offset = "0x12D0D00", VA = "0x12D0D00")]
		private void UnbindSplineRelatedEvents()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x12D0F78", Offset = "0x12D0F78", VA = "0x12D0F78")]
		private void OnSplineRefreshed(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x12D1120", Offset = "0x12D1120", VA = "0x12D1120")]
		public UITextSplineController()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6F5D50", Offset = "0x6F5D50")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F5D50", Offset = "0x6F5D50")]
	public class VolumeController : CurvyController
	{
		[Token(Token = "0x4000334")]
		private const float CrossPositionRangeMin = -0.5f;

		[Token(Token = "0x4000335")]
		private const float CrossPositionRangeMax = 0.5f;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6FBB34", Offset = "0x6FBB34")]
		[AttributeAttribute(Name = "CGDataReferenceSelectorAttribute", RVA = "0x6FBB34", Offset = "0x6FBB34")]
		[SerializeField]
		private CGDataReference m_Volume;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6FBC18", Offset = "0x6FBC18")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_CrossRange;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6FBCEC", Offset = "0x6FBCEC")]
		[SerializeField]
		private float crossRelativePosition;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private CurvyClamping m_CrossClamping;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6FBD90", Offset = "0x6FBD90")]
		private float m_CrossInitialPosition;

		[Token(Token = "0x1700011B")]
		public CGDataReference Volume
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x12D1DF4", Offset = "0x12D1DF4", VA = "0x12D1DF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x12D1DFC", Offset = "0x12D1DFC", VA = "0x12D1DFC")]
			set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public CGVolume VolumeData
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x12D1E04", Offset = "0x12D1E04", VA = "0x12D1E04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011D")]
		public float CrossFrom
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x12D1EA0", Offset = "0x12D1EA0", VA = "0x12D1EA0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x12D1EA8", Offset = "0x12D1EA8", VA = "0x12D1EA8")]
			set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public float CrossTo
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x12D1F34", Offset = "0x12D1F34", VA = "0x12D1F34")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x12D1F3C", Offset = "0x12D1F3C", VA = "0x12D1F3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700011F")]
		public float CrossLength
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x12D1FD4", Offset = "0x12D1FD4", VA = "0x12D1FD4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000120")]
		public CurvyClamping CrossClamping
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x12D1FE0", Offset = "0x12D1FE0", VA = "0x12D1FE0")]
			get
			{
				return default(CurvyClamping);
			}
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x12D1FE8", Offset = "0x12D1FE8", VA = "0x12D1FE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000121")]
		public float CrossRelativePosition
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x12D1FF0", Offset = "0x12D1FF0", VA = "0x12D1FF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x12D2058", Offset = "0x12D2058", VA = "0x12D2058")]
			set
			{
			}
		}

		[Token(Token = "0x17000122")]
		public override float Length
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x12D2094", Offset = "0x12D2094", VA = "0x12D2094", Slot = "28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000123")]
		public override bool IsReady
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x12D21CC", Offset = "0x12D21CC", VA = "0x12D21CC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000124")]
		private RegionOptions<float> CrossRangeOptions
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x12D288C", Offset = "0x12D288C", VA = "0x12D288C")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x17000125")]
		private float MinCrossRelativePosition
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x12D28F0", Offset = "0x12D28F0", VA = "0x12D28F0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000126")]
		private float MaxCrossRelativePosition
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x12D28F8", Offset = "0x12D28F8", VA = "0x12D28F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x12D20DC", Offset = "0x12D20DC", VA = "0x12D20DC")]
		public float CrossRelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x12D2154", Offset = "0x12D2154", VA = "0x12D2154")]
		public float CrossAbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x12D221C", Offset = "0x12D221C", VA = "0x12D221C", Slot = "32")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x12D226C", Offset = "0x12D226C", VA = "0x12D226C", Slot = "31")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x12D22BC", Offset = "0x12D22BC", VA = "0x12D22BC", Slot = "33")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x12D2398", Offset = "0x12D2398", VA = "0x12D2398", Slot = "34")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x12D2514", Offset = "0x12D2514", VA = "0x12D2514", Slot = "36")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x12D25F0", Offset = "0x12D25F0", VA = "0x12D25F0", Slot = "35")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x12D26CC", Offset = "0x12D26CC", VA = "0x12D26CC", Slot = "29")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x12D2738", Offset = "0x12D2738", VA = "0x12D2738", Slot = "30")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x12D2024", Offset = "0x12D2024", VA = "0x12D2024")]
		private float GetClampedCrossPosition(float position)
		{
			return default(float);
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x12D2900", Offset = "0x12D2900", VA = "0x12D2900", Slot = "37")]
		public override void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x12D2960", Offset = "0x12D2960", VA = "0x12D2960")]
		public VolumeController()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Components
{
	[Token(Token = "0x20000D5")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F5DB4", Offset = "0x6F5DB4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6F5DB4", Offset = "0x6F5DB4")]
	public class CurvyGLRenderer : MonoBehaviour
	{
		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[ArrayEx]
		public List<GLSlotData> Splines;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Material lineMaterial;

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x12C5D30", Offset = "0x12C5D30", VA = "0x12C5D30")]
		private void CreateLineMaterial()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x12C5E68", Offset = "0x12C5E68", VA = "0x12C5E68")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x12C6094", Offset = "0x12C6094", VA = "0x12C6094")]
		private void sanitize()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x12C65AC", Offset = "0x12C65AC", VA = "0x12C65AC")]
		private void OnSplineRefresh(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x12C677C", Offset = "0x12C677C", VA = "0x12C677C")]
		private GLSlotData getSlot(CurvySpline spline)
		{
			return null;
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x12C6934", Offset = "0x12C6934", VA = "0x12C6934")]
		public void Add(CurvySpline spline)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x12C6AFC", Offset = "0x12C6AFC", VA = "0x12C6AFC")]
		public void Remove(CurvySpline spline)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x12C6C34", Offset = "0x12C6C34", VA = "0x12C6C34")]
		public CurvyGLRenderer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D6")]
	public class GLSlotData
	{
		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		public CurvySpline Spline;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Color LineColor;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public List<Vector3[]> VertexData;

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x12C61F4", Offset = "0x12C61F4", VA = "0x12C61F4")]
		public void GetVertexData()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x12C6378", Offset = "0x12C6378", VA = "0x12C6378")]
		public void Render(Material mat)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x12C6A28", Offset = "0x12C6A28", VA = "0x12C6A28")]
		public GLSlotData()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6F5E14", Offset = "0x6F5E14")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F5E14", Offset = "0x6F5E14")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F5E14", Offset = "0x6F5E14")]
	public class CurvyLineRenderer : MonoBehaviour
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public CurvySpline m_Spline;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private LineRenderer mRenderer;

		[Token(Token = "0x17000127")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x12C6CC4", Offset = "0x12C6CC4", VA = "0x12C6CC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x12C6CCC", Offset = "0x12C6CCC", VA = "0x12C6CCC")]
			set
			{
			}
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x12C7288", Offset = "0x12C7288", VA = "0x12C7288")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x12C736C", Offset = "0x12C736C", VA = "0x12C736C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x12C73E0", Offset = "0x12C73E0", VA = "0x12C73E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x12C73E4", Offset = "0x12C73E4", VA = "0x12C73E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x12C73E8", Offset = "0x12C73E8", VA = "0x12C73E8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x12C73EC", Offset = "0x12C73EC", VA = "0x12C73EC")]
		private void EnforceWorldSpaceUsage()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x12C7104", Offset = "0x12C7104", VA = "0x12C7104")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x12C76A0", Offset = "0x12C76A0", VA = "0x12C76A0")]
		private void OnSplineRefresh(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x12C76A4", Offset = "0x12C76A4", VA = "0x12C76A4")]
		private void OnSplineCoordinatesChanged(CurvySpline spline)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x12C6F48", Offset = "0x12C6F48", VA = "0x12C6F48")]
		private void BindEvents()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x12C6D8C", Offset = "0x12C6D8C", VA = "0x12C6D8C")]
		private void UnbindEvents()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x12C76A8", Offset = "0x12C76A8", VA = "0x12C76A8")]
		public CurvyLineRenderer()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Shapes
{
	[Token(Token = "0x20000D8")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x6F5EE4", Offset = "0x6F5EE4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F5EE4", Offset = "0x6F5EE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6F5EE4", Offset = "0x6F5EE4")]
	public class CSCircle : CurvyShape2D
	{
		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Positive]
		[SerializeField]
		private int m_Count;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_Radius;

		[Token(Token = "0x17000128")]
		public int Count
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x1BE84B4", Offset = "0x1BE84B4", VA = "0x1BE84B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x1BE84BC", Offset = "0x1BE84BC", VA = "0x1BE84BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public float Radius
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x1BE8554", Offset = "0x1BE8554", VA = "0x1BE8554")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x1BE855C", Offset = "0x1BE855C", VA = "0x1BE855C")]
			set
			{
			}
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1BE85FC", Offset = "0x1BE85FC", VA = "0x1BE85FC", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x1BE862C", Offset = "0x1BE862C", VA = "0x1BE862C", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x1BE880C", Offset = "0x1BE880C", VA = "0x1BE880C")]
		public CSCircle()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x6F5FA8", Offset = "0x6F5FA8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F5FA8", Offset = "0x6F5FA8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6F5FA8", Offset = "0x6F5FA8")]
	public class CSPie : CSCircle
	{
		[Token(Token = "0x2000176")]
		public enum EatModeEnum
		{
			[Token(Token = "0x40005DA")]
			Left,
			[Token(Token = "0x40005DB")]
			Right,
			[Token(Token = "0x40005DC")]
			Center
		}

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6FBE88", Offset = "0x6FBE88")]
		[SerializeField]
		private float m_Roundness;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6FBEC0", Offset = "0x6FBEC0")]
		private int m_Empty;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FBF44", Offset = "0x6FBF44")]
		[SerializeField]
		private EatModeEnum m_Eat;

		[Token(Token = "0x1700012A")]
		public float Roundness
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x1BE8824", Offset = "0x1BE8824", VA = "0x1BE8824")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x1BE882C", Offset = "0x1BE882C", VA = "0x1BE882C")]
			set
			{
			}
		}

		[Token(Token = "0x1700012B")]
		public int Empty
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x1BE88C8", Offset = "0x1BE88C8", VA = "0x1BE88C8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x1BE88D0", Offset = "0x1BE88D0", VA = "0x1BE88D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		private int maxEmpty
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x1BE8970", Offset = "0x1BE8970", VA = "0x1BE8970")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700012D")]
		public EatModeEnum Eat
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x1BE8978", Offset = "0x1BE8978", VA = "0x1BE8978")]
			get
			{
				return default(EatModeEnum);
			}
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x1BE8980", Offset = "0x1BE8980", VA = "0x1BE8980")]
			set
			{
			}
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1BE8998", Offset = "0x1BE8998", VA = "0x1BE8998", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1BE89D8", Offset = "0x1BE89D8", VA = "0x1BE89D8")]
		private Vector3 cpPosition(int i, int empty, float d)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x1BE8B60", Offset = "0x1BE8B60", VA = "0x1BE8B60", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1BE9614", Offset = "0x1BE9614", VA = "0x1BE9614")]
		public CSPie()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x6F606C", Offset = "0x6F606C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F606C", Offset = "0x6F606C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6F606C", Offset = "0x6F606C")]
	public class CSRectangle : CurvyShape2D
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Positive]
		[SerializeField]
		private float m_Width;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Positive]
		[SerializeField]
		private float m_Height;

		[Token(Token = "0x1700012E")]
		public float Width
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x1BE963C", Offset = "0x1BE963C", VA = "0x1BE963C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x1BE9644", Offset = "0x1BE9644", VA = "0x1BE9644")]
			set
			{
			}
		}

		[Token(Token = "0x1700012F")]
		public float Height
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x1BE96E4", Offset = "0x1BE96E4", VA = "0x1BE96E4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x1BE96EC", Offset = "0x1BE96EC", VA = "0x1BE96EC")]
			set
			{
			}
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1BE978C", Offset = "0x1BE978C", VA = "0x1BE978C", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1BE97BC", Offset = "0x1BE97BC", VA = "0x1BE97BC", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1BE9A18", Offset = "0x1BE9A18", VA = "0x1BE9A18")]
		public CSRectangle()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x6F6130", Offset = "0x6F6130")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F6130", Offset = "0x6F6130")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6F6130", Offset = "0x6F6130")]
	public class CSRoundedRectangle : CurvyShape2D
	{
		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Positive]
		[SerializeField]
		private float m_Width;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Positive]
		[SerializeField]
		private float m_Height;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6FC058", Offset = "0x6FC058")]
		[SerializeField]
		private float m_Roundness;

		[Token(Token = "0x17000130")]
		public float Width
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x1BE9A2C", Offset = "0x1BE9A2C", VA = "0x1BE9A2C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x1BE9A34", Offset = "0x1BE9A34", VA = "0x1BE9A34")]
			set
			{
			}
		}

		[Token(Token = "0x17000131")]
		public float Height
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x1BE9AD4", Offset = "0x1BE9AD4", VA = "0x1BE9AD4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x1BE9ADC", Offset = "0x1BE9ADC", VA = "0x1BE9ADC")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public float Roundness
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x1BE9B7C", Offset = "0x1BE9B7C", VA = "0x1BE9B7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x1BE9B84", Offset = "0x1BE9B84", VA = "0x1BE9B84")]
			set
			{
			}
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x1BE9C20", Offset = "0x1BE9C20", VA = "0x1BE9C20", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x1BE9C5C", Offset = "0x1BE9C5C", VA = "0x1BE9C5C", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x1BEA2C0", Offset = "0x1BEA2C0", VA = "0x1BEA2C0")]
		public CSRoundedRectangle()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x6F61F4", Offset = "0x6F61F4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F61F4", Offset = "0x6F61F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6F61F4", Offset = "0x6F61F4")]
	public class CSSpiral : CurvyShape2D
	{
		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Positive]
		[SerializeField]
		private int m_Count;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Positive]
		[SerializeField]
		private float m_Circles;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Positive]
		[SerializeField]
		private float m_Radius;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FC18C", Offset = "0x6FC18C")]
		[SerializeField]
		private AnimationCurve m_RadiusFactor;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve m_Z;

		[Token(Token = "0x17000133")]
		public int Count
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x1BEA2DC", Offset = "0x1BEA2DC", VA = "0x1BEA2DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1BEA2E4", Offset = "0x1BEA2E4", VA = "0x1BEA2E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public float Circles
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x1BEA37C", Offset = "0x1BEA37C", VA = "0x1BEA37C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1BEA384", Offset = "0x1BEA384", VA = "0x1BEA384")]
			set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public float Radius
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x1BEA424", Offset = "0x1BEA424", VA = "0x1BEA424")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x1BEA42C", Offset = "0x1BEA42C", VA = "0x1BEA42C")]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public AnimationCurve RadiusFactor
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x1BEA4CC", Offset = "0x1BEA4CC", VA = "0x1BEA4CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1BEA4D4", Offset = "0x1BEA4D4", VA = "0x1BEA4D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public AnimationCurve Z
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x1BEA500", Offset = "0x1BEA500", VA = "0x1BEA500")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x1BEA508", Offset = "0x1BEA508", VA = "0x1BEA508")]
			set
			{
			}
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x1BEA534", Offset = "0x1BEA534", VA = "0x1BEA534", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x1BEA600", Offset = "0x1BEA600", VA = "0x1BEA600", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1BEA83C", Offset = "0x1BEA83C", VA = "0x1BEA83C")]
		public CSSpiral()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x6F62B8", Offset = "0x6F62B8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F62B8", Offset = "0x6F62B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6F62B8", Offset = "0x6F62B8")]
	public class CSStar : CurvyShape2D
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Positive]
		private int m_Sides;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Positive]
		private float m_OuterRadius;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6FC27C", Offset = "0x6FC27C")]
		private float m_OuterRoundness;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Positive]
		private float m_InnerRadius;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6FC318", Offset = "0x6FC318")]
		private float m_InnerRoundness;

		[Token(Token = "0x17000138")]
		public int Sides
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x1BEA8D8", Offset = "0x1BEA8D8", VA = "0x1BEA8D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x1BEA8E0", Offset = "0x1BEA8E0", VA = "0x1BEA8E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000139")]
		public float OuterRadius
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x1BEA978", Offset = "0x1BEA978", VA = "0x1BEA978")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x1BEA980", Offset = "0x1BEA980", VA = "0x1BEA980")]
			set
			{
			}
		}

		[Token(Token = "0x1700013A")]
		public float OuterRoundness
		{
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x1BEAA2C", Offset = "0x1BEAA2C", VA = "0x1BEAA2C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x1BEAA34", Offset = "0x1BEAA34", VA = "0x1BEAA34")]
			set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public float InnerRadius
		{
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x1BEAAD4", Offset = "0x1BEAAD4", VA = "0x1BEAAD4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x1BEAADC", Offset = "0x1BEAADC", VA = "0x1BEAADC")]
			set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public float InnerRoundness
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x1BEAB7C", Offset = "0x1BEAB7C", VA = "0x1BEAB7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x1BEAB84", Offset = "0x1BEAB84", VA = "0x1BEAB84")]
			set
			{
			}
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x1BEAC24", Offset = "0x1BEAC24", VA = "0x1BEAC24", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1BEAC78", Offset = "0x1BEAC78", VA = "0x1BEAC78", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1BEAFC4", Offset = "0x1BEAFC4", VA = "0x1BEAFC4")]
		public CSStar()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Utils
{
	[Token(Token = "0x20000DE")]
	public static class CurvyUtility
	{
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1D773BC", Offset = "0x1D773BC", VA = "0x1D773BC")]
		public static float ClampTF(float tf, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1D77510", Offset = "0x1D77510", VA = "0x1D77510")]
		public static float ClampValue(float tf, CurvyClamping clamping, float minTF, float maxTF)
		{
			return default(float);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1D776F8", Offset = "0x1D776F8", VA = "0x1D776F8")]
		public static float ClampTF(float tf, ref int dir, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1D77838", Offset = "0x1D77838", VA = "0x1D77838")]
		public static float ClampTF(float tf, ref int dir, CurvyClamping clamping, float minTF, float maxTF)
		{
			return default(float);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1D779F4", Offset = "0x1D779F4", VA = "0x1D779F4")]
		public static float ClampDistance(float distance, CurvyClamping clamping, float length)
		{
			return default(float);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1D77B20", Offset = "0x1D77B20", VA = "0x1D77B20")]
		public static float ClampDistance(float distance, CurvyClamping clamping, float length, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1D77CBC", Offset = "0x1D77CBC", VA = "0x1D77CBC")]
		public static float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float length)
		{
			return default(float);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1D77E3C", Offset = "0x1D77E3C", VA = "0x1D77E3C")]
		public static float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float length, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1D78020", Offset = "0x1D78020", VA = "0x1D78020")]
		public static Material GetDefaultMaterial()
		{
			return null;
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1D7813C", Offset = "0x1D7813C", VA = "0x1D7813C")]
		public static bool Approximately(this float x, float y)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000DF")]
	public class Spline2Mesh
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public List<SplinePolyLine> Lines;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public WindingRule Winding;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 UVTiling;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 UVOffset;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool SuppressUVMapping;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool UV2;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public string MeshName;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool VertexLineOnly;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FC384", Offset = "0x6FC384")]
		private string <Error>k__BackingField;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Tess mTess;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Mesh mMesh;

		[Token(Token = "0x1700013D")]
		public string Error
		{
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x1D782EC", Offset = "0x1D782EC", VA = "0x1D782EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703A24", Offset = "0x703A24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x1D782F4", Offset = "0x1D782F4", VA = "0x1D782F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703A34", Offset = "0x703A34")]
			private set
			{
			}
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1D782FC", Offset = "0x1D782FC", VA = "0x1D782FC")]
		public bool Apply(out Mesh result)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x1D78AF4", Offset = "0x1D78AF4", VA = "0x1D78AF4")]
		private bool triangulate()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1D790CC", Offset = "0x1D790CC", VA = "0x1D790CC")]
		private static bool polyLineIsValid(SplinePolyLine pl)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1D7917C", Offset = "0x1D7917C", VA = "0x1D7917C")]
		public Spline2Mesh()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E0")]
	public class SplinePolyLine
	{
		[Token(Token = "0x2000177")]
		public enum VertexCalculation
		{
			[Token(Token = "0x40005DE")]
			ByApproximation,
			[Token(Token = "0x40005DF")]
			ByAngle
		}

		[Token(Token = "0x2000178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F789C", Offset = "0x6F789C")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<Vector3> vPos;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 curPos;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<Vector3> vTan;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 curTangent;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<float> vTF;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float angleFromLast;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float distAccu;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int linearSteps;

			[Token(Token = "0x6000B53")]
			[Address(RVA = "0x1D79D78", Offset = "0x1D79D78", VA = "0x1D79D78")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000B54")]
			[Address(RVA = "0x1D79D80", Offset = "0x1D79D80", VA = "0x1D79D80")]
			internal void <GetPolygon>b__0(float f)
			{
			}
		}

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ContourOrientation Orientation;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public CurvySpline Spline;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public VertexCalculation VertexMode;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Angle;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Distance;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Space Space;

		[Token(Token = "0x1700013E")]
		public bool IsClosed
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x1D79364", Offset = "0x1D79364", VA = "0x1D79364")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1D79298", Offset = "0x1D79298", VA = "0x1D79298")]
		public SplinePolyLine(CurvySpline spline)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1D7931C", Offset = "0x1D7931C", VA = "0x1D7931C")]
		public SplinePolyLine(CurvySpline spline, float angle, float distance)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1D792D0", Offset = "0x1D792D0", VA = "0x1D792D0")]
		private SplinePolyLine(CurvySpline spline, VertexCalculation vertexMode, float angle, float distance, Space space = Space.World)
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1D78F10", Offset = "0x1D78F10", VA = "0x1D78F10")]
		public Vector3[] GetVertices()
		{
			return null;
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1D79410", Offset = "0x1D79410", VA = "0x1D79410")]
		private static Vector3[] GetPolygon(CurvySpline spline, float fromTF, float toTF, float maxAngle, float minDistance, float maxDistance, out List<float> vertexTF, out List<Vector3> vertexTangents, bool includeEndPoint = true, float stepSize = 0.01f)
		{
			return null;
		}
	}
}
namespace FluffyUnderware.Curvy.Generator
{
	[Token(Token = "0x20000E1")]
	public abstract class SplineInputModuleBase : CGModule
	{
		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6FC394", Offset = "0x6FC394")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6FC394", Offset = "0x6FC394")]
		private bool m_UseCache;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6FC404", Offset = "0x6FC404")]
		[SerializeField]
		private bool m_UseGlobalSpace;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6FC44C", Offset = "0x6FC44C")]
		[SerializeField]
		protected CurvySplineSegment m_StartCP;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FC494", Offset = "0x6FC494")]
		[SerializeField]
		protected CurvySplineSegment m_EndCP;

		[Token(Token = "0x1700013F")]
		public bool UseCache
		{
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x1BE4400", Offset = "0x1BE4400", VA = "0x1BE4400")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x1BE4408", Offset = "0x1BE4408", VA = "0x1BE4408")]
			set
			{
			}
		}

		[Token(Token = "0x17000140")]
		public CurvySplineSegment StartCP
		{
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x1BE442C", Offset = "0x1BE442C", VA = "0x1BE442C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x1BE4434", Offset = "0x1BE4434", VA = "0x1BE4434")]
			set
			{
			}
		}

		[Token(Token = "0x17000141")]
		public CurvySplineSegment EndCP
		{
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x1BE44F0", Offset = "0x1BE44F0", VA = "0x1BE44F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x1BE44F8", Offset = "0x1BE44F8", VA = "0x1BE44F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000142")]
		public bool UseGlobalSpace
		{
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x1BE45B4", Offset = "0x1BE45B4", VA = "0x1BE45B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x1BE45BC", Offset = "0x1BE45BC", VA = "0x1BE45BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000143")]
		public override bool IsConfigured
		{
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x1BE45CC", Offset = "0x1BE45CC", VA = "0x1BE45CC", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000144")]
		public override bool IsInitialized
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x1BE4680", Offset = "0x1BE4680", VA = "0x1BE4680", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000145")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x704404", Offset = "0x704404")]
		public float PathLength
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x1BE476C", Offset = "0x1BE476C", VA = "0x1BE476C", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000146")]
		public bool PathIsClosed
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x1BE491C", Offset = "0x1BE491C", VA = "0x1BE491C", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000147")]
		protected abstract CurvySpline InputSpline
		{
			[Token(Token = "0x600070B")]
			get;
			[Token(Token = "0x600070C")]
			set;
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1BE4A4C", Offset = "0x1BE4A4C", VA = "0x1BE4A4C", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1BE4A94", Offset = "0x1BE4A94", VA = "0x1BE4A94", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1BE4C98", Offset = "0x1BE4C98", VA = "0x1BE4C98", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x1BE4D14", Offset = "0x1BE4D14", VA = "0x1BE4D14")]
		private void OnSplineRefreshed(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x1BE4EB0", Offset = "0x1BE4EB0", VA = "0x1BE4EB0")]
		private void OnInputSplineCoordinatesChanged(CurvySpline sender)
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x1BE4EA4", Offset = "0x1BE4EA4", VA = "0x1BE4EA4")]
		private void ForceRefresh()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x1BE47C0", Offset = "0x1BE47C0", VA = "0x1BE47C0")]
		private float getPathLength(CurvySpline spline)
		{
			return default(float);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x1BE4970", Offset = "0x1BE4970", VA = "0x1BE4970")]
		private bool getPathClosed(CurvySpline spline)
		{
			return default(bool);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1BDB8BC", Offset = "0x1BDB8BC", VA = "0x1BDB8BC")]
		protected CGData GetSplineData(CurvySpline spline, bool fullPath, CGDataRequestRasterization raster, CGDataRequestMetaCGOptions options)
		{
			return null;
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1BE51D0", Offset = "0x1BE51D0", VA = "0x1BE51D0")]
		private static void FillData(CGShape dataToFill, SamplePointsMaterialGroup materialGroup, List<float> sourceFs, List<float> relativeFs, bool isFullPath, List<Vector3> positions, List<Vector3> tangents, List<Vector3> normals, bool considerSplineTransform, Transform splineTransform, Transform generatorTransform)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1BE5080", Offset = "0x1BE5080", VA = "0x1BE5080")]
		private static void AddPoint(float sourceF, float relativeF, bool isFullPath, Vector3 position, Vector3 tangent, Vector3 up, List<float> sourceFList, List<float> relativeFList, List<Vector3> positionList, List<Vector3> tangentList, List<Vector3> upList)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x1BE5690", Offset = "0x1BE5690", VA = "0x1BE5690")]
		private static bool MoveByAngleExt(CurvySpline spline, bool useCache, ref float tf, float maxDistance, float maxAngle, out Vector3 pos, out Vector3 tan, float stopTF, bool loop, float stepDist)
		{
			return default(bool);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1BE5AB0", Offset = "0x1BE5AB0", VA = "0x1BE5AB0")]
		private static void CalculateExtendedUV(CurvySpline spline, float startTF, float endTF, List<SamplePointUData> ext, CGShape data)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1BE6568", Offset = "0x1BE6568", VA = "0x1BE6568")]
		private static MetaCGOptions findPreviousReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp)
		{
			return null;
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x1BE6718", Offset = "0x1BE6718", VA = "0x1BE6718")]
		private static MetaCGOptions findNextReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp)
		{
			return null;
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x1BDDF68", Offset = "0x1BDDF68", VA = "0x1BDDF68", Slot = "19")]
		protected virtual void OnSplineAssigned()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x1BDB354", Offset = "0x1BDB354", VA = "0x1BDB354")]
		protected void ValidateStartAndEndCps()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1BDD920", Offset = "0x1BDD920", VA = "0x1BDD920")]
		protected SplineInputModuleBase()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class TRSModuleBase : CGModule
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6FC504", Offset = "0x6FC504")]
		private Vector3 m_Transpose;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6FC560", Offset = "0x6FC560")]
		private Vector3 m_Rotation;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6FC5BC", Offset = "0x6FC5BC")]
		private Vector3 m_Scale;

		[Token(Token = "0x17000148")]
		public Vector3 Transpose
		{
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x1BE6A90", Offset = "0x1BE6A90", VA = "0x1BE6A90")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000711")]
			[Address(RVA = "0x1BE6AA4", Offset = "0x1BE6AA4", VA = "0x1BE6AA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000149")]
		public Vector3 Rotation
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x1BE6B74", Offset = "0x1BE6B74", VA = "0x1BE6B74")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x1BE6B88", Offset = "0x1BE6B88", VA = "0x1BE6B88")]
			set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x1BE6C58", Offset = "0x1BE6C58", VA = "0x1BE6C58")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x1BE6C6C", Offset = "0x1BE6C6C", VA = "0x1BE6C6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700014B")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x1BE15B8", Offset = "0x1BE15B8", VA = "0x1BE15B8")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1BE6D3C", Offset = "0x1BE6D3C", VA = "0x1BE6D3C", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x1BE6D8C", Offset = "0x1BE6D8C", VA = "0x1BE6D8C", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1BE1774", Offset = "0x1BE1774", VA = "0x1BE1774")]
		public TRSModuleBase()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public enum CGYesNoAuto
	{
		[Token(Token = "0x400036F")]
		Yes,
		[Token(Token = "0x4000370")]
		No,
		[Token(Token = "0x4000371")]
		Auto
	}
	[Token(Token = "0x20000E4")]
	public enum CGReferenceMode
	{
		[Token(Token = "0x4000373")]
		Source,
		[Token(Token = "0x4000374")]
		Self
	}
	[Token(Token = "0x20000E5")]
	public enum CGKeepAspectMode
	{
		[Token(Token = "0x4000376")]
		Off,
		[Token(Token = "0x4000377")]
		ScaleU,
		[Token(Token = "0x4000378")]
		ScaleV
	}
	[Token(Token = "0x20000E6")]
	public enum CGUVEnum
	{
		[Token(Token = "0x400037A")]
		U,
		[Token(Token = "0x400037B")]
		V
	}
	[Token(Token = "0x20000E7")]
	public enum CGColliderEnum
	{
		[Token(Token = "0x400037D")]
		None,
		[Token(Token = "0x400037E")]
		Mesh,
		[Token(Token = "0x400037F")]
		Box,
		[Token(Token = "0x4000380")]
		Sphere
	}
	[Serializable]
	[Token(Token = "0x20000E8")]
	public struct CGSpot : IEquatable<CGSpot>
	{
		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FC618", Offset = "0x6FC618")]
		private int m_Index;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6FC678", Offset = "0x6FC678")]
		private Vector3 m_Position;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6FC6E8", Offset = "0x6FC6E8")]
		private Quaternion m_Rotation;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6FC758", Offset = "0x6FC758")]
		private Vector3 m_Scale;

		[Token(Token = "0x1700014C")]
		public int Index
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0x13FDF10", Offset = "0x13FDF10", VA = "0x13FDF10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700014D")]
		public Vector3 Position
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x13FDF18", Offset = "0x13FDF18", VA = "0x13FDF18")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x13FDF2C", Offset = "0x13FDF2C", VA = "0x13FDF2C")]
			set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		public Quaternion Rotation
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x13FDFE8", Offset = "0x13FDFE8", VA = "0x13FDFE8")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x13FDFF8", Offset = "0x13FDFF8", VA = "0x13FDFF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700014F")]
		public Vector3 Scale
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x13FE0E0", Offset = "0x13FE0E0", VA = "0x13FE0E0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x13FE0F4", Offset = "0x13FE0F4", VA = "0x13FE0F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000150")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x13FE1B4", Offset = "0x13FE1B4", VA = "0x13FE1B4")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x13FE29C", Offset = "0x13FE29C", VA = "0x13FE29C")]
		public CGSpot(int index)
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x13FE3A0", Offset = "0x13FE3A0", VA = "0x13FE3A0")]
		public CGSpot(int index, Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x13FE3E4", Offset = "0x13FE3E4", VA = "0x13FE3E4")]
		public void ToTransform(Transform transform)
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x13FE494", Offset = "0x13FE494", VA = "0x13FE494", Slot = "4")]
		public bool Equals(CGSpot other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x13FE524", Offset = "0x13FE524", VA = "0x13FE524", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x13FE5E0", Offset = "0x13FE5E0", VA = "0x13FE5E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x13FE638", Offset = "0x13FE638", VA = "0x13FE638")]
		public static bool operator ==(CGSpot left, CGSpot right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x13FE6D0", Offset = "0x13FE6D0", VA = "0x13FE6D0")]
		public static bool operator !=(CGSpot left, CGSpot right)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x20000E9")]
	public class CGMaterialSettings
	{
		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SwapUV;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public CGKeepAspectMode KeepAspect;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float UVRotation;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector2 UVOffset;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 UVScale;

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x1D6AB34", Offset = "0x1D6AB34", VA = "0x1D6AB34")]
		public CGMaterialSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EA")]
	public class CGMaterialSettingsEx : CGMaterialSettings
	{
		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int MaterialID;

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x1D6ABEC", Offset = "0x1D6ABEC", VA = "0x1D6ABEC")]
		public CGMaterialSettingsEx()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EB")]
	public class CGMeshProperties
	{
		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private Mesh m_Mesh;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Material[] m_Material;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6FC7E8", Offset = "0x6FC7E8")]
		private Vector3 m_Translation;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6FC844", Offset = "0x6FC844")]
		private Vector3 m_Rotation;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6FC8A0", Offset = "0x6FC8A0")]
		private Vector3 m_Scale;

		[Token(Token = "0x17000151")]
		public Mesh Mesh
		{
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x1D6ABF0", Offset = "0x1D6ABF0", VA = "0x1D6ABF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x1D6ABF8", Offset = "0x1D6ABF8", VA = "0x1D6ABF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public Material[] Material
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x1D6AD4C", Offset = "0x1D6AD4C", VA = "0x1D6AD4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x1D6AD54", Offset = "0x1D6AD54", VA = "0x1D6AD54")]
			set
			{
			}
		}

		[Token(Token = "0x17000153")]
		public Vector3 Translation
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x1D6AD68", Offset = "0x1D6AD68", VA = "0x1D6AD68")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x1D6AD7C", Offset = "0x1D6AD7C", VA = "0x1D6AD7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000154")]
		public Vector3 Rotation
		{
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x1D6AE3C", Offset = "0x1D6AE3C", VA = "0x1D6AE3C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x1D6AE50", Offset = "0x1D6AE50", VA = "0x1D6AE50")]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x1D6AF10", Offset = "0x1D6AF10", VA = "0x1D6AF10")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x1D6AF24", Offset = "0x1D6AF24", VA = "0x1D6AF24")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x1D6AFE4", Offset = "0x1D6AFE4", VA = "0x1D6AFE4")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x1D6B0F4", Offset = "0x1D6B0F4", VA = "0x1D6B0F4")]
		public CGMeshProperties()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x1D6B1B8", Offset = "0x1D6B1B8", VA = "0x1D6B1B8")]
		public CGMeshProperties(Mesh mesh)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EC")]
	public class CGGameObjectProperties
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private GameObject m_Object;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6FC90C", Offset = "0x6FC90C")]
		private Vector3 m_Translation;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6FC968", Offset = "0x6FC968")]
		private Vector3 m_Rotation;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6FC9C4", Offset = "0x6FC9C4")]
		private Vector3 m_Scale;

		[Token(Token = "0x17000157")]
		public GameObject Object
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x1D69FF0", Offset = "0x1D69FF0", VA = "0x1D69FF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x1D69FF8", Offset = "0x1D69FF8", VA = "0x1D69FF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000158")]
		public Vector3 Translation
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x1D6A09C", Offset = "0x1D6A09C", VA = "0x1D6A09C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x1D6A0B0", Offset = "0x1D6A0B0", VA = "0x1D6A0B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public Vector3 Rotation
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x1D6A170", Offset = "0x1D6A170", VA = "0x1D6A170")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x1D6A184", Offset = "0x1D6A184", VA = "0x1D6A184")]
			set
			{
			}
		}

		[Token(Token = "0x1700015A")]
		public Vector3 Scale
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x1D6A244", Offset = "0x1D6A244", VA = "0x1D6A244")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x1D6A258", Offset = "0x1D6A258", VA = "0x1D6A258")]
			set
			{
			}
		}

		[Token(Token = "0x1700015B")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x1D6A318", Offset = "0x1D6A318", VA = "0x1D6A318")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x1D6A428", Offset = "0x1D6A428", VA = "0x1D6A428")]
		public CGGameObjectProperties()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x1D6A4C4", Offset = "0x1D6A4C4", VA = "0x1D6A4C4")]
		public CGGameObjectProperties(GameObject gameObject)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000ED")]
	public class CGWeightedItem
	{
		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6FCA20", Offset = "0x6FCA20")]
		[SerializeField]
		private float m_Weight;

		[Token(Token = "0x1700015C")]
		public float Weight
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x1405128", Offset = "0x1405128", VA = "0x1405128")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x1405130", Offset = "0x1405130", VA = "0x1405130")]
			set
			{
			}
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x14051C4", Offset = "0x14051C4", VA = "0x14051C4")]
		public CGWeightedItem()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EE")]
	public class CGBoundsGroup : CGWeightedItem
	{
		[Token(Token = "0x2000179")]
		public enum DistributionModeEnum
		{
			[Token(Token = "0x40005E9")]
			Parent,
			[Token(Token = "0x40005EA")]
			Self
		}

		[Token(Token = "0x200017A")]
		public enum RotationModeEnum
		{
			[Token(Token = "0x40005EC")]
			Full,
			[Token(Token = "0x40005ED")]
			Direction,
			[Token(Token = "0x40005EE")]
			Horizontal,
			[Token(Token = "0x40005EF")]
			Independent
		}

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private string m_Name;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_KeepTogether;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_SpaceBefore;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_SpaceAfter;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private CurvyRepeatingOrderEnum m_RepeatingOrder;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[IntRegion]
		[SerializeField]
		private IntRegion m_RepeatingItems;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6FCBAC", Offset = "0x6FCBAC")]
		private DistributionModeEnum m_DistributionMode;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_PositionOffset;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_Height;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6FCC9C", Offset = "0x6FCC9C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FCC9C", Offset = "0x6FCC9C")]
		[SerializeField]
		private RotationModeEnum m_RotationMode;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6FCD24", Offset = "0x6FCD24")]
		private Vector3 m_RotationOffset;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6FCD80", Offset = "0x6FCD80")]
		private Vector3 m_RotationScatter;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private List<CGBoundsGroupItem> m_Items;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private WeightedRandom<int> mItemBag;

		[Token(Token = "0x1700015D")]
		public string Name
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x1D677A8", Offset = "0x1D677A8", VA = "0x1D677A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x1D677B0", Offset = "0x1D677B0", VA = "0x1D677B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700015E")]
		public bool KeepTogether
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x1D677E8", Offset = "0x1D677E8", VA = "0x1D677E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x1D677F0", Offset = "0x1D677F0", VA = "0x1D677F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700015F")]
		public FloatRegion SpaceBefore
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x1D6780C", Offset = "0x1D6780C", VA = "0x1D6780C")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x1D67820", Offset = "0x1D67820", VA = "0x1D67820")]
			set
			{
			}
		}

		[Token(Token = "0x17000160")]
		public FloatRegion SpaceAfter
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x1D67878", Offset = "0x1D67878", VA = "0x1D67878")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x1D6788C", Offset = "0x1D6788C", VA = "0x1D6788C")]
			set
			{
			}
		}

		[Token(Token = "0x17000161")]
		public CurvyRepeatingOrderEnum RepeatingOrder
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x1D678E4", Offset = "0x1D678E4", VA = "0x1D678E4")]
			get
			{
				return default(CurvyRepeatingOrderEnum);
			}
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x1D678EC", Offset = "0x1D678EC", VA = "0x1D678EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000162")]
		public IntRegion RepeatingItems
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x1D678FC", Offset = "0x1D678FC", VA = "0x1D678FC")]
			get
			{
				return default(IntRegion);
			}
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x1D67910", Offset = "0x1D67910", VA = "0x1D67910")]
			set
			{
			}
		}

		[Token(Token = "0x17000163")]
		public DistributionModeEnum DistributionMode
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x1D67968", Offset = "0x1D67968", VA = "0x1D67968")]
			get
			{
				return default(DistributionModeEnum);
			}
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x1D67970", Offset = "0x1D67970", VA = "0x1D67970")]
			set
			{
			}
		}

		[Token(Token = "0x17000164")]
		public FloatRegion PositionOffset
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x1D67980", Offset = "0x1D67980", VA = "0x1D67980")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x1D67994", Offset = "0x1D67994", VA = "0x1D67994")]
			set
			{
			}
		}

		[Token(Token = "0x17000165")]
		public FloatRegion Height
		{
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x1D679EC", Offset = "0x1D679EC", VA = "0x1D679EC")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x1D67A00", Offset = "0x1D67A00", VA = "0x1D67A00")]
			set
			{
			}
		}

		[Token(Token = "0x17000166")]
		public RotationModeEnum RotationMode
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x1D67A58", Offset = "0x1D67A58", VA = "0x1D67A58")]
			get
			{
				return default(RotationModeEnum);
			}
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x1D67A60", Offset = "0x1D67A60", VA = "0x1D67A60")]
			set
			{
			}
		}

		[Token(Token = "0x17000167")]
		public Vector3 RotationOffset
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x1D67A70", Offset = "0x1D67A70", VA = "0x1D67A70")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x1D67A84", Offset = "0x1D67A84", VA = "0x1D67A84")]
			set
			{
			}
		}

		[Token(Token = "0x17000168")]
		public Vector3 RotationScatter
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x1D67B44", Offset = "0x1D67B44", VA = "0x1D67B44")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x1D67B58", Offset = "0x1D67B58", VA = "0x1D67B58")]
			set
			{
			}
		}

		[Token(Token = "0x17000169")]
		public List<CGBoundsGroupItem> Items
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x1D67C18", Offset = "0x1D67C18", VA = "0x1D67C18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016A")]
		public int FirstRepeating
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x1D67C20", Offset = "0x1D67C20", VA = "0x1D67C20")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x1D67C28", Offset = "0x1D67C28", VA = "0x1D67C28")]
			set
			{
			}
		}

		[Token(Token = "0x1700016B")]
		public int LastRepeating
		{
			[Token(Token = "0x6000762")]
			[Address(RVA = "0x1D67D30", Offset = "0x1D67D30", VA = "0x1D67D30")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000763")]
			[Address(RVA = "0x1D67D38", Offset = "0x1D67D38", VA = "0x1D67D38")]
			set
			{
			}
		}

		[Token(Token = "0x1700016C")]
		public int ItemCount
		{
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x1D67CD8", Offset = "0x1D67CD8", VA = "0x1D67CD8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700016D")]
		private RegionOptions<int> RepeatingGroupsOptions
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x1D67F20", Offset = "0x1D67F20", VA = "0x1D67F20")]
			get
			{
				return default(RegionOptions<int>);
			}
		}

		[Token(Token = "0x1700016E")]
		private RegionOptions<float> PositionRangeOptions
		{
			[Token(Token = "0x6000767")]
			[Address(RVA = "0x1D67FD0", Offset = "0x1D67FD0", VA = "0x1D67FD0")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x1700016F")]
		private int lastItemIndex
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x1D68038", Offset = "0x1D68038", VA = "0x1D68038")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1D67DF0", Offset = "0x1D67DF0", VA = "0x1D67DF0")]
		public CGBoundsGroup(string name)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1D680C4", Offset = "0x1D680C4", VA = "0x1D680C4")]
		internal void PrepareINTERNAL()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1D68210", Offset = "0x1D68210", VA = "0x1D68210")]
		public static void FillItemBag(WeightedRandom<int> bag, IEnumerable<CGWeightedItem> itemsWeights, int firstItem, int lastItem)
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1D68364", Offset = "0x1D68364", VA = "0x1D68364")]
		internal int getRandomItemINTERNAL()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000EF")]
	public class CGBoundsGroupItem : CGWeightedItem
	{
		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int Index;

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1D683D0", Offset = "0x1D683D0", VA = "0x1D683D0")]
		public CGBoundsGroupItem()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public struct ControlPointOption : IEquatable<ControlPointOption>
	{
		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float TF;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Distance;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool Include;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int MaterialID;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool HardEdge;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float MaxStepDistance;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UVEdge;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UVShift;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FirstU;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float SecondU;

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x13FF45C", Offset = "0x13FF45C", VA = "0x13FF45C")]
		public ControlPointOption(float tf, float dist, bool includeAnyways, int materialID, bool hardEdge, float maxStepDistance, bool uvEdge, bool uvShift, float firstU, float secondU)
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x14051D4", Offset = "0x14051D4", VA = "0x14051D4", Slot = "4")]
		public bool Equals(ControlPointOption other)
		{
			return default(bool);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x1405310", Offset = "0x1405310", VA = "0x1405310", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x14053C4", Offset = "0x14053C4", VA = "0x14053C4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1405490", Offset = "0x1405490", VA = "0x1405490")]
		public static bool operator ==(ControlPointOption left, ControlPointOption right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x140550C", Offset = "0x140550C", VA = "0x140550C")]
		public static bool operator !=(ControlPointOption left, ControlPointOption right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F1")]
	public struct SamplePointsPatch : IEquatable<SamplePointsPatch>
	{
		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Start;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int Count;

		[Token(Token = "0x17000170")]
		public int End
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0x1BE3768", Offset = "0x1BE3768", VA = "0x1BE3768")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x1BE3E24", Offset = "0x1BE3E24", VA = "0x1BE3E24")]
			set
			{
			}
		}

		[Token(Token = "0x17000171")]
		public int TriangleCount
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x1BE3658", Offset = "0x1BE3658", VA = "0x1BE3658")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1BE3EB0", Offset = "0x1BE3EB0", VA = "0x1BE3EB0")]
		public SamplePointsPatch(int start)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1BE3EBC", Offset = "0x1BE3EBC", VA = "0x1BE3EBC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1BE414C", Offset = "0x1BE414C", VA = "0x1BE414C", Slot = "4")]
		public bool Equals(SamplePointsPatch other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1BE4170", Offset = "0x1BE4170", VA = "0x1BE4170", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1BE4210", Offset = "0x1BE4210", VA = "0x1BE4210", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1BE4228", Offset = "0x1BE4228", VA = "0x1BE4228")]
		public static bool operator ==(SamplePointsPatch left, SamplePointsPatch right)
		{
			return default(bool);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1BE4240", Offset = "0x1BE4240", VA = "0x1BE4240")]
		public static bool operator !=(SamplePointsPatch left, SamplePointsPatch right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F2")]
	public class SamplePointsMaterialGroup
	{
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int MaterialID;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public List<SamplePointsPatch> Patches;

		[Token(Token = "0x17000172")]
		public int TriangleCount
		{
			[Token(Token = "0x600077D")]
			[Address(RVA = "0x1BE35A8", Offset = "0x1BE35A8", VA = "0x1BE35A8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000173")]
		public int StartVertex
		{
			[Token(Token = "0x600077E")]
			[Address(RVA = "0x1BE3664", Offset = "0x1BE3664", VA = "0x1BE3664")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000174")]
		public int EndVertex
		{
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x1BE36D4", Offset = "0x1BE36D4", VA = "0x1BE36D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000175")]
		public int VertexCount
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x1BE3778", Offset = "0x1BE3778", VA = "0x1BE3778")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1BE37A0", Offset = "0x1BE37A0", VA = "0x1BE37A0")]
		public SamplePointsMaterialGroup(int materialID)
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1BE3838", Offset = "0x1BE3838", VA = "0x1BE3838")]
		public void GetLengths(CGVolume volume, out float worldLength, out float uLength)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1BE0AC0", Offset = "0x1BE0AC0", VA = "0x1BE0AC0")]
		public SamplePointsMaterialGroup Clone()
		{
			return null;
		}
	}
	[Token(Token = "0x20000F3")]
	public struct SamplePointUData : IEquatable<SamplePointUData>
	{
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Vertex;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool UVEdge;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float FirstU;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float SecondU;

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1BE30F0", Offset = "0x1BE30F0", VA = "0x1BE30F0")]
		public SamplePointUData(int vt, bool uvEdge, float uv0, float uv1)
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1BE3108", Offset = "0x1BE3108", VA = "0x1BE3108", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1BE33A8", Offset = "0x1BE33A8", VA = "0x1BE33A8", Slot = "4")]
		public bool Equals(SamplePointUData other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1BE3418", Offset = "0x1BE3418", VA = "0x1BE3418", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1BE34B4", Offset = "0x1BE34B4", VA = "0x1BE34B4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1BE350C", Offset = "0x1BE350C", VA = "0x1BE350C")]
		public static bool operator ==(SamplePointUData left, SamplePointUData right)
		{
			return default(bool);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1BE3558", Offset = "0x1BE3558", VA = "0x1BE3558")]
		public static bool operator !=(SamplePointUData left, SamplePointUData right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F4")]
	public class SamplePointsMaterialGroupCollection : List<SamplePointsMaterialGroup>
	{
		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MaterialID;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float AspectCorrection;

		[Token(Token = "0x17000176")]
		public int TriangleCount
		{
			[Token(Token = "0x600078B")]
			[Address(RVA = "0x1BE3A94", Offset = "0x1BE3A94", VA = "0x1BE3A94")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1BE3B34", Offset = "0x1BE3B34", VA = "0x1BE3B34")]
		public SamplePointsMaterialGroupCollection()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1BE3BC4", Offset = "0x1BE3BC4", VA = "0x1BE3BC4")]
		public SamplePointsMaterialGroupCollection(int capacity)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1BE3C5C", Offset = "0x1BE3C5C", VA = "0x1BE3C5C")]
		public SamplePointsMaterialGroupCollection(IEnumerable<SamplePointsMaterialGroup> collection)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1BE3CF4", Offset = "0x1BE3CF4", VA = "0x1BE3CF4")]
		public void CalculateAspectCorrection(CGVolume volume, CGMaterialSettingsEx matSettings)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F5")]
	public class CGDataReference
	{
		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private CGModule m_Module;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private string m_SlotName;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CGModuleOutputSlot mSlot;

		[Token(Token = "0x17000177")]
		public CGData[] Data
		{
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x1D686D0", Offset = "0x1D686D0", VA = "0x1D686D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000178")]
		public CGModuleOutputSlot Slot
		{
			[Token(Token = "0x6000791")]
			[Address(RVA = "0x1D6875C", Offset = "0x1D6875C", VA = "0x1D6875C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000179")]
		public bool HasValue
		{
			[Token(Token = "0x6000792")]
			[Address(RVA = "0x1D68A10", Offset = "0x1D68A10", VA = "0x1D68A10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700017A")]
		public bool IsEmpty
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x1D68A4C", Offset = "0x1D68A4C", VA = "0x1D68A4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700017B")]
		public CGModule Module
		{
			[Token(Token = "0x6000794")]
			[Address(RVA = "0x1D68A58", Offset = "0x1D68A58", VA = "0x1D68A58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017C")]
		public string SlotName
		{
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x1D68A60", Offset = "0x1D68A60", VA = "0x1D68A60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1D68A68", Offset = "0x1D68A68", VA = "0x1D68A68")]
		public CGDataReference()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1D68A70", Offset = "0x1D68A70", VA = "0x1D68A70")]
		public CGDataReference(CGModule module, string slotName)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1D68AE0", Offset = "0x1D68AE0", VA = "0x1D68AE0")]
		public CGDataReference(CurvyGenerator generator, string moduleName, string slotName)
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x1D68B90", Offset = "0x1D68B90", VA = "0x1D68B90")]
		public void Clear()
		{
		}

		[Token(Token = "0x600079A")]
		public T GetData<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x600079B")]
		public T[] GetAllData<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x1D68AA0", Offset = "0x1D68AA0", VA = "0x1D68AA0")]
		public void setINTERNAL(CGModule module, string slotName)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1D68B20", Offset = "0x1D68B20", VA = "0x1D68B20")]
		public void setINTERNAL(CurvyGenerator generator, string moduleName, string slotName)
		{
		}
	}
	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6F638C", Offset = "0x6F638C")]
	public sealed class CGDataInfoAttribute : Attribute
	{
		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly Color Color;

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x1D685E4", Offset = "0x1D685E4", VA = "0x1D685E4")]
		public CGDataInfoAttribute(Color color)
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x1D6861C", Offset = "0x1D6861C", VA = "0x1D6861C")]
		public CGDataInfoAttribute(float r, float g, float b, float a = 1f)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x1D68688", Offset = "0x1D68688", VA = "0x1D68688")]
		public CGDataInfoAttribute(string htmlColor)
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class CGData
	{
		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Name;

		[Token(Token = "0x1700017D")]
		public virtual int Count
		{
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x1D683D8", Offset = "0x1D683D8", VA = "0x1D683D8", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1D683E0", Offset = "0x1D683E0", VA = "0x1D683E0")]
		public static implicit operator bool(CGData a)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A3")]
		public virtual T Clone<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x1D683EC", Offset = "0x1D683EC", VA = "0x1D683EC")]
		protected int getGenericFIndex(ref float[] FMapArray, float fValue, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x1D675AC", Offset = "0x1D675AC", VA = "0x1D675AC")]
		public CGData()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x6F63A0", Offset = "0x6F63A0")]
	public class CGShape : CGData
	{
		[Serializable]
		[Token(Token = "0x200017B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F78AC", Offset = "0x6F78AC")]
		private sealed class <>c
		{
			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<SamplePointsMaterialGroup, SamplePointsMaterialGroup> <>9__16_0;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<SamplePointsMaterialGroup, SamplePointsMaterialGroup> <>9__18_0;

			[Token(Token = "0x6000B56")]
			[Address(RVA = "0x13FD974", Offset = "0x13FD974", VA = "0x13FD974")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B57")]
			[Address(RVA = "0x13FD97C", Offset = "0x13FD97C", VA = "0x13FD97C")]
			internal SamplePointsMaterialGroup <.ctor>b__16_0(SamplePointsMaterialGroup g)
			{
				return null;
			}

			[Token(Token = "0x6000B58")]
			[Address(RVA = "0x13FD9A4", Offset = "0x13FD9A4", VA = "0x13FD9A4")]
			internal SamplePointsMaterialGroup <Copy>b__18_0(SamplePointsMaterialGroup g)
			{
				return null;
			}
		}

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float[] SourceF;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] F;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3[] Position;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] Normal;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float[] Map;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SamplePointsMaterialGroup> MaterialGroups;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool SourceIsManaged;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool Closed;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool Seamless;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Length;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float mCacheLastF;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int mCacheLastIndex;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float mCacheLastFrag;

		[Token(Token = "0x1700017E")]
		public override int Count
		{
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x1D75AA4", Offset = "0x1D75AA4", VA = "0x1D75AA4", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1D73EB4", Offset = "0x1D73EB4", VA = "0x1D73EB4")]
		public CGShape()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1D740E4", Offset = "0x1D740E4", VA = "0x1D740E4")]
		public CGShape(CGShape source)
		{
		}

		[Token(Token = "0x60007A9")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x1D74658", Offset = "0x1D74658", VA = "0x1D74658")]
		public static void Copy(CGShape dest, CGShape source)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1D75AC4", Offset = "0x1D75AC4", VA = "0x1D75AC4")]
		public void Copy(CGShape source)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1D75AC8", Offset = "0x1D75AC8", VA = "0x1D75AC8")]
		public float DistanceToF(float distance)
		{
			return default(float);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x1D75B6C", Offset = "0x1D75B6C", VA = "0x1D75B6C")]
		public float FToDistance(float f)
		{
			return default(float);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x1D74C70", Offset = "0x1D74C70", VA = "0x1D74C70")]
		public int GetFIndex(float f, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x1D75BFC", Offset = "0x1D75BFC", VA = "0x1D75BFC")]
		public Vector3 InterpolatePosition(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x1D75D64", Offset = "0x1D75D64", VA = "0x1D75D64")]
		public Vector3 InterpolateUp(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x1D75ECC", Offset = "0x1D75ECC", VA = "0x1D75ECC")]
		public void Interpolate(float f, out Vector3 position, out Vector3 up)
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x1D76108", Offset = "0x1D76108", VA = "0x1D76108")]
		public void Move(ref float f, ref int direction, float speed, CurvyClamping clamping)
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x1D76140", Offset = "0x1D76140", VA = "0x1D76140")]
		public void MoveBy(ref float f, ref int direction, float speedDist, CurvyClamping clamping)
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x1D7529C", Offset = "0x1D7529C", VA = "0x1D7529C", Slot = "6")]
		public virtual void Recalculate()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x1D761AC", Offset = "0x1D761AC", VA = "0x1D761AC")]
		public void RecalculateNormals(List<int> softEdges)
		{
		}
	}
	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x6F63E8", Offset = "0x6F63E8")]
	public class CGPath : CGShape
	{
		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3[] Direction;

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x1D73E40", Offset = "0x1D73E40", VA = "0x1D73E40")]
		public CGPath()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x1D73FF4", Offset = "0x1D73FF4", VA = "0x1D73FF4")]
		public CGPath(CGPath source)
		{
		}

		[Token(Token = "0x60007B8")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x1D74588", Offset = "0x1D74588", VA = "0x1D74588")]
		public static void Copy(CGPath dest, CGPath source)
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1D74974", Offset = "0x1D74974", VA = "0x1D74974")]
		public void Interpolate(float f, out Vector3 position, out Vector3 direction, out Vector3 up)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x1D74CD8", Offset = "0x1D74CD8", VA = "0x1D74CD8")]
		public void Interpolate(float f, float angleF, out Vector3 pos, out Vector3 dir, out Vector3 up)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x1D74E00", Offset = "0x1D74E00", VA = "0x1D74E00")]
		public Vector3 InterpolateDirection(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1D74F68", Offset = "0x1D74F68", VA = "0x1D74F68", Slot = "6")]
		public override void Recalculate()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x6F6430", Offset = "0x6F6430")]
	public class CGVolume : CGPath
	{
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3[] Vertex;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3[] VertexNormal;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float[] CrossF;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float[] CrossMap;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float[] SegmentLength;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool CrossClosed;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool CrossSeamless;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float CrossFShift;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public SamplePointsMaterialGroupCollection CrossMaterialGroups;

		[Token(Token = "0x1700017F")]
		public int CrossSize
		{
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x13FF94C", Offset = "0x13FF94C", VA = "0x13FF94C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000180")]
		public int VertexCount
		{
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x1402E2C", Offset = "0x1402E2C", VA = "0x1402E2C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x1402E4C", Offset = "0x1402E4C", VA = "0x1402E4C")]
		public CGVolume()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1402F24", Offset = "0x1402F24", VA = "0x1402F24")]
		public CGVolume(int samplePoints, CGShape crossShape)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x1403208", Offset = "0x1403208", VA = "0x1403208")]
		public CGVolume(CGPath path, CGShape crossShape)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x14034F8", Offset = "0x14034F8", VA = "0x14034F8")]
		public CGVolume(CGVolume source)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x140384C", Offset = "0x140384C", VA = "0x140384C")]
		public static CGVolume Get(CGVolume data, CGPath path, CGShape crossShape)
		{
			return null;
		}

		[Token(Token = "0x60007C5")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1403AA0", Offset = "0x1403AA0", VA = "0x1403AA0")]
		public void InterpolateVolume(float f, float crossF, out Vector3 pos, out Vector3 dir, out Vector3 up)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x1403FF8", Offset = "0x1403FF8", VA = "0x1403FF8")]
		public Vector3 InterpolateVolumePosition(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x1404408", Offset = "0x1404408", VA = "0x1404408")]
		public Vector3 InterpolateVolumeDirection(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x140464C", Offset = "0x140464C", VA = "0x140464C")]
		public Vector3 InterpolateVolumeUp(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x1404990", Offset = "0x1404990", VA = "0x1404990")]
		public float GetCrossLength(float pathF)
		{
			return default(float);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x1404E48", Offset = "0x1404E48", VA = "0x1404E48")]
		public float CrossFToDistance(float f, float crossF, CurvyClamping crossClamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1404E88", Offset = "0x1404E88", VA = "0x1404E88")]
		public float CrossDistanceToF(float f, float distance, CurvyClamping crossClamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1404BC0", Offset = "0x1404BC0", VA = "0x1404BC0")]
		public void GetSegmentIndices(float pathF, out int s0Index, out int s1Index, out float frag)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x1404ECC", Offset = "0x1404ECC", VA = "0x1404ECC")]
		public int GetSegmentIndex(int segment)
		{
			return default(int);
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1404EF4", Offset = "0x1404EF4", VA = "0x1404EF4")]
		public int GetCrossFIndex(float crossF, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x1404FC8", Offset = "0x1404FC8", VA = "0x1404FC8")]
		public int GetVertexIndex(float pathF, out float pathFrag)
		{
			return default(int);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x1403FC4", Offset = "0x1403FC4", VA = "0x1403FC4")]
		public int GetVertexIndex(float pathF, float crossF, out float pathFrag, out float crossFrag)
		{
			return default(int);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1404FFC", Offset = "0x1404FFC", VA = "0x1404FFC")]
		public Vector3[] GetSegmentVertices(params int[] segmentIndices)
		{
			return null;
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1404C70", Offset = "0x1404C70", VA = "0x1404C70")]
		private float calcSegmentLength(int segmentIndex)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x6F6474", Offset = "0x6F6474")]
	public class CGBounds : CGData
	{
		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		protected Bounds? mBounds;

		[Token(Token = "0x17000181")]
		public Bounds Bounds
		{
			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x1D67390", Offset = "0x1D67390", VA = "0x1D67390")]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x1D67418", Offset = "0x1D67418", VA = "0x1D67418")]
			set
			{
			}
		}

		[Token(Token = "0x17000182")]
		public float Depth
		{
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x1D6753C", Offset = "0x1D6753C", VA = "0x1D6753C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x1D675A4", Offset = "0x1D675A4", VA = "0x1D675A4")]
		public CGBounds()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x1D675B4", Offset = "0x1D675B4", VA = "0x1D675B4")]
		public CGBounds(Bounds bounds)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x1D67600", Offset = "0x1D67600", VA = "0x1D67600")]
		public CGBounds(CGBounds source)
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x1D676D0", Offset = "0x1D676D0", VA = "0x1D676D0", Slot = "6")]
		public virtual void RecalculateBounds()
		{
		}

		[Token(Token = "0x60007DB")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x1D67704", Offset = "0x1D67704", VA = "0x1D67704")]
		public static void Copy(CGBounds dest, CGBounds source)
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class CGVSubMesh : CGData
	{
		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int[] Triangles;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material Material;

		[Token(Token = "0x17000183")]
		public override int Count
		{
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x1402C5C", Offset = "0x1402C5C", VA = "0x1402C5C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x1402518", Offset = "0x1402518", VA = "0x1402518")]
		public CGVSubMesh([Optional] Material material)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x14004E4", Offset = "0x14004E4", VA = "0x14004E4")]
		public CGVSubMesh(int[] triangles, [Optional] Material material)
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1402C7C", Offset = "0x1402C7C", VA = "0x1402C7C")]
		public CGVSubMesh(int triangleCount, [Optional] Material material)
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x13FFD20", Offset = "0x13FFD20", VA = "0x13FFD20")]
		public CGVSubMesh(CGVSubMesh source)
		{
		}

		[Token(Token = "0x60007E2")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1402D0C", Offset = "0x1402D0C", VA = "0x1402D0C")]
		public static CGVSubMesh Get(CGVSubMesh data, int triangleCount, [Optional] Material material)
		{
			return null;
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x1402DB8", Offset = "0x1402DB8", VA = "0x1402DB8")]
		public void ShiftIndices(int offset, int startIndex = 0)
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x14015B0", Offset = "0x14015B0", VA = "0x14015B0")]
		public void Add(CGVSubMesh other, int shiftIndexOffset = 0)
		{
		}
	}
	[Token(Token = "0x20000FD")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x6F64B4", Offset = "0x6F64B4")]
	public class CGVMesh : CGBounds
	{
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3[] Vertex;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector2[] UV;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2[] UV2;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3[] Normal;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector4[] Tangents;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public CGVSubMesh[] SubMeshes;

		[Token(Token = "0x17000184")]
		public override int Count
		{
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x13FF4BC", Offset = "0x13FF4BC", VA = "0x13FF4BC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000185")]
		public bool HasUV
		{
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x13FF4DC", Offset = "0x13FF4DC", VA = "0x13FF4DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000186")]
		public bool HasUV2
		{
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x13FF504", Offset = "0x13FF504", VA = "0x13FF504")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000187")]
		public bool HasNormals
		{
			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x13FF52C", Offset = "0x13FF52C", VA = "0x13FF52C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000188")]
		public bool HasTangents
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x13FF554", Offset = "0x13FF554", VA = "0x13FF554")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000189")]
		public int TriangleCount
		{
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x13FF57C", Offset = "0x13FF57C", VA = "0x13FF57C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x13FF61C", Offset = "0x13FF61C", VA = "0x13FF61C")]
		public CGVMesh()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x13FF64C", Offset = "0x13FF64C", VA = "0x13FF64C")]
		public CGVMesh(int vertexCount, bool addUV = false, bool addUV2 = false, bool addNormals = false, bool addTangents = false)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x13FF7BC", Offset = "0x13FF7BC", VA = "0x13FF7BC")]
		public CGVMesh(CGVolume volume)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x13FF83C", Offset = "0x13FF83C", VA = "0x13FF83C")]
		public CGVMesh(CGVolume volume, IntRegion subset)
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x13FF96C", Offset = "0x13FF96C", VA = "0x13FF96C")]
		public CGVMesh(CGVMesh source)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x13FFE20", Offset = "0x13FFE20", VA = "0x13FFE20")]
		public CGVMesh(CGMeshProperties meshProperties)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x13FFF10", Offset = "0x13FFF10", VA = "0x13FFF10")]
		public CGVMesh(Mesh source, Material[] materials, Matrix4x4 trsMatrix)
		{
		}

		[Token(Token = "0x60007F3")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x14008EC", Offset = "0x14008EC", VA = "0x14008EC")]
		public static CGVMesh Get(CGVMesh data, CGVolume source, bool addUV, bool reverseNormals)
		{
			return null;
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1400974", Offset = "0x1400974", VA = "0x1400974")]
		public static CGVMesh Get(CGVMesh data, CGVolume source, IntRegion subset, bool addUV, bool reverseNormals)
		{
			return null;
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x1400DFC", Offset = "0x1400DFC", VA = "0x1400DFC")]
		public void SetSubMeshCount(int count)
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x1400E60", Offset = "0x1400E60", VA = "0x1400E60")]
		public void AddSubMesh([Optional] CGVSubMesh submesh)
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x1400ED4", Offset = "0x1400ED4", VA = "0x1400ED4")]
		public void MergeVMesh(CGVMesh source)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x14016C4", Offset = "0x14016C4", VA = "0x14016C4")]
		public void MergeVMesh(CGVMesh source, Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x14019CC", Offset = "0x14019CC", VA = "0x14019CC")]
		public void MergeVMeshes(List<CGVMesh> vMeshes, int startIndex, int endIndex)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x1401070", Offset = "0x1401070", VA = "0x1401070")]
		private void MergeUVsNormalsAndTangents(CGVMesh source, int preMergeVertexCount)
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x1401444", Offset = "0x1401444", VA = "0x1401444")]
		public CGVSubMesh GetMaterialSubMesh(Material mat, bool createIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x14025A4", Offset = "0x14025A4", VA = "0x14025A4")]
		public Mesh AsMesh()
		{
			return null;
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x1402624", Offset = "0x1402624", VA = "0x1402624")]
		public void ToMesh(ref Mesh msh)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x1402818", Offset = "0x1402818", VA = "0x1402818")]
		public Material[] GetMaterials()
		{
			return null;
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x1402940", Offset = "0x1402940", VA = "0x1402940", Slot = "6")]
		public override void RecalculateBounds()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x1402C34", Offset = "0x1402C34", VA = "0x1402C34")]
		public void RecalculateUV2()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x1400524", Offset = "0x1400524", VA = "0x1400524")]
		public void TRS(Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x6000803")]
		private void copyData<T>(ref T[] src, ref T[] dst, int currentSize, int extraSize)
		{
		}
	}
	[Token(Token = "0x20000FE")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x6F64F4", Offset = "0x6F64F4")]
	public class CGGameObject : CGBounds
	{
		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject Object;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 Translate;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 Rotate;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 Scale;

		[Token(Token = "0x1700018A")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x1D693C0", Offset = "0x1D693C0", VA = "0x1D693C0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x1D694D0", Offset = "0x1D694D0", VA = "0x1D694D0")]
		public CGGameObject()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x1D6956C", Offset = "0x1D6956C", VA = "0x1D6956C")]
		public CGGameObject(CGGameObjectProperties properties)
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x1D69790", Offset = "0x1D69790", VA = "0x1D69790")]
		public CGGameObject(GameObject obj)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1D69630", Offset = "0x1D69630", VA = "0x1D69630")]
		public CGGameObject(GameObject obj, Vector3 translate, Vector3 rotate, Vector3 scale)
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x1D69874", Offset = "0x1D69874", VA = "0x1D69874")]
		public CGGameObject(CGGameObject source)
		{
		}

		[Token(Token = "0x600080A")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1D69994", Offset = "0x1D69994", VA = "0x1D69994")]
		public static CGGameObject Get(CGGameObject data, GameObject obj, Vector3 translate, Vector3 rotate, Vector3 scale)
		{
			return null;
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1D69ADC", Offset = "0x1D69ADC", VA = "0x1D69ADC", Slot = "6")]
		public override void RecalculateBounds()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x6F6528", Offset = "0x6F6528")]
	public class CGSpots : CGData
	{
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public CGSpot[] Points;

		[Token(Token = "0x1700018B")]
		public override int Count
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x13FE76C", Offset = "0x13FE76C", VA = "0x13FE76C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x13FE78C", Offset = "0x13FE78C", VA = "0x13FE78C")]
		public CGSpots()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x13FE804", Offset = "0x13FE804", VA = "0x13FE804")]
		public CGSpots(params CGSpot[] points)
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x13FE830", Offset = "0x13FE830", VA = "0x13FE830")]
		public CGSpots(params List<CGSpot>[] lists)
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x13FE9A8", Offset = "0x13FE9A8", VA = "0x13FE9A8")]
		public CGSpots(CGSpots source)
		{
		}

		[Token(Token = "0x6000812")]
		public override T Clone<T>()
		{
			return null;
		}
	}
	[Token(Token = "0x2000100")]
	public class CGDataRequestParameter
	{
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1D68E18", Offset = "0x1D68E18", VA = "0x1D68E18")]
		public static implicit operator bool(CGDataRequestParameter a)
		{
			return default(bool);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1D68C30", Offset = "0x1D68C30", VA = "0x1D68C30")]
		public CGDataRequestParameter()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class CGDataRequestMetaCGOptions : CGDataRequestParameter
	{
		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool CheckHardEdges;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public bool CheckMaterialID;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public bool IncludeControlPoints;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		public bool CheckExtendedUV;

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1D68BF8", Offset = "0x1D68BF8", VA = "0x1D68BF8")]
		public CGDataRequestMetaCGOptions(bool checkEdges, bool checkMaterials, bool includeCP, bool extendedUV)
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x1D68C38", Offset = "0x1D68C38", VA = "0x1D68C38", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x1D68D58", Offset = "0x1D68D58", VA = "0x1D68D58", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000102")]
	public class CGDataRequestShapeRasterization : CGDataRequestRasterization
	{
		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float[] PathF;

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1D69224", Offset = "0x1D69224", VA = "0x1D69224")]
		public CGDataRequestShapeRasterization(float[] pathF, float start, float rasterizedRelativeLength, int resolution, float angle, ModeEnum mode = ModeEnum.Even)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1D69278", Offset = "0x1D69278", VA = "0x1D69278", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x1D6937C", Offset = "0x1D6937C", VA = "0x1D6937C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000103")]
	public class CGDataRequestRasterization : CGDataRequestParameter
	{
		[Token(Token = "0x200017C")]
		public enum ModeEnum
		{
			[Token(Token = "0x40005F4")]
			Even,
			[Token(Token = "0x40005F5")]
			Optimized
		}

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float Start;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float RasterizedRelativeLength;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Resolution;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6FCE0C", Offset = "0x6FCE0C")]
		public float SplineAbsoluteLength;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleThreshold;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ModeEnum Mode;

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x1D68E24", Offset = "0x1D68E24", VA = "0x1D68E24")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x703A44", Offset = "0x703A44")]
		public CGDataRequestRasterization(float start, float rasterizedRelativeLength, int resolution, float splineAbsoluteLength, float angle, ModeEnum mode = ModeEnum.Even)
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x1D68EF4", Offset = "0x1D68EF4", VA = "0x1D68EF4")]
		public CGDataRequestRasterization(float start, float rasterizedRelativeLength, int resolution, float angle, ModeEnum mode = ModeEnum.Even)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1D68FBC", Offset = "0x1D68FBC", VA = "0x1D68FBC")]
		public CGDataRequestRasterization(CGDataRequestRasterization source)
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1D69050", Offset = "0x1D69050", VA = "0x1D69050", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x1D69154", Offset = "0x1D69154", VA = "0x1D69154", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000104")]
	public interface INoProcessing
	{
	}
	[Token(Token = "0x2000105")]
	public interface IExternalInput
	{
		[Token(Token = "0x1700018C")]
		bool SupportsIPE
		{
			[Token(Token = "0x6000820")]
			get;
		}
	}
	[Token(Token = "0x2000106")]
	public interface IOnRequestProcessing
	{
		[Token(Token = "0x6000821")]
		CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests);
	}
	[Token(Token = "0x2000107")]
	public interface IPathProvider
	{
		[Token(Token = "0x1700018D")]
		bool PathIsClosed
		{
			[Token(Token = "0x6000822")]
			get;
		}
	}
	[Token(Token = "0x2000108")]
	public interface IOnRequestPath : IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x1700018E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x704438", Offset = "0x704438")]
		float PathLength
		{
			[Token(Token = "0x6000823")]
			get;
		}
	}
	[Token(Token = "0x2000109")]
	public interface ICGResourceLoader
	{
		[Token(Token = "0x6000824")]
		UnityEngine.Component Create(CGModule cgModule, string context);

		[Token(Token = "0x6000825")]
		void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill);
	}
	[Token(Token = "0x200010A")]
	public interface ICGResourceCollection
	{
		[Token(Token = "0x1700018F")]
		int Count
		{
			[Token(Token = "0x6000826")]
			get;
		}

		[Token(Token = "0x17000190")]
		UnityEngine.Component[] ItemsArray
		{
			[Token(Token = "0x6000827")]
			get;
		}
	}
	[Token(Token = "0x200010B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F6568", Offset = "0x6F6568")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F6568", Offset = "0x6F6568")]
	public class CGMeshResource : DuplicateEditorMesh, IPoolable
	{
		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private MeshRenderer mRenderer;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Collider mCollider;

		[Token(Token = "0x17000191")]
		public MeshRenderer Renderer
		{
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x1D6B31C", Offset = "0x1D6B31C", VA = "0x1D6B31C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000192")]
		public Collider Collider
		{
			[Token(Token = "0x6000829")]
			[Address(RVA = "0x1D6B3D8", Offset = "0x1D6B3D8", VA = "0x1D6B3D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x1D6B494", Offset = "0x1D6B494", VA = "0x1D6B494")]
		public Mesh Prepare()
		{
			return null;
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x1D6B4FC", Offset = "0x1D6B4FC", VA = "0x1D6B4FC")]
		public bool ColliderMatches(CGColliderEnum type)
		{
			return default(bool);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x1D6B690", Offset = "0x1D6B690", VA = "0x1D6B690")]
		public void RemoveCollider()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x1D6B7A8", Offset = "0x1D6B7A8", VA = "0x1D6B7A8")]
		public bool UpdateCollider(CGColliderEnum mode, bool convex, PhysicMaterial material, MeshColliderCookingOptions meshCookingOptions = MeshColliderCookingOptions.CookForFasterSimulation | MeshColliderCookingOptions.EnableMeshCleaning | MeshColliderCookingOptions.WeldColocatedVertices)
		{
			return default(bool);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x1D6BF60", Offset = "0x1D6BF60", VA = "0x1D6BF60", Slot = "5")]
		public void OnBeforePush()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x1D6BF64", Offset = "0x1D6BF64", VA = "0x1D6BF64", Slot = "6")]
		public void OnAfterPop()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x1D6BF68", Offset = "0x1D6BF68", VA = "0x1D6BF68")]
		public CGMeshResource()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010C")]
	public class CGMeshResourceCollection : ICGResourceCollection
	{
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public List<CGMeshResource> Items;

		[Token(Token = "0x17000193")]
		public int Count
		{
			[Token(Token = "0x6000831")]
			[Address(RVA = "0x1D6BF70", Offset = "0x1D6BF70", VA = "0x1D6BF70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000194")]
		public UnityEngine.Component[] ItemsArray
		{
			[Token(Token = "0x6000832")]
			[Address(RVA = "0x1D6BFC8", Offset = "0x1D6BFC8", VA = "0x1D6BFC8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x1D6C034", Offset = "0x1D6C034", VA = "0x1D6C034")]
		public CGMeshResourceCollection()
		{
		}
	}
	[Token(Token = "0x200010D")]
	[ExecuteInEditMode]
	public class CGModule : DTVersionedMonoBehaviour
	{
		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6FCE40", Offset = "0x6FCE40")]
		[SerializeField]
		private CurvyCGEvent m_OnBeforeRefresh;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6FCE98", Offset = "0x6FCE98")]
		[SerializeField]
		private CurvyCGEvent m_OnRefresh;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private string m_ModuleName;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[HideInInspector]
		private bool m_Active;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6FCF40", Offset = "0x6FCF40")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x6FCF40", Offset = "0x6FCF40")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x6FCF40", Offset = "0x6FCF40")]
		[SerializeField]
		private bool m_RandomizeSeed;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private int m_Seed;

		[NonSerialized]
		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public List<string> UIMessages;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CurvyGenerator mGenerator;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[HideInInspector]
		private int m_UniqueID;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD054", Offset = "0x6FD054")]
		private bool <CircularReferenceError>k__BackingField;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal int SortAncestors;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public CGModuleProperties Properties;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[HideInInspector]
		public List<CGModuleLink> InputLinks;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public List<CGModuleLink> OutputLinks;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD094", Offset = "0x6FD094")]
		private Dictionary<string, CGModuleInputSlot> <InputByName>k__BackingField;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD0A4", Offset = "0x6FD0A4")]
		private Dictionary<string, CGModuleOutputSlot> <OutputByName>k__BackingField;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD0B4", Offset = "0x6FD0B4")]
		private List<CGModuleInputSlot> <Input>k__BackingField;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD0C4", Offset = "0x6FD0C4")]
		private List<CGModuleOutputSlot> <Output>k__BackingField;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private ModuleInfoAttribute mInfo;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool mDirty;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool mInitialized;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool mIsConfiguredInternal;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		private bool mStateChangeDirty;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool mLastIsConfiguredState;

		[Token(Token = "0x17000195")]
		public CurvyCGEvent OnBeforeRefresh
		{
			[Token(Token = "0x6000834")]
			[Address(RVA = "0x1D6C4D0", Offset = "0x1D6C4D0", VA = "0x1D6C4D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x1D6C4D8", Offset = "0x1D6C4D8", VA = "0x1D6C4D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000196")]
		public CurvyCGEvent OnRefresh
		{
			[Token(Token = "0x6000836")]
			[Address(RVA = "0x1D6C4EC", Offset = "0x1D6C4EC", VA = "0x1D6C4EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x1D6C4F4", Offset = "0x1D6C4F4", VA = "0x1D6C4F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000197")]
		public string ModuleName
		{
			[Token(Token = "0x600083A")]
			[Address(RVA = "0x1D6C5E8", Offset = "0x1D6C5E8", VA = "0x1D6C5E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600083B")]
			[Address(RVA = "0x1D6C5F0", Offset = "0x1D6C5F0", VA = "0x1D6C5F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000198")]
		public bool Active
		{
			[Token(Token = "0x600083C")]
			[Address(RVA = "0x1D6C858", Offset = "0x1D6C858", VA = "0x1D6C858")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600083D")]
			[Address(RVA = "0x1D6C860", Offset = "0x1D6C860", VA = "0x1D6C860")]
			set
			{
			}
		}

		[Token(Token = "0x17000199")]
		public int Seed
		{
			[Token(Token = "0x600083E")]
			[Address(RVA = "0x1D6C9F0", Offset = "0x1D6C9F0", VA = "0x1D6C9F0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x1D6C9F8", Offset = "0x1D6C9F8", VA = "0x1D6C9F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700019A")]
		public bool RandomizeSeed
		{
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x1D6CA0C", Offset = "0x1D6CA0C", VA = "0x1D6CA0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x1D6CA14", Offset = "0x1D6CA14", VA = "0x1D6CA14")]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		public CurvyGenerator Generator
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x1D6CA30", Offset = "0x1D6CA30", VA = "0x1D6CA30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019C")]
		public int UniqueID
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x1D6CA38", Offset = "0x1D6CA38", VA = "0x1D6CA38")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700019D")]
		public bool CircularReferenceError
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x1D6CA40", Offset = "0x1D6CA40", VA = "0x1D6CA40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703A78", Offset = "0x703A78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x1D6CA48", Offset = "0x1D6CA48", VA = "0x1D6CA48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703A88", Offset = "0x703A88")]
			set
			{
			}
		}

		[Token(Token = "0x1700019E")]
		public Dictionary<string, CGModuleInputSlot> InputByName
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x1D6CA50", Offset = "0x1D6CA50", VA = "0x1D6CA50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703A98", Offset = "0x703A98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x1D6CA58", Offset = "0x1D6CA58", VA = "0x1D6CA58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703AA8", Offset = "0x703AA8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700019F")]
		public Dictionary<string, CGModuleOutputSlot> OutputByName
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x1D6CA60", Offset = "0x1D6CA60", VA = "0x1D6CA60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703AB8", Offset = "0x703AB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x1D6CA68", Offset = "0x1D6CA68", VA = "0x1D6CA68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703AC8", Offset = "0x703AC8")]
			private set
			{
			}
		}

		[Token(Token = "0x170001A0")]
		public List<CGModuleInputSlot> Input
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x1D6CA70", Offset = "0x1D6CA70", VA = "0x1D6CA70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703AD8", Offset = "0x703AD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x1D6CA78", Offset = "0x1D6CA78", VA = "0x1D6CA78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703AE8", Offset = "0x703AE8")]
			private set
			{
			}
		}

		[Token(Token = "0x170001A1")]
		public List<CGModuleOutputSlot> Output
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x1D6CA80", Offset = "0x1D6CA80", VA = "0x1D6CA80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703AF8", Offset = "0x703AF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x1D6CA88", Offset = "0x1D6CA88", VA = "0x1D6CA88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703B08", Offset = "0x703B08")]
			private set
			{
			}
		}

		[Token(Token = "0x170001A2")]
		public ModuleInfoAttribute Info
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x1D6CA90", Offset = "0x1D6CA90", VA = "0x1D6CA90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A3")]
		public bool Dirty
		{
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x1D6CBE0", Offset = "0x1D6CBE0", VA = "0x1D6CBE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000850")]
			[Address(RVA = "0x1D6C8B4", Offset = "0x1D6C8B4", VA = "0x1D6C8B4")]
			set
			{
			}
		}

		[Token(Token = "0x170001A4")]
		public virtual bool IsConfigured
		{
			[Token(Token = "0x6000857")]
			[Address(RVA = "0x1D6EB1C", Offset = "0x1D6EB1C", VA = "0x1D6EB1C", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A5")]
		public virtual bool IsInitialized
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0x1D6F03C", Offset = "0x1D6F03C", VA = "0x1D6F03C", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x1D6C508", Offset = "0x1D6C508", VA = "0x1D6C508")]
		protected CurvyCGEventArgs OnBeforeRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x1D6C578", Offset = "0x1D6C578", VA = "0x1D6C578")]
		protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x1D6CE1C", Offset = "0x1D6CE1C", VA = "0x1D6CE1C", Slot = "5")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x1D6CE88", Offset = "0x1D6CE88", VA = "0x1D6CE88", Slot = "6")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x1D6CF34", Offset = "0x1D6CF34", VA = "0x1D6CF34")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x1D6D738", Offset = "0x1D6D738", VA = "0x1D6D738", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x1D6D73C", Offset = "0x1D6D73C", VA = "0x1D6D73C", Slot = "8")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x1D6EB14", Offset = "0x1D6EB14", VA = "0x1D6EB14")]
		private void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x1D6F044", Offset = "0x1D6F044", VA = "0x1D6F044", Slot = "11")]
		public virtual void Refresh()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x1D6F0B0", Offset = "0x1D6F0B0", VA = "0x1D6F0B0", Slot = "12")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x1D6F228", Offset = "0x1D6F228", VA = "0x1D6F228")]
		public void ReInitializeLinkedSlots()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x1D6F35C", Offset = "0x1D6F35C", VA = "0x1D6F35C", Slot = "13")]
		public virtual void OnStateChange()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x1D6F490", Offset = "0x1D6F490", VA = "0x1D6F490", Slot = "14")]
		public virtual void OnTemplateCreated()
		{
		}

		[Token(Token = "0x600085E")]
		protected static T GetRequestParameter<T>(ref CGDataRequestParameter[] requests) where T : CGDataRequestParameter
		{
			return null;
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x1D6F494", Offset = "0x1D6F494", VA = "0x1D6F494")]
		protected static void RemoveRequestParameter(ref CGDataRequestParameter[] requests, CGDataRequestParameter request)
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x1D6F56C", Offset = "0x1D6F56C", VA = "0x1D6F56C")]
		public CGModuleLink GetOutputLink(CGModuleOutputSlot outSlot, CGModuleInputSlot inSlot)
		{
			return null;
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x1D6F648", Offset = "0x1D6F648", VA = "0x1D6F648")]
		public List<CGModuleLink> GetOutputLinks(CGModuleOutputSlot outSlot)
		{
			return null;
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x1D6F778", Offset = "0x1D6F778", VA = "0x1D6F778")]
		public CGModuleLink GetInputLink(CGModuleInputSlot inSlot, CGModuleOutputSlot outSlot)
		{
			return null;
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x1D6F780", Offset = "0x1D6F780", VA = "0x1D6F780")]
		public List<CGModuleLink> GetInputLinks(CGModuleInputSlot inSlot)
		{
			return null;
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x1D6F574", Offset = "0x1D6F574", VA = "0x1D6F574")]
		private static CGModuleLink GetLink(List<CGModuleLink> lst, CGModuleSlot source, CGModuleSlot target)
		{
			return null;
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x1D6F650", Offset = "0x1D6F650", VA = "0x1D6F650")]
		private static List<CGModuleLink> GetLinks(List<CGModuleLink> lst, CGModuleSlot source)
		{
			return null;
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x1D6F958", Offset = "0x1D6F958", VA = "0x1D6F958")]
		public CGModule CopyTo(CurvyGenerator targetGenerator)
		{
			return null;
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x1D6FB14", Offset = "0x1D6FB14", VA = "0x1D6FB14")]
		public UnityEngine.Component AddManagedResource(string resourceName, string context = "", int index = -1)
		{
			return null;
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x1D6E318", Offset = "0x1D6E318", VA = "0x1D6E318")]
		public void DeleteManagedResource(string resourceName, UnityEngine.Component res, string context = "", bool dontUsePool = false)
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x1D70674", Offset = "0x1D70674", VA = "0x1D70674")]
		public bool IsManagedResource(UnityEngine.Component res)
		{
			return default(bool);
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x1D6FF44", Offset = "0x1D6FF44", VA = "0x1D6FF44")]
		protected void RenameResource(string resourceName, UnityEngine.Component resource, int index = -1)
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x1D7077C", Offset = "0x1D7077C", VA = "0x1D7077C")]
		protected PrefabPool GetPrefabPool(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x1D7091C", Offset = "0x1D7091C", VA = "0x1D7091C")]
		public List<IPool> GetAllPrefabPools()
		{
			return null;
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x1D70A14", Offset = "0x1D70A14", VA = "0x1D70A14")]
		public void DeleteAllPrefabPools()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x1D70B0C", Offset = "0x1D70B0C", VA = "0x1D70B0C")]
		public void Delete()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x1D70BBC", Offset = "0x1D70BBC", VA = "0x1D70BBC")]
		public CGModuleInputSlot GetInputSlot(string name)
		{
			return null;
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x1D6E3F8", Offset = "0x1D6E3F8", VA = "0x1D6E3F8")]
		public List<CGModuleInputSlot> GetInputSlots([Optional] Type filterType)
		{
			return null;
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x1D68964", Offset = "0x1D68964", VA = "0x1D68964")]
		public CGModuleOutputSlot GetOutputSlot(string name)
		{
			return null;
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x1D6E6C8", Offset = "0x1D6E6C8", VA = "0x1D6E6C8")]
		public List<CGModuleOutputSlot> GetOutputSlots([Optional] Type filterType)
		{
			return null;
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x1D6DD34", Offset = "0x1D6DD34", VA = "0x1D6DD34")]
		public bool GetManagedResources(out List<UnityEngine.Component> components, out List<string> componentNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x1D6FAD4", Offset = "0x1D6FAD4", VA = "0x1D6FAD4")]
		public int SetUniqueIdINTERNAL()
		{
			return default(int);
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x1D70C68", Offset = "0x1D70C68", VA = "0x1D70C68")]
		internal void initializeSort()
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x1D70E30", Offset = "0x1D70E30", VA = "0x1D70E30")]
		internal List<CGModule> decrementChilds()
		{
			return null;
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x1D7109C", Offset = "0x1D7109C", VA = "0x1D7109C")]
		internal void doRefresh()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x1D71228", Offset = "0x1D71228", VA = "0x1D71228")]
		private static void setSeed(int seed)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x1D6CACC", Offset = "0x1D6CACC", VA = "0x1D6CACC")]
		internal ModuleInfoAttribute getInfo()
		{
			return null;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x1D71230", Offset = "0x1D71230", VA = "0x1D71230")]
		private bool usesRandom()
		{
			return default(bool);
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x1D6D180", Offset = "0x1D6D180", VA = "0x1D6D180")]
		private void loadSlots()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x1D71278", Offset = "0x1D71278", VA = "0x1D71278")]
		private SlotInfo getSlotInfo(FieldInfo f)
		{
			return null;
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x1D6DB30", Offset = "0x1D6DB30", VA = "0x1D6DB30")]
		private void setTreeDirtyStateChange()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x1D6CBE8", Offset = "0x1D6CBE8", VA = "0x1D6CBE8")]
		private void setTreeDirtyState()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x1D718CC", Offset = "0x1D718CC", VA = "0x1D718CC")]
		public void checkOnStateChangedINTERNAL()
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x1D6C638", Offset = "0x1D6C638", VA = "0x1D6C638")]
		public void renameManagedResourcesINTERNAL()
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x1D71904", Offset = "0x1D71904", VA = "0x1D71904")]
		public CGModule()
		{
		}
	}
	[Token(Token = "0x200010E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6F6614", Offset = "0x6F6614")]
	public sealed class ModuleInfoAttribute : Attribute, IComparable
	{
		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly string MenuName;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string ModuleName;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Description;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool UsesRandom;

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x1408E70", Offset = "0x1408E70", VA = "0x1408E70")]
		public ModuleInfoAttribute(string name)
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x1408E9C", Offset = "0x1408E9C", VA = "0x1408E9C", Slot = "7")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200010F")]
	public class CGModuleProperties
	{
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Rect Dimensions;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float MinWidth;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float LabelWidth;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color BackgroundColor;

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x1D71AEC", Offset = "0x1D71AEC", VA = "0x1D71AEC")]
		public CGModuleProperties()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000110")]
	public class CGModuleLink
	{
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private int m_ModuleID;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private string m_SlotName;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int m_TargetModuleID;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private string m_TargetSlotName;

		[Token(Token = "0x170001A6")]
		public int ModuleID
		{
			[Token(Token = "0x6000885")]
			[Address(RVA = "0x1D72C10", Offset = "0x1D72C10", VA = "0x1D72C10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A7")]
		public string SlotName
		{
			[Token(Token = "0x6000886")]
			[Address(RVA = "0x1D72C18", Offset = "0x1D72C18", VA = "0x1D72C18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A8")]
		public int TargetModuleID
		{
			[Token(Token = "0x6000887")]
			[Address(RVA = "0x1D72C20", Offset = "0x1D72C20", VA = "0x1D72C20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A9")]
		public string TargetSlotName
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x1D72C28", Offset = "0x1D72C28", VA = "0x1D72C28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x1D72C30", Offset = "0x1D72C30", VA = "0x1D72C30")]
		public CGModuleLink(int sourceID, string sourceSlotName, int targetID, string targetSlotName)
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x1D71F64", Offset = "0x1D71F64", VA = "0x1D71F64")]
		public CGModuleLink(CGModuleSlot source, CGModuleSlot target)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x1D72CDC", Offset = "0x1D72CDC", VA = "0x1D72CDC")]
		public bool IsSame(CGModuleLink o)
		{
			return default(bool);
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x1D6F788", Offset = "0x1D6F788", VA = "0x1D6F788")]
		public bool IsSame(CGModuleSlot source, CGModuleSlot target)
		{
			return default(bool);
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x1D72D4C", Offset = "0x1D72D4C", VA = "0x1D72D4C")]
		public bool IsTo(CGModuleSlot s)
		{
			return default(bool);
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x1D6F8B4", Offset = "0x1D6F8B4", VA = "0x1D6F8B4")]
		public bool IsFrom(CGModuleSlot s)
		{
			return default(bool);
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x1D72DF0", Offset = "0x1D72DF0", VA = "0x1D72DF0")]
		public bool IsUsing(CGModule module)
		{
			return default(bool);
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x1D72E30", Offset = "0x1D72E30", VA = "0x1D72E30")]
		public bool IsBetween(CGModuleSlot one, CGModuleSlot another)
		{
			return default(bool);
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x1D72E9C", Offset = "0x1D72E9C", VA = "0x1D72E9C")]
		public void SetModuleIDIINTERNAL(int moduleID, int targetModuleID)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x1D71F58", Offset = "0x1D71F58", VA = "0x1D71F58")]
		public static implicit operator bool(CGModuleLink a)
		{
			return default(bool);
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x1D72EA8", Offset = "0x1D72EA8", VA = "0x1D72EA8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000111")]
	public class CGModuleSlot
	{
		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD114", Offset = "0x6FD114")]
		private CGModule <Module>k__BackingField;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD124", Offset = "0x6FD124")]
		private SlotInfo <Info>k__BackingField;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD134", Offset = "0x6FD134")]
		private Vector2 <Origin>k__BackingField;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD144", Offset = "0x6FD144")]
		private Rect <DropZone>k__BackingField;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected List<CGModuleSlot> mLinkedSlots;

		[Token(Token = "0x170001AA")]
		public CGModule Module
		{
			[Token(Token = "0x6000894")]
			[Address(RVA = "0x1D73A68", Offset = "0x1D73A68", VA = "0x1D73A68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703B18", Offset = "0x703B18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x1D73A70", Offset = "0x1D73A70", VA = "0x1D73A70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703B28", Offset = "0x703B28")]
			internal set
			{
			}
		}

		[Token(Token = "0x170001AB")]
		public SlotInfo Info
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x1D73A78", Offset = "0x1D73A78", VA = "0x1D73A78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703B38", Offset = "0x703B38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000897")]
			[Address(RVA = "0x1D73A80", Offset = "0x1D73A80", VA = "0x1D73A80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703B48", Offset = "0x703B48")]
			internal set
			{
			}
		}

		[Token(Token = "0x170001AC")]
		public Vector2 Origin
		{
			[Token(Token = "0x6000898")]
			[Address(RVA = "0x1D73A88", Offset = "0x1D73A88", VA = "0x1D73A88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703B58", Offset = "0x703B58")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000899")]
			[Address(RVA = "0x1D73A9C", Offset = "0x1D73A9C", VA = "0x1D73A9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703B68", Offset = "0x703B68")]
			set
			{
			}
		}

		[Token(Token = "0x170001AD")]
		public Rect DropZone
		{
			[Token(Token = "0x600089A")]
			[Address(RVA = "0x1D73AA8", Offset = "0x1D73AA8", VA = "0x1D73AA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703B78", Offset = "0x703B78")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x1D73AB8", Offset = "0x1D73AB8", VA = "0x1D73AB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703B88", Offset = "0x703B88")]
			set
			{
			}
		}

		[Token(Token = "0x170001AE")]
		public bool IsLinked
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x1D6EE68", Offset = "0x1D6EE68", VA = "0x1D6EE68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001AF")]
		public bool IsLinkedAndConfigured
		{
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x1D73AC8", Offset = "0x1D73AC8", VA = "0x1D73AC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001B0")]
		public IOnRequestProcessing OnRequestModule
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0x1D729D0", Offset = "0x1D729D0", VA = "0x1D729D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B1")]
		public IOnRequestPath OnRequestPathModule
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0x1D73BCC", Offset = "0x1D73BCC", VA = "0x1D73BCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B2")]
		public IPathProvider PathProvider
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x1D73C28", Offset = "0x1D73C28", VA = "0x1D73C28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B3")]
		public IExternalInput ExternalInput
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x1D73C84", Offset = "0x1D73C84", VA = "0x1D73C84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B4")]
		public List<CGModuleSlot> LinkedSlots
		{
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x1D70D8C", Offset = "0x1D70D8C", VA = "0x1D70D8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B5")]
		public int Count
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x1D6EFDC", Offset = "0x1D6EFDC", VA = "0x1D6EFDC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001B6")]
		public string Name
		{
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x1D72C7C", Offset = "0x1D72C7C", VA = "0x1D72C7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x1D71B44", Offset = "0x1D71B44", VA = "0x1D71B44")]
		public CGModuleSlot()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x1D723C0", Offset = "0x1D723C0", VA = "0x1D723C0")]
		public bool HasLinkTo(CGModuleSlot other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x1D717B4", Offset = "0x1D717B4", VA = "0x1D717B4")]
		public List<CGModule> GetLinkedModules()
		{
			return null;
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x1D72480", Offset = "0x1D72480", VA = "0x1D72480", Slot = "4")]
		public virtual void LinkTo(CGModuleSlot other)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x1D72794", Offset = "0x1D72794", VA = "0x1D72794", Slot = "5")]
		public virtual void UnlinkFrom(CGModuleSlot other)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x1D73CE0", Offset = "0x1D73CE0", VA = "0x1D73CE0", Slot = "6")]
		public virtual void UnlinkAll()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x1D6F34C", Offset = "0x1D6F34C", VA = "0x1D6F34C")]
		public void ReInitializeLinkedSlots()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x1D6E998", Offset = "0x1D6E998", VA = "0x1D6E998")]
		public void ReInitializeLinkedTargetModules()
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x1D71F54", Offset = "0x1D71F54", VA = "0x1D71F54", Slot = "7")]
		protected virtual void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x1D73CE4", Offset = "0x1D73CE4", VA = "0x1D73CE4")]
		public static implicit operator bool(CGModuleSlot a)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x1D73CF0", Offset = "0x1D73CF0", VA = "0x1D73CF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000112")]
	public class CGModuleInputSlot : CGModuleSlot
	{
		[Token(Token = "0x170001B7")]
		public InputSlotInfo InputInfo
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x1D6EDF4", Offset = "0x1D6EDF4", VA = "0x1D6EDF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x1D71B3C", Offset = "0x1D71B3C", VA = "0x1D71B3C")]
		public CGModuleInputSlot()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x1D71B4C", Offset = "0x1D71B4C", VA = "0x1D71B4C", Slot = "7")]
		protected override void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x1D72068", Offset = "0x1D72068", VA = "0x1D72068", Slot = "6")]
		public override void UnlinkAll()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x1D721CC", Offset = "0x1D721CC", VA = "0x1D721CC", Slot = "4")]
		public override void LinkTo(CGModuleSlot outputSlot)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x1D725B8", Offset = "0x1D725B8", VA = "0x1D725B8", Slot = "5")]
		public override void UnlinkFrom(CGModuleSlot outputSlot)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x1D6EEEC", Offset = "0x1D6EEEC", VA = "0x1D6EEEC")]
		public CGModuleOutputSlot SourceSlot(int index = 0)
		{
			return null;
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x1D728CC", Offset = "0x1D728CC", VA = "0x1D728CC")]
		public bool CanLinkTo(CGModuleOutputSlot source)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x1D72ABC", Offset = "0x1D72ABC", VA = "0x1D72ABC")]
		public static bool AreInputAndOutputSlotsCompatible(InputSlotInfo inputSlotInfo, bool inputSlotModuleIsOnRequest, OutputSlotInfo outputSlotInfo, bool outputSlotModuleIsOnRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x1D72B60", Offset = "0x1D72B60", VA = "0x1D72B60")]
		private CGModule SourceModule(int index)
		{
			return null;
		}

		[Token(Token = "0x60008BA")]
		public T GetData<T>(params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		[Token(Token = "0x60008BB")]
		public List<T> GetAllData<T>(params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		[Token(Token = "0x60008BC")]
		private CGData[] GetData<T>(int slotIndex, params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		[Token(Token = "0x60008BD")]
		private static CGData[] cloneData<T>(ref CGData[] source) where T : CGData
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000113")]
	public class CGModuleOutputSlot : CGModuleSlot
	{
		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public CGData[] Data;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CGDataRequestParameter[] LastRequestParameters;

		[Token(Token = "0x170001B8")]
		public OutputSlotInfo OutputInfo
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x1D72A2C", Offset = "0x1D72A2C", VA = "0x1D72A2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B9")]
		public bool HasData
		{
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x1D739B4", Offset = "0x1D739B4", VA = "0x1D739B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x1D73108", Offset = "0x1D73108", VA = "0x1D73108")]
		public CGModuleOutputSlot()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x1D73180", Offset = "0x1D73180", VA = "0x1D73180", Slot = "7")]
		protected override void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x1D73588", Offset = "0x1D73588", VA = "0x1D73588", Slot = "4")]
		public override void LinkTo(CGModuleSlot inputSlot)
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x1D737D8", Offset = "0x1D737D8", VA = "0x1D737D8", Slot = "5")]
		public override void UnlinkFrom(CGModuleSlot inputSlot)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x1D6F424", Offset = "0x1D6F424", VA = "0x1D6F424")]
		public void ClearData()
		{
		}

		[Token(Token = "0x60008C5")]
		public void SetData<T>(List<T> data) where T : CGData
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x1D739E0", Offset = "0x1D739E0", VA = "0x1D739E0")]
		public void SetData(params CGData[] data)
		{
		}

		[Token(Token = "0x60008C7")]
		public T GetData<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x60008C8")]
		public T[] GetAllData<T>() where T : CGData
		{
			return null;
		}
	}
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6F6628", Offset = "0x6F6628")]
	public class SlotInfo : Attribute, IComparable
	{
		[Token(Token = "0x200017D")]
		public enum SlotArrayType
		{
			[Token(Token = "0x40005F7")]
			Unknown,
			[Token(Token = "0x40005F8")]
			Normal,
			[Token(Token = "0x40005F9")]
			Hidden
		}

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly Type[] DataTypes;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string Name;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string displayName;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public string Tooltip;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Array;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SlotArrayType ArrayType;

		[Token(Token = "0x170001BA")]
		public string DisplayName
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x1BE42FC", Offset = "0x1BE42FC", VA = "0x1BE42FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x1BE4310", Offset = "0x1BE4310", VA = "0x1BE4310")]
			set
			{
			}
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x1BE3078", Offset = "0x1BE3078", VA = "0x1BE3078")]
		protected SlotInfo(string name, params Type[] type)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x1BE4318", Offset = "0x1BE4318", VA = "0x1BE4318")]
		protected SlotInfo(params Type[] type)
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x1BE4324", Offset = "0x1BE4324", VA = "0x1BE4324", Slot = "7")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6F663C", Offset = "0x6F663C")]
	public sealed class InputSlotInfo : SlotInfo
	{
		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool RequestDataOnly;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Optional;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool ModifiesData;

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x1408D08", Offset = "0x1408D08", VA = "0x1408D08")]
		public InputSlotInfo(string name, params Type[] type)
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x1408D10", Offset = "0x1408D10", VA = "0x1408D10")]
		public InputSlotInfo(params Type[] type)
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x1408D20", Offset = "0x1408D20", VA = "0x1408D20")]
		public bool IsValidFrom(Type outType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6F6668", Offset = "0x6F6668")]
	public class OutputSlotInfo : SlotInfo
	{
		[Token(Token = "0x170001BB")]
		public Type DataType
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x1BE2F5C", Offset = "0x1BE2F5C", VA = "0x1BE2F5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x1BE2F94", Offset = "0x1BE2F94", VA = "0x1BE2F94")]
		public OutputSlotInfo(Type type)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x1BE2FA0", Offset = "0x1BE2FA0", VA = "0x1BE2FA0")]
		public OutputSlotInfo(string name, Type type)
		{
		}
	}
	[Token(Token = "0x2000117")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6F6694", Offset = "0x6F6694")]
	public class ShapeOutputSlotInfo : OutputSlotInfo
	{
		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool OutputsVariableShape;

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x1BE4254", Offset = "0x1BE4254", VA = "0x1BE4254")]
		public ShapeOutputSlotInfo()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x1BE425C", Offset = "0x1BE425C", VA = "0x1BE425C")]
		public ShapeOutputSlotInfo(string name)
		{
		}
	}
	[Token(Token = "0x2000118")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6F66C0", Offset = "0x6F66C0")]
	public sealed class ResourceLoaderAttribute : Attribute
	{
		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly string ResourceName;

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x1BE30C4", Offset = "0x1BE30C4", VA = "0x1BE30C4")]
		public ResourceLoaderAttribute(string resName)
		{
		}
	}
	[Token(Token = "0x2000119")]
	public static class CGResourceHandler
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, ICGResourceLoader> Loader;

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x1D6FCC0", Offset = "0x1D6FCC0", VA = "0x1D6FCC0")]
		public static UnityEngine.Component CreateResource(CGModule module, string resName, string context)
		{
			return null;
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x1D7028C", Offset = "0x1D7028C", VA = "0x1D7028C")]
		public static void DestroyResource(CGModule module, string resName, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x1D756B8", Offset = "0x1D756B8", VA = "0x1D756B8")]
		private static void getLoaders()
		{
		}
	}
	[Token(Token = "0x200011A")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x6F66D4", Offset = "0x6F66D4")]
	public class CGSplineResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x13FDC20", Offset = "0x13FDC20", VA = "0x13FDC20", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x13FDE54", Offset = "0x13FDE54", VA = "0x13FDE54", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x13FDF08", Offset = "0x13FDF08", VA = "0x13FDF08")]
		public CGSplineResourceLoader()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x6F6708", Offset = "0x6F6708")]
	public class CGShapeResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x13FD9CC", Offset = "0x13FD9CC", VA = "0x13FD9CC", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x13FDB64", Offset = "0x13FDB64", VA = "0x13FDB64", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x13FDC18", Offset = "0x13FDC18", VA = "0x13FDC18")]
		public CGShapeResourceLoader()
		{
		}
	}
	[Token(Token = "0x200011C")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x6F673C", Offset = "0x6F673C")]
	public class CGMeshResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x1D6C0C4", Offset = "0x1D6C0C4", VA = "0x1D6C0C4", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x1D6C178", Offset = "0x1D6C178", VA = "0x1D6C178", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x1D6C4C8", Offset = "0x1D6C4C8", VA = "0x1D6C4C8")]
		public CGMeshResourceLoader()
		{
		}
	}
	[Token(Token = "0x200011D")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x6F6770", Offset = "0x6F6770")]
	public class CGGameObjectResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x1D6A704", Offset = "0x1D6A704", VA = "0x1D6A704", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x1D6A8C8", Offset = "0x1D6A8C8", VA = "0x1D6A8C8", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x1D6AB2C", Offset = "0x1D6AB2C", VA = "0x1D6AB2C")]
		public CGGameObjectResourceLoader()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011E")]
	public class CGGameObjectResourceCollection : ICGResourceCollection
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public List<Transform> Items;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public List<string> PoolNames;

		[Token(Token = "0x170001BC")]
		public int Count
		{
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x1D6A570", Offset = "0x1D6A570", VA = "0x1D6A570", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001BD")]
		public UnityEngine.Component[] ItemsArray
		{
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x1D6A5C8", Offset = "0x1D6A5C8", VA = "0x1D6A5C8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x1D6A634", Offset = "0x1D6A634", VA = "0x1D6A634")]
		public CGGameObjectResourceCollection()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public static class CGUtility
	{
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x13FE9E0", Offset = "0x13FE9E0", VA = "0x13FE9E0")]
		public static Vector2[] CalculateUV2(Vector2[] uv)
		{
			return null;
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x13FEBD0", Offset = "0x13FEBD0", VA = "0x13FEBD0")]
		public static List<ControlPointOption> GetControlPointsWithOptions(CGDataRequestMetaCGOptions options, CurvySpline shape, float startDist, float endDist, bool optimize, out int initialMaterialID, out float initialMaxStep)
		{
			return null;
		}
	}
	[Token(Token = "0x2000120")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F67A4", Offset = "0x6F67A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6F67A4", Offset = "0x6F67A4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6F67A4", Offset = "0x6F67A4")]
	public class CurvyGenerator : DTVersionedMonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200017E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F78BC", Offset = "0x6F78BC")]
		private sealed class <>c
		{
			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<CGModule, bool> <>9__47_0;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<CGModule, float> <>9__47_1;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static Func<CGModuleInputSlot, IEnumerable<CGModule>> <>9__65_0;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<CGModule, float> <>9__65_1;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static Func<CGModuleInputSlot, IEnumerable<CGModule>> <>9__66_0;

			[Token(Token = "0x6000B5A")]
			[Address(RVA = "0x1408BCC", Offset = "0x1408BCC", VA = "0x1408BCC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B5B")]
			[Address(RVA = "0x1408BD4", Offset = "0x1408BD4", VA = "0x1408BD4")]
			internal bool <ReorderModules>b__47_0(CGModule m)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B5C")]
			[Address(RVA = "0x1408C40", Offset = "0x1408C40", VA = "0x1408C40")]
			internal float <ReorderModules>b__47_1(CGModule m)
			{
				return default(float);
			}

			[Token(Token = "0x6000B5D")]
			[Address(RVA = "0x1408C78", Offset = "0x1408C78", VA = "0x1408C78")]
			internal IEnumerable<CGModule> <ReorderEndpointRecursiveInputs>b__65_0(CGModuleInputSlot i)
			{
				return null;
			}

			[Token(Token = "0x6000B5E")]
			[Address(RVA = "0x1408CA0", Offset = "0x1408CA0", VA = "0x1408CA0")]
			internal float <ReorderEndpointRecursiveInputs>b__65_1(CGModule m)
			{
				return default(float);
			}

			[Token(Token = "0x6000B5F")]
			[Address(RVA = "0x1408CD8", Offset = "0x1408CD8", VA = "0x1408CD8")]
			internal IEnumerable<CGModule> <UpdateModulesRecursiveInputs>b__66_0(CGModuleInputSlot i)
			{
				return null;
			}
		}

		[Token(Token = "0x200017F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F78CC", Offset = "0x6F78CC")]
		private sealed class <>c__DisplayClass66_0
		{
			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs;

			[Token(Token = "0x6000B60")]
			[Address(RVA = "0x1408A3C", Offset = "0x1408A3C", VA = "0x1408A3C")]
			public <>c__DisplayClass66_0()
			{
			}

			[Token(Token = "0x6000B61")]
			[Address(RVA = "0x1408D00", Offset = "0x1408D00", VA = "0x1408D00")]
			internal IEnumerable<CGModule> <UpdateModulesRecursiveInputs>b__1(CGModule i)
			{
				return null;
			}
		}

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6FD154", Offset = "0x6FD154")]
		[SerializeField]
		private bool m_ShowDebug;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6FD19C", Offset = "0x6FD19C")]
		[SerializeField]
		private bool m_AutoRefresh;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FD1E4", Offset = "0x6FD1E4")]
		[Positive]
		[SerializeField]
		private int m_RefreshDelay;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FD2D4", Offset = "0x6FD2D4")]
		[Positive]
		[SerializeField]
		private int m_RefreshDelayEditor;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6FD3C4", Offset = "0x6FD3C4")]
		[SerializeField]
		private CurvyCGEvent m_OnRefresh;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public List<CGModule> Modules;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		internal int m_LastModuleID;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD488", Offset = "0x6FD488")]
		private bool <Destroying>k__BackingField;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Dictionary<int, CGModule> ModulesByID;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool mInitialized;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool mInitializedPhaseOne;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool mNeedSort;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private double mLastUpdateTime;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PoolManager mPoolManager;

		[Token(Token = "0x4000437")]
		private const int ModulesReorderingDeltaX = 50;

		[Token(Token = "0x4000438")]
		private const int ModulesReorderingDeltaY = 20;

		[Token(Token = "0x170001BE")]
		public bool ShowDebug
		{
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x140558C", Offset = "0x140558C", VA = "0x140558C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x1405594", Offset = "0x1405594", VA = "0x1405594")]
			set
			{
			}
		}

		[Token(Token = "0x170001BF")]
		public bool AutoRefresh
		{
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x14055B0", Offset = "0x14055B0", VA = "0x14055B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x14055B8", Offset = "0x14055B8", VA = "0x14055B8")]
			set
			{
			}
		}

		[Token(Token = "0x170001C0")]
		public int RefreshDelay
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x14055D4", Offset = "0x14055D4", VA = "0x14055D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x14055DC", Offset = "0x14055DC", VA = "0x14055DC")]
			set
			{
			}
		}

		[Token(Token = "0x170001C1")]
		public int RefreshDelayEditor
		{
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x140566C", Offset = "0x140566C", VA = "0x140566C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x1405674", Offset = "0x1405674", VA = "0x1405674")]
			set
			{
			}
		}

		[Token(Token = "0x170001C2")]
		public PoolManager PoolManager
		{
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x1405704", Offset = "0x1405704", VA = "0x1405704")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C3")]
		public CurvyCGEvent OnRefresh
		{
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x14057C0", Offset = "0x14057C0", VA = "0x14057C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x14057C8", Offset = "0x14057C8", VA = "0x14057C8")]
			set
			{
			}
		}

		[Token(Token = "0x170001C4")]
		public bool IsInitialized
		{
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x14057DC", Offset = "0x14057DC", VA = "0x14057DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001C5")]
		public bool Destroying
		{
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x14057E4", Offset = "0x14057E4", VA = "0x14057E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703B98", Offset = "0x703B98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x14057EC", Offset = "0x14057EC", VA = "0x14057EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703BA8", Offset = "0x703BA8")]
			private set
			{
			}
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x14057F4", Offset = "0x14057F4", VA = "0x14057F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x14057F8", Offset = "0x14057F8", VA = "0x14057F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x1405828", Offset = "0x1405828", VA = "0x1405828")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x140583C", Offset = "0x140583C", VA = "0x140583C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x1405848", Offset = "0x1405848", VA = "0x1405848")]
		private void Update()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x14064EC", Offset = "0x14064EC", VA = "0x14064EC")]
		public static CurvyGenerator Create()
		{
			return null;
		}

		[Token(Token = "0x6000900")]
		public T AddModule<T>() where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x1406650", Offset = "0x1406650", VA = "0x1406650")]
		public CGModule AddModule(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x140680C", Offset = "0x140680C", VA = "0x140680C")]
		public void ArrangeModules()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x1406BEC", Offset = "0x1406BEC", VA = "0x1406BEC")]
		public void ReorderModules()
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x1407BBC", Offset = "0x1407BBC", VA = "0x1407BBC")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x1407D28", Offset = "0x1407D28", VA = "0x1407D28")]
		public void DeleteModule(CGModule module)
		{
		}

		[Token(Token = "0x6000906")]
		public List<T> FindModules<T>(bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x1407DC4", Offset = "0x1407DC4", VA = "0x1407DC4")]
		public List<CGModule> GetModules(bool includeOnRequestProcessing = false)
		{
			return null;
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x1407F48", Offset = "0x1407F48", VA = "0x1407F48")]
		public CGModule GetModule(int moduleID, bool includeOnRequestProcessing = false)
		{
			return null;
		}

		[Token(Token = "0x6000909")]
		public T GetModule<T>(int moduleID, bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x1408010", Offset = "0x1408010", VA = "0x1408010")]
		public CGModule GetModule(string moduleName, bool includeOnRequestProcessing = false)
		{
			return null;
		}

		[Token(Token = "0x600090B")]
		public T GetModule<T>(string moduleName, bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x1408184", Offset = "0x1408184", VA = "0x1408184")]
		public CGModuleOutputSlot GetModuleOutputSlot(int moduleId, string slotName)
		{
			return null;
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x1408248", Offset = "0x1408248", VA = "0x1408248")]
		public CGModuleOutputSlot GetModuleOutputSlot(string moduleName, string slotName)
		{
			return null;
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x14058E4", Offset = "0x14058E4", VA = "0x14058E4")]
		public void Initialize(bool force = false)
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x1405D94", Offset = "0x1405D94", VA = "0x1405D94")]
		public void Refresh(bool forceUpdate = false)
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x1408768", Offset = "0x1408768", VA = "0x1408768")]
		protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x1407BC0", Offset = "0x1407BC0", VA = "0x1407BC0")]
		private void clearModules()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x14087D8", Offset = "0x14087D8", VA = "0x14087D8")]
		public string getUniqueModuleNameINTERNAL(string name)
		{
			return null;
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x140830C", Offset = "0x140830C", VA = "0x140830C")]
		internal void sortModulesINTERNAL()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x1408318", Offset = "0x1408318", VA = "0x1408318")]
		private bool doSortModules()
		{
			return default(bool);
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x140759C", Offset = "0x140759C", VA = "0x140759C")]
		private static void ReorderEndpointRecursiveInputs(CGModule endPoint, HashSet<int> reordredModuleIds, Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs)
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x1407254", Offset = "0x1407254", VA = "0x1407254")]
		private static HashSet<CGModule> UpdateModulesRecursiveInputs(Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs, CGModule moduleToAdd)
		{
			return null;
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x1408A44", Offset = "0x1408A44", VA = "0x1408A44")]
		public CurvyGenerator()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Generator.Modules
{
	[Token(Token = "0x2000121")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F6878", Offset = "0x6F6878")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F6878", Offset = "0x6F6878")]
	public class BuildRasterizedPath : CGModule, IPathProvider
	{
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6FD498", Offset = "0x6FD498")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6FD56C", Offset = "0x6FD56C")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_Range;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6FD690", Offset = "0x6FD690")]
		private int m_Resolution;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool m_Optimize;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FD714", Offset = "0x6FD714")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6FD714", Offset = "0x6FD714")]
		private float m_AngleTreshold;

		[Token(Token = "0x170001C6")]
		public float From
		{
			[Token(Token = "0x6000918")]
			[Address(RVA = "0x1408F44", Offset = "0x1408F44", VA = "0x1408F44")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000919")]
			[Address(RVA = "0x1408F4C", Offset = "0x1408F4C", VA = "0x1408F4C")]
			set
			{
			}
		}

		[Token(Token = "0x170001C7")]
		public float To
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x1408FF4", Offset = "0x1408FF4", VA = "0x1408FF4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x1408FFC", Offset = "0x1408FFC", VA = "0x1408FFC")]
			set
			{
			}
		}

		[Token(Token = "0x170001C8")]
		public float Length
		{
			[Token(Token = "0x600091C")]
			[Address(RVA = "0x1409228", Offset = "0x1409228", VA = "0x1409228")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x1409250", Offset = "0x1409250", VA = "0x1409250")]
			set
			{
			}
		}

		[Token(Token = "0x170001C9")]
		public int Resolution
		{
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x1409298", Offset = "0x1409298", VA = "0x1409298")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x14092A0", Offset = "0x14092A0", VA = "0x14092A0")]
			set
			{
			}
		}

		[Token(Token = "0x170001CA")]
		public bool Optimize
		{
			[Token(Token = "0x6000920")]
			[Address(RVA = "0x1409344", Offset = "0x1409344", VA = "0x1409344")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x140934C", Offset = "0x140934C", VA = "0x140934C")]
			set
			{
			}
		}

		[Token(Token = "0x170001CB")]
		public float AngleThreshold
		{
			[Token(Token = "0x6000922")]
			[Address(RVA = "0x1409370", Offset = "0x1409370", VA = "0x1409370")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000923")]
			[Address(RVA = "0x1409378", Offset = "0x1409378", VA = "0x1409378")]
			set
			{
			}
		}

		[Token(Token = "0x170001CC")]
		public CGPath Path
		{
			[Token(Token = "0x6000924")]
			[Address(RVA = "0x140942C", Offset = "0x140942C", VA = "0x140942C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CD")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x14090FC", Offset = "0x14090FC", VA = "0x14090FC", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001CE")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x6000926")]
			[Address(RVA = "0x1409498", Offset = "0x1409498", VA = "0x1409498")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x14095C0", Offset = "0x14095C0", VA = "0x14095C0", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x1409610", Offset = "0x1409610", VA = "0x1409610", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x14096A0", Offset = "0x14096A0", VA = "0x14096A0", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x14098F4", Offset = "0x14098F4", VA = "0x14098F4")]
		public BuildRasterizedPath()
		{
		}
	}
	[Token(Token = "0x2000122")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F6918", Offset = "0x6F6918")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F6918", Offset = "0x6F6918")]
	public class BuildShapeExtrusion : CGModule, IPathProvider
	{
		[Token(Token = "0x2000180")]
		public enum ScaleModeEnum
		{
			[Token(Token = "0x4000602")]
			Simple,
			[Token(Token = "0x4000603")]
			Advanced
		}

		[Token(Token = "0x2000181")]
		public enum CrossShiftModeEnum
		{
			[Token(Token = "0x4000605")]
			None,
			[Token(Token = "0x4000606")]
			ByOrientation,
			[Token(Token = "0x4000607")]
			Custom
		}

		[Serializable]
		[Token(Token = "0x2000182")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F78DC", Offset = "0x6F78DC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<CGShape, int> <>9__152_0;

			[Token(Token = "0x6000B63")]
			[Address(RVA = "0x140CBD8", Offset = "0x140CBD8", VA = "0x140CBD8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x140CBE0", Offset = "0x140CBE0", VA = "0x140CBE0")]
			internal int <Refresh>b__152_0(CGShape c)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6FD818", Offset = "0x6FD818")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6FD8CC", Offset = "0x6FD8CC")]
		public CGModuleInputSlot InCross;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6FD98C", Offset = "0x6FD98C")]
		public CGModuleOutputSlot OutVolume;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6FDA0C", Offset = "0x6FDA0C")]
		public CGModuleOutputSlot OutVolumeHollow;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6FDA8C", Offset = "0x6FDA8C")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_Range;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6FDB18", Offset = "0x6FDB18")]
		private int m_Resolution;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool m_Optimize;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FDB9C", Offset = "0x6FDB9C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6FDB9C", Offset = "0x6FDB9C")]
		private float m_AngleThreshold;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6FDCC0", Offset = "0x6FDCC0")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x6FDCC0", Offset = "0x6FDCC0")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_CrossRange;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6FDD80", Offset = "0x6FDD80")]
		private int m_CrossResolution;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FDE14", Offset = "0x6FDE14")]
		private bool m_CrossOptimize;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FDE74", Offset = "0x6FDE74")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6FDE74", Offset = "0x6FDE74")]
		private float m_CrossAngleThreshold;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FDF9C", Offset = "0x6FDF9C")]
		private bool m_CrossIncludeControlpoints;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FDFFC", Offset = "0x6FDFFC")]
		private bool m_CrossHardEdges;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FE05C", Offset = "0x6FE05C")]
		private bool m_CrossMaterials;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FE0BC", Offset = "0x6FE0BC")]
		private bool m_CrossExtendedUV;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FE11C", Offset = "0x6FE11C")]
		private CrossShiftModeEnum m_CrossShiftMode;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6FE19C", Offset = "0x6FE19C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FE19C", Offset = "0x6FE19C")]
		private float m_CrossShiftValue;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FE2A8", Offset = "0x6FE2A8")]
		[SerializeField]
		private bool m_CrossReverseNormals;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6FE308", Offset = "0x6FE308")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FE308", Offset = "0x6FE308")]
		[SerializeField]
		private ScaleModeEnum m_ScaleMode;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FE390", Offset = "0x6FE390")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FE390", Offset = "0x6FE390")]
		[SerializeField]
		private CGReferenceMode m_ScaleReference;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FE48C", Offset = "0x6FE48C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FE48C", Offset = "0x6FE48C")]
		[SerializeField]
		private float m_ScaleOffset;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FE588", Offset = "0x6FE588")]
		private bool m_ScaleUniform;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float m_ScaleX;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FE618", Offset = "0x6FE618")]
		private float m_ScaleY;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FE6D8", Offset = "0x6FE6D8")]
		[AttributeAttribute(Name = "AnimationCurveExAttribute", RVA = "0x6FE6D8", Offset = "0x6FE6D8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6FE6D8", Offset = "0x6FE6D8")]
		private AnimationCurve m_ScaleCurveX;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FE7FC", Offset = "0x6FE7FC")]
		[AttributeAttribute(Name = "AnimationCurveExAttribute", RVA = "0x6FE7FC", Offset = "0x6FE7FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6FE7FC", Offset = "0x6FE7FC")]
		private AnimationCurve m_ScaleCurveY;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6FE95C", Offset = "0x6FE95C")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6FE95C", Offset = "0x6FE95C")]
		[SerializeField]
		private float m_HollowInset;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FEA18", Offset = "0x6FEA18")]
		[SerializeField]
		private bool m_HollowReverseNormals;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEA78", Offset = "0x6FEA78")]
		private int <PathSamples>k__BackingField;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEA88", Offset = "0x6FEA88")]
		private int <CrossSamples>k__BackingField;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEA98", Offset = "0x6FEA98")]
		private int <CrossGroups>k__BackingField;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEAA8", Offset = "0x6FEAA8")]
		private Vector3 <CrossPosition>k__BackingField;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEAB8", Offset = "0x6FEAB8")]
		private Quaternion <CrossRotation>k__BackingField;

		[Token(Token = "0x170001CF")]
		public float From
		{
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x14099D4", Offset = "0x14099D4", VA = "0x14099D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600092C")]
			[Address(RVA = "0x14099DC", Offset = "0x14099DC", VA = "0x14099DC")]
			set
			{
			}
		}

		[Token(Token = "0x170001D0")]
		public float To
		{
			[Token(Token = "0x600092D")]
			[Address(RVA = "0x1409A84", Offset = "0x1409A84", VA = "0x1409A84")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x1409A8C", Offset = "0x1409A8C", VA = "0x1409A8C")]
			set
			{
			}
		}

		[Token(Token = "0x170001D1")]
		public float Length
		{
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x1409CA4", Offset = "0x1409CA4", VA = "0x1409CA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x1409CCC", Offset = "0x1409CCC", VA = "0x1409CCC")]
			set
			{
			}
		}

		[Token(Token = "0x170001D2")]
		public int Resolution
		{
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x1409D14", Offset = "0x1409D14", VA = "0x1409D14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000932")]
			[Address(RVA = "0x1409D1C", Offset = "0x1409D1C", VA = "0x1409D1C")]
			set
			{
			}
		}

		[Token(Token = "0x170001D3")]
		public bool Optimize
		{
			[Token(Token = "0x6000933")]
			[Address(RVA = "0x1409DC0", Offset = "0x1409DC0", VA = "0x1409DC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000934")]
			[Address(RVA = "0x1409DC8", Offset = "0x1409DC8", VA = "0x1409DC8")]
			set
			{
			}
		}

		[Token(Token = "0x170001D4")]
		public float AngleThreshold
		{
			[Token(Token = "0x6000935")]
			[Address(RVA = "0x1409DEC", Offset = "0x1409DEC", VA = "0x1409DEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x1409DF4", Offset = "0x1409DF4", VA = "0x1409DF4")]
			set
			{
			}
		}

		[Token(Token = "0x170001D5")]
		public float CrossFrom
		{
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x1409EA8", Offset = "0x1409EA8", VA = "0x1409EA8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000938")]
			[Address(RVA = "0x1409EB0", Offset = "0x1409EB0", VA = "0x1409EB0")]
			set
			{
			}
		}

		[Token(Token = "0x170001D6")]
		public float CrossTo
		{
			[Token(Token = "0x6000939")]
			[Address(RVA = "0x1409F58", Offset = "0x1409F58", VA = "0x1409F58")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600093A")]
			[Address(RVA = "0x1409F60", Offset = "0x1409F60", VA = "0x1409F60")]
			set
			{
			}
		}

		[Token(Token = "0x170001D7")]
		public float CrossLength
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x140A178", Offset = "0x140A178", VA = "0x140A178")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600093C")]
			[Address(RVA = "0x140A1A0", Offset = "0x140A1A0", VA = "0x140A1A0")]
			set
			{
			}
		}

		[Token(Token = "0x170001D8")]
		public int CrossResolution
		{
			[Token(Token = "0x600093D")]
			[Address(RVA = "0x140A1E8", Offset = "0x140A1E8", VA = "0x140A1E8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600093E")]
			[Address(RVA = "0x140A1F0", Offset = "0x140A1F0", VA = "0x140A1F0")]
			set
			{
			}
		}

		[Token(Token = "0x170001D9")]
		public bool CrossOptimize
		{
			[Token(Token = "0x600093F")]
			[Address(RVA = "0x140A294", Offset = "0x140A294", VA = "0x140A294")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000940")]
			[Address(RVA = "0x140A29C", Offset = "0x140A29C", VA = "0x140A29C")]
			set
			{
			}
		}

		[Token(Token = "0x170001DA")]
		public float CrossAngleThreshold
		{
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x140A2C0", Offset = "0x140A2C0", VA = "0x140A2C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000942")]
			[Address(RVA = "0x140A2C8", Offset = "0x140A2C8", VA = "0x140A2C8")]
			set
			{
			}
		}

		[Token(Token = "0x170001DB")]
		public bool CrossIncludeControlPoints
		{
			[Token(Token = "0x6000943")]
			[Address(RVA = "0x140A37C", Offset = "0x140A37C", VA = "0x140A37C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x140A384", Offset = "0x140A384", VA = "0x140A384")]
			set
			{
			}
		}

		[Token(Token = "0x170001DC")]
		public bool CrossHardEdges
		{
			[Token(Token = "0x6000945")]
			[Address(RVA = "0x140A3A8", Offset = "0x140A3A8", VA = "0x140A3A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000946")]
			[Address(RVA = "0x140A3B0", Offset = "0x140A3B0", VA = "0x140A3B0")]
			set
			{
			}
		}

		[Token(Token = "0x170001DD")]
		public bool CrossMaterials
		{
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x140A3D4", Offset = "0x140A3D4", VA = "0x140A3D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000948")]
			[Address(RVA = "0x140A3DC", Offset = "0x140A3DC", VA = "0x140A3DC")]
			set
			{
			}
		}

		[Token(Token = "0x170001DE")]
		public bool CrossExtendedUV
		{
			[Token(Token = "0x6000949")]
			[Address(RVA = "0x140A400", Offset = "0x140A400", VA = "0x140A400")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600094A")]
			[Address(RVA = "0x140A408", Offset = "0x140A408", VA = "0x140A408")]
			set
			{
			}
		}

		[Token(Token = "0x170001DF")]
		public CrossShiftModeEnum CrossShiftMode
		{
			[Token(Token = "0x600094B")]
			[Address(RVA = "0x140A42C", Offset = "0x140A42C", VA = "0x140A42C")]
			get
			{
				return default(CrossShiftModeEnum);
			}
			[Token(Token = "0x600094C")]
			[Address(RVA = "0x140A434", Offset = "0x140A434", VA = "0x140A434")]
			set
			{
			}
		}

		[Token(Token = "0x170001E0")]
		public float CrossShiftValue
		{
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x140A44C", Offset = "0x140A44C", VA = "0x140A44C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600094E")]
			[Address(RVA = "0x140A454", Offset = "0x140A454", VA = "0x140A454")]
			set
			{
			}
		}

		[Token(Token = "0x170001E1")]
		public bool CrossReverseNormals
		{
			[Token(Token = "0x600094F")]
			[Address(RVA = "0x140A4FC", Offset = "0x140A4FC", VA = "0x140A4FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000950")]
			[Address(RVA = "0x140A504", Offset = "0x140A504", VA = "0x140A504")]
			set
			{
			}
		}

		[Token(Token = "0x170001E2")]
		public ScaleModeEnum ScaleMode
		{
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x140A528", Offset = "0x140A528", VA = "0x140A528")]
			get
			{
				return default(ScaleModeEnum);
			}
			[Token(Token = "0x6000952")]
			[Address(RVA = "0x140A530", Offset = "0x140A530", VA = "0x140A530")]
			set
			{
			}
		}

		[Token(Token = "0x170001E3")]
		public CGReferenceMode ScaleReference
		{
			[Token(Token = "0x6000953")]
			[Address(RVA = "0x140A548", Offset = "0x140A548", VA = "0x140A548")]
			get
			{
				return default(CGReferenceMode);
			}
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x140A550", Offset = "0x140A550", VA = "0x140A550")]
			set
			{
			}
		}

		[Token(Token = "0x170001E4")]
		public bool ScaleUniform
		{
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x140A568", Offset = "0x140A568", VA = "0x140A568")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x140A570", Offset = "0x140A570", VA = "0x140A570")]
			set
			{
			}
		}

		[Token(Token = "0x170001E5")]
		public float ScaleOffset
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x140A594", Offset = "0x140A594", VA = "0x140A594")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x140A59C", Offset = "0x140A59C", VA = "0x140A59C")]
			set
			{
			}
		}

		[Token(Token = "0x170001E6")]
		public float ScaleX
		{
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x140A5BC", Offset = "0x140A5BC", VA = "0x140A5BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x140A5C4", Offset = "0x140A5C4", VA = "0x140A5C4")]
			set
			{
			}
		}

		[Token(Token = "0x170001E7")]
		public float ScaleY
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x140A5E4", Offset = "0x140A5E4", VA = "0x140A5E4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600095C")]
			[Address(RVA = "0x140A5EC", Offset = "0x140A5EC", VA = "0x140A5EC")]
			set
			{
			}
		}

		[Token(Token = "0x170001E8")]
		public AnimationCurve ScaleMultiplierX
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x140A60C", Offset = "0x140A60C", VA = "0x140A60C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x140A614", Offset = "0x140A614", VA = "0x140A614")]
			set
			{
			}
		}

		[Token(Token = "0x170001E9")]
		public AnimationCurve ScaleMultiplierY
		{
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x140A648", Offset = "0x140A648", VA = "0x140A648")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x140A650", Offset = "0x140A650", VA = "0x140A650")]
			set
			{
			}
		}

		[Token(Token = "0x170001EA")]
		public float HollowInset
		{
			[Token(Token = "0x6000961")]
			[Address(RVA = "0x140A684", Offset = "0x140A684", VA = "0x140A684")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x140A68C", Offset = "0x140A68C", VA = "0x140A68C")]
			set
			{
			}
		}

		[Token(Token = "0x170001EB")]
		public bool HollowReverseNormals
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x140A730", Offset = "0x140A730", VA = "0x140A730")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000964")]
			[Address(RVA = "0x140A738", Offset = "0x140A738", VA = "0x140A738")]
			set
			{
			}
		}

		[Token(Token = "0x170001EC")]
		public int PathSamples
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x140A75C", Offset = "0x140A75C", VA = "0x140A75C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703BB8", Offset = "0x703BB8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000966")]
			[Address(RVA = "0x140A764", Offset = "0x140A764", VA = "0x140A764")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703BC8", Offset = "0x703BC8")]
			private set
			{
			}
		}

		[Token(Token = "0x170001ED")]
		public int CrossSamples
		{
			[Token(Token = "0x6000967")]
			[Address(RVA = "0x140A76C", Offset = "0x140A76C", VA = "0x140A76C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703BD8", Offset = "0x703BD8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000968")]
			[Address(RVA = "0x140A774", Offset = "0x140A774", VA = "0x140A774")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703BE8", Offset = "0x703BE8")]
			private set
			{
			}
		}

		[Token(Token = "0x170001EE")]
		public int CrossGroups
		{
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x140A77C", Offset = "0x140A77C", VA = "0x140A77C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703BF8", Offset = "0x703BF8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x140A784", Offset = "0x140A784", VA = "0x140A784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703C08", Offset = "0x703C08")]
			private set
			{
			}
		}

		[Token(Token = "0x170001EF")]
		public IExternalInput Cross
		{
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x140A78C", Offset = "0x140A78C", VA = "0x140A78C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F0")]
		public Vector3 CrossPosition
		{
			[Token(Token = "0x600096C")]
			[Address(RVA = "0x140A7FC", Offset = "0x140A7FC", VA = "0x140A7FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703C18", Offset = "0x703C18")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x140A810", Offset = "0x140A810", VA = "0x140A810")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703C28", Offset = "0x703C28")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001F1")]
		public Quaternion CrossRotation
		{
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x140A81C", Offset = "0x140A81C", VA = "0x140A81C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703C38", Offset = "0x703C38")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x140A82C", Offset = "0x140A82C", VA = "0x140A82C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703C48", Offset = "0x703C48")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001F2")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x140A83C", Offset = "0x140A83C", VA = "0x140A83C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001F3")]
		private bool ClampPath
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x1409B6C", Offset = "0x1409B6C", VA = "0x1409B6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001F4")]
		private bool ClampCross
		{
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x140A040", Offset = "0x140A040", VA = "0x140A040")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001F5")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x140A944", Offset = "0x140A944", VA = "0x140A944")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x170001F6")]
		private RegionOptions<float> CrossRangeOptions
		{
			[Token(Token = "0x6000974")]
			[Address(RVA = "0x140AA6C", Offset = "0x140AA6C", VA = "0x140AA6C")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x140AB94", Offset = "0x140AB94", VA = "0x140AB94", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x140ABE4", Offset = "0x140ABE4", VA = "0x140ABE4", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x140AEBC", Offset = "0x140AEBC", VA = "0x140AEBC", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x140C864", Offset = "0x140C864", VA = "0x140C864")]
		public Vector3 GetScale(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x140C778", Offset = "0x140C778", VA = "0x140C778")]
		private void getScaleInternal(float f, Vector3 baseScale, ref Vector3 scale)
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x140C9A0", Offset = "0x140C9A0", VA = "0x140C9A0")]
		public BuildShapeExtrusion()
		{
		}
	}
	[Token(Token = "0x2000123")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F69B8", Offset = "0x6F69B8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F69B8", Offset = "0x6F69B8")]
	public class BuildVolumeCaps : CGModule
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6FEAC8", Offset = "0x6FEAC8")]
		public CGModuleInputSlot InVolume;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6FEB70", Offset = "0x6FEB70")]
		public CGModuleInputSlot InVolumeHoles;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6FEC28", Offset = "0x6FEC28")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6FECB0", Offset = "0x6FECB0")]
		[SerializeField]
		private CGYesNoAuto m_StartCap;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CGYesNoAuto m_EndCap;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6FED08", Offset = "0x6FED08")]
		private bool m_ReverseTriOrder;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		[SerializeField]
		private bool m_GenerateUV;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6FED60", Offset = "0x6FED60")]
		[Inline]
		[SerializeField]
		private CGMaterialSettings m_StartMaterialSettings;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FEDB8", Offset = "0x6FEDB8")]
		[SerializeField]
		private Material m_StartMaterial;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6FEE18", Offset = "0x6FEE18")]
		[SerializeField]
		private bool m_CloneStartCap;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "AsGroupAttribute", RVA = "0x6FEE60", Offset = "0x6FEE60")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x6FEE60", Offset = "0x6FEE60")]
		[SerializeField]
		private CGMaterialSettings m_EndMaterialSettings;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6FEF30", Offset = "0x6FEF30")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6FEF30", Offset = "0x6FEF30")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FEF30", Offset = "0x6FEF30")]
		[SerializeField]
		private Material m_EndMaterial;

		[Token(Token = "0x170001F7")]
		public bool GenerateUV
		{
			[Token(Token = "0x600097B")]
			[Address(RVA = "0x140CC04", Offset = "0x140CC04", VA = "0x140CC04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600097C")]
			[Address(RVA = "0x140CC0C", Offset = "0x140CC0C", VA = "0x140CC0C")]
			set
			{
			}
		}

		[Token(Token = "0x170001F8")]
		public bool ReverseTriOrder
		{
			[Token(Token = "0x600097D")]
			[Address(RVA = "0x140CC30", Offset = "0x140CC30", VA = "0x140CC30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600097E")]
			[Address(RVA = "0x140CC38", Offset = "0x140CC38", VA = "0x140CC38")]
			set
			{
			}
		}

		[Token(Token = "0x170001F9")]
		public CGYesNoAuto StartCap
		{
			[Token(Token = "0x600097F")]
			[Address(RVA = "0x140CC5C", Offset = "0x140CC5C", VA = "0x140CC5C")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000980")]
			[Address(RVA = "0x140CC64", Offset = "0x140CC64", VA = "0x140CC64")]
			set
			{
			}
		}

		[Token(Token = "0x170001FA")]
		public Material StartMaterial
		{
			[Token(Token = "0x6000981")]
			[Address(RVA = "0x140CC7C", Offset = "0x140CC7C", VA = "0x140CC7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000982")]
			[Address(RVA = "0x140CC84", Offset = "0x140CC84", VA = "0x140CC84")]
			set
			{
			}
		}

		[Token(Token = "0x170001FB")]
		public CGMaterialSettings StartMaterialSettings
		{
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x140CD38", Offset = "0x140CD38", VA = "0x140CD38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FC")]
		public CGYesNoAuto EndCap
		{
			[Token(Token = "0x6000984")]
			[Address(RVA = "0x140CD40", Offset = "0x140CD40", VA = "0x140CD40")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000985")]
			[Address(RVA = "0x140CD48", Offset = "0x140CD48", VA = "0x140CD48")]
			set
			{
			}
		}

		[Token(Token = "0x170001FD")]
		public bool CloneStartCap
		{
			[Token(Token = "0x6000986")]
			[Address(RVA = "0x140CD60", Offset = "0x140CD60", VA = "0x140CD60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000987")]
			[Address(RVA = "0x140CD68", Offset = "0x140CD68", VA = "0x140CD68")]
			set
			{
			}
		}

		[Token(Token = "0x170001FE")]
		public CGMaterialSettings EndMaterialSettings
		{
			[Token(Token = "0x6000988")]
			[Address(RVA = "0x140CD8C", Offset = "0x140CD8C", VA = "0x140CD8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FF")]
		public Material EndMaterial
		{
			[Token(Token = "0x6000989")]
			[Address(RVA = "0x140CD94", Offset = "0x140CD94", VA = "0x140CD94")]
			get
			{
				return null;
			}
			[Token(Token = "0x600098A")]
			[Address(RVA = "0x140CD9C", Offset = "0x140CD9C", VA = "0x140CD9C")]
			set
			{
			}
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x140CE50", Offset = "0x140CE50", VA = "0x140CE50", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x140CF50", Offset = "0x140CF50", VA = "0x140CF50", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x140D0BC", Offset = "0x140D0BC", VA = "0x140D0BC", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x140E2CC", Offset = "0x140E2CC", VA = "0x140E2CC")]
		private static Matrix4x4 getMatrix(CGVolume vol, int index, bool inverse)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x140EAB8", Offset = "0x140EAB8", VA = "0x140EAB8")]
		private static void flipTris(ref int[] indices, int start, int end)
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x140E6F0", Offset = "0x140E6F0", VA = "0x140E6F0")]
		private static Vector3[] applyMatrix(Vector3[] vt, Matrix4x4 matrix, out Bounds bounds)
		{
			return null;
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x140E0CC", Offset = "0x140E0CC", VA = "0x140E0CC")]
		private static ContourVertex[] make2DSegment(CGVolume vol, int index)
		{
			return null;
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x140EBA4", Offset = "0x140EBA4", VA = "0x140EBA4")]
		private static void applyUV(Vector3[] vts, ref Vector2[] uvArray, int index, int count, CGMaterialSettings mat, Bounds bounds)
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x140F078", Offset = "0x140F078", VA = "0x140F078")]
		public BuildVolumeCaps()
		{
		}
	}
	[Token(Token = "0x2000124")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F6A58", Offset = "0x6F6A58")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F6A58", Offset = "0x6F6A58")]
	public class BuildVolumeMesh : CGModule
	{
		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6FF058", Offset = "0x6FF058")]
		public CGModuleInputSlot InVolume;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6FF100", Offset = "0x6FF100")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6FF188", Offset = "0x6FF188")]
		[SerializeField]
		private bool m_GenerateUV;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		[SerializeField]
		private bool m_Split;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FF1E0", Offset = "0x6FF1E0")]
		[SerializeField]
		private float m_SplitLength;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x6FF2B8", Offset = "0x6FF2B8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6FF2B8", Offset = "0x6FF2B8")]
		private bool m_ReverseTriOrder;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[HideInInspector]
		private List<CGMaterialSettingsEx> m_MaterialSettings;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[HideInInspector]
		private Material[] m_Material;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private List<SamplePointsMaterialGroupCollection> groupsByMatID;

		[Token(Token = "0x17000200")]
		public bool GenerateUV
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0x140F1B8", Offset = "0x140F1B8", VA = "0x140F1B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000995")]
			[Address(RVA = "0x140F1C0", Offset = "0x140F1C0", VA = "0x140F1C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000201")]
		public bool ReverseTriOrder
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0x140F1E4", Offset = "0x140F1E4", VA = "0x140F1E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000997")]
			[Address(RVA = "0x140F1EC", Offset = "0x140F1EC", VA = "0x140F1EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000202")]
		public bool Split
		{
			[Token(Token = "0x6000998")]
			[Address(RVA = "0x140F210", Offset = "0x140F210", VA = "0x140F210")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x140F218", Offset = "0x140F218", VA = "0x140F218")]
			set
			{
			}
		}

		[Token(Token = "0x17000203")]
		public float SplitLength
		{
			[Token(Token = "0x600099A")]
			[Address(RVA = "0x140F23C", Offset = "0x140F23C", VA = "0x140F23C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600099B")]
			[Address(RVA = "0x140F244", Offset = "0x140F244", VA = "0x140F244")]
			set
			{
			}
		}

		[Token(Token = "0x17000204")]
		public List<CGMaterialSettingsEx> MaterialSetttings
		{
			[Token(Token = "0x600099C")]
			[Address(RVA = "0x140F2EC", Offset = "0x140F2EC", VA = "0x140F2EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000205")]
		public int MaterialCount
		{
			[Token(Token = "0x600099D")]
			[Address(RVA = "0x140F2F4", Offset = "0x140F2F4", VA = "0x140F2F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x140F34C", Offset = "0x140F34C", VA = "0x140F34C", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x140F460", Offset = "0x140F460", VA = "0x140F460", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x140F698", Offset = "0x140F698", VA = "0x140F698", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x140F37C", Offset = "0x140F37C", VA = "0x140F37C")]
		public int AddMaterial()
		{
			return default(int);
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x14101B4", Offset = "0x14101B4", VA = "0x14101B4")]
		public void RemoveMaterial(int index)
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x141033C", Offset = "0x141033C", VA = "0x141033C")]
		public void SetMaterial(int index, Material mat)
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x14104F0", Offset = "0x14104F0", VA = "0x14104F0")]
		public Material GetMaterial(int index)
		{
			return null;
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x140FCB0", Offset = "0x140FCB0", VA = "0x140FCB0")]
		private void prepare(CGVolume vol)
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x140FCD4", Offset = "0x140FCD4", VA = "0x140FCD4")]
		private void build(CGVMesh vmesh, CGVolume vol, IntRegion subset)
		{
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x141093C", Offset = "0x141093C", VA = "0x141093C")]
		private static void prepareSubMeshes(CGVMesh vmesh, List<SamplePointsMaterialGroupCollection> groupsBySubMeshes, int extrusions, ref Material[] materials)
		{
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x1410BA4", Offset = "0x1410BA4", VA = "0x1410BA4")]
		private void createMaterialGroupUV(CGVMesh vmesh, CGVolume vol, SamplePointsMaterialGroup grp, int matIndex, float grpAspectCorrection, int sample, int baseVertex)
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x1410E24", Offset = "0x1410E24", VA = "0x1410E24")]
		private static int createPatchTriangles(ref int[] triangles, ref int triIdx, int curVTIndex, int patchSize, int crossSize, bool reverse)
		{
			return default(int);
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x1410548", Offset = "0x1410548", VA = "0x1410548")]
		private List<SamplePointsMaterialGroupCollection> getMaterialIDGroups(CGVolume volume)
		{
			return null;
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x1410280", Offset = "0x1410280", VA = "0x1410280")]
		private bool validateMaterialIndex(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x1411030", Offset = "0x1411030", VA = "0x1411030")]
		public BuildVolumeMesh()
		{
		}
	}
	[Token(Token = "0x2000125")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F6AF8", Offset = "0x6F6AF8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F6AF8", Offset = "0x6F6AF8")]
	public class BuildVolumeSpots : CGModule
	{
		[Token(Token = "0x2000183")]
		private class GroupSet
		{
			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public CGBoundsGroup Group;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float Length;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<int> Items;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public List<float> Distances;

			[Token(Token = "0x6000B65")]
			[Address(RVA = "0x1414144", Offset = "0x1414144", VA = "0x1414144")]
			public GroupSet()
			{
			}
		}

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6FF38C", Offset = "0x6FF38C")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6FF478", Offset = "0x6FF478")]
		public CGModuleInputSlot InBounds;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6FF52C", Offset = "0x6FF52C")]
		public CGModuleOutputSlot OutSpots;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6FF5AC", Offset = "0x6FF5AC")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_Range;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6FF630", Offset = "0x6FF630")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6FF630", Offset = "0x6FF630")]
		[SerializeField]
		private bool m_UseVolume;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6FF6C4", Offset = "0x6FF6C4")]
		[SerializeField]
		private bool m_Simulate;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6FF70C", Offset = "0x6FF70C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6FF70C", Offset = "0x6FF70C")]
		private float m_CrossBase;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AnimationCurve m_CrossCurve;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6FF7C0", Offset = "0x6FF7C0")]
		[ArrayEx]
		[SerializeField]
		private List<CGBoundsGroup> m_Groups;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[IntRegion]
		[SerializeField]
		private IntRegion m_RepeatingGroups;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private CurvyRepeatingOrderEnum m_RepeatingOrder;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool m_FitEnd;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FF8A8", Offset = "0x6FF8A8")]
		private int <Count>k__BackingField;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public CGSpots SimulatedSpots;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private WeightedRandom<int> mGroupBag;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<CGBounds> mBounds;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FF8B8", Offset = "0x6FF8B8")]
		private CGPath <Path>k__BackingField;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FF8C8", Offset = "0x6FF8C8")]
		private float <StartDistance>k__BackingField;

		[Token(Token = "0x17000206")]
		public FloatRegion Range
		{
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x141115C", Offset = "0x141115C", VA = "0x141115C")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x1411170", Offset = "0x1411170", VA = "0x1411170")]
			set
			{
			}
		}

		[Token(Token = "0x17000207")]
		public bool UseVolume
		{
			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x14111D8", Offset = "0x14111D8", VA = "0x14111D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x14111E0", Offset = "0x14111E0", VA = "0x14111E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000208")]
		public bool Simulate
		{
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x1411204", Offset = "0x1411204", VA = "0x1411204")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x141120C", Offset = "0x141120C", VA = "0x141120C")]
			set
			{
			}
		}

		[Token(Token = "0x17000209")]
		public float CrossBase
		{
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x1411230", Offset = "0x1411230", VA = "0x1411230")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x1411238", Offset = "0x1411238", VA = "0x1411238")]
			set
			{
			}
		}

		[Token(Token = "0x1700020A")]
		public AnimationCurve CrossCurve
		{
			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x14112E0", Offset = "0x14112E0", VA = "0x14112E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x14112E8", Offset = "0x14112E8", VA = "0x14112E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700020B")]
		public List<CGBoundsGroup> Groups
		{
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x141131C", Offset = "0x141131C", VA = "0x141131C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x1411324", Offset = "0x1411324", VA = "0x1411324")]
			set
			{
			}
		}

		[Token(Token = "0x1700020C")]
		public CurvyRepeatingOrderEnum RepeatingOrder
		{
			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x1411338", Offset = "0x1411338", VA = "0x1411338")]
			get
			{
				return default(CurvyRepeatingOrderEnum);
			}
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x1411340", Offset = "0x1411340", VA = "0x1411340")]
			set
			{
			}
		}

		[Token(Token = "0x1700020D")]
		public int FirstRepeating
		{
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x1411358", Offset = "0x1411358", VA = "0x1411358")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x1411360", Offset = "0x1411360", VA = "0x1411360")]
			set
			{
			}
		}

		[Token(Token = "0x1700020E")]
		public int LastRepeating
		{
			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x1411478", Offset = "0x1411478", VA = "0x1411478")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x1411480", Offset = "0x1411480", VA = "0x1411480")]
			set
			{
			}
		}

		[Token(Token = "0x1700020F")]
		public bool FitEnd
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x1411544", Offset = "0x1411544", VA = "0x1411544")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x141154C", Offset = "0x141154C", VA = "0x141154C")]
			set
			{
			}
		}

		[Token(Token = "0x17000210")]
		public int GroupCount
		{
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x1411420", Offset = "0x1411420", VA = "0x1411420")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000211")]
		public GUIContent[] BoundsNames
		{
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x1411570", Offset = "0x1411570", VA = "0x1411570")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000212")]
		public int[] BoundsIndices
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x1411784", Offset = "0x1411784", VA = "0x1411784")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000213")]
		public int Count
		{
			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x141185C", Offset = "0x141185C", VA = "0x141185C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703C58", Offset = "0x703C58")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x1411864", Offset = "0x1411864", VA = "0x1411864")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703C68", Offset = "0x703C68")]
			private set
			{
			}
		}

		[Token(Token = "0x17000214")]
		private int lastGroupIndex
		{
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x141186C", Offset = "0x141186C", VA = "0x141186C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000215")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x14118F8", Offset = "0x14118F8", VA = "0x14118F8")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x17000216")]
		private RegionOptions<int> RepeatingGroupsOptions
		{
			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x141195C", Offset = "0x141195C", VA = "0x141195C")]
			get
			{
				return default(RegionOptions<int>);
			}
		}

		[Token(Token = "0x17000217")]
		private CGPath Path
		{
			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x1411A0C", Offset = "0x1411A0C", VA = "0x1411A0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703C78", Offset = "0x703C78")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x1411A14", Offset = "0x1411A14", VA = "0x1411A14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703C88", Offset = "0x703C88")]
			set
			{
			}
		}

		[Token(Token = "0x17000218")]
		private CGVolume Volume
		{
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x1411A1C", Offset = "0x1411A1C", VA = "0x1411A1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000219")]
		private float Length
		{
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x1411AAC", Offset = "0x1411AAC", VA = "0x1411AAC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700021A")]
		private float StartDistance
		{
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x1411AF8", Offset = "0x1411AF8", VA = "0x1411AF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703C98", Offset = "0x703C98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x1411B00", Offset = "0x1411B00", VA = "0x1411B00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703CA8", Offset = "0x703CA8")]
			set
			{
			}
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x1411B08", Offset = "0x1411B08", VA = "0x1411B08", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x1411B3C", Offset = "0x1411B3C", VA = "0x1411B3C", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x1411DB8", Offset = "0x1411DB8", VA = "0x1411DB8", Slot = "13")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x1411DF4", Offset = "0x1411DF4", VA = "0x1411DF4")]
		public void Clear()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x1411F0C", Offset = "0x1411F0C", VA = "0x1411F0C", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x1411CB4", Offset = "0x1411CB4", VA = "0x1411CB4")]
		public CGBoundsGroup AddGroup(string name)
		{
			return null;
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x141401C", Offset = "0x141401C", VA = "0x141401C")]
		public void RemoveGroup(CGBoundsGroup group)
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x1413234", Offset = "0x1413234", VA = "0x1413234")]
		private GroupSet addGroupItems(CGBoundsGroup group, ref List<CGSpot> spots, ref float remainingLength, ref float currentDistance, bool calcLengthOnly = false)
		{
			return null;
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x1413D10", Offset = "0x1413D10", VA = "0x1413D10")]
		private void rebase(ref List<CGSpot> spots, ref List<GroupSet> sets, float currentDistance)
		{
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x1414214", Offset = "0x1414214", VA = "0x1414214")]
		private CGSpot getSpot(int itemID, ref CGBoundsGroup group, ref CGBounds bounds, float startDist)
		{
			return default(CGSpot);
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x141308C", Offset = "0x141308C", VA = "0x141308C")]
		private void prepare()
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x14140A0", Offset = "0x14140A0", VA = "0x14140A0")]
		private CGBounds getItemBounds(int itemIndex)
		{
			return null;
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x1414B04", Offset = "0x1414B04", VA = "0x1414B04")]
		private float getCrossValue(float globalF, CGBoundsGroup group)
		{
			return default(float);
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x1414C0C", Offset = "0x1414C0C", VA = "0x1414C0C")]
		public BuildVolumeSpots()
		{
		}
	}
	[Token(Token = "0x2000126")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F6BA0", Offset = "0x6F6BA0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F6BA0", Offset = "0x6F6BA0")]
	public class ConformPath : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6FF8D8", Offset = "0x6FF8D8")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6FF9AC", Offset = "0x6FF9AC")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6FFA2C", Offset = "0x6FFA2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6FFA2C", Offset = "0x6FFA2C")]
		private Vector3 m_Direction;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6FFAB0", Offset = "0x6FFAB0")]
		private float m_MaxDistance;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6FFAF8", Offset = "0x6FFAF8")]
		private float m_Offset;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6FFB40", Offset = "0x6FFB40")]
		private bool m_Warp;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6FFB88", Offset = "0x6FFB88")]
		private LayerMask m_LayerMask;

		[Token(Token = "0x1700021B")]
		public Vector3 Direction
		{
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x1414D74", Offset = "0x1414D74", VA = "0x1414D74")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x1414D88", Offset = "0x1414D88", VA = "0x1414D88")]
			set
			{
			}
		}

		[Token(Token = "0x1700021C")]
		public float MaxDistance
		{
			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x1414E58", Offset = "0x1414E58", VA = "0x1414E58")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x1414E60", Offset = "0x1414E60", VA = "0x1414E60")]
			set
			{
			}
		}

		[Token(Token = "0x1700021D")]
		public float Offset
		{
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x1414E80", Offset = "0x1414E80", VA = "0x1414E80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x1414E88", Offset = "0x1414E88", VA = "0x1414E88")]
			set
			{
			}
		}

		[Token(Token = "0x1700021E")]
		public bool Warp
		{
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x1414EA8", Offset = "0x1414EA8", VA = "0x1414EA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x1414EB0", Offset = "0x1414EB0", VA = "0x1414EB0")]
			set
			{
			}
		}

		[Token(Token = "0x1700021F")]
		public LayerMask LayerMask
		{
			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x1414ED4", Offset = "0x1414ED4", VA = "0x1414ED4")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x1414EDC", Offset = "0x1414EDC", VA = "0x1414EDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000220")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x70446C", Offset = "0x70446C")]
		public float PathLength
		{
			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x1415040", Offset = "0x1415040", VA = "0x1415040", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000221")]
		public bool PathIsClosed
		{
			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x14151D8", Offset = "0x14151D8", VA = "0x14151D8", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x1414F24", Offset = "0x1414F24", VA = "0x1414F24", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x1414F58", Offset = "0x1414F58", VA = "0x1414F58", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x1415304", Offset = "0x1415304", VA = "0x1415304", Slot = "16")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x14154D4", Offset = "0x14154D4", VA = "0x14154D4")]
		public static CGPath Conform(Transform pathTransform, CGPath path, LayerMask layers, Vector3 projectionDirection, float offset, float rayLength, bool warp)
		{
			return null;
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x1415A24", Offset = "0x1415A24", VA = "0x1415A24")]
		public ConformPath()
		{
		}
	}
	[Token(Token = "0x2000127")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F6C40", Offset = "0x6F6C40")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F6C40", Offset = "0x6F6C40")]
	public class CreateGameObject : CGModule
	{
		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6FFBD0", Offset = "0x6FFBD0")]
		public CGModuleInputSlot InGameObjectArray;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6FFCA4", Offset = "0x6FFCA4")]
		public CGModuleInputSlot InSpots;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceCollectionManagerAttribute", RVA = "0x6FFD70", Offset = "0x6FFD70")]
		private CGGameObjectResourceCollection m_Resources;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6FFDC0", Offset = "0x6FFDC0")]
		[SerializeField]
		private bool m_MakeStatic;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[AttributeAttribute(Name = "LayerAttribute", RVA = "0x6FFE08", Offset = "0x6FFE08")]
		private int m_Layer;

		[Token(Token = "0x17000222")]
		public int Layer
		{
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x1415B20", Offset = "0x1415B20", VA = "0x1415B20")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x1415B28", Offset = "0x1415B28", VA = "0x1415B28")]
			set
			{
			}
		}

		[Token(Token = "0x17000223")]
		public bool MakeStatic
		{
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x1415BCC", Offset = "0x1415BCC", VA = "0x1415BCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x1415BD4", Offset = "0x1415BD4", VA = "0x1415BD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000224")]
		public CGGameObjectResourceCollection GameObjects
		{
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x1415BF8", Offset = "0x1415BF8", VA = "0x1415BF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000225")]
		public int GameObjectCount
		{
			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x1415C00", Offset = "0x1415C00", VA = "0x1415C00")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x1415C28", Offset = "0x1415C28", VA = "0x1415C28", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x1415DE8", Offset = "0x1415DE8", VA = "0x1415DE8", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x1415E2C", Offset = "0x1415E2C", VA = "0x1415E2C", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x1415C74", Offset = "0x1415C74", VA = "0x1415C74")]
		public void Clear()
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x1415E30", Offset = "0x1415E30", VA = "0x1415E30", Slot = "13")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x1415E6C", Offset = "0x1415E6C", VA = "0x1415E6C", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x1416B18", Offset = "0x1416B18", VA = "0x1416B18")]
		public CreateGameObject()
		{
		}
	}
	[Token(Token = "0x2000128")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F6CC0", Offset = "0x6F6CC0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F6CC0", Offset = "0x6F6CC0")]
	public class CreateMesh : CGModule
	{
		[Serializable]
		[Token(Token = "0x2000184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F78EC", Offset = "0x6F78EC")]
		private sealed class <>c
		{
			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Comparison<CGSpot> <>9__107_0;

			[Token(Token = "0x6000B67")]
			[Address(RVA = "0x1BDA2E8", Offset = "0x1BDA2E8", VA = "0x1BDA2E8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B68")]
			[Address(RVA = "0x1BDA2F0", Offset = "0x1BDA2F0", VA = "0x1BDA2F0")]
			internal int <createSpotMeshes>b__107_0(CGSpot a, CGSpot b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000494")]
		private const string DefaultTag = "Untagged";

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6FFE64", Offset = "0x6FFE64")]
		public CGModuleInputSlot InVMeshArray;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6FFF38", Offset = "0x6FFF38")]
		public CGModuleInputSlot InSpots;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceCollectionManagerAttribute", RVA = "0x70000C", Offset = "0x70000C")]
		private CGMeshResourceCollection m_MeshResources;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x70005C", Offset = "0x70005C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x70005C", Offset = "0x70005C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x70005C", Offset = "0x70005C")]
		[SerializeField]
		private bool m_Combine;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x700174", Offset = "0x700174")]
		[SerializeField]
		private bool m_GroupMeshes;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x7001BC", Offset = "0x7001BC")]
		private CGYesNoAuto m_AddNormals;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x700280", Offset = "0x700280")]
		private CGYesNoAuto m_AddTangents;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x700344", Offset = "0x700344")]
		private bool m_AddUV2;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x700408", Offset = "0x700408")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x700408", Offset = "0x700408")]
		private bool m_MakeStatic;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7004F4", Offset = "0x7004F4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x7004F4", Offset = "0x7004F4")]
		[AttributeAttribute(Name = "LayerAttribute", RVA = "0x7004F4", Offset = "0x7004F4")]
		private int m_Layer;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x700620", Offset = "0x700620")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x700620", Offset = "0x700620")]
		[AttributeAttribute(Name = "TagAttribute", RVA = "0x700620", Offset = "0x700620")]
		private string m_Tag;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x70074C", Offset = "0x70074C")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x70074C", Offset = "0x70074C")]
		private bool m_RendererEnabled;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x700838", Offset = "0x700838")]
		private ShadowCastingMode m_CastShadows;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x7008FC", Offset = "0x7008FC")]
		private bool m_ReceiveShadows;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x7009C0", Offset = "0x7009C0")]
		private LightProbeUsage m_LightProbeUsage;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[HideInInspector]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x700A84", Offset = "0x700A84")]
		private bool m_UseLightProbes;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x700B58", Offset = "0x700B58")]
		private ReflectionProbeUsage m_ReflectionProbes;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x700C1C", Offset = "0x700C1C")]
		private Transform m_AnchorOverride;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x700CE0", Offset = "0x700CE0")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x700CE0", Offset = "0x700CE0")]
		private CGColliderEnum m_Collider;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x700DCC", Offset = "0x700DCC")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x700DCC", Offset = "0x700DCC")]
		private bool m_Convex;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x700EE8", Offset = "0x700EE8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x700EE8", Offset = "0x700EE8")]
		[SerializeField]
		[AttributeAttribute(Name = "EnumFlagAttribute", RVA = "0x700EE8", Offset = "0x700EE8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x700EE8", Offset = "0x700EE8")]
		private MeshColliderCookingOptions m_CookingOptions;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x701068", Offset = "0x701068")]
		[SerializeField]
		private bool m_AutoUpdateColliders;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private PhysicMaterial m_Material;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7010D8", Offset = "0x7010D8")]
		private int <VertexCount>k__BackingField;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int mCurrentMeshCount;

		[Token(Token = "0x17000226")]
		public bool Combine
		{
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x1416BEC", Offset = "0x1416BEC", VA = "0x1416BEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x1416BF4", Offset = "0x1416BF4", VA = "0x1416BF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000227")]
		public bool GroupMeshes
		{
			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x1416C18", Offset = "0x1416C18", VA = "0x1416C18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x1416C20", Offset = "0x1416C20", VA = "0x1416C20")]
			set
			{
			}
		}

		[Token(Token = "0x17000228")]
		public CGYesNoAuto AddNormals
		{
			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x1416C44", Offset = "0x1416C44", VA = "0x1416C44")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x1416C4C", Offset = "0x1416C4C", VA = "0x1416C4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000229")]
		public CGYesNoAuto AddTangents
		{
			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x1416C64", Offset = "0x1416C64", VA = "0x1416C64")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x1416C6C", Offset = "0x1416C6C", VA = "0x1416C6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700022A")]
		public bool AddUV2
		{
			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x1416C84", Offset = "0x1416C84", VA = "0x1416C84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x1416C8C", Offset = "0x1416C8C", VA = "0x1416C8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700022B")]
		public int Layer
		{
			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x1416CB0", Offset = "0x1416CB0", VA = "0x1416CB0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x1416CB8", Offset = "0x1416CB8", VA = "0x1416CB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700022C")]
		public string Tag
		{
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x1416D5C", Offset = "0x1416D5C", VA = "0x1416D5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x1416D64", Offset = "0x1416D64", VA = "0x1416D64")]
			set
			{
			}
		}

		[Token(Token = "0x1700022D")]
		public bool MakeStatic
		{
			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x1416DB0", Offset = "0x1416DB0", VA = "0x1416DB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x1416DB8", Offset = "0x1416DB8", VA = "0x1416DB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700022E")]
		public bool RendererEnabled
		{
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x1416DDC", Offset = "0x1416DDC", VA = "0x1416DDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x1416DE4", Offset = "0x1416DE4", VA = "0x1416DE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700022F")]
		public ShadowCastingMode CastShadows
		{
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x1416E08", Offset = "0x1416E08", VA = "0x1416E08")]
			get
			{
				return default(ShadowCastingMode);
			}
			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x1416E10", Offset = "0x1416E10", VA = "0x1416E10")]
			set
			{
			}
		}

		[Token(Token = "0x17000230")]
		public bool ReceiveShadows
		{
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x1416E28", Offset = "0x1416E28", VA = "0x1416E28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x1416E30", Offset = "0x1416E30", VA = "0x1416E30")]
			set
			{
			}
		}

		[Token(Token = "0x17000231")]
		public bool UseLightProbes
		{
			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x1416E54", Offset = "0x1416E54", VA = "0x1416E54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x1416E5C", Offset = "0x1416E5C", VA = "0x1416E5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000232")]
		public LightProbeUsage LightProbeUsage
		{
			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x1416E80", Offset = "0x1416E80", VA = "0x1416E80")]
			get
			{
				return default(LightProbeUsage);
			}
			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x1416E88", Offset = "0x1416E88", VA = "0x1416E88")]
			set
			{
			}
		}

		[Token(Token = "0x17000233")]
		public ReflectionProbeUsage ReflectionProbes
		{
			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x1416EA0", Offset = "0x1416EA0", VA = "0x1416EA0")]
			get
			{
				return default(ReflectionProbeUsage);
			}
			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x1416EA8", Offset = "0x1416EA8", VA = "0x1416EA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000234")]
		public Transform AnchorOverride
		{
			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x1416EC0", Offset = "0x1416EC0", VA = "0x1416EC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x1416EC8", Offset = "0x1416EC8", VA = "0x1416EC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000235")]
		public CGColliderEnum Collider
		{
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x1416F7C", Offset = "0x1416F7C", VA = "0x1416F7C")]
			get
			{
				return default(CGColliderEnum);
			}
			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x1416F84", Offset = "0x1416F84", VA = "0x1416F84")]
			set
			{
			}
		}

		[Token(Token = "0x17000236")]
		public bool AutoUpdateColliders
		{
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x1416F9C", Offset = "0x1416F9C", VA = "0x1416F9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x1416FA4", Offset = "0x1416FA4", VA = "0x1416FA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000237")]
		public bool Convex
		{
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x1416FC8", Offset = "0x1416FC8", VA = "0x1416FC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x1416FD0", Offset = "0x1416FD0", VA = "0x1416FD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000238")]
		public MeshColliderCookingOptions CookingOptions
		{
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x1416FF4", Offset = "0x1416FF4", VA = "0x1416FF4")]
			get
			{
				return default(MeshColliderCookingOptions);
			}
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x1416FFC", Offset = "0x1416FFC", VA = "0x1416FFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000239")]
		public PhysicMaterial Material
		{
			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x1417014", Offset = "0x1417014", VA = "0x1417014")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x141701C", Offset = "0x141701C", VA = "0x141701C")]
			set
			{
			}
		}

		[Token(Token = "0x1700023A")]
		public CGMeshResourceCollection Meshes
		{
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x14170D0", Offset = "0x14170D0", VA = "0x14170D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023B")]
		public int MeshCount
		{
			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x14170D8", Offset = "0x14170D8", VA = "0x14170D8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700023C")]
		public int VertexCount
		{
			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x1417100", Offset = "0x1417100", VA = "0x1417100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703CB8", Offset = "0x703CB8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x1417108", Offset = "0x1417108", VA = "0x1417108")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703CC8", Offset = "0x703CC8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700023D")]
		private bool canGroupMeshes
		{
			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x1417110", Offset = "0x1417110", VA = "0x1417110")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700023E")]
		private bool canModifyStaticFlag
		{
			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x1417158", Offset = "0x1417158", VA = "0x1417158")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700023F")]
		private bool canUpdate
		{
			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x1417160", Offset = "0x1417160", VA = "0x1417160")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x1417190", Offset = "0x1417190", VA = "0x1417190", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x1417474", Offset = "0x1417474", VA = "0x1417474", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x1417454", Offset = "0x1417454", VA = "0x1417454")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x14175DC", Offset = "0x14175DC", VA = "0x14175DC", Slot = "13")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x1417628", Offset = "0x1417628", VA = "0x1417628", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x1418C6C", Offset = "0x1418C6C", VA = "0x1418C6C")]
		public GameObject SaveToScene([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x1418A88", Offset = "0x1418A88", VA = "0x1418A88")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x14185B8", Offset = "0x14185B8", VA = "0x14185B8")]
		private void createMeshes(ref List<CGVMesh> vMeshes, bool combine)
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x1417964", Offset = "0x1417964", VA = "0x1417964")]
		private void createSpotMeshes(ref List<CGVMesh> vMeshes, ref CGSpots spots, bool combine)
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x141926C", Offset = "0x141926C", VA = "0x141926C")]
		private CGMeshResource writeVMeshToMesh(ref CGVMesh vmesh)
		{
			return null;
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x1417494", Offset = "0x1417494", VA = "0x1417494")]
		private void removeUnusedResource()
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x14196D0", Offset = "0x14196D0", VA = "0x14196D0")]
		private CGMeshResource getNewMesh()
		{
			return null;
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x1419B1C", Offset = "0x1419B1C", VA = "0x1419B1C")]
		public CreateMesh()
		{
		}
	}
	[Token(Token = "0x2000129")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F6D40", Offset = "0x6F6D40")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F6D40", Offset = "0x6F6D40")]
	public class CreatePathLineRenderer : CGModule
	{
		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x7010E8", Offset = "0x7010E8")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private LineRenderer mLineRenderer;

		[Token(Token = "0x17000240")]
		public LineRenderer LineRenderer
		{
			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x1BDA31C", Offset = "0x1BDA31C", VA = "0x1BDA31C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x1BDA3D8", Offset = "0x1BDA3D8", VA = "0x1BDA3D8", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x1BDA53C", Offset = "0x1BDA53C", VA = "0x1BDA53C", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x1BDA3F8", Offset = "0x1BDA3F8", VA = "0x1BDA3F8")]
		private void createLR()
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x1BDA6F0", Offset = "0x1BDA6F0", VA = "0x1BDA6F0")]
		public CreatePathLineRenderer()
		{
		}
	}
	[Token(Token = "0x200012A")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F6DE0", Offset = "0x6F6DE0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F6DE0", Offset = "0x6F6DE0")]
	public class DebugRasterizedPath : CGModule
	{
		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x7011B4", Offset = "0x7011B4")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x701280", Offset = "0x701280")]
		public bool ShowNormals;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7012B4", Offset = "0x7012B4")]
		public bool ShowOrientation;

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x1BDA770", Offset = "0x1BDA770", VA = "0x1BDA770", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x1BDA790", Offset = "0x1BDA790", VA = "0x1BDA790")]
		public DebugRasterizedPath()
		{
		}
	}
	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F6E80", Offset = "0x6F6E80")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F6E80", Offset = "0x6F6E80")]
	public class DebugVMesh : CGModule
	{
		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x7012E8", Offset = "0x7012E8")]
		public CGModuleInputSlot InData;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x7013B4", Offset = "0x7013B4")]
		public bool ShowVertices;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		public bool ShowVertexID;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		public bool ShowUV;

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x1BDA818", Offset = "0x1BDA818", VA = "0x1BDA818", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x1BDA83C", Offset = "0x1BDA83C", VA = "0x1BDA83C")]
		public DebugVMesh()
		{
		}
	}
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F6F00", Offset = "0x6F6F00")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F6F00", Offset = "0x6F6F00")]
	public class DebugVolume : CGModule
	{
		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x7013E8", Offset = "0x7013E8")]
		public CGModuleInputSlot InData;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x7014B4", Offset = "0x7014B4")]
		public bool ShowPathSamples;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		public bool ShowCrossSamples;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x7014E8", Offset = "0x7014E8")]
		[IntRegion]
		public IntRegion LimitCross;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool ShowNormals;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		public bool ShowIndex;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x76")]
		public bool ShowMap;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color PathColor;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color VolumeColor;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color NormalColor;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x7015AC", Offset = "0x7015AC")]
		public bool Interpolate;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x7015E0", Offset = "0x7015E0")]
		public float InterpolatePathF;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x701640", Offset = "0x701640")]
		public float InterpolateCrossF;

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x1BDA8BC", Offset = "0x1BDA8BC", VA = "0x1BDA8BC")]
		public DebugVolume()
		{
		}
	}
	[Token(Token = "0x200012D")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F6F80", Offset = "0x6F6F80")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F6F80", Offset = "0x6F6F80")]
	public class InputGameObject : CGModule
	{
		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x7016A0", Offset = "0x7016A0")]
		public CGModuleOutputSlot OutGameObject;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[ArrayEx]
		[SerializeField]
		private List<CGGameObjectProperties> m_GameObjects;

		[Token(Token = "0x17000241")]
		public List<CGGameObjectProperties> GameObjects
		{
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x1BDA9D4", Offset = "0x1BDA9D4", VA = "0x1BDA9D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000242")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x1BDA9DC", Offset = "0x1BDA9DC", VA = "0x1BDA9DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x1BDA9E4", Offset = "0x1BDA9E4", VA = "0x1BDA9E4", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x1BDAA6C", Offset = "0x1BDAA6C", VA = "0x1BDAA6C", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x1BDAC7C", Offset = "0x1BDAC7C", VA = "0x1BDAC7C", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x1BDACF4", Offset = "0x1BDACF4", VA = "0x1BDACF4")]
		public InputGameObject()
		{
		}
	}
	[Token(Token = "0x200012E")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F7020", Offset = "0x6F7020")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F7020", Offset = "0x6F7020")]
	public class InputMesh : CGModule, IExternalInput
	{
		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x701758", Offset = "0x701758")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		[ArrayEx]
		private List<CGMeshProperties> m_Meshes;

		[Token(Token = "0x17000243")]
		public List<CGMeshProperties> Meshes
		{
			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x1BDADB4", Offset = "0x1BDADB4", VA = "0x1BDADB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000244")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x1BDADBC", Offset = "0x1BDADBC", VA = "0x1BDADBC", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x1BDADC4", Offset = "0x1BDADC4", VA = "0x1BDADC4", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x1BDAE4C", Offset = "0x1BDAE4C", VA = "0x1BDAE4C", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x1BDB0A4", Offset = "0x1BDB0A4", VA = "0x1BDB0A4", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x1BDB11C", Offset = "0x1BDB11C", VA = "0x1BDB11C")]
		public InputMesh()
		{
		}
	}
	[Token(Token = "0x200012F")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F70C0", Offset = "0x6F70C0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F70C0", Offset = "0x6F70C0")]
	public class InputSplinePath : SplineInputModuleBase, IExternalInput, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x701810", Offset = "0x701810")]
		public CGModuleOutputSlot Path;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x701890", Offset = "0x701890")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceManagerAttribute", RVA = "0x701890", Offset = "0x701890")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x701890", Offset = "0x701890")]
		private CurvySpline m_Spline;

		[Token(Token = "0x17000245")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x1BDB27C", Offset = "0x1BDB27C", VA = "0x1BDB27C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x1BDB284", Offset = "0x1BDB284", VA = "0x1BDB284")]
			set
			{
			}
		}

		[Token(Token = "0x17000246")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x1BDB6A4", Offset = "0x1BDB6A4", VA = "0x1BDB6A4", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000247")]
		protected override CurvySpline InputSpline
		{
			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x1BDD894", Offset = "0x1BDD894", VA = "0x1BDD894", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x1BDD89C", Offset = "0x1BDD89C", VA = "0x1BDD89C", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x1BDB6AC", Offset = "0x1BDB6AC", VA = "0x1BDB6AC", Slot = "22")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x1BDD7D8", Offset = "0x1BDD7D8", VA = "0x1BDD7D8", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x1BDD8A0", Offset = "0x1BDD8A0", VA = "0x1BDD8A0")]
		public InputSplinePath()
		{
		}
	}
	[Token(Token = "0x2000130")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F7160", Offset = "0x6F7160")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F7160", Offset = "0x6F7160")]
	public class InputSplineShape : SplineInputModuleBase, IExternalInput, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x701960", Offset = "0x701960")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x7019E0", Offset = "0x7019E0")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceManagerAttribute", RVA = "0x7019E0", Offset = "0x7019E0")]
		private CurvySpline m_Shape;

		[Token(Token = "0x17000248")]
		public CurvySpline Shape
		{
			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x1BDD928", Offset = "0x1BDD928", VA = "0x1BDD928")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x1BDD930", Offset = "0x1BDD930", VA = "0x1BDD930")]
			set
			{
			}
		}

		[Token(Token = "0x17000249")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x1BDDA00", Offset = "0x1BDDA00", VA = "0x1BDDA00", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700024A")]
		public bool FreeForm
		{
			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x1BDDA04", Offset = "0x1BDDA04", VA = "0x1BDDA04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x1BDDAF4", Offset = "0x1BDDAF4", VA = "0x1BDDAF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700024B")]
		protected override CurvySpline InputSpline
		{
			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x1BDDEAC", Offset = "0x1BDDEAC", VA = "0x1BDDEAC", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x1BDDEB4", Offset = "0x1BDDEB4", VA = "0x1BDDEB4", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x1BDDC88", Offset = "0x1BDDC88", VA = "0x1BDDC88", Slot = "22")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A5B")]
		public T SetManagedShape<T>() where T : CurvyShape2D
		{
			return null;
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x1BDDDE4", Offset = "0x1BDDDE4", VA = "0x1BDDDE4")]
		public void RemoveManagedShape()
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x1BDDEB8", Offset = "0x1BDDEB8", VA = "0x1BDDEB8", Slot = "19")]
		protected override void OnSplineAssigned()
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x1BDE160", Offset = "0x1BDE160", VA = "0x1BDE160")]
		public InputSplineShape()
		{
		}
	}
	[Token(Token = "0x2000131")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F7200", Offset = "0x6F7200")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F7200", Offset = "0x6F7200")]
	public class InputSpots : CGModule
	{
		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x701A58", Offset = "0x701A58")]
		public CGModuleOutputSlot OutSpots;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[ArrayEx]
		[SerializeField]
		private List<CGSpot> m_Spots;

		[Token(Token = "0x1700024C")]
		public List<CGSpot> Spots
		{
			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x1BDE1E0", Offset = "0x1BDE1E0", VA = "0x1BDE1E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x1BDE1E8", Offset = "0x1BDE1E8", VA = "0x1BDE1E8")]
			set
			{
			}
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x1BDE21C", Offset = "0x1BDE21C", VA = "0x1BDE21C", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x1BDE250", Offset = "0x1BDE250", VA = "0x1BDE250", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x1BDE2D8", Offset = "0x1BDE2D8", VA = "0x1BDE2D8", Slot = "13")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x1BDE2E0", Offset = "0x1BDE2E0", VA = "0x1BDE2E0", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x1BDE438", Offset = "0x1BDE438", VA = "0x1BDE438")]
		public InputSpots()
		{
		}
	}
	[Token(Token = "0x2000132")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F72A0", Offset = "0x6F72A0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F72A0", Offset = "0x6F72A0")]
	public class ModifierMixPaths : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x701B08", Offset = "0x701B08")]
		public CGModuleInputSlot InPathA;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x701BD4", Offset = "0x701BD4")]
		public CGModuleInputSlot InPathB;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x701CA0", Offset = "0x701CA0")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x701D20", Offset = "0x701D20")]
		private float m_Mix;

		[Token(Token = "0x1700024D")]
		public float Mix
		{
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x1BDE4F8", Offset = "0x1BDE4F8", VA = "0x1BDE4F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x1BDE500", Offset = "0x1BDE500", VA = "0x1BDE500")]
			set
			{
			}
		}

		[Token(Token = "0x1700024E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7044A0", Offset = "0x7044A0")]
		public float PathLength
		{
			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x1BDE520", Offset = "0x1BDE520", VA = "0x1BDE520", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700024F")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x1BDE748", Offset = "0x1BDE748", VA = "0x1BDE748", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x1BDE934", Offset = "0x1BDE934", VA = "0x1BDE934", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x1BDE984", Offset = "0x1BDE984", VA = "0x1BDE984", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x1BDE9C0", Offset = "0x1BDE9C0", VA = "0x1BDE9C0", Slot = "16")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x1BDEB30", Offset = "0x1BDEB30", VA = "0x1BDEB30")]
		public static CGPath MixPath(CGPath pathA, CGPath pathB, float mix, [NotNull] List<string> warningsContainer)
		{
			return null;
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x1BE0184", Offset = "0x1BE0184", VA = "0x1BE0184")]
		public ModifierMixPaths()
		{
		}
	}
	[Token(Token = "0x2000133")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F7340", Offset = "0x6F7340")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F7340", Offset = "0x6F7340")]
	public class ModifierMixShapes : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Serializable]
		[Token(Token = "0x2000185")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F78FC", Offset = "0x6F78FC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<SamplePointsMaterialGroup, SamplePointsMaterialGroup> <>9__15_0;

			[Token(Token = "0x6000B6A")]
			[Address(RVA = "0x1BE0A94", Offset = "0x1BE0A94", VA = "0x1BE0A94")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B6B")]
			[Address(RVA = "0x1BE0A9C", Offset = "0x1BE0A9C", VA = "0x1BE0A9C")]
			internal SamplePointsMaterialGroup <InterpolateShape>b__15_0(SamplePointsMaterialGroup g)
			{
				return null;
			}
		}

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x701DB0", Offset = "0x701DB0")]
		public CGModuleInputSlot InShapeA;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x701E7C", Offset = "0x701E7C")]
		public CGModuleInputSlot InShapeB;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x701F48", Offset = "0x701F48")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x701FC8", Offset = "0x701FC8")]
		private float m_Mix;

		[Token(Token = "0x17000250")]
		public float Mix
		{
			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x1BE0258", Offset = "0x1BE0258", VA = "0x1BE0258")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x1BE0260", Offset = "0x1BE0260", VA = "0x1BE0260")]
			set
			{
			}
		}

		[Token(Token = "0x17000251")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7044D4", Offset = "0x7044D4")]
		public float PathLength
		{
			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x1BE0280", Offset = "0x1BE0280", VA = "0x1BE0280", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000252")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x1BE04A8", Offset = "0x1BE04A8", VA = "0x1BE04A8", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x1BE0694", Offset = "0x1BE0694", VA = "0x1BE0694", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x1BE06E4", Offset = "0x1BE06E4", VA = "0x1BE06E4", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x1BE0720", Offset = "0x1BE0720", VA = "0x1BE0720", Slot = "16")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x1BE0894", Offset = "0x1BE0894", VA = "0x1BE0894")]
		public static CGShape MixShapes(CGShape shapeA, CGShape shapeB, float mix, [NotNull] List<string> warningsContainer, bool ignoreWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x1BDF168", Offset = "0x1BDF168", VA = "0x1BDF168")]
		public static void InterpolateShape([NotNull] CGShape resultShape, CGShape shapeA, CGShape shapeB, float mix, [NotNull] List<string> warningsContainer, bool ignoreWarnings = false)
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x1BE094C", Offset = "0x1BE094C", VA = "0x1BE094C")]
		public ModifierMixShapes()
		{
		}
	}
	[Token(Token = "0x2000134")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F73E0", Offset = "0x6F73E0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F73E0", Offset = "0x6F73E0")]
	public class ModifierPathRelativeTranslation : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x702058", Offset = "0x702058")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x70212C", Offset = "0x70212C")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7021AC", Offset = "0x7021AC")]
		private float lateralTranslation;

		[Token(Token = "0x17000253")]
		public float LateralTranslation
		{
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x1BE0B80", Offset = "0x1BE0B80", VA = "0x1BE0B80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x1BE0B88", Offset = "0x1BE0B88", VA = "0x1BE0B88")]
			set
			{
			}
		}

		[Token(Token = "0x17000254")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x704508", Offset = "0x704508")]
		public float PathLength
		{
			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x1BE0BAC", Offset = "0x1BE0BAC", VA = "0x1BE0BAC", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000255")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0x1BE0CD8", Offset = "0x1BE0CD8", VA = "0x1BE0CD8", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x1BE0E04", Offset = "0x1BE0E04", VA = "0x1BE0E04", Slot = "16")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x1BE11C0", Offset = "0x1BE11C0", VA = "0x1BE11C0", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x1BE1210", Offset = "0x1BE1210", VA = "0x1BE1210", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x1BE1254", Offset = "0x1BE1254", VA = "0x1BE1254")]
		public ModifierPathRelativeTranslation()
		{
		}
	}
	[Token(Token = "0x2000135")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F7480", Offset = "0x6F7480")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F7480", Offset = "0x6F7480")]
	public class ModifierTRSMesh : TRSModuleBase
	{
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x7021F4", Offset = "0x7021F4")]
		public CGModuleInputSlot InVMesh;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x7022AC", Offset = "0x7022AC")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x1BE1304", Offset = "0x1BE1304", VA = "0x1BE1304", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x1BE16C8", Offset = "0x1BE16C8", VA = "0x1BE16C8")]
		public ModifierTRSMesh()
		{
		}
	}
	[Token(Token = "0x2000136")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F7520", Offset = "0x6F7520")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F7520", Offset = "0x6F7520")]
	public class ModifierTRSPath : TRSModuleBase, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x702334", Offset = "0x702334")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x702408", Offset = "0x702408")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x17000256")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x70453C", Offset = "0x70453C")]
		public float PathLength
		{
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x1BE1810", Offset = "0x1BE1810", VA = "0x1BE1810", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000257")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x1BE193C", Offset = "0x1BE193C", VA = "0x1BE193C", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x1BE1A68", Offset = "0x1BE1A68", VA = "0x1BE1A68", Slot = "16")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x1BE1EB4", Offset = "0x1BE1EB4", VA = "0x1BE1EB4")]
		public ModifierTRSPath()
		{
		}
	}
	[Token(Token = "0x2000137")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F75C0", Offset = "0x6F75C0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F75C0", Offset = "0x6F75C0")]
	public class ModifierTRSShape : TRSModuleBase, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x702488", Offset = "0x702488")]
		public CGModuleInputSlot InShape;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x70255C", Offset = "0x70255C")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x17000258")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x704570", Offset = "0x704570")]
		public float PathLength
		{
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x1BE1F60", Offset = "0x1BE1F60", VA = "0x1BE1F60", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000259")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x1BE208C", Offset = "0x1BE208C", VA = "0x1BE208C", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x1BE21B8", Offset = "0x1BE21B8", VA = "0x1BE21B8", Slot = "16")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x1BE2604", Offset = "0x1BE2604", VA = "0x1BE2604")]
		public ModifierTRSShape()
		{
		}
	}
	[Token(Token = "0x2000138")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F7660", Offset = "0x6F7660")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F7660", Offset = "0x6F7660")]
	public class ModifierVariableMixShapes : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x7025DC", Offset = "0x7025DC")]
		public CGModuleInputSlot InShapeA;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x7026A8", Offset = "0x7026A8")]
		public CGModuleInputSlot InShapeB;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[AttributeAttribute(Name = "ShapeOutputSlotInfo", RVA = "0x702774", Offset = "0x702774")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x7027BC", Offset = "0x7027BC")]
		[SerializeField]
		private AnimationCurve m_MixCurve;

		[Token(Token = "0x1700025A")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7045A4", Offset = "0x7045A4")]
		public float PathLength
		{
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x1BE26B0", Offset = "0x1BE26B0", VA = "0x1BE26B0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700025B")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x1BE28D8", Offset = "0x1BE28D8", VA = "0x1BE28D8", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700025C")]
		public AnimationCurve MixCurve
		{
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x1BE2AC4", Offset = "0x1BE2AC4", VA = "0x1BE2AC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x1BE2ACC", Offset = "0x1BE2ACC", VA = "0x1BE2ACC")]
			set
			{
			}
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x1BE2AF4", Offset = "0x1BE2AF4", VA = "0x1BE2AF4", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x1BE2B44", Offset = "0x1BE2B44", VA = "0x1BE2B44", Slot = "16")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x1BE2D8C", Offset = "0x1BE2D8C", VA = "0x1BE2D8C")]
		public ModifierVariableMixShapes()
		{
		}
	}
	[Token(Token = "0x2000139")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6F7700", Offset = "0x6F7700")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6F7700", Offset = "0x6F7700")]
	public class Note : CGModule, INoProcessing
	{
		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x70281C", Offset = "0x70281C")]
		private string m_Note;

		[Token(Token = "0x1700025D")]
		public string NoteText
		{
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x1BE2E98", Offset = "0x1BE2E98", VA = "0x1BE2E98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x1BE2EA0", Offset = "0x1BE2EA0", VA = "0x1BE2EA0")]
			set
			{
			}
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x1BE2ED8", Offset = "0x1BE2ED8", VA = "0x1BE2ED8", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x1BE2F28", Offset = "0x1BE2F28", VA = "0x1BE2F28", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x1BE2F54", Offset = "0x1BE2F54", VA = "0x1BE2F54")]
		public Note()
		{
		}
	}
}
