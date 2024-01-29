using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using Crosstales.Common.Model.Enum;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class EditorPrefsStrings
{
}
namespace VLB
{
	[Token(Token = "0x2000003")]
	public static class BatchingHelper
	{
		[Token(Token = "0x4000001")]
		public const bool isGpuInstancingSupported = true;

		[Token(Token = "0x17000001")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0xE1CE4C", Offset = "0xE1CE4C", VA = "0xE1CE4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xE1CEEC", Offset = "0xE1CEEC", VA = "0xE1CEEC")]
		public static bool IsGpuInstancingEnabled(Material material)
		{
			return default(bool);
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xE1CF00", Offset = "0xE1CF00", VA = "0xE1CF00")]
		public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xE1CF18", Offset = "0xE1CF18", VA = "0xE1CF18")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xE1D4A4", Offset = "0xE1D4A4", VA = "0xE1D4A4")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xE1D610", Offset = "0xE1D610", VA = "0xE1D610")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x2000004")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam.html")]
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
	{
		[Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class <CoUpdateFadeOut>d__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400000D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400000E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400000F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x1700000D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000037")]
				[Address(RVA = "0xE21BD0", Offset = "0xE21BD0", VA = "0xE21BD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000039")]
				[Address(RVA = "0xE21C18", Offset = "0xE21C18", VA = "0xE21C18", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000034")]
			[Address(RVA = "0xE1D97C", Offset = "0xE1D97C", VA = "0xE1D97C")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__31(int <>1__state)
			{
			}

			[Token(Token = "0x6000035")]
			[Address(RVA = "0xE21B30", Offset = "0xE21B30", VA = "0xE21B30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000036")]
			[Address(RVA = "0xE21B34", Offset = "0xE21B34", VA = "0xE21B34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000038")]
			[Address(RVA = "0xE21BD8", Offset = "0xE21BD8", VA = "0xE21BD8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_CustomMaterial;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private MaterialModifier.Callback m_MaterialModifierCallback;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Coroutine m_CoFadeOut;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int overrideLayer;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Camera m_CurrentCameraRenderingSRP;

		[Token(Token = "0x17000002")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0xE1D6E8", Offset = "0xE1D6E8", VA = "0xE1D6E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0xE1D6F0", Offset = "0xE1D6F0", VA = "0xE1D6F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0xE1D6F8", Offset = "0xE1D6F8", VA = "0xE1D6F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0xE1D700", Offset = "0xE1D700", VA = "0xE1D700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public Mesh coneMesh
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0xE1D708", Offset = "0xE1D708", VA = "0xE1D708")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0xE1D710", Offset = "0xE1D710", VA = "0xE1D710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public bool visible
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0xE1D718", Offset = "0xE1D718", VA = "0xE1D718")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0xE1D734", Offset = "0xE1D734", VA = "0xE1D734")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public int sortingLayerID
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0xE1D754", Offset = "0xE1D754", VA = "0xE1D754")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0xE1D770", Offset = "0xE1D770", VA = "0xE1D770")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public int sortingOrder
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0xE1D78C", Offset = "0xE1D78C", VA = "0xE1D78C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0xE1D7A8", Offset = "0xE1D7A8", VA = "0xE1D7A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0xE1D7C4", Offset = "0xE1D7C4", VA = "0xE1D7C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0xE1E0CC", Offset = "0xE1E0CC", VA = "0xE1E0CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0xE1E0D4", Offset = "0xE1E0D4", VA = "0xE1E0D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0xE1FF10", Offset = "0xE1FF10", VA = "0xE1FF10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0xE20004", Offset = "0xE20004", VA = "0xE20004")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xE1D7D4", Offset = "0xE1D7D4", VA = "0xE1D7D4")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xE1D908", Offset = "0xE1D908", VA = "0xE1D908")]
		[IteratorStateMachine(typeof(<CoUpdateFadeOut>d__31))]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xE1D9A4", Offset = "0xE1D9A4", VA = "0xE1D9A4")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xE1DAAC", Offset = "0xE1DAAC", VA = "0xE1DAAC")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xE1DDBC", Offset = "0xE1DDBC", VA = "0xE1DDBC")]
		public void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xE1DE9C", Offset = "0xE1DE9C", VA = "0xE1DE9C")]
		private void Start()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xE1DF38", Offset = "0xE1DF38", VA = "0xE1DF38")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xE1DFD4", Offset = "0xE1DFD4", VA = "0xE1DFD4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xE1E14C", Offset = "0xE1E14C", VA = "0xE1E14C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xE1E248", Offset = "0xE1E248", VA = "0xE1E248")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xE1E9B4", Offset = "0xE1E9B4", VA = "0xE1E9B4")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xE1FCC8", Offset = "0xE1FCC8", VA = "0xE1FCC8")]
		private Vector3 ComputeLocalMatrix()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xE1E6DC", Offset = "0xE1E6DC", VA = "0xE1E6DC")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xE1DC1C", Offset = "0xE1DC1C", VA = "0xE1DC1C", Slot = "4")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xE20714", Offset = "0xE20714", VA = "0xE20714", Slot = "5")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xE2082C", Offset = "0xE2082C", VA = "0xE2082C", Slot = "6")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xE20944", Offset = "0xE20944", VA = "0xE20944", Slot = "7")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xE20A74", Offset = "0xE20A74", VA = "0xE20A74", Slot = "8")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xE1DB64", Offset = "0xE1DB64", VA = "0xE1DB64")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xE1DD04", Offset = "0xE1DD04", VA = "0xE1DD04")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xE20B50", Offset = "0xE20B50", VA = "0xE20B50")]
		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xE1F5A4", Offset = "0xE1F5A4", VA = "0xE1F5A4")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xE21320", Offset = "0xE21320", VA = "0xE21320")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xE21518", Offset = "0xE21518", VA = "0xE21518")]
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xE21524", Offset = "0xE21524", VA = "0xE21524")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xE21554", Offset = "0xE21554", VA = "0xE21554")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xE21638", Offset = "0xE21638", VA = "0xE21638")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xE21B20", Offset = "0xE21B20", VA = "0xE21B20")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000006")]
	[HelpURL("http://saladgamer.com/vlb-doc/config.html")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x4000010")]
		public const string ClassName = "Config";

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[FormerlySerializedAs("renderPipeline")]
		private RenderPipeline _RenderPipeline;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("renderingMode")]
		private RenderingMode _RenderingMode;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float ditheringFactor;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int sharedMeshSides;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int sharedMeshSegments;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0.01f, 2f)]
		public float globalNoiseScale;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string fadeOutCameraTag;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HighlightNull]
		public Texture3D noiseTexture3D;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture2D ditheringNoiseTexture;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public FeatureEnabledColorGradient featureEnabledColorGradient;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool featureEnabledDepthBlend;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		public bool featureEnabledNoise3D;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x76")]
		public bool featureEnabledDynamicOcclusion;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x77")]
		public bool featureEnabledMeshSkewing;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool featureEnabledShaderAccuracyHigh;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Material _DummyMaterial;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Shader _BeamShader;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Config ms_Instance;

		[Token(Token = "0x1700000F")]
		public RenderPipeline renderPipeline
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0xE21C20", Offset = "0xE21C20", VA = "0xE21C20")]
			get
			{
				return default(RenderPipeline);
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0xE21C28", Offset = "0xE21C28", VA = "0xE21C28")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public RenderingMode renderingMode
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0xE21C90", Offset = "0xE21C90", VA = "0xE21C90")]
			get
			{
				return default(RenderingMode);
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0xE21C98", Offset = "0xE21C98", VA = "0xE21C98")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xE1CE9C", Offset = "0xE1CE9C", VA = "0xE1CE9C")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000012")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0xE21D94", Offset = "0xE21D94", VA = "0xE21D94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		public bool requiresDoubleSidedMesh
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0xE1EC1C", Offset = "0xE1EC1C", VA = "0xE1EC1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000014")]
		public Shader beamShader
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0xE21DAC", Offset = "0xE21DAC", VA = "0xE21DAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0xE1DA38", Offset = "0xE1DA38", VA = "0xE1DA38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public bool hasRenderPipelineMismatch
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0xE21E54", Offset = "0xE21E54", VA = "0xE21E54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public static Config Instance
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0xE1CE94", Offset = "0xE1CE94", VA = "0xE1CE94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xE21D00", Offset = "0xE21D00", VA = "0xE21D00")]
		public bool IsSRPBatcherSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xE21DB4", Offset = "0xE21DB4", VA = "0xE21DB4")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xE21E80", Offset = "0xE21E80", VA = "0xE21E80")]
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xE22020", Offset = "0xE22020", VA = "0xE22020")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xE21F64", Offset = "0xE21F64", VA = "0xE21F64")]
		private void RefreshGlobalShaderProperties()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xE2212C", Offset = "0xE2212C", VA = "0xE2212C")]
		public void ResetInternalData()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xE22328", Offset = "0xE22328", VA = "0xE22328")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xE224C8", Offset = "0xE224C8", VA = "0xE224C8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xE224D4", Offset = "0xE224D4", VA = "0xE224D4")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xE224D8", Offset = "0xE224D8", VA = "0xE224D8")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xE22654", Offset = "0xE22654", VA = "0xE22654")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000007")]
	[HelpURL("http://saladgamer.com/vlb-doc/config.html")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x400002B")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xE22764", Offset = "0xE22764", VA = "0xE22764")]
		public ConfigOverride()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public static class Consts
	{
		[Token(Token = "0x2000009")]
		public static class Help
		{
			[Token(Token = "0x400002D")]
			private const string UrlBase = "http://saladgamer.com/vlb-doc/";

			[Token(Token = "0x400002E")]
			private const string UrlSuffix = ".html";

			[Token(Token = "0x400002F")]
			public const string UrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam.html";

			[Token(Token = "0x4000030")]
			public const string UrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles.html";

			[Token(Token = "0x4000031")]
			public const string UrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting.html";

			[Token(Token = "0x4000032")]
			public const string UrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer.html";

			[Token(Token = "0x4000033")]
			public const string UrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone.html";

			[Token(Token = "0x4000034")]
			public const string UrlSkewingHandle = "http://saladgamer.com/vlb-doc/comp-skewinghandle.html";

			[Token(Token = "0x4000035")]
			public const string UrlEffectFlicker = "http://saladgamer.com/vlb-doc/comp-effect-flicker.html";

			[Token(Token = "0x4000036")]
			public const string UrlEffectPulse = "http://saladgamer.com/vlb-doc/comp-effect-pulse.html";

			[Token(Token = "0x4000037")]
			public const string UrlConfig = "http://saladgamer.com/vlb-doc/config.html";
		}

		[Token(Token = "0x200000A")]
		public static class Internal
		{
			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly bool ProceduralObjectsVisibleInEditor;

			[Token(Token = "0x17000018")]
			public static HideFlags ProceduralObjectsHideFlags
			{
				[Token(Token = "0x6000051")]
				[Address(RVA = "0xE1E56C", Offset = "0xE1E56C", VA = "0xE1E56C")]
				get
				{
					return default(HideFlags);
				}
			}
		}

		[Token(Token = "0x200000B")]
		public static class Beam
		{
			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Color FlatColor;

			[Token(Token = "0x400003A")]
			public const ColorMode ColorModeDefault = ColorMode.Flat;

			[Token(Token = "0x400003B")]
			public const float IntensityDefault = 1f;

			[Token(Token = "0x400003C")]
			public const float IntensityMin = 0f;

			[Token(Token = "0x400003D")]
			public const float SpotAngleDefault = 35f;

			[Token(Token = "0x400003E")]
			public const float SpotAngleMin = 0.1f;

			[Token(Token = "0x400003F")]
			public const float SpotAngleMax = 179.9f;

			[Token(Token = "0x4000040")]
			public const float ConeRadiusStart = 0.1f;

			[Token(Token = "0x4000041")]
			public const MeshType GeomMeshType = MeshType.Shared;

			[Token(Token = "0x4000042")]
			public const int GeomSidesDefault = 18;

			[Token(Token = "0x4000043")]
			public const int GeomSidesMin = 3;

			[Token(Token = "0x4000044")]
			public const int GeomSidesMax = 256;

			[Token(Token = "0x4000045")]
			public const int GeomSegmentsDefault = 5;

			[Token(Token = "0x4000046")]
			public const int GeomSegmentsMin = 0;

			[Token(Token = "0x4000047")]
			public const int GeomSegmentsMax = 64;

			[Token(Token = "0x4000048")]
			public const bool GeomCap = false;

			[Token(Token = "0x4000049")]
			public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

			[Token(Token = "0x400004A")]
			public const float AttenuationCustomBlending = 0.5f;

			[Token(Token = "0x400004B")]
			public const float FallOffStart = 0f;

			[Token(Token = "0x400004C")]
			public const float FallOffEnd = 3f;

			[Token(Token = "0x400004D")]
			public const float FallOffDistancesMinThreshold = 0.01f;

			[Token(Token = "0x400004E")]
			public const float DepthBlendDistance = 2f;

			[Token(Token = "0x400004F")]
			public const float CameraClippingDistance = 0.5f;

			[Token(Token = "0x4000050")]
			public const float FresnelPowMaxValue = 10f;

			[Token(Token = "0x4000051")]
			public const float FresnelPow = 8f;

			[Token(Token = "0x4000052")]
			public const float GlareFrontal = 0.5f;

			[Token(Token = "0x4000053")]
			public const float GlareBehind = 0.5f;

			[Token(Token = "0x4000054")]
			public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

			[Token(Token = "0x4000055")]
			public const float NoiseIntensityMin = 0f;

			[Token(Token = "0x4000056")]
			public const float NoiseIntensityMax = 1f;

			[Token(Token = "0x4000057")]
			public const float NoiseIntensityDefault = 0.5f;

			[Token(Token = "0x4000058")]
			public const float NoiseScaleMin = 0.01f;

			[Token(Token = "0x4000059")]
			public const float NoiseScaleMax = 2f;

			[Token(Token = "0x400005A")]
			public const float NoiseScaleDefault = 0.5f;

			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly Vector3 NoiseVelocityDefault;

			[Token(Token = "0x400005C")]
			public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

			[Token(Token = "0x400005D")]
			public const ShaderAccuracy ShaderAccuracyDefault = ShaderAccuracy.Fast;

			[Token(Token = "0x400005E")]
			public const float FadeOutBeginDefault = -150f;

			[Token(Token = "0x400005F")]
			public const float FadeOutEndDefault = -200f;

			[Token(Token = "0x4000060")]
			public const Dimensions DimensionsDefault = Dimensions.Dim3D;

			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static readonly Vector2 TiltDefault;

			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public static readonly Vector3 SkewingLocalForwardDirectionDefault;

			[Token(Token = "0x4000063")]
			public const Transform ClippingPlaneTransformDefault = null;
		}

		[Token(Token = "0x200000C")]
		public static class DustParticles
		{
			[Token(Token = "0x4000064")]
			public const float AlphaDefault = 0.5f;

			[Token(Token = "0x4000065")]
			public const float SizeDefault = 0.01f;

			[Token(Token = "0x4000066")]
			public const ParticlesDirection DirectionDefault = ParticlesDirection.Random;

			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Vector3 VelocityDefault;

			[Token(Token = "0x4000068")]
			public const float DensityDefault = 5f;

			[Token(Token = "0x4000069")]
			public const float DensityMin = 0f;

			[Token(Token = "0x400006A")]
			public const float DensityMax = 1000f;

			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly MinMaxRangeFloat SpawnDistanceRangeDefault;

			[Token(Token = "0x400006C")]
			public const bool CullingEnabledDefault = false;

			[Token(Token = "0x400006D")]
			public const float CullingMaxDistanceDefault = 10f;

			[Token(Token = "0x400006E")]
			public const float CullingMaxDistanceMin = 1f;
		}

		[Token(Token = "0x200000D")]
		public static class DynOcclusion
		{
			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly LayerMask LayerMaskDefault;

			[Token(Token = "0x4000070")]
			public const float FadeDistanceToSurfaceDefault = 0.25f;

			[Token(Token = "0x4000071")]
			public const DynamicOcclusionUpdateRate UpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames;

			[Token(Token = "0x4000072")]
			public const int WaitFramesCountDefault = 3;

			[Token(Token = "0x4000073")]
			public const Dimensions RaycastingDimensionsDefault = Dimensions.Dim3D;

			[Token(Token = "0x4000074")]
			public const bool RaycastingConsiderTriggersDefault = false;

			[Token(Token = "0x4000075")]
			public const float RaycastingMinOccluderAreaDefault = 0f;

			[Token(Token = "0x4000076")]
			public const float RaycastingMinSurfaceRatioDefault = 0.5f;

			[Token(Token = "0x4000077")]
			public const float RaycastingMinSurfaceRatioMin = 50f;

			[Token(Token = "0x4000078")]
			public const float RaycastingMinSurfaceRatioMax = 100f;

			[Token(Token = "0x4000079")]
			public const float RaycastingMaxSurfaceDotDefault = 0.25f;

			[Token(Token = "0x400007A")]
			public const float RaycastingMaxSurfaceAngleMin = 45f;

			[Token(Token = "0x400007B")]
			public const float RaycastingMaxSurfaceAngleMax = 90f;

			[Token(Token = "0x400007C")]
			public const PlaneAlignment RaycastingPlaneAlignmentDefault = PlaneAlignment.Surface;

			[Token(Token = "0x400007D")]
			public const float RaycastingPlaneOffsetDefault = 0.1f;

			[Token(Token = "0x400007E")]
			public const int DepthBufferDepthMapResolutionDefault = 32;

			[Token(Token = "0x400007F")]
			public const bool DepthBufferOcclusionCullingDefault = true;
		}

		[Token(Token = "0x200000E")]
		public static class Effects
		{
			[Token(Token = "0x4000080")]
			public const EffectAbstractBase.ComponentsToChange ComponentsToChangeDefault = (EffectAbstractBase.ComponentsToChange)2147483647;

			[Token(Token = "0x4000081")]
			public const bool RestoreBaseIntensityDefault = true;

			[Token(Token = "0x4000082")]
			public const float FrequencyDefault = 10f;

			[Token(Token = "0x4000083")]
			public const bool PerformPausesDefault = false;

			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly MinMaxRangeFloat FlickeringDurationDefault;

			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly MinMaxRangeFloat PauseDurationDefault;

			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly MinMaxRangeFloat IntensityAmplitudeDefault;

			[Token(Token = "0x4000087")]
			public const float SmoothingDefault = 0.05f;
		}

		[Token(Token = "0x200000F")]
		public static class Config
		{
			[Token(Token = "0x4000088")]
			public const bool GeometryOverrideLayerDefault = true;

			[Token(Token = "0x4000089")]
			public const int GeometryLayerIDDefault = 1;

			[Token(Token = "0x400008A")]
			public const string GeometryTagDefault = "Untagged";

			[Token(Token = "0x400008B")]
			public const string FadeOutCameraTagDefault = "MainCamera";

			[Token(Token = "0x400008C")]
			public const RenderQueue GeometryRenderQueueDefault = RenderQueue.Transparent;

			[Token(Token = "0x400008D")]
			public const RenderPipeline GeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

			[Token(Token = "0x400008E")]
			public const RenderingMode GeometryRenderingModeDefault = RenderingMode.SinglePass;

			[Token(Token = "0x400008F")]
			public const int Noise3DSizeDefault = 64;

			[Token(Token = "0x4000090")]
			public const int SharedMeshSides = 24;

			[Token(Token = "0x4000091")]
			public const int SharedMeshSegments = 5;

			[Token(Token = "0x4000092")]
			public const float DitheringFactor = 0f;

			[Token(Token = "0x4000093")]
			public const bool FeatureEnabledDefault = true;

			[Token(Token = "0x4000094")]
			public const FeatureEnabledColorGradient FeatureEnabledColorGradientDefault = FeatureEnabledColorGradient.HighOnly;
		}

		[Token(Token = "0x400002C")]
		public const string PluginFolder = "Plugins/VolumetricLightBeam";
	}
	[Token(Token = "0x2000010")]
	public static class DummyMaterial
	{
	}
	[Token(Token = "0x2000011")]
	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeam))]
	public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x2000012")]
		protected enum ProcessOcclusionSource
		{
			[Token(Token = "0x400009F")]
			RenderLoop,
			[Token(Token = "0x40000A0")]
			OnEnable,
			[Token(Token = "0x40000A1")]
			EditorUpdate,
			[Token(Token = "0x40000A2")]
			User
		}

		[Token(Token = "0x4000095")]
		public const string ClassName = "DynamicOcclusionAbstractBase";

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicOcclusionUpdateRate updateRate;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[FormerlySerializedAs("waitFrameCount")]
		public int waitXFrames;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool _INTERNAL_ApplyRandomFrameOffset;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TransformUtils.Packed m_TransformPacked;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_LastFrameRendered;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected VolumetricLightBeam m_Master;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected MaterialModifier.Callback m_MaterialModifierCallbackCached;

		[Token(Token = "0x17000019")]
		public int _INTERNAL_LastFrameRendered
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0xE22DE0", Offset = "0xE22DE0", VA = "0xE22DE0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action onOcclusionProcessed
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xE22B70", Offset = "0xE22B70", VA = "0xE22B70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0xE22C0C", Offset = "0xE22C0C", VA = "0xE22C0C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xE229E0", Offset = "0xE229E0", VA = "0xE229E0")]
		public void ProcessOcclusionManually()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xE229E8", Offset = "0xE229E8", VA = "0xE229E8")]
		protected void ProcessOcclusion(ProcessOcclusionSource source)
		{
		}

		[Token(Token = "0x600005C")]
		protected abstract string GetShaderKeyword();

		[Token(Token = "0x600005D")]
		protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

		[Token(Token = "0x600005E")]
		protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

		[Token(Token = "0x600005F")]
		protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

		[Token(Token = "0x6000060")]
		protected abstract void OnEnablePostValidate();

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xE22DE8", Offset = "0xE22DE8", VA = "0xE22DE8", Slot = "9")]
		protected virtual void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xE22E08", Offset = "0xE22E08", VA = "0xE22E08", Slot = "10")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xE22E88", Offset = "0xE22E88", VA = "0xE22E88", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xE22ED4", Offset = "0xE22ED4", VA = "0xE22ED4", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xE23494", Offset = "0xE23494", VA = "0xE23494", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xE235BC", Offset = "0xE235BC", VA = "0xE235BC")]
		private void OnWillCameraRender(Camera cam)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xE22EA4", Offset = "0xE22EA4", VA = "0xE22EA4")]
		private void DisableOcclusion()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xE237B0", Offset = "0xE237B0", VA = "0xE237B0")]
		protected DynamicOcclusionAbstractBase()
		{
		}
	}
	[Token(Token = "0x2000013")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer.html")]
	[ExecuteInEditMode]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x40000A3")]
		public new const string ClassName = "DynamicOcclusionDepthBuffer";

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LayerMask layerMask;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool useOcclusionCulling;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int depthMapResolution;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Camera m_DepthCamera;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_NeedToUpdateOcclusionNextFrame;

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xE23820", Offset = "0xE23820", VA = "0xE23820", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xE23860", Offset = "0xE23860", VA = "0xE23860", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xE23868", Offset = "0xE23868", VA = "0xE23868")]
		private void ProcessOcclusionInternal()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xE23A78", Offset = "0xE23A78", VA = "0xE23A78", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xE23AAC", Offset = "0xE23AAC", VA = "0xE23AAC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xE2388C", Offset = "0xE2388C", VA = "0xE2388C")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xE23C78", Offset = "0xE23C78", VA = "0xE23C78")]
		public bool HasLayerMaskIssues()
		{
			return default(bool);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xE23CDC", Offset = "0xE23CDC", VA = "0xE23CDC", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xE23D40", Offset = "0xE23D40", VA = "0xE23D40")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xE240E4", Offset = "0xE240E4", VA = "0xE240E4", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xE240E8", Offset = "0xE240E8", VA = "0xE240E8", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xE24180", Offset = "0xE24180", VA = "0xE24180", Slot = "10")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xE24184", Offset = "0xE24184", VA = "0xE24184", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xE2419C", Offset = "0xE2419C", VA = "0xE2419C")]
		private void DestroyDepthCamera()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xE242EC", Offset = "0xE242EC", VA = "0xE242EC", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xE24468", Offset = "0xE24468", VA = "0xE24468")]
		public DynamicOcclusionDepthBuffer()
		{
		}
	}
	[Token(Token = "0x2000015")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting.html")]
	[ExecuteInEditMode]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x2000016")]
		public struct HitResult
		{
			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 point;

			[Token(Token = "0x40000BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 normal;

			[Token(Token = "0x40000BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float distance;

			[Token(Token = "0x40000BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Collider2D collider2D;

			[Token(Token = "0x40000BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Collider collider3D;

			[Token(Token = "0x1700001E")]
			public bool hasCollider
			{
				[Token(Token = "0x600009C")]
				[Address(RVA = "0xE253A8", Offset = "0xE253A8", VA = "0xE253A8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700001F")]
			public string name
			{
				[Token(Token = "0x600009D")]
				[Address(RVA = "0xE25E88", Offset = "0xE25E88", VA = "0xE25E88")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000020")]
			public Bounds bounds
			{
				[Token(Token = "0x600009E")]
				[Address(RVA = "0xE25F4C", Offset = "0xE25F4C", VA = "0xE25F4C")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0xE250C0", Offset = "0xE250C0", VA = "0xE250C0")]
			public HitResult(ref RaycastHit hit3D)
			{
			}

			[Token(Token = "0x600009B")]
			[Address(RVA = "0xE2513C", Offset = "0xE2513C", VA = "0xE2513C")]
			public HitResult(ref RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x600009F")]
			[Address(RVA = "0xE247F0", Offset = "0xE247F0", VA = "0xE247F0")]
			public void SetNull()
			{
			}
		}

		[Token(Token = "0x2000017")]
		private enum Direction
		{
			[Token(Token = "0x40000C0")]
			Up = 0,
			[Token(Token = "0x40000C1")]
			Down = 1,
			[Token(Token = "0x40000C2")]
			Left = 2,
			[Token(Token = "0x40000C3")]
			Right = 3,
			[Token(Token = "0x40000C4")]
			Max2D = 1,
			[Token(Token = "0x40000C5")]
			Max3D = 3
		}

		[Token(Token = "0x40000AC")]
		public new const string ClassName = "DynamicOcclusionRaycasting";

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Dimensions dimensions;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public LayerMask layerMask;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool considerTriggers;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float minOccluderArea;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float minSurfaceRatio;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float maxSurfaceDot;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float planeOffset;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[FormerlySerializedAs("fadeDistanceToPlane")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private HitResult m_CurrentHit;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float m_RangeMultiplier;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x1700001A")]
		[Obsolete("Use 'fadeDistanceToSurface' instead")]
		public float fadeDistanceToPlane
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0xE24608", Offset = "0xE24608", VA = "0xE24608")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0xE24610", Offset = "0xE24610", VA = "0xE24610")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0xE24774", Offset = "0xE24774", VA = "0xE24774")]
			[CompilerGenerated]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x6000084")]
			[Address(RVA = "0xE24780", Offset = "0xE24780", VA = "0xE24780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xE249BC", Offset = "0xE249BC", VA = "0xE249BC")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x1700001D")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0xE249D0", Offset = "0xE249D0", VA = "0xE249D0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xE24618", Offset = "0xE24618", VA = "0xE24618")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xE2472C", Offset = "0xE2472C", VA = "0xE2472C", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xE2476C", Offset = "0xE2476C", VA = "0xE2476C", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xE2478C", Offset = "0xE2478C", VA = "0xE2478C", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xE247C8", Offset = "0xE247C8", VA = "0xE247C8", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xE24818", Offset = "0xE24818", VA = "0xE24818", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xE24860", Offset = "0xE24860", VA = "0xE24860")]
		private void Start()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xE2490C", Offset = "0xE2490C", VA = "0xE2490C")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xE24AF0", Offset = "0xE24AF0", VA = "0xE24AF0")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xE24B40", Offset = "0xE24B40", VA = "0xE24B40")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xE24D9C", Offset = "0xE24D9C", VA = "0xE24D9C")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xE251B8", Offset = "0xE251B8", VA = "0xE251B8")]
		private uint GetDirectionCount()
		{
			return default(uint);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xE251D0", Offset = "0xE251D0", VA = "0xE251D0")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xE25334", Offset = "0xE25334", VA = "0xE25334")]
		private bool IsHitValid(ref HitResult hit, Vector3 forwardVec)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xE25438", Offset = "0xE25438", VA = "0xE25438", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xE258DC", Offset = "0xE258DC", VA = "0xE258DC")]
		private void SetHit(ref HitResult hit)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xE24830", Offset = "0xE24830", VA = "0xE24830")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xE25A8C", Offset = "0xE25A8C", VA = "0xE25A8C", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xE259A0", Offset = "0xE259A0", VA = "0xE259A0")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xE25A54", Offset = "0xE25A54", VA = "0xE25A54")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xE25DBC", Offset = "0xE25DBC", VA = "0xE25DBC")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xE25DC8", Offset = "0xE25DC8", VA = "0xE25DC8")]
		public DynamicOcclusionRaycasting()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	public class EffectAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x2000019")]
		[Flags]
		public enum ComponentsToChange
		{
			[Token(Token = "0x40000D0")]
			UnityLight = 1,
			[Token(Token = "0x40000D1")]
			VolumetricLightBeam = 2,
			[Token(Token = "0x40000D2")]
			VolumetricDustParticles = 4
		}

		[Token(Token = "0x40000C6")]
		public const string ClassName = "EffectAbstractBase";

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ComponentsToChange componentsToChange;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool restoreBaseIntensity;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected VolumetricLightBeam m_Beam;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Light m_Light;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected VolumetricDustParticles m_Particles;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected float m_BaseIntensityBeamInside;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float m_BaseIntensityBeamOutside;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected float m_BaseIntensityLight;

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xE26034", Offset = "0xE26034", VA = "0xE26034")]
		protected void SetAdditiveIntensity(float additive)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xE26198", Offset = "0xE26198", VA = "0xE26198")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xE26330", Offset = "0xE26330", VA = "0xE26330", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xE26338", Offset = "0xE26338", VA = "0xE26338")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xE26368", Offset = "0xE26368", VA = "0xE26368")]
		public EffectAbstractBase()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-effect-flicker.html")]
	public class EffectFlicker : EffectAbstractBase
	{
		[Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class <CoUpdate>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectFlicker <>4__this;

			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <remaining>5__2;

			[Token(Token = "0x17000021")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000AD")]
				[Address(RVA = "0xE26724", Offset = "0xE26724", VA = "0xE26724", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000022")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000AF")]
				[Address(RVA = "0xE2676C", Offset = "0xE2676C", VA = "0xE2676C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000AA")]
			[Address(RVA = "0xE26420", Offset = "0xE26420", VA = "0xE26420")]
			[DebuggerHidden]
			public <CoUpdate>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60000AB")]
			[Address(RVA = "0xE26638", Offset = "0xE26638", VA = "0xE26638", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000AC")]
			[Address(RVA = "0xE2663C", Offset = "0xE2663C", VA = "0xE2663C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000AE")]
			[Address(RVA = "0xE2672C", Offset = "0xE2672C", VA = "0xE2672C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class <CoFlicker>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectFlicker <>4__this;

			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <remainingDuration>5__2;

			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <freqDuration>5__3;

			[Token(Token = "0x17000023")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000B3")]
				[Address(RVA = "0xE26850", Offset = "0xE26850", VA = "0xE26850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000024")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000B5")]
				[Address(RVA = "0xE26898", Offset = "0xE26898", VA = "0xE26898", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0xE264BC", Offset = "0xE264BC", VA = "0xE264BC")]
			[DebuggerHidden]
			public <CoFlicker>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60000B1")]
			[Address(RVA = "0xE26774", Offset = "0xE26774", VA = "0xE26774", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000B2")]
			[Address(RVA = "0xE26778", Offset = "0xE26778", VA = "0xE26778", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000B4")]
			[Address(RVA = "0xE26858", Offset = "0xE26858", VA = "0xE26858", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class <CoChangeIntensity>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectFlicker <>4__this;

			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float nextIntensity;

			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float expectedDuration;

			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <velocity>5__2;

			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <t>5__3;

			[Token(Token = "0x17000025")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000B9")]
				[Address(RVA = "0xE2698C", Offset = "0xE2698C", VA = "0xE2698C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000026")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000BB")]
				[Address(RVA = "0xE269D4", Offset = "0xE269D4", VA = "0xE269D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B6")]
			[Address(RVA = "0xE2656C", Offset = "0xE2656C", VA = "0xE2656C")]
			[DebuggerHidden]
			public <CoChangeIntensity>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60000B7")]
			[Address(RVA = "0xE268A0", Offset = "0xE268A0", VA = "0xE268A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000B8")]
			[Address(RVA = "0xE268A4", Offset = "0xE268A4", VA = "0xE268A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0xE26994", Offset = "0xE26994", VA = "0xE26994", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000D3")]
		public new const string ClassName = "EffectFlicker";

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(1f, 60f)]
		public float frequency;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool performPauses;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[MinMaxRange(0f, 10f)]
		public MinMaxRangeFloat flickeringDuration;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[MinMaxRange(0f, 10f)]
		public MinMaxRangeFloat pauseDuration;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[MinMaxRange(-5f, 5f)]
		public MinMaxRangeFloat intensityAmplitude;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Range(0f, 0.25f)]
		public float smoothing;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_CurrentAdditiveIntensity;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xE26380", Offset = "0xE26380", VA = "0xE26380", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xE263AC", Offset = "0xE263AC", VA = "0xE263AC")]
		[IteratorStateMachine(typeof(<CoUpdate>d__9))]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xE26448", Offset = "0xE26448", VA = "0xE26448")]
		[IteratorStateMachine(typeof(<CoFlicker>d__10))]
		private IEnumerator CoFlicker()
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xE264E4", Offset = "0xE264E4", VA = "0xE264E4")]
		[IteratorStateMachine(typeof(<CoChangeIntensity>d__11))]
		private IEnumerator CoChangeIntensity(float expectedDuration, float nextIntensity)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xE26594", Offset = "0xE26594", VA = "0xE26594")]
		public EffectFlicker()
		{
		}
	}
	[Token(Token = "0x200001E")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-effect-pulse.html")]
	public class EffectPulse : EffectAbstractBase
	{
		[Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class <CoUpdate>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectPulse <>4__this;

			[Token(Token = "0x40000F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000027")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000C2")]
				[Address(RVA = "0xE26C24", Offset = "0xE26C24", VA = "0xE26C24", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000028")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000C4")]
				[Address(RVA = "0xE26C6C", Offset = "0xE26C6C", VA = "0xE26C6C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000BF")]
			[Address(RVA = "0xE26A7C", Offset = "0xE26A7C", VA = "0xE26A7C")]
			[DebuggerHidden]
			public <CoUpdate>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60000C0")]
			[Address(RVA = "0xE26B24", Offset = "0xE26B24", VA = "0xE26B24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0xE26B28", Offset = "0xE26B28", VA = "0xE26B28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xE26C2C", Offset = "0xE26C2C", VA = "0xE26C2C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000EB")]
		public new const string ClassName = "EffectPulse";

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0.1f, 60f)]
		public float frequency;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[MinMaxRange(-5f, 5f)]
		public MinMaxRangeFloat intensityAmplitude;

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xE269DC", Offset = "0xE269DC", VA = "0xE269DC", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xE26A08", Offset = "0xE26A08", VA = "0xE26A08")]
		[IteratorStateMachine(typeof(<CoUpdate>d__4))]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xE26AA4", Offset = "0xE26AA4", VA = "0xE26AA4")]
		public EffectPulse()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public enum FeatureEnabledColorGradient
	{
		[Token(Token = "0x40000F3")]
		Off,
		[Token(Token = "0x40000F4")]
		HighOnly,
		[Token(Token = "0x40000F5")]
		HighAndLow
	}
	[Token(Token = "0x2000021")]
	public enum ColorMode
	{
		[Token(Token = "0x40000F7")]
		Flat,
		[Token(Token = "0x40000F8")]
		Gradient
	}
	[Token(Token = "0x2000022")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x40000FA")]
		Linear,
		[Token(Token = "0x40000FB")]
		Quadratic,
		[Token(Token = "0x40000FC")]
		Blend
	}
	[Token(Token = "0x2000023")]
	public enum BlendingMode
	{
		[Token(Token = "0x40000FE")]
		Additive,
		[Token(Token = "0x40000FF")]
		SoftAdditive,
		[Token(Token = "0x4000100")]
		TraditionalTransparency
	}
	[Token(Token = "0x2000024")]
	public enum ShaderAccuracy
	{
		[Token(Token = "0x4000102")]
		Fast,
		[Token(Token = "0x4000103")]
		High
	}
	[Token(Token = "0x2000025")]
	public enum NoiseMode
	{
		[Token(Token = "0x4000105")]
		Disabled,
		[Token(Token = "0x4000106")]
		WorldSpace,
		[Token(Token = "0x4000107")]
		LocalSpace
	}
	[Token(Token = "0x2000026")]
	public enum MeshType
	{
		[Token(Token = "0x4000109")]
		Shared,
		[Token(Token = "0x400010A")]
		Custom
	}
	[Token(Token = "0x2000027")]
	public enum RenderPipeline
	{
		[Token(Token = "0x400010C")]
		BuiltIn,
		[Token(Token = "0x400010D")]
		URP,
		[Token(Token = "0x400010E")]
		HDRP
	}
	[Token(Token = "0x2000028")]
	public enum RenderingMode
	{
		[Token(Token = "0x4000110")]
		MultiPass,
		[Token(Token = "0x4000111")]
		SinglePass,
		[Token(Token = "0x4000112")]
		GPUInstancing,
		[Token(Token = "0x4000113")]
		SRPBatcher
	}
	[Token(Token = "0x2000029")]
	public enum RenderQueue
	{
		[Token(Token = "0x4000115")]
		Custom = 0,
		[Token(Token = "0x4000116")]
		Background = 1000,
		[Token(Token = "0x4000117")]
		Geometry = 2000,
		[Token(Token = "0x4000118")]
		AlphaTest = 2450,
		[Token(Token = "0x4000119")]
		GeometryLast = 2500,
		[Token(Token = "0x400011A")]
		Transparent = 3000,
		[Token(Token = "0x400011B")]
		Overlay = 4000
	}
	[Token(Token = "0x200002A")]
	public enum Dimensions
	{
		[Token(Token = "0x400011D")]
		Dim3D,
		[Token(Token = "0x400011E")]
		Dim2D
	}
	[Token(Token = "0x200002B")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x4000120")]
		Surface,
		[Token(Token = "0x4000121")]
		Beam
	}
	[Token(Token = "0x200002C")]
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		[Token(Token = "0x4000123")]
		Never = 1,
		[Token(Token = "0x4000124")]
		OnEnable = 2,
		[Token(Token = "0x4000125")]
		OnBeamMove = 4,
		[Token(Token = "0x4000126")]
		EveryXFrames = 8,
		[Token(Token = "0x4000127")]
		OnBeamMoveAndEveryXFrames = 0xC
	}
	[Token(Token = "0x200002D")]
	public enum ParticlesDirection
	{
		[Token(Token = "0x4000129")]
		Random,
		[Token(Token = "0x400012A")]
		LocalSpace,
		[Token(Token = "0x400012B")]
		WorldSpace
	}
	[Token(Token = "0x200002E")]
	public static class GlobalMesh
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xE1F420", Offset = "0xE1F420", VA = "0xE1F420")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xE26C74", Offset = "0xE26C74", VA = "0xE26C74")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xE26D40", Offset = "0xE26D40", VA = "0xE26D40")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public static class MaterialManager
	{
		[Token(Token = "0x2000031")]
		public enum BlendingMode
		{
			[Token(Token = "0x4000135")]
			Additive,
			[Token(Token = "0x4000136")]
			SoftAdditive,
			[Token(Token = "0x4000137")]
			TraditionalTransparency,
			[Token(Token = "0x4000138")]
			Count
		}

		[Token(Token = "0x2000032")]
		public enum Noise3D
		{
			[Token(Token = "0x400013A")]
			Off,
			[Token(Token = "0x400013B")]
			On,
			[Token(Token = "0x400013C")]
			Count
		}

		[Token(Token = "0x2000033")]
		public enum DepthBlend
		{
			[Token(Token = "0x400013E")]
			Off,
			[Token(Token = "0x400013F")]
			On,
			[Token(Token = "0x4000140")]
			Count
		}

		[Token(Token = "0x2000034")]
		public enum ColorGradient
		{
			[Token(Token = "0x4000142")]
			Off,
			[Token(Token = "0x4000143")]
			MatrixLow,
			[Token(Token = "0x4000144")]
			MatrixHigh,
			[Token(Token = "0x4000145")]
			Count
		}

		[Token(Token = "0x2000035")]
		public enum DynamicOcclusion
		{
			[Token(Token = "0x4000147")]
			Off,
			[Token(Token = "0x4000148")]
			ClippingPlane,
			[Token(Token = "0x4000149")]
			DepthTexture,
			[Token(Token = "0x400014A")]
			Count
		}

		[Token(Token = "0x2000036")]
		public enum MeshSkewing
		{
			[Token(Token = "0x400014C")]
			Off,
			[Token(Token = "0x400014D")]
			On,
			[Token(Token = "0x400014E")]
			Count
		}

		[Token(Token = "0x2000037")]
		public enum ShaderAccuracy
		{
			[Token(Token = "0x4000150")]
			Fast,
			[Token(Token = "0x4000151")]
			High,
			[Token(Token = "0x4000152")]
			Count
		}

		[Token(Token = "0x2000038")]
		public struct StaticProperties
		{
			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BlendingMode blendingMode;

			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Noise3D noise3D;

			[Token(Token = "0x4000155")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public DepthBlend depthBlend;

			[Token(Token = "0x4000156")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public ColorGradient colorGradient;

			[Token(Token = "0x4000157")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DynamicOcclusion dynamicOcclusion;

			[Token(Token = "0x4000158")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public MeshSkewing meshSkewing;

			[Token(Token = "0x4000159")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ShaderAccuracy shaderAccuracy;

			[Token(Token = "0x17000029")]
			private int blendingModeID
			{
				[Token(Token = "0x60000CC")]
				[Address(RVA = "0xE27140", Offset = "0xE27140", VA = "0xE27140")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002A")]
			private int noise3DID
			{
				[Token(Token = "0x60000CD")]
				[Address(RVA = "0xE27148", Offset = "0xE27148", VA = "0xE27148")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002B")]
			private int depthBlendID
			{
				[Token(Token = "0x60000CE")]
				[Address(RVA = "0xE2717C", Offset = "0xE2717C", VA = "0xE2717C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002C")]
			private int colorGradientID
			{
				[Token(Token = "0x60000CF")]
				[Address(RVA = "0xE271B0", Offset = "0xE271B0", VA = "0xE271B0")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002D")]
			private int dynamicOcclusionID
			{
				[Token(Token = "0x60000D0")]
				[Address(RVA = "0xE271E4", Offset = "0xE271E4", VA = "0xE271E4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002E")]
			private int meshSkewingID
			{
				[Token(Token = "0x60000D1")]
				[Address(RVA = "0xE27218", Offset = "0xE27218", VA = "0xE27218")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002F")]
			private int shaderAccuracyID
			{
				[Token(Token = "0x60000D2")]
				[Address(RVA = "0xE2724C", Offset = "0xE2724C", VA = "0xE2724C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000030")]
			public int materialID
			{
				[Token(Token = "0x60000D3")]
				[Address(RVA = "0xE26ED8", Offset = "0xE26ED8", VA = "0xE26ED8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xE201D4", Offset = "0xE201D4", VA = "0xE201D4")]
			public void ApplyToMaterial(Material mat)
			{
			}
		}

		[Token(Token = "0x2000039")]
		private class MaterialsGroup
		{
			[Token(Token = "0x400015A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xE26E48", Offset = "0xE26E48", VA = "0xE26E48")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xE1E5D0", Offset = "0xE1E5D0", VA = "0xE1E5D0")]
		public static Material NewMaterialTransient(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xE26D48", Offset = "0xE26D48", VA = "0xE26D48")]
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xE204A4", Offset = "0xE204A4", VA = "0xE204A4")]
		public static Material GetInstancedMaterial(uint groupID, ref StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x200003A")]
	public static class MaterialModifier
	{
		[Token(Token = "0x200003B")]
		public interface Interface
		{
			[Token(Token = "0x60000D6")]
			void SetMaterialProp(int nameID, float value);

			[Token(Token = "0x60000D7")]
			void SetMaterialProp(int nameID, Vector4 value);

			[Token(Token = "0x60000D8")]
			void SetMaterialProp(int nameID, Color value);

			[Token(Token = "0x60000D9")]
			void SetMaterialProp(int nameID, Matrix4x4 value);

			[Token(Token = "0x60000DA")]
			void SetMaterialProp(int nameID, Texture value);
		}

		[Token(Token = "0x200003C")]
		public delegate void Callback(Interface owner);
	}
	[Token(Token = "0x200003D")]
	public static class MeshGenerator
	{
		[Token(Token = "0x400015B")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xE272C0", Offset = "0xE272C0", VA = "0xE272C0")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xE272D8", Offset = "0xE272D8", VA = "0xE272D8")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xE27348", Offset = "0xE27348", VA = "0xE27348")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xE1EC34", Offset = "0xE1EC34", VA = "0xE1EC34")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xE212E8", Offset = "0xE212E8", VA = "0xE212E8")]
		public static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xE273B4", Offset = "0xE273B4", VA = "0xE273B4")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xE273D0", Offset = "0xE273D0", VA = "0xE273D0")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xE273F8", Offset = "0xE273F8", VA = "0xE273F8")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xE27458", Offset = "0xE27458", VA = "0xE27458")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200003E")]
	public struct MinMaxRangeFloat
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float m_MinValue;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private float m_MaxValue;

		[Token(Token = "0x17000031")]
		public float minValue
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xE274BC", Offset = "0xE274BC", VA = "0xE274BC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000032")]
		public float maxValue
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0xE274C4", Offset = "0xE274C4", VA = "0xE274C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000033")]
		public float randomValue
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xE26718", Offset = "0xE26718", VA = "0xE26718")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000034")]
		public Vector2 asVector2
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0xE274CC", Offset = "0xE274CC", VA = "0xE274CC")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xE26BFC", Offset = "0xE26BFC", VA = "0xE26BFC")]
		public float GetLerpedValue(float lerp01)
		{
			return default(float);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xE22910", Offset = "0xE22910", VA = "0xE22910")]
		public MinMaxRangeFloat(float min, float max)
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class MinMaxRangeAttribute : Attribute
	{
		[Token(Token = "0x17000035")]
		public float minValue
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0xE274D4", Offset = "0xE274D4", VA = "0xE274D4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0xE274DC", Offset = "0xE274DC", VA = "0xE274DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public float maxValue
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0xE274E4", Offset = "0xE274E4", VA = "0xE274E4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xE274EC", Offset = "0xE274EC", VA = "0xE274EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xE274F4", Offset = "0xE274F4", VA = "0xE274F4")]
		public MinMaxRangeAttribute(float min, float max)
		{
		}
	}
	[Token(Token = "0x2000040")]
	public static class Noise3D
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x4000163")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x17000037")]
		public static bool isSupported
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0xE1FF48", Offset = "0xE1FF48", VA = "0xE1FF48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xE275C4", Offset = "0xE275C4", VA = "0xE275C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0xE27520", Offset = "0xE27520", VA = "0xE27520")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xE2763C", Offset = "0xE2763C", VA = "0xE2763C")]
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xE20F78", Offset = "0xE20F78", VA = "0xE20F78")]
		public static void LoadIfNeeded()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class PlatformHelper
	{
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xE22640", Offset = "0xE22640", VA = "0xE22640")]
		public static string GetCurrentPlatformSuffix()
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xE27640", Offset = "0xE27640", VA = "0xE27640")]
		private static string GetPlatformSuffix(RuntimePlatform platform)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xE276A4", Offset = "0xE276A4", VA = "0xE276A4")]
		public PlatformHelper()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class PolygonHelper : MonoBehaviour
	{
		[Token(Token = "0x2000043")]
		public struct Plane2D
		{
			[Token(Token = "0x4000164")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2 normal;

			[Token(Token = "0x4000165")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float distance;

			[Token(Token = "0x60000FC")]
			[Address(RVA = "0xE276B4", Offset = "0xE276B4", VA = "0xE276B4")]
			public float Distance(Vector2 point)
			{
				return default(float);
			}

			[Token(Token = "0x60000FD")]
			[Address(RVA = "0xE276D0", Offset = "0xE276D0", VA = "0xE276D0")]
			public Vector2 ClosestPoint(Vector2 pt)
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000FE")]
			[Address(RVA = "0xE276FC", Offset = "0xE276FC", VA = "0xE276FC")]
			public Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000FF")]
			[Address(RVA = "0xE2778C", Offset = "0xE2778C", VA = "0xE2778C")]
			public bool GetSide(Vector2 point)
			{
				return default(bool);
			}

			[Token(Token = "0x6000100")]
			[Address(RVA = "0xE277B0", Offset = "0xE277B0", VA = "0xE277B0")]
			public static Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x6000101")]
			[Address(RVA = "0xE278A8", Offset = "0xE278A8", VA = "0xE278A8")]
			public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x6000102")]
			[Address(RVA = "0xE278B8", Offset = "0xE278B8", VA = "0xE278B8")]
			public void Flip()
			{
			}

			[Token(Token = "0x6000103")]
			[Address(RVA = "0xE278D4", Offset = "0xE278D4", VA = "0xE278D4")]
			public Vector2[] CutConvex(Vector2[] poly)
			{
				return null;
			}

			[Token(Token = "0x6000104")]
			[Address(RVA = "0xE27B74", Offset = "0xE27B74", VA = "0xE27B74", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xE276AC", Offset = "0xE276AC", VA = "0xE276AC")]
		public PolygonHelper()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public static class ShaderKeywords
	{
		[Token(Token = "0x4000166")]
		public const string AlphaAsBlack = "VLB_ALPHA_AS_BLACK";

		[Token(Token = "0x4000167")]
		public const string ColorGradientMatrixLow = "VLB_COLOR_GRADIENT_MATRIX_LOW";

		[Token(Token = "0x4000168")]
		public const string ColorGradientMatrixHigh = "VLB_COLOR_GRADIENT_MATRIX_HIGH";

		[Token(Token = "0x4000169")]
		public const string DepthBlend = "VLB_DEPTH_BLEND";

		[Token(Token = "0x400016A")]
		public const string Noise3D = "VLB_NOISE_3D";

		[Token(Token = "0x400016B")]
		public const string OcclusionClippingPlane = "VLB_OCCLUSION_CLIPPING_PLANE";

		[Token(Token = "0x400016C")]
		public const string OcclusionDepthTexture = "VLB_OCCLUSION_DEPTH_TEXTURE";

		[Token(Token = "0x400016D")]
		public const string MeshSkewing = "VLB_MESH_SKEWING";

		[Token(Token = "0x400016E")]
		public const string ShaderAccuracyHigh = "VLB_SHADER_ACCURACY_HIGH";
	}
	[Token(Token = "0x2000045")]
	public static class ShaderProperties
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int FadeOutFactor;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int ConeSlopeCosSin;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int ConeRadius;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int ConeApexOffsetZ;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int ColorFlat;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly int AlphaInside;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int AlphaOutside;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static readonly int AttenuationLerpLinearQuad;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly int DistanceFallOff;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static readonly int DistanceCamClipping;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly int FresnelPow;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static readonly int GlareBehind;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly int GlareFrontal;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static readonly int DrawCap;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly int DepthBlendDistance;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static readonly int NoiseVelocityAndScale;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly int NoiseParam;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static readonly int CameraParams;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly int ColorGradientMatrix;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static readonly int LocalToWorldMatrix;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly int WorldToLocalMatrix;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static readonly int BlendSrcFactor;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly int BlendDstFactor;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static readonly int DynamicOcclusionClippingPlaneWS;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly int DynamicOcclusionClippingPlaneProps;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static readonly int DynamicOcclusionDepthTexture;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static readonly int DynamicOcclusionDepthProps;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static readonly int LocalForwardDirection;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static readonly int TiltVector;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public static readonly int AdditionalClippingPlaneWS;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static readonly int ParticlesTintColor;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public static readonly int GlobalUsesReversedZBuffer;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static readonly int GlobalNoiseTex3D;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static readonly int GlobalNoiseCustomTime;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static readonly int GlobalDitheringFactor;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public static readonly int GlobalDitheringNoiseTex;
	}
	[Token(Token = "0x2000046")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-skewinghandle.html")]
	public class SkewingHandle : MonoBehaviour
	{
		[Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class <CoUpdate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SkewingHandle <>4__this;

			[Token(Token = "0x1700003A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000112")]
				[Address(RVA = "0xE2865C", Offset = "0xE2865C", VA = "0xE2865C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000114")]
				[Address(RVA = "0xE286A4", Offset = "0xE286A4", VA = "0xE286A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600010F")]
			[Address(RVA = "0xE285B4", Offset = "0xE285B4", VA = "0xE285B4")]
			[DebuggerHidden]
			public <CoUpdate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000110")]
			[Address(RVA = "0xE285E4", Offset = "0xE285E4", VA = "0xE285E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000111")]
			[Address(RVA = "0xE285E8", Offset = "0xE285E8", VA = "0xE285E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000113")]
			[Address(RVA = "0xE28664", Offset = "0xE28664", VA = "0xE28664", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VolumetricLightBeam volumetricLightBeam;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool shouldUpdateEachFrame;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xE282C4", Offset = "0xE282C4", VA = "0xE282C4")]
		public bool IsAttachedToSelf()
		{
			return default(bool);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xE28384", Offset = "0xE28384", VA = "0xE28384")]
		public bool CanSetSkewingVector()
		{
			return default(bool);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xE2841C", Offset = "0xE2841C", VA = "0xE2841C")]
		public bool CanUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xE28454", Offset = "0xE28454", VA = "0xE28454")]
		private bool ShouldUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xE28468", Offset = "0xE28468", VA = "0xE28468")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xE284F4", Offset = "0xE284F4", VA = "0xE284F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xE28540", Offset = "0xE28540", VA = "0xE28540")]
		[IteratorStateMachine(typeof(<CoUpdate>d__8))]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xE2848C", Offset = "0xE2848C", VA = "0xE2848C")]
		private void SetSkewingVector()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xE285DC", Offset = "0xE285DC", VA = "0xE285DC")]
		public SkewingHandle()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public static class SRPHelper
	{
		[Token(Token = "0x2000049")]
		public enum RenderPipeline
		{
			[Token(Token = "0x400019A")]
			Undefined,
			[Token(Token = "0x400019B")]
			BuiltIn,
			[Token(Token = "0x400019C")]
			URP,
			[Token(Token = "0x400019D")]
			LWRP,
			[Token(Token = "0x400019E")]
			HDRP
		}

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RenderPipeline m_RenderPipelineCached;

		[Token(Token = "0x1700003C")]
		public static RenderPipeline renderPipelineType
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0xE21D38", Offset = "0xE21D38", VA = "0xE21D38")]
			get
			{
				return default(RenderPipeline);
			}
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xE286AC", Offset = "0xE286AC", VA = "0xE286AC")]
		private static RenderPipeline ComputeRenderPipeline()
		{
			return default(RenderPipeline);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xE2143C", Offset = "0xE2143C", VA = "0xE2143C")]
		public static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xE1E1D0", Offset = "0xE1E1D0", VA = "0xE1E1D0")]
		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xE1E060", Offset = "0xE1E060", VA = "0xE1E060")]
		public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}
	}
	[Token(Token = "0x200004A")]
	public static class TransformUtils
	{
		[Token(Token = "0x200004B")]
		public struct Packed
		{
			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Quaternion rotation;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lossyScale;

			[Token(Token = "0x600011B")]
			[Address(RVA = "0xE236BC", Offset = "0xE236BC", VA = "0xE236BC")]
			public bool IsSame(Transform transf)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xE22D4C", Offset = "0xE22D4C", VA = "0xE22D4C")]
		public static Packed GetWorldPacked(this Transform self)
		{
			return default(Packed);
		}
	}
	[Token(Token = "0x200004C")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-triggerzone.html")]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[DisallowMultipleComponent]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x200004D")]
		private enum TriggerZoneUpdateRate
		{
			[Token(Token = "0x40001AA")]
			OnEnable,
			[Token(Token = "0x40001AB")]
			OnOcclusionChange
		}

		[Token(Token = "0x40001A2")]
		public const string ClassName = "TriggerZone";

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x40001A5")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private VolumetricLightBeam m_Beam;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PolygonCollider2D m_PolygonCollider2D;

		[Token(Token = "0x1700003D")]
		private TriggerZoneUpdateRate updateRate
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0xE287D4", Offset = "0xE287D4", VA = "0xE287D4")]
			get
			{
				return default(TriggerZoneUpdateRate);
			}
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xE28858", Offset = "0xE28858", VA = "0xE28858")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xE28F10", Offset = "0xE28F10", VA = "0xE28F10")]
		private void OnOcclusionProcessed()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xE289CC", Offset = "0xE289CC", VA = "0xE289CC")]
		private void ComputeZone()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xE28FC4", Offset = "0xE28FC4", VA = "0xE28FC4")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public static class Utils
	{
		[Token(Token = "0x200004F")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x40001B0")]
			High = 64,
			[Token(Token = "0x40001B1")]
			Low = 8,
			[Token(Token = "0x40001B2")]
			Undef = 0
		}

		[Token(Token = "0x40001AC")]
		private const float kEpsilon = 1E-05f;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x40001AE")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xE28FDC", Offset = "0xE28FDC", VA = "0xE28FDC")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xE29010", Offset = "0xE29010", VA = "0xE29010")]
		public static float ComputeSpotAngle(float fallOffEnd, float coneRadiusEnd)
		{
			return default(float);
		}

		[Token(Token = "0x6000123")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xE1E8C8", Offset = "0xE1E8C8", VA = "0xE1E8C8")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		public static void ForeachComponentsOnlyInChildren<T>(this GameObject self, Action<T> lambda, bool includeInactive = false) where T : Component
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xE2903C", Offset = "0xE2903C", VA = "0xE2903C")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xE2910C", Offset = "0xE2910C", VA = "0xE2910C")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xE29110", Offset = "0xE29110", VA = "0xE29110")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xE29118", Offset = "0xE29118", VA = "0xE29118")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xE29124", Offset = "0xE29124", VA = "0xE29124")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xE29134", Offset = "0xE29134", VA = "0xE29134")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xE29140", Offset = "0xE29140", VA = "0xE29140")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xE29148", Offset = "0xE29148", VA = "0xE29148")]
		public static bool Approximately(this float a, float b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xE29158", Offset = "0xE29158", VA = "0xE29158")]
		public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xE29178", Offset = "0xE29178", VA = "0xE29178")]
		public static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xE291A4", Offset = "0xE291A4", VA = "0xE291A4")]
		public static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xE291E0", Offset = "0xE291E0", VA = "0xE291E0")]
		public static Vector4 AsVector4(this Vector3 vec3, float w)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xE291E4", Offset = "0xE291E4", VA = "0xE291E4")]
		public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xE29200", Offset = "0xE29200", VA = "0xE29200")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xE25030", Offset = "0xE25030", VA = "0xE25030")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xE29248", Offset = "0xE29248", VA = "0xE29248")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xE29250", Offset = "0xE29250", VA = "0xE29250")]
		public static Color ComputeComplementaryColor(this Color self, bool blackAndWhite)
		{
			return default(Color);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xE25C50", Offset = "0xE25C50", VA = "0xE25C50")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xE28F4C", Offset = "0xE28F4C", VA = "0xE28F4C")]
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xE27774", Offset = "0xE27774", VA = "0xE27774")]
		public static bool IsAlmostZero(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xE246E4", Offset = "0xE246E4", VA = "0xE246E4")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xE20C24", Offset = "0xE20C24", VA = "0xE20C24")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xE292C8", Offset = "0xE292C8", VA = "0xE292C8")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xE20D64", Offset = "0xE20D64", VA = "0xE20D64")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xE29338", Offset = "0xE29338", VA = "0xE29338")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xE2941C", Offset = "0xE2941C", VA = "0xE2941C")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xE292DC", Offset = "0xE292DC", VA = "0xE292DC")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xE2003C", Offset = "0xE2003C", VA = "0xE2003C")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xE29430", Offset = "0xE29430", VA = "0xE29430")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xE29434", Offset = "0xE29434", VA = "0xE29434")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x2000050")]
	public static class Version
	{
		[Token(Token = "0x40001B3")]
		public const int Current = 1970;
	}
	[Token(Token = "0x2000051")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dustparticles.html")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[ExecuteInEditMode]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x40001B4")]
		public const string ClassName = "VolumetricDustParticles";

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float alpha;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0.0001f, 0.1f)]
		public float size;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticlesDirection direction;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 velocity;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Obsolete("Use 'velocity' instead")]
		public float speed;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float density;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[MinMaxRange(0f, 1f)]
		public MinMaxRangeFloat spawnDistanceRange;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Obsolete("Use 'spawnDistanceRange' instead")]
		public float spawnMinDistance;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Obsolete("Use 'spawnDistanceRange' instead")]
		public float spawnMaxDistance;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool cullingEnabled;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float cullingMaxDistance;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_AlphaAdditionalRuntime;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_Material;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Gradient m_GradientCached;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_RuntimePropertiesDirty;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x1700003E")]
		public bool isCulled
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0xE29438", Offset = "0xE29438", VA = "0xE29438")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0xE29440", Offset = "0xE29440", VA = "0xE29440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public float alphaAdditionalRuntime
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0xE2944C", Offset = "0xE2944C", VA = "0xE2944C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xE2617C", Offset = "0xE2617C", VA = "0xE2617C")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xE29454", Offset = "0xE29454", VA = "0xE29454")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0xE294B0", Offset = "0xE294B0", VA = "0xE294B0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000042")]
		public int particlesMaxCount
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0xE29534", Offset = "0xE29534", VA = "0xE29534")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000043")]
		public Camera mainCamera
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0xE295D0", Offset = "0xE295D0", VA = "0xE295D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xE29790", Offset = "0xE29790", VA = "0xE29790")]
		private void Start()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xE29874", Offset = "0xE29874", VA = "0xE29874")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xE29B28", Offset = "0xE29B28", VA = "0xE29B28")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xE29B44", Offset = "0xE29B44", VA = "0xE29B44")]
		private void SetActive(bool active)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xE29B0C", Offset = "0xE29B0C", VA = "0xE29B0C")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xE29BE4", Offset = "0xE29BE4", VA = "0xE29BE4")]
		private void Play()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xE2A2D4", Offset = "0xE2A2D4", VA = "0xE2A2D4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xE2A2DC", Offset = "0xE2A2DC", VA = "0xE2A2DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xE2A3F4", Offset = "0xE2A3F4", VA = "0xE2A3F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xE29C84", Offset = "0xE29C84", VA = "0xE29C84")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xE29828", Offset = "0xE29828", VA = "0xE29828")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xE2A4E0", Offset = "0xE2A4E0", VA = "0xE2A4E0")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xE2A820", Offset = "0xE2A820", VA = "0xE2A820")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[SelectionBase]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam.html")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x2000054")]
		public delegate void OnWillCameraRenderCB(Camera cam);

		[Token(Token = "0x2000055")]
		public delegate void OnBeamGeometryInitialized();

		[Token(Token = "0x2000056")]
		public enum AttachedLightType
		{
			[Token(Token = "0x4000201")]
			NoLight,
			[Token(Token = "0x4000202")]
			OtherLight,
			[Token(Token = "0x4000203")]
			SpotLight
		}

		[Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class <CoPlaytimeUpdate>d__195 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x17000077")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001CB")]
				[Address(RVA = "0xE2C0D4", Offset = "0xE2C0D4", VA = "0xE2C0D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000078")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0xE2C11C", Offset = "0xE2C11C", VA = "0xE2C11C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xE2BBC4", Offset = "0xE2BBC4", VA = "0xE2BBC4")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__195(int <>1__state)
			{
			}

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xE2C040", Offset = "0xE2C040", VA = "0xE2C040", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xE2C044", Offset = "0xE2C044", VA = "0xE2C044", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xE2C0DC", Offset = "0xE2C0DC", VA = "0xE2C0DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001CC")]
		public const string ClassName = "VolumetricLightBeam";

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("colorValue")]
		[ColorUsage(false, true)]
		public Color color;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[FormerlySerializedAs("alphaInside")]
		public float intensityInside;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("alpha")]
		[FormerlySerializedAs("alphaOutside")]
		public float intensityOutside;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("angleFromLight")]
		public bool spotAngleFromLight;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0.1f, 179.9f)]
		public float spotAngle;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[FormerlySerializedAs("radiusStart")]
		public float coneRadiusStart;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public ShaderAccuracy shaderAccuracy;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MeshType geomMeshType;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[FormerlySerializedAs("geomSides")]
		public int geomCustomSides;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int geomCustomSegments;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 skewingLocalForwardDirection;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform clippingPlaneTransform;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool geomCap;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[FormerlySerializedAs("fadeEndFromLight")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float attenuationCustomBlending;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[FormerlySerializedAs("fadeStart")]
		public float fallOffStart;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[FormerlySerializedAs("fadeEnd")]
		public float fallOffEnd;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float depthBlendDistance;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float cameraClippingDistance;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[Range(0f, 1f)]
		public float glareFrontal;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Range(0f, 1f)]
		public float glareBehind;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[FormerlySerializedAs("fresnelPowOutside")]
		public float fresnelPow;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public NoiseMode noiseMode;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[Range(0f, 1f)]
		public float noiseIntensity;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Range(0.01f, 2f)]
		public float noiseScaleLocal;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Dimensions dimensions;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector2 tiltFactor;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private MaterialManager.DynamicOcclusion m_INTERNAL_DynamicOcclusionMode;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool m_INTERNAL_DynamicOcclusionMode_Runtime;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[FormerlySerializedAs("trackChangesDuringPlaytime")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[FormerlySerializedAs("fadeOutBegin")]
		private float _FadeOutBegin;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[FormerlySerializedAs("fadeOutEnd")]
		[SerializeField]
		private float _FadeOutEnd;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Light m_CachedLight;

		[Token(Token = "0x17000044")]
		public ColorMode usedColorMode
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0xE20D30", Offset = "0xE20D30", VA = "0xE20D30")]
			get
			{
				return default(ColorMode);
			}
		}

		[Token(Token = "0x17000045")]
		[Obsolete("Use 'intensityGlobal' or 'intensityInside' instead")]
		public float alphaInside
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0xE2AA04", Offset = "0xE2AA04", VA = "0xE2AA04")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0xE2AA0C", Offset = "0xE2AA0C", VA = "0xE2AA0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		[Obsolete("Use 'intensityGlobal' or 'intensityOutside' instead")]
		public float alphaOutside
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0xE2AA14", Offset = "0xE2AA14", VA = "0xE2AA14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0xE2AA1C", Offset = "0xE2AA1C", VA = "0xE2AA1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public float intensityGlobal
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0xE2AA24", Offset = "0xE2AA24", VA = "0xE2AA24")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0xE2AA2C", Offset = "0xE2AA2C", VA = "0xE2AA2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public float coneAngle
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0xE20C44", Offset = "0xE20C44", VA = "0xE20C44")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000049")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0xE1FDC0", Offset = "0xE1FDC0", VA = "0xE1FDC0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0xE2AA34", Offset = "0xE2AA34", VA = "0xE2AA34")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public float coneVolume
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0xE2AA78", Offset = "0xE2AA78", VA = "0xE2AA78")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004B")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0xE20CB8", Offset = "0xE20CB8", VA = "0xE20CB8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004C")]
		public Vector3 coneApexPositionLocal
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0xE2AAF4", Offset = "0xE2AAF4", VA = "0xE2AAF4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004D")]
		public Vector3 coneApexPositionGlobal
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0xE2AB10", Offset = "0xE2AB10", VA = "0xE2AB10")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004E")]
		public int geomSides
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xE28F14", Offset = "0xE28F14", VA = "0xE28F14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0xE2AB88", Offset = "0xE2AB88", VA = "0xE2AB88")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public int geomSegments
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0xE2AC04", Offset = "0xE2AC04", VA = "0xE2AC04")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xE2AC3C", Offset = "0xE2AC3C", VA = "0xE2AC3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public Vector3 skewingLocalForwardDirectionNormalized
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0xE21088", Offset = "0xE21088", VA = "0xE21088")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000051")]
		public Vector4 additionalClippingPlane
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0xE20E70", Offset = "0xE20E70", VA = "0xE20E70")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000052")]
		public bool canHaveMeshSkewing
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0xE2840C", Offset = "0xE2840C", VA = "0xE2840C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		public bool hasMeshSkewing
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xE200C0", Offset = "0xE200C0", VA = "0xE200C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		[Obsolete("Use 'fallOffEndFromLight' instead")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0xE2ACB8", Offset = "0xE2ACB8", VA = "0xE2ACB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0xE2ACC0", Offset = "0xE2ACC0", VA = "0xE2ACC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0xE20E48", Offset = "0xE20E48", VA = "0xE20E48")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000056")]
		[Obsolete("Use 'fallOffStart' instead")]
		public float fadeStart
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0xE2ACCC", Offset = "0xE2ACCC", VA = "0xE2ACCC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0xE2ACD4", Offset = "0xE2ACD4", VA = "0xE2ACD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		[Obsolete("Use 'fallOffEnd' instead")]
		public float fadeEnd
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0xE2ACDC", Offset = "0xE2ACDC", VA = "0xE2ACDC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0xE2ACE4", Offset = "0xE2ACE4", VA = "0xE2ACE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public float maxGeometryDistance
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0xE1FE10", Offset = "0xE1FE10", VA = "0xE1FE10")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000059")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xE1D6D8", Offset = "0xE1D6D8", VA = "0xE1D6D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005A")]
		[Obsolete("Use 'noiseMode' instead")]
		public bool noiseEnabled
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0xE2ACEC", Offset = "0xE2ACEC", VA = "0xE2ACEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0xE2ACFC", Offset = "0xE2ACFC", VA = "0xE2ACFC")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public float fadeOutBegin
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0xE2AD18", Offset = "0xE2AD18", VA = "0xE2AD18")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0xE2AD20", Offset = "0xE2AD20", VA = "0xE2AD20")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public float fadeOutEnd
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0xE2AD7C", Offset = "0xE2AD7C", VA = "0xE2AD7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0xE2AD84", Offset = "0xE2AD84", VA = "0xE2AD84")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0xE1D8E4", Offset = "0xE1D8E4", VA = "0xE1D8E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		public bool isTilted
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0xE2AD8C", Offset = "0xE2AD8C", VA = "0xE2AD8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0xE2ADF4", Offset = "0xE2ADF4", VA = "0xE2ADF4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0xE2ADFC", Offset = "0xE2ADFC", VA = "0xE2ADFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public string sortingLayerName
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xE2AE9C", Offset = "0xE2AE9C", VA = "0xE2AE9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0xE2AEA8", Offset = "0xE2AEA8", VA = "0xE2AEA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public int sortingOrder
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0xE2AECC", Offset = "0xE2AECC", VA = "0xE2AECC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0xE2AED4", Offset = "0xE2AED4", VA = "0xE2AED4")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0xE2AF74", Offset = "0xE2AF74", VA = "0xE2AF74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0xE2AF7C", Offset = "0xE2AF7C", VA = "0xE2AF7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0xE2AFF0", Offset = "0xE2AFF0", VA = "0xE2AFF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		public bool hasGeometry
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0xE2A6B0", Offset = "0xE2A6B0", VA = "0xE2A6B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		public Bounds bounds
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0xE2A710", Offset = "0xE2A710", VA = "0xE2A710")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000066")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0xE2B000", Offset = "0xE2B000", VA = "0xE2B000")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000067")]
		public Quaternion beamInternalLocalRotation
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0xE1FE30", Offset = "0xE1FE30", VA = "0xE1FE30")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000068")]
		public Vector3 beamLocalForward
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0xE23B48", Offset = "0xE23B48", VA = "0xE23B48")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000069")]
		public Vector3 beamGlobalForward
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0xE2B0D8", Offset = "0xE2B0D8", VA = "0xE2B0D8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006A")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0xE23BE4", Offset = "0xE23BE4", VA = "0xE23BE4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006B")]
		public float raycastDistance
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0xE24A14", Offset = "0xE24A14", VA = "0xE24A14")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700006C")]
		public Vector3 raycastGlobalForward
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0xE25838", Offset = "0xE25838", VA = "0xE25838")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006D")]
		public Vector3 raycastGlobalUp
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0xE25254", Offset = "0xE25254", VA = "0xE25254")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006E")]
		public Vector3 raycastGlobalRight
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0xE252C4", Offset = "0xE252C4", VA = "0xE252C4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006F")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0xE1E118", Offset = "0xE1E118", VA = "0xE1E118")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
			[Token(Token = "0x600019C")]
			[Address(RVA = "0xE2B144", Offset = "0xE2B144", VA = "0xE2B144")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0xE200AC", Offset = "0xE200AC", VA = "0xE200AC")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
		}

		[Token(Token = "0x17000071")]
		public int _INTERNAL_pluginVersion
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0xE2B188", Offset = "0xE2B188", VA = "0xE2B188")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000072")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0xE2B224", Offset = "0xE2B224", VA = "0xE2B224")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0xE2B22C", Offset = "0xE2B22C", VA = "0xE2B22C")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public string meshStats
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xE2B234", Offset = "0xE2B234", VA = "0xE2B234")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public int meshVerticesCount
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0xE2B3D4", Offset = "0xE2B3D4", VA = "0xE2B3D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000075")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0xE2B48C", Offset = "0xE2B48C", VA = "0xE2B48C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000076")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0xE2B658", Offset = "0xE2B658", VA = "0xE2B658")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0xE2324C", Offset = "0xE2324C", VA = "0xE2324C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0xE23520", Offset = "0xE23520", VA = "0xE23520")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xE20E1C", Offset = "0xE20E1C", VA = "0xE20E1C")]
		public void GetInsideAndOutsideIntensity(out float inside, out float outside)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xE22CA8", Offset = "0xE22CA8", VA = "0xE22CA8")]
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xE21950", Offset = "0xE21950", VA = "0xE21950")]
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xE233B4", Offset = "0xE233B4", VA = "0xE233B4")]
		public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xE2B14C", Offset = "0xE2B14C", VA = "0xE2B14C")]
		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xE2AD28", Offset = "0xE2AD28", VA = "0xE2AD28")]
		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xE2B190", Offset = "0xE2B190", VA = "0xE2B190")]
		private void OnFadeOutStateChanged()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xE2B560", Offset = "0xE2B560", VA = "0xE2B560")]
		public Light GetLightSpotAttachedSlow(out AttachedLightType lightType)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xE2B628", Offset = "0xE2B628", VA = "0xE2B628")]
		private void InitLightSpotAttachedCached()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xE2B660", Offset = "0xE2B660", VA = "0xE2B660")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xE2196C", Offset = "0xE2196C", VA = "0xE2196C")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xE2B6B4", Offset = "0xE2B6B4", VA = "0xE2B6B4")]
		[Obsolete("Use 'GenerateGeometry()' instead")]
		public void Generate()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xE2B6C0", Offset = "0xE2B6C0", VA = "0xE2B6C0", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xE2B968", Offset = "0xE2B968", VA = "0xE2B968", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xE2B9F8", Offset = "0xE2B9F8", VA = "0xE2B9F8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xE2BA38", Offset = "0xE2BA38", VA = "0xE2BA38")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xE2BAC0", Offset = "0xE2BAC0", VA = "0xE2BAC0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xE2AF88", Offset = "0xE2AF88", VA = "0xE2AF88")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xE2BB50", Offset = "0xE2BB50", VA = "0xE2BB50")]
		[IteratorStateMachine(typeof(<CoPlaytimeUpdate>d__195))]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xE2BBEC", Offset = "0xE2BBEC", VA = "0xE2BBEC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xE2BBF0", Offset = "0xE2BBF0", VA = "0xE2BBF0")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xE2BC9C", Offset = "0xE2BC9C", VA = "0xE2BC9C")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xE2BD8C", Offset = "0xE2BD8C", VA = "0xE2BD8C")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xE2B94C", Offset = "0xE2B94C", VA = "0xE2B94C")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xE2B7EC", Offset = "0xE2B7EC", VA = "0xE2B7EC")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xE2BEA4", Offset = "0xE2BEA4", VA = "0xE2BEA4")]
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
		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE2C124", Offset = "0xE2C124", VA = "0xE2C124")]
		private void Update()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE2C1E4", Offset = "0xE2C1E4", VA = "0xE2C1E4")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[RequireComponent(typeof(Collider), typeof(Rigidbody), typeof(MeshRenderer))]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isInsideBeam;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xE2C1F4", Offset = "0xE2C1F4", VA = "0xE2C1F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xE2C2E4", Offset = "0xE2C2E4", VA = "0xE2C2E4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xE2C398", Offset = "0xE2C398", VA = "0xE2C398")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xE2C3A0", Offset = "0xE2C3A0", VA = "0xE2C3A0")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xE2C458", Offset = "0xE2C458", VA = "0xE2C458")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xE2C460", Offset = "0xE2C460", VA = "0xE2C460")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xE2C4C8", Offset = "0xE2C4C8", VA = "0xE2C4C8")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x17000079")]
		private bool useMouseView
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0xE2C4D0", Offset = "0xE2C4D0", VA = "0xE2C4D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0xE2C4D8", Offset = "0xE2C4D8", VA = "0xE2C4D8")]
			set
			{
			}
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xE2C508", Offset = "0xE2C508", VA = "0xE2C508")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xE2C598", Offset = "0xE2C598", VA = "0xE2C598")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xE2CB50", Offset = "0xE2CB50", VA = "0xE2CB50")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Range(1f, 100f)]
		private int CountX;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(1f, 100f)]
		[SerializeField]
		private int CountY;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xE2CB74", Offset = "0xE2CB74", VA = "0xE2CB74")]
		public void Generate()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xE2D204", Offset = "0xE2D204", VA = "0xE2D204")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("m_EulerSpeed")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xE2D220", Offset = "0xE2D220", VA = "0xE2D220")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xE2D2F0", Offset = "0xE2D2F0", VA = "0xE2D2F0")]
		public Rotater()
		{
		}
	}
}
namespace Crosstales
{
	[Token(Token = "0x200005E")]
	public static class ExtensionMethods
	{
		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 flat;

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xE2D350", Offset = "0xE2D350", VA = "0xE2D350")]
		public static string CTToTitleCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xE2D3F0", Offset = "0xE2D3F0", VA = "0xE2D3F0")]
		public static string CTReverse(this string str)
		{
			return null;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xE2D468", Offset = "0xE2D468", VA = "0xE2D468")]
		public static string CTReplace(this string str, string oldString, string newString, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xE2D4F4", Offset = "0xE2D4F4", VA = "0xE2D4F4")]
		public static bool CTEquals(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xE2D504", Offset = "0xE2D504", VA = "0xE2D504")]
		public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xE2D524", Offset = "0xE2D524", VA = "0xE2D524")]
		public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xE2D694", Offset = "0xE2D694", VA = "0xE2D694")]
		public static bool CTContainsAll(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xE2D804", Offset = "0xE2D804", VA = "0xE2D804")]
		public static string CTRemoveNewLines(this string str, string replacement = "#nl#", [Optional] string newLine)
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xE2D858", Offset = "0xE2D858", VA = "0xE2D858")]
		public static string CTAddNewLines(this string str, string replacement = "#nl#", [Optional] string newLine)
		{
			return null;
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xE2D8FC", Offset = "0xE2D8FC", VA = "0xE2D8FC")]
		public static bool CTisNumeric(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xE2D920", Offset = "0xE2D920", VA = "0xE2D920")]
		public static bool CTisInteger(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xE2D998", Offset = "0xE2D998", VA = "0xE2D998")]
		public static bool CTisEmail(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xE2DA18", Offset = "0xE2DA18", VA = "0xE2DA18")]
		public static bool CTisWebsite(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xE2DA98", Offset = "0xE2DA98", VA = "0xE2DA98")]
		public static bool CTisCreditcard(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xE2DB18", Offset = "0xE2DB18", VA = "0xE2DB18")]
		public static bool CTisIPv4(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xE2DB98", Offset = "0xE2DB98", VA = "0xE2DB98")]
		public static bool CTisAlphanumeric(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xE2DC18", Offset = "0xE2DC18", VA = "0xE2DC18")]
		public static bool CThasLineEndings(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xE2DC98", Offset = "0xE2DC98", VA = "0xE2DC98")]
		public static bool CThasInvalidChars(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xE2DD18", Offset = "0xE2DD18", VA = "0xE2DD18")]
		public static bool CTStartsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xE2DD6C", Offset = "0xE2DD6C", VA = "0xE2DD6C")]
		public static bool CTEndsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xE2DDC0", Offset = "0xE2DDC0", VA = "0xE2DDC0")]
		public static int CTLastIndexOf(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xE2DE60", Offset = "0xE2DE60", VA = "0xE2DE60")]
		public static int CTIndexOf(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xE2DF00", Offset = "0xE2DF00", VA = "0xE2DF00")]
		public static int CTIndexOf(this string str, string toCheck, int startIndex, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xE2DFB4", Offset = "0xE2DFB4", VA = "0xE2DFB4")]
		public static string CTToBase64(this string str, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xE2E0BC", Offset = "0xE2E0BC", VA = "0xE2E0BC")]
		public static string CTFromBase64(this string str, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xE2E15C", Offset = "0xE2E15C", VA = "0xE2E15C")]
		public static byte[] CTFromBase64ToByteArray(this string str)
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xE2E1C8", Offset = "0xE2E1C8", VA = "0xE2E1C8")]
		public static string CTToHex(this string str, bool addPrefix = false)
		{
			return null;
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xE2E318", Offset = "0xE2E318", VA = "0xE2E318")]
		public static string CTHexToString(this string hexString)
		{
			return null;
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xE2E4F8", Offset = "0xE2E4F8", VA = "0xE2E4F8")]
		public static Color32 CTHexToColor32(this string hexString)
		{
			return default(Color32);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xE2E77C", Offset = "0xE2E77C", VA = "0xE2E77C")]
		public static Color CTHexToColor(this string hexString)
		{
			return default(Color);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xE2E80C", Offset = "0xE2E80C", VA = "0xE2E80C")]
		public static byte[] CTToByteArray(this string str, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xE2E860", Offset = "0xE2E860", VA = "0xE2E860")]
		public static string CTClearTags(this string str)
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xE2E90C", Offset = "0xE2E90C", VA = "0xE2E90C")]
		public static string CTClearSpaces(this string str)
		{
			return null;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xE2E9B0", Offset = "0xE2E9B0", VA = "0xE2E9B0")]
		public static string CTClearLineEndings(this string str)
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		public static void CTShuffle<T>(this T[] array, int seed = 0)
		{
		}

		[Token(Token = "0x6000203")]
		public static string CTDump<T>(this T[] array, string prefix = "", string postfix = "", bool appendNewLine = true, string delimiter = "; ")
		{
			return null;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xE2EA5C", Offset = "0xE2EA5C", VA = "0xE2EA5C")]
		public static string CTDump(this Quaternion[] array)
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xE2EBEC", Offset = "0xE2EBEC", VA = "0xE2EBEC")]
		public static string CTDump(this Vector2[] array)
		{
			return null;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xE2ED2C", Offset = "0xE2ED2C", VA = "0xE2ED2C")]
		public static string CTDump(this Vector3[] array)
		{
			return null;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xE2EE9C", Offset = "0xE2EE9C", VA = "0xE2EE9C")]
		public static string CTDump(this Vector4[] array)
		{
			return null;
		}

		[Token(Token = "0x6000208")]
		public static string[] CTToString<T>(this T[] array)
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xE2F02C", Offset = "0xE2F02C", VA = "0xE2F02C")]
		public static float[] CTToFloatArray(this byte[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xE2F1C0", Offset = "0xE2F1C0", VA = "0xE2F1C0")]
		public static byte[] CTToByteArray(this float[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xE2F300", Offset = "0xE2F300", VA = "0xE2F300")]
		public static Texture2D CTToTexture(this byte[] data)
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xE2F3C8", Offset = "0xE2F3C8", VA = "0xE2F3C8")]
		public static Sprite CTToSprite(this byte[] data)
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xE2F51C", Offset = "0xE2F51C", VA = "0xE2F51C")]
		public static string CTToString(this byte[] data, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xE2E050", Offset = "0xE2E050", VA = "0xE2E050")]
		public static string CTToBase64(this byte[] data)
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		public static void CTShuffle<T>(this IList<T> list, int seed = 0)
		{
		}

		[Token(Token = "0x6000210")]
		public static string CTDump<T>(this IList<T> list, string prefix = "", string postfix = "", bool appendNewLine = true, string delimiter = "; ")
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xE2F564", Offset = "0xE2F564", VA = "0xE2F564")]
		public static string CTDump(this IList<Quaternion> list)
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xE2F990", Offset = "0xE2F990", VA = "0xE2F990")]
		public static string CTDump(this IList<Vector2> list)
		{
			return null;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xE2FD58", Offset = "0xE2FD58", VA = "0xE2FD58")]
		public static string CTDump(this IList<Vector3> list)
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xE30158", Offset = "0xE30158", VA = "0xE30158")]
		public static string CTDump(this IList<Vector4> list)
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		public static List<string> CTToString<T>(this IList<T> list)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		public static string CTDump<K, V>(this IDictionary<K, V> dict, string prefix = "", string postfix = "", bool appendNewLine = true, string delimiter = "; ")
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		public static void CTAddRange<K, V>(this IDictionary<K, V> dict, IDictionary<K, V> collection)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xE30584", Offset = "0xE30584", VA = "0xE30584")]
		public static byte[] CTReadFully(this Stream input)
		{
			return null;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xE30784", Offset = "0xE30784", VA = "0xE30784")]
		public static string CTToHexRGB(this Color32 input)
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xE30830", Offset = "0xE30830", VA = "0xE30830")]
		public static string CTToHexRGB(this Color input)
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xE30838", Offset = "0xE30838", VA = "0xE30838")]
		public static string CTToHexRGBA(this Color32 input)
		{
			return null;
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xE308E4", Offset = "0xE308E4", VA = "0xE308E4")]
		public static string CTToHexRGBA(this Color input)
		{
			return null;
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xE308EC", Offset = "0xE308EC", VA = "0xE308EC")]
		public static Vector3 CTVector3(this Color32 color)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xE30984", Offset = "0xE30984", VA = "0xE30984")]
		public static Vector3 CTVector3(this Color color)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xE30988", Offset = "0xE30988", VA = "0xE30988")]
		public static Vector4 CTVector4(this Color32 color)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xE30A30", Offset = "0xE30A30", VA = "0xE30A30")]
		public static Vector4 CTVector4(this Color color)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xE30A34", Offset = "0xE30A34", VA = "0xE30A34")]
		public static Vector2 CTMultiply(this Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xE30A40", Offset = "0xE30A40", VA = "0xE30A40")]
		public static Vector3 CTMultiply(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xE30A50", Offset = "0xE30A50", VA = "0xE30A50")]
		public static Vector3 CTFlatten(this Vector3 a)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xE30AD4", Offset = "0xE30AD4", VA = "0xE30AD4")]
		public static Quaternion CTQuaternion(this Vector3 eulerAngle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xE30AF0", Offset = "0xE30AF0", VA = "0xE30AF0")]
		public static Color CTColorRGB(this Vector3 rgb, float alpha = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xE30B2C", Offset = "0xE30B2C", VA = "0xE30B2C")]
		public static Vector4 CTMultiply(this Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xE30B40", Offset = "0xE30B40", VA = "0xE30B40")]
		public static Quaternion CTQuaternion(this Vector4 angle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xE30B44", Offset = "0xE30B44", VA = "0xE30B44")]
		public static Color CTColorRGBA(this Vector4 rgba)
		{
			return default(Color);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xE30B80", Offset = "0xE30B80", VA = "0xE30B80")]
		public static Vector3 CTVector3(this Quaternion angle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xE30BAC", Offset = "0xE30BAC", VA = "0xE30BAC")]
		public static Vector4 CTVector4(this Quaternion angle)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xE30BB0", Offset = "0xE30BB0", VA = "0xE30BB0")]
		public static Vector3 CTCorrectLossyScale(this Canvas canvas)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xE30DC8", Offset = "0xE30DC8", VA = "0xE30DC8")]
		public static void CTGetLocalCorners(this RectTransform transform, Vector3[] fourCornersArray, Canvas canvas, float inset = 0f, bool corrected = false)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xE31038", Offset = "0xE31038", VA = "0xE31038")]
		public static Vector3[] CTGetLocalCorners(this RectTransform transform, Canvas canvas, float inset = 0f, bool corrected = false)
		{
			return null;
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xE310F0", Offset = "0xE310F0", VA = "0xE310F0")]
		public static void CTGetScreenCorners(this RectTransform transform, Vector3[] fourCornersArray, Canvas canvas, float inset = 0f, bool corrected = false)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xE313CC", Offset = "0xE313CC", VA = "0xE313CC")]
		public static Vector3[] CTGetScreenCorners(this RectTransform transform, Canvas canvas, float inset = 0f, bool corrected = false)
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xE31484", Offset = "0xE31484", VA = "0xE31484")]
		public static Bounds CTGetBounds(this RectTransform transform, float uiScaleFactor = 1f)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xE319C4", Offset = "0xE319C4", VA = "0xE319C4")]
		public static void CTSetLeft(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xE31AA0", Offset = "0xE31AA0", VA = "0xE31AA0")]
		public static void CTSetRight(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xE31B7C", Offset = "0xE31B7C", VA = "0xE31B7C")]
		public static void CTSetTop(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xE31C58", Offset = "0xE31C58", VA = "0xE31C58")]
		public static void CTSetBottom(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xE31D34", Offset = "0xE31D34", VA = "0xE31D34")]
		public static float CTGetLeft(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xE31DF4", Offset = "0xE31DF4", VA = "0xE31DF4")]
		public static float CTGetRight(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xE31EB4", Offset = "0xE31EB4", VA = "0xE31EB4")]
		public static float CTGetTop(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xE31F7C", Offset = "0xE31F7C", VA = "0xE31F7C")]
		public static float CTGetBottom(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xE32044", Offset = "0xE32044", VA = "0xE32044")]
		public static Vector4 CTGetLRTB(this RectTransform transform)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xE3214C", Offset = "0xE3214C", VA = "0xE3214C")]
		public static void CTSetLRTB(this RectTransform transform, Vector4 lrtb)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xE32248", Offset = "0xE32248", VA = "0xE32248")]
		public static GameObject CTFind(this MonoBehaviour mb, string name)
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		public static T CTFind<T>(this MonoBehaviour mb, string name)
		{
			return (T)null;
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xE32468", Offset = "0xE32468", VA = "0xE32468")]
		public static GameObject CTFind(this GameObject go, string name)
		{
			return null;
		}

		[Token(Token = "0x600023E")]
		public static T CTFind<T>(this GameObject go, string name)
		{
			return (T)null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xE32578", Offset = "0xE32578", VA = "0xE32578")]
		public static Bounds CTGetBounds(this GameObject go)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xE32358", Offset = "0xE32358", VA = "0xE32358")]
		public static Transform CTFind(this Transform transform, string name)
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		public static T CTFind<T>(this Transform transform, string name)
		{
			return (T)null;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xE32B58", Offset = "0xE32B58", VA = "0xE32B58")]
		public static byte[] CTToPNG(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xE32D04", Offset = "0xE32D04", VA = "0xE32D04")]
		public static byte[] CTToJPG(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xE32EB0", Offset = "0xE32EB0", VA = "0xE32EB0")]
		public static byte[] CTToTGA(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xE3305C", Offset = "0xE3305C", VA = "0xE3305C")]
		public static byte[] CTToEXR(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xE32C4C", Offset = "0xE32C4C", VA = "0xE32C4C")]
		public static byte[] CTToPNG(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xE32DF8", Offset = "0xE32DF8", VA = "0xE32DF8")]
		public static byte[] CTToJPG(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xE32FA4", Offset = "0xE32FA4", VA = "0xE32FA4")]
		public static byte[] CTToTGA(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xE33150", Offset = "0xE33150", VA = "0xE33150")]
		public static byte[] CTToEXR(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xE33208", Offset = "0xE33208", VA = "0xE33208")]
		public static Sprite CTToSprite(this Texture2D texture, float pixelsPerUnit = 100f)
		{
			return null;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xE33338", Offset = "0xE33338", VA = "0xE33338")]
		public static bool CTHasActiveClip(this AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xE33448", Offset = "0xE33448", VA = "0xE33448")]
		public static bool CTIsVisibleFrom(this Renderer renderer, Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xE327A8", Offset = "0xE327A8", VA = "0xE327A8")]
		private static Transform deepSearch(Transform parent, string name)
		{
			return null;
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xE2F1A4", Offset = "0xE2F1A4", VA = "0xE2F1A4")]
		private static float bytesToFloat(byte firstByte, byte secondByte)
		{
			return default(float);
		}
	}
}
namespace Crosstales.Common.Util
{
	[Token(Token = "0x2000063")]
	public abstract class BaseConstants
	{
		[Token(Token = "0x4000221")]
		public const string ASSET_AUTHOR = "crosstales LLC";

		[Token(Token = "0x4000222")]
		public const string ASSET_AUTHOR_URL = "https://www.crosstales.com";

		[Token(Token = "0x4000223")]
		public const string ASSET_CT_URL = "https://assetstore.unity.com/lists/crosstales-42213?aid=1011lNGT";

		[Token(Token = "0x4000224")]
		public const string ASSET_SOCIAL_DISCORD = "https://discord.gg/ZbZ2sh4";

		[Token(Token = "0x4000225")]
		public const string ASSET_SOCIAL_FACEBOOK = "https://www.facebook.com/crosstales/";

		[Token(Token = "0x4000226")]
		public const string ASSET_SOCIAL_TWITTER = "https://twitter.com/crosstales";

		[Token(Token = "0x4000227")]
		public const string ASSET_SOCIAL_YOUTUBE = "https://www.youtube.com/c/Crosstales";

		[Token(Token = "0x4000228")]
		public const string ASSET_SOCIAL_LINKEDIN = "https://www.linkedin.com/company/crosstales";

		[Token(Token = "0x4000229")]
		public const string ASSET_3P_PLAYMAKER = "https://assetstore.unity.com/packages/slug/368?aid=1011lNGT";

		[Token(Token = "0x400022A")]
		public const string ASSET_3P_VOLUMETRIC_AUDIO = "https://assetstore.unity.com/packages/slug/17125?aid=1011lNGT";

		[Token(Token = "0x400022B")]
		public const string ASSET_3P_ROCKTOMATE = "https://assetstore.unity.com/packages/slug/156311?aid=1011lNGT";

		[Token(Token = "0x400022C")]
		public const string ASSET_BWF = "https://assetstore.unity.com/packages/slug/26255?aid=1011lNGT";

		[Token(Token = "0x400022D")]
		public const string ASSET_DJ = "https://assetstore.unity.com/packages/slug/41993?aid=1011lNGT";

		[Token(Token = "0x400022E")]
		public const string ASSET_FB = "https://assetstore.unity.com/packages/slug/98713?aid=1011lNGT";

		[Token(Token = "0x400022F")]
		public const string ASSET_OC = "https://assetstore.unity.com/packages/slug/74688?aid=1011lNGT";

		[Token(Token = "0x4000230")]
		public const string ASSET_RADIO = "https://assetstore.unity.com/packages/slug/32034?aid=1011lNGT";

		[Token(Token = "0x4000231")]
		public const string ASSET_RTV = "https://assetstore.unity.com/packages/slug/41068?aid=1011lNGT";

		[Token(Token = "0x4000232")]
		public const string ASSET_TB = "https://assetstore.unity.com/packages/slug/98711?aid=1011lNGT";

		[Token(Token = "0x4000233")]
		public const string ASSET_TPB = "https://assetstore.unity.com/packages/slug/98714?aid=1011lNGT";

		[Token(Token = "0x4000234")]
		public const string ASSET_TPS = "https://assetstore.unity.com/packages/slug/60040?aid=1011lNGT";

		[Token(Token = "0x4000235")]
		public const string ASSET_TR = "https://assetstore.unity.com/packages/slug/61617?aid=1011lNGT";

		[Token(Token = "0x4000236")]
		public const int FACTOR_KB = 1024;

		[Token(Token = "0x4000237")]
		public const int FACTOR_MB = 1048576;

		[Token(Token = "0x4000238")]
		public const int FACTOR_GB = 1073741824;

		[Token(Token = "0x4000239")]
		public const float FLOAT_32768 = 32768f;

		[Token(Token = "0x400023A")]
		public const float FLOAT_TOLERANCE = 0.0001f;

		[Token(Token = "0x400023B")]
		public const string FORMAT_TWO_DECIMAL_PLACES = "0.00";

		[Token(Token = "0x400023C")]
		public const string FORMAT_NO_DECIMAL_PLACES = "0";

		[Token(Token = "0x400023D")]
		public const string FORMAT_PERCENT = "0%";

		[Token(Token = "0x400023E")]
		public const bool DEFAULT_DEBUG = false;

		[Token(Token = "0x400023F")]
		public const string PATH_DELIMITER_WINDOWS = "\\";

		[Token(Token = "0x4000240")]
		public const string PATH_DELIMITER_UNIX = "/";

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Regex REGEX_LINEENDINGS;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Regex REGEX_EMAIL;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Regex REGEX_CREDITCARD;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Regex REGEX_URL_WEB;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Regex REGEX_IP_ADDRESS;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly Regex REGEX_INVALID_CHARS;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly Regex REGEX_ALPHANUMERIC;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly Regex REGEX_CLEAN_SPACES;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly Regex REGEX_CLEAN_TAGS;

		[Token(Token = "0x400024A")]
		public const string LATIN_ABC_UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		[Token(Token = "0x400024B")]
		public const string LATIN_ABC_LOWERCASE = "abcdefghijklmnopqrstuvwxyz";

		[Token(Token = "0x400024C")]
		public const string LATIN_ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

		[Token(Token = "0x400024D")]
		public const string NUMBERS = "0123456789";

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static bool DEV_DEBUG;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string TEXT_TOSTRING_START;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string TEXT_TOSTRING_END;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string TEXT_TOSTRING_DELIMITER;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string TEXT_TOSTRING_DELIMITER_END;

		[Token(Token = "0x4000253")]
		public const string PREFIX_HTTP = "http://";

		[Token(Token = "0x4000254")]
		public const string PREFIX_HTTPS = "https://";

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static int PROCESS_KILL_TIME;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string CMD_WINDOWS_PATH;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static bool SHOW_BWF_BANNER;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public static bool SHOW_DJ_BANNER;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		public static bool SHOW_FB_BANNER;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
		public static bool SHOW_OC_BANNER;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static bool SHOW_RADIO_BANNER;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		public static bool SHOW_RTV_BANNER;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
		public static bool SHOW_TB_BANNER;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x87")]
		public static bool SHOW_TPB_BANNER;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static bool SHOW_TPS_BANNER;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public static bool SHOW_TR_BANNER;

		[Token(Token = "0x1700007A")]
		public static string PREFIX_FILE
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0xE337C0", Offset = "0xE337C0", VA = "0xE337C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		public static string APPLICATION_PATH
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0xE338CC", Offset = "0xE338CC", VA = "0xE338CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xE33B30", Offset = "0xE33B30", VA = "0xE33B30")]
		protected BaseConstants()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public abstract class BaseHelper
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly CultureInfo BaseCulture;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static readonly System.Random rnd;

		[Token(Token = "0x4000263")]
		protected const string file_prefix = "file://";

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static bool ApplicationIsPlaying;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string applicationDataPath;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static string[] args;

		[Token(Token = "0x1700007C")]
		public static bool isInternetAvailable
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0xE33EF0", Offset = "0xE33EF0", VA = "0xE33EF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007D")]
		public static bool isWindowsPlatform
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0xE33F0C", Offset = "0xE33F0C", VA = "0xE33F0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007E")]
		public static bool isMacOSPlatform
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0xE33F14", Offset = "0xE33F14", VA = "0xE33F14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007F")]
		public static bool isLinuxPlatform
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0xE33F1C", Offset = "0xE33F1C", VA = "0xE33F1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000080")]
		public static bool isStandalonePlatform
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0xE33F24", Offset = "0xE33F24", VA = "0xE33F24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000081")]
		public static bool isAndroidPlatform
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0xE33F94", Offset = "0xE33F94", VA = "0xE33F94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000082")]
		public static bool isIOSPlatform
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0xE33F9C", Offset = "0xE33F9C", VA = "0xE33F9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000083")]
		public static bool isTvOSPlatform
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0xE33FA4", Offset = "0xE33FA4", VA = "0xE33FA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000084")]
		public static bool isWSAPlatform
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0xE33FAC", Offset = "0xE33FAC", VA = "0xE33FAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public static bool isXboxOnePlatform
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0xE33FB4", Offset = "0xE33FB4", VA = "0xE33FB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000086")]
		public static bool isPS4Platform
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0xE33FBC", Offset = "0xE33FBC", VA = "0xE33FBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000087")]
		public static bool isWebGLPlatform
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0xE33FC4", Offset = "0xE33FC4", VA = "0xE33FC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000088")]
		public static bool isWebPlatform
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0xE33FCC", Offset = "0xE33FCC", VA = "0xE33FCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000089")]
		public static bool isWindowsBasedPlatform
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0xE33844", Offset = "0xE33844", VA = "0xE33844")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008A")]
		public static bool isWSABasedPlatform
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0xE3401C", Offset = "0xE3401C", VA = "0xE3401C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public static bool isAppleBasedPlatform
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0xE3407C", Offset = "0xE3407C", VA = "0xE3407C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008C")]
		public static bool isIOSBasedPlatform
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0xE340EC", Offset = "0xE340EC", VA = "0xE340EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008D")]
		public static bool isMobilePlatform
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0xE3414C", Offset = "0xE3414C", VA = "0xE3414C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008E")]
		public static bool isEditor
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xE3419C", Offset = "0xE3419C", VA = "0xE3419C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008F")]
		public static bool isWindowsEditor
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0xE338B4", Offset = "0xE338B4", VA = "0xE338B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000090")]
		public static bool isMacOSEditor
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0xE338BC", Offset = "0xE338BC", VA = "0xE338BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		public static bool isLinuxEditor
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0xE338C4", Offset = "0xE338C4", VA = "0xE338C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000092")]
		public static bool isEditorMode
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0xE3420C", Offset = "0xE3420C", VA = "0xE3420C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000093")]
		public static bool isIL2CPP
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0xE34260", Offset = "0xE34260", VA = "0xE34260")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000094")]
		public static Platform CurrentPlatform
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0xE34268", Offset = "0xE34268", VA = "0xE34268")]
			get
			{
				return default(Platform);
			}
		}

		[Token(Token = "0x17000095")]
		public static string StreamingAssetsPath
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0xE342E8", Offset = "0xE342E8", VA = "0xE342E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xE343B0", Offset = "0xE343B0", VA = "0xE343B0")]
		static BaseHelper()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xE344C8", Offset = "0xE344C8", VA = "0xE344C8")]
		[RuntimeInitializeOnLoadMethod]
		private static void initialize()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xE3454C", Offset = "0xE3454C", VA = "0xE3454C")]
		public static bool OpenURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xE3470C", Offset = "0xE3470C", VA = "0xE3470C")]
		public static string CreateString(string replaceChars, int stringLength)
		{
			return null;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xE34890", Offset = "0xE34890", VA = "0xE34890")]
		[Obsolete("Use the extension method 'CTHasActiveClip' instead")]
		public static bool hasActiveClip(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xE348E8", Offset = "0xE348E8", VA = "0xE348E8")]
		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xE33968", Offset = "0xE33968", VA = "0xE33968")]
		public static string ValidatePath(string path, bool addEndDelimiter = true)
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xE34E00", Offset = "0xE34E00", VA = "0xE34E00")]
		public static string ValidateFile(string path)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xE35058", Offset = "0xE35058", VA = "0xE35058")]
		public static bool PathHasInvalidChars(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xE350E8", Offset = "0xE350E8", VA = "0xE350E8")]
		public static bool FileHasInvalidChars(string file)
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xE35178", Offset = "0xE35178", VA = "0xE35178")]
		public static string[] GetFiles(string path, bool isRecursive = false, params string[] extensions)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xE3568C", Offset = "0xE3568C", VA = "0xE3568C")]
		public static string[] GetDirectories(string path, bool isRecursive = false)
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xE358A8", Offset = "0xE358A8", VA = "0xE358A8")]
		public static string[] GetDrives()
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xE35A40", Offset = "0xE35A40", VA = "0xE35A40")]
		public static string ValidURLFromFilePath(string path)
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xE35BB8", Offset = "0xE35BB8", VA = "0xE35BB8")]
		public static string CleanUrl(string url, bool removeProtocol = true, bool removeWWW = true, bool removeSlash = true)
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xE35D60", Offset = "0xE35D60", VA = "0xE35D60")]
		[Obsolete("Use the extension method 'CTClearTags' instead")]
		public static string ClearTags(string text)
		{
			return null;
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xE35DB8", Offset = "0xE35DB8", VA = "0xE35DB8")]
		[Obsolete("Use the extension method 'CTClearSpaces' instead")]
		public static string ClearSpaces(string text)
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xE35E10", Offset = "0xE35E10", VA = "0xE35E10")]
		[Obsolete("Use the extension method 'CTClearLineEndings' instead")]
		public static string ClearLineEndings(string text)
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xE35E68", Offset = "0xE35E68", VA = "0xE35E68")]
		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true, int skipHeaderLines = 0, int skipFooterLines = 0)
		{
			return null;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xE3613C", Offset = "0xE3613C", VA = "0xE3613C")]
		public static string FormatBytesToHRF(long bytes, bool useSI = true)
		{
			return null;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xE36404", Offset = "0xE36404", VA = "0xE36404")]
		public static string FormatSecondsToHourMinSec(double seconds)
		{
			return null;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xE36460", Offset = "0xE36460", VA = "0xE36460")]
		public static string FormatSecondsToHRF(double seconds)
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xE36894", Offset = "0xE36894", VA = "0xE36894")]
		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xE3462C", Offset = "0xE3462C", VA = "0xE3462C")]
		public static bool isValidURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xE369E4", Offset = "0xE369E4", VA = "0xE369E4")]
		public static void CopyPath(string sourcePath, string destPath, bool move = false)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xE36EF8", Offset = "0xE36EF8", VA = "0xE36EF8")]
		public static void CopyFile(string sourceFile, string destFile, bool move = false)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xE37218", Offset = "0xE37218", VA = "0xE37218")]
		public static void ShowPath(string path)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xE37264", Offset = "0xE37264", VA = "0xE37264")]
		public static void ShowFile(string file)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xE37308", Offset = "0xE37308", VA = "0xE37308")]
		public static void OpenFile(string file)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xE373AC", Offset = "0xE373AC", VA = "0xE373AC")]
		public static string GetIP(string host)
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xE37528", Offset = "0xE37528", VA = "0xE37528")]
		public static string GenerateLoremIpsum(int length, int minSentences = 1, int maxSentences = int.MaxValue, int minWords = 1, int maxWords = 15)
		{
			return null;
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xE37F68", Offset = "0xE37F68", VA = "0xE37F68")]
		public static string LanguageToISO639(SystemLanguage language)
		{
			return null;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xE38198", Offset = "0xE38198", VA = "0xE38198")]
		public static SystemLanguage ISO639ToLanguage(string isoCode)
		{
			return default(SystemLanguage);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xE38D78", Offset = "0xE38D78", VA = "0xE38D78")]
		public static object InvokeMethod(string className, string methodName, params object[] parameters)
		{
			return null;
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xE39370", Offset = "0xE39370", VA = "0xE39370")]
		public static string GetArgument(string name)
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xE39494", Offset = "0xE39494", VA = "0xE39494")]
		public static string[] GetArguments()
		{
			return null;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xE36824", Offset = "0xE36824", VA = "0xE36824")]
		private static string addLeadingZero(int value)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xE36D2C", Offset = "0xE36D2C", VA = "0xE36D2C")]
		private static void copyAll(DirectoryInfo source, DirectoryInfo target)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xE34704", Offset = "0xE34704", VA = "0xE34704")]
		private static void openURL(string url)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xE39540", Offset = "0xE39540", VA = "0xE39540")]
		protected BaseHelper()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public abstract class CTPlayerPrefs
	{
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xE39684", Offset = "0xE39684", VA = "0xE39684")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xE396B4", Offset = "0xE396B4", VA = "0xE396B4")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xE396BC", Offset = "0xE396BC", VA = "0xE396BC")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xE3972C", Offset = "0xE3972C", VA = "0xE3972C")]
		public static void Save()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xE39734", Offset = "0xE39734", VA = "0xE39734")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xE397A4", Offset = "0xE397A4", VA = "0xE397A4")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xE39814", Offset = "0xE39814", VA = "0xE39814")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xE39884", Offset = "0xE39884", VA = "0xE39884")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xE39908", Offset = "0xE39908", VA = "0xE39908")]
		public static DateTime GetDate(string key)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xE399A8", Offset = "0xE399A8", VA = "0xE399A8")]
		public static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xE39A1C", Offset = "0xE39A1C", VA = "0xE39A1C")]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xE39AB0", Offset = "0xE39AB0", VA = "0xE39AB0")]
		public static Vector4 GetVector4(string key)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xE39B6C", Offset = "0xE39B6C", VA = "0xE39B6C")]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xE39BF8", Offset = "0xE39BF8", VA = "0xE39BF8")]
		public static Color GetColor(string key)
		{
			return default(Color);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xE39C84", Offset = "0xE39C84", VA = "0xE39C84")]
		public static SystemLanguage GetLanguage(string key)
		{
			return default(SystemLanguage);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xE39D88", Offset = "0xE39D88", VA = "0xE39D88")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xE39E08", Offset = "0xE39E08", VA = "0xE39E08")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xE39E88", Offset = "0xE39E88", VA = "0xE39E88")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xE39F08", Offset = "0xE39F08", VA = "0xE39F08")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xE39F78", Offset = "0xE39F78", VA = "0xE39F78")]
		public static void SetDate(string key, DateTime value)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xE39FE0", Offset = "0xE39FE0", VA = "0xE39FE0")]
		public static void SetVector2(string key, Vector2 value)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xE3A094", Offset = "0xE3A094", VA = "0xE3A094")]
		public static void SetVector3(string key, Vector3 value)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xE3A174", Offset = "0xE3A174", VA = "0xE3A174")]
		public static void SetVector4(string key, Vector4 value)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xE3A36C", Offset = "0xE3A36C", VA = "0xE3A36C")]
		public static void SetQuaternion(string key, Quaternion value)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xE3A3F8", Offset = "0xE3A3F8", VA = "0xE3A3F8")]
		public static void SetColor(string key, Color value)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xE3A484", Offset = "0xE3A484", VA = "0xE3A484")]
		public static void SetLanguage(string key, SystemLanguage language)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xE3A500", Offset = "0xE3A500", VA = "0xE3A500")]
		protected CTPlayerPrefs()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class CTWebClient : WebClient
	{
		[Token(Token = "0x17000096")]
		public int Timeout
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0xE3A508", Offset = "0xE3A508", VA = "0xE3A508")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xE3A510", Offset = "0xE3A510", VA = "0xE3A510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public int ConnectionLimit
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xE3A518", Offset = "0xE3A518", VA = "0xE3A518")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xE3A520", Offset = "0xE3A520", VA = "0xE3A520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xE3A528", Offset = "0xE3A528", VA = "0xE3A528")]
		public CTWebClient()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xE3A534", Offset = "0xE3A534", VA = "0xE3A534")]
		public CTWebClient(int timeout, int connectionLimit = 20)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xE3A5A4", Offset = "0xE3A5A4", VA = "0xE3A5A4")]
		public WebRequest CTGetWebRequest(string uri)
		{
			return null;
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xE3A620", Offset = "0xE3A620", VA = "0xE3A620", Slot = "9")]
		protected override WebRequest GetWebRequest(Uri uri)
		{
			return null;
		}
	}
	[Token(Token = "0x2000068")]
	public abstract class XmlHelper
	{
		[Token(Token = "0x60002C8")]
		public static void SerializeToFile<T>(T obj, string filename)
		{
		}

		[Token(Token = "0x60002C9")]
		public static T DeserializeFromFile<T>(string filename, bool skipBOM = false)
		{
			return (T)null;
		}

		[Token(Token = "0x60002CA")]
		public static string SerializeToString<T>(T obj)
		{
			return null;
		}

		[Token(Token = "0x60002CB")]
		public static T DeserializeFromString<T>(string xmlAsString, bool skipBOM = true)
		{
			return (T)null;
		}

		[Token(Token = "0x60002CC")]
		public static T DeserializeFromResource<T>(string resourceName, bool skipBOM = true)
		{
			return (T)null;
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xE3A780", Offset = "0xE3A780", VA = "0xE3A780")]
		protected XmlHelper()
		{
		}
	}
}
namespace Crosstales.Common.Model.Enum
{
	[Token(Token = "0x2000069")]
	public enum Platform
	{
		[Token(Token = "0x400026F")]
		Windows,
		[Token(Token = "0x4000270")]
		OSX,
		[Token(Token = "0x4000271")]
		Linux,
		[Token(Token = "0x4000272")]
		IOS,
		[Token(Token = "0x4000273")]
		Android,
		[Token(Token = "0x4000274")]
		WSA,
		[Token(Token = "0x4000275")]
		Web,
		[Token(Token = "0x4000276")]
		Unsupported
	}
	[Token(Token = "0x200006A")]
	public enum SampleRate
	{
		[Token(Token = "0x4000278")]
		_8000Hz = 8000,
		[Token(Token = "0x4000279")]
		_11025Hz = 11025,
		[Token(Token = "0x400027A")]
		_22050Hz = 22050,
		[Token(Token = "0x400027B")]
		_44100Hz = 44100,
		[Token(Token = "0x400027C")]
		_48000Hz = 48000
	}
}
