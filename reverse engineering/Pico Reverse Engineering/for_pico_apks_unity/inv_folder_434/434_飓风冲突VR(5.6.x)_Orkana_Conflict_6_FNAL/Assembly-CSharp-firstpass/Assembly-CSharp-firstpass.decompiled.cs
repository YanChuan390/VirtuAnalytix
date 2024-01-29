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
	[Address(RVA = "0xA509C0", Offset = "0xA509C0", VA = "0xA509C0")]
	public static bool IsUsingCustomRenderPipeline()
	{
		return default(bool);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xA50A9C", Offset = "0xA50A9C", VA = "0xA50A9C")]
	public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xA50B14", Offset = "0xA50B14", VA = "0xA50B14")]
	public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
	{
	}
}
[Token(Token = "0x2000006")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x600000D")]
	[Address(RVA = "0xA50B80", Offset = "0xA50B80", VA = "0xA50B80")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xA50C88", Offset = "0xA50C88", VA = "0xA50C88")]
	public EventSystemChecker()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000007")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000008")]
		public enum Mode
		{
			[Token(Token = "0x4000007")]
			Trigger,
			[Token(Token = "0x4000008")]
			Replace,
			[Token(Token = "0x4000009")]
			Activate,
			[Token(Token = "0x400000A")]
			Enable,
			[Token(Token = "0x400000B")]
			Animate,
			[Token(Token = "0x400000C")]
			Deactivate
		}

		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x18")]
		public Mode action;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x20")]
		public UnityEngine.Object target;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x28")]
		public GameObject source;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x30")]
		public int triggerCount;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x34")]
		public bool repeatTrigger;

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xA50C90", Offset = "0xA50C90", VA = "0xA50C90")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xA510CC", Offset = "0xA510CC", VA = "0xA510CC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xA510D0", Offset = "0xA510D0", VA = "0xA510D0")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000A")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x6000014")]
			[Address(RVA = "0xA51C2C", Offset = "0xA51C2C", VA = "0xA51C2C")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200000B")]
		public class ReplacementList
		{
			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x6000015")]
			[Address(RVA = "0xA51C34", Offset = "0xA51C34", VA = "0xA51C34")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xA510E8", Offset = "0xA510E8", VA = "0xA510E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xA51C24", Offset = "0xA51C24", VA = "0xA51C24")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000D")]
		public class Vector3andSpace
		{
			[Token(Token = "0x4000015")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x4000016")]
			[FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x6000019")]
			[Address(RVA = "0xA51D80", Offset = "0xA51D80", VA = "0xA51D80")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xA51C98", Offset = "0xA51C98", VA = "0xA51C98")]
		private void Start()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xA51CB4", Offset = "0xA51CB4", VA = "0xA51CB4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xA51D78", Offset = "0xA51D78", VA = "0xA51D78")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class CameraRefocus
	{
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xA51D90", Offset = "0xA51D90", VA = "0xA51D90")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xA51DF8", Offset = "0xA51DF8", VA = "0xA51DF8")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xA51E00", Offset = "0xA51E00", VA = "0xA51E00")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xA51E08", Offset = "0xA51E08", VA = "0xA51E08")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xA51EF4", Offset = "0xA51EF4", VA = "0xA51EF4")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class CurveControlledBob
	{
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xA51F38", Offset = "0xA51F38", VA = "0xA51F38")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xA51FD8", Offset = "0xA51FD8", VA = "0xA51FD8")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xA520C8", Offset = "0xA520C8", VA = "0xA520C8")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400002C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400002D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400002E")]
			[FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x400002F")]
			[FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000030")]
			[FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x4000031")]
			[FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x4000032")]
			[FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x17000001")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000029")]
				[Address(RVA = "0xA52A64", Offset = "0xA52A64", VA = "0xA52A64", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000002")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600002B")]
				[Address(RVA = "0xA52AAC", Offset = "0xA52AAC", VA = "0xA52AAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000026")]
			[Address(RVA = "0xA527F0", Offset = "0xA527F0", VA = "0xA527F0")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000027")]
			[Address(RVA = "0xA52820", Offset = "0xA52820", VA = "0xA52820", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000028")]
			[Address(RVA = "0xA52824", Offset = "0xA52824", VA = "0xA52824", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600002A")]
			[Address(RVA = "0xA52A6C", Offset = "0xA52A6C", VA = "0xA52A6C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000025")]
		private const float k_Spring = 50f;

		[Token(Token = "0x4000026")]
		private const float k_Damper = 5f;

		[Token(Token = "0x4000027")]
		private const float k_Drag = 10f;

		[Token(Token = "0x4000028")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x4000029")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x400002A")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xA52314", Offset = "0xA52314", VA = "0xA52314")]
		private void Update()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xA5276C", Offset = "0xA5276C", VA = "0xA5276C")]
		[IteratorStateMachine(typeof(<DragObject>d__8))]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xA526C0", Offset = "0xA526C0", VA = "0xA526C0")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xA52818", Offset = "0xA52818", VA = "0xA52818")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xA52AB4", Offset = "0xA52AB4", VA = "0xA52AB4")]
		private void Start()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xA52ADC", Offset = "0xA52ADC", VA = "0xA52ADC")]
		private void Update()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xA52D00", Offset = "0xA52D00", VA = "0xA52D00")]
		public DynamicShadowSettings()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xA52D34", Offset = "0xA52D34", VA = "0xA52D34")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xA52D90", Offset = "0xA52D90", VA = "0xA52D90")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000014")]
	public class FOVKick
	{
		[Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000046")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000047")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000048")]
			[FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x4000049")]
			[FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000003")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600003A")]
				[Address(RVA = "0xA5316C", Offset = "0xA5316C", VA = "0xA5316C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000004")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600003C")]
				[Address(RVA = "0xA531B4", Offset = "0xA531B4", VA = "0xA531B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000037")]
			[Address(RVA = "0xA52F54", Offset = "0xA52F54", VA = "0xA52F54")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000038")]
			[Address(RVA = "0xA53034", Offset = "0xA53034", VA = "0xA53034", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000039")]
			[Address(RVA = "0xA53038", Offset = "0xA53038", VA = "0xA53038", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600003B")]
			[Address(RVA = "0xA53174", Offset = "0xA53174", VA = "0xA53174", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400004A")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400004B")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400004C")]
			[FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x400004D")]
			[FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000005")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000040")]
				[Address(RVA = "0xA53308", Offset = "0xA53308", VA = "0xA53308", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000006")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000042")]
				[Address(RVA = "0xA53350", Offset = "0xA53350", VA = "0xA53350", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600003D")]
			[Address(RVA = "0xA52FF0", Offset = "0xA52FF0", VA = "0xA52FF0")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0xA531BC", Offset = "0xA531BC", VA = "0xA531BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600003F")]
			[Address(RVA = "0xA531C0", Offset = "0xA531C0", VA = "0xA531C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000041")]
			[Address(RVA = "0xA53310", Offset = "0xA53310", VA = "0xA53310", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xA52DA8", Offset = "0xA52DA8", VA = "0xA52DA8")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xA52DF0", Offset = "0xA52DF0", VA = "0xA52DF0")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xA52ED8", Offset = "0xA52ED8", VA = "0xA52ED8")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xA52EE0", Offset = "0xA52EE0", VA = "0xA52EE0")]
		[IteratorStateMachine(typeof(<FOVKickUp>d__9))]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xA52F7C", Offset = "0xA52F7C", VA = "0xA52F7C")]
		[IteratorStateMachine(typeof(<FOVKickDown>d__10))]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xA53018", Offset = "0xA53018", VA = "0xA53018")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[RequireComponent(typeof(Text))]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x400004E")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x4000052")]
		private const string display = "{0} FPS";

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xA53358", Offset = "0xA53358", VA = "0xA53358")]
		private void Start()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xA533C4", Offset = "0xA533C4", VA = "0xA533C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xA534B8", Offset = "0xA534B8", VA = "0xA534B8")]
		public FPSCounter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public class LerpControlledBob
	{
		[Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000057")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000058")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000059")]
			[FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x400005A")]
			[FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000007")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600004C")]
				[Address(RVA = "0xA53724", Offset = "0xA53724", VA = "0xA53724", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000008")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600004E")]
				[Address(RVA = "0xA5376C", Offset = "0xA5376C", VA = "0xA5376C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000049")]
			[Address(RVA = "0xA5353C", Offset = "0xA5353C", VA = "0xA5353C")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600004A")]
			[Address(RVA = "0xA5356C", Offset = "0xA5356C", VA = "0xA5356C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600004B")]
			[Address(RVA = "0xA53570", Offset = "0xA53570", VA = "0xA53570", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600004D")]
			[Address(RVA = "0xA5372C", Offset = "0xA5372C", VA = "0xA5372C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xA534C0", Offset = "0xA534C0", VA = "0xA534C0")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xA534C8", Offset = "0xA534C8", VA = "0xA534C8")]
		[IteratorStateMachine(typeof(<DoBobCycle>d__4))]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xA53564", Offset = "0xA53564", VA = "0xA53564")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400005F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000060")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000061")]
			[FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000062")]
			[FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x17000009")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000056")]
				[Address(RVA = "0xA53BF8", Offset = "0xA53BF8", VA = "0xA53BF8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000058")]
				[Address(RVA = "0xA53C40", Offset = "0xA53C40", VA = "0xA53C40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000053")]
			[Address(RVA = "0xA53938", Offset = "0xA53938", VA = "0xA53938")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000054")]
			[Address(RVA = "0xA53968", Offset = "0xA53968", VA = "0xA53968", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000055")]
			[Address(RVA = "0xA5396C", Offset = "0xA5396C", VA = "0xA5396C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000057")]
			[Address(RVA = "0xA53C00", Offset = "0xA53C00", VA = "0xA53C00", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xA53774", Offset = "0xA53774", VA = "0xA53774")]
		private void Start()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xA53894", Offset = "0xA53894", VA = "0xA53894")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xA538B4", Offset = "0xA538B4", VA = "0xA538B4")]
		[IteratorStateMachine(typeof(<ResetCoroutine>d__6))]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xA53960", Offset = "0xA53960", VA = "0xA53960")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000067")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000068")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000069")]
			[FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x400006A")]
			[FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x400006B")]
			[FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x1700000B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600005F")]
				[Address(RVA = "0xA54008", Offset = "0xA54008", VA = "0xA54008", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000061")]
				[Address(RVA = "0xA54050", Offset = "0xA54050", VA = "0xA54050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600005C")]
			[Address(RVA = "0xA53CBC", Offset = "0xA53CBC", VA = "0xA53CBC")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600005D")]
			[Address(RVA = "0xA53D04", Offset = "0xA53D04", VA = "0xA53D04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600005E")]
			[Address(RVA = "0xA53D08", Offset = "0xA53D08", VA = "0xA53D08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000060")]
			[Address(RVA = "0xA54010", Offset = "0xA54010", VA = "0xA54010", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xA53C48", Offset = "0xA53C48", VA = "0xA53C48")]
		[IteratorStateMachine(typeof(<Start>d__4))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xA53CE4", Offset = "0xA53CE4", VA = "0xA53CE4")]
		public void Stop()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xA53CF0", Offset = "0xA53CF0", VA = "0xA53CF0")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x200001F")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x4000071")]
			Standalone,
			[Token(Token = "0x4000072")]
			Mobile
		}

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xA54058", Offset = "0xA54058", VA = "0xA54058")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xA5405C", Offset = "0xA5405C", VA = "0xA5405C")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xA5406C", Offset = "0xA5406C", VA = "0xA5406C")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xA54458", Offset = "0xA54458", VA = "0xA54458")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xA544F4", Offset = "0xA544F4", VA = "0xA544F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xA54524", Offset = "0xA54524", VA = "0xA54524")]
		private void Update()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xA54918", Offset = "0xA54918", VA = "0xA54918")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xA54938", Offset = "0xA54938", VA = "0xA54938")]
		private void Start()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xA5493C", Offset = "0xA5493C", VA = "0xA5493C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xA54C70", Offset = "0xA54C70", VA = "0xA54C70")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000023")]
		public enum Action
		{
			[Token(Token = "0x4000084")]
			Activate,
			[Token(Token = "0x4000085")]
			Deactivate,
			[Token(Token = "0x4000086")]
			Destroy,
			[Token(Token = "0x4000087")]
			ReloadLevel,
			[Token(Token = "0x4000088")]
			Call
		}

		[Serializable]
		[Token(Token = "0x2000024")]
		public class Entry
		{
			[Token(Token = "0x4000089")]
			[FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x400008A")]
			[FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x400008B")]
			[FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x6000071")]
			[Address(RVA = "0xA54FEC", Offset = "0xA54FEC", VA = "0xA54FEC")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000025")]
		public class Entries
		{
			[Token(Token = "0x400008C")]
			[FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x6000072")]
			[Address(RVA = "0xA54FE4", Offset = "0xA54FE4", VA = "0xA54FE4")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400008D")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400008E")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400008F")]
			[FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700000D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000076")]
				[Address(RVA = "0xA550C8", Offset = "0xA550C8", VA = "0xA550C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000078")]
				[Address(RVA = "0xA55110", Offset = "0xA55110", VA = "0xA55110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000073")]
			[Address(RVA = "0xA54EF8", Offset = "0xA54EF8", VA = "0xA54EF8")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000074")]
			[Address(RVA = "0xA54FF4", Offset = "0xA54FF4", VA = "0xA54FF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000075")]
			[Address(RVA = "0xA54FF8", Offset = "0xA54FF8", VA = "0xA54FF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000077")]
			[Address(RVA = "0xA550D0", Offset = "0xA550D0", VA = "0xA550D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000090")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000091")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000092")]
			[FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700000F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600007C")]
				[Address(RVA = "0xA551EC", Offset = "0xA551EC", VA = "0xA551EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000010")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600007E")]
				[Address(RVA = "0xA55234", Offset = "0xA55234", VA = "0xA55234", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000079")]
			[Address(RVA = "0xA54F20", Offset = "0xA54F20", VA = "0xA54F20")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600007A")]
			[Address(RVA = "0xA55118", Offset = "0xA55118", VA = "0xA55118", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600007B")]
			[Address(RVA = "0xA5511C", Offset = "0xA5511C", VA = "0xA5511C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600007D")]
			[Address(RVA = "0xA551F4", Offset = "0xA551F4", VA = "0xA551F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000093")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000094")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000095")]
			[FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000011")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000082")]
				[Address(RVA = "0xA5534C", Offset = "0xA5534C", VA = "0xA5534C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000012")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000084")]
				[Address(RVA = "0xA55394", Offset = "0xA55394", VA = "0xA55394", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600007F")]
			[Address(RVA = "0xA54F48", Offset = "0xA54F48", VA = "0xA54F48")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000080")]
			[Address(RVA = "0xA5523C", Offset = "0xA5523C", VA = "0xA5523C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000081")]
			[Address(RVA = "0xA55240", Offset = "0xA55240", VA = "0xA55240", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000083")]
			[Address(RVA = "0xA55354", Offset = "0xA55354", VA = "0xA55354", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xA54C84", Offset = "0xA54C84", VA = "0xA54C84")]
		private void Awake()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xA54D9C", Offset = "0xA54D9C", VA = "0xA54D9C")]
		[IteratorStateMachine(typeof(<Activate>d__5))]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xA54E10", Offset = "0xA54E10", VA = "0xA54E10")]
		[IteratorStateMachine(typeof(<Deactivate>d__6))]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xA54E84", Offset = "0xA54E84", VA = "0xA54E84")]
		[IteratorStateMachine(typeof(<ReloadLevel>d__7))]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xA54F70", Offset = "0xA54F70", VA = "0xA54F70")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xA5539C", Offset = "0xA5539C", VA = "0xA5539C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xA553EC", Offset = "0xA553EC", VA = "0xA553EC")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xA5547C", Offset = "0xA5547C", VA = "0xA5547C")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200002B")]
		public class WaypointList
		{
			[Token(Token = "0x40000A8")]
			[FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x40000A9")]
			[FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x6000094")]
			[Address(RVA = "0xA55F9C", Offset = "0xA55F9C", VA = "0xA55F9C")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x200002C")]
		public struct RoutePoint
		{
			[Token(Token = "0x40000AA")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40000AB")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x6000095")]
			[Address(RVA = "0xA55B78", Offset = "0xA55B78", VA = "0xA55B78")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000013")]
		public float Length
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xA5548C", Offset = "0xA5548C", VA = "0xA5548C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xA55494", Offset = "0xA55494", VA = "0xA55494")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xA5549C", Offset = "0xA5549C", VA = "0xA5549C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xA554B8", Offset = "0xA554B8", VA = "0xA554B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xA557E8", Offset = "0xA557E8", VA = "0xA557E8")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xA55918", Offset = "0xA55918", VA = "0xA55918")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xA55B88", Offset = "0xA55B88", VA = "0xA55B88")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xA55508", Offset = "0xA55508", VA = "0xA55508")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xA55C94", Offset = "0xA55C94", VA = "0xA55C94")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xA55F14", Offset = "0xA55F14", VA = "0xA55F14")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xA55C9C", Offset = "0xA55C9C", VA = "0xA55C9C")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xA55F1C", Offset = "0xA55F1C", VA = "0xA55F1C")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x200002E")]
		public enum ProgressStyle
		{
			[Token(Token = "0x40000BC")]
			SmoothAlongRoute,
			[Token(Token = "0x40000BD")]
			PointToPoint
		}

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000015")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0xA56000", Offset = "0xA56000", VA = "0xA56000")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0xA56014", Offset = "0xA56014", VA = "0xA56014")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0xA56028", Offset = "0xA56028", VA = "0xA56028")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0xA5603C", Offset = "0xA5603C", VA = "0xA5603C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0xA56050", Offset = "0xA56050", VA = "0xA56050")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600009B")]
			[Address(RVA = "0xA56064", Offset = "0xA56064", VA = "0xA56064")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xA56078", Offset = "0xA56078", VA = "0xA56078")]
		private void Start()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xA56174", Offset = "0xA56174", VA = "0xA56174")]
		public void Reset()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xA56240", Offset = "0xA56240", VA = "0xA56240")]
		private void Update()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xA56718", Offset = "0xA56718", VA = "0xA56718")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xA56874", Offset = "0xA56874", VA = "0xA56874")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x200002F")]
	[RequireComponent(typeof(SphereCollider))]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xA56890", Offset = "0xA56890", VA = "0xA56890")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xA56968", Offset = "0xA56968", VA = "0xA56968")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xA56ED4", Offset = "0xA56ED4", VA = "0xA56ED4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xA57424", Offset = "0xA57424", VA = "0xA57424")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000C8")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000C9")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000CA")]
			[FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x40000CB")]
			[FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x17000018")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000AB")]
				[Address(RVA = "0xA57B58", Offset = "0xA57B58", VA = "0xA57B58", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000019")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000AD")]
				[Address(RVA = "0xA57BA0", Offset = "0xA57BA0", VA = "0xA57BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000A8")]
			[Address(RVA = "0xA574AC", Offset = "0xA574AC", VA = "0xA574AC")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60000A9")]
			[Address(RVA = "0xA57628", Offset = "0xA57628", VA = "0xA57628", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000AA")]
			[Address(RVA = "0xA5762C", Offset = "0xA5762C", VA = "0xA5762C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000AC")]
			[Address(RVA = "0xA57B60", Offset = "0xA57B60", VA = "0xA57B60", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xA57438", Offset = "0xA57438", VA = "0xA57438")]
		[IteratorStateMachine(typeof(<Start>d__4))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xA574D4", Offset = "0xA574D4", VA = "0xA574D4")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xA57620", Offset = "0xA57620", VA = "0xA57620")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000CD")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000CE")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000CF")]
			[FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x1700001A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000B3")]
				[Address(RVA = "0xA5803C", Offset = "0xA5803C", VA = "0xA5803C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000B5")]
				[Address(RVA = "0xA58084", Offset = "0xA58084", VA = "0xA58084", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0xA57C1C", Offset = "0xA57C1C", VA = "0xA57C1C")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60000B1")]
			[Address(RVA = "0xA57C54", Offset = "0xA57C54", VA = "0xA57C54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000B2")]
			[Address(RVA = "0xA57C58", Offset = "0xA57C58", VA = "0xA57C58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000B4")]
			[Address(RVA = "0xA58044", Offset = "0xA58044", VA = "0xA58044", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xA57BA8", Offset = "0xA57BA8", VA = "0xA57BA8")]
		[IteratorStateMachine(typeof(<Start>d__1))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xA57C44", Offset = "0xA57C44", VA = "0xA57C44")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class <OnCollisionEnter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000D7")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000D8")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000D9")]
			[FieldOffset(Offset = "0x20")]
			public Explosive <>4__this;

			[Token(Token = "0x40000DA")]
			[FieldOffset(Offset = "0x28")]
			public Collision col;

			[Token(Token = "0x1700001C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000BD")]
				[Address(RVA = "0xA58540", Offset = "0xA58540", VA = "0xA58540", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000BF")]
				[Address(RVA = "0xA58588", Offset = "0xA58588", VA = "0xA58588", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0xA58174", Offset = "0xA58174", VA = "0xA58174")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60000BB")]
			[Address(RVA = "0xA581C8", Offset = "0xA581C8", VA = "0xA581C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000BC")]
			[Address(RVA = "0xA581CC", Offset = "0xA581CC", VA = "0xA581CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000BE")]
			[Address(RVA = "0xA58548", Offset = "0xA58548", VA = "0xA58548", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x18")]
		public Transform explosionPrefab;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x20")]
		public float detonationImpactVelocity;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x24")]
		public float sizeMultiplier;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x28")]
		public bool reset;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x2C")]
		public float resetTimeDelay;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x30")]
		private bool m_Exploded;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x38")]
		private ObjectResetter m_ObjectResetter;

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xA5808C", Offset = "0xA5808C", VA = "0xA5808C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xA580E4", Offset = "0xA580E4", VA = "0xA580E4")]
		[IteratorStateMachine(typeof(<OnCollisionEnter>d__8))]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xA5819C", Offset = "0xA5819C", VA = "0xA5819C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xA581A4", Offset = "0xA581A4", VA = "0xA581A4")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xA58590", Offset = "0xA58590", VA = "0xA58590")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xA585E8", Offset = "0xA585E8", VA = "0xA585E8")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xA58660", Offset = "0xA58660", VA = "0xA58660")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xA58670", Offset = "0xA58670", VA = "0xA58670")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xA586E0", Offset = "0xA586E0", VA = "0xA586E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xA588C8", Offset = "0xA588C8", VA = "0xA588C8")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xA588F0", Offset = "0xA588F0", VA = "0xA588F0")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xA58900", Offset = "0xA58900", VA = "0xA58900")]
		private void Update()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xA58A48", Offset = "0xA58A48", VA = "0xA58A48")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xA58A64", Offset = "0xA58A64", VA = "0xA58A64")]
		private void Start()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xA58B90", Offset = "0xA58B90", VA = "0xA58B90")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xA58BA0", Offset = "0xA58BA0", VA = "0xA58BA0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xA58C50", Offset = "0xA58C50", VA = "0xA58C50")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x20")]
		private ParticleCollisionEvent[] m_CollisionEvents;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xA58C58", Offset = "0xA58C58", VA = "0xA58C58")]
		private void Start()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xA58CB0", Offset = "0xA58CB0", VA = "0xA58CB0")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xA58EDC", Offset = "0xA58EDC", VA = "0xA58EDC")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x200003C")]
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xA58F48", Offset = "0xA58F48", VA = "0xA58F48")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xA59144", Offset = "0xA59144", VA = "0xA59144")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[RequireComponent(typeof(WaterBase))]
	[ExecuteInEditMode]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xA5914C", Offset = "0xA5914C", VA = "0xA5914C")]
		public void Awake()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xA5916C", Offset = "0xA5916C", VA = "0xA5916C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xA591D0", Offset = "0xA591D0", VA = "0xA591D0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xA59234", Offset = "0xA59234", VA = "0xA59234")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xA5923C", Offset = "0xA5923C", VA = "0xA5923C")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class MeshContainer
	{
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xA59244", Offset = "0xA59244", VA = "0xA59244")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xA592B4", Offset = "0xA592B4", VA = "0xA592B4")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xA592EC", Offset = "0xA592EC", VA = "0xA592EC")]
		public void Start()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xA593E8", Offset = "0xA593E8", VA = "0xA593E8")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xA596F8", Offset = "0xA596F8", VA = "0xA596F8")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xA597AC", Offset = "0xA597AC", VA = "0xA597AC")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xA59904", Offset = "0xA59904", VA = "0xA59904")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xA5A178", Offset = "0xA5A178", VA = "0xA5A178")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xA5A1D0", Offset = "0xA5A1D0", VA = "0xA5A1D0")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xA5A2B0", Offset = "0xA5A2B0", VA = "0xA5A2B0")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xA5A314", Offset = "0xA5A314", VA = "0xA5A314")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xA59AC0", Offset = "0xA59AC0", VA = "0xA59AC0")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xA5A378", Offset = "0xA5A378", VA = "0xA5A378")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xA5A62C", Offset = "0xA5A62C", VA = "0xA5A62C")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xA5A3D8", Offset = "0xA5A3D8", VA = "0xA5A3D8")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xA5A798", Offset = "0xA5A798", VA = "0xA5A798")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xA5A47C", Offset = "0xA5A47C", VA = "0xA5A47C")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xA5A7B8", Offset = "0xA5A7B8", VA = "0xA5A7B8")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xA5A828", Offset = "0xA5A828", VA = "0xA5A828")]
		public void Start()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xA5A950", Offset = "0xA5A950", VA = "0xA5A950")]
		public void Update()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xA5AB68", Offset = "0xA5AB68", VA = "0xA5AB68")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x2000043")]
		public enum WaterMode
		{
			[Token(Token = "0x4000109")]
			Simple,
			[Token(Token = "0x400010A")]
			Reflective,
			[Token(Token = "0x400010B")]
			Refractive
		}

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xA5AB70", Offset = "0xA5AB70", VA = "0xA5AB70")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xA5C2F8", Offset = "0xA5C2F8", VA = "0xA5C2F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xA5C660", Offset = "0xA5C660", VA = "0xA5C660")]
		private void Update()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xA5BE78", Offset = "0xA5BE78", VA = "0xA5BE78")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xA5B50C", Offset = "0xA5B50C", VA = "0xA5B50C")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xA5B4F8", Offset = "0xA5B4F8", VA = "0xA5B4F8")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xA5B38C", Offset = "0xA5B38C", VA = "0xA5B38C")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xA5C148", Offset = "0xA5C148", VA = "0xA5C148")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xA5C0B4", Offset = "0xA5C0B4", VA = "0xA5C0B4")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xA5C90C", Offset = "0xA5C90C", VA = "0xA5C90C")]
		public Water()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public enum WaterQuality
	{
		[Token(Token = "0x400010D")]
		High = 2,
		[Token(Token = "0x400010E")]
		Medium = 1,
		[Token(Token = "0x400010F")]
		Low = 0
	}
	[Token(Token = "0x2000045")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xA5CA0C", Offset = "0xA5CA0C", VA = "0xA5CA0C")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xA5CB84", Offset = "0xA5CB84", VA = "0xA5CB84")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xA5CC28", Offset = "0xA5CC28", VA = "0xA5CC28")]
		public void Update()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xA5CC9C", Offset = "0xA5CC9C", VA = "0xA5CC9C")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xA5CCB4", Offset = "0xA5CCB4", VA = "0xA5CCB4")]
		public void Start()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xA5CCB8", Offset = "0xA5CCB8", VA = "0xA5CCB8")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xA5CE78", Offset = "0xA5CE78", VA = "0xA5CE78")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xA5CF5C", Offset = "0xA5CF5C", VA = "0xA5CF5C")]
		public WaterTile()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000047")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xA5CF64", Offset = "0xA5CF64", VA = "0xA5CF64")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xA5D1EC", Offset = "0xA5D1EC", VA = "0xA5D1EC")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xA5D370", Offset = "0xA5D370", VA = "0xA5D370")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xA5D3E0", Offset = "0xA5D3E0", VA = "0xA5D3E0", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xA5D4AC", Offset = "0xA5D4AC", VA = "0xA5D4AC", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xA5D510", Offset = "0xA5D510", VA = "0xA5D510")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xA5D57C", Offset = "0xA5D57C", VA = "0xA5D57C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xA5D580", Offset = "0xA5D580", VA = "0xA5D580")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xA5D648", Offset = "0xA5D648", VA = "0xA5D648")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xA5D710", Offset = "0xA5D710", VA = "0xA5D710")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xA5D7D8", Offset = "0xA5D7D8", VA = "0xA5D7D8")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xA5D8A0", Offset = "0xA5D8A0", VA = "0xA5D8A0")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xA5D968", Offset = "0xA5D968", VA = "0xA5D968")]
		public void Update()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xA5D96C", Offset = "0xA5D96C", VA = "0xA5D96C")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200004A")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x4000120")]
			Hardware,
			[Token(Token = "0x4000121")]
			Touch
		}

		[Token(Token = "0x200004B")]
		public class VirtualAxis
		{
			[Token(Token = "0x4000123")]
			[FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x1700001F")]
			public string name
			{
				[Token(Token = "0x6000125")]
				[Address(RVA = "0xA5E6F4", Offset = "0xA5E6F4", VA = "0xA5E6F4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000126")]
				[Address(RVA = "0xA5E6FC", Offset = "0xA5E6FC", VA = "0xA5E6FC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000020")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000127")]
				[Address(RVA = "0xA5E704", Offset = "0xA5E704", VA = "0xA5E704")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000128")]
				[Address(RVA = "0xA5E70C", Offset = "0xA5E70C", VA = "0xA5E70C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000021")]
			public float GetValue
			{
				[Token(Token = "0x600012D")]
				[Address(RVA = "0xA5E760", Offset = "0xA5E760", VA = "0xA5E760")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000022")]
			public float GetValueRaw
			{
				[Token(Token = "0x600012E")]
				[Address(RVA = "0xA5E768", Offset = "0xA5E768", VA = "0xA5E768")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000129")]
			[Address(RVA = "0xA5D0E0", Offset = "0xA5D0E0", VA = "0xA5D0E0")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x600012A")]
			[Address(RVA = "0xA5E718", Offset = "0xA5E718", VA = "0xA5E718")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600012B")]
			[Address(RVA = "0xA5D388", Offset = "0xA5D388", VA = "0xA5D388")]
			public void Remove()
			{
			}

			[Token(Token = "0x600012C")]
			[Address(RVA = "0xA5E758", Offset = "0xA5E758", VA = "0xA5E758")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x200004C")]
		public class VirtualButton
		{
			[Token(Token = "0x4000127")]
			[FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x4000128")]
			[FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000129")]
			[FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x17000023")]
			public string name
			{
				[Token(Token = "0x600012F")]
				[Address(RVA = "0xA5E770", Offset = "0xA5E770", VA = "0xA5E770")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000130")]
				[Address(RVA = "0xA5E778", Offset = "0xA5E778", VA = "0xA5E778")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000131")]
				[Address(RVA = "0xA5E780", Offset = "0xA5E780", VA = "0xA5E780")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000132")]
				[Address(RVA = "0xA5E788", Offset = "0xA5E788", VA = "0xA5E788")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public bool GetButton
			{
				[Token(Token = "0x6000138")]
				[Address(RVA = "0xA5E8C4", Offset = "0xA5E8C4", VA = "0xA5E8C4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000026")]
			public bool GetButtonDown
			{
				[Token(Token = "0x6000139")]
				[Address(RVA = "0xA5E8CC", Offset = "0xA5E8CC", VA = "0xA5E8CC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000027")]
			public bool GetButtonUp
			{
				[Token(Token = "0x600013A")]
				[Address(RVA = "0xA5E8F0", Offset = "0xA5E8F0", VA = "0xA5E8F0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000133")]
			[Address(RVA = "0xA5E794", Offset = "0xA5E794", VA = "0xA5E794")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x6000134")]
			[Address(RVA = "0xA5E7D8", Offset = "0xA5E7D8", VA = "0xA5E7D8")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000135")]
			[Address(RVA = "0xA5E820", Offset = "0xA5E820", VA = "0xA5E820")]
			public void Pressed()
			{
			}

			[Token(Token = "0x6000136")]
			[Address(RVA = "0xA5E84C", Offset = "0xA5E84C", VA = "0xA5E84C")]
			public void Released()
			{
			}

			[Token(Token = "0x6000137")]
			[Address(RVA = "0xA5E86C", Offset = "0xA5E86C", VA = "0xA5E86C")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x1700001E")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0xA5E520", Offset = "0xA5E520", VA = "0xA5E520")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xA5D974", Offset = "0xA5D974", VA = "0xA5D974")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xA5DA4C", Offset = "0xA5DA4C", VA = "0xA5DA4C")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xA5D078", Offset = "0xA5D078", VA = "0xA5D078")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xA5DB48", Offset = "0xA5DB48", VA = "0xA5DB48")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xA5D11C", Offset = "0xA5D11C", VA = "0xA5D11C")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xA5DDA0", Offset = "0xA5DDA0", VA = "0xA5DDA0")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xA5DFA0", Offset = "0xA5DFA0", VA = "0xA5DFA0")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xA5E0E8", Offset = "0xA5E0E8", VA = "0xA5E0E8")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xA5D184", Offset = "0xA5D184", VA = "0xA5D184")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xA548C0", Offset = "0xA548C0", VA = "0xA548C0")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xA5E2F4", Offset = "0xA5E2F4", VA = "0xA5E2F4")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xA5E274", Offset = "0xA5E274", VA = "0xA5E274")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xA5E34C", Offset = "0xA5E34C", VA = "0xA5E34C")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xA5E3BC", Offset = "0xA5E3BC", VA = "0xA5E3BC")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xA5E42C", Offset = "0xA5E42C", VA = "0xA5E42C")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xA5D5D8", Offset = "0xA5D5D8", VA = "0xA5D5D8")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xA5D6A0", Offset = "0xA5D6A0", VA = "0xA5D6A0")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xA5D768", Offset = "0xA5D768", VA = "0xA5D768")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xA5D8F8", Offset = "0xA5D8F8", VA = "0xA5D8F8")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xA5D830", Offset = "0xA5D830", VA = "0xA5D830")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xA5E49C", Offset = "0xA5E49C", VA = "0xA5E49C")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xA5E58C", Offset = "0xA5E58C", VA = "0xA5E58C")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xA5E604", Offset = "0xA5E604", VA = "0xA5E604")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xA5E67C", Offset = "0xA5E67C", VA = "0xA5E67C")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xA5E914", Offset = "0xA5E914", VA = "0xA5E914")]
		private void Update()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xA5E918", Offset = "0xA5E918", VA = "0xA5E918")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xA5E988", Offset = "0xA5E988", VA = "0xA5E988")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x200004F")]
		public enum AxisOption
		{
			[Token(Token = "0x4000135")]
			Both,
			[Token(Token = "0x4000136")]
			OnlyHorizontal,
			[Token(Token = "0x4000137")]
			OnlyVertical
		}

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xA5E990", Offset = "0xA5E990", VA = "0xA5E990")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xA5EAF4", Offset = "0xA5EAF4", VA = "0xA5EAF4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xA5EB24", Offset = "0xA5EB24", VA = "0xA5EB24")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xA5E994", Offset = "0xA5E994", VA = "0xA5E994")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xA5EB84", Offset = "0xA5EB84", VA = "0xA5EB84", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xA5ECD0", Offset = "0xA5ECD0", VA = "0xA5ECD0", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xA5ED0C", Offset = "0xA5ED0C", VA = "0xA5ED0C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xA5ED10", Offset = "0xA5ED10", VA = "0xA5ED10")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xA5ED50", Offset = "0xA5ED50", VA = "0xA5ED50")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x6000147")]
		[Address(RVA = "0xA5EDDC", Offset = "0xA5EDDC", VA = "0xA5EDDC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xA5EDEC", Offset = "0xA5EDEC", VA = "0xA5EDEC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xA5EDE4", Offset = "0xA5EDE4", VA = "0xA5EDE4")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xA5EEF4", Offset = "0xA5EEF4", VA = "0xA5EEF4")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xA5F1EC", Offset = "0xA5F1EC", VA = "0xA5F1EC")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000052")]
		public enum AxisOptions
		{
			[Token(Token = "0x400013E")]
			ForwardAxis,
			[Token(Token = "0x400013F")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x2000053")]
		public class AxisMapping
		{
			[Token(Token = "0x2000054")]
			public enum MappingType
			{
				[Token(Token = "0x4000143")]
				NamedAxis,
				[Token(Token = "0x4000144")]
				MousePositionX,
				[Token(Token = "0x4000145")]
				MousePositionY,
				[Token(Token = "0x4000146")]
				MousePositionZ
			}

			[Token(Token = "0x4000140")]
			[FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x4000141")]
			[FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000150")]
			[Address(RVA = "0xA5F548", Offset = "0xA5F548", VA = "0xA5F548")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xA5F1F4", Offset = "0xA5F1F4", VA = "0xA5F1F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xA5F2D0", Offset = "0xA5F2D0", VA = "0xA5F2D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xA5F520", Offset = "0xA5F520", VA = "0xA5F520")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xA5F538", Offset = "0xA5F538", VA = "0xA5F538")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000056")]
		public enum AxisOption
		{
			[Token(Token = "0x400015A")]
			Both,
			[Token(Token = "0x400015B")]
			OnlyHorizontal,
			[Token(Token = "0x400015C")]
			OnlyVertical
		}

		[Token(Token = "0x2000057")]
		public enum ControlStyle
		{
			[Token(Token = "0x400015E")]
			Absolute,
			[Token(Token = "0x400015F")]
			Relative,
			[Token(Token = "0x4000160")]
			Swipe
		}

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xA5F550", Offset = "0xA5F550", VA = "0xA5F550")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xA5F6B4", Offset = "0xA5F6B4", VA = "0xA5F6B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xA5F554", Offset = "0xA5F554", VA = "0xA5F554")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xA5F73C", Offset = "0xA5F73C", VA = "0xA5F73C")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xA5F83C", Offset = "0xA5F83C", VA = "0xA5F83C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xA5F874", Offset = "0xA5F874", VA = "0xA5F874")]
		private void Update()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xA5FA4C", Offset = "0xA5FA4C", VA = "0xA5FA4C", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xA5FAAC", Offset = "0xA5FAAC", VA = "0xA5FAAC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xA5FB6C", Offset = "0xA5FB6C", VA = "0xA5FB6C")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x17000028")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0xA5FC00", Offset = "0xA5FC00", VA = "0xA5FC00")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0xA5FC0C", Offset = "0xA5FC0C", VA = "0xA5FC0C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xA5DAF0", Offset = "0xA5DAF0", VA = "0xA5DAF0")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xA5DBB0", Offset = "0xA5DBB0", VA = "0xA5DBB0")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xA5DC08", Offset = "0xA5DC08", VA = "0xA5DC08")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xA5DE08", Offset = "0xA5DE08", VA = "0xA5DE08")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xA5E058", Offset = "0xA5E058", VA = "0xA5E058")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xA5E150", Offset = "0xA5E150", VA = "0xA5E150")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xA5E1E0", Offset = "0xA5E1E0", VA = "0xA5E1E0")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xA5E5FC", Offset = "0xA5E5FC", VA = "0xA5E5FC")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xA5E674", Offset = "0xA5E674", VA = "0xA5E674")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xA5E6EC", Offset = "0xA5E6EC", VA = "0xA5E6EC")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x6000166")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x6000167")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x6000168")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x6000169")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x600016A")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x600016B")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x600016C")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x600016D")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x600016E")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x600016F")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000170")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xA5FC18", Offset = "0xA5FC18", VA = "0xA5FC18")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000059")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x6000172")]
		[Address(RVA = "0xA5FD40", Offset = "0xA5FD40", VA = "0xA5FD40")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xA5FDF0", Offset = "0xA5FDF0", VA = "0xA5FDF0")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xA5FE98", Offset = "0xA5FE98", VA = "0xA5FE98", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xA5FF30", Offset = "0xA5FF30", VA = "0xA5FF30", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xA5FFE4", Offset = "0xA5FFE4", VA = "0xA5FFE4", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xA6008C", Offset = "0xA6008C", VA = "0xA6008C", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xA60128", Offset = "0xA60128", VA = "0xA60128", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xA601C4", Offset = "0xA601C4", VA = "0xA601C4", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xA6025C", Offset = "0xA6025C", VA = "0xA6025C", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xA60300", Offset = "0xA60300", VA = "0xA60300", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xA603AC", Offset = "0xA603AC", VA = "0xA603AC", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xA60458", Offset = "0xA60458", VA = "0xA60458", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xA604F0", Offset = "0xA604F0", VA = "0xA604F0", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xA5DA44", Offset = "0xA5DA44", VA = "0xA5DA44")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000180")]
		[Address(RVA = "0xA604FC", Offset = "0xA604FC", VA = "0xA604FC", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xA60510", Offset = "0xA60510", VA = "0xA60510", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xA6051C", Offset = "0xA6051C", VA = "0xA6051C", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xA60528", Offset = "0xA60528", VA = "0xA60528", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xA60534", Offset = "0xA60534", VA = "0xA60534", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xA60584", Offset = "0xA60584", VA = "0xA60584", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xA605D4", Offset = "0xA605D4", VA = "0xA605D4", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xA60624", Offset = "0xA60624", VA = "0xA60624", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xA60674", Offset = "0xA60674", VA = "0xA60674", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xA606C4", Offset = "0xA606C4", VA = "0xA606C4", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xA60714", Offset = "0xA60714", VA = "0xA60714", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xA5DA48", Offset = "0xA5DA48", VA = "0xA5DA48")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[Token(Token = "0x200005B")]
	[RequireComponent(typeof(ThirdPersonCharacter))]
	[RequireComponent(typeof(NavMeshAgent))]
	public class AICharacterControl : MonoBehaviour
	{
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x17000029")]
		public NavMeshAgent agent
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0xA6071C", Offset = "0xA6071C", VA = "0xA6071C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600018D")]
			[Address(RVA = "0xA60724", Offset = "0xA60724", VA = "0xA60724")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public ThirdPersonCharacter character
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0xA6072C", Offset = "0xA6072C", VA = "0xA6072C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0xA60734", Offset = "0xA60734", VA = "0xA60734")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xA6073C", Offset = "0xA6073C", VA = "0xA6073C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xA607FC", Offset = "0xA607FC", VA = "0xA607FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xA60B80", Offset = "0xA60B80", VA = "0xA60B80")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xA60B88", Offset = "0xA60B88", VA = "0xA60B88")]
		public AICharacterControl()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Animator))]
	[RequireComponent(typeof(CapsuleCollider))]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovingTurnSpeed;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_StationaryTurnSpeed;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(1f, 4f)]
		private float m_GravityMultiplier;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_RunCycleLegOffset;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MoveSpeedMultiplier;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_AnimSpeedMultiplier;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_GroundCheckDistance;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x40")]
		private Animator m_Animator;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x48")]
		private bool m_IsGrounded;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x4C")]
		private float m_OrigGroundCheckDistance;

		[Token(Token = "0x4000174")]
		private const float k_Half = 0.5f;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x50")]
		private float m_TurnAmount;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x54")]
		private float m_ForwardAmount;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 m_GroundNormal;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x64")]
		private float m_CapsuleHeight;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 m_CapsuleCenter;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x78")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x80")]
		private bool m_Crouching;

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xA60B90", Offset = "0xA60B90", VA = "0xA60B90")]
		private void Start()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xA60924", Offset = "0xA60924", VA = "0xA60924")]
		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xA61060", Offset = "0xA61060", VA = "0xA61060")]
		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xA61280", Offset = "0xA61280", VA = "0xA61280")]
		private void PreventStandingInLowHeadroom()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xA61400", Offset = "0xA61400", VA = "0xA61400")]
		private void UpdateAnimator(Vector3 move)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xA60FC8", Offset = "0xA60FC8", VA = "0xA60FC8")]
		private void HandleAirborneMovement()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xA60EAC", Offset = "0xA60EAC", VA = "0xA60EAC")]
		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xA60E28", Offset = "0xA60E28", VA = "0xA60E28")]
		private void ApplyExtraTurnRotation()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xA616C0", Offset = "0xA616C0", VA = "0xA616C0")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xA60CA4", Offset = "0xA60CA4", VA = "0xA60CA4")]
		private void CheckGroundStatus()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xA61760", Offset = "0xA61760", VA = "0xA61760")]
		public ThirdPersonCharacter()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[RequireComponent(typeof(ThirdPersonCharacter))]
	public class ThirdPersonUserControl : MonoBehaviour
	{
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x18")]
		private ThirdPersonCharacter m_Character;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x20")]
		private Transform m_Cam;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 m_CamForward;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 m_Move;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x40")]
		private bool m_Jump;

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xA61780", Offset = "0xA61780", VA = "0xA61780")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xA61890", Offset = "0xA61890", VA = "0xA61890")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xA6190C", Offset = "0xA6190C", VA = "0xA6190C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xA61BFC", Offset = "0xA61BFC", VA = "0xA61BFC")]
		public ThirdPersonUserControl()
		{
		}
	}
}
namespace VLB
{
	[Token(Token = "0x200005E")]
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
	{
		[Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class <CoUpdateFadeOut>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400018B")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400018C")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400018D")]
			[FieldOffset(Offset = "0x20")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x17000036")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0xA64E60", Offset = "0xA64E60", VA = "0xA64E60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000037")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0xA64EA8", Offset = "0xA64EA8", VA = "0xA64EA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0xA64D6C", Offset = "0xA64D6C", VA = "0xA64D6C")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x60001D1")]
			[Address(RVA = "0xA64D94", Offset = "0xA64D94", VA = "0xA64D94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D2")]
			[Address(RVA = "0xA64D98", Offset = "0xA64D98", VA = "0xA64D98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D4")]
			[Address(RVA = "0xA64E68", Offset = "0xA64E68", VA = "0xA64E68", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x18")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x20")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x60")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x68")]
		private Material m_CustomMaterial;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x70")]
		private MaterialModifier.Callback m_MaterialModifierCallback;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x78")]
		private Coroutine m_CoFadeOut;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x98")]
		private Camera m_CurrentCameraRenderingSRP;

		[Token(Token = "0x1700002B")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0xA61C04", Offset = "0xA61C04", VA = "0xA61C04")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0xA61C0C", Offset = "0xA61C0C", VA = "0xA61C0C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0xA61C14", Offset = "0xA61C14", VA = "0xA61C14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0xA61C1C", Offset = "0xA61C1C", VA = "0xA61C1C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public Mesh coneMesh
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0xA61C24", Offset = "0xA61C24", VA = "0xA61C24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0xA61C2C", Offset = "0xA61C2C", VA = "0xA61C2C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public bool visible
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xA61C34", Offset = "0xA61C34", VA = "0xA61C34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0xA61C50", Offset = "0xA61C50", VA = "0xA61C50")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public int sortingLayerID
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0xA61C70", Offset = "0xA61C70", VA = "0xA61C70")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0xA61C8C", Offset = "0xA61C8C", VA = "0xA61C8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public int sortingOrder
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0xA61CA8", Offset = "0xA61CA8", VA = "0xA61CA8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0xA61CC4", Offset = "0xA61CC4", VA = "0xA61CC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xA61CE0", Offset = "0xA61CE0", VA = "0xA61CE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000032")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xA624AC", Offset = "0xA624AC", VA = "0xA624AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000033")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xA624B4", Offset = "0xA624B4", VA = "0xA624B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000034")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xA631E0", Offset = "0xA631E0", VA = "0xA631E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xA6322C", Offset = "0xA6322C", VA = "0xA6322C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xA61CF0", Offset = "0xA61CF0", VA = "0xA61CF0")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xA61DF8", Offset = "0xA61DF8", VA = "0xA61DF8")]
		[IteratorStateMachine(typeof(<CoUpdateFadeOut>d__30))]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xA61E6C", Offset = "0xA61E6C", VA = "0xA61E6C")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xA61F04", Offset = "0xA61F04", VA = "0xA61F04")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xA62214", Offset = "0xA62214", VA = "0xA62214")]
		public void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xA622E8", Offset = "0xA622E8", VA = "0xA622E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xA62384", Offset = "0xA62384", VA = "0xA62384")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xA62420", Offset = "0xA62420", VA = "0xA62420")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xA624FC", Offset = "0xA624FC", VA = "0xA624FC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xA62580", Offset = "0xA62580", VA = "0xA62580")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xA62A54", Offset = "0xA62A54", VA = "0xA62A54")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xA63180", Offset = "0xA63180", VA = "0xA63180")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xA628B0", Offset = "0xA628B0", VA = "0xA628B0")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xA62074", Offset = "0xA62074", VA = "0xA62074", Slot = "4")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xA63268", Offset = "0xA63268", VA = "0xA63268", Slot = "5")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xA63380", Offset = "0xA63380", VA = "0xA63380", Slot = "6")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xA63498", Offset = "0xA63498", VA = "0xA63498", Slot = "7")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xA635C8", Offset = "0xA635C8", VA = "0xA635C8", Slot = "8")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xA61FBC", Offset = "0xA61FBC", VA = "0xA61FBC")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xA6215C", Offset = "0xA6215C", VA = "0xA6215C")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xA636A4", Offset = "0xA636A4", VA = "0xA636A4")]
		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xA62CE0", Offset = "0xA62CE0", VA = "0xA62CE0")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xA6377C", Offset = "0xA6377C", VA = "0xA6377C")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xA6389C", Offset = "0xA6389C", VA = "0xA6389C")]
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xA638A8", Offset = "0xA638A8", VA = "0xA638A8")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xA638D8", Offset = "0xA638D8", VA = "0xA638D8")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xA639AC", Offset = "0xA639AC", VA = "0xA639AC")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xA63D64", Offset = "0xA63D64", VA = "0xA63D64")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x2C")]
		public RenderPipeline renderPipeline;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x30")]
		[Obsolete("Use 'renderingMode' instead")]
		public bool forceSinglePass;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x34")]
		public RenderingMode renderingMode;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x38")]
		[HighlightNull]
		[SerializeField]
		private Shader beamShader1Pass;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HighlightNull]
		[FormerlySerializedAs("BeamShader")]
		[FormerlySerializedAs("beamShader")]
		private Shader beamShader2Pass;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x48")]
		[HighlightNull]
		[SerializeField]
		private Shader beamShaderSRP;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x50")]
		public int sharedMeshSides;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x54")]
		public int sharedMeshSegments;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x58")]
		[Range(0.01f, 2f)]
		public float globalNoiseScale;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x5C")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x68")]
		public string fadeOutCameraTag;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x70")]
		[HighlightNull]
		public TextAsset noise3DData;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x78")]
		public int noise3DSize;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x80")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x90")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x40001A2")]
		private const string kAssetName = "Config";

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x0")]
		private static Config m_Instance;

		[Token(Token = "0x17000038")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0xA64EB0", Offset = "0xA64EB0", VA = "0xA64EB0")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000039")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0xA64EB8", Offset = "0xA64EB8", VA = "0xA64EB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003A")]
		public Shader beamShader
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0xA64EC8", Offset = "0xA64EC8", VA = "0xA64EC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0xA64F3C", Offset = "0xA64F3C", VA = "0xA64F3C")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x1700003C")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xA64F48", Offset = "0xA64F48", VA = "0xA64F48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public static Config Instance
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xA65094", Offset = "0xA65094", VA = "0xA65094")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xA64FBC", Offset = "0xA64FBC", VA = "0xA64FBC")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xA6505C", Offset = "0xA6505C", VA = "0xA6505C")]
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xA64F18", Offset = "0xA64F18", VA = "0xA64F18")]
		private static bool ShouldEnableSrpApi(RenderPipeline pipeline)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xA6509C", Offset = "0xA6509C", VA = "0xA6509C")]
		public static void OnRenderPipelineChanged(RenderPipeline pipeline)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xA65124", Offset = "0xA65124", VA = "0xA65124")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xA651F4", Offset = "0xA651F4", VA = "0xA651F4")]
		public void ResetInternalData()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xA6543C", Offset = "0xA6543C", VA = "0xA6543C")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xA65640", Offset = "0xA65640", VA = "0xA65640")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xA6566C", Offset = "0xA6566C", VA = "0xA6566C")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xA65714", Offset = "0xA65714", VA = "0xA65714")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xA65850", Offset = "0xA65850", VA = "0xA65850")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x40001A4")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xA6594C", Offset = "0xA6594C", VA = "0xA6594C")]
		public ConfigOverride()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public static class Consts
	{
		[Token(Token = "0x40001A5")]
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		[Token(Token = "0x40001A6")]
		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		[Token(Token = "0x40001A7")]
		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		[Token(Token = "0x40001A8")]
		public const string HelpUrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/";

		[Token(Token = "0x40001A9")]
		public const string HelpUrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/";

		[Token(Token = "0x40001AA")]
		public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

		[Token(Token = "0x40001AB")]
		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly bool ProceduralObjectsVisibleInEditor;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x4")]
		public static readonly Color FlatColor;

		[Token(Token = "0x40001AE")]
		public const ColorMode ColorModeDefault = ColorMode.Flat;

		[Token(Token = "0x40001AF")]
		public const float IntensityDefault = 1f;

		[Token(Token = "0x40001B0")]
		public const float IntensityMin = 0f;

		[Token(Token = "0x40001B1")]
		public const float IntensityMax = 8f;

		[Token(Token = "0x40001B2")]
		public const float SpotAngleDefault = 35f;

		[Token(Token = "0x40001B3")]
		public const float SpotAngleMin = 0.1f;

		[Token(Token = "0x40001B4")]
		public const float SpotAngleMax = 179.9f;

		[Token(Token = "0x40001B5")]
		public const float ConeRadiusStart = 0.1f;

		[Token(Token = "0x40001B6")]
		public const MeshType GeomMeshType = MeshType.Shared;

		[Token(Token = "0x40001B7")]
		public const int GeomSidesDefault = 18;

		[Token(Token = "0x40001B8")]
		public const int GeomSidesMin = 3;

		[Token(Token = "0x40001B9")]
		public const int GeomSidesMax = 256;

		[Token(Token = "0x40001BA")]
		public const int GeomSegmentsDefault = 5;

		[Token(Token = "0x40001BB")]
		public const int GeomSegmentsMin = 0;

		[Token(Token = "0x40001BC")]
		public const int GeomSegmentsMax = 64;

		[Token(Token = "0x40001BD")]
		public const bool GeomCap = false;

		[Token(Token = "0x40001BE")]
		public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

		[Token(Token = "0x40001BF")]
		public const float AttenuationCustomBlending = 0.5f;

		[Token(Token = "0x40001C0")]
		public const float FallOffStart = 0f;

		[Token(Token = "0x40001C1")]
		public const float FallOffEnd = 3f;

		[Token(Token = "0x40001C2")]
		public const float FallOffDistancesMinThreshold = 0.01f;

		[Token(Token = "0x40001C3")]
		public const float DepthBlendDistance = 2f;

		[Token(Token = "0x40001C4")]
		public const float CameraClippingDistance = 0.5f;

		[Token(Token = "0x40001C5")]
		public const float FresnelPowMaxValue = 10f;

		[Token(Token = "0x40001C6")]
		public const float FresnelPow = 8f;

		[Token(Token = "0x40001C7")]
		public const float GlareFrontal = 0.5f;

		[Token(Token = "0x40001C8")]
		public const float GlareBehind = 0.5f;

		[Token(Token = "0x40001C9")]
		public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

		[Token(Token = "0x40001CA")]
		public const float NoiseIntensityMin = 0f;

		[Token(Token = "0x40001CB")]
		public const float NoiseIntensityMax = 1f;

		[Token(Token = "0x40001CC")]
		public const float NoiseIntensityDefault = 0.5f;

		[Token(Token = "0x40001CD")]
		public const float NoiseScaleMin = 0.01f;

		[Token(Token = "0x40001CE")]
		public const float NoiseScaleMax = 2f;

		[Token(Token = "0x40001CF")]
		public const float NoiseScaleDefault = 0.5f;

		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x14")]
		public static readonly Vector3 NoiseVelocityDefault;

		[Token(Token = "0x40001D1")]
		public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

		[Token(Token = "0x40001D2")]
		public const float FadeOutBeginDefault = -150f;

		[Token(Token = "0x40001D3")]
		public const float FadeOutEndDefault = -200f;

		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x20")]
		public static readonly LayerMask DynOcclusionLayerMaskDefault;

		[Token(Token = "0x40001D5")]
		public const float DynOcclusionFadeDistanceToSurfaceDefault = 0.25f;

		[Token(Token = "0x40001D6")]
		public const DynamicOcclusionUpdateRate DynamicOcclusionUpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames;

		[Token(Token = "0x40001D7")]
		public const int DynOcclusionWaitFramesCountDefault = 3;

		[Token(Token = "0x40001D8")]
		public const OccluderDimensions DynOcclusionRaycastingDimensionsDefault = OccluderDimensions.Occluders3D;

		[Token(Token = "0x40001D9")]
		public const bool DynOcclusionRaycastingConsiderTriggersDefault = false;

		[Token(Token = "0x40001DA")]
		public const float DynOcclusionRaycastingMinOccluderAreaDefault = 0f;

		[Token(Token = "0x40001DB")]
		public const float DynOcclusionRaycastingMinSurfaceRatioDefault = 0.5f;

		[Token(Token = "0x40001DC")]
		public const float DynOcclusionRaycastingMinSurfaceRatioMin = 50f;

		[Token(Token = "0x40001DD")]
		public const float DynOcclusionRaycastingMinSurfaceRatioMax = 100f;

		[Token(Token = "0x40001DE")]
		public const float DynOcclusionRaycastingMaxSurfaceDotDefault = 0.25f;

		[Token(Token = "0x40001DF")]
		public const float DynOcclusionRaycastingMaxSurfaceAngleMin = 45f;

		[Token(Token = "0x40001E0")]
		public const float DynOcclusionRaycastingMaxSurfaceAngleMax = 90f;

		[Token(Token = "0x40001E1")]
		public const PlaneAlignment DynOcclusionRaycastingPlaneAlignmentDefault = PlaneAlignment.Surface;

		[Token(Token = "0x40001E2")]
		public const float DynOcclusionRaycastingPlaneOffsetDefault = 0.1f;

		[Token(Token = "0x40001E3")]
		public const int DynOcclusionDepthBufferDepthMapResolutionDefault = 32;

		[Token(Token = "0x40001E4")]
		public const bool DynOcclusionDepthBufferOcclusionCullingDefault = true;

		[Token(Token = "0x40001E5")]
		public const bool ConfigGeometryOverrideLayerDefault = true;

		[Token(Token = "0x40001E6")]
		public const int ConfigGeometryLayerIDDefault = 1;

		[Token(Token = "0x40001E7")]
		public const string ConfigGeometryTagDefault = "Untagged";

		[Token(Token = "0x40001E8")]
		public const string ConfigFadeOutCameraTagDefault = "MainCamera";

		[Token(Token = "0x40001E9")]
		public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

		[Token(Token = "0x40001EA")]
		public const RenderPipeline ConfigGeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

		[Token(Token = "0x40001EB")]
		public const RenderingMode ConfigGeometryRenderingModeDefault = RenderingMode.MultiPass;

		[Token(Token = "0x40001EC")]
		public const int ConfigNoise3DSizeDefault = 64;

		[Token(Token = "0x40001ED")]
		public const int ConfigSharedMeshSides = 24;

		[Token(Token = "0x40001EE")]
		public const int ConfigSharedMeshSegments = 5;

		[Token(Token = "0x1700003E")]
		public static HideFlags ProceduralObjectsHideFlags
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xA655DC", Offset = "0xA655DC", VA = "0xA655DC")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x2000063")]
	[DisallowMultipleComponent]
	[AddComponentMenu("")]
	[RequireComponent(typeof(VolumetricLightBeam))]
	public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x2000064")]
		protected enum ProcessOcclusionSource
		{
			[Token(Token = "0x40001F6")]
			RenderLoop,
			[Token(Token = "0x40001F7")]
			OnEnable,
			[Token(Token = "0x40001F8")]
			EditorUpdate,
			[Token(Token = "0x40001F9")]
			User
		}

		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x18")]
		public DynamicOcclusionUpdateRate updateRate;

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x1C")]
		[FormerlySerializedAs("waitFrameCount")]
		public int waitXFrames;

		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x0")]
		public static bool _INTERNAL_ApplyRandomFrameOffset;

		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x20")]
		private TransformUtils.Packed m_TransformPacked;

		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x28")]
		private int m_LastFrameRendered;

		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x30")]
		protected VolumetricLightBeam m_Master;

		[Token(Token = "0x1700003F")]
		public int _INTERNAL_LastFrameRendered
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xA65CBC", Offset = "0xA65CBC", VA = "0xA65CBC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xA659DC", Offset = "0xA659DC", VA = "0xA659DC")]
		public void ProcessOcclusionManually()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xA659E4", Offset = "0xA659E4", VA = "0xA659E4")]
		protected void ProcessOcclusion(ProcessOcclusionSource source)
		{
		}

		[Token(Token = "0x60001ED")]
		protected abstract string GetShaderKeyword();

		[Token(Token = "0x60001EE")]
		protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

		[Token(Token = "0x60001EF")]
		protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

		[Token(Token = "0x60001F0")]
		protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

		[Token(Token = "0x60001F1")]
		protected abstract void OnEnablePostValidate();

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xA65CC4", Offset = "0xA65CC4", VA = "0xA65CC4", Slot = "9")]
		protected virtual void OnValidateProperties()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xA65CE4", Offset = "0xA65CE4", VA = "0xA65CE4", Slot = "10")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xA65D64", Offset = "0xA65D64", VA = "0xA65D64", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xA65DB0", Offset = "0xA65DB0", VA = "0xA65DB0", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xA661EC", Offset = "0xA661EC", VA = "0xA661EC", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xA66314", Offset = "0xA66314", VA = "0xA66314")]
		private void OnWillCameraRender(Camera cam)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xA65D80", Offset = "0xA65D80", VA = "0xA65D80")]
		private void DisableOcclusion()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xA66504", Offset = "0xA66504", VA = "0xA66504")]
		protected DynamicOcclusionAbstractBase()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/")]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x38")]
		public LayerMask layerMask;

		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x3C")]
		public bool useOcclusionCulling;

		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x40")]
		public int depthMapResolution;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x44")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x48")]
		private Camera m_DepthCamera;

		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x50")]
		private bool m_NeedToUpdateOcclusionNextFrame;

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xA66574", Offset = "0xA66574", VA = "0xA66574", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xA665B4", Offset = "0xA665B4", VA = "0xA665B4", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xA665BC", Offset = "0xA665BC", VA = "0xA665BC")]
		private void ProcessOcclusionInternal()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xA66770", Offset = "0xA66770", VA = "0xA66770", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xA667A8", Offset = "0xA667A8", VA = "0xA667A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xA665E0", Offset = "0xA665E0", VA = "0xA665E0")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xA66900", Offset = "0xA66900", VA = "0xA66900")]
		public bool HasLayerMaskIssues()
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xA66964", Offset = "0xA66964", VA = "0xA66964", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xA669C8", Offset = "0xA669C8", VA = "0xA669C8")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xA66CA4", Offset = "0xA66CA4", VA = "0xA66CA4", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xA66CA8", Offset = "0xA66CA8", VA = "0xA66CA8", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xA66D40", Offset = "0xA66D40", VA = "0xA66D40", Slot = "10")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xA66D44", Offset = "0xA66D44", VA = "0xA66D44", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xA66D5C", Offset = "0xA66D5C", VA = "0xA66D5C")]
		private void DestroyDepthCamera()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xA66EAC", Offset = "0xA66EAC", VA = "0xA66EAC", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xA67028", Offset = "0xA67028", VA = "0xA67028")]
		public DynamicOcclusionDepthBuffer()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/")]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x2000067")]
		public class HitResult
		{
			[Token(Token = "0x400020D")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x400020E")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 normal;

			[Token(Token = "0x400020F")]
			[FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000210")]
			[FieldOffset(Offset = "0x30")]
			private Collider2D collider2D;

			[Token(Token = "0x4000211")]
			[FieldOffset(Offset = "0x38")]
			private Collider collider3D;

			[Token(Token = "0x17000045")]
			public bool hasCollider
			{
				[Token(Token = "0x600022B")]
				[Address(RVA = "0xA67E14", Offset = "0xA67E14", VA = "0xA67E14")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000046")]
			public string name
			{
				[Token(Token = "0x600022C")]
				[Address(RVA = "0xA6876C", Offset = "0xA6876C", VA = "0xA6876C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000047")]
			public Bounds bounds
			{
				[Token(Token = "0x600022D")]
				[Address(RVA = "0xA68830", Offset = "0xA68830", VA = "0xA68830")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x6000228")]
			[Address(RVA = "0xA67A50", Offset = "0xA67A50", VA = "0xA67A50")]
			public HitResult(RaycastHit hit3D)
			{
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0xA67B64", Offset = "0xA67B64", VA = "0xA67B64")]
			public HitResult(RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0xA67AD4", Offset = "0xA67AD4", VA = "0xA67AD4")]
			public HitResult()
			{
			}
		}

		[Token(Token = "0x2000068")]
		private enum Direction
		{
			[Token(Token = "0x4000213")]
			Up,
			[Token(Token = "0x4000214")]
			Right,
			[Token(Token = "0x4000215")]
			Down,
			[Token(Token = "0x4000216")]
			Left
		}

		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x38")]
		public OccluderDimensions dimensions;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x3C")]
		public LayerMask layerMask;

		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x40")]
		public bool considerTriggers;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x44")]
		public float minOccluderArea;

		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x48")]
		public float minSurfaceRatio;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x4C")]
		public float maxSurfaceDot;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x50")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x54")]
		public float planeOffset;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x58")]
		[FormerlySerializedAs("fadeDistanceToPlane")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x68")]
		private float m_RangeMultiplier;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x7C")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x17000040")]
		[Obsolete("Use 'fadeDistanceToSurface' instead")]
		public float fadeDistanceToPlane
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0xA670DC", Offset = "0xA670DC", VA = "0xA670DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0xA670E4", Offset = "0xA670E4", VA = "0xA670E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public HitResult currentHit
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0xA67200", Offset = "0xA67200", VA = "0xA67200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000210")]
			[Address(RVA = "0xA67208", Offset = "0xA67208", VA = "0xA67208")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		private Plane planeEquationWS
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0xA67258", Offset = "0xA67258", VA = "0xA67258")]
			[CompilerGenerated]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x6000214")]
			[Address(RVA = "0xA67264", Offset = "0xA67264", VA = "0xA67264")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0xA674EC", Offset = "0xA674EC", VA = "0xA674EC")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x17000044")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0xA67500", Offset = "0xA67500", VA = "0xA67500")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xA670EC", Offset = "0xA670EC", VA = "0xA670EC")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xA67210", Offset = "0xA67210", VA = "0xA67210", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xA67250", Offset = "0xA67250", VA = "0xA67250", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xA67270", Offset = "0xA67270", VA = "0xA67270", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xA672AC", Offset = "0xA672AC", VA = "0xA672AC", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xA672B8", Offset = "0xA672B8", VA = "0xA672B8", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xA67390", Offset = "0xA67390", VA = "0xA67390")]
		private void Start()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xA6743C", Offset = "0xA6743C", VA = "0xA6743C")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xA67544", Offset = "0xA67544", VA = "0xA67544")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xA67558", Offset = "0xA67558", VA = "0xA67558")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xA67770", Offset = "0xA67770", VA = "0xA67770")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xA67BE8", Offset = "0xA67BE8", VA = "0xA67BE8")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xA67D8C", Offset = "0xA67D8C", VA = "0xA67D8C")]
		private bool IsHitValid(HitResult hit)
		{
			return default(bool);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xA67EA4", Offset = "0xA67EA4", VA = "0xA67EA4", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xA672E0", Offset = "0xA672E0", VA = "0xA672E0")]
		private void SetHit(HitResult hit)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xA68370", Offset = "0xA68370", VA = "0xA68370", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xA68260", Offset = "0xA68260", VA = "0xA68260")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xA68228", Offset = "0xA68228", VA = "0xA68228")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xA686A0", Offset = "0xA686A0", VA = "0xA686A0")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xA686AC", Offset = "0xA686AC", VA = "0xA686AC")]
		public DynamicOcclusionRaycasting()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public enum ColorMode
	{
		[Token(Token = "0x4000218")]
		Flat,
		[Token(Token = "0x4000219")]
		Gradient
	}
	[Token(Token = "0x200006A")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x400021B")]
		Linear,
		[Token(Token = "0x400021C")]
		Quadratic,
		[Token(Token = "0x400021D")]
		Blend
	}
	[Token(Token = "0x200006B")]
	public enum BlendingMode
	{
		[Token(Token = "0x400021F")]
		Additive,
		[Token(Token = "0x4000220")]
		SoftAdditive,
		[Token(Token = "0x4000221")]
		TraditionalTransparency
	}
	[Token(Token = "0x200006C")]
	public enum NoiseMode
	{
		[Token(Token = "0x4000223")]
		Disabled,
		[Token(Token = "0x4000224")]
		WorldSpace,
		[Token(Token = "0x4000225")]
		LocalSpace
	}
	[Token(Token = "0x200006D")]
	public enum MeshType
	{
		[Token(Token = "0x4000227")]
		Shared,
		[Token(Token = "0x4000228")]
		Custom
	}
	[Token(Token = "0x200006E")]
	public enum RenderPipeline
	{
		[Token(Token = "0x400022A")]
		BuiltIn,
		[Token(Token = "0x400022B")]
		SRP_4_0_0_or_higher
	}
	[Token(Token = "0x200006F")]
	public enum RenderingMode
	{
		[Token(Token = "0x400022D")]
		MultiPass,
		[Token(Token = "0x400022E")]
		SinglePass,
		[Token(Token = "0x400022F")]
		GPUInstancing
	}
	[Token(Token = "0x2000070")]
	public enum RenderQueue
	{
		[Token(Token = "0x4000231")]
		Custom = 0,
		[Token(Token = "0x4000232")]
		Background = 1000,
		[Token(Token = "0x4000233")]
		Geometry = 2000,
		[Token(Token = "0x4000234")]
		AlphaTest = 2450,
		[Token(Token = "0x4000235")]
		GeometryLast = 2500,
		[Token(Token = "0x4000236")]
		Transparent = 3000,
		[Token(Token = "0x4000237")]
		Overlay = 4000
	}
	[Token(Token = "0x2000071")]
	public enum OccluderDimensions
	{
		[Token(Token = "0x4000239")]
		Occluders3D,
		[Token(Token = "0x400023A")]
		Occluders2D
	}
	[Token(Token = "0x2000072")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x400023C")]
		Surface,
		[Token(Token = "0x400023D")]
		Beam
	}
	[Token(Token = "0x2000073")]
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		[Token(Token = "0x400023F")]
		Never = 1,
		[Token(Token = "0x4000240")]
		OnEnable = 2,
		[Token(Token = "0x4000241")]
		OnBeamMove = 4,
		[Token(Token = "0x4000242")]
		EveryXFrames = 8,
		[Token(Token = "0x4000243")]
		OnBeamMoveAndEveryXFrames = 0xC
	}
	[Token(Token = "0x2000074")]
	public static class GlobalMesh
	{
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xA68918", Offset = "0xA68918", VA = "0xA68918")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xA68A98", Offset = "0xA68A98", VA = "0xA68A98")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public static class GpuInstancing
	{
		[Token(Token = "0x4000246")]
		public const bool isSupported = true;

		[Token(Token = "0x17000048")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0xA69350", Offset = "0xA69350", VA = "0xA69350")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xA69378", Offset = "0xA69378", VA = "0xA69378")]
		public static void SetMaterialProperties(Material material, bool enableInstancing)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xA69404", Offset = "0xA69404", VA = "0xA69404")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xA69650", Offset = "0xA69650", VA = "0xA69650")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xA69788", Offset = "0xA69788", VA = "0xA69788")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x2000076")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000235")]
		[Address(RVA = "0xA69860", Offset = "0xA69860", VA = "0xA69860")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class MaterialKeywordSRP
	{
		[Token(Token = "0x4000247")]
		public const string kKeyword = "VLB_SRP_API";

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xA69868", Offset = "0xA69868", VA = "0xA69868")]
		public MaterialKeywordSRP()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public static class MaterialManager
	{
		[Token(Token = "0x2000079")]
		public enum BlendingMode
		{
			[Token(Token = "0x400024F")]
			Additive,
			[Token(Token = "0x4000250")]
			SoftAdditive,
			[Token(Token = "0x4000251")]
			TraditionalTransparency,
			[Token(Token = "0x4000252")]
			Count
		}

		[Token(Token = "0x200007A")]
		public enum Noise3D
		{
			[Token(Token = "0x4000254")]
			Off,
			[Token(Token = "0x4000255")]
			On,
			[Token(Token = "0x4000256")]
			Count
		}

		[Token(Token = "0x200007B")]
		public enum DepthBlend
		{
			[Token(Token = "0x4000258")]
			Off,
			[Token(Token = "0x4000259")]
			On,
			[Token(Token = "0x400025A")]
			Count
		}

		[Token(Token = "0x200007C")]
		public enum ColorGradient
		{
			[Token(Token = "0x400025C")]
			Off,
			[Token(Token = "0x400025D")]
			MatrixLow,
			[Token(Token = "0x400025E")]
			MatrixHigh,
			[Token(Token = "0x400025F")]
			Count
		}

		[Token(Token = "0x200007D")]
		public enum DynamicOcclusion
		{
			[Token(Token = "0x4000261")]
			Off,
			[Token(Token = "0x4000262")]
			ClippingPlane,
			[Token(Token = "0x4000263")]
			DepthTexture,
			[Token(Token = "0x4000264")]
			Count
		}

		[Token(Token = "0x200007E")]
		public class StaticProperties
		{
			[Token(Token = "0x4000265")]
			[FieldOffset(Offset = "0x10")]
			public BlendingMode blendingMode;

			[Token(Token = "0x4000266")]
			[FieldOffset(Offset = "0x14")]
			public Noise3D noise3D;

			[Token(Token = "0x4000267")]
			[FieldOffset(Offset = "0x18")]
			public DepthBlend depthBlend;

			[Token(Token = "0x4000268")]
			[FieldOffset(Offset = "0x1C")]
			public ColorGradient colorGradient;

			[Token(Token = "0x4000269")]
			[FieldOffset(Offset = "0x20")]
			public DynamicOcclusion dynamicOcclusion;

			[Token(Token = "0x17000049")]
			public int materialID
			{
				[Token(Token = "0x600023A")]
				[Address(RVA = "0xA69D24", Offset = "0xA69D24", VA = "0xA69D24")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x600023B")]
			[Address(RVA = "0xA69D4C", Offset = "0xA69D4C", VA = "0xA69D4C")]
			public void ApplyToMaterial(Material mat)
			{
			}

			[Token(Token = "0x600023C")]
			[Address(RVA = "0xA6A190", Offset = "0xA6A190", VA = "0xA6A190")]
			public StaticProperties()
			{
			}
		}

		[Token(Token = "0x200007F")]
		private class MaterialsGroup
		{
			[Token(Token = "0x400026A")]
			[FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x600023D")]
			[Address(RVA = "0xA69C94", Offset = "0xA69C94", VA = "0xA69C94")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x20")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xA69870", Offset = "0xA69870", VA = "0xA69870")]
		public static Material NewMaterial(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xA69A04", Offset = "0xA69A04", VA = "0xA69A04")]
		public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x2000080")]
	public static class MeshGenerator
	{
		[Token(Token = "0x400026B")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xA6A198", Offset = "0xA6A198", VA = "0xA6A198")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xA6A1B0", Offset = "0xA6A1B0", VA = "0xA6A1B0")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xA6A220", Offset = "0xA6A220", VA = "0xA6A220")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xA68B64", Offset = "0xA68B64", VA = "0xA68B64")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xA6A28C", Offset = "0xA6A28C", VA = "0xA6A28C")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xA6A2A8", Offset = "0xA6A2A8", VA = "0xA6A2A8")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xA6A2D0", Offset = "0xA6A2D0", VA = "0xA6A2D0")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xA6A330", Offset = "0xA6A330", VA = "0xA6A330")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000081")]
	public static class Noise3D
	{
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x400026F")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x4000270")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x1700004A")]
		public static bool isSupported
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0xA6A394", Offset = "0xA6A394", VA = "0xA6A394")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0xA6A4F4", Offset = "0xA6A4F4", VA = "0xA6A4F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0xA6A450", Offset = "0xA6A450", VA = "0xA6A450")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xA6A56C", Offset = "0xA6A56C", VA = "0xA6A56C")]
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xA6A570", Offset = "0xA6A570", VA = "0xA6A570")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xA6A6EC", Offset = "0xA6A6EC", VA = "0xA6A6EC")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x2000082")]
	public static class ShaderProperties
	{
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int FadeOutFactor;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int ClippingPlaneWS;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int ClippingPlaneProps;

		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int ConeSlopeCosSin;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int ConeRadius;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int ConeApexOffsetZ;

		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int ColorFlat;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly int AlphaInside;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x20")]
		public static readonly int AlphaOutside;

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x24")]
		public static readonly int AttenuationLerpLinearQuad;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x28")]
		public static readonly int DistanceFadeStart;

		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly int DistanceFadeEnd;

		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x30")]
		public static readonly int DistanceCamClipping;

		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x34")]
		public static readonly int FresnelPow;

		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x38")]
		public static readonly int GlareBehind;

		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x3C")]
		public static readonly int GlareFrontal;

		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x40")]
		public static readonly int DrawCap;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x44")]
		public static readonly int DepthBlendDistance;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x48")]
		public static readonly int NoiseLocal;

		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x4C")]
		public static readonly int NoiseParam;

		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x50")]
		public static readonly int CameraParams;

		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x54")]
		public static readonly int CameraBufferSizeSRP;

		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x58")]
		public static readonly int ColorGradientMatrix;

		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x5C")]
		public static readonly int LocalToWorldMatrix;

		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x60")]
		public static readonly int WorldToLocalMatrix;

		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x64")]
		public static readonly int BlendSrcFactor;

		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x68")]
		public static readonly int BlendDstFactor;

		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x6C")]
		public static readonly int DynamicOcclusionDepthTexture;

		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x70")]
		public static readonly int DynamicOcclusionDepthProps;
	}
	[Token(Token = "0x2000083")]
	public static class TransformUtils
	{
		[Token(Token = "0x2000084")]
		public class Packed
		{
			[Token(Token = "0x400028E")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 position;

			[Token(Token = "0x400028F")]
			[FieldOffset(Offset = "0x1C")]
			public Quaternion rotation;

			[Token(Token = "0x4000290")]
			[FieldOffset(Offset = "0x2C")]
			public Vector3 lossyScale;

			[Token(Token = "0x600024F")]
			[Address(RVA = "0xA6AF38", Offset = "0xA6AF38", VA = "0xA6AF38")]
			public Packed()
			{
			}
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xA65C1C", Offset = "0xA65C1C", VA = "0xA65C1C")]
		public static Packed GetWorldPacked(this Transform self)
		{
			return null;
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xA6640C", Offset = "0xA6640C", VA = "0xA6640C")]
		public static bool IsSame(this Transform self, Packed packed)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000085")]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[DisallowMultipleComponent]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-triggerzone/")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x4000293")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x20")]
		private Mesh m_Mesh;

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xA6AF40", Offset = "0xA6AF40", VA = "0xA6AF40")]
		private void Update()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xA6B128", Offset = "0xA6B128", VA = "0xA6B128")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public static class Utils
	{
		[Token(Token = "0x2000087")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x4000298")]
			High = 64,
			[Token(Token = "0x4000299")]
			Low = 8,
			[Token(Token = "0x400029A")]
			Undef = 0
		}

		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x4000296")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xA6B140", Offset = "0xA6B140", VA = "0xA6B140")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x6000253")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xA6B174", Offset = "0xA6B174", VA = "0xA6B174")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000257")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xA6B260", Offset = "0xA6B260", VA = "0xA6B260")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xA6B330", Offset = "0xA6B330", VA = "0xA6B330")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xA6B334", Offset = "0xA6B334", VA = "0xA6B334")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xA6B33C", Offset = "0xA6B33C", VA = "0xA6B33C")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xA6B348", Offset = "0xA6B348", VA = "0xA6B348")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xA6B358", Offset = "0xA6B358", VA = "0xA6B358")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xA6B364", Offset = "0xA6B364", VA = "0xA6B364")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xA6B36C", Offset = "0xA6B36C", VA = "0xA6B36C")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xA679C0", Offset = "0xA679C0", VA = "0xA679C0")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xA6B3B4", Offset = "0xA6B3B4", VA = "0xA6B3B4")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xA6B3BC", Offset = "0xA6B3BC", VA = "0xA6B3BC")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xA68534", Offset = "0xA68534", VA = "0xA68534")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xA671B8", Offset = "0xA671B8", VA = "0xA671B8")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xA693E4", Offset = "0xA693E4", VA = "0xA693E4")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xA65110", Offset = "0xA65110", VA = "0xA65110")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xA6B74C", Offset = "0xA6B74C", VA = "0xA6B74C")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xA6B860", Offset = "0xA6B860", VA = "0xA6B860")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xA6B944", Offset = "0xA6B944", VA = "0xA6B944")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xA6B804", Offset = "0xA6B804", VA = "0xA6B804")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xA6B958", Offset = "0xA6B958", VA = "0xA6B958")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xA6B9C8", Offset = "0xA6B9C8", VA = "0xA6B9C8")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xA65710", Offset = "0xA65710", VA = "0xA65710")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x2000088")]
	public static class Version
	{
		[Token(Token = "0x400029B")]
		public const int Current = 1800;
	}
	[Token(Token = "0x2000089")]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dustparticles/")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x200008A")]
		public enum Direction
		{
			[Token(Token = "0x40002AD")]
			Beam,
			[Token(Token = "0x40002AE")]
			Random
		}

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float alpha;

		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0.0001f, 0.1f)]
		public float size;

		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x20")]
		public Direction direction;

		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x28")]
		public float density;

		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float spawnMinDistance;

		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float spawnMaxDistance;

		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x34")]
		public bool cullingEnabled;

		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x38")]
		public float cullingMaxDistance;

		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x40")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x48")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x50")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x1700004D")]
		public bool isCulled
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0xA6B9CC", Offset = "0xA6B9CC", VA = "0xA6B9CC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xA6B9D4", Offset = "0xA6B9D4", VA = "0xA6B9D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0xA6B9E0", Offset = "0xA6B9E0", VA = "0xA6B9E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0xA6BA3C", Offset = "0xA6BA3C", VA = "0xA6BA3C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000050")]
		public int particlesMaxCount
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0xA6BAC0", Offset = "0xA6BAC0", VA = "0xA6BAC0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000051")]
		public Camera mainCamera
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0xA6BB5C", Offset = "0xA6BB5C", VA = "0xA6BB5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xA6BD74", Offset = "0xA6BD74", VA = "0xA6BD74")]
		private void Start()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xA6BDE0", Offset = "0xA6BDE0", VA = "0xA6BDE0")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xA6C03C", Offset = "0xA6C03C", VA = "0xA6C03C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xA6BF90", Offset = "0xA6BF90", VA = "0xA6BF90")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xA6C680", Offset = "0xA6C680", VA = "0xA6C680")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xA6C710", Offset = "0xA6C710", VA = "0xA6C710")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xA6C7B8", Offset = "0xA6C7B8", VA = "0xA6C7B8")]
		private void Update()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xA6C040", Offset = "0xA6C040", VA = "0xA6C040")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xA6C7E0", Offset = "0xA6C7E0", VA = "0xA6C7E0")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xA6CB34", Offset = "0xA6CB34", VA = "0xA6CB34")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x200008C")]
		public delegate void OnWillCameraRenderCB(Camera cam);

		[Token(Token = "0x200008D")]
		public delegate void OnBeamGeometryInitialized();

		[Token(Token = "0x200008E")]
		[CompilerGenerated]
		private sealed class <CoPlaytimeUpdate>d__149 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002DE")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002DF")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002E0")]
			[FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x17000073")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002D5")]
				[Address(RVA = "0xA6E208", Offset = "0xA6E208", VA = "0xA6E208", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002D7")]
				[Address(RVA = "0xA6E250", Offset = "0xA6E250", VA = "0xA6E250", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0xA6DD04", Offset = "0xA6DD04", VA = "0xA6DD04")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__149(int <>1__state)
			{
			}

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0xA6E174", Offset = "0xA6E174", VA = "0xA6E174", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002D4")]
			[Address(RVA = "0xA6E178", Offset = "0xA6E178", VA = "0xA6E178", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002D6")]
			[Address(RVA = "0xA6E210", Offset = "0xA6E210", VA = "0xA6E210", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("colorValue")]
		[ColorUsage(false, true)]
		public Color color;

		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 8f)]
		[FormerlySerializedAs("alphaInside")]
		public float intensityInside;

		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 8f)]
		[FormerlySerializedAs("alpha")]
		[FormerlySerializedAs("alphaOutside")]
		public float intensityOutside;

		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("angleFromLight")]
		public bool spotAngleFromLight;

		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0.1f, 179.9f)]
		public float spotAngle;

		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x50")]
		[FormerlySerializedAs("radiusStart")]
		public float coneRadiusStart;

		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x54")]
		public MeshType geomMeshType;

		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x58")]
		[FormerlySerializedAs("geomSides")]
		public int geomCustomSides;

		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x5C")]
		public int geomCustomSegments;

		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x60")]
		public bool geomCap;

		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x61")]
		[FormerlySerializedAs("fadeEndFromLight")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x64")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float attenuationCustomBlending;

		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x6C")]
		[FormerlySerializedAs("fadeStart")]
		public float fallOffStart;

		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x70")]
		[FormerlySerializedAs("fadeEnd")]
		public float fallOffEnd;

		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x74")]
		public float depthBlendDistance;

		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x78")]
		public float cameraClippingDistance;

		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float glareFrontal;

		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float glareBehind;

		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x84")]
		[FormerlySerializedAs("fresnelPowOutside")]
		public float fresnelPow;

		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x88")]
		public NoiseMode noiseMode;

		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x8C")]
		[FormerlySerializedAs("noiseEnabled")]
		[SerializeField]
		private bool _DEPRECATED_NoiseEnabled;

		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x90")]
		[Range(0f, 1f)]
		public float noiseIntensity;

		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x94")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x98")]
		[Range(0.01f, 2f)]
		public float noiseScaleLocal;

		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x9C")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_IsDynamicOcclusionEnabled;

		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0xC0")]
		private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0xCC")]
		[FormerlySerializedAs("trackChangesDuringPlaytime")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0xD8")]
		[FormerlySerializedAs("fadeOutBegin")]
		[SerializeField]
		private float _FadeOutBegin;

		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0xDC")]
		[FormerlySerializedAs("fadeOutEnd")]
		[SerializeField]
		private float _FadeOutEnd;

		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0xE8")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0xF0")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0xF8")]
		private Light _CachedLight;

		[Token(Token = "0x17000052")]
		[Obsolete("Use 'intensityGlobal' or 'intensityInside' instead")]
		public float alphaInside
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0xA6CBC8", Offset = "0xA6CBC8", VA = "0xA6CBC8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000280")]
			[Address(RVA = "0xA6CBD0", Offset = "0xA6CBD0", VA = "0xA6CBD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		[Obsolete("Use 'intensityGlobal' or 'intensityOutside' instead")]
		public float alphaOutside
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0xA6CBD8", Offset = "0xA6CBD8", VA = "0xA6CBD8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000282")]
			[Address(RVA = "0xA6CBE0", Offset = "0xA6CBE0", VA = "0xA6CBE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public float intensityGlobal
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0xA6CBE8", Offset = "0xA6CBE8", VA = "0xA6CBE8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000284")]
			[Address(RVA = "0xA6CBF0", Offset = "0xA6CBF0", VA = "0xA6CBF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public float coneAngle
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0xA668A4", Offset = "0xA668A4", VA = "0xA668A4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000056")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0xA681F0", Offset = "0xA681F0", VA = "0xA681F0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000057")]
		public float coneVolume
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0xA6CBF8", Offset = "0xA6CBF8", VA = "0xA6CBF8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000058")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0xA66844", Offset = "0xA66844", VA = "0xA66844")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000059")]
		public int geomSides
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0xA6CC54", Offset = "0xA6CC54", VA = "0xA6CC54")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0xA6CC8C", Offset = "0xA6CC8C", VA = "0xA6CC8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public int geomSegments
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0xA6CD08", Offset = "0xA6CD08", VA = "0xA6CD08")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600028C")]
			[Address(RVA = "0xA6CD40", Offset = "0xA6CD40", VA = "0xA6CD40")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		[Obsolete("Use 'fallOffEndFromLight' instead")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0xA6CDBC", Offset = "0xA6CDBC", VA = "0xA6CDBC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0xA6CDC4", Offset = "0xA6CDC4", VA = "0xA6CDC4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0xA6CDD0", Offset = "0xA6CDD0", VA = "0xA6CDD0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005D")]
		[Obsolete("Use 'fallOffStart' instead")]
		public float fadeStart
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0xA6CDF8", Offset = "0xA6CDF8", VA = "0xA6CDF8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000291")]
			[Address(RVA = "0xA6CE00", Offset = "0xA6CE00", VA = "0xA6CE00")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		[Obsolete("Use 'fallOffEnd' instead")]
		public float fadeEnd
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0xA6CE08", Offset = "0xA6CE08", VA = "0xA6CE08")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000293")]
			[Address(RVA = "0xA6CE10", Offset = "0xA6CE10", VA = "0xA6CE10")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0xA69850", Offset = "0xA69850", VA = "0xA69850")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000060")]
		[Obsolete("Use 'noiseMode' instead")]
		public bool noiseEnabled
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0xA6CE18", Offset = "0xA6CE18", VA = "0xA6CE18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000296")]
			[Address(RVA = "0xA6CE28", Offset = "0xA6CE28", VA = "0xA6CE28")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public float fadeOutBegin
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0xA6CE44", Offset = "0xA6CE44", VA = "0xA6CE44")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000298")]
			[Address(RVA = "0xA6CE4C", Offset = "0xA6CE4C", VA = "0xA6CE4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public float fadeOutEnd
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0xA6CEA8", Offset = "0xA6CEA8", VA = "0xA6CEA8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0xA6CEB0", Offset = "0xA6CEB0", VA = "0xA6CEB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0xA64E3C", Offset = "0xA64E3C", VA = "0xA64E3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		public int sortingLayerID
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0xA6CEB8", Offset = "0xA6CEB8", VA = "0xA6CEB8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600029D")]
			[Address(RVA = "0xA6CEC0", Offset = "0xA6CEC0", VA = "0xA6CEC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public string sortingLayerName
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0xA6CF58", Offset = "0xA6CF58", VA = "0xA6CF58")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0xA6CF64", Offset = "0xA6CF64", VA = "0xA6CF64")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public int sortingOrder
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0xA6CF88", Offset = "0xA6CF88", VA = "0xA6CF88")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0xA6CF90", Offset = "0xA6CF90", VA = "0xA6CF90")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0xA6D028", Offset = "0xA6D028", VA = "0xA6D028")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0xA6D030", Offset = "0xA6D030", VA = "0xA6D030")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0xA6D0A4", Offset = "0xA6D0A4", VA = "0xA6D0A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		public bool hasGeometry
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0xA6C9C4", Offset = "0xA6C9C4", VA = "0xA6C9C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		public Bounds bounds
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0xA6CA24", Offset = "0xA6CA24", VA = "0xA6CA24")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x1700006B")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0xA6D0B4", Offset = "0xA6D0B4", VA = "0xA6D0B4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006C")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0xA6D18C", Offset = "0xA6D18C", VA = "0xA6D18C")]
			[CompilerGenerated]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0xA6D194", Offset = "0xA6D194", VA = "0xA6D194")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public MaterialManager.DynamicOcclusion _INTERNAL_EnabledDynamicOcclusionMode
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0xA6D19C", Offset = "0xA6D19C", VA = "0xA6D19C")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
		}

		[Token(Token = "0x1700006E")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0xA6D2A4", Offset = "0xA6D2A4", VA = "0xA6D2A4")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0xA6D2AC", Offset = "0xA6D2AC", VA = "0xA6D2AC")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public string meshStats
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0xA6D2B4", Offset = "0xA6D2B4", VA = "0xA6D2B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public int meshVerticesCount
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0xA6D454", Offset = "0xA6D454", VA = "0xA6D454")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000071")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0xA6D50C", Offset = "0xA6D50C", VA = "0xA6D50C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000072")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0xA6D5E0", Offset = "0xA6D5E0", VA = "0xA6D5E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0xA65FA4", Offset = "0xA65FA4", VA = "0xA65FA4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xA66278", Offset = "0xA66278", VA = "0xA66278")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xA65B74", Offset = "0xA65B74", VA = "0xA65B74")]
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xA6D1B4", Offset = "0xA6D1B4", VA = "0xA6D1B4")]
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xA6610C", Offset = "0xA6610C", VA = "0xA6610C")]
		public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xA6D1D0", Offset = "0xA6D1D0", VA = "0xA6D1D0")]
		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xA6CE54", Offset = "0xA6CE54", VA = "0xA6CE54")]
		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xA6D20C", Offset = "0xA6D20C", VA = "0xA6D20C")]
		private void OnFadeOutStateChanged()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xA6D6D4", Offset = "0xA6D6D4", VA = "0xA6D6D4")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xA6D728", Offset = "0xA6D728", VA = "0xA6D728")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xA6D8B0", Offset = "0xA6D8B0", VA = "0xA6D8B0")]
		[Obsolete("Use 'GenerateGeometry()' instead")]
		public void Generate()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xA6D8BC", Offset = "0xA6D8BC", VA = "0xA6D8BC", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xA6DAF4", Offset = "0xA6DAF4", VA = "0xA6DAF4", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xA6DB7C", Offset = "0xA6DB7C", VA = "0xA6DB7C")]
		private void Start()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xA6DB88", Offset = "0xA6DB88", VA = "0xA6DB88")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xA6DC08", Offset = "0xA6DC08", VA = "0xA6DC08")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xA6D03C", Offset = "0xA6D03C", VA = "0xA6D03C")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xA6DC90", Offset = "0xA6DC90", VA = "0xA6DC90")]
		[IteratorStateMachine(typeof(<CoPlaytimeUpdate>d__149))]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xA6DD2C", Offset = "0xA6DD2C", VA = "0xA6DD2C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xA6DD30", Offset = "0xA6DD30", VA = "0xA6DD30")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xA6DDD8", Offset = "0xA6DDD8", VA = "0xA6DDD8")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xA6DEC8", Offset = "0xA6DEC8", VA = "0xA6DEC8")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xA6DAD0", Offset = "0xA6DAD0", VA = "0xA6DAD0")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xA6D9E4", Offset = "0xA6D9E4", VA = "0xA6D9E4")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xA6DFF8", Offset = "0xA6DFF8", VA = "0xA6DFF8")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x200008F")]
	[RequireComponent(typeof(Camera))]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xA6E258", Offset = "0xA6E258", VA = "0xA6E258")]
		private void Update()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xA6E318", Offset = "0xA6E318", VA = "0xA6E318")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[RequireComponent(typeof(Collider), typeof(Rigidbody), typeof(MeshRenderer))]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x18")]
		private bool isInsideBeam;

		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xA6E328", Offset = "0xA6E328", VA = "0xA6E328")]
		private void Start()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xA6E418", Offset = "0xA6E418", VA = "0xA6E418")]
		private void Update()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xA6E4CC", Offset = "0xA6E4CC", VA = "0xA6E4CC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xA6E4D4", Offset = "0xA6E4D4", VA = "0xA6E4D4")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xA6E58C", Offset = "0xA6E58C", VA = "0xA6E58C")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xA6E594", Offset = "0xA6E594", VA = "0xA6E594")]
		private void Start()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xA6E5FC", Offset = "0xA6E5FC", VA = "0xA6E5FC")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x17000075")]
		private bool useMouseView
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xA6E604", Offset = "0xA6E604", VA = "0xA6E604")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xA6E60C", Offset = "0xA6E60C", VA = "0xA6E60C")]
			set
			{
			}
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xA6E63C", Offset = "0xA6E63C", VA = "0xA6E63C")]
		private void Start()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xA6E6CC", Offset = "0xA6E6CC", VA = "0xA6E6CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xA6ECA8", Offset = "0xA6ECA8", VA = "0xA6ECA8")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x18")]
		[Range(1f, 100f)]
		[SerializeField]
		private int CountX;

		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x1C")]
		[Range(1f, 100f)]
		[SerializeField]
		private int CountY;

		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xA6ECCC", Offset = "0xA6ECCC", VA = "0xA6ECCC")]
		public void Generate()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xA6F340", Offset = "0xA6F340", VA = "0xA6F340")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("m_EulerSpeed")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xA6F35C", Offset = "0xA6F35C", VA = "0xA6F35C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xA6F42C", Offset = "0xA6F42C", VA = "0xA6F42C")]
		public Rotater()
		{
		}
	}
}
