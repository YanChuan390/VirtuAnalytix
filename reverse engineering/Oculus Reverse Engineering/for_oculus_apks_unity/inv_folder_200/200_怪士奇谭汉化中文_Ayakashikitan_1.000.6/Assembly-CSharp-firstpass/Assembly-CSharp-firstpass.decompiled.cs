using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using Unity.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Experimental.Animations;
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
	[Address(RVA = "0xF9C340", Offset = "0xF9C340", VA = "0xF9C340")]
	public void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xF9C514", Offset = "0xF9C514", VA = "0xF9C514", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xF9C960", Offset = "0xF9C960", VA = "0xF9C960")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000003")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000004")]
	[Address(RVA = "0xF9C968", Offset = "0xF9C968", VA = "0xF9C968")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xF9CA80", Offset = "0xF9CA80", VA = "0xF9CA80")]
	public EventSystemChecker()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x65497C", Offset = "0x65497C")]
public class ForcedReset : MonoBehaviour
{
	[Token(Token = "0x6000006")]
	[Address(RVA = "0xF9CA88", Offset = "0xF9CA88", VA = "0xF9CA88")]
	private void Update()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xF9CB24", Offset = "0xF9CB24", VA = "0xF9CB24")]
	public ForcedReset()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000005")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000127")]
		public enum Mode
		{
			[Token(Token = "0x40008B8")]
			Trigger,
			[Token(Token = "0x40008B9")]
			Replace,
			[Token(Token = "0x40008BA")]
			Activate,
			[Token(Token = "0x40008BB")]
			Enable,
			[Token(Token = "0x40008BC")]
			Animate,
			[Token(Token = "0x40008BD")]
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
		[Address(RVA = "0xBC8D14", Offset = "0xBC8D14", VA = "0xBC8D14")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xBC91E0", Offset = "0xBC91E0", VA = "0xBC91E0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xBC91E4", Offset = "0xBC91E4", VA = "0xBC91E4")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000128")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x40008BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x40008BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0xBC9EA0", Offset = "0xBC9EA0", VA = "0xBC9EA0")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000129")]
		public class ReplacementList
		{
			[Token(Token = "0x40008C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x60008CA")]
			[Address(RVA = "0xBC9EA8", Offset = "0xBC9EA8", VA = "0xBC9EA8")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xBC91FC", Offset = "0xBC91FC", VA = "0xBC91FC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xBC9E98", Offset = "0xBC9E98", VA = "0xBC9E98")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200012A")]
		public class Vector3andSpace
		{
			[Token(Token = "0x40008C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x40008C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x60008CB")]
			[Address(RVA = "0xBCA0E0", Offset = "0xBCA0E0", VA = "0xBCA0E0")]
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
		[Address(RVA = "0xBC9F08", Offset = "0xBC9F08", VA = "0xBC9F08")]
		private void Start()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xBC9F30", Offset = "0xBC9F30", VA = "0xBC9F30")]
		private void Update()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xBCA0D8", Offset = "0xBCA0D8", VA = "0xBCA0D8")]
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
		[Address(RVA = "0xBCA0F0", Offset = "0xBCA0F0", VA = "0xBCA0F0")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xBCA150", Offset = "0xBCA150", VA = "0xBCA150")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xBCA158", Offset = "0xBCA158", VA = "0xBCA158")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xBCA160", Offset = "0xBCA160", VA = "0xBCA160")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xBCA2EC", Offset = "0xBCA2EC", VA = "0xBCA2EC")]
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
		[Address(RVA = "0xBBD210", Offset = "0xBBD210", VA = "0xBBD210")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xBBE274", Offset = "0xBBE274", VA = "0xBBE274")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xBBEAE4", Offset = "0xBBEAE4", VA = "0xBBEAE4")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x200012B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6575DC", Offset = "0x6575DC")]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x40008C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x40008C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x40008C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x40008C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x170000AD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008CF")]
				[Address(RVA = "0xBCACC0", Offset = "0xBCACC0", VA = "0xBCACC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008D1")]
				[Address(RVA = "0xBCAD30", Offset = "0xBCAD30", VA = "0xBCAD30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008CC")]
			[Address(RVA = "0xBCA928", Offset = "0xBCA928", VA = "0xBCA928")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60008CD")]
			[Address(RVA = "0xBCA95C", Offset = "0xBCA95C", VA = "0xBCA95C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008CE")]
			[Address(RVA = "0xBCA960", Offset = "0xBCA960", VA = "0xBCA960", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0xBCACC8", Offset = "0xBCACC8", VA = "0xBCACC8", Slot = "8")]
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
		[Address(RVA = "0xBCA378", Offset = "0xBCA378", VA = "0xBCA378")]
		private void Update()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xBCA890", Offset = "0xBCA890", VA = "0xBCA890")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6610D0", Offset = "0x6610D0")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xBCA7E0", Offset = "0xBCA7E0", VA = "0xBCA7E0")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xBCA954", Offset = "0xBCA954", VA = "0xBCA954")]
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
		[Address(RVA = "0xBCAD38", Offset = "0xBCAD38", VA = "0xBCAD38")]
		private void Start()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xBCAD74", Offset = "0xBCAD74", VA = "0xBCAD74")]
		private void Update()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xBCB02C", Offset = "0xBCB02C", VA = "0xBCB02C")]
		public DynamicShadowSettings()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xBCB784", Offset = "0xBCB784", VA = "0xBCB784")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xBCB890", Offset = "0xBCB890", VA = "0xBCB890")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public class FOVKick
	{
		[Token(Token = "0x200012C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6575EC", Offset = "0x6575EC")]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x170000AF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008D5")]
				[Address(RVA = "0xBCB5AC", Offset = "0xBCB5AC", VA = "0xBCB5AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008D7")]
				[Address(RVA = "0xBCB61C", Offset = "0xBCB61C", VA = "0xBCB61C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0xBCB150", Offset = "0xBCB150", VA = "0xBCB150")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60008D3")]
			[Address(RVA = "0xBCB404", Offset = "0xBCB404", VA = "0xBCB404", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0xBCB408", Offset = "0xBCB408", VA = "0xBCB408", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0xBCB5B4", Offset = "0xBCB5B4", VA = "0xBCB5B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200012D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6575FC", Offset = "0x6575FC")]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x170000B1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008DB")]
				[Address(RVA = "0xBCB38C", Offset = "0xBCB38C", VA = "0xBCB38C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008DD")]
				[Address(RVA = "0xBCB3FC", Offset = "0xBCB3FC", VA = "0xBCB3FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008D8")]
			[Address(RVA = "0xBCB17C", Offset = "0xBCB17C", VA = "0xBCB17C")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60008D9")]
			[Address(RVA = "0xBCB1A8", Offset = "0xBCB1A8", VA = "0xBCB1A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008DA")]
			[Address(RVA = "0xBCB1AC", Offset = "0xBCB1AC", VA = "0xBCB1AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008DC")]
			[Address(RVA = "0xBCB394", Offset = "0xBCB394", VA = "0xBCB394", Slot = "8")]
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

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xBBD1CC", Offset = "0xBBD1CC", VA = "0xBBD1CC")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xBCB060", Offset = "0xBCB060", VA = "0xBCB060")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xBCB148", Offset = "0xBCB148", VA = "0xBCB148")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xBBE42C", Offset = "0xBBE42C", VA = "0xBBE42C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x661134", Offset = "0x661134")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xBBE3B8", Offset = "0xBBE3B8", VA = "0xBBE3B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x661198", Offset = "0x661198")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xBBEAC8", Offset = "0xBBEAC8", VA = "0xBBEAC8")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6549E0", Offset = "0x6549E0")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x4000034")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x4000038")]
		private const string display = "{0} FPS";

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xBCB624", Offset = "0xBCB624", VA = "0xBCB624")]
		private void Start()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xBCB690", Offset = "0xBCB690", VA = "0xBCB690")]
		private void Update()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xBCB77C", Offset = "0xBCB77C", VA = "0xBCB77C")]
		public FPSCounter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class LerpControlledBob
	{
		[Token(Token = "0x200012E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65760C", Offset = "0x65760C")]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x40008D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x170000B3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008E1")]
				[Address(RVA = "0xBCBB54", Offset = "0xBCBB54", VA = "0xBCBB54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008E3")]
				[Address(RVA = "0xBCBBC4", Offset = "0xBCBBC4", VA = "0xBCBBC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008DE")]
			[Address(RVA = "0xBCB8F0", Offset = "0xBCB8F0", VA = "0xBCB8F0")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60008DF")]
			[Address(RVA = "0xBCB91C", Offset = "0xBCB91C", VA = "0xBCB91C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008E0")]
			[Address(RVA = "0xBCB920", Offset = "0xBCB920", VA = "0xBCB920", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008E2")]
			[Address(RVA = "0xBCBB5C", Offset = "0xBCBB5C", VA = "0xBCBB5C", Slot = "8")]
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
		[Address(RVA = "0xBBE3B0", Offset = "0xBBE3B0", VA = "0xBBE3B0")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xBBD598", Offset = "0xBBD598", VA = "0xBBD598")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6611FC", Offset = "0x6611FC")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xBBED70", Offset = "0xBBED70", VA = "0xBBED70")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x200012F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65761C", Offset = "0x65761C")]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x170000B5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008E7")]
				[Address(RVA = "0xBCC09C", Offset = "0xBCC09C", VA = "0xBCC09C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008E9")]
				[Address(RVA = "0xBCC10C", Offset = "0xBCC10C", VA = "0xBCC10C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008E4")]
			[Address(RVA = "0xBCBD64", Offset = "0xBCBD64", VA = "0xBCBD64")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0xBCBD98", Offset = "0xBCBD98", VA = "0xBCBD98", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008E6")]
			[Address(RVA = "0xBCBD9C", Offset = "0xBCBD9C", VA = "0xBCBD9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008E8")]
			[Address(RVA = "0xBCC0A4", Offset = "0xBCC0A4", VA = "0xBCC0A4", Slot = "8")]
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
		[Address(RVA = "0xBCBBCC", Offset = "0xBCBBCC", VA = "0xBCBBCC")]
		private void Start()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xBC7F84", Offset = "0xBC7F84", VA = "0xBC7F84")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xBCBCCC", Offset = "0xBCBCCC", VA = "0xBCBCCC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x661260", Offset = "0x661260")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xBCBD90", Offset = "0xBCBD90", VA = "0xBCBD90")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x2000130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65762C", Offset = "0x65762C")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x170000B7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008ED")]
				[Address(RVA = "0xBCC5C8", Offset = "0xBCC5C8", VA = "0xBCC5C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008EF")]
				[Address(RVA = "0xBCC638", Offset = "0xBCC638", VA = "0xBCC638", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008EA")]
			[Address(RVA = "0xBCC188", Offset = "0xBCC188", VA = "0xBCC188")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60008EB")]
			[Address(RVA = "0xBCC1D4", Offset = "0xBCC1D4", VA = "0xBCC1D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008EC")]
			[Address(RVA = "0xBCC1D8", Offset = "0xBCC1D8", VA = "0xBCC1D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008EE")]
			[Address(RVA = "0xBCC5D0", Offset = "0xBCC5D0", VA = "0xBCC5D0", Slot = "8")]
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
		[Address(RVA = "0xBCC114", Offset = "0xBCC114", VA = "0xBCC114")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6612C4", Offset = "0x6612C4")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xBCC1B4", Offset = "0xBCC1B4", VA = "0xBCC1B4")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xBCC1C0", Offset = "0xBCC1C0", VA = "0xBCC1C0")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x2000131")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x40008E0")]
			Standalone,
			[Token(Token = "0x40008E1")]
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
		[Address(RVA = "0xBCC640", Offset = "0xBCC640", VA = "0xBCC640")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xBCC644", Offset = "0xBCC644", VA = "0xBCC644")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xBCC660", Offset = "0xBCC660", VA = "0xBCC660")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xBCCB10", Offset = "0xBCCB10", VA = "0xBCCB10")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GUIText camSwitchButton;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] objects;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_CurrentActiveObject;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xBCCB88", Offset = "0xBCCB88", VA = "0xBCCB88")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xBCCC04", Offset = "0xBCCC04", VA = "0xBCCC04")]
		public void NextCamera()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xBCCD54", Offset = "0xBCCD54", VA = "0xBCCD54")]
		public SimpleActivatorMenu()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xBCCD5C", Offset = "0xBCCD5C", VA = "0xBCCD5C")]
		private void Start()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xBCCDA0", Offset = "0xBCCDA0", VA = "0xBCCDA0")]
		private void Update()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xBCD214", Offset = "0xBCD214", VA = "0xBCD214")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xBCD2D8", Offset = "0xBCD2D8", VA = "0xBCD2D8")]
		private void Start()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xBCD2DC", Offset = "0xBCD2DC", VA = "0xBCD2DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xBCD6C0", Offset = "0xBCD6C0", VA = "0xBCD6C0")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000132")]
		public enum Action
		{
			[Token(Token = "0x40008E3")]
			Activate,
			[Token(Token = "0x40008E4")]
			Deactivate,
			[Token(Token = "0x40008E5")]
			Destroy,
			[Token(Token = "0x40008E6")]
			ReloadLevel,
			[Token(Token = "0x40008E7")]
			Call
		}

		[Serializable]
		[Token(Token = "0x2000133")]
		public class Entry
		{
			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x60008F0")]
			[Address(RVA = "0xBCDE88", Offset = "0xBCDE88", VA = "0xBCDE88")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000134")]
		public class Entries
		{
			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0xBCDA70", Offset = "0xBCDA70", VA = "0xBCDA70")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000135")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65763C", Offset = "0x65763C")]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008F5")]
				[Address(RVA = "0xBCDB5C", Offset = "0xBCDB5C", VA = "0xBCDB5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008F7")]
				[Address(RVA = "0xBCDBCC", Offset = "0xBCDBCC", VA = "0xBCDBCC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008F2")]
			[Address(RVA = "0xBCD984", Offset = "0xBCD984", VA = "0xBCD984")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60008F3")]
			[Address(RVA = "0xBCDA78", Offset = "0xBCDA78", VA = "0xBCDA78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008F4")]
			[Address(RVA = "0xBCDA7C", Offset = "0xBCDA7C", VA = "0xBCDA7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008F6")]
			[Address(RVA = "0xBCDB64", Offset = "0xBCDB64", VA = "0xBCDB64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000136")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65764C", Offset = "0x65764C")]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x170000BB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008FB")]
				[Address(RVA = "0xBCDCB8", Offset = "0xBCDCB8", VA = "0xBCDCB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008FD")]
				[Address(RVA = "0xBCDD28", Offset = "0xBCDD28", VA = "0xBCDD28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0xBCD9B0", Offset = "0xBCD9B0", VA = "0xBCD9B0")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0xBCDBD4", Offset = "0xBCDBD4", VA = "0xBCDBD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0xBCDBD8", Offset = "0xBCDBD8", VA = "0xBCDBD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0xBCDCC0", Offset = "0xBCDCC0", VA = "0xBCDCC0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000137")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65765C", Offset = "0x65765C")]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x170000BD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000901")]
				[Address(RVA = "0xBCDE10", Offset = "0xBCDE10", VA = "0xBCDE10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000903")]
				[Address(RVA = "0xBCDE80", Offset = "0xBCDE80", VA = "0xBCDE80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008FE")]
			[Address(RVA = "0xBCD9DC", Offset = "0xBCD9DC", VA = "0xBCD9DC")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60008FF")]
			[Address(RVA = "0xBCDD30", Offset = "0xBCDD30", VA = "0xBCDD30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000900")]
			[Address(RVA = "0xBCDD34", Offset = "0xBCDD34", VA = "0xBCDD34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000902")]
			[Address(RVA = "0xBCDE18", Offset = "0xBCDE18", VA = "0xBCDE18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xBCD6D4", Offset = "0xBCD6D4", VA = "0xBCD6D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xBCD828", Offset = "0xBCD828", VA = "0xBCD828")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x661328", Offset = "0x661328")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xBCD89C", Offset = "0xBCD89C", VA = "0xBCD89C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x66138C", Offset = "0x66138C")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xBCD910", Offset = "0xBCD910", VA = "0xBCD910")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6613F0", Offset = "0x6613F0")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xBCDA08", Offset = "0xBCDA08", VA = "0xBCDA08")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xBCDE90", Offset = "0xBCDE90", VA = "0xBCDE90")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xBCDEE8", Offset = "0xBCDEE8", VA = "0xBCDEE8")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xBCDF90", Offset = "0xBCDF90", VA = "0xBCDF90")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000138")]
		public class WaypointList
		{
			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x40008F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x6000904")]
			[Address(RVA = "0xBCF208", Offset = "0xBCF208", VA = "0xBCF208")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x2000139")]
		public struct RoutePoint
		{
			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x6000905")]
			[Address(RVA = "0x707C40", Offset = "0x707C40", VA = "0x707C40")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65787C", Offset = "0x65787C")]
		private float <Length>k__BackingField;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000001")]
		public float Length
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0xBCDFA0", Offset = "0xBCDFA0", VA = "0xBCDFA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661454", Offset = "0x661454")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004A")]
			[Address(RVA = "0xBCDFA8", Offset = "0xBCDFA8", VA = "0xBCDFA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661464", Offset = "0x661464")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0xBCDFB0", Offset = "0xBCDFB0", VA = "0xBCDFB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xBCDFDC", Offset = "0xBCDFDC", VA = "0xBCDFDC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xBCE4B8", Offset = "0xBCE4B8", VA = "0xBCE4B8")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xBCE5C8", Offset = "0xBCE5C8", VA = "0xBCE5C8")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xBCEA74", Offset = "0xBCEA74", VA = "0xBCEA74")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xBCE054", Offset = "0xBCE054", VA = "0xBCE054")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xBCEDD0", Offset = "0xBCEDD0", VA = "0xBCEDD0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xBCF18C", Offset = "0xBCF18C", VA = "0xBCF18C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xBCEDD8", Offset = "0xBCEDD8", VA = "0xBCEDD8")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xBCF194", Offset = "0xBCF194", VA = "0xBCF194")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x200013A")]
		public enum ProgressStyle
		{
			[Token(Token = "0x40008FA")]
			SmoothAlongRoute,
			[Token(Token = "0x40008FB")]
			PointToPoint
		}

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6578FC", Offset = "0x6578FC")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65790C", Offset = "0x65790C")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65791C", Offset = "0x65791C")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000003")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0xBCF268", Offset = "0xBCF268", VA = "0xBCF268")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661474", Offset = "0x661474")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xBCF27C", Offset = "0xBCF27C", VA = "0xBCF27C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661484", Offset = "0x661484")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xBCF290", Offset = "0xBCF290", VA = "0xBCF290")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661494", Offset = "0x661494")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xBCF2A4", Offset = "0xBCF2A4", VA = "0xBCF2A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6614A4", Offset = "0x6614A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0xBCF2B8", Offset = "0xBCF2B8", VA = "0xBCF2B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6614B4", Offset = "0x6614B4")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xBCF2CC", Offset = "0xBCF2CC", VA = "0xBCF2CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6614C4", Offset = "0x6614C4")]
			private set
			{
			}
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xBCF2E0", Offset = "0xBCF2E0", VA = "0xBCF2E0")]
		private void Start()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xBCF3C8", Offset = "0xBCF3C8", VA = "0xBCF3C8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xBCF570", Offset = "0xBCF570", VA = "0xBCF570")]
		private void Update()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xBCFC50", Offset = "0xBCFC50", VA = "0xBCFC50")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xBCFE70", Offset = "0xBCFE70", VA = "0xBCFE70")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x654A44", Offset = "0x654A44")]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xBC5F10", Offset = "0xBC5F10", VA = "0xBC5F10")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xBC5FA8", Offset = "0xBC5FA8", VA = "0xBC5FA8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xBC65C4", Offset = "0xBC65C4", VA = "0xBC65C4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xBC6C54", Offset = "0xBC6C54", VA = "0xBC6C54")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x200013B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65766C", Offset = "0x65766C")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x170000BF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000909")]
				[Address(RVA = "0xBC7540", Offset = "0xBC7540", VA = "0xBC7540", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600090B")]
				[Address(RVA = "0xBC75B0", Offset = "0xBC75B0", VA = "0xBC75B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000906")]
			[Address(RVA = "0xBC6CDC", Offset = "0xBC6CDC", VA = "0xBC6CDC")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000907")]
			[Address(RVA = "0xBC6E9C", Offset = "0xBC6E9C", VA = "0xBC6E9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000908")]
			[Address(RVA = "0xBC6EA0", Offset = "0xBC6EA0", VA = "0xBC6EA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600090A")]
			[Address(RVA = "0xBC7548", Offset = "0xBC7548", VA = "0xBC7548", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xBC6C68", Offset = "0xBC6C68", VA = "0xBC6C68")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6614D4", Offset = "0x6614D4")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xBC6D08", Offset = "0xBC6D08", VA = "0xBC6D08")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xBC6E94", Offset = "0xBC6E94", VA = "0xBC6E94")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x200013C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65767C", Offset = "0x65767C")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x170000C1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600090F")]
				[Address(RVA = "0xBC7A2C", Offset = "0xBC7A2C", VA = "0xBC7A2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000911")]
				[Address(RVA = "0xBC7A9C", Offset = "0xBC7A9C", VA = "0xBC7A9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600090C")]
			[Address(RVA = "0xBC762C", Offset = "0xBC762C", VA = "0xBC762C")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x600090D")]
			[Address(RVA = "0xBC7668", Offset = "0xBC7668", VA = "0xBC7668", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600090E")]
			[Address(RVA = "0xBC766C", Offset = "0xBC766C", VA = "0xBC766C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000910")]
			[Address(RVA = "0xBC7A34", Offset = "0xBC7A34", VA = "0xBC7A34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xBC75B8", Offset = "0xBC75B8", VA = "0xBC75B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x661538", Offset = "0x661538")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xBC7658", Offset = "0xBC7658", VA = "0xBC7658")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x200013D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65768C", Offset = "0x65768C")]
		private sealed class <OnCollisionEnter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Explosive <>4__this;

			[Token(Token = "0x4000906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Collision col;

			[Token(Token = "0x170000C3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000915")]
				[Address(RVA = "0xBC7FB0", Offset = "0xBC7FB0", VA = "0xBC7FB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000917")]
				[Address(RVA = "0xBC8020", Offset = "0xBC8020", VA = "0xBC8020", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000912")]
			[Address(RVA = "0xBC7B94", Offset = "0xBC7B94", VA = "0xBC7B94")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000913")]
			[Address(RVA = "0xBC7BEC", Offset = "0xBC7BEC", VA = "0xBC7BEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000914")]
			[Address(RVA = "0xBC7BF0", Offset = "0xBC7BF0", VA = "0xBC7BF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0xBC7FB8", Offset = "0xBC7FB8", VA = "0xBC7FB8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform explosionPrefab;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float detonationImpactVelocity;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sizeMultiplier;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool reset;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float resetTimeDelay;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_Exploded;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ObjectResetter m_ObjectResetter;

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xBC7AA4", Offset = "0xBC7AA4", VA = "0xBC7AA4")]
		private void Start()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xBC7AFC", Offset = "0xBC7AFC", VA = "0xBC7AFC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x66159C", Offset = "0x66159C")]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xBC7BC0", Offset = "0xBC7BC0", VA = "0xBC7BC0")]
		public void Reset()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xBC7BC8", Offset = "0xBC7BC8", VA = "0xBC7BC8")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xBC8028", Offset = "0xBC8028", VA = "0xBC8028")]
		private void Start()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xBC8080", Offset = "0xBC8080", VA = "0xBC8080")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xBC811C", Offset = "0xBC811C", VA = "0xBC811C")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xBC812C", Offset = "0xBC812C", VA = "0xBC812C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xBC819C", Offset = "0xBC819C", VA = "0xBC819C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xBC8424", Offset = "0xBC8424", VA = "0xBC8424")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xBC845C", Offset = "0xBC845C", VA = "0xBC845C")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xBC846C", Offset = "0xBC846C", VA = "0xBC846C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xBC86A8", Offset = "0xBC86A8", VA = "0xBC86A8")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xBC86C4", Offset = "0xBC86C4", VA = "0xBC86C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xBC8880", Offset = "0xBC8880", VA = "0xBC8880")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xBC8890", Offset = "0xBC8890", VA = "0xBC8890")]
		private void Start()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xBC898C", Offset = "0xBC898C", VA = "0xBC898C")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xBC8994", Offset = "0xBC8994", VA = "0xBC8994")]
		private void Start()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xBC89EC", Offset = "0xBC89EC", VA = "0xBC89EC")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xBC8C9C", Offset = "0xBC8C9C", VA = "0xBC8C9C")]
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
		[Address(RVA = "0x1588298", Offset = "0x1588298", VA = "0x1588298")]
		private void Update()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1588510", Offset = "0x1588510", VA = "0x1588510")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x654AB8", Offset = "0x654AB8")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x158303C", Offset = "0x158303C", VA = "0x158303C")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1583060", Offset = "0x1583060", VA = "0x1583060")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x15830C0", Offset = "0x15830C0", VA = "0x15830C0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1583120", Offset = "0x1583120", VA = "0x1583120")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x654B2C", Offset = "0x654B2C")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1583128", Offset = "0x1583128", VA = "0x1583128")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class MeshContainer
	{
		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1583130", Offset = "0x1583130", VA = "0x1583130")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x15831A4", Offset = "0x15831A4", VA = "0x15831A4")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x654BA0", Offset = "0x654BA0")]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1583208", Offset = "0x1583208", VA = "0x1583208")]
		public void Start()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x15833B8", Offset = "0x15833B8", VA = "0x15833B8")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1583778", Offset = "0x1583778", VA = "0x1583778")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x158389C", Offset = "0x158389C", VA = "0x158389C")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x15839BC", Offset = "0x15839BC", VA = "0x15839BC")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1584610", Offset = "0x1584610", VA = "0x1584610")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1584670", Offset = "0x1584670", VA = "0x1584670")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1584778", Offset = "0x1584778", VA = "0x1584778")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x15847D8", Offset = "0x15847D8", VA = "0x15847D8")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1583B4C", Offset = "0x1583B4C", VA = "0x1583B4C")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1584838", Offset = "0x1584838", VA = "0x1584838")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1584DC8", Offset = "0x1584DC8", VA = "0x1584DC8")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x158491C", Offset = "0x158491C", VA = "0x158491C")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1585010", Offset = "0x1585010", VA = "0x1585010")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1584BE0", Offset = "0x1584BE0", VA = "0x1584BE0")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1585030", Offset = "0x1585030", VA = "0x1585030")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x654C14", Offset = "0x654C14")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x15850A4", Offset = "0x15850A4", VA = "0x15850A4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x15851DC", Offset = "0x15851DC", VA = "0x15851DC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1585494", Offset = "0x1585494", VA = "0x1585494")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x200013E")]
		public enum WaterMode
		{
			[Token(Token = "0x4000908")]
			Simple,
			[Token(Token = "0x4000909")]
			Reflective,
			[Token(Token = "0x400090A")]
			Refractive
		}

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x158549C", Offset = "0x158549C", VA = "0x158549C")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x15877DC", Offset = "0x15877DC", VA = "0x15877DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1587B88", Offset = "0x1587B88", VA = "0x1587B88")]
		private void Update()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1586F7C", Offset = "0x1586F7C", VA = "0x1586F7C")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x15861F8", Offset = "0x15861F8", VA = "0x15861F8")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x15861E4", Offset = "0x15861E4", VA = "0x15861E4")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x158608C", Offset = "0x158608C", VA = "0x158608C")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x15875F4", Offset = "0x15875F4", VA = "0x15875F4")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1587350", Offset = "0x1587350", VA = "0x1587350")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1587E68", Offset = "0x1587E68", VA = "0x1587E68")]
		public Water()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public enum WaterQuality
	{
		[Token(Token = "0x40000BD")]
		High = 2,
		[Token(Token = "0x40000BE")]
		Medium = 1,
		[Token(Token = "0x40000BF")]
		Low = 0
	}
	[Token(Token = "0x200002C")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1587F44", Offset = "0x1587F44", VA = "0x1587F44")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1588124", Offset = "0x1588124", VA = "0x1588124")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x15881FC", Offset = "0x15881FC", VA = "0x15881FC")]
		public void Update()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1588280", Offset = "0x1588280", VA = "0x1588280")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1588518", Offset = "0x1588518", VA = "0x1588518")]
		public void Start()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x158851C", Offset = "0x158851C", VA = "0x158851C")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1588714", Offset = "0x1588714", VA = "0x1588714")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1588830", Offset = "0x1588830", VA = "0x1588830")]
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
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xBC1F30", Offset = "0xBC1F30", VA = "0xBC1F30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xBC21D8", Offset = "0xBC21D8", VA = "0xBC21D8")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xBC2380", Offset = "0xBC2380", VA = "0xBC2380")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xBC2414", Offset = "0xBC2414", VA = "0xBC2414", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xBC2510", Offset = "0xBC2510", VA = "0xBC2510", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xBC25BC", Offset = "0xBC25BC", VA = "0xBC25BC")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xBC2624", Offset = "0xBC2624", VA = "0xBC2624")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xBC2628", Offset = "0xBC2628", VA = "0xBC2628")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xBC2718", Offset = "0xBC2718", VA = "0xBC2718")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xBC2808", Offset = "0xBC2808", VA = "0xBC2808")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xBC28F8", Offset = "0xBC28F8", VA = "0xBC28F8")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xBC29E8", Offset = "0xBC29E8", VA = "0xBC29E8")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xBC2AD8", Offset = "0xBC2AD8", VA = "0xBC2AD8")]
		public void Update()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xBC2ADC", Offset = "0xBC2ADC", VA = "0xBC2ADC")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200013F")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x400090C")]
			Hardware,
			[Token(Token = "0x400090D")]
			Touch
		}

		[Token(Token = "0x2000140")]
		public class VirtualAxis
		{
			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65D8C0", Offset = "0x65D8C0")]
			private string <name>k__BackingField;

			[Token(Token = "0x400090F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x4000910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65D8D0", Offset = "0x65D8D0")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x170000C5")]
			public string name
			{
				[Token(Token = "0x6000918")]
				[Address(RVA = "0xBC3A50", Offset = "0xBC3A50", VA = "0xBC3A50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x663EB4", Offset = "0x663EB4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000919")]
				[Address(RVA = "0xBC3A58", Offset = "0xBC3A58", VA = "0xBC3A58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x663EC4", Offset = "0x663EC4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C6")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600091A")]
				[Address(RVA = "0xBC3A60", Offset = "0xBC3A60", VA = "0xBC3A60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x663ED4", Offset = "0x663ED4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600091B")]
				[Address(RVA = "0xBC3A68", Offset = "0xBC3A68", VA = "0xBC3A68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x663EE4", Offset = "0x663EE4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C7")]
			public float GetValue
			{
				[Token(Token = "0x6000920")]
				[Address(RVA = "0xBC2500", Offset = "0xBC2500", VA = "0xBC2500")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000C8")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000921")]
				[Address(RVA = "0xBC3AB4", Offset = "0xBC3AB4", VA = "0xBC3AB4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600091C")]
			[Address(RVA = "0xBC20A4", Offset = "0xBC20A4", VA = "0xBC20A4")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x600091D")]
			[Address(RVA = "0xBC3A74", Offset = "0xBC3A74", VA = "0xBC3A74")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600091E")]
			[Address(RVA = "0xBC23AC", Offset = "0xBC23AC", VA = "0xBC23AC")]
			public void Remove()
			{
			}

			[Token(Token = "0x600091F")]
			[Address(RVA = "0xBC2508", Offset = "0xBC2508", VA = "0xBC2508")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000141")]
		public class VirtualButton
		{
			[Token(Token = "0x4000911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65D8E0", Offset = "0x65D8E0")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65D8F0", Offset = "0x65D8F0")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x4000913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x4000914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x170000C9")]
			public string name
			{
				[Token(Token = "0x6000922")]
				[Address(RVA = "0xBC3ABC", Offset = "0xBC3ABC", VA = "0xBC3ABC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x663EF4", Offset = "0x663EF4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000923")]
				[Address(RVA = "0xBC3AC4", Offset = "0xBC3AC4", VA = "0xBC3AC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x663F04", Offset = "0x663F04")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CA")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000924")]
				[Address(RVA = "0xBC3ACC", Offset = "0xBC3ACC", VA = "0xBC3ACC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x663F14", Offset = "0x663F14")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000925")]
				[Address(RVA = "0xBC3AD4", Offset = "0xBC3AD4", VA = "0xBC3AD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x663F24", Offset = "0x663F24")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CB")]
			public bool GetButton
			{
				[Token(Token = "0x600092B")]
				[Address(RVA = "0xBC3C30", Offset = "0xBC3C30", VA = "0xBC3C30")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000CC")]
			public bool GetButtonDown
			{
				[Token(Token = "0x600092C")]
				[Address(RVA = "0xBC3C38", Offset = "0xBC3C38", VA = "0xBC3C38")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000CD")]
			public bool GetButtonUp
			{
				[Token(Token = "0x600092D")]
				[Address(RVA = "0xBC3C68", Offset = "0xBC3C68", VA = "0xBC3C68")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000926")]
			[Address(RVA = "0xBC3AE0", Offset = "0xBC3AE0", VA = "0xBC3AE0")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x6000927")]
			[Address(RVA = "0xBC3B1C", Offset = "0xBC3B1C", VA = "0xBC3B1C")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0xBC3B64", Offset = "0xBC3B64", VA = "0xBC3B64")]
			public void Pressed()
			{
			}

			[Token(Token = "0x6000929")]
			[Address(RVA = "0xBC3B9C", Offset = "0xBC3B9C", VA = "0xBC3B9C")]
			public void Released()
			{
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0xBC3BC8", Offset = "0xBC3BC8", VA = "0xBC3BC8")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x17000006")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xBC36BC", Offset = "0xBC36BC", VA = "0xBC36BC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xBC2AE4", Offset = "0xBC2AE4", VA = "0xBC2AE4")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xBC2B84", Offset = "0xBC2B84", VA = "0xBC2B84")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xBC2024", Offset = "0xBC2024", VA = "0xBC2024")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xBC2CA4", Offset = "0xBC2CA4", VA = "0xBC2CA4")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xBC20D8", Offset = "0xBC20D8", VA = "0xBC20D8")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xBC2EF0", Offset = "0xBC2EF0", VA = "0xBC2EF0")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xBC30CC", Offset = "0xBC30CC", VA = "0xBC30CC")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xBC3240", Offset = "0xBC3240", VA = "0xBC3240")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xBC2158", Offset = "0xBC2158", VA = "0xBC2158")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xBBB9E4", Offset = "0xBBB9E4", VA = "0xBBB9E4")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xBC34AC", Offset = "0xBC34AC", VA = "0xBC34AC")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xBC3414", Offset = "0xBC3414", VA = "0xBC3414")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xBC3514", Offset = "0xBC3514", VA = "0xBC3514")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xBBD510", Offset = "0xBBD510", VA = "0xBBD510")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xBC359C", Offset = "0xBC359C", VA = "0xBC359C")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xBC2690", Offset = "0xBC2690", VA = "0xBC2690")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xBC2780", Offset = "0xBC2780", VA = "0xBC2780")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xBC2870", Offset = "0xBC2870", VA = "0xBC2870")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xBC2A50", Offset = "0xBC2A50", VA = "0xBC2A50")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xBC2960", Offset = "0xBC2960", VA = "0xBC2960")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xBC3624", Offset = "0xBC3624", VA = "0xBC3624")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xBC3740", Offset = "0xBC3740", VA = "0xBC3740")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xBC3840", Offset = "0xBC3840", VA = "0xBC3840")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xBC394C", Offset = "0xBC394C", VA = "0xBC394C")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xBC3C98", Offset = "0xBC3C98", VA = "0xBC3C98")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xBC3C9C", Offset = "0xBC3C9C", VA = "0xBC3C9C")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xBC3D1C", Offset = "0xBC3D1C", VA = "0xBC3D1C")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000142")]
		public enum AxisOption
		{
			[Token(Token = "0x4000917")]
			Both,
			[Token(Token = "0x4000918")]
			OnlyHorizontal,
			[Token(Token = "0x4000919")]
			OnlyVertical
		}

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xBC3D24", Offset = "0xBC3D24", VA = "0xBC3D24")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xBC3E84", Offset = "0xBC3E84", VA = "0xBC3E84")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xBC3EC8", Offset = "0xBC3EC8", VA = "0xBC3EC8")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xBC3D28", Offset = "0xBC3D28", VA = "0xBC3D28")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xBC3FCC", Offset = "0xBC3FCC", VA = "0xBC3FCC", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xBC41B8", Offset = "0xBC41B8", VA = "0xBC41B8", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xBC4224", Offset = "0xBC4224", VA = "0xBC4224", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xBC4228", Offset = "0xBC4228", VA = "0xBC4228")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xBC428C", Offset = "0xBC428C", VA = "0xBC428C")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xBC42FC", Offset = "0xBC42FC", VA = "0xBC42FC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xBC430C", Offset = "0xBC430C", VA = "0xBC430C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xBC4304", Offset = "0xBC4304", VA = "0xBC4304")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xBC440C", Offset = "0xBC440C", VA = "0xBC440C")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xBC4784", Offset = "0xBC4784", VA = "0xBC4784")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000143")]
		public enum AxisOptions
		{
			[Token(Token = "0x400091B")]
			ForwardAxis,
			[Token(Token = "0x400091C")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x2000144")]
		public class AxisMapping
		{
			[Token(Token = "0x20001C3")]
			public enum MappingType
			{
				[Token(Token = "0x4000C2F")]
				NamedAxis,
				[Token(Token = "0x4000C30")]
				MousePositionX,
				[Token(Token = "0x4000C31")]
				MousePositionY,
				[Token(Token = "0x4000C32")]
				MousePositionZ
			}

			[Token(Token = "0x400091D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x600092E")]
			[Address(RVA = "0xBC57B8", Offset = "0xBC57B8", VA = "0xBC57B8")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xBC540C", Offset = "0xBC540C", VA = "0xBC540C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xBC54E0", Offset = "0xBC54E0", VA = "0xBC54E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xBC577C", Offset = "0xBC577C", VA = "0xBC577C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xBC57A8", Offset = "0xBC57A8", VA = "0xBC57A8")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x654CC8", Offset = "0x654CC8")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000145")]
		public enum AxisOption
		{
			[Token(Token = "0x4000920")]
			Both,
			[Token(Token = "0x4000921")]
			OnlyHorizontal,
			[Token(Token = "0x4000922")]
			OnlyVertical
		}

		[Token(Token = "0x2000146")]
		public enum ControlStyle
		{
			[Token(Token = "0x4000924")]
			Absolute,
			[Token(Token = "0x4000925")]
			Relative,
			[Token(Token = "0x4000926")]
			Swipe
		}

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xBC57C0", Offset = "0xBC57C0", VA = "0xBC57C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xBC5920", Offset = "0xBC5920", VA = "0xBC5920")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xBC57C4", Offset = "0xBC57C4", VA = "0xBC57C4")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xBC59B0", Offset = "0xBC59B0", VA = "0xBC59B0")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xBC5A38", Offset = "0xBC5A38", VA = "0xBC5A38", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xBC5B10", Offset = "0xBC5B10", VA = "0xBC5B10")]
		private void Update()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xBC5D24", Offset = "0xBC5D24", VA = "0xBC5D24", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xBC5D9C", Offset = "0xBC5D9C", VA = "0xBC5D9C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xBC5E90", Offset = "0xBC5E90", VA = "0xBC5E90")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65792C", Offset = "0x65792C")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x17000007")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0xBC5048", Offset = "0xBC5048", VA = "0xBC5048")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661600", Offset = "0x661600")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xBC5F04", Offset = "0xBC5F04", VA = "0xBC5F04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661610", Offset = "0x661610")]
			private set
			{
			}
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xBC2C34", Offset = "0xBC2C34", VA = "0xBC2C34")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xBC2D24", Offset = "0xBC2D24", VA = "0xBC2D24")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xBC2D94", Offset = "0xBC2D94", VA = "0xBC2D94")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xBC2F70", Offset = "0xBC2F70", VA = "0xBC2F70")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xBC3194", Offset = "0xBC3194", VA = "0xBC3194")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xBC32C0", Offset = "0xBC32C0", VA = "0xBC32C0")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xBC336C", Offset = "0xBC336C", VA = "0xBC336C")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xBC37F4", Offset = "0xBC37F4", VA = "0xBC37F4")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xBC38F8", Offset = "0xBC38F8", VA = "0xBC38F8")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xBC3A00", Offset = "0xBC3A00", VA = "0xBC3A00")]
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
		[Address(RVA = "0xBC5054", Offset = "0xBC5054", VA = "0xBC5054")]
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
		[Address(RVA = "0xBC478C", Offset = "0xBC478C", VA = "0xBC478C")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xBC4820", Offset = "0xBC4820", VA = "0xBC4820")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xBC48AC", Offset = "0xBC48AC", VA = "0xBC48AC", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xBC4964", Offset = "0xBC4964", VA = "0xBC4964", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xBC4A34", Offset = "0xBC4A34", VA = "0xBC4A34", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xBC4AF8", Offset = "0xBC4AF8", VA = "0xBC4AF8", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xBC4BB4", Offset = "0xBC4BB4", VA = "0xBC4BB4", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xBC4C70", Offset = "0xBC4C70", VA = "0xBC4C70", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xBC4D28", Offset = "0xBC4D28", VA = "0xBC4D28", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xBC4DEC", Offset = "0xBC4DEC", VA = "0xBC4DEC", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xBC4EB8", Offset = "0xBC4EB8", VA = "0xBC4EB8", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xBC4F84", Offset = "0xBC4F84", VA = "0xBC4F84", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xBC503C", Offset = "0xBC503C", VA = "0xBC503C", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xBC2B7C", Offset = "0xBC2B7C", VA = "0xBC2B7C")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000116")]
		[Address(RVA = "0xBC5114", Offset = "0xBC5114", VA = "0xBC5114", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xBC5128", Offset = "0xBC5128", VA = "0xBC5128", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xBC5134", Offset = "0xBC5134", VA = "0xBC5134", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xBC5140", Offset = "0xBC5140", VA = "0xBC5140", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xBC514C", Offset = "0xBC514C", VA = "0xBC514C", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xBC51C0", Offset = "0xBC51C0", VA = "0xBC51C0", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xBC5234", Offset = "0xBC5234", VA = "0xBC5234", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xBC52A8", Offset = "0xBC52A8", VA = "0xBC52A8", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xBC531C", Offset = "0xBC531C", VA = "0xBC531C", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xBC5390", Offset = "0xBC5390", VA = "0xBC5390", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xBC5404", Offset = "0xBC5404", VA = "0xBC5404", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xBC2B80", Offset = "0xBC2B80", VA = "0xBC2B80")]
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
		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CarController car;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Renderer m_Renderer;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xBD375C", Offset = "0xBD375C", VA = "0xBD375C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xBD37B4", Offset = "0xBD37B4", VA = "0xBD37B4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xBD380C", Offset = "0xBD380C", VA = "0xBD380C")]
		public BrakeLight()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x654D2C", Offset = "0x654D2C")]
	public class CarAIControl : MonoBehaviour
	{
		[Token(Token = "0x2000147")]
		public enum BrakeCondition
		{
			[Token(Token = "0x4000928")]
			NeverBrake,
			[Token(Token = "0x4000929")]
			TargetDirectionDifference,
			[Token(Token = "0x400092A")]
			TargetDistance
		}

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65793C", Offset = "0x65793C")]
		private float m_CautiousSpeedFactor;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65797C", Offset = "0x65797C")]
		private float m_CautiousMaxAngle;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_CautiousMaxDistance;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_CautiousAngularVelocityFactor;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_SteerSensitivity;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_AccelSensitivity;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_BrakeSensitivity;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_LateralWanderDistance;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_LateralWanderSpeed;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x657A30", Offset = "0x657A30")]
		private float m_AccelWanderAmount;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_AccelWanderSpeed;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private BrakeCondition m_BrakeCondition;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool m_Driving;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform m_Target;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_StopWhenTargetReached;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_ReachTargetThreshold;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float m_RandomPerlin;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CarController m_CarController;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_AvoidOtherCarTime;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float m_AvoidOtherCarSlowdown;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float m_AvoidPathOffset;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xBD3814", Offset = "0xBD3814", VA = "0xBD3814")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xBD389C", Offset = "0xBD389C", VA = "0xBD389C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xBD44A0", Offset = "0xBD44A0", VA = "0xBD44A0")]
		private void OnCollisionStay(Collision col)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xBD47B8", Offset = "0xBD47B8", VA = "0xBD47B8")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xBD47C8", Offset = "0xBD47C8", VA = "0xBD47C8")]
		public CarAIControl()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x654D90", Offset = "0x654D90")]
	public class CarAudio : MonoBehaviour
	{
		[Token(Token = "0x2000148")]
		public enum EngineAudioOptions
		{
			[Token(Token = "0x400092C")]
			Simple,
			[Token(Token = "0x400092D")]
			FourChannel
		}

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EngineAudioOptions engineSoundStyle;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip lowAccelClip;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip lowDecelClip;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip highAccelClip;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip highDecelClip;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pitchMultiplier;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float lowPitchMin;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float lowPitchMax;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float highPitchMultiplier;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float maxRolloffDistance;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dopplerLevel;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool useDoppler;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource m_LowAccel;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AudioSource m_LowDecel;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AudioSource m_HighAccel;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private AudioSource m_HighDecel;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_StartedSound;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CarController m_CarController;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xBD4810", Offset = "0xBD4810", VA = "0xBD4810")]
		private void StartSound()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xBD4A98", Offset = "0xBD4A98", VA = "0xBD4A98")]
		private void StopSound()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xBD4B78", Offset = "0xBD4B78", VA = "0xBD4B78")]
		private void Update()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xBD48BC", Offset = "0xBD48BC", VA = "0xBD48BC")]
		private AudioSource SetUpEngineAudioSource(AudioClip clip)
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xBD5088", Offset = "0xBD5088", VA = "0xBD5088")]
		private static float ULerp(float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xBD50A8", Offset = "0xBD50A8", VA = "0xBD50A8")]
		public CarAudio()
		{
		}
	}
	[Token(Token = "0x200003C")]
	internal enum CarDriveType
	{
		[Token(Token = "0x400011F")]
		FrontWheelDrive,
		[Token(Token = "0x4000120")]
		RearWheelDrive,
		[Token(Token = "0x4000121")]
		FourWheelDrive
	}
	[Token(Token = "0x200003D")]
	internal enum SpeedType
	{
		[Token(Token = "0x4000123")]
		MPH,
		[Token(Token = "0x4000124")]
		KPH
	}
	[Token(Token = "0x200003E")]
	public class CarController : MonoBehaviour
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CarDriveType m_CarDriveType;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WheelCollider[] m_WheelColliders;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] m_WheelMeshes;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private WheelEffects[] m_WheelEffects;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector3 m_CentreOfMassOffset;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_MaximumSteerAngle;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x657B30", Offset = "0x657B30")]
		[SerializeField]
		private float m_SteerHelper;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x657B70", Offset = "0x657B70")]
		[SerializeField]
		private float m_TractionControl;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_FullTorqueOverAllWheels;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_ReverseTorque;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_MaxHandbrakeTorque;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_Downforce;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SpeedType m_SpeedType;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_Topspeed;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private static int NoOfGears;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_RevRangeBoundary;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_SlipLimit;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float m_BrakeTorque;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion[] m_WheelMeshLocalRotations;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Prevpos;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 m_Pos;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float m_SteerAngle;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int m_GearNum;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float m_GearFactor;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float m_OldRotation;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float m_CurrentTorque;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000140")]
		private const float k_ReversingThreshold = 0.01f;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x657C50", Offset = "0x657C50")]
		private bool <Skidding>k__BackingField;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x657C60", Offset = "0x657C60")]
		private float <BrakeInput>k__BackingField;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x657C70", Offset = "0x657C70")]
		private float <Revs>k__BackingField;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x657C80", Offset = "0x657C80")]
		private float <AccelInput>k__BackingField;

		[Token(Token = "0x17000008")]
		public bool Skidding
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0xBD50D4", Offset = "0xBD50D4", VA = "0xBD50D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661620", Offset = "0x661620")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0xBD50DC", Offset = "0xBD50DC", VA = "0xBD50DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661630", Offset = "0x661630")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public float BrakeInput
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0xBD3804", Offset = "0xBD3804", VA = "0xBD3804")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661640", Offset = "0x661640")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0xBD50E8", Offset = "0xBD50E8", VA = "0xBD50E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661650", Offset = "0x661650")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public float CurrentSteerAngle
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0xBD50F0", Offset = "0xBD50F0", VA = "0xBD50F0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000B")]
		public float CurrentSpeed
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0xBD443C", Offset = "0xBD443C", VA = "0xBD443C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000C")]
		public float MaxSpeed
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0xBD4434", Offset = "0xBD4434", VA = "0xBD4434")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000D")]
		public float Revs
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0xBD5080", Offset = "0xBD5080", VA = "0xBD5080")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661660", Offset = "0x661660")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000138")]
			[Address(RVA = "0xBD50F8", Offset = "0xBD50F8", VA = "0xBD50F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661670", Offset = "0x661670")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public float AccelInput
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0xBD50A0", Offset = "0xBD50A0", VA = "0xBD50A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661680", Offset = "0x661680")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0xBD5100", Offset = "0xBD5100", VA = "0xBD5100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661690", Offset = "0x661690")]
			private set
			{
			}
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xBD5108", Offset = "0xBD5108", VA = "0xBD5108")]
		private void Start()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xBD52EC", Offset = "0xBD52EC", VA = "0xBD52EC")]
		private void GearChanging()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xBD541C", Offset = "0xBD541C", VA = "0xBD541C")]
		private static float CurveFactor(float factor)
		{
			return default(float);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xBD5430", Offset = "0xBD5430", VA = "0xBD5430")]
		private static float ULerp(float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xBD5448", Offset = "0xBD5448", VA = "0xBD5448")]
		private void CalculateGearFactor()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xBD5554", Offset = "0xBD5554", VA = "0xBD5554")]
		private void CalculateRevs()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xBD4030", Offset = "0xBD4030", VA = "0xBD4030")]
		public void Move(float steering, float accel, float footbrake, float handbrake)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xBD5D08", Offset = "0xBD5D08", VA = "0xBD5D08")]
		private void CapSpeed()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xBD5904", Offset = "0xBD5904", VA = "0xBD5904")]
		private void ApplyDrive(float accel, float footbrake)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xBD5628", Offset = "0xBD5628", VA = "0xBD5628")]
		private void SteerHelper()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xBD5E78", Offset = "0xBD5E78", VA = "0xBD5E78")]
		private void AddDownForce()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xBD605C", Offset = "0xBD605C", VA = "0xBD605C")]
		private void CheckForWheelSpin()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xBD632C", Offset = "0xBD632C", VA = "0xBD632C")]
		private void TractionControl()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xBD66C0", Offset = "0xBD66C0", VA = "0xBD66C0")]
		private void AdjustTorque(float forwardSlip)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xBD6630", Offset = "0xBD6630", VA = "0xBD6630")]
		private bool AnySkidSoundPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xBD6708", Offset = "0xBD6708", VA = "0xBD6708")]
		public CarController()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class CarSelfRighting : MonoBehaviour
	{
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_WaitTime;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_VelocityThreshold;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_LastOkTime;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xBD6808", Offset = "0xBD6808", VA = "0xBD6808")]
		private void Start()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xBD6860", Offset = "0xBD6860", VA = "0xBD6860")]
		private void Update()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xBD6920", Offset = "0xBD6920", VA = "0xBD6920")]
		private void RightCar()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xBD6AC0", Offset = "0xBD6AC0", VA = "0xBD6AC0")]
		public CarSelfRighting()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x654DF4", Offset = "0x654DF4")]
	public class CarUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CarController m_Car;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xBD6AD4", Offset = "0xBD6AD4", VA = "0xBD6AD4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xBD6B2C", Offset = "0xBD6B2C", VA = "0xBD6B2C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xBD6BE0", Offset = "0xBD6BE0", VA = "0xBD6BE0")]
		public CarUserControl()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class Mudguard : MonoBehaviour
	{
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CarController carController;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xBD6BE8", Offset = "0xBD6BE8", VA = "0xBD6BE8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xBD6C2C", Offset = "0xBD6C2C", VA = "0xBD6C2C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xBD6D40", Offset = "0xBD6D40", VA = "0xBD6D40")]
		public Mudguard()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class SkidTrail : MonoBehaviour
	{
		[Token(Token = "0x2000149")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65769C", Offset = "0x65769C")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400092E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400092F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SkidTrail <>4__this;

			[Token(Token = "0x170000CE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000932")]
				[Address(RVA = "0xBD6F68", Offset = "0xBD6F68", VA = "0xBD6F68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000934")]
				[Address(RVA = "0xBD6FD8", Offset = "0xBD6FD8", VA = "0xBD6FD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600092F")]
			[Address(RVA = "0xBD6DBC", Offset = "0xBD6DBC", VA = "0xBD6DBC")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000930")]
			[Address(RVA = "0xBD6DF0", Offset = "0xBD6DF0", VA = "0xBD6DF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000931")]
			[Address(RVA = "0xBD6DF4", Offset = "0xBD6DF4", VA = "0xBD6DF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000933")]
			[Address(RVA = "0xBD6F70", Offset = "0xBD6F70", VA = "0xBD6F70", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_PersistTime;

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xBD6D48", Offset = "0xBD6D48", VA = "0xBD6D48")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6616A0", Offset = "0x6616A0")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xBD6DE8", Offset = "0xBD6DE8", VA = "0xBD6DE8")]
		public SkidTrail()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class Suspension : MonoBehaviour
	{
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject wheel;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 m_TargetOriginalPosition;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_Origin;

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xBD6FE0", Offset = "0xBD6FE0", VA = "0xBD6FE0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xBD7064", Offset = "0xBD7064", VA = "0xBD7064")]
		private void Update()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xBD71BC", Offset = "0xBD71BC", VA = "0xBD71BC")]
		public Suspension()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x654E58", Offset = "0x654E58")]
	public class WheelEffects : MonoBehaviour
	{
		[Token(Token = "0x200014A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6576AC", Offset = "0x6576AC")]
		private sealed class <StartSkidTrail>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WheelEffects <>4__this;

			[Token(Token = "0x170000D0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000938")]
				[Address(RVA = "0x1582FC4", Offset = "0x1582FC4", VA = "0x1582FC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600093A")]
				[Address(RVA = "0x1583034", Offset = "0x1583034", VA = "0x1583034", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000935")]
			[Address(RVA = "0x1582C90", Offset = "0x1582C90", VA = "0x1582C90")]
			[DebuggerHidden]
			public <StartSkidTrail>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0x1582DAC", Offset = "0x1582DAC", VA = "0x1582DAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0x1582DB0", Offset = "0x1582DB0", VA = "0x1582DB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000939")]
			[Address(RVA = "0x1582FCC", Offset = "0x1582FCC", VA = "0x1582FCC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform SkidTrailPrefab;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Transform skidTrailsDetachedParent;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleSystem skidParticles;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x657CC0", Offset = "0x657CC0")]
		private bool <skidding>k__BackingField;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x657CD0", Offset = "0x657CD0")]
		private bool <PlayingAudio>k__BackingField;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_SkidTrail;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WheelCollider m_WheelCollider;

		[Token(Token = "0x1700000F")]
		public bool skidding
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x1582798", Offset = "0x1582798", VA = "0x1582798")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661704", Offset = "0x661704")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x15827A0", Offset = "0x15827A0", VA = "0x15827A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661714", Offset = "0x661714")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public bool PlayingAudio
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x15827AC", Offset = "0x15827AC", VA = "0x15827AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661724", Offset = "0x661724")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x15827B4", Offset = "0x15827B4", VA = "0x15827B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661734", Offset = "0x661734")]
			private set
			{
			}
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x15827C0", Offset = "0x15827C0", VA = "0x15827C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x15829B4", Offset = "0x15829B4", VA = "0x15829B4")]
		public void EmitTyreSmoke()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1582C14", Offset = "0x1582C14", VA = "0x1582C14")]
		public void PlayAudio()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1582C54", Offset = "0x1582C54", VA = "0x1582C54")]
		public void StopAudio()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1582BA0", Offset = "0x1582BA0", VA = "0x1582BA0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x661744", Offset = "0x661744")]
		public IEnumerator StartSkidTrail()
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1582CBC", Offset = "0x1582CBC", VA = "0x1582CBC")]
		public void EndSkidTrail()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1582DA4", Offset = "0x1582DA4", VA = "0x1582DA4")]
		public WheelEffects()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Aeroplane
{
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x654EBC", Offset = "0x654EBC")]
	public class AeroplaneAiControl : MonoBehaviour
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_RollSensitivity;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_PitchSensitivity;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_LateralWanderDistance;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_LateralWanderSpeed;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_MaxClimbAngle;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MaxRollAngle;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_SpeedEffect;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_TakeoffHeight;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform m_Target;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AeroplaneController m_AeroplaneController;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_RandomPerlin;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool m_TakenOff;

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xBCFE8C", Offset = "0xBCFE8C", VA = "0xBCFE8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xBCFEFC", Offset = "0xBCFEFC", VA = "0xBCFEFC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xBCFF04", Offset = "0xBCFF04", VA = "0xBCFF04")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xBD02D8", Offset = "0xBD02D8", VA = "0xBD02D8")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xBD02E0", Offset = "0xBD02E0", VA = "0xBD02E0")]
		public AeroplaneAiControl()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class AeroplaneAudio : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014B")]
		public class AdvancedSetttings
		{
			[Token(Token = "0x4000934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float engineMinDistance;

			[Token(Token = "0x4000935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float engineMaxDistance;

			[Token(Token = "0x4000936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float engineDopplerLevel;

			[Token(Token = "0x4000937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65D900", Offset = "0x65D900")]
			public float engineMasterVolume;

			[Token(Token = "0x4000938")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float windMinDistance;

			[Token(Token = "0x4000939")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float windMaxDistance;

			[Token(Token = "0x400093A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float windDopplerLevel;

			[Token(Token = "0x400093B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65D918", Offset = "0x65D918")]
			public float windMasterVolume;

			[Token(Token = "0x600093B")]
			[Address(RVA = "0xBD0938", Offset = "0xBD0938", VA = "0xBD0938")]
			public AdvancedSetttings()
			{
			}
		}

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioClip m_EngineSound;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_EngineMinThrottlePitch;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_EngineMaxThrottlePitch;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_EngineFwdSpeedMultiplier;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip m_WindSound;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_WindBasePitch;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_WindSpeedPitchFactor;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_WindMaxSpeedVolume;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AdvancedSetttings m_AdvancedSetttings;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AudioSource m_EngineSoundSource;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AudioSource m_WindSoundSource;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xBD0300", Offset = "0xBD0300", VA = "0xBD0300")]
		private void Awake()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xBD0600", Offset = "0xBD0600", VA = "0xBD0600")]
		private void Update()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xBD0884", Offset = "0xBD0884", VA = "0xBD0884")]
		public AeroplaneAudio()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x654F20", Offset = "0x654F20")]
	public class AeroplaneController : MonoBehaviour
	{
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MaxEnginePower;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_Lift;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_ZeroLiftSpeed;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_RollEffect;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_PitchEffect;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_YawEffect;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_BankedTurnEffect;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_AerodynamicEffect;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_AutoTurnPitch;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_AutoRollLevel;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_AutoPitchLevel;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_AirBrakesEffect;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float m_ThrottleChangeSpeed;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_DragIncreaseFactor;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x657EE0", Offset = "0x657EE0")]
		private float <Altitude>k__BackingField;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x657EF0", Offset = "0x657EF0")]
		private float <Throttle>k__BackingField;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x657F00", Offset = "0x657F00")]
		private bool <AirBrakes>k__BackingField;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x657F10", Offset = "0x657F10")]
		private float <ForwardSpeed>k__BackingField;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x657F20", Offset = "0x657F20")]
		private float <EnginePower>k__BackingField;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x657F30", Offset = "0x657F30")]
		private float <RollAngle>k__BackingField;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x657F40", Offset = "0x657F40")]
		private float <PitchAngle>k__BackingField;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x657F50", Offset = "0x657F50")]
		private float <RollInput>k__BackingField;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x657F60", Offset = "0x657F60")]
		private float <PitchInput>k__BackingField;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x657F70", Offset = "0x657F70")]
		private float <YawInput>k__BackingField;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x657F80", Offset = "0x657F80")]
		private float <ThrottleInput>k__BackingField;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float m_OriginalDrag;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float m_OriginalAngularDrag;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float m_AeroFactor;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_Immobilized;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float m_BankedTurnAmount;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private WheelCollider[] m_WheelColliders;

		[Token(Token = "0x17000011")]
		public float Altitude
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xBD024C", Offset = "0xBD024C", VA = "0xBD024C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6617A8", Offset = "0x6617A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0xBD0E28", Offset = "0xBD0E28", VA = "0xBD0E28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6617B8", Offset = "0x6617B8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public float Throttle
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0xBD0E30", Offset = "0xBD0E30", VA = "0xBD0E30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6617C8", Offset = "0x6617C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xBD0E38", Offset = "0xBD0E38", VA = "0xBD0E38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6617D8", Offset = "0x6617D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public bool AirBrakes
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0xBD0E40", Offset = "0xBD0E40", VA = "0xBD0E40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6617E8", Offset = "0x6617E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0xBD0E48", Offset = "0xBD0E48", VA = "0xBD0E48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6617F8", Offset = "0x6617F8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public float ForwardSpeed
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0xBD025C", Offset = "0xBD025C", VA = "0xBD025C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661808", Offset = "0x661808")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xBD0E54", Offset = "0xBD0E54", VA = "0xBD0E54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661818", Offset = "0x661818")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public float EnginePower
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0xBD087C", Offset = "0xBD087C", VA = "0xBD087C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661828", Offset = "0x661828")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0xBD0E5C", Offset = "0xBD0E5C", VA = "0xBD0E5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661838", Offset = "0x661838")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public float MaxEnginePower
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0xBD0874", Offset = "0xBD0874", VA = "0xBD0874")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000017")]
		public float RollAngle
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0xBD0254", Offset = "0xBD0254", VA = "0xBD0254")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661848", Offset = "0x661848")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0xBD0E64", Offset = "0xBD0E64", VA = "0xBD0E64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661858", Offset = "0x661858")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public float PitchAngle
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0xBD0244", Offset = "0xBD0244", VA = "0xBD0244")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661868", Offset = "0x661868")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0xBD0E6C", Offset = "0xBD0E6C", VA = "0xBD0E6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661878", Offset = "0x661878")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public float RollInput
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0xBD0C6C", Offset = "0xBD0C6C", VA = "0xBD0C6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661888", Offset = "0x661888")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xBD0E74", Offset = "0xBD0E74", VA = "0xBD0E74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661898", Offset = "0x661898")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public float PitchInput
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0xBD0E00", Offset = "0xBD0E00", VA = "0xBD0E00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6618A8", Offset = "0x6618A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0xBD0E7C", Offset = "0xBD0E7C", VA = "0xBD0E7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6618B8", Offset = "0x6618B8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public float YawInput
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0xBD0E08", Offset = "0xBD0E08", VA = "0xBD0E08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6618C8", Offset = "0x6618C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0xBD0E84", Offset = "0xBD0E84", VA = "0xBD0E84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6618D8", Offset = "0x6618D8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public float ThrottleInput
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0xBD0E8C", Offset = "0xBD0E8C", VA = "0xBD0E8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6618E8", Offset = "0x6618E8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0xBD0E94", Offset = "0xBD0E94", VA = "0xBD0E94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6618F8", Offset = "0x6618F8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xBD0E9C", Offset = "0xBD0E9C", VA = "0xBD0E9C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xBD0264", Offset = "0xBD0264", VA = "0xBD0264")]
		public void Move(float rollInput, float pitchInput, float yawInput, float throttleInput, bool airBrakes)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xBD1038", Offset = "0xBD1038", VA = "0xBD1038")]
		private void ClampInputs()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xBD1120", Offset = "0xBD1120", VA = "0xBD1120")]
		private void CalculateRollAndPitchAngles()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xBD12C8", Offset = "0xBD12C8", VA = "0xBD12C8")]
		private void AutoLevel()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xBD13B4", Offset = "0xBD13B4", VA = "0xBD13B4")]
		private void CalculateForwardSpeed()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xBD14A0", Offset = "0xBD14A0", VA = "0xBD14A0")]
		private void ControlThrottle()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xBD1564", Offset = "0xBD1564", VA = "0xBD1564")]
		private void CalculateDrag()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xBD163C", Offset = "0xBD163C", VA = "0xBD163C")]
		private void CaluclateAerodynamicEffect()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xBD19B8", Offset = "0xBD19B8", VA = "0xBD19B8")]
		private void CalculateLinearForces()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xBD1C20", Offset = "0xBD1C20", VA = "0xBD1C20")]
		private void CalculateTorque()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xBD1ED8", Offset = "0xBD1ED8", VA = "0xBD1ED8")]
		private void CalculateAltitude()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xBD2088", Offset = "0xBD2088", VA = "0xBD2088")]
		public void Immobilize()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xBD2094", Offset = "0xBD2094", VA = "0xBD2094")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xBD209C", Offset = "0xBD209C", VA = "0xBD209C")]
		public AeroplaneController()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class AeroplaneControlSurfaceAnimator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014C")]
		public class ControlSurface
		{
			[Token(Token = "0x20001C4")]
			public enum Type
			{
				[Token(Token = "0x4000C34")]
				Aileron,
				[Token(Token = "0x4000C35")]
				Elevator,
				[Token(Token = "0x4000C36")]
				Rudder,
				[Token(Token = "0x4000C37")]
				RuddervatorNegative,
				[Token(Token = "0x4000C38")]
				RuddervatorPositive
			}

			[Token(Token = "0x400093C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400093D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float amount;

			[Token(Token = "0x400093E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Type type;

			[Token(Token = "0x400093F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[HideInInspector]
			public Quaternion originalLocalRotation;

			[Token(Token = "0x600093C")]
			[Address(RVA = "0xBD0E20", Offset = "0xBD0E20", VA = "0xBD0E20")]
			public ControlSurface()
			{
			}
		}

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Smoothing;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ControlSurface[] m_ControlSurfaces;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xBD0954", Offset = "0xBD0954", VA = "0xBD0954")]
		private void Start()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xBD0A30", Offset = "0xBD0A30", VA = "0xBD0A30")]
		private void Update()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xBD0C74", Offset = "0xBD0C74", VA = "0xBD0C74")]
		private void RotateSurface(ControlSurface surface, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xBD0E10", Offset = "0xBD0E10", VA = "0xBD0E10")]
		public AeroplaneControlSurfaceAnimator()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class AeroplanePropellerAnimator : MonoBehaviour
	{
		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_PropellorModel;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_PropellorBlur;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Texture2D[] m_PropellorBlurTextures;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x657FE0", Offset = "0x657FE0")]
		private float m_ThrottleBlurStart;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x658020", Offset = "0x658020")]
		private float m_ThrottleBlurEnd;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_MaxRpm;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_PropellorBlurState;

		[Token(Token = "0x400019C")]
		private const float k_RpmToDps = 60f;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Renderer m_PropellorModelRenderer;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Renderer m_PropellorBlurRenderer;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xBD20DC", Offset = "0xBD20DC", VA = "0xBD20DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xBD21A0", Offset = "0xBD21A0", VA = "0xBD21A0")]
		private void Update()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xBD241C", Offset = "0xBD241C", VA = "0xBD241C")]
		public AeroplanePropellerAnimator()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x654F84", Offset = "0x654F84")]
	public class AeroplaneUserControl2Axis : MonoBehaviour
	{
		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxRollAngle;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxPitchAngle;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AeroplaneController m_Aeroplane;

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xBD2440", Offset = "0xBD2440", VA = "0xBD2440")]
		private void Awake()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xBD2498", Offset = "0xBD2498", VA = "0xBD2498")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xBD25B0", Offset = "0xBD25B0", VA = "0xBD25B0")]
		private void AdjustInputForMobileControls(ref float roll, ref float pitch, ref float throttle)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xBD26FC", Offset = "0xBD26FC", VA = "0xBD26FC")]
		public AeroplaneUserControl2Axis()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x654FE8", Offset = "0x654FE8")]
	public class AeroplaneUserControl4Axis : MonoBehaviour
	{
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxRollAngle;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxPitchAngle;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AeroplaneController m_Aeroplane;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_Throttle;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool m_AirBrakes;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_Yaw;

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xBD2710", Offset = "0xBD2710", VA = "0xBD2710")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xBD2768", Offset = "0xBD2768", VA = "0xBD2768")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xBD289C", Offset = "0xBD289C", VA = "0xBD289C")]
		private void AdjustInputForMobileControls(ref float roll, ref float pitch, ref float throttle)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xBD29A0", Offset = "0xBD29A0", VA = "0xBD29A0")]
		public AeroplaneUserControl4Axis()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x65504C", Offset = "0x65504C")]
	public class JetParticleEffect : MonoBehaviour
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color minColour;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AeroplaneController m_Jet;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem m_System;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_OriginalStartSize;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_OriginalLifetime;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color m_OriginalStartColor;

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xBD29B4", Offset = "0xBD29B4", VA = "0xBD29B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xBD2C78", Offset = "0xBD2C78", VA = "0xBD2C78")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xBD2B30", Offset = "0xBD2B30", VA = "0xBD2B30")]
		private AeroplaneController FindAeroplaneParent()
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xBD2E5C", Offset = "0xBD2E5C", VA = "0xBD2E5C")]
		public JetParticleEffect()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class LandingGear : MonoBehaviour
	{
		[Token(Token = "0x200014D")]
		private enum GearState
		{
			[Token(Token = "0x4000941")]
			Raised = -1,
			[Token(Token = "0x4000942")]
			Lowered = 1
		}

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float raiseAtAltitude;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float lowerAtAltitude;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GearState m_State;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator m_Animator;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xBD2E64", Offset = "0xBD2E64", VA = "0xBD2E64")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xBD2EEC", Offset = "0xBD2EEC", VA = "0xBD2EEC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xBD300C", Offset = "0xBD300C", VA = "0xBD300C")]
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
		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovePower;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_UseTorque;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MaxAngularVelocity;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x40001B8")]
		private const float k_GroundRayLength = 1f;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xBD3028", Offset = "0xBD3028", VA = "0xBD3028")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xBD30B0", Offset = "0xBD30B0", VA = "0xBD30B0")]
		public void Move(Vector3 moveDirection, bool jump)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xBD3314", Offset = "0xBD3314", VA = "0xBD3314")]
		public Ball()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class BallUserControl : MonoBehaviour
	{
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Ball ball;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 move;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform cam;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 camForward;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool jump;

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xBD3338", Offset = "0xBD3338", VA = "0xBD3338")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xBD3434", Offset = "0xBD3434", VA = "0xBD3434")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xBD36E4", Offset = "0xBD36E4", VA = "0xBD36E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xBD3754", Offset = "0xBD3754", VA = "0xBD3754")]
		public BallUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6550B0", Offset = "0x6550B0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6550B0", Offset = "0x6550B0")]
	public class AICharacterControl : MonoBehaviour
	{
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6580B0", Offset = "0x6580B0")]
		private NavMeshAgent <agent>k__BackingField;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6580C0", Offset = "0x6580C0")]
		private ThirdPersonCharacter <character>k__BackingField;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x1700001D")]
		public NavMeshAgent agent
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xBC06A8", Offset = "0xBC06A8", VA = "0xBC06A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661908", Offset = "0x661908")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0xBC06B0", Offset = "0xBC06B0", VA = "0xBC06B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661918", Offset = "0x661918")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public ThirdPersonCharacter character
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xBC06B8", Offset = "0xBC06B8", VA = "0xBC06B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661928", Offset = "0x661928")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xBC06C0", Offset = "0xBC06C0", VA = "0xBC06C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661938", Offset = "0x661938")]
			private set
			{
			}
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xBC06C8", Offset = "0xBC06C8", VA = "0xBC06C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xBC0774", Offset = "0xBC0774", VA = "0xBC0774")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xBC0AE0", Offset = "0xBC0AE0", VA = "0xBC0AE0")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xBC0AE8", Offset = "0xBC0AE8", VA = "0xBC0AE8")]
		public AICharacterControl()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x65513C", Offset = "0x65513C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x65513C", Offset = "0x65513C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x65513C", Offset = "0x65513C")]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovingTurnSpeed;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_StationaryTurnSpeed;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x658100", Offset = "0x658100")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_RunCycleLegOffset;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MoveSpeedMultiplier;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_AnimSpeedMultiplier;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_GroundCheckDistance;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator m_Animator;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_IsGrounded;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_OrigGroundCheckDistance;

		[Token(Token = "0x40001CE")]
		private const float k_Half = 0.5f;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_TurnAmount;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_ForwardAmount;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 m_GroundNormal;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_CapsuleHeight;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 m_CapsuleCenter;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_Crouching;

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xBC0AF0", Offset = "0xBC0AF0", VA = "0xBC0AF0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xBC0914", Offset = "0xBC0914", VA = "0xBC0914")]
		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xBC111C", Offset = "0xBC111C", VA = "0xBC111C")]
		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xBC1470", Offset = "0xBC1470", VA = "0xBC1470")]
		private void PreventStandingInLowHeadroom()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xBC1658", Offset = "0xBC1658", VA = "0xBC1658")]
		private void UpdateAnimator(Vector3 move)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xBC0FDC", Offset = "0xBC0FDC", VA = "0xBC0FDC")]
		private void HandleAirborneMovement()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xBC0E68", Offset = "0xBC0E68", VA = "0xBC0E68")]
		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xBC0D94", Offset = "0xBC0D94", VA = "0xBC0D94")]
		private void ApplyExtraTurnRotation()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xBC193C", Offset = "0xBC193C", VA = "0xBC193C")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xBC0BE0", Offset = "0xBC0BE0", VA = "0xBC0BE0")]
		private void CheckGroundStatus()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xBC1A94", Offset = "0xBC1A94", VA = "0xBC1A94")]
		public ThirdPersonCharacter()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6551F0", Offset = "0x6551F0")]
	public class ThirdPersonUserControl : MonoBehaviour
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ThirdPersonCharacter m_Character;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_Cam;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 m_CamForward;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 m_Move;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_Jump;

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xBC1AB4", Offset = "0xBC1AB4", VA = "0xBC1AB4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xBC1BC4", Offset = "0xBC1BC4", VA = "0xBC1BC4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xBC1C44", Offset = "0xBC1C44", VA = "0xBC1C44")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xBC1F28", Offset = "0xBC1F28", VA = "0xBC1F28")]
		public ThirdPersonUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x655254", Offset = "0x655254")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x655254", Offset = "0x655254")]
	public class FirstPersonController : MonoBehaviour
	{
		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6581B0", Offset = "0x6581B0")]
		private float m_RunstepLenghten;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MouseLook m_MouseLook;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FOVKick m_FovKick;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioClip m_JumpSound;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AudioClip m_LandSound;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Camera m_Camera;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_Jump;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float m_YRotation;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2 m_Input;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float m_StepCycle;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float m_NextStep;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private bool m_Jumping;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xBBD06C", Offset = "0xBBD06C", VA = "0xBBD06C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xBBD364", Offset = "0xBBD364", VA = "0xBBD364")]
		private void Update()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xBBD60C", Offset = "0xBBD60C", VA = "0xBBD60C")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xBBD680", Offset = "0xBBD680", VA = "0xBBD680")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xBBDC60", Offset = "0xBBDC60", VA = "0xBBDC60")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xBBDCC0", Offset = "0xBBDCC0", VA = "0xBBDCC0")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xBBE074", Offset = "0xBBE074", VA = "0xBBE074")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xBBDDD8", Offset = "0xBBDDD8", VA = "0xBBDDD8")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xBBDAAC", Offset = "0xBBDAAC", VA = "0xBBDAAC")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xBBD4A4", Offset = "0xBBD4A4", VA = "0xBBD4A4")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xBBE80C", Offset = "0xBBE80C", VA = "0xBBE80C")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xBBE9E0", Offset = "0xBBE9E0", VA = "0xBBE9E0")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class HeadBob : MonoBehaviour
	{
		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera Camera;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurveControlledBob motionBob;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LerpControlledBob jumpAndLandingBob;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float StrideInterval;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6582C0", Offset = "0x6582C0")]
		public float RunningStrideLengthen;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xBBED78", Offset = "0xBBED78", VA = "0xBBED78")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xBBEE04", Offset = "0xBBEE04", VA = "0xBBEE04")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xBBF110", Offset = "0xBBF110", VA = "0xBBF110")]
		public HeadBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class MouseLook
	{
		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xBBD2F8", Offset = "0xBBD2F8", VA = "0xBBD2F8")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xBBE4A0", Offset = "0xBBE4A0", VA = "0xBBE4A0")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xBBF25C", Offset = "0xBBF25C", VA = "0xBBF25C")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xBBE064", Offset = "0xBBE064", VA = "0xBBE064")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xBBF290", Offset = "0xBBF290", VA = "0xBBF290")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xBBF194", Offset = "0xBBF194", VA = "0xBBF194")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xBBF310", Offset = "0xBBF310", VA = "0xBBF310")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6552E0", Offset = "0x6552E0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6552E0", Offset = "0x6552E0")]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014E")]
		public class MovementSettings
		{
			[Token(Token = "0x4000943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float ForwardSpeed;

			[Token(Token = "0x4000944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float BackwardSpeed;

			[Token(Token = "0x4000945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float StrafeSpeed;

			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float RunMultiplier;

			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public KeyCode RunKey;

			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float JumpForce;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnimationCurve SlopeCurveModifier;

			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public float CurrentTargetSpeed;

			[Token(Token = "0x600093D")]
			[Address(RVA = "0xBC02F4", Offset = "0xBC02F4", VA = "0xBC02F4")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0xBC04A8", Offset = "0xBC04A8", VA = "0xBC04A8")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200014F")]
		public class AdvancedSettings
		{
			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool airControl;

			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D950", Offset = "0x65D950")]
			public float shellOffset;

			[Token(Token = "0x600093F")]
			[Address(RVA = "0xBC0688", Offset = "0xBC0688", VA = "0xBC0688")]
			public AdvancedSettings()
			{
			}
		}

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera cam;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovementSettings movementSettings;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MouseLook mouseLook;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AdvancedSettings advancedSettings;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_YRotation;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_GroundContactNormal;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_Jump;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool m_Jumping;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		private bool m_IsGrounded;

		[Token(Token = "0x1700001F")]
		public Vector3 Velocity
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xBBF0D0", Offset = "0xBBF0D0", VA = "0xBBF0D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000020")]
		public bool Grounded
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0xBBF100", Offset = "0xBBF100", VA = "0xBBF100")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000021")]
		public bool Jumping
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xBBF344", Offset = "0xBBF344", VA = "0xBBF344")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		public bool Running
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xBBF108", Offset = "0xBBF108", VA = "0xBBF108")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xBBF34C", Offset = "0xBBF34C", VA = "0xBBF34C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xBBF410", Offset = "0xBBF410", VA = "0xBBF410")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xBBF700", Offset = "0xBBF700", VA = "0xBBF700")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xBBFF3C", Offset = "0xBBFF3C", VA = "0xBBFF3C")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xBC000C", Offset = "0xBC000C", VA = "0xBC000C")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xBBFE84", Offset = "0xBBFE84", VA = "0xBBFE84")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xBBF49C", Offset = "0xBBF49C", VA = "0xBBF49C")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xBBFC68", Offset = "0xBBFC68", VA = "0xBBFC68")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xBC03C0", Offset = "0xBC03C0", VA = "0xBC03C0")]
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
		[Token(Token = "0x2000150")]
		public enum UpdateType
		{
			[Token(Token = "0x4000951")]
			FixedUpdate,
			[Token(Token = "0x4000952")]
			LateUpdate,
			[Token(Token = "0x4000953")]
			ManualUpdate
		}

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform m_Target;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_AutoTargetPlayer;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UpdateType m_UpdateType;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x17000023")]
		public Transform Target
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xBBAB34", Offset = "0xBBAB34", VA = "0xBBAB34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xBBA6FC", Offset = "0xBBA6FC", VA = "0xBBA6FC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xBBA86C", Offset = "0xBBA86C", VA = "0xBBA86C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xBBA954", Offset = "0xBBA954", VA = "0xBBA954")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xBBAA40", Offset = "0xBBAA40", VA = "0xBBAA40")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x60001EF")]
		protected abstract void FollowTarget(float deltaTime);

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xBBA7AC", Offset = "0xBBA7AC", VA = "0xBBA7AC")]
		public void FindAndTargetPlayer()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xBBAB2C", Offset = "0xBBAB2C", VA = "0xBBAB2C", Slot = "6")]
		public virtual void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xBBAB3C", Offset = "0xBBAB3C", VA = "0xBBAB3C")]
		protected AbstractTargetFollower()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[ExecuteInEditMode]
	public class AutoCam : PivotBasedCameraRig
	{
		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_RollSpeed;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_FollowVelocity;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool m_FollowTilt;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_SpinTurnLimit;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_TargetVelocityLowerLimit;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SmoothTurnTime;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_LastFlatAngle;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_CurrentTurnAmount;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_TurnSpeedVelocityChange;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 m_RollUp;

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xBBAB4C", Offset = "0xBBAB4C", VA = "0xBBAB4C", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xBBB164", Offset = "0xBBB164", VA = "0xBBB164")]
		public AutoCam()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class FreeLookCam : PivotBasedCameraRig
	{
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x658398", Offset = "0x658398")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_TurnSmoothing;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_TiltMax;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_TiltMin;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_LockCursor;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool m_VerticalAutoReturn;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_LookAngle;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_TiltAngle;

		[Token(Token = "0x4000231")]
		private const float k_LookDistance = 100f;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 m_PivotEulers;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion m_PivotTargetRot;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion m_TransformTargetRot;

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xBBB220", Offset = "0xBBB220", VA = "0xBBB220", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xBBB398", Offset = "0xBBB398", VA = "0xBBB398")]
		protected void Update()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xBBB820", Offset = "0xBBB820", VA = "0xBBB820")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xBBB844", Offset = "0xBBB844", VA = "0xBBB844", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xBBB3F8", Offset = "0xBBB3F8", VA = "0xBBB3F8")]
		private void HandleRotationMovement()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xBBBA4C", Offset = "0xBBBA4C", VA = "0xBBBA4C")]
		public FreeLookCam()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class HandHeldCam : LookatTarget
	{
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SwaySpeed;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_BaseSwayAmount;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_TrackingSwayAmount;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x658458", Offset = "0x658458")]
		[SerializeField]
		private float m_TrackingBias;

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xBBBA74", Offset = "0xBBBA74", VA = "0xBBBA74", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xBBBFBC", Offset = "0xBBBFBC", VA = "0xBBBFBC")]
		public HandHeldCam()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class LookatTarget : AbstractTargetFollower
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 m_RotationRange;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_FollowSpeed;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Vector3 m_FollowVelocity;

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xBBBFF8", Offset = "0xBBBFF8", VA = "0xBBBFF8", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xBBBBE8", Offset = "0xBBBBE8", VA = "0xBBBBE8", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xBBBFE0", Offset = "0xBBBFE0", VA = "0xBBBFE0")]
		public LookatTarget()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform m_Cam;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Transform m_Pivot;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Vector3 m_LastTargetPosition;

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xBBB30C", Offset = "0xBBB30C", VA = "0xBBB30C", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xBBB210", Offset = "0xBBB210", VA = "0xBBB210")]
		protected PivotBasedCameraRig()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		[Token(Token = "0x2000151")]
		public class RayHitComparer : IComparer
		{
			[Token(Token = "0x6000940")]
			[Address(RVA = "0xBBC9FC", Offset = "0xBBC9FC", VA = "0xBBC9FC", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x6000941")]
			[Address(RVA = "0xBBC14C", Offset = "0xBBC14C", VA = "0xBBC14C")]
			public RayHitComparer()
			{
			}
		}

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float clipMoveTime;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float returnTime;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sphereCastRadius;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool visualiseInEditor;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float closestDistance;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6584B8", Offset = "0x6584B8")]
		private bool <protecting>k__BackingField;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string dontClipTag;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Cam;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_Pivot;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_OriginalDist;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_MoveVelocity;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_CurrentDist;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Ray m_Ray;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RayHitComparer m_RayHitComparer;

		[Token(Token = "0x17000024")]
		public bool protecting
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0xBBC044", Offset = "0xBBC044", VA = "0xBBC044")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661948", Offset = "0x661948")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000204")]
			[Address(RVA = "0xBBC04C", Offset = "0xBBC04C", VA = "0xBBC04C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661958", Offset = "0x661958")]
			private set
			{
			}
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xBBC058", Offset = "0xBBC058", VA = "0xBBC058")]
		private void Start()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xBBC154", Offset = "0xBBC154", VA = "0xBBC154")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xBBC97C", Offset = "0xBBC97C", VA = "0xBBC97C")]
		public ProtectCameraFromWallClip()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class TargetFieldOfView : AbstractTargetFollower
	{
		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_FovAdjustTime;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_ZoomAmountMultiplier;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_IncludeEffectsInSize;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_BoundSize;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_FovAdjustVelocity;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_Cam;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform m_LastTarget;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xBBCBB0", Offset = "0xBBCBB0", VA = "0xBBCBB0", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xBBCE74", Offset = "0xBBCE74", VA = "0xBBCE74", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xBBD020", Offset = "0xBBD020", VA = "0xBBD020", Slot = "6")]
		public override void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xBBCC20", Offset = "0xBBCC20", VA = "0xBBCC20")]
		public static float MaxBoundsExtent(Transform obj, bool includeEffects)
		{
			return default(float);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xBBD050", Offset = "0xBBD050", VA = "0xBBD050")]
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
		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float damping;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float lookAheadFactor;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float lookAheadReturnSpeed;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float lookAheadMoveThreshold;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_OffsetZ;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 m_LastTargetPosition;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 m_CurrentVelocity;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_LookAheadPos;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1588838", Offset = "0x1588838", VA = "0x1588838")]
		private void Start()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1588974", Offset = "0x1588974", VA = "0x1588974")]
		private void Update()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1588CCC", Offset = "0x1588CCC", VA = "0x1588CCC")]
		public Camera2DFollow()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class CameraFollow : MonoBehaviour
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float xMargin;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMargin;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float xSmooth;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float ySmooth;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 maxXAndY;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 minXAndY;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Player;

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1588CE0", Offset = "0x1588CE0", VA = "0x1588CE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1588D50", Offset = "0x1588D50", VA = "0x1588D50")]
		private bool CheckXMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1588E14", Offset = "0x1588E14", VA = "0x1588E14")]
		private bool CheckYMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1588ED8", Offset = "0x1588ED8", VA = "0x1588ED8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1588EDC", Offset = "0x1588EDC", VA = "0x1588EDC")]
		private void TrackPlayer()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x158918C", Offset = "0x158918C", VA = "0x158918C")]
		public CameraFollow()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x65537C", Offset = "0x65537C")]
	public class Platformer2DUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlatformerCharacter2D m_Character;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_Jump;

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x15891A0", Offset = "0x15891A0", VA = "0x15891A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x15891F8", Offset = "0x15891F8", VA = "0x15891F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x158927C", Offset = "0x158927C", VA = "0x158927C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1589688", Offset = "0x1589688", VA = "0x1589688")]
		public Platformer2DUserControl()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class PlatformerCharacter2D : MonoBehaviour
	{
		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MaxSpeed;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_JumpForce;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x658518", Offset = "0x658518")]
		[SerializeField]
		private float m_CrouchSpeed;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_AirControl;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask m_WhatIsGround;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform m_GroundCheck;

		[Token(Token = "0x400026F")]
		private const float k_GroundedRadius = 0.2f;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_Grounded;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_CeilingCheck;

		[Token(Token = "0x4000272")]
		private const float k_CeilingRadius = 0.01f;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator m_Anim;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody2D m_Rigidbody2D;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_FacingRight;

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1589690", Offset = "0x1589690", VA = "0x1589690")]
		private void Awake()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1589768", Offset = "0x1589768", VA = "0x1589768")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1589348", Offset = "0x1589348", VA = "0x1589348")]
		public void Move(float move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x15899B8", Offset = "0x15899B8", VA = "0x15899B8")]
		private void Flip()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1589A48", Offset = "0x1589A48", VA = "0x1589A48")]
		public PlatformerCharacter2D()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class Restarter : MonoBehaviour
	{
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1589A70", Offset = "0x1589A70", VA = "0x1589A70")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1589B10", Offset = "0x1589B10", VA = "0x1589B10")]
		public Restarter()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000064")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000152")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000955")]
			Update,
			[Token(Token = "0x4000956")]
			FixedUpdate,
			[Token(Token = "0x4000957")]
			LateUpdate,
			[Token(Token = "0x4000958")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x658578", Offset = "0x658578")]
		public bool smoothFollow;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6585B0", Offset = "0x6585B0")]
		public float rotationSensitivity;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6585E8", Offset = "0x6585E8")]
		public float distance;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x658620", Offset = "0x658620")]
		public LayerMask blockingLayers;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x658658", Offset = "0x658658")]
		public float blockedOffset;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x658670", Offset = "0x658670")]
		private float <x>k__BackingField;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x658680", Offset = "0x658680")]
		private float <y>k__BackingField;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x658690", Offset = "0x658690")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000025")]
		public float x
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0xFBB3AC", Offset = "0xFBB3AC", VA = "0xFBB3AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661968", Offset = "0x661968")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000222")]
			[Address(RVA = "0xFBB3B4", Offset = "0xFBB3B4", VA = "0xFBB3B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661978", Offset = "0x661978")]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public float y
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0xFBB3BC", Offset = "0xFBB3BC", VA = "0xFBB3BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661988", Offset = "0x661988")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000224")]
			[Address(RVA = "0xFBB3C4", Offset = "0xFBB3C4", VA = "0xFBB3C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661998", Offset = "0x661998")]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public float distanceTarget
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0xFBB3CC", Offset = "0xFBB3CC", VA = "0xFBB3CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6619A8", Offset = "0x6619A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000226")]
			[Address(RVA = "0xFBB3D4", Offset = "0xFBB3D4", VA = "0xFBB3D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6619B8", Offset = "0x6619B8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		private float zoomAdd
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0xFBBED8", Offset = "0xFBBED8", VA = "0xFBBED8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xFBB3DC", Offset = "0xFBB3DC", VA = "0xFBB3DC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xFBB518", Offset = "0xFBB518", VA = "0xFBB518", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xFBB57C", Offset = "0xFBB57C", VA = "0xFBB57C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xFBB5E4", Offset = "0xFBB5E4", VA = "0xFBB5E4", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xFBB648", Offset = "0xFBB648", VA = "0xFBB648")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xFBB554", Offset = "0xFBB554", VA = "0xFBB554")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xFBB7D0", Offset = "0xFBB7D0", VA = "0xFBB7D0")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xFBBE28", Offset = "0xFBBE28", VA = "0xFBBE28")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xFBBF4C", Offset = "0xFBBF4C", VA = "0xFBBF4C")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xB1F8C8", Offset = "0xB1F8C8", VA = "0xB1F8C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xB1F908", Offset = "0xB1F908", VA = "0xB1F908")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xB1FAE4", Offset = "0xB1FAE4", VA = "0xB1FAE4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xB1FB94", Offset = "0xB1FB94", VA = "0xB1FB94")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public enum Axis
	{
		[Token(Token = "0x40002A1")]
		X,
		[Token(Token = "0x40002A2")]
		Y,
		[Token(Token = "0x40002A3")]
		Z
	}
	[Token(Token = "0x2000067")]
	public class AxisTools
	{
		[Token(Token = "0x6000235")]
		[Address(RVA = "0xFB2918", Offset = "0xFB2918", VA = "0xFB2918")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xFB29D8", Offset = "0xFB29D8", VA = "0xFB29D8")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xFB2A84", Offset = "0xFB2A84", VA = "0xFB2A84")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xFB2C6C", Offset = "0xFB2C6C", VA = "0xFB2C6C")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xFB2BA0", Offset = "0xFB2BA0", VA = "0xFB2BA0")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xFB2D88", Offset = "0xFB2D88", VA = "0xFB2D88")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xFB2FD0", Offset = "0xFB2FD0", VA = "0xFB2FD0")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000153")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000942")]
			[Address(RVA = "0xFB3298", Offset = "0xFB3298", VA = "0xFB3298")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000029")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0xFB3024", Offset = "0xFB3024", VA = "0xFB3024")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0xFB3314", Offset = "0xFB3314", VA = "0xFB3314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xFB2FD8", Offset = "0xFB2FD8", VA = "0xFB2FD8")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000069")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000154")]
		public enum BoneType
		{
			[Token(Token = "0x400095D")]
			Unassigned,
			[Token(Token = "0x400095E")]
			Spine,
			[Token(Token = "0x400095F")]
			Head,
			[Token(Token = "0x4000960")]
			Arm,
			[Token(Token = "0x4000961")]
			Leg,
			[Token(Token = "0x4000962")]
			Tail,
			[Token(Token = "0x4000963")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000155")]
		public enum BoneSide
		{
			[Token(Token = "0x4000965")]
			Center,
			[Token(Token = "0x4000966")]
			Left,
			[Token(Token = "0x4000967")]
			Right
		}

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xFB3588", Offset = "0xFB3588", VA = "0xFB3588")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xFB38CC", Offset = "0xFB38CC", VA = "0xFB38CC")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xFB3B60", Offset = "0xFB3B60", VA = "0xFB3B60")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xFB3BE4", Offset = "0xFB3BE4", VA = "0xFB3BE4")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xFB3C98", Offset = "0xFB3C98", VA = "0xFB3C98")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xFB377C", Offset = "0xFB377C", VA = "0xFB377C")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xFB3AC0", Offset = "0xFB3AC0", VA = "0xFB3AC0")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xFB44EC", Offset = "0xFB44EC", VA = "0xFB44EC")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xFB4304", Offset = "0xFB4304", VA = "0xFB4304")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xFB43F8", Offset = "0xFB43F8", VA = "0xFB43F8")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xFB3ECC", Offset = "0xFB3ECC", VA = "0xFB3ECC")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xFB3F80", Offset = "0xFB3F80", VA = "0xFB3F80")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xFB4034", Offset = "0xFB4034", VA = "0xFB4034")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xFB40E8", Offset = "0xFB40E8", VA = "0xFB40E8")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xFB419C", Offset = "0xFB419C", VA = "0xFB419C")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xFB4250", Offset = "0xFB4250", VA = "0xFB4250")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xFB4768", Offset = "0xFB4768", VA = "0xFB4768")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xFB3DD8", Offset = "0xFB3DD8", VA = "0xFB3DD8")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xFB46D0", Offset = "0xFB46D0", VA = "0xFB46D0")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xFB47D8", Offset = "0xFB47D8", VA = "0xFB47D8")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xFB48AC", Offset = "0xFB48AC", VA = "0xFB48AC")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xFB463C", Offset = "0xFB463C", VA = "0xFB463C")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xFB457C", Offset = "0xFB457C", VA = "0xFB457C")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class BipedReferences
	{
		[Token(Token = "0x2000156")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x170000D2")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000944")]
				[Address(RVA = "0xFBB3A4", Offset = "0xFBB3A4", VA = "0xFBB3A4")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000943")]
			[Address(RVA = "0x713BE4", Offset = "0x713BE4", VA = "0x713BE4")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700002B")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0xFB7390", Offset = "0xFB7390", VA = "0xFB7390", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002C")]
		public bool isEmpty
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0xFB7794", Offset = "0xFB7794", VA = "0xFB7794")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xFB77A4", Offset = "0xFB77A4", VA = "0xFB77A4", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xFB7BE8", Offset = "0xFB7BE8", VA = "0xFB7BE8", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xFB8030", Offset = "0xFB8030", VA = "0xFB8030")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xFB8878", Offset = "0xFB8878", VA = "0xFB8878")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xFB82B4", Offset = "0xFB82B4", VA = "0xFB82B4")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xFB935C", Offset = "0xFB935C", VA = "0xFB935C")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xFB9454", Offset = "0xFB9454", VA = "0xFB9454")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xFB9A84", Offset = "0xFB9A84", VA = "0xFB9A84")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xFB9854", Offset = "0xFB9854", VA = "0xFB9854")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xFB969C", Offset = "0xFB969C", VA = "0xFB969C")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xFB952C", Offset = "0xFB952C", VA = "0xFB952C")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xFB996C", Offset = "0xFB996C", VA = "0xFB996C")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xFB9B90", Offset = "0xFB9B90", VA = "0xFB9B90")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xFBAA34", Offset = "0xFBAA34", VA = "0xFBAA34")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xFBA320", Offset = "0xFBA320", VA = "0xFBA320")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xFBADEC", Offset = "0xFBADEC", VA = "0xFBADEC")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xFBA7E0", Offset = "0xFBA7E0", VA = "0xFBA7E0")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xFBADF4", Offset = "0xFBADF4", VA = "0xFBADF4")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xFBADFC", Offset = "0xFBADFC", VA = "0xFBADFC")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xFBB008", Offset = "0xFBB008", VA = "0xFBB008")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xFBB26C", Offset = "0xFBB26C", VA = "0xFBB26C")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xFB8244", Offset = "0xFB8244", VA = "0xFB8244")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xB1FBB0", Offset = "0xB1FBB0", VA = "0xB1FBB0")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xB1FBB8", Offset = "0xB1FBB8", VA = "0xB1FBB8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xB1FC78", Offset = "0xB1FC78", VA = "0xB1FC78")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class Hierarchy
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0xE3BB00", Offset = "0xE3BB00", VA = "0xE3BB00")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xE3BD34", Offset = "0xE3BD34", VA = "0xE3BD34")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xE3BBB0", Offset = "0xE3BBB0", VA = "0xE3BBB0")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xE3BE80", Offset = "0xE3BE80", VA = "0xE3BE80")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xE3BFA8", Offset = "0xE3BFA8", VA = "0xE3BFA8")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xE3C2F8", Offset = "0xE3C2F8", VA = "0xE3C2F8")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xE3C43C", Offset = "0xE3C43C", VA = "0xE3C43C")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xE3C5E8", Offset = "0xE3C5E8", VA = "0xE3C5E8")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xE3C9D0", Offset = "0xE3C9D0", VA = "0xE3C9D0")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xE3C79C", Offset = "0xE3C79C", VA = "0xE3C79C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xE3CB80", Offset = "0xE3CB80", VA = "0xE3CB80")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xE3CB88", Offset = "0xE3CB88", VA = "0xE3CB88")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xE3CBF8", Offset = "0xE3CBF8", VA = "0xE3CBF8")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40002D1")]
		None,
		[Token(Token = "0x40002D2")]
		InOutCubic,
		[Token(Token = "0x40002D3")]
		InOutQuintic,
		[Token(Token = "0x40002D4")]
		InOutSine,
		[Token(Token = "0x40002D5")]
		InQuintic,
		[Token(Token = "0x40002D6")]
		InQuartic,
		[Token(Token = "0x40002D7")]
		InCubic,
		[Token(Token = "0x40002D8")]
		InQuadratic,
		[Token(Token = "0x40002D9")]
		InElastic,
		[Token(Token = "0x40002DA")]
		InElasticSmall,
		[Token(Token = "0x40002DB")]
		InElasticBig,
		[Token(Token = "0x40002DC")]
		InSine,
		[Token(Token = "0x40002DD")]
		InBack,
		[Token(Token = "0x40002DE")]
		OutQuintic,
		[Token(Token = "0x40002DF")]
		OutQuartic,
		[Token(Token = "0x40002E0")]
		OutCubic,
		[Token(Token = "0x40002E1")]
		OutInCubic,
		[Token(Token = "0x40002E2")]
		OutInQuartic,
		[Token(Token = "0x40002E3")]
		OutElastic,
		[Token(Token = "0x40002E4")]
		OutElasticSmall,
		[Token(Token = "0x40002E5")]
		OutElasticBig,
		[Token(Token = "0x40002E6")]
		OutSine,
		[Token(Token = "0x40002E7")]
		OutBack,
		[Token(Token = "0x40002E8")]
		OutBackCubic,
		[Token(Token = "0x40002E9")]
		OutBackQuartic,
		[Token(Token = "0x40002EA")]
		BackInCubic,
		[Token(Token = "0x40002EB")]
		BackInQuartic
	}
	[Token(Token = "0x2000070")]
	public class Interp
	{
		[Token(Token = "0x600027F")]
		[Address(RVA = "0xE3CC68", Offset = "0xE3CC68", VA = "0xE3CC68")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xE3D6D8", Offset = "0xE3D6D8", VA = "0xE3D6D8")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xE3D7E0", Offset = "0xE3D7E0", VA = "0xE3D7E0")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xE3CFD8", Offset = "0xE3CFD8", VA = "0xE3CFD8")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xE3CFE4", Offset = "0xE3CFE4", VA = "0xE3CFE4")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xE3D00C", Offset = "0xE3D00C", VA = "0xE3D00C")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xE3D048", Offset = "0xE3D048", VA = "0xE3D048")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xE3D060", Offset = "0xE3D060", VA = "0xE3D060")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xE3D074", Offset = "0xE3D074", VA = "0xE3D074")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xE3D088", Offset = "0xE3D088", VA = "0xE3D088")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xE3D098", Offset = "0xE3D098", VA = "0xE3D098")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xE3D0E0", Offset = "0xE3D0E0", VA = "0xE3D0E0")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xE3D118", Offset = "0xE3D118", VA = "0xE3D118")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xE3D140", Offset = "0xE3D140", VA = "0xE3D140")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xE3D8DC", Offset = "0xE3D8DC", VA = "0xE3D8DC")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xE3D174", Offset = "0xE3D174", VA = "0xE3D174")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xE3D19C", Offset = "0xE3D19C", VA = "0xE3D19C")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xE3D1CC", Offset = "0xE3D1CC", VA = "0xE3D1CC")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xE3D200", Offset = "0xE3D200", VA = "0xE3D200")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xE3D244", Offset = "0xE3D244", VA = "0xE3D244")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xE3D2A8", Offset = "0xE3D2A8", VA = "0xE3D2A8")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xE3D30C", Offset = "0xE3D30C", VA = "0xE3D30C")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xE3D360", Offset = "0xE3D360", VA = "0xE3D360")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xE3D3B4", Offset = "0xE3D3B4", VA = "0xE3D3B4")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xE3D44C", Offset = "0xE3D44C", VA = "0xE3D44C")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xE3D4E0", Offset = "0xE3D4E0", VA = "0xE3D4E0")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xE3D910", Offset = "0xE3D910", VA = "0xE3D910")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xE3D584", Offset = "0xE3D584", VA = "0xE3D584")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xE3D668", Offset = "0xE3D668", VA = "0xE3D668")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xE3D698", Offset = "0xE3D698", VA = "0xE3D698")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xE3D9F8", Offset = "0xE3D9F8", VA = "0xE3D9F8")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xE3DA00", Offset = "0xE3DA00", VA = "0xE3DA00")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xE3DA70", Offset = "0xE3DA70", VA = "0xE3DA70")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000072")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xE3DAE0", Offset = "0xE3DAE0", VA = "0xE3DAE0")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xE3DB3C", Offset = "0xE3DB3C", VA = "0xE3DB3C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xE3DC14", Offset = "0xE3DC14", VA = "0xE3DC14")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xE3DB54", Offset = "0xE3DB54", VA = "0xE3DB54")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xE3DC2C", Offset = "0xE3DC2C", VA = "0xE3DC2C")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xE3DCDC", Offset = "0xE3DCDC", VA = "0xE3DCDC")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xE3DD08", Offset = "0xE3DD08", VA = "0xE3DD08")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xE3DD58", Offset = "0xE3DD58", VA = "0xE3DD58")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xE3DDC4", Offset = "0xE3DDC4", VA = "0xE3DDC4")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xE3DEC4", Offset = "0xE3DEC4", VA = "0xE3DEC4")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xE3DFA8", Offset = "0xE3DFA8", VA = "0xE3DFA8")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xE3E008", Offset = "0xE3E008", VA = "0xE3E008")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000073")]
	public static class QuaTools
	{
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xE3E038", Offset = "0xE3E038", VA = "0xE3E038")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xE3E184", Offset = "0xE3E184", VA = "0xE3E184")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xE3E2D0", Offset = "0xE3E2D0", VA = "0xE3E2D0")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xE3E3E4", Offset = "0xE3E3E4", VA = "0xE3E3E4")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xE278A0", Offset = "0xE278A0", VA = "0xE278A0")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xE3E4F8", Offset = "0xE3E4F8", VA = "0xE3E4F8")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xE2E038", Offset = "0xE2E038", VA = "0xE2E038")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xE3E5C8", Offset = "0xE3E5C8", VA = "0xE3E5C8")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xE3E84C", Offset = "0xE3E84C", VA = "0xE3E84C")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xE3EA60", Offset = "0xE3EA60", VA = "0xE3EA60")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xE38FD8", Offset = "0xE38FD8", VA = "0xE38FD8")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000074")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700002D")]
		public static T instance
		{
			[Token(Token = "0x60002B7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B8")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002B9")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6586B0", Offset = "0x6586B0")]
		public bool fixTransforms;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700002E")]
		private bool animatePhysics
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xE3ED18", Offset = "0xE3ED18", VA = "0xE3ED18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		private bool isAnimated
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0xE3F06C", Offset = "0xE3F06C", VA = "0xE3F06C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xE3EBE0", Offset = "0xE3EBE0", VA = "0xE3EBE0")]
		public void Disable()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xE3EC78", Offset = "0xE3EC78", VA = "0xE3EC78", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xE3EC7C", Offset = "0xE3EC7C", VA = "0xE3EC7C", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xE3EC80", Offset = "0xE3EC80", VA = "0xE3EC80", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xE3EC84", Offset = "0xE3EC84", VA = "0xE3EC84")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xE3ED14", Offset = "0xE3ED14", VA = "0xE3ED14")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xE3ECBC", Offset = "0xE3ECBC", VA = "0xE3ECBC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xE3F01C", Offset = "0xE3F01C", VA = "0xE3F01C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xE3EE1C", Offset = "0xE3EE1C", VA = "0xE3EE1C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xE3F128", Offset = "0xE3F128", VA = "0xE3F128")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xE3F184", Offset = "0xE3F184", VA = "0xE3F184")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xE3F1E4", Offset = "0xE3F1E4", VA = "0xE3F1E4")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xE2BF64", Offset = "0xE2BF64", VA = "0xE2BF64")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xE3F22C", Offset = "0xE3F22C", VA = "0xE3F22C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xE3F2EC", Offset = "0xE3F2EC", VA = "0xE3F2EC")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xE3F3AC", Offset = "0xE3F3AC", VA = "0xE3F3AC")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xE3F46C", Offset = "0xE3F46C", VA = "0xE3F46C")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public static class V3Tools
	{
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xE3F474", Offset = "0xE3F474", VA = "0xE3F474")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xE3F56C", Offset = "0xE3F56C", VA = "0xE3F56C")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xE3F664", Offset = "0xE3F664", VA = "0xE3F664")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xE3F75C", Offset = "0xE3F75C", VA = "0xE3F75C")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xE3F85C", Offset = "0xE3F85C", VA = "0xE3F85C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xE3FA98", Offset = "0xE3FA98", VA = "0xE3FA98")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xE3FCE8", Offset = "0xE3FCE8", VA = "0xE3FCE8")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xE3FEF8", Offset = "0xE3FEF8", VA = "0xE3FEF8")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000078")]
	public static class Warning
	{
		[Token(Token = "0x2000157")]
		public delegate void Logger(string message);

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xE400D4", Offset = "0xE400D4", VA = "0xE400D4")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xE23FE0", Offset = "0xE23FE0", VA = "0xE23FE0")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6553F0", Offset = "0x6553F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6553F0", Offset = "0x6553F0")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xF300AC", Offset = "0xF300AC", VA = "0xF300AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661A38", Offset = "0x661A38")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xF300F8", Offset = "0xF300F8", VA = "0xF300F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661A70", Offset = "0x661A70")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xF30144", Offset = "0xF30144", VA = "0xF30144")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661AA8", Offset = "0x661AA8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xF30190", Offset = "0xF30190", VA = "0xF30190")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661AE0", Offset = "0x661AE0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xF301DC", Offset = "0xF301DC", VA = "0xF301DC")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xF302AC", Offset = "0xF302AC", VA = "0xF302AC")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xF302DC", Offset = "0xF302DC", VA = "0xF302DC")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xF3031C", Offset = "0xF3031C", VA = "0xF3031C")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xF3035C", Offset = "0xF3035C", VA = "0xF3035C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xF303B4", Offset = "0xF303B4", VA = "0xF303B4")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xF30414", Offset = "0xF30414", VA = "0xF30414")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xF30448", Offset = "0xF30448", VA = "0xF30448")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xF30478", Offset = "0xF30478", VA = "0xF30478")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xF30510", Offset = "0xF30510", VA = "0xF30510")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xF30578", Offset = "0xF30578", VA = "0xF30578")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xF305E0", Offset = "0xF305E0", VA = "0xF305E0")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xF3020C", Offset = "0xF3020C", VA = "0xF3020C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xF30630", Offset = "0xF30630", VA = "0xF30630")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xF3063C", Offset = "0xF3063C", VA = "0xF3063C")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xF30648", Offset = "0xF30648", VA = "0xF30648")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xF30A94", Offset = "0xF30A94", VA = "0xF30A94", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xF30B8C", Offset = "0xF30B8C", VA = "0xF30B8C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xF310D0", Offset = "0xF310D0", VA = "0xF310D0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xF317A0", Offset = "0xF317A0", VA = "0xF317A0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xF317D4", Offset = "0xF317D4", VA = "0xF317D4")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000030")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0xF308DC", Offset = "0xF308DC", VA = "0xF308DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0xF319A0", Offset = "0xF319A0", VA = "0xF319A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xF30E14", Offset = "0xF30E14", VA = "0xF30E14")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xF31858", Offset = "0xF31858", VA = "0xF31858")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000032")]
		public bool isValid
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xF351EC", Offset = "0xF351EC", VA = "0xF351EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002F6")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xF3525C", Offset = "0xF3525C", VA = "0xF3525C")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007C")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xF35264", Offset = "0xF35264", VA = "0xF35264", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xF35398", Offset = "0xF35398", VA = "0xF35398")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xF353A0", Offset = "0xF353A0", VA = "0xF353A0")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007D")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000033")]
		private bool positionChanged
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xF355F8", Offset = "0xF355F8", VA = "0xF355F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xF353CC", Offset = "0xF353CC", VA = "0xF353CC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xF356BC", Offset = "0xF356BC", VA = "0xF356BC")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xF356C4", Offset = "0xF356C4", VA = "0xF356C4")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007E")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xF356F0", Offset = "0xF356F0", VA = "0xF356F0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xF35848", Offset = "0xF35848", VA = "0xF35848")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xF35850", Offset = "0xF35850", VA = "0xF35850")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000034")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0xF35ABC", Offset = "0xF35ABC", VA = "0xF35ABC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xF3587C", Offset = "0xF3587C", VA = "0xF3587C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xF35B94", Offset = "0xF35B94", VA = "0xF35B94")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xF35B9C", Offset = "0xF35B9C", VA = "0xF35B9C")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class Constraints
	{
		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6586E8", Offset = "0x6586E8")]
		public float positionWeight;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x658700", Offset = "0x658700")]
		public float rotationWeight;

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xF35BC8", Offset = "0xF35BC8", VA = "0xF35BC8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xF31058", Offset = "0xF31058", VA = "0xF31058")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xF3136C", Offset = "0xF3136C", VA = "0xF3136C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xF31C3C", Offset = "0xF31C3C", VA = "0xF31C3C")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000158")]
		public enum DOF
		{
			[Token(Token = "0x400096B")]
			One,
			[Token(Token = "0x400096C")]
			Three
		}

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658718", Offset = "0x658718")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x658718", Offset = "0x658718")]
		public float weight;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65876C", Offset = "0x65876C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65876C", Offset = "0x65876C")]
		public float rotationWeight;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6587C0", Offset = "0x6587C0")]
		public DOF rotationDOF;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6587F8", Offset = "0x6587F8")]
		public Transform bone1;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658830", Offset = "0x658830")]
		public Transform bone2;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658868", Offset = "0x658868")]
		public Transform bone3;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6588A0", Offset = "0x6588A0")]
		public Transform tip;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6588D8", Offset = "0x6588D8")]
		public Transform target;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x658910", Offset = "0x658910")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x17000035")]
		public bool initiated
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0xF40068", Offset = "0xF40068", VA = "0xF40068")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661B18", Offset = "0x661B18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030B")]
			[Address(RVA = "0xF40070", Offset = "0xF40070", VA = "0xF40070")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661B28", Offset = "0x661B28")]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0xF4007C", Offset = "0xF4007C", VA = "0xF4007C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600030D")]
			[Address(RVA = "0xF400AC", Offset = "0xF400AC", VA = "0xF400AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0xF400F8", Offset = "0xF400F8", VA = "0xF400F8")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600030F")]
			[Address(RVA = "0xF40128", Offset = "0xF40128", VA = "0xF40128")]
			set
			{
			}
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xF40178", Offset = "0xF40178", VA = "0xF40178")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xF40278", Offset = "0xF40278", VA = "0xF40278")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xF40784", Offset = "0xF40784", VA = "0xF40784")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xF408B4", Offset = "0xF408B4", VA = "0xF408B4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xF4099C", Offset = "0xF4099C", VA = "0xF4099C")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xF40E94", Offset = "0xF40E94", VA = "0xF40E94")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658920", Offset = "0x658920")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x658920", Offset = "0x658920")]
		public float weight;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x658974", Offset = "0x658974")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000038")]
		public bool initiated
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0xF40EA4", Offset = "0xF40EA4", VA = "0xF40EA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661B38", Offset = "0x661B38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000317")]
			[Address(RVA = "0xF40EAC", Offset = "0xF40EAC", VA = "0xF40EAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661B48", Offset = "0x661B48")]
			private set
			{
			}
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xF40EB8", Offset = "0xF40EB8", VA = "0xF40EB8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xF40F4C", Offset = "0xF40F4C", VA = "0xF40F4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661B58", Offset = "0x661B58")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xF41398", Offset = "0xF41398", VA = "0xF41398")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xF415AC", Offset = "0xF415AC", VA = "0xF415AC")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xF4124C", Offset = "0xF4124C", VA = "0xF4124C")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xF417A4", Offset = "0xF417A4", VA = "0xF417A4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xF418AC", Offset = "0xF418AC", VA = "0xF418AC")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xF41940", Offset = "0xF41940", VA = "0xF41940")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xF419CC", Offset = "0xF419CC", VA = "0xF419CC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xF41A4C", Offset = "0xF41A4C", VA = "0xF41A4C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xF41A50", Offset = "0xF41A50", VA = "0xF41A50", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xF41A64", Offset = "0xF41A64", VA = "0xF41A64")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000159")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658984", Offset = "0x658984")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x658984", Offset = "0x658984")]
		public float weight;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6589D8", Offset = "0x6589D8")]
		public Grounding solver;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x658A10", Offset = "0x658A10")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000039")]
		public bool initiated
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0xF42E1C", Offset = "0xF42E1C", VA = "0xF42E1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661B90", Offset = "0x661B90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000326")]
			[Address(RVA = "0xF42E24", Offset = "0xF42E24", VA = "0xF42E24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661BA0", Offset = "0x661BA0")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000324")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xF42E30", Offset = "0xF42E30", VA = "0xF42E30")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xF43180", Offset = "0xF43180", VA = "0xF43180")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xF42FB8", Offset = "0xF42FB8", VA = "0xF42FB8")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xF431B4", Offset = "0xF431B4", VA = "0xF431B4")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600032C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xF43434", Offset = "0xF43434", VA = "0xF43434")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x655450", Offset = "0x655450")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655450", Offset = "0x655450")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658A20", Offset = "0x658A20")]
		public BipedIK ik;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658A58", Offset = "0x658A58")]
		public float spineBend;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658A90", Offset = "0x658A90")]
		public float spineSpeed;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xF439A0", Offset = "0xF439A0", VA = "0xF439A0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661BB0", Offset = "0x661BB0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xF439EC", Offset = "0xF439EC", VA = "0xF439EC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661BE8", Offset = "0x661BE8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xF43A38", Offset = "0xF43A38", VA = "0xF43A38", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xF43B68", Offset = "0xF43B68", VA = "0xF43B68")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xF43C68", Offset = "0xF43C68", VA = "0xF43C68")]
		private void Update()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xF43D1C", Offset = "0xF43D1C", VA = "0xF43D1C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xF444B0", Offset = "0xF444B0", VA = "0xF444B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xF4453C", Offset = "0xF4453C", VA = "0xF4453C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xF44F34", Offset = "0xF44F34", VA = "0xF44F34")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xF45120", Offset = "0xF45120", VA = "0xF45120")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xF45390", Offset = "0xF45390", VA = "0xF45390")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xF455E4", Offset = "0xF455E4", VA = "0xF455E4")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6554B0", Offset = "0x6554B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6554B0", Offset = "0x6554B0")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200015A")]
		public class SpineEffector
		{
			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D988", Offset = "0x65D988")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D9C0", Offset = "0x65D9C0")]
			public float horizontalWeight;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D9F8", Offset = "0x65D9F8")]
			public float verticalWeight;

			[Token(Token = "0x600094D")]
			[Address(RVA = "0xF467CC", Offset = "0xF467CC", VA = "0xF467CC")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600094E")]
			[Address(RVA = "0xF467DC", Offset = "0xF467DC", VA = "0xF467DC")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658AC8", Offset = "0x658AC8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658B00", Offset = "0x658B00")]
		public float spineBend;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658B38", Offset = "0x658B38")]
		public float spineSpeed;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xF45664", Offset = "0xF45664", VA = "0xF45664")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661C20", Offset = "0x661C20")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xF456B0", Offset = "0xF456B0", VA = "0xF456B0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661C58", Offset = "0x661C58")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xF456FC", Offset = "0xF456FC", VA = "0xF456FC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661C90", Offset = "0x661C90")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xF45748", Offset = "0xF45748", VA = "0xF45748", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xF457D0", Offset = "0xF457D0", VA = "0xF457D0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xF45880", Offset = "0xF45880", VA = "0xF45880")]
		private void Update()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xF45C70", Offset = "0xF45C70", VA = "0xF45C70")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xF45C7C", Offset = "0xF45C7C", VA = "0xF45C7C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xF4593C", Offset = "0xF4593C", VA = "0xF4593C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xF45C88", Offset = "0xF45C88", VA = "0xF45C88")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xF462A0", Offset = "0xF462A0", VA = "0xF462A0")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xF464AC", Offset = "0xF464AC", VA = "0xF464AC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xF465E4", Offset = "0xF465E4", VA = "0xF465E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xF4674C", Offset = "0xF4674C", VA = "0xF4674C")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x655510", Offset = "0x655510")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655510", Offset = "0x655510")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658B70", Offset = "0x658B70")]
		public Transform pelvis;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658BA8", Offset = "0x658BA8")]
		public Transform characterRoot;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658BE0", Offset = "0x658BE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x658BE0", Offset = "0x658BE0")]
		public float rootRotationWeight;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658C34", Offset = "0x658C34")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658C6C", Offset = "0x658C6C")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xF46824", Offset = "0xF46824", VA = "0xF46824", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661CC8", Offset = "0x661CC8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xF46870", Offset = "0xF46870", VA = "0xF46870", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661D00", Offset = "0x661D00")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xF468BC", Offset = "0xF468BC", VA = "0xF468BC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xF468E8", Offset = "0xF468E8", VA = "0xF468E8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xF46AE8", Offset = "0xF46AE8", VA = "0xF46AE8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xF46C34", Offset = "0xF46C34", VA = "0xF46C34")]
		private void Update()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xF47480", Offset = "0xF47480", VA = "0xF47480")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xF47AC4", Offset = "0xF47AC4", VA = "0xF47AC4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xF47DA4", Offset = "0xF47DA4", VA = "0xF47DA4")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xF482EC", Offset = "0xF482EC", VA = "0xF482EC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xF48564", Offset = "0xF48564", VA = "0xF48564")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xF487FC", Offset = "0xF487FC", VA = "0xF487FC")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x655570", Offset = "0x655570")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655570", Offset = "0x655570")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x200015B")]
		public struct Foot
		{
			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x600094F")]
			[Address(RVA = "0x712E10", Offset = "0x712E10", VA = "0x712E10")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658CA4", Offset = "0x658CA4")]
		public Grounding forelegSolver;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658CDC", Offset = "0x658CDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x658CDC", Offset = "0x658CDC")]
		public float rootRotationWeight;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658D30", Offset = "0x658D30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x658D30", Offset = "0x658D30")]
		public float minRootRotation;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658D88", Offset = "0x658D88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x658D88", Offset = "0x658D88")]
		public float maxRootRotation;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658DE0", Offset = "0x658DE0")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658E18", Offset = "0x658E18")]
		public float maxLegOffset;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658E50", Offset = "0x658E50")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658E88", Offset = "0x658E88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x658E88", Offset = "0x658E88")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658EDC", Offset = "0x658EDC")]
		public Transform characterRoot;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658F14", Offset = "0x658F14")]
		public Transform pelvis;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658F4C", Offset = "0x658F4C")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658F84", Offset = "0x658F84")]
		public Transform head;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xF4887C", Offset = "0xF4887C", VA = "0xF4887C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661D38", Offset = "0x661D38")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xF488C8", Offset = "0xF488C8", VA = "0xF488C8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661D70", Offset = "0x661D70")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xF48914", Offset = "0xF48914", VA = "0xF48914", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xF4895C", Offset = "0xF4895C", VA = "0xF4895C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xF48A98", Offset = "0xF48A98", VA = "0xF48A98")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xF48C50", Offset = "0xF48C50", VA = "0xF48C50")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xF48D30", Offset = "0xF48D30", VA = "0xF48D30")]
		private void Update()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xF48DE8", Offset = "0xF48DE8", VA = "0xF48DE8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xF491F4", Offset = "0xF491F4", VA = "0xF491F4")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xF496FC", Offset = "0xF496FC", VA = "0xF496FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xF49848", Offset = "0xF49848", VA = "0xF49848")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xF49DAC", Offset = "0xF49DAC", VA = "0xF49DAC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xF4A7CC", Offset = "0xF4A7CC", VA = "0xF4A7CC")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xF4AB30", Offset = "0xF4AB30", VA = "0xF4AB30")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xF4ACC4", Offset = "0xF4ACC4", VA = "0xF4ACC4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xF4B0BC", Offset = "0xF4B0BC", VA = "0xF4B0BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xF4B100", Offset = "0xF4B100", VA = "0xF4B100")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xF4B390", Offset = "0xF4B390", VA = "0xF4B390")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6555D0", Offset = "0x6555D0")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x658FCC", Offset = "0x658FCC")]
		public VRIK ik;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xF4B4AC", Offset = "0xF4B4AC", VA = "0xF4B4AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661DA8", Offset = "0x661DA8")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xF4B4B0", Offset = "0xF4B4B0", VA = "0xF4B4B0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661DE0", Offset = "0x661DE0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xF4B4B4", Offset = "0xF4B4B4", VA = "0xF4B4B4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661E18", Offset = "0x661E18")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xF4B4B8", Offset = "0xF4B4B8", VA = "0xF4B4B8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xF4B4E4", Offset = "0xF4B4E4", VA = "0xF4B4E4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xF4B594", Offset = "0xF4B594", VA = "0xF4B594")]
		private void Update()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xF4B648", Offset = "0xF4B648", VA = "0xF4B648")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xF4B994", Offset = "0xF4B994", VA = "0xF4B994")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xF4BD64", Offset = "0xF4BD64", VA = "0xF4BD64")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xF4BEA0", Offset = "0xF4BEA0", VA = "0xF4BEA0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xF4C1D0", Offset = "0xF4C1D0", VA = "0xF4C1D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xF4C308", Offset = "0xF4C308", VA = "0xF4C308")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xF4C53C", Offset = "0xF4C53C", VA = "0xF4C53C")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000089")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x200015C")]
		public enum Quality
		{
			[Token(Token = "0x4000975")]
			Fastest,
			[Token(Token = "0x4000976")]
			Simple,
			[Token(Token = "0x4000977")]
			Best
		}

		[Token(Token = "0x200015D")]
		public class Leg
		{
			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65DA30", Offset = "0x65DA30")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65DA40", Offset = "0x65DA40")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65DA50", Offset = "0x65DA50")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65DA60", Offset = "0x65DA60")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65DA70", Offset = "0x65DA70")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65DA80", Offset = "0x65DA80")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65DA90", Offset = "0x65DA90")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x4000982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x4000983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x4000984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x170000D3")]
			public bool isGrounded
			{
				[Token(Token = "0x6000950")]
				[Address(RVA = "0xF4D6D4", Offset = "0xF4D6D4", VA = "0xF4D6D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x663FD4", Offset = "0x663FD4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000951")]
				[Address(RVA = "0xF4DFAC", Offset = "0xF4DFAC", VA = "0xF4DFAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x663FE4", Offset = "0x663FE4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D4")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000952")]
				[Address(RVA = "0xF43420", Offset = "0xF43420", VA = "0xF43420")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x663FF4", Offset = "0x663FF4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000953")]
				[Address(RVA = "0xF4DFB8", Offset = "0xF4DFB8", VA = "0xF4DFB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664004", Offset = "0x664004")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D5")]
			public bool initiated
			{
				[Token(Token = "0x6000954")]
				[Address(RVA = "0xF4DFC4", Offset = "0xF4DFC4", VA = "0xF4DFC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664014", Offset = "0x664014")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000955")]
				[Address(RVA = "0xF4DFCC", Offset = "0xF4DFCC", VA = "0xF4DFCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664024", Offset = "0x664024")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D6")]
			public float heightFromGround
			{
				[Token(Token = "0x6000956")]
				[Address(RVA = "0xF4DFD8", Offset = "0xF4DFD8", VA = "0xF4DFD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664034", Offset = "0x664034")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000957")]
				[Address(RVA = "0xF4DFE0", Offset = "0xF4DFE0", VA = "0xF4DFE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664044", Offset = "0x664044")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D7")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000958")]
				[Address(RVA = "0xF4DFE8", Offset = "0xF4DFE8", VA = "0xF4DFE8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664054", Offset = "0x664054")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000959")]
				[Address(RVA = "0xF4DFF4", Offset = "0xF4DFF4", VA = "0xF4DFF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664064", Offset = "0x664064")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D8")]
			public Transform transform
			{
				[Token(Token = "0x600095A")]
				[Address(RVA = "0xF4342C", Offset = "0xF4342C", VA = "0xF4342C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664074", Offset = "0x664074")]
				get
				{
					return null;
				}
				[Token(Token = "0x600095B")]
				[Address(RVA = "0xF4E000", Offset = "0xF4E000", VA = "0xF4E000")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664084", Offset = "0x664084")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D9")]
			public float IKOffset
			{
				[Token(Token = "0x600095C")]
				[Address(RVA = "0xF4D6CC", Offset = "0xF4D6CC", VA = "0xF4D6CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664094", Offset = "0x664094")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600095D")]
				[Address(RVA = "0xF4E008", Offset = "0xF4E008", VA = "0xF4E008")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6640A4", Offset = "0x6640A4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DA")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000962")]
				[Address(RVA = "0xF4EC8C", Offset = "0xF4EC8C", VA = "0xF4EC8C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000DB")]
			private float rootYOffset
			{
				[Token(Token = "0x600096B")]
				[Address(RVA = "0xF4F010", Offset = "0xF4F010", VA = "0xF4F010")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600095E")]
			[Address(RVA = "0xF4CBD0", Offset = "0xF4CBD0", VA = "0xF4CBD0")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x600095F")]
			[Address(RVA = "0xF4E010", Offset = "0xF4E010", VA = "0xF4E010")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000960")]
			[Address(RVA = "0xF4DA8C", Offset = "0xF4DA8C", VA = "0xF4DA8C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000961")]
			[Address(RVA = "0xF4CCE0", Offset = "0xF4CCE0", VA = "0xF4CCE0")]
			public void Process()
			{
			}

			[Token(Token = "0x6000963")]
			[Address(RVA = "0xF4E790", Offset = "0xF4E790", VA = "0xF4E790")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000964")]
			[Address(RVA = "0xF4E064", Offset = "0xF4E064", VA = "0xF4E064")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000965")]
			[Address(RVA = "0xF4EE50", Offset = "0xF4EE50", VA = "0xF4EE50")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000966")]
			[Address(RVA = "0xF4E414", Offset = "0xF4E414", VA = "0xF4E414")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000967")]
			[Address(RVA = "0xF4E51C", Offset = "0xF4E51C", VA = "0xF4E51C")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000968")]
			[Address(RVA = "0xF4EF60", Offset = "0xF4EF60", VA = "0xF4EF60")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0xF4ED3C", Offset = "0xF4ED3C", VA = "0xF4ED3C")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x600096A")]
			[Address(RVA = "0xF4F17C", Offset = "0xF4F17C", VA = "0xF4F17C")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600096C")]
			[Address(RVA = "0xF4CB20", Offset = "0xF4CB20", VA = "0xF4CB20")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200015E")]
		public class Pelvis
		{
			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65DAA0", Offset = "0x65DAA0")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65DAB0", Offset = "0x65DAB0")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x400098E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000DC")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x600096D")]
				[Address(RVA = "0xF44F28", Offset = "0xF44F28", VA = "0xF44F28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6640B4", Offset = "0x6640B4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600096E")]
				[Address(RVA = "0xF4F2F4", Offset = "0xF4F2F4", VA = "0xF4F2F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6640C4", Offset = "0x6640C4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DD")]
			public float heightOffset
			{
				[Token(Token = "0x600096F")]
				[Address(RVA = "0xF4AB28", Offset = "0xF4AB28", VA = "0xF4AB28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6640D4", Offset = "0x6640D4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000970")]
				[Address(RVA = "0xF4F300", Offset = "0xF4F300", VA = "0xF4F300")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6640E4", Offset = "0x6640E4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000971")]
			[Address(RVA = "0xF4CCB8", Offset = "0xF4CCB8", VA = "0xF4CCB8")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000972")]
			[Address(RVA = "0xF4D9C0", Offset = "0xF4D9C0", VA = "0xF4D9C0")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000973")]
			[Address(RVA = "0xF4F308", Offset = "0xF4F308", VA = "0xF4F308")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000974")]
			[Address(RVA = "0xF4D6DC", Offset = "0xF4D6DC", VA = "0xF4D6DC")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000975")]
			[Address(RVA = "0xF4CBC8", Offset = "0xF4CBC8", VA = "0xF4CBC8")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659004", Offset = "0x659004")]
		public LayerMask layers;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65903C", Offset = "0x65903C")]
		public float maxStep;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659074", Offset = "0x659074")]
		public float heightOffset;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6590AC", Offset = "0x6590AC")]
		public float footSpeed;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6590E4", Offset = "0x6590E4")]
		public float footRadius;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65911C", Offset = "0x65911C")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659168", Offset = "0x659168")]
		public float prediction;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6591A0", Offset = "0x6591A0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6591A0", Offset = "0x6591A0")]
		public float footRotationWeight;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6591F4", Offset = "0x6591F4")]
		public float footRotationSpeed;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65922C", Offset = "0x65922C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65922C", Offset = "0x65922C")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659284", Offset = "0x659284")]
		public bool rotateSolver;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6592BC", Offset = "0x6592BC")]
		public float pelvisSpeed;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6592F4", Offset = "0x6592F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6592F4", Offset = "0x6592F4")]
		public float pelvisDamper;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659348", Offset = "0x659348")]
		public float lowerPelvisWeight;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659380", Offset = "0x659380")]
		public float liftPelvisWeight;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6593B8", Offset = "0x6593B8")]
		public float rootSphereCastRadius;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6593F0", Offset = "0x6593F0")]
		public bool overstepFallsDown;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659428", Offset = "0x659428")]
		public Quality quality;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x659460", Offset = "0x659460")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x659470", Offset = "0x659470")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x659480", Offset = "0x659480")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x659490", Offset = "0x659490")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6594A0", Offset = "0x6594A0")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700003A")]
		public Leg[] legs
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0xF42FB0", Offset = "0xF42FB0", VA = "0xF42FB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661E50", Offset = "0x661E50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000374")]
			[Address(RVA = "0xF4C598", Offset = "0xF4C598", VA = "0xF4C598")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661E60", Offset = "0x661E60")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0xF44F20", Offset = "0xF44F20", VA = "0xF44F20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661E70", Offset = "0x661E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000376")]
			[Address(RVA = "0xF4C5A0", Offset = "0xF4C5A0", VA = "0xF4C5A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661E80", Offset = "0x661E80")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public bool isGrounded
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0xF4C5A8", Offset = "0xF4C5A8", VA = "0xF4C5A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661E90", Offset = "0x661E90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000378")]
			[Address(RVA = "0xF4C5B0", Offset = "0xF4C5B0", VA = "0xF4C5B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661EA0", Offset = "0x661EA0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public Transform root
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0xF43418", Offset = "0xF43418", VA = "0xF43418")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661EB0", Offset = "0x661EB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600037A")]
			[Address(RVA = "0xF4C5BC", Offset = "0xF4C5BC", VA = "0xF4C5BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661EC0", Offset = "0x661EC0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0xF49D90", Offset = "0xF49D90", VA = "0xF49D90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661ED0", Offset = "0x661ED0")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600037C")]
			[Address(RVA = "0xF4C5C4", Offset = "0xF4C5C4", VA = "0xF4C5C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x661EE0", Offset = "0x661EE0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public bool rootGrounded
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0xF4C5E4", Offset = "0xF4C5E4", VA = "0xF4C5E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		public Vector3 up
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0xF4508C", Offset = "0xF4508C", VA = "0xF4508C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000041")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0xF4DB54", Offset = "0xF4DB54", VA = "0xF4DB54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xF4C63C", Offset = "0xF4C63C", VA = "0xF4C63C")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xF4CA44", Offset = "0xF4CA44", VA = "0xF4CA44")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xF441AC", Offset = "0xF441AC", VA = "0xF441AC")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xF44C80", Offset = "0xF44C80", VA = "0xF44C80")]
		public void Update()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xF4720C", Offset = "0xF4720C", VA = "0xF4720C")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xF43AC0", Offset = "0xF43AC0", VA = "0xF43AC0")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xF4CCC8", Offset = "0xF4CCC8", VA = "0xF4CCC8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xF4DC2C", Offset = "0xF4DC2C", VA = "0xF4DC2C")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xF4DD9C", Offset = "0xF4DD9C", VA = "0xF4DD9C")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xF4DEA8", Offset = "0xF4DEA8", VA = "0xF4DEA8")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xF434F8", Offset = "0xF434F8", VA = "0xF434F8")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x655608", Offset = "0x655608")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655608", Offset = "0x655608")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xB3C95C", Offset = "0xB3C95C", VA = "0xB3C95C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661EF0", Offset = "0x661EF0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xB3C9A8", Offset = "0xB3C9A8", VA = "0xB3C9A8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661F28", Offset = "0x661F28")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xB3C9F4", Offset = "0xB3C9F4", VA = "0xB3C9F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661F60", Offset = "0x661F60")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xB3CA40", Offset = "0xB3CA40", VA = "0xB3CA40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661F98", Offset = "0x661F98")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xB3CA8C", Offset = "0xB3CA8C", VA = "0xB3CA8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x661FD0", Offset = "0x661FD0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xB3CAD8", Offset = "0xB3CAD8", VA = "0xB3CAD8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xB3CAE0", Offset = "0xB3CAE0", VA = "0xB3CAE0")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655668", Offset = "0x655668")]
	public class ArmIK : IK
	{
		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xF2FECC", Offset = "0xF2FECC", VA = "0xF2FECC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662008", Offset = "0x662008")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xF2FF38", Offset = "0xF2FF38", VA = "0xF2FF38", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662040", Offset = "0x662040")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xF2FFA4", Offset = "0xF2FFA4", VA = "0xF2FFA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662078", Offset = "0x662078")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xF2FFF0", Offset = "0xF2FFF0", VA = "0xF2FFF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6620B0", Offset = "0x6620B0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xF3003C", Offset = "0xF3003C", VA = "0xF3003C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xF30044", Offset = "0xF30044", VA = "0xF30044")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6556A0", Offset = "0x6556A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6556A0", Offset = "0x6556A0")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xF31F18", Offset = "0xF31F18", VA = "0xF31F18", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6620E8", Offset = "0x6620E8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xF31F64", Offset = "0xF31F64", VA = "0xF31F64", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662120", Offset = "0x662120")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xF31FB0", Offset = "0xF31FB0", VA = "0xF31FB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662158", Offset = "0x662158")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xF31FFC", Offset = "0xF31FFC", VA = "0xF31FFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662190", Offset = "0x662190")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xF32048", Offset = "0xF32048", VA = "0xF32048", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xF32050", Offset = "0xF32050", VA = "0xF32050")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x655700", Offset = "0x655700")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655700", Offset = "0x655700")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xF35C38", Offset = "0xF35C38", VA = "0xF35C38", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6621C8", Offset = "0x6621C8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xF35C84", Offset = "0xF35C84", VA = "0xF35C84", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662200", Offset = "0x662200")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xF35CD0", Offset = "0xF35CD0", VA = "0xF35CD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662238", Offset = "0x662238")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xF35D1C", Offset = "0xF35D1C", VA = "0xF35D1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662270", Offset = "0x662270")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xF35D68", Offset = "0xF35D68", VA = "0xF35D68", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xF35D70", Offset = "0xF35D70", VA = "0xF35D70")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x655760", Offset = "0x655760")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655760", Offset = "0x655760")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xF366D4", Offset = "0xF366D4", VA = "0xF366D4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6622A8", Offset = "0x6622A8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xF36720", Offset = "0xF36720", VA = "0xF36720", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6622E0", Offset = "0x6622E0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xF3676C", Offset = "0xF3676C", VA = "0xF3676C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662318", Offset = "0x662318")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xF367B8", Offset = "0xF367B8", VA = "0xF367B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662350", Offset = "0x662350")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xF36804", Offset = "0xF36804", VA = "0xF36804", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xF3680C", Offset = "0xF3680C", VA = "0xF3680C")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6557C0", Offset = "0x6557C0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6557C0", Offset = "0x6557C0")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xF41ACC", Offset = "0xF41ACC", VA = "0xF41ACC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662388", Offset = "0x662388")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xF41B18", Offset = "0xF41B18", VA = "0xF41B18", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6623C0", Offset = "0x6623C0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xF41B64", Offset = "0xF41B64", VA = "0xF41B64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6623F8", Offset = "0x6623F8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xF41BB0", Offset = "0xF41BB0", VA = "0xF41BB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662430", Offset = "0x662430")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xF41BFC", Offset = "0xF41BFC", VA = "0xF41BFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662468", Offset = "0x662468")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xF41C48", Offset = "0xF41C48", VA = "0xF41C48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6624A0", Offset = "0x6624A0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xF41C94", Offset = "0xF41C94", VA = "0xF41C94")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xF41CE0", Offset = "0xF41CE0", VA = "0xF41CE0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xF41CE8", Offset = "0xF41CE8", VA = "0xF41CE8")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xF41F0C", Offset = "0xF41F0C", VA = "0xF41F0C")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xF422FC", Offset = "0xF422FC", VA = "0xF422FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6624D8", Offset = "0x6624D8")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xF4233C", Offset = "0xF4233C", VA = "0xF4233C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662510", Offset = "0x662510")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xF42450", Offset = "0xF42450", VA = "0xF42450")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x60003B7")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x118AE60", Offset = "0x118AE60", VA = "0x118AE60", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x118AF6C", Offset = "0x118AF6C", VA = "0x118AF6C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x118B138", Offset = "0x118B138", VA = "0x118B138", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60003BB")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60003BC")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x118B1A8", Offset = "0x118B1A8", VA = "0x118B1A8")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6594B0", Offset = "0x6594B0")]
		public IK[] IKComponents;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6594E8", Offset = "0x6594E8")]
		public Animator animator;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000042")]
		private bool animatePhysics
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x118EA3C", Offset = "0x118EA3C", VA = "0x118EA3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x118EAE0", Offset = "0x118EAE0", VA = "0x118EAE0")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x118EB80", Offset = "0x118EB80", VA = "0x118EB80")]
		private void Update()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x118ECB8", Offset = "0x118ECB8", VA = "0x118ECB8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x118ECF4", Offset = "0x118ECF4", VA = "0x118ECF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x118EBB4", Offset = "0x118EBB4", VA = "0x118EBB4")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x118EDBC", Offset = "0x118EDBC", VA = "0x118EDBC")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655820", Offset = "0x655820")]
	public class LegIK : IK
	{
		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xE28B58", Offset = "0xE28B58", VA = "0xE28B58", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662548", Offset = "0x662548")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xE28BC4", Offset = "0xE28BC4", VA = "0xE28BC4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662580", Offset = "0x662580")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xE28C30", Offset = "0xE28C30", VA = "0xE28C30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6625B8", Offset = "0x6625B8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xE28C7C", Offset = "0xE28C7C", VA = "0xE28C7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6625F0", Offset = "0x6625F0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xE28CC8", Offset = "0xE28CC8", VA = "0xE28CC8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xE28CD0", Offset = "0xE28CD0", VA = "0xE28CD0")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x655858", Offset = "0x655858")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655858", Offset = "0x655858")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xE28D38", Offset = "0xE28D38", VA = "0xE28D38", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662628", Offset = "0x662628")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xE28D84", Offset = "0xE28D84", VA = "0xE28D84", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662660", Offset = "0x662660")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xE28DD0", Offset = "0xE28DD0", VA = "0xE28DD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662698", Offset = "0x662698")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xE28E1C", Offset = "0xE28E1C", VA = "0xE28E1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6626D0", Offset = "0x6626D0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xE28E68", Offset = "0xE28E68", VA = "0xE28E68", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xE28E70", Offset = "0xE28E70", VA = "0xE28E70")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6558B8", Offset = "0x6558B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6558B8", Offset = "0x6558B8")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xE29F8C", Offset = "0xE29F8C", VA = "0xE29F8C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662708", Offset = "0x662708")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xE29FD8", Offset = "0xE29FD8", VA = "0xE29FD8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662740", Offset = "0x662740")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xE2A024", Offset = "0xE2A024", VA = "0xE2A024")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662778", Offset = "0x662778")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xE2A070", Offset = "0xE2A070", VA = "0xE2A070")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6627B0", Offset = "0x6627B0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xE2A0BC", Offset = "0xE2A0BC", VA = "0xE2A0BC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xE2A0C4", Offset = "0xE2A0C4", VA = "0xE2A0C4")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x655918", Offset = "0x655918")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655918", Offset = "0x655918")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xE34ADC", Offset = "0xE34ADC", VA = "0xE34ADC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6627E8", Offset = "0x6627E8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xE34B28", Offset = "0xE34B28", VA = "0xE34B28", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662820", Offset = "0x662820")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xE34B74", Offset = "0xE34B74", VA = "0xE34B74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662858", Offset = "0x662858")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xE34BC0", Offset = "0xE34BC0", VA = "0xE34BC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662890", Offset = "0x662890")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xE34C0C", Offset = "0xE34C0C", VA = "0xE34C0C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xE34C14", Offset = "0xE34C14", VA = "0xE34C14")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655978", Offset = "0x655978")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x200015F")]
		public class References
		{
			[Token(Token = "0x4000990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DAC0", Offset = "0x65DAC0")]
			public Transform chest;

			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DAF8", Offset = "0x65DAF8")]
			public Transform neck;

			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DB30", Offset = "0x65DB30")]
			public Transform leftShoulder;

			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DB68", Offset = "0x65DB68")]
			public Transform rightShoulder;

			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x400099C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x400099D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x400099E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DBA0", Offset = "0x65DBA0")]
			public Transform leftThigh;

			[Token(Token = "0x400099F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DBD8", Offset = "0x65DBD8")]
			public Transform leftCalf;

			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DC10", Offset = "0x65DC10")]
			public Transform leftFoot;

			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DC48", Offset = "0x65DC48")]
			public Transform leftToes;

			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DC80", Offset = "0x65DC80")]
			public Transform rightThigh;

			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DCB8", Offset = "0x65DCB8")]
			public Transform rightCalf;

			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DCF0", Offset = "0x65DCF0")]
			public Transform rightFoot;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DD28", Offset = "0x65DD28")]
			public Transform rightToes;

			[Token(Token = "0x170000DE")]
			public bool isFilled
			{
				[Token(Token = "0x6000977")]
				[Address(RVA = "0xE36564", Offset = "0xE36564", VA = "0xE36564")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000DF")]
			public bool isEmpty
			{
				[Token(Token = "0x6000978")]
				[Address(RVA = "0xE360E8", Offset = "0xE360E8", VA = "0xE360E8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000976")]
			[Address(RVA = "0xE36C08", Offset = "0xE36C08", VA = "0xE36C08")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0xE35A90", Offset = "0xE35A90", VA = "0xE35A90")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0xE36C00", Offset = "0xE36C00", VA = "0xE36C00")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x659520", Offset = "0x659520")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659520", Offset = "0x659520")]
		public References references;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65959C", Offset = "0x65959C")]
		public IKSolverVR solver;

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xE35944", Offset = "0xE35944", VA = "0xE35944", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6628C8", Offset = "0x6628C8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xE359B0", Offset = "0xE359B0", VA = "0xE359B0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662900", Offset = "0x662900")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xE35A1C", Offset = "0xE35A1C", VA = "0xE35A1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662938", Offset = "0x662938")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xE35A68", Offset = "0xE35A68", VA = "0xE35A68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662970", Offset = "0x662970")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xE3600C", Offset = "0xE3600C", VA = "0xE3600C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6629A8", Offset = "0x6629A8")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xE36044", Offset = "0xE36044", VA = "0xE36044", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xE3604C", Offset = "0xE3604C", VA = "0xE3604C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xE369E8", Offset = "0xE369E8", VA = "0xE369E8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xE36B78", Offset = "0xE36B78", VA = "0xE36B78")]
		public VRIK()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6559B0", Offset = "0x6559B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6559B0", Offset = "0x6559B0")]
	public class AimIKJ : MonoBehaviour
	{
		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6595D4", Offset = "0x6595D4")]
		public Transform target;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65960C", Offset = "0x65960C")]
		public Transform poleTarget;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659644", Offset = "0x659644")]
		public Transform aimTransform;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x65967C", Offset = "0x65967C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65967C", Offset = "0x65967C")]
		public float axisX;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6596CC", Offset = "0x6596CC")]
		public float axisY;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659704", Offset = "0x659704")]
		public float axisZ;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x65973C", Offset = "0x65973C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65973C", Offset = "0x65973C")]
		public float poleAxisX;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65978C", Offset = "0x65978C")]
		public float poleAxisY;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6597C4", Offset = "0x6597C4")]
		public float poleAxisZ;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6597FC", Offset = "0x6597FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6597FC", Offset = "0x6597FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6597FC", Offset = "0x6597FC")]
		public float weight;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659864", Offset = "0x659864")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x659864", Offset = "0x659864")]
		public float poleWeight;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6598B8", Offset = "0x6598B8")]
		public float tolerance;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6598F0", Offset = "0x6598F0")]
		public int maxIterations;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659928", Offset = "0x659928")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x659928", Offset = "0x659928")]
		public float clampWeight;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65997C", Offset = "0x65997C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65997C", Offset = "0x65997C")]
		public int clampSmoothing;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6599D0", Offset = "0x6599D0")]
		public bool useRotationLimits;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659A08", Offset = "0x659A08")]
		public bool XY;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x659A40", Offset = "0x659A40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659A40", Offset = "0x659A40")]
		public Transform[] bones;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x659A90", Offset = "0x659A90")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PlayableGraph graph;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AnimationScriptPlayable IKPlayable;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AimIKJob job;

		[Token(Token = "0x17000043")]
		public bool initiated
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0xB3CB48", Offset = "0xB3CB48", VA = "0xB3CB48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6629E0", Offset = "0x6629E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xB3CB50", Offset = "0xB3CB50", VA = "0xB3CB50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6629F0", Offset = "0x6629F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public Vector3 axis
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0xB3CB5C", Offset = "0xB3CB5C", VA = "0xB3CB5C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xB3CB98", Offset = "0xB3CB98", VA = "0xB3CB98")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public Vector3 poleAxis
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xB3CBA4", Offset = "0xB3CBA4", VA = "0xB3CBA4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0xB3CBE0", Offset = "0xB3CBE0", VA = "0xB3CBE0")]
			set
			{
			}
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xB3CBEC", Offset = "0xB3CBEC", VA = "0xB3CBEC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xB3DDA4", Offset = "0xB3DDA4", VA = "0xB3DDA4")]
		private void Update()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xB3E190", Offset = "0xB3E190", VA = "0xB3E190")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xB3E290", Offset = "0xB3E290", VA = "0xB3E290")]
		public AimIKJ()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public struct AimIKJob : IAnimationJob
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public TransformSceneHandle _poleTarget;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TransformStreamHandle _transform;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PropertySceneHandle _IKPositionWeight;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public PropertySceneHandle _poleWeight;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public PropertySceneHandle _axisX;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public PropertySceneHandle _axisY;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public PropertySceneHandle _axisZ;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public PropertySceneHandle _poleAxisX;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public PropertySceneHandle _poleAxisY;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public PropertySceneHandle _poleAxisZ;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public PropertySceneHandle _clampWeight;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public PropertySceneHandle _clampSmoothing;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public PropertySceneHandle _maxIterations;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public PropertySceneHandle _tolerance;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public PropertySceneHandle _XY;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public PropertySceneHandle _useRotationLimits;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NativeArray<TransformStreamHandle> bones;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private NativeArray<PropertySceneHandle> boneWeights;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 lastLocalDirection;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float step;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private NativeArray<Vector3> limitAxisArray;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NativeArray<int> hingeFlags;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private NativeArray<Quaternion> hingeLastRotations;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private NativeArray<float> hingeLastAngles;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private NativeArray<int> angleFlags;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x704A94", Offset = "0x704A94", VA = "0x704A94")]
		public void Setup(Animator animator, Transform[] bones, Transform target, Transform poleTarget, Transform aimTransform)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x704A9C", Offset = "0x704A9C", VA = "0x704A9C")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x704AA4", Offset = "0x704AA4", VA = "0x704AA4")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x704AAC", Offset = "0x704AAC", VA = "0x704AAC", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x704AB0", Offset = "0x704AB0", VA = "0x704AB0", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x704AF4", Offset = "0x704AF4", VA = "0x704AF4")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x704B38", Offset = "0x704B38", VA = "0x704B38")]
		private void RotateToTarget(AnimationStream s, Vector3 targetPosition, Vector3 polePosition, int i, float weight, float poleWeight, bool XY, bool useRotationLimits, Vector3 axis, Vector3 poleAxis)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x704BA4", Offset = "0x704BA4", VA = "0x704BA4")]
		public float GetAngle(AnimationStream s, Vector3 axis, Vector3 IKPosition)
		{
			return default(float);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x704BE8", Offset = "0x704BE8", VA = "0x704BE8")]
		private Vector3 GetClampedIKPosition(AnimationStream s, float clampWeight, int clampSmoothing, Vector3 IKPosition, Vector3 transformPosition, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x704BFC", Offset = "0x704BFC", VA = "0x704BFC")]
		private Vector3 GetLocalDirection(AnimationStream s, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x704C40", Offset = "0x704C40", VA = "0x704C40")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x704C48", Offset = "0x704C48", VA = "0x704C48")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x655A38", Offset = "0x655A38")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655A38", Offset = "0x655A38")]
	public class CCDIKJ : MonoBehaviour
	{
		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659AA0", Offset = "0x659AA0")]
		public Transform target;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659AD8", Offset = "0x659AD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x659AD8", Offset = "0x659AD8")]
		public float weight;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659B2C", Offset = "0x659B2C")]
		public float tolerance;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659B64", Offset = "0x659B64")]
		public int maxIterations;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659B9C", Offset = "0x659B9C")]
		public bool useRotationLimits;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659BD4", Offset = "0x659BD4")]
		public bool XY;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659C0C", Offset = "0x659C0C")]
		public Transform[] bones;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x659C44", Offset = "0x659C44")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator animator;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PlayableGraph graph;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AnimationScriptPlayable IKPlayable;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CCDIKJob job;

		[Token(Token = "0x17000046")]
		public bool initiated
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xF320B8", Offset = "0xF320B8", VA = "0xF320B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662A00", Offset = "0x662A00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0xF320C0", Offset = "0xF320C0", VA = "0xF320C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662A10", Offset = "0x662A10")]
			private set
			{
			}
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xF320CC", Offset = "0xF320CC", VA = "0xF320CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xF32A9C", Offset = "0xF32A9C", VA = "0xF32A9C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xF32C38", Offset = "0xF32C38", VA = "0xF32C38")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xF32D4C", Offset = "0xF32D4C", VA = "0xF32D4C")]
		public CCDIKJ()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public struct CCDIKJob : IAnimationJob
	{
		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PropertySceneHandle _IKPositionWeight;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PropertySceneHandle _maxIterations;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PropertySceneHandle _tolerance;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PropertySceneHandle _XY;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PropertySceneHandle _useRotationLimits;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NativeArray<TransformStreamHandle> bones;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private NativeArray<PropertySceneHandle> boneWeights;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NativeArray<float> boneSqrMags;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float chainSqrMag;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 lastLocalDirection;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private NativeArray<Vector3> limitAxisArray;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NativeArray<int> hingeFlags;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private NativeArray<Quaternion> hingeLastRotations;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NativeArray<float> hingeLastAngles;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private NativeArray<int> angleFlags;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x712BA0", Offset = "0x712BA0", VA = "0x712BA0")]
		public void Setup(Animator animator, Transform[] bones, Transform target)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x712BA8", Offset = "0x712BA8", VA = "0x712BA8")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x712BB0", Offset = "0x712BB0", VA = "0x712BB0")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x712BB8", Offset = "0x712BB8", VA = "0x712BB8", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x712BBC", Offset = "0x712BBC", VA = "0x712BBC", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x712C00", Offset = "0x712C00", VA = "0x712C00")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x712C44", Offset = "0x712C44", VA = "0x712C44")]
		private void Read(AnimationStream s)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x712C88", Offset = "0x712C88", VA = "0x712C88")]
		private void Solve(AnimationStream s, Vector3 targetPosition, bool XY, float weight, int it, bool useRotationLimits)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x712CD4", Offset = "0x712CD4", VA = "0x712CD4")]
		private Vector3 GetLocalDirection(AnimationStream s)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x712D18", Offset = "0x712D18", VA = "0x712D18")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x712D20", Offset = "0x712D20", VA = "0x712D20")]
		private Vector3 GetSingularityOffset(AnimationStream s, Vector3 IKPosition, bool useRotationLimits)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x712D68", Offset = "0x712D68", VA = "0x712D68")]
		private bool SingularityDetected(AnimationStream s, Vector3 IKPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x712DB0", Offset = "0x712DB0", VA = "0x712DB0")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class IKJBoneParams : MonoBehaviour
	{
		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x659C54", Offset = "0x659C54")]
		public float weight;

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x118EDC4", Offset = "0x118EDC4", VA = "0x118EDC4")]
		public IKJBoneParams()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public static class RotationLimitUtilities
	{
		[Token(Token = "0x6000410")]
		[Address(RVA = "0xE337F4", Offset = "0xE337F4", VA = "0xE337F4")]
		public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, ref Quaternion lastRotation, ref float lastAngle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xE33B14", Offset = "0xE33B14", VA = "0xE33B14")]
		public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xE33BF8", Offset = "0xE33BF8", VA = "0xE33BF8")]
		public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xE33C60", Offset = "0xE33C60", VA = "0xE33C60")]
		public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xE33E94", Offset = "0xE33E94", VA = "0xE33E94")]
		public static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200009D")]
	public class FABRIKChain
	{
		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x659C6C", Offset = "0x659C6C")]
		public float pull;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x659C84", Offset = "0x659C84")]
		public float pin;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xF35DD8", Offset = "0xF35DD8", VA = "0xF35DD8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xF35EB0", Offset = "0xF35EB0", VA = "0xF35EB0")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xF35EE4", Offset = "0xF35EE4", VA = "0xF35EE4")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xF36464", Offset = "0xF36464", VA = "0xF36464")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xF3606C", Offset = "0xF3606C", VA = "0xF3606C")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xF3666C", Offset = "0xF3666C", VA = "0xF3666C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xF36874", Offset = "0xF36874", VA = "0xF36874")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xF36FE4", Offset = "0xF36FE4", VA = "0xF36FE4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xF372B8", Offset = "0xF372B8", VA = "0xF372B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xF37418", Offset = "0xF37418", VA = "0xF37418")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000160")]
		public class BendBone
		{
			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DD60", Offset = "0x65DD60")]
			public Transform transform;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DD98", Offset = "0x65DD98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65DD98", Offset = "0x65DD98")]
			public float weight;

			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600097B")]
			[Address(RVA = "0xF3B7FC", Offset = "0xF3B7FC", VA = "0xF3B7FC")]
			public BendBone()
			{
			}

			[Token(Token = "0x600097C")]
			[Address(RVA = "0xF3B87C", Offset = "0xF3B87C", VA = "0xF3B87C")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x600097D")]
			[Address(RVA = "0xF380A0", Offset = "0xF380A0", VA = "0xF380A0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600097E")]
			[Address(RVA = "0xF386EC", Offset = "0xF386EC", VA = "0xF386EC")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659C9C", Offset = "0x659C9C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x659CD4", Offset = "0x659CD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659CD4", Offset = "0x659CD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x659CD4", Offset = "0x659CD4")]
		public float positionWeight;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659D4C", Offset = "0x659D4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x659D4C", Offset = "0x659D4C")]
		public float bodyWeight;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659DA0", Offset = "0x659DA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x659DA0", Offset = "0x659DA0")]
		public float thighWeight;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659DF4", Offset = "0x659DF4")]
		public bool handsPullBody;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x659E2C", Offset = "0x659E2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659E2C", Offset = "0x659E2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x659E2C", Offset = "0x659E2C")]
		public float rotationWeight;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659EA4", Offset = "0x659EA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x659EA4", Offset = "0x659EA4")]
		public float bodyClampWeight;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659EF8", Offset = "0x659EF8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x659EF8", Offset = "0x659EF8")]
		public float headClampWeight;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659F4C", Offset = "0x659F4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x659F4C", Offset = "0x659F4C")]
		public float bendWeight;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659FA0", Offset = "0x659FA0")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x659FD8", Offset = "0x659FD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x659FD8", Offset = "0x659FD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x659FD8", Offset = "0x659FD8")]
		public float CCDWeight;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A050", Offset = "0x65A050")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A050", Offset = "0x65A050")]
		public float roll;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A0A4", Offset = "0x65A0A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A0A4", Offset = "0x65A0A4")]
		public float damper;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A0FC", Offset = "0x65A0FC")]
		public Transform[] CCDBones;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x65A134", Offset = "0x65A134")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A134", Offset = "0x65A134")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A134", Offset = "0x65A134")]
		public float postStretchWeight;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A1AC", Offset = "0x65A1AC")]
		public float maxStretch;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A1E4", Offset = "0x65A1E4")]
		public float stretchDamper;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A21C", Offset = "0x65A21C")]
		public bool fixHead;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A254", Offset = "0x65A254")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x65A28C", Offset = "0x65A28C")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A2C4", Offset = "0x65A2C4")]
		public float chestDirectionWeight;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xF37420", Offset = "0xF37420", VA = "0xF37420")]
		private void Start()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xF379A8", Offset = "0xF379A8", VA = "0xF379A8")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xF380E0", Offset = "0xF380E0", VA = "0xF380E0")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xF38744", Offset = "0xF38744", VA = "0xF38744")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xF393F8", Offset = "0xF393F8", VA = "0xF393F8")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xF39868", Offset = "0xF39868", VA = "0xF39868")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xF39D48", Offset = "0xF39D48", VA = "0xF39D48")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xF3AA90", Offset = "0xF3AA90", VA = "0xF3AA90")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xF3906C", Offset = "0xF3906C", VA = "0xF3906C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xF3AD78", Offset = "0xF3AD78", VA = "0xF3AD78")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xF3A910", Offset = "0xF3A910", VA = "0xF3A910")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xF3A774", Offset = "0xF3A774", VA = "0xF3A774")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xF3B1DC", Offset = "0xF3B1DC", VA = "0xF3B1DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xF3B67C", Offset = "0xF3B67C", VA = "0xF3B67C")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A0")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000161")]
		public class ChildConstraint
		{
			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40009AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40009AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65DE0C", Offset = "0x65DE0C")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65DE1C", Offset = "0x65DE1C")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x40009B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x170000E0")]
			public float nominalDistance
			{
				[Token(Token = "0x600097F")]
				[Address(RVA = "0xF3FFF8", Offset = "0xF3FFF8", VA = "0xF3FFF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6640F4", Offset = "0x6640F4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000980")]
				[Address(RVA = "0xF40000", Offset = "0xF40000", VA = "0xF40000")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664104", Offset = "0x664104")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E1")]
			public bool isRigid
			{
				[Token(Token = "0x6000981")]
				[Address(RVA = "0xF40008", Offset = "0xF40008", VA = "0xF40008")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664114", Offset = "0x664114")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000982")]
				[Address(RVA = "0xF40010", Offset = "0xF40010", VA = "0xF40010")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664124", Offset = "0x664124")]
				private set
				{
				}
			}

			[Token(Token = "0x6000983")]
			[Address(RVA = "0xF4001C", Offset = "0xF4001C", VA = "0xF4001C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000984")]
			[Address(RVA = "0xF3CA84", Offset = "0xF3CA84", VA = "0xF3CA84")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0xF3D408", Offset = "0xF3D408", VA = "0xF3D408")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000986")]
			[Address(RVA = "0xF3FBAC", Offset = "0xF3FBAC", VA = "0xF3FBAC")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000162")]
		public enum Smoothing
		{
			[Token(Token = "0x40009B4")]
			None,
			[Token(Token = "0x40009B5")]
			Exponential,
			[Token(Token = "0x40009B6")]
			Cubic
		}

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A2DC", Offset = "0x65A2DC")]
		public float pin;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A2F4", Offset = "0x65A2F4")]
		public float pull;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A30C", Offset = "0x65A30C")]
		public float push;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A324", Offset = "0x65A324")]
		public float pushParent;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A33C", Offset = "0x65A33C")]
		public float reach;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x4000441")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xF3B920", Offset = "0xF3B920", VA = "0xF3B920")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xF3B9EC", Offset = "0xF3B9EC", VA = "0xF3B9EC")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xF3BAF8", Offset = "0xF3BAF8", VA = "0xF3BAF8")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xF3BC48", Offset = "0xF3BC48", VA = "0xF3BC48")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xF3BD48", Offset = "0xF3BD48", VA = "0xF3BD48")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xF3BE68", Offset = "0xF3BE68", VA = "0xF3BE68")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xF3CAFC", Offset = "0xF3CAFC", VA = "0xF3CAFC")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xF3C0FC", Offset = "0xF3C0FC", VA = "0xF3C0FC")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xF3D6E8", Offset = "0xF3D6E8", VA = "0xF3D6E8")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xF3DBC0", Offset = "0xF3DBC0", VA = "0xF3DBC0")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xF3E0F0", Offset = "0xF3E0F0", VA = "0xF3E0F0")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xF3E804", Offset = "0xF3E804", VA = "0xF3E804")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xF3F2F4", Offset = "0xF3F2F4", VA = "0xF3F2F4")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xF3F7A4", Offset = "0xF3F7A4", VA = "0xF3F7A4")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xF3F1EC", Offset = "0xF3F1EC", VA = "0xF3F1EC")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xF3E5EC", Offset = "0xF3E5EC", VA = "0xF3E5EC")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xF3F144", Offset = "0xF3F144", VA = "0xF3F144")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xF3F9C8", Offset = "0xF3F9C8", VA = "0xF3F9C8")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xF3EEFC", Offset = "0xF3EEFC", VA = "0xF3EEFC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xF3F518", Offset = "0xF3F518", VA = "0xF3F518")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A1")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A354", Offset = "0x65A354")]
		public float weight;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65A36C", Offset = "0x65A36C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000047")]
		public bool initiated
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x118B390", Offset = "0x118B390", VA = "0x118B390")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662A20", Offset = "0x662A20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x118B398", Offset = "0x118B398", VA = "0x118B398")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662A30", Offset = "0x662A30")]
			private set
			{
			}
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x118B1B0", Offset = "0x118B1B0", VA = "0x118B1B0")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x118B3A4", Offset = "0x118B3A4", VA = "0x118B3A4")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x118B428", Offset = "0x118B428", VA = "0x118B428")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x118B4D4", Offset = "0x118B4D4", VA = "0x118B4D4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x118B4E0", Offset = "0x118B4E0", VA = "0x118B4E0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x118BB48", Offset = "0x118BB48", VA = "0x118BB48")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x118BD80", Offset = "0x118BD80", VA = "0x118BD80")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x118C2F8", Offset = "0x118C2F8", VA = "0x118C2F8")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x118B8B8", Offset = "0x118B8B8", VA = "0x118B8B8")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x118BA00", Offset = "0x118BA00", VA = "0x118BA00")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000A2")]
	public class IKEffector
	{
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A37C", Offset = "0x65A37C")]
		public float positionWeight;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A394", Offset = "0x65A394")]
		public float rotationWeight;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65A3AC", Offset = "0x65A3AC")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A3BC", Offset = "0x65A3BC")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000048")]
		public bool isEndEffector
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x118CAAC", Offset = "0x118CAAC", VA = "0x118CAAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662A40", Offset = "0x662A40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x118CAB4", Offset = "0x118CAB4", VA = "0x118CAB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662A50", Offset = "0x662A50")]
			private set
			{
			}
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x118C9FC", Offset = "0x118C9FC", VA = "0x118C9FC")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x118CAC0", Offset = "0x118CAC0", VA = "0x118CAC0")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x118CBA8", Offset = "0x118CBA8", VA = "0x118CBA8")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x118CCE4", Offset = "0x118CCE4", VA = "0x118CCE4")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x118CE3C", Offset = "0x118CE3C", VA = "0x118CE3C")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x118D194", Offset = "0x118D194", VA = "0x118D194")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x118D530", Offset = "0x118D530", VA = "0x118D530")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x118D704", Offset = "0x118D704", VA = "0x118D704")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x118D7C4", Offset = "0x118D7C4", VA = "0x118D7C4")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x118DFB4", Offset = "0x118DFB4", VA = "0x118DFB4")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x118E024", Offset = "0x118E024", VA = "0x118E024")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x118E284", Offset = "0x118E284", VA = "0x118E284")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x118E6E0", Offset = "0x118E6E0", VA = "0x118E6E0")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000A3")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000163")]
		public class BoneMap
		{
			[Token(Token = "0x40009B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40009B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40009B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40009BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40009BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40009BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40009BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40009BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40009BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40009C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40009C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40009C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40009C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40009C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40009C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40009C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40009C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000E2")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x6000988")]
				[Address(RVA = "0x118F078", Offset = "0x118F078", VA = "0x118F078")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E3")]
			public bool isNodeBone
			{
				[Token(Token = "0x600098B")]
				[Address(RVA = "0x118F240", Offset = "0x118F240", VA = "0x118F240")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E4")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x600099F")]
				[Address(RVA = "0x118F8E4", Offset = "0x118F8E4", VA = "0x118F8E4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000987")]
			[Address(RVA = "0x118F028", Offset = "0x118F028", VA = "0x118F028")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000989")]
			[Address(RVA = "0x118F14C", Offset = "0x118F14C", VA = "0x118F14C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600098A")]
			[Address(RVA = "0x118F1B0", Offset = "0x118F1B0", VA = "0x118F1B0")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x600098C")]
			[Address(RVA = "0x118F250", Offset = "0x118F250", VA = "0x118F250")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x600098D")]
			[Address(RVA = "0x118F354", Offset = "0x118F354", VA = "0x118F354")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x600098E")]
			[Address(RVA = "0x118F35C", Offset = "0x118F35C", VA = "0x118F35C")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x600098F")]
			[Address(RVA = "0x118F514", Offset = "0x118F514", VA = "0x118F514")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000990")]
			[Address(RVA = "0x118F628", Offset = "0x118F628", VA = "0x118F628")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000991")]
			[Address(RVA = "0x118F714", Offset = "0x118F714", VA = "0x118F714")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000992")]
			[Address(RVA = "0x118FB58", Offset = "0x118FB58", VA = "0x118FB58")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0x118FB98", Offset = "0x118FB98", VA = "0x118FB98")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000994")]
			[Address(RVA = "0x118FBD8", Offset = "0x118FBD8", VA = "0x118FBD8")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000995")]
			[Address(RVA = "0x118FC2C", Offset = "0x118FC2C", VA = "0x118FC2C")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000996")]
			[Address(RVA = "0x118FD9C", Offset = "0x118FD9C", VA = "0x118FD9C")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000997")]
			[Address(RVA = "0x119014C", Offset = "0x119014C", VA = "0x119014C")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000998")]
			[Address(RVA = "0x11901A8", Offset = "0x11901A8", VA = "0x11901A8")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000999")]
			[Address(RVA = "0x1190378", Offset = "0x1190378", VA = "0x1190378")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x600099A")]
			[Address(RVA = "0x11903F0", Offset = "0x11903F0", VA = "0x11903F0")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x600099B")]
			[Address(RVA = "0x119068C", Offset = "0x119068C", VA = "0x119068C")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600099C")]
			[Address(RVA = "0x119090C", Offset = "0x119090C", VA = "0x119090C")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x600099D")]
			[Address(RVA = "0x1190A54", Offset = "0x1190A54", VA = "0x1190A54")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600099E")]
			[Address(RVA = "0x118FEFC", Offset = "0x118FEFC", VA = "0x118FEFC")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x1190C68", Offset = "0x1190C68", VA = "0x1190C68")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x118EDD4", Offset = "0x118EDD4", VA = "0x118EDD4", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x118EDDC", Offset = "0x118EDDC", VA = "0x118EDDC", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x118EDE0", Offset = "0x118EDE0", VA = "0x118EDE0")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x118EF18", Offset = "0x118EF18", VA = "0x118EF18")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x118F020", Offset = "0x118F020", VA = "0x118F020")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A4")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A3D4", Offset = "0x65A3D4")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1190C80", Offset = "0x1190C80", VA = "0x1190C80", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1190D20", Offset = "0x1190D20", VA = "0x1190D20")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1190DA4", Offset = "0x1190DA4", VA = "0x1190DA4")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1190E3C", Offset = "0x1190E3C", VA = "0x1190E3C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1190E68", Offset = "0x1190E68", VA = "0x1190E68")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1190E98", Offset = "0x1190E98", VA = "0x1190E98", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1190F44", Offset = "0x1190F44", VA = "0x1190F44")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1190F70", Offset = "0x1190F70", VA = "0x1190F70")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A5")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000164")]
		public enum BoneMapType
		{
			[Token(Token = "0x40009CE")]
			Parent,
			[Token(Token = "0x40009CF")]
			Bone1,
			[Token(Token = "0x40009D0")]
			Bone2,
			[Token(Token = "0x40009D1")]
			Bone3
		}

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A3EC", Offset = "0x65A3EC")]
		public float maintainRotationWeight;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A404", Offset = "0x65A404")]
		public float weight;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1190FB0", Offset = "0x1190FB0", VA = "0x1190FB0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1191034", Offset = "0x1191034", VA = "0x1191034")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1191108", Offset = "0x1191108", VA = "0x1191108")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x11914D8", Offset = "0x11914D8", VA = "0x11914D8")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x11915D8", Offset = "0x11915D8", VA = "0x11915D8")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1191704", Offset = "0x1191704", VA = "0x1191704")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1191710", Offset = "0x1191710", VA = "0x1191710")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x11917E4", Offset = "0x11917E4", VA = "0x11917E4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x11918C8", Offset = "0x11918C8", VA = "0x11918C8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1191BE4", Offset = "0x1191BE4", VA = "0x1191BE4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1191CBC", Offset = "0x1191CBC", VA = "0x1191CBC")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A6")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A41C", Offset = "0x65A41C")]
		public int iterations;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A434", Offset = "0x65A434")]
		public float twistWeight;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1191EE8", Offset = "0x1191EE8", VA = "0x1191EE8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x119220C", Offset = "0x119220C", VA = "0x119220C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1192328", Offset = "0x1192328", VA = "0x1192328")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1192478", Offset = "0x1192478", VA = "0x1192478")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1192488", Offset = "0x1192488", VA = "0x1192488")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1192520", Offset = "0x1192520", VA = "0x1192520")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x11925F0", Offset = "0x11925F0", VA = "0x11925F0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1193014", Offset = "0x1193014", VA = "0x1193014")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1193060", Offset = "0x1193060", VA = "0x1193060")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1193544", Offset = "0x1193544", VA = "0x1193544")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1193B80", Offset = "0x1193B80", VA = "0x1193B80")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1193DDC", Offset = "0x1193DDC", VA = "0x1193DDC")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1193FF0", Offset = "0x1193FF0", VA = "0x1193FF0")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A7")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000165")]
		public class Point
		{
			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65DE2C", Offset = "0x65DE2C")]
			public float weight;

			[Token(Token = "0x40009D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40009D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40009D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x1196694", Offset = "0x1196694", VA = "0x1196694")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x11966F8", Offset = "0x11966F8", VA = "0x11966F8")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x11968C8", Offset = "0x11968C8", VA = "0x11968C8")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x1196908", Offset = "0x1196908", VA = "0x1196908")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x1196948", Offset = "0x1196948", VA = "0x1196948")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x11969AC", Offset = "0x11969AC", VA = "0x11969AC")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x1195F88", Offset = "0x1195F88", VA = "0x1195F88")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000166")]
		public class Bone : Point
		{
			[Token(Token = "0x40009D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40009D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40009DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40009DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40009DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x170000E5")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x60009A8")]
				[Address(RVA = "0x119537C", Offset = "0x119537C", VA = "0x119537C")]
				get
				{
					return null;
				}
				[Token(Token = "0x60009A9")]
				[Address(RVA = "0x1195478", Offset = "0x1195478", VA = "0x1195478")]
				set
				{
				}
			}

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x1195500", Offset = "0x1195500", VA = "0x1195500")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x1195808", Offset = "0x1195808", VA = "0x1195808")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x1195C00", Offset = "0x1195C00", VA = "0x1195C00")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x1195EB0", Offset = "0x1195EB0", VA = "0x1195EB0")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x1195F04", Offset = "0x1195F04", VA = "0x1195F04")]
			public Bone()
			{
			}

			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x1196008", Offset = "0x1196008", VA = "0x1196008")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x11960A0", Offset = "0x11960A0", VA = "0x11960A0")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000167")]
		public class Node : Point
		{
			[Token(Token = "0x40009DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40009DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40009DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40009E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x1196630", Offset = "0x1196630", VA = "0x1196630")]
			public Node()
			{
			}

			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x1196634", Offset = "0x1196634", VA = "0x1196634")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x119665C", Offset = "0x119665C", VA = "0x119665C")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000168")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000169")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A45C", Offset = "0x65A45C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A45C", Offset = "0x65A45C")]
		public float IKPositionWeight;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65A4B0", Offset = "0x65A4B0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000049")]
		public bool initiated
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x118AEFC", Offset = "0x118AEFC", VA = "0x118AEFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662A60", Offset = "0x662A60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x1194978", Offset = "0x1194978", VA = "0x1194978")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662A70", Offset = "0x662A70")]
			private set
			{
			}
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x11944FC", Offset = "0x11944FC", VA = "0x11944FC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000482")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x118AFEC", Offset = "0x118AFEC", VA = "0x118AFEC")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x118AF04", Offset = "0x118AF04", VA = "0x118AF04")]
		public void Update()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1194984", Offset = "0x1194984", VA = "0x1194984", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1194990", Offset = "0x1194990", VA = "0x1194990")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x119499C", Offset = "0x119499C", VA = "0x119499C")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x11949A4", Offset = "0x11949A4", VA = "0x11949A4")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1189558", Offset = "0x1189558", VA = "0x1189558")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x600048C")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x600048D")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x600048E")]
		public abstract void FixTransforms();

		[Token(Token = "0x600048F")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000490")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000491")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1194A28", Offset = "0x1194A28", VA = "0x1194A28")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x1194A40", Offset = "0x1194A40", VA = "0x1194A40")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1194BBC", Offset = "0x1194BBC", VA = "0x1194BBC")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x1194C90", Offset = "0x1194C90", VA = "0x1194C90")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x1195364", Offset = "0x1195364", VA = "0x1195364")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A8")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A4F8", Offset = "0x65A4F8")]
		public float poleWeight;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A510", Offset = "0x65A510")]
		public float clampWeight;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A528", Offset = "0x65A528")]
		public int clampSmoothing;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700004A")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x1196B68", Offset = "0x1196B68", VA = "0x1196B68")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004B")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x1196C3C", Offset = "0x1196C3C", VA = "0x1196C3C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004C")]
		protected override int minBones
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x1197C28", Offset = "0x1197C28", VA = "0x1197C28", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004D")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x11982B8", Offset = "0x11982B8", VA = "0x11982B8", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1196A60", Offset = "0x1196A60", VA = "0x1196A60")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1196D10", Offset = "0x1196D10", VA = "0x1196D10", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1197018", Offset = "0x1197018", VA = "0x1197018", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1197A4C", Offset = "0x1197A4C", VA = "0x1197A4C")]
		private void Solve()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1197624", Offset = "0x1197624", VA = "0x1197624")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1197C30", Offset = "0x1197C30", VA = "0x1197C30")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x11983C0", Offset = "0x11983C0", VA = "0x11983C0")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A9")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A540", Offset = "0x65A540")]
		public float IKRotationWeight;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x11984D0", Offset = "0x11984D0", VA = "0x11984D0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1198968", Offset = "0x1198968", VA = "0x1198968")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1198A28", Offset = "0x1198A28", VA = "0x1198A28", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1198C14", Offset = "0x1198C14", VA = "0x1198C14", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1198DD0", Offset = "0x1198DD0", VA = "0x1198DD0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1198E48", Offset = "0x1198E48", VA = "0x1198E48", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1198ED4", Offset = "0x1198ED4", VA = "0x1198ED4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x119955C", Offset = "0x119955C", VA = "0x119955C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1199588", Offset = "0x1199588", VA = "0x1199588")]
		private void Solve()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1198F5C", Offset = "0x1198F5C", VA = "0x1198F5C")]
		private void Read()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1199630", Offset = "0x1199630", VA = "0x1199630")]
		private void Write()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1199930", Offset = "0x1199930", VA = "0x1199930")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AA")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1199A80", Offset = "0x1199A80", VA = "0x1199A80")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1199BD8", Offset = "0x1199BD8", VA = "0x1199BD8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x119A4B4", Offset = "0x119A4B4", VA = "0x119A4B4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x119AD8C", Offset = "0x119AD8C", VA = "0x119AD8C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x119B858", Offset = "0x119B858", VA = "0x119B858")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700004E")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x119D250", Offset = "0x119D250", VA = "0x119D250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x119B85C", Offset = "0x119B85C", VA = "0x119B85C")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x119C474", Offset = "0x119C474", VA = "0x119C474")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x119C5AC", Offset = "0x119C5AC", VA = "0x119C5AC", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x119C650", Offset = "0x119C650", VA = "0x119C650", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x119CEA8", Offset = "0x119CEA8", VA = "0x119CEA8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x119D258", Offset = "0x119D258", VA = "0x119D258")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x119B930", Offset = "0x119B930", VA = "0x119B930")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x119C558", Offset = "0x119C558", VA = "0x119C558")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x119D1D8", Offset = "0x119D1D8", VA = "0x119D1D8")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x119C0C8", Offset = "0x119C0C8", VA = "0x119C0C8")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x119DF0C", Offset = "0x119DF0C", VA = "0x119DF0C")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x119E034", Offset = "0x119E034", VA = "0x119E034")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x119E1CC", Offset = "0x119E1CC", VA = "0x119E1CC")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x119E364", Offset = "0x119E364", VA = "0x119E364")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x119CB10", Offset = "0x119CB10", VA = "0x119CB10")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x119CCDC", Offset = "0x119CCDC", VA = "0x119CCDC")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x119E604", Offset = "0x119E604", VA = "0x119E604")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x119D72C", Offset = "0x119D72C", VA = "0x119D72C")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x119C548", Offset = "0x119C548", VA = "0x119C548")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x119F10C", Offset = "0x119F10C", VA = "0x119F10C")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x119E7FC", Offset = "0x119E7FC", VA = "0x119E7FC")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x119D370", Offset = "0x119D370", VA = "0x119D370")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x119D550", Offset = "0x119D550", VA = "0x119D550")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x119F324", Offset = "0x119F324", VA = "0x119F324")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AC")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A558", Offset = "0x65A558")]
		public float rootPin;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x119F398", Offset = "0x119F398", VA = "0x119F398", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x11A02F4", Offset = "0x11A02F4", VA = "0x11A02F4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x11A03D8", Offset = "0x11A03D8", VA = "0x11A03D8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x11A04E0", Offset = "0x11A04E0", VA = "0x11A04E0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x11A064C", Offset = "0x11A064C", VA = "0x11A064C")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x11A07A4", Offset = "0x11A07A4", VA = "0x11A07A4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x11A0EFC", Offset = "0x11A0EFC", VA = "0x11A0EFC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x11A1188", Offset = "0x11A1188", VA = "0x11A1188", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x11A0FD0", Offset = "0x11A0FD0", VA = "0x11A0FD0")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x11A0AD8", Offset = "0x11A0AD8", VA = "0x11A0AD8")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x11A1260", Offset = "0x11A1260", VA = "0x11A1260")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AD")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A570", Offset = "0x65A570")]
		public int iterations;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x11A12D8", Offset = "0x11A12D8", VA = "0x11A12D8")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x11A140C", Offset = "0x11A140C", VA = "0x11A140C")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x11A1478", Offset = "0x11A1478", VA = "0x11A1478")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x118C958", Offset = "0x118C958", VA = "0x118C958")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x118B814", Offset = "0x118B814", VA = "0x118B814")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x11A162C", Offset = "0x11A162C", VA = "0x11A162C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x11A188C", Offset = "0x11A188C", VA = "0x11A188C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x11A1AB4", Offset = "0x11A1AB4", VA = "0x11A1AB4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x11A1D58", Offset = "0x11A1D58", VA = "0x11A1D58", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x11A1E94", Offset = "0x11A1E94", VA = "0x11A1E94", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x11A1FE4", Offset = "0x11A1FE4", VA = "0x11A1FE4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x11A21E4", Offset = "0x11A21E4", VA = "0x11A21E4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x11A241C", Offset = "0x11A241C", VA = "0x11A241C", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x11A2854", Offset = "0x11A2854", VA = "0x11A2854", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x11A2E08", Offset = "0x11A2E08", VA = "0x11A2E08", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x11A2E6C", Offset = "0x11A2E6C", VA = "0x11A2E6C", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x11A2FCC", Offset = "0x11A2FCC", VA = "0x11A2FCC")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40004CA")]
		Body,
		[Token(Token = "0x40004CB")]
		LeftShoulder,
		[Token(Token = "0x40004CC")]
		RightShoulder,
		[Token(Token = "0x40004CD")]
		LeftThigh,
		[Token(Token = "0x40004CE")]
		RightThigh,
		[Token(Token = "0x40004CF")]
		LeftHand,
		[Token(Token = "0x40004D0")]
		RightHand,
		[Token(Token = "0x40004D1")]
		LeftFoot,
		[Token(Token = "0x40004D2")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x20000AF")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40004D4")]
		LeftArm,
		[Token(Token = "0x40004D5")]
		RightArm,
		[Token(Token = "0x40004D6")]
		LeftLeg,
		[Token(Token = "0x40004D7")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A588", Offset = "0x65A588")]
		public float spineStiffness;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A5A0", Offset = "0x65A5A0")]
		public float pullBodyVertical;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A5B8", Offset = "0x65A5B8")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65A5D0", Offset = "0x65A5D0")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700004F")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x11A30AC", Offset = "0x11A30AC", VA = "0x11A30AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x11A30B4", Offset = "0x11A30B4", VA = "0x11A30B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x11A30BC", Offset = "0x11A30BC", VA = "0x11A30BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x11A30C4", Offset = "0x11A30C4", VA = "0x11A30C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x11A30CC", Offset = "0x11A30CC", VA = "0x11A30CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x11A30D4", Offset = "0x11A30D4", VA = "0x11A30D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x11A30DC", Offset = "0x11A30DC", VA = "0x11A30DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x11A30E4", Offset = "0x11A30E4", VA = "0x11A30E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x11A30EC", Offset = "0x11A30EC", VA = "0x11A30EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x11A30F4", Offset = "0x11A30F4", VA = "0x11A30F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x11A313C", Offset = "0x11A313C", VA = "0x11A313C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x11A3184", Offset = "0x11A3184", VA = "0x11A3184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x11A31CC", Offset = "0x11A31CC", VA = "0x11A31CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x11A3214", Offset = "0x11A3214", VA = "0x11A3214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x11A3258", Offset = "0x11A3258", VA = "0x11A3258")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x11A32A0", Offset = "0x11A32A0", VA = "0x11A32A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x11A32E8", Offset = "0x11A32E8", VA = "0x11A32E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x11A3330", Offset = "0x11A3330", VA = "0x11A3330")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x11A6254", Offset = "0x11A6254", VA = "0x11A6254")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662A80", Offset = "0x662A80")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x11A6260", Offset = "0x11A6260", VA = "0x11A6260")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662A90", Offset = "0x662A90")]
			private set
			{
			}
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x11A3374", Offset = "0x11A3374", VA = "0x11A3374")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x11A34EC", Offset = "0x11A34EC", VA = "0x11A34EC")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x11A33DC", Offset = "0x11A33DC", VA = "0x11A33DC")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x11A35DC", Offset = "0x11A35DC", VA = "0x11A35DC")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x11896BC", Offset = "0x11896BC", VA = "0x11896BC")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x11A371C", Offset = "0x11A371C", VA = "0x11A371C")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x11A382C", Offset = "0x11A382C", VA = "0x11A382C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x11A3938", Offset = "0x11A3938", VA = "0x11A3938")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x11A3A44", Offset = "0x11A3A44", VA = "0x11A3A44")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x11A3A4C", Offset = "0x11A3A4C", VA = "0x11A3A4C")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x11A3A90", Offset = "0x11A3A90", VA = "0x11A3A90")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x11A3BB4", Offset = "0x11A3BB4", VA = "0x11A3BB4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x11A3E80", Offset = "0x11A3E80", VA = "0x11A3E80")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x11A59C0", Offset = "0x11A59C0", VA = "0x11A59C0")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x11A5F58", Offset = "0x11A5F58", VA = "0x11A5F58")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x11A6018", Offset = "0x11A6018", VA = "0x11A6018")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x11A5D88", Offset = "0x11A5D88", VA = "0x11A5D88")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x11A5E70", Offset = "0x11A5E70", VA = "0x11A5E70")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x11A626C", Offset = "0x11A626C", VA = "0x11A626C")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x11A6344", Offset = "0x11A6344", VA = "0x11A6344", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x11A653C", Offset = "0x11A653C", VA = "0x11A653C")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x11A66FC", Offset = "0x11A66FC", VA = "0x11A66FC")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x11A6904", Offset = "0x11A6904", VA = "0x11A6904")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x11A6B78", Offset = "0x11A6B78", VA = "0x11A6B78", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x11A708C", Offset = "0x11A708C", VA = "0x11A708C", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x11A71C8", Offset = "0x11A71C8", VA = "0x11A71C8")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000062")]
		protected virtual int minBones
		{
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x11A7C40", Offset = "0x11A7C40", VA = "0x11A7C40", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000063")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x11A7C48", Offset = "0x11A7C48", VA = "0x11A7C48", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x11A7C50", Offset = "0x11A7C50", VA = "0x11A7C50", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x11A7C60", Offset = "0x11A7C60", VA = "0x11A7C60", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000066")]
		protected float positionOffset
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x119ACC8", Offset = "0x119ACC8", VA = "0x119ACC8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x11A71D4", Offset = "0x11A71D4", VA = "0x11A71D4")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x11A73E0", Offset = "0x11A73E0", VA = "0x11A73E0")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x11A75AC", Offset = "0x11A75AC", VA = "0x11A75AC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x11A7644", Offset = "0x11A7644", VA = "0x11A7644", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x11A76F0", Offset = "0x11A76F0", VA = "0x11A76F0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x11A7B04", Offset = "0x11A7B04", VA = "0x11A7B04", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x11A7B0C", Offset = "0x11A7B0C", VA = "0x11A7B0C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x11A7C58", Offset = "0x11A7C58", VA = "0x11A7C58", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x11A7C5C", Offset = "0x11A7C5C", VA = "0x11A7C5C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1199C88", Offset = "0x1199C88", VA = "0x1199C88")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x119A804", Offset = "0x119A804", VA = "0x119A804")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x11A7E40", Offset = "0x11A7E40", VA = "0x11A7E40")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1198454", Offset = "0x1198454", VA = "0x1198454")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B2")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A5E0", Offset = "0x65A5E0")]
		public float IKRotationWeight;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x11A81A8", Offset = "0x11A81A8", VA = "0x11A81A8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x11A8640", Offset = "0x11A8640", VA = "0x11A8640")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x11A8700", Offset = "0x11A8700", VA = "0x11A8700", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x11A88EC", Offset = "0x11A88EC", VA = "0x11A88EC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x11A8AA8", Offset = "0x11A8AA8", VA = "0x11A8AA8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x11A8B20", Offset = "0x11A8B20", VA = "0x11A8B20", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x11A8BAC", Offset = "0x11A8BAC", VA = "0x11A8BAC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x11A9238", Offset = "0x11A9238", VA = "0x11A9238", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x11A9264", Offset = "0x11A9264", VA = "0x11A9264")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x11A8C34", Offset = "0x11A8C34", VA = "0x11A8C34")]
		private void Read()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x11A93A0", Offset = "0x11A93A0", VA = "0x11A93A0")]
		private void Write()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x11A96A0", Offset = "0x11A96A0", VA = "0x11A96A0")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B3")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x200016A")]
		public enum BendModifier
		{
			[Token(Token = "0x40009E2")]
			Animation,
			[Token(Token = "0x40009E3")]
			Target,
			[Token(Token = "0x40009E4")]
			Parent,
			[Token(Token = "0x40009E5")]
			Arm,
			[Token(Token = "0x40009E6")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x200016B")]
		public struct AxisDirection
		{
			[Token(Token = "0x40009E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x40009E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x40009E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x71BC10", Offset = "0x71BC10", VA = "0x71BC10")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A5F8", Offset = "0x65A5F8")]
		public float maintainRotationWeight;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A610", Offset = "0x65A610")]
		public float bendModifierWeight;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000067")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x11AB040", Offset = "0x11AB040", VA = "0x11AB040")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x11A97F0", Offset = "0x11A97F0", VA = "0x11A97F0")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x11A9850", Offset = "0x11A9850", VA = "0x11A9850")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x11A98A4", Offset = "0x11A98A4", VA = "0x11A98A4", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x11AA030", Offset = "0x11AA030", VA = "0x11AA030", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x11AAD98", Offset = "0x11AAD98", VA = "0x11AAD98", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x11AAF3C", Offset = "0x11AAF3C", VA = "0x11AAF3C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x11AAFB4", Offset = "0x11AAFB4", VA = "0x11AAFB4")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x11A9CDC", Offset = "0x11A9CDC", VA = "0x11A9CDC")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x11AA16C", Offset = "0x11AA16C", VA = "0x11AA16C")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000B4")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200016C")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x170000E6")]
			public Vector3 forward
			{
				[Token(Token = "0x60009C1")]
				[Address(RVA = "0x11CE618", Offset = "0x11CE618", VA = "0x11CE618")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x11CEE6C", Offset = "0x11CEE6C", VA = "0x11CEE6C")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x11CD680", Offset = "0x11CD680", VA = "0x11CD680")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x11CDAC4", Offset = "0x11CDAC4", VA = "0x11CDAC4")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x11CEADC", Offset = "0x11CEADC", VA = "0x11CEADC")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A628", Offset = "0x65A628")]
		public float bodyWeight;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A640", Offset = "0x65A640")]
		public float headWeight;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A658", Offset = "0x65A658")]
		public float eyesWeight;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A670", Offset = "0x65A670")]
		public float clampWeight;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A688", Offset = "0x65A688")]
		public float clampWeightHead;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A6A0", Offset = "0x65A6A0")]
		public float clampWeightEyes;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A6B8", Offset = "0x65A6B8")]
		public int clampSmoothing;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x17000068")]
		private bool spineIsValid
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x11CCB54", Offset = "0x11CCB54", VA = "0x11CCB54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x11CCDF4", Offset = "0x11CCDF4", VA = "0x11CCDF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		private bool headIsValid
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x11CCC9C", Offset = "0x11CCC9C", VA = "0x11CCC9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		private bool headIsEmpty
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x11CCE28", Offset = "0x11CCE28", VA = "0x11CCE28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		private bool eyesIsValid
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x11CCCAC", Offset = "0x11CCCAC", VA = "0x11CCCAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x11CCEA8", Offset = "0x11CCEA8", VA = "0x11CCEA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x11CC110", Offset = "0x11CC110", VA = "0x11CC110")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x11CC194", Offset = "0x11CC194", VA = "0x11CC194")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x11CC240", Offset = "0x11CC240", VA = "0x11CC240")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x11CC308", Offset = "0x11CC308", VA = "0x11CC308")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x11CC3F4", Offset = "0x11CC3F4", VA = "0x11CC3F4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x11CC500", Offset = "0x11CC500", VA = "0x11CC500")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x11CC648", Offset = "0x11CC648", VA = "0x11CC648", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x11CC7E8", Offset = "0x11CC7E8", VA = "0x11CC7E8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x11CC9A4", Offset = "0x11CC9A4", VA = "0x11CC9A4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x11CCEDC", Offset = "0x11CCEDC", VA = "0x11CCEDC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x11CD1EC", Offset = "0x11CD1EC", VA = "0x11CD1EC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x11CD3AC", Offset = "0x11CD3AC", VA = "0x11CD3AC")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x11CD6AC", Offset = "0x11CD6AC", VA = "0x11CD6AC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x11CDC10", Offset = "0x11CDC10", VA = "0x11CDC10", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x11CDD1C", Offset = "0x11CDD1C", VA = "0x11CDD1C")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x11CE018", Offset = "0x11CE018", VA = "0x11CE018")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x11CE314", Offset = "0x11CE314", VA = "0x11CE314")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x11CE6EC", Offset = "0x11CE6EC", VA = "0x11CE6EC")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x11CD460", Offset = "0x11CD460", VA = "0x11CD460")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x11CEC74", Offset = "0x11CEC74", VA = "0x11CEC74")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B5")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200016D")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x40009EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x40009EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x11D0890", Offset = "0x11D0890", VA = "0x11D0890")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x11D17F0", Offset = "0x11D17F0", VA = "0x11D17F0")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x11D13E4", Offset = "0x11D13E4", VA = "0x11D13E4")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x11D19C8", Offset = "0x11D19C8", VA = "0x11D19C8")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A6D0", Offset = "0x65A6D0")]
		public float IKRotationWeight;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x11CEE74", Offset = "0x11CEE74", VA = "0x11CEE74")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x11CF098", Offset = "0x11CF098", VA = "0x11CF098")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x11CF2A0", Offset = "0x11CF2A0", VA = "0x11CF2A0")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x11CF2AC", Offset = "0x11CF2AC", VA = "0x11CF2AC")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x11CF330", Offset = "0x11CF330", VA = "0x11CF330")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x11CF33C", Offset = "0x11CF33C", VA = "0x11CF33C")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x11CF344", Offset = "0x11CF344", VA = "0x11CF344", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x11CF498", Offset = "0x11CF498", VA = "0x11CF498", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x11CF5CC", Offset = "0x11CF5CC", VA = "0x11CF5CC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x11CF638", Offset = "0x11CF638", VA = "0x11CF638", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x11CF6BC", Offset = "0x11CF6BC", VA = "0x11CF6BC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x11CFBAC", Offset = "0x11CFBAC", VA = "0x11CFBAC")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x11CFC3C", Offset = "0x11CFC3C", VA = "0x11CFC3C")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x11D02C8", Offset = "0x11D02C8", VA = "0x11D02C8")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x11D04E0", Offset = "0x11D04E0", VA = "0x11D04E0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x11D0754", Offset = "0x11D0754", VA = "0x11D0754")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x11D063C", Offset = "0x11D063C", VA = "0x11D063C")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x11D0A50", Offset = "0x11D0A50", VA = "0x11D0A50", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x11D18AC", Offset = "0x11D18AC", VA = "0x11D18AC", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x11D18B0", Offset = "0x11D18B0", VA = "0x11D18B0", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x11D18B4", Offset = "0x11D18B4", VA = "0x11D18B4", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x11D14B8", Offset = "0x11D14B8", VA = "0x11D14B8")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x11D18B8", Offset = "0x11D18B8", VA = "0x11D18B8")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200016E")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20001C5")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000C3A")]
				YawPitch,
				[Token(Token = "0x4000C3B")]
				FromTo
			}

			[Token(Token = "0x40009EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DE44", Offset = "0x65DE44")]
			public Transform target;

			[Token(Token = "0x40009ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DE7C", Offset = "0x65DE7C")]
			public Transform bendGoal;

			[Token(Token = "0x40009EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DEB4", Offset = "0x65DEB4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65DEB4", Offset = "0x65DEB4")]
			public float positionWeight;

			[Token(Token = "0x40009EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DF08", Offset = "0x65DF08")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65DF08", Offset = "0x65DF08")]
			public float rotationWeight;

			[Token(Token = "0x40009F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DF5C", Offset = "0x65DF5C")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40009F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DF94", Offset = "0x65DF94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65DF94", Offset = "0x65DF94")]
			public float shoulderRotationWeight;

			[Token(Token = "0x40009F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65DFE8", Offset = "0x65DFE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65DFE8", Offset = "0x65DFE8")]
			public float shoulderTwistWeight;

			[Token(Token = "0x40009F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E03C", Offset = "0x65E03C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65E03C", Offset = "0x65E03C")]
			public float bendGoalWeight;

			[Token(Token = "0x40009F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E090", Offset = "0x65E090")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65E090", Offset = "0x65E090")]
			public float swivelOffset;

			[Token(Token = "0x40009F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E0EC", Offset = "0x65E0EC")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40009F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E124", Offset = "0x65E124")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40009F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E15C", Offset = "0x65E15C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65E15C", Offset = "0x65E15C")]
			public float armLengthMlp;

			[Token(Token = "0x40009F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E1B4", Offset = "0x65E1B4")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40009F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40009FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40009FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40009FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40009FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65E22C", Offset = "0x65E22C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40009FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65E23C", Offset = "0x65E23C")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40009FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000A00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000A01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000A02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000A03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000A04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000A05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000A06")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000A07")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000E7")]
			public Vector3 position
			{
				[Token(Token = "0x60009C6")]
				[Address(RVA = "0x11DC270", Offset = "0x11DC270", VA = "0x11DC270")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664134", Offset = "0x664134")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60009C7")]
				[Address(RVA = "0x11DC27C", Offset = "0x11DC27C", VA = "0x11DC27C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664144", Offset = "0x664144")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E8")]
			public Quaternion rotation
			{
				[Token(Token = "0x60009C8")]
				[Address(RVA = "0x11DC288", Offset = "0x11DC288", VA = "0x11DC288")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664154", Offset = "0x664154")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60009C9")]
				[Address(RVA = "0x11DC294", Offset = "0x11DC294", VA = "0x11DC294")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664164", Offset = "0x664164")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E9")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60009CA")]
				[Address(RVA = "0x11DC2A0", Offset = "0x11DC2A0", VA = "0x11DC2A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EA")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60009CB")]
				[Address(RVA = "0x11DC2E4", Offset = "0x11DC2E4", VA = "0x11DC2E4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EB")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60009CC")]
				[Address(RVA = "0x11DC334", Offset = "0x11DC334", VA = "0x11DC334")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EC")]
			private VirtualBone hand
			{
				[Token(Token = "0x60009CD")]
				[Address(RVA = "0x11DC390", Offset = "0x11DC390", VA = "0x11DC390")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x11DC3EC", Offset = "0x11DC3EC", VA = "0x11DC3EC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x11DCEBC", Offset = "0x11DCEBC", VA = "0x11DCEBC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x11DD104", Offset = "0x11DD104", VA = "0x11DD104", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x11DD1B0", Offset = "0x11DD1B0", VA = "0x11DD1B0")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x11DA040", Offset = "0x11DA040", VA = "0x11DA040")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x11DE9F0", Offset = "0x11DE9F0", VA = "0x11DE9F0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x11DEA60", Offset = "0x11DEA60", VA = "0x11DEA60", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x11DD698", Offset = "0x11DD698", VA = "0x11DD698")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x11DDA88", Offset = "0x11DDA88", VA = "0x11DDA88")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x11DEDAC", Offset = "0x11DEDAC", VA = "0x11DEDAC")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x11DBF6C", Offset = "0x11DBF6C", VA = "0x11DBF6C")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200016F")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000A08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65E24C", Offset = "0x65E24C")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000A09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65E25C", Offset = "0x65E25C")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000A0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000A0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000A0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000A0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000A0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x170000ED")]
			public float sqrMag
			{
				[Token(Token = "0x60009DE")]
				[Address(RVA = "0x11DEF9C", Offset = "0x11DEF9C", VA = "0x11DEF9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664174", Offset = "0x664174")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009DF")]
				[Address(RVA = "0x11DEFA4", Offset = "0x11DEFA4", VA = "0x11DEFA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664184", Offset = "0x664184")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EE")]
			public float mag
			{
				[Token(Token = "0x60009E0")]
				[Address(RVA = "0x11DD770", Offset = "0x11DD770", VA = "0x11DD770")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664194", Offset = "0x664194")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009E1")]
				[Address(RVA = "0x11DEFAC", Offset = "0x11DEFAC", VA = "0x11DEFAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6641A4", Offset = "0x6641A4")]
				private set
				{
				}
			}

			[Token(Token = "0x60009D9")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x60009DA")]
			public abstract void PreSolve();

			[Token(Token = "0x60009DB")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x60009DC")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x60009DD")]
			public abstract void ResetOffsets();

			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x11D6F20", Offset = "0x11D6F20", VA = "0x11D6F20")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x11DF4F8", Offset = "0x11DF4F8", VA = "0x11DF4F8")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x11DF690", Offset = "0x11DF690", VA = "0x11DF690")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x11DFA18", Offset = "0x11DFA18", VA = "0x11DFA18")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x11D9788", Offset = "0x11D9788", VA = "0x11D9788")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x11DE7D8", Offset = "0x11DE7D8", VA = "0x11DE7D8")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x11DFA6C", Offset = "0x11DFA6C", VA = "0x11DFA6C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x11DFC0C", Offset = "0x11DFC0C", VA = "0x11DFC0C")]
			public void Visualize()
			{
			}

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x11DEF04", Offset = "0x11DEF04", VA = "0x11DEF04")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000170")]
		public class Footstep
		{
			[Token(Token = "0x4000A0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000A10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000A11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000A12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000A13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000A14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000A15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65E27C", Offset = "0x65E27C")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000A16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000A17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000A18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000A19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000A1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000A1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000A1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000EF")]
			public bool isStepping
			{
				[Token(Token = "0x60009EB")]
				[Address(RVA = "0x11DFC34", Offset = "0x11DFC34", VA = "0x11DFC34")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000F0")]
			public float stepProgress
			{
				[Token(Token = "0x60009EC")]
				[Address(RVA = "0x11DFC48", Offset = "0x11DFC48", VA = "0x11DFC48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6641B4", Offset = "0x6641B4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009ED")]
				[Address(RVA = "0x11DFC50", Offset = "0x11DFC50", VA = "0x11DFC50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6641C4", Offset = "0x6641C4")]
				private set
				{
				}
			}

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x11DFC58", Offset = "0x11DFC58", VA = "0x11DFC58")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x11DFDEC", Offset = "0x11DFDEC", VA = "0x11DFDEC")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x11DFE34", Offset = "0x11DFE34", VA = "0x11DFE34")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x11DFF40", Offset = "0x11DFF40", VA = "0x11DFF40")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x11E0118", Offset = "0x11E0118", VA = "0x11E0118")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x11E0304", Offset = "0x11E0304", VA = "0x11E0304")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000171")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000A1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E28C", Offset = "0x65E28C")]
			public Transform target;

			[Token(Token = "0x4000A1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E2C4", Offset = "0x65E2C4")]
			public Transform bendGoal;

			[Token(Token = "0x4000A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E2FC", Offset = "0x65E2FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65E2FC", Offset = "0x65E2FC")]
			public float positionWeight;

			[Token(Token = "0x4000A20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E350", Offset = "0x65E350")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65E350", Offset = "0x65E350")]
			public float rotationWeight;

			[Token(Token = "0x4000A21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E3A4", Offset = "0x65E3A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65E3A4", Offset = "0x65E3A4")]
			public float bendGoalWeight;

			[Token(Token = "0x4000A22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E3F8", Offset = "0x65E3F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65E3F8", Offset = "0x65E3F8")]
			public float swivelOffset;

			[Token(Token = "0x4000A23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E454", Offset = "0x65E454")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65E454", Offset = "0x65E454")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E4A8", Offset = "0x65E4A8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65E4A8", Offset = "0x65E4A8")]
			public float legLengthMlp;

			[Token(Token = "0x4000A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E500", Offset = "0x65E500")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000A27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000A28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000A29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000A2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000A2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x4000A2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65E598", Offset = "0x65E598")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65E5A8", Offset = "0x65E5A8")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000A2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65E5B8", Offset = "0x65E5B8")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x4000A2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65E5C8", Offset = "0x65E5C8")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x4000A30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 footPosition;

			[Token(Token = "0x4000A31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Quaternion footRotation;

			[Token(Token = "0x4000A32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 bendNormal;

			[Token(Token = "0x4000A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x4000A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x4000A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x4000A36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x170000F1")]
			public Vector3 position
			{
				[Token(Token = "0x60009F4")]
				[Address(RVA = "0x11D9604", Offset = "0x11D9604", VA = "0x11D9604")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6641D4", Offset = "0x6641D4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60009F5")]
				[Address(RVA = "0x11E0524", Offset = "0x11E0524", VA = "0x11E0524")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6641E4", Offset = "0x6641E4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F2")]
			public Quaternion rotation
			{
				[Token(Token = "0x60009F6")]
				[Address(RVA = "0x11E0530", Offset = "0x11E0530", VA = "0x11E0530")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6641F4", Offset = "0x6641F4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60009F7")]
				[Address(RVA = "0x11E053C", Offset = "0x11E053C", VA = "0x11E053C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664204", Offset = "0x664204")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F3")]
			public bool hasToes
			{
				[Token(Token = "0x60009F8")]
				[Address(RVA = "0x11E0548", Offset = "0x11E0548", VA = "0x11E0548")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664214", Offset = "0x664214")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60009F9")]
				[Address(RVA = "0x11E0550", Offset = "0x11E0550", VA = "0x11E0550")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664224", Offset = "0x664224")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F4")]
			public VirtualBone thigh
			{
				[Token(Token = "0x60009FA")]
				[Address(RVA = "0x11E055C", Offset = "0x11E055C", VA = "0x11E055C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F5")]
			private VirtualBone calf
			{
				[Token(Token = "0x60009FB")]
				[Address(RVA = "0x11E05A0", Offset = "0x11E05A0", VA = "0x11E05A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F6")]
			private VirtualBone foot
			{
				[Token(Token = "0x60009FC")]
				[Address(RVA = "0x11E05E8", Offset = "0x11E05E8", VA = "0x11E05E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F7")]
			private VirtualBone toes
			{
				[Token(Token = "0x60009FD")]
				[Address(RVA = "0x11E0630", Offset = "0x11E0630", VA = "0x11E0630")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F8")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x60009FE")]
				[Address(RVA = "0x11D95A8", Offset = "0x11D95A8", VA = "0x11D95A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F9")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60009FF")]
				[Address(RVA = "0x11E0678", Offset = "0x11E0678", VA = "0x11E0678")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664234", Offset = "0x664234")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A00")]
				[Address(RVA = "0x11E0684", Offset = "0x11E0684", VA = "0x11E0684")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664244", Offset = "0x664244")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x11E0690", Offset = "0x11E0690", VA = "0x11E0690", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x11E0EA0", Offset = "0x11E0EA0", VA = "0x11E0EA0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x11E1734", Offset = "0x11E1734", VA = "0x11E1734", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x11E1630", Offset = "0x11E1630", VA = "0x11E1630")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x11E13F8", Offset = "0x11E13F8", VA = "0x11E13F8")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x11D9980", Offset = "0x11D9980", VA = "0x11D9980")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x11E1D4C", Offset = "0x11E1D4C", VA = "0x11E1D4C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x11E2330", Offset = "0x11E2330", VA = "0x11E2330", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x11E2678", Offset = "0x11E2678", VA = "0x11E2678", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x11DC094", Offset = "0x11DC094", VA = "0x11DC094")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000172")]
		public class Locomotion
		{
			[Token(Token = "0x4000A37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E5D8", Offset = "0x65E5D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65E5D8", Offset = "0x65E5D8")]
			public float weight;

			[Token(Token = "0x4000A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E62C", Offset = "0x65E62C")]
			public float footDistance;

			[Token(Token = "0x4000A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E664", Offset = "0x65E664")]
			public float stepThreshold;

			[Token(Token = "0x4000A3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E69C", Offset = "0x65E69C")]
			public float angleThreshold;

			[Token(Token = "0x4000A3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E6D4", Offset = "0x65E6D4")]
			public float comAngleMlp;

			[Token(Token = "0x4000A3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E70C", Offset = "0x65E70C")]
			public float maxVelocity;

			[Token(Token = "0x4000A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E744", Offset = "0x65E744")]
			public float velocityFactor;

			[Token(Token = "0x4000A3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E77C", Offset = "0x65E77C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65E77C", Offset = "0x65E77C")]
			public float maxLegStretch;

			[Token(Token = "0x4000A3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E7D4", Offset = "0x65E7D4")]
			public float rootSpeed;

			[Token(Token = "0x4000A40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E80C", Offset = "0x65E80C")]
			public float stepSpeed;

			[Token(Token = "0x4000A41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E844", Offset = "0x65E844")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000A42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E87C", Offset = "0x65E87C")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000A43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E8B4", Offset = "0x65E8B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65E8B4", Offset = "0x65E8B4")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000A44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E90C", Offset = "0x65E90C")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000A45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E944", Offset = "0x65E944")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000A46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E97C", Offset = "0x65E97C")]
			public Vector3 offset;

			[Token(Token = "0x4000A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x4000A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x4000A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65E9F4", Offset = "0x65E9F4")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65EA2C", Offset = "0x65EA2C")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x4000A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65EA64", Offset = "0x65EA64")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x4000A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x4000A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000FA")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000A0B")]
				[Address(RVA = "0x11E2728", Offset = "0x11E2728", VA = "0x11E2728")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664254", Offset = "0x664254")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A0C")]
				[Address(RVA = "0x11E2734", Offset = "0x11E2734", VA = "0x11E2734")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664264", Offset = "0x664264")]
				private set
				{
				}
			}

			[Token(Token = "0x170000FB")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000A12")]
				[Address(RVA = "0x11E2BA8", Offset = "0x11E2BA8", VA = "0x11E2BA8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000FC")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000A13")]
				[Address(RVA = "0x11E2C00", Offset = "0x11E2C00", VA = "0x11E2C00")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000FD")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000A14")]
				[Address(RVA = "0x11E2C5C", Offset = "0x11E2C5C", VA = "0x11E2C5C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000FE")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000A15")]
				[Address(RVA = "0x11E2CB4", Offset = "0x11E2CB4", VA = "0x11E2CB4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x11D7068", Offset = "0x11D7068", VA = "0x11D7068")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x11D4170", Offset = "0x11D4170", VA = "0x11D4170")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x11D32AC", Offset = "0x11D32AC", VA = "0x11D32AC")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x11D30F0", Offset = "0x11D30F0", VA = "0x11D30F0")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x11D7A34", Offset = "0x11D7A34", VA = "0x11D7A34")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x11E2790", Offset = "0x11E2790", VA = "0x11E2790")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x11E2934", Offset = "0x11E2934", VA = "0x11E2934")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x11E29DC", Offset = "0x11E29DC", VA = "0x11E29DC")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x11DC188", Offset = "0x11DC188", VA = "0x11DC188")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000173")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65EA74", Offset = "0x65EA74")]
			public Transform headTarget;

			[Token(Token = "0x4000A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65EAAC", Offset = "0x65EAAC")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65EAE4", Offset = "0x65EAE4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65EAE4", Offset = "0x65EAE4")]
			public float positionWeight;

			[Token(Token = "0x4000A56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65EB38", Offset = "0x65EB38")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65EB38", Offset = "0x65EB38")]
			public float rotationWeight;

			[Token(Token = "0x4000A57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65EB8C", Offset = "0x65EB8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65EB8C", Offset = "0x65EB8C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000A58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65EBE0", Offset = "0x65EBE0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65EBE0", Offset = "0x65EBE0")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000A59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65EC34", Offset = "0x65EC34")]
			public Transform chestGoal;

			[Token(Token = "0x4000A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65EC6C", Offset = "0x65EC6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65EC6C", Offset = "0x65EC6C")]
			public float chestGoalWeight;

			[Token(Token = "0x4000A5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65ECC0", Offset = "0x65ECC0")]
			public float minHeadHeight;

			[Token(Token = "0x4000A5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65ECF8", Offset = "0x65ECF8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65ECF8", Offset = "0x65ECF8")]
			public float bodyPosStiffness;

			[Token(Token = "0x4000A5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65ED4C", Offset = "0x65ED4C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65ED4C", Offset = "0x65ED4C")]
			public float bodyRotStiffness;

			[Token(Token = "0x4000A5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65EDA0", Offset = "0x65EDA0")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x65EDA0", Offset = "0x65EDA0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65EDA0", Offset = "0x65EDA0")]
			public float neckStiffness;

			[Token(Token = "0x4000A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65EE18", Offset = "0x65EE18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65EE18", Offset = "0x65EE18")]
			public float rotateChestByHands;

			[Token(Token = "0x4000A60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65EE6C", Offset = "0x65EE6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65EE6C", Offset = "0x65EE6C")]
			public float chestClampWeight;

			[Token(Token = "0x4000A61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65EEC0", Offset = "0x65EEC0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65EEC0", Offset = "0x65EEC0")]
			public float headClampWeight;

			[Token(Token = "0x4000A62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65EF14", Offset = "0x65EF14")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000A63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65EF4C", Offset = "0x65EF4C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65EF4C", Offset = "0x65EF4C")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65EFA0", Offset = "0x65EFA0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65EFA0", Offset = "0x65EFA0")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x4000A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000A67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000A68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000A69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000A6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000A6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000A6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000A70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000A71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000A72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x4000A73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65F0D8", Offset = "0x65F0D8")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000A74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private Quaternion headRotation;

			[Token(Token = "0x4000A75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x4000A76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x4000A77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x4000A78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000A79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000A7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000A7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000A7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000A7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private int pelvisIndex;

			[Token(Token = "0x4000A7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int spineIndex;

			[Token(Token = "0x4000A7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int chestIndex;

			[Token(Token = "0x4000A80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int neckIndex;

			[Token(Token = "0x4000A81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int headIndex;

			[Token(Token = "0x4000A82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private float length;

			[Token(Token = "0x4000A83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private bool hasChest;

			[Token(Token = "0x4000A84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20D")]
			private bool hasNeck;

			[Token(Token = "0x4000A85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20E")]
			private bool hasLegs;

			[Token(Token = "0x4000A86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private float headHeight;

			[Token(Token = "0x4000A87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float sizeMlp;

			[Token(Token = "0x4000A88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private Vector3 chestForward;

			[Token(Token = "0x170000FF")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000A1A")]
				[Address(RVA = "0x11D4530", Offset = "0x11D4530", VA = "0x11D4530")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000100")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000A1B")]
				[Address(RVA = "0x11E2D10", Offset = "0x11E2D10", VA = "0x11E2D10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000101")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000A1C")]
				[Address(RVA = "0x11D9FD8", Offset = "0x11D9FD8", VA = "0x11D9FD8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000102")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000A1D")]
				[Address(RVA = "0x11E2D60", Offset = "0x11E2D60", VA = "0x11E2D60")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000103")]
			public VirtualBone head
			{
				[Token(Token = "0x6000A1E")]
				[Address(RVA = "0x11E2740", Offset = "0x11E2740", VA = "0x11E2740")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000104")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000A1F")]
				[Address(RVA = "0x11E2DB0", Offset = "0x11E2DB0", VA = "0x11E2DB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664274", Offset = "0x664274")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000A20")]
				[Address(RVA = "0x11E2DC4", Offset = "0x11E2DC4", VA = "0x11E2DC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664284", Offset = "0x664284")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x11E2DD8", Offset = "0x11E2DD8", VA = "0x11E2DD8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x11E3C2C", Offset = "0x11E3C2C", VA = "0x11E3C2C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x11E3E8C", Offset = "0x11E3E8C", VA = "0x11E3E8C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x11E444C", Offset = "0x11E444C", VA = "0x11E444C")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x11D7450", Offset = "0x11D7450", VA = "0x11D7450")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x11E4E4C", Offset = "0x11E4E4C", VA = "0x11E4E4C")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x11E55F0", Offset = "0x11E55F0", VA = "0x11E55F0")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x11E5FE0", Offset = "0x11E5FE0", VA = "0x11E5FE0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x11E635C", Offset = "0x11E635C", VA = "0x11E635C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x11E4680", Offset = "0x11E4680", VA = "0x11E4680")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x11D9610", Offset = "0x11D9610", VA = "0x11D9610")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x11E4A38", Offset = "0x11E4A38", VA = "0x11E4A38")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x11E6454", Offset = "0x11E6454", VA = "0x11E6454")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x11E5350", Offset = "0x11E5350", VA = "0x11E5350")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x11E505C", Offset = "0x11E505C", VA = "0x11E505C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x11DBDA0", Offset = "0x11DBDA0", VA = "0x11DBDA0")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000174")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000A8A")]
			Pelvis,
			[Token(Token = "0x4000A8B")]
			Chest,
			[Token(Token = "0x4000A8C")]
			Head,
			[Token(Token = "0x4000A8D")]
			LeftHand,
			[Token(Token = "0x4000A8E")]
			RightHand,
			[Token(Token = "0x4000A8F")]
			LeftFoot,
			[Token(Token = "0x4000A90")]
			RightFoot,
			[Token(Token = "0x4000A91")]
			LeftHeel,
			[Token(Token = "0x4000A92")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000175")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000A94")]
			Pelvis,
			[Token(Token = "0x4000A95")]
			Chest,
			[Token(Token = "0x4000A96")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000176")]
		public class VirtualBone
		{
			[Token(Token = "0x4000A97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000A98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000A99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000A9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000A9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000A9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000A9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x11D6E7C", Offset = "0x11D6E7C", VA = "0x11D6E7C")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x11D6F00", Offset = "0x11D6F00", VA = "0x11D6F00")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x11E6804", Offset = "0x11E6804", VA = "0x11E6804")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x11DEFB4", Offset = "0x11DEFB4", VA = "0x11DEFB4")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x11DF78C", Offset = "0x11DF78C", VA = "0x11DF78C")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x11E6B40", Offset = "0x11E6B40", VA = "0x11E6B40")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x11DD778", Offset = "0x11DD778", VA = "0x11DD778")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x11E6E48", Offset = "0x11E6E48", VA = "0x11E6E48")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x11DE0B4", Offset = "0x11DE0B4", VA = "0x11DE0B4")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x11E6F48", Offset = "0x11E6F48", VA = "0x11E6F48")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x11E5980", Offset = "0x11E5980", VA = "0x11E5980")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x11E7160", Offset = "0x11E7160", VA = "0x11E7160")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x11E7268", Offset = "0x11E7268", VA = "0x11E7268")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A6E8", Offset = "0x65A6E8")]
		public bool plantFeet;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65A720", Offset = "0x65A720")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A730", Offset = "0x65A730")]
		public Spine spine;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A768", Offset = "0x65A768")]
		public Arm leftArm;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A7A0", Offset = "0x65A7A0")]
		public Arm rightArm;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A7D8", Offset = "0x65A7D8")]
		public Leg leftLeg;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A810", Offset = "0x65A810")]
		public Leg rightLeg;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A848", Offset = "0x65A848")]
		public Locomotion locomotion;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x1700006E")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x11D4168", Offset = "0x11D4168", VA = "0x11D4168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662AA0", Offset = "0x662AA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x11D6EF8", Offset = "0x11D6EF8", VA = "0x11D6EF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662AB0", Offset = "0x662AB0")]
			private set
			{
			}
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x11D19D0", Offset = "0x11D19D0", VA = "0x11D19D0")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x11D1F50", Offset = "0x11D1F50", VA = "0x11D1F50")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x11D1D6C", Offset = "0x11D1D6C", VA = "0x11D1D6C")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x11D2B54", Offset = "0x11D2B54", VA = "0x11D2B54")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x11D2CF0", Offset = "0x11D2CF0", VA = "0x11D2CF0")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x11D2D94", Offset = "0x11D2D94", VA = "0x11D2D94")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x11D2F3C", Offset = "0x11D2F3C", VA = "0x11D2F3C")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x11D3690", Offset = "0x11D3690", VA = "0x11D3690")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x11D4580", Offset = "0x11D4580", VA = "0x11D4580", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x11D47B4", Offset = "0x11D47B4", VA = "0x11D47B4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x11D4A20", Offset = "0x11D4A20", VA = "0x11D4A20", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x11D4A94", Offset = "0x11D4A94", VA = "0x11D4A94", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x11D4B08", Offset = "0x11D4B08", VA = "0x11D4B08", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x11D4D38", Offset = "0x11D4D38", VA = "0x11D4D38")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x11D2310", Offset = "0x11D2310", VA = "0x11D2310")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x11D2500", Offset = "0x11D2500", VA = "0x11D2500")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x11D29DC", Offset = "0x11D29DC", VA = "0x11D29DC")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x11D384C", Offset = "0x11D384C", VA = "0x11D384C")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x11D507C", Offset = "0x11D507C", VA = "0x11D507C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x11D50C4", Offset = "0x11D50C4", VA = "0x11D50C4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x11D69CC", Offset = "0x11D69CC", VA = "0x11D69CC")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x11D3A70", Offset = "0x11D3A70", VA = "0x11D3A70")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x11D5140", Offset = "0x11D5140", VA = "0x11D5140")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x11D6DC8", Offset = "0x11D6DC8", VA = "0x11D6DC8")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x11D6E24", Offset = "0x11D6E24", VA = "0x11D6E24")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x11D67F0", Offset = "0x11D67F0", VA = "0x11D67F0")]
		private void Write()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x11DB4F8", Offset = "0x11DB4F8", VA = "0x11DB4F8")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x11DBBF8", Offset = "0x11DBBF8", VA = "0x11DBBF8")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A880", Offset = "0x65A880")]
		public Transform parent;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A8B8", Offset = "0x65A8B8")]
		public Transform child;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A8F0", Offset = "0x65A8F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A8F0", Offset = "0x65A8F0")]
		public float weight;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A944", Offset = "0x65A944")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A944", Offset = "0x65A944")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A998", Offset = "0x65A998")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A998", Offset = "0x65A998")]
		public float twistAngleOffset;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xE34C7C", Offset = "0xE34C7C", VA = "0xE34C7C")]
		public void Relax()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xE350C0", Offset = "0xE350C0", VA = "0xE350C0")]
		private void Start()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xE35634", Offset = "0xE35634", VA = "0xE35634")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xE356BC", Offset = "0xE356BC", VA = "0xE356BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xE35744", Offset = "0xE35744", VA = "0xE35744")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xE358B0", Offset = "0xE358B0", VA = "0xE358B0")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B8")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65A9F4", Offset = "0x65A9F4")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65AA04", Offset = "0x65AA04")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65AA14", Offset = "0x65AA14")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x1700006F")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x11E7B6C", Offset = "0x11E7B6C", VA = "0x11E7B6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662AC0", Offset = "0x662AC0")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x11E7B74", Offset = "0x11E7B74", VA = "0x11E7B74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662AD0", Offset = "0x662AD0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public bool isPaused
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x11E7B7C", Offset = "0x11E7B7C", VA = "0x11E7B7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662AE0", Offset = "0x662AE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x11E7B84", Offset = "0x11E7B84", VA = "0x11E7B84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662AF0", Offset = "0x662AF0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x11E7B90", Offset = "0x11E7B90", VA = "0x11E7B90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662B00", Offset = "0x662B00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x11E7B98", Offset = "0x11E7B98", VA = "0x11E7B98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662B10", Offset = "0x662B10")]
			private set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public bool inInteraction
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x11E7BA0", Offset = "0x11E7BA0", VA = "0x11E7BA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000073")]
		public float progress
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x11EABD0", Offset = "0x11EABD0", VA = "0x11EABD0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x11E7C10", Offset = "0x11E7C10", VA = "0x11E7C10")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x11E7C94", Offset = "0x11E7C94", VA = "0x11E7C94")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x11E7D70", Offset = "0x11E7D70", VA = "0x11E7D70")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x11E7FD4", Offset = "0x11E7FD4", VA = "0x11E7FD4")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x11E857C", Offset = "0x11E857C", VA = "0x11E857C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x11E873C", Offset = "0x11E873C", VA = "0x11E873C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x11E87CC", Offset = "0x11E87CC", VA = "0x11E87CC")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x11E8FDC", Offset = "0x11E8FDC", VA = "0x11E8FDC")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x11E9F60", Offset = "0x11E9F60", VA = "0x11E9F60")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x11EA42C", Offset = "0x11EA42C", VA = "0x11EA42C")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x11EAA28", Offset = "0x11EAA28", VA = "0x11EAA28")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x11EAC9C", Offset = "0x11EAC9C", VA = "0x11EAC9C")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AA24", Offset = "0x65AA24")]
		public LookAtIK ik;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AA5C", Offset = "0x65AA5C")]
		public float lerpSpeed;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AA94", Offset = "0x65AA94")]
		public float weightSpeed;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x11EB004", Offset = "0x11EB004", VA = "0x11EB004")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x11EB210", Offset = "0x11EB210", VA = "0x11EB210")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x11EB2D8", Offset = "0x11EB2D8", VA = "0x11EB2D8")]
		public void Update()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x11EB594", Offset = "0x11EB594", VA = "0x11EB594")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x11EB728", Offset = "0x11EB728", VA = "0x11EB728")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x11EB84C", Offset = "0x11EB84C", VA = "0x11EB84C")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x655AC0", Offset = "0x655AC0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655AC0", Offset = "0x655AC0")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000177")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000A9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F0E8", Offset = "0x65F0E8")]
			public float time;

			[Token(Token = "0x4000A9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F120", Offset = "0x65F120")]
			public bool pause;

			[Token(Token = "0x4000AA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F158", Offset = "0x65F158")]
			public bool pickUp;

			[Token(Token = "0x4000AA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F190", Offset = "0x65F190")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000AA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F1C8", Offset = "0x65F1C8")]
			public Message[] messages;

			[Token(Token = "0x4000AA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F200", Offset = "0x65F200")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0xE21140", Offset = "0xE21140", VA = "0xE21140")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0xE21358", Offset = "0xE21358", VA = "0xE21358")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000178")]
		public class Message
		{
			[Token(Token = "0x4000AA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F238", Offset = "0x65F238")]
			public string function;

			[Token(Token = "0x4000AA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F270", Offset = "0x65F270")]
			public GameObject recipient;

			[Token(Token = "0x4000AA6")]
			private const string empty = "";

			[Token(Token = "0x6000A40")]
			[Address(RVA = "0xE2125C", Offset = "0xE2125C", VA = "0xE2125C")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000A41")]
			[Address(RVA = "0xE21360", Offset = "0xE21360", VA = "0xE21360")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000179")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000AA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F2A8", Offset = "0x65F2A8")]
			public Animator animator;

			[Token(Token = "0x4000AA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F2E0", Offset = "0x65F2E0")]
			public Animation animation;

			[Token(Token = "0x4000AA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F318", Offset = "0x65F318")]
			public string animationState;

			[Token(Token = "0x4000AAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F350", Offset = "0x65F350")]
			public float crossfadeTime;

			[Token(Token = "0x4000AAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F388", Offset = "0x65F388")]
			public int layer;

			[Token(Token = "0x4000AAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F3C0", Offset = "0x65F3C0")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000AAD")]
			private const string empty = "";

			[Token(Token = "0x6000A42")]
			[Address(RVA = "0xE20E1C", Offset = "0xE20E1C", VA = "0xE20E1C")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000A43")]
			[Address(RVA = "0xE20F18", Offset = "0xE20F18", VA = "0xE20F18")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000A44")]
			[Address(RVA = "0xE21000", Offset = "0xE21000", VA = "0xE21000")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000A45")]
			[Address(RVA = "0xE2112C", Offset = "0xE2112C", VA = "0xE2112C")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200017A")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20001C6")]
			public enum Type
			{
				[Token(Token = "0x4000C3D")]
				PositionWeight,
				[Token(Token = "0x4000C3E")]
				RotationWeight,
				[Token(Token = "0x4000C3F")]
				PositionOffsetX,
				[Token(Token = "0x4000C40")]
				PositionOffsetY,
				[Token(Token = "0x4000C41")]
				PositionOffsetZ,
				[Token(Token = "0x4000C42")]
				Pull,
				[Token(Token = "0x4000C43")]
				Reach,
				[Token(Token = "0x4000C44")]
				RotateBoneWeight,
				[Token(Token = "0x4000C45")]
				Push,
				[Token(Token = "0x4000C46")]
				PushParent,
				[Token(Token = "0x4000C47")]
				PoserWeight
			}

			[Token(Token = "0x4000AAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F3F8", Offset = "0x65F3F8")]
			public Type type;

			[Token(Token = "0x4000AAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F430", Offset = "0x65F430")]
			public AnimationCurve curve;

			[Token(Token = "0x6000A46")]
			[Address(RVA = "0xE213B4", Offset = "0xE213B4", VA = "0xE213B4")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000A47")]
			[Address(RVA = "0xE21404", Offset = "0xE21404", VA = "0xE21404")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200017B")]
		public class Multiplier
		{
			[Token(Token = "0x4000AB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F468", Offset = "0x65F468")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000AB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F4A0", Offset = "0x65F4A0")]
			public float multiplier;

			[Token(Token = "0x4000AB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F4D8", Offset = "0x65F4D8")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000A48")]
			[Address(RVA = "0xE21368", Offset = "0xE21368", VA = "0xE21368")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000A49")]
			[Address(RVA = "0xE213F4", Offset = "0xE213F4", VA = "0xE213F4")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AADC", Offset = "0x65AADC")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AB14", Offset = "0x65AB14")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AB4C", Offset = "0x65AB4C")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65AB84", Offset = "0x65AB84")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65AB94", Offset = "0x65AB94")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000074")]
		public float length
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x11E8FD4", Offset = "0x11E8FD4", VA = "0x11E8FD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662C70", Offset = "0x662C70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x11EBA28", Offset = "0x11EBA28", VA = "0x11EBA28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662C80", Offset = "0x662C80")]
			private set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x11EBA30", Offset = "0x11EBA30", VA = "0x11EBA30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662C90", Offset = "0x662C90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x11EBA38", Offset = "0x11EBA38", VA = "0x11EBA38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662CA0", Offset = "0x662CA0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x11EBD50", Offset = "0x11EBD50", VA = "0x11EBD50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x11EAC0C", Offset = "0x11EAC0C", VA = "0x11EAC0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x11EB860", Offset = "0x11EB860", VA = "0x11EB860")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662B20", Offset = "0x662B20")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x11EB8AC", Offset = "0x11EB8AC", VA = "0x11EB8AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662B58", Offset = "0x662B58")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x11EB8F8", Offset = "0x11EB8F8", VA = "0x11EB8F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662B90", Offset = "0x662B90")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x11EB944", Offset = "0x11EB944", VA = "0x11EB944")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662BC8", Offset = "0x662BC8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x11EB990", Offset = "0x11EB990", VA = "0x11EB990")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662C00", Offset = "0x662C00")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x11EB9DC", Offset = "0x11EB9DC", VA = "0x11EB9DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662C38", Offset = "0x662C38")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x11EBA40", Offset = "0x11EBA40", VA = "0x11EBA40")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x11EBDE0", Offset = "0x11EBDE0", VA = "0x11EBDE0")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x11E8ED4", Offset = "0x11E8ED4", VA = "0x11E8ED4")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x11EBFAC", Offset = "0x11EBFAC", VA = "0x11EBFAC")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x11E8CF4", Offset = "0x11E8CF4", VA = "0x11E8CF4")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x11E8ECC", Offset = "0x11E8ECC", VA = "0x11E8ECC")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x11E98E0", Offset = "0x11E98E0", VA = "0x11E98E0")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x11EA6F0", Offset = "0x11EA6F0", VA = "0x11EA6F0")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x11EC90C", Offset = "0x11EC90C", VA = "0x11EC90C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x11EC0A8", Offset = "0x11EC0A8", VA = "0x11EC0A8")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x11EBFB4", Offset = "0x11EBFB4", VA = "0x11EBFB4")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x11EC85C", Offset = "0x11EC85C", VA = "0x11EC85C")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x11EC910", Offset = "0x11EC910", VA = "0x11EC910")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x11EC9C0", Offset = "0x11EC9C0", VA = "0x11EC9C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662CB0", Offset = "0x662CB0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x11ECA0C", Offset = "0x11ECA0C", VA = "0x11ECA0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662CE8", Offset = "0x662CE8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x11ECA58", Offset = "0x11ECA58", VA = "0x11ECA58")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x655B20", Offset = "0x655B20")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655B20", Offset = "0x655B20")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200017C")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200017D")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65ABA4", Offset = "0x65ABA4")]
		public string targetTag;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65ABDC", Offset = "0x65ABDC")]
		public float fadeInTime;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AC14", Offset = "0x65AC14")]
		public float speed;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AC4C", Offset = "0x65AC4C")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x65AC84", Offset = "0x65AC84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AC84", Offset = "0x65AC84")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x65AC84", Offset = "0x65AC84")]
		public Collider characterCollider;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AD08", Offset = "0x65AD08")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x65AD08", Offset = "0x65AD08")]
		public Transform FPSCamera;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AD68", Offset = "0x65AD68")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65ADA0", Offset = "0x65ADA0")]
		public float camRaycastDistance;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65ADD8", Offset = "0x65ADD8")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x65ADE8", Offset = "0x65ADE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65ADE8", Offset = "0x65ADE8")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AE48", Offset = "0x65AE48")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000078")]
		public bool inInteraction
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xE215D4", Offset = "0xE215D4", VA = "0xE215D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000079")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xE24098", Offset = "0xE24098", VA = "0xE24098")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xE240A0", Offset = "0xE240A0", VA = "0xE240A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xE22B48", Offset = "0xE22B48", VA = "0xE22B48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662E70", Offset = "0x662E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xE240A8", Offset = "0xE240A8", VA = "0xE240A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x662E80", Offset = "0x662E80")]
			private set
			{
			}
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xE2140C", Offset = "0xE2140C", VA = "0xE2140C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662D20", Offset = "0x662D20")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xE21458", Offset = "0xE21458", VA = "0xE21458")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662D58", Offset = "0x662D58")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xE214A4", Offset = "0xE214A4", VA = "0xE214A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662D90", Offset = "0x662D90")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xE214F0", Offset = "0xE214F0", VA = "0xE214F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662DC8", Offset = "0x662DC8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xE2153C", Offset = "0xE2153C", VA = "0xE2153C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662E00", Offset = "0x662E00")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xE21588", Offset = "0xE21588", VA = "0xE21588")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662E38", Offset = "0x662E38")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xE217BC", Offset = "0xE217BC", VA = "0xE217BC")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xE21928", Offset = "0xE21928", VA = "0xE21928")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xE21A98", Offset = "0xE21A98", VA = "0xE21A98")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xE21BA0", Offset = "0xE21BA0", VA = "0xE21BA0")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xE21D34", Offset = "0xE21D34", VA = "0xE21D34")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xE21EE4", Offset = "0xE21EE4", VA = "0xE21EE4")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xE22000", Offset = "0xE22000", VA = "0xE22000")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xE2211C", Offset = "0xE2211C", VA = "0xE2211C")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xE22238", Offset = "0xE22238", VA = "0xE22238")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xE222E0", Offset = "0xE222E0", VA = "0xE222E0")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xE22388", Offset = "0xE22388", VA = "0xE22388")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xE22424", Offset = "0xE22424", VA = "0xE22424")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xE22540", Offset = "0xE22540", VA = "0xE22540")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xE2265C", Offset = "0xE2265C", VA = "0xE2265C")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xE22778", Offset = "0xE22778", VA = "0xE22778")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xE22B50", Offset = "0xE22B50", VA = "0xE22B50")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xE22E00", Offset = "0xE22E00", VA = "0xE22E00")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xE231C4", Offset = "0xE231C4", VA = "0xE231C4")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xE23568", Offset = "0xE23568", VA = "0xE23568")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xE235C4", Offset = "0xE235C4", VA = "0xE235C4")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xE236C0", Offset = "0xE236C0", VA = "0xE236C0")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xE23838", Offset = "0xE23838", VA = "0xE23838")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xE239F4", Offset = "0xE239F4", VA = "0xE239F4")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xE23E8C", Offset = "0xE23E8C", VA = "0xE23E8C")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xE232FC", Offset = "0xE232FC", VA = "0xE232FC")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xE240B0", Offset = "0xE240B0", VA = "0xE240B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xE24A28", Offset = "0xE24A28", VA = "0xE24A28")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xE24A58", Offset = "0xE24A58", VA = "0xE24A58")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xE24A84", Offset = "0xE24A84", VA = "0xE24A84")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xE24AB0", Offset = "0xE24AB0", VA = "0xE24AB0")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xE24B48", Offset = "0xE24B48", VA = "0xE24B48")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xE24C80", Offset = "0xE24C80", VA = "0xE24C80")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xE24D8C", Offset = "0xE24D8C", VA = "0xE24D8C")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xE25158", Offset = "0xE25158", VA = "0xE25158")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xE25244", Offset = "0xE25244", VA = "0xE25244")]
		private void Update()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xE25510", Offset = "0xE25510", VA = "0xE25510")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xE24768", Offset = "0xE24768", VA = "0xE24768")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xE25664", Offset = "0xE25664", VA = "0xE25664")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xE25800", Offset = "0xE25800", VA = "0xE25800")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xE258B4", Offset = "0xE258B4", VA = "0xE258B4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xE259E4", Offset = "0xE259E4", VA = "0xE259E4")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xE25A14", Offset = "0xE25A14", VA = "0xE25A14")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xE216DC", Offset = "0xE216DC", VA = "0xE216DC")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xE22A1C", Offset = "0xE22A1C", VA = "0xE22A1C")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xE25F7C", Offset = "0xE25F7C", VA = "0xE25F7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662E90", Offset = "0x662E90")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xE25FC8", Offset = "0xE25FC8", VA = "0xE25FC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662EC8", Offset = "0x662EC8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xE26014", Offset = "0xE26014", VA = "0xE26014")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x655B80", Offset = "0x655B80")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655B80", Offset = "0x655B80")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200017E")]
		public class Multiplier
		{
			[Token(Token = "0x4000AB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F510", Offset = "0x65F510")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000AB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F548", Offset = "0x65F548")]
			public float multiplier;

			[Token(Token = "0x6000A52")]
			[Address(RVA = "0xE27B50", Offset = "0xE27B50", VA = "0xE27B50")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AE80", Offset = "0x65AE80")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AEB8", Offset = "0x65AEB8")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AEF0", Offset = "0x65AEF0")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AF28", Offset = "0x65AF28")]
		public Transform pivot;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AF60", Offset = "0x65AF60")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AF98", Offset = "0x65AF98")]
		public float twistWeight;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65AFD0", Offset = "0x65AFD0")]
		public float swingWeight;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B008", Offset = "0x65B008")]
		public bool rotateOnce;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xE26EFC", Offset = "0xE26EFC", VA = "0xE26EFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662F00", Offset = "0x662F00")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xE26F48", Offset = "0xE26F48", VA = "0xE26F48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662F38", Offset = "0x662F38")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xE26F94", Offset = "0xE26F94", VA = "0xE26F94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662F70", Offset = "0x662F70")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xE26FE0", Offset = "0xE26FE0", VA = "0xE26FE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662FA8", Offset = "0x662FA8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xE2702C", Offset = "0xE2702C", VA = "0xE2702C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x662FE0", Offset = "0x662FE0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xE27078", Offset = "0xE27078", VA = "0xE27078")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x663018", Offset = "0x663018")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xE270C4", Offset = "0xE270C4", VA = "0xE270C4")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xE271C4", Offset = "0xE271C4", VA = "0xE271C4")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xE27290", Offset = "0xE27290", VA = "0xE27290")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xE27A2C", Offset = "0xE27A2C", VA = "0xE27A2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x663050", Offset = "0x663050")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xE27A78", Offset = "0xE27A78", VA = "0xE27A78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x663088", Offset = "0x663088")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xE27AC4", Offset = "0xE27AC4", VA = "0xE27AC4")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x655BE0", Offset = "0x655BE0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655BE0", Offset = "0x655BE0")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200017F")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000AB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F580", Offset = "0x65F580")]
			public bool use;

			[Token(Token = "0x4000AB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F5B8", Offset = "0x65F5B8")]
			public Vector2 offset;

			[Token(Token = "0x4000AB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F5F0", Offset = "0x65F5F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65F5F0", Offset = "0x65F5F0")]
			public float angleOffset;

			[Token(Token = "0x4000AB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F64C", Offset = "0x65F64C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65F64C", Offset = "0x65F64C")]
			public float maxAngle;

			[Token(Token = "0x4000AB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F6A4", Offset = "0x65F6A4")]
			public float radius;

			[Token(Token = "0x4000ABA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F6DC", Offset = "0x65F6DC")]
			public bool orbit;

			[Token(Token = "0x4000ABB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F714", Offset = "0x65F714")]
			public bool fixYAxis;

			[Token(Token = "0x17000105")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000A53")]
				[Address(RVA = "0xE28324", Offset = "0xE28324", VA = "0xE28324")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000106")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000A54")]
				[Address(RVA = "0xE28360", Offset = "0xE28360", VA = "0xE28360")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000A55")]
			[Address(RVA = "0xE28458", Offset = "0xE28458", VA = "0xE28458")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A56")]
			[Address(RVA = "0xE28B2C", Offset = "0xE28B2C", VA = "0xE28B2C")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000180")]
		public class CameraPosition
		{
			[Token(Token = "0x4000ABC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F74C", Offset = "0x65F74C")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000ABD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F784", Offset = "0x65F784")]
			public Vector3 direction;

			[Token(Token = "0x4000ABE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F7BC", Offset = "0x65F7BC")]
			public float maxDistance;

			[Token(Token = "0x4000ABF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F7F4", Offset = "0x65F7F4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65F7F4", Offset = "0x65F7F4")]
			public float maxAngle;

			[Token(Token = "0x4000AC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F84C", Offset = "0x65F84C")]
			public bool fixYAxis;

			[Token(Token = "0x6000A57")]
			[Address(RVA = "0xE27DE0", Offset = "0xE27DE0", VA = "0xE27DE0")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000A58")]
			[Address(RVA = "0xE27FB4", Offset = "0xE27FB4", VA = "0xE27FB4")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A59")]
			[Address(RVA = "0xE28298", Offset = "0xE28298", VA = "0xE28298")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000181")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20001C7")]
			public class Interaction
			{
				[Token(Token = "0x4000C48")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660CA8", Offset = "0x660CA8")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000C49")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660CE0", Offset = "0x660CE0")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000B1F")]
				[Address(RVA = "0xE28B50", Offset = "0xE28B50", VA = "0xE28B50")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000AC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000AC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x4000AC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F8F4", Offset = "0x65F8F4")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000AC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F92C", Offset = "0x65F92C")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000AC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F964", Offset = "0x65F964")]
			public Interaction[] interactions;

			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0xE27C40", Offset = "0xE27C40", VA = "0xE27C40")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0xE28B40", Offset = "0xE28B40", VA = "0xE28B40")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B040", Offset = "0x65B040")]
		public Range[] ranges;

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xE27B58", Offset = "0xE27B58", VA = "0xE27B58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6630C0", Offset = "0x6630C0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xE27BA4", Offset = "0xE27BA4", VA = "0xE27BA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6630F8", Offset = "0x6630F8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xE27BF0", Offset = "0xE27BF0", VA = "0xE27BF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x663130", Offset = "0x663130")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xE27C3C", Offset = "0xE27C3C", VA = "0xE27C3C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xE24F70", Offset = "0xE24F70", VA = "0xE24F70")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xE27D80", Offset = "0xE27D80", VA = "0xE27D80")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x2000182")]
		public class Map
		{
			[Token(Token = "0x4000AC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000AC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000AC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000AC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0xF42868", Offset = "0xF42868", VA = "0xF42868")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0xF42DB0", Offset = "0xF42DB0", VA = "0xF42DB0")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0xF42D24", Offset = "0xF42D24", VA = "0xF42D24")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0xF42A78", Offset = "0xF42A78", VA = "0xF42A78")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xF424D8", Offset = "0xF424D8", VA = "0xF424D8", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x663168", Offset = "0x663168")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xF4293C", Offset = "0xF4293C", VA = "0xF4293C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xF42940", Offset = "0xF42940", VA = "0xF42940", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xF42C8C", Offset = "0xF42C8C", VA = "0xF42C8C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xF428A4", Offset = "0xF428A4", VA = "0xF428A4")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xF427A0", Offset = "0xF427A0", VA = "0xF427A0")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xF42E14", Offset = "0xF42E14", VA = "0xF42E14")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xF4F384", Offset = "0xF4F384", VA = "0xF4F384", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xF4F440", Offset = "0xF4F440", VA = "0xF4F440", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xF4F6A0", Offset = "0xF4F6A0", VA = "0xF4F6A0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xF4F830", Offset = "0xF4F830", VA = "0xF4F830", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xF4F49C", Offset = "0xF4F49C", VA = "0xF4F49C")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xF4FD54", Offset = "0xF4FD54", VA = "0xF4FD54")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65B078", Offset = "0x65B078")]
		public float weight;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65B090", Offset = "0x65B090")]
		public float localRotationWeight;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65B0A8", Offset = "0x65B0A8")]
		public float localPositionWeight;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000622")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xE2BE98", Offset = "0xE2BE98", VA = "0xE2BE98")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000624")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000625")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000626")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xE2BEA4", Offset = "0xE2BEA4", VA = "0xE2BEA4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xE2BEF8", Offset = "0xE2BEF8", VA = "0xE2BEF8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xE2BF34", Offset = "0xE2BF34", VA = "0xE2BF34", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xE2BF4C", Offset = "0xE2BF4C", VA = "0xE2BF4C")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x655C40", Offset = "0x655C40")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x2000183")]
		public class Rigidbone
		{
			[Token(Token = "0x4000ACA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000ACB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x4000ACC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x4000ACD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000ACE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000ACF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000AD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000AD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000AD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000AD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000AD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000A60")]
			[Address(RVA = "0xE2C63C", Offset = "0xE2C63C", VA = "0xE2C63C")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0xE2D650", Offset = "0xE2D650", VA = "0xE2D650")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000A62")]
			[Address(RVA = "0xE2D398", Offset = "0xE2D398", VA = "0xE2D398")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x2000184")]
		public class Child
		{
			[Token(Token = "0x4000AD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000AD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000AD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000A63")]
			[Address(RVA = "0xE2C7D4", Offset = "0xE2C7D4", VA = "0xE2C7D4")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000A64")]
			[Address(RVA = "0xE2D828", Offset = "0xE2D828", VA = "0xE2D828")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000A65")]
			[Address(RVA = "0xE2D7C4", Offset = "0xE2D7C4", VA = "0xE2D7C4")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x2000185")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6576BC", Offset = "0x6576BC")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000ADA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000107")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A69")]
				[Address(RVA = "0xE2DFC0", Offset = "0xE2DFC0", VA = "0xE2DFC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000108")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A6B")]
				[Address(RVA = "0xE2E030", Offset = "0xE2E030", VA = "0xE2E030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A66")]
			[Address(RVA = "0xE2C844", Offset = "0xE2C844", VA = "0xE2C844")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000A67")]
			[Address(RVA = "0xE2DC98", Offset = "0xE2DC98", VA = "0xE2DC98", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A68")]
			[Address(RVA = "0xE2DC9C", Offset = "0xE2DC9C", VA = "0xE2DC9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0xE2DFC8", Offset = "0xE2DFC8", VA = "0xE2DFC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B0C0", Offset = "0x65B0C0")]
		public IK ik;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B0F8", Offset = "0x65B0F8")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B130", Offset = "0x65B130")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B168", Offset = "0x65B168")]
		public float applyVelocity;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B1A0", Offset = "0x65B1A0")]
		public float applyAngularVelocity;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700007B")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0xE2BFAC", Offset = "0xE2BFAC", VA = "0xE2BFAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		private bool ikUsed
		{
			[Token(Token = "0x6000638")]
			[Address(RVA = "0xE2CDAC", Offset = "0xE2CDAC", VA = "0xE2CDAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xE2BF74", Offset = "0xE2BF74", VA = "0xE2BF74")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xE2C04C", Offset = "0xE2C04C", VA = "0xE2C04C")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xE2C198", Offset = "0xE2C198", VA = "0xE2C198")]
		public void Start()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xE2C124", Offset = "0xE2C124", VA = "0xE2C124")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6631A0", Offset = "0x6631A0")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xE2C870", Offset = "0xE2C870", VA = "0xE2C870")]
		private void Update()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xE2CC0C", Offset = "0xE2CC0C", VA = "0xE2CC0C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xE2CCDC", Offset = "0xE2CCDC", VA = "0xE2CCDC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xE2CF70", Offset = "0xE2CF70", VA = "0xE2CF70")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xE2CD70", Offset = "0xE2CD70", VA = "0xE2CD70")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xE2CF2C", Offset = "0xE2CF2C", VA = "0xE2CF2C")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xE2D024", Offset = "0xE2D024", VA = "0xE2D024")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xE2CFA4", Offset = "0xE2CFA4", VA = "0xE2CFA4")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xE2C0A4", Offset = "0xE2C0A4", VA = "0xE2C0A4")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xE2CC4C", Offset = "0xE2CC4C", VA = "0xE2CC4C")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xE2DA60", Offset = "0xE2DA60", VA = "0xE2DA60")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xE2DBCC", Offset = "0xE2DBCC", VA = "0xE2DBCC")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x1700007D")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0xE2FE0C", Offset = "0xE2FE0C", VA = "0xE2FE0C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007E")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0xE2FE48", Offset = "0xE2FE48", VA = "0xE2FE48")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xE2FA48", Offset = "0xE2FA48", VA = "0xE2FA48")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xE2FA94", Offset = "0xE2FA94", VA = "0xE2FA94")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xE2FD24", Offset = "0xE2FD24", VA = "0xE2FD24")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xE2FDD4", Offset = "0xE2FDD4", VA = "0xE2FDD4")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000643")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xE2FC34", Offset = "0xE2FC34", VA = "0xE2FC34")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xE2FF18", Offset = "0xE2FF18", VA = "0xE2FF18")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xE2FF1C", Offset = "0xE2FF1C", VA = "0xE2FF1C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xE2FF4C", Offset = "0xE2FF4C", VA = "0xE2FF4C")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xE30030", Offset = "0xE30030", VA = "0xE30030")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xE302B0", Offset = "0xE302B0", VA = "0xE302B0")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xE3036C", Offset = "0xE3036C", VA = "0xE3036C")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x655CA4", Offset = "0x655CA4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655CA4", Offset = "0x655CA4")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65B1E8", Offset = "0x65B1E8")]
		public float limit;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65B204", Offset = "0x65B204")]
		public float twistLimit;

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xE303E4", Offset = "0xE303E4", VA = "0xE303E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x663204", Offset = "0x663204")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xE30430", Offset = "0xE30430", VA = "0xE30430")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x66323C", Offset = "0x66323C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xE3047C", Offset = "0xE3047C", VA = "0xE3047C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x663274", Offset = "0x663274")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xE304C8", Offset = "0xE304C8", VA = "0xE304C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6632AC", Offset = "0x6632AC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xE30514", Offset = "0xE30514", VA = "0xE30514", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xE305CC", Offset = "0xE305CC", VA = "0xE305CC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xE30814", Offset = "0xE30814", VA = "0xE30814")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x655D04", Offset = "0x655D04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655D04", Offset = "0x655D04")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xE30824", Offset = "0xE30824", VA = "0xE30824")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6632E4", Offset = "0x6632E4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xE30870", Offset = "0xE30870", VA = "0xE30870")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x66331C", Offset = "0x66331C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xE308BC", Offset = "0xE308BC", VA = "0xE308BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x663354", Offset = "0x663354")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xE30908", Offset = "0xE30908", VA = "0xE30908")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x66338C", Offset = "0x66338C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xE30954", Offset = "0xE30954", VA = "0xE30954", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xE3097C", Offset = "0xE3097C", VA = "0xE3097C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xE30C7C", Offset = "0xE30C7C", VA = "0xE30C7C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x655D64", Offset = "0x655D64")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655D64", Offset = "0x655D64")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x2000186")]
		public class ReachCone
		{
			[Token(Token = "0x4000ADB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000ADC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000ADD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000ADE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000109")]
			public Vector3 o
			{
				[Token(Token = "0x6000A6C")]
				[Address(RVA = "0xE33164", Offset = "0xE33164", VA = "0xE33164")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010A")]
			public Vector3 a
			{
				[Token(Token = "0x6000A6D")]
				[Address(RVA = "0xE331AC", Offset = "0xE331AC", VA = "0xE331AC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010B")]
			public Vector3 b
			{
				[Token(Token = "0x6000A6E")]
				[Address(RVA = "0xE331F8", Offset = "0xE331F8", VA = "0xE331F8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010C")]
			public Vector3 c
			{
				[Token(Token = "0x6000A6F")]
				[Address(RVA = "0xE33244", Offset = "0xE33244", VA = "0xE33244")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010D")]
			public bool isValid
			{
				[Token(Token = "0x6000A71")]
				[Address(RVA = "0xE320A0", Offset = "0xE320A0", VA = "0xE320A0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A70")]
			[Address(RVA = "0xE32848", Offset = "0xE32848", VA = "0xE32848")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000A72")]
			[Address(RVA = "0xE329F8", Offset = "0xE329F8", VA = "0xE329F8")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000187")]
		public class LimitPoint
		{
			[Token(Token = "0x4000ADF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000AE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000A73")]
			[Address(RVA = "0xE320B0", Offset = "0xE320B0", VA = "0xE320B0")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65B230", Offset = "0x65B230")]
		public float twistLimit;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65B24C", Offset = "0x65B24C")]
		public int smoothIterations;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xE30D04", Offset = "0xE30D04", VA = "0xE30D04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6633C4", Offset = "0x6633C4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xE30D50", Offset = "0xE30D50", VA = "0xE30D50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6633FC", Offset = "0x6633FC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xE30D9C", Offset = "0xE30D9C", VA = "0xE30D9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x663434", Offset = "0x663434")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xE30DE8", Offset = "0xE30DE8", VA = "0xE30DE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x66346C", Offset = "0x66346C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xE30E34", Offset = "0xE30E34", VA = "0xE30E34")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xE3146C", Offset = "0xE3146C", VA = "0xE3146C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xE31568", Offset = "0xE31568", VA = "0xE31568")]
		private void Start()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xE31C2C", Offset = "0xE31C2C", VA = "0xE31C2C")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xE30ED4", Offset = "0xE30ED4", VA = "0xE30ED4")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xE32134", Offset = "0xE32134", VA = "0xE32134")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xE32BB8", Offset = "0xE32BB8", VA = "0xE32BB8")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xE32BFC", Offset = "0xE32BFC", VA = "0xE32BFC")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xE32D44", Offset = "0xE32D44", VA = "0xE32D44")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xE318C4", Offset = "0xE318C4", VA = "0xE318C4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xE32ED4", Offset = "0xE32ED4", VA = "0xE32ED4")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xE33100", Offset = "0xE33100", VA = "0xE33100")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x655DC4", Offset = "0x655DC4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x655DC4", Offset = "0x655DC4")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65B30C", Offset = "0x65B30C")]
		public float twistLimit;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xE33290", Offset = "0xE33290", VA = "0xE33290")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6634A4", Offset = "0x6634A4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xE332DC", Offset = "0xE332DC", VA = "0xE332DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6634DC", Offset = "0x6634DC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xE33328", Offset = "0xE33328", VA = "0xE33328")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x663514", Offset = "0x663514")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xE33374", Offset = "0xE33374", VA = "0xE33374")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x66354C", Offset = "0x66354C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xE333C0", Offset = "0xE333C0", VA = "0xE333C0")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xE333F8", Offset = "0xE333F8", VA = "0xE333F8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xE334B0", Offset = "0xE334B0", VA = "0xE334B0")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xE337E8", Offset = "0xE337E8", VA = "0xE337E8")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x2000188")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6576CC", Offset = "0x6576CC")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x1700010E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A77")]
				[Address(RVA = "0xB3C8E4", Offset = "0xB3C8E4", VA = "0xB3C8E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A79")]
				[Address(RVA = "0xB3C954", Offset = "0xB3C954", VA = "0xB3C954", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A74")]
			[Address(RVA = "0xB3C670", Offset = "0xB3C670", VA = "0xB3C670")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000A75")]
			[Address(RVA = "0xB3C768", Offset = "0xB3C768", VA = "0xB3C768", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A76")]
			[Address(RVA = "0xB3C76C", Offset = "0xB3C76C", VA = "0xB3C76C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A78")]
			[Address(RVA = "0xB3C8EC", Offset = "0xB3C8EC", VA = "0xB3C8EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B360", Offset = "0x65B360")]
		public AimIK ik;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B398", Offset = "0x65B398")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65B398", Offset = "0x65B398")]
		public float weight;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x65B3EC", Offset = "0x65B3EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B3EC", Offset = "0x65B3EC")]
		public Transform target;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B44C", Offset = "0x65B44C")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B484", Offset = "0x65B484")]
		public float weightSmoothTime;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x65B4BC", Offset = "0x65B4BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B4BC", Offset = "0x65B4BC")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B51C", Offset = "0x65B51C")]
		public float maxRadiansDelta;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B554", Offset = "0x65B554")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B58C", Offset = "0x65B58C")]
		public float slerpSpeed;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B5C4", Offset = "0x65B5C4")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B5FC", Offset = "0x65B5FC")]
		public float minDistance;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B634", Offset = "0x65B634")]
		public Vector3 offset;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x65B66C", Offset = "0x65B66C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B66C", Offset = "0x65B66C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65B66C", Offset = "0x65B66C")]
		public float maxRootAngle;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B6E8", Offset = "0x65B6E8")]
		public bool turnToTarget;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B720", Offset = "0x65B720")]
		public float turnToTargetTime;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x65B758", Offset = "0x65B758")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B758", Offset = "0x65B758")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B7B8", Offset = "0x65B7B8")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x1700007F")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0xB3B5B0", Offset = "0xB3B5B0", VA = "0xB3B5B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xB3B480", Offset = "0xB3B480", VA = "0xB3B480")]
		private void Start()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xB3B728", Offset = "0xB3B728", VA = "0xB3B728")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xB3C02C", Offset = "0xB3C02C", VA = "0xB3C02C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xB3C1F8", Offset = "0xB3C1F8", VA = "0xB3C1F8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xB3C5FC", Offset = "0xB3C5FC", VA = "0xB3C5FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x663584", Offset = "0x663584")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xB3C69C", Offset = "0xB3C69C", VA = "0xB3C69C")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000189")]
		public class Pose
		{
			[Token(Token = "0x4000AE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000AE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000AE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000AE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000AE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000AE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0xF2F3C4", Offset = "0xF2F3C4", VA = "0xF2F3C4")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0xF2F758", Offset = "0xF2F758", VA = "0xF2F758")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0xF2F7C8", Offset = "0xF2F7C8", VA = "0xF2F7C8")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xF2F264", Offset = "0xF2F264", VA = "0xF2F264")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xF2F660", Offset = "0xF2F660", VA = "0xF2F660")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xF2F760", Offset = "0xF2F760", VA = "0xF2F760")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200018A")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001C8")]
			public class EffectorLink
			{
				[Token(Token = "0x4000C4A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660D18", Offset = "0x660D18")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000C4B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660D50", Offset = "0x660D50")]
				public float weight;

				[Token(Token = "0x6000B20")]
				[Address(RVA = "0xF2FEC4", Offset = "0xF2FEC4", VA = "0xF2FEC4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000AEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F99C", Offset = "0x65F99C")]
			public Transform transform;

			[Token(Token = "0x4000AEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65F9D4", Offset = "0x65F9D4")]
			public Transform relativeTo;

			[Token(Token = "0x4000AEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FA0C", Offset = "0x65FA0C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000AED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FA44", Offset = "0x65FA44")]
			public float verticalWeight;

			[Token(Token = "0x4000AEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FA7C", Offset = "0x65FA7C")]
			public float horizontalWeight;

			[Token(Token = "0x4000AEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FAB4", Offset = "0x65FAB4")]
			public float speed;

			[Token(Token = "0x4000AF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000AF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000AF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0xF2F944", Offset = "0xF2F944", VA = "0xF2F944")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0xF2FE9C", Offset = "0xF2FE9C", VA = "0xF2FE9C")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0xF2FEAC", Offset = "0xF2FEAC", VA = "0xF2FEAC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B7F0", Offset = "0x65B7F0")]
		public Body[] bodies;

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xF2F7E4", Offset = "0xF2F7E4", VA = "0xF2F7E4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xF2FE94", Offset = "0xF2FE94", VA = "0xF2FE94")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B828", Offset = "0x65B828")]
		public float tiltSpeed;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B860", Offset = "0x65B860")]
		public float tiltSensitivity;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B898", Offset = "0x65B898")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B8D0", Offset = "0x65B8D0")]
		public OffsetPose poseRight;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xF31C44", Offset = "0xF31C44", VA = "0xF31C44", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xF31C94", Offset = "0xF31C94", VA = "0xF31C94", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xF31F00", Offset = "0xF31F00", VA = "0xF31F00")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200018B")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000AF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FAEC", Offset = "0x65FAEC")]
			public string name;

			[Token(Token = "0x4000AF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FB24", Offset = "0x65FB24")]
			public Collider collider;

			[Token(Token = "0x4000AF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FB5C", Offset = "0x65FB5C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000AF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65FBA8", Offset = "0x65FBA8")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000AF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65FBB8", Offset = "0x65FBB8")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000AF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65FBC8", Offset = "0x65FBC8")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000AF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65FBD8", Offset = "0x65FBD8")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000AFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000AFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000AFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000110")]
			public bool inProgress
			{
				[Token(Token = "0x6000A80")]
				[Address(RVA = "0x1188730", Offset = "0x1188730", VA = "0x1188730")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000111")]
			protected float crossFader
			{
				[Token(Token = "0x6000A81")]
				[Address(RVA = "0x118874C", Offset = "0x118874C", VA = "0x118874C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664334", Offset = "0x664334")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A82")]
				[Address(RVA = "0x1188754", Offset = "0x1188754", VA = "0x1188754")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664344", Offset = "0x664344")]
				private set
				{
				}
			}

			[Token(Token = "0x17000112")]
			protected float timer
			{
				[Token(Token = "0x6000A83")]
				[Address(RVA = "0x1188744", Offset = "0x1188744", VA = "0x1188744")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664354", Offset = "0x664354")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A84")]
				[Address(RVA = "0x118875C", Offset = "0x118875C", VA = "0x118875C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664364", Offset = "0x664364")]
				private set
				{
				}
			}

			[Token(Token = "0x17000113")]
			protected Vector3 force
			{
				[Token(Token = "0x6000A85")]
				[Address(RVA = "0x1188764", Offset = "0x1188764", VA = "0x1188764")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664374", Offset = "0x664374")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A86")]
				[Address(RVA = "0x1188770", Offset = "0x1188770", VA = "0x1188770")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664384", Offset = "0x664384")]
				private set
				{
				}
			}

			[Token(Token = "0x17000114")]
			protected Vector3 point
			{
				[Token(Token = "0x6000A87")]
				[Address(RVA = "0x118877C", Offset = "0x118877C", VA = "0x118877C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664394", Offset = "0x664394")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A88")]
				[Address(RVA = "0x1188788", Offset = "0x1188788", VA = "0x1188788")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6643A4", Offset = "0x6643A4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x1188794", Offset = "0x1188794", VA = "0x1188794")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x11888C0", Offset = "0x11888C0", VA = "0x11888C0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000A8B")]
			protected abstract float GetLength();

			[Token(Token = "0x6000A8C")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000A8D")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x1188A0C", Offset = "0x1188A0C", VA = "0x1188A0C")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018C")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001C9")]
			public class EffectorLink
			{
				[Token(Token = "0x4000C4C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660D88", Offset = "0x660D88")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000C4D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660DC0", Offset = "0x660DC0")]
				public float weight;

				[Token(Token = "0x4000C4E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000C4F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000B21")]
				[Address(RVA = "0x1189560", Offset = "0x1189560", VA = "0x1189560")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000B22")]
				[Address(RVA = "0x11892FC", Offset = "0x11892FC", VA = "0x11892FC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000B23")]
				[Address(RVA = "0x11898CC", Offset = "0x11898CC", VA = "0x11898CC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000AFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FBE8", Offset = "0x65FBE8")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000AFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FC20", Offset = "0x65FC20")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000AFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FC58", Offset = "0x65FC58")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x1189074", Offset = "0x1189074", VA = "0x1189074", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x1189274", Offset = "0x1189274", VA = "0x1189274", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x1189310", Offset = "0x1189310", VA = "0x1189310", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x11896A8", Offset = "0x11896A8", VA = "0x11896A8")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018D")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001CA")]
			public class BoneLink
			{
				[Token(Token = "0x4000C50")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660DF8", Offset = "0x660DF8")]
				public Transform bone;

				[Token(Token = "0x4000C51")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660E30", Offset = "0x660E30")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x660E30", Offset = "0x660E30")]
				public float weight;

				[Token(Token = "0x4000C52")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000C53")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000B24")]
				[Address(RVA = "0x1188E4C", Offset = "0x1188E4C", VA = "0x1188E4C")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000B25")]
				[Address(RVA = "0x1188B8C", Offset = "0x1188B8C", VA = "0x1188B8C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000B26")]
				[Address(RVA = "0x1188FEC", Offset = "0x1188FEC", VA = "0x1188FEC")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000B00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FC90", Offset = "0x65FC90")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000B01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FCC8", Offset = "0x65FCC8")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000B02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x1188A20", Offset = "0x1188A20", VA = "0x1188A20", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x1188AFC", Offset = "0x1188AFC", VA = "0x1188AFC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x1188BA8", Offset = "0x1188BA8", VA = "0x1188BA8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x1188FD8", Offset = "0x1188FD8", VA = "0x1188FD8")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B908", Offset = "0x65B908")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B940", Offset = "0x65B940")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000080")]
		public bool inProgress
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0xF4FD5C", Offset = "0xF4FD5C", VA = "0xF4FD5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xF4FE58", Offset = "0xF4FE58", VA = "0xF4FE58", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xF4FF94", Offset = "0xF4FF94", VA = "0xF4FF94")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xF50204", Offset = "0xF50204", VA = "0xF50204")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x200018E")]
		public abstract class Offset
		{
			[Token(Token = "0x4000B03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FD00", Offset = "0x65FD00")]
			public string name;

			[Token(Token = "0x4000B04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FD38", Offset = "0x65FD38")]
			public Collider collider;

			[Token(Token = "0x4000B05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FD70", Offset = "0x65FD70")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000B06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65FDBC", Offset = "0x65FDBC")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000B07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65FDCC", Offset = "0x65FDCC")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000B08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65FDDC", Offset = "0x65FDDC")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000B09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65FDEC", Offset = "0x65FDEC")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000B0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000B0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000B0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000115")]
			protected float crossFader
			{
				[Token(Token = "0x6000A97")]
				[Address(RVA = "0x1189F04", Offset = "0x1189F04", VA = "0x1189F04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6643B4", Offset = "0x6643B4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A98")]
				[Address(RVA = "0x1189F0C", Offset = "0x1189F0C", VA = "0x1189F0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6643C4", Offset = "0x6643C4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000116")]
			protected float timer
			{
				[Token(Token = "0x6000A99")]
				[Address(RVA = "0x1189F14", Offset = "0x1189F14", VA = "0x1189F14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6643D4", Offset = "0x6643D4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A9A")]
				[Address(RVA = "0x1189F1C", Offset = "0x1189F1C", VA = "0x1189F1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6643E4", Offset = "0x6643E4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000117")]
			protected Vector3 force
			{
				[Token(Token = "0x6000A9B")]
				[Address(RVA = "0x1189F24", Offset = "0x1189F24", VA = "0x1189F24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6643F4", Offset = "0x6643F4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A9C")]
				[Address(RVA = "0x1189F30", Offset = "0x1189F30", VA = "0x1189F30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664404", Offset = "0x664404")]
				private set
				{
				}
			}

			[Token(Token = "0x17000118")]
			protected Vector3 point
			{
				[Token(Token = "0x6000A9D")]
				[Address(RVA = "0x1189F3C", Offset = "0x1189F3C", VA = "0x1189F3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664414", Offset = "0x664414")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A9E")]
				[Address(RVA = "0x1189F48", Offset = "0x1189F48", VA = "0x1189F48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x664424", Offset = "0x664424")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0x1189DBC", Offset = "0x1189DBC", VA = "0x1189DBC")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x11899F8", Offset = "0x11899F8", VA = "0x11899F8")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000AA1")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000AA2")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000AA3")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x1189F54", Offset = "0x1189F54", VA = "0x1189F54")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018F")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001CB")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000C54")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660E84", Offset = "0x660E84")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000C55")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660EBC", Offset = "0x660EBC")]
				public float weight;

				[Token(Token = "0x4000C56")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000C57")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000B27")]
				[Address(RVA = "0x118A594", Offset = "0x118A594", VA = "0x118A594")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000B28")]
				[Address(RVA = "0x118A2D8", Offset = "0x118A2D8", VA = "0x118A2D8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000B29")]
				[Address(RVA = "0x118A6E4", Offset = "0x118A6E4", VA = "0x118A6E4")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000B0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FDFC", Offset = "0x65FDFC")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000B0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FE34", Offset = "0x65FE34")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000B0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FE6C", Offset = "0x65FE6C")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x1189F68", Offset = "0x1189F68", VA = "0x1189F68", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x118A250", Offset = "0x118A250", VA = "0x118A250", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x118A2EC", Offset = "0x118A2EC", VA = "0x118A2EC", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x118A6C8", Offset = "0x118A6C8", VA = "0x118A6C8")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000190")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001CC")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000C58")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660EF4", Offset = "0x660EF4")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000C59")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660F2C", Offset = "0x660F2C")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x660F2C", Offset = "0x660F2C")]
				public float weight;

				[Token(Token = "0x4000C5A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000C5B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000B2A")]
				[Address(RVA = "0x118AC60", Offset = "0x118AC60", VA = "0x118AC60")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000B2B")]
				[Address(RVA = "0x118A8E0", Offset = "0x118A8E0", VA = "0x118A8E0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000B2C")]
				[Address(RVA = "0x118ADD8", Offset = "0x118ADD8", VA = "0x118ADD8")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000B10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FEA4", Offset = "0x65FEA4")]
			public int curveIndex;

			[Token(Token = "0x4000B11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FEDC", Offset = "0x65FEDC")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000B12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x118A6EC", Offset = "0x118A6EC", VA = "0x118A6EC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x118A850", Offset = "0x118A850", VA = "0x118A850", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x118A8FC", Offset = "0x118A8FC", VA = "0x118A8FC", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x118ADC4", Offset = "0x118ADC4", VA = "0x118ADC4")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B978", Offset = "0x65B978")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B9B0", Offset = "0x65B9B0")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x11898D4", Offset = "0x11898D4", VA = "0x11898D4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1189B4C", Offset = "0x1189B4C", VA = "0x1189B4C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1189EFC", Offset = "0x1189EFC", VA = "0x1189EFC")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000191")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001CD")]
			public class EffectorLink
			{
				[Token(Token = "0x4000C5C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660F80", Offset = "0x660F80")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000C5D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660FB8", Offset = "0x660FB8")]
				public float weight;

				[Token(Token = "0x6000B2D")]
				[Address(RVA = "0x11E7B64", Offset = "0x11E7B64", VA = "0x11E7B64")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000B13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FF14", Offset = "0x65FF14")]
			public Transform transform;

			[Token(Token = "0x4000B14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FF4C", Offset = "0x65FF4C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000B15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FF84", Offset = "0x65FF84")]
			public float speed;

			[Token(Token = "0x4000B16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FFBC", Offset = "0x65FFBC")]
			public float acceleration;

			[Token(Token = "0x4000B17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65FFF4", Offset = "0x65FFF4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65FFF4", Offset = "0x65FFF4")]
			public float matchVelocity;

			[Token(Token = "0x4000B18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660048", Offset = "0x660048")]
			public float gravity;

			[Token(Token = "0x4000B19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000B1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000B1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000B1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000B1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x11E75B4", Offset = "0x11E75B4", VA = "0x11E75B4")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x11E7778", Offset = "0x11E7778", VA = "0x11E7778")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x11E7B48", Offset = "0x11E7B48", VA = "0x11E7B48")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65B9E8", Offset = "0x65B9E8")]
		public Body[] bodies;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BA20", Offset = "0x65BA20")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x11E7524", Offset = "0x11E7524", VA = "0x11E7524")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x11E76A4", Offset = "0x11E76A4", VA = "0x11E76A4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x11E7B40", Offset = "0x11E7B40", VA = "0x11E7B40")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x65BA58", Offset = "0x65BA58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BA58", Offset = "0x65BA58")]
		public Transform target;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65BAB8", Offset = "0x65BAB8")]
		public float weight;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BAD0", Offset = "0x65BAD0")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BB08", Offset = "0x65BB08")]
		public float weightSmoothTime;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x65BB40", Offset = "0x65BB40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BB40", Offset = "0x65BB40")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BBA0", Offset = "0x65BBA0")]
		public float maxRadiansDelta;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BBD8", Offset = "0x65BBD8")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BC10", Offset = "0x65BC10")]
		public float slerpSpeed;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BC48", Offset = "0x65BC48")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BC80", Offset = "0x65BC80")]
		public float minDistance;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x65BCB8", Offset = "0x65BCB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BCB8", Offset = "0x65BCB8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65BCB8", Offset = "0x65BCB8")]
		public float maxRootAngle;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x17000081")]
		private Vector3 pivot
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0xE28FE4", Offset = "0xE28FE4", VA = "0xE28FE4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xE28ED8", Offset = "0xE28ED8", VA = "0xE28ED8")]
		private void Start()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xE2915C", Offset = "0xE2915C", VA = "0xE2915C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xE29964", Offset = "0xE29964", VA = "0xE29964")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xE29B30", Offset = "0xE29B30", VA = "0xE29B30")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xE29EE0", Offset = "0xE29EE0", VA = "0xE29EE0")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000192")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000B1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660080", Offset = "0x660080")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000B1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6600B8", Offset = "0x6600B8")]
			public float spring;

			[Token(Token = "0x4000B20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6600F0", Offset = "0x6600F0")]
			public bool x;

			[Token(Token = "0x4000B21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660128", Offset = "0x660128")]
			public bool y;

			[Token(Token = "0x4000B22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660160", Offset = "0x660160")]
			public bool z;

			[Token(Token = "0x4000B23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660198", Offset = "0x660198")]
			public float minX;

			[Token(Token = "0x4000B24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6601D0", Offset = "0x6601D0")]
			public float maxX;

			[Token(Token = "0x4000B25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660208", Offset = "0x660208")]
			public float minY;

			[Token(Token = "0x4000B26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660240", Offset = "0x660240")]
			public float maxY;

			[Token(Token = "0x4000B27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660278", Offset = "0x660278")]
			public float minZ;

			[Token(Token = "0x4000B28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6602B0", Offset = "0x6602B0")]
			public float maxZ;

			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0xE2A41C", Offset = "0xE2A41C", VA = "0xE2A41C")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0xE2AA38", Offset = "0xE2AA38", VA = "0xE2AA38")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0xE2AA68", Offset = "0xE2AA68", VA = "0xE2AA68")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0xE2AB40", Offset = "0xE2AB40", VA = "0xE2AB40")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000193")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6576DC", Offset = "0x6576DC")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x17000119")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AB7")]
				[Address(RVA = "0xE2A9C0", Offset = "0xE2A9C0", VA = "0xE2A9C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AB9")]
				[Address(RVA = "0xE2AA30", Offset = "0xE2AA30", VA = "0xE2AA30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0xE2A1F8", Offset = "0xE2A1F8", VA = "0xE2A1F8")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0xE2A810", Offset = "0xE2A810", VA = "0xE2A810", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0xE2A814", Offset = "0xE2A814", VA = "0xE2A814", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0xE2A9C8", Offset = "0xE2A9C8", VA = "0xE2A9C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BD34", Offset = "0x65BD34")]
		public float weight;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BD6C", Offset = "0x65BD6C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000082")]
		protected float deltaTime
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0xE2A12C", Offset = "0xE2A12C", VA = "0xE2A12C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000691")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xE2A158", Offset = "0xE2A158", VA = "0xE2A158", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xE2A184", Offset = "0xE2A184", VA = "0xE2A184")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6635E8", Offset = "0x6635E8")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xE2A224", Offset = "0xE2A224", VA = "0xE2A224")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xE2A330", Offset = "0xE2A330", VA = "0xE2A330")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xE2A6A0", Offset = "0xE2A6A0", VA = "0xE2A6A0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xE2A800", Offset = "0xE2A800", VA = "0xE2A800")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000194")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6576EC", Offset = "0x6576EC")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x1700011B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000ABD")]
				[Address(RVA = "0xE2B06C", Offset = "0xE2B06C", VA = "0xE2B06C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000ABF")]
				[Address(RVA = "0xE2B0DC", Offset = "0xE2B0DC", VA = "0xE2B0DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0xE2AC14", Offset = "0xE2AC14", VA = "0xE2AC14")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0xE2AEBC", Offset = "0xE2AEBC", VA = "0xE2AEBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0xE2AEC0", Offset = "0xE2AEC0", VA = "0xE2AEC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0xE2B074", Offset = "0xE2B074", VA = "0xE2B074", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BDA4", Offset = "0x65BDA4")]
		public float weight;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BDDC", Offset = "0x65BDDC")]
		public VRIK ik;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000083")]
		protected float deltaTime
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0xE2AB48", Offset = "0xE2AB48", VA = "0xE2AB48")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000699")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xE2AB74", Offset = "0xE2AB74", VA = "0xE2AB74", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xE2ABA0", Offset = "0xE2ABA0", VA = "0xE2ABA0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x66364C", Offset = "0x66364C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xE2AC40", Offset = "0xE2AC40", VA = "0xE2AC40")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xE2AD4C", Offset = "0xE2AD4C", VA = "0xE2AD4C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xE2AEAC", Offset = "0xE2AEAC", VA = "0xE2AEAC")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000195")]
		public class EffectorLink
		{
			[Token(Token = "0x4000B2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000B30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000B31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000B32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0xE2B1FC", Offset = "0xE2B1FC", VA = "0xE2B1FC")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0xE2B738", Offset = "0xE2B738", VA = "0xE2B738")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xE2B0E4", Offset = "0xE2B0E4", VA = "0xE2B0E4")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xE2B5F0", Offset = "0xE2B5F0", VA = "0xE2B5F0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xE2B6D8", Offset = "0xE2B6D8", VA = "0xE2B6D8")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000196")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20001CE")]
			public class EffectorLink
			{
				[Token(Token = "0x4000C5E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660FF0", Offset = "0x660FF0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000C5F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x661028", Offset = "0x661028")]
				public float weight;

				[Token(Token = "0x6000B2E")]
				[Address(RVA = "0xE2BE90", Offset = "0xE2BE90", VA = "0xE2BE90")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000B33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6602E8", Offset = "0x6602E8")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000B34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660320", Offset = "0x660320")]
			public Transform raycastTo;

			[Token(Token = "0x4000B35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660358", Offset = "0x660358")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x660358", Offset = "0x660358")]
			public float raycastRadius;

			[Token(Token = "0x4000B36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6603AC", Offset = "0x6603AC")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000B37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6603E4", Offset = "0x6603E4")]
			public float smoothTimeIn;

			[Token(Token = "0x4000B38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x66041C", Offset = "0x66041C")]
			public float smoothTimeOut;

			[Token(Token = "0x4000B39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660454", Offset = "0x660454")]
			public LayerMask layers;

			[Token(Token = "0x4000B3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000B3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000B3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0xE2B7F4", Offset = "0xE2B7F4", VA = "0xE2B7F4")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0xE2BA1C", Offset = "0xE2BA1C", VA = "0xE2BA1C")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0xE2BC00", Offset = "0xE2BC00", VA = "0xE2BC00")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0xE2BE74", Offset = "0xE2BE74", VA = "0xE2BE74")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BE14", Offset = "0x65BE14")]
		public Avoider[] avoiders;

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xE2B740", Offset = "0xE2B740", VA = "0xE2B740", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xE2BA0C", Offset = "0xE2BA0C", VA = "0xE2BA0C")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000197")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20001CF")]
			public class EffectorLink
			{
				[Token(Token = "0x4000C60")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x661060", Offset = "0x661060")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000C61")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x661098", Offset = "0x661098")]
				public float weight;

				[Token(Token = "0x6000B2F")]
				[Address(RVA = "0xE2FA40", Offset = "0xE2FA40", VA = "0xE2FA40")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000B3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x66048C", Offset = "0x66048C")]
			public Vector3 offset;

			[Token(Token = "0x4000B3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6604C4", Offset = "0x6604C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6604C4", Offset = "0x6604C4")]
			public float additivity;

			[Token(Token = "0x4000B3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660518", Offset = "0x660518")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000B40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660550", Offset = "0x660550")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000B41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000B42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0xE2E3F0", Offset = "0xE2E3F0", VA = "0xE2E3F0")]
			public void Start()
			{
			}

			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0xE2F160", Offset = "0xE2F160", VA = "0xE2F160")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0xE2FA28", Offset = "0xE2FA28", VA = "0xE2FA28")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000198")]
		public enum Handedness
		{
			[Token(Token = "0x4000B44")]
			Right,
			[Token(Token = "0x4000B45")]
			Left
		}

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BE4C", Offset = "0x65BE4C")]
		public AimIK aimIK;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BE84", Offset = "0x65BE84")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BEBC", Offset = "0x65BEBC")]
		public Handedness handedness;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BEF4", Offset = "0x65BEF4")]
		public bool twoHanded;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BF2C", Offset = "0x65BF2C")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BF64", Offset = "0x65BF64")]
		public float magnitudeRandom;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BF9C", Offset = "0x65BF9C")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65BFD4", Offset = "0x65BFD4")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C00C", Offset = "0x65C00C")]
		public float blendTime;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x65C044", Offset = "0x65C044")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C044", Offset = "0x65C044")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x17000084")]
		public bool isFinished
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0xE2E18C", Offset = "0xE2E18C", VA = "0xE2E18C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0xE2F448", Offset = "0xE2F448", VA = "0xE2F448")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0xE2F4A8", Offset = "0xE2F4A8", VA = "0xE2F4A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		private Transform primaryHand
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0xE2F3F0", Offset = "0xE2F3F0", VA = "0xE2F3F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0xE2F41C", Offset = "0xE2F41C", VA = "0xE2F41C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xE2E1BC", Offset = "0xE2E1BC", VA = "0xE2E1BC")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xE2E1E8", Offset = "0xE2E1E8", VA = "0xE2E1E8")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xE2E4A0", Offset = "0xE2E4A0", VA = "0xE2E4A0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xE2F508", Offset = "0xE2F508", VA = "0xE2F508")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xE2F6A4", Offset = "0xE2F6A4", VA = "0xE2F6A4")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xE2F700", Offset = "0xE2F700", VA = "0xE2F700", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xE2F974", Offset = "0xE2F974", VA = "0xE2F974")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C0A4", Offset = "0x65C0A4")]
		public float weight;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C0DC", Offset = "0x65C0DC")]
		public float offset;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xE34114", Offset = "0xE34114", VA = "0xE34114")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xE34250", Offset = "0xE34250", VA = "0xE34250")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xE34368", Offset = "0xE34368", VA = "0xE34368")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xE34900", Offset = "0xE34900", VA = "0xE34900")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xE34964", Offset = "0xE34964", VA = "0xE34964")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xE34AC4", Offset = "0xE34AC4", VA = "0xE34AC4")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x2000199")]
		public class Settings
		{
			[Token(Token = "0x4000B46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660588", Offset = "0x660588")]
			public float scaleMlp;

			[Token(Token = "0x4000B47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6605C0", Offset = "0x6605C0")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000B48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6605F8", Offset = "0x6605F8")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000B49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660630", Offset = "0x660630")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000B4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660668", Offset = "0x660668")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000B4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6606A0", Offset = "0x6606A0")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000B4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6606D8", Offset = "0x6606D8")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000B4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660710", Offset = "0x660710")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000B4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660748", Offset = "0x660748")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000B4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x660780", Offset = "0x660780")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660780", Offset = "0x660780")]
			public Vector3 headOffset;

			[Token(Token = "0x4000B50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6607D0", Offset = "0x6607D0")]
			public Vector3 handOffset;

			[Token(Token = "0x4000B51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660808", Offset = "0x660808")]
			public float footForwardOffset;

			[Token(Token = "0x4000B52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660840", Offset = "0x660840")]
			public float footInwardOffset;

			[Token(Token = "0x4000B53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660878", Offset = "0x660878")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x660878", Offset = "0x660878")]
			public float footHeadingOffset;

			[Token(Token = "0x4000B54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6608D4", Offset = "0x6608D4")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000B55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6608EC", Offset = "0x6608EC")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0xE3B080", Offset = "0xE3B080", VA = "0xE3B080")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200019A")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20001D0")]
			public class Target
			{
				[Token(Token = "0x4000C62")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000C63")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000C64")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000B30")]
				[Address(RVA = "0xE39D54", Offset = "0xE39D54", VA = "0xE39D54")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000B31")]
				[Address(RVA = "0xE3AB90", Offset = "0xE3AB90", VA = "0xE3AB90")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000B56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000B57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000B58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000B59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000B5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000B5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000B5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x4000B5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000B5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000B5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000B60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000B61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0xE38FD0", Offset = "0xE38FD0", VA = "0xE38FD0")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xE37300", Offset = "0xE37300", VA = "0xE37300")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xE374F8", Offset = "0xE374F8", VA = "0xE374F8")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xE39148", Offset = "0xE39148", VA = "0xE39148")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xE39E48", Offset = "0xE39E48", VA = "0xE39E48")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xE3AC34", Offset = "0xE3AC34", VA = "0xE3AC34")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65C114", Offset = "0x65C114")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x17000089")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0xE39E3C", Offset = "0xE39E3C", VA = "0xE39E3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6636B0", Offset = "0x6636B0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0xE3B178", Offset = "0xE3B178", VA = "0xE3B178")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6636C0", Offset = "0x6636C0")]
			private set
			{
			}
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xE3B184", Offset = "0xE3B184", VA = "0xE3B184")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xE39AB0", Offset = "0xE39AB0", VA = "0xE39AB0")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xE3AEB0", Offset = "0xE3AEB0", VA = "0xE3AEB0")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xE3B2C8", Offset = "0xE3B2C8", VA = "0xE3B2C8")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xE3B998", Offset = "0xE3B998", VA = "0xE3B998")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xE3BAF8", Offset = "0xE3BAF8", VA = "0xE3BAF8")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000D7")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xB1FCAC", Offset = "0xB1FCAC", VA = "0xB1FCAC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xB1FDA8", Offset = "0xB1FDA8", VA = "0xB1FDA8")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C124", Offset = "0x65C124")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xB1FDB0", Offset = "0xB1FDB0", VA = "0xB1FDB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xB1FF3C", Offset = "0xB1FF3C", VA = "0xB1FF3C")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C15C", Offset = "0x65C15C")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C194", Offset = "0x65C194")]
		public AimIK aim;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C1CC", Offset = "0x65C1CC")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C204", Offset = "0x65C204")]
		public Animator animator;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C23C", Offset = "0x65C23C")]
		public float crossfadeTime;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C274", Offset = "0x65C274")]
		public float minAimDistance;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xB35C60", Offset = "0xB35C60", VA = "0xB35C60")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xB35CB8", Offset = "0xB35CB8", VA = "0xB35CB8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xB35E40", Offset = "0xB35E40", VA = "0xB35E40")]
		private void Pose()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xB360F8", Offset = "0xB360F8", VA = "0xB360F8")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xB36364", Offset = "0xB36364", VA = "0xB36364")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xB36458", Offset = "0xB36458", VA = "0xB36458")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xB37378", Offset = "0xB37378", VA = "0xB37378")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xB37640", Offset = "0xB37640", VA = "0xB37640")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xB37898", Offset = "0xB37898", VA = "0xB37898")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x65C2AC", Offset = "0x65C2AC")]
		public Animator animator;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x65C2E4", Offset = "0x65C2E4")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C31C", Offset = "0x65C31C")]
		public float lookAtWeight;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C334", Offset = "0x65C334")]
		public float lookAtBodyWeight;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C34C", Offset = "0x65C34C")]
		public float lookAtHeadWeight;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C364", Offset = "0x65C364")]
		public float lookAtEyesWeight;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C37C", Offset = "0x65C37C")]
		public float lookAtClampWeight;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C394", Offset = "0x65C394")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C3AC", Offset = "0x65C3AC")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x65C3C4", Offset = "0x65C3C4")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C3FC", Offset = "0x65C3FC")]
		public float footPositionWeight;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C414", Offset = "0x65C414")]
		public float footRotationWeight;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x65C42C", Offset = "0x65C42C")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C464", Offset = "0x65C464")]
		public float handPositionWeight;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C47C", Offset = "0x65C47C")]
		public float handRotationWeight;

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xB22230", Offset = "0xB22230", VA = "0xB22230")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xB22AEC", Offset = "0xB22AEC", VA = "0xB22AEC")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xB2E4F4", Offset = "0xB2E4F4", VA = "0xB2E4F4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xB2F0CC", Offset = "0xB2F0CC", VA = "0xB2F0CC")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xB2ED50", Offset = "0xB2ED50", VA = "0xB2ED50")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xB2F2C8", Offset = "0xB2F2C8", VA = "0xB2F2C8")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x1700008A")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0xB2F2F4", Offset = "0xB2F2F4", VA = "0xB2F2F4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xB2F394", Offset = "0xB2F394", VA = "0xB2F394")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xB2F6C8", Offset = "0xB2F6C8", VA = "0xB2F6C8")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x200019B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6576FC", Offset = "0x6576FC")]
		private sealed class <Step>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x4000B65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000B66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x1700011D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000ACE")]
				[Address(RVA = "0xB30690", Offset = "0xB30690", VA = "0xB30690", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AD0")]
				[Address(RVA = "0xB30700", Offset = "0xB30700", VA = "0xB30700", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0xB30254", Offset = "0xB30254", VA = "0xB30254")]
			[DebuggerHidden]
			public <Step>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0xB302B0", Offset = "0xB302B0", VA = "0xB302B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0xB302B4", Offset = "0xB302B4", VA = "0xB302B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0xB30698", Offset = "0xB30698", VA = "0xB30698", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem sand;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IK ik;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float stepProgress;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastStepTime;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit hit;

		[Token(Token = "0x1700008B")]
		public bool isStepping
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0xB2F6DC", Offset = "0xB2F6DC", VA = "0xB2F6DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008C")]
		public Vector3 position
		{
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0xB2F278", Offset = "0xB2F278", VA = "0xB2F278")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0xB2F6F0", Offset = "0xB2F6F0", VA = "0xB2F6F0")]
			set
			{
			}
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xB2F764", Offset = "0xB2F764", VA = "0xB2F764")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xB2F7BC", Offset = "0xB2F7BC", VA = "0xB2F7BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xB2F9E4", Offset = "0xB2F9E4", VA = "0xB2F9E4")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xB2FEA8", Offset = "0xB2FEA8", VA = "0xB2FEA8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xB2FFEC", Offset = "0xB2FFEC", VA = "0xB2FFEC")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xB2FF18", Offset = "0xB2FF18", VA = "0xB2FF18")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6636D0", Offset = "0x6636D0")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xB30280", Offset = "0xB30280", VA = "0xB30280")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xB30708", Offset = "0xB30708", VA = "0xB30708")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xB30800", Offset = "0xB30800", VA = "0xB30800")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xB30AD4", Offset = "0xB30AD4", VA = "0xB30AD4")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200019C")]
		public struct Warp
		{
			[Token(Token = "0x4000B67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660904", Offset = "0x660904")]
			public int animationLayer;

			[Token(Token = "0x4000B68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x66093C", Offset = "0x66093C")]
			public string animationState;

			[Token(Token = "0x4000B69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660974", Offset = "0x660974")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000B6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6609AC", Offset = "0x6609AC")]
			public Transform warpFrom;

			[Token(Token = "0x4000B6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6609E4", Offset = "0x6609E4")]
			public Transform warpTo;

			[Token(Token = "0x4000B6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660A1C", Offset = "0x660A1C")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x200019D")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000B6E")]
			PositionOffset,
			[Token(Token = "0x4000B6F")]
			Position
		}

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C494", Offset = "0x65C494")]
		public Animator animator;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C4CC", Offset = "0x65C4CC")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x65C504", Offset = "0x65C504")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C504", Offset = "0x65C504")]
		public Warp[] warps;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xB1FFB4", Offset = "0xB1FFB4", VA = "0xB1FFB4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xB1FFE0", Offset = "0xB1FFE0", VA = "0xB1FFE0")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xB2024C", Offset = "0xB2024C", VA = "0xB2024C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xB20770", Offset = "0xB20770", VA = "0xB20770")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xB20838", Offset = "0xB20838", VA = "0xB20838")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x655E24", Offset = "0x655E24")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xB20840", Offset = "0xB20840", VA = "0xB20840", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xB20898", Offset = "0xB20898", VA = "0xB20898")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xB20B14", Offset = "0xB20B14", VA = "0xB20B14", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xB20DD8", Offset = "0xB20DD8", VA = "0xB20DD8")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x655E88", Offset = "0x655E88")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x655E88", Offset = "0x655E88")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C554", Offset = "0x65C554")]
		public float headLookWeight;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xB20DEC", Offset = "0xB20DEC", VA = "0xB20DEC", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xB2105C", Offset = "0xB2105C", VA = "0xB2105C", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xB210D0", Offset = "0xB210D0", VA = "0xB210D0")]
		private void Read()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xB212C0", Offset = "0xB212C0", VA = "0xB212C0")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xB21344", Offset = "0xB21344", VA = "0xB21344")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xB21B00", Offset = "0xB21B00", VA = "0xB21B00")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xB21844", Offset = "0xB21844", VA = "0xB21844")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xB21EE0", Offset = "0xB21EE0", VA = "0xB21EE0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xB22040", Offset = "0xB22040", VA = "0xB22040")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x655F14", Offset = "0x655F14")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xB23EC4", Offset = "0xB23EC4", VA = "0xB23EC4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xB23F24", Offset = "0xB23F24", VA = "0xB23F24", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xB2426C", Offset = "0xB2426C", VA = "0xB2426C")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xB24434", Offset = "0xB24434", VA = "0xB24434")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x655F78", Offset = "0x655F78")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x1700008D")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0xB25444", Offset = "0xB25444", VA = "0xB25444")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700008E")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0xB254E4", Offset = "0xB254E4", VA = "0xB254E4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xB25140", Offset = "0xB25140", VA = "0xB25140")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xB251B4", Offset = "0xB251B4", VA = "0xB251B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xB25584", Offset = "0xB25584", VA = "0xB25584")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C57C", Offset = "0x65C57C")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xB28168", Offset = "0xB28168", VA = "0xB28168", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xB288C8", Offset = "0xB288C8", VA = "0xB288C8")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xB288D0", Offset = "0xB288D0", VA = "0xB288D0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xB2898C", Offset = "0xB2898C", VA = "0xB2898C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xB28FF0", Offset = "0xB28FF0", VA = "0xB28FF0")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xB29108", Offset = "0xB29108", VA = "0xB29108")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200019E")]
		public class Limb
		{
			[Token(Token = "0x4000B70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x4000B71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000B72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0xB29380", Offset = "0xB29380", VA = "0xB29380")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0xB294F4", Offset = "0xB294F4", VA = "0xB294F4")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xB29190", Offset = "0xB29190", VA = "0xB29190")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xB29444", Offset = "0xB29444", VA = "0xB29444")]
		private void Start()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xB294E0", Offset = "0xB294E0", VA = "0xB294E0")]
		private void Update()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xB294E4", Offset = "0xB294E4", VA = "0xB294E4")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xB29504", Offset = "0xB29504", VA = "0xB29504")]
		private void Start()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xB29570", Offset = "0xB29570", VA = "0xB29570")]
		private void Update()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xB29690", Offset = "0xB29690", VA = "0xB29690")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C594", Offset = "0x65C594")]
		public Transform target;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C5CC", Offset = "0x65C5CC")]
		public Transform pin;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C604", Offset = "0x65C604")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C63C", Offset = "0x65C63C")]
		public AimIK aim;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C674", Offset = "0x65C674")]
		public float weight;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C6AC", Offset = "0x65C6AC")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C6E4", Offset = "0x65C6E4")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xB29698", Offset = "0xB29698", VA = "0xB29698")]
		private void Start()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xB296F0", Offset = "0xB296F0", VA = "0xB296F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xB2997C", Offset = "0xB2997C", VA = "0xB2997C")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xB29984", Offset = "0xB29984", VA = "0xB29984")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xB29AAC", Offset = "0xB29AAC", VA = "0xB29AAC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xB29B84", Offset = "0xB29B84", VA = "0xB29B84")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xB2A1A4", Offset = "0xB2A1A4", VA = "0xB2A1A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xB2A304", Offset = "0xB2A304", VA = "0xB2A304")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C71C", Offset = "0x65C71C")]
		public float aimWeight;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C734", Offset = "0x65C734")]
		public float sightWeight;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C74C", Offset = "0x65C74C")]
		public float maxAngle;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C7D8", Offset = "0x65C7D8")]
		private float cameraRecoilWeight;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool updateFrame;

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xB2A30C", Offset = "0xB2A30C", VA = "0xB2A30C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xB2A4CC", Offset = "0xB2A4CC", VA = "0xB2A4CC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xB2A4D8", Offset = "0xB2A4D8", VA = "0xB2A4D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xB2A954", Offset = "0xB2A954", VA = "0xB2A954")]
		private void Aiming()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xB2AC80", Offset = "0xB2AC80", VA = "0xB2AC80")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xB2A624", Offset = "0xB2A624", VA = "0xB2A624")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xB2BA94", Offset = "0xB2BA94", VA = "0xB2BA94")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x655FDC", Offset = "0x655FDC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x655FDC", Offset = "0x655FDC")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C818", Offset = "0x65C818")]
		public float walkSpeed;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xB2BAB4", Offset = "0xB2BAB4", VA = "0xB2BAB4")]
		private void Start()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xB2BB24", Offset = "0xB2BB24", VA = "0xB2BB24")]
		private void Update()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xB2BC8C", Offset = "0xB2BC8C", VA = "0xB2BC8C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xB2BD3C", Offset = "0xB2BD3C", VA = "0xB2BD3C")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xB2BF24", Offset = "0xB2BF24", VA = "0xB2BF24")]
		private void Update()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xB2C130", Offset = "0xB2C130", VA = "0xB2C130")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xB2C200", Offset = "0xB2C200", VA = "0xB2C200")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xB2C4FC", Offset = "0xB2C4FC", VA = "0xB2C4FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xB2C70C", Offset = "0xB2C70C", VA = "0xB2C70C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xB2CC88", Offset = "0xB2CC88", VA = "0xB2CC88")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xB2CC98", Offset = "0xB2CC98", VA = "0xB2CC98")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xB2CD74", Offset = "0xB2CD74", VA = "0xB2CD74")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xB2CF48", Offset = "0xB2CF48", VA = "0xB2CF48")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xB2CF50", Offset = "0xB2CF50", VA = "0xB2CF50")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xB2D3A0", Offset = "0xB2D3A0", VA = "0xB2D3A0")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x657068", Offset = "0x657068")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C850", Offset = "0x65C850")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C89C", Offset = "0x65C89C")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xB2D3A8", Offset = "0xB2D3A8", VA = "0xB2D3A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xB2D400", Offset = "0xB2D400", VA = "0xB2D400")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xB2D6A8", Offset = "0xB2D6A8", VA = "0xB2D6A8")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200019F")]
		public class Partner
		{
			[Token(Token = "0x4000B73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000B74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000B75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000B76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000B77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000B78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000B79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000B7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000B7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000B7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000B7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x1700011F")]
			private Transform neck
			{
				[Token(Token = "0x6000AD5")]
				[Address(RVA = "0xB2E404", Offset = "0xB2E404", VA = "0xB2E404")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0xB2D6F8", Offset = "0xB2D6F8", VA = "0xB2D6F8")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0xB2D7B8", Offset = "0xB2D7B8", VA = "0xB2D7B8")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0xB2E1B0", Offset = "0xB2E1B0", VA = "0xB2E1B0")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0xB2E4E0", Offset = "0xB2E4E0", VA = "0xB2E4E0")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xB2D6B0", Offset = "0xB2D6B0", VA = "0xB2D6B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xB2D72C", Offset = "0xB2D72C", VA = "0xB2D72C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xB2E1A0", Offset = "0xB2E1A0", VA = "0xB2E1A0")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001A0")]
		public enum Mode
		{
			[Token(Token = "0x4000B7F")]
			Position,
			[Token(Token = "0x4000B80")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x20001A1")]
		public class Absorber
		{
			[Token(Token = "0x4000B81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660A54", Offset = "0x660A54")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000B82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660A8C", Offset = "0x660A8C")]
			public float weight;

			[Token(Token = "0x4000B83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000B84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000B85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0xB30CEC", Offset = "0xB30CEC", VA = "0xB30CEC")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0xB30F98", Offset = "0xB30F98", VA = "0xB30F98")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0xB30FF8", Offset = "0xB30FF8", VA = "0xB30FF8")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0xB31204", Offset = "0xB31204", VA = "0xB31204")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0xB314E8", Offset = "0xB314E8", VA = "0xB314E8")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C8E8", Offset = "0x65C8E8")]
		public Mode mode;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C920", Offset = "0x65C920")]
		public Absorber[] absorbers;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C958", Offset = "0x65C958")]
		public AnimationCurve falloff;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C990", Offset = "0x65C990")]
		public float falloffSpeed;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xB30ADC", Offset = "0xB30ADC", VA = "0xB30ADC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xB30C18", Offset = "0xB30C18", VA = "0xB30C18")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xB30E18", Offset = "0xB30E18", VA = "0xB30E18", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xB31144", Offset = "0xB31144", VA = "0xB31144")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xB3136C", Offset = "0xB3136C", VA = "0xB3136C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xB314D8", Offset = "0xB314D8", VA = "0xB314D8")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xB31568", Offset = "0xB31568", VA = "0xB31568")]
		private void Start()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xB315F4", Offset = "0xB315F4", VA = "0xB315F4")]
		private void Update()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xB316C8", Offset = "0xB316C8", VA = "0xB316C8")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xB318AC", Offset = "0xB318AC", VA = "0xB318AC")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001A2")]
		public class EffectorLink
		{
			[Token(Token = "0x4000B86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000B87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x4000B88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0xB32894", Offset = "0xB32894", VA = "0xB32894")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xB3244C", Offset = "0xB3244C", VA = "0xB3244C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xB325D8", Offset = "0xB325D8", VA = "0xB325D8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xB3288C", Offset = "0xB3288C", VA = "0xB3288C")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6570CC", Offset = "0x6570CC")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65C9C8", Offset = "0x65C9C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65C9C8", Offset = "0x65C9C8")]
		public float weight;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65CA1C", Offset = "0x65CA1C")]
		public float hangingDistanceMlp;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65CA54", Offset = "0x65CA54")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65CAA0", Offset = "0x65CAA0")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xB328A4", Offset = "0xB328A4", VA = "0xB328A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xB32CCC", Offset = "0xB32CCC", VA = "0xB32CCC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xB336C8", Offset = "0xB336C8", VA = "0xB336C8")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x1700008F")]
		private bool holding
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0xB338D8", Offset = "0xB338D8", VA = "0xB338D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xB33750", Offset = "0xB33750", VA = "0xB33750")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000743")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xB3390C", Offset = "0xB3390C", VA = "0xB3390C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xB33B9C", Offset = "0xB33B9C", VA = "0xB33B9C")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xB33D78", Offset = "0xB33D78", VA = "0xB33D78")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xB33EAC", Offset = "0xB33EAC", VA = "0xB33EAC")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xB34010", Offset = "0xB34010", VA = "0xB34010")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xB3429C", Offset = "0xB3429C", VA = "0xB3429C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xB34564", Offset = "0xB34564", VA = "0xB34564")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600074C")]
		[Address(RVA = "0xB34578", Offset = "0xB34578", VA = "0xB34578", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xB34814", Offset = "0xB34814", VA = "0xB34814")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600074E")]
		[Address(RVA = "0xB34828", Offset = "0xB34828", VA = "0xB34828", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xB34A80", Offset = "0xB34A80", VA = "0xB34A80")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xB353A4", Offset = "0xB353A4", VA = "0xB353A4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xB35408", Offset = "0xB35408", VA = "0xB35408")]
		private void Update()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xB35640", Offset = "0xB35640", VA = "0xB35640")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x657130", Offset = "0x657130")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xB35648", Offset = "0xB35648", VA = "0xB35648")]
		private void Start()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xB356A0", Offset = "0xB356A0", VA = "0xB356A0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xB35714", Offset = "0xB35714", VA = "0xB35714")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xB35778", Offset = "0xB35778", VA = "0xB35778")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x20001A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65770C", Offset = "0x65770C")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000B8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x17000120")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AE1")]
				[Address(RVA = "0xB35BE8", Offset = "0xB35BE8", VA = "0xB35BE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000121")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AE3")]
				[Address(RVA = "0xB35C58", Offset = "0xB35C58", VA = "0xB35C58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000ADE")]
			[Address(RVA = "0xB35940", Offset = "0xB35940", VA = "0xB35940")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000ADF")]
			[Address(RVA = "0xB3597C", Offset = "0xB3597C", VA = "0xB3597C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0xB35980", Offset = "0xB35980", VA = "0xB35980", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0xB35BF0", Offset = "0xB35BF0", VA = "0xB35BF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xB35788", Offset = "0xB35788", VA = "0xB35788")]
		private void Start()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xB35860", Offset = "0xB35860", VA = "0xB35860")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xB358A8", Offset = "0xB358A8", VA = "0xB358A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x663734", Offset = "0x663734")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xB3596C", Offset = "0xB3596C", VA = "0xB3596C")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x657194", Offset = "0x657194")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x20001A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65771C", Offset = "0x65771C")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x17000122")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AE7")]
				[Address(RVA = "0xB37300", Offset = "0xB37300", VA = "0xB37300", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000123")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AE9")]
				[Address(RVA = "0xB37370", Offset = "0xB37370", VA = "0xB37370", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0xB37124", Offset = "0xB37124", VA = "0xB37124")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0xB37158", Offset = "0xB37158", VA = "0xB37158", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0xB3715C", Offset = "0xB3715C", VA = "0xB3715C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0xB37308", Offset = "0xB37308", VA = "0xB37308", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xB36FEC", Offset = "0xB36FEC", VA = "0xB36FEC")]
		private void Start()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xB370B0", Offset = "0xB370B0", VA = "0xB370B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x663798", Offset = "0x663798")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xB37150", Offset = "0xB37150", VA = "0xB37150")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001A5")]
		public class EffectorLink
		{
			[Token(Token = "0x4000B90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000B91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000B92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000B93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000B94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000B95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000B96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000B97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x4000B98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x4000B99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x4000B9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x4000B9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x4000B9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x4000B9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x4000B9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x4000B9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000BA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000BA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x4000BA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x4000BA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0xB379A0", Offset = "0xB379A0", VA = "0xB379A0")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0xB38B00", Offset = "0xB38B00", VA = "0xB38B00")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0xB37ED8", Offset = "0xB37ED8", VA = "0xB37ED8")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000AED")]
			[Address(RVA = "0xB38BF0", Offset = "0xB38BF0", VA = "0xB38BF0")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0xB38DD8", Offset = "0xB38DD8", VA = "0xB38DD8")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0xB38E74", Offset = "0xB38E74", VA = "0xB38E74")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0xB38F0C", Offset = "0xB38F0C", VA = "0xB38F0C")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0xB38868", Offset = "0xB38868", VA = "0xB38868")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0xB38FA4", Offset = "0xB38FA4", VA = "0xB38FA4")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xB3790C", Offset = "0xB3790C", VA = "0xB3790C")]
		private void Start()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xB37E38", Offset = "0xB37E38", VA = "0xB37E38")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xB3876C", Offset = "0xB3876C", VA = "0xB3876C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xB38AF8", Offset = "0xB38AF8", VA = "0xB38AF8")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65CB8C", Offset = "0x65CB8C")]
		public Transform to;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65CBC4", Offset = "0x65CBC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65CBC4", Offset = "0x65CBC4")]
		public float transferMotion;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xB38FE4", Offset = "0xB38FE4", VA = "0xB38FE4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xB39028", Offset = "0xB39028", VA = "0xB39028")]
		private void Update()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xB391C0", Offset = "0xB391C0", VA = "0xB391C0")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65CC18", Offset = "0x65CC18")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xB393EC", Offset = "0xB393EC", VA = "0xB393EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xB3964C", Offset = "0xB3964C", VA = "0xB3964C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xB39A1C", Offset = "0xB39A1C", VA = "0xB39A1C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xB39B94", Offset = "0xB39B94", VA = "0xB39B94")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xB39CF4", Offset = "0xB39CF4", VA = "0xB39CF4")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xB3A114", Offset = "0xB3A114", VA = "0xB3A114", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xB3A5D8", Offset = "0xB3A5D8", VA = "0xB3A5D8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xB3A794", Offset = "0xB3A794", VA = "0xB3A794")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xB2BD4C", Offset = "0xB2BD4C", VA = "0xB2BD4C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xB2BE6C", Offset = "0xB2BE6C", VA = "0xB2BE6C")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xB2BF1C", Offset = "0xB2BF1C", VA = "0xB2BF1C")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x20001A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65772C", Offset = "0x65772C")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x17000124")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AF6")]
				[Address(RVA = "0xB3532C", Offset = "0xB3532C", VA = "0xB3532C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000125")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AF8")]
				[Address(RVA = "0xB3539C", Offset = "0xB3539C", VA = "0xB3539C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0xB34EC8", Offset = "0xB34EC8", VA = "0xB34EC8")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0xB35134", Offset = "0xB35134", VA = "0xB35134", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0xB35138", Offset = "0xB35138", VA = "0xB35138", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0xB35334", Offset = "0xB35334", VA = "0xB35334", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xB34A94", Offset = "0xB34A94", VA = "0xB34A94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xB34C38", Offset = "0xB34C38", VA = "0xB34C38")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xB34BC4", Offset = "0xB34BC4", VA = "0xB34BC4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6637FC", Offset = "0x6637FC")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xB34EF4", Offset = "0xB34EF4", VA = "0xB34EF4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xB35008", Offset = "0xB35008", VA = "0xB35008")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xB35118", Offset = "0xB35118", VA = "0xB35118")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65CC80", Offset = "0x65CC80")]
		public float weight;

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xB220A0", Offset = "0xB220A0", VA = "0xB220A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xB2210C", Offset = "0xB2210C", VA = "0xB2210C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xB22220", Offset = "0xB22220", VA = "0xB22220")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001A7")]
		public class Part
		{
			[Token(Token = "0x4000BA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000BA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0xB39268", Offset = "0xB39268", VA = "0xB39268")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0xB393E4", Offset = "0xB393E4", VA = "0xB393E4")]
			public Part()
			{
			}
		}

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xB391D4", Offset = "0xB391D4", VA = "0xB391D4")]
		private void Update()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xB393DC", Offset = "0xB393DC", VA = "0xB393DC")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xB2C210", Offset = "0xB2C210", VA = "0xB2C210")]
		private void Update()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xB2C41C", Offset = "0xB2C41C", VA = "0xB2C41C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xB2C4EC", Offset = "0xB2C4EC", VA = "0xB2C4EC")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65CCB8", Offset = "0x65CCB8")]
		public VRIK ik;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65CCF0", Offset = "0x65CCF0")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65CD28", Offset = "0x65CD28")]
		public Transform headTracker;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65CD60", Offset = "0x65CD60")]
		public Transform bodyTracker;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65CD98", Offset = "0x65CD98")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65CDD0", Offset = "0x65CDD0")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65CE08", Offset = "0x65CE08")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65CE40", Offset = "0x65CE40")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x65CE78", Offset = "0x65CE78")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xB3A7B8", Offset = "0xB3A7B8", VA = "0xB3A7B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xB3A924", Offset = "0xB3A924", VA = "0xB3A924")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xB3A98C", Offset = "0xB3A98C", VA = "0xB3A98C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xB3A9FC", Offset = "0xB3A9FC", VA = "0xB3A9FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xB3AC6C", Offset = "0xB3AC6C", VA = "0xB3AC6C")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xB3ACE4", Offset = "0xB3ACE4", VA = "0xB3ACE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xB3B400", Offset = "0xB3B400", VA = "0xB3B400")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x17000090")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0xB22B40", Offset = "0xB22B40", VA = "0xB22B40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xB22B0C", Offset = "0xB22B0C", VA = "0xB22B0C", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xB22B48", Offset = "0xB22B48", VA = "0xB22B48")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xB22C14", Offset = "0xB22C14", VA = "0xB22C14", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xB22EFC", Offset = "0xB22EFC", VA = "0xB22EFC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xB2321C", Offset = "0xB2321C", VA = "0xB2321C", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xB22F0C", Offset = "0xB22F0C", VA = "0xB22F0C")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xB2322C", Offset = "0xB2322C", VA = "0xB2322C")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200010B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6571F8", Offset = "0x6571F8")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xB23244", Offset = "0xB23244", VA = "0xB23244", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xB232A4", Offset = "0xB232A4", VA = "0xB232A4", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xB233F0", Offset = "0xB233F0", VA = "0xB233F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xB235C4", Offset = "0xB235C4", VA = "0xB235C4")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200010C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x65725C", Offset = "0x65725C")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65CF10", Offset = "0x65CF10")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000776")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000777")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x17000091")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0xB23698", Offset = "0xB23698", VA = "0xB23698", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xB235DC", Offset = "0xB235DC", VA = "0xB235DC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xB23668", Offset = "0xB23668", VA = "0xB23668", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xB2379C", Offset = "0xB2379C", VA = "0xB2379C", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xB23CBC", Offset = "0xB23CBC", VA = "0xB23CBC")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xB23EA0", Offset = "0xB23EA0", VA = "0xB23EA0")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200010D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6572C0", Offset = "0x6572C0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6572C0", Offset = "0x6572C0")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x65CF54", Offset = "0x65CF54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65CF54", Offset = "0x65CF54")]
		public Transform gravityTarget;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65CFB4", Offset = "0x65CFB4")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x4000783")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x6000797")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xB24458", Offset = "0xB24458", VA = "0xB24458")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xB245F0", Offset = "0xB245F0", VA = "0xB245F0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xB247DC", Offset = "0xB247DC", VA = "0xB247DC", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xB24A98", Offset = "0xB24A98", VA = "0xB24A98")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xB24B64", Offset = "0xB24B64", VA = "0xB24B64")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xB24DAC", Offset = "0xB24DAC", VA = "0xB24DAC")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xB24FAC", Offset = "0xB24FAC", VA = "0xB24FAC")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xB24FE4", Offset = "0xB24FE4", VA = "0xB24FE4")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xB2501C", Offset = "0xB2501C", VA = "0xB2501C")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xB25120", Offset = "0xB25120", VA = "0xB25120")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x20001A8")]
		public enum MoveMode
		{
			[Token(Token = "0x4000BAA")]
			Directional,
			[Token(Token = "0x4000BAB")]
			Strafe
		}

		[Token(Token = "0x20001A9")]
		public struct AnimState
		{
			[Token(Token = "0x4000BAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000BAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000BAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000BAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000BB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000BB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x4000BB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x65D050", Offset = "0x65D050")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x65D088", Offset = "0x65D088")]
		public MoveMode moveMode;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x65D0C0", Offset = "0x65D0C0")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x65D0F8", Offset = "0x65D0F8")]
		public float airSpeed;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x65D130", Offset = "0x65D130")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMaxLength;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x65D17C", Offset = "0x65D17C")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65D1B4", Offset = "0x65D1B4")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AnimState animState;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool fixedFrame;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float wallRunEndTime;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Vector3 gravity;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float velocityY;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool doubleJumped;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		private bool jumpReleased;

		[Token(Token = "0x17000092")]
		public bool onGround
		{
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0xB2558C", Offset = "0xB2558C", VA = "0xB2558C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x663860", Offset = "0x663860")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0xB25594", Offset = "0xB25594", VA = "0xB25594")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x663870", Offset = "0x663870")]
			private set
			{
			}
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xB255A0", Offset = "0xB255A0", VA = "0xB255A0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xB25738", Offset = "0xB25738", VA = "0xB25738")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xB257DC", Offset = "0xB257DC", VA = "0xB257DC", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xB25918", Offset = "0xB25918", VA = "0xB25918")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xB26A8C", Offset = "0xB26A8C", VA = "0xB26A8C", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xB26E5C", Offset = "0xB26E5C", VA = "0xB26E5C", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xB26074", Offset = "0xB26074", VA = "0xB26074")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xB26F84", Offset = "0xB26F84", VA = "0xB26F84")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xB27630", Offset = "0xB27630", VA = "0xB27630")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xB26B6C", Offset = "0xB26B6C", VA = "0xB26B6C")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xB276D4", Offset = "0xB276D4", VA = "0xB276D4", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xB27C18", Offset = "0xB27C18", VA = "0xB27C18")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xB27E14", Offset = "0xB27E14", VA = "0xB27E14", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xB26604", Offset = "0xB26604", VA = "0xB26604")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xB28040", Offset = "0xB28040", VA = "0xB28040")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200010F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x65734C", Offset = "0x65734C")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001AA")]
		public enum RotationMode
		{
			[Token(Token = "0x4000BB4")]
			Smooth,
			[Token(Token = "0x4000BB5")]
			Linear
		}

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D1C4", Offset = "0x65D1C4")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D210", Offset = "0x65D210")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D25C", Offset = "0x65D25C")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D2A8", Offset = "0x65D2A8")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D2F4", Offset = "0x65D2F4")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D340", Offset = "0x65D340")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65D38C", Offset = "0x65D38C")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x17000093")]
		public bool isGrounded
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xB28FE8", Offset = "0xB28FE8", VA = "0xB28FE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x663880", Offset = "0x663880")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0xB36470", Offset = "0xB36470", VA = "0xB36470")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x663890", Offset = "0x663890")]
			private set
			{
			}
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xB3647C", Offset = "0xB3647C", VA = "0xB3647C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xB36508", Offset = "0xB36508", VA = "0xB36508")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xB36CC0", Offset = "0xB36CC0", VA = "0xB36CC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xB36564", Offset = "0xB36564", VA = "0xB36564")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xB369C0", Offset = "0xB369C0", VA = "0xB369C0")]
		private void Move()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xB36D10", Offset = "0xB36D10", VA = "0xB36D10")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xB36E08", Offset = "0xB36E08", VA = "0xB36E08")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xB36EA8", Offset = "0xB36EA8", VA = "0xB36EA8")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xB39CFC", Offset = "0xB39CFC", VA = "0xB39CFC", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xB39D84", Offset = "0xB39D84", VA = "0xB39D84", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xB3A094", Offset = "0xB3A094", VA = "0xB3A094")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xB3A0E8", Offset = "0xB3A0E8", VA = "0xB3A0E8")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x20001AB")]
		public struct State
		{
			[Token(Token = "0x4000BB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000BB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000BB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000BB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000BBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xB39D44", Offset = "0xB39D44", VA = "0xB39D44", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xB3A248", Offset = "0xB3A248", VA = "0xB3A248", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xB3A104", Offset = "0xB3A104", VA = "0xB3A104")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xB2205C", Offset = "0xB2205C", VA = "0xB2205C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xB22098", Offset = "0xB22098", VA = "0xB22098")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xB36ED4", Offset = "0xB36ED4", VA = "0xB36ED4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xB36F08", Offset = "0xB36F08", VA = "0xB36F08")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xB36FD8", Offset = "0xB36FD8", VA = "0xB36FD8")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000114")]
	public class Navigator
	{
		[Token(Token = "0x20001AC")]
		public enum State
		{
			[Token(Token = "0x4000BBC")]
			Idle,
			[Token(Token = "0x4000BBD")]
			Seeking,
			[Token(Token = "0x4000BBE")]
			OnPath
		}

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D3DC", Offset = "0x65D3DC")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D414", Offset = "0x65D414")]
		public float cornerRadius;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D44C", Offset = "0x65D44C")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D484", Offset = "0x65D484")]
		public float maxSampleDistance;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D4BC", Offset = "0x65D4BC")]
		public float nextPathInterval;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65D4F4", Offset = "0x65D4F4")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65D504", Offset = "0x65D504")]
		private State <state>k__BackingField;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x17000094")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60007C9")]
			[Address(RVA = "0xB318C0", Offset = "0xB318C0", VA = "0xB318C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6638A0", Offset = "0x6638A0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007CA")]
			[Address(RVA = "0xB318CC", Offset = "0xB318CC", VA = "0xB318CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6638B0", Offset = "0x6638B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public State state
		{
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0xB318D8", Offset = "0xB318D8", VA = "0xB318D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6638C0", Offset = "0x6638C0")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60007CC")]
			[Address(RVA = "0xB318E0", Offset = "0xB318E0", VA = "0xB318E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6638D0", Offset = "0x6638D0")]
			private set
			{
			}
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xB318E8", Offset = "0xB318E8", VA = "0xB318E8")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xB319BC", Offset = "0xB319BC", VA = "0xB319BC")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xB31F78", Offset = "0xB31F78", VA = "0xB31F78")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xB31FE8", Offset = "0xB31FE8", VA = "0xB31FE8")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xB31E40", Offset = "0xB31E40", VA = "0xB31E40")]
		private void Stop()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xB31EB4", Offset = "0xB31EB4", VA = "0xB31EB4")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xB32150", Offset = "0xB32150", VA = "0xB32150")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xB323E0", Offset = "0xB323E0", VA = "0xB323E0")]
		public Navigator()
		{
		}
	}
}
namespace RenderHeads.Media.AVProMovieCapture
{
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6573B0", Offset = "0x6573B0")]
	public class CaptureFromCamera : CaptureBase
	{
		[Token(Token = "0x20001AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65773C", Offset = "0x65773C")]
		private sealed class <FinalRenderCapture>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CaptureFromCamera <>4__this;

			[Token(Token = "0x17000126")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AFE")]
				[Address(RVA = "0xFA450C", Offset = "0xFA450C", VA = "0xFA450C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000127")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B00")]
				[Address(RVA = "0xFA457C", Offset = "0xFA457C", VA = "0xFA457C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0xFA35D4", Offset = "0xFA35D4", VA = "0xFA35D4")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0xFA4490", Offset = "0xFA4490", VA = "0xFA4490", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0xFA4494", Offset = "0xFA4494", VA = "0xFA4494", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AFF")]
			[Address(RVA = "0xFA4514", Offset = "0xFA4514", VA = "0xFA4514", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private Camera _lastCamera;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private Camera[] _contribCameras;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private bool _useContributingCameras;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private RenderTexture _target;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private IntPtr _targetNativePointer;

		[Token(Token = "0x17000096")]
		public bool UseContributingCameras
		{
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0xFA2AD0", Offset = "0xFA2AD0", VA = "0xFA2AD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0xFA2AD8", Offset = "0xFA2AD8", VA = "0xFA2AD8")]
			set
			{
			}
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xFA2AE4", Offset = "0xFA2AE4", VA = "0xFA2AE4")]
		public void SetCamera(Camera mainCamera, bool useContributingCameras = true)
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xFA3238", Offset = "0xFA3238", VA = "0xFA3238")]
		public void SetCamera(Camera mainCamera, Camera[] contributingCameras)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xFA3240", Offset = "0xFA3240", VA = "0xFA3240")]
		private bool HasCamera()
		{
			return default(bool);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xFA32B0", Offset = "0xFA32B0", VA = "0xFA32B0")]
		private bool HasContributingCameras()
		{
			return default(bool);
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xFA32D8", Offset = "0xFA32D8", VA = "0xFA32D8", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xFA334C", Offset = "0xFA334C", VA = "0xFA334C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6638E0", Offset = "0x6638E0")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xFA33C0", Offset = "0xFA33C0", VA = "0xFA33C0")]
		private void Capture()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xFA3608", Offset = "0xFA3608", VA = "0xFA3608")]
		private void UpdateTexture()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xFA3D04", Offset = "0xFA3D04", VA = "0xFA3D04", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xFA3DA8", Offset = "0xFA3DA8", VA = "0xFA3DA8", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xFA3DB0", Offset = "0xFA3DB0", VA = "0xFA3DB0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xFA4380", Offset = "0xFA4380", VA = "0xFA4380", Slot = "6")]
		public override void OnDestroy()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xFA4420", Offset = "0xFA4420", VA = "0xFA4420")]
		public CaptureFromCamera()
		{
		}
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6573EC", Offset = "0x6573EC")]
	public class CaptureFromCamera360 : CaptureBase
	{
		[Token(Token = "0x20001AE")]
		private enum CubemapRenderMethod
		{
			[Token(Token = "0x4000BC3")]
			Manual,
			[Token(Token = "0x4000BC4")]
			Unity,
			[Token(Token = "0x4000BC5")]
			Unity2018
		}

		[Token(Token = "0x20001AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65774C", Offset = "0x65774C")]
		private sealed class <FinalRenderCapture>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CaptureFromCamera360 <>4__this;

			[Token(Token = "0x17000128")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B04")]
				[Address(RVA = "0xFA6FC0", Offset = "0xFA6FC0", VA = "0xFA6FC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000129")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B06")]
				[Address(RVA = "0xFA7030", Offset = "0xFA7030", VA = "0xFA7030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B01")]
			[Address(RVA = "0xFA4954", Offset = "0xFA4954", VA = "0xFA4954")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x6000B02")]
			[Address(RVA = "0xFA6F44", Offset = "0xFA6F44", VA = "0xFA6F44", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B03")]
			[Address(RVA = "0xFA6F48", Offset = "0xFA6F48", VA = "0xFA6F48", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B05")]
			[Address(RVA = "0xFA6FC8", Offset = "0xFA6FC8", VA = "0xFA6FC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		public int _cubemapResolution;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		[SerializeField]
		public int _cubemapDepth;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		public bool _supportGUI;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
		[SerializeField]
		public bool _supportCameraRotation;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D584", Offset = "0x65D584")]
		public bool _render180Degrees;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		[SerializeField]
		public StereoPacking _stereoRendering;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D5E0", Offset = "0x65D5E0")]
		public float _ipd;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private Camera _camera;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private RenderTexture _faceTarget;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private Material _blitMaterial;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Material _cubemapToEquirectangularMaterial;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private RenderTexture _cubeTarget;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private RenderTexture _finalTarget;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private IntPtr _targetNativePointer;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private int _propFlipX;

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xFA4584", Offset = "0xFA4584", VA = "0xFA4584")]
		public CaptureFromCamera360()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xFA4610", Offset = "0xFA4610", VA = "0xFA4610")]
		private CubemapRenderMethod GetCubemapRenderingMethod()
		{
			return default(CubemapRenderMethod);
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xFA4648", Offset = "0xFA4648", VA = "0xFA4648")]
		public void SetCamera(Camera camera)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xFA4650", Offset = "0xFA4650", VA = "0xFA4650", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xFA46AC", Offset = "0xFA46AC", VA = "0xFA46AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x663944", Offset = "0x663944")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xFA4720", Offset = "0xFA4720", VA = "0xFA4720")]
		private void Capture()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xFA4F8C", Offset = "0xFA4F8C", VA = "0xFA4F8C")]
		private static void ClearCubemap(RenderTexture texture, Color color)
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xFA5174", Offset = "0xFA5174", VA = "0xFA5174")]
		private void RenderCubemapToEquiRect(RenderTexture cubemap, RenderTexture target, bool supportRotation, Quaternion rotation, bool isEyeLeft)
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xFA4A7C", Offset = "0xFA4A7C", VA = "0xFA4A7C")]
		private void UpdateTexture()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xFA532C", Offset = "0xFA532C", VA = "0xFA532C")]
		private void RenderCameraToCubemap(Camera camera, RenderTexture cubemapTarget)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xFA4980", Offset = "0xFA4980", VA = "0xFA4980")]
		private void AccumulateMotionBlur()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xFA5E54", Offset = "0xFA5E54", VA = "0xFA5E54", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xFA6B88", Offset = "0xFA6B88", VA = "0xFA6B88", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xFA6BCC", Offset = "0xFA6BCC", VA = "0xFA6BCC", Slot = "5")]
		public override void Start()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xFA6D88", Offset = "0xFA6D88", VA = "0xFA6D88", Slot = "6")]
		public override void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000117")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x657428", Offset = "0x657428")]
	public class CaptureFromCamera360ODS : CaptureBase
	{
		[Serializable]
		[Token(Token = "0x20001B0")]
		public class Settings
		{
			[Token(Token = "0x4000BC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public Camera camera;

			[Token(Token = "0x4000BCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660AE4", Offset = "0x660AE4")]
			public bool render180Degrees;

			[Token(Token = "0x4000BCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660B30", Offset = "0x660B30")]
			public float ipd;

			[Token(Token = "0x4000BCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660B7C", Offset = "0x660B7C")]
			public int pixelSliceSize;

			[Token(Token = "0x4000BCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x660BC8", Offset = "0x660BC8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660BC8", Offset = "0x660BC8")]
			public int paddingSize;

			[Token(Token = "0x4000BCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			public CameraClearFlags cameraClearMode;

			[Token(Token = "0x4000BCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[SerializeField]
			public Color cameraClearColor;

			[Token(Token = "0x4000BD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[SerializeField]
			public Behaviour[] cameraImageEffects;

			[Token(Token = "0x6000B07")]
			[Address(RVA = "0xFA70DC", Offset = "0xFA70DC", VA = "0xFA70DC")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x20001B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65775C", Offset = "0x65775C")]
		private sealed class <FinalRenderCapture>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CaptureFromCamera360ODS <>4__this;

			[Token(Token = "0x1700012A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B0B")]
				[Address(RVA = "0xFA9400", Offset = "0xFA9400", VA = "0xFA9400", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B0D")]
				[Address(RVA = "0xFA9470", Offset = "0xFA9470", VA = "0xFA9470", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B08")]
			[Address(RVA = "0xFA7DBC", Offset = "0xFA7DBC", VA = "0xFA7DBC")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x6000B09")]
			[Address(RVA = "0xFA9384", Offset = "0xFA9384", VA = "0xFA9384", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0xFA9388", Offset = "0xFA9388", VA = "0xFA9388", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0xFA9408", Offset = "0xFA9408", VA = "0xFA9408", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private Settings _settings;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private int _eyeWidth;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private int _eyeHeight;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Transform _cameraGroup;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Camera _leftCameraTop;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Camera _leftCameraBot;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private Camera _rightCameraTop;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Camera _rightCameraBot;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private RenderTexture _final;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private IntPtr _targetNativePointer;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Material _finalMaterial;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private int _propSliceCenter;

		[Token(Token = "0x17000097")]
		public Settings Setup
		{
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0xFA7038", Offset = "0xFA7038", VA = "0xFA7038")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xFA7040", Offset = "0xFA7040", VA = "0xFA7040")]
		public CaptureFromCamera360ODS()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xFA712C", Offset = "0xFA712C", VA = "0xFA712C")]
		public void SetCamera(Camera camera)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xFA715C", Offset = "0xFA715C", VA = "0xFA715C", Slot = "5")]
		public override void Start()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xFA726C", Offset = "0xFA726C", VA = "0xFA726C")]
		private Camera CreateEye(Camera camera, string gameObjectName, float yRot, float xOffset, int cameraTargetHeight, int cullingMask, float fov, float aspect, int aalevel)
		{
			return null;
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xFA7B24", Offset = "0xFA7B24", VA = "0xFA7B24", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xFA7B80", Offset = "0xFA7B80", VA = "0xFA7B80")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6639A8", Offset = "0x6639A8")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xFA7BF4", Offset = "0xFA7BF4", VA = "0xFA7BF4")]
		private void Capture()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xFA7DE8", Offset = "0xFA7DE8", VA = "0xFA7DE8")]
		private void AccumulateMotionBlur()
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xFA7EF4", Offset = "0xFA7EF4", VA = "0xFA7EF4")]
		private void RenderFrame()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xFA8468", Offset = "0xFA8468", VA = "0xFA8468", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xFA84AC", Offset = "0xFA84AC", VA = "0xFA84AC", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xFA90DC", Offset = "0xFA90DC", VA = "0xFA90DC")]
		private static void DestroyEye(Camera camera)
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xFA91C8", Offset = "0xFA91C8", VA = "0xFA91C8", Slot = "6")]
		public override void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000118")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x657464", Offset = "0x657464")]
	public class CaptureFromScreen : CaptureBase
	{
		[Token(Token = "0x20001B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65776C", Offset = "0x65776C")]
		private sealed class <FinalRenderCapture>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CaptureFromScreen <>4__this;

			[Token(Token = "0x1700012C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B11")]
				[Address(RVA = "0xFA998C", Offset = "0xFA998C", VA = "0xFA998C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B13")]
				[Address(RVA = "0xFA99FC", Offset = "0xFA99FC", VA = "0xFA99FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0xFA96E0", Offset = "0xFA96E0", VA = "0xFA96E0")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0xFA97B8", Offset = "0xFA97B8", VA = "0xFA97B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B10")]
			[Address(RVA = "0xFA97BC", Offset = "0xFA97BC", VA = "0xFA97BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B12")]
			[Address(RVA = "0xFA9994", Offset = "0xFA9994", VA = "0xFA9994", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xFA9478", Offset = "0xFA9478", VA = "0xFA9478", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xFA966C", Offset = "0xFA966C", VA = "0xFA966C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x663A0C", Offset = "0x663A0C")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xFA970C", Offset = "0xFA970C", VA = "0xFA970C", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xFA9754", Offset = "0xFA9754", VA = "0xFA9754")]
		public CaptureFromScreen()
		{
		}
	}
	[Token(Token = "0x2000119")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6574A0", Offset = "0x6574A0")]
	public class CaptureFromTexture : CaptureBase
	{
		[Token(Token = "0x20001B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65777C", Offset = "0x65777C")]
		private sealed class <FinalRenderCapture>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CaptureFromTexture <>4__this;

			[Token(Token = "0x1700012E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B17")]
				[Address(RVA = "0xFAA9CC", Offset = "0xFAA9CC", VA = "0xFAA9CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B19")]
				[Address(RVA = "0xFAAA3C", Offset = "0xFAAA3C", VA = "0xFAAA3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B14")]
			[Address(RVA = "0xFAA464", Offset = "0xFAA464", VA = "0xFAA464")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000B15")]
			[Address(RVA = "0xFAA950", Offset = "0xFAA950", VA = "0xFAA950", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B16")]
			[Address(RVA = "0xFAA954", Offset = "0xFAA954", VA = "0xFAA954", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B18")]
			[Address(RVA = "0xFAA9D4", Offset = "0xFAA9D4", VA = "0xFAA9D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D64C", Offset = "0x65D64C")]
		[SerializeField]
		private bool _manualUpdate;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Texture _sourceTexture;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private RenderTexture _renderTexture;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private IntPtr _targetNativePointer;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public bool _isSourceTextureChanged;

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xFA9A04", Offset = "0xFA9A04", VA = "0xFA9A04")]
		public void SetSourceTexture(Texture texture)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xFAA068", Offset = "0xFAA068", VA = "0xFAA068")]
		public void UpdateSourceTexture()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xFAA074", Offset = "0xFAA074", VA = "0xFAA074")]
		private bool ShouldCaptureFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xFAA104", Offset = "0xFAA104", VA = "0xFAA104")]
		private bool HasSourceTextureChanged()
		{
			return default(bool);
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xFAA124", Offset = "0xFAA124", VA = "0xFAA124", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xFAA170", Offset = "0xFAA170", VA = "0xFAA170")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x663A70", Offset = "0x663A70")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xFAA1E4", Offset = "0xFAA1E4", VA = "0xFAA1E4")]
		private void Capture()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xFAA490", Offset = "0xFAA490", VA = "0xFAA490")]
		private void AccumulateMotionBlur()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xFAA550", Offset = "0xFAA550", VA = "0xFAA550", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xFAA5F8", Offset = "0xFAA5F8", VA = "0xFAA5F8", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xFAA84C", Offset = "0xFAA84C", VA = "0xFAA84C", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xFAA8E8", Offset = "0xFAA8E8", VA = "0xFAA8E8")]
		public CaptureFromTexture()
		{
		}
	}
	[Token(Token = "0x200011A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6574DC", Offset = "0x6574DC")]
	public class CaptureGUI : MonoBehaviour
	{
		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CaptureBase _movieCapture;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool _showUI;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool _whenRecordingAutoHideUI;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GUISkin _guiSkin;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _shownSection;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string[] _videoCodecNames;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string[] _audioCodecNames;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool[] _videoCodecConfigurable;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool[] _audioCodecConfigurable;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string[] _audioDeviceNames;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string[] _downScales;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string[] _frameRates;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string[] _outputType;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _downScaleIndex;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int _frameRateIndex;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector2 _videoPos;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector2 _audioPos;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector2 _audioCodecPos;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private long _lastFileSize;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private uint _lastEncodedMinutes;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private uint _lastEncodedSeconds;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private uint _lastEncodedFrame;

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xFAAA44", Offset = "0xFAAA44", VA = "0xFAAA44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xFAAACC", Offset = "0xFAAACC", VA = "0xFAAACC")]
		private void CreateGUI()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xFABA20", Offset = "0xFABA20", VA = "0xFABA20")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xFABC90", Offset = "0xFABC90", VA = "0xFABC90")]
		private void MyWindow(int id)
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xFAD52C", Offset = "0xFAD52C", VA = "0xFAD52C")]
		private void GUI_RecordingStatus()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xFAE898", Offset = "0xFAE898", VA = "0xFAE898")]
		private void DrawGuiField(string a, string b)
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xFAE634", Offset = "0xFAE634", VA = "0xFAE634")]
		private void StartCapture()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xFAEB08", Offset = "0xFAEB08", VA = "0xFAEB08")]
		private void StopCapture()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xFAEA70", Offset = "0xFAEA70", VA = "0xFAEA70")]
		private void CancelCapture()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xFAE9D8", Offset = "0xFAE9D8", VA = "0xFAE9D8")]
		private void ResumeCapture()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xFAE940", Offset = "0xFAE940", VA = "0xFAE940")]
		private void PauseCapture()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xFAEBAC", Offset = "0xFAEBAC", VA = "0xFAEBAC")]
		private void Update()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xFAEDC4", Offset = "0xFAEDC4", VA = "0xFAEDC4")]
		public CaptureGUI()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x657518", Offset = "0x657518")]
	public class MotionBlur : MonoBehaviour
	{
		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public RenderTextureFormat _format;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _numSamples;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RenderTexture _accum;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture _lastComp;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material _addMaterial;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material _divMaterial;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _frameCount;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _targetWidth;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _targetHeight;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool _isDirty;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _propNumSamples;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int _propWeight;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65D6B8", Offset = "0x65D6B8")]
		private bool <IsFrameAccumulated>k__BackingField;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public float _bias;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _total;

		[Token(Token = "0x17000098")]
		public bool IsFrameAccumulated
		{
			[Token(Token = "0x600081E")]
			[Address(RVA = "0xFA3600", Offset = "0xFA3600", VA = "0xFA3600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x663AD4", Offset = "0x663AD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600081F")]
			[Address(RVA = "0xFB09E8", Offset = "0xFB09E8", VA = "0xFB09E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x663AE4", Offset = "0x663AE4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public int NumSamples
		{
			[Token(Token = "0x6000820")]
			[Address(RVA = "0xFB09F4", Offset = "0xFB09F4", VA = "0xFB09F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000821")]
			[Address(RVA = "0xFA08FC", Offset = "0xFA08FC", VA = "0xFA08FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public int FrameCount
		{
			[Token(Token = "0x6000822")]
			[Address(RVA = "0xFB0AF4", Offset = "0xFB0AF4", VA = "0xFB0AF4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009B")]
		public RenderTexture FinalTexture
		{
			[Token(Token = "0x6000823")]
			[Address(RVA = "0xFA3BA0", Offset = "0xFA3BA0", VA = "0xFA3BA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xFB0AFC", Offset = "0xFB0AFC", VA = "0xFB0AFC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xFA0904", Offset = "0xFA0904", VA = "0xFA0904")]
		public void SetTargetSize(int width, int height)
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xFB0B90", Offset = "0xFB0B90", VA = "0xFB0B90")]
		private void Start()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xFB0EA4", Offset = "0xFB0EA4", VA = "0xFB0EA4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xFB0B94", Offset = "0xFB0B94", VA = "0xFB0B94")]
		private void Setup()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xFB0EB0", Offset = "0xFB0EB0", VA = "0xFB0EB0")]
		private void ClearAccumulation()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xFB0F08", Offset = "0xFB0F08", VA = "0xFB0F08")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xFB09FC", Offset = "0xFB09FC", VA = "0xFB09FC")]
		public void OnNumSamplesChanged()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xFB1100", Offset = "0xFB1100", VA = "0xFB1100")]
		private static float LerpUnclamped(float a, float b, float t)
		{
			return default(float);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xFB1110", Offset = "0xFB1110", VA = "0xFB1110")]
		private void ApplyWeighting()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xFA5D48", Offset = "0xFA5D48", VA = "0xFA5D48")]
		public void Accumulate(Texture src)
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xFB1238", Offset = "0xFB1238", VA = "0xFB1238")]
		private void OnRenderImage(RenderTexture src, RenderTexture dst)
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xFB12C4", Offset = "0xFB12C4", VA = "0xFB12C4")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x200011C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x657554", Offset = "0x657554")]
	public class MouseCursor : MonoBehaviour
	{
		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Texture2D _texture;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _hotspotOffset;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65D6F8", Offset = "0x65D6F8")]
		private int _sizeScale;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _depth;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GUIContent _content;

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xFB12E0", Offset = "0xFB12E0", VA = "0xFB12E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xFB12E8", Offset = "0xFB12E8", VA = "0xFB12E8")]
		public void SetTexture(Texture2D texture)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xFB1390", Offset = "0xFB1390", VA = "0xFB1390")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xFB14DC", Offset = "0xFB14DC", VA = "0xFB14DC")]
		public MouseCursor()
		{
		}
	}
	[Token(Token = "0x200011D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x657590", Offset = "0x657590")]
	public class UnityAudioCapture : MonoBehaviour
	{
		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _debugLogging;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _muteAudio;

		[Token(Token = "0x4000837")]
		private const int BufferSize = 16;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float[] _buffer;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float[] _readBuffer;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _bufferIndex;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private GCHandle _bufferHandle;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _numChannels;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _overflowCount;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private object _lockObject;

		[Token(Token = "0x1700009C")]
		public float[] Buffer
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0xFB1928", Offset = "0xFB1928", VA = "0xFB1928")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public int BufferLength
		{
			[Token(Token = "0x6000836")]
			[Address(RVA = "0xFB1930", Offset = "0xFB1930", VA = "0xFB1930")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009E")]
		public int NumChannels
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0xFA092C", Offset = "0xFA092C", VA = "0xFA092C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009F")]
		public IntPtr BufferPtr
		{
			[Token(Token = "0x6000838")]
			[Address(RVA = "0xFB1938", Offset = "0xFB1938", VA = "0xFB1938")]
			get
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x170000A0")]
		public int OverflowCount
		{
			[Token(Token = "0x6000839")]
			[Address(RVA = "0xFAE938", Offset = "0xFAE938", VA = "0xFAE938")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xFB1944", Offset = "0xFB1944", VA = "0xFB1944")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xFB1E00", Offset = "0xFB1E00", VA = "0xFB1E00")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xF9EC34", Offset = "0xF9EC34", VA = "0xF9EC34")]
		public IntPtr ReadData(out int length)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xFA0CA4", Offset = "0xFA0CA4", VA = "0xFA0CA4")]
		public void FlushBuffer()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xFB1ED0", Offset = "0xFB1ED0", VA = "0xFB1ED0")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xFB1DDC", Offset = "0xFB1DDC", VA = "0xFB1DDC")]
		public static int GetNumChannels(AudioSpeakerMode mode)
		{
			return default(int);
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xFB21B8", Offset = "0xFB21B8", VA = "0xFB21B8")]
		public UnityAudioCapture()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class CaptureBase : MonoBehaviour
	{
		[Token(Token = "0x20001B4")]
		public enum FrameRate
		{
			[Token(Token = "0x4000BDB")]
			One = 1,
			[Token(Token = "0x4000BDC")]
			Ten = 10,
			[Token(Token = "0x4000BDD")]
			Fifteen = 15,
			[Token(Token = "0x4000BDE")]
			TwentyFour = 24,
			[Token(Token = "0x4000BDF")]
			TwentyFive = 25,
			[Token(Token = "0x4000BE0")]
			Thirty = 30,
			[Token(Token = "0x4000BE1")]
			Fifty = 50,
			[Token(Token = "0x4000BE2")]
			Sixty = 60,
			[Token(Token = "0x4000BE3")]
			SeventyFive = 75,
			[Token(Token = "0x4000BE4")]
			Ninety = 90,
			[Token(Token = "0x4000BE5")]
			OneTwenty = 120
		}

		[Token(Token = "0x20001B5")]
		public enum Resolution
		{
			[Token(Token = "0x4000BE7")]
			POW2_8192x8192,
			[Token(Token = "0x4000BE8")]
			POW2_8192x4096,
			[Token(Token = "0x4000BE9")]
			POW2_4096x4096,
			[Token(Token = "0x4000BEA")]
			POW2_4096x2048,
			[Token(Token = "0x4000BEB")]
			POW2_2048x4096,
			[Token(Token = "0x4000BEC")]
			UHD_3840x2160,
			[Token(Token = "0x4000BED")]
			UHD_3840x2048,
			[Token(Token = "0x4000BEE")]
			UHD_3840x1920,
			[Token(Token = "0x4000BEF")]
			POW2_2048x2048,
			[Token(Token = "0x4000BF0")]
			POW2_2048x1024,
			[Token(Token = "0x4000BF1")]
			HD_1920x1080,
			[Token(Token = "0x4000BF2")]
			HD_1280x720,
			[Token(Token = "0x4000BF3")]
			SD_1024x768,
			[Token(Token = "0x4000BF4")]
			SD_800x600,
			[Token(Token = "0x4000BF5")]
			SD_800x450,
			[Token(Token = "0x4000BF6")]
			SD_640x480,
			[Token(Token = "0x4000BF7")]
			SD_640x360,
			[Token(Token = "0x4000BF8")]
			SD_320x240,
			[Token(Token = "0x4000BF9")]
			Original,
			[Token(Token = "0x4000BFA")]
			Custom
		}

		[Token(Token = "0x20001B6")]
		public enum CubemapDepth
		{
			[Token(Token = "0x4000BFC")]
			Depth_24 = 24,
			[Token(Token = "0x4000BFD")]
			Depth_16 = 16,
			[Token(Token = "0x4000BFE")]
			Depth_Zero = 0
		}

		[Token(Token = "0x20001B7")]
		public enum CubemapResolution
		{
			[Token(Token = "0x4000C00")]
			POW2_4096 = 4096,
			[Token(Token = "0x4000C01")]
			POW2_2048 = 2048,
			[Token(Token = "0x4000C02")]
			POW2_1024 = 1024,
			[Token(Token = "0x4000C03")]
			POW2_512 = 512,
			[Token(Token = "0x4000C04")]
			POW2_256 = 256
		}

		[Token(Token = "0x20001B8")]
		public enum AntiAliasingLevel
		{
			[Token(Token = "0x4000C06")]
			UseCurrent,
			[Token(Token = "0x4000C07")]
			ForceNone,
			[Token(Token = "0x4000C08")]
			ForceSample2,
			[Token(Token = "0x4000C09")]
			ForceSample4,
			[Token(Token = "0x4000C0A")]
			ForceSample8
		}

		[Token(Token = "0x20001B9")]
		public enum DownScale
		{
			[Token(Token = "0x4000C0C")]
			Original = 1,
			[Token(Token = "0x4000C0D")]
			Half = 2,
			[Token(Token = "0x4000C0E")]
			Quarter = 4,
			[Token(Token = "0x4000C0F")]
			Eighth = 8,
			[Token(Token = "0x4000C10")]
			Sixteenth = 16,
			[Token(Token = "0x4000C11")]
			Custom = 100
		}

		[Token(Token = "0x20001BA")]
		public enum OutputPath
		{
			[Token(Token = "0x4000C13")]
			RelativeToProject,
			[Token(Token = "0x4000C14")]
			RelativeToPeristentData,
			[Token(Token = "0x4000C15")]
			Absolute
		}

		[Token(Token = "0x20001BB")]
		public enum OutputExtension
		{
			[Token(Token = "0x4000C17")]
			AVI = 0,
			[Token(Token = "0x4000C18")]
			MP4 = 1,
			[Token(Token = "0x4000C19")]
			PNG = 2,
			[Token(Token = "0x4000C1A")]
			Custom = 100
		}

		[Token(Token = "0x20001BC")]
		public enum OutputType
		{
			[Token(Token = "0x4000C1C")]
			VideoFile,
			[Token(Token = "0x4000C1D")]
			ImageSequence,
			[Token(Token = "0x4000C1E")]
			NamedPipe
		}

		[Serializable]
		[Token(Token = "0x20001BD")]
		public class PostCaptureSettings
		{
			[Token(Token = "0x4000C1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x660C5C", Offset = "0x660C5C")]
			public bool writeFastStartStreamingForMp4;

			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0xFA2ABC", Offset = "0xFA2ABC", VA = "0xFA2ABC")]
			public PostCaptureSettings()
			{
			}
		}

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PostCaptureSettings _postCaptureSettings;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public KeyCode _captureKey;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool _captureOnStart;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool _startPaused;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool _listVideoCodecsOnStart;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool _isRealTime;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _persistAcrossSceneLoads;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public StopMode _stopMode;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int _stopFrames;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float _stopSeconds;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool _useMediaFoundationH264;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string[] _videoCodecPriority;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FrameRate _frameRate;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D798", Offset = "0x65D798")]
		private int _timelapseScale;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public DownScale _downScale;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector2 _maxVideoSize;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int _forceVideoCodecIndex;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool _flipVertically;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool _supportAlpha;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D7E4", Offset = "0x65D7E4")]
		[SerializeField]
		private bool _forceGpuFlush;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65D830", Offset = "0x65D830")]
		[SerializeField]
		protected bool _useWaitForEndOfFrame;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool _noAudio;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string[] _audioCodecPriority;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int _forceAudioCodecIndex;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int _forceAudioDeviceIndex;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public UnityAudioCapture _audioCapture;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool _autoGenerateFilename;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public OutputPath _outputFolderType;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string _outputFolderPath;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string _autoFilenamePrefix;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string _autoFilenameExtension;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string _forceFilename;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int _imageSequenceStartFrame;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65D87C", Offset = "0x65D87C")]
		public int _imageSequenceZeroDigits;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public OutputType _outputType;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public ImageSequenceFormat _imageSequenceFormat;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Resolution _renderResolution;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Vector2 _renderSize;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public int _renderAntiAliasing;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool _useMotionBlur;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65D894", Offset = "0x65D894")]
		public int _motionBlurSamples;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Camera[] _motionBlurCameras;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected MotionBlur _motionBlur;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool _allowVSyncDisable;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		[SerializeField]
		protected bool _supportTextureRecreate;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE2")]
		public bool _captureMouseCursor;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public MouseCursor _mouseCursor;

		[NonSerialized]
		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public string _codecName;

		[NonSerialized]
		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public int _codecIndex;

		[NonSerialized]
		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public string _audioCodecName;

		[NonSerialized]
		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public int _audioCodecIndex;

		[NonSerialized]
		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public string _audioDeviceName;

		[NonSerialized]
		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public int _audioDeviceIndex;

		[NonSerialized]
		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public int _unityAudioSampleRate;

		[NonSerialized]
		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public int _unityAudioChannelCount;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		protected Texture2D _texture;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		protected int _handle;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		protected int _targetWidth;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		protected int _targetHeight;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		protected bool _capturing;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13D")]
		protected bool _paused;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		protected string _filePath;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		protected FileInfo _fileInfo;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		protected NativePlugin.PixelFormat _pixelFormat;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private int _oldVSyncCount;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float _oldFixedDeltaTime;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		protected bool _isTopDown;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15D")]
		protected bool _isDirectX11;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15E")]
		private bool _queuedStartCapture;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15F")]
		private bool _queuedStopCapture;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float _captureStartTime;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float _timeSinceLastFrame;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		protected YieldInstruction _waitForEndOfFrame;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public int _minimumDiskSpaceMB;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private long _freeDiskSpaceMB;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private uint _numDroppedFrames;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private uint _numDroppedEncoderFrames;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private uint _numEncodedFrames;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private uint _totalEncodedSeconds;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _isInitialised;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		protected IntPtr _renderEventFunction;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		protected IntPtr _freeEventFunction;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float _fps;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private int _frameTotal;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private int _frameCount;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private float _startFrameTime;

		[Token(Token = "0x170000A1")]
		public string LastFilePath
		{
			[Token(Token = "0x6000841")]
			[Address(RVA = "0xF9CB2C", Offset = "0xF9CB2C", VA = "0xF9CB2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		public uint NumDroppedFrames
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0xF9CB34", Offset = "0xF9CB34", VA = "0xF9CB34")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x170000A3")]
		public uint NumDroppedEncoderFrames
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0xF9CB3C", Offset = "0xF9CB3C", VA = "0xF9CB3C")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x170000A4")]
		public uint NumEncodedFrames
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0xF9CB44", Offset = "0xF9CB44", VA = "0xF9CB44")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x170000A5")]
		public uint TotalEncodedSeconds
		{
			[Token(Token = "0x6000845")]
			[Address(RVA = "0xF9CB4C", Offset = "0xF9CB4C", VA = "0xF9CB4C")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x170000A6")]
		public string[] VideoCodecPriority
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0xF9CB54", Offset = "0xF9CB54", VA = "0xF9CB54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000847")]
			[Address(RVA = "0xF9CB5C", Offset = "0xF9CB5C", VA = "0xF9CB5C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public int TimelapseScale
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0xF9CF18", Offset = "0xF9CF18", VA = "0xF9CF18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000849")]
			[Address(RVA = "0xF9CF20", Offset = "0xF9CF20", VA = "0xF9CF20")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public bool UseWaitForEndOfFrame
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0xF9CF28", Offset = "0xF9CF28", VA = "0xF9CF28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600084B")]
			[Address(RVA = "0xF9CF30", Offset = "0xF9CF30", VA = "0xF9CF30")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public PostCaptureSettings PostCapture
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0xF9CF3C", Offset = "0xF9CF3C", VA = "0xF9CF3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		public static string LastFileSaved
		{
			[Token(Token = "0x600086D")]
			[Address(RVA = "0xFA10D8", Offset = "0xFA10D8", VA = "0xFA10D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086E")]
			[Address(RVA = "0xFA1138", Offset = "0xFA1138", VA = "0xFA1138")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public float FPS
		{
			[Token(Token = "0x600087E")]
			[Address(RVA = "0xFA23E4", Offset = "0xFA23E4", VA = "0xFA23E4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000AC")]
		public float FramesTotal
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0xFA23EC", Offset = "0xFA23EC", VA = "0xFA23EC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xF9CF44", Offset = "0xF9CF44", VA = "0xF9CF44", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xF9D80C", Offset = "0xF9D80C", VA = "0xF9D80C")]
		protected void SetupRenderFunctions()
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xF9DF94", Offset = "0xF9DF94", VA = "0xF9DF94", Slot = "5")]
		public virtual void Start()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xF9CB68", Offset = "0xF9CB68", VA = "0xF9CB68")]
		public void SelectCodec(bool listCodecs)
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xF9D838", Offset = "0xF9D838", VA = "0xF9D838")]
		public void SelectAudioCodec(bool listCodecs)
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xF9DBF8", Offset = "0xF9DBF8", VA = "0xF9DBF8")]
		public void SelectAudioDevice(bool display)
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xF9E570", Offset = "0xF9E570", VA = "0xF9E570")]
		public static Vector2 GetRecordingResolution(int width, int height, DownScale downscale, Vector2 maxVideoSize)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xF9E698", Offset = "0xF9E698", VA = "0xF9E698")]
		public void SelectRecordingResolution(int width, int height)
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xF9E7B4", Offset = "0xF9E7B4", VA = "0xF9E7B4", Slot = "6")]
		public virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xF9E7C8", Offset = "0xF9E7C8", VA = "0xF9E7C8")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xF9E900", Offset = "0xF9E900", VA = "0xF9E900")]
		protected void EncodeTexture(Texture2D texture)
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xF9E990", Offset = "0xF9E990", VA = "0xF9E990")]
		protected bool IsUsingUnityAudio()
		{
			return default(bool);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xF9EA28", Offset = "0xF9EA28", VA = "0xF9EA28")]
		protected bool IsRecordingUnityAudio()
		{
			return default(bool);
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xF9EA74", Offset = "0xF9EA74", VA = "0xF9EA74")]
		protected bool IsUsingMotionBlur()
		{
			return default(bool);
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xF9EB04", Offset = "0xF9EB04", VA = "0xF9EB04", Slot = "7")]
		public virtual void EncodePointer(IntPtr ptr)
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xF9EDCC", Offset = "0xF9EDCC", VA = "0xF9EDCC")]
		public bool IsCapturing()
		{
			return default(bool);
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xF9EDD4", Offset = "0xF9EDD4", VA = "0xF9EDD4")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xF9EDDC", Offset = "0xF9EDDC", VA = "0xF9EDDC")]
		public int GetRecordingWidth()
		{
			return default(int);
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xF9EDE4", Offset = "0xF9EDE4", VA = "0xF9EDE4")]
		public int GetRecordingHeight()
		{
			return default(int);
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xF9EDEC", Offset = "0xF9EDEC", VA = "0xF9EDEC", Slot = "8")]
		protected virtual string GenerateTimestampedFilename(string filenamePrefix, string filenameExtension)
		{
			return null;
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xF9F220", Offset = "0xF9F220", VA = "0xF9F220")]
		private static string GetFolder(OutputPath outputPathType, string path)
		{
			return null;
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xF9F338", Offset = "0xF9F338", VA = "0xF9F338")]
		private static string AutoGenerateFilename(OutputPath outputPathType, string path, string filename)
		{
			return null;
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xF9F3E8", Offset = "0xF9F3E8", VA = "0xF9F3E8")]
		private static string ManualGenerateFilename(OutputPath outputPathType, string path, string filename)
		{
			return null;
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xF9F4D4", Offset = "0xF9F4D4", VA = "0xF9F4D4")]
		protected static bool HasExtension(string path, string extension)
		{
			return default(bool);
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xF9F524", Offset = "0xF9F524", VA = "0xF9F524")]
		protected void GenerateFilename()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xF9F9D0", Offset = "0xF9F9D0", VA = "0xF9F9D0", Slot = "9")]
		public virtual bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xFA0C98", Offset = "0xFA0C98", VA = "0xFA0C98")]
		public void QueueStartCapture()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xF9E018", Offset = "0xF9E018", VA = "0xF9E018")]
		public bool StartCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xFA0E1C", Offset = "0xFA0E1C", VA = "0xFA0E1C")]
		public void PauseCapture()
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xFA0F38", Offset = "0xFA0F38", VA = "0xFA0F38")]
		public void ResumeCapture()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xFA0FE0", Offset = "0xFA0FE0", VA = "0xFA0FE0")]
		public void CancelCapture()
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xFA1038", Offset = "0xFA1038", VA = "0xFA1038", Slot = "10")]
		public virtual void UnprepareCapture()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xFA118C", Offset = "0xFA118C", VA = "0xFA118C")]
		protected void RenderThreadEvent(NativePlugin.PluginEvent renderEvent)
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xFA1238", Offset = "0xFA1238", VA = "0xFA1238", Slot = "11")]
		public virtual void StopCapture(bool skipPendingFrames = false)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xFA1698", Offset = "0xFA1698", VA = "0xFA1698")]
		protected void ApplyPostOperations(string path)
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xFA1CC0", Offset = "0xFA1CC0", VA = "0xFA1CC0")]
		private void ToggleCapture()
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xFA1CDC", Offset = "0xFA1CDC", VA = "0xFA1CDC")]
		private bool IsEnoughDiskSpace()
		{
			return default(bool);
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xFA1CE4", Offset = "0xFA1CE4", VA = "0xFA1CE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xFA1D40", Offset = "0xFA1D40", VA = "0xFA1D40")]
		private void CheckFreeDiskSpace()
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xFA1D7C", Offset = "0xFA1D7C", VA = "0xFA1D7C")]
		protected bool IsProgressComplete()
		{
			return default(bool);
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xFA1E14", Offset = "0xFA1E14", VA = "0xFA1E14")]
		public float GetProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xFA0DF4", Offset = "0xFA0DF4", VA = "0xFA0DF4")]
		protected float GetSecondsPerCaptureFrame()
		{
			return default(float);
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xFA1EB4", Offset = "0xFA1EB4", VA = "0xFA1EB4")]
		protected bool CanOutputFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xFA2024", Offset = "0xFA2024", VA = "0xFA2024")]
		protected void TickFrameTimer()
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xFA205C", Offset = "0xFA205C", VA = "0xFA205C")]
		protected void RenormTimer()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xFA2098", Offset = "0xFA2098", VA = "0xFA2098", Slot = "12")]
		public virtual Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xFA20A0", Offset = "0xFA20A0", VA = "0xFA20A0", Slot = "13")]
		public virtual void UpdateFrame()
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0xFA0DEC", Offset = "0xFA0DEC", VA = "0xFA0DEC")]
		protected void ResetFPS()
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xFA23F8", Offset = "0xFA23F8", VA = "0xFA23F8")]
		public void UpdateFPS()
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xFA2460", Offset = "0xFA2460", VA = "0xFA2460")]
		protected int GetCameraAntiAliasingLevel(Camera camera)
		{
			return default(int);
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xFA2624", Offset = "0xFA2624", VA = "0xFA2624")]
		private void ConfigureCodec()
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xFA2700", Offset = "0xFA2700", VA = "0xFA2700")]
		public long GetCaptureFileSize()
		{
			return default(long);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xFA27E0", Offset = "0xFA27E0", VA = "0xFA27E0")]
		public static void GetResolution(Resolution res, ref int width, ref int height)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xF9E68C", Offset = "0xF9E68C", VA = "0xF9E68C")]
		protected static int NextMultipleOf4(int value)
		{
			return default(int);
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xFA280C", Offset = "0xFA280C", VA = "0xFA280C")]
		public CaptureBase()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class MP4FileProcessing
	{
		[Token(Token = "0x20001BE")]
		private class Chunk
		{
			[Token(Token = "0x4000C20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint id;

			[Token(Token = "0x4000C21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public long size;

			[Token(Token = "0x4000C22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public long offset;

			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0xFB010C", Offset = "0xFB010C", VA = "0xFB010C")]
			public Chunk()
			{
			}
		}

		[Token(Token = "0x4000895")]
		private const int ChunkHeaderSize = 8;

		[Token(Token = "0x4000896")]
		private const int CopyBufferSize = 65536;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint Atom_moov;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static uint Atom_mdat;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static uint Atom_cmov;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static uint Atom_trak;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static uint Atom_mdia;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static uint Atom_minf;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static uint Atom_stbl;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static uint Atom_stco;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static uint Atom_co64;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BinaryReader _reader;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Stream _writeFile;

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xFA1840", Offset = "0xFA1840", VA = "0xFA1840")]
		public static bool ApplyFastStart(string filePath, bool keepBackup)
		{
			return default(bool);
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xFAEEC8", Offset = "0xFAEEC8", VA = "0xFAEEC8")]
		public static bool ApplyFastStart(string srcPath, string dstPath)
		{
			return default(bool);
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xFAF23C", Offset = "0xFAF23C", VA = "0xFAF23C")]
		public bool Open(Stream srcStream, Stream dstStream)
		{
			return default(bool);
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xFAF54C", Offset = "0xFAF54C", VA = "0xFAF54C")]
		public void Close()
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xFAF7C4", Offset = "0xFAF7C4", VA = "0xFAF7C4")]
		private static Chunk GetFirstChunkOfType(uint id, List<Chunk> chunks)
		{
			return null;
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xFAF580", Offset = "0xFAF580", VA = "0xFAF580")]
		private List<Chunk> ReadChildChunks(Chunk parentChunk)
		{
			return null;
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xFAFEFC", Offset = "0xFAFEFC", VA = "0xFAFEFC")]
		private Chunk ReadChunkHeader()
		{
			return null;
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xFAF8F8", Offset = "0xFAF8F8", VA = "0xFAF8F8")]
		private bool ChunkContainsChildChunkWithId(Chunk chunk, uint id)
		{
			return default(bool);
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xFAFE70", Offset = "0xFAFE70", VA = "0xFAFE70")]
		private void WriteChunk(Chunk chunk)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xFB0384", Offset = "0xFB0384", VA = "0xFB0384")]
		private void WriteChunkHeader(Chunk chunk)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xFB0254", Offset = "0xFB0254", VA = "0xFB0254")]
		private void CopyBytes(long numBytes)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xFAFA70", Offset = "0xFAFA70", VA = "0xFAFA70")]
		private void WriteChunk_moov(Chunk parentChunk, ulong byteOffset)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xFB0114", Offset = "0xFB0114", VA = "0xFB0114")]
		private uint ReadUInt32()
		{
			return default(uint);
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xFB01B4", Offset = "0xFB01B4", VA = "0xFB01B4")]
		private ulong ReadUInt64()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xFB0410", Offset = "0xFB0410", VA = "0xFB0410")]
		private void WriteUInt32(uint value, bool isBigEndian = true)
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xFB04E0", Offset = "0xFB04E0", VA = "0xFB04E0")]
		private void WriteUInt64(ulong value)
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xFB05A4", Offset = "0xFB05A4", VA = "0xFB05A4")]
		private static string ChunkType(uint id)
		{
			return null;
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xFB07C4", Offset = "0xFB07C4", VA = "0xFB07C4")]
		private static uint ChunkId(string id)
		{
			return default(uint);
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xFAF234", Offset = "0xFAF234", VA = "0xFAF234")]
		public MP4FileProcessing()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public enum StereoPacking
	{
		[Token(Token = "0x40008A3")]
		None,
		[Token(Token = "0x40008A4")]
		TopBottom,
		[Token(Token = "0x40008A5")]
		LeftRight
	}
	[Token(Token = "0x2000121")]
	public enum StopMode
	{
		[Token(Token = "0x40008A7")]
		None,
		[Token(Token = "0x40008A8")]
		FramesEncoded,
		[Token(Token = "0x40008A9")]
		SecondsEncoded,
		[Token(Token = "0x40008AA")]
		SecondsElapsed
	}
	[Token(Token = "0x2000122")]
	public enum ImageSequenceFormat
	{
		[Token(Token = "0x40008AC")]
		PNG
	}
	[Token(Token = "0x2000123")]
	public enum FileWriterType
	{
		[Token(Token = "0x40008AE")]
		AVI,
		[Token(Token = "0x40008AF")]
		MediaFoundation,
		[Token(Token = "0x40008B0")]
		PNG
	}
	[Token(Token = "0x2000124")]
	public class NativePlugin
	{
		[Token(Token = "0x20001BF")]
		public enum PixelFormat
		{
			[Token(Token = "0x4000C24")]
			RGBA32,
			[Token(Token = "0x4000C25")]
			BGRA32,
			[Token(Token = "0x4000C26")]
			YCbCr422_YUY2,
			[Token(Token = "0x4000C27")]
			YCbCr422_UYVY,
			[Token(Token = "0x4000C28")]
			YCbCr422_HDYC
		}

		[Token(Token = "0x20001C0")]
		public enum PluginEvent
		{
			[Token(Token = "0x4000C2A")]
			CaptureFrameBuffer,
			[Token(Token = "0x4000C2B")]
			FreeResources
		}

		[Token(Token = "0x40008B1")]
		public const int PluginID = 262340608;

		[Token(Token = "0x40008B2")]
		public const string ScriptVersion = "3.7.4";

		[Token(Token = "0x40008B3")]
		public const string ExpectedPluginVersion = "3.7.4";

		[Token(Token = "0x40008B4")]
		public const int MaxRenderWidth = 16384;

		[Token(Token = "0x40008B5")]
		public const int MaxRenderHeight = 16384;

		[PreserveSig]
		[Token(Token = "0x600089D")]
		[Address(RVA = "0xF9DE7C", Offset = "0xF9DE7C", VA = "0xF9DE7C")]
		public static extern IntPtr GetRenderEventFunc();

		[PreserveSig]
		[Token(Token = "0x600089E")]
		[Address(RVA = "0xF9DF08", Offset = "0xF9DF08", VA = "0xF9DF08")]
		public static extern IntPtr GetFreeResourcesEventFunc();

		[PreserveSig]
		[Token(Token = "0x600089F")]
		[Address(RVA = "0xF9D778", Offset = "0xF9D778", VA = "0xF9D778")]
		public static extern bool Init();

		[PreserveSig]
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xF9E874", Offset = "0xF9E874", VA = "0xF9E874")]
		public static extern void Deinit();

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xF9D708", Offset = "0xF9D708", VA = "0xF9D708")]
		public static string GetPluginVersionString()
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xFB15EC", Offset = "0xFB15EC", VA = "0xFB15EC")]
		public static extern bool IsTrialVersion();

		[PreserveSig]
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xF9E168", Offset = "0xF9E168", VA = "0xF9E168")]
		public static extern int GetNumAVIVideoCodecs();

		[PreserveSig]
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xFAB8D8", Offset = "0xFAB8D8", VA = "0xFAB8D8")]
		public static extern bool IsConfigureVideoCodecSupported(int index);

		[PreserveSig]
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xFA2664", Offset = "0xFA2664", VA = "0xFA2664")]
		public static extern void ConfigureVideoCodec(int index);

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xF9E1F4", Offset = "0xF9E1F4", VA = "0xF9E1F4")]
		public static string GetAVIVideoCodecName(int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xF9E2C0", Offset = "0xF9E2C0", VA = "0xF9E2C0")]
		public static extern int GetNumAVIAudioCodecs();

		[PreserveSig]
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xFAB97C", Offset = "0xFAB97C", VA = "0xFAB97C")]
		public static extern bool IsConfigureAudioCodecSupported(int index);

		[PreserveSig]
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xFAE598", Offset = "0xFAE598", VA = "0xFAE598")]
		public static extern void ConfigureAudioCodec(int index);

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xF9E34C", Offset = "0xF9E34C", VA = "0xF9E34C")]
		public static string GetAVIAudioCodecName(int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xF9E418", Offset = "0xF9E418", VA = "0xF9E418")]
		public static extern int GetNumAVIAudioInputDevices();

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xF9E4A4", Offset = "0xF9E4A4", VA = "0xF9E4A4")]
		public static string GetAVIAudioInputDeviceName(int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xFA0934", Offset = "0xFA0934", VA = "0xFA0934")]
		public static extern int CreateRecorderVideo(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, int videoCodecIndex, bool hasAudio, int audioSampleRate, int audioChannelCount, int audioInputDeviceIndex, int audioCodecIndex, bool isRealTime, bool useMediaFoundation, bool supportAlpha, bool forceGpuFlush);

		[PreserveSig]
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xFA0A80", Offset = "0xFA0A80", VA = "0xFA0A80")]
		public static extern int CreateRecorderImages(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool isRealTime, int imageFormatType, bool supportAlpha, bool forceGpuFlush, int startFrame);

		[PreserveSig]
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xFA0B9C", Offset = "0xFA0B9C", VA = "0xFA0B9C")]
		public static extern int CreateRecorderPipe(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool supportAlpha, bool forceGpuFlush);

		[PreserveSig]
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xFA0D48", Offset = "0xFA0D48", VA = "0xFA0D48")]
		public static extern bool Start(int handle);

		[PreserveSig]
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xFA1F80", Offset = "0xFA1F80", VA = "0xFA1F80")]
		public static extern bool IsNewFrameDue(int handle);

		[PreserveSig]
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xF9EB88", Offset = "0xF9EB88", VA = "0xF9EB88")]
		public static extern void EncodeFrame(int handle, IntPtr data);

		[PreserveSig]
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xFA3C50", Offset = "0xFA3C50", VA = "0xFA3C50")]
		public static extern void EncodeAudio(int handle, IntPtr data, uint length);

		[PreserveSig]
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xF9ED08", Offset = "0xF9ED08", VA = "0xF9ED08")]
		public static extern void EncodeFrameWithAudio(int handle, IntPtr videoData, IntPtr audioData, uint audioLength);

		[PreserveSig]
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xFA0E9C", Offset = "0xFA0E9C", VA = "0xFA0E9C")]
		public static extern void Pause(int handle);

		[PreserveSig]
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xFA1550", Offset = "0xFA1550", VA = "0xFA1550")]
		public static extern void Stop(int handle, bool skipPendingFrames);

		[PreserveSig]
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xFA3BA8", Offset = "0xFA3BA8", VA = "0xFA3BA8")]
		public static extern void SetTexturePointer(int handle, IntPtr texture);

		[PreserveSig]
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xFA15FC", Offset = "0xFA15FC", VA = "0xFA15FC")]
		public static extern void FreeRecorder(int handle);

		[PreserveSig]
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xFA2178", Offset = "0xFA2178", VA = "0xFA2178")]
		public static extern uint GetNumDroppedFrames(int handle);

		[PreserveSig]
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xFA2214", Offset = "0xFA2214", VA = "0xFA2214")]
		public static extern uint GetNumDroppedEncoderFrames(int handle);

		[PreserveSig]
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xFA22B0", Offset = "0xFA22B0", VA = "0xFA22B0")]
		public static extern uint GetNumEncodedFrames(int handle);

		[PreserveSig]
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xFA234C", Offset = "0xFA234C", VA = "0xFA234C")]
		public static extern uint GetEncodedSeconds(int handle);

		[PreserveSig]
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xFB1560", Offset = "0xFB1560", VA = "0xFB1560")]
		private static extern IntPtr GetPluginVersion();

		[PreserveSig]
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xFB1680", Offset = "0xFB1680", VA = "0xFB1680")]
		private static extern bool GetAVIVideoCodecName(int index, StringBuilder name, int nameBufferLength);

		[PreserveSig]
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xFB1760", Offset = "0xFB1760", VA = "0xFB1760")]
		private static extern bool GetAVIAudioCodecName(int index, StringBuilder name, int nameBufferLength);

		[PreserveSig]
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xFB1840", Offset = "0xFB1840", VA = "0xFB1840")]
		private static extern bool GetAVIAudioInputDeviceName(int index, StringBuilder name, int nameBufferLength);

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xFB1920", Offset = "0xFB1920", VA = "0xFB1920")]
		public NativePlugin()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class Utils
	{
		[Serializable]
		[Token(Token = "0x20001C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65778C", Offset = "0x65778C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000C2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<Camera> <>9__2_0;

			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0xFB2524", Offset = "0xFB2524", VA = "0xFB2524")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0xFB252C", Offset = "0xFB252C", VA = "0xFB252C")]
			internal int <FindContributingCameras>b__2_0(Camera a, Camera b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xFB2248", Offset = "0xFB2248", VA = "0xFB2248")]
		public static Camera GetUltimateRenderCamera()
		{
			return null;
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xFA2B90", Offset = "0xFA2B90", VA = "0xFA2B90")]
		public static bool HasContributingCameras(Camera parentCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xFA2C78", Offset = "0xFA2C78", VA = "0xFA2C78")]
		public static Camera[] FindContributingCameras(Camera parentCamera)
		{
			return null;
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xFAE6E0", Offset = "0xFAE6E0", VA = "0xFAE6E0")]
		public static bool ShowInExplorer(string itemPath)
		{
			return default(bool);
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xFAE7BC", Offset = "0xFAE7BC", VA = "0xFAE7BC")]
		public static bool OpenInDefaultApp(string itemPath)
		{
			return default(bool);
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xFB2444", Offset = "0xFB2444", VA = "0xFB2444")]
		public static long GetFileSize(string filename)
		{
			return default(long);
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xFB24B8", Offset = "0xFB24B8", VA = "0xFB24B8")]
		public Utils()
		{
		}
	}
}
