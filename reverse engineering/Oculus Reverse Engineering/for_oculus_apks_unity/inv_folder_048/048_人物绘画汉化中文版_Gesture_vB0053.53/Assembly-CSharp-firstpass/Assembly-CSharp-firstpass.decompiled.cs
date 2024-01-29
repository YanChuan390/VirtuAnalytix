using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class HandBehaviour : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	public enum Handedness
	{
		[Token(Token = "0x400000F")]
		Left,
		[Token(Token = "0x4000010")]
		Right
	}

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public VRRig vrRig;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	public Handedness handedness;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	public HandBehaviour otherHand;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 velocity;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 lastPos;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 angularVelocity;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 eulerLast;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x60")]
	public InputTrigger trigger;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x68")]
	public InputTrigger grip;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x70")]
	public InputStick stick;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x78")]
	public InputFaceButton top;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x80")]
	public InputFaceButton bottom;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x88")]
	public InputButton menu;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1174094", Offset = "0x1174094", VA = "0x1174094")]
	private void Update()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x11740B8", Offset = "0x11740B8", VA = "0x11740B8")]
	private void GetInputs()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1174B24", Offset = "0x1174B24", VA = "0x1174B24")]
	public void TriggerHapticPulse(float strength, float length)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1174954", Offset = "0x1174954", VA = "0x1174954")]
	private void CalculateHandVelocity()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1174D70", Offset = "0x1174D70", VA = "0x1174D70")]
	public HandBehaviour()
	{
	}
}
[Token(Token = "0x2000004")]
public class HandButtonColor : MonoBehaviour
{
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x18")]
	private HandBehaviour myHand;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x20")]
	private HandBehaviour ogHand;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x28")]
	public float colorLerpSpeed;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x2C")]
	public Color normalColor;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x3C")]
	public Color touchColor;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x4C")]
	public Color pressedColor;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x60")]
	public Renderer topButton;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x68")]
	public Renderer bottomButton;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x70")]
	public Renderer stick;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x78")]
	public Transform thumbStickHolder;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x80")]
	public Transform triggerHolder;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x88")]
	public Transform gripHolder;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x90")]
	private Color topTargetColor;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0xA0")]
	private Color bottomTargetColor;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0xB0")]
	private Color stickTargetColor;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1174D78", Offset = "0x1174D78", VA = "0x1174D78")]
	private void Start()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1174DE4", Offset = "0x1174DE4", VA = "0x1174DE4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1175458", Offset = "0x1175458", VA = "0x1175458")]
	public HandButtonColor()
	{
	}
}
[Serializable]
[Token(Token = "0x2000005")]
public class InputButton
{
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x10")]
	public bool held;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x11")]
	public bool down;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x12")]
	public bool up;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1175468", Offset = "0x1175468", VA = "0x1175468")]
	public InputButton()
	{
	}
}
[Serializable]
[Token(Token = "0x2000006")]
public class InputTouch
{
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x10")]
	public bool held;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x11")]
	public bool down;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x12")]
	public bool up;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1175480", Offset = "0x1175480", VA = "0x1175480")]
	public InputTouch()
	{
	}
}
[Serializable]
[Token(Token = "0x2000007")]
public class InputFaceButton
{
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x10")]
	public bool held;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x11")]
	public bool down;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x12")]
	public bool up;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x18")]
	public InputTouch touch;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1175470", Offset = "0x1175470", VA = "0x1175470")]
	public InputFaceButton()
	{
	}
}
[Serializable]
[Token(Token = "0x2000008")]
public class InputStick
{
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 axis;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x18")]
	public InputButton button;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x20")]
	public InputTouch touch;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1175478", Offset = "0x1175478", VA = "0x1175478")]
	public InputStick()
	{
	}
}
[Serializable]
[Token(Token = "0x2000009")]
public class InputTrigger
{
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x10")]
	public float axis;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x14")]
	public bool held;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x15")]
	public bool down;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x16")]
	public bool up;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1175488", Offset = "0x1175488", VA = "0x1175488")]
	public InputTrigger()
	{
	}
}
[Token(Token = "0x200000A")]
public class VRRig : MonoBehaviour
{
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody rb;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x20")]
	public Transform trackedObjects;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x28")]
	public Transform hmd;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x30")]
	public HandBehaviour leftHand;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x38")]
	public HandBehaviour rightHand;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x117D1AC", Offset = "0x117D1AC", VA = "0x117D1AC")]
	private void Update()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x117D21C", Offset = "0x117D21C", VA = "0x117D21C")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x117D338", Offset = "0x117D338", VA = "0x117D338")]
	public VRRig()
	{
	}
}
namespace DynamicShadowProjector
{
	[Token(Token = "0x200000B")]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4E873C", Offset = "0x4E873C")]
	public class DrawSceneObject : MonoBehaviour
	{
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Shader m_replacementShader;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayerMask m_cullingMask;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x28")]
		private ShadowTextureRenderer m_shadowTextureRenderer;

