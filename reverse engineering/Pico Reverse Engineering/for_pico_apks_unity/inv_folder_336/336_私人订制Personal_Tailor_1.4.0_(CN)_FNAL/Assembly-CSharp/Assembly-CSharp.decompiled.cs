using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SimpleJson;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class SkyboxCamera : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Camera m_MainCamera;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_SkyboxScale;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 mainCamStartPos;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 skyboxCamStartPos;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xB7D174", Offset = "0xB7D174", VA = "0xB7D174")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xB7D248", Offset = "0xB7D248", VA = "0xB7D248")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xB7D328", Offset = "0xB7D328", VA = "0xB7D328")]
	public SkyboxCamera()
	{
	}
}
[Token(Token = "0x2000003")]
[ExecuteAlways]
public class ScreenSpacePlacement : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Camera m_Cam;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform m_FlareObject;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xB7D338", Offset = "0xB7D338", VA = "0xB7D338")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xB7D48C", Offset = "0xB7D48C", VA = "0xB7D48C")]
	public ScreenSpacePlacement()
	{
	}
}
[Token(Token = "0x2000004")]
public class KeepFrameFeature : ScriptableRendererFeature
{
	[Token(Token = "0x2000005")]
	private class CopyFramePass : ScriptableRenderPass
	{
		[Token(Token = "0x17000001")]
		private RenderTargetIdentifier source
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0xB7D854", Offset = "0xB7D854", VA = "0xB7D854")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0xB7D86C", Offset = "0xB7D86C", VA = "0xB7D86C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		private RenderTargetHandle destination
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0xB7D884", Offset = "0xB7D884", VA = "0xB7D884")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0xB7D898", Offset = "0xB7D898", VA = "0xB7D898")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xB7D764", Offset = "0xB7D764", VA = "0xB7D764")]
		public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xB7D8AC", Offset = "0xB7D8AC", VA = "0xB7D8AC", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xB7D9F0", Offset = "0xB7D9F0", VA = "0xB7D9F0", Slot = "7")]
		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xB7D560", Offset = "0xB7D560", VA = "0xB7D560")]
		public CopyFramePass()
		{
		}
	}

	[Token(Token = "0x2000006")]
	private class DrawOldFramePass : ScriptableRenderPass
	{
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material m_DrawOldFrameMaterial;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTargetHandle m_handle;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string m_textureName;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xB7D78C", Offset = "0xB7D78C", VA = "0xB7D78C")]
		public void Setup(Material drawOldFrameMaterial, RenderTargetHandle handle, string textureName)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xB7DAF0", Offset = "0xB7DAF0", VA = "0xB7DAF0", Slot = "6")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescripor)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xB7DB94", Offset = "0xB7DB94", VA = "0xB7DB94", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xB7D568", Offset = "0xB7D568", VA = "0xB7D568")]
		public DrawOldFramePass()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000007")]
	public class Settings
	{
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("The material that is used when the old frame is redrawn at the start of the new frame (before opaques).")]
		public Material displayMaterial;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The name of the texture used for referencing the copied frame. (Defaults to _FrameCopyTex if empty)")]
		public string textureName;

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xB7D84C", Offset = "0xB7D84C", VA = "0xB7D84C")]
		public Settings()
		{
		}
	}

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CopyFramePass m_CopyFrame;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private DrawOldFramePass m_DrawOldFame;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTargetHandle m_OldFrameHandle;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Settings settings;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xB7D494", Offset = "0xB7D494", VA = "0xB7D494", Slot = "5")]
	public override void Create()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xB7D570", Offset = "0xB7D570", VA = "0xB7D570", Slot = "7")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xB7D7D8", Offset = "0xB7D7D8", VA = "0xB7D7D8")]
	public KeepFrameFeature()
	{
	}
}
[Token(Token = "0x2000008")]
[ExecuteAlways]
public class AutoLoadPipelineAsset : MonoBehaviour
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UniversalRenderPipelineAsset m_PipelineAsset;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RenderPipelineAsset m_PreviousPipelineAsset;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_overrodeQualitySettings;

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xB7DE4C", Offset = "0xB7DE4C", VA = "0xB7DE4C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xB7DFB8", Offset = "0xB7DFB8", VA = "0xB7DFB8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xB7DE50", Offset = "0xB7DE50", VA = "0xB7DE50")]
	private void UpdatePipeline()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xB7DFBC", Offset = "0xB7DFBC", VA = "0xB7DFBC")]
	private void ResetPipeline()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xB7E048", Offset = "0xB7E048", VA = "0xB7E048")]
	public AutoLoadPipelineAsset()
	{
	}
}
[Token(Token = "0x2000009")]
[RequireComponent(typeof(CharacterController))]
public class FirstPersonController : MonoBehaviour
{
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_MouseSensitivity;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_MovementSpeed;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform m_PlayerCamera;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool m_MoveWithMouse;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CharacterController m_CharacterController;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float m_XRotation;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private byte m_ButtonMovementFlags;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xB7E050", Offset = "0xB7E050", VA = "0xB7E050")]
	private void Start()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xB7E0F0", Offset = "0xB7E0F0", VA = "0xB7E0F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xB7E108", Offset = "0xB7E108", VA = "0xB7E108")]
	private void Look()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xB7E1F0", Offset = "0xB7E1F0", VA = "0xB7E1F0")]
	private void Move()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xB7E2E0", Offset = "0xB7E2E0", VA = "0xB7E2E0")]
	private Vector2 GetLookInput()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xB7E3A4", Offset = "0xB7E3A4", VA = "0xB7E3A4")]
	private Vector3 GetMovementInput()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xB7E43C", Offset = "0xB7E43C", VA = "0xB7E43C")]
	public FirstPersonController()
	{
	}
}
[Token(Token = "0x200000A")]
public class ColliderButton : MonoBehaviour
{
	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Action action;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sprite hightLightSprite;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Sprite defaultSprite;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private SpriteRenderer spriteRenderer;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Image image;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xB7E458", Offset = "0xB7E458", VA = "0xB7E458")]
	private void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xB7E5A0", Offset = "0xB7E5A0", VA = "0xB7E5A0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xB7E6DC", Offset = "0xB7E6DC", VA = "0xB7E6DC")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xB7E7D8", Offset = "0xB7E7D8", VA = "0xB7E7D8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xB7E89C", Offset = "0xB7E89C", VA = "0xB7E89C")]
	public ColliderButton()
	{
	}
}
[Token(Token = "0x200000B")]
public static class Game
{
	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static GameObject Scene;
}
[Token(Token = "0x200000C")]
public class GripHelp_Col : MonoBehaviour
{
	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Action action_TriggerEnter;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Action action_TriggerExit;

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xB7E8A4", Offset = "0xB7E8A4", VA = "0xB7E8A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xB7E8A8", Offset = "0xB7E8A8", VA = "0xB7E8A8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xB7E938", Offset = "0xB7E938", VA = "0xB7E938")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xB7E9C8", Offset = "0xB7E9C8", VA = "0xB7E9C8")]
	public GripHelp_Col()
	{
	}
}
[Token(Token = "0x200000D")]
public class GripHelp : MonoBehaviour
{
	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Collider nearCollider;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Collider farCollider;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject obj;

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xB7E9D0", Offset = "0xB7E9D0", VA = "0xB7E9D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xB7EB60", Offset = "0xB7EB60", VA = "0xB7EB60")]
	private void Show()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xB7EB80", Offset = "0xB7EB80", VA = "0xB7EB80")]
	private void Hide()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xB7EBA0", Offset = "0xB7EBA0", VA = "0xB7EBA0")]
	public GripHelp()
	{
	}
}
[Token(Token = "0x200000E")]
public class DianTiCol : MonoBehaviour
{
	[Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class <OnCloseLift>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DianTiCol <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0xB7FA50", Offset = "0xB7FA50", VA = "0xB7FA50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0xB7FA98", Offset = "0xB7FA98", VA = "0xB7FA98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xB7F250", Offset = "0xB7F250", VA = "0xB7F250")]
		[DebuggerHidden]
		public <OnCloseLift>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xB7F94C", Offset = "0xB7F94C", VA = "0xB7F94C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xB7F950", Offset = "0xB7F950", VA = "0xB7F950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xB7FA58", Offset = "0xB7FA58", VA = "0xB7FA58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Collider openDoorButton;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Collider openDoor2Button;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Collider closeDoorButton;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject f7Button;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject f6Button;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject f5Button;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject f4Button;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject f3Button;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject f2Button;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject f1Button;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject b1Button;

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xB7EBA8", Offset = "0xB7EBA8", VA = "0xB7EBA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xB7EBAC", Offset = "0xB7EBAC", VA = "0xB7EBAC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xB7F0BC", Offset = "0xB7F0BC", VA = "0xB7F0BC")]
	private void OpenDoor()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xB7F1CC", Offset = "0xB7F1CC", VA = "0xB7F1CC")]
	private void CloseDoor()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xB7F158", Offset = "0xB7F158", VA = "0xB7F158")]
	[IteratorStateMachine(typeof(<OnCloseLift>d__16))]
	public IEnumerator OnCloseLift()
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xB7F278", Offset = "0xB7F278", VA = "0xB7F278")]
	public void OnFloor_07()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xB7F420", Offset = "0xB7F420", VA = "0xB7F420")]
	public void OnFloor_06()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xB7F4DC", Offset = "0xB7F4DC", VA = "0xB7F4DC")]
	public void OnFloor_05()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xB7F598", Offset = "0xB7F598", VA = "0xB7F598")]
	public void OnFloor_04()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xB7F654", Offset = "0xB7F654", VA = "0xB7F654")]
	public void OnFloor_03()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xB7F710", Offset = "0xB7F710", VA = "0xB7F710")]
	public void OnFloor_02()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xB7F7CC", Offset = "0xB7F7CC", VA = "0xB7F7CC")]
	public void OnFloor_01()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xB7F888", Offset = "0xB7F888", VA = "0xB7F888")]
	public void OnFloor_B1()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xB7F944", Offset = "0xB7F944", VA = "0xB7F944")]
	public DianTiCol()
	{
	}
}
[Token(Token = "0x2000010")]
public class Init : MonoBehaviour
{
	[Token(Token = "0x6000043")]
	[Address(RVA = "0xB7FAA0", Offset = "0xB7FAA0", VA = "0xB7FAA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xB7FBB8", Offset = "0xB7FBB8", VA = "0xB7FBB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xB805BC", Offset = "0xB805BC", VA = "0xB805BC")]
	public Init()
	{
	}
}
[Token(Token = "0x2000011")]
public class LevelBase : MonoBehaviour
{
	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Transform> level;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int nowId;

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xB805C4", Offset = "0xB805C4", VA = "0xB805C4")]
	public void Init()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xB80958", Offset = "0xB80958", VA = "0xB80958")]
	public void Next()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xB80A50", Offset = "0xB80A50", VA = "0xB80A50")]
	public void Last()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xB80B34", Offset = "0xB80B34", VA = "0xB80B34")]
	public void SetLevel(int _id)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xB80C04", Offset = "0xB80C04", VA = "0xB80C04")]
	public int GetLevelNowId()
	{
		return default(int);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xB80C0C", Offset = "0xB80C0C", VA = "0xB80C0C")]
	public int GetLevelCount()
	{
		return default(int);
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xB80C54", Offset = "0xB80C54", VA = "0xB80C54")]
	public LevelBase()
	{
	}
}
[Token(Token = "0x2000012")]
public class Level_TriggerNext : MonoBehaviour
{
	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool isOk;

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xB80CE4", Offset = "0xB80CE4", VA = "0xB80CE4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xB80CEC", Offset = "0xB80CEC", VA = "0xB80CEC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xB80D80", Offset = "0xB80D80", VA = "0xB80D80")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xB80CF0", Offset = "0xB80CF0", VA = "0xB80CF0")]
	private void OnNext()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xB80D84", Offset = "0xB80D84", VA = "0xB80D84")]
	public Level_TriggerNext()
	{
	}
}
[Token(Token = "0x2000013")]
public class Level_WaitNext : MonoBehaviour
{
	[Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class <OnNext>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level_WaitNext <>4__this;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xB80F58", Offset = "0xB80F58", VA = "0xB80F58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xB80FA0", Offset = "0xB80FA0", VA = "0xB80FA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xB80E20", Offset = "0xB80E20", VA = "0xB80E20")]
		[DebuggerHidden]
		public <OnNext>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xB80E58", Offset = "0xB80E58", VA = "0xB80E58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xB80E5C", Offset = "0xB80E5C", VA = "0xB80E5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xB80F60", Offset = "0xB80F60", VA = "0xB80F60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float time;

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xB80D8C", Offset = "0xB80D8C", VA = "0xB80D8C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xB80DAC", Offset = "0xB80DAC", VA = "0xB80DAC")]
	[IteratorStateMachine(typeof(<OnNext>d__2))]
	public IEnumerator OnNext()
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xB80E48", Offset = "0xB80E48", VA = "0xB80E48")]
	public Level_WaitNext()
	{
	}
}
[Token(Token = "0x2000015")]
public class Level_01 : LevelBase
{
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform playerTrans;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform firstOpenPlayerTrans;

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xB80FA8", Offset = "0xB80FA8", VA = "0xB80FA8")]
	private void Start()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xB81258", Offset = "0xB81258", VA = "0xB81258")]
	public Level_01()
	{
	}
}
[Token(Token = "0x2000016")]
public class Level_01_03 : MonoBehaviour
{
	[Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class <OnPlaySound>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level_01_03 <>4__this;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0xB8165C", Offset = "0xB8165C", VA = "0xB8165C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0xB816A4", Offset = "0xB816A4", VA = "0xB816A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xB81570", Offset = "0xB81570", VA = "0xB81570")]
		[DebuggerHidden]
		public <OnPlaySound>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xB815A0", Offset = "0xB815A0", VA = "0xB815A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xB815A4", Offset = "0xB815A4", VA = "0xB815A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xB81664", Offset = "0xB81664", VA = "0xB81664", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject enterButton;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject closeButton;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioSource audioSource;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isOk;

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xB8125C", Offset = "0xB8125C", VA = "0xB8125C")]
	private void Start()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xB81390", Offset = "0xB81390", VA = "0xB81390")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xB81398", Offset = "0xB81398", VA = "0xB81398")]
	private void OnEnter()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xB81470", Offset = "0xB81470", VA = "0xB81470")]
	private void OnClose()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xB814FC", Offset = "0xB814FC", VA = "0xB814FC")]
	[IteratorStateMachine(typeof(<OnPlaySound>d__8))]
	public IEnumerator OnPlaySound()
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xB81598", Offset = "0xB81598", VA = "0xB81598")]
	public Level_01_03()
	{
	}
}
[Token(Token = "0x2000018")]
public class Level_01_SaveData : MonoBehaviour
{
	[Token(Token = "0x6000069")]
	[Address(RVA = "0xB816AC", Offset = "0xB816AC", VA = "0xB816AC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xB817C8", Offset = "0xB817C8", VA = "0xB817C8")]
	public Level_01_SaveData()
	{
	}
}
[Token(Token = "0x2000019")]
public class Level_01_ShowText : MonoBehaviour
{
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_Text text1;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TMP_Text text2;

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xB817D0", Offset = "0xB817D0", VA = "0xB817D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xB817D4", Offset = "0xB817D4", VA = "0xB817D4")]
	public Level_01_ShowText()
	{
	}
}
[Token(Token = "0x200001A")]
public class Level_01_ZhuoPai_01 : MonoBehaviour
{
	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject playButton;

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xB817DC", Offset = "0xB817DC", VA = "0xB817DC")]
	private void Start()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xB8189C", Offset = "0xB8189C", VA = "0xB8189C")]
	public void OnPlayAim()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xB81958", Offset = "0xB81958", VA = "0xB81958")]
	public Level_01_ZhuoPai_01()
	{
	}
}
[Token(Token = "0x200001B")]
public class AnimatorController : MonoBehaviour
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isExpand;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool isClosed;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int schedule;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int resetResetProgress;

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xB81960", Offset = "0xB81960", VA = "0xB81960")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xB81964", Offset = "0xB81964", VA = "0xB81964")]
	private void Start()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xB819D4", Offset = "0xB819D4", VA = "0xB819D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xB81C94", Offset = "0xB81C94", VA = "0xB81C94")]
	public void Expand()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xB81D00", Offset = "0xB81D00", VA = "0xB81D00")]
	public void Closed()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xB81E4C", Offset = "0xB81E4C", VA = "0xB81E4C")]
	public void Switch()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xB82004", Offset = "0xB82004", VA = "0xB82004")]
	public AnimatorController()
	{
	}
}
[Token(Token = "0x200001C")]
public static class JsonTool
{
	[Token(Token = "0x6000077")]
	[Address(RVA = "0xB82014", Offset = "0xB82014", VA = "0xB82014")]
	public static int JsonToInt(JsonObject _json, string _index)
	{
		return default(int);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xB82104", Offset = "0xB82104", VA = "0xB82104")]
	public static float JsonToFloat(JsonObject _json, string _index)
	{
		return default(float);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xB821F8", Offset = "0xB821F8", VA = "0xB821F8")]
	public static string JsonToString(JsonObject _json, string _index)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xB8228C", Offset = "0xB8228C", VA = "0xB8228C")]
	public static JsonObject GetChildJson(JsonObject _json, string _index)
	{
		return null;
	}
}
[Token(Token = "0x200001D")]
public class ComponentSettings : MonoBehaviour
{
	[Token(Token = "0x600007B")]
	[Address(RVA = "0xB8233C", Offset = "0xB8233C", VA = "0xB8233C")]
	private void Start()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xB82340", Offset = "0xB82340", VA = "0xB82340")]
	private void Update()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xB82344", Offset = "0xB82344", VA = "0xB82344")]
	public void GetCurrentGameObjectPos()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xB82488", Offset = "0xB82488", VA = "0xB82488")]
	public ComponentSettings()
	{
	}
}
[Token(Token = "0x200001E")]
public class DataManager : MonoBehaviour
{
	[Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class <LoadDataImpl>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string _name;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DataManager <>4__this;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWW <www>5__2;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xB82BBC", Offset = "0xB82BBC", VA = "0xB82BBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0xB82C04", Offset = "0xB82C04", VA = "0xB82C04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xB8263C", Offset = "0xB8263C", VA = "0xB8263C")]
		[DebuggerHidden]
		public <LoadDataImpl>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xB8283C", Offset = "0xB8283C", VA = "0xB8283C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xB82840", Offset = "0xB82840", VA = "0xB82840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xB82BC4", Offset = "0xB82BC4", VA = "0xB82BC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DataManager Instance;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, JsonObject> dicJsonObject;

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xB82490", Offset = "0xB82490", VA = "0xB82490")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xB82534", Offset = "0xB82534", VA = "0xB82534")]
	private void Start()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xB8258C", Offset = "0xB8258C", VA = "0xB8258C")]
	public void LoadData(string _name)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xB825AC", Offset = "0xB825AC", VA = "0xB825AC")]
	[IteratorStateMachine(typeof(<LoadDataImpl>d__5))]
	private IEnumerator LoadDataImpl(string _name)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xB82664", Offset = "0xB82664", VA = "0xB82664")]
	public JsonObject GetJsonObject(string tbName)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xB826F8", Offset = "0xB826F8", VA = "0xB826F8")]
	public JsonObject GetJsonDataByIndex(string index, string tbName)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xB82720", Offset = "0xB82720", VA = "0xB82720")]
	public string GetIntroductionByName(string name)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xB827B4", Offset = "0xB827B4", VA = "0xB827B4")]
	public DataManager()
	{
	}
}
[Token(Token = "0x2000020")]
public class DisassembleManagement : MonoBehaviour
{
	[Token(Token = "0x2000021")]
	public delegate void Disassembly(WaterPumpComponent waterPump);

