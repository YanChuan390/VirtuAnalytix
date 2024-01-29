using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class ExampleScript : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text batteryText;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool auto;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool activeResearch;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float autoTimer;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float autoDelay;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private ForceTubeVRChannel target;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xC12C1C", Offset = "0xC12C1C", VA = "0xC12C1C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xC12DE8", Offset = "0xC12DE8", VA = "0xC12DE8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xC1323C", Offset = "0xC1323C", VA = "0xC1323C")]
	public void Shoot()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xC132BC", Offset = "0xC132BC", VA = "0xC132BC")]
	public void AutoShoot()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xC132CC", Offset = "0xC132CC", VA = "0xC132CC")]
	public void Kick()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xC134C0", Offset = "0xC134C0", VA = "0xC134C0")]
	public void Rumble()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xC13730", Offset = "0xC13730", VA = "0xC13730")]
	public void SetTargetChannel(int target)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xC13738", Offset = "0xC13738", VA = "0xC13738")]
	public void SetActiveResearch()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xC13900", Offset = "0xC13900", VA = "0xC13900")]
	public void OpenBluetoothSettings()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xC13A38", Offset = "0xC13A38", VA = "0xC13A38")]
	public ExampleScript()
	{
	}
}
[Token(Token = "0x2000003")]
public enum ForceTubeVRChannel
{
	[Token(Token = "0x4000008")]
	all,
	[Token(Token = "0x4000009")]
	rifle,
	[Token(Token = "0x400000A")]
	rifleButt,
	[Token(Token = "0x400000B")]
	rifleBolt,
	[Token(Token = "0x400000C")]
	pistol1,
	[Token(Token = "0x400000D")]
	pistol2,
	[Token(Token = "0x400000E")]
	other,
	[Token(Token = "0x400000F")]
	vest
}
[Token(Token = "0x2000004")]
public class ForceTubeVRInterface : MonoBehaviour
{
	[Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class <InitAndroid>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool pistolsFirst;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0xC140D4", Offset = "0xC140D4", VA = "0xC140D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0xC1411C", Offset = "0xC1411C", VA = "0xC1411C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xC13AC0", Offset = "0xC13AC0", VA = "0xC13AC0")]
		[DebuggerHidden]
		public <InitAndroid>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xC13CF4", Offset = "0xC13CF4", VA = "0xC13CF4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xC13CF8", Offset = "0xC13CF8", VA = "0xC13CF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xC140DC", Offset = "0xC140DC", VA = "0xC140DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ForceTubeVRInterface instance;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static AndroidJavaObject ForceTubeVRPlugin;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xC13A54", Offset = "0xC13A54", VA = "0xC13A54")]
	[IteratorStateMachine(typeof(<InitAndroid>d__2))]
	private static IEnumerator InitAndroid(bool pistolsFirst)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xC12C8C", Offset = "0xC12C8C", VA = "0xC12C8C")]
	public static void InitAsync(bool pistolsFirst = false)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xC13344", Offset = "0xC13344", VA = "0xC13344")]
	public static void Kick(byte power, ForceTubeVRChannel target = ForceTubeVRChannel.rifle)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xC1353C", Offset = "0xC1353C", VA = "0xC1353C")]
	public static void Rumble(byte power, float duration, ForceTubeVRChannel target = ForceTubeVRChannel.rifle)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xC12F10", Offset = "0xC12F10", VA = "0xC12F10")]
	public static void Shoot(byte kickPower, byte rumblePower, float rumbleDuration, ForceTubeVRChannel target = ForceTubeVRChannel.rifle)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xC137E8", Offset = "0xC137E8", VA = "0xC137E8")]
	public static void SetActiveResearch(bool active)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xC13AE8", Offset = "0xC13AE8", VA = "0xC13AE8")]
	public static byte TempoToKickPower(float tempo)
	{
		return default(byte);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xC13158", Offset = "0xC13158", VA = "0xC13158")]
	public static byte GetBatteryLevel()
	{
		return default(byte);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xC1396C", Offset = "0xC1396C", VA = "0xC1396C")]
	public static void OpenBluetoothSettings()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xC13C20", Offset = "0xC13C20", VA = "0xC13C20")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xC13CEC", Offset = "0xC13CEC", VA = "0xC13CEC")]
	public ForceTubeVRInterface()
	{
	}
}
namespace VLB
{
	[Token(Token = "0x2000006")]
	public static class BatchingHelper
	{
		[Token(Token = "0x4000015")]
		public const bool isGpuInstancingSupported = true;

