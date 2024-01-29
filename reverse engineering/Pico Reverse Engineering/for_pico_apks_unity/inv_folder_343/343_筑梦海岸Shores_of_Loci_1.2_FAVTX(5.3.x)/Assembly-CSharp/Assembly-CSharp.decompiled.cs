using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Dreamteck.Splines;
using Il2CppDummyDll;
using Loci;
using Loci.Configs;
using Loci.Effects;
using Loci.Input;
using Loci.Popups;
using Loci.Prototyping;
using Loci.Snapping;
using Loci.Util;
using MikeVR.Source.Util;
using MikeVR.Water;
using Pathfinding;
using Rendnarok.Water;
using Shapes;
using TMPro;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Profiling;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.XR;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[ExecuteInEditMode]
[RequireComponent(typeof(ParticleSystem))]
public class FireflyConfig : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem _particleSystem;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float NumParticles;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector2 Size;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _numParticles;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector2 _size;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xB79CBC", Offset = "0xB79CBC", VA = "0xB79CBC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xB79E14", Offset = "0xB79E14", VA = "0xB79E14")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xB79E6C", Offset = "0xB79E6C", VA = "0xB79E6C")]
	private void UpdateEmission()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xB79F28", Offset = "0xB79F28", VA = "0xB79F28")]
	private void UpdateSize()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xB79F94", Offset = "0xB79F94", VA = "0xB79F94")]
	public FireflyConfig()
	{
	}
}
[Token(Token = "0x2000003")]
public class LocimonSnap : MonoBehaviour
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform _tr;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Camera _camera;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int _width;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int _height;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string _path;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _menuActive;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SnapChapterRunner Runner;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float MovementSpeed;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float RotationSpeed;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xB79FA4", Offset = "0xB79FA4", VA = "0xB79FA4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xB7A03C", Offset = "0xB7A03C", VA = "0xB7A03C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xB7A07C", Offset = "0xB7A07C", VA = "0xB7A07C")]
	private void Translation()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xB7A2F4", Offset = "0xB7A2F4", VA = "0xB7A2F4")]
	private void Rotation()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xB7A42C", Offset = "0xB7A42C", VA = "0xB7A42C")]
	private void Capture()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xB7A45C", Offset = "0xB7A45C", VA = "0xB7A45C")]
	private void CaptureImage(int width, int height)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xB7A6B8", Offset = "0xB7A6B8", VA = "0xB7A6B8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xB7A9B8", Offset = "0xB7A9B8", VA = "0xB7A9B8")]
	private void DrawArea(Rect rect, string header, Action draw)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xB7AB64", Offset = "0xB7AB64", VA = "0xB7AB64")]
	public LocimonSnap()
	{
	}
}
[Token(Token = "0x2000005")]
public class SnapChapter : MonoBehaviour
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material Skybox;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xB7B910", Offset = "0xB7B910", VA = "0xB7B910")]
	public SnapChapter()
	{
	}
}
[Token(Token = "0x2000006")]
public class SnapChapterRunner : InjectableMonobehavior
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Inject]
	private Loci.Environment _environment;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string _scenePath;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string _sceneName;

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xB7ADA8", Offset = "0xB7ADA8", VA = "0xB7ADA8")]
	public void LoadChapter(ChapterIndex index)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xB7B918", Offset = "0xB7B918", VA = "0xB7B918")]
	private void UnloadCurrent()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xB7B9B4", Offset = "0xB7B9B4", VA = "0xB7B9B4")]
	public SnapChapterRunner()
	{
	}
}
[Token(Token = "0x2000007")]
[DefaultExecutionOrder(-100)]
public class SnapMain : MonoBehaviour
{
	[Token(Token = "0x600001A")]
	[Address(RVA = "0xB7BAB4", Offset = "0xB7BAB4", VA = "0xB7BAB4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xB7BB3C", Offset = "0xB7BB3C", VA = "0xB7BB3C")]
	public SnapMain()
	{
	}
}
[Token(Token = "0x2000008")]
public class DevCamera : MonoBehaviour
{
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Camera _camera;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RenderTexture _renderTexture;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Material _debugMat;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xB7BB44", Offset = "0xB7BB44", VA = "0xB7BB44")]
	private void Start()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xB7BC28", Offset = "0xB7BC28", VA = "0xB7BC28")]
	private void OnPreCull()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xB7BC2C", Offset = "0xB7BC2C", VA = "0xB7BC2C")]
	public DevCamera()
	{
	}
}
[Token(Token = "0x200000A")]
public class InputManager
{
	[Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class <Update>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InputManager <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0xB7C7BC", Offset = "0xB7C7BC", VA = "0xB7C7BC", Slot = "4")]
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
			[Address(RVA = "0xB7C804", Offset = "0xB7C804", VA = "0xB7C804", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xB7C568", Offset = "0xB7C568", VA = "0xB7C568")]
		[DebuggerHidden]
		public <Update>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xB7C590", Offset = "0xB7C590", VA = "0xB7C590", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xB7C594", Offset = "0xB7C594", VA = "0xB7C594", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xB7C7C4", Offset = "0xB7C7C4", VA = "0xB7C7C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private IInputHandler _handler;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly InputSource[] Controllers;

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xB7BEE4", Offset = "0xB7BEE4", VA = "0xB7BEE4")]
	public InputManager(PlatformRoot platformRoot, Bootstrapper bootstrapper)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xB7C110", Offset = "0xB7C110", VA = "0xB7C110")]
	public void RegisterHandler(IInputHandler handler)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xB7C2CC", Offset = "0xB7C2CC", VA = "0xB7C2CC")]
	public void RemoveHandler(IInputHandler handler)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xB7C380", Offset = "0xB7C380", VA = "0xB7C380")]
	private void ControllerTriggerActivated(InputSource inputSource, bool active)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xB7C474", Offset = "0xB7C474", VA = "0xB7C474")]
	private void ControllerGrabActivated(InputSource inputSource, bool active)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xB7C09C", Offset = "0xB7C09C", VA = "0xB7C09C")]
	[IteratorStateMachine(typeof(<Update>d__7))]
	private IEnumerator Update()
	{
		return null;
	}
}
[Token(Token = "0x200000C")]
public class Performance : MonoBehaviour
{
	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Performance _instance;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ProfilerRecorder _cpuRecorder;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ProfilerRecorder _drawCallRecorder;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ProfilerRecorder _setPassRecorder;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ProfilerRecorder _vertRecorder;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Recorder _stdRender;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Recorder _srpBatcher;

	[Token(Token = "0x17000005")]
	public static float CPUTime
	{
		[Token(Token = "0x6000032")]
		[Address(RVA = "0xB7C80C", Offset = "0xB7C80C", VA = "0xB7C80C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000006")]
	public static float DrawCalls
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0xB7C86C", Offset = "0xB7C86C", VA = "0xB7C86C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000007")]
	public static float VertCount
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0xB7C8CC", Offset = "0xB7C8CC", VA = "0xB7C8CC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xB7C92C", Offset = "0xB7C92C", VA = "0xB7C92C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xB7CBDC", Offset = "0xB7CBDC", VA = "0xB7CBDC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xB7CC18", Offset = "0xB7CC18", VA = "0xB7CC18")]
	private void Update()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xB7CB0C", Offset = "0xB7CB0C", VA = "0xB7CB0C")]
	private Recorder GetRecorder(string primary, string secondary = "")
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xB7CD3C", Offset = "0xB7CD3C", VA = "0xB7CD3C")]
	public Performance()
	{
	}
}
[Token(Token = "0x200000D")]
public class WaterController : MonoBehaviour
{
	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Material[] Materials;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material RipplesMaterial;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private MeshRenderer RipplesRenderer;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ParticleSystem DropParticles;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationCurve ParticlesCurve;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool bStartTransition;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float HeightOffset;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float ReductorMultiplier;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float InitialHeight;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Vector2 ReductorRange;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float InitialEmission;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xB7CD44", Offset = "0xB7CD44", VA = "0xB7CD44")]
	private void Start()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xB7CE88", Offset = "0xB7CE88", VA = "0xB7CE88")]
	private void Update()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xB7D0E4", Offset = "0xB7D0E4", VA = "0xB7D0E4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xB7D184", Offset = "0xB7D184", VA = "0xB7D184")]
	public WaterController()
	{
	}
}
[Token(Token = "0x200000E")]
public class DisplayVR : MonoBehaviour
{
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Camera _camera;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera Camera;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material Material;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float left;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float right;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float top;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float bottom;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RenderTexture DebugTexture;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xB7D198", Offset = "0xB7D198", VA = "0xB7D198")]
	private void Start()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xB7D598", Offset = "0xB7D598", VA = "0xB7D598")]
	private void OutputFrustum(Matrix4x4 m)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xB7D7BC", Offset = "0xB7D7BC", VA = "0xB7D7BC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xB7D858", Offset = "0xB7D858", VA = "0xB7D858")]
	public DisplayVR()
	{
	}
}
[Token(Token = "0x2000011")]
public class ForceMatrices : MonoBehaviour
{
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera _camera;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Renderer _renderer;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material _material;

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xB7DDC4", Offset = "0xB7DDC4", VA = "0xB7DDC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xB7DE44", Offset = "0xB7DE44", VA = "0xB7DE44")]
	private void Update()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xB7DFF8", Offset = "0xB7DFF8", VA = "0xB7DFF8")]
	public ForceMatrices()
	{
	}
}
[Token(Token = "0x2000012")]
public class ReflectionGrab : ScriptableRendererFeature
{
	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0.5f, 1f)]
	public float RenderScale;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private UnderwaterPass _underwaterPass;

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xB7E000", Offset = "0xB7E000", VA = "0xB7E000", Slot = "5")]
	public override void Create()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xB7E070", Offset = "0xB7E070", VA = "0xB7E070", Slot = "7")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xB7E0A4", Offset = "0xB7E0A4", VA = "0xB7E0A4")]
	public ReflectionGrab()
	{
	}
}
[Token(Token = "0x2000013")]
public class ReflectionMapGen : MonoBehaviour
{
	[Token(Token = "0x2000014")]
	public enum ReflectionResolution
	{
		[Token(Token = "0x4000047")]
		Lowest = 0x80,
		[Token(Token = "0x4000048")]
		Low = 0x100,
		[Token(Token = "0x4000049")]
		Mid = 0x200,
		[Token(Token = "0x400004A")]
		High = 0x400,
		[Token(Token = "0x400004B")]
		Higher = 0x800,
		[Token(Token = "0x400004C")]
		Ultra = 0x1000
	}

	[Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class <Render>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ReflectionMapGen <>4__this;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Camera cam;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3[] <Directions>5__2;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RenderTexture <capture>5__3;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture <cubemap>5__4;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture <equirect>5__5;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int <i>5__6;

		[Token(Token = "0x1700000A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xB7EB7C", Offset = "0xB7EB7C", VA = "0xB7EB7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xB7EBC4", Offset = "0xB7EBC4", VA = "0xB7EBC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xB7E2CC", Offset = "0xB7E2CC", VA = "0xB7E2CC")]
		[DebuggerHidden]
		public <Render>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xB7E354", Offset = "0xB7E354", VA = "0xB7E354", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xB7E358", Offset = "0xB7E358", VA = "0xB7E358", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xB7EB84", Offset = "0xB7EB84", VA = "0xB7EB84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ReflectionResolution Resolution;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string OutputFolder;

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xB7E0B4", Offset = "0xB7E0B4", VA = "0xB7E0B4")]
	[ContextMenu("Render")]
	public void RenderCubemap()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xB7E23C", Offset = "0xB7E23C", VA = "0xB7E23C")]
	[IteratorStateMachine(typeof(<Render>d__4))]
	private IEnumerator Render(Camera cam)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xB7E2F4", Offset = "0xB7E2F4", VA = "0xB7E2F4")]
	public ReflectionMapGen()
	{
	}
}
[Token(Token = "0x2000016")]
[ExecuteAlways]
public class WaterTemp : MonoBehaviour
{
	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int WaterLevel;

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xB7EBCC", Offset = "0xB7EBCC", VA = "0xB7EBCC")]
	public WaterTemp()
	{
	}
}
[Token(Token = "0x2000017")]
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	[Token(Token = "0x1700000C")]
	public static bool Initialized
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0xB7EC3C", Offset = "0xB7EC3C", VA = "0xB7EC3C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xB7EC44", Offset = "0xB7EC44", VA = "0xB7EC44")]
	public SteamManager()
	{
	}
}
namespace Rendnarok.Water
{
	[Token(Token = "0x2000018")]
	public class WaterLink : MonoBehaviour
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaterReflectable Reflectable;

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xB7EC4C", Offset = "0xB7EC4C", VA = "0xB7EC4C")]
		public WaterLink()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class WaterReflectable : MonoBehaviour
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly List<WaterReflectable> AllActive;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _tr;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _targetTr;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _activeRef;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _posRef;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _rotRef;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _sclRef;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _registered;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xB7EC54", Offset = "0xB7EC54", VA = "0xB7EC54")]
		public void Initialize(Transform tr)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xB7EDA4", Offset = "0xB7EDA4", VA = "0xB7EDA4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xB7EE3C", Offset = "0xB7EE3C", VA = "0xB7EE3C")]
		public void UpdateTransform(Plane reflPlane, bool forceUpdate)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xB7F148", Offset = "0xB7F148", VA = "0xB7F148")]
		private bool ChangeNeeded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xB7EDB4", Offset = "0xB7EDB4", VA = "0xB7EDB4")]
		private void RemoveFromActive()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xB7F2F4", Offset = "0xB7F2F4", VA = "0xB7F2F4")]
		public void ForceHide()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xB7F318", Offset = "0xB7F318", VA = "0xB7F318")]
		public void ForceShow()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xB7F33C", Offset = "0xB7F33C", VA = "0xB7F33C")]
		public WaterReflectable()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[ExecuteInEditMode]
	public class WaterSurface : MonoBehaviour
	{
		[Token(Token = "0x4000060")]
		private const int UNDERWATER_LAYER = 4;

		[Token(Token = "0x4000061")]
		private const int DNR_LAYER = 7;

		[Token(Token = "0x4000062")]
		private const int WATER_SURFACE = 3;

		[Token(Token = "0x4000063")]
		private const int NO_REFLECT = 152;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int _WaterLevel;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<Material, Material> SubmergedMaterials;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Camera Camera;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<Camera, Camera> _cameraMap;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Waterline;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool _waterlineDirty;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Camera _camera;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static GameObject _reflectablesContainer;

		[Token(Token = "0x1700000D")]
		public Plane ReflectionPlane
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0xB7F3DC", Offset = "0xB7F3DC", VA = "0xB7F3DC")]
			[CompilerGenerated]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xB7F3E8", Offset = "0xB7F3E8", VA = "0xB7F3E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xB7F3F4", Offset = "0xB7F3F4", VA = "0xB7F3F4")]
		public static void CreateReflectables(params Renderer[] renderers)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xB7FA98", Offset = "0xB7FA98", VA = "0xB7FA98")]
		public static Material GetReflectedMaterial(Material source)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xB7FE88", Offset = "0xB7FE88", VA = "0xB7FE88")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xB80274", Offset = "0xB80274", VA = "0xB80274")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xB80318", Offset = "0xB80318", VA = "0xB80318")]
		private void Update()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xB80158", Offset = "0xB80158", VA = "0xB80158")]
		private void UpdateWaterline(float waterline)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xB803C4", Offset = "0xB803C4", VA = "0xB803C4")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xB804C4", Offset = "0xB804C4", VA = "0xB804C4")]
		private void Render_Start(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xB7F67C", Offset = "0xB7F67C", VA = "0xB7F67C")]
		private static void CreateReflectionObject(GameObject original)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xB80888", Offset = "0xB80888", VA = "0xB80888")]
		private static Material[] CloneMaterials(Material[] materials)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xB7FB88", Offset = "0xB7FB88", VA = "0xB7FB88")]
		private static Material CreateMaterial(Material mat)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xB80A48", Offset = "0xB80A48", VA = "0xB80A48")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xB80A6C", Offset = "0xB80A6C", VA = "0xB80A6C")]
		public WaterSurface()
		{
		}
	}
}
namespace Rendnarok.Water.Demo
{
	[Token(Token = "0x200001B")]
	public class ForceFrustum : MonoBehaviour
	{
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float left;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float right;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float top;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float bottom;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Camera _camera;

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xB80BB8", Offset = "0xB80BB8", VA = "0xB80BB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xB80C10", Offset = "0xB80C10", VA = "0xB80C10")]
		public void Update()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xB80C94", Offset = "0xB80C94", VA = "0xB80C94")]
		public ForceFrustum()
		{
		}
	}
}
namespace Rendnarok.Util
{
	[Token(Token = "0x200001C")]
	public static class ComponentExtensions
	{
		[Token(Token = "0x600007C")]
		public static T AddOrGetComponent<T>(this Component @this) where T : Component
		{
			return null;
		}
	}
	[Token(Token = "0x200001D")]
	public static class RenderTextureExtensions
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0xB80CA8", Offset = "0xB80CA8", VA = "0xB80CA8")]
		public static void Log(this RenderTexture rt)
		{
		}
	}
}
namespace Loci
{
	[Token(Token = "0x200001E")]
	public class AchievementService
	{
		[Token(Token = "0x200001F")]
		public enum Achievement
		{
			[Token(Token = "0x4000075")]
			TUTORIAL_BEGIN,
			[Token(Token = "0x4000076")]
			TUTORIAL_COMPLETE,
			[Token(Token = "0x4000077")]
			CH1_SNAP,
			[Token(Token = "0x4000078")]
			CH1_COMPLETE,
			[Token(Token = "0x4000079")]
			CH2_SNAP,
			[Token(Token = "0x400007A")]
			CH2_COMPLETE,
			[Token(Token = "0x400007B")]
			CH3_SNAP,
			[Token(Token = "0x400007C")]
			CH3_COMPLETE,
			[Token(Token = "0x400007D")]
			CH4_SNAP,
			[Token(Token = "0x400007E")]
			CH4_COMPLETE,
			[Token(Token = "0x400007F")]
			GAME_COMPLETE,
			[Token(Token = "0x4000080")]
			GAME_NO_HINTS,
			[Token(Token = "0x4000081")]
			GAME_RESET,
			[Token(Token = "0x4000082")]
			GAME_IDLED,
			[Token(Token = "0x4000083")]
			GAME_ANGER,
			[Token(Token = "0x4000084")]
			GIANT_PLEASED,
			[Token(Token = "0x4000085")]
			CH5_SNAP,
			[Token(Token = "0x4000086")]
			CH5_COMPLETE
		}

		[Token(Token = "0x4000072")]
		public const int TOTAL_ACHIEVEMENTS = 18;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly SaveService _saveService;

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xB8101C", Offset = "0xB8101C", VA = "0xB8101C")]
		public AchievementService(SaveService saveService)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xB8104C", Offset = "0xB8104C", VA = "0xB8104C")]
		public void Unlock(Achievement achievement)
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class AnimationEventHandler : MonoBehaviour
	{
		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Giant _giant;

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xB8114C", Offset = "0xB8114C", VA = "0xB8114C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xB811A4", Offset = "0xB811A4", VA = "0xB811A4")]
		private void AnimEvent(string evtName)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xB81234", Offset = "0xB81234", VA = "0xB81234")]
		public AnimationEventHandler()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class Audio : MonoBehaviour
	{
		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Common Tracks")]
		private AudioTrack _voidTrack;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioTrack _puzzleComplete;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioTrack _chapterIntro;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Header("One Shots")]
		[SerializeField]
		private float _grabAmplitudeModifier;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _snapAmplitudeModifier;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _tempAmplitudeModifier;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AudioClip[] _grabSounds;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioClip _grabHit;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioClip[] _puzzleClicksWithReward;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _puzzleClickNoReward;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AudioClip _debug;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AudioClip _chapterUnlock;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AudioClip _tutorialStepSuccess;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Header("Impacts")]
		[SerializeField]
		private AudioClip[] _geodeImpacts;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AudioClip[] _stoneImpacts;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioClip[] _dirtImpacts;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip[] _woodImpacts;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Header("Platform")]
		private AudioClip _platformOpen;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip _platformClose;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly List<AudioInstance> _activeAudio;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly Dictionary<TrackType, AudioInstance> _currentTracks;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioTrack _queuedScore;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool _introPlaying;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int _puzzleClickIndex;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _lastImpactPlaytime;

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xB8123C", Offset = "0xB8123C", VA = "0xB8123C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xB81318", Offset = "0xB81318", VA = "0xB81318")]
		public void PauseAllAudio()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xB8145C", Offset = "0xB8145C", VA = "0xB8145C")]
		public void ResumeAllAudio()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xB8159C", Offset = "0xB8159C", VA = "0xB8159C")]
		public void StopAllAudio(bool force = false)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xB819EC", Offset = "0xB819EC", VA = "0xB819EC")]
		public void PuzzleComplete()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xB81DC0", Offset = "0xB81DC0", VA = "0xB81DC0")]
		public void ChapterIntro()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xB81E6C", Offset = "0xB81E6C", VA = "0xB81E6C")]
		public void StartTrack(AudioTrack track)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xB81FB8", Offset = "0xB81FB8", VA = "0xB81FB8")]
		public void PuzzleClick(Vector3 worldPos)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xB820A4", Offset = "0xB820A4", VA = "0xB820A4")]
		public void PuzzleClick_NoReward(Vector3 worldPos)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xB8214C", Offset = "0xB8214C", VA = "0xB8214C")]
		public void GrabLaunch(Vector3 worldPos, float range)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xB822D8", Offset = "0xB822D8", VA = "0xB822D8")]
		public void GrabHit(Vector3 worldPos)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xB823CC", Offset = "0xB823CC", VA = "0xB823CC")]
		public void ChapterUnlock()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xB82448", Offset = "0xB82448", VA = "0xB82448")]
		public void TutorialStepSuccess(float volume = 0.5f)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xB824D4", Offset = "0xB824D4", VA = "0xB824D4")]
		public void Impact(ImpactType type, Vector3 position)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xB8275C", Offset = "0xB8275C", VA = "0xB8275C")]
		public void PlatformOpen()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xB82828", Offset = "0xB82828", VA = "0xB82828")]
		public void PlatformClose()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xB828F4", Offset = "0xB828F4", VA = "0xB828F4")]
		public void Debug(Vector3 worldPos)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xB81A98", Offset = "0xB81A98", VA = "0xB81A98")]
		private void StartDuck()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xB82AA8", Offset = "0xB82AA8", VA = "0xB82AA8")]
		private void EndDuck()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xB826B0", Offset = "0xB826B0", VA = "0xB826B0")]
		private AudioClip RandomClip(AudioClip[] bank)
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xB82D78", Offset = "0xB82D78", VA = "0xB82D78")]
		public void OnAudioStarted(AudioInstance instance)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xB82E28", Offset = "0xB82E28", VA = "0xB82E28")]
		public void OnAudioStopped(AudioInstance instance)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xB82E80", Offset = "0xB82E80", VA = "0xB82E80")]
		public Audio()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public enum TrackType
	{
		[Token(Token = "0x40000A4")]
		Ambiance,
		[Token(Token = "0x40000A5")]
		Score
	}
	[Serializable]
	[Token(Token = "0x2000024")]
	public class PlaySettings
	{
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TrackType Type;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float FadeInSec;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float FadeOutSec;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool Loop;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 StartPosition;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float InitialVolume;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xB82090", Offset = "0xB82090", VA = "0xB82090")]
		public PlaySettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000025")]
	public class AudioTrack
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioClip Clip;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlaySettings Settings;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xB830F0", Offset = "0xB830F0", VA = "0xB830F0")]
		public AudioTrack()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class AudioInstance
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Audio _audio;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly PlaySettings _settings;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly AudioSource _source;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _stopping;