	[Token(Token = "0x2000022")]
	public delegate void Assembly(WaterPumpComponent waterPump);

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static DisassembleManagement _instance;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public bool logicSwitch;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[Tooltip("选择从编号大的开始拖拽还是从小的开始拖拽")]
	private bool dragDirection;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject waterPumpComponentParent;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<WaterPumpComponent> assemble;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<WaterPumpComponent> dismantling;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Disassembly DisassemblyDelegate;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Assembly AssemblyDelegate;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public WaterPumpComponent currentDragGameobject;

	[Token(Token = "0x1700000B")]
	public static DisassembleManagement Instance
	{
		[Token(Token = "0x600008D")]
		[Address(RVA = "0xB82C0C", Offset = "0xB82C0C", VA = "0xB82C0C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000C")]
	public WaterPumpComponent CurrentDragGameobject
	{
		[Token(Token = "0x600008F")]
		[Address(RVA = "0xB82EB4", Offset = "0xB82EB4", VA = "0xB82EB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600008E")]
		[Address(RVA = "0xB82CF8", Offset = "0xB82CF8", VA = "0xB82CF8")]
		set
		{
		}
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xB82EBC", Offset = "0xB82EBC", VA = "0xB82EBC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xB82EC0", Offset = "0xB82EC0", VA = "0xB82EC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xB832A8", Offset = "0xB832A8", VA = "0xB832A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xB832AC", Offset = "0xB832AC", VA = "0xB832AC")]
	public bool IsIncludingPartsInAssemble(WaterPumpComponent waterPumpComponent)
	{
		return default(bool);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xB83304", Offset = "0xB83304", VA = "0xB83304")]
	public bool IsIncludingPartsInDismantling(WaterPumpComponent waterPumpComponent)
	{
		return default(bool);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xB82FF8", Offset = "0xB82FF8", VA = "0xB82FF8")]
	public void UpdateSelection()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xB834E8", Offset = "0xB834E8", VA = "0xB834E8")]
	public Vector3[] GetTargetGameObject()
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xB83930", Offset = "0xB83930", VA = "0xB83930")]
	public bool DetermineCurrentPartIs(WaterPumpComponent currentComponent)
	{
		return default(bool);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xB8335C", Offset = "0xB8335C", VA = "0xB8335C")]
	public bool DetermineIfTheCurrentPartIs(WaterPumpComponent currentComponent)
	{
		return default(bool);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xB83B08", Offset = "0xB83B08", VA = "0xB83B08")]
	public void AddAssemble(WaterPumpComponent waterPump)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xB83C7C", Offset = "0xB83C7C", VA = "0xB83C7C")]
	public void RemoveAssemble(WaterPumpComponent waterPump)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xB83D5C", Offset = "0xB83D5C", VA = "0xB83D5C")]
	public void AddDismantling(WaterPumpComponent waterPump)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xB83E98", Offset = "0xB83E98", VA = "0xB83E98")]
	public void RemoveDismantling(WaterPumpComponent waterPump)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xB82ED8", Offset = "0xB82ED8", VA = "0xB82ED8")]
	private void WaterPumpComponentInit()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xB83F78", Offset = "0xB83F78", VA = "0xB83F78")]
	private void Sort()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xB840F4", Offset = "0xB840F4", VA = "0xB840F4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xB841CC", Offset = "0xB841CC", VA = "0xB841CC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xB842A0", Offset = "0xB842A0", VA = "0xB842A0")]
	public void OneButtonReset()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xB845E8", Offset = "0xB845E8", VA = "0xB845E8")]
	public DisassembleManagement()
	{
	}
}
[Token(Token = "0x2000023")]
public class HighlightBlinkControl : MonoBehaviour
{
	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Material[] materials;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material material;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector4 vector4;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float r;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float g;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float b;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float a;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int targetNamber;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool openOrClose;

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xB84998", Offset = "0xB84998", VA = "0xB84998")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xB84AD8", Offset = "0xB84AD8", VA = "0xB84AD8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xB8391C", Offset = "0xB8391C", VA = "0xB8391C")]
	public void Show()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xB83928", Offset = "0xB83928", VA = "0xB83928")]
	public void Hide()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xB84CB0", Offset = "0xB84CB0", VA = "0xB84CB0")]
	public HighlightBlinkControl()
	{
	}
}
[Token(Token = "0x2000024")]
public class IndicatorMark : MonoBehaviour
{
	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int tagNumber;

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xB84CB8", Offset = "0xB84CB8", VA = "0xB84CB8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xB84CBC", Offset = "0xB84CBC", VA = "0xB84CBC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xB84CC0", Offset = "0xB84CC0", VA = "0xB84CC0")]
	public void Show()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xB84CE4", Offset = "0xB84CE4", VA = "0xB84CE4")]
	public void Hide()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xB84D08", Offset = "0xB84D08", VA = "0xB84D08")]
	public IndicatorMark()
	{
	}
}
[Token(Token = "0x2000025")]
public class Level_11 : MonoBehaviour
{
	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform playerTrans;

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xB84D10", Offset = "0xB84D10", VA = "0xB84D10")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xB84DF4", Offset = "0xB84DF4", VA = "0xB84DF4")]
	public Level_11()
	{
	}
}
[Token(Token = "0x2000026")]
public class ProjectManager : MonoBehaviour
{
	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ProjectManager _instance;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ToolTipManager toolTipManager;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 currentGameObjectPos;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int progressPress;

	[Token(Token = "0x1700000D")]
	public static ProjectManager Instance
	{
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xB82390", Offset = "0xB82390", VA = "0xB82390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xB84DFC", Offset = "0xB84DFC", VA = "0xB84DFC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xB84E00", Offset = "0xB84E00", VA = "0xB84E00")]
	private void Start()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xB84E7C", Offset = "0xB84E7C", VA = "0xB84E7C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xB8247C", Offset = "0xB8247C", VA = "0xB8247C")]
	public void GetCurrentGameObjectPos(Vector3 curPos)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xB84E80", Offset = "0xB84E80", VA = "0xB84E80")]
	public void SetToolTipPos()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xB8505C", Offset = "0xB8505C", VA = "0xB8505C")]
	public ProjectManager()
	{
	}
}
[Token(Token = "0x2000027")]
public class StepManager : MonoBehaviour
{
	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static StepManager _instance;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject objStep01;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject objStep02;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject objStep03;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject[] stepManualHideGameObjects;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject[] stepOtherShowGameObjects;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject[] step1OtherShowGameObjects;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private UIManager uiManager;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public int step;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject objCurStep;

	[Token(Token = "0x1700000E")]
	public static StepManager Instance
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xB850C0", Offset = "0xB850C0", VA = "0xB850C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xB851AC", Offset = "0xB851AC", VA = "0xB851AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xB85270", Offset = "0xB85270", VA = "0xB85270")]
	public void ChangeStep(int stepNumber)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xB855F4", Offset = "0xB855F4", VA = "0xB855F4")]
	public StepManager()
	{
	}
}
[Token(Token = "0x2000028")]
public class TargetManager : MonoBehaviour
{
	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IndicatorMark[] indicatorMarks;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static TargetManager _instance;

	[Token(Token = "0x1700000F")]
	public static TargetManager Instance
	{
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xB855FC", Offset = "0xB855FC", VA = "0xB855FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xB856E8", Offset = "0xB856E8", VA = "0xB856E8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xB856EC", Offset = "0xB856EC", VA = "0xB856EC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xB85A14", Offset = "0xB85A14", VA = "0xB85A14")]
	public void SetTargetPos(IndicatorMark indicator, Vector3 pos)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xB85A68", Offset = "0xB85A68", VA = "0xB85A68")]
	public TargetManager()
	{
	}
}
[Token(Token = "0x2000029")]
public class test : MonoBehaviour
{
	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Material[] material;

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xB85ACC", Offset = "0xB85ACC", VA = "0xB85ACC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xB85C78", Offset = "0xB85C78", VA = "0xB85C78")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xB85DD4", Offset = "0xB85DD4", VA = "0xB85DD4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xB85DD8", Offset = "0xB85DD8", VA = "0xB85DD8")]
	public test()
	{
	}
}
[Token(Token = "0x200002A")]
public class ToolTipManager : MonoBehaviour
{
	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float xOffset;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float yOffset;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float zOffset;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject cameraGameObject;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CanvasGroup toolTipGroup;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float showAndHideSpeed;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float currentAlpha;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float targetAlpha;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Text introduction;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Text title;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject waterPump;

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xB85DE0", Offset = "0xB85DE0", VA = "0xB85DE0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xB86000", Offset = "0xB86000", VA = "0xB86000")]
	private void Update()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xB84F30", Offset = "0xB84F30", VA = "0xB84F30")]
	public void SetPosition(Vector3 pos)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xB86144", Offset = "0xB86144", VA = "0xB86144")]
	private void LookAtCamera(GameObject camera)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xB861E0", Offset = "0xB861E0", VA = "0xB861E0")]
	public void Show(string name)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xB8626C", Offset = "0xB8626C", VA = "0xB8626C")]
	public void Hide()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xB862E8", Offset = "0xB862E8", VA = "0xB862E8")]
	public ToolTipManager()
	{
	}
}
[Token(Token = "0x200002B")]
public class UIManager : MonoBehaviour
{
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button objBtn1;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button objBtn2;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button ziDong;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Button shouDong;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Button jieShao;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Button ziDongBuZhou;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Button oneButtonReset;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int schedule;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Text but1Text;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Text ziDongBuZhouText;

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xB86300", Offset = "0xB86300", VA = "0xB86300")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xB8650C", Offset = "0xB8650C", VA = "0xB8650C")]
	private void Delay()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xB8652C", Offset = "0xB8652C", VA = "0xB8652C")]
	public void ZiDongBuZhouSwitch()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xB86628", Offset = "0xB86628", VA = "0xB86628")]
	public void ZiDong()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xB866B4", Offset = "0xB866B4", VA = "0xB866B4")]
	public void ShouDong()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xB86740", Offset = "0xB86740", VA = "0xB86740")]
	public void JieShao()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xB85564", Offset = "0xB85564", VA = "0xB85564")]
	public void ChangeSetp()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xB867CC", Offset = "0xB867CC", VA = "0xB867CC")]
	public UIManager()
	{
	}
}
[Token(Token = "0x200002C")]
public class WaterPumpComponent : MonoBehaviour
{
	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("拖拽顺序编号")]
	public int sequenceNumber;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool isDrag;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject initialParent;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("相对于父物体   自身初始位置")]
	public Vector3 initialPersonalPosition;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("相对于父物体   自身初始旋转")]
	public Vector3 initialPersonalRotation;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("相对于世界   自身初始位置")]
	public Vector3 initialWorldLocation;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[Tooltip("相对一世界   自身初始旋转")]
	public Vector3 initialWorldRotation;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Tooltip("拆解后放置的位置")]
	public Transform disassembledPosition;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Tooltip("吸附检测距离")]
	public float adsorptionDistance;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Rigidbody gameobjectRigid;

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xB867DC", Offset = "0xB867DC", VA = "0xB867DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xB867E0", Offset = "0xB867E0", VA = "0xB867E0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xB86BF0", Offset = "0xB86BF0", VA = "0xB86BF0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xB844E8", Offset = "0xB844E8", VA = "0xB844E8")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xB86C90", Offset = "0xB86C90", VA = "0xB86C90")]
	private void DisassemblyPlacingTheGround()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xB86D38", Offset = "0xB86D38", VA = "0xB86D38")]
	public void AddGravity()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xB86BF4", Offset = "0xB86BF4", VA = "0xB86BF4")]
	public void RemoveGravity()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xB86D3C", Offset = "0xB86D3C", VA = "0xB86D3C")]
	public void PlacementDetection()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xB871A8", Offset = "0xB871A8", VA = "0xB871A8")]
	public void LogicSwitchDetection()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xB871C8", Offset = "0xB871C8", VA = "0xB871C8")]
	public WaterPumpComponent()
	{
	}
}
[Token(Token = "0x200002D")]
public class Level_12 : MonoBehaviour
{
	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform playerTrans;

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xB87268", Offset = "0xB87268", VA = "0xB87268")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xB8734C", Offset = "0xB8734C", VA = "0xB8734C")]
	public Level_12()
	{
	}
}
[Token(Token = "0x200002E")]
public class Level_13 : MonoBehaviour
{
	[Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class <LockNeedle>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level_13 <>4__this;

		[Token(Token = "0x17000010")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0xB87850", Offset = "0xB87850", VA = "0xB87850", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0xB87898", Offset = "0xB87898", VA = "0xB87898", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xB876C8", Offset = "0xB876C8", VA = "0xB876C8")]
		[DebuggerHidden]
		public <LockNeedle>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xB876F8", Offset = "0xB876F8", VA = "0xB876F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xB876FC", Offset = "0xB876FC", VA = "0xB876FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xB87858", Offset = "0xB87858", VA = "0xB87858", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform playerTrans;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject nowNeedle;

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xB87354", Offset = "0xB87354", VA = "0xB87354")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xB87438", Offset = "0xB87438", VA = "0xB87438")]
	public void SetNowNeedleSelectEnter(GameObject _needle)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xB874F0", Offset = "0xB874F0", VA = "0xB874F0")]
	public void SetNowNeedleSelectExite()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xB87654", Offset = "0xB87654", VA = "0xB87654")]
	[IteratorStateMachine(typeof(<LockNeedle>d__5))]
	public IEnumerator LockNeedle()
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xB876F0", Offset = "0xB876F0", VA = "0xB876F0")]
	public Level_13()
	{
	}
}
[Token(Token = "0x2000030")]
public class Level_13_Body : MonoBehaviour
{
	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xB878A0", Offset = "0xB878A0", VA = "0xB878A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xB878A4", Offset = "0xB878A4", VA = "0xB878A4")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xB879D4", Offset = "0xB879D4", VA = "0xB879D4")]
	private void OnTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xB87B00", Offset = "0xB87B00", VA = "0xB87B00")]
	public Level_13_Body()
	{
	}
}
[Token(Token = "0x2000031")]
public class Level_13_Needle : MonoBehaviour
{
	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isOnAcupoint;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool isOnNeedleStay;

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xB87B08", Offset = "0xB87B08", VA = "0xB87B08")]
	public Level_13_Needle()
	{
	}
}
[Token(Token = "0x2000032")]
public class Level_13_Point : MonoBehaviour
{
	[Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class <OnRestSound>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level_13_Point <>4__this;

		[Token(Token = "0x17000012")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0xB88008", Offset = "0xB88008", VA = "0xB88008", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0xB88050", Offset = "0xB88050", VA = "0xB88050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xB87F20", Offset = "0xB87F20", VA = "0xB87F20")]
		[DebuggerHidden]
		public <OnRestSound>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xB87F50", Offset = "0xB87F50", VA = "0xB87F50", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xB87F54", Offset = "0xB87F54", VA = "0xB87F54", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xB88010", Offset = "0xB88010", VA = "0xB88010", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool isPlaying;

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xB87B10", Offset = "0xB87B10", VA = "0xB87B10")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xB87B88", Offset = "0xB87B88", VA = "0xB87B88")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xB87DF4", Offset = "0xB87DF4", VA = "0xB87DF4")]
	private void OnTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xB87D80", Offset = "0xB87D80", VA = "0xB87D80")]
	[IteratorStateMachine(typeof(<OnRestSound>d__4))]
	public IEnumerator OnRestSound()
	{
		return null;
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xB87F48", Offset = "0xB87F48", VA = "0xB87F48")]
	public Level_13_Point()
	{
	}
}
[Token(Token = "0x2000034")]
public class Level_13_WaitPlaySound : MonoBehaviour
{
	[Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class <OnPlaySound>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level_13_WaitPlaySound <>4__this;

		[Token(Token = "0x17000014")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0xB882A4", Offset = "0xB882A4", VA = "0xB882A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0xB882EC", Offset = "0xB882EC", VA = "0xB882EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xB88160", Offset = "0xB88160", VA = "0xB88160")]
		[DebuggerHidden]
		public <OnPlaySound>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xB88198", Offset = "0xB88198", VA = "0xB88198", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xB8819C", Offset = "0xB8819C", VA = "0xB8819C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xB882AC", Offset = "0xB882AC", VA = "0xB882AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject obj;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float time;

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xB88058", Offset = "0xB88058", VA = "0xB88058")]
	private void Start()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xB880EC", Offset = "0xB880EC", VA = "0xB880EC")]
	[IteratorStateMachine(typeof(<OnPlaySound>d__3))]
	public IEnumerator OnPlaySound()
	{
		return null;
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xB88188", Offset = "0xB88188", VA = "0xB88188")]
	public Level_13_WaitPlaySound()
	{
	}
}
[Token(Token = "0x2000036")]
public class Level_14 : MonoBehaviour
{
	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform playerTrans;

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xB882F4", Offset = "0xB882F4", VA = "0xB882F4")]
	private void Start()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xB883D8", Offset = "0xB883D8", VA = "0xB883D8")]
	public Level_14()
	{
	}
}
[Token(Token = "0x2000037")]
public class Level_15 : MonoBehaviour
{
	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform playerTrans;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject openGameButton;

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xB883E0", Offset = "0xB883E0", VA = "0xB883E0")]
	private void Start()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xB884C4", Offset = "0xB884C4", VA = "0xB884C4")]
	public void OnOpenGame()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xB88580", Offset = "0xB88580", VA = "0xB88580")]
	public Level_15()
	{
	}
}
[Token(Token = "0x2000038")]
public class Level_16 : MonoBehaviour
{
	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform playerTrans;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] allUI;

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xB88588", Offset = "0xB88588", VA = "0xB88588")]
	private void Start()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xB8866C", Offset = "0xB8866C", VA = "0xB8866C")]
	public void ShowObj(int _n)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xB887B4", Offset = "0xB887B4", VA = "0xB887B4")]
	public Level_16()
	{
	}
}
[Token(Token = "0x2000039")]
public class Level_17 : MonoBehaviour
{
	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform playerTrans;

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xB887BC", Offset = "0xB887BC", VA = "0xB887BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xB888A0", Offset = "0xB888A0", VA = "0xB888A0")]
	public Level_17()
	{
	}
}
[Token(Token = "0x200003A")]
public class Level_17_ErTongJieCol : MonoBehaviour
{
	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource audioSource;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator animator;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool isPlaying;

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xB888A8", Offset = "0xB888A8", VA = "0xB888A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xB888AC", Offset = "0xB888AC", VA = "0xB888AC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xB88930", Offset = "0xB88930", VA = "0xB88930")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xB8899C", Offset = "0xB8899C", VA = "0xB8899C")]
	public Level_17_ErTongJieCol()
	{
	}
}
[Token(Token = "0x200003B")]
public class CharacterLOD : MonoBehaviour
{
	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject LOD0;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject LOD1;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float lodDist;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Camera camera1;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool foundCamera;

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xB889A4", Offset = "0xB889A4", VA = "0xB889A4")]
	public void Start()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xB88AA8", Offset = "0xB88AA8", VA = "0xB88AA8")]
	private void Update()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xB88ACC", Offset = "0xB88ACC", VA = "0xB88ACC")]
	public void UpdateMeshLOD()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xB889A8", Offset = "0xB889A8", VA = "0xB889A8")]
	public void GetCamera()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xB88CD4", Offset = "0xB88CD4", VA = "0xB88CD4")]
	public CharacterLOD()
	{
	}
}
[Token(Token = "0x200003C")]
public class DeveloperCol : MonoBehaviour
{
	[Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class <OnRestSound>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DeveloperCol <>4__this;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0xB88F8C", Offset = "0xB88F8C", VA = "0xB88F8C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0xB88FD4", Offset = "0xB88FD4", VA = "0xB88FD4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xB88E90", Offset = "0xB88E90", VA = "0xB88E90")]
		[DebuggerHidden]
		public <OnRestSound>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xB88EC0", Offset = "0xB88EC0", VA = "0xB88EC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xB88EC4", Offset = "0xB88EC4", VA = "0xB88EC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xB88F94", Offset = "0xB88F94", VA = "0xB88F94", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Collider buttonCol;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource audioSource;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject ui;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isPlaying;

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xB88CE4", Offset = "0xB88CE4", VA = "0xB88CE4")]
	private void Start()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xB88DB8", Offset = "0xB88DB8", VA = "0xB88DB8")]
	private void OnClickButton()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xB88E1C", Offset = "0xB88E1C", VA = "0xB88E1C")]
	[IteratorStateMachine(typeof(<OnRestSound>d__6))]
	public IEnumerator OnRestSound()
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xB88EB8", Offset = "0xB88EB8", VA = "0xB88EB8")]
	public DeveloperCol()
	{
	}
}
[Token(Token = "0x200003E")]
public class MmCol : MonoBehaviour
{
	[Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class <OnRestSound>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float _time;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MmCol <>4__this;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0xB89630", Offset = "0xB89630", VA = "0xB89630", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0xB89678", Offset = "0xB89678", VA = "0xB89678", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xB89268", Offset = "0xB89268", VA = "0xB89268")]
		[DebuggerHidden]
		public <OnRestSound>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xB8953C", Offset = "0xB8953C", VA = "0xB8953C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xB89540", Offset = "0xB89540", VA = "0xB89540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xB89638", Offset = "0xB89638", VA = "0xB89638", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Collider buttonCol;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TMP_Text text;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioSource audioSource;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<AudioClip> audioClips;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<string> texts;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<float> times;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int id;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool isPlaying;

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xB88FDC", Offset = "0xB88FDC", VA = "0xB88FDC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xB8909C", Offset = "0xB8909C", VA = "0xB8909C")]
	private void OnClickButton()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xB891E4", Offset = "0xB891E4", VA = "0xB891E4")]
	[IteratorStateMachine(typeof(<OnRestSound>d__10))]
	public IEnumerator OnRestSound(float _time)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xB89290", Offset = "0xB89290", VA = "0xB89290")]
	public MmCol()
	{
	}
}
[Token(Token = "0x2000040")]
public class RmbCol : MonoBehaviour
{
	[Token(Token = "0x6000131")]
	[Address(RVA = "0xB89680", Offset = "0xB89680", VA = "0xB89680")]
	private void Start()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xB89684", Offset = "0xB89684", VA = "0xB89684")]
	private void Update()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xB89688", Offset = "0xB89688", VA = "0xB89688")]
	public RmbCol()
	{
	}
}
[Token(Token = "0x2000041")]
public class ShouBiaoCol : MonoBehaviour
{
	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject shouBiaoEffectButton;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject shouBiaoEffectObj;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject ui_Main;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject ui_Money;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject ui_CallSecretary;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject ui_Help;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool _shouBiaoShow;

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xB89690", Offset = "0xB89690", VA = "0xB89690")]
	private void Start()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xB89764", Offset = "0xB89764", VA = "0xB89764")]
	private void OnShouBiaoEffect()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xB89808", Offset = "0xB89808", VA = "0xB89808")]
	public void ShowUI(int _n)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xB898D8", Offset = "0xB898D8", VA = "0xB898D8")]
	public ShouBiaoCol()
	{
	}
}
[Token(Token = "0x2000042")]
public class ShouBiaoUI_CallMm : MonoBehaviour
{
	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject closeButton;

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xB898E8", Offset = "0xB898E8", VA = "0xB898E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xB899A8", Offset = "0xB899A8", VA = "0xB899A8")]
	private void OnClose()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xB89A54", Offset = "0xB89A54", VA = "0xB89A54")]
	public ShouBiaoUI_CallMm()
	{
	}
}
[Token(Token = "0x2000043")]
public class ShouBiaoUI_Help : MonoBehaviour
{
	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject closeButton;

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xB89A5C", Offset = "0xB89A5C", VA = "0xB89A5C")]
	private void Start()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xB89B1C", Offset = "0xB89B1C", VA = "0xB89B1C")]
	private void OnClose()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xB89BC8", Offset = "0xB89BC8", VA = "0xB89BC8")]
	public ShouBiaoUI_Help()
	{
	}
}
[Token(Token = "0x2000044")]
public class ShouBiaoUI_Main : MonoBehaviour
{
	[Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class <ShowMoney>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShouBiaoUI_Main <>4__this;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0xB8A494", Offset = "0xB8A494", VA = "0xB8A494", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xB8A4DC", Offset = "0xB8A4DC", VA = "0xB8A4DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xB89E68", Offset = "0xB89E68", VA = "0xB89E68")]
		[DebuggerHidden]
		public <ShowMoney>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xB8A1A8", Offset = "0xB8A1A8", VA = "0xB8A1A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xB8A1AC", Offset = "0xB8A1AC", VA = "0xB8A1AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xB8A49C", Offset = "0xB8A49C", VA = "0xB8A49C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject moneyButton;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TMP_Text moneyText;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject rayButton;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject rayObj1;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject rayObj2;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TMP_Text rayText;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject showMmButton;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject helpButton;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _rayShow;

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xB89BD0", Offset = "0xB89BD0", VA = "0xB89BD0")]
	private void Start()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xB89DD4", Offset = "0xB89DD4", VA = "0xB89DD4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xB89DF4", Offset = "0xB89DF4", VA = "0xB89DF4")]
	[IteratorStateMachine(typeof(<ShowMoney>d__10))]
	private IEnumerator ShowMoney()
	{
		return null;
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xB89E90", Offset = "0xB89E90", VA = "0xB89E90")]
	private void ShowMoneyUI()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xB89F3C", Offset = "0xB89F3C", VA = "0xB89F3C")]
	private void OnRay()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xB8A048", Offset = "0xB8A048", VA = "0xB8A048")]
	private void ShowMm()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xB8A0F4", Offset = "0xB8A0F4", VA = "0xB8A0F4")]
	private void ShowHelp()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xB8A1A0", Offset = "0xB8A1A0", VA = "0xB8A1A0")]
	public ShouBiaoUI_Main()
	{
	}
}
[Token(Token = "0x2000046")]
public class ShouBiaoUI_Money : MonoBehaviour
{
	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_Text moneyText;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject closeButton;

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xB8A4E4", Offset = "0xB8A4E4", VA = "0xB8A4E4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xB8A5A0", Offset = "0xB8A5A0", VA = "0xB8A5A0")]
	private void Start()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xB8A660", Offset = "0xB8A660", VA = "0xB8A660")]
	private void OnClose()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xB8A70C", Offset = "0xB8A70C", VA = "0xB8A70C")]
	public ShouBiaoUI_Money()
	{
	}
}
[Token(Token = "0x2000047")]
public class XrFPSInput : MonoBehaviour
{
	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_Text text;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public InputActionProperty head_Position;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public InputActionProperty head_Rotation;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public InputActionProperty leftHand_Position;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public InputActionProperty leftHand_Rotation;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public InputActionProperty rightHand_Position;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public InputActionProperty righHand_Rotation;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public InputActionProperty button_Move;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public InputActionProperty button_Fire;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public InputActionProperty button_Grip;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public InputActionProperty button_EnterVehicle;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public InputActionProperty button_Menu;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Vector3 headPosition;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public Quaternion headRotation;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	public Vector3 leftHandPosition;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public Quaternion leftHandRotation;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public Vector3 rightHandPosition;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	public Quaternion rightHandRotation;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	public Vector2 buttonMove;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	public float buttonFire;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public float buttonGrip;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	public float buttonEnterVehicle;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public float buttonMenu;

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xB8A714", Offset = "0xB8A714", VA = "0xB8A714")]
	private void Start()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xB8A718", Offset = "0xB8A718", VA = "0xB8A718")]
	private void Update()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xB8AD7C", Offset = "0xB8AD7C", VA = "0xB8AD7C")]
	public XrFPSInput()
	{
	}
}
[Token(Token = "0x2000048")]
public class XrInputTest : MonoBehaviour
{
	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InputActionProperty pinchActionProperty;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public InputActionProperty gripActionProperty;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public InputActionProperty moveActionProperty;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public InputActionProperty button_X;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public InputActionProperty button_Y;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public InputActionProperty button_Menu1;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public InputActionProperty button_A;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public InputActionProperty button_B;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public InputActionProperty button_Menu2;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public float pinchValue;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public float gripValue;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Vector2 moveValue;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public int buttonValue;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public float buttonX;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public float buttonY;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public float buttonMenu1;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public float buttonA;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	public float buttonB;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public float buttonMenu2;

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xB8AE08", Offset = "0xB8AE08", VA = "0xB8AE08")]
	private void Start()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xB8AE0C", Offset = "0xB8AE0C", VA = "0xB8AE0C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xB8AF60", Offset = "0xB8AF60", VA = "0xB8AF60")]
	public XrInputTest()
	{
	}
}
[Token(Token = "0x2000049")]
public class TS_CheckUpdateComponent : MonoBehaviour
{
	[Token(Token = "0x6000156")]
	[Address(RVA = "0xB8AF68", Offset = "0xB8AF68", VA = "0xB8AF68")]
	private void Start()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xB8B560", Offset = "0xB8B560", VA = "0xB8B560")]
	private double GetLoginDays(DateTime dateTime1, DateTime dateTime2)
	{
		return default(double);
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xB8B5E4", Offset = "0xB8B5E4", VA = "0xB8B5E4")]
	public TS_CheckUpdateComponent()
	{
	}
}
[Token(Token = "0x200004A")]
public class SaveData
{
	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public decimal money;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool showFirstAnimation;

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xB8B5EC", Offset = "0xB8B5EC", VA = "0xB8B5EC")]
	public SaveData()
	{
	}
}
[Token(Token = "0x200004B")]
public class TS_ConfigComponent : MonoBehaviour
{
	[Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class <Show>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0xB8B890", Offset = "0xB8B890", VA = "0xB8B890", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0xB8B8D8", Offset = "0xB8B8D8", VA = "0xB8B8D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xB8B750", Offset = "0xB8B750", VA = "0xB8B750")]
		[DebuggerHidden]
		public <Show>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xB8B7D8", Offset = "0xB8B7D8", VA = "0xB8B7D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xB8B7DC", Offset = "0xB8B7DC", VA = "0xB8B7DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xB8B898", Offset = "0xB8B898", VA = "0xB8B898", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool setFirtLoginPlayerPos;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SaveData saveData;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string log;

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xB8B5FC", Offset = "0xB8B5FC", VA = "0xB8B5FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xB7FDF0", Offset = "0xB7FDF0", VA = "0xB7FDF0")]
	public void Init()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xB8B660", Offset = "0xB8B660", VA = "0xB8B660")]
	public void MoneyChange(decimal _money)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xB81744", Offset = "0xB81744", VA = "0xB81744")]
	public void SaveData()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xB8B600", Offset = "0xB8B600", VA = "0xB8B600")]
	[IteratorStateMachine(typeof(<Show>d__7))]
	public IEnumerator Show()
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xB8B778", Offset = "0xB8B778", VA = "0xB8B778")]
	public TS_ConfigComponent()
	{
	}
}
[Token(Token = "0x200004D")]
public class TS_SceneComponent : MonoBehaviour
{
	[Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class <LoadSceneAndCallBack>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TS_SceneComponent <>4__this;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string _name;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action _action;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool <loadOver>5__2;

		[Token(Token = "0x1700001F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0xB8BF54", Offset = "0xB8BF54", VA = "0xB8BF54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xB8BF9C", Offset = "0xB8BF9C", VA = "0xB8BF9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xB8BA88", Offset = "0xB8BA88", VA = "0xB8BA88")]
		[DebuggerHidden]
		public <LoadSceneAndCallBack>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xB8BBB8", Offset = "0xB8BBB8", VA = "0xB8BBB8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xB8BBBC", Offset = "0xB8BBBC", VA = "0xB8BBBC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xB8BF5C", Offset = "0xB8BF5C", VA = "0xB8BF5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class <OnLoadingScene>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TS_SceneComponent <>4__this;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string _name;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0xB8C074", Offset = "0xB8C074", VA = "0xB8C074", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0xB8C0BC", Offset = "0xB8C0BC", VA = "0xB8C0BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xB8BB40", Offset = "0xB8BB40", VA = "0xB8BB40")]
		[DebuggerHidden]
		public <OnLoadingScene>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xB8BFA4", Offset = "0xB8BFA4", VA = "0xB8BFA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xB8BFA8", Offset = "0xB8BFA8", VA = "0xB8BFA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xB8C07C", Offset = "0xB8C07C", VA = "0xB8C07C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AsyncOperation operation;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float targetValue;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float nowValue;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float loadingSpeed;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int process;

