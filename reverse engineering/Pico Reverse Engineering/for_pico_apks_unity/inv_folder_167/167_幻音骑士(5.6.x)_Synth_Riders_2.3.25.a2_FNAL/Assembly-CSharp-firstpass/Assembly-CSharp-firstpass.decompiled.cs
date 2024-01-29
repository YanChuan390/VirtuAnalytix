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
	[Address(RVA = "0x1910378", Offset = "0x1910378", VA = "0x1910378")]
	public void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1910538", Offset = "0x1910538", VA = "0x1910538", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1910844", Offset = "0x1910844", VA = "0x1910844")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000003")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x191084C", Offset = "0x191084C", VA = "0x191084C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1910928", Offset = "0x1910928", VA = "0x1910928")]
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
		[Address(RVA = "0x1D79864", Offset = "0x1D79864", VA = "0x1D79864")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x1D79CCC", Offset = "0x1D79CCC", VA = "0x1D79CCC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1D79CD0", Offset = "0x1D79CD0", VA = "0x1D79CD0")]
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
			[Address(RVA = "0x1D7A71C", Offset = "0x1D7A71C", VA = "0x1D7A71C")]
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
			[Address(RVA = "0x1D7A724", Offset = "0x1D7A724", VA = "0x1D7A724")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1D79CE8", Offset = "0x1D79CE8", VA = "0x1D79CE8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1D7A714", Offset = "0x1D7A714", VA = "0x1D7A714")]
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
			[Address(RVA = "0x1D7AA40", Offset = "0x1D7AA40", VA = "0x1D7AA40")]
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
			[Address(RVA = "0x1D7A790", Offset = "0x1D7A790", VA = "0x1D7A790")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public new GameObject gameObject
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x1D7A834", Offset = "0x1D7A834", VA = "0x1D7A834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1D7A8D8", Offset = "0x1D7A8D8", VA = "0x1D7A8D8")]
		private void Start()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1D7A900", Offset = "0x1D7A900", VA = "0x1D7A900")]
		private void Update()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1D7AA38", Offset = "0x1D7AA38", VA = "0x1D7AA38")]
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
		[Address(RVA = "0x1D7AA50", Offset = "0x1D7AA50", VA = "0x1D7AA50")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1D7AAC4", Offset = "0x1D7AAC4", VA = "0x1D7AAC4")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1D7AACC", Offset = "0x1D7AACC", VA = "0x1D7AACC")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1D7AAD4", Offset = "0x1D7AAD4", VA = "0x1D7AAD4")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1D7AC34", Offset = "0x1D7AC34", VA = "0x1D7AC34")]
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
		[Address(RVA = "0x1D7AC88", Offset = "0x1D7AC88", VA = "0x1D7AC88")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1D7AD2C", Offset = "0x1D7AD2C", VA = "0x1D7AD2C")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1D7AE4C", Offset = "0x1D7AE4C", VA = "0x1D7AE4C")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB81514", Offset = "0xB81514")]
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
				[Address(RVA = "0x1D7B7D8", Offset = "0x1D7B7D8", VA = "0x1D7B7D8", Slot = "4")]
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
				[Address(RVA = "0x1D7B840", Offset = "0x1D7B840", VA = "0x1D7B840", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x1D7B548", Offset = "0x1D7B548", VA = "0x1D7B548")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x1D7B57C", Offset = "0x1D7B57C", VA = "0x1D7B57C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x1D7B580", Offset = "0x1D7B580", VA = "0x1D7B580", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x1D7B7E0", Offset = "0x1D7B7E0", VA = "0x1D7B7E0", Slot = "8")]
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
		[Address(RVA = "0x1D7B098", Offset = "0x1D7B098", VA = "0x1D7B098")]
		private void Update()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1D7B4BC", Offset = "0x1D7B4BC", VA = "0x1D7B4BC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB8964C", Offset = "0xB8964C")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1D7B40C", Offset = "0x1D7B40C", VA = "0x1D7B40C")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1D7B574", Offset = "0x1D7B574", VA = "0x1D7B574")]
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
		[Address(RVA = "0x1D7B848", Offset = "0x1D7B848", VA = "0x1D7B848")]
		private void Start()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1D7B87C", Offset = "0x1D7B87C", VA = "0x1D7B87C")]
		private void Update()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1D7BAF0", Offset = "0x1D7BAF0", VA = "0x1D7BAF0")]
		public DynamicShadowSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public class FOVKick
	{
		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB81524", Offset = "0xB81524")]
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
				[Address(RVA = "0x1D7C128", Offset = "0x1D7C128", VA = "0x1D7C128", Slot = "4")]
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
				[Address(RVA = "0x1D7C190", Offset = "0x1D7C190", VA = "0x1D7C190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x1D7BCD4", Offset = "0x1D7BCD4", VA = "0x1D7BCD4")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x1D7BFB8", Offset = "0x1D7BFB8", VA = "0x1D7BFB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x1D7BFBC", Offset = "0x1D7BFBC", VA = "0x1D7BFBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x1D7C130", Offset = "0x1D7C130", VA = "0x1D7C130", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB81534", Offset = "0xB81534")]
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
				[Address(RVA = "0x1D7BF48", Offset = "0x1D7BF48", VA = "0x1D7BF48", Slot = "4")]
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
				[Address(RVA = "0x1D7BFB0", Offset = "0x1D7BFB0", VA = "0x1D7BFB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x1D7BD7C", Offset = "0x1D7BD7C", VA = "0x1D7BD7C")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x1D7BDC4", Offset = "0x1D7BDC4", VA = "0x1D7BDC4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x1D7BDC8", Offset = "0x1D7BDC8", VA = "0x1D7BDC8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x1D7BF50", Offset = "0x1D7BF50", VA = "0x1D7BF50", Slot = "8")]
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
		[Address(RVA = "0x1D7BB24", Offset = "0x1D7BB24", VA = "0x1D7BB24")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1D7BB70", Offset = "0x1D7BB70", VA = "0x1D7BB70")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1D7BC50", Offset = "0x1D7BC50", VA = "0x1D7BC50")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1D7BC58", Offset = "0x1D7BC58", VA = "0x1D7BC58")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB896B0", Offset = "0xB896B0")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1D7BD00", Offset = "0x1D7BD00", VA = "0x1D7BD00")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB89714", Offset = "0xB89714")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1D7BDA8", Offset = "0x1D7BDA8", VA = "0x1D7BDA8")]
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
		[Address(RVA = "0x1D7C198", Offset = "0x1D7C198", VA = "0x1D7C198")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1D7C278", Offset = "0x1D7C278", VA = "0x1D7C278")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public class LerpControlledBob
	{
		[Token(Token = "0x20000D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB81544", Offset = "0xB81544")]
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
				[Address(RVA = "0x1D7C58C", Offset = "0x1D7C58C", VA = "0x1D7C58C", Slot = "4")]
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
				[Address(RVA = "0x1D7C5F4", Offset = "0x1D7C5F4", VA = "0x1D7C5F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x1D7C35C", Offset = "0x1D7C35C", VA = "0x1D7C35C")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x1D7C390", Offset = "0x1D7C390", VA = "0x1D7C390", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x1D7C394", Offset = "0x1D7C394", VA = "0x1D7C394", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x1D7C594", Offset = "0x1D7C594", VA = "0x1D7C594", Slot = "8")]
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
		[Address(RVA = "0x1D7C2D8", Offset = "0x1D7C2D8", VA = "0x1D7C2D8")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1D7C2E0", Offset = "0x1D7C2E0", VA = "0x1D7C2E0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB89778", Offset = "0xB89778")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1D7C388", Offset = "0x1D7C388", VA = "0x1D7C388")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB81554", Offset = "0xB81554")]
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
				[Address(RVA = "0x1D7CA28", Offset = "0x1D7CA28", VA = "0x1D7CA28", Slot = "4")]
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
				[Address(RVA = "0x1D7CA90", Offset = "0x1D7CA90", VA = "0x1D7CA90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x1D7C7B4", Offset = "0x1D7C7B4", VA = "0x1D7C7B4")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x1D7C7E8", Offset = "0x1D7C7E8", VA = "0x1D7C7E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x1D7C7EC", Offset = "0x1D7C7EC", VA = "0x1D7C7EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x1D7CA30", Offset = "0x1D7CA30", VA = "0x1D7CA30", Slot = "8")]
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
		[Address(RVA = "0x1D7C5FC", Offset = "0x1D7C5FC", VA = "0x1D7C5FC")]
		private void Start()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1D7C6FC", Offset = "0x1D7C6FC", VA = "0x1D7C6FC")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1D7C728", Offset = "0x1D7C728", VA = "0x1D7C728")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB897DC", Offset = "0xB897DC")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1D7C7E0", Offset = "0x1D7C7E0", VA = "0x1D7C7E0")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x20000D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB81564", Offset = "0xB81564")]
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
				[Address(RVA = "0x1D7CEC0", Offset = "0x1D7CEC0", VA = "0x1D7CEC0", Slot = "4")]
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
				[Address(RVA = "0x1D7CF28", Offset = "0x1D7CF28", VA = "0x1D7CF28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x1D7CB14", Offset = "0x1D7CB14", VA = "0x1D7CB14")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0x1D7CB60", Offset = "0x1D7CB60", VA = "0x1D7CB60", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0x1D7CB64", Offset = "0x1D7CB64", VA = "0x1D7CB64", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x1D7CEC8", Offset = "0x1D7CEC8", VA = "0x1D7CEC8", Slot = "8")]
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
		[Address(RVA = "0x1D7CA98", Offset = "0x1D7CA98", VA = "0x1D7CA98")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB89840", Offset = "0xB89840")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1D7CB40", Offset = "0x1D7CB40", VA = "0x1D7CB40")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1D7CB4C", Offset = "0x1D7CB4C", VA = "0x1D7CB4C")]
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
		[Address(RVA = "0x1D7CF30", Offset = "0x1D7CF30", VA = "0x1D7CF30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1D7CF34", Offset = "0x1D7CF34", VA = "0x1D7CF34")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1D7CF50", Offset = "0x1D7CF50", VA = "0x1D7CF50")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1D7D2AC", Offset = "0x1D7D2AC", VA = "0x1D7D2AC")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1D7D33C", Offset = "0x1D7D33C", VA = "0x1D7D33C")]
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
		[Address(RVA = "0x1D7D344", Offset = "0x1D7D344", VA = "0x1D7D344")]
		private void Start()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1D7D348", Offset = "0x1D7D348", VA = "0x1D7D348")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1D7D674", Offset = "0x1D7D674", VA = "0x1D7D674")]
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
			[Address(RVA = "0x1D7DE30", Offset = "0x1D7DE30", VA = "0x1D7DE30")]
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
			[Address(RVA = "0x1D7DA20", Offset = "0x1D7DA20", VA = "0x1D7DA20")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB81574", Offset = "0xB81574")]
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
				[Address(RVA = "0x1D7DB00", Offset = "0x1D7DB00", VA = "0x1D7DB00", Slot = "4")]
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
				[Address(RVA = "0x1D7DB68", Offset = "0x1D7DB68", VA = "0x1D7DB68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x1D7D928", Offset = "0x1D7D928", VA = "0x1D7D928")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0x1D7DA28", Offset = "0x1D7DA28", VA = "0x1D7DA28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000621")]
			[Address(RVA = "0x1D7DA2C", Offset = "0x1D7DA2C", VA = "0x1D7DA2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x1D7DB08", Offset = "0x1D7DB08", VA = "0x1D7DB08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB81584", Offset = "0xB81584")]
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
				[Address(RVA = "0x1D7DC48", Offset = "0x1D7DC48", VA = "0x1D7DC48", Slot = "4")]
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
				[Address(RVA = "0x1D7DCB0", Offset = "0x1D7DCB0", VA = "0x1D7DCB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000625")]
			[Address(RVA = "0x1D7D954", Offset = "0x1D7D954", VA = "0x1D7D954")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000626")]
			[Address(RVA = "0x1D7DB70", Offset = "0x1D7DB70", VA = "0x1D7DB70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x1D7DB74", Offset = "0x1D7DB74", VA = "0x1D7DB74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x1D7DC50", Offset = "0x1D7DC50", VA = "0x1D7DC50", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB81594", Offset = "0xB81594")]
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
				[Address(RVA = "0x1D7DDC0", Offset = "0x1D7DDC0", VA = "0x1D7DDC0", Slot = "4")]
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
				[Address(RVA = "0x1D7DE28", Offset = "0x1D7DE28", VA = "0x1D7DE28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x1D7D980", Offset = "0x1D7D980", VA = "0x1D7D980")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x1D7DCB8", Offset = "0x1D7DCB8", VA = "0x1D7DCB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x1D7DCBC", Offset = "0x1D7DCBC", VA = "0x1D7DCBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x1D7DDC8", Offset = "0x1D7DDC8", VA = "0x1D7DDC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1D7D688", Offset = "0x1D7D688", VA = "0x1D7D688")]
		private void Awake()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1D7D7B4", Offset = "0x1D7D7B4", VA = "0x1D7D7B4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB898A4", Offset = "0xB898A4")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1D7D830", Offset = "0x1D7D830", VA = "0x1D7D830")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB89908", Offset = "0xB89908")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1D7D8AC", Offset = "0x1D7D8AC", VA = "0x1D7D8AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB8996C", Offset = "0xB8996C")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1D7D9AC", Offset = "0x1D7D9AC", VA = "0x1D7D9AC")]
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
		[Address(RVA = "0x1D7DE38", Offset = "0x1D7DE38", VA = "0x1D7DE38")]
		private void Awake()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1D7DE90", Offset = "0x1D7DE90", VA = "0x1D7DE90")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1D7DF30", Offset = "0x1D7DF30", VA = "0x1D7DF30")]
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
			[Address(RVA = "0x1D7EDAC", Offset = "0x1D7EDAC", VA = "0x1D7EDAC")]
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
			[Address(RVA = "0x1D7E724", Offset = "0x1D7E724", VA = "0x1D7E724")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB81724", Offset = "0xB81724")]
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
			[Address(RVA = "0x1D7DF40", Offset = "0x1D7DF40", VA = "0x1D7DF40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB899D0", Offset = "0xB899D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x1D7DF48", Offset = "0x1D7DF48", VA = "0x1D7DF48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB899E0", Offset = "0xB899E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x1D7DF50", Offset = "0x1D7DF50", VA = "0x1D7DF50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1D7DF6C", Offset = "0x1D7DF6C", VA = "0x1D7DF6C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1D7E2BC", Offset = "0x1D7E2BC", VA = "0x1D7E2BC")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1D7E3CC", Offset = "0x1D7E3CC", VA = "0x1D7E3CC")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1D7E734", Offset = "0x1D7E734", VA = "0x1D7E734")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1D7DFC8", Offset = "0x1D7DFC8", VA = "0x1D7DFC8")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1D7EA9C", Offset = "0x1D7EA9C", VA = "0x1D7EA9C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1D7ED24", Offset = "0x1D7ED24", VA = "0x1D7ED24")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1D7EAA4", Offset = "0x1D7EAA4", VA = "0x1D7EAA4")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1D7ED2C", Offset = "0x1D7ED2C", VA = "0x1D7ED2C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB817A4", Offset = "0xB817A4")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB817B4", Offset = "0xB817B4")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB817C4", Offset = "0xB817C4")]
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
			[Address(RVA = "0x1D7EE18", Offset = "0x1D7EE18", VA = "0x1D7EE18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB899F0", Offset = "0xB899F0")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x1D7EE2C", Offset = "0x1D7EE2C", VA = "0x1D7EE2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89A00", Offset = "0xB89A00")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x1D7EE40", Offset = "0x1D7EE40", VA = "0x1D7EE40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89A10", Offset = "0xB89A10")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x1D7EE54", Offset = "0x1D7EE54", VA = "0x1D7EE54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89A20", Offset = "0xB89A20")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x1D7EE68", Offset = "0x1D7EE68", VA = "0x1D7EE68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89A30", Offset = "0xB89A30")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x1D7EE7C", Offset = "0x1D7EE7C", VA = "0x1D7EE7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89A40", Offset = "0xB89A40")]
			private set
			{
			}
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1D7EE90", Offset = "0x1D7EE90", VA = "0x1D7EE90")]
		private void Start()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1D7EF84", Offset = "0x1D7EF84", VA = "0x1D7EF84")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1D7F05C", Offset = "0x1D7F05C", VA = "0x1D7F05C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1D7F5C4", Offset = "0x1D7F5C4", VA = "0x1D7F5C4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1D7F79C", Offset = "0x1D7F79C", VA = "0x1D7F79C")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB805E0", Offset = "0xB805E0")]
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
		[Address(RVA = "0x1D77504", Offset = "0x1D77504", VA = "0x1D77504")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1D775A0", Offset = "0x1D775A0", VA = "0x1D775A0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1D77A60", Offset = "0x1D77A60", VA = "0x1D77A60")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1D77FA8", Offset = "0x1D77FA8", VA = "0x1D77FA8")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB815A4", Offset = "0xB815A4")]
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
				[Address(RVA = "0x1D787EC", Offset = "0x1D787EC", VA = "0x1D787EC", Slot = "4")]
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
				[Address(RVA = "0x1D78854", Offset = "0x1D78854", VA = "0x1D78854", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x1D78038", Offset = "0x1D78038", VA = "0x1D78038")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x1D781F0", Offset = "0x1D781F0", VA = "0x1D781F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x1D781F4", Offset = "0x1D781F4", VA = "0x1D781F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x1D787F4", Offset = "0x1D787F4", VA = "0x1D787F4", Slot = "8")]
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
		[Address(RVA = "0x1D77FBC", Offset = "0x1D77FBC", VA = "0x1D77FBC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB89A50", Offset = "0xB89A50")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1D78064", Offset = "0x1D78064", VA = "0x1D78064")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1D781E8", Offset = "0x1D781E8", VA = "0x1D781E8")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB815B4", Offset = "0xB815B4")]
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
				[Address(RVA = "0x1D78C30", Offset = "0x1D78C30", VA = "0x1D78C30", Slot = "4")]
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
				[Address(RVA = "0x1D78C98", Offset = "0x1D78C98", VA = "0x1D78C98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x1D788D8", Offset = "0x1D788D8", VA = "0x1D788D8")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x1D78914", Offset = "0x1D78914", VA = "0x1D78914", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x1D78918", Offset = "0x1D78918", VA = "0x1D78918", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x1D78C38", Offset = "0x1D78C38", VA = "0x1D78C38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1D7885C", Offset = "0x1D7885C", VA = "0x1D7885C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB89AB4", Offset = "0xB89AB4")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1D78904", Offset = "0x1D78904", VA = "0x1D78904")]
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
		[Address(RVA = "0x1D78CA0", Offset = "0x1D78CA0", VA = "0x1D78CA0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1D78D00", Offset = "0x1D78D00", VA = "0x1D78D00")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1D78D8C", Offset = "0x1D78D8C", VA = "0x1D78D8C")]
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
		[Address(RVA = "0x1D78D9C", Offset = "0x1D78D9C", VA = "0x1D78D9C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1D78E14", Offset = "0x1D78E14", VA = "0x1D78E14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1D79074", Offset = "0x1D79074", VA = "0x1D79074")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1D7909C", Offset = "0x1D7909C", VA = "0x1D7909C")]
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
		[Address(RVA = "0x1D790AC", Offset = "0x1D790AC", VA = "0x1D790AC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1D79270", Offset = "0x1D79270", VA = "0x1D79270")]
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
		[Address(RVA = "0x1D7928C", Offset = "0x1D7928C", VA = "0x1D7928C")]
		private void Start()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1D79418", Offset = "0x1D79418", VA = "0x1D79418")]
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
		[Address(RVA = "0x1D79428", Offset = "0x1D79428", VA = "0x1D79428")]
		private void Start()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1D794E8", Offset = "0x1D794E8", VA = "0x1D794E8")]
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
		[Address(RVA = "0x1D794F0", Offset = "0x1D794F0", VA = "0x1D794F0")]
		private void Start()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1D79550", Offset = "0x1D79550", VA = "0x1D79550")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1D797E0", Offset = "0x1D797E0", VA = "0x1D797E0")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB817D4", Offset = "0xB817D4")]
		public bool smoothFollow;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB8180C", Offset = "0xB8180C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB81844", Offset = "0xB81844")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB8187C", Offset = "0xB8187C")]
		public LayerMask blockingLayers;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB818B4", Offset = "0xB818B4")]
		public float blockedOffset;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB818CC", Offset = "0xB818CC")]
		private float <x>k__BackingField;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB818DC", Offset = "0xB818DC")]
		private float <y>k__BackingField;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB818EC", Offset = "0xB818EC")]
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
			[Address(RVA = "0x19182B0", Offset = "0x19182B0", VA = "0x19182B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89B18", Offset = "0xB89B18")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x19182B8", Offset = "0x19182B8", VA = "0x19182B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89B28", Offset = "0xB89B28")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public float y
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x19182C0", Offset = "0x19182C0", VA = "0x19182C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89B38", Offset = "0xB89B38")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x19182C8", Offset = "0x19182C8", VA = "0x19182C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89B48", Offset = "0xB89B48")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public float distanceTarget
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x19182D0", Offset = "0x19182D0", VA = "0x19182D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89B58", Offset = "0xB89B58")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x19182D8", Offset = "0x19182D8", VA = "0x19182D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89B68", Offset = "0xB89B68")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		private float zoomAdd
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x1918D4C", Offset = "0x1918D4C", VA = "0x1918D4C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x19182E0", Offset = "0x19182E0", VA = "0x19182E0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1918408", Offset = "0x1918408", VA = "0x1918408", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1918464", Offset = "0x1918464", VA = "0x1918464", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x19184CC", Offset = "0x19184CC", VA = "0x19184CC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1918530", Offset = "0x1918530", VA = "0x1918530")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x191843C", Offset = "0x191843C", VA = "0x191843C")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x19186B0", Offset = "0x19186B0", VA = "0x19186B0")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1918C9C", Offset = "0x1918C9C", VA = "0x1918C9C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1918DC0", Offset = "0x1918DC0", VA = "0x1918DC0")]
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
		[Address(RVA = "0x1918ED0", Offset = "0x1918ED0", VA = "0x1918ED0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1918F08", Offset = "0x1918F08", VA = "0x1918F08")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x19190C0", Offset = "0x19190C0", VA = "0x19190C0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1919170", Offset = "0x1919170", VA = "0x1919170")]
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
		[Address(RVA = "0x1910930", Offset = "0x1910930", VA = "0x1910930")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x19109E8", Offset = "0x19109E8", VA = "0x19109E8")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1910A94", Offset = "0x1910A94", VA = "0x1910A94")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1910C78", Offset = "0x1910C78", VA = "0x1910C78")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1910BB0", Offset = "0x1910BB0", VA = "0x1910BB0")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1910D94", Offset = "0x1910D94", VA = "0x1910D94")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1910FC0", Offset = "0x1910FC0", VA = "0x1910FC0")]
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
			[Address(RVA = "0x19112C0", Offset = "0x19112C0", VA = "0x19112C0")]
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
			[Address(RVA = "0x1911048", Offset = "0x1911048", VA = "0x1911048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x1911338", Offset = "0x1911338", VA = "0x1911338")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1910FC8", Offset = "0x1910FC8", VA = "0x1910FC8")]
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
		[Address(RVA = "0x19115B0", Offset = "0x19115B0", VA = "0x19115B0")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x19118B8", Offset = "0x19118B8", VA = "0x19118B8")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1911B10", Offset = "0x1911B10", VA = "0x1911B10")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1911B94", Offset = "0x1911B94", VA = "0x1911B94")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1911C40", Offset = "0x1911C40", VA = "0x1911C40")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1911768", Offset = "0x1911768", VA = "0x1911768")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1911A70", Offset = "0x1911A70", VA = "0x1911A70")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1912480", Offset = "0x1912480", VA = "0x1912480")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1912298", Offset = "0x1912298", VA = "0x1912298")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x191238C", Offset = "0x191238C", VA = "0x191238C")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1911E60", Offset = "0x1911E60", VA = "0x1911E60")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1911F14", Offset = "0x1911F14", VA = "0x1911F14")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1911FC8", Offset = "0x1911FC8", VA = "0x1911FC8")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x191207C", Offset = "0x191207C", VA = "0x191207C")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1912130", Offset = "0x1912130", VA = "0x1912130")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x19121E4", Offset = "0x19121E4", VA = "0x19121E4")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1912694", Offset = "0x1912694", VA = "0x1912694")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1911D74", Offset = "0x1911D74", VA = "0x1911D74")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1912604", Offset = "0x1912604", VA = "0x1912604")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1912704", Offset = "0x1912704", VA = "0x1912704")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x19127DC", Offset = "0x19127DC", VA = "0x19127DC")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1912588", Offset = "0x1912588", VA = "0x1912588")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1912510", Offset = "0x1912510", VA = "0x1912510")]
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
				[Address(RVA = "0x19182A8", Offset = "0x19182A8", VA = "0x19182A8")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x1918294", Offset = "0x1918294", VA = "0x1918294")]
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
			[Address(RVA = "0x1914B74", Offset = "0x1914B74", VA = "0x1914B74", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		public bool isEmpty
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x1914F60", Offset = "0x1914F60", VA = "0x1914F60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1914F70", Offset = "0x1914F70", VA = "0x1914F70", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x191539C", Offset = "0x191539C", VA = "0x191539C", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x19157D4", Offset = "0x19157D4", VA = "0x19157D4")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1915EE0", Offset = "0x1915EE0", VA = "0x1915EE0")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1915A50", Offset = "0x1915A50", VA = "0x1915A50")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1916714", Offset = "0x1916714", VA = "0x1916714")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1916814", Offset = "0x1916814", VA = "0x1916814")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1916DC8", Offset = "0x1916DC8", VA = "0x1916DC8")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1916BB8", Offset = "0x1916BB8", VA = "0x1916BB8")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1916A30", Offset = "0x1916A30", VA = "0x1916A30")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x19168B4", Offset = "0x19168B4", VA = "0x19168B4")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1916CBC", Offset = "0x1916CBC", VA = "0x1916CBC")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1916EC4", Offset = "0x1916EC4", VA = "0x1916EC4")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1917A28", Offset = "0x1917A28", VA = "0x1917A28")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x19174F4", Offset = "0x19174F4", VA = "0x19174F4")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1917D70", Offset = "0x1917D70", VA = "0x1917D70")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1917840", Offset = "0x1917840", VA = "0x1917840")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1917D78", Offset = "0x1917D78", VA = "0x1917D78")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1917D80", Offset = "0x1917D80", VA = "0x1917D80")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1917F4C", Offset = "0x1917F4C", VA = "0x1917F4C")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1918170", Offset = "0x1918170", VA = "0x1918170")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x19159C8", Offset = "0x19159C8", VA = "0x19159C8")]
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
		[Address(RVA = "0x191918C", Offset = "0x191918C", VA = "0x191918C")]
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
		[Address(RVA = "0x1919194", Offset = "0x1919194", VA = "0x1919194")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x19192D4", Offset = "0x19192D4", VA = "0x19192D4")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class Hierarchy
	{
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1D72980", Offset = "0x1D72980", VA = "0x1D72980")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1D72B80", Offset = "0x1D72B80", VA = "0x1D72B80")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1D72A18", Offset = "0x1D72A18", VA = "0x1D72A18")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1D72CA4", Offset = "0x1D72CA4", VA = "0x1D72CA4")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1D72DC8", Offset = "0x1D72DC8", VA = "0x1D72DC8")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1D73078", Offset = "0x1D73078", VA = "0x1D73078")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1D73194", Offset = "0x1D73194", VA = "0x1D73194")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1D7331C", Offset = "0x1D7331C", VA = "0x1D7331C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1D736B0", Offset = "0x1D736B0", VA = "0x1D736B0")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1D7349C", Offset = "0x1D7349C", VA = "0x1D7349C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1D73850", Offset = "0x1D73850", VA = "0x1D73850")]
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
		[Address(RVA = "0x1D73858", Offset = "0x1D73858", VA = "0x1D73858")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1D738E8", Offset = "0x1D738E8", VA = "0x1D738E8")]
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
		[Address(RVA = "0x1D7397C", Offset = "0x1D7397C", VA = "0x1D7397C")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1D743E4", Offset = "0x1D743E4", VA = "0x1D743E4")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1D744EC", Offset = "0x1D744EC", VA = "0x1D744EC")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1D73CE8", Offset = "0x1D73CE8", VA = "0x1D73CE8")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1D73CF4", Offset = "0x1D73CF4", VA = "0x1D73CF4")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1D73D18", Offset = "0x1D73D18", VA = "0x1D73D18")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1D73D54", Offset = "0x1D73D54", VA = "0x1D73D54")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1D73D6C", Offset = "0x1D73D6C", VA = "0x1D73D6C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1D73D80", Offset = "0x1D73D80", VA = "0x1D73D80")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1D73D94", Offset = "0x1D73D94", VA = "0x1D73D94")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1D73DA4", Offset = "0x1D73DA4", VA = "0x1D73DA4")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1D73DEC", Offset = "0x1D73DEC", VA = "0x1D73DEC")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1D73E24", Offset = "0x1D73E24", VA = "0x1D73E24")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1D73E4C", Offset = "0x1D73E4C", VA = "0x1D73E4C")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1D745E8", Offset = "0x1D745E8", VA = "0x1D745E8")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1D73E80", Offset = "0x1D73E80", VA = "0x1D73E80")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1D73EA8", Offset = "0x1D73EA8", VA = "0x1D73EA8")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1D73ED8", Offset = "0x1D73ED8", VA = "0x1D73ED8")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1D73F0C", Offset = "0x1D73F0C", VA = "0x1D73F0C")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1D73F50", Offset = "0x1D73F50", VA = "0x1D73F50")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1D73FB4", Offset = "0x1D73FB4", VA = "0x1D73FB4")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1D74018", Offset = "0x1D74018", VA = "0x1D74018")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1D7406C", Offset = "0x1D7406C", VA = "0x1D7406C")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1D740C0", Offset = "0x1D740C0", VA = "0x1D740C0")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1D74158", Offset = "0x1D74158", VA = "0x1D74158")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1D741EC", Offset = "0x1D741EC", VA = "0x1D741EC")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1D7461C", Offset = "0x1D7461C", VA = "0x1D7461C")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1D74290", Offset = "0x1D74290", VA = "0x1D74290")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1D74374", Offset = "0x1D74374", VA = "0x1D74374")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1D743A4", Offset = "0x1D743A4", VA = "0x1D743A4")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1D74704", Offset = "0x1D74704", VA = "0x1D74704")]
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
		[Address(RVA = "0x1D7470C", Offset = "0x1D7470C", VA = "0x1D7470C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1D7479C", Offset = "0x1D7479C", VA = "0x1D7479C")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200002E")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1D74830", Offset = "0x1D74830", VA = "0x1D74830")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1D74888", Offset = "0x1D74888", VA = "0x1D74888")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1D74954", Offset = "0x1D74954", VA = "0x1D74954")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1D748A0", Offset = "0x1D748A0", VA = "0x1D748A0")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1D7496C", Offset = "0x1D7496C", VA = "0x1D7496C")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1D74A10", Offset = "0x1D74A10", VA = "0x1D74A10")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1D74A3C", Offset = "0x1D74A3C", VA = "0x1D74A3C")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1D74A8C", Offset = "0x1D74A8C", VA = "0x1D74A8C")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1D74AF8", Offset = "0x1D74AF8", VA = "0x1D74AF8")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1D74BEC", Offset = "0x1D74BEC", VA = "0x1D74BEC")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1D74CC4", Offset = "0x1D74CC4", VA = "0x1D74CC4")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1D74D24", Offset = "0x1D74D24", VA = "0x1D74D24")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200002F")]
	public static class QuaTools
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1D74D54", Offset = "0x1D74D54", VA = "0x1D74D54")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1D74EA0", Offset = "0x1D74EA0", VA = "0x1D74EA0")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1D74FEC", Offset = "0x1D74FEC", VA = "0x1D74FEC")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1D75100", Offset = "0x1D75100", VA = "0x1D75100")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1D75214", Offset = "0x1D75214", VA = "0x1D75214")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1D753A0", Offset = "0x1D753A0", VA = "0x1D753A0")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1D75470", Offset = "0x1D75470", VA = "0x1D75470")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1D755C4", Offset = "0x1D755C4", VA = "0x1D755C4")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1D75848", Offset = "0x1D75848", VA = "0x1D75848")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1D75A5C", Offset = "0x1D75A5C", VA = "0x1D75A5C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1D70624", Offset = "0x1D70624", VA = "0x1D70624")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8190C", Offset = "0xB8190C")]
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
			[Address(RVA = "0x1D75D14", Offset = "0x1D75D14", VA = "0x1D75D14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000012")]
		private bool isAnimated
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x1D76048", Offset = "0x1D76048", VA = "0x1D76048")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1D75BDC", Offset = "0x1D75BDC", VA = "0x1D75BDC")]
		public void Disable()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1D75C74", Offset = "0x1D75C74", VA = "0x1D75C74", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1D75C78", Offset = "0x1D75C78", VA = "0x1D75C78", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1D75C7C", Offset = "0x1D75C7C", VA = "0x1D75C7C", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1D75C80", Offset = "0x1D75C80", VA = "0x1D75C80")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1D75D10", Offset = "0x1D75D10", VA = "0x1D75D10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1D75CB8", Offset = "0x1D75CB8", VA = "0x1D75CB8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1D75FFC", Offset = "0x1D75FFC", VA = "0x1D75FFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1D75E04", Offset = "0x1D75E04", VA = "0x1D75E04")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1D76104", Offset = "0x1D76104", VA = "0x1D76104")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1D76160", Offset = "0x1D76160", VA = "0x1D76160")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1D761BC", Offset = "0x1D761BC", VA = "0x1D761BC")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1D76204", Offset = "0x1D76204", VA = "0x1D76204")]
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
		[Address(RVA = "0x1D76214", Offset = "0x1D76214", VA = "0x1D76214")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1D762CC", Offset = "0x1D762CC", VA = "0x1D762CC")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1D76384", Offset = "0x1D76384", VA = "0x1D76384")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1D7643C", Offset = "0x1D7643C", VA = "0x1D7643C")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public static class V3Tools
	{
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1D76444", Offset = "0x1D76444", VA = "0x1D76444")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1D7653C", Offset = "0x1D7653C", VA = "0x1D7653C")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1D76634", Offset = "0x1D76634", VA = "0x1D76634")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1D7672C", Offset = "0x1D7672C", VA = "0x1D7672C")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1D7682C", Offset = "0x1D7682C", VA = "0x1D7682C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1D76A68", Offset = "0x1D76A68", VA = "0x1D76A68")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1D76CB8", Offset = "0x1D76CB8", VA = "0x1D76CB8")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1D76EB8", Offset = "0x1D76EB8", VA = "0x1D76EB8")]
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
		[Address(RVA = "0x1D77094", Offset = "0x1D77094", VA = "0x1D77094")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1D69158", Offset = "0x1D69158", VA = "0x1D69158")]
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
		[Address(RVA = "0x1919308", Offset = "0x1919308", VA = "0x1919308")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x191938C", Offset = "0x191938C", VA = "0x191938C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB81944", Offset = "0xB81944")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1919394", Offset = "0x1919394", VA = "0x1919394")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x191949C", Offset = "0x191949C", VA = "0x191949C")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8197C", Offset = "0xB8197C")]
		public AimPoser aimPoser;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB819B4", Offset = "0xB819B4")]
		public AimIK aim;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB819EC", Offset = "0xB819EC")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB81A24", Offset = "0xB81A24")]
		public Animator animator;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB81A5C", Offset = "0xB81A5C")]
		public float crossfadeTime;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB81A94", Offset = "0xB81A94")]
		public float minAimDistance;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1815370", Offset = "0x1815370", VA = "0x1815370")]
		private void Start()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x18153B4", Offset = "0x18153B4", VA = "0x18153B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1815508", Offset = "0x1815508", VA = "0x1815508")]
		private void Pose()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1815720", Offset = "0x1815720", VA = "0x1815720")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1815A60", Offset = "0x1815A60", VA = "0x1815A60")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1815B38", Offset = "0x1815B38", VA = "0x1815B38")]
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
		[Address(RVA = "0x1816904", Offset = "0x1816904", VA = "0x1816904")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1816B68", Offset = "0x1816B68", VA = "0x1816B68")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1816DB8", Offset = "0x1816DB8", VA = "0x1816DB8")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB81ACC", Offset = "0xB81ACC")]
		public Animator animator;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB81B04", Offset = "0xB81B04")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB81B3C", Offset = "0xB81B3C")]
		public float lookAtWeight;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB81B54", Offset = "0xB81B54")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB81B6C", Offset = "0xB81B6C")]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB81B84", Offset = "0xB81B84")]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB81B9C", Offset = "0xB81B9C")]
		public float lookAtClampWeight;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB81BB4", Offset = "0xB81BB4")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB81BCC", Offset = "0xB81BCC")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB81BE4", Offset = "0xB81BE4")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB81C1C", Offset = "0xB81C1C")]
		public float footPositionWeight;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB81C34", Offset = "0xB81C34")]
		public float footRotationWeight;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB81C4C", Offset = "0xB81C4C")]
		public Transform handTargetBiped;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB81C84", Offset = "0xB81C84")]
		public float handPositionWeight;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB81C9C", Offset = "0xB81C9C")]
		public float handRotationWeight;

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x191B090", Offset = "0x191B090", VA = "0x191B090")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x191B53C", Offset = "0x191B53C", VA = "0x191B53C")]
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
		[Address(RVA = "0x19254A4", Offset = "0x19254A4", VA = "0x19254A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1925ED8", Offset = "0x1925ED8", VA = "0x1925ED8")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1925BC0", Offset = "0x1925BC0", VA = "0x1925BC0")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1926080", Offset = "0x1926080", VA = "0x1926080")]
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
			[Address(RVA = "0x19260AC", Offset = "0x19260AC", VA = "0x19260AC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x192614C", Offset = "0x192614C", VA = "0x192614C")]
		private void Update()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x19263E4", Offset = "0x19263E4", VA = "0x19263E4")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB815C4", Offset = "0xB815C4")]
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
				[Address(RVA = "0x19270F4", Offset = "0x19270F4", VA = "0x19270F4", Slot = "4")]
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
				[Address(RVA = "0x192715C", Offset = "0x192715C", VA = "0x192715C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x1926D78", Offset = "0x1926D78", VA = "0x1926D78")]
			[DebuggerHidden]
			public <Step>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x1926DD4", Offset = "0x1926DD4", VA = "0x1926DD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x1926DD8", Offset = "0x1926DD8", VA = "0x1926DD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x19270FC", Offset = "0x19270FC", VA = "0x19270FC", Slot = "8")]
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
			[Address(RVA = "0x19263F8", Offset = "0x19263F8", VA = "0x19263F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public Vector3 position
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x192604C", Offset = "0x192604C", VA = "0x192604C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x192640C", Offset = "0x192640C", VA = "0x192640C")]
			set
			{
			}
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x192645C", Offset = "0x192645C", VA = "0x192645C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x19264BC", Offset = "0x19264BC", VA = "0x19264BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1926664", Offset = "0x1926664", VA = "0x1926664")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1926A34", Offset = "0x1926A34", VA = "0x1926A34")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1926B5C", Offset = "0x1926B5C", VA = "0x1926B5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1926AA4", Offset = "0x1926AA4", VA = "0x1926AA4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB89BE8", Offset = "0xB89BE8")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1926DA4", Offset = "0x1926DA4", VA = "0x1926DA4")]
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
		[Address(RVA = "0x1927164", Offset = "0x1927164", VA = "0x1927164")]
		private void Start()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1927220", Offset = "0x1927220", VA = "0x1927220")]
		private void Update()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x19274B4", Offset = "0x19274B4", VA = "0x19274B4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB860D8", Offset = "0xB860D8")]
			public int animationLayer;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86110", Offset = "0xB86110")]
			public string animationState;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86148", Offset = "0xB86148")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86180", Offset = "0xB86180")]
			public Transform warpFrom;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB861B8", Offset = "0xB861B8")]
			public Transform warpTo;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB861F0", Offset = "0xB861F0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB81CB4", Offset = "0xB81CB4")]
		public Animator animator;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB81CEC", Offset = "0xB81CEC")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xB81D24", Offset = "0xB81D24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB81D24", Offset = "0xB81D24")]
		public Warp[] warps;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1919514", Offset = "0x1919514", VA = "0x1919514", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1919540", Offset = "0x1919540", VA = "0x1919540")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1919760", Offset = "0x1919760", VA = "0x1919760", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1919B14", Offset = "0x1919B14", VA = "0x1919B14")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1919BB4", Offset = "0x1919BB4", VA = "0x1919BB4")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB80654", Offset = "0xB80654")]
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
		[Address(RVA = "0x1919BBC", Offset = "0x1919BBC", VA = "0x1919BBC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1919C1C", Offset = "0x1919C1C", VA = "0x1919C1C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1919E54", Offset = "0x1919E54", VA = "0x1919E54", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x191A0B8", Offset = "0x191A0B8", VA = "0x191A0B8")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB806B8", Offset = "0xB806B8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB806B8", Offset = "0xB806B8")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB81D74", Offset = "0xB81D74")]
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
		[Address(RVA = "0x191A0CC", Offset = "0x191A0CC", VA = "0x191A0CC", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x191A278", Offset = "0x191A278", VA = "0x191A278", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x191A2EC", Offset = "0x191A2EC", VA = "0x191A2EC")]
		private void Read()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x191A444", Offset = "0x191A444", VA = "0x191A444")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x191A48C", Offset = "0x191A48C", VA = "0x191A48C")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x191AA84", Offset = "0x191AA84", VA = "0x191AA84")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x191A848", Offset = "0x191A848", VA = "0x191A848")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x191ADDC", Offset = "0x191ADDC", VA = "0x191ADDC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x191AEF8", Offset = "0x191AEF8", VA = "0x191AEF8")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB80744", Offset = "0xB80744")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x191C58C", Offset = "0x191C58C", VA = "0x191C58C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x191C5F4", Offset = "0x191C5F4", VA = "0x191C5F4", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x191C8B8", Offset = "0x191C8B8", VA = "0x191C8B8")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x191CA70", Offset = "0x191CA70", VA = "0x191CA70")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB807A8", Offset = "0xB807A8")]
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
			[Address(RVA = "0x191D8DC", Offset = "0x191D8DC", VA = "0x191D8DC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000017")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x191D97C", Offset = "0x191D97C", VA = "0x191D97C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x191D620", Offset = "0x191D620", VA = "0x191D620")]
		private void Start()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x191D698", Offset = "0x191D698", VA = "0x191D698")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x191DA1C", Offset = "0x191DA1C", VA = "0x191DA1C")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB81D9C", Offset = "0xB81D9C")]
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
		[Address(RVA = "0x19200AC", Offset = "0x19200AC", VA = "0x19200AC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1920690", Offset = "0x1920690", VA = "0x1920690")]
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
		[Address(RVA = "0x1920698", Offset = "0x1920698", VA = "0x1920698")]
		private void Start()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x192074C", Offset = "0x192074C", VA = "0x192074C")]
		private void Update()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1920BC8", Offset = "0x1920BC8", VA = "0x1920BC8")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1920C74", Offset = "0x1920C74", VA = "0x1920C74")]
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
			[Address(RVA = "0x1920E48", Offset = "0x1920E48", VA = "0x1920E48")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x1920F7C", Offset = "0x1920F7C", VA = "0x1920F7C")]
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
		[Address(RVA = "0x1920CFC", Offset = "0x1920CFC", VA = "0x1920CFC")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1920ECC", Offset = "0x1920ECC", VA = "0x1920ECC")]
		private void Start()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1920F68", Offset = "0x1920F68", VA = "0x1920F68")]
		private void Update()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1920F6C", Offset = "0x1920F6C", VA = "0x1920F6C")]
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
		[Address(RVA = "0x1920F8C", Offset = "0x1920F8C", VA = "0x1920F8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1920FF8", Offset = "0x1920FF8", VA = "0x1920FF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x19210DC", Offset = "0x19210DC", VA = "0x19210DC")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB81DB4", Offset = "0xB81DB4")]
		public Transform target;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB81DEC", Offset = "0xB81DEC")]
		public Transform pin;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB81E24", Offset = "0xB81E24")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB81E5C", Offset = "0xB81E5C")]
		public AimIK aim;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB81E94", Offset = "0xB81E94")]
		public float weight;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB81ECC", Offset = "0xB81ECC")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB81F04", Offset = "0xB81F04")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x19210E4", Offset = "0x19210E4", VA = "0x19210E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1921144", Offset = "0x1921144", VA = "0x1921144")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x19212E0", Offset = "0x19212E0", VA = "0x19212E0")]
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
		[Address(RVA = "0x19212E8", Offset = "0x19212E8", VA = "0x19212E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x19213B8", Offset = "0x19213B8", VA = "0x19213B8")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1921448", Offset = "0x1921448", VA = "0x1921448")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x192195C", Offset = "0x192195C", VA = "0x192195C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1921A78", Offset = "0x1921A78", VA = "0x1921A78")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB81F3C", Offset = "0xB81F3C")]
		public float aimWeight;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB81F54", Offset = "0xB81F54")]
		public float sightWeight;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB81F6C", Offset = "0xB81F6C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB81FF8", Offset = "0xB81FF8")]
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
		[Address(RVA = "0x1921A80", Offset = "0x1921A80", VA = "0x1921A80")]
		private void Start()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1921BE0", Offset = "0x1921BE0", VA = "0x1921BE0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1921BEC", Offset = "0x1921BEC", VA = "0x1921BEC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1921F2C", Offset = "0x1921F2C", VA = "0x1921F2C")]
		private void Aiming()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1922194", Offset = "0x1922194", VA = "0x1922194")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1921CB0", Offset = "0x1921CB0", VA = "0x1921CB0")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1922BA0", Offset = "0x1922BA0", VA = "0x1922BA0")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB8080C", Offset = "0xB8080C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB8080C", Offset = "0xB8080C")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB82038", Offset = "0xB82038")]
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
		[Address(RVA = "0x1922BC0", Offset = "0x1922BC0", VA = "0x1922BC0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1922C44", Offset = "0x1922C44", VA = "0x1922C44")]
		private void Update()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1922D68", Offset = "0x1922D68", VA = "0x1922D68")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1922E18", Offset = "0x1922E18", VA = "0x1922E18")]
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
		[Address(RVA = "0x19231AC", Offset = "0x19231AC", VA = "0x19231AC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1923378", Offset = "0x1923378", VA = "0x1923378")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x192353C", Offset = "0x192353C", VA = "0x192353C")]
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
		[Address(RVA = "0x19238EC", Offset = "0x19238EC", VA = "0x19238EC")]
		private void Start()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1923A98", Offset = "0x1923A98", VA = "0x1923A98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1923E54", Offset = "0x1923E54", VA = "0x1923E54")]
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
		[Address(RVA = "0x1923E64", Offset = "0x1923E64", VA = "0x1923E64")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1923F98", Offset = "0x1923F98", VA = "0x1923F98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x19240E8", Offset = "0x19240E8", VA = "0x19240E8")]
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
		[Address(RVA = "0x19240F0", Offset = "0x19240F0", VA = "0x19240F0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x19247C0", Offset = "0x19247C0", VA = "0x19247C0")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB80898", Offset = "0xB80898")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82070", Offset = "0xB82070")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB820BC", Offset = "0xB820BC")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x19247C8", Offset = "0x19247C8", VA = "0x19247C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1924828", Offset = "0x1924828", VA = "0x1924828")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1924B34", Offset = "0x1924B34", VA = "0x1924B34")]
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
				[Address(RVA = "0x1925438", Offset = "0x1925438", VA = "0x1925438")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x1924B70", Offset = "0x1924B70", VA = "0x1924B70")]
			public void Initiate()
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x1924BF0", Offset = "0x1924BF0", VA = "0x1924BF0")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x192525C", Offset = "0x192525C", VA = "0x192525C")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x1925490", Offset = "0x1925490", VA = "0x1925490")]
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
		[Address(RVA = "0x1924B3C", Offset = "0x1924B3C", VA = "0x1924B3C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1924B90", Offset = "0x1924B90", VA = "0x1924B90")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x192524C", Offset = "0x192524C", VA = "0x192524C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86228", Offset = "0xB86228")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86260", Offset = "0xB86260")]
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
			[Address(RVA = "0x1927630", Offset = "0x1927630", VA = "0x1927630")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x1927824", Offset = "0x1927824", VA = "0x1927824")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x1927860", Offset = "0x1927860", VA = "0x1927860")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x1927A10", Offset = "0x1927A10", VA = "0x1927A10")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x1927C58", Offset = "0x1927C58", VA = "0x1927C58")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82108", Offset = "0xB82108")]
		public Mode mode;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82140", Offset = "0xB82140")]
		public Absorber[] absorbers;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82178", Offset = "0xB82178")]
		public AnimationCurve falloff;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB821B0", Offset = "0xB821B0")]
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
		[Address(RVA = "0x19274BC", Offset = "0x19274BC", VA = "0x19274BC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x19275A4", Offset = "0x19275A4", VA = "0x19275A4")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1927718", Offset = "0x1927718", VA = "0x1927718", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1927988", Offset = "0x1927988", VA = "0x1927988")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1927B20", Offset = "0x1927B20", VA = "0x1927B20", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1927C48", Offset = "0x1927C48", VA = "0x1927C48")]
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
		[Address(RVA = "0x1927CD8", Offset = "0x1927CD8", VA = "0x1927CD8")]
		private void Start()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1927D58", Offset = "0x1927D58", VA = "0x1927D58")]
		private void Update()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1927E24", Offset = "0x1927E24", VA = "0x1927E24")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1927F84", Offset = "0x1927F84", VA = "0x1927F84")]
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
			[Address(RVA = "0x1928D24", Offset = "0x1928D24", VA = "0x1928D24")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x19289F0", Offset = "0x19289F0", VA = "0x19289F0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1928AF0", Offset = "0x1928AF0", VA = "0x1928AF0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1928D1C", Offset = "0x1928D1C", VA = "0x1928D1C")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB808FC", Offset = "0xB808FC")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB821E8", Offset = "0xB821E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB821E8", Offset = "0xB821E8")]
		public float weight;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8223C", Offset = "0xB8223C")]
		public float hangingDistanceMlp;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82274", Offset = "0xB82274")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB822C0", Offset = "0xB822C0")]
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
		[Address(RVA = "0x1928D34", Offset = "0x1928D34", VA = "0x1928D34")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1929084", Offset = "0x1929084", VA = "0x1929084")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x19297D4", Offset = "0x19297D4", VA = "0x19297D4")]
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
			[Address(RVA = "0x181369C", Offset = "0x181369C", VA = "0x181369C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x18133DC", Offset = "0x18133DC", VA = "0x18133DC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001A8")]
		protected abstract void RotatePivot();

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x18136BC", Offset = "0x18136BC", VA = "0x18136BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1813854", Offset = "0x1813854", VA = "0x1813854")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x18139D0", Offset = "0x18139D0", VA = "0x18139D0")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1813AB0", Offset = "0x1813AB0", VA = "0x1813AB0")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1813BDC", Offset = "0x1813BDC", VA = "0x1813BDC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1813DEC", Offset = "0x1813DEC", VA = "0x1813DEC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1813FD0", Offset = "0x1813FD0", VA = "0x1813FD0")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1813FE4", Offset = "0x1813FE4", VA = "0x1813FE4", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x18141D8", Offset = "0x18141D8", VA = "0x18141D8")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x18141EC", Offset = "0x18141EC", VA = "0x18141EC", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1814398", Offset = "0x1814398", VA = "0x1814398")]
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
		[Address(RVA = "0x1814B38", Offset = "0x1814B38", VA = "0x1814B38")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1814C10", Offset = "0x1814C10", VA = "0x1814C10")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1814DB8", Offset = "0x1814DB8", VA = "0x1814DB8")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB80960", Offset = "0xB80960")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1814DC0", Offset = "0x1814DC0", VA = "0x1814DC0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1814E20", Offset = "0x1814E20", VA = "0x1814E20")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1814E7C", Offset = "0x1814E7C", VA = "0x1814E7C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1814F54", Offset = "0x1814F54", VA = "0x1814F54")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB815D4", Offset = "0xB815D4")]
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
				[Address(RVA = "0x1815300", Offset = "0x1815300", VA = "0x1815300", Slot = "4")]
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
				[Address(RVA = "0x1815368", Offset = "0x1815368", VA = "0x1815368", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x1815104", Offset = "0x1815104", VA = "0x1815104")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x1815140", Offset = "0x1815140", VA = "0x1815140", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x1815144", Offset = "0x1815144", VA = "0x1815144", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x1815308", Offset = "0x1815308", VA = "0x1815308", Slot = "8")]
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
		[Address(RVA = "0x1814F64", Offset = "0x1814F64", VA = "0x1814F64")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1815030", Offset = "0x1815030", VA = "0x1815030")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1815078", Offset = "0x1815078", VA = "0x1815078")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB89C4C", Offset = "0xB89C4C")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1815130", Offset = "0x1815130", VA = "0x1815130")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB809C4", Offset = "0xB809C4")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB815E4", Offset = "0xB815E4")]
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
				[Address(RVA = "0x1816894", Offset = "0x1816894", VA = "0x1816894", Slot = "4")]
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
				[Address(RVA = "0x18168FC", Offset = "0x18168FC", VA = "0x18168FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x1816724", Offset = "0x1816724", VA = "0x1816724")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x1816758", Offset = "0x1816758", VA = "0x1816758", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x181675C", Offset = "0x181675C", VA = "0x181675C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x181689C", Offset = "0x181689C", VA = "0x181689C", Slot = "8")]
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
		[Address(RVA = "0x18165EC", Offset = "0x18165EC", VA = "0x18165EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x18166A8", Offset = "0x18166A8", VA = "0x18166A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB89CB0", Offset = "0xB89CB0")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1816750", Offset = "0x1816750", VA = "0x1816750")]
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
			[Address(RVA = "0x1816EA4", Offset = "0x1816EA4", VA = "0x1816EA4")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x1817BB4", Offset = "0x1817BB4", VA = "0x1817BB4")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x1817220", Offset = "0x1817220", VA = "0x1817220")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x1817C9C", Offset = "0x1817C9C", VA = "0x1817C9C")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x1817E38", Offset = "0x1817E38", VA = "0x1817E38")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x1817ED4", Offset = "0x1817ED4", VA = "0x1817ED4")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x1817F6C", Offset = "0x1817F6C", VA = "0x1817F6C")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x1817A00", Offset = "0x1817A00", VA = "0x1817A00")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x1818004", Offset = "0x1818004", VA = "0x1818004")]
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
		[Address(RVA = "0x1816E2C", Offset = "0x1816E2C", VA = "0x1816E2C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x18171B4", Offset = "0x18171B4", VA = "0x18171B4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1817938", Offset = "0x1817938", VA = "0x1817938")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1817BAC", Offset = "0x1817BAC", VA = "0x1817BAC")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB823AC", Offset = "0xB823AC")]
		public Transform to;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB823E4", Offset = "0xB823E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB823E4", Offset = "0xB823E4")]
		public float transferMotion;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1818038", Offset = "0x1818038", VA = "0x1818038")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1818074", Offset = "0x1818074", VA = "0x1818074")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x18181CC", Offset = "0x18181CC", VA = "0x18181CC")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82438", Offset = "0xB82438")]
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
		[Address(RVA = "0x18183A0", Offset = "0x18183A0", VA = "0x18183A0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1818580", Offset = "0x1818580", VA = "0x1818580")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x181881C", Offset = "0x181881C", VA = "0x181881C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x18188E8", Offset = "0x18188E8", VA = "0x18188E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1818A04", Offset = "0x1818A04", VA = "0x1818A04")]
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
		[Address(RVA = "0x1818D7C", Offset = "0x1818D7C", VA = "0x1818D7C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x18191F4", Offset = "0x18191F4", VA = "0x18191F4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x181944C", Offset = "0x181944C", VA = "0x181944C")]
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
		[Address(RVA = "0x1922E28", Offset = "0x1922E28", VA = "0x1922E28")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1923124", Offset = "0x1923124", VA = "0x1923124")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x19231A4", Offset = "0x19231A4", VA = "0x19231A4")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB815F4", Offset = "0xB815F4")]
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
				[Address(RVA = "0x1814AC8", Offset = "0x1814AC8", VA = "0x1814AC8", Slot = "4")]
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
				[Address(RVA = "0x1814B30", Offset = "0x1814B30", VA = "0x1814B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x1814778", Offset = "0x1814778", VA = "0x1814778")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x1814984", Offset = "0x1814984", VA = "0x1814984", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x1814988", Offset = "0x1814988", VA = "0x1814988", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x1814AD0", Offset = "0x1814AD0", VA = "0x1814AD0", Slot = "8")]
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
		[Address(RVA = "0x18143AC", Offset = "0x18143AC", VA = "0x18143AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1814550", Offset = "0x1814550", VA = "0x1814550")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x18144D4", Offset = "0x18144D4", VA = "0x18144D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB89D14", Offset = "0xB89D14")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x18147A4", Offset = "0x18147A4", VA = "0x18147A4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1814888", Offset = "0x1814888", VA = "0x1814888")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1814968", Offset = "0x1814968", VA = "0x1814968")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB824A0", Offset = "0xB824A0")]
		public float weight;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x191AF58", Offset = "0x191AF58", VA = "0x191AF58")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x191AFC4", Offset = "0x191AFC4", VA = "0x191AFC4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x191B080", Offset = "0x191B080", VA = "0x191B080")]
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
			[Address(RVA = "0x1818258", Offset = "0x1818258", VA = "0x1818258")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x1818398", Offset = "0x1818398", VA = "0x1818398")]
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
		[Address(RVA = "0x18181E0", Offset = "0x18181E0", VA = "0x18181E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1818390", Offset = "0x1818390", VA = "0x1818390")]
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
		[Address(RVA = "0x192354C", Offset = "0x192354C", VA = "0x192354C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1923718", Offset = "0x1923718", VA = "0x1923718")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x19238DC", Offset = "0x19238DC", VA = "0x19238DC")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB824D8", Offset = "0xB824D8")]
		public VRIK ik;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82510", Offset = "0xB82510")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82548", Offset = "0xB82548")]
		public Transform headTracker;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82580", Offset = "0xB82580")]
		public Transform bodyTracker;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB825B8", Offset = "0xB825B8")]
		public Transform leftHandTracker;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB825F0", Offset = "0xB825F0")]
		public Transform rightHandTracker;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82628", Offset = "0xB82628")]
		public Transform leftFootTracker;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82660", Offset = "0xB82660")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB82698", Offset = "0xB82698")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1819470", Offset = "0x1819470", VA = "0x1819470")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x18195D8", Offset = "0x18195D8", VA = "0x18195D8")]
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
		[Address(RVA = "0x181964C", Offset = "0x181964C", VA = "0x181964C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x18196A8", Offset = "0x18196A8", VA = "0x18196A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x18198F4", Offset = "0x18198F4", VA = "0x18198F4")]
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
		[Address(RVA = "0x181996C", Offset = "0x181996C", VA = "0x181996C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1819ED4", Offset = "0x1819ED4", VA = "0x1819ED4")]
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
			[Address(RVA = "0x191B580", Offset = "0x191B580", VA = "0x191B580", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x191B55C", Offset = "0x191B55C", VA = "0x191B55C", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x191B588", Offset = "0x191B588", VA = "0x191B588")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x191B64C", Offset = "0x191B64C", VA = "0x191B64C", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x191B8A4", Offset = "0x191B8A4", VA = "0x191B8A4", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x191BB14", Offset = "0x191BB14", VA = "0x191BB14", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x191B8B4", Offset = "0x191B8B4", VA = "0x191B8B4")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x191BB24", Offset = "0x191BB24", VA = "0x191BB24")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB80A28", Offset = "0xB80A28")]
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
		[Address(RVA = "0x191BB3C", Offset = "0x191BB3C", VA = "0x191BB3C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x191BBA4", Offset = "0x191BBA4", VA = "0x191BBA4", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x191BCD0", Offset = "0x191BCD0", VA = "0x191BCD0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x191BE4C", Offset = "0x191BE4C", VA = "0x191BE4C")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB80A8C", Offset = "0xB80A8C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB82730", Offset = "0xB82730")]
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
			[Address(RVA = "0x191BF10", Offset = "0x191BF10", VA = "0x191BF10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x191BE64", Offset = "0x191BE64", VA = "0x191BE64", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x191BEF4", Offset = "0x191BEF4", VA = "0x191BEF4", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x191C000", Offset = "0x191C000", VA = "0x191C000", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x191C3B4", Offset = "0x191C3B4", VA = "0x191C3B4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x191C568", Offset = "0x191C568", VA = "0x191C568")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB80AF0", Offset = "0xB80AF0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB80AF0", Offset = "0xB80AF0")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB82774", Offset = "0xB82774")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82774", Offset = "0xB82774")]
		public Transform gravityTarget;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB827D4", Offset = "0xB827D4")]
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
		[Address(RVA = "0x191CA94", Offset = "0x191CA94", VA = "0x191CA94")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x191CC18", Offset = "0x191CC18", VA = "0x191CC18", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x191CDE0", Offset = "0x191CDE0", VA = "0x191CDE0", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x191D058", Offset = "0x191D058", VA = "0x191D058")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x191D11C", Offset = "0x191D11C", VA = "0x191D11C")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x191D304", Offset = "0x191D304", VA = "0x191D304")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x191D4B4", Offset = "0x191D4B4", VA = "0x191D4B4")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x191D4D8", Offset = "0x191D4D8", VA = "0x191D4D8")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x191D4FC", Offset = "0x191D4FC", VA = "0x191D4FC")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x191D600", Offset = "0x191D600", VA = "0x191D600")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB82870", Offset = "0xB82870")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB828A8", Offset = "0xB828A8")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB828E0", Offset = "0xB828E0")]
		public bool lookInCameraDirection;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB82918", Offset = "0xB82918")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB82950", Offset = "0xB82950")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB8299C", Offset = "0xB8299C")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB829D4", Offset = "0xB829D4")]
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
			[Address(RVA = "0x191DA24", Offset = "0x191DA24", VA = "0x191DA24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89D78", Offset = "0xB89D78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x191DA2C", Offset = "0x191DA2C", VA = "0x191DA2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89D88", Offset = "0xB89D88")]
			private set
			{
			}
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x191DA38", Offset = "0x191DA38", VA = "0x191DA38", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x191DBE4", Offset = "0x191DBE4", VA = "0x191DBE4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x191DC74", Offset = "0x191DC74", VA = "0x191DC74", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x191DDB0", Offset = "0x191DDB0", VA = "0x191DDB0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x191ECEC", Offset = "0x191ECEC", VA = "0x191ECEC", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x191F084", Offset = "0x191F084", VA = "0x191F084", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x191E3BC", Offset = "0x191E3BC", VA = "0x191E3BC")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x191F164", Offset = "0x191F164", VA = "0x191F164")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x191F754", Offset = "0x191F754", VA = "0x191F754")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x191EDC8", Offset = "0x191EDC8", VA = "0x191EDC8")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x191F7F4", Offset = "0x191F7F4", VA = "0x191F7F4", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x191FC64", Offset = "0x191FC64", VA = "0x191FC64")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x191FDF0", Offset = "0x191FDF0", VA = "0x191FDF0", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x191E8CC", Offset = "0x191E8CC", VA = "0x191E8CC")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x191FF84", Offset = "0x191FF84", VA = "0x191FF84")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB80B7C", Offset = "0xB80B7C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB829E4", Offset = "0xB829E4")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82A30", Offset = "0xB82A30")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82A7C", Offset = "0xB82A7C")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82AC8", Offset = "0xB82AC8")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82B14", Offset = "0xB82B14")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82B60", Offset = "0xB82B60")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB82BAC", Offset = "0xB82BAC")]
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
			[Address(RVA = "0x1815B4C", Offset = "0x1815B4C", VA = "0x1815B4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89D98", Offset = "0xB89D98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x1815B54", Offset = "0x1815B54", VA = "0x1815B54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89DA8", Offset = "0xB89DA8")]
			private set
			{
			}
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1815B60", Offset = "0x1815B60", VA = "0x1815B60")]
		private void Start()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1815BFC", Offset = "0x1815BFC", VA = "0x1815BFC")]
		private void Update()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x18162F8", Offset = "0x18162F8", VA = "0x18162F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1815C50", Offset = "0x1815C50", VA = "0x1815C50")]
		private void Rotate()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1816050", Offset = "0x1816050", VA = "0x1816050")]
		private void Move()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1816334", Offset = "0x1816334", VA = "0x1816334")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x181642C", Offset = "0x181642C", VA = "0x181642C")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x18164CC", Offset = "0x18164CC", VA = "0x18164CC")]
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
		[Address(RVA = "0x1818A0C", Offset = "0x1818A0C", VA = "0x1818A0C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1818A90", Offset = "0x1818A90", VA = "0x1818A90", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1818D28", Offset = "0x1818D28", VA = "0x1818D28")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1818D50", Offset = "0x1818D50", VA = "0x1818D50")]
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
		[Address(RVA = "0x1818A50", Offset = "0x1818A50", VA = "0x1818A50", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1818E90", Offset = "0x1818E90", VA = "0x1818E90", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1818D6C", Offset = "0x1818D6C", VA = "0x1818D6C")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x191AF14", Offset = "0x191AF14", VA = "0x191AF14")]
		private void Update()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x191AF50", Offset = "0x191AF50", VA = "0x191AF50")]
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
		[Address(RVA = "0x18164F4", Offset = "0x18164F4", VA = "0x18164F4")]
		private void Update()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1816528", Offset = "0x1816528", VA = "0x1816528")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x18165D8", Offset = "0x18165D8", VA = "0x18165D8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82BFC", Offset = "0xB82BFC")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82C34", Offset = "0xB82C34")]
		public float cornerRadius;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82C6C", Offset = "0xB82C6C")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82CA4", Offset = "0xB82CA4")]
		public float maxSampleDistance;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82CDC", Offset = "0xB82CDC")]
		public float nextPathInterval;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB82D14", Offset = "0xB82D14")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB82D24", Offset = "0xB82D24")]
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
			[Address(RVA = "0x1927F98", Offset = "0x1927F98", VA = "0x1927F98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89DB8", Offset = "0xB89DB8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x1927FA4", Offset = "0x1927FA4", VA = "0x1927FA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89DC8", Offset = "0xB89DC8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public State state
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x1927FB0", Offset = "0x1927FB0", VA = "0x1927FB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89DD8", Offset = "0xB89DD8")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x1927FB8", Offset = "0x1927FB8", VA = "0x1927FB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89DE8", Offset = "0xB89DE8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1927FC0", Offset = "0x1927FC0", VA = "0x1927FC0")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x19280B8", Offset = "0x19280B8", VA = "0x19280B8")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1928610", Offset = "0x1928610", VA = "0x1928610")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1928680", Offset = "0x1928680", VA = "0x1928680")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x19284D8", Offset = "0x19284D8", VA = "0x19284D8")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x192854C", Offset = "0x192854C", VA = "0x192854C")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x19287C8", Offset = "0x19287C8", VA = "0x19287C8")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1928978", Offset = "0x1928978", VA = "0x1928978")]
		public Navigator()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB80BE0", Offset = "0xB80BE0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB80BE0", Offset = "0xB80BE0")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x181BDE0", Offset = "0x181BDE0", VA = "0x181BDE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB89DF8", Offset = "0xB89DF8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x181BE2C", Offset = "0x181BE2C", VA = "0x181BE2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB89E30", Offset = "0xB89E30")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x181BE78", Offset = "0x181BE78", VA = "0x181BE78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB89E68", Offset = "0xB89E68")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x181BEC4", Offset = "0x181BEC4", VA = "0x181BEC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB89EA0", Offset = "0xB89EA0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x181BF10", Offset = "0x181BF10", VA = "0x181BF10")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x181BFAC", Offset = "0x181BFAC", VA = "0x181BFAC")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x181BFCC", Offset = "0x181BFCC", VA = "0x181BFCC")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x181BFFC", Offset = "0x181BFFC", VA = "0x181BFFC")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x181C02C", Offset = "0x181C02C", VA = "0x181C02C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x181C06C", Offset = "0x181C06C", VA = "0x181C06C")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x181C0B0", Offset = "0x181C0B0", VA = "0x181C0B0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x181C0D4", Offset = "0x181C0D4", VA = "0x181C0D4")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x181C0F8", Offset = "0x181C0F8", VA = "0x181C0F8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x181C120", Offset = "0x181C120", VA = "0x181C120")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x181C14C", Offset = "0x181C14C", VA = "0x181C14C")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x181C178", Offset = "0x181C178", VA = "0x181C178")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x181BF30", Offset = "0x181BF30", VA = "0x181BF30")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x181C1A0", Offset = "0x181C1A0", VA = "0x181C1A0")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x181C1AC", Offset = "0x181C1AC", VA = "0x181C1AC")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x181C1B8", Offset = "0x181C1B8", VA = "0x181C1B8")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x181C4E0", Offset = "0x181C4E0", VA = "0x181C4E0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x181C588", Offset = "0x181C588", VA = "0x181C588", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x181C8D4", Offset = "0x181C8D4", VA = "0x181C8D4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x181CDBC", Offset = "0x181CDBC", VA = "0x181CDBC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x181CDF0", Offset = "0x181CDF0", VA = "0x181CDF0")]
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
			[Address(RVA = "0x181C358", Offset = "0x181C358", VA = "0x181C358")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x181D034", Offset = "0x181D034", VA = "0x181D034")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x181C758", Offset = "0x181C758", VA = "0x181C758")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x181CE8C", Offset = "0x181CE8C", VA = "0x181CE8C")]
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
			[Address(RVA = "0x181D6A4", Offset = "0x181D6A4", VA = "0x181D6A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000258")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x181D714", Offset = "0x181D714", VA = "0x181D714")]
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
		[Address(RVA = "0x181D71C", Offset = "0x181D71C", VA = "0x181D71C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x181D828", Offset = "0x181D828", VA = "0x181D828")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x181D830", Offset = "0x181D830", VA = "0x181D830")]
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
			[Address(RVA = "0x181DA00", Offset = "0x181DA00", VA = "0x181DA00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x181D864", Offset = "0x181D864", VA = "0x181D864", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x181DABC", Offset = "0x181DABC", VA = "0x181DABC")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x181DAC4", Offset = "0x181DAC4", VA = "0x181DAC4")]
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
		[Address(RVA = "0x181DAF8", Offset = "0x181DAF8", VA = "0x181DAF8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x181DC20", Offset = "0x181DC20", VA = "0x181DC20")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x181DC28", Offset = "0x181DC28", VA = "0x181DC28")]
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
			[Address(RVA = "0x181DDFC", Offset = "0x181DDFC", VA = "0x181DDFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x181DC5C", Offset = "0x181DC5C", VA = "0x181DC5C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x181DECC", Offset = "0x181DECC", VA = "0x181DECC")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x181DED4", Offset = "0x181DED4", VA = "0x181DED4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB82D34", Offset = "0xB82D34")]
		public float positionWeight;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB82D4C", Offset = "0xB82D4C")]
		public float rotationWeight;

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x181DF08", Offset = "0x181DF08", VA = "0x181DF08")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x181C87C", Offset = "0x181C87C", VA = "0x181C87C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x181CA5C", Offset = "0x181CA5C", VA = "0x181CA5C")]
		public void Update()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x181D264", Offset = "0x181D264", VA = "0x181D264")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82D64", Offset = "0xB82D64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB82D64", Offset = "0xB82D64")]
		public float weight;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82DB8", Offset = "0xB82DB8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB82DB8", Offset = "0xB82DB8")]
		public float rotationWeight;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82E0C", Offset = "0xB82E0C")]
		public DOF rotationDOF;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82E44", Offset = "0xB82E44")]
		public Transform bone1;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82E7C", Offset = "0xB82E7C")]
		public Transform bone2;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82EB4", Offset = "0xB82EB4")]
		public Transform bone3;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82EEC", Offset = "0xB82EEC")]
		public Transform tip;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82F24", Offset = "0xB82F24")]
		public Transform target;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB82F5C", Offset = "0xB82F5C")]
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
			[Address(RVA = "0x18253A8", Offset = "0x18253A8", VA = "0x18253A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89ED8", Offset = "0xB89ED8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x18253B0", Offset = "0x18253B0", VA = "0x18253B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89EE8", Offset = "0xB89EE8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x18253BC", Offset = "0x18253BC", VA = "0x18253BC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x18253DC", Offset = "0x18253DC", VA = "0x18253DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x18253FC", Offset = "0x18253FC", VA = "0x18253FC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x182541C", Offset = "0x182541C", VA = "0x182541C")]
			set
			{
			}
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x182543C", Offset = "0x182543C", VA = "0x182543C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1825548", Offset = "0x1825548", VA = "0x1825548")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1825984", Offset = "0x1825984", VA = "0x1825984")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1825A60", Offset = "0x1825A60", VA = "0x1825A60")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1825B28", Offset = "0x1825B28", VA = "0x1825B28")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1825EE0", Offset = "0x1825EE0", VA = "0x1825EE0")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82F6C", Offset = "0xB82F6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB82F6C", Offset = "0xB82F6C")]
		public float weight;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB82FC0", Offset = "0xB82FC0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000027")]
		public bool initiated
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x1825EF0", Offset = "0x1825EF0", VA = "0x1825EF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89EF8", Offset = "0xB89EF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x1825EF8", Offset = "0x1825EF8", VA = "0x1825EF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89F08", Offset = "0xB89F08")]
			private set
			{
			}
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1825F04", Offset = "0x1825F04", VA = "0x1825F04")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1825F8C", Offset = "0x1825F8C", VA = "0x1825F8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB89F18", Offset = "0xB89F18")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1826304", Offset = "0x1826304", VA = "0x1826304")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x18264C0", Offset = "0x18264C0", VA = "0x18264C0")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x18261F4", Offset = "0x18261F4", VA = "0x18261F4")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1826644", Offset = "0x1826644", VA = "0x1826644", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1826704", Offset = "0x1826704", VA = "0x1826704")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x182677C", Offset = "0x182677C", VA = "0x182677C")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x18267F0", Offset = "0x18267F0", VA = "0x18267F0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1826858", Offset = "0x1826858", VA = "0x1826858", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x182685C", Offset = "0x182685C", VA = "0x182685C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1826870", Offset = "0x1826870", VA = "0x1826870")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB82FD0", Offset = "0xB82FD0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB82FD0", Offset = "0xB82FD0")]
		public float weight;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83024", Offset = "0xB83024")]
		public Grounding solver;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8305C", Offset = "0xB8305C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000028")]
		public bool initiated
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x1827940", Offset = "0x1827940", VA = "0x1827940")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89F50", Offset = "0xB89F50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x1827948", Offset = "0x1827948", VA = "0x1827948")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB89F60", Offset = "0xB89F60")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000286")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1827954", Offset = "0x1827954", VA = "0x1827954")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1827C28", Offset = "0x1827C28", VA = "0x1827C28")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1827A98", Offset = "0x1827A98", VA = "0x1827A98")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1827C5C", Offset = "0x1827C5C", VA = "0x1827C5C")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028D")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600028E")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1827E64", Offset = "0x1827E64", VA = "0x1827E64")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB80C40", Offset = "0xB80C40")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB80C40", Offset = "0xB80C40")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8306C", Offset = "0xB8306C")]
		public BipedIK ik;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB830A4", Offset = "0xB830A4")]
		public float spineBend;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB830DC", Offset = "0xB830DC")]
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
		[Address(RVA = "0x1828138", Offset = "0x1828138", VA = "0x1828138", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB89F70", Offset = "0xB89F70")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1828184", Offset = "0x1828184", VA = "0x1828184", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB89FA8", Offset = "0xB89FA8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x18281D0", Offset = "0x18281D0", VA = "0x18281D0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1828254", Offset = "0x1828254", VA = "0x1828254")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1828304", Offset = "0x1828304", VA = "0x1828304")]
		private void Update()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x18283B8", Offset = "0x18283B8", VA = "0x18283B8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x18286CC", Offset = "0x18286CC", VA = "0x18286CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1828720", Offset = "0x1828720", VA = "0x1828720")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1828C74", Offset = "0x1828C74", VA = "0x1828C74")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1828D48", Offset = "0x1828D48", VA = "0x1828D48")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1828ED8", Offset = "0x1828ED8", VA = "0x1828ED8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x182907C", Offset = "0x182907C", VA = "0x182907C")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB80CA0", Offset = "0xB80CA0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB80CA0", Offset = "0xB80CA0")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000FC")]
		public class SpineEffector
		{
			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB862A8", Offset = "0xB862A8")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB862E0", Offset = "0xB862E0")]
			public float horizontalWeight;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86318", Offset = "0xB86318")]
			public float verticalWeight;

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x1829FA4", Offset = "0x1829FA4", VA = "0x1829FA4")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x1829FB4", Offset = "0x1829FB4", VA = "0x1829FB4")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83114", Offset = "0xB83114")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8314C", Offset = "0xB8314C")]
		public float spineBend;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83184", Offset = "0xB83184")]
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
		[Address(RVA = "0x1829114", Offset = "0x1829114", VA = "0x1829114")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB89FE0", Offset = "0xB89FE0")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1829160", Offset = "0x1829160", VA = "0x1829160", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A018", Offset = "0xB8A018")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x18291AC", Offset = "0x18291AC", VA = "0x18291AC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A050", Offset = "0xB8A050")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x18291F8", Offset = "0x18291F8", VA = "0x18291F8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x182927C", Offset = "0x182927C", VA = "0x182927C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1829314", Offset = "0x1829314", VA = "0x1829314")]
		private void Update()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1829610", Offset = "0x1829610", VA = "0x1829610")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x182961C", Offset = "0x182961C", VA = "0x182961C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x18293D0", Offset = "0x18293D0", VA = "0x18293D0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1829628", Offset = "0x1829628", VA = "0x1829628")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1829ACC", Offset = "0x1829ACC", VA = "0x1829ACC")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1829C8C", Offset = "0x1829C8C", VA = "0x1829C8C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1829DE8", Offset = "0x1829DE8", VA = "0x1829DE8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1829F0C", Offset = "0x1829F0C", VA = "0x1829F0C")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB80D00", Offset = "0xB80D00")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB80D00", Offset = "0xB80D00")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB831BC", Offset = "0xB831BC")]
		public Transform pelvis;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB831F4", Offset = "0xB831F4")]
		public Transform characterRoot;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8322C", Offset = "0xB8322C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8322C", Offset = "0xB8322C")]
		public float rootRotationWeight;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83280", Offset = "0xB83280")]
		public float rootRotationSpeed;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB832B8", Offset = "0xB832B8")]
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
		[Address(RVA = "0x1829FFC", Offset = "0x1829FFC", VA = "0x1829FFC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A088", Offset = "0xB8A088")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x182A048", Offset = "0x182A048", VA = "0x182A048", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A0C0", Offset = "0xB8A0C0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x182A094", Offset = "0x182A094", VA = "0x182A094", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x182A0B0", Offset = "0x182A0B0", VA = "0x182A0B0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x182A2A0", Offset = "0x182A2A0", VA = "0x182A2A0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x182A3A0", Offset = "0x182A3A0", VA = "0x182A3A0")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x182A8D4", Offset = "0x182A8D4", VA = "0x182A8D4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x182AD18", Offset = "0x182AD18", VA = "0x182AD18")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x182AF8C", Offset = "0x182AF8C", VA = "0x182AF8C")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x182B2AC", Offset = "0x182B2AC", VA = "0x182B2AC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x182B438", Offset = "0x182B438", VA = "0x182B438")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x182B624", Offset = "0x182B624", VA = "0x182B624")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB80D60", Offset = "0xB80D60")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB80D60", Offset = "0xB80D60")]
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
			[Address(RVA = "0x1F32328", Offset = "0x1F32328", VA = "0x1F32328")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB832F0", Offset = "0xB832F0")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83328", Offset = "0xB83328")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB83328", Offset = "0xB83328")]
		public float rootRotationWeight;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8337C", Offset = "0xB8337C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8337C", Offset = "0xB8337C")]
		public float minRootRotation;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB833D4", Offset = "0xB833D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB833D4", Offset = "0xB833D4")]
		public float maxRootRotation;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8342C", Offset = "0xB8342C")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83464", Offset = "0xB83464")]
		public float maxLegOffset;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8349C", Offset = "0xB8349C")]
		public float maxForeLegOffset;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB834D4", Offset = "0xB834D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB834D4", Offset = "0xB834D4")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83528", Offset = "0xB83528")]
		public Transform characterRoot;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83560", Offset = "0xB83560")]
		public Transform pelvis;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83598", Offset = "0xB83598")]
		public Transform lastSpineBone;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB835D0", Offset = "0xB835D0")]
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
		[Address(RVA = "0x1F31470", Offset = "0x1F31470", VA = "0x1F31470", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A0F8", Offset = "0xB8A0F8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1F314BC", Offset = "0x1F314BC", VA = "0x1F314BC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A130", Offset = "0xB8A130")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1F31508", Offset = "0x1F31508", VA = "0x1F31508", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1F315C0", Offset = "0x1F315C0", VA = "0x1F315C0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1F316F0", Offset = "0x1F316F0", VA = "0x1F316F0")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1F3189C", Offset = "0x1F3189C", VA = "0x1F3189C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1F31904", Offset = "0x1F31904", VA = "0x1F31904")]
		private void Update()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1F319BC", Offset = "0x1F319BC", VA = "0x1F319BC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1F31CF0", Offset = "0x1F31CF0", VA = "0x1F31CF0")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1F323A0", Offset = "0x1F323A0", VA = "0x1F323A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1F324EC", Offset = "0x1F324EC", VA = "0x1F324EC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1F32990", Offset = "0x1F32990", VA = "0x1F32990")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1F33188", Offset = "0x1F33188", VA = "0x1F33188")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1F336B0", Offset = "0x1F336B0", VA = "0x1F336B0")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1F33810", Offset = "0x1F33810", VA = "0x1F33810")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1F33AEC", Offset = "0x1F33AEC", VA = "0x1F33AEC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1F33B24", Offset = "0x1F33B24", VA = "0x1F33B24")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1F33D20", Offset = "0x1F33D20", VA = "0x1F33D20")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB80DC0", Offset = "0xB80DC0")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83618", Offset = "0xB83618")]
		public VRIK ik;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1F33EAC", Offset = "0x1F33EAC", VA = "0x1F33EAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A168", Offset = "0xB8A168")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1F33EB0", Offset = "0x1F33EB0", VA = "0x1F33EB0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A1A0", Offset = "0xB8A1A0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1F33EB4", Offset = "0x1F33EB4", VA = "0x1F33EB4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A1D8", Offset = "0xB8A1D8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1F33EB8", Offset = "0x1F33EB8", VA = "0x1F33EB8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1F33ED0", Offset = "0x1F33ED0", VA = "0x1F33ED0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1F33F68", Offset = "0x1F33F68", VA = "0x1F33F68")]
		private void Update()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1F3401C", Offset = "0x1F3401C", VA = "0x1F3401C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1F34280", Offset = "0x1F34280", VA = "0x1F34280")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1F3451C", Offset = "0x1F3451C", VA = "0x1F3451C")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1F34624", Offset = "0x1F34624", VA = "0x1F34624")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1F34824", Offset = "0x1F34824", VA = "0x1F34824")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1F34980", Offset = "0x1F34980", VA = "0x1F34980")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1F34B2C", Offset = "0x1F34B2C", VA = "0x1F34B2C")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB86350", Offset = "0xB86350")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB86360", Offset = "0xB86360")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB86370", Offset = "0xB86370")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB86380", Offset = "0xB86380")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB86390", Offset = "0xB86390")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB863A0", Offset = "0xB863A0")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB863B0", Offset = "0xB863B0")]
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
				[Address(RVA = "0x1F36634", Offset = "0x1F36634", VA = "0x1F36634")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BF00", Offset = "0xB8BF00")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600067E")]
				[Address(RVA = "0x1F3663C", Offset = "0x1F3663C", VA = "0x1F3663C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BF10", Offset = "0xB8BF10")]
				private set
				{
				}
			}

			[Token(Token = "0x17000096")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x600067F")]
				[Address(RVA = "0x1F36648", Offset = "0x1F36648", VA = "0x1F36648")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BF20", Offset = "0xB8BF20")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000680")]
				[Address(RVA = "0x1F36654", Offset = "0x1F36654", VA = "0x1F36654")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BF30", Offset = "0xB8BF30")]
				private set
				{
				}
			}

			[Token(Token = "0x17000097")]
			public bool initiated
			{
				[Token(Token = "0x6000681")]
				[Address(RVA = "0x1F36660", Offset = "0x1F36660", VA = "0x1F36660")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BF40", Offset = "0xB8BF40")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000682")]
				[Address(RVA = "0x1F36668", Offset = "0x1F36668", VA = "0x1F36668")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BF50", Offset = "0xB8BF50")]
				private set
				{
				}
			}

			[Token(Token = "0x17000098")]
			public float heightFromGround
			{
				[Token(Token = "0x6000683")]
				[Address(RVA = "0x1F36674", Offset = "0x1F36674", VA = "0x1F36674")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BF60", Offset = "0xB8BF60")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000684")]
				[Address(RVA = "0x1F3667C", Offset = "0x1F3667C", VA = "0x1F3667C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BF70", Offset = "0xB8BF70")]
				private set
				{
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000685")]
				[Address(RVA = "0x1F36684", Offset = "0x1F36684", VA = "0x1F36684")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BF80", Offset = "0xB8BF80")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000686")]
				[Address(RVA = "0x1F36690", Offset = "0x1F36690", VA = "0x1F36690")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BF90", Offset = "0xB8BF90")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009A")]
			public Transform transform
			{
				[Token(Token = "0x6000687")]
				[Address(RVA = "0x1F3669C", Offset = "0x1F3669C", VA = "0x1F3669C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BFA0", Offset = "0xB8BFA0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000688")]
				[Address(RVA = "0x1F366A4", Offset = "0x1F366A4", VA = "0x1F366A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BFB0", Offset = "0xB8BFB0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009B")]
			public float IKOffset
			{
				[Token(Token = "0x6000689")]
				[Address(RVA = "0x1F366AC", Offset = "0x1F366AC", VA = "0x1F366AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BFC0", Offset = "0xB8BFC0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600068A")]
				[Address(RVA = "0x1F366B4", Offset = "0x1F366B4", VA = "0x1F366B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BFD0", Offset = "0xB8BFD0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x600068F")]
				[Address(RVA = "0x1F37204", Offset = "0x1F37204", VA = "0x1F37204")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700009D")]
			private float rootYOffset
			{
				[Token(Token = "0x6000698")]
				[Address(RVA = "0x1F374F8", Offset = "0x1F374F8", VA = "0x1F374F8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x1F3526C", Offset = "0x1F3526C", VA = "0x1F3526C")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0x1F366BC", Offset = "0x1F366BC", VA = "0x1F366BC")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x1F36154", Offset = "0x1F36154", VA = "0x1F36154")]
			public void Reset()
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x1F353B0", Offset = "0x1F353B0", VA = "0x1F353B0")]
			public void Process()
			{
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x1F36D9C", Offset = "0x1F36D9C", VA = "0x1F36D9C")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x1F36708", Offset = "0x1F36708", VA = "0x1F36708")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x1F37384", Offset = "0x1F37384", VA = "0x1F37384")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x1F36A2C", Offset = "0x1F36A2C", VA = "0x1F36A2C")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x1F36B34", Offset = "0x1F36B34", VA = "0x1F36B34")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x1F37480", Offset = "0x1F37480", VA = "0x1F37480")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x1F37290", Offset = "0x1F37290", VA = "0x1F37290")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x1F3762C", Offset = "0x1F3762C", VA = "0x1F3762C")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x1F351BC", Offset = "0x1F351BC", VA = "0x1F351BC")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000100")]
		public class Pelvis
		{
			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB863C0", Offset = "0xB863C0")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB863D0", Offset = "0xB863D0")]
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
				[Address(RVA = "0x1F3771C", Offset = "0x1F3771C", VA = "0x1F3771C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BFE0", Offset = "0xB8BFE0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600069B")]
				[Address(RVA = "0x1F37728", Offset = "0x1F37728", VA = "0x1F37728")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BFF0", Offset = "0xB8BFF0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009F")]
			public float heightOffset
			{
				[Token(Token = "0x600069C")]
				[Address(RVA = "0x1F37734", Offset = "0x1F37734", VA = "0x1F37734")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C000", Offset = "0xB8C000")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600069D")]
				[Address(RVA = "0x1F3773C", Offset = "0x1F3773C", VA = "0x1F3773C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C010", Offset = "0xB8C010")]
				private set
				{
				}
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x1F35368", Offset = "0x1F35368", VA = "0x1F35368")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x1F360A4", Offset = "0x1F360A4", VA = "0x1F360A4")]
			public void Reset()
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x1F37744", Offset = "0x1F37744", VA = "0x1F37744")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x1F35C20", Offset = "0x1F35C20", VA = "0x1F35C20")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x1F35264", Offset = "0x1F35264", VA = "0x1F35264")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83650", Offset = "0xB83650")]
		public LayerMask layers;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83688", Offset = "0xB83688")]
		public float maxStep;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB836C0", Offset = "0xB836C0")]
		public float heightOffset;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB836F8", Offset = "0xB836F8")]
		public float footSpeed;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83730", Offset = "0xB83730")]
		public float footRadius;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83768", Offset = "0xB83768")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB837B4", Offset = "0xB837B4")]
		public float prediction;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB837EC", Offset = "0xB837EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB837EC", Offset = "0xB837EC")]
		public float footRotationWeight;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83840", Offset = "0xB83840")]
		public float footRotationSpeed;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83878", Offset = "0xB83878")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB83878", Offset = "0xB83878")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB838D0", Offset = "0xB838D0")]
		public bool rotateSolver;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83908", Offset = "0xB83908")]
		public float pelvisSpeed;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83940", Offset = "0xB83940")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB83940", Offset = "0xB83940")]
		public float pelvisDamper;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83994", Offset = "0xB83994")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB839CC", Offset = "0xB839CC")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83A04", Offset = "0xB83A04")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83A3C", Offset = "0xB83A3C")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83A74", Offset = "0xB83A74")]
		public Quality quality;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB83AAC", Offset = "0xB83AAC")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB83ABC", Offset = "0xB83ABC")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB83ACC", Offset = "0xB83ACC")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB83ADC", Offset = "0xB83ADC")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB83AEC", Offset = "0xB83AEC")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000029")]
		public Leg[] legs
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x1F34B98", Offset = "0x1F34B98", VA = "0x1F34B98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8A210", Offset = "0xB8A210")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x1F34BA0", Offset = "0x1F34BA0", VA = "0x1F34BA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8A220", Offset = "0xB8A220")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x1F34BA8", Offset = "0x1F34BA8", VA = "0x1F34BA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8A230", Offset = "0xB8A230")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x1F34BB0", Offset = "0x1F34BB0", VA = "0x1F34BB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8A240", Offset = "0xB8A240")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public bool isGrounded
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x1F34BB8", Offset = "0x1F34BB8", VA = "0x1F34BB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8A250", Offset = "0xB8A250")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x1F34BC0", Offset = "0x1F34BC0", VA = "0x1F34BC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8A260", Offset = "0xB8A260")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public Transform root
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x1F34BCC", Offset = "0x1F34BCC", VA = "0x1F34BCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8A270", Offset = "0xB8A270")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x1F34BD4", Offset = "0x1F34BD4", VA = "0x1F34BD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8A280", Offset = "0xB8A280")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x1F34BDC", Offset = "0x1F34BDC", VA = "0x1F34BDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8A290", Offset = "0xB8A290")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x1F34BF4", Offset = "0x1F34BF4", VA = "0x1F34BF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8A2A0", Offset = "0xB8A2A0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public bool rootGrounded
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x1F34C14", Offset = "0x1F34C14", VA = "0x1F34C14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		public Vector3 up
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x1F35048", Offset = "0x1F35048", VA = "0x1F35048")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000030")]
		private bool useRootRotation
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x1F36208", Offset = "0x1F36208", VA = "0x1F36208")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1F34C68", Offset = "0x1F34C68", VA = "0x1F34C68")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1F350D4", Offset = "0x1F350D4", VA = "0x1F350D4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1F32070", Offset = "0x1F32070", VA = "0x1F32070")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1F33448", Offset = "0x1F33448", VA = "0x1F33448")]
		public void Update()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1F35E8C", Offset = "0x1F35E8C", VA = "0x1F35E8C")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1F3153C", Offset = "0x1F3153C", VA = "0x1F3153C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1F35398", Offset = "0x1F35398", VA = "0x1F35398")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1F362D8", Offset = "0x1F362D8", VA = "0x1F362D8")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1F36440", Offset = "0x1F36440", VA = "0x1F36440")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1F36544", Offset = "0x1F36544", VA = "0x1F36544")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1F33E58", Offset = "0x1F33E58", VA = "0x1F33E58")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB80DF8", Offset = "0xB80DF8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB80DF8", Offset = "0xB80DF8")]
	public class AimIK : IK
	{
		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x181B0F0", Offset = "0x181B0F0", VA = "0x181B0F0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A2B0", Offset = "0xB8A2B0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x181B13C", Offset = "0x181B13C", VA = "0x181B13C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A2E8", Offset = "0xB8A2E8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x181B188", Offset = "0x181B188", VA = "0x181B188")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A320", Offset = "0xB8A320")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x181B1D4", Offset = "0x181B1D4", VA = "0x181B1D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A358", Offset = "0xB8A358")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x181B220", Offset = "0x181B220", VA = "0x181B220")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A390", Offset = "0xB8A390")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x181B26C", Offset = "0x181B26C", VA = "0x181B26C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x181B274", Offset = "0x181B274", VA = "0x181B274")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB80E58", Offset = "0xB80E58")]
	public class ArmIK : IK
	{
		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x181BBF4", Offset = "0x181BBF4", VA = "0x181BBF4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A3C8", Offset = "0xB8A3C8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x181BC60", Offset = "0x181BC60", VA = "0x181BC60", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A400", Offset = "0xB8A400")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x181BCCC", Offset = "0x181BCCC", VA = "0x181BCCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A438", Offset = "0xB8A438")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x181BD18", Offset = "0x181BD18", VA = "0x181BD18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A470", Offset = "0xB8A470")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x181BD64", Offset = "0x181BD64", VA = "0x181BD64", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x181BD6C", Offset = "0x181BD6C", VA = "0x181BD6C")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB80E90", Offset = "0xB80E90")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB80E90", Offset = "0xB80E90")]
	public class CCDIK : IK
	{
		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x181D4F8", Offset = "0x181D4F8", VA = "0x181D4F8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A4A8", Offset = "0xB8A4A8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x181D544", Offset = "0x181D544", VA = "0x181D544", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A4E0", Offset = "0xB8A4E0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x181D590", Offset = "0x181D590", VA = "0x181D590")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A518", Offset = "0xB8A518")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x181D5DC", Offset = "0x181D5DC", VA = "0x181D5DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A550", Offset = "0xB8A550")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x181D628", Offset = "0x181D628", VA = "0x181D628", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x181D630", Offset = "0x181D630", VA = "0x181D630")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB80EF0", Offset = "0xB80EF0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB80EF0", Offset = "0xB80EF0")]
	public class FABRIK : IK
	{
		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x181DF78", Offset = "0x181DF78", VA = "0x181DF78", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A588", Offset = "0xB8A588")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x181DFC4", Offset = "0x181DFC4", VA = "0x181DFC4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A5C0", Offset = "0xB8A5C0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x181E010", Offset = "0x181E010", VA = "0x181E010")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A5F8", Offset = "0xB8A5F8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x181E05C", Offset = "0x181E05C", VA = "0x181E05C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A630", Offset = "0xB8A630")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x181E0A8", Offset = "0x181E0A8", VA = "0x181E0A8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x181E0B0", Offset = "0x181E0B0", VA = "0x181E0B0")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB80F50", Offset = "0xB80F50")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB80F50", Offset = "0xB80F50")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x181E754", Offset = "0x181E754", VA = "0x181E754", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A668", Offset = "0xB8A668")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x181E7A0", Offset = "0x181E7A0", VA = "0x181E7A0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A6A0", Offset = "0xB8A6A0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x181E7EC", Offset = "0x181E7EC", VA = "0x181E7EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A6D8", Offset = "0xB8A6D8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x181E838", Offset = "0x181E838", VA = "0x181E838")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A710", Offset = "0xB8A710")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x181E884", Offset = "0x181E884", VA = "0x181E884", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x181E88C", Offset = "0x181E88C", VA = "0x181E88C")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB80FB0", Offset = "0xB80FB0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB80FB0", Offset = "0xB80FB0")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x18268E4", Offset = "0x18268E4", VA = "0x18268E4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A748", Offset = "0xB8A748")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1826930", Offset = "0x1826930", VA = "0x1826930", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A780", Offset = "0xB8A780")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x182697C", Offset = "0x182697C", VA = "0x182697C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A7B8", Offset = "0xB8A7B8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x18269C8", Offset = "0x18269C8", VA = "0x18269C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A7F0", Offset = "0xB8A7F0")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1826A14", Offset = "0x1826A14", VA = "0x1826A14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A828", Offset = "0xB8A828")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1826A60", Offset = "0x1826A60", VA = "0x1826A60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A860", Offset = "0xB8A860")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1826AAC", Offset = "0x1826AAC", VA = "0x1826AAC")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1826AF0", Offset = "0x1826AF0", VA = "0x1826AF0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1826AF8", Offset = "0x1826AF8", VA = "0x1826AF8")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1826CC0", Offset = "0x1826CC0", VA = "0x1826CC0")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1827020", Offset = "0x1827020", VA = "0x1827020")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A898", Offset = "0xB8A898")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1827040", Offset = "0x1827040", VA = "0x1827040")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A8D0", Offset = "0xB8A8D0")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1827134", Offset = "0x1827134", VA = "0x1827134")]
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
		[Address(RVA = "0x1F3A290", Offset = "0x1F3A290", VA = "0x1F3A290", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1F3A37C", Offset = "0x1F3A37C", VA = "0x1F3A37C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1F3A544", Offset = "0x1F3A544", VA = "0x1F3A544", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600031D")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600031E")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1F3A5A4", Offset = "0x1F3A5A4", VA = "0x1F3A5A4")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83AFC", Offset = "0xB83AFC")]
		public IK[] IKComponents;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83B34", Offset = "0xB83B34")]
		public Animator animator;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000031")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x1F3D5FC", Offset = "0x1F3D5FC", VA = "0x1F3D5FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1F3D698", Offset = "0x1F3D698", VA = "0x1F3D698")]
		private void Start()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1F3D708", Offset = "0x1F3D708", VA = "0x1F3D708")]
		private void Update()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1F3D7C4", Offset = "0x1F3D7C4", VA = "0x1F3D7C4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1F3D800", Offset = "0x1F3D800", VA = "0x1F3D800")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1F3D73C", Offset = "0x1F3D73C", VA = "0x1F3D73C")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1F3D88C", Offset = "0x1F3D88C", VA = "0x1F3D88C")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB81010", Offset = "0xB81010")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1C46E3C", Offset = "0x1C46E3C", VA = "0x1C46E3C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A908", Offset = "0xB8A908")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1C46EA8", Offset = "0x1C46EA8", VA = "0x1C46EA8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A940", Offset = "0xB8A940")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1C46F14", Offset = "0x1C46F14", VA = "0x1C46F14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A978", Offset = "0xB8A978")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1C46F60", Offset = "0x1C46F60", VA = "0x1C46F60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A9B0", Offset = "0xB8A9B0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1C46FAC", Offset = "0x1C46FAC", VA = "0x1C46FAC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1C46FB4", Offset = "0x1C46FB4", VA = "0x1C46FB4")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB81048", Offset = "0xB81048")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB81048", Offset = "0xB81048")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1C47028", Offset = "0x1C47028", VA = "0x1C47028", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8A9E8", Offset = "0xB8A9E8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1C47074", Offset = "0x1C47074", VA = "0x1C47074", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AA20", Offset = "0xB8AA20")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1C470C0", Offset = "0x1C470C0", VA = "0x1C470C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AA58", Offset = "0xB8AA58")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1C4710C", Offset = "0x1C4710C", VA = "0x1C4710C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AA90", Offset = "0xB8AA90")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1C47158", Offset = "0x1C47158", VA = "0x1C47158", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1C47160", Offset = "0x1C47160", VA = "0x1C47160")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB810A8", Offset = "0xB810A8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB810A8", Offset = "0xB810A8")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1C48018", Offset = "0x1C48018", VA = "0x1C48018", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AAC8", Offset = "0xB8AAC8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1C48064", Offset = "0x1C48064", VA = "0x1C48064", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AB00", Offset = "0xB8AB00")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1C480B0", Offset = "0x1C480B0", VA = "0x1C480B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AB38", Offset = "0xB8AB38")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1C480FC", Offset = "0x1C480FC", VA = "0x1C480FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AB70", Offset = "0xB8AB70")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1C48148", Offset = "0x1C48148", VA = "0x1C48148", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1C48150", Offset = "0x1C48150", VA = "0x1C48150")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB81108", Offset = "0xB81108")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB81108", Offset = "0xB81108")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1D6CD80", Offset = "0x1D6CD80", VA = "0x1D6CD80", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8ABA8", Offset = "0xB8ABA8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1D6CDCC", Offset = "0x1D6CDCC", VA = "0x1D6CDCC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8ABE0", Offset = "0xB8ABE0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1D6CE18", Offset = "0x1D6CE18", VA = "0x1D6CE18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AC18", Offset = "0xB8AC18")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1D6CE64", Offset = "0x1D6CE64", VA = "0x1D6CE64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AC50", Offset = "0xB8AC50")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1D6CEB0", Offset = "0x1D6CEB0", VA = "0x1D6CEB0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1D6CEB8", Offset = "0x1D6CEB8", VA = "0x1D6CEB8")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB81168", Offset = "0xB81168")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB863E0", Offset = "0xB863E0")]
			public Transform chest;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86418", Offset = "0xB86418")]
			public Transform neck;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86450", Offset = "0xB86450")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86488", Offset = "0xB86488")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB864C0", Offset = "0xB864C0")]
			public Transform leftThigh;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB864F8", Offset = "0xB864F8")]
			public Transform leftCalf;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86530", Offset = "0xB86530")]
			public Transform leftFoot;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86568", Offset = "0xB86568")]
			public Transform leftToes;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB865A0", Offset = "0xB865A0")]
			public Transform rightThigh;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB865D8", Offset = "0xB865D8")]
			public Transform rightCalf;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86610", Offset = "0xB86610")]
			public Transform rightFoot;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86648", Offset = "0xB86648")]
			public Transform rightToes;

			[Token(Token = "0x170000A0")]
			public bool isFilled
			{
				[Token(Token = "0x60006A4")]
				[Address(RVA = "0x1D6E570", Offset = "0x1D6E570", VA = "0x1D6E570")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A1")]
			public bool isEmpty
			{
				[Token(Token = "0x60006A5")]
				[Address(RVA = "0x1D6E0F4", Offset = "0x1D6E0F4", VA = "0x1D6E0F4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x1D6EC0C", Offset = "0x1D6EC0C", VA = "0x1D6EC0C")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x1D6DBD0", Offset = "0x1D6DBD0", VA = "0x1D6DBD0")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x1D6EC04", Offset = "0x1D6EC04", VA = "0x1D6EC04")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0xB83B6C", Offset = "0xB83B6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83B6C", Offset = "0xB83B6C")]
		public References references;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83BE8", Offset = "0xB83BE8")]
		public IKSolverVR solver;

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1D6DA84", Offset = "0x1D6DA84", VA = "0x1D6DA84", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AC88", Offset = "0xB8AC88")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1D6DAF0", Offset = "0x1D6DAF0", VA = "0x1D6DAF0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8ACC0", Offset = "0xB8ACC0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1D6DB5C", Offset = "0x1D6DB5C", VA = "0x1D6DB5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8ACF8", Offset = "0xB8ACF8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1D6DBA8", Offset = "0x1D6DBA8", VA = "0x1D6DBA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AD30", Offset = "0xB8AD30")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1D6E050", Offset = "0x1D6E050", VA = "0x1D6E050")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AD68", Offset = "0xB8AD68")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1D6E078", Offset = "0x1D6E078", VA = "0x1D6E078", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1D6E080", Offset = "0x1D6E080", VA = "0x1D6E080", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1D6E9EC", Offset = "0x1D6E9EC", VA = "0x1D6E9EC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1D6EB64", Offset = "0x1D6EB64", VA = "0x1D6EB64")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB83C20", Offset = "0xB83C20")]
		public float pull;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB83C38", Offset = "0xB83C38")]
		public float pin;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x181E124", Offset = "0x181E124", VA = "0x181E124")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x181E1F8", Offset = "0x181E1F8", VA = "0x181E1F8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x181E218", Offset = "0x181E218", VA = "0x181E218")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x181E5E8", Offset = "0x181E5E8", VA = "0x181E5E8")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x181E2EC", Offset = "0x181E2EC", VA = "0x181E2EC")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x181E6E0", Offset = "0x181E6E0", VA = "0x181E6E0")]
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
		[Address(RVA = "0x181E900", Offset = "0x181E900", VA = "0x181E900")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x181EE7C", Offset = "0x181EE7C", VA = "0x181EE7C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x181F03C", Offset = "0x181F03C", VA = "0x181F03C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x181F158", Offset = "0x181F158", VA = "0x181F158")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86680", Offset = "0xB86680")]
			public Transform transform;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB866B8", Offset = "0xB866B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB866B8", Offset = "0xB866B8")]
			public float weight;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x18222E8", Offset = "0x18222E8", VA = "0x18222E8")]
			public BendBone()
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x1822368", Offset = "0x1822368", VA = "0x1822368")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x181F9A8", Offset = "0x181F9A8", VA = "0x181F9A8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x181FDAC", Offset = "0x181FDAC", VA = "0x181FDAC")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83C50", Offset = "0xB83C50")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB83C88", Offset = "0xB83C88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83C88", Offset = "0xB83C88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB83C88", Offset = "0xB83C88")]
		public float positionWeight;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83D00", Offset = "0xB83D00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB83D00", Offset = "0xB83D00")]
		public float bodyWeight;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83D54", Offset = "0xB83D54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB83D54", Offset = "0xB83D54")]
		public float thighWeight;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83DA8", Offset = "0xB83DA8")]
		public bool handsPullBody;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB83DE0", Offset = "0xB83DE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83DE0", Offset = "0xB83DE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB83DE0", Offset = "0xB83DE0")]
		public float rotationWeight;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83E58", Offset = "0xB83E58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB83E58", Offset = "0xB83E58")]
		public float bodyClampWeight;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83EAC", Offset = "0xB83EAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB83EAC", Offset = "0xB83EAC")]
		public float headClampWeight;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83F00", Offset = "0xB83F00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB83F00", Offset = "0xB83F00")]
		public float bendWeight;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83F54", Offset = "0xB83F54")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB83F8C", Offset = "0xB83F8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB83F8C", Offset = "0xB83F8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB83F8C", Offset = "0xB83F8C")]
		public float CCDWeight;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84004", Offset = "0xB84004")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB84004", Offset = "0xB84004")]
		public float roll;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84058", Offset = "0xB84058")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB84058", Offset = "0xB84058")]
		public float damper;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB840B0", Offset = "0xB840B0")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB840E8", Offset = "0xB840E8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB840E8", Offset = "0xB840E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB840E8", Offset = "0xB840E8")]
		public float postStretchWeight;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84160", Offset = "0xB84160")]
		public float maxStretch;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84198", Offset = "0xB84198")]
		public float stretchDamper;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB841D0", Offset = "0xB841D0")]
		public bool fixHead;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84208", Offset = "0xB84208")]
		public Transform[] stretchBones;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB84240", Offset = "0xB84240")]
		public Vector3 chestDirection;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB84278", Offset = "0xB84278")]
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
		[Address(RVA = "0x181F160", Offset = "0x181F160", VA = "0x181F160")]
		private void Start()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x181F4E4", Offset = "0x181F4E4", VA = "0x181F4E4")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x181F9E0", Offset = "0x181F9E0", VA = "0x181F9E0")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x181FDD4", Offset = "0x181FDD4", VA = "0x181FDD4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x182074C", Offset = "0x182074C", VA = "0x182074C")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1820A98", Offset = "0x1820A98", VA = "0x1820A98")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1820E34", Offset = "0x1820E34", VA = "0x1820E34")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x18218A0", Offset = "0x18218A0", VA = "0x18218A0")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1820478", Offset = "0x1820478", VA = "0x1820478")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1821AB0", Offset = "0x1821AB0", VA = "0x1821AB0")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x182175C", Offset = "0x182175C", VA = "0x182175C")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x18215C0", Offset = "0x18215C0", VA = "0x18215C0")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1821E1C", Offset = "0x1821E1C", VA = "0x1821E1C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1822100", Offset = "0x1822100", VA = "0x1822100")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8672C", Offset = "0xB8672C")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8673C", Offset = "0xB8673C")]
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
				[Address(RVA = "0x182531C", Offset = "0x182531C", VA = "0x182531C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C020", Offset = "0xB8C020")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006AD")]
				[Address(RVA = "0x1825324", Offset = "0x1825324", VA = "0x1825324")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C030", Offset = "0xB8C030")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			public bool isRigid
			{
				[Token(Token = "0x60006AE")]
				[Address(RVA = "0x182532C", Offset = "0x182532C", VA = "0x182532C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C040", Offset = "0xB8C040")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006AF")]
				[Address(RVA = "0x1825334", Offset = "0x1825334", VA = "0x1825334")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C050", Offset = "0xB8C050")]
				private set
				{
				}
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x1825340", Offset = "0x1825340", VA = "0x1825340")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x18230A0", Offset = "0x18230A0", VA = "0x18230A0")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x18235E0", Offset = "0x18235E0", VA = "0x18235E0")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x1825018", Offset = "0x1825018", VA = "0x1825018")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB84290", Offset = "0xB84290")]
		public float pin;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB842A8", Offset = "0xB842A8")]
		public float pull;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB842C0", Offset = "0xB842C0")]
		public float push;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB842D8", Offset = "0xB842D8")]
		public float pushParent;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB842F0", Offset = "0xB842F0")]
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
		[Address(RVA = "0x1822418", Offset = "0x1822418", VA = "0x1822418")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1822514", Offset = "0x1822514", VA = "0x1822514")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1822664", Offset = "0x1822664", VA = "0x1822664")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1822798", Offset = "0x1822798", VA = "0x1822798")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1822874", Offset = "0x1822874", VA = "0x1822874")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1822984", Offset = "0x1822984", VA = "0x1822984")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x18230F8", Offset = "0x18230F8", VA = "0x18230F8")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x1822B20", Offset = "0x1822B20", VA = "0x1822B20")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x18237E4", Offset = "0x18237E4", VA = "0x18237E4")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1823B88", Offset = "0x1823B88", VA = "0x1823B88")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1823F6C", Offset = "0x1823F6C", VA = "0x1823F6C")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x18244F0", Offset = "0x18244F0", VA = "0x18244F0")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1824AC0", Offset = "0x1824AC0", VA = "0x1824AC0")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1824D58", Offset = "0x1824D58", VA = "0x1824D58")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x18249B8", Offset = "0x18249B8", VA = "0x18249B8")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x18242D8", Offset = "0x18242D8", VA = "0x18242D8")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1824940", Offset = "0x1824940", VA = "0x1824940")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1824E40", Offset = "0x1824E40", VA = "0x1824E40")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1824860", Offset = "0x1824860", VA = "0x1824860")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1824C40", Offset = "0x1824C40", VA = "0x1824C40")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB84308", Offset = "0xB84308")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB84320", Offset = "0xB84320")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000032")]
		public bool initiated
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x1F3A774", Offset = "0x1F3A774", VA = "0x1F3A774")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8ADA0", Offset = "0xB8ADA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x1F3A77C", Offset = "0x1F3A77C", VA = "0x1F3A77C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8ADB0", Offset = "0xB8ADB0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1F3A5AC", Offset = "0x1F3A5AC", VA = "0x1F3A5AC")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1F3A788", Offset = "0x1F3A788", VA = "0x1F3A788")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1F3A80C", Offset = "0x1F3A80C", VA = "0x1F3A80C")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1F3A8C0", Offset = "0x1F3A8C0", VA = "0x1F3A8C0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1F3A910", Offset = "0x1F3A910", VA = "0x1F3A910")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1F3AE00", Offset = "0x1F3AE00", VA = "0x1F3AE00")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1F3B038", Offset = "0x1F3B038", VA = "0x1F3B038")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1F3B4D4", Offset = "0x1F3B4D4", VA = "0x1F3B4D4")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1F3ABC0", Offset = "0x1F3ABC0", VA = "0x1F3ABC0")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1F3ACE0", Offset = "0x1F3ACE0", VA = "0x1F3ACE0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB84330", Offset = "0xB84330")]
		public float positionWeight;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB84348", Offset = "0xB84348")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB84360", Offset = "0xB84360")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB84370", Offset = "0xB84370")]
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
			[Address(RVA = "0x1F3BB40", Offset = "0x1F3BB40", VA = "0x1F3BB40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8ADC0", Offset = "0xB8ADC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x1F3BB48", Offset = "0x1F3BB48", VA = "0x1F3BB48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8ADD0", Offset = "0xB8ADD0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1F3BAD8", Offset = "0x1F3BAD8", VA = "0x1F3BAD8")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1F3BB54", Offset = "0x1F3BB54", VA = "0x1F3BB54")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1F3BC28", Offset = "0x1F3BC28", VA = "0x1F3BC28")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1F3BD94", Offset = "0x1F3BD94", VA = "0x1F3BD94")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1F3BF3C", Offset = "0x1F3BF3C", VA = "0x1F3BF3C")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1F3C238", Offset = "0x1F3C238", VA = "0x1F3C238")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1F3C510", Offset = "0x1F3C510", VA = "0x1F3C510")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1F3C650", Offset = "0x1F3C650", VA = "0x1F3C650")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1F3C6FC", Offset = "0x1F3C6FC", VA = "0x1F3C6FC")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1F3CD50", Offset = "0x1F3CD50", VA = "0x1F3CD50")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1F3CDC0", Offset = "0x1F3CDC0", VA = "0x1F3CDC0")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1F3CFD8", Offset = "0x1F3CFD8", VA = "0x1F3CFD8")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1F3D320", Offset = "0x1F3D320", VA = "0x1F3D320")]
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
				[Address(RVA = "0x1F3DB30", Offset = "0x1F3DB30", VA = "0x1F3DB30")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A5")]
			public bool isNodeBone
			{
				[Token(Token = "0x60006B8")]
				[Address(RVA = "0x1F3DC9C", Offset = "0x1F3DC9C", VA = "0x1F3DC9C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A6")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60006CC")]
				[Address(RVA = "0x1F3E2AC", Offset = "0x1F3E2AC", VA = "0x1F3E2AC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x1F3DAE0", Offset = "0x1F3DAE0", VA = "0x1F3DAE0")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x1F3DBFC", Offset = "0x1F3DBFC", VA = "0x1F3DBFC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x1F3DC4C", Offset = "0x1F3DC4C", VA = "0x1F3DC4C")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x1F3DCAC", Offset = "0x1F3DCAC", VA = "0x1F3DCAC")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x1F3DD94", Offset = "0x1F3DD94", VA = "0x1F3DD94")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x1F3DD9C", Offset = "0x1F3DD9C", VA = "0x1F3DD9C")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x1F3DF2C", Offset = "0x1F3DF2C", VA = "0x1F3DF2C")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x1F3E038", Offset = "0x1F3E038", VA = "0x1F3E038")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x1F3E0FC", Offset = "0x1F3E0FC", VA = "0x1F3E0FC")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x1F3E4D0", Offset = "0x1F3E4D0", VA = "0x1F3E4D0")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x1F3E508", Offset = "0x1F3E508", VA = "0x1F3E508")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1F3E540", Offset = "0x1F3E540", VA = "0x1F3E540")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x1F3E568", Offset = "0x1F3E568", VA = "0x1F3E568")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1F3E694", Offset = "0x1F3E694", VA = "0x1F3E694")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x1F3E9DC", Offset = "0x1F3E9DC", VA = "0x1F3E9DC")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x1F3EA0C", Offset = "0x1F3EA0C", VA = "0x1F3EA0C")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x1F3EBA4", Offset = "0x1F3EBA4", VA = "0x1F3EBA4")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1F3EC14", Offset = "0x1F3EC14", VA = "0x1F3EC14")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x1F3EE58", Offset = "0x1F3EE58", VA = "0x1F3EE58")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x1F3F080", Offset = "0x1F3F080", VA = "0x1F3F080")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x1F3F198", Offset = "0x1F3F198", VA = "0x1F3F198")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x1F3E7D8", Offset = "0x1F3E7D8", VA = "0x1F3E7D8")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x1F3F334", Offset = "0x1F3F334", VA = "0x1F3F334")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1F3D894", Offset = "0x1F3D894", VA = "0x1F3D894", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1F3D89C", Offset = "0x1F3D89C", VA = "0x1F3D89C", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1F3D8A0", Offset = "0x1F3D8A0", VA = "0x1F3D8A0")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1F3D9D0", Offset = "0x1F3D9D0", VA = "0x1F3D9D0")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1F3DAD8", Offset = "0x1F3DAD8", VA = "0x1F3DAD8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB84388", Offset = "0xB84388")]
		public float maintainRotationWeight;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1F3F350", Offset = "0x1F3F350", VA = "0x1F3F350", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1F3F3FC", Offset = "0x1F3F3FC", VA = "0x1F3F3FC")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1F3F48C", Offset = "0x1F3F48C", VA = "0x1F3F48C")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1F3F538", Offset = "0x1F3F538", VA = "0x1F3F538")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1F3F550", Offset = "0x1F3F550", VA = "0x1F3F550")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1F3F56C", Offset = "0x1F3F56C", VA = "0x1F3F56C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1F3F618", Offset = "0x1F3F618", VA = "0x1F3F618")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1F3F630", Offset = "0x1F3F630", VA = "0x1F3F630")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB843A0", Offset = "0xB843A0")]
		public float maintainRotationWeight;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB843B8", Offset = "0xB843B8")]
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
		[Address(RVA = "0x1F3F654", Offset = "0x1F3F654", VA = "0x1F3F654", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1F3F6D8", Offset = "0x1F3F6D8", VA = "0x1F3F6D8")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1F3F7AC", Offset = "0x1F3F7AC", VA = "0x1F3F7AC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1F3FB00", Offset = "0x1F3FB00", VA = "0x1F3FB00")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1F3FC30", Offset = "0x1F3FC30", VA = "0x1F3FC30")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1F3FD98", Offset = "0x1F3FD98", VA = "0x1F3FD98")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1F3FDFC", Offset = "0x1F3FDFC", VA = "0x1F3FDFC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1F3FEA4", Offset = "0x1F3FEA4", VA = "0x1F3FEA4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1F3FF5C", Offset = "0x1F3FF5C", VA = "0x1F3FF5C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1F40224", Offset = "0x1F40224", VA = "0x1F40224")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1F402DC", Offset = "0x1F402DC", VA = "0x1F402DC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB843D0", Offset = "0xB843D0")]
		public int iterations;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB843E8", Offset = "0xB843E8")]
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
		[Address(RVA = "0x1F40448", Offset = "0x1F40448", VA = "0x1F40448", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1F40740", Offset = "0x1F40740", VA = "0x1F40740")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1F40898", Offset = "0x1F40898", VA = "0x1F40898")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1F40A38", Offset = "0x1F40A38", VA = "0x1F40A38")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1F40AB8", Offset = "0x1F40AB8", VA = "0x1F40AB8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1F40B20", Offset = "0x1F40B20", VA = "0x1F40B20")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1F40BA0", Offset = "0x1F40BA0", VA = "0x1F40BA0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1F41278", Offset = "0x1F41278", VA = "0x1F41278")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1F412B0", Offset = "0x1F412B0", VA = "0x1F412B0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1F41590", Offset = "0x1F41590", VA = "0x1F41590")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1F41944", Offset = "0x1F41944", VA = "0x1F41944")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1F41A30", Offset = "0x1F41A30", VA = "0x1F41A30")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1F41AF8", Offset = "0x1F41AF8", VA = "0x1F41AF8")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8674C", Offset = "0xB8674C")]
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
			[Address(RVA = "0x1F43660", Offset = "0x1F43660", VA = "0x1F43660")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x1F436B0", Offset = "0x1F436B0", VA = "0x1F436B0")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x1F43838", Offset = "0x1F43838", VA = "0x1F43838")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x1F43870", Offset = "0x1F43870", VA = "0x1F43870")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x1F438A8", Offset = "0x1F438A8", VA = "0x1F438A8")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x1F438F8", Offset = "0x1F438F8", VA = "0x1F438F8")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x1F43108", Offset = "0x1F43108", VA = "0x1F43108")]
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
				[Address(RVA = "0x1F426C4", Offset = "0x1F426C4", VA = "0x1F426C4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x1F427C0", Offset = "0x1F427C0", VA = "0x1F427C0")]
				set
				{
				}
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x1F42854", Offset = "0x1F42854", VA = "0x1F42854")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x1F42B14", Offset = "0x1F42B14", VA = "0x1F42B14")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x1F42DF4", Offset = "0x1F42DF4", VA = "0x1F42DF4")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x1F4305C", Offset = "0x1F4305C", VA = "0x1F4305C")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x1F43084", Offset = "0x1F43084", VA = "0x1F43084")]
			public Bone()
			{
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x1F43188", Offset = "0x1F43188", VA = "0x1F43188")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x1F43228", Offset = "0x1F43228", VA = "0x1F43228")]
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
			[Address(RVA = "0x1F435E8", Offset = "0x1F435E8", VA = "0x1F435E8")]
			public Node()
			{
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x1F435EC", Offset = "0x1F435EC", VA = "0x1F435EC")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x1F4361C", Offset = "0x1F4361C", VA = "0x1F4361C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84410", Offset = "0xB84410")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB84410", Offset = "0xB84410")]
		public float IKPositionWeight;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB84464", Offset = "0xB84464")]
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
			[Address(RVA = "0x1F42114", Offset = "0x1F42114", VA = "0x1F42114")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8ADE0", Offset = "0xB8ADE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x1F4211C", Offset = "0x1F4211C", VA = "0x1F4211C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8ADF0", Offset = "0xB8ADF0")]
			private set
			{
			}
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1F41DE0", Offset = "0x1F41DE0", VA = "0x1F41DE0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B5")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1F3A3EC", Offset = "0x1F3A3EC", VA = "0x1F3A3EC")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1F3A314", Offset = "0x1F3A314", VA = "0x1F3A314")]
		public void Update()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1F42068", Offset = "0x1F42068", VA = "0x1F42068", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1F42074", Offset = "0x1F42074", VA = "0x1F42074")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1F42080", Offset = "0x1F42080", VA = "0x1F42080")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1F42088", Offset = "0x1F42088", VA = "0x1F42088")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1F4210C", Offset = "0x1F4210C", VA = "0x1F4210C")]
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
		[Address(RVA = "0x1F42128", Offset = "0x1F42128", VA = "0x1F42128")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1F42140", Offset = "0x1F42140", VA = "0x1F42140")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1F4227C", Offset = "0x1F4227C", VA = "0x1F4227C")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1F42328", Offset = "0x1F42328", VA = "0x1F42328")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1F426AC", Offset = "0x1F426AC", VA = "0x1F426AC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB844AC", Offset = "0xB844AC")]
		public float poleWeight;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB844C4", Offset = "0xB844C4")]
		public float clampWeight;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB844DC", Offset = "0xB844DC")]
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
			[Address(RVA = "0x1F43A80", Offset = "0x1F43A80", VA = "0x1F43A80")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000036")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x1F43B4C", Offset = "0x1F43B4C", VA = "0x1F43B4C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000037")]
		protected override int minBones
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x1F448DC", Offset = "0x1F448DC", VA = "0x1F448DC", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000038")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x1F44E80", Offset = "0x1F44E80", VA = "0x1F44E80", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1F43980", Offset = "0x1F43980", VA = "0x1F43980")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1F43C18", Offset = "0x1F43C18", VA = "0x1F43C18", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1F43E98", Offset = "0x1F43E98", VA = "0x1F43E98", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1F44828", Offset = "0x1F44828", VA = "0x1F44828")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1F44450", Offset = "0x1F44450", VA = "0x1F44450")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1F448E4", Offset = "0x1F448E4", VA = "0x1F448E4")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1F44EF4", Offset = "0x1F44EF4", VA = "0x1F44EF4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB844F4", Offset = "0xB844F4")]
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
		[Address(RVA = "0x1F44F8C", Offset = "0x1F44F8C", VA = "0x1F44F8C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1F45348", Offset = "0x1F45348", VA = "0x1F45348")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1F453FC", Offset = "0x1F453FC", VA = "0x1F453FC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1F45594", Offset = "0x1F45594", VA = "0x1F45594", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1F4572C", Offset = "0x1F4572C", VA = "0x1F4572C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1F45778", Offset = "0x1F45778", VA = "0x1F45778", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1F457D8", Offset = "0x1F457D8", VA = "0x1F457D8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1F45B48", Offset = "0x1F45B48", VA = "0x1F45B48", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1F45B74", Offset = "0x1F45B74", VA = "0x1F45B74")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1F4583C", Offset = "0x1F4583C", VA = "0x1F4583C")]
		private void Read()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1F45BE0", Offset = "0x1F45BE0", VA = "0x1F45BE0")]
		private void Write()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1F45D6C", Offset = "0x1F45D6C", VA = "0x1F45D6C")]
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
		[Address(RVA = "0x1F45F1C", Offset = "0x1F45F1C", VA = "0x1F45F1C")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1F45FCC", Offset = "0x1F45FCC", VA = "0x1F45FCC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1F46050", Offset = "0x1F46050", VA = "0x1F46050", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1F4634C", Offset = "0x1F4634C", VA = "0x1F4634C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1F46AA0", Offset = "0x1F46AA0", VA = "0x1F46AA0")]
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
			[Address(RVA = "0x1F47CEC", Offset = "0x1F47CEC", VA = "0x1F47CEC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1F46AA8", Offset = "0x1F46AA8", VA = "0x1F46AA8")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1F471F0", Offset = "0x1F471F0", VA = "0x1F471F0")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1F47328", Offset = "0x1F47328", VA = "0x1F47328", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1F473C0", Offset = "0x1F473C0", VA = "0x1F473C0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1F47984", Offset = "0x1F47984", VA = "0x1F47984", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1F47CF4", Offset = "0x1F47CF4", VA = "0x1F47CF4")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1F46B7C", Offset = "0x1F46B7C", VA = "0x1F46B7C")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1F472D4", Offset = "0x1F472D4", VA = "0x1F472D4")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1F47C90", Offset = "0x1F47C90", VA = "0x1F47C90")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1F47018", Offset = "0x1F47018", VA = "0x1F47018")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1F48534", Offset = "0x1F48534", VA = "0x1F48534")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1F48644", Offset = "0x1F48644", VA = "0x1F48644")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1F48770", Offset = "0x1F48770", VA = "0x1F48770")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1F48888", Offset = "0x1F48888", VA = "0x1F48888")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1F476EC", Offset = "0x1F476EC", VA = "0x1F476EC")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1F47838", Offset = "0x1F47838", VA = "0x1F47838")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1F48A74", Offset = "0x1F48A74", VA = "0x1F48A74")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1F47FAC", Offset = "0x1F47FAC", VA = "0x1F47FAC")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1F472C4", Offset = "0x1F472C4", VA = "0x1F472C4")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1F491DC", Offset = "0x1F491DC", VA = "0x1F491DC")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1F48C48", Offset = "0x1F48C48", VA = "0x1F48C48")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1F47E0C", Offset = "0x1F47E0C", VA = "0x1F47E0C")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1F47EE8", Offset = "0x1F47EE8", VA = "0x1F47EE8")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1F492A8", Offset = "0x1F492A8", VA = "0x1F492A8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8450C", Offset = "0xB8450C")]
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
		[Address(RVA = "0x1EB25CC", Offset = "0x1EB25CC", VA = "0x1EB25CC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1EB2FA4", Offset = "0x1EB2FA4", VA = "0x1EB2FA4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1EB303C", Offset = "0x1EB303C", VA = "0x1EB303C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1EB30DC", Offset = "0x1EB30DC", VA = "0x1EB30DC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1EB31EC", Offset = "0x1EB31EC", VA = "0x1EB31EC")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1EB3288", Offset = "0x1EB3288", VA = "0x1EB3288", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1EB37F0", Offset = "0x1EB37F0", VA = "0x1EB37F0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1EB3A08", Offset = "0x1EB3A08", VA = "0x1EB3A08", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1EB38A0", Offset = "0x1EB38A0", VA = "0x1EB38A0")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1EB34BC", Offset = "0x1EB34BC", VA = "0x1EB34BC")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1EB3AA0", Offset = "0x1EB3AA0", VA = "0x1EB3AA0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB84524", Offset = "0xB84524")]
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
		[Address(RVA = "0x1EB3B14", Offset = "0x1EB3B14", VA = "0x1EB3B14")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1EB3C08", Offset = "0x1EB3C08", VA = "0x1EB3C08")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1EB3C64", Offset = "0x1EB3C64", VA = "0x1EB3C64")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1EB3D98", Offset = "0x1EB3D98", VA = "0x1EB3D98")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1EB3DF4", Offset = "0x1EB3DF4", VA = "0x1EB3DF4")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1EB3E74", Offset = "0x1EB3E74", VA = "0x1EB3E74", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1EB4014", Offset = "0x1EB4014", VA = "0x1EB4014", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1EB4188", Offset = "0x1EB4188", VA = "0x1EB4188", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1EB4390", Offset = "0x1EB4390", VA = "0x1EB4390", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1EB4468", Offset = "0x1EB4468", VA = "0x1EB4468", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1EB4554", Offset = "0x1EB4554", VA = "0x1EB4554", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1EB46C8", Offset = "0x1EB46C8", VA = "0x1EB46C8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1EB4890", Offset = "0x1EB4890", VA = "0x1EB4890", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1EB4ADC", Offset = "0x1EB4ADC", VA = "0x1EB4ADC", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1EB4DB8", Offset = "0x1EB4DB8", VA = "0x1EB4DB8", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1EB4DFC", Offset = "0x1EB4DFC", VA = "0x1EB4DFC", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1EB4EEC", Offset = "0x1EB4EEC", VA = "0x1EB4EEC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8453C", Offset = "0xB8453C")]
		public float spineStiffness;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB84554", Offset = "0xB84554")]
		public float pullBodyVertical;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8456C", Offset = "0xB8456C")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB84584", Offset = "0xB84584")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700003A")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x1EB5000", Offset = "0x1EB5000", VA = "0x1EB5000")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x1EB5148", Offset = "0x1EB5148", VA = "0x1EB5148")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x1EB5150", Offset = "0x1EB5150", VA = "0x1EB5150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x1EB5158", Offset = "0x1EB5158", VA = "0x1EB5158")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x1EB5160", Offset = "0x1EB5160", VA = "0x1EB5160")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x1EB5168", Offset = "0x1EB5168", VA = "0x1EB5168")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x1EB5170", Offset = "0x1EB5170", VA = "0x1EB5170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x1EB5178", Offset = "0x1EB5178", VA = "0x1EB5178")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x1EB5180", Offset = "0x1EB5180", VA = "0x1EB5180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x1EB5188", Offset = "0x1EB5188", VA = "0x1EB5188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x1EB51C0", Offset = "0x1EB51C0", VA = "0x1EB51C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x1EB51F8", Offset = "0x1EB51F8", VA = "0x1EB51F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x1EB5230", Offset = "0x1EB5230", VA = "0x1EB5230")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x1EB5268", Offset = "0x1EB5268", VA = "0x1EB5268")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x1EB529C", Offset = "0x1EB529C", VA = "0x1EB529C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x1EB52D4", Offset = "0x1EB52D4", VA = "0x1EB52D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x1EB530C", Offset = "0x1EB530C", VA = "0x1EB530C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x1EB5344", Offset = "0x1EB5344", VA = "0x1EB5344")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x1EB75D0", Offset = "0x1EB75D0", VA = "0x1EB75D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8AE00", Offset = "0xB8AE00")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x1EB75DC", Offset = "0x1EB75DC", VA = "0x1EB75DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8AE10", Offset = "0xB8AE10")]
			private set
			{
			}
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1EB5378", Offset = "0x1EB5378", VA = "0x1EB5378")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1EB5484", Offset = "0x1EB5484", VA = "0x1EB5484")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1EB53CC", Offset = "0x1EB53CC", VA = "0x1EB53CC")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1EB5560", Offset = "0x1EB5560", VA = "0x1EB5560")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1EB5008", Offset = "0x1EB5008", VA = "0x1EB5008")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1EB5630", Offset = "0x1EB5630", VA = "0x1EB5630")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1EB56E8", Offset = "0x1EB56E8", VA = "0x1EB56E8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1EB579C", Offset = "0x1EB579C", VA = "0x1EB579C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1EB5850", Offset = "0x1EB5850", VA = "0x1EB5850")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1EB5858", Offset = "0x1EB5858", VA = "0x1EB5858")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1EB588C", Offset = "0x1EB588C", VA = "0x1EB588C")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1EB5954", Offset = "0x1EB5954", VA = "0x1EB5954", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1EB5AE8", Offset = "0x1EB5AE8", VA = "0x1EB5AE8")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1EB6EE8", Offset = "0x1EB6EE8", VA = "0x1EB6EE8")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1EB737C", Offset = "0x1EB737C", VA = "0x1EB737C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1EB73DC", Offset = "0x1EB73DC", VA = "0x1EB73DC")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1EB71FC", Offset = "0x1EB71FC", VA = "0x1EB71FC")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1EB72BC", Offset = "0x1EB72BC", VA = "0x1EB72BC")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1EB75E8", Offset = "0x1EB75E8", VA = "0x1EB75E8")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1EB76C4", Offset = "0x1EB76C4", VA = "0x1EB76C4", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1EB780C", Offset = "0x1EB780C", VA = "0x1EB780C")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1EB799C", Offset = "0x1EB799C", VA = "0x1EB799C")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1EB7B9C", Offset = "0x1EB7B9C", VA = "0x1EB7B9C")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1EB7D9C", Offset = "0x1EB7D9C", VA = "0x1EB7D9C", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1EB80D0", Offset = "0x1EB80D0", VA = "0x1EB80D0", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1EB81D0", Offset = "0x1EB81D0", VA = "0x1EB81D0")]
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
			[Address(RVA = "0x1EB8A74", Offset = "0x1EB8A74", VA = "0x1EB8A74", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004E")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x1EB8A7C", Offset = "0x1EB8A7C", VA = "0x1EB8A7C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x1EB8A84", Offset = "0x1EB8A84", VA = "0x1EB8A84", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000050")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x1EB9014", Offset = "0x1EB9014", VA = "0x1EB9014", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000051")]
		protected float positionOffset
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x1EB9148", Offset = "0x1EB9148", VA = "0x1EB9148")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1EB81DC", Offset = "0x1EB81DC", VA = "0x1EB81DC")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1EB8390", Offset = "0x1EB8390", VA = "0x1EB8390")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1EB84F4", Offset = "0x1EB84F4", VA = "0x1EB84F4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1EB8560", Offset = "0x1EB8560", VA = "0x1EB8560", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1EB85E0", Offset = "0x1EB85E0", VA = "0x1EB85E0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1EB8978", Offset = "0x1EB8978", VA = "0x1EB8978", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1EB8980", Offset = "0x1EB8980", VA = "0x1EB8980", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1EB8A8C", Offset = "0x1EB8A8C", VA = "0x1EB8A8C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1EB8A90", Offset = "0x1EB8A90", VA = "0x1EB8A90", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1EB8A94", Offset = "0x1EB8A94", VA = "0x1EB8A94")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1EB920C", Offset = "0x1EB920C", VA = "0x1EB920C")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1EB95B0", Offset = "0x1EB95B0", VA = "0x1EB95B0")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1EB9864", Offset = "0x1EB9864", VA = "0x1EB9864")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB84594", Offset = "0xB84594")]
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
		[Address(RVA = "0x1EB98E0", Offset = "0x1EB98E0", VA = "0x1EB98E0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1EB9C9C", Offset = "0x1EB9C9C", VA = "0x1EB9C9C")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1EB9D54", Offset = "0x1EB9D54", VA = "0x1EB9D54", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1EB9EEC", Offset = "0x1EB9EEC", VA = "0x1EB9EEC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1EBA084", Offset = "0x1EBA084", VA = "0x1EBA084", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1EBA0E0", Offset = "0x1EBA0E0", VA = "0x1EBA0E0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1EBA150", Offset = "0x1EBA150", VA = "0x1EBA150", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1EBA4BC", Offset = "0x1EBA4BC", VA = "0x1EBA4BC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1EBA4E8", Offset = "0x1EBA4E8", VA = "0x1EBA4E8")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1EBA1B4", Offset = "0x1EBA1B4", VA = "0x1EBA1B4")]
		private void Read()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1EBA5EC", Offset = "0x1EBA5EC", VA = "0x1EBA5EC")]
		private void Write()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1EBAE28", Offset = "0x1EBAE28", VA = "0x1EBAE28")]
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
			[Address(RVA = "0x1EBC850", Offset = "0x1EBC850", VA = "0x1EBC850")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB845AC", Offset = "0xB845AC")]
		public float maintainRotationWeight;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB845C4", Offset = "0xB845C4")]
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
			[Address(RVA = "0x1EBC834", Offset = "0x1EBC834", VA = "0x1EBC834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1EBB0DC", Offset = "0x1EBB0DC", VA = "0x1EBB0DC")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1EBB12C", Offset = "0x1EBB12C", VA = "0x1EBB12C")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1EBB240", Offset = "0x1EBB240", VA = "0x1EBB240", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1EBB8B0", Offset = "0x1EBB8B0", VA = "0x1EBB8B0", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1EBC48C", Offset = "0x1EBC48C", VA = "0x1EBC48C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1EBC5D4", Offset = "0x1EBC5D4", VA = "0x1EBC5D4")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1EBC794", Offset = "0x1EBC794", VA = "0x1EBC794")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1EBB5BC", Offset = "0x1EBB5BC", VA = "0x1EBB5BC")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1EBB9DC", Offset = "0x1EBB9DC", VA = "0x1EBB9DC")]
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
				[Address(RVA = "0x1EBE7C8", Offset = "0x1EBE7C8", VA = "0x1EBE7C8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x1EBEF6C", Offset = "0x1EBEF6C", VA = "0x1EBEF6C")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x1EBDB18", Offset = "0x1EBDB18", VA = "0x1EBDB18")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x1EBDEA0", Offset = "0x1EBDEA0", VA = "0x1EBDEA0")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x1EBEBCC", Offset = "0x1EBEBCC", VA = "0x1EBEBCC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB845DC", Offset = "0xB845DC")]
		public float bodyWeight;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB845F4", Offset = "0xB845F4")]
		public float headWeight;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8460C", Offset = "0xB8460C")]
		public float eyesWeight;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB84624", Offset = "0xB84624")]
		public float clampWeight;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8463C", Offset = "0xB8463C")]
		public float clampWeightHead;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB84654", Offset = "0xB84654")]
		public float clampWeightEyes;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8466C", Offset = "0xB8466C")]
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
			[Address(RVA = "0x1EBD1FC", Offset = "0x1EBD1FC", VA = "0x1EBD1FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x1EBD3D4", Offset = "0x1EBD3D4", VA = "0x1EBD3D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		private bool headIsValid
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x1EBD2E0", Offset = "0x1EBD2E0", VA = "0x1EBD2E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		private bool headIsEmpty
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x1EBD3F8", Offset = "0x1EBD3F8", VA = "0x1EBD3F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		private bool eyesIsValid
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x1EBD2F0", Offset = "0x1EBD2F0", VA = "0x1EBD2F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x1EBD474", Offset = "0x1EBD474", VA = "0x1EBD474")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1EBC8B0", Offset = "0x1EBC8B0", VA = "0x1EBC8B0")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1EBC934", Offset = "0x1EBC934", VA = "0x1EBC934")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1EBC9E0", Offset = "0x1EBC9E0", VA = "0x1EBC9E0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1EBCAA8", Offset = "0x1EBCAA8", VA = "0x1EBCAA8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1EBCB94", Offset = "0x1EBCB94", VA = "0x1EBCB94")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1EBCCA0", Offset = "0x1EBCCA0", VA = "0x1EBCCA0")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1EBCDE8", Offset = "0x1EBCDE8", VA = "0x1EBCDE8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1EBCF18", Offset = "0x1EBCF18", VA = "0x1EBCF18", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1EBD05C", Offset = "0x1EBD05C", VA = "0x1EBD05C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1EBD498", Offset = "0x1EBD498", VA = "0x1EBD498", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1EBD700", Offset = "0x1EBD700", VA = "0x1EBD700", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1EBD8A0", Offset = "0x1EBD8A0", VA = "0x1EBD8A0")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1EBDB4C", Offset = "0x1EBDB4C", VA = "0x1EBDB4C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1EBDFDC", Offset = "0x1EBDFDC", VA = "0x1EBDFDC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1EBE0E0", Offset = "0x1EBE0E0", VA = "0x1EBE0E0")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1EBE30C", Offset = "0x1EBE30C", VA = "0x1EBE30C")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1EBE568", Offset = "0x1EBE568", VA = "0x1EBE568")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1EBE894", Offset = "0x1EBE894", VA = "0x1EBE894")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1EBD968", Offset = "0x1EBD968", VA = "0x1EBD968")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1EBED34", Offset = "0x1EBED34", VA = "0x1EBED34")]
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
			[Address(RVA = "0x1EC05C0", Offset = "0x1EC05C0", VA = "0x1EC05C0")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x1EC1168", Offset = "0x1EC1168", VA = "0x1EC1168")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x1EBB174", Offset = "0x1EBB174", VA = "0x1EBB174")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x1EC1230", Offset = "0x1EC1230", VA = "0x1EC1230")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB84684", Offset = "0xB84684")]
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
		[Address(RVA = "0x1EBEF74", Offset = "0x1EBEF74", VA = "0x1EBEF74")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1EBF164", Offset = "0x1EBF164", VA = "0x1EBF164")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1EBF318", Offset = "0x1EBF318", VA = "0x1EBF318")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1EBF324", Offset = "0x1EBF324", VA = "0x1EBF324")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1EBF3A8", Offset = "0x1EBF3A8", VA = "0x1EBF3A8")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1EBF3B4", Offset = "0x1EBF3B4", VA = "0x1EBF3B4")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1EBF3BC", Offset = "0x1EBF3BC", VA = "0x1EBF3BC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1EBF4E4", Offset = "0x1EBF4E4", VA = "0x1EBF4E4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x1EBF604", Offset = "0x1EBF604", VA = "0x1EBF604", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1EBF650", Offset = "0x1EBF650", VA = "0x1EBF650", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x1EBF6B0", Offset = "0x1EBF6B0", VA = "0x1EBF6B0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x1EBFABC", Offset = "0x1EBFABC", VA = "0x1EBFABC")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1EBFB3C", Offset = "0x1EBFB3C", VA = "0x1EBFB3C")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1EC00E4", Offset = "0x1EC00E4", VA = "0x1EC00E4")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1EC02FC", Offset = "0x1EC02FC", VA = "0x1EC02FC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1EC04B8", Offset = "0x1EC04B8", VA = "0x1EC04B8")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1EC0434", Offset = "0x1EC0434", VA = "0x1EC0434")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1EC0760", Offset = "0x1EC0760", VA = "0x1EC0760", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1EC1224", Offset = "0x1EC1224", VA = "0x1EC1224", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1EC1228", Offset = "0x1EC1228", VA = "0x1EC1228", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1EC122C", Offset = "0x1EC122C", VA = "0x1EC122C", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1EC0E6C", Offset = "0x1EC0E6C", VA = "0x1EC0E6C")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1EBC660", Offset = "0x1EBC660", VA = "0x1EBC660")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86764", Offset = "0xB86764")]
			public Transform target;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8679C", Offset = "0xB8679C")]
			public Transform bendGoal;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB867D4", Offset = "0xB867D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB867D4", Offset = "0xB867D4")]
			public float positionWeight;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86828", Offset = "0xB86828")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB86828", Offset = "0xB86828")]
			public float rotationWeight;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8687C", Offset = "0xB8687C")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB868B4", Offset = "0xB868B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB868B4", Offset = "0xB868B4")]
			public float shoulderRotationWeight;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86908", Offset = "0xB86908")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB86908", Offset = "0xB86908")]
			public float shoulderTwistWeight;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8695C", Offset = "0xB8695C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8695C", Offset = "0xB8695C")]
			public float bendGoalWeight;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB869B0", Offset = "0xB869B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB869B0", Offset = "0xB869B0")]
			public float swivelOffset;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86A0C", Offset = "0xB86A0C")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86A44", Offset = "0xB86A44")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86A7C", Offset = "0xB86A7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB86A7C", Offset = "0xB86A7C")]
			public float armLengthMlp;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86AD4", Offset = "0xB86AD4")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB86B4C", Offset = "0xB86B4C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB86B5C", Offset = "0xB86B5C")]
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
				[Address(RVA = "0x1EC6D3C", Offset = "0x1EC6D3C", VA = "0x1EC6D3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C060", Offset = "0xB8C060")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006F4")]
				[Address(RVA = "0x1EC6D48", Offset = "0x1EC6D48", VA = "0x1EC6D48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C070", Offset = "0xB8C070")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AA")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006F5")]
				[Address(RVA = "0x1EC6D54", Offset = "0x1EC6D54", VA = "0x1EC6D54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C080", Offset = "0xB8C080")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006F6")]
				[Address(RVA = "0x1EC6D60", Offset = "0x1EC6D60", VA = "0x1EC6D60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C090", Offset = "0xB8C090")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AB")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60006F7")]
				[Address(RVA = "0x1EC6D6C", Offset = "0x1EC6D6C", VA = "0x1EC6D6C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x1EC6DA0", Offset = "0x1EC6DA0", VA = "0x1EC6DA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AD")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60006F9")]
				[Address(RVA = "0x1EC6DE0", Offset = "0x1EC6DE0", VA = "0x1EC6DE0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private VirtualBone hand
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x1EC6E2C", Offset = "0x1EC6E2C", VA = "0x1EC6E2C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x1EC6E78", Offset = "0x1EC6E78", VA = "0x1EC6E78", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x1EC7648", Offset = "0x1EC7648", VA = "0x1EC7648", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x1EC783C", Offset = "0x1EC783C", VA = "0x1EC783C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x1EC78E8", Offset = "0x1EC78E8", VA = "0x1EC78E8")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x1EC4FEC", Offset = "0x1EC4FEC", VA = "0x1EC4FEC")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x1EC8534", Offset = "0x1EC8534", VA = "0x1EC8534", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x1EC85A4", Offset = "0x1EC85A4", VA = "0x1EC85A4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x1EC7D00", Offset = "0x1EC7D00", VA = "0x1EC7D00")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x1EC7DD8", Offset = "0x1EC7DD8", VA = "0x1EC7DD8")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x1EC87C4", Offset = "0x1EC87C4", VA = "0x1EC87C4")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x1EC6C08", Offset = "0x1EC6C08", VA = "0x1EC6C08")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB86B6C", Offset = "0xB86B6C")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB86B7C", Offset = "0xB86B7C")]
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
				[Address(RVA = "0x1EC8990", Offset = "0x1EC8990", VA = "0x1EC8990")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C0A0", Offset = "0xB8C0A0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600070C")]
				[Address(RVA = "0x1EC8998", Offset = "0x1EC8998", VA = "0x1EC8998")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C0B0", Offset = "0xB8C0B0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B0")]
			public float mag
			{
				[Token(Token = "0x600070D")]
				[Address(RVA = "0x1EC89A0", Offset = "0x1EC89A0", VA = "0x1EC89A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C0C0", Offset = "0xB8C0C0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600070E")]
				[Address(RVA = "0x1EC89A8", Offset = "0x1EC89A8", VA = "0x1EC89A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C0D0", Offset = "0xB8C0D0")]
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
			[Address(RVA = "0x1EBAD54", Offset = "0x1EBAD54", VA = "0x1EBAD54")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x1EC89B0", Offset = "0x1EC89B0", VA = "0x1EC89B0")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x1EC8B1C", Offset = "0x1EC8B1C", VA = "0x1EC8B1C")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x1EC8BC8", Offset = "0x1EC8BC8", VA = "0x1EC8BC8")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x1EC4DFC", Offset = "0x1EC4DFC", VA = "0x1EC4DFC")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x1EC8390", Offset = "0x1EC8390", VA = "0x1EC8390")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x1EC8C1C", Offset = "0x1EC8C1C", VA = "0x1EC8C1C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x1EC8D60", Offset = "0x1EC8D60", VA = "0x1EC8D60")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x1EC88EC", Offset = "0x1EC88EC", VA = "0x1EC88EC")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB86B9C", Offset = "0xB86B9C")]
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
				[Address(RVA = "0x1EC8D88", Offset = "0x1EC8D88", VA = "0x1EC8D88")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B2")]
			public float stepProgress
			{
				[Token(Token = "0x6000719")]
				[Address(RVA = "0x1EC8D9C", Offset = "0x1EC8D9C", VA = "0x1EC8D9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C0E0", Offset = "0xB8C0E0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600071A")]
				[Address(RVA = "0x1EC8DA4", Offset = "0x1EC8DA4", VA = "0x1EC8DA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C0F0", Offset = "0xB8C0F0")]
				private set
				{
				}
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1EC8DAC", Offset = "0x1EC8DAC", VA = "0x1EC8DAC")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x1EC8F3C", Offset = "0x1EC8F3C", VA = "0x1EC8F3C")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x1EC8F84", Offset = "0x1EC8F84", VA = "0x1EC8F84")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0x1EC9084", Offset = "0x1EC9084", VA = "0x1EC9084")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x1EC925C", Offset = "0x1EC925C", VA = "0x1EC925C")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000720")]
			[Address(RVA = "0x1EC9448", Offset = "0x1EC9448", VA = "0x1EC9448")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86BAC", Offset = "0xB86BAC")]
			public Transform target;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86BE4", Offset = "0xB86BE4")]
			public Transform bendGoal;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86C1C", Offset = "0xB86C1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB86C1C", Offset = "0xB86C1C")]
			public float positionWeight;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86C70", Offset = "0xB86C70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB86C70", Offset = "0xB86C70")]
			public float rotationWeight;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86CC4", Offset = "0xB86CC4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB86CC4", Offset = "0xB86CC4")]
			public float bendGoalWeight;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86D18", Offset = "0xB86D18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB86D18", Offset = "0xB86D18")]
			public float swivelOffset;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86D74", Offset = "0xB86D74")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB86D74", Offset = "0xB86D74")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86DC8", Offset = "0xB86DC8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB86DC8", Offset = "0xB86DC8")]
			public float legLengthMlp;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86E20", Offset = "0xB86E20")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB86EB8", Offset = "0xB86EB8")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB86EC8", Offset = "0xB86EC8")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB86ED8", Offset = "0xB86ED8")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB86EE8", Offset = "0xB86EE8")]
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
				[Address(RVA = "0x1EC9664", Offset = "0x1EC9664", VA = "0x1EC9664")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C100", Offset = "0xB8C100")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000722")]
				[Address(RVA = "0x1EC9670", Offset = "0x1EC9670", VA = "0x1EC9670")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C110", Offset = "0xB8C110")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B4")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000723")]
				[Address(RVA = "0x1EC967C", Offset = "0x1EC967C", VA = "0x1EC967C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C120", Offset = "0xB8C120")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000724")]
				[Address(RVA = "0x1EC9688", Offset = "0x1EC9688", VA = "0x1EC9688")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C130", Offset = "0xB8C130")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B5")]
			public bool hasToes
			{
				[Token(Token = "0x6000725")]
				[Address(RVA = "0x1EC9694", Offset = "0x1EC9694", VA = "0x1EC9694")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C140", Offset = "0xB8C140")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000726")]
				[Address(RVA = "0x1EC969C", Offset = "0x1EC969C", VA = "0x1EC969C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C150", Offset = "0xB8C150")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B6")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000727")]
				[Address(RVA = "0x1EC96A8", Offset = "0x1EC96A8", VA = "0x1EC96A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B7")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000728")]
				[Address(RVA = "0x1EC96DC", Offset = "0x1EC96DC", VA = "0x1EC96DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000729")]
				[Address(RVA = "0x1EC9714", Offset = "0x1EC9714", VA = "0x1EC9714")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private VirtualBone toes
			{
				[Token(Token = "0x600072A")]
				[Address(RVA = "0x1EC974C", Offset = "0x1EC974C", VA = "0x1EC974C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600072B")]
				[Address(RVA = "0x1EC4DBC", Offset = "0x1EC4DBC", VA = "0x1EC4DBC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BB")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600072C")]
				[Address(RVA = "0x1EC9784", Offset = "0x1EC9784", VA = "0x1EC9784")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C160", Offset = "0xB8C160")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600072D")]
				[Address(RVA = "0x1EC9790", Offset = "0x1EC9790", VA = "0x1EC9790")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C170", Offset = "0xB8C170")]
				private set
				{
				}
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x1EC979C", Offset = "0x1EC979C", VA = "0x1EC979C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600072F")]
			[Address(RVA = "0x1EC9E24", Offset = "0x1EC9E24", VA = "0x1EC9E24", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000730")]
			[Address(RVA = "0x1ECA634", Offset = "0x1ECA634", VA = "0x1ECA634", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0x1ECA530", Offset = "0x1ECA530", VA = "0x1ECA530")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000732")]
			[Address(RVA = "0x1ECA2F8", Offset = "0x1ECA2F8", VA = "0x1ECA2F8")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x1EBA778", Offset = "0x1EBA778", VA = "0x1EBA778")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x1ECABEC", Offset = "0x1ECABEC", VA = "0x1ECABEC")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x1ECB0EC", Offset = "0x1ECB0EC", VA = "0x1ECB0EC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x1ECB308", Offset = "0x1ECB308", VA = "0x1ECB308", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x1EBAFDC", Offset = "0x1EBAFDC", VA = "0x1EBAFDC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86EF8", Offset = "0xB86EF8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB86EF8", Offset = "0xB86EF8")]
			public float weight;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86F4C", Offset = "0xB86F4C")]
			public float footDistance;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86F84", Offset = "0xB86F84")]
			public float stepThreshold;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86FBC", Offset = "0xB86FBC")]
			public float angleThreshold;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86FF4", Offset = "0xB86FF4")]
			public float comAngleMlp;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8702C", Offset = "0xB8702C")]
			public float maxVelocity;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87064", Offset = "0xB87064")]
			public float velocityFactor;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8709C", Offset = "0xB8709C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8709C", Offset = "0xB8709C")]
			public float maxLegStretch;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB870F4", Offset = "0xB870F4")]
			public float rootSpeed;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8712C", Offset = "0xB8712C")]
			public float stepSpeed;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87164", Offset = "0xB87164")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8719C", Offset = "0xB8719C")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB871D4", Offset = "0xB871D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB871D4", Offset = "0xB871D4")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8722C", Offset = "0xB8722C")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87264", Offset = "0xB87264")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8729C", Offset = "0xB8729C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87314", Offset = "0xB87314")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8734C", Offset = "0xB8734C")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB87384", Offset = "0xB87384")]
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
				[Address(RVA = "0x1C35368", Offset = "0x1C35368", VA = "0x1C35368")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C180", Offset = "0xB8C180")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000739")]
				[Address(RVA = "0x1C35374", Offset = "0x1C35374", VA = "0x1C35374")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C190", Offset = "0xB8C190")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BD")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x600073F")]
				[Address(RVA = "0x1C3786C", Offset = "0x1C3786C", VA = "0x1C3786C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000BE")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000740")]
				[Address(RVA = "0x1C378AC", Offset = "0x1C378AC", VA = "0x1C378AC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000BF")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000741")]
				[Address(RVA = "0x1C378F0", Offset = "0x1C378F0", VA = "0x1C378F0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000C0")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000742")]
				[Address(RVA = "0x1C37930", Offset = "0x1C37930", VA = "0x1C37930")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x1C35380", Offset = "0x1C35380", VA = "0x1C35380")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x1C356A0", Offset = "0x1C356A0", VA = "0x1C356A0")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x600073C")]
			[Address(RVA = "0x1C3591C", Offset = "0x1C3591C", VA = "0x1C3591C")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x1C35CF4", Offset = "0x1C35CF4", VA = "0x1C35CF4")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0x1C35EA4", Offset = "0x1C35EA4", VA = "0x1C35EA4")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x1C37458", Offset = "0x1C37458", VA = "0x1C37458")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x1C375FC", Offset = "0x1C375FC", VA = "0x1C375FC")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x1C376A0", Offset = "0x1C376A0", VA = "0x1C376A0")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0x1C37974", Offset = "0x1C37974", VA = "0x1C37974")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87394", Offset = "0xB87394")]
			public Transform headTarget;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB873CC", Offset = "0xB873CC")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87404", Offset = "0xB87404")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB87404", Offset = "0xB87404")]
			public float positionWeight;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87458", Offset = "0xB87458")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB87458", Offset = "0xB87458")]
			public float rotationWeight;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB874AC", Offset = "0xB874AC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB874AC", Offset = "0xB874AC")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87500", Offset = "0xB87500")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB87500", Offset = "0xB87500")]
			public float pelvisRotationWeight;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87554", Offset = "0xB87554")]
			public Transform chestGoal;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8758C", Offset = "0xB8758C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8758C", Offset = "0xB8758C")]
			public float chestGoalWeight;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB875E0", Offset = "0xB875E0")]
			public float minHeadHeight;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87618", Offset = "0xB87618")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB87618", Offset = "0xB87618")]
			public float bodyPosStiffness;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8766C", Offset = "0xB8766C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8766C", Offset = "0xB8766C")]
			public float bodyRotStiffness;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB876C0", Offset = "0xB876C0")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB876C0", Offset = "0xB876C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB876C0", Offset = "0xB876C0")]
			public float neckStiffness;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87738", Offset = "0xB87738")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB87738", Offset = "0xB87738")]
			public float rotateChestByHands;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8778C", Offset = "0xB8778C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8778C", Offset = "0xB8778C")]
			public float chestClampWeight;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB877E0", Offset = "0xB877E0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB877E0", Offset = "0xB877E0")]
			public float headClampWeight;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87834", Offset = "0xB87834")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8786C", Offset = "0xB8786C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8786C", Offset = "0xB8786C")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB878C0", Offset = "0xB878C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB878C0", Offset = "0xB878C0")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB879F8", Offset = "0xB879F8")]
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
				[Address(RVA = "0x1C373D8", Offset = "0x1C373D8", VA = "0x1C373D8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000748")]
				[Address(RVA = "0x1C37A7C", Offset = "0x1C37A7C", VA = "0x1C37A7C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000749")]
				[Address(RVA = "0x1C37ABC", Offset = "0x1C37ABC", VA = "0x1C37ABC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private VirtualBone neck
			{
				[Token(Token = "0x600074A")]
				[Address(RVA = "0x1C37B10", Offset = "0x1C37B10", VA = "0x1C37B10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			public VirtualBone head
			{
				[Token(Token = "0x600074B")]
				[Address(RVA = "0x1C37418", Offset = "0x1C37418", VA = "0x1C37418")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C6")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x600074C")]
				[Address(RVA = "0x1C37B50", Offset = "0x1C37B50", VA = "0x1C37B50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C1A0", Offset = "0xB8C1A0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600074D")]
				[Address(RVA = "0x1C37B64", Offset = "0x1C37B64", VA = "0x1C37B64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C1B0", Offset = "0xB8C1B0")]
				private set
				{
				}
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x1C37B78", Offset = "0x1C37B78", VA = "0x1C37B78", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0x1C38710", Offset = "0x1C38710", VA = "0x1C38710", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x1C38920", Offset = "0x1C38920", VA = "0x1C38920", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x1C38ED8", Offset = "0x1C38ED8", VA = "0x1C38ED8")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0x1C3948C", Offset = "0x1C3948C", VA = "0x1C3948C")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0x1C39DF4", Offset = "0x1C39DF4", VA = "0x1C39DF4")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0x1C3A610", Offset = "0x1C3A610", VA = "0x1C3A610")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x1C3B38C", Offset = "0x1C3B38C", VA = "0x1C3B38C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0x1C3B568", Offset = "0x1C3B568", VA = "0x1C3B568", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0x1C39108", Offset = "0x1C39108", VA = "0x1C39108")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x1C3A254", Offset = "0x1C3A254", VA = "0x1C3A254")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x1C399E8", Offset = "0x1C399E8", VA = "0x1C399E8")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x1C3B660", Offset = "0x1C3B660", VA = "0x1C3B660")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x1C3A3C4", Offset = "0x1C3A3C4", VA = "0x1C3A3C4")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x1C39FA0", Offset = "0x1C39FA0", VA = "0x1C39FA0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x1C3BB7C", Offset = "0x1C3BB7C", VA = "0x1C3BB7C")]
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
			[Address(RVA = "0x1C38674", Offset = "0x1C38674", VA = "0x1C38674")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0x1C386F0", Offset = "0x1C386F0", VA = "0x1C386F0")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x1C3BD4C", Offset = "0x1C3BD4C", VA = "0x1C3BD4C")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000761")]
			[Address(RVA = "0x1C3BFDC", Offset = "0x1C3BFDC", VA = "0x1C3BFDC")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0x1C3B994", Offset = "0x1C3B994", VA = "0x1C3B994")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0x1C3C2C8", Offset = "0x1C3C2C8", VA = "0x1C3C2C8")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0x1C3C500", Offset = "0x1C3C500", VA = "0x1C3C500")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000765")]
			[Address(RVA = "0x1C3C734", Offset = "0x1C3C734", VA = "0x1C3C734")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0x1C3ADE0", Offset = "0x1C3ADE0", VA = "0x1C3ADE0")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0x1C3C7EC", Offset = "0x1C3C7EC", VA = "0x1C3C7EC")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0x1C3A998", Offset = "0x1C3A998", VA = "0x1C3A998")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0x1C3CA04", Offset = "0x1C3CA04", VA = "0x1C3CA04")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x1C3CB0C", Offset = "0x1C3CB0C", VA = "0x1C3CB0C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8469C", Offset = "0xB8469C")]
		public bool plantFeet;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB846D4", Offset = "0xB846D4")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB846E4", Offset = "0xB846E4")]
		public Spine spine;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8471C", Offset = "0xB8471C")]
		public Arm leftArm;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84754", Offset = "0xB84754")]
		public Arm rightArm;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8478C", Offset = "0xB8478C")]
		public Leg leftLeg;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB847C4", Offset = "0xB847C4")]
		public Leg rightLeg;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB847FC", Offset = "0xB847FC")]
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
			[Address(RVA = "0x1EC6994", Offset = "0x1EC6994", VA = "0x1EC6994")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8AE20", Offset = "0xB8AE20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x1EC699C", Offset = "0x1EC699C", VA = "0x1EC699C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8AE30", Offset = "0xB8AE30")]
			private set
			{
			}
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1EC1238", Offset = "0x1EC1238", VA = "0x1EC1238")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1EC16CC", Offset = "0x1EC16CC", VA = "0x1EC16CC")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1EC1554", Offset = "0x1EC1554", VA = "0x1EC1554")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1EC20B8", Offset = "0x1EC20B8", VA = "0x1EC20B8")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1EC2394", Offset = "0x1EC2394", VA = "0x1EC2394")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1EC2438", Offset = "0x1EC2438", VA = "0x1EC2438")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1EC25CC", Offset = "0x1EC25CC", VA = "0x1EC25CC")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1EC2758", Offset = "0x1EC2758", VA = "0x1EC2758")]
		public void Reset()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1EC2FBC", Offset = "0x1EC2FBC", VA = "0x1EC2FBC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1EC3130", Offset = "0x1EC3130", VA = "0x1EC3130", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1EC32D4", Offset = "0x1EC32D4", VA = "0x1EC32D4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1EC3348", Offset = "0x1EC3348", VA = "0x1EC3348", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1EC33BC", Offset = "0x1EC33BC", VA = "0x1EC33BC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1EC35DC", Offset = "0x1EC35DC", VA = "0x1EC35DC")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1EC196C", Offset = "0x1EC196C", VA = "0x1EC196C")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1EC1B44", Offset = "0x1EC1B44", VA = "0x1EC1B44")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1EC1F94", Offset = "0x1EC1F94", VA = "0x1EC1F94")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1EC28D0", Offset = "0x1EC28D0", VA = "0x1EC28D0")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1EC38BC", Offset = "0x1EC38BC", VA = "0x1EC38BC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1EC3904", Offset = "0x1EC3904", VA = "0x1EC3904", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1EC4AD4", Offset = "0x1EC4AD4", VA = "0x1EC4AD4")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1EC2A38", Offset = "0x1EC2A38", VA = "0x1EC2A38")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1EC3970", Offset = "0x1EC3970", VA = "0x1EC3970")]
		private void Solve()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1EC4D30", Offset = "0x1EC4D30", VA = "0x1EC4D30")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1EC4D78", Offset = "0x1EC4D78", VA = "0x1EC4D78")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1EC4984", Offset = "0x1EC4984", VA = "0x1EC4984")]
		private void Write()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1EC6394", Offset = "0x1EC6394", VA = "0x1EC6394")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1EC69A4", Offset = "0x1EC69A4", VA = "0x1EC69A4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84834", Offset = "0xB84834")]
		public Transform parent;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8486C", Offset = "0xB8486C")]
		public Transform child;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB848A4", Offset = "0xB848A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB848A4", Offset = "0xB848A4")]
		public float weight;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB848F8", Offset = "0xB848F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB848F8", Offset = "0xB848F8")]
		public float parentChildCrossfade;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8494C", Offset = "0xB8494C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8494C", Offset = "0xB8494C")]
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
		[Address(RVA = "0x1D6CF2C", Offset = "0x1D6CF2C", VA = "0x1D6CF2C")]
		public void Relax()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1D6D30C", Offset = "0x1D6D30C", VA = "0x1D6D30C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1D6D7B8", Offset = "0x1D6D7B8", VA = "0x1D6D7B8")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1D6D840", Offset = "0x1D6D840", VA = "0x1D6D840")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1D6D8C8", Offset = "0x1D6D8C8", VA = "0x1D6D8C8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1D6D9F0", Offset = "0x1D6D9F0", VA = "0x1D6D9F0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB849A8", Offset = "0xB849A8")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB849B8", Offset = "0xB849B8")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB849C8", Offset = "0xB849C8")]
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
			[Address(RVA = "0x1C3D430", Offset = "0x1C3D430", VA = "0x1C3D430")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8AE40", Offset = "0xB8AE40")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x1C3D438", Offset = "0x1C3D438", VA = "0x1C3D438")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8AE50", Offset = "0xB8AE50")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public bool isPaused
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x1C3D440", Offset = "0x1C3D440", VA = "0x1C3D440")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8AE60", Offset = "0xB8AE60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x1C3D448", Offset = "0x1C3D448", VA = "0x1C3D448")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8AE70", Offset = "0xB8AE70")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x1C3D454", Offset = "0x1C3D454", VA = "0x1C3D454")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8AE80", Offset = "0xB8AE80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x1C3D45C", Offset = "0x1C3D45C", VA = "0x1C3D45C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8AE90", Offset = "0xB8AE90")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public bool inInteraction
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x1C3D464", Offset = "0x1C3D464", VA = "0x1C3D464")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		public float progress
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x1C3FE1C", Offset = "0x1C3FE1C", VA = "0x1C3FE1C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1C3D4D4", Offset = "0x1C3D4D4", VA = "0x1C3D4D4")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1C3D564", Offset = "0x1C3D564", VA = "0x1C3D564")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1C3D634", Offset = "0x1C3D634", VA = "0x1C3D634")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1C3D774", Offset = "0x1C3D774", VA = "0x1C3D774")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1C3DB78", Offset = "0x1C3DB78", VA = "0x1C3DB78")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1C3DF38", Offset = "0x1C3DF38", VA = "0x1C3DF38")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1C3DF8C", Offset = "0x1C3DF8C", VA = "0x1C3DF8C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1C3EB28", Offset = "0x1C3EB28", VA = "0x1C3EB28")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1C3F650", Offset = "0x1C3F650", VA = "0x1C3F650")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1C3F878", Offset = "0x1C3F878", VA = "0x1C3F878")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1C3FCAC", Offset = "0x1C3FCAC", VA = "0x1C3FCAC")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1C40304", Offset = "0x1C40304", VA = "0x1C40304")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB849D8", Offset = "0xB849D8")]
		public LookAtIK ik;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84A10", Offset = "0xB84A10")]
		public float lerpSpeed;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84A48", Offset = "0xB84A48")]
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
		[Address(RVA = "0x1C40568", Offset = "0x1C40568", VA = "0x1C40568")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1C406EC", Offset = "0x1C406EC", VA = "0x1C406EC")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1C40794", Offset = "0x1C40794", VA = "0x1C40794")]
		public void Update()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1C409E8", Offset = "0x1C409E8", VA = "0x1C409E8")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1C40AE0", Offset = "0x1C40AE0", VA = "0x1C40AE0")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1C40BAC", Offset = "0x1C40BAC", VA = "0x1C40BAC")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB811A0", Offset = "0xB811A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB811A0", Offset = "0xB811A0")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000119")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87A08", Offset = "0xB87A08")]
			public float time;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87A40", Offset = "0xB87A40")]
			public bool pause;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87A78", Offset = "0xB87A78")]
			public bool pickUp;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87AB0", Offset = "0xB87AB0")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87AE8", Offset = "0xB87AE8")]
			public Message[] messages;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87B20", Offset = "0xB87B20")]
			public UnityEvent unityEvent;

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x1C3FE58", Offset = "0x1C3FE58", VA = "0x1C3FE58")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0x1C41E60", Offset = "0x1C41E60", VA = "0x1C41E60")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87B58", Offset = "0xB87B58")]
			public string function;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87B90", Offset = "0xB87B90")]
			public GameObject recipient;

			[Token(Token = "0x4000798")]
			private const string empty = "";

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x1C41D70", Offset = "0x1C41D70", VA = "0x1C41D70")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0x1C41E68", Offset = "0x1C41E68", VA = "0x1C41E68")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87BC8", Offset = "0xB87BC8")]
			public Animator animator;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87C00", Offset = "0xB87C00")]
			public Animation animation;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87C38", Offset = "0xB87C38")]
			public string animationState;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87C70", Offset = "0xB87C70")]
			public float crossfadeTime;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87CA8", Offset = "0xB87CA8")]
			public int layer;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87CE0", Offset = "0xB87CE0")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400079F")]
			private const string empty = "";

			[Token(Token = "0x600076F")]
			[Address(RVA = "0x1C41AD0", Offset = "0x1C41AD0", VA = "0x1C41AD0")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x1C41BC4", Offset = "0x1C41BC4", VA = "0x1C41BC4")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x1C41C7C", Offset = "0x1C41C7C", VA = "0x1C41C7C")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x1C41D5C", Offset = "0x1C41D5C", VA = "0x1C41D5C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87D18", Offset = "0xB87D18")]
			public Type type;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87D50", Offset = "0xB87D50")]
			public AnimationCurve curve;

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x1C412C0", Offset = "0x1C412C0", VA = "0x1C412C0")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x1C41E80", Offset = "0x1C41E80", VA = "0x1C41E80")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87D88", Offset = "0xB87D88")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87DC0", Offset = "0xB87DC0")]
			public float multiplier;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87DF8", Offset = "0xB87DF8")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x1C41924", Offset = "0x1C41924", VA = "0x1C41924")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x1C41E70", Offset = "0x1C41E70", VA = "0x1C41E70")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84A90", Offset = "0xB84A90")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84AC8", Offset = "0xB84AC8")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84B00", Offset = "0xB84B00")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB84B38", Offset = "0xB84B38")]
		private float <length>k__BackingField;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB84B48", Offset = "0xB84B48")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700005F")]
		public float length
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x1C40D88", Offset = "0x1C40D88", VA = "0x1C40D88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8AFF0", Offset = "0xB8AFF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x1C40D90", Offset = "0x1C40D90", VA = "0x1C40D90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8B000", Offset = "0xB8B000")]
			private set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x1C40D98", Offset = "0x1C40D98", VA = "0x1C40D98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8B010", Offset = "0xB8B010")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x1C40DA0", Offset = "0x1C40DA0", VA = "0x1C40DA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8B020", Offset = "0xB8B020")]
			private set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x1C40FC4", Offset = "0x1C40FC4", VA = "0x1C40FC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x1C401D8", Offset = "0x1C401D8", VA = "0x1C401D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1C40BC0", Offset = "0x1C40BC0", VA = "0x1C40BC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AEA0", Offset = "0xB8AEA0")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1C40C0C", Offset = "0x1C40C0C", VA = "0x1C40C0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AED8", Offset = "0xB8AED8")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1C40C58", Offset = "0x1C40C58", VA = "0x1C40C58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AF10", Offset = "0xB8AF10")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1C40CA4", Offset = "0x1C40CA4", VA = "0x1C40CA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AF48", Offset = "0xB8AF48")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1C40CF0", Offset = "0x1C40CF0", VA = "0x1C40CF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AF80", Offset = "0xB8AF80")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1C40D3C", Offset = "0x1C40D3C", VA = "0x1C40D3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8AFB8", Offset = "0xB8AFB8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1C40DA8", Offset = "0x1C40DA8", VA = "0x1C40DA8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1C41054", Offset = "0x1C41054", VA = "0x1C41054")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1C3E548", Offset = "0x1C3E548", VA = "0x1C3E548")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1C411D8", Offset = "0x1C411D8", VA = "0x1C411D8")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1C3E3FC", Offset = "0x1C3E3FC", VA = "0x1C3E3FC")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1C3E540", Offset = "0x1C3E540", VA = "0x1C3E540")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1C3F234", Offset = "0x1C3F234", VA = "0x1C3F234")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1C3FA84", Offset = "0x1C3FA84", VA = "0x1C3FA84")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1C41960", Offset = "0x1C41960", VA = "0x1C41960")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1C412DC", Offset = "0x1C412DC", VA = "0x1C412DC")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1C411E0", Offset = "0x1C411E0", VA = "0x1C411E0")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1C418BC", Offset = "0x1C418BC", VA = "0x1C418BC")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1C41964", Offset = "0x1C41964", VA = "0x1C41964")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1C419CC", Offset = "0x1C419CC", VA = "0x1C419CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B030", Offset = "0xB8B030")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1C41A18", Offset = "0x1C41A18", VA = "0x1C41A18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B068", Offset = "0xB8B068")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1C41A64", Offset = "0x1C41A64", VA = "0x1C41A64")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB81200", Offset = "0xB81200")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB81200", Offset = "0xB81200")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200011E")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200011F")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84B58", Offset = "0xB84B58")]
		public string targetTag;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84B90", Offset = "0xB84B90")]
		public float fadeInTime;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84BC8", Offset = "0xB84BC8")]
		public float speed;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84C00", Offset = "0xB84C00")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB84C38", Offset = "0xB84C38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84C38", Offset = "0xB84C38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB84C38", Offset = "0xB84C38")]
		public Collider characterCollider;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84CBC", Offset = "0xB84CBC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB84CBC", Offset = "0xB84CBC")]
		public Transform FPSCamera;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84D1C", Offset = "0xB84D1C")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84D54", Offset = "0xB84D54")]
		public float camRaycastDistance;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB84D8C", Offset = "0xB84D8C")]
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
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xB84D9C", Offset = "0xB84D9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84D9C", Offset = "0xB84D9C")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84DFC", Offset = "0xB84DFC")]
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
			[Address(RVA = "0x1C42050", Offset = "0x1C42050", VA = "0x1C42050")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x1C43CA8", Offset = "0x1C43CA8", VA = "0x1C43CA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x1C43CB0", Offset = "0x1C43CB0", VA = "0x1C43CB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x1C43CB8", Offset = "0x1C43CB8", VA = "0x1C43CB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8B1F0", Offset = "0xB8B1F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x1C43CC0", Offset = "0x1C43CC0", VA = "0x1C43CC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8B200", Offset = "0xB8B200")]
			private set
			{
			}
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1C41E88", Offset = "0x1C41E88", VA = "0x1C41E88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B0A0", Offset = "0xB8B0A0")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1C41ED4", Offset = "0x1C41ED4", VA = "0x1C41ED4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B0D8", Offset = "0xB8B0D8")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1C41F20", Offset = "0x1C41F20", VA = "0x1C41F20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B110", Offset = "0xB8B110")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1C41F6C", Offset = "0x1C41F6C", VA = "0x1C41F6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B148", Offset = "0xB8B148")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1C41FB8", Offset = "0x1C41FB8", VA = "0x1C41FB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B180", Offset = "0xB8B180")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1C42004", Offset = "0x1C42004", VA = "0x1C42004")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B1B8", Offset = "0xB8B1B8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1C421E0", Offset = "0x1C421E0", VA = "0x1C421E0")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1C422AC", Offset = "0x1C422AC", VA = "0x1C422AC")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1C42378", Offset = "0x1C42378", VA = "0x1C42378")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1C42424", Offset = "0x1C42424", VA = "0x1C42424")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1C4251C", Offset = "0x1C4251C", VA = "0x1C4251C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1C42638", Offset = "0x1C42638", VA = "0x1C42638")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1C426C8", Offset = "0x1C426C8", VA = "0x1C426C8")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1C42758", Offset = "0x1C42758", VA = "0x1C42758")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1C427E8", Offset = "0x1C427E8", VA = "0x1C427E8")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1C4285C", Offset = "0x1C4285C", VA = "0x1C4285C")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1C428D0", Offset = "0x1C428D0", VA = "0x1C428D0")]
		public void StopAll()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1C42938", Offset = "0x1C42938", VA = "0x1C42938")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1C429C4", Offset = "0x1C429C4", VA = "0x1C429C4")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1C42A78", Offset = "0x1C42A78", VA = "0x1C42A78")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1C42B5C", Offset = "0x1C42B5C", VA = "0x1C42B5C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1C42E00", Offset = "0x1C42E00", VA = "0x1C42E00")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1C42FF0", Offset = "0x1C42FF0", VA = "0x1C42FF0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1C43274", Offset = "0x1C43274", VA = "0x1C43274")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1C43568", Offset = "0x1C43568", VA = "0x1C43568")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1C435AC", Offset = "0x1C435AC", VA = "0x1C435AC")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1C43624", Offset = "0x1C43624", VA = "0x1C43624")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1C4375C", Offset = "0x1C4375C", VA = "0x1C4375C")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1C438D4", Offset = "0x1C438D4", VA = "0x1C438D4")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1C43B7C", Offset = "0x1C43B7C", VA = "0x1C43B7C")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1C43374", Offset = "0x1C43374", VA = "0x1C43374")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1C43CC8", Offset = "0x1C43CC8", VA = "0x1C43CC8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1C4447C", Offset = "0x1C4447C", VA = "0x1C4447C")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1C4449C", Offset = "0x1C4449C", VA = "0x1C4449C")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1C444B8", Offset = "0x1C444B8", VA = "0x1C444B8")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1C444D4", Offset = "0x1C444D4", VA = "0x1C444D4")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1C44534", Offset = "0x1C44534", VA = "0x1C44534")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1C44650", Offset = "0x1C44650", VA = "0x1C44650")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1C4474C", Offset = "0x1C4474C", VA = "0x1C4474C")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1C44AAC", Offset = "0x1C44AAC", VA = "0x1C44AAC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1C44BC4", Offset = "0x1C44BC4", VA = "0x1C44BC4")]
		private void Update()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1C44E10", Offset = "0x1C44E10", VA = "0x1C44E10")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1C441DC", Offset = "0x1C441DC", VA = "0x1C441DC")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1C44F50", Offset = "0x1C44F50", VA = "0x1C44F50")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1C4507C", Offset = "0x1C4507C", VA = "0x1C4507C")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1C45124", Offset = "0x1C45124", VA = "0x1C45124")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1C4520C", Offset = "0x1C4520C", VA = "0x1C4520C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1C45224", Offset = "0x1C45224", VA = "0x1C45224")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1C420FC", Offset = "0x1C420FC", VA = "0x1C420FC")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1C42CFC", Offset = "0x1C42CFC", VA = "0x1C42CFC")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1C455E8", Offset = "0x1C455E8", VA = "0x1C455E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B210", Offset = "0xB8B210")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1C45634", Offset = "0x1C45634", VA = "0x1C45634")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B248", Offset = "0xB8B248")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1C45680", Offset = "0x1C45680", VA = "0x1C45680")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB81260", Offset = "0xB81260")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB81260", Offset = "0xB81260")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000120")]
		public class Multiplier
		{
			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87E30", Offset = "0xB87E30")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87E68", Offset = "0xB87E68")]
			public float multiplier;

			[Token(Token = "0x600077F")]
			[Address(RVA = "0x1C45ECC", Offset = "0x1C45ECC", VA = "0x1C45ECC")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84E34", Offset = "0xB84E34")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84E6C", Offset = "0xB84E6C")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84EA4", Offset = "0xB84EA4")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84EDC", Offset = "0xB84EDC")]
		public Transform pivot;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84F14", Offset = "0xB84F14")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84F4C", Offset = "0xB84F4C")]
		public float twistWeight;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84F84", Offset = "0xB84F84")]
		public float swingWeight;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84FBC", Offset = "0xB84FBC")]
		public bool rotateOnce;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1C45BE0", Offset = "0x1C45BE0", VA = "0x1C45BE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B280", Offset = "0xB8B280")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1C45C2C", Offset = "0x1C45C2C", VA = "0x1C45C2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B2B8", Offset = "0xB8B2B8")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1C45C78", Offset = "0x1C45C78", VA = "0x1C45C78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B2F0", Offset = "0xB8B2F0")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1C45CC4", Offset = "0x1C45CC4", VA = "0x1C45CC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B328", Offset = "0xB8B328")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1C45D10", Offset = "0x1C45D10", VA = "0x1C45D10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B360", Offset = "0xB8B360")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1C45D5C", Offset = "0x1C45D5C", VA = "0x1C45D5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B398", Offset = "0xB8B398")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1C41250", Offset = "0x1C41250", VA = "0x1C41250")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1C40268", Offset = "0x1C40268", VA = "0x1C40268")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1C3E5FC", Offset = "0x1C3E5FC", VA = "0x1C3E5FC")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1C45DA8", Offset = "0x1C45DA8", VA = "0x1C45DA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B3D0", Offset = "0xB8B3D0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1C45DF4", Offset = "0x1C45DF4", VA = "0x1C45DF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B408", Offset = "0xB8B408")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1C45E40", Offset = "0x1C45E40", VA = "0x1C45E40")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB812C0", Offset = "0xB812C0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB812C0", Offset = "0xB812C0")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000121")]
		public class CharacterPosition
		{
			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87EA0", Offset = "0xB87EA0")]
			public bool use;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87ED8", Offset = "0xB87ED8")]
			public Vector2 offset;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87F10", Offset = "0xB87F10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB87F10", Offset = "0xB87F10")]
			public float angleOffset;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87F6C", Offset = "0xB87F6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB87F6C", Offset = "0xB87F6C")]
			public float maxAngle;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87FC4", Offset = "0xB87FC4")]
			public float radius;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB87FFC", Offset = "0xB87FFC")]
			public bool orbit;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88034", Offset = "0xB88034")]
			public bool fixYAxis;

			[Token(Token = "0x170000C7")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000780")]
				[Address(RVA = "0x1C46660", Offset = "0x1C46660", VA = "0x1C46660")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C8")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000781")]
				[Address(RVA = "0x1C4669C", Offset = "0x1C4669C", VA = "0x1C4669C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000782")]
			[Address(RVA = "0x1C46794", Offset = "0x1C46794", VA = "0x1C46794")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000783")]
			[Address(RVA = "0x1C46E10", Offset = "0x1C46E10", VA = "0x1C46E10")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8806C", Offset = "0xB8806C")]
			public Collider lookAtTarget;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB880A4", Offset = "0xB880A4")]
			public Vector3 direction;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB880DC", Offset = "0xB880DC")]
			public float maxDistance;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88114", Offset = "0xB88114")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB88114", Offset = "0xB88114")]
			public float maxAngle;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8816C", Offset = "0xB8816C")]
			public bool fixYAxis;

			[Token(Token = "0x6000784")]
			[Address(RVA = "0x1C4614C", Offset = "0x1C4614C", VA = "0x1C4614C")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0x1C462F4", Offset = "0x1C462F4", VA = "0x1C462F4")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0x1C465D4", Offset = "0x1C465D4", VA = "0x1C465D4")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB89224", Offset = "0xB89224")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000864")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8925C", Offset = "0xB8925C")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60007F8")]
				[Address(RVA = "0x1C46E34", Offset = "0x1C46E34", VA = "0x1C46E34")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88214", Offset = "0xB88214")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8824C", Offset = "0xB8824C")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88284", Offset = "0xB88284")]
			public Interaction[] interactions;

			[Token(Token = "0x6000787")]
			[Address(RVA = "0x1C45FBC", Offset = "0x1C45FBC", VA = "0x1C45FBC")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000788")]
			[Address(RVA = "0x1C46E24", Offset = "0x1C46E24", VA = "0x1C46E24")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB84FF4", Offset = "0xB84FF4")]
		public Range[] ranges;

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1C45ED4", Offset = "0x1C45ED4", VA = "0x1C45ED4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B440", Offset = "0xB8B440")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1C45F20", Offset = "0x1C45F20", VA = "0x1C45F20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B478", Offset = "0xB8B478")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1C45F6C", Offset = "0x1C45F6C", VA = "0x1C45F6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B4B0", Offset = "0xB8B4B0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1C45FB8", Offset = "0x1C45FB8", VA = "0x1C45FB8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1C448F0", Offset = "0x1C448F0", VA = "0x1C448F0")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1C460E0", Offset = "0x1C460E0", VA = "0x1C460E0")]
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
			[Address(RVA = "0x18274C8", Offset = "0x18274C8", VA = "0x18274C8")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x600078A")]
			[Address(RVA = "0x18278E8", Offset = "0x18278E8", VA = "0x18278E8")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600078B")]
			[Address(RVA = "0x182789C", Offset = "0x182789C", VA = "0x182789C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600078C")]
			[Address(RVA = "0x1827694", Offset = "0x1827694", VA = "0x1827694")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x18271D4", Offset = "0x18271D4", VA = "0x18271D4", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B4E8", Offset = "0xB8B4E8")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1827588", Offset = "0x1827588", VA = "0x1827588", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x182758C", Offset = "0x182758C", VA = "0x182758C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1827834", Offset = "0x1827834", VA = "0x1827834", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1827520", Offset = "0x1827520", VA = "0x1827520")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1827428", Offset = "0x1827428", VA = "0x1827428")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1827938", Offset = "0x1827938", VA = "0x1827938")]
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
		[Address(RVA = "0x1F377A4", Offset = "0x1F377A4", VA = "0x1F377A4", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1F3786C", Offset = "0x1F3786C", VA = "0x1F3786C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1F37A50", Offset = "0x1F37A50", VA = "0x1F37A50", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1F37B4C", Offset = "0x1F37B4C", VA = "0x1F37B4C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1F378D4", Offset = "0x1F378D4", VA = "0x1F378D4")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1F37EFC", Offset = "0x1F37EFC", VA = "0x1F37EFC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8502C", Offset = "0xB8502C")]
		public float weight;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB85044", Offset = "0xB85044")]
		public float localRotationWeight;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8505C", Offset = "0xB8505C")]
		public float localPositionWeight;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000555")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1C49AE4", Offset = "0x1C49AE4", VA = "0x1C49AE4")]
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
		[Address(RVA = "0x1C49AF0", Offset = "0x1C49AF0", VA = "0x1C49AF0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1C49B44", Offset = "0x1C49B44", VA = "0x1C49B44", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1C49B80", Offset = "0x1C49B80", VA = "0x1C49B80", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1C49B98", Offset = "0x1C49B98", VA = "0x1C49B98")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB81320", Offset = "0xB81320")]
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
			[Address(RVA = "0x1C4A1C8", Offset = "0x1C4A1C8", VA = "0x1C4A1C8")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x1C4AE40", Offset = "0x1C4AE40", VA = "0x1C4AE40")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x1C4AC24", Offset = "0x1C4AC24", VA = "0x1C4AC24")]
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
			[Address(RVA = "0x1C4A378", Offset = "0x1C4A378", VA = "0x1C4A378")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x1C4AFDC", Offset = "0x1C4AFDC", VA = "0x1C4AFDC")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x1C4AF8C", Offset = "0x1C4AF8C", VA = "0x1C4AF8C")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB81604", Offset = "0xB81604")]
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
				[Address(RVA = "0x1C4B63C", Offset = "0x1C4B63C", VA = "0x1C4B63C", Slot = "4")]
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
				[Address(RVA = "0x1C4B6A4", Offset = "0x1C4B6A4", VA = "0x1C4B6A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0x1C4A3F0", Offset = "0x1C4A3F0", VA = "0x1C4A3F0")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x1C4B3D4", Offset = "0x1C4B3D4", VA = "0x1C4B3D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0x1C4B3D8", Offset = "0x1C4B3D8", VA = "0x1C4B3D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x1C4B644", Offset = "0x1C4B644", VA = "0x1C4B644", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85074", Offset = "0xB85074")]
		public IK ik;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB850AC", Offset = "0xB850AC")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB850E4", Offset = "0xB850E4")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8511C", Offset = "0xB8511C")]
		public float applyVelocity;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85154", Offset = "0xB85154")]
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
			[Address(RVA = "0x1C49BE0", Offset = "0x1C49BE0", VA = "0x1C49BE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		private bool ikUsed
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x1C4A7DC", Offset = "0x1C4A7DC", VA = "0x1C4A7DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1C49BA8", Offset = "0x1C49BA8", VA = "0x1C49BA8")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1C49C58", Offset = "0x1C49C58", VA = "0x1C49C58")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1C49D94", Offset = "0x1C49D94", VA = "0x1C49D94")]
		public void Start()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1C49D18", Offset = "0x1C49D18", VA = "0x1C49D18")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB8B520", Offset = "0xB8B520")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1C4A41C", Offset = "0x1C4A41C", VA = "0x1C4A41C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1C4A668", Offset = "0x1C4A668", VA = "0x1C4A668")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1C4A720", Offset = "0x1C4A720", VA = "0x1C4A720")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1C4A960", Offset = "0x1C4A960", VA = "0x1C4A960")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1C4A7A0", Offset = "0x1C4A7A0", VA = "0x1C4A7A0")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1C4A91C", Offset = "0x1C4A91C", VA = "0x1C4A91C")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1C4A9FC", Offset = "0x1C4A9FC", VA = "0x1C4A9FC")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1C4A994", Offset = "0x1C4A994", VA = "0x1C4A994")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1C49CB0", Offset = "0x1C49CB0", VA = "0x1C49CB0")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1C4A6A8", Offset = "0x1C4A6A8", VA = "0x1C4A6A8")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1C4B1A4", Offset = "0x1C4B1A4", VA = "0x1C4B1A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1C4B2CC", Offset = "0x1C4B2CC", VA = "0x1C4B2CC")]
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
			[Address(RVA = "0x1D69018", Offset = "0x1D69018", VA = "0x1D69018")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000069")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x1D69054", Offset = "0x1D69054", VA = "0x1D69054")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1D68CA0", Offset = "0x1D68CA0", VA = "0x1D68CA0")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1D68CE4", Offset = "0x1D68CE4", VA = "0x1D68CE4")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1D68F70", Offset = "0x1D68F70", VA = "0x1D68F70")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1D68FE0", Offset = "0x1D68FE0", VA = "0x1D68FE0")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000576")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1D68E80", Offset = "0x1D68E80", VA = "0x1D68E80")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1D69124", Offset = "0x1D69124", VA = "0x1D69124")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1D69128", Offset = "0x1D69128", VA = "0x1D69128")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1D69210", Offset = "0x1D69210", VA = "0x1D69210")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1D692F4", Offset = "0x1D692F4", VA = "0x1D692F4")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1D69570", Offset = "0x1D69570", VA = "0x1D69570")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1D6962C", Offset = "0x1D6962C", VA = "0x1D6962C")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB81384", Offset = "0xB81384")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB81384", Offset = "0xB81384")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8519C", Offset = "0xB8519C")]
		public float limit;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB851B8", Offset = "0xB851B8")]
		public float twistLimit;

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1D696A4", Offset = "0x1D696A4", VA = "0x1D696A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B584", Offset = "0xB8B584")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1D696F0", Offset = "0x1D696F0", VA = "0x1D696F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B5BC", Offset = "0xB8B5BC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1D6973C", Offset = "0x1D6973C", VA = "0x1D6973C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B5F4", Offset = "0xB8B5F4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1D69788", Offset = "0x1D69788", VA = "0x1D69788")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B62C", Offset = "0xB8B62C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1D697D4", Offset = "0x1D697D4", VA = "0x1D697D4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1D6988C", Offset = "0x1D6988C", VA = "0x1D6988C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1D69AD4", Offset = "0x1D69AD4", VA = "0x1D69AD4")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB813E4", Offset = "0xB813E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB813E4", Offset = "0xB813E4")]
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
		[Address(RVA = "0x1D69AE4", Offset = "0x1D69AE4", VA = "0x1D69AE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B664", Offset = "0xB8B664")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1D69B30", Offset = "0x1D69B30", VA = "0x1D69B30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B69C", Offset = "0xB8B69C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1D69B7C", Offset = "0x1D69B7C", VA = "0x1D69B7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B6D4", Offset = "0xB8B6D4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1D69BC8", Offset = "0x1D69BC8", VA = "0x1D69BC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B70C", Offset = "0xB8B70C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1D69C14", Offset = "0x1D69C14", VA = "0x1D69C14", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1D69C3C", Offset = "0x1D69C3C", VA = "0x1D69C3C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1D69F3C", Offset = "0x1D69F3C", VA = "0x1D69F3C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB81444", Offset = "0xB81444")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB81444", Offset = "0xB81444")]
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
				[Address(RVA = "0x1D6BFC8", Offset = "0x1D6BFC8", VA = "0x1D6BFC8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CC")]
			public Vector3 a
			{
				[Token(Token = "0x600079A")]
				[Address(RVA = "0x1D6C000", Offset = "0x1D6C000", VA = "0x1D6C000")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CD")]
			public Vector3 b
			{
				[Token(Token = "0x600079B")]
				[Address(RVA = "0x1D6C03C", Offset = "0x1D6C03C", VA = "0x1D6C03C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CE")]
			public Vector3 c
			{
				[Token(Token = "0x600079C")]
				[Address(RVA = "0x1D6C078", Offset = "0x1D6C078", VA = "0x1D6C078")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CF")]
			public bool isValid
			{
				[Token(Token = "0x600079E")]
				[Address(RVA = "0x1D6B10C", Offset = "0x1D6B10C", VA = "0x1D6B10C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x1D6B758", Offset = "0x1D6B758", VA = "0x1D6B758")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x1D6B8CC", Offset = "0x1D6B8CC", VA = "0x1D6B8CC")]
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
			[Address(RVA = "0x1D6B11C", Offset = "0x1D6B11C", VA = "0x1D6B11C")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB851E4", Offset = "0xB851E4")]
		public float twistLimit;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB85200", Offset = "0xB85200")]
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
		[Address(RVA = "0x1D69FC4", Offset = "0x1D69FC4", VA = "0x1D69FC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B744", Offset = "0xB8B744")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1D6A010", Offset = "0x1D6A010", VA = "0x1D6A010")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B77C", Offset = "0xB8B77C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1D6A05C", Offset = "0x1D6A05C", VA = "0x1D6A05C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B7B4", Offset = "0xB8B7B4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1D6A0A8", Offset = "0x1D6A0A8", VA = "0x1D6A0A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B7EC", Offset = "0xB8B7EC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1D6A0F4", Offset = "0x1D6A0F4", VA = "0x1D6A0F4")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1D6A634", Offset = "0x1D6A634", VA = "0x1D6A634", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1D6A72C", Offset = "0x1D6A72C", VA = "0x1D6A72C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1D6AD2C", Offset = "0x1D6AD2C", VA = "0x1D6AD2C")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1D6A19C", Offset = "0x1D6A19C", VA = "0x1D6A19C")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1D6B1A0", Offset = "0x1D6B1A0", VA = "0x1D6B1A0")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1D6BA8C", Offset = "0x1D6BA8C", VA = "0x1D6BA8C")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1D6BAD0", Offset = "0x1D6BAD0", VA = "0x1D6BAD0")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1D6BC18", Offset = "0x1D6BC18", VA = "0x1D6BC18")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1D6A9F4", Offset = "0x1D6A9F4", VA = "0x1D6A9F4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1D6BDA8", Offset = "0x1D6BDA8", VA = "0x1D6BDA8")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1D6BF58", Offset = "0x1D6BF58", VA = "0x1D6BF58")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB814A4", Offset = "0xB814A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB814A4", Offset = "0xB814A4")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB852C0", Offset = "0xB852C0")]
		public float twistLimit;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1D6C0B4", Offset = "0x1D6C0B4", VA = "0x1D6C0B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B824", Offset = "0xB8B824")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1D6C100", Offset = "0x1D6C100", VA = "0x1D6C100")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B85C", Offset = "0xB8B85C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1D6C14C", Offset = "0x1D6C14C", VA = "0x1D6C14C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B894", Offset = "0xB8B894")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1D6C198", Offset = "0x1D6C198", VA = "0x1D6C198")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB8B8CC", Offset = "0xB8B8CC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1D6C1E4", Offset = "0x1D6C1E4", VA = "0x1D6C1E4")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1D6C200", Offset = "0x1D6C200", VA = "0x1D6C200", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1D6C2B8", Offset = "0x1D6C2B8", VA = "0x1D6C2B8")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1D6C5E4", Offset = "0x1D6C5E4", VA = "0x1D6C5E4")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x200012A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB81614", Offset = "0xB81614")]
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
				[Address(RVA = "0x181B080", Offset = "0x181B080", VA = "0x181B080", Slot = "4")]
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
				[Address(RVA = "0x181B0E8", Offset = "0x181B0E8", VA = "0x181B0E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x181AE50", Offset = "0x181AE50", VA = "0x181AE50")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x181AF50", Offset = "0x181AF50", VA = "0x181AF50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x181AF54", Offset = "0x181AF54", VA = "0x181AF54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x181B088", Offset = "0x181B088", VA = "0x181B088", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85314", Offset = "0xB85314")]
		public AimIK ik;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8534C", Offset = "0xB8534C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8534C", Offset = "0xB8534C")]
		public float weight;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB853A0", Offset = "0xB853A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB853A0", Offset = "0xB853A0")]
		public Transform target;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85400", Offset = "0xB85400")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85438", Offset = "0xB85438")]
		public float weightSmoothTime;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB85470", Offset = "0xB85470")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85470", Offset = "0xB85470")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB854D0", Offset = "0xB854D0")]
		public float maxRadiansDelta;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85508", Offset = "0xB85508")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85540", Offset = "0xB85540")]
		public float slerpSpeed;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85578", Offset = "0xB85578")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB855B0", Offset = "0xB855B0")]
		public float minDistance;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB855E8", Offset = "0xB855E8")]
		public Vector3 offset;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB85620", Offset = "0xB85620")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85620", Offset = "0xB85620")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB85620", Offset = "0xB85620")]
		public float maxRootAngle;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8569C", Offset = "0xB8569C")]
		public bool turnToTarget;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB856D4", Offset = "0xB856D4")]
		public float turnToTargetTime;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB8570C", Offset = "0xB8570C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8570C", Offset = "0xB8570C")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8576C", Offset = "0xB8576C")]
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
			[Address(RVA = "0x181A054", Offset = "0x181A054", VA = "0x181A054")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1819F54", Offset = "0x1819F54", VA = "0x1819F54")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x181A1A0", Offset = "0x181A1A0", VA = "0x181A1A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x181A8C8", Offset = "0x181A8C8", VA = "0x181A8C8")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x181AA64", Offset = "0x181AA64", VA = "0x181AA64")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x181ADD4", Offset = "0x181ADD4", VA = "0x181ADD4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB8B904", Offset = "0xB8B904")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x181AE7C", Offset = "0x181AE7C", VA = "0x181AE7C")]
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
			[Address(RVA = "0x181B2E8", Offset = "0x181B2E8", VA = "0x181B2E8")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x181B5F4", Offset = "0x181B5F4", VA = "0x181B5F4")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x181B5FC", Offset = "0x181B5FC", VA = "0x181B5FC")]
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
		[Address(RVA = "0x1815918", Offset = "0x1815918", VA = "0x1815918")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x18159F4", Offset = "0x18159F4", VA = "0x18159F4")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x181B580", Offset = "0x181B580", VA = "0x181B580")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB89294", Offset = "0xB89294")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000866")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB892CC", Offset = "0xB892CC")]
				public float weight;

				[Token(Token = "0x60007F9")]
				[Address(RVA = "0x181BBEC", Offset = "0x181BBEC", VA = "0x181BBEC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB882BC", Offset = "0xB882BC")]
			public Transform transform;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB882F4", Offset = "0xB882F4")]
			public Transform relativeTo;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8832C", Offset = "0xB8832C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88364", Offset = "0xB88364")]
			public float verticalWeight;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8839C", Offset = "0xB8839C")]
			public float horizontalWeight;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB883D4", Offset = "0xB883D4")]
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
			[Address(RVA = "0x181B758", Offset = "0x181B758", VA = "0x181B758")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x181BBC4", Offset = "0x181BBC4", VA = "0x181BBC4")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x181BBD4", Offset = "0x181BBD4", VA = "0x181BBD4")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB857A4", Offset = "0xB857A4")]
		public Body[] bodies;

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x181B618", Offset = "0x181B618", VA = "0x181B618", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x181BBBC", Offset = "0x181BBBC", VA = "0x181BBBC")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB857DC", Offset = "0xB857DC")]
		public float tiltSpeed;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85814", Offset = "0xB85814")]
		public float tiltSensitivity;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8584C", Offset = "0xB8584C")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85884", Offset = "0xB85884")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x181D26C", Offset = "0x181D26C", VA = "0x181D26C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x181D2B4", Offset = "0x181D2B4", VA = "0x181D2B4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x181D4E4", Offset = "0x181D4E4", VA = "0x181D4E4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8840C", Offset = "0xB8840C")]
			public string name;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88444", Offset = "0xB88444")]
			public Collider collider;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8847C", Offset = "0xB8847C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB884C8", Offset = "0xB884C8")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB884D8", Offset = "0xB884D8")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB884E8", Offset = "0xB884E8")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB884F8", Offset = "0xB884F8")]
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
				[Address(RVA = "0x1F37FC0", Offset = "0x1F37FC0", VA = "0x1F37FC0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000D3")]
			protected float crossFader
			{
				[Token(Token = "0x60007AE")]
				[Address(RVA = "0x1F38568", Offset = "0x1F38568", VA = "0x1F38568")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C260", Offset = "0xB8C260")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007AF")]
				[Address(RVA = "0x1F38570", Offset = "0x1F38570", VA = "0x1F38570")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C270", Offset = "0xB8C270")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D4")]
			protected float timer
			{
				[Token(Token = "0x60007B0")]
				[Address(RVA = "0x1F38578", Offset = "0x1F38578", VA = "0x1F38578")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C280", Offset = "0xB8C280")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007B1")]
				[Address(RVA = "0x1F38580", Offset = "0x1F38580", VA = "0x1F38580")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C290", Offset = "0xB8C290")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D5")]
			protected Vector3 force
			{
				[Token(Token = "0x60007B2")]
				[Address(RVA = "0x1F38588", Offset = "0x1F38588", VA = "0x1F38588")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C2A0", Offset = "0xB8C2A0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007B3")]
				[Address(RVA = "0x1F38594", Offset = "0x1F38594", VA = "0x1F38594")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C2B0", Offset = "0xB8C2B0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D6")]
			protected Vector3 point
			{
				[Token(Token = "0x60007B4")]
				[Address(RVA = "0x1F385A0", Offset = "0x1F385A0", VA = "0x1F385A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C2C0", Offset = "0xB8C2C0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007B5")]
				[Address(RVA = "0x1F385AC", Offset = "0x1F385AC", VA = "0x1F385AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C2D0", Offset = "0xB8C2D0")]
				private set
				{
				}
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x1F38434", Offset = "0x1F38434", VA = "0x1F38434")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x1F380A8", Offset = "0x1F380A8", VA = "0x1F380A8")]
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
			[Address(RVA = "0x1F385B8", Offset = "0x1F385B8", VA = "0x1F385B8")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB89304", Offset = "0xB89304")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000868")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8933C", Offset = "0xB8933C")]
				public float weight;

				[Token(Token = "0x4000869")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400086A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60007FA")]
				[Address(RVA = "0x1F38F34", Offset = "0x1F38F34", VA = "0x1F38F34")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60007FB")]
				[Address(RVA = "0x1F38D28", Offset = "0x1F38D28", VA = "0x1F38D28")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007FC")]
				[Address(RVA = "0x1F39070", Offset = "0x1F39070", VA = "0x1F39070")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88508", Offset = "0xB88508")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88540", Offset = "0xB88540")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88578", Offset = "0xB88578")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x1F38B44", Offset = "0x1F38B44", VA = "0x1F38B44", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x1F38CBC", Offset = "0x1F38CBC", VA = "0x1F38CBC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x1F38D3C", Offset = "0x1F38D3C", VA = "0x1F38D3C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x1F3905C", Offset = "0x1F3905C", VA = "0x1F3905C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB89374", Offset = "0xB89374")]
				public Transform bone;

				[Token(Token = "0x400086C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB893AC", Offset = "0xB893AC")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB893AC", Offset = "0xB893AC")]
				public float weight;

				[Token(Token = "0x400086D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x400086E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60007FD")]
				[Address(RVA = "0x1F3894C", Offset = "0x1F3894C", VA = "0x1F3894C")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60007FE")]
				[Address(RVA = "0x1F386D4", Offset = "0x1F386D4", VA = "0x1F386D4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007FF")]
				[Address(RVA = "0x1F38ABC", Offset = "0x1F38ABC", VA = "0x1F38ABC")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB885B0", Offset = "0xB885B0")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB885E8", Offset = "0xB885E8")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x1F385CC", Offset = "0x1F385CC", VA = "0x1F385CC", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x1F38670", Offset = "0x1F38670", VA = "0x1F38670", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x1F386E0", Offset = "0x1F386E0", VA = "0x1F386E0", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x1F38AA8", Offset = "0x1F38AA8", VA = "0x1F38AA8")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB858BC", Offset = "0xB858BC")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB858F4", Offset = "0xB858F4")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700006B")]
		public bool inProgress
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x1F37F04", Offset = "0x1F37F04", VA = "0x1F37F04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1F37FD4", Offset = "0x1F37FD4", VA = "0x1F37FD4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1F381F4", Offset = "0x1F381F4", VA = "0x1F381F4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1F38560", Offset = "0x1F38560", VA = "0x1F38560")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88620", Offset = "0xB88620")]
			public string name;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88658", Offset = "0xB88658")]
			public Collider collider;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88690", Offset = "0xB88690")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB886DC", Offset = "0xB886DC")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB886EC", Offset = "0xB886EC")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB886FC", Offset = "0xB886FC")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8870C", Offset = "0xB8870C")]
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
				[Address(RVA = "0x1F39628", Offset = "0x1F39628", VA = "0x1F39628")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C2E0", Offset = "0xB8C2E0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007C5")]
				[Address(RVA = "0x1F39630", Offset = "0x1F39630", VA = "0x1F39630")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C2F0", Offset = "0xB8C2F0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D8")]
			protected float timer
			{
				[Token(Token = "0x60007C6")]
				[Address(RVA = "0x1F39638", Offset = "0x1F39638", VA = "0x1F39638")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C300", Offset = "0xB8C300")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007C7")]
				[Address(RVA = "0x1F39640", Offset = "0x1F39640", VA = "0x1F39640")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C310", Offset = "0xB8C310")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D9")]
			protected Vector3 force
			{
				[Token(Token = "0x60007C8")]
				[Address(RVA = "0x1F39648", Offset = "0x1F39648", VA = "0x1F39648")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C320", Offset = "0xB8C320")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007C9")]
				[Address(RVA = "0x1F39654", Offset = "0x1F39654", VA = "0x1F39654")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C330", Offset = "0xB8C330")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DA")]
			protected Vector3 point
			{
				[Token(Token = "0x60007CA")]
				[Address(RVA = "0x1F39660", Offset = "0x1F39660", VA = "0x1F39660")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C340", Offset = "0xB8C340")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007CB")]
				[Address(RVA = "0x1F3966C", Offset = "0x1F3966C", VA = "0x1F3966C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8C350", Offset = "0xB8C350")]
				private set
				{
				}
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x1F394E0", Offset = "0x1F394E0", VA = "0x1F394E0")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x1F39144", Offset = "0x1F39144", VA = "0x1F39144")]
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
			[Address(RVA = "0x1F39678", Offset = "0x1F39678", VA = "0x1F39678")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB89400", Offset = "0xB89400")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000870")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB89438", Offset = "0xB89438")]
				public float weight;

				[Token(Token = "0x4000871")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000872")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000800")]
				[Address(RVA = "0x1F39B34", Offset = "0x1F39B34", VA = "0x1F39B34")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000801")]
				[Address(RVA = "0x1F398F0", Offset = "0x1F398F0", VA = "0x1F398F0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000802")]
				[Address(RVA = "0x1F39C50", Offset = "0x1F39C50", VA = "0x1F39C50")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8871C", Offset = "0xB8871C")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88754", Offset = "0xB88754")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8878C", Offset = "0xB8878C")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x1F3968C", Offset = "0x1F3968C", VA = "0x1F3968C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x1F39884", Offset = "0x1F39884", VA = "0x1F39884", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x1F39904", Offset = "0x1F39904", VA = "0x1F39904", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x1F39C34", Offset = "0x1F39C34", VA = "0x1F39C34")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB89470", Offset = "0xB89470")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000874")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB894A8", Offset = "0xB894A8")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB894A8", Offset = "0xB894A8")]
				public float weight;

				[Token(Token = "0x4000875")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000876")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000803")]
				[Address(RVA = "0x1F3A0CC", Offset = "0x1F3A0CC", VA = "0x1F3A0CC")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000804")]
				[Address(RVA = "0x1F39DA0", Offset = "0x1F39DA0", VA = "0x1F39DA0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000805")]
				[Address(RVA = "0x1F3A208", Offset = "0x1F3A208", VA = "0x1F3A208")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB887C4", Offset = "0xB887C4")]
			public int curveIndex;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB887FC", Offset = "0xB887FC")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x1F39C58", Offset = "0x1F39C58", VA = "0x1F39C58", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x1F39D3C", Offset = "0x1F39D3C", VA = "0x1F39D3C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x1F39DAC", Offset = "0x1F39DAC", VA = "0x1F39DAC", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x1F3A1F4", Offset = "0x1F3A1F4", VA = "0x1F3A1F4")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8592C", Offset = "0xB8592C")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85964", Offset = "0xB85964")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1F39078", Offset = "0x1F39078", VA = "0x1F39078", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1F39298", Offset = "0x1F39298", VA = "0x1F39298")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1F39620", Offset = "0x1F39620", VA = "0x1F39620")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB894FC", Offset = "0xB894FC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000878")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB89534", Offset = "0xB89534")]
				public float weight;

				[Token(Token = "0x6000806")]
				[Address(RVA = "0x1C3D428", Offset = "0x1C3D428", VA = "0x1C3D428")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88834", Offset = "0xB88834")]
			public Transform transform;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8886C", Offset = "0xB8886C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB888A4", Offset = "0xB888A4")]
			public float speed;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB888DC", Offset = "0xB888DC")]
			public float acceleration;

			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88914", Offset = "0xB88914")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB88914", Offset = "0xB88914")]
			public float matchVelocity;

			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88968", Offset = "0xB88968")]
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
			[Address(RVA = "0x1C3CDF8", Offset = "0x1C3CDF8", VA = "0x1C3CDF8")]
			public void Reset()
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x1C3CFB8", Offset = "0x1C3CFB8", VA = "0x1C3CFB8")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x1C3D40C", Offset = "0x1C3D40C", VA = "0x1C3D40C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8599C", Offset = "0xB8599C")]
		public Body[] bodies;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB859D4", Offset = "0xB859D4")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1C3CD80", Offset = "0x1C3CD80", VA = "0x1C3CD80")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1C3CED4", Offset = "0x1C3CED4", VA = "0x1C3CED4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1C3D3EC", Offset = "0x1C3D3EC", VA = "0x1C3D3EC")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB85A0C", Offset = "0xB85A0C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85A0C", Offset = "0xB85A0C")]
		public Transform target;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB85A6C", Offset = "0xB85A6C")]
		public float weight;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85A84", Offset = "0xB85A84")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85ABC", Offset = "0xB85ABC")]
		public float weightSmoothTime;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB85AF4", Offset = "0xB85AF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85AF4", Offset = "0xB85AF4")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85B54", Offset = "0xB85B54")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85B8C", Offset = "0xB85B8C")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85BC4", Offset = "0xB85BC4")]
		public float slerpSpeed;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85BFC", Offset = "0xB85BFC")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85C34", Offset = "0xB85C34")]
		public float minDistance;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB85C6C", Offset = "0xB85C6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85C6C", Offset = "0xB85C6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB85C6C", Offset = "0xB85C6C")]
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
			[Address(RVA = "0x1C472BC", Offset = "0x1C472BC", VA = "0x1C472BC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1C471D4", Offset = "0x1C471D4", VA = "0x1C471D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1C47408", Offset = "0x1C47408", VA = "0x1C47408")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1C47AAC", Offset = "0x1C47AAC", VA = "0x1C47AAC")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1C47C48", Offset = "0x1C47C48", VA = "0x1C47C48")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1C47F64", Offset = "0x1C47F64", VA = "0x1C47F64")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB889A0", Offset = "0xB889A0")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB889D8", Offset = "0xB889D8")]
			public float spring;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88A10", Offset = "0xB88A10")]
			public bool x;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88A48", Offset = "0xB88A48")]
			public bool y;

			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88A80", Offset = "0xB88A80")]
			public bool z;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88AB8", Offset = "0xB88AB8")]
			public float minX;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88AF0", Offset = "0xB88AF0")]
			public float maxX;

			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88B28", Offset = "0xB88B28")]
			public float minY;

			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88B60", Offset = "0xB88B60")]
			public float maxY;

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88B98", Offset = "0xB88B98")]
			public float minZ;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88BD0", Offset = "0xB88BD0")]
			public float maxZ;

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x1C483A4", Offset = "0x1C483A4", VA = "0x1C483A4")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x1C488F0", Offset = "0x1C488F0", VA = "0x1C488F0")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x1C48920", Offset = "0x1C48920", VA = "0x1C48920")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x1C489F8", Offset = "0x1C489F8", VA = "0x1C489F8")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000135")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB81624", Offset = "0xB81624")]
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
				[Address(RVA = "0x1C48880", Offset = "0x1C48880", VA = "0x1C48880", Slot = "4")]
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
				[Address(RVA = "0x1C488E8", Offset = "0x1C488E8", VA = "0x1C488E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x1C4826C", Offset = "0x1C4826C", VA = "0x1C4826C")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x1C48720", Offset = "0x1C48720", VA = "0x1C48720", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x1C48724", Offset = "0x1C48724", VA = "0x1C48724", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x1C48888", Offset = "0x1C48888", VA = "0x1C48888", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85CE8", Offset = "0xB85CE8")]
		public float weight;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85D20", Offset = "0xB85D20")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x1700006D")]
		protected float deltaTime
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x1C3CF8C", Offset = "0x1C3CF8C", VA = "0x1C3CF8C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005C4")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1C481C4", Offset = "0x1C481C4", VA = "0x1C481C4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1C481F0", Offset = "0x1C481F0", VA = "0x1C481F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB8B968", Offset = "0xB8B968")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1C48298", Offset = "0x1C48298", VA = "0x1C48298")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1C3D330", Offset = "0x1C3D330", VA = "0x1C3D330")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1C48604", Offset = "0x1C48604", VA = "0x1C48604", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1C3D3FC", Offset = "0x1C3D3FC", VA = "0x1C3D3FC")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000136")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB81634", Offset = "0xB81634")]
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
				[Address(RVA = "0x1C48E98", Offset = "0x1C48E98", VA = "0x1C48E98", Slot = "4")]
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
				[Address(RVA = "0x1C48F00", Offset = "0x1C48F00", VA = "0x1C48F00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x1C48AD4", Offset = "0x1C48AD4", VA = "0x1C48AD4")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x1C48D38", Offset = "0x1C48D38", VA = "0x1C48D38", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x1C48D3C", Offset = "0x1C48D3C", VA = "0x1C48D3C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x1C48EA0", Offset = "0x1C48EA0", VA = "0x1C48EA0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85D58", Offset = "0xB85D58")]
		public float weight;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85D90", Offset = "0xB85D90")]
		public VRIK ik;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x1700006E")]
		protected float deltaTime
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x1C48A00", Offset = "0x1C48A00", VA = "0x1C48A00")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005CC")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1C48A2C", Offset = "0x1C48A2C", VA = "0x1C48A2C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1C48A58", Offset = "0x1C48A58", VA = "0x1C48A58")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB8B9CC", Offset = "0xB8B9CC")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1C48B00", Offset = "0x1C48B00", VA = "0x1C48B00")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x1C48C0C", Offset = "0x1C48C0C", VA = "0x1C48C0C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1C48D28", Offset = "0x1C48D28", VA = "0x1C48D28")]
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
			[Address(RVA = "0x1C48FC8", Offset = "0x1C48FC8", VA = "0x1C48FC8")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x1C49424", Offset = "0x1C49424", VA = "0x1C49424")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x1C48F08", Offset = "0x1C48F08", VA = "0x1C48F08")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x1C49300", Offset = "0x1C49300", VA = "0x1C49300")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1C493B8", Offset = "0x1C493B8", VA = "0x1C493B8")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB8956C", Offset = "0xB8956C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400087A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB895A4", Offset = "0xB895A4")]
				public float weight;

				[Token(Token = "0x6000807")]
				[Address(RVA = "0x1C49ADC", Offset = "0x1C49ADC", VA = "0x1C49ADC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88C08", Offset = "0xB88C08")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88C40", Offset = "0xB88C40")]
			public Transform raycastTo;

			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88C78", Offset = "0xB88C78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB88C78", Offset = "0xB88C78")]
			public float raycastRadius;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88CCC", Offset = "0xB88CCC")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88D04", Offset = "0xB88D04")]
			public float smoothTimeIn;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88D3C", Offset = "0xB88D3C")]
			public float smoothTimeOut;

			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88D74", Offset = "0xB88D74")]
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
			[Address(RVA = "0x1C494B0", Offset = "0x1C494B0", VA = "0x1C494B0")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x1C496BC", Offset = "0x1C496BC", VA = "0x1C496BC")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x1C49854", Offset = "0x1C49854", VA = "0x1C49854")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x1C49AC8", Offset = "0x1C49AC8", VA = "0x1C49AC8")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85DC8", Offset = "0xB85DC8")]
		public Avoider[] avoiders;

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x1C4942C", Offset = "0x1C4942C", VA = "0x1C4942C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x1C496AC", Offset = "0x1C496AC", VA = "0x1C496AC")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB895DC", Offset = "0xB895DC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400087C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB89614", Offset = "0xB89614")]
				public float weight;

				[Token(Token = "0x6000808")]
				[Address(RVA = "0x1D68C98", Offset = "0x1D68C98", VA = "0x1D68C98")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88DAC", Offset = "0xB88DAC")]
			public Vector3 offset;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88DE4", Offset = "0xB88DE4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB88DE4", Offset = "0xB88DE4")]
			public float additivity;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88E38", Offset = "0xB88E38")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88E70", Offset = "0xB88E70")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x1D68960", Offset = "0x1D68960", VA = "0x1D68960")]
			public void Start()
			{
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x1D68A10", Offset = "0x1D68A10", VA = "0x1D68A10")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x1D68C84", Offset = "0x1D68C84", VA = "0x1D68C84")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85E00", Offset = "0xB85E00")]
		public AimIK aimIK;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85E38", Offset = "0xB85E38")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85E70", Offset = "0xB85E70")]
		public Handedness handedness;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85EA8", Offset = "0xB85EA8")]
		public bool twoHanded;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85EE0", Offset = "0xB85EE0")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85F18", Offset = "0xB85F18")]
		public float magnitudeRandom;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85F50", Offset = "0xB85F50")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85F88", Offset = "0xB85F88")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85FC0", Offset = "0xB85FC0")]
		public float blendTime;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xB85FF8", Offset = "0xB85FF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB85FF8", Offset = "0xB85FF8")]
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
			[Address(RVA = "0x1C4B6AC", Offset = "0x1C4B6AC", VA = "0x1C4B6AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x1C4C420", Offset = "0x1C4C420", VA = "0x1C4C420")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x1C4C460", Offset = "0x1C4C460", VA = "0x1C4C460")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		private Transform primaryHand
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x1C4C3E0", Offset = "0x1C4C3E0", VA = "0x1C4C3E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x1C4C400", Offset = "0x1C4C400", VA = "0x1C4C400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1C4B6DC", Offset = "0x1C4B6DC", VA = "0x1C4B6DC")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1C4B708", Offset = "0x1C4B708", VA = "0x1C4B708")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x1C4B8D8", Offset = "0x1C4B8D8", VA = "0x1C4B8D8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1C4C4A0", Offset = "0x1C4C4A0", VA = "0x1C4C4A0")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1C4C5F8", Offset = "0x1C4C5F8", VA = "0x1C4C5F8")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x1C4C634", Offset = "0x1C4C634", VA = "0x1C4C634", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x1C4C800", Offset = "0x1C4C800", VA = "0x1C4C800")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86058", Offset = "0xB86058")]
		public float weight;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB86090", Offset = "0xB86090")]
		public float offset;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1D6C5F0", Offset = "0x1D6C5F0", VA = "0x1D6C5F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1D6C6E4", Offset = "0x1D6C6E4", VA = "0x1D6C6E4")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1D6C7D0", Offset = "0x1D6C7D0", VA = "0x1D6C7D0")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1D6CC18", Offset = "0x1D6CC18", VA = "0x1D6CC18")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x1D6CC50", Offset = "0x1D6CC50", VA = "0x1D6CC50")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1D6CD6C", Offset = "0x1D6CD6C", VA = "0x1D6CD6C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88EA8", Offset = "0xB88EA8")]
			public float scaleMlp;

			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88EE0", Offset = "0xB88EE0")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88F18", Offset = "0xB88F18")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88F50", Offset = "0xB88F50")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88F88", Offset = "0xB88F88")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88FC0", Offset = "0xB88FC0")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB88FF8", Offset = "0xB88FF8")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB89030", Offset = "0xB89030")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB89068", Offset = "0xB89068")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xB890A0", Offset = "0xB890A0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB890A0", Offset = "0xB890A0")]
			public Vector3 headOffset;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB890F0", Offset = "0xB890F0")]
			public Vector3 handOffset;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB89128", Offset = "0xB89128")]
			public float footForwardOffset;

			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB89160", Offset = "0xB89160")]
			public float footInwardOffset;

			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB89198", Offset = "0xB89198")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB89198", Offset = "0xB89198")]
			public float footHeadingOffset;

			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB891F4", Offset = "0xB891F4")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB8920C", Offset = "0xB8920C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x1D721AC", Offset = "0x1D721AC", VA = "0x1D721AC")]
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
				[Address(RVA = "0x1D711D8", Offset = "0x1D711D8", VA = "0x1D711D8")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x600080A")]
				[Address(RVA = "0x1D71D4C", Offset = "0x1D71D4C", VA = "0x1D71D4C")]
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
			[Address(RVA = "0x1D7061C", Offset = "0x1D7061C", VA = "0x1D7061C")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1D6F160", Offset = "0x1D6F160", VA = "0x1D6F160")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1D6F2C8", Offset = "0x1D6F2C8", VA = "0x1D6F2C8")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x1D70794", Offset = "0x1D70794", VA = "0x1D70794")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1D7129C", Offset = "0x1D7129C", VA = "0x1D7129C")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1D71DAC", Offset = "0x1D71DAC", VA = "0x1D71DAC")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB860C8", Offset = "0xB860C8")]
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
			[Address(RVA = "0x1D722A4", Offset = "0x1D722A4", VA = "0x1D722A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BA30", Offset = "0xB8BA30")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x1D722B0", Offset = "0x1D722B0", VA = "0x1D722B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB8BA40", Offset = "0xB8BA40")]
			private set
			{
			}
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1D722BC", Offset = "0x1D722BC", VA = "0x1D722BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1D70F7C", Offset = "0x1D70F7C", VA = "0x1D70F7C")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1D72004", Offset = "0x1D72004", VA = "0x1D72004")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1D723B8", Offset = "0x1D723B8", VA = "0x1D723B8")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1D7285C", Offset = "0x1D7285C", VA = "0x1D7285C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1D72978", Offset = "0x1D72978", VA = "0x1D72978")]
		public VRIKRootController()
		{
		}
	}
}
