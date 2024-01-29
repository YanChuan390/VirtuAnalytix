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
using UnityEngine.Events;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Image _image;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2460D30", Offset = "0x2460D30", VA = "0x2460D30")]
	public void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2460EF0", Offset = "0x2460EF0", VA = "0x2460EF0", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x24611FC", Offset = "0x24611FC", VA = "0x24611FC")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000003")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2461204", Offset = "0x2461204", VA = "0x2461204")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x24612E0", Offset = "0x24612E0", VA = "0x24612E0")]
	public EventSystemChecker()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000004")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x20000CC")]
		public enum Mode
		{
			[Token(Token = "0x400059E")]
			Trigger,
			[Token(Token = "0x400059F")]
			Replace,
			[Token(Token = "0x40005A0")]
			Activate,
			[Token(Token = "0x40005A1")]
			Enable,
			[Token(Token = "0x40005A2")]
			Animate,
			[Token(Token = "0x40005A3")]
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

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x38C838C", Offset = "0x38C838C", VA = "0x38C838C")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x38C87F4", Offset = "0x38C87F4", VA = "0x38C87F4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x38C87F8", Offset = "0x38C87F8", VA = "0x38C87F8")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CD")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x38C9244", Offset = "0x38C9244", VA = "0x38C9244")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CE")]
		public class ReplacementList
		{
			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x38C924C", Offset = "0x38C924C", VA = "0x38C924C")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x38C8810", Offset = "0x38C8810", VA = "0x38C8810")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x38C923C", Offset = "0x38C923C", VA = "0x38C923C")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CF")]
		public class Vector3andSpace
		{
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x38C9568", Offset = "0x38C9568", VA = "0x38C9568")]
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

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform myTransform;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject myGameObject;

		[Token(Token = "0x17000001")]
		public new Transform transform
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x38C92B8", Offset = "0x38C92B8", VA = "0x38C92B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public new GameObject gameObject
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x38C935C", Offset = "0x38C935C", VA = "0x38C935C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x38C9400", Offset = "0x38C9400", VA = "0x38C9400")]
		private void Start()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x38C9428", Offset = "0x38C9428", VA = "0x38C9428")]
		private void Update()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x38C9560", Offset = "0x38C9560", VA = "0x38C9560")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class CameraRefocus
	{
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x38C9578", Offset = "0x38C9578", VA = "0x38C9578")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x38C95EC", Offset = "0x38C95EC", VA = "0x38C95EC")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x38C95F4", Offset = "0x38C95F4", VA = "0x38C95F4")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x38C95FC", Offset = "0x38C95FC", VA = "0x38C95FC")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x38C975C", Offset = "0x38C975C", VA = "0x38C975C")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	public class CurveControlledBob
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x38C97B0", Offset = "0x38C97B0", VA = "0x38C97B0")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x38C9854", Offset = "0x38C9854", VA = "0x38C9854")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x38C9974", Offset = "0x38C9974", VA = "0x38C9974")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD090", Offset = "0x13AD090")]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x17000075")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0x38CA300", Offset = "0x38CA300", VA = "0x38CA300", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000076")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005FE")]
				[Address(RVA = "0x38CA368", Offset = "0x38CA368", VA = "0x38CA368", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x38CA070", Offset = "0x38CA070", VA = "0x38CA070")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x38CA0A4", Offset = "0x38CA0A4", VA = "0x38CA0A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x38CA0A8", Offset = "0x38CA0A8", VA = "0x38CA0A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x38CA308", Offset = "0x38CA308", VA = "0x38CA308", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400001C")]
		private const float k_Spring = 50f;

		[Token(Token = "0x400001D")]
		private const float k_Damper = 5f;

		[Token(Token = "0x400001E")]
		private const float k_Drag = 10f;

		[Token(Token = "0x400001F")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x4000020")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x4000021")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x38C9BC0", Offset = "0x38C9BC0", VA = "0x38C9BC0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x38C9FE4", Offset = "0x38C9FE4", VA = "0x38C9FE4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B51C8", Offset = "0x13B51C8")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x38C9F34", Offset = "0x38C9F34", VA = "0x38C9F34")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x38CA09C", Offset = "0x38CA09C", VA = "0x38CA09C")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x38CA370", Offset = "0x38CA370", VA = "0x38CA370")]
		private void Start()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x38CA3A4", Offset = "0x38CA3A4", VA = "0x38CA3A4")]
		private void Update()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x38CA618", Offset = "0x38CA618", VA = "0x38CA618")]
		public DynamicShadowSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public class FOVKick
	{
		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD0A0", Offset = "0x13AD0A0")]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000077")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000602")]
				[Address(RVA = "0x38CAC50", Offset = "0x38CAC50", VA = "0x38CAC50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000078")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000604")]
				[Address(RVA = "0x38CACB8", Offset = "0x38CACB8", VA = "0x38CACB8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x38CA7FC", Offset = "0x38CA7FC", VA = "0x38CA7FC")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x38CAAE0", Offset = "0x38CAAE0", VA = "0x38CAAE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x38CAAE4", Offset = "0x38CAAE4", VA = "0x38CAAE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x38CAC58", Offset = "0x38CAC58", VA = "0x38CAC58", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD0B0", Offset = "0x13AD0B0")]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000079")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000608")]
				[Address(RVA = "0x38CAA70", Offset = "0x38CAA70", VA = "0x38CAA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600060A")]
				[Address(RVA = "0x38CAAD8", Offset = "0x38CAAD8", VA = "0x38CAAD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x38CA8A4", Offset = "0x38CA8A4", VA = "0x38CA8A4")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x38CA8EC", Offset = "0x38CA8EC", VA = "0x38CA8EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x38CA8F0", Offset = "0x38CA8F0", VA = "0x38CA8F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x38CAA78", Offset = "0x38CAA78", VA = "0x38CAA78", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x38CA64C", Offset = "0x38CA64C", VA = "0x38CA64C")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x38CA698", Offset = "0x38CA698", VA = "0x38CA698")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x38CA778", Offset = "0x38CA778", VA = "0x38CA778")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x38CA780", Offset = "0x38CA780", VA = "0x38CA780")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B522C", Offset = "0x13B522C")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x38CA828", Offset = "0x38CA828", VA = "0x38CA828")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B5290", Offset = "0x13B5290")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x38CA8D0", Offset = "0x38CA8D0", VA = "0x38CA8D0")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x38CACC0", Offset = "0x38CACC0", VA = "0x38CACC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x38CADA0", Offset = "0x38CADA0", VA = "0x38CADA0")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public class LerpControlledBob
	{
		[Token(Token = "0x20000D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD0C0", Offset = "0x13AD0C0")]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x1700007B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600060E")]
				[Address(RVA = "0x38CB0B4", Offset = "0x38CB0B4", VA = "0x38CB0B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000610")]
				[Address(RVA = "0x38CB11C", Offset = "0x38CB11C", VA = "0x38CB11C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x38CAE84", Offset = "0x38CAE84", VA = "0x38CAE84")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x38CAEB8", Offset = "0x38CAEB8", VA = "0x38CAEB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x38CAEBC", Offset = "0x38CAEBC", VA = "0x38CAEBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x38CB0BC", Offset = "0x38CB0BC", VA = "0x38CB0BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x38CAE00", Offset = "0x38CAE00", VA = "0x38CAE00")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x38CAE08", Offset = "0x38CAE08", VA = "0x38CAE08")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B52F4", Offset = "0x13B52F4")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x38CAEB0", Offset = "0x38CAEB0", VA = "0x38CAEB0")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD0D0", Offset = "0x13AD0D0")]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x1700007D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000614")]
				[Address(RVA = "0x38CB550", Offset = "0x38CB550", VA = "0x38CB550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000616")]
				[Address(RVA = "0x38CB5B8", Offset = "0x38CB5B8", VA = "0x38CB5B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x38CB2DC", Offset = "0x38CB2DC", VA = "0x38CB2DC")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x38CB310", Offset = "0x38CB310", VA = "0x38CB310", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x38CB314", Offset = "0x38CB314", VA = "0x38CB314", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x38CB558", Offset = "0x38CB558", VA = "0x38CB558", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x38CB124", Offset = "0x38CB124", VA = "0x38CB124")]
		private void Start()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x38CB224", Offset = "0x38CB224", VA = "0x38CB224")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x38CB250", Offset = "0x38CB250", VA = "0x38CB250")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B5358", Offset = "0x13B5358")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x38CB308", Offset = "0x38CB308", VA = "0x38CB308")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x20000D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD0E0", Offset = "0x13AD0E0")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x1700007F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600061A")]
				[Address(RVA = "0x38CB9E8", Offset = "0x38CB9E8", VA = "0x38CB9E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000080")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600061C")]
				[Address(RVA = "0x38CBA50", Offset = "0x38CBA50", VA = "0x38CBA50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x38CB63C", Offset = "0x38CB63C", VA = "0x38CB63C")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0x38CB688", Offset = "0x38CB688", VA = "0x38CB688", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0x38CB68C", Offset = "0x38CB68C", VA = "0x38CB68C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x38CB9F0", Offset = "0x38CB9F0", VA = "0x38CB9F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x38CB5C0", Offset = "0x38CB5C0", VA = "0x38CB5C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B53BC", Offset = "0x13B53BC")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x38CB668", Offset = "0x38CB668", VA = "0x38CB668")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x38CB674", Offset = "0x38CB674", VA = "0x38CB674")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x20000D6")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x40005C6")]
			Standalone,
			[Token(Token = "0x40005C7")]
			Mobile
		}

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x38CBA58", Offset = "0x38CBA58", VA = "0x38CBA58")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x38CBA5C", Offset = "0x38CBA5C", VA = "0x38CBA5C")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x38CBA78", Offset = "0x38CBA78", VA = "0x38CBA78")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x38CBDD4", Offset = "0x38CBDD4", VA = "0x38CBDD4")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x38CBE64", Offset = "0x38CBE64", VA = "0x38CBE64")]
		public SimpleActivatorMenu()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x38CBE6C", Offset = "0x38CBE6C", VA = "0x38CBE6C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x38CBE70", Offset = "0x38CBE70", VA = "0x38CBE70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x38CC19C", Offset = "0x38CC19C", VA = "0x38CC19C")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x20000D7")]
		public enum Action
		{
			[Token(Token = "0x40005C9")]
			Activate,
			[Token(Token = "0x40005CA")]
			Deactivate,
			[Token(Token = "0x40005CB")]
			Destroy,
			[Token(Token = "0x40005CC")]
			ReloadLevel,
			[Token(Token = "0x40005CD")]
			Call
		}

		[Serializable]
		[Token(Token = "0x20000D8")]
		public class Entry
		{
			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x38CC958", Offset = "0x38CC958", VA = "0x38CC958")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D9")]
		public class Entries
		{
			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x600061E")]
			[Address(RVA = "0x38CC548", Offset = "0x38CC548", VA = "0x38CC548")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD0F0", Offset = "0x13AD0F0")]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000081")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000622")]
				[Address(RVA = "0x38CC628", Offset = "0x38CC628", VA = "0x38CC628", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000082")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000624")]
				[Address(RVA = "0x38CC690", Offset = "0x38CC690", VA = "0x38CC690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x38CC450", Offset = "0x38CC450", VA = "0x38CC450")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0x38CC550", Offset = "0x38CC550", VA = "0x38CC550", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000621")]
			[Address(RVA = "0x38CC554", Offset = "0x38CC554", VA = "0x38CC554", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x38CC630", Offset = "0x38CC630", VA = "0x38CC630", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD100", Offset = "0x13AD100")]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000083")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000628")]
				[Address(RVA = "0x38CC770", Offset = "0x38CC770", VA = "0x38CC770", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000084")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600062A")]
				[Address(RVA = "0x38CC7D8", Offset = "0x38CC7D8", VA = "0x38CC7D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000625")]
			[Address(RVA = "0x38CC47C", Offset = "0x38CC47C", VA = "0x38CC47C")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000626")]
			[Address(RVA = "0x38CC698", Offset = "0x38CC698", VA = "0x38CC698", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x38CC69C", Offset = "0x38CC69C", VA = "0x38CC69C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x38CC778", Offset = "0x38CC778", VA = "0x38CC778", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD110", Offset = "0x13AD110")]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000085")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600062E")]
				[Address(RVA = "0x38CC8E8", Offset = "0x38CC8E8", VA = "0x38CC8E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000086")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000630")]
				[Address(RVA = "0x38CC950", Offset = "0x38CC950", VA = "0x38CC950", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x38CC4A8", Offset = "0x38CC4A8", VA = "0x38CC4A8")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x38CC7E0", Offset = "0x38CC7E0", VA = "0x38CC7E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x38CC7E4", Offset = "0x38CC7E4", VA = "0x38CC7E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x38CC8F0", Offset = "0x38CC8F0", VA = "0x38CC8F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x38CC1B0", Offset = "0x38CC1B0", VA = "0x38CC1B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x38CC2DC", Offset = "0x38CC2DC", VA = "0x38CC2DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B5420", Offset = "0x13B5420")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x38CC358", Offset = "0x38CC358", VA = "0x38CC358")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B5484", Offset = "0x13B5484")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x38CC3D4", Offset = "0x38CC3D4", VA = "0x38CC3D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B54E8", Offset = "0x13B54E8")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x38CC4D4", Offset = "0x38CC4D4", VA = "0x38CC4D4")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x38CC960", Offset = "0x38CC960", VA = "0x38CC960")]
		private void Awake()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x38CC9B8", Offset = "0x38CC9B8", VA = "0x38CC9B8")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x38CCA58", Offset = "0x38CCA58", VA = "0x38CCA58")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000DD")]
		public class WaypointList
		{
			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x38CD8D4", Offset = "0x38CD8D4", VA = "0x38CD8D4")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x20000DE")]
		public struct RoutePoint
		{
			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x38CD24C", Offset = "0x38CD24C", VA = "0x38CD24C")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD2A0", Offset = "0x13AD2A0")]
		private float <Length>k__BackingField;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000003")]
		public float Length
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x38CCA68", Offset = "0x38CCA68", VA = "0x38CCA68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B554C", Offset = "0x13B554C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x38CCA70", Offset = "0x38CCA70", VA = "0x38CCA70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B555C", Offset = "0x13B555C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x38CCA78", Offset = "0x38CCA78", VA = "0x38CCA78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x38CCA94", Offset = "0x38CCA94", VA = "0x38CCA94")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x38CCDE4", Offset = "0x38CCDE4", VA = "0x38CCDE4")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x38CCEF4", Offset = "0x38CCEF4", VA = "0x38CCEF4")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x38CD25C", Offset = "0x38CD25C", VA = "0x38CD25C")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x38CCAF0", Offset = "0x38CCAF0", VA = "0x38CCAF0")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x38CD5C4", Offset = "0x38CD5C4", VA = "0x38CD5C4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x38CD84C", Offset = "0x38CD84C", VA = "0x38CD84C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x38CD5CC", Offset = "0x38CD5CC", VA = "0x38CD5CC")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x38CD854", Offset = "0x38CD854", VA = "0x38CD854")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x20000DF")]
		public enum ProgressStyle
		{
			[Token(Token = "0x40005E0")]
			SmoothAlongRoute,
			[Token(Token = "0x40005E1")]
			PointToPoint
		}

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD320", Offset = "0x13AD320")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD330", Offset = "0x13AD330")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD340", Offset = "0x13AD340")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000005")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x38CD940", Offset = "0x38CD940", VA = "0x38CD940")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B556C", Offset = "0x13B556C")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x38CD954", Offset = "0x38CD954", VA = "0x38CD954")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B557C", Offset = "0x13B557C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x38CD968", Offset = "0x38CD968", VA = "0x38CD968")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B558C", Offset = "0x13B558C")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x38CD97C", Offset = "0x38CD97C", VA = "0x38CD97C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B559C", Offset = "0x13B559C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x38CD990", Offset = "0x38CD990", VA = "0x38CD990")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B55AC", Offset = "0x13B55AC")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x38CD9A4", Offset = "0x38CD9A4", VA = "0x38CD9A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B55BC", Offset = "0x13B55BC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x38CD9B8", Offset = "0x38CD9B8", VA = "0x38CD9B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x38CDAAC", Offset = "0x38CDAAC", VA = "0x38CDAAC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x38CDB84", Offset = "0x38CDB84", VA = "0x38CDB84")]
		private void Update()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x38CE0EC", Offset = "0x38CE0EC", VA = "0x38CE0EC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x38CE2C4", Offset = "0x38CE2C4", VA = "0x38CE2C4")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AC15C", Offset = "0x13AC15C")]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x292C110", Offset = "0x292C110", VA = "0x292C110")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x292C1AC", Offset = "0x292C1AC", VA = "0x292C1AC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x292C66C", Offset = "0x292C66C", VA = "0x292C66C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x292CBB4", Offset = "0x292CBB4", VA = "0x292CBB4")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD120", Offset = "0x13AD120")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x17000087")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000636")]
				[Address(RVA = "0x38C7314", Offset = "0x38C7314", VA = "0x38C7314", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000088")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000638")]
				[Address(RVA = "0x38C737C", Offset = "0x38C737C", VA = "0x38C737C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x38C6B60", Offset = "0x38C6B60", VA = "0x38C6B60")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x38C6D18", Offset = "0x38C6D18", VA = "0x38C6D18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x38C6D1C", Offset = "0x38C6D1C", VA = "0x38C6D1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x38C731C", Offset = "0x38C731C", VA = "0x38C731C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x38C6AE4", Offset = "0x38C6AE4", VA = "0x38C6AE4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B55CC", Offset = "0x13B55CC")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x38C6B8C", Offset = "0x38C6B8C", VA = "0x38C6B8C")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x38C6D10", Offset = "0x38C6D10", VA = "0x38C6D10")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD130", Offset = "0x13AD130")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x17000089")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600063C")]
				[Address(RVA = "0x38C7758", Offset = "0x38C7758", VA = "0x38C7758", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600063E")]
				[Address(RVA = "0x38C77C0", Offset = "0x38C77C0", VA = "0x38C77C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x38C7400", Offset = "0x38C7400", VA = "0x38C7400")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x38C743C", Offset = "0x38C743C", VA = "0x38C743C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x38C7440", Offset = "0x38C7440", VA = "0x38C7440", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x38C7760", Offset = "0x38C7760", VA = "0x38C7760", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x38C7384", Offset = "0x38C7384", VA = "0x38C7384")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B5630", Offset = "0x13B5630")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x38C742C", Offset = "0x38C742C", VA = "0x38C742C")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x38C77C8", Offset = "0x38C77C8", VA = "0x38C77C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x38C7828", Offset = "0x38C7828", VA = "0x38C7828")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x38C78B4", Offset = "0x38C78B4", VA = "0x38C78B4")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x38C78C4", Offset = "0x38C78C4", VA = "0x38C78C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x38C793C", Offset = "0x38C793C", VA = "0x38C793C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x38C7B9C", Offset = "0x38C7B9C", VA = "0x38C7B9C")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x38C7BC4", Offset = "0x38C7BC4", VA = "0x38C7BC4")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x38C7BD4", Offset = "0x38C7BD4", VA = "0x38C7BD4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x38C7D98", Offset = "0x38C7D98", VA = "0x38C7D98")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x38C7DB4", Offset = "0x38C7DB4", VA = "0x38C7DB4")]
		private void Start()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x38C7F40", Offset = "0x38C7F40", VA = "0x38C7F40")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x38C7F50", Offset = "0x38C7F50", VA = "0x38C7F50")]
		private void Start()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x38C8010", Offset = "0x38C8010", VA = "0x38C8010")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x38C8018", Offset = "0x38C8018", VA = "0x38C8018")]
		private void Start()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x38C8078", Offset = "0x38C8078", VA = "0x38C8078")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x38C8308", Offset = "0x38C8308", VA = "0x38C8308")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000020")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E2")]
		public enum UpdateMode
		{
			[Token(Token = "0x40005EA")]
			Update,
			[Token(Token = "0x40005EB")]
			FixedUpdate,
			[Token(Token = "0x40005EC")]
			LateUpdate,
			[Token(Token = "0x40005ED")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13AD350", Offset = "0x13AD350")]
		public bool smoothFollow;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13AD388", Offset = "0x13AD388")]
		public float rotationSensitivity;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13AD3C0", Offset = "0x13AD3C0")]
		public float distance;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13AD3F8", Offset = "0x13AD3F8")]
		public LayerMask blockingLayers;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AD430", Offset = "0x13AD430")]
		public float blockedOffset;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD448", Offset = "0x13AD448")]
		private float <x>k__BackingField;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD458", Offset = "0x13AD458")]
		private float <y>k__BackingField;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD468", Offset = "0x13AD468")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000008")]
		public float x
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x2468C68", Offset = "0x2468C68", VA = "0x2468C68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5694", Offset = "0x13B5694")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x2468C70", Offset = "0x2468C70", VA = "0x2468C70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B56A4", Offset = "0x13B56A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public float y
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x2468C78", Offset = "0x2468C78", VA = "0x2468C78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B56B4", Offset = "0x13B56B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x2468C80", Offset = "0x2468C80", VA = "0x2468C80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B56C4", Offset = "0x13B56C4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public float distanceTarget
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x2468C88", Offset = "0x2468C88", VA = "0x2468C88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B56D4", Offset = "0x13B56D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x2468C90", Offset = "0x2468C90", VA = "0x2468C90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B56E4", Offset = "0x13B56E4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		private float zoomAdd
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x2469704", Offset = "0x2469704", VA = "0x2469704")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2468C98", Offset = "0x2468C98", VA = "0x2468C98", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2468DC0", Offset = "0x2468DC0", VA = "0x2468DC0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2468E1C", Offset = "0x2468E1C", VA = "0x2468E1C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2468E84", Offset = "0x2468E84", VA = "0x2468E84", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2468EE8", Offset = "0x2468EE8", VA = "0x2468EE8")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2468DF4", Offset = "0x2468DF4", VA = "0x2468DF4")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2469068", Offset = "0x2469068", VA = "0x2469068")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2469654", Offset = "0x2469654", VA = "0x2469654")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2469778", Offset = "0x2469778", VA = "0x2469778")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2469888", Offset = "0x2469888", VA = "0x2469888")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x24698C0", Offset = "0x24698C0", VA = "0x24698C0")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2469A78", Offset = "0x2469A78", VA = "0x2469A78")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2469B28", Offset = "0x2469B28", VA = "0x2469B28")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000022")]
	public enum Axis
	{
		[Token(Token = "0x40000B3")]
		X,
		[Token(Token = "0x40000B4")]
		Y,
		[Token(Token = "0x40000B5")]
		Z
	}
	[Token(Token = "0x2000023")]
	public class AxisTools
	{
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x24612E8", Offset = "0x24612E8", VA = "0x24612E8")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x24613A0", Offset = "0x24613A0", VA = "0x24613A0")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x246144C", Offset = "0x246144C", VA = "0x246144C")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2461630", Offset = "0x2461630", VA = "0x2461630")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2461568", Offset = "0x2461568", VA = "0x2461568")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x246174C", Offset = "0x246174C", VA = "0x246174C")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2461978", Offset = "0x2461978", VA = "0x2461978")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000024")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x20000E3")]
		public class LimbOrientation
		{
			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x600063F")]
			[Address(RVA = "0x2461C78", Offset = "0x2461C78", VA = "0x2461C78")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x1700000C")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x2461A00", Offset = "0x2461A00", VA = "0x2461A00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x2461CF0", Offset = "0x2461CF0", VA = "0x2461CF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2461980", Offset = "0x2461980", VA = "0x2461980")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000025")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x20000E4")]
		public enum BoneType
		{
			[Token(Token = "0x40005F2")]
			Unassigned,
			[Token(Token = "0x40005F3")]
			Spine,
			[Token(Token = "0x40005F4")]
			Head,
			[Token(Token = "0x40005F5")]
			Arm,
			[Token(Token = "0x40005F6")]
			Leg,
			[Token(Token = "0x40005F7")]
			Tail,
			[Token(Token = "0x40005F8")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x20000E5")]
		public enum BoneSide
		{
			[Token(Token = "0x40005FA")]
			Center,
			[Token(Token = "0x40005FB")]
			Left,
			[Token(Token = "0x40005FC")]
			Right
		}

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2461F68", Offset = "0x2461F68", VA = "0x2461F68")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2462270", Offset = "0x2462270", VA = "0x2462270")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x24624C8", Offset = "0x24624C8", VA = "0x24624C8")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x246254C", Offset = "0x246254C", VA = "0x246254C")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x24625F8", Offset = "0x24625F8", VA = "0x24625F8")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2462120", Offset = "0x2462120", VA = "0x2462120")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2462428", Offset = "0x2462428", VA = "0x2462428")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2462E38", Offset = "0x2462E38", VA = "0x2462E38")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2462C50", Offset = "0x2462C50", VA = "0x2462C50")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2462D44", Offset = "0x2462D44", VA = "0x2462D44")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2462818", Offset = "0x2462818", VA = "0x2462818")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x24628CC", Offset = "0x24628CC", VA = "0x24628CC")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2462980", Offset = "0x2462980", VA = "0x2462980")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2462A34", Offset = "0x2462A34", VA = "0x2462A34")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2462AE8", Offset = "0x2462AE8", VA = "0x2462AE8")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2462B9C", Offset = "0x2462B9C", VA = "0x2462B9C")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x246304C", Offset = "0x246304C", VA = "0x246304C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x246272C", Offset = "0x246272C", VA = "0x246272C")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2462FBC", Offset = "0x2462FBC", VA = "0x2462FBC")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x24630BC", Offset = "0x24630BC", VA = "0x24630BC")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2463194", Offset = "0x2463194", VA = "0x2463194")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2462F40", Offset = "0x2462F40", VA = "0x2462F40")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2462EC8", Offset = "0x2462EC8", VA = "0x2462EC8")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000026")]
	public class BipedReferences
	{
		[Token(Token = "0x20000E6")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700008B")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000641")]
				[Address(RVA = "0x2468C60", Offset = "0x2468C60", VA = "0x2468C60")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x2468C4C", Offset = "0x2468C4C", VA = "0x2468C4C")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700000E")]
		public virtual bool isFilled
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x246552C", Offset = "0x246552C", VA = "0x246552C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		public bool isEmpty
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x2465918", Offset = "0x2465918", VA = "0x2465918")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2465928", Offset = "0x2465928", VA = "0x2465928", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2465D54", Offset = "0x2465D54", VA = "0x2465D54", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x246618C", Offset = "0x246618C", VA = "0x246618C")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2466898", Offset = "0x2466898", VA = "0x2466898")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2466408", Offset = "0x2466408", VA = "0x2466408")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x24670CC", Offset = "0x24670CC", VA = "0x24670CC")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x24671CC", Offset = "0x24671CC", VA = "0x24671CC")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2467780", Offset = "0x2467780", VA = "0x2467780")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2467570", Offset = "0x2467570", VA = "0x2467570")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x24673E8", Offset = "0x24673E8", VA = "0x24673E8")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x246726C", Offset = "0x246726C", VA = "0x246726C")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2467674", Offset = "0x2467674", VA = "0x2467674")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x246787C", Offset = "0x246787C", VA = "0x246787C")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x24683E0", Offset = "0x24683E0", VA = "0x24683E0")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2467EAC", Offset = "0x2467EAC", VA = "0x2467EAC")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2468728", Offset = "0x2468728", VA = "0x2468728")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x24681F8", Offset = "0x24681F8", VA = "0x24681F8")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2468730", Offset = "0x2468730", VA = "0x2468730")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2468738", Offset = "0x2468738", VA = "0x2468738")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2468904", Offset = "0x2468904", VA = "0x2468904")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2468B28", Offset = "0x2468B28", VA = "0x2468B28")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2466380", Offset = "0x2466380", VA = "0x2466380")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2469B44", Offset = "0x2469B44", VA = "0x2469B44")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2469B4C", Offset = "0x2469B4C", VA = "0x2469B4C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2469C8C", Offset = "0x2469C8C", VA = "0x2469C8C")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class Hierarchy
	{
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x292787C", Offset = "0x292787C", VA = "0x292787C")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2927A7C", Offset = "0x2927A7C", VA = "0x2927A7C")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2927914", Offset = "0x2927914", VA = "0x2927914")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2927BA0", Offset = "0x2927BA0", VA = "0x2927BA0")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2927CC4", Offset = "0x2927CC4", VA = "0x2927CC4")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2927F74", Offset = "0x2927F74", VA = "0x2927F74")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2928090", Offset = "0x2928090", VA = "0x2928090")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2928218", Offset = "0x2928218", VA = "0x2928218")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x29285AC", Offset = "0x29285AC", VA = "0x29285AC")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2928398", Offset = "0x2928398", VA = "0x2928398")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x292874C", Offset = "0x292874C", VA = "0x292874C")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2928754", Offset = "0x2928754", VA = "0x2928754")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x29287E4", Offset = "0x29287E4", VA = "0x29287E4")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000E3")]
		None,
		[Token(Token = "0x40000E4")]
		InOutCubic,
		[Token(Token = "0x40000E5")]
		InOutQuintic,
		[Token(Token = "0x40000E6")]
		InOutSine,
		[Token(Token = "0x40000E7")]
		InQuintic,
		[Token(Token = "0x40000E8")]
		InQuartic,
		[Token(Token = "0x40000E9")]
		InCubic,
		[Token(Token = "0x40000EA")]
		InQuadratic,
		[Token(Token = "0x40000EB")]
		InElastic,
		[Token(Token = "0x40000EC")]
		InElasticSmall,
		[Token(Token = "0x40000ED")]
		InElasticBig,
		[Token(Token = "0x40000EE")]
		InSine,
		[Token(Token = "0x40000EF")]
		InBack,
		[Token(Token = "0x40000F0")]
		OutQuintic,
		[Token(Token = "0x40000F1")]
		OutQuartic,
		[Token(Token = "0x40000F2")]
		OutCubic,
		[Token(Token = "0x40000F3")]
		OutInCubic,
		[Token(Token = "0x40000F4")]
		OutInQuartic,
		[Token(Token = "0x40000F5")]
		OutElastic,
		[Token(Token = "0x40000F6")]
		OutElasticSmall,
		[Token(Token = "0x40000F7")]
		OutElasticBig,
		[Token(Token = "0x40000F8")]
		OutSine,
		[Token(Token = "0x40000F9")]
		OutBack,
		[Token(Token = "0x40000FA")]
		OutBackCubic,
		[Token(Token = "0x40000FB")]
		OutBackQuartic,
		[Token(Token = "0x40000FC")]
		BackInCubic,
		[Token(Token = "0x40000FD")]
		BackInQuartic
	}
	[Token(Token = "0x200002C")]
	public class Interp
	{
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2928878", Offset = "0x2928878", VA = "0x2928878")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x29292E0", Offset = "0x29292E0", VA = "0x29292E0")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x29293E8", Offset = "0x29293E8", VA = "0x29293E8")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2928BE4", Offset = "0x2928BE4", VA = "0x2928BE4")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2928BF0", Offset = "0x2928BF0", VA = "0x2928BF0")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2928C14", Offset = "0x2928C14", VA = "0x2928C14")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2928C50", Offset = "0x2928C50", VA = "0x2928C50")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2928C68", Offset = "0x2928C68", VA = "0x2928C68")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2928C7C", Offset = "0x2928C7C", VA = "0x2928C7C")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2928C90", Offset = "0x2928C90", VA = "0x2928C90")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2928CA0", Offset = "0x2928CA0", VA = "0x2928CA0")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2928CE8", Offset = "0x2928CE8", VA = "0x2928CE8")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2928D20", Offset = "0x2928D20", VA = "0x2928D20")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2928D48", Offset = "0x2928D48", VA = "0x2928D48")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x29294E4", Offset = "0x29294E4", VA = "0x29294E4")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2928D7C", Offset = "0x2928D7C", VA = "0x2928D7C")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2928DA4", Offset = "0x2928DA4", VA = "0x2928DA4")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2928DD4", Offset = "0x2928DD4", VA = "0x2928DD4")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2928E08", Offset = "0x2928E08", VA = "0x2928E08")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2928E4C", Offset = "0x2928E4C", VA = "0x2928E4C")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2928EB0", Offset = "0x2928EB0", VA = "0x2928EB0")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2928F14", Offset = "0x2928F14", VA = "0x2928F14")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2928F68", Offset = "0x2928F68", VA = "0x2928F68")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2928FBC", Offset = "0x2928FBC", VA = "0x2928FBC")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2929054", Offset = "0x2929054", VA = "0x2929054")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x29290E8", Offset = "0x29290E8", VA = "0x29290E8")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2929518", Offset = "0x2929518", VA = "0x2929518")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x292918C", Offset = "0x292918C", VA = "0x292918C")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2929270", Offset = "0x2929270", VA = "0x2929270")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x29292A0", Offset = "0x29292A0", VA = "0x29292A0")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2929600", Offset = "0x2929600", VA = "0x2929600")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2929608", Offset = "0x2929608", VA = "0x2929608")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2929698", Offset = "0x2929698", VA = "0x2929698")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200002E")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x292972C", Offset = "0x292972C", VA = "0x292972C")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2929784", Offset = "0x2929784", VA = "0x2929784")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2929850", Offset = "0x2929850", VA = "0x2929850")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x292979C", Offset = "0x292979C", VA = "0x292979C")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2929868", Offset = "0x2929868", VA = "0x2929868")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x292990C", Offset = "0x292990C", VA = "0x292990C")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2929938", Offset = "0x2929938", VA = "0x2929938")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2929988", Offset = "0x2929988", VA = "0x2929988")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x29299F4", Offset = "0x29299F4", VA = "0x29299F4")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2929AE8", Offset = "0x2929AE8", VA = "0x2929AE8")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2929BC0", Offset = "0x2929BC0", VA = "0x2929BC0")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2929C20", Offset = "0x2929C20", VA = "0x2929C20")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200002F")]
	public static class QuaTools
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2929C50", Offset = "0x2929C50", VA = "0x2929C50")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2929D9C", Offset = "0x2929D9C", VA = "0x2929D9C")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2929EE8", Offset = "0x2929EE8", VA = "0x2929EE8")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2929FFC", Offset = "0x2929FFC", VA = "0x2929FFC")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2916A24", Offset = "0x2916A24", VA = "0x2916A24")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x292A110", Offset = "0x292A110", VA = "0x292A110")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x291C5C0", Offset = "0x291C5C0", VA = "0x291C5C0")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x292A1E0", Offset = "0x292A1E0", VA = "0x292A1E0")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x292A464", Offset = "0x292A464", VA = "0x292A464")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x292A678", Offset = "0x292A678", VA = "0x292A678")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2925520", Offset = "0x2925520", VA = "0x2925520")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000030")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000010")]
		public static T instance
		{
			[Token(Token = "0x6000107")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000108")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000109")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AD488", Offset = "0x13AD488")]
		public bool fixTransforms;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000011")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x292A930", Offset = "0x292A930", VA = "0x292A930")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000012")]
		private bool isAnimated
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x292AC64", Offset = "0x292AC64", VA = "0x292AC64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x292A7F8", Offset = "0x292A7F8", VA = "0x292A7F8")]
		public void Disable()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x292A890", Offset = "0x292A890", VA = "0x292A890", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x292A894", Offset = "0x292A894", VA = "0x292A894", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x292A898", Offset = "0x292A898", VA = "0x292A898", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x292A89C", Offset = "0x292A89C", VA = "0x292A89C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x292A92C", Offset = "0x292A92C", VA = "0x292A92C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x292A8D4", Offset = "0x292A8D4", VA = "0x292A8D4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x292AC18", Offset = "0x292AC18", VA = "0x292AC18")]
		private void Update()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x292AA20", Offset = "0x292AA20", VA = "0x292AA20")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x292AD20", Offset = "0x292AD20", VA = "0x292AD20")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x292AD7C", Offset = "0x292AD7C", VA = "0x292AD7C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x292ADD8", Offset = "0x292ADD8", VA = "0x292ADD8")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x291AAB0", Offset = "0x291AAB0", VA = "0x291AAB0")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x292AE20", Offset = "0x292AE20", VA = "0x292AE20")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x292AED8", Offset = "0x292AED8", VA = "0x292AED8")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x292AF90", Offset = "0x292AF90", VA = "0x292AF90")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x292B048", Offset = "0x292B048", VA = "0x292B048")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public static class V3Tools
	{
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x292B050", Offset = "0x292B050", VA = "0x292B050")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x292B148", Offset = "0x292B148", VA = "0x292B148")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x292B240", Offset = "0x292B240", VA = "0x292B240")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x292B338", Offset = "0x292B338", VA = "0x292B338")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x292B438", Offset = "0x292B438", VA = "0x292B438")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x292B674", Offset = "0x292B674", VA = "0x292B674")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x292B8C4", Offset = "0x292B8C4", VA = "0x292B8C4")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x292BAC4", Offset = "0x292BAC4", VA = "0x292BAC4")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000034")]
	public static class Warning
	{
		[Token(Token = "0x20000E7")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x292BCA0", Offset = "0x292BCA0", VA = "0x292BCA0")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2913CC4", Offset = "0x2913CC4", VA = "0x2913CC4")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000035")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2469CC0", Offset = "0x2469CC0", VA = "0x2469CC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2469D44", Offset = "0x2469D44", VA = "0x2469D44")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AD4C0", Offset = "0x13AD4C0")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2469D4C", Offset = "0x2469D4C", VA = "0x2469D4C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2469E54", Offset = "0x2469E54", VA = "0x2469E54")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AD4F8", Offset = "0x13AD4F8")]
		public AimPoser aimPoser;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AD530", Offset = "0x13AD530")]
		public AimIK aim;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AD568", Offset = "0x13AD568")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AD5A0", Offset = "0x13AD5A0")]
		public Animator animator;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AD5D8", Offset = "0x13AD5D8")]
		public float crossfadeTime;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AD610", Offset = "0x13AD610")]
		public float minAimDistance;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x247C174", Offset = "0x247C174", VA = "0x247C174")]
		private void Start()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x247C1B8", Offset = "0x247C1B8", VA = "0x247C1B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x247C30C", Offset = "0x247C30C", VA = "0x247C30C")]
		private void Pose()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x247C52C", Offset = "0x247C52C", VA = "0x247C52C")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x247C724", Offset = "0x247C724", VA = "0x247C724")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x247C7FC", Offset = "0x247C7FC", VA = "0x247C7FC")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x247D5C8", Offset = "0x247D5C8", VA = "0x247D5C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x247D82C", Offset = "0x247D82C", VA = "0x247D82C")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x247DA7C", Offset = "0x247DA7C", VA = "0x247DA7C")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x13AD648", Offset = "0x13AD648")]
		public Animator animator;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x13AD680", Offset = "0x13AD680")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AD6B8", Offset = "0x13AD6B8")]
		public float lookAtWeight;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AD6D0", Offset = "0x13AD6D0")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AD6E8", Offset = "0x13AD6E8")]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AD700", Offset = "0x13AD700")]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AD718", Offset = "0x13AD718")]
		public float lookAtClampWeight;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AD730", Offset = "0x13AD730")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AD748", Offset = "0x13AD748")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x13AD760", Offset = "0x13AD760")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AD798", Offset = "0x13AD798")]
		public float footPositionWeight;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AD7B0", Offset = "0x13AD7B0")]
		public float footRotationWeight;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x13AD7C8", Offset = "0x13AD7C8")]
		public Transform handTargetBiped;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AD800", Offset = "0x13AD800")]
		public float handPositionWeight;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AD818", Offset = "0x13AD818")]
		public float handRotationWeight;

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x246BA30", Offset = "0x246BA30", VA = "0x246BA30")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x246BEDC", Offset = "0x246BEDC", VA = "0x246BEDC")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2475E44", Offset = "0x2475E44", VA = "0x2475E44")]
		private void Update()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2476878", Offset = "0x2476878", VA = "0x2476878")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2476560", Offset = "0x2476560", VA = "0x2476560")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2476A20", Offset = "0x2476A20", VA = "0x2476A20")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x17000013")]
		public Vector3 inputVector
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x2476A4C", Offset = "0x2476A4C", VA = "0x2476A4C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2476AEC", Offset = "0x2476AEC", VA = "0x2476AEC")]
		private void Update()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2476D84", Offset = "0x2476D84", VA = "0x2476D84")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD140", Offset = "0x13AD140")]
		private sealed class <Step>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x1700008C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000649")]
				[Address(RVA = "0x2477A94", Offset = "0x2477A94", VA = "0x2477A94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600064B")]
				[Address(RVA = "0x2477AFC", Offset = "0x2477AFC", VA = "0x2477AFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x2477718", Offset = "0x2477718", VA = "0x2477718")]
			[DebuggerHidden]
			public <Step>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x2477774", Offset = "0x2477774", VA = "0x2477774", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x2477778", Offset = "0x2477778", VA = "0x2477778", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x2477A9C", Offset = "0x2477A9C", VA = "0x2477A9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem sand;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IK ik;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float stepProgress;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastStepTime;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit hit;

		[Token(Token = "0x17000014")]
		public bool isStepping
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x2476D98", Offset = "0x2476D98", VA = "0x2476D98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public Vector3 position
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x24769EC", Offset = "0x24769EC", VA = "0x24769EC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x2476DAC", Offset = "0x2476DAC", VA = "0x2476DAC")]
			set
			{
			}
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2476DFC", Offset = "0x2476DFC", VA = "0x2476DFC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2476E5C", Offset = "0x2476E5C", VA = "0x2476E5C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2477004", Offset = "0x2477004", VA = "0x2477004")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x24773D4", Offset = "0x24773D4", VA = "0x24773D4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x24774FC", Offset = "0x24774FC", VA = "0x24774FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2477444", Offset = "0x2477444", VA = "0x2477444")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B5764", Offset = "0x13B5764")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2477744", Offset = "0x2477744", VA = "0x2477744")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2477B04", Offset = "0x2477B04", VA = "0x2477B04")]
		private void Start()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2477BC0", Offset = "0x2477BC0", VA = "0x2477BC0")]
		private void Update()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2477E54", Offset = "0x2477E54", VA = "0x2477E54")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E9")]
		public struct Warp
		{
			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1C54", Offset = "0x13B1C54")]
			public int animationLayer;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1C8C", Offset = "0x13B1C8C")]
			public string animationState;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1CC4", Offset = "0x13B1CC4")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1CFC", Offset = "0x13B1CFC")]
			public Transform warpFrom;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1D34", Offset = "0x13B1D34")]
			public Transform warpTo;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1D6C", Offset = "0x13B1D6C")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000EA")]
		public enum EffectorMode
		{
			[Token(Token = "0x400060B")]
			PositionOffset,
			[Token(Token = "0x400060C")]
			Position
		}

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AD830", Offset = "0x13AD830")]
		public Animator animator;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AD868", Offset = "0x13AD868")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x13AD8A0", Offset = "0x13AD8A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AD8A0", Offset = "0x13AD8A0")]
		public Warp[] warps;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2469ECC", Offset = "0x2469ECC", VA = "0x2469ECC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2469EF8", Offset = "0x2469EF8", VA = "0x2469EF8")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x246A100", Offset = "0x246A100", VA = "0x246A100", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x246A4B4", Offset = "0x246A4B4", VA = "0x246A4B4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x246A554", Offset = "0x246A554", VA = "0x246A554")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AC1D0", Offset = "0x13AC1D0")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x246A55C", Offset = "0x246A55C", VA = "0x246A55C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x246A5BC", Offset = "0x246A5BC", VA = "0x246A5BC")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x246A7F4", Offset = "0x246A7F4", VA = "0x246A7F4", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x246AA58", Offset = "0x246AA58", VA = "0x246AA58")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AC234", Offset = "0x13AC234")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AC234", Offset = "0x13AC234")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AD8F0", Offset = "0x13AD8F0")]
		public float headLookWeight;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x246AA6C", Offset = "0x246AA6C", VA = "0x246AA6C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x246AC18", Offset = "0x246AC18", VA = "0x246AC18", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x246AC8C", Offset = "0x246AC8C", VA = "0x246AC8C")]
		private void Read()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x246ADE4", Offset = "0x246ADE4", VA = "0x246ADE4")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x246AE2C", Offset = "0x246AE2C", VA = "0x246AE2C")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x246B424", Offset = "0x246B424", VA = "0x246B424")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x246B1E8", Offset = "0x246B1E8", VA = "0x246B1E8")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x246B77C", Offset = "0x246B77C", VA = "0x246B77C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x246B898", Offset = "0x246B898", VA = "0x246B898")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AC2C0", Offset = "0x13AC2C0")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x246CF2C", Offset = "0x246CF2C", VA = "0x246CF2C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x246CF94", Offset = "0x246CF94", VA = "0x246CF94", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x246D258", Offset = "0x246D258", VA = "0x246D258")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x246D410", Offset = "0x246D410", VA = "0x246D410")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AC324", Offset = "0x13AC324")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000016")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x246E27C", Offset = "0x246E27C", VA = "0x246E27C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000017")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x246E31C", Offset = "0x246E31C", VA = "0x246E31C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x246DFC0", Offset = "0x246DFC0", VA = "0x246DFC0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x246E038", Offset = "0x246E038", VA = "0x246E038")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x246E3BC", Offset = "0x246E3BC", VA = "0x246E3BC")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AD918", Offset = "0x13AD918")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2470A4C", Offset = "0x2470A4C", VA = "0x2470A4C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2471030", Offset = "0x2471030", VA = "0x2471030")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2471038", Offset = "0x2471038", VA = "0x2471038")]
		private void Start()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x24710EC", Offset = "0x24710EC", VA = "0x24710EC")]
		private void Update()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2471568", Offset = "0x2471568", VA = "0x2471568")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2471614", Offset = "0x2471614", VA = "0x2471614")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EB")]
		public class Limb
		{
			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x24717E8", Offset = "0x24717E8", VA = "0x24717E8")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x247191C", Offset = "0x247191C", VA = "0x247191C")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x247169C", Offset = "0x247169C", VA = "0x247169C")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x247186C", Offset = "0x247186C", VA = "0x247186C")]
		private void Start()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2471908", Offset = "0x2471908", VA = "0x2471908")]
		private void Update()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x247190C", Offset = "0x247190C", VA = "0x247190C")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x247192C", Offset = "0x247192C", VA = "0x247192C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2471998", Offset = "0x2471998", VA = "0x2471998")]
		private void Update()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2471A7C", Offset = "0x2471A7C", VA = "0x2471A7C")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AD930", Offset = "0x13AD930")]
		public Transform target;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AD968", Offset = "0x13AD968")]
		public Transform pin;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AD9A0", Offset = "0x13AD9A0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AD9D8", Offset = "0x13AD9D8")]
		public AimIK aim;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13ADA10", Offset = "0x13ADA10")]
		public float weight;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13ADA48", Offset = "0x13ADA48")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13ADA80", Offset = "0x13ADA80")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2471A84", Offset = "0x2471A84", VA = "0x2471A84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2471AE4", Offset = "0x2471AE4", VA = "0x2471AE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2471C80", Offset = "0x2471C80", VA = "0x2471C80")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2471C88", Offset = "0x2471C88", VA = "0x2471C88")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2471D58", Offset = "0x2471D58", VA = "0x2471D58")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2471DE8", Offset = "0x2471DE8", VA = "0x2471DE8")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x24722FC", Offset = "0x24722FC", VA = "0x24722FC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2472418", Offset = "0x2472418", VA = "0x2472418")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13ADAB8", Offset = "0x13ADAB8")]
		public float aimWeight;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13ADAD0", Offset = "0x13ADAD0")]
		public float sightWeight;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13ADAE8", Offset = "0x13ADAE8")]
		public float maxAngle;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13ADB74", Offset = "0x13ADB74")]
		private float cameraRecoilWeight;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool updateFrame;

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2472420", Offset = "0x2472420", VA = "0x2472420")]
		private void Start()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2472580", Offset = "0x2472580", VA = "0x2472580")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x247258C", Offset = "0x247258C", VA = "0x247258C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x24728CC", Offset = "0x24728CC", VA = "0x24728CC")]
		private void Aiming()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2472B34", Offset = "0x2472B34", VA = "0x2472B34")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2472650", Offset = "0x2472650", VA = "0x2472650")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2473540", Offset = "0x2473540", VA = "0x2473540")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AC388", Offset = "0x13AC388")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AC388", Offset = "0x13AC388")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13ADBB4", Offset = "0x13ADBB4")]
		public float walkSpeed;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2473560", Offset = "0x2473560", VA = "0x2473560")]
		private void Start()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x24735E4", Offset = "0x24735E4", VA = "0x24735E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2473708", Offset = "0x2473708", VA = "0x2473708")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x24737B8", Offset = "0x24737B8", VA = "0x24737B8")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2473B4C", Offset = "0x2473B4C", VA = "0x2473B4C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2473D18", Offset = "0x2473D18", VA = "0x2473D18")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2473EDC", Offset = "0x2473EDC", VA = "0x2473EDC")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x247428C", Offset = "0x247428C", VA = "0x247428C")]
		private void Start()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2474438", Offset = "0x2474438", VA = "0x2474438")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x24747F4", Offset = "0x24747F4", VA = "0x24747F4")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2474804", Offset = "0x2474804", VA = "0x2474804")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2474938", Offset = "0x2474938", VA = "0x2474938")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2474A88", Offset = "0x2474A88", VA = "0x2474A88")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2474A90", Offset = "0x2474A90", VA = "0x2474A90")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2475160", Offset = "0x2475160", VA = "0x2475160")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AC414", Offset = "0x13AC414")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13ADBEC", Offset = "0x13ADBEC")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13ADC38", Offset = "0x13ADC38")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2475168", Offset = "0x2475168", VA = "0x2475168")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x24751C8", Offset = "0x24751C8", VA = "0x24751C8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x24754D4", Offset = "0x24754D4", VA = "0x24754D4")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EC")]
		public class Partner
		{
			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x1700008E")]
			private Transform neck
			{
				[Token(Token = "0x6000650")]
				[Address(RVA = "0x2475DD8", Offset = "0x2475DD8", VA = "0x2475DD8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x2475510", Offset = "0x2475510", VA = "0x2475510")]
			public void Initiate()
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x2475590", Offset = "0x2475590", VA = "0x2475590")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x2475BFC", Offset = "0x2475BFC", VA = "0x2475BFC")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x2475E30", Offset = "0x2475E30", VA = "0x2475E30")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x24754DC", Offset = "0x24754DC", VA = "0x24754DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2475530", Offset = "0x2475530", VA = "0x2475530")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2475BEC", Offset = "0x2475BEC", VA = "0x2475BEC")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000ED")]
		public enum Mode
		{
			[Token(Token = "0x400061C")]
			Position,
			[Token(Token = "0x400061D")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x20000EE")]
		public class Absorber
		{
			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1DA4", Offset = "0x13B1DA4")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1DDC", Offset = "0x13B1DDC")]
			public float weight;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x2477FD0", Offset = "0x2477FD0", VA = "0x2477FD0")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x24781C4", Offset = "0x24781C4", VA = "0x24781C4")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x2478200", Offset = "0x2478200", VA = "0x2478200")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x24783B0", Offset = "0x24783B0", VA = "0x24783B0")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x24785F8", Offset = "0x24785F8", VA = "0x24785F8")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13ADC84", Offset = "0x13ADC84")]
		public Mode mode;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13ADCBC", Offset = "0x13ADCBC")]
		public Absorber[] absorbers;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13ADCF4", Offset = "0x13ADCF4")]
		public AnimationCurve falloff;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13ADD2C", Offset = "0x13ADD2C")]
		public float falloffSpeed;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2477E5C", Offset = "0x2477E5C", VA = "0x2477E5C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2477F44", Offset = "0x2477F44", VA = "0x2477F44")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x24780B8", Offset = "0x24780B8", VA = "0x24780B8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2478328", Offset = "0x2478328", VA = "0x2478328")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x24784C0", Offset = "0x24784C0", VA = "0x24784C0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x24785E8", Offset = "0x24785E8", VA = "0x24785E8")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2478678", Offset = "0x2478678", VA = "0x2478678")]
		private void Start()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x24786F8", Offset = "0x24786F8", VA = "0x24786F8")]
		private void Update()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x24787AC", Offset = "0x24787AC", VA = "0x24787AC")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x247890C", Offset = "0x247890C", VA = "0x247890C")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000EF")]
		public class EffectorLink
		{
			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x24796AC", Offset = "0x24796AC", VA = "0x24796AC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2479378", Offset = "0x2479378", VA = "0x2479378", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2479478", Offset = "0x2479478", VA = "0x2479478", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x24796A4", Offset = "0x24796A4", VA = "0x24796A4")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AC478", Offset = "0x13AC478")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13ADD64", Offset = "0x13ADD64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13ADD64", Offset = "0x13ADD64")]
		public float weight;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13ADDB8", Offset = "0x13ADDB8")]
		public float hangingDistanceMlp;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13ADDF0", Offset = "0x13ADDF0")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13ADE3C", Offset = "0x13ADE3C")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x24796BC", Offset = "0x24796BC", VA = "0x24796BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2479A0C", Offset = "0x2479A0C", VA = "0x2479A0C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x247A15C", Offset = "0x247A15C", VA = "0x247A15C")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000018")]
		private bool holding
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x247A4A0", Offset = "0x247A4A0", VA = "0x247A4A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x247A1E0", Offset = "0x247A1E0", VA = "0x247A1E0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001A8")]
		protected abstract void RotatePivot();

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x247A4C0", Offset = "0x247A4C0", VA = "0x247A4C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x247A658", Offset = "0x247A658", VA = "0x247A658")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x247A7D4", Offset = "0x247A7D4", VA = "0x247A7D4")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x247A8B4", Offset = "0x247A8B4", VA = "0x247A8B4")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x247A9E0", Offset = "0x247A9E0", VA = "0x247A9E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x247ABF0", Offset = "0x247ABF0", VA = "0x247ABF0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x247ADD4", Offset = "0x247ADD4", VA = "0x247ADD4")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x247ADE8", Offset = "0x247ADE8", VA = "0x247ADE8", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x247AFDC", Offset = "0x247AFDC", VA = "0x247AFDC")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x247AFF0", Offset = "0x247AFF0", VA = "0x247AFF0", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x247B19C", Offset = "0x247B19C", VA = "0x247B19C")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x247B93C", Offset = "0x247B93C", VA = "0x247B93C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x247BA14", Offset = "0x247BA14", VA = "0x247BA14")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x247BBBC", Offset = "0x247BBBC", VA = "0x247BBBC")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AC4DC", Offset = "0x13AC4DC")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x247BBC4", Offset = "0x247BBC4", VA = "0x247BBC4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x247BC24", Offset = "0x247BC24", VA = "0x247BC24")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x247BC80", Offset = "0x247BC80", VA = "0x247BC80")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x247BD58", Offset = "0x247BD58", VA = "0x247BD58")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD150", Offset = "0x13AD150")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x1700008F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600065C")]
				[Address(RVA = "0x247C104", Offset = "0x247C104", VA = "0x247C104", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600065E")]
				[Address(RVA = "0x247C16C", Offset = "0x247C16C", VA = "0x247C16C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x247BF08", Offset = "0x247BF08", VA = "0x247BF08")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x247BF44", Offset = "0x247BF44", VA = "0x247BF44", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x247BF48", Offset = "0x247BF48", VA = "0x247BF48", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x247C10C", Offset = "0x247C10C", VA = "0x247C10C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x247BD68", Offset = "0x247BD68", VA = "0x247BD68")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x247BE34", Offset = "0x247BE34", VA = "0x247BE34")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x247BE7C", Offset = "0x247BE7C", VA = "0x247BE7C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B57C8", Offset = "0x13B57C8")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x247BF34", Offset = "0x247BF34", VA = "0x247BF34")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AC540", Offset = "0x13AC540")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD160", Offset = "0x13AD160")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x17000091")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000662")]
				[Address(RVA = "0x247D558", Offset = "0x247D558", VA = "0x247D558", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000664")]
				[Address(RVA = "0x247D5C0", Offset = "0x247D5C0", VA = "0x247D5C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x247D3E8", Offset = "0x247D3E8", VA = "0x247D3E8")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x247D41C", Offset = "0x247D41C", VA = "0x247D41C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x247D420", Offset = "0x247D420", VA = "0x247D420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x247D560", Offset = "0x247D560", VA = "0x247D560", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x247D2B0", Offset = "0x247D2B0", VA = "0x247D2B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x247D36C", Offset = "0x247D36C", VA = "0x247D36C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B582C", Offset = "0x13B582C")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x247D414", Offset = "0x247D414", VA = "0x247D414")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F2")]
		public class EffectorLink
		{
			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x247DB68", Offset = "0x247DB68", VA = "0x247DB68")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x247E878", Offset = "0x247E878", VA = "0x247E878")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x247DEE4", Offset = "0x247DEE4", VA = "0x247DEE4")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x247E960", Offset = "0x247E960", VA = "0x247E960")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x247EAFC", Offset = "0x247EAFC", VA = "0x247EAFC")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x247EB98", Offset = "0x247EB98", VA = "0x247EB98")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x247EC30", Offset = "0x247EC30", VA = "0x247EC30")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x247E6C4", Offset = "0x247E6C4", VA = "0x247E6C4")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x247ECC8", Offset = "0x247ECC8", VA = "0x247ECC8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x247DAF0", Offset = "0x247DAF0", VA = "0x247DAF0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x247DE78", Offset = "0x247DE78", VA = "0x247DE78")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x247E5FC", Offset = "0x247E5FC", VA = "0x247E5FC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x247E870", Offset = "0x247E870", VA = "0x247E870")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13ADF28", Offset = "0x13ADF28")]
		public Transform to;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13ADF60", Offset = "0x13ADF60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13ADF60", Offset = "0x13ADF60")]
		public float transferMotion;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x247ECFC", Offset = "0x247ECFC", VA = "0x247ECFC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x247ED38", Offset = "0x247ED38", VA = "0x247ED38")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x247EE90", Offset = "0x247EE90", VA = "0x247EE90")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13ADFB4", Offset = "0x13ADFB4")]
		public Transform leftHandTarget;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x247F064", Offset = "0x247F064", VA = "0x247F064")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x247F244", Offset = "0x247F244", VA = "0x247F244")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x247F4E0", Offset = "0x247F4E0", VA = "0x247F4E0")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x247F5AC", Offset = "0x247F5AC", VA = "0x247F5AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x247F6C8", Offset = "0x247F6C8", VA = "0x247F6C8")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x247FA40", Offset = "0x247FA40", VA = "0x247FA40", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x247FEB8", Offset = "0x247FEB8", VA = "0x247FEB8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2480110", Offset = "0x2480110", VA = "0x2480110")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x24737C8", Offset = "0x24737C8", VA = "0x24737C8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2473AC4", Offset = "0x2473AC4", VA = "0x2473AC4")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2473B44", Offset = "0x2473B44", VA = "0x2473B44")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD170", Offset = "0x13AD170")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x17000093")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000671")]
				[Address(RVA = "0x247B8CC", Offset = "0x247B8CC", VA = "0x247B8CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000673")]
				[Address(RVA = "0x247B934", Offset = "0x247B934", VA = "0x247B934", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x247B57C", Offset = "0x247B57C", VA = "0x247B57C")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x247B788", Offset = "0x247B788", VA = "0x247B788", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x247B78C", Offset = "0x247B78C", VA = "0x247B78C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x247B8D4", Offset = "0x247B8D4", VA = "0x247B8D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x247B1B0", Offset = "0x247B1B0", VA = "0x247B1B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x247B354", Offset = "0x247B354", VA = "0x247B354")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x247B2D8", Offset = "0x247B2D8", VA = "0x247B2D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B5890", Offset = "0x13B5890")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x247B5A8", Offset = "0x247B5A8", VA = "0x247B5A8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x247B68C", Offset = "0x247B68C", VA = "0x247B68C")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x247B76C", Offset = "0x247B76C", VA = "0x247B76C")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AE01C", Offset = "0x13AE01C")]
		public float weight;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x246B8F8", Offset = "0x246B8F8", VA = "0x246B8F8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x246B964", Offset = "0x246B964", VA = "0x246B964")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x246BA20", Offset = "0x246BA20", VA = "0x246BA20")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F4")]
		public class Part
		{
			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x247EF1C", Offset = "0x247EF1C", VA = "0x247EF1C")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x247F05C", Offset = "0x247F05C", VA = "0x247F05C")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x247EEA4", Offset = "0x247EEA4", VA = "0x247EEA4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x247F054", Offset = "0x247F054", VA = "0x247F054")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2473EEC", Offset = "0x2473EEC", VA = "0x2473EEC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x24740B8", Offset = "0x24740B8", VA = "0x24740B8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x247427C", Offset = "0x247427C", VA = "0x247427C")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE054", Offset = "0x13AE054")]
		public VRIK ik;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE08C", Offset = "0x13AE08C")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE0C4", Offset = "0x13AE0C4")]
		public Transform headTracker;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE0FC", Offset = "0x13AE0FC")]
		public Transform bodyTracker;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE134", Offset = "0x13AE134")]
		public Transform leftHandTracker;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE16C", Offset = "0x13AE16C")]
		public Transform rightHandTracker;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE1A4", Offset = "0x13AE1A4")]
		public Transform leftFootTracker;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE1DC", Offset = "0x13AE1DC")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13AE214", Offset = "0x13AE214")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2480134", Offset = "0x2480134", VA = "0x2480134")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x248029C", Offset = "0x248029C", VA = "0x248029C")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2480310", Offset = "0x2480310", VA = "0x2480310")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x248036C", Offset = "0x248036C", VA = "0x248036C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x24805B8", Offset = "0x24805B8", VA = "0x24805B8")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2480630", Offset = "0x2480630", VA = "0x2480630")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2480B98", Offset = "0x2480B98", VA = "0x2480B98")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x17000019")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x246BF20", Offset = "0x246BF20", VA = "0x246BF20", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x246BEFC", Offset = "0x246BEFC", VA = "0x246BEFC", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x246BF28", Offset = "0x246BF28", VA = "0x246BF28")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x246BFEC", Offset = "0x246BFEC", VA = "0x246BFEC", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x246C244", Offset = "0x246C244", VA = "0x246C244", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x246C4B4", Offset = "0x246C4B4", VA = "0x246C4B4", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x246C254", Offset = "0x246C254", VA = "0x246C254")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x246C4C4", Offset = "0x246C4C4", VA = "0x246C4C4")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AC5A4", Offset = "0x13AC5A4")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x246C4DC", Offset = "0x246C4DC", VA = "0x246C4DC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x246C544", Offset = "0x246C544", VA = "0x246C544", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x246C670", Offset = "0x246C670", VA = "0x246C670")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x246C7EC", Offset = "0x246C7EC", VA = "0x246C7EC")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AC608", Offset = "0x13AC608")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AE2AC", Offset = "0x13AE2AC")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x400024D")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x400024E")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x1700001A")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x246C8B0", Offset = "0x246C8B0", VA = "0x246C8B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x246C804", Offset = "0x246C804", VA = "0x246C804", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x246C894", Offset = "0x246C894", VA = "0x246C894", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x246C9A0", Offset = "0x246C9A0", VA = "0x246C9A0", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x246CD54", Offset = "0x246CD54", VA = "0x246CD54")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x246CF08", Offset = "0x246CF08", VA = "0x246CF08")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AC66C", Offset = "0x13AC66C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AC66C", Offset = "0x13AC66C")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13AE2F0", Offset = "0x13AE2F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE2F0", Offset = "0x13AE2F0")]
		public Transform gravityTarget;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE350", Offset = "0x13AE350")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x400025A")]
		protected const float half = 0.5f;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60001FC")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x246D434", Offset = "0x246D434", VA = "0x246D434")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x246D5B8", Offset = "0x246D5B8", VA = "0x246D5B8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x246D780", Offset = "0x246D780", VA = "0x246D780", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x246D9F8", Offset = "0x246D9F8", VA = "0x246D9F8")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x246DABC", Offset = "0x246DABC", VA = "0x246DABC")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x246DCA4", Offset = "0x246DCA4", VA = "0x246DCA4")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x246DE54", Offset = "0x246DE54", VA = "0x246DE54")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x246DE78", Offset = "0x246DE78", VA = "0x246DE78")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x246DE9C", Offset = "0x246DE9C", VA = "0x246DE9C")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x246DFA0", Offset = "0x246DFA0", VA = "0x246DFA0")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x20000F5")]
		public enum MoveMode
		{
			[Token(Token = "0x4000647")]
			Directional,
			[Token(Token = "0x4000648")]
			Strafe
		}

		[Token(Token = "0x20000F6")]
		public struct AnimState
		{
			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13AE3EC", Offset = "0x13AE3EC")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13AE424", Offset = "0x13AE424")]
		public MoveMode moveMode;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13AE45C", Offset = "0x13AE45C")]
		public bool lookInCameraDirection;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13AE494", Offset = "0x13AE494")]
		public float airSpeed;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13AE4CC", Offset = "0x13AE4CC")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMaxLength;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13AE518", Offset = "0x13AE518")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AE550", Offset = "0x13AE550")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AnimState animState;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected Vector3 moveDirection;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool fixedFrame;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float wallRunEndTime;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Vector3 gravity;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float velocityY;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool doubleJumped;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		private bool jumpReleased;

		[Token(Token = "0x1700001B")]
		public bool onGround
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x246E3C4", Offset = "0x246E3C4", VA = "0x246E3C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B58F4", Offset = "0x13B58F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x246E3CC", Offset = "0x246E3CC", VA = "0x246E3CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5904", Offset = "0x13B5904")]
			private set
			{
			}
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x246E3D8", Offset = "0x246E3D8", VA = "0x246E3D8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x246E584", Offset = "0x246E584", VA = "0x246E584")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x246E614", Offset = "0x246E614", VA = "0x246E614", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x246E750", Offset = "0x246E750", VA = "0x246E750")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x246F68C", Offset = "0x246F68C", VA = "0x246F68C", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x246FA24", Offset = "0x246FA24", VA = "0x246FA24", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x246ED5C", Offset = "0x246ED5C", VA = "0x246ED5C")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x246FB04", Offset = "0x246FB04", VA = "0x246FB04")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x24700F4", Offset = "0x24700F4", VA = "0x24700F4")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x246F768", Offset = "0x246F768", VA = "0x246F768")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2470194", Offset = "0x2470194", VA = "0x2470194", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2470604", Offset = "0x2470604", VA = "0x2470604")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2470790", Offset = "0x2470790", VA = "0x2470790", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x246F26C", Offset = "0x246F26C", VA = "0x246F26C")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2470924", Offset = "0x2470924", VA = "0x2470924")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13AC6F8", Offset = "0x13AC6F8")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F7")]
		public enum RotationMode
		{
			[Token(Token = "0x4000651")]
			Smooth,
			[Token(Token = "0x4000652")]
			Linear
		}

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE560", Offset = "0x13AE560")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE5AC", Offset = "0x13AE5AC")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE5F8", Offset = "0x13AE5F8")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE644", Offset = "0x13AE644")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE690", Offset = "0x13AE690")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE6DC", Offset = "0x13AE6DC")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AE728", Offset = "0x13AE728")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x1700001C")]
		public bool isGrounded
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x247C810", Offset = "0x247C810", VA = "0x247C810")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5914", Offset = "0x13B5914")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x247C818", Offset = "0x247C818", VA = "0x247C818")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5924", Offset = "0x13B5924")]
			private set
			{
			}
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x247C824", Offset = "0x247C824", VA = "0x247C824")]
		private void Start()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x247C8C0", Offset = "0x247C8C0", VA = "0x247C8C0")]
		private void Update()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x247CFBC", Offset = "0x247CFBC", VA = "0x247CFBC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x247C914", Offset = "0x247C914", VA = "0x247C914")]
		private void Rotate()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x247CD14", Offset = "0x247CD14", VA = "0x247CD14")]
		private void Move()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x247CFF8", Offset = "0x247CFF8", VA = "0x247CFF8")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x247D0F0", Offset = "0x247D0F0", VA = "0x247D0F0")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x247D190", Offset = "0x247D190", VA = "0x247D190")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x247F6D0", Offset = "0x247F6D0", VA = "0x247F6D0", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x247F754", Offset = "0x247F754", VA = "0x247F754", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x247F9EC", Offset = "0x247F9EC", VA = "0x247F9EC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x247FA14", Offset = "0x247FA14", VA = "0x247FA14")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x20000F8")]
		public struct State
		{
			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x247F714", Offset = "0x247F714", VA = "0x247F714", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x247FB54", Offset = "0x247FB54", VA = "0x247FB54", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x247FA30", Offset = "0x247FA30", VA = "0x247FA30")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x246B8B4", Offset = "0x246B8B4", VA = "0x246B8B4")]
		private void Update()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x246B8F0", Offset = "0x246B8F0", VA = "0x246B8F0")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x247D1B8", Offset = "0x247D1B8", VA = "0x247D1B8")]
		private void Update()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x247D1EC", Offset = "0x247D1EC", VA = "0x247D1EC")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x247D29C", Offset = "0x247D29C", VA = "0x247D29C")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public class Navigator
	{
		[Token(Token = "0x20000F9")]
		public enum State
		{
			[Token(Token = "0x4000659")]
			Idle,
			[Token(Token = "0x400065A")]
			Seeking,
			[Token(Token = "0x400065B")]
			OnPath
		}

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE778", Offset = "0x13AE778")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE7B0", Offset = "0x13AE7B0")]
		public float cornerRadius;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE7E8", Offset = "0x13AE7E8")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE820", Offset = "0x13AE820")]
		public float maxSampleDistance;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE858", Offset = "0x13AE858")]
		public float nextPathInterval;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AE890", Offset = "0x13AE890")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AE8A0", Offset = "0x13AE8A0")]
		private State <state>k__BackingField;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x1700001D")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x2478920", Offset = "0x2478920", VA = "0x2478920")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5934", Offset = "0x13B5934")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x247892C", Offset = "0x247892C", VA = "0x247892C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5944", Offset = "0x13B5944")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public State state
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x2478938", Offset = "0x2478938", VA = "0x2478938")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5954", Offset = "0x13B5954")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x2478940", Offset = "0x2478940", VA = "0x2478940")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5964", Offset = "0x13B5964")]
			private set
			{
			}
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x2478948", Offset = "0x2478948", VA = "0x2478948")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2478A40", Offset = "0x2478A40", VA = "0x2478A40")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2478F98", Offset = "0x2478F98", VA = "0x2478F98")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2479008", Offset = "0x2479008", VA = "0x2479008")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2478E60", Offset = "0x2478E60", VA = "0x2478E60")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2478ED4", Offset = "0x2478ED4", VA = "0x2478ED4")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2479150", Offset = "0x2479150", VA = "0x2479150")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x2479300", Offset = "0x2479300", VA = "0x2479300")]
		public Navigator()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AC75C", Offset = "0x13AC75C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13AC75C", Offset = "0x13AC75C")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2482BEC", Offset = "0x2482BEC", VA = "0x2482BEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5974", Offset = "0x13B5974")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2482C38", Offset = "0x2482C38", VA = "0x2482C38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B59AC", Offset = "0x13B59AC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2482C84", Offset = "0x2482C84", VA = "0x2482C84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B59E4", Offset = "0x13B59E4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2482CD0", Offset = "0x2482CD0", VA = "0x2482CD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5A1C", Offset = "0x13B5A1C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2482D1C", Offset = "0x2482D1C", VA = "0x2482D1C")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2482DB8", Offset = "0x2482DB8", VA = "0x2482DB8")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2482DD8", Offset = "0x2482DD8", VA = "0x2482DD8")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2482E08", Offset = "0x2482E08", VA = "0x2482E08")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2482E38", Offset = "0x2482E38", VA = "0x2482E38")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2482E78", Offset = "0x2482E78", VA = "0x2482E78")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2482EBC", Offset = "0x2482EBC", VA = "0x2482EBC")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x2482EE0", Offset = "0x2482EE0", VA = "0x2482EE0")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2482F04", Offset = "0x2482F04", VA = "0x2482F04")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x2482F2C", Offset = "0x2482F2C", VA = "0x2482F2C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2482F58", Offset = "0x2482F58", VA = "0x2482F58")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2482F84", Offset = "0x2482F84", VA = "0x2482F84")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2482D3C", Offset = "0x2482D3C", VA = "0x2482D3C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2482FAC", Offset = "0x2482FAC", VA = "0x2482FAC")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2482FB8", Offset = "0x2482FB8", VA = "0x2482FB8")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x2482FC4", Offset = "0x2482FC4", VA = "0x2482FC4")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x24832EC", Offset = "0x24832EC", VA = "0x24832EC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x2483394", Offset = "0x2483394", VA = "0x2483394", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x24836E0", Offset = "0x24836E0", VA = "0x24836E0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2483BC8", Offset = "0x2483BC8", VA = "0x2483BC8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x2483BFC", Offset = "0x2483BFC", VA = "0x2483BFC")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700001F")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x2483164", Offset = "0x2483164", VA = "0x2483164")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x2483E40", Offset = "0x2483E40", VA = "0x2483E40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2483564", Offset = "0x2483564", VA = "0x2483564")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2483C98", Offset = "0x2483C98", VA = "0x2483C98")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	public abstract class Constraint
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000021")]
		public bool isValid
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x24844B0", Offset = "0x24844B0", VA = "0x24844B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000258")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2484520", Offset = "0x2484520", VA = "0x2484520")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2484528", Offset = "0x2484528", VA = "0x2484528", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2484634", Offset = "0x2484634", VA = "0x2484634")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x248463C", Offset = "0x248463C", VA = "0x248463C")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000022")]
		private bool positionChanged
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x248480C", Offset = "0x248480C", VA = "0x248480C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2484670", Offset = "0x2484670", VA = "0x2484670", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x24848C8", Offset = "0x24848C8", VA = "0x24848C8")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x24848D0", Offset = "0x24848D0", VA = "0x24848D0")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2484904", Offset = "0x2484904", VA = "0x2484904", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2484A2C", Offset = "0x2484A2C", VA = "0x2484A2C")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2484A34", Offset = "0x2484A34", VA = "0x2484A34")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000023")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x2484C08", Offset = "0x2484C08", VA = "0x2484C08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x2484A68", Offset = "0x2484A68", VA = "0x2484A68", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2484CD8", Offset = "0x2484CD8", VA = "0x2484CD8")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2484CE0", Offset = "0x2484CE0", VA = "0x2484CE0")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public class Constraints
	{
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AE8B0", Offset = "0x13AE8B0")]
		public float positionWeight;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AE8C8", Offset = "0x13AE8C8")]
		public float rotationWeight;

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2484D14", Offset = "0x2484D14", VA = "0x2484D14")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2483688", Offset = "0x2483688", VA = "0x2483688")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2483868", Offset = "0x2483868", VA = "0x2483868")]
		public void Update()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2484070", Offset = "0x2484070", VA = "0x2484070")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x20000FA")]
		public enum DOF
		{
			[Token(Token = "0x400065D")]
			One,
			[Token(Token = "0x400065E")]
			Three
		}

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE8E0", Offset = "0x13AE8E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AE8E0", Offset = "0x13AE8E0")]
		public float weight;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE934", Offset = "0x13AE934")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AE934", Offset = "0x13AE934")]
		public float rotationWeight;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE988", Offset = "0x13AE988")]
		public DOF rotationDOF;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE9C0", Offset = "0x13AE9C0")]
		public Transform bone1;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AE9F8", Offset = "0x13AE9F8")]
		public Transform bone2;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEA30", Offset = "0x13AEA30")]
		public Transform bone3;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEA68", Offset = "0x13AEA68")]
		public Transform tip;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEAA0", Offset = "0x13AEAA0")]
		public Transform target;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AEAD8", Offset = "0x13AEAD8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x17000024")]
		public bool initiated
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x248C1B4", Offset = "0x248C1B4", VA = "0x248C1B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5A54", Offset = "0x13B5A54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x248C1BC", Offset = "0x248C1BC", VA = "0x248C1BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5A64", Offset = "0x13B5A64")]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x248C1C8", Offset = "0x248C1C8", VA = "0x248C1C8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x248C1E8", Offset = "0x248C1E8", VA = "0x248C1E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x248C208", Offset = "0x248C208", VA = "0x248C208")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x248C228", Offset = "0x248C228", VA = "0x248C228")]
			set
			{
			}
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x248C248", Offset = "0x248C248", VA = "0x248C248")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x248C354", Offset = "0x248C354", VA = "0x248C354")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x248C790", Offset = "0x248C790", VA = "0x248C790")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x248C86C", Offset = "0x248C86C", VA = "0x248C86C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x248C934", Offset = "0x248C934", VA = "0x248C934")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x248CCEC", Offset = "0x248CCEC", VA = "0x248CCEC")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEAE8", Offset = "0x13AEAE8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AEAE8", Offset = "0x13AEAE8")]
		public float weight;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AEB3C", Offset = "0x13AEB3C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000027")]
		public bool initiated
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x248CCFC", Offset = "0x248CCFC", VA = "0x248CCFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5A74", Offset = "0x13B5A74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x248CD04", Offset = "0x248CD04", VA = "0x248CD04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5A84", Offset = "0x13B5A84")]
			private set
			{
			}
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x248CD10", Offset = "0x248CD10", VA = "0x248CD10")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x248CD98", Offset = "0x248CD98", VA = "0x248CD98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5A94", Offset = "0x13B5A94")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x248D110", Offset = "0x248D110", VA = "0x248D110")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x248D2CC", Offset = "0x248D2CC", VA = "0x248D2CC")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x248D000", Offset = "0x248D000", VA = "0x248D000")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x248D450", Offset = "0x248D450", VA = "0x248D450", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x248D510", Offset = "0x248D510", VA = "0x248D510")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x248D588", Offset = "0x248D588", VA = "0x248D588")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x248D5FC", Offset = "0x248D5FC", VA = "0x248D5FC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x248D664", Offset = "0x248D664", VA = "0x248D664", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x248D668", Offset = "0x248D668", VA = "0x248D668", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x248D67C", Offset = "0x248D67C", VA = "0x248D67C")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x20000FB")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEB4C", Offset = "0x13AEB4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AEB4C", Offset = "0x13AEB4C")]
		public float weight;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEBA0", Offset = "0x13AEBA0")]
		public Grounding solver;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AEBD8", Offset = "0x13AEBD8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000028")]
		public bool initiated
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x248E74C", Offset = "0x248E74C", VA = "0x248E74C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5ACC", Offset = "0x13B5ACC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x248E754", Offset = "0x248E754", VA = "0x248E754")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5ADC", Offset = "0x13B5ADC")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000286")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x248E760", Offset = "0x248E760", VA = "0x248E760")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x248EA34", Offset = "0x248EA34", VA = "0x248EA34")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x248E8A4", Offset = "0x248E8A4", VA = "0x248E8A4")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x248EA68", Offset = "0x248EA68", VA = "0x248EA68")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028D")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600028E")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x248EC70", Offset = "0x248EC70", VA = "0x248EC70")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AC7BC", Offset = "0x13AC7BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13AC7BC", Offset = "0x13AC7BC")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEBE8", Offset = "0x13AEBE8")]
		public BipedIK ik;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEC20", Offset = "0x13AEC20")]
		public float spineBend;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEC58", Offset = "0x13AEC58")]
		public float spineSpeed;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x248EFE8", Offset = "0x248EFE8", VA = "0x248EFE8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5AEC", Offset = "0x13B5AEC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x248F034", Offset = "0x248F034", VA = "0x248F034", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5B24", Offset = "0x13B5B24")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x248F080", Offset = "0x248F080", VA = "0x248F080", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x248F188", Offset = "0x248F188", VA = "0x248F188")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x248F238", Offset = "0x248F238", VA = "0x248F238")]
		private void Update()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x248F2EC", Offset = "0x248F2EC", VA = "0x248F2EC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x248F8A4", Offset = "0x248F8A4", VA = "0x248F8A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x248F8F8", Offset = "0x248F8F8", VA = "0x248F8F8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x24900B0", Offset = "0x24900B0", VA = "0x24900B0")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2490210", Offset = "0x2490210", VA = "0x2490210")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x24903A0", Offset = "0x24903A0", VA = "0x24903A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2490544", Offset = "0x2490544", VA = "0x2490544")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AC81C", Offset = "0x13AC81C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13AC81C", Offset = "0x13AC81C")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000FC")]
		public class SpineEffector
		{
			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1E24", Offset = "0x13B1E24")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1E5C", Offset = "0x13B1E5C")]
			public float horizontalWeight;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1E94", Offset = "0x13B1E94")]
			public float verticalWeight;

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x2491460", Offset = "0x2491460", VA = "0x2491460")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x2491470", Offset = "0x2491470", VA = "0x2491470")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEC90", Offset = "0x13AEC90")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AECC8", Offset = "0x13AECC8")]
		public float spineBend;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AED00", Offset = "0x13AED00")]
		public float spineSpeed;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x24905DC", Offset = "0x24905DC", VA = "0x24905DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5B5C", Offset = "0x13B5B5C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2490628", Offset = "0x2490628", VA = "0x2490628", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5B94", Offset = "0x13B5B94")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x2490674", Offset = "0x2490674", VA = "0x2490674", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5BCC", Offset = "0x13B5BCC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x24906C0", Offset = "0x24906C0", VA = "0x24906C0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2490740", Offset = "0x2490740", VA = "0x2490740")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x24907D8", Offset = "0x24907D8", VA = "0x24907D8")]
		private void Update()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x2490AD0", Offset = "0x2490AD0", VA = "0x2490AD0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x2490ADC", Offset = "0x2490ADC", VA = "0x2490ADC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2490894", Offset = "0x2490894", VA = "0x2490894")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2490AE8", Offset = "0x2490AE8", VA = "0x2490AE8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2490F88", Offset = "0x2490F88", VA = "0x2490F88")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x2491148", Offset = "0x2491148", VA = "0x2491148")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x24912A4", Offset = "0x24912A4", VA = "0x24912A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x24913C8", Offset = "0x24913C8", VA = "0x24913C8")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AC87C", Offset = "0x13AC87C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13AC87C", Offset = "0x13AC87C")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AED38", Offset = "0x13AED38")]
		public Transform pelvis;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AED70", Offset = "0x13AED70")]
		public Transform characterRoot;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEDA8", Offset = "0x13AEDA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AEDA8", Offset = "0x13AEDA8")]
		public float rootRotationWeight;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEDFC", Offset = "0x13AEDFC")]
		public float rootRotationSpeed;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEE34", Offset = "0x13AEE34")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x24914B8", Offset = "0x24914B8", VA = "0x24914B8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5C04", Offset = "0x13B5C04")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2491504", Offset = "0x2491504", VA = "0x2491504", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5C3C", Offset = "0x13B5C3C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2491550", Offset = "0x2491550", VA = "0x2491550", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x2491568", Offset = "0x2491568", VA = "0x2491568")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x2491758", Offset = "0x2491758", VA = "0x2491758")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x2491858", Offset = "0x2491858", VA = "0x2491858")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x2491FA0", Offset = "0x2491FA0", VA = "0x2491FA0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x24923E0", Offset = "0x24923E0", VA = "0x24923E0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x2492650", Offset = "0x2492650", VA = "0x2492650")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x2492970", Offset = "0x2492970", VA = "0x2492970")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x2492AFC", Offset = "0x2492AFC", VA = "0x2492AFC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2492CE8", Offset = "0x2492CE8", VA = "0x2492CE8")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AC8DC", Offset = "0x13AC8DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13AC8DC", Offset = "0x13AC8DC")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x20000FD")]
		public struct Foot
		{
			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x2493904", Offset = "0x2493904", VA = "0x2493904")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEE6C", Offset = "0x13AEE6C")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEEA4", Offset = "0x13AEEA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AEEA4", Offset = "0x13AEEA4")]
		public float rootRotationWeight;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEEF8", Offset = "0x13AEEF8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AEEF8", Offset = "0x13AEEF8")]
		public float minRootRotation;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEF50", Offset = "0x13AEF50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AEF50", Offset = "0x13AEF50")]
		public float maxRootRotation;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEFA8", Offset = "0x13AEFA8")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AEFE0", Offset = "0x13AEFE0")]
		public float maxLegOffset;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF018", Offset = "0x13AF018")]
		public float maxForeLegOffset;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF050", Offset = "0x13AF050")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AF050", Offset = "0x13AF050")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF0A4", Offset = "0x13AF0A4")]
		public Transform characterRoot;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF0DC", Offset = "0x13AF0DC")]
		public Transform pelvis;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF114", Offset = "0x13AF114")]
		public Transform lastSpineBone;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF14C", Offset = "0x13AF14C")]
		public Transform head;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2492D80", Offset = "0x2492D80", VA = "0x2492D80", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5C74", Offset = "0x13B5C74")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2492DCC", Offset = "0x2492DCC", VA = "0x2492DCC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5CAC", Offset = "0x13B5CAC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2492E18", Offset = "0x2492E18", VA = "0x2492E18", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x2492E4C", Offset = "0x2492E4C", VA = "0x2492E4C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2492F7C", Offset = "0x2492F7C", VA = "0x2492F7C")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x249313C", Offset = "0x249313C", VA = "0x249313C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x24931A4", Offset = "0x24931A4", VA = "0x24931A4")]
		private void Update()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x249325C", Offset = "0x249325C", VA = "0x249325C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2493590", Offset = "0x2493590", VA = "0x2493590")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2493968", Offset = "0x2493968", VA = "0x2493968")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x2493AB4", Offset = "0x2493AB4", VA = "0x2493AB4")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x2493F58", Offset = "0x2493F58", VA = "0x2493F58")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x2494748", Offset = "0x2494748", VA = "0x2494748")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x2494A08", Offset = "0x2494A08", VA = "0x2494A08")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x2494B68", Offset = "0x2494B68", VA = "0x2494B68")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x2494E44", Offset = "0x2494E44", VA = "0x2494E44")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x2494E7C", Offset = "0x2494E7C", VA = "0x2494E7C")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x2495060", Offset = "0x2495060", VA = "0x2495060")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13AC93C", Offset = "0x13AC93C")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF194", Offset = "0x13AF194")]
		public VRIK ik;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x2495194", Offset = "0x2495194", VA = "0x2495194")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5CE4", Offset = "0x13B5CE4")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x2495198", Offset = "0x2495198", VA = "0x2495198", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5D1C", Offset = "0x13B5D1C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x249519C", Offset = "0x249519C", VA = "0x249519C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5D54", Offset = "0x13B5D54")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x24951A0", Offset = "0x24951A0", VA = "0x24951A0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x24951B8", Offset = "0x24951B8", VA = "0x24951B8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x2495250", Offset = "0x2495250", VA = "0x2495250")]
		private void Update()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x2495304", Offset = "0x2495304", VA = "0x2495304")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x2495550", Offset = "0x2495550", VA = "0x2495550")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x24957E4", Offset = "0x24957E4", VA = "0x24957E4")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x24958EC", Offset = "0x24958EC", VA = "0x24958EC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x2495AEC", Offset = "0x2495AEC", VA = "0x2495AEC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x2495C48", Offset = "0x2495C48", VA = "0x2495C48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x2495DDC", Offset = "0x2495DDC", VA = "0x2495DDC")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x20000FE")]
		public enum Quality
		{
			[Token(Token = "0x4000667")]
			Fastest,
			[Token(Token = "0x4000668")]
			Simple,
			[Token(Token = "0x4000669")]
			Best
		}

		[Token(Token = "0x20000FF")]
		public class Leg
		{
			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B1ECC", Offset = "0x13B1ECC")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B1EDC", Offset = "0x13B1EDC")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B1EEC", Offset = "0x13B1EEC")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B1EFC", Offset = "0x13B1EFC")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B1F0C", Offset = "0x13B1F0C")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B1F1C", Offset = "0x13B1F1C")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B1F2C", Offset = "0x13B1F2C")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x17000095")]
			public bool isGrounded
			{
				[Token(Token = "0x600067D")]
				[Address(RVA = "0x24972E8", Offset = "0x24972E8", VA = "0x24972E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7A7C", Offset = "0x13B7A7C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600067E")]
				[Address(RVA = "0x24972F0", Offset = "0x24972F0", VA = "0x24972F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7A8C", Offset = "0x13B7A8C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000096")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x600067F")]
				[Address(RVA = "0x24972FC", Offset = "0x24972FC", VA = "0x24972FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7A9C", Offset = "0x13B7A9C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000680")]
				[Address(RVA = "0x2497308", Offset = "0x2497308", VA = "0x2497308")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7AAC", Offset = "0x13B7AAC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000097")]
			public bool initiated
			{
				[Token(Token = "0x6000681")]
				[Address(RVA = "0x2497314", Offset = "0x2497314", VA = "0x2497314")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7ABC", Offset = "0x13B7ABC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000682")]
				[Address(RVA = "0x249731C", Offset = "0x249731C", VA = "0x249731C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7ACC", Offset = "0x13B7ACC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000098")]
			public float heightFromGround
			{
				[Token(Token = "0x6000683")]
				[Address(RVA = "0x2497328", Offset = "0x2497328", VA = "0x2497328")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7ADC", Offset = "0x13B7ADC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000684")]
				[Address(RVA = "0x2497330", Offset = "0x2497330", VA = "0x2497330")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7AEC", Offset = "0x13B7AEC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000685")]
				[Address(RVA = "0x2497338", Offset = "0x2497338", VA = "0x2497338")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7AFC", Offset = "0x13B7AFC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000686")]
				[Address(RVA = "0x2497344", Offset = "0x2497344", VA = "0x2497344")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7B0C", Offset = "0x13B7B0C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009A")]
			public Transform transform
			{
				[Token(Token = "0x6000687")]
				[Address(RVA = "0x2497350", Offset = "0x2497350", VA = "0x2497350")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7B1C", Offset = "0x13B7B1C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000688")]
				[Address(RVA = "0x2497358", Offset = "0x2497358", VA = "0x2497358")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7B2C", Offset = "0x13B7B2C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009B")]
			public float IKOffset
			{
				[Token(Token = "0x6000689")]
				[Address(RVA = "0x2497360", Offset = "0x2497360", VA = "0x2497360")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7B3C", Offset = "0x13B7B3C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600068A")]
				[Address(RVA = "0x2497368", Offset = "0x2497368", VA = "0x2497368")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7B4C", Offset = "0x13B7B4C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x600068F")]
				[Address(RVA = "0x2497EB8", Offset = "0x2497EB8", VA = "0x2497EB8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700009D")]
			private float rootYOffset
			{
				[Token(Token = "0x6000698")]
				[Address(RVA = "0x24981AC", Offset = "0x24981AC", VA = "0x24981AC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x2496484", Offset = "0x2496484", VA = "0x2496484")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0x2497370", Offset = "0x2497370", VA = "0x2497370")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x2496E08", Offset = "0x2496E08", VA = "0x2496E08")]
			public void Reset()
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x2496598", Offset = "0x2496598", VA = "0x2496598")]
			public void Process()
			{
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x2497A50", Offset = "0x2497A50", VA = "0x2497A50")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x24973BC", Offset = "0x24973BC", VA = "0x24973BC")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x2498038", Offset = "0x2498038", VA = "0x2498038")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x24976E0", Offset = "0x24976E0", VA = "0x24976E0")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x24977E8", Offset = "0x24977E8", VA = "0x24977E8")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x2498134", Offset = "0x2498134", VA = "0x2498134")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x2497F44", Offset = "0x2497F44", VA = "0x2497F44")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x24982E0", Offset = "0x24982E0", VA = "0x24982E0")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x24963DC", Offset = "0x24963DC", VA = "0x24963DC")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000100")]
		public class Pelvis
		{
			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B1F3C", Offset = "0x13B1F3C")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B1F4C", Offset = "0x13B1F4C")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x1700009E")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x600069A")]
				[Address(RVA = "0x305DC8C", Offset = "0x305DC8C", VA = "0x305DC8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7B5C", Offset = "0x13B7B5C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600069B")]
				[Address(RVA = "0x305DC98", Offset = "0x305DC98", VA = "0x305DC98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7B6C", Offset = "0x13B7B6C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009F")]
			public float heightOffset
			{
				[Token(Token = "0x600069C")]
				[Address(RVA = "0x305DCA4", Offset = "0x305DCA4", VA = "0x305DCA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7B7C", Offset = "0x13B7B7C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600069D")]
				[Address(RVA = "0x305DCAC", Offset = "0x305DCAC", VA = "0x305DCAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7B8C", Offset = "0x13B7B8C")]
				private set
				{
				}
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x305DCB4", Offset = "0x305DCB4", VA = "0x305DCB4")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x305DD44", Offset = "0x305DD44", VA = "0x305DD44")]
			public void Reset()
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x305DCE4", Offset = "0x305DCE4", VA = "0x305DCE4")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x305DDF4", Offset = "0x305DDF4", VA = "0x305DDF4")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x305E040", Offset = "0x305E040", VA = "0x305E040")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF1CC", Offset = "0x13AF1CC")]
		public LayerMask layers;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF204", Offset = "0x13AF204")]
		public float maxStep;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF23C", Offset = "0x13AF23C")]
		public float heightOffset;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF274", Offset = "0x13AF274")]
		public float footSpeed;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF2AC", Offset = "0x13AF2AC")]
		public float footRadius;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF2E4", Offset = "0x13AF2E4")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF330", Offset = "0x13AF330")]
		public float prediction;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF368", Offset = "0x13AF368")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AF368", Offset = "0x13AF368")]
		public float footRotationWeight;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF3BC", Offset = "0x13AF3BC")]
		public float footRotationSpeed;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF3F4", Offset = "0x13AF3F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AF3F4", Offset = "0x13AF3F4")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF44C", Offset = "0x13AF44C")]
		public bool rotateSolver;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF484", Offset = "0x13AF484")]
		public float pelvisSpeed;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF4BC", Offset = "0x13AF4BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AF4BC", Offset = "0x13AF4BC")]
		public float pelvisDamper;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF510", Offset = "0x13AF510")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF548", Offset = "0x13AF548")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF580", Offset = "0x13AF580")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF5B8", Offset = "0x13AF5B8")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF5F0", Offset = "0x13AF5F0")]
		public Quality quality;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF628", Offset = "0x13AF628")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF638", Offset = "0x13AF638")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF648", Offset = "0x13AF648")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF658", Offset = "0x13AF658")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AF668", Offset = "0x13AF668")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000029")]
		public Leg[] legs
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x2495E44", Offset = "0x2495E44", VA = "0x2495E44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5D8C", Offset = "0x13B5D8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x2495E4C", Offset = "0x2495E4C", VA = "0x2495E4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5D9C", Offset = "0x13B5D9C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x2495E54", Offset = "0x2495E54", VA = "0x2495E54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5DAC", Offset = "0x13B5DAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x2495E5C", Offset = "0x2495E5C", VA = "0x2495E5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5DBC", Offset = "0x13B5DBC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public bool isGrounded
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x2495E64", Offset = "0x2495E64", VA = "0x2495E64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5DCC", Offset = "0x13B5DCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x2495E6C", Offset = "0x2495E6C", VA = "0x2495E6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5DDC", Offset = "0x13B5DDC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public Transform root
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x2495E78", Offset = "0x2495E78", VA = "0x2495E78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5DEC", Offset = "0x13B5DEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x2495E80", Offset = "0x2495E80", VA = "0x2495E80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5DFC", Offset = "0x13B5DFC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x2495E88", Offset = "0x2495E88", VA = "0x2495E88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5E0C", Offset = "0x13B5E0C")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x2495EA0", Offset = "0x2495EA0", VA = "0x2495EA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B5E1C", Offset = "0x13B5E1C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public bool rootGrounded
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x2495EC0", Offset = "0x2495EC0", VA = "0x2495EC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		public Vector3 up
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x2490184", Offset = "0x2490184", VA = "0x2490184")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000030")]
		private bool useRootRotation
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x2496EBC", Offset = "0x2496EBC", VA = "0x2496EBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x2495F14", Offset = "0x2495F14", VA = "0x2495F14")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x24962F4", Offset = "0x24962F4", VA = "0x24962F4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x248F5FC", Offset = "0x248F5FC", VA = "0x248F5FC")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x248FE44", Offset = "0x248FE44", VA = "0x248FE44")]
		public void Update()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x2491D88", Offset = "0x2491D88", VA = "0x2491D88")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x248F100", Offset = "0x248F100", VA = "0x248F100")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x2496580", Offset = "0x2496580", VA = "0x2496580")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x2496F8C", Offset = "0x2496F8C", VA = "0x2496F8C")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x24970F4", Offset = "0x24970F4", VA = "0x24970F4")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x24971F8", Offset = "0x24971F8", VA = "0x24971F8")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x248ED3C", Offset = "0x248ED3C", VA = "0x248ED3C")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AC974", Offset = "0x13AC974")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13AC974", Offset = "0x13AC974")]
	public class AimIK : IK
	{
		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x2481DB4", Offset = "0x2481DB4", VA = "0x2481DB4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5E2C", Offset = "0x13B5E2C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x2481E00", Offset = "0x2481E00", VA = "0x2481E00", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5E64", Offset = "0x13B5E64")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x2481E4C", Offset = "0x2481E4C", VA = "0x2481E4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5E9C", Offset = "0x13B5E9C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x2481E98", Offset = "0x2481E98", VA = "0x2481E98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5ED4", Offset = "0x13B5ED4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x2481EE4", Offset = "0x2481EE4", VA = "0x2481EE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5F0C", Offset = "0x13B5F0C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x2481F30", Offset = "0x2481F30", VA = "0x2481F30", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x2481F38", Offset = "0x2481F38", VA = "0x2481F38")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13AC9D4", Offset = "0x13AC9D4")]
	public class ArmIK : IK
	{
		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x2482A00", Offset = "0x2482A00", VA = "0x2482A00", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5F44", Offset = "0x13B5F44")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x2482A6C", Offset = "0x2482A6C", VA = "0x2482A6C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5F7C", Offset = "0x13B5F7C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x2482AD8", Offset = "0x2482AD8", VA = "0x2482AD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5FB4", Offset = "0x13B5FB4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x2482B24", Offset = "0x2482B24", VA = "0x2482B24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B5FEC", Offset = "0x13B5FEC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x2482B70", Offset = "0x2482B70", VA = "0x2482B70", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x2482B78", Offset = "0x2482B78", VA = "0x2482B78")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13ACA0C", Offset = "0x13ACA0C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ACA0C", Offset = "0x13ACA0C")]
	public class CCDIK : IK
	{
		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x2484304", Offset = "0x2484304", VA = "0x2484304", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6024", Offset = "0x13B6024")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x2484350", Offset = "0x2484350", VA = "0x2484350", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B605C", Offset = "0x13B605C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x248439C", Offset = "0x248439C", VA = "0x248439C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6094", Offset = "0x13B6094")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x24843E8", Offset = "0x24843E8", VA = "0x24843E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B60CC", Offset = "0x13B60CC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x2484434", Offset = "0x2484434", VA = "0x2484434", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x248443C", Offset = "0x248443C", VA = "0x248443C")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13ACA6C", Offset = "0x13ACA6C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ACA6C", Offset = "0x13ACA6C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x2484D84", Offset = "0x2484D84", VA = "0x2484D84", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6104", Offset = "0x13B6104")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x2484DD0", Offset = "0x2484DD0", VA = "0x2484DD0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B613C", Offset = "0x13B613C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x2484E1C", Offset = "0x2484E1C", VA = "0x2484E1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6174", Offset = "0x13B6174")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x2484E68", Offset = "0x2484E68", VA = "0x2484E68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B61AC", Offset = "0x13B61AC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x2484EB4", Offset = "0x2484EB4", VA = "0x2484EB4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x2484EBC", Offset = "0x2484EBC", VA = "0x2484EBC")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13ACACC", Offset = "0x13ACACC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ACACC", Offset = "0x13ACACC")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x2485560", Offset = "0x2485560", VA = "0x2485560", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B61E4", Offset = "0x13B61E4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x24855AC", Offset = "0x24855AC", VA = "0x24855AC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B621C", Offset = "0x13B621C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x24855F8", Offset = "0x24855F8", VA = "0x24855F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6254", Offset = "0x13B6254")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x2485644", Offset = "0x2485644", VA = "0x2485644")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B628C", Offset = "0x13B628C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x2485690", Offset = "0x2485690", VA = "0x2485690", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x2485698", Offset = "0x2485698", VA = "0x2485698")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13ACB2C", Offset = "0x13ACB2C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ACB2C", Offset = "0x13ACB2C")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x248D6F0", Offset = "0x248D6F0", VA = "0x248D6F0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B62C4", Offset = "0x13B62C4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x248D73C", Offset = "0x248D73C", VA = "0x248D73C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B62FC", Offset = "0x13B62FC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x248D788", Offset = "0x248D788", VA = "0x248D788")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6334", Offset = "0x13B6334")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x248D7D4", Offset = "0x248D7D4", VA = "0x248D7D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B636C", Offset = "0x13B636C")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x248D820", Offset = "0x248D820", VA = "0x248D820")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B63A4", Offset = "0x13B63A4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x248D86C", Offset = "0x248D86C", VA = "0x248D86C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B63DC", Offset = "0x13B63DC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x248D8B8", Offset = "0x248D8B8", VA = "0x248D8B8")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x248D8FC", Offset = "0x248D8FC", VA = "0x248D8FC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x248D904", Offset = "0x248D904", VA = "0x248D904")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x248DACC", Offset = "0x248DACC", VA = "0x248DACC")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x248DE2C", Offset = "0x248DE2C", VA = "0x248DE2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6414", Offset = "0x13B6414")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x248DE4C", Offset = "0x248DE4C", VA = "0x248DE4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B644C", Offset = "0x13B644C")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x248DF40", Offset = "0x248DF40", VA = "0x248DF40")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000319")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x3060C70", Offset = "0x3060C70", VA = "0x3060C70", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x3060D5C", Offset = "0x3060D5C", VA = "0x3060D5C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x3060F24", Offset = "0x3060F24", VA = "0x3060F24", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600031D")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600031E")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x3060F84", Offset = "0x3060F84", VA = "0x3060F84")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF678", Offset = "0x13AF678")]
		public IK[] IKComponents;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF6B0", Offset = "0x13AF6B0")]
		public Animator animator;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000031")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x3064028", Offset = "0x3064028", VA = "0x3064028")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x30640C4", Offset = "0x30640C4", VA = "0x30640C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x3064134", Offset = "0x3064134", VA = "0x3064134")]
		private void Update()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x30641F0", Offset = "0x30641F0", VA = "0x30641F0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x306422C", Offset = "0x306422C", VA = "0x306422C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x3064168", Offset = "0x3064168", VA = "0x3064168")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x30642B8", Offset = "0x30642B8", VA = "0x30642B8")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ACB8C", Offset = "0x13ACB8C")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x2917C44", Offset = "0x2917C44", VA = "0x2917C44", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6484", Offset = "0x13B6484")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x2917CB0", Offset = "0x2917CB0", VA = "0x2917CB0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B64BC", Offset = "0x13B64BC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x2917D1C", Offset = "0x2917D1C", VA = "0x2917D1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B64F4", Offset = "0x13B64F4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x2917D68", Offset = "0x2917D68", VA = "0x2917D68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B652C", Offset = "0x13B652C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x2917DB4", Offset = "0x2917DB4", VA = "0x2917DB4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x2917DBC", Offset = "0x2917DBC", VA = "0x2917DBC")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13ACBC4", Offset = "0x13ACBC4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ACBC4", Offset = "0x13ACBC4")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x2917E30", Offset = "0x2917E30", VA = "0x2917E30", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6564", Offset = "0x13B6564")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x2917E7C", Offset = "0x2917E7C", VA = "0x2917E7C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B659C", Offset = "0x13B659C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x2917EC8", Offset = "0x2917EC8", VA = "0x2917EC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B65D4", Offset = "0x13B65D4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x2917F14", Offset = "0x2917F14", VA = "0x2917F14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B660C", Offset = "0x13B660C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x2917F60", Offset = "0x2917F60", VA = "0x2917F60", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x2917F68", Offset = "0x2917F68", VA = "0x2917F68")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13ACC24", Offset = "0x13ACC24")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ACC24", Offset = "0x13ACC24")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x2918E20", Offset = "0x2918E20", VA = "0x2918E20", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6644", Offset = "0x13B6644")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x2918E6C", Offset = "0x2918E6C", VA = "0x2918E6C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B667C", Offset = "0x13B667C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x2918EB8", Offset = "0x2918EB8", VA = "0x2918EB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B66B4", Offset = "0x13B66B4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x2918F04", Offset = "0x2918F04", VA = "0x2918F04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B66EC", Offset = "0x13B66EC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x2918F50", Offset = "0x2918F50", VA = "0x2918F50", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x2918F58", Offset = "0x2918F58", VA = "0x2918F58")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13ACC84", Offset = "0x13ACC84")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ACC84", Offset = "0x13ACC84")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x2921C7C", Offset = "0x2921C7C", VA = "0x2921C7C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6724", Offset = "0x13B6724")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x2921CC8", Offset = "0x2921CC8", VA = "0x2921CC8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B675C", Offset = "0x13B675C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x2921D14", Offset = "0x2921D14", VA = "0x2921D14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6794", Offset = "0x13B6794")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x2921D60", Offset = "0x2921D60", VA = "0x2921D60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B67CC", Offset = "0x13B67CC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x2921DAC", Offset = "0x2921DAC", VA = "0x2921DAC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x2921DB4", Offset = "0x2921DB4", VA = "0x2921DB4")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ACCE4", Offset = "0x13ACCE4")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000101")]
		public class References
		{
			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1F5C", Offset = "0x13B1F5C")]
			public Transform chest;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1F94", Offset = "0x13B1F94")]
			public Transform neck;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1FCC", Offset = "0x13B1FCC")]
			public Transform leftShoulder;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2004", Offset = "0x13B2004")]
			public Transform rightShoulder;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B203C", Offset = "0x13B203C")]
			public Transform leftThigh;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2074", Offset = "0x13B2074")]
			public Transform leftCalf;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B20AC", Offset = "0x13B20AC")]
			public Transform leftFoot;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B20E4", Offset = "0x13B20E4")]
			public Transform leftToes;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B211C", Offset = "0x13B211C")]
			public Transform rightThigh;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2154", Offset = "0x13B2154")]
			public Transform rightCalf;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B218C", Offset = "0x13B218C")]
			public Transform rightFoot;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B21C4", Offset = "0x13B21C4")]
			public Transform rightToes;

			[Token(Token = "0x170000A0")]
			public bool isFilled
			{
				[Token(Token = "0x60006A4")]
				[Address(RVA = "0x292346C", Offset = "0x292346C", VA = "0x292346C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A1")]
			public bool isEmpty
			{
				[Token(Token = "0x60006A5")]
				[Address(RVA = "0x2922FF0", Offset = "0x2922FF0", VA = "0x2922FF0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x2923B08", Offset = "0x2923B08", VA = "0x2923B08")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x2922ACC", Offset = "0x2922ACC", VA = "0x2922ACC")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x2923B00", Offset = "0x2923B00", VA = "0x2923B00")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x13AF6E8", Offset = "0x13AF6E8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF6E8", Offset = "0x13AF6E8")]
		public References references;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF764", Offset = "0x13AF764")]
		public IKSolverVR solver;

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x2922980", Offset = "0x2922980", VA = "0x2922980", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6804", Offset = "0x13B6804")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x29229EC", Offset = "0x29229EC", VA = "0x29229EC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B683C", Offset = "0x13B683C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x2922A58", Offset = "0x2922A58", VA = "0x2922A58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6874", Offset = "0x13B6874")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x2922AA4", Offset = "0x2922AA4", VA = "0x2922AA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B68AC", Offset = "0x13B68AC")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x2922F4C", Offset = "0x2922F4C", VA = "0x2922F4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B68E4", Offset = "0x13B68E4")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x2922F74", Offset = "0x2922F74", VA = "0x2922F74", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x2922F7C", Offset = "0x2922F7C", VA = "0x2922F7C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x29238E8", Offset = "0x29238E8", VA = "0x29238E8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x2923A60", Offset = "0x2923A60", VA = "0x2923A60")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000091")]
	public class FABRIKChain
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AF79C", Offset = "0x13AF79C")]
		public float pull;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AF7B4", Offset = "0x13AF7B4")]
		public float pin;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x2484F30", Offset = "0x2484F30", VA = "0x2484F30")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x2485004", Offset = "0x2485004", VA = "0x2485004")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x2485024", Offset = "0x2485024", VA = "0x2485024")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x24853F4", Offset = "0x24853F4", VA = "0x24853F4")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x24850F8", Offset = "0x24850F8", VA = "0x24850F8")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x24854EC", Offset = "0x24854EC", VA = "0x24854EC")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x248570C", Offset = "0x248570C", VA = "0x248570C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x2485C88", Offset = "0x2485C88", VA = "0x2485C88")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x2485E48", Offset = "0x2485E48", VA = "0x2485E48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x2485F64", Offset = "0x2485F64", VA = "0x2485F64")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000102")]
		public class BendBone
		{
			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B21FC", Offset = "0x13B21FC")]
			public Transform transform;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2234", Offset = "0x13B2234")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B2234", Offset = "0x13B2234")]
			public float weight;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x24890F4", Offset = "0x24890F4", VA = "0x24890F4")]
			public BendBone()
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x2489174", Offset = "0x2489174", VA = "0x2489174")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x24867B4", Offset = "0x24867B4", VA = "0x24867B4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x2486BB8", Offset = "0x2486BB8", VA = "0x2486BB8")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF7CC", Offset = "0x13AF7CC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x13AF804", Offset = "0x13AF804")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF804", Offset = "0x13AF804")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AF804", Offset = "0x13AF804")]
		public float positionWeight;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF87C", Offset = "0x13AF87C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AF87C", Offset = "0x13AF87C")]
		public float bodyWeight;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF8D0", Offset = "0x13AF8D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AF8D0", Offset = "0x13AF8D0")]
		public float thighWeight;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF924", Offset = "0x13AF924")]
		public bool handsPullBody;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x13AF95C", Offset = "0x13AF95C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF95C", Offset = "0x13AF95C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AF95C", Offset = "0x13AF95C")]
		public float rotationWeight;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AF9D4", Offset = "0x13AF9D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AF9D4", Offset = "0x13AF9D4")]
		public float bodyClampWeight;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AFA28", Offset = "0x13AFA28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFA28", Offset = "0x13AFA28")]
		public float headClampWeight;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AFA7C", Offset = "0x13AFA7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFA7C", Offset = "0x13AFA7C")]
		public float bendWeight;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AFAD0", Offset = "0x13AFAD0")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x13AFB08", Offset = "0x13AFB08")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AFB08", Offset = "0x13AFB08")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFB08", Offset = "0x13AFB08")]
		public float CCDWeight;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AFB80", Offset = "0x13AFB80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFB80", Offset = "0x13AFB80")]
		public float roll;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AFBD4", Offset = "0x13AFBD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFBD4", Offset = "0x13AFBD4")]
		public float damper;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AFC2C", Offset = "0x13AFC2C")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x13AFC64", Offset = "0x13AFC64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AFC64", Offset = "0x13AFC64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFC64", Offset = "0x13AFC64")]
		public float postStretchWeight;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AFCDC", Offset = "0x13AFCDC")]
		public float maxStretch;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AFD14", Offset = "0x13AFD14")]
		public float stretchDamper;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AFD4C", Offset = "0x13AFD4C")]
		public bool fixHead;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AFD84", Offset = "0x13AFD84")]
		public Transform[] stretchBones;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x13AFDBC", Offset = "0x13AFDBC")]
		public Vector3 chestDirection;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFDF4", Offset = "0x13AFDF4")]
		public float chestDirectionWeight;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x2485F6C", Offset = "0x2485F6C", VA = "0x2485F6C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x24862F0", Offset = "0x24862F0", VA = "0x24862F0")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x24867EC", Offset = "0x24867EC", VA = "0x24867EC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x2486BE0", Offset = "0x2486BE0", VA = "0x2486BE0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x2487558", Offset = "0x2487558", VA = "0x2487558")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x24878A4", Offset = "0x24878A4", VA = "0x24878A4")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x2487C40", Offset = "0x2487C40", VA = "0x2487C40")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x24886AC", Offset = "0x24886AC", VA = "0x24886AC")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x2487284", Offset = "0x2487284", VA = "0x2487284")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x24888BC", Offset = "0x24888BC", VA = "0x24888BC")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x2488568", Offset = "0x2488568", VA = "0x2488568")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x24883CC", Offset = "0x24883CC", VA = "0x24883CC")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x2488C28", Offset = "0x2488C28", VA = "0x2488C28")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x2488F0C", Offset = "0x2488F0C", VA = "0x2488F0C")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000094")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000103")]
		public class ChildConstraint
		{
			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B22A8", Offset = "0x13B22A8")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B22B8", Offset = "0x13B22B8")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x170000A2")]
			public float nominalDistance
			{
				[Token(Token = "0x60006AC")]
				[Address(RVA = "0x248C128", Offset = "0x248C128", VA = "0x248C128")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7B9C", Offset = "0x13B7B9C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006AD")]
				[Address(RVA = "0x248C130", Offset = "0x248C130", VA = "0x248C130")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7BAC", Offset = "0x13B7BAC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			public bool isRigid
			{
				[Token(Token = "0x60006AE")]
				[Address(RVA = "0x248C138", Offset = "0x248C138", VA = "0x248C138")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7BBC", Offset = "0x13B7BBC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006AF")]
				[Address(RVA = "0x248C140", Offset = "0x248C140", VA = "0x248C140")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7BCC", Offset = "0x13B7BCC")]
				private set
				{
				}
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x248C14C", Offset = "0x248C14C", VA = "0x248C14C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x2489EAC", Offset = "0x2489EAC", VA = "0x2489EAC")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x248A3EC", Offset = "0x248A3EC", VA = "0x248A3EC")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x248BE24", Offset = "0x248BE24", VA = "0x248BE24")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000104")]
		public enum Smoothing
		{
			[Token(Token = "0x40006A6")]
			None,
			[Token(Token = "0x40006A7")]
			Exponential,
			[Token(Token = "0x40006A8")]
			Cubic
		}

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFE0C", Offset = "0x13AFE0C")]
		public float pin;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFE24", Offset = "0x13AFE24")]
		public float pull;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFE3C", Offset = "0x13AFE3C")]
		public float push;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFE54", Offset = "0x13AFE54")]
		public float pushParent;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFE6C", Offset = "0x13AFE6C")]
		public float reach;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40003AB")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x2489224", Offset = "0x2489224", VA = "0x2489224")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x2489320", Offset = "0x2489320", VA = "0x2489320")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x2489470", Offset = "0x2489470", VA = "0x2489470")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x24895A4", Offset = "0x24895A4", VA = "0x24895A4")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x2489680", Offset = "0x2489680", VA = "0x2489680")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x2489790", Offset = "0x2489790", VA = "0x2489790")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x2489F04", Offset = "0x2489F04", VA = "0x2489F04")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x248992C", Offset = "0x248992C", VA = "0x248992C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x248A5F0", Offset = "0x248A5F0", VA = "0x248A5F0")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x248A994", Offset = "0x248A994", VA = "0x248A994")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x248AD78", Offset = "0x248AD78", VA = "0x248AD78")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x248B2FC", Offset = "0x248B2FC", VA = "0x248B2FC")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x248B8CC", Offset = "0x248B8CC", VA = "0x248B8CC")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x248BB64", Offset = "0x248BB64", VA = "0x248BB64")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x248B7C4", Offset = "0x248B7C4", VA = "0x248B7C4")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x248B0E4", Offset = "0x248B0E4", VA = "0x248B0E4")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x248B74C", Offset = "0x248B74C", VA = "0x248B74C")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x248BC4C", Offset = "0x248BC4C", VA = "0x248BC4C")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x248B66C", Offset = "0x248B66C", VA = "0x248B66C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x248BA4C", Offset = "0x248BA4C", VA = "0x248BA4C")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000095")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFE84", Offset = "0x13AFE84")]
		public float weight;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AFE9C", Offset = "0x13AFE9C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000032")]
		public bool initiated
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x3061154", Offset = "0x3061154", VA = "0x3061154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B691C", Offset = "0x13B691C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x306115C", Offset = "0x306115C", VA = "0x306115C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B692C", Offset = "0x13B692C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x3060F8C", Offset = "0x3060F8C", VA = "0x3060F8C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x3061168", Offset = "0x3061168", VA = "0x3061168")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x30611EC", Offset = "0x30611EC", VA = "0x30611EC")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x30612A0", Offset = "0x30612A0", VA = "0x30612A0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x30612F0", Offset = "0x30612F0", VA = "0x30612F0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x3061844", Offset = "0x3061844", VA = "0x3061844")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x3061A7C", Offset = "0x3061A7C", VA = "0x3061A7C")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x3061F18", Offset = "0x3061F18", VA = "0x3061F18")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x3061614", Offset = "0x3061614", VA = "0x3061614")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x306172C", Offset = "0x306172C", VA = "0x306172C")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000096")]
	public class IKEffector
	{
		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFEAC", Offset = "0x13AFEAC")]
		public float positionWeight;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFEC4", Offset = "0x13AFEC4")]
		public float rotationWeight;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AFEDC", Offset = "0x13AFEDC")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFEEC", Offset = "0x13AFEEC")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000033")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x30625C8", Offset = "0x30625C8", VA = "0x30625C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B693C", Offset = "0x13B693C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x30625D0", Offset = "0x30625D0", VA = "0x30625D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B694C", Offset = "0x13B694C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x3062560", Offset = "0x3062560", VA = "0x3062560")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x30625DC", Offset = "0x30625DC", VA = "0x30625DC")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x30626B0", Offset = "0x30626B0", VA = "0x30626B0")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x306281C", Offset = "0x306281C", VA = "0x306281C")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x30629C4", Offset = "0x30629C4", VA = "0x30629C4")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x3062CC0", Offset = "0x3062CC0", VA = "0x3062CC0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x3062F84", Offset = "0x3062F84", VA = "0x3062F84")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x30630BC", Offset = "0x30630BC", VA = "0x30630BC")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x3063168", Offset = "0x3063168", VA = "0x3063168")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x30637A8", Offset = "0x30637A8", VA = "0x30637A8")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x3063818", Offset = "0x3063818", VA = "0x3063818")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x3063A24", Offset = "0x3063A24", VA = "0x3063A24")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x3063D58", Offset = "0x3063D58", VA = "0x3063D58")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000097")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000105")]
		public class BoneMap
		{
			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000A4")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60006B5")]
				[Address(RVA = "0x3064558", Offset = "0x3064558", VA = "0x3064558")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A5")]
			public bool isNodeBone
			{
				[Token(Token = "0x60006B8")]
				[Address(RVA = "0x30646C4", Offset = "0x30646C4", VA = "0x30646C4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A6")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60006CC")]
				[Address(RVA = "0x3064CC8", Offset = "0x3064CC8", VA = "0x3064CC8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x306450C", Offset = "0x306450C", VA = "0x306450C")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x3064624", Offset = "0x3064624", VA = "0x3064624")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x3064674", Offset = "0x3064674", VA = "0x3064674")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x30646D4", Offset = "0x30646D4", VA = "0x30646D4")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x30647BC", Offset = "0x30647BC", VA = "0x30647BC")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x30647C4", Offset = "0x30647C4", VA = "0x30647C4")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x3064954", Offset = "0x3064954", VA = "0x3064954")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x3064A60", Offset = "0x3064A60", VA = "0x3064A60")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x3064B18", Offset = "0x3064B18", VA = "0x3064B18")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x3064EEC", Offset = "0x3064EEC", VA = "0x3064EEC")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x3064F24", Offset = "0x3064F24", VA = "0x3064F24")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x3064F5C", Offset = "0x3064F5C", VA = "0x3064F5C")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x3064F84", Offset = "0x3064F84", VA = "0x3064F84")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x30650AC", Offset = "0x30650AC", VA = "0x30650AC")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x30653E4", Offset = "0x30653E4", VA = "0x30653E4")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x3065414", Offset = "0x3065414", VA = "0x3065414")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x30655AC", Offset = "0x30655AC", VA = "0x30655AC")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x306561C", Offset = "0x306561C", VA = "0x306561C")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x3065860", Offset = "0x3065860", VA = "0x3065860")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x3065A88", Offset = "0x3065A88", VA = "0x3065A88")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x3065BA0", Offset = "0x3065BA0", VA = "0x3065BA0")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x30651EC", Offset = "0x30651EC", VA = "0x30651EC")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x3065D30", Offset = "0x3065D30", VA = "0x3065D30")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x30642C0", Offset = "0x30642C0", VA = "0x30642C0", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x30642C8", Offset = "0x30642C8", VA = "0x30642C8", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x30642CC", Offset = "0x30642CC", VA = "0x30642CC")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x30643FC", Offset = "0x30643FC", VA = "0x30643FC")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x3064504", Offset = "0x3064504", VA = "0x3064504")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000098")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFF04", Offset = "0x13AFF04")]
		public float maintainRotationWeight;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x3065D4C", Offset = "0x3065D4C", VA = "0x3065D4C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x3065DF8", Offset = "0x3065DF8", VA = "0x3065DF8")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x3065E88", Offset = "0x3065E88", VA = "0x3065E88")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x3065F34", Offset = "0x3065F34", VA = "0x3065F34")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x3065F4C", Offset = "0x3065F4C", VA = "0x3065F4C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x3065F68", Offset = "0x3065F68", VA = "0x3065F68", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x3066014", Offset = "0x3066014", VA = "0x3066014")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x306602C", Offset = "0x306602C", VA = "0x306602C")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000099")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000106")]
		public enum BoneMapType
		{
			[Token(Token = "0x40006C0")]
			Parent,
			[Token(Token = "0x40006C1")]
			Bone1,
			[Token(Token = "0x40006C2")]
			Bone2,
			[Token(Token = "0x40006C3")]
			Bone3
		}

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFF1C", Offset = "0x13AFF1C")]
		public float maintainRotationWeight;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFF34", Offset = "0x13AFF34")]
		public float weight;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x3066050", Offset = "0x3066050", VA = "0x3066050", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x30660D4", Offset = "0x30660D4", VA = "0x30660D4")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x30661A8", Offset = "0x30661A8", VA = "0x30661A8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x30664FC", Offset = "0x30664FC", VA = "0x30664FC")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x306662C", Offset = "0x306662C", VA = "0x306662C")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x3066794", Offset = "0x3066794", VA = "0x3066794")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x30667F8", Offset = "0x30667F8", VA = "0x30667F8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x30668A0", Offset = "0x30668A0", VA = "0x30668A0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x3066958", Offset = "0x3066958", VA = "0x3066958", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x3066C20", Offset = "0x3066C20", VA = "0x3066C20")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x3066CD8", Offset = "0x3066CD8", VA = "0x3066CD8")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009A")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFF4C", Offset = "0x13AFF4C")]
		public int iterations;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFF64", Offset = "0x13AFF64")]
		public float twistWeight;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x3066E40", Offset = "0x3066E40", VA = "0x3066E40", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x3067138", Offset = "0x3067138", VA = "0x3067138")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x3067290", Offset = "0x3067290", VA = "0x3067290")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x3067430", Offset = "0x3067430", VA = "0x3067430")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x30674B0", Offset = "0x30674B0", VA = "0x30674B0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x3067518", Offset = "0x3067518", VA = "0x3067518")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x3067598", Offset = "0x3067598", VA = "0x3067598", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x3067C70", Offset = "0x3067C70", VA = "0x3067C70")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x3067CA8", Offset = "0x3067CA8", VA = "0x3067CA8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x3067F88", Offset = "0x3067F88", VA = "0x3067F88")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x3068334", Offset = "0x3068334", VA = "0x3068334")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x3068420", Offset = "0x3068420", VA = "0x3068420")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x30684E8", Offset = "0x30684E8", VA = "0x30684E8")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009B")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000107")]
		public class Point
		{
			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B22C8", Offset = "0x13B22C8")]
			public float weight;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x306A048", Offset = "0x306A048", VA = "0x306A048")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x306A098", Offset = "0x306A098", VA = "0x306A098")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x306A220", Offset = "0x306A220", VA = "0x306A220")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x306A258", Offset = "0x306A258", VA = "0x306A258")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x306A290", Offset = "0x306A290", VA = "0x306A290")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x306A2E0", Offset = "0x306A2E0", VA = "0x306A2E0")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x3069AF0", Offset = "0x3069AF0", VA = "0x3069AF0")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000108")]
		public class Bone : Point
		{
			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x170000A7")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x60006D5")]
				[Address(RVA = "0x30690AC", Offset = "0x30690AC", VA = "0x30690AC")]
				get
				{
					return null;
				}
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x30691A8", Offset = "0x30691A8", VA = "0x30691A8")]
				set
				{
				}
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x306923C", Offset = "0x306923C", VA = "0x306923C")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x30694FC", Offset = "0x30694FC", VA = "0x30694FC")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x30697DC", Offset = "0x30697DC", VA = "0x30697DC")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x3069A44", Offset = "0x3069A44", VA = "0x3069A44")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x3069A6C", Offset = "0x3069A6C", VA = "0x3069A6C")]
			public Bone()
			{
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x3069B70", Offset = "0x3069B70", VA = "0x3069B70")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x3069C10", Offset = "0x3069C10", VA = "0x3069C10")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000109")]
		public class Node : Point
		{
			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x3069FD0", Offset = "0x3069FD0", VA = "0x3069FD0")]
			public Node()
			{
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x3069FD4", Offset = "0x3069FD4", VA = "0x3069FD4")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x306A004", Offset = "0x306A004", VA = "0x306A004")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x200010A")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x200010B")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13AFF8C", Offset = "0x13AFF8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13AFF8C", Offset = "0x13AFF8C")]
		public float IKPositionWeight;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AFFE0", Offset = "0x13AFFE0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000034")]
		public bool initiated
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x3068AFC", Offset = "0x3068AFC", VA = "0x3068AFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B695C", Offset = "0x13B695C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x3068B04", Offset = "0x3068B04", VA = "0x3068B04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B696C", Offset = "0x13B696C")]
			private set
			{
			}
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x30687C8", Offset = "0x30687C8", VA = "0x30687C8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B5")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x3060DCC", Offset = "0x3060DCC", VA = "0x3060DCC")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x3060CF4", Offset = "0x3060CF4", VA = "0x3060CF4")]
		public void Update()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x3068A50", Offset = "0x3068A50", VA = "0x3068A50", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x3068A5C", Offset = "0x3068A5C", VA = "0x3068A5C")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x3068A68", Offset = "0x3068A68", VA = "0x3068A68")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x3068A70", Offset = "0x3068A70", VA = "0x3068A70")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x3068AF4", Offset = "0x3068AF4", VA = "0x3068AF4")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60003C0")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60003C1")]
		public abstract void FixTransforms();

		[Token(Token = "0x60003C2")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60003C3")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60003C4")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x3068B10", Offset = "0x3068B10", VA = "0x3068B10")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x3068B28", Offset = "0x3068B28", VA = "0x3068B28")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x3068C64", Offset = "0x3068C64", VA = "0x3068C64")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x3068D10", Offset = "0x3068D10", VA = "0x3068D10")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x3069094", Offset = "0x3069094", VA = "0x3069094")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009C")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0028", Offset = "0x13B0028")]
		public float poleWeight;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0040", Offset = "0x13B0040")]
		public float clampWeight;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0058", Offset = "0x13B0058")]
		public int clampSmoothing;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000035")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x306A47C", Offset = "0x306A47C", VA = "0x306A47C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000036")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x306A548", Offset = "0x306A548", VA = "0x306A548")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000037")]
		protected override int minBones
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x306B2D8", Offset = "0x306B2D8", VA = "0x306B2D8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000038")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x306B87C", Offset = "0x306B87C", VA = "0x306B87C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x306A37C", Offset = "0x306A37C", VA = "0x306A37C")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x306A614", Offset = "0x306A614", VA = "0x306A614", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x306A894", Offset = "0x306A894", VA = "0x306A894", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x306B224", Offset = "0x306B224", VA = "0x306B224")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x306AE4C", Offset = "0x306AE4C", VA = "0x306AE4C")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x306B2E0", Offset = "0x306B2E0", VA = "0x306B2E0")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x306B8F0", Offset = "0x306B8F0", VA = "0x306B8F0")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009D")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0070", Offset = "0x13B0070")]
		public float IKRotationWeight;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x306BA0C", Offset = "0x306BA0C", VA = "0x306BA0C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x306BDC8", Offset = "0x306BDC8", VA = "0x306BDC8")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x306BE7C", Offset = "0x306BE7C", VA = "0x306BE7C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x306C014", Offset = "0x306C014", VA = "0x306C014", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x306C1AC", Offset = "0x306C1AC", VA = "0x306C1AC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x306C1F8", Offset = "0x306C1F8", VA = "0x306C1F8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x306C258", Offset = "0x306C258", VA = "0x306C258", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x306C5C8", Offset = "0x306C5C8", VA = "0x306C5C8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x306C5F4", Offset = "0x306C5F4", VA = "0x306C5F4")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x306C2BC", Offset = "0x306C2BC", VA = "0x306C2BC")]
		private void Read()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x306C660", Offset = "0x306C660", VA = "0x306C660")]
		private void Write()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x306C7EC", Offset = "0x306C7EC", VA = "0x306C7EC")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009E")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x306C99C", Offset = "0x306C99C", VA = "0x306C99C")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x306CA4C", Offset = "0x306CA4C", VA = "0x306CA4C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x306D040", Offset = "0x306D040", VA = "0x306D040", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x306D790", Offset = "0x306D790", VA = "0x306D790")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x306DEE4", Offset = "0x306DEE4", VA = "0x306DEE4")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009F")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000039")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x306F120", Offset = "0x306F120", VA = "0x306F120", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x306DEE8", Offset = "0x306DEE8", VA = "0x306DEE8")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x306E630", Offset = "0x306E630", VA = "0x306E630")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x306E768", Offset = "0x306E768", VA = "0x306E768", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x306E800", Offset = "0x306E800", VA = "0x306E800", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x306EDC0", Offset = "0x306EDC0", VA = "0x306EDC0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x306F128", Offset = "0x306F128", VA = "0x306F128")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x306DFBC", Offset = "0x306DFBC", VA = "0x306DFBC")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x306E714", Offset = "0x306E714", VA = "0x306E714")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x306F0C4", Offset = "0x306F0C4", VA = "0x306F0C4")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x306E458", Offset = "0x306E458", VA = "0x306E458")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x306F968", Offset = "0x306F968", VA = "0x306F968")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x306FA78", Offset = "0x306FA78", VA = "0x306FA78")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x306FBA4", Offset = "0x306FBA4", VA = "0x306FBA4")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x306FCBC", Offset = "0x306FCBC", VA = "0x306FCBC")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x306EB28", Offset = "0x306EB28", VA = "0x306EB28")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x306EC74", Offset = "0x306EC74", VA = "0x306EC74")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x306FEA8", Offset = "0x306FEA8", VA = "0x306FEA8")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x306F3E0", Offset = "0x306F3E0", VA = "0x306F3E0")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x306E704", Offset = "0x306E704", VA = "0x306E704")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x3070610", Offset = "0x3070610", VA = "0x3070610")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x307007C", Offset = "0x307007C", VA = "0x307007C")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x306F240", Offset = "0x306F240", VA = "0x306F240")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x306F31C", Offset = "0x306F31C", VA = "0x306F31C")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x30706DC", Offset = "0x30706DC", VA = "0x30706DC")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A0")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0088", Offset = "0x13B0088")]
		public float rootPin;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x3070768", Offset = "0x3070768", VA = "0x3070768", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x3071140", Offset = "0x3071140", VA = "0x3071140", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x30711D8", Offset = "0x30711D8", VA = "0x30711D8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x3071278", Offset = "0x3071278", VA = "0x3071278", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x3071388", Offset = "0x3071388", VA = "0x3071388")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x3071424", Offset = "0x3071424", VA = "0x3071424", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x307198C", Offset = "0x307198C", VA = "0x307198C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x3071BA4", Offset = "0x3071BA4", VA = "0x3071BA4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x3071A3C", Offset = "0x3071A3C", VA = "0x3071A3C")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x3071658", Offset = "0x3071658", VA = "0x3071658")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x3071C3C", Offset = "0x3071C3C", VA = "0x3071C3C")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A1")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B00A0", Offset = "0x13B00A0")]
		public int iterations;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x3071CC0", Offset = "0x3071CC0", VA = "0x3071CC0")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x3071DB4", Offset = "0x3071DB4", VA = "0x3071DB4")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x3071E10", Offset = "0x3071E10", VA = "0x3071E10")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x3062504", Offset = "0x3062504", VA = "0x3062504")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x3061594", Offset = "0x3061594", VA = "0x3061594")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x3071F44", Offset = "0x3071F44", VA = "0x3071F44", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x30720E4", Offset = "0x30720E4", VA = "0x30720E4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x3072258", Offset = "0x3072258", VA = "0x3072258", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x307245C", Offset = "0x307245C", VA = "0x307245C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x307252C", Offset = "0x307252C", VA = "0x307252C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x3072608", Offset = "0x3072608", VA = "0x3072608", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x3072778", Offset = "0x3072778", VA = "0x3072778", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x3072930", Offset = "0x3072930", VA = "0x3072930", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x3072B6C", Offset = "0x3072B6C", VA = "0x3072B6C", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x3072E2C", Offset = "0x3072E2C", VA = "0x3072E2C", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x3072E70", Offset = "0x3072E70", VA = "0x3072E70", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x3072F54", Offset = "0x3072F54", VA = "0x3072F54")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A2")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000434")]
		Body,
		[Token(Token = "0x4000435")]
		LeftShoulder,
		[Token(Token = "0x4000436")]
		RightShoulder,
		[Token(Token = "0x4000437")]
		LeftThigh,
		[Token(Token = "0x4000438")]
		RightThigh,
		[Token(Token = "0x4000439")]
		LeftHand,
		[Token(Token = "0x400043A")]
		RightHand,
		[Token(Token = "0x400043B")]
		LeftFoot,
		[Token(Token = "0x400043C")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x20000A3")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x400043E")]
		LeftArm,
		[Token(Token = "0x400043F")]
		RightArm,
		[Token(Token = "0x4000440")]
		LeftLeg,
		[Token(Token = "0x4000441")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x20000A4")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B00B8", Offset = "0x13B00B8")]
		public float spineStiffness;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B00D0", Offset = "0x13B00D0")]
		public float pullBodyVertical;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B00E8", Offset = "0x13B00E8")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B0100", Offset = "0x13B0100")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700003A")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x3073070", Offset = "0x3073070", VA = "0x3073070")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x3073078", Offset = "0x3073078", VA = "0x3073078")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x3073080", Offset = "0x3073080", VA = "0x3073080")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x3073088", Offset = "0x3073088", VA = "0x3073088")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x3073090", Offset = "0x3073090", VA = "0x3073090")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x3073098", Offset = "0x3073098", VA = "0x3073098")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x30730A0", Offset = "0x30730A0", VA = "0x30730A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x30730A8", Offset = "0x30730A8", VA = "0x30730A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x30730B0", Offset = "0x30730B0", VA = "0x30730B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x30730B8", Offset = "0x30730B8", VA = "0x30730B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x30730F0", Offset = "0x30730F0", VA = "0x30730F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x3073128", Offset = "0x3073128", VA = "0x3073128")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x3073160", Offset = "0x3073160", VA = "0x3073160")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x3073198", Offset = "0x3073198", VA = "0x3073198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x30731CC", Offset = "0x30731CC", VA = "0x30731CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x3073204", Offset = "0x3073204", VA = "0x3073204")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x307323C", Offset = "0x307323C", VA = "0x307323C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x3073274", Offset = "0x3073274", VA = "0x3073274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x30754A0", Offset = "0x30754A0", VA = "0x30754A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B697C", Offset = "0x13B697C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x30754AC", Offset = "0x30754AC", VA = "0x30754AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B698C", Offset = "0x13B698C")]
			private set
			{
			}
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x30732A8", Offset = "0x30732A8", VA = "0x30732A8")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x30733B4", Offset = "0x30733B4", VA = "0x30733B4")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x30732FC", Offset = "0x30732FC", VA = "0x30732FC")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x3073490", Offset = "0x3073490", VA = "0x3073490")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x305F910", Offset = "0x305F910", VA = "0x305F910")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x3073560", Offset = "0x3073560", VA = "0x3073560")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x3073618", Offset = "0x3073618", VA = "0x3073618")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x30736CC", Offset = "0x30736CC", VA = "0x30736CC")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x3073780", Offset = "0x3073780", VA = "0x3073780")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x3073788", Offset = "0x3073788", VA = "0x3073788")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x30737BC", Offset = "0x30737BC", VA = "0x30737BC")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x3073884", Offset = "0x3073884", VA = "0x3073884", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x3073A18", Offset = "0x3073A18", VA = "0x3073A18")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x3074DC4", Offset = "0x3074DC4", VA = "0x3074DC4")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x3075258", Offset = "0x3075258", VA = "0x3075258")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x30752B8", Offset = "0x30752B8", VA = "0x30752B8")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x30750D8", Offset = "0x30750D8", VA = "0x30750D8")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x3075198", Offset = "0x3075198", VA = "0x3075198")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x30754B8", Offset = "0x30754B8", VA = "0x30754B8")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x3075594", Offset = "0x3075594", VA = "0x3075594", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x30756D8", Offset = "0x30756D8", VA = "0x30756D8")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x3075868", Offset = "0x3075868", VA = "0x3075868")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x3075A68", Offset = "0x3075A68", VA = "0x3075A68")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x3075C68", Offset = "0x3075C68", VA = "0x3075C68", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x3075F98", Offset = "0x3075F98", VA = "0x3075F98", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x3076098", Offset = "0x3076098", VA = "0x3076098")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A5")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x1700004D")]
		protected virtual int minBones
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x3076924", Offset = "0x3076924", VA = "0x3076924", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004E")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x307692C", Offset = "0x307692C", VA = "0x307692C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x3076934", Offset = "0x3076934", VA = "0x3076934", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000050")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x3076944", Offset = "0x3076944", VA = "0x3076944", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000051")]
		protected float positionOffset
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x306D6CC", Offset = "0x306D6CC", VA = "0x306D6CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x30760A4", Offset = "0x30760A4", VA = "0x30760A4")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x3076250", Offset = "0x3076250", VA = "0x3076250")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x30763B4", Offset = "0x30763B4", VA = "0x30763B4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x307641C", Offset = "0x307641C", VA = "0x307641C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x3076498", Offset = "0x3076498", VA = "0x3076498", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x3076828", Offset = "0x3076828", VA = "0x3076828", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x3076830", Offset = "0x3076830", VA = "0x3076830", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x307693C", Offset = "0x307693C", VA = "0x307693C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x3076940", Offset = "0x3076940", VA = "0x3076940", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x306CACC", Offset = "0x306CACC", VA = "0x306CACC")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x306D334", Offset = "0x306D334", VA = "0x306D334")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x3076A78", Offset = "0x3076A78", VA = "0x3076A78")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x306B984", Offset = "0x306B984", VA = "0x306B984")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A6")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0110", Offset = "0x13B0110")]
		public float IKRotationWeight;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x3076D2C", Offset = "0x3076D2C", VA = "0x3076D2C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x30770E8", Offset = "0x30770E8", VA = "0x30770E8")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x307719C", Offset = "0x307719C", VA = "0x307719C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x3077334", Offset = "0x3077334", VA = "0x3077334", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x30774CC", Offset = "0x30774CC", VA = "0x30774CC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x3077518", Offset = "0x3077518", VA = "0x3077518", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x3077578", Offset = "0x3077578", VA = "0x3077578", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x30778E8", Offset = "0x30778E8", VA = "0x30778E8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x3077914", Offset = "0x3077914", VA = "0x3077914")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x30775DC", Offset = "0x30775DC", VA = "0x30775DC")]
		private void Read()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x3077A1C", Offset = "0x3077A1C", VA = "0x3077A1C")]
		private void Write()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x3077BA8", Offset = "0x3077BA8", VA = "0x3077BA8")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A7")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x200010C")]
		public enum BendModifier
		{
			[Token(Token = "0x40006D4")]
			Animation,
			[Token(Token = "0x40006D5")]
			Target,
			[Token(Token = "0x40006D6")]
			Parent,
			[Token(Token = "0x40006D7")]
			Arm,
			[Token(Token = "0x40006D8")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x200010D")]
		public struct AxisDirection
		{
			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x2F59888", Offset = "0x2F59888", VA = "0x2F59888")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0128", Offset = "0x13B0128")]
		public float maintainRotationWeight;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0140", Offset = "0x13B0140")]
		public float bendModifierWeight;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000052")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x2F5986C", Offset = "0x2F5986C", VA = "0x2F5986C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x2F58114", Offset = "0x2F58114", VA = "0x2F58114")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x2F58164", Offset = "0x2F58164", VA = "0x2F58164")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x2F58278", Offset = "0x2F58278", VA = "0x2F58278", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x2F588E8", Offset = "0x2F588E8", VA = "0x2F588E8", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x2F594C4", Offset = "0x2F594C4", VA = "0x2F594C4", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x2F5960C", Offset = "0x2F5960C", VA = "0x2F5960C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x2F597CC", Offset = "0x2F597CC", VA = "0x2F597CC")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x2F585F4", Offset = "0x2F585F4", VA = "0x2F585F4")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x2F58A14", Offset = "0x2F58A14", VA = "0x2F58A14")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000A8")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200010E")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x170000A8")]
			public Vector3 forward
			{
				[Token(Token = "0x60006EE")]
				[Address(RVA = "0x2F5B800", Offset = "0x2F5B800", VA = "0x2F5B800")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x2F5BFA4", Offset = "0x2F5BFA4", VA = "0x2F5BFA4")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x2F5AB50", Offset = "0x2F5AB50", VA = "0x2F5AB50")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x2F5AED8", Offset = "0x2F5AED8", VA = "0x2F5AED8")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x2F5BC04", Offset = "0x2F5BC04", VA = "0x2F5BC04")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0158", Offset = "0x13B0158")]
		public float bodyWeight;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0170", Offset = "0x13B0170")]
		public float headWeight;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0188", Offset = "0x13B0188")]
		public float eyesWeight;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B01A0", Offset = "0x13B01A0")]
		public float clampWeight;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B01B8", Offset = "0x13B01B8")]
		public float clampWeightHead;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B01D0", Offset = "0x13B01D0")]
		public float clampWeightEyes;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B01E8", Offset = "0x13B01E8")]
		public int clampSmoothing;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x17000053")]
		private bool spineIsValid
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x2F5A234", Offset = "0x2F5A234", VA = "0x2F5A234")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x2F5A40C", Offset = "0x2F5A40C", VA = "0x2F5A40C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		private bool headIsValid
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x2F5A318", Offset = "0x2F5A318", VA = "0x2F5A318")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		private bool headIsEmpty
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x2F5A430", Offset = "0x2F5A430", VA = "0x2F5A430")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		private bool eyesIsValid
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x2F5A328", Offset = "0x2F5A328", VA = "0x2F5A328")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x2F5A4AC", Offset = "0x2F5A4AC", VA = "0x2F5A4AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x2F598E8", Offset = "0x2F598E8", VA = "0x2F598E8")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x2F5996C", Offset = "0x2F5996C", VA = "0x2F5996C")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x2F59A18", Offset = "0x2F59A18", VA = "0x2F59A18")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x2F59AE0", Offset = "0x2F59AE0", VA = "0x2F59AE0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x2F59BCC", Offset = "0x2F59BCC", VA = "0x2F59BCC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x2F59CD8", Offset = "0x2F59CD8", VA = "0x2F59CD8")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x2F59E20", Offset = "0x2F59E20", VA = "0x2F59E20", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x2F59F50", Offset = "0x2F59F50", VA = "0x2F59F50", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x2F5A094", Offset = "0x2F5A094", VA = "0x2F5A094", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x2F5A4D0", Offset = "0x2F5A4D0", VA = "0x2F5A4D0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x2F5A738", Offset = "0x2F5A738", VA = "0x2F5A738", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x2F5A8D8", Offset = "0x2F5A8D8", VA = "0x2F5A8D8")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x2F5AB84", Offset = "0x2F5AB84", VA = "0x2F5AB84", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x2F5B014", Offset = "0x2F5B014", VA = "0x2F5B014", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x2F5B118", Offset = "0x2F5B118", VA = "0x2F5B118")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x2F5B344", Offset = "0x2F5B344", VA = "0x2F5B344")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x2F5B5A0", Offset = "0x2F5B5A0", VA = "0x2F5B5A0")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x2F5B8CC", Offset = "0x2F5B8CC", VA = "0x2F5B8CC")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x2F5A9A0", Offset = "0x2F5A9A0", VA = "0x2F5A9A0")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x2F5BD6C", Offset = "0x2F5BD6C", VA = "0x2F5BD6C")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A9")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200010F")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x2F5D5F8", Offset = "0x2F5D5F8", VA = "0x2F5D5F8")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x2F5E1A0", Offset = "0x2F5E1A0", VA = "0x2F5E1A0")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x2F581AC", Offset = "0x2F581AC", VA = "0x2F581AC")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x2F5E268", Offset = "0x2F5E268", VA = "0x2F5E268")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0200", Offset = "0x13B0200")]
		public float IKRotationWeight;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x2F5BFAC", Offset = "0x2F5BFAC", VA = "0x2F5BFAC")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x2F5C19C", Offset = "0x2F5C19C", VA = "0x2F5C19C")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x2F5C350", Offset = "0x2F5C350", VA = "0x2F5C350")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x2F5C35C", Offset = "0x2F5C35C", VA = "0x2F5C35C")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x2F5C3E0", Offset = "0x2F5C3E0", VA = "0x2F5C3E0")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x2F5C3EC", Offset = "0x2F5C3EC", VA = "0x2F5C3EC")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x2F5C3F4", Offset = "0x2F5C3F4", VA = "0x2F5C3F4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x2F5C51C", Offset = "0x2F5C51C", VA = "0x2F5C51C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x2F5C63C", Offset = "0x2F5C63C", VA = "0x2F5C63C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x2F5C688", Offset = "0x2F5C688", VA = "0x2F5C688", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x2F5C6E8", Offset = "0x2F5C6E8", VA = "0x2F5C6E8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x2F5CAF4", Offset = "0x2F5CAF4", VA = "0x2F5CAF4")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x2F5CB74", Offset = "0x2F5CB74", VA = "0x2F5CB74")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x2F5D11C", Offset = "0x2F5D11C", VA = "0x2F5D11C")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x2F5D334", Offset = "0x2F5D334", VA = "0x2F5D334", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x2F5D4F0", Offset = "0x2F5D4F0", VA = "0x2F5D4F0")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x2F5D46C", Offset = "0x2F5D46C", VA = "0x2F5D46C")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x2F5D798", Offset = "0x2F5D798", VA = "0x2F5D798", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x2F5E25C", Offset = "0x2F5E25C", VA = "0x2F5E25C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x2F5E260", Offset = "0x2F5E260", VA = "0x2F5E260", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x2F5E264", Offset = "0x2F5E264", VA = "0x2F5E264", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x2F5DEA4", Offset = "0x2F5DEA4", VA = "0x2F5DEA4")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x2F59698", Offset = "0x2F59698", VA = "0x2F59698")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AA")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000110")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x200013E")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000855")]
				YawPitch,
				[Token(Token = "0x4000856")]
				FromTo
			}

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B22E0", Offset = "0x13B22E0")]
			public Transform target;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2318", Offset = "0x13B2318")]
			public Transform bendGoal;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2350", Offset = "0x13B2350")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B2350", Offset = "0x13B2350")]
			public float positionWeight;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B23A4", Offset = "0x13B23A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B23A4", Offset = "0x13B23A4")]
			public float rotationWeight;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B23F8", Offset = "0x13B23F8")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2430", Offset = "0x13B2430")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B2430", Offset = "0x13B2430")]
			public float shoulderRotationWeight;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2484", Offset = "0x13B2484")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B2484", Offset = "0x13B2484")]
			public float shoulderTwistWeight;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B24D8", Offset = "0x13B24D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B24D8", Offset = "0x13B24D8")]
			public float bendGoalWeight;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B252C", Offset = "0x13B252C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B252C", Offset = "0x13B252C")]
			public float swivelOffset;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2588", Offset = "0x13B2588")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B25C0", Offset = "0x13B25C0")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B25F8", Offset = "0x13B25F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B25F8", Offset = "0x13B25F8")]
			public float armLengthMlp;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2650", Offset = "0x13B2650")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B26C8", Offset = "0x13B26C8")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B26D8", Offset = "0x13B26D8")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40006F8")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x40006F9")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000A9")]
			public Vector3 position
			{
				[Token(Token = "0x60006F3")]
				[Address(RVA = "0x2F66F5C", Offset = "0x2F66F5C", VA = "0x2F66F5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7BDC", Offset = "0x13B7BDC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006F4")]
				[Address(RVA = "0x2F66F68", Offset = "0x2F66F68", VA = "0x2F66F68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7BEC", Offset = "0x13B7BEC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AA")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006F5")]
				[Address(RVA = "0x2F66F74", Offset = "0x2F66F74", VA = "0x2F66F74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7BFC", Offset = "0x13B7BFC")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006F6")]
				[Address(RVA = "0x2F66F80", Offset = "0x2F66F80", VA = "0x2F66F80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7C0C", Offset = "0x13B7C0C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AB")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60006F7")]
				[Address(RVA = "0x2F66F8C", Offset = "0x2F66F8C", VA = "0x2F66F8C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x2F66FC0", Offset = "0x2F66FC0", VA = "0x2F66FC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AD")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60006F9")]
				[Address(RVA = "0x2F67000", Offset = "0x2F67000", VA = "0x2F67000")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private VirtualBone hand
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x2F6704C", Offset = "0x2F6704C", VA = "0x2F6704C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x2F67098", Offset = "0x2F67098", VA = "0x2F67098", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x2F67850", Offset = "0x2F67850", VA = "0x2F67850", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x2F67A44", Offset = "0x2F67A44", VA = "0x2F67A44", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x2F67AF0", Offset = "0x2F67AF0", VA = "0x2F67AF0")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x2F64E70", Offset = "0x2F64E70", VA = "0x2F64E70")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x2F68F18", Offset = "0x2F68F18", VA = "0x2F68F18", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x2F68F88", Offset = "0x2F68F88", VA = "0x2F68F88", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x2F67F08", Offset = "0x2F67F08", VA = "0x2F67F08")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x2F68214", Offset = "0x2F68214", VA = "0x2F68214")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x2F691A8", Offset = "0x2F691A8", VA = "0x2F691A8")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x2F66C20", Offset = "0x2F66C20", VA = "0x2F66C20")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000111")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B26E8", Offset = "0x13B26E8")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B26F8", Offset = "0x13B26F8")]
			private float <mag>k__BackingField;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x170000AF")]
			public float sqrMag
			{
				[Token(Token = "0x600070B")]
				[Address(RVA = "0x2F69374", Offset = "0x2F69374", VA = "0x2F69374")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7C1C", Offset = "0x13B7C1C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600070C")]
				[Address(RVA = "0x2F6937C", Offset = "0x2F6937C", VA = "0x2F6937C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7C2C", Offset = "0x13B7C2C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B0")]
			public float mag
			{
				[Token(Token = "0x600070D")]
				[Address(RVA = "0x2F69384", Offset = "0x2F69384", VA = "0x2F69384")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7C3C", Offset = "0x13B7C3C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600070E")]
				[Address(RVA = "0x2F6938C", Offset = "0x2F6938C", VA = "0x2F6938C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7C4C", Offset = "0x13B7C4C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000706")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000707")]
			public abstract void PreSolve();

			[Token(Token = "0x6000708")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000709")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x600070A")]
			public abstract void ResetOffsets();

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x2F626AC", Offset = "0x2F626AC", VA = "0x2F626AC")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x2F69680", Offset = "0x2F69680", VA = "0x2F69680")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x2F697EC", Offset = "0x2F697EC", VA = "0x2F697EC")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x2F69A7C", Offset = "0x2F69A7C", VA = "0x2F69A7C")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x2F6465C", Offset = "0x2F6465C", VA = "0x2F6465C")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x2F68D78", Offset = "0x2F68D78", VA = "0x2F68D78")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x2F69AD0", Offset = "0x2F69AD0", VA = "0x2F69AD0")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x2F69C14", Offset = "0x2F69C14", VA = "0x2F69C14")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x2F692D0", Offset = "0x2F692D0", VA = "0x2F692D0")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000112")]
		public class Footstep
		{
			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B2718", Offset = "0x13B2718")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000B1")]
			public bool isStepping
			{
				[Token(Token = "0x6000718")]
				[Address(RVA = "0x2F69C3C", Offset = "0x2F69C3C", VA = "0x2F69C3C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B2")]
			public float stepProgress
			{
				[Token(Token = "0x6000719")]
				[Address(RVA = "0x2F69C50", Offset = "0x2F69C50", VA = "0x2F69C50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7C5C", Offset = "0x13B7C5C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600071A")]
				[Address(RVA = "0x2F69C58", Offset = "0x2F69C58", VA = "0x2F69C58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7C6C", Offset = "0x13B7C6C")]
				private set
				{
				}
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x2F69C60", Offset = "0x2F69C60", VA = "0x2F69C60")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x2F69DF0", Offset = "0x2F69DF0", VA = "0x2F69DF0")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x2F69E38", Offset = "0x2F69E38", VA = "0x2F69E38")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0x2F69F38", Offset = "0x2F69F38", VA = "0x2F69F38")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x2F6A110", Offset = "0x2F6A110", VA = "0x2F6A110")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000720")]
			[Address(RVA = "0x2F6A2FC", Offset = "0x2F6A2FC", VA = "0x2F6A2FC")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000113")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2728", Offset = "0x13B2728")]
			public Transform target;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2760", Offset = "0x13B2760")]
			public Transform bendGoal;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2798", Offset = "0x13B2798")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B2798", Offset = "0x13B2798")]
			public float positionWeight;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B27EC", Offset = "0x13B27EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B27EC", Offset = "0x13B27EC")]
			public float rotationWeight;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2840", Offset = "0x13B2840")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B2840", Offset = "0x13B2840")]
			public float bendGoalWeight;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2894", Offset = "0x13B2894")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B2894", Offset = "0x13B2894")]
			public float swivelOffset;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B28F0", Offset = "0x13B28F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B28F0", Offset = "0x13B28F0")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2944", Offset = "0x13B2944")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B2944", Offset = "0x13B2944")]
			public float legLengthMlp;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B299C", Offset = "0x13B299C")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B2A34", Offset = "0x13B2A34")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B2A44", Offset = "0x13B2A44")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B2A54", Offset = "0x13B2A54")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B2A64", Offset = "0x13B2A64")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 footPosition;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Quaternion footRotation;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 bendNormal;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x170000B3")]
			public Vector3 position
			{
				[Token(Token = "0x6000721")]
				[Address(RVA = "0x2F6A518", Offset = "0x2F6A518", VA = "0x2F6A518")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7C7C", Offset = "0x13B7C7C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000722")]
				[Address(RVA = "0x2F6A524", Offset = "0x2F6A524", VA = "0x2F6A524")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7C8C", Offset = "0x13B7C8C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B4")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000723")]
				[Address(RVA = "0x2F6A530", Offset = "0x2F6A530", VA = "0x2F6A530")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7C9C", Offset = "0x13B7C9C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000724")]
				[Address(RVA = "0x2F6A53C", Offset = "0x2F6A53C", VA = "0x2F6A53C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7CAC", Offset = "0x13B7CAC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B5")]
			public bool hasToes
			{
				[Token(Token = "0x6000725")]
				[Address(RVA = "0x2F6A548", Offset = "0x2F6A548", VA = "0x2F6A548")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7CBC", Offset = "0x13B7CBC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000726")]
				[Address(RVA = "0x2F6A550", Offset = "0x2F6A550", VA = "0x2F6A550")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7CCC", Offset = "0x13B7CCC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B6")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000727")]
				[Address(RVA = "0x2F6A55C", Offset = "0x2F6A55C", VA = "0x2F6A55C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B7")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000728")]
				[Address(RVA = "0x2F6A590", Offset = "0x2F6A590", VA = "0x2F6A590")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000729")]
				[Address(RVA = "0x2F6A5C8", Offset = "0x2F6A5C8", VA = "0x2F6A5C8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private VirtualBone toes
			{
				[Token(Token = "0x600072A")]
				[Address(RVA = "0x2F6A600", Offset = "0x2F6A600", VA = "0x2F6A600")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600072B")]
				[Address(RVA = "0x2F644B0", Offset = "0x2F644B0", VA = "0x2F644B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BB")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600072C")]
				[Address(RVA = "0x2F6A638", Offset = "0x2F6A638", VA = "0x2F6A638")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7CDC", Offset = "0x13B7CDC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600072D")]
				[Address(RVA = "0x2F6A644", Offset = "0x2F6A644", VA = "0x2F6A644")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7CEC", Offset = "0x13B7CEC")]
				private set
				{
				}
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x2F6A650", Offset = "0x2F6A650", VA = "0x2F6A650", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600072F")]
			[Address(RVA = "0x2F6AC58", Offset = "0x2F6AC58", VA = "0x2F6AC58", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000730")]
			[Address(RVA = "0x2F6B468", Offset = "0x2F6B468", VA = "0x2F6B468", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0x2F6B364", Offset = "0x2F6B364", VA = "0x2F6B364")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000732")]
			[Address(RVA = "0x2F6B12C", Offset = "0x2F6B12C", VA = "0x2F6B12C")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x2F64848", Offset = "0x2F64848", VA = "0x2F64848")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x2F6BA20", Offset = "0x2F6BA20", VA = "0x2F6BA20")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x2F6BF20", Offset = "0x2F6BF20", VA = "0x2F6BF20", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x2F6C13C", Offset = "0x2F6C13C", VA = "0x2F6C13C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x2F66D54", Offset = "0x2F66D54", VA = "0x2F66D54")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000114")]
		public class Locomotion
		{
			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2A74", Offset = "0x13B2A74")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B2A74", Offset = "0x13B2A74")]
			public float weight;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2AC8", Offset = "0x13B2AC8")]
			public float footDistance;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2B00", Offset = "0x13B2B00")]
			public float stepThreshold;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2B38", Offset = "0x13B2B38")]
			public float angleThreshold;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2B70", Offset = "0x13B2B70")]
			public float comAngleMlp;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2BA8", Offset = "0x13B2BA8")]
			public float maxVelocity;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2BE0", Offset = "0x13B2BE0")]
			public float velocityFactor;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2C18", Offset = "0x13B2C18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B2C18", Offset = "0x13B2C18")]
			public float maxLegStretch;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2C70", Offset = "0x13B2C70")]
			public float rootSpeed;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2CA8", Offset = "0x13B2CA8")]
			public float stepSpeed;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2CE0", Offset = "0x13B2CE0")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2D18", Offset = "0x13B2D18")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2D50", Offset = "0x13B2D50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B2D50", Offset = "0x13B2D50")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2DA8", Offset = "0x13B2DA8")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2DE0", Offset = "0x13B2DE0")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2E18", Offset = "0x13B2E18")]
			public Vector3 offset;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2E90", Offset = "0x13B2E90")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2EC8", Offset = "0x13B2EC8")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B2F00", Offset = "0x13B2F00")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000BC")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000738")]
				[Address(RVA = "0x2F6C1EC", Offset = "0x2F6C1EC", VA = "0x2F6C1EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7CFC", Offset = "0x13B7CFC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000739")]
				[Address(RVA = "0x2F6C1F8", Offset = "0x2F6C1F8", VA = "0x2F6C1F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7D0C", Offset = "0x13B7D0C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BD")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x600073F")]
				[Address(RVA = "0x2F6C638", Offset = "0x2F6C638", VA = "0x2F6C638")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000BE")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000740")]
				[Address(RVA = "0x2F6C678", Offset = "0x2F6C678", VA = "0x2F6C678")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000BF")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000741")]
				[Address(RVA = "0x2F6C6BC", Offset = "0x2F6C6BC", VA = "0x2F6C6BC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000C0")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000742")]
				[Address(RVA = "0x2F6C6FC", Offset = "0x2F6C6FC", VA = "0x2F6C6FC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x2F6277C", Offset = "0x2F6277C", VA = "0x2F6277C")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x2F60574", Offset = "0x2F60574", VA = "0x2F60574")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x600073C")]
			[Address(RVA = "0x2F5F938", Offset = "0x2F5F938", VA = "0x2F5F938")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x2F5F788", Offset = "0x2F5F788", VA = "0x2F5F788")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0x2F62FF0", Offset = "0x2F62FF0", VA = "0x2F62FF0")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x2F6C244", Offset = "0x2F6C244", VA = "0x2F6C244")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x2F6C3E8", Offset = "0x2F6C3E8", VA = "0x2F6C3E8")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x2F6C46C", Offset = "0x2F6C46C", VA = "0x2F6C46C")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0x2F66E54", Offset = "0x2F66E54", VA = "0x2F66E54")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000115")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2F10", Offset = "0x13B2F10")]
			public Transform headTarget;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2F48", Offset = "0x13B2F48")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2F80", Offset = "0x13B2F80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B2F80", Offset = "0x13B2F80")]
			public float positionWeight;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B2FD4", Offset = "0x13B2FD4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B2FD4", Offset = "0x13B2FD4")]
			public float rotationWeight;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3028", Offset = "0x13B3028")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B3028", Offset = "0x13B3028")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B307C", Offset = "0x13B307C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B307C", Offset = "0x13B307C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B30D0", Offset = "0x13B30D0")]
			public Transform chestGoal;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3108", Offset = "0x13B3108")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B3108", Offset = "0x13B3108")]
			public float chestGoalWeight;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B315C", Offset = "0x13B315C")]
			public float minHeadHeight;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3194", Offset = "0x13B3194")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B3194", Offset = "0x13B3194")]
			public float bodyPosStiffness;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B31E8", Offset = "0x13B31E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B31E8", Offset = "0x13B31E8")]
			public float bodyRotStiffness;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B323C", Offset = "0x13B323C")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B323C", Offset = "0x13B323C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B323C", Offset = "0x13B323C")]
			public float neckStiffness;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B32B4", Offset = "0x13B32B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B32B4", Offset = "0x13B32B4")]
			public float rotateChestByHands;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3308", Offset = "0x13B3308")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B3308", Offset = "0x13B3308")]
			public float chestClampWeight;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B335C", Offset = "0x13B335C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B335C", Offset = "0x13B335C")]
			public float headClampWeight;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B33B0", Offset = "0x13B33B0")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B33E8", Offset = "0x13B33E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B33E8", Offset = "0x13B33E8")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B343C", Offset = "0x13B343C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B343C", Offset = "0x13B343C")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B3574", Offset = "0x13B3574")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private Quaternion headRotation;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private int pelvisIndex;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int spineIndex;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int chestIndex;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int neckIndex;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int headIndex;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private float length;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private bool hasChest;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20D")]
			private bool hasNeck;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20E")]
			private bool hasLegs;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private float headHeight;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float sizeMlp;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private Vector3 chestForward;

			[Token(Token = "0x170000C1")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000747")]
				[Address(RVA = "0x2F607E8", Offset = "0x2F607E8", VA = "0x2F607E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000748")]
				[Address(RVA = "0x2F6C740", Offset = "0x2F6C740", VA = "0x2F6C740")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000749")]
				[Address(RVA = "0x2F64E1C", Offset = "0x2F64E1C", VA = "0x2F64E1C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private VirtualBone neck
			{
				[Token(Token = "0x600074A")]
				[Address(RVA = "0x2F6C780", Offset = "0x2F6C780", VA = "0x2F6C780")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			public VirtualBone head
			{
				[Token(Token = "0x600074B")]
				[Address(RVA = "0x2F6C204", Offset = "0x2F6C204", VA = "0x2F6C204")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C6")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x600074C")]
				[Address(RVA = "0x2F6C7C0", Offset = "0x2F6C7C0", VA = "0x2F6C7C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7D1C", Offset = "0x13B7D1C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600074D")]
				[Address(RVA = "0x2F6C7D4", Offset = "0x2F6C7D4", VA = "0x2F6C7D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7D2C", Offset = "0x13B7D2C")]
				private set
				{
				}
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x2F6C7E8", Offset = "0x2F6C7E8", VA = "0x2F6C7E8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0x2F6D2E4", Offset = "0x2F6D2E4", VA = "0x2F6D2E4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x2F6D4F4", Offset = "0x2F6D4F4", VA = "0x2F6D4F4", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x2F6DAAC", Offset = "0x2F6DAAC", VA = "0x2F6DAAC")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0x2F62A94", Offset = "0x2F62A94", VA = "0x2F62A94")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0x2F6E468", Offset = "0x2F6E468", VA = "0x2F6E468")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0x2F6EB14", Offset = "0x2F6EB14", VA = "0x2F6EB14")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x2F6F2E4", Offset = "0x2F6F2E4", VA = "0x2F6F2E4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0x2F6F4C0", Offset = "0x2F6F4C0", VA = "0x2F6F4C0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0x2F6DCDC", Offset = "0x2F6DCDC", VA = "0x2F6DCDC")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x2F644F0", Offset = "0x2F644F0", VA = "0x2F644F0")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x2F6E060", Offset = "0x2F6E060", VA = "0x2F6E060")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x2F6F5B8", Offset = "0x2F6F5B8", VA = "0x2F6F5B8")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x2F6E8C8", Offset = "0x2F6E8C8", VA = "0x2F6E8C8")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x2F6E614", Offset = "0x2F6E614", VA = "0x2F6E614")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x2F66A54", Offset = "0x2F66A54", VA = "0x2F66A54")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000116")]
		public enum PositionOffset
		{
			[Token(Token = "0x400077C")]
			Pelvis,
			[Token(Token = "0x400077D")]
			Chest,
			[Token(Token = "0x400077E")]
			Head,
			[Token(Token = "0x400077F")]
			LeftHand,
			[Token(Token = "0x4000780")]
			RightHand,
			[Token(Token = "0x4000781")]
			LeftFoot,
			[Token(Token = "0x4000782")]
			RightFoot,
			[Token(Token = "0x4000783")]
			LeftHeel,
			[Token(Token = "0x4000784")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000117")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000786")]
			Pelvis,
			[Token(Token = "0x4000787")]
			Chest,
			[Token(Token = "0x4000788")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000118")]
		public class VirtualBone
		{
			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x2F62610", Offset = "0x2F62610", VA = "0x2F62610")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0x2F6268C", Offset = "0x2F6268C", VA = "0x2F6268C")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x2F6F8E0", Offset = "0x2F6F8E0", VA = "0x2F6F8E0")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000761")]
			[Address(RVA = "0x2F69394", Offset = "0x2F69394", VA = "0x2F69394")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0x2F69894", Offset = "0x2F69894", VA = "0x2F69894")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0x2F6FB70", Offset = "0x2F6FB70", VA = "0x2F6FB70")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0x2F67FE0", Offset = "0x2F67FE0", VA = "0x2F67FE0")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000765")]
			[Address(RVA = "0x2F6FDA8", Offset = "0x2F6FDA8", VA = "0x2F6FDA8")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0x2F687CC", Offset = "0x2F687CC", VA = "0x2F687CC")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0x2F6FE60", Offset = "0x2F6FE60", VA = "0x2F6FE60")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0x2F6EE9C", Offset = "0x2F6EE9C", VA = "0x2F6EE9C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0x2F70078", Offset = "0x2F70078", VA = "0x2F70078")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x2F70180", Offset = "0x2F70180", VA = "0x2F70180")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0218", Offset = "0x13B0218")]
		public bool plantFeet;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B0250", Offset = "0x13B0250")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0260", Offset = "0x13B0260")]
		public Spine spine;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0298", Offset = "0x13B0298")]
		public Arm leftArm;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B02D0", Offset = "0x13B02D0")]
		public Arm rightArm;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0308", Offset = "0x13B0308")]
		public Leg leftLeg;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0340", Offset = "0x13B0340")]
		public Leg rightLeg;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0378", Offset = "0x13B0378")]
		public Locomotion locomotion;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000059")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x2F667E8", Offset = "0x2F667E8", VA = "0x2F667E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B699C", Offset = "0x13B699C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x2F667F0", Offset = "0x2F667F0", VA = "0x2F667F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B69AC", Offset = "0x13B69AC")]
			private set
			{
			}
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x2F5E270", Offset = "0x2F5E270", VA = "0x2F5E270")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x2F5E704", Offset = "0x2F5E704", VA = "0x2F5E704")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x2F5E58C", Offset = "0x2F5E58C", VA = "0x2F5E58C")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x2F5F0F0", Offset = "0x2F5F0F0", VA = "0x2F5F0F0")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x2F5F3CC", Offset = "0x2F5F3CC", VA = "0x2F5F3CC")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x2F5F470", Offset = "0x2F5F470", VA = "0x2F5F470")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x2F5F604", Offset = "0x2F5F604", VA = "0x2F5F604")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x2F5FD10", Offset = "0x2F5FD10", VA = "0x2F5FD10")]
		public void Reset()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x2F60828", Offset = "0x2F60828", VA = "0x2F60828", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x2F6099C", Offset = "0x2F6099C", VA = "0x2F6099C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2F60B40", Offset = "0x2F60B40", VA = "0x2F60B40", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x2F60BB4", Offset = "0x2F60BB4", VA = "0x2F60BB4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x2F60C28", Offset = "0x2F60C28", VA = "0x2F60C28", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x2F60E48", Offset = "0x2F60E48", VA = "0x2F60E48")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x2F5E9A4", Offset = "0x2F5E9A4", VA = "0x2F5E9A4")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x2F5EB7C", Offset = "0x2F5EB7C", VA = "0x2F5EB7C")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x2F5EFCC", Offset = "0x2F5EFCC", VA = "0x2F5EFCC")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x2F5FE80", Offset = "0x2F5FE80", VA = "0x2F5FE80")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x2F61128", Offset = "0x2F61128", VA = "0x2F61128", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x2F61170", Offset = "0x2F61170", VA = "0x2F61170", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x2F62328", Offset = "0x2F62328", VA = "0x2F62328")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x2F5FFE8", Offset = "0x2F5FFE8", VA = "0x2F5FFE8")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x2F611DC", Offset = "0x2F611DC", VA = "0x2F611DC")]
		private void Solve()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x2F62584", Offset = "0x2F62584", VA = "0x2F62584")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x2F625CC", Offset = "0x2F625CC", VA = "0x2F625CC")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x2F621D8", Offset = "0x2F621D8", VA = "0x2F621D8")]
		private void Write()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x2F66200", Offset = "0x2F66200", VA = "0x2F66200")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2F667F8", Offset = "0x2F667F8", VA = "0x2F667F8")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B03B0", Offset = "0x13B03B0")]
		public Transform parent;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B03E8", Offset = "0x13B03E8")]
		public Transform child;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0420", Offset = "0x13B0420")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0420", Offset = "0x13B0420")]
		public float weight;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0474", Offset = "0x13B0474")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0474", Offset = "0x13B0474")]
		public float parentChildCrossfade;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B04C8", Offset = "0x13B04C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B04C8", Offset = "0x13B04C8")]
		public float twistAngleOffset;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x2921E28", Offset = "0x2921E28", VA = "0x2921E28")]
		public void Relax()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x2922208", Offset = "0x2922208", VA = "0x2922208")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x29226B4", Offset = "0x29226B4", VA = "0x29226B4")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x292273C", Offset = "0x292273C", VA = "0x292273C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x29227C4", Offset = "0x29227C4", VA = "0x29227C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x29228EC", Offset = "0x29228EC", VA = "0x29228EC")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AC")]
	public class InteractionEffector
	{
		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B0524", Offset = "0x13B0524")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B0534", Offset = "0x13B0534")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B0544", Offset = "0x13B0544")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x1700005A")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x2F709A8", Offset = "0x2F709A8", VA = "0x2F709A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B69BC", Offset = "0x13B69BC")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x2F709B0", Offset = "0x2F709B0", VA = "0x2F709B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B69CC", Offset = "0x13B69CC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public bool isPaused
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x2F709B8", Offset = "0x2F709B8", VA = "0x2F709B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B69DC", Offset = "0x13B69DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x2F709C0", Offset = "0x2F709C0", VA = "0x2F709C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B69EC", Offset = "0x13B69EC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x2F709CC", Offset = "0x2F709CC", VA = "0x2F709CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B69FC", Offset = "0x13B69FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x2F709D4", Offset = "0x2F709D4", VA = "0x2F709D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B6A0C", Offset = "0x13B6A0C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public bool inInteraction
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x2F709DC", Offset = "0x2F709DC", VA = "0x2F709DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		public float progress
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x2F72C08", Offset = "0x2F72C08", VA = "0x2F72C08")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x2F70A4C", Offset = "0x2F70A4C", VA = "0x2F70A4C")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x2F70ADC", Offset = "0x2F70ADC", VA = "0x2F70ADC")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2F70BAC", Offset = "0x2F70BAC", VA = "0x2F70BAC")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x2F70CEC", Offset = "0x2F70CEC", VA = "0x2F70CEC")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x2F710F0", Offset = "0x2F710F0", VA = "0x2F710F0")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x2F71224", Offset = "0x2F71224", VA = "0x2F71224")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x2F7127C", Offset = "0x2F7127C", VA = "0x2F7127C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x2F718F4", Offset = "0x2F718F4", VA = "0x2F718F4")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x2F72424", Offset = "0x2F72424", VA = "0x2F72424")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x2F72654", Offset = "0x2F72654", VA = "0x2F72654")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x2F72A90", Offset = "0x2F72A90", VA = "0x2F72A90")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x2F72CD4", Offset = "0x2F72CD4", VA = "0x2F72CD4")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AD")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0554", Offset = "0x13B0554")]
		public LookAtIK ik;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B058C", Offset = "0x13B058C")]
		public float lerpSpeed;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B05C4", Offset = "0x13B05C4")]
		public float weightSpeed;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x2F72F38", Offset = "0x2F72F38", VA = "0x2F72F38")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x2F730BC", Offset = "0x2F730BC", VA = "0x2F730BC")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x2F73164", Offset = "0x2F73164", VA = "0x2F73164")]
		public void Update()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x2F733B8", Offset = "0x2F733B8", VA = "0x2F733B8")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x2F734B0", Offset = "0x2F734B0", VA = "0x2F734B0")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x2F7357C", Offset = "0x2F7357C", VA = "0x2F7357C")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13ACD1C", Offset = "0x13ACD1C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ACD1C", Offset = "0x13ACD1C")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000119")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3584", Offset = "0x13B3584")]
			public float time;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B35BC", Offset = "0x13B35BC")]
			public bool pause;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B35F4", Offset = "0x13B35F4")]
			public bool pickUp;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B362C", Offset = "0x13B362C")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3664", Offset = "0x13B3664")]
			public Message[] messages;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B369C", Offset = "0x13B369C")]
			public UnityEvent unityEvent;

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x2911C6C", Offset = "0x2911C6C", VA = "0x2911C6C")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0x2911E2C", Offset = "0x2911E2C", VA = "0x2911E2C")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200011A")]
		public class Message
		{
			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B36D4", Offset = "0x13B36D4")]
			public string function;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B370C", Offset = "0x13B370C")]
			public GameObject recipient;

			[Token(Token = "0x4000798")]
			private const string empty = "";

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x2911D3C", Offset = "0x2911D3C", VA = "0x2911D3C")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0x2911E34", Offset = "0x2911E34", VA = "0x2911E34")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200011B")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3744", Offset = "0x13B3744")]
			public Animator animator;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B377C", Offset = "0x13B377C")]
			public Animation animation;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B37B4", Offset = "0x13B37B4")]
			public string animationState;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B37EC", Offset = "0x13B37EC")]
			public float crossfadeTime;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3824", Offset = "0x13B3824")]
			public int layer;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B385C", Offset = "0x13B385C")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400079F")]
			private const string empty = "";

			[Token(Token = "0x600076F")]
			[Address(RVA = "0x29119CC", Offset = "0x29119CC", VA = "0x29119CC")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x2911AC0", Offset = "0x2911AC0", VA = "0x2911AC0")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x2911B78", Offset = "0x2911B78", VA = "0x2911B78")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x2911C58", Offset = "0x2911C58", VA = "0x2911C58")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200011C")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x200013F")]
			public enum Type
			{
				[Token(Token = "0x4000858")]
				PositionWeight,
				[Token(Token = "0x4000859")]
				RotationWeight,
				[Token(Token = "0x400085A")]
				PositionOffsetX,
				[Token(Token = "0x400085B")]
				PositionOffsetY,
				[Token(Token = "0x400085C")]
				PositionOffsetZ,
				[Token(Token = "0x400085D")]
				Pull,
				[Token(Token = "0x400085E")]
				Reach,
				[Token(Token = "0x400085F")]
				RotateBoneWeight,
				[Token(Token = "0x4000860")]
				Push,
				[Token(Token = "0x4000861")]
				PushParent,
				[Token(Token = "0x4000862")]
				PoserWeight
			}

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3894", Offset = "0x13B3894")]
			public Type type;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B38CC", Offset = "0x13B38CC")]
			public AnimationCurve curve;

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x2911E78", Offset = "0x2911E78", VA = "0x2911E78")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x2911EA4", Offset = "0x2911EA4", VA = "0x2911EA4")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200011D")]
		public class Multiplier
		{
			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3904", Offset = "0x13B3904")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B393C", Offset = "0x13B393C")]
			public float multiplier;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3974", Offset = "0x13B3974")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x2911E3C", Offset = "0x2911E3C", VA = "0x2911E3C")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x2911E94", Offset = "0x2911E94", VA = "0x2911E94")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B060C", Offset = "0x13B060C")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0644", Offset = "0x13B0644")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B067C", Offset = "0x13B067C")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B06B4", Offset = "0x13B06B4")]
		private float <length>k__BackingField;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B06C4", Offset = "0x13B06C4")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700005F")]
		public float length
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x2F73758", Offset = "0x2F73758", VA = "0x2F73758")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B6B6C", Offset = "0x13B6B6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x2F73760", Offset = "0x2F73760", VA = "0x2F73760")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B6B7C", Offset = "0x13B6B7C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x2F73768", Offset = "0x2F73768", VA = "0x2F73768")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B6B8C", Offset = "0x13B6B8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x2F73770", Offset = "0x2F73770", VA = "0x2F73770")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B6B9C", Offset = "0x13B6B9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x2F73994", Offset = "0x2F73994", VA = "0x2F73994")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x2F72C44", Offset = "0x2F72C44", VA = "0x2F72C44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x2F73590", Offset = "0x2F73590", VA = "0x2F73590")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6A1C", Offset = "0x13B6A1C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x2F735DC", Offset = "0x2F735DC", VA = "0x2F735DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6A54", Offset = "0x13B6A54")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x2F73628", Offset = "0x2F73628", VA = "0x2F73628")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6A8C", Offset = "0x13B6A8C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x2F73674", Offset = "0x2F73674", VA = "0x2F73674")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6AC4", Offset = "0x13B6AC4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x2F736C0", Offset = "0x2F736C0", VA = "0x2F736C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6AFC", Offset = "0x13B6AFC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x2F7370C", Offset = "0x2F7370C", VA = "0x2F7370C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6B34", Offset = "0x13B6B34")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x2F73778", Offset = "0x2F73778", VA = "0x2F73778")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x2F73A24", Offset = "0x2F73A24", VA = "0x2F73A24")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x2F71840", Offset = "0x2F71840", VA = "0x2F71840")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2F73BA8", Offset = "0x2F73BA8", VA = "0x2F73BA8")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2F716F4", Offset = "0x2F716F4", VA = "0x2F716F4")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x2F71838", Offset = "0x2F71838", VA = "0x2F71838")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x2F72004", Offset = "0x2F72004", VA = "0x2F72004")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x2F72864", Offset = "0x2F72864", VA = "0x2F72864")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x2F74268", Offset = "0x2F74268", VA = "0x2F74268")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x2F73C20", Offset = "0x2F73C20", VA = "0x2F73C20")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x2F73BB0", Offset = "0x2F73BB0", VA = "0x2F73BB0")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2F74200", Offset = "0x2F74200", VA = "0x2F74200")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2F7426C", Offset = "0x2F7426C", VA = "0x2F7426C")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x2F742D4", Offset = "0x2F742D4", VA = "0x2F742D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6BAC", Offset = "0x13B6BAC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2F74320", Offset = "0x2F74320", VA = "0x2F74320")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6BE4", Offset = "0x13B6BE4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2F7436C", Offset = "0x2F7436C", VA = "0x2F7436C")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13ACD7C", Offset = "0x13ACD7C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ACD7C", Offset = "0x13ACD7C")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200011E")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200011F")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B06D4", Offset = "0x13B06D4")]
		public string targetTag;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B070C", Offset = "0x13B070C")]
		public float fadeInTime;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0744", Offset = "0x13B0744")]
		public float speed;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B077C", Offset = "0x13B077C")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13B07B4", Offset = "0x13B07B4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B07B4", Offset = "0x13B07B4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B07B4", Offset = "0x13B07B4")]
		public Collider characterCollider;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0838", Offset = "0x13B0838")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x13B0838", Offset = "0x13B0838")]
		public Transform FPSCamera;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0898", Offset = "0x13B0898")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B08D0", Offset = "0x13B08D0")]
		public float camRaycastDistance;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B0908", Offset = "0x13B0908")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x13B0918", Offset = "0x13B0918")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0918", Offset = "0x13B0918")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0978", Offset = "0x13B0978")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000063")]
		public bool inInteraction
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x2912074", Offset = "0x2912074", VA = "0x2912074")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x2913D7C", Offset = "0x2913D7C", VA = "0x2913D7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x2913D84", Offset = "0x2913D84", VA = "0x2913D84")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x2913D8C", Offset = "0x2913D8C", VA = "0x2913D8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B6D6C", Offset = "0x13B6D6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x2913D94", Offset = "0x2913D94", VA = "0x2913D94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B6D7C", Offset = "0x13B6D7C")]
			private set
			{
			}
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2911EAC", Offset = "0x2911EAC", VA = "0x2911EAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6C1C", Offset = "0x13B6C1C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2911EF8", Offset = "0x2911EF8", VA = "0x2911EF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6C54", Offset = "0x13B6C54")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2911F44", Offset = "0x2911F44", VA = "0x2911F44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6C8C", Offset = "0x13B6C8C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x2911F90", Offset = "0x2911F90", VA = "0x2911F90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6CC4", Offset = "0x13B6CC4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2911FDC", Offset = "0x2911FDC", VA = "0x2911FDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6CFC", Offset = "0x13B6CFC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2912028", Offset = "0x2912028", VA = "0x2912028")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6D34", Offset = "0x13B6D34")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2912204", Offset = "0x2912204", VA = "0x2912204")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x29122D4", Offset = "0x29122D4", VA = "0x29122D4")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x29123A4", Offset = "0x29123A4", VA = "0x29123A4")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2912454", Offset = "0x2912454", VA = "0x2912454")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2912550", Offset = "0x2912550", VA = "0x2912550")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2912670", Offset = "0x2912670", VA = "0x2912670")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2912704", Offset = "0x2912704", VA = "0x2912704")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2912798", Offset = "0x2912798", VA = "0x2912798")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x291282C", Offset = "0x291282C", VA = "0x291282C")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x29128A4", Offset = "0x29128A4", VA = "0x29128A4")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x291291C", Offset = "0x291291C", VA = "0x291291C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2912988", Offset = "0x2912988", VA = "0x2912988")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2912A14", Offset = "0x2912A14", VA = "0x2912A14")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2912AA8", Offset = "0x2912AA8", VA = "0x2912AA8")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x2912B74", Offset = "0x2912B74", VA = "0x2912B74")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x2912E14", Offset = "0x2912E14", VA = "0x2912E14")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x2913004", Offset = "0x2913004", VA = "0x2913004")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x291328C", Offset = "0x291328C", VA = "0x291328C")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x2913580", Offset = "0x2913580", VA = "0x2913580")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x29135C4", Offset = "0x29135C4", VA = "0x29135C4")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x2913640", Offset = "0x2913640", VA = "0x2913640")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x2913778", Offset = "0x2913778", VA = "0x2913778")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x29138F4", Offset = "0x29138F4", VA = "0x29138F4")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x2913B9C", Offset = "0x2913B9C", VA = "0x2913B9C")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x291338C", Offset = "0x291338C", VA = "0x291338C")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x2913D9C", Offset = "0x2913D9C", VA = "0x2913D9C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x2914550", Offset = "0x2914550", VA = "0x2914550")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x2914570", Offset = "0x2914570", VA = "0x2914570")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x291458C", Offset = "0x291458C", VA = "0x291458C")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x29145A8", Offset = "0x29145A8", VA = "0x29145A8")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x2914610", Offset = "0x2914610", VA = "0x2914610")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x291472C", Offset = "0x291472C", VA = "0x291472C")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x2914828", Offset = "0x2914828", VA = "0x2914828")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x2914B80", Offset = "0x2914B80", VA = "0x2914B80")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x2914C98", Offset = "0x2914C98", VA = "0x2914C98")]
		private void Update()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x2914EE8", Offset = "0x2914EE8", VA = "0x2914EE8")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x29142B0", Offset = "0x29142B0", VA = "0x29142B0")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x2915028", Offset = "0x2915028", VA = "0x2915028")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x291515C", Offset = "0x291515C", VA = "0x291515C")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x2915208", Offset = "0x2915208", VA = "0x2915208")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x29152F8", Offset = "0x29152F8", VA = "0x29152F8")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x2915314", Offset = "0x2915314", VA = "0x2915314")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x2912124", Offset = "0x2912124", VA = "0x2912124")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x2912D14", Offset = "0x2912D14", VA = "0x2912D14")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x29156D8", Offset = "0x29156D8", VA = "0x29156D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6D8C", Offset = "0x13B6D8C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x2915724", Offset = "0x2915724", VA = "0x2915724")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6DC4", Offset = "0x13B6DC4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x2915770", Offset = "0x2915770", VA = "0x2915770")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13ACDDC", Offset = "0x13ACDDC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ACDDC", Offset = "0x13ACDDC")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000120")]
		public class Multiplier
		{
			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B39AC", Offset = "0x13B39AC")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B39E4", Offset = "0x13B39E4")]
			public float multiplier;

			[Token(Token = "0x600077F")]
			[Address(RVA = "0x2916CD4", Offset = "0x2916CD4", VA = "0x2916CD4")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B09B0", Offset = "0x13B09B0")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B09E8", Offset = "0x13B09E8")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0A20", Offset = "0x13B0A20")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0A58", Offset = "0x13B0A58")]
		public Transform pivot;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0A90", Offset = "0x13B0A90")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0AC8", Offset = "0x13B0AC8")]
		public float twistWeight;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0B00", Offset = "0x13B0B00")]
		public float swingWeight;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0B38", Offset = "0x13B0B38")]
		public bool rotateOnce;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x2916228", Offset = "0x2916228", VA = "0x2916228")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6DFC", Offset = "0x13B6DFC")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x2916274", Offset = "0x2916274", VA = "0x2916274")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6E34", Offset = "0x13B6E34")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x29162C0", Offset = "0x29162C0", VA = "0x29162C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6E6C", Offset = "0x13B6E6C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x291630C", Offset = "0x291630C", VA = "0x291630C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6EA4", Offset = "0x13B6EA4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x2916358", Offset = "0x2916358", VA = "0x2916358")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6EDC", Offset = "0x13B6EDC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x29163A4", Offset = "0x29163A4", VA = "0x29163A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6F14", Offset = "0x13B6F14")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x29163F0", Offset = "0x29163F0", VA = "0x29163F0")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x2916460", Offset = "0x2916460", VA = "0x2916460")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x29164FC", Offset = "0x29164FC", VA = "0x29164FC")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x2916BB0", Offset = "0x2916BB0", VA = "0x2916BB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6F4C", Offset = "0x13B6F4C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x2916BFC", Offset = "0x2916BFC", VA = "0x2916BFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6F84", Offset = "0x13B6F84")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x2916C48", Offset = "0x2916C48", VA = "0x2916C48")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13ACE3C", Offset = "0x13ACE3C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ACE3C", Offset = "0x13ACE3C")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000121")]
		public class CharacterPosition
		{
			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3A1C", Offset = "0x13B3A1C")]
			public bool use;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3A54", Offset = "0x13B3A54")]
			public Vector2 offset;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3A8C", Offset = "0x13B3A8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B3A8C", Offset = "0x13B3A8C")]
			public float angleOffset;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3AE8", Offset = "0x13B3AE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B3AE8", Offset = "0x13B3AE8")]
			public float maxAngle;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3B40", Offset = "0x13B3B40")]
			public float radius;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3B78", Offset = "0x13B3B78")]
			public bool orbit;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3BB0", Offset = "0x13B3BB0")]
			public bool fixYAxis;

			[Token(Token = "0x170000C7")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000780")]
				[Address(RVA = "0x2917468", Offset = "0x2917468", VA = "0x2917468")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C8")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000781")]
				[Address(RVA = "0x29174A4", Offset = "0x29174A4", VA = "0x29174A4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000782")]
			[Address(RVA = "0x291759C", Offset = "0x291759C", VA = "0x291759C")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000783")]
			[Address(RVA = "0x2917C18", Offset = "0x2917C18", VA = "0x2917C18")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000122")]
		public class CameraPosition
		{
			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3BE8", Offset = "0x13B3BE8")]
			public Collider lookAtTarget;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3C20", Offset = "0x13B3C20")]
			public Vector3 direction;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3C58", Offset = "0x13B3C58")]
			public float maxDistance;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3C90", Offset = "0x13B3C90")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B3C90", Offset = "0x13B3C90")]
			public float maxAngle;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3CE8", Offset = "0x13B3CE8")]
			public bool fixYAxis;

			[Token(Token = "0x6000784")]
			[Address(RVA = "0x2916F54", Offset = "0x2916F54", VA = "0x2916F54")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0x29170FC", Offset = "0x29170FC", VA = "0x29170FC")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0x29173DC", Offset = "0x29173DC", VA = "0x29173DC")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000123")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000140")]
			public class Interaction
			{
				[Token(Token = "0x4000863")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4DA0", Offset = "0x13B4DA0")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000864")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4DD8", Offset = "0x13B4DD8")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60007F8")]
				[Address(RVA = "0x2917C3C", Offset = "0x2917C3C", VA = "0x2917C3C")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3D90", Offset = "0x13B3D90")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3DC8", Offset = "0x13B3DC8")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3E00", Offset = "0x13B3E00")]
			public Interaction[] interactions;

			[Token(Token = "0x6000787")]
			[Address(RVA = "0x2916DC4", Offset = "0x2916DC4", VA = "0x2916DC4")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000788")]
			[Address(RVA = "0x2917C2C", Offset = "0x2917C2C", VA = "0x2917C2C")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0B70", Offset = "0x13B0B70")]
		public Range[] ranges;

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x2916CDC", Offset = "0x2916CDC", VA = "0x2916CDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6FBC", Offset = "0x13B6FBC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x2916D28", Offset = "0x2916D28", VA = "0x2916D28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B6FF4", Offset = "0x13B6FF4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x2916D74", Offset = "0x2916D74", VA = "0x2916D74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B702C", Offset = "0x13B702C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x2916DC0", Offset = "0x2916DC0", VA = "0x2916DC0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x29149C8", Offset = "0x29149C8", VA = "0x29149C8")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x2916EE8", Offset = "0x2916EE8", VA = "0x2916EE8")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x2000124")]
		public class Map
		{
			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000789")]
			[Address(RVA = "0x248E2D4", Offset = "0x248E2D4", VA = "0x248E2D4")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x600078A")]
			[Address(RVA = "0x248E6F4", Offset = "0x248E6F4", VA = "0x248E6F4")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600078B")]
			[Address(RVA = "0x248E6A8", Offset = "0x248E6A8", VA = "0x248E6A8")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600078C")]
			[Address(RVA = "0x248E4A0", Offset = "0x248E4A0", VA = "0x248E4A0")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x248DFE0", Offset = "0x248DFE0", VA = "0x248DFE0", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B7064", Offset = "0x13B7064")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x248E394", Offset = "0x248E394", VA = "0x248E394", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x248E398", Offset = "0x248E398", VA = "0x248E398", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x248E640", Offset = "0x248E640", VA = "0x248E640", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x248E32C", Offset = "0x248E32C", VA = "0x248E32C")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x248E234", Offset = "0x248E234", VA = "0x248E234")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x248E744", Offset = "0x248E744", VA = "0x248E744")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x305E048", Offset = "0x305E048", VA = "0x305E048", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x305E110", Offset = "0x305E110", VA = "0x305E110", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x305E2F4", Offset = "0x305E2F4", VA = "0x305E2F4", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x305E3F0", Offset = "0x305E3F0", VA = "0x305E3F0", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x305E178", Offset = "0x305E178", VA = "0x305E178")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x305E7A0", Offset = "0x305E7A0", VA = "0x305E7A0")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0BA8", Offset = "0x13B0BA8")]
		public float weight;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0BC0", Offset = "0x13B0BC0")]
		public float localRotationWeight;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0BD8", Offset = "0x13B0BD8")]
		public float localPositionWeight;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000555")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x291A9E4", Offset = "0x291A9E4", VA = "0x291A9E4")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000557")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000558")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000559")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x291A9F0", Offset = "0x291A9F0", VA = "0x291A9F0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x291AA44", Offset = "0x291AA44", VA = "0x291AA44", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x291AA80", Offset = "0x291AA80", VA = "0x291AA80", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x291AA98", Offset = "0x291AA98", VA = "0x291AA98")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x13ACE9C", Offset = "0x13ACE9C")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x2000125")]
		public class Rigidbone
		{
			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x600078D")]
			[Address(RVA = "0x291B0E0", Offset = "0x291B0E0", VA = "0x291B0E0")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x291BD58", Offset = "0x291BD58", VA = "0x291BD58")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x291BB3C", Offset = "0x291BB3C", VA = "0x291BB3C")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x2000126")]
		public class Child
		{
			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x291B290", Offset = "0x291B290", VA = "0x291B290")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x291BEF0", Offset = "0x291BEF0", VA = "0x291BEF0")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x291BEA0", Offset = "0x291BEA0", VA = "0x291BEA0")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD180", Offset = "0x13AD180")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000C9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000796")]
				[Address(RVA = "0x291C550", Offset = "0x291C550", VA = "0x291C550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000798")]
				[Address(RVA = "0x291C5B8", Offset = "0x291C5B8", VA = "0x291C5B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0x291B308", Offset = "0x291B308", VA = "0x291B308")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x291C2E8", Offset = "0x291C2E8", VA = "0x291C2E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0x291C2EC", Offset = "0x291C2EC", VA = "0x291C2EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x291C558", Offset = "0x291C558", VA = "0x291C558", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0BF0", Offset = "0x13B0BF0")]
		public IK ik;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0C28", Offset = "0x13B0C28")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0C60", Offset = "0x13B0C60")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0C98", Offset = "0x13B0C98")]
		public float applyVelocity;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0CD0", Offset = "0x13B0CD0")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000066")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x291AAF8", Offset = "0x291AAF8", VA = "0x291AAF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		private bool ikUsed
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x291B6F4", Offset = "0x291B6F4", VA = "0x291B6F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x291AAC0", Offset = "0x291AAC0", VA = "0x291AAC0")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x291AB70", Offset = "0x291AB70", VA = "0x291AB70")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x291ACAC", Offset = "0x291ACAC", VA = "0x291ACAC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x291AC30", Offset = "0x291AC30", VA = "0x291AC30")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B709C", Offset = "0x13B709C")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x291B334", Offset = "0x291B334", VA = "0x291B334")]
		private void Update()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x291B580", Offset = "0x291B580", VA = "0x291B580")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x291B638", Offset = "0x291B638", VA = "0x291B638")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x291B878", Offset = "0x291B878", VA = "0x291B878")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x291B6B8", Offset = "0x291B6B8", VA = "0x291B6B8")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x291B834", Offset = "0x291B834", VA = "0x291B834")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x291B914", Offset = "0x291B914", VA = "0x291B914")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x291B8AC", Offset = "0x291B8AC", VA = "0x291B8AC")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x291ABC8", Offset = "0x291ABC8", VA = "0x291ABC8")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x291B5C0", Offset = "0x291B5C0", VA = "0x291B5C0")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x291C0B8", Offset = "0x291C0B8", VA = "0x291C0B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x291C1E0", Offset = "0x291C1E0", VA = "0x291C1E0")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000068")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x291DFCC", Offset = "0x291DFCC", VA = "0x291DFCC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000069")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x291E008", Offset = "0x291E008", VA = "0x291E008")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x291DC54", Offset = "0x291DC54", VA = "0x291DC54")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x291DC98", Offset = "0x291DC98", VA = "0x291DC98")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x291DF24", Offset = "0x291DF24", VA = "0x291DF24")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x291DF94", Offset = "0x291DF94", VA = "0x291DF94")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000576")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x291DE34", Offset = "0x291DE34", VA = "0x291DE34")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x291E0D8", Offset = "0x291E0D8", VA = "0x291E0D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x291E0DC", Offset = "0x291E0DC", VA = "0x291E0DC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x291E10C", Offset = "0x291E10C", VA = "0x291E10C")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x291E1F0", Offset = "0x291E1F0", VA = "0x291E1F0")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x291E46C", Offset = "0x291E46C", VA = "0x291E46C")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x291E528", Offset = "0x291E528", VA = "0x291E528")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13ACF00", Offset = "0x13ACF00")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ACF00", Offset = "0x13ACF00")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0D18", Offset = "0x13B0D18")]
		public float limit;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0D34", Offset = "0x13B0D34")]
		public float twistLimit;

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x291E5A0", Offset = "0x291E5A0", VA = "0x291E5A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B7100", Offset = "0x13B7100")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x291E5EC", Offset = "0x291E5EC", VA = "0x291E5EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B7138", Offset = "0x13B7138")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x291E638", Offset = "0x291E638", VA = "0x291E638")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B7170", Offset = "0x13B7170")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x291E684", Offset = "0x291E684", VA = "0x291E684")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B71A8", Offset = "0x13B71A8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x291E6D0", Offset = "0x291E6D0", VA = "0x291E6D0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x291E788", Offset = "0x291E788", VA = "0x291E788")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x291E9D0", Offset = "0x291E9D0", VA = "0x291E9D0")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13ACF60", Offset = "0x13ACF60")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ACF60", Offset = "0x13ACF60")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x291E9E0", Offset = "0x291E9E0", VA = "0x291E9E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B71E0", Offset = "0x13B71E0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x291EA2C", Offset = "0x291EA2C", VA = "0x291EA2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B7218", Offset = "0x13B7218")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x291EA78", Offset = "0x291EA78", VA = "0x291EA78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B7250", Offset = "0x13B7250")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x291EAC4", Offset = "0x291EAC4", VA = "0x291EAC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B7288", Offset = "0x13B7288")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x291EB10", Offset = "0x291EB10", VA = "0x291EB10", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x291EB38", Offset = "0x291EB38", VA = "0x291EB38")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x291EE38", Offset = "0x291EE38", VA = "0x291EE38")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13ACFC0", Offset = "0x13ACFC0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13ACFC0", Offset = "0x13ACFC0")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x2000128")]
		public class ReachCone
		{
			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000CB")]
			public Vector3 o
			{
				[Token(Token = "0x6000799")]
				[Address(RVA = "0x2920EC4", Offset = "0x2920EC4", VA = "0x2920EC4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CC")]
			public Vector3 a
			{
				[Token(Token = "0x600079A")]
				[Address(RVA = "0x2920EFC", Offset = "0x2920EFC", VA = "0x2920EFC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CD")]
			public Vector3 b
			{
				[Token(Token = "0x600079B")]
				[Address(RVA = "0x2920F38", Offset = "0x2920F38", VA = "0x2920F38")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CE")]
			public Vector3 c
			{
				[Token(Token = "0x600079C")]
				[Address(RVA = "0x2920F74", Offset = "0x2920F74", VA = "0x2920F74")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CF")]
			public bool isValid
			{
				[Token(Token = "0x600079E")]
				[Address(RVA = "0x2920008", Offset = "0x2920008", VA = "0x2920008")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x2920654", Offset = "0x2920654", VA = "0x2920654")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x29207C8", Offset = "0x29207C8", VA = "0x29207C8")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000129")]
		public class LimitPoint
		{
			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x2920018", Offset = "0x2920018", VA = "0x2920018")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0D60", Offset = "0x13B0D60")]
		public float twistLimit;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0D7C", Offset = "0x13B0D7C")]
		public int smoothIterations;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x291EEC0", Offset = "0x291EEC0", VA = "0x291EEC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B72C0", Offset = "0x13B72C0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x291EF0C", Offset = "0x291EF0C", VA = "0x291EF0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B72F8", Offset = "0x13B72F8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x291EF58", Offset = "0x291EF58", VA = "0x291EF58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B7330", Offset = "0x13B7330")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x291EFA4", Offset = "0x291EFA4", VA = "0x291EFA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B7368", Offset = "0x13B7368")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x291EFF0", Offset = "0x291EFF0", VA = "0x291EFF0")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x291F530", Offset = "0x291F530", VA = "0x291F530", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x291F628", Offset = "0x291F628", VA = "0x291F628")]
		private void Start()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x291FC28", Offset = "0x291FC28", VA = "0x291FC28")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x291F098", Offset = "0x291F098", VA = "0x291F098")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x292009C", Offset = "0x292009C", VA = "0x292009C")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x2920988", Offset = "0x2920988", VA = "0x2920988")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x29209CC", Offset = "0x29209CC", VA = "0x29209CC")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x2920B14", Offset = "0x2920B14", VA = "0x2920B14")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x291F8F0", Offset = "0x291F8F0", VA = "0x291F8F0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x2920CA4", Offset = "0x2920CA4", VA = "0x2920CA4")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x2920E54", Offset = "0x2920E54", VA = "0x2920E54")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x13AD020", Offset = "0x13AD020")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x13AD020", Offset = "0x13AD020")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0E3C", Offset = "0x13B0E3C")]
		public float twistLimit;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x2920FB0", Offset = "0x2920FB0", VA = "0x2920FB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B73A0", Offset = "0x13B73A0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x2920FFC", Offset = "0x2920FFC", VA = "0x2920FFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B73D8", Offset = "0x13B73D8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x2921048", Offset = "0x2921048", VA = "0x2921048")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B7410", Offset = "0x13B7410")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x2921094", Offset = "0x2921094", VA = "0x2921094")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x13B7448", Offset = "0x13B7448")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x29210E0", Offset = "0x29210E0", VA = "0x29210E0")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x29210FC", Offset = "0x29210FC", VA = "0x29210FC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x29211B4", Offset = "0x29211B4", VA = "0x29211B4")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x29214E0", Offset = "0x29214E0", VA = "0x29214E0")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x200012A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD190", Offset = "0x13AD190")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000D0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007A4")]
				[Address(RVA = "0x2481D44", Offset = "0x2481D44", VA = "0x2481D44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007A6")]
				[Address(RVA = "0x2481DAC", Offset = "0x2481DAC", VA = "0x2481DAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x2481B14", Offset = "0x2481B14", VA = "0x2481B14")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x2481C14", Offset = "0x2481C14", VA = "0x2481C14", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x2481C18", Offset = "0x2481C18", VA = "0x2481C18", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x2481D4C", Offset = "0x2481D4C", VA = "0x2481D4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0E90", Offset = "0x13B0E90")]
		public AimIK ik;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0EC8", Offset = "0x13B0EC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B0EC8", Offset = "0x13B0EC8")]
		public float weight;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13B0F1C", Offset = "0x13B0F1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0F1C", Offset = "0x13B0F1C")]
		public Transform target;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0F7C", Offset = "0x13B0F7C")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0FB4", Offset = "0x13B0FB4")]
		public float weightSmoothTime;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13B0FEC", Offset = "0x13B0FEC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B0FEC", Offset = "0x13B0FEC")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B104C", Offset = "0x13B104C")]
		public float maxRadiansDelta;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1084", Offset = "0x13B1084")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B10BC", Offset = "0x13B10BC")]
		public float slerpSpeed;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B10F4", Offset = "0x13B10F4")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B112C", Offset = "0x13B112C")]
		public float minDistance;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1164", Offset = "0x13B1164")]
		public Vector3 offset;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13B119C", Offset = "0x13B119C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B119C", Offset = "0x13B119C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B119C", Offset = "0x13B119C")]
		public float maxRootAngle;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1218", Offset = "0x13B1218")]
		public bool turnToTarget;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1250", Offset = "0x13B1250")]
		public float turnToTargetTime;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13B1288", Offset = "0x13B1288")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1288", Offset = "0x13B1288")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B12E8", Offset = "0x13B12E8")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x1700006A")]
		private Vector3 pivot
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x2480D18", Offset = "0x2480D18", VA = "0x2480D18")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x2480C18", Offset = "0x2480C18", VA = "0x2480C18")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x2480E64", Offset = "0x2480E64", VA = "0x2480E64")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x248158C", Offset = "0x248158C", VA = "0x248158C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x2481728", Offset = "0x2481728", VA = "0x2481728")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x2481A98", Offset = "0x2481A98", VA = "0x2481A98")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B7480", Offset = "0x13B7480")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x2481B40", Offset = "0x2481B40", VA = "0x2481B40")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200012B")]
		public class Pose
		{
			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x2482088", Offset = "0x2482088", VA = "0x2482088")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x2482400", Offset = "0x2482400", VA = "0x2482400")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x2482408", Offset = "0x2482408", VA = "0x2482408")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x2481FAC", Offset = "0x2481FAC", VA = "0x2481FAC")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x2482320", Offset = "0x2482320", VA = "0x2482320")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x248238C", Offset = "0x248238C", VA = "0x248238C")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200012C")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000141")]
			public class EffectorLink
			{
				[Token(Token = "0x4000865")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4E10", Offset = "0x13B4E10")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000866")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4E48", Offset = "0x13B4E48")]
				public float weight;

				[Token(Token = "0x60007F9")]
				[Address(RVA = "0x24829F8", Offset = "0x24829F8", VA = "0x24829F8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3E38", Offset = "0x13B3E38")]
			public Transform transform;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3E70", Offset = "0x13B3E70")]
			public Transform relativeTo;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3EA8", Offset = "0x13B3EA8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3EE0", Offset = "0x13B3EE0")]
			public float verticalWeight;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3F18", Offset = "0x13B3F18")]
			public float horizontalWeight;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3F50", Offset = "0x13B3F50")]
			public float speed;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x2482564", Offset = "0x2482564", VA = "0x2482564")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x24829D0", Offset = "0x24829D0", VA = "0x24829D0")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x24829E0", Offset = "0x24829E0", VA = "0x24829E0")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1320", Offset = "0x13B1320")]
		public Body[] bodies;

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x2482424", Offset = "0x2482424", VA = "0x2482424", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x24829C8", Offset = "0x24829C8", VA = "0x24829C8")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1358", Offset = "0x13B1358")]
		public float tiltSpeed;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1390", Offset = "0x13B1390")]
		public float tiltSensitivity;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B13C8", Offset = "0x13B13C8")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1400", Offset = "0x13B1400")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x2484078", Offset = "0x2484078", VA = "0x2484078", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x24840C0", Offset = "0x24840C0", VA = "0x24840C0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x24842F0", Offset = "0x24842F0", VA = "0x24842F0")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200012D")]
		public abstract class HitPoint
		{
			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3F88", Offset = "0x13B3F88")]
			public string name;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3FC0", Offset = "0x13B3FC0")]
			public Collider collider;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B3FF8", Offset = "0x13B3FF8")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4044", Offset = "0x13B4044")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4054", Offset = "0x13B4054")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4064", Offset = "0x13B4064")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4074", Offset = "0x13B4074")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000D2")]
			public bool inProgress
			{
				[Token(Token = "0x60007AD")]
				[Address(RVA = "0x305E864", Offset = "0x305E864", VA = "0x305E864")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000D3")]
			protected float crossFader
			{
				[Token(Token = "0x60007AE")]
				[Address(RVA = "0x305EE0C", Offset = "0x305EE0C", VA = "0x305EE0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7DDC", Offset = "0x13B7DDC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007AF")]
				[Address(RVA = "0x305EE14", Offset = "0x305EE14", VA = "0x305EE14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7DEC", Offset = "0x13B7DEC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D4")]
			protected float timer
			{
				[Token(Token = "0x60007B0")]
				[Address(RVA = "0x305EE1C", Offset = "0x305EE1C", VA = "0x305EE1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7DFC", Offset = "0x13B7DFC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007B1")]
				[Address(RVA = "0x305EE24", Offset = "0x305EE24", VA = "0x305EE24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7E0C", Offset = "0x13B7E0C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D5")]
			protected Vector3 force
			{
				[Token(Token = "0x60007B2")]
				[Address(RVA = "0x305EE2C", Offset = "0x305EE2C", VA = "0x305EE2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7E1C", Offset = "0x13B7E1C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007B3")]
				[Address(RVA = "0x305EE38", Offset = "0x305EE38", VA = "0x305EE38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7E2C", Offset = "0x13B7E2C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D6")]
			protected Vector3 point
			{
				[Token(Token = "0x60007B4")]
				[Address(RVA = "0x305EE44", Offset = "0x305EE44", VA = "0x305EE44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7E3C", Offset = "0x13B7E3C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007B5")]
				[Address(RVA = "0x305EE50", Offset = "0x305EE50", VA = "0x305EE50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7E4C", Offset = "0x13B7E4C")]
				private set
				{
				}
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x305ECD8", Offset = "0x305ECD8", VA = "0x305ECD8")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x305E94C", Offset = "0x305E94C", VA = "0x305E94C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60007B8")]
			protected abstract float GetLength();

			[Token(Token = "0x60007B9")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60007BA")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x305EE5C", Offset = "0x305EE5C", VA = "0x305EE5C")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200012E")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000142")]
			public class EffectorLink
			{
				[Token(Token = "0x4000867")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4E80", Offset = "0x13B4E80")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000868")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4EB8", Offset = "0x13B4EB8")]
				public float weight;

				[Token(Token = "0x4000869")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400086A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60007FA")]
				[Address(RVA = "0x305F7D8", Offset = "0x305F7D8", VA = "0x305F7D8")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60007FB")]
				[Address(RVA = "0x305F5CC", Offset = "0x305F5CC", VA = "0x305F5CC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007FC")]
				[Address(RVA = "0x305FA50", Offset = "0x305FA50", VA = "0x305FA50")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4084", Offset = "0x13B4084")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B40BC", Offset = "0x13B40BC")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B40F4", Offset = "0x13B40F4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x305F3E8", Offset = "0x305F3E8", VA = "0x305F3E8", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x305F560", Offset = "0x305F560", VA = "0x305F560", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x305F5E0", Offset = "0x305F5E0", VA = "0x305F5E0", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x305F8FC", Offset = "0x305F8FC", VA = "0x305F8FC")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200012F")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000143")]
			public class BoneLink
			{
				[Token(Token = "0x400086B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4EF0", Offset = "0x13B4EF0")]
				public Transform bone;

				[Token(Token = "0x400086C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4F28", Offset = "0x13B4F28")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B4F28", Offset = "0x13B4F28")]
				public float weight;

				[Token(Token = "0x400086D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x400086E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60007FD")]
				[Address(RVA = "0x305F1F0", Offset = "0x305F1F0", VA = "0x305F1F0")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60007FE")]
				[Address(RVA = "0x305EF78", Offset = "0x305EF78", VA = "0x305EF78")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007FF")]
				[Address(RVA = "0x305F360", Offset = "0x305F360", VA = "0x305F360")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B412C", Offset = "0x13B412C")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4164", Offset = "0x13B4164")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x305EE70", Offset = "0x305EE70", VA = "0x305EE70", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x305EF14", Offset = "0x305EF14", VA = "0x305EF14", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x305EF84", Offset = "0x305EF84", VA = "0x305EF84", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x305F34C", Offset = "0x305F34C", VA = "0x305F34C")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1438", Offset = "0x13B1438")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1470", Offset = "0x13B1470")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700006B")]
		public bool inProgress
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x305E7A8", Offset = "0x305E7A8", VA = "0x305E7A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x305E878", Offset = "0x305E878", VA = "0x305E878", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x305EA98", Offset = "0x305EA98", VA = "0x305EA98")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x305EE04", Offset = "0x305EE04", VA = "0x305EE04")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x2000130")]
		public abstract class Offset
		{
			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B419C", Offset = "0x13B419C")]
			public string name;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B41D4", Offset = "0x13B41D4")]
			public Collider collider;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B420C", Offset = "0x13B420C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4258", Offset = "0x13B4258")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4268", Offset = "0x13B4268")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4278", Offset = "0x13B4278")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B4288", Offset = "0x13B4288")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000D7")]
			protected float crossFader
			{
				[Token(Token = "0x60007C4")]
				[Address(RVA = "0x3060008", Offset = "0x3060008", VA = "0x3060008")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7E5C", Offset = "0x13B7E5C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007C5")]
				[Address(RVA = "0x3060010", Offset = "0x3060010", VA = "0x3060010")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7E6C", Offset = "0x13B7E6C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D8")]
			protected float timer
			{
				[Token(Token = "0x60007C6")]
				[Address(RVA = "0x3060018", Offset = "0x3060018", VA = "0x3060018")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7E7C", Offset = "0x13B7E7C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007C7")]
				[Address(RVA = "0x3060020", Offset = "0x3060020", VA = "0x3060020")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7E8C", Offset = "0x13B7E8C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D9")]
			protected Vector3 force
			{
				[Token(Token = "0x60007C8")]
				[Address(RVA = "0x3060028", Offset = "0x3060028", VA = "0x3060028")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7E9C", Offset = "0x13B7E9C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007C9")]
				[Address(RVA = "0x3060034", Offset = "0x3060034", VA = "0x3060034")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7EAC", Offset = "0x13B7EAC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DA")]
			protected Vector3 point
			{
				[Token(Token = "0x60007CA")]
				[Address(RVA = "0x3060040", Offset = "0x3060040", VA = "0x3060040")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7EBC", Offset = "0x13B7EBC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007CB")]
				[Address(RVA = "0x306004C", Offset = "0x306004C", VA = "0x306004C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B7ECC", Offset = "0x13B7ECC")]
				private set
				{
				}
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x305FEC0", Offset = "0x305FEC0", VA = "0x305FEC0")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x305FB24", Offset = "0x305FB24", VA = "0x305FB24")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60007CE")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x60007CF")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60007D0")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x3060058", Offset = "0x3060058", VA = "0x3060058")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000131")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000144")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x400086F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4F7C", Offset = "0x13B4F7C")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000870")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4FB4", Offset = "0x13B4FB4")]
				public float weight;

				[Token(Token = "0x4000871")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000872")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000800")]
				[Address(RVA = "0x3060514", Offset = "0x3060514", VA = "0x3060514")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000801")]
				[Address(RVA = "0x30602D0", Offset = "0x30602D0", VA = "0x30602D0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000802")]
				[Address(RVA = "0x3060630", Offset = "0x3060630", VA = "0x3060630")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4298", Offset = "0x13B4298")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B42D0", Offset = "0x13B42D0")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4308", Offset = "0x13B4308")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x306006C", Offset = "0x306006C", VA = "0x306006C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x3060264", Offset = "0x3060264", VA = "0x3060264", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x30602E4", Offset = "0x30602E4", VA = "0x30602E4", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x3060614", Offset = "0x3060614", VA = "0x3060614")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000132")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000145")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000873")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4FEC", Offset = "0x13B4FEC")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000874")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B5024", Offset = "0x13B5024")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B5024", Offset = "0x13B5024")]
				public float weight;

				[Token(Token = "0x4000875")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000876")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000803")]
				[Address(RVA = "0x3060AAC", Offset = "0x3060AAC", VA = "0x3060AAC")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000804")]
				[Address(RVA = "0x3060780", Offset = "0x3060780", VA = "0x3060780")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000805")]
				[Address(RVA = "0x3060BE8", Offset = "0x3060BE8", VA = "0x3060BE8")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4340", Offset = "0x13B4340")]
			public int curveIndex;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4378", Offset = "0x13B4378")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x3060638", Offset = "0x3060638", VA = "0x3060638", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x306071C", Offset = "0x306071C", VA = "0x306071C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x306078C", Offset = "0x306078C", VA = "0x306078C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x3060BD4", Offset = "0x3060BD4", VA = "0x3060BD4")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B14A8", Offset = "0x13B14A8")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B14E0", Offset = "0x13B14E0")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x305FA58", Offset = "0x305FA58", VA = "0x305FA58", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x305FC78", Offset = "0x305FC78", VA = "0x305FC78")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x3060000", Offset = "0x3060000", VA = "0x3060000")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000133")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000146")]
			public class EffectorLink
			{
				[Token(Token = "0x4000877")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B5078", Offset = "0x13B5078")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000878")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B50B0", Offset = "0x13B50B0")]
				public float weight;

				[Token(Token = "0x6000806")]
				[Address(RVA = "0x2F709A0", Offset = "0x2F709A0", VA = "0x2F709A0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B43B0", Offset = "0x13B43B0")]
			public Transform transform;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B43E8", Offset = "0x13B43E8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4420", Offset = "0x13B4420")]
			public float speed;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4458", Offset = "0x13B4458")]
			public float acceleration;

			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4490", Offset = "0x13B4490")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B4490", Offset = "0x13B4490")]
			public float matchVelocity;

			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B44E4", Offset = "0x13B44E4")]
			public float gravity;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x2F7046C", Offset = "0x2F7046C", VA = "0x2F7046C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x2F70604", Offset = "0x2F70604", VA = "0x2F70604")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x2F70984", Offset = "0x2F70984", VA = "0x2F70984")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1518", Offset = "0x13B1518")]
		public Body[] bodies;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1550", Offset = "0x13B1550")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x2F703F4", Offset = "0x2F703F4", VA = "0x2F703F4")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x2F70548", Offset = "0x2F70548", VA = "0x2F70548", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x2F7097C", Offset = "0x2F7097C", VA = "0x2F7097C")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13B1588", Offset = "0x13B1588")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1588", Offset = "0x13B1588")]
		public Transform target;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B15E8", Offset = "0x13B15E8")]
		public float weight;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1600", Offset = "0x13B1600")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1638", Offset = "0x13B1638")]
		public float weightSmoothTime;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13B1670", Offset = "0x13B1670")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1670", Offset = "0x13B1670")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B16D0", Offset = "0x13B16D0")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1708", Offset = "0x13B1708")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1740", Offset = "0x13B1740")]
		public float slerpSpeed;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1778", Offset = "0x13B1778")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B17B0", Offset = "0x13B17B0")]
		public float minDistance;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x13B17E8", Offset = "0x13B17E8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B17E8", Offset = "0x13B17E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B17E8", Offset = "0x13B17E8")]
		public float maxRootAngle;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x1700006C")]
		private Vector3 pivot
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x29180C4", Offset = "0x29180C4", VA = "0x29180C4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x2917FDC", Offset = "0x2917FDC", VA = "0x2917FDC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x2918210", Offset = "0x2918210", VA = "0x2918210")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x29188B4", Offset = "0x29188B4", VA = "0x29188B4")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x2918A50", Offset = "0x2918A50", VA = "0x2918A50")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x2918D6C", Offset = "0x2918D6C", VA = "0x2918D6C")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000134")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B451C", Offset = "0x13B451C")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4554", Offset = "0x13B4554")]
			public float spring;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B458C", Offset = "0x13B458C")]
			public bool x;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B45C4", Offset = "0x13B45C4")]
			public bool y;

			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B45FC", Offset = "0x13B45FC")]
			public bool z;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4634", Offset = "0x13B4634")]
			public float minX;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B466C", Offset = "0x13B466C")]
			public float maxX;

			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B46A4", Offset = "0x13B46A4")]
			public float minY;

			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B46DC", Offset = "0x13B46DC")]
			public float maxY;

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4714", Offset = "0x13B4714")]
			public float minZ;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B474C", Offset = "0x13B474C")]
			public float maxZ;

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x2919294", Offset = "0x2919294", VA = "0x2919294")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x29197F0", Offset = "0x29197F0", VA = "0x29197F0")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x2919820", Offset = "0x2919820", VA = "0x2919820")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x29198F8", Offset = "0x29198F8", VA = "0x29198F8")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000135")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD1A0", Offset = "0x13AD1A0")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000DB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E4")]
				[Address(RVA = "0x2919780", Offset = "0x2919780", VA = "0x2919780", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E6")]
				[Address(RVA = "0x29197E8", Offset = "0x29197E8", VA = "0x29197E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x29190A0", Offset = "0x29190A0", VA = "0x29190A0")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x2919620", Offset = "0x2919620", VA = "0x2919620", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x2919624", Offset = "0x2919624", VA = "0x2919624", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x2919788", Offset = "0x2919788", VA = "0x2919788", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1864", Offset = "0x13B1864")]
		public float weight;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B189C", Offset = "0x13B189C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x1700006D")]
		protected float deltaTime
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x2918FCC", Offset = "0x2918FCC", VA = "0x2918FCC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005C4")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x2918FF8", Offset = "0x2918FF8", VA = "0x2918FF8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x2919024", Offset = "0x2919024", VA = "0x2919024")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B74E4", Offset = "0x13B74E4")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x29190CC", Offset = "0x29190CC", VA = "0x29190CC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x29191D8", Offset = "0x29191D8", VA = "0x29191D8")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x29194F4", Offset = "0x29194F4", VA = "0x29194F4", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x2919610", Offset = "0x2919610", VA = "0x2919610")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000136")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13AD1B0", Offset = "0x13AD1B0")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000DD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007EA")]
				[Address(RVA = "0x2919D98", Offset = "0x2919D98", VA = "0x2919D98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007EC")]
				[Address(RVA = "0x2919E00", Offset = "0x2919E00", VA = "0x2919E00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x29199D4", Offset = "0x29199D4", VA = "0x29199D4")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x2919C38", Offset = "0x2919C38", VA = "0x2919C38", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x2919C3C", Offset = "0x2919C3C", VA = "0x2919C3C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x2919DA0", Offset = "0x2919DA0", VA = "0x2919DA0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B18D4", Offset = "0x13B18D4")]
		public float weight;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B190C", Offset = "0x13B190C")]
		public VRIK ik;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x1700006E")]
		protected float deltaTime
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x2919900", Offset = "0x2919900", VA = "0x2919900")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005CC")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x291992C", Offset = "0x291992C", VA = "0x291992C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x2919958", Offset = "0x2919958", VA = "0x2919958")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x13B7548", Offset = "0x13B7548")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2919A00", Offset = "0x2919A00", VA = "0x2919A00")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x2919B0C", Offset = "0x2919B0C", VA = "0x2919B0C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x2919C28", Offset = "0x2919C28", VA = "0x2919C28")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000137")]
		public class EffectorLink
		{
			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x2919EC8", Offset = "0x2919EC8", VA = "0x2919EC8")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x291A324", Offset = "0x291A324", VA = "0x291A324")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x2919E08", Offset = "0x2919E08", VA = "0x2919E08")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x291A200", Offset = "0x291A200", VA = "0x291A200")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x291A2B8", Offset = "0x291A2B8", VA = "0x291A2B8")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000138")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x2000147")]
			public class EffectorLink
			{
				[Token(Token = "0x4000879")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B50E8", Offset = "0x13B50E8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400087A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B5120", Offset = "0x13B5120")]
				public float weight;

				[Token(Token = "0x6000807")]
				[Address(RVA = "0x291A9DC", Offset = "0x291A9DC", VA = "0x291A9DC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4784", Offset = "0x13B4784")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B47BC", Offset = "0x13B47BC")]
			public Transform raycastTo;

			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B47F4", Offset = "0x13B47F4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B47F4", Offset = "0x13B47F4")]
			public float raycastRadius;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4848", Offset = "0x13B4848")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4880", Offset = "0x13B4880")]
			public float smoothTimeIn;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B48B8", Offset = "0x13B48B8")]
			public float smoothTimeOut;

			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B48F0", Offset = "0x13B48F0")]
			public LayerMask layers;

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x291A3B0", Offset = "0x291A3B0", VA = "0x291A3B0")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x291A5BC", Offset = "0x291A5BC", VA = "0x291A5BC")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x291A754", Offset = "0x291A754", VA = "0x291A754")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x291A9C8", Offset = "0x291A9C8", VA = "0x291A9C8")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1944", Offset = "0x13B1944")]
		public Avoider[] avoiders;

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x291A32C", Offset = "0x291A32C", VA = "0x291A32C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x291A5AC", Offset = "0x291A5AC", VA = "0x291A5AC")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000139")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x2000148")]
			public class EffectorLink
			{
				[Token(Token = "0x400087B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B5158", Offset = "0x13B5158")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400087C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B5190", Offset = "0x13B5190")]
				public float weight;

				[Token(Token = "0x6000808")]
				[Address(RVA = "0x291DC4C", Offset = "0x291DC4C", VA = "0x291DC4C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4928", Offset = "0x13B4928")]
			public Vector3 offset;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4960", Offset = "0x13B4960")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B4960", Offset = "0x13B4960")]
			public float additivity;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B49B4", Offset = "0x13B49B4")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B49EC", Offset = "0x13B49EC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x291C93C", Offset = "0x291C93C", VA = "0x291C93C")]
			public void Start()
			{
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x291D4F0", Offset = "0x291D4F0", VA = "0x291D4F0")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x291DC38", Offset = "0x291DC38", VA = "0x291DC38")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013A")]
		public enum Handedness
		{
			[Token(Token = "0x4000836")]
			Right,
			[Token(Token = "0x4000837")]
			Left
		}

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B197C", Offset = "0x13B197C")]
		public AimIK aimIK;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B19B4", Offset = "0x13B19B4")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B19EC", Offset = "0x13B19EC")]
		public Handedness handedness;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1A24", Offset = "0x13B1A24")]
		public bool twoHanded;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1A5C", Offset = "0x13B1A5C")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1A94", Offset = "0x13B1A94")]
		public float magnitudeRandom;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1ACC", Offset = "0x13B1ACC")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1B04", Offset = "0x13B1B04")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1B3C", Offset = "0x13B1B3C")]
		public float blendTime;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x13B1B74", Offset = "0x13B1B74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1B74", Offset = "0x13B1B74")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x1700006F")]
		public bool isFinished
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x291C714", Offset = "0x291C714", VA = "0x291C714")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x291D7A4", Offset = "0x291D7A4", VA = "0x291D7A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x291D7E4", Offset = "0x291D7E4", VA = "0x291D7E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		private Transform primaryHand
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x291D764", Offset = "0x291D764", VA = "0x291D764")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x291D784", Offset = "0x291D784", VA = "0x291D784")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x291C744", Offset = "0x291C744", VA = "0x291C744")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x291C770", Offset = "0x291C770", VA = "0x291C770")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x291C9EC", Offset = "0x291C9EC", VA = "0x291C9EC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x291D824", Offset = "0x291D824", VA = "0x291D824")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x291D97C", Offset = "0x291D97C", VA = "0x291D97C")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x291D9B8", Offset = "0x291D9B8", VA = "0x291D9B8", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x291DB84", Offset = "0x291DB84", VA = "0x291DB84")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1BD4", Offset = "0x13B1BD4")]
		public float weight;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B1C0C", Offset = "0x13B1C0C")]
		public float offset;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x29214EC", Offset = "0x29214EC", VA = "0x29214EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x29215E0", Offset = "0x29215E0", VA = "0x29215E0")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x29216CC", Offset = "0x29216CC", VA = "0x29216CC")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x2921B14", Offset = "0x2921B14", VA = "0x2921B14")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x2921B4C", Offset = "0x2921B4C", VA = "0x2921B4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x2921C68", Offset = "0x2921C68", VA = "0x2921C68")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x200013B")]
		public class Settings
		{
			[Token(Token = "0x4000838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4A24", Offset = "0x13B4A24")]
			public float scaleMlp;

			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4A5C", Offset = "0x13B4A5C")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4A94", Offset = "0x13B4A94")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4ACC", Offset = "0x13B4ACC")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4B04", Offset = "0x13B4B04")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4B3C", Offset = "0x13B4B3C")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4B74", Offset = "0x13B4B74")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4BAC", Offset = "0x13B4BAC")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4BE4", Offset = "0x13B4BE4")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x13B4C1C", Offset = "0x13B4C1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4C1C", Offset = "0x13B4C1C")]
			public Vector3 headOffset;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4C6C", Offset = "0x13B4C6C")]
			public Vector3 handOffset;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4CA4", Offset = "0x13B4CA4")]
			public float footForwardOffset;

			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4CDC", Offset = "0x13B4CDC")]
			public float footInwardOffset;

			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x13B4D14", Offset = "0x13B4D14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B4D14", Offset = "0x13B4D14")]
			public float footHeadingOffset;

			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B4D70", Offset = "0x13B4D70")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x13B4D88", Offset = "0x13B4D88")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x29270A8", Offset = "0x29270A8", VA = "0x29270A8")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013C")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x2000149")]
			public class Target
			{
				[Token(Token = "0x400087D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x400087E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x400087F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000809")]
				[Address(RVA = "0x29260D4", Offset = "0x29260D4", VA = "0x29260D4")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x600080A")]
				[Address(RVA = "0x2926C48", Offset = "0x2926C48", VA = "0x2926C48")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x400084A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x2925518", Offset = "0x2925518", VA = "0x2925518")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x292405C", Offset = "0x292405C", VA = "0x292405C")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x29241C4", Offset = "0x29241C4", VA = "0x29241C4")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x2925690", Offset = "0x2925690", VA = "0x2925690")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x2926198", Offset = "0x2926198", VA = "0x2926198")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x2926CA8", Offset = "0x2926CA8", VA = "0x2926CA8")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B1C44", Offset = "0x13B1C44")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x17000074")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x29271A0", Offset = "0x29271A0", VA = "0x29271A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B75AC", Offset = "0x13B75AC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x29271AC", Offset = "0x29271AC", VA = "0x29271AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x13B75BC", Offset = "0x13B75BC")]
			private set
			{
			}
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x29271B8", Offset = "0x29271B8", VA = "0x29271B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x2925E78", Offset = "0x2925E78", VA = "0x2925E78")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x2926F00", Offset = "0x2926F00", VA = "0x2926F00")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x29272B4", Offset = "0x29272B4", VA = "0x29272B4")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x2927758", Offset = "0x2927758", VA = "0x2927758")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x2927874", Offset = "0x2927874", VA = "0x2927874")]
		public VRIKRootController()
		{
		}
	}
}
