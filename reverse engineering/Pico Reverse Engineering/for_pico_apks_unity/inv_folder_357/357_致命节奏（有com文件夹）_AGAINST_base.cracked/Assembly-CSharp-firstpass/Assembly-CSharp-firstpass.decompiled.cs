using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

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
namespace VLB
{
	[Token(Token = "0x2000005")]
	public static class BatchingHelper
	{
		[Token(Token = "0x4000001")]
		public const bool isGpuInstancingSupported = true;

		[Token(Token = "0x17000001")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0xBB32E4", Offset = "0xBB32E4", VA = "0xBB32E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xBB3384", Offset = "0xBB3384", VA = "0xBB3384")]
		public static bool IsGpuInstancingEnabled(Material material)
		{
			return default(bool);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xBB3398", Offset = "0xBB3398", VA = "0xBB3398")]
		public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xBB33B0", Offset = "0xBB33B0", VA = "0xBB33B0")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xBB38D0", Offset = "0xBB38D0", VA = "0xBB38D0")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xBB3A24", Offset = "0xBB3A24", VA = "0xBB3A24")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x2000006")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	[ExecuteInEditMode]
	[AddComponentMenu("")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
	{
		[Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class <CoUpdateFadeOut>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400000C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400000D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x20")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x1700000D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000040")]
				[Address(RVA = "0xBB8034", Offset = "0xBB8034", VA = "0xBB8034", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000042")]
				[Address(RVA = "0xBB807C", Offset = "0xBB807C", VA = "0xBB807C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600003D")]
			[Address(RVA = "0xBB3D90", Offset = "0xBB3D90", VA = "0xBB3D90")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0xBB7F94", Offset = "0xBB7F94", VA = "0xBB7F94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600003F")]
			[Address(RVA = "0xBB7F98", Offset = "0xBB7F98", VA = "0xBB7F98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000041")]
			[Address(RVA = "0xBB803C", Offset = "0xBB803C", VA = "0xBB803C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x20")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x60")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x68")]
		private Material m_CustomMaterial;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x70")]
		private MaterialModifier.Callback m_MaterialModifierCallback;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x78")]
		private Coroutine m_CoFadeOut;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x98")]
		private Camera m_CurrentCameraRenderingSRP;

		[Token(Token = "0x17000002")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0xBB3AFC", Offset = "0xBB3AFC", VA = "0xBB3AFC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0xBB3B04", Offset = "0xBB3B04", VA = "0xBB3B04")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0xBB3B0C", Offset = "0xBB3B0C", VA = "0xBB3B0C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0xBB3B14", Offset = "0xBB3B14", VA = "0xBB3B14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public Mesh coneMesh
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0xBB3B1C", Offset = "0xBB3B1C", VA = "0xBB3B1C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0xBB3B24", Offset = "0xBB3B24", VA = "0xBB3B24")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public bool visible
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0xBB3B2C", Offset = "0xBB3B2C", VA = "0xBB3B2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0xBB3B48", Offset = "0xBB3B48", VA = "0xBB3B48")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0xBB3B68", Offset = "0xBB3B68", VA = "0xBB3B68")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0xBB3B84", Offset = "0xBB3B84", VA = "0xBB3B84")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public int sortingOrder
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0xBB3BA0", Offset = "0xBB3BA0", VA = "0xBB3BA0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0xBB3BBC", Offset = "0xBB3BBC", VA = "0xBB3BBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0xBB3BD8", Offset = "0xBB3BD8", VA = "0xBB3BD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0xBB44E0", Offset = "0xBB44E0", VA = "0xBB44E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0xBB44E8", Offset = "0xBB44E8", VA = "0xBB44E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0xBB62DC", Offset = "0xBB62DC", VA = "0xBB62DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0xBB63D0", Offset = "0xBB63D0", VA = "0xBB63D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xBB3BE8", Offset = "0xBB3BE8", VA = "0xBB3BE8")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xBB3D1C", Offset = "0xBB3D1C", VA = "0xBB3D1C")]
		[IteratorStateMachine(typeof(<CoUpdateFadeOut>d__30))]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xBB3DB8", Offset = "0xBB3DB8", VA = "0xBB3DB8")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xBB3EC0", Offset = "0xBB3EC0", VA = "0xBB3EC0")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xBB41D0", Offset = "0xBB41D0", VA = "0xBB41D0")]
		public void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xBB42B0", Offset = "0xBB42B0", VA = "0xBB42B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xBB434C", Offset = "0xBB434C", VA = "0xBB434C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xBB43E8", Offset = "0xBB43E8", VA = "0xBB43E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xBB452C", Offset = "0xBB452C", VA = "0xBB452C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xBB4628", Offset = "0xBB4628", VA = "0xBB4628")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xBB4D68", Offset = "0xBB4D68", VA = "0xBB4D68")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xBB6094", Offset = "0xBB6094", VA = "0xBB6094")]
		private Vector3 ComputeLocalMatrix()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xBB4ABC", Offset = "0xBB4ABC", VA = "0xBB4ABC")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xBB4030", Offset = "0xBB4030", VA = "0xBB4030", Slot = "4")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xBB6B18", Offset = "0xBB6B18", VA = "0xBB6B18", Slot = "5")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xBB6C30", Offset = "0xBB6C30", VA = "0xBB6C30", Slot = "6")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xBB6D48", Offset = "0xBB6D48", VA = "0xBB6D48", Slot = "7")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xBB6E78", Offset = "0xBB6E78", VA = "0xBB6E78", Slot = "8")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xBB3F78", Offset = "0xBB3F78", VA = "0xBB3F78")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xBB4118", Offset = "0xBB4118", VA = "0xBB4118")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xBB6F54", Offset = "0xBB6F54", VA = "0xBB6F54")]
		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xBB5970", Offset = "0xBB5970", VA = "0xBB5970")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xBB778C", Offset = "0xBB778C", VA = "0xBB778C")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xBB7984", Offset = "0xBB7984", VA = "0xBB7984")]
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xBB7990", Offset = "0xBB7990", VA = "0xBB7990")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xBB79C0", Offset = "0xBB79C0", VA = "0xBB79C0")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xBB7AA4", Offset = "0xBB7AA4", VA = "0xBB7AA4")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xBB7F8C", Offset = "0xBB7F8C", VA = "0xBB7F8C")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000008")]
	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[FormerlySerializedAs("renderPipeline")]
		private RenderPipeline _RenderPipeline;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("renderingMode")]
		[SerializeField]
		private RenderingMode _RenderingMode;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x34")]
		public float ditheringFactor;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x38")]
		public int sharedMeshSides;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x3C")]
		public int sharedMeshSegments;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x40")]
		[Range(0.01f, 2f)]
		public float globalNoiseScale;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x50")]
		public string fadeOutCameraTag;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x58")]
		[HighlightNull]
		public TextAsset noise3DData;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x60")]
		public int noise3DSize;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x68")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x70")]
		public Texture2D ditheringNoiseTexture;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x78")]
		public FeatureEnabledColorGradient featureEnabledColorGradient;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x7C")]
		public bool featureEnabledDepthBlend;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x7D")]
		public bool featureEnabledNoise3D;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x7E")]
		public bool featureEnabledDynamicOcclusion;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x7F")]
		public bool featureEnabledMeshSkewing;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x80")]
		public bool featureEnabledShaderAccuracyHigh;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Material _DummyMaterial;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Shader _BeamShader;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x98")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x0")]
		private static Config ms_Instance;

		[Token(Token = "0x1700000F")]
		public RenderPipeline renderPipeline
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0xBB8084", Offset = "0xBB8084", VA = "0xBB8084")]
			get
			{
				return default(RenderPipeline);
			}
			[Token(Token = "0x6000044")]
			[Address(RVA = "0xBB808C", Offset = "0xBB808C", VA = "0xBB808C")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public RenderingMode renderingMode
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0xBB80F4", Offset = "0xBB80F4", VA = "0xBB80F4")]
			get
			{
				return default(RenderingMode);
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0xBB80FC", Offset = "0xBB80FC", VA = "0xBB80FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0xBB3334", Offset = "0xBB3334", VA = "0xBB3334")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000012")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0xBB81F8", Offset = "0xBB81F8", VA = "0xBB81F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		public bool requiresDoubleSidedMesh
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0xBB4FE8", Offset = "0xBB4FE8", VA = "0xBB4FE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000014")]
		public Shader beamShader
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0xBB8210", Offset = "0xBB8210", VA = "0xBB8210")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0xBB3E4C", Offset = "0xBB3E4C", VA = "0xBB3E4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public bool hasRenderPipelineMismatch
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0xBB82B8", Offset = "0xBB82B8", VA = "0xBB82B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public static Config Instance
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xBB332C", Offset = "0xBB332C", VA = "0xBB332C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xBB8164", Offset = "0xBB8164", VA = "0xBB8164")]
		public bool IsSRPBatcherSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xBB8218", Offset = "0xBB8218", VA = "0xBB8218")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xBB82E4", Offset = "0xBB82E4", VA = "0xBB82E4")]
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xBB8444", Offset = "0xBB8444", VA = "0xBB8444")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xBB83C8", Offset = "0xBB83C8", VA = "0xBB83C8")]
		private void RefreshGlobalShaderProperties()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xBB8550", Offset = "0xBB8550", VA = "0xBB8550")]
		public void ResetInternalData()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xBB8798", Offset = "0xBB8798", VA = "0xBB8798")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xBB8938", Offset = "0xBB8938", VA = "0xBB8938")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xBB8944", Offset = "0xBB8944", VA = "0xBB8944")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xBB8948", Offset = "0xBB8948", VA = "0xBB8948")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xBB8AC4", Offset = "0xBB8AC4", VA = "0xBB8AC4")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000009")]
	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x400002A")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xBB8BDC", Offset = "0xBB8BDC", VA = "0xBB8BDC")]
		public ConfigOverride()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public static class Consts
	{
		[Token(Token = "0x400002B")]
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		[Token(Token = "0x400002C")]
		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		[Token(Token = "0x400002D")]
		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		[Token(Token = "0x400002E")]
		public const string HelpUrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/";

		[Token(Token = "0x400002F")]
		public const string HelpUrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/";

		[Token(Token = "0x4000030")]
		public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

		[Token(Token = "0x4000031")]
		public const string HelpUrlSkewingHandle = "http://saladgamer.com/vlb-doc/comp-skewinghandle/";

		[Token(Token = "0x4000032")]
		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x0")]
		public static readonly bool ProceduralObjectsVisibleInEditor;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x4")]
		public static readonly Color FlatColor;

		[Token(Token = "0x4000035")]
		public const ColorMode ColorModeDefault = ColorMode.Flat;

		[Token(Token = "0x4000036")]
		public const float IntensityDefault = 1f;

		[Token(Token = "0x4000037")]
		public const float IntensityMin = 0f;

		[Token(Token = "0x4000038")]
		public const float IntensityMax = 8f;

		[Token(Token = "0x4000039")]
		public const float SpotAngleDefault = 35f;

		[Token(Token = "0x400003A")]
		public const float SpotAngleMin = 0.1f;

		[Token(Token = "0x400003B")]
		public const float SpotAngleMax = 179.9f;

		[Token(Token = "0x400003C")]
		public const float ConeRadiusStart = 0.1f;

		[Token(Token = "0x400003D")]
		public const MeshType GeomMeshType = MeshType.Shared;

		[Token(Token = "0x400003E")]
		public const int GeomSidesDefault = 18;

		[Token(Token = "0x400003F")]
		public const int GeomSidesMin = 3;

		[Token(Token = "0x4000040")]
		public const int GeomSidesMax = 256;

		[Token(Token = "0x4000041")]
		public const int GeomSegmentsDefault = 5;

		[Token(Token = "0x4000042")]
		public const int GeomSegmentsMin = 0;

		[Token(Token = "0x4000043")]
		public const int GeomSegmentsMax = 64;

		[Token(Token = "0x4000044")]
		public const bool GeomCap = false;

		[Token(Token = "0x4000045")]
		public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

		[Token(Token = "0x4000046")]
		public const float AttenuationCustomBlending = 0.5f;

		[Token(Token = "0x4000047")]
		public const float FallOffStart = 0f;

		[Token(Token = "0x4000048")]
		public const float FallOffEnd = 3f;

		[Token(Token = "0x4000049")]
		public const float FallOffDistancesMinThreshold = 0.01f;

		[Token(Token = "0x400004A")]
		public const float DepthBlendDistance = 2f;

		[Token(Token = "0x400004B")]
		public const float CameraClippingDistance = 0.5f;

		[Token(Token = "0x400004C")]
		public const float FresnelPowMaxValue = 10f;

		[Token(Token = "0x400004D")]
		public const float FresnelPow = 8f;

		[Token(Token = "0x400004E")]
		public const float GlareFrontal = 0.5f;

		[Token(Token = "0x400004F")]
		public const float GlareBehind = 0.5f;

		[Token(Token = "0x4000050")]
		public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

		[Token(Token = "0x4000051")]
		public const float NoiseIntensityMin = 0f;

		[Token(Token = "0x4000052")]
		public const float NoiseIntensityMax = 1f;

		[Token(Token = "0x4000053")]
		public const float NoiseIntensityDefault = 0.5f;

		[Token(Token = "0x4000054")]
		public const float NoiseScaleMin = 0.01f;

		[Token(Token = "0x4000055")]
		public const float NoiseScaleMax = 2f;

		[Token(Token = "0x4000056")]
		public const float NoiseScaleDefault = 0.5f;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x14")]
		public static readonly Vector3 NoiseVelocityDefault;

		[Token(Token = "0x4000058")]
		public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

		[Token(Token = "0x4000059")]
		public const ShaderAccuracy ShaderAccuracyDefault = ShaderAccuracy.Fast;

		[Token(Token = "0x400005A")]
		public const float FadeOutBeginDefault = -150f;

		[Token(Token = "0x400005B")]
		public const float FadeOutEndDefault = -200f;

		[Token(Token = "0x400005C")]
		public const Dimensions DimensionsDefault = Dimensions.Dim3D;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Vector2 TiltDefault;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x28")]
		public static readonly Vector3 SkewingLocalForwardDirectionDefault;

		[Token(Token = "0x400005F")]
		public const Transform ClippingPlaneTransformDefault = null;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x34")]
		public static readonly LayerMask DynOcclusionLayerMaskDefault;

		[Token(Token = "0x4000061")]
		public const float DynOcclusionFadeDistanceToSurfaceDefault = 0.25f;

		[Token(Token = "0x4000062")]
		public const DynamicOcclusionUpdateRate DynamicOcclusionUpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames;

		[Token(Token = "0x4000063")]
		public const int DynOcclusionWaitFramesCountDefault = 3;

		[Token(Token = "0x4000064")]
		public const Dimensions DynOcclusionRaycastingDimensionsDefault = Dimensions.Dim3D;

		[Token(Token = "0x4000065")]
		public const bool DynOcclusionRaycastingConsiderTriggersDefault = false;

		[Token(Token = "0x4000066")]
		public const float DynOcclusionRaycastingMinOccluderAreaDefault = 0f;

		[Token(Token = "0x4000067")]
		public const float DynOcclusionRaycastingMinSurfaceRatioDefault = 0.5f;

		[Token(Token = "0x4000068")]
		public const float DynOcclusionRaycastingMinSurfaceRatioMin = 50f;

		[Token(Token = "0x4000069")]
		public const float DynOcclusionRaycastingMinSurfaceRatioMax = 100f;

		[Token(Token = "0x400006A")]
		public const float DynOcclusionRaycastingMaxSurfaceDotDefault = 0.25f;

		[Token(Token = "0x400006B")]
		public const float DynOcclusionRaycastingMaxSurfaceAngleMin = 45f;

		[Token(Token = "0x400006C")]
		public const float DynOcclusionRaycastingMaxSurfaceAngleMax = 90f;

		[Token(Token = "0x400006D")]
		public const PlaneAlignment DynOcclusionRaycastingPlaneAlignmentDefault = PlaneAlignment.Surface;

		[Token(Token = "0x400006E")]
		public const float DynOcclusionRaycastingPlaneOffsetDefault = 0.1f;

		[Token(Token = "0x400006F")]
		public const int DynOcclusionDepthBufferDepthMapResolutionDefault = 32;

		[Token(Token = "0x4000070")]
		public const bool DynOcclusionDepthBufferOcclusionCullingDefault = true;

		[Token(Token = "0x4000071")]
		public const bool ConfigGeometryOverrideLayerDefault = true;

		[Token(Token = "0x4000072")]
		public const int ConfigGeometryLayerIDDefault = 1;

		[Token(Token = "0x4000073")]
		public const string ConfigGeometryTagDefault = "Untagged";

		[Token(Token = "0x4000074")]
		public const string ConfigFadeOutCameraTagDefault = "MainCamera";

		[Token(Token = "0x4000075")]
		public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

		[Token(Token = "0x4000076")]
		public const RenderPipeline ConfigGeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

		[Token(Token = "0x4000077")]
		public const RenderingMode ConfigGeometryRenderingModeDefault = RenderingMode.SinglePass;

		[Token(Token = "0x4000078")]
		public const int ConfigNoise3DSizeDefault = 64;

		[Token(Token = "0x4000079")]
		public const int ConfigSharedMeshSides = 24;

		[Token(Token = "0x400007A")]
		public const int ConfigSharedMeshSegments = 5;

		[Token(Token = "0x400007B")]
		public const float ConfigDitheringFactor = 0f;

		[Token(Token = "0x400007C")]
		public const bool ConfigFeatureEnabledDefault = true;

		[Token(Token = "0x400007D")]
		public const FeatureEnabledColorGradient ConfigFeatureEnabledColorGradientDefault = FeatureEnabledColorGradient.HighOnly;

		[Token(Token = "0x17000018")]
		public static HideFlags ProceduralObjectsHideFlags
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xBB494C", Offset = "0xBB494C", VA = "0xBB494C")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x200000B")]
	public static class DummyMaterial
	{
	}
	[Token(Token = "0x200000C")]
	[DisallowMultipleComponent]
	[AddComponentMenu("")]
	[RequireComponent(typeof(VolumetricLightBeam))]
	public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x200000D")]
		protected enum ProcessOcclusionSource
		{
			[Token(Token = "0x4000086")]
			RenderLoop,
			[Token(Token = "0x4000087")]
			OnEnable,
			[Token(Token = "0x4000088")]
			EditorUpdate,
			[Token(Token = "0x4000089")]
			User
		}

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x18")]
		public DynamicOcclusionUpdateRate updateRate;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x1C")]
		[FormerlySerializedAs("waitFrameCount")]
		public int waitXFrames;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x0")]
		public static bool _INTERNAL_ApplyRandomFrameOffset;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x28")]
		private TransformUtils.Packed m_TransformPacked;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x30")]
		private int m_LastFrameRendered;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x38")]
		protected VolumetricLightBeam m_Master;

		[Token(Token = "0x17000019")]
		public int _INTERNAL_LastFrameRendered
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0xBB9114", Offset = "0xBB9114", VA = "0xBB9114")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action onOcclusionProcessed
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0xBB8E98", Offset = "0xBB8E98", VA = "0xBB8E98")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600005E")]
			[Address(RVA = "0xBB8F34", Offset = "0xBB8F34", VA = "0xBB8F34")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xBB8CF0", Offset = "0xBB8CF0", VA = "0xBB8CF0")]
		public void ProcessOcclusionManually()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xBB8CF8", Offset = "0xBB8CF8", VA = "0xBB8CF8")]
		protected void ProcessOcclusion(ProcessOcclusionSource source)
		{
		}

		[Token(Token = "0x6000061")]
		protected abstract string GetShaderKeyword();

		[Token(Token = "0x6000062")]
		protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

		[Token(Token = "0x6000063")]
		protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

		[Token(Token = "0x6000064")]
		protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

		[Token(Token = "0x6000065")]
		protected abstract void OnEnablePostValidate();

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xBB911C", Offset = "0xBB911C", VA = "0xBB911C", Slot = "9")]
		protected virtual void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xBB913C", Offset = "0xBB913C", VA = "0xBB913C", Slot = "10")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xBB91BC", Offset = "0xBB91BC", VA = "0xBB91BC", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xBB9208", Offset = "0xBB9208", VA = "0xBB9208", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xBB95F0", Offset = "0xBB95F0", VA = "0xBB95F0", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xBB9718", Offset = "0xBB9718", VA = "0xBB9718")]
		private void OnWillCameraRender(Camera cam)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xBB91D8", Offset = "0xBB91D8", VA = "0xBB91D8")]
		private void DisableOcclusion()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xBB9908", Offset = "0xBB9908", VA = "0xBB9908")]
		protected DynamicOcclusionAbstractBase()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/")]
	[ExecuteInEditMode]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x40")]
		public LayerMask layerMask;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x44")]
		public bool useOcclusionCulling;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x48")]
		public int depthMapResolution;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x4C")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x50")]
		private Camera m_DepthCamera;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x58")]
		private bool m_NeedToUpdateOcclusionNextFrame;

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xBB9978", Offset = "0xBB9978", VA = "0xBB9978", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xBB99B8", Offset = "0xBB99B8", VA = "0xBB99B8", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xBB99C0", Offset = "0xBB99C0", VA = "0xBB99C0")]
		private void ProcessOcclusionInternal()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xBB9BD0", Offset = "0xBB9BD0", VA = "0xBB9BD0", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xBB9C04", Offset = "0xBB9C04", VA = "0xBB9C04")]
		private void Update()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xBB99E4", Offset = "0xBB99E4", VA = "0xBB99E4")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xBB9DD0", Offset = "0xBB9DD0", VA = "0xBB9DD0")]
		public bool HasLayerMaskIssues()
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xBB9E34", Offset = "0xBB9E34", VA = "0xBB9E34", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xBB9E98", Offset = "0xBB9E98", VA = "0xBB9E98")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xBBA174", Offset = "0xBBA174", VA = "0xBBA174", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xBBA178", Offset = "0xBBA178", VA = "0xBBA178", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xBBA210", Offset = "0xBBA210", VA = "0xBBA210", Slot = "10")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xBBA214", Offset = "0xBBA214", VA = "0xBBA214", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xBBA22C", Offset = "0xBBA22C", VA = "0xBBA22C")]
		private void DestroyDepthCamera()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xBBA37C", Offset = "0xBBA37C", VA = "0xBBA37C", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xBBA4F8", Offset = "0xBBA4F8", VA = "0xBBA4F8")]
		public DynamicOcclusionDepthBuffer()
		{
		}
	}
	[Token(Token = "0x200000F")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/")]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x2000010")]
		public class HitResult
		{
			[Token(Token = "0x400009D")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x400009E")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 normal;

			[Token(Token = "0x400009F")]
			[FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x40000A0")]
			[FieldOffset(Offset = "0x30")]
			private Collider2D collider2D;

			[Token(Token = "0x40000A1")]
			[FieldOffset(Offset = "0x38")]
			private Collider collider3D;

			[Token(Token = "0x1700001F")]
			public bool hasCollider
			{
				[Token(Token = "0x60000A0")]
				[Address(RVA = "0xBBB498", Offset = "0xBBB498", VA = "0xBBB498")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000020")]
			public string name
			{
				[Token(Token = "0x60000A1")]
				[Address(RVA = "0xBBBEDC", Offset = "0xBBBEDC", VA = "0xBBBEDC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000021")]
			public Bounds bounds
			{
				[Token(Token = "0x60000A2")]
				[Address(RVA = "0xBBBFA0", Offset = "0xBBBFA0", VA = "0xBBBFA0")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x600009D")]
			[Address(RVA = "0xBBB108", Offset = "0xBBB108", VA = "0xBBB108")]
			public HitResult(RaycastHit hit3D)
			{
			}

			[Token(Token = "0x600009E")]
			[Address(RVA = "0xBBB21C", Offset = "0xBBB21C", VA = "0xBBB21C")]
			public HitResult(RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x600009F")]
			[Address(RVA = "0xBBB18C", Offset = "0xBBB18C", VA = "0xBBB18C")]
			public HitResult()
			{
			}
		}

		[Token(Token = "0x2000011")]
		private enum Direction
		{
			[Token(Token = "0x40000A3")]
			Up = 0,
			[Token(Token = "0x40000A4")]
			Down = 1,
			[Token(Token = "0x40000A5")]
			Left = 2,
			[Token(Token = "0x40000A6")]
			Right = 3,
			[Token(Token = "0x40000A7")]
			Max2D = 1,
			[Token(Token = "0x40000A8")]
			Max3D = 3
		}

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x40")]
		public Dimensions dimensions;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x44")]
		public LayerMask layerMask;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x48")]
		public bool considerTriggers;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x4C")]
		public float minOccluderArea;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x50")]
		public float minSurfaceRatio;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x54")]
		public float maxSurfaceDot;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x58")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x5C")]
		public float planeOffset;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x60")]
		[FormerlySerializedAs("fadeDistanceToPlane")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x70")]
		private float m_RangeMultiplier;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x84")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x1700001A")]
		[Obsolete("Use 'fadeDistanceToSurface' instead")]
		public float fadeDistanceToPlane
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0xBBA5AC", Offset = "0xBBA5AC", VA = "0xBBA5AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0xBBA5B4", Offset = "0xBBA5B4", VA = "0xBBA5B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public HitResult currentHit
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0xBBA6D0", Offset = "0xBBA6D0", VA = "0xBBA6D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000084")]
			[Address(RVA = "0xBBA6D8", Offset = "0xBBA6D8", VA = "0xBBA6D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0xBBA728", Offset = "0xBBA728", VA = "0xBBA728")]
			[CompilerGenerated]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xBBA734", Offset = "0xBBA734", VA = "0xBBA734")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xBBA9B0", Offset = "0xBBA9B0", VA = "0xBBA9B0")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x1700001E")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xBBA9C4", Offset = "0xBBA9C4", VA = "0xBBA9C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xBBA5BC", Offset = "0xBBA5BC", VA = "0xBBA5BC")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xBBA6E0", Offset = "0xBBA6E0", VA = "0xBBA6E0", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xBBA720", Offset = "0xBBA720", VA = "0xBBA720", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xBBA740", Offset = "0xBBA740", VA = "0xBBA740", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xBBA77C", Offset = "0xBBA77C", VA = "0xBBA77C", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xBBA788", Offset = "0xBBA788", VA = "0xBBA788", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xBBA854", Offset = "0xBBA854", VA = "0xBBA854")]
		private void Start()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xBBA900", Offset = "0xBBA900", VA = "0xBBA900")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xBBAAE4", Offset = "0xBBAAE4", VA = "0xBBAAE4")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xBBAAF8", Offset = "0xBBAAF8", VA = "0xBBAAF8")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xBBAD9C", Offset = "0xBBAD9C", VA = "0xBBAD9C")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xBBB2A0", Offset = "0xBBB2A0", VA = "0xBBB2A0")]
		private uint GetDirectionCount()
		{
			return default(uint);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xBBB2B8", Offset = "0xBBB2B8", VA = "0xBBB2B8")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xBBB41C", Offset = "0xBBB41C", VA = "0xBBB41C")]
		private bool IsHitValid(HitResult hit, Vector3 forwardVec)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xBBB528", Offset = "0xBBB528", VA = "0xBBB528", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xBBA7B0", Offset = "0xBBA7B0", VA = "0xBBA7B0")]
		private void SetHit(HitResult hit)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xBBBAE0", Offset = "0xBBBAE0", VA = "0xBBBAE0", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xBBB9D4", Offset = "0xBBB9D4", VA = "0xBBB9D4")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xBBB99C", Offset = "0xBBB99C", VA = "0xBBB99C")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xBBBE10", Offset = "0xBBBE10", VA = "0xBBBE10")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xBBBE1C", Offset = "0xBBBE1C", VA = "0xBBBE1C")]
		public DynamicOcclusionRaycasting()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public enum FeatureEnabledColorGradient
	{
		[Token(Token = "0x40000AA")]
		Off,
		[Token(Token = "0x40000AB")]
		HighOnly,
		[Token(Token = "0x40000AC")]
		HighAndLow
	}
	[Token(Token = "0x2000013")]
	public enum ColorMode
	{
		[Token(Token = "0x40000AE")]
		Flat,
		[Token(Token = "0x40000AF")]
		Gradient
	}
	[Token(Token = "0x2000014")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x40000B1")]
		Linear,
		[Token(Token = "0x40000B2")]
		Quadratic,
		[Token(Token = "0x40000B3")]
		Blend
	}
	[Token(Token = "0x2000015")]
	public enum BlendingMode
	{
		[Token(Token = "0x40000B5")]
		Additive,
		[Token(Token = "0x40000B6")]
		SoftAdditive,
		[Token(Token = "0x40000B7")]
		TraditionalTransparency
	}
	[Token(Token = "0x2000016")]
	public enum ShaderAccuracy
	{
		[Token(Token = "0x40000B9")]
		Fast,
		[Token(Token = "0x40000BA")]
		High
	}
	[Token(Token = "0x2000017")]
	public enum NoiseMode
	{
		[Token(Token = "0x40000BC")]
		Disabled,
		[Token(Token = "0x40000BD")]
		WorldSpace,
		[Token(Token = "0x40000BE")]
		LocalSpace
	}
	[Token(Token = "0x2000018")]
	public enum MeshType
	{
		[Token(Token = "0x40000C0")]
		Shared,
		[Token(Token = "0x40000C1")]
		Custom
	}
	[Token(Token = "0x2000019")]
	public enum RenderPipeline
	{
		[Token(Token = "0x40000C3")]
		BuiltIn,
		[Token(Token = "0x40000C4")]
		URP,
		[Token(Token = "0x40000C5")]
		HDRP
	}
	[Token(Token = "0x200001A")]
	public enum RenderingMode
	{
		[Token(Token = "0x40000C7")]
		MultiPass,
		[Token(Token = "0x40000C8")]
		SinglePass,
		[Token(Token = "0x40000C9")]
		GPUInstancing,
		[Token(Token = "0x40000CA")]
		SRPBatcher
	}
	[Token(Token = "0x200001B")]
	public enum RenderQueue
	{
		[Token(Token = "0x40000CC")]
		Custom = 0,
		[Token(Token = "0x40000CD")]
		Background = 1000,
		[Token(Token = "0x40000CE")]
		Geometry = 2000,
		[Token(Token = "0x40000CF")]
		AlphaTest = 2450,
		[Token(Token = "0x40000D0")]
		GeometryLast = 2500,
		[Token(Token = "0x40000D1")]
		Transparent = 3000,
		[Token(Token = "0x40000D2")]
		Overlay = 4000
	}
	[Token(Token = "0x200001C")]
	public enum Dimensions
	{
		[Token(Token = "0x40000D4")]
		Dim3D,
		[Token(Token = "0x40000D5")]
		Dim2D
	}
	[Token(Token = "0x200001D")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x40000D7")]
		Surface,
		[Token(Token = "0x40000D8")]
		Beam
	}
	[Token(Token = "0x200001E")]
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		[Token(Token = "0x40000DA")]
		Never = 1,
		[Token(Token = "0x40000DB")]
		OnEnable = 2,
		[Token(Token = "0x40000DC")]
		OnBeamMove = 4,
		[Token(Token = "0x40000DD")]
		EveryXFrames = 8,
		[Token(Token = "0x40000DE")]
		OnBeamMoveAndEveryXFrames = 0xC
	}
	[Token(Token = "0x200001F")]
	public enum ParticlesDirection
	{
		[Token(Token = "0x40000E0")]
		Random,
		[Token(Token = "0x40000E1")]
		LocalSpace,
		[Token(Token = "0x40000E2")]
		WorldSpace
	}
	[Token(Token = "0x2000020")]
	public static class GlobalMesh
	{
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xBB57EC", Offset = "0xBB57EC", VA = "0xBB57EC")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xBBC088", Offset = "0xBBC088", VA = "0xBBC088")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xBBC154", Offset = "0xBBC154", VA = "0xBBC154")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public static class MaterialManager
	{
		[Token(Token = "0x2000023")]
		public enum BlendingMode
		{
			[Token(Token = "0x40000EC")]
			Additive,
			[Token(Token = "0x40000ED")]
			SoftAdditive,
			[Token(Token = "0x40000EE")]
			TraditionalTransparency,
			[Token(Token = "0x40000EF")]
			Count
		}

		[Token(Token = "0x2000024")]
		public enum Noise3D
		{
			[Token(Token = "0x40000F1")]
			Off,
			[Token(Token = "0x40000F2")]
			On,
			[Token(Token = "0x40000F3")]
			Count
		}

		[Token(Token = "0x2000025")]
		public enum DepthBlend
		{
			[Token(Token = "0x40000F5")]
			Off,
			[Token(Token = "0x40000F6")]
			On,
			[Token(Token = "0x40000F7")]
			Count
		}

		[Token(Token = "0x2000026")]
		public enum ColorGradient
		{
			[Token(Token = "0x40000F9")]
			Off,
			[Token(Token = "0x40000FA")]
			MatrixLow,
			[Token(Token = "0x40000FB")]
			MatrixHigh,
			[Token(Token = "0x40000FC")]
			Count
		}

		[Token(Token = "0x2000027")]
		public enum DynamicOcclusion
		{
			[Token(Token = "0x40000FE")]
			Off,
			[Token(Token = "0x40000FF")]
			ClippingPlane,
			[Token(Token = "0x4000100")]
			DepthTexture,
			[Token(Token = "0x4000101")]
			Count
		}

		[Token(Token = "0x2000028")]
		public enum MeshSkewing
		{
			[Token(Token = "0x4000103")]
			Off,
			[Token(Token = "0x4000104")]
			On,
			[Token(Token = "0x4000105")]
			Count
		}

		[Token(Token = "0x2000029")]
		public enum ShaderAccuracy
		{
			[Token(Token = "0x4000107")]
			Fast,
			[Token(Token = "0x4000108")]
			High,
			[Token(Token = "0x4000109")]
			Count
		}

		[Token(Token = "0x200002A")]
		public class StaticProperties
		{
			[Token(Token = "0x400010A")]
			[FieldOffset(Offset = "0x10")]
			public BlendingMode blendingMode;

			[Token(Token = "0x400010B")]
			[FieldOffset(Offset = "0x14")]
			public Noise3D noise3D;

			[Token(Token = "0x400010C")]
			[FieldOffset(Offset = "0x18")]
			public DepthBlend depthBlend;

			[Token(Token = "0x400010D")]
			[FieldOffset(Offset = "0x1C")]
			public ColorGradient colorGradient;

			[Token(Token = "0x400010E")]
			[FieldOffset(Offset = "0x20")]
			public DynamicOcclusion dynamicOcclusion;

			[Token(Token = "0x400010F")]
			[FieldOffset(Offset = "0x24")]
			public MeshSkewing meshSkewing;

			[Token(Token = "0x4000110")]
			[FieldOffset(Offset = "0x28")]
			public ShaderAccuracy shaderAccuracy;

			[Token(Token = "0x17000022")]
			public int materialID
			{
				[Token(Token = "0x60000AA")]
				[Address(RVA = "0xBBC2EC", Offset = "0xBBC2EC", VA = "0xBBC2EC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60000AB")]
			[Address(RVA = "0xBB65AC", Offset = "0xBB65AC", VA = "0xBB65AC")]
			public void ApplyToMaterial(Material mat)
			{
			}

			[Token(Token = "0x60000AC")]
			[Address(RVA = "0xBB6478", Offset = "0xBB6478", VA = "0xBB6478")]
			public StaticProperties()
			{
			}
		}

		[Token(Token = "0x200002B")]
		private class MaterialsGroup
		{
			[Token(Token = "0x4000111")]
			[FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x60000AD")]
			[Address(RVA = "0xBBC25C", Offset = "0xBBC25C", VA = "0xBBC25C")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x20")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xBB49B0", Offset = "0xBB49B0", VA = "0xBB49B0")]
		public static Material NewMaterialTransient(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xBBC15C", Offset = "0xBBC15C", VA = "0xBBC15C")]
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xBB687C", Offset = "0xBB687C", VA = "0xBB687C")]
		public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x200002C")]
	public static class MeshGenerator
	{
		[Token(Token = "0x4000112")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xBBC4FC", Offset = "0xBBC4FC", VA = "0xBBC4FC")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xBBC514", Offset = "0xBBC514", VA = "0xBBC514")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xBBC584", Offset = "0xBBC584", VA = "0xBBC584")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xBB5000", Offset = "0xBB5000", VA = "0xBB5000")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xBB7754", Offset = "0xBB7754", VA = "0xBB7754")]
		public static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xBBC5F0", Offset = "0xBBC5F0", VA = "0xBBC5F0")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xBBC60C", Offset = "0xBBC60C", VA = "0xBBC60C")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xBBC634", Offset = "0xBBC634", VA = "0xBBC634")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xBBC694", Offset = "0xBBC694", VA = "0xBBC694")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Token(Token = "0x200002D")]
	public static class Noise3D
	{
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x4000116")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x4000117")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x17000023")]
		public static bool isSupported
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0xBB6314", Offset = "0xBB6314", VA = "0xBB6314")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000024")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0xBBC79C", Offset = "0xBBC79C", VA = "0xBBC79C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000025")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0xBBC6F8", Offset = "0xBBC6F8", VA = "0xBBC6F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xBBC814", Offset = "0xBBC814", VA = "0xBBC814")]
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xBB737C", Offset = "0xBB737C", VA = "0xBB737C")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xBBC818", Offset = "0xBBC818", VA = "0xBBC818")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x200002E")]
	public class PlatformHelper
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xBB8AB0", Offset = "0xBB8AB0", VA = "0xBB8AB0")]
		public static string GetCurrentPlatformSuffix()
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xBBCAB8", Offset = "0xBBCAB8", VA = "0xBBCAB8")]
		private static string GetPlatformSuffix(RuntimePlatform platform)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xBBCB1C", Offset = "0xBBCB1C", VA = "0xBBCB1C")]
		public PlatformHelper()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class PolygonHelper : MonoBehaviour
	{
		[Token(Token = "0x2000030")]
		public struct Plane2D
		{
			[Token(Token = "0x4000118")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 normal;

			[Token(Token = "0x4000119")]
			[FieldOffset(Offset = "0x8")]
			public float distance;

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0xBBCB2C", Offset = "0xBBCB2C", VA = "0xBBCB2C")]
			public float Distance(Vector2 point)
			{
				return default(float);
			}

			[Token(Token = "0x60000C2")]
			[Address(RVA = "0xBBCB48", Offset = "0xBBCB48", VA = "0xBBCB48")]
			public Vector2 ClosestPoint(Vector2 pt)
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xBBCB74", Offset = "0xBBCB74", VA = "0xBBCB74")]
			public Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xBBCC04", Offset = "0xBBCC04", VA = "0xBBCC04")]
			public bool GetSide(Vector2 point)
			{
				return default(bool);
			}

			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xBBCC28", Offset = "0xBBCC28", VA = "0xBBCC28")]
			public static Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xBBCD20", Offset = "0xBBCD20", VA = "0xBBCD20")]
			public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xBBCD30", Offset = "0xBBCD30", VA = "0xBBCD30")]
			public void Flip()
			{
			}

			[Token(Token = "0x60000C8")]
			[Address(RVA = "0xBBCD4C", Offset = "0xBBCD4C", VA = "0xBBCD4C")]
			public Vector2[] CutConvex(Vector2[] poly)
			{
				return null;
			}

			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xBBCFEC", Offset = "0xBBCFEC", VA = "0xBBCFEC", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xBBCB24", Offset = "0xBBCB24", VA = "0xBBCB24")]
		public PolygonHelper()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public static class ShaderKeywords
	{
		[Token(Token = "0x400011A")]
		public const string AlphaAsBlack = "VLB_ALPHA_AS_BLACK";

		[Token(Token = "0x400011B")]
		public const string ColorGradientMatrixLow = "VLB_COLOR_GRADIENT_MATRIX_LOW";

		[Token(Token = "0x400011C")]
		public const string ColorGradientMatrixHigh = "VLB_COLOR_GRADIENT_MATRIX_HIGH";

		[Token(Token = "0x400011D")]
		public const string DepthBlend = "VLB_DEPTH_BLEND";

		[Token(Token = "0x400011E")]
		public const string Noise3D = "VLB_NOISE_3D";

		[Token(Token = "0x400011F")]
		public const string OcclusionClippingPlane = "VLB_OCCLUSION_CLIPPING_PLANE";

		[Token(Token = "0x4000120")]
		public const string OcclusionDepthTexture = "VLB_OCCLUSION_DEPTH_TEXTURE";

		[Token(Token = "0x4000121")]
		public const string MeshSkewing = "VLB_MESH_SKEWING";

		[Token(Token = "0x4000122")]
		public const string ShaderAccuracyHigh = "VLB_SHADER_ACCURACY_HIGH";
	}
	[Token(Token = "0x2000032")]
	public static class ShaderProperties
	{
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int FadeOutFactor;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int ConeSlopeCosSin;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int ConeRadius;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int ConeApexOffsetZ;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int ColorFlat;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int AlphaInside;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int AlphaOutside;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly int AttenuationLerpLinearQuad;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x20")]
		public static readonly int DistanceFallOff;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x24")]
		public static readonly int DistanceCamClipping;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x28")]
		public static readonly int FresnelPow;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly int GlareBehind;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x30")]
		public static readonly int GlareFrontal;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x34")]
		public static readonly int DrawCap;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x38")]
		public static readonly int DepthBlendDistance;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x3C")]
		public static readonly int NoiseVelocityAndScale;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x40")]
		public static readonly int NoiseParam;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x44")]
		public static readonly int CameraParams;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x48")]
		public static readonly int ColorGradientMatrix;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x4C")]
		public static readonly int LocalToWorldMatrix;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x50")]
		public static readonly int WorldToLocalMatrix;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x54")]
		public static readonly int BlendSrcFactor;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x58")]
		public static readonly int BlendDstFactor;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x5C")]
		public static readonly int DynamicOcclusionClippingPlaneWS;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x60")]
		public static readonly int DynamicOcclusionClippingPlaneProps;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x64")]
		public static readonly int DynamicOcclusionDepthTexture;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x68")]
		public static readonly int DynamicOcclusionDepthProps;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x6C")]
		public static readonly int LocalForwardDirection;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x70")]
		public static readonly int TiltVector;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x74")]
		public static readonly int AdditionalClippingPlaneWS;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x78")]
		public static readonly int GlobalNoiseTex3D;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x7C")]
		public static readonly int GlobalNoiseCustomTime;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x80")]
		public static readonly int GlobalDitheringFactor;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x84")]
		public static readonly int GlobalDitheringNoiseTex;
	}
	[Token(Token = "0x2000033")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-skewinghandle/")]
	[ExecuteInEditMode]
	public class SkewingHandle : MonoBehaviour
	{
		[Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class <CoUpdate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000147")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000148")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000149")]
			[FieldOffset(Offset = "0x20")]
			public SkewingHandle <>4__this;

			[Token(Token = "0x17000026")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000D7")]
				[Address(RVA = "0xBBDA7C", Offset = "0xBBDA7C", VA = "0xBBDA7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000027")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000D9")]
				[Address(RVA = "0xBBDAC4", Offset = "0xBBDAC4", VA = "0xBBDAC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xBBD9D4", Offset = "0xBBD9D4", VA = "0xBBD9D4")]
			[DebuggerHidden]
			public <CoUpdate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xBBDA04", Offset = "0xBBDA04", VA = "0xBBDA04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xBBDA08", Offset = "0xBBDA08", VA = "0xBBDA08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xBBDA84", Offset = "0xBBDA84", VA = "0xBBDA84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x18")]
		public VolumetricLightBeam volumetricLightBeam;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x20")]
		public bool shouldUpdateEachFrame;

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xBBD6E4", Offset = "0xBBD6E4", VA = "0xBBD6E4")]
		public bool IsAttachedToSelf()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xBBD7A4", Offset = "0xBBD7A4", VA = "0xBBD7A4")]
		public bool CanSetSkewingVector()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xBBD83C", Offset = "0xBBD83C", VA = "0xBBD83C")]
		public bool CanUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xBBD874", Offset = "0xBBD874", VA = "0xBBD874")]
		private bool ShouldUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xBBD888", Offset = "0xBBD888", VA = "0xBBD888")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xBBD914", Offset = "0xBBD914", VA = "0xBBD914")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xBBD960", Offset = "0xBBD960", VA = "0xBBD960")]
		[IteratorStateMachine(typeof(<CoUpdate>d__8))]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xBBD8AC", Offset = "0xBBD8AC", VA = "0xBBD8AC")]
		private void SetSkewingVector()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xBBD9FC", Offset = "0xBBD9FC", VA = "0xBBD9FC")]
		public SkewingHandle()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public static class SRPHelper
	{
		[Token(Token = "0x2000036")]
		public enum RenderPipeline
		{
			[Token(Token = "0x400014C")]
			Undefined,
			[Token(Token = "0x400014D")]
			BuiltIn,
			[Token(Token = "0x400014E")]
			URP,
			[Token(Token = "0x400014F")]
			LWRP,
			[Token(Token = "0x4000150")]
			HDRP
		}

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x0")]
		private static RenderPipeline m_RenderPipelineCached;

		[Token(Token = "0x17000028")]
		public static RenderPipeline renderPipelineType
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xBB819C", Offset = "0xBB819C", VA = "0xBB819C")]
			get
			{
				return default(RenderPipeline);
			}
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xBBDACC", Offset = "0xBBDACC", VA = "0xBBDACC")]
		private static RenderPipeline ComputeRenderPipeline()
		{
			return default(RenderPipeline);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xBB78A8", Offset = "0xBB78A8", VA = "0xBB78A8")]
		public static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xBB45B0", Offset = "0xBB45B0", VA = "0xBB45B0")]
		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xBB4474", Offset = "0xBB4474", VA = "0xBB4474")]
		public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}
	}
	[Token(Token = "0x2000037")]
	public static class TransformUtils
	{
		[Token(Token = "0x2000038")]
		public class Packed
		{
			[Token(Token = "0x4000151")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 position;

			[Token(Token = "0x4000152")]
			[FieldOffset(Offset = "0x1C")]
			public Quaternion rotation;

			[Token(Token = "0x4000153")]
			[FieldOffset(Offset = "0x2C")]
			public Vector3 lossyScale;

			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xBBDBF4", Offset = "0xBBDBF4", VA = "0xBBDBF4")]
			public Packed()
			{
			}
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xBB9074", Offset = "0xBB9074", VA = "0xBB9074")]
		public static Packed GetWorldPacked(this Transform self)
		{
			return null;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xBB9810", Offset = "0xBB9810", VA = "0xBB9810")]
		public static bool IsSame(this Transform self, Packed packed)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000039")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-triggerzone/")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x200003A")]
		private enum TriggerZoneUpdateRate
		{
			[Token(Token = "0x400015B")]
			OnEnable,
			[Token(Token = "0x400015C")]
			OnOcclusionChange
		}

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x4000156")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x20")]
		private VolumetricLightBeam m_Beam;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x28")]
		private DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x30")]
		private PolygonCollider2D m_PolygonCollider2D;

		[Token(Token = "0x17000029")]
		private TriggerZoneUpdateRate updateRate
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xBBDBFC", Offset = "0xBBDBFC", VA = "0xBBDBFC")]
			get
			{
				return default(TriggerZoneUpdateRate);
			}
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xBBDC80", Offset = "0xBBDC80", VA = "0xBBDC80")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xBBE338", Offset = "0xBBE338", VA = "0xBBE338")]
		private void OnOcclusionProcessed()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xBBDDF4", Offset = "0xBBDDF4", VA = "0xBBDDF4")]
		private void ComputeZone()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xBBE3EC", Offset = "0xBBE3EC", VA = "0xBBE3EC")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public static class Utils
	{
		[Token(Token = "0x200003C")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x4000160")]
			High = 64,
			[Token(Token = "0x4000161")]
			Low = 8,
			[Token(Token = "0x4000162")]
			Undef = 0
		}

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x400015E")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xBBE404", Offset = "0xBBE404", VA = "0xBBE404")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xBB4C7C", Offset = "0xBB4C7C", VA = "0xBB4C7C")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xBBE438", Offset = "0xBBE438", VA = "0xBBE438")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xBBE508", Offset = "0xBBE508", VA = "0xBBE508")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xBBE50C", Offset = "0xBBE50C", VA = "0xBBE50C")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xBBE514", Offset = "0xBBE514", VA = "0xBBE514")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xBBE520", Offset = "0xBBE520", VA = "0xBBE520")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xBBE530", Offset = "0xBBE530", VA = "0xBBE530")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xBBE53C", Offset = "0xBBE53C", VA = "0xBBE53C")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xBBE544", Offset = "0xBBE544", VA = "0xBBE544")]
		public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xBBE564", Offset = "0xBBE564", VA = "0xBBE564")]
		public static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xBBE590", Offset = "0xBBE590", VA = "0xBBE590")]
		public static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xBBE5CC", Offset = "0xBBE5CC", VA = "0xBBE5CC")]
		public static Vector4 AsVector4(this Vector3 vec3, float w)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xBBE5D0", Offset = "0xBBE5D0", VA = "0xBBE5D0")]
		public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xBBE5EC", Offset = "0xBBE5EC", VA = "0xBBE5EC")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xBBB078", Offset = "0xBBB078", VA = "0xBBB078")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xBBE634", Offset = "0xBBE634", VA = "0xBBE634")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xBBBCA4", Offset = "0xBBBCA4", VA = "0xBBBCA4")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xBBE374", Offset = "0xBBE374", VA = "0xBBE374")]
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xBBCBEC", Offset = "0xBBCBEC", VA = "0xBBCBEC")]
		public static bool IsAlmostZero(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xBBA688", Offset = "0xBBA688", VA = "0xBBA688")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xBB7028", Offset = "0xBB7028", VA = "0xBB7028")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xBBE63C", Offset = "0xBBE63C", VA = "0xBBE63C")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xBB7168", Offset = "0xBB7168", VA = "0xBB7168")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xBBE6AC", Offset = "0xBBE6AC", VA = "0xBBE6AC")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xBBE790", Offset = "0xBBE790", VA = "0xBBE790")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xBBE650", Offset = "0xBBE650", VA = "0xBBE650")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xBB6408", Offset = "0xBB6408", VA = "0xBB6408")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xBBE7A4", Offset = "0xBBE7A4", VA = "0xBBE7A4")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xBBE7A8", Offset = "0xBBE7A8", VA = "0xBBE7A8")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x200003D")]
	public static class Version
	{
		[Token(Token = "0x4000163")]
		public const int Current = 1910;
	}
	[Token(Token = "0x200003E")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dustparticles/")]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float alpha;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0.0001f, 0.1f)]
		public float size;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x20")]
		public ParticlesDirection direction;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 velocity;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x30")]
		[Obsolete("Use 'velocity' instead")]
		public float speed;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x34")]
		public float density;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float spawnMinDistance;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float spawnMaxDistance;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x40")]
		public bool cullingEnabled;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x44")]
		public float cullingMaxDistance;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x50")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x58")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x60")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x1700002A")]
		public bool isCulled
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0xBBE7AC", Offset = "0xBBE7AC", VA = "0xBBE7AC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010A")]
			[Address(RVA = "0xBBE7B4", Offset = "0xBBE7B4", VA = "0xBBE7B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0xBBE7C0", Offset = "0xBBE7C0", VA = "0xBBE7C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002C")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0xBBE81C", Offset = "0xBBE81C", VA = "0xBBE81C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002D")]
		public int particlesMaxCount
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0xBBE8A0", Offset = "0xBBE8A0", VA = "0xBBE8A0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002E")]
		public Camera mainCamera
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0xBBE93C", Offset = "0xBBE93C", VA = "0xBBE93C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xBBEB54", Offset = "0xBBEB54", VA = "0xBBEB54")]
		private void Start()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xBBEC38", Offset = "0xBBEC38", VA = "0xBBEC38")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xBBEEC8", Offset = "0xBBEEC8", VA = "0xBBEEC8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xBBEE1C", Offset = "0xBBEE1C", VA = "0xBBEE1C")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xBBF58C", Offset = "0xBBF58C", VA = "0xBBF58C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xBBF61C", Offset = "0xBBF61C", VA = "0xBBF61C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xBBF6C4", Offset = "0xBBF6C4", VA = "0xBBF6C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xBBEECC", Offset = "0xBBEECC", VA = "0xBBEECC")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xBBEC00", Offset = "0xBBEC00", VA = "0xBBEC00")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xBBF6EC", Offset = "0xBBF6EC", VA = "0xBBF6EC")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xBBFA40", Offset = "0xBBFA40", VA = "0xBBFA40")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x2000040")]
		public delegate void OnWillCameraRenderCB(Camera cam);

		[Token(Token = "0x2000041")]
		public delegate void OnBeamGeometryInitialized();

		[Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class <CoPlaytimeUpdate>d__184 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001A8")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001A9")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001AA")]
			[FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x1700005F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000181")]
				[Address(RVA = "0xBC1034", Offset = "0xBC1034", VA = "0xBC1034", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000060")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000183")]
				[Address(RVA = "0xBC107C", Offset = "0xBC107C", VA = "0xBC107C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600017E")]
			[Address(RVA = "0xBC0B0C", Offset = "0xBC0B0C", VA = "0xBC0B0C")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__184(int <>1__state)
			{
			}

			[Token(Token = "0x600017F")]
			[Address(RVA = "0xBC0FA0", Offset = "0xBC0FA0", VA = "0xBC0FA0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000180")]
			[Address(RVA = "0xBC0FA4", Offset = "0xBC0FA4", VA = "0xBC0FA4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000182")]
			[Address(RVA = "0xBC103C", Offset = "0xBC103C", VA = "0xBC103C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x20")]
		[ColorUsage(false, true)]
		[FormerlySerializedAs("colorValue")]
		public Color color;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x3C")]
		[FormerlySerializedAs("alphaInside")]
		[Range(0f, 8f)]
		public float intensityInside;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("alphaOutside")]
		[FormerlySerializedAs("alpha")]
		[Range(0f, 8f)]
		public float intensityOutside;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("angleFromLight")]
		public bool spotAngleFromLight;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0.1f, 179.9f)]
		public float spotAngle;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x50")]
		[FormerlySerializedAs("radiusStart")]
		public float coneRadiusStart;

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x54")]
		public ShaderAccuracy shaderAccuracy;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x58")]
		public MeshType geomMeshType;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x5C")]
		[FormerlySerializedAs("geomSides")]
		public int geomCustomSides;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x60")]
		public int geomCustomSegments;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x64")]
		public Vector3 skewingLocalForwardDirection;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x70")]
		public Transform clippingPlaneTransform;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x78")]
		public bool geomCap;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x79")]
		[FormerlySerializedAs("fadeEndFromLight")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x7C")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float attenuationCustomBlending;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x84")]
		[FormerlySerializedAs("fadeStart")]
		public float fallOffStart;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x88")]
		[FormerlySerializedAs("fadeEnd")]
		public float fallOffEnd;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x8C")]
		public float depthBlendDistance;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x90")]
		public float cameraClippingDistance;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x94")]
		[Range(0f, 1f)]
		public float glareFrontal;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x98")]
		[Range(0f, 1f)]
		public float glareBehind;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x9C")]
		[FormerlySerializedAs("fresnelPowOutside")]
		public float fresnelPow;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0xA0")]
		public NoiseMode noiseMode;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0xA4")]
		[Range(0f, 1f)]
		public float noiseIntensity;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0xA8")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0xAC")]
		[Range(0.01f, 2f)]
		public float noiseScaleLocal;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0xB0")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0xB4")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0xC0")]
		public Dimensions dimensions;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0xC4")]
		public Vector2 tiltFactor;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_IsDynamicOcclusionEnabled;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0xE0")]
		private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[FormerlySerializedAs("trackChangesDuringPlaytime")]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[FormerlySerializedAs("fadeOutBegin")]
		private float _FadeOutBegin;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0xFC")]
		[FormerlySerializedAs("fadeOutEnd")]
		[SerializeField]
		private float _FadeOutEnd;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x108")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x110")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x118")]
		private Light _CachedLight;

		[Token(Token = "0x1700002F")]
		public ColorMode usedColorMode
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0xBB7134", Offset = "0xBB7134", VA = "0xBB7134")]
			get
			{
				return default(ColorMode);
			}
		}

		[Token(Token = "0x17000030")]
		[Obsolete("Use 'intensityGlobal' or 'intensityInside' instead")]
		public float alphaInside
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0xBBFAD8", Offset = "0xBBFAD8", VA = "0xBBFAD8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0xBBFAE0", Offset = "0xBBFAE0", VA = "0xBBFAE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		[Obsolete("Use 'intensityGlobal' or 'intensityOutside' instead")]
		public float alphaOutside
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0xBBFAE8", Offset = "0xBBFAE8", VA = "0xBBFAE8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0xBBFAF0", Offset = "0xBBFAF0", VA = "0xBBFAF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public float intensityGlobal
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0xBBFAF8", Offset = "0xBBFAF8", VA = "0xBBFAF8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0xBBFB00", Offset = "0xBBFB00", VA = "0xBBFB00")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public float coneAngle
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0xBB7048", Offset = "0xBB7048", VA = "0xBB7048")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000034")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0xBB618C", Offset = "0xBB618C", VA = "0xBB618C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000035")]
		public float coneVolume
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0xBBFB08", Offset = "0xBBFB08", VA = "0xBBFB08")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000036")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0xBB70BC", Offset = "0xBB70BC", VA = "0xBB70BC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000037")]
		public int geomSides
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0xBBE33C", Offset = "0xBBE33C", VA = "0xBBE33C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000128")]
			[Address(RVA = "0xBBFB84", Offset = "0xBBFB84", VA = "0xBBFB84")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public int geomSegments
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0xBBFC00", Offset = "0xBBFC00", VA = "0xBBFC00")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600012A")]
			[Address(RVA = "0xBBFC38", Offset = "0xBBFC38", VA = "0xBBFC38")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public Vector3 skewingLocalForwardDirectionNormalized
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0xBB74F4", Offset = "0xBB74F4", VA = "0xBB74F4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003A")]
		public Vector4 additionalClippingPlane
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0xBB7274", Offset = "0xBB7274", VA = "0xBB7274")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x1700003B")]
		public bool canHaveMeshSkewing
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0xBBD82C", Offset = "0xBBD82C", VA = "0xBBD82C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public bool hasMeshSkewing
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0xBB6498", Offset = "0xBB6498", VA = "0xBB6498")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		[Obsolete("Use 'fallOffEndFromLight' instead")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0xBBFCB4", Offset = "0xBBFCB4", VA = "0xBBFCB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000130")]
			[Address(RVA = "0xBBFCBC", Offset = "0xBBFCBC", VA = "0xBBFCBC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0xBB724C", Offset = "0xBB724C", VA = "0xBB724C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003F")]
		[Obsolete("Use 'fallOffStart' instead")]
		public float fadeStart
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0xBBFCC8", Offset = "0xBBFCC8", VA = "0xBBFCC8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0xBBFCD0", Offset = "0xBBFCD0", VA = "0xBBFCD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		[Obsolete("Use 'fallOffEnd' instead")]
		public float fadeEnd
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0xBBFCD8", Offset = "0xBBFCD8", VA = "0xBBFCD8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0xBBFCE0", Offset = "0xBBFCE0", VA = "0xBBFCE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public float maxGeometryDistance
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0xBB61DC", Offset = "0xBB61DC", VA = "0xBB61DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000042")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0xBB3AEC", Offset = "0xBB3AEC", VA = "0xBB3AEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		[Obsolete("Use 'noiseMode' instead")]
		public bool noiseEnabled
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0xBBFCE8", Offset = "0xBBFCE8", VA = "0xBBFCE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0xBBFCF8", Offset = "0xBBFCF8", VA = "0xBBFCF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public float fadeOutBegin
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0xBBFD14", Offset = "0xBBFD14", VA = "0xBBFD14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0xBBFD1C", Offset = "0xBBFD1C", VA = "0xBBFD1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public float fadeOutEnd
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0xBBFD78", Offset = "0xBBFD78", VA = "0xBBFD78")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600013D")]
			[Address(RVA = "0xBBFD80", Offset = "0xBBFD80", VA = "0xBBFD80")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0xBB3CF8", Offset = "0xBB3CF8", VA = "0xBB3CF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		public bool isTilted
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0xBBFD88", Offset = "0xBBFD88", VA = "0xBBFD88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0xBBFDF0", Offset = "0xBBFDF0", VA = "0xBBFDF0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0xBBFDF8", Offset = "0xBBFDF8", VA = "0xBBFDF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public string sortingLayerName
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0xBBFE98", Offset = "0xBBFE98", VA = "0xBBFE98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0xBBFEA4", Offset = "0xBBFEA4", VA = "0xBBFEA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public int sortingOrder
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0xBBFEC8", Offset = "0xBBFEC8", VA = "0xBBFEC8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0xBBFED0", Offset = "0xBBFED0", VA = "0xBBFED0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0xBBFF70", Offset = "0xBBFF70", VA = "0xBBFF70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0xBBFF78", Offset = "0xBBFF78", VA = "0xBBFF78")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0xBBFFEC", Offset = "0xBBFFEC", VA = "0xBBFFEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		public bool hasGeometry
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0xBBF8D0", Offset = "0xBBF8D0", VA = "0xBBF8D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		public Bounds bounds
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xBBF930", Offset = "0xBBF930", VA = "0xBBF930")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x1700004F")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xBBFFFC", Offset = "0xBBFFFC", VA = "0xBBFFFC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000050")]
		public Quaternion beamInternalLocalRotation
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0xBB61FC", Offset = "0xBB61FC", VA = "0xBB61FC")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000051")]
		public Vector3 beamLocalForward
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0xBB9CA0", Offset = "0xBB9CA0", VA = "0xBB9CA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000052")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0xBB9D3C", Offset = "0xBB9D3C", VA = "0xBB9D3C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000053")]
		public float raycastDistance
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0xBBAA08", Offset = "0xBBAA08", VA = "0xBBAA08")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000054")]
		public Vector3 raycastGlobalForward
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0xBBB8F8", Offset = "0xBBB8F8", VA = "0xBBB8F8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000055")]
		public Vector3 raycastGlobalUp
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0xBBB33C", Offset = "0xBBB33C", VA = "0xBBB33C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000056")]
		public Vector3 raycastGlobalRight
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0xBBB3AC", Offset = "0xBBB3AC", VA = "0xBBB3AC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000057")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0xBC00D4", Offset = "0xBC00D4", VA = "0xBC00D4")]
			[CompilerGenerated]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0xBC00DC", Offset = "0xBC00DC", VA = "0xBC00DC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public MaterialManager.DynamicOcclusion _INTERNAL_EnabledDynamicOcclusionMode
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0xBB6480", Offset = "0xBB6480", VA = "0xBB6480")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
		}

		[Token(Token = "0x17000059")]
		public int _INTERNAL_pluginVersion
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0xBC0120", Offset = "0xBC0120", VA = "0xBC0120")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005A")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0xBC01BC", Offset = "0xBC01BC", VA = "0xBC01BC")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0xBC01C4", Offset = "0xBC01C4", VA = "0xBC01C4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public string meshStats
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0xBC01CC", Offset = "0xBC01CC", VA = "0xBC01CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public int meshVerticesCount
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0xBC036C", Offset = "0xBC036C", VA = "0xBC036C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005D")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0xBC0424", Offset = "0xBC0424", VA = "0xBC0424")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005E")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0xBC04F8", Offset = "0xBC04F8", VA = "0xBC04F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0xBB93CC", Offset = "0xBB93CC", VA = "0xBB93CC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0xBB967C", Offset = "0xBB967C", VA = "0xBB967C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xBB7220", Offset = "0xBB7220", VA = "0xBB7220")]
		public void GetInsideAndOutsideIntensity(out float inside, out float outside)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xBB8FD0", Offset = "0xBB8FD0", VA = "0xBB8FD0")]
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xBB7DBC", Offset = "0xBB7DBC", VA = "0xBB7DBC")]
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xBB9510", Offset = "0xBB9510", VA = "0xBB9510")]
		public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xBC00E4", Offset = "0xBC00E4", VA = "0xBC00E4")]
		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xBBFD24", Offset = "0xBBFD24", VA = "0xBBFD24")]
		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xBC0128", Offset = "0xBC0128", VA = "0xBC0128")]
		private void OnFadeOutStateChanged()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xBC05EC", Offset = "0xBC05EC", VA = "0xBC05EC")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xBB7DD8", Offset = "0xBB7DD8", VA = "0xBB7DD8")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xBC0640", Offset = "0xBC0640", VA = "0xBC0640")]
		[Obsolete("Use 'GenerateGeometry()' instead")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xBC064C", Offset = "0xBC064C", VA = "0xBC064C", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xBC08F0", Offset = "0xBC08F0", VA = "0xBC08F0", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xBC0974", Offset = "0xBC0974", VA = "0xBC0974")]
		private void Start()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xBC0980", Offset = "0xBC0980", VA = "0xBC0980")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xBC0A08", Offset = "0xBC0A08", VA = "0xBC0A08")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xBBFF84", Offset = "0xBBFF84", VA = "0xBBFF84")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xBC0A98", Offset = "0xBC0A98", VA = "0xBC0A98")]
		[IteratorStateMachine(typeof(<CoPlaytimeUpdate>d__184))]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xBC0B34", Offset = "0xBC0B34", VA = "0xBC0B34")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xBC0B38", Offset = "0xBC0B38", VA = "0xBC0B38")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xBC0BE4", Offset = "0xBC0BE4", VA = "0xBC0BE4")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xBC0CD4", Offset = "0xBC0CD4", VA = "0xBC0CD4")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xBC08CC", Offset = "0xBC08CC", VA = "0xBC08CC")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xBC076C", Offset = "0xBC076C", VA = "0xBC076C")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xBC0E04", Offset = "0xBC0E04", VA = "0xBC0E04")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x2000043")]
	[RequireComponent(typeof(Camera))]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xBC1084", Offset = "0xBC1084", VA = "0xBC1084")]
		private void Update()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xBC1144", Offset = "0xBC1144", VA = "0xBC1144")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[RequireComponent(typeof(Collider), typeof(Rigidbody), typeof(MeshRenderer))]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x18")]
		private bool isInsideBeam;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xBC1154", Offset = "0xBC1154", VA = "0xBC1154")]
		private void Start()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xBC1244", Offset = "0xBC1244", VA = "0xBC1244")]
		private void Update()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xBC12F8", Offset = "0xBC12F8", VA = "0xBC12F8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xBC1300", Offset = "0xBC1300", VA = "0xBC1300")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xBC13B8", Offset = "0xBC13B8", VA = "0xBC13B8")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x600018B")]
		[Address(RVA = "0xBC13C0", Offset = "0xBC13C0", VA = "0xBC13C0")]
		private void Start()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xBC1428", Offset = "0xBC1428", VA = "0xBC1428")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x17000061")]
		private bool useMouseView
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0xBC1430", Offset = "0xBC1430", VA = "0xBC1430")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0xBC1438", Offset = "0xBC1438", VA = "0xBC1438")]
			set
			{
			}
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xBC1468", Offset = "0xBC1468", VA = "0xBC1468")]
		private void Start()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xBC14F8", Offset = "0xBC14F8", VA = "0xBC14F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xBC1AD4", Offset = "0xBC1AD4", VA = "0xBC1AD4")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x18")]
		[Range(1f, 100f)]
		[SerializeField]
		private int CountX;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x1C")]
		[Range(1f, 100f)]
		[SerializeField]
		private int CountY;

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xBC1AF8", Offset = "0xBC1AF8", VA = "0xBC1AF8")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xBC216C", Offset = "0xBC216C", VA = "0xBC216C")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("m_EulerSpeed")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xBC2188", Offset = "0xBC2188", VA = "0xBC2188")]
		private void Update()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xBC2258", Offset = "0xBC2258", VA = "0xBC2258")]
		public Rotater()
		{
		}
	}
}