		[Token(Token = "0x14000001")]
		public event Action StopStarted
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0xB81D24", Offset = "0xB81D24", VA = "0xB81D24")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0xB830F8", Offset = "0xB830F8", VA = "0xB830F8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action StopComplete
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0xB83194", Offset = "0xB83194", VA = "0xB83194")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0xB83230", Offset = "0xB83230", VA = "0xB83230")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xB832CC", Offset = "0xB832CC", VA = "0xB832CC")]
		private AudioInstance(Audio audio, AudioClip clip, PlaySettings settings, double scheduledTime = 0.0)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xB81C9C", Offset = "0xB81C9C", VA = "0xB81C9C")]
		public static AudioInstance Create(Audio audio, AudioClip clip, PlaySettings settings, double scheduledTime = 0.0)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xB81440", Offset = "0xB81440", VA = "0xB81440")]
		public void Pause()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xB81570", Offset = "0xB81570", VA = "0xB81570")]
		public void Resume()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xB81708", Offset = "0xB81708", VA = "0xB81708")]
		public void Stop(bool force = false)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xB829E0", Offset = "0xB829E0", VA = "0xB829E0")]
		public void DuckStart()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xB82CAC", Offset = "0xB82CAC", VA = "0xB82CAC")]
		public void DuckEnd()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xB83688", Offset = "0xB83688", VA = "0xB83688")]
		public void Unmute()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xB836C0", Offset = "0xB836C0", VA = "0xB836C0")]
		public void Mute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public class ChapterAudio
	{
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioTrack[] Tracks;

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xB83810", Offset = "0xB83810", VA = "0xB83810")]
		public ChapterAudio()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000028")]
	public class PuzzleAudio
	{
		[Serializable]
		[Token(Token = "0x2000029")]
		public struct AudioBatch
		{
			[Token(Token = "0x40000B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AudioClip[] Stems;
		}

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioBatch[] Batches;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xB83818", Offset = "0xB83818", VA = "0xB83818")]
		public PuzzleAudio()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public enum ChapterIndex
	{
		[Token(Token = "0x40000B8")]
		None = -50,
		[Token(Token = "0x40000B9")]
		Credits = -5,
		[Token(Token = "0x40000BA")]
		Intro = -1,
		[Token(Token = "0x40000BB")]
		Chapter1 = 1,
		[Token(Token = "0x40000BC")]
		Chapter2 = 2,
		[Token(Token = "0x40000BD")]
		Chapter3 = 3,
		[Token(Token = "0x40000BE")]
		Chapter4 = 4,
		[Token(Token = "0x40000BF")]
		Chapter5 = 5,
		[Token(Token = "0x40000C0")]
		MiniChapter2 = 102,
		[Token(Token = "0x40000C1")]
		MiniChapter3 = 103,
		[Token(Token = "0x40000C2")]
		MiniChapter4 = 104,
		[Token(Token = "0x40000C3")]
		MiniChapter5 = 105
	}
	[Token(Token = "0x200002B")]
	public class ChapterRunner
	{
		[Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class <ExitCurrentChapter>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ChapterRunner <>4__this;

			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool blackOut;

			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public ChapterIndex next;

			[Token(Token = "0x17000011")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000CE")]
				[Address(RVA = "0xB84EF4", Offset = "0xB84EF4", VA = "0xB84EF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000012")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000D0")]
				[Address(RVA = "0xB84F3C", Offset = "0xB84F3C", VA = "0xB84F3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xB83E04", Offset = "0xB83E04", VA = "0xB83E04")]
			[DebuggerHidden]
			public <ExitCurrentChapter>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xB84D24", Offset = "0xB84D24", VA = "0xB84D24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xB84D28", Offset = "0xB84D28", VA = "0xB84D28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xB84EFC", Offset = "0xB84EFC", VA = "0xB84EFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isDone;

			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xB84F44", Offset = "0xB84F44", VA = "0xB84F44")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x60000D2")]
			[Address(RVA = "0xB84F4C", Offset = "0xB84F4C", VA = "0xB84F4C")]
			internal void <UnloadCurrentChapter>b__0(AsyncOperation _)
			{
			}
		}

		[Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class <UnloadCurrentChapter>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ChapterRunner <>4__this;

			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass23_0 <>8__1;

			[Token(Token = "0x17000013")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000D6")]
				[Address(RVA = "0xB85244", Offset = "0xB85244", VA = "0xB85244", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000014")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000D8")]
				[Address(RVA = "0xB8528C", Offset = "0xB8528C", VA = "0xB8528C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D3")]
			[Address(RVA = "0xB83EA0", Offset = "0xB83EA0", VA = "0xB83EA0")]
			[DebuggerHidden]
			public <UnloadCurrentChapter>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xB84F58", Offset = "0xB84F58", VA = "0xB84F58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xB84F5C", Offset = "0xB84F5C", VA = "0xB84F5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xB8524C", Offset = "0xB8524C", VA = "0xB8524C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Bootstrapper _bootstrapper;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Audio _audio;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Environment _environment;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly SaveService _saveService;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly MaterialManager _materialManager;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly MainCamera _mainCamera;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly MessageBus _msgBus;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly HandheldGrabHandler _grabHandler;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly AchievementService _achievementService;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly NoticePopup _notice;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string _scenePath;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string _sceneName;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Chapter _chapter;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Action _stageCallback;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BaseTween _calmTween;

		[Token(Token = "0x1700000E")]
		public ChapterIndex Current
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0xB83820", Offset = "0xB83820", VA = "0xB83820")]
			[CompilerGenerated]
			get
			{
				return default(ChapterIndex);
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0xB83828", Offset = "0xB83828", VA = "0xB83828")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xB83830", Offset = "0xB83830", VA = "0xB83830")]
		public ChapterRunner(Bootstrapper bootstrapper, Audio audio, Environment environment, SaveService saveService, MaterialManager materialManager, MainCamera mainCamera, MessageBus msgBus, HandheldGrabHandler grabHandler, AchievementService achievementService, NoticePopup noticePopup)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xB83AD4", Offset = "0xB83AD4", VA = "0xB83AD4")]
		public void Restart()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xB83B70", Offset = "0xB83B70", VA = "0xB83B70")]
		public void LoadChapter(ChapterIndex index, bool blackOut = false)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xB83D74", Offset = "0xB83D74", VA = "0xB83D74")]
		[IteratorStateMachine(typeof(<ExitCurrentChapter>d__22))]
		private IEnumerator ExitCurrentChapter(ChapterIndex next, bool blackOut)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xB83E2C", Offset = "0xB83E2C", VA = "0xB83E2C")]
		[IteratorStateMachine(typeof(<UnloadCurrentChapter>d__23))]
		private IEnumerator UnloadCurrentChapter()
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xB83EC8", Offset = "0xB83EC8", VA = "0xB83EC8")]
		private void ConfigureCalmDelay()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class Chapter : InjectableMonobehavior
	{
		[Token(Token = "0x2000034")]
		protected enum State
		{
			[Token(Token = "0x4000105")]
			Unconfigured,
			[Token(Token = "0x4000106")]
			Intro,
			[Token(Token = "0x4000107")]
			Puzzling,
			[Token(Token = "0x4000108")]
			BetweenPuzzles,
			[Token(Token = "0x4000109")]
			Complete
		}

		[Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class <OutroChapter>d__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400010A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400010B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400010C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Chapter <>4__this;

			[Token(Token = "0x1700001A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000F5")]
				[Address(RVA = "0xB86EE4", Offset = "0xB86EE4", VA = "0xB86EE4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000F7")]
				[Address(RVA = "0xB86F2C", Offset = "0xB86F2C", VA = "0xB86F2C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000F2")]
			[Address(RVA = "0xB8665C", Offset = "0xB8665C", VA = "0xB8665C")]
			[DebuggerHidden]
			public <OutroChapter>d__39(int <>1__state)
			{
			}

			[Token(Token = "0x60000F3")]
			[Address(RVA = "0xB86E68", Offset = "0xB86E68", VA = "0xB86E68", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xB86E6C", Offset = "0xB86E6C", VA = "0xB86E6C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000F6")]
			[Address(RVA = "0xB86EEC", Offset = "0xB86EEC", VA = "0xB86EEC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class <SpawnPuzzle>d__44 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Chapter <>4__this;

			[Token(Token = "0x4000115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PuzzleManager puzzle;

			[Token(Token = "0x1700001E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000103")]
				[Address(RVA = "0xB87418", Offset = "0xB87418", VA = "0xB87418", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000105")]
				[Address(RVA = "0xB87460", Offset = "0xB87460", VA = "0xB87460", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000100")]
			[Address(RVA = "0xB86C78", Offset = "0xB86C78", VA = "0xB86C78")]
			[DebuggerHidden]
			public <SpawnPuzzle>d__44(int <>1__state)
			{
			}

			[Token(Token = "0x6000101")]
			[Address(RVA = "0xB87340", Offset = "0xB87340", VA = "0xB87340", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000102")]
			[Address(RVA = "0xB87344", Offset = "0xB87344", VA = "0xB87344", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000104")]
			[Address(RVA = "0xB87420", Offset = "0xB87420", VA = "0xB87420", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class <DeliverPuzzle>d__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000117")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000118")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuzzleManager puzzle;

			[Token(Token = "0x4000119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Chapter <>4__this;

			[Token(Token = "0x400011A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<PrefixedPuzzleChunk> <piecesToSpawn>5__2;

			[Token(Token = "0x17000020")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000109")]
				[Address(RVA = "0xB8785C", Offset = "0xB8785C", VA = "0xB8785C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000021")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600010B")]
				[Address(RVA = "0xB878A4", Offset = "0xB878A4", VA = "0xB878A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000106")]
			[Address(RVA = "0xB86D30", Offset = "0xB86D30", VA = "0xB86D30")]
			[DebuggerHidden]
			public <DeliverPuzzle>d__45(int <>1__state)
			{
			}

			[Token(Token = "0x6000107")]
			[Address(RVA = "0xB87468", Offset = "0xB87468", VA = "0xB87468", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000108")]
			[Address(RVA = "0xB8746C", Offset = "0xB8746C", VA = "0xB8746C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600010A")]
			[Address(RVA = "0xB87864", Offset = "0xB87864", VA = "0xB87864", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass46_0
		{
			[Token(Token = "0x400011B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Chapter <>4__this;

			[Token(Token = "0x400011C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform blanketTr;

			[Token(Token = "0x400011D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuzzleManager puzzle;

			[Token(Token = "0x600010C")]
			[Address(RVA = "0xB878AC", Offset = "0xB878AC", VA = "0xB878AC")]
			public <>c__DisplayClass46_0()
			{
			}

			[Token(Token = "0x600010D")]
			[Address(RVA = "0xB878B4", Offset = "0xB878B4", VA = "0xB878B4")]
			internal void <OutroPuzzle>b__0()
			{
			}

			[Token(Token = "0x600010E")]
			[Address(RVA = "0xB8790C", Offset = "0xB8790C", VA = "0xB8790C")]
			internal void <OutroPuzzle>b__1(Vector3 v)
			{
			}

			[Token(Token = "0x600010F")]
			[Address(RVA = "0xB87928", Offset = "0xB87928", VA = "0xB87928")]
			internal void <OutroPuzzle>b__2()
			{
			}
		}

		[Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class <OutroPuzzle>d__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400011E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400011F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000120")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Chapter <>4__this;

			[Token(Token = "0x4000121")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PuzzleManager puzzle;

			[Token(Token = "0x4000122")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass46_0 <>8__1;

			[Token(Token = "0x17000022")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000113")]
				[Address(RVA = "0xB88654", Offset = "0xB88654", VA = "0xB88654", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000023")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000115")]
				[Address(RVA = "0xB8869C", Offset = "0xB8869C", VA = "0xB8869C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000110")]
			[Address(RVA = "0xB86DE8", Offset = "0xB86DE8", VA = "0xB86DE8")]
			[DebuggerHidden]
			public <OutroPuzzle>d__46(int <>1__state)
			{
			}

			[Token(Token = "0x6000111")]
			[Address(RVA = "0xB879D4", Offset = "0xB879D4", VA = "0xB879D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000112")]
			[Address(RVA = "0xB879D8", Offset = "0xB879D8", VA = "0xB879D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000114")]
			[Address(RVA = "0xB8865C", Offset = "0xB8865C", VA = "0xB8865C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool _devSnap;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Inject]
		protected MaterialManager _materialManager;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Inject]
		protected ChapterConfig _config;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Inject]
		protected HandheldGrabHandler _grabHandler;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Inject]
		protected SaveService _saveService;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Inject]
		protected SymbolPlatform _symbolPlatform;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Inject]
		protected MessageBus _msgBus;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Inject]
		protected ChapterRunner _chapterRunner;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Inject]
		protected AchievementService _achievementService;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Config")]
		public ChapterIndex ChapterNumber;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public SphericalHarmonicsL2 AmbientProbe;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AnimationCurve VoidReveal;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Header("Scene References")]
		[SerializeField]
		private GameObject _backgroundRoot;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		protected Giant _giant;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public PuzzleManager[] Puzzles;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public PuzzleFerry Ferry;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Header("Project References")]
		public Material Skybox;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Cubemap HandTexture;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public Material[] HighlightMaterials;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[Header("Optional")]
		[SerializeField]
		private Mesh[] _navMeshes;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public bool AutoManageAudio;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public ChapterAudio Audio;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		protected Transform[] _giantScriptedSpawnPositions;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		protected State _currentState;

		[Token(Token = "0x17000017")]
		public int LastPuzzleIndex
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0xB854F8", Offset = "0xB854F8", VA = "0xB854F8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000018")]
		protected int _currentPuzzle
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0xB85518", Offset = "0xB85518", VA = "0xB85518")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xB85520", Offset = "0xB85520", VA = "0xB85520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		protected PuzzleManager _currentPuzzleInstance
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xB85528", Offset = "0xB85528", VA = "0xB85528")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xB85530", Offset = "0xB85530", VA = "0xB85530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xB85540", Offset = "0xB85540", VA = "0xB85540", Slot = "5")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xB85874", Offset = "0xB85874", VA = "0xB85874", Slot = "6")]
		public virtual void Cleanup()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xB85878", Offset = "0xB85878", VA = "0xB85878", Slot = "7")]
		public virtual void ConfigureFromSave()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xB86274", Offset = "0xB86274", VA = "0xB86274", Slot = "8")]
		public virtual void StartChapter()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xB865E8", Offset = "0xB865E8", VA = "0xB865E8", Slot = "9")]
		[IteratorStateMachine(typeof(<OutroChapter>d__39))]
		public virtual IEnumerator OutroChapter(ChapterIndex next)
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xB86684", Offset = "0xB86684", VA = "0xB86684")]
		protected bool UnlockChapter(ChapterIndex chapterIndex, GiantAnimationTrack desired, GiantAnimationTrack fallback, Transform location)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xB86784", Offset = "0xB86784", VA = "0xB86784", Slot = "10")]
		protected virtual void OnPuzzleComplete()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xB869E0", Offset = "0xB869E0", VA = "0xB869E0", Slot = "11")]
		public virtual void SpawnNextPuzzle()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xB86554", Offset = "0xB86554", VA = "0xB86554")]
		public void DeliverPuzzle()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xB86BE8", Offset = "0xB86BE8", VA = "0xB86BE8", Slot = "12")]
		[IteratorStateMachine(typeof(<SpawnPuzzle>d__44))]
		protected virtual IEnumerator SpawnPuzzle(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xB86CA0", Offset = "0xB86CA0", VA = "0xB86CA0", Slot = "13")]
		[IteratorStateMachine(typeof(<DeliverPuzzle>d__45))]
		protected virtual IEnumerator DeliverPuzzle(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xB86D58", Offset = "0xB86D58", VA = "0xB86D58", Slot = "14")]
		[IteratorStateMachine(typeof(<OutroPuzzle>d__46))]
		protected virtual IEnumerator OutroPuzzle(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xB86E10", Offset = "0xB86E10", VA = "0xB86E10")]
		public Chapter()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class Chapter1 : StandardChapter
	{
		[Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class <SpawnPuzzle>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Chapter1 <>4__this;

			[Token(Token = "0x4000129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PuzzleManager puzzle;

			[Token(Token = "0x17000024")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000121")]
				[Address(RVA = "0xB88AB0", Offset = "0xB88AB0", VA = "0xB88AB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000025")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000123")]
				[Address(RVA = "0xB88AF8", Offset = "0xB88AF8", VA = "0xB88AF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600011E")]
			[Address(RVA = "0xB888A4", Offset = "0xB888A4", VA = "0xB888A4")]
			[DebuggerHidden]
			public <SpawnPuzzle>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x600011F")]
			[Address(RVA = "0xB889B0", Offset = "0xB889B0", VA = "0xB889B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000120")]
			[Address(RVA = "0xB889B4", Offset = "0xB889B4", VA = "0xB889B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000122")]
			[Address(RVA = "0xB88AB8", Offset = "0xB88AB8", VA = "0xB88AB8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class <OutroPuzzle>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400012A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400012C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Chapter1 <>4__this;

			[Token(Token = "0x400012D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PuzzleManager puzzle;

			[Token(Token = "0x17000026")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000127")]
				[Address(RVA = "0xB88CA0", Offset = "0xB88CA0", VA = "0xB88CA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000027")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000129")]
				[Address(RVA = "0xB88CE8", Offset = "0xB88CE8", VA = "0xB88CE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000124")]
			[Address(RVA = "0xB8895C", Offset = "0xB8895C", VA = "0xB8895C")]
			[DebuggerHidden]
			public <OutroPuzzle>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000125")]
			[Address(RVA = "0xB88B00", Offset = "0xB88B00", VA = "0xB88B00", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000126")]
			[Address(RVA = "0xB88B04", Offset = "0xB88B04", VA = "0xB88B04", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0xB88CA8", Offset = "0xB88CA8", VA = "0xB88CA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[Header("Chapter 1")]
		[SerializeField]
		private AudioTrack _postPuzzleTrack;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		private TutorialEnvironment _environment;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[Inject]
		private Audio _audio;

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xB886A4", Offset = "0xB886A4", VA = "0xB886A4", Slot = "7")]
		public override void ConfigureFromSave()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xB886E0", Offset = "0xB886E0", VA = "0xB886E0", Slot = "8")]
		public override void StartChapter()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xB88814", Offset = "0xB88814", VA = "0xB88814", Slot = "12")]
		[IteratorStateMachine(typeof(<SpawnPuzzle>d__5))]
		protected override IEnumerator SpawnPuzzle(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xB888CC", Offset = "0xB888CC", VA = "0xB888CC", Slot = "14")]
		[IteratorStateMachine(typeof(<OutroPuzzle>d__6))]
		protected override IEnumerator OutroPuzzle(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xB88984", Offset = "0xB88984", VA = "0xB88984")]
		public Chapter1()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class Chapter2 : StandardChapter
	{
		[Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class <DeliverPuzzle>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Chapter2 <>4__this;

			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PuzzleManager puzzle;

			[Token(Token = "0x17000028")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600013C")]
				[Address(RVA = "0xB897EC", Offset = "0xB897EC", VA = "0xB897EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000029")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600013E")]
				[Address(RVA = "0xB89834", Offset = "0xB89834", VA = "0xB89834", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000139")]
			[Address(RVA = "0xB8913C", Offset = "0xB8913C", VA = "0xB8913C")]
			[DebuggerHidden]
			public <DeliverPuzzle>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x600013A")]
			[Address(RVA = "0xB896C0", Offset = "0xB896C0", VA = "0xB896C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600013B")]
			[Address(RVA = "0xB896C4", Offset = "0xB896C4", VA = "0xB896C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600013D")]
			[Address(RVA = "0xB897F4", Offset = "0xB897F4", VA = "0xB897F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class <OutroPuzzle>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Chapter2 <>4__this;

			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PuzzleManager puzzle;

			[Token(Token = "0x1700002A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000142")]
				[Address(RVA = "0xB89910", Offset = "0xB89910", VA = "0xB89910", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000144")]
				[Address(RVA = "0xB89958", Offset = "0xB89958", VA = "0xB89958", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600013F")]
			[Address(RVA = "0xB89418", Offset = "0xB89418", VA = "0xB89418")]
			[DebuggerHidden]
			public <OutroPuzzle>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000140")]
			[Address(RVA = "0xB8983C", Offset = "0xB8983C", VA = "0xB8983C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000141")]
			[Address(RVA = "0xB89840", Offset = "0xB89840", VA = "0xB89840", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000143")]
			[Address(RVA = "0xB89918", Offset = "0xB89918", VA = "0xB89918", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Header("Chapter 2 Specifics")]
		protected Vector2[] _puzzleDirectorStartStops;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _waitingOnBoat;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xB88CF0", Offset = "0xB88CF0", VA = "0xB88CF0", Slot = "5")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xB88DB8", Offset = "0xB88DB8", VA = "0xB88DB8", Slot = "6")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xB88E60", Offset = "0xB88E60", VA = "0xB88E60", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xB890AC", Offset = "0xB890AC", VA = "0xB890AC", Slot = "13")]
		[IteratorStateMachine(typeof(<DeliverPuzzle>d__5))]
		protected override IEnumerator DeliverPuzzle(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xB89164", Offset = "0xB89164", VA = "0xB89164", Slot = "7")]
		public override void ConfigureFromSave()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xB89388", Offset = "0xB89388", VA = "0xB89388", Slot = "14")]
		[IteratorStateMachine(typeof(<OutroPuzzle>d__7))]
		protected override IEnumerator OutroPuzzle(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xB89440", Offset = "0xB89440", VA = "0xB89440")]
		private void PostChapterUnlock()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xB894FC", Offset = "0xB894FC", VA = "0xB894FC")]
		public Chapter2()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class Chapter3 : StandardChapter
	{
		[Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class <OutroPuzzle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400013A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400013B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400013C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Chapter3 <>4__this;

			[Token(Token = "0x400013D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PuzzleManager puzzle;

			[Token(Token = "0x1700002C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000154")]
				[Address(RVA = "0xB8A11C", Offset = "0xB8A11C", VA = "0xB8A11C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000156")]
				[Address(RVA = "0xB8A164", Offset = "0xB8A164", VA = "0xB8A164", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000151")]
			[Address(RVA = "0xB89E04", Offset = "0xB89E04", VA = "0xB89E04")]
			[DebuggerHidden]
			public <OutroPuzzle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000152")]
			[Address(RVA = "0xB89F44", Offset = "0xB89F44", VA = "0xB89F44", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000153")]
			[Address(RVA = "0xB89F48", Offset = "0xB89F48", VA = "0xB89F48", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000155")]
			[Address(RVA = "0xB8A124", Offset = "0xB8A124", VA = "0xB8A124", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xB89960", Offset = "0xB89960", VA = "0xB89960", Slot = "5")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xB89A94", Offset = "0xB89A94", VA = "0xB89A94", Slot = "6")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xB89B3C", Offset = "0xB89B3C", VA = "0xB89B3C", Slot = "7")]
		public override void ConfigureFromSave()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xB89D44", Offset = "0xB89D44", VA = "0xB89D44")]
		public void GiantStand()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xB89D74", Offset = "0xB89D74", VA = "0xB89D74", Slot = "14")]
		[IteratorStateMachine(typeof(<OutroPuzzle>d__4))]
		protected override IEnumerator OutroPuzzle(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xB89E2C", Offset = "0xB89E2C", VA = "0xB89E2C")]
		public Chapter3()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class Chapter4 : StandardChapter
	{
		[Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class <SpawnPuzzle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400013E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Chapter4 <>4__this;

			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PuzzleManager puzzle;

			[Token(Token = "0x1700002E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000164")]
				[Address(RVA = "0xB8A640", Offset = "0xB8A640", VA = "0xB8A640", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000166")]
				[Address(RVA = "0xB8A688", Offset = "0xB8A688", VA = "0xB8A688", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000161")]
			[Address(RVA = "0xB8A3D8", Offset = "0xB8A3D8", VA = "0xB8A3D8")]
			[DebuggerHidden]
			public <SpawnPuzzle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000162")]
			[Address(RVA = "0xB8A4E4", Offset = "0xB8A4E4", VA = "0xB8A4E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000163")]
			[Address(RVA = "0xB8A4E8", Offset = "0xB8A4E8", VA = "0xB8A4E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000165")]
			[Address(RVA = "0xB8A648", Offset = "0xB8A648", VA = "0xB8A648", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class <OutroPuzzle>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Chapter4 <>4__this;

			[Token(Token = "0x4000145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PuzzleManager puzzle;

			[Token(Token = "0x17000030")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600016A")]
				[Address(RVA = "0xB8A738", Offset = "0xB8A738", VA = "0xB8A738", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000031")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600016C")]
				[Address(RVA = "0xB8A780", Offset = "0xB8A780", VA = "0xB8A780", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000167")]
			[Address(RVA = "0xB8A490", Offset = "0xB8A490", VA = "0xB8A490")]
			[DebuggerHidden]
			public <OutroPuzzle>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000168")]
			[Address(RVA = "0xB8A690", Offset = "0xB8A690", VA = "0xB8A690", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000169")]
			[Address(RVA = "0xB8A694", Offset = "0xB8A694", VA = "0xB8A694", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600016B")]
			[Address(RVA = "0xB8A740", Offset = "0xB8A740", VA = "0xB8A740", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xB8A16C", Offset = "0xB8A16C", VA = "0xB8A16C", Slot = "5")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xB8A234", Offset = "0xB8A234", VA = "0xB8A234", Slot = "6")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xB8A2DC", Offset = "0xB8A2DC", VA = "0xB8A2DC", Slot = "7")]
		public override void ConfigureFromSave()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xB8A30C", Offset = "0xB8A30C", VA = "0xB8A30C", Slot = "8")]
		public override void StartChapter()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xB8A348", Offset = "0xB8A348", VA = "0xB8A348", Slot = "12")]
		[IteratorStateMachine(typeof(<SpawnPuzzle>d__4))]
		protected override IEnumerator SpawnPuzzle(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xB8A400", Offset = "0xB8A400", VA = "0xB8A400", Slot = "14")]
		[IteratorStateMachine(typeof(<OutroPuzzle>d__5))]
		protected override IEnumerator OutroPuzzle(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xB8A4B8", Offset = "0xB8A4B8", VA = "0xB8A4B8")]
		public Chapter4()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class Chapter5 : StandardChapter
	{
		[Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class <OutroPuzzle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000146")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Chapter5 <>4__this;

			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PuzzleManager puzzle;

			[Token(Token = "0x17000032")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000178")]
				[Address(RVA = "0xB8ADDC", Offset = "0xB8ADDC", VA = "0xB8ADDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000033")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600017A")]
				[Address(RVA = "0xB8AE24", Offset = "0xB8AE24", VA = "0xB8AE24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000175")]
			[Address(RVA = "0xB8ACF4", Offset = "0xB8ACF4", VA = "0xB8ACF4")]
			[DebuggerHidden]
			public <OutroPuzzle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000176")]
			[Address(RVA = "0xB8AD44", Offset = "0xB8AD44", VA = "0xB8AD44", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000177")]
			[Address(RVA = "0xB8AD48", Offset = "0xB8AD48", VA = "0xB8AD48", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000179")]
			[Address(RVA = "0xB8ADE4", Offset = "0xB8ADE4", VA = "0xB8ADE4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xB8A788", Offset = "0xB8A788", VA = "0xB8A788", Slot = "5")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xB8A8F0", Offset = "0xB8A8F0", VA = "0xB8A8F0", Slot = "6")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xB8A9D8", Offset = "0xB8A9D8", VA = "0xB8A9D8", Slot = "8")]
		public override void StartChapter()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xB8AB00", Offset = "0xB8AB00", VA = "0xB8AB00")]
		private void PlayGiantTrack()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xB8AC64", Offset = "0xB8AC64", VA = "0xB8AC64", Slot = "14")]
		[IteratorStateMachine(typeof(<OutroPuzzle>d__4))]
		protected override IEnumerator OutroPuzzle(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xB8AD1C", Offset = "0xB8AD1C", VA = "0xB8AD1C")]
		public Chapter5()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public static class ChapterMath
	{
		[Token(Token = "0x600017B")]
		[Address(RVA = "0xB84D10", Offset = "0xB84D10", VA = "0xB84D10")]
		public static bool IsChapterIndex(ChapterIndex index)
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xB872BC", Offset = "0xB872BC", VA = "0xB872BC")]
		public static bool IsMiniChapterIndex(ChapterIndex index)
		{
			return default(bool);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xB8AE2C", Offset = "0xB8AE2C", VA = "0xB8AE2C")]
		public static ChapterIndex AssociatedMiniPuzzle(ChapterIndex index)
		{
			return default(ChapterIndex);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xB872CC", Offset = "0xB872CC", VA = "0xB872CC")]
		public static ChapterIndex AssociatedPuzzle(ChapterIndex index)
		{
			return default(ChapterIndex);
		}
	}
	[Token(Token = "0x200004B")]
	public class IntroCinematic : Chapter
	{
		[Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x4000159")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isDone;

			[Token(Token = "0x600018B")]
			[Address(RVA = "0xB8BCB4", Offset = "0xB8BCB4", VA = "0xB8BCB4")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x600018C")]
			[Address(RVA = "0xB8BCBC", Offset = "0xB8BCBC", VA = "0xB8BCBC")]
			internal void <OutroChapter>b__0()
			{
			}

			[Token(Token = "0x600018D")]
			[Address(RVA = "0xB8BCC8", Offset = "0xB8BCC8", VA = "0xB8BCC8")]
			internal void <OutroChapter>b__1()
			{
			}
		}

		[Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class <OutroChapter>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400015A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400015B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400015C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IntroCinematic <>4__this;

			[Token(Token = "0x400015D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ChapterIndex next;

			[Token(Token = "0x400015E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass20_0 <>8__1;

			[Token(Token = "0x17000034")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000191")]
				[Address(RVA = "0xB8BEDC", Offset = "0xB8BEDC", VA = "0xB8BEDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000035")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000193")]
				[Address(RVA = "0xB8BF24", Offset = "0xB8BF24", VA = "0xB8BF24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600018E")]
			[Address(RVA = "0xB8B388", Offset = "0xB8B388", VA = "0xB8B388")]
			[DebuggerHidden]
			public <OutroChapter>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x600018F")]
			[Address(RVA = "0xB8BCD4", Offset = "0xB8BCD4", VA = "0xB8BCD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000190")]
			[Address(RVA = "0xB8BCD8", Offset = "0xB8BCD8", VA = "0xB8BCD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000192")]
			[Address(RVA = "0xB8BEE4", Offset = "0xB8BEE4", VA = "0xB8BEE4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private PlayableDirector _masterTimeline;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Header("Geode Tutorial")]
		private Transform _geodeTop;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private Transform _geodeBottom;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Material _portalMat;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		private OutroPortal _outroPortal;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[Inject]
		private InputManager _inputManager;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[Inject]
		private Audio _audio;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[Inject]
		private PlatformRoot _platform;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[Inject]
		private MainCamera _mainCamera;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[Inject]
		private Skipper _skipper;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[Inject]
		private Bootstrapper _bootstrapper;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[Inject]
		private ControllerGuideGroup _controllerGuide;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private int _invokeCount;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private bool _focusControllers;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A5")]
		private bool _controllerInView;

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xB8AE40", Offset = "0xB8AE40", VA = "0xB8AE40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xB8AEB0", Offset = "0xB8AEB0", VA = "0xB8AEB0", Slot = "5")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xB8AFA0", Offset = "0xB8AFA0", VA = "0xB8AFA0", Slot = "7")]
		public override void ConfigureFromSave()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xB8AFA4", Offset = "0xB8AFA4", VA = "0xB8AFA4")]
		public void BeginTutorialFlow()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xB8B20C", Offset = "0xB8B20C", VA = "0xB8B20C")]
		public void CinematicMidway()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xB8B304", Offset = "0xB8B304", VA = "0xB8B304", Slot = "9")]
		[IteratorStateMachine(typeof(<OutroChapter>d__20))]
		public override IEnumerator OutroChapter(ChapterIndex next)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xB8B0DC", Offset = "0xB8B0DC", VA = "0xB8B0DC")]
		private void ShowMenuTutorial()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xB8B3B0", Offset = "0xB8B3B0", VA = "0xB8B3B0")]
		private void ShowGeodeTutorial()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xB8BBAC", Offset = "0xB8BBAC", VA = "0xB8BBAC")]
		public IntroCinematic()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class GeodeGroup : InjectableMonobehavior
	{
		[Token(Token = "0x2000052")]
		[CompilerGenerated]
		private sealed class <CombinePieces>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GeodeGroup <>4__this;

			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GeodeManipulator p1;

			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GeodeManipulator p2;

			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3 <midpoint>5__2;

			[Token(Token = "0x17000036")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001A8")]
				[Address(RVA = "0xB8D348", Offset = "0xB8D348", VA = "0xB8D348", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000037")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001AA")]
				[Address(RVA = "0xB8D390", Offset = "0xB8D390", VA = "0xB8D390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001A5")]
			[Address(RVA = "0xB8CEBC", Offset = "0xB8CEBC", VA = "0xB8CEBC")]
			[DebuggerHidden]
			public <CombinePieces>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x60001A6")]
			[Address(RVA = "0xB8CF10", Offset = "0xB8CF10", VA = "0xB8CF10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001A7")]
			[Address(RVA = "0xB8CF14", Offset = "0xB8CF14", VA = "0xB8CF14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xB8D350", Offset = "0xB8D350", VA = "0xB8D350", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ChapterIndex Chapter;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_pieces")]
		public GeodeManipulator[] Pieces;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SnapSettings _snapSettings;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ParticleSystem[] Seams;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Inject]
		private HandheldGrabHandler _grabHandler;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Inject]
		private VFXManager _vfx;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Inject]
		private Audio _audio;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _performCheck;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool _combined;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3[] _startPositions;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3[] _startRotations;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Action CombineStarted;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Action<GeodeGroup> Combined;

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xB8C2B8", Offset = "0xB8C2B8", VA = "0xB8C2B8", Slot = "5")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xB8C474", Offset = "0xB8C474", VA = "0xB8C474")]
		private void Update()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xB8C944", Offset = "0xB8C944", VA = "0xB8C944")]
		public void Configure(bool combined, bool updatePosition = true)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xB8CB48", Offset = "0xB8CB48", VA = "0xB8CB48")]
		public BaseTween RestorePosition(float durationSec, bool run)
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xB8CE04", Offset = "0xB8CE04", VA = "0xB8CE04")]
		public void EnableInteraction()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xB8BB44", Offset = "0xB8BB44", VA = "0xB8BB44")]
		public void DisableInteraction()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xB8CE68", Offset = "0xB8CE68", VA = "0xB8CE68")]
		private void ConfigurePiece(GeodeManipulator p, bool active)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xB8C8A0", Offset = "0xB8C8A0", VA = "0xB8C8A0")]
		[IteratorStateMachine(typeof(<CombinePieces>d__20))]
		private IEnumerator CombinePieces(GeodeManipulator p1, GeodeManipulator p2)
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xB8CEE4", Offset = "0xB8CEE4", VA = "0xB8CEE4")]
		public GeodeGroup()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class GeodeManipulator : HandheldManipulator
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private bool _shouldResize;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Inject]
		private HandheldGrabHandler _grabHandler;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Inject]
		private Audio _audio;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool _dormant;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private ConfigurableJoint _activeJoint;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 _connectedAnchorPoint;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private bool _scaleHappening;

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xB8D398", Offset = "0xB8D398", VA = "0xB8D398", Slot = "11")]
		public override void StartInput()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xB8D594", Offset = "0xB8D594", VA = "0xB8D594", Slot = "10")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xB8C59C", Offset = "0xB8C59C", VA = "0xB8C59C")]
		public bool CanSnap(SnapSettings settings, Transform otherPiece)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xB8D938", Offset = "0xB8D938", VA = "0xB8D938")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xB8DA48", Offset = "0xB8DA48", VA = "0xB8DA48")]
		private new void Reset()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xB8DAEC", Offset = "0xB8DAEC", VA = "0xB8DAEC")]
		public GeodeManipulator()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class GeodeMenu : InjectableMonobehavior
	{
		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GeodeGroup[] _chapterGeodes;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform[] _geodeHidePositions;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform[] _geodeLiftPositions;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Inject]
		private MessageBus _msgBus;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Inject]
		private SaveService _saveService;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ChapterIndex _currentChapter;

		[Token(Token = "0x14000003")]
		public event Action GeodeCombineStarted
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0xB8DB04", Offset = "0xB8DB04", VA = "0xB8DB04")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xB8DBA0", Offset = "0xB8DBA0", VA = "0xB8DBA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event Action<ChapterIndex> GeodeCombined
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xB8DC3C", Offset = "0xB8DC3C", VA = "0xB8DC3C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xB8DCEC", Offset = "0xB8DCEC", VA = "0xB8DCEC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xB8DD9C", Offset = "0xB8DD9C", VA = "0xB8DD9C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xB8E028", Offset = "0xB8E028", VA = "0xB8E028")]
		public BaseTween LiftGeodes(float durationSec)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xB8E310", Offset = "0xB8E310", VA = "0xB8E310")]
		public BaseTween RecallGeodes(float durationSec)
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xB8E5B8", Offset = "0xB8E5B8", VA = "0xB8E5B8")]
		public (GeodeGroup, Transform) GetGeodeGroup(ChapterIndex index)
		{
			return default((GeodeGroup, Transform));
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xB8E660", Offset = "0xB8E660", VA = "0xB8E660")]
		private void GeodePortalGoodness(GeodeGroup group)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xB8E70C", Offset = "0xB8E70C", VA = "0xB8E70C")]
		public GeodeMenu()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class GeodeSpin : MonoBehaviour
	{
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _spinAmount;

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xB8E778", Offset = "0xB8E778", VA = "0xB8E778")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xB8E7A0", Offset = "0xB8E7A0", VA = "0xB8E7A0")]
		public GeodeSpin()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public abstract class MiniChapter : Chapter
	{
		[Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class <SpawnPuzzle>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MiniChapter <>4__this;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PuzzleManager puzzle;

			[Token(Token = "0x17000038")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001CB")]
				[Address(RVA = "0xB8E9C4", Offset = "0xB8E9C4", VA = "0xB8E9C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000039")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0xB8EA0C", Offset = "0xB8EA0C", VA = "0xB8EA0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xB8E858", Offset = "0xB8E858", VA = "0xB8E858")]
			[DebuggerHidden]
			public <SpawnPuzzle>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xB8E910", Offset = "0xB8E910", VA = "0xB8E910", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xB8E914", Offset = "0xB8E914", VA = "0xB8E914", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xB8E9CC", Offset = "0xB8E9CC", VA = "0xB8E9CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isDone;

			[Token(Token = "0x60001CE")]
			[Address(RVA = "0xB8EA14", Offset = "0xB8EA14", VA = "0xB8EA14")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60001CF")]
			[Address(RVA = "0xB8EA1C", Offset = "0xB8EA1C", VA = "0xB8EA1C")]
			internal void <OutroChapter>b__0()
			{
			}

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0xB8EA28", Offset = "0xB8EA28", VA = "0xB8EA28")]
			internal void <OutroChapter>b__1()
			{
			}
		}

		[Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class <OutroChapter>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MiniChapter <>4__this;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ChapterIndex next;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass4_0 <>8__1;

			[Token(Token = "0x1700003A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0xB8EC50", Offset = "0xB8EC50", VA = "0xB8EC50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0xB8EC98", Offset = "0xB8EC98", VA = "0xB8EC98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D1")]
			[Address(RVA = "0xB8EA34", Offset = "0xB8EA34", VA = "0xB8EA34")]
			[DebuggerHidden]
			public <OutroChapter>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60001D2")]
			[Address(RVA = "0xB8EA5C", Offset = "0xB8EA5C", VA = "0xB8EA5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D3")]
			[Address(RVA = "0xB8EA60", Offset = "0xB8EA60", VA = "0xB8EA60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D5")]
			[Address(RVA = "0xB8EC58", Offset = "0xB8EC58", VA = "0xB8EC58", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private OutroPortal _outroPortal;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[Inject]
		protected Skipper _skipper;

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xB8E7A8", Offset = "0xB8E7A8", VA = "0xB8E7A8", Slot = "8")]
		public override void StartChapter()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xB8E7C8", Offset = "0xB8E7C8", VA = "0xB8E7C8", Slot = "12")]
		[IteratorStateMachine(typeof(<SpawnPuzzle>d__3))]
		protected override IEnumerator SpawnPuzzle(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xB8E880", Offset = "0xB8E880", VA = "0xB8E880", Slot = "9")]
		[IteratorStateMachine(typeof(<OutroChapter>d__4))]
		public override IEnumerator OutroChapter(ChapterIndex next)
		{
			return null;
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xB8E904", Offset = "0xB8E904", VA = "0xB8E904")]
		protected MiniChapter()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class MiniChapter2 : MiniChapter
	{
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xB8ECA0", Offset = "0xB8ECA0", VA = "0xB8ECA0")]
		public MiniChapter2()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public abstract class StandardChapter : Chapter
	{
		[Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isDone;

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xB8EE20", Offset = "0xB8EE20", VA = "0xB8EE20")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60001DF")]
			[Address(RVA = "0xB8EE28", Offset = "0xB8EE28", VA = "0xB8EE28")]
			internal void <OutroChapter>b__0()
			{
			}

			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xB8EE34", Offset = "0xB8EE34", VA = "0xB8EE34")]
			internal void <OutroChapter>b__1()
			{
			}
		}

		[Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class <OutroChapter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public StandardChapter <>4__this;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ChapterIndex next;

			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass8_0 <>8__1;

			[Token(Token = "0x1700003C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001E4")]
				[Address(RVA = "0xB8F12C", Offset = "0xB8F12C", VA = "0xB8F12C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001E6")]
				[Address(RVA = "0xB8F174", Offset = "0xB8F174", VA = "0xB8F174", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xB8EDE8", Offset = "0xB8EDE8", VA = "0xB8EDE8")]
			[DebuggerHidden]
			public <OutroChapter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xB8EE40", Offset = "0xB8EE40", VA = "0xB8EE40", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xB8EE44", Offset = "0xB8EE44", VA = "0xB8EE44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xB8F134", Offset = "0xB8F134", VA = "0xB8F134", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[Header("Standard Chapters")]
		[SerializeField]
		protected PlayableDirector _introTimeline;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private GameObject[] _introDestroyables;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private OutroPortal _outroPortal;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[Inject]
		protected Bootstrapper _bootstrapper;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[Inject]
		protected Skipper _skipper;

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xB8ECA8", Offset = "0xB8ECA8", VA = "0xB8ECA8", Slot = "5")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xB8ECBC", Offset = "0xB8ECBC", VA = "0xB8ECBC", Slot = "8")]
		public override void StartChapter()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xB8ECC4", Offset = "0xB8ECC4", VA = "0xB8ECC4", Slot = "15")]
		public virtual void CleanupIntro()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xB8ED64", Offset = "0xB8ED64", VA = "0xB8ED64", Slot = "9")]
		[IteratorStateMachine(typeof(<OutroChapter>d__8))]
		public override IEnumerator OutroChapter(ChapterIndex next)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xB8EE10", Offset = "0xB8EE10", VA = "0xB8EE10")]
		protected StandardChapter()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class TutorialChapter : Chapter
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[Inject]
		private Audio _audio;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[Inject]
		private new SaveService _saveService;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[Inject]
		private PlatformRoot _platform;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[Inject]
		private Bootstrapper _bootstrapper;

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xB8F17C", Offset = "0xB8F17C", VA = "0xB8F17C")]
		public TutorialChapter()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class TutorialEnvironment : InjectableMonobehavior
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int _Transition;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int _ForceWhiten;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Night -> Day Transition")]
		[SerializeField]
		private PlayableDirector _nightDayTimeline;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Light _light;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _nightColor;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _nightIntensity;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private SphericalHarmonicsL2 _nightSH;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Color _dayColor;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float _dayIntensity;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private SphericalHarmonicsL2 _daySH;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[Header("Chapter Outro")]
		[SerializeField]
		private PlayableDirector _nightDayTransition;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Material _handMat;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Material _skybox;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private GameObject _particlesThatShouldBeOff;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[Inject]
		private Bootstrapper _bootstrapper;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[Inject]
		private Audio _audio;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[Inject]
		private Skipper _skipper;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private RenderTexture _rt;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _giDirty;

		[Token(Token = "0x14000005")]
		public event Action ProgressionComplete
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xB8F184", Offset = "0xB8F184", VA = "0xB8F184")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xB8F224", Offset = "0xB8F224", VA = "0xB8F224")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xB8F2C4", Offset = "0xB8F2C4", VA = "0xB8F2C4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xB8F328", Offset = "0xB8F328", VA = "0xB8F328")]
		[ContextMenu("Loci/Start Night->Day")]
		public void StartNightToDay()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xB8F344", Offset = "0xB8F344", VA = "0xB8F344")]
		[ContextMenu("Loci/Set Night")]
		public void SetNight()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xB8F430", Offset = "0xB8F430", VA = "0xB8F430")]
		[ContextMenu("Loci/Set Day")]
		public void SetDay()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xB8F45C", Offset = "0xB8F45C", VA = "0xB8F45C")]
		public void StartProgression()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xB8F34C", Offset = "0xB8F34C", VA = "0xB8F34C")]
		private void SetEnvironmentInterpolation(float f)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xB8F6BC", Offset = "0xB8F6BC", VA = "0xB8F6BC")]
		public TutorialEnvironment()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class ControllerGuide : InjectableMonobehavior
	{
		[Token(Token = "0x2000063")]
		private enum VisualVariant
		{
			[Token(Token = "0x40001C6")]
			Unknown,
			[Token(Token = "0x40001C7")]
			OculusTouch,
			[Token(Token = "0x40001C8")]
			Knuckles,
			[Token(Token = "0x40001C9")]
			Vive,
			[Token(Token = "0x40001CA")]
			ViveCosmos
		}

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VisualVariant LastVariant;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PhysicalControllerVisual _questVisuals;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PhysicalControllerVisual _knucklesVisuals;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PhysicalControllerVisual _viveVisuals;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PhysicalControllerVisual _viveCosmosVisuals;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _defaultInvisible;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private VisualVariant _variant;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PhysicalControllerVisual _currentVisual;

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xB8F8F8", Offset = "0xB8F8F8", VA = "0xB8F8F8", Slot = "5")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xB8FB28", Offset = "0xB8FB28", VA = "0xB8FB28")]
		public void Show(PlatformRoot.ControllerAnnotations state)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xB8FB04", Offset = "0xB8FB04", VA = "0xB8FB04")]
		public void Hide()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xB8F988", Offset = "0xB8F988", VA = "0xB8F988")]
		private void SetVariant(VisualVariant variant)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xB8FB64", Offset = "0xB8FB64", VA = "0xB8FB64")]
		public ControllerGuide()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class ControllerGuideGroup : MonoBehaviour
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ControllerGuide[] _guides;

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xB8FBB8", Offset = "0xB8FBB8", VA = "0xB8FBB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xB8FC40", Offset = "0xB8FC40", VA = "0xB8FC40")]
		public void Show(PlatformRoot.ControllerAnnotations state)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xB8FCBC", Offset = "0xB8FCBC", VA = "0xB8FCBC")]
		public void Hide()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xB8FD30", Offset = "0xB8FD30", VA = "0xB8FD30")]
		public ControllerGuideGroup()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class DebugHud : MonoBehaviour
	{
		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Fps;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float Draws;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static float Verts;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string Debug;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static float STDRender;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static float SRPRender;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static float SetPass;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _fps;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _draws;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _verts;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _debug;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _build;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _srpRender;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _stdRender;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _setPassCalls;

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xB8FD38", Offset = "0xB8FD38", VA = "0xB8FD38")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xB8FDF4", Offset = "0xB8FDF4", VA = "0xB8FDF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xB9010C", Offset = "0xB9010C", VA = "0xB9010C")]
		public void Show()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xB90130", Offset = "0xB90130", VA = "0xB90130")]
		public void Hide()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xB90154", Offset = "0xB90154", VA = "0xB90154")]
		public DebugHud()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[ExecuteInEditMode]
	public class Environment : InjectableMonobehavior
	{
		[Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class <ExitVoid>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AnimationCurve curve;

			[Token(Token = "0x40001EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Environment <>4__this;

			[Token(Token = "0x1700003E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000213")]
				[Address(RVA = "0xB90DB0", Offset = "0xB90DB0", VA = "0xB90DB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000215")]
				[Address(RVA = "0xB90DF8", Offset = "0xB90DF8", VA = "0xB90DF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000210")]
			[Address(RVA = "0xB90788", Offset = "0xB90788", VA = "0xB90788")]
			[DebuggerHidden]
			public <ExitVoid>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000211")]
			[Address(RVA = "0xB90A34", Offset = "0xB90A34", VA = "0xB90A34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000212")]
			[Address(RVA = "0xB90A38", Offset = "0xB90A38", VA = "0xB90A38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000214")]
			[Address(RVA = "0xB90DB8", Offset = "0xB90DB8", VA = "0xB90DB8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class <EnterVoid>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Environment <>4__this;

			[Token(Token = "0x17000040")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600021C")]
				[Address(RVA = "0xB910DC", Offset = "0xB910DC", VA = "0xB910DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000041")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600021E")]
				[Address(RVA = "0xB91124", Offset = "0xB91124", VA = "0xB91124", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000219")]
			[Address(RVA = "0xB90824", Offset = "0xB90824", VA = "0xB90824")]
			[DebuggerHidden]
			public <EnterVoid>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600021A")]
			[Address(RVA = "0xB90EE4", Offset = "0xB90EE4", VA = "0xB90EE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600021B")]
			[Address(RVA = "0xB90EE8", Offset = "0xB90EE8", VA = "0xB90EE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0xB910E4", Offset = "0xB910E4", VA = "0xB910E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int _Cubemap;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int _VoidSrcWS;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int _VoidPull;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int _VoidMin;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int _VoidMax;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Inject]
		private MainCamera _mainCamera;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ReflectionProbe _probe;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ChapterIndex _chapter;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Color _voidColor;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BaseTween _revealTween;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Deprecated?")]
		[SerializeField]
		private Material _handMaterial;

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xB90214", Offset = "0xB90214", VA = "0xB90214", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xB902C8", Offset = "0xB902C8", VA = "0xB902C8")]
		public void SetSkybox(Material skybox)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xB905B8", Offset = "0xB905B8", VA = "0xB905B8")]
		public void SetHandTexture(Cubemap texture, float fadeDurationSec = 3f)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xB906F8", Offset = "0xB906F8", VA = "0xB906F8")]
		[IteratorStateMachine(typeof(<ExitVoid>d__14))]
		public IEnumerator ExitVoid(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xB907B0", Offset = "0xB907B0", VA = "0xB907B0")]
		[IteratorStateMachine(typeof(<EnterVoid>d__15))]
		public IEnumerator EnterVoid()
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xB9084C", Offset = "0xB9084C", VA = "0xB9084C")]
		public Environment()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class BoatFerry : PuzzleFerry
	{
		[Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class <MoveToPlayer>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BoatFerry <>4__this;

			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PuzzleManager puzzle;

			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PrefixedPuzzleChunk[] puzzlePieces;

			[Token(Token = "0x17000042")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000226")]
				[Address(RVA = "0xB91E24", Offset = "0xB91E24", VA = "0xB91E24", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000043")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000228")]
				[Address(RVA = "0xB91E6C", Offset = "0xB91E6C", VA = "0xB91E6C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0xB9183C", Offset = "0xB9183C", VA = "0xB9183C")]
			[DebuggerHidden]
			public <MoveToPlayer>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0xB91874", Offset = "0xB91874", VA = "0xB91874", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000225")]
			[Address(RVA = "0xB91878", Offset = "0xB91878", VA = "0xB91878", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000227")]
			[Address(RVA = "0xB91E2C", Offset = "0xB91E2C", VA = "0xB91E2C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Inject]
		private MainCamera _camera;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Inject]
		private ViewableRegion _viewableRegion;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float[] LiftHeight;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform Boat;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform[] PuzzleSpawnRoots;

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xB9112C", Offset = "0xB9112C", VA = "0xB9112C", Slot = "8")]
		public override void SpawnInstant(PuzzleManager puzzle, List<PrefixedPuzzleChunk> pieces)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xB91724", Offset = "0xB91724", VA = "0xB91724", Slot = "6")]
		public override IEnumerator SpawnPieces(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xB91798", Offset = "0xB91798", VA = "0xB91798", Slot = "7")]
		[IteratorStateMachine(typeof(<MoveToPlayer>d__7))]
		public override IEnumerator MoveToPlayer(PuzzleManager puzzle, PrefixedPuzzleChunk[] puzzlePieces)
		{
			return null;
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xB91864", Offset = "0xB91864", VA = "0xB91864")]
		public BoatFerry()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class CloudRiseFerry : PuzzleFerry
	{
		[Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class <SpawnPieces>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuzzleManager puzzle;

			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CloudRiseFerry <>4__this;

			[Token(Token = "0x17000044")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000231")]
				[Address(RVA = "0xB92804", Offset = "0xB92804", VA = "0xB92804", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000045")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000233")]
				[Address(RVA = "0xB9284C", Offset = "0xB9284C", VA = "0xB9284C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600022E")]
			[Address(RVA = "0xB92190", Offset = "0xB92190", VA = "0xB92190")]
			[DebuggerHidden]
			public <SpawnPieces>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600022F")]
			[Address(RVA = "0xB92398", Offset = "0xB92398", VA = "0xB92398", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000230")]
			[Address(RVA = "0xB9239C", Offset = "0xB9239C", VA = "0xB9239C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000232")]
			[Address(RVA = "0xB9280C", Offset = "0xB9280C", VA = "0xB9280C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200006F")]
		[CompilerGenerated]
		private sealed class <MoveToPlayer>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CloudRiseFerry <>4__this;

			[Token(Token = "0x400020A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PrefixedPuzzleChunk[] puzzlePieces;

			[Token(Token = "0x400020B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PuzzleManager puzzle;

			[Token(Token = "0x17000046")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000237")]
				[Address(RVA = "0xB929C4", Offset = "0xB929C4", VA = "0xB929C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000047")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000239")]
				[Address(RVA = "0xB92A0C", Offset = "0xB92A0C", VA = "0xB92A0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000234")]
			[Address(RVA = "0xB9225C", Offset = "0xB9225C", VA = "0xB9225C")]
			[DebuggerHidden]
			public <MoveToPlayer>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000235")]
			[Address(RVA = "0xB92854", Offset = "0xB92854", VA = "0xB92854", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000236")]
			[Address(RVA = "0xB92858", Offset = "0xB92858", VA = "0xB92858", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000238")]
			[Address(RVA = "0xB929CC", Offset = "0xB929CC", VA = "0xB929CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class <Move>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400020C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400020D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3[] destinations;

			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PrefixedPuzzleChunk[] chunks;

			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public TweenConfig positionTween;

			[Token(Token = "0x4000211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 dstScale;

			[Token(Token = "0x4000212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public TweenConfig scaleTween;

			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Vector3[] <startPositions>5__2;

			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Vector3[] <startScales>5__3;

			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float <startTime>5__4;

			[Token(Token = "0x17000048")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600023D")]
				[Address(RVA = "0xB92E28", Offset = "0xB92E28", VA = "0xB92E28", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000049")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600023F")]
				[Address(RVA = "0xB92E70", Offset = "0xB92E70", VA = "0xB92E70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600023A")]
			[Address(RVA = "0xB92368", Offset = "0xB92368", VA = "0xB92368")]
			[DebuggerHidden]
			public <Move>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600023B")]
			[Address(RVA = "0xB92A14", Offset = "0xB92A14", VA = "0xB92A14", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600023C")]
			[Address(RVA = "0xB92A18", Offset = "0xB92A18", VA = "0xB92A18", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600023E")]
			[Address(RVA = "0xB92E30", Offset = "0xB92E30", VA = "0xB92E30", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Inject]
		private ViewableRegion _viewableRegion;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Inject]
		private MainCamera _mainCamera;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform[] Group1;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform[] Group2;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform[] Group3;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform[] Group4;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float[] SpawnHeightOffsets;

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xB91E74", Offset = "0xB91E74", VA = "0xB91E74", Slot = "8")]
		public override void SpawnInstant(PuzzleManager puzzle, List<PrefixedPuzzleChunk> pieces)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xB92100", Offset = "0xB92100", VA = "0xB92100", Slot = "6")]
		[IteratorStateMachine(typeof(<SpawnPieces>d__8))]
		public override IEnumerator SpawnPieces(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xB921B8", Offset = "0xB921B8", VA = "0xB921B8", Slot = "7")]
		[IteratorStateMachine(typeof(<MoveToPlayer>d__9))]
		public override IEnumerator MoveToPlayer(PuzzleManager puzzle, PrefixedPuzzleChunk[] puzzlePieces)
		{
			return null;
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xB92284", Offset = "0xB92284", VA = "0xB92284")]
		[IteratorStateMachine(typeof(<Move>d__10))]
		private IEnumerator Move(PrefixedPuzzleChunk[] chunks, Vector3[] destinations, Vector3 dstScale, TweenConfig positionTween, TweenConfig scaleTween)
		{
			return null;
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xB92390", Offset = "0xB92390", VA = "0xB92390")]
		public CloudRiseFerry()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public abstract class PuzzleFerry : InjectableMonobehavior
	{
		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Inject]
		protected SymbolPlatform _symbolPlatform;

		[Token(Token = "0x6000240")]
		public abstract IEnumerator SpawnPieces(PuzzleManager puzzle);

		[Token(Token = "0x6000241")]
		public abstract IEnumerator MoveToPlayer(PuzzleManager puzzle, PrefixedPuzzleChunk[] puzzlePieces);

		[Token(Token = "0x6000242")]
		public abstract void SpawnInstant(PuzzleManager puzzle, List<PrefixedPuzzleChunk> pieces);

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xB9186C", Offset = "0xB9186C", VA = "0xB9186C")]
		protected PuzzleFerry()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class ScaleFerry : PuzzleFerry
	{
		[Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class <MoveToPlayer>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ScaleFerry <>4__this;

			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PuzzleManager puzzle;

			[Token(Token = "0x1700004A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600024B")]
				[Address(RVA = "0xB93418", Offset = "0xB93418", VA = "0xB93418", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600024D")]
				[Address(RVA = "0xB93460", Offset = "0xB93460", VA = "0xB93460", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000248")]
			[Address(RVA = "0xB93174", Offset = "0xB93174", VA = "0xB93174")]
			[DebuggerHidden]
			public <MoveToPlayer>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000249")]
			[Address(RVA = "0xB931A4", Offset = "0xB931A4", VA = "0xB931A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600024A")]
			[Address(RVA = "0xB931A8", Offset = "0xB931A8", VA = "0xB931A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600024C")]
			[Address(RVA = "0xB93420", Offset = "0xB93420", VA = "0xB93420", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Inject]
		private ViewableRegion _viewableRegion;

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xB92E78", Offset = "0xB92E78", VA = "0xB92E78", Slot = "8")]
		public override void SpawnInstant(PuzzleManager puzzle, List<PrefixedPuzzleChunk> pieces)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xB93098", Offset = "0xB93098", VA = "0xB93098", Slot = "6")]
		public override IEnumerator SpawnPieces(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xB930E4", Offset = "0xB930E4", VA = "0xB930E4", Slot = "7")]
		[IteratorStateMachine(typeof(<MoveToPlayer>d__3))]
		public override IEnumerator MoveToPlayer(PuzzleManager puzzle, PrefixedPuzzleChunk[] puzzlePieces)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xB9319C", Offset = "0xB9319C", VA = "0xB9319C")]
		public ScaleFerry()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class SubmergedFerryV2 : PuzzleFerry
	{
		[Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class <SpawnPieces>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SubmergedFerryV2 <>4__this;

			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PuzzleManager puzzle;

			[Token(Token = "0x1700004C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000257")]
				[Address(RVA = "0xB93C04", Offset = "0xB93C04", VA = "0xB93C04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000259")]
				[Address(RVA = "0xB93C4C", Offset = "0xB93C4C", VA = "0xB93C4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000254")]
			[Address(RVA = "0xB93864", Offset = "0xB93864", VA = "0xB93864")]
			[DebuggerHidden]
			public <SpawnPieces>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000255")]
			[Address(RVA = "0xB93ACC", Offset = "0xB93ACC", VA = "0xB93ACC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000256")]
			[Address(RVA = "0xB93AD0", Offset = "0xB93AD0", VA = "0xB93AD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000258")]
			[Address(RVA = "0xB93C0C", Offset = "0xB93C0C", VA = "0xB93C0C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class <MoveToPlayer>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PrefixedPuzzleChunk[] puzzlePieces;

			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SubmergedFerryV2 <>4__this;

			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PuzzleManager puzzle;

			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TweenConfig <config>5__2;

			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 <pieceAvgPos>5__3;

			[Token(Token = "0x1700004E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600025D")]
				[Address(RVA = "0xB94084", Offset = "0xB94084", VA = "0xB94084", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600025F")]
				[Address(RVA = "0xB940CC", Offset = "0xB940CC", VA = "0xB940CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600025A")]
			[Address(RVA = "0xB93930", Offset = "0xB93930", VA = "0xB93930")]
			[DebuggerHidden]
			public <MoveToPlayer>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x600025B")]
			[Address(RVA = "0xB93C54", Offset = "0xB93C54", VA = "0xB93C54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600025C")]
			[Address(RVA = "0xB93C58", Offset = "0xB93C58", VA = "0xB93C58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600025E")]
			[Address(RVA = "0xB9408C", Offset = "0xB9408C", VA = "0xB9408C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class <Move>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 dstScale;

			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PrefixedPuzzleChunk[] chunks;

			[Token(Token = "0x4000236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3[] destinations;

			[Token(Token = "0x4000237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public TweenConfig positionTween;

			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public TweenConfig scaleTween;

			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Vector3[] <startPositions>5__2;

			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Vector3[] <startScales>5__3;

			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float <startTime>5__4;

			[Token(Token = "0x17000050")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000263")]
				[Address(RVA = "0xB945D0", Offset = "0xB945D0", VA = "0xB945D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000051")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000265")]
				[Address(RVA = "0xB94618", Offset = "0xB94618", VA = "0xB94618", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000260")]
			[Address(RVA = "0xB93A3C", Offset = "0xB93A3C", VA = "0xB93A3C")]
			[DebuggerHidden]
			public <Move>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000261")]
			[Address(RVA = "0xB940D4", Offset = "0xB940D4", VA = "0xB940D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000262")]
			[Address(RVA = "0xB940D8", Offset = "0xB940D8", VA = "0xB940D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000264")]
			[Address(RVA = "0xB945D8", Offset = "0xB945D8", VA = "0xB945D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Inject]
		private ViewableRegion _viewableRegion;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Inject]
		private VFXManager _vfx;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform[] Group1;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform[] Group2;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform[] Group3;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform[] Group4;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector2 PeakHeights;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector2 RecurringHeights;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector2 LiftHeight;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float WaterHeight;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float EffectScale;

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xB93468", Offset = "0xB93468", VA = "0xB93468", Slot = "8")]
		public override void SpawnInstant(PuzzleManager puzzle, List<PrefixedPuzzleChunk> pieces)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xB937D4", Offset = "0xB937D4", VA = "0xB937D4", Slot = "6")]
		[IteratorStateMachine(typeof(<SpawnPieces>d__12))]
		public override IEnumerator SpawnPieces(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xB9388C", Offset = "0xB9388C", VA = "0xB9388C", Slot = "7")]
		[IteratorStateMachine(typeof(<MoveToPlayer>d__13))]
		public override IEnumerator MoveToPlayer(PuzzleManager puzzle, PrefixedPuzzleChunk[] puzzlePieces)
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xB93958", Offset = "0xB93958", VA = "0xB93958")]
		[IteratorStateMachine(typeof(<Move>d__14))]
		private IEnumerator Move(PrefixedPuzzleChunk[] chunks, Vector3[] destinations, Vector3 dstScale, TweenConfig positionTween, TweenConfig scaleTween)
		{
			return null;
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xB93A64", Offset = "0xB93A64", VA = "0xB93A64")]
		public SubmergedFerryV2()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class TempleFerry : PuzzleFerry
	{
		[Serializable]
		[Token(Token = "0x2000079")]
		private struct Delivery
		{
			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform[] Origins;

			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform[] Locations;
		}

		[Serializable]
		[Token(Token = "0x200007A")]
		private struct DeliverySet
		{
			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int[] Pieces;
		}

		[Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class <SpawnPieces>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TempleFerry <>4__this;

			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PuzzleManager puzzle;

			[Token(Token = "0x17000052")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000274")]
				[Address(RVA = "0xB95190", Offset = "0xB95190", VA = "0xB95190", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000053")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000276")]
				[Address(RVA = "0xB951D8", Offset = "0xB951D8", VA = "0xB951D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000271")]
			[Address(RVA = "0xB949FC", Offset = "0xB949FC", VA = "0xB949FC")]
			[DebuggerHidden]
			public <SpawnPieces>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000272")]
			[Address(RVA = "0xB95090", Offset = "0xB95090", VA = "0xB95090", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000273")]
			[Address(RVA = "0xB95094", Offset = "0xB95094", VA = "0xB95094", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000275")]
			[Address(RVA = "0xB95198", Offset = "0xB95198", VA = "0xB95198", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class <MoveToPlayer>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TempleFerry <>4__this;

			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PuzzleManager puzzle;

			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PrefixedPuzzleChunk[] puzzlePieces;

			[Token(Token = "0x17000054")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600027A")]
				[Address(RVA = "0xB952A4", Offset = "0xB952A4", VA = "0xB952A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000055")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600027C")]
				[Address(RVA = "0xB952EC", Offset = "0xB952EC", VA = "0xB952EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000277")]
			[Address(RVA = "0xB94AC8", Offset = "0xB94AC8", VA = "0xB94AC8")]
			[DebuggerHidden]
			public <MoveToPlayer>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000278")]
			[Address(RVA = "0xB951E0", Offset = "0xB951E0", VA = "0xB951E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000279")]
			[Address(RVA = "0xB951E4", Offset = "0xB951E4", VA = "0xB951E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600027B")]
			[Address(RVA = "0xB952AC", Offset = "0xB952AC", VA = "0xB952AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class <MoveToPlayer_Tutorial>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuzzleManager puzzle;

			[Token(Token = "0x17000056")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000280")]
				[Address(RVA = "0xB9552C", Offset = "0xB9552C", VA = "0xB9552C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000057")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000282")]
				[Address(RVA = "0xB95574", Offset = "0xB95574", VA = "0xB95574", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600027D")]
			[Address(RVA = "0xB94D60", Offset = "0xB94D60", VA = "0xB94D60")]
			[DebuggerHidden]
			public <MoveToPlayer_Tutorial>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x600027E")]
			[Address(RVA = "0xB952F4", Offset = "0xB952F4", VA = "0xB952F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600027F")]
			[Address(RVA = "0xB952F8", Offset = "0xB952F8", VA = "0xB952F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0xB95534", Offset = "0xB95534", VA = "0xB95534", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class <SpawnPieces_Temple>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuzzleManager puzzle;

			[Token(Token = "0x4000255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TempleFerry <>4__this;

			[Token(Token = "0x17000058")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000286")]
				[Address(RVA = "0xB957D8", Offset = "0xB957D8", VA = "0xB957D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000059")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000288")]
				[Address(RVA = "0xB95820", Offset = "0xB95820", VA = "0xB95820", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000283")]
			[Address(RVA = "0xB94E18", Offset = "0xB94E18", VA = "0xB94E18")]
			[DebuggerHidden]
			public <SpawnPieces_Temple>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000284")]
			[Address(RVA = "0xB9557C", Offset = "0xB9557C", VA = "0xB9557C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000285")]
			[Address(RVA = "0xB95580", Offset = "0xB95580", VA = "0xB95580", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000287")]
			[Address(RVA = "0xB957E0", Offset = "0xB957E0", VA = "0xB957E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class <MoveToPlayer_Temple>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000257")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000258")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000259")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuzzleManager puzzle;

			[Token(Token = "0x400025A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PrefixedPuzzleChunk[] puzzlePieces;

			[Token(Token = "0x400025B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public TempleFerry <>4__this;

			[Token(Token = "0x1700005A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600028E")]
				[Address(RVA = "0xB95FEC", Offset = "0xB95FEC", VA = "0xB95FEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000290")]
				[Address(RVA = "0xB96034", Offset = "0xB96034", VA = "0xB96034", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0xB94EE4", Offset = "0xB94EE4", VA = "0xB94EE4")]
			[DebuggerHidden]
			public <MoveToPlayer_Temple>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600028C")]
			[Address(RVA = "0xB95850", Offset = "0xB95850", VA = "0xB95850", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600028D")]
			[Address(RVA = "0xB95854", Offset = "0xB95854", VA = "0xB95854", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600028F")]
			[Address(RVA = "0xB95FF4", Offset = "0xB95FF4", VA = "0xB95FF4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Inject]
		private VFXManager _vfx;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform[] _tutorialGroup1;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform[] _tutorialGroup2;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Delivery _delivery2;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2 _peakHeights;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Vector2 _recurringHeights;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _waterHeight;

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xB94620", Offset = "0xB94620", VA = "0xB94620", Slot = "8")]
		public override void SpawnInstant(PuzzleManager puzzle, List<PrefixedPuzzleChunk> pieces)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xB9496C", Offset = "0xB9496C", VA = "0xB9496C", Slot = "6")]
		[IteratorStateMachine(typeof(<SpawnPieces>d__10))]
		public override IEnumerator SpawnPieces(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xB94A24", Offset = "0xB94A24", VA = "0xB94A24", Slot = "7")]
		[IteratorStateMachine(typeof(<MoveToPlayer>d__11))]
		public override IEnumerator MoveToPlayer(PuzzleManager puzzle, PrefixedPuzzleChunk[] puzzlePieces)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xB94AF0", Offset = "0xB94AF0", VA = "0xB94AF0")]
		private void SpawnPieces_Tutorial(PuzzleManager puzzle)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xB94CEC", Offset = "0xB94CEC", VA = "0xB94CEC")]
		[IteratorStateMachine(typeof(<MoveToPlayer_Tutorial>d__13))]
		private IEnumerator MoveToPlayer_Tutorial(PuzzleManager puzzle, PrefixedPuzzleChunk[] puzzlePieces)
		{
			return null;
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xB94D88", Offset = "0xB94D88", VA = "0xB94D88")]
		[IteratorStateMachine(typeof(<SpawnPieces_Temple>d__14))]
		private IEnumerator SpawnPieces_Temple(PuzzleManager puzzle)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xB94E40", Offset = "0xB94E40", VA = "0xB94E40")]
		[IteratorStateMachine(typeof(<MoveToPlayer_Temple>d__15))]
		private IEnumerator MoveToPlayer_Temple(PuzzleManager puzzle, PrefixedPuzzleChunk[] puzzlePieces)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xB9494C", Offset = "0xB9494C", VA = "0xB9494C")]
		private bool IsTemple(PuzzleManager puzzle)
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xB94F0C", Offset = "0xB94F0C", VA = "0xB94F0C")]
		private void AddBuoyancy(PrefixedPuzzleChunk chunk)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xB95040", Offset = "0xB95040", VA = "0xB95040")]
		public TempleFerry()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class AnimationTester : MonoBehaviour
	{
		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Track;

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xB9603C", Offset = "0xB9603C", VA = "0xB9603C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xB960D8", Offset = "0xB960D8", VA = "0xB960D8")]
		public AnimationTester()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class EffectTesting : MonoBehaviour
	{
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] Chunks;

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xB960E0", Offset = "0xB960E0", VA = "0xB960E0")]
		public void Create()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xB960E4", Offset = "0xB960E4", VA = "0xB960E4")]
		[ContextMenu("Destroy")]
		public void Destroy()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xB962B8", Offset = "0xB962B8", VA = "0xB962B8")]
		public EffectTesting()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class Giant : InjectableMonobehavior
	{
		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Giant Instance;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int TRACK;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int RESET;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int CONTINUE;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly Color NormalEmission;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Inject]
		private MainCamera _camera;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Inject]
		private Bootstrapper _bootstrapper;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Inject]
		private Audio _audio;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Inject]
		private VFXManager _vfx;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Inject]
		private ChapterRunner _runner;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _rigRoot;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Animator _animator;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[ColorUsage(true, true)]
		private Color[] _chapterColors;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[FormerlySerializedAs("HandPickupRight")]
		[Header("Transform References")]
		[SerializeField]
		public Transform _handPickupRight;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		public Transform _handPickupLeft;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _portalCenter;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GiantFragment Core;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Header("Material References")]
		private Material _grassMaterial;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Material _iceMaterial;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Material _creditsMaterial;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[FormerlySerializedAs("AppearParticles")]
		[Header("Effects")]
		[SerializeField]
		private ParticleSystem[] _appearParticles;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private ChapterUnlock _chapterUnlock;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private MaterialLink _materialLink;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AnimationCurve FragmentRotation;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Header("Audio")]
		private AudioSource _audioSource;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private AudioClip _appear;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private AudioClip _disappear;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int _showCount;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private GiantFragment[] _fragments;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int _RimColor;

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xB96458", Offset = "0xB96458", VA = "0xB96458", Slot = "5")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xB96788", Offset = "0xB96788", VA = "0xB96788")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xB96830", Offset = "0xB96830", VA = "0xB96830")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xB968D8", Offset = "0xB968D8", VA = "0xB968D8")]
		public void ConfigureVisibility(bool visible)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xB969F0", Offset = "0xB969F0", VA = "0xB969F0")]
		public void PlayTrack(GiantAnimationTrack track, Transform location)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xB96C74", Offset = "0xB96C74", VA = "0xB96C74")]
		public void ContinueAnimation()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xB96C0C", Offset = "0xB96C0C", VA = "0xB96C0C")]
		[ContextMenu("Show")]
		public void Show()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xB97038", Offset = "0xB97038", VA = "0xB97038")]
		[ContextMenu("Hide")]
		public void Hide()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xB974A8", Offset = "0xB974A8", VA = "0xB974A8")]
		public void HideInstant()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xB965B0", Offset = "0xB965B0", VA = "0xB965B0")]
		private void Configure(ChapterIndex index)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xB968E8", Offset = "0xB968E8", VA = "0xB968E8")]
		private void SetVisibility(bool visible)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xB974B0", Offset = "0xB974B0", VA = "0xB974B0")]
		[ContextMenu("Scatter")]
		private void Scatter()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xB976F8", Offset = "0xB976F8", VA = "0xB976F8")]
		[ContextMenu("Assemble")]
		private void Assemble()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xB96CE4", Offset = "0xB96CE4", VA = "0xB96CE4")]
		[ContextMenu("Grow")]
		private void Grow()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xB97070", Offset = "0xB97070", VA = "0xB97070")]
		[ContextMenu("Shrink")]
		private void Shrink()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xB97D38", Offset = "0xB97D38", VA = "0xB97D38")]
		public Giant()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public enum GiantAnimationTrack
	{
		[Token(Token = "0x4000282")]
		IdleTurnWalk = 100,
		[Token(Token = "0x4000283")]
		LookdownTurnWalk = 101,
		[Token(Token = "0x4000284")]
		CelebrateWaveTurnWalk = 102,
		[Token(Token = "0x4000285")]
		BendGrabPresent = 200,
		[Token(Token = "0x4000286")]
		GeodeCreate = 202,
		[Token(Token = "0x4000287")]
		GeodeCreate_Ch3 = 203,
		[Token(Token = "0x4000288")]
		GeodeCreate_Walkaway = 204,
		[Token(Token = "0x4000289")]
		GeodeCreate_Ch4 = 205,
		[Token(Token = "0x400028A")]
		Chapter2_Puzzle2 = 250,
		[Token(Token = "0x400028B")]
		Chapter2_Puzzle2_NoUnlock = 251,
		[Token(Token = "0x400028C")]
		Chapter3_Puzzle1 = 500,
		[Token(Token = "0x400028D")]
		Chapter3_Puzzle2 = 501,
		[Token(Token = "0x400028E")]
		Chapter3_Puzzle3 = 502,
		[Token(Token = "0x400028F")]
		Chapter3_Puzzle4 = 503,
		[Token(Token = "0x4000290")]
		Chapter3_Puzzle2_NoUnlock = 505,
		[Token(Token = "0x4000291")]
		Chapter3_Puzzle2_PostUnlock = 506,
		[Token(Token = "0x4000292")]
		Chapter4_Puzzle1 = 600,
		[Token(Token = "0x4000293")]
		Chapter4_Puzzle2 = 601,
		[Token(Token = "0x4000294")]
		Chapter4_Puzzle2_NoUnlock = 602,
		[Token(Token = "0x4000295")]
		Chapter4_Puzzle2_PostUnlock = 603,
		[Token(Token = "0x4000296")]
		Chapter5_Puzzle1 = 700,
		[Token(Token = "0x4000297")]
		Chapter5_Puzzle2 = 701,
		[Token(Token = "0x4000298")]
		Chapter5_Puzzle3 = 702,
		[Token(Token = "0x4000299")]
		Chapter5_Puzzle4 = 703,
		[Token(Token = "0x400029A")]
		Wave = 1000
	}
	[Token(Token = "0x2000087")]
	public class GiantFragment : MonoBehaviour
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _builtRefBone;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _builtLocalPosition;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Quaternion _builtLocalOffset;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _scaleAdjustment;

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xB97624", Offset = "0xB97624", VA = "0xB97624")]
		public void SpawnAtLocation(Vector3 xzWorld, float scale)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xB97780", Offset = "0xB97780", VA = "0xB97780")]
		public BaseTween Assemble(TweenConfig config)
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xB97B04", Offset = "0xB97B04", VA = "0xB97B04")]
		public BaseTween Grow(TweenConfig config)
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xB97BD8", Offset = "0xB97BD8", VA = "0xB97BD8")]
		public BaseTween Shrink(TweenConfig config)
		{
			return null;
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xB97E90", Offset = "0xB97E90", VA = "0xB97E90")]
		private void Reset()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xB97F08", Offset = "0xB97F08", VA = "0xB97F08")]
		public GiantFragment()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public static class GlobalSettings
	{
		[Token(Token = "0x200008A")]
		public enum GameDifficulty
		{
			[Token(Token = "0x40002A6")]
			Normal,
			[Token(Token = "0x40002A7")]
			Advanced
		}

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _muteMusic;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static GameDifficulty _difficulty;

		[Token(Token = "0x1700005E")]
		public static bool MuteMusic
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0xB98058", Offset = "0xB98058", VA = "0xB98058")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0xB980A0", Offset = "0xB980A0", VA = "0xB980A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public static GameDifficulty Difficulty
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0xB98118", Offset = "0xB98118", VA = "0xB98118")]
			get
			{
				return default(GameDifficulty);
			}
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0xB98160", Offset = "0xB98160", VA = "0xB98160")]
			set
			{
			}
		}

		[Token(Token = "0x14000006")]
		public static event Action MuteMusicChanged
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xB981D8", Offset = "0xB981D8", VA = "0xB981D8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xB98294", Offset = "0xB98294", VA = "0xB98294")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public static event Action GameDifficultyChanged
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xB98350", Offset = "0xB98350", VA = "0xB98350")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xB9840C", Offset = "0xB9840C", VA = "0xB9840C")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Token(Token = "0x200008B")]
	public enum ImpactType
	{
		[Token(Token = "0x40002A9")]
		Geode,
		[Token(Token = "0x40002AA")]
		Stone,
		[Token(Token = "0x40002AB")]
		Dirt,
		[Token(Token = "0x40002AC")]
		Wood
	}
	[Token(Token = "0x200008C")]
	[RequireComponent(typeof(CanvasGroup))]
	public class LateShowChildren : MonoBehaviour
	{
		[Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class <Delay>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LateShowChildren <>4__this;

			[Token(Token = "0x17000060")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002CC")]
				[Address(RVA = "0xB98738", Offset = "0xB98738", VA = "0xB98738", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000061")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002CE")]
				[Address(RVA = "0xB98780", Offset = "0xB98780", VA = "0xB98780", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0xB985AC", Offset = "0xB985AC", VA = "0xB985AC")]
			[DebuggerHidden]
			public <Delay>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0xB98604", Offset = "0xB98604", VA = "0xB98604", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0xB98608", Offset = "0xB98608", VA = "0xB98608", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0xB98740", Offset = "0xB98740", VA = "0xB98740", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float DelaySec;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float FadeSec;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xB984C8", Offset = "0xB984C8", VA = "0xB984C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xB98538", Offset = "0xB98538", VA = "0xB98538")]
		[IteratorStateMachine(typeof(<Delay>d__4))]
		private IEnumerator Delay()
		{
			return null;
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xB985D4", Offset = "0xB985D4", VA = "0xB985D4")]
		public LateShowChildren()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class IntroSubtitles : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008F")]
		private class SubtitleEntry
		{
			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float StartiIme;

			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float EndTime;

			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TextKey Text;

			[Token(Token = "0x60002D6")]
			[Address(RVA = "0xB98C08", Offset = "0xB98C08", VA = "0xB98C08")]
			public SubtitleEntry()
			{
			}
		}

		[Token(Token = "0x40002B3")]
		private const float FADE_IN = 0.3f;

		[Token(Token = "0x40002B4")]
		private const float FADE_OUT = 0.3f;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PlayableDirector _timeline;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LocalizedText _text;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RelativeHeight _relativeHeight;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SubtitleEntry[] _subtitles;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SubtitleEntry _currentSubtitle;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SubtitleEntry _nextSubtitle;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _index;

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xB98788", Offset = "0xB98788", VA = "0xB98788")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xB987B4", Offset = "0xB987B4", VA = "0xB987B4")]
		private void Update()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xB98840", Offset = "0xB98840", VA = "0xB98840")]
		private void ShowSubtitle()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xB989F0", Offset = "0xB989F0", VA = "0xB989F0")]
		private void HideSubtitle()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xB98BA8", Offset = "0xB98BA8", VA = "0xB98BA8")]
		public IntroSubtitles()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class LocalizationBase : MonoBehaviour
	{
		[Token(Token = "0x17000062")]
		protected SystemLanguage _currentLanguage
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0xB98C10", Offset = "0xB98C10", VA = "0xB98C10")]
			[CompilerGenerated]
			get
			{
				return default(SystemLanguage);
			}
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0xB98C18", Offset = "0xB98C18", VA = "0xB98C18")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xB98C20", Offset = "0xB98C20", VA = "0xB98C20", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xB98CB4", Offset = "0xB98CB4", VA = "0xB98CB4")]
		public LocalizationBase()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[DefaultExecutionOrder(-10000)]
	public class LocalizedText : LocalizationBase
	{
		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_FontAsset LociFont;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TMP_FontAsset LatinFont;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TMP_FontAsset ChineseTraditionalFont;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TMP_FontAsset ChineseSimplifiedFont;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TMP_FontAsset JapaneseFont;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TMP_FontAsset KoreanFont;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TMP_FontAsset ThaiFont;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		public TextMeshPro _text;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TMP_FontAsset _currentFont;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public TextKey Key;

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xB98CC4", Offset = "0xB98CC4", VA = "0xB98CC4", Slot = "4")]
		[ContextMenu("Localize")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xB98AD0", Offset = "0xB98AD0", VA = "0xB98AD0")]
		public void UpdateFont()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xB98D9C", Offset = "0xB98D9C", VA = "0xB98D9C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xB98DF4", Offset = "0xB98DF4", VA = "0xB98DF4")]
		public LocalizedText()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class LocalizedVisibility : LocalizationBase
	{
		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SystemLanguage[] _targetLanguages;

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xB98E04", Offset = "0xB98E04", VA = "0xB98E04", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xB98E80", Offset = "0xB98E80", VA = "0xB98E80")]
		public LocalizedVisibility()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class TaglineText : LocalizedText
	{
		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MeshRenderer _image;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private MaterialLink _link;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextMeshPro _otherText;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool _active;

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xB98E90", Offset = "0xB98E90", VA = "0xB98E90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xB98EF4", Offset = "0xB98EF4", VA = "0xB98EF4")]
		private void Update()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xB98FE0", Offset = "0xB98FE0", VA = "0xB98FE0")]
		public TaglineText()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public enum TextKey
	{
		[Token(Token = "0x40002D0")]
		None = -1,
		[Token(Token = "0x40002D1")]
		TitleTagline = 0,
		[Token(Token = "0x40002D2")]
		ResetAllProgress = 1,
		[Token(Token = "0x40002D3")]
		ResetLevel = 2,
		[Token(Token = "0x40002D4")]
		Controls = 3,
		[Token(Token = "0x40002D5")]
		OpenCloseMenu = 4,
		[Token(Token = "0x40002D6")]
		Hint = 5,
		[Token(Token = "0x40002D7")]
		Grab = 6,
		[Token(Token = "0x40002D8")]
		AreYouSure = 7,
		[Token(Token = "0x40002D9")]
		Yes = 8,
		[Token(Token = "0x40002DA")]
		No = 9,
		[Token(Token = "0x40002DB")]
		ThankYouForPlaying = 10,
		[Token(Token = "0x40002DC")]
		ManyWorldsToCome = 11,
		[Token(Token = "0x40002DD")]
		ProductionSupportTeam = 12,
		[Token(Token = "0x40002DE")]
		ProductionAssistant = 13,
		[Token(Token = "0x40002DF")]
		DesignAndBranding = 14,
		[Token(Token = "0x40002E0")]
		VideoEditing = 15,
		[Token(Token = "0x40002E1")]
		WebDevelopment = 16,
		[Token(Token = "0x40002E2")]
		DevelopmentSupportTeam = 17,
		[Token(Token = "0x40002E3")]
		ThreeDArtSupport = 18,
		[Token(Token = "0x40002E4")]
		CharacterDesign = 19,
		[Token(Token = "0x40002E5")]
		QA = 20,
		[Token(Token = "0x40002E6")]
		UX = 21,
		[Token(Token = "0x40002E7")]
		AnimationAdvisor = 22,
		[Token(Token = "0x40002E8")]
		AudioSupport = 23,
		[Token(Token = "0x40002E9")]
		CoreProductionTeam = 24,
		[Token(Token = "0x40002EA")]
		ExecutiveProducer = 25,
		[Token(Token = "0x40002EB")]
		SystemsEngineer = 26,
		[Token(Token = "0x40002EC")]
		Producer = 27,
		[Token(Token = "0x40002ED")]
		ProgramManager = 28,
		[Token(Token = "0x40002EE")]
		CreativeDirector = 29,
		[Token(Token = "0x40002EF")]
		GameDesign = 30,
		[Token(Token = "0x40002F0")]
		StoryAndConcept = 31,
		[Token(Token = "0x40002F1")]
		ArtAndMusic = 32,
		[Token(Token = "0x40002F2")]
		Advisors = 33,
		[Token(Token = "0x40002F3")]
		Intro_0 = 34,
		[Token(Token = "0x40002F4")]
		Intro_1 = 35,
		[Token(Token = "0x40002F5")]
		Intro_2 = 36,
		[Token(Token = "0x40002F6")]
		Intro_3 = 37,
		[Token(Token = "0x40002F7")]
		Intro_4 = 38,
		[Token(Token = "0x40002F8")]
		Intro_5 = 39,
		[Token(Token = "0x40002F9")]
		Intro_6 = 40,
		[Token(Token = "0x40002FA")]
		Intro_7 = 41,
		[Token(Token = "0x40002FB")]
		Intro_8 = 42,
		[Token(Token = "0x40002FC")]
		Intro_9 = 43,
		[Token(Token = "0x40002FD")]
		Intro_10 = 44,
		[Token(Token = "0x40002FE")]
		Intro_11 = 45,
		[Token(Token = "0x40002FF")]
		Intro_12 = 46,
		[Token(Token = "0x4000300")]
		Intro_13 = 47,
		[Token(Token = "0x4000301")]
		Difficulty = 1000,
		[Token(Token = "0x4000302")]
		Normal = 1001,
		[Token(Token = "0x4000303")]
		Advanced = 1002,
		[Token(Token = "0x4000304")]
		MuteSound = 1003,
		[Token(Token = "0x4000305")]
		Mute = 1004,
		[Token(Token = "0x4000306")]
		Unmute = 1005
	}
	[Token(Token = "0x2000095")]
	public static class TextLookup
	{
		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<TextKey, Dictionary<SystemLanguage, string>> LanguageMap;
	}
	[Token(Token = "0x2000096")]
	[DefaultExecutionOrder(-100)]
	public class Main : MonoBehaviour
	{
		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int speedOfLight;

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xB9F40C", Offset = "0xB9F40C", VA = "0xB9F40C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xB9F7F4", Offset = "0xB9F7F4", VA = "0xB9F7F4")]
		private void SetupInput()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xB9F894", Offset = "0xB9F894", VA = "0xB9F894")]
		private void Initialize()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xB9FA50", Offset = "0xB9FA50", VA = "0xB9FA50")]
		private void ConfigureCheats()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xB9FAB8", Offset = "0xB9FAB8", VA = "0xB9FAB8")]
		public Main()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[RequireComponent(typeof(Camera))]
	public class MainCamera : MonoBehaviour
	{
		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject RenderBlock;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera Camera;

		[Token(Token = "0x14000008")]
		public event Action Recenter
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xB9FAC0", Offset = "0xB9FAC0", VA = "0xB9FAC0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0xB9FB5C", Offset = "0xB9FB5C", VA = "0xB9FB5C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xB9FBF8", Offset = "0xB9FBF8", VA = "0xB9FBF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xB9FEC0", Offset = "0xB9FEC0", VA = "0xB9FEC0")]
		public void DevRecenter()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xB9FEDC", Offset = "0xB9FEDC", VA = "0xB9FEDC")]
		public MainCamera()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class MaterialManager : MonoBehaviour
	{
		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int _LeftHandPos;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int _LeftHandDir;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int _RightHandPos;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int _RightHandDir;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<Renderer, List<Tuple<int, Material>>> _originalMaterials;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<Material> _availableReplacements;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Tween<float> _leftActiveTween;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Tween<float> _rightActiveTween;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _leftActive;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _rightActive;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Tween<float> _seamTween;

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xB9FFFC", Offset = "0xB9FFFC", VA = "0xB9FFFC")]
		public void SetReplacementMaterials(Material[] materials)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xBA0054", Offset = "0xBA0054", VA = "0xBA0054")]
		public void ClearReplacementMaterials()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xBA00C4", Offset = "0xBA00C4", VA = "0xBA00C4")]
		public void SetControllerData(Handedness handedness, Vector3 position, Vector3 forward, bool active)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xBA039C", Offset = "0xBA039C", VA = "0xBA039C")]
		public void ReplaceMaterials(GameObject rendererRoot)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xBA07A8", Offset = "0xBA07A8", VA = "0xBA07A8")]
		public void RevertMaterials(GameObject rendererRoot)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xBA0698", Offset = "0xBA0698", VA = "0xBA0698")]
		private Material GetOverrideMaterial(Material material)
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xBA098C", Offset = "0xBA098C", VA = "0xBA098C")]
		public MaterialManager()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class MessageBus
	{
		[Token(Token = "0x200009C")]
		private class Bindings
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0xBA0C28", Offset = "0xBA0C28", VA = "0xBA0C28")]
			public Bindings()
			{
			}
		}

		[Token(Token = "0x200009D")]
		private class Bindings<T> : Bindings
		{
			[Token(Token = "0x400031C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly List<Callback<T>> Callbacks;

			[Token(Token = "0x6000305")]
			public void Add(Callback<T> callback)
			{
			}

			[Token(Token = "0x6000306")]
			public void Remove(Action<T> callback)
			{
			}

			[Token(Token = "0x6000307")]
			public Bindings()
			{
			}
		}

		[Token(Token = "0x200009E")]
		private class Callback<T>
		{
			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> Action;

			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool InvokeOnce;

			[Token(Token = "0x6000308")]
			public Callback()
			{
			}
		}

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<Type, Bindings> _bindings;

		[Token(Token = "0x60002FE")]
		public void Subscribe<T>(Action<T> callback) where T : Message
		{
		}

		[Token(Token = "0x60002FF")]
		public void SubscribeOnce<T>(Action<T> callback) where T : Message
		{
		}

		[Token(Token = "0x6000300")]
		public void Unsubscribe<T>(Action<T> callback) where T : Message
		{
		}

		[Token(Token = "0x6000301")]
		public void Broadcast<T>(T message) where T : Message
		{
		}

		[Token(Token = "0x6000302")]
		private Bindings<T> GetBindings<T>()
		{
			return null;
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xBA0BA0", Offset = "0xBA0BA0", VA = "0xBA0BA0")]
		public MessageBus()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public abstract class Message
	{
		[Token(Token = "0x6000309")]
		[Address(RVA = "0xBA0C30", Offset = "0xBA0C30", VA = "0xBA0C30")]
		protected Message()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public abstract class ChapterMessage : Message
	{
		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ChapterIndex ChapterIndex;

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xBA0C38", Offset = "0xBA0C38", VA = "0xBA0C38")]
		protected ChapterMessage()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class GamePause : Message
	{
		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool PauseState;

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xBA0C40", Offset = "0xBA0C40", VA = "0xBA0C40")]
		public GamePause()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class ChapterLoad_Start : ChapterMessage
	{
		[Token(Token = "0x600030C")]
		[Address(RVA = "0xBA0C48", Offset = "0xBA0C48", VA = "0xBA0C48")]
		public ChapterLoad_Start()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class ChapterLoad_Complete : ChapterMessage
	{
		[Token(Token = "0x600030D")]
		[Address(RVA = "0xBA0C50", Offset = "0xBA0C50", VA = "0xBA0C50")]
		public ChapterLoad_Complete()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class ChapterUnlocked : ChapterMessage
	{
		[Token(Token = "0x600030E")]
		[Address(RVA = "0xBA0C58", Offset = "0xBA0C58", VA = "0xBA0C58")]
		public ChapterUnlocked()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class ChapterComplete : ChapterMessage
	{
		[Token(Token = "0x600030F")]
		[Address(RVA = "0xBA0C60", Offset = "0xBA0C60", VA = "0xBA0C60")]
		public ChapterComplete()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class MenuToggle : Message
	{
		[Token(Token = "0x6000310")]
		[Address(RVA = "0xBA0C68", Offset = "0xBA0C68", VA = "0xBA0C68")]
		public MenuToggle()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class HintShow : Message
	{
		[Token(Token = "0x6000311")]
		[Address(RVA = "0xBA0C70", Offset = "0xBA0C70", VA = "0xBA0C70")]
		public HintShow()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class MenuUpdated : Message
	{
		[Token(Token = "0x6000312")]
		[Address(RVA = "0xBA0C78", Offset = "0xBA0C78", VA = "0xBA0C78")]
		public MenuUpdated()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class ResetChapter : Message
	{
		[Token(Token = "0x6000313")]
		[Address(RVA = "0xBA0C80", Offset = "0xBA0C80", VA = "0xBA0C80")]
		public ResetChapter()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class ResetGame : Message
	{
		[Token(Token = "0x6000314")]
		[Address(RVA = "0xBA0C88", Offset = "0xBA0C88", VA = "0xBA0C88")]
		public ResetGame()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class TogglePause : Message
	{
		[Token(Token = "0x6000315")]
		[Address(RVA = "0xBA0C90", Offset = "0xBA0C90", VA = "0xBA0C90")]
		public TogglePause()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class ForceUnpause : Message
	{
		[Token(Token = "0x6000316")]
		[Address(RVA = "0xBA0C98", Offset = "0xBA0C98", VA = "0xBA0C98")]
		public ForceUnpause()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class HackUnlock : Message
	{
		[Token(Token = "0x6000317")]
		[Address(RVA = "0xBA0CA0", Offset = "0xBA0CA0", VA = "0xBA0CA0")]
		public HackUnlock()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class HackCredits : Message
	{
		[Token(Token = "0x6000318")]
		[Address(RVA = "0xBA0CA8", Offset = "0xBA0CA8", VA = "0xBA0CA8")]
		public HackCredits()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class Miniature : Seeker
	{
		[Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class <Move>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400032B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Path path;

			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Miniature <>4__this;

			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <waypoint>5__2;

			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 <graphWaypointPos>5__3;

			[Token(Token = "0x17000063")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000325")]
				[Address(RVA = "0xBA1820", Offset = "0xBA1820", VA = "0xBA1820", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000064")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000327")]
				[Address(RVA = "0xBA1868", Offset = "0xBA1868", VA = "0xBA1868", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0xBA1234", Offset = "0xBA1234", VA = "0xBA1234")]
			[DebuggerHidden]
			public <Move>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000323")]
			[Address(RVA = "0xBA1440", Offset = "0xBA1440", VA = "0xBA1440", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000324")]
			[Address(RVA = "0xBA1444", Offset = "0xBA1444", VA = "0xBA1444", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000326")]
			[Address(RVA = "0xBA1828", Offset = "0xBA1828", VA = "0xBA1828", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class <Dwell>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Miniature <>4__this;

			[Token(Token = "0x17000065")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600032B")]
				[Address(RVA = "0xBA1998", Offset = "0xBA1998", VA = "0xBA1998", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600032D")]
				[Address(RVA = "0xBA19E0", Offset = "0xBA19E0", VA = "0xBA19E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000328")]
			[Address(RVA = "0xBA12D0", Offset = "0xBA12D0", VA = "0xBA12D0")]
			[DebuggerHidden]
			public <Dwell>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000329")]
			[Address(RVA = "0xBA1870", Offset = "0xBA1870", VA = "0xBA1870", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600032A")]
			[Address(RVA = "0xBA1874", Offset = "0xBA1874", VA = "0xBA1874", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0xBA19A0", Offset = "0xBA19A0", VA = "0xBA19A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int Walk;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Transform _tr;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Animator _animator;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private NavMeshGraph _graph;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Transform _chunkTransform;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Matrix4x4 _chunkWorldToLocal;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Matrix4x4 _chunkLocalToWorld;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public float Speed;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public float WaypointDist;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public Vector2 DwellRange;

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xBA0CB0", Offset = "0xBA0CB0", VA = "0xBA0CB0", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xBA1020", Offset = "0xBA1020", VA = "0xBA1020")]
		[ContextMenu("Random Move!")]
		public void StartRandomMove()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xBA11A4", Offset = "0xBA11A4", VA = "0xBA11A4")]
		[IteratorStateMachine(typeof(<Move>d__12))]
		private IEnumerator Move(Path path)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xBA125C", Offset = "0xBA125C", VA = "0xBA125C")]
		[IteratorStateMachine(typeof(<Dwell>d__13))]
		private IEnumerator Dwell()
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xBA1174", Offset = "0xBA1174", VA = "0xBA1174")]
		private Vector3 CurrentToGraph(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xBA0FF4", Offset = "0xBA0FF4", VA = "0xBA0FF4")]
		private Vector3 GraphToCurrent(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xBA12F8", Offset = "0xBA12F8", VA = "0xBA12F8")]
		public Miniature()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public static class MiniatureSpawner
	{
		[Token(Token = "0x600032E")]
		[Address(RVA = "0xBA0E08", Offset = "0xBA0E08", VA = "0xBA0E08")]
		public static NavMeshGraph ResolveGraph(PrefixedPuzzleChunk chunk)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B3")]
	public class ChapterCapstone : SymbolCapstone
	{
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int Fill;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int BaseColor;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Renderer _progressRenderer;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Material _dotMaterial;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _inactiveColor;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[ColorUsage(false, true)]
		[SerializeField]
		private Color _activeColor;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material _material;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public ChapterData ChapterData;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool? _prevUnlockState;

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xBA19E8", Offset = "0xBA19E8", VA = "0xBA19E8")]
		private new void Awake()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xBA1A80", Offset = "0xBA1A80", VA = "0xBA1A80", Slot = "6")]
		public override BaseTween Open(TweenConfig config)
		{
			return null;
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xBA1AAC", Offset = "0xBA1AAC", VA = "0xBA1AAC")]
		public void CalculateProgress()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xBA1E90", Offset = "0xBA1E90", VA = "0xBA1E90")]
		private int GetTotalSnaps(ChapterIndex index)
		{
			return default(int);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xBA1F38", Offset = "0xBA1F38", VA = "0xBA1F38")]
		public ChapterCapstone()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class DisplayCapstone : SymbolCapstone
	{
		[Token(Token = "0x20000B5")]
		[CompilerGenerated]
		private sealed class <ChangeDisplay>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DisplayCapstone <>4__this;

			[Token(Token = "0x17000067")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600033F")]
				[Address(RVA = "0xBA2878", Offset = "0xBA2878", VA = "0xBA2878", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000341")]
				[Address(RVA = "0xBA28C0", Offset = "0xBA28C0", VA = "0xBA28C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600033C")]
			[Address(RVA = "0xBA25C8", Offset = "0xBA25C8", VA = "0xBA25C8")]
			[DebuggerHidden]
			public <ChangeDisplay>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600033D")]
			[Address(RVA = "0xBA2644", Offset = "0xBA2644", VA = "0xBA2644", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600033E")]
			[Address(RVA = "0xBA2648", Offset = "0xBA2648", VA = "0xBA2648", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000340")]
			[Address(RVA = "0xBA2880", Offset = "0xBA2880", VA = "0xBA2880", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ControllerGuide _visual;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _closedPosition;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _openPosition;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Inject]
		private ChapterRunner _runner;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _open;

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xBA20A8", Offset = "0xBA20A8", VA = "0xBA20A8", Slot = "6")]
		public override BaseTween Open(TweenConfig config)
		{
			return null;
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xBA2384", Offset = "0xBA2384", VA = "0xBA2384", Slot = "7")]
		public override BaseTween Close(TweenConfig config)
		{
			return null;
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xBA2554", Offset = "0xBA2554", VA = "0xBA2554")]
		[IteratorStateMachine(typeof(<ChangeDisplay>d__7))]
		private IEnumerator ChangeDisplay()
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xBA25F0", Offset = "0xBA25F0", VA = "0xBA25F0")]
		public DisplayCapstone()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class MenuCapstone : SymbolCapstone
	{
		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TextKey _textKey;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private LocalizedText _text;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _default;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _confirm;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private MorphButton _menuButton;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MorphButton _confirmButton;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private MorphButton _cancelButton;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _showAreYouSure;

		[Token(Token = "0x14000009")]
		public event Action OptionActivated
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0xBA28C8", Offset = "0xBA28C8", VA = "0xBA28C8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000343")]
			[Address(RVA = "0xBA2964", Offset = "0xBA2964", VA = "0xBA2964")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event Action OptionCanceled
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0xBA2A00", Offset = "0xBA2A00", VA = "0xBA2A00")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000345")]
			[Address(RVA = "0xBA2A9C", Offset = "0xBA2A9C", VA = "0xBA2A9C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xBA2B38", Offset = "0xBA2B38", VA = "0xBA2B38")]
		private new void Awake()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xBA2CF8", Offset = "0xBA2CF8", VA = "0xBA2CF8", Slot = "6")]
		public override BaseTween Open(TweenConfig config)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xBA2F10", Offset = "0xBA2F10", VA = "0xBA2F10", Slot = "7")]
		public override BaseTween Close(TweenConfig config)
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xBA305C", Offset = "0xBA305C", VA = "0xBA305C")]
		[ContextMenu("Show Default")]
		private void ShowDefault()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xBA30AC", Offset = "0xBA30AC", VA = "0xBA30AC")]
		[ContextMenu("Show Confirm")]
		private void ShowConfirm()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xBA2DB4", Offset = "0xBA2DB4", VA = "0xBA2DB4")]
		private void HideAll()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xBA310C", Offset = "0xBA310C", VA = "0xBA310C")]
		public MenuCapstone()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class SymbolCapstone : InjectableMonobehavior
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 IdlePosition;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 IdleRotation;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 FacingPosition;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 FacingRotation;

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xBA2DEC", Offset = "0xBA2DEC", VA = "0xBA2DEC", Slot = "6")]
		public virtual BaseTween Open(TweenConfig config)
		{
			return null;
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xBA2F38", Offset = "0xBA2F38", VA = "0xBA2F38", Slot = "7")]
		public virtual BaseTween Close(TweenConfig config)
		{
			return null;
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xBA311C", Offset = "0xBA311C", VA = "0xBA311C")]
		public SymbolCapstone()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class SymbolPlatform : InjectableMonobehavior
	{
		[Serializable]
		[Token(Token = "0x20000B9")]
		private class Appearance
		{
			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material CapstoneMaterial;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject[] Visuals;

			[Token(Token = "0x6000373")]
			[Address(RVA = "0xBA6354", Offset = "0xBA6354", VA = "0xBA6354")]
			public Appearance()
			{
			}
		}

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int _EmissionColor;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("General")]
		[SerializeField]
		private Transform _rotateRoot;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[ColorUsage(false, true)]
		[SerializeField]
		private Color _activeColor;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TweenConfig _openTween;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TweenConfig _closeTween;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GeodeMenu _geodeMenu;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Quaternion _tutorialRotation;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Quaternion _defaultRotation;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Header("Appearance")]
		private Renderer[] _capstoneRenderers;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Appearance _darkStone;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Appearance _lightStone;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Appearance _wooden;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Appearance _mosaic;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Header("Capstones")]
		[SerializeField]
		private SymbolCapstone[] _capstones;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ParticleSystem[] _capstoneVFX;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private MenuCapstone _resetAllCapstone;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private MenuCapstone _resetLevelCapstone;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private MenuCapstone _audioCapstone;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private MenuCapstone _difficultyCapstone;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Inject]
		private ChapterRunner _runner;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Inject]
		private MessageBus _msgBus;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Inject]
		private SaveService _saveService;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Inject]
		private Audio _audio;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Inject]
		private AchievementService _achievementService;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Appearance _activeAppearance;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material _activeMat;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool _tweening;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		private bool _allowUsage;

		[Token(Token = "0x17000069")]
		public bool IsOpen
		{
			[Token(Token = "0x6000352")]
			[Address(RVA = "0xBA377C", Offset = "0xBA377C", VA = "0xBA377C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000353")]
			[Address(RVA = "0xBA3784", Offset = "0xBA3784", VA = "0xBA3784")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public bool AllowUsage
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0xBA3790", Offset = "0xBA3790", VA = "0xBA3790")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000355")]
			[Address(RVA = "0xBA3798", Offset = "0xBA3798", VA = "0xBA3798")]
			set
			{
			}
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xBA3C9C", Offset = "0xBA3C9C", VA = "0xBA3C9C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xBA44DC", Offset = "0xBA44DC", VA = "0xBA44DC")]
		[ContextMenu("Toggle Openness")]
		public void Toggle()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xBA4650", Offset = "0xBA4650", VA = "0xBA4650")]
		public BaseTween Open()
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xBA3874", Offset = "0xBA3874", VA = "0xBA3874")]
		public BaseTween Close(bool slowVariant = false)
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xBA43F8", Offset = "0xBA43F8", VA = "0xBA43F8")]
		private void SetCapstoneData()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xBA51B8", Offset = "0xBA51B8", VA = "0xBA51B8")]
		private void ChapterLoad_Start(ChapterLoad_Start msg)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xBA54EC", Offset = "0xBA54EC", VA = "0xBA54EC")]
		private void ChapterLoad_Complete(ChapterLoad_Complete msg)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xBA5268", Offset = "0xBA5268", VA = "0xBA5268")]
		private void UpdateAppearance(ChapterIndex index)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xBA550C", Offset = "0xBA550C", VA = "0xBA550C")]
		private SymbolCapstone CapstoneForChapter(ChapterIndex index)
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xBA5540", Offset = "0xBA5540", VA = "0xBA5540")]
		public SymbolPlatform()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class NotificationManager : InjectableMonobehavior
	{
		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _congratulatory;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Inject]
		private MainCamera _camera;

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xBA65CC", Offset = "0xBA65CC", VA = "0xBA65CC")]
		public void Congratulatory(string msg)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xBA6718", Offset = "0xBA6718", VA = "0xBA6718")]
		public NotificationManager()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class OutroPortal : InjectableMonobehavior
	{
		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PlayableDirector _director;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MaterialLink _materialLink;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Material _material;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Audio")]
		[SerializeField]
		private bool _useVariableTracks;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AudioSource _ch3;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioSource _ch4;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _ch5;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Destination Skyboxes")]
		[SerializeField]
		private Texture2D _default;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Texture2D _chapter1;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Texture2D _chapter2;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Texture2D _chapter3;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Texture2D _chapter4;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _useV1;

		[Token(Token = "0x1400000B")]
		public event Action PortalComplete
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0xBA6720", Offset = "0xBA6720", VA = "0xBA6720")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000381")]
			[Address(RVA = "0xBA67BC", Offset = "0xBA67BC", VA = "0xBA67BC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xBA6858", Offset = "0xBA6858", VA = "0xBA6858")]
		public void StartEffect(ChapterIndex destination)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xBA6BD0", Offset = "0xBA6BD0", VA = "0xBA6BD0")]
		public void OnAnimationComplete()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xBA6B1C", Offset = "0xBA6B1C", VA = "0xBA6B1C")]
		private void UpdateTexture(Texture2D texture)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xBA6C04", Offset = "0xBA6C04", VA = "0xBA6C04")]
		[ContextMenu("Default")]
		private void SetDefault()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xBA6C0C", Offset = "0xBA6C0C", VA = "0xBA6C0C")]
		[ContextMenu("Set Chapter 1")]
		private void SetChapter1()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xBA6C14", Offset = "0xBA6C14", VA = "0xBA6C14")]
		[ContextMenu("Set Chapter 2")]
		private void SetChapter2()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xBA6C1C", Offset = "0xBA6C1C", VA = "0xBA6C1C")]
		[ContextMenu("Set Chapter 3")]
		private void SetChapter3()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xBA6C24", Offset = "0xBA6C24", VA = "0xBA6C24")]
		[ContextMenu("Set Chapter 4")]
		private void SetChapter4()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xBA6C2C", Offset = "0xBA6C2C", VA = "0xBA6C2C")]
		public OutroPortal()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class PauseManager : InjectableMonobehavior
	{
		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Inject]
		private MessageBus _msgBus;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Inject]
		private MainCamera _mainCamera;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Inject]
		private Audio _audio;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _text;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _greyOut;

		[Token(Token = "0x1700006B")]
		public bool Paused
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0xBA6C34", Offset = "0xBA6C34", VA = "0xBA6C34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600038C")]
			[Address(RVA = "0xBA6C3C", Offset = "0xBA6C3C", VA = "0xBA6C3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xBA6C48", Offset = "0xBA6C48", VA = "0xBA6C48", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xBA6D7C", Offset = "0xBA6D7C", VA = "0xBA6D7C")]
		private void OnApplicationFocus(bool paused)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xBA6E24", Offset = "0xBA6E24", VA = "0xBA6E24")]
		private void Toggle(TogglePause _)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xBA706C", Offset = "0xBA706C", VA = "0xBA706C")]
		public PauseManager()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class PuzzleLoader : MonoBehaviour
	{
		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _levelIndex;

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xBA7084", Offset = "0xBA7084", VA = "0xBA7084")]
		public void AssembleAround(PuzzleManager level, SpawnVolume spawnVolume)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xBA7540", Offset = "0xBA7540", VA = "0xBA7540")]
		public PuzzleLoader()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[DefaultExecutionOrder(100)]
	public class RelativeHeight : InjectableMonobehavior
	{
		[Token(Token = "0x4000392")]
		private const float SAMPLE_RATE = 0.01f;

		[Token(Token = "0x4000393")]
		private const float SAMPLE_DURATION = 1f;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Inject]
		private MainCamera _mainCamera;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float[] _buffer;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static float _lastSampleTime;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static int _bufferIndex;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _updateEveryFrame;

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xBA7550", Offset = "0xBA7550", VA = "0xBA7550", Slot = "5")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xBA77B0", Offset = "0xBA77B0", VA = "0xBA77B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xBA76D4", Offset = "0xBA76D4", VA = "0xBA76D4")]
		public void OnRecenter()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xBA7950", Offset = "0xBA7950", VA = "0xBA7950")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xBA783C", Offset = "0xBA783C", VA = "0xBA783C")]
		private void AdjustHeight()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xBA7A64", Offset = "0xBA7A64", VA = "0xBA7A64")]
		public RelativeHeight()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class RendererSettings : MonoBehaviour
	{
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RendererSettings _instance;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScriptableRendererFeature _feature;

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xBA7B28", Offset = "0xBA7B28", VA = "0xBA7B28")]
		private void Awake()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xBA7B80", Offset = "0xBA7B80", VA = "0xBA7B80")]
		public static void EnableReflectionPass()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xBA7BE0", Offset = "0xBA7BE0", VA = "0xBA7BE0")]
		public static void DisableReflectionPass()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xBA7C3C", Offset = "0xBA7C3C", VA = "0xBA7C3C")]
		public RendererSettings()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	[ExecuteInEditMode]
	public class Rotator : MonoBehaviour
	{
		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 RotateSpeed;

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xBA7C44", Offset = "0xBA7C44", VA = "0xBA7C44")]
		private void Update()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xBA7CA4", Offset = "0xBA7CA4", VA = "0xBA7CA4")]
		public Rotator()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class SaveData
	{
		[Token(Token = "0x400039C")]
		public const int LATEST_FORMAT_VERSION = 53;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int SaveFormatVersion;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool InputTutorialCompleted;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ChapterData[] Chapters;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ChapterData[] MiniChapters;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PlayData PlayData;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool[] Achievements;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool MuteMusic;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public GlobalSettings.GameDifficulty Difficulty;

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xBA7CAC", Offset = "0xBA7CAC", VA = "0xBA7CAC")]
		public void InitializeToDefaults()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xBA7E5C", Offset = "0xBA7E5C", VA = "0xBA7E5C")]
		public SaveData()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class ChapterData
	{
		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int ChapterIndex;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool Unlocked;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool Complete;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuzzleData[] Puzzles;

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xBA7E4C", Offset = "0xBA7E4C", VA = "0xBA7E4C")]
		public ChapterData()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class PuzzleData
	{
		[Token(Token = "0x20000C7")]
		public enum CompletionStatus
		{
			[Token(Token = "0x40003AF")]
			NotStarted,
			[Token(Token = "0x40003B0")]
			InProgress,
			[Token(Token = "0x40003B1")]
			Complete
		}

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CompletionStatus Completion;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int PuzzleSaveVersion;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int ActiveBatch;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PieceData[] PieceData;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int SnapsMade;

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xBA7F54", Offset = "0xBA7F54", VA = "0xBA7F54")]
		public PuzzleData()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class PieceData
	{
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Id;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool Connected;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GroupIdentifier;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 Position;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Quaternion Rotation;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Scale;

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xBA7F64", Offset = "0xBA7F64", VA = "0xBA7F64")]
		public PieceData()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class PlayData
	{
		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int HintsUsed;

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xBA7E54", Offset = "0xBA7E54", VA = "0xBA7E54")]
		public PlayData()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class SaveService
	{
		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string SAVE_PATH;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private SaveData _cached;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _activeChapter;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool _recursiveGuard;

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xBA7F74", Offset = "0xBA7F74", VA = "0xBA7F74")]
		public SaveService()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xBA8008", Offset = "0xBA8008", VA = "0xBA8008")]
		public SaveData Load()
		{
			return null;
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xBA5768", Offset = "0xBA5768", VA = "0xBA5768")]
		public void DeleteAll()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xBA597C", Offset = "0xBA597C", VA = "0xBA597C")]
		public void DeleteChapter(ChapterIndex chapter)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xBA8A8C", Offset = "0xBA8A8C", VA = "0xBA8A8C")]
		public bool GetTutorialComplete()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xBA8AA8", Offset = "0xBA8AA8", VA = "0xBA8AA8")]
		public bool IsGameComplete()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xBA8B08", Offset = "0xBA8B08", VA = "0xBA8B08")]
		public void SetTutorialComplete(bool complete)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xBA8BE4", Offset = "0xBA8BE4", VA = "0xBA8BE4")]
		public bool GetAchievementUnlocked(AchievementService.Achievement achievement)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xBA8C1C", Offset = "0xBA8C1C", VA = "0xBA8C1C")]
		public void SetAchievementUnlocked(AchievementService.Achievement achievement)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xBA8C58", Offset = "0xBA8C58", VA = "0xBA8C58")]
		public ChapterData GetData(ChapterIndex index)
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xBA5070", Offset = "0xBA5070", VA = "0xBA5070")]
		public ChapterData GetData(int chapter)
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xBA8C5C", Offset = "0xBA8C5C", VA = "0xBA8C5C")]
		public void SetActive(int chapterIndex)
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xBA8D24", Offset = "0xBA8D24", VA = "0xBA8D24")]
		public void UpdateData(int puzzle, PuzzleData data)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xBA5B68", Offset = "0xBA5B68", VA = "0xBA5B68")]
		public void UnlockChapter(ChapterIndex index)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xBA9078", Offset = "0xBA9078", VA = "0xBA9078")]
		public void CompleteChapter(ChapterIndex index)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xBA9120", Offset = "0xBA9120", VA = "0xBA9120")]
		public bool IsChapterUnlocked(ChapterIndex index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xBA91BC", Offset = "0xBA91BC", VA = "0xBA91BC")]
		public bool IsChapterComplete(ChapterIndex index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xBA9258", Offset = "0xBA9258", VA = "0xBA9258")]
		public void HintUsed()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xBA9284", Offset = "0xBA9284", VA = "0xBA9284")]
		public int GetHints()
		{
			return default(int);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xBA92A8", Offset = "0xBA92A8", VA = "0xBA92A8")]
		private void OnGlobalChanged()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xBA87EC", Offset = "0xBA87EC", VA = "0xBA87EC")]
		private void WriteToDisk()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xBA8684", Offset = "0xBA8684", VA = "0xBA8684")]
		public static void DeleteOnDisk()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class Skipper : MonoBehaviour
	{
		[Token(Token = "0x20000CC")]
		public enum SkipType
		{
			[Token(Token = "0x40003C2")]
			Puzzle,
			[Token(Token = "0x40003C3")]
			Timeline,
			[Token(Token = "0x40003C4")]
			Geode
		}

		[Token(Token = "0x40003BD")]
		private const float SKIP_DELAY_ENFORCE_SEC = 0.5f;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _lastSkipTime;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private SkipType _type;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action _skip;

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xBA93C8", Offset = "0xBA93C8", VA = "0xBA93C8")]
		public void RegisterNext(SkipType type, Action action)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xBA93D8", Offset = "0xBA93D8", VA = "0xBA93D8")]
		public void Clear(SkipType type)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xBA93F4", Offset = "0xBA93F4", VA = "0xBA93F4")]
		public void Skip()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xBA9448", Offset = "0xBA9448", VA = "0xBA9448")]
		public Skipper()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class SmoothTrack : MonoBehaviour
	{
		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _target;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _positionPool;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _rotationPool;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] PositionPool;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3[] ForwardPool;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] UpPool;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _positionIndex;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _rotationIndex;

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xBA9450", Offset = "0xBA9450", VA = "0xBA9450")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xBA94E0", Offset = "0xBA94E0", VA = "0xBA94E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xBA97B0", Offset = "0xBA97B0", VA = "0xBA97B0")]
		public SmoothTrack()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	[ExecuteInEditMode]
	public class Temp : MonoBehaviour
	{
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xBA97C4", Offset = "0xBA97C4", VA = "0xBA97C4")]
		[ContextMenu("Face Origin")]
		private void FaceOrigin()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xBA982C", Offset = "0xBA982C", VA = "0xBA982C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xBA9894", Offset = "0xBA9894", VA = "0xBA9894")]
		public Temp()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class TimelineSkipper : InjectableMonobehavior
	{
		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Inject]
		private Skipper _skipper;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlayableDirector _timeline;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _registeredSkip;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector2[] _skipFrames;

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xBA989C", Offset = "0xBA989C", VA = "0xBA989C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xBA990C", Offset = "0xBA990C", VA = "0xBA990C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xBA9AFC", Offset = "0xBA9AFC", VA = "0xBA9AFC")]
		public TimelineSkipper()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class Unlockable : MonoBehaviour
	{
		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshPro _text;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _particles;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _preview;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float GiantScale;

		[Token(Token = "0x1400000C")]
		public event Action PresentComplete
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0xBA9B44", Offset = "0xBA9B44", VA = "0xBA9B44")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0xBA9BE0", Offset = "0xBA9BE0", VA = "0xBA9BE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xBA9C7C", Offset = "0xBA9C7C", VA = "0xBA9C7C")]
		public void Present()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xBA9D60", Offset = "0xBA9D60", VA = "0xBA9D60")]
		public Unlockable()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class DontDestroyOnLoad : MonoBehaviour
	{
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xBAA490", Offset = "0xBAA490", VA = "0xBAA490")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xBAA4FC", Offset = "0xBAA4FC", VA = "0xBAA4FC")]
		public DontDestroyOnLoad()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	[ExecuteInEditMode]
	public class FogController : MonoBehaviour
	{
		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Enabled;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Color Color;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 0.05f)]
		public float Density;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(1f, 10f)]
		public float DensityMultiplier;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Header("Linear (Unused?)")]
		public float StartDistance;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float EndDistance;

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xBAA504", Offset = "0xBAA504", VA = "0xBAA504")]
		private void Start()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xBAA558", Offset = "0xBAA558", VA = "0xBAA558")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xBAA5A8", Offset = "0xBAA5A8", VA = "0xBAA5A8")]
		public FogController()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	[ExecuteInEditMode]
	public class SkyboxController : MonoBehaviour
	{
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int _Transition;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int _Tint1;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int _Tint2;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int _Exposure1;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int _Exposure2;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material SkyboxMaterial;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Transition;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color Tint1;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color Tint2;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float Exposure1;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float Exposure2;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float ReflectionIntensity;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _transition;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Color _tint1;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Color _tint2;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _exposure1;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _exposure2;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _reflectionIntensity;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xBAA5B8", Offset = "0xBAA5B8", VA = "0xBAA5B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xBAA834", Offset = "0xBAA834", VA = "0xBAA834")]
		public SkyboxController()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public enum VFXType
	{
		[Token(Token = "0x40003F1")]
		SnapEnd,
		[Token(Token = "0x40003F2")]
		ObjectRelocate,
		[Token(Token = "0x40003F3")]
		WaterImpact,
		[Token(Token = "0x40003F4")]
		WaterTrail,
		[Token(Token = "0x40003F5")]
		GeodeUnformed,
		[Token(Token = "0x40003F6")]
		WaterInstant,
		[Token(Token = "0x40003F7")]
		SnapFinale
	}
	[Token(Token = "0x20000D6")]
	public class VFXManager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D7")]
		public class EffectConfig
		{
			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public VFXType Type;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ParticleSystem EffectPrefab;

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0xBAAFFC", Offset = "0xBAAFFC", VA = "0xBAAFFC")]
			public EffectConfig()
			{
			}
		}

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EffectConfig[] _effects;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<VFXType, ParticleSystem> _effectLookup;

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xBAA96C", Offset = "0xBAA96C", VA = "0xBAA96C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xBAAA04", Offset = "0xBAAA04", VA = "0xBAAA04")]
		public void OneshotEffect(VFXType type, Vector3 initWorldPosition, float scale = 1f)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xBAAC3C", Offset = "0xBAAC3C", VA = "0xBAAC3C")]
		public Action PersistentEffect(VFXType type, Transform transform, Vector3 initWorldPosition, float scale)
		{
			return null;
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xBAAE84", Offset = "0xBAAE84", VA = "0xBAAE84")]
		public Transform SpawnUnmanaged(VFXType type, Vector3 initWorldPosition)
		{
			return null;
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xBAAF74", Offset = "0xBAAF74", VA = "0xBAAF74")]
		public VFXManager()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class ViewableRegion : MonoBehaviour
	{
		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SpawnVolume Volume;

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xBAB4F8", Offset = "0xBAB4F8", VA = "0xBAB4F8")]
		public ViewableRegion()
		{
		}
	}
}
namespace Loci.Util
{
	[Token(Token = "0x20000DD")]
	public class Bootstrapper : MonoBehaviour
	{
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xBAB500", Offset = "0xBAB500", VA = "0xBAB500")]
		public void Run(IEnumerator coroutine)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xBAB508", Offset = "0xBAB508", VA = "0xBAB508")]
		public void Run(Action action, float delayMs)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xBAB620", Offset = "0xBAB620", VA = "0xBAB620")]
		public Bootstrapper()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public static class DI
	{
		[Token(Token = "0x20000E1")]
		private class Binding
		{
			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type Type;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object Instance;

			[Token(Token = "0x6000409")]
			[Address(RVA = "0xBAC0BC", Offset = "0xBAC0BC", VA = "0xBAC0BC")]
			public Binding()
			{
			}
		}

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, Binding> _bindings;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly List<Type> _scratch;

		[Token(Token = "0x60003FF")]
		public static void Bind<T>()
		{
		}

		[Token(Token = "0x6000400")]
		public static void Bind<T>(T instance)
		{
		}

		[Token(Token = "0x6000401")]
		public static void Bind<T, K>()
		{
		}

		[Token(Token = "0x6000402")]
		public static void Bind<T, K>(K instance)
		{
		}

		[Token(Token = "0x6000403")]
		public static void SceneInstance<T>(bool required = true) where T : UnityEngine.Object
		{
		}

		[Token(Token = "0x6000404")]
		public static T Build<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xBAB77C", Offset = "0xBAB77C", VA = "0xBAB77C")]
		private static object Resolve(Type type, bool bindingRequired)
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xBABA90", Offset = "0xBABA90", VA = "0xBABA90")]
		private static object Construct(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xBABCEC", Offset = "0xBABCEC", VA = "0xBABCEC")]
		public static void Inject(object target)
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[AttributeUsage(AttributeTargets.Field)]
	public class Inject : Attribute
	{
		[Token(Token = "0x600040D")]
		[Address(RVA = "0xBAC1C4", Offset = "0xBAC1C4", VA = "0xBAC1C4")]
		public Inject()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public abstract class InjectableMonobehavior : MonoBehaviour
	{
		[Token(Token = "0x17000072")]
		protected bool _initialized
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0xBAC1CC", Offset = "0xBAC1CC", VA = "0xBAC1CC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600040F")]
			[Address(RVA = "0xBAC1D4", Offset = "0xBAC1D4", VA = "0xBAC1D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xBA43E0", Offset = "0xBA43E0", VA = "0xBA43E0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xBA7664", Offset = "0xBA7664", VA = "0xBA7664", Slot = "5")]
		public virtual void Initialize()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xBA3774", Offset = "0xBA3774", VA = "0xBA3774")]
		protected InjectableMonobehavior()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public static class Layers
	{
		[Token(Token = "0x4000412")]
		public const int DEFAULT = 0;

		[Token(Token = "0x4000413")]
		public const int INTERACTABLE = 6;
	}
	[Token(Token = "0x20000E6")]
	[DefaultExecutionOrder(1)]
	[ExecuteInEditMode]
	public class MaterialPositionSetter : MonoBehaviour
	{
		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int StartPosWs;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Renderer _renderer;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material _material1;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material _material2;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _stencilAlways;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool StencilAlways;

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xBAC1E0", Offset = "0xBAC1E0", VA = "0xBAC1E0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xBAC1E4", Offset = "0xBAC1E4", VA = "0xBAC1E4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xBAC330", Offset = "0xBAC330", VA = "0xBAC330")]
		public MaterialPositionSetter()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public static class Random
	{
		[Token(Token = "0x6000417")]
		[Address(RVA = "0xBAC3A0", Offset = "0xBAC3A0", VA = "0xBAC3A0")]
		public static float Inclusive(float min, float max, bool allowNegative = false)
		{
			return default(float);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xBAC3F0", Offset = "0xBAC3F0", VA = "0xBAC3F0")]
		public static int Index(int length)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000E8")]
	public class SpawnVolume : InjectableMonobehavior
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleSystem _ParticleSystem;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Inject]
		private MainCamera _mainCamera;

		[Token(Token = "0x17000073")]
		public Vector3 Center
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0xBAC478", Offset = "0xBAC478", VA = "0xBAC478")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xBAC4E0", Offset = "0xBAC4E0", VA = "0xBAC4E0")]
		public void RotateTowards(Vector3 worldPos)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xBA7314", Offset = "0xBA7314", VA = "0xBA7314")]
		public Vector3[] GeneratePositions(int count)
		{
			return null;
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xBAC570", Offset = "0xBAC570", VA = "0xBAC570")]
		private void Reset()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xBAC62C", Offset = "0xBAC62C", VA = "0xBAC62C")]
		public SpawnVolume()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public static class Tween
	{
		[Token(Token = "0x20000EA")]
		private class CompletedTween : BaseTween
		{
			[Token(Token = "0x1400000D")]
			public override event Action Complete
			{
				[Token(Token = "0x6000433")]
				[Address(RVA = "0xBAE290", Offset = "0xBAE290", VA = "0xBAE290", Slot = "4")]
				add
				{
				}
				[Token(Token = "0x6000434")]
				[Address(RVA = "0xBAE2B0", Offset = "0xBAE2B0", VA = "0xBAE2B0", Slot = "5")]
				remove
				{
				}
			}

			[Token(Token = "0x1400000E")]
			public override event Action Aborted
			{
				[Token(Token = "0x6000435")]
				[Address(RVA = "0xBAE2B4", Offset = "0xBAE2B4", VA = "0xBAE2B4", Slot = "6")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6000436")]
				[Address(RVA = "0xBAE350", Offset = "0xBAE350", VA = "0xBAE350", Slot = "7")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0xBAE3EC", Offset = "0xBAE3EC", VA = "0xBAE3EC", Slot = "8")]
			public override BaseTween Run()
			{
				return null;
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0xBAE3F0", Offset = "0xBAE3F0", VA = "0xBAE3F0", Slot = "9")]
			public override void Abort()
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0xBAE1DC", Offset = "0xBAE1DC", VA = "0xBAE1DC")]
			public CompletedTween()
			{
			}
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xBA4F7C", Offset = "0xBA4F7C", VA = "0xBA4F7C")]
		public static BaseTween Delay(float delayMs, bool autoRun = false)
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xBA4D88", Offset = "0xBA4D88", VA = "0xBA4D88")]
		public static BaseTween Action(Action action)
		{
			return null;
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xBAA284", Offset = "0xBAA284", VA = "0xBAA284")]
		public static Tween<float> Float(float src, float dst, TweenConfig config, Action<float> update, bool autoRun = false)
		{
			return null;
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xBAC634", Offset = "0xBAC634", VA = "0xBAC634")]
		public static Tween<float> Float(float src, Func<float> dst, TweenConfig config, Action<float> update, bool autoRun = false)
		{
			return null;
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xBAC854", Offset = "0xBAC854", VA = "0xBAC854")]
		public static Tween<Vector3> Vector3(Vector3 start, Vector3 end, TweenConfig config, Action<Vector3> update, bool autoRun = false)
		{
			return null;
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xBAC9B4", Offset = "0xBAC9B4", VA = "0xBAC9B4")]
		public static Tween<Vector3> Vector3(Vector3 start, Func<Vector3> end, TweenConfig config, Action<Vector3> update, bool autoRun = false)
		{
			return null;
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xBA4C10", Offset = "0xBA4C10", VA = "0xBA4C10")]
		public static Tween<Color> Color(Color start, Color end, TweenConfig config, Action<Color> update, bool autoRun = false)
		{
			return null;
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xBACBEC", Offset = "0xBACBEC", VA = "0xBACBEC")]
		public static Tween<Color> Color(Color start, Func<Color> end, TweenConfig config, Action<Color> update, bool autoRun = false)
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xBACE28", Offset = "0xBACE28", VA = "0xBACE28")]
		public static Tween<Vector3> Position(Transform transform, Vector3 end, TweenConfig config, bool autoRun = false)
		{
			return null;
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xBAD0B4", Offset = "0xBAD0B4", VA = "0xBAD0B4")]
		public static Tween<Vector3> Position(Transform transform, Func<Vector3> end, TweenConfig config, bool autoRun = false)
		{
			return null;
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xBAD3A8", Offset = "0xBAD3A8", VA = "0xBAD3A8")]
		public static Tween<Vector3> Position(Transform transform, Func<Vector3> start, Func<Vector3> end, TweenConfig config)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xBA31EC", Offset = "0xBA31EC", VA = "0xBA31EC")]
		public static Tween<Vector3> LocalPosition(Transform transform, Vector3 end, TweenConfig config, bool autoRun = false)
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xBA3470", Offset = "0xBA3470", VA = "0xBA3470")]
		public static Tween<Quaternion> LocalRotation(Transform transform, Vector3 end, TweenConfig config, bool autoRun = false)
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xBAD6A8", Offset = "0xBAD6A8", VA = "0xBAD6A8")]
		public static Tween<Quaternion> Rotation(Transform transform, Quaternion end, TweenConfig config, bool autoRun = false)
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xBAD93C", Offset = "0xBAD93C", VA = "0xBAD93C")]
		public static Tween<Quaternion> Rotation(Transform transform, Func<Quaternion> end, TweenConfig config, bool autoRun = false)
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xBADC30", Offset = "0xBADC30", VA = "0xBADC30")]
		public static Tween<Quaternion> Rotation(Transform transform, Func<Quaternion> start, Func<Quaternion> end, TweenConfig config, bool autoRun = false)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xBAA000", Offset = "0xBAA000", VA = "0xBAA000")]
		public static Tween<Vector3> LocalScale(Transform transform, Vector3 end, TweenConfig config, bool autoRun = false)
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xBADF50", Offset = "0xBADF50", VA = "0xBADF50")]
		public static Tween<Vector3> LocalScale(Transform transform, Func<Vector3> end, TweenConfig config, bool autoRun = false)
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xBA4B28", Offset = "0xBA4B28", VA = "0xBA4B28")]
		public static BaseTween Completed()
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xBA3714", Offset = "0xBA3714", VA = "0xBA3714")]
		public static TweenBatch Batch(params BaseTween[] tweens)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xBAE230", Offset = "0xBAE230", VA = "0xBAE230")]
		public static TweenChain Chain(params BaseTween[] tweens)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F8")]
	public abstract class BaseTween
	{
		[Token(Token = "0x20000F9")]
		[CompilerGenerated]
		private sealed class <Await>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BaseTween <>4__this;

			[Token(Token = "0x17000074")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000471")]
				[Address(RVA = "0xBAEF90", Offset = "0xBAEF90", VA = "0xBAEF90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000075")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000473")]
				[Address(RVA = "0xBAEFD8", Offset = "0xBAEFD8", VA = "0xBAEFD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0xBAED40", Offset = "0xBAED40", VA = "0xBAED40")]
			[DebuggerHidden]
			public <Await>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0xBAEF00", Offset = "0xBAEF00", VA = "0xBAEF00", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0xBAEF04", Offset = "0xBAEF04", VA = "0xBAEF04", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0xBAEF98", Offset = "0xBAEF98", VA = "0xBAEF98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<BaseTween> _allTweens;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected bool _started;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		protected bool _completed;

		[Token(Token = "0x1400000F")]
		[method: Token(Token = "0x6000462")]
		public abstract event Action Complete;

		[Token(Token = "0x14000010")]
		[method: Token(Token = "0x6000464")]
		public abstract event Action Aborted;

		[Token(Token = "0x6000466")]
		public abstract BaseTween Run();

		[Token(Token = "0x6000467")]
		public abstract void Abort();

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xBAE3F4", Offset = "0xBAE3F4", VA = "0xBAE3F4")]
		public BaseTween()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xBAEBF4", Offset = "0xBAEBF4", VA = "0xBAEBF4")]
		public static void StopAll()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xBAECCC", Offset = "0xBAECCC", VA = "0xBAECCC")]
		[IteratorStateMachine(typeof(<Await>d__13))]
		public IEnumerator Await()
		{
			return null;
		}
	}
	[Token(Token = "0x20000FA")]
	public class Tween<T> : BaseTween
	{
		[Token(Token = "0x20000FB")]
		[CompilerGenerated]
		private sealed class <Process>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Tween<T> <>4__this;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float <start>5__2;

			[Token(Token = "0x17000076")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000488")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000077")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600048A")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000485")]
			[DebuggerHidden]
			public <Process>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x6000486")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000487")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000489")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Bootstrapper _bootstrapper;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TaskCompletionSource<bool> _taskCompletion;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Func<T, T, float, T> _lerpFunc;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Start;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T End;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float DurationSec;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve Curve;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool Loop;

		[Token(Token = "0x14000011")]
		private event Action _onComplete
		{
			[Token(Token = "0x6000474")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000475")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		private event Action _onAbort
		{
			[Token(Token = "0x6000476")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000477")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000013")]
		public event Action OnBegin
		{
			[Token(Token = "0x6000478")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000479")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event Action<T> OnProgress
		{
			[Token(Token = "0x600047A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600047B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public override event Action Complete
		{
			[Token(Token = "0x600047C")]
			add
			{
			}
			[Token(Token = "0x600047D")]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public override event Action Aborted
		{
			[Token(Token = "0x600047E")]
			add
			{
			}
			[Token(Token = "0x600047F")]
			remove
			{
			}
		}

		[Token(Token = "0x6000480")]
		public Tween(Func<T, T, float, T> lerpFunc)
		{
		}

		[Token(Token = "0x6000481")]
		public override BaseTween Run()
		{
			return null;
		}

		[Token(Token = "0x6000482")]
		public override void Abort()
		{
		}

		[Token(Token = "0x6000483")]
		[IteratorStateMachine(typeof(Tween<>.<Process>d__29))]
		private IEnumerator Process()
		{
			return null;
		}

		[Token(Token = "0x6000484")]
		public static implicit operator Task(Tween<T> tween)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FC")]
	public class TweenBatch : TweenGroup
	{
		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _completeCount;

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xBA4D84", Offset = "0xBA4D84", VA = "0xBA4D84")]
		public TweenBatch(params BaseTween[] tweens)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xBAF12C", Offset = "0xBAF12C", VA = "0xBAF12C", Slot = "10")]
		protected override void Process()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xBAF234", Offset = "0xBAF234", VA = "0xBAF234", Slot = "11")]
		protected override void Cancel()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class TweenChain : TweenGroup
	{
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BaseTween _activeTween;

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xBA506C", Offset = "0xBA506C", VA = "0xBA506C")]
		public TweenChain(params BaseTween[] tweens)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xBAF448", Offset = "0xBAF448", VA = "0xBAF448", Slot = "10")]
		protected override void Process()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xBAF570", Offset = "0xBAF570", VA = "0xBAF570", Slot = "11")]
		protected override void Cancel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000FE")]
	public class TweenConfig
	{
		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float DurationSec;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Curve;

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xBA9F98", Offset = "0xBA9F98", VA = "0xBA9F98")]
		public static TweenConfig Basic(float durationSec)
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xBA4B80", Offset = "0xBA4B80", VA = "0xBA4B80")]
		public static TweenConfig Linear(float durationSec)
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xBAF5C8", Offset = "0xBAF5C8", VA = "0xBAF5C8")]
		public static TweenConfig EaseIn(float durationSec)
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xBAF648", Offset = "0xBAF648", VA = "0xBAF648")]
		public static TweenConfig EaseInAggro(float durationSec)
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xBAF6C8", Offset = "0xBAF6C8", VA = "0xBAF6C8")]
		public static TweenConfig EaseOutAggro(float durationSec)
		{
			return null;
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xBAF588", Offset = "0xBAF588", VA = "0xBAF588")]
		public TweenConfig()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public abstract class TweenGroup : BaseTween
	{
		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly TaskCompletionSource<bool> _tcs;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected readonly List<BaseTween> _tweens;

		[Token(Token = "0x14000017")]
		public override event Action Complete
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0xBAF748", Offset = "0xBAF748", VA = "0xBAF748", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0xBAF7E4", Offset = "0xBAF7E4", VA = "0xBAF7E4", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		public override event Action Aborted
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0xBAF880", Offset = "0xBAF880", VA = "0xBAF880", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0xBAF91C", Offset = "0xBAF91C", VA = "0xBAF91C", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xBAEFE0", Offset = "0xBAEFE0", VA = "0xBAEFE0")]
		public TweenGroup(params BaseTween[] tweens)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xBA4E78", Offset = "0xBA4E78", VA = "0xBA4E78")]
		public void Add(BaseTween tween)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xBAF9B8", Offset = "0xBAF9B8", VA = "0xBAF9B8", Slot = "8")]
		public override BaseTween Run()
		{
			return null;
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xBAF9EC", Offset = "0xBAF9EC", VA = "0xBAF9EC", Slot = "9")]
		public override void Abort()
		{
		}

		[Token(Token = "0x60004A0")]
		protected abstract void Process();

		[Token(Token = "0x60004A1")]
		protected abstract void Cancel();

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xBAF330", Offset = "0xBAF330", VA = "0xBAF330")]
		protected void InvokeOnComplete()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xBAFA74", Offset = "0xBAFA74", VA = "0xBAFA74")]
		public static implicit operator Task(TweenGroup tween)
		{
			return null;
		}
	}
}
namespace Loci.Snapping
{
	[Token(Token = "0x2000100")]
	public class PieceGroup : HandheldManipulator
	{
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xBAFAD0", Offset = "0xBAFAD0", VA = "0xBAFAD0", Slot = "5")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xBAFB8C", Offset = "0xBAFB8C", VA = "0xBAFB8C", Slot = "13")]
		public override void SetPivot(HandheldManipulator pivot)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xBAFC44", Offset = "0xBAFC44", VA = "0xBAFC44")]
		public PieceGroup()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class PrefixedPuzzleChunk : HandheldManipulator
	{
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public int PieceId;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _baseRoot;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _fixedGroup;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Inject]
		private Audio _audio;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool _miniaturesSpawned;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public PuzzleManager Puzzle;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Transform OriginalParent;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public PrefixedPuzzleChunk[] Neighbors;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public Vector3[] NeighborOffsets;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public Vector3[] NeighborSnapPoints;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public ParticleSystem[] NeighborSeams;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public Vector3 OriginalWorldPosition;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public Matrix4x4 InitWorldToLocal;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		public Matrix4x4 InitLocalToWorld;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public int MiniatureCount;

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xBAFC4C", Offset = "0xBAFC4C", VA = "0xBAFC4C", Slot = "5")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xBAFDE8", Offset = "0xBAFDE8", VA = "0xBAFDE8", Slot = "10")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xBAFEA0", Offset = "0xBAFEA0", VA = "0xBAFEA0", Slot = "13")]
		public override void SetPivot(HandheldManipulator pivot)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xBB03B0", Offset = "0xBB03B0", VA = "0xBB03B0")]
		public PrefixedPuzzleChunk VerifySnapProximity(SnapSettings settings)
		{
			return null;
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xBB0BB0", Offset = "0xBB0BB0", VA = "0xBB0BB0")]
		public Vector3 GetIdealPiecePosition(PrefixedPuzzleChunk piece)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xBB0DD0", Offset = "0xBB0DD0", VA = "0xBB0DD0")]
		public void GetSnapPoint(PrefixedPuzzleChunk piece, out Vector3 position)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xBAFEE0", Offset = "0xBAFEE0", VA = "0xBAFEE0")]
		public void ShowFixedGroup(bool instant)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xBB0F84", Offset = "0xBB0F84", VA = "0xBB0F84")]
		public void CleanupChunk()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xBB008C", Offset = "0xBB008C", VA = "0xBB008C")]
		[ContextMenu("Loci/Spawn Miniatures")]
		public void SpawnMiniatures()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xBB0FFC", Offset = "0xBB0FFC", VA = "0xBB0FFC")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xBB1060", Offset = "0xBB1060", VA = "0xBB1060", Slot = "14")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xBB115C", Offset = "0xBB115C", VA = "0xBB115C")]
		[ContextMenu("Cache Reference Matrices")]
		public void CacheReferenceMatrices()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xBB11E4", Offset = "0xBB11E4", VA = "0xBB11E4")]
		[ContextMenu("Update GameObject References")]
		private void UpdateGameObjectReferences()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xBB125C", Offset = "0xBB125C", VA = "0xBB125C")]
		public PrefixedPuzzleChunk()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class PuzzleManager : InjectableMonobehavior
	{
		[Token(Token = "0x2000103")]
		private enum HelperState
		{
			[Token(Token = "0x400049C")]
			Unconfigured,
			[Token(Token = "0x400049D")]
			Waiting,
			[Token(Token = "0x400049E")]
			Ready,
			[Token(Token = "0x400049F")]
			Active
		}

		[Token(Token = "0x2000104")]
		private class BreakupInfo
		{
			[Token(Token = "0x40004A0")]
			public const float BREAKUP_DIST = 0.02f;

			[Token(Token = "0x40004A1")]
			public const float BREAKUP_ANGLE = 15f;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BreakupState State;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HandheldManipulator Left;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandheldManipulator Right;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float StartDistance;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 LeftStartRotation;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 RightStartRotation;

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0xBB62EC", Offset = "0xBB62EC", VA = "0xBB62EC")]
			public BreakupInfo()
			{
			}
		}

		[Token(Token = "0x2000105")]
		private enum BreakupState
		{
			[Token(Token = "0x40004A9")]
			Impossible,
			[Token(Token = "0x40004AA")]
			Possible,
			[Token(Token = "0x40004AB")]
			Tense,
			[Token(Token = "0x40004AC")]
			BrokenUp
		}

		[Serializable]
		[Token(Token = "0x2000106")]
		public struct Batch
		{
			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PrefixedPuzzleChunk[] Pieces;
		}

		[Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class <Snap>d__77 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuzzleManager <>4__this;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PrefixedPuzzleChunk segment;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PrefixedPuzzleChunk reference;

			[Token(Token = "0x1700007A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004E0")]
				[Address(RVA = "0xBB7224", Offset = "0xBB7224", VA = "0xBB7224", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004E2")]
				[Address(RVA = "0xBB726C", Offset = "0xBB726C", VA = "0xBB726C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0xBB3668", Offset = "0xBB3668", VA = "0xBB3668")]
			[DebuggerHidden]
			public <Snap>d__77(int <>1__state)
			{
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0xBB6438", Offset = "0xBB6438", VA = "0xBB6438", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xBB643C", Offset = "0xBB643C", VA = "0xBB643C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0xBB722C", Offset = "0xBB722C", VA = "0xBB722C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200010D")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass87_0
		{
			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PrefixedPuzzleChunk reference;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PrefixedPuzzleChunk segment;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandheldManipulator segPivot;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HandheldManipulator refPivot;

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0xBB7480", Offset = "0xBB7480", VA = "0xBB7480")]
			public <>c__DisplayClass87_0()
			{
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0xBB7488", Offset = "0xBB7488", VA = "0xBB7488")]
			internal Vector3 <TwistSnap>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0xBB76E4", Offset = "0xBB76E4", VA = "0xBB76E4")]
			internal Quaternion <TwistSnap>b__1()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60004F2")]
			[Address(RVA = "0xBB770C", Offset = "0xBB770C", VA = "0xBB770C")]
			internal Vector3 <TwistSnap>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004F3")]
			[Address(RVA = "0xBB77B0", Offset = "0xBB77B0", VA = "0xBB77B0")]
			internal Quaternion <TwistSnap>b__3()
			{
				return default(Quaternion);
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200010E")]
		[CompilerGenerated]
		private struct <TwistSnap>d__87 : IAsyncStateMachine
		{
			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PrefixedPuzzleChunk reference;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PrefixedPuzzleChunk segment;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public HandheldManipulator segPivot;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public HandheldManipulator refPivot;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public PuzzleManager <>4__this;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private <>c__DisplayClass87_0 <>8__1;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60004F4")]
			[Address(RVA = "0xBB77D8", Offset = "0xBB77D8", VA = "0xBB77D8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004F5")]
			[Address(RVA = "0xBB7FDC", Offset = "0xBB7FDC", VA = "0xBB7FDC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SnapSettings _snapSettings;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float PUZZLE_COMPLETE_DWELL_SEC;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool HIDE_REFLECTION_WHILE_PUZZLING;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Inject]
		private Audio _audio;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Inject]
		private HandheldGrabHandler _grabHandler;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Inject]
		private VFXManager _vfx;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Inject]
		private MaterialManager _materialManager;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Inject]
		private SaveService _saveService;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Inject]
		private Skipper _skipper;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Inject]
		private ViewableRegion _viewableRegion;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Inject]
		private MessageBus _msgBus;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Inject]
		private SymbolPlatform _symbolPlatform;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float SNAPS_SPEED_SCALE;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly List<PrefixedPuzzleChunk> _chunks;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly List<List<PrefixedPuzzleChunk>> _heldGroups;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly List<PrefixedPuzzleChunk> _guardedChunks;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly List<PrefixedPuzzleChunk> _piecesInPlay;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly List<Tuple<PrefixedPuzzleChunk, PrefixedPuzzleChunk>> _snapHistory;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly List<HandheldManipulator> _pausedPieces;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly List<Vector3> _pausedScales;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<Quaternion> _pausedRotations;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int _pickupHappened;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool _active;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int _snapsMade;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool _awaitingMore;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly BreakupInfo _breakup;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly ParticleSystem[] _activeHelpers;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HelperState _helperState;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Header("Puzzle Config")]
		public int PuzzleIndex;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string Designation;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int SaveVersion;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public float NearScale;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public float FarScale;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public bool HasHints;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public ImpactType ImpactType;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public Batch[] Batches;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[Header("Completion Config")]
		public GameObject Ground;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public GameObject[] MiniaturePrefabs;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public GameObject OptimizedVariant;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public ParticleSystem CompletionEffect;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public Quaternion CompletedRotation;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private bool _playCompletionAudio;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public UnityEvent PuzzleComplete_Unity;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public UnityEvent SecondPickup_Unity;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public UnityEvent SnapMade_Unity;

		[Token(Token = "0x17000078")]
		public int CurrentBatch
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0xBB126C", Offset = "0xBB126C", VA = "0xBB126C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0xBB1274", Offset = "0xBB1274", VA = "0xBB1274")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public List<PrefixedPuzzleChunk> Chunks
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0xBA72BC", Offset = "0xBA72BC", VA = "0xBA72BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000019")]
		public event Action NeedMoarPieces
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0xBB13F0", Offset = "0xBB13F0", VA = "0xBB13F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0xBB1490", Offset = "0xBB1490", VA = "0xBB1490")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001A")]
		public event Action PuzzleComplete
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0xBB1530", Offset = "0xBB1530", VA = "0xBB1530")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0xBB15D0", Offset = "0xBB15D0", VA = "0xBB15D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001B")]
		public event Action FirstSnapMade
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0xBB1670", Offset = "0xBB1670", VA = "0xBB1670")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0xBB1710", Offset = "0xBB1710", VA = "0xBB1710")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xBB17B0", Offset = "0xBB17B0", VA = "0xBB17B0", Slot = "5")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xBB127C", Offset = "0xBB127C", VA = "0xBB127C")]
		private void LoadChunks()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xBB181C", Offset = "0xBB181C", VA = "0xBB181C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xBB1ACC", Offset = "0xBB1ACC", VA = "0xBB1ACC")]
		public void EnablePuzzle()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xBB1D3C", Offset = "0xBB1D3C", VA = "0xBB1D3C")]
		public void AddBatch(List<PrefixedPuzzleChunk> pieces)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xBB2570", Offset = "0xBB2570", VA = "0xBB2570")]
		public void DisablePuzzle()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xBB28A4", Offset = "0xBB28A4", VA = "0xBB28A4")]
		public void DisableKinematics()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xBB2960", Offset = "0xBB2960", VA = "0xBB2960")]
		public void RestoreFromSave(PuzzleData data)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xBB32E4", Offset = "0xBB32E4", VA = "0xBB32E4")]
		private void OnGrab(HandheldManipulator handheld)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xBB3440", Offset = "0xBB3440", VA = "0xBB3440")]
		private void OnRelease(HandheldManipulator handheld)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xBB3640", Offset = "0xBB3640", VA = "0xBB3640")]
		private void OnControllerRelease()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xBB3320", Offset = "0xBB3320", VA = "0xBB3320")]
		private void TrackPiece(HandheldManipulator pivot)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xBB3444", Offset = "0xBB3444", VA = "0xBB3444")]
		private bool UntrackPiece(HandheldManipulator pivot)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xBB1A28", Offset = "0xBB1A28", VA = "0xBB1A28")]
		[IteratorStateMachine(typeof(<Snap>d__77))]
		private IEnumerator Snap(PrefixedPuzzleChunk segment, PrefixedPuzzleChunk reference)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xBB3690", Offset = "0xBB3690", VA = "0xBB3690")]
		private void Unsnap(PrefixedPuzzleChunk left, PrefixedPuzzleChunk right)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xBB4240", Offset = "0xBB4240", VA = "0xBB4240")]
		public int ActivePuzzleRoots()
		{
			return default(int);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xBB43CC", Offset = "0xBB43CC", VA = "0xBB43CC")]
		private void CompletePuzzle()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xBB45B4", Offset = "0xBB45B4", VA = "0xBB45B4")]
		private void OnDriftComplete()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xBB1F0C", Offset = "0xBB1F0C", VA = "0xBB1F0C")]
		private void SavePuzzle()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xBB5188", Offset = "0xBB5188", VA = "0xBB5188")]
		private void ShowHelpers(object _)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xBB440C", Offset = "0xBB440C", VA = "0xBB440C")]
		private void HideHelpers()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xBB49A8", Offset = "0xBB49A8", VA = "0xBB49A8")]
		private void OnGamePaused(GamePause msg)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xBB5BE4", Offset = "0xBB5BE4", VA = "0xBB5BE4")]
		public bool ForceRandomSnap()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xBB5E34", Offset = "0xBB5E34", VA = "0xBB5E34")]
		[AsyncStateMachine(typeof(<TwistSnap>d__87))]
		private Task TwistSnap(HandheldManipulator segPivot, HandheldManipulator refPivot, PrefixedPuzzleChunk segment, PrefixedPuzzleChunk reference)
		{
			return null;
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xBB5F88", Offset = "0xBB5F88", VA = "0xBB5F88")]
		public PuzzleManager()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public static class SnapMethods
	{
		[Token(Token = "0x6000502")]
		[Address(RVA = "0xBB6FB8", Offset = "0xBB6FB8", VA = "0xBB6FB8")]
		public static IEnumerator Original(HandheldManipulator segPivot, HandheldManipulator refPivot, PrefixedPuzzleChunk segment, PrefixedPuzzleChunk reference)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000113")]
	public class SnapSettings
	{
		[Token(Token = "0x2000114")]
		public enum SnapMode
		{
			[Token(Token = "0x40004DD")]
			Original,
			[Token(Token = "0x40004DE")]
			Bounce,
			[Token(Token = "0x40004DF")]
			Twist,
			[Token(Token = "0x40004E0")]
			Track
		}

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SnapMode Mode;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float OffsetDistance;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float YawThreshold;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float FlatnessThreshold;

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xBB853C", Offset = "0xBB853C", VA = "0xBB853C")]
		public SnapSettings()
		{
		}
	}
}
namespace Loci.Prototyping
{
	[Token(Token = "0x2000115")]
	public class KonamiMenu : MonoBehaviour
	{
		[Token(Token = "0x6000507")]
		[Address(RVA = "0xBB8558", Offset = "0xBB8558", VA = "0xBB8558")]
		public void Show()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xBB860C", Offset = "0xBB860C", VA = "0xBB860C")]
		public KonamiMenu()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class MorphButton : HandheldManipulator
	{
		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Inject]
		private HandheldGrabHandler _grabHandler;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private SpriteRenderer _sprite;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool _interactable;

		[Token(Token = "0x1400001C")]
		public event Action ButtonActivated
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0xBA2C58", Offset = "0xBA2C58", VA = "0xBA2C58")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000511")]
			[Address(RVA = "0xBB8750", Offset = "0xBB8750", VA = "0xBB8750")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xBB87F0", Offset = "0xBB87F0", VA = "0xBB87F0", Slot = "11")]
		public override void StartInput()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xBB88B8", Offset = "0xBB88B8", VA = "0xBB88B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xBB88C0", Offset = "0xBB88C0", VA = "0xBB88C0")]
		public void SetInteractable(bool interactable)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xBB890C", Offset = "0xBB890C", VA = "0xBB890C")]
		public MorphButton()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public abstract class ProtoMenu : InjectableMonobehavior
	{
		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Inject]
		protected Audio _audio;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject Idle;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject Active;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SmackButton OpenButton;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SmackButton[] _options;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Text _text;

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xBB8A04", Offset = "0xBB8A04", VA = "0xBB8A04", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xBB8C40", Offset = "0xBB8C40", VA = "0xBB8C40")]
		private void Open()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xBB8CA8", Offset = "0xBB8CA8", VA = "0xBB8CA8")]
		private void Close()
		{
		}

		[Token(Token = "0x6000520")]
		protected abstract void OnOption(int index);

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xBB8CE0", Offset = "0xBB8CE0", VA = "0xBB8CE0")]
		protected ProtoMenu()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class SmackButton : InjectableMonobehavior
	{
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Inject]
		private HandheldGrabHandler _handheldHandler;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SphereCollider _collider;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _activationTime;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CanvasGroup _cheapLink;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _initScale;

		[Token(Token = "0x1400001D")]
		public event Action Activated
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0xBB8BA4", Offset = "0xBB8BA4", VA = "0xBB8BA4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000525")]
			[Address(RVA = "0xBB8D80", Offset = "0xBB8D80", VA = "0xBB8D80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xBB8E1C", Offset = "0xBB8E1C", VA = "0xBB8E1C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xBB8EE0", Offset = "0xBB8EE0", VA = "0xBB8EE0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xBB9148", Offset = "0xBB9148", VA = "0xBB9148")]
		public void DevTrigger()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xBB9164", Offset = "0xBB9164", VA = "0xBB9164")]
		public SmackButton()
		{
		}
	}
}
namespace Loci.Preloader
{
	[Token(Token = "0x200011C")]
	public class LogoPresent : MonoBehaviour
	{
		[Token(Token = "0x200011D")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LogoPresent <>4__this;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RectTransform rt;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<float> <>9__0;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<float> <>9__1;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<float> <>9__2;

			[Token(Token = "0x600052D")]
			[Address(RVA = "0xBB92A0", Offset = "0xBB92A0", VA = "0xBB92A0")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600052E")]
			[Address(RVA = "0xBB92A8", Offset = "0xBB92A8", VA = "0xBB92A8")]
			internal void <Present>b__0(float f)
			{
			}

			[Token(Token = "0x600052F")]
			[Address(RVA = "0xBB92E4", Offset = "0xBB92E4", VA = "0xBB92E4")]
			internal void <Present>b__1(float f)
			{
			}

			[Token(Token = "0x6000530")]
			[Address(RVA = "0xBB9384", Offset = "0xBB9384", VA = "0xBB9384")]
			internal void <Present>b__2(float f)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200011E")]
		[CompilerGenerated]
		private struct <Present>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LogoPresent <>4__this;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass10_0 <>8__1;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <i>5__2;

			[Token(Token = "0x6000531")]
			[Address(RVA = "0xBB93C0", Offset = "0xBB93C0", VA = "0xBB93C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000532")]
			[Address(RVA = "0xBB9D88", Offset = "0xBB9D88", VA = "0xBB9D88", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Logos")]
		public Sprite[] Logos;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Global Timing")]
		public float InitialDwell;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Intro;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Dwell;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float Outro;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float GapDwell;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float SizeSmall;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float SizeLarge;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Image Container;

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xBB916C", Offset = "0xBB916C", VA = "0xBB916C")]
		public void Awake()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xBB91E0", Offset = "0xBB91E0", VA = "0xBB91E0")]
		[AsyncStateMachine(typeof(<Present>d__10))]
		private void Present()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xBB9298", Offset = "0xBB9298", VA = "0xBB9298")]
		public LogoPresent()
		{
		}
	}
}
namespace Loci.Popups
{
	[Token(Token = "0x200011F")]
	public class NoticePopup : Popup
	{
		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Inject]
		protected HandheldGrabHandler _grabHandler;

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xBB9D94", Offset = "0xBB9D94", VA = "0xBB9D94", Slot = "6")]
		protected override void Display()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xBB9EAC", Offset = "0xBB9EAC", VA = "0xBB9EAC", Slot = "7")]
		public override void Dismiss()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xBB9FD4", Offset = "0xBB9FD4", VA = "0xBB9FD4")]
		public NoticePopup()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public abstract class Popup : InjectableMonobehavior
	{
		[Token(Token = "0x2000121")]
		[CompilerGenerated]
		private sealed class <Prompt>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Popup <>4__this;

			[Token(Token = "0x17000086")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600053E")]
				[Address(RVA = "0xBBA224", Offset = "0xBBA224", VA = "0xBBA224", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000540")]
				[Address(RVA = "0xBBA26C", Offset = "0xBBA26C", VA = "0xBBA26C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600053B")]
			[Address(RVA = "0xBBA058", Offset = "0xBBA058", VA = "0xBBA058")]
			[DebuggerHidden]
			public <Prompt>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600053C")]
			[Address(RVA = "0xBBA08C", Offset = "0xBBA08C", VA = "0xBBA08C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600053D")]
			[Address(RVA = "0xBBA090", Offset = "0xBBA090", VA = "0xBBA090", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600053F")]
			[Address(RVA = "0xBBA22C", Offset = "0xBBA22C", VA = "0xBBA22C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _contentRoot;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _dismissReady;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Inject]
		protected MainCamera _mainCamera;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Inject]
		protected Skipper _skipper;

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xBB9FE4", Offset = "0xBB9FE4", VA = "0xBB9FE4")]
		[IteratorStateMachine(typeof(<Prompt>d__4))]
		public IEnumerator Prompt()
		{
			return null;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xBB9E0C", Offset = "0xBB9E0C", VA = "0xBB9E0C", Slot = "6")]
		protected virtual void Display()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xBB9F2C", Offset = "0xBB9F2C", VA = "0xBB9F2C", Slot = "7")]
		public virtual void Dismiss()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xBB9FDC", Offset = "0xBB9FDC", VA = "0xBB9FDC")]
		protected Popup()
		{
		}
	}
}
namespace Loci.Intro
{
	[Token(Token = "0x2000122")]
	public class LogoRise : MonoBehaviour
	{
		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float RiseTime;

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xBBA274", Offset = "0xBBA274", VA = "0xBBA274")]
		public void Rise()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xBBA2EC", Offset = "0xBBA2EC", VA = "0xBBA2EC")]
		public LogoRise()
		{
		}
	}
}
namespace Loci.Input
{
	[Token(Token = "0x2000123")]
	public class HandheldCollection
	{
		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<HandheldManipulator> _active;

		[Token(Token = "0x17000088")]
		public IReadOnlyList<HandheldManipulator> AllActive
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0xBBA2FC", Offset = "0xBBA2FC", VA = "0xBBA2FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xBBA304", Offset = "0xBBA304", VA = "0xBBA304")]
		public void Register(HandheldManipulator handheld)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xBBA3B4", Offset = "0xBBA3B4", VA = "0xBBA3B4")]
		public void Unregister(HandheldManipulator handheld)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xBBA40C", Offset = "0xBBA40C", VA = "0xBBA40C")]
		public HandheldCollection()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public interface IInputHandler
	{
		[Token(Token = "0x6000547")]
		void AddController(InputSource inputSource);

		[Token(Token = "0x6000548")]
		void ClearAll();

		[Token(Token = "0x6000549")]
		void OnTriggerActivated(InputSource inputSource);

		[Token(Token = "0x600054A")]
		void OnTriggerDeactivated(InputSource inputSource);

		[Token(Token = "0x600054B")]
		void OnGrabActivated(InputSource inputSource);

		[Token(Token = "0x600054C")]
		void OnGrabDeactivated(InputSource inputSource);

		[Token(Token = "0x600054D")]
		void OnThumbstickStart(InputSource inputSource, Vector2 direction);

		[Token(Token = "0x600054E")]
		void OnButtonDown(InputSource inputSource, Button button);

		[Token(Token = "0x600054F")]
		void ProcessUpdate();
	}
	[Token(Token = "0x2000125")]
	public interface IInputTarget
	{
		[Token(Token = "0x17000089")]
		bool Available
		{
			[Token(Token = "0x6000550")]
			get;
		}

		[Token(Token = "0x1700008A")]
		Vector3 WorldCenter
		{
			[Token(Token = "0x6000551")]
			get;
		}

		[Token(Token = "0x6000552")]
		void StartInput();

		[Token(Token = "0x6000553")]
		void EndInput();
	}
	[Token(Token = "0x2000126")]
	public abstract class BaseGrabHandler : IInputHandler
	{
		[Token(Token = "0x2000127")]
		protected enum Proximity
		{
			[Token(Token = "0x4000523")]
			Near,
			[Token(Token = "0x4000524")]
			Far
		}

		[Token(Token = "0x2000128")]
		protected struct GrabInfo<T>
		{
			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Proximity Proximity;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float Distance;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T Handheld;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 HitPoint;
		}

		[Token(Token = "0x2000129")]
		protected struct ControllerPair
		{
			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InputSource Input;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public InputVisual Visual;
		}

		[Token(Token = "0x4000518")]
		private const int LAYER_MASK = 64;

		[Token(Token = "0x4000519")]
		private const float PICKUP_RADIUS = 0.1f;

		[Token(Token = "0x400051A")]
		private const float RAYCAST_RADIUS = 0.05f;

		[Token(Token = "0x400051B")]
		protected const float GRAB_DISTANCE = 5f;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Keybindings _keybindings;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly MaterialManager _materials;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected readonly PauseManager _pauseManager;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected readonly Dictionary<HandheldManipulator, Handedness> _holdState;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected readonly Dictionary<Handedness, ControllerPair> _controllers;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly List<InputVisual> InputVisuals;

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xBBA494", Offset = "0xBBA494", VA = "0xBBA494")]
		protected BaseGrabHandler(Keybindings keybindings, MaterialManager materials, PauseManager pauseManager)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xBBA608", Offset = "0xBBA608", VA = "0xBBA608", Slot = "13")]
		public virtual void AddController(InputSource inputSource)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xBBA960", Offset = "0xBBA960", VA = "0xBBA960", Slot = "14")]
		public virtual void ClearAll()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xBBAD28", Offset = "0xBBAD28", VA = "0xBBAD28")]
		public (Vector3, Vector3) GetHandData(Handedness handedness)
		{
			return default((Vector3, Vector3));
		}

		[Token(Token = "0x6000558")]
		public abstract void OnTriggerActivated(InputSource inputSource);

		[Token(Token = "0x6000559")]
		public abstract void OnTriggerDeactivated(InputSource inputSource);

		[Token(Token = "0x600055A")]
		public abstract void OnGrabActivated(InputSource inputSource);

		[Token(Token = "0x600055B")]
		public abstract void OnGrabDeactivated(InputSource inputSource);

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xBBAE3C", Offset = "0xBBAE3C", VA = "0xBBAE3C", Slot = "10")]
		public void OnThumbstickStart(InputSource inputSource, Vector2 dir)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xBBB024", Offset = "0xBBB024", VA = "0xBBB024", Slot = "11")]
		public void OnButtonDown(InputSource inputSource, Button button)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xBBB4F4", Offset = "0xBBB4F4", VA = "0xBBB4F4", Slot = "19")]
		public virtual void ProcessUpdate()
		{
		}

		[Token(Token = "0x600055F")]
		protected bool FindNearby<T>(InputSource inputSource, out GrabInfo<T> results) where T : HandheldManipulator
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200012A")]
	public class HandheldGrabHandler : BaseGrabHandler
	{
		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly Audio _audio;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<HandheldManipulator> _allHeld;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Rigidbody _centerRigid;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private HandheldManipulator _leftHeld;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private HandheldManipulator _rightHeld;

		[Token(Token = "0x1400001E")]
		public event Action GrabUsed
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xBB9E10", Offset = "0xBB9E10", VA = "0xBB9E10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000561")]
			[Address(RVA = "0xBB9F38", Offset = "0xBB9F38", VA = "0xBB9F38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001F")]
		public event Action GrabReleased
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0xBBB6EC", Offset = "0xBBB6EC", VA = "0xBBB6EC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000563")]
			[Address(RVA = "0xBBB788", Offset = "0xBBB788", VA = "0xBBB788")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xBBB824", Offset = "0xBBB824", VA = "0xBBB824")]
		public HandheldGrabHandler(HandheldConfig config, Audio audio, MaterialManager materials, Keybindings keybindings, PauseManager pauseManager)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xBBB904", Offset = "0xBBB904", VA = "0xBBB904")]
		public void SetHaptic(Handedness hand, float intensity, float duration)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xBBBA2C", Offset = "0xBBBA2C", VA = "0xBBBA2C", Slot = "15")]
		public override void OnTriggerActivated(InputSource inputSource)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xBBBCF8", Offset = "0xBBBCF8", VA = "0xBBBCF8", Slot = "16")]
		public override void OnTriggerDeactivated(InputSource inputSource)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xBBBE44", Offset = "0xBBBE44", VA = "0xBBBE44", Slot = "17")]
		public override void OnGrabActivated(InputSource inputSource)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xBBBEF0", Offset = "0xBBBEF0", VA = "0xBBBEF0", Slot = "18")]
		public override void OnGrabDeactivated(InputSource inputSource)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xBBBF20", Offset = "0xBBBF20", VA = "0xBBBF20", Slot = "19")]
		public override void ProcessUpdate()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xBBC2D8", Offset = "0xBBC2D8", VA = "0xBBC2D8")]
		public void DropAll()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xBBC368", Offset = "0xBBC368", VA = "0xBBC368")]
		public void DropHandheld(HandheldManipulator handheld)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xBBC7A4", Offset = "0xBBC7A4", VA = "0xBBC7A4")]
		public bool GetBreakupSet(out HandheldManipulator sharedPivot, out HandheldManipulator a, out HandheldManipulator b)
		{
			return default(bool);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xBBC9A4", Offset = "0xBBC9A4", VA = "0xBBC9A4")]
		private void AddHand(HandheldManipulator handheld, Handedness handedness, Vector3 attachPoint)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xBBC370", Offset = "0xBBC370", VA = "0xBBC370")]
		private void RemoveHand(HandheldManipulator handheld, Handedness handedness)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xBBCD60", Offset = "0xBBCD60", VA = "0xBBCD60")]
		private void UpdatePivot(HandheldManipulator handheld, Handedness handedness, Vector3 suggested)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xBBD290", Offset = "0xBBD290", VA = "0xBBD290")]
		private void Handheld_PivotChanged(HandheldManipulator prev, HandheldManipulator next)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xBBBAD8", Offset = "0xBBBAD8", VA = "0xBBBAD8")]
		private void StartHold(InputSource inputSource, bool allowFar)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xBBBD28", Offset = "0xBBBD28", VA = "0xBBBD28")]
		private void EndHold(InputSource inputSource)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xBBD52C", Offset = "0xBBD52C", VA = "0xBBD52C")]
		public void ForceEndHold(HandheldManipulator handheld)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012C")]
	[Flags]
	public enum Handedness
	{
		[Token(Token = "0x4000536")]
		None = 0,
		[Token(Token = "0x4000537")]
		Left = 1,
		[Token(Token = "0x4000538")]
		Right = 2,
		[Token(Token = "0x4000539")]
		Combined = 3
	}
	[Token(Token = "0x200012D")]
	public enum Button
	{
		[Token(Token = "0x400053B")]
		Start,
		[Token(Token = "0x400053C")]
		Primary,
		[Token(Token = "0x400053D")]
		Secondary
	}
	[Serializable]
	[Token(Token = "0x200012E")]
	public abstract class InputSource : MonoBehaviour
	{
		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Handedness _handedness;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlatformControllerBinding Binding;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool InUse;

		[Token(Token = "0x1700008B")]
		public Handedness Handedness
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0xBBD694", Offset = "0xBBD694", VA = "0xBBD694")]
			get
			{
				return default(Handedness);
			}
		}

		[Token(Token = "0x1700008C")]
		public Vector3 CurrentPosition
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0xBBADFC", Offset = "0xBBADFC", VA = "0xBBADFC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700008D")]
		public Vector3 CurrentDirection
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0xBBAE1C", Offset = "0xBBAE1C", VA = "0xBBAE1C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700008E")]
		public Quaternion CurrentRotation
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0xBBD69C", Offset = "0xBBD69C", VA = "0xBBD69C")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x14000020")]
		public event Action<InputSource, bool> TriggerActivated
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0xBBD6BC", Offset = "0xBBD6BC", VA = "0xBBD6BC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600057C")]
			[Address(RVA = "0xBBD76C", Offset = "0xBBD76C", VA = "0xBBD76C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000021")]
		public event Action<InputSource, bool> GrabActivated
		{
			[Token(Token = "0x600057D")]
			[Address(RVA = "0xBBD81C", Offset = "0xBBD81C", VA = "0xBBD81C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600057E")]
			[Address(RVA = "0xBBD8CC", Offset = "0xBBD8CC", VA = "0xBBD8CC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000022")]
		public event Action<InputSource, Button> ButtonDown
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0xBBA8B0", Offset = "0xBBA8B0", VA = "0xBBA8B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000580")]
			[Address(RVA = "0xBBAC78", Offset = "0xBBAC78", VA = "0xBBAC78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000023")]
		public event Action<InputSource, Vector2> ThumbstickKnocked
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0xBBA800", Offset = "0xBBA800", VA = "0xBBA800")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000582")]
			[Address(RVA = "0xBBABC8", Offset = "0xBBABC8", VA = "0xBBABC8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xBBD97C", Offset = "0xBBD97C", VA = "0xBBD97C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xBBD9A8", Offset = "0xBBD9A8", VA = "0xBBD9A8", Slot = "5")]
		public virtual void Process()
		{
		}

		[Token(Token = "0x6000585")]
		public abstract void SetHaptics(float frequency, float amplitude, float durationSec);

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xBBD9AC", Offset = "0xBBD9AC", VA = "0xBBD9AC")]
		protected void StartTrigger()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xBBD9D0", Offset = "0xBBD9D0", VA = "0xBBD9D0")]
		protected void ReleaseTrigger()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xBBD9F4", Offset = "0xBBD9F4", VA = "0xBBD9F4")]
		protected void StartGrab()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xBBDA18", Offset = "0xBBDA18", VA = "0xBBDA18")]
		protected void ReleaseGrab()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xBBDA3C", Offset = "0xBBDA3C", VA = "0xBBDA3C")]
		protected void InvokeButton(Button button)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xBBDA64", Offset = "0xBBDA64", VA = "0xBBDA64")]
		protected void InvokeThumbstick(Vector2 dir)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xBBDA84", Offset = "0xBBDA84", VA = "0xBBDA84")]
		protected InputSource()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012F")]
	public class PlatformControllerBinding
	{
		[Token(Token = "0x4000545")]
		private const float ABSORB_DURATION = 0.25f;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject PlatformController;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputVisual LociController;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject GrabAnnotations;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject MenuAnnotations;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _transform;

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xBBDA8C", Offset = "0xBBDA8C", VA = "0xBBDA8C")]
		public void SetTransform(Transform transform)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xBBDA94", Offset = "0xBBDA94", VA = "0xBBDA94")]
		public void ShowPlatform(PlatformRoot.ControllerAnnotations annotations)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xBBDBC4", Offset = "0xBBDBC4", VA = "0xBBDBC4")]
		public void ShowGame()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xBBDC08", Offset = "0xBBDC08", VA = "0xBBDC08")]
		public void AbsorbVisual(InputVisual visual, Action onComplete)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xBBE04C", Offset = "0xBBE04C", VA = "0xBBE04C")]
		public PlatformControllerBinding()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class UnityXRInputSource : InputSource
	{
		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private InputDevice _inputDevice;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _grabActive;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool _primaryButtonActive;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool _secondaryButtonActive;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector2 _thumbstick;

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xBBE108", Offset = "0xBBE108", VA = "0xBBE108", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xBBE140", Offset = "0xBBE140", VA = "0xBBE140", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xBBE620", Offset = "0xBBE620", VA = "0xBBE620", Slot = "6")]
		public override void SetHaptics(float frequency, float amplitude, float durationSec)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xBBE240", Offset = "0xBBE240", VA = "0xBBE240")]
		private void CheckTriggers()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xBBE340", Offset = "0xBBE340", VA = "0xBBE340")]
		private void CheckButtons()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xBBE510", Offset = "0xBBE510", VA = "0xBBE510")]
		private void CheckThumbstick()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xBBE6C4", Offset = "0xBBE6C4", VA = "0xBBE6C4")]
		public UnityXRInputSource()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class HandheldManipulator : InjectableMonobehavior, IInputTarget
	{
		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Inject]
		protected HandheldCollection _handheldCollection;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Inject]
		protected VFXManager _vfxManager;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Inject]
		protected HandheldConfig _handheldConfig;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Inject]
		protected ViewableRegion _viewableRegion;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Inject]
		protected RelocationField _relocation;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Inject]
		protected AchievementService _achievementService;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 _initLocalScale;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _inUse;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ConfigurableJoint _joint;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private BaseTween _grabTween;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float _bobPeriod;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float _bobOffset;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _bobBoost;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BaseTween _relocateTween;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool RelocateToUser;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int Weight;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool AllowPickup;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		public bool ShouldBob;

		[Token(Token = "0x1700008F")]
		protected HandheldManipulator _parentPivot
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0xBBE6CC", Offset = "0xBBE6CC", VA = "0xBBE6CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600059E")]
			[Address(RVA = "0xBBE6D4", Offset = "0xBBE6D4", VA = "0xBBE6D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000090")]
		protected Transform _transform
		{
			[Token(Token = "0x600059F")]
			[Address(RVA = "0xBBE6DC", Offset = "0xBBE6DC", VA = "0xBBE6DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0xBBE6E4", Offset = "0xBBE6E4", VA = "0xBBE6E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public Vector3 WorldCenter
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0xBBE6EC", Offset = "0xBBE6EC", VA = "0xBBE6EC", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000092")]
		public HandheldManipulator PivotManipulator
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0xBBC92C", Offset = "0xBBC92C", VA = "0xBBC92C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0xBBE81C", Offset = "0xBBE81C", VA = "0xBBE81C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public Vector3 JointAnchor
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0xBBD094", Offset = "0xBBD094", VA = "0xBBD094")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000094")]
		public Rigidbody Rigidbody
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0xBBEAB0", Offset = "0xBBEAB0", VA = "0xBBEAB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xBBEAB8", Offset = "0xBBEAB8", VA = "0xBBEAB8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public bool IsGrouped
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xBBEAC0", Offset = "0xBBEAC0", VA = "0xBBEAC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xBBEAC8", Offset = "0xBBEAC8", VA = "0xBBEAC8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public bool Available
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xBBEAD4", Offset = "0xBBEAD4", VA = "0xBBEAD4", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000097")]
		public Collider Collider
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xBBEB0C", Offset = "0xBBEB0C", VA = "0xBBEB0C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xBBEB14", Offset = "0xBBEB14", VA = "0xBBEB14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x14000024")]
		public event Action<HandheldManipulator> OnGrab
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0xBBEB1C", Offset = "0xBBEB1C", VA = "0xBBEB1C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0xBBEBCC", Offset = "0xBBEBCC", VA = "0xBBEBCC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000025")]
		public event Action<HandheldManipulator> OnRelease
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0xBBEC7C", Offset = "0xBBEC7C", VA = "0xBBEC7C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0xBBED2C", Offset = "0xBBED2C", VA = "0xBBED2C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000026")]
		public event Action<HandheldManipulator, HandheldManipulator> OnPivotChange
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0xBBCF34", Offset = "0xBBCF34", VA = "0xBBCF34")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xBBCFE4", Offset = "0xBBCFE4", VA = "0xBBCFE4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xBBEDDC", Offset = "0xBBEDDC", VA = "0xBBEDDC", Slot = "5")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xBBEEC8", Offset = "0xBBEEC8", VA = "0xBBEEC8", Slot = "10")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xBBFB8C", Offset = "0xBBFB8C", VA = "0xBBFB8C")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xBBFBA8", Offset = "0xBBFBA8", VA = "0xBBFBA8")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xBBFBC4", Offset = "0xBBFBC4", VA = "0xBBFBC4", Slot = "11")]
		public virtual void StartInput()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xBBFCCC", Offset = "0xBBFCCC", VA = "0xBBFCCC", Slot = "12")]
		public virtual void EndInput()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xBBD0D4", Offset = "0xBBD0D4", VA = "0xBBD0D4")]
		public void ConfigureJoint(Rigidbody connection, Vector3 anchor)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xBC0028", Offset = "0xBC0028", VA = "0xBC0028", Slot = "13")]
		public virtual void SetPivot(HandheldManipulator pivot)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xBC016C", Offset = "0xBC016C", VA = "0xBC016C")]
		public void ClearPivot()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xBC0248", Offset = "0xBC0248", VA = "0xBC0248")]
		public void Terminate()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xBBFE5C", Offset = "0xBBFE5C", VA = "0xBBFE5C")]
		private void ZeroKinematics()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xBC03A0", Offset = "0xBC03A0", VA = "0xBC03A0", Slot = "14")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xBC03C4", Offset = "0xBC03C4", VA = "0xBC03C4")]
		[ContextMenu("Debug/Inspect")]
		private void Inspect()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xBC042C", Offset = "0xBC042C", VA = "0xBC042C")]
		public HandheldManipulator()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class TutorialManipulator : HandheldManipulator
	{
		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Renderer CorrespondingController;

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xBC04D4", Offset = "0xBC04D4", VA = "0xBC04D4")]
		public TutorialManipulator()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class Keybindings
	{
		[Token(Token = "0x2000136")]
		public enum InputType
		{
			[Token(Token = "0x400057C")]
			Up,
			[Token(Token = "0x400057D")]
			Down,
			[Token(Token = "0x400057E")]
			Left,
			[Token(Token = "0x400057F")]
			Right,
			[Token(Token = "0x4000580")]
			B,
			[Token(Token = "0x4000581")]
			A
		}

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool CHEAT_CODES;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly DebugHud _debugHud;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly KonamiMenu _konami;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly PlatformRoot _platform;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Skipper _skipper;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly MainCamera _mainCamera;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly MessageBus _msgBus;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<InputType> _lastInputs;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Dictionary<Handedness, float> _secondaryPressTime;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _secretStartTime;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _secretCount;

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xBC04F0", Offset = "0xBC04F0", VA = "0xBC04F0")]
		public Keybindings(DebugHud debugHud, KonamiMenu konami, PlatformRoot root, Skipper skipper, MessageBus msgBus, MainCamera mainCamera)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xBBAEA0", Offset = "0xBBAEA0", VA = "0xBBAEA0")]
		public void ThumbstickUp(Handedness hand)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xBBAF8C", Offset = "0xBBAF8C", VA = "0xBBAF8C")]
		public void ThumbstickDown(Handedness hand)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xBBAF94", Offset = "0xBBAF94", VA = "0xBBAF94")]
		public void ThumbstickLeft(Handedness hand)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xBBAFDC", Offset = "0xBBAFDC", VA = "0xBBAFDC")]
		public void ThumbstickRight(Handedness hand)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xBBB1D8", Offset = "0xBBB1D8", VA = "0xBBB1D8")]
		public void PrimaryButtonPress(Handedness hand)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xBBB2BC", Offset = "0xBBB2BC", VA = "0xBBB2BC")]
		public void SecondaryButtonPress(Handedness hand)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xBBB470", Offset = "0xBBB470", VA = "0xBBB470")]
		public void StartButtonPress(Handedness hand)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xBC0B18", Offset = "0xBC0B18", VA = "0xBC0B18")]
		private bool CheckKonami(InputType cur)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000137")]
	public class PlatformRoot : MonoBehaviour
	{
		[Token(Token = "0x2000138")]
		public enum ControllerAnnotations
		{
			[Token(Token = "0x4000584")]
			None = 0,
			[Token(Token = "0x4000585")]
			Grab = 1,
			[Token(Token = "0x4000586")]
			Menu = 2,
			[Token(Token = "0x4000587")]
			Hint = 4
		}

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public InputSource[] Controllers;

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xBC0DF8", Offset = "0xBC0DF8", VA = "0xBC0DF8")]
		public void ShowPlatformControllers(ControllerAnnotations annotations)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xBC0E64", Offset = "0xBC0E64", VA = "0xBC0E64")]
		public void ShowGameControllers()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xBC0EC8", Offset = "0xBC0EC8", VA = "0xBC0EC8")]
		public PlatformRoot()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class HandlessVisual : InputVisual
	{
		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _tr;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BaseTween _visibilityTween;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BaseTween _movingTween;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _initScale;

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xBC0ED0", Offset = "0xBC0ED0", VA = "0xBC0ED0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xBC0F5C", Offset = "0xBC0F5C", VA = "0xBC0F5C", Slot = "4")]
		public override void Idle()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xBC11F8", Offset = "0xBC11F8", VA = "0xBC11F8", Slot = "5")]
		public override BaseTween GrabNothing()
		{
			return null;
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xBC1478", Offset = "0xBC1478", VA = "0xBC1478", Slot = "6")]
		public override BaseTween GrabNear(Vector3 worldPos)
		{
			return null;
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xBC14D8", Offset = "0xBC14D8", VA = "0xBC14D8", Slot = "7")]
		public override BaseTween GrabFar(Vector3 worldPos)
		{
			return null;
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xBC1778", Offset = "0xBC1778", VA = "0xBC1778", Slot = "8")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xBC10C8", Offset = "0xBC10C8", VA = "0xBC10C8")]
		private void ScaleTo(float ratio)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xBC180C", Offset = "0xBC180C", VA = "0xBC180C")]
		public HandlessVisual()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public enum UsageState
	{
		[Token(Token = "0x4000592")]
		Ready,
		[Token(Token = "0x4000593")]
		Animating,
		[Token(Token = "0x4000594")]
		Holding
	}
	[Token(Token = "0x200013D")]
	public abstract class InputVisual : MonoBehaviour
	{
		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Rigidbody Rigidbody;

		[Token(Token = "0x1700009A")]
		public UsageState Usage
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0xBC1A4C", Offset = "0xBC1A4C", VA = "0xBC1A4C")]
			[CompilerGenerated]
			get
			{
				return default(UsageState);
			}
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0xBC1A54", Offset = "0xBC1A54", VA = "0xBC1A54")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x14000027")]
		public event Action PickupTrigger
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xBBD490", Offset = "0xBBD490", VA = "0xBBD490")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xBC1A5C", Offset = "0xBC1A5C", VA = "0xBC1A5C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60005EB")]
		public abstract void Idle();

		[Token(Token = "0x60005EC")]
		public abstract BaseTween GrabNothing();

		[Token(Token = "0x60005ED")]
		public abstract BaseTween GrabNear(Vector3 worldPos);

		[Token(Token = "0x60005EE")]
		public abstract BaseTween GrabFar(Vector3 worldPos);

		[Token(Token = "0x60005EF")]
		public abstract void Reset();

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xBC14A4", Offset = "0xBC14A4", VA = "0xBC14A4")]
		protected void InvokePickupTrigger()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xBC1814", Offset = "0xBC1814", VA = "0xBC1814")]
		protected InputVisual()
		{
		}
	}
	[Token(Token = "0x200013E")]
	[ExecuteAlways]
	public class Morph : MonoBehaviour
	{
		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float MinOffset;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MaxOffset;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float AnimSpeed;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform BoneRoot;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] _timeOffset;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float[] _offsets;

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xBC1AF8", Offset = "0xBC1AF8", VA = "0xBC1AF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xBC1C18", Offset = "0xBC1C18", VA = "0xBC1C18")]
		private void Update()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xBC1D9C", Offset = "0xBC1D9C", VA = "0xBC1D9C")]
		public Morph()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class PhysicalControllerVisual : MonoBehaviour
	{
		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material _baseMaterial;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Material _highlightMaterial;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Renderer _aButton;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Renderer _bButton;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Renderer _triggers;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject GrabAnnotations;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject MenuAnnotations;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject HintAnnotations;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Vector3 _defautRotation;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Vector3 _menuRotation;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector3 _hintRotation;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _grabRotation;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Header("Vive Specific")]
		[SerializeField]
		private bool _singleButtonController;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		[SerializeField]
		private bool _primaryController;

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xBC1DB8", Offset = "0xBC1DB8", VA = "0xBC1DB8")]
		public void SetAnnotations(PlatformRoot.ControllerAnnotations state)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xBC202C", Offset = "0xBC202C", VA = "0xBC202C")]
		public PhysicalControllerVisual()
		{
		}
	}
}
namespace Loci.Extensions
{
	[Token(Token = "0x2000141")]
	public static class ColliderExtensions
	{
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xBC2224", Offset = "0xBC2224", VA = "0xBC2224")]
		public static bool Raycast(this Collider collider, Vector3 position, Vector3 direction)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xBC2294", Offset = "0xBC2294", VA = "0xBC2294")]
		public static bool Contains(this SphereCollider collider, Vector3 position, float padding = 0f)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000142")]
	public static class FloatExtensions
	{
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xBC2390", Offset = "0xBC2390", VA = "0xBC2390")]
		public static bool Approximately(this float f, float value, float precision = float.Epsilon)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000143")]
	public static class GameObjectExtensions
	{
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xBBDFF4", Offset = "0xBBDFF4", VA = "0xBBDFF4")]
		public static void Destroy(this GameObject @this)
		{
		}

		[Token(Token = "0x60005FD")]
		public static T AddOrGetComponent<T>(this GameObject @this) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xBC23A0", Offset = "0xBC23A0", VA = "0xBC23A0")]
		public static Material[] GetAllMaterials(this GameObject @this)
		{
			return null;
		}
	}
	[Token(Token = "0x2000144")]
	public static class JointExtensions
	{
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xBBFEF0", Offset = "0xBBFEF0", VA = "0xBBFEF0")]
		public static void Configure(this ConfigurableJoint joint, JointConfig config)
		{
		}
	}
	[Token(Token = "0x2000145")]
	public static class NavMeshGraphExtensions
	{
		[Token(Token = "0x6000600")]
		[Address(RVA = "0xBC2588", Offset = "0xBC2588", VA = "0xBC2588")]
		public static Vector3 RoughRandomGraphPosition(this NavMeshGraph graph, bool onGraph = false)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000146")]
	public static class ParticleSystemExtensions
	{
		[Token(Token = "0x6000601")]
		[Address(RVA = "0xBC26B4", Offset = "0xBC26B4", VA = "0xBC26B4")]
		public static void DisableEmission(this ParticleSystem particleSystem)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xBC26E8", Offset = "0xBC26E8", VA = "0xBC26E8")]
		public static void EnableEmission(this ParticleSystem particleSystem)
		{
		}
	}
	[Token(Token = "0x2000147")]
	public static class PlaneExtensions
	{
		[Token(Token = "0x6000603")]
		[Address(RVA = "0xBC2744", Offset = "0xBC2744", VA = "0xBC2744")]
		public static bool RayIntersect(this Plane plane, Vector3 position, Vector3 direction, out Vector3 intersect)
		{
			return default(bool);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xBC27DC", Offset = "0xBC27DC", VA = "0xBC27DC")]
		public static bool RayIntersect(this Plane plane, Ray ray, out Vector3 intersect)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000148")]
	public static class RenderTextureExtensions
	{
		[Token(Token = "0x6000605")]
		[Address(RVA = "0xBC2898", Offset = "0xBC2898", VA = "0xBC2898")]
		public static string Specs(this RenderTexture rt)
		{
			return null;
		}
	}
	[Token(Token = "0x2000149")]
	public static class RigidbodyExtensions
	{
		[Token(Token = "0x6000606")]
		[Address(RVA = "0xBC2AB0", Offset = "0xBC2AB0", VA = "0xBC2AB0")]
		public static Bounds BuildCompoundBounds(this Rigidbody rigidbody)
		{
			return default(Bounds);
		}
	}
	[Token(Token = "0x200014A")]
	public static class TransformExtensions
	{
		[Token(Token = "0x6000607")]
		[Address(RVA = "0xBC2BC4", Offset = "0xBC2BC4", VA = "0xBC2BC4")]
		public static Transform[] GetNestedOfTag(this Transform tr, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xBC2E74", Offset = "0xBC2E74", VA = "0xBC2E74")]
		public static void SetLocalPositionAndRotation(this Transform tr, Vector3 localPos, Quaternion localRot)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xBC2ECC", Offset = "0xBC2ECC", VA = "0xBC2ECC")]
		public static void Reset(this Transform tr)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xBC2FAC", Offset = "0xBC2FAC", VA = "0xBC2FAC")]
		public static Transform FindStartsWith(this Transform tr, string name)
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xBC30C8", Offset = "0xBC30C8", VA = "0xBC30C8")]
		public static Transform FindExactChildRecursive(this Transform tr, string name)
		{
			return null;
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xBC33E8", Offset = "0xBC33E8", VA = "0xBC33E8")]
		public static Transform FindChildRecursive(this Transform tr, string name)
		{
			return null;
		}
	}
}
namespace Loci.Effects
{
	[Token(Token = "0x200014B")]
	public class Buoyancy : MonoBehaviour
	{
		[Token(Token = "0x40005AE")]
		private const float INITIAL_DURATION = 9f;

		[Token(Token = "0x40005AF")]
		private const float RECURRING_DURATION = 3f;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float PeakHeight;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float RecurringHeight;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float SpeedModifier;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _duration;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _waterline;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _nextPeak;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _lastPeak;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BaseTween _tween;

		[Token(Token = "0x14000028")]
		public event Action<Vector3> WaterlineBreached
		{
			[Token(Token = "0x600060D")]
			[Address(RVA = "0xBC370C", Offset = "0xBC370C", VA = "0xBC370C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600060E")]
			[Address(RVA = "0xBC37BC", Offset = "0xBC37BC", VA = "0xBC37BC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xBC386C", Offset = "0xBC386C", VA = "0xBC386C")]
		public void SetWaterline(float heightWS)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xBC3A20", Offset = "0xBC3A20", VA = "0xBC3A20")]
		private void Bob()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xBC3D0C", Offset = "0xBC3D0C", VA = "0xBC3D0C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xBC3D24", Offset = "0xBC3D24", VA = "0xBC3D24")]
		private void InvokeWaterlineBreach()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xBC3D78", Offset = "0xBC3D78", VA = "0xBC3D78")]
		public Buoyancy()
		{
		}
	}
	[Token(Token = "0x200014D")]
	public class ChapterUnlock : InjectableMonobehavior
	{
		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool SEQUENCE_ACTIVE;

		[Token(Token = "0x40005BC")]
		private const float MAX_PULL_FORCE = 10f;

		[Token(Token = "0x40005BD")]
		private const float PUSH_FORCE = -20f;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _handRef;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ParticleSystemForceField _field;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Inject]
		private VFXManager _vfx;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Inject]
		private Audio _audio;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Inject]
		private GeodeMenu _geodeMenu;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Inject]
		private SymbolPlatform _symbolPlatform;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Inject]
		private Bootstrapper _bootstrapper;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Action _effectStop;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ChapterIndex UnlockedChapter;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Action OnComplete;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int ShowRim;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int Alpha;

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xBC3E54", Offset = "0xBC3E54", VA = "0xBC3E54")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xBC40F4", Offset = "0xBC40F4", VA = "0xBC40F4")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xBC42A4", Offset = "0xBC42A4", VA = "0xBC42A4")]
		private void SpawnEffect()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xBC4364", Offset = "0xBC4364", VA = "0xBC4364")]
		private void EndEffect()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xBC4B94", Offset = "0xBC4B94", VA = "0xBC4B94")]
		public ChapterUnlock()
		{
		}
	}
	[Token(Token = "0x200014F")]
	[RequireComponent(typeof(ParticleSystem))]
	public class ParticleLink : MonoBehaviour
	{
		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem _ps;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleSystemRenderer _renderer;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem.Particle[] _buffer;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform[] _reflections;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WaterSurface _water;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _helper;

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xBC508C", Offset = "0xBC508C", VA = "0xBC508C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xBC5470", Offset = "0xBC5470", VA = "0xBC5470")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xBC5524", Offset = "0xBC5524", VA = "0xBC5524")]
		private void Update()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xBC58A4", Offset = "0xBC58A4", VA = "0xBC58A4")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xBC5938", Offset = "0xBC5938", VA = "0xBC5938")]
		public ParticleLink()
		{
		}
	}
	[Token(Token = "0x2000150")]
	[ExecuteInEditMode]
	public class PortalPositioner : MonoBehaviour
	{
		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Pitch;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Bearing;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Distance;

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xBC5940", Offset = "0xBC5940", VA = "0xBC5940")]
		private void Update()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xBC5A1C", Offset = "0xBC5A1C", VA = "0xBC5A1C")]
		public PortalPositioner()
		{
		}
	}
	[Token(Token = "0x2000151")]
	public class WaterlineBreach : InjectableMonobehavior
	{
		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DisableVFX;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int WaterLevel;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float _waterline;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static float _waterlineRef;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Plane _waterPlane;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Inject]
		private VFXManager _vfx;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VFXType Type;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform SubmergedPoint;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Scale;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float SqrStep;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _isAbove;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 _priorPos;

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xBC5A24", Offset = "0xBC5A24", VA = "0xBC5A24")]
		private void Update()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xBC5E20", Offset = "0xBC5E20", VA = "0xBC5E20")]
		public WaterlineBreach()
		{
		}
	}
}
namespace Loci.Dev
{
	[Token(Token = "0x2000152")]
	public class BuildNumberDisplay : MonoBehaviour
	{
		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshPro _text;

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xBC5EBC", Offset = "0xBC5EBC", VA = "0xBC5EBC")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xBC5F78", Offset = "0xBC5F78", VA = "0xBC5F78")]
		public BuildNumberDisplay()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class InputMode : MonoBehaviour
	{
		[Token(Token = "0x6000631")]
		[Address(RVA = "0xBC5F80", Offset = "0xBC5F80", VA = "0xBC5F80")]
		public InputMode()
		{
		}
	}
	[Token(Token = "0x2000154")]
	[RequireComponent(typeof(Text))]
	public class InputReadout : MonoBehaviour
	{
		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Text _text;

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xBC5F88", Offset = "0xBC5F88", VA = "0xBC5F88")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xBC5FE0", Offset = "0xBC5FE0", VA = "0xBC5FE0")]
		public InputReadout()
		{
		}
	}
	[Token(Token = "0x2000155")]
	public static class RuntimeSettings
	{
		[Token(Token = "0x2000156")]
		public enum ViewMode
		{
			[Token(Token = "0x40005E7")]
			ThirdPerson,
			[Token(Token = "0x40005E8")]
			FirstPerson
		}

		[Token(Token = "0x1700009B")]
		public static ViewMode CurrentViewMode
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0xBC5FE8", Offset = "0xBC5FE8", VA = "0xBC5FE8")]
			[CompilerGenerated]
			get
			{
				return default(ViewMode);
			}
			[Token(Token = "0x6000635")]
			[Address(RVA = "0xBC6030", Offset = "0xBC6030", VA = "0xBC6030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x14000029")]
		public static event Action<ViewMode> OnViewModeChange
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0xBC607C", Offset = "0xBC607C", VA = "0xBC607C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000637")]
			[Address(RVA = "0xBC614C", Offset = "0xBC614C", VA = "0xBC614C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xBC621C", Offset = "0xBC621C", VA = "0xBC621C")]
		public static void UpdateViewMode(ViewMode mode)
		{
		}
	}
}
namespace Loci.Configs
{
	[Token(Token = "0x2000157")]
	public class ChapterConfig : MonoBehaviour
	{
		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Puzzle Outro")]
		public TweenConfig OutroLift;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TweenConfig OutroPushPosition;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweenConfig OutroPushScale;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TweenConfig OutroDrop;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Misc")]
		[SerializeField]
		private SerializableJointConfig _bouyancyJoint;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public JointConfig BouyancyJoint;

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xBC635C", Offset = "0xBC635C", VA = "0xBC635C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xBC6474", Offset = "0xBC6474", VA = "0xBC6474")]
		public ChapterConfig()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public class Curves : MonoBehaviour
	{
		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationCurve _pieceBob;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationCurve _easeIn;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve _easeOut;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _easeInAggro;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurve _easeOutAggro;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationCurve _puzzleFlyoff;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve _creditRoll;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Curves _instance;

		[Token(Token = "0x1700009C")]
		public static AnimationCurve PieceBob
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0xBBF398", Offset = "0xBBF398", VA = "0xBBF398")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public static AnimationCurve EaseIn
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0xBC6508", Offset = "0xBC6508", VA = "0xBC6508")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public static AnimationCurve EaseOut
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0xBC655C", Offset = "0xBC655C", VA = "0xBC655C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public static AnimationCurve EaseInAggro
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0xBC65B0", Offset = "0xBC65B0", VA = "0xBC65B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public static AnimationCurve EaseOutAggro
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0xBC6604", Offset = "0xBC6604", VA = "0xBC6604")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		public static AnimationCurve PuzzleFlyoff
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0xBC6658", Offset = "0xBC6658", VA = "0xBC6658")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		public static AnimationCurve CreditRoll
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0xBC66AC", Offset = "0xBC66AC", VA = "0xBC66AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xBC6700", Offset = "0xBC6700", VA = "0xBC6700")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xBC6758", Offset = "0xBC6758", VA = "0xBC6758")]
		public Curves()
		{
		}
	}
	[Token(Token = "0x2000159")]
	public class HandheldConfig : MonoBehaviour
	{
		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SerializableJointConfig _jointConfigEntry;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve PuzzleDoneDrift;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject InputVisualPrefab;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Rigidbody CenterVisualPrefab;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public JointConfig HandheldJointConfig;

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xBC6760", Offset = "0xBC6760", VA = "0xBC6760")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xBC67A8", Offset = "0xBC67A8", VA = "0xBC67A8")]
		public HandheldConfig()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015A")]
	public struct SerializableJointConfig
	{
		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float DriftDistance;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float TranslationSpring;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float TranslationDampening;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float RotationSpring;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float RotationDampening;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ConfigurableJointMotion TranslationMotion;
	}
	[Token(Token = "0x200015B")]
	public struct JointConfig
	{
		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float DriftDistance;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ConfigurableJointMotion TranslationMotion;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public JointDrive TranslationDrive;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public JointDrive RotationDrive;

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xBC63A0", Offset = "0xBC63A0", VA = "0xBC63A0")]
		public JointConfig(SerializableJointConfig config)
		{
		}
	}
}
namespace Loci.Finale
{
	[Token(Token = "0x200015C")]
	public class CreditsRoll : Chapter
	{
		[Serializable]
		[Token(Token = "0x200015D")]
		private struct Group
		{
			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform Root;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float SubmergeDepth;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float FloatHeight;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float RiseTime;
		}

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private MaterialLink[] _materialLink;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private Group[] _groups;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private ParticleSystem _houseFloaters;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[Inject]
		private MainCamera _mainCamera;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int _activeGroup;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private BaseTween _tween;

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xBC67B0", Offset = "0xBC67B0", VA = "0xBC67B0", Slot = "8")]
		public override void StartChapter()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xBC6EB4", Offset = "0xBC6EB4", VA = "0xBC6EB4", Slot = "7")]
		public override void ConfigureFromSave()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xBC6EB8", Offset = "0xBC6EB8", VA = "0xBC6EB8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xBC6818", Offset = "0xBC6818", VA = "0xBC6818")]
		private void PresentGroup()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xBC6ED8", Offset = "0xBC6ED8", VA = "0xBC6ED8")]
		public CreditsRoll()
		{
		}
	}
}
namespace Loci.Animation
{
	[Token(Token = "0x200015F")]
	public enum AnimationEvents
	{
		[Token(Token = "0x4000613")]
		Giant_SpawnHandheld,
		[Token(Token = "0x4000614")]
		Giant_ReleaseHandheld,
		[Token(Token = "0x4000615")]
		Giant_Despawn,
		[Token(Token = "0x4000616")]
		Giant_Chapter3PuzzleSpawn,
		[Token(Token = "0x4000617")]
		Giant_DeliverPuzzle,
		[Token(Token = "0x4000618")]
		Giant_GeodeForgeStart,
		[Token(Token = "0x4000619")]
		Giant_GeodeForgeEnd,
		[Token(Token = "0x400061A")]
		Giant_SummonPuzzle
	}
	[Token(Token = "0x2000160")]
	public static class AnimationListener
	{
		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int Track;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int Reset;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<AnimationEvents, List<Action>> _subscriptions;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Bootstrapper _bootstrapper;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static int InvokeGuard;

		[Token(Token = "0x170000A3")]
		private static Bootstrapper Bootstrapper
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0xBC7000", Offset = "0xBC7000", VA = "0xBC7000")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xBC7170", Offset = "0xBC7170", VA = "0xBC7170")]
		public static void Trigger(AnimationEvents evt, float delayMs)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xBC74B8", Offset = "0xBC74B8", VA = "0xBC74B8")]
		public static void Configure(Animator animator, GiantAnimationTrack track, float delayMs)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xBC3F40", Offset = "0xBC3F40", VA = "0xBC3F40")]
		public static void On(AnimationEvents evt, Action callback)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xBC41E0", Offset = "0xBC41E0", VA = "0xBC41E0")]
		public static void Off(AnimationEvents evt, Action callback)
		{
		}
	}
	[Token(Token = "0x2000165")]
	public class AnimationTrackChange : StateMachineBehaviour
	{
		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GiantAnimationTrack Track;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int DelayMs;

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xBC78DC", Offset = "0xBC78DC", VA = "0xBC78DC", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xBC7948", Offset = "0xBC7948", VA = "0xBC7948")]
		public AnimationTrackChange()
		{
		}
	}
	[Token(Token = "0x2000166")]
	public class AnimationTrigger : StateMachineBehaviour
	{
		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationEvents Event;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float DelayMs;

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xBC7950", Offset = "0xBC7950", VA = "0xBC7950", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xBC79B8", Offset = "0xBC79B8", VA = "0xBC79B8")]
		public AnimationTrigger()
		{
		}
	}
}
namespace Loci.Animals
{
	[Token(Token = "0x2000167")]
	public abstract class Animal : MonoBehaviour
	{
		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected SplineComputer _path;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected float _pathLength;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _speed;

		[Token(Token = "0x170000A4")]
		protected float _adjustedSpeed
		{
			[Token(Token = "0x6000663")]
			[Address(RVA = "0xBC79C0", Offset = "0xBC79C0", VA = "0xBC79C0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xBC79CC", Offset = "0xBC79CC", VA = "0xBC79CC")]
		[ContextMenu("Calculate Path Length")]
		private void CalculatePathLength()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xBC7AF0", Offset = "0xBC7AF0", VA = "0xBC7AF0")]
		protected Animal()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public class Bird : MonoBehaviour
	{
		[Token(Token = "0x2000169")]
		private enum Movement
		{
			[Token(Token = "0x4000638")]
			Grounded,
			[Token(Token = "0x4000639")]
			Inflight
		}

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int Anim_Takeoff;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int Anim_Land;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animator _animator;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SplineComputer _path;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _transform;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _speed;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Movement _state;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _takeoffTime;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _progression;

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xBC7B00", Offset = "0xBC7B00", VA = "0xBC7B00")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xBC7B94", Offset = "0xBC7B94", VA = "0xBC7B94")]
		private void Update()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xBC7D24", Offset = "0xBC7D24", VA = "0xBC7D24")]
		public void Takeoff()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xBC7C7C", Offset = "0xBC7C7C", VA = "0xBC7C7C")]
		public void Land()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xBC7D9C", Offset = "0xBC7D9C", VA = "0xBC7D9C")]
		public Bird()
		{
		}
	}
	[Token(Token = "0x200016A")]
	public class Dolphin : Animal
	{
		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int Anim_Jump;

		[Token(Token = "0x400063B")]
		private const float JUMP_MIN = 5f;

		[Token(Token = "0x400063C")]
		private const float JUMP_MAX = 20f;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _transform;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animator[] _animators;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudioSource _audio;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AudioClip[] _soundClips;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _progression;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] _nextJumps;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _lastSfx;

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xBC7E4C", Offset = "0xBC7E4C", VA = "0xBC7E4C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xBC7F8C", Offset = "0xBC7F8C", VA = "0xBC7F8C")]
		private void Update()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xBC7EE8", Offset = "0xBC7EE8", VA = "0xBC7EE8")]
		private void CalculateJump(int i)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xBC8134", Offset = "0xBC8134", VA = "0xBC8134")]
		[ContextMenu("Set at Start")]
		private void SetAtStart()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xBC8198", Offset = "0xBC8198", VA = "0xBC8198")]
		public Dolphin()
		{
		}
	}
	[Token(Token = "0x200016B")]
	public class NoLandBird : MonoBehaviour
	{
		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SplineComputer _path;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _speed;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _animSpeedMod;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _progression;

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xBC8210", Offset = "0xBC8210", VA = "0xBC8210")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xBC8314", Offset = "0xBC8314", VA = "0xBC8314")]
		private void Update()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xBC83E8", Offset = "0xBC83E8", VA = "0xBC83E8")]
		public NoLandBird()
		{
		}
	}
	[Token(Token = "0x200016C")]
	public class Reindeer : MonoBehaviour
	{
		[Token(Token = "0x6000675")]
		[Address(RVA = "0xBC83F8", Offset = "0xBC83F8", VA = "0xBC83F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xBC848C", Offset = "0xBC848C", VA = "0xBC848C")]
		public Reindeer()
		{
		}
	}
	[Token(Token = "0x200016E")]
	public class Walrus : MonoBehaviour
	{
		[Token(Token = "0x600067E")]
		[Address(RVA = "0xBC8640", Offset = "0xBC8640", VA = "0xBC8640")]
		private void Awake()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xBC86D4", Offset = "0xBC86D4", VA = "0xBC86D4")]
		public Walrus()
		{
		}
	}
}
namespace MikeVR.Water
{
	[Token(Token = "0x2000170")]
	public class UnderwaterPass : ScriptableRenderPass
	{
		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int WaterReflection;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly GlobalKeyword _underwaterGlobal;

		[Token(Token = "0x4000650")]
		private const int WATER_LAYER = 16;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly List<ShaderTagId> ShaderTags;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RTHandle _waterRT;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderStateBlock _waterRenderState;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private FilteringSettings _opaqueFilter;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private FilteringSettings _transparentFilter;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		public float RenderScale;

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xBC8888", Offset = "0xBC8888", VA = "0xBC8888")]
		public UnderwaterPass()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xBC8C94", Offset = "0xBC8C94", VA = "0xBC8C94", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xBC8EC4", Offset = "0xBC8EC4", VA = "0xBC8EC4", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xBC92E4", Offset = "0xBC92E4", VA = "0xBC92E4", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xBC90D8", Offset = "0xBC90D8", VA = "0xBC90D8")]
		private void RenderSkybox(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData)
		{
		}
	}
}
namespace MikeVR.Source
{
	[Token(Token = "0x2000171")]
	[RequireComponent(typeof(Camera))]
	public class ScreenshotGenerator : MonoBehaviour
	{
		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Width;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Height;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Camera _camera;

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xBC9430", Offset = "0xBC9430", VA = "0xBC9430")]
		[ContextMenu("Capture Image")]
		private void Capture()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xBC9674", Offset = "0xBC9674", VA = "0xBC9674")]
		public ScreenshotGenerator()
		{
		}
	}
}
namespace MikeVR.Source.Util
{
	[Token(Token = "0x2000172")]
	[ExecuteInEditMode]
	public class AmbientProbeController : MonoBehaviour
	{
		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SphericalHarmonicsL2 AmbientProbe;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private SphericalHarmonicsL2 _ref;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public float ReflectionIntensity;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float _reflIntensity;

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xBC967C", Offset = "0xBC967C", VA = "0xBC967C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xBC9734", Offset = "0xBC9734", VA = "0xBC9734")]
		public AmbientProbeController()
		{
		}
	}
	[Token(Token = "0x2000173")]
	[RequireComponent(typeof(PlayableDirector))]
	public class AssistantDirector : MonoBehaviour
	{
		[Token(Token = "0x2000174")]
		private enum ActualState
		{
			[Token(Token = "0x4000663")]
			Playing,
			[Token(Token = "0x4000664")]
			Stopped,
			[Token(Token = "0x4000665")]
			AtTheEndButTechnicallyNotStopped
		}

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayableDirector _director;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ActualState _state;

		[Token(Token = "0x170000A9")]
		public float Time
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0xBC99AC", Offset = "0xBC99AC", VA = "0xBC99AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000AA")]
		public bool IsPlaying
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0xBC99D0", Offset = "0xBC99D0", VA = "0xBC99D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AB")]
		private bool IsAtEnd
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0xBC99E0", Offset = "0xBC99E0", VA = "0xBC99E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1400002A")]
		public event Action Paused
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0xBC973C", Offset = "0xBC973C", VA = "0xBC973C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000692")]
			[Address(RVA = "0xBC97D8", Offset = "0xBC97D8", VA = "0xBC97D8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400002B")]
		public event Action Complete
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0xBC9874", Offset = "0xBC9874", VA = "0xBC9874")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000694")]
			[Address(RVA = "0xBC9910", Offset = "0xBC9910", VA = "0xBC9910")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xBC9A78", Offset = "0xBC9A78", VA = "0xBC9A78")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xBC9BAC", Offset = "0xBC9BAC", VA = "0xBC9BAC")]
		private void Update()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xBC9C58", Offset = "0xBC9C58", VA = "0xBC9C58")]
		public void ClearAllSubscriptions()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xBC9C80", Offset = "0xBC9C80", VA = "0xBC9C80")]
		public void Play()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xBC9CA4", Offset = "0xBC9CA4", VA = "0xBC9CA4")]
		public void Stop()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xBC9CC0", Offset = "0xBC9CC0", VA = "0xBC9CC0")]
		public void Pause()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xBC9CDC", Offset = "0xBC9CDC", VA = "0xBC9CDC")]
		public void SetToTime(float time)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xBC9D10", Offset = "0xBC9D10", VA = "0xBC9D10")]
		public void SetToEnd()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xBC9D3C", Offset = "0xBC9D3C", VA = "0xBC9D3C")]
		private void OnPause(PlayableDirector obj)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xBC9D60", Offset = "0xBC9D60", VA = "0xBC9D60")]
		private void OnStopped(PlayableDirector obj)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xBC9E9C", Offset = "0xBC9E9C", VA = "0xBC9E9C")]
		public AssistantDirector()
		{
		}
	}
	[Token(Token = "0x2000175")]
	public class Billboard : InjectableMonobehavior
	{
		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Inject]
		private MainCamera _camera;

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xBC9EA4", Offset = "0xBC9EA4", VA = "0xBC9EA4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xBC9EE8", Offset = "0xBC9EE8", VA = "0xBC9EE8")]
		public Billboard()
		{
		}
	}
	[Token(Token = "0x2000176")]
	public class ControllerFadeGroup : MonoBehaviour
	{
		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material Material;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshPro[] Text;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Line[] Line;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int _Alpha;

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xBC9EF0", Offset = "0xBC9EF0", VA = "0xBC9EF0")]
		public void ShowAll()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xBCA15C", Offset = "0xBCA15C", VA = "0xBCA15C")]
		public void HideHelpers()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xBCA280", Offset = "0xBCA280", VA = "0xBCA280")]
		public ControllerFadeGroup()
		{
		}
	}
	[Token(Token = "0x2000177")]
	[ExecuteInEditMode]
	public class EmissionController : MonoBehaviour
	{
		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int _EmissionColor;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int _Metallic;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int _Smoothness;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int _VertexEmit;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material _material;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Color _emissionColor;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _metallic;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _smoothness;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _vertexEmit;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color EmissionColor;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float Metallic;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Smoothness;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float VertexEmit;

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xBCA4A8", Offset = "0xBCA4A8", VA = "0xBCA4A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xBCA648", Offset = "0xBCA648", VA = "0xBCA648")]
		public EmissionController()
		{
		}
	}
	[Token(Token = "0x2000178")]
	public class MaterialLink : MonoBehaviour
	{
		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly List<MaterialLink> Active;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("_material")]
		public Material Material;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material _altMaterial;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ColorUsed;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string ColorProperty;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color ColorValue;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color _lastColorVal;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _colorPropertyId;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool FloatUsed;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string FloatProperty;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float FloatValue;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _lastFloatVal;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _floatPropertyId;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool _initialized;

		[Token(Token = "0x170000AC")]
		public Material AltMaterial
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0xBCA74C", Offset = "0xBCA74C", VA = "0xBCA74C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xBCA754", Offset = "0xBCA754", VA = "0xBCA754")]
			set
			{
			}
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xBCA828", Offset = "0xBCA828", VA = "0xBCA828")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xBCA928", Offset = "0xBCA928", VA = "0xBCA928")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xBCA82C", Offset = "0xBCA82C", VA = "0xBCA82C")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xBCA9A8", Offset = "0xBCA9A8", VA = "0xBCA9A8")]
		public void ForceUpdateMaterial(Material material)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xBCAA84", Offset = "0xBCAA84", VA = "0xBCAA84")]
		private void Update()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xBCAA9C", Offset = "0xBCAA9C", VA = "0xBCAA9C")]
		private void UpdateColor()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xBCAB4C", Offset = "0xBCAB4C", VA = "0xBCAB4C")]
		private void UpdateFloat()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xBCA770", Offset = "0xBCA770", VA = "0xBCA770")]
		private void ForceUpdateAltMaterial()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xBCABC8", Offset = "0xBCABC8", VA = "0xBCABC8")]
		public MaterialLink()
		{
		}
	}
	[Token(Token = "0x2000179")]
	[ExecuteInEditMode]
	public class ReflectionProbeLinker : MonoBehaviour
	{
		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ReflectionProbe _probe;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _lastIntensity;

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xBCAC7C", Offset = "0xBCAC7C", VA = "0xBCAC7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xBCACD4", Offset = "0xBCACD4", VA = "0xBCACD4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xBCAD24", Offset = "0xBCAD24", VA = "0xBCAD24")]
		public ReflectionProbeLinker()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public class RelocationField : MonoBehaviour
	{
		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Collider Field;

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xBCAD2C", Offset = "0xBCAD2C", VA = "0xBCAD2C")]
		public RelocationField()
		{
		}
	}
	[Token(Token = "0x200017B")]
	[ExecuteInEditMode]
	public class RimLink : MonoBehaviour
	{
		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int RimColor;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material _material;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color Rim;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color _rim;

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xBCAD34", Offset = "0xBCAD34", VA = "0xBCAD34")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xBCADF8", Offset = "0xBCADF8", VA = "0xBCADF8")]
		public RimLink()
		{
		}
	}
	[Token(Token = "0x200017C")]
	[ExecuteInEditMode]
	public class SHController : MonoBehaviour
	{
		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] _shValues;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SphericalHarmonicsL2 _ambientProbe;

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xBCAE68", Offset = "0xBCAE68", VA = "0xBCAE68")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xBCAFB0", Offset = "0xBCAFB0", VA = "0xBCAFB0")]
		public SHController()
		{
		}
	}
	[Token(Token = "0x200017D")]
	public static class SH_Util
	{
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xBCAFB8", Offset = "0xBCAFB8", VA = "0xBCAFB8")]
		public static bool AreEqual(SphericalHarmonicsL2 a, SphericalHarmonicsL2 b)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xBCB050", Offset = "0xBCB050", VA = "0xBCB050")]
		public static SphericalHarmonicsL2 Lerp(SphericalHarmonicsL2 a, SphericalHarmonicsL2 b, float f)
		{
			return default(SphericalHarmonicsL2);
		}
	}
	[Token(Token = "0x200017E")]
	public static class SplineUtil
	{
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xBCB12C", Offset = "0xBCB12C", VA = "0xBCB12C")]
		public static Tween<float> SplineTween(Vector3[] points, Action<Vector3> update, TweenConfig config)
		{
			return null;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xBBF3F4", Offset = "0xBBF3F4", VA = "0xBBF3F4")]
		public static Tween<float> RelocationTween(Vector3 start, Vector3 end, Action<Vector3> update)
		{
			return null;
		}
	}
	[Token(Token = "0x2000181")]
	[ExecuteInEditMode]
	public class VoidController : MonoBehaviour
	{
		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int _VoidSrcWS;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int _VoidPull;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int _VoidColor;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _distance;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Color _color;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 _voidSrcWS;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color _voidColor;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _voidPull;

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xBCB5A0", Offset = "0xBCB5A0", VA = "0xBCB5A0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xBCB650", Offset = "0xBCB650", VA = "0xBCB650")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xBCB744", Offset = "0xBCB744", VA = "0xBCB744")]
		public VoidController()
		{
		}
	}
}
namespace MikeVR.Libraries.PostProcessing
{
	[Token(Token = "0x2000182")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class Bloom : MonoBehaviour
	{
		[Token(Token = "0x2000183")]
		public enum DownsampleRatio
		{
			[Token(Token = "0x40006AF")]
			[InspectorName("0.5")]
			x2 = 2,
			[Token(Token = "0x40006B0")]
			[InspectorName("0.25")]
			x4 = 4,
			[Token(Token = "0x40006B1")]
			[InspectorName("0.125")]
			x8 = 8
		}

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int _SampleStride;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int _OriginalTex;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int _DstBlend;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int _Prefilter;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int _Intensity;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int _Threshold;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int _Color;

		[Token(Token = "0x40006A4")]
		private const float DOWNSAMPLE_STRIDE = 1f;

		[Token(Token = "0x40006A5")]
		private const float UPSAMPLE_STRIDE = 0.5f;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material Material;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(1f, 8f)]
		public int Passes;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public DownsampleRatio TextureRatio;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 30f)]
		public float Intensity;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 5f)]
		public float Threshold;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color Color;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _passes;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture[] _rtPool;

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xBCB814", Offset = "0xBCB814", VA = "0xBCB814")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xBCB900", Offset = "0xBCB900", VA = "0xBCB900")]
		private void OnRenderImage(RenderTexture image, RenderTexture canvas)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xBCC23C", Offset = "0xBCC23C", VA = "0xBCC23C")]
		public Bloom()
		{
		}
	}
}
namespace ColliderCombiner
{
	[Token(Token = "0x2000184")]
	public class ColliderCombiner : MonoBehaviour
	{
		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CombineResults Results;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Settings _settings;

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xBCC3E8", Offset = "0xBCC3E8", VA = "0xBCC3E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xBCC3EC", Offset = "0xBCC3EC", VA = "0xBCC3EC")]
		private void CreateMesh()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xBCC3F0", Offset = "0xBCC3F0", VA = "0xBCC3F0")]
		public ColliderCombiner()
		{
		}
	}
	[Token(Token = "0x2000185")]
	public class CombineResults : ScriptableObject
	{
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xBCC3F8", Offset = "0xBCC3F8", VA = "0xBCC3F8")]
		public CombineResults()
		{
		}
	}
	[Token(Token = "0x2000186")]
	public class Settings : ScriptableObject
	{
		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IncludeInactive;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool DeactivateAfter;

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xBCC400", Offset = "0xBCC400", VA = "0xBCC400")]
		public Settings()
		{
		}
	}
	[Token(Token = "0x2000187")]
	public class Survey
	{
		[Token(Token = "0x2000188")]
		public class Entry
		{
			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Collider Collider;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool Valid;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string InvalidReason;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool UserOmitted;

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0xBCC594", Offset = "0xBCC594", VA = "0xBCC594")]
			public Entry()
			{
			}
		}

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<Entry> _entries;

		[Token(Token = "0x170000AD")]
		public IReadOnlyList<Entry> Entries
		{
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0xBCC410", Offset = "0xBCC410", VA = "0xBCC410")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		public int ValidCount
		{
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0xBCC418", Offset = "0xBCC418", VA = "0xBCC418")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0xBCC420", Offset = "0xBCC420", VA = "0xBCC420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public int TotalCount
		{
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0xBCC428", Offset = "0xBCC428", VA = "0xBCC428")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0xBCC430", Offset = "0xBCC430", VA = "0xBCC430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xBCC438", Offset = "0xBCC438", VA = "0xBCC438")]
		public void AddEntry(Entry entry)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xBCC50C", Offset = "0xBCC50C", VA = "0xBCC50C")]
		public Survey()
		{
		}
	}
	[Token(Token = "0x2000189")]
	public static class MeshGeneration
	{
	}
}
