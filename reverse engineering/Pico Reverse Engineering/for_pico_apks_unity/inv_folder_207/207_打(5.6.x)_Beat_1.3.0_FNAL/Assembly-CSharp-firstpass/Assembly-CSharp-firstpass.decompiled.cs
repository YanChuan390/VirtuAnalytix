using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityStandardAssets.Utility;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class MaterialModifier
{
	[Token(Token = "0x2000003")]
	public interface Interface
	{
		[Token(Token = "0x6000001")]
		void SetMaterialProp(int nameID, float value);

		[Token(Token = "0x6000002")]
		void SetMaterialProp(int nameID, Vector4 value);

		[Token(Token = "0x6000003")]
		void SetMaterialProp(int nameID, Color value);

		[Token(Token = "0x6000004")]
		void SetMaterialProp(int nameID, Matrix4x4 value);

		[Token(Token = "0x6000005")]
		void SetMaterialProp(int nameID, Texture value);
	}

	[Token(Token = "0x2000004")]
	public delegate void Callback(Interface owner);
}
[Token(Token = "0x2000005")]
public static class SRPHelper
{
	[Token(Token = "0x600000A")]
	[Address(RVA = "0xA2B4DC", Offset = "0xA2B4DC", VA = "0xA2B4DC")]
	public static bool IsUsingCustomRenderPipeline()
	{
		return default(bool);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xA2B5D4", Offset = "0xA2B5D4", VA = "0xA2B5D4")]
	public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xA2B658", Offset = "0xA2B658", VA = "0xA2B658")]
	public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
	{
	}
}
[Token(Token = "0x2000006")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	protected Image _image;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xA66FE0", Offset = "0xA66FE0", VA = "0xA66FE0")]
	public void Start()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xA671DC", Offset = "0xA671DC", VA = "0xA671DC", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xA674D4", Offset = "0xA674D4", VA = "0xA674D4")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000007")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000010")]
	[Address(RVA = "0xA73250", Offset = "0xA73250", VA = "0xA73250")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xA73364", Offset = "0xA73364", VA = "0xA73364")]
	public EventSystemChecker()
	{
	}
}
[Token(Token = "0x2000008")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x587D2C", Offset = "0x587D2C")]
public class ForcedReset : MonoBehaviour
{
	[Token(Token = "0x6000012")]
	[Address(RVA = "0xA74D1C", Offset = "0xA74D1C", VA = "0xA74D1C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xA74DE8", Offset = "0xA74DE8", VA = "0xA74DE8")]
	public ForcedReset()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000009")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x200000A")]
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

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xA6420C", Offset = "0xA6420C", VA = "0xA6420C")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xA646AC", Offset = "0xA646AC", VA = "0xA646AC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xA646B0", Offset = "0xA646B0", VA = "0xA646B0")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000C")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x6000019")]
			[Address(RVA = "0xBA8958", Offset = "0xBA8958", VA = "0xBA8958")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200000D")]
		public class ReplacementList
		{
			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x600001A")]
			[Address(RVA = "0xBA8960", Offset = "0xBA8960", VA = "0xBA8960")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xA6793C", Offset = "0xA6793C", VA = "0xA6793C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xA68418", Offset = "0xA68418", VA = "0xA68418")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000F")]
		public class Vector3andSpace
		{
			[Token(Token = "0x4000016")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x4000017")]
			[FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x600001E")]
			[Address(RVA = "0xBA89C8", Offset = "0xBA89C8", VA = "0xBA89C8")]
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

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xA68420", Offset = "0xA68420", VA = "0xA68420")]
		private void Start()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xA68448", Offset = "0xA68448", VA = "0xA68448")]
		private void Update()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xA68518", Offset = "0xA68518", VA = "0xA68518")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x2000010")]
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

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xA6C17C", Offset = "0xA6C17C", VA = "0xA6C17C")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xA6C1F0", Offset = "0xA6C1F0", VA = "0xA6C1F0")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xA6C1F8", Offset = "0xA6C1F8", VA = "0xA6C1F8")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xA6C200", Offset = "0xA6C200", VA = "0xA6C200")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xA6C2FC", Offset = "0xA6C2FC", VA = "0xA6C2FC")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
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

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xA700E8", Offset = "0xA700E8", VA = "0xA700E8")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xA7018C", Offset = "0xA7018C", VA = "0xA7018C")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xA70288", Offset = "0xA70288", VA = "0xA70288")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x2000013")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x587D8C", Offset = "0x587D8C")]
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
				[Token(Token = "0x600002E")]
				[Address(RVA = "0xBA90A4", Offset = "0xBA90A4", VA = "0xBA90A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000002")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000030")]
				[Address(RVA = "0xBA90EC", Offset = "0xBA90EC", VA = "0xBA90EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600002B")]
			[Address(RVA = "0xBA8E1C", Offset = "0xBA8E1C", VA = "0xBA8E1C")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600002C")]
			[Address(RVA = "0xBA8E48", Offset = "0xBA8E48", VA = "0xBA8E48", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600002D")]
			[Address(RVA = "0xBA8E4C", Offset = "0xBA8E4C", VA = "0xBA8E4C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600002F")]
			[Address(RVA = "0xBA90AC", Offset = "0xBA90AC", VA = "0xBA90AC", Slot = "8")]
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

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xA705D8", Offset = "0xA705D8", VA = "0xA705D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xA70A28", Offset = "0xA70A28", VA = "0xA70A28")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58A4AC", Offset = "0x58A4AC")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xA70970", Offset = "0xA70970", VA = "0xA70970")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xA70AB0", Offset = "0xA70AB0", VA = "0xA70AB0")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x2000014")]
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

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xA7302C", Offset = "0xA7302C", VA = "0xA7302C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xA73060", Offset = "0xA73060", VA = "0xA73060")]
		private void Update()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xA7321C", Offset = "0xA7321C", VA = "0xA7321C")]
		public DynamicShadowSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000015")]
	public class FOVKick
	{
		[Token(Token = "0x2000016")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x587D9C", Offset = "0x587D9C")]
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
				[Token(Token = "0x600003D")]
				[Address(RVA = "0xBAA4FC", Offset = "0xBAA4FC", VA = "0xBAA4FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000004")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600003F")]
				[Address(RVA = "0xBAA544", Offset = "0xBAA544", VA = "0xBAA544", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600003A")]
			[Address(RVA = "0xBAA390", Offset = "0xBAA390", VA = "0xBAA390")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600003B")]
			[Address(RVA = "0xBAA3BC", Offset = "0xBAA3BC", VA = "0xBAA3BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0xBAA3C0", Offset = "0xBAA3C0", VA = "0xBAA3C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0xBAA504", Offset = "0xBAA504", VA = "0xBAA504", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000017")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x587DAC", Offset = "0x587DAC")]
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
				[Token(Token = "0x6000043")]
				[Address(RVA = "0xBAA340", Offset = "0xBAA340", VA = "0xBAA340", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000006")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000045")]
				[Address(RVA = "0xBAA388", Offset = "0xBAA388", VA = "0xBAA388", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000040")]
			[Address(RVA = "0xBAA1C0", Offset = "0xBAA1C0", VA = "0xBAA1C0")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000041")]
			[Address(RVA = "0xBAA1EC", Offset = "0xBAA1EC", VA = "0xBAA1EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000042")]
			[Address(RVA = "0xBAA1F0", Offset = "0xBAA1F0", VA = "0xBAA1F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000044")]
			[Address(RVA = "0xBAA348", Offset = "0xBAA348", VA = "0xBAA348", Slot = "8")]
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

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xA737AC", Offset = "0xA737AC", VA = "0xA737AC")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xA737F8", Offset = "0xA737F8", VA = "0xA737F8")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xA738E4", Offset = "0xA738E4", VA = "0xA738E4")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xA738EC", Offset = "0xA738EC", VA = "0xA738EC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58A55C", Offset = "0x58A55C")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xA73964", Offset = "0xA73964", VA = "0xA73964")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58A5BC", Offset = "0x58A5BC")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xA739DC", Offset = "0xA739DC", VA = "0xA739DC")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x587DBC", Offset = "0x587DBC")]
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

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xA739F8", Offset = "0xA739F8", VA = "0xA739F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xA73A68", Offset = "0xA73A68", VA = "0xA73A68")]
		private void Update()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xA73B6C", Offset = "0xA73B6C", VA = "0xA73B6C")]
		public FPSCounter()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xA74CA4", Offset = "0xA74CA4", VA = "0xA74CA4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xA74D04", Offset = "0xA74D04", VA = "0xA74D04")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001A")]
	public class LerpControlledBob
	{
		[Token(Token = "0x200001B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x587E1C", Offset = "0x587E1C")]
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
				[Token(Token = "0x6000051")]
				[Address(RVA = "0xBAA720", Offset = "0xBAA720", VA = "0xBAA720", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000008")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000053")]
				[Address(RVA = "0xBAA768", Offset = "0xBAA768", VA = "0xBAA768", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0xBAA54C", Offset = "0xBAA54C", VA = "0xBAA54C")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600004F")]
			[Address(RVA = "0xBAA578", Offset = "0xBAA578", VA = "0xBAA578", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000050")]
			[Address(RVA = "0xBAA57C", Offset = "0xBAA57C", VA = "0xBAA57C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000052")]
			[Address(RVA = "0xBAA728", Offset = "0xBAA728", VA = "0xBAA728", Slot = "8")]
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

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xA24D04", Offset = "0xA24D04", VA = "0xA24D04")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xA23F9C", Offset = "0xA23F9C", VA = "0xA23F9C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58A6BC", Offset = "0x58A6BC")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xA240BC", Offset = "0xA240BC", VA = "0xA240BC")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x200001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x587E2C", Offset = "0x587E2C")]
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
				[Token(Token = "0x600005B")]
				[Address(RVA = "0xBAB130", Offset = "0xBAB130", VA = "0xBAB130", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600005D")]
				[Address(RVA = "0xBAB178", Offset = "0xBAB178", VA = "0xBAB178", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000058")]
			[Address(RVA = "0xBAAEB8", Offset = "0xBAAEB8", VA = "0xBAAEB8")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000059")]
			[Address(RVA = "0xBAAEE4", Offset = "0xBAAEE4", VA = "0xBAAEE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600005A")]
			[Address(RVA = "0xBAAEE8", Offset = "0xBAAEE8", VA = "0xBAAEE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600005C")]
			[Address(RVA = "0xBAB138", Offset = "0xBAB138", VA = "0xBAB138", Slot = "8")]
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

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xA2790C", Offset = "0xA2790C", VA = "0xA2790C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xA27A2C", Offset = "0xA27A2C", VA = "0xA27A2C")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xA27A58", Offset = "0xA27A58", VA = "0xA27A58")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58A76C", Offset = "0x58A76C")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xA27AE0", Offset = "0xA27AE0", VA = "0xA27AE0")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x200001F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x587E3C", Offset = "0x587E3C")]
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
				[Token(Token = "0x6000064")]
				[Address(RVA = "0xBAB510", Offset = "0xBAB510", VA = "0xBAB510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000066")]
				[Address(RVA = "0xBAB558", Offset = "0xBAB558", VA = "0xBAB558", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000061")]
			[Address(RVA = "0xBAB180", Offset = "0xBAB180", VA = "0xBAB180")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000062")]
			[Address(RVA = "0xBAB1AC", Offset = "0xBAB1AC", VA = "0xBAB1AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000063")]
			[Address(RVA = "0xBAB1B0", Offset = "0xBAB1B0", VA = "0xBAB1B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000065")]
			[Address(RVA = "0xBAB518", Offset = "0xBAB518", VA = "0xBAB518", Slot = "8")]
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

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xA27AE8", Offset = "0xA27AE8", VA = "0xA27AE8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58A81C", Offset = "0x58A81C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xA27B60", Offset = "0xA27B60", VA = "0xA27B60")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xA27B6C", Offset = "0xA27B6C", VA = "0xA27B6C")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x2000021")]
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

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xA2946C", Offset = "0xA2946C", VA = "0xA2946C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xA29470", Offset = "0xA29470", VA = "0xA29470")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xA2948C", Offset = "0xA2948C", VA = "0xA2948C")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xA2983C", Offset = "0xA2983C", VA = "0xA2983C")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x2000022")]
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

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xA2BC0C", Offset = "0xA2BC0C", VA = "0xA2BC0C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xA2BC78", Offset = "0xA2BC78", VA = "0xA2BC78")]
		public void NextCamera()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xA2BD50", Offset = "0xA2BD50", VA = "0xA2BD50")]
		public SimpleActivatorMenu()
		{
		}
	}
	[Token(Token = "0x2000023")]
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

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xA2BD58", Offset = "0xA2BD58", VA = "0xA2BD58")]
		private void Start()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xA2BD94", Offset = "0xA2BD94", VA = "0xA2BD94")]
		private void Update()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xA2C0EC", Offset = "0xA2C0EC", VA = "0xA2C0EC")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x2000024")]
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

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xA2C250", Offset = "0xA2C250", VA = "0xA2C250")]
		private void Start()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xA2C254", Offset = "0xA2C254", VA = "0xA2C254")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xA2C4FC", Offset = "0xA2C4FC", VA = "0xA2C4FC")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000026")]
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
		[Token(Token = "0x2000027")]
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

			[Token(Token = "0x6000079")]
			[Address(RVA = "0xBABEDC", Offset = "0xBABEDC", VA = "0xBABEDC")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000028")]
		public class Entries
		{
			[Token(Token = "0x4000090")]
			[FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x600007A")]
			[Address(RVA = "0xBABED4", Offset = "0xBABED4", VA = "0xBABED4")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000029")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x587E4C", Offset = "0x587E4C")]
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
				[Token(Token = "0x600007E")]
				[Address(RVA = "0xBABBA8", Offset = "0xBABBA8", VA = "0xBABBA8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000080")]
				[Address(RVA = "0xBABBF0", Offset = "0xBABBF0", VA = "0xBABBF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600007B")]
			[Address(RVA = "0xBABAA8", Offset = "0xBABAA8", VA = "0xBABAA8")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x600007C")]
			[Address(RVA = "0xBABAD4", Offset = "0xBABAD4", VA = "0xBABAD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600007D")]
			[Address(RVA = "0xBABAD8", Offset = "0xBABAD8", VA = "0xBABAD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600007F")]
			[Address(RVA = "0xBABBB0", Offset = "0xBABBB0", VA = "0xBABBB0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x587E5C", Offset = "0x587E5C")]
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
				[Token(Token = "0x6000084")]
				[Address(RVA = "0xBABCF8", Offset = "0xBABCF8", VA = "0xBABCF8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000010")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000086")]
				[Address(RVA = "0xBABD40", Offset = "0xBABD40", VA = "0xBABD40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000081")]
			[Address(RVA = "0xBABBF8", Offset = "0xBABBF8", VA = "0xBABBF8")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000082")]
			[Address(RVA = "0xBABC24", Offset = "0xBABC24", VA = "0xBABC24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000083")]
			[Address(RVA = "0xBABC28", Offset = "0xBABC28", VA = "0xBABC28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000085")]
			[Address(RVA = "0xBABD00", Offset = "0xBABD00", VA = "0xBABD00", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200002B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x587E6C", Offset = "0x587E6C")]
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
				[Token(Token = "0x600008A")]
				[Address(RVA = "0xBABE84", Offset = "0xBABE84", VA = "0xBABE84", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000012")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600008C")]
				[Address(RVA = "0xBABECC", Offset = "0xBABECC", VA = "0xBABECC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000087")]
			[Address(RVA = "0xBABD48", Offset = "0xBABD48", VA = "0xBABD48")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000088")]
			[Address(RVA = "0xBABD74", Offset = "0xBABD74", VA = "0xBABD74", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000089")]
			[Address(RVA = "0xBABD78", Offset = "0xBABD78", VA = "0xBABD78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600008B")]
			[Address(RVA = "0xBABE8C", Offset = "0xBABE8C", VA = "0xBABE8C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xA2E1D4", Offset = "0xA2E1D4", VA = "0xA2E1D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xA2E2FC", Offset = "0xA2E2FC", VA = "0xA2E2FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58A8CC", Offset = "0x58A8CC")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xA2E374", Offset = "0xA2E374", VA = "0xA2E374")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58A92C", Offset = "0x58A92C")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xA2E3EC", Offset = "0xA2E3EC", VA = "0xA2E3EC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58A98C", Offset = "0x58A98C")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xA2E464", Offset = "0xA2E464", VA = "0xA2E464")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x200002C")]
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

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xA2E4D4", Offset = "0xA2E4D4", VA = "0xA2E4D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xA2E528", Offset = "0xA2E528", VA = "0xA2E528")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xA2E5C4", Offset = "0xA2E5C4", VA = "0xA2E5C4")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200002E")]
		public class WaypointList
		{
			[Token(Token = "0x40000AC")]
			[FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x40000AD")]
			[FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x600009C")]
			[Address(RVA = "0xBA7B84", Offset = "0xBA7B84", VA = "0xBA7B84")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x200002F")]
		public struct RoutePoint
		{
			[Token(Token = "0x40000AE")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40000AF")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x600009D")]
			[Address(RVA = "0xBA775C", Offset = "0xBA775C", VA = "0xBA775C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x588E58", Offset = "0x588E58")]
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
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xBA70E8", Offset = "0xBA70E8", VA = "0xBA70E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AADC", Offset = "0x58AADC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0xBA70F0", Offset = "0xBA70F0", VA = "0xBA70F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AAEC", Offset = "0x58AAEC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0xBA70F8", Offset = "0xBA70F8", VA = "0xBA70F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xBA7114", Offset = "0xBA7114", VA = "0xBA7114")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xBA7444", Offset = "0xBA7444", VA = "0xBA7444")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xBA74D0", Offset = "0xBA74D0", VA = "0xBA74D0")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xBA776C", Offset = "0xBA776C", VA = "0xBA776C")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xBA7170", Offset = "0xBA7170", VA = "0xBA7170")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xBA7878", Offset = "0xBA7878", VA = "0xBA7878")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xBA7B00", Offset = "0xBA7B00", VA = "0xBA7B00")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xBA7880", Offset = "0xBA7880", VA = "0xBA7880")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xBA7B08", Offset = "0xBA7B08", VA = "0xBA7B08")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x2000031")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x588ED8", Offset = "0x588ED8")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x588EE8", Offset = "0x588EE8")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x588EF8", Offset = "0x588EF8")]
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
			[Token(Token = "0x600009E")]
			[Address(RVA = "0xBA7BEC", Offset = "0xBA7BEC", VA = "0xBA7BEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AAFC", Offset = "0x58AAFC")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600009F")]
			[Address(RVA = "0xBA7C00", Offset = "0xBA7C00", VA = "0xBA7C00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AB0C", Offset = "0x58AB0C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0xBA7C14", Offset = "0xBA7C14", VA = "0xBA7C14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AB1C", Offset = "0x58AB1C")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0xBA7C28", Offset = "0xBA7C28", VA = "0xBA7C28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AB2C", Offset = "0x58AB2C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0xBA7C3C", Offset = "0xBA7C3C", VA = "0xBA7C3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AB3C", Offset = "0x58AB3C")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0xBA7C50", Offset = "0xBA7C50", VA = "0xBA7C50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AB4C", Offset = "0x58AB4C")]
			private set
			{
			}
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xBA7C64", Offset = "0xBA7C64", VA = "0xBA7C64")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xBA7D6C", Offset = "0xBA7D6C", VA = "0xBA7D6C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xBA7E44", Offset = "0xBA7E44", VA = "0xBA7E44")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xBA8240", Offset = "0xBA8240", VA = "0xBA8240")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xBA8390", Offset = "0xBA8390", VA = "0xBA8390")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x587E7C", Offset = "0x587E7C")]
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

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xA66694", Offset = "0xA66694", VA = "0xA66694")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xA66738", Offset = "0xA66738", VA = "0xA66738")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xA66B44", Offset = "0xA66B44", VA = "0xA66B44")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xA66FCC", Offset = "0xA66FCC", VA = "0xA66FCC")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x2000034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x587EDC", Offset = "0x587EDC")]
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
				[Token(Token = "0x60000B3")]
				[Address(RVA = "0xBA9A50", Offset = "0xBA9A50", VA = "0xBA9A50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000019")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000B5")]
				[Address(RVA = "0xBA9A98", Offset = "0xBA9A98", VA = "0xBA9A98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0xBA94F8", Offset = "0xBA94F8", VA = "0xBA94F8")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60000B1")]
			[Address(RVA = "0xBA9524", Offset = "0xBA9524", VA = "0xBA9524", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000B2")]
			[Address(RVA = "0xBA9528", Offset = "0xBA9528", VA = "0xBA9528", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000B4")]
			[Address(RVA = "0xBA9A58", Offset = "0xBA9A58", VA = "0xBA9A58", Slot = "8")]
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

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xA7336C", Offset = "0xA7336C", VA = "0xA7336C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58AB5C", Offset = "0x58AB5C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xA733E4", Offset = "0xA733E4", VA = "0xA733E4")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xA73508", Offset = "0xA73508", VA = "0xA73508")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x2000036")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x587EEC", Offset = "0x587EEC")]
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
				[Token(Token = "0x60000BB")]
				[Address(RVA = "0xBA9E50", Offset = "0xBA9E50", VA = "0xBA9E50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000BD")]
				[Address(RVA = "0xBA9E98", Offset = "0xBA9E98", VA = "0xBA9E98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B8")]
			[Address(RVA = "0xBA9AA0", Offset = "0xBA9AA0", VA = "0xBA9AA0")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60000B9")]
			[Address(RVA = "0xBA9ACC", Offset = "0xBA9ACC", VA = "0xBA9ACC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0xBA9AD0", Offset = "0xBA9AD0", VA = "0xBA9AD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000BC")]
			[Address(RVA = "0xBA9E58", Offset = "0xBA9E58", VA = "0xBA9E58", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xA73510", Offset = "0xA73510", VA = "0xA73510")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58AC0C", Offset = "0x58AC0C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xA73588", Offset = "0xA73588", VA = "0xA73588")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x2000038")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x587EFC", Offset = "0x587EFC")]
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
				[Token(Token = "0x60000C5")]
				[Address(RVA = "0xBAA170", Offset = "0xBAA170", VA = "0xBAA170", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000C7")]
				[Address(RVA = "0xBAA1B8", Offset = "0xBAA1B8", VA = "0xBAA1B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C2")]
			[Address(RVA = "0xBA9EA0", Offset = "0xBA9EA0", VA = "0xBA9EA0")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xBA9ECC", Offset = "0xBA9ECC", VA = "0xBA9ECC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xBA9ED0", Offset = "0xBA9ED0", VA = "0xBA9ED0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xBAA178", Offset = "0xBAA178", VA = "0xBAA178", Slot = "8")]
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

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xA73598", Offset = "0xA73598", VA = "0xA73598")]
		private void Start()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xA735F4", Offset = "0xA735F4", VA = "0xA735F4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58ACBC", Offset = "0x58ACBC")]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xA73688", Offset = "0xA73688", VA = "0xA73688")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xA73690", Offset = "0xA73690", VA = "0xA73690")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xA736B4", Offset = "0xA736B4", VA = "0xA736B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xA73710", Offset = "0xA73710", VA = "0xA73710")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xA7379C", Offset = "0xA7379C", VA = "0xA7379C")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x200003A")]
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

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xA73C48", Offset = "0xA73C48", VA = "0xA73C48")]
		private void Start()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xA73CBC", Offset = "0xA73CBC", VA = "0xA73CBC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xA73E78", Offset = "0xA73E78", VA = "0xA73E78")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xA73EA0", Offset = "0xA73EA0", VA = "0xA73EA0")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x200003B")]
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

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xA240CC", Offset = "0xA240CC", VA = "0xA240CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xA24248", Offset = "0xA24248", VA = "0xA24248")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xA27B80", Offset = "0xA27B80", VA = "0xA27B80")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xA27CE0", Offset = "0xA27CE0", VA = "0xA27CE0")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xA2C18C", Offset = "0xA2C18C", VA = "0xA2C18C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xA2C248", Offset = "0xA2C248", VA = "0xA2C248")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x200003E")]
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

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xBA6A8C", Offset = "0xBA6A8C", VA = "0xBA6A8C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xBA6AE8", Offset = "0xBA6AE8", VA = "0xBA6AE8")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xBA6D5C", Offset = "0xBA6D5C", VA = "0xBA6D5C")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x200003F")]
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xBA6858", Offset = "0xBA6858", VA = "0xBA6858")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xBA6A84", Offset = "0xBA6A84", VA = "0xBA6A84")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x587F1C", Offset = "0x587F1C")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xA704DC", Offset = "0xA704DC", VA = "0xA704DC")]
		public void Awake()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xA70500", Offset = "0xA70500", VA = "0xA70500")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xA70568", Offset = "0xA70568", VA = "0xA70568")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xA705D0", Offset = "0xA705D0", VA = "0xA705D0")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x587F8C", Offset = "0x587F8C")]
	[ExecuteInEditMode]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xA2281C", Offset = "0xA2281C", VA = "0xA2281C")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000042")]
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

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xA25AC4", Offset = "0xA25AC4", VA = "0xA25AC4")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xA25B38", Offset = "0xA25B38", VA = "0xA25B38")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x587FFC", Offset = "0x587FFC")]
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

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xA27CF0", Offset = "0xA27CF0", VA = "0xA27CF0")]
		public void Start()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xA27DF8", Offset = "0xA27DF8", VA = "0xA27DF8")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xA28150", Offset = "0xA28150", VA = "0xA28150")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xA28200", Offset = "0xA28200", VA = "0xA28200")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xA282DC", Offset = "0xA282DC", VA = "0xA282DC")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xA28BA8", Offset = "0xA28BA8", VA = "0xA28BA8")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xA28C04", Offset = "0xA28C04", VA = "0xA28C04")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xA28CF8", Offset = "0xA28CF8", VA = "0xA28CF8")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xA28D60", Offset = "0xA28D60", VA = "0xA28D60")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xA284A0", Offset = "0xA284A0", VA = "0xA284A0")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xA28DC8", Offset = "0xA28DC8", VA = "0xA28DC8")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xA29210", Offset = "0xA29210", VA = "0xA29210")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xA28E2C", Offset = "0xA28E2C", VA = "0xA28E2C")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xA293D4", Offset = "0xA293D4", VA = "0xA293D4")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xA290E4", Offset = "0xA290E4", VA = "0xA290E4")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xA293F4", Offset = "0xA293F4", VA = "0xA293F4")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58806C", Offset = "0x58806C")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xA2C510", Offset = "0xA2C510", VA = "0xA2C510")]
		public void Start()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xA2C620", Offset = "0xA2C620", VA = "0xA2C620")]
		public void Update()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xA2C848", Offset = "0xA2C848", VA = "0xA2C848")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x2000046")]
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

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xA32F84", Offset = "0xA32F84", VA = "0xA32F84")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xA34A9C", Offset = "0xA34A9C", VA = "0xA34A9C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xA34E34", Offset = "0xA34E34", VA = "0xA34E34")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xA34468", Offset = "0xA34468", VA = "0xA34468")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xA33ABC", Offset = "0xA33ABC", VA = "0xA33ABC")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xA33AA8", Offset = "0xA33AA8", VA = "0xA33AA8")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xA33934", Offset = "0xA33934", VA = "0xA33934")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xA34970", Offset = "0xA34970", VA = "0xA34970")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xA346CC", Offset = "0xA346CC", VA = "0xA346CC")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xA35104", Offset = "0xA35104", VA = "0xA35104")]
		public Water()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public enum WaterQuality
	{
		[Token(Token = "0x4000111")]
		High = 2,
		[Token(Token = "0x4000112")]
		Medium = 1,
		[Token(Token = "0x4000113")]
		Low = 0
	}
	[Token(Token = "0x2000048")]
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

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xBA657C", Offset = "0xBA657C", VA = "0xBA657C")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xBA6710", Offset = "0xBA6710", VA = "0xBA6710")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xBA67C0", Offset = "0xBA67C0", VA = "0xBA67C0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xBA6840", Offset = "0xBA6840", VA = "0xBA6840")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xBA6DE8", Offset = "0xBA6DE8", VA = "0xBA6DE8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xBA6DEC", Offset = "0xBA6DEC", VA = "0xBA6DEC")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xBA6FD0", Offset = "0xBA6FD0", VA = "0xBA6FD0")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xBA70E0", Offset = "0xBA70E0", VA = "0xBA70E0")]
		public WaterTile()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200004A")]
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

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xA68520", Offset = "0xA68520", VA = "0xA68520")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xA6879C", Offset = "0xA6879C", VA = "0xA6879C")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xA6894C", Offset = "0xA6894C", VA = "0xA6894C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xA68968", Offset = "0xA68968", VA = "0xA68968", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xA68A28", Offset = "0xA68A28", VA = "0xA68A28", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xA68A7C", Offset = "0xA68A7C", VA = "0xA68A7C")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xA6B7C0", Offset = "0xA6B7C0", VA = "0xA6B7C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xA6B7C4", Offset = "0xA6B7C4", VA = "0xA6B7C4")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xA6B8A4", Offset = "0xA6B8A4", VA = "0xA6B8A4")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xA6B984", Offset = "0xA6B984", VA = "0xA6B984")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xA6BA64", Offset = "0xA6BA64", VA = "0xA6BA64")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xA6BB44", Offset = "0xA6BB44", VA = "0xA6BB44")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xA6BC24", Offset = "0xA6BC24", VA = "0xA6BC24")]
		public void Update()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xA6BC28", Offset = "0xA6BC28", VA = "0xA6BC28")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200004D")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x4000124")]
			Hardware,
			[Token(Token = "0x4000125")]
			Touch
		}

		[Token(Token = "0x200004E")]
		public class VirtualAxis
		{
			[Token(Token = "0x4000126")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x588F08", Offset = "0x588F08")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000127")]
			[FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x4000128")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x588F18", Offset = "0x588F18")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x1700001F")]
			public string name
			{
				[Token(Token = "0x600012D")]
				[Address(RVA = "0xBA8AF4", Offset = "0xBA8AF4", VA = "0xBA8AF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AD6C", Offset = "0x58AD6C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600012E")]
				[Address(RVA = "0xBA8AFC", Offset = "0xBA8AFC", VA = "0xBA8AFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AD7C", Offset = "0x58AD7C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000020")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600012F")]
				[Address(RVA = "0xBA8B04", Offset = "0xBA8B04", VA = "0xBA8B04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AD8C", Offset = "0x58AD8C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000130")]
				[Address(RVA = "0xBA8B0C", Offset = "0xBA8B0C", VA = "0xBA8B0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AD9C", Offset = "0x58AD9C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000021")]
			public float GetValue
			{
				[Token(Token = "0x6000135")]
				[Address(RVA = "0xBA8C14", Offset = "0xBA8C14", VA = "0xBA8C14")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000022")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000136")]
				[Address(RVA = "0xBA8C1C", Offset = "0xBA8C1C", VA = "0xBA8C1C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000131")]
			[Address(RVA = "0xBA8B18", Offset = "0xBA8B18", VA = "0xBA8B18")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000132")]
			[Address(RVA = "0xBA8B58", Offset = "0xBA8B58", VA = "0xBA8B58")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000133")]
			[Address(RVA = "0xBA8BA4", Offset = "0xBA8BA4", VA = "0xBA8BA4")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000134")]
			[Address(RVA = "0xBA8C0C", Offset = "0xBA8C0C", VA = "0xBA8C0C")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x200004F")]
		public class VirtualButton
		{
			[Token(Token = "0x4000129")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x588F28", Offset = "0x588F28")]
			private string <name>k__BackingField;

			[Token(Token = "0x400012A")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x588F38", Offset = "0x588F38")]
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
				[Token(Token = "0x6000137")]
				[Address(RVA = "0xBA8C24", Offset = "0xBA8C24", VA = "0xBA8C24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58ADAC", Offset = "0x58ADAC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000138")]
				[Address(RVA = "0xBA8C2C", Offset = "0xBA8C2C", VA = "0xBA8C2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58ADBC", Offset = "0x58ADBC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000139")]
				[Address(RVA = "0xBA8C34", Offset = "0xBA8C34", VA = "0xBA8C34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58ADCC", Offset = "0x58ADCC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600013A")]
				[Address(RVA = "0xBA8C3C", Offset = "0xBA8C3C", VA = "0xBA8C3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58ADDC", Offset = "0x58ADDC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public bool GetButton
			{
				[Token(Token = "0x6000140")]
				[Address(RVA = "0xBA8DB4", Offset = "0xBA8DB4", VA = "0xBA8DB4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000026")]
			public bool GetButtonDown
			{
				[Token(Token = "0x6000141")]
				[Address(RVA = "0xBA8DBC", Offset = "0xBA8DBC", VA = "0xBA8DBC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000027")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000142")]
				[Address(RVA = "0xBA8DEC", Offset = "0xBA8DEC", VA = "0xBA8DEC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600013B")]
			[Address(RVA = "0xBA8C48", Offset = "0xBA8C48", VA = "0xBA8C48")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x600013C")]
			[Address(RVA = "0xBA8C90", Offset = "0xBA8C90", VA = "0xBA8C90")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600013D")]
			[Address(RVA = "0xBA8CE4", Offset = "0xBA8CE4", VA = "0xBA8CE4")]
			public void Pressed()
			{
			}

			[Token(Token = "0x600013E")]
			[Address(RVA = "0xBA8D20", Offset = "0xBA8D20", VA = "0xBA8D20")]
			public void Released()
			{
			}

			[Token(Token = "0x600013F")]
			[Address(RVA = "0xBA8D4C", Offset = "0xBA8D4C", VA = "0xBA8D4C")]
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
			[Token(Token = "0x6000129")]
			[Address(RVA = "0xA6FEF0", Offset = "0xA6FEF0", VA = "0xA6FEF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xA6F8D0", Offset = "0xA6F8D0", VA = "0xA6F8D0")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xA6F998", Offset = "0xA6F998", VA = "0xA6F998")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xA68634", Offset = "0xA68634", VA = "0xA68634")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xA6FA4C", Offset = "0xA6FA4C", VA = "0xA6FA4C")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xA686AC", Offset = "0xA686AC", VA = "0xA686AC")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xA6FAC4", Offset = "0xA6FAC4", VA = "0xA6FAC4")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xA6FB3C", Offset = "0xA6FB3C", VA = "0xA6FB3C")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xA6FC00", Offset = "0xA6FC00", VA = "0xA6FC00")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xA68724", Offset = "0xA68724", VA = "0xA68724")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xA66264", Offset = "0xA66264", VA = "0xA66264")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xA6FD04", Offset = "0xA6FD04", VA = "0xA6FD04")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xA6FC78", Offset = "0xA6FC78", VA = "0xA6FC78")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xA662C8", Offset = "0xA662C8", VA = "0xA662C8")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xA6FD68", Offset = "0xA6FD68", VA = "0xA6FD68")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xA6FDE4", Offset = "0xA6FDE4", VA = "0xA6FDE4")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xA6B828", Offset = "0xA6B828", VA = "0xA6B828")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xA6B908", Offset = "0xA6B908", VA = "0xA6B908")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xA6B9E8", Offset = "0xA6B9E8", VA = "0xA6B9E8")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xA6BBA8", Offset = "0xA6BBA8", VA = "0xA6BBA8")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xA6BAC8", Offset = "0xA6BAC8", VA = "0xA6BAC8")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xA6FE60", Offset = "0xA6FE60", VA = "0xA6FE60")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xA6FF68", Offset = "0xA6FF68", VA = "0xA6FF68")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xA6FFE8", Offset = "0xA6FFE8", VA = "0xA6FFE8")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xA70068", Offset = "0xA70068", VA = "0xA70068")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xA24264", Offset = "0xA24264", VA = "0xA24264")]
		private void Update()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xA24268", Offset = "0xA24268", VA = "0xA24268")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xA242E8", Offset = "0xA242E8", VA = "0xA242E8")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000052")]
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

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xA246F4", Offset = "0xA246F4", VA = "0xA246F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xA24854", Offset = "0xA24854", VA = "0xA24854")]
		private void Start()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xA24890", Offset = "0xA24890", VA = "0xA24890")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xA246F8", Offset = "0xA246F8", VA = "0xA246F8")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xA248F4", Offset = "0xA248F4", VA = "0xA248F4", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xA24A18", Offset = "0xA24A18", VA = "0xA24A18", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xA24A60", Offset = "0xA24A60", VA = "0xA24A60", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xA24A64", Offset = "0xA24A64", VA = "0xA24A64")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xA24ABC", Offset = "0xA24ABC", VA = "0xA24ABC")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0xA25E08", Offset = "0xA25E08", VA = "0xA25E08")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xA25E18", Offset = "0xA25E18", VA = "0xA25E18")]
		private void Start()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xA25E10", Offset = "0xA25E10", VA = "0xA25E10")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xA25F2C", Offset = "0xA25F2C", VA = "0xA25F2C")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xA261E8", Offset = "0xA261E8", VA = "0xA261E8")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000055")]
		public enum AxisOptions
		{
			[Token(Token = "0x4000142")]
			ForwardAxis,
			[Token(Token = "0x4000143")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x2000056")]
		public class AxisMapping
		{
			[Token(Token = "0x2000057")]
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

			[Token(Token = "0x6000158")]
			[Address(RVA = "0xBABAA0", Offset = "0xBABAA0", VA = "0xBABAA0")]
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

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xA2DEAC", Offset = "0xA2DEAC", VA = "0xA2DEAC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xA2DF80", Offset = "0xA2DF80", VA = "0xA2DF80")]
		private void Update()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xA2E1A8", Offset = "0xA2E1A8", VA = "0xA2E1A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xA2E1C4", Offset = "0xA2E1C4", VA = "0xA2E1C4")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58811C", Offset = "0x58811C")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000059")]
		public enum AxisOption
		{
			[Token(Token = "0x400015E")]
			Both,
			[Token(Token = "0x400015F")]
			OnlyHorizontal,
			[Token(Token = "0x4000160")]
			OnlyVertical
		}

		[Token(Token = "0x200005A")]
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

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xA2E5D4", Offset = "0xA2E5D4", VA = "0xA2E5D4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xA2E734", Offset = "0xA2E734", VA = "0xA2E734")]
		private void Start()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xA2E5D8", Offset = "0xA2E5D8", VA = "0xA2E5D8")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xA2E7BC", Offset = "0xA2E7BC", VA = "0xA2E7BC")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xA2E828", Offset = "0xA2E828", VA = "0xA2E828", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xA2E860", Offset = "0xA2E860", VA = "0xA2E860")]
		private void Update()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xA2E9A8", Offset = "0xA2E9A8", VA = "0xA2E9A8", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xA2E9DC", Offset = "0xA2E9DC", VA = "0xA2E9DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xA2EADC", Offset = "0xA2EADC", VA = "0xA2EADC")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x588F48", Offset = "0x588F48")]
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
			[Token(Token = "0x6000162")]
			[Address(RVA = "0xA2FACC", Offset = "0xA2FACC", VA = "0xA2FACC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58ADEC", Offset = "0x58ADEC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0xA2FAD8", Offset = "0xA2FAD8", VA = "0xA2FAD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58ADFC", Offset = "0x58ADFC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xA2FAE4", Offset = "0xA2FAE4", VA = "0xA2FAE4")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xA2FB48", Offset = "0xA2FB48", VA = "0xA2FB48")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xA2FBAC", Offset = "0xA2FBAC", VA = "0xA2FBAC")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xA2FD0C", Offset = "0xA2FD0C", VA = "0xA2FD0C")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xA2FE6C", Offset = "0xA2FE6C", VA = "0xA2FE6C")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xA2FF0C", Offset = "0xA2FF0C", VA = "0xA2FF0C")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xA2FFAC", Offset = "0xA2FFAC", VA = "0xA2FFAC")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xA30048", Offset = "0xA30048", VA = "0xA30048")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xA30050", Offset = "0xA30050", VA = "0xA30050")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xA30058", Offset = "0xA30058", VA = "0xA30058")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x600016E")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x600016F")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x6000170")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x6000171")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x6000172")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000173")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000174")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000175")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x6000176")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000177")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000178")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xA2699C", Offset = "0xA2699C", VA = "0xA2699C")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x200005C")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x600017A")]
		[Address(RVA = "0xA261F0", Offset = "0xA261F0", VA = "0xA261F0")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xA26280", Offset = "0xA26280", VA = "0xA26280")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xA26310", Offset = "0xA26310", VA = "0xA26310", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xA263B4", Offset = "0xA263B4", VA = "0xA263B4", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xA26458", Offset = "0xA26458", VA = "0xA26458", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xA264FC", Offset = "0xA264FC", VA = "0xA264FC", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xA265A4", Offset = "0xA265A4", VA = "0xA265A4", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xA2664C", Offset = "0xA2664C", VA = "0xA2664C", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xA266F0", Offset = "0xA266F0", VA = "0xA266F0", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xA267A0", Offset = "0xA267A0", VA = "0xA267A0", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xA26844", Offset = "0xA26844", VA = "0xA26844", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xA268E8", Offset = "0xA268E8", VA = "0xA268E8", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xA2698C", Offset = "0xA2698C", VA = "0xA2698C", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xA26998", Offset = "0xA26998", VA = "0xA26998")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000188")]
		[Address(RVA = "0xA2C850", Offset = "0xA2C850", VA = "0xA2C850", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xA2C864", Offset = "0xA2C864", VA = "0xA2C864", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xA2C870", Offset = "0xA2C870", VA = "0xA2C870", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xA2C87C", Offset = "0xA2C87C", VA = "0xA2C87C", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xA2C888", Offset = "0xA2C888", VA = "0xA2C888", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xA2C8DC", Offset = "0xA2C8DC", VA = "0xA2C8DC", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xA2C930", Offset = "0xA2C930", VA = "0xA2C930", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xA2C984", Offset = "0xA2C984", VA = "0xA2C984", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xA2C9D8", Offset = "0xA2C9D8", VA = "0xA2C9D8", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xA2CA2C", Offset = "0xA2CA2C", VA = "0xA2CA2C", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xA2CA80", Offset = "0xA2CA80", VA = "0xA2CA80", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xA2CA88", Offset = "0xA2CA88", VA = "0xA2CA88")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Car
{
	[Token(Token = "0x200005E")]
	public class BrakeLight : MonoBehaviour
	{
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x18")]
		public CarController car;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x20")]
		private Renderer m_Renderer;

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xA6B728", Offset = "0xA6B728", VA = "0xA6B728")]
		private void Start()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xA6B784", Offset = "0xA6B784", VA = "0xA6B784")]
		private void Update()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xA6B7B8", Offset = "0xA6B7B8", VA = "0xA6B7B8")]
		public BrakeLight()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58817C", Offset = "0x58817C")]
	public class CarAIControl : MonoBehaviour
	{
		[Token(Token = "0x2000060")]
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
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x588F58", Offset = "0x588F58")]
		private float m_CautiousSpeedFactor;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x588F98", Offset = "0x588F98")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58904C", Offset = "0x58904C")]
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

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xA6C45C", Offset = "0xA6C45C", VA = "0xA6C45C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xA6C500", Offset = "0xA6C500", VA = "0xA6C500")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xA6CCB8", Offset = "0xA6CCB8", VA = "0xA6CCB8")]
		private void OnCollisionStay(Collision col)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xA6CED4", Offset = "0xA6CED4", VA = "0xA6CED4")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xA6CF04", Offset = "0xA6CF04", VA = "0xA6CF04")]
		public CarAIControl()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5881DC", Offset = "0x5881DC")]
	public class CarAudio : MonoBehaviour
	{
		[Token(Token = "0x2000062")]
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

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xA6CF4C", Offset = "0xA6CF4C", VA = "0xA6CF4C")]
		private void StartSound()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xA6D13C", Offset = "0xA6D13C", VA = "0xA6D13C")]
		private void StopSound()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xA6D224", Offset = "0xA6D224", VA = "0xA6D224")]
		private void Update()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xA6D030", Offset = "0xA6D030", VA = "0xA6D030")]
		private AudioSource SetUpEngineAudioSource(AudioClip clip)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xA6D56C", Offset = "0xA6D56C", VA = "0xA6D56C")]
		private static float ULerp(float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xA6D584", Offset = "0xA6D584", VA = "0xA6D584")]
		public CarAudio()
		{
		}
	}
	[Token(Token = "0x2000063")]
	internal enum CarDriveType
	{
		[Token(Token = "0x400019B")]
		FrontWheelDrive,
		[Token(Token = "0x400019C")]
		RearWheelDrive,
		[Token(Token = "0x400019D")]
		FourWheelDrive
	}
	[Token(Token = "0x2000064")]
	internal enum SpeedType
	{
		[Token(Token = "0x400019F")]
		MPH,
		[Token(Token = "0x40001A0")]
		KPH
	}
	[Token(Token = "0x2000065")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58914C", Offset = "0x58914C")]
		[SerializeField]
		private float m_SteerHelper;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58918C", Offset = "0x58918C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58926C", Offset = "0x58926C")]
		private bool <Skidding>k__BackingField;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58927C", Offset = "0x58927C")]
		private float <BrakeInput>k__BackingField;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58928C", Offset = "0x58928C")]
		private float <Revs>k__BackingField;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58929C", Offset = "0x58929C")]
		private float <AccelInput>k__BackingField;

		[Token(Token = "0x17000029")]
		public bool Skidding
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0xA6D5B0", Offset = "0xA6D5B0", VA = "0xA6D5B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AE0C", Offset = "0x58AE0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0xA6D5B8", Offset = "0xA6D5B8", VA = "0xA6D5B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AE1C", Offset = "0x58AE1C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public float BrakeInput
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0xA6D5C4", Offset = "0xA6D5C4", VA = "0xA6D5C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AE2C", Offset = "0x58AE2C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0xA6D5CC", Offset = "0xA6D5CC", VA = "0xA6D5CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AE3C", Offset = "0x58AE3C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public float CurrentSteerAngle
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0xA6D5D4", Offset = "0xA6D5D4", VA = "0xA6D5D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002C")]
		public float CurrentSpeed
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0xA6CC64", Offset = "0xA6CC64", VA = "0xA6CC64")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public float MaxSpeed
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0xA6D5DC", Offset = "0xA6D5DC", VA = "0xA6D5DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002E")]
		public float Revs
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xA6D5E4", Offset = "0xA6D5E4", VA = "0xA6D5E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AE4C", Offset = "0x58AE4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0xA6D5EC", Offset = "0xA6D5EC", VA = "0xA6D5EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AE5C", Offset = "0x58AE5C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public float AccelInput
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0xA6D5F4", Offset = "0xA6D5F4", VA = "0xA6D5F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AE6C", Offset = "0x58AE6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0xA6D5FC", Offset = "0xA6D5FC", VA = "0xA6D5FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AE7C", Offset = "0x58AE7C")]
			private set
			{
			}
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xA6D604", Offset = "0xA6D604", VA = "0xA6D604")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xA6D768", Offset = "0xA6D768", VA = "0xA6D768")]
		private void GearChanging()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xA6D878", Offset = "0xA6D878", VA = "0xA6D878")]
		private static float CurveFactor(float factor)
		{
			return default(float);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xA6D88C", Offset = "0xA6D88C", VA = "0xA6D88C")]
		private static float ULerp(float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xA6D8A4", Offset = "0xA6D8A4", VA = "0xA6D8A4")]
		private void CalculateGearFactor()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xA6D984", Offset = "0xA6D984", VA = "0xA6D984")]
		private void CalculateRevs()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xA6C9D4", Offset = "0xA6C9D4", VA = "0xA6C9D4")]
		public void Move(float steering, float accel, float footbrake, float handbrake)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xA6DE88", Offset = "0xA6DE88", VA = "0xA6DE88")]
		private void CapSpeed()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xA6DC1C", Offset = "0xA6DC1C", VA = "0xA6DC1C")]
		private void ApplyDrive(float accel, float footbrake)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xA6DA54", Offset = "0xA6DA54", VA = "0xA6DA54")]
		private void SteerHelper()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xA6DF5C", Offset = "0xA6DF5C", VA = "0xA6DF5C")]
		private void AddDownForce()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xA6E060", Offset = "0xA6E060", VA = "0xA6E060")]
		private void CheckForWheelSpin()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xA6E1CC", Offset = "0xA6E1CC", VA = "0xA6E1CC")]
		private void TractionControl()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xA6E4A0", Offset = "0xA6E4A0", VA = "0xA6E4A0")]
		private void AdjustTorque(float forwardSlip)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xA6E434", Offset = "0xA6E434", VA = "0xA6E434")]
		private bool AnySkidSoundPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xA6E4E8", Offset = "0xA6E4E8", VA = "0xA6E4E8")]
		public CarController()
		{
		}
	}
	[Token(Token = "0x2000066")]
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

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xA6E61C", Offset = "0xA6E61C", VA = "0xA6E61C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xA6E678", Offset = "0xA6E678", VA = "0xA6E678")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xA6E724", Offset = "0xA6E724", VA = "0xA6E724")]
		private void RightCar()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xA6E7D4", Offset = "0xA6E7D4", VA = "0xA6E7D4")]
		public CarSelfRighting()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58823C", Offset = "0x58823C")]
	public class CarUserControl : MonoBehaviour
	{
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x18")]
		private CarController m_Car;

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xA6E7E8", Offset = "0xA6E7E8", VA = "0xA6E7E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xA6E844", Offset = "0xA6E844", VA = "0xA6E844")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xA6E900", Offset = "0xA6E900", VA = "0xA6E900")]
		public CarUserControl()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class Mudguard : MonoBehaviour
	{
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x18")]
		public CarController carController;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x20")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xA26F40", Offset = "0xA26F40", VA = "0xA26F40")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xA26F7C", Offset = "0xA26F7C", VA = "0xA26F7C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xA27010", Offset = "0xA27010", VA = "0xA27010")]
		public Mudguard()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class SkidTrail : MonoBehaviour
	{
		[Token(Token = "0x200006A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58829C", Offset = "0x58829C")]
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
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0xBABA50", Offset = "0xBABA50", VA = "0xBABA50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000031")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0xBABA98", Offset = "0xBABA98", VA = "0xBABA98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xBAB8E4", Offset = "0xBAB8E4", VA = "0xBAB8E4")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60001CB")]
			[Address(RVA = "0xBAB910", Offset = "0xBAB910", VA = "0xBAB910", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xBAB914", Offset = "0xBAB914", VA = "0xBAB914", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001CE")]
			[Address(RVA = "0xBABA58", Offset = "0xBABA58", VA = "0xBABA58", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_PersistTime;

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xA2C10C", Offset = "0xA2C10C", VA = "0xA2C10C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58AE8C", Offset = "0x58AE8C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xA2C184", Offset = "0xA2C184", VA = "0xA2C184")]
		public SkidTrail()
		{
		}
	}
	[Token(Token = "0x200006B")]
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

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xA2CA8C", Offset = "0xA2CA8C", VA = "0xA2CA8C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xA2CAF0", Offset = "0xA2CAF0", VA = "0xA2CAF0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xA2CB80", Offset = "0xA2CB80", VA = "0xA2CB80")]
		public Suspension()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5882AC", Offset = "0x5882AC")]
	public class WheelEffects : MonoBehaviour
	{
		[Token(Token = "0x200006D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58830C", Offset = "0x58830C")]
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
				[Token(Token = "0x60001E1")]
				[Address(RVA = "0xBAC7BC", Offset = "0xBAC7BC", VA = "0xBAC7BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000035")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001E3")]
				[Address(RVA = "0xBAC804", Offset = "0xBAC804", VA = "0xBAC804", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xBA8834", Offset = "0xBA8834", VA = "0xBA8834")]
			[DebuggerHidden]
			public <StartSkidTrail>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x60001DF")]
			[Address(RVA = "0xBAC610", Offset = "0xBAC610", VA = "0xBAC610", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xBAC614", Offset = "0xBAC614", VA = "0xBAC614", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xBAC7C4", Offset = "0xBAC7C4", VA = "0xBAC7C4", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5892DC", Offset = "0x5892DC")]
		private bool <skidding>k__BackingField;

		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5892EC", Offset = "0x5892EC")]
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
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0xBA83AC", Offset = "0xBA83AC", VA = "0xBA83AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AF3C", Offset = "0x58AF3C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0xBA83B4", Offset = "0xBA83B4", VA = "0xBA83B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AF4C", Offset = "0x58AF4C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public bool PlayingAudio
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0xBA83C0", Offset = "0xBA83C0", VA = "0xBA83C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AF5C", Offset = "0x58AF5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0xBA83C8", Offset = "0xBA83C8", VA = "0xBA83C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58AF6C", Offset = "0x58AF6C")]
			private set
			{
			}
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xBA83D4", Offset = "0xBA83D4", VA = "0xBA83D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xBA863C", Offset = "0xBA863C", VA = "0xBA863C")]
		public void EmitTyreSmoke()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xBA87C8", Offset = "0xBA87C8", VA = "0xBA87C8")]
		public void PlayAudio()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xBA8800", Offset = "0xBA8800", VA = "0xBA8800")]
		public void StopAudio()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xBA8750", Offset = "0xBA8750", VA = "0xBA8750")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58AF7C", Offset = "0x58AF7C")]
		public IEnumerator StartSkidTrail()
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xBA8860", Offset = "0xBA8860", VA = "0xBA8860")]
		public void EndSkidTrail()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xBA892C", Offset = "0xBA892C", VA = "0xBA892C")]
		public WheelEffects()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Aeroplane
{
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58831C", Offset = "0x58831C")]
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

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xA646C8", Offset = "0xA646C8", VA = "0xA646C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xA64740", Offset = "0xA64740", VA = "0xA64740")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xA64748", Offset = "0xA64748", VA = "0xA64748")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xA64A04", Offset = "0xA64A04", VA = "0xA64A04")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xA64A0C", Offset = "0xA64A0C", VA = "0xA64A0C")]
		public AeroplaneAiControl()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class AeroplaneAudio : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000070")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58941C", Offset = "0x58941C")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x589434", Offset = "0x589434")]
			public float windMasterVolume;

			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xBA8934", Offset = "0xBA8934", VA = "0xBA8934")]
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

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xA64A2C", Offset = "0xA64A2C", VA = "0xA64A2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xA64C78", Offset = "0xA64C78", VA = "0xA64C78")]
		private void Update()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xA64DEC", Offset = "0xA64DEC", VA = "0xA64DEC")]
		public AeroplaneAudio()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class AeroplaneControlSurfaceAnimator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000072")]
		public class ControlSurface
		{
			[Token(Token = "0x2000073")]
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

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xBA8950", Offset = "0xBA8950", VA = "0xBA8950")]
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

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xA64E88", Offset = "0xA64E88", VA = "0xA64E88")]
		private void Start()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xA64F54", Offset = "0xA64F54", VA = "0xA64F54")]
		private void Update()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xA6508C", Offset = "0xA6508C", VA = "0xA6508C")]
		private void RotateSurface(ControlSurface surface, Quaternion rotation)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xA65174", Offset = "0xA65174", VA = "0xA65174")]
		public AeroplaneControlSurfaceAnimator()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58837C", Offset = "0x58837C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58955C", Offset = "0x58955C")]
		private float <Altitude>k__BackingField;

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58956C", Offset = "0x58956C")]
		private float <Throttle>k__BackingField;

		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58957C", Offset = "0x58957C")]
		private bool <AirBrakes>k__BackingField;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58958C", Offset = "0x58958C")]
		private float <ForwardSpeed>k__BackingField;

		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58959C", Offset = "0x58959C")]
		private float <EnginePower>k__BackingField;

		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5895AC", Offset = "0x5895AC")]
		private float <RollAngle>k__BackingField;

		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5895BC", Offset = "0x5895BC")]
		private float <PitchAngle>k__BackingField;

		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5895CC", Offset = "0x5895CC")]
		private float <RollInput>k__BackingField;

		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5895DC", Offset = "0x5895DC")]
		private float <PitchInput>k__BackingField;

		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5895EC", Offset = "0x5895EC")]
		private float <YawInput>k__BackingField;

		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5895FC", Offset = "0x5895FC")]
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
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xA65184", Offset = "0xA65184", VA = "0xA65184")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B02C", Offset = "0x58B02C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xA6518C", Offset = "0xA6518C", VA = "0xA6518C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B03C", Offset = "0x58B03C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public float Throttle
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xA65194", Offset = "0xA65194", VA = "0xA65194")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B04C", Offset = "0x58B04C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xA6519C", Offset = "0xA6519C", VA = "0xA6519C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B05C", Offset = "0x58B05C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool AirBrakes
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xA651A4", Offset = "0xA651A4", VA = "0xA651A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B06C", Offset = "0x58B06C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0xA651AC", Offset = "0xA651AC", VA = "0xA651AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B07C", Offset = "0x58B07C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public float ForwardSpeed
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0xA651B8", Offset = "0xA651B8", VA = "0xA651B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B08C", Offset = "0x58B08C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0xA651C0", Offset = "0xA651C0", VA = "0xA651C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B09C", Offset = "0x58B09C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public float EnginePower
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0xA651C8", Offset = "0xA651C8", VA = "0xA651C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B0AC", Offset = "0x58B0AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0xA651D0", Offset = "0xA651D0", VA = "0xA651D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B0BC", Offset = "0x58B0BC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public float MaxEnginePower
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0xA651D8", Offset = "0xA651D8", VA = "0xA651D8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003C")]
		public float RollAngle
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0xA651E0", Offset = "0xA651E0", VA = "0xA651E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B0CC", Offset = "0x58B0CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0xA651E8", Offset = "0xA651E8", VA = "0xA651E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B0DC", Offset = "0x58B0DC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public float PitchAngle
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0xA651F0", Offset = "0xA651F0", VA = "0xA651F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B0EC", Offset = "0x58B0EC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0xA651F8", Offset = "0xA651F8", VA = "0xA651F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B0FC", Offset = "0x58B0FC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public float RollInput
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0xA65200", Offset = "0xA65200", VA = "0xA65200")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B10C", Offset = "0x58B10C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000202")]
			[Address(RVA = "0xA65208", Offset = "0xA65208", VA = "0xA65208")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B11C", Offset = "0x58B11C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public float PitchInput
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0xA65210", Offset = "0xA65210", VA = "0xA65210")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B12C", Offset = "0x58B12C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000204")]
			[Address(RVA = "0xA65218", Offset = "0xA65218", VA = "0xA65218")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B13C", Offset = "0x58B13C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public float YawInput
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0xA65220", Offset = "0xA65220", VA = "0xA65220")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B14C", Offset = "0x58B14C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000206")]
			[Address(RVA = "0xA65228", Offset = "0xA65228", VA = "0xA65228")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B15C", Offset = "0x58B15C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public float ThrottleInput
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0xA65230", Offset = "0xA65230", VA = "0xA65230")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B16C", Offset = "0x58B16C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000208")]
			[Address(RVA = "0xA65238", Offset = "0xA65238", VA = "0xA65238")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B17C", Offset = "0x58B17C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xA65240", Offset = "0xA65240", VA = "0xA65240")]
		private void Start()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xA64990", Offset = "0xA64990", VA = "0xA64990")]
		public void Move(float rollInput, float pitchInput, float yawInput, float throttleInput, bool airBrakes)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xA653B4", Offset = "0xA653B4", VA = "0xA653B4")]
		private void ClampInputs()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xA6544C", Offset = "0xA6544C", VA = "0xA6544C")]
		private void CalculateRollAndPitchAngles()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xA65558", Offset = "0xA65558", VA = "0xA65558")]
		private void AutoLevel()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xA655CC", Offset = "0xA655CC", VA = "0xA655CC")]
		private void CalculateForwardSpeed()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xA65630", Offset = "0xA65630", VA = "0xA65630")]
		private void ControlThrottle()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xA656A4", Offset = "0xA656A4", VA = "0xA656A4")]
		private void CalculateDrag()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xA65750", Offset = "0xA65750", VA = "0xA65750")]
		private void CaluclateAerodynamicEffect()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xA659AC", Offset = "0xA659AC", VA = "0xA659AC")]
		private void CalculateLinearForces()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xA65B2C", Offset = "0xA65B2C", VA = "0xA65B2C")]
		private void CalculateTorque()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xA65D04", Offset = "0xA65D04", VA = "0xA65D04")]
		private void CalculateAltitude()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xA65E24", Offset = "0xA65E24", VA = "0xA65E24")]
		public void Immobilize()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xA65E30", Offset = "0xA65E30", VA = "0xA65E30")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xA65E38", Offset = "0xA65E38", VA = "0xA65E38")]
		public AeroplaneController()
		{
		}
	}
	[Token(Token = "0x2000075")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58963C", Offset = "0x58963C")]
		[SerializeField]
		private float m_ThrottleBlurStart;

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58967C", Offset = "0x58967C")]
		[SerializeField]
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

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xA65E78", Offset = "0xA65E78", VA = "0xA65E78")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xA65F50", Offset = "0xA65F50", VA = "0xA65F50")]
		private void Update()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xA660D0", Offset = "0xA660D0", VA = "0xA660D0")]
		public AeroplanePropellerAnimator()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5883DC", Offset = "0x5883DC")]
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

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xA660F4", Offset = "0xA660F4", VA = "0xA660F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xA66150", Offset = "0xA66150", VA = "0xA66150")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xA66344", Offset = "0xA66344", VA = "0xA66344")]
		private void AdjustInputForMobileControls(ref float roll, ref float pitch, ref float throttle)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xA66428", Offset = "0xA66428", VA = "0xA66428")]
		public AeroplaneUserControl2Axis()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58843C", Offset = "0x58843C")]
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

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xA6643C", Offset = "0xA6643C", VA = "0xA6643C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xA66498", Offset = "0xA66498", VA = "0xA66498")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xA665D4", Offset = "0xA665D4", VA = "0xA665D4")]
		private void AdjustInputForMobileControls(ref float roll, ref float pitch, ref float throttle)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xA66680", Offset = "0xA66680", VA = "0xA66680")]
		public AeroplaneUserControl4Axis()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58849C", Offset = "0x58849C")]
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

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xA242F0", Offset = "0xA242F0", VA = "0xA242F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xA245BC", Offset = "0xA245BC", VA = "0xA245BC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xA24478", Offset = "0xA24478", VA = "0xA24478")]
		private AeroplaneController FindAeroplaneParent()
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xA246EC", Offset = "0xA246EC", VA = "0xA246EC")]
		public JetParticleEffect()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class LandingGear : MonoBehaviour
	{
		[Token(Token = "0x200007A")]
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

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xA24B44", Offset = "0xA24B44", VA = "0xA24B44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xA24C00", Offset = "0xA24C00", VA = "0xA24C00")]
		private void Update()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xA24CE8", Offset = "0xA24CE8", VA = "0xA24CE8")]
		public LandingGear()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Ball
{
	[Token(Token = "0x200007B")]
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

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xA68AEC", Offset = "0xA68AEC", VA = "0xA68AEC")]
		private void Start()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xA68B68", Offset = "0xA68B68", VA = "0xA68B68")]
		public void Move(Vector3 moveDirection, bool jump)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xA68C80", Offset = "0xA68C80", VA = "0xA68C80")]
		public Ball()
		{
		}
	}
	[Token(Token = "0x200007C")]
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

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xA68CA4", Offset = "0xA68CA4", VA = "0xA68CA4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xA68DCC", Offset = "0xA68DCC", VA = "0xA68DCC")]
		private void Update()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xA68F98", Offset = "0xA68F98", VA = "0xA68F98")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xA68FD4", Offset = "0xA68FD4", VA = "0xA68FD4")]
		public BallUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5884FC", Offset = "0x5884FC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5884FC", Offset = "0x5884FC")]
	public class AICharacterControl : MonoBehaviour
	{
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58970C", Offset = "0x58970C")]
		private NavMeshAgent <agent>k__BackingField;

		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58971C", Offset = "0x58971C")]
		private ThirdPersonCharacter <character>k__BackingField;

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x17000042")]
		public NavMeshAgent agent
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0xA63BFC", Offset = "0xA63BFC", VA = "0xA63BFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B18C", Offset = "0x58B18C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000232")]
			[Address(RVA = "0xA63C04", Offset = "0xA63C04", VA = "0xA63C04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B19C", Offset = "0x58B19C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public ThirdPersonCharacter character
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0xA63C0C", Offset = "0xA63C0C", VA = "0xA63C0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B1AC", Offset = "0x58B1AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000234")]
			[Address(RVA = "0xA63C14", Offset = "0xA63C14", VA = "0xA63C14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B1BC", Offset = "0x58B1BC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xA63C1C", Offset = "0xA63C1C", VA = "0xA63C1C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xA63CD8", Offset = "0xA63CD8", VA = "0xA63CD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xA63DDC", Offset = "0xA63DDC", VA = "0xA63DDC")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xA63DE4", Offset = "0xA63DE4", VA = "0xA63DE4")]
		public AICharacterControl()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x588590", Offset = "0x588590")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x588590", Offset = "0x588590")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x588590", Offset = "0x588590")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58975C", Offset = "0x58975C")]
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

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xA2CF20", Offset = "0xA2CF20", VA = "0xA2CF20")]
		private void Start()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xA2D02C", Offset = "0xA2D02C", VA = "0xA2D02C")]
		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xA2D498", Offset = "0xA2D498", VA = "0xA2D498")]
		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xA2D680", Offset = "0xA2D680", VA = "0xA2D680")]
		private void PreventStandingInLowHeadroom()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xA2D7C8", Offset = "0xA2D7C8", VA = "0xA2D7C8")]
		private void UpdateAnimator(Vector3 move)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xA2D3F4", Offset = "0xA2D3F4", VA = "0xA2D3F4")]
		private void HandleAirborneMovement()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xA2D2D4", Offset = "0xA2D2D4", VA = "0xA2D2D4")]
		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xA2D25C", Offset = "0xA2D25C", VA = "0xA2D25C")]
		private void ApplyExtraTurnRotation()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xA2DA28", Offset = "0xA2DA28", VA = "0xA2DA28")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xA2D144", Offset = "0xA2D144", VA = "0xA2D144")]
		private void CheckGroundStatus()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xA2DAD8", Offset = "0xA2DAD8", VA = "0xA2DAD8")]
		public ThirdPersonCharacter()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x588658", Offset = "0x588658")]
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

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xA2DAF8", Offset = "0xA2DAF8", VA = "0xA2DAF8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xA2DC34", Offset = "0xA2DC34", VA = "0xA2DC34")]
		private void Update()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xA2DCC0", Offset = "0xA2DCC0", VA = "0xA2DCC0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xA2DEA4", Offset = "0xA2DEA4", VA = "0xA2DEA4")]
		public ThirdPersonUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5886B8", Offset = "0x5886B8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5886B8", Offset = "0x5886B8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58980C", Offset = "0x58980C")]
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

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xA73EB0", Offset = "0xA73EB0", VA = "0xA73EB0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xA73FE8", Offset = "0xA73FE8", VA = "0xA73FE8")]
		private void Update()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xA74160", Offset = "0xA74160", VA = "0xA74160")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xA741B4", Offset = "0xA741B4", VA = "0xA741B4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xA745F0", Offset = "0xA745F0", VA = "0xA745F0")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xA74630", Offset = "0xA74630", VA = "0xA74630")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xA748F8", Offset = "0xA748F8", VA = "0xA748F8")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xA74734", Offset = "0xA74734", VA = "0xA74734")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xA7445C", Offset = "0xA7445C", VA = "0xA7445C")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xA74108", Offset = "0xA74108", VA = "0xA74108")]
		private void RotateView()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xA74A68", Offset = "0xA74A68", VA = "0xA74A68")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xA74BA4", Offset = "0xA74BA4", VA = "0xA74BA4")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x2000081")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58991C", Offset = "0x58991C")]
		public float RunningStrideLengthen;

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xA23D2C", Offset = "0xA23D2C", VA = "0xA23D2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xA23D88", Offset = "0xA23D88", VA = "0xA23D88")]
		private void Update()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xA24014", Offset = "0xA24014", VA = "0xA24014")]
		public HeadBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
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

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xA26AB8", Offset = "0xA26AB8", VA = "0xA26AB8")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xA26B0C", Offset = "0xA26B0C", VA = "0xA26B0C")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xA26E5C", Offset = "0xA26E5C", VA = "0xA26E5C")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xA26E4C", Offset = "0xA26E4C", VA = "0xA26E4C")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xA26E90", Offset = "0xA26E90", VA = "0xA26E90")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xA26DE4", Offset = "0xA26DE4", VA = "0xA26DE4")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xA26F0C", Offset = "0xA26F0C", VA = "0xA26F0C")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58874C", Offset = "0x58874C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58874C", Offset = "0x58874C")]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000084")]
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

			[Token(Token = "0x600026B")]
			[Address(RVA = "0xBAB688", Offset = "0xBAB688", VA = "0xBAB688")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0xBAB718", Offset = "0xBAB718", VA = "0xBAB718")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000085")]
		public class AdvancedSettings
		{
			[Token(Token = "0x40002B7")]
			[FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			[Token(Token = "0x40002B8")]
			[FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x40002B9")]
			[FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			[Token(Token = "0x40002BA")]
			[FieldOffset(Offset = "0x1C")]
			public bool airControl;

			[Token(Token = "0x40002BB")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x589944", Offset = "0x589944")]
			public float shellOffset;

			[Token(Token = "0x600026D")]
			[Address(RVA = "0xBAB66C", Offset = "0xBAB66C", VA = "0xBAB66C")]
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
			[Token(Token = "0x600025E")]
			[Address(RVA = "0xA23F78", Offset = "0xA23F78", VA = "0xA23F78")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000045")]
		public bool Grounded
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0xA2A860", Offset = "0xA2A860", VA = "0xA2A860")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		public bool Jumping
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0xA2A868", Offset = "0xA2A868", VA = "0xA2A868")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		public bool Running
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0xA23F94", Offset = "0xA23F94", VA = "0xA23F94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xA2A870", Offset = "0xA2A870", VA = "0xA2A870")]
		private void Start()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xA2A93C", Offset = "0xA2A93C", VA = "0xA2A93C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xA2AB48", Offset = "0xA2AB48", VA = "0xA2AB48")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xA2B07C", Offset = "0xA2B07C", VA = "0xA2B07C")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xA2B0F0", Offset = "0xA2B0F0", VA = "0xA2B0F0")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xA2AFAC", Offset = "0xA2AFAC", VA = "0xA2AFAC")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xA2A9D4", Offset = "0xA2A9D4", VA = "0xA2A9D4")]
		private void RotateView()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xA2AE2C", Offset = "0xA2AE2C", VA = "0xA2AE2C")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xA2B2C8", Offset = "0xA2B2C8", VA = "0xA2B2C8")]
		public RigidbodyFirstPersonController()
		{
		}
	}
}
namespace UnityStandardAssets.Cameras
{
	[Token(Token = "0x2000086")]
	public abstract class AbstractTargetFollower : MonoBehaviour
	{
		[Token(Token = "0x2000087")]
		public enum UpdateType
		{
			[Token(Token = "0x40002C1")]
			FixedUpdate,
			[Token(Token = "0x40002C2")]
			LateUpdate,
			[Token(Token = "0x40002C3")]
			ManualUpdate
		}

		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform m_Target;

		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_AutoTargetPlayer;

		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UpdateType m_UpdateType;

		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x28")]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x17000048")]
		public Transform Target
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0xA641F4", Offset = "0xA641F4", VA = "0xA641F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xA63DEC", Offset = "0xA63DEC", VA = "0xA63DEC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xA63F74", Offset = "0xA63F74", VA = "0xA63F74")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xA64044", Offset = "0xA64044", VA = "0xA64044")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xA64118", Offset = "0xA64118", VA = "0xA64118")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x6000272")]
		protected abstract void FollowTarget(float deltaTime);

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xA63EB0", Offset = "0xA63EB0", VA = "0xA63EB0")]
		public void FindAndTargetPlayer()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xA641EC", Offset = "0xA641EC", VA = "0xA641EC", Slot = "6")]
		public virtual void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xA641FC", Offset = "0xA641FC", VA = "0xA641FC")]
		protected AbstractTargetFollower()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[ExecuteInEditMode]
	public class AutoCam : PivotBasedCameraRig
	{
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_RollSpeed;

		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_FollowVelocity;

		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool m_FollowTilt;

		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_SpinTurnLimit;

		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_TargetVelocityLowerLimit;

		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SmoothTurnTime;

		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x68")]
		private float m_LastFlatAngle;

		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x6C")]
		private float m_CurrentTurnAmount;

		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x70")]
		private float m_TurnSpeedVelocityChange;

		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x74")]
		private Vector3 m_RollUp;

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xA674DC", Offset = "0xA674DC", VA = "0xA674DC", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xA678D8", Offset = "0xA678D8", VA = "0xA678D8")]
		public AutoCam()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class FreeLookCam : PivotBasedCameraRig
	{
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x589A3C", Offset = "0x589A3C")]
		private float m_TurnSpeed;

		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_TurnSmoothing;

		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_TiltMax;

		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_TiltMin;

		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_LockCursor;

		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool m_VerticalAutoReturn;

		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x64")]
		private float m_LookAngle;

		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x68")]
		private float m_TiltAngle;

		[Token(Token = "0x40002D9")]
		private const float k_LookDistance = 100f;

		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 m_PivotEulers;

		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x78")]
		private Quaternion m_PivotTargetRot;

		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x88")]
		private Quaternion m_TransformTargetRot;

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xA221FC", Offset = "0xA221FC", VA = "0xA221FC", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xA2234C", Offset = "0xA2234C", VA = "0xA2234C")]
		protected void Update()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xA22688", Offset = "0xA22688", VA = "0xA22688")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xA226AC", Offset = "0xA226AC", VA = "0xA226AC", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xA223AC", Offset = "0xA223AC", VA = "0xA223AC")]
		private void HandleRotationMovement()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xA227F4", Offset = "0xA227F4", VA = "0xA227F4")]
		public FreeLookCam()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class HandHeldCam : LookatTarget
	{
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SwaySpeed;

		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_BaseSwayAmount;

		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_TrackingSwayAmount;

		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x589AFC", Offset = "0x589AFC")]
		private float m_TrackingBias;

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xA23988", Offset = "0xA23988", VA = "0xA23988", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xA23CFC", Offset = "0xA23CFC", VA = "0xA23CFC")]
		public HandHeldCam()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class LookatTarget : AbstractTargetFollower
	{
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 m_RotationRange;

		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_FollowSpeed;

		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x48")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x58")]
		protected Vector3 m_FollowVelocity;

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xA25420", Offset = "0xA25420", VA = "0xA25420", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xA23AC4", Offset = "0xA23AC4", VA = "0xA23AC4", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xA23D1C", Offset = "0xA23D1C", VA = "0xA23D1C")]
		public LookatTarget()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x30")]
		protected Transform m_Cam;

		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x38")]
		protected Transform m_Pivot;

		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x40")]
		protected Vector3 m_LastTargetPosition;

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xA222BC", Offset = "0xA222BC", VA = "0xA222BC", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xA22814", Offset = "0xA22814", VA = "0xA22814")]
		protected PivotBasedCameraRig()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		[Token(Token = "0x200008E")]
		public class RayHitComparer : IComparer
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0xBAB560", Offset = "0xBAB560", VA = "0xBAB560", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x600028C")]
			[Address(RVA = "0xBAB664", Offset = "0xBAB664", VA = "0xBAB664")]
			public RayHitComparer()
			{
			}
		}

		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x18")]
		public float clipMoveTime;

		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x1C")]
		public float returnTime;

		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x20")]
		public float sphereCastRadius;

		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x24")]
		public bool visualiseInEditor;

		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x28")]
		public float closestDistance;

		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x589B5C", Offset = "0x589B5C")]
		private bool <protecting>k__BackingField;

		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x30")]
		public string dontClipTag;

		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x38")]
		private Transform m_Cam;

		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x40")]
		private Transform m_Pivot;

		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x48")]
		private float m_OriginalDist;

		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x4C")]
		private float m_MoveVelocity;

		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x50")]
		private float m_CurrentDist;

		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x54")]
		private Ray m_Ray;

		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x70")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x78")]
		private RayHitComparer m_RayHitComparer;

		[Token(Token = "0x17000049")]
		public bool protecting
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0xA2A090", Offset = "0xA2A090", VA = "0xA2A090")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B1CC", Offset = "0x58B1CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000287")]
			[Address(RVA = "0xA2A098", Offset = "0xA2A098", VA = "0xA2A098")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B1DC", Offset = "0x58B1DC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xA2A0A4", Offset = "0xA2A0A4", VA = "0xA2A0A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xA2A1B0", Offset = "0xA2A1B0", VA = "0xA2A1B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xA2A718", Offset = "0xA2A718", VA = "0xA2A718")]
		public ProtectCameraFromWallClip()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class TargetFieldOfView : AbstractTargetFollower
	{
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_FovAdjustTime;

		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_ZoomAmountMultiplier;

		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_IncludeEffectsInSize;

		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x3C")]
		private float m_BoundSize;

		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x40")]
		private float m_FovAdjustVelocity;

		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x48")]
		private Camera m_Cam;

		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x50")]
		private Transform m_LastTarget;

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xA2CB88", Offset = "0xA2CB88", VA = "0xA2CB88", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xA2CDE0", Offset = "0xA2CDE0", VA = "0xA2CDE0", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xA2CED0", Offset = "0xA2CED0", VA = "0xA2CED0", Slot = "6")]
		public override void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xA2CC00", Offset = "0xA2CC00", VA = "0xA2CC00")]
		public static float MaxBoundsExtent(Transform obj, bool includeEffects)
		{
			return default(float);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xA2CF0C", Offset = "0xA2CF0C", VA = "0xA2CF0C")]
		public TargetFieldOfView()
		{
		}
	}
}
namespace UnityStandardAssets._2D
{
	[Token(Token = "0x2000090")]
	public class Camera2DFollow : MonoBehaviour
	{
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x20")]
		public float damping;

		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x24")]
		public float lookAheadFactor;

		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x28")]
		public float lookAheadReturnSpeed;

		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x2C")]
		public float lookAheadMoveThreshold;

		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x30")]
		private float m_OffsetZ;

		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 m_LastTargetPosition;

		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 m_CurrentVelocity;

		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 m_LookAheadPos;

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xA6BC30", Offset = "0xA6BC30", VA = "0xA6BC30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xA6BCBC", Offset = "0xA6BCBC", VA = "0xA6BCBC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xA6BE94", Offset = "0xA6BE94", VA = "0xA6BE94")]
		public Camera2DFollow()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class CameraFollow : MonoBehaviour
	{
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x18")]
		public float xMargin;

		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x1C")]
		public float yMargin;

		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x20")]
		public float xSmooth;

		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x24")]
		public float ySmooth;

		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 maxXAndY;

		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 minXAndY;

		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x38")]
		private Transform m_Player;

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xA6BEA8", Offset = "0xA6BEA8", VA = "0xA6BEA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xA6BF14", Offset = "0xA6BF14", VA = "0xA6BF14")]
		private bool CheckXMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xA6BF74", Offset = "0xA6BF74", VA = "0xA6BF74")]
		private bool CheckYMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xA6BFD4", Offset = "0xA6BFD4", VA = "0xA6BFD4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xA6BFD8", Offset = "0xA6BFD8", VA = "0xA6BFD8")]
		private void TrackPlayer()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xA6C168", Offset = "0xA6C168", VA = "0xA6C168")]
		public CameraFollow()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5887F0", Offset = "0x5887F0")]
	public class Platformer2DUserControl : MonoBehaviour
	{
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x18")]
		private PlatformerCharacter2D m_Character;

		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x20")]
		private bool m_Jump;

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xA298D4", Offset = "0xA298D4", VA = "0xA298D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xA29930", Offset = "0xA29930", VA = "0xA29930")]
		private void Update()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xA299BC", Offset = "0xA299BC", VA = "0xA299BC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xA29CF0", Offset = "0xA29CF0", VA = "0xA29CF0")]
		public Platformer2DUserControl()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class PlatformerCharacter2D : MonoBehaviour
	{
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MaxSpeed;

		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_JumpForce;

		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x589BBC", Offset = "0x589BBC")]
		private float m_CrouchSpeed;

		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_AirControl;

		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask m_WhatIsGround;

		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x30")]
		private Transform m_GroundCheck;

		[Token(Token = "0x4000317")]
		private const float k_GroundedRadius = 0.2f;

		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x38")]
		private bool m_Grounded;

		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x40")]
		private Transform m_CeilingCheck;

		[Token(Token = "0x400031A")]
		private const float k_CeilingRadius = 0.01f;

		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x48")]
		private Animator m_Anim;

		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x50")]
		private Rigidbody2D m_Rigidbody2D;

		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x58")]
		private bool m_FacingRight;

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xA29CF8", Offset = "0xA29CF8", VA = "0xA29CF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xA29E08", Offset = "0xA29E08", VA = "0xA29E08")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xA29A68", Offset = "0xA29A68", VA = "0xA29A68")]
		public void Move(float move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xA29FEC", Offset = "0xA29FEC", VA = "0xA29FEC")]
		private void Flip()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xA2A068", Offset = "0xA2A068", VA = "0xA2A068")]
		public PlatformerCharacter2D()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class Restarter : MonoBehaviour
	{
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xA2A794", Offset = "0xA2A794", VA = "0xA2A794")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xA2A858", Offset = "0xA2A858", VA = "0xA2A858")]
		public Restarter()
		{
		}
	}
}
namespace VLB
{
	[Token(Token = "0x2000095")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x588850", Offset = "0x588850")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x588850", Offset = "0x588850")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
	{
		[Token(Token = "0x2000096")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5888C0", Offset = "0x5888C0")]
		private sealed class <CoUpdateFadeOut>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000328")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000329")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400032A")]
			[FieldOffset(Offset = "0x20")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x17000055")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002D6")]
				[Address(RVA = "0xBA8AA4", Offset = "0xBA8AA4", VA = "0xBA8AA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000056")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002D8")]
				[Address(RVA = "0xBA8AEC", Offset = "0xBA8AEC", VA = "0xBA8AEC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0xBA89D8", Offset = "0xBA89D8", VA = "0xBA89D8")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x60002D4")]
			[Address(RVA = "0xBA8A04", Offset = "0xBA8A04", VA = "0xBA8A04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002D5")]
			[Address(RVA = "0xBA8A08", Offset = "0xBA8A08", VA = "0xBA8A08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002D7")]
			[Address(RVA = "0xBA8AAC", Offset = "0xBA8AAC", VA = "0xBA8AAC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x18")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x20")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x60")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x68")]
		private Material m_CustomMaterial;

		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x70")]
		private MaterialModifier.Callback m_MaterialModifierCallback;

		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x78")]
		private Coroutine m_CoFadeOut;

		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x589C1C", Offset = "0x589C1C")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x589C2C", Offset = "0x589C2C")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x589C3C", Offset = "0x589C3C")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x98")]
		private Camera m_CurrentCameraRenderingSRP;

		[Token(Token = "0x1700004A")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0xA68FDC", Offset = "0xA68FDC", VA = "0xA68FDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B1EC", Offset = "0x58B1EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0xA68FE4", Offset = "0xA68FE4", VA = "0xA68FE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B1FC", Offset = "0x58B1FC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0xA68FEC", Offset = "0xA68FEC", VA = "0xA68FEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B20C", Offset = "0x58B20C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0xA68FF4", Offset = "0xA68FF4", VA = "0xA68FF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B21C", Offset = "0x58B21C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public Mesh coneMesh
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0xA68FFC", Offset = "0xA68FFC", VA = "0xA68FFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B22C", Offset = "0x58B22C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0xA69004", Offset = "0xA69004", VA = "0xA69004")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B23C", Offset = "0x58B23C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public bool visible
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0xA6900C", Offset = "0xA6900C", VA = "0xA6900C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xA69028", Offset = "0xA69028", VA = "0xA69028")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public int sortingLayerID
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0xA69048", Offset = "0xA69048", VA = "0xA69048")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0xA69064", Offset = "0xA69064", VA = "0xA69064")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public int sortingOrder
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0xA69080", Offset = "0xA69080", VA = "0xA69080")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0xA6909C", Offset = "0xA6909C", VA = "0xA6909C")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0xA690B8", Offset = "0xA690B8", VA = "0xA690B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000051")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0xA69A28", Offset = "0xA69A28", VA = "0xA69A28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000052")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0xA69A30", Offset = "0xA69A30", VA = "0xA69A30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xA6AAF4", Offset = "0xA6AAF4", VA = "0xA6AAF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xA6AB90", Offset = "0xA6AB90", VA = "0xA6AB90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xA690C8", Offset = "0xA690C8", VA = "0xA690C8")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xA691B0", Offset = "0xA691B0", VA = "0xA691B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58B24C", Offset = "0x58B24C")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xA69228", Offset = "0xA69228", VA = "0xA69228")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xA693CC", Offset = "0xA693CC", VA = "0xA693CC")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xA69724", Offset = "0xA69724", VA = "0xA69724")]
		public void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xA69810", Offset = "0xA69810", VA = "0xA69810")]
		private void Start()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xA698CC", Offset = "0xA698CC", VA = "0xA698CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xA69988", Offset = "0xA69988", VA = "0xA69988")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xA69AC8", Offset = "0xA69AC8", VA = "0xA69AC8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xA69B60", Offset = "0xA69B60", VA = "0xA69B60")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xA6A18C", Offset = "0xA6A18C", VA = "0xA6A18C")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xA6AA7C", Offset = "0xA6AA7C", VA = "0xA6AA7C")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xA69F98", Offset = "0xA69F98", VA = "0xA69F98")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xA6955C", Offset = "0xA6955C", VA = "0xA6955C", Slot = "4")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xA6ABD8", Offset = "0xA6ABD8", VA = "0xA6ABD8", Slot = "5")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xA6AD04", Offset = "0xA6AD04", VA = "0xA6AD04", Slot = "6")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xA6AE30", Offset = "0xA6AE30", VA = "0xA6AE30", Slot = "7")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xA6AF64", Offset = "0xA6AF64", VA = "0xA6AF64", Slot = "8")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xA69490", Offset = "0xA69490", VA = "0xA69490")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xA69658", Offset = "0xA69658", VA = "0xA69658")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xA6B054", Offset = "0xA6B054", VA = "0xA6B054")]
		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xA6A4DC", Offset = "0xA6A4DC", VA = "0xA6A4DC")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xA6B164", Offset = "0xA6B164", VA = "0xA6B164")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xA6B2B0", Offset = "0xA6B2B0", VA = "0xA6B2B0")]
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xA6B2BC", Offset = "0xA6B2BC", VA = "0xA6B2BC")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xA6B2FC", Offset = "0xA6B2FC", VA = "0xA6B2FC")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xA6B3E4", Offset = "0xA6B3E4", VA = "0xA6B3E4")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xA6B720", Offset = "0xA6B720", VA = "0xA6B720")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5888D0", Offset = "0x5888D0")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x2C")]
		public RenderPipeline renderPipeline;

		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x589C4C", Offset = "0x589C4C")]
		public bool forceSinglePass;

		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x34")]
		public RenderingMode renderingMode;

		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader1Pass;

		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x40")]
		[HighlightNull]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x589CBC", Offset = "0x589CBC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x589CBC", Offset = "0x589CBC")]
		private Shader beamShader2Pass;

		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x48")]
		[HighlightNull]
		[SerializeField]
		private Shader beamShaderSRP;

		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x50")]
		public int sharedMeshSides;

		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x54")]
		public int sharedMeshSegments;

		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x589D74", Offset = "0x589D74")]
		public float globalNoiseScale;

		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x5C")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x68")]
		public string fadeOutCameraTag;

		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x70")]
		[HighlightNull]
		public TextAsset noise3DData;

		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x78")]
		public int noise3DSize;

		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x80")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x90")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x400033F")]
		private const string kAssetName = "Config";

		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x0")]
		private static Config m_Instance;

		[Token(Token = "0x17000057")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0xA69AC0", Offset = "0xA69AC0", VA = "0xA69AC0")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000058")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0xA6A4CC", Offset = "0xA6A4CC", VA = "0xA6A4CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000059")]
		public Shader beamShader
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0xA6ECC8", Offset = "0xA6ECC8", VA = "0xA6ECC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xA6ED5C", Offset = "0xA6ED5C", VA = "0xA6ED5C")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x1700005B")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0xA6934C", Offset = "0xA6934C", VA = "0xA6934C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public static Config Instance
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xA692F0", Offset = "0xA692F0", VA = "0xA692F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xA6ED94", Offset = "0xA6ED94", VA = "0xA6ED94")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xA6EE40", Offset = "0xA6EE40", VA = "0xA6EE40")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x58B2FC", Offset = "0x58B2FC")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xA6ED50", Offset = "0xA6ED50", VA = "0xA6ED50")]
		private static bool ShouldEnableSrpApi(RenderPipeline pipeline)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xA6EEBC", Offset = "0xA6EEBC", VA = "0xA6EEBC")]
		public static void OnRenderPipelineChanged(RenderPipeline pipeline)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xA6EF68", Offset = "0xA6EF68", VA = "0xA6EF68")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xA6F038", Offset = "0xA6F038", VA = "0xA6F038")]
		public void ResetInternalData()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xA6F230", Offset = "0xA6F230", VA = "0xA6F230")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xA6F3FC", Offset = "0xA6F3FC", VA = "0xA6F3FC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xA6F42C", Offset = "0xA6F42C", VA = "0xA6F42C")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xA6F50C", Offset = "0xA6F50C", VA = "0xA6F50C")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xA6F6D0", Offset = "0xA6F6D0", VA = "0xA6F6D0")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x588908", Offset = "0x588908")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x4000341")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xA6F7D0", Offset = "0xA6F7D0", VA = "0xA6F7D0")]
		public ConfigOverride()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public static class Consts
	{
		[Token(Token = "0x4000342")]
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		[Token(Token = "0x4000343")]
		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		[Token(Token = "0x4000344")]
		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		[Token(Token = "0x4000345")]
		public const string HelpUrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/";

		[Token(Token = "0x4000346")]
		public const string HelpUrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/";

		[Token(Token = "0x4000347")]
		public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

		[Token(Token = "0x4000348")]
		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x0")]
		public static readonly bool ProceduralObjectsVisibleInEditor;

		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x4")]
		public static readonly Color FlatColor;

		[Token(Token = "0x400034B")]
		public const ColorMode ColorModeDefault = ColorMode.Flat;

		[Token(Token = "0x400034C")]
		public const float IntensityDefault = 1f;

		[Token(Token = "0x400034D")]
		public const float IntensityMin = 0f;

		[Token(Token = "0x400034E")]
		public const float IntensityMax = 8f;

		[Token(Token = "0x400034F")]
		public const float SpotAngleDefault = 35f;

		[Token(Token = "0x4000350")]
		public const float SpotAngleMin = 0.1f;

		[Token(Token = "0x4000351")]
		public const float SpotAngleMax = 179.9f;

		[Token(Token = "0x4000352")]
		public const float ConeRadiusStart = 0.1f;

		[Token(Token = "0x4000353")]
		public const MeshType GeomMeshType = MeshType.Shared;

		[Token(Token = "0x4000354")]
		public const int GeomSidesDefault = 18;

		[Token(Token = "0x4000355")]
		public const int GeomSidesMin = 3;

		[Token(Token = "0x4000356")]
		public const int GeomSidesMax = 256;

		[Token(Token = "0x4000357")]
		public const int GeomSegmentsDefault = 5;

		[Token(Token = "0x4000358")]
		public const int GeomSegmentsMin = 0;

		[Token(Token = "0x4000359")]
		public const int GeomSegmentsMax = 64;

		[Token(Token = "0x400035A")]
		public const bool GeomCap = false;

		[Token(Token = "0x400035B")]
		public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

		[Token(Token = "0x400035C")]
		public const float AttenuationCustomBlending = 0.5f;

		[Token(Token = "0x400035D")]
		public const float FallOffStart = 0f;

		[Token(Token = "0x400035E")]
		public const float FallOffEnd = 3f;

		[Token(Token = "0x400035F")]
		public const float FallOffDistancesMinThreshold = 0.01f;

		[Token(Token = "0x4000360")]
		public const float DepthBlendDistance = 2f;

		[Token(Token = "0x4000361")]
		public const float CameraClippingDistance = 0.5f;

		[Token(Token = "0x4000362")]
		public const float FresnelPowMaxValue = 10f;

		[Token(Token = "0x4000363")]
		public const float FresnelPow = 8f;

		[Token(Token = "0x4000364")]
		public const float GlareFrontal = 0.5f;

		[Token(Token = "0x4000365")]
		public const float GlareBehind = 0.5f;

		[Token(Token = "0x4000366")]
		public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

		[Token(Token = "0x4000367")]
		public const float NoiseIntensityMin = 0f;

		[Token(Token = "0x4000368")]
		public const float NoiseIntensityMax = 1f;

		[Token(Token = "0x4000369")]
		public const float NoiseIntensityDefault = 0.5f;

		[Token(Token = "0x400036A")]
		public const float NoiseScaleMin = 0.01f;

		[Token(Token = "0x400036B")]
		public const float NoiseScaleMax = 2f;

		[Token(Token = "0x400036C")]
		public const float NoiseScaleDefault = 0.5f;

		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x14")]
		public static readonly Vector3 NoiseVelocityDefault;

		[Token(Token = "0x400036E")]
		public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

		[Token(Token = "0x400036F")]
		public const float FadeOutBeginDefault = -150f;

		[Token(Token = "0x4000370")]
		public const float FadeOutEndDefault = -200f;

		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x20")]
		public static readonly LayerMask DynOcclusionLayerMaskDefault;

		[Token(Token = "0x4000372")]
		public const float DynOcclusionFadeDistanceToSurfaceDefault = 0.25f;

		[Token(Token = "0x4000373")]
		public const DynamicOcclusionUpdateRate DynamicOcclusionUpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames;

		[Token(Token = "0x4000374")]
		public const int DynOcclusionWaitFramesCountDefault = 3;

		[Token(Token = "0x4000375")]
		public const OccluderDimensions DynOcclusionRaycastingDimensionsDefault = OccluderDimensions.Occluders3D;

		[Token(Token = "0x4000376")]
		public const bool DynOcclusionRaycastingConsiderTriggersDefault = false;

		[Token(Token = "0x4000377")]
		public const float DynOcclusionRaycastingMinOccluderAreaDefault = 0f;

		[Token(Token = "0x4000378")]
		public const float DynOcclusionRaycastingMinSurfaceRatioDefault = 0.5f;

		[Token(Token = "0x4000379")]
		public const float DynOcclusionRaycastingMinSurfaceRatioMin = 50f;

		[Token(Token = "0x400037A")]
		public const float DynOcclusionRaycastingMinSurfaceRatioMax = 100f;

		[Token(Token = "0x400037B")]
		public const float DynOcclusionRaycastingMaxSurfaceDotDefault = 0.25f;

		[Token(Token = "0x400037C")]
		public const float DynOcclusionRaycastingMaxSurfaceAngleMin = 45f;

		[Token(Token = "0x400037D")]
		public const float DynOcclusionRaycastingMaxSurfaceAngleMax = 90f;

		[Token(Token = "0x400037E")]
		public const PlaneAlignment DynOcclusionRaycastingPlaneAlignmentDefault = PlaneAlignment.Surface;

		[Token(Token = "0x400037F")]
		public const float DynOcclusionRaycastingPlaneOffsetDefault = 0.1f;

		[Token(Token = "0x4000380")]
		public const int DynOcclusionDepthBufferDepthMapResolutionDefault = 32;

		[Token(Token = "0x4000381")]
		public const bool DynOcclusionDepthBufferOcclusionCullingDefault = true;

		[Token(Token = "0x4000382")]
		public const bool ConfigGeometryOverrideLayerDefault = true;

		[Token(Token = "0x4000383")]
		public const int ConfigGeometryLayerIDDefault = 1;

		[Token(Token = "0x4000384")]
		public const string ConfigGeometryTagDefault = "Untagged";

		[Token(Token = "0x4000385")]
		public const string ConfigFadeOutCameraTagDefault = "MainCamera";

		[Token(Token = "0x4000386")]
		public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

		[Token(Token = "0x4000387")]
		public const RenderPipeline ConfigGeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

		[Token(Token = "0x4000388")]
		public const RenderingMode ConfigGeometryRenderingModeDefault = RenderingMode.MultiPass;

		[Token(Token = "0x4000389")]
		public const int ConfigNoise3DSizeDefault = 64;

		[Token(Token = "0x400038A")]
		public const int ConfigSharedMeshSides = 24;

		[Token(Token = "0x400038B")]
		public const int ConfigSharedMeshSegments = 5;

		[Token(Token = "0x1700005D")]
		public static HideFlags ProceduralObjectsHideFlags
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xA69F28", Offset = "0xA69F28", VA = "0xA69F28")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x588940", Offset = "0x588940")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x588940", Offset = "0x588940")]
	[DisallowMultipleComponent]
	public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x200009B")]
		protected enum ProcessOcclusionSource
		{
			[Token(Token = "0x4000393")]
			RenderLoop,
			[Token(Token = "0x4000394")]
			OnEnable,
			[Token(Token = "0x4000395")]
			EditorUpdate,
			[Token(Token = "0x4000396")]
			User
		}

		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x18")]
		public DynamicOcclusionUpdateRate updateRate;

		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x589DC0", Offset = "0x589DC0")]
		public int waitXFrames;

		[Token(Token = "0x400038E")]
		[FieldOffset(Offset = "0x0")]
		public static bool _INTERNAL_ApplyRandomFrameOffset;

		[Token(Token = "0x400038F")]
		[FieldOffset(Offset = "0x20")]
		private TransformUtils.Packed m_TransformPacked;

		[Token(Token = "0x4000390")]
		[FieldOffset(Offset = "0x28")]
		private int m_LastFrameRendered;

		[Token(Token = "0x4000391")]
		[FieldOffset(Offset = "0x30")]
		protected VolumetricLightBeam m_Master;

		[Token(Token = "0x1700005E")]
		public int _INTERNAL_LastFrameRendered
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xA70CC0", Offset = "0xA70CC0", VA = "0xA70CC0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xA70AB8", Offset = "0xA70AB8", VA = "0xA70AB8")]
		public void ProcessOcclusionManually()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xA70AC0", Offset = "0xA70AC0", VA = "0xA70AC0")]
		protected void ProcessOcclusion(ProcessOcclusionSource source)
		{
		}

		[Token(Token = "0x60002F1")]
		protected abstract string GetShaderKeyword();

		[Token(Token = "0x60002F2")]
		protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

		[Token(Token = "0x60002F3")]
		protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

		[Token(Token = "0x60002F4")]
		protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

		[Token(Token = "0x60002F5")]
		protected abstract void OnEnablePostValidate();

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xA70CC8", Offset = "0xA70CC8", VA = "0xA70CC8", Slot = "9")]
		protected virtual void OnValidateProperties()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xA70CFC", Offset = "0xA70CFC", VA = "0xA70CFC", Slot = "10")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xA70D7C", Offset = "0xA70D7C", VA = "0xA70D7C", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xA70DD8", Offset = "0xA70DD8", VA = "0xA70DD8", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xA70F44", Offset = "0xA70F44", VA = "0xA70F44", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xA70FE0", Offset = "0xA70FE0", VA = "0xA70FE0")]
		private void OnWillCameraRender(Camera cam)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xA70D98", Offset = "0xA70D98", VA = "0xA70D98")]
		private void DisableOcclusion()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xA71168", Offset = "0xA71168", VA = "0xA71168")]
		protected DynamicOcclusionAbstractBase()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xA711D4", Offset = "0xA711D4", VA = "0xA711D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B30C", Offset = "0x58B30C")]
		private void <OnEnable>b__19_0()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5889D4", Offset = "0x5889D4")]
	[ExecuteInEditMode]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x38")]
		public LayerMask layerMask;

		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x3C")]
		public bool useOcclusionCulling;

		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x40")]
		public int depthMapResolution;

		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x44")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x48")]
		private Camera m_DepthCamera;

		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x50")]
		private bool m_NeedToUpdateOcclusionNextFrame;

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xA711DC", Offset = "0xA711DC", VA = "0xA711DC", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xA71220", Offset = "0xA71220", VA = "0xA71220", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xA71228", Offset = "0xA71228", VA = "0xA71228")]
		private void ProcessOcclusionInternal()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xA7139C", Offset = "0xA7139C", VA = "0xA7139C", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xA713E0", Offset = "0xA713E0", VA = "0xA713E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xA71258", Offset = "0xA71258", VA = "0xA71258")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xA71498", Offset = "0xA71498", VA = "0xA71498")]
		public bool HasLayerMaskIssues()
		{
			return default(bool);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xA71550", Offset = "0xA71550", VA = "0xA71550", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xA715BC", Offset = "0xA715BC", VA = "0xA715BC")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xA718B8", Offset = "0xA718B8", VA = "0xA718B8", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xA718BC", Offset = "0xA718BC", VA = "0xA718BC", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xA71960", Offset = "0xA71960", VA = "0xA71960", Slot = "10")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xA71964", Offset = "0xA71964", VA = "0xA71964", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xA71988", Offset = "0xA71988", VA = "0xA71988")]
		private void DestroyDepthCamera()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xA71B08", Offset = "0xA71B08", VA = "0xA71B08", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xA71CA0", Offset = "0xA71CA0", VA = "0xA71CA0")]
		public DynamicOcclusionDepthBuffer()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x588A20", Offset = "0x588A20")]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x200009E")]
		public class HitResult
		{
			[Token(Token = "0x40003AA")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40003AB")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 normal;

			[Token(Token = "0x40003AC")]
			[FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x40003AD")]
			[FieldOffset(Offset = "0x30")]
			private Collider2D collider2D;

			[Token(Token = "0x40003AE")]
			[FieldOffset(Offset = "0x38")]
			private Collider collider3D;

			[Token(Token = "0x17000064")]
			public bool hasCollider
			{
				[Token(Token = "0x600032F")]
				[Address(RVA = "0xBA9268", Offset = "0xBA9268", VA = "0xBA9268")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000065")]
			public string name
			{
				[Token(Token = "0x6000330")]
				[Address(RVA = "0xBA9318", Offset = "0xBA9318", VA = "0xBA9318")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			public Bounds bounds
			{
				[Token(Token = "0x6000331")]
				[Address(RVA = "0xBA93FC", Offset = "0xBA93FC", VA = "0xBA93FC")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0xBA90F4", Offset = "0xBA90F4", VA = "0xBA90F4")]
			public HitResult(RaycastHit hit3D)
			{
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0xBA917C", Offset = "0xBA917C", VA = "0xBA917C")]
			public HitResult(RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x600032E")]
			[Address(RVA = "0xBA9204", Offset = "0xBA9204", VA = "0xBA9204")]
			public HitResult()
			{
			}
		}

		[Token(Token = "0x200009F")]
		private enum Direction
		{
			[Token(Token = "0x40003B0")]
			Up,
			[Token(Token = "0x40003B1")]
			Right,
			[Token(Token = "0x40003B2")]
			Down,
			[Token(Token = "0x40003B3")]
			Left
		}

		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x38")]
		public OccluderDimensions dimensions;

		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x3C")]
		public LayerMask layerMask;

		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x40")]
		public bool considerTriggers;

		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x44")]
		public float minOccluderArea;

		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0x48")]
		public float minSurfaceRatio;

		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x4C")]
		public float maxSurfaceDot;

		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x50")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x54")]
		public float planeOffset;

		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x589DF8", Offset = "0x589DF8")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x589E30", Offset = "0x589E30")]
		private HitResult <currentHit>k__BackingField;

		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x68")]
		private float m_RangeMultiplier;

		[Token(Token = "0x40003A8")]
		[FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x589E40", Offset = "0x589E40")]
		private Plane <planeEquationWS>k__BackingField;

		[Token(Token = "0x40003A9")]
		[FieldOffset(Offset = "0x7C")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x1700005F")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x58B614", Offset = "0x58B614")]
		public float fadeDistanceToPlane
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0xA71D68", Offset = "0xA71D68", VA = "0xA71D68")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000311")]
			[Address(RVA = "0xA71D70", Offset = "0xA71D70", VA = "0xA71D70")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public HitResult currentHit
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0xA71D78", Offset = "0xA71D78", VA = "0xA71D78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B31C", Offset = "0x58B31C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000314")]
			[Address(RVA = "0xA71D80", Offset = "0xA71D80", VA = "0xA71D80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B32C", Offset = "0x58B32C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000061")]
		private Plane planeEquationWS
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0xA71DD4", Offset = "0xA71DD4", VA = "0xA71DD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B33C", Offset = "0x58B33C")]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x6000318")]
			[Address(RVA = "0xA71DE0", Offset = "0xA71DE0", VA = "0xA71DE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B34C", Offset = "0x58B34C")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0xA720A4", Offset = "0xA720A4", VA = "0xA720A4")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x17000063")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0xA720B8", Offset = "0xA720B8", VA = "0xA720B8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xA6EB90", Offset = "0xA6EB90", VA = "0xA6EB90")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xA71D88", Offset = "0xA71D88", VA = "0xA71D88", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xA71DCC", Offset = "0xA71DCC", VA = "0xA71DCC", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xA71DEC", Offset = "0xA71DEC", VA = "0xA71DEC", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xA71E4C", Offset = "0xA71E4C", VA = "0xA71E4C", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xA71E58", Offset = "0xA71E58", VA = "0xA71E58", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xA71F40", Offset = "0xA71F40", VA = "0xA71F40")]
		private void Start()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xA71FFC", Offset = "0xA71FFC", VA = "0xA71FFC")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xA72100", Offset = "0xA72100", VA = "0xA72100")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xA72114", Offset = "0xA72114", VA = "0xA72114")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xA72390", Offset = "0xA72390", VA = "0xA72390")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xA72644", Offset = "0xA72644", VA = "0xA72644")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xA727C8", Offset = "0xA727C8", VA = "0xA727C8")]
		private bool IsHitValid(HitResult hit)
		{
			return default(bool);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xA72858", Offset = "0xA72858", VA = "0xA72858", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xA71E8C", Offset = "0xA71E8C", VA = "0xA71E8C")]
		private void SetHit(HitResult hit)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xA72D40", Offset = "0xA72D40", VA = "0xA72D40", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xA72BE0", Offset = "0xA72BE0", VA = "0xA72BE0")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xA72B98", Offset = "0xA72B98", VA = "0xA72B98")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xA72F4C", Offset = "0xA72F4C", VA = "0xA72F4C")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xA72F58", Offset = "0xA72F58", VA = "0xA72F58")]
		public DynamicOcclusionRaycasting()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public enum ColorMode
	{
		[Token(Token = "0x40003B5")]
		Flat,
		[Token(Token = "0x40003B6")]
		Gradient
	}
	[Token(Token = "0x20000A1")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x40003B8")]
		Linear,
		[Token(Token = "0x40003B9")]
		Quadratic,
		[Token(Token = "0x40003BA")]
		Blend
	}
	[Token(Token = "0x20000A2")]
	public enum BlendingMode
	{
		[Token(Token = "0x40003BC")]
		Additive,
		[Token(Token = "0x40003BD")]
		SoftAdditive,
		[Token(Token = "0x40003BE")]
		TraditionalTransparency
	}
	[Token(Token = "0x20000A3")]
	public enum NoiseMode
	{
		[Token(Token = "0x40003C0")]
		Disabled,
		[Token(Token = "0x40003C1")]
		WorldSpace,
		[Token(Token = "0x40003C2")]
		LocalSpace
	}
	[Token(Token = "0x20000A4")]
	public enum MeshType
	{
		[Token(Token = "0x40003C4")]
		Shared,
		[Token(Token = "0x40003C5")]
		Custom
	}
	[Token(Token = "0x20000A5")]
	public enum RenderPipeline
	{
		[Token(Token = "0x40003C7")]
		BuiltIn,
		[Token(Token = "0x40003C8")]
		SRP_4_0_0_or_higher
	}
	[Token(Token = "0x20000A6")]
	public enum RenderingMode
	{
		[Token(Token = "0x40003CA")]
		MultiPass,
		[Token(Token = "0x40003CB")]
		SinglePass,
		[Token(Token = "0x40003CC")]
		GPUInstancing
	}
	[Token(Token = "0x20000A7")]
	public enum RenderQueue
	{
		[Token(Token = "0x40003CE")]
		Custom = 0,
		[Token(Token = "0x40003CF")]
		Background = 1000,
		[Token(Token = "0x40003D0")]
		Geometry = 2000,
		[Token(Token = "0x40003D1")]
		AlphaTest = 2450,
		[Token(Token = "0x40003D2")]
		GeometryLast = 2500,
		[Token(Token = "0x40003D3")]
		Transparent = 3000,
		[Token(Token = "0x40003D4")]
		Overlay = 4000
	}
	[Token(Token = "0x20000A8")]
	public enum OccluderDimensions
	{
		[Token(Token = "0x40003D6")]
		Occluders3D,
		[Token(Token = "0x40003D7")]
		Occluders2D
	}
	[Token(Token = "0x20000A9")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x40003D9")]
		Surface,
		[Token(Token = "0x40003DA")]
		Beam
	}
	[Token(Token = "0x20000AA")]
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		[Token(Token = "0x40003DC")]
		Never = 1,
		[Token(Token = "0x40003DD")]
		OnEnable = 2,
		[Token(Token = "0x40003DE")]
		OnBeamMove = 4,
		[Token(Token = "0x40003DF")]
		EveryXFrames = 8,
		[Token(Token = "0x40003E0")]
		OnBeamMoveAndEveryXFrames = 0xC
	}
	[Token(Token = "0x20000AB")]
	public static class GlobalMesh
	{
		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xA22824", Offset = "0xA22824", VA = "0xA22824")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xA22A64", Offset = "0xA22A64", VA = "0xA22A64")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public static class GpuInstancing
	{
		[Token(Token = "0x40003E3")]
		public const bool isSupported = true;

		[Token(Token = "0x17000067")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0xA233C8", Offset = "0xA233C8", VA = "0xA233C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xA23440", Offset = "0xA23440", VA = "0xA23440")]
		public static void SetMaterialProperties(Material material, bool enableInstancing)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xA23508", Offset = "0xA23508", VA = "0xA23508")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xA23768", Offset = "0xA23768", VA = "0xA23768")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xA238AC", Offset = "0xA238AC", VA = "0xA238AC")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x600033A")]
		[Address(RVA = "0xA240C4", Offset = "0xA240C4", VA = "0xA240C4")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class MaterialKeywordSRP
	{
		[Token(Token = "0x40003E4")]
		public const string kKeyword = "VLB_SRP_API";

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xA25468", Offset = "0xA25468", VA = "0xA25468")]
		public MaterialKeywordSRP()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public static class MaterialManager
	{
		[Token(Token = "0x20000B0")]
		public enum BlendingMode
		{
			[Token(Token = "0x40003EC")]
			Additive,
			[Token(Token = "0x40003ED")]
			SoftAdditive,
			[Token(Token = "0x40003EE")]
			TraditionalTransparency,
			[Token(Token = "0x40003EF")]
			Count
		}

		[Token(Token = "0x20000B1")]
		public enum Noise3D
		{
			[Token(Token = "0x40003F1")]
			Off,
			[Token(Token = "0x40003F2")]
			On,
			[Token(Token = "0x40003F3")]
			Count
		}

		[Token(Token = "0x20000B2")]
		public enum DepthBlend
		{
			[Token(Token = "0x40003F5")]
			Off,
			[Token(Token = "0x40003F6")]
			On,
			[Token(Token = "0x40003F7")]
			Count
		}

		[Token(Token = "0x20000B3")]
		public enum ColorGradient
		{
			[Token(Token = "0x40003F9")]
			Off,
			[Token(Token = "0x40003FA")]
			MatrixLow,
			[Token(Token = "0x40003FB")]
			MatrixHigh,
			[Token(Token = "0x40003FC")]
			Count
		}

		[Token(Token = "0x20000B4")]
		public enum DynamicOcclusion
		{
			[Token(Token = "0x40003FE")]
			Off,
			[Token(Token = "0x40003FF")]
			ClippingPlane,
			[Token(Token = "0x4000400")]
			DepthTexture,
			[Token(Token = "0x4000401")]
			Count
		}

		[Token(Token = "0x20000B5")]
		public class StaticProperties
		{
			[Token(Token = "0x4000402")]
			[FieldOffset(Offset = "0x10")]
			public BlendingMode blendingMode;

			[Token(Token = "0x4000403")]
			[FieldOffset(Offset = "0x14")]
			public Noise3D noise3D;

			[Token(Token = "0x4000404")]
			[FieldOffset(Offset = "0x18")]
			public DepthBlend depthBlend;

			[Token(Token = "0x4000405")]
			[FieldOffset(Offset = "0x1C")]
			public ColorGradient colorGradient;

			[Token(Token = "0x4000406")]
			[FieldOffset(Offset = "0x20")]
			public DynamicOcclusion dynamicOcclusion;

			[Token(Token = "0x17000068")]
			public int materialID
			{
				[Token(Token = "0x600033F")]
				[Address(RVA = "0xBAA80C", Offset = "0xBAA80C", VA = "0xBAA80C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000340")]
			[Address(RVA = "0xBAA834", Offset = "0xBAA834", VA = "0xBAA834")]
			public void ApplyToMaterial(Material mat)
			{
			}

			[Token(Token = "0x6000341")]
			[Address(RVA = "0xBAAAF8", Offset = "0xBAAAF8", VA = "0xBAAAF8")]
			public StaticProperties()
			{
			}
		}

		[Token(Token = "0x20000B6")]
		private class MaterialsGroup
		{
			[Token(Token = "0x4000407")]
			[FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x6000342")]
			[Address(RVA = "0xBAA770", Offset = "0xBAA770", VA = "0xBAA770")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x20")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xA25470", Offset = "0xA25470", VA = "0xA25470")]
		public static Material NewMaterial(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xA2563C", Offset = "0xA2563C", VA = "0xA2563C")]
		public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B7")]
	public static class MeshGenerator
	{
		[Token(Token = "0x4000408")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xA25B7C", Offset = "0xA25B7C", VA = "0xA25B7C")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xA25B94", Offset = "0xA25B94", VA = "0xA25B94")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xA25C08", Offset = "0xA25C08", VA = "0xA25C08")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xA22B80", Offset = "0xA22B80", VA = "0xA22B80")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xA25C78", Offset = "0xA25C78", VA = "0xA25C78")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xA25C94", Offset = "0xA25C94", VA = "0xA25C94")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xA25CBC", Offset = "0xA25CBC", VA = "0xA25CBC")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xA25D60", Offset = "0xA25D60", VA = "0xA25D60")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000B8")]
	public static class Noise3D
	{
		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x400040C")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x400040D")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x17000069")]
		public static bool isSupported
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0xA27018", Offset = "0xA27018", VA = "0xA27018")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0xA27218", Offset = "0xA27218", VA = "0xA27218")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0xA27170", Offset = "0xA27170", VA = "0xA27170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xA272B8", Offset = "0xA272B8", VA = "0xA272B8")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x58B35C", Offset = "0x58B35C")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xA27310", Offset = "0xA27310", VA = "0xA27310")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xA2757C", Offset = "0xA2757C", VA = "0xA2757C")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B9")]
	public static class ShaderProperties
	{
		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int FadeOutFactor;

		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int ClippingPlaneWS;

		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int ClippingPlaneProps;

		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int ConeSlopeCosSin;

		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int ConeRadius;

		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int ConeApexOffsetZ;

		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int ColorFlat;

		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly int AlphaInside;

		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x20")]
		public static readonly int AlphaOutside;

		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x24")]
		public static readonly int AttenuationLerpLinearQuad;

		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x28")]
		public static readonly int DistanceFadeStart;

		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly int DistanceFadeEnd;

		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x30")]
		public static readonly int DistanceCamClipping;

		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x34")]
		public static readonly int FresnelPow;

		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x38")]
		public static readonly int GlareBehind;

		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x3C")]
		public static readonly int GlareFrontal;

		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x40")]
		public static readonly int DrawCap;

		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x44")]
		public static readonly int DepthBlendDistance;

		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x48")]
		public static readonly int NoiseLocal;

		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x4C")]
		public static readonly int NoiseParam;

		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x50")]
		public static readonly int CameraParams;

		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x54")]
		public static readonly int CameraBufferSizeSRP;

		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x58")]
		public static readonly int ColorGradientMatrix;

		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x5C")]
		public static readonly int LocalToWorldMatrix;

		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x60")]
		public static readonly int WorldToLocalMatrix;

		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x64")]
		public static readonly int BlendSrcFactor;

		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x68")]
		public static readonly int BlendDstFactor;

		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x6C")]
		public static readonly int DynamicOcclusionDepthTexture;

		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x70")]
		public static readonly int DynamicOcclusionDepthProps;
	}
	[Token(Token = "0x20000BA")]
	public static class TransformUtils
	{
		[Token(Token = "0x20000BB")]
		public class Packed
		{
			[Token(Token = "0x400042B")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 position;

			[Token(Token = "0x400042C")]
			[FieldOffset(Offset = "0x1C")]
			public Quaternion rotation;

			[Token(Token = "0x400042D")]
			[FieldOffset(Offset = "0x2C")]
			public Vector3 lossyScale;

			[Token(Token = "0x6000355")]
			[Address(RVA = "0xBABEE4", Offset = "0xBABEE4", VA = "0xBABEE4")]
			public Packed()
			{
			}
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xA2EB6C", Offset = "0xA2EB6C", VA = "0xA2EB6C")]
		public static Packed GetWorldPacked(this Transform self)
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xA2EC10", Offset = "0xA2EC10", VA = "0xA2EC10")]
		public static bool IsSame(this Transform self, Packed packed)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000BC")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x588A8C", Offset = "0x588A8C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x588A8C", Offset = "0x588A8C")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x4000430")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x20")]
		private Mesh m_Mesh;

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xA2ECA4", Offset = "0xA2ECA4", VA = "0xA2ECA4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xA2EF54", Offset = "0xA2EF54", VA = "0xA2EF54")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public static class Utils
	{
		[Token(Token = "0x20000BE")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x4000435")]
			High = 64,
			[Token(Token = "0x4000436")]
			Low = 8,
			[Token(Token = "0x4000437")]
			Undef = 0
		}

		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x4000433")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xA2EF6C", Offset = "0xA2EF6C", VA = "0xA2EF6C")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x6000359")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xA2EFA4", Offset = "0xA2EFA4", VA = "0xA2EFA4")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600035C")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xA2F0DC", Offset = "0xA2F0DC", VA = "0xA2F0DC")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xA2F1BC", Offset = "0xA2F1BC", VA = "0xA2F1BC")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xA2F1C0", Offset = "0xA2F1C0", VA = "0xA2F1C0")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xA2F1C8", Offset = "0xA2F1C8", VA = "0xA2F1C8")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xA2F1D4", Offset = "0xA2F1D4", VA = "0xA2F1D4")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xA2F1E4", Offset = "0xA2F1E4", VA = "0xA2F1E4")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xA2F1F0", Offset = "0xA2F1F0", VA = "0xA2F1F0")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xA2F1F8", Offset = "0xA2F1F8", VA = "0xA2F1F8")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xA2F24C", Offset = "0xA2F24C", VA = "0xA2F24C")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xA2F2EC", Offset = "0xA2F2EC", VA = "0xA2F2EC")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xA2F320", Offset = "0xA2F320", VA = "0xA2F320")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xA2F5AC", Offset = "0xA2F5AC", VA = "0xA2F5AC")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xA2F654", Offset = "0xA2F654", VA = "0xA2F654")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xA234E4", Offset = "0xA234E4", VA = "0xA234E4")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xA2F6A0", Offset = "0xA2F6A0", VA = "0xA2F6A0")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xA2F6B4", Offset = "0xA2F6B4", VA = "0xA2F6B4")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xA2F8D0", Offset = "0xA2F8D0", VA = "0xA2F8D0")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xA2F9B4", Offset = "0xA2F9B4", VA = "0xA2F9B4")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xA2F7D8", Offset = "0xA2F7D8", VA = "0xA2F7D8")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xA2F9F4", Offset = "0xA2F9F4", VA = "0xA2F9F4")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xA2FAC0", Offset = "0xA2FAC0", VA = "0xA2FAC0")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xA2FAC4", Offset = "0xA2FAC4", VA = "0xA2FAC4")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public static class Version
	{
		[Token(Token = "0x4000438")]
		public const int Current = 1810;
	}
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x588B30", Offset = "0x588B30")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x588B30", Offset = "0x588B30")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x20000C1")]
		public enum Direction
		{
			[Token(Token = "0x400044A")]
			Beam,
			[Token(Token = "0x400044B")]
			Random
		}

		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x589E50", Offset = "0x589E50")]
		public float alpha;

		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x589E68", Offset = "0x589E68")]
		public float size;

		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x20")]
		public Direction direction;

		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x28")]
		public float density;

		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x589E88", Offset = "0x589E88")]
		public float spawnMinDistance;

		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x589EA0", Offset = "0x589EA0")]
		public float spawnMaxDistance;

		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x34")]
		public bool cullingEnabled;

		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x38")]
		public float cullingMaxDistance;

		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x589EB8", Offset = "0x589EB8")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x40")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x48")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x50")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x1700006C")]
		public bool isCulled
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0xA30060", Offset = "0xA30060", VA = "0xA30060")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B4AC", Offset = "0x58B4AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000376")]
			[Address(RVA = "0xA30068", Offset = "0xA30068", VA = "0xA30068")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B4BC", Offset = "0x58B4BC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0xA30074", Offset = "0xA30074", VA = "0xA30074")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0xA300DC", Offset = "0xA300DC", VA = "0xA300DC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006F")]
		public int particlesMaxCount
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0xA3016C", Offset = "0xA3016C", VA = "0xA3016C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000070")]
		public Camera mainCamera
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0xA30214", Offset = "0xA30214", VA = "0xA30214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xA304A4", Offset = "0xA304A4", VA = "0xA304A4")]
		private void Start()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xA30514", Offset = "0xA30514", VA = "0xA30514")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xA307D0", Offset = "0xA307D0", VA = "0xA307D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xA30718", Offset = "0xA30718", VA = "0xA30718")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xA30EA0", Offset = "0xA30EA0", VA = "0xA30EA0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xA30F3C", Offset = "0xA30F3C", VA = "0xA30F3C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xA31000", Offset = "0xA31000", VA = "0xA31000")]
		private void Update()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xA307D4", Offset = "0xA307D4", VA = "0xA307D4")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xA31034", Offset = "0xA31034", VA = "0xA31034")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xA31434", Offset = "0xA31434", VA = "0xA31434")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x588BD4", Offset = "0x588BD4")]
	[SelectionBase]
	[DisallowMultipleComponent]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x20000C3")]
		public delegate void OnWillCameraRenderCB(Camera cam);

		[Token(Token = "0x20000C4")]
		public delegate void OnBeamGeometryInitialized();

		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x588C40", Offset = "0x588C40")]
		private sealed class <CoPlaytimeUpdate>d__149 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400047B")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400047C")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400047D")]
			[FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x17000092")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003DC")]
				[Address(RVA = "0xBABFB0", Offset = "0xBABFB0", VA = "0xBABFB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003DE")]
				[Address(RVA = "0xBABFF8", Offset = "0xBABFF8", VA = "0xBABFF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0xBABEEC", Offset = "0xBABEEC", VA = "0xBABEEC")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__149(int <>1__state)
			{
			}

			[Token(Token = "0x60003DA")]
			[Address(RVA = "0xBABF18", Offset = "0xBABF18", VA = "0xBABF18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0xBABF1C", Offset = "0xBABF1C", VA = "0xBABF1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003DD")]
			[Address(RVA = "0xBABFB8", Offset = "0xBABFB8", VA = "0xBABFB8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x589EC8", Offset = "0x589EC8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x589EC8", Offset = "0x589EC8")]
		public Color color;

		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x589F1C", Offset = "0x589F1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x589F1C", Offset = "0x589F1C")]
		public float intensityInside;

		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x589F70", Offset = "0x589F70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x589F70", Offset = "0x589F70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x589F70", Offset = "0x589F70")]
		public float intensityOutside;

		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x589FE8", Offset = "0x589FE8")]
		public bool spotAngleFromLight;

		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58A020", Offset = "0x58A020")]
		public float spotAngle;

		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x58A040", Offset = "0x58A040")]
		public float coneRadiusStart;

		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x54")]
		public MeshType geomMeshType;

		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x58A078", Offset = "0x58A078")]
		public int geomCustomSides;

		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x5C")]
		public int geomCustomSegments;

		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x60")]
		public bool geomCap;

		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x58A0B0", Offset = "0x58A0B0")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x64")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58A0E8", Offset = "0x58A0E8")]
		public float attenuationCustomBlending;

		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x58A100", Offset = "0x58A100")]
		public float fallOffStart;

		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x58A138", Offset = "0x58A138")]
		public float fallOffEnd;

		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x74")]
		public float depthBlendDistance;

		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x78")]
		public float cameraClippingDistance;

		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58A170", Offset = "0x58A170")]
		public float glareFrontal;

		[Token(Token = "0x4000464")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58A188", Offset = "0x58A188")]
		public float glareBehind;

		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x58A1A0", Offset = "0x58A1A0")]
		public float fresnelPow;

		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x88")]
		public NoiseMode noiseMode;

		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x58A1D8", Offset = "0x58A1D8")]
		private bool _DEPRECATED_NoiseEnabled;

		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58A224", Offset = "0x58A224")]
		public float noiseIntensity;

		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x94")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58A23C", Offset = "0x58A23C")]
		public float noiseScaleLocal;

		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x9C")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58A258", Offset = "0x58A258")]
		private MaterialManager.DynamicOcclusion <_INTERNAL_DynamicOcclusionMode>k__BackingField;

		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_IsDynamicOcclusionEnabled;

		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0xC0")]
		private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x58A288", Offset = "0x58A288")]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x58A2F4", Offset = "0x58A2F4")]
		private float _FadeOutBegin;

		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x58A340", Offset = "0x58A340")]
		[SerializeField]
		private float _FadeOutEnd;

		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58A38C", Offset = "0x58A38C")]
		private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField;

		[Token(Token = "0x4000478")]
		[FieldOffset(Offset = "0xE8")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0xF0")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0xF8")]
		private Light _CachedLight;

		[Token(Token = "0x17000071")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x58B64C", Offset = "0x58B64C")]
		public float alphaInside
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0xA314E0", Offset = "0xA314E0", VA = "0xA314E0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000387")]
			[Address(RVA = "0xA314E8", Offset = "0xA314E8", VA = "0xA314E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x58B684", Offset = "0x58B684")]
		public float alphaOutside
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0xA314F0", Offset = "0xA314F0", VA = "0xA314F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000389")]
			[Address(RVA = "0xA314F8", Offset = "0xA314F8", VA = "0xA314F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public float intensityGlobal
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0xA31500", Offset = "0xA31500", VA = "0xA31500")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600038B")]
			[Address(RVA = "0xA31508", Offset = "0xA31508", VA = "0xA31508")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public float coneAngle
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0xA3123C", Offset = "0xA3123C", VA = "0xA3123C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000075")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0xA2EECC", Offset = "0xA2EECC", VA = "0xA2EECC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000076")]
		public float coneVolume
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0xA31510", Offset = "0xA31510", VA = "0xA31510")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000077")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0xA31564", Offset = "0xA31564", VA = "0xA31564")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000078")]
		public int geomSides
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0xA315BC", Offset = "0xA315BC", VA = "0xA315BC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0xA31644", Offset = "0xA31644", VA = "0xA31644")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public int geomSegments
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0xA316CC", Offset = "0xA316CC", VA = "0xA316CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000393")]
			[Address(RVA = "0xA31754", Offset = "0xA31754", VA = "0xA31754")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x58B6BC", Offset = "0x58B6BC")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0xA317DC", Offset = "0xA317DC", VA = "0xA317DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000395")]
			[Address(RVA = "0xA317E4", Offset = "0xA317E4", VA = "0xA317E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0xA317F0", Offset = "0xA317F0", VA = "0xA317F0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700007C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x58B6F4", Offset = "0x58B6F4")]
		public float fadeStart
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0xA31818", Offset = "0xA31818", VA = "0xA31818")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000398")]
			[Address(RVA = "0xA31820", Offset = "0xA31820", VA = "0xA31820")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x58B72C", Offset = "0x58B72C")]
		public float fadeEnd
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0xA31828", Offset = "0xA31828", VA = "0xA31828")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600039A")]
			[Address(RVA = "0xA31830", Offset = "0xA31830", VA = "0xA31830")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0xA23978", Offset = "0xA23978", VA = "0xA23978")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007F")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x58B764", Offset = "0x58B764")]
		public bool noiseEnabled
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0xA31838", Offset = "0xA31838", VA = "0xA31838")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600039D")]
			[Address(RVA = "0xA31848", Offset = "0xA31848", VA = "0xA31848")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public float fadeOutBegin
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0xA31864", Offset = "0xA31864", VA = "0xA31864")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600039F")]
			[Address(RVA = "0xA3186C", Offset = "0xA3186C", VA = "0xA3186C")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public float fadeOutEnd
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0xA318C8", Offset = "0xA318C8", VA = "0xA318C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0xA318D0", Offset = "0xA318D0", VA = "0xA318D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0xA3127C", Offset = "0xA3127C", VA = "0xA3127C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000083")]
		public int sortingLayerID
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0xA318D8", Offset = "0xA318D8", VA = "0xA318D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0xA318E0", Offset = "0xA318E0", VA = "0xA318E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public string sortingLayerName
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0xA31984", Offset = "0xA31984", VA = "0xA31984")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0xA31990", Offset = "0xA31990", VA = "0xA31990")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public int sortingOrder
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0xA319C0", Offset = "0xA319C0", VA = "0xA319C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xA319C8", Offset = "0xA319C8", VA = "0xA319C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0xA31A6C", Offset = "0xA31A6C", VA = "0xA31A6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xA31A74", Offset = "0xA31A74", VA = "0xA31A74")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0xA31AEC", Offset = "0xA31AEC", VA = "0xA31AEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000088")]
		public bool hasGeometry
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0xA312A0", Offset = "0xA312A0", VA = "0xA312A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000089")]
		public Bounds bounds
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0xA3130C", Offset = "0xA3130C", VA = "0xA3130C")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x1700008A")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xA31AFC", Offset = "0xA31AFC", VA = "0xA31AFC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008B")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0xA31BE0", Offset = "0xA31BE0", VA = "0xA31BE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B4CC", Offset = "0x58B4CC")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xA31BE8", Offset = "0xA31BE8", VA = "0xA31BE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B4DC", Offset = "0x58B4DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public MaterialManager.DynamicOcclusion _INTERNAL_EnabledDynamicOcclusionMode
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0xA31BF0", Offset = "0xA31BF0", VA = "0xA31BF0")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
		}

		[Token(Token = "0x1700008D")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0xA31FE0", Offset = "0xA31FE0", VA = "0xA31FE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B50C", Offset = "0x58B50C")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0xA31FE8", Offset = "0xA31FE8", VA = "0xA31FE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B51C", Offset = "0x58B51C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public string meshStats
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0xA31FF0", Offset = "0xA31FF0", VA = "0xA31FF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		public int meshVerticesCount
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0xA321C4", Offset = "0xA321C4", VA = "0xA321C4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000090")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0xA3229C", Offset = "0xA3229C", VA = "0xA3229C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000091")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0xA3238C", Offset = "0xA3238C", VA = "0xA3238C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0xA31CBC", Offset = "0xA31CBC", VA = "0xA31CBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B4EC", Offset = "0x58B4EC")]
			add
			{
			}
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0xA31D5C", Offset = "0xA31D5C", VA = "0xA31D5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B4FC", Offset = "0x58B4FC")]
			remove
			{
			}
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xA31C08", Offset = "0xA31C08", VA = "0xA31C08")]
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xA31DFC", Offset = "0xA31DFC", VA = "0xA31DFC")]
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xA31E10", Offset = "0xA31E10", VA = "0xA31E10")]
		public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xA31EF8", Offset = "0xA31EF8", VA = "0xA31EF8")]
		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xA31874", Offset = "0xA31874", VA = "0xA31874")]
		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xA31F3C", Offset = "0xA31F3C", VA = "0xA31F3C")]
		private void OnFadeOutStateChanged()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xA32494", Offset = "0xA32494", VA = "0xA32494")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xA324F4", Offset = "0xA324F4", VA = "0xA324F4")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xA3264C", Offset = "0xA3264C", VA = "0xA3264C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x58B52C", Offset = "0x58B52C")]
		public void Generate()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xA32658", Offset = "0xA32658", VA = "0xA32658", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xA328D0", Offset = "0xA328D0", VA = "0xA328D0", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xA32964", Offset = "0xA32964", VA = "0xA32964")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xA32970", Offset = "0xA32970", VA = "0xA32970")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xA329FC", Offset = "0xA329FC", VA = "0xA329FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xA31A80", Offset = "0xA31A80", VA = "0xA31A80")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xA32A90", Offset = "0xA32A90", VA = "0xA32A90")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58B564", Offset = "0x58B564")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xA32B08", Offset = "0xA32B08", VA = "0xA32B08")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xA32B0C", Offset = "0xA32B0C", VA = "0xA32B0C")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xA32BD0", Offset = "0xA32BD0", VA = "0xA32BD0")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xA32CCC", Offset = "0xA32CCC", VA = "0xA32CCC")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xA328A0", Offset = "0xA328A0", VA = "0xA328A0")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xA327B8", Offset = "0xA327B8", VA = "0xA327B8")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xA32E70", Offset = "0xA32E70", VA = "0xA32E70")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x588C50", Offset = "0x588C50")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xA6C350", Offset = "0xA6C350", VA = "0xA6C350")]
		private void Update()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xA6C44C", Offset = "0xA6C44C", VA = "0xA6C44C")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x588CB0", Offset = "0x588CB0")]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x400047F")]
		[FieldOffset(Offset = "0x18")]
		private bool isInsideBeam;

		[Token(Token = "0x4000480")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xA6E908", Offset = "0xA6E908", VA = "0xA6E908")]
		private void Start()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xA6E9F8", Offset = "0xA6E9F8", VA = "0xA6E9F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xA6EABC", Offset = "0xA6EABC", VA = "0xA6EABC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xA6EAC4", Offset = "0xA6EAC4", VA = "0xA6EAC4")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xA6ECC0", Offset = "0xA6ECC0", VA = "0xA6ECC0")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xA73B74", Offset = "0xA73B74", VA = "0xA73B74")]
		private void Start()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xA73C40", Offset = "0xA73C40", VA = "0xA73C40")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x17000094")]
		private bool useMouseView
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0xA74DF0", Offset = "0xA74DF0", VA = "0xA74DF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xA74DF8", Offset = "0xA74DF8", VA = "0xA74DF8")]
			set
			{
			}
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xA74E34", Offset = "0xA74E34", VA = "0xA74E34")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xA74ECC", Offset = "0xA74ECC", VA = "0xA74ECC")]
		private void Update()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xA753E0", Offset = "0xA753E0", VA = "0xA753E0")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58A3AC", Offset = "0x58A3AC")]
		private int CountX;

		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58A3F0", Offset = "0x58A3F0")]
		[SerializeField]
		private int CountY;

		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xA24D0C", Offset = "0xA24D0C", VA = "0xA24D0C")]
		public void Generate()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xA25404", Offset = "0xA25404", VA = "0xA25404")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x58A474", Offset = "0x58A474")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xA2B3D4", Offset = "0xA2B3D4", VA = "0xA2B3D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xA2B4A8", Offset = "0xA2B4A8", VA = "0xA2B4A8")]
		public Rotater()
		{
		}
	}
}