		[Token(Token = "0x17000003")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0xC14124", Offset = "0xC14124", VA = "0xC14124")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xC141C4", Offset = "0xC141C4", VA = "0xC141C4")]
		public static bool IsGpuInstancingEnabled(Material material)
		{
			return default(bool);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xC141D8", Offset = "0xC141D8", VA = "0xC141D8")]
		public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xC141F0", Offset = "0xC141F0", VA = "0xC141F0")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xC1477C", Offset = "0xC1477C", VA = "0xC1477C")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xC148E8", Offset = "0xC148E8", VA = "0xC148E8")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x2000007")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	[ExecuteInEditMode]
	[AddComponentMenu("")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
	{
		[Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class <CoUpdateFadeOut>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x1700000F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000052")]
				[Address(RVA = "0xC18EB8", Offset = "0xC18EB8", VA = "0xC18EB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000010")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000054")]
				[Address(RVA = "0xC18F00", Offset = "0xC18F00", VA = "0xC18F00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600004F")]
			[Address(RVA = "0xC14C54", Offset = "0xC14C54", VA = "0xC14C54")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000050")]
			[Address(RVA = "0xC18E18", Offset = "0xC18E18", VA = "0xC18E18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000051")]
			[Address(RVA = "0xC18E1C", Offset = "0xC18E1C", VA = "0xC18E1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000053")]
			[Address(RVA = "0xC18EC0", Offset = "0xC18EC0", VA = "0xC18EC0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_CustomMaterial;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private MaterialModifier.Callback m_MaterialModifierCallback;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Coroutine m_CoFadeOut;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Camera m_CurrentCameraRenderingSRP;

		[Token(Token = "0x17000004")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0xC149C0", Offset = "0xC149C0", VA = "0xC149C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0xC149C8", Offset = "0xC149C8", VA = "0xC149C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0xC149D0", Offset = "0xC149D0", VA = "0xC149D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0xC149D8", Offset = "0xC149D8", VA = "0xC149D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public Mesh coneMesh
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0xC149E0", Offset = "0xC149E0", VA = "0xC149E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0xC149E8", Offset = "0xC149E8", VA = "0xC149E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public bool visible
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0xC149F0", Offset = "0xC149F0", VA = "0xC149F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0xC14A0C", Offset = "0xC14A0C", VA = "0xC14A0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public int sortingLayerID
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0xC14A2C", Offset = "0xC14A2C", VA = "0xC14A2C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600002B")]
			[Address(RVA = "0xC14A48", Offset = "0xC14A48", VA = "0xC14A48")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public int sortingOrder
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0xC14A64", Offset = "0xC14A64", VA = "0xC14A64")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0xC14A80", Offset = "0xC14A80", VA = "0xC14A80")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0xC14A9C", Offset = "0xC14A9C", VA = "0xC14A9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0xC153A4", Offset = "0xC153A4", VA = "0xC153A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0xC153AC", Offset = "0xC153AC", VA = "0xC153AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0xC17200", Offset = "0xC17200", VA = "0xC17200")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0xC172F4", Offset = "0xC172F4", VA = "0xC172F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xC14AAC", Offset = "0xC14AAC", VA = "0xC14AAC")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xC14BE0", Offset = "0xC14BE0", VA = "0xC14BE0")]
		[IteratorStateMachine(typeof(<CoUpdateFadeOut>d__30))]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xC14C7C", Offset = "0xC14C7C", VA = "0xC14C7C")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xC14D84", Offset = "0xC14D84", VA = "0xC14D84")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xC15094", Offset = "0xC15094", VA = "0xC15094")]
		public void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xC15174", Offset = "0xC15174", VA = "0xC15174")]
		private void Start()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xC15210", Offset = "0xC15210", VA = "0xC15210")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xC152AC", Offset = "0xC152AC", VA = "0xC152AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xC15424", Offset = "0xC15424", VA = "0xC15424")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xC15520", Offset = "0xC15520", VA = "0xC15520")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xC15C8C", Offset = "0xC15C8C", VA = "0xC15C8C")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xC16FB8", Offset = "0xC16FB8", VA = "0xC16FB8")]
		private Vector3 ComputeLocalMatrix()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xC159B4", Offset = "0xC159B4", VA = "0xC159B4")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xC14EF4", Offset = "0xC14EF4", VA = "0xC14EF4", Slot = "4")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xC17A04", Offset = "0xC17A04", VA = "0xC17A04", Slot = "5")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xC17B1C", Offset = "0xC17B1C", VA = "0xC17B1C", Slot = "6")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xC17C34", Offset = "0xC17C34", VA = "0xC17C34", Slot = "7")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xC17D64", Offset = "0xC17D64", VA = "0xC17D64", Slot = "8")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xC14E3C", Offset = "0xC14E3C", VA = "0xC14E3C")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xC14FDC", Offset = "0xC14FDC", VA = "0xC14FDC")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xC17E40", Offset = "0xC17E40", VA = "0xC17E40")]
		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xC16894", Offset = "0xC16894", VA = "0xC16894")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xC18610", Offset = "0xC18610", VA = "0xC18610")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xC18808", Offset = "0xC18808", VA = "0xC18808")]
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xC18814", Offset = "0xC18814", VA = "0xC18814")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xC18844", Offset = "0xC18844", VA = "0xC18844")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xC18928", Offset = "0xC18928", VA = "0xC18928")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xC18E10", Offset = "0xC18E10", VA = "0xC18E10")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000009")]
	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x4000023")]
		public const string ClassName = "Config";

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[FormerlySerializedAs("renderPipeline")]
		private RenderPipeline _RenderPipeline;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("renderingMode")]
		private RenderingMode _RenderingMode;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float ditheringFactor;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int sharedMeshSides;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int sharedMeshSegments;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0.01f, 2f)]
		public float globalNoiseScale;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string fadeOutCameraTag;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HighlightNull]
		public Texture3D noiseTexture3D;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture2D ditheringNoiseTexture;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public FeatureEnabledColorGradient featureEnabledColorGradient;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool featureEnabledDepthBlend;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		public bool featureEnabledNoise3D;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x76")]
		public bool featureEnabledDynamicOcclusion;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x77")]
		public bool featureEnabledMeshSkewing;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool featureEnabledShaderAccuracyHigh;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Material _DummyMaterial;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Shader _BeamShader;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Config ms_Instance;

		[Token(Token = "0x17000011")]
		public RenderPipeline renderPipeline
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0xC18F08", Offset = "0xC18F08", VA = "0xC18F08")]
			get
			{
				return default(RenderPipeline);
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xC18F10", Offset = "0xC18F10", VA = "0xC18F10")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public RenderingMode renderingMode
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xC18F78", Offset = "0xC18F78", VA = "0xC18F78")]
			get
			{
				return default(RenderingMode);
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xC18F80", Offset = "0xC18F80", VA = "0xC18F80")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xC14174", Offset = "0xC14174", VA = "0xC14174")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000014")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0xC1907C", Offset = "0xC1907C", VA = "0xC1907C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public bool requiresDoubleSidedMesh
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0xC15F0C", Offset = "0xC15F0C", VA = "0xC15F0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000016")]
		public Shader beamShader
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0xC19094", Offset = "0xC19094", VA = "0xC19094")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0xC14D10", Offset = "0xC14D10", VA = "0xC14D10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public bool hasRenderPipelineMismatch
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0xC1913C", Offset = "0xC1913C", VA = "0xC1913C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000019")]
		public static Config Instance
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0xC1416C", Offset = "0xC1416C", VA = "0xC1416C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xC18FE8", Offset = "0xC18FE8", VA = "0xC18FE8")]
		public bool IsSRPBatcherSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xC1909C", Offset = "0xC1909C", VA = "0xC1909C")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xC19168", Offset = "0xC19168", VA = "0xC19168")]
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xC19308", Offset = "0xC19308", VA = "0xC19308")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xC1924C", Offset = "0xC1924C", VA = "0xC1924C")]
		private void RefreshGlobalShaderProperties()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xC19414", Offset = "0xC19414", VA = "0xC19414")]
		public void ResetInternalData()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xC19610", Offset = "0xC19610", VA = "0xC19610")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xC197B0", Offset = "0xC197B0", VA = "0xC197B0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xC197BC", Offset = "0xC197BC", VA = "0xC197BC")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xC197C0", Offset = "0xC197C0", VA = "0xC197C0")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xC1993C", Offset = "0xC1993C", VA = "0xC1993C")]
		public Config()
		{
		}
	}
	[Token(Token = "0x200000A")]
	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x400003E")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xC19A4C", Offset = "0xC19A4C", VA = "0xC19A4C")]
		public ConfigOverride()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public static class Consts
	{
		[Token(Token = "0x200000C")]
		public static class Help
		{
			[Token(Token = "0x4000040")]
			private const string UrlBase = "http://saladgamer.com/vlb-doc/";

			[Token(Token = "0x4000041")]
			public const string UrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

			[Token(Token = "0x4000042")]
			public const string UrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

			[Token(Token = "0x4000043")]
			public const string UrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/";

			[Token(Token = "0x4000044")]
			public const string UrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/";

			[Token(Token = "0x4000045")]
			public const string UrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

			[Token(Token = "0x4000046")]
			public const string UrlSkewingHandle = "http://saladgamer.com/vlb-doc/comp-skewinghandle/";

			[Token(Token = "0x4000047")]
			public const string UrlEffectFlicker = "http://saladgamer.com/vlb-doc/comp-effect-flicker/";

			[Token(Token = "0x4000048")]
			public const string UrlEffectPulse = "http://saladgamer.com/vlb-doc/comp-effect-pulse/";

			[Token(Token = "0x4000049")]
			public const string UrlConfig = "http://saladgamer.com/vlb-doc/config/";
		}

		[Token(Token = "0x200000D")]
		public static class Internal
		{
			[Token(Token = "0x400004A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly bool ProceduralObjectsVisibleInEditor;

			[Token(Token = "0x1700001A")]
			public static HideFlags ProceduralObjectsHideFlags
			{
				[Token(Token = "0x600006C")]
				[Address(RVA = "0xC15844", Offset = "0xC15844", VA = "0xC15844")]
				get
				{
					return default(HideFlags);
				}
			}
		}

		[Token(Token = "0x200000E")]
		public static class Beam
		{
			[Token(Token = "0x400004B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Color FlatColor;

			[Token(Token = "0x400004C")]
			public const ColorMode ColorModeDefault = ColorMode.Flat;

			[Token(Token = "0x400004D")]
			public const float IntensityDefault = 1f;

			[Token(Token = "0x400004E")]
			public const float IntensityMin = 0f;

			[Token(Token = "0x400004F")]
			public const float SpotAngleDefault = 35f;

			[Token(Token = "0x4000050")]
			public const float SpotAngleMin = 0.1f;

			[Token(Token = "0x4000051")]
			public const float SpotAngleMax = 179.9f;

			[Token(Token = "0x4000052")]
			public const float ConeRadiusStart = 0.1f;

			[Token(Token = "0x4000053")]
			public const MeshType GeomMeshType = MeshType.Shared;

			[Token(Token = "0x4000054")]
			public const int GeomSidesDefault = 18;

			[Token(Token = "0x4000055")]
			public const int GeomSidesMin = 3;

			[Token(Token = "0x4000056")]
			public const int GeomSidesMax = 256;

			[Token(Token = "0x4000057")]
			public const int GeomSegmentsDefault = 5;

			[Token(Token = "0x4000058")]
			public const int GeomSegmentsMin = 0;

			[Token(Token = "0x4000059")]
			public const int GeomSegmentsMax = 64;

			[Token(Token = "0x400005A")]
			public const bool GeomCap = false;

			[Token(Token = "0x400005B")]
			public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

			[Token(Token = "0x400005C")]
			public const float AttenuationCustomBlending = 0.5f;

			[Token(Token = "0x400005D")]
			public const float FallOffStart = 0f;

			[Token(Token = "0x400005E")]
			public const float FallOffEnd = 3f;

			[Token(Token = "0x400005F")]
			public const float FallOffDistancesMinThreshold = 0.01f;

			[Token(Token = "0x4000060")]
			public const float DepthBlendDistance = 2f;

			[Token(Token = "0x4000061")]
			public const float CameraClippingDistance = 0.5f;

			[Token(Token = "0x4000062")]
			public const float FresnelPowMaxValue = 10f;

			[Token(Token = "0x4000063")]
			public const float FresnelPow = 8f;

			[Token(Token = "0x4000064")]
			public const float GlareFrontal = 0.5f;

			[Token(Token = "0x4000065")]
			public const float GlareBehind = 0.5f;

			[Token(Token = "0x4000066")]
			public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

			[Token(Token = "0x4000067")]
			public const float NoiseIntensityMin = 0f;

			[Token(Token = "0x4000068")]
			public const float NoiseIntensityMax = 1f;

			[Token(Token = "0x4000069")]
			public const float NoiseIntensityDefault = 0.5f;

			[Token(Token = "0x400006A")]
			public const float NoiseScaleMin = 0.01f;

			[Token(Token = "0x400006B")]
			public const float NoiseScaleMax = 2f;

			[Token(Token = "0x400006C")]
			public const float NoiseScaleDefault = 0.5f;

			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly Vector3 NoiseVelocityDefault;

			[Token(Token = "0x400006E")]
			public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

			[Token(Token = "0x400006F")]
			public const ShaderAccuracy ShaderAccuracyDefault = ShaderAccuracy.Fast;

			[Token(Token = "0x4000070")]
			public const float FadeOutBeginDefault = -150f;

			[Token(Token = "0x4000071")]
			public const float FadeOutEndDefault = -200f;

			[Token(Token = "0x4000072")]
			public const Dimensions DimensionsDefault = Dimensions.Dim3D;

			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static readonly Vector2 TiltDefault;

			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public static readonly Vector3 SkewingLocalForwardDirectionDefault;

			[Token(Token = "0x4000075")]
			public const Transform ClippingPlaneTransformDefault = null;
		}

		[Token(Token = "0x200000F")]
		public static class DustParticles
		{
			[Token(Token = "0x4000076")]
			public const float AlphaDefault = 0.5f;

			[Token(Token = "0x4000077")]
			public const float SizeDefault = 0.01f;

			[Token(Token = "0x4000078")]
			public const ParticlesDirection DirectionDefault = ParticlesDirection.Random;

			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Vector3 VelocityDefault;

			[Token(Token = "0x400007A")]
			public const float DensityDefault = 5f;

			[Token(Token = "0x400007B")]
			public const float DensityMin = 0f;

			[Token(Token = "0x400007C")]
			public const float DensityMax = 1000f;

			[Token(Token = "0x400007D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly MinMaxRangeFloat SpawnDistanceRangeDefault;

			[Token(Token = "0x400007E")]
			public const bool CullingEnabledDefault = false;

			[Token(Token = "0x400007F")]
			public const float CullingMaxDistanceDefault = 10f;

			[Token(Token = "0x4000080")]
			public const float CullingMaxDistanceMin = 1f;
		}

		[Token(Token = "0x2000010")]
		public static class DynOcclusion
		{
			[Token(Token = "0x4000081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly LayerMask LayerMaskDefault;

			[Token(Token = "0x4000082")]
			public const float FadeDistanceToSurfaceDefault = 0.25f;

			[Token(Token = "0x4000083")]
			public const DynamicOcclusionUpdateRate UpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames;

			[Token(Token = "0x4000084")]
			public const int WaitFramesCountDefault = 3;

			[Token(Token = "0x4000085")]
			public const Dimensions RaycastingDimensionsDefault = Dimensions.Dim3D;

			[Token(Token = "0x4000086")]
			public const bool RaycastingConsiderTriggersDefault = false;

			[Token(Token = "0x4000087")]
			public const float RaycastingMinOccluderAreaDefault = 0f;

			[Token(Token = "0x4000088")]
			public const float RaycastingMinSurfaceRatioDefault = 0.5f;

			[Token(Token = "0x4000089")]
			public const float RaycastingMinSurfaceRatioMin = 50f;

			[Token(Token = "0x400008A")]
			public const float RaycastingMinSurfaceRatioMax = 100f;

			[Token(Token = "0x400008B")]
			public const float RaycastingMaxSurfaceDotDefault = 0.25f;

			[Token(Token = "0x400008C")]
			public const float RaycastingMaxSurfaceAngleMin = 45f;

			[Token(Token = "0x400008D")]
			public const float RaycastingMaxSurfaceAngleMax = 90f;

			[Token(Token = "0x400008E")]
			public const PlaneAlignment RaycastingPlaneAlignmentDefault = PlaneAlignment.Surface;

			[Token(Token = "0x400008F")]
			public const float RaycastingPlaneOffsetDefault = 0.1f;

			[Token(Token = "0x4000090")]
			public const int DepthBufferDepthMapResolutionDefault = 32;

			[Token(Token = "0x4000091")]
			public const bool DepthBufferOcclusionCullingDefault = true;
		}

		[Token(Token = "0x2000011")]
		public static class Effects
		{
			[Token(Token = "0x4000092")]
			public const EffectAbstractBase.ComponentsToChange ComponentsToChangeDefault = (EffectAbstractBase.ComponentsToChange)2147483647;

			[Token(Token = "0x4000093")]
			public const bool RestoreBaseIntensityDefault = true;

			[Token(Token = "0x4000094")]
			public const float FrequencyDefault = 10f;

			[Token(Token = "0x4000095")]
			public const bool PerformPausesDefault = false;

			[Token(Token = "0x4000096")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly MinMaxRangeFloat FlickeringDurationDefault;

			[Token(Token = "0x4000097")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly MinMaxRangeFloat PauseDurationDefault;

			[Token(Token = "0x4000098")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly MinMaxRangeFloat IntensityAmplitudeDefault;

			[Token(Token = "0x4000099")]
			public const float SmoothingDefault = 0.05f;
		}

		[Token(Token = "0x2000012")]
		public static class Config
		{
			[Token(Token = "0x400009A")]
			public const bool GeometryOverrideLayerDefault = true;

			[Token(Token = "0x400009B")]
			public const int GeometryLayerIDDefault = 1;

			[Token(Token = "0x400009C")]
			public const string GeometryTagDefault = "Untagged";

			[Token(Token = "0x400009D")]
			public const string FadeOutCameraTagDefault = "MainCamera";

			[Token(Token = "0x400009E")]
			public const RenderQueue GeometryRenderQueueDefault = RenderQueue.Transparent;

			[Token(Token = "0x400009F")]
			public const RenderPipeline GeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

			[Token(Token = "0x40000A0")]
			public const RenderingMode GeometryRenderingModeDefault = RenderingMode.SinglePass;

			[Token(Token = "0x40000A1")]
			public const int Noise3DSizeDefault = 64;

			[Token(Token = "0x40000A2")]
			public const int SharedMeshSides = 24;

			[Token(Token = "0x40000A3")]
			public const int SharedMeshSegments = 5;

			[Token(Token = "0x40000A4")]
			public const float DitheringFactor = 0f;

			[Token(Token = "0x40000A5")]
			public const bool FeatureEnabledDefault = true;

			[Token(Token = "0x40000A6")]
			public const FeatureEnabledColorGradient FeatureEnabledColorGradientDefault = FeatureEnabledColorGradient.HighOnly;
		}

		[Token(Token = "0x400003F")]
		public const string PluginFolder = "Plugins/VolumetricLightBeam";
	}
	[Token(Token = "0x2000013")]
	public static class DummyMaterial
	{
	}
	[Token(Token = "0x2000014")]
	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeam))]
	public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x2000015")]
		protected enum ProcessOcclusionSource
		{
			[Token(Token = "0x40000B1")]
			RenderLoop,
			[Token(Token = "0x40000B2")]
			OnEnable,
			[Token(Token = "0x40000B3")]
			EditorUpdate,
			[Token(Token = "0x40000B4")]
			User
		}

		[Token(Token = "0x40000A7")]
		public const string ClassName = "DynamicOcclusionAbstractBase";

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicOcclusionUpdateRate updateRate;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[FormerlySerializedAs("waitFrameCount")]
		public int waitXFrames;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool _INTERNAL_ApplyRandomFrameOffset;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TransformUtils.Packed m_TransformPacked;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_LastFrameRendered;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected VolumetricLightBeam m_Master;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected MaterialModifier.Callback m_MaterialModifierCallbackCached;

		[Token(Token = "0x1700001B")]
		public int _INTERNAL_LastFrameRendered
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0xC1A0C8", Offset = "0xC1A0C8", VA = "0xC1A0C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action onOcclusionProcessed
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0xC19E58", Offset = "0xC19E58", VA = "0xC19E58")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0xC19EF4", Offset = "0xC19EF4", VA = "0xC19EF4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xC19CC8", Offset = "0xC19CC8", VA = "0xC19CC8")]
		public void ProcessOcclusionManually()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xC19CD0", Offset = "0xC19CD0", VA = "0xC19CD0")]
		protected void ProcessOcclusion(ProcessOcclusionSource source)
		{
		}

		[Token(Token = "0x6000077")]
		protected abstract string GetShaderKeyword();

		[Token(Token = "0x6000078")]
		protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

		[Token(Token = "0x6000079")]
		protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

		[Token(Token = "0x600007A")]
		protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

		[Token(Token = "0x600007B")]
		protected abstract void OnEnablePostValidate();

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xC1A0D0", Offset = "0xC1A0D0", VA = "0xC1A0D0", Slot = "9")]
		protected virtual void OnValidateProperties()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xC1A0F0", Offset = "0xC1A0F0", VA = "0xC1A0F0", Slot = "10")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xC1A170", Offset = "0xC1A170", VA = "0xC1A170", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xC1A1BC", Offset = "0xC1A1BC", VA = "0xC1A1BC", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xC1A77C", Offset = "0xC1A77C", VA = "0xC1A77C", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xC1A8A4", Offset = "0xC1A8A4", VA = "0xC1A8A4")]
		private void OnWillCameraRender(Camera cam)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xC1A18C", Offset = "0xC1A18C", VA = "0xC1A18C")]
		private void DisableOcclusion()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xC1AA98", Offset = "0xC1AA98", VA = "0xC1AA98")]
		protected DynamicOcclusionAbstractBase()
		{
		}
	}
	[Token(Token = "0x2000016")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/")]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x40000B5")]
		public new const string ClassName = "DynamicOcclusionDepthBuffer";

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LayerMask layerMask;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool useOcclusionCulling;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int depthMapResolution;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Camera m_DepthCamera;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_NeedToUpdateOcclusionNextFrame;

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xC1AB08", Offset = "0xC1AB08", VA = "0xC1AB08", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xC1AB48", Offset = "0xC1AB48", VA = "0xC1AB48", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xC1AB50", Offset = "0xC1AB50", VA = "0xC1AB50")]
		private void ProcessOcclusionInternal()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xC1AD60", Offset = "0xC1AD60", VA = "0xC1AD60", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xC1AD94", Offset = "0xC1AD94", VA = "0xC1AD94")]
		private void Update()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xC1AB74", Offset = "0xC1AB74", VA = "0xC1AB74")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xC1AF60", Offset = "0xC1AF60", VA = "0xC1AF60")]
		public bool HasLayerMaskIssues()
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xC1AFC4", Offset = "0xC1AFC4", VA = "0xC1AFC4", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xC1B028", Offset = "0xC1B028", VA = "0xC1B028")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xC1B304", Offset = "0xC1B304", VA = "0xC1B304", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xC1B308", Offset = "0xC1B308", VA = "0xC1B308", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xC1B3A0", Offset = "0xC1B3A0", VA = "0xC1B3A0", Slot = "10")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xC1B3A4", Offset = "0xC1B3A4", VA = "0xC1B3A4", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xC1B3BC", Offset = "0xC1B3BC", VA = "0xC1B3BC")]
		private void DestroyDepthCamera()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xC1B50C", Offset = "0xC1B50C", VA = "0xC1B50C", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xC1B688", Offset = "0xC1B688", VA = "0xC1B688")]
		public DynamicOcclusionDepthBuffer()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/")]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x2000018")]
		public struct HitResult
		{
			[Token(Token = "0x40000CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 point;

			[Token(Token = "0x40000CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 normal;

			[Token(Token = "0x40000CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float distance;

			[Token(Token = "0x40000CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Collider2D collider2D;

			[Token(Token = "0x40000CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Collider collider3D;

			[Token(Token = "0x17000020")]
			public bool hasCollider
			{
				[Token(Token = "0x60000B4")]
				[Address(RVA = "0xC1C4DC", Offset = "0xC1C4DC", VA = "0xC1C4DC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000021")]
			public string name
			{
				[Token(Token = "0x60000B5")]
				[Address(RVA = "0xC1CFBC", Offset = "0xC1CFBC", VA = "0xC1CFBC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000022")]
			public Bounds bounds
			{
				[Token(Token = "0x60000B6")]
				[Address(RVA = "0xC1D080", Offset = "0xC1D080", VA = "0xC1D080")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x60000B2")]
			[Address(RVA = "0xC1C1F4", Offset = "0xC1C1F4", VA = "0xC1C1F4")]
			public HitResult(ref RaycastHit hit3D)
			{
			}

			[Token(Token = "0x60000B3")]
			[Address(RVA = "0xC1C270", Offset = "0xC1C270", VA = "0xC1C270")]
			public HitResult(ref RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x60000B7")]
			[Address(RVA = "0xC1B924", Offset = "0xC1B924", VA = "0xC1B924")]
			public void SetNull()
			{
			}
		}

		[Token(Token = "0x2000019")]
		private enum Direction
		{
			[Token(Token = "0x40000D0")]
			Up = 0,
			[Token(Token = "0x40000D1")]
			Down = 1,
			[Token(Token = "0x40000D2")]
			Left = 2,
			[Token(Token = "0x40000D3")]
			Right = 3,
			[Token(Token = "0x40000D4")]
			Max2D = 1,
			[Token(Token = "0x40000D5")]
			Max3D = 3
		}

		[Token(Token = "0x40000BC")]
		public new const string ClassName = "DynamicOcclusionRaycasting";

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Dimensions dimensions;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public LayerMask layerMask;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool considerTriggers;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float minOccluderArea;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float minSurfaceRatio;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float maxSurfaceDot;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float planeOffset;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[FormerlySerializedAs("fadeDistanceToPlane")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private HitResult m_CurrentHit;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float m_RangeMultiplier;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x1700001C")]
		[Obsolete("Use 'fadeDistanceToSurface' instead")]
		public float fadeDistanceToPlane
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0xC1B73C", Offset = "0xC1B73C", VA = "0xC1B73C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0xC1B744", Offset = "0xC1B744", VA = "0xC1B744")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0xC1B8A8", Offset = "0xC1B8A8", VA = "0xC1B8A8")]
			[CompilerGenerated]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0xC1B8B4", Offset = "0xC1B8B4", VA = "0xC1B8B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0xC1BAF0", Offset = "0xC1BAF0", VA = "0xC1BAF0")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x1700001F")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0xC1BB04", Offset = "0xC1BB04", VA = "0xC1BB04")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xC1B74C", Offset = "0xC1B74C", VA = "0xC1B74C")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xC1B860", Offset = "0xC1B860", VA = "0xC1B860", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xC1B8A0", Offset = "0xC1B8A0", VA = "0xC1B8A0", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xC1B8C0", Offset = "0xC1B8C0", VA = "0xC1B8C0", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xC1B8FC", Offset = "0xC1B8FC", VA = "0xC1B8FC", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xC1B94C", Offset = "0xC1B94C", VA = "0xC1B94C", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xC1B994", Offset = "0xC1B994", VA = "0xC1B994")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xC1BA40", Offset = "0xC1BA40", VA = "0xC1BA40")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xC1BC24", Offset = "0xC1BC24", VA = "0xC1BC24")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xC1BC74", Offset = "0xC1BC74", VA = "0xC1BC74")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xC1BED0", Offset = "0xC1BED0", VA = "0xC1BED0")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xC1C2EC", Offset = "0xC1C2EC", VA = "0xC1C2EC")]
		private uint GetDirectionCount()
		{
			return default(uint);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xC1C304", Offset = "0xC1C304", VA = "0xC1C304")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xC1C468", Offset = "0xC1C468", VA = "0xC1C468")]
		private bool IsHitValid(ref HitResult hit, Vector3 forwardVec)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xC1C56C", Offset = "0xC1C56C", VA = "0xC1C56C", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xC1CA10", Offset = "0xC1CA10", VA = "0xC1CA10")]
		private void SetHit(ref HitResult hit)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xC1B964", Offset = "0xC1B964", VA = "0xC1B964")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xC1CBC0", Offset = "0xC1CBC0", VA = "0xC1CBC0", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xC1CAD4", Offset = "0xC1CAD4", VA = "0xC1CAD4")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xC1CB88", Offset = "0xC1CB88", VA = "0xC1CB88")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xC1CEF0", Offset = "0xC1CEF0", VA = "0xC1CEF0")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xC1CEFC", Offset = "0xC1CEFC", VA = "0xC1CEFC")]
		public DynamicOcclusionRaycasting()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[DisallowMultipleComponent]
	[AddComponentMenu("")]
	public class EffectAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x200001B")]
		[Flags]
		public enum ComponentsToChange
		{
			[Token(Token = "0x40000E0")]
			UnityLight = 1,
			[Token(Token = "0x40000E1")]
			VolumetricLightBeam = 2,
			[Token(Token = "0x40000E2")]
			VolumetricDustParticles = 4
		}

		[Token(Token = "0x40000D6")]
		public const string ClassName = "EffectAbstractBase";

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ComponentsToChange componentsToChange;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool restoreBaseIntensity;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected VolumetricLightBeam m_Beam;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Light m_Light;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected VolumetricDustParticles m_Particles;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected float m_BaseIntensityBeamInside;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float m_BaseIntensityBeamOutside;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected float m_BaseIntensityLight;

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xC1D168", Offset = "0xC1D168", VA = "0xC1D168")]
		protected void SetAdditiveIntensity(float additive)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xC1D2CC", Offset = "0xC1D2CC", VA = "0xC1D2CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xC1D464", Offset = "0xC1D464", VA = "0xC1D464", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xC1D46C", Offset = "0xC1D46C", VA = "0xC1D46C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xC1D49C", Offset = "0xC1D49C", VA = "0xC1D49C")]
		public EffectAbstractBase()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-effect-flicker/")]
	public class EffectFlicker : EffectAbstractBase
	{
		[Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class <CoUpdate>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectFlicker <>4__this;

			[Token(Token = "0x40000EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <remaining>5__2;

			[Token(Token = "0x17000023")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000C5")]
				[Address(RVA = "0xC1D858", Offset = "0xC1D858", VA = "0xC1D858", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000024")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000C7")]
				[Address(RVA = "0xC1D8A0", Offset = "0xC1D8A0", VA = "0xC1D8A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C2")]
			[Address(RVA = "0xC1D554", Offset = "0xC1D554", VA = "0xC1D554")]
			[DebuggerHidden]
			public <CoUpdate>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xC1D76C", Offset = "0xC1D76C", VA = "0xC1D76C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xC1D770", Offset = "0xC1D770", VA = "0xC1D770", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xC1D860", Offset = "0xC1D860", VA = "0xC1D860", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class <CoFlicker>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectFlicker <>4__this;

			[Token(Token = "0x40000F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <remainingDuration>5__2;

			[Token(Token = "0x40000F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <freqDuration>5__3;

			[Token(Token = "0x17000025")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000CB")]
				[Address(RVA = "0xC1D984", Offset = "0xC1D984", VA = "0xC1D984", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000026")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000CD")]
				[Address(RVA = "0xC1D9CC", Offset = "0xC1D9CC", VA = "0xC1D9CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C8")]
			[Address(RVA = "0xC1D5F0", Offset = "0xC1D5F0", VA = "0xC1D5F0")]
			[DebuggerHidden]
			public <CoFlicker>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xC1D8A8", Offset = "0xC1D8A8", VA = "0xC1D8A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xC1D8AC", Offset = "0xC1D8AC", VA = "0xC1D8AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xC1D98C", Offset = "0xC1D98C", VA = "0xC1D98C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class <CoChangeIntensity>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectFlicker <>4__this;

			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float nextIntensity;

			[Token(Token = "0x40000F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float expectedDuration;

			[Token(Token = "0x40000F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <velocity>5__2;

			[Token(Token = "0x40000FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <t>5__3;

			[Token(Token = "0x17000027")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000D1")]
				[Address(RVA = "0xC1DAC0", Offset = "0xC1DAC0", VA = "0xC1DAC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000028")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000D3")]
				[Address(RVA = "0xC1DB08", Offset = "0xC1DB08", VA = "0xC1DB08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xC1D6A0", Offset = "0xC1D6A0", VA = "0xC1D6A0")]
			[DebuggerHidden]
			public <CoChangeIntensity>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xC1D9D4", Offset = "0xC1D9D4", VA = "0xC1D9D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xC1D9D8", Offset = "0xC1D9D8", VA = "0xC1D9D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000D2")]
			[Address(RVA = "0xC1DAC8", Offset = "0xC1DAC8", VA = "0xC1DAC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000E3")]
		public new const string ClassName = "EffectFlicker";

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(1f, 60f)]
		public float frequency;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool performPauses;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[MinMaxRange(0f, 10f)]
		public MinMaxRangeFloat flickeringDuration;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[MinMaxRange(0f, 10f)]
		public MinMaxRangeFloat pauseDuration;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[MinMaxRange(-5f, 5f)]
		public MinMaxRangeFloat intensityAmplitude;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Range(0f, 0.25f)]
		public float smoothing;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_CurrentAdditiveIntensity;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xC1D4B4", Offset = "0xC1D4B4", VA = "0xC1D4B4", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xC1D4E0", Offset = "0xC1D4E0", VA = "0xC1D4E0")]
		[IteratorStateMachine(typeof(<CoUpdate>d__9))]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xC1D57C", Offset = "0xC1D57C", VA = "0xC1D57C")]
		[IteratorStateMachine(typeof(<CoFlicker>d__10))]
		private IEnumerator CoFlicker()
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xC1D618", Offset = "0xC1D618", VA = "0xC1D618")]
		[IteratorStateMachine(typeof(<CoChangeIntensity>d__11))]
		private IEnumerator CoChangeIntensity(float expectedDuration, float nextIntensity)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xC1D6C8", Offset = "0xC1D6C8", VA = "0xC1D6C8")]
		public EffectFlicker()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-effect-pulse/")]
	public class EffectPulse : EffectAbstractBase
	{
		[Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class <CoUpdate>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000100")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectPulse <>4__this;

			[Token(Token = "0x4000101")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000029")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000DA")]
				[Address(RVA = "0xC1DD58", Offset = "0xC1DD58", VA = "0xC1DD58", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000DC")]
				[Address(RVA = "0xC1DDA0", Offset = "0xC1DDA0", VA = "0xC1DDA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xC1DBB0", Offset = "0xC1DBB0", VA = "0xC1DBB0")]
			[DebuggerHidden]
			public <CoUpdate>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xC1DC58", Offset = "0xC1DC58", VA = "0xC1DC58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000D9")]
			[Address(RVA = "0xC1DC5C", Offset = "0xC1DC5C", VA = "0xC1DC5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xC1DD60", Offset = "0xC1DD60", VA = "0xC1DD60", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000FB")]
		public new const string ClassName = "EffectPulse";

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0.1f, 60f)]
		public float frequency;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[MinMaxRange(-5f, 5f)]
		public MinMaxRangeFloat intensityAmplitude;

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xC1DB10", Offset = "0xC1DB10", VA = "0xC1DB10", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xC1DB3C", Offset = "0xC1DB3C", VA = "0xC1DB3C")]
		[IteratorStateMachine(typeof(<CoUpdate>d__4))]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xC1DBD8", Offset = "0xC1DBD8", VA = "0xC1DBD8")]
		public EffectPulse()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public enum FeatureEnabledColorGradient
	{
		[Token(Token = "0x4000103")]
		Off,
		[Token(Token = "0x4000104")]
		HighOnly,
		[Token(Token = "0x4000105")]
		HighAndLow
	}
	[Token(Token = "0x2000023")]
	public enum ColorMode
	{
		[Token(Token = "0x4000107")]
		Flat,
		[Token(Token = "0x4000108")]
		Gradient
	}
	[Token(Token = "0x2000024")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x400010A")]
		Linear,
		[Token(Token = "0x400010B")]
		Quadratic,
		[Token(Token = "0x400010C")]
		Blend
	}
	[Token(Token = "0x2000025")]
	public enum BlendingMode
	{
		[Token(Token = "0x400010E")]
		Additive,
		[Token(Token = "0x400010F")]
		SoftAdditive,
		[Token(Token = "0x4000110")]
		TraditionalTransparency
	}
	[Token(Token = "0x2000026")]
	public enum ShaderAccuracy
	{
		[Token(Token = "0x4000112")]
		Fast,
		[Token(Token = "0x4000113")]
		High
	}
	[Token(Token = "0x2000027")]
	public enum NoiseMode
	{
		[Token(Token = "0x4000115")]
		Disabled,
		[Token(Token = "0x4000116")]
		WorldSpace,
		[Token(Token = "0x4000117")]
		LocalSpace
	}
	[Token(Token = "0x2000028")]
	public enum MeshType
	{
		[Token(Token = "0x4000119")]
		Shared,
		[Token(Token = "0x400011A")]
		Custom
	}
	[Token(Token = "0x2000029")]
	public enum RenderPipeline
	{
		[Token(Token = "0x400011C")]
		BuiltIn,
		[Token(Token = "0x400011D")]
		URP,
		[Token(Token = "0x400011E")]
		HDRP
	}
	[Token(Token = "0x200002A")]
	public enum RenderingMode
	{
		[Token(Token = "0x4000120")]
		MultiPass,
		[Token(Token = "0x4000121")]
		SinglePass,
		[Token(Token = "0x4000122")]
		GPUInstancing,
		[Token(Token = "0x4000123")]
		SRPBatcher
	}
	[Token(Token = "0x200002B")]
	public enum RenderQueue
	{
		[Token(Token = "0x4000125")]
		Custom = 0,
		[Token(Token = "0x4000126")]
		Background = 1000,
		[Token(Token = "0x4000127")]
		Geometry = 2000,
		[Token(Token = "0x4000128")]
		AlphaTest = 2450,
		[Token(Token = "0x4000129")]
		GeometryLast = 2500,
		[Token(Token = "0x400012A")]
		Transparent = 3000,
		[Token(Token = "0x400012B")]
		Overlay = 4000
	}
	[Token(Token = "0x200002C")]
	public enum Dimensions
	{
		[Token(Token = "0x400012D")]
		Dim3D,
		[Token(Token = "0x400012E")]
		Dim2D
	}
	[Token(Token = "0x200002D")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x4000130")]
		Surface,
		[Token(Token = "0x4000131")]
		Beam
	}
	[Token(Token = "0x200002E")]
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		[Token(Token = "0x4000133")]
		Never = 1,
		[Token(Token = "0x4000134")]
		OnEnable = 2,
		[Token(Token = "0x4000135")]
		OnBeamMove = 4,
		[Token(Token = "0x4000136")]
		EveryXFrames = 8,
		[Token(Token = "0x4000137")]
		OnBeamMoveAndEveryXFrames = 0xC
	}
	[Token(Token = "0x200002F")]
	public enum ParticlesDirection
	{
		[Token(Token = "0x4000139")]
		Random,
		[Token(Token = "0x400013A")]
		LocalSpace,
		[Token(Token = "0x400013B")]
		WorldSpace
	}
	[Token(Token = "0x2000030")]
	public static class GlobalMesh
	{
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xC16710", Offset = "0xC16710", VA = "0xC16710")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xC1DDA8", Offset = "0xC1DDA8", VA = "0xC1DDA8")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xC1DE74", Offset = "0xC1DE74", VA = "0xC1DE74")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public static class MaterialManager
	{
		[Token(Token = "0x2000033")]
		public enum BlendingMode
		{
			[Token(Token = "0x4000145")]
			Additive,
			[Token(Token = "0x4000146")]
			SoftAdditive,
			[Token(Token = "0x4000147")]
			TraditionalTransparency,
			[Token(Token = "0x4000148")]
			Count
		}

		[Token(Token = "0x2000034")]
		public enum Noise3D
		{
			[Token(Token = "0x400014A")]
			Off,
			[Token(Token = "0x400014B")]
			On,
			[Token(Token = "0x400014C")]
			Count
		}

		[Token(Token = "0x2000035")]
		public enum DepthBlend
		{
			[Token(Token = "0x400014E")]
			Off,
			[Token(Token = "0x400014F")]
			On,
			[Token(Token = "0x4000150")]
			Count
		}

		[Token(Token = "0x2000036")]
		public enum ColorGradient
		{
			[Token(Token = "0x4000152")]
			Off,
			[Token(Token = "0x4000153")]
			MatrixLow,
			[Token(Token = "0x4000154")]
			MatrixHigh,
			[Token(Token = "0x4000155")]
			Count
		}

		[Token(Token = "0x2000037")]
		public enum DynamicOcclusion
		{
			[Token(Token = "0x4000157")]
			Off,
			[Token(Token = "0x4000158")]
			ClippingPlane,
			[Token(Token = "0x4000159")]
			DepthTexture,
			[Token(Token = "0x400015A")]
			Count
		}

		[Token(Token = "0x2000038")]
		public enum MeshSkewing
		{
			[Token(Token = "0x400015C")]
			Off,
			[Token(Token = "0x400015D")]
			On,
			[Token(Token = "0x400015E")]
			Count
		}

		[Token(Token = "0x2000039")]
		public enum ShaderAccuracy
		{
			[Token(Token = "0x4000160")]
			Fast,
			[Token(Token = "0x4000161")]
			High,
			[Token(Token = "0x4000162")]
			Count
		}

		[Token(Token = "0x200003A")]
		public struct StaticProperties
		{
			[Token(Token = "0x4000163")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BlendingMode blendingMode;

			[Token(Token = "0x4000164")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Noise3D noise3D;

			[Token(Token = "0x4000165")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public DepthBlend depthBlend;

			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public ColorGradient colorGradient;

			[Token(Token = "0x4000167")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DynamicOcclusion dynamicOcclusion;

			[Token(Token = "0x4000168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public MeshSkewing meshSkewing;

			[Token(Token = "0x4000169")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ShaderAccuracy shaderAccuracy;

			[Token(Token = "0x1700002B")]
			private int blendingModeID
			{
				[Token(Token = "0x60000E4")]
				[Address(RVA = "0xC1E274", Offset = "0xC1E274", VA = "0xC1E274")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002C")]
			private int noise3DID
			{
				[Token(Token = "0x60000E5")]
				[Address(RVA = "0xC1E27C", Offset = "0xC1E27C", VA = "0xC1E27C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002D")]
			private int depthBlendID
			{
				[Token(Token = "0x60000E6")]
				[Address(RVA = "0xC1E2B0", Offset = "0xC1E2B0", VA = "0xC1E2B0")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002E")]
			private int colorGradientID
			{
				[Token(Token = "0x60000E7")]
				[Address(RVA = "0xC1E2E4", Offset = "0xC1E2E4", VA = "0xC1E2E4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002F")]
			private int dynamicOcclusionID
			{
				[Token(Token = "0x60000E8")]
				[Address(RVA = "0xC1E318", Offset = "0xC1E318", VA = "0xC1E318")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000030")]
			private int meshSkewingID
			{
				[Token(Token = "0x60000E9")]
				[Address(RVA = "0xC1E34C", Offset = "0xC1E34C", VA = "0xC1E34C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000031")]
			private int shaderAccuracyID
			{
				[Token(Token = "0x60000EA")]
				[Address(RVA = "0xC1E380", Offset = "0xC1E380", VA = "0xC1E380")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000032")]
			public int materialID
			{
				[Token(Token = "0x60000EB")]
				[Address(RVA = "0xC1E00C", Offset = "0xC1E00C", VA = "0xC1E00C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60000EC")]
			[Address(RVA = "0xC174C4", Offset = "0xC174C4", VA = "0xC174C4")]
			public void ApplyToMaterial(Material mat)
			{
			}
		}

		[Token(Token = "0x200003B")]
		private class MaterialsGroup
		{
			[Token(Token = "0x400016A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x60000ED")]
			[Address(RVA = "0xC1DF7C", Offset = "0xC1DF7C", VA = "0xC1DF7C")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xC158A8", Offset = "0xC158A8", VA = "0xC158A8")]
		public static Material NewMaterialTransient(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xC1DE7C", Offset = "0xC1DE7C", VA = "0xC1DE7C")]
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xC17794", Offset = "0xC17794", VA = "0xC17794")]
		public static Material GetInstancedMaterial(uint groupID, ref StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x200003C")]
	public static class MaterialModifier
	{
		[Token(Token = "0x200003D")]
		public interface Interface
		{
			[Token(Token = "0x60000EE")]
			void SetMaterialProp(int nameID, float value);

			[Token(Token = "0x60000EF")]
			void SetMaterialProp(int nameID, Vector4 value);

			[Token(Token = "0x60000F0")]
			void SetMaterialProp(int nameID, Color value);

			[Token(Token = "0x60000F1")]
			void SetMaterialProp(int nameID, Matrix4x4 value);

			[Token(Token = "0x60000F2")]
			void SetMaterialProp(int nameID, Texture value);
		}

		[Token(Token = "0x200003E")]
		public delegate void Callback(Interface owner);
	}
	[Token(Token = "0x200003F")]
	public static class MeshGenerator
	{
		[Token(Token = "0x400016B")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xC1E3F4", Offset = "0xC1E3F4", VA = "0xC1E3F4")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xC1E40C", Offset = "0xC1E40C", VA = "0xC1E40C")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xC1E47C", Offset = "0xC1E47C", VA = "0xC1E47C")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xC15F24", Offset = "0xC15F24", VA = "0xC15F24")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xC185D8", Offset = "0xC185D8", VA = "0xC185D8")]
		public static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xC1E4E8", Offset = "0xC1E4E8", VA = "0xC1E4E8")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xC1E504", Offset = "0xC1E504", VA = "0xC1E504")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xC1E52C", Offset = "0xC1E52C", VA = "0xC1E52C")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xC1E58C", Offset = "0xC1E58C", VA = "0xC1E58C")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public struct MinMaxRangeFloat
	{
		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float m_MinValue;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private float m_MaxValue;

		[Token(Token = "0x17000033")]
		public float minValue
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0xC1E5F0", Offset = "0xC1E5F0", VA = "0xC1E5F0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000034")]
		public float maxValue
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0xC1E5F8", Offset = "0xC1E5F8", VA = "0xC1E5F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000035")]
		public float randomValue
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0xC1D84C", Offset = "0xC1D84C", VA = "0xC1D84C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000036")]
		public Vector2 asVector2
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0xC1E600", Offset = "0xC1E600", VA = "0xC1E600")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xC1DD30", Offset = "0xC1DD30", VA = "0xC1DD30")]
		public float GetLerpedValue(float lerp01)
		{
			return default(float);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xC19BF8", Offset = "0xC19BF8", VA = "0xC19BF8")]
		public MinMaxRangeFloat(float min, float max)
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class MinMaxRangeAttribute : Attribute
	{
		[Token(Token = "0x17000037")]
		public float minValue
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0xC1E608", Offset = "0xC1E608", VA = "0xC1E608")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000107")]
			[Address(RVA = "0xC1E610", Offset = "0xC1E610", VA = "0xC1E610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public float maxValue
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0xC1E618", Offset = "0xC1E618", VA = "0xC1E618")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0xC1E620", Offset = "0xC1E620", VA = "0xC1E620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xC1E628", Offset = "0xC1E628", VA = "0xC1E628")]
		public MinMaxRangeAttribute(float min, float max)
		{
		}
	}
	[Token(Token = "0x2000042")]
	public static class Noise3D
	{
		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x4000173")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x17000039")]
		public static bool isSupported
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0xC17238", Offset = "0xC17238", VA = "0xC17238")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003A")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0xC1E6F8", Offset = "0xC1E6F8", VA = "0xC1E6F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0xC1E654", Offset = "0xC1E654", VA = "0xC1E654")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xC1E770", Offset = "0xC1E770", VA = "0xC1E770")]
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xC18268", Offset = "0xC18268", VA = "0xC18268")]
		public static void LoadIfNeeded()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class PlatformHelper
	{
		[Token(Token = "0x6000110")]
		[Address(RVA = "0xC19928", Offset = "0xC19928", VA = "0xC19928")]
		public static string GetCurrentPlatformSuffix()
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xC1E774", Offset = "0xC1E774", VA = "0xC1E774")]
		private static string GetPlatformSuffix(RuntimePlatform platform)
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xC1E7D8", Offset = "0xC1E7D8", VA = "0xC1E7D8")]
		public PlatformHelper()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class PolygonHelper : MonoBehaviour
	{
		[Token(Token = "0x2000045")]
		public struct Plane2D
		{
			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2 normal;

			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float distance;

			[Token(Token = "0x6000114")]
			[Address(RVA = "0xC1E7E8", Offset = "0xC1E7E8", VA = "0xC1E7E8")]
			public float Distance(Vector2 point)
			{
				return default(float);
			}

			[Token(Token = "0x6000115")]
			[Address(RVA = "0xC1E804", Offset = "0xC1E804", VA = "0xC1E804")]
			public Vector2 ClosestPoint(Vector2 pt)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000116")]
			[Address(RVA = "0xC1E830", Offset = "0xC1E830", VA = "0xC1E830")]
			public Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000117")]
			[Address(RVA = "0xC1E8C0", Offset = "0xC1E8C0", VA = "0xC1E8C0")]
			public bool GetSide(Vector2 point)
			{
				return default(bool);
			}

			[Token(Token = "0x6000118")]
			[Address(RVA = "0xC1E8E4", Offset = "0xC1E8E4", VA = "0xC1E8E4")]
			public static Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x6000119")]
			[Address(RVA = "0xC1E9DC", Offset = "0xC1E9DC", VA = "0xC1E9DC")]
			public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x600011A")]
			[Address(RVA = "0xC1E9EC", Offset = "0xC1E9EC", VA = "0xC1E9EC")]
			public void Flip()
			{
			}

			[Token(Token = "0x600011B")]
			[Address(RVA = "0xC1EA08", Offset = "0xC1EA08", VA = "0xC1EA08")]
			public Vector2[] CutConvex(Vector2[] poly)
			{
				return null;
			}

			[Token(Token = "0x600011C")]
			[Address(RVA = "0xC1ECA8", Offset = "0xC1ECA8", VA = "0xC1ECA8", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xC1E7E0", Offset = "0xC1E7E0", VA = "0xC1E7E0")]
		public PolygonHelper()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public static class ShaderKeywords
	{
		[Token(Token = "0x4000176")]
		public const string AlphaAsBlack = "VLB_ALPHA_AS_BLACK";

		[Token(Token = "0x4000177")]
		public const string ColorGradientMatrixLow = "VLB_COLOR_GRADIENT_MATRIX_LOW";

		[Token(Token = "0x4000178")]
		public const string ColorGradientMatrixHigh = "VLB_COLOR_GRADIENT_MATRIX_HIGH";

		[Token(Token = "0x4000179")]
		public const string DepthBlend = "VLB_DEPTH_BLEND";

		[Token(Token = "0x400017A")]
		public const string Noise3D = "VLB_NOISE_3D";

		[Token(Token = "0x400017B")]
		public const string OcclusionClippingPlane = "VLB_OCCLUSION_CLIPPING_PLANE";

		[Token(Token = "0x400017C")]
		public const string OcclusionDepthTexture = "VLB_OCCLUSION_DEPTH_TEXTURE";

		[Token(Token = "0x400017D")]
		public const string MeshSkewing = "VLB_MESH_SKEWING";

		[Token(Token = "0x400017E")]
		public const string ShaderAccuracyHigh = "VLB_SHADER_ACCURACY_HIGH";
	}
	[Token(Token = "0x2000047")]
	public static class ShaderProperties
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int FadeOutFactor;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int ConeSlopeCosSin;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int ConeRadius;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int ConeApexOffsetZ;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int ColorFlat;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly int AlphaInside;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int AlphaOutside;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static readonly int AttenuationLerpLinearQuad;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly int DistanceFallOff;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static readonly int DistanceCamClipping;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly int FresnelPow;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static readonly int GlareBehind;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly int GlareFrontal;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static readonly int DrawCap;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly int DepthBlendDistance;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static readonly int NoiseVelocityAndScale;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly int NoiseParam;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static readonly int CameraParams;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly int ColorGradientMatrix;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static readonly int LocalToWorldMatrix;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly int WorldToLocalMatrix;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static readonly int BlendSrcFactor;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly int BlendDstFactor;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static readonly int DynamicOcclusionClippingPlaneWS;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly int DynamicOcclusionClippingPlaneProps;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static readonly int DynamicOcclusionDepthTexture;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static readonly int DynamicOcclusionDepthProps;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static readonly int LocalForwardDirection;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static readonly int TiltVector;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public static readonly int AdditionalClippingPlaneWS;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static readonly int ParticlesTintColor;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public static readonly int GlobalUsesReversedZBuffer;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static readonly int GlobalNoiseTex3D;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static readonly int GlobalNoiseCustomTime;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static readonly int GlobalDitheringFactor;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public static readonly int GlobalDitheringNoiseTex;
	}
	[Token(Token = "0x2000048")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-skewinghandle/")]
	public class SkewingHandle : MonoBehaviour
	{
		[Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class <CoUpdate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SkewingHandle <>4__this;

			[Token(Token = "0x1700003C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600012A")]
				[Address(RVA = "0xC1F790", Offset = "0xC1F790", VA = "0xC1F790", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600012C")]
				[Address(RVA = "0xC1F7D8", Offset = "0xC1F7D8", VA = "0xC1F7D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000127")]
			[Address(RVA = "0xC1F6E8", Offset = "0xC1F6E8", VA = "0xC1F6E8")]
			[DebuggerHidden]
			public <CoUpdate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0xC1F718", Offset = "0xC1F718", VA = "0xC1F718", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000129")]
			[Address(RVA = "0xC1F71C", Offset = "0xC1F71C", VA = "0xC1F71C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600012B")]
			[Address(RVA = "0xC1F798", Offset = "0xC1F798", VA = "0xC1F798", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VolumetricLightBeam volumetricLightBeam;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool shouldUpdateEachFrame;

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xC1F3F8", Offset = "0xC1F3F8", VA = "0xC1F3F8")]
		public bool IsAttachedToSelf()
		{
			return default(bool);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xC1F4B8", Offset = "0xC1F4B8", VA = "0xC1F4B8")]
		public bool CanSetSkewingVector()
		{
			return default(bool);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xC1F550", Offset = "0xC1F550", VA = "0xC1F550")]
		public bool CanUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xC1F588", Offset = "0xC1F588", VA = "0xC1F588")]
		private bool ShouldUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xC1F59C", Offset = "0xC1F59C", VA = "0xC1F59C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xC1F628", Offset = "0xC1F628", VA = "0xC1F628")]
		private void Start()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xC1F674", Offset = "0xC1F674", VA = "0xC1F674")]
		[IteratorStateMachine(typeof(<CoUpdate>d__8))]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xC1F5C0", Offset = "0xC1F5C0", VA = "0xC1F5C0")]
		private void SetSkewingVector()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xC1F710", Offset = "0xC1F710", VA = "0xC1F710")]
		public SkewingHandle()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public static class SRPHelper
	{
		[Token(Token = "0x200004B")]
		public enum RenderPipeline
		{
			[Token(Token = "0x40001AA")]
			Undefined,
			[Token(Token = "0x40001AB")]
			BuiltIn,
			[Token(Token = "0x40001AC")]
			URP,
			[Token(Token = "0x40001AD")]
			LWRP,
			[Token(Token = "0x40001AE")]
			HDRP
		}

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RenderPipeline m_RenderPipelineCached;

		[Token(Token = "0x1700003E")]
		public static RenderPipeline renderPipelineType
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0xC19020", Offset = "0xC19020", VA = "0xC19020")]
			get
			{
				return default(RenderPipeline);
			}
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xC1F7E0", Offset = "0xC1F7E0", VA = "0xC1F7E0")]
		private static RenderPipeline ComputeRenderPipeline()
		{
			return default(RenderPipeline);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xC1872C", Offset = "0xC1872C", VA = "0xC1872C")]
		public static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xC154A8", Offset = "0xC154A8", VA = "0xC154A8")]
		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xC15338", Offset = "0xC15338", VA = "0xC15338")]
		public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}
	}
	[Token(Token = "0x200004C")]
	public static class TransformUtils
	{
		[Token(Token = "0x200004D")]
		public struct Packed
		{
			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Quaternion rotation;

			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lossyScale;

			[Token(Token = "0x6000133")]
			[Address(RVA = "0xC1A9A4", Offset = "0xC1A9A4", VA = "0xC1A9A4")]
			public bool IsSame(Transform transf)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xC1A034", Offset = "0xC1A034", VA = "0xC1A034")]
		public static Packed GetWorldPacked(this Transform self)
		{
			return default(Packed);
		}
	}
	[Token(Token = "0x200004E")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-triggerzone/")]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[DisallowMultipleComponent]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x200004F")]
		private enum TriggerZoneUpdateRate
		{
			[Token(Token = "0x40001BA")]
			OnEnable,
			[Token(Token = "0x40001BB")]
			OnOcclusionChange
		}

		[Token(Token = "0x40001B2")]
		public const string ClassName = "TriggerZone";

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x40001B5")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private VolumetricLightBeam m_Beam;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PolygonCollider2D m_PolygonCollider2D;

		[Token(Token = "0x1700003F")]
		private TriggerZoneUpdateRate updateRate
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0xC1F908", Offset = "0xC1F908", VA = "0xC1F908")]
			get
			{
				return default(TriggerZoneUpdateRate);
			}
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xC1F98C", Offset = "0xC1F98C", VA = "0xC1F98C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xC20044", Offset = "0xC20044", VA = "0xC20044")]
		private void OnOcclusionProcessed()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xC1FB00", Offset = "0xC1FB00", VA = "0xC1FB00")]
		private void ComputeZone()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xC200F8", Offset = "0xC200F8", VA = "0xC200F8")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public static class Utils
	{
		[Token(Token = "0x2000051")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x40001C0")]
			High = 64,
			[Token(Token = "0x40001C1")]
			Low = 8,
			[Token(Token = "0x40001C2")]
			Undef = 0
		}

		[Token(Token = "0x40001BC")]
		private const float kEpsilon = 1E-05f;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x40001BE")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xC20110", Offset = "0xC20110", VA = "0xC20110")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x600013A")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xC15BA0", Offset = "0xC15BA0", VA = "0xC15BA0")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x600013C")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600013D")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xC20144", Offset = "0xC20144", VA = "0xC20144")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xC20214", Offset = "0xC20214", VA = "0xC20214")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xC20218", Offset = "0xC20218", VA = "0xC20218")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xC20220", Offset = "0xC20220", VA = "0xC20220")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xC2022C", Offset = "0xC2022C", VA = "0xC2022C")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xC2023C", Offset = "0xC2023C", VA = "0xC2023C")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xC20248", Offset = "0xC20248", VA = "0xC20248")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xC20250", Offset = "0xC20250", VA = "0xC20250")]
		public static bool Approximately(float a, float b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xC20260", Offset = "0xC20260", VA = "0xC20260")]
		public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xC20280", Offset = "0xC20280", VA = "0xC20280")]
		public static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xC202AC", Offset = "0xC202AC", VA = "0xC202AC")]
		public static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xC202E8", Offset = "0xC202E8", VA = "0xC202E8")]
		public static Vector4 AsVector4(this Vector3 vec3, float w)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xC202EC", Offset = "0xC202EC", VA = "0xC202EC")]
		public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xC20308", Offset = "0xC20308", VA = "0xC20308")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xC1C164", Offset = "0xC1C164", VA = "0xC1C164")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xC20350", Offset = "0xC20350", VA = "0xC20350")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xC1CD84", Offset = "0xC1CD84", VA = "0xC1CD84")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xC20080", Offset = "0xC20080", VA = "0xC20080")]
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xC1E8A8", Offset = "0xC1E8A8", VA = "0xC1E8A8")]
		public static bool IsAlmostZero(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xC1B818", Offset = "0xC1B818", VA = "0xC1B818")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xC17F14", Offset = "0xC17F14", VA = "0xC17F14")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xC20358", Offset = "0xC20358", VA = "0xC20358")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xC18054", Offset = "0xC18054", VA = "0xC18054")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xC203C8", Offset = "0xC203C8", VA = "0xC203C8")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xC204AC", Offset = "0xC204AC", VA = "0xC204AC")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xC2036C", Offset = "0xC2036C", VA = "0xC2036C")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xC1732C", Offset = "0xC1732C", VA = "0xC1732C")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xC204C0", Offset = "0xC204C0", VA = "0xC204C0")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xC204C4", Offset = "0xC204C4", VA = "0xC204C4")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x2000052")]
	public static class Version
	{
		[Token(Token = "0x40001C3")]
		public const int Current = 1950;
	}
	[Token(Token = "0x2000053")]
	[DisallowMultipleComponent]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dustparticles/")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(VolumetricLightBeam))]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x40001C4")]
		public const string ClassName = "VolumetricDustParticles";

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float alpha;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0.0001f, 0.1f)]
		public float size;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticlesDirection direction;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 velocity;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Obsolete("Use 'velocity' instead")]
		public float speed;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float density;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[MinMaxRange(0f, 1f)]
		public MinMaxRangeFloat spawnDistanceRange;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Obsolete("Use 'spawnDistanceRange' instead")]
		public float spawnMinDistance;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Obsolete("Use 'spawnDistanceRange' instead")]
		public float spawnMaxDistance;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool cullingEnabled;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float cullingMaxDistance;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_AlphaAdditionalRuntime;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_Material;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Gradient m_GradientCached;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_RuntimePropertiesDirty;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x17000040")]
		public bool isCulled
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0xC204C8", Offset = "0xC204C8", VA = "0xC204C8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015D")]
			[Address(RVA = "0xC204D0", Offset = "0xC204D0", VA = "0xC204D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public float alphaAdditionalRuntime
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0xC204DC", Offset = "0xC204DC", VA = "0xC204DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600015F")]
			[Address(RVA = "0xC1D2B0", Offset = "0xC1D2B0", VA = "0xC1D2B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0xC204E4", Offset = "0xC204E4", VA = "0xC204E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0xC20540", Offset = "0xC20540", VA = "0xC20540")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000044")]
		public int particlesMaxCount
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0xC205C4", Offset = "0xC205C4", VA = "0xC205C4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000045")]
		public Camera mainCamera
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0xC20660", Offset = "0xC20660", VA = "0xC20660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xC20820", Offset = "0xC20820", VA = "0xC20820")]
		private void Start()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xC20904", Offset = "0xC20904", VA = "0xC20904")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xC20B74", Offset = "0xC20B74", VA = "0xC20B74")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xC20B90", Offset = "0xC20B90", VA = "0xC20B90")]
		private void SetActive(bool active)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xC20B58", Offset = "0xC20B58", VA = "0xC20B58")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xC20C30", Offset = "0xC20C30", VA = "0xC20C30")]
		private void Play()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xC21320", Offset = "0xC21320", VA = "0xC21320")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xC21328", Offset = "0xC21328", VA = "0xC21328")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xC21440", Offset = "0xC21440", VA = "0xC21440")]
		private void Update()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xC20CD0", Offset = "0xC20CD0", VA = "0xC20CD0")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xC208B8", Offset = "0xC208B8", VA = "0xC208B8")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xC2152C", Offset = "0xC2152C", VA = "0xC2152C")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xC2186C", Offset = "0xC2186C", VA = "0xC2186C")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x2000055")]
		public delegate void OnWillCameraRenderCB(Camera cam);

		[Token(Token = "0x2000056")]
		public delegate void OnBeamGeometryInitialized();

		[Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class <CoPlaytimeUpdate>d__187 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x17000076")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001D9")]
				[Address(RVA = "0xC22EB8", Offset = "0xC22EB8", VA = "0xC22EB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000077")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001DB")]
				[Address(RVA = "0xC22F00", Offset = "0xC22F00", VA = "0xC22F00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D6")]
			[Address(RVA = "0xC229A8", Offset = "0xC229A8", VA = "0xC229A8")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__187(int <>1__state)
			{
			}

			[Token(Token = "0x60001D7")]
			[Address(RVA = "0xC22E24", Offset = "0xC22E24", VA = "0xC22E24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D8")]
			[Address(RVA = "0xC22E28", Offset = "0xC22E28", VA = "0xC22E28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xC22EC0", Offset = "0xC22EC0", VA = "0xC22EC0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001DA")]
		public const string ClassName = "VolumetricLightBeam";

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ColorUsage(false, true)]
		[FormerlySerializedAs("colorValue")]
		public Color color;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[FormerlySerializedAs("alphaInside")]
		public float intensityInside;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("alpha")]
		[FormerlySerializedAs("alphaOutside")]
		public float intensityOutside;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("angleFromLight")]
		public bool spotAngleFromLight;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0.1f, 179.9f)]
		public float spotAngle;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[FormerlySerializedAs("radiusStart")]
		public float coneRadiusStart;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public ShaderAccuracy shaderAccuracy;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MeshType geomMeshType;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[FormerlySerializedAs("geomSides")]
		public int geomCustomSides;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int geomCustomSegments;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 skewingLocalForwardDirection;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform clippingPlaneTransform;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool geomCap;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[FormerlySerializedAs("fadeEndFromLight")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float attenuationCustomBlending;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[FormerlySerializedAs("fadeStart")]
		public float fallOffStart;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[FormerlySerializedAs("fadeEnd")]
		public float fallOffEnd;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float depthBlendDistance;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float cameraClippingDistance;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[Range(0f, 1f)]
		public float glareFrontal;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Range(0f, 1f)]
		public float glareBehind;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[FormerlySerializedAs("fresnelPowOutside")]
		public float fresnelPow;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public NoiseMode noiseMode;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[Range(0f, 1f)]
		public float noiseIntensity;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Range(0.01f, 2f)]
		public float noiseScaleLocal;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Dimensions dimensions;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector2 tiltFactor;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private MaterialManager.DynamicOcclusion m_INTERNAL_DynamicOcclusionMode;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool m_INTERNAL_DynamicOcclusionMode_Runtime;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[FormerlySerializedAs("trackChangesDuringPlaytime")]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[FormerlySerializedAs("fadeOutBegin")]
		private float _FadeOutBegin;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[FormerlySerializedAs("fadeOutEnd")]
		[SerializeField]
		private float _FadeOutEnd;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Light m_CachedLight;

		[Token(Token = "0x17000046")]
		public ColorMode usedColorMode
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xC18020", Offset = "0xC18020", VA = "0xC18020")]
			get
			{
				return default(ColorMode);
			}
		}

		[Token(Token = "0x17000047")]
		[Obsolete("Use 'intensityGlobal' or 'intensityInside' instead")]
		public float alphaInside
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0xC21964", Offset = "0xC21964", VA = "0xC21964")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0xC2196C", Offset = "0xC2196C", VA = "0xC2196C")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		[Obsolete("Use 'intensityGlobal' or 'intensityOutside' instead")]
		public float alphaOutside
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0xC21974", Offset = "0xC21974", VA = "0xC21974")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xC2197C", Offset = "0xC2197C", VA = "0xC2197C")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public float intensityGlobal
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0xC21984", Offset = "0xC21984", VA = "0xC21984")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0xC2198C", Offset = "0xC2198C", VA = "0xC2198C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public float coneAngle
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0xC17F34", Offset = "0xC17F34", VA = "0xC17F34")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004B")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0xC170B0", Offset = "0xC170B0", VA = "0xC170B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004C")]
		public float coneVolume
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0xC21994", Offset = "0xC21994", VA = "0xC21994")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004D")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0xC17FA8", Offset = "0xC17FA8", VA = "0xC17FA8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004E")]
		public int geomSides
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0xC20048", Offset = "0xC20048", VA = "0xC20048")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xC21A10", Offset = "0xC21A10", VA = "0xC21A10")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public int geomSegments
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0xC21A8C", Offset = "0xC21A8C", VA = "0xC21A8C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0xC21AC4", Offset = "0xC21AC4", VA = "0xC21AC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public Vector3 skewingLocalForwardDirectionNormalized
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0xC18378", Offset = "0xC18378", VA = "0xC18378")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000051")]
		public Vector4 additionalClippingPlane
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0xC18160", Offset = "0xC18160", VA = "0xC18160")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000052")]
		public bool canHaveMeshSkewing
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0xC1F540", Offset = "0xC1F540", VA = "0xC1F540")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		public bool hasMeshSkewing
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0xC173B0", Offset = "0xC173B0", VA = "0xC173B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		[Obsolete("Use 'fallOffEndFromLight' instead")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0xC21B40", Offset = "0xC21B40", VA = "0xC21B40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0xC21B48", Offset = "0xC21B48", VA = "0xC21B48")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0xC18138", Offset = "0xC18138", VA = "0xC18138")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000056")]
		[Obsolete("Use 'fallOffStart' instead")]
		public float fadeStart
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0xC21B54", Offset = "0xC21B54", VA = "0xC21B54")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xC21B5C", Offset = "0xC21B5C", VA = "0xC21B5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		[Obsolete("Use 'fallOffEnd' instead")]
		public float fadeEnd
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0xC21B64", Offset = "0xC21B64", VA = "0xC21B64")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0xC21B6C", Offset = "0xC21B6C", VA = "0xC21B6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public float maxGeometryDistance
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0xC17100", Offset = "0xC17100", VA = "0xC17100")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000059")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0xC149B0", Offset = "0xC149B0", VA = "0xC149B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005A")]
		[Obsolete("Use 'noiseMode' instead")]
		public bool noiseEnabled
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0xC21B74", Offset = "0xC21B74", VA = "0xC21B74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0xC21B84", Offset = "0xC21B84", VA = "0xC21B84")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public float fadeOutBegin
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0xC21BA0", Offset = "0xC21BA0", VA = "0xC21BA0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000191")]
			[Address(RVA = "0xC21BA8", Offset = "0xC21BA8", VA = "0xC21BA8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public float fadeOutEnd
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0xC21C04", Offset = "0xC21C04", VA = "0xC21C04")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0xC21C0C", Offset = "0xC21C0C", VA = "0xC21C0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0xC14BBC", Offset = "0xC14BBC", VA = "0xC14BBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		public bool isTilted
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0xC21C14", Offset = "0xC21C14", VA = "0xC21C14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0xC21C7C", Offset = "0xC21C7C", VA = "0xC21C7C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0xC21C84", Offset = "0xC21C84", VA = "0xC21C84")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public string sortingLayerName
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0xC21D24", Offset = "0xC21D24", VA = "0xC21D24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0xC21D30", Offset = "0xC21D30", VA = "0xC21D30")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public int sortingOrder
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0xC21D54", Offset = "0xC21D54", VA = "0xC21D54")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600019B")]
			[Address(RVA = "0xC21D5C", Offset = "0xC21D5C", VA = "0xC21D5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0xC21DFC", Offset = "0xC21DFC", VA = "0xC21DFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600019D")]
			[Address(RVA = "0xC21E04", Offset = "0xC21E04", VA = "0xC21E04")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0xC21E78", Offset = "0xC21E78", VA = "0xC21E78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		public bool hasGeometry
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0xC216FC", Offset = "0xC216FC", VA = "0xC216FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		public Bounds bounds
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0xC2175C", Offset = "0xC2175C", VA = "0xC2175C")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000066")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0xC21E88", Offset = "0xC21E88", VA = "0xC21E88")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000067")]
		public Quaternion beamInternalLocalRotation
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0xC17120", Offset = "0xC17120", VA = "0xC17120")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000068")]
		public Vector3 beamLocalForward
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0xC1AE30", Offset = "0xC1AE30", VA = "0xC1AE30")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000069")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0xC1AECC", Offset = "0xC1AECC", VA = "0xC1AECC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006A")]
		public float raycastDistance
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0xC1BB48", Offset = "0xC1BB48", VA = "0xC1BB48")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700006B")]
		public Vector3 raycastGlobalForward
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0xC1C96C", Offset = "0xC1C96C", VA = "0xC1C96C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006C")]
		public Vector3 raycastGlobalUp
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0xC1C388", Offset = "0xC1C388", VA = "0xC1C388")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006D")]
		public Vector3 raycastGlobalRight
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0xC1C3F8", Offset = "0xC1C3F8", VA = "0xC1C3F8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006E")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xC153F0", Offset = "0xC153F0", VA = "0xC153F0")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0xC21F60", Offset = "0xC21F60", VA = "0xC21F60")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0xC1739C", Offset = "0xC1739C", VA = "0xC1739C")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
		}

		[Token(Token = "0x17000070")]
		public int _INTERNAL_pluginVersion
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0xC21FA4", Offset = "0xC21FA4", VA = "0xC21FA4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000071")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xC22040", Offset = "0xC22040", VA = "0xC22040")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0xC22048", Offset = "0xC22048", VA = "0xC22048")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public string meshStats
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xC22050", Offset = "0xC22050", VA = "0xC22050")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public int meshVerticesCount
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xC221F0", Offset = "0xC221F0", VA = "0xC221F0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000074")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xC222A8", Offset = "0xC222A8", VA = "0xC222A8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000075")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0xC2244C", Offset = "0xC2244C", VA = "0xC2244C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0xC1A534", Offset = "0xC1A534", VA = "0xC1A534")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0xC1A808", Offset = "0xC1A808", VA = "0xC1A808")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xC1810C", Offset = "0xC1810C", VA = "0xC1810C")]
		public void GetInsideAndOutsideIntensity(out float inside, out float outside)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xC19F90", Offset = "0xC19F90", VA = "0xC19F90")]
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xC18C40", Offset = "0xC18C40", VA = "0xC18C40")]
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xC1A69C", Offset = "0xC1A69C", VA = "0xC1A69C")]
		public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xC21F68", Offset = "0xC21F68", VA = "0xC21F68")]
		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xC21BB0", Offset = "0xC21BB0", VA = "0xC21BB0")]
		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xC21FAC", Offset = "0xC21FAC", VA = "0xC21FAC")]
		private void OnFadeOutStateChanged()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xC2237C", Offset = "0xC2237C", VA = "0xC2237C")]
		private Light GetLightSpotAttached()
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xC2242C", Offset = "0xC2242C", VA = "0xC2242C")]
		private void InitLightSpotAttachedCached()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xC22454", Offset = "0xC22454", VA = "0xC22454")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xC18C5C", Offset = "0xC18C5C", VA = "0xC18C5C")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xC224A8", Offset = "0xC224A8", VA = "0xC224A8")]
		[Obsolete("Use 'GenerateGeometry()' instead")]
		public void Generate()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xC224B4", Offset = "0xC224B4", VA = "0xC224B4", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xC2275C", Offset = "0xC2275C", VA = "0xC2275C", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xC227EC", Offset = "0xC227EC", VA = "0xC227EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xC2281C", Offset = "0xC2281C", VA = "0xC2281C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xC228A4", Offset = "0xC228A4", VA = "0xC228A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xC21E10", Offset = "0xC21E10", VA = "0xC21E10")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xC22934", Offset = "0xC22934", VA = "0xC22934")]
		[IteratorStateMachine(typeof(<CoPlaytimeUpdate>d__187))]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xC229D0", Offset = "0xC229D0", VA = "0xC229D0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xC229D4", Offset = "0xC229D4", VA = "0xC229D4")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xC22A80", Offset = "0xC22A80", VA = "0xC22A80")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xC22B70", Offset = "0xC22B70", VA = "0xC22B70")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xC22740", Offset = "0xC22740", VA = "0xC22740")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xC225E0", Offset = "0xC225E0", VA = "0xC225E0")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xC22C88", Offset = "0xC22C88", VA = "0xC22C88")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x2000058")]
	[RequireComponent(typeof(Camera))]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xC22F08", Offset = "0xC22F08", VA = "0xC22F08")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xC22FC8", Offset = "0xC22FC8", VA = "0xC22FC8")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[RequireComponent(typeof(Collider), typeof(Rigidbody), typeof(MeshRenderer))]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isInsideBeam;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xC22FD8", Offset = "0xC22FD8", VA = "0xC22FD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xC230C8", Offset = "0xC230C8", VA = "0xC230C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xC2317C", Offset = "0xC2317C", VA = "0xC2317C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xC23184", Offset = "0xC23184", VA = "0xC23184")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xC2323C", Offset = "0xC2323C", VA = "0xC2323C")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xC23244", Offset = "0xC23244", VA = "0xC23244")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xC232AC", Offset = "0xC232AC", VA = "0xC232AC")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x17000078")]
		private bool useMouseView
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xC232B4", Offset = "0xC232B4", VA = "0xC232B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xC232BC", Offset = "0xC232BC", VA = "0xC232BC")]
			set
			{
			}
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xC232EC", Offset = "0xC232EC", VA = "0xC232EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xC2337C", Offset = "0xC2337C", VA = "0xC2337C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xC23958", Offset = "0xC23958", VA = "0xC23958")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(1f, 100f)]
		[SerializeField]
		private int CountX;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(1f, 100f)]
		[SerializeField]
		private int CountY;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xC2397C", Offset = "0xC2397C", VA = "0xC2397C")]
		public void Generate()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xC23FF0", Offset = "0xC23FF0", VA = "0xC23FF0")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("m_EulerSpeed")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xC2400C", Offset = "0xC2400C", VA = "0xC2400C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xC240DC", Offset = "0xC240DC", VA = "0xC240DC")]
		public Rotater()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x200005E")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	[AddComponentMenu("Scripts/RootMotion/Baker")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200005F")]
		public enum Mode
		{
			[Token(Token = "0x4000233")]
			AnimationClips,
			[Token(Token = "0x4000234")]
			AnimationStates,
			[Token(Token = "0x4000235")]
			PlayableDirector,
			[Token(Token = "0x4000236")]
			Realtime
		}

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("In AnimationClips, AnimationStates or PlayableDirector mode - the frame rate at which the animation clip will be sampled. In Realtime mode - the frame rate at which the pose will be sampled. With the latter, the frame rate is not guaranteed if the player is not able to reach it.")]
		[Range(1f, 90f)]
		public int frameRate;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 0.1f)]
		[Tooltip("Maximum allowed error for keyframe reduction.")]
		public float keyReductionError;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("AnimationClips mode can be used to bake a batch of AnimationClips directly without the need of setting up an AnimatorController. AnimationStates mode is useful for when you need to set up a more complex rig with layers and AvatarMasks in Mecanim. PlayableDirector mode bakes a Timeline. Realtime mode is for continuous baking of gameplay, ragdoll phsysics or PuppetMaster dynamics.")]
		public Mode mode;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("AnimationClips to bake.")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The name of the AnimationStates to bake (must be on the base layer) in the Animator above (Right-click on this component header and select 'Find Animation States' to have Baker fill those in automatically, required that state names match with the names of the clips used in them).")]
		public string[] animationStates;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Sets the baked animation clip to loop time and matches the last frame keys with the first. Note that when overwriting a previously baked clip, AnimationClipSettings will be copied from the existing clip.")]
		public bool loop;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The folder to save the baked AnimationClips to.")]
		public string saveToFolder;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were 'Idle' and 'Walk', then with '_Baked' as Append Name, the Baker will create 'Idle_Baked' and 'Walk_Baked' animation clips.")]
		public string appendName;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Name of the created AnimationClip file.")]
		public string saveName;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x17000079")]
		public bool isBaking
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xC2424C", Offset = "0xC2424C", VA = "0xC2424C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xC24254", Offset = "0xC24254", VA = "0xC24254")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public float bakingProgress
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xC24260", Offset = "0xC24260", VA = "0xC24260")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xC24268", Offset = "0xC24268", VA = "0xC24268")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		protected float clipLength
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0xC24270", Offset = "0xC24270", VA = "0xC24270")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0xC24278", Offset = "0xC24278", VA = "0xC24278")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xC2413C", Offset = "0xC2413C", VA = "0xC2413C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xC24180", Offset = "0xC24180", VA = "0xC24180")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xC241C4", Offset = "0xC241C4", VA = "0xC241C4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xC24208", Offset = "0xC24208", VA = "0xC24208")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F6")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x60001F7")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x60001F8")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x60001F9")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x60001FA")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xC24280", Offset = "0xC24280", VA = "0xC24280")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xC24284", Offset = "0xC24284", VA = "0xC24284")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xC24288", Offset = "0xC24288", VA = "0xC24288")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xC2428C", Offset = "0xC2428C", VA = "0xC2428C")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("If true, produced AnimationClips will be marked as Legacy and usable with the Legacy animation system.")]
		public bool markAsLegacy;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Root Transform of the hierarchy to bake.")]
		public Transform root;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("Root Node used for root motion.")]
		public Transform rootNode;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("List of Transforms to ignore, rotation curves will not be baked for these Transforms.")]
		public Transform[] ignoreList;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("LocalPosition curves will be baked for these Transforms only. If you are baking a character, the pelvis bone should be added to this array.")]
		public Transform[] bakePositionList;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xC243B4", Offset = "0xC243B4", VA = "0xC243B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xC2475C", Offset = "0xC2475C", VA = "0xC2475C", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xC24764", Offset = "0xC24764", VA = "0xC24764", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xC24860", Offset = "0xC24860", VA = "0xC24860", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xC248D0", Offset = "0xC248D0", VA = "0xC248D0", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xC24938", Offset = "0xC24938", VA = "0xC24938", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xC245EC", Offset = "0xC245EC", VA = "0xC245EC")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xC246A4", Offset = "0xC246A4", VA = "0xC246A4")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xC249A8", Offset = "0xC249A8", VA = "0xC249A8")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class TQ
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xC24A10", Offset = "0xC24A10", VA = "0xC24A10")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class AvatarUtility
	{
		[Token(Token = "0x600020B")]
		[Address(RVA = "0xC24A74", Offset = "0xC24A74", VA = "0xC24A74")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xC24CD0", Offset = "0xC24CD0", VA = "0xC24CD0")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xC24CB0", Offset = "0xC24CB0", VA = "0xC24CB0")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xC25340", Offset = "0xC25340", VA = "0xC25340")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public static class BakerUtilities
	{
		[Token(Token = "0x600020F")]
		[Address(RVA = "0xC25348", Offset = "0xC25348", VA = "0xC25348")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xC25380", Offset = "0xC25380", VA = "0xC25380")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xC25744", Offset = "0xC25744", VA = "0xC25744")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xC25924", Offset = "0xC25924", VA = "0xC25924")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xC25928", Offset = "0xC25928", VA = "0xC25928")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xC25ABC", Offset = "0xC25ABC", VA = "0xC25ABC")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xC25E20", Offset = "0xC25E20", VA = "0xC25E20")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xC25C88", Offset = "0xC25C88", VA = "0xC25C88")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xC26008", Offset = "0xC26008", VA = "0xC26008")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xC2625C", Offset = "0xC2625C", VA = "0xC2625C")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xC2634C", Offset = "0xC2634C", VA = "0xC2634C")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xC26430", Offset = "0xC26430", VA = "0xC26430")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xC263B4", Offset = "0xC263B4", VA = "0xC263B4")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xC264B4", Offset = "0xC264B4", VA = "0xC264B4")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xC2655C", Offset = "0xC2655C", VA = "0xC2655C")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class BakerMuscle
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xC26894", Offset = "0xC26894", VA = "0xC26894")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xC26904", Offset = "0xC26904", VA = "0xC26904")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xC273A0", Offset = "0xC273A0", VA = "0xC273A0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xC27448", Offset = "0xC27448", VA = "0xC27448")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xC27338", Offset = "0xC27338", VA = "0xC27338")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xC27540", Offset = "0xC27540", VA = "0xC27540")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xC2757C", Offset = "0xC2757C", VA = "0xC2757C")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class BakerTransform
	{
		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xC27588", Offset = "0xC27588", VA = "0xC27588")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xC27788", Offset = "0xC27788", VA = "0xC27788")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xC2779C", Offset = "0xC2779C", VA = "0xC2779C")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xC27A50", Offset = "0xC27A50", VA = "0xC27A50")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xC27630", Offset = "0xC27630", VA = "0xC27630")]
		public void Reset()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xC27CD8", Offset = "0xC27CD8", VA = "0xC27CD8")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xC27D5C", Offset = "0xC27D5C", VA = "0xC27D5C")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xC27F50", Offset = "0xC27F50", VA = "0xC27F50")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("Should the hand IK curves be added to the animation? Disable this if the original hand positions are not important when using the clip on another character via Humanoid retargeting.")]
		public bool bakeHandIK;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for 'Key Reduction Error' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(0f, 0.1f)]
		public float IKKeyReductionError;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Tooltip("Frame rate divider for the muscle curves. If you have 'Frame Rate' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(1f, 9f)]
		public int muscleFrameRateDiv;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xC28148", Offset = "0xC28148", VA = "0xC28148")]
		private void Awake()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xC286A8", Offset = "0xC286A8", VA = "0xC286A8", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xC286C4", Offset = "0xC286C4", VA = "0xC286C4", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xC287A0", Offset = "0xC287A0", VA = "0xC287A0", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xC28860", Offset = "0xC28860", VA = "0xC28860", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xC28A00", Offset = "0xC28A00", VA = "0xC28A00", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xC28CA4", Offset = "0xC28CA4", VA = "0xC28CA4")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xC28D80", Offset = "0xC28D80", VA = "0xC28D80")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000069")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000299")]
			Update,
			[Token(Token = "0x400029A")]
			FixedUpdate,
			[Token(Token = "0x400029B")]
			LateUpdate,
			[Token(Token = "0x400029C")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Header("Position")]
		public bool smoothFollow;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Rotation")]
		public float rotationSensitivity;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Distance")]
		public float distance;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("Blocking")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		public float blockedOffset;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x1700007C")]
		public float x
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0xC28E34", Offset = "0xC28E34", VA = "0xC28E34")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000236")]
			[Address(RVA = "0xC28E3C", Offset = "0xC28E3C", VA = "0xC28E3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public float y
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0xC28E44", Offset = "0xC28E44", VA = "0xC28E44")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000238")]
			[Address(RVA = "0xC28E4C", Offset = "0xC28E4C", VA = "0xC28E4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public float distanceTarget
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0xC28E54", Offset = "0xC28E54", VA = "0xC28E54")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600023A")]
			[Address(RVA = "0xC28E5C", Offset = "0xC28E5C", VA = "0xC28E5C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		private float zoomAdd
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0xC2987C", Offset = "0xC2987C", VA = "0xC2987C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xC28E64", Offset = "0xC28E64", VA = "0xC28E64")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xC28E9C", Offset = "0xC28E9C", VA = "0xC28E9C")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xC28EA4", Offset = "0xC28EA4", VA = "0xC28EA4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xC28FDC", Offset = "0xC28FDC", VA = "0xC28FDC", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xC29024", Offset = "0xC29024", VA = "0xC29024", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xC2907C", Offset = "0xC2907C", VA = "0xC2907C", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xC290D4", Offset = "0xC290D4", VA = "0xC290D4")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xC29008", Offset = "0xC29008", VA = "0xC29008")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xC29260", Offset = "0xC29260", VA = "0xC29260")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xC29840", Offset = "0xC29840", VA = "0xC29840")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xC298E8", Offset = "0xC298E8", VA = "0xC298E8")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xC299A8", Offset = "0xC299A8", VA = "0xC299A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xC299D4", Offset = "0xC299D4", VA = "0xC299D4")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xC29BF8", Offset = "0xC29BF8", VA = "0xC29BF8")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xC29C34", Offset = "0xC29C34", VA = "0xC29C34")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public enum Axis
	{
		[Token(Token = "0x40002A3")]
		X,
		[Token(Token = "0x40002A4")]
		Y,
		[Token(Token = "0x40002A5")]
		Z
	}
	[Token(Token = "0x200006C")]
	public class AxisTools
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0xC29C50", Offset = "0xC29C50", VA = "0xC29C50")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xC29D30", Offset = "0xC29D30", VA = "0xC29D30")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xC29D68", Offset = "0xC29D68", VA = "0xC29D68")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xC29EB0", Offset = "0xC29EB0", VA = "0xC29EB0")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xC29E64", Offset = "0xC29E64", VA = "0xC29E64")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xC29FAC", Offset = "0xC29FAC", VA = "0xC29FAC")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xC29FF0", Offset = "0xC29FF0", VA = "0xC29FF0")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xC2A47C", Offset = "0xC2A47C", VA = "0xC2A47C")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x200006E")]
		public class LimbOrientation
		{
			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000256")]
			[Address(RVA = "0xC2A7B0", Offset = "0xC2A7B0", VA = "0xC2A7B0")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000080")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0xC2A4F8", Offset = "0xC2A4F8", VA = "0xC2A4F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0xC2A824", Offset = "0xC2A824", VA = "0xC2A824")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xC2A484", Offset = "0xC2A484", VA = "0xC2A484")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200006F")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000070")]
		public enum BoneType
		{
			[Token(Token = "0x40002C0")]
			Unassigned,
			[Token(Token = "0x40002C1")]
			Spine,
			[Token(Token = "0x40002C2")]
			Head,
			[Token(Token = "0x40002C3")]
			Arm,
			[Token(Token = "0x40002C4")]
			Leg,
			[Token(Token = "0x40002C5")]
			Tail,
			[Token(Token = "0x40002C6")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000071")]
		public enum BoneSide
		{
			[Token(Token = "0x40002C8")]
			Center,
			[Token(Token = "0x40002C9")]
			Left,
			[Token(Token = "0x40002CA")]
			Right
		}

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xC2AADC", Offset = "0xC2AADC", VA = "0xC2AADC")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xC2ADA8", Offset = "0xC2ADA8", VA = "0xC2ADA8")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xC2AFE4", Offset = "0xC2AFE4", VA = "0xC2AFE4")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xC2B058", Offset = "0xC2B058", VA = "0xC2B058")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xC2B0EC", Offset = "0xC2B0EC", VA = "0xC2B0EC")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xC2AC90", Offset = "0xC2AC90", VA = "0xC2AC90")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xC2AF5C", Offset = "0xC2AF5C", VA = "0xC2AF5C")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xC2B824", Offset = "0xC2B824", VA = "0xC2B824")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xC2B67C", Offset = "0xC2B67C", VA = "0xC2B67C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xC2B750", Offset = "0xC2B750", VA = "0xC2B750")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xC2B2D4", Offset = "0xC2B2D4", VA = "0xC2B2D4")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xC2B370", Offset = "0xC2B370", VA = "0xC2B370")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xC2B40C", Offset = "0xC2B40C", VA = "0xC2B40C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xC2B4A8", Offset = "0xC2B4A8", VA = "0xC2B4A8")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xC2B544", Offset = "0xC2B544", VA = "0xC2B544")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xC2B5E0", Offset = "0xC2B5E0", VA = "0xC2B5E0")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xC2BA0C", Offset = "0xC2BA0C", VA = "0xC2BA0C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xC2B200", Offset = "0xC2B200", VA = "0xC2B200")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xC2B988", Offset = "0xC2B988", VA = "0xC2B988")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xC2BA6C", Offset = "0xC2BA6C", VA = "0xC2BA6C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xC2BB2C", Offset = "0xC2BB2C", VA = "0xC2BB2C")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xC2B914", Offset = "0xC2B914", VA = "0xC2B914")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xC2B8A4", Offset = "0xC2B8A4", VA = "0xC2B8A4")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public class BipedReferences
	{
		[Token(Token = "0x2000073")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000084")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000288")]
				[Address(RVA = "0xC325E4", Offset = "0xC325E4", VA = "0xC325E4")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000287")]
			[Address(RVA = "0xC325D0", Offset = "0xC325D0", VA = "0xC325D0")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000082")]
		public virtual bool isFilled
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xC2E91C", Offset = "0xC2E91C", VA = "0xC2E91C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000083")]
		public bool isEmpty
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0xC2EC78", Offset = "0xC2EC78", VA = "0xC2EC78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xC2EC88", Offset = "0xC2EC88", VA = "0xC2EC88", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xC2F014", Offset = "0xC2F014", VA = "0xC2F014", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xC2F3A4", Offset = "0xC2F3A4", VA = "0xC2F3A4")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xC2FAC8", Offset = "0xC2FAC8", VA = "0xC2FAC8")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xC2F638", Offset = "0xC2F638", VA = "0xC2F638")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xC30348", Offset = "0xC30348", VA = "0xC30348")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xC30434", Offset = "0xC30434", VA = "0xC30434")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xC30F50", Offset = "0xC30F50", VA = "0xC30F50")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xC30D5C", Offset = "0xC30D5C", VA = "0xC30D5C")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xC30AFC", Offset = "0xC30AFC", VA = "0xC30AFC")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xC304D0", Offset = "0xC304D0", VA = "0xC304D0")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xC30E50", Offset = "0xC30E50", VA = "0xC30E50")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xC31030", Offset = "0xC31030", VA = "0xC31030")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xC31BD8", Offset = "0xC31BD8", VA = "0xC31BD8")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xC31680", Offset = "0xC31680", VA = "0xC31680")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xC31F24", Offset = "0xC31F24", VA = "0xC31F24")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xC319E0", Offset = "0xC319E0", VA = "0xC319E0")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xC31F2C", Offset = "0xC31F2C", VA = "0xC31F2C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xC31F34", Offset = "0xC31F34", VA = "0xC31F34")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xC320F4", Offset = "0xC320F4", VA = "0xC320F4")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xC32568", Offset = "0xC32568", VA = "0xC32568")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xC2F5B8", Offset = "0xC2F5B8", VA = "0xC2F5B8")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xC325EC", Offset = "0xC325EC", VA = "0xC325EC")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xC325F4", Offset = "0xC325F4", VA = "0xC325F4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xC326EC", Offset = "0xC326EC", VA = "0xC326EC")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class Hierarchy
	{
		[Token(Token = "0x600028C")]
		[Address(RVA = "0xC324E4", Offset = "0xC324E4", VA = "0xC324E4")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xC323D8", Offset = "0xC323D8", VA = "0xC323D8")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xC30634", Offset = "0xC30634", VA = "0xC30634")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xC30C4C", Offset = "0xC30C4C", VA = "0xC30C4C")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xC308B4", Offset = "0xC308B4", VA = "0xC308B4")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xC326FC", Offset = "0xC326FC", VA = "0xC326FC")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xC30764", Offset = "0xC30764", VA = "0xC30764")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xC327F0", Offset = "0xC327F0", VA = "0xC327F0")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xC32B5C", Offset = "0xC32B5C", VA = "0xC32B5C")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xC32954", Offset = "0xC32954", VA = "0xC32954")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xC32CE4", Offset = "0xC32CE4", VA = "0xC32CE4")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xC32CEC", Offset = "0xC32CEC", VA = "0xC32CEC")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xC32D74", Offset = "0xC32D74", VA = "0xC32D74")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40002E4")]
		None,
		[Token(Token = "0x40002E5")]
		InOutCubic,
		[Token(Token = "0x40002E6")]
		InOutQuintic,
		[Token(Token = "0x40002E7")]
		InOutSine,
		[Token(Token = "0x40002E8")]
		InQuintic,
		[Token(Token = "0x40002E9")]
		InQuartic,
		[Token(Token = "0x40002EA")]
		InCubic,
		[Token(Token = "0x40002EB")]
		InQuadratic,
		[Token(Token = "0x40002EC")]
		InElastic,
		[Token(Token = "0x40002ED")]
		InElasticSmall,
		[Token(Token = "0x40002EE")]
		InElasticBig,
		[Token(Token = "0x40002EF")]
		InSine,
		[Token(Token = "0x40002F0")]
		InBack,
		[Token(Token = "0x40002F1")]
		OutQuintic,
		[Token(Token = "0x40002F2")]
		OutQuartic,
		[Token(Token = "0x40002F3")]
		OutCubic,
		[Token(Token = "0x40002F4")]
		OutInCubic,
		[Token(Token = "0x40002F5")]
		OutInQuartic,
		[Token(Token = "0x40002F6")]
		OutElastic,
		[Token(Token = "0x40002F7")]
		OutElasticSmall,
		[Token(Token = "0x40002F8")]
		OutElasticBig,
		[Token(Token = "0x40002F9")]
		OutSine,
		[Token(Token = "0x40002FA")]
		OutBack,
		[Token(Token = "0x40002FB")]
		OutBackCubic,
		[Token(Token = "0x40002FC")]
		OutBackQuartic,
		[Token(Token = "0x40002FD")]
		BackInCubic,
		[Token(Token = "0x40002FE")]
		BackInQuartic
	}
	[Token(Token = "0x2000079")]
	public class Interp
	{
		[Token(Token = "0x6000299")]
		[Address(RVA = "0xC32E00", Offset = "0xC32E00", VA = "0xC32E00")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xC33788", Offset = "0xC33788", VA = "0xC33788")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xC337F8", Offset = "0xC337F8", VA = "0xC337F8")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xC33200", Offset = "0xC33200", VA = "0xC33200")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xC3320C", Offset = "0xC3320C", VA = "0xC3320C")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xC33230", Offset = "0xC33230", VA = "0xC33230")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xC3326C", Offset = "0xC3326C", VA = "0xC3326C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xC33284", Offset = "0xC33284", VA = "0xC33284")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xC33298", Offset = "0xC33298", VA = "0xC33298")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xC332AC", Offset = "0xC332AC", VA = "0xC332AC")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xC332BC", Offset = "0xC332BC", VA = "0xC332BC")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xC33304", Offset = "0xC33304", VA = "0xC33304")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xC3333C", Offset = "0xC3333C", VA = "0xC3333C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xC33364", Offset = "0xC33364", VA = "0xC33364")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xC33868", Offset = "0xC33868", VA = "0xC33868")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xC33398", Offset = "0xC33398", VA = "0xC33398")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xC333C0", Offset = "0xC333C0", VA = "0xC333C0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xC333F0", Offset = "0xC333F0", VA = "0xC333F0")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xC33424", Offset = "0xC33424", VA = "0xC33424")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xC33468", Offset = "0xC33468", VA = "0xC33468")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xC334CC", Offset = "0xC334CC", VA = "0xC334CC")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xC33530", Offset = "0xC33530", VA = "0xC33530")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xC33584", Offset = "0xC33584", VA = "0xC33584")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xC335D8", Offset = "0xC335D8", VA = "0xC335D8")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xC33610", Offset = "0xC33610", VA = "0xC33610")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xC33644", Offset = "0xC33644", VA = "0xC33644")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xC3389C", Offset = "0xC3389C", VA = "0xC3389C")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xC33688", Offset = "0xC33688", VA = "0xC33688")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xC33718", Offset = "0xC33718", VA = "0xC33718")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xC33748", Offset = "0xC33748", VA = "0xC33748")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xC3392C", Offset = "0xC3392C", VA = "0xC3392C")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xC33934", Offset = "0xC33934", VA = "0xC33934")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xC339BC", Offset = "0xC339BC", VA = "0xC339BC")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200007B")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xC33A48", Offset = "0xC33A48", VA = "0xC33A48")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xC33A94", Offset = "0xC33A94", VA = "0xC33A94")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xC33B50", Offset = "0xC33B50", VA = "0xC33B50")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xC33AA8", Offset = "0xC33AA8", VA = "0xC33AA8")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xC33B64", Offset = "0xC33B64", VA = "0xC33B64")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xC33BF4", Offset = "0xC33BF4", VA = "0xC33BF4")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xC33C1C", Offset = "0xC33C1C", VA = "0xC33C1C")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xC33C68", Offset = "0xC33C68", VA = "0xC33C68")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xC33CD0", Offset = "0xC33CD0", VA = "0xC33CD0")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xC33E2C", Offset = "0xC33E2C", VA = "0xC33E2C")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xC33F64", Offset = "0xC33F64", VA = "0xC33F64")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xC33FBC", Offset = "0xC33FBC", VA = "0xC33FBC")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200007C")]
	public static class QuaTools
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xC33FE0", Offset = "0xC33FE0", VA = "0xC33FE0")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xC3402C", Offset = "0xC3402C", VA = "0xC3402C")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xC34078", Offset = "0xC34078", VA = "0xC34078")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xC3417C", Offset = "0xC3417C", VA = "0xC3417C")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xC34280", Offset = "0xC34280", VA = "0xC34280")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xC34394", Offset = "0xC34394", VA = "0xC34394")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xC3443C", Offset = "0xC3443C", VA = "0xC3443C")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xC34548", Offset = "0xC34548", VA = "0xC34548")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xC346B0", Offset = "0xC346B0", VA = "0xC346B0")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xC34894", Offset = "0xC34894", VA = "0xC34894")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xC34964", Offset = "0xC34964", VA = "0xC34964")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xC34AE8", Offset = "0xC34AE8", VA = "0xC34AE8")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xC34BF4", Offset = "0xC34BF4", VA = "0xC34BF4")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200007D")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000085")]
		public static T instance
		{
			[Token(Token = "0x60002D3")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002D5")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000086")]
		private bool animatePhysics
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xC34D68", Offset = "0xC34D68", VA = "0xC34D68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000087")]
		private bool isAnimated
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xC35064", Offset = "0xC35064", VA = "0xC35064")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xC34C4C", Offset = "0xC34C4C", VA = "0xC34C4C")]
		public void Disable()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xC34CE0", Offset = "0xC34CE0", VA = "0xC34CE0", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xC34CE4", Offset = "0xC34CE4", VA = "0xC34CE4", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xC34CE8", Offset = "0xC34CE8", VA = "0xC34CE8", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xC34CEC", Offset = "0xC34CEC", VA = "0xC34CEC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xC34D64", Offset = "0xC34D64", VA = "0xC34D64")]
		private void Start()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xC34D14", Offset = "0xC34D14", VA = "0xC34D14")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xC35028", Offset = "0xC35028", VA = "0xC35028")]
		private void Update()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xC34E34", Offset = "0xC34E34", VA = "0xC34E34")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xC350FC", Offset = "0xC350FC", VA = "0xC350FC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xC35148", Offset = "0xC35148", VA = "0xC35148")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xC35194", Offset = "0xC35194", VA = "0xC35194")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xC351CC", Offset = "0xC351CC", VA = "0xC351CC")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xC351DC", Offset = "0xC351DC", VA = "0xC351DC")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xC35290", Offset = "0xC35290", VA = "0xC35290")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xC35344", Offset = "0xC35344", VA = "0xC35344")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xC353F8", Offset = "0xC353F8", VA = "0xC353F8")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public static class V3Tools
	{
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xC35400", Offset = "0xC35400", VA = "0xC35400")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xC3545C", Offset = "0xC3545C", VA = "0xC3545C")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xC35494", Offset = "0xC35494", VA = "0xC35494")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xC355E4", Offset = "0xC355E4", VA = "0xC355E4")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xC35760", Offset = "0xC35760", VA = "0xC35760")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xC35990", Offset = "0xC35990", VA = "0xC35990")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xC35BE0", Offset = "0xC35BE0", VA = "0xC35BE0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xC35E38", Offset = "0xC35E38", VA = "0xC35E38")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xC35FE4", Offset = "0xC35FE4", VA = "0xC35FE4")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xC361DC", Offset = "0xC361DC", VA = "0xC361DC")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xC36258", Offset = "0xC36258", VA = "0xC36258")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000081")]
	public static class Warning
	{
		[Token(Token = "0x2000082")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xC362E8", Offset = "0xC362E8", VA = "0xC362E8")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xC30294", Offset = "0xC30294", VA = "0xC30294")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000083")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/Ragdoll Manager/Biped Ragdoll Creator")]
	[HelpURL("https://www.youtube.com/watch?v=y-luLRVmL7E&index=1&list=PLVxSIA1OaTOuE2SB9NUbckQ9r2hTg4mvL")]
	public class BipedRagdollCreator : RagdollCreator
	{
		[Serializable]
		[Token(Token = "0x2000084")]
		public struct Options
		{
			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float weight;

			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Header("Optional Bones")]
			public bool spine;

			[Token(Token = "0x400030F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public bool chest;

			[Token(Token = "0x4000310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public bool hands;

			[Token(Token = "0x4000311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public bool feet;

			[Token(Token = "0x4000312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Header("Joints")]
			public JointType joints;

			[Token(Token = "0x4000313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float jointRange;

			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Header("Colliders")]
			public float colliderLengthOverlap;

			[Token(Token = "0x4000315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ColliderType torsoColliders;

			[Token(Token = "0x4000316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ColliderType headCollider;

			[Token(Token = "0x4000317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColliderType armColliders;

			[Token(Token = "0x4000318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ColliderType handColliders;

			[Token(Token = "0x4000319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public ColliderType legColliders;

			[Token(Token = "0x400031A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ColliderType footColliders;

			[Token(Token = "0x17000088")]
			public static Options Default
			{
				[Token(Token = "0x600030B")]
				[Address(RVA = "0xC36724", Offset = "0xC36724", VA = "0xC36724")]
				get
				{
					return default(Options);
				}
			}
		}

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool canBuild;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedRagdollReferences references;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Options options;

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xC364A4", Offset = "0xC364A4", VA = "0xC364A4")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xC364E8", Offset = "0xC364E8", VA = "0xC364E8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xC3652C", Offset = "0xC3652C", VA = "0xC3652C")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xC36570", Offset = "0xC36570", VA = "0xC36570")]
		public static Options AutodetectOptions(BipedRagdollReferences r)
		{
			return default(Options);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xC367D4", Offset = "0xC367D4", VA = "0xC367D4")]
		public static void Create(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xC37118", Offset = "0xC37118", VA = "0xC37118")]
		private static void CreateColliders(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xC38C24", Offset = "0xC38C24", VA = "0xC38C24")]
		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, Options options)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xC3901C", Offset = "0xC3901C", VA = "0xC3901C")]
		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, Options options)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xC39714", Offset = "0xC39714", VA = "0xC39714")]
		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xC37F38", Offset = "0xC37F38", VA = "0xC37F38")]
		private static void MassDistribution(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xC38384", Offset = "0xC38384", VA = "0xC38384")]
		private static void CreateJoints(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xC39814", Offset = "0xC39814", VA = "0xC39814")]
		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, JointType jointType, CreateJointParams.Limits limits1, CreateJointParams.Limits limits2, CreateJointParams.Limits limits3)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xC39FC8", Offset = "0xC39FC8", VA = "0xC39FC8")]
		public static void ClearBipedRagdoll(BipedRagdollReferences r)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xC3A414", Offset = "0xC3A414", VA = "0xC3A414")]
		public static bool IsClear(BipedRagdollReferences r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xC38B9C", Offset = "0xC38B9C", VA = "0xC38B9C")]
		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xC3675C", Offset = "0xC3675C", VA = "0xC3675C")]
		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xC3A4FC", Offset = "0xC3A4FC", VA = "0xC3A4FC")]
		public BipedRagdollCreator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public struct BipedRagdollReferences
	{
		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform root;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform hips;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform spine;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform chest;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform head;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftUpperLeg;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftLowerLeg;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform leftFoot;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightUpperLeg;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightLowerLeg;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightFoot;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftLowerArm;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform leftHand;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightUpperArm;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightLowerArm;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform rightHand;

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xC36918", Offset = "0xC36918", VA = "0xC36918")]
		public bool IsValid(ref string msg)
		{
			return default(bool);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xC3A538", Offset = "0xC3A538", VA = "0xC3A538")]
		private bool IsChildRecursive(Transform t, Transform parent)
		{
			return default(bool);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xC3A620", Offset = "0xC3A620", VA = "0xC3A620")]
		public bool IsEmpty(bool considerRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xC3A91C", Offset = "0xC3A91C", VA = "0xC3A91C")]
		public bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xC3A02C", Offset = "0xC3A02C", VA = "0xC3A02C")]
		public Transform[] GetRagdollTransforms()
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xC3AC24", Offset = "0xC3AC24", VA = "0xC3AC24")]
		public static BipedRagdollReferences FromAvatar(Animator animator)
		{
			return default(BipedRagdollReferences);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xC3AEA0", Offset = "0xC3AEA0", VA = "0xC3AEA0")]
		public static BipedRagdollReferences FromBipedReferences(BipedReferences biped)
		{
			return default(BipedRagdollReferences);
		}
	}
	[Token(Token = "0x2000086")]
	public static class JointConverter
	{
		[Token(Token = "0x6000313")]
		[Address(RVA = "0xC3B044", Offset = "0xC3B044", VA = "0xC3B044")]
		public static void ToConfigurable(GameObject root)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xC3B54C", Offset = "0xC3B54C", VA = "0xC3B54C")]
		public static void HingeToConfigurable(HingeJoint src)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xC3B83C", Offset = "0xC3B83C", VA = "0xC3B83C")]
		public static void FixedToConfigurable(FixedJoint src)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xC3B990", Offset = "0xC3B990", VA = "0xC3B990")]
		public static void SpringToConfigurable(SpringJoint src)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xC3B314", Offset = "0xC3B314", VA = "0xC3B314")]
		public static void CharacterToConfigurable(CharacterJoint src)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xC3BB34", Offset = "0xC3BB34", VA = "0xC3BB34")]
		private static void ConvertJoint(ref ConfigurableJoint conf, Joint src)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xC3BC60", Offset = "0xC3BC60", VA = "0xC3BC60")]
		private static SoftJointLimit ConvertToHighSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xC3BD0C", Offset = "0xC3BD0C", VA = "0xC3BD0C")]
		private static SoftJointLimit ConvertToLowSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xC3BCB8", Offset = "0xC3BCB8", VA = "0xC3BCB8")]
		private static SoftJointLimitSpring ConvertToSoftJointLimitSpring(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimitSpring);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xC3BD64", Offset = "0xC3BD64", VA = "0xC3BD64")]
		private static SoftJointLimit CopyLimit(SoftJointLimit src)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xC3BDC0", Offset = "0xC3BDC0", VA = "0xC3BDC0")]
		private static SoftJointLimitSpring CopyLimitSpring(SoftJointLimitSpring src)
		{
			return default(SoftJointLimitSpring);
		}
	}
	[Token(Token = "0x2000087")]
	public abstract class RagdollCreator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000088")]
		public enum ColliderType
		{
			[Token(Token = "0x400032D")]
			Box,
			[Token(Token = "0x400032E")]
			Capsule
		}

		[Serializable]
		[Token(Token = "0x2000089")]
		public enum JointType
		{
			[Token(Token = "0x4000330")]
			Configurable,
			[Token(Token = "0x4000331")]
			Character
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		public enum Direction
		{
			[Token(Token = "0x4000333")]
			X,
			[Token(Token = "0x4000334")]
			Y,
			[Token(Token = "0x4000335")]
			Z
		}

		[Token(Token = "0x200008B")]
		public struct CreateJointParams
		{
			[Token(Token = "0x200008C")]
			public struct Limits
			{
				[Token(Token = "0x400033C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float minSwing;

				[Token(Token = "0x400033D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public float maxSwing;

				[Token(Token = "0x400033E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public float swing2;

				[Token(Token = "0x400033F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public float twist;

				[Token(Token = "0x600032E")]
				[Address(RVA = "0xC3E6B4", Offset = "0xC3E6B4", VA = "0xC3E6B4")]
				public Limits(float minSwing, float maxSwing, float swing2, float twist)
				{
				}
			}

			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rigidbody rigidbody;

			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Rigidbody connectedBody;

			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform child;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 worldSwingAxis;

			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Limits limits;

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public JointType type;

			[Token(Token = "0x600032D")]
			[Address(RVA = "0xC3E610", Offset = "0xC3E610", VA = "0xC3E610")]
			public CreateJointParams(Rigidbody rigidbody, Rigidbody connectedBody, Transform child, Vector3 worldSwingAxis, Limits limits, JointType type)
			{
			}
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xC3CE0C", Offset = "0xC3CE0C", VA = "0xC3CE0C")]
		public static void ClearAll(Transform root)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xC3CFEC", Offset = "0xC3CFEC", VA = "0xC3CFEC")]
		protected static void ClearTransform(Transform transform)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xC3D1FC", Offset = "0xC3D1FC", VA = "0xC3D1FC")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xC3D6A8", Offset = "0xC3D6A8", VA = "0xC3D6A8")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xC3D544", Offset = "0xC3D544", VA = "0xC3D544")]
		protected static float GetScaleF(Transform t)
		{
			return default(float);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xC3DA30", Offset = "0xC3DA30", VA = "0xC3DA30")]
		protected static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xC3DA40", Offset = "0xC3DA40", VA = "0xC3DA40")]
		protected static void Vector3Abs(ref Vector3 v)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xC3DA5C", Offset = "0xC3DA5C", VA = "0xC3DA5C")]
		protected static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xC3DB3C", Offset = "0xC3DB3C", VA = "0xC3DB3C")]
		protected static Vector3 DirectionToVector3(Direction dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xC3D570", Offset = "0xC3D570", VA = "0xC3D570")]
		protected static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xC3DC1C", Offset = "0xC3DC1C", VA = "0xC3DC1C")]
		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xC3DE94", Offset = "0xC3DE94", VA = "0xC3DE94")]
		protected static Rigidbody GetConnectedBody(Transform bone, ref Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xC3E034", Offset = "0xC3E034", VA = "0xC3E034")]
		protected static void CreateJoint(CreateJointParams p)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xC3E5D8", Offset = "0xC3E5D8", VA = "0xC3E5D8")]
		private static SoftJointLimit ToSoftJointLimit(float limit)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xC3E608", Offset = "0xC3E608", VA = "0xC3E608")]
		protected RagdollCreator()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/Ragdoll Manager/Ragdoll Editor")]
	[HelpURL("https://www.youtube.com/watch?v=y-luLRVmL7E&index=1&list=PLVxSIA1OaTOuE2SB9NUbckQ9r2hTg4mvL")]
	public class RagdollEditor : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008E")]
		public enum Mode
		{
			[Token(Token = "0x4000345")]
			Colliders,
			[Token(Token = "0x4000346")]
			Joints
		}

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Rigidbody selectedRigidbody;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Collider selectedCollider;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool symmetry;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public Mode mode;

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xC3E6C0", Offset = "0xC3E6C0", VA = "0xC3E6C0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xC3E704", Offset = "0xC3E704", VA = "0xC3E704")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xC3E748", Offset = "0xC3E748", VA = "0xC3E748")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xC3E78C", Offset = "0xC3E78C", VA = "0xC3E78C")]
		public RagdollEditor()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200008F")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xC3E79C", Offset = "0xC3E79C", VA = "0xC3E79C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xC3E7E0", Offset = "0xC3E7E0", VA = "0xC3E7E0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xC3E824", Offset = "0xC3E824", VA = "0xC3E824")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xC3E868", Offset = "0xC3E868", VA = "0xC3E868")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xC3E8AC", Offset = "0xC3E8AC", VA = "0xC3E8AC")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xC3E944", Offset = "0xC3E944", VA = "0xC3E944")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xC3E960", Offset = "0xC3E960", VA = "0xC3E960")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xC3E98C", Offset = "0xC3E98C", VA = "0xC3E98C")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xC3E9B8", Offset = "0xC3E9B8", VA = "0xC3E9B8")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xC3E9F4", Offset = "0xC3E9F4", VA = "0xC3E9F4")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xC3EA34", Offset = "0xC3EA34", VA = "0xC3EA34")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xC3EA54", Offset = "0xC3EA54", VA = "0xC3EA54")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xC3EA74", Offset = "0xC3EA74", VA = "0xC3EA74")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xC3EA98", Offset = "0xC3EA98", VA = "0xC3EA98")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xC3EAC0", Offset = "0xC3EAC0", VA = "0xC3EAC0")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xC3EAE8", Offset = "0xC3EAE8", VA = "0xC3EAE8")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xC3E8C8", Offset = "0xC3E8C8", VA = "0xC3E8C8")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xC3EB0C", Offset = "0xC3EB0C", VA = "0xC3EB0C")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xC3EB18", Offset = "0xC3EB18", VA = "0xC3EB18")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xC3EB24", Offset = "0xC3EB24", VA = "0xC3EB24")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xC3EDD8", Offset = "0xC3EDD8", VA = "0xC3EDD8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xC3EE74", Offset = "0xC3EE74", VA = "0xC3EE74", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xC3F1A0", Offset = "0xC3F1A0", VA = "0xC3F1A0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xC3F60C", Offset = "0xC3F60C", VA = "0xC3F60C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xC3F634", Offset = "0xC3F634", VA = "0xC3F634")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000090")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000089")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0xC3EC60", Offset = "0xC3EC60", VA = "0xC3EC60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0xC3F8CC", Offset = "0xC3F8CC", VA = "0xC3F8CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xC3F02C", Offset = "0xC3F02C", VA = "0xC3F02C")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xC3F6E0", Offset = "0xC3F6E0", VA = "0xC3F6E0")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000091")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700008B")]
		public bool isValid
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0xC3FAF4", Offset = "0xC3FAF4", VA = "0xC3FAF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000351")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xC3FB54", Offset = "0xC3FB54", VA = "0xC3FB54")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000092")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xC3FB5C", Offset = "0xC3FB5C", VA = "0xC3FB5C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xC3FBF4", Offset = "0xC3FBF4", VA = "0xC3FBF4")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xC3FBFC", Offset = "0xC3FBFC", VA = "0xC3FBFC")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000093")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700008C")]
		private bool positionChanged
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0xC3FD30", Offset = "0xC3FD30", VA = "0xC3FD30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xC3FC2C", Offset = "0xC3FC2C", VA = "0xC3FC2C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xC3FD8C", Offset = "0xC3FD8C", VA = "0xC3FD8C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xC3FD94", Offset = "0xC3FD94", VA = "0xC3FD94")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000094")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xC3FDC4", Offset = "0xC3FDC4", VA = "0xC3FDC4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xC3FE40", Offset = "0xC3FE40", VA = "0xC3FE40")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xC3FE48", Offset = "0xC3FE48", VA = "0xC3FE48")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000095")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700008D")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0xC3FF7C", Offset = "0xC3FF7C", VA = "0xC3FF7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xC3FE78", Offset = "0xC3FE78", VA = "0xC3FE78", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xC3FFD4", Offset = "0xC3FFD4", VA = "0xC3FFD4")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xC3FFDC", Offset = "0xC3FFDC", VA = "0xC3FFDC")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000096")]
	public class Constraints
	{
		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xC4000C", Offset = "0xC4000C", VA = "0xC4000C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xC3F14C", Offset = "0xC3F14C", VA = "0xC3F14C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xC3F314", Offset = "0xC3F314", VA = "0xC3F314")]
		public void Update()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xC3FAEC", Offset = "0xC3FAEC", VA = "0xC3FAEC")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000097")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000098")]
		public enum DOF
		{
			[Token(Token = "0x400037B")]
			One,
			[Token(Token = "0x400037C")]
			Three
		}

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Master Weight for the finger.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("If enabled, keeps bone1 twist angle fixed relative to bone2.")]
		public bool fixBone1Twist;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x1700008E")]
		public bool initiated
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0xC4006C", Offset = "0xC4006C", VA = "0xC4006C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000366")]
			[Address(RVA = "0xC40074", Offset = "0xC40074", VA = "0xC40074")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0xC40080", Offset = "0xC40080", VA = "0xC40080")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000368")]
			[Address(RVA = "0xC400A0", Offset = "0xC400A0", VA = "0xC400A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0xC400C0", Offset = "0xC400C0", VA = "0xC400C0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600036A")]
			[Address(RVA = "0xC400E0", Offset = "0xC400E0", VA = "0xC400E0")]
			set
			{
			}
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xC40100", Offset = "0xC40100", VA = "0xC40100")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xC401F8", Offset = "0xC401F8", VA = "0xC401F8")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xC406F8", Offset = "0xC406F8", VA = "0xC406F8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xC407C4", Offset = "0xC407C4", VA = "0xC407C4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xC4087C", Offset = "0xC4087C", VA = "0xC4087C")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xC40EE4", Offset = "0xC40EE4", VA = "0xC40EE4")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The master weight for all fingers.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x17000091")]
		public bool initiated
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0xC40EF4", Offset = "0xC40EF4", VA = "0xC40EF4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000372")]
			[Address(RVA = "0xC40EFC", Offset = "0xC40EFC", VA = "0xC40EFC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xC40F08", Offset = "0xC40F08", VA = "0xC40F08")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xC40F7C", Offset = "0xC40F7C", VA = "0xC40F7C")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xC412F4", Offset = "0xC412F4", VA = "0xC412F4")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xC414AC", Offset = "0xC414AC", VA = "0xC414AC")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xC41204", Offset = "0xC41204", VA = "0xC41204")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xC4162C", Offset = "0xC4162C", VA = "0xC4162C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xC416D4", Offset = "0xC416D4", VA = "0xC416D4")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xC41738", Offset = "0xC41738", VA = "0xC41738")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xC417A0", Offset = "0xC417A0", VA = "0xC417A0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xC417FC", Offset = "0xC417FC", VA = "0xC417FC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xC41800", Offset = "0xC41800", VA = "0xC41800", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xC41814", Offset = "0xC41814", VA = "0xC41814")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x200009B")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x17000092")]
		public bool initiated
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0xC41880", Offset = "0xC41880", VA = "0xC41880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000381")]
			[Address(RVA = "0xC41888", Offset = "0xC41888", VA = "0xC41888")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x600037F")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xC41894", Offset = "0xC41894", VA = "0xC41894")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xC41B44", Offset = "0xC41B44", VA = "0xC41B44")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xC41958", Offset = "0xC41958", VA = "0xC41958")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xC41B6C", Offset = "0xC41B6C", VA = "0xC41B6C")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000386")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000387")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xC41CE0", Offset = "0xC41CE0", VA = "0xC41CE0")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xC41F04", Offset = "0xC41F04", VA = "0xC41F04", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xC41F48", Offset = "0xC41F48", VA = "0xC41F48", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xC41F8C", Offset = "0xC41F8C", VA = "0xC41F8C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xC4206C", Offset = "0xC4206C", VA = "0xC4206C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xC4210C", Offset = "0xC4210C", VA = "0xC4210C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xC42160", Offset = "0xC42160", VA = "0xC42160")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xC42780", Offset = "0xC42780", VA = "0xC42780")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xC427C0", Offset = "0xC427C0", VA = "0xC427C0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xC42E0C", Offset = "0xC42E0C", VA = "0xC42E0C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xC42F34", Offset = "0xC42F34", VA = "0xC42F34")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xC43104", Offset = "0xC43104", VA = "0xC43104")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xC432DC", Offset = "0xC432DC", VA = "0xC432DC")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200009E")]
		public class SpineEffector
		{
			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			[Token(Token = "0x60003A7")]
			[Address(RVA = "0xC4402C", Offset = "0xC4402C", VA = "0xC4402C")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xC4403C", Offset = "0xC4403C", VA = "0xC4403C")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xC43380", Offset = "0xC43380", VA = "0xC43380")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xC433C4", Offset = "0xC433C4", VA = "0xC433C4", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xC43408", Offset = "0xC43408", VA = "0xC43408", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xC4344C", Offset = "0xC4344C", VA = "0xC4344C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xC434B4", Offset = "0xC434B4", VA = "0xC434B4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xC4353C", Offset = "0xC4353C", VA = "0xC4353C")]
		private void Update()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xC437E8", Offset = "0xC437E8", VA = "0xC437E8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xC437F4", Offset = "0xC437F4", VA = "0xC437F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xC43598", Offset = "0xC43598", VA = "0xC43598")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xC43800", Offset = "0xC43800", VA = "0xC43800")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xC43B70", Offset = "0xC43B70", VA = "0xC43B70")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xC43CF4", Offset = "0xC43CF4", VA = "0xC43CF4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xC43E54", Offset = "0xC43E54", VA = "0xC43E54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xC43F88", Offset = "0xC43F88", VA = "0xC43F88")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xC44080", Offset = "0xC44080", VA = "0xC44080", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xC440C4", Offset = "0xC440C4", VA = "0xC440C4", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xC44108", Offset = "0xC44108", VA = "0xC44108", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xC44120", Offset = "0xC44120", VA = "0xC44120")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xC44340", Offset = "0xC44340", VA = "0xC44340")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xC44420", Offset = "0xC44420", VA = "0xC44420")]
		private void Update()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xC44B04", Offset = "0xC44B04", VA = "0xC44B04")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xC44FBC", Offset = "0xC44FBC", VA = "0xC44FBC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xC45168", Offset = "0xC45168", VA = "0xC45168")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xC454F0", Offset = "0xC454F0", VA = "0xC454F0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xC456C8", Offset = "0xC456C8", VA = "0xC456C8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xC458F0", Offset = "0xC458F0", VA = "0xC458F0")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x20000A1")]
		public struct Foot
		{
			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60003C7")]
			[Address(RVA = "0xC464E4", Offset = "0xC464E4", VA = "0xC464E4")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		public float rootRotationWeight;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(-90f, 0f)]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		public float minRootRotation;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 90f)]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		public float maxRootRotation;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xC45994", Offset = "0xC45994", VA = "0xC45994", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xC459D8", Offset = "0xC459D8", VA = "0xC459D8", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xC45A1C", Offset = "0xC45A1C", VA = "0xC45A1C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xC45A44", Offset = "0xC45A44", VA = "0xC45A44")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xC45B48", Offset = "0xC45B48", VA = "0xC45B48")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xC45D40", Offset = "0xC45D40", VA = "0xC45D40")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xC45DA4", Offset = "0xC45DA4", VA = "0xC45DA4")]
		private void Update()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xC45DFC", Offset = "0xC45DFC", VA = "0xC45DFC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xC46148", Offset = "0xC46148", VA = "0xC46148")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xC46544", Offset = "0xC46544", VA = "0xC46544")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xC465D4", Offset = "0xC465D4", VA = "0xC465D4")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xC46A24", Offset = "0xC46A24", VA = "0xC46A24")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xC470E4", Offset = "0xC470E4", VA = "0xC470E4")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xC4739C", Offset = "0xC4739C", VA = "0xC4739C")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xC474D0", Offset = "0xC474D0", VA = "0xC474D0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xC47798", Offset = "0xC47798", VA = "0xC47798")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xC477C8", Offset = "0xC477C8", VA = "0xC477C8")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xC479E8", Offset = "0xC479E8", VA = "0xC479E8")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder VRIK")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the VRIK componet.")]
		public VRIK ik;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xC47B3C", Offset = "0xC47B3C", VA = "0xC47B3C")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xC47B80", Offset = "0xC47B80", VA = "0xC47B80", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xC47BC4", Offset = "0xC47BC4", VA = "0xC47BC4", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xC47C08", Offset = "0xC47C08", VA = "0xC47C08", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xC47C20", Offset = "0xC47C20", VA = "0xC47C20")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xC47CA8", Offset = "0xC47CA8", VA = "0xC47CA8")]
		private void Update()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xC47CFC", Offset = "0xC47CFC", VA = "0xC47CFC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xC47F80", Offset = "0xC47F80", VA = "0xC47F80")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xC48174", Offset = "0xC48174", VA = "0xC48174")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xC481F8", Offset = "0xC481F8", VA = "0xC481F8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xC48494", Offset = "0xC48494", VA = "0xC48494")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xC485F4", Offset = "0xC485F4", VA = "0xC485F4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xC487BC", Offset = "0xC487BC", VA = "0xC487BC")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A3")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x20000A4")]
		public enum Quality
		{
			[Token(Token = "0x40003E2")]
			Fastest,
			[Token(Token = "0x40003E3")]
			Simple,
			[Token(Token = "0x40003E4")]
			Best
		}

		[Token(Token = "0x20000A5")]
		public class Leg
		{
			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x1700009B")]
			public bool isGrounded
			{
				[Token(Token = "0x60003ED")]
				[Address(RVA = "0xC49BA4", Offset = "0xC49BA4", VA = "0xC49BA4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003EE")]
				[Address(RVA = "0xC49BAC", Offset = "0xC49BAC", VA = "0xC49BAC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009C")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60003EF")]
				[Address(RVA = "0xC49BB8", Offset = "0xC49BB8", VA = "0xC49BB8")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60003F0")]
				[Address(RVA = "0xC49BC4", Offset = "0xC49BC4", VA = "0xC49BC4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009D")]
			public bool initiated
			{
				[Token(Token = "0x60003F1")]
				[Address(RVA = "0xC49BD0", Offset = "0xC49BD0", VA = "0xC49BD0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003F2")]
				[Address(RVA = "0xC49BD8", Offset = "0xC49BD8", VA = "0xC49BD8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009E")]
			public float heightFromGround
			{
				[Token(Token = "0x60003F3")]
				[Address(RVA = "0xC49BE4", Offset = "0xC49BE4", VA = "0xC49BE4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60003F4")]
				[Address(RVA = "0xC49BEC", Offset = "0xC49BEC", VA = "0xC49BEC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009F")]
			public Vector3 velocity
			{
				[Token(Token = "0x60003F5")]
				[Address(RVA = "0xC49BF4", Offset = "0xC49BF4", VA = "0xC49BF4")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60003F6")]
				[Address(RVA = "0xC49C00", Offset = "0xC49C00", VA = "0xC49C00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A0")]
			public Transform transform
			{
				[Token(Token = "0x60003F7")]
				[Address(RVA = "0xC49C0C", Offset = "0xC49C0C", VA = "0xC49C0C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60003F8")]
				[Address(RVA = "0xC49C14", Offset = "0xC49C14", VA = "0xC49C14")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A1")]
			public float IKOffset
			{
				[Token(Token = "0x60003F9")]
				[Address(RVA = "0xC49C1C", Offset = "0xC49C1C", VA = "0xC49C1C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60003FA")]
				[Address(RVA = "0xC49C24", Offset = "0xC49C24", VA = "0xC49C24")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60003FB")]
				[Address(RVA = "0xC49C2C", Offset = "0xC49C2C", VA = "0xC49C2C")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60003FC")]
				[Address(RVA = "0xC49C44", Offset = "0xC49C44", VA = "0xC49C44")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60003FD")]
				[Address(RVA = "0xC49C64", Offset = "0xC49C64", VA = "0xC49C64")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60003FE")]
				[Address(RVA = "0xC49C7C", Offset = "0xC49C7C", VA = "0xC49C7C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60003FF")]
				[Address(RVA = "0xC49C9C", Offset = "0xC49C9C", VA = "0xC49C9C")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x170000A5")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000405")]
				[Address(RVA = "0xC4A584", Offset = "0xC4A584", VA = "0xC4A584")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000A6")]
			private float rootYOffset
			{
				[Token(Token = "0x600040E")]
				[Address(RVA = "0xC4A6D4", Offset = "0xC4A6D4", VA = "0xC4A6D4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000400")]
			[Address(RVA = "0xC49CE4", Offset = "0xC49CE4", VA = "0xC49CE4")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000401")]
			[Address(RVA = "0xC48CE8", Offset = "0xC48CE8", VA = "0xC48CE8")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000402")]
			[Address(RVA = "0xC49CF8", Offset = "0xC49CF8", VA = "0xC49CF8")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000403")]
			[Address(RVA = "0xC49814", Offset = "0xC49814", VA = "0xC49814")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000404")]
			[Address(RVA = "0xC48DFC", Offset = "0xC48DFC", VA = "0xC48DFC")]
			public void Process()
			{
			}

			[Token(Token = "0x6000406")]
			[Address(RVA = "0xC4A198", Offset = "0xC4A198", VA = "0xC4A198")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000407")]
			[Address(RVA = "0xC49D38", Offset = "0xC49D38", VA = "0xC49D38")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000408")]
			[Address(RVA = "0xC4A618", Offset = "0xC4A618", VA = "0xC4A618")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000409")]
			[Address(RVA = "0xC4A000", Offset = "0xC4A000", VA = "0xC4A000")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x600040A")]
			[Address(RVA = "0xC4A080", Offset = "0xC4A080", VA = "0xC4A080")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0xC4A684", Offset = "0xC4A684", VA = "0xC4A684")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0xC4A5B8", Offset = "0xC4A5B8", VA = "0xC4A5B8")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0xC4A760", Offset = "0xC4A760", VA = "0xC4A760")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600040F")]
			[Address(RVA = "0xC48C48", Offset = "0xC48C48", VA = "0xC48C48")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000A6")]
		public class Pelvis
		{
			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000A7")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000410")]
				[Address(RVA = "0xC4A910", Offset = "0xC4A910", VA = "0xC4A910")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000411")]
				[Address(RVA = "0xC4A91C", Offset = "0xC4A91C", VA = "0xC4A91C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			public float heightOffset
			{
				[Token(Token = "0x6000412")]
				[Address(RVA = "0xC4A928", Offset = "0xC4A928", VA = "0xC4A928")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000413")]
				[Address(RVA = "0xC4A930", Offset = "0xC4A930", VA = "0xC4A930")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000414")]
			[Address(RVA = "0xC48DC0", Offset = "0xC48DC0", VA = "0xC48DC0")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0xC49780", Offset = "0xC49780", VA = "0xC49780")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000416")]
			[Address(RVA = "0xC4A938", Offset = "0xC4A938", VA = "0xC4A938")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000417")]
			[Address(RVA = "0xC49594", Offset = "0xC49594", VA = "0xC49594")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000418")]
			[Address(RVA = "0xC48CE0", Offset = "0xC48CE0", VA = "0xC48CE0")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Offset of the foot center along character forward axis.")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 90f)]
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		public float pelvisDamper;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
		public bool overstepFallsDown;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000093")]
		public Leg[] legs
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0xC4881C", Offset = "0xC4881C", VA = "0xC4881C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0xC48824", Offset = "0xC48824", VA = "0xC48824")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0xC4882C", Offset = "0xC4882C", VA = "0xC4882C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0xC48834", Offset = "0xC48834", VA = "0xC48834")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public bool isGrounded
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0xC4883C", Offset = "0xC4883C", VA = "0xC4883C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0xC48844", Offset = "0xC48844", VA = "0xC48844")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public Transform root
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0xC48850", Offset = "0xC48850", VA = "0xC48850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0xC48858", Offset = "0xC48858", VA = "0xC48858")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0xC48860", Offset = "0xC48860", VA = "0xC48860")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xC48878", Offset = "0xC48878", VA = "0xC48878")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public bool rootGrounded
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0xC48898", Offset = "0xC48898", VA = "0xC48898")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000099")]
		public Vector3 up
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xC42ECC", Offset = "0xC42ECC", VA = "0xC42ECC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700009A")]
		private bool useRootRotation
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xC498A8", Offset = "0xC498A8", VA = "0xC498A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xC488E0", Offset = "0xC488E0", VA = "0xC488E0")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xC48B40", Offset = "0xC48B40", VA = "0xC48B40")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xC424BC", Offset = "0xC424BC", VA = "0xC424BC")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xC42C18", Offset = "0xC42C18", VA = "0xC42C18")]
		public void Update()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xC4498C", Offset = "0xC4498C", VA = "0xC4498C")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xC41FF4", Offset = "0xC41FF4", VA = "0xC41FF4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xC48DE4", Offset = "0xC48DE4", VA = "0xC48DE4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xC4995C", Offset = "0xC4995C", VA = "0xC4995C")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xC499E0", Offset = "0xC499E0", VA = "0xC499E0")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xC49B34", Offset = "0xC49B34", VA = "0xC49B34")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xC41DA4", Offset = "0xC41DA4", VA = "0xC41DA4")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xC4A98C", Offset = "0xC4A98C", VA = "0xC4A98C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xC4A9D0", Offset = "0xC4A9D0", VA = "0xC4A9D0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xC4AA14", Offset = "0xC4AA14", VA = "0xC4AA14")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xC4AA58", Offset = "0xC4AA58", VA = "0xC4AA58")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xC4AA9C", Offset = "0xC4AA9C", VA = "0xC4AA9C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xC4AAE0", Offset = "0xC4AAE0", VA = "0xC4AAE0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xC4AAE8", Offset = "0xC4AAE8", VA = "0xC4AAE8")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	public class ArmIK : IK
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xC4AB64", Offset = "0xC4AB64", VA = "0xC4AB64", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xC4ABA8", Offset = "0xC4ABA8", VA = "0xC4ABA8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xC4ABEC", Offset = "0xC4ABEC", VA = "0xC4ABEC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xC4AC30", Offset = "0xC4AC30", VA = "0xC4AC30")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xC4AC74", Offset = "0xC4AC74", VA = "0xC4AC74", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xC4AC7C", Offset = "0xC4AC7C", VA = "0xC4AC7C")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xC4ACF0", Offset = "0xC4ACF0", VA = "0xC4ACF0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xC4AD34", Offset = "0xC4AD34", VA = "0xC4AD34", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xC4AD78", Offset = "0xC4AD78", VA = "0xC4AD78")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xC4ADBC", Offset = "0xC4ADBC", VA = "0xC4ADBC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xC4AE00", Offset = "0xC4AE00", VA = "0xC4AE00", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xC4AE08", Offset = "0xC4AE08", VA = "0xC4AE08")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xC4AE7C", Offset = "0xC4AE7C", VA = "0xC4AE7C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xC4AEC0", Offset = "0xC4AEC0", VA = "0xC4AEC0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xC4AF04", Offset = "0xC4AF04", VA = "0xC4AF04")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xC4AF48", Offset = "0xC4AF48", VA = "0xC4AF48")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xC4AF8C", Offset = "0xC4AF8C", VA = "0xC4AF8C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xC4AF94", Offset = "0xC4AF94", VA = "0xC4AF94")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xC4B008", Offset = "0xC4B008", VA = "0xC4B008", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xC4B04C", Offset = "0xC4B04C", VA = "0xC4B04C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xC4B090", Offset = "0xC4B090", VA = "0xC4B090")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xC4B0D4", Offset = "0xC4B0D4", VA = "0xC4B0D4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xC4B118", Offset = "0xC4B118", VA = "0xC4B118", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xC4B120", Offset = "0xC4B120", VA = "0xC4B120")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xC4B194", Offset = "0xC4B194", VA = "0xC4B194", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xC4B1D8", Offset = "0xC4B1D8", VA = "0xC4B1D8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xC4B21C", Offset = "0xC4B21C", VA = "0xC4B21C")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xC4B260", Offset = "0xC4B260", VA = "0xC4B260")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xC4B2A4", Offset = "0xC4B2A4", VA = "0xC4B2A4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xC4B2E8", Offset = "0xC4B2E8", VA = "0xC4B2E8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xC4B32C", Offset = "0xC4B32C", VA = "0xC4B32C")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xC4B36C", Offset = "0xC4B36C", VA = "0xC4B36C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xC4B374", Offset = "0xC4B374", VA = "0xC4B374")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xC4B544", Offset = "0xC4B544", VA = "0xC4B544")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xC4BA00", Offset = "0xC4BA00", VA = "0xC4BA00")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xC4BA20", Offset = "0xC4BA20", VA = "0xC4BA20")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xC4BB10", Offset = "0xC4BB10", VA = "0xC4BB10")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000445")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xC4BBC0", Offset = "0xC4BBC0", VA = "0xC4BBC0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xC4BC38", Offset = "0xC4BC38", VA = "0xC4BC38", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xC4BCA8", Offset = "0xC4BCA8", VA = "0xC4BCA8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000449")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600044A")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xC4AB5C", Offset = "0xC4AB5C", VA = "0xC4AB5C")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected bool fixedFrame;

		[Token(Token = "0x170000A9")]
		protected bool animatePhysics
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0xC4BCF8", Offset = "0xC4BCF8", VA = "0xC4BCF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xC4BD84", Offset = "0xC4BD84", VA = "0xC4BD84")]
		private void Start()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xC4BDE8", Offset = "0xC4BDE8", VA = "0xC4BDE8")]
		private void Update()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xC4BE88", Offset = "0xC4BE88", VA = "0xC4BE88")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xC4BEB4", Offset = "0xC4BEB4", VA = "0xC4BEB4", Slot = "4")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xC4BE0C", Offset = "0xC4BE0C", VA = "0xC4BE0C")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xC4BF38", Offset = "0xC4BF38", VA = "0xC4BF38")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xC4BF40", Offset = "0xC4BF40", VA = "0xC4BF40", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xC4BF84", Offset = "0xC4BF84", VA = "0xC4BF84", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xC4BFC8", Offset = "0xC4BFC8", VA = "0xC4BFC8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xC4C00C", Offset = "0xC4C00C", VA = "0xC4C00C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xC4C050", Offset = "0xC4C050", VA = "0xC4C050", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xC4C058", Offset = "0xC4C058", VA = "0xC4C058")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	public class LimbIK : IK
	{
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xC4C0CC", Offset = "0xC4C0CC", VA = "0xC4C0CC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xC4C110", Offset = "0xC4C110", VA = "0xC4C110", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xC4C154", Offset = "0xC4C154", VA = "0xC4C154")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xC4C198", Offset = "0xC4C198", VA = "0xC4C198")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xC4C1DC", Offset = "0xC4C1DC", VA = "0xC4C1DC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xC4C1E4", Offset = "0xC4C1E4", VA = "0xC4C1E4")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xC4C258", Offset = "0xC4C258", VA = "0xC4C258", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xC4C29C", Offset = "0xC4C29C", VA = "0xC4C29C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xC4C2E0", Offset = "0xC4C2E0", VA = "0xC4C2E0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xC4C324", Offset = "0xC4C324", VA = "0xC4C324")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xC4C368", Offset = "0xC4C368", VA = "0xC4C368", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xC4C370", Offset = "0xC4C370", VA = "0xC4C370")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xC4C3E4", Offset = "0xC4C3E4", VA = "0xC4C3E4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xC4C428", Offset = "0xC4C428", VA = "0xC4C428", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xC4C46C", Offset = "0xC4C46C", VA = "0xC4C46C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xC4C4B0", Offset = "0xC4C4B0", VA = "0xC4C4B0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xC4C4F4", Offset = "0xC4C4F4", VA = "0xC4C4F4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xC4C4FC", Offset = "0xC4C4FC", VA = "0xC4C4FC")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000B4")]
		public class References
		{
			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Optional")]
			public Transform chest;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Optional")]
			public Transform neck;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Optional")]
			public Transform leftShoulder;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Optional")]
			public Transform rightShoulder;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftThigh;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot;

			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("Optional")]
			public Transform leftToes;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightThigh;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[Tooltip("Optional")]
			public Transform rightToes;

			[Token(Token = "0x170000AA")]
			public bool isFilled
			{
				[Token(Token = "0x6000475")]
				[Address(RVA = "0xC4CF4C", Offset = "0xC4CF4C", VA = "0xC4CF4C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000AB")]
			public bool isEmpty
			{
				[Token(Token = "0x6000476")]
				[Address(RVA = "0xC4CB90", Offset = "0xC4CB90", VA = "0xC4CB90")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0xC4D550", Offset = "0xC4D550", VA = "0xC4D550")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0xC4C658", Offset = "0xC4C658", VA = "0xC4C658")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0xC4D548", Offset = "0xC4D548", VA = "0xC4D548")]
			public References()
			{
			}
		}

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		public References references;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xC4C570", Offset = "0xC4C570", VA = "0xC4C570", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xC4C5B4", Offset = "0xC4C5B4", VA = "0xC4C5B4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xC4C5F8", Offset = "0xC4C5F8", VA = "0xC4C5F8")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xC4C63C", Offset = "0xC4C63C", VA = "0xC4C63C")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xC4CAF4", Offset = "0xC4CAF4", VA = "0xC4CAF4")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xC4CB1C", Offset = "0xC4CB1C", VA = "0xC4CB1C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xC4CB24", Offset = "0xC4CB24", VA = "0xC4CB24", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xC4D308", Offset = "0xC4D308", VA = "0xC4D308", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xC4D498", Offset = "0xC4D498", VA = "0xC4D498")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B5")]
	public class FABRIKChain
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xC4DA94", Offset = "0xC4DA94", VA = "0xC4DA94")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xC4DB64", Offset = "0xC4DB64", VA = "0xC4DB64")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xC4DB84", Offset = "0xC4DB84", VA = "0xC4DB84")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xC4DDD8", Offset = "0xC4DDD8", VA = "0xC4DDD8")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xC4DC44", Offset = "0xC4DC44", VA = "0xC4DC44")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xC4DEBC", Offset = "0xC4DEBC", VA = "0xC4DEBC")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xC4DF28", Offset = "0xC4DF28", VA = "0xC4DF28")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xC4E3D8", Offset = "0xC4E3D8", VA = "0xC4E3D8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xC4E56C", Offset = "0xC4E56C", VA = "0xC4E56C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xC4E698", Offset = "0xC4E698", VA = "0xC4E698")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B8")]
		public class BendBone
		{
			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			[Tooltip("The weight of rotating this bone.")]
			public float weight;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000491")]
			[Address(RVA = "0xC518B0", Offset = "0xC518B0", VA = "0xC518B0")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0xC51910", Offset = "0xC51910", VA = "0xC51910")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0xC51998", Offset = "0xC51998", VA = "0xC51998")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0xC519C4", Offset = "0xC519C4", VA = "0xC519C4")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[LargeHeader("Position")]
		[Tooltip("Master weight for positioning the head.")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the body along with the head")]
		public float bodyWeight;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The weight of moving the thighs along with the head")]
		[Range(0f, 1f)]
		public float thighWeight;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[LargeHeader("Rotation")]
		[Tooltip("The weight of rotating the head bone after solving")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Clamping the rotation of the body")]
		[Range(0f, 1f)]
		public float bodyClampWeight;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Clamping the rotation of the head")]
		[Range(0f, 1f)]
		public float headClampWeight;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		public float bendWeight;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[LargeHeader("CCD")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[Range(0f, 1f)]
		public float CCDWeight;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rolling the bones in towards the target")]
		public float roll;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1000f)]
		[Tooltip("Smoothing the CCD effect.")]
		public float damper;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[LargeHeader("Stretching")]
		public float postStretchWeight;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xC4E6A0", Offset = "0xC4E6A0", VA = "0xC4E6A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xC4EAE0", Offset = "0xC4EAE0", VA = "0xC4EAE0")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xC4EF94", Offset = "0xC4EF94", VA = "0xC4EF94")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xC4F33C", Offset = "0xC4F33C", VA = "0xC4F33C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xC4FC38", Offset = "0xC4FC38", VA = "0xC4FC38")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xC50030", Offset = "0xC50030", VA = "0xC50030")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xC50440", Offset = "0xC50440", VA = "0xC50440")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xC50DC0", Offset = "0xC50DC0", VA = "0xC50DC0")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xC4F97C", Offset = "0xC4F97C", VA = "0xC4F97C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xC50FFC", Offset = "0xC50FFC", VA = "0xC50FFC")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xC50CD8", Offset = "0xC50CD8", VA = "0xC50CD8")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xC50BD8", Offset = "0xC50BD8", VA = "0xC50BD8")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xC51300", Offset = "0xC51300", VA = "0xC51300")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xC5169C", Offset = "0xC5169C", VA = "0xC5169C")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000BA")]
		public class ChildConstraint
		{
			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x170000AC")]
			public float nominalDistance
			{
				[Token(Token = "0x60004A9")]
				[Address(RVA = "0xC54A68", Offset = "0xC54A68", VA = "0xC54A68")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004AA")]
				[Address(RVA = "0xC54A70", Offset = "0xC54A70", VA = "0xC54A70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000AD")]
			public bool isRigid
			{
				[Token(Token = "0x60004AB")]
				[Address(RVA = "0xC54A78", Offset = "0xC54A78", VA = "0xC54A78")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60004AC")]
				[Address(RVA = "0xC54A80", Offset = "0xC54A80", VA = "0xC54A80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0xC54A8C", Offset = "0xC54A8C", VA = "0xC54A8C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0xC52768", Offset = "0xC52768", VA = "0xC52768")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0xC52E38", Offset = "0xC52E38", VA = "0xC52E38")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0xC5482C", Offset = "0xC5482C", VA = "0xC5482C")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BB")]
		public enum Smoothing
		{
			[Token(Token = "0x4000486")]
			None,
			[Token(Token = "0x4000487")]
			Exponential,
			[Token(Token = "0x4000488")]
			Cubic
		}

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float push;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(-1f, 1f)]
		public float pushParent;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float reach;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x400047A")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xC519EC", Offset = "0xC519EC", VA = "0xC519EC")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xC51B78", Offset = "0xC51B78", VA = "0xC51B78")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xC51CE8", Offset = "0xC51CE8", VA = "0xC51CE8")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xC51E4C", Offset = "0xC51E4C", VA = "0xC51E4C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xC51F08", Offset = "0xC51F08", VA = "0xC51F08")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xC52024", Offset = "0xC52024", VA = "0xC52024")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xC52A54", Offset = "0xC52A54", VA = "0xC52A54")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xC521A0", Offset = "0xC521A0", VA = "0xC521A0")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xC5301C", Offset = "0xC5301C", VA = "0xC5301C")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xC532B0", Offset = "0xC532B0", VA = "0xC532B0")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xC53580", Offset = "0xC53580", VA = "0xC53580")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xC53F30", Offset = "0xC53F30", VA = "0xC53F30")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xC54428", Offset = "0xC54428", VA = "0xC54428")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xC54628", Offset = "0xC54628", VA = "0xC54628")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xC54314", Offset = "0xC54314", VA = "0xC54314")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xC53DD0", Offset = "0xC53DD0", VA = "0xC53DD0")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xC542B0", Offset = "0xC542B0", VA = "0xC542B0")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xC54704", Offset = "0xC54704", VA = "0xC54704")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xC541DC", Offset = "0xC541DC", VA = "0xC541DC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xC5452C", Offset = "0xC5452C", VA = "0xC5452C")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BC")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x170000AE")]
		public bool initiated
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0xC54DD4", Offset = "0xC54DD4", VA = "0xC54DD4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0xC54DDC", Offset = "0xC54DDC", VA = "0xC54DDC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xC54BFC", Offset = "0xC54BFC", VA = "0xC54BFC")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xC51B18", Offset = "0xC51B18", VA = "0xC51B18")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xC54DE8", Offset = "0xC54DE8", VA = "0xC54DE8")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xC527B4", Offset = "0xC527B4", VA = "0xC527B4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xC527F8", Offset = "0xC527F8", VA = "0xC527F8")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xC55018", Offset = "0xC55018", VA = "0xC55018")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xC5536C", Offset = "0xC5536C", VA = "0xC5536C")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xC537B8", Offset = "0xC537B8", VA = "0xC537B8")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xC54EE0", Offset = "0xC54EE0", VA = "0xC54EE0")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xC54F7C", Offset = "0xC54F7C", VA = "0xC54F7C")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000BD")]
	public class IKEffector
	{
		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x170000AF")]
		public bool isEndEffector
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0xC557E0", Offset = "0xC557E0", VA = "0xC557E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0xC557E8", Offset = "0xC557E8", VA = "0xC557E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xC55784", Offset = "0xC55784", VA = "0xC55784")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xC557F4", Offset = "0xC557F4", VA = "0xC557F4")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xC55878", Offset = "0xC55878", VA = "0xC55878")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xC55A48", Offset = "0xC55A48", VA = "0xC55A48")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xC55C54", Offset = "0xC55C54", VA = "0xC55C54")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xC55F5C", Offset = "0xC55F5C", VA = "0xC55F5C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xC56220", Offset = "0xC56220", VA = "0xC56220")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xC56338", Offset = "0xC56338", VA = "0xC56338")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xC563D4", Offset = "0xC563D4", VA = "0xC563D4")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xC56A74", Offset = "0xC56A74", VA = "0xC56A74")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xC56ACC", Offset = "0xC56ACC", VA = "0xC56ACC")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xC56C94", Offset = "0xC56C94", VA = "0xC56C94")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xC56EDC", Offset = "0xC56EDC", VA = "0xC56EDC")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000BE")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000BF")]
		public class BoneMap
		{
			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000B0")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60004D2")]
				[Address(RVA = "0xC5743C", Offset = "0xC5743C", VA = "0xC5743C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B1")]
			public bool isNodeBone
			{
				[Token(Token = "0x60004D5")]
				[Address(RVA = "0xC574F4", Offset = "0xC574F4", VA = "0xC574F4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B2")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60004E9")]
				[Address(RVA = "0xC578D4", Offset = "0xC578D4", VA = "0xC578D4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0xC573FC", Offset = "0xC573FC", VA = "0xC573FC")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0xC5746C", Offset = "0xC5746C", VA = "0xC5746C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0xC574B0", Offset = "0xC574B0", VA = "0xC574B0")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xC57504", Offset = "0xC57504", VA = "0xC57504")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xC575D8", Offset = "0xC575D8", VA = "0xC575D8")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0xC575E0", Offset = "0xC575E0", VA = "0xC575E0")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xC576AC", Offset = "0xC576AC", VA = "0xC576AC")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0xC57718", Offset = "0xC57718", VA = "0xC57718")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0xC577C4", Offset = "0xC577C4", VA = "0xC577C4")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0xC57A3C", Offset = "0xC57A3C", VA = "0xC57A3C")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0xC57A68", Offset = "0xC57A68", VA = "0xC57A68")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0xC57A94", Offset = "0xC57A94", VA = "0xC57A94")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xC57ABC", Offset = "0xC57ABC", VA = "0xC57ABC")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0xC57B7C", Offset = "0xC57B7C", VA = "0xC57B7C")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0xC57D00", Offset = "0xC57D00", VA = "0xC57D00")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0xC57D24", Offset = "0xC57D24", VA = "0xC57D24")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0xC57E44", Offset = "0xC57E44", VA = "0xC57E44")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0xC57EA8", Offset = "0xC57EA8", VA = "0xC57EA8")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0xC58028", Offset = "0xC58028", VA = "0xC58028")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0xC581A8", Offset = "0xC581A8", VA = "0xC581A8")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0xC58224", Offset = "0xC58224", VA = "0xC58224")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0xC57BF0", Offset = "0xC57BF0", VA = "0xC57BF0")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0xC58340", Offset = "0xC58340", VA = "0xC58340")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xC5718C", Offset = "0xC5718C", VA = "0xC5718C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xC57194", Offset = "0xC57194", VA = "0xC57194", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xC57198", Offset = "0xC57198", VA = "0xC57198")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xC572E0", Offset = "0xC572E0", VA = "0xC572E0")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xC573F4", Offset = "0xC573F4", VA = "0xC573F4")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C0")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xC5835C", Offset = "0xC5835C", VA = "0xC5835C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xC58404", Offset = "0xC58404", VA = "0xC58404")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xC58494", Offset = "0xC58494", VA = "0xC58494")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xC58540", Offset = "0xC58540", VA = "0xC58540")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xC58558", Offset = "0xC58558", VA = "0xC58558")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xC58574", Offset = "0xC58574", VA = "0xC58574", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xC5861C", Offset = "0xC5861C", VA = "0xC5861C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xC58634", Offset = "0xC58634", VA = "0xC58634")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C1")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000C2")]
		public enum BoneMapType
		{
			[Token(Token = "0x40004E0")]
			Parent,
			[Token(Token = "0x40004E1")]
			Bone1,
			[Token(Token = "0x40004E2")]
			Bone2,
			[Token(Token = "0x40004E3")]
			Bone3
		}

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xC58658", Offset = "0xC58658", VA = "0xC58658", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xC586CC", Offset = "0xC586CC", VA = "0xC586CC")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xC58794", Offset = "0xC58794", VA = "0xC58794")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xC58A4C", Offset = "0xC58A4C", VA = "0xC58A4C")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xC58B98", Offset = "0xC58B98", VA = "0xC58B98")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xC58D1C", Offset = "0xC58D1C", VA = "0xC58D1C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xC58D7C", Offset = "0xC58D7C", VA = "0xC58D7C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xC58E14", Offset = "0xC58E14", VA = "0xC58E14")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xC58EBC", Offset = "0xC58EBC", VA = "0xC58EBC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xC59170", Offset = "0xC59170", VA = "0xC59170")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xC591D0", Offset = "0xC591D0", VA = "0xC591D0")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C3")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 3f)]
		public int iterations;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float twistWeight;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xC59314", Offset = "0xC59314", VA = "0xC59314", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xC59640", Offset = "0xC59640", VA = "0xC59640")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xC597B8", Offset = "0xC597B8", VA = "0xC597B8")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xC59970", Offset = "0xC59970", VA = "0xC59970")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xC599E4", Offset = "0xC599E4", VA = "0xC599E4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xC59A40", Offset = "0xC59A40", VA = "0xC59A40")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xC59AB8", Offset = "0xC59AB8", VA = "0xC59AB8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xC5A130", Offset = "0xC5A130", VA = "0xC5A130")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xC5A168", Offset = "0xC5A168", VA = "0xC5A168")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xC5A3CC", Offset = "0xC5A3CC", VA = "0xC5A3CC")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xC5A6EC", Offset = "0xC5A6EC", VA = "0xC5A6EC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xC5A7CC", Offset = "0xC5A7CC", VA = "0xC5A7CC")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xC5A880", Offset = "0xC5A880", VA = "0xC5A880")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C4")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000C5")]
		public class Point
		{
			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000521")]
			[Address(RVA = "0xC5B154", Offset = "0xC5B154", VA = "0xC5B154")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000522")]
			[Address(RVA = "0xC5B198", Offset = "0xC5B198", VA = "0xC5B198")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000523")]
			[Address(RVA = "0xC5B278", Offset = "0xC5B278", VA = "0xC5B278")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0xC5B2A4", Offset = "0xC5B2A4", VA = "0xC5B2A4")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000525")]
			[Address(RVA = "0xC5B2D0", Offset = "0xC5B2D0", VA = "0xC5B2D0")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0xC5B314", Offset = "0xC5B314", VA = "0xC5B314")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000527")]
			[Address(RVA = "0xC5B358", Offset = "0xC5B358", VA = "0xC5B358")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C6")]
		public class Bone : Point
		{
			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x170000B4")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000528")]
				[Address(RVA = "0xC5B3B8", Offset = "0xC5B3B8", VA = "0xC5B3B8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000529")]
				[Address(RVA = "0xC5B4A8", Offset = "0xC5B4A8", VA = "0xC5B4A8")]
				set
				{
				}
			}

			[Token(Token = "0x600052A")]
			[Address(RVA = "0xC5B52C", Offset = "0xC5B52C", VA = "0xC5B52C")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600052B")]
			[Address(RVA = "0xC5B798", Offset = "0xC5B798", VA = "0xC5B798")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600052C")]
			[Address(RVA = "0xC5BA54", Offset = "0xC5BA54", VA = "0xC5BA54")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600052D")]
			[Address(RVA = "0xC5BC48", Offset = "0xC5BC48", VA = "0xC5BC48")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600052E")]
			[Address(RVA = "0xC5BC70", Offset = "0xC5BC70", VA = "0xC5BC70")]
			public Bone()
			{
			}

			[Token(Token = "0x600052F")]
			[Address(RVA = "0xC5BCDC", Offset = "0xC5BCDC", VA = "0xC5BCDC")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000530")]
			[Address(RVA = "0xC5BD5C", Offset = "0xC5BD5C", VA = "0xC5BD5C")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C7")]
		public class Node : Point
		{
			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000531")]
			[Address(RVA = "0xC5BDF0", Offset = "0xC5BDF0", VA = "0xC5BDF0")]
			public Node()
			{
			}

			[Token(Token = "0x6000532")]
			[Address(RVA = "0xC51E20", Offset = "0xC51E20", VA = "0xC51E20")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0xC5BDF4", Offset = "0xC5BDF4", VA = "0xC5BDF4")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000C8")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000C9")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The positional or the master weight of the solver.")]
		[Range(0f, 1f)]
		public float IKPositionWeight;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		protected Transform root;

		[Token(Token = "0x170000B3")]
		public bool initiated
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0xC5AD60", Offset = "0xC5AD60", VA = "0xC5AD60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000515")]
			[Address(RVA = "0xC5AD68", Offset = "0xC5AD68", VA = "0xC5AD68")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xC5AABC", Offset = "0xC5AABC", VA = "0xC5AABC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600050C")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xC5AB30", Offset = "0xC5AB30", VA = "0xC5AB30")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xC5ACAC", Offset = "0xC5ACAC", VA = "0xC5ACAC")]
		public void Update()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xC5AD1C", Offset = "0xC5AD1C", VA = "0xC5AD1C", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xC5AD28", Offset = "0xC5AD28", VA = "0xC5AD28")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xC5AD34", Offset = "0xC5AD34", VA = "0xC5AD34")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xC5AD3C", Offset = "0xC5AD3C", VA = "0xC5AD3C")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xC5AD58", Offset = "0xC5AD58", VA = "0xC5AD58")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000517")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000518")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000519")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x600051A")]
		protected abstract void OnInitiate();

		[Token(Token = "0x600051B")]
		protected abstract void OnUpdate();

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xC5AD74", Offset = "0xC5AD74", VA = "0xC5AD74")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xC5AD8C", Offset = "0xC5AD8C", VA = "0xC5AD8C")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xC5AEB0", Offset = "0xC5AEB0", VA = "0xC5AEB0")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xC5AF48", Offset = "0xC5AF48", VA = "0xC5AF48")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xC5B13C", Offset = "0xC5B13C", VA = "0xC5B13C")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CA")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x170000B5")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0xC5C1F0", Offset = "0xC5C1F0", VA = "0xC5C1F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B6")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0xC5C220", Offset = "0xC5C220", VA = "0xC5C220")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B7")]
		protected override int minBones
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0xC5CE70", Offset = "0xC5CE70", VA = "0xC5CE70", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B8")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0xC5D3B0", Offset = "0xC5D3B0", VA = "0xC5D3B0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xC5C0B8", Offset = "0xC5C0B8", VA = "0xC5C0B8")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xC5C250", Offset = "0xC5C250", VA = "0xC5C250", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xC5C4DC", Offset = "0xC5C4DC", VA = "0xC5C4DC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xC5CDC8", Offset = "0xC5CDC8", VA = "0xC5CDC8")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xC5CA64", Offset = "0xC5CA64", VA = "0xC5CA64")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xC5CE78", Offset = "0xC5CE78", VA = "0xC5CE78")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xC5D410", Offset = "0xC5D410", VA = "0xC5D410")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CB")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xC5D4B4", Offset = "0xC5D4B4", VA = "0xC5D4B4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xC5D858", Offset = "0xC5D858", VA = "0xC5D858")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xC5D908", Offset = "0xC5D908", VA = "0xC5D908", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xC5DA88", Offset = "0xC5DA88", VA = "0xC5DA88", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xC5DBE8", Offset = "0xC5DBE8", VA = "0xC5DBE8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xC5DC28", Offset = "0xC5DC28", VA = "0xC5DC28", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xC5DC78", Offset = "0xC5DC78", VA = "0xC5DC78", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xC5DFD8", Offset = "0xC5DFD8", VA = "0xC5DFD8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xC5DFF8", Offset = "0xC5DFF8", VA = "0xC5DFF8")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xC5DCD0", Offset = "0xC5DCD0", VA = "0xC5DCD0")]
		private void Read()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xC5E058", Offset = "0xC5E058", VA = "0xC5E058")]
		private void Write()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xC5E1D0", Offset = "0xC5E1D0", VA = "0xC5E1D0")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CC")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xC5E3C4", Offset = "0xC5E3C4", VA = "0xC5E3C4")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xC5E434", Offset = "0xC5E434", VA = "0xC5E434", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xC5E4A4", Offset = "0xC5E4A4", VA = "0xC5E4A4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xC5E758", Offset = "0xC5E758", VA = "0xC5E758")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xC5EDE8", Offset = "0xC5EDE8", VA = "0xC5EDE8")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CD")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x170000B9")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0xC5FDAC", Offset = "0xC5FDAC", VA = "0xC5FDAC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xC5EDF0", Offset = "0xC5EDF0", VA = "0xC5EDF0")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xC5F3D0", Offset = "0xC5F3D0", VA = "0xC5F3D0")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xC5F500", Offset = "0xC5F500", VA = "0xC5F500", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xC5F588", Offset = "0xC5F588", VA = "0xC5F588", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xC5FAA0", Offset = "0xC5FAA0", VA = "0xC5FAA0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xC5FDB4", Offset = "0xC5FDB4", VA = "0xC5FDB4")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xC5EEC8", Offset = "0xC5EEC8", VA = "0xC5EEC8")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xC5F4B8", Offset = "0xC5F4B8", VA = "0xC5F4B8")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xC5FD64", Offset = "0xC5FD64", VA = "0xC5FD64")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xC5F264", Offset = "0xC5F264", VA = "0xC5F264")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xC60460", Offset = "0xC60460", VA = "0xC60460")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xC604C8", Offset = "0xC604C8", VA = "0xC604C8")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xC60598", Offset = "0xC60598", VA = "0xC60598")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xC60660", Offset = "0xC60660", VA = "0xC60660")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xC5F818", Offset = "0xC5F818", VA = "0xC5F818")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xC5F95C", Offset = "0xC5F95C", VA = "0xC5F95C")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xC60750", Offset = "0xC60750", VA = "0xC60750")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xC60050", Offset = "0xC60050", VA = "0xC60050")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xC5F4A8", Offset = "0xC5F4A8", VA = "0xC5F4A8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xC60DC0", Offset = "0xC60DC0", VA = "0xC60DC0")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xC60910", Offset = "0xC60910", VA = "0xC60910")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xC5FED0", Offset = "0xC5FED0", VA = "0xC5FED0")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xC5FFA0", Offset = "0xC5FFA0", VA = "0xC5FFA0")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xC60E78", Offset = "0xC60E78", VA = "0xC60E78")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CE")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float rootPin;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xC60F14", Offset = "0xC60F14", VA = "0xC60F14", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xC615D8", Offset = "0xC615D8", VA = "0xC615D8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xC61664", Offset = "0xC61664", VA = "0xC61664", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xC616F8", Offset = "0xC616F8", VA = "0xC616F8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xC617F0", Offset = "0xC617F0", VA = "0xC617F0")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xC61880", Offset = "0xC61880", VA = "0xC61880", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xC61C80", Offset = "0xC61C80", VA = "0xC61C80", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xC61E78", Offset = "0xC61E78", VA = "0xC61E78", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xC61D20", Offset = "0xC61D20", VA = "0xC61D20")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xC61A58", Offset = "0xC61A58", VA = "0xC61A58")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xC61EFC", Offset = "0xC61EFC", VA = "0xC61EFC")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CF")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xC61F78", Offset = "0xC61F78", VA = "0xC61F78")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xC62054", Offset = "0xC62054", VA = "0xC62054")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xC54AE8", Offset = "0xC54AE8", VA = "0xC54AE8")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xC55734", Offset = "0xC55734", VA = "0xC55734")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xC54E70", Offset = "0xC54E70", VA = "0xC54E70")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xC6209C", Offset = "0xC6209C", VA = "0xC6209C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xC6223C", Offset = "0xC6223C", VA = "0xC6223C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xC62398", Offset = "0xC62398", VA = "0xC62398", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xC62594", Offset = "0xC62594", VA = "0xC62594", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xC62664", Offset = "0xC62664", VA = "0xC62664", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xC62740", Offset = "0xC62740", VA = "0xC62740", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xC62898", Offset = "0xC62898", VA = "0xC62898", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xC62A30", Offset = "0xC62A30", VA = "0xC62A30", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xC62C54", Offset = "0xC62C54", VA = "0xC62C54", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xC62F10", Offset = "0xC62F10", VA = "0xC62F10", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xC62F44", Offset = "0xC62F44", VA = "0xC62F44", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xC6301C", Offset = "0xC6301C", VA = "0xC6301C")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D0")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x400053C")]
		Body,
		[Token(Token = "0x400053D")]
		LeftShoulder,
		[Token(Token = "0x400053E")]
		RightShoulder,
		[Token(Token = "0x400053F")]
		LeftThigh,
		[Token(Token = "0x4000540")]
		RightThigh,
		[Token(Token = "0x4000541")]
		LeftHand,
		[Token(Token = "0x4000542")]
		RightHand,
		[Token(Token = "0x4000543")]
		LeftFoot,
		[Token(Token = "0x4000544")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x20000D1")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000546")]
		LeftArm,
		[Token(Token = "0x4000547")]
		RightArm,
		[Token(Token = "0x4000548")]
		LeftLeg,
		[Token(Token = "0x4000549")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x20000D2")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Range(0f, 1f)]
		public float spineStiffness;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x170000BA")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0xC63170", Offset = "0xC63170", VA = "0xC63170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0xC632B0", Offset = "0xC632B0", VA = "0xC632B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0xC632B8", Offset = "0xC632B8", VA = "0xC632B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0xC632C0", Offset = "0xC632C0", VA = "0xC632C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0xC632C8", Offset = "0xC632C8", VA = "0xC632C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0xC632D0", Offset = "0xC632D0", VA = "0xC632D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0xC632D8", Offset = "0xC632D8", VA = "0xC632D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0xC632E0", Offset = "0xC632E0", VA = "0xC632E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0xC632E8", Offset = "0xC632E8", VA = "0xC632E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0xC632F0", Offset = "0xC632F0", VA = "0xC632F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0xC6331C", Offset = "0xC6331C", VA = "0xC6331C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0xC63348", Offset = "0xC63348", VA = "0xC63348")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0xC63374", Offset = "0xC63374", VA = "0xC63374")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0xC633A0", Offset = "0xC633A0", VA = "0xC633A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C8")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0xC633C8", Offset = "0xC633C8", VA = "0xC633C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0xC633F4", Offset = "0xC633F4", VA = "0xC633F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CA")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0xC63420", Offset = "0xC63420", VA = "0xC63420")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CB")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0xC6344C", Offset = "0xC6344C", VA = "0xC6344C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0xC6568C", Offset = "0xC6568C", VA = "0xC6568C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0xC65698", Offset = "0xC65698", VA = "0xC65698")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xC63474", Offset = "0xC63474", VA = "0xC63474")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xC63574", Offset = "0xC63574", VA = "0xC63574")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xC634C4", Offset = "0xC634C4", VA = "0xC634C4")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xC635EC", Offset = "0xC635EC", VA = "0xC635EC")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xC63178", Offset = "0xC63178", VA = "0xC63178")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xC636B4", Offset = "0xC636B4", VA = "0xC636B4")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xC63764", Offset = "0xC63764", VA = "0xC63764")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xC63810", Offset = "0xC63810", VA = "0xC63810")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xC638BC", Offset = "0xC638BC", VA = "0xC638BC")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xC638C4", Offset = "0xC638C4", VA = "0xC638C4")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xC638EC", Offset = "0xC638EC", VA = "0xC638EC")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xC639AC", Offset = "0xC639AC", VA = "0xC639AC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xC63B44", Offset = "0xC63B44", VA = "0xC63B44")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xC64F84", Offset = "0xC64F84", VA = "0xC64F84")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xC65534", Offset = "0xC65534", VA = "0xC65534")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xC65590", Offset = "0xC65590", VA = "0xC65590")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xC653D4", Offset = "0xC653D4", VA = "0xC653D4")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xC65484", Offset = "0xC65484", VA = "0xC65484")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xC656A4", Offset = "0xC656A4", VA = "0xC656A4")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xC65768", Offset = "0xC65768", VA = "0xC65768", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xC6583C", Offset = "0xC6583C", VA = "0xC6583C")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xC65958", Offset = "0xC65958", VA = "0xC65958")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xC65AE8", Offset = "0xC65AE8", VA = "0xC65AE8")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xC65C60", Offset = "0xC65C60", VA = "0xC65C60", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xC65EC4", Offset = "0xC65EC4", VA = "0xC65EC4", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xC65F40", Offset = "0xC65F40", VA = "0xC65F40")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D3")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x170000CD")]
		protected virtual int minBones
		{
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0xC667E4", Offset = "0xC667E4", VA = "0xC667E4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CE")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xC667EC", Offset = "0xC667EC", VA = "0xC667EC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xC667F4", Offset = "0xC667F4", VA = "0xC667F4", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D0")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xC66C98", Offset = "0xC66C98", VA = "0xC66C98", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D1")]
		protected float positionOffset
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0xC66D54", Offset = "0xC66D54", VA = "0xC66D54")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xC65F50", Offset = "0xC65F50", VA = "0xC65F50")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xC66100", Offset = "0xC66100", VA = "0xC66100")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xC6624C", Offset = "0xC6624C", VA = "0xC6624C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xC662AC", Offset = "0xC662AC", VA = "0xC662AC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xC66320", Offset = "0xC66320", VA = "0xC66320", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xC66700", Offset = "0xC66700", VA = "0xC66700", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xC66708", Offset = "0xC66708", VA = "0xC66708", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xC667FC", Offset = "0xC667FC", VA = "0xC667FC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xC66800", Offset = "0xC66800", VA = "0xC66800", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xC66804", Offset = "0xC66804", VA = "0xC66804")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xC66D9C", Offset = "0xC66D9C", VA = "0xC66D9C")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xC67154", Offset = "0xC67154", VA = "0xC67154")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xC673E8", Offset = "0xC673E8", VA = "0xC673E8")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D4")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xC6745C", Offset = "0xC6745C", VA = "0xC6745C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xC67800", Offset = "0xC67800", VA = "0xC67800")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xC678B4", Offset = "0xC678B4", VA = "0xC678B4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xC67A34", Offset = "0xC67A34", VA = "0xC67A34", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xC67B94", Offset = "0xC67B94", VA = "0xC67B94", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xC67BE4", Offset = "0xC67BE4", VA = "0xC67BE4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xC67C44", Offset = "0xC67C44", VA = "0xC67C44", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xC67FA0", Offset = "0xC67FA0", VA = "0xC67FA0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xC67FC0", Offset = "0xC67FC0", VA = "0xC67FC0")]
		private void Solve()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xC67C9C", Offset = "0xC67C9C", VA = "0xC67C9C")]
		private void Read()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xC68048", Offset = "0xC68048", VA = "0xC68048")]
		private void Write()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xC68280", Offset = "0xC68280", VA = "0xC68280")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D5")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000D6")]
		public enum BendModifier
		{
			[Token(Token = "0x4000574")]
			Animation,
			[Token(Token = "0x4000575")]
			Target,
			[Token(Token = "0x4000576")]
			Parent,
			[Token(Token = "0x4000577")]
			Arm,
			[Token(Token = "0x4000578")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000D7")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0xC698B8", Offset = "0xC698B8", VA = "0xC698B8")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float bendModifierWeight;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x170000D2")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0xC6989C", Offset = "0xC6989C", VA = "0xC6989C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xC68478", Offset = "0xC68478", VA = "0xC68478")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xC684BC", Offset = "0xC684BC", VA = "0xC684BC")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xC68528", Offset = "0xC68528", VA = "0xC68528", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xC68A70", Offset = "0xC68A70", VA = "0xC68A70", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xC6958C", Offset = "0xC6958C", VA = "0xC6958C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xC69634", Offset = "0xC69634", VA = "0xC69634")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xC69804", Offset = "0xC69804", VA = "0xC69804")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xC68884", Offset = "0xC68884", VA = "0xC68884")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xC68B2C", Offset = "0xC68B2C", VA = "0xC68B2C")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000D8")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000D9")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x170000D9")]
			public Vector3 forward
			{
				[Token(Token = "0x6000602")]
				[Address(RVA = "0xC6B74C", Offset = "0xC6B74C", VA = "0xC6B74C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xC6BDFC", Offset = "0xC6BDFC", VA = "0xC6BDFC")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0xC6A868", Offset = "0xC6A868", VA = "0xC6A868")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0xC6AB5C", Offset = "0xC6AB5C", VA = "0xC6AB5C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0xC6BA94", Offset = "0xC6BA94", VA = "0xC6BA94")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float headWeight;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float eyesWeight;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x170000D3")]
		protected bool spineIsValid
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0xC69FEC", Offset = "0xC69FEC", VA = "0xC69FEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D4")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xC6A194", Offset = "0xC6A194", VA = "0xC6A194")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D5")]
		protected bool headIsValid
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xC6A0B8", Offset = "0xC6A0B8", VA = "0xC6A0B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D6")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0xC6A1B8", Offset = "0xC6A1B8", VA = "0xC6A1B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D7")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0xC6A0C8", Offset = "0xC6A0C8", VA = "0xC6A0C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D8")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0xC6A224", Offset = "0xC6A224", VA = "0xC6A224")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xC69A54", Offset = "0xC69A54", VA = "0xC69A54")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xC69A70", Offset = "0xC69A70", VA = "0xC69A70")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xC69A9C", Offset = "0xC69A9C", VA = "0xC69A9C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xC69AD4", Offset = "0xC69AD4", VA = "0xC69AD4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xC69B1C", Offset = "0xC69B1C", VA = "0xC69B1C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xC69B74", Offset = "0xC69B74", VA = "0xC69B74")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xC69BE4", Offset = "0xC69BE4", VA = "0xC69BE4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xC69CFC", Offset = "0xC69CFC", VA = "0xC69CFC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xC69E28", Offset = "0xC69E28", VA = "0xC69E28", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xC6A248", Offset = "0xC6A248", VA = "0xC6A248", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xC6A49C", Offset = "0xC6A49C", VA = "0xC6A49C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xC6A5FC", Offset = "0xC6A5FC", VA = "0xC6A5FC")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xC6A898", Offset = "0xC6A898", VA = "0xC6A898", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xC6AC48", Offset = "0xC6AC48", VA = "0xC6AC48", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xC6AD0C", Offset = "0xC6AD0C", VA = "0xC6AD0C")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xC6AF28", Offset = "0xC6AF28", VA = "0xC6AF28")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xC6B270", Offset = "0xC6B270", VA = "0xC6B270")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xC6B77C", Offset = "0xC6B77C", VA = "0xC6B77C")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xC6A6C4", Offset = "0xC6A6C4", VA = "0xC6A6C4")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xC6BB9C", Offset = "0xC6BB9C", VA = "0xC6BB9C")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000DA")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000DB")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x600061A")]
			[Address(RVA = "0xC6D124", Offset = "0xC6D124", VA = "0xC6D124")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0xC6D9CC", Offset = "0xC6D9CC", VA = "0xC6D9CC")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600061C")]
			[Address(RVA = "0xC684F8", Offset = "0xC684F8", VA = "0xC684F8")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0xC6DA68", Offset = "0xC6DA68", VA = "0xC6DA68")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xC6BE04", Offset = "0xC6BE04", VA = "0xC6BE04")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xC6BF98", Offset = "0xC6BF98", VA = "0xC6BF98")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xC6C118", Offset = "0xC6C118", VA = "0xC6C118")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xC6C124", Offset = "0xC6C124", VA = "0xC6C124")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xC6C140", Offset = "0xC6C140", VA = "0xC6C140")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xC6C14C", Offset = "0xC6C14C", VA = "0xC6C14C")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xC6C154", Offset = "0xC6C154", VA = "0xC6C154", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xC6C264", Offset = "0xC6C264", VA = "0xC6C264", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xC6C35C", Offset = "0xC6C35C", VA = "0xC6C35C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xC6C39C", Offset = "0xC6C39C", VA = "0xC6C39C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xC6C3EC", Offset = "0xC6C3EC", VA = "0xC6C3EC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xC6C7C0", Offset = "0xC6C7C0", VA = "0xC6C7C0")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xC6C83C", Offset = "0xC6C83C", VA = "0xC6C83C")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xC6CD30", Offset = "0xC6CD30", VA = "0xC6CD30")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xC6CE88", Offset = "0xC6CE88", VA = "0xC6CE88", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xC6D034", Offset = "0xC6D034", VA = "0xC6D034")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xC6CFB4", Offset = "0xC6CFB4", VA = "0xC6CFB4")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xC6D214", Offset = "0xC6D214", VA = "0xC6D214", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xC6DA5C", Offset = "0xC6DA5C", VA = "0xC6DA5C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xC6DA60", Offset = "0xC6DA60", VA = "0xC6DA60", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xC6DA64", Offset = "0xC6DA64", VA = "0xC6DA64", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xC6D80C", Offset = "0xC6D80C", VA = "0xC6D80C")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xC696B8", Offset = "0xC696B8", VA = "0xC696B8")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000DC")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000DD")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20000DE")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x40005DA")]
				YawPitch,
				[Token(Token = "0x40005DB")]
				FromTo
			}

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The hand target. This should not be the hand controller itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the hand bone. The best practice for setup would be to move the hand controller to the avatar's hand as it it was held by the avatar, duplicate the avatar's hand bone and parent it to the hand controller. Then assign the duplicate to this slot.")]
			public Transform target;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the hand target. Note that if you have nulled the target, the hand will still be pulled to the last position of the target until you set this value to 0.")]
			public float positionWeight;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the hand target. Note that if you have nulled the target, the hand will still be rotated to the last rotation of the target until you set this value to 0.")]
			public float rotationWeight;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("The weight of shoulder rotation")]
			[Range(0f, 1f)]
			public float shoulderRotationWeight;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("The weight of twisting the shoulders backwards when arms are lifted up.")]
			[Range(0f, 1f)]
			public float shoulderTwistWeight;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset of the elbow bending direction.")]
			public float swivelOffset;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Use this to make the arm shorter/longer. Works by displacement of hand and forearm localPosition.")]
			[Range(0.01f, 2f)]
			public float armLengthMlp;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Evaluates stretching of the arm by target distance relative to arm length. Value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x40005D7")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x40005D8")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000DB")]
			public Vector3 position
			{
				[Token(Token = "0x600063C")]
				[Address(RVA = "0xC7383C", Offset = "0xC7383C", VA = "0xC7383C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600063D")]
				[Address(RVA = "0xC73848", Offset = "0xC73848", VA = "0xC73848")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000DC")]
			public Quaternion rotation
			{
				[Token(Token = "0x600063E")]
				[Address(RVA = "0xC73854", Offset = "0xC73854", VA = "0xC73854")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600063F")]
				[Address(RVA = "0xC73860", Offset = "0xC73860", VA = "0xC73860")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000DD")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000640")]
				[Address(RVA = "0xC7386C", Offset = "0xC7386C", VA = "0xC7386C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DE")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000641")]
				[Address(RVA = "0xC73894", Offset = "0xC73894", VA = "0xC73894")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000642")]
				[Address(RVA = "0xC738C8", Offset = "0xC738C8", VA = "0xC738C8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E0")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000643")]
				[Address(RVA = "0xC73908", Offset = "0xC73908", VA = "0xC73908")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0xC73948", Offset = "0xC73948", VA = "0xC73948", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0xC741E8", Offset = "0xC741E8", VA = "0xC741E8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0xC74494", Offset = "0xC74494", VA = "0xC74494", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0xC744B8", Offset = "0xC744B8", VA = "0xC744B8")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0xC716D8", Offset = "0xC716D8", VA = "0xC716D8")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0xC74EEC", Offset = "0xC74EEC", VA = "0xC74EEC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0xC74F44", Offset = "0xC74F44", VA = "0xC74F44", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0xC74808", Offset = "0xC74808", VA = "0xC74808")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600064C")]
			[Address(RVA = "0xC74888", Offset = "0xC74888", VA = "0xC74888")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0xC75150", Offset = "0xC75150", VA = "0xC75150")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0xC736A4", Offset = "0xC736A4", VA = "0xC736A4")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DF")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x170000E1")]
			public float sqrMag
			{
				[Token(Token = "0x6000654")]
				[Address(RVA = "0xC7530C", Offset = "0xC7530C", VA = "0xC7530C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000655")]
				[Address(RVA = "0xC75314", Offset = "0xC75314", VA = "0xC75314")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E2")]
			public float mag
			{
				[Token(Token = "0x6000656")]
				[Address(RVA = "0xC7531C", Offset = "0xC7531C", VA = "0xC7531C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000657")]
				[Address(RVA = "0xC75324", Offset = "0xC75324", VA = "0xC75324")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600064F")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000650")]
			public abstract void PreSolve();

			[Token(Token = "0x6000651")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000652")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x6000653")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000658")]
			[Address(RVA = "0xC7532C", Offset = "0xC7532C", VA = "0xC7532C")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0xC681C0", Offset = "0xC681C0", VA = "0xC681C0")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0xC75334", Offset = "0xC75334", VA = "0xC75334")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0xC753BC", Offset = "0xC753BC", VA = "0xC753BC")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0xC75454", Offset = "0xC75454", VA = "0xC75454")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0xC715B0", Offset = "0xC715B0", VA = "0xC715B0")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0xC74D84", Offset = "0xC74D84", VA = "0xC74D84")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0xC7549C", Offset = "0xC7549C", VA = "0xC7549C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0xC755C0", Offset = "0xC755C0", VA = "0xC755C0")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0xC75268", Offset = "0xC75268", VA = "0xC75268")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E0")]
		public class Footstep
		{
			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000E3")]
			public bool isStepping
			{
				[Token(Token = "0x6000662")]
				[Address(RVA = "0xC755D4", Offset = "0xC755D4", VA = "0xC755D4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E4")]
			public float stepProgress
			{
				[Token(Token = "0x6000663")]
				[Address(RVA = "0xC755E8", Offset = "0xC755E8", VA = "0xC755E8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000664")]
				[Address(RVA = "0xC755F0", Offset = "0xC755F0", VA = "0xC755F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0xC755F8", Offset = "0xC755F8", VA = "0xC755F8")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0xC757BC", Offset = "0xC757BC", VA = "0xC757BC")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0xC75804", Offset = "0xC75804", VA = "0xC75804")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0xC75A28", Offset = "0xC75A28", VA = "0xC75A28")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0xC75C30", Offset = "0xC75C30", VA = "0xC75C30")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0xC75E14", Offset = "0xC75E14", VA = "0xC75E14")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E1")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The foot/toe target. This should not be the foot tracker itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the foot/toe bone. If a toe bone is assigned in the References, the solver will match the toe bone to this target. If no toe bone assigned, foot bone will be used instead.")]
			public Transform target;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the toe/foot target. Note that if you have nulled the target, the foot will still be pulled to the last position of the target until you set this value to 0.")]
			public float positionWeight;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the toe/foot target. Note that if you have nulled the target, the foot will still be rotated to the last rotation of the target until you set this value to 0.")]
			public float rotationWeight;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset of knee bending direction.")]
			public float swivelOffset;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			[Range(0f, 1f)]
			public float bendToTargetWeight;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Range(0.01f, 2f)]
			[Tooltip("Use this to make the leg shorter/longer. Works by displacement of foot and calf localPosition.")]
			public float legLengthMlp;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x170000E5")]
			public Vector3 position
			{
				[Token(Token = "0x600066B")]
				[Address(RVA = "0xC75F88", Offset = "0xC75F88", VA = "0xC75F88")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600066C")]
				[Address(RVA = "0xC75F94", Offset = "0xC75F94", VA = "0xC75F94")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E6")]
			public Quaternion rotation
			{
				[Token(Token = "0x600066D")]
				[Address(RVA = "0xC75FA0", Offset = "0xC75FA0", VA = "0xC75FA0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600066E")]
				[Address(RVA = "0xC75FAC", Offset = "0xC75FAC", VA = "0xC75FAC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E7")]
			public bool hasToes
			{
				[Token(Token = "0x600066F")]
				[Address(RVA = "0xC75FB8", Offset = "0xC75FB8", VA = "0xC75FB8")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000670")]
				[Address(RVA = "0xC75FC0", Offset = "0xC75FC0", VA = "0xC75FC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E8")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000671")]
				[Address(RVA = "0xC75FCC", Offset = "0xC75FCC", VA = "0xC75FCC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E9")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000672")]
				[Address(RVA = "0xC75FF4", Offset = "0xC75FF4", VA = "0xC75FF4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EA")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000673")]
				[Address(RVA = "0xC76020", Offset = "0xC76020", VA = "0xC76020")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EB")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000674")]
				[Address(RVA = "0xC7604C", Offset = "0xC7604C", VA = "0xC7604C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EC")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000675")]
				[Address(RVA = "0xC76078", Offset = "0xC76078", VA = "0xC76078")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000ED")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000676")]
				[Address(RVA = "0xC760AC", Offset = "0xC760AC", VA = "0xC760AC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000677")]
				[Address(RVA = "0xC760B8", Offset = "0xC760B8", VA = "0xC760B8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0xC760C4", Offset = "0xC760C4", VA = "0xC760C4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0xC766C4", Offset = "0xC766C4", VA = "0xC766C4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0xC76E34", Offset = "0xC76E34", VA = "0xC76E34", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0xC76DE4", Offset = "0xC76DE4", VA = "0xC76DE4")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0xC76B98", Offset = "0xC76B98", VA = "0xC76B98")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0xC77310", Offset = "0xC77310", VA = "0xC77310")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0xC77C74", Offset = "0xC77C74", VA = "0xC77C74")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0xC774B4", Offset = "0xC774B4", VA = "0xC774B4")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0xC780CC", Offset = "0xC780CC", VA = "0xC780CC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0xC782D4", Offset = "0xC782D4", VA = "0xC782D4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0xC783B4", Offset = "0xC783B4", VA = "0xC783B4")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E2")]
		public class Locomotion
		{
			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			[Range(0.9f, 1f)]
			public float maxLegStretch;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The speed of moving a foot to the next position.")]
			public float stepSpeed;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Range(0f, 180f)]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000EE")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000683")]
				[Address(RVA = "0xC784A0", Offset = "0xC784A0", VA = "0xC784A0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000684")]
				[Address(RVA = "0xC784AC", Offset = "0xC784AC", VA = "0xC784AC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000EF")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x600068A")]
				[Address(RVA = "0xC7A610", Offset = "0xC7A610", VA = "0xC7A610")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000F0")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x600068B")]
				[Address(RVA = "0xC7A644", Offset = "0xC7A644", VA = "0xC7A644")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000F1")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x600068C")]
				[Address(RVA = "0xC7A67C", Offset = "0xC7A67C", VA = "0xC7A67C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000F2")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x600068D")]
				[Address(RVA = "0xC7A6B0", Offset = "0xC7A6B0", VA = "0xC7A6B0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0xC784B8", Offset = "0xC784B8", VA = "0xC784B8")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000686")]
			[Address(RVA = "0xC787CC", Offset = "0xC787CC", VA = "0xC787CC")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000687")]
			[Address(RVA = "0xC789B0", Offset = "0xC789B0", VA = "0xC789B0")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0xC78D78", Offset = "0xC78D78", VA = "0xC78D78")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0xC78E30", Offset = "0xC78E30", VA = "0xC78E30")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0xC7A240", Offset = "0xC7A240", VA = "0xC7A240")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0xC7A3F4", Offset = "0xC7A3F4", VA = "0xC7A3F4")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0xC7A460", Offset = "0xC7A460", VA = "0xC7A460")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0xC7A6E8", Offset = "0xC7A6E8", VA = "0xC7A6E8")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E3")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The head target. This should not be the camera Transform itself, but a child GameObject parented to it so you could adjust it's position/rotation  to match the orientation of the head bone. The best practice for setup would be to move the camera to the avatar's eyes, duplicate the avatar's head bone and parent it to the camera. Then assign the duplicate to this slot.")]
			public Transform headTarget;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The pelvis target (optional), useful for seated rigs or if you had an additional tracker on the backpack or belt are. The best practice for setup would be to duplicate the avatar's pelvis bone and parenting it to the pelvis tracker. Then assign the duplicate to this slot.")]
			public Transform pelvisTarget;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the head target. Note that if you have nulled the headTarget, the head will still be pulled to the last position of the headTarget until you set this value to 0.")]
			public float positionWeight;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the head target. Note that if you have nulled the headTarget, the head will still be rotated to the last rotation of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Positional weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be pulled to the last position of the pelvisTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Rotational weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be rotated to the last rotation of the pelvisTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Range(0f, 1f)]
			[Tooltip("Weight of turning the chest towards the 'Chest Goal'.")]
			public float chestGoalWeight;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Range(0f, 1f)]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			public float bodyRotStiffness;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[Range(0f, 1f)]
			[FormerlySerializedAs("chestRotationWeight")]
			public float neckStiffness;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			[Range(0f, 1f)]
			public float rotateChestByHands;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("Clamps chest rotation. Value of 0.5 allows 90 degrees of rotation for the chest relative to the head. Value of 0 allows 180 degrees and value of 1 means the chest will be locked relative to the head.")]
			[Range(0f, 1f)]
			public float chestClampWeight;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Clamps head rotation. Value of 0.5 allows 90 degrees of rotation for the head relative to the headTarget. Value of 0 allows 180 degrees and value of 1 means head rotation will be locked to the target.")]
			[Range(0f, 1f)]
			public float headClampWeight;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Range(0f, 1f)]
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			public float maintainPelvisPosition;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Range(0f, 180f)]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			public float maxRootAngle;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset for root heading. Adjust this value to turn the root relative to the HMD around the vertical axis. Usefulf for fighting or shooting games where you would sometimes want the avatar to stand at an angled stance.")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x170000F3")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000692")]
				[Address(RVA = "0xC7A1D8", Offset = "0xC7A1D8", VA = "0xC7A1D8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F4")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000693")]
				[Address(RVA = "0xC7A7F8", Offset = "0xC7A7F8", VA = "0xC7A7F8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F5")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000694")]
				[Address(RVA = "0xC7A82C", Offset = "0xC7A82C", VA = "0xC7A82C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F6")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000695")]
				[Address(RVA = "0xC7A874", Offset = "0xC7A874", VA = "0xC7A874")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F7")]
			public VirtualBone head
			{
				[Token(Token = "0x6000696")]
				[Address(RVA = "0xC7A20C", Offset = "0xC7A20C", VA = "0xC7A20C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F8")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000697")]
				[Address(RVA = "0xC7A8A8", Offset = "0xC7A8A8", VA = "0xC7A8A8")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000698")]
				[Address(RVA = "0xC7A8BC", Offset = "0xC7A8BC", VA = "0xC7A8BC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000F9")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000699")]
				[Address(RVA = "0xC7A8D0", Offset = "0xC7A8D0", VA = "0xC7A8D0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600069A")]
				[Address(RVA = "0xC7A8E4", Offset = "0xC7A8E4", VA = "0xC7A8E4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0xC7A8F8", Offset = "0xC7A8F8", VA = "0xC7A8F8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0xC7B598", Offset = "0xC7B598", VA = "0xC7B598", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0xC7B780", Offset = "0xC7B780", VA = "0xC7B780", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0xC7BF14", Offset = "0xC7BF14", VA = "0xC7BF14")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0xC7C550", Offset = "0xC7C550", VA = "0xC7C550")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0xC7CE9C", Offset = "0xC7CE9C", VA = "0xC7CE9C")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0xC7D644", Offset = "0xC7D644", VA = "0xC7D644")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xC7DCA0", Offset = "0xC7DCA0", VA = "0xC7DCA0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0xC7DE70", Offset = "0xC7DE70", VA = "0xC7DE70", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0xC7C158", Offset = "0xC7C158", VA = "0xC7C158")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xC7D36C", Offset = "0xC7D36C", VA = "0xC7D36C")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xC7CA8C", Offset = "0xC7CA8C", VA = "0xC7CA8C")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0xC7DF44", Offset = "0xC7DF44", VA = "0xC7DF44")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0xC7D448", Offset = "0xC7D448", VA = "0xC7D448")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0xC7D0FC", Offset = "0xC7D0FC", VA = "0xC7D0FC")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0xC7E350", Offset = "0xC7E350", VA = "0xC7E350")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000661")]
			Pelvis,
			[Token(Token = "0x4000662")]
			Chest,
			[Token(Token = "0x4000663")]
			Head,
			[Token(Token = "0x4000664")]
			LeftHand,
			[Token(Token = "0x4000665")]
			RightHand,
			[Token(Token = "0x4000666")]
			LeftFoot,
			[Token(Token = "0x4000667")]
			RightFoot,
			[Token(Token = "0x4000668")]
			LeftHeel,
			[Token(Token = "0x4000669")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000E5")]
		public enum RotationOffset
		{
			[Token(Token = "0x400066B")]
			Pelvis,
			[Token(Token = "0x400066C")]
			Chest,
			[Token(Token = "0x400066D")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000E6")]
		public class VirtualBone
		{
			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0xC76634", Offset = "0xC76634", VA = "0xC76634")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0xC766A4", Offset = "0xC766A4", VA = "0xC766A4")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0xC7E46C", Offset = "0xC7E46C", VA = "0xC7E46C")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0xC7E66C", Offset = "0xC7E66C", VA = "0xC7E66C")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0xC7E1E0", Offset = "0xC7E1E0", VA = "0xC7E1E0")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0xC7E7CC", Offset = "0xC7E7CC", VA = "0xC7E7CC")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xC7E974", Offset = "0xC7E974", VA = "0xC7E974")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0xC7EAFC", Offset = "0xC7EAFC", VA = "0xC7EAFC")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0xC77890", Offset = "0xC77890", VA = "0xC77890")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0xC7EBA0", Offset = "0xC7EBA0", VA = "0xC7EBA0")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0xC7D8D4", Offset = "0xC7D8D4", VA = "0xC7D8D4")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0xC7ECF8", Offset = "0xC7ECF8", VA = "0xC7ECF8")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xC7EE0C", Offset = "0xC7EE0C", VA = "0xC7EE0C")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
		[Range(0f, 2f)]
		public int LOD;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
		public bool plantFeet;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public Locomotion locomotion;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x170000DA")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0xC733A8", Offset = "0xC733A8", VA = "0xC733A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000638")]
			[Address(RVA = "0xC733B0", Offset = "0xC733B0", VA = "0xC733B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xC6DA70", Offset = "0xC6DA70", VA = "0xC6DA70")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xC6DEDC", Offset = "0xC6DEDC", VA = "0xC6DEDC")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xC6DD70", Offset = "0xC6DD70", VA = "0xC6DD70")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xC6E70C", Offset = "0xC6E70C", VA = "0xC6E70C")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xC6E850", Offset = "0xC6E850", VA = "0xC6E850")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xC6E890", Offset = "0xC6E890", VA = "0xC6E890")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xC6E9B4", Offset = "0xC6E9B4", VA = "0xC6E9B4")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xC6EA90", Offset = "0xC6EA90", VA = "0xC6EA90")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xC6F25C", Offset = "0xC6F25C", VA = "0xC6F25C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xC6F3B0", Offset = "0xC6F3B0", VA = "0xC6F3B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xC6F59C", Offset = "0xC6F59C", VA = "0xC6F59C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xC6F60C", Offset = "0xC6F60C", VA = "0xC6F60C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xC6F67C", Offset = "0xC6F67C", VA = "0xC6F67C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xC6F884", Offset = "0xC6F884", VA = "0xC6F884")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xC6E1CC", Offset = "0xC6E1CC", VA = "0xC6E1CC")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xC6E2B0", Offset = "0xC6E2B0", VA = "0xC6E2B0")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xC6E5F8", Offset = "0xC6E5F8", VA = "0xC6E5F8")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xC6EBA4", Offset = "0xC6EBA4", VA = "0xC6EBA4")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xC6FAF4", Offset = "0xC6FAF4", VA = "0xC6FAF4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xC6FB30", Offset = "0xC6FB30", VA = "0xC6FB30", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xC710E8", Offset = "0xC710E8", VA = "0xC710E8")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xC6ECF4", Offset = "0xC6ECF4", VA = "0xC6ECF4")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xC6FF3C", Offset = "0xC6FF3C", VA = "0xC6FF3C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xC7153C", Offset = "0xC7153C", VA = "0xC7153C")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xC71578", Offset = "0xC71578", VA = "0xC71578")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xC70FAC", Offset = "0xC70FAC", VA = "0xC70FAC")]
		private void Write()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xC72CBC", Offset = "0xC72CBC", VA = "0xC72CBC")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xC733B8", Offset = "0xC733B8", VA = "0xC733B8")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform child;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		public float parentChildCrossfade;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(-180f, 180f)]
		[Tooltip("Rotation offset around the twist axis.")]
		public float twistAngleOffset;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xC7EFC0", Offset = "0xC7EFC0", VA = "0xC7EFC0")]
		public void Relax()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xC7F404", Offset = "0xC7F404", VA = "0xC7F404")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xC7F7F4", Offset = "0xC7F7F4", VA = "0xC7F7F4")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xC7F86C", Offset = "0xC7F86C", VA = "0xC7F86C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xC7F8E4", Offset = "0xC7F8E4", VA = "0xC7F8E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xC7FA1C", Offset = "0xC7FA1C", VA = "0xC7FA1C")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E8")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x170000FA")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0xC7FABC", Offset = "0xC7FABC", VA = "0xC7FABC")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0xC7FAC4", Offset = "0xC7FAC4", VA = "0xC7FAC4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public bool isPaused
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0xC7FACC", Offset = "0xC7FACC", VA = "0xC7FACC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0xC7FAD4", Offset = "0xC7FAD4", VA = "0xC7FAD4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0xC7FAE0", Offset = "0xC7FAE0", VA = "0xC7FAE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0xC7FAE8", Offset = "0xC7FAE8", VA = "0xC7FAE8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public bool inInteraction
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0xC7FAF0", Offset = "0xC7FAF0", VA = "0xC7FAF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FE")]
		public float progress
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0xC82124", Offset = "0xC82124", VA = "0xC82124")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xC7FB50", Offset = "0xC7FB50", VA = "0xC7FB50")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xC7FBEC", Offset = "0xC7FBEC", VA = "0xC7FBEC")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xC7FCAC", Offset = "0xC7FCAC", VA = "0xC7FCAC")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xC7FE18", Offset = "0xC7FE18", VA = "0xC7FE18")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xC801F4", Offset = "0xC801F4", VA = "0xC801F4")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xC80314", Offset = "0xC80314", VA = "0xC80314")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xC80368", Offset = "0xC80368", VA = "0xC80368")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xC80EC8", Offset = "0xC80EC8", VA = "0xC80EC8")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xC8197C", Offset = "0xC8197C", VA = "0xC8197C")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xC81B9C", Offset = "0xC81B9C", VA = "0xC81B9C")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xC81FC0", Offset = "0xC81FC0", VA = "0xC81FC0")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xC82324", Offset = "0xC82324", VA = "0xC82324")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E9")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xC82560", Offset = "0xC82560", VA = "0xC82560")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xC8267C", Offset = "0xC8267C", VA = "0xC8267C")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xC82714", Offset = "0xC82714", VA = "0xC82714")]
		public void Update()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xC8291C", Offset = "0xC8291C", VA = "0xC8291C")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xC829C4", Offset = "0xC829C4", VA = "0xC829C4")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xC82A70", Offset = "0xC82A70", VA = "0xC82A70")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EB")]
		public class InteractionEvent
		{
			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0xC82154", Offset = "0xC82154", VA = "0xC82154")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0xC83A14", Offset = "0xC83A14", VA = "0xC83A14")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EC")]
		public class Message
		{
			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Token(Token = "0x40006BC")]
			private const string empty = "";

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0xC8391C", Offset = "0xC8391C", VA = "0xC8391C")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0xC83A1C", Offset = "0xC83A1C", VA = "0xC83A1C")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000ED")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40006C3")]
			private const string empty = "";

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0xC83840", Offset = "0xC83840", VA = "0xC83840")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0xC83A24", Offset = "0xC83A24", VA = "0xC83A24")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0xC83AD4", Offset = "0xC83AD4", VA = "0xC83AD4")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0xC83BAC", Offset = "0xC83BAC", VA = "0xC83BAC")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EE")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20000EF")]
			public enum Type
			{
				[Token(Token = "0x40006C7")]
				PositionWeight,
				[Token(Token = "0x40006C8")]
				RotationWeight,
				[Token(Token = "0x40006C9")]
				PositionOffsetX,
				[Token(Token = "0x40006CA")]
				PositionOffsetY,
				[Token(Token = "0x40006CB")]
				PositionOffsetZ,
				[Token(Token = "0x40006CC")]
				Pull,
				[Token(Token = "0x40006CD")]
				Reach,
				[Token(Token = "0x40006CE")]
				RotateBoneWeight,
				[Token(Token = "0x40006CF")]
				Push,
				[Token(Token = "0x40006D0")]
				PushParent,
				[Token(Token = "0x40006D1")]
				PoserWeight,
				[Token(Token = "0x40006D2")]
				BendGoalWeight
			}

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0xC83144", Offset = "0xC83144", VA = "0xC83144")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0xC83BC0", Offset = "0xC83BC0", VA = "0xC83BC0")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F0")]
		public class Multiplier
		{
			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0xC8374C", Offset = "0xC8374C", VA = "0xC8374C")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0xC83BC8", Offset = "0xC83BC8", VA = "0xC83BC8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x170000FF")]
		public float length
		{
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0xC82CA4", Offset = "0xC82CA4", VA = "0xC82CA4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0xC82CAC", Offset = "0xC82CAC", VA = "0xC82CAC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0xC82CB4", Offset = "0xC82CB4", VA = "0xC82CB4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0xC82CBC", Offset = "0xC82CBC", VA = "0xC82CBC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0xC82E7C", Offset = "0xC82E7C", VA = "0xC82E7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000102")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0xC82218", Offset = "0xC82218", VA = "0xC82218")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xC82A84", Offset = "0xC82A84", VA = "0xC82A84")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xC82AC8", Offset = "0xC82AC8", VA = "0xC82AC8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xC82B0C", Offset = "0xC82B0C", VA = "0xC82B0C")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xC82B50", Offset = "0xC82B50", VA = "0xC82B50")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xC82B94", Offset = "0xC82B94", VA = "0xC82B94")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xC82BD8", Offset = "0xC82BD8", VA = "0xC82BD8")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xC82C1C", Offset = "0xC82C1C", VA = "0xC82C1C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xC82C60", Offset = "0xC82C60", VA = "0xC82C60")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xC82CC4", Offset = "0xC82CC4", VA = "0xC82CC4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xC82EFC", Offset = "0xC82EFC", VA = "0xC82EFC")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xC80988", Offset = "0xC80988", VA = "0xC80988")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xC83074", Offset = "0xC83074", VA = "0xC83074")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xC80844", Offset = "0xC80844", VA = "0xC80844")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xC80980", Offset = "0xC80980", VA = "0xC80980")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xC81574", Offset = "0xC81574", VA = "0xC81574")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xC81DB4", Offset = "0xC81DB4", VA = "0xC81DB4")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xC8377C", Offset = "0xC8377C", VA = "0xC8377C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xC83160", Offset = "0xC83160", VA = "0xC83160")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xC8307C", Offset = "0xC8307C", VA = "0xC8307C")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xC836F0", Offset = "0xC836F0", VA = "0xC836F0")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xC83780", Offset = "0xC83780", VA = "0xC83780")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xC837DC", Offset = "0xC837DC", VA = "0xC837DC")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000F2")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000F3")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[Header("Triggering")]
		[FormerlySerializedAs("collider")]
		public Collider characterCollider;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		[FormerlySerializedAs("camera")]
		public Transform FPSCamera;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Tooltip("Reference to the FBBIK component.")]
		[SerializeField]
		[Space(10f)]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000103")]
		public bool inInteraction
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0xC83DF8", Offset = "0xC83DF8", VA = "0xC83DF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000104")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000722")]
			[Address(RVA = "0xC858A0", Offset = "0xC858A0", VA = "0xC858A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000723")]
			[Address(RVA = "0xC858A8", Offset = "0xC858A8", VA = "0xC858A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0xC858B0", Offset = "0xC858B0", VA = "0xC858B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000725")]
			[Address(RVA = "0xC858B8", Offset = "0xC858B8", VA = "0xC858B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xC83BD8", Offset = "0xC83BD8", VA = "0xC83BD8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xC83C1C", Offset = "0xC83C1C", VA = "0xC83C1C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xC83C60", Offset = "0xC83C60", VA = "0xC83C60")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xC83CA4", Offset = "0xC83CA4", VA = "0xC83CA4")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xC83CE8", Offset = "0xC83CE8", VA = "0xC83CE8")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xC83D2C", Offset = "0xC83D2C", VA = "0xC83D2C")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xC83D70", Offset = "0xC83D70", VA = "0xC83D70")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xC83DB4", Offset = "0xC83DB4", VA = "0xC83DB4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xC83F70", Offset = "0xC83F70", VA = "0xC83F70")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xC84028", Offset = "0xC84028", VA = "0xC84028")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xC840E0", Offset = "0xC840E0", VA = "0xC840E0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xC84178", Offset = "0xC84178", VA = "0xC84178")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xC8425C", Offset = "0xC8425C", VA = "0xC8425C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xC84354", Offset = "0xC84354", VA = "0xC84354")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xC843D8", Offset = "0xC843D8", VA = "0xC843D8")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xC8445C", Offset = "0xC8445C", VA = "0xC8445C")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xC844E0", Offset = "0xC844E0", VA = "0xC844E0")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xC84548", Offset = "0xC84548", VA = "0xC84548")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xC845B0", Offset = "0xC845B0", VA = "0xC845B0")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xC8460C", Offset = "0xC8460C", VA = "0xC8460C")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xC8468C", Offset = "0xC8468C", VA = "0xC8468C")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xC84734", Offset = "0xC84734", VA = "0xC84734")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xC84804", Offset = "0xC84804", VA = "0xC84804")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xC84A94", Offset = "0xC84A94", VA = "0xC84A94")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xC84C68", Offset = "0xC84C68", VA = "0xC84C68")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xC84ED8", Offset = "0xC84ED8", VA = "0xC84ED8")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xC85164", Offset = "0xC85164", VA = "0xC85164")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xC8519C", Offset = "0xC8519C", VA = "0xC8519C")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xC851FC", Offset = "0xC851FC", VA = "0xC851FC")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xC85328", Offset = "0xC85328", VA = "0xC85328")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xC8550C", Offset = "0xC8550C", VA = "0xC8550C")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xC85780", Offset = "0xC85780", VA = "0xC85780")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xC84FC0", Offset = "0xC84FC0", VA = "0xC84FC0")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xC858C0", Offset = "0xC858C0", VA = "0xC858C0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xC861E4", Offset = "0xC861E4", VA = "0xC861E4")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xC86204", Offset = "0xC86204", VA = "0xC86204")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xC86220", Offset = "0xC86220", VA = "0xC86220")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xC8623C", Offset = "0xC8623C", VA = "0xC8623C")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xC86290", Offset = "0xC86290", VA = "0xC86290")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xC86414", Offset = "0xC86414", VA = "0xC86414")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xC86510", Offset = "0xC86510", VA = "0xC86510")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xC866BC", Offset = "0xC866BC", VA = "0xC866BC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xC867D4", Offset = "0xC867D4", VA = "0xC867D4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xC86ABC", Offset = "0xC86ABC", VA = "0xC86ABC")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xC85F84", Offset = "0xC85F84", VA = "0xC85F84")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xC86BEC", Offset = "0xC86BEC", VA = "0xC86BEC")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xC86CF8", Offset = "0xC86CF8", VA = "0xC86CF8")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xC86D80", Offset = "0xC86D80", VA = "0xC86D80")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xC86E40", Offset = "0xC86E40", VA = "0xC86E40")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xC86E58", Offset = "0xC86E58", VA = "0xC86E58")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xC83E90", Offset = "0xC83E90", VA = "0xC83E90")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xC84980", Offset = "0xC84980", VA = "0xC84980")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xC872D0", Offset = "0xC872D0", VA = "0xC872D0")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F5")]
		public class Multiplier
		{
			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x600074E")]
			[Address(RVA = "0xC87BE8", Offset = "0xC87BE8", VA = "0xC87BE8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xC87958", Offset = "0xC87958", VA = "0xC87958")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xC8799C", Offset = "0xC8799C", VA = "0xC8799C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xC879E0", Offset = "0xC879E0", VA = "0xC879E0")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xC87A24", Offset = "0xC87A24", VA = "0xC87A24")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xC87A68", Offset = "0xC87A68", VA = "0xC87A68")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xC87AAC", Offset = "0xC87AAC", VA = "0xC87AAC")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xC87AF0", Offset = "0xC87AF0", VA = "0xC87AF0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xC87B34", Offset = "0xC87B34", VA = "0xC87B34")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xC830E0", Offset = "0xC830E0", VA = "0xC830E0")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xC82298", Offset = "0xC82298", VA = "0xC82298")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xC80A1C", Offset = "0xC80A1C", VA = "0xC80A1C")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xC87B78", Offset = "0xC87B78", VA = "0xC87B78")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F7")]
		public class CharacterPosition
		{
			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(-180f, 180f)]
			[Tooltip("Angle offset from the default forward direction.")]
			public float angleOffset;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 180f)]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			public float maxAngle;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Token(Token = "0x17000106")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000757")]
				[Address(RVA = "0xC88010", Offset = "0xC88010", VA = "0xC88010")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000107")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000758")]
				[Address(RVA = "0xC8801C", Offset = "0xC8801C", VA = "0xC8801C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0xC880DC", Offset = "0xC880DC", VA = "0xC880DC")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0xC88840", Offset = "0xC88840", VA = "0xC88840")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F8")]
		public class CameraPosition
		{
			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Range(0f, 180f)]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			public float maxAngle;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Token(Token = "0x600075B")]
			[Address(RVA = "0xC88854", Offset = "0xC88854", VA = "0xC88854")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0xC889CC", Offset = "0xC889CC", VA = "0xC889CC")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0xC88CD4", Offset = "0xC88CD4", VA = "0xC88CD4")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F9")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000FA")]
			public class Interaction
			{
				[Token(Token = "0x400070C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Token(Token = "0x400070D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000760")]
				[Address(RVA = "0xC88D58", Offset = "0xC88D58", VA = "0xC88D58")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Token(Token = "0x600075E")]
			[Address(RVA = "0xC87EFC", Offset = "0xC87EFC", VA = "0xC87EFC")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0xC88D48", Offset = "0xC88D48", VA = "0xC88D48")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xC87BF0", Offset = "0xC87BF0", VA = "0xC87BF0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xC87C34", Offset = "0xC87C34", VA = "0xC87C34")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xC87C78", Offset = "0xC87C78", VA = "0xC87C78")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xC87CBC", Offset = "0xC87CBC", VA = "0xC87CBC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xC87D00", Offset = "0xC87D00", VA = "0xC87D00")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xC87D44", Offset = "0xC87D44", VA = "0xC87D44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xC87D48", Offset = "0xC87D48", VA = "0xC87D48")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xC87FAC", Offset = "0xC87FAC", VA = "0xC87FAC")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000FC")]
		public class Map
		{
			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000768")]
			[Address(RVA = "0xC89058", Offset = "0xC89058", VA = "0xC89058")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0xC893B0", Offset = "0xC893B0", VA = "0xC893B0")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0xC89370", Offset = "0xC89370", VA = "0xC89370")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0xC891F4", Offset = "0xC891F4", VA = "0xC891F4")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xC88D60", Offset = "0xC88D60", VA = "0xC88D60", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xC89100", Offset = "0xC89100", VA = "0xC89100", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xC89104", Offset = "0xC89104", VA = "0xC89104", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xC89314", Offset = "0xC89314", VA = "0xC89314", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xC890A4", Offset = "0xC890A4", VA = "0xC890A4")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xC88FC4", Offset = "0xC88FC4", VA = "0xC88FC4")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xC893F4", Offset = "0xC893F4", VA = "0xC893F4")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xC89414", Offset = "0xC89414", VA = "0xC89414", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xC894E4", Offset = "0xC894E4", VA = "0xC894E4", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xC896BC", Offset = "0xC896BC", VA = "0xC896BC", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xC897A4", Offset = "0xC897A4", VA = "0xC897A4", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xC89544", Offset = "0xC89544", VA = "0xC89544")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xC89AD4", Offset = "0xC89AD4", VA = "0xC89AD4")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000772")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xC89AE4", Offset = "0xC89AE4", VA = "0xC89AE4")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000774")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000775")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000776")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xC89AF0", Offset = "0xC89AF0", VA = "0xC89AF0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xC89B34", Offset = "0xC89B34", VA = "0xC89B34", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xC89B60", Offset = "0xC89B60", VA = "0xC89B60", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xC89404", Offset = "0xC89404", VA = "0xC89404")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	[RequireComponent(typeof(Animator))]
	public class RagdollUtility : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000100")]
		public class Rigidbone
		{
			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000791")]
			[Address(RVA = "0xC8A310", Offset = "0xC8A310", VA = "0xC8A310")]
			public Rigidbone(Joint joint)
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0xC8AEC8", Offset = "0xC8AEC8", VA = "0xC8AEC8")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0xC8AC88", Offset = "0xC8AC88", VA = "0xC8AC88")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x2000101")]
		public class Child
		{
			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 initLocalPosition;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion initLocalRotation;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 localPosition;

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Quaternion localRotation;

			[Token(Token = "0x6000794")]
			[Address(RVA = "0xC8A494", Offset = "0xC8A494", VA = "0xC8A494")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0xC8AFE0", Offset = "0xC8AFE0", VA = "0xC8AFE0")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0xC8AF9C", Offset = "0xC8AF9C", VA = "0xC8AF9C")]
			public void StoreLocalState()
			{
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0xC8B14C", Offset = "0xC8B14C", VA = "0xC8B14C")]
			public void ResetLocalState()
			{
			}
		}

		[Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x1700010A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600079B")]
				[Address(RVA = "0xC8B618", Offset = "0xC8B618", VA = "0xC8B618", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600079D")]
				[Address(RVA = "0xC8B660", Offset = "0xC8B660", VA = "0xC8B660", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0xC8A530", Offset = "0xC8A530", VA = "0xC8A530")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0xC8B428", Offset = "0xC8B428", VA = "0xC8B428", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0xC8B42C", Offset = "0xC8B42C", VA = "0xC8B42C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0xC8B620", Offset = "0xC8B620", VA = "0xC8B620", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Rigidbone[] rigidbones;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000108")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000787")]
			[Address(RVA = "0xC89BA4", Offset = "0xC89BA4", VA = "0xC89BA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000109")]
		private bool ikUsed
		{
			[Token(Token = "0x6000789")]
			[Address(RVA = "0xC8A8BC", Offset = "0xC8A8BC", VA = "0xC8A8BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xC89B78", Offset = "0xC89B78", VA = "0xC89B78")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xC89BCC", Offset = "0xC89BCC", VA = "0xC89BCC")]
		private void ForceDisableRagdoll()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xC89DA4", Offset = "0xC89DA4", VA = "0xC89DA4")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xC89E60", Offset = "0xC89E60", VA = "0xC89E60")]
		public void Awake()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xC89DEC", Offset = "0xC89DEC", VA = "0xC89DEC")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__22))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xC8A558", Offset = "0xC8A558", VA = "0xC8A558")]
		private void Update()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xC8A780", Offset = "0xC8A780", VA = "0xC8A780")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xC8A820", Offset = "0xC8A820", VA = "0xC8A820")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xC8AA10", Offset = "0xC8AA10", VA = "0xC8AA10")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xC8A890", Offset = "0xC8A890", VA = "0xC8A890")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xC8A9DC", Offset = "0xC8A9DC", VA = "0xC8A9DC")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xC8AA90", Offset = "0xC8AA90", VA = "0xC8AA90")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xC8AA34", Offset = "0xC8AA34", VA = "0xC8AA34")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xC89D48", Offset = "0xC89D48", VA = "0xC89D48")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xC8A7B4", Offset = "0xC8A7B4", VA = "0xC8A7B4")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xC8B0F0", Offset = "0xC8B0F0", VA = "0xC8B0F0")]
		private void ResetLocalState()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xC8B18C", Offset = "0xC8B18C", VA = "0xC8B18C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xC8B2C4", Offset = "0xC8B2C4", VA = "0xC8B2C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xC8B2DC", Offset = "0xC8B2DC", VA = "0xC8B2DC")]
		public void ResetRagdoll()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xC8B2F4", Offset = "0xC8B2F4", VA = "0xC8B2F4")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x1700010C")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0xC8BACC", Offset = "0xC8BACC", VA = "0xC8BACC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700010D")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0xC8BAD8", Offset = "0xC8BAD8", VA = "0xC8BAD8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700010E")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0xC8BB08", Offset = "0xC8BB08", VA = "0xC8BB08")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0xC8BB10", Offset = "0xC8BB10", VA = "0xC8BB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xC8B668", Offset = "0xC8B668", VA = "0xC8B668")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xC8B6A4", Offset = "0xC8B6A4", VA = "0xC8B6A4")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xC8B6BC", Offset = "0xC8B6BC", VA = "0xC8B6BC")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xC8BA3C", Offset = "0xC8BA3C", VA = "0xC8BA3C")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xC8BAA0", Offset = "0xC8BAA0", VA = "0xC8BAA0")]
		public void Disable()
		{
		}

		[Token(Token = "0x60007A7")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xC8B940", Offset = "0xC8B940", VA = "0xC8B940")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xC8BB1C", Offset = "0xC8BB1C", VA = "0xC8BB1C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xC8BB20", Offset = "0xC8BB20", VA = "0xC8BB20")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xC8BB48", Offset = "0xC8BB48", VA = "0xC8BB48")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xC8BC1C", Offset = "0xC8BC1C", VA = "0xC8BC1C")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xC8BE74", Offset = "0xC8BE74", VA = "0xC8BE74")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xC8BFC8", Offset = "0xC8BFC8", VA = "0xC8BFC8")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000104")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float limit;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xC8C028", Offset = "0xC8C028", VA = "0xC8C028")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xC8C06C", Offset = "0xC8C06C", VA = "0xC8C06C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xC8C0B0", Offset = "0xC8C0B0", VA = "0xC8C0B0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xC8C0F4", Offset = "0xC8C0F4", VA = "0xC8C0F4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xC8C138", Offset = "0xC8C138", VA = "0xC8C138", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xC8C170", Offset = "0xC8C170", VA = "0xC8C170")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xC8C494", Offset = "0xC8C494", VA = "0xC8C494")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000105")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion lastRotation;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastAngle;

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xC8C4A4", Offset = "0xC8C4A4", VA = "0xC8C4A4")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xC8C4E8", Offset = "0xC8C4E8", VA = "0xC8C4E8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xC8C52C", Offset = "0xC8C52C", VA = "0xC8C52C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xC8C570", Offset = "0xC8C570", VA = "0xC8C570")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xC8C5B4", Offset = "0xC8C5B4", VA = "0xC8C5B4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xC8C5D0", Offset = "0xC8C5D0", VA = "0xC8C5D0")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xC8C818", Offset = "0xC8C818", VA = "0xC8C818")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000106")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x2000107")]
		public class ReachCone
		{
			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x1700010F")]
			public Vector3 o
			{
				[Token(Token = "0x60007CD")]
				[Address(RVA = "0xC8E710", Offset = "0xC8E710", VA = "0xC8E710")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000110")]
			public Vector3 a
			{
				[Token(Token = "0x60007CE")]
				[Address(RVA = "0xC8E73C", Offset = "0xC8E73C", VA = "0xC8E73C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000111")]
			public Vector3 b
			{
				[Token(Token = "0x60007CF")]
				[Address(RVA = "0xC8E76C", Offset = "0xC8E76C", VA = "0xC8E76C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000112")]
			public Vector3 c
			{
				[Token(Token = "0x60007D0")]
				[Address(RVA = "0xC8E79C", Offset = "0xC8E79C", VA = "0xC8E79C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000113")]
			public bool isValid
			{
				[Token(Token = "0x60007D2")]
				[Address(RVA = "0xC8DC38", Offset = "0xC8DC38", VA = "0xC8DC38")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0xC8E0DC", Offset = "0xC8E0DC", VA = "0xC8E0DC")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0xC8E254", Offset = "0xC8E254", VA = "0xC8E254")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000108")]
		public class LimitPoint
		{
			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0xC8DC48", Offset = "0xC8DC48", VA = "0xC8DC48")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public LimitPoint[] points;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[SerializeField]
		public Vector3[] P;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		public ReachCone[] reachCones;

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xC8C87C", Offset = "0xC8C87C", VA = "0xC8C87C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xC8C8C0", Offset = "0xC8C8C0", VA = "0xC8C8C0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xC8C904", Offset = "0xC8C904", VA = "0xC8C904")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xC8C948", Offset = "0xC8C948", VA = "0xC8C948")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xC8C98C", Offset = "0xC8C98C", VA = "0xC8C98C")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xC8D070", Offset = "0xC8D070", VA = "0xC8D070", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xC8D0F8", Offset = "0xC8D0F8", VA = "0xC8D0F8")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xC8D744", Offset = "0xC8D744", VA = "0xC8D744")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xC8CA24", Offset = "0xC8CA24", VA = "0xC8CA24")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xC8DCAC", Offset = "0xC8DCAC", VA = "0xC8DCAC")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xC8E4C8", Offset = "0xC8E4C8", VA = "0xC8E4C8")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xC8E510", Offset = "0xC8E510", VA = "0xC8E510")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xC8E570", Offset = "0xC8E570", VA = "0xC8E570")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xC8D4A0", Offset = "0xC8D4A0", VA = "0xC8D4A0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xC8E5DC", Offset = "0xC8E5DC", VA = "0xC8E5DC")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xC8E6A8", Offset = "0xC8E6A8", VA = "0xC8E6A8")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000109")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xC8E7CC", Offset = "0xC8E7CC", VA = "0xC8E7CC")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xC8E810", Offset = "0xC8E810", VA = "0xC8E810")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xC8E854", Offset = "0xC8E854", VA = "0xC8E854")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xC8E898", Offset = "0xC8E898", VA = "0xC8E898")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xC8E8DC", Offset = "0xC8E8DC", VA = "0xC8E8DC")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xC8E8F8", Offset = "0xC8E8F8", VA = "0xC8E8F8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xC8E930", Offset = "0xC8E930", VA = "0xC8E930")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xC8ECDC", Offset = "0xC8ECDC", VA = "0xC8ECDC")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x200010B")]
		[CompilerGenerated]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x17000115")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E7")]
				[Address(RVA = "0xC8F9C0", Offset = "0xC8F9C0", VA = "0xC8F9C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000116")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E9")]
				[Address(RVA = "0xC8FA08", Offset = "0xC8FA08", VA = "0xC8FA08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0xC8F7C0", Offset = "0xC8F7C0", VA = "0xC8F7C0")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0xC8F8CC", Offset = "0xC8F8CC", VA = "0xC8F8CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0xC8F8D0", Offset = "0xC8F8D0", VA = "0xC8F8D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0xC8F9C8", Offset = "0xC8F9C8", VA = "0xC8F9C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Master weight of the IK solver.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Target Smoothing")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		public Transform target;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Range(0f, 180f)]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Header("RootRotation")]
		public float maxRootAngle;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Mode")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x17000114")]
		private Vector3 pivot
		{
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0xC8ED68", Offset = "0xC8ED68", VA = "0xC8ED68")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xC8ECE8", Offset = "0xC8ECE8", VA = "0xC8ECE8")]
		private void Start()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xC8EDEC", Offset = "0xC8EDEC", VA = "0xC8EDEC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xC8F324", Offset = "0xC8F324", VA = "0xC8F324")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xC8F4A8", Offset = "0xC8F4A8", VA = "0xC8F4A8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xC8F74C", Offset = "0xC8F74C", VA = "0xC8F74C")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__33))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xC8F7E8", Offset = "0xC8F7E8", VA = "0xC8F7E8")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010D")]
		public class Pose
		{
			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0xC8FAE0", Offset = "0xC8FAE0", VA = "0xC8FAE0")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0xC9005C", Offset = "0xC9005C", VA = "0xC9005C")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0xC90064", Offset = "0xC90064", VA = "0xC90064")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xC8FA10", Offset = "0xC8FA10", VA = "0xC8FA10")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xC8FF90", Offset = "0xC8FF90", VA = "0xC8FF90")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xC8FFF0", Offset = "0xC8FFF0", VA = "0xC8FFF0")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010F")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000110")]
			public class EffectorLink
			{
				[Token(Token = "0x400078B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400078C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x60007F5")]
				[Address(RVA = "0xC90528", Offset = "0xC90528", VA = "0xC90528")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0xC901D0", Offset = "0xC901D0", VA = "0xC901D0")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0xC90500", Offset = "0xC90500", VA = "0xC90500")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0xC90510", Offset = "0xC90510", VA = "0xC90510")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xC90080", Offset = "0xC90080", VA = "0xC90080", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xC904E0", Offset = "0xC904E0", VA = "0xC904E0")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xC90530", Offset = "0xC90530", VA = "0xC90530", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xC90598", Offset = "0xC90598", VA = "0xC90598", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xC90838", Offset = "0xC90838", VA = "0xC90838")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x2000112")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IK ik;

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xC90854", Offset = "0xC90854", VA = "0xC90854")]
		private void Start()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xC908F0", Offset = "0xC908F0", VA = "0xC908F0")]
		private void Update()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xC909B0", Offset = "0xC909B0", VA = "0xC909B0")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000114")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000118")]
			public bool inProgress
			{
				[Token(Token = "0x6000800")]
				[Address(RVA = "0xC90A54", Offset = "0xC90A54", VA = "0xC90A54")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000119")]
			protected float crossFader
			{
				[Token(Token = "0x6000801")]
				[Address(RVA = "0xC90F54", Offset = "0xC90F54", VA = "0xC90F54")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000802")]
				[Address(RVA = "0xC90F5C", Offset = "0xC90F5C", VA = "0xC90F5C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700011A")]
			protected float timer
			{
				[Token(Token = "0x6000803")]
				[Address(RVA = "0xC90F64", Offset = "0xC90F64", VA = "0xC90F64")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000804")]
				[Address(RVA = "0xC90F6C", Offset = "0xC90F6C", VA = "0xC90F6C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700011B")]
			protected Vector3 force
			{
				[Token(Token = "0x6000805")]
				[Address(RVA = "0xC90F74", Offset = "0xC90F74", VA = "0xC90F74")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000806")]
				[Address(RVA = "0xC90F80", Offset = "0xC90F80", VA = "0xC90F80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700011C")]
			protected Vector3 point
			{
				[Token(Token = "0x6000807")]
				[Address(RVA = "0xC90F8C", Offset = "0xC90F8C", VA = "0xC90F8C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000808")]
				[Address(RVA = "0xC90F98", Offset = "0xC90F98", VA = "0xC90F98")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000809")]
			[Address(RVA = "0xC90E1C", Offset = "0xC90E1C", VA = "0xC90E1C")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x600080A")]
			[Address(RVA = "0xC90B28", Offset = "0xC90B28", VA = "0xC90B28")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600080B")]
			protected abstract float GetLength();

			[Token(Token = "0x600080C")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600080D")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x600080E")]
			[Address(RVA = "0xC90FA4", Offset = "0xC90FA4", VA = "0xC90FA4")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000115")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000116")]
			public class EffectorLink
			{
				[Token(Token = "0x40007A3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40007A4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x40007A5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40007A6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000813")]
				[Address(RVA = "0xC912D8", Offset = "0xC912D8", VA = "0xC912D8")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000814")]
				[Address(RVA = "0xC91134", Offset = "0xC91134", VA = "0xC91134")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000815")]
				[Address(RVA = "0xC91388", Offset = "0xC91388", VA = "0xC91388")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600080F")]
			[Address(RVA = "0xC90FB8", Offset = "0xC90FB8", VA = "0xC90FB8", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000810")]
			[Address(RVA = "0xC910D4", Offset = "0xC910D4", VA = "0xC910D4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0xC91148", Offset = "0xC91148", VA = "0xC91148", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000812")]
			[Address(RVA = "0xC91374", Offset = "0xC91374", VA = "0xC91374")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000117")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000118")]
			public class BoneLink
			{
				[Token(Token = "0x40007AA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Token(Token = "0x40007AB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x40007AC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x40007AD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x600081A")]
				[Address(RVA = "0xC91658", Offset = "0xC91658", VA = "0xC91658")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600081B")]
				[Address(RVA = "0xC91474", Offset = "0xC91474", VA = "0xC91474")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600081C")]
				[Address(RVA = "0xC917F8", Offset = "0xC917F8", VA = "0xC917F8")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000816")]
			[Address(RVA = "0xC91390", Offset = "0xC91390", VA = "0xC91390", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0xC9141C", Offset = "0xC9141C", VA = "0xC9141C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0xC91480", Offset = "0xC91480", VA = "0xC91480", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0xC917E4", Offset = "0xC917E4", VA = "0xC917E4")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000117")]
		public bool inProgress
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0xC909B8", Offset = "0xC909B8", VA = "0xC909B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xC90A68", Offset = "0xC90A68", VA = "0xC90A68", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xC90C00", Offset = "0xC90C00", VA = "0xC90C00")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xC90F44", Offset = "0xC90F44", VA = "0xC90F44")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x200011A")]
		public abstract class Offset
		{
			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x1700011D")]
			protected float crossFader
			{
				[Token(Token = "0x6000820")]
				[Address(RVA = "0xC91D68", Offset = "0xC91D68", VA = "0xC91D68")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000821")]
				[Address(RVA = "0xC91D70", Offset = "0xC91D70", VA = "0xC91D70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700011E")]
			protected float timer
			{
				[Token(Token = "0x6000822")]
				[Address(RVA = "0xC91D78", Offset = "0xC91D78", VA = "0xC91D78")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000823")]
				[Address(RVA = "0xC91D80", Offset = "0xC91D80", VA = "0xC91D80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700011F")]
			protected Vector3 force
			{
				[Token(Token = "0x6000824")]
				[Address(RVA = "0xC91D88", Offset = "0xC91D88", VA = "0xC91D88")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000825")]
				[Address(RVA = "0xC91D94", Offset = "0xC91D94", VA = "0xC91D94")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000120")]
			protected Vector3 point
			{
				[Token(Token = "0x6000826")]
				[Address(RVA = "0xC91DA0", Offset = "0xC91DA0", VA = "0xC91DA0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000827")]
				[Address(RVA = "0xC91DAC", Offset = "0xC91DAC", VA = "0xC91DAC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000828")]
			[Address(RVA = "0xC91C18", Offset = "0xC91C18", VA = "0xC91C18")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000829")]
			[Address(RVA = "0xC91914", Offset = "0xC91914", VA = "0xC91914")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600082A")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x600082B")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600082C")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600082D")]
			[Address(RVA = "0xC91DB8", Offset = "0xC91DB8", VA = "0xC91DB8")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200011B")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x200011C")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x40007BE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x40007BF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x40007C0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40007C1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000832")]
				[Address(RVA = "0xC9219C", Offset = "0xC9219C", VA = "0xC9219C")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000833")]
				[Address(RVA = "0xC91FC0", Offset = "0xC91FC0", VA = "0xC91FC0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000834")]
				[Address(RVA = "0xC92230", Offset = "0xC92230", VA = "0xC92230")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600082E")]
			[Address(RVA = "0xC91DCC", Offset = "0xC91DCC", VA = "0xC91DCC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600082F")]
			[Address(RVA = "0xC91F60", Offset = "0xC91F60", VA = "0xC91F60", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000830")]
			[Address(RVA = "0xC91FD4", Offset = "0xC91FD4", VA = "0xC91FD4", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000831")]
			[Address(RVA = "0xC92214", Offset = "0xC92214", VA = "0xC92214")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200011D")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x200011E")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x40007C5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x40007C6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				[Token(Token = "0x40007C7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x40007C8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000839")]
				[Address(RVA = "0xC92604", Offset = "0xC92604", VA = "0xC92604")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600083A")]
				[Address(RVA = "0xC92368", Offset = "0xC92368", VA = "0xC92368")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600083B")]
				[Address(RVA = "0xC92720", Offset = "0xC92720", VA = "0xC92720")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000835")]
			[Address(RVA = "0xC92238", Offset = "0xC92238", VA = "0xC92238", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000836")]
			[Address(RVA = "0xC92310", Offset = "0xC92310", VA = "0xC92310", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000837")]
			[Address(RVA = "0xC92374", Offset = "0xC92374", VA = "0xC92374", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000838")]
			[Address(RVA = "0xC9270C", Offset = "0xC9270C", VA = "0xC9270C")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xC9185C", Offset = "0xC9185C", VA = "0xC9185C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xC919F4", Offset = "0xC919F4", VA = "0xC919F4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xC91D48", Offset = "0xC91D48", VA = "0xC91D48")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000120")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000121")]
			public class EffectorLink
			{
				[Token(Token = "0x40007D6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40007D7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000842")]
				[Address(RVA = "0xC92CE8", Offset = "0xC92CE8", VA = "0xC92CE8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Matching target velocity")]
			[Range(0f, 1f)]
			public float matchVelocity;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600083F")]
			[Address(RVA = "0xC927F0", Offset = "0xC927F0", VA = "0xC927F0")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0xC92970", Offset = "0xC92970", VA = "0xC92970")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000841")]
			[Address(RVA = "0xC92CCC", Offset = "0xC92CCC", VA = "0xC92CCC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xC92784", Offset = "0xC92784", VA = "0xC92784")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xC928CC", Offset = "0xC928CC", VA = "0xC928CC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xC92CBC", Offset = "0xC92CBC", VA = "0xC92CBC")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		[Header("Target Smoothing")]
		public Transform target;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 180f)]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		[Header("RootRotation")]
		public float maxRootAngle;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x17000121")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000845")]
			[Address(RVA = "0xC92D58", Offset = "0xC92D58", VA = "0xC92D58")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xC92CF0", Offset = "0xC92CF0", VA = "0xC92CF0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xC92DDC", Offset = "0xC92DDC", VA = "0xC92DDC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xC932D0", Offset = "0xC932D0", VA = "0xC932D0")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xC93454", Offset = "0xC93454", VA = "0xC93454")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xC936A0", Offset = "0xC936A0", VA = "0xC936A0")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000124")]
		public class OffsetLimits
		{
			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("The limits")]
			public float minX;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The limits")]
			public float maxX;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The limits")]
			public float minY;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The limits")]
			public float maxY;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The limits")]
			public float minZ;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The limits")]
			public float maxZ;

			[Token(Token = "0x6000851")]
			[Address(RVA = "0xC938A8", Offset = "0xC938A8", VA = "0xC938A8")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000852")]
			[Address(RVA = "0xC93B38", Offset = "0xC93B38", VA = "0xC93B38")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000853")]
			[Address(RVA = "0xC93BA8", Offset = "0xC93BA8", VA = "0xC93BA8")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000854")]
			[Address(RVA = "0xC93BF0", Offset = "0xC93BF0", VA = "0xC93BF0")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000125")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x17000123")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000858")]
				[Address(RVA = "0xC93D6C", Offset = "0xC93D6C", VA = "0xC93D6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000124")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600085A")]
				[Address(RVA = "0xC93DB4", Offset = "0xC93DB4", VA = "0xC93DB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000855")]
			[Address(RVA = "0xC937AC", Offset = "0xC937AC", VA = "0xC937AC")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000856")]
			[Address(RVA = "0xC93BF8", Offset = "0xC93BF8", VA = "0xC93BF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0xC93BFC", Offset = "0xC93BFC", VA = "0xC93BFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000859")]
			[Address(RVA = "0xC93D74", Offset = "0xC93D74", VA = "0xC93D74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000122")]
		protected float deltaTime
		{
			[Token(Token = "0x6000849")]
			[Address(RVA = "0xC901B0", Offset = "0xC901B0", VA = "0xC901B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600084A")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xC90578", Offset = "0xC90578", VA = "0xC90578", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xC93738", Offset = "0xC93738", VA = "0xC93738")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xC937D4", Offset = "0xC937D4", VA = "0xC937D4")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xC92C14", Offset = "0xC92C14", VA = "0xC92C14")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xC93A0C", Offset = "0xC93A0C", VA = "0xC93A0C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xC904F0", Offset = "0xC904F0", VA = "0xC904F0")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000127")]
		[CompilerGenerated]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x17000126")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000865")]
				[Address(RVA = "0xC9420C", Offset = "0xC9420C", VA = "0xC9420C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000127")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000867")]
				[Address(RVA = "0xC94254", Offset = "0xC94254", VA = "0xC94254", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000862")]
			[Address(RVA = "0xC93E70", Offset = "0xC93E70", VA = "0xC93E70")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000863")]
			[Address(RVA = "0xC94098", Offset = "0xC94098", VA = "0xC94098", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000864")]
			[Address(RVA = "0xC9409C", Offset = "0xC9409C", VA = "0xC9409C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000866")]
			[Address(RVA = "0xC94214", Offset = "0xC94214", VA = "0xC94214", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000125")]
		protected float deltaTime
		{
			[Token(Token = "0x600085B")]
			[Address(RVA = "0xC93DBC", Offset = "0xC93DBC", VA = "0xC93DBC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600085C")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xC93DDC", Offset = "0xC93DDC", VA = "0xC93DDC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xC93DFC", Offset = "0xC93DFC", VA = "0xC93DFC")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xC93E98", Offset = "0xC93E98", VA = "0xC93E98")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xC93F6C", Offset = "0xC93F6C", VA = "0xC93F6C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xC91D58", Offset = "0xC91D58", VA = "0xC91D58")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000129")]
		public class EffectorLink
		{
			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x600086B")]
			[Address(RVA = "0xC9425C", Offset = "0xC9425C", VA = "0xC9425C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x600086C")]
			[Address(RVA = "0xC945B4", Offset = "0xC945B4", VA = "0xC945B4")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xC90784", Offset = "0xC90784", VA = "0xC90784")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xC944AC", Offset = "0xC944AC", VA = "0xC944AC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xC94550", Offset = "0xC94550", VA = "0xC94550")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200012B")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x200012C")]
			public class EffectorLink
			{
				[Token(Token = "0x4000813")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000814")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;

				[Token(Token = "0x6000873")]
				[Address(RVA = "0xC94C08", Offset = "0xC94C08", VA = "0xC94C08")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 1f)]
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			public float raycastRadius;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this to FBBIK effectors.")]
			public EffectorLink[] effectors;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x600086F")]
			[Address(RVA = "0xC9462C", Offset = "0xC9462C", VA = "0xC9462C")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000870")]
			[Address(RVA = "0xC947CC", Offset = "0xC947CC", VA = "0xC947CC")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000871")]
			[Address(RVA = "0xC948D4", Offset = "0xC948D4", VA = "0xC948D4")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0xC94BF4", Offset = "0xC94BF4", VA = "0xC94BF4")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xC945BC", Offset = "0xC945BC", VA = "0xC945BC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xC947BC", Offset = "0xC947BC", VA = "0xC947BC")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200012E")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x200012F")]
			public class EffectorLink
			{
				[Token(Token = "0x4000832")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000833")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000883")]
				[Address(RVA = "0xC95FB4", Offset = "0xC95FB4", VA = "0xC95FB4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			[Range(0f, 1f)]
			public float additivity;

			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000880")]
			[Address(RVA = "0xC94DAC", Offset = "0xC94DAC", VA = "0xC94DAC")]
			public void Start()
			{
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0xC9592C", Offset = "0xC9592C", VA = "0xC9592C")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000882")]
			[Address(RVA = "0xC95FA0", Offset = "0xC95FA0", VA = "0xC95FA0")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000130")]
		public enum Handedness
		{
			[Token(Token = "0x4000835")]
			Right,
			[Token(Token = "0x4000836")]
			Left
		}

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		[Space(10f)]
		public RecoilOffset[] offsets;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x17000128")]
		public bool isFinished
		{
			[Token(Token = "0x6000874")]
			[Address(RVA = "0xC94C10", Offset = "0xC94C10", VA = "0xC94C10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000129")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x600087A")]
			[Address(RVA = "0xC95B30", Offset = "0xC95B30", VA = "0xC95B30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012A")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x600087B")]
			[Address(RVA = "0xC95B6C", Offset = "0xC95B6C", VA = "0xC95B6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012B")]
		private Transform primaryHand
		{
			[Token(Token = "0x600087C")]
			[Address(RVA = "0xC95AF8", Offset = "0xC95AF8", VA = "0xC95AF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012C")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600087D")]
			[Address(RVA = "0xC95B14", Offset = "0xC95B14", VA = "0xC95B14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xC94C34", Offset = "0xC94C34", VA = "0xC94C34")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xC94C60", Offset = "0xC94C60", VA = "0xC94C60")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xC94E80", Offset = "0xC94E80", VA = "0xC94E80", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xC95BA8", Offset = "0xC95BA8", VA = "0xC95BA8")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xC95CC0", Offset = "0xC95CC0", VA = "0xC95CC0")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xC95D10", Offset = "0xC95D10", VA = "0xC95D10", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xC95F14", Offset = "0xC95F14", VA = "0xC95F14")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xC95FBC", Offset = "0xC95FBC", VA = "0xC95FBC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xC960D0", Offset = "0xC960D0", VA = "0xC960D0")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xC961AC", Offset = "0xC961AC", VA = "0xC961AC")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xC965B0", Offset = "0xC965B0", VA = "0xC965B0")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xC965E4", Offset = "0xC965E4", VA = "0xC965E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xC96710", Offset = "0xC96710", VA = "0xC96710")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x2000133")]
		public class Settings
		{
			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Multiplies character scale")]
			public float scaleMlp;

			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Local axis of the body tracker towards the player's forward direction.")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Local axis of the body tracker towards the up direction.")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			[Space(10f)]
			public Vector3 headOffset;

			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Range(-180f, 180f)]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			public float footHeadingOffset;

			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x400084A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x600088F")]
			[Address(RVA = "0xC992C8", Offset = "0xC992C8", VA = "0xC992C8")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000134")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x2000135")]
			public class Target
			{
				[Token(Token = "0x4000857")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000858")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000859")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000891")]
				[Address(RVA = "0xC98400", Offset = "0xC98400", VA = "0xC98400")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000892")]
				[Address(RVA = "0xC98E58", Offset = "0xC98E58", VA = "0xC98E58")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000890")]
			[Address(RVA = "0xC97B04", Offset = "0xC97B04", VA = "0xC97B04")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xC96724", Offset = "0xC96724", VA = "0xC96724")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xC96818", Offset = "0xC96818", VA = "0xC96818")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xC97B0C", Offset = "0xC97B0C", VA = "0xC97B0C")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xC984B4", Offset = "0xC984B4", VA = "0xC984B4")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xC98EB4", Offset = "0xC98EB4", VA = "0xC98EB4")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xC994CC", Offset = "0xC994CC", VA = "0xC994CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xC99524", Offset = "0xC99524", VA = "0xC99524")]
		private void Update()
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xC9954C", Offset = "0xC9954C", VA = "0xC9954C")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xC9966C", Offset = "0xC9966C", VA = "0xC9966C")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x1700012D")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0xC99684", Offset = "0xC99684", VA = "0xC99684")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000898")]
			[Address(RVA = "0xC99690", Offset = "0xC99690", VA = "0xC99690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xC9969C", Offset = "0xC9969C", VA = "0xC9969C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xC981EC", Offset = "0xC981EC", VA = "0xC981EC")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xC99128", Offset = "0xC99128", VA = "0xC99128")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xC997B8", Offset = "0xC997B8", VA = "0xC997B8")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xC99B80", Offset = "0xC99B80", VA = "0xC99B80")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xC99CAC", Offset = "0xC99CAC", VA = "0xC99CAC")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000138")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000139")]
		public class Offset
		{
			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0xC9AE40", Offset = "0xC9AE40", VA = "0xC9AE40")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0xC9AFF0", Offset = "0xC9AFF0", VA = "0xC9AFF0")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x600089F")]
		[Address(RVA = "0xC99CB4", Offset = "0xC99CB4", VA = "0xC99CB4")]
		private void Start()
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xC99D0C", Offset = "0xC99D0C", VA = "0xC99D0C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xC99D74", Offset = "0xC99D74", VA = "0xC99D74")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xC99E38", Offset = "0xC99E38", VA = "0xC99E38")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xC9AFF8", Offset = "0xC9AFF8", VA = "0xC9AFF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xC9B078", Offset = "0xC9B078", VA = "0xC9B078")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The direction of the animated weapon swing in character space. Tweak this value to adjust the aiming.")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xC9B080", Offset = "0xC9B080", VA = "0xC9B080")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xC9B0EC", Offset = "0xC9B0EC", VA = "0xC9B0EC")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xC9B14C", Offset = "0xC9B14C", VA = "0xC9B14C")]
		private void Start()
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xC9B184", Offset = "0xC9B184", VA = "0xC9B184")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xC9B440", Offset = "0xC9B440", VA = "0xC9B440")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xC9B448", Offset = "0xC9B448", VA = "0xC9B448")]
		private void Start()
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xC9B480", Offset = "0xC9B480", VA = "0xC9B480")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xC9B5CC", Offset = "0xC9B5CC", VA = "0xC9B5CC")]
		private void Pose()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xC9B758", Offset = "0xC9B758", VA = "0xC9B758")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xC9B93C", Offset = "0xC9B93C", VA = "0xC9B93C")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xC9B9CC", Offset = "0xC9B9CC", VA = "0xC9B9CC")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x200013E")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xC9B9E0", Offset = "0xC9B9E0", VA = "0xC9B9E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xC9BB4C", Offset = "0xC9BB4C", VA = "0xC9BB4C")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xC9BD48", Offset = "0xC9BD48", VA = "0xC9BD48")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("References")]
		public Animator animator;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xC9BD78", Offset = "0xC9BD78", VA = "0xC9BD78")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xC9C1A4", Offset = "0xC9C1A4", VA = "0xC9C1A4")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xC9C1C4", Offset = "0xC9C1C4", VA = "0xC9C1C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xC9CAE0", Offset = "0xC9CAE0", VA = "0xC9CAE0")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xC9C85C", Offset = "0xC9C85C", VA = "0xC9C85C")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xC9CBF0", Offset = "0xC9CBF0", VA = "0xC9CBF0")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x1700012E")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0xC9CC1C", Offset = "0xC9CC1C", VA = "0xC9CC1C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xC9CC9C", Offset = "0xC9CC9C", VA = "0xC9CC9C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xC9CFE0", Offset = "0xC9CFE0", VA = "0xC9CFE0")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x2000143")]
		[CompilerGenerated]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x40008C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x40008C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x17000131")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008CC")]
				[Address(RVA = "0xC9E068", Offset = "0xC9E068", VA = "0xC9E068", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000132")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008CE")]
				[Address(RVA = "0xC9E0B0", Offset = "0xC9E0B0", VA = "0xC9E0B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0xC9DD00", Offset = "0xC9DD00", VA = "0xC9DD00")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60008CA")]
			[Address(RVA = "0xC9DDB8", Offset = "0xC9DDB8", VA = "0xC9DDB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008CB")]
			[Address(RVA = "0xC9DDBC", Offset = "0xC9DDBC", VA = "0xC9DDBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008CD")]
			[Address(RVA = "0xC9E070", Offset = "0xC9E070", VA = "0xC9E070", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x1700012F")]
		public bool isStepping
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0xC9CFF4", Offset = "0xC9CFF4", VA = "0xC9CFF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000130")]
		public Vector3 position
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0xC9CBC0", Offset = "0xC9CBC0", VA = "0xC9CBC0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0xC9D008", Offset = "0xC9D008", VA = "0xC9D008")]
			set
			{
			}
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xC9D054", Offset = "0xC9D054", VA = "0xC9D054")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xC9D2D4", Offset = "0xC9D2D4", VA = "0xC9D2D4")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xC9D4AC", Offset = "0xC9D4AC", VA = "0xC9D4AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xC9D6D0", Offset = "0xC9D6D0", VA = "0xC9D6D0")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xC9D960", Offset = "0xC9D960", VA = "0xC9D960")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xC9DAC8", Offset = "0xC9DAC8", VA = "0xC9DAC8")]
		private void Update()
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xC9D620", Offset = "0xC9D620", VA = "0xC9D620")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xC9DD28", Offset = "0xC9DD28", VA = "0xC9DD28")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xC9E0B8", Offset = "0xC9E0B8", VA = "0xC9E0B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xC9E194", Offset = "0xC9E194", VA = "0xC9E194")]
		private void Update()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xC9E408", Offset = "0xC9E408", VA = "0xC9E408")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000146")]
		public struct Warp
		{
			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x2000147")]
		public enum EffectorMode
		{
			[Token(Token = "0x40008D5")]
			PositionOffset,
			[Token(Token = "0x40008D6")]
			Position
		}

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space(10f)]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		public Warp[] warps;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xC9E410", Offset = "0xC9E410", VA = "0xC9E410", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xC9E430", Offset = "0xC9E430", VA = "0xC9E430")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xC9E648", Offset = "0xC9E648", VA = "0xC9E648", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xC9E900", Offset = "0xC9E900", VA = "0xC9E900")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xC9E994", Offset = "0xC9E994", VA = "0xC9E994")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x2000148")]
	[RequireComponent(typeof(Animator))]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xC9E99C", Offset = "0xC9E99C", VA = "0xC9E99C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xC9E9F4", Offset = "0xC9E9F4", VA = "0xC9E9F4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xC9EBFC", Offset = "0xC9EBFC", VA = "0xC9EBFC", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xC9EE24", Offset = "0xC9EE24", VA = "0xC9EE24")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000149")]
	[RequireComponent(typeof(AimIK))]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xC9EE38", Offset = "0xC9EE38", VA = "0xC9EE38", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xC9F00C", Offset = "0xC9F00C", VA = "0xC9F00C", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xC9F07C", Offset = "0xC9F07C", VA = "0xC9F07C")]
		private void Read()
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xC9F1B4", Offset = "0xC9F1B4", VA = "0xC9F1B4")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xC9F210", Offset = "0xC9F210", VA = "0xC9F210")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xC9F858", Offset = "0xC9F858", VA = "0xC9F858")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xC9F66C", Offset = "0xC9F66C", VA = "0xC9F66C")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xC9FAFC", Offset = "0xC9FAFC", VA = "0xC9FAFC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xC9FC28", Offset = "0xC9FC28", VA = "0xC9FC28")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x200014A")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xC9FC44", Offset = "0xC9FC44", VA = "0xC9FC44", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xC9FD2C", Offset = "0xC9FD2C", VA = "0xC9FD2C", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xCA0080", Offset = "0xCA0080", VA = "0xCA0080")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xCA0170", Offset = "0xCA0170", VA = "0xCA0170")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x200014B")]
	[RequireComponent(typeof(AnimatorController3rdPerson))]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000133")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60008EA")]
			[Address(RVA = "0xCA0418", Offset = "0xCA0418", VA = "0xCA0418")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000134")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0xCA0498", Offset = "0xCA0498", VA = "0xCA0498")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xCA01B8", Offset = "0xCA01B8", VA = "0xCA01B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xCA0228", Offset = "0xCA0228", VA = "0xCA0228")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xCA0518", Offset = "0xCA0518", VA = "0xCA0518")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200014C")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0xCA0520", Offset = "0xCA0520", VA = "0xCA0520", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xCA097C", Offset = "0xCA097C", VA = "0xCA097C")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x200014D")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0xCA0984", Offset = "0xCA0984", VA = "0xCA0984")]
		private void Start()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0xCA0A3C", Offset = "0xCA0A3C", VA = "0xCA0A3C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0xCA0E98", Offset = "0xCA0E98", VA = "0xCA0E98")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0xCA0F38", Offset = "0xCA0F38", VA = "0xCA0F38")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x200014E")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014F")]
		public class Limb
		{
			[Token(Token = "0x400090B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x400090C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0xCA10CC", Offset = "0xCA10CC", VA = "0xCA10CC")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0xCA11F0", Offset = "0xCA11F0", VA = "0xCA11F0")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0xCA0FA8", Offset = "0xCA0FA8", VA = "0xCA0FA8")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0xCA1144", Offset = "0xCA1144", VA = "0xCA1144")]
		private void Start()
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0xCA11DC", Offset = "0xCA11DC", VA = "0xCA11DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0xCA11E0", Offset = "0xCA11E0", VA = "0xCA11E0")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000150")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0xCA1200", Offset = "0xCA1200", VA = "0xCA1200")]
		private void Start()
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0xCA1268", Offset = "0xCA1268", VA = "0xCA1268")]
		private void Update()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xCA133C", Offset = "0xCA133C", VA = "0xCA133C")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000151")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xCA1344", Offset = "0xCA1344", VA = "0xCA1344")]
		private void Start()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xCA139C", Offset = "0xCA139C", VA = "0xCA139C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xCA1534", Offset = "0xCA1534", VA = "0xCA1534")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000152")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xCA153C", Offset = "0xCA153C", VA = "0xCA153C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xCA161C", Offset = "0xCA161C", VA = "0xCA161C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xCA16A8", Offset = "0xCA16A8", VA = "0xCA16A8")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0xCA1B7C", Offset = "0xCA1B7C", VA = "0xCA1B7C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xCA1CA8", Offset = "0xCA1CA8", VA = "0xCA1CA8")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CameraControllerFPS cam;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Recoil recoil;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float cameraRecoilWeight;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool updateFrame;

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xCA1CB0", Offset = "0xCA1CB0", VA = "0xCA1CB0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0xCA1E10", Offset = "0xCA1E10", VA = "0xCA1E10")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0xCA1E1C", Offset = "0xCA1E1C", VA = "0xCA1E1C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0xCA20DC", Offset = "0xCA20DC", VA = "0xCA20DC")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0xCA2268", Offset = "0xCA2268", VA = "0xCA2268")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0xCA1EE0", Offset = "0xCA1EE0", VA = "0xCA1EE0")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0xCA2F20", Offset = "0xCA2F20", VA = "0xCA2F20")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000154")]
	[RequireComponent(typeof(FPSAiming))]
	[RequireComponent(typeof(Animator))]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x600090B")]
		[Address(RVA = "0xCA2F40", Offset = "0xCA2F40", VA = "0xCA2F40")]
		private void Start()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xCA2FD0", Offset = "0xCA2FD0", VA = "0xCA2FD0")]
		private void Update()
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xCA30CC", Offset = "0xCA30CC", VA = "0xCA30CC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xCA3178", Offset = "0xCA3178", VA = "0xCA3178")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000155")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600090F")]
		[Address(RVA = "0xCA3188", Offset = "0xCA3188", VA = "0xCA3188")]
		private void Update()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xCA32D8", Offset = "0xCA32D8", VA = "0xCA32D8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xCA343C", Offset = "0xCA343C", VA = "0xCA343C")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000156")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xCA344C", Offset = "0xCA344C", VA = "0xCA344C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xCA3618", Offset = "0xCA3618", VA = "0xCA3618")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xCA3A28", Offset = "0xCA3A28", VA = "0xCA3A28")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000157")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xCA3A38", Offset = "0xCA3A38", VA = "0xCA3A38")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xCA3B20", Offset = "0xCA3B20", VA = "0xCA3B20")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xCA3C0C", Offset = "0xCA3C0C", VA = "0xCA3C0C")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xCA3C14", Offset = "0xCA3C14", VA = "0xCA3C14")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xCA4114", Offset = "0xCA4114", VA = "0xCA4114")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x2000159")]
	[RequireComponent(typeof(InteractionSystem))]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The object to interact to")]
		public InteractionObject interactionObject;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The effectors to interact with")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xCA411C", Offset = "0xCA411C", VA = "0xCA411C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xCA4174", Offset = "0xCA4174", VA = "0xCA4174")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xCA4420", Offset = "0xCA4420", VA = "0xCA4420")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x200015A")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200015B")]
		public class Partner
		{
			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x17000135")]
			private Transform neck
			{
				[Token(Token = "0x6000922")]
				[Address(RVA = "0xCA4C2C", Offset = "0xCA4C2C", VA = "0xCA4C2C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000920")]
			[Address(RVA = "0xCA4450", Offset = "0xCA4450", VA = "0xCA4450")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000921")]
			[Address(RVA = "0xCA44CC", Offset = "0xCA44CC", VA = "0xCA44CC")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000923")]
			[Address(RVA = "0xCA4AC4", Offset = "0xCA4AC4", VA = "0xCA4AC4")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000924")]
			[Address(RVA = "0xCA4C78", Offset = "0xCA4C78", VA = "0xCA4C78")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xCA4428", Offset = "0xCA4428", VA = "0xCA4428")]
		private void Start()
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0xCA4470", Offset = "0xCA4470", VA = "0xCA4470")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xCA4AB4", Offset = "0xCA4AB4", VA = "0xCA4AB4")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x200015C")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200015D")]
		public enum Mode
		{
			[Token(Token = "0x4000961")]
			Position,
			[Token(Token = "0x4000962")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x200015E")]
		public class Absorber
		{
			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x600092B")]
			[Address(RVA = "0xCA4E04", Offset = "0xCA4E04", VA = "0xCA4E04")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0xCA4FEC", Offset = "0xCA4FEC", VA = "0xCA4FEC")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x600092D")]
			[Address(RVA = "0xCA5010", Offset = "0xCA5010", VA = "0xCA5010")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x600092E")]
			[Address(RVA = "0xCA5120", Offset = "0xCA5120", VA = "0xCA5120")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x600092F")]
			[Address(RVA = "0xCA52D8", Offset = "0xCA52D8", VA = "0xCA52D8")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xCA4C8C", Offset = "0xCA4C8C", VA = "0xCA4C8C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xCA4D84", Offset = "0xCA4D84", VA = "0xCA4D84")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xCA4EE0", Offset = "0xCA4EE0", VA = "0xCA4EE0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xCA50A4", Offset = "0xCA50A4", VA = "0xCA50A4")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xCA5190", Offset = "0xCA5190", VA = "0xCA5190", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xCA52C8", Offset = "0xCA52C8", VA = "0xCA52C8")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xCA5338", Offset = "0xCA5338", VA = "0xCA5338")]
		private void Start()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xCA53B0", Offset = "0xCA53B0", VA = "0xCA53B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xCA5480", Offset = "0xCA5480", VA = "0xCA5480")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xCA55C8", Offset = "0xCA55C8", VA = "0xCA55C8")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000160")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000161")]
		public class EffectorLink
		{
			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000937")]
			[Address(RVA = "0xCA5848", Offset = "0xCA5848", VA = "0xCA5848")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000934")]
		[Address(RVA = "0xCA55DC", Offset = "0xCA55DC", VA = "0xCA55DC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xCA56C8", Offset = "0xCA56C8", VA = "0xCA56C8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xCA5840", Offset = "0xCA5840", VA = "0xCA5840")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000162")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight of this script.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000938")]
		[Address(RVA = "0xCA5858", Offset = "0xCA5858", VA = "0xCA5858")]
		private void Start()
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0xCA5B6C", Offset = "0xCA5B6C", VA = "0xCA5B6C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0xCA6368", Offset = "0xCA6368", VA = "0xCA6368")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000163")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000136")]
		private bool holding
		{
			[Token(Token = "0x6000942")]
			[Address(RVA = "0xCA65E8", Offset = "0xCA65E8", VA = "0xCA65E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0xCA63D4", Offset = "0xCA63D4", VA = "0xCA63D4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600093C")]
		protected abstract void RotatePivot();

		[Token(Token = "0x600093D")]
		[Address(RVA = "0xCA6608", Offset = "0xCA6608", VA = "0xCA6608")]
		private void Start()
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0xCA67F8", Offset = "0xCA67F8", VA = "0xCA67F8")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0xCA6968", Offset = "0xCA6968", VA = "0xCA6968")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0xCA6A38", Offset = "0xCA6A38", VA = "0xCA6A38")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0xCA6B58", Offset = "0xCA6B58", VA = "0xCA6B58")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0xCA6CCC", Offset = "0xCA6CCC", VA = "0xCA6CCC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0xCA6F08", Offset = "0xCA6F08", VA = "0xCA6F08")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000164")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000945")]
		[Address(RVA = "0xCA6F1C", Offset = "0xCA6F1C", VA = "0xCA6F1C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0xCA70FC", Offset = "0xCA70FC", VA = "0xCA70FC")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000165")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000947")]
		[Address(RVA = "0xCA7110", Offset = "0xCA7110", VA = "0xCA7110", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0xCA7224", Offset = "0xCA7224", VA = "0xCA7224")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000166")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xCA7238", Offset = "0xCA7238", VA = "0xCA7238")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xCA72D0", Offset = "0xCA72D0", VA = "0xCA72D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xCA73E8", Offset = "0xCA73E8", VA = "0xCA73E8")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000167")]
	[RequireComponent(typeof(Recoil))]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xCA73F0", Offset = "0xCA73F0", VA = "0xCA73F0")]
		private void Start()
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xCA7448", Offset = "0xCA7448", VA = "0xCA7448")]
		private void Update()
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xCA7494", Offset = "0xCA7494", VA = "0xCA7494")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xCA752C", Offset = "0xCA752C", VA = "0xCA752C")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000169")]
		[CompilerGenerated]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x400099C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x17000137")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000957")]
				[Address(RVA = "0xCA78A4", Offset = "0xCA78A4", VA = "0xCA78A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000138")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000959")]
				[Address(RVA = "0xCA78EC", Offset = "0xCA78EC", VA = "0xCA78EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000954")]
			[Address(RVA = "0xCA76C0", Offset = "0xCA76C0", VA = "0xCA76C0")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0xCA76F8", Offset = "0xCA76F8", VA = "0xCA76F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0xCA76FC", Offset = "0xCA76FC", VA = "0xCA76FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000958")]
			[Address(RVA = "0xCA78AC", Offset = "0xCA78AC", VA = "0xCA78AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000950")]
		[Address(RVA = "0xCA753C", Offset = "0xCA753C", VA = "0xCA753C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xCA7600", Offset = "0xCA7600", VA = "0xCA7600")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0xCA763C", Offset = "0xCA763C", VA = "0xCA763C")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xCA76E8", Offset = "0xCA76E8", VA = "0xCA76E8")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x200016A")]
	[RequireComponent(typeof(Animator))]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x200016B")]
		[CompilerGenerated]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x17000139")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000960")]
				[Address(RVA = "0xCA7B90", Offset = "0xCA7B90", VA = "0xCA7B90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000962")]
				[Address(RVA = "0xCA7BD8", Offset = "0xCA7BD8", VA = "0xCA7BD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600095D")]
			[Address(RVA = "0xCA7A1C", Offset = "0xCA7A1C", VA = "0xCA7A1C")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600095E")]
			[Address(RVA = "0xCA7A4C", Offset = "0xCA7A4C", VA = "0xCA7A4C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600095F")]
			[Address(RVA = "0xCA7A50", Offset = "0xCA7A50", VA = "0xCA7A50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000961")]
			[Address(RVA = "0xCA7B98", Offset = "0xCA7B98", VA = "0xCA7B98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x600095A")]
		[Address(RVA = "0xCA78F4", Offset = "0xCA78F4", VA = "0xCA78F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0xCA79A8", Offset = "0xCA79A8", VA = "0xCA79A8")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0xCA7A44", Offset = "0xCA7A44", VA = "0xCA7A44")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x200016C")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200016D")]
		public class EffectorLink
		{
			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x40009AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x40009AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x40009B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x40009B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x40009B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x40009B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x40009B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x40009B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x40009B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x6000967")]
			[Address(RVA = "0xCA7C44", Offset = "0xCA7C44", VA = "0xCA7C44")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000968")]
			[Address(RVA = "0xCA8818", Offset = "0xCA8818", VA = "0xCA8818")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0xCA804C", Offset = "0xCA804C", VA = "0xCA804C")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600096A")]
			[Address(RVA = "0xCA88F4", Offset = "0xCA88F4", VA = "0xCA88F4")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600096B")]
			[Address(RVA = "0xCA89D8", Offset = "0xCA89D8", VA = "0xCA89D8")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600096C")]
			[Address(RVA = "0xCA8A64", Offset = "0xCA8A64", VA = "0xCA8A64")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600096D")]
			[Address(RVA = "0xCA8AEC", Offset = "0xCA8AEC", VA = "0xCA8AEC")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600096E")]
			[Address(RVA = "0xCA8604", Offset = "0xCA8604", VA = "0xCA8604")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600096F")]
			[Address(RVA = "0xCA8B74", Offset = "0xCA8B74", VA = "0xCA8B74")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000963")]
		[Address(RVA = "0xCA7BE0", Offset = "0xCA7BE0", VA = "0xCA7BE0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0xCA7FEC", Offset = "0xCA7FEC", VA = "0xCA7FEC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0xCA8554", Offset = "0xCA8554", VA = "0xCA8554")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xCA8810", Offset = "0xCA8810", VA = "0xCA8810")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200016E")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The amount of motion to transfer.")]
		[Range(0f, 1f)]
		public float transferMotion;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000970")]
		[Address(RVA = "0xCA8BA8", Offset = "0xCA8BA8", VA = "0xCA8BA8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0xCA8BD8", Offset = "0xCA8BD8", VA = "0xCA8BD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0xCA8C88", Offset = "0xCA8C88", VA = "0xCA8C88")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200016F")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x6000973")]
		[Address(RVA = "0xCA8C9C", Offset = "0xCA8C9C", VA = "0xCA8C9C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0xCA8EB4", Offset = "0xCA8EB4", VA = "0xCA8EB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0xCA9150", Offset = "0xCA9150", VA = "0xCA9150")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0xCA9218", Offset = "0xCA9218", VA = "0xCA9218")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0xCA9344", Offset = "0xCA9344", VA = "0xCA9344")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x2000170")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000978")]
		[Address(RVA = "0xCA934C", Offset = "0xCA934C", VA = "0xCA934C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0xCA9464", Offset = "0xCA9464", VA = "0xCA9464")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0xCA962C", Offset = "0xCA962C", VA = "0xCA962C")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000171")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x600097B")]
		[Address(RVA = "0xCA9648", Offset = "0xCA9648", VA = "0xCA9648")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0xCA9850", Offset = "0xCA9850", VA = "0xCA9850")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0xCA98BC", Offset = "0xCA98BC", VA = "0xCA98BC")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000173")]
		[CompilerGenerated]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x1700013B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000987")]
				[Address(RVA = "0xCAA02C", Offset = "0xCAA02C", VA = "0xCAA02C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000989")]
				[Address(RVA = "0xCAA074", Offset = "0xCAA074", VA = "0xCAA074", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000984")]
			[Address(RVA = "0xCA9CB4", Offset = "0xCA9CB4", VA = "0xCA9CB4")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0xCA9EA4", Offset = "0xCA9EA4", VA = "0xCA9EA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000986")]
			[Address(RVA = "0xCA9EA8", Offset = "0xCA9EA8", VA = "0xCA9EA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000988")]
			[Address(RVA = "0xCAA034", Offset = "0xCAA034", VA = "0xCAA034", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x40009CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x600097E")]
		[Address(RVA = "0xCA98C4", Offset = "0xCA98C4", VA = "0xCA98C4")]
		private void Start()
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0xCA9A00", Offset = "0xCA9A00", VA = "0xCA9A00")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0xCA998C", Offset = "0xCA998C", VA = "0xCA998C")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0xCA9CDC", Offset = "0xCA9CDC", VA = "0xCA9CDC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0xCA9DB4", Offset = "0xCA9DB4", VA = "0xCA9DB4")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0xCA9E88", Offset = "0xCA9E88", VA = "0xCA9E88")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000174")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x600098A")]
		[Address(RVA = "0xCAA07C", Offset = "0xCAA07C", VA = "0xCAA07C")]
		private void Start()
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0xCAA0E4", Offset = "0xCAA0E4", VA = "0xCAA0E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0xCAA190", Offset = "0xCAA190", VA = "0xCAA190")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x2000175")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000176")]
		public class Part
		{
			[Token(Token = "0x40009D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40009D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x600098F")]
			[Address(RVA = "0xCAA204", Offset = "0xCAA204", VA = "0xCAA204")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000990")]
			[Address(RVA = "0xCAA340", Offset = "0xCAA340", VA = "0xCAA340")]
			public Part()
			{
			}
		}

		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x600098D")]
		[Address(RVA = "0xCAA1A0", Offset = "0xCAA1A0", VA = "0xCAA1A0")]
		private void Update()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0xCAA338", Offset = "0xCAA338", VA = "0xCAA338")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000177")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40009DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000991")]
		[Address(RVA = "0xCAA348", Offset = "0xCAA348", VA = "0xCAA348")]
		private void Update()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0xCAA498", Offset = "0xCAA498", VA = "0xCAA498")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0xCAA5FC", Offset = "0xCAA5FC", VA = "0xCAA5FC")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000178")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the VRIK component on the avatar.")]
		public VRIK ik;

		[Token(Token = "0x40009DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The settings for VRIK calibration.")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x40009DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The HMD.")]
		public Transform headTracker;

		[Token(Token = "0x40009E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
		public Transform bodyTracker;

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
		public Transform leftHandTracker;

		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
		public Transform rightHandTracker;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
		public Transform leftFootTracker;

		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
		public Transform rightFootTracker;

		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x6000994")]
		[Address(RVA = "0xCAA60C", Offset = "0xCAA60C", VA = "0xCAA60C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0xCAA76C", Offset = "0xCAA76C", VA = "0xCAA76C")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000179")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000996")]
		[Address(RVA = "0xCAA7E0", Offset = "0xCAA7E0", VA = "0xCAA7E0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0xCAA830", Offset = "0xCAA830", VA = "0xCAA830")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xCAAA08", Offset = "0xCAAA08", VA = "0xCAAA08")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xCAAA60", Offset = "0xCAAA60", VA = "0xCAAA60")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xCAAF90", Offset = "0xCAAF90", VA = "0xCAAF90")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x200017B")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x1700013D")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x600099C")]
			[Address(RVA = "0xCAB00C", Offset = "0xCAB00C", VA = "0xCAB00C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0xCAAFEC", Offset = "0xCAAFEC", VA = "0xCAAFEC", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0xCAB014", Offset = "0xCAB014", VA = "0xCAB014")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xCAB074", Offset = "0xCAB074", VA = "0xCAB074", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0xCA0070", Offset = "0xCA0070", VA = "0xCA0070", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0xCAB464", Offset = "0xCAB464", VA = "0xCAB464", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xCAB1F8", Offset = "0xCAB1F8", VA = "0xCAB1F8")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xCAB474", Offset = "0xCAB474", VA = "0xCAB474")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200017C")]
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xCAB48C", Offset = "0xCAB48C", VA = "0xCAB48C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xCAB4EC", Offset = "0xCAB4EC", VA = "0xCAB4EC", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0xCAB57C", Offset = "0xCAB57C", VA = "0xCAB57C")]
		private void Update()
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0xCAB6A0", Offset = "0xCAB6A0", VA = "0xCAB6A0")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200017D")]
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Range(0.1f, 3f)]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000A02")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000A03")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x1700013E")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60009A9")]
			[Address(RVA = "0xCAB6D4", Offset = "0xCAB6D4", VA = "0xCAB6D4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xC9FCA4", Offset = "0xC9FCA4", VA = "0xC9FCA4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xCAB6B8", Offset = "0xCAB6B8", VA = "0xCAB6B8", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xCAB7C8", Offset = "0xCAB7C8", VA = "0xCAB7C8", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0xCABB9C", Offset = "0xCABB9C", VA = "0xCABB9C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xCA0194", Offset = "0xCA0194", VA = "0xCA0194")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200017E")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Base Parameters")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		public Transform gravityTarget;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		public float gravityMultiplier;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x4000A0F")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60009AD")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xCABCC4", Offset = "0xCABCC4", VA = "0xCABCC4")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xCABEB0", Offset = "0xCABEB0", VA = "0xCABEB0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xCAC0DC", Offset = "0xCAC0DC", VA = "0xCAC0DC", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xCAC27C", Offset = "0xCAC27C", VA = "0xCAC27C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xCAC2DC", Offset = "0xCAC2DC", VA = "0xCAC2DC")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xCAC440", Offset = "0xCAC440", VA = "0xCAC440")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xCAC644", Offset = "0xCAC644", VA = "0xCAC644")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xCAC668", Offset = "0xCAC668", VA = "0xCAC668")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xCAC68C", Offset = "0xCAC68C", VA = "0xCAC68C")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0xCAC7D8", Offset = "0xCAC7D8", VA = "0xCAC7D8")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x200017F")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000180")]
		public enum MoveMode
		{
			[Token(Token = "0x4000A4C")]
			Directional,
			[Token(Token = "0x4000A4D")]
			Strafe
		}

		[Token(Token = "0x2000181")]
		public struct AnimState
		{
			[Token(Token = "0x4000A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x4000A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x2000182")]
		[CompilerGenerated]
		private sealed class <JumpSmooth>d__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x4000A58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x4000A59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x4000A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x17000140")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009CD")]
				[Address(RVA = "0xCAF1D8", Offset = "0xCAF1D8", VA = "0xCAF1D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000141")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009CF")]
				[Address(RVA = "0xCAF220", Offset = "0xCAF220", VA = "0xCAF220", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009CA")]
			[Address(RVA = "0xCAEFAC", Offset = "0xCAEFAC", VA = "0xCAEFAC")]
			[DebuggerHidden]
			public <JumpSmooth>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x60009CB")]
			[Address(RVA = "0xCAF0D4", Offset = "0xCAF0D4", VA = "0xCAF0D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0xCAF0D8", Offset = "0xCAF0D8", VA = "0xCAF0D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0xCAF1E0", Offset = "0xCAF1E0", VA = "0xCAF1E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Header("Jumping and Falling")]
		public bool smoothJump;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Header("Wall Running")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x4000A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x4000A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool fixedFrame;

		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float wallRunEndTime;

		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Vector3 gravity;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float velocityY;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool doubleJumped;

		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		private bool jumpReleased;

		[Token(Token = "0x1700013F")]
		public bool onGround
		{
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0xCAC7F8", Offset = "0xCAC7F8", VA = "0xCAC7F8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009B9")]
			[Address(RVA = "0xCAC800", Offset = "0xCAC800", VA = "0xCAC800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xCAC80C", Offset = "0xCAC80C", VA = "0xCAC80C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xCACA00", Offset = "0xCACA00", VA = "0xCACA00")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0xCACA84", Offset = "0xCACA84", VA = "0xCACA84", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xCACB34", Offset = "0xCACB34", VA = "0xCACB34")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xCADB30", Offset = "0xCADB30", VA = "0xCADB30", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0xCADFC0", Offset = "0xCADFC0", VA = "0xCADFC0", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0xCAD1F4", Offset = "0xCAD1F4", VA = "0xCAD1F4")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0xCAE098", Offset = "0xCAE098", VA = "0xCAE098")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0xCAE724", Offset = "0xCAE724", VA = "0xCAE724")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0xCADBBC", Offset = "0xCADBBC", VA = "0xCADBBC")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0xCAE814", Offset = "0xCAE814", VA = "0xCAE814", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0xCAEC98", Offset = "0xCAEC98", VA = "0xCAEC98")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0xCAEDC0", Offset = "0xCAEDC0", VA = "0xCAEDC0", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0xCAEF14", Offset = "0xCAEF14", VA = "0xCAEF14")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__74))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0xCAD5D0", Offset = "0xCAD5D0", VA = "0xCAD5D0")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0xCAEFD4", Offset = "0xCAEFD4", VA = "0xCAEFD4")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000183")]
	[RequireComponent(typeof(Animator))]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000184")]
		public enum RotationMode
		{
			[Token(Token = "0x4000A69")]
			Smooth,
			[Token(Token = "0x4000A6A")]
			Linear
		}

		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The component that updates the camera.")]
		public CameraController cameraController;

		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Acceleration of movement.")]
		public float accelerationTime;

		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Turning speed.")]
		public float turnTime;

		[Token(Token = "0x4000A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		public bool walkByDefault;

		[Token(Token = "0x4000A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Smooth or linear rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		public float moveSpeed;

		[Token(Token = "0x4000A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x4000A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x17000142")]
		public bool isGrounded
		{
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0xCAF228", Offset = "0xCAF228", VA = "0xCAF228")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009D1")]
			[Address(RVA = "0xCAF230", Offset = "0xCAF230", VA = "0xCAF230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xCAF23C", Offset = "0xCAF23C", VA = "0xCAF23C")]
		private void Start()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xCAF2E4", Offset = "0xCAF2E4", VA = "0xCAF2E4")]
		private void Update()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xCAF8FC", Offset = "0xCAF8FC", VA = "0xCAF8FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xCAF32C", Offset = "0xCAF32C", VA = "0xCAF32C")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xCAF694", Offset = "0xCAF694", VA = "0xCAF694")]
		private void Move()
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0xCAF92C", Offset = "0xCAF92C", VA = "0xCAF92C")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0xCAF9C4", Offset = "0xCAF9C4", VA = "0xCAF9C4")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xCAFA44", Offset = "0xCAFA44", VA = "0xCAFA44")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000185")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000A6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000A6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xCAFA6C", Offset = "0xCAFA6C", VA = "0xCAFA6C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xCAFBB4", Offset = "0xCAFBB4", VA = "0xCAFBB4", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xCB022C", Offset = "0xCB022C", VA = "0xCB022C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xCB0418", Offset = "0xCB0418", VA = "0xCB0418")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000186")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000187")]
		public struct State
		{
			[Token(Token = "0x4000A74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000A75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000A76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000A77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000A78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000A6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000A70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000A71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xCAFAA8", Offset = "0xCAFAA8", VA = "0xCAFAA8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xCB0444", Offset = "0xCB0444", VA = "0xCB0444", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0xCB0434", Offset = "0xCB0434", VA = "0xCB0434")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000188")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xCB0788", Offset = "0xCB0788", VA = "0xCB0788")]
		private void Update()
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0xCB07C0", Offset = "0xCB07C0", VA = "0xCB07C0")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000189")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000A79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x4000A7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x4000A7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x4000A7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xCB07C8", Offset = "0xCB07C8", VA = "0xCB07C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xCB07F0", Offset = "0xCB07F0", VA = "0xCB07F0")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xCB0894", Offset = "0xCB0894", VA = "0xCB0894")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200018A")]
	public class Navigator
	{
		[Token(Token = "0x200018B")]
		public enum State
		{
			[Token(Token = "0x4000A8C")]
			Idle,
			[Token(Token = "0x4000A8D")]
			Seeking,
			[Token(Token = "0x4000A8E")]
			OnPath
		}

		[Token(Token = "0x4000A7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000A7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius;

		[Token(Token = "0x4000A7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000A80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance;

		[Token(Token = "0x4000A81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Interval of updating the path")]
		public float nextPathInterval;

		[Token(Token = "0x4000A84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000A85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x4000A86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000A87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000A88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000A89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000A8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x17000143")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0xCB08A8", Offset = "0xCB08A8", VA = "0xCB08A8")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0xCB08B4", Offset = "0xCB08B4", VA = "0xCB08B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public State state
		{
			[Token(Token = "0x60009E8")]
			[Address(RVA = "0xCB08C0", Offset = "0xCB08C0", VA = "0xCB08C0")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60009E9")]
			[Address(RVA = "0xCB08C8", Offset = "0xCB08C8", VA = "0xCB08C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xCAFADC", Offset = "0xCAFADC", VA = "0xCAFADC")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xCAFDD4", Offset = "0xCAFDD4", VA = "0xCAFDD4")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0xCB09A8", Offset = "0xCB09A8", VA = "0xCB09A8")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0xCB0A0C", Offset = "0xCB0A0C", VA = "0xCB0A0C")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xCB08D0", Offset = "0xCB08D0", VA = "0xCB08D0")]
		private void Stop()
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xCB092C", Offset = "0xCB092C", VA = "0xCB092C")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xCB0254", Offset = "0xCB0254", VA = "0xCB0254")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xCB0B40", Offset = "0xCB0B40", VA = "0xCB0B40")]
		public Navigator()
		{
		}
	}
}
