using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.UI;
using UnityStandardAssets.Utility;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Image _image;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x10BB12C", Offset = "0x10BB12C", VA = "0x10BB12C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x10BB318", Offset = "0x10BB318", VA = "0x10BB318", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x10BB610", Offset = "0x10BB610", VA = "0x10BB610")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000003")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1238C74", Offset = "0x1238C74", VA = "0x1238C74")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1238D88", Offset = "0x1238D88", VA = "0x1238D88")]
	public EventSystemChecker()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD228", Offset = "0x5BD228")]
public class ForcedReset : MonoBehaviour
{
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x11C2E8C", Offset = "0x11C2E8C", VA = "0x11C2E8C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x11C2F5C", Offset = "0x11C2F5C", VA = "0x11C2F5C")]
	public ForcedReset()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000005")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000122")]
		public enum Mode
		{
			[Token(Token = "0x400081E")]
			Trigger,
			[Token(Token = "0x400081F")]
			Replace,
			[Token(Token = "0x4000820")]
			Activate,
			[Token(Token = "0x4000821")]
			Enable,
			[Token(Token = "0x4000822")]
			Animate,
			[Token(Token = "0x4000823")]
			Deactivate
		}

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode action;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object target;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject source;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int triggerCount;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool repeatTrigger;

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x10B7408", Offset = "0x10B7408", VA = "0x10B7408")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x10B78A8", Offset = "0x10B78A8", VA = "0x10B78A8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x10B78AC", Offset = "0x10B78AC", VA = "0x10B78AC")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000123")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x6000842")]
			[Address(RVA = "0x11223D0", Offset = "0x11223D0", VA = "0x11223D0")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000124")]
		public class ReplacementList
		{
			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x6000843")]
			[Address(RVA = "0x11223D8", Offset = "0x11223D8", VA = "0x11223D8")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x10BD21C", Offset = "0x10BD21C", VA = "0x10BD21C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x10BDC2C", Offset = "0x10BDC2C", VA = "0x10BDC2C")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000125")]
		public class Vector3andSpace
		{
			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x6000844")]
			[Address(RVA = "0x1122434", Offset = "0x1122434", VA = "0x1122434")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x10BDC34", Offset = "0x10BDC34", VA = "0x10BDC34")]
		private void Start()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x10BDC5C", Offset = "0x10BDC5C", VA = "0x10BDC5C")]
		private void Update()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x10BDD2C", Offset = "0x10BDD2C", VA = "0x10BDD2C")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class CameraRefocus
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x122F978", Offset = "0x122F978", VA = "0x122F978")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x122F9D8", Offset = "0x122F9D8", VA = "0x122F9D8")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x122F9E0", Offset = "0x122F9E0", VA = "0x122F9E0")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x122F9E8", Offset = "0x122F9E8", VA = "0x122F9E8")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x122FAE4", Offset = "0x122FAE4", VA = "0x122FAE4")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000009")]
	public class CurveControlledBob
	{
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1236DD0", Offset = "0x1236DD0", VA = "0x1236DD0")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1236E74", Offset = "0x1236E74", VA = "0x1236E74")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1236F70", Offset = "0x1236F70", VA = "0x1236F70")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x2000126")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE688", Offset = "0x5BE688")]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x1700009C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000848")]
				[Address(RVA = "0x1122BB4", Offset = "0x1122BB4", VA = "0x1122BB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600084A")]
				[Address(RVA = "0x1122BFC", Offset = "0x1122BFC", VA = "0x1122BFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000845")]
			[Address(RVA = "0x1122944", Offset = "0x1122944", VA = "0x1122944")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000846")]
			[Address(RVA = "0x1122970", Offset = "0x1122970", VA = "0x1122970", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000847")]
			[Address(RVA = "0x1122974", Offset = "0x1122974", VA = "0x1122974", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000849")]
			[Address(RVA = "0x1122BBC", Offset = "0x1122BBC", VA = "0x1122BBC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400001A")]
		private const float k_Spring = 50f;

		[Token(Token = "0x400001B")]
		private const float k_Damper = 5f;

		[Token(Token = "0x400001C")]
		private const float k_Drag = 10f;

		[Token(Token = "0x400001D")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x400001E")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x400001F")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1237430", Offset = "0x1237430", VA = "0x1237430")]
		private void Update()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1237870", Offset = "0x1237870", VA = "0x1237870")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C7B94", Offset = "0x5C7B94")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x12377B8", Offset = "0x12377B8", VA = "0x12377B8")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x12378EC", Offset = "0x12378EC", VA = "0x12378EC")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x12378F4", Offset = "0x12378F4", VA = "0x12378F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1237928", Offset = "0x1237928", VA = "0x1237928")]
		private void Update()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1237AE4", Offset = "0x1237AE4", VA = "0x1237AE4")]
		public DynamicShadowSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public class FOVKick
	{
		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE698", Offset = "0x5BE698")]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x1700009E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600084E")]
				[Address(RVA = "0x1124338", Offset = "0x1124338", VA = "0x1124338", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000850")]
				[Address(RVA = "0x1124380", Offset = "0x1124380", VA = "0x1124380", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600084B")]
			[Address(RVA = "0x11241D8", Offset = "0x11241D8", VA = "0x11241D8")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600084C")]
			[Address(RVA = "0x1124204", Offset = "0x1124204", VA = "0x1124204", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600084D")]
			[Address(RVA = "0x1124208", Offset = "0x1124208", VA = "0x1124208", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600084F")]
			[Address(RVA = "0x1124340", Offset = "0x1124340", VA = "0x1124340", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE6A8", Offset = "0x5BE6A8")]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x4000837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x170000A0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000854")]
				[Address(RVA = "0x1124188", Offset = "0x1124188", VA = "0x1124188", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000856")]
				[Address(RVA = "0x11241D0", Offset = "0x11241D0", VA = "0x11241D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0x1124014", Offset = "0x1124014", VA = "0x1124014")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000852")]
			[Address(RVA = "0x1124040", Offset = "0x1124040", VA = "0x1124040", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000853")]
			[Address(RVA = "0x1124044", Offset = "0x1124044", VA = "0x1124044", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x1124190", Offset = "0x1124190", VA = "0x1124190", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x11BF0D0", Offset = "0x11BF0D0", VA = "0x11BF0D0")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x11BF110", Offset = "0x11BF110", VA = "0x11BF110")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x11BF1FC", Offset = "0x11BF1FC", VA = "0x11BF1FC")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x11BF204", Offset = "0x11BF204", VA = "0x11BF204")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C7BF4", Offset = "0x5C7BF4")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x11BF270", Offset = "0x11BF270", VA = "0x11BF270")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C7C54", Offset = "0x5C7C54")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x11BF2DC", Offset = "0x11BF2DC", VA = "0x11BF2DC")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD288", Offset = "0x5BD288")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x4000032")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x4000036")]
		private const string display = "{0} FPS";

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x11C0558", Offset = "0x11C0558", VA = "0x11C0558")]
		private void Start()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x11C05C0", Offset = "0x11C05C0", VA = "0x11C05C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x11C06AC", Offset = "0x11C06AC", VA = "0x11C06AC")]
		public FPSCounter()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x11C2E14", Offset = "0x11C2E14", VA = "0x11C2E14")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x11C2E74", Offset = "0x11C2E74", VA = "0x11C2E74")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class LerpControlledBob
	{
		[Token(Token = "0x2000129")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE6B8", Offset = "0x5BE6B8")]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x170000A2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600085A")]
				[Address(RVA = "0x12F2D0C", Offset = "0x12F2D0C", VA = "0x12F2D0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600085C")]
				[Address(RVA = "0x12F2D54", Offset = "0x12F2D54", VA = "0x12F2D54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0x12F2B50", Offset = "0x12F2B50", VA = "0x12F2B50")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000858")]
			[Address(RVA = "0x12F2B7C", Offset = "0x12F2B7C", VA = "0x12F2B7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000859")]
			[Address(RVA = "0x12F2B80", Offset = "0x12F2B80", VA = "0x12F2B80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600085B")]
			[Address(RVA = "0x12F2D14", Offset = "0x12F2D14", VA = "0x12F2D14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xF9E438", Offset = "0xF9E438", VA = "0xF9E438")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xF9E440", Offset = "0xF9E440", VA = "0xF9E440")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C7CB4", Offset = "0x5C7CB4")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xF9E4AC", Offset = "0xF9E4AC", VA = "0xF9E4AC")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x200012A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE6C8", Offset = "0x5BE6C8")]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x170000A4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000860")]
				[Address(RVA = "0x12F3560", Offset = "0x12F3560", VA = "0x12F3560", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000862")]
				[Address(RVA = "0x12F35A8", Offset = "0x12F35A8", VA = "0x12F35A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600085D")]
			[Address(RVA = "0x12F32F4", Offset = "0x12F32F4", VA = "0x12F32F4")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0x12F3320", Offset = "0x12F3320", VA = "0x12F3320", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600085F")]
			[Address(RVA = "0x12F3324", Offset = "0x12F3324", VA = "0x12F3324", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0x12F3568", Offset = "0x12F3568", VA = "0x12F3568", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xFA31DC", Offset = "0xFA31DC", VA = "0xFA31DC")]
		private void Start()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xFA32E8", Offset = "0xFA32E8", VA = "0xFA32E8")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xFA3314", Offset = "0xFA3314", VA = "0xFA3314")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C7D14", Offset = "0x5C7D14")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xFA3390", Offset = "0xFA3390", VA = "0xFA3390")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x200012B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE6D8", Offset = "0x5BE6D8")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x170000A6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000866")]
				[Address(RVA = "0x12F411C", Offset = "0x12F411C", VA = "0x12F411C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000868")]
				[Address(RVA = "0x12F4164", Offset = "0x12F4164", VA = "0x12F4164", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000863")]
			[Address(RVA = "0x12F3DB4", Offset = "0x12F3DB4", VA = "0x12F3DB4")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000864")]
			[Address(RVA = "0x12F3DE0", Offset = "0x12F3DE0", VA = "0x12F3DE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000865")]
			[Address(RVA = "0x12F3DE4", Offset = "0x12F3DE4", VA = "0x12F3DE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000867")]
			[Address(RVA = "0x12F4124", Offset = "0x12F4124", VA = "0x12F4124", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xFA3D0C", Offset = "0xFA3D0C", VA = "0xFA3D0C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C7D74", Offset = "0x5C7D74")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xFA3D78", Offset = "0xFA3D78", VA = "0xFA3D78")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xFA3D84", Offset = "0xFA3D84", VA = "0xFA3D84")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x200012C")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x4000846")]
			Standalone,
			[Token(Token = "0x4000847")]
			Mobile
		}

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xFA7844", Offset = "0xFA7844", VA = "0xFA7844")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xFA7848", Offset = "0xFA7848", VA = "0xFA7848")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xFA7864", Offset = "0xFA7864", VA = "0xFA7864")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xFA7C14", Offset = "0xFA7C14", VA = "0xFA7C14")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] objects;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentActiveObject;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xEA9B04", Offset = "0xEA9B04", VA = "0xEA9B04")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xEA9B0C", Offset = "0xEA9B0C", VA = "0xEA9B0C")]
		public void NextCamera()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xEA9BA8", Offset = "0xEA9BA8", VA = "0xEA9BA8")]
		public SimpleActivatorMenu()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xEAA7A0", Offset = "0xEAA7A0", VA = "0xEAA7A0")]
		private void Start()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xEAA7DC", Offset = "0xEAA7DC", VA = "0xEAA7DC")]
		private void Update()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xEAAB34", Offset = "0xEAAB34", VA = "0xEAAB34")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xEAAD84", Offset = "0xEAAD84", VA = "0xEAAD84")]
		private void Start()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xEAAD88", Offset = "0xEAAD88", VA = "0xEAAD88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xEAB030", Offset = "0xEAB030", VA = "0xEAB030")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x200012D")]
		public enum Action
		{
			[Token(Token = "0x4000849")]
			Activate,
			[Token(Token = "0x400084A")]
			Deactivate,
			[Token(Token = "0x400084B")]
			Destroy,
			[Token(Token = "0x400084C")]
			ReloadLevel,
			[Token(Token = "0x400084D")]
			Call
		}

		[Serializable]
		[Token(Token = "0x200012E")]
		public class Entry
		{
			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x6000869")]
			[Address(RVA = "0x12F626C", Offset = "0x12F626C", VA = "0x12F626C")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200012F")]
		public class Entries
		{
			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x600086A")]
			[Address(RVA = "0x12F6264", Offset = "0x12F6264", VA = "0x12F6264")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE6E8", Offset = "0x5BE6E8")]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x170000A8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600086E")]
				[Address(RVA = "0x12F5F50", Offset = "0x12F5F50", VA = "0x12F5F50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000870")]
				[Address(RVA = "0x12F5F98", Offset = "0x12F5F98", VA = "0x12F5F98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600086B")]
			[Address(RVA = "0x12F5E5C", Offset = "0x12F5E5C", VA = "0x12F5E5C")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x600086C")]
			[Address(RVA = "0x12F5E88", Offset = "0x12F5E88", VA = "0x12F5E88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600086D")]
			[Address(RVA = "0x12F5E8C", Offset = "0x12F5E8C", VA = "0x12F5E8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600086F")]
			[Address(RVA = "0x12F5F58", Offset = "0x12F5F58", VA = "0x12F5F58", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000131")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE6F8", Offset = "0x5BE6F8")]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x170000AA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000874")]
				[Address(RVA = "0x12F6094", Offset = "0x12F6094", VA = "0x12F6094", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000876")]
				[Address(RVA = "0x12F60DC", Offset = "0x12F60DC", VA = "0x12F60DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000871")]
			[Address(RVA = "0x12F5FA0", Offset = "0x12F5FA0", VA = "0x12F5FA0")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x12F5FCC", Offset = "0x12F5FCC", VA = "0x12F5FCC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000873")]
			[Address(RVA = "0x12F5FD0", Offset = "0x12F5FD0", VA = "0x12F5FD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000875")]
			[Address(RVA = "0x12F609C", Offset = "0x12F609C", VA = "0x12F609C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000132")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE708", Offset = "0x5BE708")]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400085A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x170000AC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600087A")]
				[Address(RVA = "0x12F6214", Offset = "0x12F6214", VA = "0x12F6214", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600087C")]
				[Address(RVA = "0x12F625C", Offset = "0x12F625C", VA = "0x12F625C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x12F60E4", Offset = "0x12F60E4", VA = "0x12F60E4")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000878")]
			[Address(RVA = "0x12F6110", Offset = "0x12F6110", VA = "0x12F6110", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000879")]
			[Address(RVA = "0x12F6114", Offset = "0x12F6114", VA = "0x12F6114", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600087B")]
			[Address(RVA = "0x12F621C", Offset = "0x12F621C", VA = "0x12F621C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xEAD844", Offset = "0xEAD844", VA = "0xEAD844")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xEAD96C", Offset = "0xEAD96C", VA = "0xEAD96C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C7DD4", Offset = "0x5C7DD4")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xEAD9D8", Offset = "0xEAD9D8", VA = "0xEAD9D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C7E34", Offset = "0x5C7E34")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xEADA44", Offset = "0xEADA44", VA = "0xEADA44")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C7E94", Offset = "0x5C7E94")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xEADAB0", Offset = "0xEADAB0", VA = "0xEADAB0")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xEADB14", Offset = "0xEADB14", VA = "0xEADB14")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xEADB68", Offset = "0xEADB68", VA = "0xEADB68")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xEADC04", Offset = "0xEADC04", VA = "0xEADC04")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000133")]
		public class WaypointList
		{
			[Token(Token = "0x400085B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x400085C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x600087D")]
			[Address(RVA = "0x12F8558", Offset = "0x12F8558", VA = "0x12F8558")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x2000134")]
		public struct RoutePoint
		{
			[Token(Token = "0x400085D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x400085E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x600087E")]
			[Address(RVA = "0x12F8548", Offset = "0x12F8548", VA = "0x12F8548")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE8D8", Offset = "0x5BE8D8")]
		private float <Length>k__BackingField;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000001")]
		public float Length
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x1120520", Offset = "0x1120520", VA = "0x1120520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C7EF4", Offset = "0x5C7EF4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x1120528", Offset = "0x1120528", VA = "0x1120528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C7F04", Offset = "0x5C7F04")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x1120530", Offset = "0x1120530", VA = "0x1120530")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x112054C", Offset = "0x112054C", VA = "0x112054C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1120854", Offset = "0x1120854", VA = "0x1120854")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1120900", Offset = "0x1120900", VA = "0x1120900")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1120B8C", Offset = "0x1120B8C", VA = "0x1120B8C")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x11205A8", Offset = "0x11205A8", VA = "0x11205A8")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1120C98", Offset = "0x1120C98", VA = "0x1120C98")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1120F18", Offset = "0x1120F18", VA = "0x1120F18")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1120CA0", Offset = "0x1120CA0", VA = "0x1120CA0")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1120F20", Offset = "0x1120F20", VA = "0x1120F20")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x2000135")]
		public enum ProgressStyle
		{
			[Token(Token = "0x4000860")]
			SmoothAlongRoute,
			[Token(Token = "0x4000861")]
			PointToPoint
		}

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE958", Offset = "0x5BE958")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE968", Offset = "0x5BE968")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE978", Offset = "0x5BE978")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000003")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x1120F94", Offset = "0x1120F94", VA = "0x1120F94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C7F14", Offset = "0x5C7F14")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x1120FA8", Offset = "0x1120FA8", VA = "0x1120FA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C7F24", Offset = "0x5C7F24")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x1120FBC", Offset = "0x1120FBC", VA = "0x1120FBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C7F34", Offset = "0x5C7F34")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x1120FD0", Offset = "0x1120FD0", VA = "0x1120FD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C7F44", Offset = "0x5C7F44")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x1120FE4", Offset = "0x1120FE4", VA = "0x1120FE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C7F54", Offset = "0x5C7F54")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x1120FF8", Offset = "0x1120FF8", VA = "0x1120FF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C7F64", Offset = "0x5C7F64")]
			private set
			{
			}
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x112100C", Offset = "0x112100C", VA = "0x112100C")]
		private void Start()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1121104", Offset = "0x1121104", VA = "0x1121104")]
		public void Reset()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x11211DC", Offset = "0x11211DC", VA = "0x11211DC")]
		private void Update()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x11215F0", Offset = "0x11215F0", VA = "0x11215F0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1121740", Offset = "0x1121740", VA = "0x1121740")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD2E8", Offset = "0x5BD2E8")]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x10B971C", Offset = "0x10B971C", VA = "0x10B971C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x10B97BC", Offset = "0x10B97BC", VA = "0x10B97BC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x10B9BB4", Offset = "0x10B9BB4", VA = "0x10B9BB4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x10BA038", Offset = "0x10BA038", VA = "0x10BA038")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x2000136")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE718", Offset = "0x5BE718")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x170000AE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000882")]
				[Address(RVA = "0x1123150", Offset = "0x1123150", VA = "0x1123150", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000884")]
				[Address(RVA = "0x1123198", Offset = "0x1123198", VA = "0x1123198", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x1122C04", Offset = "0x1122C04", VA = "0x1122C04")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0x1122C30", Offset = "0x1122C30", VA = "0x1122C30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0x1122C34", Offset = "0x1122C34", VA = "0x1122C34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0x1123158", Offset = "0x1123158", VA = "0x1123158", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x12392AC", Offset = "0x12392AC", VA = "0x12392AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C7F74", Offset = "0x5C7F74")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1239318", Offset = "0x1239318", VA = "0x1239318")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x123943C", Offset = "0x123943C", VA = "0x123943C")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x2000137")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE728", Offset = "0x5BE728")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x170000B0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000888")]
				[Address(RVA = "0x112353C", Offset = "0x112353C", VA = "0x112353C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600088A")]
				[Address(RVA = "0x1123584", Offset = "0x1123584", VA = "0x1123584", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0x11231A0", Offset = "0x11231A0", VA = "0x11231A0")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000886")]
			[Address(RVA = "0x11231CC", Offset = "0x11231CC", VA = "0x11231CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000887")]
			[Address(RVA = "0x11231D0", Offset = "0x11231D0", VA = "0x11231D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000889")]
			[Address(RVA = "0x1123544", Offset = "0x1123544", VA = "0x1123544", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1239444", Offset = "0x1239444", VA = "0x1239444")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C7FD4", Offset = "0x5C7FD4")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x12394B0", Offset = "0x12394B0", VA = "0x12394B0")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x2000138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE738", Offset = "0x5BE738")]
		private sealed class <OnCollisionEnter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Explosive <>4__this;

			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Collision col;

			[Token(Token = "0x170000B2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600088E")]
				[Address(RVA = "0x1123850", Offset = "0x1123850", VA = "0x1123850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000890")]
				[Address(RVA = "0x1123898", Offset = "0x1123898", VA = "0x1123898", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600088B")]
			[Address(RVA = "0x112358C", Offset = "0x112358C", VA = "0x112358C")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600088C")]
			[Address(RVA = "0x11235B8", Offset = "0x11235B8", VA = "0x11235B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600088D")]
			[Address(RVA = "0x11235BC", Offset = "0x11235BC", VA = "0x11235BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600088F")]
			[Address(RVA = "0x1123858", Offset = "0x1123858", VA = "0x1123858", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform explosionPrefab;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float detonationImpactVelocity;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sizeMultiplier;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool reset;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float resetTimeDelay;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_Exploded;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ObjectResetter m_ObjectResetter;

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x12394C0", Offset = "0x12394C0", VA = "0x12394C0")]
		private void Start()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1239514", Offset = "0x1239514", VA = "0x1239514")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C8034", Offset = "0x5C8034")]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x123958C", Offset = "0x123958C", VA = "0x123958C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1239594", Offset = "0x1239594", VA = "0x1239594")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x12395B8", Offset = "0x12395B8", VA = "0x12395B8")]
		private void Start()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x123960C", Offset = "0x123960C", VA = "0x123960C")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1239698", Offset = "0x1239698", VA = "0x1239698")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x11C1D44", Offset = "0x11C1D44", VA = "0x11C1D44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x11C1DB0", Offset = "0x11C1DB0", VA = "0x11C1DB0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x11C1F6C", Offset = "0x11C1F6C", VA = "0x11C1F6C")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x11C1F94", Offset = "0x11C1F94", VA = "0x11C1F94")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x12C0294", Offset = "0x12C0294", VA = "0x12C0294")]
		private void Update()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x12C0410", Offset = "0x12C0410", VA = "0x12C0410")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xFA3D98", Offset = "0xFA3D98", VA = "0xFA3D98")]
		private void Start()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xFA3EF8", Offset = "0xFA3EF8", VA = "0xFA3EF8")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xEAACC0", Offset = "0xEAACC0", VA = "0xEAACC0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xEAAD7C", Offset = "0xEAAD7C", VA = "0xEAAD7C")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x111FF04", Offset = "0x111FF04", VA = "0x111FF04")]
		private void Start()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x111FF58", Offset = "0x111FF58", VA = "0x111FF58")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x11201CC", Offset = "0x11201CC", VA = "0x11201CC")]
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
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x111FCD0", Offset = "0x111FCD0", VA = "0x111FCD0")]
		private void Update()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x111FEFC", Offset = "0x111FEFC", VA = "0x111FEFC")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD358", Offset = "0x5BD358")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1237334", Offset = "0x1237334", VA = "0x1237334")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1237358", Offset = "0x1237358", VA = "0x1237358")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x12373C0", Offset = "0x12373C0", VA = "0x12373C0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1237428", Offset = "0x1237428", VA = "0x1237428")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD3C8", Offset = "0x5BD3C8")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x11C48A0", Offset = "0x11C48A0", VA = "0x11C48A0")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class MeshContainer
	{
		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xFA1014", Offset = "0xFA1014", VA = "0xFA1014")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xFA1068", Offset = "0xFA1068", VA = "0xFA1068")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD438", Offset = "0x5BD438")]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xFA5C58", Offset = "0xFA5C58", VA = "0xFA5C58")]
		public void Start()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xFA5D5C", Offset = "0xFA5D5C", VA = "0xFA5D5C")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xFA60A8", Offset = "0xFA60A8", VA = "0xFA60A8")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xFA6158", Offset = "0xFA6158", VA = "0xFA6158")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xFA6234", Offset = "0xFA6234", VA = "0xFA6234")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xFA6AE8", Offset = "0xFA6AE8", VA = "0xFA6AE8")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xFA6B44", Offset = "0xFA6B44", VA = "0xFA6B44")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xFA6C38", Offset = "0xFA6C38", VA = "0xFA6C38")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xFA6CA0", Offset = "0xFA6CA0", VA = "0xFA6CA0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xFA63E0", Offset = "0xFA63E0", VA = "0xFA63E0")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xFA6D08", Offset = "0xFA6D08", VA = "0xFA6D08")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xFA7150", Offset = "0xFA7150", VA = "0xFA7150")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xFA6D6C", Offset = "0xFA6D6C", VA = "0xFA6D6C")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xFA7314", Offset = "0xFA7314", VA = "0xFA7314")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xFA7024", Offset = "0xFA7024", VA = "0xFA7024")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xFA7334", Offset = "0xFA7334", VA = "0xFA7334")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD4A8", Offset = "0x5BD4A8")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xEAB778", Offset = "0xEAB778", VA = "0xEAB778")]
		public void Start()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xEAB878", Offset = "0xEAB878", VA = "0xEAB878")]
		public void Update()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xEABA7C", Offset = "0xEABA7C", VA = "0xEABA7C")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x2000139")]
		public enum WaterMode
		{
			[Token(Token = "0x400086E")]
			Simple,
			[Token(Token = "0x400086F")]
			Reflective,
			[Token(Token = "0x4000870")]
			Refractive
		}

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xEB6C68", Offset = "0xEB6C68", VA = "0xEB6C68")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xEB86F0", Offset = "0xEB86F0", VA = "0xEB86F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xEB8A68", Offset = "0xEB8A68", VA = "0xEB8A68")]
		private void Update()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xEB80BC", Offset = "0xEB80BC", VA = "0xEB80BC")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xEB77A0", Offset = "0xEB77A0", VA = "0xEB77A0")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xEB778C", Offset = "0xEB778C", VA = "0xEB778C")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xEB7618", Offset = "0xEB7618", VA = "0xEB7618")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xEB85C4", Offset = "0xEB85C4", VA = "0xEB85C4")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xEB8320", Offset = "0xEB8320", VA = "0xEB8320")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xEB8D38", Offset = "0xEB8D38", VA = "0xEB8D38")]
		public Water()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public enum WaterQuality
	{
		[Token(Token = "0x40000BC")]
		High = 2,
		[Token(Token = "0x40000BD")]
		Medium = 1,
		[Token(Token = "0x40000BE")]
		Low = 0
	}
	[Token(Token = "0x200002C")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x111F9F4", Offset = "0x111F9F4", VA = "0x111F9F4")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x111FB88", Offset = "0x111FB88", VA = "0x111FB88")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x111FC38", Offset = "0x111FC38", VA = "0x111FC38")]
		public void Update()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x111FCB8", Offset = "0x111FCB8", VA = "0x111FCB8")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x112024C", Offset = "0x112024C", VA = "0x112024C")]
		public void Start()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1120250", Offset = "0x1120250", VA = "0x1120250")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1120408", Offset = "0x1120408", VA = "0x1120408")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1120518", Offset = "0x1120518", VA = "0x1120518")]
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
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x10BE93C", Offset = "0x10BE93C", VA = "0x10BE93C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x10BEA3C", Offset = "0x10BEA3C", VA = "0x10BEA3C")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x10BEBDC", Offset = "0x10BEBDC", VA = "0x10BEBDC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x10BEBF8", Offset = "0x10BEBF8", VA = "0x10BEBF8", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x10BECB8", Offset = "0x10BECB8", VA = "0x10BECB8", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x10BED0C", Offset = "0x10BED0C", VA = "0x10BED0C")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x122DDE0", Offset = "0x122DDE0", VA = "0x122DDE0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x122DDE4", Offset = "0x122DDE4", VA = "0x122DDE4")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x122DEC4", Offset = "0x122DEC4", VA = "0x122DEC4")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x122DFA4", Offset = "0x122DFA4", VA = "0x122DFA4")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x122E084", Offset = "0x122E084", VA = "0x122E084")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x122E164", Offset = "0x122E164", VA = "0x122E164")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x122E244", Offset = "0x122E244", VA = "0x122E244")]
		public void Update()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x122E248", Offset = "0x122E248", VA = "0x122E248")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200013A")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x4000872")]
			Hardware,
			[Token(Token = "0x4000873")]
			Touch
		}

		[Token(Token = "0x200013B")]
		public class VirtualAxis
		{
			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4534", Offset = "0x5C4534")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4544", Offset = "0x5C4544")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x170000B4")]
			public string name
			{
				[Token(Token = "0x6000891")]
				[Address(RVA = "0x112264C", Offset = "0x112264C", VA = "0x112264C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA95C", Offset = "0x5CA95C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000892")]
				[Address(RVA = "0x1122654", Offset = "0x1122654", VA = "0x1122654")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA96C", Offset = "0x5CA96C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B5")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000893")]
				[Address(RVA = "0x112265C", Offset = "0x112265C", VA = "0x112265C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA97C", Offset = "0x5CA97C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000894")]
				[Address(RVA = "0x1122664", Offset = "0x1122664", VA = "0x1122664")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA98C", Offset = "0x5CA98C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B6")]
			public float GetValue
			{
				[Token(Token = "0x6000899")]
				[Address(RVA = "0x1122754", Offset = "0x1122754", VA = "0x1122754")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000B7")]
			public float GetValueRaw
			{
				[Token(Token = "0x600089A")]
				[Address(RVA = "0x112275C", Offset = "0x112275C", VA = "0x112275C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000895")]
			[Address(RVA = "0x1122670", Offset = "0x1122670", VA = "0x1122670")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x11226A4", Offset = "0x11226A4", VA = "0x11226A4")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000897")]
			[Address(RVA = "0x11226E4", Offset = "0x11226E4", VA = "0x11226E4")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x112274C", Offset = "0x112274C", VA = "0x112274C")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x200013C")]
		public class VirtualButton
		{
			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4554", Offset = "0x5C4554")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4564", Offset = "0x5C4564")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x170000B8")]
			public string name
			{
				[Token(Token = "0x600089B")]
				[Address(RVA = "0x1122764", Offset = "0x1122764", VA = "0x1122764")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA99C", Offset = "0x5CA99C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600089C")]
				[Address(RVA = "0x112276C", Offset = "0x112276C", VA = "0x112276C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA9AC", Offset = "0x5CA9AC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B9")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600089D")]
				[Address(RVA = "0x1122774", Offset = "0x1122774", VA = "0x1122774")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA9BC", Offset = "0x5CA9BC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600089E")]
				[Address(RVA = "0x112277C", Offset = "0x112277C", VA = "0x112277C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA9CC", Offset = "0x5CA9CC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BA")]
			public bool GetButton
			{
				[Token(Token = "0x60008A4")]
				[Address(RVA = "0x11228DC", Offset = "0x11228DC", VA = "0x11228DC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BB")]
			public bool GetButtonDown
			{
				[Token(Token = "0x60008A5")]
				[Address(RVA = "0x11228E4", Offset = "0x11228E4", VA = "0x11228E4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BC")]
			public bool GetButtonUp
			{
				[Token(Token = "0x60008A6")]
				[Address(RVA = "0x1122914", Offset = "0x1122914", VA = "0x1122914")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600089F")]
			[Address(RVA = "0x1122788", Offset = "0x1122788", VA = "0x1122788")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x11227C4", Offset = "0x11227C4", VA = "0x11227C4")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x112280C", Offset = "0x112280C", VA = "0x112280C")]
			public void Pressed()
			{
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x1122848", Offset = "0x1122848", VA = "0x1122848")]
			public void Released()
			{
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x1122874", Offset = "0x1122874", VA = "0x1122874")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x17000006")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x1236BD8", Offset = "0x1236BD8", VA = "0x1236BD8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x12363F0", Offset = "0x12363F0", VA = "0x12363F0")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x12364A4", Offset = "0x12364A4", VA = "0x12364A4")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1236550", Offset = "0x1236550", VA = "0x1236550")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x12365C8", Offset = "0x12365C8", VA = "0x12365C8")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1236640", Offset = "0x1236640", VA = "0x1236640")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x12366B8", Offset = "0x12366B8", VA = "0x12366B8")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1236730", Offset = "0x1236730", VA = "0x1236730")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x12367F4", Offset = "0x12367F4", VA = "0x12367F4")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x123686C", Offset = "0x123686C", VA = "0x123686C")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x12320E0", Offset = "0x12320E0", VA = "0x12320E0")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1236970", Offset = "0x1236970", VA = "0x1236970")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x12368E4", Offset = "0x12368E4", VA = "0x12368E4")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x12369D4", Offset = "0x12369D4", VA = "0x12369D4")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1236A50", Offset = "0x1236A50", VA = "0x1236A50")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1236ACC", Offset = "0x1236ACC", VA = "0x1236ACC")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x122DE48", Offset = "0x122DE48", VA = "0x122DE48")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x122DF28", Offset = "0x122DF28", VA = "0x122DF28")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x122E008", Offset = "0x122E008", VA = "0x122E008")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x122E1C8", Offset = "0x122E1C8", VA = "0x122E1C8")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x122E0E8", Offset = "0x122E0E8", VA = "0x122E0E8")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1236B48", Offset = "0x1236B48", VA = "0x1236B48")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1236C50", Offset = "0x1236C50", VA = "0x1236C50")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1236CD0", Offset = "0x1236CD0", VA = "0x1236CD0")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1236D50", Offset = "0x1236D50", VA = "0x1236D50")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x11FCB2C", Offset = "0x11FCB2C", VA = "0x11FCB2C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x11FCB30", Offset = "0x11FCB30", VA = "0x11FCB30")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x11FCBB0", Offset = "0x11FCBB0", VA = "0x11FCBB0")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x200013D")]
		public enum AxisOption
		{
			[Token(Token = "0x400087D")]
			Both,
			[Token(Token = "0x400087E")]
			OnlyHorizontal,
			[Token(Token = "0x400087F")]
			OnlyVertical
		}

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xF9D630", Offset = "0xF9D630", VA = "0xF9D630")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xF9D770", Offset = "0xF9D770", VA = "0xF9D770")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xF9D7AC", Offset = "0xF9D7AC", VA = "0xF9D7AC")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xF9D634", Offset = "0xF9D634", VA = "0xF9D634")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xF9D810", Offset = "0xF9D810", VA = "0xF9D810", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xF9D904", Offset = "0xF9D904", VA = "0xF9D904", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xF9D94C", Offset = "0xF9D94C", VA = "0xF9D94C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xF9D950", Offset = "0xF9D950", VA = "0xF9D950")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xF9D9A8", Offset = "0xF9D9A8", VA = "0xF9D9A8")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xFA10AC", Offset = "0xFA10AC", VA = "0xFA10AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xFA10BC", Offset = "0xFA10BC", VA = "0xFA10BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xFA10B4", Offset = "0xFA10B4", VA = "0xFA10B4")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xFA11D0", Offset = "0xFA11D0", VA = "0xFA11D0")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xFA148C", Offset = "0xFA148C", VA = "0xFA148C")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x200013E")]
		public enum AxisOptions
		{
			[Token(Token = "0x4000881")]
			ForwardAxis,
			[Token(Token = "0x4000882")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x200013F")]
		public class AxisMapping
		{
			[Token(Token = "0x20001AD")]
			public enum MappingType
			{
				[Token(Token = "0x4000B42")]
				NamedAxis,
				[Token(Token = "0x4000B43")]
				MousePositionX,
				[Token(Token = "0x4000B44")]
				MousePositionY,
				[Token(Token = "0x4000B45")]
				MousePositionZ
			}

			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x12F5E54", Offset = "0x12F5E54", VA = "0x12F5E54")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xEAD52C", Offset = "0xEAD52C", VA = "0xEAD52C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xEAD5F0", Offset = "0xEAD5F0", VA = "0xEAD5F0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xEAD818", Offset = "0xEAD818", VA = "0xEAD818")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xEAD834", Offset = "0xEAD834", VA = "0xEAD834")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD558", Offset = "0x5BD558")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000140")]
		public enum AxisOption
		{
			[Token(Token = "0x4000886")]
			Both,
			[Token(Token = "0x4000887")]
			OnlyHorizontal,
			[Token(Token = "0x4000888")]
			OnlyVertical
		}

		[Token(Token = "0x2000141")]
		public enum ControlStyle
		{
			[Token(Token = "0x400088A")]
			Absolute,
			[Token(Token = "0x400088B")]
			Relative,
			[Token(Token = "0x400088C")]
			Swipe
		}

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xEADC14", Offset = "0xEADC14", VA = "0xEADC14")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xEADD54", Offset = "0xEADD54", VA = "0xEADD54")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xEADC18", Offset = "0xEADC18", VA = "0xEADC18")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xEADDCC", Offset = "0xEADDCC", VA = "0xEADDCC")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xEADE38", Offset = "0xEADE38", VA = "0xEADE38", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xEADE70", Offset = "0xEADE70", VA = "0xEADE70")]
		private void Update()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xEADFB8", Offset = "0xEADFB8", VA = "0xEADFB8", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xEADFEC", Offset = "0xEADFEC", VA = "0xEADFEC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xEAE0EC", Offset = "0xEAE0EC", VA = "0xEAE0EC")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE988", Offset = "0x5BE988")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x17000007")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0xEB663C", Offset = "0xEB663C", VA = "0xEB663C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8094", Offset = "0x5C8094")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xEB6648", Offset = "0xEB6648", VA = "0xEB6648")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C80A4", Offset = "0x5C80A4")]
			private set
			{
			}
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xEB6654", Offset = "0xEB6654", VA = "0xEB6654")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xEB66B8", Offset = "0xEB66B8", VA = "0xEB66B8")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xEB671C", Offset = "0xEB671C", VA = "0xEB671C")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xEB687C", Offset = "0xEB687C", VA = "0xEB687C")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xEB69DC", Offset = "0xEB69DC", VA = "0xEB69DC")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xEB6A7C", Offset = "0xEB6A7C", VA = "0xEB6A7C")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xEB6B1C", Offset = "0xEB6B1C", VA = "0xEB6B1C")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xEB6BB8", Offset = "0xEB6BB8", VA = "0xEB6BB8")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xEB6BC0", Offset = "0xEB6BC0", VA = "0xEB6BC0")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xEB6BC8", Offset = "0xEB6BC8", VA = "0xEB6BC8")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x60000FC")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x60000FD")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x60000FE")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x60000FF")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x6000100")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000101")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000102")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000103")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x6000104")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000105")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000106")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xEABCC0", Offset = "0xEABCC0", VA = "0xEABCC0")]
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
		[Token(Token = "0x6000108")]
		[Address(RVA = "0xFA1494", Offset = "0xFA1494", VA = "0xFA1494")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xFA1524", Offset = "0xFA1524", VA = "0xFA1524")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xFA15B4", Offset = "0xFA15B4", VA = "0xFA15B4", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xFA1658", Offset = "0xFA1658", VA = "0xFA1658", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xFA16FC", Offset = "0xFA16FC", VA = "0xFA16FC", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xFA17A0", Offset = "0xFA17A0", VA = "0xFA17A0", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xFA1848", Offset = "0xFA1848", VA = "0xFA1848", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xFA18F0", Offset = "0xFA18F0", VA = "0xFA18F0", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xFA1994", Offset = "0xFA1994", VA = "0xFA1994", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xFA1A44", Offset = "0xFA1A44", VA = "0xFA1A44", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xFA1AE8", Offset = "0xFA1AE8", VA = "0xFA1AE8", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xFA1B8C", Offset = "0xFA1B8C", VA = "0xFA1B8C", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xFA1C30", Offset = "0xFA1C30", VA = "0xFA1C30", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xFA1C3C", Offset = "0xFA1C3C", VA = "0xFA1C3C")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000116")]
		[Address(RVA = "0xEABA84", Offset = "0xEABA84", VA = "0xEABA84", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xEABA98", Offset = "0xEABA98", VA = "0xEABA98", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xEABAA4", Offset = "0xEABAA4", VA = "0xEABAA4", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xEABAB0", Offset = "0xEABAB0", VA = "0xEABAB0", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xEABABC", Offset = "0xEABABC", VA = "0xEABABC", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xEABB10", Offset = "0xEABB10", VA = "0xEABB10", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xEABB64", Offset = "0xEABB64", VA = "0xEABB64", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xEABBB8", Offset = "0xEABBB8", VA = "0xEABBB8", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xEABC0C", Offset = "0xEABC0C", VA = "0xEABC0C", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xEABC60", Offset = "0xEABC60", VA = "0xEABC60", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xEABCB4", Offset = "0xEABCB4", VA = "0xEABCB4", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xEABCBC", Offset = "0xEABCBC", VA = "0xEABCBC")]
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
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CarController car;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Renderer m_Renderer;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x122DD50", Offset = "0x122DD50", VA = "0x122DD50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x122DDA4", Offset = "0x122DDA4", VA = "0x122DDA4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x122DDD8", Offset = "0x122DDD8", VA = "0x122DDD8")]
		public BrakeLight()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD5B8", Offset = "0x5BD5B8")]
	public class CarAIControl : MonoBehaviour
	{
		[Token(Token = "0x2000142")]
		public enum BrakeCondition
		{
			[Token(Token = "0x400088E")]
			NeverBrake,
			[Token(Token = "0x400088F")]
			TargetDirectionDifference,
			[Token(Token = "0x4000890")]
			TargetDistance
		}

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BE998", Offset = "0x5BE998")]
		private float m_CautiousSpeedFactor;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BE9D8", Offset = "0x5BE9D8")]
		private float m_CautiousMaxAngle;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_CautiousMaxDistance;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_CautiousAngularVelocityFactor;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_SteerSensitivity;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_AccelSensitivity;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_BrakeSensitivity;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_LateralWanderDistance;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_LateralWanderSpeed;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BEA8C", Offset = "0x5BEA8C")]
		private float m_AccelWanderAmount;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_AccelWanderSpeed;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private BrakeCondition m_BrakeCondition;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool m_Driving;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform m_Target;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_StopWhenTargetReached;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_ReachTargetThreshold;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float m_RandomPerlin;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CarController m_CarController;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_AvoidOtherCarTime;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float m_AvoidOtherCarSlowdown;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float m_AvoidPathOffset;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x122FB38", Offset = "0x122FB38", VA = "0x122FB38")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x122FBC8", Offset = "0x122FBC8", VA = "0x122FBC8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1230380", Offset = "0x1230380", VA = "0x1230380")]
		private void OnCollisionStay(Collision col)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x123059C", Offset = "0x123059C", VA = "0x123059C")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x12305AC", Offset = "0x12305AC", VA = "0x12305AC")]
		public CarAIControl()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD618", Offset = "0x5BD618")]
	public class CarAudio : MonoBehaviour
	{
		[Token(Token = "0x2000143")]
		public enum EngineAudioOptions
		{
			[Token(Token = "0x4000892")]
			Simple,
			[Token(Token = "0x4000893")]
			FourChannel
		}

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EngineAudioOptions engineSoundStyle;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BEB2C", Offset = "0x5BEB2C")]
		public float m_carVolume;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool m_useTireSkidAudio;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BEB44", Offset = "0x5BEB44")]
		public float m_tireVolume;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip lowAccelClip;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip lowDecelClip;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip highAccelClip;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip highDecelClip;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float pitchMultiplier;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float lowPitchMin;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float lowPitchMax;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float highPitchMultiplier;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxRolloffDistance;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float dopplerLevel;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool useDoppler;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AudioSource m_LowAccel;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AudioSource m_LowDecel;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private AudioSource m_HighAccel;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AudioSource m_HighDecel;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_StartedSound;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private CarController m_CarController;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float m_currentTireVolume;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool m_currentUseTireSkidAudio;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private WheelEffects[] m_wheels;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x12305F4", Offset = "0x12305F4", VA = "0x12305F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x12306E4", Offset = "0x12306E4", VA = "0x12306E4")]
		private void StartSound()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1230898", Offset = "0x1230898", VA = "0x1230898")]
		private void StopSound()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1230980", Offset = "0x1230980", VA = "0x1230980")]
		private void Update()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x123078C", Offset = "0x123078C", VA = "0x123078C")]
		private AudioSource SetUpEngineAudioSource(AudioClip clip)
		{
			return null;
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1230D5C", Offset = "0x1230D5C", VA = "0x1230D5C")]
		private static float ULerp(float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1230608", Offset = "0x1230608", VA = "0x1230608")]
		private void UpdateVolume()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1230D74", Offset = "0x1230D74", VA = "0x1230D74")]
		public CarAudio()
		{
		}
	}
	[Token(Token = "0x200003C")]
	internal enum CarDriveType
	{
		[Token(Token = "0x4000124")]
		FrontWheelDrive,
		[Token(Token = "0x4000125")]
		RearWheelDrive,
		[Token(Token = "0x4000126")]
		FourWheelDrive
	}
	[Token(Token = "0x200003D")]
	internal enum SpeedType
	{
		[Token(Token = "0x4000128")]
		MPH,
		[Token(Token = "0x4000129")]
		KPH
	}
	[Token(Token = "0x200003E")]
	public class CarController : MonoBehaviour
	{
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CarDriveType m_CarDriveType;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WheelCollider[] m_WheelColliders;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] m_WheelMeshes;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private WheelEffects[] m_WheelEffects;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector3 m_CentreOfMassOffset;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_MaximumSteerAngle;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BEBBC", Offset = "0x5BEBBC")]
		[SerializeField]
		private float m_SteerHelper;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BEBFC", Offset = "0x5BEBFC")]
		[SerializeField]
		private float m_TractionControl;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_FullTorqueOverAllWheels;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_ReverseTorque;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_MaxHandbrakeTorque;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_Downforce;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SpeedType m_SpeedType;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_Topspeed;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private static int NoOfGears;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_RevRangeBoundary;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_SlipLimit;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float m_BrakeTorque;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion[] m_WheelMeshLocalRotations;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Prevpos;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 m_Pos;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float m_SteerAngle;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int m_GearNum;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float m_GearFactor;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float m_OldRotation;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float m_CurrentTorque;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000145")]
		private const float k_ReversingThreshold = 0.01f;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BECDC", Offset = "0x5BECDC")]
		private bool <Skidding>k__BackingField;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BECEC", Offset = "0x5BECEC")]
		private float <BrakeInput>k__BackingField;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BECFC", Offset = "0x5BECFC")]
		private float <Revs>k__BackingField;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BED0C", Offset = "0x5BED0C")]
		private float <AccelInput>k__BackingField;

		[Token(Token = "0x17000008")]
		public bool Skidding
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x1230DB0", Offset = "0x1230DB0", VA = "0x1230DB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C80B4", Offset = "0x5C80B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x1230DB8", Offset = "0x1230DB8", VA = "0x1230DB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C80C4", Offset = "0x5C80C4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public float BrakeInput
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x1230DC4", Offset = "0x1230DC4", VA = "0x1230DC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C80D4", Offset = "0x5C80D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x1230DCC", Offset = "0x1230DCC", VA = "0x1230DCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C80E4", Offset = "0x5C80E4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public float CurrentSteerAngle
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x1230DD4", Offset = "0x1230DD4", VA = "0x1230DD4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000B")]
		public float CurrentSpeed
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x123032C", Offset = "0x123032C", VA = "0x123032C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000C")]
		public float MaxSpeed
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x1230DDC", Offset = "0x1230DDC", VA = "0x1230DDC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000D")]
		public float Revs
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x1230DE4", Offset = "0x1230DE4", VA = "0x1230DE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C80F4", Offset = "0x5C80F4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x1230DEC", Offset = "0x1230DEC", VA = "0x1230DEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8104", Offset = "0x5C8104")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public float AccelInput
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x1230DF4", Offset = "0x1230DF4", VA = "0x1230DF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8114", Offset = "0x5C8114")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x1230DFC", Offset = "0x1230DFC", VA = "0x1230DFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8124", Offset = "0x5C8124")]
			private set
			{
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1230E04", Offset = "0x1230E04", VA = "0x1230E04")]
		private void Start()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1230F58", Offset = "0x1230F58", VA = "0x1230F58")]
		private void GearChanging()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1231068", Offset = "0x1231068", VA = "0x1231068")]
		private static float CurveFactor(float factor)
		{
			return default(float);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x123107C", Offset = "0x123107C", VA = "0x123107C")]
		private static float ULerp(float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1231094", Offset = "0x1231094", VA = "0x1231094")]
		private void CalculateGearFactor()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1231174", Offset = "0x1231174", VA = "0x1231174")]
		private void CalculateRevs()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x123009C", Offset = "0x123009C", VA = "0x123009C")]
		public void Move(float steering, float accel, float footbrake, float handbrake)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1231678", Offset = "0x1231678", VA = "0x1231678")]
		private void CapSpeed()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x123140C", Offset = "0x123140C", VA = "0x123140C")]
		private void ApplyDrive(float accel, float footbrake)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1231244", Offset = "0x1231244", VA = "0x1231244")]
		private void SteerHelper()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x123174C", Offset = "0x123174C", VA = "0x123174C")]
		private void AddDownForce()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1231850", Offset = "0x1231850", VA = "0x1231850")]
		private void CheckForWheelSpin()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x12319E0", Offset = "0x12319E0", VA = "0x12319E0")]
		private void TractionControl()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1231CB4", Offset = "0x1231CB4", VA = "0x1231CB4")]
		private void AdjustTorque(float forwardSlip)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1231C48", Offset = "0x1231C48", VA = "0x1231C48")]
		private bool AnySkidSoundPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1231CFC", Offset = "0x1231CFC", VA = "0x1231CFC")]
		public CarController()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class CarSelfRighting : MonoBehaviour
	{
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_WaitTime;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_VelocityThreshold;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_LastOkTime;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1231E0C", Offset = "0x1231E0C", VA = "0x1231E0C")]
		private void Start()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1231E60", Offset = "0x1231E60", VA = "0x1231E60")]
		private void Update()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1231F0C", Offset = "0x1231F0C", VA = "0x1231F0C")]
		private void RightCar()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1231FBC", Offset = "0x1231FBC", VA = "0x1231FBC")]
		public CarSelfRighting()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD678", Offset = "0x5BD678")]
	public class CarUserControl : MonoBehaviour
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CarController m_Car;

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1231FD0", Offset = "0x1231FD0", VA = "0x1231FD0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1232024", Offset = "0x1232024", VA = "0x1232024")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1232144", Offset = "0x1232144", VA = "0x1232144")]
		public CarUserControl()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class Mudguard : MonoBehaviour
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CarController carController;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xFA2860", Offset = "0xFA2860", VA = "0xFA2860")]
		private void Start()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xFA289C", Offset = "0xFA289C", VA = "0xFA289C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xFA2930", Offset = "0xFA2930", VA = "0xFA2930")]
		public Mudguard()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class SkidTrail : MonoBehaviour
	{
		[Token(Token = "0x2000144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE748", Offset = "0x5BE748")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SkidTrail <>4__this;

			[Token(Token = "0x170000BD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008AB")]
				[Address(RVA = "0x12F5C5C", Offset = "0x12F5C5C", VA = "0x12F5C5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008AD")]
				[Address(RVA = "0x12F5CA4", Offset = "0x12F5CA4", VA = "0x12F5CA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x12F5AFC", Offset = "0x12F5AFC", VA = "0x12F5AFC")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x12F5B28", Offset = "0x12F5B28", VA = "0x12F5B28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x12F5B2C", Offset = "0x12F5B2C", VA = "0x12F5B2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x12F5C64", Offset = "0x12F5C64", VA = "0x12F5C64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_PersistTime;

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xEAAB54", Offset = "0xEAAB54", VA = "0xEAAB54")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C8134", Offset = "0x5C8134")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xEAABC0", Offset = "0xEAABC0", VA = "0xEAABC0")]
		public SkidTrail()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class Suspension : MonoBehaviour
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject wheel;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 m_TargetOriginalPosition;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_Origin;

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xEABDB8", Offset = "0xEABDB8", VA = "0xEABDB8")]
		private void Start()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xEABE1C", Offset = "0xEABE1C", VA = "0xEABE1C")]
		private void Update()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xEABEAC", Offset = "0xEABEAC", VA = "0xEABEAC")]
		public Suspension()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD6D8", Offset = "0x5BD6D8")]
	public class WheelEffects : MonoBehaviour
	{
		[Token(Token = "0x2000145")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE758", Offset = "0x5BE758")]
		private sealed class <StartSkidTrail>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WheelEffects <>4__this;

			[Token(Token = "0x170000BF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008B1")]
				[Address(RVA = "0x12F8774", Offset = "0x12F8774", VA = "0x12F8774", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008B3")]
				[Address(RVA = "0x12F87BC", Offset = "0x12F87BC", VA = "0x12F87BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x12F85B4", Offset = "0x12F85B4", VA = "0x12F85B4")]
			[DebuggerHidden]
			public <StartSkidTrail>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x12F85E0", Offset = "0x12F85E0", VA = "0x12F85E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x12F85E4", Offset = "0x12F85E4", VA = "0x12F85E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x12F877C", Offset = "0x12F877C", VA = "0x12F877C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform SkidTrailPrefab;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Transform skidTrailsDetachedParent;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleSystem skidParticles;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BED4C", Offset = "0x5BED4C")]
		private bool <skidding>k__BackingField;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BED5C", Offset = "0x5BED5C")]
		private bool <PlayingAudio>k__BackingField;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool m_useSkidAudio;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_SkidTrail;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WheelCollider m_WheelCollider;

		[Token(Token = "0x1700000F")]
		public bool skidding
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x112175C", Offset = "0x112175C", VA = "0x112175C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8194", Offset = "0x5C8194")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x1121764", Offset = "0x1121764", VA = "0x1121764")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C81A4", Offset = "0x5C81A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public bool PlayingAudio
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x1121770", Offset = "0x1121770", VA = "0x1121770")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C81B4", Offset = "0x5C81B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x1121778", Offset = "0x1121778", VA = "0x1121778")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C81C4", Offset = "0x5C81C4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1121784", Offset = "0x1121784", VA = "0x1121784")]
		private void Start()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x11219E4", Offset = "0x11219E4", VA = "0x11219E4")]
		public void SetVolume(float volume, bool useAudio)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1121AA0", Offset = "0x1121AA0", VA = "0x1121AA0")]
		public void EmitTyreSmoke()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1121C20", Offset = "0x1121C20", VA = "0x1121C20")]
		public void PlayAudio()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1121C60", Offset = "0x1121C60", VA = "0x1121C60")]
		public void StopAudio()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1121BB4", Offset = "0x1121BB4", VA = "0x1121BB4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C81D4", Offset = "0x5C81D4")]
		private IEnumerator StartSkidTrail()
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1121C94", Offset = "0x1121C94", VA = "0x1121C94")]
		public void EndSkidTrail()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1121D60", Offset = "0x1121D60", VA = "0x1121D60")]
		public WheelEffects()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Aeroplane
{
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD738", Offset = "0x5BD738")]
	public class AeroplaneAiControl : MonoBehaviour
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_RollSensitivity;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_PitchSensitivity;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_LateralWanderDistance;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_LateralWanderSpeed;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_MaxClimbAngle;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MaxRollAngle;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_SpeedEffect;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_TakeoffHeight;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform m_Target;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AeroplaneController m_AeroplaneController;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_RandomPerlin;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool m_TakenOff;

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x10B78C4", Offset = "0x10B78C4", VA = "0x10B78C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x10B7930", Offset = "0x10B7930", VA = "0x10B7930")]
		public void Reset()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x10B7938", Offset = "0x10B7938", VA = "0x10B7938")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x10B7BF4", Offset = "0x10B7BF4", VA = "0x10B7BF4")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x10B7BFC", Offset = "0x10B7BFC", VA = "0x10B7BFC")]
		public AeroplaneAiControl()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class AeroplaneAudio : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000146")]
		public class AdvancedSetttings
		{
			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float engineMinDistance;

			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float engineMaxDistance;

			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float engineDopplerLevel;

			[Token(Token = "0x400089D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C4574", Offset = "0x5C4574")]
			public float engineMasterVolume;

			[Token(Token = "0x400089E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float windMinDistance;

			[Token(Token = "0x400089F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float windMaxDistance;

			[Token(Token = "0x40008A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float windDopplerLevel;

			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C458C", Offset = "0x5C458C")]
			public float windMasterVolume;

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x1121D68", Offset = "0x1121D68", VA = "0x1121D68")]
			public AdvancedSetttings()
			{
			}
		}

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioClip m_EngineSound;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_EngineMinThrottlePitch;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_EngineMaxThrottlePitch;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_EngineFwdSpeedMultiplier;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip m_WindSound;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_WindBasePitch;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_WindSpeedPitchFactor;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_WindMaxSpeedVolume;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AdvancedSetttings m_AdvancedSetttings;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AudioSource m_EngineSoundSource;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AudioSource m_WindSoundSource;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x10B7C1C", Offset = "0x10B7C1C", VA = "0x10B7C1C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x10B7E20", Offset = "0x10B7E20", VA = "0x10B7E20")]
		private void Update()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x10B7F94", Offset = "0x10B7F94", VA = "0x10B7F94")]
		public AeroplaneAudio()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class AeroplaneControlSurfaceAnimator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000147")]
		public class ControlSurface
		{
			[Token(Token = "0x20001AE")]
			public enum Type
			{
				[Token(Token = "0x4000B47")]
				Aileron,
				[Token(Token = "0x4000B48")]
				Elevator,
				[Token(Token = "0x4000B49")]
				Rudder,
				[Token(Token = "0x4000B4A")]
				RuddervatorNegative,
				[Token(Token = "0x4000B4B")]
				RuddervatorPositive
			}

			[Token(Token = "0x40008A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float amount;

			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Type type;

			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[HideInInspector]
			public Quaternion originalLocalRotation;

			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x1121D84", Offset = "0x1121D84", VA = "0x1121D84")]
			public ControlSurface()
			{
			}
		}

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Smoothing;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ControlSurface[] m_ControlSurfaces;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x10B8024", Offset = "0x10B8024", VA = "0x10B8024")]
		private void Start()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x10B80E4", Offset = "0x10B80E4", VA = "0x10B80E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x10B821C", Offset = "0x10B821C", VA = "0x10B821C")]
		private void RotateSurface(ControlSurface surface, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x10B8304", Offset = "0x10B8304", VA = "0x10B8304")]
		public AeroplaneControlSurfaceAnimator()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD798", Offset = "0x5BD798")]
	public class AeroplaneController : MonoBehaviour
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MaxEnginePower;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_Lift;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_ZeroLiftSpeed;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_RollEffect;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_PitchEffect;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_YawEffect;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_BankedTurnEffect;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_AerodynamicEffect;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_AutoTurnPitch;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_AutoRollLevel;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_AutoPitchLevel;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_AirBrakesEffect;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float m_ThrottleChangeSpeed;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_DragIncreaseFactor;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BEF8C", Offset = "0x5BEF8C")]
		private float <Altitude>k__BackingField;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BEF9C", Offset = "0x5BEF9C")]
		private float <Throttle>k__BackingField;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BEFAC", Offset = "0x5BEFAC")]
		private bool <AirBrakes>k__BackingField;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BEFBC", Offset = "0x5BEFBC")]
		private float <ForwardSpeed>k__BackingField;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BEFCC", Offset = "0x5BEFCC")]
		private float <EnginePower>k__BackingField;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BEFDC", Offset = "0x5BEFDC")]
		private float <RollAngle>k__BackingField;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BEFEC", Offset = "0x5BEFEC")]
		private float <PitchAngle>k__BackingField;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BEFFC", Offset = "0x5BEFFC")]
		private float <RollInput>k__BackingField;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF00C", Offset = "0x5BF00C")]
		private float <PitchInput>k__BackingField;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF01C", Offset = "0x5BF01C")]
		private float <YawInput>k__BackingField;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF02C", Offset = "0x5BF02C")]
		private float <ThrottleInput>k__BackingField;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float m_OriginalDrag;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float m_OriginalAngularDrag;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float m_AeroFactor;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_Immobilized;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float m_BankedTurnAmount;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private WheelCollider[] m_WheelColliders;

		[Token(Token = "0x17000011")]
		public float Altitude
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x10B8314", Offset = "0x10B8314", VA = "0x10B8314")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8234", Offset = "0x5C8234")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x10B831C", Offset = "0x10B831C", VA = "0x10B831C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8244", Offset = "0x5C8244")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public float Throttle
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x10B8324", Offset = "0x10B8324", VA = "0x10B8324")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8254", Offset = "0x5C8254")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x10B832C", Offset = "0x10B832C", VA = "0x10B832C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8264", Offset = "0x5C8264")]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public bool AirBrakes
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x10B8334", Offset = "0x10B8334", VA = "0x10B8334")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8274", Offset = "0x5C8274")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x10B833C", Offset = "0x10B833C", VA = "0x10B833C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8284", Offset = "0x5C8284")]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public float ForwardSpeed
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x10B8348", Offset = "0x10B8348", VA = "0x10B8348")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8294", Offset = "0x5C8294")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x10B8350", Offset = "0x10B8350", VA = "0x10B8350")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C82A4", Offset = "0x5C82A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public float EnginePower
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x10B8358", Offset = "0x10B8358", VA = "0x10B8358")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C82B4", Offset = "0x5C82B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x10B8360", Offset = "0x10B8360", VA = "0x10B8360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C82C4", Offset = "0x5C82C4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public float MaxEnginePower
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x10B8368", Offset = "0x10B8368", VA = "0x10B8368")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000017")]
		public float RollAngle
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x10B8370", Offset = "0x10B8370", VA = "0x10B8370")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C82D4", Offset = "0x5C82D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x10B8378", Offset = "0x10B8378", VA = "0x10B8378")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C82E4", Offset = "0x5C82E4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public float PitchAngle
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x10B8380", Offset = "0x10B8380", VA = "0x10B8380")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C82F4", Offset = "0x5C82F4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x10B8388", Offset = "0x10B8388", VA = "0x10B8388")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8304", Offset = "0x5C8304")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public float RollInput
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x10B8390", Offset = "0x10B8390", VA = "0x10B8390")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8314", Offset = "0x5C8314")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x10B8398", Offset = "0x10B8398", VA = "0x10B8398")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8324", Offset = "0x5C8324")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public float PitchInput
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x10B83A0", Offset = "0x10B83A0", VA = "0x10B83A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8334", Offset = "0x5C8334")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x10B83A8", Offset = "0x10B83A8", VA = "0x10B83A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8344", Offset = "0x5C8344")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public float YawInput
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x10B83B0", Offset = "0x10B83B0", VA = "0x10B83B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8354", Offset = "0x5C8354")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x10B83B8", Offset = "0x10B83B8", VA = "0x10B83B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8364", Offset = "0x5C8364")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public float ThrottleInput
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x10B83C0", Offset = "0x10B83C0", VA = "0x10B83C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8374", Offset = "0x5C8374")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x10B83C8", Offset = "0x10B83C8", VA = "0x10B83C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8384", Offset = "0x5C8384")]
			private set
			{
			}
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x10B83D0", Offset = "0x10B83D0", VA = "0x10B83D0")]
		private void Start()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x10B7B80", Offset = "0x10B7B80", VA = "0x10B7B80")]
		public void Move(float rollInput, float pitchInput, float yawInput, float throttleInput, bool airBrakes)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x10B8534", Offset = "0x10B8534", VA = "0x10B8534")]
		private void ClampInputs()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x10B85CC", Offset = "0x10B85CC", VA = "0x10B85CC")]
		private void CalculateRollAndPitchAngles()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x10B86D8", Offset = "0x10B86D8", VA = "0x10B86D8")]
		private void AutoLevel()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x10B874C", Offset = "0x10B874C", VA = "0x10B874C")]
		private void CalculateForwardSpeed()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x10B87B0", Offset = "0x10B87B0", VA = "0x10B87B0")]
		private void ControlThrottle()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x10B8824", Offset = "0x10B8824", VA = "0x10B8824")]
		private void CalculateDrag()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x10B88D0", Offset = "0x10B88D0", VA = "0x10B88D0")]
		private void CaluclateAerodynamicEffect()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x10B8B2C", Offset = "0x10B8B2C", VA = "0x10B8B2C")]
		private void CalculateLinearForces()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x10B8CAC", Offset = "0x10B8CAC", VA = "0x10B8CAC")]
		private void CalculateTorque()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x10B8E84", Offset = "0x10B8E84", VA = "0x10B8E84")]
		private void CalculateAltitude()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x10B8FA4", Offset = "0x10B8FA4", VA = "0x10B8FA4")]
		public void Immobilize()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x10B8FB0", Offset = "0x10B8FB0", VA = "0x10B8FB0")]
		public void Reset()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x10B8FB8", Offset = "0x10B8FB8", VA = "0x10B8FB8")]
		public AeroplaneController()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class AeroplanePropellerAnimator : MonoBehaviour
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_PropellorModel;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_PropellorBlur;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Texture2D[] m_PropellorBlurTextures;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BF06C", Offset = "0x5BF06C")]
		private float m_ThrottleBlurStart;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BF0AC", Offset = "0x5BF0AC")]
		private float m_ThrottleBlurEnd;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_MaxRpm;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_PropellorBlurState;

		[Token(Token = "0x40001A2")]
		private const float k_RpmToDps = 60f;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Renderer m_PropellorModelRenderer;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Renderer m_PropellorBlurRenderer;

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x10B8FF8", Offset = "0x10B8FF8", VA = "0x10B8FF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x10B90A8", Offset = "0x10B90A8", VA = "0x10B90A8")]
		private void Update()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x10B9228", Offset = "0x10B9228", VA = "0x10B9228")]
		public AeroplanePropellerAnimator()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD7F8", Offset = "0x5BD7F8")]
	public class AeroplaneUserControl2Axis : MonoBehaviour
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxRollAngle;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxPitchAngle;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AeroplaneController m_Aeroplane;

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x10B924C", Offset = "0x10B924C", VA = "0x10B924C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x10B92A0", Offset = "0x10B92A0", VA = "0x10B92A0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x10B93C0", Offset = "0x10B93C0", VA = "0x10B93C0")]
		private void AdjustInputForMobileControls(ref float roll, ref float pitch, ref float throttle)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x10B94A4", Offset = "0x10B94A4", VA = "0x10B94A4")]
		public AeroplaneUserControl2Axis()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD858", Offset = "0x5BD858")]
	public class AeroplaneUserControl4Axis : MonoBehaviour
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxRollAngle;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxPitchAngle;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AeroplaneController m_Aeroplane;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_Throttle;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool m_AirBrakes;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_Yaw;

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x10B94B8", Offset = "0x10B94B8", VA = "0x10B94B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x10B950C", Offset = "0x10B950C", VA = "0x10B950C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x10B965C", Offset = "0x10B965C", VA = "0x10B965C")]
		private void AdjustInputForMobileControls(ref float roll, ref float pitch, ref float throttle)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x10B9708", Offset = "0x10B9708", VA = "0x10B9708")]
		public AeroplaneUserControl4Axis()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD8B8", Offset = "0x5BD8B8")]
	public class JetParticleEffect : MonoBehaviour
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color minColour;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AeroplaneController m_Jet;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem m_System;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_OriginalStartSize;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_OriginalLifetime;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color m_OriginalStartColor;

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xF9D248", Offset = "0xF9D248", VA = "0xF9D248")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xF9D4F8", Offset = "0xF9D4F8", VA = "0xF9D4F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xF9D3B4", Offset = "0xF9D3B4", VA = "0xF9D3B4")]
		private AeroplaneController FindAeroplaneParent()
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xF9D628", Offset = "0xF9D628", VA = "0xF9D628")]
		public JetParticleEffect()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class LandingGear : MonoBehaviour
	{
		[Token(Token = "0x2000148")]
		private enum GearState
		{
			[Token(Token = "0x40008A7")]
			Raised = -1,
			[Token(Token = "0x40008A8")]
			Lowered = 1
		}

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float raiseAtAltitude;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float lowerAtAltitude;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GearState m_State;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator m_Animator;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xF9DAD4", Offset = "0xF9DAD4", VA = "0xF9DAD4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xF9DB70", Offset = "0xF9DB70", VA = "0xF9DB70")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xF9DC58", Offset = "0xF9DC58", VA = "0xF9DC58")]
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
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovePower;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_UseTorque;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MaxAngularVelocity;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x40001BE")]
		private const float k_GroundRayLength = 1f;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x10C1DD8", Offset = "0x10C1DD8", VA = "0x10C1DD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x10C1E48", Offset = "0x10C1E48", VA = "0x10C1E48")]
		public void Move(Vector3 moveDirection, bool jump)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x10C1F60", Offset = "0x10C1F60", VA = "0x10C1F60")]
		public Ball()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class BallUserControl : MonoBehaviour
	{
		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Ball ball;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 move;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform cam;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 camForward;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool jump;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x10C1F84", Offset = "0x10C1F84", VA = "0x10C1F84")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x10C2098", Offset = "0x10C2098", VA = "0x10C2098")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x10C2270", Offset = "0x10C2270", VA = "0x10C2270")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x10C22AC", Offset = "0x10C22AC", VA = "0x10C22AC")]
		public BallUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD918", Offset = "0x5BD918")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD918", Offset = "0x5BD918")]
	public class AICharacterControl : MonoBehaviour
	{
		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF13C", Offset = "0x5BF13C")]
		private NavMeshAgent <agent>k__BackingField;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF14C", Offset = "0x5BF14C")]
		private ThirdPersonCharacter <character>k__BackingField;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x1700001D")]
		public NavMeshAgent agent
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x10B6E24", Offset = "0x10B6E24", VA = "0x10B6E24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8394", Offset = "0x5C8394")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x10B6E2C", Offset = "0x10B6E2C", VA = "0x10B6E2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C83A4", Offset = "0x5C83A4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public ThirdPersonCharacter character
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x10B6E34", Offset = "0x10B6E34", VA = "0x10B6E34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C83B4", Offset = "0x5C83B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x10B6E3C", Offset = "0x10B6E3C", VA = "0x10B6E3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C83C4", Offset = "0x5C83C4")]
			private set
			{
			}
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x10B6E44", Offset = "0x10B6E44", VA = "0x10B6E44")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x10B6EE8", Offset = "0x10B6EE8", VA = "0x10B6EE8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x10B6FEC", Offset = "0x10B6FEC", VA = "0x10B6FEC")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x10B6FF4", Offset = "0x10B6FF4", VA = "0x10B6FF4")]
		public AICharacterControl()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD9AC", Offset = "0x5BD9AC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD9AC", Offset = "0x5BD9AC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BD9AC", Offset = "0x5BD9AC")]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovingTurnSpeed;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_StationaryTurnSpeed;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BF18C", Offset = "0x5BF18C")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_RunCycleLegOffset;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MoveSpeedMultiplier;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_AnimSpeedMultiplier;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_GroundCheckDistance;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator m_Animator;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_IsGrounded;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_OrigGroundCheckDistance;

		[Token(Token = "0x40001D4")]
		private const float k_Half = 0.5f;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_TurnAmount;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_ForwardAmount;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 m_GroundNormal;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_CapsuleHeight;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 m_CapsuleCenter;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_Crouching;

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xEAC5DC", Offset = "0xEAC5DC", VA = "0xEAC5DC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xEAC6C0", Offset = "0xEAC6C0", VA = "0xEAC6C0")]
		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xEACB2C", Offset = "0xEACB2C", VA = "0xEACB2C")]
		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xEACD14", Offset = "0xEACD14", VA = "0xEACD14")]
		private void PreventStandingInLowHeadroom()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xEACE5C", Offset = "0xEACE5C", VA = "0xEACE5C")]
		private void UpdateAnimator(Vector3 move)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xEACA88", Offset = "0xEACA88", VA = "0xEACA88")]
		private void HandleAirborneMovement()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xEAC968", Offset = "0xEAC968", VA = "0xEAC968")]
		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xEAC8F0", Offset = "0xEAC8F0", VA = "0xEAC8F0")]
		private void ApplyExtraTurnRotation()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xEAD0BC", Offset = "0xEAD0BC", VA = "0xEAD0BC")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xEAC7D8", Offset = "0xEAC7D8", VA = "0xEAC7D8")]
		private void CheckGroundStatus()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xEAD16C", Offset = "0xEAD16C", VA = "0xEAD16C")]
		public ThirdPersonCharacter()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BDA74", Offset = "0x5BDA74")]
	public class ThirdPersonUserControl : MonoBehaviour
	{
		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ThirdPersonCharacter m_Character;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_Cam;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 m_CamForward;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 m_Move;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_Jump;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xEAD18C", Offset = "0xEAD18C", VA = "0xEAD18C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xEAD2B4", Offset = "0xEAD2B4", VA = "0xEAD2B4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xEAD340", Offset = "0xEAD340", VA = "0xEAD340")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xEAD524", Offset = "0xEAD524", VA = "0xEAD524")]
		public ThirdPersonUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BDAD4", Offset = "0x5BDAD4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BDAD4", Offset = "0x5BDAD4")]
	public class FirstPersonController : MonoBehaviour
	{
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BF23C", Offset = "0x5BF23C")]
		private float m_RunstepLenghten;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MouseLook m_MouseLook;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FOVKick m_FovKick;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioClip m_JumpSound;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AudioClip m_LandSound;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Camera m_Camera;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_Jump;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float m_YRotation;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2 m_Input;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float m_StepCycle;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float m_NextStep;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private bool m_Jumping;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x11C1FA4", Offset = "0x11C1FA4", VA = "0x11C1FA4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x11C20B8", Offset = "0x11C20B8", VA = "0x11C20B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x11C2234", Offset = "0x11C2234", VA = "0x11C2234")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x11C2288", Offset = "0x11C2288", VA = "0x11C2288")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x11C26CC", Offset = "0x11C26CC", VA = "0x11C26CC")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x11C270C", Offset = "0x11C270C", VA = "0x11C270C")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x11C29D8", Offset = "0x11C29D8", VA = "0x11C29D8")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x11C2810", Offset = "0x11C2810", VA = "0x11C2810")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x11C2530", Offset = "0x11C2530", VA = "0x11C2530")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x11C21DC", Offset = "0x11C21DC", VA = "0x11C21DC")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x11C2B24", Offset = "0x11C2B24", VA = "0x11C2B24")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x11C2C60", Offset = "0x11C2C60", VA = "0x11C2C60")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class HeadBob : MonoBehaviour
	{
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera Camera;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurveControlledBob motionBob;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LerpControlledBob jumpAndLandingBob;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float StrideInterval;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BF34C", Offset = "0x5BF34C")]
		public float RunningStrideLengthen;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x11CBD14", Offset = "0x11CBD14", VA = "0x11CBD14")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x11CBD70", Offset = "0x11CBD70", VA = "0x11CBD70")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x11CBF7C", Offset = "0x11CBF7C", VA = "0x11CBF7C")]
		public HeadBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class MouseLook
	{
		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xFA23D8", Offset = "0xFA23D8", VA = "0xFA23D8")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xFA242C", Offset = "0xFA242C", VA = "0xFA242C")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xFA277C", Offset = "0xFA277C", VA = "0xFA277C")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xFA276C", Offset = "0xFA276C", VA = "0xFA276C")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xFA27B0", Offset = "0xFA27B0", VA = "0xFA27B0")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xFA2704", Offset = "0xFA2704", VA = "0xFA2704")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xFA282C", Offset = "0xFA282C", VA = "0xFA282C")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BDB68", Offset = "0x5BDB68")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BDB68", Offset = "0x5BDB68")]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000149")]
		public class MovementSettings
		{
			[Token(Token = "0x40008A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float ForwardSpeed;

			[Token(Token = "0x40008AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float BackwardSpeed;

			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float StrafeSpeed;

			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float RunMultiplier;

			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public KeyCode RunKey;

			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float JumpForce;

			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnimationCurve SlopeCurveModifier;

			[Token(Token = "0x40008B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public float CurrentTargetSpeed;

			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x12F54E8", Offset = "0x12F54E8", VA = "0x12F54E8")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x12F5578", Offset = "0x12F5578", VA = "0x12F5578")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200014A")]
		public class AdvancedSettings
		{
			[Token(Token = "0x40008B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x40008B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			[Token(Token = "0x40008B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool airControl;

			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C45C4", Offset = "0x5C45C4")]
			public float shellOffset;

			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x12F54CC", Offset = "0x12F54CC", VA = "0x12F54CC")]
			public AdvancedSettings()
			{
			}
		}

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera cam;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovementSettings movementSettings;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MouseLook mouseLook;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AdvancedSettings advancedSettings;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_YRotation;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_GroundContactNormal;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_Jump;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool m_Jumping;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		private bool m_IsGrounded;

		[Token(Token = "0x1700001F")]
		public Vector3 Velocity
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xFABC3C", Offset = "0xFABC3C", VA = "0xFABC3C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000020")]
		public bool Grounded
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xFABC58", Offset = "0xFABC58", VA = "0xFABC58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000021")]
		public bool Jumping
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xFABC60", Offset = "0xFABC60", VA = "0xFABC60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		public bool Running
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xFABC68", Offset = "0xFABC68", VA = "0xFABC68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xFABC70", Offset = "0xFABC70", VA = "0xFABC70")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xFABD24", Offset = "0xFABD24", VA = "0xFABD24")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xFABF30", Offset = "0xFABF30", VA = "0xFABF30")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xFAC464", Offset = "0xFAC464", VA = "0xFAC464")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xFAC4D8", Offset = "0xFAC4D8", VA = "0xFAC4D8")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xFAC394", Offset = "0xFAC394", VA = "0xFAC394")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xFABDBC", Offset = "0xFABDBC", VA = "0xFABDBC")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xFAC214", Offset = "0xFAC214", VA = "0xFAC214")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xFAC6B0", Offset = "0xFAC6B0", VA = "0xFAC6B0")]
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
		[Token(Token = "0x200014B")]
		public enum UpdateType
		{
			[Token(Token = "0x40008B7")]
			FixedUpdate,
			[Token(Token = "0x40008B8")]
			LateUpdate,
			[Token(Token = "0x40008B9")]
			ManualUpdate
		}

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform m_Target;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_AutoTargetPlayer;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UpdateType m_UpdateType;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x17000023")]
		public Transform Target
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x10B73F0", Offset = "0x10B73F0", VA = "0x10B73F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x10B6FFC", Offset = "0x10B6FFC", VA = "0x10B6FFC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x10B7170", Offset = "0x10B7170", VA = "0x10B7170")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x10B7240", Offset = "0x10B7240", VA = "0x10B7240")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x10B7314", Offset = "0x10B7314", VA = "0x10B7314")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x60001F2")]
		protected abstract void FollowTarget(float deltaTime);

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x10B70AC", Offset = "0x10B70AC", VA = "0x10B70AC")]
		public void FindAndTargetPlayer()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x10B73E8", Offset = "0x10B73E8", VA = "0x10B73E8", Slot = "6")]
		public virtual void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x10B73F8", Offset = "0x10B73F8", VA = "0x10B73F8")]
		protected AbstractTargetFollower()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[ExecuteInEditMode]
	public class AutoCam : PivotBasedCameraRig
	{
		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_RollSpeed;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_FollowVelocity;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool m_FollowTilt;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_SpinTurnLimit;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_TargetVelocityLowerLimit;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SmoothTurnTime;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_LastFlatAngle;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_CurrentTurnAmount;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_TurnSpeedVelocityChange;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 m_RollUp;

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x10BCDBC", Offset = "0x10BCDBC", VA = "0x10BCDBC", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x10BD1B8", Offset = "0x10BD1B8", VA = "0x10BD1B8")]
		public AutoCam()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class FreeLookCam : PivotBasedCameraRig
	{
		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BF424", Offset = "0x5BF424")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_TurnSmoothing;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_TiltMax;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_TiltMin;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_LockCursor;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool m_VerticalAutoReturn;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_LookAngle;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_TiltAngle;

		[Token(Token = "0x4000237")]
		private const float k_LookDistance = 100f;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 m_PivotEulers;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion m_PivotTargetRot;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion m_TransformTargetRot;

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x11C2F64", Offset = "0x11C2F64", VA = "0x11C2F64", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x11C3028", Offset = "0x11C3028", VA = "0x11C3028")]
		protected void Update()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x11C3364", Offset = "0x11C3364", VA = "0x11C3364")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x11C3388", Offset = "0x11C3388", VA = "0x11C3388", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x11C3088", Offset = "0x11C3088", VA = "0x11C3088")]
		private void HandleRotationMovement()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x11C34D0", Offset = "0x11C34D0", VA = "0x11C34D0")]
		public FreeLookCam()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class HandHeldCam : LookatTarget
	{
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SwaySpeed;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_BaseSwayAmount;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_TrackingSwayAmount;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BF4E4", Offset = "0x5BF4E4")]
		[SerializeField]
		private float m_TrackingBias;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x11CB4D4", Offset = "0x11CB4D4", VA = "0x11CB4D4", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x11CB614", Offset = "0x11CB614", VA = "0x11CB614")]
		public HandHeldCam()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class LookatTarget : AbstractTargetFollower
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 m_RotationRange;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_FollowSpeed;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Vector3 m_FollowVelocity;

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xF9F154", Offset = "0xF9F154", VA = "0xF9F154", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xF9F19C", Offset = "0xF9F19C", VA = "0xF9F19C", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xF9F3D4", Offset = "0xF9F3D4", VA = "0xF9F3D4")]
		public LookatTarget()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform m_Cam;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Transform m_Pivot;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Vector3 m_LastTargetPosition;

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xFA5BDC", Offset = "0xFA5BDC", VA = "0xFA5BDC", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xFA5C50", Offset = "0xFA5C50", VA = "0xFA5C50")]
		protected PivotBasedCameraRig()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		[Token(Token = "0x200014C")]
		public class RayHitComparer : IComparer
		{
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x12F471C", Offset = "0x12F471C", VA = "0x12F471C", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x12F4820", Offset = "0x12F4820", VA = "0x12F4820")]
			public RayHitComparer()
			{
			}
		}

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float clipMoveTime;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float returnTime;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sphereCastRadius;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool visualiseInEditor;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float closestDistance;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF544", Offset = "0x5BF544")]
		private bool <protecting>k__BackingField;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string dontClipTag;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Cam;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_Pivot;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_OriginalDist;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_MoveVelocity;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_CurrentDist;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Ray m_Ray;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RayHitComparer m_RayHitComparer;

		[Token(Token = "0x17000024")]
		public bool protecting
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0xFA84E0", Offset = "0xFA84E0", VA = "0xFA84E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C83D4", Offset = "0x5C83D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0xFA84E8", Offset = "0xFA84E8", VA = "0xFA84E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C83E4", Offset = "0x5C83E4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xFA84F4", Offset = "0xFA84F4", VA = "0xFA84F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xFA85D4", Offset = "0xFA85D4", VA = "0xFA85D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xFA8B30", Offset = "0xFA8B30", VA = "0xFA8B30")]
		public ProtectCameraFromWallClip()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class TargetFieldOfView : AbstractTargetFollower
	{
		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_FovAdjustTime;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_ZoomAmountMultiplier;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_IncludeEffectsInSize;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_BoundSize;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_FovAdjustVelocity;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_Cam;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform m_LastTarget;

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xEABF24", Offset = "0xEABF24", VA = "0xEABF24", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xEAC174", Offset = "0xEAC174", VA = "0xEAC174", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xEAC264", Offset = "0xEAC264", VA = "0xEAC264", Slot = "6")]
		public override void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xEABF94", Offset = "0xEABF94", VA = "0xEABF94")]
		public static float MaxBoundsExtent(Transform obj, bool includeEffects)
		{
			return default(float);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xEAC294", Offset = "0xEAC294", VA = "0xEAC294")]
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
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float damping;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float lookAheadFactor;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float lookAheadReturnSpeed;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float lookAheadMoveThreshold;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_OffsetZ;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 m_LastTargetPosition;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 m_CurrentVelocity;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_LookAheadPos;

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x122E7E8", Offset = "0x122E7E8", VA = "0x122E7E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x122E874", Offset = "0x122E874", VA = "0x122E874")]
		private void Update()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x122EA4C", Offset = "0x122EA4C", VA = "0x122EA4C")]
		public Camera2DFollow()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class CameraFollow : MonoBehaviour
	{
		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float xMargin;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMargin;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float xSmooth;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float ySmooth;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 maxXAndY;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 minXAndY;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Player;

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x122F6AC", Offset = "0x122F6AC", VA = "0x122F6AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x122F710", Offset = "0x122F710", VA = "0x122F710")]
		private bool CheckXMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x122F770", Offset = "0x122F770", VA = "0x122F770")]
		private bool CheckYMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x122F7D0", Offset = "0x122F7D0", VA = "0x122F7D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x122F7D4", Offset = "0x122F7D4", VA = "0x122F7D4")]
		private void TrackPlayer()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x122F964", Offset = "0x122F964", VA = "0x122F964")]
		public CameraFollow()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BDC0C", Offset = "0x5BDC0C")]
	public class Platformer2DUserControl : MonoBehaviour
	{
		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlatformerCharacter2D m_Character;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_Jump;

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xFA7C94", Offset = "0xFA7C94", VA = "0xFA7C94")]
		private void Awake()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xFA7CE8", Offset = "0xFA7CE8", VA = "0xFA7CE8")]
		private void Update()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xFA7D74", Offset = "0xFA7D74", VA = "0xFA7D74")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xFA80A8", Offset = "0xFA80A8", VA = "0xFA80A8")]
		public Platformer2DUserControl()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class PlatformerCharacter2D : MonoBehaviour
	{
		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MaxSpeed;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_JumpForce;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BF5A4", Offset = "0x5BF5A4")]
		[SerializeField]
		private float m_CrouchSpeed;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_AirControl;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask m_WhatIsGround;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform m_GroundCheck;

		[Token(Token = "0x4000275")]
		private const float k_GroundedRadius = 0.2f;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_Grounded;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_CeilingCheck;

		[Token(Token = "0x4000278")]
		private const float k_CeilingRadius = 0.01f;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator m_Anim;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody2D m_Rigidbody2D;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_FacingRight;

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xFA80B0", Offset = "0xFA80B0", VA = "0xFA80B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xFA8194", Offset = "0xFA8194", VA = "0xFA8194")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xFA7E20", Offset = "0xFA7E20", VA = "0xFA7E20")]
		public void Move(float move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xFA8378", Offset = "0xFA8378", VA = "0xFA8378")]
		private void Flip()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xFA83F4", Offset = "0xFA83F4", VA = "0xFA83F4")]
		public PlatformerCharacter2D()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class Restarter : MonoBehaviour
	{
		[Token(Token = "0x6000222")]
		[Address(RVA = "0xFABB70", Offset = "0xFABB70", VA = "0xFABB70")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xFABC34", Offset = "0xFABC34", VA = "0xFABC34")]
		public Restarter()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BDC6C", Offset = "0x5BDC6C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BDC6C", Offset = "0x5BDC6C")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014D")]
		public enum Mode
		{
			[Token(Token = "0x40008BB")]
			AnimationClips,
			[Token(Token = "0x40008BC")]
			AnimationStates,
			[Token(Token = "0x40008BD")]
			PlayableDirector,
			[Token(Token = "0x40008BE")]
			Realtime
		}

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF604", Offset = "0x5BF604")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BF604", Offset = "0x5BF604")]
		public int frameRate;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF65C", Offset = "0x5BF65C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BF65C", Offset = "0x5BF65C")]
		public float keyReductionError;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF6B4", Offset = "0x5BF6B4")]
		public Mode mode;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF6EC", Offset = "0x5BF6EC")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF724", Offset = "0x5BF724")]
		public string[] animationStates;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF75C", Offset = "0x5BF75C")]
		public bool loop;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF794", Offset = "0x5BF794")]
		public string saveToFolder;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF7CC", Offset = "0x5BF7CC")]
		public string appendName;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF804", Offset = "0x5BF804")]
		public string saveName;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF83C", Offset = "0x5BF83C")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF84C", Offset = "0x5BF84C")]
		private float <bakingProgress>k__BackingField;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF87C", Offset = "0x5BF87C")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000025")]
		public bool isBaking
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x10BEE94", Offset = "0x10BEE94", VA = "0x10BEE94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C84D4", Offset = "0x5C84D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x10BEE9C", Offset = "0x10BEE9C", VA = "0x10BEE9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C84E4", Offset = "0x5C84E4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public float bakingProgress
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x10BEEA8", Offset = "0x10BEEA8", VA = "0x10BEEA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C84F4", Offset = "0x5C84F4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x10BEEB0", Offset = "0x10BEEB0", VA = "0x10BEEB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8504", Offset = "0x5C8504")]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		protected float clipLength
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x10BEEB8", Offset = "0x10BEEB8", VA = "0x10BEEB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8514", Offset = "0x5C8514")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x10BEEC0", Offset = "0x10BEEC0", VA = "0x10BEEC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8524", Offset = "0x5C8524")]
			private set
			{
			}
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x10BED74", Offset = "0x10BED74", VA = "0x10BED74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C83F4", Offset = "0x5C83F4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x10BEDBC", Offset = "0x10BEDBC", VA = "0x10BEDBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C842C", Offset = "0x5C842C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x10BEE04", Offset = "0x10BEE04", VA = "0x10BEE04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8464", Offset = "0x5C8464")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x10BEE4C", Offset = "0x10BEE4C", VA = "0x10BEE4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C849C", Offset = "0x5C849C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600022C")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x600022D")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x600022E")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x600022F")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x6000230")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x10BEEC8", Offset = "0x10BEEC8", VA = "0x10BEEC8")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x10BEECC", Offset = "0x10BEECC", VA = "0x10BEECC")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x10BEED0", Offset = "0x10BEED0", VA = "0x10BEED0")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x10BEED4", Offset = "0x10BEED4", VA = "0x10BEED4")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF88C", Offset = "0x5BF88C")]
		public bool markAsLegacy;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF8C4", Offset = "0x5BF8C4")]
		public Transform root;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF8FC", Offset = "0x5BF8FC")]
		public Transform rootNode;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF934", Offset = "0x5BF934")]
		public Transform[] ignoreList;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF96C", Offset = "0x5BF96C")]
		public Transform[] bakePositionList;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x11C3CC4", Offset = "0x11C3CC4", VA = "0x11C3CC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x11C40B4", Offset = "0x11C40B4", VA = "0x11C40B4", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x11C40BC", Offset = "0x11C40BC", VA = "0x11C40BC", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x11C41CC", Offset = "0x11C41CC", VA = "0x11C41CC", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x11C4248", Offset = "0x11C4248", VA = "0x11C4248", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x11C42C4", Offset = "0x11C42C4", VA = "0x11C42C4", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x11C3F0C", Offset = "0x11C3F0C", VA = "0x11C3F0C")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x11C3FE0", Offset = "0x11C3FE0", VA = "0x11C3FE0")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x11C4340", Offset = "0x11C4340", VA = "0x11C4340")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class TQ
	{
		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xEABEB4", Offset = "0xEABEB4", VA = "0xEABEB4")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class AvatarUtility
	{
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x10BDD34", Offset = "0x10BDD34", VA = "0x10BDD34")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x10BDF90", Offset = "0x10BDF90", VA = "0x10BDF90")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x10BDF70", Offset = "0x10BDF70", VA = "0x10BDF70")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x10BE53C", Offset = "0x10BE53C", VA = "0x10BE53C")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x10C0150", Offset = "0x10C0150", VA = "0x10C0150")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x10C1A08", Offset = "0x10C1A08", VA = "0x10C1A08")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x10BFBA4", Offset = "0x10BFBA4", VA = "0x10BFBA4")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x10C0198", Offset = "0x10C0198", VA = "0x10C0198")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x10BF6D4", Offset = "0x10BF6D4", VA = "0x10BF6D4")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x10BEFC0", Offset = "0x10BEFC0", VA = "0x10BEFC0")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x10BF22C", Offset = "0x10BF22C", VA = "0x10BF22C")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x10BF124", Offset = "0x10BF124", VA = "0x10BF124")]
		public void Reset()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x10BF3A8", Offset = "0x10BF3A8", VA = "0x10BF3A8")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x10BF938", Offset = "0x10BF938", VA = "0x10BF938")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x10BFA34", Offset = "0x10BFA34", VA = "0x10BFA34")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x10BFB30", Offset = "0x10BFB30", VA = "0x10BFB30")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x10BFAA8", Offset = "0x10BFAA8", VA = "0x10BFAA8")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x10BFD9C", Offset = "0x10BFD9C", VA = "0x10BFD9C")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x10BFE50", Offset = "0x10BFE50", VA = "0x10BFE50")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class BakerMuscle
	{
		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x10C019C", Offset = "0x10C019C", VA = "0x10C019C")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x10C020C", Offset = "0x10C020C", VA = "0x10C020C")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x10C0CA0", Offset = "0x10C0CA0", VA = "0x10C0CA0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x10C0D54", Offset = "0x10C0D54", VA = "0x10C0D54")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x10C0C44", Offset = "0x10C0C44", VA = "0x10C0C44")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x10C0E4C", Offset = "0x10C0E4C", VA = "0x10C0E4C")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x10C0E94", Offset = "0x10C0E94", VA = "0x10C0E94")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public class BakerTransform
	{
		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x10C0E9C", Offset = "0x10C0E9C", VA = "0x10C0E9C")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x10C1028", Offset = "0x10C1028", VA = "0x10C1028")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x10C103C", Offset = "0x10C103C", VA = "0x10C103C")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x10C1328", Offset = "0x10C1328", VA = "0x10C1328")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x10C0F34", Offset = "0x10C0F34", VA = "0x10C0F34")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x10C15DC", Offset = "0x10C15DC", VA = "0x10C15DC")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x10C1650", Offset = "0x10C1650", VA = "0x10C1650")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x10C1804", Offset = "0x10C1804", VA = "0x10C1804")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF9A4", Offset = "0x5BF9A4")]
		public bool bakeHandIK;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF9DC", Offset = "0x5BF9DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BF9DC", Offset = "0x5BF9DC")]
		public float IKKeyReductionError;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BFA34", Offset = "0x5BFA34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BFA34", Offset = "0x5BFA34")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x12C042C", Offset = "0x12C042C", VA = "0x12C042C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x12C0908", Offset = "0x12C0908", VA = "0x12C0908", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x12C0924", Offset = "0x12C0924", VA = "0x12C0924", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x12C0A00", Offset = "0x12C0A00", VA = "0x12C0A00", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x12C0ADC", Offset = "0x12C0ADC", VA = "0x12C0ADC", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x12C0CAC", Offset = "0x12C0CAC", VA = "0x12C0CAC", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x12C0FE4", Offset = "0x12C0FE4", VA = "0x12C0FE4")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x12C10C0", Offset = "0x12C10C0", VA = "0x12C10C0")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014E")]
		public enum UpdateMode
		{
			[Token(Token = "0x40008C0")]
			Update,
			[Token(Token = "0x40008C1")]
			FixedUpdate,
			[Token(Token = "0x40008C2")]
			LateUpdate,
			[Token(Token = "0x40008C3")]
			FixedLateUpdate
		}

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5BFA88", Offset = "0x5BFA88")]
		public bool smoothFollow;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5BFAC0", Offset = "0x5BFAC0")]
		public float rotationSensitivity;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5BFAF8", Offset = "0x5BFAF8")]
		public float distance;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5BFB30", Offset = "0x5BFB30")]
		public LayerMask blockingLayers;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float blockingOriginOffset;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BFB68", Offset = "0x5BFB68")]
		public float blockedOffset;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFB80", Offset = "0x5BFB80")]
		private float <x>k__BackingField;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFB90", Offset = "0x5BFB90")]
		private float <y>k__BackingField;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFBA0", Offset = "0x5BFBA0")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 targetDistance;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 position;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion rotation;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 smoothPosition;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000028")]
		public float x
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x122EA60", Offset = "0x122EA60", VA = "0x122EA60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8534", Offset = "0x5C8534")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x122EA68", Offset = "0x122EA68", VA = "0x122EA68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8544", Offset = "0x5C8544")]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public float y
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x122EA70", Offset = "0x122EA70", VA = "0x122EA70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8554", Offset = "0x5C8554")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x122EA78", Offset = "0x122EA78", VA = "0x122EA78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8564", Offset = "0x5C8564")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public float distanceTarget
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x122EA80", Offset = "0x122EA80", VA = "0x122EA80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8574", Offset = "0x5C8574")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x122EA88", Offset = "0x122EA88", VA = "0x122EA88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8584", Offset = "0x5C8584")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		private float zoomAdd
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x122F364", Offset = "0x122F364", VA = "0x122F364")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x122EA90", Offset = "0x122EA90", VA = "0x122EA90")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x122EACC", Offset = "0x122EACC", VA = "0x122EACC")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x122EAD4", Offset = "0x122EAD4", VA = "0x122EAD4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x122EBD8", Offset = "0x122EBD8", VA = "0x122EBD8", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x122EC34", Offset = "0x122EC34", VA = "0x122EC34", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x122EC9C", Offset = "0x122EC9C", VA = "0x122EC9C", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x122ED00", Offset = "0x122ED00", VA = "0x122ED00")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x122EC0C", Offset = "0x122EC0C", VA = "0x122EC0C")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x122EE80", Offset = "0x122EE80", VA = "0x122EE80")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x122F334", Offset = "0x122F334", VA = "0x122F334")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x122F3D4", Offset = "0x122F3D4", VA = "0x122F3D4")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x122F480", Offset = "0x122F480", VA = "0x122F480")]
		private void Awake()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x122F4B8", Offset = "0x122F4B8", VA = "0x122F4B8")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x122F660", Offset = "0x122F660", VA = "0x122F660")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x122F690", Offset = "0x122F690", VA = "0x122F690")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public enum Axis
	{
		[Token(Token = "0x40002F2")]
		X,
		[Token(Token = "0x40002F3")]
		Y,
		[Token(Token = "0x40002F4")]
		Z
	}
	[Token(Token = "0x2000070")]
	public class AxisTools
	{
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x10BE544", Offset = "0x10BE544", VA = "0x10BE544")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x10BE568", Offset = "0x10BE568", VA = "0x10BE568")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x10BE5A0", Offset = "0x10BE5A0", VA = "0x10BE5A0")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x10BE690", Offset = "0x10BE690", VA = "0x10BE690")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x10BE638", Offset = "0x10BE638", VA = "0x10BE638")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x10BE728", Offset = "0x10BE728", VA = "0x10BE728")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x10BE770", Offset = "0x10BE770", VA = "0x10BE770")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x10BE934", Offset = "0x10BE934", VA = "0x10BE934")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x200014F")]
		public class LimbOrientation
		{
			[Token(Token = "0x40008C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40008C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40008C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x1122444", Offset = "0x1122444", VA = "0x1122444")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x1700002C")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x10C3988", Offset = "0x10C3988", VA = "0x10C3988")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x10C3BF4", Offset = "0x10C3BF4", VA = "0x10C3BF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x10C393C", Offset = "0x10C393C", VA = "0x10C393C")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000072")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000150")]
		public enum BoneType
		{
			[Token(Token = "0x40008C8")]
			Unassigned,
			[Token(Token = "0x40008C9")]
			Spine,
			[Token(Token = "0x40008CA")]
			Head,
			[Token(Token = "0x40008CB")]
			Arm,
			[Token(Token = "0x40008CC")]
			Leg,
			[Token(Token = "0x40008CD")]
			Tail,
			[Token(Token = "0x40008CE")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000151")]
		public enum BoneSide
		{
			[Token(Token = "0x40008D0")]
			Center,
			[Token(Token = "0x40008D1")]
			Left,
			[Token(Token = "0x40008D2")]
			Right
		}

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x10C3E60", Offset = "0x10C3E60", VA = "0x10C3E60")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x10C417C", Offset = "0x10C417C", VA = "0x10C417C")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x10C43E8", Offset = "0x10C43E8", VA = "0x10C43E8")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x10C4468", Offset = "0x10C4468", VA = "0x10C4468")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x10C4510", Offset = "0x10C4510", VA = "0x10C4510")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x10C4030", Offset = "0x10C4030", VA = "0x10C4030")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x10C434C", Offset = "0x10C434C", VA = "0x10C434C")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x10C4D40", Offset = "0x10C4D40", VA = "0x10C4D40")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x10C4B48", Offset = "0x10C4B48", VA = "0x10C4B48")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x10C4C44", Offset = "0x10C4C44", VA = "0x10C4C44")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x10C4728", Offset = "0x10C4728", VA = "0x10C4728")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x10C47D8", Offset = "0x10C47D8", VA = "0x10C47D8")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x10C4888", Offset = "0x10C4888", VA = "0x10C4888")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x10C4938", Offset = "0x10C4938", VA = "0x10C4938")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x10C49E8", Offset = "0x10C49E8", VA = "0x10C49E8")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x10C4A98", Offset = "0x10C4A98", VA = "0x10C4A98")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x10C4F48", Offset = "0x10C4F48", VA = "0x10C4F48")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x10C4640", Offset = "0x10C4640", VA = "0x10C4640")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x10C4EB8", Offset = "0x10C4EB8", VA = "0x10C4EB8")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x10C4FB4", Offset = "0x10C4FB4", VA = "0x10C4FB4")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x10C5088", Offset = "0x10C5088", VA = "0x10C5088")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x10C4E40", Offset = "0x10C4E40", VA = "0x10C4E40")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x10C4DCC", Offset = "0x10C4DCC", VA = "0x10C4DCC")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class BipedReferences
	{
		[Token(Token = "0x2000152")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40008D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x170000C1")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60008BD")]
				[Address(RVA = "0x11224D0", Offset = "0x11224D0", VA = "0x11224D0")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x11224BC", Offset = "0x11224BC", VA = "0x11224BC")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700002E")]
		public virtual bool isFilled
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x10C70CC", Offset = "0x10C70CC", VA = "0x10C70CC", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		public bool isEmpty
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x10C74B4", Offset = "0x10C74B4", VA = "0x10C74B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x10C74C4", Offset = "0x10C74C4", VA = "0x10C74C4", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x10C78EC", Offset = "0x10C78EC", VA = "0x10C78EC", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x10C7D20", Offset = "0x10C7D20", VA = "0x10C7D20")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x10C830C", Offset = "0x10C830C", VA = "0x10C830C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x10C7F34", Offset = "0x10C7F34", VA = "0x10C7F34")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x10C2D10", Offset = "0x10C2D10", VA = "0x10C2D10")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x10C8B0C", Offset = "0x10C8B0C", VA = "0x10C8B0C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x10C906C", Offset = "0x10C906C", VA = "0x10C906C")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x10C8E60", Offset = "0x10C8E60", VA = "0x10C8E60")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x10C8CDC", Offset = "0x10C8CDC", VA = "0x10C8CDC")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x10C8BAC", Offset = "0x10C8BAC", VA = "0x10C8BAC")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x10C8F6C", Offset = "0x10C8F6C", VA = "0x10C8F6C")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x10C9164", Offset = "0x10C9164", VA = "0x10C9164")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x10C9C88", Offset = "0x10C9C88", VA = "0x10C9C88")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x10C9710", Offset = "0x10C9710", VA = "0x10C9710")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x10C9F30", Offset = "0x10C9F30", VA = "0x10C9F30")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x10C9A7C", Offset = "0x10C9A7C", VA = "0x10C9A7C")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x10C9F38", Offset = "0x10C9F38", VA = "0x10C9F38")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x10C9F40", Offset = "0x10C9F40", VA = "0x10C9F40")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x10CA108", Offset = "0x10CA108", VA = "0x10CA108")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x10CA2C4", Offset = "0x10CA2C4", VA = "0x10CA2C4")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x10C316C", Offset = "0x10C316C", VA = "0x10C316C")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1235B64", Offset = "0x1235B64", VA = "0x1235B64")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x12371B8", Offset = "0x12371B8", VA = "0x12371B8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1237300", Offset = "0x1237300", VA = "0x1237300")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class Hierarchy
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x11CC00C", Offset = "0x11CC00C", VA = "0x11CC00C")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x11CC1F8", Offset = "0x11CC1F8", VA = "0x11CC1F8")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x11CC0A4", Offset = "0x11CC0A4", VA = "0x11CC0A4")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x11CC318", Offset = "0x11CC318", VA = "0x11CC318")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x11CC444", Offset = "0x11CC444", VA = "0x11CC444")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x11CC690", Offset = "0x11CC690", VA = "0x11CC690")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x11CC798", Offset = "0x11CC798", VA = "0x11CC798")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x11CC90C", Offset = "0x11CC90C", VA = "0x11CC90C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x11CCCE8", Offset = "0x11CCCE8", VA = "0x11CCCE8")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x11CCAAC", Offset = "0x11CCAAC", VA = "0x11CCAAC")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x11CCE9C", Offset = "0x11CCE9C", VA = "0x11CCE9C")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x11FCBB8", Offset = "0x11FCBB8", VA = "0x11FCBB8")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x11FCC24", Offset = "0x11FCC24", VA = "0x11FCC24")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000322")]
		None,
		[Token(Token = "0x4000323")]
		InOutCubic,
		[Token(Token = "0x4000324")]
		InOutQuintic,
		[Token(Token = "0x4000325")]
		InOutSine,
		[Token(Token = "0x4000326")]
		InQuintic,
		[Token(Token = "0x4000327")]
		InQuartic,
		[Token(Token = "0x4000328")]
		InCubic,
		[Token(Token = "0x4000329")]
		InQuadratic,
		[Token(Token = "0x400032A")]
		InElastic,
		[Token(Token = "0x400032B")]
		InElasticSmall,
		[Token(Token = "0x400032C")]
		InElasticBig,
		[Token(Token = "0x400032D")]
		InSine,
		[Token(Token = "0x400032E")]
		InBack,
		[Token(Token = "0x400032F")]
		OutQuintic,
		[Token(Token = "0x4000330")]
		OutQuartic,
		[Token(Token = "0x4000331")]
		OutCubic,
		[Token(Token = "0x4000332")]
		OutInCubic,
		[Token(Token = "0x4000333")]
		OutInQuartic,
		[Token(Token = "0x4000334")]
		OutElastic,
		[Token(Token = "0x4000335")]
		OutElasticSmall,
		[Token(Token = "0x4000336")]
		OutElasticBig,
		[Token(Token = "0x4000337")]
		OutSine,
		[Token(Token = "0x4000338")]
		OutBack,
		[Token(Token = "0x4000339")]
		OutBackCubic,
		[Token(Token = "0x400033A")]
		OutBackQuartic,
		[Token(Token = "0x400033B")]
		BackInCubic,
		[Token(Token = "0x400033C")]
		BackInQuartic
	}
	[Token(Token = "0x2000079")]
	public class Interp
	{
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xF9C6CC", Offset = "0xF9C6CC", VA = "0xF9C6CC")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xF9D078", Offset = "0xF9D078", VA = "0xF9D078")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xF9D0EC", Offset = "0xF9D0EC", VA = "0xF9D0EC")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xF9CAE0", Offset = "0xF9CAE0", VA = "0xF9CAE0")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xF9CAEC", Offset = "0xF9CAEC", VA = "0xF9CAEC")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xF9CB10", Offset = "0xF9CB10", VA = "0xF9CB10")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xF9CB4C", Offset = "0xF9CB4C", VA = "0xF9CB4C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xF9CB64", Offset = "0xF9CB64", VA = "0xF9CB64")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xF9CB78", Offset = "0xF9CB78", VA = "0xF9CB78")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xF9CB8C", Offset = "0xF9CB8C", VA = "0xF9CB8C")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xF9CB9C", Offset = "0xF9CB9C", VA = "0xF9CB9C")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xF9CBE4", Offset = "0xF9CBE4", VA = "0xF9CBE4")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xF9CC1C", Offset = "0xF9CC1C", VA = "0xF9CC1C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xF9CC44", Offset = "0xF9CC44", VA = "0xF9CC44")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xF9D178", Offset = "0xF9D178", VA = "0xF9D178")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xF9CC78", Offset = "0xF9CC78", VA = "0xF9CC78")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xF9CCA0", Offset = "0xF9CCA0", VA = "0xF9CCA0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xF9CCD0", Offset = "0xF9CCD0", VA = "0xF9CCD0")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xF9CD04", Offset = "0xF9CD04", VA = "0xF9CD04")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xF9CD48", Offset = "0xF9CD48", VA = "0xF9CD48")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xF9CDAC", Offset = "0xF9CDAC", VA = "0xF9CDAC")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xF9CE10", Offset = "0xF9CE10", VA = "0xF9CE10")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xF9CE64", Offset = "0xF9CE64", VA = "0xF9CE64")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xF9CEB8", Offset = "0xF9CEB8", VA = "0xF9CEB8")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xF9CEF4", Offset = "0xF9CEF4", VA = "0xF9CEF4")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xF9CF2C", Offset = "0xF9CF2C", VA = "0xF9CF2C")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xF9D1AC", Offset = "0xF9D1AC", VA = "0xF9D1AC")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xF9CF74", Offset = "0xF9CF74", VA = "0xF9CF74")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xF9D008", Offset = "0xF9D008", VA = "0xF9D008")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xF9D038", Offset = "0xF9D038", VA = "0xF9D038")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xF9D240", Offset = "0xF9D240", VA = "0xF9D240")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xF9DC74", Offset = "0xF9DC74", VA = "0xF9DC74")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xF9DCE0", Offset = "0xF9DCE0", VA = "0xF9DCE0")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200007B")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xF9DD4C", Offset = "0xF9DD4C", VA = "0xF9DD4C")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xF9DDA4", Offset = "0xF9DDA4", VA = "0xF9DDA4")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xF9DE70", Offset = "0xF9DE70", VA = "0xF9DE70")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xF9DDBC", Offset = "0xF9DDBC", VA = "0xF9DDBC")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xF9DE88", Offset = "0xF9DE88", VA = "0xF9DE88")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xF9DF2C", Offset = "0xF9DF2C", VA = "0xF9DF2C")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xF9DF58", Offset = "0xF9DF58", VA = "0xF9DF58")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xF9DFA8", Offset = "0xF9DFA8", VA = "0xF9DFA8")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xF9E014", Offset = "0xF9E014", VA = "0xF9E014")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xF9E128", Offset = "0xF9E128", VA = "0xF9E128")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xF9E220", Offset = "0xF9E220", VA = "0xF9E220")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xF9E27C", Offset = "0xF9E27C", VA = "0xF9E27C")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200007C")]
	public static class QuaTools
	{
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xFA8BA4", Offset = "0xFA8BA4", VA = "0xFA8BA4")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xFA8C00", Offset = "0xFA8C00", VA = "0xFA8C00")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xFA8C90", Offset = "0xFA8C90", VA = "0xFA8C90")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xFA8DF0", Offset = "0xFA8DF0", VA = "0xFA8DF0")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xFA8EAC", Offset = "0xFA8EAC", VA = "0xFA8EAC")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xFA8F68", Offset = "0xFA8F68", VA = "0xFA8F68")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xFA9114", Offset = "0xFA9114", VA = "0xFA9114")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xFA9164", Offset = "0xFA9164", VA = "0xFA9164")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xFA91B4", Offset = "0xFA91B4", VA = "0xFA91B4")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xFA925C", Offset = "0xFA925C", VA = "0xFA925C")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xF9C134", Offset = "0xF9C134", VA = "0xF9C134")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xFA9304", Offset = "0xFA9304", VA = "0xFA9304")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xF9C214", Offset = "0xF9C214", VA = "0xF9C214")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xFA5970", Offset = "0xFA5970", VA = "0xFA5970")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xFA9358", Offset = "0xFA9358", VA = "0xFA9358")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xFA94E8", Offset = "0xFA94E8", VA = "0xFA94E8")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xFA95DC", Offset = "0xFA95DC", VA = "0xFA95DC")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xFA96E8", Offset = "0xFA96E8", VA = "0xFA96E8")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xFA97D4", Offset = "0xFA97D4", VA = "0xFA97D4")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200007D")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000030")]
		public static T instance
		{
			[Token(Token = "0x600030C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030D")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600030E")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BFBC0", Offset = "0x5BFBC0")]
		public bool fixTransforms;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000031")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0xEAB2A4", Offset = "0xEAB2A4", VA = "0xEAB2A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000032")]
		private bool isAnimated
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0xEAB5B0", Offset = "0xEAB5B0", VA = "0xEAB5B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xEAB164", Offset = "0xEAB164", VA = "0xEAB164")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xEAB204", Offset = "0xEAB204", VA = "0xEAB204", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xEAB208", Offset = "0xEAB208", VA = "0xEAB208", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xEAB20C", Offset = "0xEAB20C", VA = "0xEAB20C", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xEAB210", Offset = "0xEAB210", VA = "0xEAB210")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xEAB2A0", Offset = "0xEAB2A0", VA = "0xEAB2A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xEAB248", Offset = "0xEAB248", VA = "0xEAB248")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xEAB564", Offset = "0xEAB564", VA = "0xEAB564")]
		private void Update()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xEAB390", Offset = "0xEAB390", VA = "0xEAB390")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xEAB668", Offset = "0xEAB668", VA = "0xEAB668")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xEAB6C4", Offset = "0xEAB6C4", VA = "0xEAB6C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xEAB720", Offset = "0xEAB720", VA = "0xEAB720")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xEAB768", Offset = "0xEAB768", VA = "0xEAB768")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xEAE42C", Offset = "0xEAE42C", VA = "0xEAE42C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xEAE4EC", Offset = "0xEAE4EC", VA = "0xEAE4EC")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xEAE5AC", Offset = "0xEAE5AC", VA = "0xEAE5AC")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xEAE66C", Offset = "0xEAE66C", VA = "0xEAE66C")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public static class V2Tools
	{
		[Token(Token = "0x6000323")]
		[Address(RVA = "0xEB04D8", Offset = "0xEB04D8", VA = "0xEB04D8")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xEB04E0", Offset = "0xEB04E0", VA = "0xEB04E0")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xEB0530", Offset = "0xEB0530", VA = "0xEB0530")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xEB0584", Offset = "0xEB0584", VA = "0xEB0584")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xEB065C", Offset = "0xEB065C", VA = "0xEB065C")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000081")]
	public static class V3Tools
	{
		[Token(Token = "0x6000328")]
		[Address(RVA = "0xEB06F0", Offset = "0xEB06F0", VA = "0xEB06F0")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xEB0714", Offset = "0xEB0714", VA = "0xEB0714")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xEB075C", Offset = "0xEB075C", VA = "0xEB075C")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xEB07E8", Offset = "0xEB07E8", VA = "0xEB07E8")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xEB0848", Offset = "0xEB0848", VA = "0xEB0848")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xEB08A8", Offset = "0xEB08A8", VA = "0xEB08A8")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xEB09C4", Offset = "0xEB09C4", VA = "0xEB09C4")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xEB0A64", Offset = "0xEB0A64", VA = "0xEB0A64")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xEB0AA0", Offset = "0xEB0AA0", VA = "0xEB0AA0")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xEB0AE4", Offset = "0xEB0AE4", VA = "0xEB0AE4")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xEB0B80", Offset = "0xEB0B80", VA = "0xEB0B80")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xEB0CDC", Offset = "0xEB0CDC", VA = "0xEB0CDC")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xEB0E58", Offset = "0xEB0E58", VA = "0xEB0E58")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xEB0FDC", Offset = "0xEB0FDC", VA = "0xEB0FDC")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xEB1098", Offset = "0xEB1098", VA = "0xEB1098")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xEB1198", Offset = "0xEB1198", VA = "0xEB1198")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xEB1220", Offset = "0xEB1220", VA = "0xEB1220")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xEB12BC", Offset = "0xEB12BC", VA = "0xEB12BC")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xEB1360", Offset = "0xEB1360", VA = "0xEB1360")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xEB1350", Offset = "0xEB1350", VA = "0xEB1350")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000082")]
	public static class Warning
	{
		[Token(Token = "0x2000153")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xEB6BD0", Offset = "0xEB6BD0", VA = "0xEB6BD0")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xEA6F80", Offset = "0xEA6F80", VA = "0xEA6F80")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BDCDC", Offset = "0x5BDCDC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BDCDC", Offset = "0x5BDCDC")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x10C23F0", Offset = "0x10C23F0", VA = "0x10C23F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8604", Offset = "0x5C8604")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x10C2438", Offset = "0x10C2438", VA = "0x10C2438")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C863C", Offset = "0x5C863C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x10C2480", Offset = "0x10C2480", VA = "0x10C2480")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8674", Offset = "0x5C8674")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x10C24C8", Offset = "0x10C24C8", VA = "0x10C24C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C86AC", Offset = "0x5C86AC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x10C2510", Offset = "0x10C2510", VA = "0x10C2510")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x10C25AC", Offset = "0x10C25AC", VA = "0x10C25AC")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x10C25CC", Offset = "0x10C25CC", VA = "0x10C25CC")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x10C25FC", Offset = "0x10C25FC", VA = "0x10C25FC")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x10C262C", Offset = "0x10C262C", VA = "0x10C262C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x10C266C", Offset = "0x10C266C", VA = "0x10C266C")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x10C26B0", Offset = "0x10C26B0", VA = "0x10C26B0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x10C26D4", Offset = "0x10C26D4", VA = "0x10C26D4")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x10C26F8", Offset = "0x10C26F8", VA = "0x10C26F8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x10C2720", Offset = "0x10C2720", VA = "0x10C2720")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x10C274C", Offset = "0x10C274C", VA = "0x10C274C")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x10C2778", Offset = "0x10C2778", VA = "0x10C2778")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x10C2530", Offset = "0x10C2530", VA = "0x10C2530")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x10C27A0", Offset = "0x10C27A0", VA = "0x10C27A0")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x10C27AC", Offset = "0x10C27AC", VA = "0x10C27AC")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x10C27B8", Offset = "0x10C27B8", VA = "0x10C27B8")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x10C2A9C", Offset = "0x10C2A9C", VA = "0x10C2A9C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x10C2B44", Offset = "0x10C2B44", VA = "0x10C2B44", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x10C2F24", Offset = "0x10C2F24", VA = "0x10C2F24", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x10C30B0", Offset = "0x10C30B0", VA = "0x10C30B0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x10C30E4", Offset = "0x10C30E4", VA = "0x10C30E4")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000033")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x10C2958", Offset = "0x10C2958", VA = "0x10C2958")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x10C334C", Offset = "0x10C334C", VA = "0x10C334C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x10C2E00", Offset = "0x10C2E00", VA = "0x10C2E00")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x10C31D8", Offset = "0x10C31D8", VA = "0x10C31D8")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000035")]
		public bool isValid
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x1235B6C", Offset = "0x1235B6C", VA = "0x1235B6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600035C")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1235BD8", Offset = "0x1235BD8", VA = "0x1235BD8")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1235BE0", Offset = "0x1235BE0", VA = "0x1235BE0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1235CA0", Offset = "0x1235CA0", VA = "0x1235CA0")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1235CA8", Offset = "0x1235CA8", VA = "0x1235CA8")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000036")]
		private bool positionChanged
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x1235DDC", Offset = "0x1235DDC", VA = "0x1235DDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1235CD4", Offset = "0x1235CD4", VA = "0x1235CD4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1235E18", Offset = "0x1235E18", VA = "0x1235E18")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1235E20", Offset = "0x1235E20", VA = "0x1235E20")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000088")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1235E4C", Offset = "0x1235E4C", VA = "0x1235E4C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1235ECC", Offset = "0x1235ECC", VA = "0x1235ECC")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x1235ED4", Offset = "0x1235ED4", VA = "0x1235ED4")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000089")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000037")]
		private bool rotationChanged
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x1236008", Offset = "0x1236008", VA = "0x1236008")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1235F00", Offset = "0x1235F00", VA = "0x1235F00", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1236044", Offset = "0x1236044", VA = "0x1236044")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x123604C", Offset = "0x123604C", VA = "0x123604C")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008A")]
	public class Constraints
	{
		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BFBF8", Offset = "0x5BFBF8")]
		public float positionWeight;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BFC10", Offset = "0x5BFC10")]
		public float rotationWeight;

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1236078", Offset = "0x1236078", VA = "0x1236078")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x12360E4", Offset = "0x12360E4", VA = "0x12360E4")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1236138", Offset = "0x1236138", VA = "0x1236138")]
		public void Update()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x12363E8", Offset = "0x12363E8", VA = "0x12363E8")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008B")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000154")]
		public enum DOF
		{
			[Token(Token = "0x40008D6")]
			One,
			[Token(Token = "0x40008D7")]
			Three
		}

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BFC28", Offset = "0x5BFC28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BFC28", Offset = "0x5BFC28")]
		public float weight;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BFC7C", Offset = "0x5BFC7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BFC7C", Offset = "0x5BFC7C")]
		public float rotationWeight;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BFCD0", Offset = "0x5BFCD0")]
		public DOF rotationDOF;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BFD08", Offset = "0x5BFD08")]
		public bool fixBone1Twist;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BFD40", Offset = "0x5BFD40")]
		public Transform bone1;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BFD78", Offset = "0x5BFD78")]
		public Transform bone2;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BFDB0", Offset = "0x5BFDB0")]
		public Transform bone3;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BFDE8", Offset = "0x5BFDE8")]
		public Transform tip;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BFE20", Offset = "0x5BFE20")]
		public Transform target;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFE58", Offset = "0x5BFE58")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 defaultBendNormal;

		[Token(Token = "0x17000038")]
		public bool initiated
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x11C06B4", Offset = "0x11C06B4", VA = "0x11C06B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C86E4", Offset = "0x5C86E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x11C06BC", Offset = "0x11C06BC", VA = "0x11C06BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C86F4", Offset = "0x5C86F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x11C06C8", Offset = "0x11C06C8", VA = "0x11C06C8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x11C06E8", Offset = "0x11C06E8", VA = "0x11C06E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x11C0708", Offset = "0x11C0708", VA = "0x11C0708")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x11C0728", Offset = "0x11C0728", VA = "0x11C0728")]
			set
			{
			}
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x11C0748", Offset = "0x11C0748", VA = "0x11C0748")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x11C0850", Offset = "0x11C0850", VA = "0x11C0850")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x11C0DC8", Offset = "0x11C0DC8", VA = "0x11C0DC8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x11C0EA0", Offset = "0x11C0EA0", VA = "0x11C0EA0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x11C0F64", Offset = "0x11C0F64", VA = "0x11C0F64")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x11C13E8", Offset = "0x11C13E8", VA = "0x11C13E8")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BFE68", Offset = "0x5BFE68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BFE68", Offset = "0x5BFE68")]
		public float weight;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFEBC", Offset = "0x5BFEBC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700003B")]
		public bool initiated
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x11C13F8", Offset = "0x11C13F8", VA = "0x11C13F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8704", Offset = "0x5C8704")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x11C1400", Offset = "0x11C1400", VA = "0x11C1400")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8714", Offset = "0x5C8714")]
			private set
			{
			}
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x11C140C", Offset = "0x11C140C", VA = "0x11C140C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x11C1494", Offset = "0x11C1494", VA = "0x11C1494")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8724", Offset = "0x5C8724")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x11C17CC", Offset = "0x11C17CC", VA = "0x11C17CC")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x11C1944", Offset = "0x11C1944", VA = "0x11C1944")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x11C16D0", Offset = "0x11C16D0", VA = "0x11C16D0")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x11C1AB4", Offset = "0x11C1AB4", VA = "0x11C1AB4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x11C1B74", Offset = "0x11C1B74", VA = "0x11C1B74")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x11C1BEC", Offset = "0x11C1BEC", VA = "0x11C1BEC")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x11C1C60", Offset = "0x11C1C60", VA = "0x11C1C60")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x11C1CC8", Offset = "0x11C1CC8", VA = "0x11C1CC8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x11C1CCC", Offset = "0x11C1CCC", VA = "0x11C1CCC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x11C1CE0", Offset = "0x11C1CE0", VA = "0x11C1CE0")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000155")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BFECC", Offset = "0x5BFECC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BFECC", Offset = "0x5BFECC")]
		public float weight;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BFF20", Offset = "0x5BFF20")]
		public Grounding solver;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFF58", Offset = "0x5BFF58")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700003C")]
		public bool initiated
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x11C48A8", Offset = "0x11C48A8", VA = "0x11C48A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C875C", Offset = "0x5C875C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x11C48B0", Offset = "0x11C48B0", VA = "0x11C48B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C876C", Offset = "0x5C876C")]
			protected set
			{
			}
		}

		[Token(Token = "0x600038A")]
		public abstract void ResetPosition();

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x11C48BC", Offset = "0x11C48BC", VA = "0x11C48BC")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x11C4A68", Offset = "0x11C4A68", VA = "0x11C4A68")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x11C4968", Offset = "0x11C4968", VA = "0x11C4968")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x11C4A9C", Offset = "0x11C4A9C", VA = "0x11C4A9C")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000391")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000392")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x11C4BD8", Offset = "0x11C4BD8", VA = "0x11C4BD8")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BDD3C", Offset = "0x5BDD3C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BDD3C", Offset = "0x5BDD3C")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BFF68", Offset = "0x5BFF68")]
		public BipedIK ik;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BFFA0", Offset = "0x5BFFA0")]
		public float spineBend;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BFFD8", Offset = "0x5BFFD8")]
		public float spineSpeed;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x11C4CE8", Offset = "0x11C4CE8", VA = "0x11C4CE8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C877C", Offset = "0x5C877C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x11C4D30", Offset = "0x11C4D30", VA = "0x11C4D30", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C87B4", Offset = "0x5C87B4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x11C4D78", Offset = "0x11C4D78", VA = "0x11C4D78", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x11C4E40", Offset = "0x11C4E40", VA = "0x11C4E40")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x11C4EEC", Offset = "0x11C4EEC", VA = "0x11C4EEC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x11C4F4C", Offset = "0x11C4F4C", VA = "0x11C4F4C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x11C5494", Offset = "0x11C5494", VA = "0x11C5494")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x11C54E8", Offset = "0x11C54E8", VA = "0x11C54E8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x11C5B6C", Offset = "0x11C5B6C", VA = "0x11C5B6C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x11C5C84", Offset = "0x11C5C84", VA = "0x11C5C84")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x11C5DC4", Offset = "0x11C5DC4", VA = "0x11C5DC4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x11C5F54", Offset = "0x11C5F54", VA = "0x11C5F54")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BDD9C", Offset = "0x5BDD9C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BDD9C", Offset = "0x5BDD9C")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000156")]
		public class SpineEffector
		{
			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C45FC", Offset = "0x5C45FC")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4634", Offset = "0x5C4634")]
			public float horizontalWeight;

			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C466C", Offset = "0x5C466C")]
			public float verticalWeight;

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x11247E4", Offset = "0x11247E4", VA = "0x11247E4")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x11247F4", Offset = "0x11247F4", VA = "0x11247F4")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0010", Offset = "0x5C0010")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0048", Offset = "0x5C0048")]
		public float spineBend;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0080", Offset = "0x5C0080")]
		public float spineSpeed;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x11C638C", Offset = "0x11C638C", VA = "0x11C638C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C87EC", Offset = "0x5C87EC")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x11C63D4", Offset = "0x11C63D4", VA = "0x11C63D4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8824", Offset = "0x5C8824")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x11C641C", Offset = "0x11C641C", VA = "0x11C641C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C885C", Offset = "0x5C885C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x11C6464", Offset = "0x11C6464", VA = "0x11C6464", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x11C64A0", Offset = "0x11C64A0", VA = "0x11C64A0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x11C6534", Offset = "0x11C6534", VA = "0x11C6534")]
		private void Update()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x11C67B0", Offset = "0x11C67B0", VA = "0x11C67B0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x11C67BC", Offset = "0x11C67BC", VA = "0x11C67BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x11C659C", Offset = "0x11C659C", VA = "0x11C659C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x11C67C8", Offset = "0x11C67C8", VA = "0x11C67C8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x11C6AE4", Offset = "0x11C6AE4", VA = "0x11C6AE4")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x11C6BF4", Offset = "0x11C6BF4", VA = "0x11C6BF4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x11C6D4C", Offset = "0x11C6D4C", VA = "0x11C6D4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x11C6E60", Offset = "0x11C6E60", VA = "0x11C6E60")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BDDFC", Offset = "0x5BDDFC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BDDFC", Offset = "0x5BDDFC")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C00B8", Offset = "0x5C00B8")]
		public Transform pelvis;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C00F0", Offset = "0x5C00F0")]
		public Transform characterRoot;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0128", Offset = "0x5C0128")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0128", Offset = "0x5C0128")]
		public float rootRotationWeight;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C017C", Offset = "0x5C017C")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C01B4", Offset = "0x5C01B4")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x11C6EE8", Offset = "0x11C6EE8", VA = "0x11C6EE8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8894", Offset = "0x5C8894")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x11C6F30", Offset = "0x11C6F30", VA = "0x11C6F30", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C88CC", Offset = "0x5C88CC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x11C6F78", Offset = "0x11C6F78", VA = "0x11C6F78", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x11C6F90", Offset = "0x11C6F90", VA = "0x11C6F90")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x11C71C4", Offset = "0x11C71C4", VA = "0x11C71C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x11C72C0", Offset = "0x11C72C0", VA = "0x11C72C0")]
		private void Update()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x11C7870", Offset = "0x11C7870", VA = "0x11C7870")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x11C7C78", Offset = "0x11C7C78", VA = "0x11C7C78")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x11C7E04", Offset = "0x11C7E04", VA = "0x11C7E04")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x11C8108", Offset = "0x11C8108", VA = "0x11C8108")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x11C8254", Offset = "0x11C8254", VA = "0x11C8254")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x11C843C", Offset = "0x11C843C", VA = "0x11C843C")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BDE5C", Offset = "0x5BDE5C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BDE5C", Offset = "0x5BDE5C")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000157")]
		public struct Foot
		{
			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x112483C", Offset = "0x112483C", VA = "0x112483C")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C01EC", Offset = "0x5C01EC")]
		public Grounding forelegSolver;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0224", Offset = "0x5C0224")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0224", Offset = "0x5C0224")]
		public float rootRotationWeight;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0278", Offset = "0x5C0278")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0278", Offset = "0x5C0278")]
		public float minRootRotation;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C02D0", Offset = "0x5C02D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C02D0", Offset = "0x5C02D0")]
		public float maxRootRotation;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0328", Offset = "0x5C0328")]
		public float rootRotationSpeed;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0360", Offset = "0x5C0360")]
		public float maxLegOffset;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0398", Offset = "0x5C0398")]
		public float maxForeLegOffset;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C03D0", Offset = "0x5C03D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C03D0", Offset = "0x5C03D0")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0424", Offset = "0x5C0424")]
		public Transform characterRoot;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C045C", Offset = "0x5C045C")]
		public Transform pelvis;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0494", Offset = "0x5C0494")]
		public Transform lastSpineBone;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C04CC", Offset = "0x5C04CC")]
		public Transform head;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x11C84C4", Offset = "0x11C84C4", VA = "0x11C84C4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8904", Offset = "0x5C8904")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x11C850C", Offset = "0x11C850C", VA = "0x11C850C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C893C", Offset = "0x5C893C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x11C8554", Offset = "0x11C8554", VA = "0x11C8554", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x11C8588", Offset = "0x11C8588", VA = "0x11C8588")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x11C86B4", Offset = "0x11C86B4", VA = "0x11C86B4")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x11C88B8", Offset = "0x11C88B8", VA = "0x11C88B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x11C8920", Offset = "0x11C8920", VA = "0x11C8920")]
		private void Update()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x11C8984", Offset = "0x11C8984", VA = "0x11C8984")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x11C8CB0", Offset = "0x11C8CB0", VA = "0x11C8CB0")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x11C8FF4", Offset = "0x11C8FF4", VA = "0x11C8FF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x11C90EC", Offset = "0x11C90EC", VA = "0x11C90EC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x11C94B8", Offset = "0x11C94B8", VA = "0x11C94B8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x11C9AD4", Offset = "0x11C9AD4", VA = "0x11C9AD4")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x11C9CA4", Offset = "0x11C9CA4", VA = "0x11C9CA4")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x11C9D80", Offset = "0x11C9D80", VA = "0x11C9D80")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x11C9FC8", Offset = "0x11C9FC8", VA = "0x11C9FC8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x11CA000", Offset = "0x11CA000", VA = "0x11CA000")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x11CA1E0", Offset = "0x11CA1E0", VA = "0x11CA1E0")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BDEBC", Offset = "0x5BDEBC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BDEBC", Offset = "0x5BDEBC")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0514", Offset = "0x5C0514")]
		public VRIK ik;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x11CA2E0", Offset = "0x11CA2E0", VA = "0x11CA2E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8974", Offset = "0x5C8974")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x11CA328", Offset = "0x11CA328", VA = "0x11CA328", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C89AC", Offset = "0x5C89AC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x11CA370", Offset = "0x11CA370", VA = "0x11CA370", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C89E4", Offset = "0x5C89E4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x11CA3B8", Offset = "0x11CA3B8", VA = "0x11CA3B8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x11CA3D0", Offset = "0x11CA3D0", VA = "0x11CA3D0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x11CA464", Offset = "0x11CA464", VA = "0x11CA464")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x11CA4C4", Offset = "0x11CA4C4", VA = "0x11CA4C4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x11CA6E4", Offset = "0x11CA6E4", VA = "0x11CA6E4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x11CA8D4", Offset = "0x11CA8D4", VA = "0x11CA8D4")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x11CA964", Offset = "0x11CA964", VA = "0x11CA964")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x11CAB20", Offset = "0x11CAB20", VA = "0x11CAB20")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x11CAC78", Offset = "0x11CAC78", VA = "0x11CAC78")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x11CADF8", Offset = "0x11CADF8", VA = "0x11CADF8")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000093")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000158")]
		public enum Quality
		{
			[Token(Token = "0x40008E0")]
			Fastest,
			[Token(Token = "0x40008E1")]
			Simple,
			[Token(Token = "0x40008E2")]
			Best
		}

		[Token(Token = "0x2000159")]
		public class Leg
		{
			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C46A4", Offset = "0x5C46A4")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C46B4", Offset = "0x5C46B4")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C46C4", Offset = "0x5C46C4")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C46D4", Offset = "0x5C46D4")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C46E4", Offset = "0x5C46E4")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C46F4", Offset = "0x5C46F4")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4704", Offset = "0x5C4704")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4714", Offset = "0x5C4714")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4724", Offset = "0x5C4724")]
			private RaycastHit <capsuleHit>k__BackingField;

			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x40008F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x170000C2")]
			public bool isGrounded
			{
				[Token(Token = "0x60008C9")]
				[Address(RVA = "0x112487C", Offset = "0x112487C", VA = "0x112487C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAA7C", Offset = "0x5CAA7C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60008CA")]
				[Address(RVA = "0x1124884", Offset = "0x1124884", VA = "0x1124884")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAA8C", Offset = "0x5CAA8C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C3")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60008CB")]
				[Address(RVA = "0x1124890", Offset = "0x1124890", VA = "0x1124890")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAA9C", Offset = "0x5CAA9C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008CC")]
				[Address(RVA = "0x112489C", Offset = "0x112489C", VA = "0x112489C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAAAC", Offset = "0x5CAAAC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C4")]
			public bool initiated
			{
				[Token(Token = "0x60008CD")]
				[Address(RVA = "0x11248A8", Offset = "0x11248A8", VA = "0x11248A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAABC", Offset = "0x5CAABC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60008CE")]
				[Address(RVA = "0x11248B0", Offset = "0x11248B0", VA = "0x11248B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAACC", Offset = "0x5CAACC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C5")]
			public float heightFromGround
			{
				[Token(Token = "0x60008CF")]
				[Address(RVA = "0x11248BC", Offset = "0x11248BC", VA = "0x11248BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAADC", Offset = "0x5CAADC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008D0")]
				[Address(RVA = "0x11248C4", Offset = "0x11248C4", VA = "0x11248C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAAEC", Offset = "0x5CAAEC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C6")]
			public Vector3 velocity
			{
				[Token(Token = "0x60008D1")]
				[Address(RVA = "0x11248CC", Offset = "0x11248CC", VA = "0x11248CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAAFC", Offset = "0x5CAAFC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008D2")]
				[Address(RVA = "0x11248D8", Offset = "0x11248D8", VA = "0x11248D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAB0C", Offset = "0x5CAB0C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C7")]
			public Transform transform
			{
				[Token(Token = "0x60008D3")]
				[Address(RVA = "0x11248E4", Offset = "0x11248E4", VA = "0x11248E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAB1C", Offset = "0x5CAB1C")]
				get
				{
					return null;
				}
				[Token(Token = "0x60008D4")]
				[Address(RVA = "0x11248EC", Offset = "0x11248EC", VA = "0x11248EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAB2C", Offset = "0x5CAB2C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C8")]
			public float IKOffset
			{
				[Token(Token = "0x60008D5")]
				[Address(RVA = "0x11248F4", Offset = "0x11248F4", VA = "0x11248F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAB3C", Offset = "0x5CAB3C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008D6")]
				[Address(RVA = "0x11248FC", Offset = "0x11248FC", VA = "0x11248FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAB4C", Offset = "0x5CAB4C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C9")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60008D7")]
				[Address(RVA = "0x1124904", Offset = "0x1124904", VA = "0x1124904")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAB5C", Offset = "0x5CAB5C")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60008D8")]
				[Address(RVA = "0x112491C", Offset = "0x112491C", VA = "0x112491C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAB6C", Offset = "0x5CAB6C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CA")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60008D9")]
				[Address(RVA = "0x112493C", Offset = "0x112493C", VA = "0x112493C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAB7C", Offset = "0x5CAB7C")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60008DA")]
				[Address(RVA = "0x1124954", Offset = "0x1124954", VA = "0x1124954")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAB8C", Offset = "0x5CAB8C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CB")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60008DB")]
				[Address(RVA = "0x1124974", Offset = "0x1124974", VA = "0x1124974")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x170000CC")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60008E1")]
				[Address(RVA = "0x1125B3C", Offset = "0x1125B3C", VA = "0x1125B3C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000CD")]
			private float rootYOffset
			{
				[Token(Token = "0x60008EA")]
				[Address(RVA = "0x1125CA0", Offset = "0x1125CA0", VA = "0x1125CA0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x11249BC", Offset = "0x11249BC", VA = "0x11249BC")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x11249D0", Offset = "0x11249D0", VA = "0x11249D0")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x1124A44", Offset = "0x1124A44", VA = "0x1124A44")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x1124A90", Offset = "0x1124A90", VA = "0x1124A90")]
			public void Reset()
			{
			}

			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x1124B00", Offset = "0x1124B00", VA = "0x1124B00")]
			public void Process()
			{
			}

			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x11257B0", Offset = "0x11257B0", VA = "0x11257B0")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x112534C", Offset = "0x112534C", VA = "0x112534C")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x1125BD0", Offset = "0x1125BD0", VA = "0x1125BD0")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x11255EC", Offset = "0x11255EC", VA = "0x11255EC")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x1125678", Offset = "0x1125678", VA = "0x1125678")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x1125C40", Offset = "0x1125C40", VA = "0x1125C40")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x1125B64", Offset = "0x1125B64", VA = "0x1125B64")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x1125D34", Offset = "0x1125D34", VA = "0x1125D34")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x1125DC0", Offset = "0x1125DC0", VA = "0x1125DC0")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200015A")]
		public class Pelvis
		{
			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4734", Offset = "0x5C4734")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4744", Offset = "0x5C4744")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000CE")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60008EC")]
				[Address(RVA = "0x1125E04", Offset = "0x1125E04", VA = "0x1125E04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAB9C", Offset = "0x5CAB9C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008ED")]
				[Address(RVA = "0x1125E10", Offset = "0x1125E10", VA = "0x1125E10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CABAC", Offset = "0x5CABAC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CF")]
			public float heightOffset
			{
				[Token(Token = "0x60008EE")]
				[Address(RVA = "0x1125E1C", Offset = "0x1125E1C", VA = "0x1125E1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CABBC", Offset = "0x5CABBC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008EF")]
				[Address(RVA = "0x1125E24", Offset = "0x1125E24", VA = "0x1125E24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CABCC", Offset = "0x5CABCC")]
				private set
				{
				}
			}

			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x1125E2C", Offset = "0x1125E2C", VA = "0x1125E2C")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x1125E9C", Offset = "0x1125E9C", VA = "0x1125E9C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x1125E3C", Offset = "0x1125E3C", VA = "0x1125E3C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x1125F08", Offset = "0x1125F08", VA = "0x1125F08")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x11260A8", Offset = "0x11260A8", VA = "0x11260A8")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C054C", Offset = "0x5C054C")]
		public LayerMask layers;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0584", Offset = "0x5C0584")]
		public float maxStep;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C05BC", Offset = "0x5C05BC")]
		public float heightOffset;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C05F4", Offset = "0x5C05F4")]
		public float footSpeed;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C062C", Offset = "0x5C062C")]
		public float footRadius;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0664", Offset = "0x5C0664")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C06B0", Offset = "0x5C06B0")]
		public float prediction;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C06E8", Offset = "0x5C06E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C06E8", Offset = "0x5C06E8")]
		public float footRotationWeight;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C073C", Offset = "0x5C073C")]
		public float footRotationSpeed;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0774", Offset = "0x5C0774")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0774", Offset = "0x5C0774")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C07CC", Offset = "0x5C07CC")]
		public bool rotateSolver;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0804", Offset = "0x5C0804")]
		public float pelvisSpeed;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C083C", Offset = "0x5C083C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C083C", Offset = "0x5C083C")]
		public float pelvisDamper;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0890", Offset = "0x5C0890")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C08C8", Offset = "0x5C08C8")]
		public float liftPelvisWeight;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0900", Offset = "0x5C0900")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0938", Offset = "0x5C0938")]
		public bool overstepFallsDown;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0970", Offset = "0x5C0970")]
		public Quality quality;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C09A8", Offset = "0x5C09A8")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C09B8", Offset = "0x5C09B8")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C09C8", Offset = "0x5C09C8")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C09D8", Offset = "0x5C09D8")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C09E8", Offset = "0x5C09E8")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700003D")]
		public Leg[] legs
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x11CAE50", Offset = "0x11CAE50", VA = "0x11CAE50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8A1C", Offset = "0x5C8A1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x11CAE58", Offset = "0x11CAE58", VA = "0x11CAE58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8A2C", Offset = "0x5C8A2C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x11CAE60", Offset = "0x11CAE60", VA = "0x11CAE60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8A3C", Offset = "0x5C8A3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x11CAE68", Offset = "0x11CAE68", VA = "0x11CAE68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8A4C", Offset = "0x5C8A4C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public bool isGrounded
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x11CAE70", Offset = "0x11CAE70", VA = "0x11CAE70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8A5C", Offset = "0x5C8A5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x11CAE78", Offset = "0x11CAE78", VA = "0x11CAE78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8A6C", Offset = "0x5C8A6C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public Transform root
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x11CAE84", Offset = "0x11CAE84", VA = "0x11CAE84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8A7C", Offset = "0x5C8A7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x11CAE8C", Offset = "0x11CAE8C", VA = "0x11CAE8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8A8C", Offset = "0x5C8A8C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x11CAE94", Offset = "0x11CAE94", VA = "0x11CAE94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8A9C", Offset = "0x5C8A9C")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x11CAEAC", Offset = "0x11CAEAC", VA = "0x11CAEAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C8AAC", Offset = "0x5C8AAC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public bool rootGrounded
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x11CAECC", Offset = "0x11CAECC", VA = "0x11CAECC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		public Vector3 up
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x11C5C40", Offset = "0x11C5C40", VA = "0x11C5C40")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000044")]
		private bool useRootRotation
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x11CB28C", Offset = "0x11CB28C", VA = "0x11CB28C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x11CAF20", Offset = "0x11CAF20", VA = "0x11CAF20")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x11CB16C", Offset = "0x11CB16C", VA = "0x11CB16C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x11C520C", Offset = "0x11C520C", VA = "0x11C520C")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x11C58FC", Offset = "0x11C58FC", VA = "0x11C58FC")]
		public void Update()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x11C7710", Offset = "0x11C7710", VA = "0x11C7710")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x11C4DB4", Offset = "0x11C4DB4", VA = "0x11C4DB4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x11CB274", Offset = "0x11CB274", VA = "0x11CB274")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x11CB30C", Offset = "0x11CB30C", VA = "0x11CB30C")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x11CB39C", Offset = "0x11CB39C", VA = "0x11CB39C")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x11CB458", Offset = "0x11CB458", VA = "0x11CB458")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x11C4C94", Offset = "0x11C4C94", VA = "0x11C4C94")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BDF1C", Offset = "0x5BDF1C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BDF1C", Offset = "0x5BDF1C")]
	public class AimIK : IK
	{
		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x10BACFC", Offset = "0x10BACFC", VA = "0x10BACFC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8ABC", Offset = "0x5C8ABC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x10BAD44", Offset = "0x10BAD44", VA = "0x10BAD44", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8AF4", Offset = "0x5C8AF4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x10BAD8C", Offset = "0x10BAD8C", VA = "0x10BAD8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8B2C", Offset = "0x5C8B2C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x10BADD4", Offset = "0x10BADD4", VA = "0x10BADD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8B64", Offset = "0x5C8B64")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x10BAE1C", Offset = "0x10BAE1C", VA = "0x10BAE1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8B9C", Offset = "0x5C8B9C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x10BAE64", Offset = "0x10BAE64", VA = "0x10BAE64", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x10BAE6C", Offset = "0x10BAE6C", VA = "0x10BAE6C")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BDF7C", Offset = "0x5BDF7C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BDF7C", Offset = "0x5BDF7C")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x10BCC30", Offset = "0x10BCC30", VA = "0x10BCC30", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8BD4", Offset = "0x5C8BD4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x10BCC78", Offset = "0x10BCC78", VA = "0x10BCC78", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8C0C", Offset = "0x5C8C0C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x10BCCC0", Offset = "0x10BCCC0", VA = "0x10BCCC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8C44", Offset = "0x5C8C44")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x10BCD08", Offset = "0x10BCD08", VA = "0x10BCD08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8C7C", Offset = "0x5C8C7C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x10BCD50", Offset = "0x10BCD50", VA = "0x10BCD50", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x10BCD58", Offset = "0x10BCD58", VA = "0x10BCD58")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BDFDC", Offset = "0x5BDFDC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BDFDC", Offset = "0x5BDFDC")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x122E65C", Offset = "0x122E65C", VA = "0x122E65C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8CB4", Offset = "0x5C8CB4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x122E6A4", Offset = "0x122E6A4", VA = "0x122E6A4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8CEC", Offset = "0x5C8CEC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x122E6EC", Offset = "0x122E6EC", VA = "0x122E6EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8D24", Offset = "0x5C8D24")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x122E734", Offset = "0x122E734", VA = "0x122E734")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8D5C", Offset = "0x5C8D5C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x122E77C", Offset = "0x122E77C", VA = "0x122E77C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x122E784", Offset = "0x122E784", VA = "0x122E784")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BE03C", Offset = "0x5BE03C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BE03C", Offset = "0x5BE03C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x12396A8", Offset = "0x12396A8", VA = "0x12396A8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8D94", Offset = "0x5C8D94")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x12396F0", Offset = "0x12396F0", VA = "0x12396F0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8DCC", Offset = "0x5C8DCC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1239738", Offset = "0x1239738", VA = "0x1239738")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8E04", Offset = "0x5C8E04")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1239780", Offset = "0x1239780", VA = "0x1239780")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8E3C", Offset = "0x5C8E3C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x12397C8", Offset = "0x12397C8", VA = "0x12397C8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x12397D0", Offset = "0x12397D0", VA = "0x12397D0")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BE09C", Offset = "0x5BE09C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BE09C", Offset = "0x5BE09C")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1239CF4", Offset = "0x1239CF4", VA = "0x1239CF4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8E74", Offset = "0x5C8E74")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1239D3C", Offset = "0x1239D3C", VA = "0x1239D3C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8EAC", Offset = "0x5C8EAC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1239D84", Offset = "0x1239D84", VA = "0x1239D84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8EE4", Offset = "0x5C8EE4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1239DCC", Offset = "0x1239DCC", VA = "0x1239DCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8F1C", Offset = "0x5C8F1C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1239E14", Offset = "0x1239E14", VA = "0x1239E14", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1239E1C", Offset = "0x1239E1C", VA = "0x1239E1C")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BE0FC", Offset = "0x5BE0FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BE0FC", Offset = "0x5BE0FC")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x11C34F0", Offset = "0x11C34F0", VA = "0x11C34F0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8F54", Offset = "0x5C8F54")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x11C3538", Offset = "0x11C3538", VA = "0x11C3538", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8F8C", Offset = "0x5C8F8C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x11C3580", Offset = "0x11C3580", VA = "0x11C3580")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8FC4", Offset = "0x5C8FC4")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x11C35C8", Offset = "0x11C35C8", VA = "0x11C35C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C8FFC", Offset = "0x5C8FFC")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x11C3610", Offset = "0x11C3610", VA = "0x11C3610")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9034", Offset = "0x5C9034")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x11C3658", Offset = "0x11C3658", VA = "0x11C3658")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C906C", Offset = "0x5C906C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x11C36A0", Offset = "0x11C36A0", VA = "0x11C36A0")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x11C36C4", Offset = "0x11C36C4", VA = "0x11C36C4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x11C36CC", Offset = "0x11C36CC", VA = "0x11C36CC")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x11C38A8", Offset = "0x11C38A8", VA = "0x11C38A8")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x11C3B3C", Offset = "0x11C3B3C", VA = "0x11C3B3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C90A4", Offset = "0x5C90A4")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x11C3B5C", Offset = "0x11C3B5C", VA = "0x11C3B5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C90DC", Offset = "0x5C90DC")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x11C3C34", Offset = "0x11C3C34", VA = "0x11C3C34")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x600041D")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x12C1150", Offset = "0x12C1150", VA = "0x12C1150", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x12C1244", Offset = "0x12C1244", VA = "0x12C1244", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x12C1430", Offset = "0x12C1430", VA = "0x12C1430", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000421")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000422")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x12C1490", Offset = "0x12C1490", VA = "0x12C1490")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C09F8", Offset = "0x5C09F8")]
		public IK[] IKComponents;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0A30", Offset = "0x5C0A30")]
		public Animator animator;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000045")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x12C3A00", Offset = "0x12C3A00", VA = "0x12C3A00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x12C3A98", Offset = "0x12C3A98", VA = "0x12C3A98")]
		private void Start()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x12C3B08", Offset = "0x12C3B08", VA = "0x12C3B08")]
		private void Update()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x12C3BC4", Offset = "0x12C3BC4", VA = "0x12C3BC4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x12C3C00", Offset = "0x12C3C00", VA = "0x12C3C00")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x12C3B3C", Offset = "0x12C3B3C", VA = "0x12C3B3C")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x12C3C8C", Offset = "0x12C3C8C", VA = "0x12C3C8C")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BE15C", Offset = "0x5BE15C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BE15C", Offset = "0x5BE15C")]
	public class LegIK : IK
	{
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xF9E2AC", Offset = "0xF9E2AC", VA = "0xF9E2AC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9114", Offset = "0x5C9114")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xF9E2F4", Offset = "0xF9E2F4", VA = "0xF9E2F4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C914C", Offset = "0x5C914C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xF9E33C", Offset = "0xF9E33C", VA = "0xF9E33C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9184", Offset = "0x5C9184")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xF9E384", Offset = "0xF9E384", VA = "0xF9E384")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C91BC", Offset = "0x5C91BC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xF9E3CC", Offset = "0xF9E3CC", VA = "0xF9E3CC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xF9E3D4", Offset = "0xF9E3D4", VA = "0xF9E3D4")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BE1BC", Offset = "0x5BE1BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BE1BC", Offset = "0x5BE1BC")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xF9E4B4", Offset = "0xF9E4B4", VA = "0xF9E4B4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C91F4", Offset = "0x5C91F4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xF9E4FC", Offset = "0xF9E4FC", VA = "0xF9E4FC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C922C", Offset = "0x5C922C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xF9E544", Offset = "0xF9E544", VA = "0xF9E544")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9264", Offset = "0x5C9264")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xF9E58C", Offset = "0xF9E58C", VA = "0xF9E58C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C929C", Offset = "0x5C929C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xF9E5D4", Offset = "0xF9E5D4", VA = "0xF9E5D4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xF9E5DC", Offset = "0xF9E5DC", VA = "0xF9E5DC")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BE21C", Offset = "0x5BE21C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BE21C", Offset = "0x5BE21C")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xF9EFC8", Offset = "0xF9EFC8", VA = "0xF9EFC8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C92D4", Offset = "0x5C92D4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xF9F010", Offset = "0xF9F010", VA = "0xF9F010", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C930C", Offset = "0x5C930C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xF9F058", Offset = "0xF9F058", VA = "0xF9F058")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9344", Offset = "0x5C9344")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xF9F0A0", Offset = "0xF9F0A0", VA = "0xF9F0A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C937C", Offset = "0x5C937C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xF9F0E8", Offset = "0xF9F0E8", VA = "0xF9F0E8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xF9F0F0", Offset = "0xF9F0F0", VA = "0xF9F0F0")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BE27C", Offset = "0x5BE27C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BE27C", Offset = "0x5BE27C")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xEAE674", Offset = "0xEAE674", VA = "0xEAE674", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C93B4", Offset = "0x5C93B4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xEAE6BC", Offset = "0xEAE6BC", VA = "0xEAE6BC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C93EC", Offset = "0x5C93EC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xEAE704", Offset = "0xEAE704", VA = "0xEAE704")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9424", Offset = "0x5C9424")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xEAE74C", Offset = "0xEAE74C", VA = "0xEAE74C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C945C", Offset = "0x5C945C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xEAE794", Offset = "0xEAE794", VA = "0xEAE794", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xEAE79C", Offset = "0xEAE79C", VA = "0xEAE79C")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BE2DC", Offset = "0x5BE2DC")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x200015B")]
		public class References
		{
			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4754", Offset = "0x5C4754")]
			public Transform chest;

			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C478C", Offset = "0x5C478C")]
			public Transform neck;

			[Token(Token = "0x4000904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x4000905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C47C4", Offset = "0x5C47C4")]
			public Transform leftShoulder;

			[Token(Token = "0x4000906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x4000907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x4000908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x4000909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C47FC", Offset = "0x5C47FC")]
			public Transform rightShoulder;

			[Token(Token = "0x400090A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x400090B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x400090C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4834", Offset = "0x5C4834")]
			public Transform leftThigh;

			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C486C", Offset = "0x5C486C")]
			public Transform leftCalf;

			[Token(Token = "0x400090F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C48A4", Offset = "0x5C48A4")]
			public Transform leftFoot;

			[Token(Token = "0x4000910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C48DC", Offset = "0x5C48DC")]
			public Transform leftToes;

			[Token(Token = "0x4000911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4914", Offset = "0x5C4914")]
			public Transform rightThigh;

			[Token(Token = "0x4000912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C494C", Offset = "0x5C494C")]
			public Transform rightCalf;

			[Token(Token = "0x4000913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4984", Offset = "0x5C4984")]
			public Transform rightFoot;

			[Token(Token = "0x4000914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C49BC", Offset = "0x5C49BC")]
			public Transform rightToes;

			[Token(Token = "0x170000D0")]
			public bool isFilled
			{
				[Token(Token = "0x60008F6")]
				[Address(RVA = "0x12F7464", Offset = "0x12F7464", VA = "0x12F7464")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000D1")]
			public bool isEmpty
			{
				[Token(Token = "0x60008F7")]
				[Address(RVA = "0x12F78DC", Offset = "0x12F78DC", VA = "0x12F78DC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x12F701C", Offset = "0x12F701C", VA = "0x12F701C")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x12F7D54", Offset = "0x12F7D54", VA = "0x12F7D54")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x12F80F0", Offset = "0x12F80F0", VA = "0x12F80F0")]
			public References()
			{
			}
		}

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x5C0A68", Offset = "0x5C0A68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0A68", Offset = "0x5C0A68")]
		public References references;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0AE4", Offset = "0x5C0AE4")]
		public IKSolverVR solver;

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xEB13E0", Offset = "0xEB13E0", VA = "0xEB13E0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9494", Offset = "0x5C9494")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xEB1428", Offset = "0xEB1428", VA = "0xEB1428", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C94CC", Offset = "0x5C94CC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xEB1470", Offset = "0xEB1470", VA = "0xEB1470")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9504", Offset = "0x5C9504")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xEB14B8", Offset = "0xEB14B8", VA = "0xEB14B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C953C", Offset = "0x5C953C")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xEB14E4", Offset = "0xEB14E4", VA = "0xEB14E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9574", Offset = "0x5C9574")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xEB150C", Offset = "0xEB150C", VA = "0xEB150C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xEB1514", Offset = "0xEB1514", VA = "0xEB1514", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xEB1594", Offset = "0xEB1594", VA = "0xEB1594", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xEB1700", Offset = "0xEB1700", VA = "0xEB1700")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A1")]
	public class FABRIKChain
	{
		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0B1C", Offset = "0x5C0B1C")]
		public float pull;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0B34", Offset = "0x5C0B34")]
		public float pin;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1239834", Offset = "0x1239834", VA = "0x1239834")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1239904", Offset = "0x1239904", VA = "0x1239904")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1239924", Offset = "0x1239924", VA = "0x1239924")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1239B98", Offset = "0x1239B98", VA = "0x1239B98")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x12399F8", Offset = "0x12399F8", VA = "0x12399F8")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1239C90", Offset = "0x1239C90", VA = "0x1239C90")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1239E80", Offset = "0x1239E80", VA = "0x1239E80")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x123A2E4", Offset = "0x123A2E4", VA = "0x123A2E4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x123A4A0", Offset = "0x123A4A0", VA = "0x123A4A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x123A5AC", Offset = "0x123A5AC", VA = "0x123A5AC")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200015C")]
		public class BendBone
		{
			[Token(Token = "0x4000915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C49F4", Offset = "0x5C49F4")]
			public Transform transform;

			[Token(Token = "0x4000916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4A2C", Offset = "0x5C4A2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C4A2C", Offset = "0x5C4A2C")]
			public float weight;

			[Token(Token = "0x4000917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x11238A0", Offset = "0x11238A0", VA = "0x11238A0")]
			public BendBone()
			{
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x11238DC", Offset = "0x11238DC", VA = "0x11238DC")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x1123934", Offset = "0x1123934", VA = "0x1123934")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x112396C", Offset = "0x112396C", VA = "0x112396C")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0B4C", Offset = "0x5C0B4C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x5C0B84", Offset = "0x5C0B84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0B84", Offset = "0x5C0B84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0B84", Offset = "0x5C0B84")]
		public float positionWeight;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0BFC", Offset = "0x5C0BFC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0BFC", Offset = "0x5C0BFC")]
		public float bodyWeight;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0C50", Offset = "0x5C0C50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0C50", Offset = "0x5C0C50")]
		public float thighWeight;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0CA4", Offset = "0x5C0CA4")]
		public bool handsPullBody;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x5C0CDC", Offset = "0x5C0CDC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0CDC", Offset = "0x5C0CDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0CDC", Offset = "0x5C0CDC")]
		public float rotationWeight;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0D54", Offset = "0x5C0D54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0D54", Offset = "0x5C0D54")]
		public float bodyClampWeight;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0DA8", Offset = "0x5C0DA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0DA8", Offset = "0x5C0DA8")]
		public float headClampWeight;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0DFC", Offset = "0x5C0DFC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0DFC", Offset = "0x5C0DFC")]
		public float bendWeight;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0E50", Offset = "0x5C0E50")]
		public BendBone[] bendBones;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x5C0E88", Offset = "0x5C0E88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0E88", Offset = "0x5C0E88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0E88", Offset = "0x5C0E88")]
		public float CCDWeight;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0F00", Offset = "0x5C0F00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0F00", Offset = "0x5C0F00")]
		public float roll;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0F54", Offset = "0x5C0F54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0F54", Offset = "0x5C0F54")]
		public float damper;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0FAC", Offset = "0x5C0FAC")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x5C0FE4", Offset = "0x5C0FE4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0FE4", Offset = "0x5C0FE4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0FE4", Offset = "0x5C0FE4")]
		public float postStretchWeight;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C105C", Offset = "0x5C105C")]
		public float maxStretch;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1094", Offset = "0x5C1094")]
		public float stretchDamper;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C10CC", Offset = "0x5C10CC")]
		public bool fixHead;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1104", Offset = "0x5C1104")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x5C113C", Offset = "0x5C113C")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1174", Offset = "0x5C1174")]
		public float chestDirectionWeight;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x123A5B4", Offset = "0x123A5B4", VA = "0x123A5B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x123A8E8", Offset = "0x123A8E8", VA = "0x123A8E8")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x123AD88", Offset = "0x123AD88", VA = "0x123AD88")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x123B154", Offset = "0x123B154", VA = "0x123B154")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x123B8E0", Offset = "0x123B8E0", VA = "0x123B8E0")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x123BBC0", Offset = "0x123BBC0", VA = "0x123BBC0")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x123BEC4", Offset = "0x123BEC4", VA = "0x123BEC4")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x123C698", Offset = "0x123C698", VA = "0x123C698")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x123B6C4", Offset = "0x123B6C4", VA = "0x123B6C4")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x123C860", Offset = "0x123C860", VA = "0x123C860")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x123C5B0", Offset = "0x123C5B0", VA = "0x123C5B0")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x123C4E4", Offset = "0x123C4E4", VA = "0x123C4E4")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x123CAE4", Offset = "0x123CAE4", VA = "0x123CAE4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x123CDB4", Offset = "0x123CDB4", VA = "0x123CDB4")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A4")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x200015D")]
		public class ChildConstraint
		{
			[Token(Token = "0x4000918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x4000919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x400091A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x400091B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x400091C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4AA0", Offset = "0x5C4AA0")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x400091D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4AB0", Offset = "0x5C4AB0")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x170000D2")]
			public float nominalDistance
			{
				[Token(Token = "0x60008FE")]
				[Address(RVA = "0x1123A28", Offset = "0x1123A28", VA = "0x1123A28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CABDC", Offset = "0x5CABDC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008FF")]
				[Address(RVA = "0x1123A30", Offset = "0x1123A30", VA = "0x1123A30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CABEC", Offset = "0x5CABEC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D3")]
			public bool isRigid
			{
				[Token(Token = "0x6000900")]
				[Address(RVA = "0x1123A38", Offset = "0x1123A38", VA = "0x1123A38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CABFC", Offset = "0x5CABFC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000901")]
				[Address(RVA = "0x1123A40", Offset = "0x1123A40", VA = "0x1123A40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAC0C", Offset = "0x5CAC0C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000902")]
			[Address(RVA = "0x1123A4C", Offset = "0x1123A4C", VA = "0x1123A4C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0x1123A98", Offset = "0x1123A98", VA = "0x1123A98")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0x1123AF0", Offset = "0x1123AF0", VA = "0x1123AF0")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000905")]
			[Address(RVA = "0x1123C94", Offset = "0x1123C94", VA = "0x1123C94")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200015E")]
		public enum Smoothing
		{
			[Token(Token = "0x4000923")]
			None,
			[Token(Token = "0x4000924")]
			Exponential,
			[Token(Token = "0x4000925")]
			Cubic
		}

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C118C", Offset = "0x5C118C")]
		public float pin;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C11A4", Offset = "0x5C11A4")]
		public float pull;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C11BC", Offset = "0x5C11BC")]
		public float push;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C11D4", Offset = "0x5C11D4")]
		public float pushParent;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C11EC", Offset = "0x5C11EC")]
		public float reach;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x4000439")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x11BC840", Offset = "0x11BC840", VA = "0x11BC840")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x11BC92C", Offset = "0x11BC92C", VA = "0x11BC92C")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x11BCA58", Offset = "0x11BCA58", VA = "0x11BCA58")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x11BCB84", Offset = "0x11BCB84", VA = "0x11BCB84")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x11BCC5C", Offset = "0x11BCC5C", VA = "0x11BCC5C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x11BCD74", Offset = "0x11BCD74", VA = "0x11BCD74")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x11BD3F0", Offset = "0x11BD3F0", VA = "0x11BD3F0")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x11BCF04", Offset = "0x11BCF04", VA = "0x11BCF04")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x11BD7E0", Offset = "0x11BD7E0", VA = "0x11BD7E0")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x11BDA40", Offset = "0x11BDA40", VA = "0x11BDA40")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x11BDCAC", Offset = "0x11BDCAC", VA = "0x11BDCAC")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x11BE050", Offset = "0x11BE050", VA = "0x11BE050")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x11BE4E4", Offset = "0x11BE4E4", VA = "0x11BE4E4")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x11BE708", Offset = "0x11BE708", VA = "0x11BE708")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x11BE474", Offset = "0x11BE474", VA = "0x11BE474")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x11BDEDC", Offset = "0x11BDEDC", VA = "0x11BDEDC")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x11BE3F8", Offset = "0x11BE3F8", VA = "0x11BE3F8")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x11BE7F0", Offset = "0x11BE7F0", VA = "0x11BE7F0")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x11BE318", Offset = "0x11BE318", VA = "0x11BE318")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x11BE5F0", Offset = "0x11BE5F0", VA = "0x11BE5F0")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A5")]
	public class IKConstraintBend
	{
		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1204", Offset = "0x5C1204")]
		public float weight;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C121C", Offset = "0x5C121C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000046")]
		public bool initiated
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x12C1680", Offset = "0x12C1680", VA = "0x12C1680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C95AC", Offset = "0x5C95AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x12C1688", Offset = "0x12C1688", VA = "0x12C1688")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C95BC", Offset = "0x5C95BC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x12C1498", Offset = "0x12C1498", VA = "0x12C1498")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x12C1694", Offset = "0x12C1694", VA = "0x12C1694")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x12C16D4", Offset = "0x12C16D4", VA = "0x12C16D4")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x12C1734", Offset = "0x12C1734", VA = "0x12C1734")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x12C1740", Offset = "0x12C1740", VA = "0x12C1740")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x12C1AB8", Offset = "0x12C1AB8", VA = "0x12C1AB8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x12C1CA8", Offset = "0x12C1CA8", VA = "0x12C1CA8")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x12C1FF4", Offset = "0x12C1FF4", VA = "0x12C1FF4")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x12C1978", Offset = "0x12C1978", VA = "0x12C1978")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x12C1A18", Offset = "0x12C1A18", VA = "0x12C1A18")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000A6")]
	public class IKEffector
	{
		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C122C", Offset = "0x5C122C")]
		public float positionWeight;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1244", Offset = "0x5C1244")]
		public float rotationWeight;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C125C", Offset = "0x5C125C")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C126C", Offset = "0x5C126C")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000047")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x12C24D4", Offset = "0x12C24D4", VA = "0x12C24D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C95CC", Offset = "0x5C95CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x12C24DC", Offset = "0x12C24DC", VA = "0x12C24DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C95DC", Offset = "0x5C95DC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x12C246C", Offset = "0x12C246C", VA = "0x12C246C")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x12C24E8", Offset = "0x12C24E8", VA = "0x12C24E8")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x12C2578", Offset = "0x12C2578", VA = "0x12C2578")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x12C268C", Offset = "0x12C268C", VA = "0x12C268C")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x12C27BC", Offset = "0x12C27BC", VA = "0x12C27BC")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x12C2AD8", Offset = "0x12C2AD8", VA = "0x12C2AD8")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x12C2D58", Offset = "0x12C2D58", VA = "0x12C2D58")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x12C2E24", Offset = "0x12C2E24", VA = "0x12C2E24")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x12C2ECC", Offset = "0x12C2ECC", VA = "0x12C2ECC")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x12C33F4", Offset = "0x12C33F4", VA = "0x12C33F4")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x12C3420", Offset = "0x12C3420", VA = "0x12C3420")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x12C3574", Offset = "0x12C3574", VA = "0x12C3574")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x12C37EC", Offset = "0x12C37EC", VA = "0x12C37EC")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000A7")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x200015F")]
		public class BoneMap
		{
			[Token(Token = "0x4000926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x4000928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x4000929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400092A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x400092B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x400092C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x400092D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x400092E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x400092F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x4000934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x4000935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x4000936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x4000937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x4000938")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000939")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x400093A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x400093B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000D4")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x6000907")]
				[Address(RVA = "0x1127410", Offset = "0x1127410", VA = "0x1127410")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D5")]
			public bool isNodeBone
			{
				[Token(Token = "0x600090A")]
				[Address(RVA = "0x11274EC", Offset = "0x11274EC", VA = "0x11274EC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000D6")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x600091E")]
				[Address(RVA = "0x1127890", Offset = "0x1127890", VA = "0x1127890")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000906")]
			[Address(RVA = "0x11273E4", Offset = "0x11273E4", VA = "0x11273E4")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000908")]
			[Address(RVA = "0x112744C", Offset = "0x112744C", VA = "0x112744C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000909")]
			[Address(RVA = "0x112749C", Offset = "0x112749C", VA = "0x112749C")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x600090B")]
			[Address(RVA = "0x11274FC", Offset = "0x11274FC", VA = "0x11274FC")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x600090C")]
			[Address(RVA = "0x1127584", Offset = "0x1127584", VA = "0x1127584")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x600090D")]
			[Address(RVA = "0x112758C", Offset = "0x112758C", VA = "0x112758C")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x600090E")]
			[Address(RVA = "0x1127664", Offset = "0x1127664", VA = "0x1127664")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x600090F")]
			[Address(RVA = "0x11276DC", Offset = "0x11276DC", VA = "0x11276DC")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000910")]
			[Address(RVA = "0x1127774", Offset = "0x1127774", VA = "0x1127774")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000911")]
			[Address(RVA = "0x11279D0", Offset = "0x11279D0", VA = "0x11279D0")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000912")]
			[Address(RVA = "0x1127A08", Offset = "0x1127A08", VA = "0x1127A08")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000913")]
			[Address(RVA = "0x1127A40", Offset = "0x1127A40", VA = "0x1127A40")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000914")]
			[Address(RVA = "0x1127A68", Offset = "0x1127A68", VA = "0x1127A68")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000915")]
			[Address(RVA = "0x1127B54", Offset = "0x1127B54", VA = "0x1127B54")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0x1127CE0", Offset = "0x1127CE0", VA = "0x1127CE0")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000917")]
			[Address(RVA = "0x1127D10", Offset = "0x1127D10", VA = "0x1127D10")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000918")]
			[Address(RVA = "0x1127DD8", Offset = "0x1127DD8", VA = "0x1127DD8")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000919")]
			[Address(RVA = "0x1127E48", Offset = "0x1127E48", VA = "0x1127E48")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x600091A")]
			[Address(RVA = "0x1127F98", Offset = "0x1127F98", VA = "0x1127F98")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600091B")]
			[Address(RVA = "0x11280E8", Offset = "0x11280E8", VA = "0x11280E8")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x600091C")]
			[Address(RVA = "0x1128168", Offset = "0x1128168", VA = "0x1128168")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600091D")]
			[Address(RVA = "0x1127BD0", Offset = "0x1127BD0", VA = "0x1127BD0")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600091F")]
			[Address(RVA = "0x11282A0", Offset = "0x11282A0", VA = "0x11282A0")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x12C3C94", Offset = "0x12C3C94", VA = "0x12C3C94", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x12C3C9C", Offset = "0x12C3C9C", VA = "0x12C3C9C", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x12C3CA0", Offset = "0x12C3CA0", VA = "0x12C3CA0")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x12C3DE4", Offset = "0x12C3DE4", VA = "0x12C3DE4")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x12C3E54", Offset = "0x12C3E54", VA = "0x12C3E54")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A8")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1284", Offset = "0x5C1284")]
		public float maintainRotationWeight;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x12C3E5C", Offset = "0x12C3E5C", VA = "0x12C3E5C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x12C3F04", Offset = "0x12C3F04", VA = "0x12C3F04")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x12C3F70", Offset = "0x12C3F70", VA = "0x12C3F70")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x12C3FF0", Offset = "0x12C3FF0", VA = "0x12C3FF0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x12C400C", Offset = "0x12C400C", VA = "0x12C400C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x12C402C", Offset = "0x12C402C", VA = "0x12C402C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x12C40B4", Offset = "0x12C40B4", VA = "0x12C40B4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x12C40D0", Offset = "0x12C40D0", VA = "0x12C40D0")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A9")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000160")]
		public enum BoneMapType
		{
			[Token(Token = "0x400093D")]
			Parent,
			[Token(Token = "0x400093E")]
			Bone1,
			[Token(Token = "0x400093F")]
			Bone2,
			[Token(Token = "0x4000940")]
			Bone3
		}

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C129C", Offset = "0x5C129C")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C12B4", Offset = "0x5C12B4")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x12C40F8", Offset = "0x12C40F8", VA = "0x12C40F8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x12C417C", Offset = "0x12C417C", VA = "0x12C417C")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x12C4258", Offset = "0x12C4258", VA = "0x12C4258")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x12C447C", Offset = "0x12C447C", VA = "0x12C447C")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x12C4540", Offset = "0x12C4540", VA = "0x12C4540")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x12C4630", Offset = "0x12C4630", VA = "0x12C4630")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x12C463C", Offset = "0x12C463C", VA = "0x12C463C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x12C46F0", Offset = "0x12C46F0", VA = "0x12C46F0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x12C47B4", Offset = "0x12C47B4", VA = "0x12C47B4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x12C49F4", Offset = "0x12C49F4", VA = "0x12C49F4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x12C4A68", Offset = "0x12C4A68", VA = "0x12C4A68")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AA")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C12CC", Offset = "0x5C12CC")]
		public int iterations;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C12E4", Offset = "0x5C12E4")]
		public float twistWeight;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x12C4BE4", Offset = "0x12C4BE4", VA = "0x12C4BE4", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x12C4F48", Offset = "0x12C4F48", VA = "0x12C4F48")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x12C502C", Offset = "0x12C502C", VA = "0x12C502C")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x12C5144", Offset = "0x12C5144", VA = "0x12C5144")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x12C5154", Offset = "0x12C5154", VA = "0x12C5154")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x12C51C0", Offset = "0x12C51C0", VA = "0x12C51C0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x12C5244", Offset = "0x12C5244", VA = "0x12C5244", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x12C581C", Offset = "0x12C581C", VA = "0x12C581C")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x12C5854", Offset = "0x12C5854", VA = "0x12C5854")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x12C5AD8", Offset = "0x12C5AD8", VA = "0x12C5AD8")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x12C5DD8", Offset = "0x12C5DD8", VA = "0x12C5DD8")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x12C5EC4", Offset = "0x12C5EC4", VA = "0x12C5EC4")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x12C5F8C", Offset = "0x12C5F8C", VA = "0x12C5F8C")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000161")]
		public class Point
		{
			[Token(Token = "0x4000941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000942")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C4AC0", Offset = "0x5C4AC0")]
			public float weight;

			[Token(Token = "0x4000943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000920")]
			[Address(RVA = "0x1128DAC", Offset = "0x1128DAC", VA = "0x1128DAC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000921")]
			[Address(RVA = "0x1128DFC", Offset = "0x1128DFC", VA = "0x1128DFC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0x1128E9C", Offset = "0x1128E9C", VA = "0x1128E9C")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000923")]
			[Address(RVA = "0x1128ED4", Offset = "0x1128ED4", VA = "0x1128ED4")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000924")]
			[Address(RVA = "0x1128F0C", Offset = "0x1128F0C", VA = "0x1128F0C")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000925")]
			[Address(RVA = "0x1128F5C", Offset = "0x1128F5C", VA = "0x1128F5C")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000926")]
			[Address(RVA = "0x112898C", Offset = "0x112898C", VA = "0x112898C")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000162")]
		public class Bone : Point
		{
			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x170000D7")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000927")]
				[Address(RVA = "0x11282BC", Offset = "0x11282BC", VA = "0x11282BC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000928")]
				[Address(RVA = "0x11283B8", Offset = "0x11283B8", VA = "0x11283B8")]
				set
				{
				}
			}

			[Token(Token = "0x6000929")]
			[Address(RVA = "0x112843C", Offset = "0x112843C", VA = "0x112843C")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0x11285EC", Offset = "0x11285EC", VA = "0x11285EC")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600092B")]
			[Address(RVA = "0x11287C0", Offset = "0x11287C0", VA = "0x11287C0")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0x1128920", Offset = "0x1128920", VA = "0x1128920")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600092D")]
			[Address(RVA = "0x1128948", Offset = "0x1128948", VA = "0x1128948")]
			public Bone()
			{
			}

			[Token(Token = "0x600092E")]
			[Address(RVA = "0x11289C8", Offset = "0x11289C8", VA = "0x11289C8")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600092F")]
			[Address(RVA = "0x1128A18", Offset = "0x1128A18", VA = "0x1128A18")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000163")]
		public class Node : Point
		{
			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000930")]
			[Address(RVA = "0x1128D48", Offset = "0x1128D48", VA = "0x1128D48")]
			public Node()
			{
			}

			[Token(Token = "0x6000931")]
			[Address(RVA = "0x1128D4C", Offset = "0x1128D4C", VA = "0x1128D4C")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000932")]
			[Address(RVA = "0x1128D74", Offset = "0x1128D74", VA = "0x1128D74")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000164")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000165")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public bool executedInEditor;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C131C", Offset = "0x5C131C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C131C", Offset = "0x5C131C")]
		public float IKPositionWeight;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C1370", Offset = "0x5C1370")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000048")]
		public bool initiated
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x12C62BC", Offset = "0x12C62BC", VA = "0x12C62BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C95EC", Offset = "0x5C95EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x12C62C4", Offset = "0x12C62C4", VA = "0x12C62C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C95FC", Offset = "0x5C95FC")]
			private set
			{
			}
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x12C61EC", Offset = "0x12C61EC", VA = "0x12C61EC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B9")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x12C12B4", Offset = "0x12C12B4", VA = "0x12C12B4")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x12C11D4", Offset = "0x12C11D4", VA = "0x12C11D4")]
		public void Update()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x12C6264", Offset = "0x12C6264", VA = "0x12C6264", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x12C6270", Offset = "0x12C6270", VA = "0x12C6270")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x12C627C", Offset = "0x12C627C", VA = "0x12C627C")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x12C6284", Offset = "0x12C6284", VA = "0x12C6284")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x12C62B4", Offset = "0x12C62B4", VA = "0x12C62B4")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60004C3")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60004C4")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60004C5")]
		public abstract void FixTransforms();

		[Token(Token = "0x60004C6")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60004C7")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60004C8")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x12C62D0", Offset = "0x12C62D0", VA = "0x12C62D0")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x12C62E8", Offset = "0x12C62E8", VA = "0x12C62E8")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x12C6420", Offset = "0x12C6420", VA = "0x12C6420")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x12C64CC", Offset = "0x12C64CC", VA = "0x12C64CC")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x12C6754", Offset = "0x12C6754", VA = "0x12C6754")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AC")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C13B8", Offset = "0x5C13B8")]
		public float poleWeight;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C13D0", Offset = "0x5C13D0")]
		public float clampWeight;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C13E8", Offset = "0x5C13E8")]
		public int clampSmoothing;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000049")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x12C67E8", Offset = "0x12C67E8", VA = "0x12C67E8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004A")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x12C6824", Offset = "0x12C6824", VA = "0x12C6824")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004B")]
		protected override int minBones
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x12C72B4", Offset = "0x12C72B4", VA = "0x12C72B4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004C")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x12C7698", Offset = "0x12C7698", VA = "0x12C7698", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x12C676C", Offset = "0x12C676C", VA = "0x12C676C")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x12C6860", Offset = "0x12C6860", VA = "0x12C6860", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x12C6A80", Offset = "0x12C6A80", VA = "0x12C6A80", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x12C7200", Offset = "0x12C7200", VA = "0x12C7200")]
		private void Solve()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x12C6F90", Offset = "0x12C6F90", VA = "0x12C6F90")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x12C72BC", Offset = "0x12C72BC", VA = "0x12C72BC")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x12C770C", Offset = "0x12C770C", VA = "0x12C770C")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AD")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1400", Offset = "0x5C1400")]
		public float IKRotationWeight;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x12C7760", Offset = "0x12C7760", VA = "0x12C7760", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x12C7B00", Offset = "0x12C7B00", VA = "0x12C7B00")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x12C7B6C", Offset = "0x12C7B6C", VA = "0x12C7B6C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x12C7CC4", Offset = "0x12C7CC4", VA = "0x12C7CC4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x12C7E58", Offset = "0x12C7E58", VA = "0x12C7E58", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x12C7EB4", Offset = "0x12C7EB4", VA = "0x12C7EB4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x12C7F24", Offset = "0x12C7F24", VA = "0x12C7F24", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x12C8294", Offset = "0x12C8294", VA = "0x12C8294", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x12C82C0", Offset = "0x12C82C0", VA = "0x12C82C0")]
		private void Solve()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x12C7F88", Offset = "0x12C7F88", VA = "0x12C7F88")]
		private void Read()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x12C8330", Offset = "0x12C8330", VA = "0x12C8330")]
		private void Write()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x12C84BC", Offset = "0x12C84BC", VA = "0x12C84BC")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x12C8620", Offset = "0x12C8620", VA = "0x12C8620")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x12C86D0", Offset = "0x12C86D0", VA = "0x12C86D0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x12C8754", Offset = "0x12C8754", VA = "0x12C8754", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x12C8984", Offset = "0x12C8984", VA = "0x12C8984")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x12C8F60", Offset = "0x12C8F60", VA = "0x12C8F60")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AF")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700004D")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x12C9E70", Offset = "0x12C9E70", VA = "0x12C9E70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x12C8F68", Offset = "0x12C8F68", VA = "0x12C8F68")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x12C952C", Offset = "0x12C952C", VA = "0x12C952C")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x12C966C", Offset = "0x12C966C", VA = "0x12C966C", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x12C9700", Offset = "0x12C9700", VA = "0x12C9700", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x12C9BDC", Offset = "0x12C9BDC", VA = "0x12C9BDC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x12C9E78", Offset = "0x12C9E78", VA = "0x12C9E78")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x12C9044", Offset = "0x12C9044", VA = "0x12C9044")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x12C9618", Offset = "0x12C9618", VA = "0x12C9618")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x12C9E14", Offset = "0x12C9E14", VA = "0x12C9E14")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x12C93A0", Offset = "0x12C93A0", VA = "0x12C93A0")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x12CA4C8", Offset = "0x12CA4C8", VA = "0x12CA4C8")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x12CA53C", Offset = "0x12CA53C", VA = "0x12CA53C")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x12CA604", Offset = "0x12CA604", VA = "0x12CA604")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x12CA6B4", Offset = "0x12CA6B4", VA = "0x12CA6B4")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x12C998C", Offset = "0x12C998C", VA = "0x12C998C")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x12C9AB4", Offset = "0x12C9AB4", VA = "0x12C9AB4")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x12CA7B8", Offset = "0x12CA7B8", VA = "0x12CA7B8")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x12CA098", Offset = "0x12CA098", VA = "0x12CA098")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x12C9608", Offset = "0x12C9608", VA = "0x12C9608")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x12CAD48", Offset = "0x12CAD48", VA = "0x12CAD48")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x12CA8FC", Offset = "0x12CA8FC", VA = "0x12CA8FC")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x12C9EF4", Offset = "0x12C9EF4", VA = "0x12C9EF4")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x12C9FD4", Offset = "0x12C9FD4", VA = "0x12C9FD4")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x12CAE14", Offset = "0x12CAE14", VA = "0x12CAE14")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1418", Offset = "0x5C1418")]
		public float rootPin;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x12CAE94", Offset = "0x12CAE94", VA = "0x12CAE94", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x12CB4D4", Offset = "0x12CB4D4", VA = "0x12CB4D4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x12CB56C", Offset = "0x12CB56C", VA = "0x12CB56C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x12CB60C", Offset = "0x12CB60C", VA = "0x12CB60C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x12CB708", Offset = "0x12CB708", VA = "0x12CB708")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x12CB7A4", Offset = "0x12CB7A4", VA = "0x12CB7A4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x12CBBD4", Offset = "0x12CBBD4", VA = "0x12CBBD4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x12CBDCC", Offset = "0x12CBDCC", VA = "0x12CBDCC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x12CBC80", Offset = "0x12CBC80", VA = "0x12CBC80")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x12CB990", Offset = "0x12CB990", VA = "0x12CB990")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x12CBE64", Offset = "0x12CBE64", VA = "0x12CBE64")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1430", Offset = "0x5C1430")]
		public int iterations;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x12CBED8", Offset = "0x12CBED8", VA = "0x12CBED8")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x12CBFC8", Offset = "0x12CBFC8", VA = "0x12CBFC8")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x12CC024", Offset = "0x12CC024", VA = "0x12CC024")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x12C2410", Offset = "0x12C2410", VA = "0x12C2410")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x12C18F8", Offset = "0x12C18F8", VA = "0x12C18F8")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x12CC154", Offset = "0x12CC154", VA = "0x12CC154", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x12CC2F8", Offset = "0x12CC2F8", VA = "0x12CC2F8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x12CC468", Offset = "0x12CC468", VA = "0x12CC468", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x12CC670", Offset = "0x12CC670", VA = "0x12CC670", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x12CC748", Offset = "0x12CC748", VA = "0x12CC748", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x12CC828", Offset = "0x12CC828", VA = "0x12CC828", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x12CC998", Offset = "0x12CC998", VA = "0x12CC998", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x12CCAF8", Offset = "0x12CCAF8", VA = "0x12CCAF8", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x12CCD38", Offset = "0x12CCD38", VA = "0x12CCD38", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x12CD004", Offset = "0x12CD004", VA = "0x12CD004", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x12CD048", Offset = "0x12CD048", VA = "0x12CD048", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x12CD12C", Offset = "0x12CD12C", VA = "0x12CD12C")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B2")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40004C4")]
		Body,
		[Token(Token = "0x40004C5")]
		LeftShoulder,
		[Token(Token = "0x40004C6")]
		RightShoulder,
		[Token(Token = "0x40004C7")]
		LeftThigh,
		[Token(Token = "0x40004C8")]
		RightThigh,
		[Token(Token = "0x40004C9")]
		LeftHand,
		[Token(Token = "0x40004CA")]
		RightHand,
		[Token(Token = "0x40004CB")]
		LeftFoot,
		[Token(Token = "0x40004CC")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x20000B3")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40004CE")]
		LeftArm,
		[Token(Token = "0x40004CF")]
		RightArm,
		[Token(Token = "0x40004D0")]
		LeftLeg,
		[Token(Token = "0x40004D1")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x20000B4")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1448", Offset = "0x5C1448")]
		public float spineStiffness;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1460", Offset = "0x5C1460")]
		public float pullBodyVertical;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1478", Offset = "0x5C1478")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C1490", Offset = "0x5C1490")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700004E")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x12CD238", Offset = "0x12CD238", VA = "0x12CD238")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x12CD380", Offset = "0x12CD380", VA = "0x12CD380")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x12CD388", Offset = "0x12CD388", VA = "0x12CD388")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x12CD390", Offset = "0x12CD390", VA = "0x12CD390")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x12CD398", Offset = "0x12CD398", VA = "0x12CD398")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x12BFF40", Offset = "0x12BFF40", VA = "0x12BFF40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x12BFF38", Offset = "0x12BFF38", VA = "0x12BFF38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x12CD3A0", Offset = "0x12CD3A0", VA = "0x12CD3A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x12CD3A8", Offset = "0x12CD3A8", VA = "0x12CD3A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x12CD3B0", Offset = "0x12CD3B0", VA = "0x12CD3B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x12CD3E8", Offset = "0x12CD3E8", VA = "0x12CD3E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x12CD420", Offset = "0x12CD420", VA = "0x12CD420")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x12CD458", Offset = "0x12CD458", VA = "0x12CD458")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x12CD490", Offset = "0x12CD490", VA = "0x12CD490")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x12CD4C4", Offset = "0x12CD4C4", VA = "0x12CD4C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x12CD4FC", Offset = "0x12CD4FC", VA = "0x12CD4FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x12CD534", Offset = "0x12CD534", VA = "0x12CD534")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x12CD56C", Offset = "0x12CD56C", VA = "0x12CD56C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x12CF3C0", Offset = "0x12CF3C0", VA = "0x12CF3C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C960C", Offset = "0x5C960C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x12CF3CC", Offset = "0x12CF3CC", VA = "0x12CF3CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C961C", Offset = "0x5C961C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x12CD5A0", Offset = "0x12CD5A0", VA = "0x12CD5A0")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x12CD6AC", Offset = "0x12CD6AC", VA = "0x12CD6AC")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x12CD5F4", Offset = "0x12CD5F4", VA = "0x12CD5F4")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x12CD738", Offset = "0x12CD738", VA = "0x12CD738")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x12CD240", Offset = "0x12CD240", VA = "0x12CD240")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x12CD808", Offset = "0x12CD808", VA = "0x12CD808")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x12CD8C0", Offset = "0x12CD8C0", VA = "0x12CD8C0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x12CD974", Offset = "0x12CD974", VA = "0x12CD974")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x12CDA28", Offset = "0x12CDA28", VA = "0x12CDA28")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x12CDA30", Offset = "0x12CDA30", VA = "0x12CDA30")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x12CDA64", Offset = "0x12CDA64", VA = "0x12CDA64")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x12CDB2C", Offset = "0x12CDB2C", VA = "0x12CDB2C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x12CDCD0", Offset = "0x12CDCD0", VA = "0x12CDCD0")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x12CEE48", Offset = "0x12CEE48", VA = "0x12CEE48")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x12CF25C", Offset = "0x12CF25C", VA = "0x12CF25C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x12CF2BC", Offset = "0x12CF2BC", VA = "0x12CF2BC")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x12CF0E4", Offset = "0x12CF0E4", VA = "0x12CF0E4")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x12CF1A0", Offset = "0x12CF1A0", VA = "0x12CF1A0")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x12CF3D8", Offset = "0x12CF3D8", VA = "0x12CF3D8")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x12CF4B0", Offset = "0x12CF4B0", VA = "0x12CF4B0", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x12CF5A8", Offset = "0x12CF5A8", VA = "0x12CF5A8")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x12CF6D0", Offset = "0x12CF6D0", VA = "0x12CF6D0")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x12CF814", Offset = "0x12CF814", VA = "0x12CF814")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x12CF944", Offset = "0x12CF944", VA = "0x12CF944", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x12CFB80", Offset = "0x12CFB80", VA = "0x12CFB80", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x12CFC04", Offset = "0x12CFC04", VA = "0x12CFC04")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B5")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000061")]
		protected virtual int minBones
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x11F2B5C", Offset = "0x11F2B5C", VA = "0x11F2B5C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000062")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x11F2B64", Offset = "0x11F2B64", VA = "0x11F2B64", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000063")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x11F2B6C", Offset = "0x11F2B6C", VA = "0x11F2B6C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x11F2FF4", Offset = "0x11F2FF4", VA = "0x11F2FF4", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000065")]
		protected float positionOffset
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x11F30BC", Offset = "0x11F30BC", VA = "0x11F30BC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x11F22FC", Offset = "0x11F22FC", VA = "0x11F22FC")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x11F2498", Offset = "0x11F2498", VA = "0x11F2498")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x11F25D0", Offset = "0x11F25D0", VA = "0x11F25D0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x11F263C", Offset = "0x11F263C", VA = "0x11F263C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x11F26BC", Offset = "0x11F26BC", VA = "0x11F26BC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x11F2A64", Offset = "0x11F2A64", VA = "0x11F2A64", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x11F2A6C", Offset = "0x11F2A6C", VA = "0x11F2A6C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x11F2B74", Offset = "0x11F2B74", VA = "0x11F2B74", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x11F2B78", Offset = "0x11F2B78", VA = "0x11F2B78", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x11F2B7C", Offset = "0x11F2B7C", VA = "0x11F2B7C")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x11F3110", Offset = "0x11F3110", VA = "0x11F3110")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x11F3428", Offset = "0x11F3428", VA = "0x11F3428")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x11F361C", Offset = "0x11F361C", VA = "0x11F361C")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C14A0", Offset = "0x5C14A0")]
		public float IKRotationWeight;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x11F3688", Offset = "0x11F3688", VA = "0x11F3688", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x11F3A28", Offset = "0x11F3A28", VA = "0x11F3A28")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x11F3A98", Offset = "0x11F3A98", VA = "0x11F3A98", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x11F3BF0", Offset = "0x11F3BF0", VA = "0x11F3BF0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x11F3D84", Offset = "0x11F3D84", VA = "0x11F3D84", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x11F3DE0", Offset = "0x11F3DE0", VA = "0x11F3DE0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x11F3E50", Offset = "0x11F3E50", VA = "0x11F3E50", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x11F41C0", Offset = "0x11F41C0", VA = "0x11F41C0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x11F41EC", Offset = "0x11F41EC", VA = "0x11F41EC")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x11F3EB4", Offset = "0x11F3EB4", VA = "0x11F3EB4")]
		private void Read()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x11F4284", Offset = "0x11F4284", VA = "0x11F4284")]
		private void Write()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x11F4410", Offset = "0x11F4410", VA = "0x11F4410")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x2000166")]
		public enum BendModifier
		{
			[Token(Token = "0x4000951")]
			Animation,
			[Token(Token = "0x4000952")]
			Target,
			[Token(Token = "0x4000953")]
			Parent,
			[Token(Token = "0x4000954")]
			Arm,
			[Token(Token = "0x4000955")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000167")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x600093B")]
			[Address(RVA = "0x1129200", Offset = "0x1129200", VA = "0x1129200")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C14B8", Offset = "0x5C14B8")]
		public float maintainRotationWeight;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C14D0", Offset = "0x5C14D0")]
		public float bendModifierWeight;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000066")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x11F568C", Offset = "0x11F568C", VA = "0x11F568C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x11F4568", Offset = "0x11F4568", VA = "0x11F4568")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x11F45B8", Offset = "0x11F45B8", VA = "0x11F45B8")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x11F4604", Offset = "0x11F4604", VA = "0x11F4604", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x11F4AD8", Offset = "0x11F4AD8", VA = "0x11F4AD8", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x11F5420", Offset = "0x11F5420", VA = "0x11F5420", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x11F54CC", Offset = "0x11F54CC", VA = "0x11F54CC")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x11F5608", Offset = "0x11F5608", VA = "0x11F5608")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x11F4900", Offset = "0x11F4900", VA = "0x11F4900")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x11F4BBC", Offset = "0x11F4BBC", VA = "0x11F4BBC")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000B8")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000168")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x170000D8")]
			public Vector3 forward
			{
				[Token(Token = "0x6000940")]
				[Address(RVA = "0x112948C", Offset = "0x112948C", VA = "0x112948C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600093C")]
			[Address(RVA = "0x1129260", Offset = "0x1129260", VA = "0x1129260")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x1129264", Offset = "0x1129264", VA = "0x1129264")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0x112928C", Offset = "0x112928C", VA = "0x112928C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0x1129384", Offset = "0x1129384", VA = "0x1129384")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C14E8", Offset = "0x5C14E8")]
		public float bodyWeight;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1500", Offset = "0x5C1500")]
		public float headWeight;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1518", Offset = "0x5C1518")]
		public float eyesWeight;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1530", Offset = "0x5C1530")]
		public float clampWeight;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1548", Offset = "0x5C1548")]
		public float clampWeightHead;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1560", Offset = "0x5C1560")]
		public float clampWeightEyes;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1578", Offset = "0x5C1578")]
		public int clampSmoothing;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool isDirty;

		[Token(Token = "0x17000067")]
		protected bool spineIsValid
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x11F5E3C", Offset = "0x11F5E3C", VA = "0x11F5E3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0x11F600C", Offset = "0x11F600C", VA = "0x11F600C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		protected bool headIsValid
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x11F5F1C", Offset = "0x11F5F1C", VA = "0x11F5F1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x11F6030", Offset = "0x11F6030", VA = "0x11F6030")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x11F5F2C", Offset = "0x11F5F2C", VA = "0x11F5F2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x11F60A8", Offset = "0x11F60A8", VA = "0x11F60A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x11F56A8", Offset = "0x11F56A8", VA = "0x11F56A8")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x11F56D8", Offset = "0x11F56D8", VA = "0x11F56D8")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x11F5730", Offset = "0x11F5730", VA = "0x11F5730")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x11F57AC", Offset = "0x11F57AC", VA = "0x11F57AC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x11F5844", Offset = "0x11F5844", VA = "0x11F5844")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x11F5904", Offset = "0x11F5904", VA = "0x11F5904")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x11F5A00", Offset = "0x11F5A00", VA = "0x11F5A00", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x11F5B2C", Offset = "0x11F5B2C", VA = "0x11F5B2C")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x11F5B38", Offset = "0x11F5B38", VA = "0x11F5B38", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x11F5C7C", Offset = "0x11F5C7C", VA = "0x11F5C7C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x11F60CC", Offset = "0x11F60CC", VA = "0x11F60CC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x11F630C", Offset = "0x11F630C", VA = "0x11F630C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x11F64A8", Offset = "0x11F64A8", VA = "0x11F64A8")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x11F66D8", Offset = "0x11F66D8", VA = "0x11F66D8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x11F69AC", Offset = "0x11F69AC", VA = "0x11F69AC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x11F6A7C", Offset = "0x11F6A7C", VA = "0x11F6A7C")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x11F6C1C", Offset = "0x11F6C1C", VA = "0x11F6C1C")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x11F6E40", Offset = "0x11F6E40", VA = "0x11F6E40")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x11F71F4", Offset = "0x11F71F4", VA = "0x11F71F4")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x11F6554", Offset = "0x11F6554", VA = "0x11F6554")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x11F7464", Offset = "0x11F7464", VA = "0x11F7464")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000169")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000941")]
			[Address(RVA = "0x11294C8", Offset = "0x11294C8", VA = "0x11294C8")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000942")]
			[Address(RVA = "0x11295C4", Offset = "0x11295C4", VA = "0x11295C4")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000943")]
			[Address(RVA = "0x11295F4", Offset = "0x11295F4", VA = "0x11295F4")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000944")]
			[Address(RVA = "0x1129630", Offset = "0x1129630", VA = "0x1129630")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1590", Offset = "0x5C1590")]
		public float IKRotationWeight;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x11F7670", Offset = "0x11F7670", VA = "0x11F7670")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x11F77CC", Offset = "0x11F77CC", VA = "0x11F77CC")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x11F7910", Offset = "0x11F7910", VA = "0x11F7910")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x11F791C", Offset = "0x11F791C", VA = "0x11F791C")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x11F794C", Offset = "0x11F794C", VA = "0x11F794C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x11F7958", Offset = "0x11F7958", VA = "0x11F7958")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x11F7960", Offset = "0x11F7960", VA = "0x11F7960", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x11F7A60", Offset = "0x11F7A60", VA = "0x11F7A60", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x11F7B7C", Offset = "0x11F7B7C", VA = "0x11F7B7C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x11F7BC8", Offset = "0x11F7BC8", VA = "0x11F7BC8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x11F7C28", Offset = "0x11F7C28", VA = "0x11F7C28", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x11F7FF0", Offset = "0x11F7FF0", VA = "0x11F7FF0")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x11F8048", Offset = "0x11F8048", VA = "0x11F8048")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x11F8404", Offset = "0x11F8404", VA = "0x11F8404")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x11F856C", Offset = "0x11F856C", VA = "0x11F856C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x11F86D4", Offset = "0x11F86D4", VA = "0x11F86D4")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x11F8648", Offset = "0x11F8648", VA = "0x11F8648")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x11F87D8", Offset = "0x11F87D8", VA = "0x11F87D8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x11F8FAC", Offset = "0x11F8FAC", VA = "0x11F8FAC", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x11F8FB0", Offset = "0x11F8FB0", VA = "0x11F8FB0", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x11F8FB4", Offset = "0x11F8FB4", VA = "0x11F8FB4", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x11F8DC4", Offset = "0x11F8DC4", VA = "0x11F8DC4")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x11F553C", Offset = "0x11F553C", VA = "0x11F553C")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BA")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200016A")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20001AF")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000B4D")]
				YawPitch,
				[Token(Token = "0x4000B4E")]
				FromTo
			}

			[Token(Token = "0x400095C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4AD8", Offset = "0x5C4AD8")]
			public Transform target;

			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4B10", Offset = "0x5C4B10")]
			public Transform bendGoal;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4B48", Offset = "0x5C4B48")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C4B48", Offset = "0x5C4B48")]
			public float positionWeight;

			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4B9C", Offset = "0x5C4B9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C4B9C", Offset = "0x5C4B9C")]
			public float rotationWeight;

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4BF0", Offset = "0x5C4BF0")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4C28", Offset = "0x5C4C28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C4C28", Offset = "0x5C4C28")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4C7C", Offset = "0x5C4C7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C4C7C", Offset = "0x5C4C7C")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4CD0", Offset = "0x5C4CD0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C4CD0", Offset = "0x5C4CD0")]
			public float bendGoalWeight;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4D24", Offset = "0x5C4D24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C4D24", Offset = "0x5C4D24")]
			public float swivelOffset;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4D80", Offset = "0x5C4D80")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4DB8", Offset = "0x5C4DB8")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4DF0", Offset = "0x5C4DF0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C4DF0", Offset = "0x5C4DF0")]
			public float armLengthMlp;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4E48", Offset = "0x5C4E48")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4EC0", Offset = "0x5C4EC0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4ED0", Offset = "0x5C4ED0")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x4000977")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000978")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000D9")]
			public Vector3 position
			{
				[Token(Token = "0x6000945")]
				[Address(RVA = "0x1129634", Offset = "0x1129634", VA = "0x1129634")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAC1C", Offset = "0x5CAC1C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000946")]
				[Address(RVA = "0x1129640", Offset = "0x1129640", VA = "0x1129640")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAC2C", Offset = "0x5CAC2C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DA")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000947")]
				[Address(RVA = "0x112964C", Offset = "0x112964C", VA = "0x112964C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAC3C", Offset = "0x5CAC3C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000948")]
				[Address(RVA = "0x1129658", Offset = "0x1129658", VA = "0x1129658")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAC4C", Offset = "0x5CAC4C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DB")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000949")]
				[Address(RVA = "0x1129664", Offset = "0x1129664", VA = "0x1129664")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DC")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600094A")]
				[Address(RVA = "0x1129698", Offset = "0x1129698", VA = "0x1129698")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DD")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600094B")]
				[Address(RVA = "0x11296D8", Offset = "0x11296D8", VA = "0x11296D8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DE")]
			private VirtualBone hand
			{
				[Token(Token = "0x600094C")]
				[Address(RVA = "0x1129724", Offset = "0x1129724", VA = "0x1129724")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600094D")]
			[Address(RVA = "0x1129770", Offset = "0x1129770", VA = "0x1129770", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600094E")]
			[Address(RVA = "0x112A030", Offset = "0x112A030", VA = "0x112A030", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600094F")]
			[Address(RVA = "0x112A1EC", Offset = "0x112A1EC", VA = "0x112A1EC", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000950")]
			[Address(RVA = "0x112A210", Offset = "0x112A210", VA = "0x112A210")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000951")]
			[Address(RVA = "0x112A4B0", Offset = "0x112A4B0", VA = "0x112A4B0")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000952")]
			[Address(RVA = "0x112BA20", Offset = "0x112BA20", VA = "0x112BA20", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000953")]
			[Address(RVA = "0x112BA4C", Offset = "0x112BA4C", VA = "0x112BA4C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000954")]
			[Address(RVA = "0x112B45C", Offset = "0x112B45C", VA = "0x112B45C")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0x112B4D8", Offset = "0x112B4D8", VA = "0x112B4D8")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0x112BC6C", Offset = "0x112BC6C", VA = "0x112BC6C")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000957")]
			[Address(RVA = "0x112BD90", Offset = "0x112BD90", VA = "0x112BD90")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200016B")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4EE0", Offset = "0x5C4EE0")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4EF0", Offset = "0x5C4EF0")]
			private float <mag>k__BackingField;

			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x170000DF")]
			public float sqrMag
			{
				[Token(Token = "0x600095D")]
				[Address(RVA = "0x112BEE8", Offset = "0x112BEE8", VA = "0x112BEE8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAC5C", Offset = "0x5CAC5C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600095E")]
				[Address(RVA = "0x112BEF0", Offset = "0x112BEF0", VA = "0x112BEF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAC6C", Offset = "0x5CAC6C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E0")]
			public float mag
			{
				[Token(Token = "0x600095F")]
				[Address(RVA = "0x112BEF8", Offset = "0x112BEF8", VA = "0x112BEF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAC7C", Offset = "0x5CAC7C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000960")]
				[Address(RVA = "0x112BF00", Offset = "0x112BF00", VA = "0x112BF00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAC8C", Offset = "0x5CAC8C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000958")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000959")]
			public abstract void PreSolve();

			[Token(Token = "0x600095A")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x600095B")]
			public abstract void ApplyOffsets(float scale);

			[Token(Token = "0x600095C")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000961")]
			[Address(RVA = "0x112BF08", Offset = "0x112BF08", VA = "0x112BF08")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000962")]
			[Address(RVA = "0x112BF10", Offset = "0x112BF10", VA = "0x112BF10")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000963")]
			[Address(RVA = "0x112BFE4", Offset = "0x112BFE4", VA = "0x112BFE4")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000964")]
			[Address(RVA = "0x112C078", Offset = "0x112C078", VA = "0x112C078")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000965")]
			[Address(RVA = "0x112C124", Offset = "0x112C124", VA = "0x112C124")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000966")]
			[Address(RVA = "0x112C178", Offset = "0x112C178", VA = "0x112C178")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000967")]
			[Address(RVA = "0x112B8DC", Offset = "0x112B8DC", VA = "0x112B8DC")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000968")]
			[Address(RVA = "0x112C2B4", Offset = "0x112C2B4", VA = "0x112C2B4")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0x112C3F4", Offset = "0x112C3F4", VA = "0x112C3F4")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600096A")]
			[Address(RVA = "0x112BE74", Offset = "0x112BE74", VA = "0x112BE74")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200016C")]
		public class Footstep
		{
			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool relaxFlag;

			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4F10", Offset = "0x5C4F10")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x400098E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000E1")]
			public bool isStepping
			{
				[Token(Token = "0x600096B")]
				[Address(RVA = "0x112C41C", Offset = "0x112C41C", VA = "0x112C41C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E2")]
			public float stepProgress
			{
				[Token(Token = "0x600096C")]
				[Address(RVA = "0x112C430", Offset = "0x112C430", VA = "0x112C430")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAC9C", Offset = "0x5CAC9C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600096D")]
				[Address(RVA = "0x112C438", Offset = "0x112C438", VA = "0x112C438")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CACAC", Offset = "0x5CACAC")]
				private set
				{
				}
			}

			[Token(Token = "0x600096E")]
			[Address(RVA = "0x112C440", Offset = "0x112C440", VA = "0x112C440")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600096F")]
			[Address(RVA = "0x112C578", Offset = "0x112C578", VA = "0x112C578")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000970")]
			[Address(RVA = "0x112C5C0", Offset = "0x112C5C0", VA = "0x112C5C0")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000971")]
			[Address(RVA = "0x112C78C", Offset = "0x112C78C", VA = "0x112C78C")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000972")]
			[Address(RVA = "0x112C900", Offset = "0x112C900", VA = "0x112C900")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000973")]
			[Address(RVA = "0x112CA58", Offset = "0x112CA58", VA = "0x112CA58")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200016D")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4F20", Offset = "0x5C4F20")]
			public Transform target;

			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4F58", Offset = "0x5C4F58")]
			public Transform bendGoal;

			[Token(Token = "0x4000992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4F90", Offset = "0x5C4F90")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C4F90", Offset = "0x5C4F90")]
			public float positionWeight;

			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4FE4", Offset = "0x5C4FE4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C4FE4", Offset = "0x5C4FE4")]
			public float rotationWeight;

			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5038", Offset = "0x5C5038")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C5038", Offset = "0x5C5038")]
			public float bendGoalWeight;

			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C508C", Offset = "0x5C508C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C508C", Offset = "0x5C508C")]
			public float swivelOffset;

			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C50E8", Offset = "0x5C50E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C50E8", Offset = "0x5C50E8")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C513C", Offset = "0x5C513C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C513C", Offset = "0x5C513C")]
			public float legLengthMlp;

			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5194", Offset = "0x5C5194")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400099C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400099D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400099E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x400099F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C523C", Offset = "0x5C523C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C524C", Offset = "0x5C524C")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C525C", Offset = "0x5C525C")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C526C", Offset = "0x5C526C")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x170000E3")]
			public Vector3 position
			{
				[Token(Token = "0x6000974")]
				[Address(RVA = "0x112CB94", Offset = "0x112CB94", VA = "0x112CB94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CACBC", Offset = "0x5CACBC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000975")]
				[Address(RVA = "0x112CBA0", Offset = "0x112CBA0", VA = "0x112CBA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CACCC", Offset = "0x5CACCC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E4")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000976")]
				[Address(RVA = "0x112CBAC", Offset = "0x112CBAC", VA = "0x112CBAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CACDC", Offset = "0x5CACDC")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000977")]
				[Address(RVA = "0x112CBB8", Offset = "0x112CBB8", VA = "0x112CBB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CACEC", Offset = "0x5CACEC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E5")]
			public bool hasToes
			{
				[Token(Token = "0x6000978")]
				[Address(RVA = "0x112CBC4", Offset = "0x112CBC4", VA = "0x112CBC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CACFC", Offset = "0x5CACFC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000979")]
				[Address(RVA = "0x112CBCC", Offset = "0x112CBCC", VA = "0x112CBCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAD0C", Offset = "0x5CAD0C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E6")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600097A")]
				[Address(RVA = "0x112CBD8", Offset = "0x112CBD8", VA = "0x112CBD8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E7")]
			private VirtualBone calf
			{
				[Token(Token = "0x600097B")]
				[Address(RVA = "0x112CC0C", Offset = "0x112CC0C", VA = "0x112CC0C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E8")]
			private VirtualBone foot
			{
				[Token(Token = "0x600097C")]
				[Address(RVA = "0x112CC44", Offset = "0x112CC44", VA = "0x112CC44")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E9")]
			private VirtualBone toes
			{
				[Token(Token = "0x600097D")]
				[Address(RVA = "0x112CC7C", Offset = "0x112CC7C", VA = "0x112CC7C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EA")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600097E")]
				[Address(RVA = "0x112CCB4", Offset = "0x112CCB4", VA = "0x112CCB4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EB")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600097F")]
				[Address(RVA = "0x112CCF4", Offset = "0x112CCF4", VA = "0x112CCF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAD1C", Offset = "0x5CAD1C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000980")]
				[Address(RVA = "0x112CD00", Offset = "0x112CD00", VA = "0x112CD00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAD2C", Offset = "0x5CAD2C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000981")]
			[Address(RVA = "0x112CD0C", Offset = "0x112CD0C", VA = "0x112CD0C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000982")]
			[Address(RVA = "0x112D340", Offset = "0x112D340", VA = "0x112D340", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000983")]
			[Address(RVA = "0x112D914", Offset = "0x112D914", VA = "0x112D914", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000984")]
			[Address(RVA = "0x112D8C4", Offset = "0x112D8C4", VA = "0x112D8C4")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0x112D754", Offset = "0x112D754", VA = "0x112D754")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000986")]
			[Address(RVA = "0x112DCFC", Offset = "0x112DCFC", VA = "0x112DCFC")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000987")]
			[Address(RVA = "0x112E1C0", Offset = "0x112E1C0", VA = "0x112E1C0")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x6000988")]
			[Address(RVA = "0x112DEA0", Offset = "0x112DEA0", VA = "0x112DEA0")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000989")]
			[Address(RVA = "0x112E4B8", Offset = "0x112E4B8", VA = "0x112E4B8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600098A")]
			[Address(RVA = "0x112E6D4", Offset = "0x112E6D4", VA = "0x112E6D4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600098B")]
			[Address(RVA = "0x112E720", Offset = "0x112E720", VA = "0x112E720")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200016E")]
		public class Locomotion
		{
			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C527C", Offset = "0x5C527C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C527C", Offset = "0x5C527C")]
			public float weight;

			[Token(Token = "0x40009AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C52D0", Offset = "0x5C52D0")]
			public float footDistance;

			[Token(Token = "0x40009AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5308", Offset = "0x5C5308")]
			public float stepThreshold;

			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5340", Offset = "0x5C5340")]
			public float angleThreshold;

			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5378", Offset = "0x5C5378")]
			public float comAngleMlp;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C53B0", Offset = "0x5C53B0")]
			public float maxVelocity;

			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C53E8", Offset = "0x5C53E8")]
			public float velocityFactor;

			[Token(Token = "0x40009B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5420", Offset = "0x5C5420")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C5420", Offset = "0x5C5420")]
			public float maxLegStretch;

			[Token(Token = "0x40009B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5478", Offset = "0x5C5478")]
			public float rootSpeed;

			[Token(Token = "0x40009B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C54B0", Offset = "0x5C54B0")]
			public float stepSpeed;

			[Token(Token = "0x40009B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C54E8", Offset = "0x5C54E8")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40009B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5520", Offset = "0x5C5520")]
			public float maxBodyYOffset;

			[Token(Token = "0x40009B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5558", Offset = "0x5C5558")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40009B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5590", Offset = "0x5C5590")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C5590", Offset = "0x5C5590")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40009B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C55E8", Offset = "0x5C55E8")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40009BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5620", Offset = "0x5C5620")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40009BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5658", Offset = "0x5C5658")]
			public Vector3 offset;

			[Token(Token = "0x40009BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40009BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40009BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40009BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40009C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C56D0", Offset = "0x5C56D0")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40009C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5708", Offset = "0x5C5708")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40009C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C5740", Offset = "0x5C5740")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40009C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Footstep[] footsteps;

			[Token(Token = "0x40009C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40009C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private Vector3 comVelocity;

			[Token(Token = "0x40009C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int leftFootIndex;

			[Token(Token = "0x40009C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int rightFootIndex;

			[Token(Token = "0x170000EC")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x600098C")]
				[Address(RVA = "0x112E7F0", Offset = "0x112E7F0", VA = "0x112E7F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAD3C", Offset = "0x5CAD3C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600098D")]
				[Address(RVA = "0x112E7FC", Offset = "0x112E7FC", VA = "0x112E7FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAD4C", Offset = "0x5CAD4C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000ED")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000994")]
				[Address(RVA = "0x11303A8", Offset = "0x11303A8", VA = "0x11303A8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000EE")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000995")]
				[Address(RVA = "0x11303E8", Offset = "0x11303E8", VA = "0x11303E8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000EF")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000996")]
				[Address(RVA = "0x113042C", Offset = "0x113042C", VA = "0x113042C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000F0")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000997")]
				[Address(RVA = "0x113046C", Offset = "0x113046C", VA = "0x113046C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600098E")]
			[Address(RVA = "0x112E808", Offset = "0x112E808", VA = "0x112E808")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x600098F")]
			[Address(RVA = "0x112EAC4", Offset = "0x112EAC4", VA = "0x112EAC4")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000990")]
			[Address(RVA = "0x112EC94", Offset = "0x112EC94", VA = "0x112EC94")]
			public void Relax()
			{
			}

			[Token(Token = "0x6000991")]
			[Address(RVA = "0x112ECF8", Offset = "0x112ECF8", VA = "0x112ECF8")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000992")]
			[Address(RVA = "0x112EF40", Offset = "0x112EF40", VA = "0x112EF40")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0x112F004", Offset = "0x112F004", VA = "0x112F004")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Token(Token = "0x6000998")]
			[Address(RVA = "0x1130120", Offset = "0x1130120", VA = "0x1130120")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000999")]
			[Address(RVA = "0x1130258", Offset = "0x1130258", VA = "0x1130258")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600099A")]
			[Address(RVA = "0x11302DC", Offset = "0x11302DC", VA = "0x11302DC")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600099B")]
			[Address(RVA = "0x11304B0", Offset = "0x11304B0", VA = "0x11304B0")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200016F")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5750", Offset = "0x5C5750")]
			public Transform headTarget;

			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5788", Offset = "0x5C5788")]
			public Transform pelvisTarget;

			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C57C0", Offset = "0x5C57C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C57C0", Offset = "0x5C57C0")]
			public float positionWeight;

			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5814", Offset = "0x5C5814")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C5814", Offset = "0x5C5814")]
			public float rotationWeight;

			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5868", Offset = "0x5C5868")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C5868", Offset = "0x5C5868")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40009CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C58BC", Offset = "0x5C58BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C58BC", Offset = "0x5C58BC")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40009CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5910", Offset = "0x5C5910")]
			public Transform chestGoal;

			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5948", Offset = "0x5C5948")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C5948", Offset = "0x5C5948")]
			public float chestGoalWeight;

			[Token(Token = "0x40009D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C599C", Offset = "0x5C599C")]
			public float minHeadHeight;

			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C59D4", Offset = "0x5C59D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C59D4", Offset = "0x5C59D4")]
			public float bodyPosStiffness;

			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5A28", Offset = "0x5C5A28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C5A28", Offset = "0x5C5A28")]
			public float bodyRotStiffness;

			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5A7C", Offset = "0x5C5A7C")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5C5A7C", Offset = "0x5C5A7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C5A7C", Offset = "0x5C5A7C")]
			public float neckStiffness;

			[Token(Token = "0x40009D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5AF4", Offset = "0x5C5AF4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C5AF4", Offset = "0x5C5AF4")]
			public float rotateChestByHands;

			[Token(Token = "0x40009D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5B48", Offset = "0x5C5B48")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C5B48", Offset = "0x5C5B48")]
			public float chestClampWeight;

			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5B9C", Offset = "0x5C5B9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C5B9C", Offset = "0x5C5B9C")]
			public float headClampWeight;

			[Token(Token = "0x40009D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5BF0", Offset = "0x5C5BF0")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40009D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5C28", Offset = "0x5C5C28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C5C28", Offset = "0x5C5C28")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40009D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5C7C", Offset = "0x5C5C7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C5C7C", Offset = "0x5C5C7C")]
			public float maxRootAngle;

			[Token(Token = "0x40009DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5CD4", Offset = "0x5C5CD4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C5CD4", Offset = "0x5C5CD4")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40009DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40009DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40009DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40009DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40009DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40009E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40009E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40009E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40009E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40009E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40009E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40009E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40009E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40009E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40009E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C5E10", Offset = "0x5C5E10")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40009EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C5E20", Offset = "0x5C5E20")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Token(Token = "0x40009EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x40009EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40009ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40009EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40009EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40009F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40009F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40009F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40009F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x40009F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x40009F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x40009F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x40009F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x40009F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x40009F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x40009FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x40009FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x40009FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x40009FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x40009FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x170000F1")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x600099C")]
				[Address(RVA = "0x12ECC04", Offset = "0x12ECC04", VA = "0x12ECC04")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F2")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600099D")]
				[Address(RVA = "0x12ECC44", Offset = "0x12ECC44", VA = "0x12ECC44")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F3")]
			public VirtualBone chest
			{
				[Token(Token = "0x600099E")]
				[Address(RVA = "0x12ECC84", Offset = "0x12ECC84", VA = "0x12ECC84")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F4")]
			private VirtualBone neck
			{
				[Token(Token = "0x600099F")]
				[Address(RVA = "0x12ECCD8", Offset = "0x12ECCD8", VA = "0x12ECCD8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F5")]
			public VirtualBone head
			{
				[Token(Token = "0x60009A0")]
				[Address(RVA = "0x12ECD18", Offset = "0x12ECD18", VA = "0x12ECD18")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F6")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x60009A1")]
				[Address(RVA = "0x12ECD58", Offset = "0x12ECD58", VA = "0x12ECD58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAD5C", Offset = "0x5CAD5C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60009A2")]
				[Address(RVA = "0x12ECD6C", Offset = "0x12ECD6C", VA = "0x12ECD6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAD6C", Offset = "0x5CAD6C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F7")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x60009A3")]
				[Address(RVA = "0x12ECD80", Offset = "0x12ECD80", VA = "0x12ECD80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAD7C", Offset = "0x5CAD7C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60009A4")]
				[Address(RVA = "0x12ECD94", Offset = "0x12ECD94", VA = "0x12ECD94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAD8C", Offset = "0x5CAD8C")]
				private set
				{
				}
			}

			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x12ECDA8", Offset = "0x12ECDA8", VA = "0x12ECDA8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x12ED850", Offset = "0x12ED850", VA = "0x12ED850", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x12EDA5C", Offset = "0x12EDA5C", VA = "0x12EDA5C", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x12EDEA8", Offset = "0x12EDEA8", VA = "0x12EDEA8")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x12EE2E4", Offset = "0x12EE2E4", VA = "0x12EE2E4")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x12EEA58", Offset = "0x12EEA58", VA = "0x12EEA58")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x12EF0DC", Offset = "0x12EF0DC", VA = "0x12EF0DC")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x12EFA64", Offset = "0x12EFA64", VA = "0x12EFA64", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x12EFC40", Offset = "0x12EFC40", VA = "0x12EFC40", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x12EE040", Offset = "0x12EE040", VA = "0x12EE040")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x12EEE28", Offset = "0x12EEE28", VA = "0x12EEE28")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x12EE6FC", Offset = "0x12EE6FC", VA = "0x12EE6FC")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x12EFCD8", Offset = "0x12EFCD8", VA = "0x12EFCD8")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x12EEF08", Offset = "0x12EEF08", VA = "0x12EEF08")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x12EEBD4", Offset = "0x12EEBD4", VA = "0x12EEBD4")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x12F0000", Offset = "0x12F0000", VA = "0x12F0000")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000170")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000A00")]
			Pelvis,
			[Token(Token = "0x4000A01")]
			Chest,
			[Token(Token = "0x4000A02")]
			Head,
			[Token(Token = "0x4000A03")]
			LeftHand,
			[Token(Token = "0x4000A04")]
			RightHand,
			[Token(Token = "0x4000A05")]
			LeftFoot,
			[Token(Token = "0x4000A06")]
			RightFoot,
			[Token(Token = "0x4000A07")]
			LeftHeel,
			[Token(Token = "0x4000A08")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000171")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000A0A")]
			Pelvis,
			[Token(Token = "0x4000A0B")]
			Chest,
			[Token(Token = "0x4000A0C")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000172")]
		public class VirtualBone
		{
			[Token(Token = "0x4000A0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000A0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000A0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000A10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000A11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000A12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000A13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x12ED7B4", Offset = "0x12ED7B4", VA = "0x12ED7B4")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x12ED830", Offset = "0x12ED830", VA = "0x12ED830")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x12F0174", Offset = "0x12F0174", VA = "0x12F0174")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x12F02F8", Offset = "0x12F02F8", VA = "0x12F02F8")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x12EFED8", Offset = "0x12EFED8", VA = "0x12EFED8")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x12F04E8", Offset = "0x12F04E8", VA = "0x12F04E8")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x12F0648", Offset = "0x12F0648", VA = "0x12F0648")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x12F0784", Offset = "0x12F0784", VA = "0x12F0784")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x12EF660", Offset = "0x12EF660", VA = "0x12EF660")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x12F083C", Offset = "0x12F083C", VA = "0x12F083C")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x12EF2D0", Offset = "0x12EF2D0", VA = "0x12EF2D0")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x12F09A4", Offset = "0x12F09A4", VA = "0x12F09A4")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x12F0A14", Offset = "0x12F0A14", VA = "0x12F0A14")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C15A8", Offset = "0x5C15A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C15A8", Offset = "0x5C15A8")]
		public int LOD;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C15FC", Offset = "0x5C15FC")]
		public float scale;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1634", Offset = "0x5C1634")]
		public bool plantFeet;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C166C", Offset = "0x5C166C")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C167C", Offset = "0x5C167C")]
		public Spine spine;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C16B4", Offset = "0x5C16B4")]
		public Arm leftArm;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C16EC", Offset = "0x5C16EC")]
		public Arm rightArm;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1724", Offset = "0x5C1724")]
		public Leg leftLeg;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C175C", Offset = "0x5C175C")]
		public Leg rightLeg;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1794", Offset = "0x5C1794")]
		public Locomotion locomotion;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x1700006D")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x11FC7B4", Offset = "0x11FC7B4", VA = "0x11FC7B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C962C", Offset = "0x5C962C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x11FC7BC", Offset = "0x11FC7BC", VA = "0x11FC7BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C963C", Offset = "0x5C963C")]
			private set
			{
			}
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x11F8FB8", Offset = "0x11F8FB8", VA = "0x11F8FB8")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x11F941C", Offset = "0x11F941C", VA = "0x11F941C")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x11F92C8", Offset = "0x11F92C8", VA = "0x11F92C8")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x11F9780", Offset = "0x11F9780", VA = "0x11F9780")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x11F98C4", Offset = "0x11F98C4", VA = "0x11F98C4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x11F98F4", Offset = "0x11F98F4", VA = "0x11F98F4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x11F99A4", Offset = "0x11F99A4", VA = "0x11F99A4")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x11F9A8C", Offset = "0x11F9A8C", VA = "0x11F9A8C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x11FA1F4", Offset = "0x11FA1F4", VA = "0x11FA1F4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x11FA364", Offset = "0x11FA364", VA = "0x11FA364", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x11FA568", Offset = "0x11FA568", VA = "0x11FA568", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x11FA5E4", Offset = "0x11FA5E4", VA = "0x11FA5E4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x11FA660", Offset = "0x11FA660", VA = "0x11FA660", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x11FA838", Offset = "0x11FA838", VA = "0x11FA838")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x11F9660", Offset = "0x11F9660", VA = "0x11F9660")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x11F9B80", Offset = "0x11F9B80", VA = "0x11F9B80")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x11FA9F8", Offset = "0x11FA9F8", VA = "0x11FA9F8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x11FAA40", Offset = "0x11FAA40", VA = "0x11FAA40", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x11FBEE4", Offset = "0x11FBEE4", VA = "0x11FBEE4")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x11F9CE4", Offset = "0x11F9CE4", VA = "0x11F9CE4")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x11FADB4", Offset = "0x11FADB4", VA = "0x11FADB4")]
		private void Solve()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x11FC294", Offset = "0x11FC294", VA = "0x11FC294")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x11FC2DC", Offset = "0x11FC2DC", VA = "0x11FC2DC")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x11FBD94", Offset = "0x11FBD94", VA = "0x11FBD94")]
		private void Write()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x11FC320", Offset = "0x11FC320", VA = "0x11FC320")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x11FC7C4", Offset = "0x11FC7C4", VA = "0x11FC7C4")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C17CC", Offset = "0x5C17CC")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xEAE884", Offset = "0xEAE884", VA = "0xEAE884")]
		public void Start()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xEAEF08", Offset = "0xEAEF08", VA = "0xEAEF08")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xEAF398", Offset = "0xEAF398", VA = "0xEAF398")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xEAF45C", Offset = "0xEAF45C", VA = "0xEAF45C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xEAF574", Offset = "0xEAF574", VA = "0xEAF574")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BC")]
	public class TwistSolver
	{
		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1804", Offset = "0x5C1804")]
		public Transform transform;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C183C", Offset = "0x5C183C")]
		public Transform parent;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1874", Offset = "0x5C1874")]
		public Transform[] children;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C18AC", Offset = "0x5C18AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C18AC", Offset = "0x5C18AC")]
		public float weight;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1900", Offset = "0x5C1900")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1900", Offset = "0x5C1900")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1954", Offset = "0x5C1954")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C1954", Offset = "0x5C1954")]
		public float twistAngleOffset;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xEAF5D0", Offset = "0xEAF5D0", VA = "0xEAF5D0")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xEAEA60", Offset = "0xEAEA60", VA = "0xEAEA60")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xEAEFCC", Offset = "0xEAEFCC", VA = "0xEAEFCC")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BD")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C19B0", Offset = "0x5C19B0")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C19C0", Offset = "0x5C19C0")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C19D0", Offset = "0x5C19D0")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x1700006E")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x11FD80C", Offset = "0x11FD80C", VA = "0x11FD80C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C964C", Offset = "0x5C964C")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x11FD814", Offset = "0x11FD814", VA = "0x11FD814")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C965C", Offset = "0x5C965C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public bool isPaused
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x11FD81C", Offset = "0x11FD81C", VA = "0x11FD81C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C966C", Offset = "0x5C966C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x11FD824", Offset = "0x11FD824", VA = "0x11FD824")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C967C", Offset = "0x5C967C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x11FD830", Offset = "0x11FD830", VA = "0x11FD830")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C968C", Offset = "0x5C968C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x11FD838", Offset = "0x11FD838", VA = "0x11FD838")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C969C", Offset = "0x5C969C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public bool inInteraction
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x11FD840", Offset = "0x11FD840", VA = "0x11FD840")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000072")]
		public float progress
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x11FF8AC", Offset = "0x11FF8AC", VA = "0x11FF8AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x11FD8AC", Offset = "0x11FD8AC", VA = "0x11FD8AC")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x11FD938", Offset = "0x11FD938", VA = "0x11FD938")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x11FD9D0", Offset = "0x11FD9D0", VA = "0x11FD9D0")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x11FDB48", Offset = "0x11FDB48", VA = "0x11FDB48")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x11FDEAC", Offset = "0x11FDEAC", VA = "0x11FDEAC")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x11FDF68", Offset = "0x11FDF68", VA = "0x11FDF68")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x11FDFC0", Offset = "0x11FDFC0", VA = "0x11FDFC0")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x11FE5C8", Offset = "0x11FE5C8", VA = "0x11FE5C8")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x11FF068", Offset = "0x11FF068", VA = "0x11FF068")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x11FF2AC", Offset = "0x11FF2AC", VA = "0x11FF2AC")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x11FF754", Offset = "0x11FF754", VA = "0x11FF754")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x11FF974", Offset = "0x11FF974", VA = "0x11FF974")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BE")]
	public class InteractionLookAt
	{
		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C19E0", Offset = "0x5C19E0")]
		public LookAtIK ik;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1A18", Offset = "0x5C1A18")]
		public float lerpSpeed;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1A50", Offset = "0x5C1A50")]
		public float weightSpeed;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x11FFB98", Offset = "0x11FFB98", VA = "0x11FFB98")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x11FFCB4", Offset = "0x11FFCB4", VA = "0x11FFCB4")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x11FFD58", Offset = "0x11FFD58", VA = "0x11FFD58")]
		public void Update()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x11FFF50", Offset = "0x11FFF50", VA = "0x11FFF50")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1200044", Offset = "0x1200044", VA = "0x1200044")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x120010C", Offset = "0x120010C", VA = "0x120010C")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BE314", Offset = "0x5BE314")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BE314", Offset = "0x5BE314")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000173")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000A14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5E30", Offset = "0x5C5E30")]
			public float time;

			[Token(Token = "0x4000A15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5E68", Offset = "0x5C5E68")]
			public bool pause;

			[Token(Token = "0x4000A16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5EA0", Offset = "0x5C5EA0")]
			public bool pickUp;

			[Token(Token = "0x4000A17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5ED8", Offset = "0x5C5ED8")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000A18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5F10", Offset = "0x5C5F10")]
			public Message[] messages;

			[Token(Token = "0x4000A19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5F48", Offset = "0x5C5F48")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x12F11C0", Offset = "0x12F11C0", VA = "0x12F11C0")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x12F1394", Offset = "0x12F1394", VA = "0x12F1394")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000174")]
		public class Message
		{
			[Token(Token = "0x4000A1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5F80", Offset = "0x5C5F80")]
			public string function;

			[Token(Token = "0x4000A1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5FB8", Offset = "0x5C5FB8")]
			public GameObject recipient;

			[Token(Token = "0x4000A1C")]
			private const string empty = "";

			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x12F1290", Offset = "0x12F1290", VA = "0x12F1290")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x12F139C", Offset = "0x12F139C", VA = "0x12F139C")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000175")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000A1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C5FF0", Offset = "0x5C5FF0")]
			public Animator animator;

			[Token(Token = "0x4000A1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6028", Offset = "0x5C6028")]
			public Animation animation;

			[Token(Token = "0x4000A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6060", Offset = "0x5C6060")]
			public string animationState;

			[Token(Token = "0x4000A20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6098", Offset = "0x5C6098")]
			public float crossfadeTime;

			[Token(Token = "0x4000A21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C60D0", Offset = "0x5C60D0")]
			public int layer;

			[Token(Token = "0x4000A22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6108", Offset = "0x5C6108")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000A23")]
			private const string empty = "";

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x12F0F2C", Offset = "0x12F0F2C", VA = "0x12F0F2C")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x12F101C", Offset = "0x12F101C", VA = "0x12F101C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x12F10D0", Offset = "0x12F10D0", VA = "0x12F10D0")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x12F11AC", Offset = "0x12F11AC", VA = "0x12F11AC")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000176")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20001B0")]
			public enum Type
			{
				[Token(Token = "0x4000B50")]
				PositionWeight,
				[Token(Token = "0x4000B51")]
				RotationWeight,
				[Token(Token = "0x4000B52")]
				PositionOffsetX,
				[Token(Token = "0x4000B53")]
				PositionOffsetY,
				[Token(Token = "0x4000B54")]
				PositionOffsetZ,
				[Token(Token = "0x4000B55")]
				Pull,
				[Token(Token = "0x4000B56")]
				Reach,
				[Token(Token = "0x4000B57")]
				RotateBoneWeight,
				[Token(Token = "0x4000B58")]
				Push,
				[Token(Token = "0x4000B59")]
				PushParent,
				[Token(Token = "0x4000B5A")]
				PoserWeight,
				[Token(Token = "0x4000B5B")]
				BendGoalWeight
			}

			[Token(Token = "0x4000A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6140", Offset = "0x5C6140")]
			public Type type;

			[Token(Token = "0x4000A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6178", Offset = "0x5C6178")]
			public AnimationCurve curve;

			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x12F13E0", Offset = "0x12F13E0", VA = "0x12F13E0")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x12F140C", Offset = "0x12F140C", VA = "0x12F140C")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000177")]
		public class Multiplier
		{
			[Token(Token = "0x4000A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C61B0", Offset = "0x5C61B0")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000A27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C61E8", Offset = "0x5C61E8")]
			public float multiplier;

			[Token(Token = "0x4000A28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6220", Offset = "0x5C6220")]
			public WeightCurve.Type result;

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x12F13A4", Offset = "0x12F13A4", VA = "0x12F13A4")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x12F13FC", Offset = "0x12F13FC", VA = "0x12F13FC")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1A98", Offset = "0x5C1A98")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1AD0", Offset = "0x5C1AD0")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1B08", Offset = "0x5C1B08")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C1B40", Offset = "0x5C1B40")]
		private float <length>k__BackingField;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C1B50", Offset = "0x5C1B50")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000073")]
		public float length
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x1200360", Offset = "0x1200360", VA = "0x1200360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C986C", Offset = "0x5C986C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x1200368", Offset = "0x1200368", VA = "0x1200368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C987C", Offset = "0x5C987C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x1200370", Offset = "0x1200370", VA = "0x1200370")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C988C", Offset = "0x5C988C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x1200378", Offset = "0x1200378", VA = "0x1200378")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C989C", Offset = "0x5C989C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x1200540", Offset = "0x1200540", VA = "0x1200540")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x11FF8E8", Offset = "0x11FF8E8", VA = "0x11FF8E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1200120", Offset = "0x1200120", VA = "0x1200120")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C96AC", Offset = "0x5C96AC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1200168", Offset = "0x1200168", VA = "0x1200168")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C96E4", Offset = "0x5C96E4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x12001B0", Offset = "0x12001B0", VA = "0x12001B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C971C", Offset = "0x5C971C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x12001F8", Offset = "0x12001F8", VA = "0x12001F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9754", Offset = "0x5C9754")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1200240", Offset = "0x1200240", VA = "0x1200240")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C978C", Offset = "0x5C978C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1200288", Offset = "0x1200288", VA = "0x1200288")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C97C4", Offset = "0x5C97C4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x12002D0", Offset = "0x12002D0", VA = "0x12002D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C97FC", Offset = "0x5C97FC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1200318", Offset = "0x1200318", VA = "0x1200318")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9834", Offset = "0x5C9834")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1200380", Offset = "0x1200380", VA = "0x1200380")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x12005CC", Offset = "0x12005CC", VA = "0x12005CC")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x11FE514", Offset = "0x11FE514", VA = "0x11FE514")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1200738", Offset = "0x1200738", VA = "0x1200738")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x11FE3C8", Offset = "0x11FE3C8", VA = "0x11FE3C8")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x11FE50C", Offset = "0x11FE50C", VA = "0x11FE50C")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x11FEC04", Offset = "0x11FEC04", VA = "0x11FEC04")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x11FF52C", Offset = "0x11FF52C", VA = "0x11FF52C")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1200CAC", Offset = "0x1200CAC", VA = "0x1200CAC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x12007B0", Offset = "0x12007B0", VA = "0x12007B0")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x1200740", Offset = "0x1200740", VA = "0x1200740")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x1200C44", Offset = "0x1200C44", VA = "0x1200C44")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1200CB0", Offset = "0x1200CB0", VA = "0x1200CB0")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1200D18", Offset = "0x1200D18", VA = "0x1200D18")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BE374", Offset = "0x5BE374")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BE374", Offset = "0x5BE374")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x2000178")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x2000179")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1B60", Offset = "0x5C1B60")]
		public string targetTag;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1B98", Offset = "0x5C1B98")]
		public float fadeInTime;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1BD0", Offset = "0x5C1BD0")]
		public float speed;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1C08", Offset = "0x5C1C08")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C1C40", Offset = "0x5C1C40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1C40", Offset = "0x5C1C40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5C1C40", Offset = "0x5C1C40")]
		public Collider characterCollider;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1CC4", Offset = "0x5C1CC4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5C1CC4", Offset = "0x5C1CC4")]
		public Transform FPSCamera;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1D24", Offset = "0x5C1D24")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1D5C", Offset = "0x5C1D5C")]
		public float camRaycastDistance;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C1D94", Offset = "0x5C1D94")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5C1DA4", Offset = "0x5C1DA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1DA4", Offset = "0x5C1DA4")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1E04", Offset = "0x5C1E04")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C1E3C", Offset = "0x5C1E3C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000077")]
		public bool inInteraction
		{
			[Token(Token = "0x6000609")]
			[Address(RVA = "0x11FD6E4", Offset = "0x11FD6E4", VA = "0x11FD6E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000078")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x1202A28", Offset = "0x1202A28", VA = "0x1202A28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x1202A30", Offset = "0x1202A30", VA = "0x1202A30")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x1202A38", Offset = "0x1202A38", VA = "0x1202A38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C9A6C", Offset = "0x5C9A6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x1202A40", Offset = "0x1202A40", VA = "0x1202A40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C9A7C", Offset = "0x5C9A7C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public bool initiated
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x1202A48", Offset = "0x1202A48", VA = "0x1202A48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C9A8C", Offset = "0x5C9A8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x1202A50", Offset = "0x1202A50", VA = "0x1202A50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C9A9C", Offset = "0x5C9A9C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1200D74", Offset = "0x1200D74", VA = "0x1200D74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C98AC", Offset = "0x5C98AC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1200DBC", Offset = "0x1200DBC", VA = "0x1200DBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C98E4", Offset = "0x5C98E4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1200E04", Offset = "0x1200E04", VA = "0x1200E04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C991C", Offset = "0x5C991C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x1200E4C", Offset = "0x1200E4C", VA = "0x1200E4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9954", Offset = "0x5C9954")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1200E94", Offset = "0x1200E94", VA = "0x1200E94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C998C", Offset = "0x5C998C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1200EDC", Offset = "0x1200EDC", VA = "0x1200EDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C99C4", Offset = "0x5C99C4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1200F24", Offset = "0x1200F24", VA = "0x1200F24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C99FC", Offset = "0x5C99FC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1200F6C", Offset = "0x1200F6C", VA = "0x1200F6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9A34", Offset = "0x5C9A34")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x12010AC", Offset = "0x12010AC", VA = "0x12010AC")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1201178", Offset = "0x1201178", VA = "0x1201178")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1201244", Offset = "0x1201244", VA = "0x1201244")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x12012F0", Offset = "0x12012F0", VA = "0x12012F0")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x11FCDC4", Offset = "0x11FCDC4", VA = "0x11FCDC4")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x12013E8", Offset = "0x12013E8", VA = "0x12013E8")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x1201478", Offset = "0x1201478", VA = "0x1201478")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x1201508", Offset = "0x1201508", VA = "0x1201508")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x1201598", Offset = "0x1201598", VA = "0x1201598")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x11FD790", Offset = "0x11FD790", VA = "0x11FD790")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x120160C", Offset = "0x120160C", VA = "0x120160C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x1201674", Offset = "0x1201674", VA = "0x1201674")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x1201700", Offset = "0x1201700", VA = "0x1201700")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x12017B4", Offset = "0x12017B4", VA = "0x12017B4")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1201898", Offset = "0x1201898", VA = "0x1201898")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1201B70", Offset = "0x1201B70", VA = "0x1201B70")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1201D50", Offset = "0x1201D50", VA = "0x1201D50")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1201FE4", Offset = "0x1201FE4", VA = "0x1201FE4")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x12022BC", Offset = "0x12022BC", VA = "0x12022BC")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1202300", Offset = "0x1202300", VA = "0x1202300")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x1202378", Offset = "0x1202378", VA = "0x1202378")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x1202494", Offset = "0x1202494", VA = "0x1202494")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x1202638", Offset = "0x1202638", VA = "0x1202638")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x12028DC", Offset = "0x12028DC", VA = "0x12028DC")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x12020F8", Offset = "0x12020F8", VA = "0x12020F8")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x1202A5C", Offset = "0x1202A5C", VA = "0x1202A5C")]
		public void Start()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x12031C8", Offset = "0x12031C8", VA = "0x12031C8")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x12031E8", Offset = "0x12031E8", VA = "0x12031E8")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1203204", Offset = "0x1203204", VA = "0x1203204")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x1203220", Offset = "0x1203220", VA = "0x1203220")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x1203280", Offset = "0x1203280", VA = "0x1203280")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x12033BC", Offset = "0x12033BC", VA = "0x12033BC")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x12034CC", Offset = "0x12034CC", VA = "0x12034CC")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x12036A0", Offset = "0x12036A0", VA = "0x12036A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x12037A0", Offset = "0x12037A0", VA = "0x12037A0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x12039FC", Offset = "0x12039FC", VA = "0x12039FC")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x1202F2C", Offset = "0x1202F2C", VA = "0x1202F2C")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1203B38", Offset = "0x1203B38", VA = "0x1203B38")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1203C60", Offset = "0x1203C60", VA = "0x1203C60")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1203CF4", Offset = "0x1203CF4", VA = "0x1203CF4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1203DC8", Offset = "0x1203DC8", VA = "0x1203DC8")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x1203DE0", Offset = "0x1203DE0", VA = "0x1203DE0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1200FB4", Offset = "0x1200FB4", VA = "0x1200FB4")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x1201A40", Offset = "0x1201A40", VA = "0x1201A40")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1204148", Offset = "0x1204148", VA = "0x1204148")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BE3D4", Offset = "0x5BE3D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BE3D4", Offset = "0x5BE3D4")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200017A")]
		public enum RotationMode
		{
			[Token(Token = "0x4000A2A")]
			TwoDOF,
			[Token(Token = "0x4000A2B")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x200017B")]
		public class Multiplier
		{
			[Token(Token = "0x4000A2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6258", Offset = "0x5C6258")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6290", Offset = "0x5C6290")]
			public float multiplier;

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x12F1A78", Offset = "0x12F1A78", VA = "0x12F1A78")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1E4C", Offset = "0x5C1E4C")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1E84", Offset = "0x5C1E84")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1EBC", Offset = "0x5C1EBC")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1EF4", Offset = "0x5C1EF4")]
		public Transform pivot;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1F2C", Offset = "0x5C1F2C")]
		public RotationMode rotationMode;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1F64", Offset = "0x5C1F64")]
		public Vector3 twistAxis;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1F9C", Offset = "0x5C1F9C")]
		public float twistWeight;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C1FD4", Offset = "0x5C1FD4")]
		public float swingWeight;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C200C", Offset = "0x5C200C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C200C", Offset = "0x5C200C")]
		public float threeDOFWeight;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2060", Offset = "0x5C2060")]
		public bool rotateOnce;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xF9B8D8", Offset = "0xF9B8D8", VA = "0xF9B8D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9AAC", Offset = "0x5C9AAC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xF9B920", Offset = "0xF9B920", VA = "0xF9B920")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9AE4", Offset = "0x5C9AE4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xF9B968", Offset = "0xF9B968", VA = "0xF9B968")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9B1C", Offset = "0x5C9B1C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xF9B9B0", Offset = "0xF9B9B0", VA = "0xF9B9B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9B54", Offset = "0x5C9B54")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xF9B9F8", Offset = "0xF9B9F8", VA = "0xF9B9F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9B8C", Offset = "0x5C9B8C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xF9BA40", Offset = "0xF9BA40", VA = "0xF9BA40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9BC4", Offset = "0x5C9BC4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xF9BA88", Offset = "0xF9BA88", VA = "0xF9BA88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9BFC", Offset = "0x5C9BFC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xF9BAD0", Offset = "0xF9BAD0", VA = "0xF9BAD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9C34", Offset = "0x5C9C34")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xF9BB18", Offset = "0xF9BB18", VA = "0xF9BB18")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xF9BB88", Offset = "0xF9BB88", VA = "0xF9BB88")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xF9BC20", Offset = "0xF9BC20", VA = "0xF9BC20")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xF9C2E8", Offset = "0xF9C2E8", VA = "0xF9C2E8")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BE434", Offset = "0x5BE434")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BE434", Offset = "0x5BE434")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200017C")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000A2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C62C8", Offset = "0x5C62C8")]
			public bool use;

			[Token(Token = "0x4000A2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6300", Offset = "0x5C6300")]
			public Vector2 offset;

			[Token(Token = "0x4000A30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6338", Offset = "0x5C6338")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C6338", Offset = "0x5C6338")]
			public float angleOffset;

			[Token(Token = "0x4000A31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6394", Offset = "0x5C6394")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C6394", Offset = "0x5C6394")]
			public float maxAngle;

			[Token(Token = "0x4000A32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C63EC", Offset = "0x5C63EC")]
			public float radius;

			[Token(Token = "0x4000A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6424", Offset = "0x5C6424")]
			public bool orbit;

			[Token(Token = "0x4000A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C645C", Offset = "0x5C645C")]
			public bool fixYAxis;

			[Token(Token = "0x170000F8")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60009D7")]
				[Address(RVA = "0x12F1DE8", Offset = "0x12F1DE8", VA = "0x12F1DE8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000F9")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60009D8")]
				[Address(RVA = "0x12F1DF4", Offset = "0x12F1DF4", VA = "0x12F1DF4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x12F1E7C", Offset = "0x12F1E7C", VA = "0x12F1E7C")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x12F22C0", Offset = "0x12F22C0", VA = "0x12F22C0")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200017D")]
		public class CameraPosition
		{
			[Token(Token = "0x4000A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6494", Offset = "0x5C6494")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000A36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C64CC", Offset = "0x5C64CC")]
			public Vector3 direction;

			[Token(Token = "0x4000A37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6504", Offset = "0x5C6504")]
			public float maxDistance;

			[Token(Token = "0x4000A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C653C", Offset = "0x5C653C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C653C", Offset = "0x5C653C")]
			public float maxAngle;

			[Token(Token = "0x4000A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6594", Offset = "0x5C6594")]
			public bool fixYAxis;

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x12F1A80", Offset = "0x12F1A80", VA = "0x12F1A80")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x12F1B74", Offset = "0x12F1B74", VA = "0x12F1B74")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x12F1D9C", Offset = "0x12F1D9C", VA = "0x12F1D9C")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200017E")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20001B1")]
			public class Interaction
			{
				[Token(Token = "0x4000B5C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C776C", Offset = "0x5C776C")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000B5D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C77A4", Offset = "0x5C77A4")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000A87")]
				[Address(RVA = "0x12F8BE0", Offset = "0x12F8BE0", VA = "0x12F8BE0")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000A3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000A3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x4000A3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C65EC", Offset = "0x5C65EC")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6624", Offset = "0x5C6624")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000A3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C665C", Offset = "0x5C665C")]
			public Interaction[] interactions;

			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x12F22D4", Offset = "0x12F22D4", VA = "0x12F22D4")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x12F2388", Offset = "0x12F2388", VA = "0x12F2388")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2098", Offset = "0x5C2098")]
		public Range[] ranges;

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xF9C334", Offset = "0xF9C334", VA = "0xF9C334")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9C6C", Offset = "0x5C9C6C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xF9C37C", Offset = "0xF9C37C", VA = "0xF9C37C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9CA4", Offset = "0x5C9CA4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xF9C3C4", Offset = "0xF9C3C4", VA = "0xF9C3C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9CDC", Offset = "0x5C9CDC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xF9C40C", Offset = "0xF9C40C", VA = "0xF9C40C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9D14", Offset = "0x5C9D14")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xF9C454", Offset = "0xF9C454", VA = "0xF9C454")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9D4C", Offset = "0x5C9D4C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xF9C49C", Offset = "0xF9C49C", VA = "0xF9C49C")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xF9C670", Offset = "0xF9C670", VA = "0xF9C670")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x200017F")]
		public class Map
		{
			[Token(Token = "0x4000A3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000A40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000A41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000A42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x1124388", Offset = "0x1124388", VA = "0x1124388")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x11243C4", Offset = "0x11243C4", VA = "0x11243C4")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x1124414", Offset = "0x1124414", VA = "0x1124414")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x1124460", Offset = "0x1124460", VA = "0x1124460")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x11C43A4", Offset = "0x11C43A4", VA = "0x11C43A4", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9D84", Offset = "0x5C9D84")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x11C4720", Offset = "0x11C4720", VA = "0x11C4720", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x11C4724", Offset = "0x11C4724", VA = "0x11C4724", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x11C482C", Offset = "0x11C482C", VA = "0x11C482C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x11C46B4", Offset = "0x11C46B4", VA = "0x11C46B4")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x11C4614", Offset = "0x11C4614", VA = "0x11C4614")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x11C4898", Offset = "0x11C4898", VA = "0x11C4898")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x11CB62C", Offset = "0x11CB62C", VA = "0x11CB62C", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x11CB6F4", Offset = "0x11CB6F4", VA = "0x11CB6F4", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x11CB8B0", Offset = "0x11CB8B0", VA = "0x11CB8B0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x11CB9AC", Offset = "0x11CB9AC", VA = "0x11CB9AC", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x11CB74C", Offset = "0x11CB74C", VA = "0x11CB74C")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x11CBD0C", Offset = "0x11CBD0C", VA = "0x11CBD0C")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C20D0", Offset = "0x5C20D0")]
		public float weight;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C20E8", Offset = "0x5C20E8")]
		public float localRotationWeight;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C2100", Offset = "0x5C2100")]
		public float localPositionWeight;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600065D")]
		public abstract void AutoMapping();

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xFA841C", Offset = "0xFA841C", VA = "0xFA841C")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x600065F")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000660")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000661")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xFA8428", Offset = "0xFA8428", VA = "0xFA8428", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xFA847C", Offset = "0xFA847C", VA = "0xFA847C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xFA84B8", Offset = "0xFA84B8", VA = "0xFA84B8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xFA84D0", Offset = "0xFA84D0", VA = "0xFA84D0")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x2000180")]
		public class Rigidbone
		{
			[Token(Token = "0x4000A43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000A44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x4000A45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x4000A46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x12F4C84", Offset = "0x12F4C84", VA = "0x12F4C84")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x12F4DF4", Offset = "0x12F4DF4", VA = "0x12F4DF4")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x12F4ED4", Offset = "0x12F4ED4", VA = "0x12F4ED4")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x2000181")]
		public class Child
		{
			[Token(Token = "0x4000A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x12F4A94", Offset = "0x12F4A94", VA = "0x12F4A94")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x12F4AF4", Offset = "0x12F4AF4", VA = "0x12F4AF4")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x12F4C34", Offset = "0x12F4C34", VA = "0x12F4C34")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x2000182")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE768", Offset = "0x5BE768")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000FA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009ED")]
				[Address(RVA = "0x12F4A44", Offset = "0x12F4A44", VA = "0x12F4A44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009EF")]
				[Address(RVA = "0x12F4A8C", Offset = "0x12F4A8C", VA = "0x12F4A8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x12F4828", Offset = "0x12F4828", VA = "0x12F4828")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x12F4854", Offset = "0x12F4854", VA = "0x12F4854", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x12F4858", Offset = "0x12F4858", VA = "0x12F4858", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x12F4A4C", Offset = "0x12F4A4C", VA = "0x12F4A4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2118", Offset = "0x5C2118")]
		public IK ik;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2150", Offset = "0x5C2150")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2188", Offset = "0x5C2188")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C21C0", Offset = "0x5C21C0")]
		public float applyVelocity;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C21F8", Offset = "0x5C21F8")]
		public float applyAngularVelocity;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700007B")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0xFA9868", Offset = "0xFA9868", VA = "0xFA9868")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		private bool ikUsed
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0xFAA1F0", Offset = "0xFAA1F0", VA = "0xFAA1F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xFA9830", Offset = "0xFA9830", VA = "0xFA9830")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xFA98E0", Offset = "0xFA98E0", VA = "0xFA98E0")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xFA9A10", Offset = "0xFA9A10", VA = "0xFA9A10")]
		public void Start()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xFA99A4", Offset = "0xFA99A4", VA = "0xFA99A4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C9DBC", Offset = "0x5C9DBC")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xFA9E2C", Offset = "0xFA9E2C", VA = "0xFA9E2C")]
		private void Update()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xFAA078", Offset = "0xFAA078", VA = "0xFAA078")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xFAA134", Offset = "0xFAA134", VA = "0xFAA134")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xFAA370", Offset = "0xFAA370", VA = "0xFAA370")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xFAA1B4", Offset = "0xFAA1B4", VA = "0xFAA1B4")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xFAA32C", Offset = "0xFAA32C", VA = "0xFAA32C")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xFAA410", Offset = "0xFAA410", VA = "0xFAA410")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xFAA3A4", Offset = "0xFAA3A4", VA = "0xFAA3A4")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xFA9938", Offset = "0xFA9938", VA = "0xFA9938")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xFAA0B8", Offset = "0xFAA0B8", VA = "0xFAA0B8")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xFAA63C", Offset = "0xFAA63C", VA = "0xFAA63C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xFAA754", Offset = "0xFAA754", VA = "0xFAA754")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C2240", Offset = "0x5C2240")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x1700007D")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x600067D")]
			[Address(RVA = "0xEA6F10", Offset = "0xEA6F10", VA = "0xEA6F10")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007E")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0xEA6F1C", Offset = "0xEA6F1C", VA = "0xEA6F1C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007F")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0xEA6F38", Offset = "0xEA6F38", VA = "0xEA6F38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C9E1C", Offset = "0x5C9E1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000680")]
			[Address(RVA = "0xEA6F40", Offset = "0xEA6F40", VA = "0xEA6F40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C9E2C", Offset = "0x5C9E2C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xEA6C10", Offset = "0xEA6C10", VA = "0xEA6C10")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xEA6C58", Offset = "0xEA6C58", VA = "0xEA6C58")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xEA6C70", Offset = "0xEA6C70", VA = "0xEA6C70")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xEA6E68", Offset = "0xEA6E68", VA = "0xEA6E68")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xEA6ED8", Offset = "0xEA6ED8", VA = "0xEA6ED8")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000681")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xEA6D90", Offset = "0xEA6D90", VA = "0xEA6D90")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xEA6F4C", Offset = "0xEA6F4C", VA = "0xEA6F4C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xEA6F50", Offset = "0xEA6F50", VA = "0xEA6F50")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xEA7040", Offset = "0xEA7040", VA = "0xEA7040")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xEA70BC", Offset = "0xEA70BC", VA = "0xEA70BC")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xEA7250", Offset = "0xEA7250", VA = "0xEA7250")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xEA72C0", Offset = "0xEA72C0", VA = "0xEA72C0")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BE494", Offset = "0x5BE494")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BE494", Offset = "0x5BE494")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C2250", Offset = "0x5C2250")]
		public float limit;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C226C", Offset = "0x5C226C")]
		public float twistLimit;

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xEA72F4", Offset = "0xEA72F4", VA = "0xEA72F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9E3C", Offset = "0x5C9E3C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xEA733C", Offset = "0xEA733C", VA = "0xEA733C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9E74", Offset = "0x5C9E74")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xEA7384", Offset = "0xEA7384", VA = "0xEA7384")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9EAC", Offset = "0x5C9EAC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xEA73CC", Offset = "0xEA73CC", VA = "0xEA73CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9EE4", Offset = "0x5C9EE4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xEA7414", Offset = "0xEA7414", VA = "0xEA7414", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xEA7458", Offset = "0xEA7458", VA = "0xEA7458")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xEA7618", Offset = "0xEA7618", VA = "0xEA7618")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BE4F4", Offset = "0x5BE4F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BE4F4", Offset = "0x5BE4F4")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xEA7658", Offset = "0xEA7658", VA = "0xEA7658")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9F1C", Offset = "0x5C9F1C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xEA76A0", Offset = "0xEA76A0", VA = "0xEA76A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9F54", Offset = "0x5C9F54")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xEA76E8", Offset = "0xEA76E8", VA = "0xEA76E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9F8C", Offset = "0x5C9F8C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xEA7730", Offset = "0xEA7730", VA = "0xEA7730")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9FC4", Offset = "0x5C9FC4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xEA7778", Offset = "0xEA7778", VA = "0xEA7778", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xEA777C", Offset = "0xEA777C", VA = "0xEA777C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xEA7900", Offset = "0xEA7900", VA = "0xEA7900")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BE554", Offset = "0x5BE554")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BE554", Offset = "0x5BE554")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x2000183")]
		public class ReachCone
		{
			[Token(Token = "0x4000A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000A56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000A57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000FC")]
			public Vector3 o
			{
				[Token(Token = "0x60009F0")]
				[Address(RVA = "0x12F5774", Offset = "0x12F5774", VA = "0x12F5774")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000FD")]
			public Vector3 a
			{
				[Token(Token = "0x60009F1")]
				[Address(RVA = "0x12F57AC", Offset = "0x12F57AC", VA = "0x12F57AC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000FE")]
			public Vector3 b
			{
				[Token(Token = "0x60009F2")]
				[Address(RVA = "0x12F57E8", Offset = "0x12F57E8", VA = "0x12F57E8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000FF")]
			public Vector3 c
			{
				[Token(Token = "0x60009F3")]
				[Address(RVA = "0x12F5824", Offset = "0x12F5824", VA = "0x12F5824")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000100")]
			public bool isValid
			{
				[Token(Token = "0x60009F5")]
				[Address(RVA = "0x12F599C", Offset = "0x12F599C", VA = "0x12F599C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x12F5860", Offset = "0x12F5860", VA = "0x12F5860")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x12F59AC", Offset = "0x12F59AC", VA = "0x12F59AC")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000184")]
		public class LimitPoint
		{
			[Token(Token = "0x4000A58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000A59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x12F5738", Offset = "0x12F5738", VA = "0x12F5738")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C2298", Offset = "0x5C2298")]
		public float twistLimit;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C22B4", Offset = "0x5C22B4")]
		public int smoothIterations;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xEA7948", Offset = "0xEA7948", VA = "0xEA7948")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5C9FFC", Offset = "0x5C9FFC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xEA7990", Offset = "0xEA7990", VA = "0xEA7990")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5CA034", Offset = "0x5CA034")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xEA79D8", Offset = "0xEA79D8", VA = "0xEA79D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5CA06C", Offset = "0x5CA06C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xEA7A20", Offset = "0xEA7A20", VA = "0xEA7A20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5CA0A4", Offset = "0x5CA0A4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xEA7A68", Offset = "0xEA7A68", VA = "0xEA7A68")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xEA7F04", Offset = "0xEA7F04", VA = "0xEA7F04", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xEA7F98", Offset = "0xEA7F98", VA = "0xEA7F98")]
		private void Start()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xEA84BC", Offset = "0xEA84BC", VA = "0xEA84BC")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xEA7B00", Offset = "0xEA7B00", VA = "0xEA7B00")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xEA883C", Offset = "0xEA883C", VA = "0xEA883C")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xEA8C48", Offset = "0xEA8C48", VA = "0xEA8C48")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xEA8C8C", Offset = "0xEA8C8C", VA = "0xEA8C8C")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xEA8CEC", Offset = "0xEA8CEC", VA = "0xEA8CEC")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xEA8250", Offset = "0xEA8250", VA = "0xEA8250")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xEA8D58", Offset = "0xEA8D58", VA = "0xEA8D58")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xEA8E34", Offset = "0xEA8E34", VA = "0xEA8E34")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5BE5B4", Offset = "0x5BE5B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BE5B4", Offset = "0x5BE5B4")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C22FC", Offset = "0x5C22FC")]
		public float twistLimit;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xEA8EA8", Offset = "0xEA8EA8", VA = "0xEA8EA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5CA0DC", Offset = "0x5CA0DC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xEA8EF0", Offset = "0xEA8EF0", VA = "0xEA8EF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5CA114", Offset = "0x5CA114")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xEA8F38", Offset = "0xEA8F38", VA = "0xEA8F38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5CA14C", Offset = "0x5CA14C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xEA8F80", Offset = "0xEA8F80", VA = "0xEA8F80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5CA184", Offset = "0x5CA184")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xEA8FC8", Offset = "0xEA8FC8", VA = "0xEA8FC8")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xEA8FE4", Offset = "0xEA8FE4", VA = "0xEA8FE4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xEA9028", Offset = "0xEA9028", VA = "0xEA9028")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xEA924C", Offset = "0xEA924C", VA = "0xEA924C")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x2000185")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE778", Offset = "0x5BE778")]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x17000101")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009FB")]
				[Address(RVA = "0x1121E7C", Offset = "0x1121E7C", VA = "0x1121E7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000102")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009FD")]
				[Address(RVA = "0x1121EC4", Offset = "0x1121EC4", VA = "0x1121EC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x1121D8C", Offset = "0x1121D8C", VA = "0x1121D8C")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x1121DB8", Offset = "0x1121DB8", VA = "0x1121DB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x1121DBC", Offset = "0x1121DBC", VA = "0x1121DBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x1121E84", Offset = "0x1121E84", VA = "0x1121E84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2328", Offset = "0x5C2328")]
		public AimIK ik;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2360", Offset = "0x5C2360")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C2360", Offset = "0x5C2360")]
		public float weight;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C23B4", Offset = "0x5C23B4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C23B4", Offset = "0x5C23B4")]
		public Transform target;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2414", Offset = "0x5C2414")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C244C", Offset = "0x5C244C")]
		public float weightSmoothTime;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C2484", Offset = "0x5C2484")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2484", Offset = "0x5C2484")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C24E4", Offset = "0x5C24E4")]
		public float maxRadiansDelta;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C251C", Offset = "0x5C251C")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2554", Offset = "0x5C2554")]
		public float slerpSpeed;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C258C", Offset = "0x5C258C")]
		public float smoothDampTime;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C25C4", Offset = "0x5C25C4")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C25FC", Offset = "0x5C25FC")]
		public float minDistance;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2634", Offset = "0x5C2634")]
		public Vector3 offset;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C266C", Offset = "0x5C266C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C266C", Offset = "0x5C266C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C266C", Offset = "0x5C266C")]
		public float maxRootAngle;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C26E8", Offset = "0x5C26E8")]
		public bool turnToTarget;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2720", Offset = "0x5C2720")]
		public float turnToTargetTime;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C2758", Offset = "0x5C2758")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2758", Offset = "0x5C2758")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C27B8", Offset = "0x5C27B8")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x17000080")]
		private Vector3 pivot
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x10BA160", Offset = "0x10BA160", VA = "0x10BA160")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x10BA0D8", Offset = "0x10BA0D8", VA = "0x10BA0D8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x10BA1F0", Offset = "0x10BA1F0", VA = "0x10BA1F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x10BA8C4", Offset = "0x10BA8C4", VA = "0x10BA8C4")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x10BA9B0", Offset = "0x10BA9B0", VA = "0x10BA9B0")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x10BAC00", Offset = "0x10BAC00", VA = "0x10BAC00")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5CA1BC", Offset = "0x5CA1BC")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x10BAC6C", Offset = "0x10BAC6C", VA = "0x10BAC6C")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000186")]
		public class Pose
		{
			[Token(Token = "0x4000A5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000A5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000A60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000A61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000A62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x1121ECC", Offset = "0x1121ECC", VA = "0x1121ECC")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x1122058", Offset = "0x1122058", VA = "0x1122058")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x1122060", Offset = "0x1122060", VA = "0x1122060")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x10BAED0", Offset = "0x10BAED0", VA = "0x10BAED0")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x10BAFB0", Offset = "0x10BAFB0", VA = "0x10BAFB0")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x10BB01C", Offset = "0x10BB01C", VA = "0x10BB01C")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000187")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001B2")]
			public class EffectorLink
			{
				[Token(Token = "0x4000B5E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C77DC", Offset = "0x5C77DC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000B5F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7814", Offset = "0x5C7814")]
				public float weight;

				[Token(Token = "0x6000A88")]
				[Address(RVA = "0x12F87C4", Offset = "0x12F87C4", VA = "0x12F87C4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000A63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6694", Offset = "0x5C6694")]
			public Transform transform;

			[Token(Token = "0x4000A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C66CC", Offset = "0x5C66CC")]
			public Transform relativeTo;

			[Token(Token = "0x4000A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6704", Offset = "0x5C6704")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C673C", Offset = "0x5C673C")]
			public float verticalWeight;

			[Token(Token = "0x4000A67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6774", Offset = "0x5C6774")]
			public float horizontalWeight;

			[Token(Token = "0x4000A68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C67AC", Offset = "0x5C67AC")]
			public float speed;

			[Token(Token = "0x4000A69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000A6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x112207C", Offset = "0x112207C", VA = "0x112207C")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x11223A8", Offset = "0x11223A8", VA = "0x11223A8")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x11223B8", Offset = "0x11223B8", VA = "0x11223B8")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C27F0", Offset = "0x5C27F0")]
		public Body[] bodies;

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x10BB618", Offset = "0x10BB618", VA = "0x10BB618", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x10BB764", Offset = "0x10BB764", VA = "0x10BB764")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2828", Offset = "0x5C2828")]
		public float tiltSpeed;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2860", Offset = "0x5C2860")]
		public float tiltSensitivity;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2898", Offset = "0x5C2898")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C28D0", Offset = "0x5C28D0")]
		public OffsetPose poseRight;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x122DB3C", Offset = "0x122DB3C", VA = "0x122DB3C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x122DB84", Offset = "0x122DB84", VA = "0x122DB84", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x122DD3C", Offset = "0x122DD3C", VA = "0x122DD3C")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C2908", Offset = "0x5C2908")]
		public float weight;

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x122E250", Offset = "0x122E250", VA = "0x122E250")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x122E318", Offset = "0x122E318", VA = "0x122E318")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x122E540", Offset = "0x122E540", VA = "0x122E540")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x122E64C", Offset = "0x122E64C", VA = "0x122E64C")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2920", Offset = "0x5C2920")]
		public Animator animator;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2958", Offset = "0x5C2958")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C29A0", Offset = "0x5C29A0")]
		private IK <ik>k__BackingField;

		[Token(Token = "0x17000081")]
		public IK ik
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x1237B18", Offset = "0x1237B18", VA = "0x1237B18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA21C", Offset = "0x5CA21C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1237B20", Offset = "0x1237B20", VA = "0x1237B20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA22C", Offset = "0x5CA22C")]
			private set
			{
			}
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1237B28", Offset = "0x1237B28", VA = "0x1237B28")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1237CC4", Offset = "0x1237CC4", VA = "0x1237CC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x1237F50", Offset = "0x1237F50", VA = "0x1237F50")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x1238098", Offset = "0x1238098", VA = "0x1238098")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1238264", Offset = "0x1238264", VA = "0x1238264")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1238494", Offset = "0x1238494", VA = "0x1238494")]
		public void Update()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x1238730", Offset = "0x1238730", VA = "0x1238730")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x5BE624", Offset = "0x5BE624")]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x17000082")]
		public bool poseStored
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x1237DBC", Offset = "0x1237DBC", VA = "0x1237DBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1238110", Offset = "0x1238110", VA = "0x1238110")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1237DE0", Offset = "0x1237DE0", VA = "0x1237DE0")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x123878C", Offset = "0x123878C", VA = "0x123878C")]
		public EditorIKPose()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000188")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000A6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C67E4", Offset = "0x5C67E4")]
			public string name;

			[Token(Token = "0x4000A6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C681C", Offset = "0x5C681C")]
			public Collider collider;

			[Token(Token = "0x4000A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6854", Offset = "0x5C6854")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C68A0", Offset = "0x5C68A0")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000A70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C68B0", Offset = "0x5C68B0")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000A71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C68C0", Offset = "0x5C68C0")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000A72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C68D0", Offset = "0x5C68D0")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000A73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000A74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000A75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000103")]
			public bool inProgress
			{
				[Token(Token = "0x6000A04")]
				[Address(RVA = "0x11260B0", Offset = "0x11260B0", VA = "0x11260B0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000104")]
			protected float crossFader
			{
				[Token(Token = "0x6000A05")]
				[Address(RVA = "0x11260C4", Offset = "0x11260C4", VA = "0x11260C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAE3C", Offset = "0x5CAE3C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A06")]
				[Address(RVA = "0x11260CC", Offset = "0x11260CC", VA = "0x11260CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAE4C", Offset = "0x5CAE4C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000105")]
			protected float timer
			{
				[Token(Token = "0x6000A07")]
				[Address(RVA = "0x11260D4", Offset = "0x11260D4", VA = "0x11260D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAE5C", Offset = "0x5CAE5C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A08")]
				[Address(RVA = "0x11260DC", Offset = "0x11260DC", VA = "0x11260DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAE6C", Offset = "0x5CAE6C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000106")]
			protected Vector3 force
			{
				[Token(Token = "0x6000A09")]
				[Address(RVA = "0x11260E4", Offset = "0x11260E4", VA = "0x11260E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAE7C", Offset = "0x5CAE7C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A0A")]
				[Address(RVA = "0x11260F0", Offset = "0x11260F0", VA = "0x11260F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAE8C", Offset = "0x5CAE8C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000107")]
			protected Vector3 point
			{
				[Token(Token = "0x6000A0B")]
				[Address(RVA = "0x11260FC", Offset = "0x11260FC", VA = "0x11260FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAE9C", Offset = "0x5CAE9C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A0C")]
				[Address(RVA = "0x1126108", Offset = "0x1126108", VA = "0x1126108")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAEAC", Offset = "0x5CAEAC")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x1126114", Offset = "0x1126114", VA = "0x1126114")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x1126248", Offset = "0x1126248", VA = "0x1126248")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000A0F")]
			protected abstract float GetLength();

			[Token(Token = "0x6000A10")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000A11")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x112631C", Offset = "0x112631C", VA = "0x112631C")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000189")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001B3")]
			public class EffectorLink
			{
				[Token(Token = "0x4000B60")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C784C", Offset = "0x5C784C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000B61")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7884", Offset = "0x5C7884")]
				public float weight;

				[Token(Token = "0x4000B62")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000B63")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000A89")]
				[Address(RVA = "0x12F8934", Offset = "0x12F8934", VA = "0x12F8934")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000A8A")]
				[Address(RVA = "0x12F89E4", Offset = "0x12F89E4", VA = "0x12F89E4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000A8B")]
				[Address(RVA = "0x12F89F8", Offset = "0x12F89F8", VA = "0x12F89F8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000A76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C68E0", Offset = "0x5C68E0")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000A77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6918", Offset = "0x5C6918")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000A78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6950", Offset = "0x5C6950")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x1126648", Offset = "0x1126648", VA = "0x1126648", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x1126778", Offset = "0x1126778", VA = "0x1126778", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x11267E4", Offset = "0x11267E4", VA = "0x11267E4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x112694C", Offset = "0x112694C", VA = "0x112694C")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018A")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001B4")]
			public class BoneLink
			{
				[Token(Token = "0x4000B64")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C78BC", Offset = "0x5C78BC")]
				public Transform bone;

				[Token(Token = "0x4000B65")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C78F4", Offset = "0x5C78F4")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C78F4", Offset = "0x5C78F4")]
				public float weight;

				[Token(Token = "0x4000B66")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000B67")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000A8C")]
				[Address(RVA = "0x12F87CC", Offset = "0x12F87CC", VA = "0x12F87CC")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000A8D")]
				[Address(RVA = "0x12F88E4", Offset = "0x12F88E4", VA = "0x12F88E4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000A8E")]
				[Address(RVA = "0x12F88F0", Offset = "0x12F88F0", VA = "0x12F88F0")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000A79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6988", Offset = "0x5C6988")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000A7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C69C0", Offset = "0x5C69C0")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000A7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x1126330", Offset = "0x1126330", VA = "0x1126330", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x11263D4", Offset = "0x11263D4", VA = "0x11263D4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x1126440", Offset = "0x1126440", VA = "0x1126440", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x1126634", Offset = "0x1126634", VA = "0x1126634")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C29B0", Offset = "0x5C29B0")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C29E8", Offset = "0x5C29E8")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000083")]
		public bool inProgress
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x12BF008", Offset = "0x12BF008", VA = "0x12BF008")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x12BF0D8", Offset = "0x12BF0D8", VA = "0x12BF0D8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x12BF1B4", Offset = "0x12BF1B4", VA = "0x12BF1B4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x12BF410", Offset = "0x12BF410", VA = "0x12BF410")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x200018B")]
		public abstract class Offset
		{
			[Token(Token = "0x4000A7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C69F8", Offset = "0x5C69F8")]
			public string name;

			[Token(Token = "0x4000A7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6A30", Offset = "0x5C6A30")]
			public Collider collider;

			[Token(Token = "0x4000A7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6A68", Offset = "0x5C6A68")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000A7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C6AB4", Offset = "0x5C6AB4")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000A80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C6AC4", Offset = "0x5C6AC4")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000A81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C6AD4", Offset = "0x5C6AD4")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000A82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C6AE4", Offset = "0x5C6AE4")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000A83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000A84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000A85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000108")]
			protected float crossFader
			{
				[Token(Token = "0x6000A1B")]
				[Address(RVA = "0x1126960", Offset = "0x1126960", VA = "0x1126960")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAEBC", Offset = "0x5CAEBC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A1C")]
				[Address(RVA = "0x1126968", Offset = "0x1126968", VA = "0x1126968")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAECC", Offset = "0x5CAECC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000109")]
			protected float timer
			{
				[Token(Token = "0x6000A1D")]
				[Address(RVA = "0x1126970", Offset = "0x1126970", VA = "0x1126970")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAEDC", Offset = "0x5CAEDC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A1E")]
				[Address(RVA = "0x1126978", Offset = "0x1126978", VA = "0x1126978")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAEEC", Offset = "0x5CAEEC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010A")]
			protected Vector3 force
			{
				[Token(Token = "0x6000A1F")]
				[Address(RVA = "0x1126980", Offset = "0x1126980", VA = "0x1126980")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAEFC", Offset = "0x5CAEFC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A20")]
				[Address(RVA = "0x112698C", Offset = "0x112698C", VA = "0x112698C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAF0C", Offset = "0x5CAF0C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010B")]
			protected Vector3 point
			{
				[Token(Token = "0x6000A21")]
				[Address(RVA = "0x1126998", Offset = "0x1126998", VA = "0x1126998")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAF1C", Offset = "0x5CAF1C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A22")]
				[Address(RVA = "0x11269A4", Offset = "0x11269A4", VA = "0x11269A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CAF2C", Offset = "0x5CAF2C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x11269B0", Offset = "0x11269B0", VA = "0x11269B0")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x1126AF8", Offset = "0x1126AF8", VA = "0x1126AF8")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000A25")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000A26")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000A27")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x1126BE0", Offset = "0x1126BE0", VA = "0x1126BE0")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018C")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001B5")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000B68")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7948", Offset = "0x5C7948")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000B69")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7980", Offset = "0x5C7980")]
				public float weight;

				[Token(Token = "0x4000B6A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000B6B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000A8F")]
				[Address(RVA = "0x12F8A00", Offset = "0x12F8A00", VA = "0x12F8A00")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000A90")]
				[Address(RVA = "0x12F8A90", Offset = "0x12F8A90", VA = "0x12F8A90")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000A91")]
				[Address(RVA = "0x12F8AA4", Offset = "0x12F8AA4", VA = "0x12F8AA4")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000A86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6AF4", Offset = "0x5C6AF4")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000A87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6B2C", Offset = "0x5C6B2C")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000A88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6B64", Offset = "0x5C6B64")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x1126BF4", Offset = "0x1126BF4", VA = "0x1126BF4", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x1126DA4", Offset = "0x1126DA4", VA = "0x1126DA4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x1126E10", Offset = "0x1126E10", VA = "0x1126E10", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x1126FB0", Offset = "0x1126FB0", VA = "0x1126FB0")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018D")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001B6")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000B6C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C79B8", Offset = "0x5C79B8")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000B6D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C79F0", Offset = "0x5C79F0")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C79F0", Offset = "0x5C79F0")]
				public float weight;

				[Token(Token = "0x4000B6E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000B6F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000A92")]
				[Address(RVA = "0x12F8AAC", Offset = "0x12F8AAC", VA = "0x12F8AAC")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000A93")]
				[Address(RVA = "0x12F8B88", Offset = "0x12F8B88", VA = "0x12F8B88")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000A94")]
				[Address(RVA = "0x12F8B94", Offset = "0x12F8B94", VA = "0x12F8B94")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000A89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6B9C", Offset = "0x5C6B9C")]
			public int curveIndex;

			[Token(Token = "0x4000A8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6BD4", Offset = "0x5C6BD4")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000A8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x1126FCC", Offset = "0x1126FCC", VA = "0x1126FCC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x11270B0", Offset = "0x11270B0", VA = "0x11270B0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x112711C", Offset = "0x112711C", VA = "0x112711C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x11273D0", Offset = "0x11273D0", VA = "0x11273D0")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2A20", Offset = "0x5C2A20")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2A58", Offset = "0x5C2A58")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x12BF764", Offset = "0x12BF764", VA = "0x12BF764", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x12BF838", Offset = "0x12BF838", VA = "0x12BF838")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x12BFA9C", Offset = "0x12BFA9C", VA = "0x12BFA9C")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200018E")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001B7")]
			public class EffectorLink
			{
				[Token(Token = "0x4000B70")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7A44", Offset = "0x5C7A44")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000B71")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7A7C", Offset = "0x5C7A7C")]
				public float weight;

				[Token(Token = "0x6000A95")]
				[Address(RVA = "0x12F8BD8", Offset = "0x12F8BD8", VA = "0x12F8BD8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000A8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6C0C", Offset = "0x5C6C0C")]
			public Transform transform;

			[Token(Token = "0x4000A8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6C44", Offset = "0x5C6C44")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000A8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6C7C", Offset = "0x5C6C7C")]
			public float speed;

			[Token(Token = "0x4000A8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6CB4", Offset = "0x5C6CB4")]
			public float acceleration;

			[Token(Token = "0x4000A90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6CEC", Offset = "0x5C6CEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C6CEC", Offset = "0x5C6CEC")]
			public float matchVelocity;

			[Token(Token = "0x4000A91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6D40", Offset = "0x5C6D40")]
			public float gravity;

			[Token(Token = "0x4000A92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000A93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000A94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000A95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000A96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x12F0B9C", Offset = "0x12F0B9C", VA = "0x12F0B9C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x12F0C54", Offset = "0x12F0C54", VA = "0x12F0C54")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x12F0F10", Offset = "0x12F0F10", VA = "0x12F0F10")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2A90", Offset = "0x5C2A90")]
		public Body[] bodies;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2AC8", Offset = "0x5C2AC8")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x11FC9E8", Offset = "0x11FC9E8", VA = "0x11FC9E8")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x11FCA64", Offset = "0x11FCA64", VA = "0x11FCA64", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x11FCB24", Offset = "0x11FCB24", VA = "0x11FCB24")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C2B00", Offset = "0x5C2B00")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2B00", Offset = "0x5C2B00")]
		public Transform target;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C2B60", Offset = "0x5C2B60")]
		public float weight;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2B78", Offset = "0x5C2B78")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2BB0", Offset = "0x5C2BB0")]
		public float weightSmoothTime;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C2BE8", Offset = "0x5C2BE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2BE8", Offset = "0x5C2BE8")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2C48", Offset = "0x5C2C48")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2C80", Offset = "0x5C2C80")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2CB8", Offset = "0x5C2CB8")]
		public float slerpSpeed;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2CF0", Offset = "0x5C2CF0")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2D28", Offset = "0x5C2D28")]
		public float minDistance;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C2D60", Offset = "0x5C2D60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2D60", Offset = "0x5C2D60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C2D60", Offset = "0x5C2D60")]
		public float maxRootAngle;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x17000084")]
		private Vector3 pivot
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0xF9E6B4", Offset = "0xF9E6B4", VA = "0xF9E6B4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xF9E640", Offset = "0xF9E640", VA = "0xF9E640")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xF9E744", Offset = "0xF9E744", VA = "0xF9E744")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xF9EC74", Offset = "0xF9EC74", VA = "0xF9EC74")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xF9ED60", Offset = "0xF9ED60", VA = "0xF9ED60")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xF9EF58", Offset = "0xF9EF58", VA = "0xF9EF58")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200018F")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000A97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6D78", Offset = "0x5C6D78")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000A98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6DB0", Offset = "0x5C6DB0")]
			public float spring;

			[Token(Token = "0x4000A99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6DE8", Offset = "0x5C6DE8")]
			public bool x;

			[Token(Token = "0x4000A9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6E20", Offset = "0x5C6E20")]
			public bool y;

			[Token(Token = "0x4000A9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6E58", Offset = "0x5C6E58")]
			public bool z;

			[Token(Token = "0x4000A9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6E90", Offset = "0x5C6E90")]
			public float minX;

			[Token(Token = "0x4000A9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6EC8", Offset = "0x5C6EC8")]
			public float maxX;

			[Token(Token = "0x4000A9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6F00", Offset = "0x5C6F00")]
			public float minY;

			[Token(Token = "0x4000A9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6F38", Offset = "0x5C6F38")]
			public float maxY;

			[Token(Token = "0x4000AA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6F70", Offset = "0x5C6F70")]
			public float minZ;

			[Token(Token = "0x4000AA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6FA8", Offset = "0x5C6FA8")]
			public float maxZ;

			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x12F3790", Offset = "0x12F3790", VA = "0x12F3790")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x12F38E8", Offset = "0x12F38E8", VA = "0x12F38E8")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x12F3960", Offset = "0x12F3960", VA = "0x12F3960")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x12F39B8", Offset = "0x12F39B8", VA = "0x12F39B8")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000190")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE788", Offset = "0x5BE788")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x1700010C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A3B")]
				[Address(RVA = "0x12F3740", Offset = "0x12F3740", VA = "0x12F3740", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A3D")]
				[Address(RVA = "0x12F3788", Offset = "0x12F3788", VA = "0x12F3788", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x12F35C0", Offset = "0x12F35C0", VA = "0x12F35C0")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x12F35EC", Offset = "0x12F35EC", VA = "0x12F35EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x12F35F0", Offset = "0x12F35F0", VA = "0x12F35F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x12F3748", Offset = "0x12F3748", VA = "0x12F3748", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2DDC", Offset = "0x5C2DDC")]
		public float weight;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2E14", Offset = "0x5C2E14")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000085")]
		protected float deltaTime
		{
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0xFA3640", Offset = "0xFA3640", VA = "0xFA3640")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006E0")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xFA1D2C", Offset = "0xFA1D2C", VA = "0xFA1D2C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xFA366C", Offset = "0xFA366C", VA = "0xFA366C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5CA23C", Offset = "0x5CA23C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xFA36D8", Offset = "0xFA36D8", VA = "0xFA36D8")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xFA37B4", Offset = "0xFA37B4", VA = "0xFA37B4")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xFA209C", Offset = "0xFA209C", VA = "0xFA209C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xFA21BC", Offset = "0xFA21BC", VA = "0xFA21BC")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000191")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE798", Offset = "0x5BE798")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x1700010E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A41")]
				[Address(RVA = "0x12F3B40", Offset = "0x12F3B40", VA = "0x12F3B40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A43")]
				[Address(RVA = "0x12F3B88", Offset = "0x12F3B88", VA = "0x12F3B88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x12F39C0", Offset = "0x12F39C0", VA = "0x12F39C0")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x12F39EC", Offset = "0x12F39EC", VA = "0x12F39EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x12F39F0", Offset = "0x12F39F0", VA = "0x12F39F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x12F3B48", Offset = "0x12F3B48", VA = "0x12F3B48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2E4C", Offset = "0x5C2E4C")]
		public float weight;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2E84", Offset = "0x5C2E84")]
		public VRIK ik;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000086")]
		protected float deltaTime
		{
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0xFA3874", Offset = "0xFA3874", VA = "0xFA3874")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006E8")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xFA38A0", Offset = "0xFA38A0", VA = "0xFA38A0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xFA38CC", Offset = "0xFA38CC", VA = "0xFA38CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5CA29C", Offset = "0x5CA29C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xFA3938", Offset = "0xFA3938", VA = "0xFA3938")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xFA3A14", Offset = "0xFA3A14", VA = "0xFA3A14", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xFA3B20", Offset = "0xFA3B20", VA = "0xFA3B20")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000192")]
		public class EffectorLink
		{
			[Token(Token = "0x4000AA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000AA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000AAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000AAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x12F3B90", Offset = "0x12F3B90", VA = "0x12F3B90")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x12F3DAC", Offset = "0x12F3DAC", VA = "0x12F3DAC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xFA3B30", Offset = "0xFA3B30", VA = "0xFA3B30")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xFA3BF4", Offset = "0xFA3BF4", VA = "0xFA3BF4")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xFA3CB0", Offset = "0xFA3CB0", VA = "0xFA3CB0")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000193")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20001B8")]
			public class EffectorLink
			{
				[Token(Token = "0x4000B72")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7AB4", Offset = "0x5C7AB4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000B73")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7AEC", Offset = "0x5C7AEC")]
				public float weight;

				[Token(Token = "0x6000A96")]
				[Address(RVA = "0x12F8BE8", Offset = "0x12F8BE8", VA = "0x12F8BE8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000AAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6FE0", Offset = "0x5C6FE0")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000AAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7018", Offset = "0x5C7018")]
			public Transform raycastTo;

			[Token(Token = "0x4000AAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7050", Offset = "0x5C7050")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C7050", Offset = "0x5C7050")]
			public float raycastRadius;

			[Token(Token = "0x4000AAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C70A4", Offset = "0x5C70A4")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000AB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C70DC", Offset = "0x5C70DC")]
			public float smoothTimeIn;

			[Token(Token = "0x4000AB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7114", Offset = "0x5C7114")]
			public float smoothTimeOut;

			[Token(Token = "0x4000AB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C714C", Offset = "0x5C714C")]
			public LayerMask layers;

			[Token(Token = "0x4000AB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000AB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000AB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x12F416C", Offset = "0x12F416C", VA = "0x12F416C")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x12F42B0", Offset = "0x12F42B0", VA = "0x12F42B0")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x12F43A8", Offset = "0x12F43A8", VA = "0x12F43A8")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x12F4578", Offset = "0x12F4578", VA = "0x12F4578")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2EBC", Offset = "0x5C2EBC")]
		public Avoider[] avoiders;

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xFA4854", Offset = "0xFA4854", VA = "0xFA4854", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xFA48DC", Offset = "0xFA48DC", VA = "0xFA48DC")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000194")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20001B9")]
			public class EffectorLink
			{
				[Token(Token = "0x4000B74")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7B24", Offset = "0x5C7B24")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000B75")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7B5C", Offset = "0x5C7B5C")]
				public float weight;

				[Token(Token = "0x6000A97")]
				[Address(RVA = "0x12F8BF0", Offset = "0x12F8BF0", VA = "0x12F8BF0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000AB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7184", Offset = "0x5C7184")]
			public Vector3 offset;

			[Token(Token = "0x4000AB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C71BC", Offset = "0x5C71BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C71BC", Offset = "0x5C71BC")]
			public float additivity;

			[Token(Token = "0x4000AB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7210", Offset = "0x5C7210")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000AB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7248", Offset = "0x5C7248")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000ABA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000ABB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x12F5078", Offset = "0x12F5078", VA = "0x12F5078")]
			public void Start()
			{
			}

			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x12F50C8", Offset = "0x12F50C8", VA = "0x12F50C8")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x12F528C", Offset = "0x12F528C", VA = "0x12F528C")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000195")]
		public enum Handedness
		{
			[Token(Token = "0x4000ABD")]
			Right,
			[Token(Token = "0x4000ABE")]
			Left
		}

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2EF4", Offset = "0x5C2EF4")]
		public AimIK aimIK;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2F2C", Offset = "0x5C2F2C")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2F64", Offset = "0x5C2F64")]
		public Handedness handedness;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2F9C", Offset = "0x5C2F9C")]
		public bool twoHanded;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C2FD4", Offset = "0x5C2FD4")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C300C", Offset = "0x5C300C")]
		public float magnitudeRandom;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3044", Offset = "0x5C3044")]
		public Vector3 rotationRandom;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C307C", Offset = "0x5C307C")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C30B4", Offset = "0x5C30B4")]
		public float blendTime;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5C30EC", Offset = "0x5C30EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C30EC", Offset = "0x5C30EC")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x17000087")]
		public bool isFinished
		{
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0xFAAA3C", Offset = "0xFAAA3C", VA = "0xFAAA3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000088")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0xFAB4B4", Offset = "0xFAB4B4", VA = "0xFAB4B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0xFAB4F4", Offset = "0xFAB4F4", VA = "0xFAB4F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		private Transform primaryHand
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0xFAB474", Offset = "0xFAB474", VA = "0xFAB474")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0xFAB494", Offset = "0xFAB494", VA = "0xFAB494")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xFAAA6C", Offset = "0xFAAA6C", VA = "0xFAAA6C")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xFAAA98", Offset = "0xFAAA98", VA = "0xFAAA98")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xFAABE0", Offset = "0xFAABE0", VA = "0xFAABE0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xFAB534", Offset = "0xFAB534", VA = "0xFAB534")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xFAB5E8", Offset = "0xFAB5E8", VA = "0xFAB5E8")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xFAB624", Offset = "0xFAB624", VA = "0xFAB624", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xFAB7DC", Offset = "0xFAB7DC", VA = "0xFAB7DC")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C314C", Offset = "0x5C314C")]
		public float weight;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3184", Offset = "0x5C3184")]
		public float offset;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xEA9488", Offset = "0xEA9488", VA = "0xEA9488")]
		private void Start()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xEA9570", Offset = "0xEA9570", VA = "0xEA9570")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xEA9658", Offset = "0xEA9658", VA = "0xEA9658")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xEA99AC", Offset = "0xEA99AC", VA = "0xEA99AC")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xEA99E4", Offset = "0xEA99E4", VA = "0xEA99E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xEA9AF0", Offset = "0xEA9AF0", VA = "0xEA9AF0")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x2000196")]
		public class Settings
		{
			[Token(Token = "0x4000ABF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7280", Offset = "0x5C7280")]
			public float scaleMlp;

			[Token(Token = "0x4000AC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C72B8", Offset = "0x5C72B8")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000AC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C72F0", Offset = "0x5C72F0")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000AC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7328", Offset = "0x5C7328")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000AC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7360", Offset = "0x5C7360")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000AC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7398", Offset = "0x5C7398")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000AC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C73D0", Offset = "0x5C73D0")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000AC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5C7408", Offset = "0x5C7408")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7408", Offset = "0x5C7408")]
			public Vector3 headOffset;

			[Token(Token = "0x4000AC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7458", Offset = "0x5C7458")]
			public Vector3 handOffset;

			[Token(Token = "0x4000AC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7490", Offset = "0x5C7490")]
			public float footForwardOffset;

			[Token(Token = "0x4000AC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C74C8", Offset = "0x5C74C8")]
			public float footInwardOffset;

			[Token(Token = "0x4000ACA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7500", Offset = "0x5C7500")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C7500", Offset = "0x5C7500")]
			public float footHeadingOffset;

			[Token(Token = "0x4000ACB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C755C", Offset = "0x5C755C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000ACC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C7574", Offset = "0x5C7574")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x12F8100", Offset = "0x12F8100", VA = "0x12F8100")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000197")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20001BA")]
			public class Target
			{
				[Token(Token = "0x4000B76")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000B77")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000B78")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000A98")]
				[Address(RVA = "0x12F8BF8", Offset = "0x12F8BF8", VA = "0x12F8BF8")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000A99")]
				[Address(RVA = "0x12F8CB8", Offset = "0x12F8CB8", VA = "0x12F8CB8")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000ACD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000ACE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000ACF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000AD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000AD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000AD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000AD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x4000AD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000AD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000AD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000AD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000AD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x12F80F8", Offset = "0x12F80F8", VA = "0x12F80F8")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xEB3A5C", Offset = "0xEB3A5C", VA = "0xEB3A5C")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xEB2624", Offset = "0xEB2624", VA = "0xEB2624")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xEB3BC4", Offset = "0xEB3BC4", VA = "0xEB3BC4")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xEB3AD8", Offset = "0xEB3AD8", VA = "0xEB3AD8")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xEB2850", Offset = "0xEB2850", VA = "0xEB2850")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xEB3BDC", Offset = "0xEB3BDC", VA = "0xEB3BDC")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xEB1B3C", Offset = "0xEB1B3C", VA = "0xEB1B3C")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xEB43C8", Offset = "0xEB43C8", VA = "0xEB43C8")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xEB1928", Offset = "0xEB1928", VA = "0xEB1928")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xEB47D8", Offset = "0xEB47D8", VA = "0xEB47D8")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xEB4E7C", Offset = "0xEB4E7C", VA = "0xEB4E7C")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xEB4C28", Offset = "0xEB4C28", VA = "0xEB4C28")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xEB50EC", Offset = "0xEB50EC", VA = "0xEB50EC")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xEB5348", Offset = "0xEB5348", VA = "0xEB5348")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xEB5438", Offset = "0xEB5438", VA = "0xEB5438")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000DE")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xEB5754", Offset = "0xEB5754", VA = "0xEB5754")]
		private void Start()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xEB57A8", Offset = "0xEB57A8", VA = "0xEB57A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xEB57DC", Offset = "0xEB57DC", VA = "0xEB57DC")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xEB5918", Offset = "0xEB5918", VA = "0xEB5918")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C31BC", Offset = "0x5C31BC")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x1700008C")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0xEB6008", Offset = "0xEB6008", VA = "0xEB6008")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA2FC", Offset = "0x5CA2FC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000719")]
			[Address(RVA = "0xEB6014", Offset = "0xEB6014", VA = "0xEB6014")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA30C", Offset = "0x5CA30C")]
			private set
			{
			}
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xEB6020", Offset = "0xEB6020", VA = "0xEB6020")]
		private void Awake()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xEB41D0", Offset = "0xEB41D0", VA = "0xEB41D0")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xEB4654", Offset = "0xEB4654", VA = "0xEB4654")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xEB610C", Offset = "0xEB610C", VA = "0xEB610C")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xEB6528", Offset = "0xEB6528", VA = "0xEB6528")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xEB6634", Offset = "0xEB6634", VA = "0xEB6634")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000E0")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000198")]
		public class Offset
		{
			[Token(Token = "0x4000AD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000ADA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000ADB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x4000ADC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x1123EAC", Offset = "0x1123EAC", VA = "0x1123EAC")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x112400C", Offset = "0x112400C", VA = "0x112400C")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x11BEF20", Offset = "0x11BEF20", VA = "0x11BEF20")]
		private void Start()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x11BEF74", Offset = "0x11BEF74", VA = "0x11BEF74")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x11BEFF0", Offset = "0x11BEFF0", VA = "0x11BEFF0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x11BF0C8", Offset = "0x11BF0C8", VA = "0x11BF0C8")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x10BA04C", Offset = "0x10BA04C", VA = "0x10BA04C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x10BA0D0", Offset = "0x10BA0D0", VA = "0x10BA0D0")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C31CC", Offset = "0x5C31CC")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x10BB080", Offset = "0x10BB080", VA = "0x10BB080")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x10BB0F8", Offset = "0x10BB0F8", VA = "0x10BB0F8")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xEA9288", Offset = "0xEA9288", VA = "0xEA9288")]
		private void Start()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xEA92CC", Offset = "0xEA92CC", VA = "0xEA92CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xEA9480", Offset = "0xEA9480", VA = "0xEA9480")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3204", Offset = "0x5C3204")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C323C", Offset = "0x5C323C")]
		public AimIK aim;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3274", Offset = "0x5C3274")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C32AC", Offset = "0x5C32AC")]
		public Animator animator;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C32E4", Offset = "0x5C32E4")]
		public float crossfadeTime;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C331C", Offset = "0x5C331C")]
		public float minAimDistance;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xEA9BB0", Offset = "0xEA9BB0", VA = "0xEA9BB0")]
		private void Start()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xEA9BF4", Offset = "0xEA9BF4", VA = "0xEA9BF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xEA9D5C", Offset = "0xEA9D5C", VA = "0xEA9D5C")]
		private void Pose()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xEA9EEC", Offset = "0xEA9EEC", VA = "0xEA9EEC")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xEAA028", Offset = "0xEAA028", VA = "0xEAA028")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xEAA0A4", Offset = "0xEAA0A4", VA = "0xEAA0A4")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xEAC2A8", Offset = "0xEAC2A8", VA = "0xEAC2A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xEAC418", Offset = "0xEAC418", VA = "0xEAC418")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xEAC5AC", Offset = "0xEAC5AC", VA = "0xEAC5AC")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x5C3354", Offset = "0x5C3354")]
		public Animator animator;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x5C338C", Offset = "0x5C338C")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C33C4", Offset = "0x5C33C4")]
		public float lookAtWeight;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C33DC", Offset = "0x5C33DC")]
		public float lookAtBodyWeight;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C33F4", Offset = "0x5C33F4")]
		public float lookAtHeadWeight;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C340C", Offset = "0x5C340C")]
		public float lookAtEyesWeight;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C3424", Offset = "0x5C3424")]
		public float lookAtClampWeight;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C343C", Offset = "0x5C343C")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C3454", Offset = "0x5C3454")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x5C346C", Offset = "0x5C346C")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C34A4", Offset = "0x5C34A4")]
		public float footPositionWeight;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C34BC", Offset = "0x5C34BC")]
		public float footRotationWeight;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x5C34D4", Offset = "0x5C34D4")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C350C", Offset = "0x5C350C")]
		public float handPositionWeight;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C3524", Offset = "0x5C3524")]
		public float handRotationWeight;

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x10C3514", Offset = "0x10C3514", VA = "0x10C3514")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x10C391C", Offset = "0x10C391C", VA = "0x10C391C")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C353C", Offset = "0x5C353C")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sine;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit rootHit;

		[Token(Token = "0x1700008D")]
		public Vector3 velocity
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0xF9F3E4", Offset = "0xF9F3E4", VA = "0xF9F3E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA31C", Offset = "0x5CA31C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000737")]
			[Address(RVA = "0xF9F3F0", Offset = "0xF9F3F0", VA = "0xF9F3F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA32C", Offset = "0x5CA32C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xF9F3FC", Offset = "0xF9F3FC", VA = "0xF9F3FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xF9F438", Offset = "0xF9F438", VA = "0xF9F438")]
		private void Update()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xF9FCAC", Offset = "0xF9FCAC", VA = "0xF9FCAC")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xF9FA5C", Offset = "0xF9FA5C", VA = "0xF9FA5C")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xF9FDA8", Offset = "0xF9FDA8", VA = "0xF9FDA8")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x1700008E")]
		public Vector3 inputVector
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0xF9FDD4", Offset = "0xF9FDD4", VA = "0xF9FDD4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xF9FE58", Offset = "0xF9FE58", VA = "0xF9FE58")]
		private void Update()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xFA007C", Offset = "0xFA007C", VA = "0xFA007C")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x2000199")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE7A8", Offset = "0x5BE7A8")]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000ADD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000ADE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000ADF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x4000AE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000AE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x17000110")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A54")]
				[Address(RVA = "0x12F304C", Offset = "0x12F304C", VA = "0x12F304C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000111")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A56")]
				[Address(RVA = "0x12F3094", Offset = "0x12F3094", VA = "0x12F3094", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x12F2D5C", Offset = "0x12F2D5C", VA = "0x12F2D5C")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x12F2D88", Offset = "0x12F2D88", VA = "0x12F2D88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x12F2D8C", Offset = "0x12F2D8C", VA = "0x12F2D8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x12F3054", Offset = "0x12F3054", VA = "0x12F3054", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x1700008F")]
		public bool isStepping
		{
			[Token(Token = "0x6000740")]
			[Address(RVA = "0xFA0090", Offset = "0xFA0090", VA = "0xFA0090")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000090")]
		public Vector3 position
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0xF9FD74", Offset = "0xF9FD74", VA = "0xF9FD74")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000742")]
			[Address(RVA = "0xFA00A4", Offset = "0xFA00A4", VA = "0xFA00A4")]
			set
			{
			}
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xFA00F4", Offset = "0xFA00F4", VA = "0xFA00F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xFA02E8", Offset = "0xFA02E8", VA = "0xFA02E8")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xFA0484", Offset = "0xFA0484", VA = "0xFA0484")]
		private void Start()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xFA06AC", Offset = "0xFA06AC", VA = "0xFA06AC")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xFA0920", Offset = "0xFA0920", VA = "0xFA0920")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xFA0A98", Offset = "0xFA0A98", VA = "0xFA0A98")]
		private void Update()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xFA0604", Offset = "0xFA0604", VA = "0xFA0604")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5CA33C", Offset = "0x5CA33C")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xFA0C94", Offset = "0xFA0C94", VA = "0xFA0C94")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xFA0CF8", Offset = "0xFA0CF8", VA = "0xFA0CF8")]
		private void Start()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xFA0DB8", Offset = "0xFA0DB8", VA = "0xFA0DB8")]
		private void Update()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xFA100C", Offset = "0xFA100C", VA = "0xFA100C")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200019A")]
		public struct Warp
		{
			[Token(Token = "0x4000AE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C759C", Offset = "0x5C759C")]
			public int animationLayer;

			[Token(Token = "0x4000AE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C75D4", Offset = "0x5C75D4")]
			public string animationState;

			[Token(Token = "0x4000AE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C760C", Offset = "0x5C760C")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000AE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7644", Offset = "0x5C7644")]
			public Transform warpFrom;

			[Token(Token = "0x4000AE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C767C", Offset = "0x5C767C")]
			public Transform warpTo;

			[Token(Token = "0x4000AE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C76B4", Offset = "0x5C76B4")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x200019B")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000AE9")]
			PositionOffset,
			[Token(Token = "0x4000AEA")]
			Position
		}

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C354C", Offset = "0x5C354C")]
		public Animator animator;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3584", Offset = "0x5C3584")]
		public EffectorMode effectorMode;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5C35BC", Offset = "0x5C35BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C35BC", Offset = "0x5C35BC")]
		public Warp[] warps;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x10BB76C", Offset = "0x10BB76C", VA = "0x10BB76C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x10BB798", Offset = "0x10BB798", VA = "0x10BB798")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x10BB9C0", Offset = "0x10BB9C0", VA = "0x10BB9C0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x10BBC84", Offset = "0x10BBC84", VA = "0x10BBC84")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x10BBD24", Offset = "0x10BBD24", VA = "0x10BBD24")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x10BBD2C", Offset = "0x10BBD2C", VA = "0x10BBD2C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x10BBD80", Offset = "0x10BBD80", VA = "0x10BBD80")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x10BBF1C", Offset = "0x10BBF1C", VA = "0x10BBF1C", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x10BC124", Offset = "0x10BC124", VA = "0x10BC124")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C360C", Offset = "0x5C360C")]
		public float headLookWeight;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x10BC138", Offset = "0x10BC138", VA = "0x10BC138", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x10BC2C4", Offset = "0x10BC2C4", VA = "0x10BC2C4", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x10BC340", Offset = "0x10BC340", VA = "0x10BC340")]
		private void Read()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x10BC434", Offset = "0x10BC434", VA = "0x10BC434")]
		private void AimIK()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x10BC47C", Offset = "0x10BC47C", VA = "0x10BC47C")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x10BC868", Offset = "0x10BC868", VA = "0x10BC868")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x10BC6F0", Offset = "0x10BC6F0", VA = "0x10BC6F0")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x10BCAC4", Offset = "0x10BCAC4", VA = "0x10BCAC4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x10BCBD0", Offset = "0x10BCBD0", VA = "0x10BCBD0")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1232E8C", Offset = "0x1232E8C", VA = "0x1232E8C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x1232EE8", Offset = "0x1232EE8", VA = "0x1232EE8", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x1233124", Offset = "0x1233124", VA = "0x1233124")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x1233218", Offset = "0x1233218", VA = "0x1233218")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000091")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x1233C3C", Offset = "0x1233C3C", VA = "0x1233C3C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000092")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000767")]
			[Address(RVA = "0x1233CC0", Offset = "0x1233CC0", VA = "0x1233CC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x1233A44", Offset = "0x1233A44", VA = "0x1233A44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1233AB0", Offset = "0x1233AB0", VA = "0x1233AB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x1233D44", Offset = "0x1233D44", VA = "0x1233D44")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C3624", Offset = "0x5C3624")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x123880C", Offset = "0x123880C", VA = "0x123880C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1238C6C", Offset = "0x1238C6C", VA = "0x1238C6C")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1238D90", Offset = "0x1238D90", VA = "0x1238D90")]
		private void Start()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1238E38", Offset = "0x1238E38", VA = "0x1238E38")]
		private void Update()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x12391BC", Offset = "0x12391BC", VA = "0x12391BC")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1239268", Offset = "0x1239268", VA = "0x1239268")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200019C")]
		public class Limb
		{
			[Token(Token = "0x4000AEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x4000AEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000AED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x1123994", Offset = "0x1123994", VA = "0x1123994")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x1123A18", Offset = "0x1123A18", VA = "0x1123A18")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x11BC2E0", Offset = "0x11BC2E0", VA = "0x11BC2E0")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x11BC438", Offset = "0x11BC438", VA = "0x11BC438")]
		private void Start()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x11BC4DC", Offset = "0x11BC4DC", VA = "0x11BC4DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x11BC4E0", Offset = "0x11BC4E0", VA = "0x11BC4E0")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x11BC4F0", Offset = "0x11BC4F0", VA = "0x11BC4F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x11BC564", Offset = "0x11BC564", VA = "0x11BC564")]
		private void Update()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x11BC638", Offset = "0x11BC638", VA = "0x11BC638")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C363C", Offset = "0x5C363C")]
		public Transform target;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3674", Offset = "0x5C3674")]
		public Transform pin;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C36AC", Offset = "0x5C36AC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C36E4", Offset = "0x5C36E4")]
		public AimIK aim;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C371C", Offset = "0x5C371C")]
		public float weight;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3754", Offset = "0x5C3754")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C378C", Offset = "0x5C378C")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x11BC640", Offset = "0x11BC640", VA = "0x11BC640")]
		private void Start()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x11BC694", Offset = "0x11BC694", VA = "0x11BC694")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x11BC838", Offset = "0x11BC838", VA = "0x11BC838")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x11BE8DC", Offset = "0x11BE8DC", VA = "0x11BE8DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x11BE9A4", Offset = "0x11BE9A4", VA = "0x11BE9A4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x11BEA34", Offset = "0x11BEA34", VA = "0x11BEA34")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x11BEE0C", Offset = "0x11BEE0C", VA = "0x11BEE0C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x11BEF18", Offset = "0x11BEF18", VA = "0x11BEF18")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C37C4", Offset = "0x5C37C4")]
		public float aimWeight;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C37DC", Offset = "0x5C37DC")]
		public float sightWeight;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C37F4", Offset = "0x5C37F4")]
		public float maxAngle;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AimIK headAim;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CameraControllerFPS cam;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Recoil recoil;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C3810", Offset = "0x5C3810")]
		public float cameraRecoilWeight;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool updateFrame;

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x11BF2F8", Offset = "0x11BF2F8", VA = "0x11BF2F8")]
		private void Start()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x11BF4BC", Offset = "0x11BF4BC", VA = "0x11BF4BC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x11BF4C8", Offset = "0x11BF4C8", VA = "0x11BF4C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x11BF748", Offset = "0x11BF748", VA = "0x11BF748")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x11BFA18", Offset = "0x11BFA18", VA = "0x11BFA18")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x11BF590", Offset = "0x11BF590", VA = "0x11BF590")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x11C030C", Offset = "0x11C030C", VA = "0x11C030C")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C3828", Offset = "0x5C3828")]
		public float walkSpeed;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x11C032C", Offset = "0x11C032C", VA = "0x11C032C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x11C03A4", Offset = "0x11C03A4", VA = "0x11C03A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x11C0490", Offset = "0x11C0490", VA = "0x11C0490")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x11C0548", Offset = "0x11C0548", VA = "0x11C0548")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x12BF418", Offset = "0x12BF418", VA = "0x12BF418")]
		private void Update()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x12BF570", Offset = "0x12BF570", VA = "0x12BF570")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x12BF754", Offset = "0x12BF754", VA = "0x12BF754")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x12BFDF0", Offset = "0x12BFDF0", VA = "0x12BFDF0")]
		private void Start()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x12BFF48", Offset = "0x12BFF48", VA = "0x12BFF48")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x12C0284", Offset = "0x12C0284", VA = "0x12C0284")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x11FCC90", Offset = "0x11FCC90", VA = "0x11FCC90")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x11FCEDC", Offset = "0x11FCEDC", VA = "0x11FCEDC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x11FCFE8", Offset = "0x11FCFE8", VA = "0x11FCFE8")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x11FCFF0", Offset = "0x11FCFF0", VA = "0x11FCFF0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x11FD804", Offset = "0x11FD804", VA = "0x11FD804")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3840", Offset = "0x5C3840")]
		public InteractionObject interactionObject;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3878", Offset = "0x5C3878")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xF9B538", Offset = "0xF9B538", VA = "0xF9B538")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xF9B58C", Offset = "0xF9B58C", VA = "0xF9B58C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xF9B8D0", Offset = "0xF9B8D0", VA = "0xF9B8D0")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200019D")]
		public class Partner
		{
			[Token(Token = "0x4000AEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000AEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000AF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000AF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000AF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000AF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000AF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000AF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000AF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000AF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000AF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x17000112")]
			private Transform neck
			{
				[Token(Token = "0x6000A5B")]
				[Address(RVA = "0x12F2AE4", Offset = "0x12F2AE4", VA = "0x12F2AE4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x12F2398", Offset = "0x12F2398", VA = "0x12F2398")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x12F23B8", Offset = "0x12F23B8", VA = "0x12F23B8")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x12F2950", Offset = "0x12F2950", VA = "0x12F2950")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x12F2B3C", Offset = "0x12F2B3C", VA = "0x12F2B3C")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xF9DA20", Offset = "0xF9DA20", VA = "0xF9DA20")]
		private void Start()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xF9DA5C", Offset = "0xF9DA5C", VA = "0xF9DA5C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xF9DAC4", Offset = "0xF9DAC4", VA = "0xF9DAC4")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200019E")]
		public enum Mode
		{
			[Token(Token = "0x4000AFA")]
			Position,
			[Token(Token = "0x4000AFB")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x200019F")]
		public class Absorber
		{
			[Token(Token = "0x4000AFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C76EC", Offset = "0x5C76EC")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000AFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C7724", Offset = "0x5C7724")]
			public float weight;

			[Token(Token = "0x4000AFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000AFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000B00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x12F309C", Offset = "0x12F309C", VA = "0x12F309C")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x12F3170", Offset = "0x12F3170", VA = "0x12F3170")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x12F31AC", Offset = "0x12F31AC", VA = "0x12F31AC")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x12F3244", Offset = "0x12F3244", VA = "0x12F3244")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x12F32B8", Offset = "0x12F32B8", VA = "0x12F32B8")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C38B0", Offset = "0x5C38B0")]
		public Mode mode;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C38E8", Offset = "0x5C38E8")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3920", Offset = "0x5C3920")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3958", Offset = "0x5C3958")]
		public float falloffSpeed;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xFA1C44", Offset = "0xFA1C44", VA = "0xFA1C44", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xFA1D58", Offset = "0xFA1D58", VA = "0xFA1D58")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xFA1DE8", Offset = "0xFA1DE8", VA = "0xFA1DE8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xFA1EFC", Offset = "0xFA1EFC", VA = "0xFA1EFC")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xFA1F88", Offset = "0xFA1F88", VA = "0xFA1F88", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xFA21A8", Offset = "0xFA21A8", VA = "0xFA21A8")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xFA21CC", Offset = "0xFA21CC", VA = "0xFA21CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xFA2240", Offset = "0xFA2240", VA = "0xFA2240")]
		private void Update()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xFA2304", Offset = "0xFA2304", VA = "0xFA2304")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xFA23C4", Offset = "0xFA23C4", VA = "0xFA23C4")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001A0")]
		public class EffectorLink
		{
			[Token(Token = "0x4000B01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000B02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x4000B03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x12F35B0", Offset = "0x12F35B0", VA = "0x12F35B0")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xFA3398", Offset = "0xFA3398", VA = "0xFA3398", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xFA34A4", Offset = "0xFA34A4", VA = "0xFA34A4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xFA3630", Offset = "0xFA3630", VA = "0xFA3630")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3990", Offset = "0x5C3990")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C3990", Offset = "0x5C3990")]
		public float weight;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C39E4", Offset = "0x5C39E4")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3A1C", Offset = "0x5C3A1C")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3A68", Offset = "0x5C3A68")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xFA3F08", Offset = "0xFA3F08", VA = "0xFA3F08")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xFA41CC", Offset = "0xFA41CC", VA = "0xFA41CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xFA4814", Offset = "0xFA4814", VA = "0xFA4814")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000093")]
		private bool holding
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xFA4E04", Offset = "0xFA4E04", VA = "0xFA4E04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000094")]
		private bool holdingLeft
		{
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0xFA4EF0", Offset = "0xFA4EF0", VA = "0xFA4EF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000095")]
		private bool holdingRight
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xFA4E3C", Offset = "0xFA4E3C", VA = "0xFA4E3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xFA48EC", Offset = "0xFA48EC", VA = "0xFA48EC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007AB")]
		protected abstract void RotatePivot();

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xFA4FA4", Offset = "0xFA4FA4", VA = "0xFA4FA4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xFA512C", Offset = "0xFA512C", VA = "0xFA512C")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xFA52B0", Offset = "0xFA52B0", VA = "0xFA52B0")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xFA538C", Offset = "0xFA538C", VA = "0xFA538C")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xFA54CC", Offset = "0xFA54CC", VA = "0xFA54CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xFA563C", Offset = "0xFA563C", VA = "0xFA563C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xFA5808", Offset = "0xFA5808", VA = "0xFA5808")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xFA581C", Offset = "0xFA581C", VA = "0xFA581C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xFA5A80", Offset = "0xFA5A80", VA = "0xFA5A80")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xFA5A94", Offset = "0xFA5A94", VA = "0xFA5A94", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xFA5BC8", Offset = "0xFA5BC8", VA = "0xFA5BC8")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xFAA840", Offset = "0xFAA840", VA = "0xFAA840")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xFAA920", Offset = "0xFAA920", VA = "0xFAA920")]
		private void Update()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xFAAA34", Offset = "0xFAAA34", VA = "0xFAAA34")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xFAB84C", Offset = "0xFAB84C", VA = "0xFAB84C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xFAB8A0", Offset = "0xFAB8A0", VA = "0xFAB8A0")]
		private void Update()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xFAB8F8", Offset = "0xFAB8F8", VA = "0xFAB8F8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xFAB9D8", Offset = "0xFAB9D8", VA = "0xFAB9D8")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x20001A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE7B8", Offset = "0x5BE7B8")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000B07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x17000113")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A67")]
				[Address(RVA = "0x12F547C", Offset = "0x12F547C", VA = "0x12F547C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000114")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A69")]
				[Address(RVA = "0x12F54C4", Offset = "0x12F54C4", VA = "0x12F54C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x12F52A0", Offset = "0x12F52A0", VA = "0x12F52A0")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x12F52CC", Offset = "0x12F52CC", VA = "0x12F52CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x12F52D0", Offset = "0x12F52D0", VA = "0x12F52D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x12F5484", Offset = "0x12F5484", VA = "0x12F5484", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xFAB9E8", Offset = "0xFAB9E8", VA = "0xFAB9E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xFABA9C", Offset = "0xFABA9C", VA = "0xFABA9C")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xFABAE4", Offset = "0xFABAE4", VA = "0xFABAE4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5CA39C", Offset = "0x5CA39C")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xFABB60", Offset = "0xFABB60", VA = "0xFABB60")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x20001A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE7C8", Offset = "0x5BE7C8")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x17000115")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A6D")]
				[Address(RVA = "0x12F5E04", Offset = "0x12F5E04", VA = "0x12F5E04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000116")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A6F")]
				[Address(RVA = "0x12F5E4C", Offset = "0x12F5E4C", VA = "0x12F5E4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x12F5CAC", Offset = "0x12F5CAC", VA = "0x12F5CAC")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x12F5CD8", Offset = "0x12F5CD8", VA = "0x12F5CD8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x12F5CDC", Offset = "0x12F5CDC", VA = "0x12F5CDC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x12F5E0C", Offset = "0x12F5E0C", VA = "0x12F5E0C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xEAB044", Offset = "0xEAB044", VA = "0xEAB044")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xEAB0F0", Offset = "0xEAB0F0", VA = "0xEAB0F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5CA3FC", Offset = "0x5CA3FC")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xEAB15C", Offset = "0xEAB15C", VA = "0xEAB15C")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001A3")]
		public class EffectorLink
		{
			[Token(Token = "0x4000B0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000B0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000B0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000B0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000B0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000B10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000B11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float distanceMlp;

			[Token(Token = "0x4000B12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000B13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float lerpSpeed;

			[Token(Token = "0x4000B14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float minSwitchTime;

			[Token(Token = "0x4000B15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float releaseDistance;

			[Token(Token = "0x4000B16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool sliding;

			[Token(Token = "0x4000B17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x4000B18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float raycastDistance;

			[Token(Token = "0x4000B19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool inTouch;

			[Token(Token = "0x4000B1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RaycastHit hit;

			[Token(Token = "0x4000B1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000B1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000B1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private bool initiated;

			[Token(Token = "0x4000B1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float nextSwitchTime;

			[Token(Token = "0x4000B1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float speedF;

			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x12F6274", Offset = "0x12F6274", VA = "0x12F6274")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x12F650C", Offset = "0x12F650C", VA = "0x12F650C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x12F65F8", Offset = "0x12F65F8", VA = "0x12F65F8")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x12F6A8C", Offset = "0x12F6A8C", VA = "0x12F6A8C")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x12F6B80", Offset = "0x12F6B80", VA = "0x12F6B80")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x12F6C18", Offset = "0x12F6C18", VA = "0x12F6C18")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x12F6CAC", Offset = "0x12F6CAC", VA = "0x12F6CAC")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x12F6D40", Offset = "0x12F6D40", VA = "0x12F6D40")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x12F6EAC", Offset = "0x12F6EAC", VA = "0x12F6EAC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xEAE16C", Offset = "0xEAE16C", VA = "0xEAE16C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xEAE1E8", Offset = "0xEAE1E8", VA = "0xEAE1E8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xEAE258", Offset = "0xEAE258", VA = "0xEAE258")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xEAE320", Offset = "0xEAE320", VA = "0xEAE320")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3AB4", Offset = "0x5C3AB4")]
		public Transform to;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3AEC", Offset = "0x5C3AEC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C3AEC", Offset = "0x5C3AEC")]
		public float transferMotion;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xEAE328", Offset = "0xEAE328", VA = "0xEAE328")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xEAE364", Offset = "0xEAE364", VA = "0xEAE364")]
		private void Update()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xEAE418", Offset = "0xEAE418", VA = "0xEAE418")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3B40", Offset = "0x5C3B40")]
		public Transform leftHandTarget;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xEAF668", Offset = "0xEAF668", VA = "0xEAF668")]
		private void Start()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xEAF858", Offset = "0xEAF858", VA = "0xEAF858")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xEAFA48", Offset = "0xEAFA48", VA = "0xEAFA48")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xEAFB14", Offset = "0xEAFB14", VA = "0xEAFB14")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xEAFC20", Offset = "0xEAFC20", VA = "0xEAFC20")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xEAFEBC", Offset = "0xEAFEBC", VA = "0xEAFEBC", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xEB0248", Offset = "0xEB0248", VA = "0xEB0248")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xEB04B4", Offset = "0xEB04B4", VA = "0xEB04B4")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x11C5FDC", Offset = "0x11C5FDC", VA = "0x11C5FDC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x11C6304", Offset = "0x11C6304", VA = "0x11C6304")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x11C6384", Offset = "0x11C6384", VA = "0x11C6384")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x20001A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE7D8", Offset = "0x5BE7D8")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x17000117")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A7C")]
				[Address(RVA = "0x12F46CC", Offset = "0x12F46CC", VA = "0x12F46CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000118")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A7E")]
				[Address(RVA = "0x12F4714", Offset = "0x12F4714", VA = "0x12F4714", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x12F458C", Offset = "0x12F458C", VA = "0x12F458C")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x12F45B8", Offset = "0x12F45B8", VA = "0x12F45B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x12F45BC", Offset = "0x12F45BC", VA = "0x12F45BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x12F46D4", Offset = "0x12F46D4", VA = "0x12F46D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xFA73A4", Offset = "0xFA73A4", VA = "0xFA73A4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xFA74D0", Offset = "0xFA74D0", VA = "0xFA74D0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xFA7464", Offset = "0xFA7464", VA = "0xFA7464")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5CA45C", Offset = "0x5CA45C")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xFA7654", Offset = "0xFA7654", VA = "0xFA7654")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xFA7740", Offset = "0xFA7740", VA = "0xFA7740")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xFA7828", Offset = "0xFA7828", VA = "0xFA7828")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C3B78", Offset = "0x5C3B78")]
		public float weight;

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x10C22B4", Offset = "0x10C22B4", VA = "0x10C22B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x10C2328", Offset = "0x10C2328", VA = "0x10C2328")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x10C23E0", Offset = "0x10C23E0", VA = "0x10C23E0")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001A5")]
		public class Part
		{
			[Token(Token = "0x4000B23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000B24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x12F6EE8", Offset = "0x12F6EE8", VA = "0x12F6EE8")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x12F7014", Offset = "0x12F7014", VA = "0x12F7014")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xEAE800", Offset = "0xEAE800", VA = "0xEAE800")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xEAE87C", Offset = "0xEAE87C", VA = "0xEAE87C")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x12BFAA4", Offset = "0x12BFAA4", VA = "0x12BFAA4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x12BFBFC", Offset = "0x12BFBFC", VA = "0x12BFBFC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x12BFDE0", Offset = "0x12BFDE0", VA = "0x12BFDE0")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3B90", Offset = "0x5C3B90")]
		public VRIK ik;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C3BC8", Offset = "0x5C3BC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3BC8", Offset = "0x5C3BC8")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3C28", Offset = "0x5C3C28")]
		public Vector3 headAnchorPositionOffset;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3C60", Offset = "0x5C3C60")]
		public Vector3 headAnchorRotationOffset;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C3C98", Offset = "0x5C3C98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3C98", Offset = "0x5C3C98")]
		public Transform leftHandAnchor;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3CF8", Offset = "0x5C3CF8")]
		public Transform rightHandAnchor;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3D30", Offset = "0x5C3D30")]
		public Vector3 handAnchorPositionOffset;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3D68", Offset = "0x5C3D68")]
		public Vector3 handAnchorRotationOffset;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C3DA0", Offset = "0x5C3DA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3DA0", Offset = "0x5C3DA0")]
		public float scaleMlp;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C3E00", Offset = "0x5C3E00")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xEB1790", Offset = "0xEB1790", VA = "0xEB1790")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xEB2670", Offset = "0xEB2670", VA = "0xEB2670")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3E38", Offset = "0x5C3E38")]
		public VRIK ik;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3E70", Offset = "0x5C3E70")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3EA8", Offset = "0x5C3EA8")]
		public Transform headTracker;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3EE0", Offset = "0x5C3EE0")]
		public Transform bodyTracker;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3F18", Offset = "0x5C3F18")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3F50", Offset = "0x5C3F50")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3F88", Offset = "0x5C3F88")]
		public Transform leftFootTracker;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C3FC0", Offset = "0x5C3FC0")]
		public Transform rightFootTracker;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C3FF8", Offset = "0x5C3FF8")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xEB26DC", Offset = "0xEB26DC", VA = "0xEB26DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xEB3A74", Offset = "0xEB3A74", VA = "0xEB3A74")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xEB5930", Offset = "0xEB5930", VA = "0xEB5930")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xEB598C", Offset = "0xEB598C", VA = "0xEB598C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xEB5B14", Offset = "0xEB5B14", VA = "0xEB5B14")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xEB5B48", Offset = "0xEB5B48", VA = "0xEB5B48")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xEB5FCC", Offset = "0xEB5FCC", VA = "0xEB5FCC")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x17000096")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x1232170", Offset = "0x1232170", VA = "0x1232170", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x123214C", Offset = "0x123214C", VA = "0x123214C", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1232178", Offset = "0x1232178", VA = "0x1232178")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x12321DC", Offset = "0x12321DC", VA = "0x12321DC", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1232374", Offset = "0x1232374", VA = "0x1232374", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x1232598", Offset = "0x1232598", VA = "0x1232598", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x1232384", Offset = "0x1232384", VA = "0x1232384")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x12325A8", Offset = "0x12325A8", VA = "0x12325A8")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x12325C0", Offset = "0x12325C0", VA = "0x12325C0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x123261C", Offset = "0x123261C", VA = "0x123261C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x12326B8", Offset = "0x12326B8", VA = "0x12326B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x12327D0", Offset = "0x12327D0", VA = "0x12327D0")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C4060", Offset = "0x5C4060")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40007A8")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40007A9")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x17000097")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x1232884", Offset = "0x1232884", VA = "0x1232884", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x12327E8", Offset = "0x12327E8", VA = "0x12327E8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x1232868", Offset = "0x1232868", VA = "0x1232868", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x123297C", Offset = "0x123297C", VA = "0x123297C", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x1232D60", Offset = "0x1232D60", VA = "0x1232D60")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x1232E68", Offset = "0x1232E68", VA = "0x1232E68")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C40A4", Offset = "0x5C40A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C40A4", Offset = "0x5C40A4")]
		public Transform gravityTarget;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4104", Offset = "0x5C4104")]
		public float gravityMultiplier;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40007B7")]
		protected const float half = 0.5f;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x6000803")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x123323C", Offset = "0x123323C", VA = "0x123323C")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x123336C", Offset = "0x123336C", VA = "0x123336C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x1233524", Offset = "0x1233524", VA = "0x1233524", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x12336D4", Offset = "0x12336D4", VA = "0x12336D4")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1233738", Offset = "0x1233738", VA = "0x1233738")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x1233858", Offset = "0x1233858", VA = "0x1233858")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x123397C", Offset = "0x123397C", VA = "0x123397C")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x12339A0", Offset = "0x12339A0", VA = "0x12339A0")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x12339C4", Offset = "0x12339C4", VA = "0x12339C4")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x1233A24", Offset = "0x1233A24", VA = "0x1233A24")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x20001A6")]
		public enum MoveMode
		{
			[Token(Token = "0x4000B26")]
			Directional,
			[Token(Token = "0x4000B27")]
			Strafe
		}

		[Token(Token = "0x20001A7")]
		public struct AnimState
		{
			[Token(Token = "0x4000B28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000B29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000B2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000B2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000B2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000B2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x4000B2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x20001A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE7E8", Offset = "0x5BE7E8")]
		private sealed class <JumpSmooth>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x4000B32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x4000B33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x4000B34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x17000119")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A84")]
				[Address(RVA = "0x11225FC", Offset = "0x11225FC", VA = "0x11225FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A86")]
				[Address(RVA = "0x1122644", Offset = "0x1122644", VA = "0x1122644", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x11224D8", Offset = "0x11224D8", VA = "0x11224D8")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x1122504", Offset = "0x1122504", VA = "0x1122504", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x1122508", Offset = "0x1122508", VA = "0x1122508", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x1122604", Offset = "0x1122604", VA = "0x1122604", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C413C", Offset = "0x5C413C")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C4174", Offset = "0x5C4174")]
		public MoveMode moveMode;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C41AC", Offset = "0x5C41AC")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C41E4", Offset = "0x5C41E4")]
		public bool smoothJump;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C421C", Offset = "0x5C421C")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5C4254", Offset = "0x5C4254")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C428C", Offset = "0x5C428C")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x17000098")]
		public bool onGround
		{
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x1233D4C", Offset = "0x1233D4C", VA = "0x1233D4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA4BC", Offset = "0x5CA4BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600080F")]
			[Address(RVA = "0x1233D54", Offset = "0x1233D54", VA = "0x1233D54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA4CC", Offset = "0x5CA4CC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x1233D60", Offset = "0x1233D60", VA = "0x1233D60", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x1233EA0", Offset = "0x1233EA0", VA = "0x1233EA0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x1233F30", Offset = "0x1233F30", VA = "0x1233F30", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1233FF8", Offset = "0x1233FF8", VA = "0x1233FF8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1234BFC", Offset = "0x1234BFC", VA = "0x1234BFC", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1234E54", Offset = "0x1234E54", VA = "0x1234E54", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x12344F0", Offset = "0x12344F0", VA = "0x12344F0")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x1234F30", Offset = "0x1234F30", VA = "0x1234F30")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x12353D8", Offset = "0x12353D8", VA = "0x12353D8")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1234C84", Offset = "0x1234C84", VA = "0x1234C84")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x1235478", Offset = "0x1235478", VA = "0x1235478", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x12357B4", Offset = "0x12357B4", VA = "0x12357B4")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x12358A4", Offset = "0x12358A4", VA = "0x12358A4", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1235A04", Offset = "0x1235A04", VA = "0x1235A04")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5CA4DC", Offset = "0x5CA4DC")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1234854", Offset = "0x1234854", VA = "0x1234854")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x1235A94", Offset = "0x1235A94", VA = "0x1235A94")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001A9")]
		public enum RotationMode
		{
			[Token(Token = "0x4000B36")]
			Smooth,
			[Token(Token = "0x4000B37")]
			Linear
		}

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C429C", Offset = "0x5C429C")]
		public CameraController cameraController;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C42D4", Offset = "0x5C42D4")]
		public float accelerationTime;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C430C", Offset = "0x5C430C")]
		public float turnTime;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4344", Offset = "0x5C4344")]
		public bool walkByDefault;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C437C", Offset = "0x5C437C")]
		public RotationMode rotationMode;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C43B4", Offset = "0x5C43B4")]
		public float moveSpeed;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C43EC", Offset = "0x5C43EC")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x17000099")]
		public bool isGrounded
		{
			[Token(Token = "0x6000820")]
			[Address(RVA = "0xEAA0B8", Offset = "0xEAA0B8", VA = "0xEAA0B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA53C", Offset = "0x5CA53C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000821")]
			[Address(RVA = "0xEAA0C0", Offset = "0xEAA0C0", VA = "0xEAA0C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA54C", Offset = "0x5CA54C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xEAA0CC", Offset = "0xEAA0CC", VA = "0xEAA0CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xEAA15C", Offset = "0xEAA15C", VA = "0xEAA15C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xEAA61C", Offset = "0xEAA61C", VA = "0xEAA61C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xEAA1B0", Offset = "0xEAA1B0", VA = "0xEAA1B0")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xEAA430", Offset = "0xEAA430", VA = "0xEAA430")]
		private void Move()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xEAA658", Offset = "0xEAA658", VA = "0xEAA658")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xEAA6F4", Offset = "0xEAA6F4", VA = "0xEAA6F4")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xEAA778", Offset = "0xEAA778", VA = "0xEAA778")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xEAFC28", Offset = "0xEAFC28", VA = "0xEAFC28", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xEAFCA4", Offset = "0xEAFCA4", VA = "0xEAFCA4", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xEAFE68", Offset = "0xEAFE68", VA = "0xEAFE68")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xEAFE90", Offset = "0xEAFE90", VA = "0xEAFE90")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x20001AA")]
		public struct State
		{
			[Token(Token = "0x4000B38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000B39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000B3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000B3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000B3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xEAFC6C", Offset = "0xEAFC6C", VA = "0xEAFC6C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xEAFFAC", Offset = "0xEAFFAC", VA = "0xEAFFAC", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xEAFEAC", Offset = "0xEAFEAC", VA = "0xEAFEAC")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x10BCBEC", Offset = "0x10BCBEC", VA = "0x10BCBEC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x10BCC28", Offset = "0x10BCC28", VA = "0x10BCC28")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xEAABC8", Offset = "0xEAABC8", VA = "0xEAABC8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xEAABFC", Offset = "0xEAABFC", VA = "0xEAABFC")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xEAACAC", Offset = "0xEAACAC", VA = "0xEAACAC")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000120")]
	public class Navigator
	{
		[Token(Token = "0x20001AB")]
		public enum State
		{
			[Token(Token = "0x4000B3E")]
			Idle,
			[Token(Token = "0x4000B3F")]
			Seeking,
			[Token(Token = "0x4000B40")]
			OnPath
		}

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C43FC", Offset = "0x5C43FC")]
		public bool activeTargetSeeking;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4434", Offset = "0x5C4434")]
		public float cornerRadius;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C446C", Offset = "0x5C446C")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C44A4", Offset = "0x5C44A4")]
		public float maxSampleDistance;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C44DC", Offset = "0x5C44DC")]
		public float nextPathInterval;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4514", Offset = "0x5C4514")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4524", Offset = "0x5C4524")]
		private State <state>k__BackingField;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x1700009A")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x6000836")]
			[Address(RVA = "0xFA2938", Offset = "0xFA2938", VA = "0xFA2938")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA55C", Offset = "0x5CA55C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000837")]
			[Address(RVA = "0xFA2944", Offset = "0xFA2944", VA = "0xFA2944")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA56C", Offset = "0x5CA56C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public State state
		{
			[Token(Token = "0x6000838")]
			[Address(RVA = "0xFA2950", Offset = "0xFA2950", VA = "0xFA2950")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA57C", Offset = "0x5CA57C")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000839")]
			[Address(RVA = "0xFA2958", Offset = "0xFA2958", VA = "0xFA2958")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CA58C", Offset = "0x5CA58C")]
			private set
			{
			}
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xFA2960", Offset = "0xFA2960", VA = "0xFA2960")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xFA2A10", Offset = "0xFA2A10", VA = "0xFA2A10")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xFA2DFC", Offset = "0xFA2DFC", VA = "0xFA2DFC")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xFA2E78", Offset = "0xFA2E78", VA = "0xFA2E78")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xFA2DB8", Offset = "0xFA2DB8", VA = "0xFA2DB8")]
		private void Stop()
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xFA2DE8", Offset = "0xFA2DE8", VA = "0xFA2DE8")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xFA2FC4", Offset = "0xFA2FC4", VA = "0xFA2FC4")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xFA3174", Offset = "0xFA3174", VA = "0xFA3174")]
		public Navigator()
		{
		}
	}
}
