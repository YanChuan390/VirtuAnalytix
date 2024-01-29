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
	[Address(RVA = "0x108FE2C", Offset = "0x108FE2C", VA = "0x108FE2C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1090028", Offset = "0x1090028", VA = "0x1090028", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1090320", Offset = "0x1090320", VA = "0x1090320")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000003")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1096344", Offset = "0x1096344", VA = "0x1096344")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1096458", Offset = "0x1096458", VA = "0x1096458")]
	public EventSystemChecker()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x555D90", Offset = "0x555D90")]
public class ForcedReset : MonoBehaviour
{
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1098104", Offset = "0x1098104", VA = "0x1098104")]
	private void Update()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x10981D0", Offset = "0x10981D0", VA = "0x10981D0")]
	public ForcedReset()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000005")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000006")]
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

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x108D090", Offset = "0x108D090", VA = "0x108D090")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x108D530", Offset = "0x108D530", VA = "0x108D530")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x108D534", Offset = "0x108D534", VA = "0x108D534")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000008")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x600000D")]
			[Address(RVA = "0x131EDB0", Offset = "0x131EDB0", VA = "0x131EDB0")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000009")]
		public class ReplacementList
		{
			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x600000E")]
			[Address(RVA = "0x131EDB8", Offset = "0x131EDB8", VA = "0x131EDB8")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x109079C", Offset = "0x109079C", VA = "0x109079C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1091278", Offset = "0x1091278", VA = "0x1091278")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000B")]
		public class Vector3andSpace
		{
			[Token(Token = "0x4000016")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x4000017")]
			[FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x6000012")]
			[Address(RVA = "0x131EE20", Offset = "0x131EE20", VA = "0x131EE20")]
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

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1091280", Offset = "0x1091280", VA = "0x1091280")]
		private void Start()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x10912A8", Offset = "0x10912A8", VA = "0x10912A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1091378", Offset = "0x1091378", VA = "0x1091378")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x200000C")]
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

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1092890", Offset = "0x1092890", VA = "0x1092890")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1092904", Offset = "0x1092904", VA = "0x1092904")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x109290C", Offset = "0x109290C", VA = "0x109290C")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1092914", Offset = "0x1092914", VA = "0x1092914")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1092A10", Offset = "0x1092A10", VA = "0x1092A10")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
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

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1095750", Offset = "0x1095750", VA = "0x1095750")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x10957F4", Offset = "0x10957F4", VA = "0x10957F4")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x10958F0", Offset = "0x10958F0", VA = "0x10958F0")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x200000F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x555DF0", Offset = "0x555DF0")]
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
				[Token(Token = "0x6000022")]
				[Address(RVA = "0x131F338", Offset = "0x131F338", VA = "0x131F338", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000002")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000024")]
				[Address(RVA = "0x131F380", Offset = "0x131F380", VA = "0x131F380", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600001F")]
			[Address(RVA = "0x131F0B0", Offset = "0x131F0B0", VA = "0x131F0B0")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000020")]
			[Address(RVA = "0x131F0DC", Offset = "0x131F0DC", VA = "0x131F0DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000021")]
			[Address(RVA = "0x131F0E0", Offset = "0x131F0E0", VA = "0x131F0E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000023")]
			[Address(RVA = "0x131F340", Offset = "0x131F340", VA = "0x131F340", Slot = "8")]
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

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1095C40", Offset = "0x1095C40", VA = "0x1095C40")]
		private void Update()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1096090", Offset = "0x1096090", VA = "0x1096090")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x557758", Offset = "0x557758")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1095FD8", Offset = "0x1095FD8", VA = "0x1095FD8")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1096118", Offset = "0x1096118", VA = "0x1096118")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x2000010")]
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

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1096120", Offset = "0x1096120", VA = "0x1096120")]
		private void Start()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1096154", Offset = "0x1096154", VA = "0x1096154")]
		private void Update()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1096310", Offset = "0x1096310", VA = "0x1096310")]
		public DynamicShadowSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	public class FOVKick
	{
		[Token(Token = "0x2000012")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x555E00", Offset = "0x555E00")]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000045")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000046")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000047")]
			[FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x4000048")]
			[FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000003")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000031")]
				[Address(RVA = "0x132038C", Offset = "0x132038C", VA = "0x132038C", Slot = "4")]
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
				[Address(RVA = "0x13203D4", Offset = "0x13203D4", VA = "0x13203D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600002E")]
			[Address(RVA = "0x1320220", Offset = "0x1320220", VA = "0x1320220")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600002F")]
			[Address(RVA = "0x132024C", Offset = "0x132024C", VA = "0x132024C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000030")]
			[Address(RVA = "0x1320250", Offset = "0x1320250", VA = "0x1320250", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000032")]
			[Address(RVA = "0x1320394", Offset = "0x1320394", VA = "0x1320394", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000013")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x555E10", Offset = "0x555E10")]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000049")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400004A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400004B")]
			[FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x400004C")]
			[FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000005")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000037")]
				[Address(RVA = "0x13201D0", Offset = "0x13201D0", VA = "0x13201D0", Slot = "4")]
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
				[Address(RVA = "0x1320218", Offset = "0x1320218", VA = "0x1320218", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000034")]
			[Address(RVA = "0x1320050", Offset = "0x1320050", VA = "0x1320050")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000035")]
			[Address(RVA = "0x132007C", Offset = "0x132007C", VA = "0x132007C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1320080", Offset = "0x1320080", VA = "0x1320080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000038")]
			[Address(RVA = "0x13201D8", Offset = "0x13201D8", VA = "0x13201D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x10968A0", Offset = "0x10968A0", VA = "0x10968A0")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x10968EC", Offset = "0x10968EC", VA = "0x10968EC")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x10969D8", Offset = "0x10969D8", VA = "0x10969D8")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x10969E0", Offset = "0x10969E0", VA = "0x10969E0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x557808", Offset = "0x557808")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1096A58", Offset = "0x1096A58", VA = "0x1096A58")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x557868", Offset = "0x557868")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1096AD0", Offset = "0x1096AD0", VA = "0x1096AD0")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x555E20", Offset = "0x555E20")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x400004D")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x4000051")]
		private const string display = "{0} FPS";

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1096AEC", Offset = "0x1096AEC", VA = "0x1096AEC")]
		private void Start()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1096B5C", Offset = "0x1096B5C", VA = "0x1096B5C")]
		private void Update()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1096C60", Offset = "0x1096C60", VA = "0x1096C60")]
		public FPSCounter()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x109808C", Offset = "0x109808C", VA = "0x109808C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x10980EC", Offset = "0x10980EC", VA = "0x10980EC")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000016")]
	public class LerpControlledBob
	{
		[Token(Token = "0x2000017")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x555E80", Offset = "0x555E80")]
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
				[Token(Token = "0x6000045")]
				[Address(RVA = "0x13205B0", Offset = "0x13205B0", VA = "0x13205B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000008")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000047")]
				[Address(RVA = "0x13205F8", Offset = "0x13205F8", VA = "0x13205F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000042")]
			[Address(RVA = "0x13203DC", Offset = "0x13203DC", VA = "0x13203DC")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000043")]
			[Address(RVA = "0x1320408", Offset = "0x1320408", VA = "0x1320408", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000044")]
			[Address(RVA = "0x132040C", Offset = "0x132040C", VA = "0x132040C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0x13205B8", Offset = "0x13205B8", VA = "0x13205B8", Slot = "8")]
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

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1099AD4", Offset = "0x1099AD4", VA = "0x1099AD4")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x10971C8", Offset = "0x10971C8", VA = "0x10971C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x557968", Offset = "0x557968")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1098084", Offset = "0x1098084", VA = "0x1098084")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x2000019")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x555E90", Offset = "0x555E90")]
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
				[Token(Token = "0x600004F")]
				[Address(RVA = "0x1320878", Offset = "0x1320878", VA = "0x1320878", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000051")]
				[Address(RVA = "0x13208C0", Offset = "0x13208C0", VA = "0x13208C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600004C")]
			[Address(RVA = "0x1320600", Offset = "0x1320600", VA = "0x1320600")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600004D")]
			[Address(RVA = "0x132062C", Offset = "0x132062C", VA = "0x132062C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0x1320630", Offset = "0x1320630", VA = "0x1320630", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000050")]
			[Address(RVA = "0x1320880", Offset = "0x1320880", VA = "0x1320880", Slot = "8")]
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

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x109A984", Offset = "0x109A984", VA = "0x109A984")]
		private void Start()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x109AAA4", Offset = "0x109AAA4", VA = "0x109AAA4")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x109AAD0", Offset = "0x109AAD0", VA = "0x109AAD0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x557A18", Offset = "0x557A18")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x109AB58", Offset = "0x109AB58", VA = "0x109AB58")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x200001B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x555EA0", Offset = "0x555EA0")]
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
				[Token(Token = "0x6000058")]
				[Address(RVA = "0x1320C30", Offset = "0x1320C30", VA = "0x1320C30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600005A")]
				[Address(RVA = "0x1320C78", Offset = "0x1320C78", VA = "0x1320C78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000055")]
			[Address(RVA = "0x13208C8", Offset = "0x13208C8", VA = "0x13208C8")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000056")]
			[Address(RVA = "0x13208F4", Offset = "0x13208F4", VA = "0x13208F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000057")]
			[Address(RVA = "0x13208F8", Offset = "0x13208F8", VA = "0x13208F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000059")]
			[Address(RVA = "0x1320C38", Offset = "0x1320C38", VA = "0x1320C38", Slot = "8")]
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

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x109AB60", Offset = "0x109AB60", VA = "0x109AB60")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x557AC8", Offset = "0x557AC8")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x109ABD8", Offset = "0x109ABD8", VA = "0x109ABD8")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x109ABE4", Offset = "0x109ABE4", VA = "0x109ABE4")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x200001D")]
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

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x109C4E4", Offset = "0x109C4E4", VA = "0x109C4E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x109C4E8", Offset = "0x109C4E8", VA = "0x109C4E8")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x109C504", Offset = "0x109C504", VA = "0x109C504")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x109C8B4", Offset = "0x109C8B4", VA = "0x109C8B4")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x18")]
		public Text camSwitchButton;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x20")]
		public GameObject[] objects;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x28")]
		private int m_CurrentActiveObject;

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1317028", Offset = "0x1317028", VA = "0x1317028")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1317094", Offset = "0x1317094", VA = "0x1317094")]
		public void NextCamera()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x131716C", Offset = "0x131716C", VA = "0x131716C")]
		public SimpleActivatorMenu()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1317174", Offset = "0x1317174", VA = "0x1317174")]
		private void Start()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x13171B0", Offset = "0x13171B0", VA = "0x13171B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1317488", Offset = "0x1317488", VA = "0x1317488")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1317618", Offset = "0x1317618", VA = "0x1317618")]
		private void Start()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x131761C", Offset = "0x131761C", VA = "0x131761C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x13178C4", Offset = "0x13178C4", VA = "0x13178C4")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000022")]
		public enum Action
		{
			[Token(Token = "0x4000088")]
			Activate,
			[Token(Token = "0x4000089")]
			Deactivate,
			[Token(Token = "0x400008A")]
			Destroy,
			[Token(Token = "0x400008B")]
			ReloadLevel,
			[Token(Token = "0x400008C")]
			Call
		}

		[Serializable]
		[Token(Token = "0x2000023")]
		public class Entry
		{
			[Token(Token = "0x400008D")]
			[FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x400008E")]
			[FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x400008F")]
			[FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x600006D")]
			[Address(RVA = "0x13212C8", Offset = "0x13212C8", VA = "0x13212C8")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000024")]
		public class Entries
		{
			[Token(Token = "0x4000090")]
			[FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x600006E")]
			[Address(RVA = "0x1319AFC", Offset = "0x1319AFC", VA = "0x1319AFC")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000025")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x555EB0", Offset = "0x555EB0")]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
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

			[Token(Token = "0x1700000D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000072")]
				[Address(RVA = "0x1320FF8", Offset = "0x1320FF8", VA = "0x1320FF8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000074")]
				[Address(RVA = "0x1321040", Offset = "0x1321040", VA = "0x1321040", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600006F")]
			[Address(RVA = "0x1319A08", Offset = "0x1319A08", VA = "0x1319A08")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000070")]
			[Address(RVA = "0x1320F24", Offset = "0x1320F24", VA = "0x1320F24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000071")]
			[Address(RVA = "0x1320F28", Offset = "0x1320F28", VA = "0x1320F28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000073")]
			[Address(RVA = "0x1321000", Offset = "0x1321000", VA = "0x1321000", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000026")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x555EC0", Offset = "0x555EC0")]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
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

			[Token(Token = "0x1700000F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000078")]
				[Address(RVA = "0x132111C", Offset = "0x132111C", VA = "0x132111C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000010")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600007A")]
				[Address(RVA = "0x1321164", Offset = "0x1321164", VA = "0x1321164", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000075")]
			[Address(RVA = "0x1319A34", Offset = "0x1319A34", VA = "0x1319A34")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000076")]
			[Address(RVA = "0x1321048", Offset = "0x1321048", VA = "0x1321048", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000077")]
			[Address(RVA = "0x132104C", Offset = "0x132104C", VA = "0x132104C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000079")]
			[Address(RVA = "0x1321124", Offset = "0x1321124", VA = "0x1321124", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000027")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x555ED0", Offset = "0x555ED0")]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000097")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000098")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000099")]
			[FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000011")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600007E")]
				[Address(RVA = "0x1321278", Offset = "0x1321278", VA = "0x1321278", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000012")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000080")]
				[Address(RVA = "0x13212C0", Offset = "0x13212C0", VA = "0x13212C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600007B")]
			[Address(RVA = "0x1319A60", Offset = "0x1319A60", VA = "0x1319A60")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600007C")]
			[Address(RVA = "0x132116C", Offset = "0x132116C", VA = "0x132116C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600007D")]
			[Address(RVA = "0x1321170", Offset = "0x1321170", VA = "0x1321170", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600007F")]
			[Address(RVA = "0x1321280", Offset = "0x1321280", VA = "0x1321280", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1319778", Offset = "0x1319778", VA = "0x1319778")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x13198A0", Offset = "0x13198A0", VA = "0x13198A0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x557B78", Offset = "0x557B78")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1319918", Offset = "0x1319918", VA = "0x1319918")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x557BD8", Offset = "0x557BD8")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1319990", Offset = "0x1319990", VA = "0x1319990")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x557C38", Offset = "0x557C38")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1319A8C", Offset = "0x1319A8C", VA = "0x1319A8C")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1319B04", Offset = "0x1319B04", VA = "0x1319B04")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1319B58", Offset = "0x1319B58", VA = "0x1319B58")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1319BF4", Offset = "0x1319BF4", VA = "0x1319BF4")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200002A")]
		public class WaypointList
		{
			[Token(Token = "0x40000AC")]
			[FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x40000AD")]
			[FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x6000090")]
			[Address(RVA = "0x131DFDC", Offset = "0x131DFDC", VA = "0x131DFDC")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x200002B")]
		public struct RoutePoint
		{
			[Token(Token = "0x40000AE")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40000AF")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x6000091")]
			[Address(RVA = "0x131DBB4", Offset = "0x131DBB4", VA = "0x131DBB4")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x556994", Offset = "0x556994")]
		private float <Length>k__BackingField;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000013")]
		public float Length
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x131D540", Offset = "0x131D540", VA = "0x131D540")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x557D88", Offset = "0x557D88")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x131D548", Offset = "0x131D548", VA = "0x131D548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x557D98", Offset = "0x557D98")]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x131D550", Offset = "0x131D550", VA = "0x131D550")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x131D56C", Offset = "0x131D56C", VA = "0x131D56C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x131D89C", Offset = "0x131D89C", VA = "0x131D89C")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x131D928", Offset = "0x131D928", VA = "0x131D928")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x131DBC4", Offset = "0x131DBC4", VA = "0x131DBC4")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x131D5C8", Offset = "0x131D5C8", VA = "0x131D5C8")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x131DCD0", Offset = "0x131DCD0", VA = "0x131DCD0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x131DF58", Offset = "0x131DF58", VA = "0x131DF58")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x131DCD8", Offset = "0x131DCD8", VA = "0x131DCD8")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x131DF60", Offset = "0x131DF60", VA = "0x131DF60")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x200002D")]
		public enum ProgressStyle
		{
			[Token(Token = "0x40000C0")]
			SmoothAlongRoute,
			[Token(Token = "0x40000C1")]
			PointToPoint
		}

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x556A14", Offset = "0x556A14")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x556A24", Offset = "0x556A24")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x556A34", Offset = "0x556A34")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000015")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x131E044", Offset = "0x131E044", VA = "0x131E044")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x557DA8", Offset = "0x557DA8")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x131E058", Offset = "0x131E058", VA = "0x131E058")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x557DB8", Offset = "0x557DB8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x131E06C", Offset = "0x131E06C", VA = "0x131E06C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x557DC8", Offset = "0x557DC8")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x131E080", Offset = "0x131E080", VA = "0x131E080")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x557DD8", Offset = "0x557DD8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x131E094", Offset = "0x131E094", VA = "0x131E094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x557DE8", Offset = "0x557DE8")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x131E0A8", Offset = "0x131E0A8", VA = "0x131E0A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x557DF8", Offset = "0x557DF8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x131E0BC", Offset = "0x131E0BC", VA = "0x131E0BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x131E1C4", Offset = "0x131E1C4", VA = "0x131E1C4")]
		public void Reset()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x131E29C", Offset = "0x131E29C", VA = "0x131E29C")]
		private void Update()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x131E698", Offset = "0x131E698", VA = "0x131E698")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x131E7E8", Offset = "0x131E7E8", VA = "0x131E7E8")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x555EE0", Offset = "0x555EE0")]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x108F4E0", Offset = "0x108F4E0", VA = "0x108F4E0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x108F584", Offset = "0x108F584", VA = "0x108F584")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x108F990", Offset = "0x108F990", VA = "0x108F990")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x108FE18", Offset = "0x108FE18", VA = "0x108FE18")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x2000030")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x555F40", Offset = "0x555F40")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000CC")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000CD")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000CE")]
			[FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x40000CF")]
			[FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x17000018")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000A7")]
				[Address(RVA = "0x131F8E0", Offset = "0x131F8E0", VA = "0x131F8E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000019")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000A9")]
				[Address(RVA = "0x131F928", Offset = "0x131F928", VA = "0x131F928", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x131F388", Offset = "0x131F388", VA = "0x131F388")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x131F3B4", Offset = "0x131F3B4", VA = "0x131F3B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x131F3B8", Offset = "0x131F3B8", VA = "0x131F3B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x131F8E8", Offset = "0x131F8E8", VA = "0x131F8E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1096460", Offset = "0x1096460", VA = "0x1096460")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x557E08", Offset = "0x557E08")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x10964D8", Offset = "0x10964D8", VA = "0x10964D8")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x10965FC", Offset = "0x10965FC", VA = "0x10965FC")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x2000032")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x555F50", Offset = "0x555F50")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000D1")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000D2")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000D3")]
			[FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x1700001A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000AF")]
				[Address(RVA = "0x131FCE0", Offset = "0x131FCE0", VA = "0x131FCE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000B1")]
				[Address(RVA = "0x131FD28", Offset = "0x131FD28", VA = "0x131FD28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x131F930", Offset = "0x131F930", VA = "0x131F930")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x131F95C", Offset = "0x131F95C", VA = "0x131F95C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x131F960", Offset = "0x131F960", VA = "0x131F960", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x131FCE8", Offset = "0x131FCE8", VA = "0x131FCE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1096604", Offset = "0x1096604", VA = "0x1096604")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x557EB8", Offset = "0x557EB8")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x109667C", Offset = "0x109667C", VA = "0x109667C")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x2000034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x555F60", Offset = "0x555F60")]
		private sealed class <OnCollisionEnter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000DB")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000DC")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000DD")]
			[FieldOffset(Offset = "0x20")]
			public Explosive <>4__this;

			[Token(Token = "0x40000DE")]
			[FieldOffset(Offset = "0x28")]
			public Collision col;

			[Token(Token = "0x1700001C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000B9")]
				[Address(RVA = "0x1320000", Offset = "0x1320000", VA = "0x1320000", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000BB")]
				[Address(RVA = "0x1320048", Offset = "0x1320048", VA = "0x1320048", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x131FD30", Offset = "0x131FD30", VA = "0x131FD30")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x131FD5C", Offset = "0x131FD5C", VA = "0x131FD5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x131FD60", Offset = "0x131FD60", VA = "0x131FD60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x1320008", Offset = "0x1320008", VA = "0x1320008", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x18")]
		public Transform explosionPrefab;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x20")]
		public float detonationImpactVelocity;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x24")]
		public float sizeMultiplier;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x28")]
		public bool reset;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x2C")]
		public float resetTimeDelay;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x30")]
		private bool m_Exploded;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x38")]
		private ObjectResetter m_ObjectResetter;

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x109668C", Offset = "0x109668C", VA = "0x109668C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x10966E8", Offset = "0x10966E8", VA = "0x10966E8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x557F68", Offset = "0x557F68")]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x109677C", Offset = "0x109677C", VA = "0x109677C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1096784", Offset = "0x1096784", VA = "0x1096784")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x10967A8", Offset = "0x10967A8", VA = "0x10967A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1096804", Offset = "0x1096804", VA = "0x1096804")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1096890", Offset = "0x1096890", VA = "0x1096890")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1096C68", Offset = "0x1096C68", VA = "0x1096C68")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1096CDC", Offset = "0x1096CDC", VA = "0x1096CDC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1096E98", Offset = "0x1096E98", VA = "0x1096E98")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1096EC0", Offset = "0x1096EC0", VA = "0x1096EC0")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1098EA8", Offset = "0x1098EA8", VA = "0x1098EA8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1099024", Offset = "0x1099024", VA = "0x1099024")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x109ABF8", Offset = "0x109ABF8", VA = "0x109ABF8")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x109AD58", Offset = "0x109AD58", VA = "0x109AD58")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1317554", Offset = "0x1317554", VA = "0x1317554")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1317610", Offset = "0x1317610", VA = "0x1317610")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x131CEE4", Offset = "0x131CEE4", VA = "0x131CEE4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x131CF40", Offset = "0x131CF40", VA = "0x131CF40")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x131D1B4", Offset = "0x131D1B4", VA = "0x131D1B4")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x200003B")]
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x131CCB0", Offset = "0x131CCB0", VA = "0x131CCB0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x131CEDC", Offset = "0x131CEDC", VA = "0x131CEDC")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x555F80", Offset = "0x555F80")]
	[ExecuteInEditMode]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1095B44", Offset = "0x1095B44", VA = "0x1095B44")]
		public void Awake()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1095B68", Offset = "0x1095B68", VA = "0x1095B68")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1095BD0", Offset = "0x1095BD0", VA = "0x1095BD0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1095C38", Offset = "0x1095C38", VA = "0x1095C38")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x555FF0", Offset = "0x555FF0")]
	[ExecuteInEditMode]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x10987EC", Offset = "0x10987EC", VA = "0x10987EC")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class MeshContainer
	{
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1099B20", Offset = "0x1099B20", VA = "0x1099B20")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1099B94", Offset = "0x1099B94", VA = "0x1099B94")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x556060", Offset = "0x556060")]
	[ExecuteInEditMode]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x109AD68", Offset = "0x109AD68", VA = "0x109AD68")]
		public void Start()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x109AE70", Offset = "0x109AE70", VA = "0x109AE70")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x109B1C8", Offset = "0x109B1C8", VA = "0x109B1C8")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x109B278", Offset = "0x109B278", VA = "0x109B278")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x109B354", Offset = "0x109B354", VA = "0x109B354")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x109BC20", Offset = "0x109BC20", VA = "0x109BC20")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x109BC7C", Offset = "0x109BC7C", VA = "0x109BC7C")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x109BD70", Offset = "0x109BD70", VA = "0x109BD70")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x109BDD8", Offset = "0x109BDD8", VA = "0x109BDD8")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x109B518", Offset = "0x109B518", VA = "0x109B518")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x109BE40", Offset = "0x109BE40", VA = "0x109BE40")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x109C288", Offset = "0x109C288", VA = "0x109C288")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x109BEA4", Offset = "0x109BEA4", VA = "0x109BEA4")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x109C44C", Offset = "0x109C44C", VA = "0x109C44C")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x109C15C", Offset = "0x109C15C", VA = "0x109C15C")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x109C46C", Offset = "0x109C46C", VA = "0x109C46C")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5560D0", Offset = "0x5560D0")]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x13178D8", Offset = "0x13178D8", VA = "0x13178D8")]
		public void Start()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x13179E8", Offset = "0x13179E8", VA = "0x13179E8")]
		public void Update()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1317C10", Offset = "0x1317C10", VA = "0x1317C10")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x2000042")]
		public enum WaterMode
		{
			[Token(Token = "0x400010D")]
			Simple,
			[Token(Token = "0x400010E")]
			Reflective,
			[Token(Token = "0x400010F")]
			Refractive
		}

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x131A758", Offset = "0x131A758", VA = "0x131A758")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x131C270", Offset = "0x131C270", VA = "0x131C270")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x131C608", Offset = "0x131C608", VA = "0x131C608")]
		private void Update()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x131BC3C", Offset = "0x131BC3C", VA = "0x131BC3C")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x131B290", Offset = "0x131B290", VA = "0x131B290")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x131B27C", Offset = "0x131B27C", VA = "0x131B27C")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x131B108", Offset = "0x131B108", VA = "0x131B108")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x131C144", Offset = "0x131C144", VA = "0x131C144")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x131BEA0", Offset = "0x131BEA0", VA = "0x131BEA0")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x131C8D8", Offset = "0x131C8D8", VA = "0x131C8D8")]
		public Water()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public enum WaterQuality
	{
		[Token(Token = "0x4000111")]
		High = 2,
		[Token(Token = "0x4000112")]
		Medium = 1,
		[Token(Token = "0x4000113")]
		Low = 0
	}
	[Token(Token = "0x2000044")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x131C9D4", Offset = "0x131C9D4", VA = "0x131C9D4")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x131CB68", Offset = "0x131CB68", VA = "0x131CB68")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x131CC18", Offset = "0x131CC18", VA = "0x131CC18")]
		public void Update()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x131CC98", Offset = "0x131CC98", VA = "0x131CC98")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x131D240", Offset = "0x131D240", VA = "0x131D240")]
		public void Start()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x131D244", Offset = "0x131D244", VA = "0x131D244")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x131D428", Offset = "0x131D428", VA = "0x131D428")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x131D538", Offset = "0x131D538", VA = "0x131D538")]
		public WaterTile()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000046")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1091380", Offset = "0x1091380", VA = "0x1091380")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x10915FC", Offset = "0x10915FC", VA = "0x10915FC")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x10917AC", Offset = "0x10917AC", VA = "0x10917AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x10917C8", Offset = "0x10917C8", VA = "0x10917C8", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1091888", Offset = "0x1091888", VA = "0x1091888", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x10918DC", Offset = "0x10918DC", VA = "0x10918DC")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1091ED4", Offset = "0x1091ED4", VA = "0x1091ED4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1091ED8", Offset = "0x1091ED8", VA = "0x1091ED8")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1091FB8", Offset = "0x1091FB8", VA = "0x1091FB8")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1092098", Offset = "0x1092098", VA = "0x1092098")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1092178", Offset = "0x1092178", VA = "0x1092178")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1092258", Offset = "0x1092258", VA = "0x1092258")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1092338", Offset = "0x1092338", VA = "0x1092338")]
		public void Update()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x109233C", Offset = "0x109233C", VA = "0x109233C")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x2000049")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x4000124")]
			Hardware,
			[Token(Token = "0x4000125")]
			Touch
		}

		[Token(Token = "0x200004A")]
		public class VirtualAxis
		{
			[Token(Token = "0x4000126")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x556A44", Offset = "0x556A44")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000127")]
			[FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x4000128")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x556A54", Offset = "0x556A54")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x1700001F")]
			public string name
			{
				[Token(Token = "0x6000121")]
				[Address(RVA = "0x131EE30", Offset = "0x131EE30", VA = "0x131EE30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558018", Offset = "0x558018")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000122")]
				[Address(RVA = "0x131EE38", Offset = "0x131EE38", VA = "0x131EE38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558028", Offset = "0x558028")]
				private set
				{
				}
			}

			[Token(Token = "0x17000020")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000123")]
				[Address(RVA = "0x131EE40", Offset = "0x131EE40", VA = "0x131EE40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558038", Offset = "0x558038")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000124")]
				[Address(RVA = "0x131EE48", Offset = "0x131EE48", VA = "0x131EE48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558048", Offset = "0x558048")]
				private set
				{
				}
			}

			[Token(Token = "0x17000021")]
			public float GetValue
			{
				[Token(Token = "0x6000129")]
				[Address(RVA = "0x131EEA8", Offset = "0x131EEA8", VA = "0x131EEA8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000022")]
			public float GetValueRaw
			{
				[Token(Token = "0x600012A")]
				[Address(RVA = "0x131EEB0", Offset = "0x131EEB0", VA = "0x131EEB0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000125")]
			[Address(RVA = "0x1319480", Offset = "0x1319480", VA = "0x1319480")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000126")]
			[Address(RVA = "0x131EE54", Offset = "0x131EE54", VA = "0x131EE54")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000127")]
			[Address(RVA = "0x1319700", Offset = "0x1319700", VA = "0x1319700")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x131EEA0", Offset = "0x131EEA0", VA = "0x131EEA0")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x200004B")]
		public class VirtualButton
		{
			[Token(Token = "0x4000129")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x556A64", Offset = "0x556A64")]
			private string <name>k__BackingField;

			[Token(Token = "0x400012A")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x556A74", Offset = "0x556A74")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x400012B")]
			[FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x400012C")]
			[FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x400012D")]
			[FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x17000023")]
			public string name
			{
				[Token(Token = "0x600012B")]
				[Address(RVA = "0x131EEB8", Offset = "0x131EEB8", VA = "0x131EEB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558058", Offset = "0x558058")]
				get
				{
					return null;
				}
				[Token(Token = "0x600012C")]
				[Address(RVA = "0x131EEC0", Offset = "0x131EEC0", VA = "0x131EEC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558068", Offset = "0x558068")]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600012D")]
				[Address(RVA = "0x131EEC8", Offset = "0x131EEC8", VA = "0x131EEC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558078", Offset = "0x558078")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600012E")]
				[Address(RVA = "0x131EED0", Offset = "0x131EED0", VA = "0x131EED0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558088", Offset = "0x558088")]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public bool GetButton
			{
				[Token(Token = "0x6000134")]
				[Address(RVA = "0x131F048", Offset = "0x131F048", VA = "0x131F048")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000026")]
			public bool GetButtonDown
			{
				[Token(Token = "0x6000135")]
				[Address(RVA = "0x131F050", Offset = "0x131F050", VA = "0x131F050")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000027")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000136")]
				[Address(RVA = "0x131F080", Offset = "0x131F080", VA = "0x131F080")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600012F")]
			[Address(RVA = "0x131EEDC", Offset = "0x131EEDC", VA = "0x131EEDC")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x6000130")]
			[Address(RVA = "0x131EF24", Offset = "0x131EF24", VA = "0x131EF24")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000131")]
			[Address(RVA = "0x131EF78", Offset = "0x131EF78", VA = "0x131EF78")]
			public void Pressed()
			{
			}

			[Token(Token = "0x6000132")]
			[Address(RVA = "0x131EFB4", Offset = "0x131EFB4", VA = "0x131EFB4")]
			public void Released()
			{
			}

			[Token(Token = "0x6000133")]
			[Address(RVA = "0x131EFE0", Offset = "0x131EFE0", VA = "0x131EFE0")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x1700001E")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x1095558", Offset = "0x1095558", VA = "0x1095558")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1094F30", Offset = "0x1094F30", VA = "0x1094F30")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1095000", Offset = "0x1095000", VA = "0x1095000")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1091494", Offset = "0x1091494", VA = "0x1091494")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x10950B4", Offset = "0x10950B4", VA = "0x10950B4")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x109150C", Offset = "0x109150C", VA = "0x109150C")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x109512C", Offset = "0x109512C", VA = "0x109512C")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x10951A4", Offset = "0x10951A4", VA = "0x10951A4")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1095268", Offset = "0x1095268", VA = "0x1095268")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1091584", Offset = "0x1091584", VA = "0x1091584")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x108F0C4", Offset = "0x108F0C4", VA = "0x108F0C4")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x109536C", Offset = "0x109536C", VA = "0x109536C")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x10952E0", Offset = "0x10952E0", VA = "0x10952E0")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x108F128", Offset = "0x108F128", VA = "0x108F128")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x10953D0", Offset = "0x10953D0", VA = "0x10953D0")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x109544C", Offset = "0x109544C", VA = "0x109544C")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1091F3C", Offset = "0x1091F3C", VA = "0x1091F3C")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x109201C", Offset = "0x109201C", VA = "0x109201C")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x10920FC", Offset = "0x10920FC", VA = "0x10920FC")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x10922BC", Offset = "0x10922BC", VA = "0x10922BC")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x10921DC", Offset = "0x10921DC", VA = "0x10921DC")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x10954C8", Offset = "0x10954C8", VA = "0x10954C8")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x10955D0", Offset = "0x10955D0", VA = "0x10955D0")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1095650", Offset = "0x1095650", VA = "0x1095650")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x10956D0", Offset = "0x10956D0", VA = "0x10956D0")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1099040", Offset = "0x1099040", VA = "0x1099040")]
		private void Update()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1099044", Offset = "0x1099044", VA = "0x1099044")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x10990C0", Offset = "0x10990C0", VA = "0x10990C0")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x200004E")]
		public enum AxisOption
		{
			[Token(Token = "0x4000139")]
			Both,
			[Token(Token = "0x400013A")]
			OnlyHorizontal,
			[Token(Token = "0x400013B")]
			OnlyVertical
		}

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x10994CC", Offset = "0x10994CC", VA = "0x10994CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1099624", Offset = "0x1099624", VA = "0x1099624")]
		private void Start()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1099660", Offset = "0x1099660", VA = "0x1099660")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x10994D0", Offset = "0x10994D0", VA = "0x10994D0")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x10996C4", Offset = "0x10996C4", VA = "0x10996C4", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x10997E8", Offset = "0x10997E8", VA = "0x10997E8", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1099830", Offset = "0x1099830", VA = "0x1099830", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1099834", Offset = "0x1099834", VA = "0x1099834")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x109988C", Offset = "0x109988C", VA = "0x109988C")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1099BD8", Offset = "0x1099BD8", VA = "0x1099BD8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1099BE8", Offset = "0x1099BE8", VA = "0x1099BE8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1099BE0", Offset = "0x1099BE0", VA = "0x1099BE0")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1099CFC", Offset = "0x1099CFC", VA = "0x1099CFC")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1099FB8", Offset = "0x1099FB8", VA = "0x1099FB8")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000051")]
		public enum AxisOptions
		{
			[Token(Token = "0x4000142")]
			ForwardAxis,
			[Token(Token = "0x4000143")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x2000052")]
		public class AxisMapping
		{
			[Token(Token = "0x2000053")]
			public enum MappingType
			{
				[Token(Token = "0x4000147")]
				NamedAxis,
				[Token(Token = "0x4000148")]
				MousePositionX,
				[Token(Token = "0x4000149")]
				MousePositionY,
				[Token(Token = "0x400014A")]
				MousePositionZ
			}

			[Token(Token = "0x4000144")]
			[FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x4000145")]
			[FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x600014C")]
			[Address(RVA = "0x1320F1C", Offset = "0x1320F1C", VA = "0x1320F1C")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1319398", Offset = "0x1319398", VA = "0x1319398")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x13194C0", Offset = "0x13194C0", VA = "0x13194C0")]
		private void Update()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x13196E8", Offset = "0x13196E8", VA = "0x13196E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1319768", Offset = "0x1319768", VA = "0x1319768")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x556180", Offset = "0x556180")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000055")]
		public enum AxisOption
		{
			[Token(Token = "0x400015E")]
			Both,
			[Token(Token = "0x400015F")]
			OnlyHorizontal,
			[Token(Token = "0x4000160")]
			OnlyVertical
		}

		[Token(Token = "0x2000056")]
		public enum ControlStyle
		{
			[Token(Token = "0x4000162")]
			Absolute,
			[Token(Token = "0x4000163")]
			Relative,
			[Token(Token = "0x4000164")]
			Swipe
		}

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1319C04", Offset = "0x1319C04", VA = "0x1319C04")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1319D8C", Offset = "0x1319D8C", VA = "0x1319D8C")]
		private void Start()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1319C08", Offset = "0x1319C08", VA = "0x1319C08")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1319E14", Offset = "0x1319E14", VA = "0x1319E14")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1319E80", Offset = "0x1319E80", VA = "0x1319E80", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1319EB8", Offset = "0x1319EB8", VA = "0x1319EB8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x131A000", Offset = "0x131A000", VA = "0x131A000", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x131A034", Offset = "0x131A034", VA = "0x131A034")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x131A134", Offset = "0x131A134", VA = "0x131A134")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x556A84", Offset = "0x556A84")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x17000028")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x131A1C4", Offset = "0x131A1C4", VA = "0x131A1C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558098", Offset = "0x558098")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x131A1D0", Offset = "0x131A1D0", VA = "0x131A1D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5580A8", Offset = "0x5580A8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x131A1DC", Offset = "0x131A1DC", VA = "0x131A1DC")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x131A240", Offset = "0x131A240", VA = "0x131A240")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x131A2A4", Offset = "0x131A2A4", VA = "0x131A2A4")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x131A404", Offset = "0x131A404", VA = "0x131A404")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x131A564", Offset = "0x131A564", VA = "0x131A564")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x131A604", Offset = "0x131A604", VA = "0x131A604")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x131A6A4", Offset = "0x131A6A4", VA = "0x131A6A4")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x131A740", Offset = "0x131A740", VA = "0x131A740")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x131A748", Offset = "0x131A748", VA = "0x131A748")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x131A750", Offset = "0x131A750", VA = "0x131A750")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x6000162")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x6000163")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x6000164")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x6000165")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x6000166")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000167")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000168")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000169")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x600016A")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x600016B")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x600016C")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1317E54", Offset = "0x1317E54", VA = "0x1317E54")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000058")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1099FC0", Offset = "0x1099FC0", VA = "0x1099FC0")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x109A04C", Offset = "0x109A04C", VA = "0x109A04C")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x109A0D8", Offset = "0x109A0D8", VA = "0x109A0D8", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x109A17C", Offset = "0x109A17C", VA = "0x109A17C", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x109A220", Offset = "0x109A220", VA = "0x109A220", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x109A2C4", Offset = "0x109A2C4", VA = "0x109A2C4", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x109A36C", Offset = "0x109A36C", VA = "0x109A36C", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x109A414", Offset = "0x109A414", VA = "0x109A414", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x109A4B8", Offset = "0x109A4B8", VA = "0x109A4B8", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x109A568", Offset = "0x109A568", VA = "0x109A568", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x109A60C", Offset = "0x109A60C", VA = "0x109A60C", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x109A6B0", Offset = "0x109A6B0", VA = "0x109A6B0", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x109A754", Offset = "0x109A754", VA = "0x109A754", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1094FF8", Offset = "0x1094FF8", VA = "0x1094FF8")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1317C18", Offset = "0x1317C18", VA = "0x1317C18", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1317C2C", Offset = "0x1317C2C", VA = "0x1317C2C", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1317C38", Offset = "0x1317C38", VA = "0x1317C38", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1317C44", Offset = "0x1317C44", VA = "0x1317C44", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1317C50", Offset = "0x1317C50", VA = "0x1317C50", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1317CA4", Offset = "0x1317CA4", VA = "0x1317CA4", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1317CF8", Offset = "0x1317CF8", VA = "0x1317CF8", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1317D4C", Offset = "0x1317D4C", VA = "0x1317D4C", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1317DA0", Offset = "0x1317DA0", VA = "0x1317DA0", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1317DF4", Offset = "0x1317DF4", VA = "0x1317DF4", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1317E48", Offset = "0x1317E48", VA = "0x1317E48", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1317E50", Offset = "0x1317E50", VA = "0x1317E50")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Car
{
	[Token(Token = "0x200005A")]
	public class BrakeLight : MonoBehaviour
	{
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x18")]
		public CarController car;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x20")]
		private Renderer m_Renderer;

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1091E3C", Offset = "0x1091E3C", VA = "0x1091E3C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1091E98", Offset = "0x1091E98", VA = "0x1091E98")]
		private void Update()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1091ECC", Offset = "0x1091ECC", VA = "0x1091ECC")]
		public BrakeLight()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5561E0", Offset = "0x5561E0")]
	public class CarAIControl : MonoBehaviour
	{
		[Token(Token = "0x200005C")]
		public enum BrakeCondition
		{
			[Token(Token = "0x4000182")]
			NeverBrake,
			[Token(Token = "0x4000183")]
			TargetDirectionDifference,
			[Token(Token = "0x4000184")]
			TargetDistance
		}

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x556A94", Offset = "0x556A94")]
		[SerializeField]
		private float m_CautiousSpeedFactor;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x556AD4", Offset = "0x556AD4")]
		[SerializeField]
		private float m_CautiousMaxAngle;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_CautiousMaxDistance;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_CautiousAngularVelocityFactor;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_SteerSensitivity;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_AccelSensitivity;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_BrakeSensitivity;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_LateralWanderDistance;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_LateralWanderSpeed;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x556B88", Offset = "0x556B88")]
		private float m_AccelWanderAmount;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_AccelWanderSpeed;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private BrakeCondition m_BrakeCondition;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool m_Driving;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform m_Target;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_StopWhenTargetReached;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_ReachTargetThreshold;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x60")]
		private float m_RandomPerlin;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x68")]
		private CarController m_CarController;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x70")]
		private float m_AvoidOtherCarTime;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x74")]
		private float m_AvoidOtherCarSlowdown;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x78")]
		private float m_AvoidPathOffset;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x80")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1092A64", Offset = "0x1092A64", VA = "0x1092A64")]
		private void Awake()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1092B08", Offset = "0x1092B08", VA = "0x1092B08")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x10932C0", Offset = "0x10932C0", VA = "0x10932C0")]
		private void OnCollisionStay(Collision col)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x10934DC", Offset = "0x10934DC", VA = "0x10934DC")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x109350C", Offset = "0x109350C", VA = "0x109350C")]
		public CarAIControl()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x556240", Offset = "0x556240")]
	public class CarAudio : MonoBehaviour
	{
		[Token(Token = "0x200005E")]
		public enum EngineAudioOptions
		{
			[Token(Token = "0x4000198")]
			Simple,
			[Token(Token = "0x4000199")]
			FourChannel
		}

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x18")]
		public EngineAudioOptions engineSoundStyle;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x20")]
		public AudioClip lowAccelClip;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x28")]
		public AudioClip lowDecelClip;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x30")]
		public AudioClip highAccelClip;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x38")]
		public AudioClip highDecelClip;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x40")]
		public float pitchMultiplier;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x44")]
		public float lowPitchMin;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x48")]
		public float lowPitchMax;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x4C")]
		public float highPitchMultiplier;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x50")]
		public float maxRolloffDistance;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x54")]
		public float dopplerLevel;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x58")]
		public bool useDoppler;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource m_LowAccel;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x68")]
		private AudioSource m_LowDecel;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x70")]
		private AudioSource m_HighAccel;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x78")]
		private AudioSource m_HighDecel;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x80")]
		private bool m_StartedSound;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x88")]
		private CarController m_CarController;

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1093554", Offset = "0x1093554", VA = "0x1093554")]
		private void StartSound()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1093744", Offset = "0x1093744", VA = "0x1093744")]
		private void StopSound()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x109382C", Offset = "0x109382C", VA = "0x109382C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1093638", Offset = "0x1093638", VA = "0x1093638")]
		private AudioSource SetUpEngineAudioSource(AudioClip clip)
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1093B74", Offset = "0x1093B74", VA = "0x1093B74")]
		private static float ULerp(float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1093B8C", Offset = "0x1093B8C", VA = "0x1093B8C")]
		public CarAudio()
		{
		}
	}
	[Token(Token = "0x200005F")]
	internal enum CarDriveType
	{
		[Token(Token = "0x400019B")]
		FrontWheelDrive,
		[Token(Token = "0x400019C")]
		RearWheelDrive,
		[Token(Token = "0x400019D")]
		FourWheelDrive
	}
	[Token(Token = "0x2000060")]
	internal enum SpeedType
	{
		[Token(Token = "0x400019F")]
		MPH,
		[Token(Token = "0x40001A0")]
		KPH
	}
	[Token(Token = "0x2000061")]
	public class CarController : MonoBehaviour
	{
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CarDriveType m_CarDriveType;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WheelCollider[] m_WheelColliders;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] m_WheelMeshes;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private WheelEffects[] m_WheelEffects;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector3 m_CentreOfMassOffset;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_MaximumSteerAngle;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x556C88", Offset = "0x556C88")]
		[SerializeField]
		private float m_SteerHelper;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x556CC8", Offset = "0x556CC8")]
		[SerializeField]
		private float m_TractionControl;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_FullTorqueOverAllWheels;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_ReverseTorque;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_MaxHandbrakeTorque;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_Downforce;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SpeedType m_SpeedType;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_Topspeed;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private static int NoOfGears;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_RevRangeBoundary;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_SlipLimit;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float m_BrakeTorque;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x78")]
		private Quaternion[] m_WheelMeshLocalRotations;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 m_Prevpos;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x8C")]
		private Vector3 m_Pos;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x98")]
		private float m_SteerAngle;

		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x9C")]
		private int m_GearNum;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0xA0")]
		private float m_GearFactor;

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0xA4")]
		private float m_OldRotation;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0xA8")]
		private float m_CurrentTorque;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0xB0")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40001BC")]
		private const float k_ReversingThreshold = 0.01f;

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x556DA8", Offset = "0x556DA8")]
		private bool <Skidding>k__BackingField;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x556DB8", Offset = "0x556DB8")]
		private float <BrakeInput>k__BackingField;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x556DC8", Offset = "0x556DC8")]
		private float <Revs>k__BackingField;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x556DD8", Offset = "0x556DD8")]
		private float <AccelInput>k__BackingField;

		[Token(Token = "0x17000029")]
		public bool Skidding
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1093BB8", Offset = "0x1093BB8", VA = "0x1093BB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5580B8", Offset = "0x5580B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x1093BC0", Offset = "0x1093BC0", VA = "0x1093BC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5580C8", Offset = "0x5580C8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public float BrakeInput
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x1093BCC", Offset = "0x1093BCC", VA = "0x1093BCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5580D8", Offset = "0x5580D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x1093BD4", Offset = "0x1093BD4", VA = "0x1093BD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5580E8", Offset = "0x5580E8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public float CurrentSteerAngle
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x1093BDC", Offset = "0x1093BDC", VA = "0x1093BDC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002C")]
		public float CurrentSpeed
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x109326C", Offset = "0x109326C", VA = "0x109326C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public float MaxSpeed
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x1093BE4", Offset = "0x1093BE4", VA = "0x1093BE4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002E")]
		public float Revs
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x1093BEC", Offset = "0x1093BEC", VA = "0x1093BEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5580F8", Offset = "0x5580F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x1093BF4", Offset = "0x1093BF4", VA = "0x1093BF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558108", Offset = "0x558108")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public float AccelInput
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x1093BFC", Offset = "0x1093BFC", VA = "0x1093BFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558118", Offset = "0x558118")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x1093C04", Offset = "0x1093C04", VA = "0x1093C04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558128", Offset = "0x558128")]
			private set
			{
			}
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1093C0C", Offset = "0x1093C0C", VA = "0x1093C0C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1093D70", Offset = "0x1093D70", VA = "0x1093D70")]
		private void GearChanging()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1093E80", Offset = "0x1093E80", VA = "0x1093E80")]
		private static float CurveFactor(float factor)
		{
			return default(float);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1093E94", Offset = "0x1093E94", VA = "0x1093E94")]
		private static float ULerp(float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1093EAC", Offset = "0x1093EAC", VA = "0x1093EAC")]
		private void CalculateGearFactor()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1093F8C", Offset = "0x1093F8C", VA = "0x1093F8C")]
		private void CalculateRevs()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1092FDC", Offset = "0x1092FDC", VA = "0x1092FDC")]
		public void Move(float steering, float accel, float footbrake, float handbrake)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1094490", Offset = "0x1094490", VA = "0x1094490")]
		private void CapSpeed()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1094224", Offset = "0x1094224", VA = "0x1094224")]
		private void ApplyDrive(float accel, float footbrake)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x109405C", Offset = "0x109405C", VA = "0x109405C")]
		private void SteerHelper()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1094564", Offset = "0x1094564", VA = "0x1094564")]
		private void AddDownForce()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1094668", Offset = "0x1094668", VA = "0x1094668")]
		private void CheckForWheelSpin()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x10947D4", Offset = "0x10947D4", VA = "0x10947D4")]
		private void TractionControl()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1094AA8", Offset = "0x1094AA8", VA = "0x1094AA8")]
		private void AdjustTorque(float forwardSlip)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1094A3C", Offset = "0x1094A3C", VA = "0x1094A3C")]
		private bool AnySkidSoundPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1094AF0", Offset = "0x1094AF0", VA = "0x1094AF0")]
		public CarController()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class CarSelfRighting : MonoBehaviour
	{
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_WaitTime;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_VelocityThreshold;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x20")]
		private float m_LastOkTime;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1094C24", Offset = "0x1094C24", VA = "0x1094C24")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1094C80", Offset = "0x1094C80", VA = "0x1094C80")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1094D2C", Offset = "0x1094D2C", VA = "0x1094D2C")]
		private void RightCar()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1094DDC", Offset = "0x1094DDC", VA = "0x1094DDC")]
		public CarSelfRighting()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5562A0", Offset = "0x5562A0")]
	public class CarUserControl : MonoBehaviour
	{
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x18")]
		private CarController m_Car;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1094DF0", Offset = "0x1094DF0", VA = "0x1094DF0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1094E4C", Offset = "0x1094E4C", VA = "0x1094E4C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1094F28", Offset = "0x1094F28", VA = "0x1094F28")]
		public CarUserControl()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class Mudguard : MonoBehaviour
	{
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x18")]
		public CarController carController;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x20")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x109A8AC", Offset = "0x109A8AC", VA = "0x109A8AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x109A8E8", Offset = "0x109A8E8", VA = "0x109A8E8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x109A97C", Offset = "0x109A97C", VA = "0x109A97C")]
		public Mudguard()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class SkidTrail : MonoBehaviour
	{
		[Token(Token = "0x2000066")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x556300", Offset = "0x556300")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001C9")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001CA")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001CB")]
			[FieldOffset(Offset = "0x20")]
			public SkidTrail <>4__this;

			[Token(Token = "0x17000030")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001C1")]
				[Address(RVA = "0x1320ECC", Offset = "0x1320ECC", VA = "0x1320ECC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000031")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001C3")]
				[Address(RVA = "0x1320F14", Offset = "0x1320F14", VA = "0x1320F14", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x1317520", Offset = "0x1317520", VA = "0x1317520")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x1320D8C", Offset = "0x1320D8C", VA = "0x1320D8C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x1320D90", Offset = "0x1320D90", VA = "0x1320D90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x1320ED4", Offset = "0x1320ED4", VA = "0x1320ED4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_PersistTime;

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x13174A8", Offset = "0x13174A8", VA = "0x13174A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x558138", Offset = "0x558138")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x131754C", Offset = "0x131754C", VA = "0x131754C")]
		public SkidTrail()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class Suspension : MonoBehaviour
	{
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x18")]
		public GameObject wheel;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 m_TargetOriginalPosition;

		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 m_Origin;

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1317F70", Offset = "0x1317F70", VA = "0x1317F70")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1317FD4", Offset = "0x1317FD4", VA = "0x1317FD4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1318064", Offset = "0x1318064", VA = "0x1318064")]
		public Suspension()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x556310", Offset = "0x556310")]
	public class WheelEffects : MonoBehaviour
	{
		[Token(Token = "0x2000069")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x556370", Offset = "0x556370")]
		private sealed class <StartSkidTrail>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001D7")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001D8")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001D9")]
			[FieldOffset(Offset = "0x20")]
			public WheelEffects <>4__this;

			[Token(Token = "0x17000034")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x132147C", Offset = "0x132147C", VA = "0x132147C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000035")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0x13214C4", Offset = "0x13214C4", VA = "0x13214C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x131EC8C", Offset = "0x131EC8C", VA = "0x131EC8C")]
			[DebuggerHidden]
			public <StartSkidTrail>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x13212D0", Offset = "0x13212D0", VA = "0x13212D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x13212D4", Offset = "0x13212D4", VA = "0x13212D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x1321484", Offset = "0x1321484", VA = "0x1321484", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x18")]
		public Transform SkidTrailPrefab;

		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x0")]
		public static Transform skidTrailsDetachedParent;

		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x20")]
		public ParticleSystem skidParticles;

		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x556E18", Offset = "0x556E18")]
		private bool <skidding>k__BackingField;

		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x556E28", Offset = "0x556E28")]
		private bool <PlayingAudio>k__BackingField;

		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x30")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x38")]
		private Transform m_SkidTrail;

		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x40")]
		private WheelCollider m_WheelCollider;

		[Token(Token = "0x17000032")]
		public bool skidding
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x131E804", Offset = "0x131E804", VA = "0x131E804")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5581E8", Offset = "0x5581E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x131E80C", Offset = "0x131E80C", VA = "0x131E80C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5581F8", Offset = "0x5581F8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public bool PlayingAudio
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x131E818", Offset = "0x131E818", VA = "0x131E818")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558208", Offset = "0x558208")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x131E820", Offset = "0x131E820", VA = "0x131E820")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558218", Offset = "0x558218")]
			private set
			{
			}
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x131E82C", Offset = "0x131E82C", VA = "0x131E82C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x131EA94", Offset = "0x131EA94", VA = "0x131EA94")]
		public void EmitTyreSmoke()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x131EC20", Offset = "0x131EC20", VA = "0x131EC20")]
		public void PlayAudio()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x131EC58", Offset = "0x131EC58", VA = "0x131EC58")]
		public void StopAudio()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x131EBA8", Offset = "0x131EBA8", VA = "0x131EBA8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x558228", Offset = "0x558228")]
		public IEnumerator StartSkidTrail()
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x131ECB8", Offset = "0x131ECB8", VA = "0x131ECB8")]
		public void EndSkidTrail()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x131ED84", Offset = "0x131ED84", VA = "0x131ED84")]
		public WheelEffects()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Aeroplane
{
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x556380", Offset = "0x556380")]
	public class AeroplaneAiControl : MonoBehaviour
	{
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_RollSensitivity;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_PitchSensitivity;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_LateralWanderDistance;

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_LateralWanderSpeed;

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_MaxClimbAngle;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MaxRollAngle;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_SpeedEffect;

		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_TakeoffHeight;

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform m_Target;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x40")]
		private AeroplaneController m_AeroplaneController;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x48")]
		private float m_RandomPerlin;

		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_TakenOff;

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x108D54C", Offset = "0x108D54C", VA = "0x108D54C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x108D5C4", Offset = "0x108D5C4", VA = "0x108D5C4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x108D5CC", Offset = "0x108D5CC", VA = "0x108D5CC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x108D888", Offset = "0x108D888", VA = "0x108D888")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x108D890", Offset = "0x108D890", VA = "0x108D890")]
		public AeroplaneAiControl()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class AeroplaneAudio : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200006C")]
		public class AdvancedSetttings
		{
			[Token(Token = "0x40001F3")]
			[FieldOffset(Offset = "0x10")]
			public float engineMinDistance;

			[Token(Token = "0x40001F4")]
			[FieldOffset(Offset = "0x14")]
			public float engineMaxDistance;

			[Token(Token = "0x40001F5")]
			[FieldOffset(Offset = "0x18")]
			public float engineDopplerLevel;

			[Token(Token = "0x40001F6")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x556F58", Offset = "0x556F58")]
			public float engineMasterVolume;

			[Token(Token = "0x40001F7")]
			[FieldOffset(Offset = "0x20")]
			public float windMinDistance;

			[Token(Token = "0x40001F8")]
			[FieldOffset(Offset = "0x24")]
			public float windMaxDistance;

			[Token(Token = "0x40001F9")]
			[FieldOffset(Offset = "0x28")]
			public float windDopplerLevel;

			[Token(Token = "0x40001FA")]
			[FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x556F70", Offset = "0x556F70")]
			public float windMasterVolume;

			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x131ED8C", Offset = "0x131ED8C", VA = "0x131ED8C")]
			public AdvancedSetttings()
			{
			}
		}

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioClip m_EngineSound;

		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_EngineMinThrottlePitch;

		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_EngineMaxThrottlePitch;

		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_EngineFwdSpeedMultiplier;

		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip m_WindSound;

		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_WindBasePitch;

		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_WindSpeedPitchFactor;

		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_WindMaxSpeedVolume;

		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AdvancedSetttings m_AdvancedSetttings;

		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x50")]
		private AudioSource m_EngineSoundSource;

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x58")]
		private AudioSource m_WindSoundSource;

		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x60")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x68")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x108D8B0", Offset = "0x108D8B0", VA = "0x108D8B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x108DAFC", Offset = "0x108DAFC", VA = "0x108DAFC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x108DC70", Offset = "0x108DC70", VA = "0x108DC70")]
		public AeroplaneAudio()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class AeroplaneControlSurfaceAnimator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200006E")]
		public class ControlSurface
		{
			[Token(Token = "0x200006F")]
			public enum Type
			{
				[Token(Token = "0x4000203")]
				Aileron,
				[Token(Token = "0x4000204")]
				Elevator,
				[Token(Token = "0x4000205")]
				Rudder,
				[Token(Token = "0x4000206")]
				RuddervatorNegative,
				[Token(Token = "0x4000207")]
				RuddervatorPositive
			}

			[Token(Token = "0x40001FE")]
			[FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40001FF")]
			[FieldOffset(Offset = "0x18")]
			public float amount;

			[Token(Token = "0x4000200")]
			[FieldOffset(Offset = "0x1C")]
			public Type type;

			[Token(Token = "0x4000201")]
			[FieldOffset(Offset = "0x20")]
			[HideInInspector]
			public Quaternion originalLocalRotation;

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x131EDA8", Offset = "0x131EDA8", VA = "0x131EDA8")]
			public ControlSurface()
			{
			}
		}

		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Smoothing;

		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ControlSurface[] m_ControlSurfaces;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x28")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x108DD0C", Offset = "0x108DD0C", VA = "0x108DD0C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x108DDD8", Offset = "0x108DDD8", VA = "0x108DDD8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x108DF10", Offset = "0x108DF10", VA = "0x108DF10")]
		private void RotateSurface(ControlSurface surface, Quaternion rotation)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x108DFF8", Offset = "0x108DFF8", VA = "0x108DFF8")]
		public AeroplaneControlSurfaceAnimator()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5563E0", Offset = "0x5563E0")]
	public class AeroplaneController : MonoBehaviour
	{
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MaxEnginePower;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_Lift;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_ZeroLiftSpeed;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_RollEffect;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_PitchEffect;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_YawEffect;

		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_BankedTurnEffect;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_AerodynamicEffect;

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_AutoTurnPitch;

		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_AutoRollLevel;

		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_AutoPitchLevel;

		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_AirBrakesEffect;

		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float m_ThrottleChangeSpeed;

		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_DragIncreaseFactor;

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x557098", Offset = "0x557098")]
		private float <Altitude>k__BackingField;

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5570A8", Offset = "0x5570A8")]
		private float <Throttle>k__BackingField;

		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5570B8", Offset = "0x5570B8")]
		private bool <AirBrakes>k__BackingField;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5570C8", Offset = "0x5570C8")]
		private float <ForwardSpeed>k__BackingField;

		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5570D8", Offset = "0x5570D8")]
		private float <EnginePower>k__BackingField;

		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5570E8", Offset = "0x5570E8")]
		private float <RollAngle>k__BackingField;

		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5570F8", Offset = "0x5570F8")]
		private float <PitchAngle>k__BackingField;

		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x557108", Offset = "0x557108")]
		private float <RollInput>k__BackingField;

		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x557118", Offset = "0x557118")]
		private float <PitchInput>k__BackingField;

		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x557128", Offset = "0x557128")]
		private float <YawInput>k__BackingField;

		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x557138", Offset = "0x557138")]
		private float <ThrottleInput>k__BackingField;

		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x7C")]
		private float m_OriginalDrag;

		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x80")]
		private float m_OriginalAngularDrag;

		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x84")]
		private float m_AeroFactor;

		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x88")]
		private bool m_Immobilized;

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x8C")]
		private float m_BankedTurnAmount;

		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x90")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x98")]
		private WheelCollider[] m_WheelColliders;

		[Token(Token = "0x17000036")]
		public float Altitude
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x108E008", Offset = "0x108E008", VA = "0x108E008")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5582D8", Offset = "0x5582D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x108E010", Offset = "0x108E010", VA = "0x108E010")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5582E8", Offset = "0x5582E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public float Throttle
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x108E018", Offset = "0x108E018", VA = "0x108E018")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5582F8", Offset = "0x5582F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x108E020", Offset = "0x108E020", VA = "0x108E020")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558308", Offset = "0x558308")]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool AirBrakes
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x108E028", Offset = "0x108E028", VA = "0x108E028")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558318", Offset = "0x558318")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x108E030", Offset = "0x108E030", VA = "0x108E030")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558328", Offset = "0x558328")]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public float ForwardSpeed
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x108E03C", Offset = "0x108E03C", VA = "0x108E03C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558338", Offset = "0x558338")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x108E044", Offset = "0x108E044", VA = "0x108E044")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558348", Offset = "0x558348")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public float EnginePower
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x108E04C", Offset = "0x108E04C", VA = "0x108E04C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558358", Offset = "0x558358")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x108E054", Offset = "0x108E054", VA = "0x108E054")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558368", Offset = "0x558368")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public float MaxEnginePower
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x108E05C", Offset = "0x108E05C", VA = "0x108E05C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003C")]
		public float RollAngle
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x108E064", Offset = "0x108E064", VA = "0x108E064")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558378", Offset = "0x558378")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x108E06C", Offset = "0x108E06C", VA = "0x108E06C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558388", Offset = "0x558388")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public float PitchAngle
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x108E074", Offset = "0x108E074", VA = "0x108E074")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558398", Offset = "0x558398")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x108E07C", Offset = "0x108E07C", VA = "0x108E07C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5583A8", Offset = "0x5583A8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public float RollInput
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x108E084", Offset = "0x108E084", VA = "0x108E084")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5583B8", Offset = "0x5583B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x108E08C", Offset = "0x108E08C", VA = "0x108E08C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5583C8", Offset = "0x5583C8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public float PitchInput
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x108E094", Offset = "0x108E094", VA = "0x108E094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5583D8", Offset = "0x5583D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x108E09C", Offset = "0x108E09C", VA = "0x108E09C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5583E8", Offset = "0x5583E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public float YawInput
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x108E0A4", Offset = "0x108E0A4", VA = "0x108E0A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5583F8", Offset = "0x5583F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x108E0AC", Offset = "0x108E0AC", VA = "0x108E0AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558408", Offset = "0x558408")]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public float ThrottleInput
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x108E0B4", Offset = "0x108E0B4", VA = "0x108E0B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558418", Offset = "0x558418")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x108E0BC", Offset = "0x108E0BC", VA = "0x108E0BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558428", Offset = "0x558428")]
			private set
			{
			}
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x108E0C4", Offset = "0x108E0C4", VA = "0x108E0C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x108D814", Offset = "0x108D814", VA = "0x108D814")]
		public void Move(float rollInput, float pitchInput, float yawInput, float throttleInput, bool airBrakes)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x108E238", Offset = "0x108E238", VA = "0x108E238")]
		private void ClampInputs()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x108E2D0", Offset = "0x108E2D0", VA = "0x108E2D0")]
		private void CalculateRollAndPitchAngles()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x108E3DC", Offset = "0x108E3DC", VA = "0x108E3DC")]
		private void AutoLevel()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x108E450", Offset = "0x108E450", VA = "0x108E450")]
		private void CalculateForwardSpeed()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x108E4B4", Offset = "0x108E4B4", VA = "0x108E4B4")]
		private void ControlThrottle()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x108E528", Offset = "0x108E528", VA = "0x108E528")]
		private void CalculateDrag()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x108E5D4", Offset = "0x108E5D4", VA = "0x108E5D4")]
		private void CaluclateAerodynamicEffect()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x108E830", Offset = "0x108E830", VA = "0x108E830")]
		private void CalculateLinearForces()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x108E9B0", Offset = "0x108E9B0", VA = "0x108E9B0")]
		private void CalculateTorque()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x108EB88", Offset = "0x108EB88", VA = "0x108EB88")]
		private void CalculateAltitude()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x108ECA8", Offset = "0x108ECA8", VA = "0x108ECA8")]
		public void Immobilize()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x108ECB4", Offset = "0x108ECB4", VA = "0x108ECB4")]
		public void Reset()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x108ECBC", Offset = "0x108ECBC", VA = "0x108ECBC")]
		public AeroplaneController()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class AeroplanePropellerAnimator : MonoBehaviour
	{
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_PropellorModel;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_PropellorBlur;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Texture2D[] m_PropellorBlurTextures;

		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x557178", Offset = "0x557178")]
		[SerializeField]
		private float m_ThrottleBlurStart;

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5571B8", Offset = "0x5571B8")]
		private float m_ThrottleBlurEnd;

		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_MaxRpm;

		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x40")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x48")]
		private int m_PropellorBlurState;

		[Token(Token = "0x4000230")]
		private const float k_RpmToDps = 60f;

		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x50")]
		private Renderer m_PropellorModelRenderer;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x58")]
		private Renderer m_PropellorBlurRenderer;

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x108ECFC", Offset = "0x108ECFC", VA = "0x108ECFC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x108EDD4", Offset = "0x108EDD4", VA = "0x108EDD4")]
		private void Update()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x108EF54", Offset = "0x108EF54", VA = "0x108EF54")]
		public AeroplanePropellerAnimator()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x556440", Offset = "0x556440")]
	public class AeroplaneUserControl2Axis : MonoBehaviour
	{
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x18")]
		public float maxRollAngle;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x1C")]
		public float maxPitchAngle;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x20")]
		private AeroplaneController m_Aeroplane;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x108EF78", Offset = "0x108EF78", VA = "0x108EF78")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x108EFD4", Offset = "0x108EFD4", VA = "0x108EFD4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x108F1A4", Offset = "0x108F1A4", VA = "0x108F1A4")]
		private void AdjustInputForMobileControls(ref float roll, ref float pitch, ref float throttle)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x108F288", Offset = "0x108F288", VA = "0x108F288")]
		public AeroplaneUserControl2Axis()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5564A0", Offset = "0x5564A0")]
	public class AeroplaneUserControl4Axis : MonoBehaviour
	{
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x18")]
		public float maxRollAngle;

		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x1C")]
		public float maxPitchAngle;

		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x20")]
		private AeroplaneController m_Aeroplane;

		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x28")]
		private float m_Throttle;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_AirBrakes;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x30")]
		private float m_Yaw;

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x108F29C", Offset = "0x108F29C", VA = "0x108F29C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x108F2F8", Offset = "0x108F2F8", VA = "0x108F2F8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x108F420", Offset = "0x108F420", VA = "0x108F420")]
		private void AdjustInputForMobileControls(ref float roll, ref float pitch, ref float throttle)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x108F4CC", Offset = "0x108F4CC", VA = "0x108F4CC")]
		public AeroplaneUserControl4Axis()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x556500", Offset = "0x556500")]
	public class JetParticleEffect : MonoBehaviour
	{
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x18")]
		public Color minColour;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x28")]
		private AeroplaneController m_Jet;

		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x30")]
		private ParticleSystem m_System;

		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x38")]
		private float m_OriginalStartSize;

		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x3C")]
		private float m_OriginalLifetime;

		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x40")]
		private Color m_OriginalStartColor;

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x10990C8", Offset = "0x10990C8", VA = "0x10990C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1099394", Offset = "0x1099394", VA = "0x1099394")]
		private void Update()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1099250", Offset = "0x1099250", VA = "0x1099250")]
		private AeroplaneController FindAeroplaneParent()
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x10994C4", Offset = "0x10994C4", VA = "0x10994C4")]
		public JetParticleEffect()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class LandingGear : MonoBehaviour
	{
		[Token(Token = "0x2000076")]
		private enum GearState
		{
			[Token(Token = "0x4000249")]
			Raised = -1,
			[Token(Token = "0x400024A")]
			Lowered = 1
		}

		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x18")]
		public float raiseAtAltitude;

		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x1C")]
		public float lowerAtAltitude;

		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x20")]
		private GearState m_State;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x28")]
		private Animator m_Animator;

		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x30")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x38")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1099914", Offset = "0x1099914", VA = "0x1099914")]
		private void Start()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x10999D0", Offset = "0x10999D0", VA = "0x10999D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1099AB8", Offset = "0x1099AB8", VA = "0x1099AB8")]
		public LandingGear()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Ball
{
	[Token(Token = "0x2000077")]
	public class Ball : MonoBehaviour
	{
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovePower;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_UseTorque;

		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MaxAngularVelocity;

		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x400024F")]
		private const float k_GroundRayLength = 1f;

		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x109194C", Offset = "0x109194C", VA = "0x109194C")]
		private void Start()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x10919C8", Offset = "0x10919C8", VA = "0x10919C8")]
		public void Move(Vector3 moveDirection, bool jump)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1091AE0", Offset = "0x1091AE0", VA = "0x1091AE0")]
		public Ball()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class BallUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x18")]
		private Ball ball;

		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 move;

		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x30")]
		private Transform cam;

		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 camForward;

		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x44")]
		private bool jump;

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1091B04", Offset = "0x1091B04", VA = "0x1091B04")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1091C2C", Offset = "0x1091C2C", VA = "0x1091C2C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1091DF8", Offset = "0x1091DF8", VA = "0x1091DF8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1091E34", Offset = "0x1091E34", VA = "0x1091E34")]
		public BallUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x556560", Offset = "0x556560")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x556560", Offset = "0x556560")]
	public class AICharacterControl : MonoBehaviour
	{
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x557248", Offset = "0x557248")]
		private NavMeshAgent <agent>k__BackingField;

		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x557258", Offset = "0x557258")]
		private ThirdPersonCharacter <character>k__BackingField;

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x17000042")]
		public NavMeshAgent agent
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x108CAB0", Offset = "0x108CAB0", VA = "0x108CAB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558438", Offset = "0x558438")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x108CAB8", Offset = "0x108CAB8", VA = "0x108CAB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558448", Offset = "0x558448")]
			private set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public ThirdPersonCharacter character
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x108CAC0", Offset = "0x108CAC0", VA = "0x108CAC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558458", Offset = "0x558458")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x108CAC8", Offset = "0x108CAC8", VA = "0x108CAC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558468", Offset = "0x558468")]
			private set
			{
			}
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x108CAD0", Offset = "0x108CAD0", VA = "0x108CAD0")]
		private void Start()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x108CB8C", Offset = "0x108CB8C", VA = "0x108CB8C")]
		private void Update()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x108CC60", Offset = "0x108CC60", VA = "0x108CC60")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x108CC68", Offset = "0x108CC68", VA = "0x108CC68")]
		public AICharacterControl()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5565F4", Offset = "0x5565F4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5565F4", Offset = "0x5565F4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5565F4", Offset = "0x5565F4")]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovingTurnSpeed;

		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_StationaryTurnSpeed;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x557298", Offset = "0x557298")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_RunCycleLegOffset;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MoveSpeedMultiplier;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_AnimSpeedMultiplier;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_GroundCheckDistance;

		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x40")]
		private Animator m_Animator;

		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x48")]
		private bool m_IsGrounded;

		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x4C")]
		private float m_OrigGroundCheckDistance;

		[Token(Token = "0x4000265")]
		private const float k_Half = 0.5f;

		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x50")]
		private float m_TurnAmount;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x54")]
		private float m_ForwardAmount;

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 m_GroundNormal;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x64")]
		private float m_CapsuleHeight;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 m_CapsuleCenter;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x78")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x80")]
		private bool m_Crouching;

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1318404", Offset = "0x1318404", VA = "0x1318404")]
		private void Start()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1318510", Offset = "0x1318510", VA = "0x1318510")]
		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x131897C", Offset = "0x131897C", VA = "0x131897C")]
		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1318B54", Offset = "0x1318B54", VA = "0x1318B54")]
		private void PreventStandingInLowHeadroom()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1318C94", Offset = "0x1318C94", VA = "0x1318C94")]
		private void UpdateAnimator(Vector3 move)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x13188D8", Offset = "0x13188D8", VA = "0x13188D8")]
		private void HandleAirborneMovement()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x13187B8", Offset = "0x13187B8", VA = "0x13187B8")]
		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1318740", Offset = "0x1318740", VA = "0x1318740")]
		private void ApplyExtraTurnRotation()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1318EF4", Offset = "0x1318EF4", VA = "0x1318EF4")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1318628", Offset = "0x1318628", VA = "0x1318628")]
		private void CheckGroundStatus()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1318FA4", Offset = "0x1318FA4", VA = "0x1318FA4")]
		public ThirdPersonCharacter()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5566BC", Offset = "0x5566BC")]
	public class ThirdPersonUserControl : MonoBehaviour
	{
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x18")]
		private ThirdPersonCharacter m_Character;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x20")]
		private Transform m_Cam;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 m_CamForward;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 m_Move;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x40")]
		private bool m_Jump;

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1318FC4", Offset = "0x1318FC4", VA = "0x1318FC4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x13190E8", Offset = "0x13190E8", VA = "0x13190E8")]
		private void Update()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1319174", Offset = "0x1319174", VA = "0x1319174")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1319390", Offset = "0x1319390", VA = "0x1319390")]
		public ThirdPersonUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x200007C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x55671C", Offset = "0x55671C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x55671C", Offset = "0x55671C")]
	public class FirstPersonController : MonoBehaviour
	{
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x557348", Offset = "0x557348")]
		private float m_RunstepLenghten;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MouseLook m_MouseLook;

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FOVKick m_FovKick;

		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioClip m_JumpSound;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AudioClip m_LandSound;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x88")]
		private Camera m_Camera;

		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x90")]
		private bool m_Jump;

		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x94")]
		private float m_YRotation;

		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x98")]
		private Vector2 m_Input;

		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0xB0")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0xB8")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0xBC")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0xC0")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0xCC")]
		private float m_StepCycle;

		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0xD0")]
		private float m_NextStep;

		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0xD4")]
		private bool m_Jumping;

		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0xD8")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1096ED0", Offset = "0x1096ED0", VA = "0x1096ED0")]
		private void Start()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1097058", Offset = "0x1097058", VA = "0x1097058")]
		private void Update()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1097240", Offset = "0x1097240", VA = "0x1097240")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1097294", Offset = "0x1097294", VA = "0x1097294")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x10976F0", Offset = "0x10976F0", VA = "0x10976F0")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1097730", Offset = "0x1097730", VA = "0x1097730")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1097A08", Offset = "0x1097A08", VA = "0x1097A08")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1097834", Offset = "0x1097834", VA = "0x1097834")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1097540", Offset = "0x1097540", VA = "0x1097540")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1097174", Offset = "0x1097174", VA = "0x1097174")]
		private void RotateView()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1097E48", Offset = "0x1097E48", VA = "0x1097E48")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1097F84", Offset = "0x1097F84", VA = "0x1097F84")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class HeadBob : MonoBehaviour
	{
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x18")]
		public Camera Camera;

		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x20")]
		public CurveControlledBob motionBob;

		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x28")]
		public LerpControlledBob jumpAndLandingBob;

		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x30")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x38")]
		public float StrideInterval;

		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x557458", Offset = "0x557458")]
		public float RunningStrideLengthen;

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1098BA8", Offset = "0x1098BA8", VA = "0x1098BA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1098C00", Offset = "0x1098C00", VA = "0x1098C00")]
		private void Update()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1098E04", Offset = "0x1098E04", VA = "0x1098E04")]
		public HeadBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007E")]
	public class MouseLook
	{
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1097004", Offset = "0x1097004", VA = "0x1097004")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1097B78", Offset = "0x1097B78", VA = "0x1097B78")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x109A7C8", Offset = "0x109A7C8", VA = "0x109A7C8")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x10979F8", Offset = "0x10979F8", VA = "0x10979F8")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x109A7FC", Offset = "0x109A7FC", VA = "0x109A7FC")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x109A760", Offset = "0x109A760", VA = "0x109A760")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x109A878", Offset = "0x109A878", VA = "0x109A878")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5567B0", Offset = "0x5567B0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5567B0", Offset = "0x5567B0")]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000080")]
		public class MovementSettings
		{
			[Token(Token = "0x40002AF")]
			[FieldOffset(Offset = "0x10")]
			public float ForwardSpeed;

			[Token(Token = "0x40002B0")]
			[FieldOffset(Offset = "0x14")]
			public float BackwardSpeed;

			[Token(Token = "0x40002B1")]
			[FieldOffset(Offset = "0x18")]
			public float StrafeSpeed;

			[Token(Token = "0x40002B2")]
			[FieldOffset(Offset = "0x1C")]
			public float RunMultiplier;

			[Token(Token = "0x40002B3")]
			[FieldOffset(Offset = "0x20")]
			public KeyCode RunKey;

			[Token(Token = "0x40002B4")]
			[FieldOffset(Offset = "0x24")]
			public float JumpForce;

			[Token(Token = "0x40002B5")]
			[FieldOffset(Offset = "0x28")]
			public AnimationCurve SlopeCurveModifier;

			[Token(Token = "0x40002B6")]
			[FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public float CurrentTargetSpeed;

			[Token(Token = "0x40002B7")]
			[FieldOffset(Offset = "0x34")]
			private bool m_Running;

			[Token(Token = "0x17000048")]
			public bool Running
			{
				[Token(Token = "0x6000260")]
				[Address(RVA = "0x1320D84", Offset = "0x1320D84", VA = "0x1320D84")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600025F")]
			[Address(RVA = "0x1316C90", Offset = "0x1316C90", VA = "0x1316C90")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x6000261")]
			[Address(RVA = "0x1316E40", Offset = "0x1316E40", VA = "0x1316E40")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000081")]
		public class AdvancedSettings
		{
			[Token(Token = "0x40002B8")]
			[FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			[Token(Token = "0x40002B9")]
			[FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x40002BA")]
			[FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			[Token(Token = "0x40002BB")]
			[FieldOffset(Offset = "0x1C")]
			public bool airControl;

			[Token(Token = "0x40002BC")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x557480", Offset = "0x557480")]
			public float shellOffset;

			[Token(Token = "0x6000262")]
			[Address(RVA = "0x131700C", Offset = "0x131700C", VA = "0x131700C")]
			public AdvancedSettings()
			{
			}
		}

		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x18")]
		public Camera cam;

		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x20")]
		public MovementSettings movementSettings;

		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x28")]
		public MouseLook mouseLook;

		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x30")]
		public AdvancedSettings advancedSettings;

		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x40")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x48")]
		private float m_YRotation;

		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 m_GroundContactNormal;

		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x58")]
		private bool m_Jump;

		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x59")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x5A")]
		private bool m_Jumping;

		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x5B")]
		private bool m_IsGrounded;

		[Token(Token = "0x17000044")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x13161EC", Offset = "0x13161EC", VA = "0x13161EC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000045")]
		public bool Grounded
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x1316208", Offset = "0x1316208", VA = "0x1316208")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		public bool Jumping
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x1316210", Offset = "0x1316210", VA = "0x1316210")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		public bool Running
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x1316218", Offset = "0x1316218", VA = "0x1316218")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1316234", Offset = "0x1316234", VA = "0x1316234")]
		private void Start()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1316304", Offset = "0x1316304", VA = "0x1316304")]
		private void Update()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1316514", Offset = "0x1316514", VA = "0x1316514")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1316A44", Offset = "0x1316A44", VA = "0x1316A44")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1316AB8", Offset = "0x1316AB8", VA = "0x1316AB8")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1316978", Offset = "0x1316978", VA = "0x1316978")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x131639C", Offset = "0x131639C", VA = "0x131639C")]
		private void RotateView()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x13167F8", Offset = "0x13167F8", VA = "0x13167F8")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1316D50", Offset = "0x1316D50", VA = "0x1316D50")]
		public RigidbodyFirstPersonController()
		{
		}
	}
}
namespace UnityStandardAssets.Cameras
{
	[Token(Token = "0x2000082")]
	public abstract class AbstractTargetFollower : MonoBehaviour
	{
		[Token(Token = "0x2000083")]
		public enum UpdateType
		{
			[Token(Token = "0x40002C2")]
			FixedUpdate,
			[Token(Token = "0x40002C3")]
			LateUpdate,
			[Token(Token = "0x40002C4")]
			ManualUpdate
		}

		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform m_Target;

		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_AutoTargetPlayer;

		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UpdateType m_UpdateType;

		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x28")]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x17000049")]
		public Transform Target
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x108D078", Offset = "0x108D078", VA = "0x108D078")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x108CC70", Offset = "0x108CC70", VA = "0x108CC70", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x108CDF8", Offset = "0x108CDF8", VA = "0x108CDF8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x108CEC8", Offset = "0x108CEC8", VA = "0x108CEC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x108CF9C", Offset = "0x108CF9C", VA = "0x108CF9C")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x6000267")]
		protected abstract void FollowTarget(float deltaTime);

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x108CD34", Offset = "0x108CD34", VA = "0x108CD34")]
		public void FindAndTargetPlayer()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x108D070", Offset = "0x108D070", VA = "0x108D070", Slot = "6")]
		public virtual void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x108D080", Offset = "0x108D080", VA = "0x108D080")]
		protected AbstractTargetFollower()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[ExecuteInEditMode]
	public class AutoCam : PivotBasedCameraRig
	{
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_RollSpeed;

		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_FollowVelocity;

		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool m_FollowTilt;

		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_SpinTurnLimit;

		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_TargetVelocityLowerLimit;

		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SmoothTurnTime;

		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x68")]
		private float m_LastFlatAngle;

		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x6C")]
		private float m_CurrentTurnAmount;

		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x70")]
		private float m_TurnSpeedVelocityChange;

		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x74")]
		private Vector3 m_RollUp;

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1090328", Offset = "0x1090328", VA = "0x1090328", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1090724", Offset = "0x1090724", VA = "0x1090724")]
		public AutoCam()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class FreeLookCam : PivotBasedCameraRig
	{
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x557578", Offset = "0x557578")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_TurnSmoothing;

		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_TiltMax;

		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_TiltMin;

		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_LockCursor;

		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool m_VerticalAutoReturn;

		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x64")]
		private float m_LookAngle;

		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x68")]
		private float m_TiltAngle;

		[Token(Token = "0x40002DA")]
		private const float k_LookDistance = 100f;

		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 m_PivotEulers;

		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x78")]
		private Quaternion m_PivotTargetRot;

		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x88")]
		private Quaternion m_TransformTargetRot;

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x10981D8", Offset = "0x10981D8", VA = "0x10981D8", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1098328", Offset = "0x1098328", VA = "0x1098328")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x109865C", Offset = "0x109865C", VA = "0x109865C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1098680", Offset = "0x1098680", VA = "0x1098680", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1098388", Offset = "0x1098388", VA = "0x1098388")]
		private void HandleRotationMovement()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x10987C8", Offset = "0x10987C8", VA = "0x10987C8")]
		public FreeLookCam()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class HandHeldCam : LookatTarget
	{
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SwaySpeed;

		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_BaseSwayAmount;

		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_TrackingSwayAmount;

		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x557638", Offset = "0x557638")]
		[SerializeField]
		private float m_TrackingBias;

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x10987F4", Offset = "0x10987F4", VA = "0x10987F4", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1098B68", Offset = "0x1098B68", VA = "0x1098B68")]
		public HandHeldCam()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class LookatTarget : AbstractTargetFollower
	{
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 m_RotationRange;

		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_FollowSpeed;

		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x48")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x58")]
		protected Vector3 m_FollowVelocity;

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1099ADC", Offset = "0x1099ADC", VA = "0x1099ADC", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1098930", Offset = "0x1098930", VA = "0x1098930", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1098B90", Offset = "0x1098B90", VA = "0x1098B90")]
		public LookatTarget()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x30")]
		protected Transform m_Cam;

		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x38")]
		protected Transform m_Pivot;

		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x40")]
		protected Vector3 m_LastTargetPosition;

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1098298", Offset = "0x1098298", VA = "0x1098298", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x109078C", Offset = "0x109078C", VA = "0x109078C")]
		protected PivotBasedCameraRig()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		[Token(Token = "0x200008A")]
		public class RayHitComparer : IComparer
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x1320C80", Offset = "0x1320C80", VA = "0x1320C80", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0x1315B34", Offset = "0x1315B34", VA = "0x1315B34")]
			public RayHitComparer()
			{
			}
		}

		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x18")]
		public float clipMoveTime;

		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x1C")]
		public float returnTime;

		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x20")]
		public float sphereCastRadius;

		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x24")]
		public bool visualiseInEditor;

		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x28")]
		public float closestDistance;

		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x557698", Offset = "0x557698")]
		private bool <protecting>k__BackingField;

		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x30")]
		public string dontClipTag;

		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x38")]
		private Transform m_Cam;

		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x40")]
		private Transform m_Pivot;

		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x48")]
		private float m_OriginalDist;

		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x4C")]
		private float m_MoveVelocity;

		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x50")]
		private float m_CurrentDist;

		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x54")]
		private Ray m_Ray;

		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x70")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x78")]
		private RayHitComparer m_RayHitComparer;

		[Token(Token = "0x1700004A")]
		public bool protecting
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x1315A14", Offset = "0x1315A14", VA = "0x1315A14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558478", Offset = "0x558478")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x1315A1C", Offset = "0x1315A1C", VA = "0x1315A1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x558488", Offset = "0x558488")]
			private set
			{
			}
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1315A28", Offset = "0x1315A28", VA = "0x1315A28")]
		private void Start()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1315B3C", Offset = "0x1315B3C", VA = "0x1315B3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x13160A4", Offset = "0x13160A4", VA = "0x13160A4")]
		public ProtectCameraFromWallClip()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class TargetFieldOfView : AbstractTargetFollower
	{
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_FovAdjustTime;

		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_ZoomAmountMultiplier;

		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_IncludeEffectsInSize;

		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x3C")]
		private float m_BoundSize;

		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x40")]
		private float m_FovAdjustVelocity;

		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x48")]
		private Camera m_Cam;

		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x50")]
		private Transform m_LastTarget;

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x131806C", Offset = "0x131806C", VA = "0x131806C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x13182C4", Offset = "0x13182C4", VA = "0x13182C4", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x13183B4", Offset = "0x13183B4", VA = "0x13183B4", Slot = "6")]
		public override void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x13180E4", Offset = "0x13180E4", VA = "0x13180E4")]
		public static float MaxBoundsExtent(Transform obj, bool includeEffects)
		{
			return default(float);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x13183F0", Offset = "0x13183F0", VA = "0x13183F0")]
		public TargetFieldOfView()
		{
		}
	}
}
namespace UnityStandardAssets._2D
{
	[Token(Token = "0x200008C")]
	public class Camera2DFollow : MonoBehaviour
	{
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x20")]
		public float damping;

		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x24")]
		public float lookAheadFactor;

		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x28")]
		public float lookAheadReturnSpeed;

		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x2C")]
		public float lookAheadMoveThreshold;

		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x30")]
		private float m_OffsetZ;

		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 m_LastTargetPosition;

		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 m_CurrentVelocity;

		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 m_LookAheadPos;

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1092344", Offset = "0x1092344", VA = "0x1092344")]
		private void Start()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x10923D0", Offset = "0x10923D0", VA = "0x10923D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x10925A8", Offset = "0x10925A8", VA = "0x10925A8")]
		public Camera2DFollow()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class CameraFollow : MonoBehaviour
	{
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x18")]
		public float xMargin;

		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x1C")]
		public float yMargin;

		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x20")]
		public float xSmooth;

		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x24")]
		public float ySmooth;

		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 maxXAndY;

		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 minXAndY;

		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x38")]
		private Transform m_Player;

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x10925BC", Offset = "0x10925BC", VA = "0x10925BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1092628", Offset = "0x1092628", VA = "0x1092628")]
		private bool CheckXMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1092688", Offset = "0x1092688", VA = "0x1092688")]
		private bool CheckYMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x10926E8", Offset = "0x10926E8", VA = "0x10926E8")]
		private void Update()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x10926EC", Offset = "0x10926EC", VA = "0x10926EC")]
		private void TrackPlayer()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x109287C", Offset = "0x109287C", VA = "0x109287C")]
		public CameraFollow()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x556854", Offset = "0x556854")]
	public class Platformer2DUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x18")]
		private PlatformerCharacter2D m_Character;

		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x20")]
		private bool m_Jump;

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x109C94C", Offset = "0x109C94C", VA = "0x109C94C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x109C9A8", Offset = "0x109C9A8", VA = "0x109C9A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x109CA30", Offset = "0x109CA30", VA = "0x109CA30")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x109CD60", Offset = "0x109CD60", VA = "0x109CD60")]
		public Platformer2DUserControl()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class PlatformerCharacter2D : MonoBehaviour
	{
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MaxSpeed;

		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_JumpForce;

		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5576F8", Offset = "0x5576F8")]
		[SerializeField]
		private float m_CrouchSpeed;

		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_AirControl;

		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask m_WhatIsGround;

		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x30")]
		private Transform m_GroundCheck;

		[Token(Token = "0x4000318")]
		private const float k_GroundedRadius = 0.2f;

		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x38")]
		private bool m_Grounded;

		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x40")]
		private Transform m_CeilingCheck;

		[Token(Token = "0x400031B")]
		private const float k_CeilingRadius = 0.01f;

		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x48")]
		private Animator m_Anim;

		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x50")]
		private Rigidbody2D m_Rigidbody2D;

		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x58")]
		private bool m_FacingRight;

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x109CD68", Offset = "0x109CD68", VA = "0x109CD68")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x109CE78", Offset = "0x109CE78", VA = "0x109CE78")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x109CAD8", Offset = "0x109CAD8", VA = "0x109CAD8")]
		public void Move(float move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x109D05C", Offset = "0x109D05C", VA = "0x109D05C")]
		private void Flip()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x109D0D8", Offset = "0x109D0D8", VA = "0x109D0D8")]
		public PlatformerCharacter2D()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class Restarter : MonoBehaviour
	{
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1316120", Offset = "0x1316120", VA = "0x1316120")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x13161E4", Offset = "0x13161E4", VA = "0x13161E4")]
		public Restarter()
		{
		}
	}
}
