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
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13ACC18", Offset = "0x13ACC18")]
internal sealed class <>f__AnonymousType0<<A>j__TPar, <B>j__TPar, <C>j__TPar, <D>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x13AF394", Offset = "0x13AF394")]
	private readonly <A>j__TPar <A>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x13AF3A8", Offset = "0x13AF3A8")]
	private readonly <B>j__TPar <B>i__Field;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x13AF3BC", Offset = "0x13AF3BC")]
	private readonly <C>j__TPar <C>i__Field;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x13AF3D0", Offset = "0x13AF3D0")]
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
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13ACC28", Offset = "0x13ACC28")]
internal sealed class <>f__AnonymousType1<<A>j__TPar, <B>j__TPar, <C>j__TPar, <D>j__TPar, <E>j__TPar>
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x13AF3E4", Offset = "0x13AF3E4")]
	private readonly <A>j__TPar <A>i__Field;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x13AF3F8", Offset = "0x13AF3F8")]
	private readonly <B>j__TPar <B>i__Field;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x13AF40C", Offset = "0x13AF40C")]
	private readonly <C>j__TPar <C>i__Field;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x13AF420", Offset = "0x13AF420")]
	private readonly <D>j__TPar <D>i__Field;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x13AF434", Offset = "0x13AF434")]
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
	[Address(RVA = "0x1FC12BC", Offset = "0x1FC12BC", VA = "0x1FC12BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1FC1398", Offset = "0x1FC1398", VA = "0x1FC1398")]
	public EventSystemChecker()
	{
	}
}
[Token(Token = "0x2000005")]
public class ForcedReset : MonoBehaviour
{
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2C527D0", Offset = "0x2C527D0", VA = "0x2C527D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2C5288C", Offset = "0x2C5288C", VA = "0x2C5288C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode action;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object target;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject source;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int triggerCount;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool repeatTrigger;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x3C75CBC", Offset = "0x3C75CBC", VA = "0x3C75CBC")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x3C76124", Offset = "0x3C76124", VA = "0x3C76124")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x3C76128", Offset = "0x3C76128", VA = "0x3C76128")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x3C76B74", Offset = "0x3C76B74", VA = "0x3C76B74")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013C")]
		public class ReplacementList
		{
			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x3C76B7C", Offset = "0x3C76B7C", VA = "0x3C76B7C")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x3C76140", Offset = "0x3C76140", VA = "0x3C76140")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x3C76B6C", Offset = "0x3C76B6C", VA = "0x3C76B6C")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x3C76D58", Offset = "0x3C76D58", VA = "0x3C76D58")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x3C76BE8", Offset = "0x3C76BE8", VA = "0x3C76BE8")]
		private void Start()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x3C76C10", Offset = "0x3C76C10", VA = "0x3C76C10")]
		private void Update()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3C76D50", Offset = "0x3C76D50", VA = "0x3C76D50")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class CameraRefocus
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x3C76D68", Offset = "0x3C76D68", VA = "0x3C76D68")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x3C76DDC", Offset = "0x3C76DDC", VA = "0x3C76DDC")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x3C76DE4", Offset = "0x3C76DE4", VA = "0x3C76DE4")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x3C76DEC", Offset = "0x3C76DEC", VA = "0x3C76DEC")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x3C76F4C", Offset = "0x3C76F4C", VA = "0x3C76F4C")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000A")]
	public class CurveControlledBob
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x3C76FA0", Offset = "0x3C76FA0", VA = "0x3C76FA0")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x3C77044", Offset = "0x3C77044", VA = "0x3C77044")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x3C77164", Offset = "0x3C77164", VA = "0x3C77164")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x200013E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF224", Offset = "0x13AF224")]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x1700025E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A9F")]
				[Address(RVA = "0x3C77AF0", Offset = "0x3C77AF0", VA = "0x3C77AF0", Slot = "4")]
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
				[Address(RVA = "0x3C77B58", Offset = "0x3C77B58", VA = "0x3C77B58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x3C77860", Offset = "0x3C77860", VA = "0x3C77860")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x3C77894", Offset = "0x3C77894", VA = "0x3C77894", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0x3C77898", Offset = "0x3C77898", VA = "0x3C77898", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x3C77AF8", Offset = "0x3C77AF8", VA = "0x3C77AF8", Slot = "8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x3C773B0", Offset = "0x3C773B0", VA = "0x3C773B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x3C777D4", Offset = "0x3C777D4", VA = "0x3C777D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13BA098", Offset = "0x13BA098")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x3C77724", Offset = "0x3C77724", VA = "0x3C77724")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x3C7788C", Offset = "0x3C7788C", VA = "0x3C7788C")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x3C77B60", Offset = "0x3C77B60", VA = "0x3C77B60")]
		private void Start()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x3C77B94", Offset = "0x3C77B94", VA = "0x3C77B94")]
		private void Update()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x3C77E08", Offset = "0x3C77E08", VA = "0x3C77E08")]
		public DynamicShadowSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public class FOVKick
	{
		[Token(Token = "0x200013F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF234", Offset = "0x13AF234")]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000260")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AA5")]
				[Address(RVA = "0x3C78440", Offset = "0x3C78440", VA = "0x3C78440", Slot = "4")]
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
				[Address(RVA = "0x3C784A8", Offset = "0x3C784A8", VA = "0x3C784A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x3C77FEC", Offset = "0x3C77FEC", VA = "0x3C77FEC")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x3C782D0", Offset = "0x3C782D0", VA = "0x3C782D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x3C782D4", Offset = "0x3C782D4", VA = "0x3C782D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x3C78448", Offset = "0x3C78448", VA = "0x3C78448", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF244", Offset = "0x13AF244")]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000262")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AAB")]
				[Address(RVA = "0x3C78260", Offset = "0x3C78260", VA = "0x3C78260", Slot = "4")]
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
				[Address(RVA = "0x3C782C8", Offset = "0x3C782C8", VA = "0x3C782C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x3C78094", Offset = "0x3C78094", VA = "0x3C78094")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x3C780DC", Offset = "0x3C780DC", VA = "0x3C780DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x3C780E0", Offset = "0x3C780E0", VA = "0x3C780E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x3C78268", Offset = "0x3C78268", VA = "0x3C78268", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x3C77E3C", Offset = "0x3C77E3C", VA = "0x3C77E3C")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x3C77E88", Offset = "0x3C77E88", VA = "0x3C77E88")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x3C77F68", Offset = "0x3C77F68", VA = "0x3C77F68")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x3C77F70", Offset = "0x3C77F70", VA = "0x3C77F70")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13BA0FC", Offset = "0x13BA0FC")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x3C78018", Offset = "0x3C78018", VA = "0x3C78018")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13BA160", Offset = "0x13BA160")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x3C780C0", Offset = "0x3C780C0", VA = "0x3C780C0")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ACC38", Offset = "0x13ACC38")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x400003A")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x400003E")]
		private const string display = "{0} FPS";

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x3C784B0", Offset = "0x3C784B0", VA = "0x3C784B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x3C785A8", Offset = "0x3C785A8", VA = "0x3C785A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x3C786C4", Offset = "0x3C786C4", VA = "0x3C786C4")]
		public FPSCounter()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x3C786CC", Offset = "0x3C786CC", VA = "0x3C786CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x3C787AC", Offset = "0x3C787AC", VA = "0x3C787AC")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	public class LerpControlledBob
	{
		[Token(Token = "0x2000141")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF254", Offset = "0x13AF254")]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000264")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AB1")]
				[Address(RVA = "0x3C78AC0", Offset = "0x3C78AC0", VA = "0x3C78AC0", Slot = "4")]
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
				[Address(RVA = "0x3C78B28", Offset = "0x3C78B28", VA = "0x3C78B28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x3C78890", Offset = "0x3C78890", VA = "0x3C78890")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x3C788C4", Offset = "0x3C788C4", VA = "0x3C788C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x3C788C8", Offset = "0x3C788C8", VA = "0x3C788C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x3C78AC8", Offset = "0x3C78AC8", VA = "0x3C78AC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x3C7880C", Offset = "0x3C7880C", VA = "0x3C7880C")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x3C78814", Offset = "0x3C78814", VA = "0x3C78814")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13BA1C4", Offset = "0x13BA1C4")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x3C788BC", Offset = "0x3C788BC", VA = "0x3C788BC")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x2000142")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF264", Offset = "0x13AF264")]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x17000266")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AB7")]
				[Address(RVA = "0x3C78F5C", Offset = "0x3C78F5C", VA = "0x3C78F5C", Slot = "4")]
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
				[Address(RVA = "0x3C78FC4", Offset = "0x3C78FC4", VA = "0x3C78FC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x3C78CE8", Offset = "0x3C78CE8", VA = "0x3C78CE8")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x3C78D1C", Offset = "0x3C78D1C", VA = "0x3C78D1C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x3C78D20", Offset = "0x3C78D20", VA = "0x3C78D20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x3C78F64", Offset = "0x3C78F64", VA = "0x3C78F64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x3C78B30", Offset = "0x3C78B30", VA = "0x3C78B30")]
		private void Start()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x3C78C30", Offset = "0x3C78C30", VA = "0x3C78C30")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x3C78C5C", Offset = "0x3C78C5C", VA = "0x3C78C5C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13BA228", Offset = "0x13BA228")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x3C78D14", Offset = "0x3C78D14", VA = "0x3C78D14")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x2000143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF274", Offset = "0x13AF274")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x17000268")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000ABD")]
				[Address(RVA = "0x3C793B0", Offset = "0x3C793B0", VA = "0x3C793B0", Slot = "4")]
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
				[Address(RVA = "0x3C79418", Offset = "0x3C79418", VA = "0x3C79418", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x3C79048", Offset = "0x3C79048", VA = "0x3C79048")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x3C79094", Offset = "0x3C79094", VA = "0x3C79094", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0x3C79098", Offset = "0x3C79098", VA = "0x3C79098", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0x3C793B8", Offset = "0x3C793B8", VA = "0x3C793B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x3C78FCC", Offset = "0x3C78FCC", VA = "0x3C78FCC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13BA28C", Offset = "0x13BA28C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x3C79074", Offset = "0x3C79074", VA = "0x3C79074")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x3C79080", Offset = "0x3C79080", VA = "0x3C79080")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x3C79420", Offset = "0x3C79420", VA = "0x3C79420")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x3C79424", Offset = "0x3C79424", VA = "0x3C79424")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x3C79440", Offset = "0x3C79440", VA = "0x3C79440")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x3C7979C", Offset = "0x3C7979C", VA = "0x3C7979C")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x3C7982C", Offset = "0x3C7982C", VA = "0x3C7982C")]
		public SimpleActivatorMenu()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x3C79834", Offset = "0x3C79834", VA = "0x3C79834")]
		private void Start()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x3C79870", Offset = "0x3C79870", VA = "0x3C79870")]
		private void Update()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x3C79CA4", Offset = "0x3C79CA4", VA = "0x3C79CA4")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x3C79D64", Offset = "0x3C79D64", VA = "0x3C79D64")]
		private void Start()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x3C79D68", Offset = "0x3C79D68", VA = "0x3C79D68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x3C7A094", Offset = "0x3C7A094", VA = "0x3C7A094")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x3C7A850", Offset = "0x3C7A850", VA = "0x3C7A850")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000147")]
		public class Entries
		{
			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x3C7A440", Offset = "0x3C7A440", VA = "0x3C7A440")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF284", Offset = "0x13AF284")]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700026A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AC5")]
				[Address(RVA = "0x3C7A520", Offset = "0x3C7A520", VA = "0x3C7A520", Slot = "4")]
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
				[Address(RVA = "0x3C7A588", Offset = "0x3C7A588", VA = "0x3C7A588", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x3C7A348", Offset = "0x3C7A348", VA = "0x3C7A348")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x3C7A448", Offset = "0x3C7A448", VA = "0x3C7A448", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x3C7A44C", Offset = "0x3C7A44C", VA = "0x3C7A44C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x3C7A528", Offset = "0x3C7A528", VA = "0x3C7A528", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000149")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF294", Offset = "0x13AF294")]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700026C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000ACB")]
				[Address(RVA = "0x3C7A668", Offset = "0x3C7A668", VA = "0x3C7A668", Slot = "4")]
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
				[Address(RVA = "0x3C7A6D0", Offset = "0x3C7A6D0", VA = "0x3C7A6D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x3C7A374", Offset = "0x3C7A374", VA = "0x3C7A374")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x3C7A590", Offset = "0x3C7A590", VA = "0x3C7A590", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x3C7A594", Offset = "0x3C7A594", VA = "0x3C7A594", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0x3C7A670", Offset = "0x3C7A670", VA = "0x3C7A670", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200014A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF2A4", Offset = "0x13AF2A4")]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700026E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AD1")]
				[Address(RVA = "0x3C7A7E0", Offset = "0x3C7A7E0", VA = "0x3C7A7E0", Slot = "4")]
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
				[Address(RVA = "0x3C7A848", Offset = "0x3C7A848", VA = "0x3C7A848", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0x3C7A3A0", Offset = "0x3C7A3A0", VA = "0x3C7A3A0")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x3C7A6D8", Offset = "0x3C7A6D8", VA = "0x3C7A6D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x3C7A6DC", Offset = "0x3C7A6DC", VA = "0x3C7A6DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x3C7A7E8", Offset = "0x3C7A7E8", VA = "0x3C7A7E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x3C7A0A8", Offset = "0x3C7A0A8", VA = "0x3C7A0A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x3C7A1D4", Offset = "0x3C7A1D4", VA = "0x3C7A1D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13BA2F0", Offset = "0x13BA2F0")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x3C7A250", Offset = "0x3C7A250", VA = "0x3C7A250")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13BA354", Offset = "0x13BA354")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x3C7A2CC", Offset = "0x3C7A2CC", VA = "0x3C7A2CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13BA3B8", Offset = "0x13BA3B8")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x3C7A3CC", Offset = "0x3C7A3CC", VA = "0x3C7A3CC")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x3C7A858", Offset = "0x3C7A858", VA = "0x3C7A858")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x3C7A8B0", Offset = "0x3C7A8B0", VA = "0x3C7A8B0")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x3C7A950", Offset = "0x3C7A950", VA = "0x3C7A950")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x3C7B7CC", Offset = "0x3C7B7CC", VA = "0x3C7B7CC")]
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
			[Address(RVA = "0x3C7B144", Offset = "0x3C7B144", VA = "0x3C7B144")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF528", Offset = "0x13AF528")]
		private float <Length>k__BackingField;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x1700000A")]
		public float Length
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x3C7A960", Offset = "0x3C7A960", VA = "0x3C7A960")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA41C", Offset = "0x13BA41C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x3C7A968", Offset = "0x3C7A968", VA = "0x3C7A968")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA42C", Offset = "0x13BA42C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x3C7A970", Offset = "0x3C7A970", VA = "0x3C7A970")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x3C7A98C", Offset = "0x3C7A98C", VA = "0x3C7A98C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x3C7ACDC", Offset = "0x3C7ACDC", VA = "0x3C7ACDC")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x3C7ADEC", Offset = "0x3C7ADEC", VA = "0x3C7ADEC")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x3C7B154", Offset = "0x3C7B154", VA = "0x3C7B154")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x3C7A9E8", Offset = "0x3C7A9E8", VA = "0x3C7A9E8")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x3C7B4BC", Offset = "0x3C7B4BC", VA = "0x3C7B4BC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x3C7B744", Offset = "0x3C7B744", VA = "0x3C7B744")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x3C7B4C4", Offset = "0x3C7B4C4", VA = "0x3C7B4C4")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x3C7B74C", Offset = "0x3C7B74C", VA = "0x3C7B74C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF5A8", Offset = "0x13AF5A8")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF5B8", Offset = "0x13AF5B8")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF5C8", Offset = "0x13AF5C8")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x1700000C")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x3C7B838", Offset = "0x3C7B838", VA = "0x3C7B838")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA43C", Offset = "0x13BA43C")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x3C7B84C", Offset = "0x3C7B84C", VA = "0x3C7B84C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA44C", Offset = "0x13BA44C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x3C7B860", Offset = "0x3C7B860", VA = "0x3C7B860")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA45C", Offset = "0x13BA45C")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x3C7B874", Offset = "0x3C7B874", VA = "0x3C7B874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA46C", Offset = "0x13BA46C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x3C7B888", Offset = "0x3C7B888", VA = "0x3C7B888")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA47C", Offset = "0x13BA47C")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x3C7B89C", Offset = "0x3C7B89C", VA = "0x3C7B89C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA48C", Offset = "0x13BA48C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x3C7B8B0", Offset = "0x3C7B8B0", VA = "0x3C7B8B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x3C7B9A4", Offset = "0x3C7B9A4", VA = "0x3C7B9A4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x3C7BA7C", Offset = "0x3C7BA7C", VA = "0x3C7BA7C")]
		private void Update()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x3C7BFE4", Offset = "0x3C7BFE4", VA = "0x3C7BFE4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x3C7C1BC", Offset = "0x3C7C1BC", VA = "0x3C7C1BC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x3C720D8", Offset = "0x3C720D8", VA = "0x3C720D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x3C723A0", Offset = "0x3C723A0", VA = "0x3C723A0")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x3C72530", Offset = "0x3C72530", VA = "0x3C72530")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x3C725B0", Offset = "0x3C725B0", VA = "0x3C725B0", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x3C72698", Offset = "0x3C72698", VA = "0x3C72698", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x3C72740", Offset = "0x3C72740", VA = "0x3C72740")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x3C727B4", Offset = "0x3C727B4", VA = "0x3C727B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x3C727B8", Offset = "0x3C727B8", VA = "0x3C727B8")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x3C728A0", Offset = "0x3C728A0", VA = "0x3C728A0")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x3C72988", Offset = "0x3C72988", VA = "0x3C72988")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x3C72A70", Offset = "0x3C72A70", VA = "0x3C72A70")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x3C72B58", Offset = "0x3C72B58", VA = "0x3C72B58")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x3C72C40", Offset = "0x3C72C40", VA = "0x3C72C40")]
		public void Update()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x3C72C44", Offset = "0x3C72C44", VA = "0x3C72C44")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B9F90", Offset = "0x13B9F90")]
			private string <name>k__BackingField;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B9FA0", Offset = "0x13B9FA0")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x17000270")]
			public string name
			{
				[Token(Token = "0x6000AD6")]
				[Address(RVA = "0x3C73AC8", Offset = "0x3C73AC8", VA = "0x3C73AC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB6C0", Offset = "0x13BB6C0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000AD7")]
				[Address(RVA = "0x3C73AD0", Offset = "0x3C73AD0", VA = "0x3C73AD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB6D0", Offset = "0x13BB6D0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000271")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000AD8")]
				[Address(RVA = "0x3C73AD8", Offset = "0x3C73AD8", VA = "0x3C73AD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB6E0", Offset = "0x13BB6E0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000AD9")]
				[Address(RVA = "0x3C73AE0", Offset = "0x3C73AE0", VA = "0x3C73AE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB6F0", Offset = "0x13BB6F0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000272")]
			public float GetValue
			{
				[Token(Token = "0x6000ADE")]
				[Address(RVA = "0x3C73B40", Offset = "0x3C73B40", VA = "0x3C73B40")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000273")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000ADF")]
				[Address(RVA = "0x3C73B48", Offset = "0x3C73B48", VA = "0x3C73B48")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x3C72270", Offset = "0x3C72270", VA = "0x3C72270")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0x3C73AEC", Offset = "0x3C73AEC", VA = "0x3C73AEC")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0x3C72548", Offset = "0x3C72548", VA = "0x3C72548")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0x3C73B38", Offset = "0x3C73B38", VA = "0x3C73B38")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000150")]
		public class VirtualButton
		{
			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B9FB0", Offset = "0x13B9FB0")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B9FC0", Offset = "0x13B9FC0")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x17000274")]
			public string name
			{
				[Token(Token = "0x6000AE0")]
				[Address(RVA = "0x3C73B50", Offset = "0x3C73B50", VA = "0x3C73B50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB700", Offset = "0x13BB700")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000AE1")]
				[Address(RVA = "0x3C73B58", Offset = "0x3C73B58", VA = "0x3C73B58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB710", Offset = "0x13BB710")]
				private set
				{
				}
			}

			[Token(Token = "0x17000275")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000AE2")]
				[Address(RVA = "0x3C73B60", Offset = "0x3C73B60", VA = "0x3C73B60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB720", Offset = "0x13BB720")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000AE3")]
				[Address(RVA = "0x3C73B68", Offset = "0x3C73B68", VA = "0x3C73B68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB730", Offset = "0x13BB730")]
				private set
				{
				}
			}

			[Token(Token = "0x17000276")]
			public bool GetButton
			{
				[Token(Token = "0x6000AE9")]
				[Address(RVA = "0x3C73CE0", Offset = "0x3C73CE0", VA = "0x3C73CE0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000277")]
			public bool GetButtonDown
			{
				[Token(Token = "0x6000AEA")]
				[Address(RVA = "0x3C73CE8", Offset = "0x3C73CE8", VA = "0x3C73CE8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000278")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000AEB")]
				[Address(RVA = "0x3C73D18", Offset = "0x3C73D18", VA = "0x3C73D18")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0x3C73B74", Offset = "0x3C73B74", VA = "0x3C73B74")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0x3C73BBC", Offset = "0x3C73BBC", VA = "0x3C73BBC")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0x3C73C10", Offset = "0x3C73C10", VA = "0x3C73C10")]
			public void Pressed()
			{
			}

			[Token(Token = "0x6000AE7")]
			[Address(RVA = "0x3C73C4C", Offset = "0x3C73C4C", VA = "0x3C73C4C")]
			public void Released()
			{
			}

			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0x3C73C78", Offset = "0x3C73C78", VA = "0x3C73C78")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x1700000F")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x3C73748", Offset = "0x3C73748", VA = "0x3C73748")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x3C72C4C", Offset = "0x3C72C4C", VA = "0x3C72C4C")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x3C72D00", Offset = "0x3C72D00", VA = "0x3C72D00")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x3C721F8", Offset = "0x3C721F8", VA = "0x3C721F8")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x3C72E20", Offset = "0x3C72E20", VA = "0x3C72E20")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x3C722B0", Offset = "0x3C722B0", VA = "0x3C722B0")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x3C73028", Offset = "0x3C73028", VA = "0x3C73028")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x3C731C8", Offset = "0x3C731C8", VA = "0x3C731C8")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x3C73318", Offset = "0x3C73318", VA = "0x3C73318")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x3C72328", Offset = "0x3C72328", VA = "0x3C72328")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x3C72068", Offset = "0x3C72068", VA = "0x3C72068")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x3C7354C", Offset = "0x3C7354C", VA = "0x3C7354C")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x3C734BC", Offset = "0x3C734BC", VA = "0x3C734BC")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x3C735B4", Offset = "0x3C735B4", VA = "0x3C735B4")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x3C71D40", Offset = "0x3C71D40", VA = "0x3C71D40")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x3C73634", Offset = "0x3C73634", VA = "0x3C73634")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x3C72820", Offset = "0x3C72820", VA = "0x3C72820")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x3C72908", Offset = "0x3C72908", VA = "0x3C72908")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x3C729F0", Offset = "0x3C729F0", VA = "0x3C729F0")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x3C72BC0", Offset = "0x3C72BC0", VA = "0x3C72BC0")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x3C72AD8", Offset = "0x3C72AD8", VA = "0x3C72AD8")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x3C736B4", Offset = "0x3C736B4", VA = "0x3C736B4")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x3C737C4", Offset = "0x3C737C4", VA = "0x3C737C4")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x3C738C0", Offset = "0x3C738C0", VA = "0x3C738C0")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x3C739C8", Offset = "0x3C739C8", VA = "0x3C739C8")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x3C73D48", Offset = "0x3C73D48", VA = "0x3C73D48")]
		private void Update()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x3C73D4C", Offset = "0x3C73D4C", VA = "0x3C73D4C")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x3C73DCC", Offset = "0x3C73DCC", VA = "0x3C73DCC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x3C73DD4", Offset = "0x3C73DD4", VA = "0x3C73DD4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x3C73F4C", Offset = "0x3C73F4C", VA = "0x3C73F4C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x3C73F88", Offset = "0x3C73F88", VA = "0x3C73F88")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x3C73DD8", Offset = "0x3C73DD8", VA = "0x3C73DD8")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x3C74078", Offset = "0x3C74078", VA = "0x3C74078", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x3C74238", Offset = "0x3C74238", VA = "0x3C74238", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x3C74280", Offset = "0x3C74280", VA = "0x3C74280", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x3C74284", Offset = "0x3C74284", VA = "0x3C74284")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x3C742D4", Offset = "0x3C742D4", VA = "0x3C742D4")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x3C74354", Offset = "0x3C74354", VA = "0x3C74354")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x3C74364", Offset = "0x3C74364", VA = "0x3C74364")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x3C7435C", Offset = "0x3C7435C", VA = "0x3C7435C")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x3C74440", Offset = "0x3C74440", VA = "0x3C74440")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x3C746AC", Offset = "0x3C746AC", VA = "0x3C746AC")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0x3C755B4", Offset = "0x3C755B4", VA = "0x3C755B4")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x3C75224", Offset = "0x3C75224", VA = "0x3C75224")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x3C75300", Offset = "0x3C75300", VA = "0x3C75300")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x3C7558C", Offset = "0x3C7558C", VA = "0x3C7558C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x3C755A4", Offset = "0x3C755A4", VA = "0x3C755A4")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ACCAC", Offset = "0x13ACCAC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x3C755BC", Offset = "0x3C755BC", VA = "0x3C755BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x3C75734", Offset = "0x3C75734", VA = "0x3C75734")]
		private void Start()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x3C755C0", Offset = "0x3C755C0", VA = "0x3C755C0")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x3C757C0", Offset = "0x3C757C0", VA = "0x3C757C0")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x3C7582C", Offset = "0x3C7582C", VA = "0x3C7582C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x3C758DC", Offset = "0x3C758DC", VA = "0x3C758DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x3C75AB0", Offset = "0x3C75AB0", VA = "0x3C75AB0", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x3C75B28", Offset = "0x3C75B28", VA = "0x3C75B28")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x3C75C1C", Offset = "0x3C75C1C", VA = "0x3C75C1C")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF5D8", Offset = "0x13AF5D8")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x17000010")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x3C75CA4", Offset = "0x3C75CA4", VA = "0x3C75CA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA49C", Offset = "0x13BA49C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x3C75CB0", Offset = "0x3C75CB0", VA = "0x3C75CB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA4AC", Offset = "0x13BA4AC")]
			private set
			{
			}
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x3C72DB8", Offset = "0x3C72DB8", VA = "0x3C72DB8")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x3C72E98", Offset = "0x3C72E98", VA = "0x3C72E98")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x3C72F00", Offset = "0x3C72F00", VA = "0x3C72F00")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x3C730A0", Offset = "0x3C730A0", VA = "0x3C730A0")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x3C73280", Offset = "0x3C73280", VA = "0x3C73280")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x3C73390", Offset = "0x3C73390", VA = "0x3C73390")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x3C73428", Offset = "0x3C73428", VA = "0x3C73428")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x3C73874", Offset = "0x3C73874", VA = "0x3C73874")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x3C73974", Offset = "0x3C73974", VA = "0x3C73974")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x3C73A78", Offset = "0x3C73A78", VA = "0x3C73A78")]
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
		[Address(RVA = "0x3C74E78", Offset = "0x3C74E78", VA = "0x3C74E78")]
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
		[Address(RVA = "0x3C746B4", Offset = "0x3C746B4", VA = "0x3C746B4")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x3C74754", Offset = "0x3C74754", VA = "0x3C74754")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x3C747EC", Offset = "0x3C747EC", VA = "0x3C747EC", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x3C74888", Offset = "0x3C74888", VA = "0x3C74888", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x3C74940", Offset = "0x3C74940", VA = "0x3C74940", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x3C749EC", Offset = "0x3C749EC", VA = "0x3C749EC", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x3C74A8C", Offset = "0x3C74A8C", VA = "0x3C74A8C", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x3C74B2C", Offset = "0x3C74B2C", VA = "0x3C74B2C", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x3C74BC8", Offset = "0x3C74BC8", VA = "0x3C74BC8", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x3C74C70", Offset = "0x3C74C70", VA = "0x3C74C70", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x3C74D20", Offset = "0x3C74D20", VA = "0x3C74D20", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x3C74DD0", Offset = "0x3C74DD0", VA = "0x3C74DD0", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x3C74E6C", Offset = "0x3C74E6C", VA = "0x3C74E6C", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x3C72CF8", Offset = "0x3C72CF8", VA = "0x3C72CF8")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x3C74F5C", Offset = "0x3C74F5C", VA = "0x3C74F5C", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x3C74F70", Offset = "0x3C74F70", VA = "0x3C74F70", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x3C74F7C", Offset = "0x3C74F7C", VA = "0x3C74F7C", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x3C74F88", Offset = "0x3C74F88", VA = "0x3C74F88", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x3C74F94", Offset = "0x3C74F94", VA = "0x3C74F94", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x3C75000", Offset = "0x3C75000", VA = "0x3C75000", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x3C7506C", Offset = "0x3C7506C", VA = "0x3C7506C", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x3C750D8", Offset = "0x3C750D8", VA = "0x3C750D8", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x3C75144", Offset = "0x3C75144", VA = "0x3C75144", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x3C751B0", Offset = "0x3C751B0", VA = "0x3C751B0", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x3C7521C", Offset = "0x3C7521C", VA = "0x3C7521C", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x3C72CFC", Offset = "0x3C72CFC", VA = "0x3C72CFC")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ACD10", Offset = "0x13ACD10")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ACD10", Offset = "0x13ACD10")]
	public class AICharacterControl : MonoBehaviour
	{
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF5E8", Offset = "0x13AF5E8")]
		private NavMeshAgent <agent>k__BackingField;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF5F8", Offset = "0x13AF5F8")]
		private ThirdPersonCharacter <character>k__BackingField;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x17000011")]
		public NavMeshAgent agent
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x2C5513C", Offset = "0x2C5513C", VA = "0x2C5513C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA4BC", Offset = "0x13BA4BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x2C55144", Offset = "0x2C55144", VA = "0x2C55144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA4CC", Offset = "0x13BA4CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public ThirdPersonCharacter character
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x2C5514C", Offset = "0x2C5514C", VA = "0x2C5514C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA4DC", Offset = "0x13BA4DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x2C55154", Offset = "0x2C55154", VA = "0x2C55154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA4EC", Offset = "0x13BA4EC")]
			private set
			{
			}
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2C5515C", Offset = "0x2C5515C", VA = "0x2C5515C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2C55210", Offset = "0x2C55210", VA = "0x2C55210")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2C554EC", Offset = "0x2C554EC", VA = "0x2C554EC")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2C554F4", Offset = "0x2C554F4", VA = "0x2C554F4")]
		public AICharacterControl()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ACD9C", Offset = "0x13ACD9C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ACD9C", Offset = "0x13ACD9C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ACD9C", Offset = "0x13ACD9C")]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovingTurnSpeed;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_StationaryTurnSpeed;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AF638", Offset = "0x13AF638")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_RunCycleLegOffset;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MoveSpeedMultiplier;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_AnimSpeedMultiplier;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_GroundCheckDistance;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator m_Animator;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_IsGrounded;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_OrigGroundCheckDistance;

		[Token(Token = "0x40000C0")]
		private const float k_Half = 0.5f;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_TurnAmount;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_ForwardAmount;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 m_GroundNormal;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_CapsuleHeight;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 m_CapsuleCenter;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_Crouching;

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2C554FC", Offset = "0x2C554FC", VA = "0x2C554FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2C55334", Offset = "0x2C55334", VA = "0x2C55334")]
		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2C55AAC", Offset = "0x2C55AAC", VA = "0x2C55AAC")]
		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2C55D48", Offset = "0x2C55D48", VA = "0x2C55D48")]
		private void PreventStandingInLowHeadroom()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2C55F00", Offset = "0x2C55F00", VA = "0x2C55F00")]
		private void UpdateAnimator(Vector3 move)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2C55998", Offset = "0x2C55998", VA = "0x2C55998")]
		private void HandleAirborneMovement()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2C55858", Offset = "0x2C55858", VA = "0x2C55858")]
		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2C55788", Offset = "0x2C55788", VA = "0x2C55788")]
		private void ApplyExtraTurnRotation()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2C5614C", Offset = "0x2C5614C", VA = "0x2C5614C")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2C555F4", Offset = "0x2C555F4", VA = "0x2C555F4")]
		private void CheckGroundStatus()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2C5627C", Offset = "0x2C5627C", VA = "0x2C5627C")]
		public ThirdPersonCharacter()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ACE50", Offset = "0x13ACE50")]
	public class ThirdPersonUserControl : MonoBehaviour
	{
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ThirdPersonCharacter m_Character;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_Cam;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 m_CamForward;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 m_Move;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_Jump;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x3C71BBC", Offset = "0x3C71BBC", VA = "0x3C71BBC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x3C71CC0", Offset = "0x3C71CC0", VA = "0x3C71CC0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x3C71DC0", Offset = "0x3C71DC0", VA = "0x3C71DC0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x3C720D0", Offset = "0x3C720D0", VA = "0x3C720D0")]
		public ThirdPersonUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ACEB4", Offset = "0x13ACEB4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ACEB4", Offset = "0x13ACEB4")]
	public class FirstPersonController : MonoBehaviour
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AF6E8", Offset = "0x13AF6E8")]
		private float m_RunstepLenghten;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MouseLook m_MouseLook;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FOVKick m_FovKick;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioClip m_JumpSound;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AudioClip m_LandSound;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Camera m_Camera;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_Jump;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float m_YRotation;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2 m_Input;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float m_StepCycle;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float m_NextStep;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private bool m_Jumping;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2C52894", Offset = "0x2C52894", VA = "0x2C52894")]
		private void Start()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2C52A1C", Offset = "0x2C52A1C", VA = "0x2C52A1C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2C52B8C", Offset = "0x2C52B8C", VA = "0x2C52B8C")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2C52BE0", Offset = "0x2C52BE0", VA = "0x2C52BE0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2C5314C", Offset = "0x2C5314C", VA = "0x2C5314C")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2C5318C", Offset = "0x2C5318C", VA = "0x2C5318C")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2C53468", Offset = "0x2C53468", VA = "0x2C53468")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2C53290", Offset = "0x2C53290", VA = "0x2C53290")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2C52FA4", Offset = "0x2C52FA4", VA = "0x2C52FA4")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2C52B38", Offset = "0x2C52B38", VA = "0x2C52B38")]
		private void RotateView()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2C538D0", Offset = "0x2C538D0", VA = "0x2C538D0")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2C53A50", Offset = "0x2C53A50", VA = "0x2C53A50")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class HeadBob : MonoBehaviour
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera Camera;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurveControlledBob motionBob;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LerpControlledBob jumpAndLandingBob;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float StrideInterval;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AF7F8", Offset = "0x13AF7F8")]
		public float RunningStrideLengthen;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2C53B58", Offset = "0x2C53B58", VA = "0x2C53B58")]
		private void Start()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2C53BB4", Offset = "0x2C53BB4", VA = "0x2C53BB4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2C53DCC", Offset = "0x2C53DCC", VA = "0x2C53DCC")]
		public HeadBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public class MouseLook
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2C529C8", Offset = "0x2C529C8", VA = "0x2C529C8")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2C535D8", Offset = "0x2C535D8", VA = "0x2C535D8")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2C53F34", Offset = "0x2C53F34", VA = "0x2C53F34")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2C53458", Offset = "0x2C53458", VA = "0x2C53458")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2C53F68", Offset = "0x2C53F68", VA = "0x2C53F68")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2C53E6C", Offset = "0x2C53E6C", VA = "0x2C53E6C")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2C53FE4", Offset = "0x2C53FE4", VA = "0x2C53FE4")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ACF40", Offset = "0x13ACF40")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ACF40", Offset = "0x13ACF40")]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000156")]
		public class MovementSettings
		{
			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float ForwardSpeed;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float BackwardSpeed;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float StrafeSpeed;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float RunMultiplier;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public KeyCode RunKey;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float JumpForce;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnimationCurve SlopeCurveModifier;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public float CurrentTargetSpeed;

			[Token(Token = "0x6000AED")]
			[Address(RVA = "0x2C54D88", Offset = "0x2C54D88", VA = "0x2C54D88")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0x2C54F5C", Offset = "0x2C54F5C", VA = "0x2C54F5C")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000157")]
		public class AdvancedSettings
		{
			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool airControl;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B9FE0", Offset = "0x13B9FE0")]
			public float shellOffset;

			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0x2C55120", Offset = "0x2C55120", VA = "0x2C55120")]
			public AdvancedSettings()
			{
			}
		}

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera cam;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovementSettings movementSettings;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MouseLook mouseLook;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AdvancedSettings advancedSettings;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_YRotation;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_GroundContactNormal;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_Jump;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool m_Jumping;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		private bool m_IsGrounded;

		[Token(Token = "0x17000013")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x2C53DA8", Offset = "0x2C53DA8", VA = "0x2C53DA8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000014")]
		public bool Grounded
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x2C54018", Offset = "0x2C54018", VA = "0x2C54018")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public bool Jumping
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x2C54020", Offset = "0x2C54020", VA = "0x2C54020")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000016")]
		public bool Running
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x2C53DC4", Offset = "0x2C53DC4", VA = "0x2C53DC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2C54028", Offset = "0x2C54028", VA = "0x2C54028")]
		private void Start()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2C540EC", Offset = "0x2C540EC", VA = "0x2C540EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2C54384", Offset = "0x2C54384", VA = "0x2C54384")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2C54A50", Offset = "0x2C54A50", VA = "0x2C54A50")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2C54B08", Offset = "0x2C54B08", VA = "0x2C54B08")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2C54998", Offset = "0x2C54998", VA = "0x2C54998")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2C5417C", Offset = "0x2C5417C", VA = "0x2C5417C")]
		private void RotateView()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2C547B0", Offset = "0x2C547B0", VA = "0x2C547B0")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2C54E54", Offset = "0x2C54E54", VA = "0x2C54E54")]
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
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x13ACFCC", Offset = "0x13ACFCC")]
	public class DTVersionAttribute : Attribute
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Version;

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2C49E10", Offset = "0x2C49E10", VA = "0x2C49E10")]
		public DTVersionAttribute(string version)
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x13AD000", Offset = "0x13AD000")]
	public class DTAttribute : Attribute, IComparable
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF810", Offset = "0x13AF810")]
		private int <TypeSort>k__BackingField;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Sort;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ShowBelowProperty;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Space;

		[Token(Token = "0x17000018")]
		public int TypeSort
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x2C44588", Offset = "0x2C44588", VA = "0x2C44588")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA4FC", Offset = "0x13BA4FC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x2C44590", Offset = "0x2C44590", VA = "0x2C44590")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA50C", Offset = "0x13BA50C")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2C44598", Offset = "0x2C44598", VA = "0x2C44598", Slot = "8")]
		public virtual int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2C41DCC", Offset = "0x2C41DCC", VA = "0x2C41DCC")]
		public DTAttribute(int sortOrder, bool showBelow = false)
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class GroupAttribute : DTAttribute, IDTGroupParsingAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF820", Offset = "0x13AF820")]
		private bool <PathIsAbsolute>k__BackingField;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Expanded;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool Invisible;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Label;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Tooltip;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string HelpURL;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string mPath;

		[Token(Token = "0x17000019")]
		public string Path
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x2C4E904", Offset = "0x2C4E904", VA = "0x2C4E904", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x2C4E90C", Offset = "0x2C4E90C", VA = "0x2C4E90C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public bool PathIsAbsolute
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x2C4EA04", Offset = "0x2C4EA04", VA = "0x2C4EA04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA51C", Offset = "0x13BA51C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x2C4EA0C", Offset = "0x2C4EA0C", VA = "0x2C4EA0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA52C", Offset = "0x13BA52C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2C42168", Offset = "0x2C42168", VA = "0x2C42168")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ActionEnum Action;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ActionPositionEnum Position;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public object ActionData;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MethodInfo mCallback;

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2C41D64", Offset = "0x2C41D64", VA = "0x2C41D64")]
		protected ActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2C41E14", Offset = "0x2C41E14", VA = "0x2C41E14")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string FieldName;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FieldInfo FieldInfo;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropertyInfo PropertyInfo;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object CompareTo;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool CompareFalse;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public OperatorEnum Operator;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MethodInfo MethodInfo;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string MethodName;

			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x2C43B14", Offset = "0x2C43B14", VA = "0x2C43B14")]
			public Condition()
			{
			}
		}

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Condition[] Conditions;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2C439AC", Offset = "0x2C439AC", VA = "0x2C439AC")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2C43B1C", Offset = "0x2C43B1C", VA = "0x2C43B1C")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2C43D24", Offset = "0x2C43D24", VA = "0x2C43D24")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2C43FBC", Offset = "0x2C43FBC", VA = "0x2C43FBC")]
		protected ConditionalAttribute(string methodToQuery)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2C44108", Offset = "0x2C44108", VA = "0x2C44108", Slot = "9")]
		public virtual bool ConditionMet(object classInstance)
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2C441D4", Offset = "0x2C441D4", VA = "0x2C441D4")]
		private bool evaluate(Condition cond, object classInstance)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000036")]
	public class SortOrderAttribute : DTAttribute, IDTFieldParsingAttribute
	{
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2C515C0", Offset = "0x2C515C0", VA = "0x2C515C0")]
		public SortOrderAttribute(int sort = 100)
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class AsGroupAttribute : GroupAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2C42110", Offset = "0x2C42110", VA = "0x2C42110")]
		public AsGroupAttribute([Optional] string pathAndName)
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class TabAttribute : GroupAttribute
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly string TabName;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly string TabBarName;

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2C515F8", Offset = "0x2C515F8", VA = "0x2C515F8")]
		public TabAttribute(string pathAndName)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2C516B0", Offset = "0x2C516B0", VA = "0x2C516B0")]
		private static bool split(string pathAndName, out string path, out string tabBar, out string tabname)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000039")]
	public class SectionAttribute : GroupAttribute
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool Fixed;

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2C4F144", Offset = "0x2C4F144", VA = "0x2C4F144")]
		public SectionAttribute(string name, bool expanded = true, bool fix = false, int sort = 100)
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class NoSectionAttribute : SectionAttribute
	{
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2C4F0A8", Offset = "0x2C4F0A8", VA = "0x2C4F0A8")]
		public NoSectionAttribute()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class Hide : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2C4EA50", Offset = "0x2C4EA50", VA = "0x2C4EA50")]
		public Hide()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class Inline : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2C4EA88", Offset = "0x2C4EA88", VA = "0x2C4EA88")]
		public Inline()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class ArrayExAttribute : DTAttribute, IDTFieldParsingAttribute
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Draggable;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool ShowHeader;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool ShowAdd;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool ShowDelete;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool DropTarget;

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2C420C8", Offset = "0x2C420C8", VA = "0x2C420C8")]
		public ArrayExAttribute()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class FieldActionAttribute : ActionAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2C4E11C", Offset = "0x2C4E11C", VA = "0x2C4E11C")]
		public FieldActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class GroupActionAttribute : ActionAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2C4E89C", Offset = "0x2C4E89C", VA = "0x2C4E89C")]
		public GroupActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class FieldConditionAttribute : ConditionalAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2C4E184", Offset = "0x2C4E184", VA = "0x2C4E184")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false, ActionEnum action = ActionEnum.Show, [Optional] object actionData, ActionPositionEnum position = ActionPositionEnum.Below)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2C4E1D4", Offset = "0x2C4E1D4", VA = "0x2C4E1D4")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2C4E1E0", Offset = "0x2C4E1E0", VA = "0x2C4E1E0")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2C4E200", Offset = "0x2C4E200", VA = "0x2C4E200")]
		public FieldConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class GroupConditionAttribute : ConditionalAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2C4EA18", Offset = "0x2C4EA18", VA = "0x2C4EA18")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2C4EA20", Offset = "0x2C4EA20", VA = "0x2C4EA20")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2C4EA2C", Offset = "0x2C4EA2C", VA = "0x2C4EA2C")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2C4EA4C", Offset = "0x2C4EA4C", VA = "0x2C4EA4C")]
		public GroupConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class Couple<T1, T2>
	{
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF830", Offset = "0x13AF830")]
		private T1 <First>k__BackingField;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF840", Offset = "0x13AF840")]
		private T2 <Second>k__BackingField;

		[Token(Token = "0x1700001B")]
		public T1 First
		{
			[Token(Token = "0x6000143")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA53C", Offset = "0x13BA53C")]
			get
			{
				return (T1)null;
			}
			[Token(Token = "0x6000144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA54C", Offset = "0x13BA54C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public T2 Second
		{
			[Token(Token = "0x6000145")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA55C", Offset = "0x13BA55C")]
			get
			{
				return (T2)null;
			}
			[Token(Token = "0x6000146")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA56C", Offset = "0x13BA56C")]
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
		[Address(RVA = "0x2C4726C", Offset = "0x2C4726C", VA = "0x2C4726C")]
		public static float Ease(EasingMethod method, float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2C488E8", Offset = "0x2C488E8", VA = "0x2C488E8")]
		public static float Ease(EasingMethod method, float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2C4885C", Offset = "0x2C4885C", VA = "0x2C4885C")]
		public static float Linear(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2C49794", Offset = "0x2C49794", VA = "0x2C49794")]
		public static float Linear(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2C473C8", Offset = "0x2C473C8", VA = "0x2C473C8")]
		public static float ExpoOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2C48C24", Offset = "0x2C48C24", VA = "0x2C48C24")]
		public static float ExpoOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2C47300", Offset = "0x2C47300", VA = "0x2C47300")]
		public static float ExpoIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2C48B7C", Offset = "0x2C48B7C", VA = "0x2C48B7C")]
		public static float ExpoIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2C4748C", Offset = "0x2C4748C", VA = "0x2C4748C")]
		public static float ExpoInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2C48CC8", Offset = "0x2C48CC8", VA = "0x2C48CC8")]
		public static float ExpoInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2C475B8", Offset = "0x2C475B8", VA = "0x2C475B8")]
		public static float ExpoOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2C48DDC", Offset = "0x2C48DDC", VA = "0x2C48DDC")]
		public static float ExpoOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2C4772C", Offset = "0x2C4772C", VA = "0x2C4772C")]
		public static float CircOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2C48EB8", Offset = "0x2C48EB8", VA = "0x2C48EB8")]
		public static float CircOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2C47678", Offset = "0x2C47678", VA = "0x2C47678")]
		public static float CircIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2C48E08", Offset = "0x2C48E08", VA = "0x2C48E08")]
		public static float CircIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2C477E0", Offset = "0x2C477E0", VA = "0x2C477E0")]
		public static float CircInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2C48F68", Offset = "0x2C48F68", VA = "0x2C48F68")]
		public static float CircInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2C478F8", Offset = "0x2C478F8", VA = "0x2C478F8")]
		public static float CircOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2C49064", Offset = "0x2C49064", VA = "0x2C49064")]
		public static float CircOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2C47A48", Offset = "0x2C47A48", VA = "0x2C47A48")]
		public static float QuadOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2C490A4", Offset = "0x2C490A4", VA = "0x2C490A4")]
		public static float QuadOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2C479B8", Offset = "0x2C479B8", VA = "0x2C479B8")]
		public static float QuadIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2C49090", Offset = "0x2C49090", VA = "0x2C49090")]
		public static float QuadIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2C47AE0", Offset = "0x2C47AE0", VA = "0x2C47AE0")]
		public static float QuadInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2C490C0", Offset = "0x2C490C0", VA = "0x2C490C0")]
		public static float QuadInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2C47BF8", Offset = "0x2C47BF8", VA = "0x2C47BF8")]
		public static float QuadOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2C491BC", Offset = "0x2C491BC", VA = "0x2C491BC")]
		public static float QuadOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2C47D58", Offset = "0x2C47D58", VA = "0x2C47D58")]
		public static float SineOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2C492AC", Offset = "0x2C492AC", VA = "0x2C492AC")]
		public static float SineOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2C47CB8", Offset = "0x2C47CB8", VA = "0x2C47CB8")]
		public static float SineIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2C49210", Offset = "0x2C49210", VA = "0x2C49210")]
		public static float SineIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2C47DF4", Offset = "0x2C47DF4", VA = "0x2C47DF4")]
		public static float SineInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2C49344", Offset = "0x2C49344", VA = "0x2C49344")]
		public static float SineInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2C47F10", Offset = "0x2C47F10", VA = "0x2C47F10")]
		public static float SineOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2C49448", Offset = "0x2C49448", VA = "0x2C49448")]
		public static float SineOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2C48064", Offset = "0x2C48064", VA = "0x2C48064")]
		public static float CubicOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2C4948C", Offset = "0x2C4948C", VA = "0x2C4948C")]
		public static float CubicOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2C47FD0", Offset = "0x2C47FD0", VA = "0x2C47FD0")]
		public static float CubicIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2C49474", Offset = "0x2C49474", VA = "0x2C49474")]
		public static float CubicIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2C48108", Offset = "0x2C48108", VA = "0x2C48108")]
		public static float CubicInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2C494B4", Offset = "0x2C494B4", VA = "0x2C494B4")]
		public static float CubicInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2C481DC", Offset = "0x2C481DC", VA = "0x2C481DC")]
		public static float CubicOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2C49508", Offset = "0x2C49508", VA = "0x2C49508")]
		public static float CubicOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2C48334", Offset = "0x2C48334", VA = "0x2C48334")]
		public static float QuartOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2C49584", Offset = "0x2C49584", VA = "0x2C49584")]
		public static float QuartOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2C4829C", Offset = "0x2C4829C", VA = "0x2C4829C")]
		public static float QuartIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2C49568", Offset = "0x2C49568", VA = "0x2C49568")]
		public static float QuartIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2C483D8", Offset = "0x2C483D8", VA = "0x2C483D8")]
		public static float QuartInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2C495AC", Offset = "0x2C495AC", VA = "0x2C495AC")]
		public static float QuartInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2C484B0", Offset = "0x2C484B0", VA = "0x2C484B0")]
		public static float QuartOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2C49608", Offset = "0x2C49608", VA = "0x2C49608")]
		public static float QuartOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2C4860C", Offset = "0x2C4860C", VA = "0x2C4860C")]
		public static float QuintOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2C49690", Offset = "0x2C49690", VA = "0x2C49690")]
		public static float QuintOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2C48570", Offset = "0x2C48570", VA = "0x2C48570")]
		public static float QuintIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2C49670", Offset = "0x2C49670", VA = "0x2C49670")]
		public static float QuintIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2C486B8", Offset = "0x2C486B8", VA = "0x2C486B8")]
		public static float QuintInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2C496C0", Offset = "0x2C496C0", VA = "0x2C496C0")]
		public static float QuintInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2C4879C", Offset = "0x2C4879C", VA = "0x2C4879C")]
		public static float QuintOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2C49724", Offset = "0x2C49724", VA = "0x2C49724")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string mIndent;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private StringBuilder mSB;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object mObject;

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2C46088", Offset = "0x2C46088", VA = "0x2C46088")]
		public DTObjectDump(object o, int indent = 0)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2C46FF4", Offset = "0x2C46FF4", VA = "0x2C46FF4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2C463CC", Offset = "0x2C463CC", VA = "0x2C463CC")]
		private void AppendHeader(string name)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2C46454", Offset = "0x2C46454", VA = "0x2C46454")]
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
			[Address(RVA = "0x2C497AC", Offset = "0x2C497AC", VA = "0x2C497AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2C497A4", Offset = "0x2C497A4", VA = "0x2C497A4")]
		public static Material GetDefaultMaterial()
		{
			return null;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2C497B4", Offset = "0x2C497B4", VA = "0x2C497B4")]
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
		[Address(RVA = "0x2C49AE0", Offset = "0x2C49AE0", VA = "0x2C49AE0")]
		public static float RandomSign()
		{
			return default(float);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2C49B0C", Offset = "0x2C49B0C", VA = "0x2C49B0C")]
		public static string GetHelpUrl(object forClass)
		{
			return null;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2C49B7C", Offset = "0x2C49B7C", VA = "0x2C49B7C")]
		public static string GetHelpUrl(Type classType)
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2C49CA8", Offset = "0x2C49CA8", VA = "0x2C49CA8")]
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
			[Address(RVA = "0x2C425B4", Offset = "0x2C425B4", VA = "0x2C425B4")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700001F")]
		public static float deltaTime
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x2C47130", Offset = "0x2C47130", VA = "0x2C47130")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2C4719C", Offset = "0x2C4719C", VA = "0x2C4719C")]
		public static void InitializeEditorTime()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2C47200", Offset = "0x2C47200", VA = "0x2C47200")]
		public static void UpdateEditorTime()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class TimeMeasure : Ring<long>
	{
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Stopwatch mWatch;

		[Token(Token = "0x17000020")]
		public double LastTicks
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x2C52174", Offset = "0x2C52174", VA = "0x2C52174")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000021")]
		public double LastMS
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x2C521E4", Offset = "0x2C521E4", VA = "0x2C521E4")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000022")]
		public double AverageMS
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x2C52204", Offset = "0x2C52204", VA = "0x2C52204")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000023")]
		public double MinimumMS
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x2C522E0", Offset = "0x2C522E0", VA = "0x2C522E0")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000024")]
		public double MaximumMS
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x2C523E4", Offset = "0x2C523E4", VA = "0x2C523E4")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000025")]
		public double AverageTicks
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x2C524E8", Offset = "0x2C524E8", VA = "0x2C524E8")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000026")]
		public double MinimumTicks
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x2C525B8", Offset = "0x2C525B8", VA = "0x2C525B8")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000027")]
		public double MaximumTicks
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x2C526B0", Offset = "0x2C526B0", VA = "0x2C526B0")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2C52028", Offset = "0x2C52028", VA = "0x2C52028")]
		public TimeMeasure(int size)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2C520B4", Offset = "0x2C520B4", VA = "0x2C520B4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2C520D0", Offset = "0x2C520D0", VA = "0x2C520D0")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2C52158", Offset = "0x2C52158", VA = "0x2C52158")]
		public void Pause()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public static class DTMath
	{
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2C44C6C", Offset = "0x2C44C6C", VA = "0x2C44C6C")]
		public static Vector3 ParallelTransportFrame(Vector3 up, Vector3 tan0, Vector3 tan1)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2C44E7C", Offset = "0x2C44E7C", VA = "0x2C44E7C")]
		public static Vector3 LeftTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2C44F2C", Offset = "0x2C44F2C", VA = "0x2C44F2C")]
		public static Vector3 RightTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2C44FDC", Offset = "0x2C44FDC", VA = "0x2C44FDC")]
		public static float Repeat(float t, float length)
		{
			return default(float);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2C45064", Offset = "0x2C45064", VA = "0x2C45064")]
		public static double FixNaN(double v)
		{
			return default(double);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2C450E4", Offset = "0x2C450E4", VA = "0x2C450E4")]
		public static float FixNaN(float v)
		{
			return default(float);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2C45114", Offset = "0x2C45114", VA = "0x2C45114")]
		public static Vector2 FixNaN(Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2C45168", Offset = "0x2C45168", VA = "0x2C45168")]
		public static Vector3 FixNaN(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2C3FF60", Offset = "0x2C3FF60", VA = "0x2C3FF60")]
		public static float MapValue(float min, float max, float value, float vMin = -1f, float vMax = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2C451D8", Offset = "0x2C451D8", VA = "0x2C451D8")]
		public static float SnapPrecision(float value, int decimals)
		{
			return default(float);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2C45260", Offset = "0x2C45260", VA = "0x2C45260")]
		public static Vector2 SnapPrecision(Vector2 value, int decimals)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2C452C0", Offset = "0x2C452C0", VA = "0x2C452C0")]
		public static Vector3 SnapPrecision(Vector3 value, int decimals)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2C45354", Offset = "0x2C45354", VA = "0x2C45354")]
		public static float LinePointDistanceSqr(Vector3 l1, Vector3 l2, Vector3 p, out float frag)
		{
			return default(float);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2C455B0", Offset = "0x2C455B0", VA = "0x2C455B0")]
		public static bool RayLineSegmentIntersection(Vector2 r0, Vector2 dir, Vector2 l1, Vector2 l2, out Vector2 hit, out float frag)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2C45720", Offset = "0x2C45720", VA = "0x2C45720")]
		public static bool ShortestIntersectionLine(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 resultSegmentA, out Vector3 resultSegmentB)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2C45B0C", Offset = "0x2C45B0C", VA = "0x2C45B0C")]
		public static bool LineLineIntersection(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 hitPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2C45C90", Offset = "0x2C45C90", VA = "0x2C45C90")]
		public static bool LineLineIntersect(Vector2 line1A, Vector2 line1B, Vector2 line2A, Vector2 line2B, out Vector2 hitPoint, bool segmentOnly = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2C45E0C", Offset = "0x2C45E0C", VA = "0x2C45E0C")]
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
		[Address(RVA = "0x2C4466C", Offset = "0x2C4466C", VA = "0x2C4466C")]
		public static void Log(object message)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2C446D4", Offset = "0x2C446D4", VA = "0x2C446D4")]
		public static void Log(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2C4474C", Offset = "0x2C4474C", VA = "0x2C4474C")]
		public static void LogError(object message)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2C447B4", Offset = "0x2C447B4", VA = "0x2C447B4")]
		public static void LogError(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2C4482C", Offset = "0x2C4482C", VA = "0x2C4482C")]
		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2C448A4", Offset = "0x2C448A4", VA = "0x2C448A4")]
		public static void LogErrorFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2C44924", Offset = "0x2C44924", VA = "0x2C44924")]
		public static void LogException(Exception exception)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2C4498C", Offset = "0x2C4498C", VA = "0x2C4498C")]
		public static void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2C44A04", Offset = "0x2C44A04", VA = "0x2C44A04")]
		public static void LogFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2C44A7C", Offset = "0x2C44A7C", VA = "0x2C44A7C")]
		public static void LogFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2C42430", Offset = "0x2C42430", VA = "0x2C42430")]
		public static void LogWarning(object message)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2C44AFC", Offset = "0x2C44AFC", VA = "0x2C44AFC")]
		public static void LogWarning(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2C44B74", Offset = "0x2C44B74", VA = "0x2C44B74")]
		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2C44BEC", Offset = "0x2C44BEC", VA = "0x2C44BEC")]
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
			[Address(RVA = "0x2C4E220", Offset = "0x2C4E220", VA = "0x2C4E220")]
			get
			{
				return default(FloatRegion);
			}
		}

		[Token(Token = "0x17000029")]
		public bool Positive
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x2C4E368", Offset = "0x2C4E368", VA = "0x2C4E368")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		public float Low
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x2C4E31C", Offset = "0x2C4E31C", VA = "0x2C4E31C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x2C4E32C", Offset = "0x2C4E32C", VA = "0x2C4E32C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public float High
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x2C4E340", Offset = "0x2C4E340", VA = "0x2C4E340")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x2C4E350", Offset = "0x2C4E350", VA = "0x2C4E350")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public float Random
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x2C4E378", Offset = "0x2C4E378", VA = "0x2C4E378")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public float Next
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x2C4E384", Offset = "0x2C4E384", VA = "0x2C4E384")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002E")]
		public float Length
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x2C4E3A0", Offset = "0x2C4E3A0", VA = "0x2C4E3A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002F")]
		public float LengthPositive
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x2C4E3AC", Offset = "0x2C4E3AC", VA = "0x2C4E3AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2C4E204", Offset = "0x2C4E204", VA = "0x2C4E204")]
		public FloatRegion(float value)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2C4E214", Offset = "0x2C4E214", VA = "0x2C4E214")]
		public FloatRegion(float A, float B)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2C4E22C", Offset = "0x2C4E22C", VA = "0x2C4E22C")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2C4E240", Offset = "0x2C4E240", VA = "0x2C4E240")]
		public void Clamp(float low, float high)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2C4E3C4", Offset = "0x2C4E3C4", VA = "0x2C4E3C4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2C4E460", Offset = "0x2C4E460", VA = "0x2C4E460", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2C4E498", Offset = "0x2C4E498", VA = "0x2C4E498", Slot = "4")]
		public bool Equals(FloatRegion other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2C4E4E8", Offset = "0x2C4E4E8", VA = "0x2C4E4E8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2C4E598", Offset = "0x2C4E598", VA = "0x2C4E598")]
		public static FloatRegion operator +(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2C4E5CC", Offset = "0x2C4E5CC", VA = "0x2C4E5CC")]
		public static FloatRegion operator -(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2C4E600", Offset = "0x2C4E600", VA = "0x2C4E600")]
		public static FloatRegion operator -(FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2C4E618", Offset = "0x2C4E618", VA = "0x2C4E618")]
		public static FloatRegion operator *(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2C4E640", Offset = "0x2C4E640", VA = "0x2C4E640")]
		public static FloatRegion operator *(float v, FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2C4E668", Offset = "0x2C4E668", VA = "0x2C4E668")]
		public static FloatRegion operator /(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2C4E690", Offset = "0x2C4E690", VA = "0x2C4E690")]
		public static bool operator ==(FloatRegion lhs, FloatRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2C4E798", Offset = "0x2C4E798", VA = "0x2C4E798")]
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
			[Address(RVA = "0x2C4EAE4", Offset = "0x2C4EAE4", VA = "0x2C4EAE4")]
			get
			{
				return default(IntRegion);
			}
		}

		[Token(Token = "0x17000031")]
		public bool Positive
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x2C4EC24", Offset = "0x2C4EC24", VA = "0x2C4EC24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000032")]
		public int Low
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x2C4EBD8", Offset = "0x2C4EBD8", VA = "0x2C4EBD8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x2C4EBE8", Offset = "0x2C4EBE8", VA = "0x2C4EBE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public int High
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x2C4EBFC", Offset = "0x2C4EBFC", VA = "0x2C4EBFC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x2C4EC0C", Offset = "0x2C4EC0C", VA = "0x2C4EC0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public int Random
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x2C4EC34", Offset = "0x2C4EC34", VA = "0x2C4EC34")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000035")]
		public int Length
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x2C4EC44", Offset = "0x2C4EC44", VA = "0x2C4EC44")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000036")]
		public int LengthPositive
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x2C4EC50", Offset = "0x2C4EC50", VA = "0x2C4EC50")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2C4EAC8", Offset = "0x2C4EAC8", VA = "0x2C4EAC8")]
		public IntRegion(int value)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2C4EAD8", Offset = "0x2C4EAD8", VA = "0x2C4EAD8")]
		public IntRegion(int A, int B)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2C4EAF0", Offset = "0x2C4EAF0", VA = "0x2C4EAF0")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2C4EB04", Offset = "0x2C4EB04", VA = "0x2C4EB04")]
		public void Clamp(int low, int high)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2C4EC64", Offset = "0x2C4EC64", VA = "0x2C4EC64", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2C4ED00", Offset = "0x2C4ED00", VA = "0x2C4ED00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2C4ED38", Offset = "0x2C4ED38", VA = "0x2C4ED38", Slot = "4")]
		public bool Equals(IntRegion other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2C4ED80", Offset = "0x2C4ED80", VA = "0x2C4ED80", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2C4EE24", Offset = "0x2C4EE24", VA = "0x2C4EE24")]
		public static IntRegion operator +(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2C4EE40", Offset = "0x2C4EE40", VA = "0x2C4EE40")]
		public static IntRegion operator -(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2C4EE5C", Offset = "0x2C4EE5C", VA = "0x2C4EE5C")]
		public static IntRegion operator -(IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2C4EE74", Offset = "0x2C4EE74", VA = "0x2C4EE74")]
		public static IntRegion operator *(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2C4EE8C", Offset = "0x2C4EE8C", VA = "0x2C4EE8C")]
		public static IntRegion operator *(int v, IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2C4EEA8", Offset = "0x2C4EEA8", VA = "0x2C4EEA8")]
		public static IntRegion operator /(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2C4EEC0", Offset = "0x2C4EEC0", VA = "0x2C4EEC0")]
		public static bool operator ==(IntRegion lhs, IntRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2C4EEF8", Offset = "0x2C4EEF8", VA = "0x2C4EEF8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF850", Offset = "0x13AF850")]
		private int <Seed>k__BackingField;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF860", Offset = "0x13AF860")]
		private bool <RandomizeSeed>k__BackingField;

		[Token(Token = "0x17000037")]
		public int Seed
		{
			[Token(Token = "0x60001F9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA57C", Offset = "0x13BA57C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001FA")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA58C", Offset = "0x13BA58C")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool RandomizeSeed
		{
			[Token(Token = "0x60001FB")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA59C", Offset = "0x13BA59C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA5AC", Offset = "0x13BA5AC")]
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
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x13AD038", Offset = "0x13AD038")]
	public class Ring<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mList;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF870", Offset = "0x13AF870")]
		private int <Size>k__BackingField;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mIndex;

		[Token(Token = "0x1700003B")]
		public int Size
		{
			[Token(Token = "0x6000204")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA5BC", Offset = "0x13BA5BC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000205")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA5CC", Offset = "0x13BA5CC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF880", Offset = "0x13AF880")]
		private string <Identifier>k__BackingField;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF890", Offset = "0x13AF890")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA5DC", Offset = "0x13BA5DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000216")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA5EC", Offset = "0x13BA5EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public PoolSettings Settings
		{
			[Token(Token = "0x6000217")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA5FC", Offset = "0x13BA5FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000218")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA60C", Offset = "0x13BA60C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_Prewarm;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool m_AutoCreate;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		[SerializeField]
		private bool m_AutoEnableDisable;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Positive]
		[SerializeField]
		private int m_MinItems;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Positive]
		[SerializeField]
		private int m_Threshold;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Positive]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Debug;

		[Token(Token = "0x17000043")]
		public bool Prewarm
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x2C50500", Offset = "0x2C50500", VA = "0x2C50500")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x2C50318", Offset = "0x2C50318", VA = "0x2C50318")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public bool AutoCreate
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x2C50508", Offset = "0x2C50508", VA = "0x2C50508")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x2C50338", Offset = "0x2C50338", VA = "0x2C50338")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public bool AutoEnableDisable
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x2C50510", Offset = "0x2C50510", VA = "0x2C50510")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x2C50518", Offset = "0x2C50518", VA = "0x2C50518")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public int MinItems
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x2C50538", Offset = "0x2C50538", VA = "0x2C50538")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x2C50358", Offset = "0x2C50358", VA = "0x2C50358")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public int Threshold
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x2C50540", Offset = "0x2C50540", VA = "0x2C50540")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x2C503E4", Offset = "0x2C503E4", VA = "0x2C503E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public float Speed
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x2C50548", Offset = "0x2C50548", VA = "0x2C50548")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x2C50474", Offset = "0x2C50474", VA = "0x2C50474")]
			set
			{
			}
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2C50300", Offset = "0x2C50300", VA = "0x2C50300")]
		public PoolSettings()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2C4FC3C", Offset = "0x2C4FC3C", VA = "0x2C4FC3C")]
		public PoolSettings(PoolSettings src)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2C42208", Offset = "0x2C42208", VA = "0x2C42208")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Label;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Tooltip;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Color;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AttributeOptionsFlags Options;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int Precision;

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2C42070", Offset = "0x2C42070", VA = "0x2C42070")]
		public DTPropertyAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class LabelAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2C4EF34", Offset = "0x2C4EF34", VA = "0x2C4EF34")]
		public LabelAttribute()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2C4EF88", Offset = "0x2C4EF88", VA = "0x2C4EF88")]
		public LabelAttribute(string label, string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class ToggleButtonAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2C527A4", Offset = "0x2C527A4", VA = "0x2C527A4")]
		public ToggleButtonAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class LayerAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2C4EF8C", Offset = "0x2C4EF8C", VA = "0x2C4EF8C")]
		public LayerAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class TagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2C5186C", Offset = "0x2C5186C", VA = "0x2C5186C")]
		public TagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class VectorExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x2C527A8", Offset = "0x2C527A8", VA = "0x2C527A8")]
		public VectorExAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class AnimationCurveExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2C42048", Offset = "0x2C42048", VA = "0x2C42048")]
		public AnimationCurveExAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class MinAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MinValue;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MinFieldOrPropertyName;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x2C4EFF8", Offset = "0x2C4EFF8", VA = "0x2C4EFF8")]
		public MinAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2C4F028", Offset = "0x2C4F028", VA = "0x2C4F028")]
		public MinAttribute(string fieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class PositiveAttribute : MinAttribute
	{
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2C50550", Offset = "0x2C50550", VA = "0x2C50550")]
		public PositiveAttribute()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class MaxAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MaxValue;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MaxFieldOrPropertyName;

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2C4EF90", Offset = "0x2C4EF90", VA = "0x2C4EF90")]
		public MaxAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2C4EFC0", Offset = "0x2C4EFC0", VA = "0x2C4EFC0")]
		public MaxAttribute(string fieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class RangeExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MinValue;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MinFieldOrPropertyName;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MaxValue;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string MaxFieldOrPropertyName;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool Slider;

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2C51480", Offset = "0x2C51480", VA = "0x2C51480")]
		public RangeExAttribute(float minValue, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x2C514C0", Offset = "0x2C514C0", VA = "0x2C514C0")]
		public RangeExAttribute(string minFieldOrProperty, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x2C51514", Offset = "0x2C51514", VA = "0x2C51514")]
		public RangeExAttribute(float minValue, string maxFieldOrProperty, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x2C51564", Offset = "0x2C51564", VA = "0x2C51564")]
		public RangeExAttribute(string minFieldOrProperty, string maxFieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class MinMaxAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string MaxValueField;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Min;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string MinBoundFieldOrPropertyName;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float Max;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string MaxBoundFieldOrPropertyName;

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x2C4F060", Offset = "0x2C4F060", VA = "0x2C4F060")]
		public MinMaxAttribute(string maxValueField, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class EnumFlagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2C4A524", Offset = "0x2C4A524", VA = "0x2C4A524")]
		public EnumFlagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class ObjectSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x2C4F1C8", Offset = "0x2C4F1C8", VA = "0x2C4F1C8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly DialogMode Mode;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Title;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Directory;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string Extension;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string DefaultName;

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2C4F1CC", Offset = "0x2C4F1CC", VA = "0x2C4F1CC")]
		public PathSelectorAttribute(DialogMode mode = DialogMode.OpenFile)
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class EnumSelectionGridAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2C4A528", Offset = "0x2C4A528", VA = "0x2C4A528")]
		public EnumSelectionGridAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class DTRegionAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool RegionIsOptional;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string RegionOptionsPropertyName;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool UseSlider;

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2C470D4", Offset = "0x2C470D4", VA = "0x2C470D4")]
		public DTRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class FloatRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2C4E898", Offset = "0x2C4E898", VA = "0x2C4E898")]
		public FloatRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class IntRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2C4EF30", Offset = "0x2C4EF30", VA = "0x2C4EF30")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA61C", Offset = "0x13BA61C")]
		private void <.ctor>b__6_0(object o)
		{
		}

		[Token(Token = "0x6000261")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA62C", Offset = "0x13BA62C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WaitCallback Callback;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object State;

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2C51478", Offset = "0x2C51478", VA = "0x2C51478")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF2B4", Offset = "0x13AF2B4")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF2C4", Offset = "0x13AF2C4")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action act;

			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x2C51BC4", Offset = "0x2C51BC4", VA = "0x2C51BC4")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0x2C5200C", Offset = "0x2C5200C", VA = "0x2C5200C")]
			internal void <QueueWorkItem>b__0(object x)
			{
			}
		}

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _remainingWorkItems;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ManualResetEvent _done;

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2C51870", Offset = "0x2C51870", VA = "0x2C51870")]
		public void QueueWorkItem(WaitCallback callback)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2C51914", Offset = "0x2C51914", VA = "0x2C51914")]
		public void QueueWorkItem(Action act)
		{
		}

		[Token(Token = "0x6000269")]
		public void ParralelFor<T>(Action<T> action, List<T> list)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2C51A1C", Offset = "0x2C51A1C", VA = "0x2C51A1C")]
		private void QueueWorkItem(QueuedCallback callback)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2C51878", Offset = "0x2C51878", VA = "0x2C51878")]
		public void QueueWorkItem(WaitCallback callback, object state)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2C5191C", Offset = "0x2C5191C", VA = "0x2C5191C")]
		public void QueueWorkItem(Action act, object state)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x2C51BCC", Offset = "0x2C51BCC", VA = "0x2C51BCC")]
		public bool WaitAll()
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x2C51CD8", Offset = "0x2C51CD8", VA = "0x2C51CD8")]
		public bool WaitAll(TimeSpan timeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x2C51BD8", Offset = "0x2C51BD8", VA = "0x2C51BD8")]
		public bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2C51DD4", Offset = "0x2C51DD4", VA = "0x2C51DD4")]
		private void HandleWorkItem(object state)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2C51D24", Offset = "0x2C51D24", VA = "0x2C51D24")]
		private void DoneWorkItem()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x2C51B1C", Offset = "0x2C51B1C", VA = "0x2C51B1C")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2C51EC4", Offset = "0x2C51EC4", VA = "0x2C51EC4", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2C51F8C", Offset = "0x2C51F8C", VA = "0x2C51F8C")]
		public ThreadPoolWorker()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class ComponentPool : MonoBehaviour, IPool, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF2D4", Offset = "0x13AF2D4")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string typeName;

			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0x2C437D4", Offset = "0x2C437D4", VA = "0x2C437D4")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x2C43968", Offset = "0x2C43968", VA = "0x2C43968")]
			internal bool <OnAfterDeserialize>b__0(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private string m_Identifier;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Inline]
		[SerializeField]
		private PoolSettings m_Settings;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PoolManager mManager;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<UnityEngine.Component> mObjects;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private double mLastTime;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double mDeltaTime;

		[Token(Token = "0x1700004D")]
		public PoolSettings Settings
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x2C421B4", Offset = "0x2C421B4", VA = "0x2C421B4", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x2C421BC", Offset = "0x2C421BC", VA = "0x2C421BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public PoolManager Manager
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x2C42240", Offset = "0x2C42240", VA = "0x2C42240")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public string Identifier
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x2C422EC", Offset = "0x2C422EC", VA = "0x2C422EC", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x2C422F4", Offset = "0x2C422F4", VA = "0x2C422F4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public Type Type
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x2C42360", Offset = "0x2C42360", VA = "0x2C42360")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public int Count
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x2C42498", Offset = "0x2C42498", VA = "0x2C42498", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2C424E8", Offset = "0x2C424E8", VA = "0x2C424E8")]
		public void Initialize(Type type, PoolSettings settings)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2C42714", Offset = "0x2C42714", VA = "0x2C42714")]
		private void Start()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2C42738", Offset = "0x2C42738", VA = "0x2C42738")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2C427D4", Offset = "0x2C427D4", VA = "0x2C427D4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2C427D8", Offset = "0x2C427D8", VA = "0x2C427D8", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2C425D0", Offset = "0x2C425D0", VA = "0x2C425D0", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2C42CB0", Offset = "0x2C42CB0", VA = "0x2C42CB0")]
		public void OnSceneLoaded(Scene scn, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2C42DA4", Offset = "0x2C42DA4", VA = "0x2C42DA4", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2C42E78", Offset = "0x2C42E78", VA = "0x2C42E78")]
		public void Push(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2C4316C", Offset = "0x2C4316C", VA = "0x2C4316C")]
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
		[Address(RVA = "0x2C42BC8", Offset = "0x2C42BC8", VA = "0x2C42BC8")]
		private UnityEngine.Component create()
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x2C42B0C", Offset = "0x2C42B0C", VA = "0x2C42B0C")]
		private void destroy(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x2C434E0", Offset = "0x2C434E0", VA = "0x2C434E0")]
		private void setParent(UnityEngine.Component item, Transform parent)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x2C43338", Offset = "0x2C43338", VA = "0x2C43338")]
		private void sendAfterPop(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2C42FC8", Offset = "0x2C42FC8", VA = "0x2C42FC8")]
		private void sendBeforePush(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2C42A40", Offset = "0x2C42A40", VA = "0x2C42A40")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x2C43590", Offset = "0x2C43590", VA = "0x2C43590", Slot = "11")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x2C43594", Offset = "0x2C43594", VA = "0x2C43594", Slot = "12")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x2C438EC", Offset = "0x2C438EC", VA = "0x2C438EC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private string m_Version;

		[Token(Token = "0x17000054")]
		public string Version
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x2C49E44", Offset = "0x2C49E44", VA = "0x2C49E44")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x2C49E4C", Offset = "0x2C49E4C", VA = "0x2C49E4C")]
			protected set
			{
			}
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2C49E54", Offset = "0x2C49E54", VA = "0x2C49E54")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BA63C", Offset = "0x13BA63C")]
		protected void CheckForVersionUpgrade()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2C49E58", Offset = "0x2C49E58", VA = "0x2C49E58", Slot = "4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BA674", Offset = "0x13BA674")]
		protected virtual bool UpgradeVersion(string oldVersion, string newVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2C4A13C", Offset = "0x2C4A13C", VA = "0x2C4A13C")]
		public void Destroy()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x2C4A1F0", Offset = "0x2C4A1F0", VA = "0x2C4A1F0")]
		public DTVersionedMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[ExecuteInEditMode]
	public class DuplicateEditorMesh : MonoBehaviour
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MeshFilter mFilter;

		[Token(Token = "0x17000055")]
		public MeshFilter Filter
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x2C4A1F8", Offset = "0x2C4A1F8", VA = "0x2C4A1F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2C4A2A4", Offset = "0x2C4A2A4", VA = "0x2C4A2A4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x2C4A51C", Offset = "0x2C4A51C", VA = "0x2C4A51C")]
		public DuplicateEditorMesh()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class InspectorNote : MonoBehaviour
	{
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x13AFA20", Offset = "0x13AFA20")]
		[SerializeField]
		private string m_Note;

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x2C4EAC0", Offset = "0x2C4EAC0", VA = "0x2C4EAC0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13AFA60", Offset = "0x13AFA60")]
		[SerializeField]
		private bool m_AutoCreatePools;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "AsGroupAttribute", RVA = "0x13AFAB8", Offset = "0x13AFAB8")]
		[SerializeField]
		private PoolSettings m_DefaultSettings;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AFAFC", Offset = "0x13AFAFC")]
		private bool <IsInitialized>k__BackingField;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, IPool> Pools;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<Type, IPool> TypePools;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IPool[] mPools;

		[Token(Token = "0x17000056")]
		public bool AutoCreatePools
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x2C4F248", Offset = "0x2C4F248", VA = "0x2C4F248")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x2C4F250", Offset = "0x2C4F250", VA = "0x2C4F250")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public PoolSettings DefaultSettings
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x2C4F270", Offset = "0x2C4F270", VA = "0x2C4F270")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x2C4F278", Offset = "0x2C4F278", VA = "0x2C4F278")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public bool IsInitialized
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x2C4F2C4", Offset = "0x2C4F2C4", VA = "0x2C4F2C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA6AC", Offset = "0x13BA6AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x2C4F2CC", Offset = "0x2C4F2CC", VA = "0x2C4F2CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BA6BC", Offset = "0x13BA6BC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public int Count
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x2C4F2D8", Offset = "0x2C4F2D8", VA = "0x2C4F2D8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2C4F358", Offset = "0x2C4F358", VA = "0x2C4F358")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2C4F360", Offset = "0x2C4F360", VA = "0x2C4F360")]
		private void Update()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2C4F4F4", Offset = "0x2C4F4F4", VA = "0x2C4F4F4")]
		private void Initialize()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x2C4F920", Offset = "0x2C4F920", VA = "0x2C4F920")]
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
		[Address(RVA = "0x2C4F9D8", Offset = "0x2C4F9D8", VA = "0x2C4F9D8")]
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
		[Address(RVA = "0x2C4FAD4", Offset = "0x2C4FAD4", VA = "0x2C4FAD4")]
		public PrefabPool CreatePrefabPool(string name, [Optional] PoolSettings settings, params GameObject[] prefabs)
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x2C4FE18", Offset = "0x2C4FE18", VA = "0x2C4FE18")]
		public List<IPool> FindPools(string identifierStartsWith)
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2C4FF88", Offset = "0x2C4FF88", VA = "0x2C4FF88")]
		public void DeletePools(string startsWith)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2C50038", Offset = "0x2C50038", VA = "0x2C50038")]
		public void DeletePool(IPool pool)
		{
		}

		[Token(Token = "0x60002B7")]
		public void DeletePool<T>()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2C501E8", Offset = "0x2C501E8", VA = "0x2C501E8")]
		public PoolManager()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AD0B8", Offset = "0x13AD0B8")]
	public class PrefabPool : MonoBehaviour, IPool
	{
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13AFB0C", Offset = "0x13AFB0C")]
		[SerializeField]
		private string m_Identifier;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> m_Prefabs;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Inline]
		[SerializeField]
		private PoolSettings m_Settings;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PoolManager mManager;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<GameObject> mObjects;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double mLastTime;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private double mDeltaTime;

		[Token(Token = "0x1700005A")]
		public string Identifier
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x2C505AC", Offset = "0x2C505AC", VA = "0x2C505AC", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x2C505B4", Offset = "0x2C505B4", VA = "0x2C505B4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public List<GameObject> Prefabs
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x2C506E0", Offset = "0x2C506E0", VA = "0x2C506E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x2C506E8", Offset = "0x2C506E8", VA = "0x2C506E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public PoolSettings Settings
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x2C50700", Offset = "0x2C50700", VA = "0x2C50700", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x2C50708", Offset = "0x2C50708", VA = "0x2C50708")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public PoolManager Manager
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x2C50634", Offset = "0x2C50634", VA = "0x2C50634")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public int Count
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x2C50B28", Offset = "0x2C50B28", VA = "0x2C50B28", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x2C50754", Offset = "0x2C50754", VA = "0x2C50754")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x2C50758", Offset = "0x2C50758", VA = "0x2C50758")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x2C4FCF0", Offset = "0x2C4FCF0", VA = "0x2C4FCF0")]
		public void Initialize(string ident, PoolSettings settings, params GameObject[] prefabs)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x2C508C0", Offset = "0x2C508C0", VA = "0x2C508C0", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x2C5077C", Offset = "0x2C5077C", VA = "0x2C5077C", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x2C50E68", Offset = "0x2C50E68", VA = "0x2C50E68", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x2C50F3C", Offset = "0x2C50F3C", VA = "0x2C50F3C")]
		public GameObject Pop([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x2C5115C", Offset = "0x2C5115C", VA = "0x2C5115C", Slot = "11")]
		public virtual void Push(GameObject item)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x2C50CAC", Offset = "0x2C50CAC", VA = "0x2C50CAC")]
		private GameObject create()
		{
			return null;
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x2C50C44", Offset = "0x2C50C44", VA = "0x2C50C44")]
		private void destroy(GameObject go)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x2C50B78", Offset = "0x2C50B78", VA = "0x2C50B78")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x2C5132C", Offset = "0x2C5132C", VA = "0x2C5132C")]
		private void setParent(Transform item, Transform parent)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x2C510FC", Offset = "0x2C510FC", VA = "0x2C510FC")]
		private void sendAfterPop(GameObject item)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x2C512CC", Offset = "0x2C512CC", VA = "0x2C512CC")]
		private void sendBeforePush(GameObject item)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x2C513D0", Offset = "0x2C513D0", VA = "0x2C513D0")]
		public PrefabPool()
		{
		}
	}
}
namespace FluffyUnderware.DevTools.Extensions
{
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13AD11C", Offset = "0x13AD11C")]
	public static class TransformExt
	{
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x2C4CC98", Offset = "0x2C4CC98", VA = "0x2C4CC98")]
		public static void CopyFrom(this Transform t, Transform other)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x2C4CD08", Offset = "0x2C4CD08", VA = "0x2C4CD08")]
		public static void SetChildrenHideFlags(this Transform t, HideFlags flags)
		{
		}
	}
	[Token(Token = "0x2000078")]
	public static class ObjectExt
	{
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x2C4C114", Offset = "0x2C4C114", VA = "0x2C4C114")]
		public static void Destroy(this UnityEngine.Object c)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x2C4C17C", Offset = "0x2C4C17C", VA = "0x2C4C17C")]
		public static string ToDumpString(this object o)
		{
			return null;
		}
	}
	[Token(Token = "0x2000079")]
	public static class Vector2Ext
	{
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x2C4DA80", Offset = "0x2C4DA80", VA = "0x2C4DA80")]
		public static Vector2 Snap(this Vector2 v, float snapX, float snapY = -1f)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x2C4DAEC", Offset = "0x2C4DAEC", VA = "0x2C4DAEC")]
		public static float AngleSigned(this Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x2C4DBC4", Offset = "0x2C4DBC4", VA = "0x2C4DBC4")]
		public static Vector2 LeftNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x2C4DBFC", Offset = "0x2C4DBFC", VA = "0x2C4DBFC")]
		public static Vector2 RightNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x2C4DC34", Offset = "0x2C4DC34", VA = "0x2C4DC34")]
		public static Vector2 Rotate(this Vector2 v, float degree)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x2C4DCF8", Offset = "0x2C4DCF8", VA = "0x2C4DCF8")]
		public static Vector2 ToVector3(this Vector2 v)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x200007A")]
	public static class Vector3Ext
	{
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x2C4DD9C", Offset = "0x2C4DD9C", VA = "0x2C4DD9C")]
		public static float AngleSigned(this Vector3 a, Vector3 b, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x2C4DEE0", Offset = "0x2C4DEE0", VA = "0x2C4DEE0")]
		public static Vector3 RotateAround(this Vector3 point, Vector3 origin, Quaternion rotation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2C4E010", Offset = "0x2C4E010", VA = "0x2C4E010")]
		public static Vector2 ToVector2(this Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x2C4E03C", Offset = "0x2C4E03C", VA = "0x2C4E03C")]
		public static bool Approximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x2C4E100", Offset = "0x2C4E100", VA = "0x2C4E100")]
		public static bool NotApproximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200007B")]
	public static class QuaternionExt
	{
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2C4C1F0", Offset = "0x2C4C1F0", VA = "0x2C4C1F0")]
		public static bool SameOrientation(this Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x2C4C2F0", Offset = "0x2C4C2F0", VA = "0x2C4C2F0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Vector3 camPos;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static Vector3 camForward;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float fov;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static float screenW;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static float screenH;

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x2C4A52C", Offset = "0x2C4A52C", VA = "0x2C4A52C")]
		public static bool BoundsInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x2C4A87C", Offset = "0x2C4A87C", VA = "0x2C4A87C")]
		public static bool BoundsPartiallyInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200007D")]
	public static class GameObjectExt
	{
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x2C4B844", Offset = "0x2C4B844", VA = "0x2C4B844")]
		public static GameObject DuplicateGameObject(this GameObject source, Transform newParent, bool keepPrefabReference = false)
		{
			return null;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x2C4B174", Offset = "0x2C4B174", VA = "0x2C4B174")]
		public static void StripComponents(this GameObject go, params Type[] toKeep)
		{
		}
	}
	[Token(Token = "0x200007E")]
	public static class ComponentExt
	{
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x2C4B088", Offset = "0x2C4B088", VA = "0x2C4B088")]
		public static void StripComponents(this UnityEngine.Component c, params Type[] toKeep)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x2C4B35C", Offset = "0x2C4B35C", VA = "0x2C4B35C")]
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
		[Address(RVA = "0x2C4B408", Offset = "0x2C4B408", VA = "0x2C4B408")]
		public static UnityEngine.Component DuplicateGameObject(this UnityEngine.Component source, Transform newParent, bool keepPrefabConnection = false)
		{
			return null;
		}
	}
	[Token(Token = "0x200007F")]
	public static class ColorExt
	{
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x2C4AE74", Offset = "0x2C4AE74", VA = "0x2C4AE74")]
		public static string ToHtml(this Color c)
		{
			return null;
		}
	}
	[Token(Token = "0x2000080")]
	public static class EnumExt
	{
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x2C4B62C", Offset = "0x2C4B62C", VA = "0x2C4B62C")]
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
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BA8BC", Offset = "0x13BA8BC")]
		public static T Toggle<T>(this Enum value, T toggleValue)
		{
			return (T)null;
		}

		[Token(Token = "0x60002F1")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BA908", Offset = "0x13BA908")]
		public static T SetAll<T>(this Enum value)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000081")]
	public static class RectExt
	{
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x2C4C3F0", Offset = "0x2C4C3F0", VA = "0x2C4C3F0")]
		public static Rect Set(this Rect rect, Vector2 pos, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x2C4C44C", Offset = "0x2C4C44C", VA = "0x2C4C44C")]
		public static Rect SetBetween(this Rect rect, Vector2 pos, Vector2 pos2)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x2C4C4A8", Offset = "0x2C4C4A8", VA = "0x2C4C4A8")]
		public static Rect SetPosition(this Rect rect, Vector2 pos)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x2C4C514", Offset = "0x2C4C514", VA = "0x2C4C514")]
		public static Rect SetPosition(this Rect rect, float x, float y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x2C4C580", Offset = "0x2C4C580", VA = "0x2C4C580")]
		public static Vector2 GetSize(this Rect rect)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x2C4C5E0", Offset = "0x2C4C5E0", VA = "0x2C4C5E0")]
		public static Rect SetSize(this Rect rect, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x2C4C64C", Offset = "0x2C4C64C", VA = "0x2C4C64C")]
		public static Rect ScaleBy(this Rect rect, int pixel)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x2C4C654", Offset = "0x2C4C654", VA = "0x2C4C654")]
		public static Rect ScaleBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x2C4C72C", Offset = "0x2C4C72C", VA = "0x2C4C72C")]
		public static Rect ShiftBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x2C4C7BC", Offset = "0x2C4C7BC", VA = "0x2C4C7BC")]
		public static Rect Include(this Rect rect, Rect other)
		{
			return default(Rect);
		}
	}
	[Token(Token = "0x2000082")]
	public static class StringExt
	{
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x2C4C928", Offset = "0x2C4C928", VA = "0x2C4C928")]
		public static Color ColorFromHtml(this string hexString)
		{
			return default(Color);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x2C4CBE4", Offset = "0x2C4CBE4", VA = "0x2C4CBE4")]
		public static string TrimStart(this string s, string trim, StringComparison compare = StringComparison.CurrentCultureIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x2C4CC38", Offset = "0x2C4CC38", VA = "0x2C4CC38")]
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
		[Address(RVA = "0x2C4B940", Offset = "0x2C4B940", VA = "0x2C4B940")]
		public static Mesh PrepareNewShared(this MeshFilter m, string name = "Mesh")
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x2C4BAC4", Offset = "0x2C4BAC4", VA = "0x2C4BAC4")]
		public static void CalculateTangents(this MeshFilter m)
		{
		}
	}
	[Token(Token = "0x2000086")]
	public static class TypeExt
	{
		[Serializable]
		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF2E4", Offset = "0x13AF2E4")]
		private sealed class <>c
		{
			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, IEnumerable<Type>> <>9__1_0;

			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x2C4DA54", Offset = "0x2C4DA54", VA = "0x2C4DA54")]
			public <>c()
			{
			}

			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x2C4DA5C", Offset = "0x2C4DA5C", VA = "0x2C4DA5C")]
			internal IEnumerable<Type> <GetLoadedTypes>b__1_0(Assembly a)
			{
				return null;
			}
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x2C4CDD8", Offset = "0x2C4CDD8", VA = "0x2C4CDD8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BAAE4", Offset = "0x13BAAE4")]
		public static Type[] GetAllTypes(this Type typeFromAssembly)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x2C437DC", Offset = "0x2C437DC", VA = "0x2C437DC")]
		public static Type[] GetLoadedTypes()
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x2C4CE10", Offset = "0x2C4CE10", VA = "0x2C4CE10")]
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
		[Address(RVA = "0x2C42014", Offset = "0x2C42014", VA = "0x2C42014")]
		public static MethodInfo MethodByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x2C44518", Offset = "0x2C44518", VA = "0x2C44518")]
		public static FieldInfo FieldByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x2C44554", Offset = "0x2C44554", VA = "0x2C44554")]
		public static PropertyInfo PropertyByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x2C4624C", Offset = "0x2C4624C", VA = "0x2C4624C")]
		public static FieldInfo[] GetAllFields(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x2C46E74", Offset = "0x2C46E74", VA = "0x2C46E74")]
		public static PropertyInfo[] GetAllProperties(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x2C4D2A0", Offset = "0x2C4D2A0", VA = "0x2C4D2A0")]
		public static bool IsFrameworkType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x2C4D3AC", Offset = "0x2C4D3AC", VA = "0x2C4D3AC")]
		public static bool IsArrayOrList(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x2C47014", Offset = "0x2C47014", VA = "0x2C47014")]
		public static Type GetEnumerableType(this Type t)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x2C4D494", Offset = "0x2C4D494", VA = "0x2C4D494")]
		private static Type FindIEnumerable(Type seqType)
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x2C4CE34", Offset = "0x2C4CE34", VA = "0x2C4CE34")]
		private static MethodInfo GetMethodIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x2C4CFA8", Offset = "0x2C4CFA8", VA = "0x2C4CFA8")]
		private static FieldInfo GetFieldIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x2C4D12C", Offset = "0x2C4D12C", VA = "0x2C4D12C")]
		private static PropertyInfo GetPropertyIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x2C4D8F0", Offset = "0x2C4D8F0", VA = "0x2C4D8F0")]
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
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AD268", Offset = "0x13AD268")]
	public class MetaCGOptions : CurvyMetadataBase
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Positive]
		[SerializeField]
		private int m_MaterialID;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_HardEdge;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Positive]
		[SerializeField]
		private float m_MaxStepDistance;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13AFC7C", Offset = "0x13AFC7C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13AFC7C", Offset = "0x13AFC7C")]
		[SerializeField]
		private bool m_UVEdge;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13AFD7C", Offset = "0x13AFD7C")]
		[SerializeField]
		private bool m_ExplicitU;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13AFE40", Offset = "0x13AFE40")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x13AFE40", Offset = "0x13AFE40")]
		[Positive]
		[SerializeField]
		private float m_FirstU;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13AFF2C", Offset = "0x13AFF2C")]
		[Positive]
		[SerializeField]
		private float m_SecondU;

		[Token(Token = "0x1700005F")]
		public int MaterialID
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x290DB90", Offset = "0x290DB90", VA = "0x290DB90")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x290DB98", Offset = "0x290DB98", VA = "0x290DB98")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public bool HardEdge
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x290DC3C", Offset = "0x290DC3C", VA = "0x290DC3C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x290DC44", Offset = "0x290DC44", VA = "0x290DC44")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public bool UVEdge
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x290DC6C", Offset = "0x290DC6C", VA = "0x290DC6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x290DC74", Offset = "0x290DC74", VA = "0x290DC74")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public bool ExplicitU
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x290DC9C", Offset = "0x290DC9C", VA = "0x290DC9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x290DCA4", Offset = "0x290DCA4", VA = "0x290DCA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public float FirstU
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x290DCCC", Offset = "0x290DCCC", VA = "0x290DCCC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x290DCD4", Offset = "0x290DCD4", VA = "0x290DCD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public float SecondU
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x290DCF0", Offset = "0x290DCF0", VA = "0x290DCF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x290DCF8", Offset = "0x290DCF8", VA = "0x290DCF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public float MaxStepDistance
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x290DD14", Offset = "0x290DD14", VA = "0x290DD14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x290DD1C", Offset = "0x290DD1C", VA = "0x290DD1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public bool HasDifferentMaterial
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x290CDE4", Offset = "0x290CDE4", VA = "0x290CDE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		private bool showUVEdge
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x290DDC0", Offset = "0x290DDC0", VA = "0x290DDC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		private bool showExplicitU
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x290DF10", Offset = "0x290DF10", VA = "0x290DF10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		private bool showFirstU
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x290DFA4", Offset = "0x290DFA4", VA = "0x290DFA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		private bool showSecondU
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x290E044", Offset = "0x290E044", VA = "0x290E044")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x290E058", Offset = "0x290E058", VA = "0x290E058")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x290CD30", Offset = "0x290CD30", VA = "0x290CD30")]
		public float GetDefinedFirstU(float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x290CD7C", Offset = "0x290CD7C", VA = "0x290CD7C")]
		public float GetDefinedSecondU(float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x290E110", Offset = "0x290E110", VA = "0x290E110")]
		public MetaCGOptions()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13AD2A0", Offset = "0x13AD2A0")]
	public interface ICurvyMetadata
	{
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13AD2D8", Offset = "0x13AD2D8")]
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
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13AD310", Offset = "0x13AD310")]
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
		[Address(RVA = "0x1FC2A28", Offset = "0x1FC2A28", VA = "0x1FC2A28")]
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
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x13AD368", Offset = "0x13AD368")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AD368", Offset = "0x13AD368")]
	public class CurvyConnection : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x2000162")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF2F4", Offset = "0x13AF2F4")]
		private sealed class <>c
		{
			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<CurvySplineSegment> <>9__24_0;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<CurvySplineSegment> <>9__25_0;

			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0x1FCD798", Offset = "0x1FCD798", VA = "0x1FCD798")]
			public <>c()
			{
			}

			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0x1FCD7A0", Offset = "0x1FCD7A0", VA = "0x1FCD7A0")]
			internal bool <OnBeforeSerialize>b__24_0(CurvySplineSegment cp)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0x1FCD7AC", Offset = "0x1FCD7AC", VA = "0x1FCD7AC")]
			internal bool <OnAfterDeserialize>b__25_0(CurvySplineSegment cp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Hide]
		private List<CurvySplineSegment> m_ControlPoints;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ReadOnlyCollection<CurvySplineSegment> readOnlyControlPoints;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Couple<Vector3, Quaternion> processedConnectionCoordinates;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<CurvySplineSegment, Couple<Vector3, Quaternion>> processedControlPointsCoordinates;

		[Token(Token = "0x1700006C")]
		public ReadOnlyCollection<CurvySplineSegment> ControlPointsList
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x1FC8F38", Offset = "0x1FC8F38", VA = "0x1FC8F38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public int Count
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x1FCC060", Offset = "0x1FCC060", VA = "0x1FCC060")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006E")]
		public CurvySplineSegment Item
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x1FCC0B0", Offset = "0x1FCC0B0", VA = "0x1FCC0B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1FCC128", Offset = "0x1FCC128", VA = "0x1FCC128")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1FCC338", Offset = "0x1FCC338", VA = "0x1FCC338")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1FCC33C", Offset = "0x1FCC33C", VA = "0x1FCC33C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1FCC788", Offset = "0x1FCC788", VA = "0x1FCC788")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1FCC7C0", Offset = "0x1FCC7C0", VA = "0x1FCC7C0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1FCC7F8", Offset = "0x1FCC7F8", VA = "0x1FCC7F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1FCC920", Offset = "0x1FCC920", VA = "0x1FCC920")]
		public static CurvyConnection Create(params CurvySplineSegment[] controlPoints)
		{
			return null;
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1FCCABC", Offset = "0x1FCCABC", VA = "0x1FCCABC")]
		public void AddControlPoints(params CurvySplineSegment[] controlPoints)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1FCCC9C", Offset = "0x1FCCC9C", VA = "0x1FCCC9C")]
		public void AutoSetFollowUp()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1FCCF68", Offset = "0x1FCCF68", VA = "0x1FCCF68")]
		public void RemoveControlPoint(CurvySplineSegment controlPoint, bool destroySelfIfEmpty = true)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1FCD030", Offset = "0x1FCD030", VA = "0x1FCD030")]
		public void Delete()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1FCD0C4", Offset = "0x1FCD0C4", VA = "0x1FCD0C4")]
		public List<CurvySplineSegment> OtherControlPoints(CurvySplineSegment source)
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1FCD160", Offset = "0x1FCD160", VA = "0x1FCD160")]
		public void SetSynchronisationPositionAndRotation(Vector3 referencePosition, Quaternion referenceRotation)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1FCC374", Offset = "0x1FCC374", VA = "0x1FCC374")]
		private void DoUpdate()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1FCD480", Offset = "0x1FCD480", VA = "0x1FCD480", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1FCD580", Offset = "0x1FCD580", VA = "0x1FCD580", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1FCD680", Offset = "0x1FCD680", VA = "0x1FCD680")]
		public CurvyConnection()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class CurvyEventArgs : EventArgs
	{
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly MonoBehaviour Sender;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly object Data;

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1FC5190", Offset = "0x1FC5190", VA = "0x1FC5190")]
		public CurvyEventArgs(MonoBehaviour sender, object data)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009D")]
	public class CurvySplineEvent : UnityEventEx<CurvySplineEventArgs>
	{
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x2BA9ED4", Offset = "0x2BA9ED4", VA = "0x2BA9ED4")]
		public CurvySplineEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009E")]
	public class CurvyControlPointEvent : UnityEventEx<CurvyControlPointEventArgs>
	{
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1FCD7B8", Offset = "0x1FCD7B8", VA = "0x1FCD7B8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ModeEnum Mode;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly CurvySplineSegment ControlPoint;

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1FCD808", Offset = "0x1FCD808", VA = "0x1FCD808")]
		public CurvyControlPointEventArgs(MonoBehaviour sender, CurvySpline spline, CurvySplineSegment cp, ModeEnum mode = ModeEnum.None, [Optional] object data)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class CurvySplineEventArgs : CurvyEventArgs
	{
		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly CurvySpline Spline;

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x2BA9F24", Offset = "0x2BA9F24", VA = "0x2BA9F24")]
		public CurvySplineEventArgs(MonoBehaviour sender, CurvySpline spline, [Optional] object data)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A1")]
	public class CurvyCGEvent : UnityEventEx<CurvyCGEventArgs>
	{
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1FCBEBC", Offset = "0x1FCBEBC", VA = "0x1FCBEBC")]
		public CurvyCGEvent()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class CurvyCGEventArgs : EventArgs
	{
		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly MonoBehaviour Sender;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly CurvyGenerator Generator;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly CGModule Module;

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1FCBF0C", Offset = "0x1FCBF0C", VA = "0x1FCBF0C")]
		public CurvyCGEventArgs(CGModule module)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1FCBFB8", Offset = "0x1FCBFB8", VA = "0x1FCBFB8")]
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
		[Address(RVA = "0x1FCD854", Offset = "0x1FCD854", VA = "0x1FCD854")]
		public static void SegmentCurveGizmo(CurvySplineSegment seg, Color col, float stepSize = 0.05f)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1FCDA88", Offset = "0x1FCDA88", VA = "0x1FCDA88")]
		public static void SegmentApproximationGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1FCDD00", Offset = "0x1FCDD00", VA = "0x1FCDD00")]
		public static void SegmentOrientationAnchorGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1FCDFA4", Offset = "0x1FCDFA4", VA = "0x1FCDFA4")]
		public static void SegmentOrientationGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1FCE280", Offset = "0x1FCE280", VA = "0x1FCE280")]
		public static void SegmentTangentGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1FCE4F0", Offset = "0x1FCE4F0", VA = "0x1FCE4F0")]
		public static void ControlPointGizmo(CurvySplineSegment cp, bool selected, Color col)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1FCE8B4", Offset = "0x1FCE8B4", VA = "0x1FCE8B4")]
		public static void BoundsGizmo(CurvySplineSegment cp, Color col)
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AD3D8", Offset = "0x13AD3D8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PoolManager mPoolManager;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ComponentPool mControlPointPool;

		[Token(Token = "0x1700006F")]
		public static bool ShowCurveGizmo
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x1FCEACC", Offset = "0x1FCEACC", VA = "0x1FCEACC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x1FCEB38", Offset = "0x1FCEB38", VA = "0x1FCEB38")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public static bool ShowApproximationGizmo
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x1FCEBD4", Offset = "0x1FCEBD4", VA = "0x1FCEBD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x1FCEC40", Offset = "0x1FCEC40", VA = "0x1FCEC40")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public static bool ShowTangentsGizmo
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x1FCECDC", Offset = "0x1FCECDC", VA = "0x1FCECDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x1FCED48", Offset = "0x1FCED48", VA = "0x1FCED48")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public static bool ShowOrientationGizmo
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x1FCEDE4", Offset = "0x1FCEDE4", VA = "0x1FCEDE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x1FCEE50", Offset = "0x1FCEE50", VA = "0x1FCEE50")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public static bool ShowLabelsGizmo
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x1FCEEEC", Offset = "0x1FCEEEC", VA = "0x1FCEEEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x1FCEF58", Offset = "0x1FCEF58", VA = "0x1FCEF58")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public static bool ShowMetadataGizmo
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x1FCEFF4", Offset = "0x1FCEFF4", VA = "0x1FCEFF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x1FCF060", Offset = "0x1FCF060", VA = "0x1FCF060")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public static bool ShowBoundsGizmo
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x1FCF0FC", Offset = "0x1FCF0FC", VA = "0x1FCF0FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x1FCF168", Offset = "0x1FCF168", VA = "0x1FCF168")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public PoolManager PoolManager
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x1FCF204", Offset = "0x1FCF204", VA = "0x1FCF204")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public ComponentPool ControlPointPool
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x1FCF2B0", Offset = "0x1FCF2B0", VA = "0x1FCF2B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public CurvyConnection[] Connections
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x1FCF2B8", Offset = "0x1FCF2B8", VA = "0x1FCF2B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1FCF308", Offset = "0x1FCF308", VA = "0x1FCF308")]
		public CurvyConnection[] GetContainingConnections(params CurvySpline[] splines)
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1FCFAB4", Offset = "0x1FCFAB4", VA = "0x1FCFAB4", Slot = "5")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1FCFC3C", Offset = "0x1FCFC3C", VA = "0x1FCFC3C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1FCFCD0", Offset = "0x1FCFCD0", VA = "0x1FCFCD0")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x13BAC40", Offset = "0x13BAC40")]
		private static void LoadRuntimeSettings()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1FCFF58", Offset = "0x1FCFF58", VA = "0x1FCFF58")]
		public static void SaveRuntimeSettings()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1FD013C", Offset = "0x1FD013C", VA = "0x1FD013C", Slot = "7")]
		public override void MergeDoubleLoaded(IDTSingleton newInstance)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1FD0258", Offset = "0x1FD0258", VA = "0x1FD0258")]
		public CurvyGlobalManager()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13AD44C", Offset = "0x13AD44C")]
	public abstract class CurvyInterpolatableMetadataBase : CurvyMetadataBase, ICurvyInterpolatableMetadata, ICurvyMetadata
	{
		[Token(Token = "0x17000079")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BBA60", Offset = "0x13BBA60")]
		public abstract object Value
		{
			[Token(Token = "0x6000377")]
			get;
		}

		[Token(Token = "0x6000378")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BAC50", Offset = "0x13BAC50")]
		public abstract object InterpolateObject(ICurvyMetadata b, float f);

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1FD0404", Offset = "0x1FD0404", VA = "0x1FD0404")]
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
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BBA98", Offset = "0x13BBA98")]
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
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BAC88", Offset = "0x13BAC88")]
		public override object InterpolateObject(ICurvyMetadata b, float f)
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BACC0", Offset = "0x13BACC0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvySplineSegment mCP;

		[Token(Token = "0x1700007C")]
		public CurvySplineSegment ControlPoint
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x1FD0414", Offset = "0x1FD0414", VA = "0x1FD0414")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x1FD041C", Offset = "0x1FD041C", VA = "0x1FD041C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1FD04A8", Offset = "0x1FD04A8", VA = "0x1FD04A8", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1FD0520", Offset = "0x1FD0520", VA = "0x1FD0520")]
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
		[Address(RVA = "0x1FD0540", Offset = "0x1FD0540", VA = "0x1FD0540")]
		protected void NotifyModification()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1FD040C", Offset = "0x1FD040C", VA = "0x1FD040C")]
		public CurvyMetadataBase()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x13AD4B8", Offset = "0x13AD4B8")]
	public class CGResourceManagerAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string ResourceName;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool ReadOnly;

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1FC143C", Offset = "0x1FC143C", VA = "0x1FC143C")]
		public CGResourceManagerAttribute(string resourceName)
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x13AD4F0", Offset = "0x13AD4F0")]
	public sealed class CGResourceCollectionManagerAttribute : CGResourceManagerAttribute
	{
		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool ShowCount;

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1FC1414", Offset = "0x1FC1414", VA = "0x1FC1414")]
		public CGResourceCollectionManagerAttribute(string resourceName)
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x13AD528", Offset = "0x13AD528")]
	public sealed class CGDataReferenceSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly Type DataType;

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1FC13A0", Offset = "0x1FC13A0", VA = "0x1FC13A0")]
		public CGDataReferenceSelectorAttribute(Type dataType)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AD560", Offset = "0x13AD560")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AD560", Offset = "0x13AD560")]
	public class CurvyShape : DTVersionedMonoBehaviour
	{
		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B0028", Offset = "0x13B0028")]
		private CurvyPlane m_Plane;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		private bool m_Persistent;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<CurvyShapeInfo, Type> mShapeDefs;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CurvySpline mSpline;

		[NonSerialized]
		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool Dirty;

		[Token(Token = "0x1700007E")]
		public CurvyPlane Plane
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x1FD05E4", Offset = "0x1FD05E4", VA = "0x1FD05E4")]
			get
			{
				return default(CurvyPlane);
			}
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x1FD05EC", Offset = "0x1FD05EC", VA = "0x1FD05EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public bool Persistent
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x1FD0608", Offset = "0x1FD0608", VA = "0x1FD0608")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x1FD0610", Offset = "0x1FD0610", VA = "0x1FD0610")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public CurvySpline Spline
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x1FD0644", Offset = "0x1FD0644", VA = "0x1FD0644")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public static Dictionary<CurvyShapeInfo, Type> ShapeDefinitions
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x1FD1D04", Offset = "0x1FD1D04", VA = "0x1FD1D04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1FD06EC", Offset = "0x1FD06EC", VA = "0x1FD06EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1FD0820", Offset = "0x1FD0820", VA = "0x1FD0820", Slot = "5")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1FD0838", Offset = "0x1FD0838", VA = "0x1FD0838")]
		public void Delete()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1FD072C", Offset = "0x1FD072C", VA = "0x1FD072C")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1FD0994", Offset = "0x1FD0994", VA = "0x1FD0994")]
		public CurvyShape Replace(string menuName)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1FD0C98", Offset = "0x1FD0C98", VA = "0x1FD0C98")]
		protected void PrepareSpline(CurvyInterpolation interpolation, CurvyOrientation orientation = CurvyOrientation.Dynamic, int cachedensity = 50, bool closed = true)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1FD0F88", Offset = "0x1FD0F88", VA = "0x1FD0F88")]
		protected void SetPosition(int no, Vector3 position)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1FD1030", Offset = "0x1FD1030", VA = "0x1FD1030")]
		protected void SetRotation(int no, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1FD10E0", Offset = "0x1FD10E0", VA = "0x1FD10E0")]
		protected void SetBezierHandles(int no, float distanceFrag)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1FD10E8", Offset = "0x1FD10E8", VA = "0x1FD10E8")]
		protected void SetBezierHandles(int no, float inDistanceFrag, float outDistanceFrag)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1FD13E0", Offset = "0x1FD13E0", VA = "0x1FD13E0")]
		protected void SetBezierHandles(int no, Vector3 i, Vector3 o, Space space = Space.World)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1FD133C", Offset = "0x1FD133C", VA = "0x1FD133C")]
		public static void SetBezierHandles(float distanceFrag, bool setIn, bool setOut, params CurvySplineSegment[] controlPoints)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1FD153C", Offset = "0x1FD153C", VA = "0x1FD153C")]
		protected void SetCGHardEdges(params int[] controlPoints)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1FD16A4", Offset = "0x1FD16A4", VA = "0x1FD16A4", Slot = "6")]
		protected virtual void ApplyShape()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1FD16A8", Offset = "0x1FD16A8", VA = "0x1FD16A8")]
		protected void PrepareControlPoints(int count)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1FD1E28", Offset = "0x1FD1E28", VA = "0x1FD1E28")]
		public static List<string> GetShapesMenuNames(bool only2D = false)
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1FD1FBC", Offset = "0x1FD1FBC", VA = "0x1FD1FBC")]
		public static List<string> GetShapesMenuNames(Type currentShapeType, out int currentIndex, bool only2D = false)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1FD2220", Offset = "0x1FD2220", VA = "0x1FD2220")]
		public static string GetShapeName(Type shapeType)
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1FD0B04", Offset = "0x1FD0B04", VA = "0x1FD0B04")]
		public static Type GetShapeType(string menuName)
		{
			return null;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1FD08A0", Offset = "0x1FD08A0", VA = "0x1FD08A0")]
		private void applyPlane()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1FD238C", Offset = "0x1FD238C", VA = "0x1FD238C")]
		private void applyRotation(Quaternion q)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1FD26B8", Offset = "0x1FD26B8", VA = "0x1FD26B8")]
		public CurvyShape()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x13AD5F8", Offset = "0x13AD5F8")]
	public sealed class CurvyShapeInfo : Attribute
	{
		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Name;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly bool Is2D;

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1FD27B0", Offset = "0x1FD27B0", VA = "0x1FD27B0")]
		public CurvyShapeInfo(string name, bool is2D = true)
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class CurvyShape2D : CurvyShape
	{
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1FD2740", Offset = "0x1FD2740", VA = "0x1FD2740")]
		public CurvyShape2D()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x13AD630", Offset = "0x13AD630")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AD630", Offset = "0x13AD630")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13AD630", Offset = "0x13AD630")]
	[ExecuteInEditMode]
	public class CurvySpline : DTVersionedMonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF304", Offset = "0x13AF304")]
		private sealed class <>c
		{
			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<CurvySplineSegment> <>9__296_0;

			[Token(Token = "0x6000B00")]
			[Address(RVA = "0x2BA9D18", Offset = "0x2BA9D18", VA = "0x2BA9D18")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B01")]
			[Address(RVA = "0x2BA9D20", Offset = "0x2BA9D20", VA = "0x2BA9D20")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private List<CurvySplineSegment> ControlPoints;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool ShowGizmos;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B0108", Offset = "0x13B0108")]
		private Action<CurvySpline> <OnGlobalCoordinatesChanged>k__BackingField;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B0118", Offset = "0x13B0118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0118", Offset = "0x13B0118")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B0118", Offset = "0x13B0118")]
		private CurvyInterpolation m_Interpolation;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B01D4", Offset = "0x13B01D4")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x13B01D4", Offset = "0x13B01D4")]
		[SerializeField]
		private bool m_RestrictTo2D;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B0248", Offset = "0x13B0248")]
		private bool m_Closed;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B0294", Offset = "0x13B0294")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0294", Offset = "0x13B0294")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B0294", Offset = "0x13B0294")]
		private bool m_AutoEndTangents;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0330", Offset = "0x13B0330")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B0330", Offset = "0x13B0330")]
		private CurvyOrientation m_Orientation;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B03A0", Offset = "0x13B03A0")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x13B03A0", Offset = "0x13B03A0")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B03A0", Offset = "0x13B03A0")]
		[SerializeField]
		private float m_AutoHandleDistance;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B04D4", Offset = "0x13B04D4")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x13B04D4", Offset = "0x13B04D4")]
		[AttributeAttribute(Name = "GroupActionAttribute", RVA = "0x13B04D4", Offset = "0x13B04D4")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B04D4", Offset = "0x13B04D4")]
		private float m_Tension;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B0624", Offset = "0x13B0624")]
		private float m_Continuity;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B0670", Offset = "0x13B0670")]
		private float m_Bias;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B06BC", Offset = "0x13B06BC")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x13B06BC", Offset = "0x13B06BC")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B06BC", Offset = "0x13B06BC")]
		[SerializeField]
		private Color m_GizmoColor;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B079C", Offset = "0x13B079C")]
		[SerializeField]
		private Color m_GizmoSelectionColor;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B0804", Offset = "0x13B0804")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B0804", Offset = "0x13B0804")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0804", Offset = "0x13B0804")]
		private int m_CacheDensity;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B08C0", Offset = "0x13B08C0")]
		private float m_MaxPointsPerUnit;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B090C", Offset = "0x13B090C")]
		private bool m_UsePooling;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0958", Offset = "0x13B0958")]
		private bool m_UseThreading;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B09A4", Offset = "0x13B09A4")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B09A4", Offset = "0x13B09A4")]
		private bool m_CheckTransform;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CurvyUpdateMethod m_UpdateIn;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x13B0A24", Offset = "0x13B0A24")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x13B0A24", Offset = "0x13B0A24")]
		[SerializeField]
		private CurvySplineEvent m_OnRefresh;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x13B0AAC", Offset = "0x13B0AAC")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x13B0AAC", Offset = "0x13B0AAC")]
		[SerializeField]
		private CurvySplineEvent m_OnAfterControlPointChanges;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x13B0B14", Offset = "0x13B0B14")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x13B0B14", Offset = "0x13B0B14")]
		[SerializeField]
		private CurvyControlPointEvent m_OnBeforeControlPointAdd;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x13B0B7C", Offset = "0x13B0B7C")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x13B0B7C", Offset = "0x13B0B7C")]
		[SerializeField]
		private CurvyControlPointEvent m_OnAfterControlPointAdd;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x13B0BE4", Offset = "0x13B0BE4")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x13B0BE4", Offset = "0x13B0BE4")]
		[SerializeField]
		private CurvyControlPointEvent m_OnBeforeControlPointDelete;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool mIsInitialized;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool isStarted;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		private bool sendOnRefreshEventNextUpdate;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly object controlPointsRelationshipCacheLock;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<CurvySplineSegment> mSegments;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ReadOnlyCollection<CurvySplineSegment> readOnlyControlPoints;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float length;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int mCacheSize;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Bounds? mBounds;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private bool mDirtyCurve;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
		private bool mDirtyOrientation;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private HashSet<CurvySplineSegment> dirtyControlPointsMinimalSet;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<CurvySplineSegment> dirtyCpsExtendedList;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool allControlPointsAreDirty;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private ThreadPoolWorker<CurvySplineSegment> mThreadWorker;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly CurvySplineEventArgs defaultSplineEventArgs;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private readonly CurvyControlPointEventArgs defaultAddAfterEventArgs;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private readonly CurvyControlPointEventArgs defaultDeleteEventArgs;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private CurvySplineSegment _lastDistToSeg;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private readonly Action<CurvySplineSegment> refreshCurveAction;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 lastProcessedPosition;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Quaternion lastProcessedRotation;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private Vector3 lastProcessedScale;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool globalCoordinatesChangedThisFrame;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		private bool isCpsRelationshipCacheValid;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private CurvySplineSegment firstSegment;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private CurvySplineSegment lastSegment;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private CurvySplineSegment firstVisibleControlPoint;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private CurvySplineSegment lastVisibleControlPoint;

		[Token(Token = "0x17000082")]
		public CurvyInterpolation Interpolation
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x1FD2BB8", Offset = "0x1FD2BB8", VA = "0x1FD2BB8")]
			get
			{
				return default(CurvyInterpolation);
			}
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x1FD0DE8", Offset = "0x1FD0DE8", VA = "0x1FD0DE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public bool RestrictTo2D
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x1FD2F68", Offset = "0x1FD2F68", VA = "0x1FD2F68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x1FD0F5C", Offset = "0x1FD0F5C", VA = "0x1FD0F5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public float AutoHandleDistance
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x1FD2F70", Offset = "0x1FD2F70", VA = "0x1FD2F70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x1FD2F78", Offset = "0x1FD2F78", VA = "0x1FD2F78")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public bool Closed
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x1FD301C", Offset = "0x1FD301C", VA = "0x1FD301C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x1FD0F04", Offset = "0x1FD0F04", VA = "0x1FD0F04")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public bool AutoEndTangents
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x1FD3024", Offset = "0x1FD3024", VA = "0x1FD3024")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x1FD2EE8", Offset = "0x1FD2EE8", VA = "0x1FD2EE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public CurvyOrientation Orientation
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x1FD3050", Offset = "0x1FD3050", VA = "0x1FD3050")]
			get
			{
				return default(CurvyOrientation);
			}
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x1FD0E34", Offset = "0x1FD0E34", VA = "0x1FD0E34")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public CurvyUpdateMethod UpdateIn
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x1FD3058", Offset = "0x1FD3058", VA = "0x1FD3058")]
			get
			{
				return default(CurvyUpdateMethod);
			}
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x1FD3060", Offset = "0x1FD3060", VA = "0x1FD3060")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public Color GizmoColor
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x1FD3074", Offset = "0x1FD3074", VA = "0x1FD3074")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x1FD3080", Offset = "0x1FD3080", VA = "0x1FD3080")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public Color GizmoSelectionColor
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x1FD30EC", Offset = "0x1FD30EC", VA = "0x1FD30EC")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x1FD30F8", Offset = "0x1FD30F8", VA = "0x1FD30F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public int CacheDensity
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x1FD3164", Offset = "0x1FD3164", VA = "0x1FD3164")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x1FD0E58", Offset = "0x1FD0E58", VA = "0x1FD0E58")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public float MaxPointsPerUnit
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x1FD316C", Offset = "0x1FD316C", VA = "0x1FD316C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x1FD3174", Offset = "0x1FD3174", VA = "0x1FD3174")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool UsePooling
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x1FD3228", Offset = "0x1FD3228", VA = "0x1FD3228")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x1FD3230", Offset = "0x1FD3230", VA = "0x1FD3230")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public bool UseThreading
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x1FD3250", Offset = "0x1FD3250", VA = "0x1FD3250")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x1FD3258", Offset = "0x1FD3258", VA = "0x1FD3258")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public bool CheckTransform
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x1FD3278", Offset = "0x1FD3278", VA = "0x1FD3278")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x1FD3280", Offset = "0x1FD3280", VA = "0x1FD3280")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public float Tension
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x1FD32AC", Offset = "0x1FD32AC", VA = "0x1FD32AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x1FD32B4", Offset = "0x1FD32B4", VA = "0x1FD32B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public float Continuity
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x1FD32D4", Offset = "0x1FD32D4", VA = "0x1FD32D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x1FD32DC", Offset = "0x1FD32DC", VA = "0x1FD32DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public float Bias
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x1FD32FC", Offset = "0x1FD32FC", VA = "0x1FD32FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x1FD3304", Offset = "0x1FD3304", VA = "0x1FD3304")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public bool IsInitialized
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x1FD3324", Offset = "0x1FD3324", VA = "0x1FD3324")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000094")]
		public Bounds Bounds
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x1FD332C", Offset = "0x1FD332C", VA = "0x1FD332C")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000095")]
		public int Count
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x1FC6F78", Offset = "0x1FC6F78", VA = "0x1FC6F78")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000096")]
		public int ControlPointCount
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x1FD12EC", Offset = "0x1FD12EC", VA = "0x1FD12EC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000097")]
		public int CacheSize
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x1FD3584", Offset = "0x1FD3584", VA = "0x1FD3584")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000098")]
		public float Length
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x1FC5DA8", Offset = "0x1FC5DA8", VA = "0x1FC5DA8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000099")]
		public bool Dirty
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x1FC7C90", Offset = "0x1FC7C90", VA = "0x1FC7C90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009A")]
		public CurvySplineSegment Item
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x1FC928C", Offset = "0x1FC928C", VA = "0x1FC928C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public ReadOnlyCollection<CurvySplineSegment> ControlPointsList
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x1FCFA38", Offset = "0x1FCFA38", VA = "0x1FCFA38")]
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
			[Address(RVA = "0x1FC2B30", Offset = "0x1FC2B30", VA = "0x1FC2B30")]
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
			[Address(RVA = "0x1FC2B64", Offset = "0x1FC2B64", VA = "0x1FC2B64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public CurvySplineSegment FirstSegment
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x1FD3C20", Offset = "0x1FD3C20", VA = "0x1FD3C20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public CurvySplineSegment LastSegment
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x1FD3C54", Offset = "0x1FD3C54", VA = "0x1FD3C54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public CurvySpline NextSpline
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x1FD3C88", Offset = "0x1FD3C88", VA = "0x1FD3C88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		public CurvySpline PreviousSpline
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x1FD3D60", Offset = "0x1FD3D60", VA = "0x1FD3D60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		public bool GlobalCoordinatesChangedThisFrame
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x1FD3E38", Offset = "0x1FD3E38", VA = "0x1FD3E38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A3")]
		public Action<CurvySpline> OnGlobalCoordinatesChanged
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x1FD3E40", Offset = "0x1FD3E40", VA = "0x1FD3E40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BACF8", Offset = "0x13BACF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x1FD3E48", Offset = "0x1FD3E48", VA = "0x1FD3E48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BAD08", Offset = "0x13BAD08")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public CurvySplineEvent OnRefresh
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1FD3E50", Offset = "0x1FD3E50", VA = "0x1FD3E50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x1FD3E58", Offset = "0x1FD3E58", VA = "0x1FD3E58")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public CurvySplineEvent OnAfterControlPointChanges
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x1FD3E70", Offset = "0x1FD3E70", VA = "0x1FD3E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x1FD3E78", Offset = "0x1FD3E78", VA = "0x1FD3E78")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public CurvyControlPointEvent OnBeforeControlPointAdd
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x1FD3E90", Offset = "0x1FD3E90", VA = "0x1FD3E90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x1FD3E98", Offset = "0x1FD3E98", VA = "0x1FD3E98")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public CurvyControlPointEvent OnAfterControlPointAdd
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x1FD3EB0", Offset = "0x1FD3EB0", VA = "0x1FD3EB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x1FD3EB8", Offset = "0x1FD3EB8", VA = "0x1FD3EB8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public CurvyControlPointEvent OnBeforeControlPointDelete
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x1FD3ED0", Offset = "0x1FD3ED0", VA = "0x1FD3ED0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x1FD3ED8", Offset = "0x1FD3ED8", VA = "0x1FD3ED8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		private List<CurvySplineSegment> controlPoints
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x1FDC33C", Offset = "0x1FDC33C", VA = "0x1FDC33C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		private List<CurvySplineSegment> Segments
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x1FD3550", Offset = "0x1FD3550", VA = "0x1FD3550")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1FD27FC", Offset = "0x1FD27FC", VA = "0x1FD27FC")]
		public CurvySpline()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1FD3EF0", Offset = "0x1FD3EF0", VA = "0x1FD3EF0")]
		public static CurvySpline Create()
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1FD40C4", Offset = "0x1FD40C4", VA = "0x1FD40C4")]
		public static CurvySpline Create(CurvySpline takeOptionsFrom)
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1FD4238", Offset = "0x1FD4238", VA = "0x1FD4238")]
		public static int CalculateCacheSize(int density, float splineLength, float maxPointsPerUnit)
		{
			return default(int);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1FD42C8", Offset = "0x1FD42C8", VA = "0x1FD42C8")]
		public static float CalculateSamplingPointsPerUnit(int density, float maxPointsPerUnit)
		{
			return default(float);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1FD43B4", Offset = "0x1FD43B4", VA = "0x1FD43B4")]
		public static Vector3 Bezier(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1FD4504", Offset = "0x1FD4504", VA = "0x1FD4504")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BAD18", Offset = "0x13BAD18")]
		public static float BezierTangent(float T0, float P0, float P1, float T1, float t)
		{
			return default(float);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1FD4554", Offset = "0x1FD4554", VA = "0x1FD4554")]
		public static Vector3 BezierTangent(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1FD4858", Offset = "0x1FD4858", VA = "0x1FD4858")]
		public static Vector3 CatmullRom(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1FD49E0", Offset = "0x1FD49E0", VA = "0x1FD49E0")]
		public static Vector3 TCB(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f, float FT0, float FC0, float FB0, float FT1, float FC1, float FB1)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1FC6688", Offset = "0x1FC6688", VA = "0x1FC6688")]
		public Vector3 Interpolate(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1FD4C88", Offset = "0x1FD4C88", VA = "0x1FD4C88")]
		public Vector3 Interpolate(float tf, CurvyInterpolation interpolation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1FC6690", Offset = "0x1FC6690", VA = "0x1FC6690")]
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
		[Address(RVA = "0x1FD4D88", Offset = "0x1FD4D88", VA = "0x1FD4D88")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BAD50", Offset = "0x13BAD50")]
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
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BAD88", Offset = "0x13BAD88")]
		public U InterpolateMetadata<T, U>(float tf) where T : UnityEngine.Component, ICurvyInterpolatableMetadata<U>
		{
			return (U)null;
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1FD4E5C", Offset = "0x1FD4E5C", VA = "0x1FD4E5C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BADC0", Offset = "0x13BADC0")]
		public object InterpolateMetadata(Type type, float tf)
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1FD4F30", Offset = "0x1FD4F30", VA = "0x1FD4F30")]
		public Vector3 InterpolateScale(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1FC6A8C", Offset = "0x1FC6A8C", VA = "0x1FC6A8C")]
		public Vector3 GetOrientationUpFast(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1FD5010", Offset = "0x1FD5010", VA = "0x1FD5010")]
		public Quaternion GetOrientationFast(float tf, bool inverse = false)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1FC6C0C", Offset = "0x1FC6C0C", VA = "0x1FC6C0C")]
		public Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1FD5108", Offset = "0x1FD5108", VA = "0x1FD5108")]
		public Vector3 GetTangent(float tf, Vector3 localPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1FC6CEC", Offset = "0x1FC6CEC", VA = "0x1FC6CEC")]
		public Vector3 GetTangentFast(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1FC697C", Offset = "0x1FC697C", VA = "0x1FC697C")]
		public void InterpolateAndGetTangent(float tf, out Vector3 localPosition, out Vector3 localTangent)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1FC686C", Offset = "0x1FC686C", VA = "0x1FC686C")]
		public void InterpolateAndGetTangentFast(float tf, out Vector3 localPosition, out Vector3 localTangent)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1FD5210", Offset = "0x1FD5210", VA = "0x1FD5210")]
		public Vector3 GetTangentByDistance(float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1FD5238", Offset = "0x1FD5238", VA = "0x1FD5238")]
		public Vector3 GetTangentByDistanceFast(float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1FD5260", Offset = "0x1FD5260", VA = "0x1FD5260")]
		public Vector3 InterpolateByDistance(float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1FD528C", Offset = "0x1FD528C", VA = "0x1FD528C")]
		public Vector3 InterpolateByDistanceFast(float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1FD52B4", Offset = "0x1FD52B4", VA = "0x1FD52B4")]
		public float ExtrapolateDistanceToTF(float tf, float distance, float stepSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1FD5484", Offset = "0x1FD5484", VA = "0x1FD5484")]
		public float ExtrapolateDistanceToTFFast(float tf, float distance, float stepSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1FC6394", Offset = "0x1FC6394", VA = "0x1FC6394")]
		public float TFToDistance(float tf, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1FC8318", Offset = "0x1FC8318", VA = "0x1FC8318")]
		public CurvySplineSegment TFToSegment(float tf, out float localF, CurvyClamping clamping)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1FD564C", Offset = "0x1FD564C", VA = "0x1FD564C")]
		public CurvySplineSegment TFToSegment(float tf, CurvyClamping clamping)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1FD5674", Offset = "0x1FD5674", VA = "0x1FD5674")]
		public CurvySplineSegment TFToSegment(float tf)
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1FD4D80", Offset = "0x1FD4D80", VA = "0x1FD4D80")]
		public CurvySplineSegment TFToSegment(float tf, out float localF)
		{
			return null;
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1FC93C8", Offset = "0x1FC93C8", VA = "0x1FC93C8")]
		public float SegmentToTF(CurvySplineSegment segment)
		{
			return default(float);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1FC8748", Offset = "0x1FC8748", VA = "0x1FC8748")]
		public float SegmentToTF(CurvySplineSegment segment, float localF)
		{
			return default(float);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1FC64D8", Offset = "0x1FC64D8", VA = "0x1FC64D8")]
		public float DistanceToTF(float distance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1FD5724", Offset = "0x1FD5724", VA = "0x1FD5724")]
		public CurvySplineSegment DistanceToSegment(float distance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1FC849C", Offset = "0x1FC849C", VA = "0x1FC849C")]
		public CurvySplineSegment DistanceToSegment(float distance, out float localDistance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1FD57FC", Offset = "0x1FD57FC", VA = "0x1FD57FC")]
		public Vector3 Move(ref float tf, ref int direction, float fDistance, CurvyClamping clamping)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1FD584C", Offset = "0x1FD584C", VA = "0x1FD584C")]
		public Vector3 MoveFast(ref float tf, ref int direction, float fDistance, CurvyClamping clamping)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1FD5898", Offset = "0x1FD5898", VA = "0x1FD5898")]
		public Vector3 MoveBy(ref float tf, ref int direction, float distance, CurvyClamping clamping, float stepSize = 0.002f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1FD58E8", Offset = "0x1FD58E8", VA = "0x1FD58E8")]
		public Vector3 MoveByFast(ref float tf, ref int direction, float distance, CurvyClamping clamping, float stepSize = 0.002f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1FD5954", Offset = "0x1FD5954", VA = "0x1FD5954")]
		public Vector3 MoveByLengthFast(ref float tf, ref int direction, float distance, CurvyClamping clamping)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1FD59E0", Offset = "0x1FD59E0", VA = "0x1FD59E0")]
		public Vector3 MoveByAngle(ref float tf, ref int direction, float angle, CurvyClamping clamping, float stepSize = 0.002f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1FD5C88", Offset = "0x1FD5C88", VA = "0x1FD5C88")]
		public Vector3 MoveByAngleFast(ref float tf, ref int direction, float angle, CurvyClamping clamping, float stepSize)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1FD5F20", Offset = "0x1FD5F20", VA = "0x1FD5F20")]
		public float ClampDistance(float distance, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1FD5F5C", Offset = "0x1FD5F5C", VA = "0x1FD5F5C")]
		public float ClampDistance(float distance, CurvyClamping clamping, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1FC7B9C", Offset = "0x1FC7B9C", VA = "0x1FC7B9C")]
		public float ClampDistance(float distance, ref int dir, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1FD5FB0", Offset = "0x1FD5FB0", VA = "0x1FD5FB0")]
		public float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1FD600C", Offset = "0x1FD600C", VA = "0x1FD600C")]
		public CurvySplineSegment Add()
		{
			return null;
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1FD6018", Offset = "0x1FD6018", VA = "0x1FD6018")]
		public CurvySplineSegment[] Add(params Vector3[] controlPointsLocalPositions)
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1FD63F0", Offset = "0x1FD63F0", VA = "0x1FD63F0")]
		public CurvySplineSegment InsertBefore(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1FD6650", Offset = "0x1FD6650", VA = "0x1FD6650")]
		public CurvySplineSegment InsertBefore(CurvySplineSegment controlPoint, Vector3 globalPosition, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1FD18CC", Offset = "0x1FD18CC", VA = "0x1FD18CC")]
		public CurvySplineSegment InsertAfter(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1FD6234", Offset = "0x1FD6234", VA = "0x1FD6234")]
		public CurvySplineSegment InsertAfter(CurvySplineSegment controlPoint, Vector3 globalPosition, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1FD6BA4", Offset = "0x1FD6BA4", VA = "0x1FD6BA4")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1FD1AE4", Offset = "0x1FD1AE4", VA = "0x1FD1AE4")]
		public void Delete(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1FC2844", Offset = "0x1FC2844", VA = "0x1FC2844")]
		public Vector3[] GetApproximation(Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1FD7100", Offset = "0x1FD7100", VA = "0x1FD7100")]
		public Vector3[] GetApproximationT()
		{
			return null;
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1FD7220", Offset = "0x1FD7220", VA = "0x1FD7220")]
		public Vector3[] GetApproximationUpVectors()
		{
			return null;
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1FD7340", Offset = "0x1FD7340", VA = "0x1FD7340")]
		public float GetNearestPointTF(Vector3 localPosition)
		{
			return default(float);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1FD73B4", Offset = "0x1FD73B4", VA = "0x1FD73B4")]
		public float GetNearestPointTF(Vector3 localPosition, out Vector3 nearest)
		{
			return default(float);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1FD73E8", Offset = "0x1FD73E8", VA = "0x1FD73E8")]
		public float GetNearestPointTF(Vector3 localPosition, int startSegmentIndex = 0, int stopSegmentIndex = -1)
		{
			return default(float);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1FD7380", Offset = "0x1FD7380", VA = "0x1FD7380")]
		public float GetNearestPointTF(Vector3 localPosition, out Vector3 nearest, int startSegmentIndex = 0, int stopSegmentIndex = -1)
		{
			return default(float);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1FD7428", Offset = "0x1FD7428", VA = "0x1FD7428")]
		public float GetNearestPointTF(Vector3 localPosition, out Vector3 nearestPoint, [CanBeNull] out CurvySplineSegment nearestSegment, out float nearestSegmentF, int startSegmentIndex = 0, int stopSegmentIndex = -1)
		{
			return default(float);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1FC7CF8", Offset = "0x1FC7CF8", VA = "0x1FC7CF8")]
		public void Refresh()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1FD0988", Offset = "0x1FD0988", VA = "0x1FD0988")]
		public void SetDirtyAll()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1FD2C9C", Offset = "0x1FD2C9C", VA = "0x1FD2C9C")]
		public void SetDirtyAll(SplineDirtyingType dirtyingType, bool dirtyConnectedControlPoints)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1FD83B4", Offset = "0x1FD83B4", VA = "0x1FD83B4")]
		public void SetDirty(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1FCD428", Offset = "0x1FCD428", VA = "0x1FCD428")]
		public void SetDirtyPartial(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1FD8854", Offset = "0x1FD8854", VA = "0x1FD8854")]
		public Vector3 ToWorldPosition(Vector3 localPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1FD88A0", Offset = "0x1FD88A0", VA = "0x1FD88A0")]
		public void SyncSplineFromHierarchy()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1FD8B04", Offset = "0x1FD8B04", VA = "0x1FD8B04")]
		public Vector3[] GetApproximationPoints(float fromTF, float toTF, bool includeEndPoint = true)
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1FD8ED8", Offset = "0x1FD8ED8", VA = "0x1FD8ED8")]
		public bool IsPlanar(out int ignoreAxis)
		{
			return default(bool);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1FD8F54", Offset = "0x1FD8F54", VA = "0x1FD8F54")]
		public bool IsPlanar(out bool xplanar, out bool yplanar, out bool zplanar)
		{
			return default(bool);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1FD91DC", Offset = "0x1FD91DC", VA = "0x1FD91DC")]
		public bool IsPlanar(CurvyPlane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1FD93A4", Offset = "0x1FD93A4", VA = "0x1FD93A4")]
		public void MakePlanar(CurvyPlane plane)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1FD983C", Offset = "0x1FD983C", VA = "0x1FD983C")]
		public void Subdivide([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1FD9EE8", Offset = "0x1FD9EE8", VA = "0x1FD9EE8")]
		public void Simplify([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1FDA1E4", Offset = "0x1FDA1E4", VA = "0x1FDA1E4")]
		public void Equalize([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1FDA598", Offset = "0x1FDA598", VA = "0x1FDA598")]
		public void Normalize()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1FDA7BC", Offset = "0x1FDA7BC", VA = "0x1FDA7BC")]
		public void MakePlanar(int axis)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1FDA964", Offset = "0x1FDA964", VA = "0x1FDA964")]
		public Vector3 SetPivot(float xRel = 0f, float yRel = 0f, float zRel = 0f, bool preview = false)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1FDACD4", Offset = "0x1FDACD4", VA = "0x1FDACD4")]
		public void Flip()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1FDAFC8", Offset = "0x1FDAFC8", VA = "0x1FDAFC8")]
		public void MoveControlPoints(int startIndex, int count, CurvySplineSegment destCP)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1FDB384", Offset = "0x1FDB384", VA = "0x1FDB384")]
		public void JoinWith(CurvySplineSegment destCP)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1FDB470", Offset = "0x1FDB470", VA = "0x1FDB470")]
		public CurvySpline Split(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1FDB6C0", Offset = "0x1FDB6C0", VA = "0x1FDB6C0")]
		public void SetFirstControlPoint(CurvySplineSegment controlPoint)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1FDB850", Offset = "0x1FDB850", VA = "0x1FDB850")]
		public bool IsControlPointAnOrientationAnchor(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1FCCF24", Offset = "0x1FCCF24", VA = "0x1FCCF24")]
		public bool CanControlPointHaveFollowUp(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1FD56E0", Offset = "0x1FD56E0", VA = "0x1FD56E0")]
		public short GetControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1FD569C", Offset = "0x1FD569C", VA = "0x1FD569C")]
		public short GetSegmentIndex(CurvySplineSegment segment)
		{
			return default(short);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1FC88B4", Offset = "0x1FC88B4", VA = "0x1FC88B4")]
		[CanBeNull]
		public CurvySplineSegment GetNextControlPoint(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1FDB960", Offset = "0x1FDB960", VA = "0x1FDB960")]
		[CanBeNull]
		public short GetNextControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1FDB9A4", Offset = "0x1FDB9A4", VA = "0x1FDB9A4")]
		[CanBeNull]
		public CurvySplineSegment GetNextControlPointUsingFollowUp(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1FC8B0C", Offset = "0x1FC8B0C", VA = "0x1FC8B0C")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousControlPoint(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1FDBB78", Offset = "0x1FDBB78", VA = "0x1FDBB78")]
		[CanBeNull]
		public short GetPreviousControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1FDBBBC", Offset = "0x1FDBBBC", VA = "0x1FDBBBC")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousControlPointUsingFollowUp(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1FD574C", Offset = "0x1FD574C", VA = "0x1FD574C")]
		[CanBeNull]
		public CurvySplineSegment GetNextSegment(CurvySplineSegment segment)
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1FDBCAC", Offset = "0x1FDBCAC", VA = "0x1FDBCAC")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousSegment(CurvySplineSegment segment)
		{
			return null;
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1FD660C", Offset = "0x1FD660C", VA = "0x1FD660C")]
		public bool IsControlPointASegment(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1FC8BBC", Offset = "0x1FC8BBC", VA = "0x1FC8BBC")]
		public bool IsControlPointVisible(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1FDBD5C", Offset = "0x1FDBD5C", VA = "0x1FDBD5C")]
		public short GetControlPointOrientationAnchorIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1FDBDA0", Offset = "0x1FDBDA0", VA = "0x1FDBDA0")]
		public void SetFromString(string fieldAndValue)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1FDC344", Offset = "0x1FDC344", VA = "0x1FDC344")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1FDC3C4", Offset = "0x1FDC3C4", VA = "0x1FDC3C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1FD4080", Offset = "0x1FD4080", VA = "0x1FD4080")]
		public void Start()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1FDC43C", Offset = "0x1FDC43C", VA = "0x1FDC43C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1FDC444", Offset = "0x1FDC444", VA = "0x1FDC444")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1FDC5A8", Offset = "0x1FDC5A8", VA = "0x1FDC5A8", Slot = "5")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1FDC758", Offset = "0x1FDC758", VA = "0x1FDC758")]
		private void Update()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1FDCAC4", Offset = "0x1FDCAC4", VA = "0x1FDCAC4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1FDCB08", Offset = "0x1FDCB08", VA = "0x1FDCB08")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1FDC3FC", Offset = "0x1FDC3FC", VA = "0x1FDC3FC")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1FDC798", Offset = "0x1FDC798", VA = "0x1FDC798")]
		private void doUpdate()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1FD302C", Offset = "0x1FD302C", VA = "0x1FD302C")]
		private bool canHaveManualEndCP()
		{
			return default(bool);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1FD840C", Offset = "0x1FD840C", VA = "0x1FD840C")]
		private void SetDirty(CurvySplineSegment controlPoint, SplineDirtyingType dirtyingType, CurvySplineSegment previousControlPoint, CurvySplineSegment nextControlPoint, bool ignoreConnectionOfInputControlPoint)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1FD8354", Offset = "0x1FD8354", VA = "0x1FD8354")]
		private void SetDirtyingFlags(SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1FDAF58", Offset = "0x1FDAF58", VA = "0x1FDAF58")]
		private void ReverseControlPoints()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1FDCBD8", Offset = "0x1FDCBD8", VA = "0x1FDCBD8")]
		private static short GetNextControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount)
		{
			return default(short);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1FDCBF4", Offset = "0x1FDCBF4", VA = "0x1FDCBF4")]
		private static short GetPreviousControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount)
		{
			return default(short);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1FDCC18", Offset = "0x1FDCC18", VA = "0x1FDCC18")]
		private static bool IsControlPointASegment(int controlPointIndex, int controlPointCount, bool isClosed, bool notAutoEndTangentsAndIsCatmullRomOrTCB)
		{
			return default(bool);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1FDBA94", Offset = "0x1FDBA94", VA = "0x1FDBA94")]
		[NotNull]
		private static CurvySplineSegment GetFollowUpNextControlPoint(CurvySplineSegment followUp, ConnectionHeadingEnum headToDirection)
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1FD89A8", Offset = "0x1FD89A8", VA = "0x1FD89A8")]
		private void AddControlPoint(CurvySplineSegment item)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1FDB224", Offset = "0x1FDB224", VA = "0x1FDB224")]
		private void InsertControlPoint(int index, CurvySplineSegment item)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1FD6F40", Offset = "0x1FD6F40", VA = "0x1FD6F40")]
		private void RemoveControlPoint(CurvySplineSegment item)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1FD6DF8", Offset = "0x1FD6DF8", VA = "0x1FD6DF8")]
		private void ClearControlPoints()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1FD2BC0", Offset = "0x1FD2BC0", VA = "0x1FD2BC0")]
		internal void InvalidateControlPointsRelationshipCacheINTERNAL()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1FD365C", Offset = "0x1FD365C", VA = "0x1FD365C")]
		private void RebuildControlPointsRelationshipCache(bool fixNonCoherentControlPoints)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1FD76F0", Offset = "0x1FD76F0", VA = "0x1FD76F0")]
		private void ProcessDirtyControlPoints()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1FDCED8", Offset = "0x1FDCED8", VA = "0x1FDCED8")]
		private void PrepareTTransforms()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1FDCC50", Offset = "0x1FDCC50", VA = "0x1FDCC50")]
		private void FillDirtyCpsExtendedList()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1FD05D8", Offset = "0x1FD05D8", VA = "0x1FD05D8")]
		internal void NotifyMetaDataModification()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1FDD0C0", Offset = "0x1FDD0C0", VA = "0x1FDD0C0")]
		private void SyncHierarchyFromSpline(bool renameControlPoints = true)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1FDCB4C", Offset = "0x1FDCB4C", VA = "0x1FDCB4C")]
		private void UpdatedLastProcessedGlobalCoordinates()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1FD6764", Offset = "0x1FD6764", VA = "0x1FD6764")]
		private CurvySplineSegment InsertAt(CurvySplineSegment controlPoint, Vector3 globalPosition, int insertionIndex, CurvyControlPointEventArgs.ModeEnum insertionMode, bool skipRefreshingAndEvents)
		{
			return null;
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1FD82E8", Offset = "0x1FD82E8", VA = "0x1FD82E8")]
		private CurvySplineEventArgs OnRefreshEvent(CurvySplineEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1FD61C8", Offset = "0x1FD61C8", VA = "0x1FD61C8")]
		private CurvyControlPointEventArgs OnBeforeControlPointAddEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1FD6318", Offset = "0x1FD6318", VA = "0x1FD6318")]
		private CurvyControlPointEventArgs OnAfterControlPointAddEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1FD6D8C", Offset = "0x1FD6D8C", VA = "0x1FD6D8C")]
		private CurvyControlPointEventArgs OnBeforeControlPointDeleteEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1FD6384", Offset = "0x1FD6384", VA = "0x1FD6384")]
		private CurvySplineEventArgs OnAfterControlPointChangesEvent(CurvySplineEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1FDD0C4", Offset = "0x1FDD0C4", VA = "0x1FDD0C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BAE88", Offset = "0x13BAE88")]
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
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AD6C8", Offset = "0x13AD6C8")]
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
				[Address(RVA = "0x2BB1D90", Offset = "0x2BB1D90", VA = "0x2BB1D90")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700027A")]
			internal short SegmentIndex
			{
				[Token(Token = "0x6000B03")]
				[Address(RVA = "0x2BB1D98", Offset = "0x2BB1D98", VA = "0x2BB1D98")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x1700027B")]
			internal short ControlPointIndex
			{
				[Token(Token = "0x6000B04")]
				[Address(RVA = "0x2BB1DA0", Offset = "0x2BB1DA0", VA = "0x2BB1DA0")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x1700027C")]
			internal short NextControlPointIndex
			{
				[Token(Token = "0x6000B05")]
				[Address(RVA = "0x2BB1DA8", Offset = "0x2BB1DA8", VA = "0x2BB1DA8")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x1700027D")]
			internal short PreviousControlPointIndex
			{
				[Token(Token = "0x6000B06")]
				[Address(RVA = "0x2BB1DB0", Offset = "0x2BB1DB0", VA = "0x2BB1DB0")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x1700027E")]
			internal bool PreviousControlPointIsSegment
			{
				[Token(Token = "0x6000B07")]
				[Address(RVA = "0x2BB1DB8", Offset = "0x2BB1DB8", VA = "0x2BB1DB8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700027F")]
			internal bool NextControlPointIsSegment
			{
				[Token(Token = "0x6000B08")]
				[Address(RVA = "0x2BB1DC0", Offset = "0x2BB1DC0", VA = "0x2BB1DC0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000280")]
			internal bool CanHaveFollowUp
			{
				[Token(Token = "0x6000B09")]
				[Address(RVA = "0x2BB1DC8", Offset = "0x2BB1DC8", VA = "0x2BB1DC8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000281")]
			internal bool IsSegment
			{
				[Token(Token = "0x6000B0A")]
				[Address(RVA = "0x2BB1DD0", Offset = "0x2BB1DD0", VA = "0x2BB1DD0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000282")]
			internal short OrientationAnchorIndex
			{
				[Token(Token = "0x6000B0B")]
				[Address(RVA = "0x2BB1DE0", Offset = "0x2BB1DE0", VA = "0x2BB1DE0")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0x2BB1DE8", Offset = "0x2BB1DE8", VA = "0x2BB1DE8")]
			internal ControlPointExtrinsicProperties(bool isVisible, short segmentIndex, short controlPointIndex, short previousControlPointIndex, short nextControlPointIndex, bool previousControlPointIsSegment, bool nextControlPointIsSegment, bool canHaveFollowUp, short orientationAnchorIndex)
			{
			}

			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x2BB1E28", Offset = "0x2BB1E28", VA = "0x2BB1E28", Slot = "4")]
			public bool Equals(ControlPointExtrinsicProperties other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0x2BB1EEC", Offset = "0x2BB1EEC", VA = "0x2BB1EEC", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0x2BB1F78", Offset = "0x2BB1F78", VA = "0x2BB1F78", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000B10")]
			[Address(RVA = "0x2BB20CC", Offset = "0x2BB20CC", VA = "0x2BB20CC")]
			public static bool operator ==(ControlPointExtrinsicProperties left, ControlPointExtrinsicProperties right)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B11")]
			[Address(RVA = "0x2BB20FC", Offset = "0x2BB20FC", VA = "0x2BB20FC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] Approximation;

		[NonSerialized]
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float[] ApproximationDistances;

		[NonSerialized]
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3[] ApproximationUp;

		[NonSerialized]
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3[] ApproximationT;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B0C4C", Offset = "0x13B0C4C")]
		private float <Length>k__BackingField;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B0C5C", Offset = "0x13B0C5C")]
		private float <Distance>k__BackingField;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x13B0C6C", Offset = "0x13B0C6C")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x13B0C6C", Offset = "0x13B0C6C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B0C6C", Offset = "0x13B0C6C")]
		[SerializeField]
		private bool m_AutoBakeOrientation;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x13B0D28", Offset = "0x13B0D28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0D28", Offset = "0x13B0D28")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B0D28", Offset = "0x13B0D28")]
		[SerializeField]
		private bool m_OrientationAnchor;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B0E24", Offset = "0x13B0E24")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x13B0E24", Offset = "0x13B0E24")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B0E24", Offset = "0x13B0E24")]
		[SerializeField]
		private CurvyOrientationSwirl m_Swirl;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B0F34", Offset = "0x13B0F34")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x13B0F34", Offset = "0x13B0F34")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B0F34", Offset = "0x13B0F34")]
		[SerializeField]
		private float m_SwirlTurns;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B1088", Offset = "0x13B1088")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x13B1088", Offset = "0x13B1088")]
		[SerializeField]
		private bool m_AutoHandles;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B1184", Offset = "0x13B1184")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B1184", Offset = "0x13B1184")]
		[SerializeField]
		private float m_AutoHandleDistance;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x13B1280", Offset = "0x13B1280")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B1280", Offset = "0x13B1280")]
		private Vector3 m_HandleIn;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x13B1334", Offset = "0x13B1334")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B1334", Offset = "0x13B1334")]
		private Vector3 m_HandleOut;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B13E8", Offset = "0x13B13E8")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x13B13E8", Offset = "0x13B13E8")]
		[AttributeAttribute(Name = "GroupActionAttribute", RVA = "0x13B13E8", Offset = "0x13B13E8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B13E8", Offset = "0x13B13E8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B13E8", Offset = "0x13B13E8")]
		private bool m_OverrideGlobalTension;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B1574", Offset = "0x13B1574")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B1574", Offset = "0x13B1574")]
		private bool m_OverrideGlobalContinuity;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B1600", Offset = "0x13B1600")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B1600", Offset = "0x13B1600")]
		private bool m_OverrideGlobalBias;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B168C", Offset = "0x13B168C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B168C", Offset = "0x13B168C")]
		private bool m_SynchronizeTCB;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B16FC", Offset = "0x13B16FC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B16FC", Offset = "0x13B16FC")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B16FC", Offset = "0x13B16FC")]
		private float m_StartTension;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B180C", Offset = "0x13B180C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B180C", Offset = "0x13B180C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B180C", Offset = "0x13B180C")]
		private float m_EndTension;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B1958", Offset = "0x13B1958")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B1958", Offset = "0x13B1958")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B1958", Offset = "0x13B1958")]
		private float m_StartContinuity;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B1A68", Offset = "0x13B1A68")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B1A68", Offset = "0x13B1A68")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B1A68", Offset = "0x13B1A68")]
		private float m_EndContinuity;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B1BB4", Offset = "0x13B1BB4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B1BB4", Offset = "0x13B1BB4")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B1BB4", Offset = "0x13B1BB4")]
		private float m_StartBias;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B1CC4", Offset = "0x13B1CC4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B1CC4", Offset = "0x13B1CC4")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B1CC4", Offset = "0x13B1CC4")]
		private float m_EndBias;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[HideInInspector]
		private CurvySplineSegment m_FollowUp;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[HideInInspector]
		private ConnectionHeadingEnum m_FollowUpHeading;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		[HideInInspector]
		private bool m_ConnectionSyncPosition;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		[SerializeField]
		[HideInInspector]
		private bool m_ConnectionSyncRotation;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[HideInInspector]
		private CurvyConnection m_Connection;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int cacheSize;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 threadSafeLocalPosition;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion threadSafeLocalRotation;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private CurvySpline mSpline;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float mStepSize;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Bounds? mBounds;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int mCacheLastDistanceToLocalFIndex;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly HashSet<UnityEngine.Component> mMetaData;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3 lastProcessedLocalPosition;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion lastProcessedLocalRotation;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private ControlPointExtrinsicProperties extrinsicPropertiesINTERNAL;

		[Token(Token = "0x170000AB")]
		public bool AutoBakeOrientation
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x2BA9F5C", Offset = "0x2BA9F5C", VA = "0x2BA9F5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x2BA9F64", Offset = "0x2BA9F64", VA = "0x2BA9F64")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public bool SerializedOrientationAnchor
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x2BA9F84", Offset = "0x2BA9F84", VA = "0x2BA9F84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x2BA9F8C", Offset = "0x2BA9F8C", VA = "0x2BA9F8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public CurvyOrientationSwirl Swirl
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x2BA9FF8", Offset = "0x2BA9FF8", VA = "0x2BA9FF8")]
			get
			{
				return default(CurvyOrientationSwirl);
			}
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x2BAA000", Offset = "0x2BAA000", VA = "0x2BAA000")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public float SwirlTurns
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x2BAA03C", Offset = "0x2BAA03C", VA = "0x2BAA03C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x2BAA044", Offset = "0x2BAA044", VA = "0x2BAA044")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public Vector3 HandleIn
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x2BAA07C", Offset = "0x2BAA07C", VA = "0x2BAA07C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x2BAA088", Offset = "0x2BAA088", VA = "0x2BAA088")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public Vector3 HandleOut
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x2BAA170", Offset = "0x2BAA170", VA = "0x2BAA170")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x2BAA17C", Offset = "0x2BAA17C", VA = "0x2BAA17C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public Vector3 HandleInPosition
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x2BAA264", Offset = "0x2BAA264", VA = "0x2BAA264")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x2BAA3AC", Offset = "0x2BAA3AC", VA = "0x2BAA3AC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public Vector3 HandleOutPosition
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x2BAA4A0", Offset = "0x2BAA4A0", VA = "0x2BAA4A0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x2BAA5E8", Offset = "0x2BAA5E8", VA = "0x2BAA5E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public bool AutoHandles
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x2BAA6DC", Offset = "0x2BAA6DC", VA = "0x2BAA6DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x2BAA6E4", Offset = "0x2BAA6E4", VA = "0x2BAA6E4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public float AutoHandleDistance
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x2BAA890", Offset = "0x2BAA890", VA = "0x2BAA890")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x2BAA898", Offset = "0x2BAA898", VA = "0x2BAA898")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public bool SynchronizeTCB
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x2BAA954", Offset = "0x2BAA954", VA = "0x2BAA954")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x2BAA95C", Offset = "0x2BAA95C", VA = "0x2BAA95C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public bool OverrideGlobalTension
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x2BAA9A4", Offset = "0x2BAA9A4", VA = "0x2BAA9A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x2BAA9AC", Offset = "0x2BAA9AC", VA = "0x2BAA9AC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public bool OverrideGlobalContinuity
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x2BAA9F4", Offset = "0x2BAA9F4", VA = "0x2BAA9F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x2BAA9FC", Offset = "0x2BAA9FC", VA = "0x2BAA9FC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public bool OverrideGlobalBias
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x2BAAA44", Offset = "0x2BAAA44", VA = "0x2BAAA44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x2BAAA4C", Offset = "0x2BAAA4C", VA = "0x2BAAA4C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public float StartTension
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x2BAAA94", Offset = "0x2BAAA94", VA = "0x2BAAA94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x2BAAA9C", Offset = "0x2BAAA9C", VA = "0x2BAAA9C")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public float StartContinuity
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x2BAAAD4", Offset = "0x2BAAAD4", VA = "0x2BAAAD4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x2BAAADC", Offset = "0x2BAAADC", VA = "0x2BAAADC")]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public float StartBias
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x2BAAB14", Offset = "0x2BAAB14", VA = "0x2BAAB14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x2BAAB1C", Offset = "0x2BAAB1C", VA = "0x2BAAB1C")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public float EndTension
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x2BAAB54", Offset = "0x2BAAB54", VA = "0x2BAAB54")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x2BAAB5C", Offset = "0x2BAAB5C", VA = "0x2BAAB5C")]
			set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public float EndContinuity
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x2BAAB94", Offset = "0x2BAAB94", VA = "0x2BAAB94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x2BAAB9C", Offset = "0x2BAAB9C", VA = "0x2BAAB9C")]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public float EndBias
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x2BAABD4", Offset = "0x2BAABD4", VA = "0x2BAABD4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x2BAABDC", Offset = "0x2BAABDC", VA = "0x2BAABDC")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public CurvySplineSegment FollowUp
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x2BAAC14", Offset = "0x2BAAC14", VA = "0x2BAAC14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x2BAAC1C", Offset = "0x2BAAC1C", VA = "0x2BAAC1C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public ConnectionHeadingEnum FollowUpHeading
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x2BAAD18", Offset = "0x2BAAD18", VA = "0x2BAAD18")]
			get
			{
				return default(ConnectionHeadingEnum);
			}
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x2BAAD20", Offset = "0x2BAAD20", VA = "0x2BAAD20")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public bool ConnectionSyncPosition
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x2BAADDC", Offset = "0x2BAADDC", VA = "0x2BAADDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x2BAADE4", Offset = "0x2BAADE4", VA = "0x2BAADE4")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public bool ConnectionSyncRotation
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x2BAAE04", Offset = "0x2BAAE04", VA = "0x2BAAE04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x2BAAE0C", Offset = "0x2BAAE0C", VA = "0x2BAAE0C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public CurvyConnection Connection
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x2BAAE2C", Offset = "0x2BAAE2C", VA = "0x2BAAE2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x2BAAE34", Offset = "0x2BAAE34", VA = "0x2BAAE34")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public int CacheSize
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x2BAB014", Offset = "0x2BAB014", VA = "0x2BAB014")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x2BAB01C", Offset = "0x2BAB01C", VA = "0x2BAB01C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public Bounds Bounds
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x2BAB024", Offset = "0x2BAB024", VA = "0x2BAB024")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x170000C6")]
		public float Length
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x2BAB2BC", Offset = "0x2BAB2BC", VA = "0x2BAB2BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BAE98", Offset = "0x13BAE98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x2BAB2C4", Offset = "0x2BAB2C4", VA = "0x2BAB2C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BAEA8", Offset = "0x13BAEA8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public float Distance
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x2BAB2CC", Offset = "0x2BAB2CC", VA = "0x2BAB2CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BAEB8", Offset = "0x13BAEB8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x2BAB2D4", Offset = "0x2BAB2D4", VA = "0x2BAB2D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BAEC8", Offset = "0x13BAEC8")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public float TF
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x2BAB2DC", Offset = "0x2BAB2DC", VA = "0x2BAB2DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C9")]
		public bool IsFirstControlPoint
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x2BAB304", Offset = "0x2BAB304", VA = "0x2BAB304")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CA")]
		public bool IsLastControlPoint
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x2BAB334", Offset = "0x2BAB334", VA = "0x2BAB334")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CB")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BBAF0", Offset = "0x13BBAF0")]
		public List<UnityEngine.Component> MetaData
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x2BAB38C", Offset = "0x2BAB38C", VA = "0x2BAB38C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		public HashSet<UnityEngine.Component> MetaDataSet
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x2BAB3DC", Offset = "0x2BAB3DC", VA = "0x2BAB3DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		public CurvySpline Spline
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x2BAB3E4", Offset = "0x2BAB3E4", VA = "0x2BAB3E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CE")]
		public bool HasUnprocessedLocalPosition
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x2BAB3EC", Offset = "0x2BAB3EC", VA = "0x2BAB3EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		public bool HasUnprocessedLocalOrientation
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x2BAB4B0", Offset = "0x2BAB4B0", VA = "0x2BAB4B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D0")]
		public bool OrientatinInfluencesSpline
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x2BAB4F8", Offset = "0x2BAB4F8", VA = "0x2BAB4F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D1")]
		private CurvyInterpolation interpolation
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x2BAF4B8", Offset = "0x2BAF4B8", VA = "0x2BAF4B8")]
			get
			{
				return default(CurvyInterpolation);
			}
		}

		[Token(Token = "0x170000D2")]
		private bool isDynamicOrientation
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x2BAF544", Offset = "0x2BAF544", VA = "0x2BAF544")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D3")]
		private bool IsOrientationAnchorEditable
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x2BAF5D8", Offset = "0x2BAF5D8", VA = "0x2BAF5D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D4")]
		private bool canHaveSwirl
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x2BAF6E0", Offset = "0x2BAF6E0", VA = "0x2BAF6E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x2BAB5A8", Offset = "0x2BAB5A8", VA = "0x2BAB5A8")]
		public void SetBezierHandleIn(Vector3 position, Space space = Space.Self, CurvyBezierModeEnum mode = CurvyBezierModeEnum.None)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2BABAF0", Offset = "0x2BABAF0", VA = "0x2BABAF0")]
		public void SetBezierHandleOut(Vector3 position, Space space = Space.Self, CurvyBezierModeEnum mode = CurvyBezierModeEnum.None)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x2BAC038", Offset = "0x2BAC038", VA = "0x2BAC038")]
		public void SetBezierHandles(float distanceFrag = -1f, bool setIn = true, bool setOut = true, bool noDirtying = false)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x2BAC36C", Offset = "0x2BAC36C", VA = "0x2BAC36C")]
		public void SetBezierHandles(float distanceFrag, Vector3 p, Vector3 n, bool setIn = true, bool setOut = true, bool noDirtying = false)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x2BAC580", Offset = "0x2BAC580", VA = "0x2BAC580")]
		public void SetFollowUp(CurvySplineSegment target, ConnectionHeadingEnum heading = ConnectionHeadingEnum.Auto)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2BAC654", Offset = "0x2BAC654", VA = "0x2BAC654")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2BAC6E8", Offset = "0x2BAC6E8", VA = "0x2BAC6E8")]
		public void ResetConnectionRelatedData()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2BAC73C", Offset = "0x2BAC73C", VA = "0x2BAC73C")]
		public Vector3 Interpolate(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2BAC758", Offset = "0x2BAC758", VA = "0x2BAC758")]
		public Vector3 Interpolate(float localF, CurvyInterpolation interpolation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2BACC30", Offset = "0x2BACC30", VA = "0x2BACC30")]
		public Vector3 InterpolateFast(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x2BACE8C", Offset = "0x2BACE8C", VA = "0x2BACE8C")]
		public void ReloadMetaData()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x2BAD178", Offset = "0x2BAD178", VA = "0x2BAD178")]
		public void RegisterMetaData(CurvyMetadataBase metaData)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x2BAD1E8", Offset = "0x2BAD1E8", VA = "0x2BAD1E8")]
		public void UnregisterMetaData(CurvyMetadataBase metaData)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x2BAD250", Offset = "0x2BAD250", VA = "0x2BAD250")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BAED8", Offset = "0x13BAED8")]
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
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BAF10", Offset = "0x13BAF10")]
		public U InterpolateMetadata<T, U>(float f) where T : UnityEngine.Component, ICurvyInterpolatableMetadata<U>
		{
			return (U)null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2BAD504", Offset = "0x2BAD504", VA = "0x2BAD504")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BAF48", Offset = "0x13BAF48")]
		public object InterpolateMetadata(Type type, float f)
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x2BAD678", Offset = "0x2BAD678", VA = "0x2BAD678")]
		public void DeleteMetadata()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x2BAD72C", Offset = "0x2BAD72C", VA = "0x2BAD72C")]
		public Vector3 InterpolateScale(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x2BAD894", Offset = "0x2BAD894", VA = "0x2BAD894")]
		public Vector3 GetTangent(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x2BAD938", Offset = "0x2BAD938", VA = "0x2BAD938")]
		public Vector3 GetTangent(float localF, Vector3 position)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x2BADB54", Offset = "0x2BADB54", VA = "0x2BADB54")]
		public Vector3 GetTangentFast(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x2BADCB8", Offset = "0x2BADCB8", VA = "0x2BADCB8")]
		public void InterpolateAndGetTangent(float localF, out Vector3 localPosition, out Vector3 localTangent)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x2BADD90", Offset = "0x2BADD90", VA = "0x2BADD90")]
		public void InterpolateAndGetTangentFast(float localF, out Vector3 localPosition, out Vector3 localTangent)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x2BADF68", Offset = "0x2BADF68", VA = "0x2BADF68")]
		public Quaternion GetOrientationFast(float localF)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x2BADF70", Offset = "0x2BADF70", VA = "0x2BADF70")]
		public Quaternion GetOrientationFast(float localF, bool inverse)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x2BAE110", Offset = "0x2BAE110", VA = "0x2BAE110")]
		public Vector3 GetOrientationUpFast(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x2BAE274", Offset = "0x2BAE274", VA = "0x2BAE274")]
		public float GetNearestPointF(Vector3 p)
		{
			return default(float);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x2BAE4A0", Offset = "0x2BAE4A0", VA = "0x2BAE4A0")]
		public float DistanceToLocalF(float localDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x2BAE678", Offset = "0x2BAE678", VA = "0x2BAE678")]
		public float LocalFToDistance(float localF)
		{
			return default(float);
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x2BAB2E4", Offset = "0x2BAB2E4", VA = "0x2BAB2E4")]
		public float LocalFToTF(float localF)
		{
			return default(float);
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x2BAE7A8", Offset = "0x2BAE7A8", VA = "0x2BAE7A8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x2BAE870", Offset = "0x2BAE870", VA = "0x2BAE870")]
		public void BakeOrientationToTransform()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x2BACD94", Offset = "0x2BACD94", VA = "0x2BACD94")]
		public int getApproximationIndexINTERNAL(float localF, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x2BAEB50", Offset = "0x2BAEB50", VA = "0x2BAEB50")]
		public void LinkToSpline(CurvySpline spline)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x2BAEB58", Offset = "0x2BAEB58", VA = "0x2BAEB58")]
		public void UnlinkFromSpline()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x2BAEB64", Offset = "0x2BAEB64", VA = "0x2BAEB64")]
		public void SetLocalPosition(Vector3 newPosition)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x2BAED70", Offset = "0x2BAED70", VA = "0x2BAED70")]
		public void SetPosition(Vector3 value)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x2BAE918", Offset = "0x2BAE918", VA = "0x2BAE918")]
		public void SetLocalRotation(Quaternion value)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x2BAEF7C", Offset = "0x2BAEF7C", VA = "0x2BAEF7C")]
		public void SetRotation(Quaternion value)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x2BAF1B4", Offset = "0x2BAF1B4", VA = "0x2BAF1B4", Slot = "4")]
		public void OnBeforePush()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x2BAF2A0", Offset = "0x2BAF2A0", VA = "0x2BAF2A0", Slot = "5")]
		public void OnAfterPop()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x2BAF3D4", Offset = "0x2BAF3D4", VA = "0x2BAF3D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x2BAF3D8", Offset = "0x2BAF3D8", VA = "0x2BAF3D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x2BAF3DC", Offset = "0x2BAF3DC", VA = "0x2BAF3DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x2BAF3E0", Offset = "0x2BAF3E0", VA = "0x2BAF3E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x2BAF444", Offset = "0x2BAF444", VA = "0x2BAF444")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2BAF47C", Offset = "0x2BAF47C", VA = "0x2BAF47C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2BAF4B4", Offset = "0x2BAF4B4", VA = "0x2BAF4B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x2BAF2A4", Offset = "0x2BAF2A4", VA = "0x2BAF2A4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x2BAF7E0", Offset = "0x2BAF7E0", VA = "0x2BAF7E0")]
		internal void SetExtrinsicPropertiesINTERNAL(ControlPointExtrinsicProperties value)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x2BAF7F4", Offset = "0x2BAF7F4", VA = "0x2BAF7F4")]
		internal unsafe ref ControlPointExtrinsicProperties GetExtrinsicPropertiesINTERNAL()
		{
			return ref *(ControlPointExtrinsicProperties*)null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2BACFA4", Offset = "0x2BACFA4", VA = "0x2BACFA4")]
		private void CheckAgainstMetaDataDuplication()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2BAF418", Offset = "0x2BAF418", VA = "0x2BAF418")]
		private void DoUpdate()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x2BAAEF0", Offset = "0x2BAAEF0", VA = "0x2BAAEF0")]
		private bool SetConnection(CurvyConnection newConnection)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2BAA730", Offset = "0x2BAA730", VA = "0x2BAA730")]
		private bool SetAutoHandles(bool newValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2BAE490", Offset = "0x2BAE490", VA = "0x2BAE490")]
		private float getApproximationLocalF(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2BAF7FC", Offset = "0x2BAF7FC", VA = "0x2BAF7FC")]
		internal void refreshCurveINTERNAL(CurvyInterpolation splineInterpolation, bool isControlPointASegment, CurvySpline spline)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2BAFEC8", Offset = "0x2BAFEC8", VA = "0x2BAFEC8")]
		private float InterpolateBezierSegment(CurvySpline spline, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2BB0834", Offset = "0x2BB0834", VA = "0x2BB0834")]
		private float InterpolateTCBSegment(CurvySpline spline, CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x2BB034C", Offset = "0x2BB034C", VA = "0x2BB034C")]
		private float InterpolateCatmullSegment(CurvySpline spline, CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2BB0EA4", Offset = "0x2BB0EA4", VA = "0x2BB0EA4")]
		private float InterpolateLinearSegment(CurvySpline spline, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2BB1188", Offset = "0x2BB1188", VA = "0x2BB1188")]
		internal void refreshOrientationNoneINTERNAL()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2BA9D38", Offset = "0x2BA9D38", VA = "0x2BA9D38")]
		internal void refreshOrientationStaticINTERNAL()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2BB1494", Offset = "0x2BB1494", VA = "0x2BB1494")]
		internal void refreshOrientationDynamicINTERNAL(Vector3 initialUp)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2BB16CC", Offset = "0x2BB16CC", VA = "0x2BB16CC")]
		internal void ClearBoundsINTERNAL()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2BB11CC", Offset = "0x2BB11CC", VA = "0x2BB11CC")]
		internal Vector3 getOrthoUp0INTERNAL()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2BB12FC", Offset = "0x2BB12FC", VA = "0x2BB12FC")]
		private Vector3 getOrthoUp1INTERNAL()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2BB16E0", Offset = "0x2BB16E0", VA = "0x2BB16E0")]
		internal void UnsetFollowUpWithoutDirtyingINTERNAL()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2BB1714", Offset = "0x2BB1714", VA = "0x2BB1714")]
		private bool SnapToFitSplineLength(float newSplineLength, float stepSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2BB1B44", Offset = "0x2BB1B44", VA = "0x2BB1B44")]
		internal void PrepareThreadSafeTransfromINTERNAL()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2BB1B98", Offset = "0x2BB1B98", VA = "0x2BB1B98")]
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
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AD714", Offset = "0x13AD714")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13AD714", Offset = "0x13AD714")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AD714", Offset = "0x13AD714")]
	public class CurvyUISpline : CurvySpline
	{
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x2BB21EC", Offset = "0x2BB21EC", VA = "0x2BB21EC")]
		public static CurvyUISpline CreateUISpline(string gameObjectName = "Curvy UI Spline")
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2BB236C", Offset = "0x2BB236C", VA = "0x2BB236C", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2BB2328", Offset = "0x2BB2328", VA = "0x2BB2328")]
		private void SetupUISpline()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2BB2394", Offset = "0x2BB2394", VA = "0x2BB2394")]
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
		[Address(RVA = "0x29109A4", Offset = "0x29109A4", VA = "0x29109A4")]
		public static bool IsWindingInside(WindingRule rule, int n)
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x2910A80", Offset = "0x2910A80", VA = "0x2910A80")]
		public static bool VertCCW(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(bool);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x2910AD4", Offset = "0x2910AD4", VA = "0x2910AD4")]
		public static bool VertEq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x2910B18", Offset = "0x2910B18", VA = "0x2910B18")]
		public static bool VertLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x2910B68", Offset = "0x2910B68", VA = "0x2910B68")]
		public static float EdgeEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x2910BDC", Offset = "0x2910BDC", VA = "0x2910BDC")]
		public static float EdgeSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x2910C40", Offset = "0x2910C40", VA = "0x2910C40")]
		public static bool TransLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x2910C90", Offset = "0x2910C90", VA = "0x2910C90")]
		public static float TransEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x2910D04", Offset = "0x2910D04", VA = "0x2910D04")]
		public static float TransSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x2910D68", Offset = "0x2910D68", VA = "0x2910D68")]
		public static bool EdgeGoesLeft(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x2910DB0", Offset = "0x2910DB0", VA = "0x2910DB0")]
		public static bool EdgeGoesRight(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x2910DD8", Offset = "0x2910DD8", VA = "0x2910DD8")]
		public static float VertL1dist(MeshUtils.Vertex u, MeshUtils.Vertex v)
		{
			return default(float);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x2910E74", Offset = "0x2910E74", VA = "0x2910E74")]
		public static void AddWinding(MeshUtils.Edge eDst, MeshUtils.Edge eSrc)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x2910EC0", Offset = "0x2910EC0", VA = "0x2910EC0")]
		public static float Interpolate(float a, float x, float b, float y)
		{
			return default(float);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x2910F1C", Offset = "0x2910F1C", VA = "0x2910F1C")]
		private static void Swap(ref MeshUtils.Vertex a, ref MeshUtils.Vertex b)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x2910F54", Offset = "0x2910F54", VA = "0x2910F54")]
		public static void EdgeIntersect(MeshUtils.Vertex o1, MeshUtils.Vertex d1, MeshUtils.Vertex o2, MeshUtils.Vertex d2, MeshUtils.Vertex v)
		{
		}
	}
	[Token(Token = "0x20000B6")]
	internal class LTMesh : MeshUtils.Pooled<LTMesh>
	{
		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal MeshUtils.Vertex _vHead;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal MeshUtils.Face _fHead;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal MeshUtils.Edge _eHead;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal MeshUtils.Edge _eHeadSym;

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x29113EC", Offset = "0x29113EC", VA = "0x29113EC")]
		public LTMesh()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x29116FC", Offset = "0x29116FC", VA = "0x29116FC", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x2911750", Offset = "0x2911750", VA = "0x2911750", Slot = "5")]
		public override void OnFree()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x2911850", Offset = "0x2911850", VA = "0x2911850")]
		public MeshUtils.Edge MakeEdge()
		{
			return null;
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x2911C24", Offset = "0x2911C24", VA = "0x2911C24")]
		public void Splice(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x2911F08", Offset = "0x2911F08", VA = "0x2911F08")]
		public void Delete(MeshUtils.Edge eDel)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x2912128", Offset = "0x2912128", VA = "0x2912128")]
		public MeshUtils.Edge AddEdgeVertex(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x29121C4", Offset = "0x29121C4", VA = "0x29121C4")]
		public MeshUtils.Edge SplitEdge(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x29122C4", Offset = "0x29122C4", VA = "0x29122C4")]
		public MeshUtils.Edge Connect(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
			return null;
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x29123C8", Offset = "0x29123C8", VA = "0x29123C8")]
		public void ZapFace(MeshUtils.Face fZap)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x291252C", Offset = "0x291252C", VA = "0x291252C")]
		public void MergeConvexFaces(int maxVertsPerFace)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x29126FC", Offset = "0x29126FC", VA = "0x29126FC")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x13BAF80", Offset = "0x13BAF80")]
		public void Check()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x13AD7C4", Offset = "0x13AD7C4")]
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
			[Address(RVA = "0x2C3F86C", Offset = "0x2C3F86C", VA = "0x2C3F86C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x2C3F90C", Offset = "0x2C3F90C", VA = "0x2C3F90C")]
			set
			{
			}
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x2C3F9B8", Offset = "0x2C3F9B8", VA = "0x2C3F9B8")]
		public static void Sub(ref Vec3 lhs, ref Vec3 rhs, out Vec3 result)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x2C3F9EC", Offset = "0x2C3F9EC", VA = "0x2C3F9EC")]
		public static void Neg(ref Vec3 v)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x2C3FA08", Offset = "0x2C3FA08", VA = "0x2C3FA08")]
		public static void Dot(ref Vec3 u, ref Vec3 v, out float dot)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x2C3FA34", Offset = "0x2C3FA34", VA = "0x2C3FA34")]
		public static void Normalize(ref Vec3 v)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x2C3FAEC", Offset = "0x2C3FAEC", VA = "0x2C3FAEC")]
		public static int LongAxis(ref Vec3 v)
		{
			return default(int);
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x2C3FBF4", Offset = "0x2C3FBF4", VA = "0x2C3FBF4", Slot = "3")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Vertex _prev;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Vertex _next;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Vec3 _coords;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal float _s;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal float _t;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal PQHandle _pqHandle;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int _n;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal object _data;

			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x2912BA0", Offset = "0x2912BA0", VA = "0x2912BA0", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x2912C5C", Offset = "0x2912C5C", VA = "0x2912C5C")]
			public Vertex()
			{
			}
		}

		[Token(Token = "0x200016A")]
		public class Face : Pooled<Face>
		{
			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Face _prev;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Face _next;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Face _trail;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal int _n;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal bool _marked;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
			internal bool _inside;

			[Token(Token = "0x17000286")]
			internal int VertsCount
			{
				[Token(Token = "0x6000B21")]
				[Address(RVA = "0x29126AC", Offset = "0x29126AC", VA = "0x29126AC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000B22")]
			[Address(RVA = "0x2912AF0", Offset = "0x2912AF0", VA = "0x2912AF0", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x2912B50", Offset = "0x2912B50", VA = "0x2912B50")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Edge _eSym;

			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x2911630", Offset = "0x2911630", VA = "0x2911630")]
			public static EdgePair Create()
			{
				return default(EdgePair);
			}

			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x2912A6C", Offset = "0x2912A6C", VA = "0x2912A6C")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x200016C")]
		public class Edge : Pooled<Edge>
		{
			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal EdgePair _pair;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _next;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Edge _Sym;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Edge _Onext;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Edge _Lnext;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Vertex _Org;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Face _Lface;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal Tess.ActiveRegion _activeRegion;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal int _winding;

			[Token(Token = "0x17000287")]
			internal Face _Rface
			{
				[Token(Token = "0x6000B26")]
				[Address(RVA = "0x291203C", Offset = "0x291203C", VA = "0x291203C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B27")]
				[Address(RVA = "0x29122A8", Offset = "0x29122A8", VA = "0x29122A8")]
				set
				{
				}
			}

			[Token(Token = "0x17000288")]
			internal Vertex _Dst
			{
				[Token(Token = "0x6000B28")]
				[Address(RVA = "0x2910D94", Offset = "0x2910D94", VA = "0x2910D94")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B29")]
				[Address(RVA = "0x291228C", Offset = "0x291228C", VA = "0x291228C")]
				set
				{
				}
			}

			[Token(Token = "0x17000289")]
			internal Edge _Oprev
			{
				[Token(Token = "0x6000B2A")]
				[Address(RVA = "0x2912058", Offset = "0x2912058", VA = "0x2912058")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B2B")]
				[Address(RVA = "0x2912878", Offset = "0x2912878", VA = "0x2912878")]
				set
				{
				}
			}

			[Token(Token = "0x1700028A")]
			internal Edge _Lprev
			{
				[Token(Token = "0x6000B2C")]
				[Address(RVA = "0x29126E0", Offset = "0x29126E0", VA = "0x29126E0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B2D")]
				[Address(RVA = "0x2912894", Offset = "0x2912894", VA = "0x2912894")]
				set
				{
				}
			}

			[Token(Token = "0x1700028B")]
			internal Edge _Dprev
			{
				[Token(Token = "0x6000B2E")]
				[Address(RVA = "0x29128B0", Offset = "0x29128B0", VA = "0x29128B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B2F")]
				[Address(RVA = "0x29128CC", Offset = "0x29128CC", VA = "0x29128CC")]
				set
				{
				}
			}

			[Token(Token = "0x1700028C")]
			internal Edge _Rprev
			{
				[Token(Token = "0x6000B30")]
				[Address(RVA = "0x29128E8", Offset = "0x29128E8", VA = "0x29128E8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B31")]
				[Address(RVA = "0x2912904", Offset = "0x2912904", VA = "0x2912904")]
				set
				{
				}
			}

			[Token(Token = "0x1700028D")]
			internal Edge _Dnext
			{
				[Token(Token = "0x6000B32")]
				[Address(RVA = "0x2912920", Offset = "0x2912920", VA = "0x2912920")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B33")]
				[Address(RVA = "0x2912948", Offset = "0x2912948", VA = "0x2912948")]
				set
				{
				}
			}

			[Token(Token = "0x1700028E")]
			internal Edge _Rnext
			{
				[Token(Token = "0x6000B34")]
				[Address(RVA = "0x2912970", Offset = "0x2912970", VA = "0x2912970")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B35")]
				[Address(RVA = "0x2912998", Offset = "0x2912998", VA = "0x2912998")]
				set
				{
				}
			}

			[Token(Token = "0x6000B36")]
			[Address(RVA = "0x29127E4", Offset = "0x29127E4", VA = "0x29127E4")]
			internal static void EnsureFirst(ref Edge e)
			{
			}

			[Token(Token = "0x6000B37")]
			[Address(RVA = "0x29129C0", Offset = "0x29129C0", VA = "0x29129C0", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000B38")]
			[Address(RVA = "0x2912AA0", Offset = "0x2912AA0", VA = "0x2912AA0")]
			public Edge()
			{
			}
		}

		[Token(Token = "0x400029D")]
		public const int Undef = -1;

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x29118A4", Offset = "0x29118A4", VA = "0x29118A4")]
		public static Edge MakeEdge(Edge eNext)
		{
			return null;
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x2911E78", Offset = "0x2911E78", VA = "0x2911E78")]
		public static void Splice(Edge a, Edge b)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x2911A1C", Offset = "0x2911A1C", VA = "0x2911A1C")]
		public static void MakeVertex(Edge eOrig, Vertex vNext)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x2911B10", Offset = "0x2911B10", VA = "0x2911B10")]
		public static void MakeFace(Edge eOrig, Face fNext)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x2912074", Offset = "0x2912074", VA = "0x2912074")]
		public static void KillEdge(Edge eDel)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x2911D00", Offset = "0x2911D00", VA = "0x2911D00")]
		public static void KillVertex(Vertex vDel, Vertex newOrg)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x2911DBC", Offset = "0x2911DBC", VA = "0x2911DBC")]
		public static void KillFace(Face fDel, Face newLFace)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x2912814", Offset = "0x2912814", VA = "0x2912814")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal MeshUtils.Edge _eUp;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Dict<ActiveRegion>.Node _nodeUp;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int _windingNumber;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal bool _inside;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			internal bool _sentinel;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
			internal bool _dirty;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
			internal bool _fixUpperEdge;

			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0x2C3F458", Offset = "0x2C3F458", VA = "0x2C3F458")]
			public ActiveRegion()
			{
			}
		}

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private LTMesh _mesh;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vec3 _normal;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vec3 _sUnit;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vec3 _tUnit;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _bminX;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _bminY;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _bmaxX;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _bmaxY;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private WindingRule _windingRule;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dict<ActiveRegion> _dict;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PriorityQueue<MeshUtils.Vertex> _pq;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshUtils.Vertex _event;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CombineCallback _combineCallback;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ContourVertex[] _vertices;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _vertexCount;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int[] _elements;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _elementCount;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float SUnitX;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float SUnitY;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float SentinelCoord;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool NoEmptyPolygons;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool UsePooling;

		[Token(Token = "0x170000D8")]
		public Vec3 Normal
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x2915184", Offset = "0x2915184", VA = "0x2915184")]
			get
			{
				return default(Vec3);
			}
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x2915190", Offset = "0x2915190", VA = "0x2915190")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public ContourVertex[] Vertices
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x291519C", Offset = "0x291519C", VA = "0x291519C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DA")]
		public int VertexCount
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x29151A4", Offset = "0x29151A4", VA = "0x29151A4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DB")]
		public int[] Elements
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x29151AC", Offset = "0x29151AC", VA = "0x29151AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		public int ElementCount
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x29151B4", Offset = "0x29151B4", VA = "0x29151B4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x2912D00", Offset = "0x2912D00", VA = "0x2912D00")]
		private ActiveRegion RegionBelow(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x2912D2C", Offset = "0x2912D2C", VA = "0x2912D2C")]
		private ActiveRegion RegionAbove(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x2912D58", Offset = "0x2912D58", VA = "0x2912D58")]
		private bool EdgeLeq(ActiveRegion reg1, ActiveRegion reg2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x2912E6C", Offset = "0x2912E6C", VA = "0x2912E6C")]
		private void DeleteRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x2912EEC", Offset = "0x2912EEC", VA = "0x2912EEC")]
		private void FixUpperEdge(ActiveRegion reg, MeshUtils.Edge newEdge)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x2912F54", Offset = "0x2912F54", VA = "0x2912F54")]
		private ActiveRegion TopLeftRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x2913014", Offset = "0x2913014", VA = "0x2913014")]
		private ActiveRegion TopRightRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x2913074", Offset = "0x2913074", VA = "0x2913074")]
		private ActiveRegion AddRegionBelow(ActiveRegion regAbove, MeshUtils.Edge eNewUp)
		{
			return null;
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x291314C", Offset = "0x291314C", VA = "0x291314C")]
		private void ComputeWinding(ActiveRegion reg)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x29131A4", Offset = "0x29131A4", VA = "0x29131A4")]
		private void FinishRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x29131F4", Offset = "0x29131F4", VA = "0x29131F4")]
		private MeshUtils.Edge FinishLeftRegions(ActiveRegion regFirst, ActiveRegion regLast)
		{
			return null;
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x2913328", Offset = "0x2913328", VA = "0x2913328")]
		private void AddRightEdges(ActiveRegion regUp, MeshUtils.Edge eFirst, MeshUtils.Edge eLast, MeshUtils.Edge eTopLeft, bool cleanUp)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x29138B4", Offset = "0x29138B4", VA = "0x29138B4")]
		private void SpliceMergeVertices(MeshUtils.Edge e1, MeshUtils.Edge e2)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x29138CC", Offset = "0x29138CC", VA = "0x29138CC")]
		private void VertexWeights(MeshUtils.Vertex isect, MeshUtils.Vertex org, MeshUtils.Vertex dst, out float w0, out float w1)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x29139C8", Offset = "0x29139C8", VA = "0x29139C8")]
		private void GetIntersectData(MeshUtils.Vertex isect, MeshUtils.Vertex orgUp, MeshUtils.Vertex dstUp, MeshUtils.Vertex orgLo, MeshUtils.Vertex dstLo)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x29134E8", Offset = "0x29134E8", VA = "0x29134E8")]
		private bool CheckForRightSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x2913C7C", Offset = "0x2913C7C", VA = "0x2913C7C")]
		private bool CheckForLeftSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x2913DEC", Offset = "0x2913DEC", VA = "0x2913DEC")]
		private bool CheckForIntersect(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x2913684", Offset = "0x2913684", VA = "0x2913684")]
		private void WalkDirtyRegions(ActiveRegion regUp)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x2914410", Offset = "0x2914410", VA = "0x2914410")]
		private void ConnectRightVertex(ActiveRegion regUp, MeshUtils.Edge eBottomLeft)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x2914610", Offset = "0x2914610", VA = "0x2914610")]
		private void ConnectLeftDegenerate(ActiveRegion regUp, MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x2914800", Offset = "0x2914800", VA = "0x2914800")]
		private void ConnectLeftVertex(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x2914720", Offset = "0x2914720", VA = "0x2914720")]
		private void SweepEvent(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x2914A28", Offset = "0x2914A28", VA = "0x2914A28")]
		private void AddSentinel(float smin, float smax, float t)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x2914B60", Offset = "0x2914B60", VA = "0x2914B60")]
		private void InitEdgeDict()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x2914C38", Offset = "0x2914C38", VA = "0x2914C38")]
		private void DoneEdgeDict()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x2914CC4", Offset = "0x2914CC4", VA = "0x2914CC4")]
		private void RemoveDegenerateEdges()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x2914E08", Offset = "0x2914E08", VA = "0x2914E08")]
		private void InitPriorityQ()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x2914FC4", Offset = "0x2914FC4", VA = "0x2914FC4")]
		private void DonePriorityQ()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x2914FD0", Offset = "0x2914FD0", VA = "0x2914FD0")]
		private void RemoveDegenerateFaces()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x2915068", Offset = "0x2915068", VA = "0x2915068")]
		protected void ComputeInterior()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x29151BC", Offset = "0x29151BC", VA = "0x29151BC")]
		public Tess()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x2915298", Offset = "0x2915298", VA = "0x2915298")]
		private void ComputeNormal(ref Vec3 norm)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x291599C", Offset = "0x291599C", VA = "0x291599C")]
		private void CheckOrientation()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x2915AB4", Offset = "0x2915AB4", VA = "0x2915AB4")]
		private void ProjectPolygon()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x2915DB8", Offset = "0x2915DB8", VA = "0x2915DB8")]
		private void TessellateMonoRegion(MeshUtils.Face face)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x2915FA8", Offset = "0x2915FA8", VA = "0x2915FA8")]
		private void TessellateInterior()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x2916014", Offset = "0x2916014", VA = "0x2916014")]
		private void DiscardExterior()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x291607C", Offset = "0x291607C", VA = "0x291607C")]
		private void SetWindingNumber(int value, bool keepOnlyBoundary)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x291614C", Offset = "0x291614C", VA = "0x291614C")]
		private int GetNeighbourFace(MeshUtils.Edge edge)
		{
			return default(int);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x2916188", Offset = "0x2916188", VA = "0x2916188")]
		private void OutputPolymesh(ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x29165F0", Offset = "0x29165F0", VA = "0x29165F0")]
		private void OutputContours()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x291685C", Offset = "0x291685C", VA = "0x291685C")]
		private float SignedArea(ContourVertex[] vertices)
		{
			return default(float);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x29168FC", Offset = "0x29168FC", VA = "0x29168FC")]
		public void AddContour(ContourVertex[] vertices)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x2916904", Offset = "0x2916904", VA = "0x2916904")]
		public void AddContour(ContourVertex[] vertices, ContourOrientation forceOrientation)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x2916AE4", Offset = "0x2916AE4", VA = "0x2916AE4")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x2916AEC", Offset = "0x2916AEC", VA = "0x2916AEC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public object Data;

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x2910918", Offset = "0x2910918", VA = "0x2910918", Slot = "3")]
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
		[Address(RVA = "0x29127CC", Offset = "0x29127CC", VA = "0x29127CC")]
		public static Vec3 Vec3(this Vector3 v)
		{
			return default(Vec3);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x29127D0", Offset = "0x29127D0", VA = "0x29127D0")]
		public static ContourVertex ContourVertex(this Vector3 v)
		{
			return default(ContourVertex);
		}
	}
	[Token(Token = "0x20000C3")]
	public static class LibTessV3Extension
	{
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x2912798", Offset = "0x2912798", VA = "0x2912798")]
		public static Vector3 Vector3(this Vec3 v)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000C4")]
	public static class UnityLibTessUtility
	{
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x2C3F460", Offset = "0x2C3F460", VA = "0x2C3F460")]
		public static ContourVertex[] ToContourVertex(Vector3[] v, bool zeroZ = false)
		{
			return null;
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x2C3F554", Offset = "0x2C3F554", VA = "0x2C3F554")]
		public static Vector3[] FromContourVertex(ContourVertex[] v)
		{
			return null;
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x2C3F5D4", Offset = "0x2C3F5D4", VA = "0x2C3F5D4")]
		public static void SetFromContourVertex(ref Vector3[] v3Array, ref ContourVertex[] cvArray)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x2C3F720", Offset = "0x2C3F720", VA = "0x2C3F720")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Position;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 Rotation;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CurvyInterpolation Interpolation;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool RestrictTo2D;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool Closed;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		public bool AutoEndTangents;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CurvyOrientation Orientation;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float AutoHandleDistance;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int CacheDensity;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MaxPointsPerUnit;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool UsePooling;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool UseThreading;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool CheckTransform;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public CurvyUpdateMethod UpdateIn;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SerializedCurvySplineSegment[] ControlPoints;

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x290D1EC", Offset = "0x290D1EC", VA = "0x290D1EC")]
		public SerializedCurvySpline()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x290D2B4", Offset = "0x290D2B4", VA = "0x290D2B4")]
		public SerializedCurvySpline([NotNull] CurvySpline spline, CurvySerializationSpace space)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x290D650", Offset = "0x290D650", VA = "0x290D650")]
		public void WriteIntoSpline([NotNull] CurvySpline deserializedSpline, CurvySerializationSpace space)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C7")]
	public class SerializedCurvySplineSegment
	{
		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 Rotation;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool AutoBakeOrientation;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool OrientationAnchor;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public CurvyOrientationSwirl Swirl;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float SwirlTurns;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool AutoHandles;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float AutoHandleDistance;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 HandleOut;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 HandleIn;

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x290DAE0", Offset = "0x290DAE0", VA = "0x290DAE0")]
		public SerializedCurvySplineSegment()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x290D544", Offset = "0x290D544", VA = "0x290D544")]
		public SerializedCurvySplineSegment([NotNull] CurvySplineSegment segment, CurvySerializationSpace space)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x290D8F8", Offset = "0x290D8F8", VA = "0x290D8F8")]
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
		[Address(RVA = "0x1FC2B98", Offset = "0x1FC2B98", VA = "0x1FC2B98")]
		protected ConnectedControlPointsSelector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C9")]
	public class ControllerEvent : UnityEventEx<CurvyController>
	{
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1FC2BA0", Offset = "0x1FC2BA0", VA = "0x1FC2BA0")]
		public ControllerEvent()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class CurvyControllerEventArgs : CurvyEventArgs
	{
		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly CurvyController Controller;

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1FC515C", Offset = "0x1FC515C", VA = "0x1FC515C")]
		public CurvyControllerEventArgs(MonoBehaviour sender, CurvyController controller)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CB")]
	public class CurvySplineMoveEvent : UnityEventEx<CurvySplineMoveEventArgs>
	{
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1FC5228", Offset = "0x1FC5228", VA = "0x1FC5228")]
		public CurvySplineMoveEvent()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class CurvySplineMoveEventArgs : CancelEventArgs
	{
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B1F28", Offset = "0x13B1F28")]
		private SplineController <Sender>k__BackingField;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B1F38", Offset = "0x13B1F38")]
		private CurvySpline <Spline>k__BackingField;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B1F48", Offset = "0x13B1F48")]
		private CurvySplineSegment <ControlPoint>k__BackingField;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B1F58", Offset = "0x13B1F58")]
		private bool <WorldUnits>k__BackingField;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B1F68", Offset = "0x13B1F68")]
		private MovementDirection <MovementDirection>k__BackingField;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B1F78", Offset = "0x13B1F78")]
		private float <Delta>k__BackingField;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B1F88", Offset = "0x13B1F88")]
		private float <Position>k__BackingField;

		[Token(Token = "0x170000DD")]
		public SplineController Sender
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x1FC5278", Offset = "0x1FC5278", VA = "0x1FC5278")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BAFE8", Offset = "0x13BAFE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x1FC5280", Offset = "0x1FC5280", VA = "0x1FC5280")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BAFF8", Offset = "0x13BAFF8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public CurvySpline Spline
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x1FC5288", Offset = "0x1FC5288", VA = "0x1FC5288")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB008", Offset = "0x13BB008")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x1FC5290", Offset = "0x1FC5290", VA = "0x1FC5290")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB018", Offset = "0x13BB018")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public CurvySplineSegment ControlPoint
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x1FC5298", Offset = "0x1FC5298", VA = "0x1FC5298")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB028", Offset = "0x13BB028")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x1FC52A0", Offset = "0x1FC52A0", VA = "0x1FC52A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB038", Offset = "0x13BB038")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public bool WorldUnits
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x1FC52A8", Offset = "0x1FC52A8", VA = "0x1FC52A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB048", Offset = "0x13BB048")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x1FC52B0", Offset = "0x1FC52B0", VA = "0x1FC52B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB058", Offset = "0x13BB058")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public MovementDirection MovementDirection
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x1FC52BC", Offset = "0x1FC52BC", VA = "0x1FC52BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB068", Offset = "0x13BB068")]
			get
			{
				return default(MovementDirection);
			}
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x1FC52C4", Offset = "0x1FC52C4", VA = "0x1FC52C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB078", Offset = "0x13BB078")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public float Delta
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x1FC52CC", Offset = "0x1FC52CC", VA = "0x1FC52CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB088", Offset = "0x13BB088")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x1FC52D4", Offset = "0x1FC52D4", VA = "0x1FC52D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB098", Offset = "0x13BB098")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public float Position
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x1FC52DC", Offset = "0x1FC52DC", VA = "0x1FC52DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB0A8", Offset = "0x13BB0A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x1FC52E4", Offset = "0x1FC52E4", VA = "0x1FC52E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB0B8", Offset = "0x13BB0B8")]
			private set
			{
			}
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1FC52EC", Offset = "0x1FC52EC", VA = "0x1FC52EC")]
		public CurvySplineMoveEventArgs(SplineController sender, CurvySpline spline, CurvySplineSegment controlPoint, float position, bool usingWorldUnits, float delta, MovementDirection direction)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1FC5364", Offset = "0x1FC5364", VA = "0x1FC5364")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B1F98", Offset = "0x13B1F98")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B1F98", Offset = "0x13B1F98")]
		public CurvyUpdateMethod UpdateIn;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B2030", Offset = "0x13B2030")]
		[SerializeField]
		private CurvyPositionMode m_PositionMode;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B20B4", Offset = "0x13B20B4")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B20B4", Offset = "0x13B20B4")]
		protected float m_Position;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B2160", Offset = "0x13B2160")]
		[SerializeField]
		private MoveModeEnum m_MoveMode;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Positive]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private MovementDirection m_Direction;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CurvyClamping m_Clamping;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2234", Offset = "0x13B2234")]
		private bool m_PlayAutomatically;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B2280", Offset = "0x13B2280")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B2280", Offset = "0x13B2280")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B2280", Offset = "0x13B2280")]
		[SerializeField]
		private OrientationModeEnum m_OrientationMode;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B23CC", Offset = "0x13B23CC")]
		[SerializeField]
		private bool m_LockRotation;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B2434", Offset = "0x13B2434")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B2434", Offset = "0x13B2434")]
		[SerializeField]
		private OrientationAxisEnum m_OrientationAxis;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2568", Offset = "0x13B2568")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B2568", Offset = "0x13B2568")]
		[SerializeField]
		private bool m_IgnoreDirection;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x13B2688", Offset = "0x13B2688")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B2688", Offset = "0x13B2688")]
		[SerializeField]
		private float m_DampingDirection;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x13B2784", Offset = "0x13B2784")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B2784", Offset = "0x13B2784")]
		[SerializeField]
		private float m_DampingUp;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B2880", Offset = "0x13B2880")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B2880", Offset = "0x13B2880")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B2880", Offset = "0x13B2880")]
		[SerializeField]
		private float m_OffsetAngle;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B2A18", Offset = "0x13B2A18")]
		[SerializeField]
		private float m_OffsetRadius;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B2B14", Offset = "0x13B2B14")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B2B14", Offset = "0x13B2B14")]
		[SerializeField]
		private bool m_OffsetCompensation;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B2C48", Offset = "0x13B2C48")]
		[SerializeField]
		private ControllerEvent onInitialized;

		[Token(Token = "0x400030B")]
		protected const string ControllerNotReadyMessage = "The controller is not yet ready";

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B2CA8", Offset = "0x13B2CA8")]
		private bool <isInitialized>k__BackingField;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private CurvyControllerState state;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 directionDampingVelocity;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 upDampingVelocity;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float prePlayPosition;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion lockedRotation;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private MovementDirection prePlayDirection;

		[Token(Token = "0x170000E4")]
		public ControllerEvent OnInitialized
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x1FC2BF0", Offset = "0x1FC2BF0", VA = "0x1FC2BF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		public CurvyPositionMode PositionMode
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x1FC2BF8", Offset = "0x1FC2BF8", VA = "0x1FC2BF8")]
			get
			{
				return default(CurvyPositionMode);
			}
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x1FC2C00", Offset = "0x1FC2C00", VA = "0x1FC2C00")]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public MoveModeEnum MoveMode
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x1FC2C08", Offset = "0x1FC2C08", VA = "0x1FC2C08")]
			get
			{
				return default(MoveModeEnum);
			}
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x1FC2C10", Offset = "0x1FC2C10", VA = "0x1FC2C10")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public bool PlayAutomatically
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x1FC2C24", Offset = "0x1FC2C24", VA = "0x1FC2C24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x1FC2C2C", Offset = "0x1FC2C2C", VA = "0x1FC2C2C")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public CurvyClamping Clamping
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x1FC2C4C", Offset = "0x1FC2C4C", VA = "0x1FC2C4C")]
			get
			{
				return default(CurvyClamping);
			}
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x1FC2C54", Offset = "0x1FC2C54", VA = "0x1FC2C54")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public OrientationModeEnum OrientationMode
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x1FC2C68", Offset = "0x1FC2C68", VA = "0x1FC2C68")]
			get
			{
				return default(OrientationModeEnum);
			}
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x1FC2C70", Offset = "0x1FC2C70", VA = "0x1FC2C70")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public bool LockRotation
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x1FC2C84", Offset = "0x1FC2C84", VA = "0x1FC2C84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x1FC2C8C", Offset = "0x1FC2C8C", VA = "0x1FC2C8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public OrientationAxisEnum OrientationAxis
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x1FC2CF4", Offset = "0x1FC2CF4", VA = "0x1FC2CF4")]
			get
			{
				return default(OrientationAxisEnum);
			}
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x1FC2CFC", Offset = "0x1FC2CFC", VA = "0x1FC2CFC")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public float DirectionDampingTime
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x1FC2D10", Offset = "0x1FC2D10", VA = "0x1FC2D10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x1FC2D18", Offset = "0x1FC2D18", VA = "0x1FC2D18")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public float UpDampingTime
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x1FC2DA4", Offset = "0x1FC2DA4", VA = "0x1FC2DA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x1FC2DAC", Offset = "0x1FC2DAC", VA = "0x1FC2DAC")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public bool IgnoreDirection
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x1FC2E38", Offset = "0x1FC2E38", VA = "0x1FC2E38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x1FC2E40", Offset = "0x1FC2E40", VA = "0x1FC2E40")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public float OffsetAngle
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x1FC2E60", Offset = "0x1FC2E60", VA = "0x1FC2E60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x1FC2E68", Offset = "0x1FC2E68", VA = "0x1FC2E68")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public float OffsetRadius
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x1FC2E7C", Offset = "0x1FC2E7C", VA = "0x1FC2E7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x1FC2E84", Offset = "0x1FC2E84", VA = "0x1FC2E84")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public bool OffsetCompensation
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x1FC2E98", Offset = "0x1FC2E98", VA = "0x1FC2E98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x1FC2EA0", Offset = "0x1FC2EA0", VA = "0x1FC2EA0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public float Speed
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x1FC2EAC", Offset = "0x1FC2EAC", VA = "0x1FC2EAC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x1FC2EB4", Offset = "0x1FC2EB4", VA = "0x1FC2EB4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public float RelativePosition
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x1FC2EC8", Offset = "0x1FC2EC8", VA = "0x1FC2EC8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x1FC30B4", Offset = "0x1FC30B4", VA = "0x1FC30B4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public float AbsolutePosition
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x1FC31AC", Offset = "0x1FC31AC", VA = "0x1FC31AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1FC32DC", Offset = "0x1FC32DC", VA = "0x1FC32DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public float Position
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x1FC33AC", Offset = "0x1FC33AC", VA = "0x1FC33AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x1FC3440", Offset = "0x1FC3440", VA = "0x1FC3440")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public MovementDirection MovementDirection
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x1FC34EC", Offset = "0x1FC34EC", VA = "0x1FC34EC")]
			get
			{
				return default(MovementDirection);
			}
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x1FC34F4", Offset = "0x1FC34F4", VA = "0x1FC34F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public CurvyControllerState PlayState
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x1FC34FC", Offset = "0x1FC34FC", VA = "0x1FC34FC")]
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
			[Address(RVA = "0x1FC3504", Offset = "0x1FC3504", VA = "0x1FC3504")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB0C8", Offset = "0x13BB0C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x1FC350C", Offset = "0x1FC350C", VA = "0x1FC350C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB0D8", Offset = "0x13BB0D8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public virtual Transform Transform
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x1FC388C", Offset = "0x1FC388C", VA = "0x1FC388C", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FB")]
		protected virtual bool ShowOrientationSection
		{
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x1FC4880", Offset = "0x1FC4880", VA = "0x1FC4880", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FC")]
		protected virtual bool ShowOffsetSection
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x1FC4888", Offset = "0x1FC4888", VA = "0x1FC4888", Slot = "27")]
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
			[Address(RVA = "0x1FC36AC", Offset = "0x1FC36AC", VA = "0x1FC36AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000FF")]
		private float maxPosition
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x1FC4FD8", Offset = "0x1FC4FD8", VA = "0x1FC4FD8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1FC3518", Offset = "0x1FC3518", VA = "0x1FC3518", Slot = "8")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1FC3580", Offset = "0x1FC3580", VA = "0x1FC3580", Slot = "9")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1FC365C", Offset = "0x1FC365C", VA = "0x1FC365C", Slot = "10")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1FC3678", Offset = "0x1FC3678", VA = "0x1FC3678", Slot = "11")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x1FC3764", Offset = "0x1FC3764", VA = "0x1FC3764", Slot = "12")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x1FC37BC", Offset = "0x1FC37BC", VA = "0x1FC37BC", Slot = "13")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x1FC37F4", Offset = "0x1FC37F4", VA = "0x1FC37F4", Slot = "14")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1FC3894", Offset = "0x1FC3894", VA = "0x1FC3894", Slot = "16")]
		protected virtual void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1FC3F24", Offset = "0x1FC3F24", VA = "0x1FC3F24", Slot = "17")]
		protected virtual void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1FC4474", Offset = "0x1FC4474", VA = "0x1FC4474")]
		private void GetOrientationNoneUpAndForward(out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1FC4730", Offset = "0x1FC4730", VA = "0x1FC4730", Slot = "18")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x1FC4818", Offset = "0x1FC4818", VA = "0x1FC4818", Slot = "19")]
		protected virtual void Deinitialize()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1FC4848", Offset = "0x1FC4848", VA = "0x1FC4848", Slot = "20")]
		protected virtual void BindEvents()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1FC484C", Offset = "0x1FC484C", VA = "0x1FC484C", Slot = "21")]
		protected virtual void UnbindEvents()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1FC4850", Offset = "0x1FC4850", VA = "0x1FC4850", Slot = "22")]
		protected virtual void SavePrePlayState()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x1FC4864", Offset = "0x1FC4864", VA = "0x1FC4864", Slot = "23")]
		protected virtual void RestorePrePlayState()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1FC4878", Offset = "0x1FC4878", VA = "0x1FC4878", Slot = "24")]
		protected virtual void UserAfterInit()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1FC487C", Offset = "0x1FC487C", VA = "0x1FC487C", Slot = "25")]
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
		[Address(RVA = "0x1FC361C", Offset = "0x1FC361C", VA = "0x1FC361C")]
		public void Play()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1FC4890", Offset = "0x1FC4890", VA = "0x1FC4890")]
		public void Stop()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1FC48CC", Offset = "0x1FC48CC", VA = "0x1FC48CC")]
		public void Pause()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1FC48E4", Offset = "0x1FC48E4", VA = "0x1FC48E4")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x1FC36B4", Offset = "0x1FC36B4", VA = "0x1FC36B4")]
		public void ApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x1FC48EC", Offset = "0x1FC48EC", VA = "0x1FC48EC")]
		public void TeleportTo(float newPosition)
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1FC4980", Offset = "0x1FC4980", VA = "0x1FC4980")]
		public void TeleportBy(float distance, MovementDirection direction)
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1FC4A3C", Offset = "0x1FC4A3C", VA = "0x1FC4A3C")]
		public void SetFromString(string fieldAndValue)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1FC4600", Offset = "0x1FC4600", VA = "0x1FC4600")]
		private static Vector3 ApplyOffset(Vector3 pos, Vector3 tan, Vector3 up, float angle, float radius)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1FC2FEC", Offset = "0x1FC2FEC", VA = "0x1FC2FEC")]
		protected static float GetClampedPosition(float position, CurvyPositionMode positionMode, CurvyClamping clampingMode, float length)
		{
			return default(float);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1FC3CA0", Offset = "0x1FC3CA0", VA = "0x1FC3CA0")]
		private float ComputeOffsetCompensatedSpeed(float deltaTime)
		{
			return default(float);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1FC5090", Offset = "0x1FC5090", VA = "0x1FC5090", Slot = "37")]
		public virtual void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1FC5134", Offset = "0x1FC5134", VA = "0x1FC5134", Slot = "5")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1FC5138", Offset = "0x1FC5138", VA = "0x1FC5138")]
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
		[Address(RVA = "0x1FC53EC", Offset = "0x1FC53EC", VA = "0x1FC53EC")]
		public static MovementDirection FromInt(int value)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1FC53F4", Offset = "0x1FC53F4", VA = "0x1FC53F4")]
		public static MovementDirection GetOpposite(this MovementDirection value)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1FC547C", Offset = "0x1FC547C", VA = "0x1FC547C")]
		public static int ToInt(this MovementDirection direction)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13AD83C", Offset = "0x13AD83C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AD83C", Offset = "0x13AD83C")]
	public class PathController : CurvyController
	{
		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B2CB8", Offset = "0x13B2CB8")]
		[SerializeField]
		[AttributeAttribute(Name = "CGDataReferenceSelectorAttribute", RVA = "0x13B2CB8", Offset = "0x13B2CB8")]
		private CGDataReference m_Path;

		[Token(Token = "0x17000100")]
		public CGDataReference Path
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x1FC5504", Offset = "0x1FC5504", VA = "0x1FC5504")]
			get
			{
				return null;
			}
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x1FC550C", Offset = "0x1FC550C", VA = "0x1FC550C")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public CGPath PathData
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x1FC5514", Offset = "0x1FC5514", VA = "0x1FC5514")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000102")]
		public override float Length
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x1FC558C", Offset = "0x1FC558C", VA = "0x1FC558C", Slot = "28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000103")]
		public override bool IsReady
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x1FC55CC", Offset = "0x1FC55CC", VA = "0x1FC55CC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x1FC561C", Offset = "0x1FC561C", VA = "0x1FC561C", Slot = "32")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x1FC5678", Offset = "0x1FC5678", VA = "0x1FC5678", Slot = "31")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x1FC56D4", Offset = "0x1FC56D4", VA = "0x1FC56D4", Slot = "33")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x1FC5748", Offset = "0x1FC5748", VA = "0x1FC5748", Slot = "34")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x1FC5820", Offset = "0x1FC5820", VA = "0x1FC5820", Slot = "36")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x1FC5894", Offset = "0x1FC5894", VA = "0x1FC5894", Slot = "35")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x1FC5908", Offset = "0x1FC5908", VA = "0x1FC5908", Slot = "29")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1FC597C", Offset = "0x1FC597C", VA = "0x1FC597C", Slot = "30")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1FC5A8C", Offset = "0x1FC5A8C", VA = "0x1FC5A8C")]
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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13AD8A0", Offset = "0x13AD8A0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AD8A0", Offset = "0x13AD8A0")]
	public class SplineController : CurvyController
	{
		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B2D7C", Offset = "0x13B2D7C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B2D7C", Offset = "0x13B2D7C")]
		[SerializeField]
		protected CurvySpline m_Spline;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2E28", Offset = "0x13B2E28")]
		private bool m_UseCache;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B2E74", Offset = "0x13B2E74")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B2E74", Offset = "0x13B2E74")]
		private SplineControllerConnectionBehavior connectionBehavior;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B2F28", Offset = "0x13B2F28")]
		private bool allowDirectionChange;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B2F88", Offset = "0x13B2F88")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B2F88", Offset = "0x13B2F88")]
		private bool rejectCurrentSpline;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B3074", Offset = "0x13B3074")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B3074", Offset = "0x13B3074")]
		private bool rejectTooDivergentSplines;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B3160", Offset = "0x13B3160")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B3160", Offset = "0x13B3160")]
		private float maxAllowedDivergenceAngle;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B31E4", Offset = "0x13B31E4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B31E4", Offset = "0x13B31E4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B31E4", Offset = "0x13B31E4")]
		private ConnectedControlPointsSelector connectionCustomSelector;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B3318", Offset = "0x13B3318")]
		[SerializeField]
		private CurvySplineMoveEvent m_OnControlPointReached;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private CurvySplineMoveEvent m_OnEndReached;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private CurvySplineMoveEvent m_OnSwitch;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B33AC", Offset = "0x13B33AC")]
		private bool <IsSwitching>k__BackingField;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private CurvySpline prePlaySpline;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float switchStartTime;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float switchDuration;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private CurvySpline switchTarget;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float tfOnSwitchTarget;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private MovementDirection directionOnSwitchTarget;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly CurvySplineMoveEventArgs preAllocatedEventArgs;

		[Token(Token = "0x17000104")]
		public virtual CurvySpline Spline
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x1FC5C08", Offset = "0x1FC5C08", VA = "0x1FC5C08", Slot = "38")]
			get
			{
				return null;
			}
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x1FC5C10", Offset = "0x1FC5C10", VA = "0x1FC5C10", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public bool UseCache
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x1FC5C18", Offset = "0x1FC5C18", VA = "0x1FC5C18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x1FC5C20", Offset = "0x1FC5C20", VA = "0x1FC5C20")]
			set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public SplineControllerConnectionBehavior ConnectionBehavior
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x1FC5C40", Offset = "0x1FC5C40", VA = "0x1FC5C40")]
			get
			{
				return default(SplineControllerConnectionBehavior);
			}
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x1FC5C48", Offset = "0x1FC5C48", VA = "0x1FC5C48")]
			set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public ConnectedControlPointsSelector ConnectionCustomSelector
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x1FC5C50", Offset = "0x1FC5C50", VA = "0x1FC5C50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x1FC5C58", Offset = "0x1FC5C58", VA = "0x1FC5C58")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public bool AllowDirectionChange
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x1FC5C60", Offset = "0x1FC5C60", VA = "0x1FC5C60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x1FC5C68", Offset = "0x1FC5C68", VA = "0x1FC5C68")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public bool RejectCurrentSpline
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x1FC5C74", Offset = "0x1FC5C74", VA = "0x1FC5C74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x1FC5C7C", Offset = "0x1FC5C7C", VA = "0x1FC5C7C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public bool RejectTooDivergentSplines
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x1FC5C88", Offset = "0x1FC5C88", VA = "0x1FC5C88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x1FC5C90", Offset = "0x1FC5C90", VA = "0x1FC5C90")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public float MaxAllowedDivergenceAngle
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x1FC5C9C", Offset = "0x1FC5C9C", VA = "0x1FC5C9C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x1FC5CA4", Offset = "0x1FC5CA4", VA = "0x1FC5CA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public CurvySplineMoveEvent OnControlPointReached
		{
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x1FC5CAC", Offset = "0x1FC5CAC", VA = "0x1FC5CAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x1FC5CB4", Offset = "0x1FC5CB4", VA = "0x1FC5CB4")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public CurvySplineMoveEvent OnEndReached
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x1FC5CBC", Offset = "0x1FC5CBC", VA = "0x1FC5CBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x1FC5CC4", Offset = "0x1FC5CC4", VA = "0x1FC5CC4")]
			set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public CurvySplineMoveEvent OnSwitch
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x1FC5CCC", Offset = "0x1FC5CCC", VA = "0x1FC5CCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x1FC5CD4", Offset = "0x1FC5CD4", VA = "0x1FC5CD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		public bool IsSwitching
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x1FC5CDC", Offset = "0x1FC5CDC", VA = "0x1FC5CDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB108", Offset = "0x13BB108")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x1FC5CE4", Offset = "0x1FC5CE4", VA = "0x1FC5CE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB118", Offset = "0x13BB118")]
			private set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public override float Length
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x1FC5CF0", Offset = "0x1FC5CF0", VA = "0x1FC5CF0", Slot = "28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000111")]
		private float SwitchProgress
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x1FC5EA8", Offset = "0x1FC5EA8", VA = "0x1FC5EA8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000112")]
		public override bool IsReady
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x1FC6200", Offset = "0x1FC6200", VA = "0x1FC6200", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000113")]
		private bool ShowRandomConnectionOptions
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x1FC93D0", Offset = "0x1FC93D0", VA = "0x1FC93D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1FC5B1C", Offset = "0x1FC5B1C", VA = "0x1FC5B1C")]
		public SplineController()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1FC5F54", Offset = "0x1FC5F54", VA = "0x1FC5F54", Slot = "40")]
		public virtual void SwitchTo(CurvySpline destinationSpline, float destinationTf, float duration)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1FC600C", Offset = "0x1FC600C", VA = "0x1FC600C")]
		public void FinishCurrentSwitch()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1FC6054", Offset = "0x1FC6054", VA = "0x1FC6054")]
		public void CancelCurrentSwitch()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1FC6064", Offset = "0x1FC6064", VA = "0x1FC6064")]
		public static float GetAngleBetweenConnectedSplines(CurvySplineSegment before, MovementDirection movementMode, CurvySplineSegment after, bool allowMovementModeChange)
		{
			return default(float);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1FC62C0", Offset = "0x1FC62C0", VA = "0x1FC62C0", Slot = "22")]
		protected override void SavePrePlayState()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x1FC630C", Offset = "0x1FC630C", VA = "0x1FC630C", Slot = "23")]
		protected override void RestorePrePlayState()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1FC634C", Offset = "0x1FC634C", VA = "0x1FC634C", Slot = "32")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1FC6490", Offset = "0x1FC6490", VA = "0x1FC6490", Slot = "31")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1FC65E0", Offset = "0x1FC65E0", VA = "0x1FC65E0", Slot = "33")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1FC6770", Offset = "0x1FC6770", VA = "0x1FC6770", Slot = "34")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1FC6B6C", Offset = "0x1FC6B6C", VA = "0x1FC6B6C", Slot = "36")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1FC6DCC", Offset = "0x1FC6DCC", VA = "0x1FC6DCC", Slot = "35")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1FC6E44", Offset = "0x1FC6E44", VA = "0x1FC6E44", Slot = "29")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1FC7B38", Offset = "0x1FC7B38", VA = "0x1FC7B38", Slot = "30")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1FC79DC", Offset = "0x1FC79DC", VA = "0x1FC79DC")]
		private void SimulateAdvanceOnSpline(ref float tf, ref MovementDirection curyDirection, CurvySpline spline, float distance)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1FC7BE0", Offset = "0x1FC7BE0", VA = "0x1FC7BE0", Slot = "16")]
		protected override void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1FC7D20", Offset = "0x1FC7D20", VA = "0x1FC7D20", Slot = "17")]
		protected override void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1FC8054", Offset = "0x1FC8054", VA = "0x1FC8054")]
		private static float MovementCompatibleGetPosition(SplineController controller, CurvyPositionMode positionMode, out CurvySplineSegment controlPoint, out bool isOnControlPoint)
		{
			return default(float);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1FC8964", Offset = "0x1FC8964", VA = "0x1FC8964")]
		private static void MovementCompatibleSetPosition(SplineController controller, CurvyPositionMode positionMode, float position)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1FC6FDC", Offset = "0x1FC6FDC", VA = "0x1FC6FDC")]
		private void EventAwareMove(float distance)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1FC8AD0", Offset = "0x1FC8AD0", VA = "0x1FC8AD0")]
		private CurvySplineSegment GetCurrentControlPoint(out bool isOnControlPoint, out float position, CurvyPositionMode positionMode)
		{
			return null;
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1FC8D04", Offset = "0x1FC8D04", VA = "0x1FC8D04")]
		private void HandleReachingNewControlPoint(CurvySplineSegment newControlPoint, CurvyPositionMode positionMode, float currentDelta, ref bool cancelMovement)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1FC90A4", Offset = "0x1FC90A4", VA = "0x1FC90A4")]
		private CurvySplineSegment HandleRandomConnectionBehavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection, ReadOnlyCollection<CurvySplineSegment> connectedControlPoints)
		{
			return null;
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1FC61B8", Offset = "0x1FC61B8", VA = "0x1FC61B8")]
		private static MovementDirection GetPostConnectionDirection(CurvySplineSegment connectedControlPoint, MovementDirection currentDirection, bool directionChangeAllowed)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1FC8FB4", Offset = "0x1FC8FB4", VA = "0x1FC8FB4")]
		private CurvySplineSegment HandleFolloUpConnectionBahavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection)
		{
			return null;
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x1FC9318", Offset = "0x1FC9318", VA = "0x1FC9318")]
		private static MovementDirection HeadingToDirection(ConnectionHeadingEnum heading, CurvySplineSegment controlPoint, MovementDirection currentDirection)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1FC8C00", Offset = "0x1FC8C00", VA = "0x1FC8C00")]
		private static float GetControlPointPosition(CurvySplineSegment controlPoint, CurvyPositionMode positionMode, MovementDirection movementDirection)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000D3")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AD904", Offset = "0x13AD904")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13AD904", Offset = "0x13AD904")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AD904", Offset = "0x13AD904")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIVertex[] V;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rect Rect;

			[Token(Token = "0x17000290")]
			public Vector3 Center
			{
				[Token(Token = "0x6000B43")]
				[Address(RVA = "0x1FCADD4", Offset = "0x1FCADD4", VA = "0x1FCADD4", Slot = "4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x1FCAE5C", Offset = "0x1FCAE5C", VA = "0x1FCAE5C")]
			public void Load(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x1FCA2BC", Offset = "0x1FCA2BC", VA = "0x1FCA2BC")]
			public void LoadTris(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x6000B46")]
			[Address(RVA = "0x1FCB078", Offset = "0x1FCB078", VA = "0x1FCB078")]
			public void calcRect()
			{
			}

			[Token(Token = "0x6000B47")]
			[Address(RVA = "0x1FCB0EC", Offset = "0x1FCB0EC", VA = "0x1FCB0EC")]
			public void Save(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x6000B48")]
			[Address(RVA = "0x1FCA4D8", Offset = "0x1FCA4D8", VA = "0x1FCA4D8")]
			public void Save(VertexHelper vh)
			{
			}

			[Token(Token = "0x6000B49")]
			[Address(RVA = "0x1FCB2A8", Offset = "0x1FCB2A8", VA = "0x1FCB2A8", Slot = "5")]
			public void Transpose(Vector3 v)
			{
			}

			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0x1FCB3B0", Offset = "0x1FCB3B0", VA = "0x1FCB3B0", Slot = "6")]
			public void Rotate(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000B4B")]
			[Address(RVA = "0x1FCA250", Offset = "0x1FCA250", VA = "0x1FCA250")]
			public GlyphQuad()
			{
			}
		}

		[Token(Token = "0x2000175")]
		protected class GlyphPlain : IGlyph
		{
			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] V;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rect Rect;

			[Token(Token = "0x17000291")]
			public Vector3 Center
			{
				[Token(Token = "0x6000B4C")]
				[Address(RVA = "0x1FCAADC", Offset = "0x1FCAADC", VA = "0x1FCAADC", Slot = "4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000B4D")]
			[Address(RVA = "0x1FC980C", Offset = "0x1FC980C", VA = "0x1FC980C")]
			public void Load(ref Vector3[] verts, int index)
			{
			}

			[Token(Token = "0x6000B4E")]
			[Address(RVA = "0x1FCAB64", Offset = "0x1FCAB64", VA = "0x1FCAB64")]
			public void calcRect()
			{
			}

			[Token(Token = "0x6000B4F")]
			[Address(RVA = "0x1FC9FAC", Offset = "0x1FC9FAC", VA = "0x1FC9FAC")]
			public void Save(ref Vector3[] verts, int index)
			{
			}

			[Token(Token = "0x6000B50")]
			[Address(RVA = "0x1FCABD8", Offset = "0x1FCABD8", VA = "0x1FCABD8", Slot = "5")]
			public void Transpose(Vector3 v)
			{
			}

			[Token(Token = "0x6000B51")]
			[Address(RVA = "0x1FCACE0", Offset = "0x1FCACE0", VA = "0x1FCACE0", Slot = "6")]
			public void Rotate(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000B52")]
			[Address(RVA = "0x1FC97A0", Offset = "0x1FC97A0", VA = "0x1FC97A0")]
			public GlyphPlain()
			{
			}
		}

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B33BC", Offset = "0x13B33BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B33BC", Offset = "0x13B33BC")]
		[SerializeField]
		private bool staticOrientation;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Graphic m_Graphic;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private RectTransform mRect;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Text mText;

		[Token(Token = "0x17000114")]
		public bool StaticOrientation
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x1FC93E4", Offset = "0x1FC93E4", VA = "0x1FC93E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x1FC93EC", Offset = "0x1FC93EC", VA = "0x1FC93EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000115")]
		protected override bool ShowOrientationSection
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x1FC93F8", Offset = "0x1FC93F8", VA = "0x1FC93F8", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000116")]
		protected override bool ShowOffsetSection
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x1FC9400", Offset = "0x1FC9400", VA = "0x1FC9400", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000117")]
		protected Text Text
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x1FC9408", Offset = "0x1FC9408", VA = "0x1FC9408")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000118")]
		protected RectTransform Rect
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x1FC94B4", Offset = "0x1FC94B4", VA = "0x1FC94B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000119")]
		protected Graphic graphic
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x1FC9560", Offset = "0x1FC9560", VA = "0x1FC9560")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011A")]
		public override CurvySpline Spline
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x1FCA678", Offset = "0x1FCA678", VA = "0x1FCA678", Slot = "38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x1FCA680", Offset = "0x1FCA680", VA = "0x1FCA680", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1FC960C", Offset = "0x1FC960C", VA = "0x1FC960C", Slot = "16")]
		protected override void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1FC9648", Offset = "0x1FC9648", VA = "0x1FC9648", Slot = "41")]
		public void ModifyMesh(Mesh verts)
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1FCA0E4", Offset = "0x1FCA0E4", VA = "0x1FCA0E4", Slot = "42")]
		public void ModifyMesh(VertexHelper vertexHelper)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1FC9944", Offset = "0x1FC9944", VA = "0x1FC9944")]
		private void UpdateGlyph(IGlyph glyph)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1FCA4FC", Offset = "0x1FCA4FC", VA = "0x1FCA4FC", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1FCA5B0", Offset = "0x1FCA5B0", VA = "0x1FCA5B0", Slot = "10")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1FCA96C", Offset = "0x1FCA96C", VA = "0x1FCA96C", Slot = "20")]
		protected override void BindEvents()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1FCA970", Offset = "0x1FCA970", VA = "0x1FCA970", Slot = "21")]
		protected override void UnbindEvents()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1FCA854", Offset = "0x1FCA854", VA = "0x1FCA854")]
		private void BindSplineRelatedEvents()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1FCA744", Offset = "0x1FCA744", VA = "0x1FCA744")]
		private void UnbindSplineRelatedEvents()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1FCA974", Offset = "0x1FCA974", VA = "0x1FCA974")]
		private void OnSplineRefreshed(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1FCAAD8", Offset = "0x1FCAAD8", VA = "0x1FCAAD8")]
		public UITextSplineController()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13AD9B0", Offset = "0x13AD9B0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AD9B0", Offset = "0x13AD9B0")]
	public class VolumeController : CurvyController
	{
		[Token(Token = "0x4000334")]
		private const float CrossPositionRangeMin = -0.5f;

		[Token(Token = "0x4000335")]
		private const float CrossPositionRangeMax = 0.5f;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B3438", Offset = "0x13B3438")]
		[AttributeAttribute(Name = "CGDataReferenceSelectorAttribute", RVA = "0x13B3438", Offset = "0x13B3438")]
		[SerializeField]
		private CGDataReference m_Volume;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B34F8", Offset = "0x13B34F8")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_CrossRange;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B35C4", Offset = "0x13B35C4")]
		[SerializeField]
		private float crossRelativePosition;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CurvyClamping m_CrossClamping;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13B366C", Offset = "0x13B366C")]
		private float m_CrossInitialPosition;

		[Token(Token = "0x1700011B")]
		public CGDataReference Volume
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x1FCB4A4", Offset = "0x1FCB4A4", VA = "0x1FCB4A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x1FCB4AC", Offset = "0x1FCB4AC", VA = "0x1FCB4AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public CGVolume VolumeData
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x1FCB4B4", Offset = "0x1FCB4B4", VA = "0x1FCB4B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011D")]
		public float CrossFrom
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x1FCB52C", Offset = "0x1FCB52C", VA = "0x1FCB52C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x1FCB534", Offset = "0x1FCB534", VA = "0x1FCB534")]
			set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public float CrossTo
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x1FCB5B8", Offset = "0x1FCB5B8", VA = "0x1FCB5B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x1FCB5C0", Offset = "0x1FCB5C0", VA = "0x1FCB5C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700011F")]
		public float CrossLength
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x1FCB648", Offset = "0x1FCB648", VA = "0x1FCB648")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000120")]
		public CurvyClamping CrossClamping
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x1FCB654", Offset = "0x1FCB654", VA = "0x1FCB654")]
			get
			{
				return default(CurvyClamping);
			}
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x1FCB65C", Offset = "0x1FCB65C", VA = "0x1FCB65C")]
			set
			{
			}
		}

		[Token(Token = "0x17000121")]
		public float CrossRelativePosition
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x1FCB664", Offset = "0x1FCB664", VA = "0x1FCB664")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x1FCB690", Offset = "0x1FCB690", VA = "0x1FCB690")]
			set
			{
			}
		}

		[Token(Token = "0x17000122")]
		public override float Length
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x1FCB6C0", Offset = "0x1FCB6C0", VA = "0x1FCB6C0", Slot = "28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000123")]
		public override bool IsReady
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x1FCB7E0", Offset = "0x1FCB7E0", VA = "0x1FCB7E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000124")]
		private RegionOptions<float> CrossRangeOptions
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x1FCBD38", Offset = "0x1FCBD38", VA = "0x1FCBD38")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x17000125")]
		private float MinCrossRelativePosition
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x1FCBD90", Offset = "0x1FCBD90", VA = "0x1FCBD90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000126")]
		private float MaxCrossRelativePosition
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x1FCBD98", Offset = "0x1FCBD98", VA = "0x1FCBD98")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1FCB700", Offset = "0x1FCB700", VA = "0x1FCB700")]
		public float CrossRelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1FCB770", Offset = "0x1FCB770", VA = "0x1FCB770")]
		public float CrossAbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x1FCB830", Offset = "0x1FCB830", VA = "0x1FCB830", Slot = "32")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1FCB88C", Offset = "0x1FCB88C", VA = "0x1FCB88C", Slot = "31")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1FCB8E8", Offset = "0x1FCB8E8", VA = "0x1FCB8E8", Slot = "33")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1FCB980", Offset = "0x1FCB980", VA = "0x1FCB980", Slot = "34")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1FCBA84", Offset = "0x1FCBA84", VA = "0x1FCBA84", Slot = "36")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1FCBB1C", Offset = "0x1FCBB1C", VA = "0x1FCBB1C", Slot = "35")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1FCBBB4", Offset = "0x1FCBBB4", VA = "0x1FCBBB4", Slot = "29")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1FCBC28", Offset = "0x1FCBC28", VA = "0x1FCBC28", Slot = "30")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1FCB67C", Offset = "0x1FCB67C", VA = "0x1FCB67C")]
		private float GetClampedCrossPosition(float position)
		{
			return default(float);
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1FCBDA0", Offset = "0x1FCBDA0", VA = "0x1FCBDA0", Slot = "37")]
		public override void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1FCBDF4", Offset = "0x1FCBDF4", VA = "0x1FCBDF4")]
		public VolumeController()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Components
{
	[Token(Token = "0x20000D5")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13ADA14", Offset = "0x13ADA14")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ADA14", Offset = "0x13ADA14")]
	public class CurvyGLRenderer : MonoBehaviour
	{
		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[ArrayEx]
		public List<GLSlotData> Splines;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material lineMaterial;

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1FC14B0", Offset = "0x1FC14B0", VA = "0x1FC14B0")]
		private void CreateLineMaterial()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1FC15BC", Offset = "0x1FC15BC", VA = "0x1FC15BC")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x1FC1790", Offset = "0x1FC1790", VA = "0x1FC1790")]
		private void sanitize()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1FC1BE8", Offset = "0x1FC1BE8", VA = "0x1FC1BE8")]
		private void OnSplineRefresh(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1FC1D3C", Offset = "0x1FC1D3C", VA = "0x1FC1D3C")]
		private GLSlotData getSlot(CurvySpline spline)
		{
			return null;
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1FC1EB8", Offset = "0x1FC1EB8", VA = "0x1FC1EB8")]
		public void Add(CurvySpline spline)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1FC2040", Offset = "0x1FC2040", VA = "0x1FC2040")]
		public void Remove(CurvySpline spline)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1FC2144", Offset = "0x1FC2144", VA = "0x1FC2144")]
		public CurvyGLRenderer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D6")]
	public class GLSlotData
	{
		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public CurvySpline Spline;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color LineColor;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Vector3[]> VertexData;

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1FC18C0", Offset = "0x1FC18C0", VA = "0x1FC18C0")]
		public void GetVertexData()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1FC1A00", Offset = "0x1FC1A00", VA = "0x1FC1A00")]
		public void Render(Material mat)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1FC1F94", Offset = "0x1FC1F94", VA = "0x1FC1F94")]
		public GLSlotData()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ADA74", Offset = "0x13ADA74")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ADA74", Offset = "0x13ADA74")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13ADA74", Offset = "0x13ADA74")]
	public class CurvyLineRenderer : MonoBehaviour
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline m_Spline;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LineRenderer mRenderer;

		[Token(Token = "0x17000127")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x1FC21C0", Offset = "0x1FC21C0", VA = "0x1FC21C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x1FC21C8", Offset = "0x1FC21C8", VA = "0x1FC21C8")]
			set
			{
			}
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1FC26A8", Offset = "0x1FC26A8", VA = "0x1FC26A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x1FC2780", Offset = "0x1FC2780", VA = "0x1FC2780")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x1FC27E8", Offset = "0x1FC27E8", VA = "0x1FC27E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x1FC27EC", Offset = "0x1FC27EC", VA = "0x1FC27EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1FC27F0", Offset = "0x1FC27F0", VA = "0x1FC27F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1FC27F4", Offset = "0x1FC27F4", VA = "0x1FC27F4")]
		private void EnforceWorldSpaceUsage()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1FC256C", Offset = "0x1FC256C", VA = "0x1FC256C")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1FC2A18", Offset = "0x1FC2A18", VA = "0x1FC2A18")]
		private void OnSplineRefresh(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1FC2A1C", Offset = "0x1FC2A1C", VA = "0x1FC2A1C")]
		private void OnSplineCoordinatesChanged(CurvySpline spline)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1FC23F8", Offset = "0x1FC23F8", VA = "0x1FC23F8")]
		private void BindEvents()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x1FC2284", Offset = "0x1FC2284", VA = "0x1FC2284")]
		private void UnbindEvents()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1FC2A20", Offset = "0x1FC2A20", VA = "0x1FC2A20")]
		public CurvyLineRenderer()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Shapes
{
	[Token(Token = "0x20000D8")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x13ADB30", Offset = "0x13ADB30")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ADB30", Offset = "0x13ADB30")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ADB30", Offset = "0x13ADB30")]
	public class CSCircle : CurvyShape2D
	{
		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[SerializeField]
		private int m_Count;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_Radius;

		[Token(Token = "0x17000128")]
		public int Count
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x290E118", Offset = "0x290E118", VA = "0x290E118")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x290E120", Offset = "0x290E120", VA = "0x290E120")]
			set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public float Radius
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x290E1B4", Offset = "0x290E1B4", VA = "0x290E1B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x290E1BC", Offset = "0x290E1BC", VA = "0x290E1BC")]
			set
			{
			}
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x290E250", Offset = "0x290E250", VA = "0x290E250", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x290E288", Offset = "0x290E288", VA = "0x290E288", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x290E414", Offset = "0x290E414", VA = "0x290E414")]
		public CSCircle()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x13ADBE0", Offset = "0x13ADBE0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ADBE0", Offset = "0x13ADBE0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ADBE0", Offset = "0x13ADBE0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B3774", Offset = "0x13B3774")]
		[SerializeField]
		private float m_Roundness;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B37B4", Offset = "0x13B37B4")]
		private int m_Empty;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B3834", Offset = "0x13B3834")]
		[SerializeField]
		private EatModeEnum m_Eat;

		[Token(Token = "0x1700012A")]
		public float Roundness
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x290E428", Offset = "0x290E428", VA = "0x290E428")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x290E430", Offset = "0x290E430", VA = "0x290E430")]
			set
			{
			}
		}

		[Token(Token = "0x1700012B")]
		public int Empty
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x290E4C0", Offset = "0x290E4C0", VA = "0x290E4C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x290E4C8", Offset = "0x290E4C8", VA = "0x290E4C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		private int maxEmpty
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x290E564", Offset = "0x290E564", VA = "0x290E564")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700012D")]
		public EatModeEnum Eat
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x290E56C", Offset = "0x290E56C", VA = "0x290E56C")]
			get
			{
				return default(EatModeEnum);
			}
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x290E574", Offset = "0x290E574", VA = "0x290E574")]
			set
			{
			}
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x290E590", Offset = "0x290E590", VA = "0x290E590", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x290E5E0", Offset = "0x290E5E0", VA = "0x290E5E0")]
		private Vector3 cpPosition(int i, int empty, float d)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x290E730", Offset = "0x290E730", VA = "0x290E730", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x290EE84", Offset = "0x290EE84", VA = "0x290EE84")]
		public CSPie()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x13ADC90", Offset = "0x13ADC90")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ADC90", Offset = "0x13ADC90")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ADC90", Offset = "0x13ADC90")]
	public class CSRectangle : CurvyShape2D
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[SerializeField]
		private float m_Width;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Positive]
		[SerializeField]
		private float m_Height;

		[Token(Token = "0x1700012E")]
		public float Width
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x290EEA0", Offset = "0x290EEA0", VA = "0x290EEA0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x290EEA8", Offset = "0x290EEA8", VA = "0x290EEA8")]
			set
			{
			}
		}

		[Token(Token = "0x1700012F")]
		public float Height
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x290EF3C", Offset = "0x290EF3C", VA = "0x290EF3C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x290EF44", Offset = "0x290EF44", VA = "0x290EF44")]
			set
			{
			}
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x290EFD8", Offset = "0x290EFD8", VA = "0x290EFD8", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x290F01C", Offset = "0x290F01C", VA = "0x290F01C", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x290F234", Offset = "0x290F234", VA = "0x290F234")]
		public CSRectangle()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x13ADD40", Offset = "0x13ADD40")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ADD40", Offset = "0x13ADD40")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ADD40", Offset = "0x13ADD40")]
	public class CSRoundedRectangle : CurvyShape2D
	{
		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[SerializeField]
		private float m_Width;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Positive]
		[SerializeField]
		private float m_Height;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B396C", Offset = "0x13B396C")]
		[SerializeField]
		private float m_Roundness;

		[Token(Token = "0x17000130")]
		public float Width
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x290F244", Offset = "0x290F244", VA = "0x290F244")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x290F24C", Offset = "0x290F24C", VA = "0x290F24C")]
			set
			{
			}
		}

		[Token(Token = "0x17000131")]
		public float Height
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x290F2E0", Offset = "0x290F2E0", VA = "0x290F2E0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x290F2E8", Offset = "0x290F2E8", VA = "0x290F2E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public float Roundness
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x290F37C", Offset = "0x290F37C", VA = "0x290F37C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x290F384", Offset = "0x290F384", VA = "0x290F384")]
			set
			{
			}
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x290F414", Offset = "0x290F414", VA = "0x290F414", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x290F464", Offset = "0x290F464", VA = "0x290F464", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x290F9C4", Offset = "0x290F9C4", VA = "0x290F9C4")]
		public CSRoundedRectangle()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x13ADDF0", Offset = "0x13ADDF0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ADDF0", Offset = "0x13ADDF0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ADDF0", Offset = "0x13ADDF0")]
	public class CSSpiral : CurvyShape2D
	{
		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[SerializeField]
		private int m_Count;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Positive]
		[SerializeField]
		private float m_Circles;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Positive]
		[SerializeField]
		private float m_Radius;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B3AB4", Offset = "0x13B3AB4")]
		[SerializeField]
		private AnimationCurve m_RadiusFactor;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve m_Z;

		[Token(Token = "0x17000133")]
		public int Count
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x290F9DC", Offset = "0x290F9DC", VA = "0x290F9DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x290F9E4", Offset = "0x290F9E4", VA = "0x290F9E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public float Circles
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x290FA78", Offset = "0x290FA78", VA = "0x290FA78")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x290FA80", Offset = "0x290FA80", VA = "0x290FA80")]
			set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public float Radius
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x290FB14", Offset = "0x290FB14", VA = "0x290FB14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x290FB1C", Offset = "0x290FB1C", VA = "0x290FB1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public AnimationCurve RadiusFactor
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x290FBB0", Offset = "0x290FBB0", VA = "0x290FBB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x290FBB8", Offset = "0x290FBB8", VA = "0x290FBB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public AnimationCurve Z
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x290FBF0", Offset = "0x290FBF0", VA = "0x290FBF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x290FBF8", Offset = "0x290FBF8", VA = "0x290FBF8")]
			set
			{
			}
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x290FC30", Offset = "0x290FC30", VA = "0x290FC30", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x290FCF8", Offset = "0x290FCF8", VA = "0x290FCF8", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x290FECC", Offset = "0x290FECC", VA = "0x290FECC")]
		public CSSpiral()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x13ADEA0", Offset = "0x13ADEA0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ADEA0", Offset = "0x13ADEA0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ADEA0", Offset = "0x13ADEA0")]
	public class CSStar : CurvyShape2D
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Positive]
		private int m_Sides;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Positive]
		private float m_OuterRadius;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B3BB8", Offset = "0x13B3BB8")]
		private float m_OuterRoundness;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Positive]
		private float m_InnerRadius;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B3C60", Offset = "0x13B3C60")]
		private float m_InnerRoundness;

		[Token(Token = "0x17000138")]
		public int Sides
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x290FF60", Offset = "0x290FF60", VA = "0x290FF60")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x290FF68", Offset = "0x290FF68", VA = "0x290FF68")]
			set
			{
			}
		}

		[Token(Token = "0x17000139")]
		public float OuterRadius
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x290FFFC", Offset = "0x290FFFC", VA = "0x290FFFC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x2910004", Offset = "0x2910004", VA = "0x2910004")]
			set
			{
			}
		}

		[Token(Token = "0x1700013A")]
		public float OuterRoundness
		{
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x291009C", Offset = "0x291009C", VA = "0x291009C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x29100A4", Offset = "0x29100A4", VA = "0x29100A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public float InnerRadius
		{
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x2910138", Offset = "0x2910138", VA = "0x2910138")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x2910140", Offset = "0x2910140", VA = "0x2910140")]
			set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public float InnerRoundness
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x29101D4", Offset = "0x29101D4", VA = "0x29101D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x29101DC", Offset = "0x29101DC", VA = "0x29101DC")]
			set
			{
			}
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x2910270", Offset = "0x2910270", VA = "0x2910270", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x29102CC", Offset = "0x29102CC", VA = "0x29102CC", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x2910558", Offset = "0x2910558", VA = "0x2910558")]
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
		[Address(RVA = "0x2C3FCB8", Offset = "0x2C3FCB8", VA = "0x2C3FCB8")]
		public static float ClampTF(float tf, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x2C3FDE8", Offset = "0x2C3FDE8", VA = "0x2C3FDE8")]
		public static float ClampValue(float tf, CurvyClamping clamping, float minTF, float maxTF)
		{
			return default(float);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x2C3FF7C", Offset = "0x2C3FF7C", VA = "0x2C3FF7C")]
		public static float ClampTF(float tf, ref int dir, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x2C400B0", Offset = "0x2C400B0", VA = "0x2C400B0")]
		public static float ClampTF(float tf, ref int dir, CurvyClamping clamping, float minTF, float maxTF)
		{
			return default(float);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x2C40238", Offset = "0x2C40238", VA = "0x2C40238")]
		public static float ClampDistance(float distance, CurvyClamping clamping, float length)
		{
			return default(float);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x2C40344", Offset = "0x2C40344", VA = "0x2C40344")]
		public static float ClampDistance(float distance, CurvyClamping clamping, float length, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x2C4049C", Offset = "0x2C4049C", VA = "0x2C4049C")]
		public static float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float length)
		{
			return default(float);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x2C405FC", Offset = "0x2C405FC", VA = "0x2C405FC")]
		public static float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float length, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x2C4079C", Offset = "0x2C4079C", VA = "0x2C4079C")]
		public static Material GetDefaultMaterial()
		{
			return null;
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x2C40898", Offset = "0x2C40898", VA = "0x2C40898")]
		public static bool Approximately(this float x, float y)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000DF")]
	public class Spline2Mesh
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<SplinePolyLine> Lines;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WindingRule Winding;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 UVTiling;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 UVOffset;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool SuppressUVMapping;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool UV2;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string MeshName;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool VertexLineOnly;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B3CD0", Offset = "0x13B3CD0")]
		private string <Error>k__BackingField;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Tess mTess;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Mesh mMesh;

		[Token(Token = "0x1700013D")]
		public string Error
		{
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x2C40A00", Offset = "0x2C40A00", VA = "0x2C40A00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB138", Offset = "0x13BB138")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x2C40A08", Offset = "0x2C40A08", VA = "0x2C40A08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB148", Offset = "0x13BB148")]
			private set
			{
			}
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x2C40A10", Offset = "0x2C40A10", VA = "0x2C40A10")]
		public bool Apply(out Mesh result)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x2C40F3C", Offset = "0x2C40F3C", VA = "0x2C40F3C")]
		private bool triangulate()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x2C413A0", Offset = "0x2C413A0", VA = "0x2C413A0")]
		private static bool polyLineIsValid(SplinePolyLine pl)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x2C4143C", Offset = "0x2C4143C", VA = "0x2C4143C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF324", Offset = "0x13AF324")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Vector3> vPos;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 curPos;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<Vector3> vTan;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 curTangent;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public List<float> vTF;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float angleFromLast;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float distAccu;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int linearSteps;

			[Token(Token = "0x6000B53")]
			[Address(RVA = "0x2C41CB0", Offset = "0x2C41CB0", VA = "0x2C41CB0")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000B54")]
			[Address(RVA = "0x2C41CB8", Offset = "0x2C41CB8", VA = "0x2C41CB8")]
			internal void <GetPolygon>b__0(float f)
			{
			}
		}

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ContourOrientation Orientation;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline Spline;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VertexCalculation VertexMode;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Angle;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Distance;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Space Space;

		[Token(Token = "0x1700013E")]
		public bool IsClosed
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x2C41608", Offset = "0x2C41608", VA = "0x2C41608")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x2C41510", Offset = "0x2C41510", VA = "0x2C41510")]
		public SplinePolyLine(CurvySpline spline)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x2C415B0", Offset = "0x2C415B0", VA = "0x2C415B0")]
		public SplinePolyLine(CurvySpline spline, float angle, float distance)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x2C4154C", Offset = "0x2C4154C", VA = "0x2C4154C")]
		private SplinePolyLine(CurvySpline spline, VertexCalculation vertexMode, float angle, float distance, Space space = Space.World)
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x2C41264", Offset = "0x2C41264", VA = "0x2C41264")]
		public Vector3[] GetVertices()
		{
			return null;
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x2C4169C", Offset = "0x2C4169C", VA = "0x2C4169C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B3CE0", Offset = "0x13B3CE0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3CE0", Offset = "0x13B3CE0")]
		private bool m_UseCache;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3D50", Offset = "0x13B3D50")]
		[SerializeField]
		private bool m_UseGlobalSpace;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B3D9C", Offset = "0x13B3D9C")]
		[SerializeField]
		protected CurvySplineSegment m_StartCP;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B3DE8", Offset = "0x13B3DE8")]
		[SerializeField]
		protected CurvySplineSegment m_EndCP;

		[Token(Token = "0x1700013F")]
		public bool UseCache
		{
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x290AF38", Offset = "0x290AF38", VA = "0x290AF38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x290AF40", Offset = "0x290AF40", VA = "0x290AF40")]
			set
			{
			}
		}

		[Token(Token = "0x17000140")]
		public CurvySplineSegment StartCP
		{
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x290AF68", Offset = "0x290AF68", VA = "0x290AF68")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x290AF70", Offset = "0x290AF70", VA = "0x290AF70")]
			set
			{
			}
		}

		[Token(Token = "0x17000141")]
		public CurvySplineSegment EndCP
		{
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x290B01C", Offset = "0x290B01C", VA = "0x290B01C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x290B024", Offset = "0x290B024", VA = "0x290B024")]
			set
			{
			}
		}

		[Token(Token = "0x17000142")]
		public bool UseGlobalSpace
		{
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x290B0D0", Offset = "0x290B0D0", VA = "0x290B0D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x290B0D8", Offset = "0x290B0D8", VA = "0x290B0D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000143")]
		public override bool IsConfigured
		{
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x290B0EC", Offset = "0x290B0EC", VA = "0x290B0EC", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000144")]
		public override bool IsInitialized
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x290B194", Offset = "0x290B194", VA = "0x290B194", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000145")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BBB28", Offset = "0x13BBB28")]
		public float PathLength
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x290B264", Offset = "0x290B264", VA = "0x290B264", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000146")]
		public bool PathIsClosed
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x290B3D0", Offset = "0x290B3D0", VA = "0x290B3D0", Slot = "16")]
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
		[Address(RVA = "0x290B4F0", Offset = "0x290B4F0", VA = "0x290B4F0", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x290B538", Offset = "0x290B538", VA = "0x290B538", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x290B6F4", Offset = "0x290B6F4", VA = "0x290B6F4", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x290B774", Offset = "0x290B774", VA = "0x290B774")]
		private void OnSplineRefreshed(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x290B8D4", Offset = "0x290B8D4", VA = "0x290B8D4")]
		private void OnInputSplineCoordinatesChanged(CurvySpline sender)
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x290B8C8", Offset = "0x290B8C8", VA = "0x290B8C8")]
		private void ForceRefresh()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x290B2BC", Offset = "0x290B2BC", VA = "0x290B2BC")]
		private float getPathLength(CurvySpline spline)
		{
			return default(float);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x290B428", Offset = "0x290B428", VA = "0x290B428")]
		private bool getPathClosed(CurvySpline spline)
		{
			return default(bool);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x2904520", Offset = "0x2904520", VA = "0x2904520")]
		protected CGData GetSplineData(CurvySpline spline, bool fullPath, CGDataRequestRasterization raster, CGDataRequestMetaCGOptions options)
		{
			return null;
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x290BBF4", Offset = "0x290BBF4", VA = "0x290BBF4")]
		private static void FillData(CGShape dataToFill, SamplePointsMaterialGroup materialGroup, List<float> sourceFs, List<float> relativeFs, bool isFullPath, List<Vector3> positions, List<Vector3> tangents, List<Vector3> normals, bool considerSplineTransform, Transform splineTransform, Transform generatorTransform)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x290BA74", Offset = "0x290BA74", VA = "0x290BA74")]
		private static void AddPoint(float sourceF, float relativeF, bool isFullPath, Vector3 position, Vector3 tangent, Vector3 up, List<float> sourceFList, List<float> relativeFList, List<Vector3> positionList, List<Vector3> tangentList, List<Vector3> upList)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x290BF44", Offset = "0x290BF44", VA = "0x290BF44")]
		private static bool MoveByAngleExt(CurvySpline spline, bool useCache, ref float tf, float maxDistance, float maxAngle, out Vector3 pos, out Vector3 tan, float stopTF, bool loop, float stepDist)
		{
			return default(bool);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x290C22C", Offset = "0x290C22C", VA = "0x290C22C")]
		private static void CalculateExtendedUV(CurvySpline spline, float startTF, float endTF, List<SamplePointUData> ext, CGShape data)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x290CA28", Offset = "0x290CA28", VA = "0x290CA28")]
		private static MetaCGOptions findPreviousReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp)
		{
			return null;
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x290CB94", Offset = "0x290CB94", VA = "0x290CB94")]
		private static MetaCGOptions findNextReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp)
		{
			return null;
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x2906108", Offset = "0x2906108", VA = "0x2906108", Slot = "19")]
		protected virtual void OnSplineAssigned()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x29040A8", Offset = "0x29040A8", VA = "0x29040A8")]
		protected void ValidateStartAndEndCps()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x2905B80", Offset = "0x2905B80", VA = "0x2905B80")]
		protected SplineInputModuleBase()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class TRSModuleBase : CGModule
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x13B3E50", Offset = "0x13B3E50")]
		private Vector3 m_Transpose;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x13B3EB8", Offset = "0x13B3EB8")]
		private Vector3 m_Rotation;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x13B3F20", Offset = "0x13B3F20")]
		private Vector3 m_Scale;

		[Token(Token = "0x17000148")]
		public Vector3 Transpose
		{
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x290CE9C", Offset = "0x290CE9C", VA = "0x290CE9C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000711")]
			[Address(RVA = "0x290CEA8", Offset = "0x290CEA8", VA = "0x290CEA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000149")]
		public Vector3 Rotation
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x290CF6C", Offset = "0x290CF6C", VA = "0x290CF6C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x290CF78", Offset = "0x290CF78", VA = "0x290CF78")]
			set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x290D03C", Offset = "0x290D03C", VA = "0x290D03C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x290D048", Offset = "0x290D048", VA = "0x290D048")]
			set
			{
			}
		}

		[Token(Token = "0x1700014B")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x2908844", Offset = "0x2908844", VA = "0x2908844")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x290D10C", Offset = "0x290D10C", VA = "0x290D10C", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x290D154", Offset = "0x290D154", VA = "0x290D154", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x2908A00", Offset = "0x2908A00", VA = "0x2908A00")]
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
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B3F88", Offset = "0x13B3F88")]
		private int m_Index;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x13B3FE8", Offset = "0x13B3FE8")]
		private Vector3 m_Position;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x13B4058", Offset = "0x13B4058")]
		private Quaternion m_Rotation;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x13B40C8", Offset = "0x13B40C8")]
		private Vector3 m_Scale;

		[Token(Token = "0x1700014C")]
		public int Index
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0x20F9DEC", Offset = "0x20F9DEC", VA = "0x20F9DEC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700014D")]
		public Vector3 Position
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x20F9DF4", Offset = "0x20F9DF4", VA = "0x20F9DF4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x20F9E00", Offset = "0x20F9E00", VA = "0x20F9E00")]
			set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		public Quaternion Rotation
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x20F9EB8", Offset = "0x20F9EB8", VA = "0x20F9EB8")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x20F9EC4", Offset = "0x20F9EC4", VA = "0x20F9EC4")]
			set
			{
			}
		}

		[Token(Token = "0x1700014F")]
		public Vector3 Scale
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x20F9F90", Offset = "0x20F9F90", VA = "0x20F9F90")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x20F9F9C", Offset = "0x20F9F9C", VA = "0x20F9F9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000150")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x20FA054", Offset = "0x20FA054", VA = "0x20FA054")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x20FA12C", Offset = "0x20FA12C", VA = "0x20FA12C")]
		public CGSpot(int index)
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x20FA224", Offset = "0x20FA224", VA = "0x20FA224")]
		public CGSpot(int index, Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x20FA24C", Offset = "0x20FA24C", VA = "0x20FA24C")]
		public void ToTransform(Transform transform)
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x20FA2AC", Offset = "0x20FA2AC", VA = "0x20FA2AC", Slot = "4")]
		public bool Equals(CGSpot other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x20FA32C", Offset = "0x20FA32C", VA = "0x20FA32C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x20FA3CC", Offset = "0x20FA3CC", VA = "0x20FA3CC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x20FA440", Offset = "0x20FA440", VA = "0x20FA440")]
		public static bool operator ==(CGSpot left, CGSpot right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x20FA474", Offset = "0x20FA474", VA = "0x20FA474")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool SwapUV;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public CGKeepAspectMode KeepAspect;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UVRotation;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 UVOffset;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 UVScale;

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x2BB53B4", Offset = "0x2BB53B4", VA = "0x2BB53B4")]
		public CGMaterialSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EA")]
	public class CGMaterialSettingsEx : CGMaterialSettings
	{
		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int MaterialID;

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x2BB5434", Offset = "0x2BB5434", VA = "0x2BB5434")]
		public CGMaterialSettingsEx()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EB")]
	public class CGMeshProperties
	{
		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Mesh m_Mesh;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material[] m_Material;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x13B4158", Offset = "0x13B4158")]
		private Vector3 m_Translation;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x13B41C0", Offset = "0x13B41C0")]
		private Vector3 m_Rotation;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x13B4228", Offset = "0x13B4228")]
		private Vector3 m_Scale;

		[Token(Token = "0x17000151")]
		public Mesh Mesh
		{
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x2BB5438", Offset = "0x2BB5438", VA = "0x2BB5438")]
			get
			{
				return null;
			}
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x2BB5440", Offset = "0x2BB5440", VA = "0x2BB5440")]
			set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public Material[] Material
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x2BB556C", Offset = "0x2BB556C", VA = "0x2BB556C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x2BB5574", Offset = "0x2BB5574", VA = "0x2BB5574")]
			set
			{
			}
		}

		[Token(Token = "0x17000153")]
		public Vector3 Translation
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x2BB558C", Offset = "0x2BB558C", VA = "0x2BB558C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x2BB5598", Offset = "0x2BB5598", VA = "0x2BB5598")]
			set
			{
			}
		}

		[Token(Token = "0x17000154")]
		public Vector3 Rotation
		{
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x2BB5650", Offset = "0x2BB5650", VA = "0x2BB5650")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x2BB565C", Offset = "0x2BB565C", VA = "0x2BB565C")]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x2BB5714", Offset = "0x2BB5714", VA = "0x2BB5714")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x2BB5720", Offset = "0x2BB5720", VA = "0x2BB5720")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x2BB57D8", Offset = "0x2BB57D8", VA = "0x2BB57D8")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x2BB58F8", Offset = "0x2BB58F8", VA = "0x2BB58F8")]
		public CGMeshProperties()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x2BB5994", Offset = "0x2BB5994", VA = "0x2BB5994")]
		public CGMeshProperties(Mesh mesh)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EC")]
	public class CGGameObjectProperties
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject m_Object;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x13B42A0", Offset = "0x13B42A0")]
		private Vector3 m_Translation;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x13B4308", Offset = "0x13B4308")]
		private Vector3 m_Rotation;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x13B4370", Offset = "0x13B4370")]
		private Vector3 m_Scale;

		[Token(Token = "0x17000157")]
		public GameObject Object
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x2BB49B8", Offset = "0x2BB49B8", VA = "0x2BB49B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x2BB49C0", Offset = "0x2BB49C0", VA = "0x2BB49C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000158")]
		public Vector3 Translation
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x2BB4A60", Offset = "0x2BB4A60", VA = "0x2BB4A60")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x2BB4A6C", Offset = "0x2BB4A6C", VA = "0x2BB4A6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public Vector3 Rotation
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x2BB4B24", Offset = "0x2BB4B24", VA = "0x2BB4B24")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x2BB4B30", Offset = "0x2BB4B30", VA = "0x2BB4B30")]
			set
			{
			}
		}

		[Token(Token = "0x1700015A")]
		public Vector3 Scale
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x2BB4BE8", Offset = "0x2BB4BE8", VA = "0x2BB4BE8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x2BB4BF4", Offset = "0x2BB4BF4", VA = "0x2BB4BF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700015B")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x2BB4CAC", Offset = "0x2BB4CAC", VA = "0x2BB4CAC")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x2BB4DCC", Offset = "0x2BB4DCC", VA = "0x2BB4DCC")]
		public CGGameObjectProperties()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x2BB4E44", Offset = "0x2BB4E44", VA = "0x2BB4E44")]
		public CGGameObjectProperties(GameObject gameObject)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000ED")]
	public class CGWeightedItem
	{
		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B43D8", Offset = "0x13B43D8")]
		[SerializeField]
		private float m_Weight;

		[Token(Token = "0x1700015C")]
		public float Weight
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x20FF384", Offset = "0x20FF384", VA = "0x20FF384")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x20FF38C", Offset = "0x20FF38C", VA = "0x20FF38C")]
			set
			{
			}
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x20FF414", Offset = "0x20FF414", VA = "0x20FF414")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_Name;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_KeepTogether;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_SpaceBefore;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_SpaceAfter;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private CurvyRepeatingOrderEnum m_RepeatingOrder;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[IntRegion]
		[SerializeField]
		private IntRegion m_RepeatingItems;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13B4580", Offset = "0x13B4580")]
		private DistributionModeEnum m_DistributionMode;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_PositionOffset;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_Height;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13B4688", Offset = "0x13B4688")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B4688", Offset = "0x13B4688")]
		[SerializeField]
		private RotationModeEnum m_RotationMode;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x13B4714", Offset = "0x13B4714")]
		private Vector3 m_RotationOffset;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x13B477C", Offset = "0x13B477C")]
		private Vector3 m_RotationScatter;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private List<CGBoundsGroupItem> m_Items;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private WeightedRandom<int> mItemBag;

		[Token(Token = "0x1700015D")]
		public string Name
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x2BB2728", Offset = "0x2BB2728", VA = "0x2BB2728")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x2BB2730", Offset = "0x2BB2730", VA = "0x2BB2730")]
			set
			{
			}
		}

		[Token(Token = "0x1700015E")]
		public bool KeepTogether
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x2BB2778", Offset = "0x2BB2778", VA = "0x2BB2778")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x2BB2780", Offset = "0x2BB2780", VA = "0x2BB2780")]
			set
			{
			}
		}

		[Token(Token = "0x1700015F")]
		public FloatRegion SpaceBefore
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x2BB27A0", Offset = "0x2BB27A0", VA = "0x2BB27A0")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x2BB27B0", Offset = "0x2BB27B0", VA = "0x2BB27B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000160")]
		public FloatRegion SpaceAfter
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x2BB2800", Offset = "0x2BB2800", VA = "0x2BB2800")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x2BB2810", Offset = "0x2BB2810", VA = "0x2BB2810")]
			set
			{
			}
		}

		[Token(Token = "0x17000161")]
		public CurvyRepeatingOrderEnum RepeatingOrder
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x2BB2860", Offset = "0x2BB2860", VA = "0x2BB2860")]
			get
			{
				return default(CurvyRepeatingOrderEnum);
			}
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x2BB2868", Offset = "0x2BB2868", VA = "0x2BB2868")]
			set
			{
			}
		}

		[Token(Token = "0x17000162")]
		public IntRegion RepeatingItems
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x2BB287C", Offset = "0x2BB287C", VA = "0x2BB287C")]
			get
			{
				return default(IntRegion);
			}
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x2BB288C", Offset = "0x2BB288C", VA = "0x2BB288C")]
			set
			{
			}
		}

		[Token(Token = "0x17000163")]
		public DistributionModeEnum DistributionMode
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x2BB28DC", Offset = "0x2BB28DC", VA = "0x2BB28DC")]
			get
			{
				return default(DistributionModeEnum);
			}
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x2BB28E4", Offset = "0x2BB28E4", VA = "0x2BB28E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000164")]
		public FloatRegion PositionOffset
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x2BB28F8", Offset = "0x2BB28F8", VA = "0x2BB28F8")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x2BB2908", Offset = "0x2BB2908", VA = "0x2BB2908")]
			set
			{
			}
		}

		[Token(Token = "0x17000165")]
		public FloatRegion Height
		{
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x2BB2958", Offset = "0x2BB2958", VA = "0x2BB2958")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x2BB2968", Offset = "0x2BB2968", VA = "0x2BB2968")]
			set
			{
			}
		}

		[Token(Token = "0x17000166")]
		public RotationModeEnum RotationMode
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x2BB29B8", Offset = "0x2BB29B8", VA = "0x2BB29B8")]
			get
			{
				return default(RotationModeEnum);
			}
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x2BB29C0", Offset = "0x2BB29C0", VA = "0x2BB29C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000167")]
		public Vector3 RotationOffset
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x2BB29D4", Offset = "0x2BB29D4", VA = "0x2BB29D4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x2BB29E0", Offset = "0x2BB29E0", VA = "0x2BB29E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000168")]
		public Vector3 RotationScatter
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x2BB2A98", Offset = "0x2BB2A98", VA = "0x2BB2A98")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x2BB2AA4", Offset = "0x2BB2AA4", VA = "0x2BB2AA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000169")]
		public List<CGBoundsGroupItem> Items
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x2BB2B5C", Offset = "0x2BB2B5C", VA = "0x2BB2B5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016A")]
		public int FirstRepeating
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x2BB2B64", Offset = "0x2BB2B64", VA = "0x2BB2B64")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x2BB2B6C", Offset = "0x2BB2B6C", VA = "0x2BB2B6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700016B")]
		public int LastRepeating
		{
			[Token(Token = "0x6000762")]
			[Address(RVA = "0x2BB2C6C", Offset = "0x2BB2C6C", VA = "0x2BB2C6C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000763")]
			[Address(RVA = "0x2BB2C74", Offset = "0x2BB2C74", VA = "0x2BB2C74")]
			set
			{
			}
		}

		[Token(Token = "0x1700016C")]
		public int ItemCount
		{
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x2BB2C1C", Offset = "0x2BB2C1C", VA = "0x2BB2C1C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700016D")]
		private RegionOptions<int> RepeatingGroupsOptions
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x2BB2E30", Offset = "0x2BB2E30", VA = "0x2BB2E30")]
			get
			{
				return default(RegionOptions<int>);
			}
		}

		[Token(Token = "0x1700016E")]
		private RegionOptions<float> PositionRangeOptions
		{
			[Token(Token = "0x6000767")]
			[Address(RVA = "0x2BB2ED4", Offset = "0x2BB2ED4", VA = "0x2BB2ED4")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x1700016F")]
		private int lastItemIndex
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x2BB2F2C", Offset = "0x2BB2F2C", VA = "0x2BB2F2C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x2BB2D28", Offset = "0x2BB2D28", VA = "0x2BB2D28")]
		public CGBoundsGroup(string name)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x2BB2FA8", Offset = "0x2BB2FA8", VA = "0x2BB2FA8")]
		internal void PrepareINTERNAL()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x2BB30D0", Offset = "0x2BB30D0", VA = "0x2BB30D0")]
		public static void FillItemBag(WeightedRandom<int> bag, IEnumerable<CGWeightedItem> itemsWeights, int firstItem, int lastItem)
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x2BB31F4", Offset = "0x2BB31F4", VA = "0x2BB31F4")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Index;

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x2BB324C", Offset = "0x2BB324C", VA = "0x2BB324C")]
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
		[Address(RVA = "0x20FAE64", Offset = "0x20FAE64", VA = "0x20FAE64")]
		public ControlPointOption(float tf, float dist, bool includeAnyways, int materialID, bool hardEdge, float maxStepDistance, bool uvEdge, bool uvShift, float firstU, float secondU)
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x20FF424", Offset = "0x20FF424", VA = "0x20FF424", Slot = "4")]
		public bool Equals(ControlPointOption other)
		{
			return default(bool);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x20FF53C", Offset = "0x20FF53C", VA = "0x20FF53C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x20FF5DC", Offset = "0x20FF5DC", VA = "0x20FF5DC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x20FF6F0", Offset = "0x20FF6F0", VA = "0x20FF6F0")]
		public static bool operator ==(ControlPointOption left, ControlPointOption right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x20FF724", Offset = "0x20FF724", VA = "0x20FF724")]
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
			[Address(RVA = "0x290A448", Offset = "0x290A448", VA = "0x290A448")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x290AA1C", Offset = "0x290AA1C", VA = "0x290AA1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000171")]
		public int TriangleCount
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x290A368", Offset = "0x290A368", VA = "0x290A368")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x290AAA0", Offset = "0x290AAA0", VA = "0x290AAA0")]
		public SamplePointsPatch(int start)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x290AAA8", Offset = "0x290AAA8", VA = "0x290AAA8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x290ACC0", Offset = "0x290ACC0", VA = "0x290ACC0", Slot = "4")]
		public bool Equals(SamplePointsPatch other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x290ACE8", Offset = "0x290ACE8", VA = "0x290ACE8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x290AD80", Offset = "0x290AD80", VA = "0x290AD80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x290AD94", Offset = "0x290AD94", VA = "0x290AD94")]
		public static bool operator ==(SamplePointsPatch left, SamplePointsPatch right)
		{
			return default(bool);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x290ADB4", Offset = "0x290ADB4", VA = "0x290ADB4")]
		public static bool operator !=(SamplePointsPatch left, SamplePointsPatch right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F2")]
	public class SamplePointsMaterialGroup
	{
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int MaterialID;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<SamplePointsPatch> Patches;

		[Token(Token = "0x17000172")]
		public int TriangleCount
		{
			[Token(Token = "0x600077D")]
			[Address(RVA = "0x290A2BC", Offset = "0x290A2BC", VA = "0x290A2BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000173")]
		public int StartVertex
		{
			[Token(Token = "0x600077E")]
			[Address(RVA = "0x290A374", Offset = "0x290A374", VA = "0x290A374")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000174")]
		public int EndVertex
		{
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x290A3D8", Offset = "0x290A3D8", VA = "0x290A3D8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000175")]
		public int VertexCount
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x290A454", Offset = "0x290A454", VA = "0x290A454")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x290A488", Offset = "0x290A488", VA = "0x290A488")]
		public SamplePointsMaterialGroup(int materialID)
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x290A518", Offset = "0x290A518", VA = "0x290A518")]
		public void GetLengths(CGVolume volume, out float worldLength, out float uLength)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x2908014", Offset = "0x2908014", VA = "0x2908014")]
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
		[Address(RVA = "0x2909EA8", Offset = "0x2909EA8", VA = "0x2909EA8")]
		public SamplePointUData(int vt, bool uvEdge, float uv0, float uv1)
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x2909EBC", Offset = "0x2909EBC", VA = "0x2909EBC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x290A0DC", Offset = "0x290A0DC", VA = "0x290A0DC", Slot = "4")]
		public bool Equals(SamplePointUData other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x290A158", Offset = "0x290A158", VA = "0x290A158", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x290A1E4", Offset = "0x290A1E4", VA = "0x290A1E4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x290A258", Offset = "0x290A258", VA = "0x290A258")]
		public static bool operator ==(SamplePointUData left, SamplePointUData right)
		{
			return default(bool);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x290A288", Offset = "0x290A288", VA = "0x290A288")]
		public static bool operator !=(SamplePointUData left, SamplePointUData right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F4")]
	public class SamplePointsMaterialGroupCollection : List<SamplePointsMaterialGroup>
	{
		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int MaterialID;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float AspectCorrection;

		[Token(Token = "0x17000176")]
		public int TriangleCount
		{
			[Token(Token = "0x600078B")]
			[Address(RVA = "0x290A6F0", Offset = "0x290A6F0", VA = "0x290A6F0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x290A794", Offset = "0x290A794", VA = "0x290A794")]
		public SamplePointsMaterialGroupCollection()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x290A80C", Offset = "0x290A80C", VA = "0x290A80C")]
		public SamplePointsMaterialGroupCollection(int capacity)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x290A894", Offset = "0x290A894", VA = "0x290A894")]
		public SamplePointsMaterialGroupCollection(IEnumerable<SamplePointsMaterialGroup> collection)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x290A91C", Offset = "0x290A91C", VA = "0x290A91C")]
		public void CalculateAspectCorrection(CGVolume volume, CGMaterialSettingsEx matSettings)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F5")]
	public class CGDataReference
	{
		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CGModule m_Module;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_SlotName;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CGModuleOutputSlot mSlot;

		[Token(Token = "0x17000177")]
		public CGData[] Data
		{
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x2BB34A0", Offset = "0x2BB34A0", VA = "0x2BB34A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000178")]
		public CGModuleOutputSlot Slot
		{
			[Token(Token = "0x6000791")]
			[Address(RVA = "0x2BB3518", Offset = "0x2BB3518", VA = "0x2BB3518")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000179")]
		public bool HasValue
		{
			[Token(Token = "0x6000792")]
			[Address(RVA = "0x2BB3734", Offset = "0x2BB3734", VA = "0x2BB3734")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700017A")]
		public bool IsEmpty
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x2BB3764", Offset = "0x2BB3764", VA = "0x2BB3764")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700017B")]
		public CGModule Module
		{
			[Token(Token = "0x6000794")]
			[Address(RVA = "0x2BB3770", Offset = "0x2BB3770", VA = "0x2BB3770")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017C")]
		public string SlotName
		{
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x2BB3778", Offset = "0x2BB3778", VA = "0x2BB3778")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x2BB3780", Offset = "0x2BB3780", VA = "0x2BB3780")]
		public CGDataReference()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x2BB3788", Offset = "0x2BB3788", VA = "0x2BB3788")]
		public CGDataReference(CGModule module, string slotName)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x2BB380C", Offset = "0x2BB380C", VA = "0x2BB380C")]
		public CGDataReference(CurvyGenerator generator, string moduleName, string slotName)
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x2BB38BC", Offset = "0x2BB38BC", VA = "0x2BB38BC")]
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
		[Address(RVA = "0x2BB37C8", Offset = "0x2BB37C8", VA = "0x2BB37C8")]
		public void setINTERNAL(CGModule module, string slotName)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x2BB3854", Offset = "0x2BB3854", VA = "0x2BB3854")]
		public void setINTERNAL(CurvyGenerator generator, string moduleName, string slotName)
		{
		}
	}
	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x13ADF60", Offset = "0x13ADF60")]
	public sealed class CGDataInfoAttribute : Attribute
	{
		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Color Color;

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x2BB33A4", Offset = "0x2BB33A4", VA = "0x2BB33A4")]
		public CGDataInfoAttribute(Color color)
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x2BB33F0", Offset = "0x2BB33F0", VA = "0x2BB33F0")]
		public CGDataInfoAttribute(float r, float g, float b, float a = 1f)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x2BB3464", Offset = "0x2BB3464", VA = "0x2BB3464")]
		public CGDataInfoAttribute(string htmlColor)
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class CGData
	{
		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x1700017D")]
		public virtual int Count
		{
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x2BB3254", Offset = "0x2BB3254", VA = "0x2BB3254", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x2BB325C", Offset = "0x2BB325C", VA = "0x2BB325C")]
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
		[Address(RVA = "0x2BB3268", Offset = "0x2BB3268", VA = "0x2BB3268")]
		protected int getGenericFIndex(ref float[] FMapArray, float fValue, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x2BB2574", Offset = "0x2BB2574", VA = "0x2BB2574")]
		public CGData()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x13ADF74", Offset = "0x13ADF74")]
	public class CGShape : CGData
	{
		[Serializable]
		[Token(Token = "0x200017B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF334", Offset = "0x13AF334")]
		private sealed class <>c
		{
			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<SamplePointsMaterialGroup, SamplePointsMaterialGroup> <>9__16_0;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<SamplePointsMaterialGroup, SamplePointsMaterialGroup> <>9__18_0;

			[Token(Token = "0x6000B56")]
			[Address(RVA = "0x20F99C8", Offset = "0x20F99C8", VA = "0x20F99C8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B57")]
			[Address(RVA = "0x20F99D0", Offset = "0x20F99D0", VA = "0x20F99D0")]
			internal SamplePointsMaterialGroup <.ctor>b__16_0(SamplePointsMaterialGroup g)
			{
				return null;
			}

			[Token(Token = "0x6000B58")]
			[Address(RVA = "0x20F99EC", Offset = "0x20F99EC", VA = "0x20F99EC")]
			internal SamplePointsMaterialGroup <Copy>b__18_0(SamplePointsMaterialGroup g)
			{
				return null;
			}
		}

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] SourceF;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float[] F;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3[] Position;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3[] Normal;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float[] Map;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<SamplePointsMaterialGroup> MaterialGroups;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool SourceIsManaged;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool Closed;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool Seamless;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float Length;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float mCacheLastF;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int mCacheLastIndex;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float mCacheLastFrag;

		[Token(Token = "0x1700017E")]
		public override int Count
		{
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x2BBE380", Offset = "0x2BBE380", VA = "0x2BBE380", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x2BBCE0C", Offset = "0x2BBCE0C", VA = "0x2BBCE0C")]
		public CGShape()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x2BBD000", Offset = "0x2BBD000", VA = "0x2BBD000")]
		public CGShape(CGShape source)
		{
		}

		[Token(Token = "0x60007A9")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x2BBD47C", Offset = "0x2BBD47C", VA = "0x2BBD47C")]
		public static void Copy(CGShape dest, CGShape source)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x2BBE39C", Offset = "0x2BBE39C", VA = "0x2BBE39C")]
		public void Copy(CGShape source)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x2BBE3A0", Offset = "0x2BBE3A0", VA = "0x2BBE3A0")]
		public float DistanceToF(float distance)
		{
			return default(float);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x2BBE42C", Offset = "0x2BBE42C", VA = "0x2BBE42C")]
		public float FToDistance(float f)
		{
			return default(float);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x2BBD8CC", Offset = "0x2BBD8CC", VA = "0x2BBD8CC")]
		public int GetFIndex(float f, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x2BBE4AC", Offset = "0x2BBE4AC", VA = "0x2BBE4AC")]
		public Vector3 InterpolatePosition(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x2BBE5D8", Offset = "0x2BBE5D8", VA = "0x2BBE5D8")]
		public Vector3 InterpolateUp(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x2BBE704", Offset = "0x2BBE704", VA = "0x2BBE704")]
		public void Interpolate(float f, out Vector3 position, out Vector3 up)
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x2BBE8A8", Offset = "0x2BBE8A8", VA = "0x2BBE8A8")]
		public void Move(ref float f, ref int direction, float speed, CurvyClamping clamping)
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x2BBE8E0", Offset = "0x2BBE8E0", VA = "0x2BBE8E0")]
		public void MoveBy(ref float f, ref int direction, float speedDist, CurvyClamping clamping)
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x2BBDD68", Offset = "0x2BBDD68", VA = "0x2BBDD68", Slot = "6")]
		public virtual void Recalculate()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x2BBE954", Offset = "0x2BBE954", VA = "0x2BBE954")]
		public void RecalculateNormals(List<int> softEdges)
		{
		}
	}
	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x13ADFA0", Offset = "0x13ADFA0")]
	public class CGPath : CGShape
	{
		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3[] Direction;

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x2BBCDA4", Offset = "0x2BBCDA4", VA = "0x2BBCDA4")]
		public CGPath()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x2BBCF34", Offset = "0x2BBCF34", VA = "0x2BBCF34")]
		public CGPath(CGPath source)
		{
		}

		[Token(Token = "0x60007B8")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x2BBD3E0", Offset = "0x2BBD3E0", VA = "0x2BBD3E0")]
		public static void Copy(CGPath dest, CGPath source)
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x2BBD6CC", Offset = "0x2BBD6CC", VA = "0x2BBD6CC")]
		public void Interpolate(float f, out Vector3 position, out Vector3 direction, out Vector3 up)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x2BBD934", Offset = "0x2BBD934", VA = "0x2BBD934")]
		public void Interpolate(float f, float angleF, out Vector3 pos, out Vector3 dir, out Vector3 up)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x2BBDA28", Offset = "0x2BBDA28", VA = "0x2BBDA28")]
		public Vector3 InterpolateDirection(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x2BBDB54", Offset = "0x2BBDB54", VA = "0x2BBDB54", Slot = "6")]
		public override void Recalculate()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x13ADFCC", Offset = "0x13ADFCC")]
	public class CGVolume : CGPath
	{
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector3[] Vertex;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3[] VertexNormal;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float[] CrossF;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float[] CrossMap;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float[] SegmentLength;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool CrossClosed;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool CrossSeamless;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float CrossFShift;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public SamplePointsMaterialGroupCollection CrossMaterialGroups;

		[Token(Token = "0x1700017F")]
		public int CrossSize
		{
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x20FB278", Offset = "0x20FB278", VA = "0x20FB278")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000180")]
		public int VertexCount
		{
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x20FD810", Offset = "0x20FD810", VA = "0x20FD810")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x20FD82C", Offset = "0x20FD82C", VA = "0x20FD82C")]
		public CGVolume()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x20FD8F4", Offset = "0x20FD8F4", VA = "0x20FD8F4")]
		public CGVolume(int samplePoints, CGShape crossShape)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x20FDB5C", Offset = "0x20FDB5C", VA = "0x20FDB5C")]
		public CGVolume(CGPath path, CGShape crossShape)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x20FDDCC", Offset = "0x20FDDCC", VA = "0x20FDDCC")]
		public CGVolume(CGVolume source)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x20FE070", Offset = "0x20FE070", VA = "0x20FE070")]
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
		[Address(RVA = "0x20FE25C", Offset = "0x20FE25C", VA = "0x20FE25C")]
		public void InterpolateVolume(float f, float crossF, out Vector3 pos, out Vector3 dir, out Vector3 up)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x20FE62C", Offset = "0x20FE62C", VA = "0x20FE62C")]
		public Vector3 InterpolateVolumePosition(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x20FE91C", Offset = "0x20FE91C", VA = "0x20FE91C")]
		public Vector3 InterpolateVolumeDirection(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x20FEADC", Offset = "0x20FEADC", VA = "0x20FEADC")]
		public Vector3 InterpolateVolumeUp(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x20FED5C", Offset = "0x20FED5C", VA = "0x20FED5C")]
		public float GetCrossLength(float pathF)
		{
			return default(float);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x20FF104", Offset = "0x20FF104", VA = "0x20FF104")]
		public float CrossFToDistance(float f, float crossF, CurvyClamping crossClamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x20FF148", Offset = "0x20FF148", VA = "0x20FF148")]
		public float CrossDistanceToF(float f, float distance, CurvyClamping crossClamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x20FEEE4", Offset = "0x20FEEE4", VA = "0x20FEEE4")]
		public void GetSegmentIndices(float pathF, out int s0Index, out int s1Index, out float frag)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x20FF190", Offset = "0x20FF190", VA = "0x20FF190")]
		public int GetSegmentIndex(int segment)
		{
			return default(int);
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x20FF1B0", Offset = "0x20FF1B0", VA = "0x20FF1B0")]
		public int GetCrossFIndex(float crossF, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x20FF260", Offset = "0x20FF260", VA = "0x20FF260")]
		public int GetVertexIndex(float pathF, out float pathFrag)
		{
			return default(int);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x20FE5DC", Offset = "0x20FE5DC", VA = "0x20FE5DC")]
		public int GetVertexIndex(float pathF, float crossF, out float pathFrag, out float crossFrag)
		{
			return default(int);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x20FF298", Offset = "0x20FF298", VA = "0x20FF298")]
		public Vector3[] GetSegmentVertices(params int[] segmentIndices)
		{
			return null;
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x20FEF98", Offset = "0x20FEF98", VA = "0x20FEF98")]
		private float calcSegmentLength(int segmentIndex)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x13ADFF4", Offset = "0x13ADFF4")]
	public class CGBounds : CGData
	{
		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Bounds? mBounds;

		[Token(Token = "0x17000181")]
		public Bounds Bounds
		{
			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x2BB239C", Offset = "0x2BB239C", VA = "0x2BB239C")]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x2BB2418", Offset = "0x2BB2418", VA = "0x2BB2418")]
			set
			{
			}
		}

		[Token(Token = "0x17000182")]
		public float Depth
		{
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x2BB2524", Offset = "0x2BB2524", VA = "0x2BB2524")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x2BB256C", Offset = "0x2BB256C", VA = "0x2BB256C")]
		public CGBounds()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x2BB257C", Offset = "0x2BB257C", VA = "0x2BB257C")]
		public CGBounds(Bounds bounds)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x2BB25C8", Offset = "0x2BB25C8", VA = "0x2BB25C8")]
		public CGBounds(CGBounds source)
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x2BB2670", Offset = "0x2BB2670", VA = "0x2BB2670", Slot = "6")]
		public virtual void RecalculateBounds()
		{
		}

		[Token(Token = "0x60007DB")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x2BB2698", Offset = "0x2BB2698", VA = "0x2BB2698")]
		public static void Copy(CGBounds dest, CGBounds source)
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class CGVSubMesh : CGData
	{
		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] Triangles;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material Material;

		[Token(Token = "0x17000183")]
		public override int Count
		{
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x20FD668", Offset = "0x20FD668", VA = "0x20FD668", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x20FD104", Offset = "0x20FD104", VA = "0x20FD104")]
		public CGVSubMesh([Optional] Material material)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x20FBA24", Offset = "0x20FBA24", VA = "0x20FBA24")]
		public CGVSubMesh(int[] triangles, [Optional] Material material)
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x20FD684", Offset = "0x20FD684", VA = "0x20FD684")]
		public CGVSubMesh(int triangleCount, [Optional] Material material)
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x20FB538", Offset = "0x20FB538", VA = "0x20FB538")]
		public CGVSubMesh(CGVSubMesh source)
		{
		}

		[Token(Token = "0x60007E2")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x20FD710", Offset = "0x20FD710", VA = "0x20FD710")]
		public static CGVSubMesh Get(CGVSubMesh data, int triangleCount, [Optional] Material material)
		{
			return null;
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x20FD7B4", Offset = "0x20FD7B4", VA = "0x20FD7B4")]
		public void ShiftIndices(int offset, int startIndex = 0)
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x20FC670", Offset = "0x20FC670", VA = "0x20FC670")]
		public void Add(CGVSubMesh other, int shiftIndexOffset = 0)
		{
		}
	}
	[Token(Token = "0x20000FD")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x13AE018", Offset = "0x13AE018")]
	public class CGVMesh : CGBounds
	{
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3[] Vertex;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector2[] UV;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector2[] UV2;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3[] Normal;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector4[] Tangents;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CGVSubMesh[] SubMeshes;

		[Token(Token = "0x17000184")]
		public override int Count
		{
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x20FAEA8", Offset = "0x20FAEA8", VA = "0x20FAEA8", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000185")]
		public bool HasUV
		{
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x20FAEC4", Offset = "0x20FAEC4", VA = "0x20FAEC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000186")]
		public bool HasUV2
		{
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x20FAEE8", Offset = "0x20FAEE8", VA = "0x20FAEE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000187")]
		public bool HasNormals
		{
			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x20FAF0C", Offset = "0x20FAF0C", VA = "0x20FAF0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000188")]
		public bool HasTangents
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x20FAF30", Offset = "0x20FAF30", VA = "0x20FAF30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000189")]
		public int TriangleCount
		{
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x20FAF54", Offset = "0x20FAF54", VA = "0x20FAF54")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x20FAFE0", Offset = "0x20FAFE0", VA = "0x20FAFE0")]
		public CGVMesh()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x20FAFF8", Offset = "0x20FAFF8", VA = "0x20FAFF8")]
		public CGVMesh(int vertexCount, bool addUV = false, bool addUV2 = false, bool addNormals = false, bool addTangents = false)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x20FB144", Offset = "0x20FB144", VA = "0x20FB144")]
		public CGVMesh(CGVolume volume)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x20FB1A0", Offset = "0x20FB1A0", VA = "0x20FB1A0")]
		public CGVMesh(CGVolume volume, IntRegion subset)
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x20FB294", Offset = "0x20FB294", VA = "0x20FB294")]
		public CGVMesh(CGVMesh source)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x20FB5F4", Offset = "0x20FB5F4", VA = "0x20FB5F4")]
		public CGVMesh(CGMeshProperties meshProperties)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x20FB660", Offset = "0x20FB660", VA = "0x20FB660")]
		public CGVMesh(Mesh source, Material[] materials, Matrix4x4 trsMatrix)
		{
		}

		[Token(Token = "0x60007F3")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x20FBCCC", Offset = "0x20FBCCC", VA = "0x20FBCCC")]
		public static CGVMesh Get(CGVMesh data, CGVolume source, bool addUV, bool reverseNormals)
		{
			return null;
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x20FBD54", Offset = "0x20FBD54", VA = "0x20FBD54")]
		public static CGVMesh Get(CGVMesh data, CGVolume source, IntRegion subset, bool addUV, bool reverseNormals)
		{
			return null;
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x20FC058", Offset = "0x20FC058", VA = "0x20FC058")]
		public void SetSubMeshCount(int count)
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x20FC0B8", Offset = "0x20FC0B8", VA = "0x20FC0B8")]
		public void AddSubMesh([Optional] CGVSubMesh submesh)
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x20FC128", Offset = "0x20FC128", VA = "0x20FC128")]
		public void MergeVMesh(CGVMesh source)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x20FC774", Offset = "0x20FC774", VA = "0x20FC774")]
		public void MergeVMesh(CGVMesh source, Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x20FC974", Offset = "0x20FC974", VA = "0x20FC974")]
		public void MergeVMeshes(List<CGVMesh> vMeshes, int startIndex, int endIndex)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x20FC268", Offset = "0x20FC268", VA = "0x20FC268")]
		private void MergeUVsNormalsAndTangents(CGVMesh source, int preMergeVertexCount)
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x20FC53C", Offset = "0x20FC53C", VA = "0x20FC53C")]
		public CGVSubMesh GetMaterialSubMesh(Material mat, bool createIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x20FD18C", Offset = "0x20FD18C", VA = "0x20FD18C")]
		public Mesh AsMesh()
		{
			return null;
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x20FD204", Offset = "0x20FD204", VA = "0x20FD204")]
		public void ToMesh(ref Mesh msh)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x20FD340", Offset = "0x20FD340", VA = "0x20FD340")]
		public Material[] GetMaterials()
		{
			return null;
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x20FD424", Offset = "0x20FD424", VA = "0x20FD424", Slot = "6")]
		public override void RecalculateBounds()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x20FD638", Offset = "0x20FD638", VA = "0x20FD638")]
		public void RecalculateUV2()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x20FBA74", Offset = "0x20FBA74", VA = "0x20FBA74")]
		public void TRS(Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x6000803")]
		private void copyData<T>(ref T[] src, ref T[] dst, int currentSize, int extraSize)
		{
		}
	}
	[Token(Token = "0x20000FE")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x13AE03C", Offset = "0x13AE03C")]
	public class CGGameObject : CGBounds
	{
		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject Object;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 Translate;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 Rotate;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 Scale;

		[Token(Token = "0x1700018A")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x2BB4000", Offset = "0x2BB4000", VA = "0x2BB4000")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x2BB4120", Offset = "0x2BB4120", VA = "0x2BB4120")]
		public CGGameObject()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x2BB4198", Offset = "0x2BB4198", VA = "0x2BB4198")]
		public CGGameObject(CGGameObjectProperties properties)
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x2BB4348", Offset = "0x2BB4348", VA = "0x2BB4348")]
		public CGGameObject(GameObject obj)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x2BB41E0", Offset = "0x2BB41E0", VA = "0x2BB41E0")]
		public CGGameObject(GameObject obj, Vector3 translate, Vector3 rotate, Vector3 scale)
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x2BB4430", Offset = "0x2BB4430", VA = "0x2BB4430")]
		public CGGameObject(CGGameObject source)
		{
		}

		[Token(Token = "0x600080A")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x2BB4500", Offset = "0x2BB4500", VA = "0x2BB4500")]
		public static CGGameObject Get(CGGameObject data, GameObject obj, Vector3 translate, Vector3 rotate, Vector3 scale)
		{
			return null;
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x2BB4644", Offset = "0x2BB4644", VA = "0x2BB4644", Slot = "6")]
		public override void RecalculateBounds()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x13AE074", Offset = "0x13AE074")]
	public class CGSpots : CGData
	{
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CGSpot[] Points;

		[Token(Token = "0x1700018B")]
		public override int Count
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x20FA4AC", Offset = "0x20FA4AC", VA = "0x20FA4AC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x20FA4C8", Offset = "0x20FA4C8", VA = "0x20FA4C8")]
		public CGSpots()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x20FA534", Offset = "0x20FA534", VA = "0x20FA534")]
		public CGSpots(params CGSpot[] points)
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x20FA568", Offset = "0x20FA568", VA = "0x20FA568")]
		public CGSpots(params List<CGSpot>[] lists)
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x20FA6A8", Offset = "0x20FA6A8", VA = "0x20FA6A8")]
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
		[Address(RVA = "0x2BB3B40", Offset = "0x2BB3B40", VA = "0x2BB3B40")]
		public static implicit operator bool(CGDataRequestParameter a)
		{
			return default(bool);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x2BB397C", Offset = "0x2BB397C", VA = "0x2BB397C")]
		public CGDataRequestParameter()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class CGDataRequestMetaCGOptions : CGDataRequestParameter
	{
		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool CheckHardEdges;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool CheckMaterialID;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool IncludeControlPoints;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool CheckExtendedUV;

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x2BB3918", Offset = "0x2BB3918", VA = "0x2BB3918")]
		public CGDataRequestMetaCGOptions(bool checkEdges, bool checkMaterials, bool includeCP, bool extendedUV)
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x2BB3984", Offset = "0x2BB3984", VA = "0x2BB3984", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x2BB3A98", Offset = "0x2BB3A98", VA = "0x2BB3A98", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000102")]
	public class CGDataRequestShapeRasterization : CGDataRequestRasterization
	{
		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float[] PathF;

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x2BB3EA4", Offset = "0x2BB3EA4", VA = "0x2BB3EA4")]
		public CGDataRequestShapeRasterization(float[] pathF, float start, float rasterizedRelativeLength, int resolution, float angle, ModeEnum mode = ModeEnum.Even)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x2BB3EDC", Offset = "0x2BB3EDC", VA = "0x2BB3EDC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x2BB3FBC", Offset = "0x2BB3FBC", VA = "0x2BB3FBC", Slot = "2")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float Start;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float RasterizedRelativeLength;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Resolution;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13B4814", Offset = "0x13B4814")]
		public float SplineAbsoluteLength;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float AngleThreshold;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ModeEnum Mode;

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x2BB3B4C", Offset = "0x2BB3B4C", VA = "0x2BB3B4C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BB158", Offset = "0x13BB158")]
		public CGDataRequestRasterization(float start, float rasterizedRelativeLength, int resolution, float splineAbsoluteLength, float angle, ModeEnum mode = ModeEnum.Even)
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x2BB3C18", Offset = "0x2BB3C18", VA = "0x2BB3C18")]
		public CGDataRequestRasterization(float start, float rasterizedRelativeLength, int resolution, float angle, ModeEnum mode = ModeEnum.Even)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x2BB3CE0", Offset = "0x2BB3CE0", VA = "0x2BB3CE0")]
		public CGDataRequestRasterization(CGDataRequestRasterization source)
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x2BB3D08", Offset = "0x2BB3D08", VA = "0x2BB3D08", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x2BB3DF0", Offset = "0x2BB3DF0", VA = "0x2BB3DF0", Slot = "2")]
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
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BBB60", Offset = "0x13BBB60")]
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
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AE098", Offset = "0x13AE098")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AE098", Offset = "0x13AE098")]
	public class CGMeshResource : DuplicateEditorMesh, IPoolable
	{
		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MeshRenderer mRenderer;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider mCollider;

		[Token(Token = "0x17000191")]
		public MeshRenderer Renderer
		{
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x2BB5AD4", Offset = "0x2BB5AD4", VA = "0x2BB5AD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000192")]
		public Collider Collider
		{
			[Token(Token = "0x6000829")]
			[Address(RVA = "0x2BB5B80", Offset = "0x2BB5B80", VA = "0x2BB5B80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x2BB5C2C", Offset = "0x2BB5C2C", VA = "0x2BB5C2C")]
		public Mesh Prepare()
		{
			return null;
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x2BB5C88", Offset = "0x2BB5C88", VA = "0x2BB5C88")]
		public bool ColliderMatches(CGColliderEnum type)
		{
			return default(bool);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x2BB5E04", Offset = "0x2BB5E04", VA = "0x2BB5E04")]
		public void RemoveCollider()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x2BB5F04", Offset = "0x2BB5F04", VA = "0x2BB5F04")]
		public bool UpdateCollider(CGColliderEnum mode, bool convex, PhysicMaterial material, MeshColliderCookingOptions meshCookingOptions = MeshColliderCookingOptions.CookForFasterSimulation | MeshColliderCookingOptions.EnableMeshCleaning | MeshColliderCookingOptions.WeldColocatedVertices)
		{
			return default(bool);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x2BB64A0", Offset = "0x2BB64A0", VA = "0x2BB64A0", Slot = "5")]
		public void OnBeforePush()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x2BB64A4", Offset = "0x2BB64A4", VA = "0x2BB64A4", Slot = "6")]
		public void OnAfterPop()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x2BB64A8", Offset = "0x2BB64A8", VA = "0x2BB64A8")]
		public CGMeshResource()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010C")]
	public class CGMeshResourceCollection : ICGResourceCollection
	{
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<CGMeshResource> Items;

		[Token(Token = "0x17000193")]
		public int Count
		{
			[Token(Token = "0x6000831")]
			[Address(RVA = "0x2BB64B0", Offset = "0x2BB64B0", VA = "0x2BB64B0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000194")]
		public UnityEngine.Component[] ItemsArray
		{
			[Token(Token = "0x6000832")]
			[Address(RVA = "0x2BB6500", Offset = "0x2BB6500", VA = "0x2BB6500", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x2BB6558", Offset = "0x2BB6558", VA = "0x2BB6558")]
		public CGMeshResourceCollection()
		{
		}
	}
	[Token(Token = "0x200010D")]
	[ExecuteInEditMode]
	public class CGModule : DTVersionedMonoBehaviour
	{
		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x13B484C", Offset = "0x13B484C")]
		[SerializeField]
		private CurvyCGEvent m_OnBeforeRefresh;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x13B48A4", Offset = "0x13B48A4")]
		[SerializeField]
		private CurvyCGEvent m_OnRefresh;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private string m_ModuleName;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private bool m_Active;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x13B4960", Offset = "0x13B4960")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x13B4960", Offset = "0x13B4960")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x13B4960", Offset = "0x13B4960")]
		[SerializeField]
		private bool m_RandomizeSeed;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[HideInInspector]
		private int m_Seed;

		[NonSerialized]
		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<string> UIMessages;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CurvyGenerator mGenerator;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private int m_UniqueID;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4A7C", Offset = "0x13B4A7C")]
		private bool <CircularReferenceError>k__BackingField;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal int SortAncestors;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public CGModuleProperties Properties;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public List<CGModuleLink> InputLinks;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public List<CGModuleLink> OutputLinks;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4ABC", Offset = "0x13B4ABC")]
		private Dictionary<string, CGModuleInputSlot> <InputByName>k__BackingField;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4ACC", Offset = "0x13B4ACC")]
		private Dictionary<string, CGModuleOutputSlot> <OutputByName>k__BackingField;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4ADC", Offset = "0x13B4ADC")]
		private List<CGModuleInputSlot> <Input>k__BackingField;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4AEC", Offset = "0x13B4AEC")]
		private List<CGModuleOutputSlot> <Output>k__BackingField;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ModuleInfoAttribute mInfo;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool mDirty;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool mInitialized;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		private bool mIsConfiguredInternal;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		private bool mStateChangeDirty;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool mLastIsConfiguredState;

		[Token(Token = "0x17000195")]
		public CurvyCGEvent OnBeforeRefresh
		{
			[Token(Token = "0x6000834")]
			[Address(RVA = "0x2BB68F4", Offset = "0x2BB68F4", VA = "0x2BB68F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x2BB68FC", Offset = "0x2BB68FC", VA = "0x2BB68FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000196")]
		public CurvyCGEvent OnRefresh
		{
			[Token(Token = "0x6000836")]
			[Address(RVA = "0x2BB6914", Offset = "0x2BB6914", VA = "0x2BB6914")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x2BB691C", Offset = "0x2BB691C", VA = "0x2BB691C")]
			set
			{
			}
		}

		[Token(Token = "0x17000197")]
		public string ModuleName
		{
			[Token(Token = "0x600083A")]
			[Address(RVA = "0x2BB6A0C", Offset = "0x2BB6A0C", VA = "0x2BB6A0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600083B")]
			[Address(RVA = "0x2BB6A14", Offset = "0x2BB6A14", VA = "0x2BB6A14")]
			set
			{
			}
		}

		[Token(Token = "0x17000198")]
		public bool Active
		{
			[Token(Token = "0x600083C")]
			[Address(RVA = "0x2BB6C50", Offset = "0x2BB6C50", VA = "0x2BB6C50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600083D")]
			[Address(RVA = "0x2BB6C58", Offset = "0x2BB6C58", VA = "0x2BB6C58")]
			set
			{
			}
		}

		[Token(Token = "0x17000199")]
		public int Seed
		{
			[Token(Token = "0x600083E")]
			[Address(RVA = "0x2BB6DB0", Offset = "0x2BB6DB0", VA = "0x2BB6DB0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x2BB6DB8", Offset = "0x2BB6DB8", VA = "0x2BB6DB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700019A")]
		public bool RandomizeSeed
		{
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x2BB6DD0", Offset = "0x2BB6DD0", VA = "0x2BB6DD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x2BB6DD8", Offset = "0x2BB6DD8", VA = "0x2BB6DD8")]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		public CurvyGenerator Generator
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x2BB6DF8", Offset = "0x2BB6DF8", VA = "0x2BB6DF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019C")]
		public int UniqueID
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x2BB6E00", Offset = "0x2BB6E00", VA = "0x2BB6E00")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700019D")]
		public bool CircularReferenceError
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x2BB6E08", Offset = "0x2BB6E08", VA = "0x2BB6E08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB190", Offset = "0x13BB190")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x2BB6E10", Offset = "0x2BB6E10", VA = "0x2BB6E10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB1A0", Offset = "0x13BB1A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700019E")]
		public Dictionary<string, CGModuleInputSlot> InputByName
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x2BB6E1C", Offset = "0x2BB6E1C", VA = "0x2BB6E1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB1B0", Offset = "0x13BB1B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x2BB6E24", Offset = "0x2BB6E24", VA = "0x2BB6E24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB1C0", Offset = "0x13BB1C0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700019F")]
		public Dictionary<string, CGModuleOutputSlot> OutputByName
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x2BB6E2C", Offset = "0x2BB6E2C", VA = "0x2BB6E2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB1D0", Offset = "0x13BB1D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x2BB6E34", Offset = "0x2BB6E34", VA = "0x2BB6E34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB1E0", Offset = "0x13BB1E0")]
			private set
			{
			}
		}

		[Token(Token = "0x170001A0")]
		public List<CGModuleInputSlot> Input
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x2BB6E3C", Offset = "0x2BB6E3C", VA = "0x2BB6E3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB1F0", Offset = "0x13BB1F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x2BB6E44", Offset = "0x2BB6E44", VA = "0x2BB6E44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB200", Offset = "0x13BB200")]
			private set
			{
			}
		}

		[Token(Token = "0x170001A1")]
		public List<CGModuleOutputSlot> Output
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x2BB6E4C", Offset = "0x2BB6E4C", VA = "0x2BB6E4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB210", Offset = "0x13BB210")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x2BB6E54", Offset = "0x2BB6E54", VA = "0x2BB6E54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB220", Offset = "0x13BB220")]
			private set
			{
			}
		}

		[Token(Token = "0x170001A2")]
		public ModuleInfoAttribute Info
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x2BB6E5C", Offset = "0x2BB6E5C", VA = "0x2BB6E5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A3")]
		public bool Dirty
		{
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x2BB6F94", Offset = "0x2BB6F94", VA = "0x2BB6F94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000850")]
			[Address(RVA = "0x2BB6CB4", Offset = "0x2BB6CB4", VA = "0x2BB6CB4")]
			set
			{
			}
		}

		[Token(Token = "0x170001A4")]
		public virtual bool IsConfigured
		{
			[Token(Token = "0x6000857")]
			[Address(RVA = "0x2BB883C", Offset = "0x2BB883C", VA = "0x2BB883C", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A5")]
		public virtual bool IsInitialized
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0x2BB8C54", Offset = "0x2BB8C54", VA = "0x2BB8C54", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x2BB6934", Offset = "0x2BB6934", VA = "0x2BB6934")]
		protected CurvyCGEventArgs OnBeforeRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x2BB69A0", Offset = "0x2BB69A0", VA = "0x2BB69A0")]
		protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x2BB7178", Offset = "0x2BB7178", VA = "0x2BB7178", Slot = "5")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x2BB71D8", Offset = "0x2BB71D8", VA = "0x2BB71D8", Slot = "6")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x2BB7270", Offset = "0x2BB7270", VA = "0x2BB7270")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x2BB7864", Offset = "0x2BB7864", VA = "0x2BB7864", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x2BB7868", Offset = "0x2BB7868", VA = "0x2BB7868", Slot = "8")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x2BB8834", Offset = "0x2BB8834", VA = "0x2BB8834")]
		private void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x2BB8C5C", Offset = "0x2BB8C5C", VA = "0x2BB8C5C", Slot = "11")]
		public virtual void Refresh()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x2BB8CB4", Offset = "0x2BB8CB4", VA = "0x2BB8CB4", Slot = "12")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x2BB8DF8", Offset = "0x2BB8DF8", VA = "0x2BB8DF8")]
		public void ReInitializeLinkedSlots()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x2BB8F10", Offset = "0x2BB8F10", VA = "0x2BB8F10", Slot = "13")]
		public virtual void OnStateChange()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x2BB9010", Offset = "0x2BB9010", VA = "0x2BB9010", Slot = "14")]
		public virtual void OnTemplateCreated()
		{
		}

		[Token(Token = "0x600085E")]
		protected static T GetRequestParameter<T>(ref CGDataRequestParameter[] requests) where T : CGDataRequestParameter
		{
			return null;
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x2BB9014", Offset = "0x2BB9014", VA = "0x2BB9014")]
		protected static void RemoveRequestParameter(ref CGDataRequestParameter[] requests, CGDataRequestParameter request)
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x2BB90D8", Offset = "0x2BB90D8", VA = "0x2BB90D8")]
		public CGModuleLink GetOutputLink(CGModuleOutputSlot outSlot, CGModuleInputSlot inSlot)
		{
			return null;
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x2BB91B4", Offset = "0x2BB91B4", VA = "0x2BB91B4")]
		public List<CGModuleLink> GetOutputLinks(CGModuleOutputSlot outSlot)
		{
			return null;
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x2BB92C8", Offset = "0x2BB92C8", VA = "0x2BB92C8")]
		public CGModuleLink GetInputLink(CGModuleInputSlot inSlot, CGModuleOutputSlot outSlot)
		{
			return null;
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x2BB92D0", Offset = "0x2BB92D0", VA = "0x2BB92D0")]
		public List<CGModuleLink> GetInputLinks(CGModuleInputSlot inSlot)
		{
			return null;
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x2BB90E0", Offset = "0x2BB90E0", VA = "0x2BB90E0")]
		private static CGModuleLink GetLink(List<CGModuleLink> lst, CGModuleSlot source, CGModuleSlot target)
		{
			return null;
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x2BB91BC", Offset = "0x2BB91BC", VA = "0x2BB91BC")]
		private static List<CGModuleLink> GetLinks(List<CGModuleLink> lst, CGModuleSlot source)
		{
			return null;
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x2BB9498", Offset = "0x2BB9498", VA = "0x2BB9498")]
		public CGModule CopyTo(CurvyGenerator targetGenerator)
		{
			return null;
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x2BB95C8", Offset = "0x2BB95C8", VA = "0x2BB95C8")]
		public UnityEngine.Component AddManagedResource(string resourceName, string context = "", int index = -1)
		{
			return null;
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x2BB81DC", Offset = "0x2BB81DC", VA = "0x2BB81DC")]
		public void DeleteManagedResource(string resourceName, UnityEngine.Component res, string context = "", bool dontUsePool = false)
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x2BB9F20", Offset = "0x2BB9F20", VA = "0x2BB9F20")]
		public bool IsManagedResource(UnityEngine.Component res)
		{
			return default(bool);
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x2BB9954", Offset = "0x2BB9954", VA = "0x2BB9954")]
		protected void RenameResource(string resourceName, UnityEngine.Component resource, int index = -1)
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x2BBA00C", Offset = "0x2BBA00C", VA = "0x2BBA00C")]
		protected PrefabPool GetPrefabPool(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x2BBA170", Offset = "0x2BBA170", VA = "0x2BBA170")]
		public List<IPool> GetAllPrefabPools()
		{
			return null;
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x2BBA240", Offset = "0x2BBA240", VA = "0x2BBA240")]
		public void DeleteAllPrefabPools()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x2BBA310", Offset = "0x2BBA310", VA = "0x2BBA310")]
		public void Delete()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x2BBA3B8", Offset = "0x2BBA3B8", VA = "0x2BBA3B8")]
		public CGModuleInputSlot GetInputSlot(string name)
		{
			return null;
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x2BB82B4", Offset = "0x2BB82B4", VA = "0x2BB82B4")]
		public List<CGModuleInputSlot> GetInputSlots([Optional] Type filterType)
		{
			return null;
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x2BB36A0", Offset = "0x2BB36A0", VA = "0x2BB36A0")]
		public CGModuleOutputSlot GetOutputSlot(string name)
		{
			return null;
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x2BB84D4", Offset = "0x2BB84D4", VA = "0x2BB84D4")]
		public List<CGModuleOutputSlot> GetOutputSlots([Optional] Type filterType)
		{
			return null;
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x2BB7D3C", Offset = "0x2BB7D3C", VA = "0x2BB7D3C")]
		public bool GetManagedResources(out List<UnityEngine.Component> components, out List<string> componentNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x2BB959C", Offset = "0x2BB959C", VA = "0x2BB959C")]
		public int SetUniqueIdINTERNAL()
		{
			return default(int);
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x2BBA44C", Offset = "0x2BBA44C", VA = "0x2BBA44C")]
		internal void initializeSort()
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x2BBA5BC", Offset = "0x2BBA5BC", VA = "0x2BBA5BC")]
		internal List<CGModule> decrementChilds()
		{
			return null;
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x2BBA79C", Offset = "0x2BBA79C", VA = "0x2BBA79C")]
		internal void doRefresh()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x2BBA8DC", Offset = "0x2BBA8DC", VA = "0x2BBA8DC")]
		private static void setSeed(int seed)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x2BB6EA0", Offset = "0x2BB6EA0", VA = "0x2BB6EA0")]
		internal ModuleInfoAttribute getInfo()
		{
			return null;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x2BBA8E4", Offset = "0x2BBA8E4", VA = "0x2BBA8E4")]
		private bool usesRandom()
		{
			return default(bool);
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x2BB7458", Offset = "0x2BB7458", VA = "0x2BB7458")]
		private void loadSlots()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x2BBA930", Offset = "0x2BBA930", VA = "0x2BBA930")]
		private SlotInfo getSlotInfo(FieldInfo f)
		{
			return null;
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x2BB7B90", Offset = "0x2BB7B90", VA = "0x2BB7B90")]
		private void setTreeDirtyStateChange()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x2BB6F9C", Offset = "0x2BB6F9C", VA = "0x2BB6F9C")]
		private void setTreeDirtyState()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x2BBAE20", Offset = "0x2BBAE20", VA = "0x2BBAE20")]
		public void checkOnStateChangedINTERNAL()
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x2BB6A6C", Offset = "0x2BB6A6C", VA = "0x2BB6A6C")]
		public void renameManagedResourcesINTERNAL()
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x2BBAE5C", Offset = "0x2BBAE5C", VA = "0x2BBAE5C")]
		public CGModule()
		{
		}
	}
	[Token(Token = "0x200010E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x13AE134", Offset = "0x13AE134")]
	public sealed class ModuleInfoAttribute : Attribute, IComparable
	{
		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string MenuName;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ModuleName;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Description;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool UsesRandom;

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x210265C", Offset = "0x210265C", VA = "0x210265C")]
		public ModuleInfoAttribute(string name)
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x2102690", Offset = "0x2102690", VA = "0x2102690", Slot = "7")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rect Dimensions;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MinWidth;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float LabelWidth;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color BackgroundColor;

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x2BBB00C", Offset = "0x2BBB00C", VA = "0x2BBB00C")]
		public CGModuleProperties()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000110")]
	public class CGModuleLink
	{
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int m_ModuleID;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_SlotName;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_TargetModuleID;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string m_TargetSlotName;

		[Token(Token = "0x170001A6")]
		public int ModuleID
		{
			[Token(Token = "0x6000885")]
			[Address(RVA = "0x2BBBE24", Offset = "0x2BBBE24", VA = "0x2BBBE24")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A7")]
		public string SlotName
		{
			[Token(Token = "0x6000886")]
			[Address(RVA = "0x2BBBE2C", Offset = "0x2BBBE2C", VA = "0x2BBBE2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A8")]
		public int TargetModuleID
		{
			[Token(Token = "0x6000887")]
			[Address(RVA = "0x2BBBE34", Offset = "0x2BBBE34", VA = "0x2BBBE34")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A9")]
		public string TargetSlotName
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x2BBBE3C", Offset = "0x2BBBE3C", VA = "0x2BBBE3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x2BBBE44", Offset = "0x2BBBE44", VA = "0x2BBBE44")]
		public CGModuleLink(int sourceID, string sourceSlotName, int targetID, string targetSlotName)
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x2BBB3C0", Offset = "0x2BBB3C0", VA = "0x2BBB3C0")]
		public CGModuleLink(CGModuleSlot source, CGModuleSlot target)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x2BBBF08", Offset = "0x2BBBF08", VA = "0x2BBBF08")]
		public bool IsSame(CGModuleLink o)
		{
			return default(bool);
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x2BB92D8", Offset = "0x2BB92D8", VA = "0x2BB92D8")]
		public bool IsSame(CGModuleSlot source, CGModuleSlot target)
		{
			return default(bool);
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x2BBBF80", Offset = "0x2BBBF80", VA = "0x2BBBF80")]
		public bool IsTo(CGModuleSlot s)
		{
			return default(bool);
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x2BB93F4", Offset = "0x2BB93F4", VA = "0x2BB93F4")]
		public bool IsFrom(CGModuleSlot s)
		{
			return default(bool);
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x2BBC024", Offset = "0x2BBC024", VA = "0x2BBC024")]
		public bool IsUsing(CGModule module)
		{
			return default(bool);
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x2BBC05C", Offset = "0x2BBC05C", VA = "0x2BBC05C")]
		public bool IsBetween(CGModuleSlot one, CGModuleSlot another)
		{
			return default(bool);
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x2BBC0D4", Offset = "0x2BBC0D4", VA = "0x2BBC0D4")]
		public void SetModuleIDIINTERNAL(int moduleID, int targetModuleID)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x2BBB3B4", Offset = "0x2BBB3B4", VA = "0x2BBB3B4")]
		public static implicit operator bool(CGModuleLink a)
		{
			return default(bool);
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x2BBC0E0", Offset = "0x2BBC0E0", VA = "0x2BBC0E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000111")]
	public class CGModuleSlot
	{
		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4B3C", Offset = "0x13B4B3C")]
		private CGModule <Module>k__BackingField;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4B4C", Offset = "0x13B4B4C")]
		private SlotInfo <Info>k__BackingField;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4B5C", Offset = "0x13B4B5C")]
		private Vector2 <Origin>k__BackingField;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4B6C", Offset = "0x13B4B6C")]
		private Rect <DropZone>k__BackingField;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<CGModuleSlot> mLinkedSlots;

		[Token(Token = "0x170001AA")]
		public CGModule Module
		{
			[Token(Token = "0x6000894")]
			[Address(RVA = "0x2BBCA6C", Offset = "0x2BBCA6C", VA = "0x2BBCA6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB230", Offset = "0x13BB230")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x2BBCA74", Offset = "0x2BBCA74", VA = "0x2BBCA74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB240", Offset = "0x13BB240")]
			internal set
			{
			}
		}

		[Token(Token = "0x170001AB")]
		public SlotInfo Info
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x2BBCA7C", Offset = "0x2BBCA7C", VA = "0x2BBCA7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB250", Offset = "0x13BB250")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000897")]
			[Address(RVA = "0x2BBCA84", Offset = "0x2BBCA84", VA = "0x2BBCA84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB260", Offset = "0x13BB260")]
			internal set
			{
			}
		}

		[Token(Token = "0x170001AC")]
		public Vector2 Origin
		{
			[Token(Token = "0x6000898")]
			[Address(RVA = "0x2BBCA8C", Offset = "0x2BBCA8C", VA = "0x2BBCA8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB270", Offset = "0x13BB270")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000899")]
			[Address(RVA = "0x2BBCA94", Offset = "0x2BBCA94", VA = "0x2BBCA94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB280", Offset = "0x13BB280")]
			set
			{
			}
		}

		[Token(Token = "0x170001AD")]
		public Rect DropZone
		{
			[Token(Token = "0x600089A")]
			[Address(RVA = "0x2BBCA9C", Offset = "0x2BBCA9C", VA = "0x2BBCA9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB290", Offset = "0x13BB290")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x2BBCAA8", Offset = "0x2BBCAA8", VA = "0x2BBCAA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB2A0", Offset = "0x13BB2A0")]
			set
			{
			}
		}

		[Token(Token = "0x170001AE")]
		public bool IsLinked
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x2BB8AC0", Offset = "0x2BB8AC0", VA = "0x2BB8AC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001AF")]
		public bool IsLinkedAndConfigured
		{
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x2BBCAB4", Offset = "0x2BBCAB4", VA = "0x2BBCAB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001B0")]
		public IOnRequestProcessing OnRequestModule
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0x2BBBC2C", Offset = "0x2BBBC2C", VA = "0x2BBBC2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B1")]
		public IOnRequestPath OnRequestPathModule
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0x2BBCB90", Offset = "0x2BBCB90", VA = "0x2BBCB90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B2")]
		public IPathProvider PathProvider
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x2BBCBE0", Offset = "0x2BBCBE0", VA = "0x2BBCBE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B3")]
		public IExternalInput ExternalInput
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x2BBCC30", Offset = "0x2BBCC30", VA = "0x2BBCC30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B4")]
		public List<CGModuleSlot> LinkedSlots
		{
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x2BBA534", Offset = "0x2BBA534", VA = "0x2BBA534")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B5")]
		public int Count
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x2BB8C00", Offset = "0x2BB8C00", VA = "0x2BB8C00")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001B6")]
		public string Name
		{
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x2BBBEAC", Offset = "0x2BBBEAC", VA = "0x2BBBEAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x2BBB050", Offset = "0x2BBB050", VA = "0x2BBB050")]
		public CGModuleSlot()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x2BBB730", Offset = "0x2BBB730", VA = "0x2BBB730")]
		public bool HasLinkTo(CGModuleSlot other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x2BBAD28", Offset = "0x2BBAD28", VA = "0x2BBAD28")]
		public List<CGModule> GetLinkedModules()
		{
			return null;
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x2BBB7F0", Offset = "0x2BBB7F0", VA = "0x2BBB7F0", Slot = "4")]
		public virtual void LinkTo(CGModuleSlot other)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x2BBBA4C", Offset = "0x2BBBA4C", VA = "0x2BBBA4C", Slot = "5")]
		public virtual void UnlinkFrom(CGModuleSlot other)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x2BBCC80", Offset = "0x2BBCC80", VA = "0x2BBCC80", Slot = "6")]
		public virtual void UnlinkAll()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x2BB8F04", Offset = "0x2BB8F04", VA = "0x2BB8F04")]
		public void ReInitializeLinkedSlots()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x2BB86F4", Offset = "0x2BB86F4", VA = "0x2BB86F4")]
		public void ReInitializeLinkedTargetModules()
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x2BBB3B0", Offset = "0x2BBB3B0", VA = "0x2BBB3B0", Slot = "7")]
		protected virtual void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x2BBCC84", Offset = "0x2BBCC84", VA = "0x2BBCC84")]
		public static implicit operator bool(CGModuleSlot a)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x2BBCC90", Offset = "0x2BBCC90", VA = "0x2BBCC90", Slot = "3")]
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
			[Address(RVA = "0x2BB8A58", Offset = "0x2BB8A58", VA = "0x2BB8A58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x2BBB048", Offset = "0x2BBB048", VA = "0x2BBB048")]
		public CGModuleInputSlot()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x2BBB058", Offset = "0x2BBB058", VA = "0x2BBB058", Slot = "7")]
		protected override void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x2BBB474", Offset = "0x2BBB474", VA = "0x2BBB474", Slot = "6")]
		public override void UnlinkAll()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x2BBB5A8", Offset = "0x2BBB5A8", VA = "0x2BBB5A8", Slot = "4")]
		public override void LinkTo(CGModuleSlot outputSlot)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x2BBB8E8", Offset = "0x2BBB8E8", VA = "0x2BBB8E8", Slot = "5")]
		public override void UnlinkFrom(CGModuleSlot outputSlot)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x2BB8B28", Offset = "0x2BB8B28", VA = "0x2BB8B28")]
		public CGModuleOutputSlot SourceSlot(int index = 0)
		{
			return null;
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x2BBBB44", Offset = "0x2BBBB44", VA = "0x2BBBB44")]
		public bool CanLinkTo(CGModuleOutputSlot source)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x2BBBD00", Offset = "0x2BBBD00", VA = "0x2BBBD00")]
		public static bool AreInputAndOutputSlotsCompatible(InputSlotInfo inputSlotInfo, bool inputSlotModuleIsOnRequest, OutputSlotInfo outputSlotInfo, bool outputSlotModuleIsOnRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x2BBBD80", Offset = "0x2BBBD80", VA = "0x2BBBD80")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CGData[] Data;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CGDataRequestParameter[] LastRequestParameters;

		[Token(Token = "0x170001B8")]
		public OutputSlotInfo OutputInfo
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x2BBBC7C", Offset = "0x2BBBC7C", VA = "0x2BBBC7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B9")]
		public bool HasData
		{
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x2BBC9A8", Offset = "0x2BBC9A8", VA = "0x2BBC9A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x2BBC2C0", Offset = "0x2BBC2C0", VA = "0x2BBC2C0")]
		public CGModuleOutputSlot()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x2BBC32C", Offset = "0x2BBC32C", VA = "0x2BBC32C", Slot = "7")]
		protected override void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x2BBC684", Offset = "0x2BBC684", VA = "0x2BBC684", Slot = "4")]
		public override void LinkTo(CGModuleSlot inputSlot)
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x2BBC844", Offset = "0x2BBC844", VA = "0x2BBC844", Slot = "5")]
		public override void UnlinkFrom(CGModuleSlot inputSlot)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x2BB8FB0", Offset = "0x2BB8FB0", VA = "0x2BB8FB0")]
		public void ClearData()
		{
		}

		[Token(Token = "0x60008C5")]
		public void SetData<T>(List<T> data) where T : CGData
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x2BBC9E8", Offset = "0x2BBC9E8", VA = "0x2BBC9E8")]
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
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x13AE148", Offset = "0x13AE148")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Type[] DataTypes;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string displayName;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Tooltip;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool Array;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public SlotArrayType ArrayType;

		[Token(Token = "0x170001BA")]
		public string DisplayName
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x290AE6C", Offset = "0x290AE6C", VA = "0x290AE6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x290AE84", Offset = "0x290AE84", VA = "0x290AE84")]
			set
			{
			}
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x2909E1C", Offset = "0x2909E1C", VA = "0x2909E1C")]
		protected SlotInfo(string name, params Type[] type)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x290AE8C", Offset = "0x290AE8C", VA = "0x290AE8C")]
		protected SlotInfo(params Type[] type)
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x290AE98", Offset = "0x290AE98", VA = "0x290AE98", Slot = "7")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x13AE15C", Offset = "0x13AE15C")]
	public sealed class InputSlotInfo : SlotInfo
	{
		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool RequestDataOnly;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool Optional;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool ModifiesData;

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x2102538", Offset = "0x2102538", VA = "0x2102538")]
		public InputSlotInfo(string name, params Type[] type)
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x2102540", Offset = "0x2102540", VA = "0x2102540")]
		public InputSlotInfo(params Type[] type)
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x2102550", Offset = "0x2102550", VA = "0x2102550")]
		public bool IsValidFrom(Type outType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x13AE190", Offset = "0x13AE190")]
	public class OutputSlotInfo : SlotInfo
	{
		[Token(Token = "0x170001BB")]
		public Type DataType
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x2909D18", Offset = "0x2909D18", VA = "0x2909D18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x2909D4C", Offset = "0x2909D4C", VA = "0x2909D4C")]
		public OutputSlotInfo(Type type)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x2909D58", Offset = "0x2909D58", VA = "0x2909D58")]
		public OutputSlotInfo(string name, Type type)
		{
		}
	}
	[Token(Token = "0x2000117")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x13AE1C4", Offset = "0x13AE1C4")]
	public class ShapeOutputSlotInfo : OutputSlotInfo
	{
		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool OutputsVariableShape;

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x290ADD4", Offset = "0x290ADD4", VA = "0x290ADD4")]
		public ShapeOutputSlotInfo()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x290ADDC", Offset = "0x290ADDC", VA = "0x290ADDC")]
		public ShapeOutputSlotInfo(string name)
		{
		}
	}
	[Token(Token = "0x2000118")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x13AE1F8", Offset = "0x13AE1F8")]
	public sealed class ResourceLoaderAttribute : Attribute
	{
		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string ResourceName;

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x2909E74", Offset = "0x2909E74", VA = "0x2909E74")]
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
		[Address(RVA = "0x2BB9744", Offset = "0x2BB9744", VA = "0x2BB9744")]
		public static UnityEngine.Component CreateResource(CGModule module, string resName, string context)
		{
			return null;
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x2BB9BFC", Offset = "0x2BB9BFC", VA = "0x2BB9BFC")]
		public static void DestroyResource(CGModule module, string resName, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x2BBE074", Offset = "0x2BBE074", VA = "0x2BBE074")]
		private static void getLoaders()
		{
		}
	}
	[Token(Token = "0x200011A")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x13AE20C", Offset = "0x13AE20C")]
	public class CGSplineResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x20F9BA8", Offset = "0x20F9BA8", VA = "0x20F9BA8", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x20F9D44", Offset = "0x20F9D44", VA = "0x20F9D44", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x20F9DE4", Offset = "0x20F9DE4", VA = "0x20F9DE4")]
		public CGSplineResourceLoader()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x13AE244", Offset = "0x13AE244")]
	public class CGShapeResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x20F9A08", Offset = "0x20F9A08", VA = "0x20F9A08", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x20F9B00", Offset = "0x20F9B00", VA = "0x20F9B00", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x20F9BA0", Offset = "0x20F9BA0", VA = "0x20F9BA0")]
		public CGShapeResourceLoader()
		{
		}
	}
	[Token(Token = "0x200011C")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x13AE27C", Offset = "0x13AE27C")]
	public class CGMeshResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x2BB65D4", Offset = "0x2BB65D4", VA = "0x2BB65D4", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x2BB664C", Offset = "0x2BB664C", VA = "0x2BB664C", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x2BB68EC", Offset = "0x2BB68EC", VA = "0x2BB68EC")]
		public CGMeshResourceLoader()
		{
		}
	}
	[Token(Token = "0x200011D")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x13AE2B4", Offset = "0x13AE2B4")]
	public class CGGameObjectResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x2BB502C", Offset = "0x2BB502C", VA = "0x2BB502C", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x2BB5194", Offset = "0x2BB5194", VA = "0x2BB5194", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x2BB53AC", Offset = "0x2BB53AC", VA = "0x2BB53AC")]
		public CGGameObjectResourceLoader()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011E")]
	public class CGGameObjectResourceCollection : ICGResourceCollection
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Transform> Items;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> PoolNames;

		[Token(Token = "0x170001BC")]
		public int Count
		{
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x2BB4ED4", Offset = "0x2BB4ED4", VA = "0x2BB4ED4", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001BD")]
		public UnityEngine.Component[] ItemsArray
		{
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x2BB4F24", Offset = "0x2BB4F24", VA = "0x2BB4F24", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x2BB4F7C", Offset = "0x2BB4F7C", VA = "0x2BB4F7C")]
		public CGGameObjectResourceCollection()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public static class CGUtility
	{
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x20FA6E4", Offset = "0x20FA6E4", VA = "0x20FA6E4")]
		public static Vector2[] CalculateUV2(Vector2[] uv)
		{
			return null;
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x20FA808", Offset = "0x20FA808", VA = "0x20FA808")]
		public static List<ControlPointOption> GetControlPointsWithOptions(CGDataRequestMetaCGOptions options, CurvySpline shape, float startDist, float endDist, bool optimize, out int initialMaterialID, out float initialMaxStep)
		{
			return null;
		}
	}
	[Token(Token = "0x2000120")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AE2EC", Offset = "0x13AE2EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13AE2EC", Offset = "0x13AE2EC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AE2EC", Offset = "0x13AE2EC")]
	public class CurvyGenerator : DTVersionedMonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200017E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF344", Offset = "0x13AF344")]
		private sealed class <>c
		{
			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<CGModule, bool> <>9__47_0;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<CGModule, float> <>9__47_1;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<CGModuleInputSlot, IEnumerable<CGModule>> <>9__65_0;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<CGModule, float> <>9__65_1;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<CGModuleInputSlot, IEnumerable<CGModule>> <>9__66_0;

			[Token(Token = "0x6000B5A")]
			[Address(RVA = "0x210243C", Offset = "0x210243C", VA = "0x210243C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B5B")]
			[Address(RVA = "0x2102444", Offset = "0x2102444", VA = "0x2102444")]
			internal bool <ReorderModules>b__47_0(CGModule m)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B5C")]
			[Address(RVA = "0x21024A8", Offset = "0x21024A8", VA = "0x21024A8")]
			internal float <ReorderModules>b__47_1(CGModule m)
			{
				return default(float);
			}

			[Token(Token = "0x6000B5D")]
			[Address(RVA = "0x21024D0", Offset = "0x21024D0", VA = "0x21024D0")]
			internal IEnumerable<CGModule> <ReorderEndpointRecursiveInputs>b__65_0(CGModuleInputSlot i)
			{
				return null;
			}

			[Token(Token = "0x6000B5E")]
			[Address(RVA = "0x21024EC", Offset = "0x21024EC", VA = "0x21024EC")]
			internal float <ReorderEndpointRecursiveInputs>b__65_1(CGModule m)
			{
				return default(float);
			}

			[Token(Token = "0x6000B5F")]
			[Address(RVA = "0x2102514", Offset = "0x2102514", VA = "0x2102514")]
			internal IEnumerable<CGModule> <UpdateModulesRecursiveInputs>b__66_0(CGModuleInputSlot i)
			{
				return null;
			}
		}

		[Token(Token = "0x200017F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF354", Offset = "0x13AF354")]
		private sealed class <>c__DisplayClass66_0
		{
			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs;

			[Token(Token = "0x6000B60")]
			[Address(RVA = "0x21022D4", Offset = "0x21022D4", VA = "0x21022D4")]
			public <>c__DisplayClass66_0()
			{
			}

			[Token(Token = "0x6000B61")]
			[Address(RVA = "0x2102530", Offset = "0x2102530", VA = "0x2102530")]
			internal IEnumerable<CGModule> <UpdateModulesRecursiveInputs>b__1(CGModule i)
			{
				return null;
			}
		}

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4B7C", Offset = "0x13B4B7C")]
		[SerializeField]
		private bool m_ShowDebug;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4BC8", Offset = "0x13B4BC8")]
		[SerializeField]
		private bool m_AutoRefresh;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B4C14", Offset = "0x13B4C14")]
		[Positive]
		[SerializeField]
		private int m_RefreshDelay;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B4CF8", Offset = "0x13B4CF8")]
		[Positive]
		[SerializeField]
		private int m_RefreshDelayEditor;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B4DDC", Offset = "0x13B4DDC")]
		[SerializeField]
		private CurvyCGEvent m_OnRefresh;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public List<CGModule> Modules;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		internal int m_LastModuleID;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4E98", Offset = "0x13B4E98")]
		private bool <Destroying>k__BackingField;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Dictionary<int, CGModule> ModulesByID;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool mInitialized;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool mInitializedPhaseOne;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool mNeedSort;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private double mLastUpdateTime;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PoolManager mPoolManager;

		[Token(Token = "0x4000437")]
		private const int ModulesReorderingDeltaX = 50;

		[Token(Token = "0x4000438")]
		private const int ModulesReorderingDeltaY = 20;

		[Token(Token = "0x170001BE")]
		public bool ShowDebug
		{
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x20FF75C", Offset = "0x20FF75C", VA = "0x20FF75C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x20FF764", Offset = "0x20FF764", VA = "0x20FF764")]
			set
			{
			}
		}

		[Token(Token = "0x170001BF")]
		public bool AutoRefresh
		{
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x20FF784", Offset = "0x20FF784", VA = "0x20FF784")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x20FF78C", Offset = "0x20FF78C", VA = "0x20FF78C")]
			set
			{
			}
		}

		[Token(Token = "0x170001C0")]
		public int RefreshDelay
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x20FF7AC", Offset = "0x20FF7AC", VA = "0x20FF7AC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x20FF7B4", Offset = "0x20FF7B4", VA = "0x20FF7B4")]
			set
			{
			}
		}

		[Token(Token = "0x170001C1")]
		public int RefreshDelayEditor
		{
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x20FF840", Offset = "0x20FF840", VA = "0x20FF840")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x20FF848", Offset = "0x20FF848", VA = "0x20FF848")]
			set
			{
			}
		}

		[Token(Token = "0x170001C2")]
		public PoolManager PoolManager
		{
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x20FF8D4", Offset = "0x20FF8D4", VA = "0x20FF8D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C3")]
		public CurvyCGEvent OnRefresh
		{
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x20FF980", Offset = "0x20FF980", VA = "0x20FF980")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x20FF988", Offset = "0x20FF988", VA = "0x20FF988")]
			set
			{
			}
		}

		[Token(Token = "0x170001C4")]
		public bool IsInitialized
		{
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x20FF9A0", Offset = "0x20FF9A0", VA = "0x20FF9A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001C5")]
		public bool Destroying
		{
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x20FF9A8", Offset = "0x20FF9A8", VA = "0x20FF9A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB2B0", Offset = "0x13BB2B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x20FF9B0", Offset = "0x20FF9B0", VA = "0x20FF9B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB2C0", Offset = "0x13BB2C0")]
			private set
			{
			}
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x20FF9BC", Offset = "0x20FF9BC", VA = "0x20FF9BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x20FF9C0", Offset = "0x20FF9C0", VA = "0x20FF9C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x20FF9E4", Offset = "0x20FF9E4", VA = "0x20FF9E4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x20FF9F4", Offset = "0x20FF9F4", VA = "0x20FF9F4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x20FFA00", Offset = "0x20FFA00", VA = "0x20FFA00")]
		private void Update()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x2100470", Offset = "0x2100470", VA = "0x2100470")]
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
		[Address(RVA = "0x2100594", Offset = "0x2100594", VA = "0x2100594")]
		public CGModule AddModule(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x21006E4", Offset = "0x21006E4", VA = "0x21006E4")]
		public void ArrangeModules()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x2100A0C", Offset = "0x2100A0C", VA = "0x2100A0C")]
		public void ReorderModules()
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x2101650", Offset = "0x2101650", VA = "0x2101650")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x2101768", Offset = "0x2101768", VA = "0x2101768")]
		public void DeleteModule(CGModule module)
		{
		}

		[Token(Token = "0x6000906")]
		public List<T> FindModules<T>(bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x21017F4", Offset = "0x21017F4", VA = "0x21017F4")]
		public List<CGModule> GetModules(bool includeOnRequestProcessing = false)
		{
			return null;
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x2101944", Offset = "0x2101944", VA = "0x2101944")]
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
		[Address(RVA = "0x21019F0", Offset = "0x21019F0", VA = "0x21019F0")]
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
		[Address(RVA = "0x2101B30", Offset = "0x2101B30", VA = "0x2101B30")]
		public CGModuleOutputSlot GetModuleOutputSlot(int moduleId, string slotName)
		{
			return null;
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x2101BF0", Offset = "0x2101BF0", VA = "0x2101BF0")]
		public CGModuleOutputSlot GetModuleOutputSlot(string moduleName, string slotName)
		{
			return null;
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x20FFA9C", Offset = "0x20FFA9C", VA = "0x20FFA9C")]
		public void Initialize(bool force = false)
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x20FFE64", Offset = "0x20FFE64", VA = "0x20FFE64")]
		public void Refresh(bool forceUpdate = false)
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x2102050", Offset = "0x2102050", VA = "0x2102050")]
		protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x2101654", Offset = "0x2101654", VA = "0x2101654")]
		private void clearModules()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x21020BC", Offset = "0x21020BC", VA = "0x21020BC")]
		public string getUniqueModuleNameINTERNAL(string name)
		{
			return null;
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x2101CB0", Offset = "0x2101CB0", VA = "0x2101CB0")]
		internal void sortModulesINTERNAL()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x2101CBC", Offset = "0x2101CBC", VA = "0x2101CBC")]
		private bool doSortModules()
		{
			return default(bool);
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x210119C", Offset = "0x210119C", VA = "0x210119C")]
		private static void ReorderEndpointRecursiveInputs(CGModule endPoint, HashSet<int> reordredModuleIds, Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs)
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x2100F2C", Offset = "0x2100F2C", VA = "0x2100F2C")]
		private static HashSet<CGModule> UpdateModulesRecursiveInputs(Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs, CGModule moduleToAdd)
		{
			return null;
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x21022DC", Offset = "0x21022DC", VA = "0x21022DC")]
		public CurvyGenerator()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Generator.Modules
{
	[Token(Token = "0x2000121")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AE3AC", Offset = "0x13AE3AC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AE3AC", Offset = "0x13AE3AC")]
	public class BuildRasterizedPath : CGModule, IPathProvider
	{
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B4EA8", Offset = "0x13B4EA8")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B4F78", Offset = "0x13B4F78")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_Range;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B508C", Offset = "0x13B508C")]
		private int m_Resolution;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private bool m_Optimize;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B5108", Offset = "0x13B5108")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B5108", Offset = "0x13B5108")]
		private float m_AngleTreshold;

		[Token(Token = "0x170001C6")]
		public float From
		{
			[Token(Token = "0x6000918")]
			[Address(RVA = "0x2102714", Offset = "0x2102714", VA = "0x2102714")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000919")]
			[Address(RVA = "0x210271C", Offset = "0x210271C", VA = "0x210271C")]
			set
			{
			}
		}

		[Token(Token = "0x170001C7")]
		public float To
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x21027B4", Offset = "0x21027B4", VA = "0x21027B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x21027BC", Offset = "0x21027BC", VA = "0x21027BC")]
			set
			{
			}
		}

		[Token(Token = "0x170001C8")]
		public float Length
		{
			[Token(Token = "0x600091C")]
			[Address(RVA = "0x2102988", Offset = "0x2102988", VA = "0x2102988")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x21029B8", Offset = "0x21029B8", VA = "0x21029B8")]
			set
			{
			}
		}

		[Token(Token = "0x170001C9")]
		public int Resolution
		{
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x2102A0C", Offset = "0x2102A0C", VA = "0x2102A0C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x2102A14", Offset = "0x2102A14", VA = "0x2102A14")]
			set
			{
			}
		}

		[Token(Token = "0x170001CA")]
		public bool Optimize
		{
			[Token(Token = "0x6000920")]
			[Address(RVA = "0x2102AB0", Offset = "0x2102AB0", VA = "0x2102AB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x2102AB8", Offset = "0x2102AB8", VA = "0x2102AB8")]
			set
			{
			}
		}

		[Token(Token = "0x170001CB")]
		public float AngleThreshold
		{
			[Token(Token = "0x6000922")]
			[Address(RVA = "0x2102AE0", Offset = "0x2102AE0", VA = "0x2102AE0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000923")]
			[Address(RVA = "0x2102AE8", Offset = "0x2102AE8", VA = "0x2102AE8")]
			set
			{
			}
		}

		[Token(Token = "0x170001CC")]
		public CGPath Path
		{
			[Token(Token = "0x6000924")]
			[Address(RVA = "0x2102B8C", Offset = "0x2102B8C", VA = "0x2102B8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CD")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x2102894", Offset = "0x2102894", VA = "0x2102894", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001CE")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x6000926")]
			[Address(RVA = "0x2102BE4", Offset = "0x2102BE4", VA = "0x2102BE4")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x2102CE8", Offset = "0x2102CE8", VA = "0x2102CE8", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x2102D30", Offset = "0x2102D30", VA = "0x2102D30", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x2102DA8", Offset = "0x2102DA8", VA = "0x2102DA8", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x2102FAC", Offset = "0x2102FAC", VA = "0x2102FAC")]
		public BuildRasterizedPath()
		{
		}
	}
	[Token(Token = "0x2000122")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AE444", Offset = "0x13AE444")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AE444", Offset = "0x13AE444")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF364", Offset = "0x13AF364")]
		private sealed class <>c
		{
			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<CGShape, int> <>9__152_0;

			[Token(Token = "0x6000B63")]
			[Address(RVA = "0x2105894", Offset = "0x2105894", VA = "0x2105894")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x210589C", Offset = "0x210589C", VA = "0x210589C")]
			internal int <Refresh>b__152_0(CGShape c)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B5204", Offset = "0x13B5204")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B52B8", Offset = "0x13B52B8")]
		public CGModuleInputSlot InCross;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B5378", Offset = "0x13B5378")]
		public CGModuleOutputSlot OutVolume;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B53EC", Offset = "0x13B53EC")]
		public CGModuleOutputSlot OutVolumeHollow;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B5460", Offset = "0x13B5460")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_Range;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B54EC", Offset = "0x13B54EC")]
		private int m_Resolution;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private bool m_Optimize;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B5568", Offset = "0x13B5568")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B5568", Offset = "0x13B5568")]
		private float m_AngleThreshold;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B5680", Offset = "0x13B5680")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x13B5680", Offset = "0x13B5680")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_CrossRange;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B5738", Offset = "0x13B5738")]
		private int m_CrossResolution;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B57C0", Offset = "0x13B57C0")]
		private bool m_CrossOptimize;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B5820", Offset = "0x13B5820")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B5820", Offset = "0x13B5820")]
		private float m_CrossAngleThreshold;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B5938", Offset = "0x13B5938")]
		private bool m_CrossIncludeControlpoints;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B5998", Offset = "0x13B5998")]
		private bool m_CrossHardEdges;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B59F8", Offset = "0x13B59F8")]
		private bool m_CrossMaterials;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B5A58", Offset = "0x13B5A58")]
		private bool m_CrossExtendedUV;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B5AB8", Offset = "0x13B5AB8")]
		private CrossShiftModeEnum m_CrossShiftMode;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B5B34", Offset = "0x13B5B34")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B5B34", Offset = "0x13B5B34")]
		private float m_CrossShiftValue;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B5C30", Offset = "0x13B5C30")]
		[SerializeField]
		private bool m_CrossReverseNormals;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B5C98", Offset = "0x13B5C98")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B5C98", Offset = "0x13B5C98")]
		[SerializeField]
		private ScaleModeEnum m_ScaleMode;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B5D24", Offset = "0x13B5D24")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B5D24", Offset = "0x13B5D24")]
		[SerializeField]
		private CGReferenceMode m_ScaleReference;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B5E10", Offset = "0x13B5E10")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B5E10", Offset = "0x13B5E10")]
		[SerializeField]
		private float m_ScaleOffset;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B5EFC", Offset = "0x13B5EFC")]
		private bool m_ScaleUniform;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float m_ScaleX;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B5F88", Offset = "0x13B5F88")]
		private float m_ScaleY;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B6038", Offset = "0x13B6038")]
		[AttributeAttribute(Name = "AnimationCurveExAttribute", RVA = "0x13B6038", Offset = "0x13B6038")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B6038", Offset = "0x13B6038")]
		private AnimationCurve m_ScaleCurveX;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B6148", Offset = "0x13B6148")]
		[AttributeAttribute(Name = "AnimationCurveExAttribute", RVA = "0x13B6148", Offset = "0x13B6148")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B6148", Offset = "0x13B6148")]
		private AnimationCurve m_ScaleCurveY;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B629C", Offset = "0x13B629C")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B629C", Offset = "0x13B629C")]
		[SerializeField]
		private float m_HollowInset;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B6354", Offset = "0x13B6354")]
		[SerializeField]
		private bool m_HollowReverseNormals;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B63BC", Offset = "0x13B63BC")]
		private int <PathSamples>k__BackingField;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B63CC", Offset = "0x13B63CC")]
		private int <CrossSamples>k__BackingField;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B63DC", Offset = "0x13B63DC")]
		private int <CrossGroups>k__BackingField;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B63EC", Offset = "0x13B63EC")]
		private Vector3 <CrossPosition>k__BackingField;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B63FC", Offset = "0x13B63FC")]
		private Quaternion <CrossRotation>k__BackingField;

		[Token(Token = "0x170001CF")]
		public float From
		{
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x2103068", Offset = "0x2103068", VA = "0x2103068")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600092C")]
			[Address(RVA = "0x2103070", Offset = "0x2103070", VA = "0x2103070")]
			set
			{
			}
		}

		[Token(Token = "0x170001D0")]
		public float To
		{
			[Token(Token = "0x600092D")]
			[Address(RVA = "0x2103108", Offset = "0x2103108", VA = "0x2103108")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x2103110", Offset = "0x2103110", VA = "0x2103110")]
			set
			{
			}
		}

		[Token(Token = "0x170001D1")]
		public float Length
		{
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x21032C8", Offset = "0x21032C8", VA = "0x21032C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x21032F8", Offset = "0x21032F8", VA = "0x21032F8")]
			set
			{
			}
		}

		[Token(Token = "0x170001D2")]
		public int Resolution
		{
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x210334C", Offset = "0x210334C", VA = "0x210334C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000932")]
			[Address(RVA = "0x2103354", Offset = "0x2103354", VA = "0x2103354")]
			set
			{
			}
		}

		[Token(Token = "0x170001D3")]
		public bool Optimize
		{
			[Token(Token = "0x6000933")]
			[Address(RVA = "0x21033F0", Offset = "0x21033F0", VA = "0x21033F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000934")]
			[Address(RVA = "0x21033F8", Offset = "0x21033F8", VA = "0x21033F8")]
			set
			{
			}
		}

		[Token(Token = "0x170001D4")]
		public float AngleThreshold
		{
			[Token(Token = "0x6000935")]
			[Address(RVA = "0x2103420", Offset = "0x2103420", VA = "0x2103420")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x2103428", Offset = "0x2103428", VA = "0x2103428")]
			set
			{
			}
		}

		[Token(Token = "0x170001D5")]
		public float CrossFrom
		{
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x21034CC", Offset = "0x21034CC", VA = "0x21034CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000938")]
			[Address(RVA = "0x21034D4", Offset = "0x21034D4", VA = "0x21034D4")]
			set
			{
			}
		}

		[Token(Token = "0x170001D6")]
		public float CrossTo
		{
			[Token(Token = "0x6000939")]
			[Address(RVA = "0x210356C", Offset = "0x210356C", VA = "0x210356C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600093A")]
			[Address(RVA = "0x2103574", Offset = "0x2103574", VA = "0x2103574")]
			set
			{
			}
		}

		[Token(Token = "0x170001D7")]
		public float CrossLength
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x210372C", Offset = "0x210372C", VA = "0x210372C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600093C")]
			[Address(RVA = "0x210375C", Offset = "0x210375C", VA = "0x210375C")]
			set
			{
			}
		}

		[Token(Token = "0x170001D8")]
		public int CrossResolution
		{
			[Token(Token = "0x600093D")]
			[Address(RVA = "0x21037B0", Offset = "0x21037B0", VA = "0x21037B0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600093E")]
			[Address(RVA = "0x21037B8", Offset = "0x21037B8", VA = "0x21037B8")]
			set
			{
			}
		}

		[Token(Token = "0x170001D9")]
		public bool CrossOptimize
		{
			[Token(Token = "0x600093F")]
			[Address(RVA = "0x2103854", Offset = "0x2103854", VA = "0x2103854")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000940")]
			[Address(RVA = "0x210385C", Offset = "0x210385C", VA = "0x210385C")]
			set
			{
			}
		}

		[Token(Token = "0x170001DA")]
		public float CrossAngleThreshold
		{
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x2103884", Offset = "0x2103884", VA = "0x2103884")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000942")]
			[Address(RVA = "0x210388C", Offset = "0x210388C", VA = "0x210388C")]
			set
			{
			}
		}

		[Token(Token = "0x170001DB")]
		public bool CrossIncludeControlPoints
		{
			[Token(Token = "0x6000943")]
			[Address(RVA = "0x2103930", Offset = "0x2103930", VA = "0x2103930")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x2103938", Offset = "0x2103938", VA = "0x2103938")]
			set
			{
			}
		}

		[Token(Token = "0x170001DC")]
		public bool CrossHardEdges
		{
			[Token(Token = "0x6000945")]
			[Address(RVA = "0x2103960", Offset = "0x2103960", VA = "0x2103960")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000946")]
			[Address(RVA = "0x2103968", Offset = "0x2103968", VA = "0x2103968")]
			set
			{
			}
		}

		[Token(Token = "0x170001DD")]
		public bool CrossMaterials
		{
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x2103990", Offset = "0x2103990", VA = "0x2103990")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000948")]
			[Address(RVA = "0x2103998", Offset = "0x2103998", VA = "0x2103998")]
			set
			{
			}
		}

		[Token(Token = "0x170001DE")]
		public bool CrossExtendedUV
		{
			[Token(Token = "0x6000949")]
			[Address(RVA = "0x21039C0", Offset = "0x21039C0", VA = "0x21039C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600094A")]
			[Address(RVA = "0x21039C8", Offset = "0x21039C8", VA = "0x21039C8")]
			set
			{
			}
		}

		[Token(Token = "0x170001DF")]
		public CrossShiftModeEnum CrossShiftMode
		{
			[Token(Token = "0x600094B")]
			[Address(RVA = "0x21039F0", Offset = "0x21039F0", VA = "0x21039F0")]
			get
			{
				return default(CrossShiftModeEnum);
			}
			[Token(Token = "0x600094C")]
			[Address(RVA = "0x21039F8", Offset = "0x21039F8", VA = "0x21039F8")]
			set
			{
			}
		}

		[Token(Token = "0x170001E0")]
		public float CrossShiftValue
		{
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x2103A14", Offset = "0x2103A14", VA = "0x2103A14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600094E")]
			[Address(RVA = "0x2103A1C", Offset = "0x2103A1C", VA = "0x2103A1C")]
			set
			{
			}
		}

		[Token(Token = "0x170001E1")]
		public bool CrossReverseNormals
		{
			[Token(Token = "0x600094F")]
			[Address(RVA = "0x2103AB4", Offset = "0x2103AB4", VA = "0x2103AB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000950")]
			[Address(RVA = "0x2103ABC", Offset = "0x2103ABC", VA = "0x2103ABC")]
			set
			{
			}
		}

		[Token(Token = "0x170001E2")]
		public ScaleModeEnum ScaleMode
		{
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x2103AE4", Offset = "0x2103AE4", VA = "0x2103AE4")]
			get
			{
				return default(ScaleModeEnum);
			}
			[Token(Token = "0x6000952")]
			[Address(RVA = "0x2103AEC", Offset = "0x2103AEC", VA = "0x2103AEC")]
			set
			{
			}
		}

		[Token(Token = "0x170001E3")]
		public CGReferenceMode ScaleReference
		{
			[Token(Token = "0x6000953")]
			[Address(RVA = "0x2103B08", Offset = "0x2103B08", VA = "0x2103B08")]
			get
			{
				return default(CGReferenceMode);
			}
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x2103B10", Offset = "0x2103B10", VA = "0x2103B10")]
			set
			{
			}
		}

		[Token(Token = "0x170001E4")]
		public bool ScaleUniform
		{
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x2103B2C", Offset = "0x2103B2C", VA = "0x2103B2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x2103B34", Offset = "0x2103B34", VA = "0x2103B34")]
			set
			{
			}
		}

		[Token(Token = "0x170001E5")]
		public float ScaleOffset
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x2103B5C", Offset = "0x2103B5C", VA = "0x2103B5C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x2103B64", Offset = "0x2103B64", VA = "0x2103B64")]
			set
			{
			}
		}

		[Token(Token = "0x170001E6")]
		public float ScaleX
		{
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x2103B80", Offset = "0x2103B80", VA = "0x2103B80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x2103B88", Offset = "0x2103B88", VA = "0x2103B88")]
			set
			{
			}
		}

		[Token(Token = "0x170001E7")]
		public float ScaleY
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x2103BA4", Offset = "0x2103BA4", VA = "0x2103BA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600095C")]
			[Address(RVA = "0x2103BAC", Offset = "0x2103BAC", VA = "0x2103BAC")]
			set
			{
			}
		}

		[Token(Token = "0x170001E8")]
		public AnimationCurve ScaleMultiplierX
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x2103BC8", Offset = "0x2103BC8", VA = "0x2103BC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x2103BD0", Offset = "0x2103BD0", VA = "0x2103BD0")]
			set
			{
			}
		}

		[Token(Token = "0x170001E9")]
		public AnimationCurve ScaleMultiplierY
		{
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x2103C10", Offset = "0x2103C10", VA = "0x2103C10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x2103C18", Offset = "0x2103C18", VA = "0x2103C18")]
			set
			{
			}
		}

		[Token(Token = "0x170001EA")]
		public float HollowInset
		{
			[Token(Token = "0x6000961")]
			[Address(RVA = "0x2103C58", Offset = "0x2103C58", VA = "0x2103C58")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x2103C60", Offset = "0x2103C60", VA = "0x2103C60")]
			set
			{
			}
		}

		[Token(Token = "0x170001EB")]
		public bool HollowReverseNormals
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x2103CF4", Offset = "0x2103CF4", VA = "0x2103CF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000964")]
			[Address(RVA = "0x2103CFC", Offset = "0x2103CFC", VA = "0x2103CFC")]
			set
			{
			}
		}

		[Token(Token = "0x170001EC")]
		public int PathSamples
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x2103D24", Offset = "0x2103D24", VA = "0x2103D24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB2D0", Offset = "0x13BB2D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000966")]
			[Address(RVA = "0x2103D2C", Offset = "0x2103D2C", VA = "0x2103D2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB2E0", Offset = "0x13BB2E0")]
			private set
			{
			}
		}

		[Token(Token = "0x170001ED")]
		public int CrossSamples
		{
			[Token(Token = "0x6000967")]
			[Address(RVA = "0x2103D34", Offset = "0x2103D34", VA = "0x2103D34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB2F0", Offset = "0x13BB2F0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000968")]
			[Address(RVA = "0x2103D3C", Offset = "0x2103D3C", VA = "0x2103D3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB300", Offset = "0x13BB300")]
			private set
			{
			}
		}

		[Token(Token = "0x170001EE")]
		public int CrossGroups
		{
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x2103D44", Offset = "0x2103D44", VA = "0x2103D44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB310", Offset = "0x13BB310")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x2103D4C", Offset = "0x2103D4C", VA = "0x2103D4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB320", Offset = "0x13BB320")]
			private set
			{
			}
		}

		[Token(Token = "0x170001EF")]
		public IExternalInput Cross
		{
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x2103D54", Offset = "0x2103D54", VA = "0x2103D54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F0")]
		public Vector3 CrossPosition
		{
			[Token(Token = "0x600096C")]
			[Address(RVA = "0x2103DB0", Offset = "0x2103DB0", VA = "0x2103DB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB330", Offset = "0x13BB330")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x2103DC0", Offset = "0x2103DC0", VA = "0x2103DC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB340", Offset = "0x13BB340")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001F1")]
		public Quaternion CrossRotation
		{
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x2103DD0", Offset = "0x2103DD0", VA = "0x2103DD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB350", Offset = "0x13BB350")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x2103DE4", Offset = "0x2103DE4", VA = "0x2103DE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB360", Offset = "0x13BB360")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001F2")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x2103DF8", Offset = "0x2103DF8", VA = "0x2103DF8", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001F3")]
		private bool ClampPath
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x21031D0", Offset = "0x21031D0", VA = "0x21031D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001F4")]
		private bool ClampCross
		{
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x2103634", Offset = "0x2103634", VA = "0x2103634")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001F5")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x2103EC8", Offset = "0x2103EC8", VA = "0x2103EC8")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x170001F6")]
		private RegionOptions<float> CrossRangeOptions
		{
			[Token(Token = "0x6000974")]
			[Address(RVA = "0x2103FCC", Offset = "0x2103FCC", VA = "0x2103FCC")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x21040D0", Offset = "0x21040D0", VA = "0x21040D0", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x2104118", Offset = "0x2104118", VA = "0x2104118", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x21043D0", Offset = "0x21043D0", VA = "0x21043D0", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x2105590", Offset = "0x2105590", VA = "0x2105590")]
		public Vector3 GetScale(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x21054CC", Offset = "0x21054CC", VA = "0x21054CC")]
		private void getScaleInternal(float f, Vector3 baseScale, ref Vector3 scale)
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x2105690", Offset = "0x2105690", VA = "0x2105690")]
		public BuildShapeExtrusion()
		{
		}
	}
	[Token(Token = "0x2000123")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AE4DC", Offset = "0x13AE4DC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AE4DC", Offset = "0x13AE4DC")]
	public class BuildVolumeCaps : CGModule
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B640C", Offset = "0x13B640C")]
		public CGModuleInputSlot InVolume;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B64A8", Offset = "0x13B64A8")]
		public CGModuleInputSlot InVolumeHoles;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B6560", Offset = "0x13B6560")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B65E0", Offset = "0x13B65E0")]
		[SerializeField]
		private CGYesNoAuto m_StartCap;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private CGYesNoAuto m_EndCap;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B663C", Offset = "0x13B663C")]
		private bool m_ReverseTriOrder;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		[SerializeField]
		private bool m_GenerateUV;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B6698", Offset = "0x13B6698")]
		[Inline]
		[SerializeField]
		private CGMaterialSettings m_StartMaterialSettings;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B66F4", Offset = "0x13B66F4")]
		[SerializeField]
		private Material m_StartMaterial;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B675C", Offset = "0x13B675C")]
		[SerializeField]
		private bool m_CloneStartCap;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "AsGroupAttribute", RVA = "0x13B67A8", Offset = "0x13B67A8")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x13B67A8", Offset = "0x13B67A8")]
		[SerializeField]
		private CGMaterialSettings m_EndMaterialSettings;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x13B686C", Offset = "0x13B686C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B686C", Offset = "0x13B686C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B686C", Offset = "0x13B686C")]
		[SerializeField]
		private Material m_EndMaterial;

		[Token(Token = "0x170001F7")]
		public bool GenerateUV
		{
			[Token(Token = "0x600097B")]
			[Address(RVA = "0x21058BC", Offset = "0x21058BC", VA = "0x21058BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600097C")]
			[Address(RVA = "0x21058C4", Offset = "0x21058C4", VA = "0x21058C4")]
			set
			{
			}
		}

		[Token(Token = "0x170001F8")]
		public bool ReverseTriOrder
		{
			[Token(Token = "0x600097D")]
			[Address(RVA = "0x21058EC", Offset = "0x21058EC", VA = "0x21058EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600097E")]
			[Address(RVA = "0x21058F4", Offset = "0x21058F4", VA = "0x21058F4")]
			set
			{
			}
		}

		[Token(Token = "0x170001F9")]
		public CGYesNoAuto StartCap
		{
			[Token(Token = "0x600097F")]
			[Address(RVA = "0x210591C", Offset = "0x210591C", VA = "0x210591C")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000980")]
			[Address(RVA = "0x2105924", Offset = "0x2105924", VA = "0x2105924")]
			set
			{
			}
		}

		[Token(Token = "0x170001FA")]
		public Material StartMaterial
		{
			[Token(Token = "0x6000981")]
			[Address(RVA = "0x2105940", Offset = "0x2105940", VA = "0x2105940")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000982")]
			[Address(RVA = "0x2105948", Offset = "0x2105948", VA = "0x2105948")]
			set
			{
			}
		}

		[Token(Token = "0x170001FB")]
		public CGMaterialSettings StartMaterialSettings
		{
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x21059EC", Offset = "0x21059EC", VA = "0x21059EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FC")]
		public CGYesNoAuto EndCap
		{
			[Token(Token = "0x6000984")]
			[Address(RVA = "0x21059F4", Offset = "0x21059F4", VA = "0x21059F4")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000985")]
			[Address(RVA = "0x21059FC", Offset = "0x21059FC", VA = "0x21059FC")]
			set
			{
			}
		}

		[Token(Token = "0x170001FD")]
		public bool CloneStartCap
		{
			[Token(Token = "0x6000986")]
			[Address(RVA = "0x2105A18", Offset = "0x2105A18", VA = "0x2105A18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000987")]
			[Address(RVA = "0x2105A20", Offset = "0x2105A20", VA = "0x2105A20")]
			set
			{
			}
		}

		[Token(Token = "0x170001FE")]
		public CGMaterialSettings EndMaterialSettings
		{
			[Token(Token = "0x6000988")]
			[Address(RVA = "0x2105A48", Offset = "0x2105A48", VA = "0x2105A48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FF")]
		public Material EndMaterial
		{
			[Token(Token = "0x6000989")]
			[Address(RVA = "0x2105A50", Offset = "0x2105A50", VA = "0x2105A50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600098A")]
			[Address(RVA = "0x2105A58", Offset = "0x2105A58", VA = "0x2105A58")]
			set
			{
			}
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x2105AFC", Offset = "0x2105AFC", VA = "0x2105AFC", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x2105BEC", Offset = "0x2105BEC", VA = "0x2105BEC", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x2105D58", Offset = "0x2105D58", VA = "0x2105D58", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x2106948", Offset = "0x2106948", VA = "0x2106948")]
		private static Matrix4x4 getMatrix(CGVolume vol, int index, bool inverse)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x2106EC0", Offset = "0x2106EC0", VA = "0x2106EC0")]
		private static void flipTris(ref int[] indices, int start, int end)
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x2106C3C", Offset = "0x2106C3C", VA = "0x2106C3C")]
		private static Vector3[] applyMatrix(Vector3[] vt, Matrix4x4 matrix, out Bounds bounds)
		{
			return null;
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x21067C0", Offset = "0x21067C0", VA = "0x21067C0")]
		private static ContourVertex[] make2DSegment(CGVolume vol, int index)
		{
			return null;
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x2106F48", Offset = "0x2106F48", VA = "0x2106F48")]
		private static void applyUV(Vector3[] vts, ref Vector2[] uvArray, int index, int count, CGMaterialSettings mat, Bounds bounds)
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x2107264", Offset = "0x2107264", VA = "0x2107264")]
		public BuildVolumeCaps()
		{
		}
	}
	[Token(Token = "0x2000124")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AE574", Offset = "0x13AE574")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AE574", Offset = "0x13AE574")]
	public class BuildVolumeMesh : CGModule
	{
		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B6978", Offset = "0x13B6978")]
		public CGModuleInputSlot InVolume;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B6A14", Offset = "0x13B6A14")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B6A94", Offset = "0x13B6A94")]
		[SerializeField]
		private bool m_GenerateUV;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		[SerializeField]
		private bool m_Split;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B6AF0", Offset = "0x13B6AF0")]
		[SerializeField]
		private float m_SplitLength;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x13B6BC0", Offset = "0x13B6BC0")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B6BC0", Offset = "0x13B6BC0")]
		private bool m_ReverseTriOrder;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[HideInInspector]
		private List<CGMaterialSettingsEx> m_MaterialSettings;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[HideInInspector]
		private Material[] m_Material;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<SamplePointsMaterialGroupCollection> groupsByMatID;

		[Token(Token = "0x17000200")]
		public bool GenerateUV
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0x2107394", Offset = "0x2107394", VA = "0x2107394")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000995")]
			[Address(RVA = "0x210739C", Offset = "0x210739C", VA = "0x210739C")]
			set
			{
			}
		}

		[Token(Token = "0x17000201")]
		public bool ReverseTriOrder
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0x21073C4", Offset = "0x21073C4", VA = "0x21073C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000997")]
			[Address(RVA = "0x21073CC", Offset = "0x21073CC", VA = "0x21073CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000202")]
		public bool Split
		{
			[Token(Token = "0x6000998")]
			[Address(RVA = "0x21073F4", Offset = "0x21073F4", VA = "0x21073F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x21073FC", Offset = "0x21073FC", VA = "0x21073FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000203")]
		public float SplitLength
		{
			[Token(Token = "0x600099A")]
			[Address(RVA = "0x2107424", Offset = "0x2107424", VA = "0x2107424")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600099B")]
			[Address(RVA = "0x210742C", Offset = "0x210742C", VA = "0x210742C")]
			set
			{
			}
		}

		[Token(Token = "0x17000204")]
		public List<CGMaterialSettingsEx> MaterialSetttings
		{
			[Token(Token = "0x600099C")]
			[Address(RVA = "0x21074C4", Offset = "0x21074C4", VA = "0x21074C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000205")]
		public int MaterialCount
		{
			[Token(Token = "0x600099D")]
			[Address(RVA = "0x21074CC", Offset = "0x21074CC", VA = "0x21074CC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x210751C", Offset = "0x210751C", VA = "0x210751C", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x2107630", Offset = "0x2107630", VA = "0x2107630", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x2107810", Offset = "0x2107810", VA = "0x2107810", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x210755C", Offset = "0x210755C", VA = "0x210755C")]
		public int AddMaterial()
		{
			return default(int);
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x21080B8", Offset = "0x21080B8", VA = "0x21080B8")]
		public void RemoveMaterial(int index)
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x2108224", Offset = "0x2108224", VA = "0x2108224")]
		public void SetMaterial(int index, Material mat)
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x21083A0", Offset = "0x21083A0", VA = "0x21083A0")]
		public Material GetMaterial(int index)
		{
			return null;
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x2107CD4", Offset = "0x2107CD4", VA = "0x2107CD4")]
		private void prepare(CGVolume vol)
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x2107D00", Offset = "0x2107D00", VA = "0x2107D00")]
		private void build(CGVMesh vmesh, CGVolume vol, IntRegion subset)
		{
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x2108720", Offset = "0x2108720", VA = "0x2108720")]
		private static void prepareSubMeshes(CGVMesh vmesh, List<SamplePointsMaterialGroupCollection> groupsBySubMeshes, int extrusions, ref Material[] materials)
		{
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x2108908", Offset = "0x2108908", VA = "0x2108908")]
		private void createMaterialGroupUV(CGVMesh vmesh, CGVolume vol, SamplePointsMaterialGroup grp, int matIndex, float grpAspectCorrection, int sample, int baseVertex)
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x2108AAC", Offset = "0x2108AAC", VA = "0x2108AAC")]
		private static int createPatchTriangles(ref int[] triangles, ref int triIdx, int curVTIndex, int patchSize, int crossSize, bool reverse)
		{
			return default(int);
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x21083FC", Offset = "0x21083FC", VA = "0x21083FC")]
		private List<SamplePointsMaterialGroupCollection> getMaterialIDGroups(CGVolume volume)
		{
			return null;
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x210817C", Offset = "0x210817C", VA = "0x210817C")]
		private bool validateMaterialIndex(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x2108C08", Offset = "0x2108C08", VA = "0x2108C08")]
		public BuildVolumeMesh()
		{
		}
	}
	[Token(Token = "0x2000125")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AE60C", Offset = "0x13AE60C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AE60C", Offset = "0x13AE60C")]
	public class BuildVolumeSpots : CGModule
	{
		[Token(Token = "0x2000183")]
		private class GroupSet
		{
			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CGBoundsGroup Group;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float Length;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<int> Items;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<float> Distances;

			[Token(Token = "0x6000B65")]
			[Address(RVA = "0x210B324", Offset = "0x210B324", VA = "0x210B324")]
			public GroupSet()
			{
			}
		}

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B6CA4", Offset = "0x13B6CA4")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B6D7C", Offset = "0x13B6D7C")]
		public CGModuleInputSlot InBounds;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B6E30", Offset = "0x13B6E30")]
		public CGModuleOutputSlot OutSpots;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B6EA4", Offset = "0x13B6EA4")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_Range;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B6F28", Offset = "0x13B6F28")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B6F28", Offset = "0x13B6F28")]
		[SerializeField]
		private bool m_UseVolume;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B6FAC", Offset = "0x13B6FAC")]
		[SerializeField]
		private bool m_Simulate;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x13B6FF8", Offset = "0x13B6FF8")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B6FF8", Offset = "0x13B6FF8")]
		private float m_CrossBase;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private AnimationCurve m_CrossCurve;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B70A8", Offset = "0x13B70A8")]
		[ArrayEx]
		[SerializeField]
		private List<CGBoundsGroup> m_Groups;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[IntRegion]
		[SerializeField]
		private IntRegion m_RepeatingGroups;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private CurvyRepeatingOrderEnum m_RepeatingOrder;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool m_FitEnd;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7194", Offset = "0x13B7194")]
		private int <Count>k__BackingField;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public CGSpots SimulatedSpots;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private WeightedRandom<int> mGroupBag;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private List<CGBounds> mBounds;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B71A4", Offset = "0x13B71A4")]
		private CGPath <Path>k__BackingField;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B71B4", Offset = "0x13B71B4")]
		private float <StartDistance>k__BackingField;

		[Token(Token = "0x17000206")]
		public FloatRegion Range
		{
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x2108D10", Offset = "0x2108D10", VA = "0x2108D10")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x2108D20", Offset = "0x2108D20", VA = "0x2108D20")]
			set
			{
			}
		}

		[Token(Token = "0x17000207")]
		public bool UseVolume
		{
			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x2108D7C", Offset = "0x2108D7C", VA = "0x2108D7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x2108D84", Offset = "0x2108D84", VA = "0x2108D84")]
			set
			{
			}
		}

		[Token(Token = "0x17000208")]
		public bool Simulate
		{
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x2108DAC", Offset = "0x2108DAC", VA = "0x2108DAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x2108DB4", Offset = "0x2108DB4", VA = "0x2108DB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000209")]
		public float CrossBase
		{
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x2108DDC", Offset = "0x2108DDC", VA = "0x2108DDC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x2108DE4", Offset = "0x2108DE4", VA = "0x2108DE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700020A")]
		public AnimationCurve CrossCurve
		{
			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x2108E7C", Offset = "0x2108E7C", VA = "0x2108E7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x2108E84", Offset = "0x2108E84", VA = "0x2108E84")]
			set
			{
			}
		}

		[Token(Token = "0x1700020B")]
		public List<CGBoundsGroup> Groups
		{
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x2108EC0", Offset = "0x2108EC0", VA = "0x2108EC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x2108EC8", Offset = "0x2108EC8", VA = "0x2108EC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700020C")]
		public CurvyRepeatingOrderEnum RepeatingOrder
		{
			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x2108EE0", Offset = "0x2108EE0", VA = "0x2108EE0")]
			get
			{
				return default(CurvyRepeatingOrderEnum);
			}
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x2108EE8", Offset = "0x2108EE8", VA = "0x2108EE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700020D")]
		public int FirstRepeating
		{
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x2108F04", Offset = "0x2108F04", VA = "0x2108F04")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x2108F0C", Offset = "0x2108F0C", VA = "0x2108F0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700020E")]
		public int LastRepeating
		{
			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x2109018", Offset = "0x2109018", VA = "0x2109018")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x2109020", Offset = "0x2109020", VA = "0x2109020")]
			set
			{
			}
		}

		[Token(Token = "0x1700020F")]
		public bool FitEnd
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x21090E0", Offset = "0x21090E0", VA = "0x21090E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x21090E8", Offset = "0x21090E8", VA = "0x21090E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000210")]
		public int GroupCount
		{
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x2108FC8", Offset = "0x2108FC8", VA = "0x2108FC8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000211")]
		public GUIContent[] BoundsNames
		{
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x2109110", Offset = "0x2109110", VA = "0x2109110")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000212")]
		public int[] BoundsIndices
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x21092FC", Offset = "0x21092FC", VA = "0x21092FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000213")]
		public int Count
		{
			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x21093B8", Offset = "0x21093B8", VA = "0x21093B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB370", Offset = "0x13BB370")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x21093C0", Offset = "0x21093C0", VA = "0x21093C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB380", Offset = "0x13BB380")]
			private set
			{
			}
		}

		[Token(Token = "0x17000214")]
		private int lastGroupIndex
		{
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x21093C8", Offset = "0x21093C8", VA = "0x21093C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000215")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x2109444", Offset = "0x2109444", VA = "0x2109444")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x17000216")]
		private RegionOptions<int> RepeatingGroupsOptions
		{
			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x210949C", Offset = "0x210949C", VA = "0x210949C")]
			get
			{
				return default(RegionOptions<int>);
			}
		}

		[Token(Token = "0x17000217")]
		private CGPath Path
		{
			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x2109540", Offset = "0x2109540", VA = "0x2109540")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB390", Offset = "0x13BB390")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x2109548", Offset = "0x2109548", VA = "0x2109548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB3A0", Offset = "0x13BB3A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000218")]
		private CGVolume Volume
		{
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x2109558", Offset = "0x2109558", VA = "0x2109558")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000219")]
		private float Length
		{
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x21095DC", Offset = "0x21095DC", VA = "0x21095DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700021A")]
		private float StartDistance
		{
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x2109618", Offset = "0x2109618", VA = "0x2109618")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB3B0", Offset = "0x13BB3B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x2109620", Offset = "0x2109620", VA = "0x2109620")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB3C0", Offset = "0x13BB3C0")]
			set
			{
			}
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x2109628", Offset = "0x2109628", VA = "0x2109628", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x2109660", Offset = "0x2109660", VA = "0x2109660", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x2109888", Offset = "0x2109888", VA = "0x2109888", Slot = "13")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x21098D0", Offset = "0x21098D0", VA = "0x21098D0")]
		public void Clear()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x21099C4", Offset = "0x21099C4", VA = "0x21099C4", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x21097A8", Offset = "0x21097A8", VA = "0x21097A8")]
		public CGBoundsGroup AddGroup(string name)
		{
			return null;
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x210B224", Offset = "0x210B224", VA = "0x210B224")]
		public void RemoveGroup(CGBoundsGroup group)
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x210A83C", Offset = "0x210A83C", VA = "0x210A83C")]
		private GroupSet addGroupItems(CGBoundsGroup group, ref List<CGSpot> spots, ref float remainingLength, ref float currentDistance, bool calcLengthOnly = false)
		{
			return null;
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x210AFE8", Offset = "0x210AFE8", VA = "0x210AFE8")]
		private void rebase(ref List<CGSpot> spots, ref List<GroupSet> sets, float currentDistance)
		{
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x210B3D4", Offset = "0x210B3D4", VA = "0x210B3D4")]
		private CGSpot getSpot(int itemID, ref CGBoundsGroup group, ref CGBounds bounds, float startDist)
		{
			return default(CGSpot);
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x210A6DC", Offset = "0x210A6DC", VA = "0x210A6DC")]
		private void prepare()
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x210B29C", Offset = "0x210B29C", VA = "0x210B29C")]
		private CGBounds getItemBounds(int itemIndex)
		{
			return null;
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x210B888", Offset = "0x210B888", VA = "0x210B888")]
		private float getCrossValue(float globalF, CGBoundsGroup group)
		{
			return default(float);
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x210B95C", Offset = "0x210B95C", VA = "0x210B95C")]
		public BuildVolumeSpots()
		{
		}
	}
	[Token(Token = "0x2000126")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AE6AC", Offset = "0x13AE6AC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AE6AC", Offset = "0x13AE6AC")]
	public class ConformPath : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B71C4", Offset = "0x13B71C4")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B7294", Offset = "0x13B7294")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x13B7308", Offset = "0x13B7308")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B7308", Offset = "0x13B7308")]
		private Vector3 m_Direction;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B7394", Offset = "0x13B7394")]
		private float m_MaxDistance;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B73E0", Offset = "0x13B73E0")]
		private float m_Offset;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B742C", Offset = "0x13B742C")]
		private bool m_Warp;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B7478", Offset = "0x13B7478")]
		private LayerMask m_LayerMask;

		[Token(Token = "0x1700021B")]
		public Vector3 Direction
		{
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x210BA9C", Offset = "0x210BA9C", VA = "0x210BA9C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x210BAA8", Offset = "0x210BAA8", VA = "0x210BAA8")]
			set
			{
			}
		}

		[Token(Token = "0x1700021C")]
		public float MaxDistance
		{
			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x210BB6C", Offset = "0x210BB6C", VA = "0x210BB6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x210BB74", Offset = "0x210BB74", VA = "0x210BB74")]
			set
			{
			}
		}

		[Token(Token = "0x1700021D")]
		public float Offset
		{
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x210BB90", Offset = "0x210BB90", VA = "0x210BB90")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x210BB98", Offset = "0x210BB98", VA = "0x210BB98")]
			set
			{
			}
		}

		[Token(Token = "0x1700021E")]
		public bool Warp
		{
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x210BBB4", Offset = "0x210BBB4", VA = "0x210BBB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x210BBBC", Offset = "0x210BBBC", VA = "0x210BBBC")]
			set
			{
			}
		}

		[Token(Token = "0x1700021F")]
		public LayerMask LayerMask
		{
			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x210BBE4", Offset = "0x210BBE4", VA = "0x210BBE4")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x210BBEC", Offset = "0x210BBEC", VA = "0x210BBEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000220")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BBB98", Offset = "0x13BBB98")]
		public float PathLength
		{
			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x210BD5C", Offset = "0x210BD5C", VA = "0x210BD5C", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000221")]
		public bool PathIsClosed
		{
			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x210BE88", Offset = "0x210BE88", VA = "0x210BE88", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x210BC48", Offset = "0x210BC48", VA = "0x210BC48", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x210BC80", Offset = "0x210BC80", VA = "0x210BC80", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x210BF7C", Offset = "0x210BF7C", VA = "0x210BF7C", Slot = "16")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x210C0E4", Offset = "0x210C0E4", VA = "0x210C0E4")]
		public static CGPath Conform(Transform pathTransform, CGPath path, LayerMask layers, Vector3 projectionDirection, float offset, float rayLength, bool warp)
		{
			return null;
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x210C4F4", Offset = "0x210C4F4", VA = "0x210C4F4")]
		public ConformPath()
		{
		}
	}
	[Token(Token = "0x2000127")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AE744", Offset = "0x13AE744")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AE744", Offset = "0x13AE744")]
	public class CreateGameObject : CGModule
	{
		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B74C4", Offset = "0x13B74C4")]
		public CGModuleInputSlot InGameObjectArray;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B7590", Offset = "0x13B7590")]
		public CGModuleInputSlot InSpots;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceCollectionManagerAttribute", RVA = "0x13B764C", Offset = "0x13B764C")]
		private CGGameObjectResourceCollection m_Resources;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B76A4", Offset = "0x13B76A4")]
		[SerializeField]
		private bool m_MakeStatic;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "LayerAttribute", RVA = "0x13B76F0", Offset = "0x13B76F0")]
		private int m_Layer;

		[Token(Token = "0x17000222")]
		public int Layer
		{
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x210C5D4", Offset = "0x210C5D4", VA = "0x210C5D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x210C5DC", Offset = "0x210C5DC", VA = "0x210C5DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000223")]
		public bool MakeStatic
		{
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x210C678", Offset = "0x210C678", VA = "0x210C678")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x210C680", Offset = "0x210C680", VA = "0x210C680")]
			set
			{
			}
		}

		[Token(Token = "0x17000224")]
		public CGGameObjectResourceCollection GameObjects
		{
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x210C6A8", Offset = "0x210C6A8", VA = "0x210C6A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000225")]
		public int GameObjectCount
		{
			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x210C6B0", Offset = "0x210C6B0", VA = "0x210C6B0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x210C6CC", Offset = "0x210C6CC", VA = "0x210C6CC", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x210C84C", Offset = "0x210C84C", VA = "0x210C84C", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x210C890", Offset = "0x210C890", VA = "0x210C890", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x210C71C", Offset = "0x210C71C", VA = "0x210C71C")]
		public void Clear()
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x210C894", Offset = "0x210C894", VA = "0x210C894", Slot = "13")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x210C8DC", Offset = "0x210C8DC", VA = "0x210C8DC", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x210D0F8", Offset = "0x210D0F8", VA = "0x210D0F8")]
		public CreateGameObject()
		{
		}
	}
	[Token(Token = "0x2000128")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AE7C0", Offset = "0x13AE7C0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AE7C0", Offset = "0x13AE7C0")]
	public class CreateMesh : CGModule
	{
		[Serializable]
		[Token(Token = "0x2000184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF374", Offset = "0x13AF374")]
		private sealed class <>c
		{
			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<CGSpot> <>9__107_0;

			[Token(Token = "0x6000B67")]
			[Address(RVA = "0x2903278", Offset = "0x2903278", VA = "0x2903278")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B68")]
			[Address(RVA = "0x2903280", Offset = "0x2903280", VA = "0x2903280")]
			internal int <createSpotMeshes>b__107_0(CGSpot a, CGSpot b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000494")]
		private const string DefaultTag = "Untagged";

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B7758", Offset = "0x13B7758")]
		public CGModuleInputSlot InVMeshArray;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B7824", Offset = "0x13B7824")]
		public CGModuleInputSlot InSpots;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceCollectionManagerAttribute", RVA = "0x13B78F4", Offset = "0x13B78F4")]
		private CGMeshResourceCollection m_MeshResources;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B794C", Offset = "0x13B794C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B794C", Offset = "0x13B794C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B794C", Offset = "0x13B794C")]
		[SerializeField]
		private bool m_Combine;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B7A50", Offset = "0x13B7A50")]
		[SerializeField]
		private bool m_GroupMeshes;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B7A9C", Offset = "0x13B7A9C")]
		private CGYesNoAuto m_AddNormals;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B7B58", Offset = "0x13B7B58")]
		private CGYesNoAuto m_AddTangents;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B7C14", Offset = "0x13B7C14")]
		private bool m_AddUV2;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B7CD0", Offset = "0x13B7CD0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B7CD0", Offset = "0x13B7CD0")]
		private bool m_MakeStatic;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B7DB0", Offset = "0x13B7DB0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B7DB0", Offset = "0x13B7DB0")]
		[AttributeAttribute(Name = "LayerAttribute", RVA = "0x13B7DB0", Offset = "0x13B7DB0")]
		private int m_Layer;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B7EC8", Offset = "0x13B7EC8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B7EC8", Offset = "0x13B7EC8")]
		[AttributeAttribute(Name = "TagAttribute", RVA = "0x13B7EC8", Offset = "0x13B7EC8")]
		private string m_Tag;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B7FE0", Offset = "0x13B7FE0")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B7FE0", Offset = "0x13B7FE0")]
		private bool m_RendererEnabled;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B80C0", Offset = "0x13B80C0")]
		private ShadowCastingMode m_CastShadows;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B817C", Offset = "0x13B817C")]
		private bool m_ReceiveShadows;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B8238", Offset = "0x13B8238")]
		private LightProbeUsage m_LightProbeUsage;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B82F4", Offset = "0x13B82F4")]
		private bool m_UseLightProbes;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B83C0", Offset = "0x13B83C0")]
		private ReflectionProbeUsage m_ReflectionProbes;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B847C", Offset = "0x13B847C")]
		private Transform m_AnchorOverride;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B8538", Offset = "0x13B8538")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B8538", Offset = "0x13B8538")]
		private CGColliderEnum m_Collider;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B8618", Offset = "0x13B8618")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B8618", Offset = "0x13B8618")]
		private bool m_Convex;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B8734", Offset = "0x13B8734")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B8734", Offset = "0x13B8734")]
		[SerializeField]
		[AttributeAttribute(Name = "EnumFlagAttribute", RVA = "0x13B8734", Offset = "0x13B8734")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B8734", Offset = "0x13B8734")]
		private MeshColliderCookingOptions m_CookingOptions;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B88AC", Offset = "0x13B88AC")]
		[SerializeField]
		private bool m_AutoUpdateColliders;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private PhysicMaterial m_Material;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B8924", Offset = "0x13B8924")]
		private int <VertexCount>k__BackingField;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int mCurrentMeshCount;

		[Token(Token = "0x17000226")]
		public bool Combine
		{
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x210D1C4", Offset = "0x210D1C4", VA = "0x210D1C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x210D1CC", Offset = "0x210D1CC", VA = "0x210D1CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000227")]
		public bool GroupMeshes
		{
			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x210D1F4", Offset = "0x210D1F4", VA = "0x210D1F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x210D1FC", Offset = "0x210D1FC", VA = "0x210D1FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000228")]
		public CGYesNoAuto AddNormals
		{
			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x210D224", Offset = "0x210D224", VA = "0x210D224")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x210D22C", Offset = "0x210D22C", VA = "0x210D22C")]
			set
			{
			}
		}

		[Token(Token = "0x17000229")]
		public CGYesNoAuto AddTangents
		{
			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x210D248", Offset = "0x210D248", VA = "0x210D248")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x210D250", Offset = "0x210D250", VA = "0x210D250")]
			set
			{
			}
		}

		[Token(Token = "0x1700022A")]
		public bool AddUV2
		{
			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x210D26C", Offset = "0x210D26C", VA = "0x210D26C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x210D274", Offset = "0x210D274", VA = "0x210D274")]
			set
			{
			}
		}

		[Token(Token = "0x1700022B")]
		public int Layer
		{
			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x210D29C", Offset = "0x210D29C", VA = "0x210D29C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x210D2A4", Offset = "0x210D2A4", VA = "0x210D2A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700022C")]
		public string Tag
		{
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x210D340", Offset = "0x210D340", VA = "0x210D340")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x210D348", Offset = "0x210D348", VA = "0x210D348")]
			set
			{
			}
		}

		[Token(Token = "0x1700022D")]
		public bool MakeStatic
		{
			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x210D3A0", Offset = "0x210D3A0", VA = "0x210D3A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x210D3A8", Offset = "0x210D3A8", VA = "0x210D3A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700022E")]
		public bool RendererEnabled
		{
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x210D3D0", Offset = "0x210D3D0", VA = "0x210D3D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x210D3D8", Offset = "0x210D3D8", VA = "0x210D3D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700022F")]
		public ShadowCastingMode CastShadows
		{
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x210D400", Offset = "0x210D400", VA = "0x210D400")]
			get
			{
				return default(ShadowCastingMode);
			}
			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x210D408", Offset = "0x210D408", VA = "0x210D408")]
			set
			{
			}
		}

		[Token(Token = "0x17000230")]
		public bool ReceiveShadows
		{
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x210D424", Offset = "0x210D424", VA = "0x210D424")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x210D42C", Offset = "0x210D42C", VA = "0x210D42C")]
			set
			{
			}
		}

		[Token(Token = "0x17000231")]
		public bool UseLightProbes
		{
			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x210D454", Offset = "0x210D454", VA = "0x210D454")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x210D45C", Offset = "0x210D45C", VA = "0x210D45C")]
			set
			{
			}
		}

		[Token(Token = "0x17000232")]
		public LightProbeUsage LightProbeUsage
		{
			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x210D484", Offset = "0x210D484", VA = "0x210D484")]
			get
			{
				return default(LightProbeUsage);
			}
			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x210D48C", Offset = "0x210D48C", VA = "0x210D48C")]
			set
			{
			}
		}

		[Token(Token = "0x17000233")]
		public ReflectionProbeUsage ReflectionProbes
		{
			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x210D4A8", Offset = "0x210D4A8", VA = "0x210D4A8")]
			get
			{
				return default(ReflectionProbeUsage);
			}
			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x210D4B0", Offset = "0x210D4B0", VA = "0x210D4B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000234")]
		public Transform AnchorOverride
		{
			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x210D4CC", Offset = "0x210D4CC", VA = "0x210D4CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x210D4D4", Offset = "0x210D4D4", VA = "0x210D4D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000235")]
		public CGColliderEnum Collider
		{
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x210D578", Offset = "0x210D578", VA = "0x210D578")]
			get
			{
				return default(CGColliderEnum);
			}
			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x210D580", Offset = "0x210D580", VA = "0x210D580")]
			set
			{
			}
		}

		[Token(Token = "0x17000236")]
		public bool AutoUpdateColliders
		{
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x210D59C", Offset = "0x210D59C", VA = "0x210D59C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x210D5A4", Offset = "0x210D5A4", VA = "0x210D5A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000237")]
		public bool Convex
		{
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x210D5CC", Offset = "0x210D5CC", VA = "0x210D5CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x210D5D4", Offset = "0x210D5D4", VA = "0x210D5D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000238")]
		public MeshColliderCookingOptions CookingOptions
		{
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x210D5FC", Offset = "0x210D5FC", VA = "0x210D5FC")]
			get
			{
				return default(MeshColliderCookingOptions);
			}
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x210D604", Offset = "0x210D604", VA = "0x210D604")]
			set
			{
			}
		}

		[Token(Token = "0x17000239")]
		public PhysicMaterial Material
		{
			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x210D620", Offset = "0x210D620", VA = "0x210D620")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x210D628", Offset = "0x210D628", VA = "0x210D628")]
			set
			{
			}
		}

		[Token(Token = "0x1700023A")]
		public CGMeshResourceCollection Meshes
		{
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x210D6C8", Offset = "0x210D6C8", VA = "0x210D6C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023B")]
		public int MeshCount
		{
			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x210D6D0", Offset = "0x210D6D0", VA = "0x210D6D0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700023C")]
		public int VertexCount
		{
			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x210D6EC", Offset = "0x210D6EC", VA = "0x210D6EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB3D0", Offset = "0x13BB3D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x210D6F4", Offset = "0x210D6F4", VA = "0x210D6F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13BB3E0", Offset = "0x13BB3E0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700023D")]
		private bool canGroupMeshes
		{
			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x210D6FC", Offset = "0x210D6FC", VA = "0x210D6FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700023E")]
		private bool canModifyStaticFlag
		{
			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x210D744", Offset = "0x210D744", VA = "0x210D744")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700023F")]
		private bool canUpdate
		{
			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x210D74C", Offset = "0x210D74C", VA = "0x210D74C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x210D788", Offset = "0x210D788", VA = "0x210D788", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x210DA64", Offset = "0x210DA64", VA = "0x210DA64", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x210DA48", Offset = "0x210DA48", VA = "0x210DA48")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x210DB90", Offset = "0x210DB90", VA = "0x210DB90", Slot = "13")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x210DBE4", Offset = "0x210DBE4", VA = "0x210DBE4", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x210EC68", Offset = "0x210EC68", VA = "0x210EC68")]
		public GameObject SaveToScene([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x210EAFC", Offset = "0x210EAFC", VA = "0x210EAFC")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x210E718", Offset = "0x210E718", VA = "0x210E718")]
		private void createMeshes(ref List<CGVMesh> vMeshes, bool combine)
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x210DE8C", Offset = "0x210DE8C", VA = "0x210DE8C")]
		private void createSpotMeshes(ref List<CGVMesh> vMeshes, ref CGSpots spots, bool combine)
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x210F0A8", Offset = "0x210F0A8", VA = "0x210F0A8")]
		private CGMeshResource writeVMeshToMesh(ref CGVMesh vmesh)
		{
			return null;
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x210DA80", Offset = "0x210DA80", VA = "0x210DA80")]
		private void removeUnusedResource()
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x210F354", Offset = "0x210F354", VA = "0x210F354")]
		private CGMeshResource getNewMesh()
		{
			return null;
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x210F624", Offset = "0x210F624", VA = "0x210F624")]
		public CreateMesh()
		{
		}
	}
	[Token(Token = "0x2000129")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AE83C", Offset = "0x13AE83C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AE83C", Offset = "0x13AE83C")]
	public class CreatePathLineRenderer : CGModule
	{
		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B8934", Offset = "0x13B8934")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private LineRenderer mLineRenderer;

		[Token(Token = "0x17000240")]
		public LineRenderer LineRenderer
		{
			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x29032B0", Offset = "0x29032B0", VA = "0x29032B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x290335C", Offset = "0x290335C", VA = "0x290335C", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x290348C", Offset = "0x290348C", VA = "0x290348C", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x2903384", Offset = "0x2903384", VA = "0x2903384")]
		private void createLR()
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x29035E4", Offset = "0x29035E4", VA = "0x29035E4")]
		public CreatePathLineRenderer()
		{
		}
	}
	[Token(Token = "0x200012A")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AE8D4", Offset = "0x13AE8D4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AE8D4", Offset = "0x13AE8D4")]
	public class DebugRasterizedPath : CGModule
	{
		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B89F0", Offset = "0x13B89F0")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B8AAC", Offset = "0x13B8AAC")]
		public bool ShowNormals;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B8AE4", Offset = "0x13B8AE4")]
		public bool ShowOrientation;

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x2903658", Offset = "0x2903658", VA = "0x2903658", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x2903684", Offset = "0x2903684", VA = "0x2903684")]
		public DebugRasterizedPath()
		{
		}
	}
	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AE96C", Offset = "0x13AE96C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AE96C", Offset = "0x13AE96C")]
	public class DebugVMesh : CGModule
	{
		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B8B1C", Offset = "0x13B8B1C")]
		public CGModuleInputSlot InData;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B8BD8", Offset = "0x13B8BD8")]
		public bool ShowVertices;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool ShowVertexID;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		public bool ShowUV;

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x2903700", Offset = "0x2903700", VA = "0x2903700", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x290372C", Offset = "0x290372C", VA = "0x290372C")]
		public DebugVMesh()
		{
		}
	}
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AE9E8", Offset = "0x13AE9E8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AE9E8", Offset = "0x13AE9E8")]
	public class DebugVolume : CGModule
	{
		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B8C10", Offset = "0x13B8C10")]
		public CGModuleInputSlot InData;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B8CCC", Offset = "0x13B8CCC")]
		public bool ShowPathSamples;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool ShowCrossSamples;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B8D04", Offset = "0x13B8D04")]
		[IntRegion]
		public IntRegion LimitCross;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool ShowNormals;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		public bool ShowIndex;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
		public bool ShowMap;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Color PathColor;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public Color VolumeColor;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public Color NormalColor;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B8DC8", Offset = "0x13B8DC8")]
		public bool Interpolate;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B8E00", Offset = "0x13B8E00")]
		public float InterpolatePathF;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B8E54", Offset = "0x13B8E54")]
		public float InterpolateCrossF;

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x29037A0", Offset = "0x29037A0", VA = "0x29037A0")]
		public DebugVolume()
		{
		}
	}
	[Token(Token = "0x200012D")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AEA64", Offset = "0x13AEA64")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AEA64", Offset = "0x13AEA64")]
	public class InputGameObject : CGModule
	{
		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B8EA8", Offset = "0x13B8EA8")]
		public CGModuleOutputSlot OutGameObject;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[ArrayEx]
		[SerializeField]
		private List<CGGameObjectProperties> m_GameObjects;

		[Token(Token = "0x17000241")]
		public List<CGGameObjectProperties> GameObjects
		{
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x2903884", Offset = "0x2903884", VA = "0x2903884")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000242")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x290388C", Offset = "0x290388C", VA = "0x290388C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x2903894", Offset = "0x2903894", VA = "0x2903894", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x2903908", Offset = "0x2903908", VA = "0x2903908", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x2903AC0", Offset = "0x2903AC0", VA = "0x2903AC0", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x2903B24", Offset = "0x2903B24", VA = "0x2903B24")]
		public InputGameObject()
		{
		}
	}
	[Token(Token = "0x200012E")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AEAFC", Offset = "0x13AEAFC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AEAFC", Offset = "0x13AEAFC")]
	public class InputMesh : CGModule, IExternalInput
	{
		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B8F60", Offset = "0x13B8F60")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[ArrayEx]
		private List<CGMeshProperties> m_Meshes;

		[Token(Token = "0x17000243")]
		public List<CGMeshProperties> Meshes
		{
			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x2903BCC", Offset = "0x2903BCC", VA = "0x2903BCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000244")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x2903BD4", Offset = "0x2903BD4", VA = "0x2903BD4", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x2903BDC", Offset = "0x2903BDC", VA = "0x2903BDC", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x2903C50", Offset = "0x2903C50", VA = "0x2903C50", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x2903E40", Offset = "0x2903E40", VA = "0x2903E40", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x2903EA4", Offset = "0x2903EA4", VA = "0x2903EA4")]
		public InputMesh()
		{
		}
	}
	[Token(Token = "0x200012F")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AEB94", Offset = "0x13AEB94")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AEB94", Offset = "0x13AEB94")]
	public class InputSplinePath : SplineInputModuleBase, IExternalInput, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B9018", Offset = "0x13B9018")]
		public CGModuleOutputSlot Path;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B908C", Offset = "0x13B908C")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceManagerAttribute", RVA = "0x13B908C", Offset = "0x13B908C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x13B908C", Offset = "0x13B908C")]
		private CurvySpline m_Spline;

		[Token(Token = "0x17000245")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x2903FE0", Offset = "0x2903FE0", VA = "0x2903FE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x2903FE8", Offset = "0x2903FE8", VA = "0x2903FE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000246")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x290436C", Offset = "0x290436C", VA = "0x290436C", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000247")]
		protected override CurvySpline InputSpline
		{
			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x2905B00", Offset = "0x2905B00", VA = "0x2905B00", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x2905B08", Offset = "0x2905B08", VA = "0x2905B08", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x2904374", Offset = "0x2904374", VA = "0x2904374", Slot = "22")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x2905A58", Offset = "0x2905A58", VA = "0x2905A58", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x2905B0C", Offset = "0x2905B0C", VA = "0x2905B0C")]
		public InputSplinePath()
		{
		}
	}
	[Token(Token = "0x2000130")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AEC2C", Offset = "0x13AEC2C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AEC2C", Offset = "0x13AEC2C")]
	public class InputSplineShape : SplineInputModuleBase, IExternalInput, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B9148", Offset = "0x13B9148")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x13B91BC", Offset = "0x13B91BC")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceManagerAttribute", RVA = "0x13B91BC", Offset = "0x13B91BC")]
		private CurvySpline m_Shape;

		[Token(Token = "0x17000248")]
		public CurvySpline Shape
		{
			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x2905B88", Offset = "0x2905B88", VA = "0x2905B88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x2905B90", Offset = "0x2905B90", VA = "0x2905B90")]
			set
			{
			}
		}

		[Token(Token = "0x17000249")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x2905C50", Offset = "0x2905C50", VA = "0x2905C50", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700024A")]
		public bool FreeForm
		{
			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x2905C54", Offset = "0x2905C54", VA = "0x2905C54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x2905D30", Offset = "0x2905D30", VA = "0x2905D30")]
			set
			{
			}
		}

		[Token(Token = "0x1700024B")]
		protected override CurvySpline InputSpline
		{
			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x2906060", Offset = "0x2906060", VA = "0x2906060", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x2906068", Offset = "0x2906068", VA = "0x2906068", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x2905E7C", Offset = "0x2905E7C", VA = "0x2905E7C", Slot = "22")]
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
		[Address(RVA = "0x2905FB8", Offset = "0x2905FB8", VA = "0x2905FB8")]
		public void RemoveManagedShape()
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x290606C", Offset = "0x290606C", VA = "0x290606C", Slot = "19")]
		protected override void OnSplineAssigned()
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x29062B8", Offset = "0x29062B8", VA = "0x29062B8")]
		public InputSplineShape()
		{
		}
	}
	[Token(Token = "0x2000131")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AECC4", Offset = "0x13AECC4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AECC4", Offset = "0x13AECC4")]
	public class InputSpots : CGModule
	{
		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B9230", Offset = "0x13B9230")]
		public CGModuleOutputSlot OutSpots;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[ArrayEx]
		[SerializeField]
		private List<CGSpot> m_Spots;

		[Token(Token = "0x1700024C")]
		public List<CGSpot> Spots
		{
			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x290632C", Offset = "0x290632C", VA = "0x290632C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x2906334", Offset = "0x2906334", VA = "0x2906334")]
			set
			{
			}
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x2906370", Offset = "0x2906370", VA = "0x2906370", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x29063A8", Offset = "0x29063A8", VA = "0x29063A8", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x290641C", Offset = "0x290641C", VA = "0x290641C", Slot = "13")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x2906424", Offset = "0x2906424", VA = "0x2906424", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x2906550", Offset = "0x2906550", VA = "0x2906550")]
		public InputSpots()
		{
		}
	}
	[Token(Token = "0x2000132")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AED5C", Offset = "0x13AED5C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AED5C", Offset = "0x13AED5C")]
	public class ModifierMixPaths : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B92DC", Offset = "0x13B92DC")]
		public CGModuleInputSlot InPathA;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B9398", Offset = "0x13B9398")]
		public CGModuleInputSlot InPathB;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B9454", Offset = "0x13B9454")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B94C8", Offset = "0x13B94C8")]
		private float m_Mix;

		[Token(Token = "0x1700024D")]
		public float Mix
		{
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x29065F8", Offset = "0x29065F8", VA = "0x29065F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x2906600", Offset = "0x2906600", VA = "0x2906600")]
			set
			{
			}
		}

		[Token(Token = "0x1700024E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BBBD0", Offset = "0x13BBBD0")]
		public float PathLength
		{
			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x290661C", Offset = "0x290661C", VA = "0x290661C", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700024F")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x29067E8", Offset = "0x29067E8", VA = "0x29067E8", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x2906974", Offset = "0x2906974", VA = "0x2906974", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x29069BC", Offset = "0x29069BC", VA = "0x29069BC", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x29069FC", Offset = "0x29069FC", VA = "0x29069FC", Slot = "16")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x2906B38", Offset = "0x2906B38", VA = "0x2906B38")]
		public static CGPath MixPath(CGPath pathA, CGPath pathB, float mix, [NotNull] List<string> warningsContainer)
		{
			return null;
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x2907804", Offset = "0x2907804", VA = "0x2907804")]
		public ModifierMixPaths()
		{
		}
	}
	[Token(Token = "0x2000133")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AEDF4", Offset = "0x13AEDF4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AEDF4", Offset = "0x13AEDF4")]
	public class ModifierMixShapes : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Serializable]
		[Token(Token = "0x2000185")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF384", Offset = "0x13AF384")]
		private sealed class <>c
		{
			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<SamplePointsMaterialGroup, SamplePointsMaterialGroup> <>9__15_0;

			[Token(Token = "0x6000B6A")]
			[Address(RVA = "0x2907FF4", Offset = "0x2907FF4", VA = "0x2907FF4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B6B")]
			[Address(RVA = "0x2907FFC", Offset = "0x2907FFC", VA = "0x2907FFC")]
			internal SamplePointsMaterialGroup <InterpolateShape>b__15_0(SamplePointsMaterialGroup g)
			{
				return null;
			}
		}

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B9554", Offset = "0x13B9554")]
		public CGModuleInputSlot InShapeA;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B9610", Offset = "0x13B9610")]
		public CGModuleInputSlot InShapeB;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B96CC", Offset = "0x13B96CC")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x13B9740", Offset = "0x13B9740")]
		private float m_Mix;

		[Token(Token = "0x17000250")]
		public float Mix
		{
			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x29078D0", Offset = "0x29078D0", VA = "0x29078D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x29078D8", Offset = "0x29078D8", VA = "0x29078D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000251")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BBC08", Offset = "0x13BBC08")]
		public float PathLength
		{
			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x29078F4", Offset = "0x29078F4", VA = "0x29078F4", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000252")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x2907AC0", Offset = "0x2907AC0", VA = "0x2907AC0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x2907C4C", Offset = "0x2907C4C", VA = "0x2907C4C", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x2907C94", Offset = "0x2907C94", VA = "0x2907C94", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x2907CD4", Offset = "0x2907CD4", VA = "0x2907CD4", Slot = "16")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x2907E08", Offset = "0x2907E08", VA = "0x2907E08")]
		public static CGShape MixShapes(CGShape shapeA, CGShape shapeB, float mix, [NotNull] List<string> warningsContainer, bool ignoreWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x2906F64", Offset = "0x2906F64", VA = "0x2906F64")]
		public static void InterpolateShape([NotNull] CGShape resultShape, CGShape shapeA, CGShape shapeB, float mix, [NotNull] List<string> warningsContainer, bool ignoreWarnings = false)
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x2907EC0", Offset = "0x2907EC0", VA = "0x2907EC0")]
		public ModifierMixShapes()
		{
		}
	}
	[Token(Token = "0x2000134")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AEE8C", Offset = "0x13AEE8C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AEE8C", Offset = "0x13AEE8C")]
	public class ModifierPathRelativeTranslation : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B97CC", Offset = "0x13B97CC")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B989C", Offset = "0x13B989C")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B9910", Offset = "0x13B9910")]
		private float lateralTranslation;

		[Token(Token = "0x17000253")]
		public float LateralTranslation
		{
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x29080C4", Offset = "0x29080C4", VA = "0x29080C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x29080CC", Offset = "0x29080CC", VA = "0x29080CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000254")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BBC40", Offset = "0x13BBC40")]
		public float PathLength
		{
			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x29080EC", Offset = "0x29080EC", VA = "0x29080EC", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000255")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0x29081E0", Offset = "0x29081E0", VA = "0x29081E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x29082D4", Offset = "0x29082D4", VA = "0x29082D4", Slot = "16")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x290853C", Offset = "0x290853C", VA = "0x290853C", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x2908584", Offset = "0x2908584", VA = "0x2908584", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x29085D0", Offset = "0x29085D0", VA = "0x29085D0")]
		public ModifierPathRelativeTranslation()
		{
		}
	}
	[Token(Token = "0x2000135")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AEF24", Offset = "0x13AEF24")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AEF24", Offset = "0x13AEF24")]
	public class ModifierTRSMesh : TRSModuleBase
	{
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B995C", Offset = "0x13B995C")]
		public CGModuleInputSlot InVMesh;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B9A14", Offset = "0x13B9A14")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x2908670", Offset = "0x2908670", VA = "0x2908670", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x2908964", Offset = "0x2908964", VA = "0x2908964")]
		public ModifierTRSMesh()
		{
		}
	}
	[Token(Token = "0x2000136")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AEFBC", Offset = "0x13AEFBC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AEFBC", Offset = "0x13AEFBC")]
	public class ModifierTRSPath : TRSModuleBase, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B9A94", Offset = "0x13B9A94")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B9B64", Offset = "0x13B9B64")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x17000256")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BBC78", Offset = "0x13BBC78")]
		public float PathLength
		{
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x2908A78", Offset = "0x2908A78", VA = "0x2908A78", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000257")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x2908B6C", Offset = "0x2908B6C", VA = "0x2908B6C", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x2908C60", Offset = "0x2908C60", VA = "0x2908C60", Slot = "16")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x2908F78", Offset = "0x2908F78", VA = "0x2908F78")]
		public ModifierTRSPath()
		{
		}
	}
	[Token(Token = "0x2000137")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AF054", Offset = "0x13AF054")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AF054", Offset = "0x13AF054")]
	public class ModifierTRSShape : TRSModuleBase, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B9BD8", Offset = "0x13B9BD8")]
		public CGModuleInputSlot InShape;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x13B9CA8", Offset = "0x13B9CA8")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x17000258")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BBCB0", Offset = "0x13BBCB0")]
		public float PathLength
		{
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x2909014", Offset = "0x2909014", VA = "0x2909014", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000259")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x2909108", Offset = "0x2909108", VA = "0x2909108", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x29091FC", Offset = "0x29091FC", VA = "0x29091FC", Slot = "16")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x2909514", Offset = "0x2909514", VA = "0x2909514")]
		public ModifierTRSShape()
		{
		}
	}
	[Token(Token = "0x2000138")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AF0EC", Offset = "0x13AF0EC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AF0EC", Offset = "0x13AF0EC")]
	public class ModifierVariableMixShapes : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B9D1C", Offset = "0x13B9D1C")]
		public CGModuleInputSlot InShapeA;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x13B9DD8", Offset = "0x13B9DD8")]
		public CGModuleInputSlot InShapeB;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "ShapeOutputSlotInfo", RVA = "0x13B9E94", Offset = "0x13B9E94")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x13B9EE8", Offset = "0x13B9EE8")]
		[SerializeField]
		private AnimationCurve m_MixCurve;

		[Token(Token = "0x1700025A")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x13BBCE8", Offset = "0x13BBCE8")]
		public float PathLength
		{
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x29095B0", Offset = "0x29095B0", VA = "0x29095B0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700025B")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x290977C", Offset = "0x290977C", VA = "0x290977C", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700025C")]
		public AnimationCurve MixCurve
		{
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x2909908", Offset = "0x2909908", VA = "0x2909908")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x2909910", Offset = "0x2909910", VA = "0x2909910")]
			set
			{
			}
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x2909940", Offset = "0x2909940", VA = "0x2909940", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x2909988", Offset = "0x2909988", VA = "0x2909988", Slot = "16")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x2909B54", Offset = "0x2909B54", VA = "0x2909B54")]
		public ModifierVariableMixShapes()
		{
		}
	}
	[Token(Token = "0x2000139")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x13AF184", Offset = "0x13AF184")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AF184", Offset = "0x13AF184")]
	public class Note : CGModule, INoProcessing
	{
		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x13B9F50", Offset = "0x13B9F50")]
		private string m_Note;

		[Token(Token = "0x1700025D")]
		public string NoteText
		{
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x2909C48", Offset = "0x2909C48", VA = "0x2909C48")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x2909C50", Offset = "0x2909C50", VA = "0x2909C50")]
			set
			{
			}
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x2909C98", Offset = "0x2909C98", VA = "0x2909C98", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x2909CE0", Offset = "0x2909CE0", VA = "0x2909CE0", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x2909D10", Offset = "0x2909D10", VA = "0x2909D10")]
		public Note()
		{
		}
	}
}
