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
using UnityEngine.Rendering;
using UnityEngine.Serialization;
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
	[Address(RVA = "0xC3E128", Offset = "0xC3E128", VA = "0xC3E128")]
	public void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xC3E2E0", Offset = "0xC3E2E0", VA = "0xC3E2E0", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xC3E5C4", Offset = "0xC3E5C4", VA = "0xC3E5C4")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000003")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000004")]
	[Address(RVA = "0xC3E5CC", Offset = "0xC3E5CC", VA = "0xC3E5CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xC3E6D4", Offset = "0xC3E6D4", VA = "0xC3E6D4")]
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
		[Address(RVA = "0xC3E6DC", Offset = "0xC3E6DC", VA = "0xC3E6DC")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xC3EB18", Offset = "0xC3EB18", VA = "0xC3EB18")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xC3EB1C", Offset = "0xC3EB1C", VA = "0xC3EB1C")]
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
			[Address(RVA = "0xC3F554", Offset = "0xC3F554", VA = "0xC3F554")]
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
			[Address(RVA = "0xC3F55C", Offset = "0xC3F55C", VA = "0xC3F55C")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xC3EB34", Offset = "0xC3EB34", VA = "0xC3EB34")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xC3F54C", Offset = "0xC3F54C", VA = "0xC3F54C")]
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
			[Address(RVA = "0xC3F69C", Offset = "0xC3F69C", VA = "0xC3F69C")]
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
		[Address(RVA = "0xC3F5B4", Offset = "0xC3F5B4", VA = "0xC3F5B4")]
		private void Start()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xC3F5D0", Offset = "0xC3F5D0", VA = "0xC3F5D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xC3F694", Offset = "0xC3F694", VA = "0xC3F694")]
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
		[Address(RVA = "0xC3F6AC", Offset = "0xC3F6AC", VA = "0xC3F6AC")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xC3F700", Offset = "0xC3F700", VA = "0xC3F700")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xC3F708", Offset = "0xC3F708", VA = "0xC3F708")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xC3F710", Offset = "0xC3F710", VA = "0xC3F710")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xC3F7FC", Offset = "0xC3F7FC", VA = "0xC3F7FC")]
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
		[Address(RVA = "0xC3F840", Offset = "0xC3F840", VA = "0xC3F840")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xC3F8E0", Offset = "0xC3F8E0", VA = "0xC3F8E0")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xC3F9D0", Offset = "0xC3F9D0", VA = "0xC3F9D0")]
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
				[Address(RVA = "0xC4032C", Offset = "0xC4032C", VA = "0xC4032C", Slot = "4")]
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
				[Address(RVA = "0xC40374", Offset = "0xC40374", VA = "0xC40374", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600001D")]
			[Address(RVA = "0xC400D0", Offset = "0xC400D0", VA = "0xC400D0")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600001E")]
			[Address(RVA = "0xC40100", Offset = "0xC40100", VA = "0xC40100", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600001F")]
			[Address(RVA = "0xC40104", Offset = "0xC40104", VA = "0xC40104", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000021")]
			[Address(RVA = "0xC40334", Offset = "0xC40334", VA = "0xC40334", Slot = "8")]
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
		[Address(RVA = "0xC3FC10", Offset = "0xC3FC10", VA = "0xC3FC10")]
		private void Update()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xC40058", Offset = "0xC40058", VA = "0xC40058")]
		[IteratorStateMachine(typeof(<DragObject>d__8))]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xC3FFAC", Offset = "0xC3FFAC", VA = "0xC3FFAC")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xC400F8", Offset = "0xC400F8", VA = "0xC400F8")]
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
		[Address(RVA = "0xC4037C", Offset = "0xC4037C", VA = "0xC4037C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xC403A4", Offset = "0xC403A4", VA = "0xC403A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xC405C8", Offset = "0xC405C8", VA = "0xC405C8")]
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
		[Address(RVA = "0xC405FC", Offset = "0xC405FC", VA = "0xC405FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xC40658", Offset = "0xC40658", VA = "0xC40658")]
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
				[Address(RVA = "0xC40A04", Offset = "0xC40A04", VA = "0xC40A04", Slot = "4")]
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
				[Address(RVA = "0xC40A4C", Offset = "0xC40A4C", VA = "0xC40A4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600002E")]
			[Address(RVA = "0xC40804", Offset = "0xC40804", VA = "0xC40804")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600002F")]
			[Address(RVA = "0xC408D8", Offset = "0xC408D8", VA = "0xC408D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000030")]
			[Address(RVA = "0xC408DC", Offset = "0xC408DC", VA = "0xC408DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000032")]
			[Address(RVA = "0xC40A0C", Offset = "0xC40A0C", VA = "0xC40A0C", Slot = "8")]
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
				[Address(RVA = "0xC40B94", Offset = "0xC40B94", VA = "0xC40B94", Slot = "4")]
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
				[Address(RVA = "0xC40BDC", Offset = "0xC40BDC", VA = "0xC40BDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000034")]
			[Address(RVA = "0xC40894", Offset = "0xC40894", VA = "0xC40894")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000035")]
			[Address(RVA = "0xC40A54", Offset = "0xC40A54", VA = "0xC40A54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000036")]
			[Address(RVA = "0xC40A58", Offset = "0xC40A58", VA = "0xC40A58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000038")]
			[Address(RVA = "0xC40B9C", Offset = "0xC40B9C", VA = "0xC40B9C", Slot = "8")]
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
		[Address(RVA = "0xC40670", Offset = "0xC40670", VA = "0xC40670")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xC406AC", Offset = "0xC406AC", VA = "0xC406AC")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xC40794", Offset = "0xC40794", VA = "0xC40794")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xC4079C", Offset = "0xC4079C", VA = "0xC4079C")]
		[IteratorStateMachine(typeof(<FOVKickUp>d__9))]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xC4082C", Offset = "0xC4082C", VA = "0xC4082C")]
		[IteratorStateMachine(typeof(<FOVKickDown>d__10))]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xC408BC", Offset = "0xC408BC", VA = "0xC408BC")]
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
		[Address(RVA = "0xC40BE4", Offset = "0xC40BE4", VA = "0xC40BE4")]
		private void Start()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xC40C48", Offset = "0xC40C48", VA = "0xC40C48")]
		private void Update()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xC40D3C", Offset = "0xC40D3C", VA = "0xC40D3C")]
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
				[Address(RVA = "0xC40F84", Offset = "0xC40F84", VA = "0xC40F84", Slot = "4")]
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
				[Address(RVA = "0xC40FCC", Offset = "0xC40FCC", VA = "0xC40FCC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000040")]
			[Address(RVA = "0xC40DB4", Offset = "0xC40DB4", VA = "0xC40DB4")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000041")]
			[Address(RVA = "0xC40DE4", Offset = "0xC40DE4", VA = "0xC40DE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000042")]
			[Address(RVA = "0xC40DE8", Offset = "0xC40DE8", VA = "0xC40DE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000044")]
			[Address(RVA = "0xC40F8C", Offset = "0xC40F8C", VA = "0xC40F8C", Slot = "8")]
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
		[Address(RVA = "0xC40D44", Offset = "0xC40D44", VA = "0xC40D44")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xC40D4C", Offset = "0xC40D4C", VA = "0xC40D4C")]
		[IteratorStateMachine(typeof(<DoBobCycle>d__4))]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xC40DDC", Offset = "0xC40DDC", VA = "0xC40DDC")]
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
				[Address(RVA = "0xC4142C", Offset = "0xC4142C", VA = "0xC4142C", Slot = "4")]
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
				[Address(RVA = "0xC41474", Offset = "0xC41474", VA = "0xC41474", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600004A")]
			[Address(RVA = "0xC41178", Offset = "0xC41178", VA = "0xC41178")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600004B")]
			[Address(RVA = "0xC411A8", Offset = "0xC411A8", VA = "0xC411A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600004C")]
			[Address(RVA = "0xC411AC", Offset = "0xC411AC", VA = "0xC411AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0xC41434", Offset = "0xC41434", VA = "0xC41434", Slot = "8")]
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
		[Address(RVA = "0xC40FD4", Offset = "0xC40FD4", VA = "0xC40FD4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xC410E0", Offset = "0xC410E0", VA = "0xC410E0")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xC41100", Offset = "0xC41100", VA = "0xC41100")]
		[IteratorStateMachine(typeof(<ResetCoroutine>d__6))]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xC411A0", Offset = "0xC411A0", VA = "0xC411A0")]
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
				[Address(RVA = "0xC41844", Offset = "0xC41844", VA = "0xC41844", Slot = "4")]
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
				[Address(RVA = "0xC4188C", Offset = "0xC4188C", VA = "0xC4188C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000053")]
			[Address(RVA = "0xC414E4", Offset = "0xC414E4", VA = "0xC414E4")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000054")]
			[Address(RVA = "0xC4152C", Offset = "0xC4152C", VA = "0xC4152C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000055")]
			[Address(RVA = "0xC41530", Offset = "0xC41530", VA = "0xC41530", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000057")]
			[Address(RVA = "0xC4184C", Offset = "0xC4184C", VA = "0xC4184C", Slot = "8")]
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
		[Address(RVA = "0xC4147C", Offset = "0xC4147C", VA = "0xC4147C")]
		[IteratorStateMachine(typeof(<Start>d__4))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xC4150C", Offset = "0xC4150C", VA = "0xC4150C")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xC41518", Offset = "0xC41518", VA = "0xC41518")]
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
		[Address(RVA = "0xC41894", Offset = "0xC41894", VA = "0xC41894")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xC41898", Offset = "0xC41898", VA = "0xC41898")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xC418A8", Offset = "0xC418A8", VA = "0xC418A8")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xC41C94", Offset = "0xC41C94", VA = "0xC41C94")]
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
		[Address(RVA = "0xC41D18", Offset = "0xC41D18", VA = "0xC41D18")]
		private void Start()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xC41D48", Offset = "0xC41D48", VA = "0xC41D48")]
		private void Update()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xC421C0", Offset = "0xC421C0", VA = "0xC421C0")]
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
		[Address(RVA = "0xC421E0", Offset = "0xC421E0", VA = "0xC421E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xC421E4", Offset = "0xC421E4", VA = "0xC421E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xC42518", Offset = "0xC42518", VA = "0xC42518")]
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
			[Address(RVA = "0xC42864", Offset = "0xC42864", VA = "0xC42864")]
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
			[Address(RVA = "0xC4285C", Offset = "0xC4285C", VA = "0xC4285C")]
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
				[Address(RVA = "0xC42934", Offset = "0xC42934", VA = "0xC42934", Slot = "4")]
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
				[Address(RVA = "0xC4297C", Offset = "0xC4297C", VA = "0xC4297C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600006A")]
			[Address(RVA = "0xC4277C", Offset = "0xC4277C", VA = "0xC4277C")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x600006B")]
			[Address(RVA = "0xC4286C", Offset = "0xC4286C", VA = "0xC4286C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600006C")]
			[Address(RVA = "0xC42870", Offset = "0xC42870", VA = "0xC42870", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600006E")]
			[Address(RVA = "0xC4293C", Offset = "0xC4293C", VA = "0xC4293C", Slot = "8")]
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
				[Address(RVA = "0xC42A4C", Offset = "0xC42A4C", VA = "0xC42A4C", Slot = "4")]
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
				[Address(RVA = "0xC42A94", Offset = "0xC42A94", VA = "0xC42A94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000070")]
			[Address(RVA = "0xC427A4", Offset = "0xC427A4", VA = "0xC427A4")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000071")]
			[Address(RVA = "0xC42984", Offset = "0xC42984", VA = "0xC42984", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000072")]
			[Address(RVA = "0xC42988", Offset = "0xC42988", VA = "0xC42988", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000074")]
			[Address(RVA = "0xC42A54", Offset = "0xC42A54", VA = "0xC42A54", Slot = "8")]
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
				[Address(RVA = "0xC42BA0", Offset = "0xC42BA0", VA = "0xC42BA0", Slot = "4")]
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
				[Address(RVA = "0xC42BE8", Offset = "0xC42BE8", VA = "0xC42BE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000076")]
			[Address(RVA = "0xC427CC", Offset = "0xC427CC", VA = "0xC427CC")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000077")]
			[Address(RVA = "0xC42A9C", Offset = "0xC42A9C", VA = "0xC42A9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000078")]
			[Address(RVA = "0xC42AA0", Offset = "0xC42AA0", VA = "0xC42AA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600007A")]
			[Address(RVA = "0xC42BA8", Offset = "0xC42BA8", VA = "0xC42BA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xC4252C", Offset = "0xC4252C", VA = "0xC4252C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xC42644", Offset = "0xC42644", VA = "0xC42644")]
		[IteratorStateMachine(typeof(<Activate>d__5))]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xC426AC", Offset = "0xC426AC", VA = "0xC426AC")]
		[IteratorStateMachine(typeof(<Deactivate>d__6))]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xC42714", Offset = "0xC42714", VA = "0xC42714")]
		[IteratorStateMachine(typeof(<ReloadLevel>d__7))]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xC427F4", Offset = "0xC427F4", VA = "0xC427F4")]
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
		[Address(RVA = "0xC42BF0", Offset = "0xC42BF0", VA = "0xC42BF0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xC42C40", Offset = "0xC42C40", VA = "0xC42C40")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xC42CD0", Offset = "0xC42CD0", VA = "0xC42CD0")]
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
			[Address(RVA = "0xC437B4", Offset = "0xC437B4", VA = "0xC437B4")]
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
			[Address(RVA = "0xC433AC", Offset = "0xC433AC", VA = "0xC433AC")]
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
			[Address(RVA = "0xC42CE0", Offset = "0xC42CE0", VA = "0xC42CE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0xC42CE8", Offset = "0xC42CE8", VA = "0xC42CE8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0xC42CF0", Offset = "0xC42CF0", VA = "0xC42CF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xC42D0C", Offset = "0xC42D0C", VA = "0xC42D0C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xC4301C", Offset = "0xC4301C", VA = "0xC4301C")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xC4314C", Offset = "0xC4314C", VA = "0xC4314C")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xC433BC", Offset = "0xC433BC", VA = "0xC433BC")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xC42D5C", Offset = "0xC42D5C", VA = "0xC42D5C")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xC434C8", Offset = "0xC434C8", VA = "0xC434C8")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xC43738", Offset = "0xC43738", VA = "0xC43738")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xC434D0", Offset = "0xC434D0", VA = "0xC434D0")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xC43740", Offset = "0xC43740", VA = "0xC43740")]
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
			[Address(RVA = "0xC4380C", Offset = "0xC4380C", VA = "0xC4380C")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xC43820", Offset = "0xC43820", VA = "0xC43820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xC43834", Offset = "0xC43834", VA = "0xC43834")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xC43848", Offset = "0xC43848", VA = "0xC43848")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0xC4385C", Offset = "0xC4385C", VA = "0xC4385C")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0xC43870", Offset = "0xC43870", VA = "0xC43870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xC43884", Offset = "0xC43884", VA = "0xC43884")]
		private void Start()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xC43968", Offset = "0xC43968", VA = "0xC43968")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xC43A34", Offset = "0xC43A34", VA = "0xC43A34")]
		private void Update()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xC43F0C", Offset = "0xC43F0C", VA = "0xC43F0C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xC44068", Offset = "0xC44068", VA = "0xC44068")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200002C")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xC44084", Offset = "0xC44084", VA = "0xC44084")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xC442D4", Offset = "0xC442D4", VA = "0xC442D4")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xC44450", Offset = "0xC44450", VA = "0xC44450")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xC444C0", Offset = "0xC444C0", VA = "0xC444C0", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xC4458C", Offset = "0xC4458C", VA = "0xC4458C", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xC445F0", Offset = "0xC445F0", VA = "0xC445F0")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xC44654", Offset = "0xC44654", VA = "0xC44654")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xC44658", Offset = "0xC44658", VA = "0xC44658")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xC44720", Offset = "0xC44720", VA = "0xC44720")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xC447E8", Offset = "0xC447E8", VA = "0xC447E8")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xC448B0", Offset = "0xC448B0", VA = "0xC448B0")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xC44978", Offset = "0xC44978", VA = "0xC44978")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xC44A40", Offset = "0xC44A40", VA = "0xC44A40")]
		public void Update()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xC44A44", Offset = "0xC44A44", VA = "0xC44A44")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200002F")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x40000CA")]
			Hardware,
			[Token(Token = "0x40000CB")]
			Touch
		}

		[Token(Token = "0x2000030")]
		public class VirtualAxis
		{
			[Token(Token = "0x40000CD")]
			[FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x17000019")]
			public string name
			{
				[Token(Token = "0x60000BF")]
				[Address(RVA = "0xC45778", Offset = "0xC45778", VA = "0xC45778")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60000C0")]
				[Address(RVA = "0xC45780", Offset = "0xC45780", VA = "0xC45780")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700001A")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60000C1")]
				[Address(RVA = "0xC45788", Offset = "0xC45788", VA = "0xC45788")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60000C2")]
				[Address(RVA = "0xC45790", Offset = "0xC45790", VA = "0xC45790")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700001B")]
			public float GetValue
			{
				[Token(Token = "0x60000C7")]
				[Address(RVA = "0xC457D8", Offset = "0xC457D8", VA = "0xC457D8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700001C")]
			public float GetValueRaw
			{
				[Token(Token = "0x60000C8")]
				[Address(RVA = "0xC457E0", Offset = "0xC457E0", VA = "0xC457E0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xC441D4", Offset = "0xC441D4", VA = "0xC441D4")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xC4579C", Offset = "0xC4579C", VA = "0xC4579C")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xC44468", Offset = "0xC44468", VA = "0xC44468")]
			public void Remove()
			{
			}

			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xC457D0", Offset = "0xC457D0", VA = "0xC457D0")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000031")]
		public class VirtualButton
		{
			[Token(Token = "0x40000D1")]
			[FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x40000D2")]
			[FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x40000D3")]
			[FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x1700001D")]
			public string name
			{
				[Token(Token = "0x60000C9")]
				[Address(RVA = "0xC457E8", Offset = "0xC457E8", VA = "0xC457E8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60000CA")]
				[Address(RVA = "0xC457F0", Offset = "0xC457F0", VA = "0xC457F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700001E")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60000CB")]
				[Address(RVA = "0xC457F8", Offset = "0xC457F8", VA = "0xC457F8")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60000CC")]
				[Address(RVA = "0xC45800", Offset = "0xC45800", VA = "0xC45800")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700001F")]
			public bool GetButton
			{
				[Token(Token = "0x60000D2")]
				[Address(RVA = "0xC45924", Offset = "0xC45924", VA = "0xC45924")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000020")]
			public bool GetButtonDown
			{
				[Token(Token = "0x60000D3")]
				[Address(RVA = "0xC4592C", Offset = "0xC4592C", VA = "0xC4592C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000021")]
			public bool GetButtonUp
			{
				[Token(Token = "0x60000D4")]
				[Address(RVA = "0xC45950", Offset = "0xC45950", VA = "0xC45950")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xC4580C", Offset = "0xC4580C", VA = "0xC4580C")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xC45844", Offset = "0xC45844", VA = "0xC45844")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xC45880", Offset = "0xC45880", VA = "0xC45880")]
			public void Pressed()
			{
			}

			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xC458AC", Offset = "0xC458AC", VA = "0xC458AC")]
			public void Released()
			{
			}

			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xC458CC", Offset = "0xC458CC", VA = "0xC458CC")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x17000018")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0xC455A4", Offset = "0xC455A4", VA = "0xC455A4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xC44A4C", Offset = "0xC44A4C", VA = "0xC44A4C")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xC44B04", Offset = "0xC44B04", VA = "0xC44B04")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xC4416C", Offset = "0xC4416C", VA = "0xC4416C")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xC44BEC", Offset = "0xC44BEC", VA = "0xC44BEC")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xC44204", Offset = "0xC44204", VA = "0xC44204")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xC44E34", Offset = "0xC44E34", VA = "0xC44E34")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xC45024", Offset = "0xC45024", VA = "0xC45024")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xC4516C", Offset = "0xC4516C", VA = "0xC4516C")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xC4426C", Offset = "0xC4426C", VA = "0xC4426C")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xC42168", Offset = "0xC42168", VA = "0xC42168")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xC45378", Offset = "0xC45378", VA = "0xC45378")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xC452F8", Offset = "0xC452F8", VA = "0xC452F8")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xC453D0", Offset = "0xC453D0", VA = "0xC453D0")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xC45440", Offset = "0xC45440", VA = "0xC45440")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xC454B0", Offset = "0xC454B0", VA = "0xC454B0")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xC446B0", Offset = "0xC446B0", VA = "0xC446B0")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xC44778", Offset = "0xC44778", VA = "0xC44778")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xC44840", Offset = "0xC44840", VA = "0xC44840")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xC449D0", Offset = "0xC449D0", VA = "0xC449D0")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xC44908", Offset = "0xC44908", VA = "0xC44908")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xC45520", Offset = "0xC45520", VA = "0xC45520")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xC45610", Offset = "0xC45610", VA = "0xC45610")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xC45688", Offset = "0xC45688", VA = "0xC45688")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xC45700", Offset = "0xC45700", VA = "0xC45700")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xC45974", Offset = "0xC45974", VA = "0xC45974")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xC45978", Offset = "0xC45978", VA = "0xC45978")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xC459E8", Offset = "0xC459E8", VA = "0xC459E8")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000034")]
		public enum AxisOption
		{
			[Token(Token = "0x40000DF")]
			Both,
			[Token(Token = "0x40000E0")]
			OnlyHorizontal,
			[Token(Token = "0x40000E1")]
			OnlyVertical
		}

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xC459F0", Offset = "0xC459F0", VA = "0xC459F0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xC45B18", Offset = "0xC45B18", VA = "0xC45B18")]
		private void Start()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xC45B48", Offset = "0xC45B48", VA = "0xC45B48")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xC459F4", Offset = "0xC459F4", VA = "0xC459F4")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xC45BA8", Offset = "0xC45BA8", VA = "0xC45BA8", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xC45CF4", Offset = "0xC45CF4", VA = "0xC45CF4", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xC45D30", Offset = "0xC45D30", VA = "0xC45D30", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xC45D34", Offset = "0xC45D34", VA = "0xC45D34")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xC45D74", Offset = "0xC45D74", VA = "0xC45D74")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xC45DF0", Offset = "0xC45DF0", VA = "0xC45DF0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xC45E00", Offset = "0xC45E00", VA = "0xC45E00")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xC45DF8", Offset = "0xC45DF8", VA = "0xC45DF8")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xC45F08", Offset = "0xC45F08", VA = "0xC45F08")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xC46200", Offset = "0xC46200", VA = "0xC46200")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000037")]
		public enum AxisOptions
		{
			[Token(Token = "0x40000E8")]
			ForwardAxis,
			[Token(Token = "0x40000E9")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x2000038")]
		public class AxisMapping
		{
			[Token(Token = "0x2000039")]
			public enum MappingType
			{
				[Token(Token = "0x40000ED")]
				NamedAxis,
				[Token(Token = "0x40000EE")]
				MousePositionX,
				[Token(Token = "0x40000EF")]
				MousePositionY,
				[Token(Token = "0x40000F0")]
				MousePositionZ
			}

			[Token(Token = "0x40000EA")]
			[FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x40000EB")]
			[FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xC46540", Offset = "0xC46540", VA = "0xC46540")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xC46208", Offset = "0xC46208", VA = "0xC46208")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xC462C8", Offset = "0xC462C8", VA = "0xC462C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xC46518", Offset = "0xC46518", VA = "0xC46518")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xC46530", Offset = "0xC46530", VA = "0xC46530")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x200003B")]
		public enum AxisOption
		{
			[Token(Token = "0x4000104")]
			Both,
			[Token(Token = "0x4000105")]
			OnlyHorizontal,
			[Token(Token = "0x4000106")]
			OnlyVertical
		}

		[Token(Token = "0x200003C")]
		public enum ControlStyle
		{
			[Token(Token = "0x4000108")]
			Absolute,
			[Token(Token = "0x4000109")]
			Relative,
			[Token(Token = "0x400010A")]
			Swipe
		}

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xC46548", Offset = "0xC46548", VA = "0xC46548")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xC46670", Offset = "0xC46670", VA = "0xC46670")]
		private void Start()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xC4654C", Offset = "0xC4654C", VA = "0xC4654C")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xC466E4", Offset = "0xC466E4", VA = "0xC466E4")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xC467E4", Offset = "0xC467E4", VA = "0xC467E4", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xC4681C", Offset = "0xC4681C", VA = "0xC4681C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xC469F4", Offset = "0xC469F4", VA = "0xC469F4", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xC46A54", Offset = "0xC46A54", VA = "0xC46A54")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xC46B14", Offset = "0xC46B14", VA = "0xC46B14")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x17000022")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xC46B98", Offset = "0xC46B98", VA = "0xC46B98")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0xC46BA4", Offset = "0xC46BA4", VA = "0xC46BA4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xC44B94", Offset = "0xC44B94", VA = "0xC44B94")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xC44C54", Offset = "0xC44C54", VA = "0xC44C54")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xC44CAC", Offset = "0xC44CAC", VA = "0xC44CAC")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xC44E9C", Offset = "0xC44E9C", VA = "0xC44E9C")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xC450DC", Offset = "0xC450DC", VA = "0xC450DC")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xC451D4", Offset = "0xC451D4", VA = "0xC451D4")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xC45264", Offset = "0xC45264", VA = "0xC45264")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xC45680", Offset = "0xC45680", VA = "0xC45680")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xC456F8", Offset = "0xC456F8", VA = "0xC456F8")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xC45770", Offset = "0xC45770", VA = "0xC45770")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x6000100")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x6000101")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x6000102")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x6000103")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x6000104")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000105")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000106")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000107")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x6000108")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000109")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x600010A")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xC46BB0", Offset = "0xC46BB0", VA = "0xC46BB0")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x200003E")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x600010C")]
		[Address(RVA = "0xC46CB4", Offset = "0xC46CB4", VA = "0xC46CB4")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xC46D4C", Offset = "0xC46D4C", VA = "0xC46D4C")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xC46DDC", Offset = "0xC46DDC", VA = "0xC46DDC", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xC46E74", Offset = "0xC46E74", VA = "0xC46E74", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xC46F28", Offset = "0xC46F28", VA = "0xC46F28", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xC46FD0", Offset = "0xC46FD0", VA = "0xC46FD0", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xC4706C", Offset = "0xC4706C", VA = "0xC4706C", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xC47108", Offset = "0xC47108", VA = "0xC47108", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xC471A0", Offset = "0xC471A0", VA = "0xC471A0", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xC47244", Offset = "0xC47244", VA = "0xC47244", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xC472F0", Offset = "0xC472F0", VA = "0xC472F0", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xC4739C", Offset = "0xC4739C", VA = "0xC4739C", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xC47434", Offset = "0xC47434", VA = "0xC47434", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xC44AFC", Offset = "0xC44AFC", VA = "0xC44AFC")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x600011A")]
		[Address(RVA = "0xC47440", Offset = "0xC47440", VA = "0xC47440", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xC47454", Offset = "0xC47454", VA = "0xC47454", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xC47460", Offset = "0xC47460", VA = "0xC47460", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xC4746C", Offset = "0xC4746C", VA = "0xC4746C", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xC47478", Offset = "0xC47478", VA = "0xC47478", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xC474C8", Offset = "0xC474C8", VA = "0xC474C8", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xC47518", Offset = "0xC47518", VA = "0xC47518", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xC47568", Offset = "0xC47568", VA = "0xC47568", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xC475B8", Offset = "0xC475B8", VA = "0xC475B8", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xC47608", Offset = "0xC47608", VA = "0xC47608", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xC47658", Offset = "0xC47658", VA = "0xC47658", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xC44B00", Offset = "0xC44B00", VA = "0xC44B00")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Ball
{
	[Token(Token = "0x2000040")]
	public class Ball : MonoBehaviour
	{
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovePower;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_UseTorque;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MaxAngularVelocity;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x4000113")]
		private const float k_GroundRayLength = 1f;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xC47660", Offset = "0xC47660", VA = "0xC47660")]
		private void Start()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xC476CC", Offset = "0xC476CC", VA = "0xC476CC")]
		public void Move(Vector3 moveDirection, bool jump)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xC47840", Offset = "0xC47840", VA = "0xC47840")]
		public Ball()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class BallUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x18")]
		private Ball ball;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 move;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x30")]
		private Transform cam;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 camForward;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x44")]
		private bool jump;

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xC47864", Offset = "0xC47864", VA = "0xC47864")]
		private void Awake()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xC47970", Offset = "0xC47970", VA = "0xC47970")]
		private void Update()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xC47D50", Offset = "0xC47D50", VA = "0xC47D50")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xC47D80", Offset = "0xC47D80", VA = "0xC47D80")]
		public BallUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[Token(Token = "0x2000042")]
	[RequireComponent(typeof(NavMeshAgent))]
	[RequireComponent(typeof(ThirdPersonCharacter))]
	public class AICharacterControl : MonoBehaviour
	{
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x17000023")]
		public NavMeshAgent agent
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0xC47D88", Offset = "0xC47D88", VA = "0xC47D88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600012E")]
			[Address(RVA = "0xC47D90", Offset = "0xC47D90", VA = "0xC47D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public ThirdPersonCharacter character
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0xC47D98", Offset = "0xC47D98", VA = "0xC47D98")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000130")]
			[Address(RVA = "0xC47DA0", Offset = "0xC47DA0", VA = "0xC47DA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xC47DA8", Offset = "0xC47DA8", VA = "0xC47DA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xC47E50", Offset = "0xC47E50", VA = "0xC47E50")]
		private void Update()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xC481D4", Offset = "0xC481D4", VA = "0xC481D4")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xC481DC", Offset = "0xC481DC", VA = "0xC481DC")]
		public AICharacterControl()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Animator))]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovingTurnSpeed;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_StationaryTurnSpeed;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(1f, 4f)]
		private float m_GravityMultiplier;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_RunCycleLegOffset;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MoveSpeedMultiplier;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_AnimSpeedMultiplier;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_GroundCheckDistance;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x40")]
		private Animator m_Animator;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x48")]
		private bool m_IsGrounded;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x4C")]
		private float m_OrigGroundCheckDistance;

		[Token(Token = "0x4000129")]
		private const float k_Half = 0.5f;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x50")]
		private float m_TurnAmount;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x54")]
		private float m_ForwardAmount;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 m_GroundNormal;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x64")]
		private float m_CapsuleHeight;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 m_CapsuleCenter;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x78")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x80")]
		private bool m_Crouching;

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xC481E4", Offset = "0xC481E4", VA = "0xC481E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xC47F78", Offset = "0xC47F78", VA = "0xC47F78")]
		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xC48688", Offset = "0xC48688", VA = "0xC48688")]
		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xC488A8", Offset = "0xC488A8", VA = "0xC488A8")]
		private void PreventStandingInLowHeadroom()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xC48A28", Offset = "0xC48A28", VA = "0xC48A28")]
		private void UpdateAnimator(Vector3 move)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xC485F0", Offset = "0xC485F0", VA = "0xC485F0")]
		private void HandleAirborneMovement()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xC484D4", Offset = "0xC484D4", VA = "0xC484D4")]
		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xC48450", Offset = "0xC48450", VA = "0xC48450")]
		private void ApplyExtraTurnRotation()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xC48CE8", Offset = "0xC48CE8", VA = "0xC48CE8")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xC482CC", Offset = "0xC482CC", VA = "0xC482CC")]
		private void CheckGroundStatus()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xC48D88", Offset = "0xC48D88", VA = "0xC48D88")]
		public ThirdPersonCharacter()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[RequireComponent(typeof(ThirdPersonCharacter))]
	public class ThirdPersonUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x18")]
		private ThirdPersonCharacter m_Character;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x20")]
		private Transform m_Cam;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 m_CamForward;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 m_Move;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x40")]
		private bool m_Jump;

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xC48DA8", Offset = "0xC48DA8", VA = "0xC48DA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xC48EBC", Offset = "0xC48EBC", VA = "0xC48EBC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xC48F38", Offset = "0xC48F38", VA = "0xC48F38")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xC491CC", Offset = "0xC491CC", VA = "0xC491CC")]
		public ThirdPersonUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x2000045")]
	[RequireComponent(typeof(AudioSource))]
	[RequireComponent(typeof(CharacterController))]
	public class FirstPersonController : MonoBehaviour
	{
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_RunstepLenghten;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MouseLook m_MouseLook;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FOVKick m_FovKick;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioClip m_JumpSound;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AudioClip m_LandSound;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x88")]
		private Camera m_Camera;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x90")]
		private bool m_Jump;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x94")]
		private float m_YRotation;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x98")]
		private Vector2 m_Input;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0xB0")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0xB8")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0xBC")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0xC0")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0xCC")]
		private float m_StepCycle;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0xD0")]
		private float m_NextStep;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0xD4")]
		private bool m_Jumping;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0xD8")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xC491D4", Offset = "0xC491D4", VA = "0xC491D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xC4932C", Offset = "0xC4932C", VA = "0xC4932C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xC4948C", Offset = "0xC4948C", VA = "0xC4948C")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xC494D4", Offset = "0xC494D4", VA = "0xC494D4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xC49AE4", Offset = "0xC49AE4", VA = "0xC49AE4")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xC49B18", Offset = "0xC49B18", VA = "0xC49B18")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xC49EB8", Offset = "0xC49EB8", VA = "0xC49EB8")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xC49C68", Offset = "0xC49C68", VA = "0xC49C68")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xC498D4", Offset = "0xC498D4", VA = "0xC498D4")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xC4943C", Offset = "0xC4943C", VA = "0xC4943C")]
		private void RotateView()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xC4A35C", Offset = "0xC4A35C", VA = "0xC4A35C")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xC4A480", Offset = "0xC4A480", VA = "0xC4A480")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class HeadBob : MonoBehaviour
	{
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x18")]
		public Camera Camera;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x20")]
		public CurveControlledBob motionBob;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x28")]
		public LerpControlledBob jumpAndLandingBob;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x30")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x38")]
		public float StrideInterval;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float RunningStrideLengthen;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xC4A598", Offset = "0xC4A598", VA = "0xC4A598")]
		private void Start()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xC4A5E4", Offset = "0xC4A5E4", VA = "0xC4A5E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xC4A85C", Offset = "0xC4A85C", VA = "0xC4A85C")]
		public HeadBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class MouseLook
	{
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xC492DC", Offset = "0xC492DC", VA = "0xC492DC")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xC49FF0", Offset = "0xC49FF0", VA = "0xC49FF0")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xC4A954", Offset = "0xC4A954", VA = "0xC4A954")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xC49EA8", Offset = "0xC49EA8", VA = "0xC49EA8")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xC4A988", Offset = "0xC4A988", VA = "0xC4A988")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xC4A8F0", Offset = "0xC4A8F0", VA = "0xC4A8F0")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xC4AA00", Offset = "0xC4AA00", VA = "0xC4AA00")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000049")]
		public class MovementSettings
		{
			[Token(Token = "0x4000173")]
			[FieldOffset(Offset = "0x10")]
			public float ForwardSpeed;

			[Token(Token = "0x4000174")]
			[FieldOffset(Offset = "0x14")]
			public float BackwardSpeed;

			[Token(Token = "0x4000175")]
			[FieldOffset(Offset = "0x18")]
			public float StrafeSpeed;

			[Token(Token = "0x4000176")]
			[FieldOffset(Offset = "0x1C")]
			public float RunMultiplier;

			[Token(Token = "0x4000177")]
			[FieldOffset(Offset = "0x20")]
			public KeyCode RunKey;

			[Token(Token = "0x4000178")]
			[FieldOffset(Offset = "0x24")]
			public float JumpForce;

			[Token(Token = "0x4000179")]
			[FieldOffset(Offset = "0x28")]
			public AnimationCurve SlopeCurveModifier;

			[Token(Token = "0x400017A")]
			[FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public float CurrentTargetSpeed;

			[Token(Token = "0x6000167")]
			[Address(RVA = "0xC4B880", Offset = "0xC4B880", VA = "0xC4B880")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x6000168")]
			[Address(RVA = "0xC4BA3C", Offset = "0xC4BA3C", VA = "0xC4BA3C")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200004A")]
		public class AdvancedSettings
		{
			[Token(Token = "0x400017B")]
			[FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			[Token(Token = "0x400017C")]
			[FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x400017D")]
			[FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			[Token(Token = "0x400017E")]
			[FieldOffset(Offset = "0x1C")]
			public bool airControl;

			[Token(Token = "0x400017F")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("set it to 0.1 or more if you get stuck in wall")]
			public float shellOffset;

			[Token(Token = "0x6000169")]
			[Address(RVA = "0xC4BBEC", Offset = "0xC4BBEC", VA = "0xC4BBEC")]
			public AdvancedSettings()
			{
			}
		}

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x18")]
		public Camera cam;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x20")]
		public MovementSettings movementSettings;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x28")]
		public MouseLook mouseLook;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x30")]
		public AdvancedSettings advancedSettings;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x40")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x48")]
		private float m_YRotation;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 m_GroundContactNormal;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x58")]
		private bool m_Jump;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x59")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x5A")]
		private bool m_Jumping;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x5B")]
		private bool m_IsGrounded;

		[Token(Token = "0x17000025")]
		public Vector3 Velocity
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0xC4A838", Offset = "0xC4A838", VA = "0xC4A838")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000026")]
		public bool Grounded
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0xC4AA34", Offset = "0xC4AA34", VA = "0xC4AA34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		public bool Jumping
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0xC4AA3C", Offset = "0xC4AA3C", VA = "0xC4AA3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000028")]
		public bool Running
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0xC4A854", Offset = "0xC4A854", VA = "0xC4A854")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xC4AA44", Offset = "0xC4AA44", VA = "0xC4AA44")]
		private void Start()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xC4AAFC", Offset = "0xC4AAFC", VA = "0xC4AAFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xC4AD00", Offset = "0xC4AD00", VA = "0xC4AD00")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xC4B3D4", Offset = "0xC4B3D4", VA = "0xC4B3D4")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xC4B534", Offset = "0xC4B534", VA = "0xC4B534")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xC4B31C", Offset = "0xC4B31C", VA = "0xC4B31C")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xC4AB84", Offset = "0xC4AB84", VA = "0xC4AB84")]
		private void RotateView()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xC4B150", Offset = "0xC4B150", VA = "0xC4B150")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xC4B938", Offset = "0xC4B938", VA = "0xC4B938")]
		public RigidbodyFirstPersonController()
		{
		}
	}
}
namespace VLB
{
	[Token(Token = "0x200004B")]
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	public class BeamGeometry : MonoBehaviour
	{
		[Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class <CoUpdateFadeOut>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000188")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000189")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400018A")]
			[FieldOffset(Offset = "0x20")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x17000033")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600019A")]
				[Address(RVA = "0xC4EE38", Offset = "0xC4EE38", VA = "0xC4EE38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000034")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600019C")]
				[Address(RVA = "0xC4EE80", Offset = "0xC4EE80", VA = "0xC4EE80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000197")]
			[Address(RVA = "0xC4BE54", Offset = "0xC4BE54", VA = "0xC4BE54")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000198")]
			[Address(RVA = "0xC4EDC0", Offset = "0xC4EDC0", VA = "0xC4EDC0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000199")]
			[Address(RVA = "0xC4EDC4", Offset = "0xC4EDC4", VA = "0xC4EDC4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600019B")]
			[Address(RVA = "0xC4EE40", Offset = "0xC4EE40", VA = "0xC4EE40", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x18")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x20")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x60")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x68")]
		private Material m_CustomMaterial;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x88")]
		private Plane m_ClippingPlaneWS;

		[Token(Token = "0x17000029")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0xC4BC08", Offset = "0xC4BC08", VA = "0xC4BC08")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0xC4BC10", Offset = "0xC4BC10", VA = "0xC4BC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0xC4BC18", Offset = "0xC4BC18", VA = "0xC4BC18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0xC4BC20", Offset = "0xC4BC20", VA = "0xC4BC20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public Mesh coneMesh
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xC4BC28", Offset = "0xC4BC28", VA = "0xC4BC28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0xC4BC30", Offset = "0xC4BC30", VA = "0xC4BC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public bool visible
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0xC4BC38", Offset = "0xC4BC38", VA = "0xC4BC38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xC4BC54", Offset = "0xC4BC54", VA = "0xC4BC54")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0xC4BC74", Offset = "0xC4BC74", VA = "0xC4BC74")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0xC4BC90", Offset = "0xC4BC90", VA = "0xC4BC90")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public int sortingOrder
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0xC4BCAC", Offset = "0xC4BCAC", VA = "0xC4BCAC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xC4BCC8", Offset = "0xC4BCC8", VA = "0xC4BCC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0xC4C6B4", Offset = "0xC4C6B4", VA = "0xC4C6B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000030")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0xC4DF10", Offset = "0xC4DF10", VA = "0xC4DF10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000031")]
		private bool isClippingPlaneEnabled
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0xC4DF4C", Offset = "0xC4DF4C", VA = "0xC4DF4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000032")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0xC4DF80", Offset = "0xC4DF80", VA = "0xC4DF80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xC4BCE4", Offset = "0xC4BCE4", VA = "0xC4BCE4")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xC4BDEC", Offset = "0xC4BDEC", VA = "0xC4BDEC")]
		[IteratorStateMachine(typeof(<CoUpdateFadeOut>d__26))]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xC4BE7C", Offset = "0xC4BE7C", VA = "0xC4BE7C")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xC4C094", Offset = "0xC4C094", VA = "0xC4C094")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xC4C354", Offset = "0xC4C354", VA = "0xC4C354")]
		private void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xC4C3FC", Offset = "0xC4C3FC", VA = "0xC4C3FC")]
		private void Start()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xC4C498", Offset = "0xC4C498", VA = "0xC4C498")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xC4C520", Offset = "0xC4C520", VA = "0xC4C520")]
		private static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xC4C5FC", Offset = "0xC4C5FC", VA = "0xC4C5FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xC4C6BC", Offset = "0xC4C6BC", VA = "0xC4C6BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xC4C77C", Offset = "0xC4C77C", VA = "0xC4C77C")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xC4CDE0", Offset = "0xC4CDE0", VA = "0xC4CDE0")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xC4DEB0", Offset = "0xC4DEB0", VA = "0xC4DEB0")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xC4CC24", Offset = "0xC4CC24", VA = "0xC4CC24")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xC4C1B4", Offset = "0xC4C1B4", VA = "0xC4C1B4")]
		private void SetMaterialProp(string name, float value)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xC4E4A8", Offset = "0xC4E4A8", VA = "0xC4E4A8")]
		private void SetMaterialProp(string name, Vector4 value)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xC4E5C0", Offset = "0xC4E5C0", VA = "0xC4E5C0")]
		private void SetMaterialProp(string name, Color value)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xC4E6D8", Offset = "0xC4E6D8", VA = "0xC4E6D8")]
		private void SetMaterialProp(string name, Matrix4x4 value)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xC4C0FC", Offset = "0xC4C0FC", VA = "0xC4C0FC")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xC4C29C", Offset = "0xC4C29C", VA = "0xC4C29C")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xC4E808", Offset = "0xC4E808", VA = "0xC4E808")]
		private void SendMaterialClippingPlaneProp()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xC4D98C", Offset = "0xC4D98C", VA = "0xC4D98C")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xC4E8B0", Offset = "0xC4E8B0", VA = "0xC4E8B0")]
		public void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xC4E984", Offset = "0xC4E984", VA = "0xC4E984")]
		public void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xC4EA24", Offset = "0xC4EA24", VA = "0xC4EA24")]
		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xC4ED20", Offset = "0xC4ED20", VA = "0xC4ED20")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xC4EDB0", Offset = "0xC4EDB0", VA = "0xC4EDB0")]
		private static bool IsEditorCamera(Camera cam)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xC4EA2C", Offset = "0xC4EA2C", VA = "0xC4EA2C")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xC4EDB8", Offset = "0xC4EDB8", VA = "0xC4EDB8")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x2C")]
		public RenderPipeline renderPipeline;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x30")]
		[Obsolete("Use 'renderingMode' instead")]
		public bool forceSinglePass;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x34")]
		public RenderingMode renderingMode;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader1Pass;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x40")]
		[HighlightNull]
		[SerializeField]
		[FormerlySerializedAs("beamShader")]
		[FormerlySerializedAs("BeamShader")]
		private Shader beamShader2Pass;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x48")]
		public int sharedMeshSides;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x4C")]
		public int sharedMeshSegments;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x50")]
		[Range(0.01f, 2f)]
		public float globalNoiseScale;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x60")]
		public string fadeOutCameraTag;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x68")]
		[HighlightNull]
		public TextAsset noise3DData;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x70")]
		public int noise3DSize;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x78")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x88")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x0")]
		private static Config m_Instance;

		[Token(Token = "0x17000035")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0xC4CAB0", Offset = "0xC4CAB0", VA = "0xC4CAB0")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000036")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0xC4D02C", Offset = "0xC4D02C", VA = "0xC4D02C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000037")]
		public Shader beamShader
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0xC4EE88", Offset = "0xC4EE88", VA = "0xC4EE88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0xC4EEA4", Offset = "0xC4EEA4", VA = "0xC4EEA4")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000039")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0xC4C020", Offset = "0xC4C020", VA = "0xC4C020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public static Config Instance
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xC4BF54", Offset = "0xC4BF54", VA = "0xC4BF54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xC4EEB0", Offset = "0xC4EEB0", VA = "0xC4EEB0")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xC4EF3C", Offset = "0xC4EF3C", VA = "0xC4EF3C")]
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xC4EF64", Offset = "0xC4EF64", VA = "0xC4EF64")]
		public static void OnRenderPipelineChanged(RenderPipeline pipeline)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xC4EFB4", Offset = "0xC4EFB4", VA = "0xC4EFB4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xC4F1DC", Offset = "0xC4F1DC", VA = "0xC4F1DC")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xC4F37C", Offset = "0xC4F37C", VA = "0xC4F37C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xC4F3A8", Offset = "0xC4F3A8", VA = "0xC4F3A8")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xC4F3E0", Offset = "0xC4F3E0", VA = "0xC4F3E0")]
		public Config()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public static class Consts
	{
		[Token(Token = "0x400019F")]
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		[Token(Token = "0x40001A0")]
		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		[Token(Token = "0x40001A1")]
		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		[Token(Token = "0x40001A2")]
		public const string HelpUrlDynamicOcclusion = "http://saladgamer.com/vlb-doc/comp-dynocclusion/";

		[Token(Token = "0x40001A3")]
		public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

		[Token(Token = "0x40001A4")]
		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly bool ProceduralObjectsVisibleInEditor;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x4")]
		public static readonly Color FlatColor;

		[Token(Token = "0x40001A7")]
		public const ColorMode ColorModeDefault = ColorMode.Flat;

		[Token(Token = "0x40001A8")]
		public const float IntensityDefault = 1f;

		[Token(Token = "0x40001A9")]
		public const float IntensityMin = 0f;

		[Token(Token = "0x40001AA")]
		public const float IntensityMax = 8f;

		[Token(Token = "0x40001AB")]
		public const float SpotAngleDefault = 35f;

		[Token(Token = "0x40001AC")]
		public const float SpotAngleMin = 0.1f;

		[Token(Token = "0x40001AD")]
		public const float SpotAngleMax = 179.9f;

		[Token(Token = "0x40001AE")]
		public const float ConeRadiusStart = 0.1f;

		[Token(Token = "0x40001AF")]
		public const MeshType GeomMeshType = MeshType.Shared;

		[Token(Token = "0x40001B0")]
		public const int GeomSidesDefault = 18;

		[Token(Token = "0x40001B1")]
		public const int GeomSidesMin = 3;

		[Token(Token = "0x40001B2")]
		public const int GeomSidesMax = 256;

		[Token(Token = "0x40001B3")]
		public const int GeomSegmentsDefault = 5;

		[Token(Token = "0x40001B4")]
		public const int GeomSegmentsMin = 0;

		[Token(Token = "0x40001B5")]
		public const int GeomSegmentsMax = 64;

		[Token(Token = "0x40001B6")]
		public const bool GeomCap = false;

		[Token(Token = "0x40001B7")]
		public const float CapIntensityBoost = 39f;

		[Token(Token = "0x40001B8")]
		public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

		[Token(Token = "0x40001B9")]
		public const float AttenuationCustomBlending = 0.5f;

		[Token(Token = "0x40001BA")]
		public const float FallOffStart = 0f;

		[Token(Token = "0x40001BB")]
		public const float FallOffEnd = 3f;

		[Token(Token = "0x40001BC")]
		public const float FallOffDistancesMinThreshold = 0.01f;

		[Token(Token = "0x40001BD")]
		public const float DepthBlendDistance = 0f;

		[Token(Token = "0x40001BE")]
		public const float CameraClippingDistance = 0f;

		[Token(Token = "0x40001BF")]
		public const float FresnelPowMaxValue = 10f;

		[Token(Token = "0x40001C0")]
		public const float FresnelPow = 8f;

		[Token(Token = "0x40001C1")]
		public const float GlareFrontal = 0.5f;

		[Token(Token = "0x40001C2")]
		public const float GlareBehind = 0.5f;

		[Token(Token = "0x40001C3")]
		public const float NoiseIntensityMin = 0f;

		[Token(Token = "0x40001C4")]
		public const float NoiseIntensityMax = 1f;

		[Token(Token = "0x40001C5")]
		public const float NoiseIntensityDefault = 0.5f;

		[Token(Token = "0x40001C6")]
		public const float NoiseScaleMin = 0.01f;

		[Token(Token = "0x40001C7")]
		public const float NoiseScaleMax = 2f;

		[Token(Token = "0x40001C8")]
		public const float NoiseScaleDefault = 0.5f;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x14")]
		public static readonly Vector3 NoiseVelocityDefault;

		[Token(Token = "0x40001CA")]
		public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

		[Token(Token = "0x40001CB")]
		public const OccluderDimensions DynOcclusionDimensionsDefault = OccluderDimensions.Occluders3D;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x20")]
		public static readonly LayerMask DynOcclusionLayerMaskDefault;

		[Token(Token = "0x40001CD")]
		public const bool DynOcclusionConsiderTriggersDefault = false;

		[Token(Token = "0x40001CE")]
		public const float DynOcclusionMinOccluderAreaDefault = 0f;

		[Token(Token = "0x40001CF")]
		public const int DynOcclusionWaitFrameCountDefault = 3;

		[Token(Token = "0x40001D0")]
		public const float DynOcclusionMinSurfaceRatioDefault = 0.5f;

		[Token(Token = "0x40001D1")]
		public const float DynOcclusionMinSurfaceRatioMin = 50f;

		[Token(Token = "0x40001D2")]
		public const float DynOcclusionMinSurfaceRatioMax = 100f;

		[Token(Token = "0x40001D3")]
		public const float DynOcclusionMaxSurfaceDotDefault = 0.25f;

		[Token(Token = "0x40001D4")]
		public const float DynOcclusionMaxSurfaceAngleMin = 45f;

		[Token(Token = "0x40001D5")]
		public const float DynOcclusionMaxSurfaceAngleMax = 90f;

		[Token(Token = "0x40001D6")]
		public const PlaneAlignment DynOcclusionPlaneAlignmentDefault = PlaneAlignment.Surface;

		[Token(Token = "0x40001D7")]
		public const float DynOcclusionPlaneOffsetDefault = 0.1f;

		[Token(Token = "0x40001D8")]
		public const bool ConfigGeometryOverrideLayerDefault = true;

		[Token(Token = "0x40001D9")]
		public const int ConfigGeometryLayerIDDefault = 1;

		[Token(Token = "0x40001DA")]
		public const string ConfigGeometryTagDefault = "Untagged";

		[Token(Token = "0x40001DB")]
		public const string ConfigFadeOutCameraTagDefault = "MainCamera";

		[Token(Token = "0x40001DC")]
		public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

		[Token(Token = "0x40001DD")]
		public const RenderPipeline ConfigGeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

		[Token(Token = "0x40001DE")]
		public const RenderingMode ConfigGeometryRenderingModeDefault = RenderingMode.MultiPass;

		[Token(Token = "0x40001DF")]
		public const int ConfigNoise3DSizeDefault = 64;

		[Token(Token = "0x40001E0")]
		public const int ConfigSharedMeshSides = 24;

		[Token(Token = "0x40001E1")]
		public const int ConfigSharedMeshSegments = 5;

		[Token(Token = "0x1700003B")]
		public static HideFlags ProceduralObjectsHideFlags
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0xC4CA4C", Offset = "0xC4CA4C", VA = "0xC4CA4C")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x200004F")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion/")]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class DynamicOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000050")]
		public class HitResult
		{
			[Token(Token = "0x40001EF")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40001F0")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 normal;

			[Token(Token = "0x40001F1")]
			[FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x40001F2")]
			[FieldOffset(Offset = "0x30")]
			private Collider2D collider2D;

			[Token(Token = "0x40001F3")]
			[FieldOffset(Offset = "0x38")]
			private Collider collider3D;

			[Token(Token = "0x1700003E")]
			public bool hasCollider
			{
				[Token(Token = "0x60001C3")]
				[Address(RVA = "0xC50338", Offset = "0xC50338", VA = "0xC50338")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xC4FFBC", Offset = "0xC4FFBC", VA = "0xC4FFBC")]
			public HitResult(RaycastHit hit3D)
			{
			}

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xC500A0", Offset = "0xC500A0", VA = "0xC500A0")]
			public HitResult(RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x60001C2")]
			[Address(RVA = "0xC50028", Offset = "0xC50028", VA = "0xC50028")]
			public HitResult()
			{
			}
		}

		[Token(Token = "0x2000051")]
		private enum Direction
		{
			[Token(Token = "0x40001F5")]
			Up,
			[Token(Token = "0x40001F6")]
			Right,
			[Token(Token = "0x40001F7")]
			Down,
			[Token(Token = "0x40001F8")]
			Left
		}

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x18")]
		public OccluderDimensions dimensions;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x1C")]
		public LayerMask layerMask;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x20")]
		public bool considerTriggers;

		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x24")]
		public float minOccluderArea;

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x28")]
		public int waitFrameCount;

		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x2C")]
		public float minSurfaceRatio;

		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x30")]
		public float maxSurfaceDot;

		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x34")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x38")]
		public float planeOffset;

		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x40")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x48")]
		private int m_FrameCountToWait;

		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x4C")]
		private float m_RangeMultiplier;

		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x50")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x1700003C")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xC4FAE0", Offset = "0xC4FAE0", VA = "0xC4FAE0")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x1700003D")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xC4FAF4", Offset = "0xC4FAF4", VA = "0xC4FAF4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xC4F554", Offset = "0xC4F554", VA = "0xC4F554")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xC4F584", Offset = "0xC4F584", VA = "0xC4F584")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xC4F5D4", Offset = "0xC4F5D4", VA = "0xC4F5D4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xC4F60C", Offset = "0xC4F60C", VA = "0xC4F60C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xC4F6B8", Offset = "0xC4F6B8", VA = "0xC4F6B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xC4FA30", Offset = "0xC4FA30", VA = "0xC4FA30")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xC4FB38", Offset = "0xC4FB38", VA = "0xC4FB38")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xC4FB4C", Offset = "0xC4FB4C", VA = "0xC4FB4C")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xC4FD68", Offset = "0xC4FD68", VA = "0xC4FD68")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xC5010C", Offset = "0xC5010C", VA = "0xC5010C")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xC502B0", Offset = "0xC502B0", VA = "0xC502B0")]
		private bool IsHitValid(HitResult hit)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xC4F6EC", Offset = "0xC4F6EC", VA = "0xC4F6EC")]
		private void ProcessRaycasts()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xC503C8", Offset = "0xC503C8", VA = "0xC503C8")]
		private void SetHit(HitResult hit)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xC4F5F0", Offset = "0xC4F5F0", VA = "0xC4F5F0")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xC50464", Offset = "0xC50464", VA = "0xC50464")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xC504F4", Offset = "0xC504F4", VA = "0xC504F4")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xC50510", Offset = "0xC50510", VA = "0xC50510")]
		public DynamicOcclusion()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public enum ColorMode
	{
		[Token(Token = "0x40001FA")]
		Flat,
		[Token(Token = "0x40001FB")]
		Gradient
	}
	[Token(Token = "0x2000053")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x40001FD")]
		Linear,
		[Token(Token = "0x40001FE")]
		Quadratic,
		[Token(Token = "0x40001FF")]
		Blend
	}
	[Token(Token = "0x2000054")]
	public enum BlendingMode
	{
		[Token(Token = "0x4000201")]
		Additive,
		[Token(Token = "0x4000202")]
		SoftAdditive,
		[Token(Token = "0x4000203")]
		TraditionalTransparency
	}
	[Token(Token = "0x2000055")]
	public enum MeshType
	{
		[Token(Token = "0x4000205")]
		Shared,
		[Token(Token = "0x4000206")]
		Custom
	}
	[Token(Token = "0x2000056")]
	public enum RenderPipeline
	{
		[Token(Token = "0x4000208")]
		BuiltIn,
		[Token(Token = "0x4000209")]
		SRP_4_0_0_or_higher
	}
	[Token(Token = "0x2000057")]
	public enum RenderingMode
	{
		[Token(Token = "0x400020B")]
		MultiPass,
		[Token(Token = "0x400020C")]
		SinglePass,
		[Token(Token = "0x400020D")]
		GPUInstancing
	}
	[Token(Token = "0x2000058")]
	public enum RenderQueue
	{
		[Token(Token = "0x400020F")]
		Custom = 0,
		[Token(Token = "0x4000210")]
		Background = 1000,
		[Token(Token = "0x4000211")]
		Geometry = 2000,
		[Token(Token = "0x4000212")]
		AlphaTest = 2450,
		[Token(Token = "0x4000213")]
		GeometryLast = 2500,
		[Token(Token = "0x4000214")]
		Transparent = 3000,
		[Token(Token = "0x4000215")]
		Overlay = 4000
	}
	[Token(Token = "0x2000059")]
	public enum OccluderDimensions
	{
		[Token(Token = "0x4000217")]
		Occluders3D,
		[Token(Token = "0x4000218")]
		Occluders2D
	}
	[Token(Token = "0x200005A")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x400021A")]
		Surface,
		[Token(Token = "0x400021B")]
		Beam
	}
	[Token(Token = "0x200005B")]
	public enum FadeOutCameraMode
	{
		[Token(Token = "0x400021D")]
		MainCamera,
		[Token(Token = "0x400021E")]
		CustomObject
	}
	[Token(Token = "0x200005C")]
	public static class GlobalMesh
	{
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xC4D828", Offset = "0xC4D828", VA = "0xC4D828")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xC505A0", Offset = "0xC505A0", VA = "0xC505A0")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public static class GpuInstancing
	{
		[Token(Token = "0x4000221")]
		public const bool isSupported = true;

		[Token(Token = "0x1700003F")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0xC4DFB8", Offset = "0xC4DFB8", VA = "0xC4DFB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xC50654", Offset = "0xC50654", VA = "0xC50654")]
		public static void SetMaterialProperties(Material material, bool enableInstancing)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xC506C4", Offset = "0xC506C4", VA = "0xC506C4")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xC5081C", Offset = "0xC5081C", VA = "0xC5081C")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reason)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xC50954", Offset = "0xC50954", VA = "0xC50954")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x200005E")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xC50A10", Offset = "0xC50A10", VA = "0xC50A10")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class MaterialKeywordSRP
	{
		[Token(Token = "0x4000222")]
		public const string kKeyword = "VLB_SRP_API";

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xC50A18", Offset = "0xC50A18", VA = "0xC50A18")]
		public MaterialKeywordSRP()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public static class MaterialManager
	{
		[Token(Token = "0x2000061")]
		public enum BlendingMode
		{
			[Token(Token = "0x400022A")]
			Additive,
			[Token(Token = "0x400022B")]
			SoftAdditive,
			[Token(Token = "0x400022C")]
			TraditionalTransparency,
			[Token(Token = "0x400022D")]
			Count
		}

		[Token(Token = "0x2000062")]
		public enum Noise3D
		{
			[Token(Token = "0x400022F")]
			Off,
			[Token(Token = "0x4000230")]
			On,
			[Token(Token = "0x4000231")]
			Count
		}

		[Token(Token = "0x2000063")]
		public enum DepthBlend
		{
			[Token(Token = "0x4000233")]
			Off,
			[Token(Token = "0x4000234")]
			On,
			[Token(Token = "0x4000235")]
			Count
		}

		[Token(Token = "0x2000064")]
		public enum ColorGradient
		{
			[Token(Token = "0x4000237")]
			Off,
			[Token(Token = "0x4000238")]
			MatrixLow,
			[Token(Token = "0x4000239")]
			MatrixHigh,
			[Token(Token = "0x400023A")]
			Count
		}

		[Token(Token = "0x2000065")]
		public enum ClippingPlane
		{
			[Token(Token = "0x400023C")]
			Off,
			[Token(Token = "0x400023D")]
			On,
			[Token(Token = "0x400023E")]
			Count
		}

		[Token(Token = "0x2000066")]
		public class StaticProperties
		{
			[Token(Token = "0x400023F")]
			[FieldOffset(Offset = "0x10")]
			public BlendingMode blendingMode;

			[Token(Token = "0x4000240")]
			[FieldOffset(Offset = "0x14")]
			public Noise3D noise3D;

			[Token(Token = "0x4000241")]
			[FieldOffset(Offset = "0x18")]
			public DepthBlend depthBlend;

			[Token(Token = "0x4000242")]
			[FieldOffset(Offset = "0x1C")]
			public ColorGradient colorGradient;

			[Token(Token = "0x4000243")]
			[FieldOffset(Offset = "0x20")]
			public ClippingPlane clippingPlane;

			[Token(Token = "0x17000040")]
			public int materialID
			{
				[Token(Token = "0x60001D0")]
				[Address(RVA = "0xC50AA4", Offset = "0xC50AA4", VA = "0xC50AA4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60001D1")]
			[Address(RVA = "0xC4DFE4", Offset = "0xC4DFE4", VA = "0xC4DFE4")]
			public void ApplyToMaterial(Material mat)
			{
			}

			[Token(Token = "0x60001D2")]
			[Address(RVA = "0xC4DFDC", Offset = "0xC4DFDC", VA = "0xC4DFDC")]
			public StaticProperties()
			{
			}
		}

		[Token(Token = "0x2000067")]
		private class MaterialsGroup
		{
			[Token(Token = "0x4000244")]
			[FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x60001D3")]
			[Address(RVA = "0xC50A20", Offset = "0xC50A20", VA = "0xC50A20")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x20")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xC4CAB8", Offset = "0xC4CAB8", VA = "0xC4CAB8")]
		public static Material NewMaterial(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xC4E224", Offset = "0xC4E224", VA = "0xC4E224")]
		public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x2000068")]
	public static class MeshGenerator
	{
		[Token(Token = "0x4000245")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xC50C70", Offset = "0xC50C70", VA = "0xC50C70")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xC50C88", Offset = "0xC50C88", VA = "0xC50C88")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xC50CF8", Offset = "0xC50CF8", VA = "0xC50CF8")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xC4D03C", Offset = "0xC4D03C", VA = "0xC4D03C")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xC50D64", Offset = "0xC50D64", VA = "0xC50D64")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xC50D80", Offset = "0xC50D80", VA = "0xC50D80")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xC50DA8", Offset = "0xC50DA8", VA = "0xC50DA8")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xC50DFC", Offset = "0xC50DFC", VA = "0xC50DFC")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000069")]
	public static class Noise3D
	{
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x4000249")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x400024A")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x17000041")]
		public static bool isSupported
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0xC51E54", Offset = "0xC51E54", VA = "0xC51E54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xC51FB4", Offset = "0xC51FB4", VA = "0xC51FB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xC51F10", Offset = "0xC51F10", VA = "0xC51F10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xC5202C", Offset = "0xC5202C", VA = "0xC5202C")]
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xC52030", Offset = "0xC52030", VA = "0xC52030")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xC52198", Offset = "0xC52198", VA = "0xC52198")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x200006A")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-triggerzone/")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x400024D")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x20")]
		private Mesh m_Mesh;

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xC52480", Offset = "0xC52480", VA = "0xC52480")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xC52698", Offset = "0xC52698", VA = "0xC52698")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public static class Utils
	{
		[Token(Token = "0x200006C")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x4000252")]
			High = 64,
			[Token(Token = "0x4000253")]
			Low = 8,
			[Token(Token = "0x4000254")]
			Undef = 0
		}

		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x4000250")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xC526B0", Offset = "0xC526B0", VA = "0xC526B0")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x60001E5")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60001E7")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xC5279C", Offset = "0xC5279C", VA = "0xC5279C")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xC5286C", Offset = "0xC5286C", VA = "0xC5286C")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xC52870", Offset = "0xC52870", VA = "0xC52870")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xC52878", Offset = "0xC52878", VA = "0xC52878")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xC52884", Offset = "0xC52884", VA = "0xC52884")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xC52894", Offset = "0xC52894", VA = "0xC52894")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xC528A0", Offset = "0xC528A0", VA = "0xC528A0")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xC528A8", Offset = "0xC528A8", VA = "0xC528A8")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xC528F0", Offset = "0xC528F0", VA = "0xC528F0")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xC52980", Offset = "0xC52980", VA = "0xC52980")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xC52988", Offset = "0xC52988", VA = "0xC52988")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xC52D18", Offset = "0xC52D18", VA = "0xC52D18")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xC52E84", Offset = "0xC52E84", VA = "0xC52E84")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xC52ECC", Offset = "0xC52ECC", VA = "0xC52ECC")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xC52EEC", Offset = "0xC52EEC", VA = "0xC52EEC")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xC52F00", Offset = "0xC52F00", VA = "0xC52F00")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xC53014", Offset = "0xC53014", VA = "0xC53014")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xC530F8", Offset = "0xC530F8", VA = "0xC530F8")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xC52FB8", Offset = "0xC52FB8", VA = "0xC52FB8")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xC5310C", Offset = "0xC5310C", VA = "0xC5310C")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xC5317C", Offset = "0xC5317C", VA = "0xC5317C")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xC53180", Offset = "0xC53180", VA = "0xC53180")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x200006D")]
	public static class Version
	{
		[Token(Token = "0x4000255")]
		public const int Current = 1640;
	}
	[Token(Token = "0x200006E")]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dustparticles/")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x200006F")]
		public enum Direction
		{
			[Token(Token = "0x4000266")]
			Beam,
			[Token(Token = "0x4000267")]
			Random
		}

		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float alpha;

		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0.0001f, 0.1f)]
		public float size;

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x20")]
		public Direction direction;

		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x28")]
		public float density;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float spawnMaxDistance;

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x30")]
		public bool cullingEnabled;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x34")]
		public float cullingMaxDistance;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x40")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x48")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x50")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x17000044")]
		public bool isCulled
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0xC53184", Offset = "0xC53184", VA = "0xC53184")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0xC5318C", Offset = "0xC5318C", VA = "0xC5318C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0xC53198", Offset = "0xC53198", VA = "0xC53198")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0xC531F4", Offset = "0xC531F4", VA = "0xC531F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000047")]
		public int particlesMaxCount
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0xC53278", Offset = "0xC53278", VA = "0xC53278")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000048")]
		public Camera mainCamera
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0xC53314", Offset = "0xC53314", VA = "0xC53314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xC53518", Offset = "0xC53518", VA = "0xC53518")]
		private void Start()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xC53578", Offset = "0xC53578", VA = "0xC53578")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xC537AC", Offset = "0xC537AC", VA = "0xC537AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xC53700", Offset = "0xC53700", VA = "0xC53700")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xC53D34", Offset = "0xC53D34", VA = "0xC53D34")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xC53DC4", Offset = "0xC53DC4", VA = "0xC53DC4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xC53E64", Offset = "0xC53E64", VA = "0xC53E64")]
		private void Update()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xC537B0", Offset = "0xC537B0", VA = "0xC537B0")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xC53E8C", Offset = "0xC53E8C", VA = "0xC53E8C")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xC541FC", Offset = "0xC541FC", VA = "0xC541FC")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[SelectionBase]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class <CoPlaytimeUpdate>d__125 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000296")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000297")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000298")]
			[FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x17000064")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600024E")]
				[Address(RVA = "0xC55868", Offset = "0xC55868", VA = "0xC55868", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000250")]
				[Address(RVA = "0xC558B0", Offset = "0xC558B0", VA = "0xC558B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600024B")]
			[Address(RVA = "0xC55400", Offset = "0xC55400", VA = "0xC55400")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__125(int <>1__state)
			{
			}

			[Token(Token = "0x600024C")]
			[Address(RVA = "0xC557E4", Offset = "0xC557E4", VA = "0xC557E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600024D")]
			[Address(RVA = "0xC557E8", Offset = "0xC557E8", VA = "0xC557E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600024F")]
			[Address(RVA = "0xC55870", Offset = "0xC55870", VA = "0xC55870", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x20")]
		[ColorUsage(true, true)]
		[FormerlySerializedAs("colorValue")]
		public Color color;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x3C")]
		[FormerlySerializedAs("alphaInside")]
		[Range(0f, 8f)]
		public float intensityInside;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 8f)]
		[FormerlySerializedAs("alpha")]
		[FormerlySerializedAs("alphaOutside")]
		public float intensityOutside;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("angleFromLight")]
		public bool spotAngleFromLight;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0.1f, 179.9f)]
		public float spotAngle;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x50")]
		[FormerlySerializedAs("radiusStart")]
		public float coneRadiusStart;

		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x54")]
		public MeshType geomMeshType;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x58")]
		[FormerlySerializedAs("geomSides")]
		public int geomCustomSides;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x5C")]
		public int geomCustomSegments;

		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x60")]
		public bool geomCap;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x64")]
		public float capIntensityBoost;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x68")]
		[FormerlySerializedAs("fadeEndFromLight")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x6C")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		public float attenuationCustomBlending;

		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x74")]
		[FormerlySerializedAs("fadeStart")]
		public float fallOffStart;

		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x78")]
		[FormerlySerializedAs("fadeEnd")]
		public float fallOffEnd;

		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x7C")]
		public float depthBlendDistance;

		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x80")]
		public float cameraClippingDistance;

		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float glareFrontal;

		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		public float glareBehind;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x8C")]
		[Obsolete("Use 'glareFrontal' instead")]
		public float boostDistanceInside;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x90")]
		[Obsolete("This property has been merged with 'fresnelPow'")]
		public float fresnelPowInside;

		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x94")]
		[FormerlySerializedAs("fresnelPowOutside")]
		public float fresnelPow;

		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x98")]
		public bool noiseEnabled;

		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x9C")]
		[Range(0f, 1f)]
		public float noiseIntensity;

		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0xA0")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0xA4")]
		[Range(0.01f, 2f)]
		public float noiseScaleLocal;

		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0xA8")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0xAC")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0xB8")]
		public float fadeOutBegin;

		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0xBC")]
		public float fadeOutEnd;

		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0xC0")]
		private Plane m_PlaneWS;

		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0xD4")]
		[FormerlySerializedAs("trackChangesDuringPlaytime")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0xE8")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0xF0")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0xF8")]
		private Light _CachedLight;

		[Token(Token = "0x17000049")]
		[Obsolete("Use 'intensitySimple' or 'intensityInside' instead")]
		public float alphaInside
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0xC5428C", Offset = "0xC5428C", VA = "0xC5428C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000210")]
			[Address(RVA = "0xC54294", Offset = "0xC54294", VA = "0xC54294")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		[Obsolete("Use 'intensitySimple' or 'intensityOutside' instead")]
		public float alphaOutside
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0xC5429C", Offset = "0xC5429C", VA = "0xC5429C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000212")]
			[Address(RVA = "0xC542A4", Offset = "0xC542A4", VA = "0xC542A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public float intensityGlobal
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0xC542AC", Offset = "0xC542AC", VA = "0xC542AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000214")]
			[Address(RVA = "0xC542B4", Offset = "0xC542B4", VA = "0xC542B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public float coneAngle
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0xC54030", Offset = "0xC54030", VA = "0xC54030")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004D")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0xC52660", Offset = "0xC52660", VA = "0xC52660")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004E")]
		public float coneVolume
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0xC542BC", Offset = "0xC542BC", VA = "0xC542BC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004F")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0xC54318", Offset = "0xC54318", VA = "0xC54318")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000050")]
		public int geomSides
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0xC54378", Offset = "0xC54378", VA = "0xC54378")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600021A")]
			[Address(RVA = "0xC543B0", Offset = "0xC543B0", VA = "0xC543B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public int geomSegments
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0xC5442C", Offset = "0xC5442C", VA = "0xC5442C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600021C")]
			[Address(RVA = "0xC54464", Offset = "0xC54464", VA = "0xC54464")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		[Obsolete("Use 'fallOffEndFromLight' instead")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x600021D")]
			[Address(RVA = "0xC544E0", Offset = "0xC544E0", VA = "0xC544E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600021E")]
			[Address(RVA = "0xC544E8", Offset = "0xC544E8", VA = "0xC544E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0xC544F4", Offset = "0xC544F4", VA = "0xC544F4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000054")]
		[Obsolete("Use 'fallOffStart' instead")]
		public float fadeStart
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0xC5451C", Offset = "0xC5451C", VA = "0xC5451C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0xC54524", Offset = "0xC54524", VA = "0xC54524")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		[Obsolete("Use 'fallOffEnd' instead")]
		public float fadeEnd
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0xC5452C", Offset = "0xC5452C", VA = "0xC5452C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0xC54534", Offset = "0xC54534", VA = "0xC54534")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0xC5453C", Offset = "0xC5453C", VA = "0xC5453C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0xC5454C", Offset = "0xC5454C", VA = "0xC5454C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000226")]
			[Address(RVA = "0xC54554", Offset = "0xC54554", VA = "0xC54554")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public string sortingLayerName
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0xC545EC", Offset = "0xC545EC", VA = "0xC545EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000228")]
			[Address(RVA = "0xC545F8", Offset = "0xC545F8", VA = "0xC545F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public int sortingOrder
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0xC5461C", Offset = "0xC5461C", VA = "0xC5461C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600022A")]
			[Address(RVA = "0xC54624", Offset = "0xC54624", VA = "0xC54624")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0xC546BC", Offset = "0xC546BC", VA = "0xC546BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022C")]
			[Address(RVA = "0xC546C4", Offset = "0xC546C4", VA = "0xC546C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0xC54718", Offset = "0xC54718", VA = "0xC54718")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		public bool hasGeometry
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0xC5408C", Offset = "0xC5408C", VA = "0xC5408C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		public Bounds bounds
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0xC540EC", Offset = "0xC540EC", VA = "0xC540EC")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x1700005E")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0xC54920", Offset = "0xC54920", VA = "0xC54920")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005F")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0xC549F8", Offset = "0xC549F8", VA = "0xC549F8")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000235")]
			[Address(RVA = "0xC54A00", Offset = "0xC54A00", VA = "0xC54A00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public string meshStats
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0xC54A08", Offset = "0xC54A08", VA = "0xC54A08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public int meshVerticesCount
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0xC54BA8", Offset = "0xC54BA8", VA = "0xC54BA8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000062")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0xC54C60", Offset = "0xC54C60", VA = "0xC54C60")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000063")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0xC54D34", Offset = "0xC54D34", VA = "0xC54D34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xC54728", Offset = "0xC54728", VA = "0xC54728")]
		public void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xC547D8", Offset = "0xC547D8", VA = "0xC547D8")]
		public void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xC54854", Offset = "0xC54854", VA = "0xC54854")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xC54E18", Offset = "0xC54E18", VA = "0xC54E18")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xC54E6C", Offset = "0xC54E6C", VA = "0xC54E6C")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xC54FF4", Offset = "0xC54FF4", VA = "0xC54FF4")]
		[Obsolete("Use 'GenerateGeometry()' instead")]
		public void Generate()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xC55000", Offset = "0xC55000", VA = "0xC55000", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xC55204", Offset = "0xC55204", VA = "0xC55204", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xC5528C", Offset = "0xC5528C", VA = "0xC5528C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xC55298", Offset = "0xC55298", VA = "0xC55298")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xC55318", Offset = "0xC55318", VA = "0xC55318")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xC546D0", Offset = "0xC546D0", VA = "0xC546D0")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xC55398", Offset = "0xC55398", VA = "0xC55398")]
		[IteratorStateMachine(typeof(<CoPlaytimeUpdate>d__125))]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xC55428", Offset = "0xC55428", VA = "0xC55428")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xC5542C", Offset = "0xC5542C", VA = "0xC5542C")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xC554CC", Offset = "0xC554CC", VA = "0xC554CC")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xC555BC", Offset = "0xC555BC", VA = "0xC555BC")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xC551E0", Offset = "0xC551E0", VA = "0xC551E0")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xC55104", Offset = "0xC55104", VA = "0xC55104")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xC556D8", Offset = "0xC556D8", VA = "0xC556D8")]
		public VolumetricLightBeam()
		{
		}
	}
}
