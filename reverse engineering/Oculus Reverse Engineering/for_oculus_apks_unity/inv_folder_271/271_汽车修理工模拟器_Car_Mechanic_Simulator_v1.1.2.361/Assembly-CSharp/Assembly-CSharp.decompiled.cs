using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using DigitalOpus.MB.Core;
using HighlightingSystem;
using Il2CppDummyDll;
using MagicLightProbes;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TMPro;
using UltimateGameTools.MeshSimplifier;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.XR;
using VRTK;
using VRTK.Controllables;
using VRTK.Controllables.PhysicsBased;
using VRTK.Examples;
using VRTK.GrabAttachMechanics;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class BaubleColorMixer : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GlassBottle glassBottle;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Color> colors;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x12C0A78", Offset = "0x12C0A78", VA = "0x12C0A78")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x12C0C30", Offset = "0x12C0C30", VA = "0x12C0C30")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x12C0C34", Offset = "0x12C0C34", VA = "0x12C0C34")]
	public BaubleColorMixer()
	{
	}
}
[Token(Token = "0x2000003")]
public class DebugVersion : MonoBehaviour
{
	[Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DebugVersion <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x12C1248", Offset = "0x12C1248", VA = "0x12C1248", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x12C1290", Offset = "0x12C1290", VA = "0x12C1290", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x12C0D30", Offset = "0x12C0D30", VA = "0x12C0D30")]
		[DebuggerHidden]
		public <Start>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x12C0D60", Offset = "0x12C0D60", VA = "0x12C0D60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x12C0D64", Offset = "0x12C0D64", VA = "0x12C0D64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x12C1250", Offset = "0x12C1250", VA = "0x12C1250", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TMP_Text text;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x12C0CBC", Offset = "0x12C0CBC", VA = "0x12C0CBC")]
	[IteratorStateMachine(typeof(<Start>d__1))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x12C0D58", Offset = "0x12C0D58", VA = "0x12C0D58")]
	public DebugVersion()
	{
	}
}
[Token(Token = "0x2000005")]
public class escButton : MonoBehaviour
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameScript gameScript;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x12C1298", Offset = "0x12C1298", VA = "0x12C1298")]
	private void Start()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x12C12EC", Offset = "0x12C12EC", VA = "0x12C12EC")]
	public void DoESC()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x12C1308", Offset = "0x12C1308", VA = "0x12C1308")]
	public escButton()
	{
	}
}
[Token(Token = "0x2000006")]
public class FirstStepsInVR : MonoBehaviour
{
	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> steps;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int stepsCounter;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject CanvasOnTabletToShow;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int StepToShowCanvasOnTablet;

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x12C1310", Offset = "0x12C1310", VA = "0x12C1310")]
	public void NextStep()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x12C1434", Offset = "0x12C1434", VA = "0x12C1434")]
	public FirstStepsInVR()
	{
	}
}
[Token(Token = "0x2000007")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/FXAA")]
public class FXAA : MonoBehaviour
{
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Shader shader;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material mat;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x12C14C4", Offset = "0x12C14C4", VA = "0x12C14C4")]
	private void CreateMaterialIfNeeded()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x12C1620", Offset = "0x12C1620", VA = "0x12C1620")]
	private void Start()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x12C1624", Offset = "0x12C1624", VA = "0x12C1624")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x12C1744", Offset = "0x12C1744", VA = "0x12C1744")]
	public FXAA()
	{
	}
}
[Token(Token = "0x2000008")]
public class InputTest : MonoBehaviour
{
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI debugTxt;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform leftHand;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform rightHand;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x12C174C", Offset = "0x12C174C", VA = "0x12C174C")]
	protected void Update()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x12C18F4", Offset = "0x12C18F4", VA = "0x12C18F4")]
	private void DebugState(XRNode node, InputDevice device, StringBuilder sb)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x12C2124", Offset = "0x12C2124", VA = "0x12C2124")]
	private void Start()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x12C22E8", Offset = "0x12C22E8", VA = "0x12C22E8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x12C22EC", Offset = "0x12C22EC", VA = "0x12C22EC")]
	public InputTest()
	{
	}
}
[Token(Token = "0x2000009")]
public class InteractableObjectWithWheels : VRE_InteractableObjectWithWheels
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public List<GameObject> collidersToActiveWhenGrab;

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x12C22F4", Offset = "0x12C22F4", VA = "0x12C22F4", Slot = "27")]
	public override void Grabbed([Optional] VRTK_InteractGrab currentGrabbingObject)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x12C24A0", Offset = "0x12C24A0", VA = "0x12C24A0", Slot = "29")]
	public override void Ungrabbed([Optional] VRTK_InteractGrab previousGrabbingObject)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x12C264C", Offset = "0x12C264C", VA = "0x12C264C")]
	public InteractableObjectWithWheels()
	{
	}
}
[Token(Token = "0x200000A")]
public class ObjectRotator : MonoBehaviour
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Rigidbody body;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x12C2654", Offset = "0x12C2654", VA = "0x12C2654")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x12C2690", Offset = "0x12C2690", VA = "0x12C2690")]
	public void RotateObject(Vector3 eulerAngles)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x12C2B18", Offset = "0x12C2B18", VA = "0x12C2B18")]
	public ObjectRotator()
	{
	}
}
[Token(Token = "0x200000B")]
public class RattleWrench : VR_BoltingTool
{
	[Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class <WrenchCoroutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RattleWrench <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x12C46B4", Offset = "0x12C46B4", VA = "0x12C46B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x12C46FC", Offset = "0x12C46FC", VA = "0x12C46FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x12C3ECC", Offset = "0x12C3ECC", VA = "0x12C3ECC")]
		[DebuggerHidden]
		public <WrenchCoroutine>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x12C4318", Offset = "0x12C4318", VA = "0x12C4318", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x12C431C", Offset = "0x12C431C", VA = "0x12C431C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x12C46BC", Offset = "0x12C46BC", VA = "0x12C46BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class <AutomaticBoltScewCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RattleWrench <>4__this;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float deltaRot;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x12C481C", Offset = "0x12C481C", VA = "0x12C481C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x12C4864", Offset = "0x12C4864", VA = "0x12C4864", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x12C3EF4", Offset = "0x12C3EF4", VA = "0x12C3EF4")]
		[DebuggerHidden]
		public <AutomaticBoltScewCoroutine>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x12C4704", Offset = "0x12C4704", VA = "0x12C4704", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x12C4708", Offset = "0x12C4708", VA = "0x12C4708", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x12C4824", Offset = "0x12C4824", VA = "0x12C4824", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	[SerializeField]
	[Header("RattleWrench specific fields")]
	private Transform extensionTransform;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	[SerializeField]
	private List<ToolSnapperDetector> toolSnapperDetectors;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	[SerializeField]
	private List<Transform> placesToSnap;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private Transform currentPlaceToSnap;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private Transform currentScrewAttachPoint;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private Vector3 prevRot;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
	private Vector3 currentRot;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private float deltaRot;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
	private float minDeltaYRot;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x12C2B20", Offset = "0x12C2B20", VA = "0x12C2B20", Slot = "113")]
	protected override void OnTriggerEnterAction(Collider callingTrigger, Collider other)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x12C3774", Offset = "0x12C3774", VA = "0x12C3774")]
	private void OnTriggerEnterDrainPlugAction(Collider callingTrigger, Collider other)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x12C3B44", Offset = "0x12C3B44", VA = "0x12C3B44", Slot = "67")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x12C3D04", Offset = "0x12C3D04", VA = "0x12C3D04", Slot = "30")]
	public override void StartUsing(VRTK_InteractUse currentUsingObject)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x12C3DB8", Offset = "0x12C3DB8", VA = "0x12C3DB8", Slot = "31")]
	public override void StopUsing([Optional] VRTK_InteractUse previousUsingObject, bool resetUsingObjectState = true)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x12C3AD0", Offset = "0x12C3AD0", VA = "0x12C3AD0")]
	[IteratorStateMachine(typeof(<WrenchCoroutine>d__14))]
	private IEnumerator WrenchCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x12C3D34", Offset = "0x12C3D34", VA = "0x12C3D34")]
	[IteratorStateMachine(typeof(<AutomaticBoltScewCoroutine>d__15))]
	private IEnumerator AutomaticBoltScewCoroutine(float deltaRot)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x12C3F1C", Offset = "0x12C3F1C", VA = "0x12C3F1C")]
	private void BoltScrew(float deltaRot, bool automaticBoltRoutine = false)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x12C41E8", Offset = "0x12C41E8", VA = "0x12C41E8", Slot = "114")]
	public override void DetachFromBolt()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x12C4274", Offset = "0x12C4274", VA = "0x12C4274")]
	public RattleWrench()
	{
	}
}
[Token(Token = "0x200000F")]
public class DemoOptionForShowcase : VRTK_DestinationPoint
{
	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Transform tabletPositionAfterTeleport;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public int demoCanvasIdx;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private InteractiveObject interactiveObjectScript;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private bool onceDestinationPointForTutorials;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private VRTK_BasePointerRenderer lastPointerRenderer;

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x12C486C", Offset = "0x12C486C", VA = "0x12C486C", Slot = "31")]
	protected override void DoDestinationMarkerSet(object sender, DestinationMarkerEventArgs e)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x12C4B18", Offset = "0x12C4B18", VA = "0x12C4B18", Slot = "23")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x12C493C", Offset = "0x12C493C", VA = "0x12C493C")]
	private void ActivateCanvasAndMoveTabletAndDisactivateMe()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x12C4D54", Offset = "0x12C4D54", VA = "0x12C4D54", Slot = "33")]
	protected override void TogglePointerCursor(VRTK_BasePointerRenderer pointerRenderer, bool state)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x12C4D88", Offset = "0x12C4D88", VA = "0x12C4D88")]
	public DemoOptionForShowcase()
	{
	}
}
[Token(Token = "0x2000010")]
public class InverseRotation : MonoBehaviour
{
	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 originalPosition;

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x12C4D98", Offset = "0x12C4D98", VA = "0x12C4D98")]
	private void Update()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x12C4E40", Offset = "0x12C4E40", VA = "0x12C4E40")]
	private void Rotation()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x12C4E44", Offset = "0x12C4E44", VA = "0x12C4E44")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x12C4E74", Offset = "0x12C4E74", VA = "0x12C4E74")]
	public void resetTransform()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x12C4D9C", Offset = "0x12C4D9C", VA = "0x12C4D9C")]
	private void Example()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x12C4EA0", Offset = "0x12C4EA0", VA = "0x12C4EA0")]
	public InverseRotation()
	{
	}
}
[Token(Token = "0x2000011")]
public class CartTrigger : MonoBehaviour
{
	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private IInteractableCarrier interactableCarrier;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x12C4EA8", Offset = "0x12C4EA8", VA = "0x12C4EA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x12C4F00", Offset = "0x12C4F00", VA = "0x12C4F00")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x12C515C", Offset = "0x12C515C", VA = "0x12C515C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x12C5310", Offset = "0x12C5310", VA = "0x12C5310")]
	public CartTrigger()
	{
	}
}
[Token(Token = "0x2000012")]
public class ControlReactorInButtons : MonoBehaviour
{
	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem water;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float startPosition;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected VRTK_BaseControllable controllableEvents;

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x12C5318", Offset = "0x12C5318", VA = "0x12C5318", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x12C5384", Offset = "0x12C5384", VA = "0x12C5384")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x12C53B0", Offset = "0x12C53B0", VA = "0x12C53B0", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x12C53C0", Offset = "0x12C53C0", VA = "0x12C53C0", Slot = "6")]
	protected virtual void ManageListeners(bool state)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x12C54E4", Offset = "0x12C54E4", VA = "0x12C54E4", Slot = "7")]
	protected virtual void ValueChanged(object sender, ControllableEventArgs e)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x12C5694", Offset = "0x12C5694", VA = "0x12C5694")]
	public ControlReactorInButtons()
	{
	}
}
[Token(Token = "0x2000013")]
public class HeadLighter : VRTK_InteractableObject
{
	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[SerializeField]
	private GameObject light_1;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[SerializeField]
	private GameObject light_2;

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x12C569C", Offset = "0x12C569C", VA = "0x12C569C", Slot = "16")]
	public override void OnInteractableObjectSnappedToDropZone(InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x12C5700", Offset = "0x12C5700", VA = "0x12C5700", Slot = "17")]
	public override void OnInteractableObjectUnsnappedFromDropZone(InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x12C56BC", Offset = "0x12C56BC", VA = "0x12C56BC")]
	private void ToggleLights(bool state)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x12C5720", Offset = "0x12C5720", VA = "0x12C5720")]
	public HeadLighter()
	{
	}
}
[Token(Token = "0x2000014")]
public class Rotate360 : MonoBehaviour
{
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x12C5728", Offset = "0x12C5728", VA = "0x12C5728")]
	private void Update()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x12C5754", Offset = "0x12C5754", VA = "0x12C5754")]
	public Rotate360()
	{
	}
}
[Token(Token = "0x2000015")]
public class TestRotation : MonoBehaviour
{
	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform child;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 offset;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 originalPosition;

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x12C575C", Offset = "0x12C575C", VA = "0x12C575C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x12C578C", Offset = "0x12C578C", VA = "0x12C578C")]
	public void resetTransform()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x12C57B8", Offset = "0x12C57B8", VA = "0x12C57B8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x12C582C", Offset = "0x12C582C", VA = "0x12C582C")]
	public TestRotation()
	{
	}
}
[Token(Token = "0x2000016")]
public class TutorialTabletWindow : MonoBehaviour
{
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> element;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject tutorialWindow;

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x12C5834", Offset = "0x12C5834", VA = "0x12C5834")]
	public void ChangeScreen(int index)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x12C5A4C", Offset = "0x12C5A4C", VA = "0x12C5A4C")]
	public void ExitWindow()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x12C5A6C", Offset = "0x12C5A6C", VA = "0x12C5A6C")]
	public TutorialTabletWindow()
	{
	}
}
[Token(Token = "0x2000017")]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class MeshCombiner : MonoBehaviour
{
	[Token(Token = "0x4000035")]
	private const int Mesh16BitBufferVertexLimit = 65535;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool createMultiMaterialMesh;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool combineInactiveChildren;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[SerializeField]
	private bool deactivateCombinedChildren;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[SerializeField]
	private bool deactivateCombinedChildrenMeshRenderers;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool generateUVMap;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[SerializeField]
	private bool destroyCombinedChildren;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string folderPath;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("MeshFilters with Meshes which we don't want to combine into one Mesh.")]
	[SerializeField]
	private MeshFilter[] meshFiltersToSkip;

	[Token(Token = "0x17000007")]
	public bool CreateMultiMaterialMesh
	{
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x12C5AF4", Offset = "0x12C5AF4", VA = "0x12C5AF4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x12C5AFC", Offset = "0x12C5AFC", VA = "0x12C5AFC")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public bool CombineInactiveChildren
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x12C5B08", Offset = "0x12C5B08", VA = "0x12C5B08")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x12C5B10", Offset = "0x12C5B10", VA = "0x12C5B10")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public bool DeactivateCombinedChildren
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x12C5B1C", Offset = "0x12C5B1C", VA = "0x12C5B1C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x12C5B24", Offset = "0x12C5B24", VA = "0x12C5B24")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public bool DeactivateCombinedChildrenMeshRenderers
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x12C5B58", Offset = "0x12C5B58", VA = "0x12C5B58")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x12C5B60", Offset = "0x12C5B60", VA = "0x12C5B60")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public bool GenerateUVMap
	{
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x12C5B80", Offset = "0x12C5B80", VA = "0x12C5B80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x12C5B88", Offset = "0x12C5B88", VA = "0x12C5B88")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public bool DestroyCombinedChildren
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x12C5B94", Offset = "0x12C5B94", VA = "0x12C5B94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x12C5B9C", Offset = "0x12C5B9C", VA = "0x12C5B9C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public string FolderPath
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x12C5BC0", Offset = "0x12C5BC0", VA = "0x12C5BC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x12C5BC8", Offset = "0x12C5BC8", VA = "0x12C5BC8")]
		set
		{
		}
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x12C5B40", Offset = "0x12C5B40", VA = "0x12C5B40")]
	private void CheckDeactivateCombinedChildren()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x12C5BB0", Offset = "0x12C5BB0", VA = "0x12C5BB0")]
	private void CheckDestroyCombinedChildren()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x12C5BD0", Offset = "0x12C5BD0", VA = "0x12C5BD0")]
	public void CombineMeshes(bool showCreatedMeshInfo)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x12C75DC", Offset = "0x12C75DC", VA = "0x12C75DC")]
	private MeshFilter[] GetMeshFiltersToCombine()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x12C5EFC", Offset = "0x12C5EFC", VA = "0x12C5EFC")]
	private void CombineMeshesWithSingleMaterial(bool showCreatedMeshInfo)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x12C66EC", Offset = "0x12C66EC", VA = "0x12C66EC")]
	private void CombineMeshesWithMutliMaterial(bool showCreatedMeshInfo)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x12C78EC", Offset = "0x12C78EC", VA = "0x12C78EC")]
	private void DeactivateCombinedGameObjects(MeshFilter[] meshFilters)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x12C78E8", Offset = "0x12C78E8", VA = "0x12C78E8")]
	private void GenerateUV(Mesh combinedMesh)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x12C7A98", Offset = "0x12C7A98", VA = "0x12C7A98")]
	public MeshCombiner()
	{
	}
}
[Token(Token = "0x200001B")]
public class OldGUIExamplesCS : MonoBehaviour
{
	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D grumpy;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D beauty;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float w;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float h;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private LTRect buttonRect1;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LTRect buttonRect2;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private LTRect buttonRect3;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LTRect buttonRect4;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private LTRect grumpyRect;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LTRect beautyTileRect;

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x12C7D18", Offset = "0x12C7D18", VA = "0x12C7D18")]
	private void Start()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x12C8094", Offset = "0x12C8094", VA = "0x12C8094")]
	public void catMoved()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x12C80FC", Offset = "0x12C80FC", VA = "0x12C80FC")]
	private void NoOnGUI4U()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x12C8A98", Offset = "0x12C8A98", VA = "0x12C8A98")]
	public OldGUIExamplesCS()
	{
	}
}
[Token(Token = "0x200001C")]
public class TestingPunch : MonoBehaviour
{
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve exportCurve;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float overShootValue;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private LTDescr descr;

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x12C8AA0", Offset = "0x12C8AA0", VA = "0x12C8AA0")]
	private void Start()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x12C8EDC", Offset = "0x12C8EDC", VA = "0x12C8EDC")]
	private void Update()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x12C9DEC", Offset = "0x12C9DEC", VA = "0x12C9DEC")]
	private static void tweenStatically(GameObject gameObject)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x12C9F5C", Offset = "0x12C9F5C", VA = "0x12C9F5C")]
	private void enterMiniGameStart(object val)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x12CA098", Offset = "0x12CA098", VA = "0x12CA098")]
	private void updateColor(Color c)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x12CA148", Offset = "0x12CA148", VA = "0x12CA148")]
	private void delayedMethod(object myVal)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x12CA23C", Offset = "0x12CA23C", VA = "0x12CA23C")]
	private void destroyOnComp(object p)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x12C8B38", Offset = "0x12C8B38", VA = "0x12C8B38")]
	private string curveToString(AnimationCurve curve)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x12CA2CC", Offset = "0x12CA2CC", VA = "0x12CA2CC")]
	public TestingPunch()
	{
	}
}
[Token(Token = "0x2000021")]
public class TestingRigidbodyCS : MonoBehaviour
{
	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject ball1;

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x12CACB8", Offset = "0x12CACB8", VA = "0x12CACB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x12CADF0", Offset = "0x12CADF0", VA = "0x12CADF0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x12CADF4", Offset = "0x12CADF4", VA = "0x12CADF4")]
	public TestingRigidbodyCS()
	{
	}
}
[Token(Token = "0x2000022")]
public class GeneralAdvancedTechniques : MonoBehaviour
{
	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject avatarRecursive;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject avatar2dRecursive;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RectTransform wingPersonPanel;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RectTransform textField;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject avatarMove;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform[] movePts;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject[] avatarSpeed;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject[] avatarSpeed2;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3[] circleSm;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3[] circleLrg;

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x12CADFC", Offset = "0x12CADFC", VA = "0x12CADFC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x12CB1AC", Offset = "0x12CB1AC", VA = "0x12CB1AC")]
	public GeneralAdvancedTechniques()
	{
	}
}
[Token(Token = "0x2000023")]
public class GeneralBasicCS : MonoBehaviour
{
	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject prefabAvatar;

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x12CB960", Offset = "0x12CB960", VA = "0x12CB960")]
	private void Start()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x12CBC78", Offset = "0x12CBC78", VA = "0x12CBC78")]
	private void advancedExamples()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x12CBD60", Offset = "0x12CBD60", VA = "0x12CBD60")]
	public GeneralBasicCS()
	{
	}
}
[Token(Token = "0x2000025")]
public class GeneralBasics2dCS : MonoBehaviour
{
	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D dudeTexture;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject prefabParticles;

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x12CC460", Offset = "0x12CC460", VA = "0x12CC460")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x12CC7C4", Offset = "0x12CC7C4", VA = "0x12CC7C4")]
	private GameObject createSpriteDude(string name, Vector3 pos, bool hasParticles = true)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x12CCAA0", Offset = "0x12CCAA0", VA = "0x12CCAA0")]
	private void advancedExamples()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x12CCB88", Offset = "0x12CCB88", VA = "0x12CCB88")]
	public GeneralBasics2dCS()
	{
	}
}
[Token(Token = "0x2000027")]
public class GeneralCameraShake : MonoBehaviour
{
	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject avatarBig;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float jumpIter;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioClip boomAudioClip;

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x12CD234", Offset = "0x12CD234", VA = "0x12CD234")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x12CD614", Offset = "0x12CD614", VA = "0x12CD614")]
	private void bigGuyJump()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x12CD78C", Offset = "0x12CD78C", VA = "0x12CD78C")]
	public GeneralCameraShake()
	{
	}
}
[Token(Token = "0x200002A")]
public class GeneralEasingTypes : MonoBehaviour
{
	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float lineDrawScale;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string[] easeTypes;

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x12CDDC4", Offset = "0x12CDDC4", VA = "0x12CDDC4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x12CDDC8", Offset = "0x12CDDC8", VA = "0x12CDDC8")]
	private void demoEaseTypes()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x12CE14C", Offset = "0x12CE14C", VA = "0x12CE14C")]
	private void resetLines()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x12CE204", Offset = "0x12CE204", VA = "0x12CE204")]
	public GeneralEasingTypes()
	{
	}
}
[Token(Token = "0x200002C")]
public class GeneralEventsListenersCS : MonoBehaviour
{
	[Token(Token = "0x200002D")]
	public enum MyEvents
	{
		[Token(Token = "0x400007D")]
		CHANGE_COLOR,
		[Token(Token = "0x400007E")]
		JUMP,
		[Token(Token = "0x400007F")]
		LENGTH
	}

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 towardsRotation;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float turnForLength;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float turnForIter;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Color fromColor;

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x12CEEF4", Offset = "0x12CEEF4", VA = "0x12CEEF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x12CEFB4", Offset = "0x12CEFB4", VA = "0x12CEFB4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x12CF0D8", Offset = "0x12CF0D8", VA = "0x12CF0D8")]
	private void jumpUp(LTEvent e)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x12CF19C", Offset = "0x12CF19C", VA = "0x12CF19C")]
	private void changeColor(LTEvent e)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x12CF410", Offset = "0x12CF410", VA = "0x12CF410")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x12CF468", Offset = "0x12CF468", VA = "0x12CF468")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x12CF4B8", Offset = "0x12CF4B8", VA = "0x12CF4B8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x12CF690", Offset = "0x12CF690", VA = "0x12CF690")]
	private void OnMouseDown()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x12CF734", Offset = "0x12CF734", VA = "0x12CF734")]
	public GeneralEventsListenersCS()
	{
	}
}
[Token(Token = "0x200002E")]
public class GeneralSimpleUiCS : MonoBehaviour
{
	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RectTransform button;

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x12CF7F4", Offset = "0x12CF7F4", VA = "0x12CF7F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x12CFDE4", Offset = "0x12CFDE4", VA = "0x12CFDE4")]
	public GeneralSimpleUiCS()
	{
	}
}
[Token(Token = "0x2000030")]
public class GeneralUISpaceCS : MonoBehaviour
{
	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RectTransform mainWindow;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RectTransform mainParagraphText;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RectTransform mainTitleText;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RectTransform mainButton1;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform mainButton2;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform pauseRing1;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RectTransform pauseRing2;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RectTransform pauseWindow;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RectTransform chatWindow;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RectTransform chatRect;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Sprite[] chatSprites;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RectTransform chatBar1;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RectTransform chatBar2;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Text chatText;

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x12D00C0", Offset = "0x12D00C0", VA = "0x12D00C0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x12D0914", Offset = "0x12D0914", VA = "0x12D0914")]
	public GeneralUISpaceCS()
	{
	}
}
[Token(Token = "0x2000032")]
public class LogoCinematic : MonoBehaviour
{
	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject lean;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject tween;

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x12D0A48", Offset = "0x12D0A48", VA = "0x12D0A48")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x12D0A4C", Offset = "0x12D0A4C", VA = "0x12D0A4C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x12D0E64", Offset = "0x12D0E64", VA = "0x12D0E64")]
	private void playBoom()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x12D150C", Offset = "0x12D150C", VA = "0x12D150C")]
	public LogoCinematic()
	{
	}
}
[Token(Token = "0x2000033")]
public class ExampleSpline : MonoBehaviour
{
	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] trans;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private LTSpline spline;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject ltLogo;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject ltLogo2;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float iter;

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x12D1514", Offset = "0x12D1514", VA = "0x12D1514")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x12D188C", Offset = "0x12D188C", VA = "0x12D188C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x12D191C", Offset = "0x12D191C", VA = "0x12D191C")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x12D1934", Offset = "0x12D1934", VA = "0x12D1934")]
	public ExampleSpline()
	{
	}
}
[Token(Token = "0x2000034")]
public class PathSpline2d : MonoBehaviour
{
	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] trans;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D spriteTexture;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private LTSpline cr;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject sprite1;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject sprite2;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float iter;

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x12D193C", Offset = "0x12D193C", VA = "0x12D193C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x12D1DB0", Offset = "0x12D1DB0", VA = "0x12D1DB0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x12D1E30", Offset = "0x12D1E30", VA = "0x12D1E30")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x12D1E48", Offset = "0x12D1E48", VA = "0x12D1E48")]
	public PathSpline2d()
	{
	}
}
[Token(Token = "0x2000035")]
public class PathSplineEndlessCS : MonoBehaviour
{
	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject trackTrailRenderers;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject car;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject carInternal;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] cubes;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int cubesIter;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject[] trees;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int treesIter;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float randomIterWidth;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private LTSpline track;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<Vector3> trackPts;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int zIter;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float carIter;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float carAdd;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int trackMaxItems;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int trackIter;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float pushTrackAhead;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float randomIter;

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x12D1E50", Offset = "0x12D1E50", VA = "0x12D1E50")]
	private void Start()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x12D22F0", Offset = "0x12D22F0", VA = "0x12D22F0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x12D28F8", Offset = "0x12D28F8", VA = "0x12D28F8")]
	private GameObject objectQueue(GameObject[] arr, ref int lastIter)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x12D1F58", Offset = "0x12D1F58", VA = "0x12D1F58")]
	private void addRandomTrackPoint()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x12D2200", Offset = "0x12D2200", VA = "0x12D2200")]
	private void refreshSpline()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x12D24E8", Offset = "0x12D24E8", VA = "0x12D24E8")]
	private void playSwish()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x12D2A30", Offset = "0x12D2A30", VA = "0x12D2A30")]
	public PathSplineEndlessCS()
	{
	}
}
[Token(Token = "0x2000036")]
public class PathSplinePerformanceCS : MonoBehaviour
{
	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject trackTrailRenderers;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject car;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject carInternal;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float circleLength;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float randomRange;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int trackNodes;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float carSpeed;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float tracerSpeed;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LTSpline track;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int trackIter;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float carAdd;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float trackPosition;

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x12D2AD8", Offset = "0x12D2AD8", VA = "0x12D2AD8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x12D2EB4", Offset = "0x12D2EB4", VA = "0x12D2EB4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x12D3418", Offset = "0x12D3418", VA = "0x12D3418")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x12D3008", Offset = "0x12D3008", VA = "0x12D3008")]
	private void playSwish()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x12D343C", Offset = "0x12D343C", VA = "0x12D343C")]
	public PathSplinePerformanceCS()
	{
	}
}
[Token(Token = "0x2000037")]
public class PathSplines : MonoBehaviour
{
	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] trans;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private LTSpline cr;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject avatar1;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float iter;

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x12D346C", Offset = "0x12D346C", VA = "0x12D346C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x12D3614", Offset = "0x12D3614", VA = "0x12D3614")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x12D374C", Offset = "0x12D374C", VA = "0x12D374C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x12D3794", Offset = "0x12D3794", VA = "0x12D3794")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x12D37E4", Offset = "0x12D37E4", VA = "0x12D37E4")]
	public PathSplines()
	{
	}
}
[Token(Token = "0x2000038")]
public class PathSplineTrackCS : MonoBehaviour
{
	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject car;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject carInternal;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject trackTrailRenderers;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform[] trackOnePoints;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LTSpline track;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int trackIter;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float trackPosition;

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x12D3990", Offset = "0x12D3990", VA = "0x12D3990")]
	private void Start()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x12D3C10", Offset = "0x12D3C10", VA = "0x12D3C10")]
	private void Update()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x12D4178", Offset = "0x12D4178", VA = "0x12D4178")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x12D3D68", Offset = "0x12D3D68", VA = "0x12D3D68")]
	private void playSwish()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x12D41E4", Offset = "0x12D41E4", VA = "0x12D41E4")]
	public PathSplineTrackCS()
	{
	}
}
[Token(Token = "0x2000039")]
public class TestingAllCS : MonoBehaviour
{
	[Token(Token = "0x200003A")]
	public delegate void NextFunc();

	[Token(Token = "0x200003B")]
	public enum TimingType
	{
		[Token(Token = "0x40000D6")]
		SteadyNormalTime,
		[Token(Token = "0x40000D7")]
		IgnoreTimeScale,
		[Token(Token = "0x40000D8")]
		HalfTimeScale,
		[Token(Token = "0x40000D9")]
		VariableTimeScale,
		[Token(Token = "0x40000DA")]
		Length
	}

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve customAnimationCurve;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform pt1;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform pt2;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform pt3;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform pt4;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform pt5;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int exampleIter;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string[] exampleFunctions;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool useEstimatedTime;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject ltLogo;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private TimingType timingType;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int descrTimeScaleChangeId;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 origin;

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x12D51F4", Offset = "0x12D51F4", VA = "0x12D51F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x12D51F8", Offset = "0x12D51F8", VA = "0x12D51F8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x12D5304", Offset = "0x12D5304", VA = "0x12D5304")]
	private void pauseNow()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x12D5378", Offset = "0x12D5378", VA = "0x12D5378")]
	private void NoOnGUI4U()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x12D54C8", Offset = "0x12D54C8", VA = "0x12D54C8")]
	private void endlessCallback()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x12D5530", Offset = "0x12D5530", VA = "0x12D5530")]
	private void cycleThroughExamples()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x12D5884", Offset = "0x12D5884", VA = "0x12D5884")]
	public void updateValue3Example()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x12D5A7C", Offset = "0x12D5A7C", VA = "0x12D5A7C")]
	public void updateValue3ExampleUpdate(Vector3 val)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x12D5A80", Offset = "0x12D5A80", VA = "0x12D5A80")]
	public void updateValue3ExampleCallback(Vector3 val)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x12D5AD0", Offset = "0x12D5AD0", VA = "0x12D5AD0")]
	public void loopTestClamp()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x12D5C3C", Offset = "0x12D5C3C", VA = "0x12D5C3C")]
	public void loopTestPingPong()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x12D5D9C", Offset = "0x12D5D9C", VA = "0x12D5D9C")]
	public void colorExample()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x12D5E78", Offset = "0x12D5E78", VA = "0x12D5E78")]
	public void moveOnACurveExample()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x12D60C8", Offset = "0x12D60C8", VA = "0x12D60C8")]
	public void customTweenExample()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x12D6284", Offset = "0x12D6284", VA = "0x12D6284")]
	public void moveExample()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x12D6380", Offset = "0x12D6380", VA = "0x12D6380")]
	public void rotateExample()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x12D65C8", Offset = "0x12D65C8", VA = "0x12D65C8")]
	public void rotateOnUpdate(float val)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x12D65CC", Offset = "0x12D65CC", VA = "0x12D65CC")]
	public void rotateFinished(object hash)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x12D66E0", Offset = "0x12D66E0", VA = "0x12D66E0")]
	public void scaleExample()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x12D67F4", Offset = "0x12D67F4", VA = "0x12D67F4")]
	public void updateValueExample()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x12D68D0", Offset = "0x12D68D0", VA = "0x12D68D0")]
	public void updateValueExampleCallback(float val, object hash)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x12D6940", Offset = "0x12D6940", VA = "0x12D6940")]
	public void delayedCallExample()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x12D6A3C", Offset = "0x12D6A3C", VA = "0x12D6A3C")]
	public void delayedCallExampleCallback()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x12D6B50", Offset = "0x12D6B50", VA = "0x12D6B50")]
	public void alphaExample()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x12D6C6C", Offset = "0x12D6C6C", VA = "0x12D6C6C")]
	public void moveLocalExample()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x12D6DC0", Offset = "0x12D6DC0", VA = "0x12D6DC0")]
	public void rotateAroundExample()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x12D6EFC", Offset = "0x12D6EFC", VA = "0x12D6EFC")]
	public void loopPause()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x12D6F78", Offset = "0x12D6F78", VA = "0x12D6F78")]
	public void loopResume()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x12D6FF4", Offset = "0x12D6FF4", VA = "0x12D6FF4")]
	public void punchTest()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x12D707C", Offset = "0x12D707C", VA = "0x12D707C")]
	public TestingAllCS()
	{
	}
}
[Token(Token = "0x200003D")]
public class TestingColorTweening : MonoBehaviour
{
	[Token(Token = "0x6000116")]
	[Address(RVA = "0x12D7794", Offset = "0x12D7794", VA = "0x12D7794")]
	private void Start()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x12D7960", Offset = "0x12D7960", VA = "0x12D7960")]
	private void OnTweenUpdate(Color update, object obj)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x12D7AA8", Offset = "0x12D7AA8", VA = "0x12D7AA8")]
	public TestingColorTweening()
	{
	}
}
[Token(Token = "0x200003E")]
public class TestingIssue : MonoBehaviour
{
	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LTDescr lt;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private LTDescr ff;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int id;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int fid;

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x12D7AB0", Offset = "0x12D7AB0", VA = "0x12D7AB0")]
	private void Start()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x12D7C2C", Offset = "0x12D7C2C", VA = "0x12D7C2C")]
	private void Update()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x12D7CD4", Offset = "0x12D7CD4", VA = "0x12D7CD4")]
	public TestingIssue()
	{
	}
}
[Token(Token = "0x200003F")]
public class TestingIssue2 : MonoBehaviour
{
	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject go;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject go2;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private LTDescr descr;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool set;

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x12D7CDC", Offset = "0x12D7CDC", VA = "0x12D7CDC")]
	private void Start()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x12D7E64", Offset = "0x12D7E64", VA = "0x12D7E64")]
	private void Update()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x12D7F14", Offset = "0x12D7F14", VA = "0x12D7F14")]
	public TestingIssue2()
	{
	}
}
[Token(Token = "0x2000040")]
public class TestingRotate : MonoBehaviour
{
	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject sun;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject earth;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject sun2;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject earth2;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject sun3;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject earth3;

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x12D7F1C", Offset = "0x12D7F1C", VA = "0x12D7F1C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x12D817C", Offset = "0x12D817C", VA = "0x12D817C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x12D8250", Offset = "0x12D8250", VA = "0x12D8250")]
	public TestingRotate()
	{
	}
}
[Token(Token = "0x2000041")]
public class TestingSceneSwitching : MonoBehaviour
{
	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cube;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int sceneIter;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int tweenCompleteCnt;

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x12D8258", Offset = "0x12D8258", VA = "0x12D8258")]
	private void Start()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x12D84DC", Offset = "0x12D84DC", VA = "0x12D84DC")]
	public TestingSceneSwitching()
	{
	}
}
[Token(Token = "0x2000043")]
public class transitionTest : MonoBehaviour
{
	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CarLiftPanel liftPanel;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PartScript part;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button button;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private PointerOriginRotator originRotator;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TooltipImageDisplay toolTipItemDisplay;

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x12D88E0", Offset = "0x12D88E0", VA = "0x12D88E0")]
	private void Update()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x12D88E4", Offset = "0x12D88E4", VA = "0x12D88E4")]
	public transitionTest()
	{
	}
}
[Token(Token = "0x2000044")]
public class LoadLevelSelectable : MonoBehaviour
{
	[Token(Token = "0x600012F")]
	[Address(RVA = "0x12D88EC", Offset = "0x12D88EC", VA = "0x12D88EC")]
	public void LoadShowroom(string name)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x12D89BC", Offset = "0x12D89BC", VA = "0x12D89BC")]
	public void LoadMenu(string name)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x12D8A8C", Offset = "0x12D8A8C", VA = "0x12D8A8C")]
	public void LoadGarage()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x12D8B5C", Offset = "0x12D8B5C", VA = "0x12D8B5C")]
	public void LoadGaragePart(string nextSceneName)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x12D9188", Offset = "0x12D9188", VA = "0x12D9188")]
	public LoadLevelSelectable()
	{
	}
}
[Token(Token = "0x2000046")]
public class LODDummy : MonoBehaviour
{
	[Token(Token = "0x6000136")]
	[Address(RVA = "0x12D9200", Offset = "0x12D9200", VA = "0x12D9200")]
	private void Start()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x12D9204", Offset = "0x12D9204", VA = "0x12D9204")]
	private void Update()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x12D9208", Offset = "0x12D9208", VA = "0x12D9208")]
	public LODDummy()
	{
	}
}
[Token(Token = "0x2000047")]
public class RotateSeeker : MonoBehaviour
{
	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float Speed;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform trans;

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x12D9210", Offset = "0x12D9210", VA = "0x12D9210")]
	private void Start()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x12D9268", Offset = "0x12D9268", VA = "0x12D9268")]
	private void Update()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x12D92B4", Offset = "0x12D92B4", VA = "0x12D92B4")]
	public RotateSeeker()
	{
	}
}
[Token(Token = "0x2000048")]
public class Fan : MonoBehaviour
{
	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float _speed;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform trans;

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x12D92C4", Offset = "0x12D92C4", VA = "0x12D92C4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x12D931C", Offset = "0x12D931C", VA = "0x12D931C")]
	private void Update()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x12D9360", Offset = "0x12D9360", VA = "0x12D9360")]
	public Fan()
	{
	}
}
[Token(Token = "0x2000049")]
public class ApplyProceduralTextureProperties : MonoBehaviour
{
	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(5f)]
	public Material m_Material;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Space(5f)]
	public ProceduralTexture2D proceduralTexAssetAlbedo;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ProceduralTexture2D proceduralTexAssetNormal;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ProceduralTexture2D proceduralTexAssetMask;

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x12D9370", Offset = "0x12D9370", VA = "0x12D9370")]
	public void SyncMatWithProceduralTextureAsset()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x12D9A0C", Offset = "0x12D9A0C", VA = "0x12D9A0C")]
	public ApplyProceduralTextureProperties()
	{
	}
}
[Serializable]
[Token(Token = "0x200004A")]
[CreateAssetMenu(fileName = "New Procedural Texture 2D", menuName = "", order = 1)]
public class ProceduralTexture2D : ScriptableObject
{
	[Token(Token = "0x200004B")]
	public enum TextureType
	{
		[Token(Token = "0x4000117")]
		Color,
		[Token(Token = "0x4000118")]
		Normal,
		[Token(Token = "0x4000119")]
		Other
	}

	[Token(Token = "0x200004C")]
	public enum CompressionLevel
	{
		[Token(Token = "0x400011B")]
		None = -1,
		[Token(Token = "0x400011C")]
		LowQuality = 0,
		[Token(Token = "0x400011D")]
		NormalQuality = 50,
		[Token(Token = "0x400011E")]
		HighQuality = 100
	}

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D input;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextureType type;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool includeAlpha;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool generateMipMaps;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FilterMode filterMode;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int anisoLevel;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CompressionLevel compressionQuality;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture2D Tinput;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture2D invT;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 colorSpaceOrigin;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector3 colorSpaceVector1;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3 colorSpaceVector2;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector3 colorSpaceVector3;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector4 compressionScalers;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public long memoryUsageBytes;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Texture2D currentInput;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TextureType currentType;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool currentIncludeAlpha;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
	public bool currentGenerateMipMaps;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public FilterMode currentFilterMode;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public int currentAnisoLevel;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public CompressionLevel currentCompressionQuality;

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x12D9A14", Offset = "0x12D9A14", VA = "0x12D9A14")]
	public ProceduralTexture2D()
	{
	}
}
[Token(Token = "0x200004D")]
public class MLPForceSaveProbes : MonoBehaviour
{
	[Token(Token = "0x6000142")]
	[Address(RVA = "0x12D9B00", Offset = "0x12D9B00", VA = "0x12D9B00")]
	public MLPForceSaveProbes()
	{
	}
}
[Token(Token = "0x200004E")]
[CreateAssetMenu(fileName = "New MLP Settings Asset", menuName = "Magic Tools/Magic Light Probes/Create New Settings Asset", order = 1)]
public class MLPSettings : ScriptableObject
{
	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public global::MagicLightProbes.MagicLightProbes.Workflow workflow;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float probesSpacing;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float cornersDetectionThreshold;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float cornerProbesSpacing;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float distanceFromGeometry;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int divideVolumeOnProbesCount;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool useVolumeBottom;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool selectedObjectsAsGlobal;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float maxHeightAboveGeometry;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float maxHeightAboveTerrain;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public LayerMask collisionDetectionLayers;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float collisionDetectionRadius;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool considerDistanceToLights;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public global::MagicLightProbes.MagicLightProbes.FillingMode fillingMode;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float lightIntensityThreshold;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool cullByColor;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float colorThreshold;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool fillEquivalentVolume;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float equivalentVolumeFillingRate;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool fillUnlitVolume;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float unlitVolumeFillingRate;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool optimizeForMixedLighting;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool tryPreventLightLeakage;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public global::MagicLightProbes.MagicLightProbes.BoundsDisplayMode boundsDisplayMode;

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x12D9B08", Offset = "0x12D9B08", VA = "0x12D9B08")]
	public MLPSettings()
	{
	}
}
[Token(Token = "0x200004F")]
public class MantisLODEditorProfessional : MonoBehaviour
{
	[Token(Token = "0x6000144")]
	[Address(RVA = "0x12D9B10", Offset = "0x12D9B10", VA = "0x12D9B10")]
	public MantisLODEditorProfessional()
	{
	}
}
[Token(Token = "0x2000050")]
public class MoveMe : MonoBehaviour
{
	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool forwarding;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float delta;

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x12D9B18", Offset = "0x12D9B18", VA = "0x12D9B18")]
	private void Start()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x12D9B1C", Offset = "0x12D9B1C", VA = "0x12D9B1C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x12D9BC4", Offset = "0x12D9BC4", VA = "0x12D9BC4")]
	public MoveMe()
	{
	}
}
[Token(Token = "0x2000051")]
public class RotateMe : MonoBehaviour
{
	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 center_to_ratate;

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x12D9BD4", Offset = "0x12D9BD4", VA = "0x12D9BD4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x12D9D7C", Offset = "0x12D9D7C", VA = "0x12D9D7C")]
	private void Update()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x12D9EC8", Offset = "0x12D9EC8", VA = "0x12D9EC8")]
	public RotateMe()
	{
	}
}
[Token(Token = "0x2000052")]
public class BakeTexturesAtRuntime : MonoBehaviour
{
	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float elapsedTime;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MB3_TextureCombiner.CreateAtlasesCoroutineResult result;

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x12D9ED0", Offset = "0x12D9ED0", VA = "0x12D9ED0")]
	private void NoOnGUI4U()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x12DA3E4", Offset = "0x12DA3E4", VA = "0x12DA3E4")]
	private void OnBuiltAtlasesSuccess()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x12DA5D8", Offset = "0x12DA5D8", VA = "0x12DA5D8")]
	public BakeTexturesAtRuntime()
	{
	}
}
[Token(Token = "0x2000053")]
public class MB_BatchPrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x600014E")]
	[Address(RVA = "0x12DA64C", Offset = "0x12DA64C", VA = "0x12DA64C")]
	private void NoOnGUI4U()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x12DA6E4", Offset = "0x12DA6E4", VA = "0x12DA6E4")]
	public MB_BatchPrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x2000054")]
public class MB_SwapShirts : MonoBehaviour
{
	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Renderer[] clothingAndBodyPartsBareTorso;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Renderer[] clothingAndBodyPartsBareTorsoDamagedArm;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Renderer[] clothingAndBodyPartsHoodie;

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x12DA6EC", Offset = "0x12DA6EC", VA = "0x12DA6EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x12DA840", Offset = "0x12DA840", VA = "0x12DA840")]
	private void NoOnGUI4U()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x12DA9D8", Offset = "0x12DA9D8", VA = "0x12DA9D8")]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x12DB010", Offset = "0x12DB010", VA = "0x12DB010")]
	public MB_SwapShirts()
	{
	}
}
[Token(Token = "0x2000055")]
public class MB_PrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x6000154")]
	[Address(RVA = "0x12DB018", Offset = "0x12DB018", VA = "0x12DB018")]
	private void NoOnGUI4U()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x12DB0B0", Offset = "0x12DB0B0", VA = "0x12DB0B0")]
	public MB_PrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x2000056")]
public class MB_DynamicAddDeleteExample : MonoBehaviour
{
	[Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class <largeNumber>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MB_DynamicAddDeleteExample <>4__this;

		[Token(Token = "0x1700000E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x12DB8D0", Offset = "0x12DB8D0", VA = "0x12DB8D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x12DB918", Offset = "0x12DB918", VA = "0x12DB918", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x12DB614", Offset = "0x12DB614", VA = "0x12DB614")]
		[DebuggerHidden]
		public <largeNumber>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x12DB75C", Offset = "0x12DB75C", VA = "0x12DB75C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x12DB760", Offset = "0x12DB760", VA = "0x12DB760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x12DB8D8", Offset = "0x12DB8D8", VA = "0x12DB8D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject prefab;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<GameObject> objsInCombined;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MB3_MultiMeshBaker mbd;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject[] objs;

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x12DB0B8", Offset = "0x12DB0B8", VA = "0x12DB0B8")]
	private float GaussianValue()
	{
		return default(float);
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x12DB13C", Offset = "0x12DB13C", VA = "0x12DB13C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x12DB5A0", Offset = "0x12DB5A0", VA = "0x12DB5A0")]
	[IteratorStateMachine(typeof(<largeNumber>d__6))]
	private IEnumerator largeNumber()
	{
		return null;
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x12DB63C", Offset = "0x12DB63C", VA = "0x12DB63C")]
	private void NoOnGUI4U()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x12DB6D4", Offset = "0x12DB6D4", VA = "0x12DB6D4")]
	public MB_DynamicAddDeleteExample()
	{
	}
}
[Token(Token = "0x2000058")]
public class MB_Example : MonoBehaviour
{
	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker meshbaker;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] objsToCombine;

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x12DB920", Offset = "0x12DB920", VA = "0x12DB920")]
	private void Start()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x12DB970", Offset = "0x12DB970", VA = "0x12DB970")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x12DB9F0", Offset = "0x12DB9F0", VA = "0x12DB9F0")]
	private void NoOnGUI4U()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x12DBA88", Offset = "0x12DBA88", VA = "0x12DBA88")]
	public MB_Example()
	{
	}
}
[Token(Token = "0x2000059")]
public class MB_ExampleMover : MonoBehaviour
{
	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int axis;

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x12DBA90", Offset = "0x12DBA90", VA = "0x12DBA90")]
	private void Update()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x12DBBC0", Offset = "0x12DBBC0", VA = "0x12DBBC0")]
	public MB_ExampleMover()
	{
	}
}
[Token(Token = "0x200005A")]
public class MB_ExampleSkinnedMeshDescription : MonoBehaviour
{
	[Token(Token = "0x6000167")]
	[Address(RVA = "0x12DBBC8", Offset = "0x12DBBC8", VA = "0x12DBBC8")]
	private void NoOnGUI4U()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x12DBC60", Offset = "0x12DBC60", VA = "0x12DBC60")]
	public MB_ExampleSkinnedMeshDescription()
	{
	}
}
[Token(Token = "0x200005B")]
public class MB_SkinnedMeshSceneController : MonoBehaviour
{
	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject swordPrefab;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject hatPrefab;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject glassesPrefab;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject workerPrefab;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject targetCharacter;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public MB3_MeshBaker skinnedMeshBaker;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject swordInstance;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject glassesInstance;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject hatInstance;

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x12DBC68", Offset = "0x12DBC68", VA = "0x12DBC68")]
	private void Start()
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x12DBE5C", Offset = "0x12DBE5C", VA = "0x12DBE5C")]
	private void NoOnGUI4U()
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x12DCBC8", Offset = "0x12DCBC8", VA = "0x12DCBC8")]
	public Transform SearchHierarchyForBone(Transform current, string name)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x12DCCD4", Offset = "0x12DCCD4", VA = "0x12DCCD4")]
	public MB_SkinnedMeshSceneController()
	{
	}
}
[Token(Token = "0x200005C")]
public class MB_SwitchBakedObjectsTexture : MonoBehaviour
{
	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer targetRenderer;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material[] materials;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x12DCCDC", Offset = "0x12DCCDC", VA = "0x12DCCDC")]
	public void NoOnGUI4U()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x12DCD74", Offset = "0x12DCD74", VA = "0x12DCD74")]
	public void Start()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x12DCE14", Offset = "0x12DCE14", VA = "0x12DCE14")]
	public void Update()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x12DD0B0", Offset = "0x12DD0B0", VA = "0x12DD0B0")]
	public MB_SwitchBakedObjectsTexture()
	{
	}
}
[Token(Token = "0x200005D")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x200005E")]
	public delegate void OnClick();

	[Token(Token = "0x200005F")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x2000060")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x2000061")]
	public delegate bool ActiveUpdate();

	[Token(Token = "0x4000157")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x4000158")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x4000159")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform[] additionalButtonPrefab;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool[] reEnable;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float elementSpacing;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float marginH;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float marginV;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector2[] insertPositions;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 menuOffset;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private OVRCameraRig rig;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private LaserPointer lp;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private LineRenderer lr;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool isHorizontal;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
	public bool usePanelCentricRelayout;

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x12DD0B8", Offset = "0x12DD0B8", VA = "0x12DD0B8")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x12DD624", Offset = "0x12DD624", VA = "0x12DD624")]
	public void Show()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x12DD9A0", Offset = "0x12DD9A0", VA = "0x12DD9A0")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x12DDB1C", Offset = "0x12DDB1C", VA = "0x12DDB1C")]
	private void StackedRelayout()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x12DDD34", Offset = "0x12DDD34", VA = "0x12DDD34")]
	private void PanelCentricRelayout()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x12DD990", Offset = "0x12DD990", VA = "0x12DD990")]
	private void Relayout()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x12DE028", Offset = "0x12DE028", VA = "0x12DE028")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x12DE3A4", Offset = "0x12DE3A4", VA = "0x12DE3A4")]
	public RectTransform AddButton(string label, [Optional] OnClick handler, int buttonIndex = -1, int targetCanvas = 0, bool highResolutionText = false)
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x12DE754", Offset = "0x12DE754", VA = "0x12DE754")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x12DE84C", Offset = "0x12DE84C", VA = "0x12DE84C")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x12DEA1C", Offset = "0x12DEA1C", VA = "0x12DEA1C")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x12DEAB4", Offset = "0x12DEAB4", VA = "0x12DEAB4")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x12DEC90", Offset = "0x12DEC90", VA = "0x12DEC90")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x12DEE8C", Offset = "0x12DEE8C", VA = "0x12DEE8C")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x12DF184", Offset = "0x12DF184", VA = "0x12DF184")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x12DF274", Offset = "0x12DF274", VA = "0x12DF274")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x12DF308", Offset = "0x12DF308", VA = "0x12DF308")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x2000067")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x12DF988", Offset = "0x12DF988", VA = "0x12DF988")]
	private void Start()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x12DFA2C", Offset = "0x12DFA2C", VA = "0x12DFA2C")]
	private void Update()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x12DFAC8", Offset = "0x12DFAC8", VA = "0x12DFAC8")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x12DFB00", Offset = "0x12DFB00", VA = "0x12DFB00")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x2000068")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x2000069")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x4000189")]
		On,
		[Token(Token = "0x400018A")]
		Off,
		[Token(Token = "0x400018B")]
		OnWhenHitTarget
	}

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x17000010")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x12DFB08", Offset = "0x12DFB08", VA = "0x12DFB08")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x12DD5E4", Offset = "0x12DD5E4", VA = "0x12DD5E4")]
		set
		{
		}
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x12DFB10", Offset = "0x12DFB10", VA = "0x12DFB10")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x12DFB68", Offset = "0x12DFB68", VA = "0x12DFB68")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x12DFCA0", Offset = "0x12DFCA0", VA = "0x12DFCA0", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x12DFCBC", Offset = "0x12DFCBC", VA = "0x12DFCBC", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x12DFD0C", Offset = "0x12DFD0C", VA = "0x12DFD0C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x12DFEAC", Offset = "0x12DFEAC", VA = "0x12DFEAC")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x12DFFBC", Offset = "0x12DFFBC", VA = "0x12DFFBC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x12E0040", Offset = "0x12E0040", VA = "0x12E0040")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x12E0100", Offset = "0x12E0100", VA = "0x12E0100")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x12E01A8", Offset = "0x12E01A8", VA = "0x12E01A8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x12E0294", Offset = "0x12E0294", VA = "0x12E0294")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x200006A")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x400018C")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x400018D")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x400018E")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("This should be a reference to the OVRCameraRig that is usually a child of the PlayerController.")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("Collision layers to be used for the purposes of fading out the screen when the HMD is inside world geometry and adjusting the capsule height.")]
	public LayerMask CollideLayers;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Offset is added to camera's real world height, effectively treating it as though the player was taller/standing higher.")]
	public float HeightOffset;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Minimum height that the character capsule can shrink to.  To disable, set to capsule's height.")]
	public float MinimumHeight;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("Maximum height that the character capsule can grow to.  To disable, set to capsule's height.")]
	public float MaximumHeight;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x12E02A4", Offset = "0x12E02A4", VA = "0x12E02A4")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x12E02AC", Offset = "0x12E02AC", VA = "0x12E02AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x12E033C", Offset = "0x12E033C", VA = "0x12E033C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x12E0460", Offset = "0x12E0460", VA = "0x12E0460")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x12E0584", Offset = "0x12E0584", VA = "0x12E0584")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x12E08A4", Offset = "0x12E08A4", VA = "0x12E08A4")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x12E0B04", Offset = "0x12E0B04", VA = "0x12E0B04")]
	private bool CheckCameraNearClipping(out float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x200006B")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x12E125C", Offset = "0x12E125C", VA = "0x12E125C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x12E1308", Offset = "0x12E1308", VA = "0x12E1308")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x200006C")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x200006D")]
	public enum States
	{
		[Token(Token = "0x40001BC")]
		Ready,
		[Token(Token = "0x40001BD")]
		Aim,
		[Token(Token = "0x40001BE")]
		CancelAim,
		[Token(Token = "0x40001BF")]
		PreTeleport,
		[Token(Token = "0x40001C0")]
		CancelTeleport,
		[Token(Token = "0x40001C1")]
		Teleporting,
		[Token(Token = "0x40001C2")]
		PostTeleport
	}

	[Token(Token = "0x200006E")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x40001C4")]
		None,
		[Token(Token = "0x40001C5")]
		Aim,
		[Token(Token = "0x40001C6")]
		PreTeleport,
		[Token(Token = "0x40001C7")]
		Teleport
	}

	[Token(Token = "0x200006F")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x40001C9")]
		Point,
		[Token(Token = "0x40001CA")]
		Sphere,
		[Token(Token = "0x40001CB")]
		Capsule
	}

	[Token(Token = "0x2000070")]
	public class AimData
	{
		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x17000014")]
		public List<Vector3> Points
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x12E3048", Offset = "0x12E3048", VA = "0x12E3048")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x12E3050", Offset = "0x12E3050", VA = "0x12E3050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x12E2FC0", Offset = "0x12E2FC0", VA = "0x12E2FC0")]
		public AimData()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x12E3058", Offset = "0x12E3058", VA = "0x12E3058")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000015")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x12E31C0", Offset = "0x12E31C0", VA = "0x12E31C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x12E3208", Offset = "0x12E3208", VA = "0x12E3208", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x12E1D14", Offset = "0x12E1D14", VA = "0x12E1D14")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x12E30B0", Offset = "0x12E30B0", VA = "0x12E30B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x12E30B4", Offset = "0x12E30B4", VA = "0x12E30B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x12E31C8", Offset = "0x12E31C8", VA = "0x12E31C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000017")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x12E336C", Offset = "0x12E336C", VA = "0x12E336C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x12E33B4", Offset = "0x12E33B4", VA = "0x12E33B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x12E219C", Offset = "0x12E219C", VA = "0x12E219C")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x12E3210", Offset = "0x12E3210", VA = "0x12E3210", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x12E3214", Offset = "0x12E3214", VA = "0x12E3214", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x12E3374", Offset = "0x12E3374", VA = "0x12E3374", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000019")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x12E346C", Offset = "0x12E346C", VA = "0x12E346C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x12E34B4", Offset = "0x12E34B4", VA = "0x12E34B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x12E2370", Offset = "0x12E2370", VA = "0x12E2370")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x12E33BC", Offset = "0x12E33BC", VA = "0x12E33BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x12E33C0", Offset = "0x12E33C0", VA = "0x12E33C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x12E3474", Offset = "0x12E3474", VA = "0x12E3474", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x12E35A4", Offset = "0x12E35A4", VA = "0x12E35A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x12E35EC", Offset = "0x12E35EC", VA = "0x12E35EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x12E2544", Offset = "0x12E2544", VA = "0x12E2544")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x12E34BC", Offset = "0x12E34BC", VA = "0x12E34BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x12E34C0", Offset = "0x12E34C0", VA = "0x12E34C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x12E35AC", Offset = "0x12E35AC", VA = "0x12E35AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x12E36A4", Offset = "0x12E36A4", VA = "0x12E36A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x12E36EC", Offset = "0x12E36EC", VA = "0x12E36EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x12E2718", Offset = "0x12E2718", VA = "0x12E2718")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x12E35F4", Offset = "0x12E35F4", VA = "0x12E35F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x12E35F8", Offset = "0x12E35F8", VA = "0x12E35F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x12E36AC", Offset = "0x12E36AC", VA = "0x12E36AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x12E37D8", Offset = "0x12E37D8", VA = "0x12E37D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x12E3820", Offset = "0x12E3820", VA = "0x12E3820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x12E28EC", Offset = "0x12E28EC", VA = "0x12E28EC")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x12E36F4", Offset = "0x12E36F4", VA = "0x12E36F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x12E36F8", Offset = "0x12E36F8", VA = "0x12E36F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x12E37E0", Offset = "0x12E37E0", VA = "0x12E37E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x12E3928", Offset = "0x12E3928", VA = "0x12E3928", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x12E3970", Offset = "0x12E3970", VA = "0x12E3970", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x12E2AC0", Offset = "0x12E2AC0", VA = "0x12E2AC0")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x12E3828", Offset = "0x12E3828", VA = "0x12E3828", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x12E382C", Offset = "0x12E382C", VA = "0x12E382C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x12E3930", Offset = "0x12E3930", VA = "0x12E3930", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Allow linear movement prior to the teleport system being activated.")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[Tooltip("Allow linear movement while the teleport system is in the process of aiming for a teleport target.")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[Tooltip("Allow linear movement while the teleport system is in the process of configuring the landing orientation.")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[Tooltip("Allow linear movement after the teleport has occurred but before the system has returned to the ready state.")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("Allow rotation prior to the teleport system being activated.")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[Tooltip("Allow rotation while the teleport system is in the process of aiming for a teleport target.")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[Tooltip("Allow rotation while the teleport system is in the process of configuring the landing orientation.")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[Tooltip("Allow rotation after the teleport has occurred but before the system has returned to the ready state.")]
	public bool EnableRotationDuringPostTeleport;

	[NonSerialized]
	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("This prefab will be instantiated as needed and updated to match the current aim target.")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("TeleportDestinationPrefab will be instantiated into this layer.")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Tooltip("When aiming at possible destinations, the aim collision type determines which shape to use for collision tests.")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Tooltip("Use the character collision radius/height/skinwidth for sphere/capsule collision tests.")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Tooltip("Radius of the sphere or capsule used for collision testing when aiming to possible teleport destinations. Ignored if UseCharacterCollisionData is true.")]
	public float AimCollisionRadius;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[Tooltip("Height of the capsule used for collision testing when aiming to possible teleport destinations. Ignored if UseCharacterCollisionData is true.")]
	public float AimCollisionHeight;

	[Token(Token = "0x17000011")]
	public States CurrentState
	{
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x12E1358", Offset = "0x12E1358", VA = "0x12E1358")]
		[CompilerGenerated]
		get
		{
			return default(States);
		}
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x12E1360", Offset = "0x12E1360", VA = "0x12E1360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x12E1530", Offset = "0x12E1530", VA = "0x12E1530")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x17000013")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x12E1554", Offset = "0x12E1554", VA = "0x12E1554")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x12E155C", Offset = "0x12E155C", VA = "0x12E155C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x12E1368", Offset = "0x12E1368", VA = "0x12E1368")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x12E1418", Offset = "0x12E1418", VA = "0x12E1418")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x12E1BDC", Offset = "0x12E1BDC", VA = "0x12E1BDC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x12E1C78", Offset = "0x12E1C78", VA = "0x12E1C78")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x12E1D3C", Offset = "0x12E1D3C", VA = "0x12E1D3C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x12E1DD8", Offset = "0x12E1DD8", VA = "0x12E1DD8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x12E1E74", Offset = "0x12E1E74", VA = "0x12E1E74")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x12E1F24", Offset = "0x12E1F24", VA = "0x12E1F24")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x12E1FF0", Offset = "0x12E1FF0", VA = "0x12E1FF0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x12E208C", Offset = "0x12E208C", VA = "0x12E208C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x12E21C4", Offset = "0x12E21C4", VA = "0x12E21C4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x12E2260", Offset = "0x12E2260", VA = "0x12E2260")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x12E2398", Offset = "0x12E2398", VA = "0x12E2398")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x12E2434", Offset = "0x12E2434", VA = "0x12E2434")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x12E256C", Offset = "0x12E256C", VA = "0x12E256C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x12E2608", Offset = "0x12E2608", VA = "0x12E2608")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x12E2740", Offset = "0x12E2740", VA = "0x12E2740")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x12E27DC", Offset = "0x12E27DC", VA = "0x12E27DC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x12E2914", Offset = "0x12E2914", VA = "0x12E2914")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x12E29B0", Offset = "0x12E29B0", VA = "0x12E29B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x12E2AE8", Offset = "0x12E2AE8", VA = "0x12E2AE8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x12E2B98", Offset = "0x12E2B98", VA = "0x12E2B98")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x12E1310", Offset = "0x12E1310", VA = "0x12E1310")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x12E1334", Offset = "0x12E1334", VA = "0x12E1334")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x12E14C8", Offset = "0x12E14C8", VA = "0x12E14C8")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x12E1564", Offset = "0x12E1564", VA = "0x12E1564")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x12E182C", Offset = "0x12E182C", VA = "0x12E182C")]
	[Conditional("DEBUG_TELEPORT_STATES")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x12E18D4", Offset = "0x12E18D4", VA = "0x12E18D4")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x12E19C0", Offset = "0x12E19C0", VA = "0x12E19C0")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x12E19FC", Offset = "0x12E19FC", VA = "0x12E19FC")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x12E1AAC", Offset = "0x12E1AAC", VA = "0x12E1AAC")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x12E1ADC", Offset = "0x12E1ADC", VA = "0x12E1ADC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x12E1B3C", Offset = "0x12E1B3C", VA = "0x12E1B3C", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x12E1BD4", Offset = "0x12E1BD4", VA = "0x12E1BD4", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x12E1B60", Offset = "0x12E1B60", VA = "0x12E1B60")]
	[IteratorStateMachine(typeof(<ReadyStateCoroutine>d__52))]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x12E1FD4", Offset = "0x12E1FD4", VA = "0x12E1FD4")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x12E2128", Offset = "0x12E2128", VA = "0x12E2128")]
	[IteratorStateMachine(typeof(<AimStateCoroutine>d__64))]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x12E22FC", Offset = "0x12E22FC", VA = "0x12E22FC")]
	[IteratorStateMachine(typeof(<CancelAimStateCoroutine>d__68))]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x12E24D0", Offset = "0x12E24D0", VA = "0x12E24D0")]
	[IteratorStateMachine(typeof(<PreTeleportStateCoroutine>d__72))]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x12E26A4", Offset = "0x12E26A4", VA = "0x12E26A4")]
	[IteratorStateMachine(typeof(<CancelTeleportStateCoroutine>d__76))]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x12E2878", Offset = "0x12E2878", VA = "0x12E2878")]
	[IteratorStateMachine(typeof(<TeleportingStateCoroutine>d__80))]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x12E2A4C", Offset = "0x12E2A4C", VA = "0x12E2A4C")]
	[IteratorStateMachine(typeof(<PostTeleportStateCoroutine>d__84))]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x12E2C48", Offset = "0x12E2C48", VA = "0x12E2C48")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x12E2D5C", Offset = "0x12E2D5C", VA = "0x12E2D5C")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x12E2D8C", Offset = "0x12E2D8C", VA = "0x12E2D8C")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x12E2EC8", Offset = "0x12E2EC8", VA = "0x12E2EC8")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x12E2FB0", Offset = "0x12E2FB0", VA = "0x12E2FB0")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x2000078")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x1400000C")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x12E03C4", Offset = "0x12E03C4", VA = "0x12E03C4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x12E04E8", Offset = "0x12E04E8", VA = "0x12E04E8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x12E3978", Offset = "0x12E3978", VA = "0x12E3978")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x12E3A14", Offset = "0x12E3A14", VA = "0x12E3A14")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x12E3AB0", Offset = "0x12E3AB0", VA = "0x12E3AB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x12E3B90", Offset = "0x12E3B90", VA = "0x12E3B90")]
	private void Start()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x12E3B94", Offset = "0x12E3B94", VA = "0x12E3B94")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x12E3C08", Offset = "0x12E3C08", VA = "0x12E3C08")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x12E3D2C", Offset = "0x12E3D2C", VA = "0x12E3D2C")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x12E3FA4", Offset = "0x12E3FA4", VA = "0x12E3FA4")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x12E41C4", Offset = "0x12E41C4", VA = "0x12E41C4")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x2000079")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x6000223")]
	[Address(RVA = "0x12E41E4", Offset = "0x12E41E4", VA = "0x12E41E4", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x12E4274", Offset = "0x12E4274", VA = "0x12E4274", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000225")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x12E4344", Offset = "0x12E4344", VA = "0x12E4344")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x200007A")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Maximum range for aiming.")]
	public float Range;

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x12E4354", Offset = "0x12E4354", VA = "0x12E4354", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x12E44E4", Offset = "0x12E44E4", VA = "0x12E44E4")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x200007B")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Maximum range for aiming.")]
	public float Range;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The MinimumElevation is relative to the AimPosition.")]
	public float MinimumElevation;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The Gravity is used in conjunction with AimVelocity and the aim direction to simulate a projectile.")]
	public float Gravity;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("The AimVelocity is the initial speed of the faked projectile.")]
	[Range(0.001f, 50f)]
	public float AimVelocity;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("The AimStep is the how much to subdivide the iteration.")]
	[Range(0.001f, 1f)]
	public float AimStep;

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x12E44F4", Offset = "0x12E44F4", VA = "0x12E44F4", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x12E46C8", Offset = "0x12E46C8", VA = "0x12E46C8")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x200007C")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("This prefab will be instantiated when the aim visual is awakened, and will be set active when the user is aiming, and deactivated when they are done aiming.")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x12E46DC", Offset = "0x12E46DC", VA = "0x12E46DC")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x12E4808", Offset = "0x12E4808", VA = "0x12E4808")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x12E4834", Offset = "0x12E4834", VA = "0x12E4834")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x12E4860", Offset = "0x12E4860", VA = "0x12E4860")]
	private void Awake()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x12E4904", Offset = "0x12E4904", VA = "0x12E4904", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x12E4958", Offset = "0x12E4958", VA = "0x12E4958", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x12E49A8", Offset = "0x12E49A8", VA = "0x12E49A8")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x200007D")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("If the target handler provides a target position, this transform will be moved to that position and it's game object enabled. A target position being provided does not mean the position is valid, only that the aim handler found something to test as a destination.")]
	public Transform PositionIndicator;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("This transform will be rotated to match the rotation of the aiming target. Simple teleport destinations should assign this to the object containing this component. More complex teleport destinations might assign this to a sub-object that is used to indicate the landing orientation independently from the rest of the destination indicator, such as when world space effects are required. This will typically be a child of the PositionIndicator.")]
	public Transform OrientationIndicator;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("After the player teleports, the character controller will have it's rotation set to this value. It is different from the OrientationIndicator transform.rotation in order to support both head-relative and forward-facing teleport modes (See TeleportOrientationHandlerThumbstick.cs).")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x17000023")]
	public bool IsValidDestination
	{
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x12E4AA4", Offset = "0x12E4AA4", VA = "0x12E4AA4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x12E4AAC", Offset = "0x12E4AAC", VA = "0x12E4AAC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x12E4C34", Offset = "0x12E4C34", VA = "0x12E4C34")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x12E4CE4", Offset = "0x12E4CE4", VA = "0x12E4CE4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x12E4AB8", Offset = "0x12E4AB8", VA = "0x12E4AB8")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x12E4B3C", Offset = "0x12E4B3C", VA = "0x12E4B3C")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x12E4C00", Offset = "0x12E4C00", VA = "0x12E4C00")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x12E4C30", Offset = "0x12E4C30", VA = "0x12E4C30")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x12E19D8", Offset = "0x12E19D8", VA = "0x12E19D8")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x12E4D94", Offset = "0x12E4D94", VA = "0x12E4D94")]
	public void Recycle()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x12E4DB0", Offset = "0x12E4DB0", VA = "0x12E4DB0", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x200007E")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x12E5378", Offset = "0x12E5378", VA = "0x12E5378", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x12E53C0", Offset = "0x12E53C0", VA = "0x12E53C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x12E51E4", Offset = "0x12E51E4", VA = "0x12E51E4")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x12E52E8", Offset = "0x12E52E8", VA = "0x12E52E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x12E52EC", Offset = "0x12E52EC", VA = "0x12E52EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x12E5380", Offset = "0x12E5380", VA = "0x12E5380", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x12E5464", Offset = "0x12E5464", VA = "0x12E5464", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x12E54AC", Offset = "0x12E54AC", VA = "0x12E54AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x12E5280", Offset = "0x12E5280", VA = "0x12E5280")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x12E53C8", Offset = "0x12E53C8", VA = "0x12E53C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x12E53CC", Offset = "0x12E53CC", VA = "0x12E53CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x12E546C", Offset = "0x12E546C", VA = "0x12E546C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x12E4FA4", Offset = "0x12E4FA4", VA = "0x12E4FA4")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x12E5078", Offset = "0x12E5078", VA = "0x12E5078", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x12E50C4", Offset = "0x12E50C4", VA = "0x12E50C4", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x12E5170", Offset = "0x12E5170", VA = "0x12E5170")]
	[IteratorStateMachine(typeof(<TeleportReadyCoroutine>d__5))]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x12E520C", Offset = "0x12E520C", VA = "0x12E520C")]
	[IteratorStateMachine(typeof(<TeleportAimCoroutine>d__6))]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000242")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x6000243")]
	public abstract void GetAimData(out Ray aimRay);
}
[Token(Token = "0x2000081")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("The button used to begin aiming for a teleport.")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("The button used to trigger the teleport after aiming. It can be the same button as the AimButton, however you cannot abort a teleport if it is.")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("When true, the system will not use the PreTeleport intention which will allow a teleport to occur on a button downpress. When false, the button downpress will trigger the PreTeleport intention and the Teleport intention when the button is released.")]
	public bool FastTeleport;

	[Token(Token = "0x17000028")]
	public Transform Pointer
	{
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x12E54B4", Offset = "0x12E54B4", VA = "0x12E54B4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x12E54BC", Offset = "0x12E54BC", VA = "0x12E54BC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x12E54C4", Offset = "0x12E54C4", VA = "0x12E54C4", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x12E55F0", Offset = "0x12E55F0", VA = "0x12E55F0", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x12E56A4", Offset = "0x12E56A4", VA = "0x12E56A4")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x2000082")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x2000083")]
	public enum InputModes
	{
		[Token(Token = "0x400021C")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x400021D")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x400021E")]
		ThumbstickTeleport,
		[Token(Token = "0x400021F")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x2000084")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x4000221")]
		A,
		[Token(Token = "0x4000222")]
		B,
		[Token(Token = "0x4000223")]
		LeftTrigger,
		[Token(Token = "0x4000224")]
		LeftThumbstick,
		[Token(Token = "0x4000225")]
		RightTrigger,
		[Token(Token = "0x4000226")]
		RightThumbstick,
		[Token(Token = "0x4000227")]
		X,
		[Token(Token = "0x4000228")]
		Y
	}

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Tooltip("CapacitiveButtonForAimAndTeleport=Activate aiming via cap touch detection, press the same button to teleport.\nSeparateButtonsForAimAndTeleport=Use one button to begin aiming, and another to trigger the teleport.\nThumbstickTeleport=Push a thumbstick to begin aiming, release to teleport.")]
	public InputModes InputMode;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Tooltip("Select the controller to be used for aiming. Supports LTouch, RTouch, or Touch for either.")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Tooltip("Select the button to use for triggering aim and teleport when InputMode==CapacitiveButtonForAimAndTeleport")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[Tooltip("The thumbstick magnitude required to trigger aiming and teleports when InputMode==InputModes.ThumbstickTeleport")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x12E56A8", Offset = "0x12E56A8", VA = "0x12E56A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x12E56AC", Offset = "0x12E56AC", VA = "0x12E56AC", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x12E5AE0", Offset = "0x12E5AE0", VA = "0x12E5AE0", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x12E5B9C", Offset = "0x12E5B9C", VA = "0x12E5B9C")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x2000085")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x2000086")]
	public enum OrientationModes
	{
		[Token(Token = "0x400022D")]
		HeadRelative,
		[Token(Token = "0x400022E")]
		ForwardFacing
	}

	[Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x17000029")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x12E604C", Offset = "0x12E604C", VA = "0x12E604C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x12E6094", Offset = "0x12E6094", VA = "0x12E6094", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x12E5E5C", Offset = "0x12E5E5C", VA = "0x12E5E5C")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x12E5F9C", Offset = "0x12E5F9C", VA = "0x12E5F9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x12E5FA0", Offset = "0x12E5FA0", VA = "0x12E5FA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x12E6054", Offset = "0x12E6054", VA = "0x12E6054", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x12E5C8C", Offset = "0x12E5C8C", VA = "0x12E5C8C")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x12E5D74", Offset = "0x12E5D74", VA = "0x12E5D74")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x12E5D7C", Offset = "0x12E5D7C", VA = "0x12E5D7C", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x12E5DB4", Offset = "0x12E5DB4", VA = "0x12E5DB4", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x12E5DE8", Offset = "0x12E5DE8", VA = "0x12E5DE8")]
	[IteratorStateMachine(typeof(<UpdateOrientationCoroutine>d__7))]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000260")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x6000261")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x12E5E84", Offset = "0x12E5E84", VA = "0x12E5E84")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}
}
[Token(Token = "0x2000088")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x600026A")]
	[Address(RVA = "0x12E609C", Offset = "0x12E609C", VA = "0x12E609C", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x12E60A0", Offset = "0x12E60A0", VA = "0x12E60A0", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x12E6148", Offset = "0x12E6148", VA = "0x12E6148")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x2000089")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("HeadRelative=Character will orient to match the arrow. ForwardFacing=When user orients to match the arrow, they will be facing the sensors.")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Should the destination orientation be updated during the aim state in addition to the PreTeleport state?")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("How far from the destination must the HMD be pointing before using it for orientation")]
	public float AimDistanceThreshold;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[Tooltip("How far from the destination must the HMD be pointing before rejecting the teleport")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x12E614C", Offset = "0x12E614C", VA = "0x12E614C", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x12E619C", Offset = "0x12E619C", VA = "0x12E619C", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x12E6660", Offset = "0x12E6660", VA = "0x12E6660")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x200008A")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("HeadRelative=Character will orient to match the arrow. ForwardFacing=When user orients to match the arrow, they will be facing the sensors.")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Which thumbstick is to be used for adjusting the teleport orientation. Supports LTouch, RTouch, or Touch for either.")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("The orientation will only change if the thumbstick magnitude is above this value. This will usually be larger than the TeleportInputHandlerTouch.ThumbstickTeleportThreshold.")]
	public float RotateStickThreshold;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x12E6664", Offset = "0x12E6664", VA = "0x12E6664", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x12E6698", Offset = "0x12E6698", VA = "0x12E6698", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x12E6B94", Offset = "0x12E6B94", VA = "0x12E6B94")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x200008B")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x12E6BA4", Offset = "0x12E6BA4", VA = "0x12E6BA4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x12E6BA8", Offset = "0x12E6BA8", VA = "0x12E6BA8")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x12E6BB0", Offset = "0x12E6BB0", VA = "0x12E6BB0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x12E6C9C", Offset = "0x12E6C9C", VA = "0x12E6C9C")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x12E6CB8", Offset = "0x12E6CB8", VA = "0x12E6CB8")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x200008C")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x1700002B")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x12E6CD0", Offset = "0x12E6CD0", VA = "0x12E6CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x12E6CD8", Offset = "0x12E6CD8", VA = "0x12E6CD8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x12E420C", Offset = "0x12E420C", VA = "0x12E420C", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x12E431C", Offset = "0x12E431C", VA = "0x12E431C", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x12E6CE0", Offset = "0x12E6CE0", VA = "0x12E6CE0")]
	[Conditional("DEBUG_TELEPORT_EVENT_HANDLERS")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x12E494C", Offset = "0x12E494C", VA = "0x12E494C", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x12E49A0", Offset = "0x12E49A0", VA = "0x12E49A0", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x12E434C", Offset = "0x12E434C", VA = "0x12E434C")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x200008D")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x1700002C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x12E73D0", Offset = "0x12E73D0", VA = "0x12E73D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x12E7418", Offset = "0x12E7418", VA = "0x12E7418", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x12E6F88", Offset = "0x12E6F88", VA = "0x12E6F88")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x12E7104", Offset = "0x12E7104", VA = "0x12E7104", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x12E7108", Offset = "0x12E7108", VA = "0x12E7108", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x12E73D8", Offset = "0x12E73D8", VA = "0x12E73D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("This bitmask controls which game object layers will be included in the targeting collision tests.")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x4000248")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x12E6DB0", Offset = "0x12E6DB0", VA = "0x12E6DB0")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x12E6EC8", Offset = "0x12E6EC8", VA = "0x12E6EC8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x12E6EF0", Offset = "0x12E6EF0", VA = "0x12E6EF0", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x12E6F14", Offset = "0x12E6F14", VA = "0x12E6F14")]
	[IteratorStateMachine(typeof(<TargetAimCoroutine>d__7))]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x12E6FB0", Offset = "0x12E6FB0", VA = "0x12E6FB0", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x6000285")]
	protected abstract bool ConsiderTeleport(Vector3 start, ref Vector3 end);

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x12E6FC8", Offset = "0x12E6FC8", VA = "0x12E6FC8", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}
}
[Token(Token = "0x200008F")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x12E7420", Offset = "0x12E7420", VA = "0x12E7420")]
	private void Awake()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x12E7488", Offset = "0x12E7488", VA = "0x12E7488", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x12E75F0", Offset = "0x12E75F0", VA = "0x12E75F0", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x12E76DC", Offset = "0x12E76DC", VA = "0x12E76DC")]
	[Conditional("SHOW_PATH_RESULT")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x12E76E0", Offset = "0x12E76E0", VA = "0x12E76E0")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x2000090")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("When checking line of sight to the destination, add this value to the vertical offset for targeting collision checks.")]
	public float LOSOffset;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Teleport logic will only work with TeleportPoint components that exist in the layers specified by this mask.")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x12E76EC", Offset = "0x12E76EC", VA = "0x12E76EC", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x12E78E4", Offset = "0x12E78E4", VA = "0x12E78E4")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x2000091")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x6000295")]
	[Address(RVA = "0x12E78F0", Offset = "0x12E78F0", VA = "0x12E78F0", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x12E7A58", Offset = "0x12E7A58", VA = "0x12E7A58")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x2000092")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x6000297")]
	[Address(RVA = "0x12E7A5C", Offset = "0x12E7A5C", VA = "0x12E7A5C", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x12E7AE0", Offset = "0x12E7AE0", VA = "0x12E7AE0", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000299")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x12E7B60", Offset = "0x12E7B60", VA = "0x12E7B60")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x2000093")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x1700002E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x12E7EC4", Offset = "0x12E7EC4", VA = "0x12E7EC4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x12E7F0C", Offset = "0x12E7F0C", VA = "0x12E7F0C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x12E7BFC", Offset = "0x12E7BFC", VA = "0x12E7BFC")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x12E7DC0", Offset = "0x12E7DC0", VA = "0x12E7DC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x12E7DC4", Offset = "0x12E7DC4", VA = "0x12E7DC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x12E7ECC", Offset = "0x12E7ECC", VA = "0x12E7ECC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("How long the transition takes. Usually this is greater than Teleport Delay.")]
	[Range(0.01f, 2f)]
	public float TransitionDuration;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("At what percentage of the elapsed transition time does the teleport occur?")]
	[Range(0f, 1f)]
	public float TeleportDelay;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Fade to black over the duration of the transition")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x12E7B68", Offset = "0x12E7B68", VA = "0x12E7B68", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x12E7B88", Offset = "0x12E7B88", VA = "0x12E7B88")]
	[IteratorStateMachine(typeof(<BlinkCoroutine>d__4))]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x12E7C24", Offset = "0x12E7C24", VA = "0x12E7C24")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x2000095")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x12E7F14", Offset = "0x12E7F14", VA = "0x12E7F14", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x12E7F2C", Offset = "0x12E7F2C", VA = "0x12E7F2C")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x2000096")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x17000030")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x12E8150", Offset = "0x12E8150", VA = "0x12E8150", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x12E8198", Offset = "0x12E8198", VA = "0x12E8198", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x12E7FC8", Offset = "0x12E7FC8", VA = "0x12E7FC8")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x12E8038", Offset = "0x12E8038", VA = "0x12E8038", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x12E803C", Offset = "0x12E803C", VA = "0x12E803C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x12E8158", Offset = "0x12E8158", VA = "0x12E8158", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("How much time the warp transition takes to complete.")]
	[Range(0.01f, 1f)]
	public float TransitionDuration;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x12E7F34", Offset = "0x12E7F34", VA = "0x12E7F34", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x12E7F54", Offset = "0x12E7F54", VA = "0x12E7F54")]
	[IteratorStateMachine(typeof(<DoWarp>d__3))]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x12E7FF0", Offset = "0x12E7FF0", VA = "0x12E7FF0")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x2000098")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x2000099")]
	public enum PlabackState
	{
		[Token(Token = "0x4000278")]
		Idle = 1,
		[Token(Token = "0x4000279")]
		Preparing,
		[Token(Token = "0x400027A")]
		Buffering,
		[Token(Token = "0x400027B")]
		Ready,
		[Token(Token = "0x400027C")]
		Ended
	}

	[Token(Token = "0x200009A")]
	public enum StereoMode
	{
		[Token(Token = "0x400027E")]
		Unknown = -1,
		[Token(Token = "0x400027F")]
		Mono,
		[Token(Token = "0x4000280")]
		TopBottom,
		[Token(Token = "0x4000281")]
		LeftRight,
		[Token(Token = "0x4000282")]
		Mesh
	}

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getCurrentPlaybackStateMethodId;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x17000032")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x12E81A0", Offset = "0x12E81A0", VA = "0x12E81A0")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17000033")]
	private static IntPtr Activity
	{
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x12E8490", Offset = "0x12E8490", VA = "0x12E8490")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17000034")]
	public static bool IsAvailable
	{
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x12E8710", Offset = "0x12E8710", VA = "0x12E8710")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000035")]
	public static bool IsPlaying
	{
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x12E8784", Offset = "0x12E8784", VA = "0x12E8784")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000036")]
	public static PlabackState CurrentPlaybackState
	{
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x12E8888", Offset = "0x12E8888", VA = "0x12E8888")]
		get
		{
			return default(PlabackState);
		}
	}

	[Token(Token = "0x17000037")]
	public static long Duration
	{
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x12E8990", Offset = "0x12E8990", VA = "0x12E8990")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000038")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x12E8A98", Offset = "0x12E8A98", VA = "0x12E8A98")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x17000039")]
	public static int VideoWidth
	{
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x12E8BA0", Offset = "0x12E8BA0", VA = "0x12E8BA0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003A")]
	public static int VideoHeight
	{
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x12E8CA8", Offset = "0x12E8CA8", VA = "0x12E8CA8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003B")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x12E8DB0", Offset = "0x12E8DB0", VA = "0x12E8DB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x12E8EB8", Offset = "0x12E8EB8", VA = "0x12E8EB8")]
		set
		{
		}
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x12E9020", Offset = "0x12E9020", VA = "0x12E9020")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x12E9238", Offset = "0x12E9238", VA = "0x12E9238")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x12E9340", Offset = "0x12E9340", VA = "0x12E9340")]
	public static void Play()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x12E9448", Offset = "0x12E9448", VA = "0x12E9448")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x12E9550", Offset = "0x12E9550", VA = "0x12E9550")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x12E96C0", Offset = "0x12E96C0", VA = "0x12E96C0")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x12E982C", Offset = "0x12E982C", VA = "0x12E982C")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x200009B")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x1400000F")]
	public event Action onButtonDown
	{
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x12E9A80", Offset = "0x12E9A80", VA = "0x12E9A80")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x12E9B1C", Offset = "0x12E9B1C", VA = "0x12E9B1C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x12E9BB8", Offset = "0x12E9BB8", VA = "0x12E9BB8", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x12E9BD4", Offset = "0x12E9BD4", VA = "0x12E9BD4")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x200009C")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x200009D")]
	public enum ButtonType
	{
		[Token(Token = "0x4000286")]
		Play,
		[Token(Token = "0x4000287")]
		Pause,
		[Token(Token = "0x4000288")]
		FastForward,
		[Token(Token = "0x4000289")]
		Rewind,
		[Token(Token = "0x400028A")]
		SkipForward,
		[Token(Token = "0x400028B")]
		SkipBack,
		[Token(Token = "0x400028C")]
		Stop
	}

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x1700003C")]
	public ButtonType buttonType
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x12E9BDC", Offset = "0x12E9BDC", VA = "0x12E9BDC")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x12E9BE4", Offset = "0x12E9BE4", VA = "0x12E9BE4")]
		set
		{
		}
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x12E9C08", Offset = "0x12E9C08", VA = "0x12E9C08", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x12EAA5C", Offset = "0x12EAA5C", VA = "0x12EAA5C")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x200009E")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x200009F")]
	public enum VideoShape
	{
		[Token(Token = "0x40002A1")]
		_360,
		[Token(Token = "0x40002A2")]
		_180,
		[Token(Token = "0x40002A3")]
		Quad
	}

	[Token(Token = "0x20000A0")]
	public enum VideoStereo
	{
		[Token(Token = "0x40002A5")]
		Mono,
		[Token(Token = "0x40002A6")]
		TopBottom,
		[Token(Token = "0x40002A7")]
		LeftRight,
		[Token(Token = "0x40002A8")]
		BottomTop
	}

	[Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x17000040")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x12EBFB8", Offset = "0x12EBFB8", VA = "0x12EBFB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x12EC000", Offset = "0x12EC000", VA = "0x12EC000", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x12EB150", Offset = "0x12EB150", VA = "0x12EB150")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x12EBE0C", Offset = "0x12EBE0C", VA = "0x12EBE0C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x12EBE10", Offset = "0x12EBE10", VA = "0x12EBE10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x12EBFC0", Offset = "0x12EBFC0", VA = "0x12EBFC0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x1700003D")]
	public bool IsPlaying
	{
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x12EAAB4", Offset = "0x12EAAB4", VA = "0x12EAAB4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x12EAABC", Offset = "0x12EAABC", VA = "0x12EAABC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	public long Duration
	{
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x12EAAC8", Offset = "0x12EAAC8", VA = "0x12EAAC8")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x12EAAD0", Offset = "0x12EAAD0", VA = "0x12EAAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700003F")]
	public long PlaybackPosition
	{
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x12EAAD8", Offset = "0x12EAAD8", VA = "0x12EAAD8")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x12EAAE0", Offset = "0x12EAAE0", VA = "0x12EAAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x12EAAE8", Offset = "0x12EAAE8", VA = "0x12EAAE8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x12EAD70", Offset = "0x12EAD70", VA = "0x12EAD70")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x12EADD0", Offset = "0x12EADD0", VA = "0x12EADD0")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x12EB0DC", Offset = "0x12EB0DC", VA = "0x12EB0DC")]
	[IteratorStateMachine(typeof(<Start>d__33))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x12EB178", Offset = "0x12EB178", VA = "0x12EB178")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x12EB450", Offset = "0x12EB450", VA = "0x12EB450")]
	public void Play()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x12EB4D8", Offset = "0x12EB4D8", VA = "0x12EB4D8")]
	public void Pause()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x12EB55C", Offset = "0x12EB55C", VA = "0x12EB55C")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x12EB64C", Offset = "0x12EB64C", VA = "0x12EB64C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x12EBBF8", Offset = "0x12EBBF8", VA = "0x12EBBF8")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x12EBC98", Offset = "0x12EBC98", VA = "0x12EBC98")]
	public void Stop()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x12EBD1C", Offset = "0x12EBD1C", VA = "0x12EBD1C")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x12EBDFC", Offset = "0x12EBDFC", VA = "0x12EBDFC")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x20000A3")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x20000A4")]
	private enum PlaybackState
	{
		[Token(Token = "0x40002C5")]
		Playing,
		[Token(Token = "0x40002C6")]
		Paused,
		[Token(Token = "0x40002C7")]
		Rewinding,
		[Token(Token = "0x40002C8")]
		FastForwarding
	}

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x12EC0E4", Offset = "0x12EC0E4", VA = "0x12EC0E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x12EC410", Offset = "0x12EC410", VA = "0x12EC410")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x12EC5E0", Offset = "0x12EC5E0", VA = "0x12EC5E0")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x12EC704", Offset = "0x12EC704", VA = "0x12EC704")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x12EC800", Offset = "0x12EC800", VA = "0x12EC800")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x12EC6D8", Offset = "0x12EC6D8", VA = "0x12EC6D8")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x12EC860", Offset = "0x12EC860", VA = "0x12EC860")]
	private void Update()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x12EC310", Offset = "0x12EC310", VA = "0x12EC310")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x12ECB90", Offset = "0x12ECB90", VA = "0x12ECB90")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x20000A5")]
public static class VectorUtil
{
	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x12EBB80", Offset = "0x12EBB80", VA = "0x12EBB80")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x20000A6")]
public class AppDeeplinkUI : MonoBehaviour
{
	[Token(Token = "0x40002C9")]
	private const ulong UNITY_COMPANION_APP_ID = 3535750239844224uL;

	[Token(Token = "0x40002CA")]
	private const ulong UNREAL_COMPANION_APP_ID = 4055411724486843uL;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform deeplinkAppId;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform deeplinkMessage;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform uiLaunchType;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform uiLaunchSource;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform uiDeepLinkMessage;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool inMenu;

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x12ECBA0", Offset = "0x12ECBA0", VA = "0x12ECBA0")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x12ED1F4", Offset = "0x12ED1F4", VA = "0x12ED1F4")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x12ED450", Offset = "0x12ED450", VA = "0x12ED450")]
	private void LaunchUnrealDeeplinkSample()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x12ED5B4", Offset = "0x12ED5B4", VA = "0x12ED5B4")]
	private void LaunchSelf()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x12ED71C", Offset = "0x12ED71C", VA = "0x12ED71C")]
	private void LaunchOtherApp()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x12ED8A0", Offset = "0x12ED8A0", VA = "0x12ED8A0")]
	public AppDeeplinkUI()
	{
	}
}
[Token(Token = "0x20000A7")]
public class CustomDebugUI : MonoBehaviour
{
	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomDebugUI instance;

	[Token(Token = "0x40002D3")]
	private const BindingFlags privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x12ED8B0", Offset = "0x12ED8B0", VA = "0x12ED8B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x12ED908", Offset = "0x12ED908", VA = "0x12ED908")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x12ED90C", Offset = "0x12ED90C", VA = "0x12ED90C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x12ECF9C", Offset = "0x12ECF9C", VA = "0x12ECF9C")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x12ED910", Offset = "0x12ED910", VA = "0x12ED910")]
	public void RemoveFromCanvas(RectTransform element, int targetCanvas = 0)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x12EDB2C", Offset = "0x12EDB2C", VA = "0x12EDB2C")]
	public CustomDebugUI()
	{
	}
}
[Token(Token = "0x20000A8")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x12EDB34", Offset = "0x12EDB34", VA = "0x12EDB34")]
	private void Start()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x12EE094", Offset = "0x12EE094", VA = "0x12EE094")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x12EE140", Offset = "0x12EE140", VA = "0x12EE140")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x12EE3D0", Offset = "0x12EE3D0", VA = "0x12EE3D0")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x12EE4A4", Offset = "0x12EE4A4", VA = "0x12EE4A4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x12EE57C", Offset = "0x12EE57C", VA = "0x12EE57C")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x12EE5E4", Offset = "0x12EE5E4", VA = "0x12EE5E4")]
	public DebugUISample()
	{
	}
}
[Token(Token = "0x20000A9")]
public class AnalyticsUI : MonoBehaviour
{
	[Token(Token = "0x6000306")]
	[Address(RVA = "0x12EE78C", Offset = "0x12EE78C", VA = "0x12EE78C")]
	public AnalyticsUI()
	{
	}
}
[Token(Token = "0x20000AA")]
public class SampleUI : MonoBehaviour
{
	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform collectionButton;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform inputText;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform valueText;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool inMenu;

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x12EE794", Offset = "0x12EE794", VA = "0x12EE794")]
	private void Start()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x12EE82C", Offset = "0x12EE82C", VA = "0x12EE82C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x12EE904", Offset = "0x12EE904", VA = "0x12EE904")]
	public SampleUI()
	{
	}
}
[Token(Token = "0x20000AB")]
public class StartCrashlytics : MonoBehaviour
{
	[Token(Token = "0x600030A")]
	[Address(RVA = "0x12EE90C", Offset = "0x12EE90C", VA = "0x12EE90C")]
	public StartCrashlytics()
	{
	}
}
[Token(Token = "0x20000AC")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x17000042")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x12EED1C", Offset = "0x12EED1C", VA = "0x12EED1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x12EED64", Offset = "0x12EED64", VA = "0x12EED64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x12EEBB8", Offset = "0x12EEBB8", VA = "0x12EEBB8")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x12EEBE8", Offset = "0x12EEBE8", VA = "0x12EEBE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x12EEBEC", Offset = "0x12EEBEC", VA = "0x12EEBEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x12EED24", Offset = "0x12EED24", VA = "0x12EED24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x12EE914", Offset = "0x12EE914", VA = "0x12EE914")]
	private void Awake()
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x12EEA20", Offset = "0x12EEA20", VA = "0x12EEA20")]
	private void Update()
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x12EE9AC", Offset = "0x12EE9AC", VA = "0x12EE9AC")]
	[IteratorStateMachine(typeof(<GetCenterEye>d__6))]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x12EEBE0", Offset = "0x12EEBE0", VA = "0x12EEBE0")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x20000AE")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(4f, 32f)]
	public int SubdivisionsU;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(4f, 32f)]
	public int SubdivisionsV;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x12EED6C", Offset = "0x12EED6C", VA = "0x12EED6C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x12F0714", Offset = "0x12F0714", VA = "0x12F0714")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x20000AF")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x17000044")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x12F071C", Offset = "0x12F071C", VA = "0x12F071C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x12F076C", Offset = "0x12F076C", VA = "0x12F076C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x12F0BA4", Offset = "0x12F0BA4", VA = "0x12F0BA4")]
	public void Update()
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x12F0C7C", Offset = "0x12F0C7C", VA = "0x12F0C7C")]
	[Conditional("DEBUG_LOCOMOTION_PANEL")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x600031B")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600031C")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x600031D")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x600031E")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x600031F")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x6000320")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x6000321")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x6000322")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x12F0CD4", Offset = "0x12F0CD4", VA = "0x12F0CD4")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x12F0D14", Offset = "0x12F0D14", VA = "0x12F0D14")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x12F0D80", Offset = "0x12F0D80", VA = "0x12F0D80")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x12F0ECC", Offset = "0x12F0ECC", VA = "0x12F0ECC")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x12F0F9C", Offset = "0x12F0F9C", VA = "0x12F0F9C")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x12F0A80", Offset = "0x12F0A80", VA = "0x12F0A80")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x12F106C", Offset = "0x12F106C", VA = "0x12F106C")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x12F10B8", Offset = "0x12F10B8", VA = "0x12F10B8")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x12F11C8", Offset = "0x12F11C8", VA = "0x12F11C8")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x20000B0")]
[RequireComponent(typeof(Canvas))]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x20000B1")]
	public enum DrawMode
	{
		[Token(Token = "0x4000302")]
		Opaque,
		[Token(Token = "0x4000303")]
		OpaqueWithClip,
		[Token(Token = "0x4000304")]
		TransparentDefaultAlpha,
		[Token(Token = "0x4000305")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private Shader _transparentShader;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[HideInInspector]
	private Shader _opaqueShader;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x17000045")]
	public bool overlayEnabled
	{
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x12F280C", Offset = "0x12F280C", VA = "0x12F280C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x12F2890", Offset = "0x12F2890", VA = "0x12F2890")]
		set
		{
		}
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x12F11D0", Offset = "0x12F11D0", VA = "0x12F11D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x12F1E94", Offset = "0x12F1E94", VA = "0x12F1E94")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x12F1F08", Offset = "0x12F1F08", VA = "0x12F1F08")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x12F1FD8", Offset = "0x12F1FD8", VA = "0x12F1FD8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x12F20A8", Offset = "0x12F20A8", VA = "0x12F20A8", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x12F22AC", Offset = "0x12F22AC", VA = "0x12F22AC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x12F294C", Offset = "0x12F294C", VA = "0x12F294C")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x20000B2")]
public class AugmentedObject : MonoBehaviour
{
	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform shadow;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool groundShadow;

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x12F2A08", Offset = "0x12F2A08", VA = "0x12F2A08")]
	private void Start()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x12F2DA8", Offset = "0x12F2DA8", VA = "0x12F2DA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x12F2F3C", Offset = "0x12F2F3C", VA = "0x12F2F3C")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x12F2F44", Offset = "0x12F2F44", VA = "0x12F2F44")]
	public void Release()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x12F2F2C", Offset = "0x12F2F2C", VA = "0x12F2F2C")]
	private void ToggleShadowType()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x12F2F4C", Offset = "0x12F2F4C", VA = "0x12F2F4C")]
	public AugmentedObject()
	{
	}
}
[Token(Token = "0x20000B3")]
public class BrushController : MonoBehaviour
{
	[Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class <FadeCameraClearColor>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeTime;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color newColor;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <timer>5__2;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <currentColor>5__3;

		[Token(Token = "0x17000046")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x12F3694", Offset = "0x12F3694", VA = "0x12F3694", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x12F36DC", Offset = "0x12F36DC", VA = "0x12F36DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x12F3538", Offset = "0x12F3538", VA = "0x12F3538")]
		[DebuggerHidden]
		public <FadeCameraClearColor>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x12F3590", Offset = "0x12F3590", VA = "0x12F3590", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x12F3594", Offset = "0x12F3594", VA = "0x12F3594", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x12F369C", Offset = "0x12F369C", VA = "0x12F369C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class <FadeSphere>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrushController <>4__this;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool disableOnFinish;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x17000048")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x12F3860", Offset = "0x12F3860", VA = "0x12F3860", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x12F38A8", Offset = "0x12F38A8", VA = "0x12F38A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x12F3560", Offset = "0x12F3560", VA = "0x12F3560")]
		[DebuggerHidden]
		public <FadeSphere>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x12F36E4", Offset = "0x12F36E4", VA = "0x12F36E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x12F36E8", Offset = "0x12F36E8", VA = "0x12F36E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x12F3868", Offset = "0x12F3868", VA = "0x12F3868", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PassthroughBrush brush;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer backgroundSphere;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator grabRoutine;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator releaseRoutine;

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x12F2F54", Offset = "0x12F2F54", VA = "0x12F2F54")]
	private void Start()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x12F3234", Offset = "0x12F3234", VA = "0x12F3234")]
	private void Update()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x12F3284", Offset = "0x12F3284", VA = "0x12F3284")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x12F33FC", Offset = "0x12F33FC", VA = "0x12F33FC")]
	public void Release()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x12F34A0", Offset = "0x12F34A0", VA = "0x12F34A0")]
	[IteratorStateMachine(typeof(<FadeCameraClearColor>d__8))]
	private IEnumerator FadeCameraClearColor(Color newColor, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x12F333C", Offset = "0x12F333C", VA = "0x12F333C")]
	[IteratorStateMachine(typeof(<FadeSphere>d__9))]
	private IEnumerator FadeSphere(Color newColor, float fadeTime, bool disableOnFinish = false)
	{
		return null;
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x12F3588", Offset = "0x12F3588", VA = "0x12F3588")]
	public BrushController()
	{
	}
}
[Token(Token = "0x20000B6")]
public class EnableUnpremultipliedAlpha : MonoBehaviour
{
	[Token(Token = "0x600034F")]
	[Address(RVA = "0x12F38B0", Offset = "0x12F38B0", VA = "0x12F38B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x12F3904", Offset = "0x12F3904", VA = "0x12F3904")]
	public EnableUnpremultipliedAlpha()
	{
	}
}
[Token(Token = "0x20000B7")]
public class Flashlight : MonoBehaviour
{
	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject lightVolume;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEngine.Light spotlight;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject bulbGlow;

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x12F390C", Offset = "0x12F390C", VA = "0x12F390C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x12F3AE0", Offset = "0x12F3AE0", VA = "0x12F3AE0")]
	public void ToggleFlashlight()
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x12F3B70", Offset = "0x12F3B70", VA = "0x12F3B70")]
	public void EnableFlashlight(bool doEnable)
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x12F3BCC", Offset = "0x12F3BCC", VA = "0x12F3BCC")]
	public Flashlight()
	{
	}
}
[Token(Token = "0x20000B8")]
public class FlashlightController : MonoBehaviour
{
	[Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class <FadeLighting>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlashlightController <>4__this;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sceneLightIntensity;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <currentLight>5__4;

		[Token(Token = "0x1700004A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x12F4DA4", Offset = "0x12F4DA4", VA = "0x12F4DA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x12F4DEC", Offset = "0x12F4DEC", VA = "0x12F4DEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x12F4B0C", Offset = "0x12F4B0C", VA = "0x12F4B0C")]
		[DebuggerHidden]
		public <FadeLighting>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x12F4BD4", Offset = "0x12F4BD4", VA = "0x12F4BD4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x12F4BD8", Offset = "0x12F4BD8", VA = "0x12F4BD8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x12F4DAC", Offset = "0x12F4DAC", VA = "0x12F4DAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEngine.Light sceneLight;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform flashlightRoot;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 localPosition;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Quaternion localRotation;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMesh infoText;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GrabObject externalController;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private OVRSkeleton[] skeletons;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OVRHand[] hands;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int handIndex;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool pinching;

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x12F3BD4", Offset = "0x12F3BD4", VA = "0x12F3BD4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x12F3EBC", Offset = "0x12F3EBC", VA = "0x12F3EBC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x12F41A8", Offset = "0x12F41A8", VA = "0x12F41A8")]
	private void FindHands()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x12F44D0", Offset = "0x12F44D0", VA = "0x12F44D0")]
	private void AlignWithHand(OVRHand hand, OVRSkeleton skeleton)
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x12F47A8", Offset = "0x12F47A8", VA = "0x12F47A8")]
	private void AlignWithController(OVRInput.Controller controller)
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x12F4890", Offset = "0x12F4890", VA = "0x12F4890")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x12F4A28", Offset = "0x12F4A28", VA = "0x12F4A28")]
	public void Release()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x12F4978", Offset = "0x12F4978", VA = "0x12F4978")]
	[IteratorStateMachine(typeof(<FadeLighting>d__17))]
	private IEnumerator FadeLighting(Color newColor, float sceneLightIntensity, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x12F4B34", Offset = "0x12F4B34", VA = "0x12F4B34")]
	public FlashlightController()
	{
	}
}
[Token(Token = "0x20000BA")]
public class GrabObject : MonoBehaviour
{
	[Token(Token = "0x20000BB")]
	public enum ManipulationType
	{
		[Token(Token = "0x400033A")]
		Default,
		[Token(Token = "0x400033B")]
		ForcedHand,
		[Token(Token = "0x400033C")]
		DollyHand,
		[Token(Token = "0x400033D")]
		DollyAttached,
		[Token(Token = "0x400033E")]
		HorizontalScaled,
		[Token(Token = "0x400033F")]
		VerticalScaled,
		[Token(Token = "0x4000340")]
		Menu
	}

	[Token(Token = "0x20000BC")]
	public delegate void GrabbedObject(OVRInput.Controller grabHand);

	[Token(Token = "0x20000BD")]
	public delegate void ReleasedObject();

	[Token(Token = "0x20000BE")]
	public delegate void SetCursorPosition(Vector3 cursorPosition);

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[TextArea]
	public string ObjectName;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[TextArea]
	public string ObjectInstructions;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ManipulationType objectManipulationType;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool showLaserWhileGrabbed;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Quaternion grabbedRotation;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GrabbedObject GrabbedObjectDelegate;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ReleasedObject ReleasedObjectDelegate;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SetCursorPosition CursorPositionDelegate;

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x12F4DF4", Offset = "0x12F4DF4", VA = "0x12F4DF4")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x12F4E54", Offset = "0x12F4E54", VA = "0x12F4E54")]
	public void Release()
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x12F4E70", Offset = "0x12F4E70", VA = "0x12F4E70")]
	public void CursorPos(Vector3 cursorPos)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x12F4E8C", Offset = "0x12F4E8C", VA = "0x12F4E8C")]
	public GrabObject()
	{
	}
}
[Token(Token = "0x20000BF")]
public class HandMeshMask : MonoBehaviour
{
	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSkeleton referenceHand;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material maskMaterial;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The segments around the tip of a finger")]
	public int radialDivisions;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The fade range (finger width is 2x this)")]
	public float borderSize;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Along the fingers, each knuckle scales down by this amount. Default is zero for uniform width along entire finger.")]
	public float fingerTaper;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("Shorten the last bone of each finger; need this to account for bone structure (end bone is at finger tip instead of center). Default is 1.")]
	public float fingerTipLength;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("Move the base of the 4 main fingers towards the tips, to avoid a visible mesh crack between finger webbing. Default is 0.")]
	public float webOffset;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float handScale;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject maskMeshObject;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Mesh maskMesh;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] handVertices;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2[] handUVs;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color32[] handColors;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] handTriangles;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int vertCounter;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int triCounter;

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x12F5144", Offset = "0x12F5144", VA = "0x12F5144")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x12F53A4", Offset = "0x12F53A4", VA = "0x12F53A4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x12F556C", Offset = "0x12F556C", VA = "0x12F556C")]
	private void CreateHandMesh()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x12F5BC0", Offset = "0x12F5BC0", VA = "0x12F5BC0")]
	private void AddKnuckleMesh(int knuckleVerts, float point1scale, float point2scale, Vector3 point1, Vector3 point2)
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x12F6158", Offset = "0x12F6158", VA = "0x12F6158")]
	private void AddPalmMesh(int knuckleVerts)
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x12F8460", Offset = "0x12F8460", VA = "0x12F8460")]
	private void AddVertex(Vector3 position, Vector2 uv, Color color)
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x12F87D4", Offset = "0x12F87D4", VA = "0x12F87D4")]
	public HandMeshMask()
	{
	}
}
[Token(Token = "0x20000C0")]
public class HandMeshUI : MonoBehaviour
{
	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SphereCollider[] knobs;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh[] readouts;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rightHeldKnob;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int leftHeldKnob;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public OVRSkeleton leftHand;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OVRSkeleton rightHand;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HandMeshMask leftMask;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HandMeshMask rightMask;

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x12F87F8", Offset = "0x12F87F8", VA = "0x12F87F8")]
	private void Start()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x12F8B60", Offset = "0x12F8B60", VA = "0x12F8B60")]
	private void Update()
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x12F8894", Offset = "0x12F8894", VA = "0x12F8894")]
	private void SetSliderValue(int sliderID, float value, bool isNormalized)
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x12F8FC8", Offset = "0x12F8FC8", VA = "0x12F8FC8")]
	private void CheckForHands()
	{
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x12F9538", Offset = "0x12F9538", VA = "0x12F9538")]
	public HandMeshUI()
	{
	}
}
[Token(Token = "0x20000C1")]
public class ObjectManipulator : MonoBehaviour
{
	[Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class <StartDemo>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectManipulator <>4__this;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fadeTime>5__3;

		[Token(Token = "0x1700004C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x12FBDD8", Offset = "0x12FBDD8", VA = "0x12FBDD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x12FBE20", Offset = "0x12FBE20", VA = "0x12FBE20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x12FBADC", Offset = "0x12FBADC", VA = "0x12FBADC")]
		[DebuggerHidden]
		public <StartDemo>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x12FBB04", Offset = "0x12FBB04", VA = "0x12FBB04", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x12FBB08", Offset = "0x12FBB08", VA = "0x12FBB08", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x12FBDE0", Offset = "0x12FBDE0", VA = "0x12FBDE0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRInput.Controller controller;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject hoverObject;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject grabObject;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float grabTime;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 localGrabOffset;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion localGrabRotation;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 camGrabPosition;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion camGrabRotation;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 handGrabPosition;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion handGrabRotation;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 cursorPosition;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float rotationOffset;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LineRenderer laser;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform objectInfo;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMesh objectNameLabel;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMesh objectInstructionsLabel;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image objectInfoBG;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject demoObjects;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public OVRPassthroughLayer passthrough;

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x12F9548", Offset = "0x12F9548", VA = "0x12F9548")]
	private void Start()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x12F9740", Offset = "0x12F9740", VA = "0x12F9740")]
	private void Update()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x12FA67C", Offset = "0x12FA67C", VA = "0x12FA67C")]
	private void GrabHoverObject(GameObject grbObj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x12FB410", Offset = "0x12FB410", VA = "0x12FB410")]
	private void ReleaseObject()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x12F96CC", Offset = "0x12F96CC", VA = "0x12F96CC")]
	[IteratorStateMachine(typeof(<StartDemo>d__23))]
	private IEnumerator StartDemo()
	{
		return null;
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x12F9990", Offset = "0x12F9990", VA = "0x12F9990")]
	private void FindHoverObject(Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x12FA970", Offset = "0x12FA970", VA = "0x12FA970")]
	private void ManipulateObject(GameObject obj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x12FB71C", Offset = "0x12FB71C", VA = "0x12FB71C")]
	private void ClampGrabOffset(ref Vector3 localOffset, float thumbY)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x12FB7D0", Offset = "0x12FB7D0", VA = "0x12FB7D0")]
	private Vector3 ClampScale(Vector3 localScale, Vector2 thumb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x12FB800", Offset = "0x12FB800", VA = "0x12FB800")]
	private void CheckForDominantHand()
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x12FB600", Offset = "0x12FB600", VA = "0x12FB600")]
	private void AssignInstructions(GrabObject targetObject)
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x12FB8F0", Offset = "0x12FB8F0", VA = "0x12FB8F0")]
	public ObjectManipulator()
	{
	}
}
[Token(Token = "0x20000C3")]
public class OverlayPassthrough : MonoBehaviour
{
	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x12FBE28", Offset = "0x12FBE28", VA = "0x12FBE28")]
	private void Start()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x12FBF94", Offset = "0x12FBF94", VA = "0x12FBF94")]
	private void Update()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x12FC048", Offset = "0x12FC048", VA = "0x12FC048")]
	public OverlayPassthrough()
	{
	}
}
[Token(Token = "0x20000C4")]
public class PassthroughBrush : MonoBehaviour
{
	[Token(Token = "0x20000C5")]
	public enum BrushState
	{
		[Token(Token = "0x400037D")]
		Idle,
		[Token(Token = "0x400037E")]
		Inking
	}

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject lineSegmentPrefab;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject lineContainer;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool forceActive;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LineRenderer currentLineSegment;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Vector3> inkPositions;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float minInkDist;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float strokeWidth;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float strokeLength;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private BrushState brushStatus;

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x12FC050", Offset = "0x12FC050", VA = "0x12FC050")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x12FC058", Offset = "0x12FC058", VA = "0x12FC058")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x12FC308", Offset = "0x12FC308", VA = "0x12FC308")]
	private void StartLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x12FC53C", Offset = "0x12FC53C", VA = "0x12FC53C")]
	private void UpdateLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x12FC77C", Offset = "0x12FC77C", VA = "0x12FC77C")]
	public void ClearLines()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x12FC220", Offset = "0x12FC220", VA = "0x12FC220")]
	public void UndoInkLine()
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x12FC84C", Offset = "0x12FC84C", VA = "0x12FC84C")]
	public PassthroughBrush()
	{
	}
}
[Token(Token = "0x20000C6")]
public class PassthroughController : MonoBehaviour
{
	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x12FC8E8", Offset = "0x12FC8E8", VA = "0x12FC8E8")]
	private void Start()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x12FCA54", Offset = "0x12FCA54", VA = "0x12FCA54")]
	private void Update()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x12FCC40", Offset = "0x12FCC40", VA = "0x12FCC40")]
	public PassthroughController()
	{
	}
}
[Token(Token = "0x20000C7")]
public class PassthroughProjectionSurface : MonoBehaviour
{
	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer quadOutline;

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x12FCC48", Offset = "0x12FCC48", VA = "0x12FCC48")]
	private void Start()
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x12FCE30", Offset = "0x12FCE30", VA = "0x12FCE30")]
	private void Update()
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x12FCFD0", Offset = "0x12FCFD0", VA = "0x12FCFD0")]
	public PassthroughProjectionSurface()
	{
	}
}
[Token(Token = "0x20000C8")]
public class PassthroughStyler : MonoBehaviour
{
	[Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class <FadeToCurrentStyle>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x1700004E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x12FDCEC", Offset = "0x12FDCEC", VA = "0x12FDCEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x12FDD34", Offset = "0x12FDD34", VA = "0x12FDD34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x12FDAE0", Offset = "0x12FDAE0", VA = "0x12FDAE0")]
		[DebuggerHidden]
		public <FadeToCurrentStyle>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x12FDC60", Offset = "0x12FDC60", VA = "0x12FDC60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x12FDC64", Offset = "0x12FDC64", VA = "0x12FDC64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x12FDCF4", Offset = "0x12FDCF4", VA = "0x12FDCF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class <FadeToDefaultPassthrough>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x17000050")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x12FDDC0", Offset = "0x12FDDC0", VA = "0x12FDDC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x12FDE08", Offset = "0x12FDE08", VA = "0x12FDE08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x12FDB08", Offset = "0x12FDB08", VA = "0x12FDB08")]
		[DebuggerHidden]
		public <FadeToDefaultPassthrough>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x12FDD3C", Offset = "0x12FDD3C", VA = "0x12FDD3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x12FDD40", Offset = "0x12FDD40", VA = "0x12FDD40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x12FDDC8", Offset = "0x12FDDC8", VA = "0x12FDDC8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class <FadeTo>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float styleValueMultiplier;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <timer>5__2;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <brightness>5__3;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <contrast>5__4;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <saturation>5__5;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color <edgeCol>5__6;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float <blend>5__7;

		[Token(Token = "0x17000052")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x12FE000", Offset = "0x12FE000", VA = "0x12FE000", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x12FE048", Offset = "0x12FE048", VA = "0x12FE048", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x12FDBB8", Offset = "0x12FDBB8", VA = "0x12FDBB8")]
		[DebuggerHidden]
		public <FadeTo>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x12FDE10", Offset = "0x12FDE10", VA = "0x12FDE10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x12FDE14", Offset = "0x12FDE14", VA = "0x12FDE14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x12FE008", Offset = "0x12FE008", VA = "0x12FE008", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000383")]
	private const float FadeDuration = 0.2f;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRInput.Controller _controllerHand;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private OVRPassthroughLayer _passthroughLayer;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform _colorWheel;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Texture2D _colorTexture;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Texture2D _colorLutTexture;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private CanvasGroup _mainCanvas;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject[] _compactObjects;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject[] _objectsToHideForColorPassthrough;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 _cursorPosition;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool _settingColor;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Color _savedColor;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float _savedBrightness;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float _savedContrast;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float _savedSaturation;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private OVRPassthroughLayer.ColorMapEditorType _currentStyle;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _savedBlend;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private OVRPassthroughColorLut _passthroughColorLut;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private IEnumerator _fade;

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x12FCFD8", Offset = "0x12FCFD8", VA = "0x12FCFD8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x12FD384", Offset = "0x12FD384", VA = "0x12FD384")]
	private void Update()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x12FD724", Offset = "0x12FD724", VA = "0x12FD724")]
	public void OnBrightnessChanged(float newValue)
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x12FD754", Offset = "0x12FD754", VA = "0x12FD754")]
	public void OnContrastChanged(float newValue)
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x12FD75C", Offset = "0x12FD75C", VA = "0x12FD75C")]
	public void OnSaturationChanged(float newValue)
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x12FD764", Offset = "0x12FD764", VA = "0x12FD764")]
	public void OnAlphaChanged(float newValue)
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x12FD798", Offset = "0x12FD798", VA = "0x12FD798")]
	public void OnBlendChange(float newValue)
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x12FD7C0", Offset = "0x12FD7C0", VA = "0x12FD7C0")]
	public void DoColorDrag(bool doDrag)
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x12FD7CC", Offset = "0x12FD7CC", VA = "0x12FD7CC")]
	public void SetPassthroughStyleToColorAdjustment(bool isOn)
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x12FD81C", Offset = "0x12FD81C", VA = "0x12FD81C")]
	public void SetPassthroughStyleToColorLut(bool isOn)
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x12FD82C", Offset = "0x12FD82C", VA = "0x12FD82C")]
	private void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x12FD98C", Offset = "0x12FD98C", VA = "0x12FD98C")]
	private void Release()
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x12FD908", Offset = "0x12FD908", VA = "0x12FD908")]
	[IteratorStateMachine(typeof(<FadeToCurrentStyle>d__31))]
	private IEnumerator FadeToCurrentStyle(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x12FDA5C", Offset = "0x12FDA5C", VA = "0x12FDA5C")]
	[IteratorStateMachine(typeof(<FadeToDefaultPassthrough>d__32))]
	private IEnumerator FadeToDefaultPassthrough(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x12FDB30", Offset = "0x12FDB30", VA = "0x12FDB30")]
	[IteratorStateMachine(typeof(<FadeTo>d__33))]
	private IEnumerator FadeTo(float styleValueMultiplier, float duration)
	{
		return null;
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x12FD72C", Offset = "0x12FD72C", VA = "0x12FD72C")]
	private void UpdateBrighnessContrastSaturation()
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x12FD31C", Offset = "0x12FD31C", VA = "0x12FD31C")]
	private void ShowFullMenu(bool doShow)
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x12FDBE0", Offset = "0x12FDBE0", VA = "0x12FDBE0")]
	private void Cursor(Vector3 cP)
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x12FD39C", Offset = "0x12FD39C", VA = "0x12FD39C")]
	private void GetColorFromWheel()
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x12FD7E0", Offset = "0x12FD7E0", VA = "0x12FD7E0")]
	private void SetPassthroughStyle(OVRPassthroughLayer.ColorMapEditorType passthroughStyle)
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x12FDBEC", Offset = "0x12FDBEC", VA = "0x12FDBEC")]
	public PassthroughStyler()
	{
	}
}
[Token(Token = "0x20000CC")]
public class PassthroughSurface : MonoBehaviour
{
	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x12FE050", Offset = "0x12FE050", VA = "0x12FE050")]
	private void Start()
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x12FE104", Offset = "0x12FE104", VA = "0x12FE104")]
	public PassthroughSurface()
	{
	}
}
[Token(Token = "0x20000CD")]
public class SceneSampler : MonoBehaviour
{
	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentSceneIndex;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject displayText;

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x12FE10C", Offset = "0x12FE10C", VA = "0x12FE10C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x12FE178", Offset = "0x12FE178", VA = "0x12FE178")]
	private void Update()
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x12FE46C", Offset = "0x12FE46C", VA = "0x12FE46C")]
	public SceneSampler()
	{
	}
}
[Token(Token = "0x20000CE")]
public class SelectivePassthroughExperience : MonoBehaviour
{
	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject leftMaskObject;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rightMaskObject;

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x12FE474", Offset = "0x12FE474", VA = "0x12FE474")]
	private void Update()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x12FE8C8", Offset = "0x12FE8C8", VA = "0x12FE8C8")]
	public SelectivePassthroughExperience()
	{
	}
}
[Token(Token = "0x20000CF")]
public class SPPquad : MonoBehaviour
{
	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRInput.Controller controllerHand;

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x12FE8D0", Offset = "0x12FE8D0", VA = "0x12FE8D0")]
	private void Start()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x12FEB38", Offset = "0x12FEB38", VA = "0x12FEB38")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x12FEB84", Offset = "0x12FEB84", VA = "0x12FEB84")]
	public void Release()
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x12FEBC4", Offset = "0x12FEBC4", VA = "0x12FEBC4")]
	public SPPquad()
	{
	}
}
[Token(Token = "0x20000D0")]
public class BouncingBallLogic : MonoBehaviour
{
	[Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private sealed class <PlayPopCallback>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float clipLength;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BouncingBallLogic <>4__this;

		[Token(Token = "0x17000054")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x12FF2E0", Offset = "0x12FF2E0", VA = "0x12FF2E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x12FF328", Offset = "0x12FF328", VA = "0x12FF328", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x12FF1A8", Offset = "0x12FF1A8", VA = "0x12FF1A8")]
		[DebuggerHidden]
		public <PlayPopCallback>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x12FF1E8", Offset = "0x12FF1E8", VA = "0x12FF1E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x12FF1EC", Offset = "0x12FF1EC", VA = "0x12FF1EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x12FF2E8", Offset = "0x12FF2E8", VA = "0x12FF2E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float TTL;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip pop;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip bounce;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClip loadball;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Material visibleMat;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Material hiddenMat;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioSource audioSource;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform centerEyeCamera;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool isVisible;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float timer;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isReleased;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool isReadyForDestroy;

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x12FEBCC", Offset = "0x12FEBCC", VA = "0x12FEBCC")]
	private void OnCollisionEnter()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x12FEBF0", Offset = "0x12FEBF0", VA = "0x12FEBF0")]
	private void Start()
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x12FECF8", Offset = "0x12FECF8", VA = "0x12FECF8")]
	private void Update()
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x12FED9C", Offset = "0x12FED9C", VA = "0x12FED9C")]
	private void UpdateVisibility()
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x12FEFF0", Offset = "0x12FEFF0", VA = "0x12FEFF0")]
	private void SetVisible(bool setVisible)
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x12FF094", Offset = "0x12FF094", VA = "0x12FF094")]
	public void Release(Vector3 pos, Vector3 vel, Vector3 angVel)
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x12FEF6C", Offset = "0x12FEF6C", VA = "0x12FEF6C")]
	[IteratorStateMachine(typeof(<PlayPopCallback>d__18))]
	private IEnumerator PlayPopCallback(float clipLength)
	{
		return null;
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x12FF1D0", Offset = "0x12FF1D0", VA = "0x12FF1D0")]
	public BouncingBallLogic()
	{
	}
}
[Token(Token = "0x20000D2")]
public class BouncingBallMgr : MonoBehaviour
{
	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform trackingspace;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject rightControllerPivot;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private OVRInput.RawButton actionBtn;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject ball;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject currentBall;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool ballGrabbed;

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x12FF330", Offset = "0x12FF330", VA = "0x12FF330")]
	private void Update()
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x12FF640", Offset = "0x12FF640", VA = "0x12FF640")]
	public BouncingBallMgr()
	{
	}
}
[Token(Token = "0x20000D3")]
[RequireComponent(typeof(OVRSceneAnchor))]
[DefaultExecutionOrder(30)]
public class FurnitureSpawner : MonoBehaviour
{
	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Add a point at ceiling.")]
	public GameObject RoomLightPrefab;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Spawnable> SpawnablePrefabs;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRSceneAnchor _sceneAnchor;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private OVRSemanticClassification _classification;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameObject _roomLightRef;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _frameCounter;

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x12FF648", Offset = "0x12FF648", VA = "0x12FF648")]
	private void Start()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x12FF860", Offset = "0x12FF860", VA = "0x12FF860")]
	private void SpawnSpawnable()
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x12FFCD0", Offset = "0x12FFCD0", VA = "0x12FFCD0")]
	private bool FindValidSpawnable(out Spawnable currentSpawnable)
	{
		return default(bool);
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x12FF6E8", Offset = "0x12FF6E8", VA = "0x12FF6E8")]
	private void AddRoomLight()
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x12FFEF0", Offset = "0x12FFEF0", VA = "0x12FFEF0")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x13003DC", Offset = "0x13003DC", VA = "0x13003DC")]
	public FurnitureSpawner()
	{
	}
}
[Token(Token = "0x20000D4")]
public class MyCustomSceneModelLoader : OVRSceneModelLoader
{
	[Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private sealed class <DelayedLoad>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MyCustomSceneModelLoader <>4__this;

		[Token(Token = "0x17000056")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x1300610", Offset = "0x1300610", VA = "0x1300610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x1300658", Offset = "0x1300658", VA = "0x1300658", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1300458", Offset = "0x1300458", VA = "0x1300458")]
		[DebuggerHidden]
		public <DelayedLoad>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1300510", Offset = "0x1300510", VA = "0x1300510", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1300514", Offset = "0x1300514", VA = "0x1300514", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1300618", Offset = "0x1300618", VA = "0x1300618", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x13003E4", Offset = "0x13003E4", VA = "0x13003E4")]
	[IteratorStateMachine(typeof(<DelayedLoad>d__0))]
	private IEnumerator DelayedLoad()
	{
		return null;
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x1300480", Offset = "0x1300480", VA = "0x1300480", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x13004A0", Offset = "0x13004A0", VA = "0x13004A0", Slot = "6")]
	protected override void OnNoSceneModelToLoad()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x1300508", Offset = "0x1300508", VA = "0x1300508")]
	public MyCustomSceneModelLoader()
	{
	}
}
[Token(Token = "0x20000D6")]
[RequireComponent(typeof(OVRManager))]
public class PassthroughPlayInEditor : MonoBehaviour
{
	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x1300660", Offset = "0x1300660", VA = "0x1300660")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x1300664", Offset = "0x1300664", VA = "0x1300664")]
	public PassthroughPlayInEditor()
	{
	}
}
[Token(Token = "0x20000D7")]
public class RequestCaptureFlow : MonoBehaviour
{
	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Button RequestCaptureBtn;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRSceneManager _sceneManager;

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x130066C", Offset = "0x130066C", VA = "0x130066C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x13006E4", Offset = "0x13006E4", VA = "0x13006E4")]
	private void Update()
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x1300768", Offset = "0x1300768", VA = "0x1300768")]
	public RequestCaptureFlow()
	{
	}
}
[Token(Token = "0x20000D8")]
[ExecuteInEditMode]
public class SimpleResizable : MonoBehaviour
{
	[Token(Token = "0x20000D9")]
	public enum Method
	{
		[Token(Token = "0x40003E2")]
		Adapt,
		[Token(Token = "0x40003E3")]
		AdaptWithAsymmetricalPadding,
		[Token(Token = "0x40003E4")]
		Scale,
		[Token(Token = "0x40003E5")]
		None
	}

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(15f)]
	public Method ScalingX;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 0.5f)]
	public float PaddingX;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(-0.5f, 0f)]
	public float PaddingXMax;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space(15f)]
	public Method ScalingY;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 0.5f)]
	public float PaddingY;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(-0.5f, 0f)]
	public float PaddingYMax;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space(15f)]
	public Method ScalingZ;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0f, 0.5f)]
	public float PaddingZ;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(-0.5f, 0f)]
	public float PaddingZMax;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Bounds _bounds;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform _pivotTransform;

	[Token(Token = "0x17000058")]
	public Vector3 PivotPosition
	{
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1300778", Offset = "0x1300778", VA = "0x1300778")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000059")]
	public Vector3 NewSize
	{
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1300794", Offset = "0x1300794", VA = "0x1300794")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x13007A0", Offset = "0x13007A0", VA = "0x13007A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700005A")]
	public Vector3 DefaultSize
	{
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x13007AC", Offset = "0x13007AC", VA = "0x13007AC")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x13007B8", Offset = "0x13007B8", VA = "0x13007B8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700005B")]
	public Mesh Mesh
	{
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x13007C4", Offset = "0x13007C4", VA = "0x13007C4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x13007CC", Offset = "0x13007CC", VA = "0x13007CC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x13007D4", Offset = "0x13007D4", VA = "0x13007D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x1300910", Offset = "0x1300910", VA = "0x1300910")]
	public SimpleResizable()
	{
	}
}
[Token(Token = "0x20000DA")]
public class SimpleResizer
{
	[Token(Token = "0x6000402")]
	[Address(RVA = "0x1300048", Offset = "0x1300048", VA = "0x1300048")]
	public void CreateResizedObject(Vector3 newSize, GameObject parent, SimpleResizable sourcePrefab)
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x1300918", Offset = "0x1300918", VA = "0x1300918")]
	private Mesh ProcessVertices(SimpleResizable resizable, Vector3 newSize)
	{
		return null;
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x1300B9C", Offset = "0x1300B9C", VA = "0x1300B9C")]
	private float CalculateNewVertexPosition(SimpleResizable.Method resizeMethod, float currentPosition, float currentSize, float newSize, float padding, float paddingMax, float pivot)
	{
		return default(float);
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x1300040", Offset = "0x1300040", VA = "0x1300040")]
	public SimpleResizer()
	{
	}
}
[Serializable]
[Token(Token = "0x20000DB")]
public class Spawnable : ISerializationCallbackReceiver
{
	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public SimpleResizable ResizablePrefab;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ClassificationLabel;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _editorClassificationIndex;

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x1300C44", Offset = "0x1300C44", VA = "0x1300C44", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x1300C48", Offset = "0x1300C48", VA = "0x1300C48", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x13010B0", Offset = "0x13010B0", VA = "0x13010B0")]
	public Spawnable()
	{
	}
}
[Token(Token = "0x20000DC")]
[RequireComponent(typeof(OVRSceneAnchor))]
public class VolumeAndPlaneSwitcher : MonoBehaviour
{
	[Token(Token = "0x20000DD")]
	public enum GeometryType
	{
		[Token(Token = "0x40003ED")]
		Plane,
		[Token(Token = "0x40003EE")]
		Volume
	}

	[Serializable]
	[Token(Token = "0x20000DE")]
	public struct LabelGeometryPair
	{
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string label;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public GeometryType desiredGeometryType;
	}

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSceneAnchor planePrefab;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRSceneAnchor volumePrefab;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<LabelGeometryPair> desiredSwitches;

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x1301108", Offset = "0x1301108", VA = "0x1301108")]
	private void ReplaceAnchor(OVRSceneAnchor prefab, Vector3 position, Quaternion rotation, Vector3 localScale)
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x1301534", Offset = "0x1301534", VA = "0x1301534")]
	private void Start()
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x1301E6C", Offset = "0x1301E6C", VA = "0x1301E6C")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x1301D44", Offset = "0x1301D44", VA = "0x1301D44")]
	private void GetTopPlaneFromVolume(Transform volume, Vector3 dimensions, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x1301EEC", Offset = "0x1301EEC", VA = "0x1301EEC")]
	public VolumeAndPlaneSwitcher()
	{
	}
}
[Token(Token = "0x20000DF")]
[RequireComponent(typeof(OVRSpatialAnchor))]
public class Anchor : MonoBehaviour
{
	[Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class <Start>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Anchor <>4__this;

		[Token(Token = "0x1700005D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x1302DE4", Offset = "0x1302DE4", VA = "0x1302DE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x1302E2C", Offset = "0x1302E2C", VA = "0x1302E2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1302248", Offset = "0x1302248", VA = "0x1302248")]
		[DebuggerHidden]
		public <Start>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1302C98", Offset = "0x1302C98", VA = "0x1302C98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1302C9C", Offset = "0x1302C9C", VA = "0x1302C9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1302DEC", Offset = "0x1302DEC", VA = "0x1302DEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003F1")]
	public const string NumUuidsPlayerPref = "numUuids";

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("canvas_")]
	[SerializeField]
	private Canvas _canvas;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("pivot_")]
	[SerializeField]
	private Transform _pivot;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("anchorMenu_")]
	[SerializeField]
	private GameObject _anchorMenu;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _isSelected;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool _isHovered;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[FormerlySerializedAs("anchorName_")]
	private TextMeshProUGUI _anchorName;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("saveIcon_")]
	private GameObject _saveIcon;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	[FormerlySerializedAs("labelImage_")]
	private Image _labelImage;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	[FormerlySerializedAs("labelBaseColor_")]
	private Color _labelBaseColor;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[FormerlySerializedAs("labelHighlightColor_")]
	private Color _labelHighlightColor;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	[FormerlySerializedAs("labelSelectedColor_")]
	private Color _labelSelectedColor;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	[FormerlySerializedAs("uiManager_")]
	private AnchorUIManager _uiManager;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	[FormerlySerializedAs("renderers_")]
	private MeshRenderer[] _renderers;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int _menuIndex;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	[FormerlySerializedAs("buttonList_")]
	private List<Button> _buttonList;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Button _selectedButton;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private OVRSpatialAnchor _spatialAnchor;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameObject _icon;

	[Token(Token = "0x1700005C")]
	public bool ShowSaveIcon
	{
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x13027DC", Offset = "0x13027DC", VA = "0x13027DC")]
		set
		{
		}
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x1301EF4", Offset = "0x1301EF4", VA = "0x1301EF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x1302074", Offset = "0x1302074", VA = "0x1302074")]
	private static string ConvertUuidToString(Guid guid)
	{
		return null;
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x13021D4", Offset = "0x13021D4", VA = "0x13021D4")]
	[IteratorStateMachine(typeof(<Start>d__21))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x1302270", Offset = "0x1302270", VA = "0x1302270")]
	private void Update()
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x13024E8", Offset = "0x13024E8", VA = "0x13024E8")]
	public void OnSaveLocalButtonPressed()
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x13025B8", Offset = "0x13025B8", VA = "0x13025B8")]
	private void SaveUuidToPlayerPrefs(Guid uuid)
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x13026A0", Offset = "0x13026A0", VA = "0x13026A0")]
	public void OnHideButtonPressed()
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x130270C", Offset = "0x130270C", VA = "0x130270C")]
	public void OnEraseButtonPressed()
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x13027FC", Offset = "0x13027FC", VA = "0x13027FC")]
	public void OnHoverStart()
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x1302918", Offset = "0x1302918", VA = "0x1302918")]
	public void OnHoverEnd()
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x1302A20", Offset = "0x1302A20", VA = "0x1302A20")]
	public void OnSelect()
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x13022C0", Offset = "0x13022C0", VA = "0x13022C0")]
	private void BillboardPanel(Transform panel)
	{
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x13023F4", Offset = "0x13023F4", VA = "0x13023F4")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x1302AF0", Offset = "0x1302AF0", VA = "0x1302AF0")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x1302C28", Offset = "0x1302C28", VA = "0x1302C28")]
	public Anchor()
	{
	}
}
[Token(Token = "0x20000E1")]
[RequireComponent(typeof(SpatialAnchorLoader))]
public class AnchorUIManager : MonoBehaviour
{
	[Token(Token = "0x20000E2")]
	public enum AnchorMode
	{
		[Token(Token = "0x400041A")]
		Create,
		[Token(Token = "0x400041B")]
		Select
	}

	[Token(Token = "0x20000E3")]
	private delegate void PrimaryPressDelegate();

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorUIManager Instance;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[FormerlySerializedAs("createModeButton_")]
	private GameObject _createModeButton;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("selectModeButton_")]
	private GameObject _selectModeButton;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("trackedDevice_")]
	private Transform _trackedDevice;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _raycastOrigin;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _drawRaycast;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("lineRenderer_")]
	[SerializeField]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Anchor _hoveredAnchor;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Anchor _selectedAnchor;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AnchorMode _mode;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[FormerlySerializedAs("buttonList_")]
	[SerializeField]
	private List<Button> _buttonList;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int _menuIndex;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Button _selectedButton;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Anchor _anchorPrefab;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[FormerlySerializedAs("placementPreview_")]
	[SerializeField]
	private GameObject _placementPreview;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[FormerlySerializedAs("anchorPlacementTransform_")]
	[SerializeField]
	private Transform _anchorPlacementTransform;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private PrimaryPressDelegate _primaryPressDelegate;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool _isFocused;

	[Token(Token = "0x1700005F")]
	public Anchor AnchorPrefab
	{
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1302E34", Offset = "0x1302E34", VA = "0x1302E34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x1302E3C", Offset = "0x1302E3C", VA = "0x1302E3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x1302F08", Offset = "0x1302F08", VA = "0x1302F08")]
	private void Start()
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x1303058", Offset = "0x1303058", VA = "0x1303058")]
	private void Update()
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x13034C8", Offset = "0x13034C8", VA = "0x13034C8")]
	public void OnCreateModeButtonPressed()
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x1303534", Offset = "0x1303534", VA = "0x1303534")]
	public void OnLoadAnchorsButtonPressed()
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x1302FF0", Offset = "0x1302FF0", VA = "0x1302FF0")]
	private void ToggleCreateMode()
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x13037B4", Offset = "0x13037B4", VA = "0x13037B4")]
	private void StartPlacementMode()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x130383C", Offset = "0x130383C", VA = "0x130383C")]
	private void EndPlacementMode()
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x130385C", Offset = "0x130385C", VA = "0x130385C")]
	private void StartSelectMode()
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x1303794", Offset = "0x1303794", VA = "0x1303794")]
	private void EndSelectMode()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x13033D4", Offset = "0x13033D4", VA = "0x13033D4")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x1303A5C", Offset = "0x1303A5C", VA = "0x1303A5C")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x13038E4", Offset = "0x13038E4", VA = "0x13038E4")]
	private void ShowAnchorPreview()
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x13039D0", Offset = "0x13039D0", VA = "0x13039D0")]
	private void HideAnchorPreview()
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x1303B5C", Offset = "0x1303B5C", VA = "0x1303B5C")]
	private void PlaceAnchor()
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x13039F0", Offset = "0x13039F0", VA = "0x13039F0")]
	private void ShowRaycastLine()
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x1303A28", Offset = "0x1303A28", VA = "0x1303A28")]
	private void HideRaycastLine()
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x1303158", Offset = "0x1303158", VA = "0x1303158")]
	private void ControllerRaycast()
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x1303C48", Offset = "0x1303C48", VA = "0x1303C48")]
	private void HoverAnchor(Anchor anchor)
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x1303C70", Offset = "0x1303C70", VA = "0x1303C70")]
	private void UnhoverAnchor()
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x1303D00", Offset = "0x1303D00", VA = "0x1303D00")]
	private void SelectAnchor()
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x1303E48", Offset = "0x1303E48", VA = "0x1303E48")]
	public AnchorUIManager()
	{
	}
}
[Token(Token = "0x20000E4")]
public class SpatialAnchorLoader : MonoBehaviour
{
	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRSpatialAnchor _anchorPrefab;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Action<OVRSpatialAnchor.UnboundAnchor, bool> _onLoadAnchor;

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x1303588", Offset = "0x1303588", VA = "0x1303588")]
	public void LoadAnchorsByUuid()
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x1304004", Offset = "0x1304004", VA = "0x1304004")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x1303F24", Offset = "0x1303F24", VA = "0x1303F24")]
	private void Load(OVRSpatialAnchor.LoadOptions options)
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x1304088", Offset = "0x1304088", VA = "0x1304088")]
	private void OnLocalized(OVRSpatialAnchor.UnboundAnchor unboundAnchor, bool success)
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x1303E98", Offset = "0x1303E98", VA = "0x1303E98")]
	private static void Log(string message)
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x1304238", Offset = "0x1304238", VA = "0x1304238")]
	public SpatialAnchorLoader()
	{
	}
}
[Token(Token = "0x20000E5")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x1304370", Offset = "0x1304370", VA = "0x1304370")]
	private void Start()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x1304584", Offset = "0x1304584", VA = "0x1304584")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x1304688", Offset = "0x1304688", VA = "0x1304688")]
	public StartMenu()
	{
	}
}
[Token(Token = "0x20000E7")]
public class LocalizedHaptics : MonoBehaviour
{
	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Header("Settings")]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x13046AC", Offset = "0x13046AC", VA = "0x13046AC")]
	private void Start()
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x13046D4", Offset = "0x13046D4", VA = "0x13046D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x1304810", Offset = "0x1304810", VA = "0x1304810")]
	public LocalizedHaptics()
	{
	}
}
[Token(Token = "0x20000E8")]
public class SceneSettings : MonoBehaviour
{
	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Header("Time")]
	private float m_fixedTimeStep;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Header("Physics")]
	private float m_gravityScalar;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_defaultContactOffset;

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x1304820", Offset = "0x1304820", VA = "0x1304820")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x13048B8", Offset = "0x13048B8", VA = "0x13048B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x13048C0", Offset = "0x13048C0", VA = "0x13048C0")]
	private static void CollidersSetContactOffset(float contactOffset)
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x1304984", Offset = "0x1304984", VA = "0x1304984")]
	public SceneSettings()
	{
	}
}
[Token(Token = "0x20000E9")]
public class StylusTip : MonoBehaviour
{
	[Token(Token = "0x4000428")]
	private const int MaxBreadCrumbs = 60;

	[Token(Token = "0x4000429")]
	private const float BreadCrumbMinSize = 0.005f;

	[Token(Token = "0x400042A")]
	private const float BreadCrumbMaxSize = 0.02f;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Header("External")]
	private Transform m_trackingSpace;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Header("Settings")]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject m_breadCrumbPf;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject m_breadCrumbContainer;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject[] m_breadCrumbs;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int m_breadCrumbIndexPrev;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int m_breadCrumbIndexCurr;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x13049A4", Offset = "0x13049A4", VA = "0x13049A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x1304C24", Offset = "0x1304C24", VA = "0x1304C24")]
	private void Update()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x1305054", Offset = "0x1305054", VA = "0x1305054")]
	private static Pose GetT_Device_StylusTip(OVRInput.Controller controller)
	{
		return default(Pose);
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x1305180", Offset = "0x1305180", VA = "0x1305180")]
	public StylusTip()
	{
	}
}
[Token(Token = "0x20000EA")]
public class UiAxis1dInspector : MonoBehaviour
{
	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Settings")]
	[SerializeField]
	private float m_minExtent;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_maxExtent;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Components")]
	[SerializeField]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Slider m_slider;

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x1305198", Offset = "0x1305198", VA = "0x1305198")]
	public void SetExtents(float minExtent, float maxExtent)
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x13051A0", Offset = "0x13051A0", VA = "0x13051A0")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x13051C4", Offset = "0x13051C4", VA = "0x13051C4")]
	public void SetValue(float value)
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x13052C8", Offset = "0x13052C8", VA = "0x13052C8")]
	public UiAxis1dInspector()
	{
	}
}
[Token(Token = "0x20000EB")]
public class UiAxis2dInspector : MonoBehaviour
{
	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Settings")]
	[SerializeField]
	private Vector2 m_xExtent;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2 m_yExtent;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Header("Components")]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image m_handle;

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x13052D8", Offset = "0x13052D8", VA = "0x13052D8")]
	public void SetExtents(Vector2 xExtent, Vector2 yExtent)
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x13052E4", Offset = "0x13052E4", VA = "0x13052E4")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x1305308", Offset = "0x1305308", VA = "0x1305308")]
	public void SetValue(bool isTouching, Vector2 value)
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x13056D0", Offset = "0x13056D0", VA = "0x13056D0")]
	public UiAxis2dInspector()
	{
	}
}
[Token(Token = "0x20000EC")]
public class UiBoolInspector : MonoBehaviour
{
	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Header("Components")]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Toggle m_toggle;

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x13056E4", Offset = "0x13056E4", VA = "0x13056E4")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x1305708", Offset = "0x1305708", VA = "0x1305708")]
	public void SetValue(bool value)
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x1305728", Offset = "0x1305728", VA = "0x1305728")]
	public UiBoolInspector()
	{
	}
}
[Token(Token = "0x20000ED")]
public class UiDeviceInspector : MonoBehaviour
{
	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Settings")]
	[SerializeField]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Left Column Components")]
	[SerializeField]
	private TextMeshProUGUI m_title;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI m_status;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UiBoolInspector m_thumbRestTouch;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UiAxis1dInspector m_thumbRestForce;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UiAxis1dInspector m_indexTrigger;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UiAxis1dInspector m_gripTrigger;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UiAxis1dInspector m_stylusTipForce;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private UiAxis1dInspector m_indexCurl1d;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UiAxis1dInspector m_indexSlider1d;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Header("Right Column Components")]
	[SerializeField]
	private UiBoolInspector m_ax;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UiBoolInspector m_axTouch;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UiBoolInspector m_by;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UiBoolInspector m_byTouch;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UiBoolInspector m_indexTouch;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UiAxis2dInspector m_thumbstick;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x1305730", Offset = "0x1305730", VA = "0x1305730")]
	private void Start()
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x1305758", Offset = "0x1305758", VA = "0x1305758")]
	private void Update()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x1305CE0", Offset = "0x1305CE0", VA = "0x1305CE0")]
	private static string ToDeviceModel()
	{
		return null;
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x1305D20", Offset = "0x1305D20", VA = "0x1305D20")]
	private static string ToHandednessString(OVRInput.Handedness handedness)
	{
		return null;
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x1305DA4", Offset = "0x1305DA4", VA = "0x1305DA4")]
	public UiDeviceInspector()
	{
	}
}
[Token(Token = "0x20000EE")]
public class UiSceneMenu : MonoBehaviour
{
	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Header("Settings")]
	private VerticalLayoutGroup m_layoutGroup;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI m_labelPf;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector2 s_lastThumbstickL;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Vector2 s_lastThumbstickR;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Scene m_activeScene;

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x1305DB4", Offset = "0x1305DB4", VA = "0x1305DB4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x1306080", Offset = "0x1306080", VA = "0x1306080")]
	private void Update()
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x1306198", Offset = "0x1306198", VA = "0x1306198")]
	private bool InputPrevScene()
	{
		return default(bool);
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x1306234", Offset = "0x1306234", VA = "0x1306234")]
	private bool InputNextScene()
	{
		return default(bool);
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x1306278", Offset = "0x1306278", VA = "0x1306278")]
	private bool KeyboardPrevScene()
	{
		return default(bool);
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x1306314", Offset = "0x1306314", VA = "0x1306314")]
	private bool KeyboardNextScene()
	{
		return default(bool);
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x1306284", Offset = "0x1306284", VA = "0x1306284")]
	private bool ThumbstickPrevScene(OVRInput.Controller controller)
	{
		return default(bool);
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x1306320", Offset = "0x1306320", VA = "0x1306320")]
	private bool ThumbstickNextScene(OVRInput.Controller controller)
	{
		return default(bool);
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x13063B0", Offset = "0x13063B0", VA = "0x13063B0")]
	private Vector2 GetLastThumbstickValue(OVRInput.Controller controller)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x13061DC", Offset = "0x13061DC", VA = "0x13061DC")]
	private void ChangeScene(int nextScene)
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x1305E58", Offset = "0x1305E58", VA = "0x1305E58")]
	private void CreateLabel(int sceneIndex, string scenePath)
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x1306418", Offset = "0x1306418", VA = "0x1306418")]
	public UiSceneMenu()
	{
	}
}
[Token(Token = "0x20000EF")]
public class UiVectorInspector : MonoBehaviour
{
	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Header("Components")]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x1306420", Offset = "0x1306420", VA = "0x1306420")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x1306444", Offset = "0x1306444", VA = "0x1306444")]
	public void SetValue(bool value)
	{
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x13064F4", Offset = "0x13064F4", VA = "0x13064F4")]
	public UiVectorInspector()
	{
	}
}
[Token(Token = "0x20000F0")]
public class OpenURL : MonoBehaviour
{
	[Token(Token = "0x6000478")]
	[Address(RVA = "0x13064FC", Offset = "0x13064FC", VA = "0x13064FC")]
	public void OpenUrl(string link)
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x1306508", Offset = "0x1306508", VA = "0x1306508")]
	public OpenURL()
	{
	}
}
[Token(Token = "0x20000F1")]
public class Button1 : MonoBehaviour
{
	[Token(Token = "0x20000F2")]
	public enum PushType
	{
		[Token(Token = "0x400045F")]
		position,
		[Token(Token = "0x4000460")]
		rotation
	}

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PushType pushType;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 startPos;

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 pushedVector;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<GameObject> objectsToInteract;

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<IButton> interafacesToInteract;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool pushed;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool active;

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x1306510", Offset = "0x1306510", VA = "0x1306510")]
	protected void Awake()
	{
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x130675C", Offset = "0x130675C", VA = "0x130675C")]
	public void Activate(bool value)
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x1306768", Offset = "0x1306768", VA = "0x1306768")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x1306B50", Offset = "0x1306B50", VA = "0x1306B50")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x130655C", Offset = "0x130655C", VA = "0x130655C")]
	private void InitializeInterfaces()
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x13067EC", Offset = "0x13067EC", VA = "0x13067EC")]
	public void Push()
	{
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x1306BCC", Offset = "0x1306BCC", VA = "0x1306BCC")]
	public Button1()
	{
	}
}
[Token(Token = "0x20000F3")]
public class CheckPosition : VRTK_InteractableObject
{
	[Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class <Transform>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CheckPosition <>4__this;

		[Token(Token = "0x17000060")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x1306F54", Offset = "0x1306F54", VA = "0x1306F54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x1306F9C", Offset = "0x1306F9C", VA = "0x1306F9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1306E68", Offset = "0x1306E68", VA = "0x1306E68")]
		[DebuggerHidden]
		public <Transform>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1306E98", Offset = "0x1306E98", VA = "0x1306E98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1306E9C", Offset = "0x1306E9C", VA = "0x1306E9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1306F5C", Offset = "0x1306F5C", VA = "0x1306F5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public GameObject parent;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[SerializeField]
	private Wheels_Controller wheels_Controller;

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x1306C5C", Offset = "0x1306C5C", VA = "0x1306C5C", Slot = "27")]
	public override void Grabbed(VRTK_InteractGrab currentGrabbingObject)
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x1306DC8", Offset = "0x1306DC8", VA = "0x1306DC8", Slot = "29")]
	public override void Ungrabbed(VRTK_InteractGrab currentGrabbingObject)
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x1306D18", Offset = "0x1306D18", VA = "0x1306D18")]
	[IteratorStateMachine(typeof(<Transform>d__4))]
	private IEnumerator Transform()
	{
		return null;
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x1306E90", Offset = "0x1306E90", VA = "0x1306E90")]
	public CheckPosition()
	{
	}
}
[Token(Token = "0x20000F5")]
public class ComputerMouse : VRTK_InteractableObject
{
	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[Header("ComputerMouse fields")]
	public ComputerMouseCursor myMouse;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public AudioSource audioSource;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public VRTK_UIPointer uiPointer;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private VRTK_VRInputModule inputModule;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private Collider mouseCollider;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private PhysicMaterial frictionMaterial;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private PhysicMaterial noFrictionMaterial;

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x1306FA4", Offset = "0x1306FA4", VA = "0x1306FA4", Slot = "66")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x130714C", Offset = "0x130714C", VA = "0x130714C", Slot = "30")]
	public override void StartUsing([Optional] VRTK_InteractUse currentUsingObject)
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x1307198", Offset = "0x1307198", VA = "0x1307198", Slot = "31")]
	public override void StopUsing([Optional] VRTK_InteractUse previousUsingObject, bool resetUsingObjectState = true)
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x13071C4", Offset = "0x13071C4", VA = "0x13071C4", Slot = "27")]
	public override void Grabbed([Optional] VRTK_InteractGrab currentGrabbingObject)
	{
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x1307568", Offset = "0x1307568", VA = "0x1307568", Slot = "29")]
	public override void Ungrabbed([Optional] VRTK_InteractGrab previousGrabbingObject)
	{
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x130734C", Offset = "0x130734C", VA = "0x130734C")]
	private void TogglePointerOnGrabbingHand(bool grabbing, VRTK_InteractGrab handInteractGrab)
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x1307010", Offset = "0x1307010", VA = "0x1307010")]
	private void InitializeFrictionMaterials()
	{
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x13076D0", Offset = "0x13076D0", VA = "0x13076D0")]
	public ComputerMouse()
	{
	}
}
[Token(Token = "0x20000F6")]
public class DeviceWithHapticAndSoundWhenUse : VRTK_InteractHaptics
{
	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public AudioSource audioSource;

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x13076D8", Offset = "0x13076D8", VA = "0x13076D8", Slot = "12")]
	public override void OnInteractHapticsUsed(InteractHapticsEventArgs e)
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x1307700", Offset = "0x1307700", VA = "0x1307700", Slot = "13")]
	public override void CancelHaptics(VRTK_ControllerReference controllerReference)
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x1307728", Offset = "0x1307728", VA = "0x1307728")]
	public DeviceWithHapticAndSoundWhenUse()
	{
	}
}
[Token(Token = "0x20000F7")]
public class GarageLamp : MonoBehaviour
{
	[Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class <StartEnableLight>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GarageLamp <>4__this;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <j>5__3;

		[Token(Token = "0x17000062")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x1307CB0", Offset = "0x1307CB0", VA = "0x1307CB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x1307CF8", Offset = "0x1307CF8", VA = "0x1307CF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x130797C", Offset = "0x130797C", VA = "0x130797C")]
		[DebuggerHidden]
		public <StartEnableLight>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x13079B4", Offset = "0x13079B4", VA = "0x13079B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x13079B8", Offset = "0x13079B8", VA = "0x13079B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1307CB8", Offset = "0x1307CB8", VA = "0x1307CB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEngine.Light light;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int indexOfMaterialInMeshRenderer;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material material;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color originalColor;

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x1307730", Offset = "0x1307730", VA = "0x1307730")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x1307808", Offset = "0x1307808", VA = "0x1307808")]
	public void EnableLight()
	{
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x130789C", Offset = "0x130789C", VA = "0x130789C")]
	public void DisableLight()
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x1307828", Offset = "0x1307828", VA = "0x1307828")]
	[IteratorStateMachine(typeof(<StartEnableLight>d__8))]
	private IEnumerator StartEnableLight()
	{
		return null;
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x13079A4", Offset = "0x13079A4", VA = "0x13079A4")]
	public GarageLamp()
	{
	}
}
[Token(Token = "0x20000F9")]
public class GearboxLift : MonoBehaviour
{
	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform state1;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform state2;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float actualPart;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(1f, 5f)]
	private int idx_state;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool up;

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x1307D00", Offset = "0x1307D00", VA = "0x1307D00")]
	public bool NextIdx()
	{
		return default(bool);
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x1307D38", Offset = "0x1307D38", VA = "0x1307D38")]
	public bool NextIdx(bool UP)
	{
		return default(bool);
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x1307D6C", Offset = "0x1307D6C", VA = "0x1307D6C")]
	public void ChangeDirection(bool UP)
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x1307D78", Offset = "0x1307D78", VA = "0x1307D78")]
	private Vector3 setPosition(Transform stateA, Transform stateB, float part)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x1307EA0", Offset = "0x1307EA0", VA = "0x1307EA0")]
	private Quaternion setRotation(Transform stateA, Transform stateB, float part)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x1307FFC", Offset = "0x1307FFC", VA = "0x1307FFC")]
	public void Move(float part)
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x1308194", Offset = "0x1308194", VA = "0x1308194")]
	public GearboxLift()
	{
	}
}
[Token(Token = "0x20000FA")]
public class HapticController : VRTK_InteractHaptics
{
	[Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class <IsInHand>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HapticController <>4__this;

		[Token(Token = "0x17000064")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x1308734", Offset = "0x1308734", VA = "0x1308734", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x130877C", Offset = "0x130877C", VA = "0x130877C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x13085CC", Offset = "0x13085CC", VA = "0x13085CC")]
		[DebuggerHidden]
		public <IsInHand>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x130869C", Offset = "0x130869C", VA = "0x130869C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x13086A0", Offset = "0x13086A0", VA = "0x13086A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x130873C", Offset = "0x130873C", VA = "0x130873C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class <PhoneHaptic>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HapticController <>4__this;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VRTK_ControllerReference controllerReference;

		[Token(Token = "0x17000066")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x1308994", Offset = "0x1308994", VA = "0x1308994", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x13089DC", Offset = "0x13089DC", VA = "0x13089DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x13085F4", Offset = "0x13085F4", VA = "0x13085F4")]
		[DebuggerHidden]
		public <PhoneHaptic>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1308784", Offset = "0x1308784", VA = "0x1308784", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1308788", Offset = "0x1308788", VA = "0x1308788", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x130899C", Offset = "0x130899C", VA = "0x130899C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class <PhoneHapticOnce>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HapticController <>4__this;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VRTK_ControllerReference controllerReference;

		[Token(Token = "0x17000068")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x1308B04", Offset = "0x1308B04", VA = "0x1308B04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x1308B4C", Offset = "0x1308B4C", VA = "0x1308B4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x130861C", Offset = "0x130861C", VA = "0x130861C")]
		[DebuggerHidden]
		public <PhoneHapticOnce>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x13089E4", Offset = "0x13089E4", VA = "0x13089E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x13089E8", Offset = "0x13089E8", VA = "0x13089E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1308B0C", Offset = "0x1308B0C", VA = "0x1308B0C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class <LongHaptic>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HapticController <>4__this;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VRTK_ControllerReference controllerReference;

		[Token(Token = "0x1700006A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x1308E08", Offset = "0x1308E08", VA = "0x1308E08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x1308E50", Offset = "0x1308E50", VA = "0x1308E50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1308644", Offset = "0x1308644", VA = "0x1308644")]
		[DebuggerHidden]
		public <LongHaptic>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1308B54", Offset = "0x1308B54", VA = "0x1308B54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1308B58", Offset = "0x1308B58", VA = "0x1308B58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1308E10", Offset = "0x1308E10", VA = "0x1308E10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class <ShortHaptic>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HapticController <>4__this;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VRTK_ControllerReference controllerReference;

		[Token(Token = "0x1700006C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x130912C", Offset = "0x130912C", VA = "0x130912C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x1309174", Offset = "0x1309174", VA = "0x1309174", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x130866C", Offset = "0x130866C", VA = "0x130866C")]
		[DebuggerHidden]
		public <ShortHaptic>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1308E58", Offset = "0x1308E58", VA = "0x1308E58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1308E5C", Offset = "0x1308E5C", VA = "0x1308E5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1309134", Offset = "0x1309134", VA = "0x1309134", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	public bool isInHand;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public AudioClip vibrationClip;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public AudioSource audioSource;

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x13081A8", Offset = "0x13081A8", VA = "0x13081A8", Slot = "11")]
	public override void OnInteractHapticsGrabbed(InteractHapticsEventArgs e)
	{
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x13081B4", Offset = "0x13081B4", VA = "0x13081B4", Slot = "30")]
	protected override void CancelGrabHaptics(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x13081D0", Offset = "0x13081D0", VA = "0x13081D0", Slot = "32")]
	public override void HapticInteract(HapticMode hapticMode)
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x1308318", Offset = "0x1308318", VA = "0x1308318")]
	[IteratorStateMachine(typeof(<IsInHand>d__6))]
	private IEnumerator IsInHand()
	{
		return null;
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x130838C", Offset = "0x130838C", VA = "0x130838C")]
	[IteratorStateMachine(typeof(<PhoneHaptic>d__7))]
	private IEnumerator PhoneHaptic(VRTK_ControllerReference controllerReference)
	{
		return null;
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x130853C", Offset = "0x130853C", VA = "0x130853C")]
	[IteratorStateMachine(typeof(<PhoneHapticOnce>d__8))]
	private IEnumerator PhoneHapticOnce(VRTK_ControllerReference controllerReference)
	{
		return null;
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x130841C", Offset = "0x130841C", VA = "0x130841C")]
	[IteratorStateMachine(typeof(<LongHaptic>d__9))]
	private IEnumerator LongHaptic(VRTK_ControllerReference controllerReference)
	{
		return null;
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x13084AC", Offset = "0x13084AC", VA = "0x13084AC")]
	[IteratorStateMachine(typeof(<ShortHaptic>d__10))]
	private IEnumerator ShortHaptic(VRTK_ControllerReference controllerReference)
	{
		return null;
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x1308694", Offset = "0x1308694", VA = "0x1308694")]
	public HapticController()
	{
	}
}
[Token(Token = "0x2000100")]
public interface IButton
{
	[Token(Token = "0x60004CF")]
	void ButtonStartUsing(GameObject buttonObject);

	[Token(Token = "0x60004D0")]
	void ButtonEndUsing(GameObject buttonObject);
}
[Token(Token = "0x2000101")]
public class ItemSnapper2 : MonoBehaviour
{
	[Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class <SnapControllerToGrabObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform grabbedSnapHandle;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ItemSnapper2 <>4__this;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject grabbingObject;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform placeToSnap;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRTK_AvatarHandController <avatarHandController>5__2;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform <controllerAttachPoint>5__3;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 <attachPointStartPos>5__4;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion <startingRotation>5__5;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 <startingPosition>5__6;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 <startPos>5__7;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion <startRot>5__8;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion <rotationTo>5__9;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 <positionTo>5__10;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float <t>5__11;

		[Token(Token = "0x1700006E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x1309E04", Offset = "0x1309E04", VA = "0x1309E04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x1309E4C", Offset = "0x1309E4C", VA = "0x1309E4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1309358", Offset = "0x1309358", VA = "0x1309358")]
		[DebuggerHidden]
		public <SnapControllerToGrabObject>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1309628", Offset = "0x1309628", VA = "0x1309628", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x130962C", Offset = "0x130962C", VA = "0x130962C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1309E0C", Offset = "0x1309E0C", VA = "0x1309E0C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class <ConnectionCoroutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject grabbingObject;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ItemSnapper2 <>4__this;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Quaternion rotationTo;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 positionTo;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Quaternion startingRotOffset;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 startingPosOffest;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform attachPoint;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public VRTK_AvatarHandController avatarHandController;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform <controllerTransform>5__2;

		[Token(Token = "0x17000070")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x130A338", Offset = "0x130A338", VA = "0x130A338", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x130A380", Offset = "0x130A380", VA = "0x130A380", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x13095F0", Offset = "0x13095F0", VA = "0x13095F0")]
		[DebuggerHidden]
		public <ConnectionCoroutine>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1309E54", Offset = "0x1309E54", VA = "0x1309E54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1309E58", Offset = "0x1309E58", VA = "0x1309E58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x130A340", Offset = "0x130A340", VA = "0x130A340", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Maximum distance between controller and hand position where connection doesn't break. \n0 - ignore break distance.")]
	public float breakDistance;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("Maximum angle between controller and hand where connection doesn't break. \n0 - ignore break angle.")]
	public float breakAngle;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public bool connectionEstabilished;

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public VRTK_BaseGrabAttach baseGrabAttach;

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Coroutine connectionCoroutine;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody grabbingObjectBody;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Rigidbody itemSnapperBody;

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x130917C", Offset = "0x130917C", VA = "0x130917C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x1309298", Offset = "0x1309298", VA = "0x1309298", Slot = "4")]
	[IteratorStateMachine(typeof(<SnapControllerToGrabObject>d__8))]
	public virtual IEnumerator SnapControllerToGrabObject(GameObject grabbingObject, Transform grabbedSnapHandle, Transform placeToSnap)
	{
		return null;
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x1309380", Offset = "0x1309380", VA = "0x1309380", Slot = "5")]
	public virtual void CreateConnection(GameObject grabbingObject, Transform grabbedSnapHandle, Vector3 positionTo, Quaternion rotationTo, Vector3 attachPointStartPos, Transform attachPoint, Vector3 startingPosOffest, Quaternion startingRotOffset, VRTK_AvatarHandController avatarHandController)
	{
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x13094A8", Offset = "0x13094A8", VA = "0x13094A8", Slot = "6")]
	[IteratorStateMachine(typeof(<ConnectionCoroutine>d__10))]
	public virtual IEnumerator ConnectionCoroutine(GameObject grabbingObject, Transform grabbedSnapHandle, Vector3 positionTo, Quaternion rotationTo, Vector3 attachPointStartPos, Transform attachPoint, Vector3 startingPosOffest, Quaternion startingRotOffset, VRTK_AvatarHandController avatarHandController)
	{
		return null;
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x1309618", Offset = "0x1309618", VA = "0x1309618")]
	public void StopConnection()
	{
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x1309620", Offset = "0x1309620", VA = "0x1309620")]
	public ItemSnapper2()
	{
	}
}
[Token(Token = "0x2000104")]
public class ItemToItemSnap : MonoBehaviour
{
	[Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class <SnapControllerToGrabObject>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform grabbedSnapHandle;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject grabbingObject;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ItemToItemSnap <>4__this;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform placeToSnap;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion <startingRotation>5__2;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 <startingPosition>5__3;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 <startPos>5__4;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion <startRot>5__5;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion <rotationTo>5__6;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 <positionTo>5__7;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float <t>5__8;

		[Token(Token = "0x17000072")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x130AC7C", Offset = "0x130AC7C", VA = "0x130AC7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x130ACC4", Offset = "0x130ACC4", VA = "0x130ACC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x130A448", Offset = "0x130A448", VA = "0x130A448")]
		[DebuggerHidden]
		public <SnapControllerToGrabObject>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x130A6B8", Offset = "0x130A6B8", VA = "0x130A6B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x130A6BC", Offset = "0x130A6BC", VA = "0x130A6BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x130AC84", Offset = "0x130AC84", VA = "0x130AC84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class <ConnectionCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject grabbingObject;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Quaternion rotationTo;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 positionTo;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ItemToItemSnap <>4__this;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Quaternion startingRotOffset;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 startingPosOffest;

		[Token(Token = "0x17000074")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x130AE58", Offset = "0x130AE58", VA = "0x130AE58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x130AEA0", Offset = "0x130AEA0", VA = "0x130AEA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x130A680", Offset = "0x130A680", VA = "0x130A680")]
		[DebuggerHidden]
		public <ConnectionCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x130ACCC", Offset = "0x130ACCC", VA = "0x130ACCC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x130ACD0", Offset = "0x130ACD0", VA = "0x130ACD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x130AE60", Offset = "0x130AE60", VA = "0x130AE60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Maximum distance between controller and hand position where connection doesn't break. \n0 - ignore break distance.")]
	public float breakDistance;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("Maximum angle between controller and hand where connection doesn't break. \n0 - ignore break angle.")]
	public float breakAngle;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public bool connectionEstabilished;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Coroutine connectionCoroutine;

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x130A388", Offset = "0x130A388", VA = "0x130A388", Slot = "4")]
	[IteratorStateMachine(typeof(<SnapControllerToGrabObject>d__4))]
	public virtual IEnumerator SnapControllerToGrabObject(GameObject grabbingObject, Transform grabbedSnapHandle, Transform placeToSnap)
	{
		return null;
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x130A470", Offset = "0x130A470", VA = "0x130A470", Slot = "5")]
	public virtual void CreateConnection(GameObject grabbingObject, Transform grabbedSnapHandle, Vector3 positionTo, Quaternion rotationTo, Vector3 startingPosOffest, Quaternion startingRotOffset)
	{
	}

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x130A568", Offset = "0x130A568", VA = "0x130A568", Slot = "6")]
	[IteratorStateMachine(typeof(<ConnectionCoroutine>d__6))]
	public virtual IEnumerator ConnectionCoroutine(GameObject grabbingObject, Transform grabbedSnapHandle, Vector3 positionTo, Quaternion rotationTo, Vector3 startingPosOffest, Quaternion startingRotOffset)
	{
		return null;
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x130A6A8", Offset = "0x130A6A8", VA = "0x130A6A8")]
	public void StopConnection()
	{
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x130A6B0", Offset = "0x130A6B0", VA = "0x130A6B0")]
	public ItemToItemSnap()
	{
	}
}
[Token(Token = "0x2000107")]
public class LightsSwitch : VRTK_InteractableObject
{
	[Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class <CheckRotationToTurnONOFFLights>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LightsSwitch <>4__this;

		[Token(Token = "0x17000076")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x130B2C0", Offset = "0x130B2C0", VA = "0x130B2C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x130B308", Offset = "0x130B308", VA = "0x130B308", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x130AFA8", Offset = "0x130AFA8", VA = "0x130AFA8")]
		[DebuggerHidden]
		public <CheckRotationToTurnONOFFLights>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x130AFD8", Offset = "0x130AFD8", VA = "0x130AFD8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x130AFDC", Offset = "0x130AFDC", VA = "0x130AFDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x130B2C8", Offset = "0x130B2C8", VA = "0x130B2C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public List<GarageLamp> garageLamps;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private Coroutine coroutine;

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private bool lightsDisable;

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x130AEA8", Offset = "0x130AEA8", VA = "0x130AEA8", Slot = "27")]
	public override void Grabbed([Optional] VRTK_InteractGrab currentGrabbingObject)
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x130AF78", Offset = "0x130AF78", VA = "0x130AF78", Slot = "29")]
	public override void Ungrabbed([Optional] VRTK_InteractGrab previousGrabbingObject)
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x130AF04", Offset = "0x130AF04", VA = "0x130AF04")]
	[IteratorStateMachine(typeof(<CheckRotationToTurnONOFFLights>d__5))]
	private IEnumerator CheckRotationToTurnONOFFLights()
	{
		return null;
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x130AFD0", Offset = "0x130AFD0", VA = "0x130AFD0")]
	public LightsSwitch()
	{
	}
}
[Token(Token = "0x2000109")]
public class OilDrainer : VRTK_InteractableObject
{
	[Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class <WaitForUngrab>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OilDrainer <>4__this;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform colideObject;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CarPlace whichLifter;

		[Token(Token = "0x17000078")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x130C630", Offset = "0x130C630", VA = "0x130C630", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x130C678", Offset = "0x130C678", VA = "0x130C678", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x130C170", Offset = "0x130C170", VA = "0x130C170")]
		[DebuggerHidden]
		public <WaitForUngrab>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x130C444", Offset = "0x130C444", VA = "0x130C444", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x130C448", Offset = "0x130C448", VA = "0x130C448", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x130C638", Offset = "0x130C638", VA = "0x130C638", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public List<GameObject> ghosts;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public Rigidbody rigidbody;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private float maxDistanceToSnap;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public List<GameObject> collidersToActiveWhenGrab;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	private Wheels_Controller wheelsController;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private bool snapToInteractivePlace;

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x130B310", Offset = "0x130B310", VA = "0x130B310", Slot = "67")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x130B908", Offset = "0x130B908", VA = "0x130B908", Slot = "27")]
	public override void Grabbed([Optional] VRTK_InteractGrab currentGrabbingObject)
	{
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0x130BCC8", Offset = "0x130BCC8", VA = "0x130BCC8", Slot = "29")]
	public override void Ungrabbed([Optional] VRTK_InteractGrab previousGrabbingObject)
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x130BFA0", Offset = "0x130BFA0", VA = "0x130BFA0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x130C0D8", Offset = "0x130C0D8", VA = "0x130C0D8")]
	[IteratorStateMachine(typeof(<WaitForUngrab>d__10))]
	private IEnumerator WaitForUngrab(CarPlace whichLifter, Transform colideObject)
	{
		return null;
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0x130B668", Offset = "0x130B668", VA = "0x130B668")]
	private void SubscribeCarLoadersCollidersChanges()
	{
	}

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x130C198", Offset = "0x130C198", VA = "0x130C198")]
	private void AddColliderToList(GameObject colliderToActive)
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x130C3D4", Offset = "0x130C3D4", VA = "0x130C3D4")]
	private void RemoveColliderFromList(GameObject colliderToActive)
	{
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x130C42C", Offset = "0x130C42C", VA = "0x130C42C")]
	public OilDrainer()
	{
	}
}
[Token(Token = "0x200010B")]
public class RotatorWithTwoTypesOfWheels : VRTK_InteractableObject
{
	[Token(Token = "0x200010C")]
	[CompilerGenerated]
	private sealed class <Rotation>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RotatorWithTwoTypesOfWheels <>4__this;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject controller;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <t>5__2;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion <start>5__3;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion <final>5__4;

		[Token(Token = "0x1700007A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x130CCD4", Offset = "0x130CCD4", VA = "0x130CCD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x130CD1C", Offset = "0x130CD1C", VA = "0x130CD1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x130C9A0", Offset = "0x130C9A0", VA = "0x130C9A0")]
		[DebuggerHidden]
		public <Rotation>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x130C9D0", Offset = "0x130C9D0", VA = "0x130C9D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x130C9D4", Offset = "0x130C9D4", VA = "0x130C9D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x130CCDC", Offset = "0x130CCDC", VA = "0x130CCDC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[SerializeField]
	private Wheels_Controller wheels_Controller;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[SerializeField]
	private One_Line_Wheels_Controller one_line_wheels_Controller;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public GameObject mesh;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private float actual_rotation;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private Vector3 start_rotation;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private Vector3[] wheels_actual_rotation;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private Vector3 previous_position;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private Vector3 actual_position;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private Coroutine rotation;

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x130C680", Offset = "0x130C680", VA = "0x130C680", Slot = "67")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x130C6C4", Offset = "0x130C6C4", VA = "0x130C6C4", Slot = "27")]
	public override void Grabbed(VRTK_InteractGrab currentGrabbingObject)
	{
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0x130C8D0", Offset = "0x130C8D0", VA = "0x130C8D0", Slot = "29")]
	public override void Ungrabbed(VRTK_InteractGrab previousGrabbingObject)
	{
	}

	[Token(Token = "0x6000512")]
	[Address(RVA = "0x130C840", Offset = "0x130C840", VA = "0x130C840")]
	[IteratorStateMachine(typeof(<Rotation>d__12))]
	private IEnumerator Rotation(GameObject controller)
	{
		return null;
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x130C9C8", Offset = "0x130C9C8", VA = "0x130C9C8")]
	public RotatorWithTwoTypesOfWheels()
	{
	}
}
[Token(Token = "0x200010D")]
public class Trolley : Toolbox_controller
{
	[Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class <WaitForUngrab>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Trolley <>4__this;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform colideObject;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CarPlace whichLifter;

		[Token(Token = "0x1700007C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x130DC9C", Offset = "0x130DC9C", VA = "0x130DC9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x130DCE4", Offset = "0x130DCE4", VA = "0x130DCE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x130DA3C", Offset = "0x130DA3C", VA = "0x130DA3C")]
		[DebuggerHidden]
		public <WaitForUngrab>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x130DAC4", Offset = "0x130DAC4", VA = "0x130DAC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x130DAC8", Offset = "0x130DAC8", VA = "0x130DAC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x130DCA4", Offset = "0x130DCA4", VA = "0x130DCA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	[Header("Trolley fields")]
	public List<GameObject> ghosts;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private float maxDistanceToSnap;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	private GameObject itemsToMoveWithTrolley;

	[Token(Token = "0x600051A")]
	[Address(RVA = "0x130CD24", Offset = "0x130CD24", VA = "0x130CD24", Slot = "67")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x130CF24", Offset = "0x130CF24", VA = "0x130CF24", Slot = "27")]
	public override void Grabbed(VRTK_InteractGrab currentGrabbingObject)
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x130D364", Offset = "0x130D364", VA = "0x130D364", Slot = "29")]
	public override void Ungrabbed(VRTK_InteractGrab previousGrabbingObject)
	{
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0x130D664", Offset = "0x130D664", VA = "0x130D664")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x130D930", Offset = "0x130D930", VA = "0x130D930")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x130D898", Offset = "0x130D898", VA = "0x130D898")]
	[IteratorStateMachine(typeof(<WaitForUngrab>d__8))]
	private IEnumerator WaitForUngrab(CarPlace whichLifter, Transform colideObject)
	{
		return null;
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0x130DA64", Offset = "0x130DA64", VA = "0x130DA64")]
	public Trolley()
	{
	}
}
[Token(Token = "0x200010F")]
public class WelderVR : VRE_InteractableObjectWithWheels
{
	[Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class <WaitForUngrab>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WelderVR <>4__this;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform colideObject;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CarPlace whichLifter;

		[Token(Token = "0x1700007E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x130EEA0", Offset = "0x130EEA0", VA = "0x130EEA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x130EEE8", Offset = "0x130EEE8", VA = "0x130EEE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x130E994", Offset = "0x130E994", VA = "0x130E994")]
		[DebuggerHidden]
		public <WaitForUngrab>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x130EC68", Offset = "0x130EC68", VA = "0x130EC68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x130EC6C", Offset = "0x130EC6C", VA = "0x130EC6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x130EEA8", Offset = "0x130EEA8", VA = "0x130EEA8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public List<GameObject> ghosts;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private float maxDistanceToSnap;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public List<GameObject> collidersToActiveWhenGrab;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private bool snapToInteractivePlace;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private Coroutine waiting;

	[Token(Token = "0x6000527")]
	[Address(RVA = "0x130DCEC", Offset = "0x130DCEC", VA = "0x130DCEC", Slot = "67")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0x130E138", Offset = "0x130E138", VA = "0x130E138", Slot = "27")]
	public override void Grabbed([Optional] VRTK_InteractGrab currentGrabbingObject)
	{
	}

	[Token(Token = "0x6000529")]
	[Address(RVA = "0x130E54C", Offset = "0x130E54C", VA = "0x130E54C", Slot = "29")]
	public override void Ungrabbed([Optional] VRTK_InteractGrab previousGrabbingObject)
	{
	}

	[Token(Token = "0x600052A")]
	[Address(RVA = "0x130E7E8", Offset = "0x130E7E8", VA = "0x130E7E8", Slot = "30")]
	public override void StartUsing([Optional] VRTK_InteractUse currentUsingObject)
	{
	}

	[Token(Token = "0x600052B")]
	[Address(RVA = "0x130E7F0", Offset = "0x130E7F0", VA = "0x130E7F0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0x130E8FC", Offset = "0x130E8FC", VA = "0x130E8FC")]
	[IteratorStateMachine(typeof(<WaitForUngrab>d__10))]
	private IEnumerator WaitForUngrab(CarPlace whichLifter, Transform colideObject)
	{
		return null;
	}

	[Token(Token = "0x600052D")]
	[Address(RVA = "0x130DE98", Offset = "0x130DE98", VA = "0x130DE98")]
	private void SubscribeCarLoadersCollidersChanges()
	{
	}

	[Token(Token = "0x600052E")]
	[Address(RVA = "0x130E9BC", Offset = "0x130E9BC", VA = "0x130E9BC")]
	private void AddColliderToList(GameObject colliderToActive)
	{
	}

	[Token(Token = "0x600052F")]
	[Address(RVA = "0x130EBF8", Offset = "0x130EBF8", VA = "0x130EBF8")]
	private void RemoveColliderFromList(GameObject colliderToActive)
	{
	}

	[Token(Token = "0x6000530")]
	[Address(RVA = "0x130EC50", Offset = "0x130EC50", VA = "0x130EC50")]
	public WelderVR()
	{
	}
}
[Token(Token = "0x2000111")]
public class Wheels_Controller : MonoBehaviour
{
	[Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class <RotateWheelsCoroutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Wheels_Controller <>4__this;

		[Token(Token = "0x17000080")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x130F618", Offset = "0x130F618", VA = "0x130F618", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x130F660", Offset = "0x130F660", VA = "0x130F660", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x130F184", Offset = "0x130F184", VA = "0x130F184")]
		[DebuggerHidden]
		public <RotateWheelsCoroutine>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x130F23C", Offset = "0x130F23C", VA = "0x130F23C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x130F240", Offset = "0x130F240", VA = "0x130F240", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x130F620", Offset = "0x130F620", VA = "0x130F620", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> wheels;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float rot_steps;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3[] wheels_start_rotation;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3[] wheelsOldPosition;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isRotating;

	[Token(Token = "0x6000539")]
	[Address(RVA = "0x130EEF0", Offset = "0x130EEF0", VA = "0x130EEF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600053A")]
	[Address(RVA = "0x130F000", Offset = "0x130F000", VA = "0x130F000")]
	protected void Start()
	{
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0x130B574", Offset = "0x130B574", VA = "0x130B574")]
	public void SetRotation(Vector3 rot)
	{
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x1306D8C", Offset = "0x1306D8C", VA = "0x1306D8C")]
	public void Roll(bool roll)
	{
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x130F110", Offset = "0x130F110", VA = "0x130F110")]
	[IteratorStateMachine(typeof(<RotateWheelsCoroutine>d__9))]
	private IEnumerator RotateWheelsCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x130F1AC", Offset = "0x130F1AC", VA = "0x130F1AC")]
	public Wheels_Controller()
	{
	}
}
[Token(Token = "0x2000113")]
public static class JSONUtils
{
	[Token(Token = "0x2000114")]
	public class TraceLogWriter : ITraceWriter
	{
		[Token(Token = "0x17000082")]
		public TraceLevel LevelFilter
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x130F668", Offset = "0x130F668", VA = "0x130F668", Slot = "4")]
			get
			{
				return default(TraceLevel);
			}
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x130F670", Offset = "0x130F670", VA = "0x130F670", Slot = "5")]
		public void Trace(TraceLevel level, string message, Exception ex)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x130F70C", Offset = "0x130F70C", VA = "0x130F70C")]
		public TraceLogWriter()
		{
		}
	}

	[Token(Token = "0x2000115")]
	private class UnsupportedTypeConverter : JsonConverter
	{
		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Type[] _types;

		[Token(Token = "0x17000083")]
		public override bool CanRead
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x130F714", Offset = "0x130F714", VA = "0x130F714", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x130F71C", Offset = "0x130F71C", VA = "0x130F71C")]
		public UnsupportedTypeConverter(params Type[] types)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x130F74C", Offset = "0x130F74C", VA = "0x130F74C", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x130F810", Offset = "0x130F810", VA = "0x130F810", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x130F818", Offset = "0x130F818", VA = "0x130F818", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000545")]
	public static string SerializeData<T>(T data)
	{
		return null;
	}

	[Token(Token = "0x6000546")]
	public static T DeserializeData<T>(string data, T destination)
	{
		return (T)null;
	}

	[Token(Token = "0x6000547")]
	public static T DeserializeData<T>(string data)
	{
		return (T)null;
	}
}
[Token(Token = "0x200011A")]
public class OverlayController : MonoBehaviour
{
	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ScreenFade screenFade;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVROverlay overlay;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool status;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float statusChangeTime;

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x130F970", Offset = "0x130F970", VA = "0x130F970")]
	private void Start()
	{
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x130F9C8", Offset = "0x130F9C8", VA = "0x130F9C8")]
	private void Update()
	{
	}

	[Token(Token = "0x600055D")]
	[Address(RVA = "0x130FB4C", Offset = "0x130FB4C", VA = "0x130FB4C")]
	public OverlayController()
	{
	}
}
[Token(Token = "0x200011B")]
public class ReportCollision : MonoBehaviour
{
	[Token(Token = "0x600055E")]
	[Address(RVA = "0x130FB54", Offset = "0x130FB54", VA = "0x130FB54")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x130FBD4", Offset = "0x130FBD4", VA = "0x130FBD4")]
	public ReportCollision()
	{
	}
}
[Token(Token = "0x200011C")]
public class reloadHorizontalLayoutGroup : MonoBehaviour
{
	[Token(Token = "0x200011D")]
	[CompilerGenerated]
	private sealed class <OnEnableCoroutine>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public reloadHorizontalLayoutGroup <>4__this;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HorizontalLayoutGroup <hlg>5__2;

		[Token(Token = "0x17000084")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x130FDE4", Offset = "0x130FDE4", VA = "0x130FDE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x130FE2C", Offset = "0x130FE2C", VA = "0x130FE2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x130FC70", Offset = "0x130FC70", VA = "0x130FC70")]
		[DebuggerHidden]
		public <OnEnableCoroutine>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x130FCA0", Offset = "0x130FCA0", VA = "0x130FCA0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x130FCA4", Offset = "0x130FCA4", VA = "0x130FCA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x130FDEC", Offset = "0x130FDEC", VA = "0x130FDEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x130FBDC", Offset = "0x130FBDC", VA = "0x130FBDC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x130FBFC", Offset = "0x130FBFC", VA = "0x130FBFC")]
	[IteratorStateMachine(typeof(<OnEnableCoroutine>d__1))]
	private IEnumerator OnEnableCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x130FC98", Offset = "0x130FC98", VA = "0x130FC98")]
	public reloadHorizontalLayoutGroup()
	{
	}
}
[Token(Token = "0x200011E")]
public class ReloadLightMaps : MonoBehaviour
{
	[Token(Token = "0x6000569")]
	[Address(RVA = "0x130FE34", Offset = "0x130FE34", VA = "0x130FE34")]
	public ReloadLightMaps()
	{
	}
}
[Token(Token = "0x200011F")]
public class AutomaticLOD : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000120")]
	public enum EvalMode
	{
		[Token(Token = "0x400053D")]
		CameraDistance,
		[Token(Token = "0x400053E")]
		ScreenCoverage
	}

	[Serializable]
	[Token(Token = "0x2000121")]
	public enum LevelsToGenerate
	{
		[Token(Token = "0x4000540")]
		_1 = 1,
		[Token(Token = "0x4000541")]
		_2,
		[Token(Token = "0x4000542")]
		_3,
		[Token(Token = "0x4000543")]
		_4,
		[Token(Token = "0x4000544")]
		_5,
		[Token(Token = "0x4000545")]
		_6
	}

	[Serializable]
	[Token(Token = "0x2000122")]
	public enum SwitchMode
	{
		[Token(Token = "0x4000547")]
		SwitchMesh,
		[Token(Token = "0x4000548")]
		SwitchGameObject,
		[Token(Token = "0x4000549")]
		UnityLODGroup
	}

	[Serializable]
	[Token(Token = "0x2000123")]
	public class LODLevelData
	{
		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m_fScreenCoverage;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m_fMaxCameraDistance;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m_fMeshVerticesAmount;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int m_nColorEditorBarIndex;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mesh m_mesh;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool m_bUsesOriginalMesh;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject m_gameObject;

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1312764", Offset = "0x1312764", VA = "0x1312764")]
		public LODLevelData GetCopy()
		{
			return null;
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1313668", Offset = "0x1313668", VA = "0x1313668")]
		public LODLevelData()
		{
		}
	}

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Mesh m_originalMesh;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public EvalMode m_evalMode;

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public bool m_bEnablePrefabUsage;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public string m_strAssetPath;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public float m_fMaxCameraDistance;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public int m_nColorEditorBarNewIndex;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public List<LODLevelData> m_listLODLevels;

	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public AutomaticLOD m_LODObjectRoot;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public List<AutomaticLOD> m_listDependentChildren;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool m_bExpandRelevanceSpheres;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RelevanceSphere[] m_aRelevanceSpheres;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Simplifier m_meshSimplifier;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private bool m_bGenerateIncludeChildren;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private LevelsToGenerate m_levelsToGenerate;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private SwitchMode m_switchMode;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	private bool m_bOverrideRootSettings;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	[HideInInspector]
	[SerializeField]
	private bool m_bLODDataDirty;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	[HideInInspector]
	private AutomaticLOD m_LODObjectRootPersist;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	[HideInInspector]
	private LODGroup m_LODGroup;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool m_bUseAutomaticCameraLODSwitch;

	[Token(Token = "0x400052D")]
	private const int k_MaxLODChecksPerFrame = 4;

	[Token(Token = "0x400052E")]
	private const int k_MaxFrameCheckLoop = 100;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int s_currentCheckIndex;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int s_currentFrameCheckIndex;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int s_checkLoopLength;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static int s_lastFrameComputedModulus;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int s_currentFrameInLoop;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Camera s_userDefinedCamera;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Camera m_renderCamera;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int m_nCurrentLOD;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Dictionary<Camera, int> m_cachedFrameLODLevel;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector3 m_localCenter;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Vector3[] _corners;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int m_frameToCheck;

	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private bool b_performCheck;

	[Token(Token = "0x17000086")]
	public static Camera UserDefinedLODCamera
	{
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x130FE3C", Offset = "0x130FE3C", VA = "0x130FE3C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x130FE94", Offset = "0x130FE94", VA = "0x130FE94")]
		set
		{
		}
	}

	[Token(Token = "0x17000087")]
	public SwitchMode LODSwitchMode
	{
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x130FEF4", Offset = "0x130FEF4", VA = "0x130FEF4")]
		get
		{
			return default(SwitchMode);
		}
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0x130FFA0", Offset = "0x130FFA0", VA = "0x130FFA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600056E")]
	[Address(RVA = "0x1310600", Offset = "0x1310600", VA = "0x1310600")]
	private void Update()
	{
	}

	[Token(Token = "0x600056F")]
	[Address(RVA = "0x1310E40", Offset = "0x1310E40", VA = "0x1310E40")]
	private void OnWillRenderObject()
	{
	}

	[Token(Token = "0x6000570")]
	[Address(RVA = "0x1310E64", Offset = "0x1310E64", VA = "0x1310E64")]
	public static bool HasValidMeshData(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x1310F4C", Offset = "0x1310F4C", VA = "0x1310F4C")]
	public static bool IsRootOrBelongsToLODTree(AutomaticLOD automaticLOD, AutomaticLOD root)
	{
		return default(bool);
	}

	[Token(Token = "0x6000572")]
	[Address(RVA = "0x131107C", Offset = "0x131107C", VA = "0x131107C")]
	public int GetNumberOfLevelsToGenerate()
	{
		return default(int);
	}

	[Token(Token = "0x6000573")]
	[Address(RVA = "0x1311084", Offset = "0x1311084", VA = "0x1311084")]
	public bool IsGenerateIncludeChildrenActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x131108C", Offset = "0x131108C", VA = "0x131108C")]
	public bool IsRootAutomaticLOD()
	{
		return default(bool);
	}

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x13110EC", Offset = "0x13110EC", VA = "0x13110EC")]
	public bool HasDependentChildren()
	{
		return default(bool);
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x1311140", Offset = "0x1311140", VA = "0x1311140")]
	public bool HasLODDataDirty()
	{
		return default(bool);
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x1311148", Offset = "0x1311148", VA = "0x1311148")]
	public bool SetLODDataDirty(bool bDirty)
	{
		return default(bool);
	}

	[Token(Token = "0x6000578")]
	[Address(RVA = "0x1311158", Offset = "0x1311158", VA = "0x1311158")]
	public int GetLODLevelCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000579")]
	[Address(RVA = "0x13111A4", Offset = "0x13111A4", VA = "0x13111A4")]
	public float ComputeScreenCoverage(Camera camera)
	{
		return default(float);
	}

	[Token(Token = "0x600057A")]
	[Address(RVA = "0x1310244", Offset = "0x1310244", VA = "0x1310244")]
	public Vector3 ComputeWorldCenter()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600057B")]
	[Address(RVA = "0x13119FC", Offset = "0x13119FC", VA = "0x13119FC")]
	public float ComputeViewSpaceBounds(Vector3 v3CameraPos, Vector3 v3CameraDir, Vector3 v3CameraUp, out Vector3 v3Min, out Vector3 v3Max, out Vector3 v3Center)
	{
		return default(float);
	}

	[Token(Token = "0x600057C")]
	[Address(RVA = "0x1311F58", Offset = "0x1311F58", VA = "0x1311F58")]
	public void SetAutomaticCameraLODSwitch(bool bEnabled)
	{
	}

	[Token(Token = "0x600057D")]
	[Address(RVA = "0x1311FD4", Offset = "0x1311FD4", VA = "0x1311FD4")]
	private static void SetAutomaticCameraLODSwitchRecursive(AutomaticLOD root, GameObject gameObject, bool bEnabled)
	{
	}

	[Token(Token = "0x600057E")]
	[Address(RVA = "0x131214C", Offset = "0x131214C", VA = "0x131214C")]
	public void SetLODLevels(List<LODLevelData> listLODLevelData, EvalMode evalMode, float fMaxCameraDistance, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600057F")]
	[Address(RVA = "0x13122DC", Offset = "0x13122DC", VA = "0x13122DC")]
	private static void SetLODLevelsRecursive(AutomaticLOD root, GameObject gameObject)
	{
	}

	[Token(Token = "0x6000580")]
	[Address(RVA = "0x1312BB0", Offset = "0x1312BB0", VA = "0x1312BB0")]
	public void AddLODLevel(int nLevel, bool bBefore, bool bCreateMesh, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000581")]
	[Address(RVA = "0x1312C4C", Offset = "0x1312C4C", VA = "0x1312C4C")]
	public static void AddLODLevelRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, bool bBefore, bool bCreateMesh, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000582")]
	[Address(RVA = "0x1313670", Offset = "0x1313670", VA = "0x1313670")]
	public void RemoveLODLevel(int nLevel, bool bDeleteMesh, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000583")]
	[Address(RVA = "0x1313704", Offset = "0x1313704", VA = "0x1313704")]
	public static void RemoveLODLevelRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, bool bDeleteMesh, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000584")]
	[Address(RVA = "0x1313B70", Offset = "0x1313B70", VA = "0x1313B70")]
	public Simplifier GetMeshSimplifier()
	{
		return null;
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x1313B78", Offset = "0x1313B78", VA = "0x1313B78")]
	public void ComputeLODData(bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x1313BB4", Offset = "0x1313BB4", VA = "0x1313BB4")]
	private void ComputeLODDataRecursive(AutomaticLOD root, GameObject gameObject, bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x13143D4", Offset = "0x13143D4", VA = "0x13143D4")]
	public bool HasLODData()
	{
		return default(bool);
	}

	[Token(Token = "0x6000588")]
	[Address(RVA = "0x1310ABC", Offset = "0x1310ABC", VA = "0x1310ABC")]
	public int GetLODLevelUsingCamera(Camera currentCamera)
	{
		return default(int);
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0x1314464", Offset = "0x1314464", VA = "0x1314464")]
	public int GetCurrentLODLevel()
	{
		return default(int);
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0x1310D5C", Offset = "0x1310D5C", VA = "0x1310D5C")]
	public void SwitchToLOD(int nLevel, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600058B")]
	[Address(RVA = "0x131446C", Offset = "0x131446C", VA = "0x131446C")]
	private static void SwitchToLODRecursive(AutomaticLOD root, GameObject gameObject, int nLODLevel, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0x1314A1C", Offset = "0x1314A1C", VA = "0x1314A1C")]
	public void ComputeAllLODMeshes(bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0x1315704", Offset = "0x1315704", VA = "0x1315704")]
	public void ComputeLODMesh(int nLevel, bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0x1314B40", Offset = "0x1314B40", VA = "0x1314B40")]
	private static void ComputeLODMeshRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x13157A0", Offset = "0x13157A0", VA = "0x13157A0")]
	public void RestoreOriginalMesh(bool bDeleteLODData, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x1315878", Offset = "0x1315878", VA = "0x1315878")]
	private static void RestoreOriginalMeshRecursive(AutomaticLOD root, GameObject gameObject, bool bDeleteLODData, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000591")]
	[Address(RVA = "0x1315CC0", Offset = "0x1315CC0", VA = "0x1315CC0")]
	public bool HasOriginalMeshActive(bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x1315D3C", Offset = "0x1315D3C", VA = "0x1315D3C")]
	private static bool HasOriginalMeshActiveRecursive(AutomaticLOD root, GameObject gameObject, bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0x1315FE8", Offset = "0x1315FE8", VA = "0x1315FE8")]
	public bool HasVertexData(int nLevel, bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	[Token(Token = "0x6000594")]
	[Address(RVA = "0x131606C", Offset = "0x131606C", VA = "0x131606C")]
	private static bool HasVertexDataRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0x13162DC", Offset = "0x13162DC", VA = "0x13162DC")]
	public int GetOriginalVertexCount(bool bRecurseIntoChildren)
	{
		return default(int);
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x1316368", Offset = "0x1316368", VA = "0x1316368")]
	private static void GetOriginalVertexCountRecursive(AutomaticLOD root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x1316524", Offset = "0x1316524", VA = "0x1316524")]
	public int GetOriginalTriangleCount(bool bRecurseIntoChildren)
	{
		return default(int);
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x13165B0", Offset = "0x13165B0", VA = "0x13165B0")]
	private static void GetOriginalTriangleCountRecursive(AutomaticLOD root, GameObject gameObject, ref int nTriangleCount, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x131678C", Offset = "0x131678C", VA = "0x131678C")]
	public int GetCurrentVertexCount(bool bRecurseIntoChildren)
	{
		return default(int);
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x1316818", Offset = "0x1316818", VA = "0x1316818")]
	private static void GetCurrentVertexCountRecursive(AutomaticLOD root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x1316AE0", Offset = "0x1316AE0", VA = "0x1316AE0")]
	public int GetLODVertexCount(int nLevel, bool bRecurseIntoChildren)
	{
		return default(int);
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x1316B7C", Offset = "0x1316B7C", VA = "0x1316B7C")]
	private static void GetLODVertexCountRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, ref int nVertexCount, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x1316DF0", Offset = "0x1316DF0", VA = "0x1316DF0")]
	public int GetLODTriangleCount(int nLevel, bool bRecurseIntoChildren)
	{
		return default(int);
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0x1316E8C", Offset = "0x1316E8C", VA = "0x1316E8C")]
	private static void GetLODTriangleCountRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, ref int nTriangleCount, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600059F")]
	[Address(RVA = "0x1317120", Offset = "0x1317120", VA = "0x1317120")]
	public void RemoveFromLODTree()
	{
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x1314358", Offset = "0x1314358", VA = "0x1314358")]
	public void FreeLODData(bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x13171C8", Offset = "0x13171C8", VA = "0x13171C8")]
	private static void FreeLODDataRecursive(AutomaticLOD root, GameObject gameObject, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x13127E4", Offset = "0x13127E4", VA = "0x13127E4")]
	private static Mesh CreateNewEmptyMesh(AutomaticLOD automaticLOD)
	{
		return null;
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x13176D8", Offset = "0x13176D8", VA = "0x13176D8")]
	private static GameObject CreateBasicObjectCopy(GameObject gameObject, Mesh mesh, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x13128CC", Offset = "0x13128CC", VA = "0x13128CC")]
	private static void CheckForAdditionalLODSetup(AutomaticLOD root, AutomaticLOD automaticLOD, LODLevelData levelData, int level)
	{
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x13152EC", Offset = "0x13152EC", VA = "0x13152EC")]
	public void SetupLODGroup()
	{
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x1317BD0", Offset = "0x1317BD0", VA = "0x1317BD0")]
	private static void SetupLODGroupRecursive(AutomaticLOD root, GameObject gameObject, ref List<List<Renderer>> renderers)
	{
	}

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x1317BC8", Offset = "0x1317BC8", VA = "0x1317BC8")]
	private static Component CopyComponent(Component original, GameObject destination)
	{
		return null;
	}

	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x1311684", Offset = "0x1311684", VA = "0x1311684")]
	private void BuildCornerData(ref Vector3[] av3Corners, Bounds bounds)
	{
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x1310568", Offset = "0x1310568", VA = "0x1310568")]
	private bool IsDependent()
	{
		return default(bool);
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x1317F78", Offset = "0x1317F78", VA = "0x1317F78")]
	public AutomaticLOD()
	{
	}
}
[Token(Token = "0x2000124")]
public class CanvasProxy : BaseRaycaster
{
	[Token(Token = "0x2000125")]
	public class TouchEvent
	{
		[Token(Token = "0x2000126")]
		public enum TouchType
		{
			[Token(Token = "0x4000576")]
			Move,
			[Token(Token = "0x4000577")]
			Press,
			[Token(Token = "0x4000578")]
			Release,
			[Token(Token = "0x4000579")]
			NearTouch,
			[Token(Token = "0x400057A")]
			Exit,
			[Token(Token = "0x400057B")]
			Scroll
		}

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TouchType Type;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector2 Point;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public long Time;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 ScrollValue;

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x131CEC0", Offset = "0x131CEC0", VA = "0x131CEC0")]
		public TouchEvent()
		{
		}
	}

	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Camera cam;

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform canvasParent;

	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform worldCanvasParent;

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform screenQuad;

	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Canvas canvas;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Vector2 tabletResolution;

	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private CanvasGroupDisabler canvasGroupDisabler;

	[Token(Token = "0x4000558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<CanvasProxyInput> inputs;

	[Token(Token = "0x4000559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform laserPointer;

	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private VRReferences vrr;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Camera mainCamera;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private SortedDictionary<int, int> order;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float lastInteractionTime;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<UIBehaviour> cachedInteractablesUnderPoint;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector2 cachedInteractablesPoint;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool cachedInteractablesUnderPointNeedRefresh;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private long touchStartTime;

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector2 touchStartPosition;

	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool touchStarted;

	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private UIBehaviour draggedObject;

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Vector2 dragStart;

	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Vector2 dragLastPoint;

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private UIBehaviour onNearTouchObject;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private CarLoader car;

	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Bounds bounds;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Vector3 lastGoodPosition;

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Quaternion lastGoodRotation;

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Collider tabletCollider;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Vector3 moveVec;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public float moveForce;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[SerializeField]
	private Collider[] collidersToForce;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CanvasProxy s_instance;

	[Token(Token = "0x17000088")]
	public override Camera eventCamera
	{
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1318094", Offset = "0x1318094", VA = "0x1318094", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000089")]
	public static CanvasProxy instance
	{
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x131CB24", Offset = "0x131CB24", VA = "0x131CB24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x131809C", Offset = "0x131809C", VA = "0x131809C", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x1318100", Offset = "0x1318100", VA = "0x1318100", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x1318414", Offset = "0x1318414", VA = "0x1318414")]
	public void UpdateTablet()
	{
	}

	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x1318484", Offset = "0x1318484", VA = "0x1318484")]
	public void RegisterInput(CanvasProxyInput input)
	{
	}

	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x131856C", Offset = "0x131856C", VA = "0x131856C")]
	public void UnregisterInput(CanvasProxyInput input)
	{
	}

	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x13185FC", Offset = "0x13185FC", VA = "0x13185FC")]
	public void ForceRefresh()
	{
	}

	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x1318618", Offset = "0x1318618", VA = "0x1318618")]
	private void SceneManager_sceneUnloaded(Scene arg0)
	{
	}

	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x1318638", Offset = "0x1318638", VA = "0x1318638")]
	private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
	{
	}

	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x1318658", Offset = "0x1318658", VA = "0x1318658")]
	private void RecursiveIndexOrder(Transform root, ref int level)
	{
	}

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x1318764", Offset = "0x1318764", VA = "0x1318764")]
	private void RecursiveChangeLayer(Transform root, int layer)
	{
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x1318844", Offset = "0x1318844", VA = "0x1318844")]
	private void Render()
	{
	}

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x1318C18", Offset = "0x1318C18", VA = "0x1318C18")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x1318C1C", Offset = "0x1318C1C", VA = "0x1318C1C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x1318C20", Offset = "0x1318C20", VA = "0x1318C20")]
	private void Update()
	{
	}

	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x1319198", Offset = "0x1319198", VA = "0x1319198")]
	private void InitializeCanvas()
	{
	}

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x131A778", Offset = "0x131A778", VA = "0x131A778")]
	private void OnStoppedColliding()
	{
	}

	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x131AA98", Offset = "0x131AA98", VA = "0x131AA98")]
	protected List<UIBehaviour> GetInteractablesUnderPoint(Vector2 point)
	{
		return null;
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x131ABCC", Offset = "0x131ABCC", VA = "0x131ABCC")]
	private void UpdateCachedInteractables()
	{
	}

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x131AC00", Offset = "0x131AC00", VA = "0x131AC00")]
	private List<UIBehaviour> _GetInteractablesUnderPoint(Vector2 point)
	{
		return null;
	}

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x131A5CC", Offset = "0x131A5CC", VA = "0x131A5CC")]
	public void UpdateEvents(TouchEvent[] events)
	{
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x131B388", Offset = "0x131B388", VA = "0x131B388")]
	private void OnScroll(Vector2 point, Vector2 scrollValue)
	{
	}

	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x131BE58", Offset = "0x131BE58", VA = "0x131BE58")]
	protected void OnNearTouch(Vector2 point)
	{
	}

	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x131A830", Offset = "0x131A830", VA = "0x131A830")]
	protected void TryOnPointerExit(UIBehaviour obj, PointerEventData pointerEvent)
	{
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x131C3E8", Offset = "0x131C3E8", VA = "0x131C3E8")]
	protected void TryOnPointerEnter(UIBehaviour obj, PointerEventData pointerEvent)
	{
	}

	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x131C650", Offset = "0x131C650", VA = "0x131C650")]
	protected void TryScroll(UIBehaviour obj, PointerEventData pointerEvent)
	{
	}

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x131C8B8", Offset = "0x131C8B8", VA = "0x131C8B8")]
	protected void TryDrag(UIBehaviour obj, PointerEventData pointerEvent)
	{
	}

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x131C2E8", Offset = "0x131C2E8", VA = "0x131C2E8")]
	protected void OnTouchExit()
	{
	}

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x131B7D4", Offset = "0x131B7D4", VA = "0x131B7D4")]
	protected void OnTouch(Vector2 point)
	{
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x131B11C", Offset = "0x131B11C", VA = "0x131B11C")]
	protected void OnDragStart(Vector2 grabPoint)
	{
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x131BE4C", Offset = "0x131BE4C", VA = "0x131BE4C")]
	protected void OnDragEnd(Vector2 dropPoint)
	{
	}

	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x131AEEC", Offset = "0x131AEEC", VA = "0x131AEEC")]
	protected void OnDragContinues(Vector2 point)
	{
	}

	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x131CB20", Offset = "0x131CB20", VA = "0x131CB20", Slot = "17")]
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
	{
	}

	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x131CBE8", Offset = "0x131CBE8", VA = "0x131CBE8")]
	public CanvasProxy()
	{
	}
}
[Token(Token = "0x2000127")]
public class CanvasProxyGroupForceRefresh : MonoBehaviour
{
	[Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class <ForceRefreshEveryFrame>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CanvasProxyGroupForceRefresh <>4__this;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CanvasGroup <canvasGroup>5__2;

		[Token(Token = "0x1700008A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x131D100", Offset = "0x131D100", VA = "0x131D100", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x131D148", Offset = "0x131D148", VA = "0x131D148", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x131CFAC", Offset = "0x131CFAC", VA = "0x131CFAC")]
		[DebuggerHidden]
		public <ForceRefreshEveryFrame>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x131CFDC", Offset = "0x131CFDC", VA = "0x131CFDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x131CFE0", Offset = "0x131CFE0", VA = "0x131CFE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x131D108", Offset = "0x131D108", VA = "0x131D108", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400057C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool alwaysRefreshWhenVisible;

	[Token(Token = "0x400057D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CanvasProxy proxy;

	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x131CEC8", Offset = "0x131CEC8", VA = "0x131CEC8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x131CEE8", Offset = "0x131CEE8", VA = "0x131CEE8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x131CF08", Offset = "0x131CF08", VA = "0x131CF08")]
	private void Start()
	{
	}

	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x131CF38", Offset = "0x131CF38", VA = "0x131CF38")]
	[IteratorStateMachine(typeof(<ForceRefreshEveryFrame>d__5))]
	private IEnumerator ForceRefreshEveryFrame()
	{
		return null;
	}

	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x131CFD4", Offset = "0x131CFD4", VA = "0x131CFD4")]
	public CanvasProxyGroupForceRefresh()
	{
	}
}
[Token(Token = "0x2000129")]
public class CanvasProxyInput : MonoBehaviour
{
	[Token(Token = "0x4000582")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float fingerHoverDistance;

	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float fingerTouchDistance;

	[Token(Token = "0x4000584")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform screenQuad;

	[Token(Token = "0x4000585")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<CanvasProxy.TouchEvent> touchEvents;

	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool wasColliding;

	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool btnWasDown;

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector2 prevPoint;

	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Plane tabletPlane;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Stopwatch timer;

	[Token(Token = "0x1700008C")]
	public List<CanvasProxy.TouchEvent> TouchEvents
	{
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x131D208", Offset = "0x131D208", VA = "0x131D208")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005DF")]
	[Address(RVA = "0x131D150", Offset = "0x131D150", VA = "0x131D150")]
	private void Start()
	{
	}

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0x131D180", Offset = "0x131D180", VA = "0x131D180")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x131D210", Offset = "0x131D210", VA = "0x131D210")]
	public static bool IntersectRayTriangle(in Ray ray, in Vector3 v0, in Vector3 v1, in Vector3 v2, out Vector3 IntersectionPoint, out Vector3 uvw)
	{
		return default(bool);
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x13197D0", Offset = "0x13197D0", VA = "0x13197D0")]
	public bool UpdateInput(Transform laserPointer, float triggetAxis, Vector2 stickAxis, Camera cam, Vector2 tabletResolution, Action OnStoppedColliding)
	{
		return default(bool);
	}

	[Token(Token = "0x60005E4")]
	[Address(RVA = "0x1319760", Offset = "0x1319760", VA = "0x1319760")]
	internal void Clear()
	{
	}

	[Token(Token = "0x60005E5")]
	[Address(RVA = "0x131D474", Offset = "0x131D474", VA = "0x131D474")]
	public CanvasProxyInput()
	{
	}
}
[Token(Token = "0x200012A")]
public class EnableChildrenTimesliced : MonoBehaviour
{
	[Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class <Show>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnableChildrenTimesliced <>4__this;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x1700008D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x131D794", Offset = "0x131D794", VA = "0x131D794", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x131D7DC", Offset = "0x131D7DC", VA = "0x131D7DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x131D5D8", Offset = "0x131D5D8", VA = "0x131D5D8")]
		[DebuggerHidden]
		public <Show>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x131D6B4", Offset = "0x131D6B4", VA = "0x131D6B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x131D6B8", Offset = "0x131D6B8", VA = "0x131D6B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x131D79C", Offset = "0x131D79C", VA = "0x131D79C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class <EnableAndScaleback>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform t;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 <currentScale>5__2;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 <startScale>5__3;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float <startTime>5__4;

		[Token(Token = "0x1700008F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x131D99C", Offset = "0x131D99C", VA = "0x131D99C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x131D9E4", Offset = "0x131D9E4", VA = "0x131D9E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x131D684", Offset = "0x131D684", VA = "0x131D684")]
		[DebuggerHidden]
		public <EnableAndScaleback>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x131D7E4", Offset = "0x131D7E4", VA = "0x131D7E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x131D7E8", Offset = "0x131D7E8", VA = "0x131D7E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x131D9A4", Offset = "0x131D9A4", VA = "0x131D9A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60005E6")]
	[Address(RVA = "0x131D544", Offset = "0x131D544", VA = "0x131D544")]
	private void Start()
	{
	}

	[Token(Token = "0x60005E7")]
	[Address(RVA = "0x131D564", Offset = "0x131D564", VA = "0x131D564")]
	[IteratorStateMachine(typeof(<Show>d__1))]
	private IEnumerator Show()
	{
		return null;
	}

	[Token(Token = "0x60005E8")]
	[Address(RVA = "0x131D600", Offset = "0x131D600", VA = "0x131D600")]
	[IteratorStateMachine(typeof(<EnableAndScaleback>d__2))]
	private IEnumerator EnableAndScaleback(Transform t, float duration)
	{
		return null;
	}

	[Token(Token = "0x60005E9")]
	[Address(RVA = "0x131D6AC", Offset = "0x131D6AC", VA = "0x131D6AC")]
	public EnableChildrenTimesliced()
	{
	}
}
[Token(Token = "0x200012D")]
public class FaceAt : MonoBehaviour
{
	[Token(Token = "0x60005F6")]
	[Address(RVA = "0x131D9EC", Offset = "0x131D9EC", VA = "0x131D9EC")]
	private void Start()
	{
	}

	[Token(Token = "0x60005F7")]
	[Address(RVA = "0x131D9F0", Offset = "0x131D9F0", VA = "0x131D9F0")]
	public FaceAt()
	{
	}
}
[Token(Token = "0x200012E")]
public class MeshSimplify : MonoBehaviour
{
	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Mesh m_originalMesh;

	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Mesh m_simplifiedMesh;

	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public bool m_bEnablePrefabUsage;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	public float m_fVertexAmount;

	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public string m_strAssetPath;

	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public MeshSimplify m_meshSimplifyRoot;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public List<MeshSimplify> m_listDependentChildren;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public bool m_bExpandRelevanceSpheres;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RelevanceSphere[] m_aRelevanceSpheres;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	[SerializeField]
	private Simplifier m_meshSimplifier;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[HideInInspector]
	private bool m_bGenerateIncludeChildren;

	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	[SerializeField]
	[HideInInspector]
	private bool m_bOverrideRootSettings;

	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	[HideInInspector]
	[SerializeField]
	private bool m_bUseEdgeLength;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
	[SerializeField]
	[HideInInspector]
	private bool m_bUseCurvature;

	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	[HideInInspector]
	private bool m_bProtectTexture;

	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	[SerializeField]
	[HideInInspector]
	private bool m_bLockBorder;

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
	[HideInInspector]
	[SerializeField]
	private bool m_bDataDirty;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
	[SerializeField]
	[HideInInspector]
	private bool m_bExcludedFromTree;

	[Token(Token = "0x17000091")]
	public bool RecurseIntoChildren
	{
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x131D9F8", Offset = "0x131D9F8", VA = "0x131D9F8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000092")]
	public Simplifier MeshSimplifier
	{
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x131DA00", Offset = "0x131DA00", VA = "0x131DA00")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x131DA08", Offset = "0x131DA08", VA = "0x131DA08")]
		set
		{
		}
	}

	[Token(Token = "0x60005FB")]
	[Address(RVA = "0x131DA10", Offset = "0x131DA10", VA = "0x131DA10")]
	public static bool HasValidMeshData(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60005FC")]
	[Address(RVA = "0x131DAF8", Offset = "0x131DAF8", VA = "0x131DAF8")]
	public static bool IsRootOrBelongsToTree(MeshSimplify meshSimplify, MeshSimplify root)
	{
		return default(bool);
	}

	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x131DC30", Offset = "0x131DC30", VA = "0x131DC30")]
	public bool IsGenerateIncludeChildrenActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x131DC38", Offset = "0x131DC38", VA = "0x131DC38")]
	public bool HasDependentChildren()
	{
		return default(bool);
	}

	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x131DC8C", Offset = "0x131DC8C", VA = "0x131DC8C")]
	public bool HasDataDirty()
	{
		return default(bool);
	}

	[Token(Token = "0x6000600")]
	[Address(RVA = "0x131DC94", Offset = "0x131DC94", VA = "0x131DC94")]
	public bool SetDataDirty(bool bDirty)
	{
		return default(bool);
	}

	[Token(Token = "0x6000601")]
	[Address(RVA = "0x131DCA4", Offset = "0x131DCA4", VA = "0x131DCA4")]
	public bool HasNonMeshSimplifyGameObjectsInTree()
	{
		return default(bool);
	}

	[Token(Token = "0x6000602")]
	[Address(RVA = "0x131DCC8", Offset = "0x131DCC8", VA = "0x131DCC8")]
	private bool HasNonMeshSimplifyGameObjectsInTreeRecursive(MeshSimplify root, GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000603")]
	[Address(RVA = "0x131DDF8", Offset = "0x131DDF8", VA = "0x131DDF8")]
	public void ConfigureSimplifier()
	{
	}

	[Token(Token = "0x6000604")]
	[Address(RVA = "0x131DF7C", Offset = "0x131DF7C", VA = "0x131DF7C")]
	public Simplifier GetMeshSimplifier()
	{
		return null;
	}

	[Token(Token = "0x6000605")]
	[Address(RVA = "0x131DF84", Offset = "0x131DF84", VA = "0x131DF84")]
	public void ComputeData(bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	[Token(Token = "0x6000606")]
	[Address(RVA = "0x131DFBC", Offset = "0x131DFBC", VA = "0x131DFBC")]
	private static void ComputeDataRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	[Token(Token = "0x6000607")]
	[Address(RVA = "0x131E814", Offset = "0x131E814", VA = "0x131E814")]
	public bool HasData()
	{
		return default(bool);
	}

	[Token(Token = "0x6000608")]
	[Address(RVA = "0x131E8D4", Offset = "0x131E8D4", VA = "0x131E8D4")]
	public bool HasSimplifiedMesh()
	{
		return default(bool);
	}

	[Token(Token = "0x6000609")]
	[Address(RVA = "0x131E960", Offset = "0x131E960", VA = "0x131E960")]
	public void ComputeMesh(bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	[Token(Token = "0x600060A")]
	[Address(RVA = "0x131E998", Offset = "0x131E998", VA = "0x131E998")]
	private static void ComputeMeshRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	[Token(Token = "0x600060B")]
	[Address(RVA = "0x131EEC8", Offset = "0x131EEC8", VA = "0x131EEC8")]
	public void AssignSimplifiedMesh(bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600060C")]
	[Address(RVA = "0x131EEF8", Offset = "0x131EEF8", VA = "0x131EEF8")]
	private static void AssignSimplifiedMeshRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600060D")]
	[Address(RVA = "0x131F11C", Offset = "0x131F11C", VA = "0x131F11C")]
	public void RestoreOriginalMesh(bool bDeleteData, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600060E")]
	[Address(RVA = "0x131F154", Offset = "0x131F154", VA = "0x131F154")]
	private static void RestoreOriginalMeshRecursive(MeshSimplify root, GameObject gameObject, bool bDeleteData, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600060F")]
	[Address(RVA = "0x131F3D8", Offset = "0x131F3D8", VA = "0x131F3D8")]
	public bool HasOriginalMeshActive(bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	[Token(Token = "0x6000610")]
	[Address(RVA = "0x131F408", Offset = "0x131F408", VA = "0x131F408")]
	private static bool HasOriginalMeshActiveRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	[Token(Token = "0x6000611")]
	[Address(RVA = "0x131F678", Offset = "0x131F678", VA = "0x131F678")]
	public bool HasVertexData(bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	[Token(Token = "0x6000612")]
	[Address(RVA = "0x131F6A8", Offset = "0x131F6A8", VA = "0x131F6A8")]
	private static bool HasVertexDataRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	[Token(Token = "0x6000613")]
	[Address(RVA = "0x131F82C", Offset = "0x131F82C", VA = "0x131F82C")]
	public int GetOriginalVertexCount(bool bRecurseIntoChildren)
	{
		return default(int);
	}

	[Token(Token = "0x6000614")]
	[Address(RVA = "0x131F86C", Offset = "0x131F86C", VA = "0x131F86C")]
	private static void GetOriginalVertexCountRecursive(MeshSimplify root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000615")]
	[Address(RVA = "0x131F9EC", Offset = "0x131F9EC", VA = "0x131F9EC")]
	public int GetOriginalTriangleCount(bool bRecurseIntoChildren)
	{
		return default(int);
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0x131FA2C", Offset = "0x131FA2C", VA = "0x131FA2C")]
	private static void GetOriginalTriangleCountRecursive(MeshSimplify root, GameObject gameObject, ref int nTriangleCount, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0x131FBCC", Offset = "0x131FBCC", VA = "0x131FBCC")]
	public int GetSimplifiedVertexCount(bool bRecurseIntoChildren)
	{
		return default(int);
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x131FC0C", Offset = "0x131FC0C", VA = "0x131FC0C")]
	private static void GetSimplifiedVertexCountRecursive(MeshSimplify root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0x131FD8C", Offset = "0x131FD8C", VA = "0x131FD8C")]
	public int GetSimplifiedTriangleCount(bool bRecurseIntoChildren)
	{
		return default(int);
	}

	[Token(Token = "0x600061A")]
	[Address(RVA = "0x131FDCC", Offset = "0x131FDCC", VA = "0x131FDCC")]
	private static void GetSimplifiedTriangleCountRecursive(MeshSimplify root, GameObject gameObject, ref int nTriangleCount, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600061B")]
	[Address(RVA = "0x131FF6C", Offset = "0x131FF6C", VA = "0x131FF6C")]
	public void RemoveFromTree()
	{
	}

	[Token(Token = "0x600061C")]
	[Address(RVA = "0x131E7E4", Offset = "0x131E7E4", VA = "0x131E7E4")]
	public void FreeData(bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600061D")]
	[Address(RVA = "0x1320030", Offset = "0x1320030", VA = "0x1320030")]
	private static void FreeDataRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600061E")]
	[Address(RVA = "0x131EDE0", Offset = "0x131EDE0", VA = "0x131EDE0")]
	private static Mesh CreateNewEmptyMesh(MeshSimplify meshSimplify)
	{
		return null;
	}

	[Token(Token = "0x600061F")]
	[Address(RVA = "0x132026C", Offset = "0x132026C", VA = "0x132026C")]
	public MeshSimplify()
	{
	}
}
[Token(Token = "0x200012F")]
public class mouseCursorOnScreen : MonoBehaviour
{
	[Token(Token = "0x6000620")]
	[Address(RVA = "0x1320314", Offset = "0x1320314", VA = "0x1320314")]
	private bool rectOverlaps(RectTransform rectTrans2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000621")]
	[Address(RVA = "0x13207A4", Offset = "0x13207A4", VA = "0x13207A4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000622")]
	[Address(RVA = "0x1320888", Offset = "0x1320888", VA = "0x1320888")]
	public mouseCursorOnScreen()
	{
	}
}
[Token(Token = "0x2000130")]
public class NearDisplayLogic : MonoBehaviour
{
	[Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class <CalculateDistance>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NearDisplayLogic <>4__this;

		[Token(Token = "0x17000093")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x1320D54", Offset = "0x1320D54", VA = "0x1320D54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x1320D9C", Offset = "0x1320D9C", VA = "0x1320D9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x1320AA8", Offset = "0x1320AA8", VA = "0x1320AA8")]
		[DebuggerHidden]
		public <CalculateDistance>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x1320BE0", Offset = "0x1320BE0", VA = "0x1320BE0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1320BE4", Offset = "0x1320BE4", VA = "0x1320BE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x1320D5C", Offset = "0x1320D5C", VA = "0x1320D5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform laserPointer;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform normalPointerTransform;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform screenPointerTransform;

	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform tabletTransform;

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public VRTK_UIPointer pointer;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float distance;

	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float validDistance;

	[Token(Token = "0x6000623")]
	[Address(RVA = "0x1320890", Offset = "0x1320890", VA = "0x1320890")]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0x1320A34", Offset = "0x1320A34", VA = "0x1320A34")]
	[IteratorStateMachine(typeof(<CalculateDistance>d__8))]
	public IEnumerator CalculateDistance()
	{
		return null;
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0x1320AD0", Offset = "0x1320AD0", VA = "0x1320AD0")]
	private void OnTriggerExit(Collider collider)
	{
	}

	[Token(Token = "0x6000626")]
	[Address(RVA = "0x1320BC8", Offset = "0x1320BC8", VA = "0x1320BC8")]
	private void OnDisabled()
	{
	}

	[Token(Token = "0x6000627")]
	[Address(RVA = "0x1320BCC", Offset = "0x1320BCC", VA = "0x1320BCC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000628")]
	[Address(RVA = "0x1320B44", Offset = "0x1320B44", VA = "0x1320B44")]
	private void Disable()
	{
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0x1320BD0", Offset = "0x1320BD0", VA = "0x1320BD0")]
	public NearDisplayLogic()
	{
	}
}
[Token(Token = "0x2000132")]
public class NearTouchInteract : MonoBehaviour
{
	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRTK_InteractableObject controllerEvents;

	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private HandsReorganizer hands;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool nearTouch;

	[Token(Token = "0x6000630")]
	[Address(RVA = "0x1320DA4", Offset = "0x1320DA4", VA = "0x1320DA4")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000631")]
	[Address(RVA = "0x1320F68", Offset = "0x1320F68", VA = "0x1320F68")]
	private void UnGrabObject(object o, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000632")]
	[Address(RVA = "0x1320FCC", Offset = "0x1320FCC", VA = "0x1320FCC")]
	private void GrabObject(object o, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000633")]
	[Address(RVA = "0x1321030", Offset = "0x1321030", VA = "0x1321030")]
	private void NearTouch(object o, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000634")]
	[Address(RVA = "0x13210A0", Offset = "0x13210A0", VA = "0x13210A0")]
	private void NearUnTouch(object o, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000635")]
	[Address(RVA = "0x13210A8", Offset = "0x13210A8", VA = "0x13210A8")]
	private void UnTouch(object o, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000636")]
	[Address(RVA = "0x13210B0", Offset = "0x13210B0", VA = "0x13210B0")]
	public NearTouchInteract()
	{
	}
}
[Token(Token = "0x2000133")]
public class PhyzicRotator : MonoBehaviour
{
	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Rigidbody m_Rigidbody;

	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 m_EulerAngleVelocity;

	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float followRotationStrength;

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 rotationOffset;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform moveTo;

	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float angle;

	[Token(Token = "0x6000637")]
	[Address(RVA = "0x13210B8", Offset = "0x13210B8", VA = "0x13210B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000638")]
	[Address(RVA = "0x1321198", Offset = "0x1321198", VA = "0x1321198")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000639")]
	[Address(RVA = "0x13211F4", Offset = "0x13211F4", VA = "0x13211F4")]
	private void TorqueTo()
	{
	}

	[Token(Token = "0x600063A")]
	[Address(RVA = "0x132124C", Offset = "0x132124C", VA = "0x132124C")]
	public Vector3 ComputeTorque(Quaternion desiredRotation)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600063B")]
	[Address(RVA = "0x1321560", Offset = "0x1321560", VA = "0x1321560")]
	public PhyzicRotator()
	{
	}
}
[Token(Token = "0x2000134")]
[RequireComponent(typeof(MeshSimplify))]
public class RuntimeMeshSimplifier : MonoBehaviour
{
	[Token(Token = "0x2000135")]
	[CompilerGenerated]
	private sealed class <ComputeMeshWithVertices>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RuntimeMeshSimplifier <>4__this;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fAmount;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<GameObject, Material[]>.Enumerator <>7__wrap1;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private KeyValuePair<GameObject, Material[]> <pair>5__3;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MeshSimplify <meshSimplify>5__4;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private MeshFilter <meshFilter>5__5;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private SkinnedMeshRenderer <skin>5__6;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Mesh <newMesh>5__7;

		[Token(Token = "0x17000099")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x1322734", Offset = "0x1322734", VA = "0x1322734", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600064C")]
			[Address(RVA = "0x132277C", Offset = "0x132277C", VA = "0x132277C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1321A60", Offset = "0x1321A60", VA = "0x1321A60")]
		[DebuggerHidden]
		public <ComputeMeshWithVertices>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1321AF8", Offset = "0x1321AF8", VA = "0x1321AF8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1321B24", Offset = "0x1321B24", VA = "0x1321B24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x13226E4", Offset = "0x13226E4", VA = "0x13226E4")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x132273C", Offset = "0x132273C", VA = "0x132273C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<GameObject, Material[]> m_objectMaterials;

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshSimplify m_selectedMeshSimplify;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_bFinished;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Mesh m_newMesh;

	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int m_nLastProgress;

	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string m_strLastTitle;

	[Token(Token = "0x40005C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string m_strLastMessage;

	[Token(Token = "0x17000095")]
	public string ProgressTitle
	{
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1321570", Offset = "0x1321570", VA = "0x1321570")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000096")]
	public string ProgressMessage
	{
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1321578", Offset = "0x1321578", VA = "0x1321578")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000097")]
	public int ProgressPercent
	{
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1321580", Offset = "0x1321580", VA = "0x1321580")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000098")]
	public bool Finished
	{
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1321588", Offset = "0x1321588", VA = "0x1321588")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000640")]
	[Address(RVA = "0x1321590", Offset = "0x1321590", VA = "0x1321590")]
	public void Simplify(float percent)
	{
	}

	[Token(Token = "0x6000641")]
	[Address(RVA = "0x1321664", Offset = "0x1321664", VA = "0x1321664")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000642")]
	[Address(RVA = "0x1321744", Offset = "0x1321744", VA = "0x1321744")]
	private void AddMaterials(GameObject theGameObject, Dictionary<GameObject, Material[]> dicMaterials)
	{
	}

	[Token(Token = "0x6000643")]
	[Address(RVA = "0x132190C", Offset = "0x132190C", VA = "0x132190C")]
	private void Progress(string strTitle, string strMessage, float fT)
	{
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0x13215E0", Offset = "0x13215E0", VA = "0x13215E0")]
	[IteratorStateMachine(typeof(<ComputeMeshWithVertices>d__12))]
	private IEnumerator ComputeMeshWithVertices(float fAmount)
	{
		return null;
	}

	[Token(Token = "0x6000645")]
	[Address(RVA = "0x1321A88", Offset = "0x1321A88", VA = "0x1321A88")]
	public RuntimeMeshSimplifier()
	{
	}
}
[Token(Token = "0x2000136")]
public class Spawner : MonoBehaviour
{
	[Token(Token = "0x40005CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject objectToSpawn;

	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float space;

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int howMuch;

	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int howMuchLevels;

	[Token(Token = "0x40005D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 pos;

	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private MaterialPropertyBlock _propBlock;

	[Token(Token = "0x600064D")]
	[Address(RVA = "0x1322784", Offset = "0x1322784", VA = "0x1322784")]
	private void Start()
	{
	}

	[Token(Token = "0x600064E")]
	[Address(RVA = "0x1322AC4", Offset = "0x1322AC4", VA = "0x1322AC4")]
	private void Update()
	{
	}

	[Token(Token = "0x600064F")]
	[Address(RVA = "0x1322AC8", Offset = "0x1322AC8", VA = "0x1322AC8")]
	public Spawner()
	{
	}
}
[Token(Token = "0x2000137")]
public class ShowPopupInfo : MonoBehaviour
{
	[Token(Token = "0x6000650")]
	[Address(RVA = "0x1322AE8", Offset = "0x1322AE8", VA = "0x1322AE8")]
	public ShowPopupInfo()
	{
	}
}
[Token(Token = "0x2000138")]
public class controllerHint : MonoBehaviour
{
	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string buttonToHint;

	[Token(Token = "0x6000651")]
	[Address(RVA = "0x1322AF0", Offset = "0x1322AF0", VA = "0x1322AF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000652")]
	[Address(RVA = "0x1322FA8", Offset = "0x1322FA8", VA = "0x1322FA8")]
	public controllerHint()
	{
	}
}
[Token(Token = "0x2000139")]
public class HoldButtonHeight : MonoBehaviour
{
	[Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class <ChangeHeight>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HoldButtonHeight <>4__this;

		[Token(Token = "0x1700009B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x13231EC", Offset = "0x13231EC", VA = "0x13231EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600065D")]
			[Address(RVA = "0x1323234", Offset = "0x1323234", VA = "0x1323234", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1323098", Offset = "0x1323098", VA = "0x1323098")]
		[DebuggerHidden]
		public <ChangeHeight>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x13230C8", Offset = "0x13230C8", VA = "0x13230C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x13230CC", Offset = "0x13230CC", VA = "0x13230CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x13231F4", Offset = "0x13231F4", VA = "0x13231F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRSettingsWindow settingsAndTutorialWindow;

	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool up;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool buttonPressed;

	[Token(Token = "0x6000653")]
	[Address(RVA = "0x1322FB0", Offset = "0x1322FB0", VA = "0x1322FB0")]
	public void OnMove(AxisEventData eventData)
	{
	}

	[Token(Token = "0x6000654")]
	[Address(RVA = "0x1322FF0", Offset = "0x1322FF0", VA = "0x1322FF0")]
	public void OnPointerDown()
	{
	}

	[Token(Token = "0x6000655")]
	[Address(RVA = "0x132308C", Offset = "0x132308C", VA = "0x132308C")]
	public void OnPointerUp()
	{
	}

	[Token(Token = "0x6000656")]
	[Address(RVA = "0x1323018", Offset = "0x1323018", VA = "0x1323018")]
	[IteratorStateMachine(typeof(<ChangeHeight>d__6))]
	private IEnumerator ChangeHeight()
	{
		return null;
	}

	[Token(Token = "0x6000657")]
	[Address(RVA = "0x13230C0", Offset = "0x13230C0", VA = "0x13230C0")]
	public HoldButtonHeight()
	{
	}
}
[Token(Token = "0x200013B")]
public class startRadioInTutorialScene : MonoBehaviour
{
	[Token(Token = "0x600065E")]
	[Address(RVA = "0x132323C", Offset = "0x132323C", VA = "0x132323C")]
	private void Start()
	{
	}

	[Token(Token = "0x600065F")]
	[Address(RVA = "0x13232D8", Offset = "0x13232D8", VA = "0x13232D8")]
	public startRadioInTutorialScene()
	{
	}
}
[Token(Token = "0x200013C")]
public class TutorialVRDestinationPoint : VRTK_DestinationPoint
{
	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public VRTutorialWindow vrTutorialWindow;

	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public int taskNR;

	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Transform tabletPositionAfterTeleport;

	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private bool canOpenInfoWindow;

	[Token(Token = "0x6000660")]
	[Address(RVA = "0x13232E0", Offset = "0x13232E0", VA = "0x13232E0", Slot = "31")]
	protected override void DoDestinationMarkerSet(object sender, DestinationMarkerEventArgs e)
	{
	}

	[Token(Token = "0x6000661")]
	[Address(RVA = "0x1323614", Offset = "0x1323614", VA = "0x1323614", Slot = "23")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000662")]
	[Address(RVA = "0x13234D0", Offset = "0x13234D0", VA = "0x13234D0")]
	private void MoveTablet()
	{
	}

	[Token(Token = "0x6000663")]
	[Address(RVA = "0x1323800", Offset = "0x1323800", VA = "0x1323800")]
	public TutorialVRDestinationPoint()
	{
	}
}
[Token(Token = "0x200013D")]
public class VRTutorialController : MonoBehaviour
{
	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private VRTK_PhysicsPusher buttonBack;

	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private VRTK_PhysicsPusher buttonNext;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private VRTK_PhysicsPusher buttonYT;

	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float buttonPressValue;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private VRSettingsWindow tutorialMenuManager;

	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool flag1;

	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool flag2;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	private bool flag3;

	[Token(Token = "0x6000664")]
	[Address(RVA = "0x1323810", Offset = "0x1323810", VA = "0x1323810")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000665")]
	[Address(RVA = "0x132390C", Offset = "0x132390C", VA = "0x132390C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000666")]
	[Address(RVA = "0x1323A08", Offset = "0x1323A08", VA = "0x1323A08", Slot = "4")]
	protected virtual void ValueChangedButtonBack(object sender, ControllableEventArgs e)
	{
	}

	[Token(Token = "0x6000667")]
	[Address(RVA = "0x1323A74", Offset = "0x1323A74", VA = "0x1323A74", Slot = "5")]
	protected virtual void ValueChangedButtonNext(object sender, ControllableEventArgs e)
	{
	}

	[Token(Token = "0x6000668")]
	[Address(RVA = "0x1323AE0", Offset = "0x1323AE0", VA = "0x1323AE0", Slot = "6")]
	protected virtual void ValueChangedButtonYT(object sender, ControllableEventArgs e)
	{
	}

	[Token(Token = "0x6000669")]
	[Address(RVA = "0x1323B58", Offset = "0x1323B58", VA = "0x1323B58")]
	public VRTutorialController()
	{
	}
}
[Token(Token = "0x200013E")]
public class Mg_consoleController : MonoBehaviour
{
	[Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class <GameOn>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mg_consoleController <>4__this;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <i>5__2;

		[Token(Token = "0x1700009D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x1323FDC", Offset = "0x1323FDC", VA = "0x1323FDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x1324024", Offset = "0x1324024", VA = "0x1324024", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1323DA0", Offset = "0x1323DA0", VA = "0x1323DA0")]
		[DebuggerHidden]
		public <GameOn>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1323E4C", Offset = "0x1323E4C", VA = "0x1323E4C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1323E50", Offset = "0x1323E50", VA = "0x1323E50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1323FE4", Offset = "0x1323FE4", VA = "0x1323FE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class <GameOff>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mg_consoleController <>4__this;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <i>5__2;

		[Token(Token = "0x1700009F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x1325180", Offset = "0x1325180", VA = "0x1325180", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x13251C8", Offset = "0x13251C8", VA = "0x13251C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x132502C", Offset = "0x132502C", VA = "0x132502C")]
		[DebuggerHidden]
		public <GameOff>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x1325054", Offset = "0x1325054", VA = "0x1325054", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1325058", Offset = "0x1325058", VA = "0x1325058", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1325188", Offset = "0x1325188", VA = "0x1325188", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private VRTK_FixedJointGrabAttach grabAttach;

	[Token(Token = "0x40005E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject screenCanvas;

	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool controllerGrabbed;

	[Token(Token = "0x40005E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float scaleSpeed;

	[Token(Token = "0x600066A")]
	[Address(RVA = "0x1323B74", Offset = "0x1323B74", VA = "0x1323B74")]
	private void Start()
	{
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0x1323BCC", Offset = "0x1323BCC", VA = "0x1323BCC")]
	private void Update()
	{
	}

	[Token(Token = "0x600066C")]
	[Address(RVA = "0x1323D44", Offset = "0x1323D44", VA = "0x1323D44")]
	private void ControllerEvents_TriggerPressed(object sender, ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x600066D")]
	[Address(RVA = "0x1323CD0", Offset = "0x1323CD0", VA = "0x1323CD0")]
	[IteratorStateMachine(typeof(<GameOn>d__7))]
	public IEnumerator GameOn()
	{
		return null;
	}

	[Token(Token = "0x600066E")]
	[Address(RVA = "0x1323DC8", Offset = "0x1323DC8", VA = "0x1323DC8")]
	[IteratorStateMachine(typeof(<GameOff>d__8))]
	public IEnumerator GameOff()
	{
		return null;
	}

	[Token(Token = "0x600066F")]
	[Address(RVA = "0x1323E3C", Offset = "0x1323E3C", VA = "0x1323E3C")]
	public Mg_consoleController()
	{
	}
}
[Token(Token = "0x2000141")]
public class Mg_Controller : MonoBehaviour
{
	[Token(Token = "0x40005F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Action onInput;

	[Token(Token = "0x40005F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Rigidbody2D rb;

	[Token(Token = "0x40005F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip clip;

	[Token(Token = "0x40005F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float power;

	[Token(Token = "0x40005F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool m_isGrounded;

	[Token(Token = "0x40005F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator animator;

	[Token(Token = "0x40005F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject spriteHolder;

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector2 startPosition;

	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioSource audioSource;

	[Token(Token = "0x170000A1")]
	public bool isGrounded
	{
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x13251D0", Offset = "0x13251D0", VA = "0x13251D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600067D")]
	[Address(RVA = "0x13251EC", Offset = "0x13251EC", VA = "0x13251EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600067E")]
	[Address(RVA = "0x1325410", Offset = "0x1325410", VA = "0x1325410")]
	private void InputProcessing()
	{
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0x1325534", Offset = "0x1325534", VA = "0x1325534")]
	private void Update()
	{
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0x13255A0", Offset = "0x13255A0", VA = "0x13255A0")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6000681")]
	[Address(RVA = "0x13256B0", Offset = "0x13256B0", VA = "0x13256B0")]
	private void OnCollisionStay2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0x1325734", Offset = "0x1325734", VA = "0x1325734")]
	private void OnCollisionExit2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6000683")]
	[Address(RVA = "0x13257AC", Offset = "0x13257AC", VA = "0x13257AC")]
	public void ReloadPlayer()
	{
	}

	[Token(Token = "0x6000684")]
	[Address(RVA = "0x13258C4", Offset = "0x13258C4", VA = "0x13258C4")]
	public Mg_Controller()
	{
	}
}
[Token(Token = "0x2000142")]
public class Mg_GameManager : MonoBehaviour
{
	[Token(Token = "0x2000143")]
	public enum GameState
	{
		[Token(Token = "0x400060C")]
		inProgress,
		[Token(Token = "0x400060D")]
		WaitForInput,
		[Token(Token = "0x400060E")]
		GameOver
	}

	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] grounds;

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] clouds;

	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<GameObject> obstacles;

	[Token(Token = "0x40005FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject obstacleParent;

	[Token(Token = "0x40005FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int score;

	[Token(Token = "0x40005FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Action onStartGame;

	[Token(Token = "0x4000600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static GameObject MGHolder;

	[Token(Token = "0x4000601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static Vector3 MotionVector;

	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 StartMotionVector;

	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float t;

	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float obstacleTimeOffset;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float obstacleTimer;

	[Token(Token = "0x4000606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float curObstacleTimer;

	[Token(Token = "0x4000607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float startObstacleTimer;

	[Token(Token = "0x4000608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public static GameState gameState;

	[Token(Token = "0x4000609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float groundOffset;

	[Token(Token = "0x400060A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float skyOffset;

	[Token(Token = "0x6000685")]
	[Address(RVA = "0x13258CC", Offset = "0x13258CC", VA = "0x13258CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000686")]
	[Address(RVA = "0x1325ACC", Offset = "0x1325ACC", VA = "0x1325ACC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000687")]
	[Address(RVA = "0x1325BE4", Offset = "0x1325BE4", VA = "0x1325BE4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000688")]
	[Address(RVA = "0x1325EDC", Offset = "0x1325EDC", VA = "0x1325EDC")]
	private void SpawnObstacle()
	{
	}

	[Token(Token = "0x6000689")]
	[Address(RVA = "0x13260EC", Offset = "0x13260EC", VA = "0x13260EC")]
	private void FasterGame()
	{
	}

	[Token(Token = "0x600068A")]
	[Address(RVA = "0x1326184", Offset = "0x1326184", VA = "0x1326184")]
	public void StartNewGame()
	{
	}

	[Token(Token = "0x600068B")]
	[Address(RVA = "0x13261F0", Offset = "0x13261F0", VA = "0x13261F0")]
	public Mg_GameManager()
	{
	}
}
[Token(Token = "0x2000144")]
public class Mg_Ground : Mg_MovingObject
{
	[Token(Token = "0x400060F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform nextGround;

	[Token(Token = "0x600068C")]
	[Address(RVA = "0x132620C", Offset = "0x132620C", VA = "0x132620C")]
	private new void FixedUpdate()
	{
	}

	[Token(Token = "0x600068D")]
	[Address(RVA = "0x1326210", Offset = "0x1326210", VA = "0x1326210")]
	public Mg_Ground()
	{
	}
}
[Token(Token = "0x2000145")]
public class Mg_HandScript : VRTK_InteractGrab
{
	[Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class <GameOn>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mg_HandScript <>4__this;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool on;

		[Token(Token = "0x170000A2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x1326938", Offset = "0x1326938", VA = "0x1326938", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x1326980", Offset = "0x1326980", VA = "0x1326980", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x1326704", Offset = "0x1326704", VA = "0x1326704")]
		[DebuggerHidden]
		public <GameOn>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1326764", Offset = "0x1326764", VA = "0x1326764", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1326768", Offset = "0x1326768", VA = "0x1326768", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1326940", Offset = "0x1326940", VA = "0x1326940", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class <TurnOff>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mg_HandScript <>4__this;

		[Token(Token = "0x170000A4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x1326A50", Offset = "0x1326A50", VA = "0x1326A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x1326A98", Offset = "0x1326A98", VA = "0x1326A98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x132672C", Offset = "0x132672C", VA = "0x132672C")]
		[DebuggerHidden]
		public <TurnOff>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x1326988", Offset = "0x1326988", VA = "0x1326988", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x132698C", Offset = "0x132698C", VA = "0x132698C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1326A58", Offset = "0x1326A58", VA = "0x1326A58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000610")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject screenCanvas;

	[Token(Token = "0x4000611")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject mgHolder;

	[Token(Token = "0x4000612")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private int delayTurnOffTimer;

	[Token(Token = "0x600068E")]
	[Address(RVA = "0x1326230", Offset = "0x1326230", VA = "0x1326230")]
	private void Start()
	{
	}

	[Token(Token = "0x600068F")]
	[Address(RVA = "0x1326390", Offset = "0x1326390", VA = "0x1326390")]
	private void Mg_HandScript_ControllerUngrabInteractableObject(object sender, ObjectInteractEventArgs e)
	{
	}

	[Token(Token = "0x6000690")]
	[Address(RVA = "0x1326518", Offset = "0x1326518", VA = "0x1326518")]
	private void Mg_HandScript_ControllerStartGrabInteractableObject(object sender, ObjectInteractEventArgs e, float[] fingers, bool precisionGrab)
	{
	}

	[Token(Token = "0x6000691")]
	[Address(RVA = "0x13266A8", Offset = "0x13266A8", VA = "0x13266A8")]
	private void ControllerEvents_TriggerPressed(object sender, ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x6000692")]
	[Address(RVA = "0x1326620", Offset = "0x1326620", VA = "0x1326620")]
	[IteratorStateMachine(typeof(<GameOn>d__7))]
	public IEnumerator GameOn(bool on)
	{
		return null;
	}

	[Token(Token = "0x6000693")]
	[Address(RVA = "0x13264A4", Offset = "0x13264A4", VA = "0x13264A4")]
	[IteratorStateMachine(typeof(<TurnOff>d__8))]
	public IEnumerator TurnOff()
	{
		return null;
	}

	[Token(Token = "0x6000694")]
	[Address(RVA = "0x1326754", Offset = "0x1326754", VA = "0x1326754")]
	public Mg_HandScript()
	{
	}
}
[Token(Token = "0x2000148")]
public class Mg_MovingObject : MonoBehaviour
{
	[Token(Token = "0x400061A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speedScale;

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x1326AA0", Offset = "0x1326AA0", VA = "0x1326AA0")]
	public void FixedUpdate()
	{
	}

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x1326220", Offset = "0x1326220", VA = "0x1326220")]
	public Mg_MovingObject()
	{
	}
}
[Token(Token = "0x2000149")]
public class Mg_Obstacle : Mg_MovingObject
{
	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x1326B6C", Offset = "0x1326B6C", VA = "0x1326B6C")]
	private void Start()
	{
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x1326C48", Offset = "0x1326C48", VA = "0x1326C48")]
	private new void FixedUpdate()
	{
	}

	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x1326DB4", Offset = "0x1326DB4", VA = "0x1326DB4")]
	public Mg_Obstacle()
	{
	}
}
[Token(Token = "0x200014A")]
public class Mg_UIManager : MonoBehaviour
{
	[Token(Token = "0x400061B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject scorePanel;

	[Token(Token = "0x400061C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject endPanel;

	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject newRecordTitle;

	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text helloText;

	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text scoreText;

	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text scoreRecordText;

	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text endScoreText;

	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text recordText;

	[Token(Token = "0x4000623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Action onGameOver;

	[Token(Token = "0x4000624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int currentRecord;

	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x1326DC4", Offset = "0x1326DC4", VA = "0x1326DC4")]
	private void Start()
	{
	}

	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x1326F94", Offset = "0x1326F94", VA = "0x1326F94")]
	private void Update()
	{
	}

	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x1327070", Offset = "0x1327070", VA = "0x1327070")]
	private void GameOver()
	{
	}

	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x13271AC", Offset = "0x13271AC", VA = "0x13271AC")]
	public void StartNewGame()
	{
	}

	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x132724C", Offset = "0x132724C", VA = "0x132724C")]
	public Mg_UIManager()
	{
	}
}
[Token(Token = "0x200014B")]
public class MiniGameManager : MonoBehaviour
{
	[Token(Token = "0x60006AB")]
	[Address(RVA = "0x1327254", Offset = "0x1327254", VA = "0x1327254")]
	public MiniGameManager()
	{
	}
}
[Token(Token = "0x200014C")]
public class SnapScrolling : MonoBehaviour
{
	[Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class <Snapping>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SnapScrolling <>4__this;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <index>5__2;

		[Token(Token = "0x170000A6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x1328158", Offset = "0x1328158", VA = "0x1328158", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x13281A0", Offset = "0x13281A0", VA = "0x13281A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1327E84", Offset = "0x1327E84", VA = "0x1327E84")]
		[DebuggerHidden]
		public <Snapping>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x1327F84", Offset = "0x1327F84", VA = "0x1327F84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x1327F88", Offset = "0x1327F88", VA = "0x1327F88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1328160", Offset = "0x1328160", VA = "0x1328160", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000625")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RectTransform[] panels;

	[Token(Token = "0x4000626")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RectTransform content;

	[Token(Token = "0x4000627")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float snapSpeed;

	[Token(Token = "0x4000628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public VRTK_UIPointer uIPointer;

	[Token(Token = "0x4000629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform container;

	[Token(Token = "0x400062A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text levelText;

	[Token(Token = "0x400062B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text expText;

	[Token(Token = "0x400062C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text expToNextLvlText;

	[Token(Token = "0x400062D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Text moneyText;

	[Token(Token = "0x400062E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Text ordersText;

	[Token(Token = "0x400062F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Text notificationsText;

	[Token(Token = "0x4000630")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Text levelTextToCopy;

	[Token(Token = "0x4000631")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Text expTextToCopy;

	[Token(Token = "0x4000632")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Text expToNextLvlTextToCopy;

	[Token(Token = "0x4000633")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Text moneyTextToCopy;

	[Token(Token = "0x4000634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Text ordersTextToCopy;

	[Token(Token = "0x4000635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int _nearestIndex;

	[Token(Token = "0x4000636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector2 contentVector;

	[Token(Token = "0x4000637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private bool isScroll;

	[Token(Token = "0x4000638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float panelWidth;

	[Token(Token = "0x60006AC")]
	[Address(RVA = "0x132725C", Offset = "0x132725C", VA = "0x132725C")]
	private void Start()
	{
	}

	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x1327368", Offset = "0x1327368", VA = "0x1327368")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x1327708", Offset = "0x1327708", VA = "0x1327708")]
	public void TogglePanels(int scale)
	{
	}

	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x13277AC", Offset = "0x13277AC", VA = "0x13277AC")]
	public void UpdateWatchUI()
	{
	}

	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x1327CC0", Offset = "0x1327CC0", VA = "0x1327CC0")]
	private void UIPointer_UIPointerElementExit(object sender, UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x1327D88", Offset = "0x1327D88", VA = "0x1327D88")]
	public int NearestIndex()
	{
		return default(int);
	}

	[Token(Token = "0x60006B2")]
	[Address(RVA = "0x1327E10", Offset = "0x1327E10", VA = "0x1327E10")]
	[IteratorStateMachine(typeof(<Snapping>d__26))]
	public IEnumerator Snapping()
	{
		return null;
	}

	[Token(Token = "0x60006B3")]
	[Address(RVA = "0x1327CC8", Offset = "0x1327CC8", VA = "0x1327CC8")]
	public void isScrolling(bool isScr)
	{
	}

	[Token(Token = "0x60006B4")]
	[Address(RVA = "0x1327EAC", Offset = "0x1327EAC", VA = "0x1327EAC")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60006B5")]
	[Address(RVA = "0x1327F7C", Offset = "0x1327F7C", VA = "0x1327F7C")]
	public SnapScrolling()
	{
	}
}
[Token(Token = "0x200014E")]
public class Wearable : MonoBehaviour
{
	[Token(Token = "0x400063D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject snapParent;

	[Token(Token = "0x400063E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform correctPosition;

	[Token(Token = "0x400063F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool done;

	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x13281A8", Offset = "0x13281A8", VA = "0x13281A8")]
	private void Update()
	{
	}

	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x132833C", Offset = "0x132833C", VA = "0x132833C")]
	public Wearable()
	{
	}
}
[Token(Token = "0x200014F")]
public class WelderMask : Wearable
{
	[Token(Token = "0x60006BE")]
	[Address(RVA = "0x1328344", Offset = "0x1328344", VA = "0x1328344")]
	private void Start()
	{
	}

	[Token(Token = "0x60006BF")]
	[Address(RVA = "0x1328348", Offset = "0x1328348", VA = "0x1328348")]
	private void Update()
	{
	}

	[Token(Token = "0x60006C0")]
	[Address(RVA = "0x132834C", Offset = "0x132834C", VA = "0x132834C")]
	public WelderMask()
	{
	}
}
[Token(Token = "0x2000150")]
public class Blocker : VRTK_InteractableObject
{
	[Token(Token = "0x4000640")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[SerializeField]
	private GameObject handleControl;

	[Token(Token = "0x4000641")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private VRTK_InteractableObject handleIO;

	[Token(Token = "0x4000642")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private VRTK_RotatorTrackGrabAttach rotatorGrabAttach;

	[Token(Token = "0x4000643")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private VRTK_MoveTransformGrabAttach sliderGrabAttach;

	[Token(Token = "0x4000644")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private float startPosY;

	[Token(Token = "0x60006C1")]
	[Address(RVA = "0x1328354", Offset = "0x1328354", VA = "0x1328354", Slot = "66")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60006C2")]
	[Address(RVA = "0x1328444", Offset = "0x1328444", VA = "0x1328444", Slot = "29")]
	public override void Ungrabbed([Optional] VRTK_InteractGrab previousGrabbingObject)
	{
	}

	[Token(Token = "0x60006C3")]
	[Address(RVA = "0x1328460", Offset = "0x1328460", VA = "0x1328460")]
	private void ChangeHandleGrabAttachMechanism()
	{
	}

	[Token(Token = "0x60006C4")]
	[Address(RVA = "0x1328580", Offset = "0x1328580", VA = "0x1328580")]
	public Blocker()
	{
	}
}
[Token(Token = "0x2000151")]
public class CreatePartForTest : MonoBehaviour
{
	[Token(Token = "0x4000645")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject objectToCopy;

	[Token(Token = "0x60006C5")]
	[Address(RVA = "0x1328588", Offset = "0x1328588", VA = "0x1328588")]
	private void Start()
	{
	}

	[Token(Token = "0x60006C6")]
	[Address(RVA = "0x1328B30", Offset = "0x1328B30", VA = "0x1328B30")]
	private void Update()
	{
	}

	[Token(Token = "0x60006C7")]
	[Address(RVA = "0x1328590", Offset = "0x1328590", VA = "0x1328590")]
	private void PreparePartClone(GameObject part)
	{
	}

	[Token(Token = "0x60006C8")]
	[Address(RVA = "0x1328B34", Offset = "0x1328B34", VA = "0x1328B34")]
	public CreatePartForTest()
	{
	}
}
[Token(Token = "0x2000152")]
public class DoNotCollide : MonoBehaviour
{
	[Token(Token = "0x4000646")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject[] ignoreCollisionWith;

	[Token(Token = "0x4000647")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Collider[] colliders;

	[Token(Token = "0x60006C9")]
	[Address(RVA = "0x1328B3C", Offset = "0x1328B3C", VA = "0x1328B3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x1328C94", Offset = "0x1328C94", VA = "0x1328C94")]
	public DoNotCollide()
	{
	}
}
[Token(Token = "0x2000153")]
public class DrawersTriggersController : MonoBehaviour, IInteractableCarrier
{
	[Token(Token = "0x4000648")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float triggerOffset;

	[Token(Token = "0x4000649")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject toolboxControllerObject;

	[Token(Token = "0x400064A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private IInteractableCarrier toolboxController;

	[Token(Token = "0x400064B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private VRTK_InteractableObject[] drawers;

	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x1328C9C", Offset = "0x1328C9C", VA = "0x1328C9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x1328FFC", Offset = "0x1328FFC", VA = "0x1328FFC", Slot = "4")]
	public void PlaceInteractable(Transform transform, VRTK_InteractableObject io)
	{
	}

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x132910C", Offset = "0x132910C", VA = "0x132910C", Slot = "5")]
	public void RemoveInteractable(VRTK_InteractableObject io)
	{
	}

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x1329208", Offset = "0x1329208", VA = "0x1329208")]
	public DrawersTriggersController()
	{
	}
}
[Token(Token = "0x2000154")]
public class DrawerTrigger : MonoBehaviour
{
	[Token(Token = "0x400064C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private IInteractableCarrier interactableCarrier;

	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x1329260", Offset = "0x1329260", VA = "0x1329260")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x13294BC", Offset = "0x13294BC", VA = "0x13294BC")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x1329670", Offset = "0x1329670", VA = "0x1329670")]
	public void SetToolboxController(IInteractableCarrier toolboxController)
	{
	}

	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x1329678", Offset = "0x1329678", VA = "0x1329678")]
	public DrawerTrigger()
	{
	}
}
[Token(Token = "0x2000155")]
public class DynoDoorHandle : VRTK_InteractableObject
{
	[Token(Token = "0x2000156")]
	[CompilerGenerated]
	private sealed class <UpdateHingePosition>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DynoDoorHandle <>4__this;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <lastfraction>5__2;

		[Token(Token = "0x170000A8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x1329F5C", Offset = "0x1329F5C", VA = "0x1329F5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x1329FA4", Offset = "0x1329FA4", VA = "0x1329FA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x13297EC", Offset = "0x13297EC", VA = "0x13297EC")]
		[DebuggerHidden]
		public <UpdateHingePosition>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1329C34", Offset = "0x1329C34", VA = "0x1329C34", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1329C38", Offset = "0x1329C38", VA = "0x1329C38", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1329F64", Offset = "0x1329F64", VA = "0x1329F64", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class <ApplySpeedAfterUngrab>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DynoDoorHandle <>4__this;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <isVelocityNegative>5__2;

		[Token(Token = "0x170000AA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x132A120", Offset = "0x132A120", VA = "0x132A120", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x132A168", Offset = "0x132A168", VA = "0x132A168", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1329814", Offset = "0x1329814", VA = "0x1329814")]
		[DebuggerHidden]
		public <ApplySpeedAfterUngrab>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x1329FAC", Offset = "0x1329FAC", VA = "0x1329FAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1329FB0", Offset = "0x1329FB0", VA = "0x1329FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x132A128", Offset = "0x132A128", VA = "0x132A128", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400064D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public float dist;

	[Token(Token = "0x400064E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	public Vector3 startPoint;

	[Token(Token = "0x400064F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public Vector3 endPoint;

	[Token(Token = "0x4000650")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public AnimationCurve curve;

	[Token(Token = "0x4000651")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public Animator animator;

	[Token(Token = "0x4000652")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private float fraction;

	[Token(Token = "0x4000653")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	private float velocity;

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x1329680", Offset = "0x1329680", VA = "0x1329680", Slot = "66")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x13296AC", Offset = "0x13296AC", VA = "0x13296AC", Slot = "27")]
	public override void Grabbed([Optional] VRTK_InteractGrab currentGrabbingObject)
	{
	}

	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x132974C", Offset = "0x132974C", VA = "0x132974C", Slot = "29")]
	public override void Ungrabbed([Optional] VRTK_InteractGrab previousGrabbingObject)
	{
	}

	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x13296D8", Offset = "0x13296D8", VA = "0x13296D8")]
	[IteratorStateMachine(typeof(<UpdateHingePosition>d__10))]
	private IEnumerator UpdateHingePosition()
	{
		return null;
	}

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x1329778", Offset = "0x1329778", VA = "0x1329778")]
	[IteratorStateMachine(typeof(<ApplySpeedAfterUngrab>d__11))]
	private IEnumerator ApplySpeedAfterUngrab()
	{
		return null;
	}

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x132983C", Offset = "0x132983C", VA = "0x132983C")]
	private Vector3 ProjectPointOnLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x1329A18", Offset = "0x1329A18", VA = "0x1329A18")]
	private Vector3 ProjectPointOnLine(Vector3 linePoint, Vector3 lineVec, Vector3 point)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x1329A5C", Offset = "0x1329A5C", VA = "0x1329A5C")]
	private int PointOnWhichSideOfLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
	{
		return default(int);
	}

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x1329B7C", Offset = "0x1329B7C", VA = "0x1329B7C")]
	private float Spring(float from, float to, float time)
	{
		return default(float);
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x1329C2C", Offset = "0x1329C2C", VA = "0x1329C2C")]
	public DynoDoorHandle()
	{
	}
}
[Token(Token = "0x2000158")]
public class DynoDoorHinge : MonoBehaviour
{
	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform wall;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform handle;

	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("In what direction the hinge should move")]
	public Vector3 axis;

	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float startDist;

	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 startPos;

	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x132A170", Offset = "0x132A170", VA = "0x132A170")]
	private void Start()
	{
	}

	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x132A308", Offset = "0x132A308", VA = "0x132A308")]
	public void UpdateHinge()
	{
	}

	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x132A4F4", Offset = "0x132A4F4", VA = "0x132A4F4")]
	private void CalculatePoints_H(Vector3 c1p, Vector3 c2p, float c1r, float c2r, out Vector3 startLine, out Vector3 endLine)
	{
	}

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x132A648", Offset = "0x132A648", VA = "0x132A648")]
	public DynoDoorHinge()
	{
	}
}
[Token(Token = "0x2000159")]
public class Engine_stand_handle : VRTK_InteractableObject
{
	[Token(Token = "0x4000661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private float _localX;

	[Token(Token = "0x4000662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	private float _localY;

	[Token(Token = "0x4000663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private float _localZ;

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x132A650", Offset = "0x132A650", VA = "0x132A650", Slot = "72")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x132A6BC", Offset = "0x132A6BC", VA = "0x132A6BC")]
	public Engine_stand_handle()
	{
	}
}
[Token(Token = "0x200015A")]
public class Engine_stand_io : MonoBehaviour
{
	[Token(Token = "0x4000664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject workingSpace;

	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x132A6C4", Offset = "0x132A6C4", VA = "0x132A6C4")]
	protected void Start()
	{
	}

	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x132A6C8", Offset = "0x132A6C8", VA = "0x132A6C8")]
	private void AddWorkingSpaceTrigger()
	{
	}

	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x132AAD4", Offset = "0x132AAD4", VA = "0x132AAD4")]
	public Engine_stand_io()
	{
	}
}
[Token(Token = "0x200015B")]
public class Engine_stand_threshold : MonoBehaviour
{
	[Token(Token = "0x4000665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject handleControl;

	[Token(Token = "0x4000666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VRTK_InteractableObject handleIO;

	[Token(Token = "0x4000667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private VRTK_RotatorTrackGrabAttach rotatorGrabAttach;

	[Token(Token = "0x4000668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private VRTK_MoveTransformGrabAttach sliderGrabAttach;

	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x132AADC", Offset = "0x132AADC", VA = "0x132AADC")]
	private void Start()
	{
	}

	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x132ABAC", Offset = "0x132ABAC", VA = "0x132ABAC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x132ACE0", Offset = "0x132ACE0", VA = "0x132ACE0")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x132AE14", Offset = "0x132AE14", VA = "0x132AE14")]
	public Engine_stand_threshold()
	{
	}
}
[Token(Token = "0x200015C")]
public class GameModePopup : MonoBehaviour
{
	[Token(Token = "0x4000669")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform PopupTransform;

	[Token(Token = "0x400066A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VRTKExample_ControllerEventsDelegateListeners controllerListener;

	[Token(Token = "0x400066B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Content;

	[Token(Token = "0x400066C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text CurrentModeText;

	[Token(Token = "0x400066D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text NextModeText;

	[Token(Token = "0x400066E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool canOpen;

	[Token(Token = "0x400066F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameMode gameModeManager;

	[Token(Token = "0x4000670")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool canChange;

	[Token(Token = "0x4000671")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private CarLoader currentCarLoader;

	[Token(Token = "0x4000672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameModePopup m_instance;

	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x132AE1C", Offset = "0x132AE1C", VA = "0x132AE1C")]
	private void Start()
	{
	}

	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x132AE70", Offset = "0x132AE70", VA = "0x132AE70")]
	private void Update()
	{
	}

	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x132B1FC", Offset = "0x132B1FC", VA = "0x132B1FC")]
	public static GameModePopup Get()
	{
		return null;
	}

	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x132B2D0", Offset = "0x132B2D0", VA = "0x132B2D0")]
	public void SetCurrentCarLoader(CarLoader carLoader)
	{
	}

	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x132B2D8", Offset = "0x132B2D8", VA = "0x132B2D8")]
	public GameModePopup()
	{
	}
}
[Token(Token = "0x200015D")]
public class GlassBottle : VRTK_InteractableObject
{
	[Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class <UnActivePiece>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject piece;

		[Token(Token = "0x170000AC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0x132BD20", Offset = "0x132BD20", VA = "0x132BD20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x132BD68", Offset = "0x132BD68", VA = "0x132BD68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x132BBE8", Offset = "0x132BBE8", VA = "0x132BBE8")]
		[DebuggerHidden]
		public <UnActivePiece>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x132BC40", Offset = "0x132BC40", VA = "0x132BC40", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x132BC44", Offset = "0x132BC44", VA = "0x132BC44", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x132BD28", Offset = "0x132BD28", VA = "0x132BD28", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class <UnActiveThis>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GlassBottle <>4__this;

		[Token(Token = "0x170000AE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x132BE34", Offset = "0x132BE34", VA = "0x132BE34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600070E")]
			[Address(RVA = "0x132BE7C", Offset = "0x132BE7C", VA = "0x132BE7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x132BC10", Offset = "0x132BC10", VA = "0x132BC10")]
		[DebuggerHidden]
		public <UnActiveThis>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x132BD70", Offset = "0x132BD70", VA = "0x132BD70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x132BD74", Offset = "0x132BD74", VA = "0x132BD74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x132BE3C", Offset = "0x132BE3C", VA = "0x132BE3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private Rigidbody rb;

	[Token(Token = "0x4000674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private float minVelocity;

	[Token(Token = "0x4000675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	private bool isSelfBroken;

	[Token(Token = "0x4000676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private VRTK_InteractGrab grabbingObject;

	[Token(Token = "0x4000677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private AudioSource audioSource;

	[Token(Token = "0x4000678")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	private AudioClip audioClip;

	[Token(Token = "0x4000679")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private AudioClip[] audioClips;

	[Token(Token = "0x400067A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	public GameObject glassBottle;

	[Token(Token = "0x400067B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	public GameObject glassBottleBroken;

	[Token(Token = "0x400067C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	private GameObject objectToBreak;

	[Token(Token = "0x60006FC")]
	[Address(RVA = "0x132B2E0", Offset = "0x132B2E0", VA = "0x132B2E0", Slot = "66")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60006FD")]
	[Address(RVA = "0x132B604", Offset = "0x132B604", VA = "0x132B604", Slot = "27")]
	public override void Grabbed([Optional] VRTK_InteractGrab currentGrabbingObject)
	{
	}

	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x132B640", Offset = "0x132B640", VA = "0x132B640", Slot = "9")]
	public override void OnInteractableObjectUntouched(InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x132B660", Offset = "0x132B660", VA = "0x132B660")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000700")]
	[Address(RVA = "0x132BB00", Offset = "0x132BB00", VA = "0x132BB00")]
	[IteratorStateMachine(typeof(<UnActivePiece>d__14))]
	public IEnumerator UnActivePiece(GameObject piece)
	{
		return null;
	}

	[Token(Token = "0x6000701")]
	[Address(RVA = "0x132BB74", Offset = "0x132BB74", VA = "0x132BB74")]
	[IteratorStateMachine(typeof(<UnActiveThis>d__15))]
	public IEnumerator UnActiveThis()
	{
		return null;
	}

	[Token(Token = "0x6000702")]
	[Address(RVA = "0x132BC38", Offset = "0x132BC38", VA = "0x132BC38")]
	public GlassBottle()
	{
	}
}
[Token(Token = "0x2000160")]
public class IO_VRTK : VRTK_InteractableObject
{
	[Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class <CheckButtonPress>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IO_VRTK <>4__this;

		[Token(Token = "0x170000B0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0x132C598", Offset = "0x132C598", VA = "0x132C598", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x132C5E0", Offset = "0x132C5E0", VA = "0x132C5E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x132C098", Offset = "0x132C098", VA = "0x132C098")]
		[DebuggerHidden]
		public <CheckButtonPress>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x132C39C", Offset = "0x132C39C", VA = "0x132C39C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x132C3A0", Offset = "0x132C3A0", VA = "0x132C3A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x132C5A0", Offset = "0x132C5A0", VA = "0x132C5A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000683")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private EmptyIOController iOController;

	[Token(Token = "0x4000684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private RenderersSwitch renderersSwitch;

	[Token(Token = "0x4000685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private bool isPointed;

	[Token(Token = "0x600070F")]
	[Address(RVA = "0x132BE84", Offset = "0x132BE84", VA = "0x132BE84", Slot = "67")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000710")]
	[Address(RVA = "0x132BF20", Offset = "0x132BF20", VA = "0x132BF20", Slot = "27")]
	public override void Grabbed([Optional] VRTK_InteractGrab currentGrabbingObject)
	{
	}

	[Token(Token = "0x6000711")]
	[Address(RVA = "0x132C024", Offset = "0x132C024", VA = "0x132C024")]
	[IteratorStateMachine(typeof(<CheckButtonPress>d__4))]
	private IEnumerator CheckButtonPress()
	{
		return null;
	}

	[Token(Token = "0x6000712")]
	[Address(RVA = "0x132C0C0", Offset = "0x132C0C0", VA = "0x132C0C0", Slot = "30")]
	public override void StartUsing([Optional] VRTK_InteractUse currentUsingObject)
	{
	}

	[Token(Token = "0x6000713")]
	[Address(RVA = "0x132C16C", Offset = "0x132C16C", VA = "0x132C16C", Slot = "31")]
	public override void StopUsing([Optional] VRTK_InteractUse previousUsingObject, bool resetUsingObjectState = true)
	{
	}

	[Token(Token = "0x6000714")]
	[Address(RVA = "0x132C218", Offset = "0x132C218", VA = "0x132C218", Slot = "29")]
	public override void Ungrabbed([Optional] VRTK_InteractGrab previousGrabbingObject)
	{
	}

	[Token(Token = "0x6000715")]
	[Address(RVA = "0x132C31C", Offset = "0x132C31C", VA = "0x132C31C", Slot = "75")]
	protected override void LoadPreviousState()
	{
	}

	[Token(Token = "0x6000716")]
	[Address(RVA = "0x132C394", Offset = "0x132C394", VA = "0x132C394")]
	public IO_VRTK()
	{
	}
}
[Token(Token = "0x2000162")]
public class MainGateDoor : VRTK_InteractableObject
{
	[Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class <RotateTheRoller>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MainGateDoor <>4__this;

		[Token(Token = "0x170000B2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x132C800", Offset = "0x132C800", VA = "0x132C800", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x132C848", Offset = "0x132C848", VA = "0x132C848", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x132C6B4", Offset = "0x132C6B4", VA = "0x132C6B4")]
		[DebuggerHidden]
		public <RotateTheRoller>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x132C724", Offset = "0x132C724", VA = "0x132C724", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x132C728", Offset = "0x132C728", VA = "0x132C728", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x132C808", Offset = "0x132C808", VA = "0x132C808", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000689")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[SerializeField]
	private GameObject roller;

	[Token(Token = "0x400068A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private Vector3 prevPos;

	[Token(Token = "0x600071D")]
	[Address(RVA = "0x132C5E8", Offset = "0x132C5E8", VA = "0x132C5E8", Slot = "27")]
	public override void Grabbed([Optional] VRTK_InteractGrab currentGrabbingObject)
	{
	}

	[Token(Token = "0x600071E")]
	[Address(RVA = "0x132C688", Offset = "0x132C688", VA = "0x132C688", Slot = "29")]
	public override void Ungrabbed([Optional] VRTK_InteractGrab previousGrabbingObject)
	{
	}

	[Token(Token = "0x600071F")]
	[Address(RVA = "0x132C614", Offset = "0x132C614", VA = "0x132C614")]
	[IteratorStateMachine(typeof(<RotateTheRoller>d__3))]
	public IEnumerator RotateTheRoller()
	{
		return null;
	}

	[Token(Token = "0x6000720")]
	[Address(RVA = "0x132C6DC", Offset = "0x132C6DC", VA = "0x132C6DC", Slot = "67")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000721")]
	[Address(RVA = "0x132C71C", Offset = "0x132C71C", VA = "0x132C71C")]
	public MainGateDoor()
	{
	}
}
[Token(Token = "0x2000164")]
public class Sprayer : VRTK_InteractableObject
{
	[Token(Token = "0x2000165")]
	[CompilerGenerated]
	private sealed class <UsingRoutine>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sprayer <>4__this;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <continuousRepairCost>5__2;

		[Token(Token = "0x170000B4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x132D488", Offset = "0x132D488", VA = "0x132D488", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x132D4D0", Offset = "0x132D4D0", VA = "0x132D4D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x132D19C", Offset = "0x132D19C", VA = "0x132D19C")]
		[DebuggerHidden]
		public <UsingRoutine>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x132D1D8", Offset = "0x132D1D8", VA = "0x132D1D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x132D1DC", Offset = "0x132D1DC", VA = "0x132D1DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x132D490", Offset = "0x132D490", VA = "0x132D490", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400068E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[SerializeField]
	private GameObject _mist;

	[Token(Token = "0x400068F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[SerializeField]
	private AudioSource audioSource;

	[Token(Token = "0x4000690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[SerializeField]
	private AudioClip audioClip;

	[Token(Token = "0x4000691")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	private GameObject _trigger;

	[Token(Token = "0x4000692")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private ParticleSystem _particle;

	[Token(Token = "0x4000693")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private Vector3 start_rot;

	[Token(Token = "0x4000694")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	private Vector3 push;

	[Token(Token = "0x4000695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public Vector3 push_rot;

	[Token(Token = "0x4000696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	private ToolSnapperDetector carBodyDetector;

	[Token(Token = "0x4000697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	private float repairSpeed;

	[Token(Token = "0x4000698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private CarLoader nearbyCarLoader;

	[Token(Token = "0x6000728")]
	[Address(RVA = "0x132C850", Offset = "0x132C850", VA = "0x132C850", Slot = "66")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0x132C8FC", Offset = "0x132C8FC", VA = "0x132C8FC", Slot = "67")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600072A")]
	[Address(RVA = "0x132C9BC", Offset = "0x132C9BC", VA = "0x132C9BC", Slot = "68")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600072B")]
	[Address(RVA = "0x132CB98", Offset = "0x132CB98", VA = "0x132CB98", Slot = "69")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600072C")]
	[Address(RVA = "0x132CD74", Offset = "0x132CD74", VA = "0x132CD74", Slot = "27")]
	public override void Grabbed([Optional] VRTK_InteractGrab currentGrabbingObject)
	{
	}

	[Token(Token = "0x600072D")]
	[Address(RVA = "0x132CDA8", Offset = "0x132CDA8", VA = "0x132CDA8", Slot = "29")]
	public override void Ungrabbed([Optional] VRTK_InteractGrab previousGrabbingObject)
	{
	}

	[Token(Token = "0x600072E")]
	[Address(RVA = "0x132CDDC", Offset = "0x132CDDC", VA = "0x132CDDC", Slot = "30")]
	public override void StartUsing([Optional] VRTK_InteractUse currentUsingObject)
	{
	}

	[Token(Token = "0x600072F")]
	[Address(RVA = "0x132CF70", Offset = "0x132CF70", VA = "0x132CF70", Slot = "31")]
	public override void StopUsing([Optional] VRTK_InteractUse previousUsingObject, bool resetUsingObjectState = true)
	{
	}

	[Token(Token = "0x6000730")]
	[Address(RVA = "0x132CE2C", Offset = "0x132CE2C", VA = "0x132CE2C")]
	private void Spray()
	{
	}

	[Token(Token = "0x6000731")]
	[Address(RVA = "0x132CE70", Offset = "0x132CE70", VA = "0x132CE70")]
	private void SetTriggerRotation()
	{
	}

	[Token(Token = "0x6000732")]
	[Address(RVA = "0x132CFA4", Offset = "0x132CFA4", VA = "0x132CFA4")]
	private void OnDetectorTriggerEnterAction(Collider caller, Collider other)
	{
	}

	[Token(Token = "0x6000733")]
	[Address(RVA = "0x132D0C4", Offset = "0x132D0C4", VA = "0x132D0C4")]
	private void OnDetectorTriggerExitAction(Collider caller, Collider other)
	{
	}

	[Token(Token = "0x6000734")]
	[Address(RVA = "0x132CEFC", Offset = "0x132CEFC", VA = "0x132CEFC")]
	[IteratorStateMachine(typeof(<UsingRoutine>d__23))]
	private IEnumerator UsingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000735")]
	[Address(RVA = "0x132D1C4", Offset = "0x132D1C4", VA = "0x132D1C4")]
	public Sprayer()
	{
	}
}
[Token(Token = "0x2000166")]
public class Sprinkler : VRTK_InteractableObject
{
	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[SerializeField]
	private SprinklerPump sprinklerPump;

	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[SerializeField]
	private GameObject pumpSlider;

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[SerializeField]
	private ParticleSystem particle;

	[Token(Token = "0x600073C")]
	[Address(RVA = "0x132D4D8", Offset = "0x132D4D8", VA = "0x132D4D8", Slot = "30")]
	public override void StartUsing([Optional] VRTK_InteractUse currentUsingObject)
	{
	}

	[Token(Token = "0x600073D")]
	[Address(RVA = "0x132D5A0", Offset = "0x132D5A0", VA = "0x132D5A0", Slot = "31")]
	public override void StopUsing([Optional] VRTK_InteractUse previousUsingObject, bool resetUsingObjectState = true)
	{
	}

	[Token(Token = "0x600073E")]
	[Address(RVA = "0x132D584", Offset = "0x132D584", VA = "0x132D584")]
	private void Spray()
	{
	}

	[Token(Token = "0x600073F")]
	[Address(RVA = "0x132D5CC", Offset = "0x132D5CC", VA = "0x132D5CC")]
	private void StopSpray()
	{
	}

	[Token(Token = "0x6000740")]
	[Address(RVA = "0x132D5E8", Offset = "0x132D5E8", VA = "0x132D5E8")]
	public Sprinkler()
	{
	}
}
[Token(Token = "0x2000167")]
public class SprinklerPump : MonoBehaviour
{
	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject objectToInteract;

	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject pumpSlider;

	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int stepOfFill;

	[Token(Token = "0x40006A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Rigidbody pumpSliderRb;

	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool isFull;

	[Token(Token = "0x6000741")]
	[Address(RVA = "0x132D5F0", Offset = "0x132D5F0", VA = "0x132D5F0")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000742")]
	[Address(RVA = "0x132D6D0", Offset = "0x132D6D0", VA = "0x132D6D0")]
	public SprinklerPump()
	{
	}
}
[Token(Token = "0x2000168")]
public class ToolboxWithWrenches : MonoBehaviour
{
	[Token(Token = "0x40006A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject GrabbedObjects;

	[Token(Token = "0x40006A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject SnapDropZones;

	[Token(Token = "0x6000743")]
	[Address(RVA = "0x132D6D8", Offset = "0x132D6D8", VA = "0x132D6D8")]
	public ToolboxWithWrenches()
	{
	}
}
[Token(Token = "0x2000169")]
public class ToolboxWrench : VRTK_InteractableObject
{
	[Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class <Wait>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float waitTime;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ToolboxWrench <>4__this;

		[Token(Token = "0x170000B6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x132D9A8", Offset = "0x132D9A8", VA = "0x132D9A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x132D9F0", Offset = "0x132D9F0", VA = "0x132D9F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x132D874", Offset = "0x132D874", VA = "0x132D874")]
		[DebuggerHidden]
		public <Wait>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x132D8A4", Offset = "0x132D8A4", VA = "0x132D8A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x132D8A8", Offset = "0x132D8A8", VA = "0x132D8A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x132D9B0", Offset = "0x132D9B0", VA = "0x132D9B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private VRTK_SnapDropZone snapDropZone;

	[Token(Token = "0x6000744")]
	[Address(RVA = "0x132D6E0", Offset = "0x132D6E0", VA = "0x132D6E0", Slot = "67")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000745")]
	[Address(RVA = "0x132D718", Offset = "0x132D718", VA = "0x132D718", Slot = "29")]
	public override void Ungrabbed([Optional] VRTK_InteractGrab previousGrabbingObject)
	{
	}

	[Token(Token = "0x6000746")]
	[Address(RVA = "0x132D7CC", Offset = "0x132D7CC", VA = "0x132D7CC")]
	private bool IsOutOfRange(Transform transform, float min, float max)
	{
		return default(bool);
	}

	[Token(Token = "0x6000747")]
	[Address(RVA = "0x132D748", Offset = "0x132D748", VA = "0x132D748")]
	[IteratorStateMachine(typeof(<Wait>d__4))]
	private IEnumerator Wait(float waitTime)
	{
		return null;
	}

	[Token(Token = "0x6000748")]
	[Address(RVA = "0x132D89C", Offset = "0x132D89C", VA = "0x132D89C")]
	public ToolboxWrench()
	{
	}
}
[Token(Token = "0x200016B")]
[RequireComponent(typeof(Rigidbody))]
public class Toolbox_controller : VRTK_InteractableObject, IInteractableCarrier
{
	[Token(Token = "0x40006AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float triggerOffset;

	[Token(Token = "0x40006AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[Header("Toolbox_controller fields")]
	[SerializeField]
	private bool addCollidersAutomatically;

	[Token(Token = "0x40006AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[SerializeField]
	private Wheels_Controller wheelsController;

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[SerializeField]
	private BoxCollider[] specificCollidersToAddTrigger;

	[Token(Token = "0x40006B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	protected List<GameObject> collidersToActiveWhenGrab;

	[Token(Token = "0x40006B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private ToolboxWithWrenches[] toolboxesWithWrenches;

	[Token(Token = "0x40006B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private GameObject[] grabbedObjects;

	[Token(Token = "0x40006B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private GameObject[] snapDropZones;

	[Token(Token = "0x40006B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private List<VRTK_InteractableObject> placedInteractables;

	[Token(Token = "0x40006B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	protected Rigidbody rigidBody;

	[Token(Token = "0x600074F")]
	[Address(RVA = "0x132D9F8", Offset = "0x132D9F8", VA = "0x132D9F8", Slot = "66")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000750")]
	[Address(RVA = "0x132E238", Offset = "0x132E238", VA = "0x132E238", Slot = "67")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000751")]
	[Address(RVA = "0x132E4F4", Offset = "0x132E4F4", VA = "0x132E4F4", Slot = "72")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000752")]
	[Address(RVA = "0x132E5B4", Offset = "0x132E5B4", VA = "0x132E5B4", Slot = "27")]
	public override void Grabbed([Optional] VRTK_InteractGrab currentGrabbingObject)
	{
	}

	[Token(Token = "0x6000753")]
	[Address(RVA = "0x132E918", Offset = "0x132E918", VA = "0x132E918", Slot = "29")]
	public override void Ungrabbed([Optional] VRTK_InteractGrab previousGrabbingObject)
	{
	}

	[Token(Token = "0x6000754")]
	[Address(RVA = "0x132DE04", Offset = "0x132DE04", VA = "0x132DE04")]
	private void AddTriggerOnTheTopCollidersOfObject()
	{
	}

	[Token(Token = "0x6000755")]
	[Address(RVA = "0x132E254", Offset = "0x132E254", VA = "0x132E254")]
	private void SubscribeCarLoadersCollidersChanges()
	{
	}

	[Token(Token = "0x6000756")]
	[Address(RVA = "0x132EC7C", Offset = "0x132EC7C", VA = "0x132EC7C")]
	private void AddColliderToList(GameObject colliderToActive)
	{
	}

	[Token(Token = "0x6000757")]
	[Address(RVA = "0x132ED64", Offset = "0x132ED64", VA = "0x132ED64")]
	private void RemoveColliderFromList(GameObject colliderToActive)
	{
	}

	[Token(Token = "0x6000758")]
	[Address(RVA = "0x132EDBC", Offset = "0x132EDBC", VA = "0x132EDBC", Slot = "22")]
	public override void SmoothMove(Vector3 position)
	{
	}

	[Token(Token = "0x6000759")]
	[Address(RVA = "0x132F054", Offset = "0x132F054", VA = "0x132F054", Slot = "113")]
	public void PlaceInteractable(Transform transform, VRTK_InteractableObject io)
	{
	}

	[Token(Token = "0x600075A")]
	[Address(RVA = "0x132F188", Offset = "0x132F188", VA = "0x132F188", Slot = "114")]
	public void RemoveInteractable(VRTK_InteractableObject io)
	{
	}

	[Token(Token = "0x600075B")]
	[Address(RVA = "0x132F228", Offset = "0x132F228", VA = "0x132F228")]
	public Toolbox_controller()
	{
	}
}
[Token(Token = "0x200016C")]
public class Toolbox_controller_small : VRTK_InteractableObject, IInteractableCarrier
{
	[Token(Token = "0x40006B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[HideInInspector]
	public List<VRTK_InteractableObject> placedInteractables;

	[Token(Token = "0x40006B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private Rigidbody[] drawersRb;

	[Token(Token = "0x40006B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[SerializeField]
	private GameObject drawersContainer;

	[Token(Token = "0x40006B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	private GameObject toolboxContainer;

	[Token(Token = "0x40006BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private Rigidbody rb;

	[Token(Token = "0x600075F")]
	[Address(RVA = "0x132F310", Offset = "0x132F310", VA = "0x132F310", Slot = "66")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000760")]
	[Address(RVA = "0x132F3AC", Offset = "0x132F3AC", VA = "0x132F3AC", Slot = "113")]
	public void PlaceInteractable(Transform transform, VRTK_InteractableObject io)
	{
	}

	[Token(Token = "0x6000761")]
	[Address(RVA = "0x132F4E0", Offset = "0x132F4E0", VA = "0x132F4E0", Slot = "114")]
	public void RemoveInteractable(VRTK_InteractableObject io)
	{
	}

	[Token(Token = "0x6000762")]
	[Address(RVA = "0x132F580", Offset = "0x132F580", VA = "0x132F580")]
	public Toolbox_controller_small()
	{
	}
}
[Token(Token = "0x200016D")]
public class Wheels_controller : MonoBehaviour
{
	[Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class <Rotation>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Wheels_controller <>4__this;

		[Token(Token = "0x170000B8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x132FD5C", Offset = "0x132FD5C", VA = "0x132FD5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x132FDA4", Offset = "0x132FDA4", VA = "0x132FDA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x132F904", Offset = "0x132F904", VA = "0x132F904")]
		[DebuggerHidden]
		public <Rotation>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x132F9BC", Offset = "0x132F9BC", VA = "0x132F9BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x132F9C0", Offset = "0x132F9C0", VA = "0x132F9C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x132FD64", Offset = "0x132FD64", VA = "0x132FD64", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> wheels;

	[Token(Token = "0x40006BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float rot_steps;

	[Token(Token = "0x40006BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3[] wheels_start_rotation;

	[Token(Token = "0x40006BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float[] wheels_actual_rotation;

	[Token(Token = "0x40006BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 previous_position;

	[Token(Token = "0x40006C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 actual_position;

	[Token(Token = "0x40006C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float degree;

	[Token(Token = "0x6000763")]
	[Address(RVA = "0x132F608", Offset = "0x132F608", VA = "0x132F608")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x6000764")]
	[Address(RVA = "0x132F670", Offset = "0x132F670", VA = "0x132F670")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000765")]
	[Address(RVA = "0x132F824", Offset = "0x132F824", VA = "0x132F824")]
	public void Roll(bool roll)
	{
	}

	[Token(Token = "0x6000766")]
	[Address(RVA = "0x132F890", Offset = "0x132F890", VA = "0x132F890")]
	[IteratorStateMachine(typeof(<Rotation>d__10))]
	private IEnumerator Rotation()
	{
		return null;
	}

	[Token(Token = "0x6000767")]
	[Address(RVA = "0x132F92C", Offset = "0x132F92C", VA = "0x132F92C")]
	public Wheels_controller()
	{
	}
}
namespace DataPlatform
{
	[Token(Token = "0x200016F")]
	public class Events
	{
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x132FDAC", Offset = "0x132FDAC", VA = "0x132FDAC")]
		[Conditional("UNITY_XBOXONE")]
		public static void SendGameProgress(string UserId, ref Guid PlayerSessionId, float CompletionPercent)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x132FDB0", Offset = "0x132FDB0", VA = "0x132FDB0")]
		[Conditional("UNITY_XBOXONE")]
		public static void SendMediaUsage(string AppSessionId, string AppSessionStartDateTime, uint UserIdType, string UserId, string SubscriptionTierType, string SubscriptionTier, string MediaType, string ProviderId, string ProviderMediaId, string ProviderMediaInstanceId, ref Guid BingId, ulong MediaLengthMs, uint MediaControlAction, float PlaybackSpeed, ulong MediaPositionMs, ulong PlaybackDurationMs, string AcquisitionType, string AcquisitionContext, string AcquisitionContextType, string AcquisitionContextId, int PlaybackIsStream, int PlaybackIsTethered, string MarketplaceLocation, string ContentLocale, float TimeZoneOffset, uint ScreenState)
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x132FDB4", Offset = "0x132FDB4", VA = "0x132FDB4")]
		[Conditional("UNITY_XBOXONE")]
		public static void SendMultiplayerRoundEnd(string UserId, ref Guid RoundId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int MatchTypeId, int DifficultyLevelId, float TimeInSeconds, int ExitStatusId)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x132FDB8", Offset = "0x132FDB8", VA = "0x132FDB8")]
		[Conditional("UNITY_XBOXONE")]
		public static void SendMultiplayerRoundStart(string UserId, ref Guid RoundId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int MatchTypeId, int DifficultyLevelId)
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x132FDBC", Offset = "0x132FDBC", VA = "0x132FDBC")]
		[Conditional("UNITY_XBOXONE")]
		public static void SendObjectiveEnd(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, int ObjectiveId, int ExitStatusId)
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x132FDC0", Offset = "0x132FDC0", VA = "0x132FDC0")]
		[Conditional("UNITY_XBOXONE")]
		public static void SendObjectiveStart(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, int ObjectiveId)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x132FDC4", Offset = "0x132FDC4", VA = "0x132FDC4")]
		[Conditional("UNITY_XBOXONE")]
		public static void SendPageAction(string UserId, ref Guid PlayerSessionId, int ActionTypeId, int ActionInputMethodId, string Page, string TemplateId, string DestinationPage, string Content)
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x132FDC8", Offset = "0x132FDC8", VA = "0x132FDC8")]
		[Conditional("UNITY_XBOXONE")]
		public static void SendPageView(string UserId, ref Guid PlayerSessionId, string Page, string RefererPage, int PageTypeId, string PageTags, string TemplateId, string Content)
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x132FDCC", Offset = "0x132FDCC", VA = "0x132FDCC")]
		[Conditional("UNITY_XBOXONE")]
		public static void SendPlayerSessionEnd(string UserId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, int ExitStatusId)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x132FDD0", Offset = "0x132FDD0", VA = "0x132FDD0")]
		[Conditional("UNITY_XBOXONE")]
		public static void SendPlayerSessionPause(string UserId, ref Guid PlayerSessionId, string MultiplayerCorrelationId)
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x132FDD4", Offset = "0x132FDD4", VA = "0x132FDD4")]
		[Conditional("UNITY_XBOXONE")]
		public static void SendPlayerSessionResume(string UserId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId)
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x132FDD8", Offset = "0x132FDD8", VA = "0x132FDD8")]
		[Conditional("UNITY_XBOXONE")]
		public static void SendPlayerSessionStart(string UserId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId)
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x132FDDC", Offset = "0x132FDDC", VA = "0x132FDDC")]
		[Conditional("UNITY_XBOXONE")]
		public static void SendRandomStat(string UserId, ref Guid PlayerSessionId, int Counter)
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x132FDE0", Offset = "0x132FDE0", VA = "0x132FDE0")]
		[Conditional("UNITY_XBOXONE")]
		public static void SendSectionEnd(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, int ExitStatusId)
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x132FDE4", Offset = "0x132FDE4", VA = "0x132FDE4")]
		[Conditional("UNITY_XBOXONE")]
		public static void SendSectionStart(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x132FDE8", Offset = "0x132FDE8", VA = "0x132FDE8")]
		[Conditional("UNITY_XBOXONE")]
		public static void SendViewOffer(string UserId, ref Guid PlayerSessionId, ref Guid OfferGuid, ref Guid ProductGuid)
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x132FDEC", Offset = "0x132FDEC", VA = "0x132FDEC")]
		public Events()
		{
		}
	}
}
namespace UnityFBXExporter
{
	[Token(Token = "0x2000170")]
	public class FBXExporter
	{
		[Token(Token = "0x170000BA")]
		public static string VersionInformation
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x13321C4", Offset = "0x13321C4", VA = "0x13321C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x132FDF4", Offset = "0x132FDF4", VA = "0x132FDF4")]
		public static bool ExportGameObjToFBX(GameObject gameObj, string newPath, bool copyMaterials = false, bool copyTextures = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1332204", Offset = "0x1332204", VA = "0x1332204")]
		public static long GetRandomFBXId()
		{
			return default(long);
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x132FF50", Offset = "0x132FF50", VA = "0x132FF50")]
		public static string MeshToString(GameObject gameObj, string newPath, bool copyMaterials = false, bool copyTextures = false)
		{
			return null;
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x132FF4C", Offset = "0x132FF4C", VA = "0x132FF4C")]
		public static void CopyComplexMaterialsToPath(GameObject gameObj, string path, bool copyTextures, string texturesFolder = "/Textures", string materialsFolder = "/Materials")
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1335A70", Offset = "0x1335A70", VA = "0x1335A70")]
		public static bool CopyAndRenameAsset(UnityEngine.Object obj, string newName, string newFolderPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1335A78", Offset = "0x1335A78", VA = "0x1335A78")]
		private static string GetFileName(string path)
		{
			return null;
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1335ABC", Offset = "0x1335ABC", VA = "0x1335ABC")]
		private static Material CopyTexturesAndAssignCopiesToMaterial(Material material, string newPath)
		{
			return null;
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1335E00", Offset = "0x1335E00", VA = "0x1335E00")]
		private static void GetTextureUpdateMaterialWithPath(Material material, string textureShaderName, string newPath)
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1335EF8", Offset = "0x1335EF8", VA = "0x1335EF8")]
		public static UnityEngine.Object CopyAndRenameAssetReturnObject(UnityEngine.Object obj, string newName, string newFolderPath)
		{
			return null;
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1335F00", Offset = "0x1335F00", VA = "0x1335F00")]
		public static string FBXFormat(float val)
		{
			return null;
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1335F50", Offset = "0x1335F50", VA = "0x1335F50")]
		private static int CheckForCommaInsteadOfDecimal(ref string vert)
		{
			return default(int);
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1335FB8", Offset = "0x1335FB8", VA = "0x1335FB8")]
		private static string ReplaceCommasWithDecimals(string vert, int breakIndex)
		{
			return null;
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x133604C", Offset = "0x133604C", VA = "0x133604C")]
		public FBXExporter()
		{
		}
	}
	[Token(Token = "0x2000171")]
	public class FBXUnityMaterialGetter
	{
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1332288", Offset = "0x1332288", VA = "0x1332288")]
		public static void GetAllMaterialsToString(GameObject gameObj, string newPath, bool copyMaterials, bool copyTextures, out Material[] materials, out string matObjects, out string connections)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1336054", Offset = "0x1336054", VA = "0x1336054")]
		private static void SerializedTextures(GameObject gameObj, string newPath, Material material, string materialName, bool copyTextures, out string objects, out string connections)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1336270", Offset = "0x1336270", VA = "0x1336270")]
		private static bool SerializeOneTexture(GameObject gameObj, string newPath, Material material, string materialName, int materialId, bool copyTextures, string unityExtension, string textureType, out string objects, out string connections)
		{
			return default(bool);
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x13363C4", Offset = "0x13363C4", VA = "0x13363C4")]
		public FBXUnityMaterialGetter()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public class FBXUnityMeshGetter
	{
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1332DE0", Offset = "0x1332DE0", VA = "0x1332DE0")]
		public static long GetMeshToString(GameObject gameObj, Material[] materials, ref StringBuilder objects, ref StringBuilder connections, [Optional] GameObject parentObject, long parentModelId = 0L)
		{
			return default(long);
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x13363CC", Offset = "0x13363CC", VA = "0x13363CC")]
		public FBXUnityMeshGetter()
		{
		}
	}
}
namespace UltimateGameTools.MeshSimplifier
{
	[Serializable]
	[Token(Token = "0x2000173")]
	public class MeshUniqueVertices
	{
		[Serializable]
		[Token(Token = "0x2000174")]
		public class ListIndices
		{
			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<int> m_listIndices;

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x1336C1C", Offset = "0x1336C1C", VA = "0x1336C1C")]
			public ListIndices()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000175")]
		public class SerializableBoneWeight
		{
			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int _boneIndex0;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int _boneIndex1;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int _boneIndex2;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int _boneIndex3;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float _boneWeight0;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float _boneWeight1;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float _boneWeight2;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float _boneWeight3;

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x1336EE4", Offset = "0x1336EE4", VA = "0x1336EE4")]
			public SerializableBoneWeight(BoneWeight boneWeight)
			{
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x1336F90", Offset = "0x1336F90", VA = "0x1336F90")]
			public BoneWeight ToBoneWeight()
			{
				return default(BoneWeight);
			}
		}

		[Token(Token = "0x2000176")]
		public class UniqueVertex
		{
			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int m_nFixedX;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int m_nFixedY;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int m_nFixedZ;

			[Token(Token = "0x40006D5")]
			private const float fDecimalMultiplier = 100000f;

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x1337044", Offset = "0x1337044", VA = "0x1337044", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x13370F4", Offset = "0x13370F4", VA = "0x13370F4", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0x1336CA4", Offset = "0x1336CA4", VA = "0x1336CA4")]
			public UniqueVertex(Vector3 v3Vertex)
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x1337148", Offset = "0x1337148", VA = "0x1337148")]
			public Vector3 ToVertex()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x13371C4", Offset = "0x13371C4", VA = "0x13371C4")]
			public static bool operator ==(UniqueVertex a, UniqueVertex b)
			{
				return default(bool);
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x13371E0", Offset = "0x13371E0", VA = "0x13371E0")]
			public static bool operator !=(UniqueVertex a, UniqueVertex b)
			{
				return default(bool);
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x1337108", Offset = "0x1337108", VA = "0x1337108")]
			private void FromVertex(Vector3 vertex)
			{
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x1337208", Offset = "0x1337208", VA = "0x1337208")]
			private int CoordToFixed(float fCoord)
			{
				return default(int);
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x13371A0", Offset = "0x13371A0", VA = "0x13371A0")]
			private float FixedToCoord(int nFixed)
			{
				return default(float);
			}
		}

		[Token(Token = "0x2000177")]
		private class RepeatedVertex
		{
			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _nFaceIndex;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int _nOriginalVertexIndex;

			[Token(Token = "0x170000BF")]
			public int FaceIndex
			{
				[Token(Token = "0x60007A5")]
				[Address(RVA = "0x13372EC", Offset = "0x13372EC", VA = "0x13372EC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x170000C0")]
			public int OriginalVertexIndex
			{
				[Token(Token = "0x60007A6")]
				[Address(RVA = "0x13372F4", Offset = "0x13372F4", VA = "0x13372F4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x1336CE8", Offset = "0x1336CE8", VA = "0x1336CE8")]
			public RepeatedVertex(int nFaceIndex, int nOriginalVertexIndex)
			{
			}
		}

		[Token(Token = "0x2000178")]
		private class RepeatedVertexList
		{
			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int m_nUniqueIndex;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private List<RepeatedVertex> m_listRepeatedVertices;

			[Token(Token = "0x170000C1")]
			public int UniqueIndex
			{
				[Token(Token = "0x60007A8")]
				[Address(RVA = "0x13372FC", Offset = "0x13372FC", VA = "0x13372FC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x1336DC4", Offset = "0x1336DC4", VA = "0x1336DC4")]
			public RepeatedVertexList(int nUniqueIndex, RepeatedVertex repeatedVertex)
			{
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x1336D14", Offset = "0x1336D14", VA = "0x1336D14")]
			public void Add(RepeatedVertex repeatedVertex)
			{
			}
		}

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<Vector3> m_listVertices;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Vector3> m_listVerticesWorld;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<SerializableBoneWeight> m_listBoneWeights;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ListIndices[] m_aFaceList;

		[Token(Token = "0x170000BB")]
		public ListIndices[] SubmeshesFaceList
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x13363D4", Offset = "0x13363D4", VA = "0x13363D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public List<Vector3> ListVertices
		{
			[Token(Token = "0x6000794")]
			[Address(RVA = "0x13363DC", Offset = "0x13363DC", VA = "0x13363DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public List<Vector3> ListVerticesWorld
		{
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x13363E4", Offset = "0x13363E4", VA = "0x13363E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		public List<SerializableBoneWeight> ListBoneWeights
		{
			[Token(Token = "0x6000796")]
			[Address(RVA = "0x13363EC", Offset = "0x13363EC", VA = "0x13363EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x13363F4", Offset = "0x13363F4", VA = "0x13363F4")]
		public void BuildData(Mesh sourceMesh, Vector3[] av3VerticesWorld)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1336F88", Offset = "0x1336F88", VA = "0x1336F88")]
		public MeshUniqueVertices()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000179")]
	public class RelevanceSphere
	{
		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bExpanded;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 m_v3Position;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 m_v3Rotation;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 m_v3Scale;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float m_fRelevance;

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1337304", Offset = "0x1337304", VA = "0x1337304")]
		public RelevanceSphere()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1337364", Offset = "0x1337364", VA = "0x1337364")]
		public void SetDefault(Transform target, float fRelevance)
		{
		}
	}
	[Token(Token = "0x200017A")]
	public class Simplifier : MonoBehaviour
	{
		[Token(Token = "0x200017B")]
		public delegate void ProgressDelegate(string strTitle, string strProgressMessage, float fT);

		[Token(Token = "0x200017C")]
		private class Triangle
		{
			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vertex[] m_aVertices;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool m_bUVData;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int[] m_aUV;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int[] m_aIndices;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 m_v3Normal;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int m_nSubMesh;

			[Token(Token = "0x170000C9")]
			public Vertex[] Vertices
			{
				[Token(Token = "0x60007D4")]
				[Address(RVA = "0x133ABD4", Offset = "0x133ABD4", VA = "0x133ABD4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CA")]
			public bool HasUVData
			{
				[Token(Token = "0x60007D5")]
				[Address(RVA = "0x133ABDC", Offset = "0x133ABDC", VA = "0x133ABDC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000CB")]
			public int[] IndicesUV
			{
				[Token(Token = "0x60007D6")]
				[Address(RVA = "0x133ABE4", Offset = "0x133ABE4", VA = "0x133ABE4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CC")]
			public Vector3 Normal
			{
				[Token(Token = "0x60007D7")]
				[Address(RVA = "0x133ABEC", Offset = "0x133ABEC", VA = "0x133ABEC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CD")]
			public int[] Indices
			{
				[Token(Token = "0x60007D8")]
				[Address(RVA = "0x133ABF8", Offset = "0x133ABF8", VA = "0x133ABF8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x133AC00", Offset = "0x133AC00", VA = "0x133AC00")]
			public Triangle(Simplifier simplifier, int nSubMesh, Vertex v0, Vertex v1, Vertex v2, bool bUVData, int nIndex1, int nIndex2, int nIndex3)
			{
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x133B280", Offset = "0x133B280", VA = "0x133B280")]
			public void Destructor(Simplifier simplifier)
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x133B4E0", Offset = "0x133B4E0", VA = "0x133B4E0")]
			public bool HasVertex(Vertex v)
			{
				return default(bool);
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x133B0B0", Offset = "0x133B0B0", VA = "0x133B0B0")]
			public void ComputeNormal()
			{
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x133B540", Offset = "0x133B540", VA = "0x133B540")]
			public int TexAt(Vertex vertex)
			{
				return default(int);
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x133B614", Offset = "0x133B614", VA = "0x133B614")]
			public int TexAt(int i)
			{
				return default(int);
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x133B644", Offset = "0x133B644", VA = "0x133B644")]
			public void SetTexAt(Vertex vertex, int uv)
			{
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x133B728", Offset = "0x133B728", VA = "0x133B728")]
			public void SetTexAt(int i, int uv)
			{
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x133B758", Offset = "0x133B758", VA = "0x133B758")]
			public void ReplaceVertex(Vertex vold, Vertex vnew)
			{
			}
		}

		[Token(Token = "0x200017D")]
		private class TriangleList
		{
			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Triangle> m_listTriangles;

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x133BA7C", Offset = "0x133BA7C", VA = "0x133BA7C")]
			public TriangleList()
			{
			}
		}

		[Token(Token = "0x200017E")]
		private class Vertex
		{
			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 m_v3Position;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 m_v3PositionWorld;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool m_bHasBoneWeight;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public BoneWeight m_boneWeight;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public int m_nID;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public List<Vertex> m_listNeighbors;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<Triangle> m_listFaces;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float m_fObjDist;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Vertex m_collapse;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public int m_nHeapSpot;

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x133BB04", Offset = "0x133BB04", VA = "0x133BB04")]
			public Vertex(Simplifier simplifier, Vector3 v, Vector3 v3World, bool bHasBoneWeight, BoneWeight boneWeight, int nID)
			{
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x133BCE4", Offset = "0x133BCE4", VA = "0x133BCE4")]
			public void Destructor(Simplifier simplifier)
			{
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x133B3E0", Offset = "0x133B3E0", VA = "0x133B3E0")]
			public void RemoveIfNonNeighbor(Vertex n)
			{
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x133BDE0", Offset = "0x133BDE0", VA = "0x133BDE0")]
			public bool IsBorder()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200017F")]
		private class VertexDataHashComparer : IEqualityComparer<VertexDataHash>
		{
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x133BF08", Offset = "0x133BF08", VA = "0x133BF08", Slot = "4")]
			public bool Equals(VertexDataHash a, VertexDataHash b)
			{
				return default(bool);
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x133BFAC", Offset = "0x133BFAC", VA = "0x133BFAC", Slot = "5")]
			public int GetHashCode(VertexDataHash vdata)
			{
				return default(int);
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x133BFCC", Offset = "0x133BFCC", VA = "0x133BFCC")]
			public VertexDataHashComparer()
			{
			}
		}

		[Token(Token = "0x2000180")]
		private class VertexDataHash
		{
			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector3 _v3Vertex;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Vector3 _v3Normal;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector2 _v2Mapping1;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector2 _v2Mapping2;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Color32 _color;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private MeshUniqueVertices.UniqueVertex _uniqueVertex;

			[Token(Token = "0x170000CE")]
			public Vector3 Vertex
			{
				[Token(Token = "0x60007EA")]
				[Address(RVA = "0x133BFD4", Offset = "0x133BFD4", VA = "0x133BFD4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CF")]
			public Vector3 Normal
			{
				[Token(Token = "0x60007EB")]
				[Address(RVA = "0x133BFE0", Offset = "0x133BFE0", VA = "0x133BFE0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D0")]
			public Vector2 UV1
			{
				[Token(Token = "0x60007EC")]
				[Address(RVA = "0x133BFEC", Offset = "0x133BFEC", VA = "0x133BFEC")]
				get
				{
					return default(Vector2);
				}
			}

			[Token(Token = "0x170000D1")]
			public Vector2 UV2
			{
				[Token(Token = "0x60007ED")]
				[Address(RVA = "0x133BFF4", Offset = "0x133BFF4", VA = "0x133BFF4")]
				get
				{
					return default(Vector2);
				}
			}

			[Token(Token = "0x170000D2")]
			public Color32 Color
			{
				[Token(Token = "0x60007EE")]
				[Address(RVA = "0x133BFFC", Offset = "0x133BFFC", VA = "0x133BFFC")]
				get
				{
					return default(Color32);
				}
			}

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x133C004", Offset = "0x133C004", VA = "0x133C004")]
			public VertexDataHash(Vector3 v3Vertex, Vector3 v3Normal, Vector2 v2Mapping1, Vector2 v2Mapping2, Color32 color)
			{
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x133C0F4", Offset = "0x133C0F4", VA = "0x133C0F4", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x133C228", Offset = "0x133C228", VA = "0x133C228", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x133C248", Offset = "0x133C248", VA = "0x133C248")]
			public static bool operator ==(VertexDataHash a, VertexDataHash b)
			{
				return default(bool);
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x133C264", Offset = "0x133C264", VA = "0x133C264")]
			public static bool operator !=(VertexDataHash a, VertexDataHash b)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000181")]
		[CompilerGenerated]
		private sealed class <ProgressiveMesh>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Simplifier <>4__this;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Mesh sourceMesh;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject gameObject;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public ProgressDelegate progress;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string strProgressDisplayObjectName;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public RelevanceSphere[] aRelevanceSpheres;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int <nVertices>5__2;

			[Token(Token = "0x170000D3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007F7")]
				[Address(RVA = "0x133CD54", Offset = "0x133CD54", VA = "0x133CD54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007F9")]
				[Address(RVA = "0x133CD9C", Offset = "0x133CD9C", VA = "0x133CD9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x133C28C", Offset = "0x133C28C", VA = "0x133C28C")]
			[DebuggerHidden]
			public <ProgressiveMesh>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x133C2B4", Offset = "0x133C2B4", VA = "0x133C2B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x133C2B8", Offset = "0x133C2B8", VA = "0x133C2B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x133CD5C", Offset = "0x133CD5C", VA = "0x133CD5C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000182")]
		[CompilerGenerated]
		private sealed class <ComputeMeshWithVertexCount>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Simplifier <>4__this;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int nVertices;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Mesh meshOut;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public GameObject gameObject;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public ProgressDelegate progress;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string strProgressDisplayObjectName;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private List<Vertex> <listVertices>5__2;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int <nTotalVertices>5__3;

			[Token(Token = "0x170000D5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007FD")]
				[Address(RVA = "0x133D898", Offset = "0x133D898", VA = "0x133D898", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007FF")]
				[Address(RVA = "0x133D8E0", Offset = "0x133D8E0", VA = "0x133D8E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x133CDA4", Offset = "0x133CDA4", VA = "0x133CDA4")]
			[DebuggerHidden]
			public <ComputeMeshWithVertexCount>d__25(int <>1__state)
			{
			}

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x133CDCC", Offset = "0x133CDCC", VA = "0x133CDCC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x133CDD0", Offset = "0x133CDD0", VA = "0x133CDD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x133D8A0", Offset = "0x133D8A0", VA = "0x133D8A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000183")]
		[CompilerGenerated]
		private sealed class <ConsolidateMesh>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Mesh meshIn;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TriangleList[] aListTriangles;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ProgressDelegate progress;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string strProgressDisplayObjectName;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Mesh meshOut;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public GameObject gameObject;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Vector3[] <av3NormalsIn>5__2;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Vector4[] <av4TangentsIn>5__3;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector2[] <av2Mapping1In>5__4;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector2[] <av2Mapping2In>5__5;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Color[] <acolColorsIn>5__6;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Color32[] <aColors32In>5__7;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private List<List<int>> <listlistIndicesOut>5__8;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private List<Vector3> <listVerticesOut>5__9;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private List<Vector3> <listNormalsOut>5__10;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private List<Vector4> <listTangentsOut>5__11;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private List<Vector2> <listMapping1Out>5__12;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private List<Vector2> <listMapping2Out>5__13;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private List<Color32> <listColors32Out>5__14;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private List<BoneWeight> <listBoneWeightsOut>5__15;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Dictionary<VertexDataHash, int> <dicVertexDataHash2Index>5__16;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private bool <bUV1>5__17;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
			private bool <bUV2>5__18;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
			private bool <bNormal>5__19;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCB")]
			private bool <bTangent>5__20;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int <nSubMesh>5__21;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private List<int> <listIndicesOut>5__22;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private string <strMesh>5__23;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private int <i>5__24;

			[Token(Token = "0x170000D7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000803")]
				[Address(RVA = "0x133F140", Offset = "0x133F140", VA = "0x133F140", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000805")]
				[Address(RVA = "0x133F188", Offset = "0x133F188", VA = "0x133F188", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x133D8E8", Offset = "0x133D8E8", VA = "0x133D8E8")]
			[DebuggerHidden]
			public <ConsolidateMesh>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x6000801")]
			[Address(RVA = "0x133D910", Offset = "0x133D910", VA = "0x133D910", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x133D914", Offset = "0x133D914", VA = "0x133D914", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x133F148", Offset = "0x133F148", VA = "0x133F148", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000184")]
		[CompilerGenerated]
		private sealed class <ComputeAllEdgeCollapseCosts>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ProgressDelegate progress;

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string strProgressDisplayObjectName;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Simplifier <>4__this;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform transform;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RelevanceSphere[] aRelevanceSpheres;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <i>5__2;

			[Token(Token = "0x170000D9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000809")]
				[Address(RVA = "0x133F450", Offset = "0x133F450", VA = "0x133F450", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600080B")]
				[Address(RVA = "0x133F498", Offset = "0x133F498", VA = "0x133F498", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x133F190", Offset = "0x133F190", VA = "0x133F190")]
			[DebuggerHidden]
			public <ComputeAllEdgeCollapseCosts>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000807")]
			[Address(RVA = "0x133F1B8", Offset = "0x133F1B8", VA = "0x133F1B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000808")]
			[Address(RVA = "0x133F1BC", Offset = "0x133F1BC", VA = "0x133F1BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600080A")]
			[Address(RVA = "0x133F458", Offset = "0x133F458", VA = "0x133F458", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int m_nCoroutineFrameMiliseconds;

		[Token(Token = "0x40006E2")]
		private const float MAX_VERTEX_COLLAPSE_COST = 10000000f;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Vertex> m_listVertices;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Vertex> m_listHeap;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TriangleList[] m_aListTriangles;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private int m_nOriginalMeshVertexCount;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[HideInInspector]
		[SerializeField]
		private float m_fOriginalMeshSize;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private List<int> m_listVertexMap;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private List<int> m_listVertexPermutationBack;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private MeshUniqueVertices m_meshUniqueVertices;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private Mesh m_meshOriginal;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		private bool m_bUseEdgeLength;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[HideInInspector]
		[SerializeField]
		private bool m_bUseCurvature;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		[HideInInspector]
		[SerializeField]
		private bool m_bProtectTexture;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		[HideInInspector]
		[SerializeField]
		private bool m_bLockBorder;

		[Token(Token = "0x170000C2")]
		public static bool Cancelled
		{
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x133747C", Offset = "0x133747C", VA = "0x133747C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x13374C4", Offset = "0x13374C4", VA = "0x13374C4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public static int CoroutineFrameMiliseconds
		{
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x1337510", Offset = "0x1337510", VA = "0x1337510")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x1337558", Offset = "0x1337558", VA = "0x1337558")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public bool CoroutineEnded
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x13375A4", Offset = "0x13375A4", VA = "0x13375A4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x13375AC", Offset = "0x13375AC", VA = "0x13375AC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public bool UseEdgeLength
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x13375B8", Offset = "0x13375B8", VA = "0x13375B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x13375C0", Offset = "0x13375C0", VA = "0x13375C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public bool UseCurvature
		{
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x13375CC", Offset = "0x13375CC", VA = "0x13375CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x13375D4", Offset = "0x13375D4", VA = "0x13375D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public bool ProtectTexture
		{
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x13375E0", Offset = "0x13375E0", VA = "0x13375E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x13375E8", Offset = "0x13375E8", VA = "0x13375E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public bool LockBorder
		{
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x13375F4", Offset = "0x13375F4", VA = "0x13375F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x13375FC", Offset = "0x13375FC", VA = "0x13375FC")]
			set
			{
			}
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x1337608", Offset = "0x1337608", VA = "0x1337608")]
		[IteratorStateMachine(typeof(<ProgressiveMesh>d__24))]
		public IEnumerator ProgressiveMesh(GameObject gameObject, Mesh sourceMesh, RelevanceSphere[] aRelevanceSpheres, string strProgressDisplayObjectName = "", [Optional] ProgressDelegate progress)
		{
			return null;
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x13376F8", Offset = "0x13376F8", VA = "0x13376F8")]
		[IteratorStateMachine(typeof(<ComputeMeshWithVertexCount>d__25))]
		public IEnumerator ComputeMeshWithVertexCount(GameObject gameObject, Mesh meshOut, int nVertices, string strProgressDisplayObjectName = "", [Optional] ProgressDelegate progress)
		{
			return null;
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x13377DC", Offset = "0x13377DC", VA = "0x13377DC")]
		public int GetOriginalMeshUniqueVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x13377E4", Offset = "0x13377E4", VA = "0x13377E4")]
		public int GetOriginalMeshTriangleCount()
		{
			return default(int);
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1337824", Offset = "0x1337824", VA = "0x1337824")]
		public static Vector3[] GetWorldVertices(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x1337FF8", Offset = "0x1337FF8", VA = "0x1337FF8")]
		[IteratorStateMachine(typeof(<ConsolidateMesh>d__29))]
		private IEnumerator ConsolidateMesh(GameObject gameObject, Mesh meshIn, Mesh meshOut, TriangleList[] aListTriangles, Vector3[] av3Vertices, string strProgressDisplayObjectName = "", [Optional] ProgressDelegate progress)
		{
			return null;
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x13380E8", Offset = "0x13380E8", VA = "0x13380E8")]
		private int MapVertex(int nVertex, int nMax)
		{
			return default(int);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x1338178", Offset = "0x1338178", VA = "0x1338178")]
		private float ComputeEdgeCollapseCost(Vertex u, Vertex v, float fRelevanceBias)
		{
			return default(float);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x13385A8", Offset = "0x13385A8", VA = "0x13385A8")]
		private void ComputeEdgeCostAtVertex(Vertex v, Transform transform, RelevanceSphere[] aRelevanceSpheres)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x13388C8", Offset = "0x13388C8", VA = "0x13388C8")]
		[IteratorStateMachine(typeof(<ComputeAllEdgeCollapseCosts>d__33))]
		private IEnumerator ComputeAllEdgeCollapseCosts(string strProgressDisplayObjectName, Transform transform, RelevanceSphere[] aRelevanceSpheres, [Optional] ProgressDelegate progress)
		{
			return null;
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x133899C", Offset = "0x133899C", VA = "0x133899C")]
		private void Collapse(Vertex u, Vertex v, bool bRecompute, Transform transform, RelevanceSphere[] aRelevanceSpheres)
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x13391F0", Offset = "0x13391F0", VA = "0x13391F0")]
		private void AddVertices(List<Vector3> listVertices, List<Vector3> listVerticesWorld, List<MeshUniqueVertices.SerializableBoneWeight> listBoneWeights)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x13393C0", Offset = "0x13393C0", VA = "0x13393C0")]
		private void AddFaceListSubMesh(int nSubMesh, List<int> listTriangles, int[] anIndices, Vector2[] v2Mapping)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x1339628", Offset = "0x1339628", VA = "0x1339628")]
		private void ShareUV(Vector2[] aMapping, Triangle t)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x13397F8", Offset = "0x13397F8", VA = "0x13397F8")]
		private Vertex MinimumCostEdge()
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x13398A0", Offset = "0x13398A0", VA = "0x13398A0")]
		private float HeapValue(int i)
		{
			return default(float);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x1338ED8", Offset = "0x1338ED8", VA = "0x1338ED8")]
		private void HeapSortUp(int k)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1339050", Offset = "0x1339050", VA = "0x1339050")]
		private void HeapSortDown(int k)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x133994C", Offset = "0x133994C", VA = "0x133994C")]
		private void HeapAdd(Vertex v)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x13397FC", Offset = "0x13397FC", VA = "0x13397FC")]
		private Vertex HeapPop()
		{
			return null;
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1339A18", Offset = "0x1339A18", VA = "0x1339A18")]
		public Simplifier()
		{
		}
	}
}
namespace App
{
	[Token(Token = "0x2000185")]
	public class DynamicResolutionManager : Singleton<DynamicResolutionManager>
	{
		[Token(Token = "0x2000186")]
		public enum LoadLevel
		{
			[Token(Token = "0x400074A")]
			LOW,
			[Token(Token = "0x400074B")]
			MEDIUM,
			[Token(Token = "0x400074C")]
			HEAVY,
			[Token(Token = "0x400074D")]
			EXTREME
		}

		[Token(Token = "0x2000187")]
		public class Load
		{
			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LoadLevel level;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float time;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int id;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string name;

			[Token(Token = "0x6000819")]
			[Address(RVA = "0x133F5C8", Offset = "0x133F5C8", VA = "0x133F5C8")]
			public Load()
			{
			}
		}

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float minTimeBetweenChanges;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float[] levels;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastChangeTime;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float scale;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private LoadLevel highestLoad;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Stack<Load> loadCache;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<int, Load> currentLoad;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int s_id;

		[Token(Token = "0x170000DB")]
		public float CurrentScale
		{
			[Token(Token = "0x600080C")]
			[Address(RVA = "0x133F4A0", Offset = "0x133F4A0", VA = "0x133F4A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000DC")]
		public int CurrentLoadCount
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x133F4A8", Offset = "0x133F4A8", VA = "0x133F4A8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DD")]
		public LoadLevel HighestLoad
		{
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x133F4F8", Offset = "0x133F4F8", VA = "0x133F4F8")]
			get
			{
				return default(LoadLevel);
			}
		}

		[Token(Token = "0x170000DE")]
		public Dictionary<int, Load> CurrentLoad
		{
			[Token(Token = "0x600080F")]
			[Address(RVA = "0x133F500", Offset = "0x133F500", VA = "0x133F500")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x133F508", Offset = "0x133F508", VA = "0x133F508")]
		private Load GetLoad()
		{
			return null;
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x133F5D0", Offset = "0x133F5D0", VA = "0x133F5D0")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x133F77C", Offset = "0x133F77C", VA = "0x133F77C")]
		public void SignalLoad(LoadLevel loadLevel, string name, ref int id)
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x133F6EC", Offset = "0x133F6EC", VA = "0x133F6EC")]
		public void SignalRemoveLoad(ref int id)
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x133F874", Offset = "0x133F874", VA = "0x133F874")]
		private void Start()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x133F9D8", Offset = "0x133F9D8", VA = "0x133F9D8")]
		private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x133FB1C", Offset = "0x133FB1C", VA = "0x133FB1C")]
		private void UpdateJob()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x133FE3C", Offset = "0x133FE3C", VA = "0x133FE3C")]
		public DynamicResolutionManager()
		{
		}
	}
}
namespace Borodar.ScreenShooter
{
	[Token(Token = "0x2000188")]
	public class Rotator : MonoBehaviour
	{
		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Angles;

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x1340008", Offset = "0x1340008", VA = "0x1340008")]
		protected void Update()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x1340064", Offset = "0x1340064", VA = "0x1340064")]
		public Rotator()
		{
		}
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x2000189")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x170000DF")]
		public bool Highlight
		{
			[Token(Token = "0x600081C")]
			[Address(RVA = "0x134006C", Offset = "0x134006C", VA = "0x134006C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600081D")]
			[Address(RVA = "0x1340074", Offset = "0x1340074", VA = "0x1340074")]
			set
			{
			}
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1340080", Offset = "0x1340080", VA = "0x1340080")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x1340220", Offset = "0x1340220", VA = "0x1340220", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x134023C", Offset = "0x134023C", VA = "0x134023C", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x1340258", Offset = "0x1340258", VA = "0x1340258")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x134012C", Offset = "0x134012C", VA = "0x134012C")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x134050C", Offset = "0x134050C", VA = "0x134050C")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x200018A")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x170000E0")]
		public bool InRange
		{
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x1340584", Offset = "0x1340584", VA = "0x1340584")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000826")]
			[Address(RVA = "0x134058C", Offset = "0x134058C", VA = "0x134058C")]
			set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public bool Targeted
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x13406F8", Offset = "0x13406F8", VA = "0x13406F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x1340700", Offset = "0x1340700", VA = "0x1340700")]
			set
			{
			}
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x134070C", Offset = "0x134070C", VA = "0x134070C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x1340598", Offset = "0x1340598", VA = "0x1340598")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x13408FC", Offset = "0x13408FC", VA = "0x13408FC")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x200018B")]
	[RequireComponent(typeof(Rigidbody))]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x170000E2")]
		public bool UseSpherecast
		{
			[Token(Token = "0x600082C")]
			[Address(RVA = "0x1340904", Offset = "0x1340904", VA = "0x1340904")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600082D")]
			[Address(RVA = "0x134090C", Offset = "0x134090C", VA = "0x134090C")]
			set
			{
			}
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x1340928", Offset = "0x1340928", VA = "0x1340928", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x1340B34", Offset = "0x1340B34", VA = "0x1340B34", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x1341420", Offset = "0x1341420", VA = "0x1341420", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x1341988", Offset = "0x1341988", VA = "0x1341988", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x1341D98", Offset = "0x1341D98", VA = "0x1341D98")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x1340D5C", Offset = "0x1340D5C", VA = "0x1340D5C")]
		protected bool FindTarget(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x1341E84", Offset = "0x1341E84", VA = "0x1341E84")]
		protected bool FindTargetWithSpherecast(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x1342284", Offset = "0x1342284", VA = "0x1342284", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x134229C", Offset = "0x134229C", VA = "0x134229C", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x13422A4", Offset = "0x13422A4", VA = "0x13422A4")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x200018C")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x200018D")]
		public enum CrosshairState
		{
			[Token(Token = "0x4000771")]
			Disabled,
			[Token(Token = "0x4000772")]
			Enabled,
			[Token(Token = "0x4000773")]
			Targeted
		}

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x13422C4", Offset = "0x13422C4", VA = "0x13422C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x1340870", Offset = "0x1340870", VA = "0x1340870")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x134232C", Offset = "0x134232C", VA = "0x134232C")]
		private void Update()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x1342364", Offset = "0x1342364", VA = "0x1342364")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x200018E")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x134236C", Offset = "0x134236C", VA = "0x134236C")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x1342418", Offset = "0x1342418", VA = "0x1342418")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x13424C0", Offset = "0x13424C0", VA = "0x13424C0")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x200018F")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x13424C8", Offset = "0x13424C8", VA = "0x13424C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x13425B4", Offset = "0x13425B4", VA = "0x13425B4")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x13425C0", Offset = "0x13425C0", VA = "0x13425C0")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x13425CC", Offset = "0x13425CC", VA = "0x13425CC")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x2000190")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x13425D4", Offset = "0x13425D4", VA = "0x13425D4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x1342624", Offset = "0x1342624", VA = "0x1342624")]
		private void Update()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x13429FC", Offset = "0x13429FC", VA = "0x13429FC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x1342AE8", Offset = "0x1342AE8", VA = "0x1342AE8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x1342628", Offset = "0x1342628", VA = "0x1342628")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x1342BD4", Offset = "0x1342BD4", VA = "0x1342BD4")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x2000191")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x2000192")]
		public enum ContactTest
		{
			[Token(Token = "0x400078A")]
			PerpenTest,
			[Token(Token = "0x400078B")]
			BackwardsPress
		}

		[Token(Token = "0x400077B")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x400077C")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _allowMultipleNearFieldInteraction;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x170000E3")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x1342CAC", Offset = "0x1342CAC", VA = "0x1342CAC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E4")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x1342CB4", Offset = "0x1342CB4", VA = "0x1342CB4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000E5")]
		public InteractableState CurrentButtonState
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x1342CC0", Offset = "0x1342CC0", VA = "0x1342CC0")]
			[CompilerGenerated]
			get
			{
				return default(InteractableState);
			}
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x1342CC8", Offset = "0x1342CC8", VA = "0x1342CC8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x1342CD0", Offset = "0x1342CD0", VA = "0x1342CD0", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x1342E20", Offset = "0x1342E20", VA = "0x1342E20")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x1343028", Offset = "0x1343028", VA = "0x1343028", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x13435EC", Offset = "0x13435EC", VA = "0x13435EC")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x1343754", Offset = "0x1343754", VA = "0x1343754")]
		public void ForceResetButton()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x1343510", Offset = "0x1343510", VA = "0x1343510")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x1343860", Offset = "0x1343860", VA = "0x1343860")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x134396C", Offset = "0x134396C", VA = "0x134396C")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x13439F4", Offset = "0x13439F4", VA = "0x13439F4")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x2000193")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x170000E6")]
		public Collider Collider
		{
			[Token(Token = "0x6000856")]
			[Address(RVA = "0x1343B18", Offset = "0x1343B18", VA = "0x1343B18", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000857")]
			[Address(RVA = "0x1343B20", Offset = "0x1343B20", VA = "0x1343B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0x1343B28", Offset = "0x1343B28", VA = "0x1343B28", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000859")]
			[Address(RVA = "0x1343B30", Offset = "0x1343B30", VA = "0x1343B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x600085A")]
			[Address(RVA = "0x1343B38", Offset = "0x1343B38", VA = "0x1343B38", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x1343B88", Offset = "0x1343B88", VA = "0x1343B88")]
		private void Awake()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x1343C1C", Offset = "0x1343C1C", VA = "0x1343C1C")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x2000194")]
	public interface ColliderZone
	{
		[Token(Token = "0x170000E9")]
		Collider Collider
		{
			[Token(Token = "0x600085D")]
			get;
		}

		[Token(Token = "0x170000EA")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x600085E")]
			get;
		}

		[Token(Token = "0x170000EB")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x600085F")]
			get;
		}
	}
	[Token(Token = "0x2000195")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x1342F7C", Offset = "0x1342F7C", VA = "0x1342F7C")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x2000196")]
	public enum InteractionType
	{
		[Token(Token = "0x4000794")]
		Enter,
		[Token(Token = "0x4000795")]
		Stay,
		[Token(Token = "0x4000796")]
		Exit
	}
	[Token(Token = "0x2000197")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x2000198")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x40007A8")]
			Mesh,
			[Token(Token = "0x40007A9")]
			Skeleton,
			[Token(Token = "0x40007AA")]
			Both
		}

		[Token(Token = "0x2000199")]
		[CompilerGenerated]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x170000F7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000882")]
				[Address(RVA = "0x134507C", Offset = "0x134507C", VA = "0x134507C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000884")]
				[Address(RVA = "0x13450C4", Offset = "0x13450C4", VA = "0x13450C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x1344674", Offset = "0x1344674", VA = "0x1344674")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0x1344E5C", Offset = "0x1344E5C", VA = "0x1344E5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0x1344E60", Offset = "0x1344E60", VA = "0x1344E60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0x1345084", Offset = "0x1345084", VA = "0x1345084", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000797")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x170000EC")]
		public OVRHand RightHand
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x1343C24", Offset = "0x1343C24", VA = "0x1343C24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x1343C50", Offset = "0x1343C50", VA = "0x1343C50")]
			private set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0x1343CB4", Offset = "0x1343CB4", VA = "0x1343CB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x1343CE0", Offset = "0x1343CE0", VA = "0x1343CE0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x1343D44", Offset = "0x1343D44", VA = "0x1343D44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x1343D70", Offset = "0x1343D70", VA = "0x1343D70")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x1343DD4", Offset = "0x1343DD4", VA = "0x1343DD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x1343E00", Offset = "0x1343E00", VA = "0x1343E00")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x1343E64", Offset = "0x1343E64", VA = "0x1343E64")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086A")]
			[Address(RVA = "0x1343E90", Offset = "0x1343E90", VA = "0x1343E90")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0x1343EF4", Offset = "0x1343EF4", VA = "0x1343EF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x1343F1C", Offset = "0x1343F1C", VA = "0x1343F1C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x600086D")]
			[Address(RVA = "0x1343F7C", Offset = "0x1343F7C", VA = "0x1343F7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x1343FA4", Offset = "0x1343FA4", VA = "0x1343FA4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x600086F")]
			[Address(RVA = "0x1344004", Offset = "0x1344004", VA = "0x1344004")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x134402C", Offset = "0x134402C", VA = "0x134402C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0x134408C", Offset = "0x134408C", VA = "0x134408C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000872")]
			[Address(RVA = "0x13440B4", Offset = "0x13440B4", VA = "0x13440B4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x6000873")]
			[Address(RVA = "0x1344114", Offset = "0x1344114", VA = "0x1344114")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000874")]
			[Address(RVA = "0x134413C", Offset = "0x134413C", VA = "0x134413C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public static HandsManager Instance
		{
			[Token(Token = "0x6000875")]
			[Address(RVA = "0x134419C", Offset = "0x134419C", VA = "0x134419C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000876")]
			[Address(RVA = "0x13441E4", Offset = "0x13441E4", VA = "0x13441E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x134423C", Offset = "0x134423C", VA = "0x134423C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x13445F8", Offset = "0x13445F8", VA = "0x13445F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x1344584", Offset = "0x1344584", VA = "0x1344584")]
		[IteratorStateMachine(typeof(<FindSkeletonVisualGameObjects>d__52))]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x134469C", Offset = "0x134469C", VA = "0x134469C")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x1344760", Offset = "0x1344760", VA = "0x1344760")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x1344930", Offset = "0x1344930", VA = "0x1344930")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x1344B94", Offset = "0x1344B94", VA = "0x1344B94")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x1344CF4", Offset = "0x1344CF4", VA = "0x1344CF4")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x200019A")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200019B")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x1345714", Offset = "0x1345714", VA = "0x1345714")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x170000F9")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x6000885")]
			[Address(RVA = "0x13450CC", Offset = "0x13450CC", VA = "0x13450CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FA")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x6000886")]
			[Address(RVA = "0x13450D4", Offset = "0x13450D4", VA = "0x13450D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FB")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x6000887")]
			[Address(RVA = "0x13450DC", Offset = "0x13450DC", VA = "0x13450DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x13450E4", Offset = "0x13450E4", VA = "0x13450E4", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x6000889")]
			[Address(RVA = "0x13450EC", Offset = "0x13450EC", VA = "0x13450EC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600088A")]
			[Address(RVA = "0x134519C", Offset = "0x134519C", VA = "0x134519C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x600088C")]
			[Address(RVA = "0x1345268", Offset = "0x1345268", VA = "0x1345268")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x1345318", Offset = "0x1345318", VA = "0x1345318")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0x13453E4", Offset = "0x13453E4", VA = "0x13453E4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000890")]
			[Address(RVA = "0x1345494", Offset = "0x1345494", VA = "0x1345494")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x134524C", Offset = "0x134524C", VA = "0x134524C", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x13453C8", Offset = "0x13453C8", VA = "0x13453C8", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x1345544", Offset = "0x1345544", VA = "0x1345544", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000892")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x1342DCC", Offset = "0x1342DCC", VA = "0x1342DCC", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x1345610", Offset = "0x1345610", VA = "0x1345610", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x1343B10", Offset = "0x1343B10", VA = "0x1343B10")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x200019C")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x40007B6")]
		None,
		[Token(Token = "0x40007B7")]
		Proximity,
		[Token(Token = "0x40007B8")]
		Contact,
		[Token(Token = "0x40007B9")]
		Action
	}
	[Token(Token = "0x200019D")]
	public enum InteractableState
	{
		[Token(Token = "0x40007BB")]
		Default,
		[Token(Token = "0x40007BC")]
		ProximityState,
		[Token(Token = "0x40007BD")]
		ContactState,
		[Token(Token = "0x40007BE")]
		ActionState
	}
	[Token(Token = "0x200019E")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x134369C", Offset = "0x134369C", VA = "0x134369C")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x200019F")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x170000FD")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x6000898")]
			[Address(RVA = "0x134575C", Offset = "0x134575C", VA = "0x134575C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x1345560", Offset = "0x1345560", VA = "0x1345560")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x1345664", Offset = "0x1345664", VA = "0x1345664")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x13457B4", Offset = "0x13457B4", VA = "0x13457B4")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x20001A0")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x20001A1")]
		[CompilerGenerated]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x170000FE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008A5")]
				[Address(RVA = "0x1345F74", Offset = "0x1345F74", VA = "0x1345F74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008A7")]
				[Address(RVA = "0x1345FBC", Offset = "0x1345FBC", VA = "0x1345FBC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x134595C", Offset = "0x134595C", VA = "0x134595C")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x1345A98", Offset = "0x1345A98", VA = "0x1345A98", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x1345AB4", Offset = "0x1345AB4", VA = "0x1345AB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x1345F24", Offset = "0x1345F24", VA = "0x1345F24")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x1345F7C", Offset = "0x1345F7C", VA = "0x1345F7C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x1345854", Offset = "0x1345854", VA = "0x1345854")]
		private void Awake()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x13458C0", Offset = "0x13458C0", VA = "0x13458C0")]
		[IteratorStateMachine(typeof(<AttachToolsToHands>d__3))]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x1345984", Offset = "0x1345984", VA = "0x1345984")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x1345A90", Offset = "0x1345A90", VA = "0x1345A90")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x20001A2")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x17000100")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x1345FC4", Offset = "0x1345FC4", VA = "0x1345FC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x1346120", Offset = "0x1346120", VA = "0x1346120")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x13461BC", Offset = "0x13461BC", VA = "0x13461BC")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x1346258", Offset = "0x1346258", VA = "0x1346258")]
		private void Update()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x13464F4", Offset = "0x13464F4", VA = "0x13464F4")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x1346530", Offset = "0x1346530", VA = "0x1346530")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x1346808", Offset = "0x1346808", VA = "0x1346808")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x1346A10", Offset = "0x1346A10", VA = "0x1346A10")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x20001A3")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x20001A4")]
		[CompilerGenerated]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x17000105")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008C1")]
				[Address(RVA = "0x1347BE0", Offset = "0x1347BE0", VA = "0x1347BE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000106")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008C3")]
				[Address(RVA = "0x1347C28", Offset = "0x1347C28", VA = "0x1347C28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x1346CAC", Offset = "0x1346CAC", VA = "0x1346CAC")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x1347750", Offset = "0x1347750", VA = "0x1347750", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x1347754", Offset = "0x1347754", VA = "0x1347754", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x1347BE8", Offset = "0x1347BE8", VA = "0x1347BE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007D7")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x17000101")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x1346B18", Offset = "0x1346B18", VA = "0x1346B18", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x17000102")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x1346B20", Offset = "0x1346B20", VA = "0x1346B20", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x17000103")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x1346B28", Offset = "0x1346B28", VA = "0x1346B28", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000104")]
		public override bool EnableState
		{
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x1346B30", Offset = "0x1346B30", VA = "0x1346B30", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x1346B58", Offset = "0x1346B58", VA = "0x1346B58", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x1346B88", Offset = "0x1346B88", VA = "0x1346B88", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x1346C38", Offset = "0x1346C38", VA = "0x1346C38")]
		[IteratorStateMachine(typeof(<AttachTriggerLogic>d__21))]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x1346CD4", Offset = "0x1346CD4", VA = "0x1346CD4")]
		private void Update()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x1346F54", Offset = "0x1346F54", VA = "0x1346F54")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x1347110", Offset = "0x1347110", VA = "0x1347110")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x13471F8", Offset = "0x13471F8", VA = "0x13471F8", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x134758C", Offset = "0x134758C", VA = "0x134758C", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x1347590", Offset = "0x1347590", VA = "0x1347590", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x1347594", Offset = "0x1347594", VA = "0x1347594")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	public class FingerTipPokeToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x17000107")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x1347C30", Offset = "0x1347C30", VA = "0x1347C30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x1347C38", Offset = "0x1347C38", VA = "0x1347C38")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public bool EnableState
		{
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x1347C40", Offset = "0x1347C40", VA = "0x1347C40", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x1347C5C", Offset = "0x1347C5C", VA = "0x1347C5C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x1347C7C", Offset = "0x1347C7C", VA = "0x1347C7C", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x1347C84", Offset = "0x1347C84", VA = "0x1347C84", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public float SphereRadius
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x1347C90", Offset = "0x1347C90", VA = "0x1347C90")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x1347C98", Offset = "0x1347C98", VA = "0x1347C98")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x1347CA0", Offset = "0x1347CA0", VA = "0x1347CA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x1347CDC", Offset = "0x1347CDC", VA = "0x1347CDC", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x1347CE0", Offset = "0x1347CE0", VA = "0x1347CE0")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x20001A6")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x40007EA")]
		None = 0,
		[Token(Token = "0x40007EB")]
		Ray = 1,
		[Token(Token = "0x40007EC")]
		Poke = 4,
		[Token(Token = "0x40007ED")]
		All = -1
	}
	[Token(Token = "0x20001A7")]
	public enum ToolInputState
	{
		[Token(Token = "0x40007EF")]
		Inactive,
		[Token(Token = "0x40007F0")]
		PrimaryInputDown,
		[Token(Token = "0x40007F1")]
		PrimaryInputDownStay,
		[Token(Token = "0x40007F2")]
		PrimaryInputUp
	}
	[Token(Token = "0x20001A8")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x1347538", Offset = "0x1347538", VA = "0x1347538")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x20001A9")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x1700010B")]
		public Transform ToolTransform
		{
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x13439EC", Offset = "0x13439EC", VA = "0x13439EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010C")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x1347CE8", Offset = "0x1347CE8", VA = "0x1347CE8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x1347CF0", Offset = "0x1347CF0", VA = "0x1347CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x60008D3")]
			get;
		}

		[Token(Token = "0x1700010E")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x60008D4")]
			get;
		}

		[Token(Token = "0x1700010F")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x60008D5")]
			get;
		}

		[Token(Token = "0x17000110")]
		public Vector3 Velocity
		{
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x1347CFC", Offset = "0x1347CFC", VA = "0x1347CFC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x1347D08", Offset = "0x1347D08", VA = "0x1347D08")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000111")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x1347D14", Offset = "0x1347D14", VA = "0x1347D14")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x1347D20", Offset = "0x1347D20", VA = "0x1347D20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000112")]
		public abstract bool EnableState
		{
			[Token(Token = "0x60008DE")]
			get;
			[Token(Token = "0x60008DF")]
			set;
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x1347D2C", Offset = "0x1347D2C", VA = "0x1347D2C")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60008DB")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x60008DC")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x60008DD")]
		public abstract void DeFocus();

		[Token(Token = "0x60008E0")]
		public abstract void Initialize();

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x1346978", Offset = "0x1346978", VA = "0x1346978")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x13469C0", Offset = "0x13469C0", VA = "0x13469C0")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x1347D34", Offset = "0x1347D34", VA = "0x1347D34", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x1347FFC", Offset = "0x1347FFC", VA = "0x1347FFC", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x13475A8", Offset = "0x13475A8", VA = "0x13475A8")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x20001AA")]
	public interface InteractableToolView
	{
		[Token(Token = "0x17000113")]
		InteractableTool InteractableTool
		{
			[Token(Token = "0x60008E6")]
			get;
		}

		[Token(Token = "0x17000114")]
		bool EnableState
		{
			[Token(Token = "0x60008E8")]
			get;
			[Token(Token = "0x60008E9")]
			set;
		}

		[Token(Token = "0x17000115")]
		bool ToolActivateState
		{
			[Token(Token = "0x60008EA")]
			get;
			[Token(Token = "0x60008EB")]
			set;
		}

		[Token(Token = "0x60008E7")]
		void SetFocusedInteractable(Interactable interactable);
	}
	[Token(Token = "0x20001AB")]
	public class PinchStateModule
	{
		[Token(Token = "0x20001AC")]
		private enum PinchState
		{
			[Token(Token = "0x4000803")]
			None,
			[Token(Token = "0x4000804")]
			PinchDown,
			[Token(Token = "0x4000805")]
			PinchStay,
			[Token(Token = "0x4000806")]
			PinchUp
		}

		[Token(Token = "0x40007FF")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x17000116")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x1348898", Offset = "0x1348898", VA = "0x1348898")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000117")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x1348914", Offset = "0x1348914", VA = "0x1348914")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000118")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x1348990", Offset = "0x1348990", VA = "0x1348990")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x1348A0C", Offset = "0x1348A0C", VA = "0x1348A0C")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x1348A34", Offset = "0x1348A34", VA = "0x1348A34")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x20001AD")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x4000807")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x4000808")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x4000809")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x400080A")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x400080B")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 45f)]
		[SerializeField]
		private float _coneAngleDegrees;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x17000119")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x1348BAC", Offset = "0x1348BAC", VA = "0x1348BAC", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x1700011A")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x1348BB4", Offset = "0x1348BB4", VA = "0x1348BB4", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x1700011B")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x1348C10", Offset = "0x1348C10", VA = "0x1348C10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011C")]
		public override bool EnableState
		{
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x1348C18", Offset = "0x1348C18", VA = "0x1348C18", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x1348C58", Offset = "0x1348C58", VA = "0x1348C58", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x1348CC8", Offset = "0x1348CC8", VA = "0x1348CC8", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x1348D1C", Offset = "0x1348D1C", VA = "0x1348D1C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x1348DA8", Offset = "0x1348DA8", VA = "0x1348DA8")]
		private void Update()
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x134904C", Offset = "0x134904C", VA = "0x134904C")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x13490C8", Offset = "0x13490C8", VA = "0x13490C8", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x13494BC", Offset = "0x13494BC", VA = "0x13494BC")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x1349658", Offset = "0x1349658", VA = "0x1349658")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x1349770", Offset = "0x1349770", VA = "0x1349770")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x1349A94", Offset = "0x1349A94", VA = "0x1349A94")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x1349E10", Offset = "0x1349E10", VA = "0x1349E10", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x1349EE8", Offset = "0x1349EE8", VA = "0x1349EE8", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x1349F18", Offset = "0x1349F18", VA = "0x1349F18")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x20001AE")]
	public class RayToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x4000817")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x4000818")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x1700011D")]
		public bool EnableState
		{
			[Token(Token = "0x6000902")]
			[Address(RVA = "0x1348C3C", Offset = "0x1348C3C", VA = "0x1348C3C", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000903")]
			[Address(RVA = "0x1348C74", Offset = "0x1348C74", VA = "0x1348C74", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public bool ToolActivateState
		{
			[Token(Token = "0x6000904")]
			[Address(RVA = "0x134A02C", Offset = "0x134A02C", VA = "0x134A02C", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000905")]
			[Address(RVA = "0x1349010", Offset = "0x1349010", VA = "0x1349010", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x1700011F")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x6000907")]
			[Address(RVA = "0x134A254", Offset = "0x134A254", VA = "0x134A254", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000908")]
			[Address(RVA = "0x134A25C", Offset = "0x134A25C", VA = "0x134A25C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x134A034", Offset = "0x134A034", VA = "0x134A034")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x1349E48", Offset = "0x1349E48", VA = "0x1349E48", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x134A264", Offset = "0x134A264", VA = "0x134A264")]
		private void Update()
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x134A510", Offset = "0x134A510", VA = "0x134A510")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x134A5B8", Offset = "0x134A5B8", VA = "0x134A5B8")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x20001AF")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x17000120")]
		public bool UseSpherecast
		{
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x134A61C", Offset = "0x134A61C", VA = "0x134A61C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600090E")]
			[Address(RVA = "0x134A624", Offset = "0x134A624", VA = "0x134A624")]
			set
			{
			}
		}

		[Token(Token = "0x17000121")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x600090F")]
			[Address(RVA = "0x134A6A0", Offset = "0x134A6A0", VA = "0x134A6A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000910")]
			[Address(RVA = "0x134A6A8", Offset = "0x134A6A8", VA = "0x134A6A8")]
			set
			{
			}
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x134A704", Offset = "0x134A704", VA = "0x134A704")]
		private void Start()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x134A9A4", Offset = "0x134A9A4", VA = "0x134A9A4")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x134A9B4", Offset = "0x134A9B4", VA = "0x134A9B4")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x134A9C4", Offset = "0x134A9C4", VA = "0x134A9C4")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x20001B0")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x134A9CC", Offset = "0x134A9CC", VA = "0x134A9CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x134A9D0", Offset = "0x134A9D0", VA = "0x134A9D0")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x134AA5C", Offset = "0x134AA5C", VA = "0x134AA5C")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x134AAEC", Offset = "0x134AAEC", VA = "0x134AAEC")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x134AB7C", Offset = "0x134AB7C", VA = "0x134AB7C")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x134AC28", Offset = "0x134AC28", VA = "0x134AC28")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x134AD04", Offset = "0x134AD04", VA = "0x134AD04")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x134AD48", Offset = "0x134AD48", VA = "0x134AD48")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x134ADA8", Offset = "0x134ADA8", VA = "0x134ADA8")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x134AE08", Offset = "0x134AE08", VA = "0x134AE08")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x20001B1")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x134AE10", Offset = "0x134AE10", VA = "0x134AE10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x134AE14", Offset = "0x134AE14", VA = "0x134AE14")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x134ADD8", Offset = "0x134ADD8", VA = "0x134ADD8")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x134AE48", Offset = "0x134AE48", VA = "0x134AE48")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x20001B2")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x20001B3")]
		[CompilerGenerated]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x4000835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x4000836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x4000837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x17000122")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600092B")]
				[Address(RVA = "0x134B4C8", Offset = "0x134B4C8", VA = "0x134B4C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000123")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600092D")]
				[Address(RVA = "0x134B510", Offset = "0x134B510", VA = "0x134B510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0x134B240", Offset = "0x134B240", VA = "0x134B240")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000929")]
			[Address(RVA = "0x134B308", Offset = "0x134B308", VA = "0x134B308", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0x134B30C", Offset = "0x134B30C", VA = "0x134B30C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0x134B4D0", Offset = "0x134B4D0", VA = "0x134B4D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000828")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x4000829")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x134AE50", Offset = "0x134AE50", VA = "0x134AE50")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x134AEF0", Offset = "0x134AEF0", VA = "0x134AEF0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x134B200", Offset = "0x134B200", VA = "0x134B200")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x134B18C", Offset = "0x134B18C", VA = "0x134B18C")]
		[IteratorStateMachine(typeof(<LerpToHMD>d__13))]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x134B268", Offset = "0x134B268", VA = "0x134B268")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x20001B4")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x20001B5")]
		public enum SelectionState
		{
			[Token(Token = "0x400083F")]
			Off,
			[Token(Token = "0x4000840")]
			Selected,
			[Token(Token = "0x4000841")]
			Highlighted
		}

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x17000124")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x134B518", Offset = "0x134B518", VA = "0x134B518")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x134B520", Offset = "0x134B520", VA = "0x134B520")]
			set
			{
			}
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x134B674", Offset = "0x134B674", VA = "0x134B674")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x134B838", Offset = "0x134B838", VA = "0x134B838")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x134B594", Offset = "0x134B594", VA = "0x134B594")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x134B900", Offset = "0x134B900", VA = "0x134B900")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x20001B6")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x20001B7")]
		public enum SegmentType
		{
			[Token(Token = "0x4000850")]
			Straight,
			[Token(Token = "0x4000851")]
			LeftTurn,
			[Token(Token = "0x4000852")]
			RightTurn,
			[Token(Token = "0x4000853")]
			Switch
		}

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x4000848")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x4000849")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x17000125")]
		public float StartDistance
		{
			[Token(Token = "0x6000935")]
			[Address(RVA = "0x134B970", Offset = "0x134B970", VA = "0x134B970")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x134B978", Offset = "0x134B978", VA = "0x134B978")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000126")]
		public float GridSize
		{
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x134B980", Offset = "0x134B980", VA = "0x134B980")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000938")]
			[Address(RVA = "0x134B988", Offset = "0x134B988", VA = "0x134B988")]
			private set
			{
			}
		}

		[Token(Token = "0x17000127")]
		public int SubDivCount
		{
			[Token(Token = "0x6000939")]
			[Address(RVA = "0x134B990", Offset = "0x134B990", VA = "0x134B990")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600093A")]
			[Address(RVA = "0x134B998", Offset = "0x134B998", VA = "0x134B998")]
			set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public SegmentType Type
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x134B9A0", Offset = "0x134B9A0", VA = "0x134B9A0")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x17000129")]
		public Pose EndPose
		{
			[Token(Token = "0x600093C")]
			[Address(RVA = "0x134B9A8", Offset = "0x134B9A8", VA = "0x134B9A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012A")]
		public float Radius
		{
			[Token(Token = "0x600093D")]
			[Address(RVA = "0x134BD7C", Offset = "0x134BD7C", VA = "0x134BD7C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700012B")]
		public float SegmentLength
		{
			[Token(Token = "0x600093F")]
			[Address(RVA = "0x134BA04", Offset = "0x134BA04", VA = "0x134BA04")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x134BD8C", Offset = "0x134BD8C", VA = "0x134BD8C")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x134BDA4", Offset = "0x134BDA4", VA = "0x134BDA4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x134BA44", Offset = "0x134BA44", VA = "0x134BA44")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x134BDA8", Offset = "0x134BDA8", VA = "0x134BDA8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x134BDAC", Offset = "0x134BDAC", VA = "0x134BDAC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x134BE08", Offset = "0x134BE08", VA = "0x134BE08")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x134C73C", Offset = "0x134C73C", VA = "0x134C73C")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x134C9C0", Offset = "0x134C9C0", VA = "0x134C9C0")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x20001B8")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x20001B9")]
		[CompilerGenerated]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x1700012C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000955")]
				[Address(RVA = "0x134D458", Offset = "0x134D458", VA = "0x134D458", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000957")]
				[Address(RVA = "0x134D4A0", Offset = "0x134D4A0", VA = "0x134D4A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000952")]
			[Address(RVA = "0x134D28C", Offset = "0x134D28C", VA = "0x134D28C")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000953")]
			[Address(RVA = "0x134D2DC", Offset = "0x134D2DC", VA = "0x134D2DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000954")]
			[Address(RVA = "0x134D2E0", Offset = "0x134D2E0", VA = "0x134D2E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0x134D460", Offset = "0x134D460", VA = "0x134D460", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000854")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x4000855")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x134CA94", Offset = "0x134CA94", VA = "0x134CA94")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x134CB4C", Offset = "0x134CB4C", VA = "0x134CB4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x134CBDC", Offset = "0x134CBDC", VA = "0x134CBDC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x134CD24", Offset = "0x134CD24", VA = "0x134CD24")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x134CEB0", Offset = "0x134CEB0", VA = "0x134CEB0")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x134CFC0", Offset = "0x134CFC0", VA = "0x134CFC0")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x134D1C4", Offset = "0x134D1C4", VA = "0x134D1C4")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x134D0D0", Offset = "0x134D0D0", VA = "0x134D0D0")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x134D0E4", Offset = "0x134D0E4", VA = "0x134D0E4")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x134D218", Offset = "0x134D218", VA = "0x134D218")]
		[IteratorStateMachine(typeof(<ResetPosition>d__26))]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x134D2B4", Offset = "0x134D2B4", VA = "0x134D2B4")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x20001BA")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x1700012E")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x134D4A8", Offset = "0x134D4A8", VA = "0x134D4A8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x134D4B8", Offset = "0x134D4B8", VA = "0x134D4B8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x134D4C0", Offset = "0x134D4C0", VA = "0x134D4C0", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x134D7F0", Offset = "0x134D7F0", VA = "0x134D7F0")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x20001BB")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x400086D")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x400086E")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x1700012F")]
		public float Distance
		{
			[Token(Token = "0x600095C")]
			[Address(RVA = "0x134D8F4", Offset = "0x134D8F4", VA = "0x134D8F4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x134D8FC", Offset = "0x134D8FC", VA = "0x134D8FC")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000130")]
		public float Scale
		{
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x134D904", Offset = "0x134D904", VA = "0x134D904")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x134D90C", Offset = "0x134D90C", VA = "0x134D90C")]
			set
			{
			}
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x134D4BC", Offset = "0x134D4BC", VA = "0x134D4BC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x134D914", Offset = "0x134D914", VA = "0x134D914")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x134D4FC", Offset = "0x134D4FC", VA = "0x134D4FC")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x134D70C", Offset = "0x134D70C", VA = "0x134D70C")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x6000964")]
		public abstract void UpdatePosition();

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x134D850", Offset = "0x134D850", VA = "0x134D850")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x20001BC")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x20001BD")]
		[CompilerGenerated]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x4000886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x17000131")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000973")]
				[Address(RVA = "0x134E134", Offset = "0x134E134", VA = "0x134E134", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000132")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000975")]
				[Address(RVA = "0x134E17C", Offset = "0x134E17C", VA = "0x134E17C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000970")]
			[Address(RVA = "0x134DDA8", Offset = "0x134DDA8", VA = "0x134DDA8")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000971")]
			[Address(RVA = "0x134DF1C", Offset = "0x134DF1C", VA = "0x134DF1C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000972")]
			[Address(RVA = "0x134DF20", Offset = "0x134DF20", VA = "0x134DF20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000974")]
			[Address(RVA = "0x134E13C", Offset = "0x134E13C", VA = "0x134E13C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x134D9D4", Offset = "0x134D9D4", VA = "0x134D9D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x134DA30", Offset = "0x134DA30", VA = "0x134DA30")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x134DB08", Offset = "0x134DB08", VA = "0x134DB08")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x134DC5C", Offset = "0x134DC5C", VA = "0x134DC5C")]
		private void Update()
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x134DB64", Offset = "0x134DB64", VA = "0x134DB64")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x134DD24", Offset = "0x134DD24", VA = "0x134DD24")]
		[IteratorStateMachine(typeof(<AnimateCrossing>d__15))]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x134DDD0", Offset = "0x134DDD0", VA = "0x134DDD0")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x134DE68", Offset = "0x134DE68", VA = "0x134DE68")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x134DEC4", Offset = "0x134DEC4", VA = "0x134DEC4")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x20001BE")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x20001BF")]
		private enum EngineSoundState
		{
			[Token(Token = "0x40008AB")]
			Start,
			[Token(Token = "0x40008AC")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x40008AD")]
			Stop
		}

		[Token(Token = "0x20001C0")]
		[CompilerGenerated]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x40008B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x40008B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x40008B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x40008B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x17000133")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000988")]
				[Address(RVA = "0x134EA20", Offset = "0x134EA20", VA = "0x134EA20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000134")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600098A")]
				[Address(RVA = "0x134EA68", Offset = "0x134EA68", VA = "0x134EA68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0x134E7C4", Offset = "0x134E7C4", VA = "0x134E7C4")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x6000986")]
			[Address(RVA = "0x134E7EC", Offset = "0x134E7EC", VA = "0x134E7EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000987")]
			[Address(RVA = "0x134E7F0", Offset = "0x134E7F0", VA = "0x134E7F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000989")]
			[Address(RVA = "0x134EA28", Offset = "0x134EA28", VA = "0x134EA28", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400088D")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x400088E")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x400088F")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x4000890")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0.2f, 2.7f)]
		[SerializeField]
		protected float _initialSpeed;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x134E184", Offset = "0x134E184", VA = "0x134E184")]
		private void Start()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x134E2E0", Offset = "0x134E2E0", VA = "0x134E2E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x134E2EC", Offset = "0x134E2EC", VA = "0x134E2EC", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x134AA00", Offset = "0x134AA00", VA = "0x134AA00")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x134E258", Offset = "0x134E258", VA = "0x134E258")]
		[IteratorStateMachine(typeof(<StartStopTrain>d__34))]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x134E424", Offset = "0x134E424", VA = "0x134E424")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x134E3C4", Offset = "0x134E3C4", VA = "0x134E3C4")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x134AA8C", Offset = "0x134AA8C", VA = "0x134AA8C")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x134AB1C", Offset = "0x134AB1C", VA = "0x134AB1C")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x134E638", Offset = "0x134E638", VA = "0x134E638")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x134E72C", Offset = "0x134E72C", VA = "0x134E72C")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x134ABAC", Offset = "0x134ABAC", VA = "0x134ABAC")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x134AC58", Offset = "0x134AC58", VA = "0x134AC58")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x134AD38", Offset = "0x134AD38", VA = "0x134AD38")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x134E768", Offset = "0x134E768", VA = "0x134E768")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x20001C1")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x17000135")]
		public float TrackLength
		{
			[Token(Token = "0x600098B")]
			[Address(RVA = "0x134EA70", Offset = "0x134EA70", VA = "0x134EA70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600098C")]
			[Address(RVA = "0x134EA78", Offset = "0x134EA78", VA = "0x134EA78")]
			private set
			{
			}
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x134EA80", Offset = "0x134EA80", VA = "0x134EA80")]
		private void Awake()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x134EC50", Offset = "0x134EC50", VA = "0x134EC50")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x134EA84", Offset = "0x134EA84", VA = "0x134EA84")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x134ED04", Offset = "0x134ED04", VA = "0x134ED04")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x134EDE4", Offset = "0x134EDE4", VA = "0x134EDE4")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x20001C2")]
	public class Pose
	{
		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x134EE00", Offset = "0x134EE00", VA = "0x134EE00")]
		public Pose()
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x134EE98", Offset = "0x134EE98", VA = "0x134EE98")]
		public Pose(Vector3 position, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x20001C3")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x17000137")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009A0")]
				[Address(RVA = "0x134F48C", Offset = "0x134F48C", VA = "0x134F48C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000138")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009A2")]
				[Address(RVA = "0x134F4D4", Offset = "0x134F4D4", VA = "0x134F4D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600099D")]
			[Address(RVA = "0x134F174", Offset = "0x134F174", VA = "0x134F174")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x600099E")]
			[Address(RVA = "0x134F2E8", Offset = "0x134F2E8", VA = "0x134F2E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600099F")]
			[Address(RVA = "0x134F2EC", Offset = "0x134F2EC", VA = "0x134F2EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x134F494", Offset = "0x134F494", VA = "0x134F494", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001C5")]
		[CompilerGenerated]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x40008D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x40008D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x40008D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x17000139")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009A6")]
				[Address(RVA = "0x134F5B0", Offset = "0x134F5B0", VA = "0x134F5B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009A8")]
				[Address(RVA = "0x134F5F8", Offset = "0x134F5F8", VA = "0x134F5F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x134F250", Offset = "0x134F250", VA = "0x134F250")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x134F4DC", Offset = "0x134F4DC", VA = "0x134F4DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x134F4E0", Offset = "0x134F4E0", VA = "0x134F4E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x134F5B8", Offset = "0x134F5B8", VA = "0x134F5B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008C0")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x17000136")]
		public bool IsMoving
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0x134EEFC", Offset = "0x134EEFC", VA = "0x134EEFC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000995")]
			[Address(RVA = "0x134EF04", Offset = "0x134EF04", VA = "0x134EF04")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x134EF10", Offset = "0x134EF10", VA = "0x134EF10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x134EF40", Offset = "0x134EF40", VA = "0x134EF40")]
		private void Update()
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x134F080", Offset = "0x134F080", VA = "0x134F080")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x134F0F0", Offset = "0x134F0F0", VA = "0x134F0F0")]
		[IteratorStateMachine(typeof(<LerpToSpeed>d__17))]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x134F19C", Offset = "0x134F19C", VA = "0x134F19C")]
		[IteratorStateMachine(typeof(<PlaySoundDelayed>d__18))]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x134F278", Offset = "0x134F278", VA = "0x134F278")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x134F2E0", Offset = "0x134F2E0", VA = "0x134F2E0")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x20001C6")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x134F600", Offset = "0x134F600", VA = "0x134F600")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x134F674", Offset = "0x134F674", VA = "0x134F674")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x134F73C", Offset = "0x134F73C", VA = "0x134F73C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x134F84C", Offset = "0x134F84C", VA = "0x134F84C")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x134F8C8", Offset = "0x134F8C8", VA = "0x134F8C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x134F994", Offset = "0x134F994", VA = "0x134F994")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x20001C7")]
	public enum EUiDisplayType
	{
		[Token(Token = "0x40008DD")]
		EUDT_WorldGeoQuad,
		[Token(Token = "0x40008DE")]
		EUDT_OverlayQuad,
		[Token(Token = "0x40008DF")]
		EUDT_None,
		[Token(Token = "0x40008E0")]
		EUDT_MaxDislayTypes
	}
	[Token(Token = "0x20001C8")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x20001C9")]
		[CompilerGenerated]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x1700013B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C2")]
				[Address(RVA = "0x1351024", Offset = "0x1351024", VA = "0x1351024", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009C4")]
				[Address(RVA = "0x135106C", Offset = "0x135106C", VA = "0x135106C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x13506B4", Offset = "0x13506B4", VA = "0x13506B4")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x1350E28", Offset = "0x1350E28", VA = "0x1350E28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x1350E2C", Offset = "0x1350E2C", VA = "0x1350E2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x135102C", Offset = "0x135102C", VA = "0x135102C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x40008E2")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x40008E3")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x40008E4")]
		private const string noneID = "NoneID";

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("App vs Compositor Comparison Settings")]
		public GameObject mainCamera;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Level Loading Sim Settings")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x134F9A4", Offset = "0x134F9A4", VA = "0x134F9A4")]
		private void Start()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x13501E4", Offset = "0x13501E4", VA = "0x13501E4")]
		private void Update()
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x135030C", Offset = "0x135030C", VA = "0x135030C")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x135043C", Offset = "0x135043C", VA = "0x135043C")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x135056C", Offset = "0x135056C", VA = "0x135056C")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x13502EC", Offset = "0x13502EC", VA = "0x13502EC")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x1350640", Offset = "0x1350640", VA = "0x1350640")]
		[IteratorStateMachine(typeof(<WaitforOVROverlay>d__30))]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x13506DC", Offset = "0x13506DC", VA = "0x13506DC")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x134FE14", Offset = "0x134FE14", VA = "0x134FE14")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x1350824", Offset = "0x1350824", VA = "0x1350824")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x1350704", Offset = "0x1350704", VA = "0x1350704")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x1350BAC", Offset = "0x1350BAC", VA = "0x1350BAC")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x1350C98", Offset = "0x1350C98", VA = "0x1350C98")]
		public OVROverlaySample()
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x20001CA")]
	[RequireComponent(typeof(OVRGrabber))]
	public class Hand : MonoBehaviour
	{
		[Token(Token = "0x40008FC")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x40008FD")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x40008FE")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x40008FF")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x4000900")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x4000901")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x4000902")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x4000903")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x4000904")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x4000905")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x4000906")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x1351074", Offset = "0x1351074", VA = "0x1351074")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x13510CC", Offset = "0x13510CC", VA = "0x13510CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x135151C", Offset = "0x135151C", VA = "0x135151C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x1351608", Offset = "0x1351608", VA = "0x1351608")]
		private void Update()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x135176C", Offset = "0x135176C", VA = "0x135176C")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x1351A3C", Offset = "0x1351A3C", VA = "0x1351A3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x1351B20", Offset = "0x1351B20", VA = "0x1351B20")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x1351CD0", Offset = "0x1351CD0", VA = "0x1351CD0")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x13517F8", Offset = "0x13517F8", VA = "0x13517F8")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x135184C", Offset = "0x135184C", VA = "0x135184C")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x13513DC", Offset = "0x13513DC", VA = "0x13513DC")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x1351DF4", Offset = "0x1351DF4", VA = "0x1351DF4")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x20001CC")]
	public enum HandPoseId
	{
		[Token(Token = "0x400091B")]
		Default,
		[Token(Token = "0x400091C")]
		Generic,
		[Token(Token = "0x400091D")]
		PingPongBall,
		[Token(Token = "0x400091E")]
		Controller
	}
	[Token(Token = "0x20001CD")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x1700013D")]
		public bool AllowPointing
		{
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x1351EAC", Offset = "0x1351EAC", VA = "0x1351EAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700013E")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x1351EB4", Offset = "0x1351EB4", VA = "0x1351EB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700013F")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x1351EBC", Offset = "0x1351EBC", VA = "0x1351EBC")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x1351EC4", Offset = "0x1351EC4", VA = "0x1351EC4")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x20001CE")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x1351ECC", Offset = "0x1351ECC", VA = "0x1351ECC")]
		private void Update()
		{
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x1352198", Offset = "0x1352198", VA = "0x1352198")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x13521E8", Offset = "0x13521E8", VA = "0x13521E8")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x1352220", Offset = "0x1352220", VA = "0x1352220")]
		public TouchController()
		{
		}
	}
}
namespace MantisLOD
{
	[Token(Token = "0x20001CF")]
	internal class My_Half_edge : IComparable
	{
		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool alive;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int pqIndex;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public My_Half_vertex vertex;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int index;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public My_Half_face face;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public My_Half_edge next;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float cost;

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x1352228", Offset = "0x1352228", VA = "0x1352228")]
		public My_Half_edge()
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x1352248", Offset = "0x1352248", VA = "0x1352248", Slot = "4")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001D0")]
	internal class My_Half_vertex
	{
		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool alive;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool on_boundary;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool on_symmetry;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 position;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<My_Half_edge> edges;

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x13522CC", Offset = "0x13522CC", VA = "0x13522CC")]
		public My_Half_vertex()
		{
		}
	}
	[Token(Token = "0x20001D1")]
	internal class My_Half_face
	{
		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool alive;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int mat;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public My_Half_edge edge;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 n;

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x1352364", Offset = "0x1352364", VA = "0x1352364")]
		public My_Half_face()
		{
		}
	}
	[Token(Token = "0x20001D2")]
	internal class My_Half_edge_index
	{
		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public My_Half_edge edge;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int index_from;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int index_to;

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x1352384", Offset = "0x1352384", VA = "0x1352384")]
		public My_Half_edge_index()
		{
		}
	}
	[Token(Token = "0x20001D3")]
	internal class My_Half_trace
	{
		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool safe;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public My_Half_vertex v_from;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public My_Half_vertex v_to;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<My_Half_face> erased_faces;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<My_Half_edge_index> updated_edge_indices;

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x135238C", Offset = "0x135238C", VA = "0x135238C")]
		public My_Half_trace()
		{
		}
	}
	[Token(Token = "0x20001D4")]
	internal abstract class BinaryHeap
	{
		[Token(Token = "0x400093D")]
		private const int rootIndex = 1;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<My_Half_edge> collection;

		[Token(Token = "0x17000140")]
		private int LastNodeIndex
		{
			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x13527CC", Offset = "0x13527CC", VA = "0x13527CC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x1352470", Offset = "0x1352470", VA = "0x1352470")]
		public BinaryHeap()
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x13525AC", Offset = "0x13525AC", VA = "0x13525AC")]
		public BinaryHeap(int capacity)
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x13526FC", Offset = "0x13526FC", VA = "0x13526FC")]
		public void Push(My_Half_edge item)
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x1352970", Offset = "0x1352970", VA = "0x1352970")]
		public My_Half_edge Pop()
		{
			return null;
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x1352C90", Offset = "0x1352C90", VA = "0x1352C90")]
		public bool Remove(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x1352DB4", Offset = "0x1352DB4", VA = "0x1352DB4")]
		public int Size()
		{
			return default(int);
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x1352E00", Offset = "0x1352E00", VA = "0x1352E00")]
		public My_Half_edge Top()
		{
			return null;
		}

		[Token(Token = "0x60009EA")]
		protected abstract bool Compare(My_Half_edge current, My_Half_edge other);

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x1352818", Offset = "0x1352818", VA = "0x1352818")]
		private void BubbleUp(int index)
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x1352AB8", Offset = "0x1352AB8", VA = "0x1352AB8")]
		private void BubbleDown(int index)
		{
		}
	}
	[Token(Token = "0x20001D5")]
	internal class MinHeap : BinaryHeap
	{
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x1352E70", Offset = "0x1352E70", VA = "0x1352E70")]
		public MinHeap()
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x1352E74", Offset = "0x1352E74", VA = "0x1352E74")]
		public MinHeap(int capacity)
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x1352E78", Offset = "0x1352E78", VA = "0x1352E78", Slot = "4")]
		protected override bool Compare(My_Half_edge current, My_Half_edge other)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001D6")]
	internal class Vector3Comparer : IEqualityComparer<Vector3>
	{
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x1352E98", Offset = "0x1352E98", VA = "0x1352E98", Slot = "4")]
		public bool Equals(Vector3 vec1, Vector3 vec2)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x1352EF0", Offset = "0x1352EF0", VA = "0x1352EF0", Slot = "5")]
		public int GetHashCode(Vector3 vec)
		{
			return default(int);
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x1352F54", Offset = "0x1352F54", VA = "0x1352F54")]
		public Vector3Comparer()
		{
		}
	}
	[Token(Token = "0x20001D7")]
	internal class Progressive_Mesh
	{
		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<My_Half_vertex> vertices;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<My_Half_face> faces;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<My_Half_edge> edges;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<My_Half_trace> contract_trace;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly List<Vector3> normals;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<Vector4> colors;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly List<Vector2> uvs;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int current_trace_position;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly MinHeap pq;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 MAX;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 MIN;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float max_square_length_of_mesh;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int face_count;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int mat_count;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool lock_boundary;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		private bool lock_detail;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
		private bool lock_symmetry;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7F")]
		private bool lock_normal;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool lock_shape;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		private bool use_detail_map;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int detail_boost;

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x1352F5C", Offset = "0x1352F5C", VA = "0x1352F5C")]
		public Progressive_Mesh()
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x1353210", Offset = "0x1353210", VA = "0x1353210")]
		public int get_trace_num()
		{
			return default(int);
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x1353258", Offset = "0x1353258", VA = "0x1353258")]
		public void create_progressive_mesh(Vector3[] vertex_array, int vertex_count, int[] triangle_array, int triangle_count, Vector3[] normal_array, int normal_count, Color[] color_array, int color_count, Vector2[] uv_array, int uv_count, int protect_boundary, int protect_detail, int protect_symmetry, int protect_normal, int protect_shape, int use_detail_map, int detail_boost)
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x13545AC", Offset = "0x13545AC", VA = "0x13545AC")]
		public void get_triangle_list(int goal, int[] triangle_array, ref int triangle_count)
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x13533E8", Offset = "0x13533E8", VA = "0x13533E8")]
		private void load_mesh_from_array(Vector3[] vertex_array, int vertex_count, int[] triangle_array, int triangle_count, Vector3[] normal_array, int normal_count, Color[] color_array, int color_count, Vector2[] uv_array, int uv_count)
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x1354CC0", Offset = "0x1354CC0", VA = "0x1354CC0")]
		private void calculate_face_normal(My_Half_face one_face)
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x1354E34", Offset = "0x1354E34", VA = "0x1354E34")]
		private void calculate_face_normals()
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x1354F70", Offset = "0x1354F70", VA = "0x1354F70")]
		private bool is_boundary_edge(My_Half_edge edge)
		{
			return default(bool);
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x13551E4", Offset = "0x13551E4", VA = "0x13551E4")]
		private void detect_and_mark_boundaries()
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x1355388", Offset = "0x1355388", VA = "0x1355388")]
		private bool is_symmetry_edge(My_Half_edge edge)
		{
			return default(bool);
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x1355A6C", Offset = "0x1355A6C", VA = "0x1355A6C")]
		private void detect_and_mark_symmetries()
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x1355C04", Offset = "0x1355C04", VA = "0x1355C04")]
		private float cost_of_edge(My_Half_edge edge)
		{
			return default(float);
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x1354014", Offset = "0x1354014", VA = "0x1354014")]
		private void calculate_cost_of_edges()
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x13573A0", Offset = "0x13573A0", VA = "0x13573A0")]
		private bool contract_edge(My_Half_edge edge)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x1354194", Offset = "0x1354194", VA = "0x1354194")]
		private void contract_edges()
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x1354218", Offset = "0x1354218", VA = "0x1354218")]
		private int trace_to(int goal)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001D8")]
	public static class MantisLODSimpler
	{
		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<Progressive_Mesh> simplers;

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x1358718", Offset = "0x1358718", VA = "0x1358718")]
		public static int create_progressive_mesh(Vector3[] vertex_array, int vertex_count, int[] triangle_array, int triangle_count, Vector3[] normal_array, int normal_count, Color[] color_array, int color_count, Vector2[] uv_array, int uv_count, int protect_boundary, int protect_detail, int protect_symmetry, int protect_normal, int protect_shape, int use_detail_map, int detail_boost)
		{
			return default(int);
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x1358A08", Offset = "0x1358A08", VA = "0x1358A08")]
		public static int get_triangle_list(int index, float goal, int[] triangle_array, ref int triangle_count)
		{
			return default(int);
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x1358B78", Offset = "0x1358B78", VA = "0x1358B78")]
		public static int delete_progressive_mesh(int index)
		{
			return default(int);
		}
	}
}
namespace MantisLODEditor
{
	[Token(Token = "0x20001D9")]
	public class Lod_Mesh
	{
		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int triangle_count;

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x1358D24", Offset = "0x1358D24", VA = "0x1358D24")]
		public Lod_Mesh()
		{
		}
	}
	[Token(Token = "0x20001DA")]
	public class Lod_Mesh_Table
	{
		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh origin_mesh;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Component> containers;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Lod_Mesh[] lod_meshes;

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x1358D2C", Offset = "0x1358D2C", VA = "0x1358D2C")]
		public Lod_Mesh_Table()
		{
		}
	}
	[Token(Token = "0x20001DB")]
	public static class MantisLODEditorUtility
	{
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x1358D34", Offset = "0x1358D34", VA = "0x1358D34")]
		public static string get_uuid_from_mesh(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x1358FB4", Offset = "0x1358FB4", VA = "0x1358FB4")]
		public static int PrepareSimplify(Mantis_Mesh[] Mantis_Meshes, bool use_origin_triangles = true)
		{
			return default(int);
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x1359224", Offset = "0x1359224", VA = "0x1359224")]
		public static void Simplify(Mantis_Mesh[] Mantis_Meshes, bool protect_boundary, bool protect_detail, bool protect_symmetry, bool protect_normal, bool protect_shape, bool use_detail_map, int detail_boost)
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x13594FC", Offset = "0x13594FC", VA = "0x13594FC")]
		public static int SetQuality(Mantis_Mesh[] Mantis_Meshes, float quality)
		{
			return default(int);
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x13596F4", Offset = "0x13596F4", VA = "0x13596F4")]
		public static void SaveSimplifiedMesh(Mesh mesh, string filePath)
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x13596F8", Offset = "0x13596F8", VA = "0x13596F8")]
		public static void FinishSimplify(Mantis_Mesh[] Mantis_Meshes, bool use_origin_triangles = true, bool unload_asset = false)
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x1359838", Offset = "0x1359838", VA = "0x1359838")]
		public static ProgressiveMesh MakeProgressiveMesh(Mantis_Mesh[] Mantis_Meshes, int max_lod_count)
		{
			return null;
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x1359F64", Offset = "0x1359F64", VA = "0x1359F64")]
		public static void SaveProgressiveMesh(ProgressiveMesh pm, string filePath)
		{
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x1359F68", Offset = "0x1359F68", VA = "0x1359F68")]
		public static ProgressiveMesh LoadProgressiveMesh(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x1359FB0", Offset = "0x1359FB0", VA = "0x1359FB0")]
		public static int get_triangles_count_from_progressive_mesh(ProgressiveMesh pm, int _lod, int _mesh_count)
		{
			return default(int);
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x135A0A4", Offset = "0x135A0A4", VA = "0x135A0A4")]
		private static int[] get_triangles_from_progressive_mesh(ProgressiveMesh pm, int _lod, int _mesh_count, int _mat)
		{
			return null;
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x135A210", Offset = "0x135A210", VA = "0x135A210")]
		private static void set_triangles(ProgressiveMesh pm, Mesh mesh, string uuid, int lod)
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x135A2E4", Offset = "0x135A2E4", VA = "0x135A2E4")]
		public static void GenerateRuntimeLOD(ProgressiveMesh pm, Component[] containers, bool optimize_on_the_fly)
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x135A908", Offset = "0x135A908", VA = "0x135A908")]
		public static int SwitchRuntimeLOD(ProgressiveMesh pm, int[] mesh_lod_range, int lod)
		{
			return default(int);
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x135AE44", Offset = "0x135AE44", VA = "0x135AE44")]
		public static void FinishRuntimeLOD(ProgressiveMesh pm)
		{
		}
	}
	[Token(Token = "0x20001DC")]
	public class Mantis_Mesh
	{
		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int index;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string uuid;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int[][] origin_triangles;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int[] out_triangles;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int out_count;

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x135B1D8", Offset = "0x135B1D8", VA = "0x135B1D8")]
		public Mantis_Mesh()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001DD")]
	public class ProgressiveMesh : ScriptableObject
	{
		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] triangles;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] uuids;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<string, Lod_Mesh_Table> lod_meshes_dic;

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x135B20C", Offset = "0x135B20C", VA = "0x135B20C")]
		public ProgressiveMesh()
		{
		}
	}
	[Token(Token = "0x20001DE")]
	public class ProgressiveMeshRuntime : MonoBehaviour
	{
		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ProgressiveMesh progressiveMesh;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text fpsHint;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text lodHint;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text triangleHint;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public bool optimize_on_the_fly;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public int[] mesh_lod_range;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public bool never_cull;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[HideInInspector]
		public int lod_strategy;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public float cull_ratio;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[HideInInspector]
		public float disappear_distance;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public float updateInterval;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int current_lod;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Component[] allBasicRenderers;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float currentTimeToInterval;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool culled;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool working;

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x135B214", Offset = "0x135B214", VA = "0x135B214")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x135B444", Offset = "0x135B444", VA = "0x135B444")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x135B448", Offset = "0x135B448", VA = "0x135B448")]
		private float ratio_of_screen()
		{
			return default(float);
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x135B83C", Offset = "0x135B83C", VA = "0x135B83C")]
		private float ratio_of_distance(float distance0)
		{
			return default(float);
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x135BC00", Offset = "0x135BC00", VA = "0x135BC00")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x135C3C4", Offset = "0x135C3C4", VA = "0x135C3C4")]
		private void create_default_mesh_lod_range()
		{
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x135B218", Offset = "0x135B218", VA = "0x135B218")]
		private void get_all_meshes()
		{
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x135C4B0", Offset = "0x135C4B0", VA = "0x135C4B0")]
		public void reset_all_parameters()
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x135C4FC", Offset = "0x135C4FC", VA = "0x135C4FC")]
		private void clean_all()
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x135C530", Offset = "0x135C530", VA = "0x135C530")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x135C534", Offset = "0x135C534", VA = "0x135C534")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x135C538", Offset = "0x135C538", VA = "0x135C538")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x135C53C", Offset = "0x135C53C", VA = "0x135C53C")]
		public ProgressiveMeshRuntime()
		{
		}
	}
}
namespace MagicLightProbes
{
	[Token(Token = "0x20001DF")]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/main-component")]
	[ExecuteInEditMode]
	public class MagicLightProbes : MonoBehaviour
	{
		[Token(Token = "0x20001E0")]
		public struct VolumeParameters
		{
			[Token(Token = "0x4000A29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int volumeIndex;

			[Token(Token = "0x4000A2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector3 position;

			[Token(Token = "0x4000A2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 demensions;

			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x135D274", Offset = "0x135D274", VA = "0x135D274")]
			public VolumeParameters(int _volumeIndex, Vector3 _position, Vector3 _demensions)
			{
			}
		}

		[Token(Token = "0x20001E1")]
		public enum FillingMode
		{
			[Token(Token = "0x4000A2D")]
			VerticalDublicating,
			[Token(Token = "0x4000A2E")]
			FullFilling,
			[Token(Token = "0x4000A2F")]
			SeparateFilling
		}

		[Token(Token = "0x20001E2")]
		public enum ExcludingLightsMode
		{
			[Token(Token = "0x4000A31")]
			AllInList,
			[Token(Token = "0x4000A32")]
			AllExceptInList
		}

		[Token(Token = "0x20001E3")]
		public enum Workflow
		{
			[Token(Token = "0x4000A34")]
			Simple,
			[Token(Token = "0x4000A35")]
			Advanced
		}

		[Token(Token = "0x20001E4")]
		public enum BoundsDisplayMode
		{
			[Token(Token = "0x4000A37")]
			Always,
			[Token(Token = "0x4000A38")]
			OnSelection
		}

		[Token(Token = "0x20001E5")]
		public enum DebugPasses
		{
			[Token(Token = "0x4000A3A")]
			MaximumHeight,
			[Token(Token = "0x4000A3B")]
			GeometryCollision,
			[Token(Token = "0x4000A3C")]
			GeometryIntersections,
			[Token(Token = "0x4000A3D")]
			NearGeometry,
			[Token(Token = "0x4000A3E")]
			OutOfRange,
			[Token(Token = "0x4000A3F")]
			OutOfRangeBorders,
			[Token(Token = "0x4000A40")]
			ShadingBorders,
			[Token(Token = "0x4000A41")]
			ContrastAreas,
			[Token(Token = "0x4000A42")]
			NearLights,
			[Token(Token = "0x4000A43")]
			LightIntensity,
			[Token(Token = "0x4000A44")]
			UnlitProbes,
			[Token(Token = "0x4000A45")]
			EqualProbes,
			[Token(Token = "0x4000A46")]
			GeometryEdges,
			[Token(Token = "0x4000A47")]
			EqualColor
		}

		[Token(Token = "0x20001E6")]
		public enum DrawModes
		{
			[Token(Token = "0x4000A49")]
			Accepted,
			[Token(Token = "0x4000A4A")]
			Culled,
			[Token(Token = "0x4000A4B")]
			Both
		}

		[Token(Token = "0x20001E7")]
		public enum CalculationTarget
		{
			[Token(Token = "0x4000A4D")]
			GeometryEdges,
			[Token(Token = "0x4000A4E")]
			GeneralCalculation
		}

		[Serializable]
		[Token(Token = "0x20001E8")]
		private struct TempPointData
		{
			[Token(Token = "0x4000A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float xPos;

			[Token(Token = "0x4000A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float yPos;

			[Token(Token = "0x4000A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float zPos;

			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x135D288", Offset = "0x135D288", VA = "0x135D288")]
			public TempPointData(Vector3 _position)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001E9")]
		public class WorkPathFoundEvent : UnityEvent<string>
		{
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x135D294", Offset = "0x135D294", VA = "0x135D294")]
			public WorkPathFoundEvent()
			{
			}
		}

		[Token(Token = "0x4000973")]
		private const string COMPUTE_SHADERS_FOLDER = "/Passes/Compute Shaders/";

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator colorThresholdRecalculationRoutine;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator lightProbesVolumeCalculatingRoutine;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator lightProbesVolumeCalculatingSubRoutine;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IEnumerator executingPassesRoutine;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IEnumerator volumeDivideingRoutine;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool autoSaveSettings;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MLPSettings lastSettingsAsset;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<string> groundAndFloorObjects;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<string> storedGroundAndFloorKeywords;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject probesVolume;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useDynamicDensity;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float volumeSpacing;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float volumeSpacingMin;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float volumeSpacingMax;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float cornersDetectionThreshold;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float cornersDetectionThresholdMin;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float cornersDetectionThresholdMax;

		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float lastCornersDetectionThreshold;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float lastCornersDetectionThresholdMin;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float lastCornersDetectionThresholdMax;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int lastMaxProbesInVolume;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int maxProbesInVolume;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int defaultMaxProbesCount;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float lastVolumeSpacing;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float lastVolumeSpacingMin;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float lastVolumeSpacingMax;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool volumeSpacingChanged;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool tooManySubVolumes;

		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public FillingMode fillingMode;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public ExcludingLightsMode excludingLightsMode;

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public MLPSettings settingsAsset;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Workflow workflow;

		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float maxHeightAboveGeometry;

		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float lastMaxHeightAboveGeometry;

		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float maxHeightAboveTerrain;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public bool considerDistanceToLights;

		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float lightIntensityTreshold;

		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float colorTreshold;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float collisionDetectionRadius;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool saveProbesNearbyGeometry;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public float cornerProbesSpacing;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public float nearbyGeometryDetectionRadius;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public float nearbyGeometryDetectionRadiusMin;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public float nearbyGeometryDetectionRadiusMax;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public float distanceFromNearbyGeometry;

		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public bool fillEquivalentVolume;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public float equivalentVolumeFillingRate;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public bool fillUnlitVolume;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		public bool fillFreeVolume;

		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public float unlitVolumeFillingRate;

		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float freeVolumeFillingRate;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public bool cullAcceptedVolume;

		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public float acceptedVolumeFillingRate;

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public float nearbyGeometryVolumeFillingRate;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public float verticalDublicatingHeight;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public float verticalDublicatingStep;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public LayerMask raycastFilter;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public List<MLPLight> excludedLights;

		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public LayerMask layerMask;

		[Token(Token = "0x40009AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public int firstCollisionLayer;

		[Token(Token = "0x40009B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public bool useMultithreading;

		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public GameObject previousSelection;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public bool unloaded;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		public bool sceneChanging;

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		public bool waitForPrevious;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public MagicLightProbes previousVolume;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public bool optimizeForMixedLighting;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		public bool lastOptimizeForMixedLightingValue;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
		public bool lastUseDynamicDensityValue;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15B")]
		public bool preventLeakageThroughWalls;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public bool useVolumeBottom;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15D")]
		public bool placeProbesOnGeometryEdges;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public float lastColorThreshold;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public float lastLightIntensityThreshold;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public float lastEquivalentVolumeFillingRate;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public float lastUnlitVolumeFillingRate;

		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public float lastFreeVolumeFillingRate;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		public float lastCornerProbesSpacing;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public float lastDistanceFromGeometry;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public bool debugMode;

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public float debugObjectScale;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		public BoundsDisplayMode boundsDisplayMode;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public DebugPasses debugPass;

		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		public DrawModes drawMode;

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public bool debugShowLightIntensity;

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x191")]
		public bool showPreviewGrid;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x192")]
		public bool nextStep;

		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x193")]
		public bool cullByColor;

		[Token(Token = "0x40009CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		public bool forceSaveProbesOnShadingBorders;

		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public string dataPath;

		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public string workPath;

		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public bool workPathFound;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public List<Vector3> localFinishedPositions;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public ComputeShader calculateVolumeFilling;

		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public ComputeShader calculateProbeSpacing;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public ComputeShader calculateDistanceFromGeometry;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public MLPVolume currentVolume;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public bool recalculationRequired;

		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private List<Collider> lightColliders;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private List<Collider> objectColliders;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private List<MLPPointData> finalDebugAcceptedPoints;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private List<MLPPointData> finalDebugCulledPoints;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private List<GameObject> tempObjects;

		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private List<GameObject> temporarilyDisabledDynamicObjects;

		[Token(Token = "0x40009DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private List<GameObject> staticObjectsWithoutCollider;

		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public List<GameObject> finalStaticGameObjectsList;

		[Token(Token = "0x40009DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private GameObject combinedVolumeObject;

		[Token(Token = "0x40009DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private VolumeParameters currentEditingVolume;

		[Token(Token = "0x40009E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
		private Vector3 currentSelectedObjectLastPosition;

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private GameObject lastSelectedObject;

		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		public bool cancelCombination;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		public List<IEnumerator> passesToExecute;

		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		public List<GameObject> staticObjects;

		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		public List<MLPLight> lights;

		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		public List<MLPPointData> tmpSharedPointsArray;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		public List<MLPPointData> tmpOutOfRangePoints;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		public List<MLPPointData> tmpOutOfMaxHeightPoints;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		public List<MLPPointData> tmpGeometryCollisionPoints;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		public List<MLPPointData> tmpContrastOnOutOfRangePoints;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		public List<MLPPointData> tmpContrastShadingBordersPoints;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		public List<MLPPointData> tmpUnlitPoints;

		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		public List<MLPPointData> tmpFreePoints;

		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		public List<MLPPointData> tmpNearbyGeometryPoints;

		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		public List<MLPPointData> tmpPointsNearGeometryIntersections;

		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		public List<MLPPointData> tmpNearbyLightsPoints;

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		public List<MLPPointData> tmpEqualPoints;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		public List<MLPPointData> debugCulledPoints;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		public List<MLPPointData> debugAcceptedPoints;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		public List<GameObject> subVolumesDivided;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		public List<Vector3> points;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		public List<VolumeParameters> innerVolumes;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		public List<VolumeParameters> subVolumesParameters;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		public List<MagicLightProbes> innerVolumesObjects;

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		public List<LayerMask> layerMasks;

		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		public List<Vector3> transformedPoints;

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		public string assetEditorPath;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		public MagicLightProbes parentVolume;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool operationalDataLost;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		public bool localOperationalDataLost;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x331")]
		public bool recombinationNeeded;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x332")]
		public bool isInBackground;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x333")]
		public bool realtimeEditing;

		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x334")]
		public bool calculated;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x335")]
		public bool calculatingError;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		public int xPointsCount;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
		public int yPointsCount;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		public int zPointsCount;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
		public float prevVolumeScaleX;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		public float prevVolumeScaleY;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34C")]
		public float prevVolumeScaleZ;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		public int totalProbes;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x354")]
		public int totalProbesInSubVolume;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		public int totalProbesInVolume;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35C")]
		public bool calculatingVolume;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35D")]
		public bool calculatingVolumeSubPass;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		public string currentPass;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		public int currentPassProgressCounter;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36C")]
		public int currentPassProgressFrameSkipper;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		public float totalProgress;

		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
		public float currentPassProgress;

		[Token(Token = "0x4000A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		public int selectedTab;

		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37C")]
		public bool showOptionsInManagerWindow;

		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37D")]
		public bool restored;

		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		public int currentVolumePart;

		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x384")]
		public float eta;

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		public bool changed;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x389")]
		public bool redivideParts;

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38A")]
		public bool combinedVolumeError;

		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38B")]
		public bool isInPrefab;

		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38C")]
		public Vector3 prefabPosition;

		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		public GameObject prefabRoot;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		public MLPPrefab prefabConnectionObject;

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		public string prefabRootName;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		public bool calculatedFromPrefab;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		public string prefabUID;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private bool passesExecuting;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C4")]
		private int totalProgressCounter;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		private int totalProgressFrameSkipper;

		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3CC")]
		private float startTime;

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		private float endTime;

		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D4")]
		private bool scenePreparing;

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x135C56C", Offset = "0x135C56C", VA = "0x135C56C")]
		public void CheckForNearContrast(MLPPointData pointForCheck)
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x135C954", Offset = "0x135C954", VA = "0x135C954")]
		public bool UpdateProgress(int count, int period = 100)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x135C99C", Offset = "0x135C99C", VA = "0x135C99C")]
		private bool UpdateTotalProgress(int count, int period = 100)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x135C9E4", Offset = "0x135C9E4", VA = "0x135C9E4")]
		public MagicLightProbes()
		{
		}
	}
	[Token(Token = "0x20001EA")]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/mlp-combined-volume")]
	[ExecuteInEditMode]
	public class MLPCombinedVolume : MonoBehaviour
	{
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x135D2DC", Offset = "0x135D2DC", VA = "0x135D2DC")]
		public MLPCombinedVolume()
		{
		}
	}
	[Token(Token = "0x20001EB")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/mlp-light")]
	public class MLPLight : MonoBehaviour
	{
		[Token(Token = "0x20001EC")]
		public enum CalculationMode
		{
			[Token(Token = "0x4000A77")]
			AccurateShadows,
			[Token(Token = "0x4000A78")]
			LightIntensity
		}

		[Token(Token = "0x20001ED")]
		public enum MLPLightType
		{
			[Token(Token = "0x4000A7A")]
			Spot,
			[Token(Token = "0x4000A7B")]
			Directional,
			[Token(Token = "0x4000A7C")]
			Point,
			[Token(Token = "0x4000A7D")]
			Area,
			[Token(Token = "0x4000A7E")]
			Mesh
		}

		[Token(Token = "0x20001EE")]
		public enum MLPLightTypeMA
		{
			[Token(Token = "0x4000A80")]
			Area = 3,
			[Token(Token = "0x4000A81")]
			Mesh
		}

		[Token(Token = "0x20001EF")]
		public enum TracePointSettingMode
		{
			[Token(Token = "0x4000A83")]
			Auto,
			[Token(Token = "0x4000A84")]
			Custom
		}

		[Token(Token = "0x20001F0")]
		public enum ShadowmaskMode
		{
			[Token(Token = "0x4000A86")]
			Shadowmask,
			[Token(Token = "0x4000A87")]
			DistanceShadowmask
		}

		[Token(Token = "0x4000A52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MLPLightType lightType;

		[Token(Token = "0x4000A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MLPLightType lastLightType;

		[Token(Token = "0x4000A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MLPLightTypeMA lightTypeMA;

		[Token(Token = "0x4000A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public CalculationMode calculationMode;

		[Token(Token = "0x4000A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TracePointSettingMode tracePointSettingType;

		[Token(Token = "0x4000A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LightmapBakeType lightMode;

		[Token(Token = "0x4000A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ShadowmaskMode shadowmaskMode;

		[Token(Token = "0x4000A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityEngine.Light targetLight;

		[Token(Token = "0x4000A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject parentGameObject;

		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 position;

		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 forward;

		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool saveNearbyProbes;

		[Token(Token = "0x4000A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float saveRadius;

		[Token(Token = "0x4000A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float range;

		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool useSourceParameters;

		[Token(Token = "0x4000A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		public bool reverseDirection;

		[Token(Token = "0x4000A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float angle;

		[Token(Token = "0x4000A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool customTracePoints;

		[Token(Token = "0x4000A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		public bool accurateTrace;

		[Token(Token = "0x4000A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int accuracy;

		[Token(Token = "0x4000A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int lastAccuracy;

		[Token(Token = "0x4000A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool isDirectional;

		[Token(Token = "0x4000A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float tracePointSize;

		[Token(Token = "0x4000A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float lastTracePointSize;

		[Token(Token = "0x4000A6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public MeshFilter lastMesh;

		[Token(Token = "0x4000A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<GameObject> tracePoints;

		[Token(Token = "0x4000A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<MLPTracePoint> tracePointsData;

		[Token(Token = "0x4000A6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public MLPTracePoint mainTracePoint;

		[Token(Token = "0x4000A6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public MagicLightProbes parentVolume;

		[Token(Token = "0x4000A6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool showOptionsInManagerWindow;

		[Token(Token = "0x4000A70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float intensity;

		[Token(Token = "0x4000A71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool resetEditor;

		[Token(Token = "0x4000A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		public bool showLightOnScene;

		[Token(Token = "0x4000A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
		public bool saveOnOutOfRange;

		[Token(Token = "0x4000A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC3")]
		public bool isHDRP;

		[Token(Token = "0x4000A75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector2 hdrpAreaSize;

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x135D2E4", Offset = "0x135D2E4", VA = "0x135D2E4")]
		public MLPLight()
		{
		}
	}
	[Token(Token = "0x20001F1")]
	public class MLPPointData
	{
		[Token(Token = "0x4000A88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float lightIntensity;

		[Token(Token = "0x4000A89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maxIntencity;

		[Token(Token = "0x4000A8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 position;

		[Token(Token = "0x4000A8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int col;

		[Token(Token = "0x4000A8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int row;

		[Token(Token = "0x4000A8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int depth;

		[Token(Token = "0x4000A8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<float> distancesToLights;

		[Token(Token = "0x4000A8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Vector3> collisionPoints;

		[Token(Token = "0x4000A90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<MLPPointData> nearbyPoints;

		[Token(Token = "0x4000A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<MLPPointData> nearbyPointsOptimaziable;

		[Token(Token = "0x4000A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool removed;

		[Token(Token = "0x4000A93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool outOfRange;

		[Token(Token = "0x4000A94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool inSaveRange;

		[Token(Token = "0x4000A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		public bool savedNearGeometry;

		[Token(Token = "0x4000A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool contrastOnOutOfRangeArea;

		[Token(Token = "0x4000A97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool inRangeOfLight;

		[Token(Token = "0x4000A98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
		public bool contrastOnShadingArea;

		[Token(Token = "0x4000A99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
		public bool equalIntensity;

		[Token(Token = "0x4000A9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool equalColor;

		[Token(Token = "0x4000A9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool borderPoint;

		[Token(Token = "0x4000A9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool outOfMaxHeight;

		[Token(Token = "0x4000A9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float angleToLight;

		[Token(Token = "0x4000A9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 contactPoint;

		[Token(Token = "0x4000A9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool inCorner;

		[Token(Token = "0x4000AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		public bool lockForCull;

		[Token(Token = "0x4000AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		public bool onGeometryEdge;

		[Token(Token = "0x4000AA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F")]
		public bool lightLeakLocked;

		[Token(Token = "0x4000AA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 collisionNormal;

		[Token(Token = "0x4000AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<MLPLight> inRangeForLights;

		[Token(Token = "0x4000AA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MLPLight> inShadowForLights;

		[Token(Token = "0x4000AA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject temporaryObject;

		[Token(Token = "0x4000AA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject collisionObject;

		[Token(Token = "0x4000AA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color averagedColor;

		[Token(Token = "0x4000AA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool xEndPoint;

		[Token(Token = "0x4000AAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool yEndPoint;

		[Token(Token = "0x4000AAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		public bool zEndPoint;

		[Token(Token = "0x4000AAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB3")]
		public bool xStartPoint;

		[Token(Token = "0x4000AAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool yStartPoint;

		[Token(Token = "0x4000AAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		public bool zStartPoint;

		[Token(Token = "0x4000AAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public int equivalent;

		[Token(Token = "0x4000AB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float avaragedColorValue;

		[Token(Token = "0x4000AB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool isUnlit;

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x135D3C8", Offset = "0x135D3C8", VA = "0x135D3C8")]
		public void SetPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x135D3D4", Offset = "0x135D3D4", VA = "0x135D3D4")]
		public void SetOutOfRange(bool visibility)
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x135D3E0", Offset = "0x135D3E0", VA = "0x135D3E0")]
		public void SetLightIntensity(float intensity)
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x135D3E8", Offset = "0x135D3E8", VA = "0x135D3E8")]
		public void SetInSaveRange(bool value)
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x135D3F4", Offset = "0x135D3F4", VA = "0x135D3F4")]
		public void SetInContrastArea(bool value)
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x135D400", Offset = "0x135D400", VA = "0x135D400")]
		public MLPPointData()
		{
		}
	}
	[Token(Token = "0x20001F2")]
	[ExecuteInEditMode]
	public class MLPPrefab : MonoBehaviour
	{
		[Token(Token = "0x4000AB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public new string name;

		[Token(Token = "0x4000AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string uid;

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x135D5D0", Offset = "0x135D5D0", VA = "0x135D5D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x135D64C", Offset = "0x135D64C", VA = "0x135D64C")]
		public MLPPrefab()
		{
		}
	}
	[Token(Token = "0x20001F3")]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/mlp-quick-editing")]
	public class MLPQuickEditing : MonoBehaviour
	{
		[Token(Token = "0x4000AB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MagicLightProbes parent;

		[Token(Token = "0x4000AB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float gizmoScale;

		[Token(Token = "0x4000AB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float drawDistance;

		[Token(Token = "0x4000AB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 _lastPrefabPosition;

		[Token(Token = "0x4000AB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion _lastPrefabRotation;

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x135D654", Offset = "0x135D654", VA = "0x135D654")]
		public MLPQuickEditing()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001F4")]
	public class MLPTracePoint
	{
		[Token(Token = "0x4000AB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x4000ABA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 forward;

		[Token(Token = "0x4000ABB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		[Token(Token = "0x4000ABC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject pointGameObject;

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x135D6F4", Offset = "0x135D6F4", VA = "0x135D6F4")]
		public MLPTracePoint()
		{
		}
	}
	[Token(Token = "0x20001F5")]
	[ExecuteInEditMode]
	public class MLPVolume : MonoBehaviour
	{
		[Token(Token = "0x4000ABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public MagicLightProbes parentRootComponent;

		[Token(Token = "0x4000ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public MeshRenderer selfRenderer;

		[Token(Token = "0x4000ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool showGizmo;

		[Token(Token = "0x4000AC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool showGizmoSelected;

		[Token(Token = "0x4000AC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool isPartVolume;

		[Token(Token = "0x4000AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool isSubdividedPart;

		[Token(Token = "0x4000AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool isCalculated;

		[Token(Token = "0x4000AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool isInProcess;

		[Token(Token = "0x4000AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		public bool skipped;

		[Token(Token = "0x4000AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int id;

		[Token(Token = "0x4000AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color colorOnSelection;

		[Token(Token = "0x4000AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<MLPPointData> localAcceptedPoints;

		[Token(Token = "0x4000AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<MLPPointData> localNearbyGeometryPoints;

		[Token(Token = "0x4000ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<MLPPointData> localContrastPoints;

		[Token(Token = "0x4000ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<MLPPointData> localCornerPoints;

		[Token(Token = "0x4000ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<Vector3> localNearbyGeometryPointsPositions;

		[Token(Token = "0x4000ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<Vector3> resultNearbyGeometryPointsPositions;

		[Token(Token = "0x4000ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<Vector3> localCornerPointsPositions;

		[Token(Token = "0x4000ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<Vector3> resultLocalCornerPointsPositions;

		[Token(Token = "0x4000AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<Vector3> localEquivalentPointsPositions;

		[Token(Token = "0x4000AD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<Vector3> resultLocalEquivalentPointsPositions;

		[Token(Token = "0x4000AD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<Vector3> resultLocalFreePointsPositions;

		[Token(Token = "0x4000AD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<Vector3> localUnlitPointsPositions;

		[Token(Token = "0x4000AD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public List<Vector3> localFreePointsPositions;

		[Token(Token = "0x4000AD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public List<Vector3> resultLocalUnlitPointsPositions;

		[Token(Token = "0x4000AD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public List<Vector3> localDirections;

		[Token(Token = "0x4000AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public List<Vector3> localAvaragedDirections;

		[Token(Token = "0x4000AD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<MLPPointData> localColorThresholdEditingPoints;

		[Token(Token = "0x4000AD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public int objectsInside;

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x135D6FC", Offset = "0x135D6FC", VA = "0x135D6FC")]
		public MLPVolume()
		{
		}
	}
	[Token(Token = "0x20001F6")]
	public class DublicateVertical
	{
		[Token(Token = "0x20001F7")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000ADA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000ADB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000ADC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MagicLightProbes parent;

			[Token(Token = "0x4000ADD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <steps>5__2;

			[Token(Token = "0x4000ADE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<MLPPointData> <candidates>5__3;

			[Token(Token = "0x4000ADF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<MLPPointData> <savedNearGeometry>5__4;

			[Token(Token = "0x4000AE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <i>5__5;

			[Token(Token = "0x4000AE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<MLPPointData>.Enumerator <>7__wrap5;

			[Token(Token = "0x17000141")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A42")]
				[Address(RVA = "0x135E6E4", Offset = "0x135E6E4", VA = "0x135E6E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000142")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A44")]
				[Address(RVA = "0x135E72C", Offset = "0x135E72C", VA = "0x135E72C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x135DAB0", Offset = "0x135DAB0", VA = "0x135DAB0")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x135DAE0", Offset = "0x135DAE0", VA = "0x135DAE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x135DAFC", Offset = "0x135DAFC", VA = "0x135DAFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x135E694", Offset = "0x135E694", VA = "0x135E694")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x135E6EC", Offset = "0x135E6EC", VA = "0x135E6EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x135DA3C", Offset = "0x135DA3C", VA = "0x135DA3C")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent)
		{
			return null;
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x135DAD8", Offset = "0x135DAD8", VA = "0x135DAD8")]
		public DublicateVertical()
		{
		}
	}
	[Token(Token = "0x20001F8")]
	public static class RandomGen
	{
		[Token(Token = "0x4000AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Random _global;

		[Token(Token = "0x4000AE3")]
		[ThreadStatic]
		private static System.Random _local;

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x135E734", Offset = "0x135E734", VA = "0x135E734")]
		public static int Next(int min, int max)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001F9")]
	public class EquivalentProbesOptimization
	{
		[Token(Token = "0x20001FA")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MagicLightProbes parent;

			[Token(Token = "0x4000AE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MLPVolume currentVolume;

			[Token(Token = "0x4000AE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool realtimeEditing;

			[Token(Token = "0x4000AE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3[] <exit>5__2;

			[Token(Token = "0x4000AEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<MLPPointData> <tempList>5__3;

			[Token(Token = "0x4000AEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <i>5__4;

			[Token(Token = "0x17000143")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A4C")]
				[Address(RVA = "0x135F218", Offset = "0x135F218", VA = "0x135F218", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000144")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A4E")]
				[Address(RVA = "0x135F260", Offset = "0x135F260", VA = "0x135F260", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x135EA54", Offset = "0x135EA54", VA = "0x135EA54")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x135EA84", Offset = "0x135EA84", VA = "0x135EA84", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x135EA88", Offset = "0x135EA88", VA = "0x135EA88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x135F220", Offset = "0x135F220", VA = "0x135F220", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x135E9B8", Offset = "0x135E9B8", VA = "0x135E9B8")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent, [Optional] MLPVolume currentVolume, bool realtimeEditing = false)
		{
			return null;
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x135EA7C", Offset = "0x135EA7C", VA = "0x135EA7C")]
		public EquivalentProbesOptimization()
		{
		}
	}
	[Token(Token = "0x20001FB")]
	public class PartialVolumeFilling
	{
		[Token(Token = "0x20001FC")]
		public enum TargetPoint
		{
			[Token(Token = "0x4000AED")]
			Unlit,
			[Token(Token = "0x4000AEE")]
			Equivalent,
			[Token(Token = "0x4000AEF")]
			Free
		}

		[Token(Token = "0x20001FD")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TargetPoint targetPoint;

			[Token(Token = "0x4000AF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MagicLightProbes parent;

			[Token(Token = "0x4000AF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public MLPVolume currentVolume;

			[Token(Token = "0x4000AF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool realtimeEditing;

			[Token(Token = "0x4000AF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<MLPPointData> <tempList>5__2;

			[Token(Token = "0x4000AF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<Vector3> <realTimeEditingList>5__3;

			[Token(Token = "0x4000AF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private List<Vector3> <targetPoints>5__4;

			[Token(Token = "0x4000AF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private float <fillingRate>5__5;

			[Token(Token = "0x4000AFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3[] <exit>5__6;

			[Token(Token = "0x4000AFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private int <i>5__7;

			[Token(Token = "0x17000145")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A54")]
				[Address(RVA = "0x1360378", Offset = "0x1360378", VA = "0x1360378", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000146")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A56")]
				[Address(RVA = "0x13603C0", Offset = "0x13603C0", VA = "0x13603C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x135F314", Offset = "0x135F314", VA = "0x135F314")]
			[DebuggerHidden]
			public <ExecutePass>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x135F344", Offset = "0x135F344", VA = "0x135F344", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x135F348", Offset = "0x135F348", VA = "0x135F348", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x1360380", Offset = "0x1360380", VA = "0x1360380", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x135F268", Offset = "0x135F268", VA = "0x135F268")]
		[IteratorStateMachine(typeof(<ExecutePass>d__1))]
		public IEnumerator ExecutePass(MagicLightProbes parent, TargetPoint targetPoint, [Optional] MLPVolume currentVolume, bool realtimeEditing = false)
		{
			return null;
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x135F33C", Offset = "0x135F33C", VA = "0x135F33C")]
		public PartialVolumeFilling()
		{
		}
	}
	[Token(Token = "0x20001FE")]
	public class RemoveUnusedPoints
	{
		[Token(Token = "0x20001FF")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MagicLightProbes parent;

			[Token(Token = "0x4000AFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<MLPPointData> <pointsToRemove>5__2;

			[Token(Token = "0x4000B00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <i>5__3;

			[Token(Token = "0x17000147")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A5C")]
				[Address(RVA = "0x13607F8", Offset = "0x13607F8", VA = "0x13607F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000148")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A5E")]
				[Address(RVA = "0x1360840", Offset = "0x1360840", VA = "0x1360840", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x136043C", Offset = "0x136043C", VA = "0x136043C")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x136046C", Offset = "0x136046C", VA = "0x136046C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x1360470", Offset = "0x1360470", VA = "0x1360470", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x1360800", Offset = "0x1360800", VA = "0x1360800", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x13603C8", Offset = "0x13603C8", VA = "0x13603C8")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent)
		{
			return null;
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x1360464", Offset = "0x1360464", VA = "0x1360464")]
		public RemoveUnusedPoints()
		{
		}
	}
	[Token(Token = "0x2000200")]
	public class SetDistanceFromGeometry
	{
		[Token(Token = "0x2000201")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MLPVolume currentVolume;

			[Token(Token = "0x4000B04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MagicLightProbes parent;

			[Token(Token = "0x4000B05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[] <exit>5__2;

			[Token(Token = "0x4000B06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <i>5__3;

			[Token(Token = "0x17000149")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A64")]
				[Address(RVA = "0x1360EAC", Offset = "0x1360EAC", VA = "0x1360EAC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700014A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A66")]
				[Address(RVA = "0x1360EF4", Offset = "0x1360EF4", VA = "0x1360EF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x13608D8", Offset = "0x13608D8", VA = "0x13608D8")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x1360908", Offset = "0x1360908", VA = "0x1360908", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x136090C", Offset = "0x136090C", VA = "0x136090C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x1360EB4", Offset = "0x1360EB4", VA = "0x1360EB4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x1360848", Offset = "0x1360848", VA = "0x1360848")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent, MLPVolume currentVolume)
		{
			return null;
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x1360900", Offset = "0x1360900", VA = "0x1360900")]
		public SetDistanceFromGeometry()
		{
		}
	}
}
namespace Lux_SRP_GrassDisplacement
{
	[Token(Token = "0x2000202")]
	public class RotateAndMove : MonoBehaviour
	{
		[Token(Token = "0x4000B07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Rotate;

		[Token(Token = "0x4000B08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool MoveUpDown;

		[Token(Token = "0x4000B09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float posy;

		[Token(Token = "0x4000B0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform trans;

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x1360EFC", Offset = "0x1360EFC", VA = "0x1360EFC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x1360F74", Offset = "0x1360F74", VA = "0x1360F74")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x1361040", Offset = "0x1361040", VA = "0x1361040")]
		public RotateAndMove()
		{
		}
	}
	[Token(Token = "0x2000203")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000B0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform targetTransform;

		[Token(Token = "0x4000B0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float smoothTime;

		[Token(Token = "0x4000B0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 velocity;

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x1361050", Offset = "0x1361050", VA = "0x1361050")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x1361134", Offset = "0x1361134", VA = "0x1361134")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000204")]
	[ExecuteInEditMode]
	public class ControlDisplacer : MonoBehaviour
	{
		[Token(Token = "0x4000B0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxDistance;

		[Token(Token = "0x4000B0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float fallOff;

		[Token(Token = "0x4000B10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Layer]
		public int layerMask;

		[Token(Token = "0x4000B11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Space(5f)]
		public bool DebugRay;

		[Token(Token = "0x4000B12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform trans;

		[Token(Token = "0x4000B13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Renderer rend;

		[Token(Token = "0x4000B14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MaterialPropertyBlock mpb;

		[Token(Token = "0x4000B15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RaycastHit hit;

		[Token(Token = "0x4000B16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float alpha;

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x13611A0", Offset = "0x13611A0", VA = "0x13611A0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x1361298", Offset = "0x1361298", VA = "0x1361298")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x13612CC", Offset = "0x13612CC", VA = "0x13612CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x1361474", Offset = "0x1361474", VA = "0x1361474")]
		public ControlDisplacer()
		{
		}
	}
	[Token(Token = "0x2000205")]
	[RequireComponent(typeof(ParticleSystem))]
	public class ControlDisplacerParticleSys : MonoBehaviour
	{
		[Token(Token = "0x4000B17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxDistance;

		[Token(Token = "0x4000B18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float fallOff;

		[Token(Token = "0x4000B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Layer]
		public int layerMask;

		[Token(Token = "0x4000B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Space(5f)]
		public bool DebugRay;

		[Token(Token = "0x4000B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform trans;

		[Token(Token = "0x4000B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem ps;

		[Token(Token = "0x4000B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ParticleSystem.MainModule main;

		[Token(Token = "0x4000B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RaycastHit hit;

		[Token(Token = "0x4000B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float alpha;

		[Token(Token = "0x4000B20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float min_alpha;

		[Token(Token = "0x4000B21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float max_alpha;

		[Token(Token = "0x4000B22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color min_StartColor;

		[Token(Token = "0x4000B23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Color max_StartColor;

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x1361490", Offset = "0x1361490", VA = "0x1361490")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x13615EC", Offset = "0x13615EC", VA = "0x13615EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x13617F8", Offset = "0x13617F8", VA = "0x13617F8")]
		public ControlDisplacerParticleSys()
		{
		}
	}
	[Token(Token = "0x2000206")]
	public class DebugGrassDisplacementTex : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000207")]
		public enum DebugSize
		{
			[Token(Token = "0x4000B27")]
			_128 = 0x80,
			[Token(Token = "0x4000B28")]
			_256 = 0x100,
			[Token(Token = "0x4000B29")]
			_512 = 0x200,
			[Token(Token = "0x4000B2A")]
			_1024 = 0x400
		}

		[Token(Token = "0x4000B24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool m_EnableDebug;

		[Token(Token = "0x4000B25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public DebugSize currentDebugSize;

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x1361814", Offset = "0x1361814", VA = "0x1361814")]
		public DebugGrassDisplacementTex()
		{
		}
	}
	[Token(Token = "0x2000208")]
	public class GrassDisplacementRenderFeature : ScriptableRendererFeature
	{
		[Serializable]
		[Token(Token = "0x2000209")]
		public enum RTDisplacementSize
		{
			[Token(Token = "0x4000B2E")]
			_128 = 0x80,
			[Token(Token = "0x4000B2F")]
			_256 = 0x100,
			[Token(Token = "0x4000B30")]
			_512 = 0x200,
			[Token(Token = "0x4000B31")]
			_1024 = 0x400
		}

		[Serializable]
		[Token(Token = "0x200020A")]
		public class GrassDisplacementSettings
		{
			[Token(Token = "0x4000B32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RTDisplacementSize Resolution;

			[Token(Token = "0x4000B33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float Size;

			[Token(Token = "0x4000B34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool ShiftRenderTex;

			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x1361960", Offset = "0x1361960", VA = "0x1361960")]
			public GrassDisplacementSettings()
			{
			}
		}

		[Token(Token = "0x4000B2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GrassDisplacementSettings settings;

		[Token(Token = "0x4000B2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GrassDisplacementPass m_GrassDisplacementPass;

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x136182C", Offset = "0x136182C", VA = "0x136182C", Slot = "5")]
		public override void Create()
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x13618C8", Offset = "0x13618C8", VA = "0x13618C8", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x13618EC", Offset = "0x13618EC", VA = "0x13618EC")]
		public GrassDisplacementRenderFeature()
		{
		}
	}
	[Token(Token = "0x200020B")]
	public class GrassDisplacementPass : ScriptableRenderPass
	{
		[Token(Token = "0x4000B35")]
		private const string ProfilerTag = "Render Lux Grass Displacement FX";

		[Token(Token = "0x4000B36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ProfilingSampler m_ProfilingSampler;

		[Token(Token = "0x4000B37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ShaderTagId m_GrassDisplacementFXShaderTag;

		[Token(Token = "0x4000B38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private SinglePassStereoMode m_StereoRenderingMode;

		[Token(Token = "0x4000B39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Color m_ClearColor;

		[Token(Token = "0x4000B3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTargetHandle m_GrassDisplacementFX;

		[Token(Token = "0x4000B3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Matrix4x4 projectionMatrix;

		[Token(Token = "0x4000B3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Matrix4x4 worldToCameraMatrix;

		[Token(Token = "0x4000B3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public float m_Size;

		[Token(Token = "0x4000B3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		public int m_Resolution;

		[Token(Token = "0x4000B3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public bool m_ShiftRenderTex;

		[Token(Token = "0x4000B40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private float stepSize;

		[Token(Token = "0x4000B41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float oneOverStepSize;

		[Token(Token = "0x4000B42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector4 posSize;

		[Token(Token = "0x4000B43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int DisplacementTexPosSizePID;

		[Token(Token = "0x1700014B")]
		private FilteringSettings transparentFilterSettings
		{
			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x1361974", Offset = "0x1361974", VA = "0x1361974")]
			[CompilerGenerated]
			get
			{
				return default(FilteringSettings);
			}
			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x136198C", Offset = "0x136198C", VA = "0x136198C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x13619A4", Offset = "0x13619A4", VA = "0x13619A4")]
		public GrassDisplacementPass()
		{
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x1361B68", Offset = "0x1361B68", VA = "0x1361B68", Slot = "6")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x1361D98", Offset = "0x1361D98", VA = "0x1361D98", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x13622DC", Offset = "0x13622DC", VA = "0x13622DC", Slot = "7")]
		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
	[Token(Token = "0x200020C")]
	[AttributeUsage(AttributeTargets.Field)]
	public class LayerAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x13623CC", Offset = "0x13623CC", VA = "0x13623CC")]
		public LayerAttribute()
		{
		}
	}
}
namespace LuxURPEssentials
{
	[Token(Token = "0x200020D")]
	public class DecalManager : MonoBehaviour
	{
		[Token(Token = "0x4000B45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Gizmos;

		[Token(Token = "0x4000B46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DrawDecalGizmos;

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x13623D4", Offset = "0x13623D4", VA = "0x13623D4")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x1362434", Offset = "0x1362434", VA = "0x1362434")]
		public DecalManager()
		{
		}
	}
	[Token(Token = "0x200020E")]
	[RequireComponent(typeof(MeshFilter))]
	public class LuxURP_BillboardBounds : MonoBehaviour
	{
		[Token(Token = "0x4000B47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Scale of the tweaked bounding box.")]
		[Space(18f)]
		[SerializeField]
		[Space(5f)]
		[LuxURP_HelpBtn("h.9i03ddhmnooa")]
		private Vector3 _Scale;

		[Token(Token = "0x4000B48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If checked Unity will instantiate the assigned mesh on Start().")]
		[SerializeField]
		private bool _createUniqueMesh;

		[Token(Token = "0x4000B49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		[Space(8f)]
		[Tooltip("Check this to preview the scaled bounding box.")]
		[SerializeField]
		private bool _drawBounds;

		[Token(Token = "0x4000B4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Mesh _Mesh;

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x1362490", Offset = "0x1362490", VA = "0x1362490")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x13624A0", Offset = "0x13624A0", VA = "0x13624A0")]
		private void SetBounds()
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x13626BC", Offset = "0x13626BC", VA = "0x13626BC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x13628F4", Offset = "0x13628F4", VA = "0x13628F4")]
		public LuxURP_BillboardBounds()
		{
		}
	}
	[Token(Token = "0x200020F")]
	public class LuxURP_HelpBtn : PropertyAttribute
	{
		[Token(Token = "0x4000B4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string URL;

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x1362914", Offset = "0x1362914", VA = "0x1362914")]
		public LuxURP_HelpBtn(string URL)
		{
		}
	}
	[Token(Token = "0x2000210")]
	public class LuxURP_LayerBasedCulling : MonoBehaviour
	{
		[Token(Token = "0x4000B4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LuxURP_HelpBtn("h.2uxuzzrgrwpo", order = 0)]
		[Space(5f, order = 1)]
		public LayerMask SmallDetailsLayer;

		[Token(Token = "0x4000B4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SmallDetailsDistance;

		[Token(Token = "0x4000B4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask MediumDetailsLayer;

		[Token(Token = "0x4000B4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float MediumDetailsDistance;

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x1362944", Offset = "0x1362944", VA = "0x1362944")]
		private int GetLayerNumber(int LayerValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x1362964", Offset = "0x1362964", VA = "0x1362964")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x1362AF8", Offset = "0x1362AF8", VA = "0x1362AF8")]
		public LuxURP_LayerBasedCulling()
		{
		}
	}
	[Token(Token = "0x2000211")]
	[ExecuteAlways]
	public class LuxURP_SetupGlobals : MonoBehaviour
	{
		[Token(Token = "0x4000B50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D _BestFittingNormal;

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x1362B10", Offset = "0x1362B10", VA = "0x1362B10")]
		private void SetupGlobals()
		{
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x1362BA4", Offset = "0x1362BA4", VA = "0x1362BA4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x1362BA8", Offset = "0x1362BA8", VA = "0x1362BA8")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x1362BAC", Offset = "0x1362BAC", VA = "0x1362BAC")]
		public LuxURP_SetupGlobals()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000212")]
	public enum ToneMappingModes
	{
		[Token(Token = "0x4000B52")]
		Custom,
		[Token(Token = "0x4000B53")]
		ACES
	}
	[Token(Token = "0x2000213")]
	[ExecuteAlways]
	public class LuxURP_Tonemapping : MonoBehaviour
	{
		[Token(Token = "0x4000B54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Space(8f)]
		[LuxURP_HelpBtn("h.zdqgjigbf0e4")]
		[Space(3f)]
		[Space(5f)]
		public bool _enableTonemapping;

		[Token(Token = "0x4000B55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Space(8f)]
		public ToneMappingModes _mode;

		[Token(Token = "0x4000B56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Custom Tonemapping")]
		[Space(8f)]
		public bool _enableNeutral;

		[Token(Token = "0x4000B57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(-1f, 1f)]
		[Space(4f)]
		public float _gamma;

		[Token(Token = "0x4000B58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(-1f, 1f)]
		public float _contrast;

		[Token(Token = "0x4000B59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(-1f, 1f)]
		public float _hue;

		[Token(Token = "0x4000B5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(-1f, 1f)]
		public float _saturation;

		[Token(Token = "0x4000B5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color _filter;

		[Token(Token = "0x4000B5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int _LuxURP_EnableTonemapping;

		[Token(Token = "0x4000B5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int _LuxURP_ToneMappingMode;

		[Token(Token = "0x4000B5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int _LuxURP_EnableNeutral;

		[Token(Token = "0x4000B5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int _LuxURP_Gamma;

		[Token(Token = "0x4000B60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int _LuxURP_Contrast;

		[Token(Token = "0x4000B61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int _LuxURP_Saturation;

		[Token(Token = "0x4000B62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int _LuxURP_Hue;

		[Token(Token = "0x4000B63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly int _LuxURP_Filter;

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x1362BB4", Offset = "0x1362BB4", VA = "0x1362BB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x1362D1C", Offset = "0x1362D1C", VA = "0x1362D1C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x1362D7C", Offset = "0x1362D7C", VA = "0x1362D7C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x1362BB8", Offset = "0x1362BB8", VA = "0x1362BB8")]
		private void UpdateSettings()
		{
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x1362D80", Offset = "0x1362D80", VA = "0x1362D80")]
		public LuxURP_Tonemapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000214")]
	public enum RTSize
	{
		[Token(Token = "0x4000B65")]
		_128 = 128,
		[Token(Token = "0x4000B66")]
		_256 = 256,
		[Token(Token = "0x4000B67")]
		_384 = 384,
		[Token(Token = "0x4000B68")]
		_512 = 512,
		[Token(Token = "0x4000B69")]
		_1024 = 1024
	}
	[Serializable]
	[Token(Token = "0x2000215")]
	public enum RTFormat
	{
		[Token(Token = "0x4000B6B")]
		ARGB32,
		[Token(Token = "0x4000B6C")]
		ARGBHalf
	}
	[Serializable]
	[Token(Token = "0x2000216")]
	public enum GustMixLayer
	{
		[Token(Token = "0x4000B6E")]
		Layer_0,
		[Token(Token = "0x4000B6F")]
		Layer_1,
		[Token(Token = "0x4000B70")]
		Layer_2
	}
	[Token(Token = "0x2000217")]
	[RequireComponent(typeof(WindZone))]
	[ExecuteAlways]
	public class LuxURP_Wind : MonoBehaviour
	{
		[Token(Token = "0x4000B71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LuxURP_HelpBtn("h.wnnhm4pxp610")]
		[Space(5f)]
		[Space(3f)]
		public bool UpdateInEditMode;

		[Token(Token = "0x4000B72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Smaller resoltions will speed up rendering but may result in some quantization regarding the final bending.")]
		[Header("Render Texture Settings")]
		[Space(4f)]
		public RTSize Resolution;

		[Token(Token = "0x4000B73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("ARGB32 needs less memory and bandwidth but creates a slightly more quantized results - while ARGBHalf needs more memory and bandwith but gives you smoother results.")]
		public RTFormat Format;

		[Token(Token = "0x4000B74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Expects an RGBA texture with diffirently scaled noise patterns. If left empty the script will grab the default one.")]
		public Texture WindBaseTex;

		[Token(Token = "0x4000B75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader WindCompositeShader;

		[Token(Token = "0x4000B76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Space(4f)]
		[Header("Wind Frequency and Turbulence")]
		[Range(0.1f, 1f)]
		[Tooltip("Drives the frequency of the turbulence animation according to the main wind strength.")]
		public float WindToFrequency;

		[Token(Token = "0x4000B77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Drives the strength of turbulence according to the main wind strength.")]
		public AnimationCurve WindToTurbulence;

		[Token(Token = "0x4000B78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 4f)]
		[Tooltip("Scales the final turbulence value used by the shaders.")]
		public float MaxTurbulence;

		[Token(Token = "0x4000B79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Base Wind Speed in km/h at Main = 1 (WindZone).")]
		[Space(4f)]
		[Header("Wind Speed and Size")]
		public float BaseWindSpeed;

		[Token(Token = "0x4000B7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Size of the Wind RenderTexture in World Space.")]
		public float SizeInWorldSpace;

		[Token(Token = "0x4000B7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Space(4f)]
		[Tooltip("Speed of Layer0 (red channel) relative to the Base Wind Speed.")]
		public float speedLayer0;

		[Token(Token = "0x4000B7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Speed of Layer1 (green channel) relative to the Base Wind Speed.")]
		public float speedLayer1;

		[Token(Token = "0x4000B7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Speed of Layer3 (blue channel) relative to the Base Wind Speed.")]
		public float speedLayer2;

		[Token(Token = "0x4000B7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Noise")]
		[Space(4f)]
		[Tooltip("Tiling of the gust layer (alpha channel) relative to Size In WorldSpace.")]
		public int GrassGustTiling;

		[Token(Token = "0x4000B7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Speed of the gust layer (alpha channel) relative to the Base Wind Speed.")]
		public float GrassGustSpeed;

		[Token(Token = "0x4000B80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Lets you choose a Wind Layer you want the dedicated Gust sample to be combined with.")]
		public GustMixLayer LayerToMixWith;

		[Token(Token = "0x4000B81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Space(4f)]
		[Header("Wind Multipliers")]
		public float Grass;

		[Token(Token = "0x4000B82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float Foliage;

		[Token(Token = "0x4000B83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RenderTexture WindRenderTexture;

		[Token(Token = "0x4000B84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material m_material;

		[Token(Token = "0x4000B85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector2 uvs;

		[Token(Token = "0x4000B86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector2 uvs1;

		[Token(Token = "0x4000B87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2 uvs2;

		[Token(Token = "0x4000B88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector2 uvs3;

		[Token(Token = "0x4000B89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform trans;

		[Token(Token = "0x4000B8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private WindZone windZone;

		[Token(Token = "0x4000B8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float mainWind;

		[Token(Token = "0x4000B8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int WindRTPID;

		[Token(Token = "0x4000B8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int LuxURPWindDirSizePID;

		[Token(Token = "0x4000B8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int LuxURPWindStrengthMultipliersPID;

		[Token(Token = "0x4000B8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int LuxURPSinTimePID;

		[Token(Token = "0x4000B90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int LuxURPGustPID;

		[Token(Token = "0x4000B91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int LuxURPGustMixLayerPID;

		[Token(Token = "0x4000B92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int LuxURPBendFrequencyPID;

		[Token(Token = "0x4000B93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly int LuxURPWindUVsPID;

		[Token(Token = "0x4000B94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int LuxURPWindUVs1PID;

		[Token(Token = "0x4000B95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly int LuxURPWindUVs2PID;

		[Token(Token = "0x4000B96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int LuxURPWindUVs3PID;

		[Token(Token = "0x4000B97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int previousRTSize;

		[Token(Token = "0x4000B98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int previousRTFormat;

		[Token(Token = "0x4000B99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Vector4 WindDirectionSize;

		[Token(Token = "0x4000B9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float WindTurbulence;

		[Token(Token = "0x4000B9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Vector3[] MixLayers;

		[Token(Token = "0x4000B9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private double currentTime;

		[Token(Token = "0x4000B9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private double domainTime_Wind;

		[Token(Token = "0x4000B9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float temp_WindFrequency;

		[Token(Token = "0x4000B9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float freqSpeed;

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x1362F4C", Offset = "0x1362F4C", VA = "0x1362F4C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x13632A8", Offset = "0x13632A8", VA = "0x13632A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x1363134", Offset = "0x1363134", VA = "0x1363134")]
		private void SetupRT()
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x13633EC", Offset = "0x13633EC", VA = "0x13633EC")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x1363620", Offset = "0x1363620", VA = "0x1363620")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x13639E4", Offset = "0x13639E4", VA = "0x13639E4")]
		public LuxURP_Wind()
		{
		}
	}
	[Token(Token = "0x2000218")]
	[RequireComponent(typeof(Terrain))]
	public class GetTerrainHeightNormalMap : MonoBehaviour
	{
		[Token(Token = "0x4000BA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TerrainData targetTerrainData;

		[Token(Token = "0x4000BA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string savePathTerrainHeightNormalMap;

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x1363E84", Offset = "0x1363E84", VA = "0x1363E84")]
		public void GetTerData()
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x1363F54", Offset = "0x1363F54", VA = "0x1363F54")]
		public GetTerrainHeightNormalMap()
		{
		}
	}
}
namespace LuxURPEssentials.Demo
{
	[Token(Token = "0x2000219")]
	public class AnimateSphere : MonoBehaviour
	{
		[Token(Token = "0x4000BA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform trans;

		[Token(Token = "0x4000BA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float yPos;

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x1363F5C", Offset = "0x1363F5C", VA = "0x1363F5C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x1363FD4", Offset = "0x1363FD4", VA = "0x1363FD4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x1364040", Offset = "0x1364040", VA = "0x1364040")]
		public AnimateSphere()
		{
		}
	}
	[Token(Token = "0x200021A")]
	public class CheckSettings : MonoBehaviour
	{
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x1364048", Offset = "0x1364048", VA = "0x1364048")]
		private void Start()
		{
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x136417C", Offset = "0x136417C", VA = "0x136417C")]
		public CheckSettings()
		{
		}
	}
	[Token(Token = "0x200021B")]
	public class ExtendedFlycam : MonoBehaviour
	{
		[Token(Token = "0x4000BA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x4000BA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float climbSpeed;

		[Token(Token = "0x4000BA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float normalMoveSpeed;

		[Token(Token = "0x4000BA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoveFactor;

		[Token(Token = "0x4000BA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fastMoveFactor;

		[Token(Token = "0x4000BA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float rotationX;

		[Token(Token = "0x4000BAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rotationY;

		[Token(Token = "0x4000BAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool isOrtho;

		[Token(Token = "0x4000BAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Camera cam;

		[Token(Token = "0x4000BAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isActive;

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x1364184", Offset = "0x1364184", VA = "0x1364184")]
		private void Start()
		{
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x1364258", Offset = "0x1364258", VA = "0x1364258")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x13649A0", Offset = "0x13649A0", VA = "0x13649A0")]
		public ExtendedFlycam()
		{
		}
	}
	[Token(Token = "0x200021C")]
	public class MouseSelect : MonoBehaviour
	{
		[Token(Token = "0x4000BAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform selectedTransform;

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x13649C4", Offset = "0x13649C4", VA = "0x13649C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x1364C20", Offset = "0x1364C20", VA = "0x1364C20")]
		public MouseSelect()
		{
		}
	}
	[Token(Token = "0x200021D")]
	public class ToggleOutlineSelection : MonoBehaviour
	{
		[Token(Token = "0x4000BAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material SelectionMaterial;

		[Token(Token = "0x4000BB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material OutlineMaterial;

		[Token(Token = "0x4000BB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Renderer rend;

		[Token(Token = "0x4000BB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material[] BaseMatArray;

		[Token(Token = "0x4000BB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material[] SelectedMatArray;

		[Token(Token = "0x4000BB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool Selected;

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x1364C28", Offset = "0x1364C28", VA = "0x1364C28")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x1364BCC", Offset = "0x1364BCC", VA = "0x1364BCC")]
		public void Select()
		{
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x1364D6C", Offset = "0x1364D6C", VA = "0x1364D6C")]
		public ToggleOutlineSelection()
		{
		}
	}
}
namespace DentedPixel.LTExamples
{
	[Token(Token = "0x200021E")]
	public class PathBezier : MonoBehaviour
	{
		[Token(Token = "0x4000BB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] trans;

		[Token(Token = "0x4000BB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LTBezierPath cr;

		[Token(Token = "0x4000BB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject avatar1;

		[Token(Token = "0x4000BB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float iter;

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x1364DEC", Offset = "0x1364DEC", VA = "0x1364DEC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x136503C", Offset = "0x136503C", VA = "0x136503C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x13651CC", Offset = "0x13651CC", VA = "0x13651CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x1365214", Offset = "0x1365214", VA = "0x1365214")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x1365264", Offset = "0x1365264", VA = "0x1365264")]
		public PathBezier()
		{
		}
	}
	[Token(Token = "0x200021F")]
	public class TestingUnitTests : MonoBehaviour
	{
		[Token(Token = "0x2000223")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x4000BE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TestingUnitTests <>4__this;

			[Token(Token = "0x4000BE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int pauseCount;

			[Token(Token = "0x4000BE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject cubeRound;

			[Token(Token = "0x4000BE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 onStartPos;

			[Token(Token = "0x4000BE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 onStartPosSpline;

			[Token(Token = "0x4000BE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public GameObject cubeSpline;

			[Token(Token = "0x4000BE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int setOnStartNum;

			[Token(Token = "0x4000BEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool hasGroupTweensCheckStarted;

			[Token(Token = "0x4000BEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public float previousXlt4;

			[Token(Token = "0x4000BEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool onUpdateWasCalled;

			[Token(Token = "0x4000BED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float start;

			[Token(Token = "0x4000BEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float expectedTime;

			[Token(Token = "0x4000BEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action <>9__8;

			[Token(Token = "0x4000BF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Action <>9__10;

			[Token(Token = "0x4000BF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Action <>9__9;

			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x136888C", Offset = "0x136888C", VA = "0x136888C")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0x1368894", Offset = "0x1368894", VA = "0x1368894")]
			internal void <timeBasedTesting>b__0()
			{
			}

			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x13688B8", Offset = "0x13688B8", VA = "0x13688B8")]
			internal void <timeBasedTesting>b__1()
			{
			}

			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x13688DC", Offset = "0x13688DC", VA = "0x13688DC")]
			internal void <timeBasedTesting>b__2(float val)
			{
			}

			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x13688EC", Offset = "0x13688EC", VA = "0x13688EC")]
			internal void <timeBasedTesting>b__3()
			{
			}

			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x1368A94", Offset = "0x1368A94", VA = "0x1368A94")]
			internal void <timeBasedTesting>b__4()
			{
			}

			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x1368EF4", Offset = "0x1368EF4", VA = "0x1368EF4")]
			internal void <timeBasedTesting>b__8()
			{
			}

			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x1368F04", Offset = "0x1368F04", VA = "0x1368F04")]
			internal void <timeBasedTesting>b__9()
			{
			}

			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x1369014", Offset = "0x1369014", VA = "0x1369014")]
			internal void <timeBasedTesting>b__10()
			{
			}

			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0x13691F8", Offset = "0x13691F8", VA = "0x13691F8")]
			internal void <timeBasedTesting>b__5()
			{
			}

			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0x13695B4", Offset = "0x13695B4", VA = "0x13695B4")]
			internal void <timeBasedTesting>b__6(float val)
			{
			}

			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0x13695C0", Offset = "0x13695C0", VA = "0x13695C0")]
			internal void <timeBasedTesting>b__7()
			{
			}
		}

		[Token(Token = "0x2000224")]
		[CompilerGenerated]
		private sealed class <timeBasedTesting>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TestingUnitTests <>4__this;

			[Token(Token = "0x4000BF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass23_0 <>8__1;

			[Token(Token = "0x4000BF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <descriptionMatchCount>5__2;

			[Token(Token = "0x1700014C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AE1")]
				[Address(RVA = "0x136B340", Offset = "0x136B340", VA = "0x136B340", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700014D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AE3")]
				[Address(RVA = "0x136B388", Offset = "0x136B388", VA = "0x136B388", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000ADE")]
			[Address(RVA = "0x1366AA4", Offset = "0x1366AA4", VA = "0x1366AA4")]
			[DebuggerHidden]
			public <timeBasedTesting>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000ADF")]
			[Address(RVA = "0x1369838", Offset = "0x1369838", VA = "0x1369838", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0x136983C", Offset = "0x136983C", VA = "0x136983C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0x136B348", Offset = "0x136B348", VA = "0x136B348", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000225")]
		[CompilerGenerated]
		private sealed class <lotsOfCancels>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TestingUnitTests <>4__this;

			[Token(Token = "0x4000BFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <cubeCount>5__2;

			[Token(Token = "0x4000BFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int[] <tweensA>5__3;

			[Token(Token = "0x4000BFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private GameObject[] <aGOs>5__4;

			[Token(Token = "0x4000BFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int[] <tweensB>5__5;

			[Token(Token = "0x4000BFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private GameObject[] <bGOs>5__6;

			[Token(Token = "0x1700014E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AE7")]
				[Address(RVA = "0x136BE08", Offset = "0x136BE08", VA = "0x136BE08", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700014F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AE9")]
				[Address(RVA = "0x136BE50", Offset = "0x136BE50", VA = "0x136BE50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0x1366B40", Offset = "0x1366B40", VA = "0x1366B40")]
			[DebuggerHidden]
			public <lotsOfCancels>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0x136B390", Offset = "0x136B390", VA = "0x136B390", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0x136B394", Offset = "0x136B394", VA = "0x136B394", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0x136BE10", Offset = "0x136BE10", VA = "0x136BE10", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000BB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject cube1;

		[Token(Token = "0x4000BBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject cube2;

		[Token(Token = "0x4000BBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject cube3;

		[Token(Token = "0x4000BBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject cube4;

		[Token(Token = "0x4000BBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject cubeAlpha1;

		[Token(Token = "0x4000BBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject cubeAlpha2;

		[Token(Token = "0x4000BBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool eventGameObjectWasCalled;

		[Token(Token = "0x4000BC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool eventGeneralWasCalled;

		[Token(Token = "0x4000BC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int lt1Id;

		[Token(Token = "0x4000BC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LTDescr lt2;

		[Token(Token = "0x4000BC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private LTDescr lt3;

		[Token(Token = "0x4000BC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private LTDescr lt4;

		[Token(Token = "0x4000BC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private LTDescr[] groupTweens;

		[Token(Token = "0x4000BC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject[] groupGOs;

		[Token(Token = "0x4000BC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int groupTweensCnt;

		[Token(Token = "0x4000BC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int rotateRepeat;

		[Token(Token = "0x4000BC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int rotateRepeatAngle;

		[Token(Token = "0x4000BCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private GameObject boxNoCollider;

		[Token(Token = "0x4000BCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float timeElapsedNormalTimeScale;

		[Token(Token = "0x4000BCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float timeElapsedIgnoreTimeScale;

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x136526C", Offset = "0x136526C", VA = "0x136526C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x1365354", Offset = "0x1365354", VA = "0x1365354")]
		private void Start()
		{
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x1366994", Offset = "0x1366994", VA = "0x1366994")]
		private GameObject cubeNamed(string name)
		{
			return null;
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x1366A30", Offset = "0x1366A30", VA = "0x1366A30")]
		[IteratorStateMachine(typeof(<timeBasedTesting>d__23))]
		private IEnumerator timeBasedTesting()
		{
			return null;
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x1366ACC", Offset = "0x1366ACC", VA = "0x1366ACC")]
		[IteratorStateMachine(typeof(<lotsOfCancels>d__24))]
		private IEnumerator lotsOfCancels()
		{
			return null;
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x1366B68", Offset = "0x1366B68", VA = "0x1366B68")]
		private void rotateRepeatFinished()
		{
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x1366BC4", Offset = "0x1366BC4", VA = "0x1366BC4")]
		private void rotateRepeatAllFinished()
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x1366DD4", Offset = "0x1366DD4", VA = "0x1366DD4")]
		private void eventGameObjectCalled(LTEvent e)
		{
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x1366DE0", Offset = "0x1366DE0", VA = "0x1366DE0")]
		private void eventGeneralCalled(LTEvent e)
		{
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x1366DEC", Offset = "0x1366DEC", VA = "0x1366DEC")]
		public TestingUnitTests()
		{
		}
	}
}
namespace VRTK
{
	[Token(Token = "0x2000226")]
	public class Sink_1 : VRTK_InteractableObject
	{
		[Token(Token = "0x2000227")]
		[CompilerGenerated]
		private sealed class <Water>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Sink_1 <>4__this;

			[Token(Token = "0x17000150")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AF3")]
				[Address(RVA = "0x136C0F4", Offset = "0x136C0F4", VA = "0x136C0F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000151")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AF5")]
				[Address(RVA = "0x136C13C", Offset = "0x136C13C", VA = "0x136C13C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x136C018", Offset = "0x136C018", VA = "0x136C018")]
			[DebuggerHidden]
			public <Water>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x136C048", Offset = "0x136C048", VA = "0x136C048", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0x136C04C", Offset = "0x136C04C", VA = "0x136C04C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x136C0FC", Offset = "0x136C0FC", VA = "0x136C0FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000BFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public ParticleSystem water;

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x136BE58", Offset = "0x136BE58", VA = "0x136BE58", Slot = "27")]
		public override void Grabbed(VRTK_InteractGrab currentGrabbingObject)
		{
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x136BEF8", Offset = "0x136BEF8", VA = "0x136BEF8", Slot = "29")]
		public override void Ungrabbed(VRTK_InteractGrab previousGrabbingObject)
		{
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x136BF00", Offset = "0x136BF00", VA = "0x136BF00")]
		private void WaterStart()
		{
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x136BF94", Offset = "0x136BF94", VA = "0x136BF94")]
		private void WaterStop()
		{
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x136BE84", Offset = "0x136BE84", VA = "0x136BE84")]
		[IteratorStateMachine(typeof(<Water>d__5))]
		private IEnumerator Water()
		{
			return null;
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x136C040", Offset = "0x136C040", VA = "0x136C040")]
		public Sink_1()
		{
		}
	}
	[Token(Token = "0x2000228")]
	public class Vise : VRTK_InteractableObject
	{
		[Token(Token = "0x2000229")]
		[CompilerGenerated]
		private sealed class <NeedleMovement>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vise <>4__this;

			[Token(Token = "0x17000152")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AFD")]
				[Address(RVA = "0x136C360", Offset = "0x136C360", VA = "0x136C360", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000153")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AFF")]
				[Address(RVA = "0x136C3A8", Offset = "0x136C3A8", VA = "0x136C3A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x136C1E0", Offset = "0x136C1E0", VA = "0x136C1E0")]
			[DebuggerHidden]
			public <NeedleMovement>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0x136C210", Offset = "0x136C210", VA = "0x136C210", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0x136C214", Offset = "0x136C214", VA = "0x136C214", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0x136C368", Offset = "0x136C368", VA = "0x136C368", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public GameObject needle;

		[Token(Token = "0x4000C04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[Range(0f, 1f)]
		public Vector3 needle_left_position;

		[Token(Token = "0x4000C05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		public Vector3 needle_right_position;

		[Token(Token = "0x4000C06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public List<GameObject> buttons;

		[Token(Token = "0x4000C07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float button_actual_rotation;

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x136C144", Offset = "0x136C144", VA = "0x136C144", Slot = "66")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x136C1D8", Offset = "0x136C1D8", VA = "0x136C1D8", Slot = "30")]
		public override void StartUsing(VRTK_InteractUse currentUsingObject)
		{
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x136C164", Offset = "0x136C164", VA = "0x136C164")]
		[IteratorStateMachine(typeof(<NeedleMovement>d__7))]
		private IEnumerator NeedleMovement()
		{
			return null;
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x136C208", Offset = "0x136C208", VA = "0x136C208")]
		public Vise()
		{
		}
	}
	[Token(Token = "0x200022A")]
	public class Wajcha : VRTK_InteractableObject
	{
		[Token(Token = "0x200022B")]
		[CompilerGenerated]
		private sealed class <Switch>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Wajcha <>4__this;

			[Token(Token = "0x17000154")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B09")]
				[Address(RVA = "0x136C690", Offset = "0x136C690", VA = "0x136C690", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000155")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B0B")]
				[Address(RVA = "0x136C6D8", Offset = "0x136C6D8", VA = "0x136C6D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B06")]
			[Address(RVA = "0x136C520", Offset = "0x136C520", VA = "0x136C520")]
			[DebuggerHidden]
			public <Switch>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000B07")]
			[Address(RVA = "0x136C550", Offset = "0x136C550", VA = "0x136C550", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x136C554", Offset = "0x136C554", VA = "0x136C554", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0x136C698", Offset = "0x136C698", VA = "0x136C698", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public Material mat;

		[Token(Token = "0x4000C0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Color baseColor;

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x136C3B0", Offset = "0x136C3B0", VA = "0x136C3B0", Slot = "66")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x136C458", Offset = "0x136C458", VA = "0x136C458", Slot = "30")]
		public override void StartUsing(VRTK_InteractUse currentUsingObject)
		{
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x136C460", Offset = "0x136C460", VA = "0x136C460", Slot = "25")]
		public override void StartTouching([Optional] VRE_InteractTouch currentTouchingObject)
		{
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x136C500", Offset = "0x136C500", VA = "0x136C500", Slot = "26")]
		public override void StopTouching([Optional] VRE_InteractTouch previousTouchingObject)
		{
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x136C48C", Offset = "0x136C48C", VA = "0x136C48C")]
		[IteratorStateMachine(typeof(<Switch>d__6))]
		private IEnumerator Switch()
		{
			return null;
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x136C548", Offset = "0x136C548", VA = "0x136C548")]
		public Wajcha()
		{
		}
	}
	[Token(Token = "0x200022C")]
	public class Fan : MonoBehaviour, IButton
	{
		[Token(Token = "0x200022D")]
		[CompilerGenerated]
		private sealed class <Using>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Fan <>4__this;

			[Token(Token = "0x17000156")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B13")]
				[Address(RVA = "0x136C874", Offset = "0x136C874", VA = "0x136C874", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000157")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B15")]
				[Address(RVA = "0x136C8BC", Offset = "0x136C8BC", VA = "0x136C8BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B10")]
			[Address(RVA = "0x136C77C", Offset = "0x136C77C", VA = "0x136C77C")]
			[DebuggerHidden]
			public <Using>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000B11")]
			[Address(RVA = "0x136C7AC", Offset = "0x136C7AC", VA = "0x136C7AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B12")]
			[Address(RVA = "0x136C7B0", Offset = "0x136C7B0", VA = "0x136C7B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B14")]
			[Address(RVA = "0x136C87C", Offset = "0x136C87C", VA = "0x136C87C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 actualRotation;

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x136C6E0", Offset = "0x136C6E0", VA = "0x136C6E0", Slot = "4")]
		public void ButtonStartUsing(GameObject buttonObject)
		{
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x136C774", Offset = "0x136C774", VA = "0x136C774", Slot = "5")]
		public void ButtonEndUsing(GameObject buttonObject)
		{
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x136C700", Offset = "0x136C700", VA = "0x136C700")]
		[IteratorStateMachine(typeof(<Using>d__3))]
		private IEnumerator Using()
		{
			return null;
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x136C7A4", Offset = "0x136C7A4", VA = "0x136C7A4")]
		public Fan()
		{
		}
	}
	[Token(Token = "0x200022E")]
	public class GearboxLiftButton : VRTK_InteractableObject
	{
		[Token(Token = "0x200022F")]
		[CompilerGenerated]
		private sealed class <CheckRotation>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GearboxLiftButton <>4__this;

			[Token(Token = "0x17000158")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B1D")]
				[Address(RVA = "0x136CB74", Offset = "0x136CB74", VA = "0x136CB74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000159")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B1F")]
				[Address(RVA = "0x136CBBC", Offset = "0x136CBBC", VA = "0x136CBBC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0x136C9D0", Offset = "0x136C9D0", VA = "0x136C9D0")]
			[DebuggerHidden]
			public <CheckRotation>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x136CA10", Offset = "0x136CA10", VA = "0x136CA10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x136CA14", Offset = "0x136CA14", VA = "0x136CA14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x136CB7C", Offset = "0x136CB7C", VA = "0x136CB7C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public Rigidbody parent;

		[Token(Token = "0x4000C15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[SerializeField]
		private GearboxLift gearboxLiftArm;

		[Token(Token = "0x4000C16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float actual_rot;

		[Token(Token = "0x4000C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float prev_rot;

		[Token(Token = "0x4000C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private bool move_to_the_end;

		[Token(Token = "0x4000C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private float partOfState;

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x136C8C4", Offset = "0x136C8C4", VA = "0x136C8C4", Slot = "27")]
		public override void Grabbed([Optional] VRTK_InteractGrab currentGrabbingObject)
		{
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x136C9A4", Offset = "0x136C9A4", VA = "0x136C9A4", Slot = "29")]
		public override void Ungrabbed([Optional] VRTK_InteractGrab previousGrabbingObject)
		{
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x136C930", Offset = "0x136C930", VA = "0x136C930")]
		[IteratorStateMachine(typeof(<CheckRotation>d__8))]
		private IEnumerator CheckRotation()
		{
			return null;
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x136C9F8", Offset = "0x136C9F8", VA = "0x136C9F8")]
		public GearboxLiftButton()
		{
		}
	}
	[Token(Token = "0x2000230")]
	public class GearboxLiftJack : VRTK_InteractableObject
	{
		[Token(Token = "0x2000231")]
		[CompilerGenerated]
		private sealed class <CheckRotation>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GearboxLiftJack <>4__this;

			[Token(Token = "0x1700015A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B27")]
				[Address(RVA = "0x136CE70", Offset = "0x136CE70", VA = "0x136CE70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B29")]
				[Address(RVA = "0x136CEB8", Offset = "0x136CEB8", VA = "0x136CEB8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x136CCD8", Offset = "0x136CCD8", VA = "0x136CCD8")]
			[DebuggerHidden]
			public <CheckRotation>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x136CD10", Offset = "0x136CD10", VA = "0x136CD10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B26")]
			[Address(RVA = "0x136CD14", Offset = "0x136CD14", VA = "0x136CD14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B28")]
			[Address(RVA = "0x136CE78", Offset = "0x136CE78", VA = "0x136CE78", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public Rigidbody parent;

		[Token(Token = "0x4000C1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[SerializeField]
		private GearboxLift gearboxLiftArm;

		[Token(Token = "0x4000C1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float actual_rot;

		[Token(Token = "0x4000C20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float prev_rot;

		[Token(Token = "0x4000C21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private bool move_to_the_end;

		[Token(Token = "0x4000C22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private float partOfState;

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x136CBC4", Offset = "0x136CBC4", VA = "0x136CBC4", Slot = "27")]
		public override void Grabbed([Optional] VRTK_InteractGrab currentGrabbingObject)
		{
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x136CCA0", Offset = "0x136CCA0", VA = "0x136CCA0", Slot = "29")]
		public override void Ungrabbed([Optional] VRTK_InteractGrab previousGrabbingObject)
		{
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x136CC2C", Offset = "0x136CC2C", VA = "0x136CC2C")]
		[IteratorStateMachine(typeof(<CheckRotation>d__8))]
		private IEnumerator CheckRotation()
		{
			return null;
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x136CD00", Offset = "0x136CD00", VA = "0x136CD00")]
		public GearboxLiftJack()
		{
		}
	}
	[Token(Token = "0x2000232")]
	public class GrabbableObjectWithSmallButtonToUse : VRTK_InteractableObject
	{
		[Token(Token = "0x4000C26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[SerializeField]
		private Button1 button1;

		[Token(Token = "0x4000C27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[SerializeField]
		private bool active;

		[Token(Token = "0x4000C28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x191")]
		[SerializeField]
		private bool pushed;

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x136CEC0", Offset = "0x136CEC0", VA = "0x136CEC0", Slot = "30")]
		public override void StartUsing(VRTK_InteractUse currentUsingObject)
		{
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x136CF74", Offset = "0x136CF74", VA = "0x136CF74")]
		public GrabbableObjectWithSmallButtonToUse()
		{
		}
	}
	[Token(Token = "0x2000233")]
	public class HeavyObjects : VRTK_InteractableObject
	{
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x136CF7C", Offset = "0x136CF7C", VA = "0x136CF7C", Slot = "30")]
		public override void StartUsing(VRTK_InteractUse currentUsingObject)
		{
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x136CF84", Offset = "0x136CF84", VA = "0x136CF84", Slot = "25")]
		public override void StartTouching(VRE_InteractTouch currentTouchingObject)
		{
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x136CF8C", Offset = "0x136CF8C", VA = "0x136CF8C")]
		public HeavyObjects()
		{
		}
	}
	[Token(Token = "0x2000234")]
	public class IO_VRTK : VRTK_InteractableObject
	{
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x136CF94", Offset = "0x136CF94", VA = "0x136CF94", Slot = "30")]
		public override void StartUsing(VRTK_InteractUse currentUsingObject)
		{
		}

		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x136CF9C", Offset = "0x136CF9C", VA = "0x136CF9C")]
		public IO_VRTK()
		{
		}
	}
	[Token(Token = "0x2000235")]
	public class IO_VRTK_with_Wheels : VRTK_InteractableObject
	{
		[Token(Token = "0x4000C29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[SerializeField]
		private Wheels_Controller wheelsController;

		[Token(Token = "0x4000C2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[SerializeField]
		private One_Line_Wheels_Controller OLwheelsController;

		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x136CFA4", Offset = "0x136CFA4", VA = "0x136CFA4", Slot = "67")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x136D050", Offset = "0x136D050", VA = "0x136D050", Slot = "27")]
		public override void Grabbed([Optional] VRTK_InteractGrab currentGrabbingObject)
		{
		}

		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x136D194", Offset = "0x136D194", VA = "0x136D194", Slot = "29")]
		public override void Ungrabbed([Optional] VRTK_InteractGrab previousGrabbingObject)
		{
		}

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x136D274", Offset = "0x136D274", VA = "0x136D274")]
		public IO_VRTK_with_Wheels()
		{
		}
	}
	[Token(Token = "0x2000236")]
	public class Light : MonoBehaviour, IButton
	{
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x136D27C", Offset = "0x136D27C", VA = "0x136D27C", Slot = "4")]
		public void ButtonStartUsing(GameObject buttonObject)
		{
		}

		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x136D2AC", Offset = "0x136D2AC", VA = "0x136D2AC", Slot = "5")]
		public void ButtonEndUsing(GameObject buttonObject)
		{
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x136D2DC", Offset = "0x136D2DC", VA = "0x136D2DC")]
		public Light()
		{
		}
	}
	[Token(Token = "0x2000237")]
	public class One_Line_Wheels_Controller : MonoBehaviour
	{
		[Token(Token = "0x2000238")]
		public enum Axis
		{
			[Token(Token = "0x4000C32")]
			X,
			[Token(Token = "0x4000C33")]
			Y,
			[Token(Token = "0x4000C34")]
			Z
		}

		[Token(Token = "0x2000239")]
		[CompilerGenerated]
		private sealed class <RotationZ>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public One_Line_Wheels_Controller <>4__this;

			[Token(Token = "0x1700015C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B41")]
				[Address(RVA = "0x136D914", Offset = "0x136D914", VA = "0x136D914", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B43")]
				[Address(RVA = "0x136D95C", Offset = "0x136D95C", VA = "0x136D95C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B3E")]
			[Address(RVA = "0x136D570", Offset = "0x136D570", VA = "0x136D570")]
			[DebuggerHidden]
			public <RotationZ>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0x136D678", Offset = "0x136D678", VA = "0x136D678", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B40")]
			[Address(RVA = "0x136D67C", Offset = "0x136D67C", VA = "0x136D67C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x136D91C", Offset = "0x136D91C", VA = "0x136D91C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200023A")]
		[CompilerGenerated]
		private sealed class <RotationY>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public One_Line_Wheels_Controller <>4__this;

			[Token(Token = "0x1700015E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B47")]
				[Address(RVA = "0x136DBD8", Offset = "0x136DBD8", VA = "0x136DBD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B49")]
				[Address(RVA = "0x136DC20", Offset = "0x136DC20", VA = "0x136DC20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x136D598", Offset = "0x136D598", VA = "0x136D598")]
			[DebuggerHidden]
			public <RotationY>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x136D964", Offset = "0x136D964", VA = "0x136D964", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B46")]
			[Address(RVA = "0x136D968", Offset = "0x136D968", VA = "0x136D968", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B48")]
			[Address(RVA = "0x136DBE0", Offset = "0x136DBE0", VA = "0x136DBE0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200023B")]
		[CompilerGenerated]
		private sealed class <RotationX>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public One_Line_Wheels_Controller <>4__this;

			[Token(Token = "0x17000160")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B4D")]
				[Address(RVA = "0x136DE90", Offset = "0x136DE90", VA = "0x136DE90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000161")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B4F")]
				[Address(RVA = "0x136DED8", Offset = "0x136DED8", VA = "0x136DED8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0x136D5C0", Offset = "0x136D5C0", VA = "0x136D5C0")]
			[DebuggerHidden]
			public <RotationX>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000B4B")]
			[Address(RVA = "0x136DC28", Offset = "0x136DC28", VA = "0x136DC28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B4C")]
			[Address(RVA = "0x136DC2C", Offset = "0x136DC2C", VA = "0x136DC2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B4E")]
			[Address(RVA = "0x136DE98", Offset = "0x136DE98", VA = "0x136DE98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GameObject> wheels;

		[Token(Token = "0x4000C2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Axis axis;

		[Token(Token = "0x4000C2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] wheels_actual_rotation;

		[Token(Token = "0x4000C2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 previous_position;

		[Token(Token = "0x4000C2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 actual_position;

		[Token(Token = "0x4000C30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool rolling;

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x136D2E4", Offset = "0x136D2E4", VA = "0x136D2E4")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x136D130", Offset = "0x136D130", VA = "0x136D130")]
		public void Roll(bool roll)
		{
		}

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x136D414", Offset = "0x136D414", VA = "0x136D414")]
		[IteratorStateMachine(typeof(<RotationZ>d__9))]
		private IEnumerator RotationZ()
		{
			return null;
		}

		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x136D488", Offset = "0x136D488", VA = "0x136D488")]
		[IteratorStateMachine(typeof(<RotationY>d__10))]
		private IEnumerator RotationY()
		{
			return null;
		}

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x136D4FC", Offset = "0x136D4FC", VA = "0x136D4FC")]
		[IteratorStateMachine(typeof(<RotationX>d__11))]
		private IEnumerator RotationX()
		{
			return null;
		}

		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x136D5E8", Offset = "0x136D5E8", VA = "0x136D5E8")]
		public One_Line_Wheels_Controller()
		{
		}
	}
	[Token(Token = "0x200023C")]
	public class Radio : VRTK_InteractableObject
	{
		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x136DEE0", Offset = "0x136DEE0", VA = "0x136DEE0", Slot = "66")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x136DEE8", Offset = "0x136DEE8", VA = "0x136DEE8")]
		public Radio()
		{
		}
	}
	[Token(Token = "0x200023D")]
	public class RotatorWithOneTypeOfWheels : VRTK_InteractableObject
	{
		[Token(Token = "0x200023E")]
		[CompilerGenerated]
		private sealed class <Rotation>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RotatorWithOneTypeOfWheels <>4__this;

			[Token(Token = "0x4000C4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject controller;

			[Token(Token = "0x4000C4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <t>5__2;

			[Token(Token = "0x4000C4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Quaternion <start>5__3;

			[Token(Token = "0x4000C4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Quaternion <final>5__4;

			[Token(Token = "0x17000162")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B5B")]
				[Address(RVA = "0x136E49C", Offset = "0x136E49C", VA = "0x136E49C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000163")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B5D")]
				[Address(RVA = "0x136E4E4", Offset = "0x136E4E4", VA = "0x136E4E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B58")]
			[Address(RVA = "0x136E134", Offset = "0x136E134", VA = "0x136E134")]
			[DebuggerHidden]
			public <Rotation>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000B59")]
			[Address(RVA = "0x136E164", Offset = "0x136E164", VA = "0x136E164", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B5A")]
			[Address(RVA = "0x136E168", Offset = "0x136E168", VA = "0x136E168", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B5C")]
			[Address(RVA = "0x136E4A4", Offset = "0x136E4A4", VA = "0x136E4A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[SerializeField]
		private One_Line_Wheels_Controller one_line_wheels_Controller;

		[Token(Token = "0x4000C3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public GameObject mesh;

		[Token(Token = "0x4000C40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public Vector3 grab_rot;

		[Token(Token = "0x4000C41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		public Vector3 neededMoveWhenGrab;

		[Token(Token = "0x4000C42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float actual_rotation;

		[Token(Token = "0x4000C43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector3 start_rotation;

		[Token(Token = "0x4000C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Vector3[] wheels_actual_rotation;

		[Token(Token = "0x4000C45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 previous_position;

		[Token(Token = "0x4000C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 actual_position;

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x136DEF0", Offset = "0x136DEF0", VA = "0x136DEF0", Slot = "30")]
		public override void StartUsing(VRTK_InteractUse currentUsingObject)
		{
		}

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x136DEF8", Offset = "0x136DEF8", VA = "0x136DEF8", Slot = "67")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x136DF60", Offset = "0x136DF60", VA = "0x136DF60", Slot = "27")]
		public override void Grabbed(VRTK_InteractGrab currentGrabbingObject)
		{
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x136E078", Offset = "0x136E078", VA = "0x136E078", Slot = "29")]
		public override void Ungrabbed(VRTK_InteractGrab previousGrabbingObject)
		{
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x136DFE8", Offset = "0x136DFE8", VA = "0x136DFE8")]
		[IteratorStateMachine(typeof(<Rotation>d__13))]
		private IEnumerator Rotation(GameObject controller)
		{
			return null;
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x136E15C", Offset = "0x136E15C", VA = "0x136E15C")]
		public RotatorWithOneTypeOfWheels()
		{
		}
	}
	[Token(Token = "0x200023F")]
	public class Sink : VRTK_InteractableObject
	{
		[Token(Token = "0x2000240")]
		[CompilerGenerated]
		private sealed class <RunningWater>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Sink <>4__this;

			[Token(Token = "0x17000164")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B65")]
				[Address(RVA = "0x136E710", Offset = "0x136E710", VA = "0x136E710", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000165")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B67")]
				[Address(RVA = "0x136E758", Offset = "0x136E758", VA = "0x136E758", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B62")]
			[Address(RVA = "0x136E5A8", Offset = "0x136E5A8", VA = "0x136E5A8")]
			[DebuggerHidden]
			public <RunningWater>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000B63")]
			[Address(RVA = "0x136E5D8", Offset = "0x136E5D8", VA = "0x136E5D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x136E5DC", Offset = "0x136E5DC", VA = "0x136E5DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B66")]
			[Address(RVA = "0x136E718", Offset = "0x136E718", VA = "0x136E718", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public ParticleSystem water;

		[Token(Token = "0x4000C4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private float rotation;

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x136E4EC", Offset = "0x136E4EC", VA = "0x136E4EC", Slot = "27")]
		public override void Grabbed(VRTK_InteractGrab currentGrabbingObject)
		{
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x136E5A0", Offset = "0x136E5A0", VA = "0x136E5A0", Slot = "29")]
		public override void Ungrabbed(VRTK_InteractGrab previousGrabbingObject)
		{
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x136E52C", Offset = "0x136E52C", VA = "0x136E52C")]
		[IteratorStateMachine(typeof(<RunningWater>d__4))]
		private IEnumerator RunningWater()
		{
			return null;
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x136E5D0", Offset = "0x136E5D0", VA = "0x136E5D0")]
		public Sink()
		{
		}
	}
	[Token(Token = "0x2000241")]
	public class Spray_gun : VRTK_InteractableObject
	{
		[Token(Token = "0x4000C53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public ParticleSystem spray;

		[Token(Token = "0x4000C54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public GameObject gun_trigger;

		[Token(Token = "0x4000C55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public Vector3 push_rot;

		[Token(Token = "0x4000C56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 start_rot;

		[Token(Token = "0x4000C57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Vector3 push;

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x136E760", Offset = "0x136E760", VA = "0x136E760", Slot = "66")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x136E824", Offset = "0x136E824", VA = "0x136E824", Slot = "30")]
		public override void StartUsing(VRTK_InteractUse currentUsingObject)
		{
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x136E960", Offset = "0x136E960", VA = "0x136E960", Slot = "31")]
		public override void StopUsing([Optional] VRTK_InteractUse previousUsingObject, bool resetUsingObjectState = true)
		{
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x136E8D4", Offset = "0x136E8D4", VA = "0x136E8D4")]
		private void SetTriggerRotation()
		{
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x136EA1C", Offset = "0x136EA1C", VA = "0x136EA1C")]
		public Spray_gun()
		{
		}
	}
	[Token(Token = "0x2000242")]
	public class Water : MonoBehaviour, IButton
	{
		[Token(Token = "0x4000C58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParticleSystem water;

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x136EA24", Offset = "0x136EA24", VA = "0x136EA24")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x136EA58", Offset = "0x136EA58", VA = "0x136EA58", Slot = "4")]
		public void ButtonStartUsing(GameObject buttonObject)
		{
		}

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x136EA78", Offset = "0x136EA78", VA = "0x136EA78", Slot = "5")]
		public void ButtonEndUsing(GameObject buttonObject)
		{
		}

		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x136EA98", Offset = "0x136EA98", VA = "0x136EA98")]
		public Water()
		{
		}
	}
	[Token(Token = "0x2000243")]
	public interface IInteractableCarrier
	{
		[Token(Token = "0x6000B71")]
		void PlaceInteractable(Transform transform, VRTK_InteractableObject io);

		[Token(Token = "0x6000B72")]
		void RemoveInteractable(VRTK_InteractableObject io);
	}
}
namespace VRTK.Examples
{
	[Token(Token = "0x2000244")]
	public class Polisher : VRTK_InteractableObject
	{
		[Token(Token = "0x2000245")]
		[CompilerGenerated]
		private sealed class <SoundRoutine>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Polisher <>4__this;

			[Token(Token = "0x4000C68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float time;

			[Token(Token = "0x17000166")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B7F")]
				[Address(RVA = "0x136F3F0", Offset = "0x136F3F0", VA = "0x136F3F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000167")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B81")]
				[Address(RVA = "0x136F438", Offset = "0x136F438", VA = "0x136F438", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B7C")]
			[Address(RVA = "0x136F1F0", Offset = "0x136F1F0", VA = "0x136F1F0")]
			[DebuggerHidden]
			public <SoundRoutine>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000B7D")]
			[Address(RVA = "0x136F220", Offset = "0x136F220", VA = "0x136F220", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B7E")]
			[Address(RVA = "0x136F224", Offset = "0x136F224", VA = "0x136F224", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B80")]
			[Address(RVA = "0x136F3F8", Offset = "0x136F3F8", VA = "0x136F3F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public GameObject cutting_disk;

		[Token(Token = "0x4000C5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public GameObject trigger;

		[Token(Token = "0x4000C5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private bool still_using;

		[Token(Token = "0x4000C5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private Vector3 start_pos;

		[Token(Token = "0x4000C5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private Vector3 push_pos;

		[Token(Token = "0x4000C5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector3 push;

		[Token(Token = "0x4000C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private VRTK_ControllerReference controllerReference;

		[Token(Token = "0x4000C60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private AudioSource audioSource;

		[Token(Token = "0x4000C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private List<AudioClip> audioClips;

		[Token(Token = "0x4000C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private GameObject dust;

		[Token(Token = "0x4000C63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private ParticleSystem particle;

		[Token(Token = "0x4000C64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private bool startDust;

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x136EAA0", Offset = "0x136EAA0", VA = "0x136EAA0", Slot = "27")]
		public override void Grabbed([Optional] VRTK_InteractGrab currentGrabbingObject)
		{
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x136EB38", Offset = "0x136EB38", VA = "0x136EB38", Slot = "30")]
		public override void StartUsing(VRTK_InteractUse currentUsingObject)
		{
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x136EE8C", Offset = "0x136EE8C", VA = "0x136EE8C", Slot = "31")]
		public override void StopUsing([Optional] VRTK_InteractUse previousUsingObject, bool resetUsingObjectState = true)
		{
		}

		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x136F07C", Offset = "0x136F07C", VA = "0x136F07C")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x136F0B0", Offset = "0x136F0B0", VA = "0x136F0B0")]
		private void OnCollisionExit(Collision other)
		{
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x136F134", Offset = "0x136F134", VA = "0x136F134", Slot = "67")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x136ED7C", Offset = "0x136ED7C", VA = "0x136ED7C")]
		private void SetTriggerPosition()
		{
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x136EE08", Offset = "0x136EE08", VA = "0x136EE08")]
		[IteratorStateMachine(typeof(<SoundRoutine>d__19))]
		private IEnumerator SoundRoutine(float time)
		{
			return null;
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x136F218", Offset = "0x136F218", VA = "0x136F218")]
		public Polisher()
		{
		}
	}
	[Token(Token = "0x2000246")]
	public class Polisher2 : VRTK_InteractableObject
	{
		[Token(Token = "0x2000247")]
		[CompilerGenerated]
		private sealed class <Using>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Polisher2 <>4__this;

			[Token(Token = "0x17000168")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B8F")]
				[Address(RVA = "0x136FD5C", Offset = "0x136FD5C", VA = "0x136FD5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000169")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B91")]
				[Address(RVA = "0x136FDA4", Offset = "0x136FDA4", VA = "0x136FDA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B8C")]
			[Address(RVA = "0x136FC18", Offset = "0x136FC18", VA = "0x136FC18")]
			[DebuggerHidden]
			public <Using>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x6000B8D")]
			[Address(RVA = "0x136FC78", Offset = "0x136FC78", VA = "0x136FC78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B8E")]
			[Address(RVA = "0x136FC7C", Offset = "0x136FC7C", VA = "0x136FC7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B90")]
			[Address(RVA = "0x136FD64", Offset = "0x136FD64", VA = "0x136FD64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000248")]
		[CompilerGenerated]
		private sealed class <SoundRoutine>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Polisher2 <>4__this;

			[Token(Token = "0x4000C7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float time;

			[Token(Token = "0x1700016A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B95")]
				[Address(RVA = "0x136FF7C", Offset = "0x136FF7C", VA = "0x136FF7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700016B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B97")]
				[Address(RVA = "0x136FFC4", Offset = "0x136FFC4", VA = "0x136FFC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B92")]
			[Address(RVA = "0x136FC40", Offset = "0x136FC40", VA = "0x136FC40")]
			[DebuggerHidden]
			public <SoundRoutine>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000B93")]
			[Address(RVA = "0x136FDAC", Offset = "0x136FDAC", VA = "0x136FDAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B94")]
			[Address(RVA = "0x136FDB0", Offset = "0x136FDB0", VA = "0x136FDB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B96")]
			[Address(RVA = "0x136FF84", Offset = "0x136FF84", VA = "0x136FF84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public GameObject cutting_disk;

		[Token(Token = "0x4000C6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public GameObject trigger;

		[Token(Token = "0x4000C6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private bool still_using;

		[Token(Token = "0x4000C6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private Vector3 start_rot;

		[Token(Token = "0x4000C6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private Vector3 push_rot;

		[Token(Token = "0x4000C6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector3 push;

		[Token(Token = "0x4000C6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private VRTK_ControllerReference controllerReference;

		[Token(Token = "0x4000C70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private float pulseStrength;

		[Token(Token = "0x4000C71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private AudioSource audioSource;

		[Token(Token = "0x4000C72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private List<AudioClip> audioClips;

		[Token(Token = "0x4000C73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private GameObject dust;

		[Token(Token = "0x4000C74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private ParticleSystem particle;

		[Token(Token = "0x4000C75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private bool startDust;

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x136F440", Offset = "0x136F440", VA = "0x136F440", Slot = "27")]
		public override void Grabbed([Optional] VRTK_InteractGrab currentGrabbingObject)
		{
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x136F4D8", Offset = "0x136F4D8", VA = "0x136F4D8", Slot = "30")]
		public override void StartUsing(VRTK_InteractUse currentUsingObject)
		{
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x136F8B8", Offset = "0x136F8B8", VA = "0x136F8B8", Slot = "31")]
		public override void StopUsing([Optional] VRTK_InteractUse previousUsingObject, bool resetUsingObjectState = true)
		{
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x136FAA8", Offset = "0x136FAA8", VA = "0x136FAA8")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x136FADC", Offset = "0x136FADC", VA = "0x136FADC")]
		private void OnCollisionExit(Collision other)
		{
		}

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x136FB60", Offset = "0x136FB60", VA = "0x136FB60", Slot = "67")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x136F734", Offset = "0x136F734", VA = "0x136F734")]
		private void SetTriggerRotation()
		{
		}

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x136F7C0", Offset = "0x136F7C0", VA = "0x136F7C0")]
		[IteratorStateMachine(typeof(<Using>d__20))]
		private IEnumerator Using()
		{
			return null;
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x136F834", Offset = "0x136F834", VA = "0x136F834")]
		[IteratorStateMachine(typeof(<SoundRoutine>d__21))]
		private IEnumerator SoundRoutine(float time)
		{
			return null;
		}

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x136FC68", Offset = "0x136FC68", VA = "0x136FC68")]
		public Polisher2()
		{
		}
	}
}
namespace VRTK.Highlighters
{
	[Token(Token = "0x2000249")]
	public class CMS_Outline : VRTK_BaseHighlighter
	{
		[Token(Token = "0x4000C7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Highlighter CMS_highlighter;

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x136FFCC", Offset = "0x136FFCC", VA = "0x136FFCC", Slot = "4")]
		public override void Initialise([Optional] Color? color, [Optional] GameObject affectObject, [Optional] Dictionary<string, object> options)
		{
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x136FFFC", Offset = "0x136FFFC", VA = "0x136FFFC", Slot = "5")]
		public override void ResetHighlighter()
		{
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x1370000", Offset = "0x1370000", VA = "0x1370000", Slot = "6")]
		public override void Highlight(Color? color, float duration = 0f)
		{
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x137001C", Offset = "0x137001C", VA = "0x137001C", Slot = "7")]
		public override void Unhighlight([Optional] Color? color, float duration = 0f)
		{
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x137009C", Offset = "0x137009C", VA = "0x137009C", Slot = "11")]
		protected virtual void DeleteExistingHighlightModels()
		{
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x13700A0", Offset = "0x13700A0", VA = "0x13700A0")]
		public CMS_Outline()
		{
		}
	}
}
