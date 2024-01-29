using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityStandardAssets.Utility;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	protected Image _image;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x97E3AC", Offset = "0x97E3AC", VA = "0x97E3AC")]
	public void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x97E564", Offset = "0x97E564", VA = "0x97E564", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x97E848", Offset = "0x97E848", VA = "0x97E848")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000003")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x97E850", Offset = "0x97E850", VA = "0x97E850")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x97E958", Offset = "0x97E958", VA = "0x97E958")]
	public EventSystemChecker()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000004")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000005")]
		public enum Mode
		{
			[Token(Token = "0x4000008")]
			Trigger,
			[Token(Token = "0x4000009")]
			Replace,
			[Token(Token = "0x400000A")]
			Activate,
			[Token(Token = "0x400000B")]
			Enable,
			[Token(Token = "0x400000C")]
			Animate,
			[Token(Token = "0x400000D")]
			Deactivate
		}

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		public Mode action;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x20")]
		public UnityEngine.Object target;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x28")]
		public GameObject source;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x30")]
		public int triggerCount;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x34")]
		public bool repeatTrigger;

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x97E960", Offset = "0x97E960", VA = "0x97E960")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x97ED9C", Offset = "0x97ED9C", VA = "0x97ED9C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x97EDA0", Offset = "0x97EDA0", VA = "0x97EDA0")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000007")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x600000B")]
			[Address(RVA = "0x97F7D8", Offset = "0x97F7D8", VA = "0x97F7D8")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000008")]
		public class ReplacementList
		{
			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x600000C")]
			[Address(RVA = "0x97F7E0", Offset = "0x97F7E0", VA = "0x97F7E0")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x97EDB8", Offset = "0x97EDB8", VA = "0x97EDB8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x97F7D0", Offset = "0x97F7D0", VA = "0x97F7D0")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000A")]
		public class Vector3andSpace
		{
			[Token(Token = "0x4000016")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x4000017")]
			[FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x6000010")]
			[Address(RVA = "0x97F920", Offset = "0x97F920", VA = "0x97F920")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x97F838", Offset = "0x97F838", VA = "0x97F838")]
		private void Start()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x97F854", Offset = "0x97F854", VA = "0x97F854")]
		private void Update()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x97F918", Offset = "0x97F918", VA = "0x97F918")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class CameraRefocus
	{
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x97F930", Offset = "0x97F930", VA = "0x97F930")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x97F984", Offset = "0x97F984", VA = "0x97F984")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x97F98C", Offset = "0x97F98C", VA = "0x97F98C")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x97F994", Offset = "0x97F994", VA = "0x97F994")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x97FA80", Offset = "0x97FA80", VA = "0x97FA80")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public class CurveControlledBob
	{
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x97FAC4", Offset = "0x97FAC4", VA = "0x97FAC4")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x97FB64", Offset = "0x97FB64", VA = "0x97FB64")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x97FC54", Offset = "0x97FC54", VA = "0x97FC54")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400002D")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400002E")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400002F")]
			[FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x4000030")]
			[FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000031")]
			[FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x4000032")]
			[FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x4000033")]
			[FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x17000001")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000020")]
				[Address(RVA = "0x9805B0", Offset = "0x9805B0", VA = "0x9805B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000002")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000022")]
				[Address(RVA = "0x9805F8", Offset = "0x9805F8", VA = "0x9805F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600001D")]
			[Address(RVA = "0x980354", Offset = "0x980354", VA = "0x980354")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600001E")]
			[Address(RVA = "0x980384", Offset = "0x980384", VA = "0x980384", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600001F")]
			[Address(RVA = "0x980388", Offset = "0x980388", VA = "0x980388", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000021")]
			[Address(RVA = "0x9805B8", Offset = "0x9805B8", VA = "0x9805B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000026")]
		private const float k_Spring = 50f;

		[Token(Token = "0x4000027")]
		private const float k_Damper = 5f;

		[Token(Token = "0x4000028")]
		private const float k_Drag = 10f;

		[Token(Token = "0x4000029")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x400002A")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x400002B")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x97FE94", Offset = "0x97FE94", VA = "0x97FE94")]
		private void Update()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x9802DC", Offset = "0x9802DC", VA = "0x9802DC")]
		[IteratorStateMachine(typeof(<DragObject>d__8))]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x980230", Offset = "0x980230", VA = "0x980230")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x98037C", Offset = "0x98037C", VA = "0x98037C")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x980600", Offset = "0x980600", VA = "0x980600")]
		private void Start()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x980628", Offset = "0x980628", VA = "0x980628")]
		private void Update()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x98084C", Offset = "0x98084C", VA = "0x98084C")]
		public DynamicShadowSettings()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x980880", Offset = "0x980880", VA = "0x980880")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x9808DC", Offset = "0x9808DC", VA = "0x9808DC")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	public class FOVKick
	{
		[Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000047")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000048")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000049")]
			[FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x400004A")]
			[FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000003")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000031")]
				[Address(RVA = "0x980C88", Offset = "0x980C88", VA = "0x980C88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000004")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000033")]
				[Address(RVA = "0x980CD0", Offset = "0x980CD0", VA = "0x980CD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600002E")]
			[Address(RVA = "0x980A88", Offset = "0x980A88", VA = "0x980A88")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600002F")]
			[Address(RVA = "0x980B5C", Offset = "0x980B5C", VA = "0x980B5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000030")]
			[Address(RVA = "0x980B60", Offset = "0x980B60", VA = "0x980B60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000032")]
			[Address(RVA = "0x980C90", Offset = "0x980C90", VA = "0x980C90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400004B")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400004C")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400004D")]
			[FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x400004E")]
			[FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000005")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000037")]
				[Address(RVA = "0x980E18", Offset = "0x980E18", VA = "0x980E18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000006")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000039")]
				[Address(RVA = "0x980E60", Offset = "0x980E60", VA = "0x980E60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000034")]
			[Address(RVA = "0x980B18", Offset = "0x980B18", VA = "0x980B18")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000035")]
			[Address(RVA = "0x980CD8", Offset = "0x980CD8", VA = "0x980CD8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000036")]
			[Address(RVA = "0x980CDC", Offset = "0x980CDC", VA = "0x980CDC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000038")]
			[Address(RVA = "0x980E20", Offset = "0x980E20", VA = "0x980E20", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x9808F4", Offset = "0x9808F4", VA = "0x9808F4")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x980930", Offset = "0x980930", VA = "0x980930")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x980A18", Offset = "0x980A18", VA = "0x980A18")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x980A20", Offset = "0x980A20", VA = "0x980A20")]
		[IteratorStateMachine(typeof(<FOVKickUp>d__9))]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x980AB0", Offset = "0x980AB0", VA = "0x980AB0")]
		[IteratorStateMachine(typeof(<FOVKickDown>d__10))]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x980B40", Offset = "0x980B40", VA = "0x980B40")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x2000014")]
	[RequireComponent(typeof(Text))]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x400004F")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x4000053")]
		private const string display = "{0} FPS";

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x980E68", Offset = "0x980E68", VA = "0x980E68")]
		private void Start()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x980ECC", Offset = "0x980ECC", VA = "0x980ECC")]
		private void Update()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x980FC0", Offset = "0x980FC0", VA = "0x980FC0")]
		public FPSCounter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000015")]
	public class LerpControlledBob
	{
		[Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000058")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000059")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400005A")]
			[FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x400005B")]
			[FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000007")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000043")]
				[Address(RVA = "0x981208", Offset = "0x981208", VA = "0x981208", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000008")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000045")]
				[Address(RVA = "0x981250", Offset = "0x981250", VA = "0x981250", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000040")]
			[Address(RVA = "0x981038", Offset = "0x981038", VA = "0x981038")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000041")]
			[Address(RVA = "0x981068", Offset = "0x981068", VA = "0x981068", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000042")]
			[Address(RVA = "0x98106C", Offset = "0x98106C", VA = "0x98106C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000044")]
			[Address(RVA = "0x981210", Offset = "0x981210", VA = "0x981210", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x980FC8", Offset = "0x980FC8", VA = "0x980FC8")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x980FD0", Offset = "0x980FD0", VA = "0x980FD0")]
		[IteratorStateMachine(typeof(<DoBobCycle>d__4))]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x981060", Offset = "0x981060", VA = "0x981060")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000060")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000061")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000062")]
			[FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000063")]
			[FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x17000009")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600004D")]
				[Address(RVA = "0x9816B0", Offset = "0x9816B0", VA = "0x9816B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600004F")]
				[Address(RVA = "0x9816F8", Offset = "0x9816F8", VA = "0x9816F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600004A")]
			[Address(RVA = "0x9813FC", Offset = "0x9813FC", VA = "0x9813FC")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600004B")]
			[Address(RVA = "0x98142C", Offset = "0x98142C", VA = "0x98142C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600004C")]
			[Address(RVA = "0x981430", Offset = "0x981430", VA = "0x981430", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0x9816B8", Offset = "0x9816B8", VA = "0x9816B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x981258", Offset = "0x981258", VA = "0x981258")]
		private void Start()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x981364", Offset = "0x981364", VA = "0x981364")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x981384", Offset = "0x981384", VA = "0x981384")]
		[IteratorStateMachine(typeof(<ResetCoroutine>d__6))]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x981424", Offset = "0x981424", VA = "0x981424")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000068")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000069")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400006A")]
			[FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x400006B")]
			[FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x400006C")]
			[FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x1700000B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000056")]
				[Address(RVA = "0x981AC4", Offset = "0x981AC4", VA = "0x981AC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000058")]
				[Address(RVA = "0x981B0C", Offset = "0x981B0C", VA = "0x981B0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000053")]
			[Address(RVA = "0x981768", Offset = "0x981768", VA = "0x981768")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000054")]
			[Address(RVA = "0x9817B0", Offset = "0x9817B0", VA = "0x9817B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000055")]
			[Address(RVA = "0x9817B4", Offset = "0x9817B4", VA = "0x9817B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000057")]
			[Address(RVA = "0x981ACC", Offset = "0x981ACC", VA = "0x981ACC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x981700", Offset = "0x981700", VA = "0x981700")]
		[IteratorStateMachine(typeof(<Start>d__4))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x981790", Offset = "0x981790", VA = "0x981790")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x98179C", Offset = "0x98179C", VA = "0x98179C")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x200001C")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x4000072")]
			Standalone,
			[Token(Token = "0x4000073")]
			Mobile
		}

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x981B14", Offset = "0x981B14", VA = "0x981B14")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x981B18", Offset = "0x981B18", VA = "0x981B18")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x981B28", Offset = "0x981B28", VA = "0x981B28")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x981F14", Offset = "0x981F14", VA = "0x981F14")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x981F98", Offset = "0x981F98", VA = "0x981F98")]
		private void Start()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x981FC8", Offset = "0x981FC8", VA = "0x981FC8")]
		private void Update()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x9823F0", Offset = "0x9823F0", VA = "0x9823F0")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x982410", Offset = "0x982410", VA = "0x982410")]
		private void Start()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x982414", Offset = "0x982414", VA = "0x982414")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x982748", Offset = "0x982748", VA = "0x982748")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000020")]
		public enum Action
		{
			[Token(Token = "0x4000085")]
			Activate,
			[Token(Token = "0x4000086")]
			Deactivate,
			[Token(Token = "0x4000087")]
			Destroy,
			[Token(Token = "0x4000088")]
			ReloadLevel,
			[Token(Token = "0x4000089")]
			Call
		}

		[Serializable]
		[Token(Token = "0x2000021")]
		public class Entry
		{
			[Token(Token = "0x400008A")]
			[FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x400008B")]
			[FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x400008C")]
			[FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x6000068")]
			[Address(RVA = "0x982A94", Offset = "0x982A94", VA = "0x982A94")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000022")]
		public class Entries
		{
			[Token(Token = "0x400008D")]
			[FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x6000069")]
			[Address(RVA = "0x982A8C", Offset = "0x982A8C", VA = "0x982A8C")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400008E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400008F")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000090")]
			[FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700000D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600006D")]
				[Address(RVA = "0x982B64", Offset = "0x982B64", VA = "0x982B64", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600006F")]
				[Address(RVA = "0x982BAC", Offset = "0x982BAC", VA = "0x982BAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600006A")]
			[Address(RVA = "0x9829AC", Offset = "0x9829AC", VA = "0x9829AC")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x600006B")]
			[Address(RVA = "0x982A9C", Offset = "0x982A9C", VA = "0x982A9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600006C")]
			[Address(RVA = "0x982AA0", Offset = "0x982AA0", VA = "0x982AA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600006E")]
			[Address(RVA = "0x982B6C", Offset = "0x982B6C", VA = "0x982B6C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000091")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000092")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000093")]
			[FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700000F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000073")]
				[Address(RVA = "0x982C7C", Offset = "0x982C7C", VA = "0x982C7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000010")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000075")]
				[Address(RVA = "0x982CC4", Offset = "0x982CC4", VA = "0x982CC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000070")]
			[Address(RVA = "0x9829D4", Offset = "0x9829D4", VA = "0x9829D4")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000071")]
			[Address(RVA = "0x982BB4", Offset = "0x982BB4", VA = "0x982BB4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000072")]
			[Address(RVA = "0x982BB8", Offset = "0x982BB8", VA = "0x982BB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000074")]
			[Address(RVA = "0x982C84", Offset = "0x982C84", VA = "0x982C84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000094")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000095")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000096")]
			[FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000011")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000079")]
				[Address(RVA = "0x982DD0", Offset = "0x982DD0", VA = "0x982DD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000012")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600007B")]
				[Address(RVA = "0x982E18", Offset = "0x982E18", VA = "0x982E18", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000076")]
			[Address(RVA = "0x9829FC", Offset = "0x9829FC", VA = "0x9829FC")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000077")]
			[Address(RVA = "0x982CCC", Offset = "0x982CCC", VA = "0x982CCC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000078")]
			[Address(RVA = "0x982CD0", Offset = "0x982CD0", VA = "0x982CD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600007A")]
			[Address(RVA = "0x982DD8", Offset = "0x982DD8", VA = "0x982DD8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x98275C", Offset = "0x98275C", VA = "0x98275C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x982874", Offset = "0x982874", VA = "0x982874")]
		[IteratorStateMachine(typeof(<Activate>d__5))]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x9828DC", Offset = "0x9828DC", VA = "0x9828DC")]
		[IteratorStateMachine(typeof(<Deactivate>d__6))]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x982944", Offset = "0x982944", VA = "0x982944")]
		[IteratorStateMachine(typeof(<ReloadLevel>d__7))]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x982A24", Offset = "0x982A24", VA = "0x982A24")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x982E20", Offset = "0x982E20", VA = "0x982E20")]
		private void Awake()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x982E70", Offset = "0x982E70", VA = "0x982E70")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x982F00", Offset = "0x982F00", VA = "0x982F00")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000028")]
		public class WaypointList
		{
			[Token(Token = "0x40000A9")]
			[FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x40000AA")]
			[FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x600008B")]
			[Address(RVA = "0x9839E4", Offset = "0x9839E4", VA = "0x9839E4")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x2000029")]
		public struct RoutePoint
		{
			[Token(Token = "0x40000AB")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40000AC")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x600008C")]
			[Address(RVA = "0x9835DC", Offset = "0x9835DC", VA = "0x9835DC")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000013")]
		public float Length
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x982F10", Offset = "0x982F10", VA = "0x982F10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x982F18", Offset = "0x982F18", VA = "0x982F18")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x982F20", Offset = "0x982F20", VA = "0x982F20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x982F3C", Offset = "0x982F3C", VA = "0x982F3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x98324C", Offset = "0x98324C", VA = "0x98324C")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x98337C", Offset = "0x98337C", VA = "0x98337C")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x9835EC", Offset = "0x9835EC", VA = "0x9835EC")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x982F8C", Offset = "0x982F8C", VA = "0x982F8C")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x9836F8", Offset = "0x9836F8", VA = "0x9836F8")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x983968", Offset = "0x983968", VA = "0x983968")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x983700", Offset = "0x983700", VA = "0x983700")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x983970", Offset = "0x983970", VA = "0x983970")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x200002B")]
		public enum ProgressStyle
		{
			[Token(Token = "0x40000BD")]
			SmoothAlongRoute,
			[Token(Token = "0x40000BE")]
			PointToPoint
		}

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000015")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x983A3C", Offset = "0x983A3C", VA = "0x983A3C")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x983A50", Offset = "0x983A50", VA = "0x983A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x983A64", Offset = "0x983A64", VA = "0x983A64")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x983A78", Offset = "0x983A78", VA = "0x983A78")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x983A8C", Offset = "0x983A8C", VA = "0x983A8C")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x983AA0", Offset = "0x983AA0", VA = "0x983AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x983AB4", Offset = "0x983AB4", VA = "0x983AB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x983B98", Offset = "0x983B98", VA = "0x983B98")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x983C64", Offset = "0x983C64", VA = "0x983C64")]
		private void Update()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x98413C", Offset = "0x98413C", VA = "0x98413C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x984298", Offset = "0x984298", VA = "0x984298")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x200002C")]
	[RequireComponent(typeof(SphereCollider))]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x9842B4", Offset = "0x9842B4", VA = "0x9842B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x984358", Offset = "0x984358", VA = "0x984358")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x9848B0", Offset = "0x9848B0", VA = "0x9848B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x984DC8", Offset = "0x984DC8", VA = "0x984DC8")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000C9")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000CA")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000CB")]
			[FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x40000CC")]
			[FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x17000018")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000A2")]
				[Address(RVA = "0x9854E4", Offset = "0x9854E4", VA = "0x9854E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000019")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000A4")]
				[Address(RVA = "0x98552C", Offset = "0x98552C", VA = "0x98552C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600009F")]
			[Address(RVA = "0x984E44", Offset = "0x984E44", VA = "0x984E44")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x984FC0", Offset = "0x984FC0", VA = "0x984FC0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x984FC4", Offset = "0x984FC4", VA = "0x984FC4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x9854EC", Offset = "0x9854EC", VA = "0x9854EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x984DDC", Offset = "0x984DDC", VA = "0x984DDC")]
		[IteratorStateMachine(typeof(<Start>d__4))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x984E6C", Offset = "0x984E6C", VA = "0x984E6C")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x984FB8", Offset = "0x984FB8", VA = "0x984FB8")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000CE")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000CF")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000D0")]
			[FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x1700001A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000AA")]
				[Address(RVA = "0x9859A4", Offset = "0x9859A4", VA = "0x9859A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000AC")]
				[Address(RVA = "0x9859EC", Offset = "0x9859EC", VA = "0x9859EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x98559C", Offset = "0x98559C", VA = "0x98559C")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x9855D4", Offset = "0x9855D4", VA = "0x9855D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x9855D8", Offset = "0x9855D8", VA = "0x9855D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x9859AC", Offset = "0x9859AC", VA = "0x9859AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x985534", Offset = "0x985534", VA = "0x985534")]
		[IteratorStateMachine(typeof(<Start>d__1))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x9855C4", Offset = "0x9855C4", VA = "0x9855C4")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class <OnCollisionEnter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000D8")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000D9")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000DA")]
			[FieldOffset(Offset = "0x20")]
			public Explosive <>4__this;

			[Token(Token = "0x40000DB")]
			[FieldOffset(Offset = "0x28")]
			public Collision col;

			[Token(Token = "0x1700001C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000B4")]
				[Address(RVA = "0x985E78", Offset = "0x985E78", VA = "0x985E78", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000B6")]
				[Address(RVA = "0x985EC0", Offset = "0x985EC0", VA = "0x985EC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x985AB8", Offset = "0x985AB8", VA = "0x985AB8")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x985B0C", Offset = "0x985B0C", VA = "0x985B0C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x985B10", Offset = "0x985B10", VA = "0x985B10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x985E80", Offset = "0x985E80", VA = "0x985E80", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x18")]
		public Transform explosionPrefab;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x20")]
		public float detonationImpactVelocity;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x24")]
		public float sizeMultiplier;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x28")]
		public bool reset;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x2C")]
		public float resetTimeDelay;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x30")]
		private bool m_Exploded;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x38")]
		private ObjectResetter m_ObjectResetter;

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x9859F4", Offset = "0x9859F4", VA = "0x9859F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x985A44", Offset = "0x985A44", VA = "0x985A44")]
		[IteratorStateMachine(typeof(<OnCollisionEnter>d__8))]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x985AE0", Offset = "0x985AE0", VA = "0x985AE0")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x985AE8", Offset = "0x985AE8", VA = "0x985AE8")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x985EC8", Offset = "0x985EC8", VA = "0x985EC8")]
		private void Start()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x985F18", Offset = "0x985F18", VA = "0x985F18")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x985F90", Offset = "0x985F90", VA = "0x985F90")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x985FA0", Offset = "0x985FA0", VA = "0x985FA0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x986008", Offset = "0x986008", VA = "0x986008")]
		private void Update()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x9861F0", Offset = "0x9861F0", VA = "0x9861F0")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x986218", Offset = "0x986218", VA = "0x986218")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x986228", Offset = "0x986228", VA = "0x986228")]
		private void Update()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x9863A8", Offset = "0x9863A8", VA = "0x9863A8")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x9863C4", Offset = "0x9863C4", VA = "0x9863C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x9864D4", Offset = "0x9864D4", VA = "0x9864D4")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x9864E4", Offset = "0x9864E4", VA = "0x9864E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x986594", Offset = "0x986594", VA = "0x986594")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x98659C", Offset = "0x98659C", VA = "0x98659C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x9865EC", Offset = "0x9865EC", VA = "0x9865EC")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x98680C", Offset = "0x98680C", VA = "0x98680C")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000039")]
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x986890", Offset = "0x986890", VA = "0x986890")]
		private void Update()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x986A8C", Offset = "0x986A8C", VA = "0x986A8C")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[RequireComponent(typeof(WaterBase))]
	[ExecuteInEditMode]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x986A94", Offset = "0x986A94", VA = "0x986A94")]
		public void Awake()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x986AB4", Offset = "0x986AB4", VA = "0x986AB4")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x986B18", Offset = "0x986B18", VA = "0x986B18")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x986B7C", Offset = "0x986B7C", VA = "0x986B7C")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[RequireComponent(typeof(WaterBase))]
	[ExecuteInEditMode]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x986B84", Offset = "0x986B84", VA = "0x986B84")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class MeshContainer
	{
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x986B8C", Offset = "0x986B8C", VA = "0x986B8C")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x986BDC", Offset = "0x986BDC", VA = "0x986BDC")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[RequireComponent(typeof(WaterBase))]
	[ExecuteInEditMode]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x986C14", Offset = "0x986C14", VA = "0x986C14")]
		public void Start()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x986D0C", Offset = "0x986D0C", VA = "0x986D0C")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x987010", Offset = "0x987010", VA = "0x987010")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x9870C4", Offset = "0x9870C4", VA = "0x9870C4")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x98721C", Offset = "0x98721C", VA = "0x98721C")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x987A68", Offset = "0x987A68", VA = "0x987A68")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x987AC0", Offset = "0x987AC0", VA = "0x987AC0")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x987BA0", Offset = "0x987BA0", VA = "0x987BA0")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x987C04", Offset = "0x987C04", VA = "0x987C04")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x9873B0", Offset = "0x9873B0", VA = "0x9873B0")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x987C68", Offset = "0x987C68", VA = "0x987C68")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x987F1C", Offset = "0x987F1C", VA = "0x987F1C")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x987CC8", Offset = "0x987CC8", VA = "0x987CC8")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x988088", Offset = "0x988088", VA = "0x988088")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x987D6C", Offset = "0x987D6C", VA = "0x987D6C")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x9880A8", Offset = "0x9880A8", VA = "0x9880A8")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[RequireComponent(typeof(WaterBase))]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x988110", Offset = "0x988110", VA = "0x988110")]
		public void Start()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x988228", Offset = "0x988228", VA = "0x988228")]
		public void Update()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x988428", Offset = "0x988428", VA = "0x988428")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x2000040")]
		public enum WaterMode
		{
			[Token(Token = "0x400010A")]
			Simple,
			[Token(Token = "0x400010B")]
			Reflective,
			[Token(Token = "0x400010C")]
			Refractive
		}

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x988430", Offset = "0x988430", VA = "0x988430")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x989CCC", Offset = "0x989CCC", VA = "0x989CCC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x98A014", Offset = "0x98A014", VA = "0x98A014")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x98984C", Offset = "0x98984C", VA = "0x98984C")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x988F84", Offset = "0x988F84", VA = "0x988F84")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x988F70", Offset = "0x988F70", VA = "0x988F70")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x988E04", Offset = "0x988E04", VA = "0x988E04")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x989B1C", Offset = "0x989B1C", VA = "0x989B1C")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x989A88", Offset = "0x989A88", VA = "0x989A88")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x98A2C0", Offset = "0x98A2C0", VA = "0x98A2C0")]
		public Water()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public enum WaterQuality
	{
		[Token(Token = "0x400010E")]
		High = 2,
		[Token(Token = "0x400010F")]
		Medium = 1,
		[Token(Token = "0x4000110")]
		Low = 0
	}
	[Token(Token = "0x2000042")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x98A3A8", Offset = "0x98A3A8", VA = "0x98A3A8")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x98A520", Offset = "0x98A520", VA = "0x98A520")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x98A5C4", Offset = "0x98A5C4", VA = "0x98A5C4")]
		public void Update()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x98A638", Offset = "0x98A638", VA = "0x98A638")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x98A650", Offset = "0x98A650", VA = "0x98A650")]
		public void Start()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x98A654", Offset = "0x98A654", VA = "0x98A654")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x98A7E0", Offset = "0x98A7E0", VA = "0x98A7E0")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x98A8C4", Offset = "0x98A8C4", VA = "0x98A8C4")]
		public WaterTile()
		{
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x2000044")]
	public enum AAMode
	{
		[Token(Token = "0x4000117")]
		FXAA2,
		[Token(Token = "0x4000118")]
		FXAA3Console,
		[Token(Token = "0x4000119")]
		FXAA1PresetA,
		[Token(Token = "0x400011A")]
		FXAA1PresetB,
		[Token(Token = "0x400011B")]
		NFAA,
		[Token(Token = "0x400011C")]
		SSAA,
		[Token(Token = "0x400011D")]
		DLAA
	}
	[Token(Token = "0x2000045")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Antialiasing")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x1C")]
		public AAMode mode;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x20")]
		public bool showGeneratedNormals;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x24")]
		public float offsetScale;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x28")]
		public float blurRadius;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x2C")]
		public float edgeThresholdMin;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x30")]
		public float edgeThreshold;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x34")]
		public float edgeSharpness;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x38")]
		public bool dlaaSharp;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x40")]
		public Shader ssaaShader;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x48")]
		private Material ssaa;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x50")]
		public Shader dlaaShader;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x58")]
		private Material dlaa;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x60")]
		public Shader nfaaShader;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x68")]
		private Material nfaa;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x70")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x78")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x80")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x88")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x90")]
		public Shader shaderFXAAII;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x98")]
		private Material materialFXAAII;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0xA0")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0xA8")]
		private Material materialFXAAIII;

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x98A8CC", Offset = "0x98A8CC", VA = "0x98A8CC")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x98A934", Offset = "0x98A934", VA = "0x98A934", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x98AA14", Offset = "0x98AA14", VA = "0x98AA14")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x98AED8", Offset = "0x98AED8", VA = "0x98AED8")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
	[RequireComponent(typeof(Camera))]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x2000047")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x4000153")]
			Ghosting,
			[Token(Token = "0x4000154")]
			Anamorphic,
			[Token(Token = "0x4000155")]
			Combined
		}

		[Token(Token = "0x2000048")]
		public enum TweakMode
		{
			[Token(Token = "0x4000157")]
			Basic,
			[Token(Token = "0x4000158")]
			Complex
		}

		[Token(Token = "0x2000049")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x400015A")]
			Auto,
			[Token(Token = "0x400015B")]
			On,
			[Token(Token = "0x400015C")]
			Off
		}

		[Token(Token = "0x200004A")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x400015E")]
			Screen,
			[Token(Token = "0x400015F")]
			Add
		}

		[Token(Token = "0x200004B")]
		public enum BloomQuality
		{
			[Token(Token = "0x4000161")]
			Cheap,
			[Token(Token = "0x4000162")]
			High
		}

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x1C")]
		public TweakMode tweakMode;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x20")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x24")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x28")]
		private bool doHdr;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x2C")]
		public float sepBlurSpread;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x30")]
		public BloomQuality quality;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x34")]
		public float bloomIntensity;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x38")]
		public float bloomThreshold;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x3C")]
		public Color bloomThresholdColor;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x4C")]
		public int bloomBlurIterations;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x54")]
		public float flareRotation;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x58")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x5C")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x60")]
		public float lensflareIntensity;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x64")]
		public float lensflareThreshold;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x68")]
		public float lensFlareSaturation;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x6C")]
		public Color flareColorA;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x7C")]
		public Color flareColorB;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x8C")]
		public Color flareColorC;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x9C")]
		public Color flareColorD;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0xB0")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0xB8")]
		public Shader lensFlareShader;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0xC0")]
		private Material lensFlareMaterial;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0xC8")]
		public Shader screenBlendShader;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0xD0")]
		private Material screenBlend;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0xD8")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0xE0")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0xE8")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0xF0")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x98AEFC", Offset = "0x98AEFC", VA = "0x98AEFC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x98AF90", Offset = "0x98AF90", VA = "0x98AF90")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x98C100", Offset = "0x98C100", VA = "0x98C100")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x98BF68", Offset = "0x98BF68", VA = "0x98BF68")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x98BCBC", Offset = "0x98BCBC", VA = "0x98BCBC")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x98BBE8", Offset = "0x98BBE8", VA = "0x98BBE8")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x98BD7C", Offset = "0x98BD7C", VA = "0x98BD7C")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x98C1C4", Offset = "0x98C1C4", VA = "0x98C1C4")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x4000164")]
		Ghosting,
		[Token(Token = "0x4000165")]
		Anamorphic,
		[Token(Token = "0x4000166")]
		Combined
	}
	[Token(Token = "0x200004D")]
	public enum TweakMode34
	{
		[Token(Token = "0x4000168")]
		Basic,
		[Token(Token = "0x4000169")]
		Complex
	}
	[Token(Token = "0x200004E")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x400016B")]
		Auto,
		[Token(Token = "0x400016C")]
		On,
		[Token(Token = "0x400016D")]
		Off
	}
	[Token(Token = "0x200004F")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x400016F")]
		Screen,
		[Token(Token = "0x4000170")]
		Add
	}
	[Token(Token = "0x2000050")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/BloomAndFlares (3.5, Deprecated)")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x1C")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x20")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x24")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x28")]
		private bool doHdr;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x2C")]
		public float sepBlurSpread;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x30")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x34")]
		public float bloomIntensity;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x38")]
		public float bloomThreshold;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x3C")]
		public int bloomBlurIterations;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x40")]
		public bool lensflares;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x44")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x48")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x4C")]
		public float hollyStretchWidth;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x50")]
		public float lensflareIntensity;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x54")]
		public float lensflareThreshold;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x58")]
		public Color flareColorA;

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x68")]
		public Color flareColorB;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x78")]
		public Color flareColorC;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x88")]
		public Color flareColorD;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x98")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0xA0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0xA8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0xB0")]
		public Shader vignetteShader;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0xB8")]
		private Material vignetteMaterial;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0xC0")]
		public Shader separableBlurShader;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0xC8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0xD0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0xD8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0xE0")]
		public Shader screenBlendShader;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0xE8")]
		private Material screenBlend;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0xF0")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0xF8")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x100")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x108")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x98C24C", Offset = "0x98C24C", VA = "0x98C24C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x98C31C", Offset = "0x98C31C", VA = "0x98C31C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x98D0DC", Offset = "0x98D0DC", VA = "0x98D0DC")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x98CF54", Offset = "0x98CF54", VA = "0x98CF54")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x98CCFC", Offset = "0x98CCFC", VA = "0x98CCFC")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x98CE04", Offset = "0x98CE04", VA = "0x98CE04")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x98D18C", Offset = "0x98D18C", VA = "0x98D18C")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000052")]
		public enum Resolution
		{
			[Token(Token = "0x400019C")]
			Low,
			[Token(Token = "0x400019D")]
			High
		}

		[Token(Token = "0x2000053")]
		public enum BlurType
		{
			[Token(Token = "0x400019F")]
			Standard,
			[Token(Token = "0x40001A0")]
			Sgx
		}

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1.5f)]
		public float threshold;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 2.5f)]
		public float intensity;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x24")]
		[Range(0.25f, 5.5f)]
		public float blurSize;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x28")]
		private Resolution resolution;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x2C")]
		[Range(1f, 4f)]
		public int blurIterations;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x30")]
		public BlurType blurType;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x38")]
		public Shader fastBloomShader;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x40")]
		private Material fastBloomMaterial;

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x98D200", Offset = "0x98D200", VA = "0x98D200", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x98D258", Offset = "0x98D258", VA = "0x98D258")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x98D2E4", Offset = "0x98D2E4", VA = "0x98D2E4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x98D654", Offset = "0x98D654", VA = "0x98D654")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Blur")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float blurSpread;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x1700001E")]
		protected Material material
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x98D678", Offset = "0x98D678", VA = "0x98D678")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x98D770", Offset = "0x98D770", VA = "0x98D770")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x98D81C", Offset = "0x98D81C", VA = "0x98D81C")]
		protected void Start()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x98D8CC", Offset = "0x98D8CC", VA = "0x98D8CC")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x98D9DC", Offset = "0x98D9DC", VA = "0x98D9DC")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x98DAD8", Offset = "0x98DAD8", VA = "0x98DAD8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x98DC34", Offset = "0x98DC34", VA = "0x98DC34")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000056")]
		public enum BlurType
		{
			[Token(Token = "0x40001AC")]
			StandardGauss,
			[Token(Token = "0x40001AD")]
			SgxGauss
		}

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 2f)]
		public int downsample;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 10f)]
		public float blurSize;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x24")]
		[Range(1f, 4f)]
		public int blurIterations;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x28")]
		public BlurType blurType;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x30")]
		public Shader blurShader;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x38")]
		private Material blurMaterial;

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x98DC4C", Offset = "0x98DC4C", VA = "0x98DC4C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x98DCA4", Offset = "0x98DCA4", VA = "0x98DCA4")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x98DD30", Offset = "0x98DD30", VA = "0x98DD30")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x98E058", Offset = "0x98E058", VA = "0x98E058")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Camera Motion Blur")]
	[ExecuteInEditMode]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x2000058")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x40001CF")]
			CameraMotion,
			[Token(Token = "0x40001D0")]
			LocalBlur,
			[Token(Token = "0x40001D1")]
			Reconstruction,
			[Token(Token = "0x40001D2")]
			ReconstructionDX11,
			[Token(Token = "0x40001D3")]
			ReconstructionDisc
		}

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x1C")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x20")]
		public bool preview;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 previewScale;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x30")]
		public float movementScale;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x34")]
		public float rotationScale;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x38")]
		public float maxVelocity;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x3C")]
		public float minVelocity;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x40")]
		public float velocityScale;

		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x44")]
		public float softZDistance;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x48")]
		public int velocityDownsample;

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x4C")]
		public LayerMask excludeLayers;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x50")]
		private GameObject tmpCam;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x58")]
		public Shader shader;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x60")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x68")]
		public Shader replacementClear;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x70")]
		private Material motionBlurMaterial;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x78")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x80")]
		public Texture2D noiseTexture;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x88")]
		public float jitter;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x8C")]
		public bool showVelocity;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x90")]
		public float showVelocityScale;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x94")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0xD8")]
		private Matrix4x4[] currentStereoViewProjMat;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0xE0")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x120")]
		private Matrix4x4[] prevStereoViewProjMat;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x128")]
		private int prevFrameCount;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x12C")]
		private bool wasActive;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x130")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x13C")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x148")]
		private Vector3 prevFramePos;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x158")]
		private Camera _camera;

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x98E074", Offset = "0x98E074", VA = "0x98E074")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x98E2D4", Offset = "0x98E2D4", VA = "0x98E2D4")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x98E53C", Offset = "0x98E53C", VA = "0x98E53C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x98E5F8", Offset = "0x98E5F8", VA = "0x98E5F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x98E71C", Offset = "0x98E71C", VA = "0x98E71C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x98E7A8", Offset = "0x98E7A8", VA = "0x98E7A8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x98E3DC", Offset = "0x98E3DC", VA = "0x98E3DC")]
		private void Remember()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x9902FC", Offset = "0x9902FC", VA = "0x9902FC")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x990278", Offset = "0x990278", VA = "0x990278")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x9902EC", Offset = "0x9902EC", VA = "0x9902EC")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x990668", Offset = "0x990668", VA = "0x990668")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x200005A")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x40001ED")]
			Simple,
			[Token(Token = "0x40001EE")]
			Advanced
		}

		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve redChannel;

		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x38")]
		public bool useDepthCorrection;

		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x40")]
		public AnimationCurve zCurve;

		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x50")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x58")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x60")]
		private Material ccMaterial;

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x68")]
		private Material ccDepthMaterial;

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x70")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x78")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x80")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x88")]
		private Texture2D zCurveTex;

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x90")]
		public float saturation;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x94")]
		public bool selectiveCc;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x98")]
		public Color selectiveFromColor;

		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0xA8")]
		public Color selectiveToColor;

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0xB8")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0xBC")]
		public bool updateTextures;

		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0xC0")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0xC8")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0xD0")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0xD8")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x990800", Offset = "0x990800", VA = "0x990800")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x990830", Offset = "0x990830", VA = "0x990830")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x990834", Offset = "0x990834", VA = "0x990834", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x990FCC", Offset = "0x990FCC", VA = "0x990FCC")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x9912C0", Offset = "0x9912C0", VA = "0x9912C0")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x9912C4", Offset = "0x9912C4", VA = "0x9912C4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x9915D0", Offset = "0x9915D0", VA = "0x9915D0")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x20")]
		public Shader shader;

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x28")]
		private Material material;

		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x30")]
		public Texture3D converted3DLut;

		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x38")]
		public string basedOnTempTex;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x991C28", Offset = "0x991C28", VA = "0x991C28", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x991C70", Offset = "0x991C70", VA = "0x991C70")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x991CF8", Offset = "0x991CF8", VA = "0x991CF8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x991D80", Offset = "0x991D80", VA = "0x991D80")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x991F64", Offset = "0x991F64", VA = "0x991F64")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x992064", Offset = "0x992064", VA = "0x992064")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x992380", Offset = "0x992380", VA = "0x992380")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x992574", Offset = "0x992574", VA = "0x992574")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x9925D0", Offset = "0x9925D0", VA = "0x9925D0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x99273C", Offset = "0x99273C", VA = "0x99273C")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
	[RequireComponent(typeof(Camera))]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float intensity;

		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 0.999f)]
		public float threshold;

		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x28")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x30")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float blurSpread;

		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x40")]
		public Shader separableBlurShader;

		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x48")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x99274C", Offset = "0x99274C", VA = "0x99274C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x9927B0", Offset = "0x9927B0", VA = "0x9927B0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x992ADC", Offset = "0x992ADC", VA = "0x992ADC")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x18")]
		[Range(0.0001f, 1f)]
		public float adaptationSpeed;

		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float limitMinimum;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float limitMaximum;

		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x1700001F")]
		protected Material materialLum
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x992B00", Offset = "0x992B00", VA = "0x992B00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		protected Material materialReduce
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x992BB8", Offset = "0x992BB8", VA = "0x992BB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		protected Material materialAdapt
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x992C70", Offset = "0x992C70", VA = "0x992C70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		protected Material materialApply
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x992D28", Offset = "0x992D28", VA = "0x992D28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x992DE0", Offset = "0x992DE0", VA = "0x992DE0")]
		private void Start()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x992E64", Offset = "0x992E64", VA = "0x992E64")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x992FA0", Offset = "0x992FA0", VA = "0x992FA0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x99316C", Offset = "0x99316C", VA = "0x99316C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x9933AC", Offset = "0x9933AC", VA = "0x9933AC")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x993564", Offset = "0x993564", VA = "0x993564")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x1C")]
		public float intensity;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x20")]
		public int softness;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x24")]
		public float spread;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x28")]
		public Shader blurShader;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x30")]
		private Material blurMaterial;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x38")]
		public Shader depthFetchShader;

		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x40")]
		private Material depthFetchMaterial;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x48")]
		public Shader creaseApplyShader;

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x50")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x9935D4", Offset = "0x9935D4", VA = "0x9935D4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x993648", Offset = "0x993648", VA = "0x993648")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x9939C0", Offset = "0x9939C0", VA = "0x9939C0")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (Lens Blur, Scatter, DX11)")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x2000061")]
		public enum BlurType
		{
			[Token(Token = "0x400022B")]
			DiscBlur,
			[Token(Token = "0x400022C")]
			DX11
		}

		[Token(Token = "0x2000062")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x400022E")]
			Low,
			[Token(Token = "0x400022F")]
			Medium,
			[Token(Token = "0x4000230")]
			High
		}

		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x1B")]
		public bool visualizeFocus;

		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x1C")]
		public float focalLength;

		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x20")]
		public float focalSize;

		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x24")]
		public float aperture;

		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x28")]
		public Transform focalTransform;

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x30")]
		public float maxBlurSize;

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x34")]
		public bool highResolution;

		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x38")]
		public BlurType blurType;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x3C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x40")]
		public bool nearBlur;

		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x44")]
		public float foregroundOverlap;

		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x48")]
		public Shader dofHdrShader;

		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x50")]
		private Material dofHdrMaterial;

		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x58")]
		public Shader dx11BokehShader;

		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x60")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x68")]
		public float dx11BokehThreshold;

		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x6C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x70")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x78")]
		public float dx11BokehScale;

		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x7C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x80")]
		private float focalDistance01;

		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x88")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x90")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x98")]
		private float internalBlurWidth;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0xA0")]
		private Camera cachedCamera;

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x9939E8", Offset = "0x9939E8", VA = "0x9939E8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x993B80", Offset = "0x993B80", VA = "0x993B80")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x993BF0", Offset = "0x993BF0", VA = "0x993BF0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x993CC8", Offset = "0x993CC8", VA = "0x993CC8")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x993A60", Offset = "0x993A60", VA = "0x993A60")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x993D00", Offset = "0x993D00", VA = "0x993D00")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x993DEC", Offset = "0x993DEC", VA = "0x993DEC")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x9940BC", Offset = "0x9940BC", VA = "0x9940BC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x9953BC", Offset = "0x9953BC", VA = "0x9953BC")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (deprecated)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x2000064")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x400025D")]
			OnlyBackground = 1,
			[Token(Token = "0x400025E")]
			BackgroundAndForeground
		}

		[Token(Token = "0x2000065")]
		public enum DofResolution
		{
			[Token(Token = "0x4000260")]
			High = 2,
			[Token(Token = "0x4000261")]
			Medium,
			[Token(Token = "0x4000262")]
			Low
		}

		[Token(Token = "0x2000066")]
		public enum DofBlurriness
		{
			[Token(Token = "0x4000264")]
			Low = 1,
			[Token(Token = "0x4000265")]
			High = 2,
			[Token(Token = "0x4000266")]
			VeryHigh = 4
		}

		[Token(Token = "0x2000067")]
		public enum BokehDestination
		{
			[Token(Token = "0x4000268")]
			Background = 1,
			[Token(Token = "0x4000269")]
			Foreground,
			[Token(Token = "0x400026A")]
			BackgroundAndForeground
		}

		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x1C")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x20")]
		public DofResolution resolution;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x24")]
		public bool simpleTweakMode;

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x28")]
		public float focalPoint;

		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x2C")]
		public float smoothness;

		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x30")]
		public float focalZDistance;

		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x34")]
		public float focalZStartCurve;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x38")]
		public float focalZEndCurve;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x3C")]
		private float focalStartCurve;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x40")]
		private float focalEndCurve;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x44")]
		private float focalDistance01;

		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x48")]
		public Transform objectFocus;

		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x50")]
		public float focalSize;

		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x54")]
		public DofBlurriness bluriness;

		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x58")]
		public float maxBlurSpread;

		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x5C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x60")]
		public Shader dofBlurShader;

		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x68")]
		private Material dofBlurMaterial;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x70")]
		public Shader dofShader;

		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x78")]
		private Material dofMaterial;

		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x80")]
		public bool visualize;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x84")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x88")]
		private float widthOverHeight;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x8C")]
		private float oneOverBaseSize;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x90")]
		public bool bokeh;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x91")]
		public bool bokehSupport;

		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x98")]
		public Shader bokehShader;

		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0xA0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0xA8")]
		public float bokehScale;

		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0xAC")]
		public float bokehIntensity;

		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0xB0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0xB4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0xB8")]
		public int bokehDownsample;

		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0xC0")]
		private Material bokehMaterial;

		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0xC8")]
		private Camera _camera;

		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0xD0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0xD8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0xE0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0xE8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0xF0")]
		private RenderTexture bokehSource;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0xF8")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x995420", Offset = "0x995420", VA = "0x995420")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x9954E4", Offset = "0x9954E4", VA = "0x9954E4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x9955D8", Offset = "0x9955D8", VA = "0x9955D8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x995718", Offset = "0x995718", VA = "0x995718")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x995788", Offset = "0x995788", VA = "0x995788")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x995874", Offset = "0x995874", VA = "0x995874")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x995898", Offset = "0x995898", VA = "0x995898")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x9958BC", Offset = "0x9958BC", VA = "0x9958BC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x99658C", Offset = "0x99658C", VA = "0x99658C")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x996B3C", Offset = "0x996B3C", VA = "0x996B3C")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x996EB0", Offset = "0x996EB0", VA = "0x996EB0")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x996464", Offset = "0x996464", VA = "0x996464")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x99676C", Offset = "0x99676C", VA = "0x99676C")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x996D48", Offset = "0x996D48", VA = "0x996D48")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x996150", Offset = "0x996150", VA = "0x996150")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x99726C", Offset = "0x99726C", VA = "0x99726C")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Edge Detection")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x2000069")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x4000277")]
			TriangleDepthNormals,
			[Token(Token = "0x4000278")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x4000279")]
			SobelDepth,
			[Token(Token = "0x400027A")]
			SobelDepthThin,
			[Token(Token = "0x400027B")]
			TriangleLuminance
		}

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x1C")]
		public EdgeDetectMode mode;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x20")]
		public float sensitivityDepth;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x24")]
		public float sensitivityNormals;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x28")]
		public float lumThreshold;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x2C")]
		public float edgeExp;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x30")]
		public float sampleDist;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x34")]
		public float edgesOnly;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x38")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x48")]
		public Shader edgeDetectShader;

		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x50")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x58")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x99733C", Offset = "0x99733C", VA = "0x99733C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x997458", Offset = "0x997458", VA = "0x997458")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x9973A8", Offset = "0x9973A8", VA = "0x9973A8")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x997464", Offset = "0x997464", VA = "0x997464")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x997468", Offset = "0x997468", VA = "0x997468")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x99763C", Offset = "0x99763C", VA = "0x99763C")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Displacement/Fisheye")]
	[ExecuteInEditMode]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1.5f)]
		public float strengthX;

		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1.5f)]
		public float strengthY;

		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x28")]
		public Shader fishEyeShader;

		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x30")]
		private Material fisheyeMaterial;

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x997678", Offset = "0x997678", VA = "0x997678", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x9976C4", Offset = "0x9976C4", VA = "0x9976C4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x9977F8", Offset = "0x9977F8", VA = "0x9977F8")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Rendering/Global Fog")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x1B")]
		[Tooltip("Apply distance-based fog?")]
		public bool distanceFog;

		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x1C")]
		[Tooltip("Exclude far plane pixels from distance-based fog? (Skybox or clear color)")]
		public bool excludeFarPixels;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x1D")]
		[Tooltip("Distance fog is based on radial distance from camera when checked")]
		public bool useRadialDistance;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x1E")]
		[Tooltip("Apply height-based fog?")]
		public bool heightFog;

		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Fog top Y coordinate")]
		public float height;

		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x24")]
		[Range(0.001f, 10f)]
		public float heightDensity;

		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Push fog away from the camera by this amount")]
		public float startDistance;

		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x30")]
		public Shader fogShader;

		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x38")]
		private Material fogMaterial;

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x99781C", Offset = "0x99781C", VA = "0x99781C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x997870", Offset = "0x997870", VA = "0x997870")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x997E00", Offset = "0x997E00", VA = "0x997E00")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x30")]
		[Range(-1f, 1f)]
		public float rampOffset;

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x997E2C", Offset = "0x997E2C", VA = "0x997E2C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x997F10", Offset = "0x997F10", VA = "0x997F10")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[AddComponentMenu("")]
	[RequireComponent(typeof(Camera))]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x17000023")]
		protected Material material
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x992684", Offset = "0x992684", VA = "0x992684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x997F18", Offset = "0x997F18", VA = "0x997F18", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x997FB8", Offset = "0x997FB8", VA = "0x997FB8", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x992744", Offset = "0x992744", VA = "0x992744")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AddComponentMenu("")]
	public class ImageEffects
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x998044", Offset = "0x998044", VA = "0x998044")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x9982B4", Offset = "0x9982B4", VA = "0x9982B4")]
		[Obsolete("Use Graphics.Blit(source,dest) instead")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x99831C", Offset = "0x99831C", VA = "0x99831C")]
		[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x99838C", Offset = "0x99838C", VA = "0x99838C")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Blur/Motion Blur (Color Accumulation)")]
	[ExecuteInEditMode]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 0.92f)]
		public float blurAmount;

		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x998394", Offset = "0x998394", VA = "0x998394", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x998398", Offset = "0x998398", VA = "0x998398", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x9983FC", Offset = "0x9983FC", VA = "0x9983FC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x998748", Offset = "0x998748", VA = "0x998748")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[AddComponentMenu("Image Effects/Noise/Noise And Grain (Filmic)")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x1C")]
		public float intensityMultiplier;

		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x20")]
		public float generalIntensity;

		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x24")]
		public float blackIntensity;

		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x28")]
		public float whiteIntensity;

		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x2C")]
		public float midGrey;

		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x30")]
		public bool dx11Grain;

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x34")]
		public float softness;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x38")]
		public bool monochrome;

		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 intensities;

		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 tiling;

		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x54")]
		public float monochromeTiling;

		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x58")]
		public FilterMode filterMode;

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x60")]
		public Texture2D noiseTexture;

		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x68")]
		public Shader noiseShader;

		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x70")]
		private Material noiseMaterial;

		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x78")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x80")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x99875C", Offset = "0x99875C", VA = "0x99875C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x9987C8", Offset = "0x9987C8", VA = "0x9987C8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x998FC8", Offset = "0x998FC8", VA = "0x998FC8")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x999308", Offset = "0x999308", VA = "0x999308")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise and Scratches")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 5f)]
		public float grainIntensityMin;

		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 5f)]
		public float grainIntensityMax;

		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x24")]
		[Range(0.1f, 50f)]
		public float grainSize;

		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 5f)]
		public float scratchIntensityMin;

		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 5f)]
		public float scratchIntensityMax;

		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x30")]
		[Range(1f, 30f)]
		public float scratchFPS;

		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float scratchJitter;

		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x17000024")]
		protected Material material
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x9994D0", Offset = "0x9994D0", VA = "0x9994D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x9993A4", Offset = "0x9993A4", VA = "0x9993A4")]
		protected void Start()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x999618", Offset = "0x999618", VA = "0x999618")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x9996E8", Offset = "0x9996E8", VA = "0x9996E8")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x99978C", Offset = "0x99978C", VA = "0x99978C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x999AB4", Offset = "0x999AB4", VA = "0x999AB4")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x990B74", Offset = "0x990B74", VA = "0x990B74")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x999B08", Offset = "0x999B08", VA = "0x999B08")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x999CEC", Offset = "0x999CEC", VA = "0x999CEC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x999CF8", Offset = "0x999CF8", VA = "0x999CF8")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x999D00", Offset = "0x999D00", VA = "0x999D00", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x990824", Offset = "0x990824", VA = "0x990824")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x990A7C", Offset = "0x990A7C", VA = "0x990A7C")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x999DC0", Offset = "0x999DC0", VA = "0x999DC0")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x999E18", Offset = "0x999E18", VA = "0x999E18")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x990F14", Offset = "0x990F14", VA = "0x990F14")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x999E20", Offset = "0x999E20", VA = "0x999E20")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x999AE8", Offset = "0x999AE8", VA = "0x999AE8")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x99A038", Offset = "0x99A038", VA = "0x99A038")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x991C14", Offset = "0x991C14", VA = "0x991C14")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x99A3B0", Offset = "0x99A3B0", VA = "0x99A3B0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x99A418", Offset = "0x99A418", VA = "0x99A418")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x99A664", Offset = "0x99A664", VA = "0x99A664")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x99A9D8", Offset = "0x99A9D8", VA = "0x99A9D8")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x99AB7C", Offset = "0x99AB7C", VA = "0x99AB7C")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x2000074")]
	internal class Quads
	{
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x99AB84", Offset = "0x99AB84", VA = "0x99AB84")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x9955DC", Offset = "0x9955DC", VA = "0x9955DC")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x997050", Offset = "0x997050", VA = "0x997050")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x99AC54", Offset = "0x99AC54", VA = "0x99AC54")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x99AFD8", Offset = "0x99AFD8", VA = "0x99AFD8")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Screen Overlay")]
	[ExecuteInEditMode]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x2000076")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x40002BF")]
			Additive,
			[Token(Token = "0x40002C0")]
			ScreenBlend,
			[Token(Token = "0x40002C1")]
			Multiply,
			[Token(Token = "0x40002C2")]
			Overlay,
			[Token(Token = "0x40002C3")]
			AlphaBlend
		}

		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x1C")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x20")]
		public float intensity;

		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x28")]
		public Texture2D texture;

		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x30")]
		public Shader overlayShader;

		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x38")]
		private Material overlayMaterial;

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x99AFE0", Offset = "0x99AFE0", VA = "0x99AFE0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x99B02C", Offset = "0x99B02C", VA = "0x99B02C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x99B17C", Offset = "0x99B17C", VA = "0x99B17C")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 3f)]
		public float intensity;

		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x20")]
		[Range(0.1f, 3f)]
		public float radius;

		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 3f)]
		public int blurIterations;

		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 5f)]
		public float blurFilterDistance;

		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public int downsample;

		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D rand;

		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x38")]
		public Shader aoShader;

		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x40")]
		private Material aoMaterial;

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x99B19C", Offset = "0x99B19C", VA = "0x99B19C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x99B1F0", Offset = "0x99B1F0", VA = "0x99B1F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x99B278", Offset = "0x99B278", VA = "0x99B278")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x99BA2C", Offset = "0x99BA2C", VA = "0x99BA2C")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Occlusion")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000079")]
		public enum SSAOSamples
		{
			[Token(Token = "0x40002D8")]
			Low,
			[Token(Token = "0x40002D9")]
			Medium,
			[Token(Token = "0x40002DA")]
			High
		}

		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x18")]
		[Range(0.05f, 1f)]
		public float m_Radius;

		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x20")]
		[Range(0.5f, 4f)]
		public float m_OcclusionIntensity;

		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 4f)]
		public int m_Blur;

		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x28")]
		[Range(1f, 6f)]
		public int m_Downsampling;

		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0.2f, 2f)]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x30")]
		[Range(1E-05f, 0.5f)]
		public float m_MinZ;

		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x99BA58", Offset = "0x99BA58", VA = "0x99BA58")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x99BB04", Offset = "0x99BB04", VA = "0x99BB04")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x99BB88", Offset = "0x99BB88", VA = "0x99BB88")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x99BB90", Offset = "0x99BB90", VA = "0x99BB90")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x99BD10", Offset = "0x99BD10", VA = "0x99BD10")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x99BC58", Offset = "0x99BC58", VA = "0x99BC58")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x99BD7C", Offset = "0x99BD7C", VA = "0x99BD7C")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x99C350", Offset = "0x99C350", VA = "0x99C350")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Sepia Tone")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x99C384", Offset = "0x99C384", VA = "0x99C384")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x99C404", Offset = "0x99C404", VA = "0x99C404")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x200007C")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x40002EA")]
			Low,
			[Token(Token = "0x40002EB")]
			Normal,
			[Token(Token = "0x40002EC")]
			High
		}

		[Token(Token = "0x200007D")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x40002EE")]
			Screen,
			[Token(Token = "0x40002EF")]
			Add
		}

		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x1C")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x20")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x28")]
		public Transform sunTransform;

		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x30")]
		public int radialBlurIterations;

		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x34")]
		public Color sunColor;

		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x44")]
		public Color sunThreshold;

		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x54")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x58")]
		public float sunShaftIntensity;

		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x5C")]
		public float maxRadius;

		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x60")]
		public bool useDepthTexture;

		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x68")]
		public Shader sunShaftsShader;

		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x70")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x78")]
		public Shader simpleClearShader;

		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x80")]
		private Material simpleClearMaterial;

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x99C40C", Offset = "0x99C40C", VA = "0x99C40C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x99C468", Offset = "0x99C468", VA = "0x99C468")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x99CB24", Offset = "0x99CB24", VA = "0x99CB24")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x200007F")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x40002F8")]
			TiltShiftMode,
			[Token(Token = "0x40002F9")]
			IrisMode
		}

		[Token(Token = "0x2000080")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x40002FB")]
			Preview,
			[Token(Token = "0x40002FC")]
			Low,
			[Token(Token = "0x40002FD")]
			Normal,
			[Token(Token = "0x40002FE")]
			High
		}

		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x1C")]
		public TiltShiftMode mode;

		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x20")]
		public TiltShiftQuality quality;

		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 15f)]
		public float blurArea;

		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 25f)]
		public float maxBlurSize;

		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public int downsample;

		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x30")]
		public Shader tiltShiftShader;

		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x38")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x99CB74", Offset = "0x99CB74", VA = "0x99CB74", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x99CBC0", Offset = "0x99CBC0", VA = "0x99CBC0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x99CE50", Offset = "0x99CE50", VA = "0x99CE50")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x2000081")]
	[AddComponentMenu("Image Effects/Color Adjustments/Tonemapping")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x2000082")]
		public enum TonemapperType
		{
			[Token(Token = "0x400030D")]
			SimpleReinhard,
			[Token(Token = "0x400030E")]
			UserCurve,
			[Token(Token = "0x400030F")]
			Hable,
			[Token(Token = "0x4000310")]
			Photographic,
			[Token(Token = "0x4000311")]
			OptimizedHejiDawson,
			[Token(Token = "0x4000312")]
			AdaptiveReinhard,
			[Token(Token = "0x4000313")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x2000083")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x4000315")]
			Square16 = 0x10,
			[Token(Token = "0x4000316")]
			Square32 = 0x20,
			[Token(Token = "0x4000317")]
			Square64 = 0x40,
			[Token(Token = "0x4000318")]
			Square128 = 0x80,
			[Token(Token = "0x4000319")]
			Square256 = 0x100,
			[Token(Token = "0x400031A")]
			Square512 = 0x200,
			[Token(Token = "0x400031B")]
			Square1024 = 0x400
		}

		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x1C")]
		public TonemapperType type;

		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x20")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x30")]
		private Texture2D curveTex;

		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x38")]
		public float exposureAdjustment;

		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x3C")]
		public float middleGrey;

		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x40")]
		public float white;

		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x44")]
		public float adaptionSpeed;

		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x48")]
		public Shader tonemapper;

		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x50")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x58")]
		private Material tonemapMaterial;

		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x60")]
		private RenderTexture rt;

		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x68")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x99CE78", Offset = "0x99CE78", VA = "0x99CE78", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x99CFB0", Offset = "0x99CFB0", VA = "0x99CFB0")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x99D228", Offset = "0x99D228", VA = "0x99D228")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x99D340", Offset = "0x99D340", VA = "0x99D340")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x99D430", Offset = "0x99D430", VA = "0x99D430")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x99DBB8", Offset = "0x99DBB8", VA = "0x99DBB8")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x2000084")]
	internal class Triangles
	{
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x99DBF0", Offset = "0x99DBF0", VA = "0x99DBF0")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x99DCC4", Offset = "0x99DCC4", VA = "0x99DCC4")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x99DE00", Offset = "0x99DE00", VA = "0x99DE00")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x99E01C", Offset = "0x99E01C", VA = "0x99E01C")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x99E310", Offset = "0x99E310", VA = "0x99E310")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Twirl")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 360f)]
		public float angle;

		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x99E318", Offset = "0x99E318", VA = "0x99E318")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x99E350", Offset = "0x99E350", VA = "0x99E350")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
	[RequireComponent(typeof(Camera))]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x2000087")]
		public enum AberrationMode
		{
			[Token(Token = "0x4000330")]
			Simple,
			[Token(Token = "0x4000331")]
			Advanced
		}

		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x1C")]
		public AberrationMode mode;

		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x20")]
		public float intensity;

		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x24")]
		public float chromaticAberration;

		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x28")]
		public float axialAberration;

		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x2C")]
		public float blur;

		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x30")]
		public float blurSpread;

		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x34")]
		public float luminanceDependency;

		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x38")]
		public float blurDistance;

		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x40")]
		public Shader vignetteShader;

		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x50")]
		public Shader chromAberrationShader;

		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x58")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x60")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x68")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x99E378", Offset = "0x99E378", VA = "0x99E378", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x99E3F0", Offset = "0x99E3F0", VA = "0x99E3F0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x99E944", Offset = "0x99E944", VA = "0x99E944")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Vortex")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x99E980", Offset = "0x99E980", VA = "0x99E980")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x99E9C0", Offset = "0x99E9C0", VA = "0x99E9C0")]
		public Vortex()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000089")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x99E9E8", Offset = "0x99E9E8", VA = "0x99E9E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x99EC38", Offset = "0x99EC38", VA = "0x99EC38")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x99EDB4", Offset = "0x99EDB4", VA = "0x99EDB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x99EE24", Offset = "0x99EE24", VA = "0x99EE24", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x99EEF0", Offset = "0x99EEF0", VA = "0x99EEF0", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x99EF54", Offset = "0x99EF54", VA = "0x99EF54")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x99EFB8", Offset = "0x99EFB8", VA = "0x99EFB8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x99EFBC", Offset = "0x99EFBC", VA = "0x99EFBC")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x99F084", Offset = "0x99F084", VA = "0x99F084")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x99F14C", Offset = "0x99F14C", VA = "0x99F14C")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x99F214", Offset = "0x99F214", VA = "0x99F214")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x99F2DC", Offset = "0x99F2DC", VA = "0x99F2DC")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x99F3A4", Offset = "0x99F3A4", VA = "0x99F3A4")]
		public void Update()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x99F3A8", Offset = "0x99F3A8", VA = "0x99F3A8")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200008C")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x4000340")]
			Hardware,
			[Token(Token = "0x4000341")]
			Touch
		}

		[Token(Token = "0x200008D")]
		public class VirtualAxis
		{
			[Token(Token = "0x4000343")]
			[FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x17000026")]
			public string name
			{
				[Token(Token = "0x60001EB")]
				[Address(RVA = "0x9A0134", Offset = "0x9A0134", VA = "0x9A0134")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001EC")]
				[Address(RVA = "0x9A013C", Offset = "0x9A013C", VA = "0x9A013C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60001ED")]
				[Address(RVA = "0x9A0144", Offset = "0x9A0144", VA = "0x9A0144")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001EE")]
				[Address(RVA = "0x9A014C", Offset = "0x9A014C", VA = "0x9A014C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public float GetValue
			{
				[Token(Token = "0x60001F3")]
				[Address(RVA = "0x9A0194", Offset = "0x9A0194", VA = "0x9A0194")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000029")]
			public float GetValueRaw
			{
				[Token(Token = "0x60001F4")]
				[Address(RVA = "0x9A019C", Offset = "0x9A019C", VA = "0x9A019C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x99EB38", Offset = "0x99EB38", VA = "0x99EB38")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x9A0158", Offset = "0x9A0158", VA = "0x9A0158")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x99EDCC", Offset = "0x99EDCC", VA = "0x99EDCC")]
			public void Remove()
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x9A018C", Offset = "0x9A018C", VA = "0x9A018C")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x200008E")]
		public class VirtualButton
		{
			[Token(Token = "0x4000347")]
			[FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x4000348")]
			[FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000349")]
			[FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x1700002A")]
			public string name
			{
				[Token(Token = "0x60001F5")]
				[Address(RVA = "0x9A01A4", Offset = "0x9A01A4", VA = "0x9A01A4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001F6")]
				[Address(RVA = "0x9A01AC", Offset = "0x9A01AC", VA = "0x9A01AC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60001F7")]
				[Address(RVA = "0x9A01B4", Offset = "0x9A01B4", VA = "0x9A01B4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001F8")]
				[Address(RVA = "0x9A01BC", Offset = "0x9A01BC", VA = "0x9A01BC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002C")]
			public bool GetButton
			{
				[Token(Token = "0x60001FE")]
				[Address(RVA = "0x9A02E0", Offset = "0x9A02E0", VA = "0x9A02E0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700002D")]
			public bool GetButtonDown
			{
				[Token(Token = "0x60001FF")]
				[Address(RVA = "0x9A02E8", Offset = "0x9A02E8", VA = "0x9A02E8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700002E")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000200")]
				[Address(RVA = "0x9A030C", Offset = "0x9A030C", VA = "0x9A030C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x9A01C8", Offset = "0x9A01C8", VA = "0x9A01C8")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x9A0200", Offset = "0x9A0200", VA = "0x9A0200")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x9A023C", Offset = "0x9A023C", VA = "0x9A023C")]
			public void Pressed()
			{
			}

			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x9A0268", Offset = "0x9A0268", VA = "0x9A0268")]
			public void Released()
			{
			}

			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x9A0288", Offset = "0x9A0288", VA = "0x9A0288")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x17000025")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x99FF60", Offset = "0x99FF60", VA = "0x99FF60")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x99F3B0", Offset = "0x99F3B0", VA = "0x99F3B0")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x99F468", Offset = "0x99F468", VA = "0x99F468")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x99EAD0", Offset = "0x99EAD0", VA = "0x99EAD0")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x99F550", Offset = "0x99F550", VA = "0x99F550")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x99EB68", Offset = "0x99EB68", VA = "0x99EB68")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x99F798", Offset = "0x99F798", VA = "0x99F798")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x99F988", Offset = "0x99F988", VA = "0x99F988")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x99FAD0", Offset = "0x99FAD0", VA = "0x99FAD0")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x99EBD0", Offset = "0x99EBD0", VA = "0x99EBD0")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x99FC5C", Offset = "0x99FC5C", VA = "0x99FC5C")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x99FD34", Offset = "0x99FD34", VA = "0x99FD34")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x99FCB4", Offset = "0x99FCB4", VA = "0x99FCB4")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x99FD8C", Offset = "0x99FD8C", VA = "0x99FD8C")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x99FDFC", Offset = "0x99FDFC", VA = "0x99FDFC")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x99FE6C", Offset = "0x99FE6C", VA = "0x99FE6C")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x99F014", Offset = "0x99F014", VA = "0x99F014")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x99F0DC", Offset = "0x99F0DC", VA = "0x99F0DC")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x99F1A4", Offset = "0x99F1A4", VA = "0x99F1A4")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x99F334", Offset = "0x99F334", VA = "0x99F334")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x99F26C", Offset = "0x99F26C", VA = "0x99F26C")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x99FEDC", Offset = "0x99FEDC", VA = "0x99FEDC")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x99FFCC", Offset = "0x99FFCC", VA = "0x99FFCC")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x9A0044", Offset = "0x9A0044", VA = "0x9A0044")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x9A00BC", Offset = "0x9A00BC", VA = "0x9A00BC")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x9A0330", Offset = "0x9A0330", VA = "0x9A0330")]
		private void Update()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x9A0334", Offset = "0x9A0334", VA = "0x9A0334")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x9A03A4", Offset = "0x9A03A4", VA = "0x9A03A4")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000091")]
		public enum AxisOption
		{
			[Token(Token = "0x4000355")]
			Both,
			[Token(Token = "0x4000356")]
			OnlyHorizontal,
			[Token(Token = "0x4000357")]
			OnlyVertical
		}

		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x400034D")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x4000351")]
		[FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x9A03AC", Offset = "0x9A03AC", VA = "0x9A03AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x9A04D4", Offset = "0x9A04D4", VA = "0x9A04D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x9A0504", Offset = "0x9A0504", VA = "0x9A0504")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x9A03B0", Offset = "0x9A03B0", VA = "0x9A03B0")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x9A0564", Offset = "0x9A0564", VA = "0x9A0564", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x9A06B0", Offset = "0x9A06B0", VA = "0x9A06B0", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x9A06EC", Offset = "0x9A06EC", VA = "0x9A06EC", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x9A06F0", Offset = "0x9A06F0", VA = "0x9A06F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x9A0730", Offset = "0x9A0730", VA = "0x9A0730")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x9A07AC", Offset = "0x9A07AC", VA = "0x9A07AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x9A07BC", Offset = "0x9A07BC", VA = "0x9A07BC")]
		private void Start()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x9A07B4", Offset = "0x9A07B4", VA = "0x9A07B4")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x9A08C4", Offset = "0x9A08C4", VA = "0x9A08C4")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x9A0BBC", Offset = "0x9A0BBC", VA = "0x9A0BBC")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000094")]
		public enum AxisOptions
		{
			[Token(Token = "0x400035E")]
			ForwardAxis,
			[Token(Token = "0x400035F")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x2000095")]
		public class AxisMapping
		{
			[Token(Token = "0x2000096")]
			public enum MappingType
			{
				[Token(Token = "0x4000363")]
				NamedAxis,
				[Token(Token = "0x4000364")]
				MousePositionX,
				[Token(Token = "0x4000365")]
				MousePositionY,
				[Token(Token = "0x4000366")]
				MousePositionZ
			}

			[Token(Token = "0x4000360")]
			[FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x4000361")]
			[FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000216")]
			[Address(RVA = "0x9A0EFC", Offset = "0x9A0EFC", VA = "0x9A0EFC")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x9A0BC4", Offset = "0x9A0BC4", VA = "0x9A0BC4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x9A0C84", Offset = "0x9A0C84", VA = "0x9A0C84")]
		private void Update()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x9A0ED4", Offset = "0x9A0ED4", VA = "0x9A0ED4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x9A0EEC", Offset = "0x9A0EEC", VA = "0x9A0EEC")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000098")]
		public enum AxisOption
		{
			[Token(Token = "0x400037A")]
			Both,
			[Token(Token = "0x400037B")]
			OnlyHorizontal,
			[Token(Token = "0x400037C")]
			OnlyVertical
		}

		[Token(Token = "0x2000099")]
		public enum ControlStyle
		{
			[Token(Token = "0x400037E")]
			Absolute,
			[Token(Token = "0x400037F")]
			Relative,
			[Token(Token = "0x4000380")]
			Swipe
		}

		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x4000374")]
		[FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x9A0F04", Offset = "0x9A0F04", VA = "0x9A0F04")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x9A102C", Offset = "0x9A102C", VA = "0x9A102C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x9A0F08", Offset = "0x9A0F08", VA = "0x9A0F08")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x9A10A0", Offset = "0x9A10A0", VA = "0x9A10A0")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x9A11A0", Offset = "0x9A11A0", VA = "0x9A11A0", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x9A11D8", Offset = "0x9A11D8", VA = "0x9A11D8")]
		private void Update()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x9A13B0", Offset = "0x9A13B0", VA = "0x9A13B0", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x9A1410", Offset = "0x9A1410", VA = "0x9A1410")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x9A14D0", Offset = "0x9A14D0", VA = "0x9A14D0")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x4000382")]
		[FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x4000383")]
		[FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x4000384")]
		[FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x1700002F")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x9A1554", Offset = "0x9A1554", VA = "0x9A1554")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x9A1560", Offset = "0x9A1560", VA = "0x9A1560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x99F4F8", Offset = "0x99F4F8", VA = "0x99F4F8")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x99F5B8", Offset = "0x99F5B8", VA = "0x99F5B8")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x99F610", Offset = "0x99F610", VA = "0x99F610")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x99F800", Offset = "0x99F800", VA = "0x99F800")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x99FA40", Offset = "0x99FA40", VA = "0x99FA40")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x99FB38", Offset = "0x99FB38", VA = "0x99FB38")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x99FBC8", Offset = "0x99FBC8", VA = "0x99FBC8")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x9A003C", Offset = "0x9A003C", VA = "0x9A003C")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x9A00B4", Offset = "0x9A00B4", VA = "0x9A00B4")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x9A012C", Offset = "0x9A012C", VA = "0x9A012C")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x600022C")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x600022D")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x600022E")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x600022F")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x6000230")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000231")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000232")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000233")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x6000234")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000235")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000236")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x9A156C", Offset = "0x9A156C", VA = "0x9A156C")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x200009B")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x9A1670", Offset = "0x9A1670", VA = "0x9A1670")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x9A1708", Offset = "0x9A1708", VA = "0x9A1708")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x9A1798", Offset = "0x9A1798", VA = "0x9A1798", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x9A1830", Offset = "0x9A1830", VA = "0x9A1830", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x9A18E4", Offset = "0x9A18E4", VA = "0x9A18E4", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x9A198C", Offset = "0x9A198C", VA = "0x9A198C", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x9A1A28", Offset = "0x9A1A28", VA = "0x9A1A28", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x9A1AC4", Offset = "0x9A1AC4", VA = "0x9A1AC4", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x9A1B5C", Offset = "0x9A1B5C", VA = "0x9A1B5C", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x9A1C00", Offset = "0x9A1C00", VA = "0x9A1C00", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x9A1CAC", Offset = "0x9A1CAC", VA = "0x9A1CAC", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x9A1D58", Offset = "0x9A1D58", VA = "0x9A1D58", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x9A1DF0", Offset = "0x9A1DF0", VA = "0x9A1DF0", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x99F460", Offset = "0x99F460", VA = "0x99F460")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x9A1DFC", Offset = "0x9A1DFC", VA = "0x9A1DFC", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x9A1E10", Offset = "0x9A1E10", VA = "0x9A1E10", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x9A1E1C", Offset = "0x9A1E1C", VA = "0x9A1E1C", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x9A1E28", Offset = "0x9A1E28", VA = "0x9A1E28", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x9A1E34", Offset = "0x9A1E34", VA = "0x9A1E34", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x9A1E84", Offset = "0x9A1E84", VA = "0x9A1E84", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x9A1ED4", Offset = "0x9A1ED4", VA = "0x9A1ED4", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x9A1F24", Offset = "0x9A1F24", VA = "0x9A1F24", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x9A1F74", Offset = "0x9A1F74", VA = "0x9A1F74", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x9A1FC4", Offset = "0x9A1FC4", VA = "0x9A1FC4", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x9A2014", Offset = "0x9A2014", VA = "0x9A2014", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x99F464", Offset = "0x99F464", VA = "0x99F464")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Ball
{
	[Token(Token = "0x200009D")]
	public class Ball : MonoBehaviour
	{
		[Token(Token = "0x4000385")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovePower;

		[Token(Token = "0x4000386")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_UseTorque;

		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MaxAngularVelocity;

		[Token(Token = "0x4000388")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x4000389")]
		private const float k_GroundRayLength = 1f;

		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x9A201C", Offset = "0x9A201C", VA = "0x9A201C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x9A2088", Offset = "0x9A2088", VA = "0x9A2088")]
		public void Move(Vector3 moveDirection, bool jump)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x9A21FC", Offset = "0x9A21FC", VA = "0x9A21FC")]
		public Ball()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class BallUserControl : MonoBehaviour
	{
		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x18")]
		private Ball ball;

		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 move;

		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x30")]
		private Transform cam;

		[Token(Token = "0x400038E")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 camForward;

		[Token(Token = "0x400038F")]
		[FieldOffset(Offset = "0x44")]
		private bool jump;

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x9A2220", Offset = "0x9A2220", VA = "0x9A2220")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x9A232C", Offset = "0x9A232C", VA = "0x9A232C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x9A270C", Offset = "0x9A270C", VA = "0x9A270C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x9A273C", Offset = "0x9A273C", VA = "0x9A273C")]
		public BallUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[Token(Token = "0x200009F")]
	[RequireComponent(typeof(ThirdPersonCharacter))]
	[RequireComponent(typeof(NavMeshAgent))]
	public class AICharacterControl : MonoBehaviour
	{
		[Token(Token = "0x4000392")]
		[FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x17000030")]
		public NavMeshAgent agent
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x9A2744", Offset = "0x9A2744", VA = "0x9A2744")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x9A274C", Offset = "0x9A274C", VA = "0x9A274C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public ThirdPersonCharacter character
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x9A2754", Offset = "0x9A2754", VA = "0x9A2754")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x9A275C", Offset = "0x9A275C", VA = "0x9A275C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x9A2764", Offset = "0x9A2764", VA = "0x9A2764")]
		private void Start()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x9A280C", Offset = "0x9A280C", VA = "0x9A280C")]
		private void Update()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x9A2B90", Offset = "0x9A2B90", VA = "0x9A2B90")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x9A2B98", Offset = "0x9A2B98", VA = "0x9A2B98")]
		public AICharacterControl()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Animator))]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000393")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovingTurnSpeed;

		[Token(Token = "0x4000394")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_StationaryTurnSpeed;

		[Token(Token = "0x4000395")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x4000396")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(1f, 4f)]
		private float m_GravityMultiplier;

		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_RunCycleLegOffset;

		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MoveSpeedMultiplier;

		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_AnimSpeedMultiplier;

		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_GroundCheckDistance;

		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x40")]
		private Animator m_Animator;

		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x48")]
		private bool m_IsGrounded;

		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x4C")]
		private float m_OrigGroundCheckDistance;

		[Token(Token = "0x400039F")]
		private const float k_Half = 0.5f;

		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x50")]
		private float m_TurnAmount;

		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0x54")]
		private float m_ForwardAmount;

		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 m_GroundNormal;

		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x64")]
		private float m_CapsuleHeight;

		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 m_CapsuleCenter;

		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x78")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x80")]
		private bool m_Crouching;

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x9A2BA0", Offset = "0x9A2BA0", VA = "0x9A2BA0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x9A2934", Offset = "0x9A2934", VA = "0x9A2934")]
		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x9A3044", Offset = "0x9A3044", VA = "0x9A3044")]
		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x9A3264", Offset = "0x9A3264", VA = "0x9A3264")]
		private void PreventStandingInLowHeadroom()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x9A33E4", Offset = "0x9A33E4", VA = "0x9A33E4")]
		private void UpdateAnimator(Vector3 move)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x9A2FAC", Offset = "0x9A2FAC", VA = "0x9A2FAC")]
		private void HandleAirborneMovement()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x9A2E90", Offset = "0x9A2E90", VA = "0x9A2E90")]
		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x9A2E0C", Offset = "0x9A2E0C", VA = "0x9A2E0C")]
		private void ApplyExtraTurnRotation()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x9A36A4", Offset = "0x9A36A4", VA = "0x9A36A4")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x9A2C88", Offset = "0x9A2C88", VA = "0x9A2C88")]
		private void CheckGroundStatus()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x9A3744", Offset = "0x9A3744", VA = "0x9A3744")]
		public ThirdPersonCharacter()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[RequireComponent(typeof(ThirdPersonCharacter))]
	public class ThirdPersonUserControl : MonoBehaviour
	{
		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x18")]
		private ThirdPersonCharacter m_Character;

		[Token(Token = "0x40003A8")]
		[FieldOffset(Offset = "0x20")]
		private Transform m_Cam;

		[Token(Token = "0x40003A9")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 m_CamForward;

		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 m_Move;

		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0x40")]
		private bool m_Jump;

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x9A3764", Offset = "0x9A3764", VA = "0x9A3764")]
		private void Start()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x9A3878", Offset = "0x9A3878", VA = "0x9A3878")]
		private void Update()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x9A38F4", Offset = "0x9A38F4", VA = "0x9A38F4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x9A3B88", Offset = "0x9A3B88", VA = "0x9A3B88")]
		public ThirdPersonUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x20000A2")]
	[RequireComponent(typeof(CharacterController))]
	[RequireComponent(typeof(AudioSource))]
	public class FirstPersonController : MonoBehaviour
	{
		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_RunstepLenghten;

		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x40003B3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MouseLook m_MouseLook;

		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x40003B5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FOVKick m_FovKick;

		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x40003BA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioClip m_JumpSound;

		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AudioClip m_LandSound;

		[Token(Token = "0x40003BD")]
		[FieldOffset(Offset = "0x88")]
		private Camera m_Camera;

		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0x90")]
		private bool m_Jump;

		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0x94")]
		private float m_YRotation;

		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x98")]
		private Vector2 m_Input;

		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0xB0")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0xB8")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0xBC")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0xC0")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0xCC")]
		private float m_StepCycle;

		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0xD0")]
		private float m_NextStep;

		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0xD4")]
		private bool m_Jumping;

		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0xD8")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x9A3B90", Offset = "0x9A3B90", VA = "0x9A3B90")]
		private void Start()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x9A3CF0", Offset = "0x9A3CF0", VA = "0x9A3CF0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x9A3E54", Offset = "0x9A3E54", VA = "0x9A3E54")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x9A3E9C", Offset = "0x9A3E9C", VA = "0x9A3E9C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x9A44B4", Offset = "0x9A44B4", VA = "0x9A44B4")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x9A44E8", Offset = "0x9A44E8", VA = "0x9A44E8")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x9A488C", Offset = "0x9A488C", VA = "0x9A488C")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x9A4638", Offset = "0x9A4638", VA = "0x9A4638")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x9A429C", Offset = "0x9A429C", VA = "0x9A429C")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x9A3E04", Offset = "0x9A3E04", VA = "0x9A3E04")]
		private void RotateView()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x9A4D30", Offset = "0x9A4D30", VA = "0x9A4D30")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x9A4E54", Offset = "0x9A4E54", VA = "0x9A4E54")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class HeadBob : MonoBehaviour
	{
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x18")]
		public Camera Camera;

		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x20")]
		public CurveControlledBob motionBob;

		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x28")]
		public LerpControlledBob jumpAndLandingBob;

		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x30")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x38")]
		public float StrideInterval;

		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float RunningStrideLengthen;

		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x9A4F5C", Offset = "0x9A4F5C", VA = "0x9A4F5C")]
		private void Start()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x9A4FAC", Offset = "0x9A4FAC", VA = "0x9A4FAC")]
		private void Update()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x9A522C", Offset = "0x9A522C", VA = "0x9A522C")]
		public HeadBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A4")]
	public class MouseLook
	{
		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x40003D6")]
		[FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x40003D8")]
		[FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x9A3CA0", Offset = "0x9A3CA0", VA = "0x9A3CA0")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x9A49C4", Offset = "0x9A49C4", VA = "0x9A49C4")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x9A5328", Offset = "0x9A5328", VA = "0x9A5328")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x9A487C", Offset = "0x9A487C", VA = "0x9A487C")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x9A535C", Offset = "0x9A535C", VA = "0x9A535C")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x9A52C4", Offset = "0x9A52C4", VA = "0x9A52C4")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x9A53D4", Offset = "0x9A53D4", VA = "0x9A53D4")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Rigidbody))]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A6")]
		public class MovementSettings
		{
			[Token(Token = "0x40003E9")]
			[FieldOffset(Offset = "0x10")]
			public float ForwardSpeed;

			[Token(Token = "0x40003EA")]
			[FieldOffset(Offset = "0x14")]
			public float BackwardSpeed;

			[Token(Token = "0x40003EB")]
			[FieldOffset(Offset = "0x18")]
			public float StrafeSpeed;

			[Token(Token = "0x40003EC")]
			[FieldOffset(Offset = "0x1C")]
			public float RunMultiplier;

			[Token(Token = "0x40003ED")]
			[FieldOffset(Offset = "0x20")]
			public KeyCode RunKey;

			[Token(Token = "0x40003EE")]
			[FieldOffset(Offset = "0x24")]
			public float JumpForce;

			[Token(Token = "0x40003EF")]
			[FieldOffset(Offset = "0x28")]
			public AnimationCurve SlopeCurveModifier;

			[Token(Token = "0x40003F0")]
			[FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public float CurrentTargetSpeed;

			[Token(Token = "0x6000293")]
			[Address(RVA = "0x9A6254", Offset = "0x9A6254", VA = "0x9A6254")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x6000294")]
			[Address(RVA = "0x9A6410", Offset = "0x9A6410", VA = "0x9A6410")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A7")]
		public class AdvancedSettings
		{
			[Token(Token = "0x40003F1")]
			[FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			[Token(Token = "0x40003F2")]
			[FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x40003F3")]
			[FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			[Token(Token = "0x40003F4")]
			[FieldOffset(Offset = "0x1C")]
			public bool airControl;

			[Token(Token = "0x40003F5")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("set it to 0.1 or more if you get stuck in wall")]
			public float shellOffset;

			[Token(Token = "0x6000295")]
			[Address(RVA = "0x9A65C0", Offset = "0x9A65C0", VA = "0x9A65C0")]
			public AdvancedSettings()
			{
			}
		}

		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x18")]
		public Camera cam;

		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x20")]
		public MovementSettings movementSettings;

		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x28")]
		public MouseLook mouseLook;

		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0x30")]
		public AdvancedSettings advancedSettings;

		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x40")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x48")]
		private float m_YRotation;

		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 m_GroundContactNormal;

		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x58")]
		private bool m_Jump;

		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x59")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x5A")]
		private bool m_Jumping;

		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x5B")]
		private bool m_IsGrounded;

		[Token(Token = "0x17000032")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x9A5208", Offset = "0x9A5208", VA = "0x9A5208")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000033")]
		public bool Grounded
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x9A5408", Offset = "0x9A5408", VA = "0x9A5408")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000034")]
		public bool Jumping
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x9A5410", Offset = "0x9A5410", VA = "0x9A5410")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		public bool Running
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x9A5224", Offset = "0x9A5224", VA = "0x9A5224")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x9A5418", Offset = "0x9A5418", VA = "0x9A5418")]
		private void Start()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x9A54D0", Offset = "0x9A54D0", VA = "0x9A54D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x9A56D4", Offset = "0x9A56D4", VA = "0x9A56D4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x9A5DA8", Offset = "0x9A5DA8", VA = "0x9A5DA8")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x9A5F08", Offset = "0x9A5F08", VA = "0x9A5F08")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x9A5CF0", Offset = "0x9A5CF0", VA = "0x9A5CF0")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x9A5558", Offset = "0x9A5558", VA = "0x9A5558")]
		private void RotateView()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x9A5B24", Offset = "0x9A5B24", VA = "0x9A5B24")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x9A630C", Offset = "0x9A630C", VA = "0x9A630C")]
		public RigidbodyFirstPersonController()
		{
		}
	}
}
namespace UnityStandardAssets.Cameras
{
	[Token(Token = "0x20000A8")]
	public abstract class AbstractTargetFollower : MonoBehaviour
	{
		[Token(Token = "0x20000A9")]
		public enum UpdateType
		{
			[Token(Token = "0x40003FB")]
			FixedUpdate,
			[Token(Token = "0x40003FC")]
			LateUpdate,
			[Token(Token = "0x40003FD")]
			ManualUpdate
		}

		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform m_Target;