	[Token(Token = "0x1700001E")]
	public int Process
	{
		[Token(Token = "0x600016E")]
		[Address(RVA = "0xB8BB68", Offset = "0xB8BB68", VA = "0xB8BB68")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xB8B8E0", Offset = "0xB8B8E0", VA = "0xB8B8E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xB802E0", Offset = "0xB802E0", VA = "0xB802E0")]
	public void Init()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xB8B8E4", Offset = "0xB8B8E4", VA = "0xB8B8E4")]
	public void Update()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xB7F334", Offset = "0xB7F334", VA = "0xB7F334")]
	public void LoadScene(string _name)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xB8B8E8", Offset = "0xB8B8E8", VA = "0xB8B8E8")]
	public void LoadScene(string _name, [Optional] Action _action)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xB8BA10", Offset = "0xB8BA10", VA = "0xB8BA10")]
	public void AddScene(string _name)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xB8B96C", Offset = "0xB8B96C", VA = "0xB8B96C")]
	[IteratorStateMachine(typeof(<LoadSceneAndCallBack>d__11))]
	public IEnumerator LoadSceneAndCallBack(string _name, [Optional] Action _action)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xB8BAB0", Offset = "0xB8BAB0", VA = "0xB8BAB0")]
	[IteratorStateMachine(typeof(<OnLoadingScene>d__12))]
	public IEnumerator OnLoadingScene(string _name)
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xB8BBA8", Offset = "0xB8BBA8", VA = "0xB8BBA8")]
	public TS_SceneComponent()
	{
	}
}
[Token(Token = "0x2000050")]
public class TS_SettingComponent : MonoBehaviour
{
	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool full;

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xB8C0C4", Offset = "0xB8C0C4", VA = "0xB8C0C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xB80380", Offset = "0xB80380", VA = "0xB80380")]
	public void Init()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xB8C0F0", Offset = "0xB8C0F0", VA = "0xB8C0F0")]
	public void SoundVolume(float v)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xB8C108", Offset = "0xB8C108", VA = "0xB8C108")]
	public void FullScreen()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xB8C120", Offset = "0xB8C120", VA = "0xB8C120")]
	public void FullScreen(bool _full)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xB8C258", Offset = "0xB8C258", VA = "0xB8C258")]
	public void SetResolution(int width, int height)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xB8C270", Offset = "0xB8C270", VA = "0xB8C270")]
	public void SetQualityLevel(int index)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xB8C280", Offset = "0xB8C280", VA = "0xB8C280")]
	public int GetQualityLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xB8C288", Offset = "0xB8C288", VA = "0xB8C288")]
	public TS_SettingComponent()
	{
	}
}
[Token(Token = "0x2000051")]
public class TS_SoundComponent : MonoBehaviour
{
	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource _audioSource1;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource _audioSource2;

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xB8C290", Offset = "0xB8C290", VA = "0xB8C290")]
	private void Start()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xB801E4", Offset = "0xB801E4", VA = "0xB801E4")]
	public void Init()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xB8C294", Offset = "0xB8C294", VA = "0xB8C294")]
	public void OnBG1Sound()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xB8C350", Offset = "0xB8C350", VA = "0xB8C350")]
	public void SetBG1Volume(float v)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xB7F3D4", Offset = "0xB7F3D4", VA = "0xB7F3D4")]
	public void OnPlayButtonSound()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xB8C444", Offset = "0xB8C444", VA = "0xB8C444")]
	public void OnPlayButtonDownSound()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xB8C490", Offset = "0xB8C490", VA = "0xB8C490")]
	public void OnPlayButtonEnterSound()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xB8C36C", Offset = "0xB8C36C", VA = "0xB8C36C")]
	public void OnPlaySound(string name, float volume = 1f)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xB8C4DC", Offset = "0xB8C4DC", VA = "0xB8C4DC")]
	public TS_SoundComponent()
	{
	}
}
[Token(Token = "0x2000052")]
public class TS_UIComponent : MonoBehaviour
{
	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UI_LodingComponent lodingComponent;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera uiCam;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject uiComponent;

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xB8C4E4", Offset = "0xB8C4E4", VA = "0xB8C4E4")]
	public void Awake()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xB800C8", Offset = "0xB800C8", VA = "0xB800C8")]
	public void Init()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xB80454", Offset = "0xB80454", VA = "0xB80454")]
	public void ShowUILoading(bool _show)
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xB8B480", Offset = "0xB8B480", VA = "0xB8B480")]
	public GameObject LoadUI(string _name)
	{
		return null;
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xB8C4E8", Offset = "0xB8C4E8", VA = "0xB8C4E8")]
	public GameObject LogUI(string mes)
	{
		return null;
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xB8C5B0", Offset = "0xB8C5B0", VA = "0xB8C5B0")]
	public GameObject LogUI(string mes, Color _color)
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xB8C6E0", Offset = "0xB8C6E0", VA = "0xB8C6E0")]
	public TS_UIComponent()
	{
	}
}
[Token(Token = "0x2000053")]
public class TS_XRInputComponent : MonoBehaviour
{
	[Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class <CreatXrPlayer>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TS_XRInputComponent <>4__this;

		[Token(Token = "0x17000023")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0xB8CAC4", Offset = "0xB8CAC4", VA = "0xB8CAC4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0xB8CB0C", Offset = "0xB8CB0C", VA = "0xB8CB0C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xB8C760", Offset = "0xB8C760", VA = "0xB8C760")]
		[DebuggerHidden]
		public <CreatXrPlayer>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xB8C850", Offset = "0xB8C850", VA = "0xB8C850", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xB8C854", Offset = "0xB8C854", VA = "0xB8C854", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xB8CACC", Offset = "0xB8CACC", VA = "0xB8CACC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class <SetPlayerPos>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TS_XRInputComponent <>4__this;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 pos;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 eulerAngles;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0xB8CD58", Offset = "0xB8CD58", VA = "0xB8CD58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0xB8CDA0", Offset = "0xB8CDA0", VA = "0xB8CDA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xB8C788", Offset = "0xB8C788", VA = "0xB8C788")]
		[DebuggerHidden]
		public <SetPlayerPos>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xB8CB14", Offset = "0xB8CB14", VA = "0xB8CB14", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xB8CB18", Offset = "0xB8CB18", VA = "0xB8CB18", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xB8CD60", Offset = "0xB8CD60", VA = "0xB8CD60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject component;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject xrObj;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject playerObj;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject simulatorObj;

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xB8C6E8", Offset = "0xB8C6E8", VA = "0xB8C6E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xB80384", Offset = "0xB80384", VA = "0xB80384")]
	public void Init()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xB8C6EC", Offset = "0xB8C6EC", VA = "0xB8C6EC")]
	[IteratorStateMachine(typeof(<CreatXrPlayer>d__6))]
	public IEnumerator CreatXrPlayer()
	{
		return null;
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0xB811A8", Offset = "0xB811A8", VA = "0xB811A8")]
	[IteratorStateMachine(typeof(<SetPlayerPos>d__7))]
	public IEnumerator SetPlayerPos(Vector3 pos, Vector3 eulerAngles)
	{
		return null;
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xB8C7B0", Offset = "0xB8C7B0", VA = "0xB8C7B0")]
	public void ShowPlayer(bool _show)
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xB8C848", Offset = "0xB8C848", VA = "0xB8C848")]
	public TS_XRInputComponent()
	{
	}
}
[Token(Token = "0x2000056")]
public class UI_LodingComponent : MonoBehaviour
{
	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject circle;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text LoadingText;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Slider loadingSlider;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float progress;

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xB8CDA8", Offset = "0xB8CDA8", VA = "0xB8CDA8")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xB8CDD0", Offset = "0xB8CDD0", VA = "0xB8CDD0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xB8BEC4", Offset = "0xB8BEC4", VA = "0xB8BEC4")]
	public void SetProgress(float _progress)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xB8CF2C", Offset = "0xB8CF2C", VA = "0xB8CF2C")]
	public UI_LodingComponent()
	{
	}
}
[Token(Token = "0x2000057")]
public class UI_LogComponent : MonoBehaviour
{
	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button buttonClose;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text text;

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xB8CF34", Offset = "0xB8CF34", VA = "0xB8CF34")]
	private void Start()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xB8C58C", Offset = "0xB8C58C", VA = "0xB8C58C")]
	public void OnLog(string _mes)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xB8C670", Offset = "0xB8C670", VA = "0xB8C670")]
	public void OnLog(string _mes, Color _color)
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xB8CFC8", Offset = "0xB8CFC8", VA = "0xB8CFC8")]
	private void OnClose()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xB8D080", Offset = "0xB8D080", VA = "0xB8D080")]
	public UI_LogComponent()
	{
	}
}
[Token(Token = "0x2000058")]
public class AnimateHandController : MonoBehaviour
{
	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InputActionProperty pinchActionProperty;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public InputActionProperty gripActionProperty;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private InputAction pinchAction;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private InputAction gripAction;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Animator animator;

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xB8D088", Offset = "0xB8D088", VA = "0xB8D088")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xB8D118", Offset = "0xB8D118", VA = "0xB8D118")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0xB8D1C8", Offset = "0xB8D1C8", VA = "0xB8D1C8")]
	public AnimateHandController()
	{
	}
}
namespace App;

[Token(Token = "0x2000059")]
public class Level_16_ButtonDown : MonoBehaviour
{
	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button enterButton;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int showObjNumber;

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xB8D1D0", Offset = "0xB8D1D0", VA = "0xB8D1D0")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xB8D264", Offset = "0xB8D264", VA = "0xB8D264")]
	private void OnEnter()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xB8D358", Offset = "0xB8D358", VA = "0xB8D358")]
	public Level_16_ButtonDown()
	{
	}
}
[Token(Token = "0x200005A")]
public class Levle_16_CloseWin : MonoBehaviour
{
	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button enterButton;

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xB8D360", Offset = "0xB8D360", VA = "0xB8D360")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xB8D3F4", Offset = "0xB8D3F4", VA = "0xB8D3F4")]
	private void OnEnter()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xB8D4B4", Offset = "0xB8D4B4", VA = "0xB8D4B4")]
	public Levle_16_CloseWin()
	{
	}
}