		[Token(Token = "0x17000001")]
		public Shader replacementShader
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x11722F0", Offset = "0x11722F0", VA = "0x11722F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x11722F8", Offset = "0x11722F8", VA = "0x11722F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public LayerMask cullingMask
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x1172520", Offset = "0x1172520", VA = "0x1172520")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x1172528", Offset = "0x1172528", VA = "0x1172528")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public ShadowTextureRenderer shadowTextureRenderer
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x1172374", Offset = "0x1172374", VA = "0x1172374")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1172628", Offset = "0x1172628", VA = "0x1172628")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x11726B8", Offset = "0x11726B8", VA = "0x11726B8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1172728", Offset = "0x1172728", VA = "0x1172728")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1172780", Offset = "0x1172780", VA = "0x1172780")]
		private void OnVisibilityChanged(bool isVisible)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x11727DC", Offset = "0x11727DC", VA = "0x11727DC")]
		public DrawSceneObject()
		{
		}
	}
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4E87BC", Offset = "0x4E87BC")]
	[ExecuteAlways]
	public class DrawTargetObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000D")]
		public struct ReplaceShader
		{
			[Token(Token = "0x4000049")]
			[FieldOffset(Offset = "0x0")]
			public string renderType;

			[Token(Token = "0x400004A")]
			[FieldOffset(Offset = "0x8")]
			public Shader shader;
		}

		[Token(Token = "0x200000E")]
		public enum TextureAlignment
		{
			[Token(Token = "0x400004C")]
			None,
			[Token(Token = "0x400004D")]
			TargetAxisX,
			[Token(Token = "0x400004E")]
			TargetAxisY,
			[Token(Token = "0x400004F")]
			TargetAxisZ
		}

		[Token(Token = "0x200000F")]
		public enum UpdateFunction
		{
			[Token(Token = "0x4000051")]
			OnPreCull,
			[Token(Token = "0x4000052")]
			LateUpdate,
			[Token(Token = "0x4000053")]
			UpdateTransform
		}

		[Token(Token = "0x2000010")]
		private struct CommandBufferHash
		{
			[Token(Token = "0x4000054")]
			[FieldOffset(Offset = "0x0")]
			private ulong hash;

			[Token(Token = "0x6000041")]
			[Address(RVA = "0x1172B1C", Offset = "0x1172B1C", VA = "0x1172B1C")]
			public void Init()
			{
			}

			[Token(Token = "0x6000042")]
			[Address(RVA = "0x11736A8", Offset = "0x11736A8", VA = "0x11736A8")]
			public void AddRenderer(Renderer renderer)
			{
			}

			[Token(Token = "0x6000043")]
			[Address(RVA = "0x1173698", Offset = "0x1173698", VA = "0x1173698")]
			public bool Equals(CommandBufferHash rhs)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_target;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_targetDirection;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask m_layerMask;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextureAlignment m_textureAlignment;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UpdateFunction m_updateFunction;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Material m_shadowShader;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ReplaceShader[] m_replacementShaders;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool m_renderChildren;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool m_autoDetectHierarchyChanges;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x4A")]
		[SerializeField]
		private bool m_followTarget;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x50")]
		private CommandBufferHash m_commandBufferHash;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isCommandBufferDirty;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x60")]
		private CommandBuffer m_commandBuffer;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x68")]
		private ShadowTextureRenderer m_shadowRenderer;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 m_localTargetPosition;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<Material, Material> m_replacedMaterialCache;

		[Token(Token = "0x17000004")]
		public Transform target
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x11727E4", Offset = "0x11727E4", VA = "0x11727E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x11727EC", Offset = "0x11727EC", VA = "0x11727EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public Transform targetDirection
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x1172894", Offset = "0x1172894", VA = "0x1172894")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x117289C", Offset = "0x117289C", VA = "0x117289C")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public bool renderChildren
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x11728A4", Offset = "0x11728A4", VA = "0x11728A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x11728AC", Offset = "0x11728AC", VA = "0x11728AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public bool autoDetectHierarchyChanges
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x11728D4", Offset = "0x11728D4", VA = "0x11728D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x11728DC", Offset = "0x11728DC", VA = "0x11728DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public LayerMask layerMask
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x11728E8", Offset = "0x11728E8", VA = "0x11728E8")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x11728F0", Offset = "0x11728F0", VA = "0x11728F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public TextureAlignment textureAlignment
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x1172950", Offset = "0x1172950", VA = "0x1172950")]
			get
			{
				return default(TextureAlignment);
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x1172958", Offset = "0x1172958", VA = "0x1172958")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public UpdateFunction updateFunction
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x1172960", Offset = "0x1172960", VA = "0x1172960")]
			get
			{
				return default(UpdateFunction);
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x1172968", Offset = "0x1172968", VA = "0x1172968")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public bool followTarget
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x1172970", Offset = "0x1172970", VA = "0x1172970")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x1172978", Offset = "0x1172978", VA = "0x1172978")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Material shadowShader
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x1172984", Offset = "0x1172984", VA = "0x1172984")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x117298C", Offset = "0x117298C", VA = "0x117298C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public ReplaceShader[] replacementShaders
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x1172A28", Offset = "0x1172A28", VA = "0x1172A28")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x1172A30", Offset = "0x1172A30", VA = "0x1172A30")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		internal CommandBuffer commandBuffer
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x1173074", Offset = "0x1173074", VA = "0x1173074")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1172888", Offset = "0x1172888", VA = "0x1172888")]
		public void SetCommandBufferDirty()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1172A60", Offset = "0x1172A60", VA = "0x1172A60")]
		public void UpdateCommandBuffer()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1172DA0", Offset = "0x1172DA0", VA = "0x1172DA0")]
		public void UpdateMaterial(Material mat)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1172E28", Offset = "0x1172E28", VA = "0x1172E28")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x117307C", Offset = "0x117307C", VA = "0x117307C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x11731FC", Offset = "0x11731FC", VA = "0x11731FC")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x117320C", Offset = "0x117320C", VA = "0x117320C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x117330C", Offset = "0x117330C", VA = "0x117330C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x11733C4", Offset = "0x11733C4", VA = "0x11733C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1173564", Offset = "0x1173564", VA = "0x1173564")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1173628", Offset = "0x1173628", VA = "0x1173628")]
		internal void OnPreCull()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x117366C", Offset = "0x117366C", VA = "0x117366C")]
		private void OnVisibilityChanged(bool isVisible)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1173164", Offset = "0x1173164", VA = "0x1173164")]
		private void CreateCommandBuffer()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x11735B8", Offset = "0x11735B8", VA = "0x11735B8")]
		private bool IsTargetObjectTreeStructureChanged()
		{
			return default(bool);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1172B24", Offset = "0x1172B24", VA = "0x1172B24")]
		private void AddDrawCommandForGameObject(GameObject obj, bool recursive, ref CommandBufferHash commandBufferHash, bool hashOnly)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x11736E8", Offset = "0x11736E8", VA = "0x11736E8")]
		private void AddDrawCommand(Renderer renderer, int renderTypeIndex)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1173B74", Offset = "0x1173B74", VA = "0x1173B74")]
		public DrawTargetObject()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class FollowTargetObject : MonoBehaviour
	{
		[Token(Token = "0x2000012")]
		public enum TextureAlignment
		{
			[Token(Token = "0x400005B")]
			None,
			[Token(Token = "0x400005C")]
			TargetAxisX,
			[Token(Token = "0x400005D")]
			TargetAxisY,
			[Token(Token = "0x400005E")]
			TargetAxisZ
		}

		[Token(Token = "0x2000013")]
		public enum UpdateFunction
		{
			[Token(Token = "0x4000060")]
			OnPreCull,
			[Token(Token = "0x4000061")]
			LateUpdate,
			[Token(Token = "0x4000062")]
			UpdateTransform
		}

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_target;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_targetDirection;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextureAlignment m_textureAlignment;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private UpdateFunction m_updateFunction;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_localTargetPosition;

		[Token(Token = "0x1700000F")]
		public Transform target
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x1173D40", Offset = "0x1173D40", VA = "0x1173D40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x1173D48", Offset = "0x1173D48", VA = "0x1173D48")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Transform targetDirection
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x1173D50", Offset = "0x1173D50", VA = "0x1173D50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x1173D58", Offset = "0x1173D58", VA = "0x1173D58")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public TextureAlignment textureAlignment
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x1173D60", Offset = "0x1173D60", VA = "0x1173D60")]
			get
			{
				return default(TextureAlignment);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x1173D68", Offset = "0x1173D68", VA = "0x1173D68")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public UpdateFunction updateFunction
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x1173D70", Offset = "0x1173D70", VA = "0x1173D70")]
			get
			{
				return default(UpdateFunction);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x1173D78", Offset = "0x1173D78", VA = "0x1173D78")]
			set
			{
			}
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1173D80", Offset = "0x1173D80", VA = "0x1173D80")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1173FAC", Offset = "0x1173FAC", VA = "0x1173FAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1174060", Offset = "0x1174060", VA = "0x1174060")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1174074", Offset = "0x1174074", VA = "0x1174074")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1174084", Offset = "0x1174084", VA = "0x1174084")]
		public FollowTargetObject()
		{
		}
	}
	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4E882C", Offset = "0x4E882C")]
	public class MipmappedShadowFallback : MonoBehaviour
	{
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x18")]
		public UnityEngine.Object m_fallbackShaderOrMaterial;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x20")]
		public int m_blurLevel;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x24")]
		public float m_blurSize;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x28")]
		public bool m_modifyTextureSize;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x2C")]
		public ShadowTextureRenderer.TextureMultiSample m_multiSampling;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x30")]
		public ShadowTextureRenderer.TextureSuperSample m_superSampling;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x34")]
		public int m_textureWidth;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x38")]
		public int m_textureHeight;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x40")]
		public Shader m_tex2DlodCheckShader;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x48")]
		public Shader m_glslCheckShader;

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1175490", Offset = "0x1175490", VA = "0x1175490")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x11756E4", Offset = "0x11756E4", VA = "0x11756E4")]
		public void ApplyFallback(Projector projector)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x11759E4", Offset = "0x11759E4", VA = "0x11759E4")]
		public MipmappedShadowFallback()
		{
		}
	}
	[Token(Token = "0x2000015")]
	[ExecuteAlways]
	public class PropertyBlockForTransparentReceiver : MonoBehaviour
	{
		[Token(Token = "0x2000016")]
		[Flags]
		public enum Options
		{
			[Token(Token = "0x400007F")]
			CopyMainTexFromMaterial = 1,
			[Token(Token = "0x4000080")]
			CopyAlphaCutoffFromMaterial = 2,
			[Token(Token = "0x4000081")]
			CopyBaseColorFromMaterial = 4,
			[Token(Token = "0x4000082")]
			EnableAlphaCutoffByKeyword = 8,
			[Token(Token = "0x4000083")]
			EnableAlphaCutoff = 0x10,
			[Token(Token = "0x4000084")]
			CopyCullModeFromMaterial = 0x20,
			[Token(Token = "0x4000085")]
			CullFront = 0x40,
			[Token(Token = "0x4000086")]
			CullBack = 0x80
		}

		[Token(Token = "0x2000017")]
		public enum CullMode
		{
			[Token(Token = "0x4000088")]
			None = 0,
			[Token(Token = "0x4000089")]
			Front = 0x40,
			[Token(Token = "0x400008A")]
			Back = 0x80
		}

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Options m_options;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x20")]
		public Texture mainTexture;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x28")]
		public Vector4 mainTextureST;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x38")]
		public float baseAlpha;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x3C")]
		public float alphaCutoff;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x40")]
		public string mainTextureName;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x48")]
		public string baseColorName;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x50")]
		public string alphaCutoffName;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x58")]
		public string alphaCutoffKeyword;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x60")]
		public string cullModeName;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x68")]
		private string m_mainTextureSTName;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x70")]
		private Renderer m_renderer;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x78")]
		private MaterialPropertyBlock m_propertyBlock;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x0")]
		private static int s_dspBaseAlphaId;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x4")]
		private static int s_dspCullModeId;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x8")]
		private static int s_dspMainTexId;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0xC")]
		private static int s_dspMainTexStId;

		[Token(Token = "0x17000013")]
		public bool copyMainTexFromMaterial
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x1175A30", Offset = "0x1175A30", VA = "0x1175A30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x1175A3C", Offset = "0x1175A3C", VA = "0x1175A3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public bool copyBaseColorFromMaterial
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x1175A58", Offset = "0x1175A58", VA = "0x1175A58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x1175A64", Offset = "0x1175A64", VA = "0x1175A64")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public bool copyAlphaCutoffFromMaterial
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x1175A80", Offset = "0x1175A80", VA = "0x1175A80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x1175A8C", Offset = "0x1175A8C", VA = "0x1175A8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public bool copyCullModeFromMaterial
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x1175AA8", Offset = "0x1175AA8", VA = "0x1175AA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x1175AB4", Offset = "0x1175AB4", VA = "0x1175AB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public CullMode cullMode
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x1175AD0", Offset = "0x1175AD0", VA = "0x1175AD0")]
			get
			{
				return default(CullMode);
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x1175ADC", Offset = "0x1175ADC", VA = "0x1175ADC")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public bool enableAlphaCutoffByKeyword
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x1175AF0", Offset = "0x1175AF0", VA = "0x1175AF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x1175AFC", Offset = "0x1175AFC", VA = "0x1175AFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public bool enableAlphaCutoff
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x1175B18", Offset = "0x1175B18", VA = "0x1175B18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x1175B2C", Offset = "0x1175B2C", VA = "0x1175B2C")]
			set
			{
			}
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1175A04", Offset = "0x1175A04", VA = "0x1175A04")]
		private bool GetOption(Options option)
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1175A14", Offset = "0x1175A14", VA = "0x1175A14")]
		private void SetOption(Options option, bool value)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1175B48", Offset = "0x1175B48", VA = "0x1175B48")]
		static PropertyBlockForTransparentReceiver()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1175B4C", Offset = "0x1175B4C", VA = "0x1175B4C")]
		private static void StaticInitialize()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1175C5C", Offset = "0x1175C5C", VA = "0x1175C5C")]
		private Texture GetMaterialMainTexture()
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1175D18", Offset = "0x1175D18", VA = "0x1175D18")]
		private Vector4 GetMaterialMainTextureST()
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1175DF0", Offset = "0x1175DF0", VA = "0x1175DF0")]
		private Color GetMaterialBaseColor()
		{
			return default(Color);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1175E64", Offset = "0x1175E64", VA = "0x1175E64")]
		private float GetMaterialAlphaCutoff()
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1175EC8", Offset = "0x1175EC8", VA = "0x1175EC8")]
		private float GetMaterialCullMode()
		{
			return default(float);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1175F2C", Offset = "0x1175F2C", VA = "0x1175F2C")]
		public void UpdatePropertyBlock()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x11763E0", Offset = "0x11763E0", VA = "0x11763E0")]
		private void Initialize()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x11764A8", Offset = "0x11764A8", VA = "0x11764A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x11764AC", Offset = "0x11764AC", VA = "0x11764AC")]
		private void Start()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x11764B0", Offset = "0x11764B0", VA = "0x11764B0")]
		public PropertyBlockForTransparentReceiver()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4E88AC", Offset = "0x4E88AC")]
	public class ShadowTextureRenderer : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000019")]
		public enum TextureMultiSample
		{
			[Token(Token = "0x40000C3")]
			x1 = 1,
			[Token(Token = "0x40000C4")]
			x2 = 2,
			[Token(Token = "0x40000C5")]
			x4 = 4,
			[Token(Token = "0x40000C6")]
			x8 = 8
		}

		[Token(Token = "0x200001A")]
		public enum TextureSuperSample
		{
			[Token(Token = "0x40000C8")]
			x1 = 1,
			[Token(Token = "0x40000C9")]
			x4 = 2,
			[Token(Token = "0x40000CA")]
			x16 = 4
		}

		[Token(Token = "0x200001B")]
		public enum MipmapFalloff
		{
			[Token(Token = "0x40000CC")]
			None,
			[Token(Token = "0x40000CD")]
			Linear,
			[Token(Token = "0x40000CE")]
			Custom
		}

		[Token(Token = "0x200001C")]
		public enum BlurFilter
		{
			[Token(Token = "0x40000D0")]
			Uniform,
			[Token(Token = "0x40000D1")]
			Gaussian
		}

		[Token(Token = "0x200001D")]
		private struct BlurParam
		{
			[Token(Token = "0x40000D2")]
			[FieldOffset(Offset = "0x0")]
			public int tap;

			[Token(Token = "0x40000D3")]
			[FieldOffset(Offset = "0x4")]
			public Vector4 offset;

			[Token(Token = "0x40000D4")]
			[FieldOffset(Offset = "0x14")]
			public Vector4 weight;
		}

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextureMultiSample m_multiSampling;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextureSuperSample m_superSampling;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MipmapFalloff m_mipmapFalloff;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BlurFilter m_blurFilter;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_testViewClip;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int m_textureWidth;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int m_textureHeight;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int m_mipLevel;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int m_blurLevel;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_blurSize;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_mipmapBlurSize;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private bool m_singlePassMipmapBlur;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color m_shadowColor;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Material m_blurShader;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Material m_downsampleShader;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Material m_copyMipmapShader;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Material m_eraseShadowShader;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float[] m_customMipmapFalloff;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RenderTextureFormat[] m_preferredTextureFormats;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Camera[] m_camerasForViewClipTest;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x90")]
		private RenderTexture <shadowTexture>k__BackingField;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x0")]
		private static int s_falloffParamID;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x4")]
		private static int s_blurOffsetHParamID;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x8")]
		private static int s_blurOffsetVParamID;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0xC")]
		private static int s_blurWeightHParamID;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x10")]
		private static int s_blurWeightVParamID;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x14")]
		private static int s_downSampleBlurOffset0ParamID;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x18")]
		private static int s_downSampleBlurOffset1ParamID;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x1C")]
		private static int s_downSampleBlurOffset2ParamID;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x20")]
		private static int s_downSampleBlurOffset3ParamID;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x24")]
		private static int s_downSampleBlurWeightParamID;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x28")]
		private static int s_blitSrcTexParamID;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x2C")]
		private static int s_blitSrcTexelSizeParamID;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x30")]
		private static int s_shadowTexParamID;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x34")]
		private static int s_mipLevelParamID;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x98")]
		private Projector m_projector;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0xA0")]
		private Material m_projectorMaterial;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0xA8")]
		private CommandBuffer m_commandBuffer;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Camera m_camera;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0xB8")]
		private CommandBuffer m_postProcessCommands;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isTexturePropertyChanged;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0xC1")]
		private bool m_isVisible;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0xC2")]
		private bool m_shadowTextureValid;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x38")]
		private static HashSet<Material> s_sharedMaterials;

		[Token(Token = "0x40000B7")]
		private const HideFlags CLONED_MATERIAL_HIDE_FLAGS = HideFlags.HideAndDontSave;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x40")]
		private static int[] s_temporaryRenderTargetNameIds;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x48")]
		private static RenderTargetIdentifier[] s_temporaryRenderTargetIdentifiers;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0xC8")]
		private RenderTexture m_temporaryRenderTarget;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0xD0")]
		private List<MaterialPropertyBlock> m_propertyBlockPool;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0xD8")]
		private int m_propetyBlockCount;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x50")]
		private static Dictionary<int, Mesh> s_borderMeshCache;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x58")]
		private static readonly int[] s_borderMeshIndices;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x60")]
		private static Mesh s_fullScreenQuad;

		[Token(Token = "0x40000C0")]
		private const int MAX_BLUR_TAP_SIZE = 7;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x68")]
		private static float[] s_blurWeights;

		[Token(Token = "0x1700001A")]
		public TextureMultiSample multiSampling
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x1176638", Offset = "0x1176638", VA = "0x1176638")]
			get
			{
				return default(TextureMultiSample);
			}
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x1175964", Offset = "0x1175964", VA = "0x1175964")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public TextureSuperSample superSampling
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x117664C", Offset = "0x117664C", VA = "0x117664C")]
			get
			{
				return default(TextureSuperSample);
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x1175980", Offset = "0x1175980", VA = "0x1175980")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public int textureWidth
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x11766C0", Offset = "0x11766C0", VA = "0x11766C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x117592C", Offset = "0x117592C", VA = "0x117592C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public int textureHeight
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x11766C8", Offset = "0x11766C8", VA = "0x11766C8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x1175948", Offset = "0x1175948", VA = "0x1175948")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public RenderTextureFormat[] preferredTextureFormats
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x11766D0", Offset = "0x11766D0", VA = "0x11766D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x11766D8", Offset = "0x11766D8", VA = "0x11766D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public int mipLevel
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x1176708", Offset = "0x1176708", VA = "0x1176708")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x1175908", Offset = "0x1175908", VA = "0x1175908")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public int blurLevel
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x1176710", Offset = "0x1176710", VA = "0x1176710")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x11758A4", Offset = "0x11758A4", VA = "0x11758A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public float blurSize
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x1176718", Offset = "0x1176718", VA = "0x1176718")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x1176720", Offset = "0x1176720", VA = "0x1176720")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public BlurFilter blurFilter
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x1176728", Offset = "0x1176728", VA = "0x1176728")]
			get
			{
				return default(BlurFilter);
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x1176730", Offset = "0x1176730", VA = "0x1176730")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public float mipmapBlurSize
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x1176738", Offset = "0x1176738", VA = "0x1176738")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x1176740", Offset = "0x1176740", VA = "0x1176740")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public bool singlePassMipmapBlur
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x1176748", Offset = "0x1176748", VA = "0x1176748")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x1176750", Offset = "0x1176750", VA = "0x1176750")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public MipmapFalloff mipmapFalloff
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x117675C", Offset = "0x117675C", VA = "0x117675C")]
			get
			{
				return default(MipmapFalloff);
			}
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x1176764", Offset = "0x1176764", VA = "0x1176764")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public float[] customMipmapFalloff
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x117676C", Offset = "0x117676C", VA = "0x117676C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x1176774", Offset = "0x1176774", VA = "0x1176774")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public Color shadowColor
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x117677C", Offset = "0x117677C", VA = "0x117677C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x1176788", Offset = "0x1176788", VA = "0x1176788")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public Material blurShader
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x1176824", Offset = "0x1176824", VA = "0x1176824")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x117682C", Offset = "0x117682C", VA = "0x117682C")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public Material downsampleShader
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x1176834", Offset = "0x1176834", VA = "0x1176834")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x117683C", Offset = "0x117683C", VA = "0x117683C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public Material copyMipmapShader
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x1176844", Offset = "0x1176844", VA = "0x1176844")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x117684C", Offset = "0x117684C", VA = "0x117684C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public Material eraseShadowShader
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x1176854", Offset = "0x1176854", VA = "0x1176854")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x117685C", Offset = "0x117685C", VA = "0x117685C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public RenderTexture shadowTexture
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x1176864", Offset = "0x1176864", VA = "0x1176864")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x117686C", Offset = "0x117686C", VA = "0x117686C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public bool testViewClip
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x1176874", Offset = "0x1176874", VA = "0x1176874")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x117687C", Offset = "0x117687C", VA = "0x117687C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public Camera[] camerasForViewClipTest
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x1176888", Offset = "0x1176888", VA = "0x1176888")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x1176890", Offset = "0x1176890", VA = "0x1176890")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public Camera projectorCamera
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x1176898", Offset = "0x1176898", VA = "0x1176898")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public float cameraNearClipPlane
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x1176C28", Offset = "0x1176C28", VA = "0x1176C28")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x1176CB4", Offset = "0x1176CB4", VA = "0x1176CB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public LayerMask cameraCullingMask
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x1176D50", Offset = "0x1176D50", VA = "0x1176D50")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x117257C", Offset = "0x117257C", VA = "0x117257C")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public bool isProjectorVisible
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x1176DEC", Offset = "0x1176DEC", VA = "0x1176DEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000033")]
		private static bool isBuiltinRP
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x1176DF4", Offset = "0x1176DF4", VA = "0x1176DF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000034")]
		private bool useIntermediateTexture
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x1176654", Offset = "0x1176654", VA = "0x1176654")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		public CommandBuffer postProcessCommandBuffer
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x1178500", Offset = "0x1178500", VA = "0x1178500")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1172428", Offset = "0x1172428", VA = "0x1172428")]
		public void SetReplacementShader(Shader shader, string replacementTag)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1176640", Offset = "0x1176640", VA = "0x1176640")]
		public void SetTexturePropertyDirty()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1176E68", Offset = "0x1176E68", VA = "0x1176E68")]
		public void CreateRenderTexture()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x11732BC", Offset = "0x11732BC", VA = "0x11732BC")]
		internal void AddCommandBuffer(CommandBuffer commandBuffer)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x11733A0", Offset = "0x11733A0", VA = "0x11733A0")]
		internal void RemoveCommandBuffer(CommandBuffer commandBuffer)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1176918", Offset = "0x1176918", VA = "0x1176918")]
		private bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x11772E8", Offset = "0x11772E8", VA = "0x11772E8")]
		private bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x117770C", Offset = "0x117770C", VA = "0x117770C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1177710", Offset = "0x1177710", VA = "0x1177710")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x11777D8", Offset = "0x11777D8", VA = "0x11777D8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x117786C", Offset = "0x117786C", VA = "0x117786C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1177B58", Offset = "0x1177B58", VA = "0x1177B58")]
		private static bool IsPrefabAsset(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1177258", Offset = "0x1177258", VA = "0x1177258")]
		private bool IsPrefabAsset()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1177B60", Offset = "0x1177B60", VA = "0x1177B60")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x11781EC", Offset = "0x11781EC", VA = "0x11781EC")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x11781F8", Offset = "0x11781F8", VA = "0x11781F8")]
		private void OnApplicationFocus(bool focus)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x11773A0", Offset = "0x11773A0", VA = "0x11773A0")]
		private void CloneProjectorMaterialIfShared()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1178204", Offset = "0x1178204", VA = "0x1178204")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1177FC4", Offset = "0x1177FC4", VA = "0x1177FC4")]
		private bool IsReadyToExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1177F38", Offset = "0x1177F38", VA = "0x1177F38")]
		private void SetVisible(bool isVisible)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1178574", Offset = "0x1178574", VA = "0x1178574")]
		private static void StaticInitialize()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1178A0C", Offset = "0x1178A0C", VA = "0x1178A0C")]
		static ShadowTextureRenderer()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1178B40", Offset = "0x1178B40", VA = "0x1178B40")]
		private void CreateTemporaryRenderTarget()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1178BE0", Offset = "0x1178BE0", VA = "0x1178BE0")]
		private void ReleaseTemporaryRenderTarget()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1178C78", Offset = "0x1178C78", VA = "0x1178C78")]
		private void ClearPropertyBlockPool()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1178C80", Offset = "0x1178C80", VA = "0x1178C80")]
		private MaterialPropertyBlock AllocatePropertyBlock()
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1178D74", Offset = "0x1178D74", VA = "0x1178D74")]
		private void AddPostRenderPassCommands(CommandBuffer cmd, RenderTargetIdentifier srcId)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x117AB7C", Offset = "0x117AB7C", VA = "0x117AB7C")]
		private void AddEraseShadowOnBorderCommand(CommandBuffer cmd, int w, int h)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x117A64C", Offset = "0x117A64C", VA = "0x117A64C")]
		private void AddBlitToCurrentTargetCommand(CommandBuffer cmd, RenderTargetIdentifier srcId, Material mat, int pass, MaterialPropertyBlock properties)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x117B514", Offset = "0x117B514", VA = "0x117B514")]
		private void Update()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x117B5C8", Offset = "0x117B5C8", VA = "0x117B5C8")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x11772B4", Offset = "0x11772B4", VA = "0x11772B4")]
		private bool HasShadowColor()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x117C064", Offset = "0x117C064", VA = "0x117C064")]
		private void PrepareRendering()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x117C114", Offset = "0x117C114", VA = "0x117C114")]
		private void OnPreRender()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x117C178", Offset = "0x117C178", VA = "0x117C178")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x117C220", Offset = "0x117C220", VA = "0x117C220")]
		private static BlurParam GetBlurParam(float blurSize, BlurFilter filter)
		{
			return default(BlurParam);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x117CBCC", Offset = "0x117CBCC", VA = "0x117CBCC")]
		private static BlurParam GetDownsampleBlurParam(float blurSize, BlurFilter filter)
		{
			return default(BlurParam);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x117A9C4", Offset = "0x117A9C4", VA = "0x117A9C4")]
		private void SetBlurShaderProperties(MaterialPropertyBlock dst, out BlurParam blurH, out BlurParam blurV)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x117AE98", Offset = "0x117AE98", VA = "0x117AE98")]
		private void GetMipmapBlurParams(ref BlurParam blurH, ref BlurParam blurV)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x117B424", Offset = "0x117B424", VA = "0x117B424")]
		private void SetMipmapBlurShaderProperties(MaterialPropertyBlock dst, BlurParam blurH, BlurParam blurV)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x117B02C", Offset = "0x117B02C", VA = "0x117B02C")]
		private void SetMipmapDownsampleWithBlurProperties(MaterialPropertyBlock dst, BlurParam blurH, BlurParam blurV, int w, int h)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x117CEF8", Offset = "0x117CEF8", VA = "0x117CEF8", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x117CF8C", Offset = "0x117CF8C", VA = "0x117CF8C", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x117CF90", Offset = "0x117CF90", VA = "0x117CF90")]
		public ShadowTextureRenderer()
		{
		}
	}
}
namespace DynamicShadowProjector.Sample
{
	[Token(Token = "0x200001E")]
	public class FPSCheck : MonoBehaviour
	{
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x18")]
		private int frameCount;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x1C")]
		private float startTime;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x20")]
		private float fps;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x28")]
		public Text text;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1173BB4", Offset = "0x1173BB4", VA = "0x1173BB4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1173D30", Offset = "0x1173D30", VA = "0x1173D30")]
		public FPSCheck()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class Rotate : MonoBehaviour
	{
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x18")]
		public float m_rotateSpeed;

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1176554", Offset = "0x1176554", VA = "0x1176554")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1176628", Offset = "0x1176628", VA = "0x1176628")]
		public Rotate()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class Swing : MonoBehaviour
	{
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x18")]
		public float m_minAngle;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x1C")]
		public float m_maxAngle;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x20")]
		public float m_swingSpeed;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x24")]
		private Quaternion m_initialRotation;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x34")]
		private float m_swing;

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x117D074", Offset = "0x117D074", VA = "0x117D074")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x117D0B4", Offset = "0x117D0B4", VA = "0x117D0B4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x117D18C", Offset = "0x117D18C", VA = "0x117D18C")]
		public Swing()
		{
		}
	}
}