		[Token(Token = "0x40003F7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_AutoTargetPlayer;

		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UpdateType m_UpdateType;

		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x28")]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x17000036")]
		public Transform Target
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x9A69A0", Offset = "0x9A69A0", VA = "0x9A69A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x9A65DC", Offset = "0x9A65DC", VA = "0x9A65DC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x9A6744", Offset = "0x9A6744", VA = "0x9A6744")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x9A6808", Offset = "0x9A6808", VA = "0x9A6808")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x9A68D0", Offset = "0x9A68D0", VA = "0x9A68D0")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x600029A")]
		protected abstract void FollowTarget(float deltaTime);

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x9A6680", Offset = "0x9A6680", VA = "0x9A6680")]
		public void FindAndTargetPlayer()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x9A6998", Offset = "0x9A6998", VA = "0x9A6998", Slot = "6")]
		public virtual void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x9A69A8", Offset = "0x9A69A8", VA = "0x9A69A8")]
		protected AbstractTargetFollower()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[ExecuteInEditMode]
	public class AutoCam : PivotBasedCameraRig
	{
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_RollSpeed;

		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_FollowVelocity;

		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool m_FollowTilt;

		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_SpinTurnLimit;

		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_TargetVelocityLowerLimit;

		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SmoothTurnTime;

		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x68")]
		private float m_LastFlatAngle;

		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0x6C")]
		private float m_CurrentTurnAmount;

		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x70")]
		private float m_TurnSpeedVelocityChange;

		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x74")]
		private Vector3 m_RollUp;

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x9A69B8", Offset = "0x9A69B8", VA = "0x9A69B8", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x9A6F84", Offset = "0x9A6F84", VA = "0x9A6F84")]
		public AutoCam()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class FreeLookCam : PivotBasedCameraRig
	{
		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Range(0f, 10f)]
		private float m_TurnSpeed;

		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_TurnSmoothing;

		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_TiltMax;

		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_TiltMin;

		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_LockCursor;

		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool m_VerticalAutoReturn;

		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x64")]
		private float m_LookAngle;

		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x68")]
		private float m_TiltAngle;

		[Token(Token = "0x4000413")]
		private const float k_LookDistance = 100f;

		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 m_PivotEulers;

		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x78")]
		private Quaternion m_PivotTargetRot;

		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x88")]
		private Quaternion m_TransformTargetRot;

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x9A7024", Offset = "0x9A7024", VA = "0x9A7024", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x9A714C", Offset = "0x9A714C", VA = "0x9A714C")]
		protected void Update()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x9A749C", Offset = "0x9A749C", VA = "0x9A749C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x9A74BC", Offset = "0x9A74BC", VA = "0x9A74BC", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x9A719C", Offset = "0x9A719C", VA = "0x9A719C")]
		private void HandleRotationMovement()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x9A75E0", Offset = "0x9A75E0", VA = "0x9A75E0")]
		public FreeLookCam()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class HandHeldCam : LookatTarget
	{
		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SwaySpeed;

		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_BaseSwayAmount;

		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_TrackingSwayAmount;

		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Range(-1f, 1f)]
		private float m_TrackingBias;

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x9A7608", Offset = "0x9A7608", VA = "0x9A7608", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x9A7AA4", Offset = "0x9A7AA4", VA = "0x9A7AA4")]
		public HandHeldCam()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class LookatTarget : AbstractTargetFollower
	{
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 m_RotationRange;

		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_FollowSpeed;

		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x48")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x58")]
		protected Vector3 m_FollowVelocity;

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x9A7AE4", Offset = "0x9A7AE4", VA = "0x9A7AE4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x9A7740", Offset = "0x9A7740", VA = "0x9A7740", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x9A7ACC", Offset = "0x9A7ACC", VA = "0x9A7ACC")]
		public LookatTarget()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x30")]
		protected Transform m_Cam;

		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x38")]
		protected Transform m_Pivot;

		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x40")]
		protected Vector3 m_LastTargetPosition;

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x9A70DC", Offset = "0x9A70DC", VA = "0x9A70DC", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x9A7014", Offset = "0x9A7014", VA = "0x9A7014")]
		protected PivotBasedCameraRig()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		[Token(Token = "0x20000B0")]
		public class RayHitComparer : IComparer
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x9A8244", Offset = "0x9A8244", VA = "0x9A8244", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x9A7C58", Offset = "0x9A7C58", VA = "0x9A7C58")]
			public RayHitComparer()
			{
			}
		}

		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x18")]
		public float clipMoveTime;

		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x1C")]
		public float returnTime;

		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x20")]
		public float sphereCastRadius;

		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x24")]
		public bool visualiseInEditor;

		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x28")]
		public float closestDistance;

		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x30")]
		public string dontClipTag;

		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x38")]
		private Transform m_Cam;

		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x40")]
		private Transform m_Pivot;

		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x48")]
		private float m_OriginalDist;

		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x4C")]
		private float m_MoveVelocity;

		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x50")]
		private float m_CurrentDist;

		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x54")]
		private Ray m_Ray;

		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x70")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x78")]
		private RayHitComparer m_RayHitComparer;

		[Token(Token = "0x17000037")]
		public bool protecting
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x9A7B1C", Offset = "0x9A7B1C", VA = "0x9A7B1C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x9A7B24", Offset = "0x9A7B24", VA = "0x9A7B24")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x9A7B30", Offset = "0x9A7B30", VA = "0x9A7B30")]
		private void Start()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x9A7C60", Offset = "0x9A7C60", VA = "0x9A7C60")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x9A81D4", Offset = "0x9A81D4", VA = "0x9A81D4")]
		public ProtectCameraFromWallClip()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class TargetFieldOfView : AbstractTargetFollower
	{
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_FovAdjustTime;

		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_ZoomAmountMultiplier;

		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_IncludeEffectsInSize;

		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x3C")]
		private float m_BoundSize;

		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x40")]
		private float m_FovAdjustVelocity;

		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x48")]
		private Camera m_Cam;

		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x50")]
		private Transform m_LastTarget;

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x9A8338", Offset = "0x9A8338", VA = "0x9A8338", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x9A8590", Offset = "0x9A8590", VA = "0x9A8590", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x9A86D0", Offset = "0x9A86D0", VA = "0x9A86D0", Slot = "6")]
		public override void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x9A83A0", Offset = "0x9A83A0", VA = "0x9A83A0")]
		public static float MaxBoundsExtent(Transform obj, bool includeEffects)
		{
			return default(float);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x9A86F4", Offset = "0x9A86F4", VA = "0x9A86F4")]
		public TargetFieldOfView()
		{
		}
	}
}
