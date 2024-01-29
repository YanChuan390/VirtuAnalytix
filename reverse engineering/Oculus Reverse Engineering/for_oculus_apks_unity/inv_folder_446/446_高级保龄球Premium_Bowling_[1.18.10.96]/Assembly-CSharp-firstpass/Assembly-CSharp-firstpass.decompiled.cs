using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
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
	[Address(RVA = "0x1A2ACCC", Offset = "0x1A2ACCC", VA = "0x1A2ACCC")]
	public void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1A2AE8C", Offset = "0x1A2AE8C", VA = "0x1A2AE8C", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1A2B198", Offset = "0x1A2B198", VA = "0x1A2B198")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000003")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1A2B1A0", Offset = "0x1A2B1A0", VA = "0x1A2B1A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1A2B27C", Offset = "0x1A2B27C", VA = "0x1A2B27C")]
	public EventSystemChecker()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000004")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x200005F")]
		public enum Mode
		{
			[Token(Token = "0x40002D8")]
			Trigger,
			[Token(Token = "0x40002D9")]
			Replace,
			[Token(Token = "0x40002DA")]
			Activate,
			[Token(Token = "0x40002DB")]
			Enable,
			[Token(Token = "0x40002DC")]
			Animate,
			[Token(Token = "0x40002DD")]
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
		[Address(RVA = "0x1E7E710", Offset = "0x1E7E710", VA = "0x1E7E710")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x1E7EB78", Offset = "0x1E7EB78", VA = "0x1E7EB78")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1E7EB7C", Offset = "0x1E7EB7C", VA = "0x1E7EB7C")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000060")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x40002DE")]
			[FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x40002DF")]
			[FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x600020D")]
			[Address(RVA = "0x1E7F5C8", Offset = "0x1E7F5C8", VA = "0x1E7F5C8")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000061")]
		public class ReplacementList
		{
			[Token(Token = "0x40002E0")]
			[FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x600020E")]
			[Address(RVA = "0x1E7F5D0", Offset = "0x1E7F5D0", VA = "0x1E7F5D0")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1E7EB94", Offset = "0x1E7EB94", VA = "0x1E7EB94")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1E7F5C0", Offset = "0x1E7F5C0", VA = "0x1E7F5C0")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000062")]
		public class Vector3andSpace
		{
			[Token(Token = "0x40002E1")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x40002E2")]
			[FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x600020F")]
			[Address(RVA = "0x1E7F7AC", Offset = "0x1E7F7AC", VA = "0x1E7F7AC")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1E7F63C", Offset = "0x1E7F63C", VA = "0x1E7F63C")]
		private void Start()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1E7F664", Offset = "0x1E7F664", VA = "0x1E7F664")]
		private void Update()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1E7F7A4", Offset = "0x1E7F7A4", VA = "0x1E7F7A4")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class CameraRefocus
	{
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1E7F7BC", Offset = "0x1E7F7BC", VA = "0x1E7F7BC")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1E7F830", Offset = "0x1E7F830", VA = "0x1E7F830")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1E7F838", Offset = "0x1E7F838", VA = "0x1E7F838")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1E7F840", Offset = "0x1E7F840", VA = "0x1E7F840")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1E7F9A0", Offset = "0x1E7F9A0", VA = "0x1E7F9A0")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	public class CurveControlledBob
	{
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1E7F9F4", Offset = "0x1E7F9F4", VA = "0x1E7F9F4")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1E7FA98", Offset = "0x1E7FA98", VA = "0x1E7FA98")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1E7FBB8", Offset = "0x1E7FBB8", VA = "0x1E7FBB8")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x2000063")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3CD70", Offset = "0xB3CD70")]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002E3")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002E4")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002E5")]
			[FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x40002E6")]
			[FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x40002E7")]
			[FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x40002E8")]
			[FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x40002E9")]
			[FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x17000015")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000213")]
				[Address(RVA = "0x1E80544", Offset = "0x1E80544", VA = "0x1E80544", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000016")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000215")]
				[Address(RVA = "0x1E805AC", Offset = "0x1E805AC", VA = "0x1E805AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000210")]
			[Address(RVA = "0x1E802B4", Offset = "0x1E802B4", VA = "0x1E802B4")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000211")]
			[Address(RVA = "0x1E802E8", Offset = "0x1E802E8", VA = "0x1E802E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000212")]
			[Address(RVA = "0x1E802EC", Offset = "0x1E802EC", VA = "0x1E802EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000214")]
			[Address(RVA = "0x1E8054C", Offset = "0x1E8054C", VA = "0x1E8054C", Slot = "8")]
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
		[FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1E7FE04", Offset = "0x1E7FE04", VA = "0x1E7FE04")]
		private void Update()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1E80228", Offset = "0x1E80228", VA = "0x1E80228")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3D4F0", Offset = "0xB3D4F0")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1E80178", Offset = "0x1E80178", VA = "0x1E80178")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1E802E0", Offset = "0x1E802E0", VA = "0x1E802E0")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1E805B4", Offset = "0x1E805B4", VA = "0x1E805B4")]
		private void Start()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1E805E8", Offset = "0x1E805E8", VA = "0x1E805E8")]
		private void Update()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1E8085C", Offset = "0x1E8085C", VA = "0x1E8085C")]
		public DynamicShadowSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public class FOVKick
	{
		[Token(Token = "0x2000064")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3CD80", Offset = "0xB3CD80")]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002EA")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002EB")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002EC")]
			[FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40002ED")]
			[FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000017")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000219")]
				[Address(RVA = "0x1E80E94", Offset = "0x1E80E94", VA = "0x1E80E94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000018")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600021B")]
				[Address(RVA = "0x1E80EFC", Offset = "0x1E80EFC", VA = "0x1E80EFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000216")]
			[Address(RVA = "0x1E80A40", Offset = "0x1E80A40", VA = "0x1E80A40")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000217")]
			[Address(RVA = "0x1E80D24", Offset = "0x1E80D24", VA = "0x1E80D24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000218")]
			[Address(RVA = "0x1E80D28", Offset = "0x1E80D28", VA = "0x1E80D28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600021A")]
			[Address(RVA = "0x1E80E9C", Offset = "0x1E80E9C", VA = "0x1E80E9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000065")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3CD90", Offset = "0xB3CD90")]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002EE")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002EF")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002F0")]
			[FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40002F1")]
			[FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000019")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600021F")]
				[Address(RVA = "0x1E80CB4", Offset = "0x1E80CB4", VA = "0x1E80CB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000221")]
				[Address(RVA = "0x1E80D1C", Offset = "0x1E80D1C", VA = "0x1E80D1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600021C")]
			[Address(RVA = "0x1E80AE8", Offset = "0x1E80AE8", VA = "0x1E80AE8")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0x1E80B30", Offset = "0x1E80B30", VA = "0x1E80B30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600021E")]
			[Address(RVA = "0x1E80B34", Offset = "0x1E80B34", VA = "0x1E80B34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0x1E80CBC", Offset = "0x1E80CBC", VA = "0x1E80CBC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1E80890", Offset = "0x1E80890", VA = "0x1E80890")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1E808DC", Offset = "0x1E808DC", VA = "0x1E808DC")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1E809BC", Offset = "0x1E809BC", VA = "0x1E809BC")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1E809C4", Offset = "0x1E809C4", VA = "0x1E809C4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3D554", Offset = "0xB3D554")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1E80A6C", Offset = "0x1E80A6C", VA = "0x1E80A6C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3D5B8", Offset = "0xB3D5B8")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1E80B14", Offset = "0x1E80B14", VA = "0x1E80B14")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3B5E0", Offset = "0xB3B5E0")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x4000032")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x4000036")]
		private const string display = "{0} FPS";

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1E80F04", Offset = "0x1E80F04", VA = "0x1E80F04")]
		private void Start()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1E80F78", Offset = "0x1E80F78", VA = "0x1E80F78")]
		private void Update()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1E8105C", Offset = "0x1E8105C", VA = "0x1E8105C")]
		public FPSCounter()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1E81064", Offset = "0x1E81064", VA = "0x1E81064")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1E81144", Offset = "0x1E81144", VA = "0x1E81144")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000E")]
	public class LerpControlledBob
	{
		[Token(Token = "0x2000066")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3CDA0", Offset = "0xB3CDA0")]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002F2")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002F3")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002F4")]
			[FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x40002F5")]
			[FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x1700001B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000225")]
				[Address(RVA = "0x1E81458", Offset = "0x1E81458", VA = "0x1E81458", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000227")]
				[Address(RVA = "0x1E814C0", Offset = "0x1E814C0", VA = "0x1E814C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x1E81228", Offset = "0x1E81228", VA = "0x1E81228")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x1E8125C", Offset = "0x1E8125C", VA = "0x1E8125C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0x1E81260", Offset = "0x1E81260", VA = "0x1E81260", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000226")]
			[Address(RVA = "0x1E81460", Offset = "0x1E81460", VA = "0x1E81460", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1E811A4", Offset = "0x1E811A4", VA = "0x1E811A4")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1E811AC", Offset = "0x1E811AC", VA = "0x1E811AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3D61C", Offset = "0xB3D61C")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1E81254", Offset = "0x1E81254", VA = "0x1E81254")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x2000067")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3CDB0", Offset = "0xB3CDB0")]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002F6")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002F7")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002F8")]
			[FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x40002F9")]
			[FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x1700001D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600022B")]
				[Address(RVA = "0x1E818F4", Offset = "0x1E818F4", VA = "0x1E818F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600022D")]
				[Address(RVA = "0x1E8195C", Offset = "0x1E8195C", VA = "0x1E8195C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000228")]
			[Address(RVA = "0x1E81680", Offset = "0x1E81680", VA = "0x1E81680")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0x1E816B4", Offset = "0x1E816B4", VA = "0x1E816B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0x1E816B8", Offset = "0x1E816B8", VA = "0x1E816B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0x1E818FC", Offset = "0x1E818FC", VA = "0x1E818FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1E814C8", Offset = "0x1E814C8", VA = "0x1E814C8")]
		private void Start()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1E815C8", Offset = "0x1E815C8", VA = "0x1E815C8")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1E815F4", Offset = "0x1E815F4", VA = "0x1E815F4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3D680", Offset = "0xB3D680")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1E816AC", Offset = "0x1E816AC", VA = "0x1E816AC")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x2000068")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3CDC0", Offset = "0xB3CDC0")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002FA")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002FB")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002FC")]
			[FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x40002FD")]
			[FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x40002FE")]
			[FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x1700001F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000231")]
				[Address(RVA = "0x1E81D8C", Offset = "0x1E81D8C", VA = "0x1E81D8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000020")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000233")]
				[Address(RVA = "0x1E81DF4", Offset = "0x1E81DF4", VA = "0x1E81DF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600022E")]
			[Address(RVA = "0x1E819E0", Offset = "0x1E819E0", VA = "0x1E819E0")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600022F")]
			[Address(RVA = "0x1E81A2C", Offset = "0x1E81A2C", VA = "0x1E81A2C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000230")]
			[Address(RVA = "0x1E81A30", Offset = "0x1E81A30", VA = "0x1E81A30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000232")]
			[Address(RVA = "0x1E81D94", Offset = "0x1E81D94", VA = "0x1E81D94", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1E81964", Offset = "0x1E81964", VA = "0x1E81964")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3D6E4", Offset = "0xB3D6E4")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1E81A0C", Offset = "0x1E81A0C", VA = "0x1E81A0C")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1E81A18", Offset = "0x1E81A18", VA = "0x1E81A18")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x2000069")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x4000300")]
			Standalone,
			[Token(Token = "0x4000301")]
			Mobile
		}

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1E81DFC", Offset = "0x1E81DFC", VA = "0x1E81DFC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1E81E00", Offset = "0x1E81E00", VA = "0x1E81E00")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1E81E1C", Offset = "0x1E81E1C", VA = "0x1E81E1C")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1E82178", Offset = "0x1E82178", VA = "0x1E82178")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1E82208", Offset = "0x1E82208", VA = "0x1E82208")]
		private void Start()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1E82244", Offset = "0x1E82244", VA = "0x1E82244")]
		private void Update()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1E825C4", Offset = "0x1E825C4", VA = "0x1E825C4")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1E82684", Offset = "0x1E82684", VA = "0x1E82684")]
		private void Start()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1E82688", Offset = "0x1E82688", VA = "0x1E82688")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1E829B4", Offset = "0x1E829B4", VA = "0x1E829B4")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x200006A")]
		public enum Action
		{
			[Token(Token = "0x4000303")]
			Activate,
			[Token(Token = "0x4000304")]
			Deactivate,
			[Token(Token = "0x4000305")]
			Destroy,
			[Token(Token = "0x4000306")]
			ReloadLevel,
			[Token(Token = "0x4000307")]
			Call
		}

		[Serializable]
		[Token(Token = "0x200006B")]
		public class Entry
		{
			[Token(Token = "0x4000308")]
			[FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x4000309")]
			[FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x400030A")]
			[FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x6000234")]
			[Address(RVA = "0x1E83170", Offset = "0x1E83170", VA = "0x1E83170")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200006C")]
		public class Entries
		{
			[Token(Token = "0x400030B")]
			[FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x6000235")]
			[Address(RVA = "0x1E82D60", Offset = "0x1E82D60", VA = "0x1E82D60")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x200006D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3CDD0", Offset = "0xB3CDD0")]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400030C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400030D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400030E")]
			[FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000021")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000239")]
				[Address(RVA = "0x1E82E40", Offset = "0x1E82E40", VA = "0x1E82E40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000022")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600023B")]
				[Address(RVA = "0x1E82EA8", Offset = "0x1E82EA8", VA = "0x1E82EA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000236")]
			[Address(RVA = "0x1E82C68", Offset = "0x1E82C68", VA = "0x1E82C68")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000237")]
			[Address(RVA = "0x1E82D68", Offset = "0x1E82D68", VA = "0x1E82D68", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000238")]
			[Address(RVA = "0x1E82D6C", Offset = "0x1E82D6C", VA = "0x1E82D6C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600023A")]
			[Address(RVA = "0x1E82E48", Offset = "0x1E82E48", VA = "0x1E82E48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200006E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3CDE0", Offset = "0xB3CDE0")]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400030F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000310")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000311")]
			[FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000023")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600023F")]
				[Address(RVA = "0x1E82F88", Offset = "0x1E82F88", VA = "0x1E82F88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000024")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000241")]
				[Address(RVA = "0x1E82FF0", Offset = "0x1E82FF0", VA = "0x1E82FF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600023C")]
			[Address(RVA = "0x1E82C94", Offset = "0x1E82C94", VA = "0x1E82C94")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600023D")]
			[Address(RVA = "0x1E82EB0", Offset = "0x1E82EB0", VA = "0x1E82EB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600023E")]
			[Address(RVA = "0x1E82EB4", Offset = "0x1E82EB4", VA = "0x1E82EB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000240")]
			[Address(RVA = "0x1E82F90", Offset = "0x1E82F90", VA = "0x1E82F90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200006F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3CDF0", Offset = "0xB3CDF0")]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000312")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000313")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000314")]
			[FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000025")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000245")]
				[Address(RVA = "0x1E83100", Offset = "0x1E83100", VA = "0x1E83100", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000026")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000247")]
				[Address(RVA = "0x1E83168", Offset = "0x1E83168", VA = "0x1E83168", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000242")]
			[Address(RVA = "0x1E82CC0", Offset = "0x1E82CC0", VA = "0x1E82CC0")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000243")]
			[Address(RVA = "0x1E82FF8", Offset = "0x1E82FF8", VA = "0x1E82FF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000244")]
			[Address(RVA = "0x1E82FFC", Offset = "0x1E82FFC", VA = "0x1E82FFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000246")]
			[Address(RVA = "0x1E83108", Offset = "0x1E83108", VA = "0x1E83108", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1E829C8", Offset = "0x1E829C8", VA = "0x1E829C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1E82AF4", Offset = "0x1E82AF4", VA = "0x1E82AF4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3D748", Offset = "0xB3D748")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1E82B70", Offset = "0x1E82B70", VA = "0x1E82B70")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3D7AC", Offset = "0xB3D7AC")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1E82BEC", Offset = "0x1E82BEC", VA = "0x1E82BEC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3D810", Offset = "0xB3D810")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1E82CEC", Offset = "0x1E82CEC", VA = "0x1E82CEC")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1E83178", Offset = "0x1E83178", VA = "0x1E83178")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1E831D0", Offset = "0x1E831D0", VA = "0x1E831D0")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1E83270", Offset = "0x1E83270", VA = "0x1E83270")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000070")]
		public class WaypointList
		{
			[Token(Token = "0x4000315")]
			[FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x4000316")]
			[FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x6000248")]
			[Address(RVA = "0x1E840EC", Offset = "0x1E840EC", VA = "0x1E840EC")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x2000071")]
		public struct RoutePoint
		{
			[Token(Token = "0x4000317")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x4000318")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x6000249")]
			[Address(RVA = "0xC62460", Offset = "0xC62460", VA = "0xC62460")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3CEE0", Offset = "0xB3CEE0")]
		private float <Length>k__BackingField;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000001")]
		public float Length
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x1E83280", Offset = "0x1E83280", VA = "0x1E83280")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D874", Offset = "0xB3D874")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x1E83288", Offset = "0x1E83288", VA = "0x1E83288")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D884", Offset = "0xB3D884")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x1E83290", Offset = "0x1E83290", VA = "0x1E83290")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1E832AC", Offset = "0x1E832AC", VA = "0x1E832AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1E835FC", Offset = "0x1E835FC", VA = "0x1E835FC")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1E8370C", Offset = "0x1E8370C", VA = "0x1E8370C")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1E83A74", Offset = "0x1E83A74", VA = "0x1E83A74")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1E83308", Offset = "0x1E83308", VA = "0x1E83308")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1E83DDC", Offset = "0x1E83DDC", VA = "0x1E83DDC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1E84064", Offset = "0x1E84064", VA = "0x1E84064")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1E83DE4", Offset = "0x1E83DE4", VA = "0x1E83DE4")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1E8406C", Offset = "0x1E8406C", VA = "0x1E8406C")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x2000072")]
		public enum ProgressStyle
		{
			[Token(Token = "0x400031A")]
			SmoothAlongRoute,
			[Token(Token = "0x400031B")]
			PointToPoint
		}

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3CF60", Offset = "0xB3CF60")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3CF70", Offset = "0xB3CF70")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3CF80", Offset = "0xB3CF80")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000003")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x1E84158", Offset = "0x1E84158", VA = "0x1E84158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D894", Offset = "0xB3D894")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x1E8416C", Offset = "0x1E8416C", VA = "0x1E8416C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D8A4", Offset = "0xB3D8A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x1E84180", Offset = "0x1E84180", VA = "0x1E84180")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D8B4", Offset = "0xB3D8B4")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x1E84194", Offset = "0x1E84194", VA = "0x1E84194")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D8C4", Offset = "0xB3D8C4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x1E841A8", Offset = "0x1E841A8", VA = "0x1E841A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D8D4", Offset = "0xB3D8D4")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x1E841BC", Offset = "0x1E841BC", VA = "0x1E841BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D8E4", Offset = "0xB3D8E4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1E841D0", Offset = "0x1E841D0", VA = "0x1E841D0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1E842C4", Offset = "0x1E842C4", VA = "0x1E842C4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1E8439C", Offset = "0x1E8439C", VA = "0x1E8439C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1E84904", Offset = "0x1E84904", VA = "0x1E84904")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1E84ADC", Offset = "0x1E84ADC", VA = "0x1E84ADC")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000018")]
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1E88D20", Offset = "0x1E88D20", VA = "0x1E88D20")]
		private void Update()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1E88F64", Offset = "0x1E88F64", VA = "0x1E88F64")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x2000019")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3B654", Offset = "0xB3B654")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1E84AF8", Offset = "0x1E84AF8", VA = "0x1E84AF8")]
		public void Awake()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1E84B1C", Offset = "0x1E84B1C", VA = "0x1E84B1C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1E84B7C", Offset = "0x1E84B7C", VA = "0x1E84B7C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1E84BDC", Offset = "0x1E84BDC", VA = "0x1E84BDC")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3B6C8", Offset = "0xB3B6C8")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1E84BE4", Offset = "0x1E84BE4", VA = "0x1E84BE4")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class MeshContainer
	{
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1E84BEC", Offset = "0x1E84BEC", VA = "0x1E84BEC")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1E84C60", Offset = "0x1E84C60", VA = "0x1E84C60")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3B73C", Offset = "0xB3B73C")]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1E84CA4", Offset = "0x1E84CA4", VA = "0x1E84CA4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1E84D98", Offset = "0x1E84D98", VA = "0x1E84D98")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1E850AC", Offset = "0x1E850AC", VA = "0x1E850AC")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1E85160", Offset = "0x1E85160", VA = "0x1E85160")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1E85268", Offset = "0x1E85268", VA = "0x1E85268")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1E85B48", Offset = "0x1E85B48", VA = "0x1E85B48")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1E85BA8", Offset = "0x1E85BA8", VA = "0x1E85BA8")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1E85CA0", Offset = "0x1E85CA0", VA = "0x1E85CA0")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1E85D00", Offset = "0x1E85D00", VA = "0x1E85D00")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1E853E8", Offset = "0x1E853E8", VA = "0x1E853E8")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1E85D60", Offset = "0x1E85D60", VA = "0x1E85D60")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1E86260", Offset = "0x1E86260", VA = "0x1E86260")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1E85DC4", Offset = "0x1E85DC4", VA = "0x1E85DC4")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1E86498", Offset = "0x1E86498", VA = "0x1E86498")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1E8607C", Offset = "0x1E8607C", VA = "0x1E8607C")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1E864B8", Offset = "0x1E864B8", VA = "0x1E864B8")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3B7B0", Offset = "0xB3B7B0")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1E86534", Offset = "0x1E86534", VA = "0x1E86534")]
		public void Start()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1E86630", Offset = "0x1E86630", VA = "0x1E86630")]
		public void Update()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1E8687C", Offset = "0x1E8687C", VA = "0x1E8687C")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x200001E")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x2000073")]
		public enum WaterMode
		{
			[Token(Token = "0x400031D")]
			Simple,
			[Token(Token = "0x400031E")]
			Reflective,
			[Token(Token = "0x400031F")]
			Refractive
		}

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1E86884", Offset = "0x1E86884", VA = "0x1E86884")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1E883C4", Offset = "0x1E883C4", VA = "0x1E883C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1E886D0", Offset = "0x1E886D0", VA = "0x1E886D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1E87CE0", Offset = "0x1E87CE0", VA = "0x1E87CE0")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1E871D8", Offset = "0x1E871D8", VA = "0x1E871D8")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1E871C4", Offset = "0x1E871C4", VA = "0x1E871C4")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1E87070", Offset = "0x1E87070", VA = "0x1E87070")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1E881E0", Offset = "0x1E881E0", VA = "0x1E881E0")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1E87F3C", Offset = "0x1E87F3C", VA = "0x1E87F3C")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1E8895C", Offset = "0x1E8895C", VA = "0x1E8895C")]
		public Water()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public enum WaterQuality
	{
		[Token(Token = "0x4000097")]
		High = 2,
		[Token(Token = "0x4000098")]
		Medium = 1,
		[Token(Token = "0x4000099")]
		Low = 0
	}
	[Token(Token = "0x2000020")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1E88A50", Offset = "0x1E88A50", VA = "0x1E88A50")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1E88BD0", Offset = "0x1E88BD0", VA = "0x1E88BD0")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1E88C84", Offset = "0x1E88C84", VA = "0x1E88C84")]
		public void Update()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1E88D08", Offset = "0x1E88D08", VA = "0x1E88D08")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1E88F6C", Offset = "0x1E88F6C", VA = "0x1E88F6C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1E88F70", Offset = "0x1E88F70", VA = "0x1E88F70")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1E89140", Offset = "0x1E89140", VA = "0x1E89140")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1E89248", Offset = "0x1E89248", VA = "0x1E89248")]
		public WaterTile()
		{
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x2000022")]
	public enum AAMode
	{
		[Token(Token = "0x40000A0")]
		FXAA2,
		[Token(Token = "0x40000A1")]
		FXAA3Console,
		[Token(Token = "0x40000A2")]
		FXAA1PresetA,
		[Token(Token = "0x40000A3")]
		FXAA1PresetB,
		[Token(Token = "0x40000A4")]
		NFAA,
		[Token(Token = "0x40000A5")]
		SSAA,
		[Token(Token = "0x40000A6")]
		DLAA
	}
	[Token(Token = "0x2000023")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3B854", Offset = "0xB3B854")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3B854", Offset = "0xB3B854")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x1C")]
		public AAMode mode;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x20")]
		public bool showGeneratedNormals;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x24")]
		public float offsetScale;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x28")]
		public float blurRadius;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x2C")]
		public float edgeThresholdMin;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x30")]
		public float edgeThreshold;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x34")]
		public float edgeSharpness;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x38")]
		public bool dlaaSharp;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x40")]
		public Shader ssaaShader;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x48")]
		private Material ssaa;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x50")]
		public Shader dlaaShader;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x58")]
		private Material dlaa;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x60")]
		public Shader nfaaShader;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x68")]
		private Material nfaa;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x70")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x78")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x80")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x88")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x90")]
		public Shader shaderFXAAII;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x98")]
		private Material materialFXAAII;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0xA0")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0xA8")]
		private Material materialFXAAIII;

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1A32E6C", Offset = "0x1A32E6C", VA = "0x1A32E6C")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1A32ED0", Offset = "0x1A32ED0", VA = "0x1A32ED0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1A33044", Offset = "0x1A33044", VA = "0x1A33044")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1A3358C", Offset = "0x1A3358C", VA = "0x1A3358C")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3B8EC", Offset = "0xB3B8EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3B8EC", Offset = "0xB3B8EC")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x2000074")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x4000321")]
			Ghosting,
			[Token(Token = "0x4000322")]
			Anamorphic,
			[Token(Token = "0x4000323")]
			Combined
		}

		[Token(Token = "0x2000075")]
		public enum TweakMode
		{
			[Token(Token = "0x4000325")]
			Basic,
			[Token(Token = "0x4000326")]
			Complex
		}

		[Token(Token = "0x2000076")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x4000328")]
			Auto,
			[Token(Token = "0x4000329")]
			On,
			[Token(Token = "0x400032A")]
			Off
		}

		[Token(Token = "0x2000077")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x400032C")]
			Screen,
			[Token(Token = "0x400032D")]
			Add
		}

		[Token(Token = "0x2000078")]
		public enum BloomQuality
		{
			[Token(Token = "0x400032F")]
			Cheap,
			[Token(Token = "0x4000330")]
			High
		}

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x1C")]
		public TweakMode tweakMode;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x20")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x24")]
		public HDRBloomMode hdr;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x28")]
		private bool doHdr;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x2C")]
		public float sepBlurSpread;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x30")]
		public BloomQuality quality;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x34")]
		public float bloomIntensity;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x38")]
		public float bloomThreshold;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x3C")]
		public Color bloomThresholdColor;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x4C")]
		public int bloomBlurIterations;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x54")]
		public float flareRotation;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x58")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x5C")]
		public float hollyStretchWidth;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x60")]
		public float lensflareIntensity;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x64")]
		public float lensflareThreshold;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x68")]
		public float lensFlareSaturation;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x6C")]
		public Color flareColorA;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x7C")]
		public Color flareColorB;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x8C")]
		public Color flareColorC;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x9C")]
		public Color flareColorD;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0xB0")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0xB8")]
		public Shader lensFlareShader;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0xC0")]
		private Material lensFlareMaterial;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0xC8")]
		public Shader screenBlendShader;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0xD0")]
		private Material screenBlend;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0xD8")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0xE0")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0xE8")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0xF0")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1A335B0", Offset = "0x1A335B0", VA = "0x1A335B0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1A336A0", Offset = "0x1A336A0", VA = "0x1A336A0")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1A34A5C", Offset = "0x1A34A5C", VA = "0x1A34A5C")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1A3485C", Offset = "0x1A3485C", VA = "0x1A3485C")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1A34564", Offset = "0x1A34564", VA = "0x1A34564")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1A34480", Offset = "0x1A34480", VA = "0x1A34480")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1A34650", Offset = "0x1A34650", VA = "0x1A34650")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1A34B24", Offset = "0x1A34B24", VA = "0x1A34B24")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x40000DC")]
		Ghosting,
		[Token(Token = "0x40000DD")]
		Anamorphic,
		[Token(Token = "0x40000DE")]
		Combined
	}
	[Token(Token = "0x2000026")]
	public enum TweakMode34
	{
		[Token(Token = "0x40000E0")]
		Basic,
		[Token(Token = "0x40000E1")]
		Complex
	}
	[Token(Token = "0x2000027")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x40000E3")]
		Auto,
		[Token(Token = "0x40000E4")]
		On,
		[Token(Token = "0x40000E5")]
		Off
	}
	[Token(Token = "0x2000028")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x40000E7")]
		Screen,
		[Token(Token = "0x40000E8")]
		Add
	}
	[Token(Token = "0x2000029")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3B984", Offset = "0xB3B984")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3B984", Offset = "0xB3B984")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x1C")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x20")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x24")]
		public HDRBloomMode hdr;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x28")]
		private bool doHdr;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x2C")]
		public float sepBlurSpread;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x30")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x34")]
		public float bloomIntensity;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x38")]
		public float bloomThreshold;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x3C")]
		public int bloomBlurIterations;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x40")]
		public bool lensflares;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x44")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x48")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x4C")]
		public float hollyStretchWidth;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x50")]
		public float lensflareIntensity;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x54")]
		public float lensflareThreshold;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x58")]
		public Color flareColorA;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x68")]
		public Color flareColorB;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x78")]
		public Color flareColorC;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x88")]
		public Color flareColorD;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x98")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0xA0")]
		public Shader lensFlareShader;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0xA8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0xB0")]
		public Shader vignetteShader;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0xB8")]
		private Material vignetteMaterial;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0xC0")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0xC8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0xD0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0xD8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0xE0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0xE8")]
		private Material screenBlend;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0xF0")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0xF8")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x100")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x108")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1A34C64", Offset = "0x1A34C64", VA = "0x1A34C64", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1A34DC8", Offset = "0x1A34DC8", VA = "0x1A34DC8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1A35D14", Offset = "0x1A35D14", VA = "0x1A35D14")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1A35B24", Offset = "0x1A35B24", VA = "0x1A35B24")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1A358A8", Offset = "0x1A358A8", VA = "0x1A358A8")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1A359D0", Offset = "0x1A359D0", VA = "0x1A359D0")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1A35DC8", Offset = "0x1A35DC8", VA = "0x1A35DC8")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3BA1C", Offset = "0xB3BA1C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3BA1C", Offset = "0xB3BA1C")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000079")]
		public enum Resolution
		{
			[Token(Token = "0x4000332")]
			Low,
			[Token(Token = "0x4000333")]
			High
		}

		[Token(Token = "0x200007A")]
		public enum BlurType
		{
			[Token(Token = "0x4000335")]
			Standard,
			[Token(Token = "0x4000336")]
			Sgx
		}

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3CF90", Offset = "0xB3CF90")]
		public float threshold;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3CFA8", Offset = "0xB3CFA8")]
		public float intensity;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3CFC0", Offset = "0xB3CFC0")]
		public float blurSize;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x28")]
		private Resolution resolution;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3CFD8", Offset = "0xB3CFD8")]
		public int blurIterations;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x30")]
		public BlurType blurType;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x38")]
		public Shader fastBloomShader;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x40")]
		private Material fastBloomMaterial;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1A35EFC", Offset = "0x1A35EFC", VA = "0x1A35EFC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1A35F74", Offset = "0x1A35F74", VA = "0x1A35F74")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1A36024", Offset = "0x1A36024", VA = "0x1A36024")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1A363F0", Offset = "0x1A363F0", VA = "0x1A363F0")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3BAB4", Offset = "0xB3BAB4")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x18")]
		public int iterations;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x1C")]
		public float blurSpread;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x17000006")]
		protected Material material
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x1A36414", Offset = "0x1A36414", VA = "0x1A36414")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1A36554", Offset = "0x1A36554", VA = "0x1A36554")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1A36650", Offset = "0x1A36650", VA = "0x1A36650")]
		protected void Start()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1A36710", Offset = "0x1A36710", VA = "0x1A36710")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1A368B4", Offset = "0x1A368B4", VA = "0x1A368B4")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1A36A2C", Offset = "0x1A36A2C", VA = "0x1A36A2C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1A36B98", Offset = "0x1A36B98", VA = "0x1A36B98")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3BB00", Offset = "0xB3BB00")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3BB00", Offset = "0xB3BB00")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x200007B")]
		public enum BlurType
		{
			[Token(Token = "0x4000338")]
			StandardGauss,
			[Token(Token = "0x4000339")]
			SgxGauss
		}

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3CFF0", Offset = "0xB3CFF0")]
		public int downsample;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3D008", Offset = "0xB3D008")]
		public float blurSize;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3D020", Offset = "0xB3D020")]
		public int blurIterations;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x28")]
		public BlurType blurType;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x30")]
		public Shader blurShader;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x38")]
		private Material blurMaterial;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1A36BB4", Offset = "0x1A36BB4", VA = "0x1A36BB4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1A36C2C", Offset = "0x1A36C2C", VA = "0x1A36C2C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1A36CDC", Offset = "0x1A36CDC", VA = "0x1A36CDC")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1A37080", Offset = "0x1A37080", VA = "0x1A37080")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3BB98", Offset = "0xB3BB98")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3BB98", Offset = "0xB3BB98")]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x200007C")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x400033B")]
			CameraMotion,
			[Token(Token = "0x400033C")]
			LocalBlur,
			[Token(Token = "0x400033D")]
			Reconstruction,
			[Token(Token = "0x400033E")]
			ReconstructionDX11,
			[Token(Token = "0x400033F")]
			ReconstructionDisc
		}

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x1C")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x20")]
		public bool preview;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 previewScale;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x30")]
		public float movementScale;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x34")]
		public float rotationScale;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x38")]
		public float maxVelocity;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x3C")]
		public float minVelocity;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x40")]
		public float velocityScale;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x44")]
		public float softZDistance;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x48")]
		public int velocityDownsample;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x4C")]
		public LayerMask excludeLayers;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x50")]
		private GameObject tmpCam;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x58")]
		public Shader shader;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x60")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x68")]
		public Shader replacementClear;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x70")]
		private Material motionBlurMaterial;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x78")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x80")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x88")]
		public float jitter;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x8C")]
		public bool showVelocity;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x90")]
		public float showVelocityScale;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x94")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0xD4")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x114")]
		private int prevFrameCount;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x118")]
		private bool wasActive;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x11C")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x128")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x134")]
		private Vector3 prevFramePos;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x140")]
		private Camera _camera;

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1A3709C", Offset = "0x1A3709C", VA = "0x1A3709C")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1A371E8", Offset = "0x1A371E8", VA = "0x1A371E8")]
		private new void Start()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1A3737C", Offset = "0x1A3737C", VA = "0x1A3737C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1A37448", Offset = "0x1A37448", VA = "0x1A37448")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1A375E4", Offset = "0x1A375E4", VA = "0x1A375E4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1A3769C", Offset = "0x1A3769C", VA = "0x1A3769C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1A372D0", Offset = "0x1A372D0", VA = "0x1A372D0")]
		private void Remember()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1A38CC4", Offset = "0x1A38CC4", VA = "0x1A38CC4")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1A38BD8", Offset = "0x1A38BD8", VA = "0x1A38BD8")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1A38CB4", Offset = "0x1A38CB4", VA = "0x1A38CB4")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1A39028", Offset = "0x1A39028", VA = "0x1A39028")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3BC30", Offset = "0xB3BC30")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x200007D")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x4000341")]
			Simple,
			[Token(Token = "0x4000342")]
			Advanced
		}

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve redChannel;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x38")]
		public bool useDepthCorrection;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x40")]
		public AnimationCurve zCurve;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x50")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x58")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x60")]
		private Material ccMaterial;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x68")]
		private Material ccDepthMaterial;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x70")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x78")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x80")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x88")]
		private Texture2D zCurveTex;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x90")]
		public float saturation;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x94")]
		public bool selectiveCc;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x98")]
		public Color selectiveFromColor;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0xA8")]
		public Color selectiveToColor;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0xB8")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0xBC")]
		public bool updateTextures;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0xC0")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0xC8")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0xD0")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0xD8")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1A39178", Offset = "0x1A39178", VA = "0x1A39178")]
		private new void Start()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1A391A4", Offset = "0x1A391A4", VA = "0x1A391A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1A391A8", Offset = "0x1A391A8", VA = "0x1A391A8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1A39484", Offset = "0x1A39484", VA = "0x1A39484")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1A39878", Offset = "0x1A39878", VA = "0x1A39878")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1A3987C", Offset = "0x1A3987C", VA = "0x1A3987C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1A39B78", Offset = "0x1A39B78", VA = "0x1A39B78")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3BC7C", Offset = "0xB3BC7C")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x20")]
		public Shader shader;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x28")]
		private Material material;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x30")]
		public Texture3D converted3DLut;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x38")]
		public string basedOnTempTex;

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1A3A200", Offset = "0x1A3A200", VA = "0x1A3A200", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1A3A274", Offset = "0x1A3A274", VA = "0x1A3A274")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1A3A334", Offset = "0x1A3A334", VA = "0x1A3A334")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1A3A3E4", Offset = "0x1A3A3E4", VA = "0x1A3A3E4")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1A3A5F8", Offset = "0x1A3A5F8", VA = "0x1A3A5F8")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1A3A6EC", Offset = "0x1A3A6EC", VA = "0x1A3A6EC")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1A3AA20", Offset = "0x1A3AA20", VA = "0x1A3AA20")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1A3AC0C", Offset = "0x1A3AC0C", VA = "0x1A3AC0C")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3BCC8", Offset = "0xB3BCC8")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1A3AC6C", Offset = "0x1A3AC6C", VA = "0x1A3AC6C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1A3ADF8", Offset = "0x1A3ADF8", VA = "0x1A3ADF8")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3BD14", Offset = "0xB3BD14")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3BD14", Offset = "0xB3BD14")]
	internal class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x1C")]
		public float intensity;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x20")]
		public float threshold;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x28")]
		private Material separableBlurMaterial;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x30")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x38")]
		public float blurSpread;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x40")]
		public Shader separableBlurShader;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x48")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1A3AE08", Offset = "0x1A3AE08", VA = "0x1A3AE08", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1A3AEA8", Offset = "0x1A3AEA8", VA = "0x1A3AEA8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1A3B210", Offset = "0x1A3B210", VA = "0x1A3B210")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3BDAC", Offset = "0xB3BDAC")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x18")]
		public float adaptationSpeed;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x1C")]
		public float limitMinimum;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x20")]
		public float limitMaximum;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x17000007")]
		protected Material materialLum
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x1A3B228", Offset = "0x1A3B228", VA = "0x1A3B228")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		protected Material materialReduce
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x1A3B2FC", Offset = "0x1A3B2FC", VA = "0x1A3B2FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		protected Material materialAdapt
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x1A3B3D0", Offset = "0x1A3B3D0", VA = "0x1A3B3D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		protected Material materialApply
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x1A3B4A4", Offset = "0x1A3B4A4", VA = "0x1A3B4A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1A3B578", Offset = "0x1A3B578", VA = "0x1A3B578")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1A3B60C", Offset = "0x1A3B60C", VA = "0x1A3B60C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1A3B764", Offset = "0x1A3B764", VA = "0x1A3B764")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1A3B994", Offset = "0x1A3B994", VA = "0x1A3B994")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1A3BBF0", Offset = "0x1A3BBF0", VA = "0x1A3BBF0")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1A3BE00", Offset = "0x1A3BE00", VA = "0x1A3BE00")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3BDF8", Offset = "0xB3BDF8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3BDF8", Offset = "0xB3BDF8")]
	internal class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x1C")]
		public float intensity;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x20")]
		public int softness;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x24")]
		public float spread;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x28")]
		public Shader blurShader;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x30")]
		private Material blurMaterial;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x38")]
		public Shader depthFetchShader;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x40")]
		private Material depthFetchMaterial;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x48")]
		public Shader creaseApplyShader;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x50")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1A3BE84", Offset = "0x1A3BE84", VA = "0x1A3BE84", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1A3BF54", Offset = "0x1A3BF54", VA = "0x1A3BF54")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1A3C2FC", Offset = "0x1A3C2FC", VA = "0x1A3C2FC")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3BE90", Offset = "0xB3BE90")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3BE90", Offset = "0xB3BE90")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x200007E")]
		public enum BlurType
		{
			[Token(Token = "0x4000344")]
			DiscBlur,
			[Token(Token = "0x4000345")]
			DX11
		}

		[Token(Token = "0x200007F")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x4000347")]
			Low,
			[Token(Token = "0x4000348")]
			Medium,
			[Token(Token = "0x4000349")]
			High
		}

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x1B")]
		public bool visualizeFocus;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x1C")]
		public float focalLength;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x20")]
		public float focalSize;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x24")]
		public float aperture;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x28")]
		public Transform focalTransform;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x30")]
		public float maxBlurSize;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x34")]
		public bool highResolution;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x38")]
		public BlurType blurType;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x3C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x40")]
		public bool nearBlur;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x44")]
		public float foregroundOverlap;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x48")]
		public Shader dofHdrShader;

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x50")]
		private Material dofHdrMaterial;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x58")]
		public Shader dx11BokehShader;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x60")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x68")]
		public float dx11BokehThreshold;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x6C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x70")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x78")]
		public float dx11BokehScale;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x7C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x80")]
		private float focalDistance01;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x88")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x90")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x98")]
		private float internalBlurWidth;

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1A3C318", Offset = "0x1A3C318", VA = "0x1A3C318", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1A3C520", Offset = "0x1A3C520", VA = "0x1A3C520")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1A3C594", Offset = "0x1A3C594", VA = "0x1A3C594")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1A3C6B4", Offset = "0x1A3C6B4", VA = "0x1A3C6B4")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1A3C3D4", Offset = "0x1A3C3D4", VA = "0x1A3C3D4")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1A3C710", Offset = "0x1A3C710", VA = "0x1A3C710")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1A3C8B4", Offset = "0x1A3C8B4", VA = "0x1A3C8B4")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1A3CBD4", Offset = "0x1A3CBD4", VA = "0x1A3CBD4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1A3E244", Offset = "0x1A3E244", VA = "0x1A3E244")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3BF28", Offset = "0xB3BF28")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3BF28", Offset = "0xB3BF28")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x2000080")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x400034B")]
			OnlyBackground = 1,
			[Token(Token = "0x400034C")]
			BackgroundAndForeground
		}

		[Token(Token = "0x2000081")]
		public enum DofResolution
		{
			[Token(Token = "0x400034E")]
			High = 2,
			[Token(Token = "0x400034F")]
			Medium,
			[Token(Token = "0x4000350")]
			Low
		}

		[Token(Token = "0x2000082")]
		public enum DofBlurriness
		{
			[Token(Token = "0x4000352")]
			Low = 1,
			[Token(Token = "0x4000353")]
			High = 2,
			[Token(Token = "0x4000354")]
			VeryHigh = 4
		}

		[Token(Token = "0x2000083")]
		public enum BokehDestination
		{
			[Token(Token = "0x4000356")]
			Background = 1,
			[Token(Token = "0x4000357")]
			Foreground,
			[Token(Token = "0x4000358")]
			BackgroundAndForeground
		}

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x1C")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x20")]
		public DofResolution resolution;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x24")]
		public bool simpleTweakMode;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x28")]
		public float focalPoint;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x2C")]
		public float smoothness;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x30")]
		public float focalZDistance;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x34")]
		public float focalZStartCurve;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x38")]
		public float focalZEndCurve;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x3C")]
		private float focalStartCurve;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x40")]
		private float focalEndCurve;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x44")]
		private float focalDistance01;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x48")]
		public Transform objectFocus;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x50")]
		public float focalSize;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x54")]
		public DofBlurriness bluriness;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x58")]
		public float maxBlurSpread;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x5C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x60")]
		public Shader dofBlurShader;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x68")]
		private Material dofBlurMaterial;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x70")]
		public Shader dofShader;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x78")]
		private Material dofMaterial;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x80")]
		public bool visualize;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x84")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x88")]
		private float widthOverHeight;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x8C")]
		private float oneOverBaseSize;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x90")]
		public bool bokeh;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x91")]
		public bool bokehSupport;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x98")]
		public Shader bokehShader;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0xA0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0xA8")]
		public float bokehScale;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0xAC")]
		public float bokehIntensity;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0xB0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0xB4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0xB8")]
		public int bokehDownsample;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0xC0")]
		private Material bokehMaterial;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0xC8")]
		private Camera _camera;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0xD0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0xD8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0xE0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0xE8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0xF0")]
		private RenderTexture bokehSource;

		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0xF8")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1A3E29C", Offset = "0x1A3E29C", VA = "0x1A3E29C")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1A3E3B8", Offset = "0x1A3E3B8", VA = "0x1A3E3B8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1A3E504", Offset = "0x1A3E504", VA = "0x1A3E504")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1A3E564", Offset = "0x1A3E564", VA = "0x1A3E564")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1A3E5EC", Offset = "0x1A3E5EC", VA = "0x1A3E5EC")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1A3E748", Offset = "0x1A3E748", VA = "0x1A3E748")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1A3E76C", Offset = "0x1A3E76C", VA = "0x1A3E76C")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1A3E790", Offset = "0x1A3E790", VA = "0x1A3E790")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1A3F610", Offset = "0x1A3F610", VA = "0x1A3F610")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1A3FCC8", Offset = "0x1A3FCC8", VA = "0x1A3FCC8")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1A40130", Offset = "0x1A40130", VA = "0x1A40130")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1A3F4C4", Offset = "0x1A3F4C4", VA = "0x1A3F4C4")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1A3F8AC", Offset = "0x1A3F8AC", VA = "0x1A3F8AC")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1A3FF84", Offset = "0x1A3FF84", VA = "0x1A3FF84")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1A3F0F4", Offset = "0x1A3F0F4", VA = "0x1A3F0F4")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1A40358", Offset = "0x1A40358", VA = "0x1A40358")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3BFC0", Offset = "0xB3BFC0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3BFC0", Offset = "0xB3BFC0")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x2000084")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x400035A")]
			TriangleDepthNormals,
			[Token(Token = "0x400035B")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x400035C")]
			SobelDepth,
			[Token(Token = "0x400035D")]
			SobelDepthThin,
			[Token(Token = "0x400035E")]
			TriangleLuminance
		}

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x1C")]
		public EdgeDetectMode mode;

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x20")]
		public float sensitivityDepth;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x24")]
		public float sensitivityNormals;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x28")]
		public float lumThreshold;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x2C")]
		public float edgeExp;

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x30")]
		public float sampleDist;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x34")]
		public float edgesOnly;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x38")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x48")]
		public Shader edgeDetectShader;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x50")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x58")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1A40434", Offset = "0x1A40434", VA = "0x1A40434", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1A4058C", Offset = "0x1A4058C", VA = "0x1A4058C")]
		private new void Start()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1A404CC", Offset = "0x1A404CC", VA = "0x1A404CC")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1A40598", Offset = "0x1A40598", VA = "0x1A40598")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1A4059C", Offset = "0x1A4059C", VA = "0x1A4059C")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1A40788", Offset = "0x1A40788", VA = "0x1A40788")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3C058", Offset = "0xB3C058")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C058", Offset = "0xB3C058")]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x1C")]
		public float strengthX;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x20")]
		public float strengthY;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x28")]
		public Shader fishEyeShader;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x30")]
		private Material fisheyeMaterial;

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1A407DC", Offset = "0x1A407DC", VA = "0x1A407DC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1A40854", Offset = "0x1A40854", VA = "0x1A40854")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1A409C4", Offset = "0x1A409C4", VA = "0x1A409C4")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3C0F0", Offset = "0xB3C0F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C0F0", Offset = "0xB3C0F0")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x1B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3D038", Offset = "0xB3D038")]
		public bool distanceFog;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3D070", Offset = "0xB3D070")]
		public bool useRadialDistance;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x1D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3D0A8", Offset = "0xB3D0A8")]
		public bool heightFog;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3D0E0", Offset = "0xB3D0E0")]
		public float height;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3D118", Offset = "0xB3D118")]
		public float heightDensity;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3D134", Offset = "0xB3D134")]
		public float startDistance;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x30")]
		public Shader fogShader;

		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x38")]
		private Material fogMaterial;

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1A409DC", Offset = "0x1A409DC", VA = "0x1A409DC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1A40A5C", Offset = "0x1A40A5C", VA = "0x1A40A5C")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1A41278", Offset = "0x1A41278", VA = "0x1A41278")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1A413E8", Offset = "0x1A413E8", VA = "0x1A413E8")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C188", Offset = "0xB3C188")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x30")]
		public float rampOffset;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1A41408", Offset = "0x1A41408", VA = "0x1A41408")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1A414E4", Offset = "0x1A414E4", VA = "0x1A414E4")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3C1D4", Offset = "0xB3C1D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C1D4", Offset = "0xB3C1D4")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x1700000B")]
		protected Material material
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x1A3AD24", Offset = "0x1A3AD24", VA = "0x1A3AD24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1A414EC", Offset = "0x1A414EC", VA = "0x1A414EC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1A4159C", Offset = "0x1A4159C", VA = "0x1A4159C", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1A3AE00", Offset = "0x1A3AE00", VA = "0x1A3AE00")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C25C", Offset = "0xB3C25C")]
	public class ImageEffects
	{
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1A4164C", Offset = "0x1A4164C", VA = "0x1A4164C")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1A418C8", Offset = "0x1A418C8", VA = "0x1A418C8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB3D914", Offset = "0xB3D914")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1A41940", Offset = "0x1A41940", VA = "0x1A41940")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB3D94C", Offset = "0xB3D94C")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1A419C0", Offset = "0x1A419C0", VA = "0x1A419C0")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C294", Offset = "0xB3C294")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3C294", Offset = "0xB3C294")]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x28")]
		public float blurAmount;

		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1E767B8", Offset = "0x1E767B8", VA = "0x1E767B8", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1E76800", Offset = "0x1E76800", VA = "0x1E76800", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1E76878", Offset = "0x1E76878", VA = "0x1E76878")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1E76C20", Offset = "0x1E76C20", VA = "0x1E76C20")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3C32C", Offset = "0xB3C32C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C32C", Offset = "0xB3C32C")]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x1C")]
		public float intensityMultiplier;

		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x20")]
		public float generalIntensity;

		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x24")]
		public float blackIntensity;

		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x28")]
		public float whiteIntensity;

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x2C")]
		public float midGrey;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x30")]
		public bool dx11Grain;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x34")]
		public float softness;

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x38")]
		public bool monochrome;

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 intensities;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 tiling;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x54")]
		public float monochromeTiling;

		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x58")]
		public FilterMode filterMode;

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x60")]
		public Texture2D noiseTexture;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x68")]
		public Shader noiseShader;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x70")]
		private Material noiseMaterial;

		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x78")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x80")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1E76C34", Offset = "0x1E76C34", VA = "0x1E76C34", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1E7726C", Offset = "0x1E7726C", VA = "0x1E7726C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1E77B8C", Offset = "0x1E77B8C", VA = "0x1E77B8C")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1E77F08", Offset = "0x1E77F08", VA = "0x1E77F08")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3C3C4", Offset = "0xB3C3C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C3C4", Offset = "0xB3C3C4")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x1C")]
		public float grainIntensityMin;

		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x20")]
		public float grainIntensityMax;

		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x24")]
		public float grainSize;

		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x28")]
		public float scratchIntensityMin;

		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x2C")]
		public float scratchIntensityMax;

		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x30")]
		public float scratchFPS;

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x34")]
		public float scratchJitter;

		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x1700000C")]
		protected Material material
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x1E78174", Offset = "0x1E78174", VA = "0x1E78174")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1E78034", Offset = "0x1E78034", VA = "0x1E78034")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1E782E8", Offset = "0x1E782E8", VA = "0x1E782E8")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1E783EC", Offset = "0x1E783EC", VA = "0x1E783EC")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1E78528", Offset = "0x1E78528", VA = "0x1E78528")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1E78870", Offset = "0x1E78870", VA = "0x1E78870")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3C45C", Offset = "0xB3C45C")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1E76DE8", Offset = "0x1E76DE8", VA = "0x1E76DE8")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1E788D0", Offset = "0x1E788D0", VA = "0x1E788D0")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1E78AC0", Offset = "0x1E78AC0", VA = "0x1E78AC0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1E78ACC", Offset = "0x1E78ACC", VA = "0x1E78ACC")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1E78AD4", Offset = "0x1E78AD4", VA = "0x1E78AD4", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1E78B84", Offset = "0x1E78B84", VA = "0x1E78B84")]
		protected void Start()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1E76CD4", Offset = "0x1E76CD4", VA = "0x1E76CD4")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1E78B90", Offset = "0x1E78B90", VA = "0x1E78B90")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1E78BEC", Offset = "0x1E78BEC", VA = "0x1E78BEC")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1E771C4", Offset = "0x1E771C4", VA = "0x1E771C4")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1E78BF4", Offset = "0x1E78BF4", VA = "0x1E78BF4")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1E788A4", Offset = "0x1E788A4", VA = "0x1E788A4")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1E78E3C", Offset = "0x1E78E3C", VA = "0x1E78E3C")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1E77FCC", Offset = "0x1E77FCC", VA = "0x1E77FCC")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3C4D0", Offset = "0xB3C4D0")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1E791B8", Offset = "0x1E791B8", VA = "0x1E791B8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1E79224", Offset = "0x1E79224", VA = "0x1E79224")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1E794A0", Offset = "0x1E794A0", VA = "0x1E794A0")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1E79818", Offset = "0x1E79818", VA = "0x1E79818")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1E799C4", Offset = "0x1E799C4", VA = "0x1E799C4")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x2000041")]
	internal class Quads
	{
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1E799CC", Offset = "0x1E799CC", VA = "0x1E799CC")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1E79AF0", Offset = "0x1E79AF0", VA = "0x1E79AF0")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1E79CE0", Offset = "0x1E79CE0", VA = "0x1E79CE0")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1E79FB4", Offset = "0x1E79FB4", VA = "0x1E79FB4")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1E7A4E8", Offset = "0x1E7A4E8", VA = "0x1E7A4E8")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3C544", Offset = "0xB3C544")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C544", Offset = "0xB3C544")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x2000085")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x4000360")]
			Additive,
			[Token(Token = "0x4000361")]
			ScreenBlend,
			[Token(Token = "0x4000362")]
			Multiply,
			[Token(Token = "0x4000363")]
			Overlay,
			[Token(Token = "0x4000364")]
			AlphaBlend
		}

		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x1C")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x20")]
		public float intensity;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x28")]
		public Texture2D texture;

		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x30")]
		public Shader overlayShader;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x38")]
		private Material overlayMaterial;

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1E7A4F4", Offset = "0x1E7A4F4", VA = "0x1E7A4F4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1E7A560", Offset = "0x1E7A560", VA = "0x1E7A560")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1E7A6C8", Offset = "0x1E7A6C8", VA = "0x1E7A6C8")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3C5DC", Offset = "0xB3C5DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C5DC", Offset = "0xB3C5DC")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3D16C", Offset = "0xB3D16C")]
		public float intensity;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3D184", Offset = "0xB3D184")]
		public float radius;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3D1A0", Offset = "0xB3D1A0")]
		public int blurIterations;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3D1B8", Offset = "0xB3D1B8")]
		public float blurFilterDistance;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3D1D0", Offset = "0xB3D1D0")]
		public int downsample;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D rand;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x38")]
		public Shader aoShader;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x40")]
		private Material aoMaterial;

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1E7A6E8", Offset = "0x1E7A6E8", VA = "0x1E7A6E8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1E7A75C", Offset = "0x1E7A75C", VA = "0x1E7A75C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1E7A80C", Offset = "0x1E7A80C", VA = "0x1E7A80C")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1E7ADE0", Offset = "0x1E7ADE0", VA = "0x1E7ADE0")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3C674", Offset = "0xB3C674")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C674", Offset = "0xB3C674")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000086")]
		public enum SSAOSamples
		{
			[Token(Token = "0x4000366")]
			Low,
			[Token(Token = "0x4000367")]
			Medium,
			[Token(Token = "0x4000368")]
			High
		}

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x18")]
		public float m_Radius;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x20")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x24")]
		public int m_Blur;

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x28")]
		public int m_Downsampling;

		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x2C")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x30")]
		public float m_MinZ;

		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1E7AE0C", Offset = "0x1E7AE0C", VA = "0x1E7AE0C")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1E7AEBC", Offset = "0x1E7AEBC", VA = "0x1E7AEBC")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1E7AF58", Offset = "0x1E7AF58", VA = "0x1E7AF58")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1E7AF60", Offset = "0x1E7AF60", VA = "0x1E7AF60")]
		private void Start()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1E7B114", Offset = "0x1E7B114", VA = "0x1E7B114")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1E7B038", Offset = "0x1E7B038", VA = "0x1E7B038")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1E7B188", Offset = "0x1E7B188", VA = "0x1E7B188")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1E7B844", Offset = "0x1E7B844", VA = "0x1E7B844")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C70C", Offset = "0xB3C70C")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1E7B878", Offset = "0x1E7B878", VA = "0x1E7B878")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1E7B90C", Offset = "0x1E7B90C", VA = "0x1E7B90C")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3C758", Offset = "0xB3C758")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C758", Offset = "0xB3C758")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x2000087")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x400036A")]
			Low,
			[Token(Token = "0x400036B")]
			Normal,
			[Token(Token = "0x400036C")]
			High
		}

		[Token(Token = "0x2000088")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x400036E")]
			Screen,
			[Token(Token = "0x400036F")]
			Add
		}

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x1C")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x20")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x28")]
		public Transform sunTransform;

		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x30")]
		public int radialBlurIterations;

		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x34")]
		public Color sunColor;

		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x44")]
		public Color sunThreshold;

		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x54")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x58")]
		public float sunShaftIntensity;

		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x5C")]
		public float maxRadius;

		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x60")]
		public bool useDepthTexture;

		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x68")]
		public Shader sunShaftsShader;

		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x70")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x78")]
		public Shader simpleClearShader;

		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x80")]
		private Material simpleClearMaterial;

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1E7B914", Offset = "0x1E7B914", VA = "0x1E7B914", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1E7B9A4", Offset = "0x1E7B9A4", VA = "0x1E7B9A4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1E7C190", Offset = "0x1E7C190", VA = "0x1E7C190")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3C7F0", Offset = "0xB3C7F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C7F0", Offset = "0xB3C7F0")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x2000089")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x4000371")]
			TiltShiftMode,
			[Token(Token = "0x4000372")]
			IrisMode
		}

		[Token(Token = "0x200008A")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x4000374")]
			Preview,
			[Token(Token = "0x4000375")]
			Normal,
			[Token(Token = "0x4000376")]
			High
		}

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x1C")]
		public TiltShiftMode mode;

		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x20")]
		public TiltShiftQuality quality;

		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3D1E8", Offset = "0xB3D1E8")]
		public float blurArea;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3D200", Offset = "0xB3D200")]
		public float maxBlurSize;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3D218", Offset = "0xB3D218")]
		public int downsample;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x30")]
		public Shader tiltShiftShader;

		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x38")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1E7C230", Offset = "0x1E7C230", VA = "0x1E7C230", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1E7C2A4", Offset = "0x1E7C2A4", VA = "0x1E7C2A4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1E7C534", Offset = "0x1E7C534", VA = "0x1E7C534")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3C878", Offset = "0xB3C878")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C878", Offset = "0xB3C878")]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x200008B")]
		public enum TonemapperType
		{
			[Token(Token = "0x4000378")]
			SimpleReinhard,
			[Token(Token = "0x4000379")]
			UserCurve,
			[Token(Token = "0x400037A")]
			Hable,
			[Token(Token = "0x400037B")]
			Photographic,
			[Token(Token = "0x400037C")]
			OptimizedHejiDawson,
			[Token(Token = "0x400037D")]
			AdaptiveReinhard,
			[Token(Token = "0x400037E")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x200008C")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x4000380")]
			Square16 = 0x10,
			[Token(Token = "0x4000381")]
			Square32 = 0x20,
			[Token(Token = "0x4000382")]
			Square64 = 0x40,
			[Token(Token = "0x4000383")]
			Square128 = 0x80,
			[Token(Token = "0x4000384")]
			Square256 = 0x100,
			[Token(Token = "0x4000385")]
			Square512 = 0x200,
			[Token(Token = "0x4000386")]
			Square1024 = 0x400
		}

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x1C")]
		public TonemapperType type;

		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x20")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x30")]
		private Texture2D curveTex;

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x38")]
		public float exposureAdjustment;

		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x3C")]
		public float middleGrey;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x40")]
		public float white;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x44")]
		public float adaptionSpeed;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x48")]
		public Shader tonemapper;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x50")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x58")]
		private Material tonemapMaterial;

		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x60")]
		private RenderTexture rt;

		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x68")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1E7C558", Offset = "0x1E7C558", VA = "0x1E7C558", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1E7C6BC", Offset = "0x1E7C6BC", VA = "0x1E7C6BC")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1E7C974", Offset = "0x1E7C974", VA = "0x1E7C974")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1E7CB04", Offset = "0x1E7CB04", VA = "0x1E7CB04")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1E7CC04", Offset = "0x1E7CC04", VA = "0x1E7CC04")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1E7D410", Offset = "0x1E7D410", VA = "0x1E7D410")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x2000049")]
	internal class Triangles
	{
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1E7D448", Offset = "0x1E7D448", VA = "0x1E7D448")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1E7D584", Offset = "0x1E7D584", VA = "0x1E7D584")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1E7D774", Offset = "0x1E7D774", VA = "0x1E7D774")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1E7DA48", Offset = "0x1E7DA48", VA = "0x1E7DA48")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1E7DE78", Offset = "0x1E7DE78", VA = "0x1E7DE78")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C910", Offset = "0xB3C910")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1E7DE84", Offset = "0x1E7DE84", VA = "0x1E7DE84")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1E7DED0", Offset = "0x1E7DED0", VA = "0x1E7DED0")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3C95C", Offset = "0xB3C95C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C95C", Offset = "0xB3C95C")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x200008D")]
		public enum AberrationMode
		{
			[Token(Token = "0x4000388")]
			Simple,
			[Token(Token = "0x4000389")]
			Advanced
		}

		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x1C")]
		public AberrationMode mode;

		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x20")]
		public float intensity;

		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x24")]
		public float chromaticAberration;

		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x28")]
		public float axialAberration;

		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x2C")]
		public float blur;

		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x30")]
		public float blurSpread;

		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x34")]
		public float luminanceDependency;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x38")]
		public float blurDistance;

		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x40")]
		public Shader vignetteShader;

		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x50")]
		public Shader chromAberrationShader;

		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x58")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x60")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x68")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1E7DF4C", Offset = "0x1E7DF4C", VA = "0x1E7DF4C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1E7E000", Offset = "0x1E7E000", VA = "0x1E7E000")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1E7E60C", Offset = "0x1E7E60C", VA = "0x1E7E60C")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3C9F4", Offset = "0xB3C9F4")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1E7E648", Offset = "0x1E7E648", VA = "0x1E7E648")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1E7E694", Offset = "0x1E7E694", VA = "0x1E7E694")]
		public Vortex()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200004D")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1A2F288", Offset = "0x1A2F288", VA = "0x1A2F288")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1A2F550", Offset = "0x1A2F550", VA = "0x1A2F550")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1A2F6E0", Offset = "0x1A2F6E0", VA = "0x1A2F6E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1A2F760", Offset = "0x1A2F760", VA = "0x1A2F760", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1A2F848", Offset = "0x1A2F848", VA = "0x1A2F848", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1A2F8F0", Offset = "0x1A2F8F0", VA = "0x1A2F8F0")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1A2F964", Offset = "0x1A2F964", VA = "0x1A2F964")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1A2F968", Offset = "0x1A2F968", VA = "0x1A2F968")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1A2FA50", Offset = "0x1A2FA50", VA = "0x1A2FA50")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1A2FB38", Offset = "0x1A2FB38", VA = "0x1A2FB38")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1A2FC20", Offset = "0x1A2FC20", VA = "0x1A2FC20")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1A2FD08", Offset = "0x1A2FD08", VA = "0x1A2FD08")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1A2FDF0", Offset = "0x1A2FDF0", VA = "0x1A2FDF0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1A2FDF4", Offset = "0x1A2FDF4", VA = "0x1A2FDF4")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200008E")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x400038B")]
			Hardware,
			[Token(Token = "0x400038C")]
			Touch
		}

		[Token(Token = "0x200008F")]
		public class VirtualAxis
		{
			[Token(Token = "0x400038D")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D468", Offset = "0xB3D468")]
			private string <name>k__BackingField;

			[Token(Token = "0x400038E")]
			[FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x400038F")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D478", Offset = "0xB3D478")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x17000027")]
			public string name
			{
				[Token(Token = "0x600024A")]
				[Address(RVA = "0x1A30C78", Offset = "0x1A30C78", VA = "0x1A30C78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3DCE4", Offset = "0xB3DCE4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600024B")]
				[Address(RVA = "0x1A30C80", Offset = "0x1A30C80", VA = "0x1A30C80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3DCF4", Offset = "0xB3DCF4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600024C")]
				[Address(RVA = "0x1A30C88", Offset = "0x1A30C88", VA = "0x1A30C88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3DD04", Offset = "0xB3DD04")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600024D")]
				[Address(RVA = "0x1A30C90", Offset = "0x1A30C90", VA = "0x1A30C90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3DD14", Offset = "0xB3DD14")]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public float GetValue
			{
				[Token(Token = "0x6000252")]
				[Address(RVA = "0x1A30CF0", Offset = "0x1A30CF0", VA = "0x1A30CF0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002A")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000253")]
				[Address(RVA = "0x1A30CF8", Offset = "0x1A30CF8", VA = "0x1A30CF8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600024E")]
			[Address(RVA = "0x1A2F420", Offset = "0x1A2F420", VA = "0x1A2F420")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x600024F")]
			[Address(RVA = "0x1A30C9C", Offset = "0x1A30C9C", VA = "0x1A30C9C")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000250")]
			[Address(RVA = "0x1A2F6F8", Offset = "0x1A2F6F8", VA = "0x1A2F6F8")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000251")]
			[Address(RVA = "0x1A30CE8", Offset = "0x1A30CE8", VA = "0x1A30CE8")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000090")]
		public class VirtualButton
		{
			[Token(Token = "0x4000390")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D488", Offset = "0xB3D488")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000391")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D498", Offset = "0xB3D498")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x4000392")]
			[FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x4000393")]
			[FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000394")]
			[FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x1700002B")]
			public string name
			{
				[Token(Token = "0x6000254")]
				[Address(RVA = "0x1A30D00", Offset = "0x1A30D00", VA = "0x1A30D00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3DD24", Offset = "0xB3DD24")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000255")]
				[Address(RVA = "0x1A30D08", Offset = "0x1A30D08", VA = "0x1A30D08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3DD34", Offset = "0xB3DD34")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002C")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000256")]
				[Address(RVA = "0x1A30D10", Offset = "0x1A30D10", VA = "0x1A30D10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3DD44", Offset = "0xB3DD44")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000257")]
				[Address(RVA = "0x1A30D18", Offset = "0x1A30D18", VA = "0x1A30D18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3DD54", Offset = "0xB3DD54")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002D")]
			public bool GetButton
			{
				[Token(Token = "0x600025D")]
				[Address(RVA = "0x1A30E90", Offset = "0x1A30E90", VA = "0x1A30E90")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700002E")]
			public bool GetButtonDown
			{
				[Token(Token = "0x600025E")]
				[Address(RVA = "0x1A30E98", Offset = "0x1A30E98", VA = "0x1A30E98")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700002F")]
			public bool GetButtonUp
			{
				[Token(Token = "0x600025F")]
				[Address(RVA = "0x1A30EC8", Offset = "0x1A30EC8", VA = "0x1A30EC8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000258")]
			[Address(RVA = "0x1A30D24", Offset = "0x1A30D24", VA = "0x1A30D24")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x6000259")]
			[Address(RVA = "0x1A30D6C", Offset = "0x1A30D6C", VA = "0x1A30D6C")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600025A")]
			[Address(RVA = "0x1A30DC0", Offset = "0x1A30DC0", VA = "0x1A30DC0")]
			public void Pressed()
			{
			}

			[Token(Token = "0x600025B")]
			[Address(RVA = "0x1A30DFC", Offset = "0x1A30DFC", VA = "0x1A30DFC")]
			public void Released()
			{
			}

			[Token(Token = "0x600025C")]
			[Address(RVA = "0x1A30E28", Offset = "0x1A30E28", VA = "0x1A30E28")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x1700000D")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x1A308F8", Offset = "0x1A308F8", VA = "0x1A308F8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1A2FDFC", Offset = "0x1A2FDFC", VA = "0x1A2FDFC")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1A2FEB0", Offset = "0x1A2FEB0", VA = "0x1A2FEB0")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1A2F3A8", Offset = "0x1A2F3A8", VA = "0x1A2F3A8")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1A2FFD0", Offset = "0x1A2FFD0", VA = "0x1A2FFD0")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1A2F460", Offset = "0x1A2F460", VA = "0x1A2F460")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1A301D8", Offset = "0x1A301D8", VA = "0x1A301D8")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1A30378", Offset = "0x1A30378", VA = "0x1A30378")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1A304C8", Offset = "0x1A304C8", VA = "0x1A304C8")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1A2F4D8", Offset = "0x1A2F4D8", VA = "0x1A2F4D8")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1A2C058", Offset = "0x1A2C058", VA = "0x1A2C058")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1A306FC", Offset = "0x1A306FC", VA = "0x1A306FC")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1A3066C", Offset = "0x1A3066C", VA = "0x1A3066C")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1A30764", Offset = "0x1A30764", VA = "0x1A30764")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1A2B578", Offset = "0x1A2B578", VA = "0x1A2B578")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1A307E4", Offset = "0x1A307E4", VA = "0x1A307E4")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1A2F9D0", Offset = "0x1A2F9D0", VA = "0x1A2F9D0")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1A2FAB8", Offset = "0x1A2FAB8", VA = "0x1A2FAB8")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1A2FBA0", Offset = "0x1A2FBA0", VA = "0x1A2FBA0")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1A2FD70", Offset = "0x1A2FD70", VA = "0x1A2FD70")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1A2FC88", Offset = "0x1A2FC88", VA = "0x1A2FC88")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1A30864", Offset = "0x1A30864", VA = "0x1A30864")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1A30974", Offset = "0x1A30974", VA = "0x1A30974")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1A30A70", Offset = "0x1A30A70", VA = "0x1A30A70")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1A30B78", Offset = "0x1A30B78", VA = "0x1A30B78")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1A30EF8", Offset = "0x1A30EF8", VA = "0x1A30EF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1A30EFC", Offset = "0x1A30EFC", VA = "0x1A30EFC")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1A30F7C", Offset = "0x1A30F7C", VA = "0x1A30F7C")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000091")]
		public enum AxisOption
		{
			[Token(Token = "0x4000396")]
			Both,
			[Token(Token = "0x4000397")]
			OnlyHorizontal,
			[Token(Token = "0x4000398")]
			OnlyVertical
		}

		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1A30F84", Offset = "0x1A30F84", VA = "0x1A30F84")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1A310FC", Offset = "0x1A310FC", VA = "0x1A310FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1A31138", Offset = "0x1A31138", VA = "0x1A31138")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1A30F88", Offset = "0x1A30F88", VA = "0x1A30F88")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1A31228", Offset = "0x1A31228", VA = "0x1A31228", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1A313E8", Offset = "0x1A313E8", VA = "0x1A313E8", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1A31430", Offset = "0x1A31430", VA = "0x1A31430", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1A31434", Offset = "0x1A31434", VA = "0x1A31434")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1A31484", Offset = "0x1A31484", VA = "0x1A31484")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1A31504", Offset = "0x1A31504", VA = "0x1A31504")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1A31514", Offset = "0x1A31514", VA = "0x1A31514")]
		private void Start()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1A3150C", Offset = "0x1A3150C", VA = "0x1A3150C")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1A315F0", Offset = "0x1A315F0", VA = "0x1A315F0")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1A3185C", Offset = "0x1A3185C", VA = "0x1A3185C")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000092")]
		public enum AxisOptions
		{
			[Token(Token = "0x400039A")]
			ForwardAxis,
			[Token(Token = "0x400039B")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		public class AxisMapping
		{
			[Token(Token = "0x2000098")]
			public enum MappingType
			{
				[Token(Token = "0x40003B5")]
				NamedAxis,
				[Token(Token = "0x40003B6")]
				MousePositionX,
				[Token(Token = "0x40003B7")]
				MousePositionY,
				[Token(Token = "0x40003B8")]
				MousePositionZ
			}

			[Token(Token = "0x400039C")]
			[FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x400039D")]
			[FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000260")]
			[Address(RVA = "0x1A32764", Offset = "0x1A32764", VA = "0x1A32764")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1A323D4", Offset = "0x1A323D4", VA = "0x1A323D4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1A324B0", Offset = "0x1A324B0", VA = "0x1A324B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1A3273C", Offset = "0x1A3273C", VA = "0x1A3273C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1A32754", Offset = "0x1A32754", VA = "0x1A32754")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3CA50", Offset = "0xB3CA50")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000094")]
		public enum AxisOption
		{
			[Token(Token = "0x400039F")]
			Both,
			[Token(Token = "0x40003A0")]
			OnlyHorizontal,
			[Token(Token = "0x40003A1")]
			OnlyVertical
		}

		[Token(Token = "0x2000095")]
		public enum ControlStyle
		{
			[Token(Token = "0x40003A3")]
			Absolute,
			[Token(Token = "0x40003A4")]
			Relative,
			[Token(Token = "0x40003A5")]
			Swipe
		}

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1A3276C", Offset = "0x1A3276C", VA = "0x1A3276C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1A328E4", Offset = "0x1A328E4", VA = "0x1A328E4")]
		private void Start()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1A32770", Offset = "0x1A32770", VA = "0x1A32770")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1A32970", Offset = "0x1A32970", VA = "0x1A32970")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1A329DC", Offset = "0x1A329DC", VA = "0x1A329DC", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1A32A8C", Offset = "0x1A32A8C", VA = "0x1A32A8C")]
		private void Update()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1A32C60", Offset = "0x1A32C60", VA = "0x1A32C60", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1A32CD8", Offset = "0x1A32CD8", VA = "0x1A32CD8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1A32DCC", Offset = "0x1A32DCC", VA = "0x1A32DCC")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D230", Offset = "0xB3D230")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x1700000E")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x1A32E54", Offset = "0x1A32E54", VA = "0x1A32E54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D9B4", Offset = "0xB3D9B4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x1A32E60", Offset = "0x1A32E60", VA = "0x1A32E60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D9C4", Offset = "0xB3D9C4")]
			private set
			{
			}
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1A2FF68", Offset = "0x1A2FF68", VA = "0x1A2FF68")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1A30048", Offset = "0x1A30048", VA = "0x1A30048")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1A300B0", Offset = "0x1A300B0", VA = "0x1A300B0")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1A30250", Offset = "0x1A30250", VA = "0x1A30250")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1A30430", Offset = "0x1A30430", VA = "0x1A30430")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1A30540", Offset = "0x1A30540", VA = "0x1A30540")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1A305D8", Offset = "0x1A305D8", VA = "0x1A305D8")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1A30A24", Offset = "0x1A30A24", VA = "0x1A30A24")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1A30B24", Offset = "0x1A30B24", VA = "0x1A30B24")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1A30C28", Offset = "0x1A30C28", VA = "0x1A30C28")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x60001AD")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x60001AE")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x60001AF")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x60001B0")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x60001B1")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x60001B2")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x60001B3")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x60001B4")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x60001B5")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x60001B6")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x60001B7")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1A32028", Offset = "0x1A32028", VA = "0x1A32028")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000056")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1A31864", Offset = "0x1A31864", VA = "0x1A31864")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1A31904", Offset = "0x1A31904", VA = "0x1A31904")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1A3199C", Offset = "0x1A3199C", VA = "0x1A3199C", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1A31A38", Offset = "0x1A31A38", VA = "0x1A31A38", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1A31AF0", Offset = "0x1A31AF0", VA = "0x1A31AF0", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1A31B9C", Offset = "0x1A31B9C", VA = "0x1A31B9C", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1A31C3C", Offset = "0x1A31C3C", VA = "0x1A31C3C", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1A31CDC", Offset = "0x1A31CDC", VA = "0x1A31CDC", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1A31D78", Offset = "0x1A31D78", VA = "0x1A31D78", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1A31E20", Offset = "0x1A31E20", VA = "0x1A31E20", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1A31ED0", Offset = "0x1A31ED0", VA = "0x1A31ED0", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1A31F80", Offset = "0x1A31F80", VA = "0x1A31F80", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1A3201C", Offset = "0x1A3201C", VA = "0x1A3201C", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1A2FEA8", Offset = "0x1A2FEA8", VA = "0x1A2FEA8")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1A3210C", Offset = "0x1A3210C", VA = "0x1A3210C", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1A32120", Offset = "0x1A32120", VA = "0x1A32120", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1A3212C", Offset = "0x1A3212C", VA = "0x1A3212C", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1A32138", Offset = "0x1A32138", VA = "0x1A32138", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1A32144", Offset = "0x1A32144", VA = "0x1A32144", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1A321B0", Offset = "0x1A321B0", VA = "0x1A321B0", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1A3221C", Offset = "0x1A3221C", VA = "0x1A3221C", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1A32288", Offset = "0x1A32288", VA = "0x1A32288", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1A322F4", Offset = "0x1A322F4", VA = "0x1A322F4", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1A32360", Offset = "0x1A32360", VA = "0x1A32360", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1A323CC", Offset = "0x1A323CC", VA = "0x1A323CC", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1A2FEAC", Offset = "0x1A2FEAC", VA = "0x1A2FEAC")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3CAB4", Offset = "0xB3CAB4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3CAB4", Offset = "0xB3CAB4")]
	public class AICharacterControl : MonoBehaviour
	{
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D240", Offset = "0xB3D240")]
		private NavMeshAgent <agent>k__BackingField;

		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D250", Offset = "0xB3D250")]
		private ThirdPersonCharacter <character>k__BackingField;

		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x1700000F")]
		public NavMeshAgent agent
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x1A2DC80", Offset = "0x1A2DC80", VA = "0x1A2DC80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D9D4", Offset = "0xB3D9D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x1A2DC88", Offset = "0x1A2DC88", VA = "0x1A2DC88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D9E4", Offset = "0xB3D9E4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public ThirdPersonCharacter character
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x1A2DC90", Offset = "0x1A2DC90", VA = "0x1A2DC90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D9F4", Offset = "0xB3D9F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x1A2DC98", Offset = "0x1A2DC98", VA = "0x1A2DC98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3DA04", Offset = "0xB3DA04")]
			private set
			{
			}
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1A2DCA0", Offset = "0x1A2DCA0", VA = "0x1A2DCA0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1A2DD54", Offset = "0x1A2DD54", VA = "0x1A2DD54")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1A2E030", Offset = "0x1A2E030", VA = "0x1A2E030")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1A2E038", Offset = "0x1A2E038", VA = "0x1A2E038")]
		public AICharacterControl()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3CB40", Offset = "0xB3CB40")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3CB40", Offset = "0xB3CB40")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3CB40", Offset = "0xB3CB40")]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovingTurnSpeed;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_StationaryTurnSpeed;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3D290", Offset = "0xB3D290")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_RunCycleLegOffset;

		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MoveSpeedMultiplier;

		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_AnimSpeedMultiplier;

		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_GroundCheckDistance;

		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x40")]
		private Animator m_Animator;

		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x48")]
		private bool m_IsGrounded;

		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x4C")]
		private float m_OrigGroundCheckDistance;

		[Token(Token = "0x400028D")]
		private const float k_Half = 0.5f;

		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x50")]
		private float m_TurnAmount;

		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x54")]
		private float m_ForwardAmount;

		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 m_GroundNormal;

		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x64")]
		private float m_CapsuleHeight;

		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 m_CapsuleCenter;

		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x78")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x80")]
		private bool m_Crouching;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1A2E040", Offset = "0x1A2E040", VA = "0x1A2E040")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1A2DE78", Offset = "0x1A2DE78", VA = "0x1A2DE78")]
		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1A2E5F0", Offset = "0x1A2E5F0", VA = "0x1A2E5F0")]
		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1A2E88C", Offset = "0x1A2E88C", VA = "0x1A2E88C")]
		private void PreventStandingInLowHeadroom()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1A2EA44", Offset = "0x1A2EA44", VA = "0x1A2EA44")]
		private void UpdateAnimator(Vector3 move)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1A2E4DC", Offset = "0x1A2E4DC", VA = "0x1A2E4DC")]
		private void HandleAirborneMovement()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1A2E39C", Offset = "0x1A2E39C", VA = "0x1A2E39C")]
		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1A2E2CC", Offset = "0x1A2E2CC", VA = "0x1A2E2CC")]
		private void ApplyExtraTurnRotation()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1A2EC90", Offset = "0x1A2EC90", VA = "0x1A2EC90")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1A2E138", Offset = "0x1A2E138", VA = "0x1A2E138")]
		private void CheckGroundStatus()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1A2EDC0", Offset = "0x1A2EDC0", VA = "0x1A2EDC0")]
		public ThirdPersonCharacter()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3CBF4", Offset = "0xB3CBF4")]
	public class ThirdPersonUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x18")]
		private ThirdPersonCharacter m_Character;

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x20")]
		private Transform m_Cam;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 m_CamForward;

		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 m_Move;

		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x40")]
		private bool m_Jump;

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1A2EDE0", Offset = "0x1A2EDE0", VA = "0x1A2EDE0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1A2EEFC", Offset = "0x1A2EEFC", VA = "0x1A2EEFC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1A2EF7C", Offset = "0x1A2EF7C", VA = "0x1A2EF7C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1A2F280", Offset = "0x1A2F280", VA = "0x1A2F280")]
		public ThirdPersonUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3CC58", Offset = "0xB3CC58")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3CC58", Offset = "0xB3CC58")]
	public class FirstPersonController : MonoBehaviour
	{
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3D340", Offset = "0xB3D340")]
		private float m_RunstepLenghten;

		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MouseLook m_MouseLook;

		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FOVKick m_FovKick;

		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioClip m_JumpSound;

		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AudioClip m_LandSound;

		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x88")]
		private Camera m_Camera;

		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x90")]
		private bool m_Jump;

		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x94")]
		private float m_YRotation;

		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x98")]
		private Vector2 m_Input;

		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0xB0")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0xB8")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0xBC")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0xC0")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0xCC")]
		private float m_StepCycle;

		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0xD0")]
		private float m_NextStep;

		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0xD4")]
		private bool m_Jumping;

		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0xD8")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1A2B284", Offset = "0x1A2B284", VA = "0x1A2B284")]
		private void Start()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1A2B40C", Offset = "0x1A2B40C", VA = "0x1A2B40C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1A2B5F8", Offset = "0x1A2B5F8", VA = "0x1A2B5F8")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1A2B64C", Offset = "0x1A2B64C", VA = "0x1A2B64C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1A2BBCC", Offset = "0x1A2BBCC", VA = "0x1A2BBCC")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1A2BC0C", Offset = "0x1A2BC0C", VA = "0x1A2BC0C")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1A2BEE8", Offset = "0x1A2BEE8", VA = "0x1A2BEE8")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1A2BD10", Offset = "0x1A2BD10", VA = "0x1A2BD10")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1A2BA10", Offset = "0x1A2BA10", VA = "0x1A2BA10")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1A2B524", Offset = "0x1A2B524", VA = "0x1A2B524")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1A2C3B0", Offset = "0x1A2C3B0", VA = "0x1A2C3B0")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1A2C530", Offset = "0x1A2C530", VA = "0x1A2C530")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class HeadBob : MonoBehaviour
	{
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x18")]
		public Camera Camera;

		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x20")]
		public CurveControlledBob motionBob;

		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x28")]
		public LerpControlledBob jumpAndLandingBob;

		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x30")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x38")]
		public float StrideInterval;

		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3D450", Offset = "0xB3D450")]
		public float RunningStrideLengthen;

		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1A2C638", Offset = "0x1A2C638", VA = "0x1A2C638")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1A2C694", Offset = "0x1A2C694", VA = "0x1A2C694")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1A2C8E4", Offset = "0x1A2C8E4", VA = "0x1A2C8E4")]
		public HeadBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public class MouseLook
	{
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1A2B3B8", Offset = "0x1A2B3B8", VA = "0x1A2B3B8")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1A2C0C0", Offset = "0x1A2C0C0", VA = "0x1A2C0C0")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1A2CA4C", Offset = "0x1A2CA4C", VA = "0x1A2CA4C")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1A2BED8", Offset = "0x1A2BED8", VA = "0x1A2BED8")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1A2CA80", Offset = "0x1A2CA80", VA = "0x1A2CA80")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1A2C984", Offset = "0x1A2C984", VA = "0x1A2C984")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1A2CAFC", Offset = "0x1A2CAFC", VA = "0x1A2CAFC")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3CCE4", Offset = "0xB3CCE4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3CCE4", Offset = "0xB3CCE4")]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000096")]
		public class MovementSettings
		{
			[Token(Token = "0x40003A6")]
			[FieldOffset(Offset = "0x10")]
			public float ForwardSpeed;

			[Token(Token = "0x40003A7")]
			[FieldOffset(Offset = "0x14")]
			public float BackwardSpeed;

			[Token(Token = "0x40003A8")]
			[FieldOffset(Offset = "0x18")]
			public float StrafeSpeed;

			[Token(Token = "0x40003A9")]
			[FieldOffset(Offset = "0x1C")]
			public float RunMultiplier;

			[Token(Token = "0x40003AA")]
			[FieldOffset(Offset = "0x20")]
			public KeyCode RunKey;

			[Token(Token = "0x40003AB")]
			[FieldOffset(Offset = "0x24")]
			public float JumpForce;

			[Token(Token = "0x40003AC")]
			[FieldOffset(Offset = "0x28")]
			public AnimationCurve SlopeCurveModifier;

			[Token(Token = "0x40003AD")]
			[FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public float CurrentTargetSpeed;

			[Token(Token = "0x40003AE")]
			[FieldOffset(Offset = "0x34")]
			private bool m_Running;

			[Token(Token = "0x17000030")]
			public bool Running
			{
				[Token(Token = "0x6000262")]
				[Address(RVA = "0x1A2DC78", Offset = "0x1A2DC78", VA = "0x1A2DC78")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000261")]
			[Address(RVA = "0x1A2D894", Offset = "0x1A2D894", VA = "0x1A2D894")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0x1A2DA98", Offset = "0x1A2DA98", VA = "0x1A2DA98")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000097")]
		public class AdvancedSettings
		{
			[Token(Token = "0x40003AF")]
			[FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			[Token(Token = "0x40003B0")]
			[FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x40003B1")]
			[FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			[Token(Token = "0x40003B2")]
			[FieldOffset(Offset = "0x1C")]
			public bool airControl;

			[Token(Token = "0x40003B3")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3D4B8", Offset = "0xB3D4B8")]
			public float shellOffset;

			[Token(Token = "0x6000264")]
			[Address(RVA = "0x1A2DC5C", Offset = "0x1A2DC5C", VA = "0x1A2DC5C")]
			public AdvancedSettings()
			{
			}
		}

		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x18")]
		public Camera cam;

		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x20")]
		public MovementSettings movementSettings;

		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x28")]
		public MouseLook mouseLook;

		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x30")]
		public AdvancedSettings advancedSettings;

		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x40")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x48")]
		private float m_YRotation;

		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 m_GroundContactNormal;

		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x58")]
		private bool m_Jump;

		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x59")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x5A")]
		private bool m_Jumping;

		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x5B")]
		private bool m_IsGrounded;

		[Token(Token = "0x17000011")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x1A2C8AC", Offset = "0x1A2C8AC", VA = "0x1A2C8AC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000012")]
		public bool Grounded
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x1A2CB30", Offset = "0x1A2CB30", VA = "0x1A2CB30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		public bool Jumping
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x1A2CB38", Offset = "0x1A2CB38", VA = "0x1A2CB38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000014")]
		public bool Running
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x1A2C8C8", Offset = "0x1A2C8C8", VA = "0x1A2C8C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1A2CB40", Offset = "0x1A2CB40", VA = "0x1A2CB40")]
		private void Start()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1A2CC04", Offset = "0x1A2CC04", VA = "0x1A2CC04")]
		private void Update()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1A2CE98", Offset = "0x1A2CE98", VA = "0x1A2CE98")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1A2D55C", Offset = "0x1A2D55C", VA = "0x1A2D55C")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1A2D614", Offset = "0x1A2D614", VA = "0x1A2D614")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1A2D4AC", Offset = "0x1A2D4AC", VA = "0x1A2D4AC")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1A2CC90", Offset = "0x1A2CC90", VA = "0x1A2CC90")]
		private void RotateView()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1A2D2C4", Offset = "0x1A2D2C4", VA = "0x1A2D2C4")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1A2D990", Offset = "0x1A2D990", VA = "0x1A2D990")]
		public RigidbodyFirstPersonController()
		{
		}
	}
}
